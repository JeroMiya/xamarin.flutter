using Android.Util;
using FlutterBinding.Engine;
using Java.Lang;
using System;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A handler of incoming method calls.
     */
    public interface IMethodCallHandler
    {
        /**
         * Handles the specified method call received from Flutter.
         *
         * <p>Handler implementations must submit a result for all incoming calls, by making a single call
         * on the given {@link Result} callback. Failure to do so will result in lingering Flutter result
         * handlers. The result may be submitted asynchronously. Calls to unknown or unimplemented methods
         * should be handled using {@link Result#notImplemented()}.</p>
         *
         * <p>Any uncaught exception thrown by this method will be caught by the channel implementation and
         * logged, and an error result will be sent back to Flutter.</p>
         *
         * <p>The handler is called on the platform thread (Android main thread). For more details see
         * <a href="https://github.com/flutter/engine/wiki/Threading-in-the-Flutter-Engine">Threading in the Flutter
         * Engine</a>.</p>
         *
         * @param call A {@link MethodCall}.
         * @param result A {@link Result} used for submitting the result of the call.
         */
        void OnMethodCall(MethodCall call, IResult result);
    }

    /**
     * Method call result callback. Supports dual use: Implementations of methods
     * to be invoked by Flutter act as clients of this interface for sending results
     * back to Flutter. Invokers of Flutter methods provide implementations of this
     * interface for handling results received from Flutter.
     *
     * <p>All methods of this class must be called on the platform thread (Android main thread). For more details see
     * <a href="https://github.com/flutter/engine/wiki/Threading-in-the-Flutter-Engine">Threading in the Flutter
     * Engine</a>.</p>
     */
    public interface IResult
    {
        /**
         * Handles a successful result.
         *
         * @param result The result, possibly null.
         */
        void Success( /* @Nullable */ object result);

        /**
         * Handles an error result.
         *
         * @param errorCode An error code String.
         * @param errorMessage A human-readable error message String, possibly null.
         * @param errorDetails Error details, possibly null
         */
        void Error(string errorCode, /* @Nullable */ string errorMessage, /* @Nullable */ object errorDetails);

        /**
         * Handles a call to an unimplemented method.
         */
        void NotImplemented();
    }

    public class ResultImpl : IResult
    {
        public Action<object> OnSuccess;
        public Action<string, string, object> OnError;
        public Action OnNotImplemented;

        /// <inheritdoc />
        public void Success(object result)
        {
            OnSuccess?.Invoke(result);
        }

        /// <inheritdoc />
        public void Error(string errorCode, string errorMessage, object errorDetails)
        {
            OnError?.Invoke(errorCode, errorMessage, errorDetails);
        }

        /// <inheritdoc />
        public void NotImplemented()
        {
            OnNotImplemented?.Invoke();
        }
    }

    /**
     * A named channel for communicating with the Flutter application using asynchronous
     * method calls.
     *
     * <p>Incoming method calls are decoded from binary on receipt, and Java results are encoded
     * into binary before being transmitted back to Flutter. The {@link MethodCodec} used must be
     * compatible with the one used by the Flutter application. This can be achieved
     * by creating a
     * <a href="https://docs.flutter.io/flutter/services/MethodChannel-class.html">MethodChannel</a>
     * counterpart of this channel on the Dart side. The Java type of method call arguments and results is
     * {@code Object}, but only values supported by the specified {@link MethodCodec} can be used.</p>
     *
     * <p>The logical identity of the channel is given by its name. Identically named channels will interfere
     * with each other's communication.</p>
     */
    public sealed class MethodChannel
    {
        private static readonly string TAG = "MethodChannel#";

        private readonly IBinaryMessenger _messenger;
        private readonly string _name;
        private readonly IMethodCodec _codec;

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger}
         * and with the specified name and the standard {@link MethodCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         */
        public MethodChannel(
            IBinaryMessenger messenger,
            string name)
            : this(
                messenger,
                name,
                StandardMethodCodec.Instance)
        {
        }

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger} and with the
         * specified name and {@link MethodCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         * @param codec a {@link MessageCodec}.
         */
        public MethodChannel(IBinaryMessenger messenger, string name, IMethodCodec codec)
        {
            //assert messenger != null;
            //assert name != null;
            //assert codec != null;
            _messenger = messenger;
            _name = name;
            _codec = codec;
        }

        /**
         * Invokes a method on this channel, expecting no result.
         *
         * @param method the name String of the method.
         * @param arguments the arguments for the invocation, possibly null.
         */
        public void InvokeMethod(string method, /*@Nullable*/ object arguments)
        {
            InvokeMethod(method, arguments, null);
        }

        /**
         * Invokes a method on this channel, optionally expecting a result.
         *
         * <p>Any uncaught exception thrown by the result callback will be caught and logged.</p>
         *
         * @param method the name String of the method.
         * @param arguments the arguments for the invocation, possibly null.
         * @param callback a {@link Result} callback for the invocation result, or null.
         */
        public void InvokeMethod(string method, /* @Nullable */ object arguments, IResult callback)
        {
            _messenger.Send(
                _name,
                _codec.EncodeMethodCall(new MethodCall(method, arguments)),
                callback == null ? null : new IncomingResultHandler(callback, _codec, _name));
        }

        /**
         * Registers a method call handler on this channel.
         *
         * <p>Overrides any existing handler registration for (the name of) this channel.</p>
         *
         * <p>If no handler has been registered, any incoming method call on this channel will be handled
         * silently by sending a null reply. This results in a
         * <a href="https://docs.flutter.io/flutter/services/MissingPluginException-class.html">MissingPluginException</a>
         * on the Dart side, unless an
         * <a href="https://docs.flutter.io/flutter/services/OptionalMethodChannel-class.html">OptionalMethodChannel</a>
         * is used.</p>
         *
         * @param handler a {@link MethodCallHandler}, or null to deregister.
         */
        public void SetMethodCallHandler(/* @Nullable */ IMethodCallHandler handler)
        {
            _messenger.SetMessageHandler(
                _name,
                handler == null ? null : new IncomingMethodCallHandler(handler, _codec, _name));
        }

        public class IncomingResultHandler : IBinaryReply
        {
            private readonly IResult _callback;
            private readonly IMethodCodec _codec;
            private readonly string _name;

            public IncomingResultHandler(IResult callback, IMethodCodec codec, string name)
            {
                _callback = callback;
                _codec = codec;
                _name = name;
            }

            //@Override
            // TODO: ByteBuffer->object
            public void Reply(object reply)
            {
                try
                {
                    if (reply == null)
                    {
                        _callback.NotImplemented();
                    }
                    else
                    {
                        try
                        {
                            _callback.Success(_codec.DecodeEnvelope(reply));
                        }
                        catch (FlutterException e)
                        {
                            _callback.Error(e.code, e.Message, e.details);
                        }
                    }
                }
                catch (RuntimeException e)
                {
                    Log.Error(TAG + _name, "Failed to handle method call result", e);
                }
            }
        }
    }

    public class IncomingMethodCallHandler : IBinaryMessageHandler
    {

        private readonly IMethodCallHandler _handler;
        private readonly IMethodCodec _codec;
        private readonly string _name;

        public IncomingMethodCallHandler(IMethodCallHandler handler, IMethodCodec codec, string name)
        {
            _handler = handler;
            _codec = codec;
            _name = name;
        }

        //@Override
        //TODO: ByteBuffer->object
        public void OnMessage(object message, IBinaryReply reply)
        {
            MethodCall call = _codec.DecodeMethodCall(message);
            try
            {
                _handler.OnMethodCall(
                    call,
                    new ResultImpl
                    {
                        OnSuccess = result => reply.Reply(_codec.EncodeSuccessEnvelope(result)),
                        OnError = (errorCode, errorMessage, errorDetails) =>
                            reply.Reply(_codec.EncodeErrorEnvelope(errorCode, errorMessage, errorDetails)),
                        OnNotImplemented = () => reply.Reply(null)
                    });
            }
            catch (RuntimeException e)
            {
                Log.Error("MethodChannel#" + _name, "Failed to handle method call", e);
                reply.Reply(_codec.EncodeErrorEnvelope("error", e.Message, null));
            }
        }
    }

}