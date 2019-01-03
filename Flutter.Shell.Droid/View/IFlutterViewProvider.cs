namespace Flutter.Shell.Droid.View
{
    public interface IFlutterViewProvider
    {
        /**
         * Returns a reference to the Flutter view maintained by this object. This may
         * be <code>null</code>.
         */
        FlutterView GetFlutterView();
    }
}
