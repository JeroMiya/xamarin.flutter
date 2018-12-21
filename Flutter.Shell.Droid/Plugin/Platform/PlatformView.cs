namespace Flutter.Shell.Droid.Plugin.Platform
{
    /**
     * A handle to an Android view to be embedded in the Flutter hierarchy.
     */
    public interface PlatformView
    {
        /**
         * Returns the Android view to be embedded in the Flutter hierarchy.
         */
        Android.Views.View GetView();

        /**
         * Dispose this platform view.
         *
         * <p>The {@link PlatformView} object is unusable after this method is called.
         *
         * <p>Plugins implementing {@link PlatformView} must clear all references to the View object and the PlatformView
         * after this method is called. Failing to do so will result in a memory leak.
         */
        void Dispose();
    }
}