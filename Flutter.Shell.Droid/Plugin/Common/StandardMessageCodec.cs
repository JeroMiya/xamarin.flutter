namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A message encoding/decoding mechanism.
     *
     * Both operations throw {@link IllegalArgumentException}, if conversion fails.
     */
    public interface MessageCodec<T> where T : class
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
    public class StandardMessageCodec : MessageCodec<object>
    {
        public static StandardMessageCodec INSTANCE = new StandardMessageCodec();

        //@Override
        // TODO: ByteBuffer->object
        public object EncodeMessage(object message)
        {
            return message;
            //if (message == null)
            //    return null;
            //ExposedByteArrayOutputStream stream = new ExposedByteArrayOutputStream();
            //writeValue(stream, message);
            //ByteBuffer buffer = ByteBuffer.allocateDirect(stream.size());
            //buffer.put(stream.buffer(), 0, stream.size());
            //return buffer;
        }

        //@Override
        public object DecodeMessage(object message)
        {
            return message;
            //if (message == null)
            //    return null;
            //message.order(ByteOrder.nativeOrder());
            //Object value = readValue(message);
            //if (message.hasRemaining())
            //    throw new IllegalArgumentException("Message corrupted");
            //return value;
        }

        //private static readonly bool LITTLE_ENDIAN = ByteOrder.nativeOrder() == ByteOrder.LITTLE_ENDIAN;
        //private static readonly Charset UTF8 = Charset.forName("UTF8");
        //private static readonly byte NULL = 0;
        //private static readonly byte TRUE = 1;
        //private static readonly byte FALSE = 2;
        //private static readonly byte INT = 3;
        //private static readonly byte LONG = 4;
        ////@Deprecated
        //private static readonly byte BIGINT = 5;
        //private static readonly byte DOUBLE = 6;
        //private static readonly byte STRING = 7;
        //private static readonly byte BYTE_ARRAY = 8;
        //private static readonly byte INT_ARRAY = 9;
        //private static readonly byte LONG_ARRAY = 10;
        //private static readonly byte DOUBLE_ARRAY = 11;
        //private static readonly byte LIST = 12;
        //private static readonly byte MAP = 13;

        ///**
        // * Writes an int representing a size to the specified stream.
        // * Uses an expanding code of 1 to 5 bytes to optimize for small values.
        // */
        //protected static void writeSize(ByteArrayOutputStream stream, int value)
        //{
        //    //assert 0 <= value;
        //    if (value < 254)
        //    {
        //        stream.write(value);
        //    }
        //    else if (value <= 0xffff)
        //    {
        //        stream.write(254);
        //        writeChar(stream, value);
        //    }
        //    else
        //    {
        //        stream.write(255);
        //        writeInt(stream, value);
        //    }
        //}

        ///**
        // * Writes the least significant two bytes of the specified int to the
        // * specified stream.
        // */
        //protected static void writeChar(ByteArrayOutputStream stream, int value)
        //{
        //    if (LITTLE_ENDIAN)
        //    {
        //        stream.write(value);
        //        stream.write(value >>> 8);
        //    }
        //    else
        //    {
        //        stream.write(value >>> 8);
        //        stream.write(value);
        //    }
        //}

        ///**
        // * Writes the specified int as 4 bytes to the specified stream.
        // */
        //protected static void writeInt(ByteArrayOutputStream stream, int value)
        //{
        //    if (LITTLE_ENDIAN)
        //    {
        //        stream.write(value);
        //        stream.write(value >>> 8);
        //        stream.write(value >>> 16);
        //        stream.write(value >>> 24);
        //    }
        //    else
        //    {
        //        stream.write(value >>> 24);
        //        stream.write(value >>> 16);
        //        stream.write(value >>> 8);
        //        stream.write(value);
        //    }
        //}

        ///**
        // * Writes the specified long as 8 bytes to the specified stream.
        // */
        //protected static void writeLong(ByteArrayOutputStream stream, long value)
        //{
        //    if (LITTLE_ENDIAN)
        //    {
        //        stream.write((byte)value);
        //        stream.write((byte)(value >>> 8));
        //        stream.write((byte)(value >>> 16));
        //        stream.write((byte)(value >>> 24));
        //        stream.write((byte)(value >>> 32));
        //        stream.write((byte)(value >>> 40));
        //        stream.write((byte)(value >>> 48));
        //        stream.write((byte)(value >>> 56));
        //    }
        //    else
        //    {
        //        stream.write((byte)(value >>> 56));
        //        stream.write((byte)(value >>> 48));
        //        stream.write((byte)(value >>> 40));
        //        stream.write((byte)(value >>> 32));
        //        stream.write((byte)(value >>> 24));
        //        stream.write((byte)(value >>> 16));
        //        stream.write((byte)(value >>> 8));
        //        stream.write((byte)value);
        //    }
        //}

        ///**
        // * Writes the specified double as 8 bytes to the specified stream.
        // */
        //protected static void writeDouble(ByteArrayOutputStream stream, double value)
        //{
        //    writeLong(stream, double.doubleToLongBits(value));
        //}

        ///**
        // * Writes the length and then the actual bytes of the specified array to
        // * the specified stream.
        // */
        //protected static void writeBytes(ByteArrayOutputStream stream, byte[] bytes)
        //{
        //    writeSize(stream, bytes.length);
        //    stream.write(bytes, 0, bytes.length);
        //}

        ///**
        // * Writes a number of padding bytes to the specified stream to ensure that
        // * the next value is aligned to a whole multiple of the specified alignment.
        // * An example usage with alignment = 8 is to ensure doubles are word-aligned
        // * in the stream.
        // */
        //protected static void writeAlignment(ByteArrayOutputStream stream, int alignment)
        //{
        //    int mod = stream.size() % alignment;
        //    if (mod != 0)
        //    {
        //        for (int i = 0; i < alignment - mod; i++)
        //        {
        //            stream.write(0);
        //        }
        //    }
        //}

        ///**
        // * Writes a type discriminator byte and then a byte serialization of the
        // * specified value to the specified stream.
        // *
        // * <p>Subclasses can extend the codec by overriding this method, calling
        // * super for values that the extension does not handle.</p>
        // */
        //protected void writeValue(ByteArrayOutputStream stream, object value)
        //{
        //    if (value == null)
        //    {
        //        stream.write(NULL);
        //    }
        //    else if (value == bool.TRUE)
        //    {
        //        stream.write(TRUE);
        //    }
        //    else if (value == bool.FALSE)
        //    {
        //        stream.write(FALSE);
        //    }
        //    else if (value is Number) {
        //        if (value is Integer || value is Short || value is Byte) {
        //            stream.write(INT);
        //            writeInt(stream, ((Number)value).intValue());
        //        } else if (value is Long) {
        //            stream.write(LONG);
        //            writeLong(stream, (long)value);
        //        } else if (value is Float || value is Double) {
        //            stream.write(DOUBLE);
        //            writeAlignment(stream, 8);
        //            writeDouble(stream, ((Number)value).doubleValue());
        //        } else if (value is BigInteger) {
        //            Log.w("Flutter", "Support for BigIntegers has been deprecated. Use String encoding instead.");
        //            stream.write(BIGINT);
        //            writeBytes(stream,
        //                ((BigInteger)value).toString(16).getBytes(UTF8));
        //        } else {
        //            throw new IllegalArgumentException("Unsupported Number type: " + value.getClass());
        //        }
        //    } else if (value is String) {
        //        stream.write(STRING);
        //        writeBytes(stream, ((string)value).getBytes(UTF8));
        //    } else if (value is byte[]) {
        //        stream.write(BYTE_ARRAY);
        //        writeBytes(stream, (byte[])value);
        //    } else if (value is int[]) {
        //        stream.write(INT_ARRAY);
        //        int[] array = (int[])value;
        //        writeSize(stream, array.length);
        //        writeAlignment(stream, 4);
        //        for (int n : array)
        //        {
        //            writeInt(stream, n);
        //        }
        //    } else if (value is long[]) {
        //        stream.write(LONG_ARRAY);
        //        long[] array = (long[])value;
        //        writeSize(stream, array.length);
        //        writeAlignment(stream, 8);
        //        for (long n : array)
        //        {
        //            writeLong(stream, n);
        //        }
        //    } else if (value is double[]) {
        //        stream.write(DOUBLE_ARRAY);
        //        double[] array = (double[])value;
        //        writeSize(stream, array.length);
        //        writeAlignment(stream, 8);
        //        for (double d : array)
        //        {
        //            writeDouble(stream, d);
        //        }
        //    } else if (value is List) {
        //        stream.write(LIST);
        //        List<?> list = (List)value;
        //        writeSize(stream, list.size());
        //        for (Object o : list)
        //        {
        //            writeValue(stream, o);
        //        }
        //    } else if (value is Map) {
        //        stream.write(MAP);
        //        Map<?, ?> map = (Map)value;
        //        writeSize(stream, map.size());
        //        for (Entry entry: map.entrySet())
        //        {
        //            writeValue(stream, entry.getKey());
        //            writeValue(stream, entry.getValue());
        //        }
        //    } else {
        //        throw new IllegalArgumentException("Unsupported value: " + value);
        //    }
        //}

        ///**
        // * Reads an int representing a size as written by writeSize.
        // */
        //protected static int readSize(ByteBuffer buffer)
        //{
        //    if (!buffer.hasRemaining())
        //    {
        //        throw new IllegalArgumentException("Message corrupted");
        //    }
        //    int value = buffer.get() & 0xff;
        //    if (value < 254)
        //    {
        //        return value;
        //    }
        //    else if (value == 254)
        //    {
        //        return buffer.getChar();
        //    }
        //    else
        //    {
        //        return buffer.getInt();
        //    }
        //}

        ///**
        // * Reads a byte array as written by writeBytes.
        // */
        //protected static byte[] readBytes(ByteBuffer buffer)
        //{
        //    int length = readSize(buffer);
        //    byte[] bytes = new byte[length];
        //    buffer.get(bytes);
        //    return bytes;
        //}

        ///**
        // * Reads alignment padding bytes as written by writeAlignment.
        // */
        //protected static void readAlignment(ByteBuffer buffer, int alignment)
        //{
        //    int mod = buffer.position() % alignment;
        //    if (mod != 0)
        //    {
        //        buffer.position(buffer.position() + alignment - mod);
        //    }
        //}

        ///**
        // * Reads a value as written by writeValue.
        // */
        //protected Object readValue(ByteBuffer buffer)
        //{
        //    if (!buffer.hasRemaining())
        //    {
        //        throw new IllegalArgumentException("Message corrupted");
        //    }
        //    byte type = buffer.get();
        //    return readValueOfType(type, buffer);
        //}

        ///**
        // * Reads a value of the specified type.
        // *
        // * <p>Subclasses may extend the codec by overriding this method, calling
        // * super for types that the extension does not handle.</p>
        // */
        //protected object readValueOfType(byte type, ByteBuffer buffer)
        //{
        //    Object result;
        //    switch (type)
        //    {
        //        case NULL:
        //            result = null;
        //            break;
        //        case TRUE:
        //            result = true;
        //            break;
        //        case FALSE:
        //            result = false;
        //            break;
        //        case INT:
        //            result = buffer.getInt();
        //            break;
        //        case LONG:
        //            result = buffer.getLong();
        //            break;
        //        case BIGINT:
        //            {
        //                Log.w("Flutter", "Support for BigIntegers has been deprecated. Use String encoding instead.");
        //                byte[] hex = readBytes(buffer);
        //                result = new BigInteger(new string(hex, UTF8), 16);
        //                break;
        //            }
        //        case DOUBLE:
        //            readAlignment(buffer, 8);
        //            result = buffer.getDouble();
        //            break;
        //        case STRING:
        //            {
        //                byte[] bytes = readBytes(buffer);
        //                result = new string(bytes, UTF8);
        //                break;
        //            }
        //        case BYTE_ARRAY:
        //            {
        //                result = readBytes(buffer);
        //                break;
        //            }
        //        case INT_ARRAY:
        //            {
        //                int length = readSize(buffer);
        //                int[] array = new int[length];
        //                readAlignment(buffer, 4);
        //                buffer.asIntBuffer().get(array);
        //                result = array;
        //                buffer.position(buffer.position() + 4 * length);
        //                break;
        //            }
        //        case LONG_ARRAY:
        //            {
        //                int length = readSize(buffer);
        //                long[] array = new long[length];
        //                readAlignment(buffer, 8);
        //                buffer.asLongBuffer().get(array);
        //                result = array;
        //                buffer.position(buffer.position() + 8 * length);
        //                break;
        //            }
        //        case DOUBLE_ARRAY:
        //            {
        //                int length = readSize(buffer);
        //                double[] array = new double[length];
        //                readAlignment(buffer, 8);
        //                buffer.asDoubleBuffer().get(array);
        //                result = array;
        //                buffer.position(buffer.position() + 8 * length);
        //                break;
        //            }
        //        case LIST:
        //            {
        //                int size = readSize(buffer);
        //                List<Object> list = new ArrayList<>(size);
        //                for (int i = 0; i < size; i++)
        //                {
        //                    list.add(readValue(buffer));
        //                }
        //                result = list;
        //                break;
        //            }
        //        case MAP:
        //            {
        //                int size = readSize(buffer);
        //                Map<Object, Object> map = new HashMap<>();
        //                for (int i = 0; i < size; i++)
        //                {
        //                    map.put(readValue(buffer), readValue(buffer));
        //                }
        //                result = map;
        //                break;
        //            }
        //        default: throw new IllegalArgumentException("Message corrupted");
        //    }
        //    return result;
        //}

        //static class ExposedByteArrayOutputStream : ByteArrayOutputStream
        //{
        //    byte[] buffer()
        //    {
        //        return buf;
        //    }
        //}
    }
}