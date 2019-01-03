namespace FlutterBinding.Plugin.Common
{
    /**
     * A message encoding/decoding mechanism.
     *
     * Both operations throw {@link IllegalArgumentException}, if conversion fails.
     */
    public interface IMessageCodec<T> where T : class
    {
        /**
         * Encodes the specified message into binary.
         *
         * @param message the T message, possibly null.
         * @return a ByteBuffer containing the encoding between position 0 and
         * the current position, or null, if message is null.
         */
        // TODO: ByteBuffer->object
        object EncodeMessage(T message);

        /**
         * Decodes the specified message from binary.
         *
         * @param message the {@link ByteBuffer} message, possibly null.
         * @return a T value representation of the bytes between the given buffer's current
         * position and its limit, or null, if message is null.
         */
        // TODO: ByteBuffer->object
        T DecodeMessage(object message);
    }


    /**
     * MessageCodec using the Flutter standard binary encoding.
     *
     * <p>This codec is guaranteed to be compatible with the corresponding
     * <a href="https://docs.flutter.io/flutter/services/StandardMessageCodec-class.html">StandardMessageCodec</a>
     * on the Dart side. These parts of the Flutter SDK are evolved synchronously.</p>
     *
     * <p>Supported messages are acyclic values of these forms:</p>
     *
     * <ul>
     *     <li>null</li>
     *     <li>Booleans</li>
     *     <li>Bytes, Shorts, Integers, Longs</li>
     *     <li>Floats, Doubles</li>
     *     <li>Strings</li>
     *     <li>byte[], int[], long[], double[]</li>
     *     <li>Lists of supported values</li>
     *     <li>Maps with supported keys and values</li>
     * </ul>
     *
     * <p>On the Dart side, these values are represented as follows:</p>
     *
     * <ul>
     *     <li>null: null</li>
     *     <li>Boolean: bool</li>
     *     <li>Byte, Short, Integer, Long: int</li>
     *     <li>Float, Double: double</li>
     *     <li>String: String</li>
     *     <li>byte[]: Uint8List</li>
     *     <li>int[]: Int32List</li>
     *     <li>long[]: Int64List</li>
     *     <li>double[]: Float64List</li>
     *     <li>List: List</li>
     *     <li>Map: Map</li>
     * </ul>
     *
     * <p>Direct support for BigIntegers has been deprecated on 2018-01-09 to be made
     * unavailable four weeks after this change is available on the Flutter alpha
     * branch. BigIntegers were needed because the Dart 1.0 int type had no size
     * limit. With Dart 2.0, the int type is a fixed-size, 64-bit signed integer.
     * If you need to communicate larger integers, use String encoding instead.</p>
     *
     * <p>To extend the codec, overwrite the writeValue and readValueOfType methods.</p>
     */
    public class StandardMessageCodec : IMessageCodec<object>
    {
        public static readonly StandardMessageCodec Instance = new StandardMessageCodec();

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeMessage(object message)
        {
            return message;
        }

        //@Override
        public object DecodeMessage(object message)
        {
            return message;
        }
    }
}
