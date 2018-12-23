﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Flutter.Shell.Droid.View;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * Registry used by plugins to set up interaction with Android APIs.
     *
     * <p>Flutter applications by default include an auto-generated and auto-updated
     * plugin registrant class (GeneratedPluginRegistrant) that makes use of a
     * {@link PluginRegistry} to register contributions from each plugin mentioned
     * in the application's pubspec file. The generated registrant class is, again
     * by default, called from the application's main {@link Activity}, which
     * defaults to an instance of {@link io.flutter.app.FlutterActivity}, itself a
     * {@link PluginRegistry}.</p>
     */
    public interface IPluginRegistry
    {
        /**
         * Returns a {@link Registrar} for receiving the registrations pertaining
         * to the specified plugin.
         *
         * @param pluginKey a unique String identifying the plugin; typically the
         * fully qualified name of the plugin's main class.
         */
        IRegistrar RegistrarFor(string pluginKey);

        /**
         * Returns whether the specified plugin is known to this registry.
         *
         * @param pluginKey a unique String identifying the plugin; typically the
         * fully qualified name of the plugin's main class.
         * @return true if this registry has handed out a registrar for the
         * specified plugin.
         */
        bool HasPlugin(string pluginKey);

        /**
         * Returns the value published by the specified plugin, if any.
         *
         * <p>Plugins may publish a single value, such as an instance of the
         * plugin's main class, for situations where external control or
         * interaction is needed. Clients are expected to know the value's
         * type.</p>
         *
         * @param pluginKey a unique String identifying the plugin; typically the
         * fully qualified name of the plugin's main class.
         * @return the published value, possibly null.
         */
        T ValuePublishedByPlugin<T>(string pluginKey);

    }

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
        //PlatformViewRegistry platformViewRegistry();

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

        /*
         * Method addRequestPermissionResultListener(RequestPermissionResultListener listener)
         * was made unavailable on 2018-02-28, leaving this comment as a temporary
         * tombstone for reference. This comment will be removed on 2018-03-28
         * (or at least four weeks after the unavailability is released).
         *
         * https://github.com/flutter/flutter/wiki/Changelog#typo-fixed-in-flutter-engine-android-api
         *
         * Adds a callback allowing the plugin to take part in handling incoming
         * calls to {@code Activity#onRequestPermissionsResult(int, String[], int[])}
         * or {@code android.support.v4.app.ActivityCompat.OnRequestPermissionsResultCallback#onRequestPermissionsResult(int, String[], int[])}.
         *
         * @param listener a {@link RequestPermissionResultListener} callback.
         * @return this {@link Registrar}.

         * @deprecated on 2018-01-02 because of misspelling. This method will be made unavailable
         * on 2018-02-06 (or at least four weeks after the deprecation is released). Use
         * {@link #addRequestPermissionsResultListener(RequestPermissionsResultListener)} instead.
         */

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

    /**
     * Delegate interface for handling result of permissions requests on
     * behalf of the main {@link Activity}.
     */
    public interface IRequestPermissionsResultListener
    {
        /**
         * @return true if the result has been handled.
         */
        bool OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults);
    }

    /*
     * interface RequestPermissionResultListener was made unavailable on
     * 2018-02-28, leaving this comment as a temporary tombstone for reference.
     * This comment will be removed on 2018-03-28 (or at least four weeks after
     * the unavailability is released).
     *
     * https://github.com/flutter/flutter/wiki/Changelog#typo-fixed-in-flutter-engine-android-api
     *
     * Delegate interface for handling result of permissions requests on
     * behalf of the main {@link Activity}.
     *
     * Deprecated on 2018-01-02 because of misspelling. This interface will be made
     * unavailable on 2018-02-06 (or at least four weeks after the deprecation is released).
     * Use {@link RequestPermissionsResultListener} instead.
     */

    /**
     * Delegate interface for handling activity results on behalf of the main
     * {@link Activity}.
     */
    public interface IActivityResultListener
    {
        /**
         * @return true if the result has been handled.
         */
        bool OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data);
    }

    /**
     * Delegate interface for handling new intents on behalf of the main
     * {@link Activity}.
     */
    public interface INewIntentListener
    {
        /**
         * @return true if the new intent has been handled.
         */
        bool OnNewIntent(Intent intent);
    }

    /**
     * Delegate interface for handling user leave hints on behalf of the main
     * {@link Activity}.
     */
    public interface IUserLeaveHintListener
    {
        void OnUserLeaveHint();
    }

    /**
     * Delegate interface for handling an {@link Activity}'s onDestroy
     * method being called. A plugin that implements this interface can
     * adopt the FlutterNativeView by retaining a reference and returning true.
     */
    public interface IViewDestroyListener
    {
        bool OnViewDestroy(FlutterNativeView view);
    }

    /**
     * Callback interface for registering plugins with a plugin registry.
     *
     * <p>For example, an Application may use this callback interface to
     * provide a background service with a callback for calling its
     * GeneratedPluginRegistrant.registerWith method.</p>
     */
    public interface IPluginRegistrantCallback
    {
        void RegisterWith(IPluginRegistry registry);
    }
}