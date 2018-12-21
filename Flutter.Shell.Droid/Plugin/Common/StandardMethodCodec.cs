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
    public sealed class StandardMethodCodec : MethodCodec
    {
        public static StandardMethodCodec INSTANCE = new StandardMethodCodec(StandardMessageCodec.INSTANCE);
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

            //ExposedByteArrayOutputStream stream = new ExposedByteArrayOutputStream();
            //messageCodec.writeValue(stream, methodCall.method);
            //messageCodec.writeValue(stream, methodCall.arguments);
            //ByteBuffer buffer = ByteBuffer.allocateDirect(stream.size());
            //buffer.put(stream.buffer(), 0, stream.size());
            //return buffer;
        }

        //@Override
        // TODO: ByteBuffer->object
        public MethodCall DecodeMethodCall(object methodCall)
        {
            return (MethodCall)methodCall;
            //methodCall.order(ByteOrder.nativeOrder());
            //object method = messageCodec.readValue(methodCall);
            //object arguments = messageCodec.readValue(methodCall);
            //if (method is String && !methodCall.hasRemaining()) {
            //    return new MethodCall((string)method, arguments);
            //}
            //throw new IllegalArgumentException("Method call corrupted");
        }

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeSuccessEnvelope(object result)
        {
            return result;

            //ExposedByteArrayOutputStream stream = new ExposedByteArrayOutputStream();
            //stream.write(0);
            //messageCodec.writeValue(stream, result);
            //ByteBuffer buffer = ByteBuffer.allocateDirect(stream.size());
            //buffer.put(stream.buffer(), 0, stream.size());
            //return buffer;
        }

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeErrorEnvelope(string errorCode, string errorMessage, object errorDetails)
        {
            return new ErrorEnvelope
            {
                errorCode = errorCode,
                errorMessage = errorMessage,
                errorDetails = errorDetails
            };

            //ExposedByteArrayOutputStream stream = new ExposedByteArrayOutputStream();
            //stream.write(1);
            //messageCodec.writeValue(stream, errorCode);
            //messageCodec.writeValue(stream, errorMessage);
            //messageCodec.writeValue(stream, errorDetails);
            //ByteBuffer buffer = ByteBuffer.allocateDirect(stream.size());
            //buffer.put(stream.buffer(), 0, stream.size());
            //return buffer;
        }

        //@Override
        // TODO: ByteBuffer->object
        public object DecodeEnvelope(object envelope)
        {
            if (envelope is ErrorEnvelope errorEnvelope)
                return errorEnvelope;
            return envelope;

            //envelope.order(ByteOrder.nativeOrder());
            //byte flag = envelope.get();
            //switch (flag)
            //{
            //    case 0:
            //        {
            //            object result = messageCodec.readValue(envelope);
            //            if (!envelope.hasRemaining())
            //            {
            //                return result;
            //            }
            //        }
            //    // Falls through intentionally.
            //    case 1:
            //        {
            //            object code = messageCodec.readValue(envelope);
            //            object message = messageCodec.readValue(envelope);
            //            object details = messageCodec.readValue(envelope);
            //            if (code is String
            //        && (message == null || message is String)
            //        && !envelope.hasRemaining()) {
            //                throw new FlutterException((string)code, (string)message, details);
            //            }
            //        }
            //}
            //throw new IllegalArgumentException("Envelope corrupted");
        }
    }

    public class ErrorEnvelope
    {
        public string errorCode;
        public string errorMessage;
        public object errorDetails;
    }
}