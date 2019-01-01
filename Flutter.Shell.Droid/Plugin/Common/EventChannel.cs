using Android.Util;
using FlutterBinding.Plugin.Common;
using Java.Lang;
using Exception = System.Exception;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
 * A named channel for communicating with the Flutter application using asynchronous
 * event streams.
 *
 * <p>Incoming requests for event stream setup are decoded from binary on receipt, and
 * Java responses and events are encoded into binary before being transmitted back
 * to Flutter. The {@link MethodCodec} used must be compatible with the one used by
 * the Flutter application. This can be achieved by creating an
 * <a href="https://docs.flutter.io/flutter/services/EventChannel-class.html">EventChannel</a>
 * counterpart of this channel on the Dart side. The Java type of stream configuration arguments,
 * events, and error details is {@code Object}, but only values supported by the specified
 * {@link MethodCodec} can be used.</p>
 *
 * <p>The logical identity of the channel is given by its name. Identically named channels will interfere
 * with each other's communication.</p>
 */
    public class EventChannel
    {
        private static readonly string TAG = "EventChannel#";

        private IBinaryMessenger Messenger { get; }
        private string Name { get; }
        private IMethodCodec Codec { get; }

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger}
         * and with the specified name and the standard {@link MethodCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         */
        public EventChannel(IBinaryMessenger messenger, string name) : this(messenger, name, StandardMethodCodec.Instance) { }

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger}
         * and with the specified name and {@link MethodCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         * @param codec a {@link MessageCodec}.
         */
        public EventChannel(IBinaryMessenger messenger, string name, IMethodCodec codec)
        {
            //assert messenger != null;
            //assert name != null;
            //assert codec != null;
            Messenger = messenger;
            Name      = name;
            Codec     = codec;
        }

        /**
         * Registers a stream handler on this channel.
         *
         * <p>Overrides any existing handler registration for (the name of) this channel.</p>
         *
         * <p>If no handler has been registered, any incoming stream setup requests will be handled
         * silently by providing an empty stream.</p>
         *
         * @param handler a {@link StreamHandler}, or null to deregister.
         */
        public void SetStreamHandler(IStreamHandler handler)
        {
            Messenger.SetMessageHandler(Name, handler == null ? null : new IncomingStreamRequestHandler(handler, this));
        }

        /**
         * Handler of stream setup and tear-down requests.
         *
         * <p>Implementations must be prepared to accept sequences of alternating calls to
         * {@link #onListen(Object, EventSink)} and {@link #onCancel(Object)}. Implementations
         * should ideally consume no resources when the last such call is not {@code onListen}.
         * In typical situations, this means that the implementation should register itself
         * with platform-specific event sources {@code onListen} and deregister again
         * {@code onCancel}.</p>
         */
        public interface IStreamHandler
        {
            /**
             * Handles a request to set up an event stream.
             *
             * <p>Any uncaught exception thrown by this method will be caught by the channel
             * implementation and logged. An error result message will be sent back to Flutter.</p>
             *
             * @param arguments stream configuration arguments, possibly null.
             * @param events an {@link EventSink} for emitting events to the Flutter receiver.
             */
            void OnListen(object arguments, IEventSink events);

            /**
             * Handles a request to tear down the most recently created event stream.
             *
             * <p>Any uncaught exception thrown by this method will be caught by the channel
             * implementation and logged. An error result message will be sent back to Flutter.</p>
             *
             * <p>The channel implementation may call this method with null arguments
             * to separate a pair of two consecutive set up requests. Such request pairs
             * may occur during Flutter hot restart. Any uncaught exception thrown
             * in this situation will be logged without notifying Flutter.</p>
             *
             * @param arguments stream configuration arguments, possibly null.
             */
            void OnCancel(object arguments);
        }

        /**
         * Event callback. Supports dual use: Producers of events to be sent to Flutter
         * act as clients of this interface for sending events. Consumers of events sent
         * from Flutter implement this interface for handling received events (the latter
         * facility has not been implemented yet).
         */
        public interface IEventSink
        {
            /**
             * Consumes a successful event.
             *
             * @param event the event, possibly null.
             */
            void Success(object @event);

            /**
             * Consumes an error event.
             *
             * @param errorCode an error code String.
             * @param errorMessage a human-readable error message String, possibly null.
             * @param errorDetails error details, possibly null
             */
            void Error(string errorCode, string errorMessage, object errorDetails);

            /**
             * Consumes end of stream. Ensuing calls to {@link #success(Object)} or
             * {@link #error(String, String, Object)}, if any, are ignored.
             */
            void EndOfStream();
        }

        private class IncomingStreamRequestHandler : IBinaryMessageHandler
        {
            private IStreamHandler Handler { get; }

            //TODO: Concurrency
            //private AtomicReference<EventSink> activeSink = new AtomicReference<EventSink>(null);
            private IEventSink ActiveSink { get; set; }
            private EventChannel _parent { get; }

            public IncomingStreamRequestHandler(IStreamHandler handler, EventChannel parent)
            {
                Handler = handler;
                _parent      = parent;
            }

            //@Override
            // TODO: ByteBuffer->object
            public void OnMessage(object message, IBinaryReply reply)
            {
                MethodCall call = _parent.Codec.DecodeMethodCall(message);
                if (call.Method.Equals("listen"))
                {
                    OnListen(call.Arguments, reply);
                }
                else if (call.Method.Equals("cancel"))
                {
                    OnCancel(call.Arguments, reply);
                }
                else
                {
                    reply.Reply(null);
                }
            }

            private void OnListen(object arguments, IBinaryReply callback)
            {
                IEventSink eventSink = new EventSinkImplementation(this);
                IEventSink oldSink = ActiveSink;
                ActiveSink = eventSink;

                if (oldSink != null)
                {
                    // Repeated calls to onListen may happen during hot restart.
                    // We separate them with a call to onCancel.
                    try
                    {
                        Handler.OnCancel(null);
                    }
                    catch (Exception e)
                    {
                        Log.Error(TAG + _parent.Name, "Failed to close existing event stream", e);
                    }
                }

                try
                {
                    Handler.OnListen(arguments, eventSink);
                    callback.Reply(_parent.Codec.EncodeSuccessEnvelope(null));
                }
                catch (RuntimeException e)
                {
                    ActiveSink = null;
                    Log.Error(TAG + _parent.Name, "Failed to open event stream", e);
                    callback.Reply(_parent.Codec.EncodeErrorEnvelope("error", e.Message, null));
                }
            }

            private void OnCancel(object arguments, IBinaryReply callback)
            {
                IEventSink oldSink = ActiveSink;
                ActiveSink = null;

                if (oldSink != null)
                {
                    try
                    {
                        Handler.OnCancel(arguments);
                        callback.Reply(_parent.Codec.EncodeSuccessEnvelope(null));
                    }
                    catch (RuntimeException e)
                    {
                        Log.Error(TAG + _parent.Name, "Failed to close event stream", e);
                        callback.Reply(_parent.Codec.EncodeErrorEnvelope("error", e.Message, null));
                    }
                }
                else
                {
                    callback.Reply(_parent.Codec.EncodeErrorEnvelope("error", "No active stream to cancel", null));
                }
            }

            private class EventSinkImplementation : IEventSink
            {
                //TODO: Concurrency
                //AtomicBoolean hasEnded = new AtomicBoolean(false);
                private bool HasEnded { get; set; }
                private IncomingStreamRequestHandler _incomingStreamRequestHandler;

                public EventSinkImplementation(IncomingStreamRequestHandler incomingStreamRequestHandler)
                {
                    _incomingStreamRequestHandler = incomingStreamRequestHandler;
                }

                //@Override
                public void Success(object @event)
                {
                    if (HasEnded || _incomingStreamRequestHandler.ActiveSink != this)
                    {
                        return;
                    }

                    _incomingStreamRequestHandler._parent.Messenger.Send(
                        _incomingStreamRequestHandler._parent.Name,
                        _incomingStreamRequestHandler._parent.Codec.EncodeSuccessEnvelope(@event));
                }

                //@Override
                public void Error(string errorCode, string errorMessage, object errorDetails)
                {
                    if (HasEnded || _incomingStreamRequestHandler.ActiveSink != this)
                        return;

                    _incomingStreamRequestHandler._parent.Messenger.Send(
                        _incomingStreamRequestHandler._parent.Name,
                        _incomingStreamRequestHandler._parent.Codec.EncodeErrorEnvelope(errorCode, errorMessage, errorDetails));
                }

                //@Override
                public void EndOfStream()
                {
                    var hadEnded = HasEnded;
                    HasEnded = true;
                    if (hadEnded || _incomingStreamRequestHandler.ActiveSink != this)
                        return;

                    _incomingStreamRequestHandler._parent.Messenger.Send(
                        _incomingStreamRequestHandler._parent.Name,
                        null);
                }
            }
        }
    }
}
