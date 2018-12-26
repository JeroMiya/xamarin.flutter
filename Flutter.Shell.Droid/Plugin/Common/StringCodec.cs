namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A {@link MessageCodec} using UTF-8 encoded String messages.
     *
     * <p>This codec is guaranteed to be compatible with the corresponding
     * <a href="https://docs.flutter.io/flutter/services/StringCodec-class.html">StringCodec</a>
     * on the Dart side. These parts of the Flutter SDK are evolved synchronously.</p>
     */
    public class StringCodec : IMessageCodec<string>
    {
        //private static Charset UTF8 = Charset.forName("UTF8");
        public static readonly StringCodec Instance = new StringCodec();

        private StringCodec() { }

        //@Override
        public object EncodeMessage(string message)
        {
            return message;
        }

        //@Override
        public string DecodeMessage(object message)
        {
            return (string)message;
        }
    }
}
