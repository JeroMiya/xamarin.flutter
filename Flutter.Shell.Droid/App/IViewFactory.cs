using Android.Content;
using Flutter.Shell.Droid.View;

namespace Flutter.Shell.Droid.App
{
    /// <summary>
    /// <p>A delegate's view factory will be consulted during <see cref="FlutterActivity.OnCreate"/>.
    /// If it returns <code>null</code>, then the delegate
    /// will fall back to instantiating a new full-screen <code>FlutterView</code>.</p>
    /// 
    /// <p>A delegate's native view factory will be consulted during
    /// <see cref="#onCreate(Bundle)"/>. If it returns <code>null</code>, then the delegate
    /// will fall back to instantiating a new <code>FlutterNativeView</code>. This is
    /// useful for applications to override to reuse the FlutterNativeView held
    /// e.g.by a pre-existing background service.</p>
    /// </summary>
    public interface IViewFactory
    {
        FlutterView CreateFlutterView(Context context);
        FlutterNativeView CreateFlutterNativeView();

        /**
         * Hook for subclasses to indicate that the {@code FlutterNativeView}
         * returned by {@link #createFlutterNativeView()} should not be destroyed
         * when this activity is destroyed.
         */
        bool RetainFlutterNativeView();
    }
}