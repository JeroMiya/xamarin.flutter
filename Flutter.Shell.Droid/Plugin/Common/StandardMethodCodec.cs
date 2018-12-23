using FlutterBinding.Engine;
using Java.Lang;
using Java.Nio;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A {@link MethodCodec} using the Flutter standard binary encoding.
     *
     * <p>This codec is guaranteed to be compatible with the corresponding
     * <a href="https://docs.flutter.io/flutter/services/StandardMethodCodec-class.html">StandardMethodCodec</a>
     * on the Dart side. These parts of the Flutter SDK are evolved synchronously.</p>
     *
     * <p>Values supported as method arguments and result payloads are those supported by
     * {@link StandardMessageCodec}.</p>
     */
    public sealed class StandardMethodCodec : IMethodCodec
    {
        public static readonly StandardMethodCodec Instance = new StandardMethodCodec(StandardMessageCodec.Instance);
        private StandardMessageCodec _messageCodec;

        /**
         * Creates a new method codec based on the specified message codec.
         */
        public StandardMethodCodec(StandardMessageCodec messageCodec)
        {
            _messageCodec = messageCodec;
        }

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeMethodCall(MethodCall methodCall)
        {
            return methodCall;
        }

        //@Override
        // TODO: ByteBuffer->object
        public MethodCall DecodeMethodCall(object methodCall)
        {
            return (MethodCall)methodCall;
        }

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeSuccessEnvelope(object result)
        {
            return result;
        }

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeErrorEnvelope(string errorCode, string errorMessage, object errorDetails)
        {
            return new ErrorEnvelope
            {
                ErrorCode = errorCode,
                ErrorMessage = errorMessage,
                ErrorDetails = errorDetails
            };
        }

        //@Override
        // TODO: ByteBuffer->object
        public object DecodeEnvelope(object envelope)
        {
            if (envelope is ErrorEnvelope errorEnvelope)
                return errorEnvelope;
            return envelope;
        }
    }

    public class ErrorEnvelope
    {
        public string ErrorCode;
        public string ErrorMessage;
        public object ErrorDetails;
    }
}