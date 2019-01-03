using Android.App;
using Android.Content;
using Flutter.Shell.Droid.Plugin.Platform;
using Flutter.Shell.Droid.View;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * Receiver of registrations from a single plugin.
     */
    public interface IRegistrar
    {
        /**
         * Returns the {@link Activity} that forms the plugin's operating context.
         *
         * <p>Plugin authors should not assume the type returned by this method
         * is any specific subclass of {@code Activity} (such as
         * {@link io.flutter.app.FlutterActivity} or
         * {@link io.flutter.app.FlutterFragmentActivity}), as applications
         * are free to use any activity subclass.</p>
         *
         * <p>When there is no foreground activity in the application, this
         * will return null. If a {@link Context} is needed, use context() to
         * get the application's context.</p>
         */
        Activity Activity();

        /**
         * Returns the {@link android.app.Application}'s {@link Context}.
         */
        Context Context();

        /**
        * Returns the active {@link Context}.
        *
        * @return the current {@link #activity() Activity}, if not null, otherwise the {@link #context() Application}.
        */
        Context ActiveContext();

        /*
        // Returns a {@link BinaryMessenger} which the plugin can use for
        // creating channels for communicating with the Dart side.
        BinaryMessenger messenger();
        */

        /**
         * Returns a {@link TextureRegistry} which the plugin can use for
         * managing backend textures.
         */
        ITextureRegistry Textures();

        /**
         * Returns the application's {@link PlatformViewRegistry}.
         *
         * Plugins can use the platform registry to register their view factories.
         */
        IPlatformViewRegistry PlatformViewRegistry();

        /**
         * Returns the {@link FlutterView} that's instantiated by this plugin's
         * {@link #activity() activity}.
         */
        FlutterView View();


        /**
         * Returns the file name for the given asset.
         * The returned file name can be used to access the asset in the APK
         * through the {@link AssetManager} API.
         *
         * @param asset the name of the asset. The name can be hierarchical
         * @return      the filename to be used with {@link AssetManager}
         */
        string LookupKeyForAsset(string asset);

        /**
         * Returns the file name for the given asset which originates from the
         * specified packageName. The returned file name can be used to access
         * the asset in the APK through the {@link AssetManager} API.
         *
         * @param asset       the name of the asset. The name can be hierarchical
         * @param packageName the name of the package from which the asset originates
         * @return            the file name to be used with {@link AssetManager}
         */
        string LookupKeyForAsset(string asset, string packageName);


        /**
         * Publishes a value associated with the plugin being registered.
         *
         * <p>The published value is available to interested clients via
         * {@link PluginRegistry#valuePublishedByPlugin(String)}.</p>
         *
         * <p>Publication should be done only when client code needs to interact
         * with the plugin in a way that cannot be accomplished by the plugin
         * registering callbacks with client APIs.</p>
         *
         * <p>Overwrites any previously published value.</p>
         *
         * @param value the value, possibly null.
         * @return this {@link Registrar}.
         */
        IRegistrar Publish(object value);

        /**
         * Adds a callback allowing the plugin to take part in handling incoming
         * calls to {@code Activity#onRequestPermissionsResult(int, String[], int[])}
         * or {@code android.support.v4.app.ActivityCompat.OnRequestPermissionsResultCallback#onRequestPermissionsResult(int, String[], int[])}.
         *
         * @param listener a {@link RequestPermissionsResultListener} callback.
         * @return this {@link Registrar}.
         */
        IRegistrar AddRequestPermissionsResultListener(IRequestPermissionsResultListener listener);

        /**
         * Adds a callback allowing the plugin to take part in handling incoming
         * calls to {@link Activity#onActivityResult(int, int, Intent)}.
         *
         * @param listener an {@link ActivityResultListener} callback.
         * @return this {@link Registrar}.
         */
        IRegistrar AddActivityResultListener(IActivityResultListener listener);

        /**
         * Adds a callback allowing the plugin to take part in handling incoming
         * calls to {@link Activity#onNewIntent(Intent)}.
         *
         * @param listener a {@link NewIntentListener} callback.
         * @return this {@link Registrar}.
         */
        IRegistrar AddNewIntentListener(INewIntentListener listener);

        /**
         * Adds a callback allowing the plugin to take part in handling incoming
         * calls to {@link Activity#onUserLeaveHint()}.
         *
         * @param listener a {@link UserLeaveHintListener} callback.
         * @return this {@link Registrar}.
         */
        IRegistrar AddUserLeaveHintListener(IUserLeaveHintListener listener);

        /**
         * Adds a callback allowing the plugin to take part in handling incoming
         * calls to {@link Activity#onDestroy()}.
         *
         * @param listener a {@link ViewDestroyListener} callback.
         * @return this {@link Registrar}.
         */
        IRegistrar AddViewDestroyListener(IViewDestroyListener listener);
    }
}
