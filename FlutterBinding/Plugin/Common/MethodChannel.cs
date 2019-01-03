using System;
using FlutterBinding.Engine;

namespace FlutterBinding.Plugin.Common
{
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
        public MethodChannel(
            IBinaryMessenger messenger,
            string name)
            : this(
                messenger,
                name,
                StandardMethodCodec.Instance) { }

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
            Messenger = messenger;
            Name      = name;
            Codec     = codec;
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
            Messenger.Send(
                Name,
                Codec.EncodeMethodCall(new MethodCall(method, arguments)),
                callback == null ? null : new IncomingResultHandler(callback, Codec, Name));
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
        public void SetMethodCallHandler( /* @Nullable */ IMethodCallHandler handler)
        {
            Messenger.SetMessageHandler(
                Name,
                handler == null ? null : new IncomingMethodCallHandler(handler, Codec, Name));
        }

        public class IncomingResultHandler : IBinaryReply
        {
            private readonly IResult _callback;
            private readonly IMethodCodec _codec;
            private readonly string _name;

            public IncomingResultHandler(IResult callback, IMethodCodec codec, string name)
            {
                _callback = callback;
                _codec    = codec;
                _name     = name;
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
                catch (Exception e)
                {
                    FLog.Error(TAG + _name, "Failed to handle method call result", e);
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
            _codec   = codec;
            _name    = name;
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
            catch (Exception e)
            {
                FLog.Error("MethodChannel#" + _name, "Failed to handle method call", e);
                reply.Reply(_codec.EncodeErrorEnvelope("error", e.Message, null));
            }
        }
    }
}
