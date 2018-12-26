namespace Flutter.Shell.Droid.View
{
    public interface IProvider
    {
        /**
         * Returns a reference to the Flutter view maintained by this object. This may
         * be {@code null}.
         */
        FlutterView GetFlutterView();
    }
}
