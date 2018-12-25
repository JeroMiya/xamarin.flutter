using Android.Util;
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

        private IBinaryMessenger messenger;
        private readonly string name;
        private readonly IMethodCodec codec;

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger}
         * and with the specified name and the standard {@link MethodCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         */
        public EventChannel(IBinaryMessenger messenger, string name) : this(messenger, name, StandardMethodCodec.Instance)
        {

        }

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
            this.messenger = messenger;
            this.name = name;
            this.codec = codec;
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
        public void setStreamHandler(StreamHandler handler)
        {
            messenger.SetMessageHandler(name, handler == null ? null : new IncomingStreamRequestHandler(handler, this));
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
        public interface StreamHandler
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
            void onListen(object arguments, EventSink events);

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
            void onCancel(object arguments);
        }

        /**
         * Event callback. Supports dual use: Producers of events to be sent to Flutter
         * act as clients of this interface for sending events. Consumers of events sent
         * from Flutter implement this interface for handling received events (the latter
         * facility has not been implemented yet).
         */
        public interface EventSink
        {
            /**
             * Consumes a successful event.
             *
             * @param event the event, possibly null.
             */
            void success(object @event);

            /**
             * Consumes an error event.
             *
             * @param errorCode an error code String.
             * @param errorMessage a human-readable error message String, possibly null.
             * @param errorDetails error details, possibly null
             */
            void error(string errorCode, string errorMessage, object errorDetails);

            /**
             * Consumes end of stream. Ensuing calls to {@link #success(Object)} or
             * {@link #error(String, String, Object)}, if any, are ignored.
             */
            void endOfStream();
        }

        private class IncomingStreamRequestHandler : IBinaryMessageHandler
        {
            private StreamHandler handler;

            //TODO: Concurrency
            //private AtomicReference<EventSink> activeSink = new AtomicReference<EventSink>(null);
            private EventSink activeSink = null;
            private EventChannel _parent = null;

            public IncomingStreamRequestHandler(StreamHandler handler, EventChannel parent)
            {
                this.handler = handler;
                _parent = parent;
            }

            //@Override
            // TODO: ByteBuffer->object
            public void OnMessage(object message, IBinaryReply reply)
            {
                MethodCall call = _parent.codec.DecodeMethodCall(message);
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
                EventSink eventSink = new EventSinkImplementation(this);
                EventSink oldSink = activeSink;
                activeSink = eventSink;

                if (oldSink != null)
                {
                    // Repeated calls to onListen may happen during hot restart.
                    // We separate them with a call to onCancel.
                    try
                    {
                        handler.onCancel(null);
                    }
                    catch (Exception e)
                    {
                        Log.Error(TAG + _parent.name, "Failed to close existing event stream", e);
                    }
                }
                try
                {
                    handler.onListen(arguments, eventSink);
                    callback.Reply(_parent.codec.EncodeSuccessEnvelope(null));
                }
                catch (RuntimeException e)
                {
                    activeSink = null;
                    Log.Error(TAG + _parent.name, "Failed to open event stream", e);
                    callback.Reply(_parent.codec.EncodeErrorEnvelope("error", e.Message, null));
                }
            }

            private void OnCancel(object arguments, IBinaryReply callback)
            {
                EventSink oldSink = activeSink;
                activeSink = null;

                if (oldSink != null)
                {
                    try
                    {
                        handler.onCancel(arguments);
                        callback.Reply(_parent.codec.EncodeSuccessEnvelope(null));
                    }
                    catch (RuntimeException e)
                    {
                        Log.Error(TAG + _parent.name, "Failed to close event stream", e);
                        callback.Reply(_parent.codec.EncodeErrorEnvelope("error", e.Message, null));
                    }
                }
                else
                {
                    callback.Reply(_parent.codec.EncodeErrorEnvelope("error", "No active stream to cancel", null));
                }
            }

            private class EventSinkImplementation : EventSink
            {
                //TODO: Concurrency
                //AtomicBoolean hasEnded = new AtomicBoolean(false);
                private bool hasEnded = false;
                private IncomingStreamRequestHandler _incomingStreamRequestHandler;
                public EventSinkImplementation(IncomingStreamRequestHandler incomingStreamRequestHandler)
                {
                    _incomingStreamRequestHandler = incomingStreamRequestHandler;
                }

                //@Override
                public void success(object @event)
                {
                    if (hasEnded || _incomingStreamRequestHandler.activeSink != this)
                    {
                        return;
                    }
                    _incomingStreamRequestHandler._parent.messenger.Send(
                        _incomingStreamRequestHandler._parent.name, 
                        _incomingStreamRequestHandler._parent.codec.EncodeSuccessEnvelope(@event));
                }

                //@Override
                public void error(string errorCode, string errorMessage, object errorDetails)
                {
                    if (hasEnded || _incomingStreamRequestHandler.activeSink != this)
                        return;

                    _incomingStreamRequestHandler._parent.messenger.Send(
                        _incomingStreamRequestHandler._parent.name,
                        _incomingStreamRequestHandler._parent.codec.EncodeErrorEnvelope(errorCode, errorMessage, errorDetails));
                }

                //@Override
                public void endOfStream()
                {
                    var hadEnded = hasEnded;
                    hasEnded = true;
                    if (hadEnded || _incomingStreamRequestHandler.activeSink != this)
                        return;

                    _incomingStreamRequestHandler._parent.messenger.Send(
                        _incomingStreamRequestHandler._parent.name, null);
                }
            }
        }
    }

}