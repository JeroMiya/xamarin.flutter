using FlutterBinding.Plugin.Common;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A codec for method calls and enveloped results.
     *
     * Method calls are encoded as binary messages with enough structure that the codec can
     * extract a method name String and an arguments Object. These data items are used to populate a
     * {@link MethodCall}.
     *
     * All operations throw {@link IllegalArgumentException}, if conversion fails.
     */
    public interface IMethodCodec
    {
        /**
         * Encodes a message call into binary.
         *
         * @param methodCall a {@link MethodCall}.
         * @return a {@link ByteBuffer} containing the encoding between position 0 and
         * the current position.
         */
        //TODO: ByteBuffer->object
        object EncodeMethodCall(MethodCall methodCall);

        /**
         * Decodes a message call from binary.
         *
         * @param methodCall the binary encoding of the method call as a {@link ByteBuffer}.
         * @return a {@link MethodCall} representation of the bytes between the given buffer's current
         * position and its limit.
         */
        //TODO: ByteBuffer->object
        MethodCall DecodeMethodCall(object methodCall);

        /**
         * Encodes a successful result into a binary envelope message.
         *
         * @param result The result value, possibly null.
         * @return a {@link ByteBuffer} containing the encoding between position 0 and
         * the current position.
         */
        //TODO: ByteBuffer->object
        object EncodeSuccessEnvelope(object result);

        /**
         * Encodes an error result into a binary envelope message.
         *
         * @param errorCode An error code String.
         * @param errorMessage An error message String, possibly null.
         * @param errorDetails Error details, possibly null.
         * @return a {@link ByteBuffer} containing the encoding between position 0 and
         * the current position.
         */
        //TODO: ByteBuffer->object
        object EncodeErrorEnvelope(string errorCode, string errorMessage, object errorDetails);

        /**
         * Decodes a result envelope from binary.
         *
         * @param envelope the binary encoding of a result envelope as a {@link ByteBuffer}.
         * @return the enveloped result Object.
         * @throws FlutterException if the envelope was an error envelope.
         */
        //TODO: ByteBuffer->object
        object DecodeEnvelope(object envelope);
    }
}
