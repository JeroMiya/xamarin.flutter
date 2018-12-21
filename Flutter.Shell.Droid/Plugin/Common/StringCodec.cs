namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A {@link MessageCodec} using UTF-8 encoded String messages.
     *
     * <p>This codec is guaranteed to be compatible with the corresponding
     * <a href="https://docs.flutter.io/flutter/services/StringCodec-class.html">StringCodec</a>
     * on the Dart side. These parts of the Flutter SDK are evolved synchronously.</p>
     */
    public class StringCodec : MessageCodec<string>
    {
        //private static Charset UTF8 = Charset.forName("UTF8");
        public static readonly StringCodec INSTANCE = new StringCodec();

        private StringCodec()
        {
        }

        //@Override
        public object EncodeMessage(string message)
        {
            return message;

            /*
            if (message == null)
            {
                return null;
            }
            // TODO(mravn): Avoid the extra copy below.
            byte[] bytes = message.GetBytes(UTF8);
            ByteBuffer buffer = ByteBuffer.allocateDirect(bytes.length);
            buffer.put(bytes);
            return buffer;
            */
        }

        //@Override
        public string DecodeMessage(object message)
        {
            return (string)message;
            /*
            if (message == null)
            {
                return null;
            }
            final byte[] bytes;
            final int offset;
            final int length = message.remaining();
            if (message.hasArray())
            {
                bytes  = message.array();
                offset = message.arrayOffset();
            }
            else
            {
                // TODO(mravn): Avoid the extra copy below.
                bytes = new byte[length];
                message.get(bytes);
                offset = 0;
            }
            return new String(bytes, offset, length, UTF8);
            */
        }
    }
}