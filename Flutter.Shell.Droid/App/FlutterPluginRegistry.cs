using Android.App;
using Android.Content;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.Plugin.Platform;
using Flutter.Shell.Droid.View;
using Java.Lang;
using System.Collections.Generic;
using Android.Content.PM;
using Result = Flutter.Shell.Droid.Plugin.Common.Result;
using TextureRegistry = Flutter.Shell.Droid.View.TextureRegistry;

namespace Flutter.Shell.Droid.App
{
    public class FlutterPluginRegistry : 
            PluginRegistry,
             RequestPermissionsResultListener,
             ActivityResultListener,
             NewIntentListener,
             UserLeaveHintListener,
             ViewDestroyListener
    {
        private static readonly string TAG = "FlutterPluginRegistry";

        internal Activity _activity;
        internal readonly Context _appContext;
        internal readonly FlutterNativeView _nativeView;
        internal FlutterView _flutterView;

        internal PlatformViewsController _platformViewsController;
        internal Dictionary<string, object> _pluginMap = new Dictionary<string, object>();
        internal readonly List<RequestPermissionsResultListener> _requestPermissionsResultListeners = new List<RequestPermissionsResultListener>();
        internal readonly List<ActivityResultListener> _activityResultListeners = new List<ActivityResultListener>();
        internal readonly List<NewIntentListener> _newIntentListeners = new List<NewIntentListener>();
        internal readonly List<UserLeaveHintListener> _userLeaveHintListeners = new List<UserLeaveHintListener>();
        internal readonly List<ViewDestroyListener> _viewDestroyListeners = new List<ViewDestroyListener>();

        public FlutterPluginRegistry(FlutterNativeView nativeView, Context context)
        {
            _nativeView = nativeView;
            _appContext = context;
            _platformViewsController = new PlatformViewsController();
        }

        //@Override
        public bool HasPlugin(string key)
        {
            return _pluginMap.ContainsKey(key);
        }

        //@Override
        //@SuppressWarnings("unchecked")
        public T ValuePublishedByPlugin<T>(string pluginKey)
        {
            return (T)_pluginMap[pluginKey];
        }

        //@Override
        public Registrar RegistrarFor(string pluginKey)
        {
            if (_pluginMap.ContainsKey(pluginKey))
            {
                throw new IllegalStateException("Plugin key " + pluginKey + " is already in use");
            }
            _pluginMap[pluginKey] = null;
            return new FlutterRegistrar(pluginKey, this);
        }

        public void Attach(FlutterView flutterView, Activity activity)
        {
            _flutterView = flutterView;
            _activity = activity;
            _platformViewsController.Attach(activity, flutterView, flutterView);
        }

        public void Detach()
        {
            _platformViewsController.Detach();
            _platformViewsController.OnFlutterViewDestroyed();
            _flutterView = null;
            _activity = null;
        }

        public void OnPreEngineRestart()
        {
            _platformViewsController.OnPreEngineRestart();
        }

        //@Override
        public bool OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            foreach (var listener in _requestPermissionsResultListeners)
            {
                if (listener.OnRequestPermissionsResult(requestCode, permissions, grantResults))
                {
                    return true;
                }
            }
            return false;
        }

        /*
         * Method onRequestPermissionResult(int, String[], int[]) was made
         * unavailable on 2018-02-28, following deprecation. This comment is left as
         * a temporary tombstone for reference, to be removed on 2018-03-28 (or at
         * least four weeks after release of unavailability).
         *
         * https://github.com/flutter/flutter/wiki/Changelog#typo-fixed-in-flutter-engine-android-api
         */

        //@Override
        public bool OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            foreach (var listener in _activityResultListeners)
            {
                if (listener.OnActivityResult(requestCode, resultCode, data))
                {
                    return true;
                }
            }
            return false;
        }

        //@Override
        public bool OnNewIntent(Intent intent)
        {
            foreach (var listener in _newIntentListeners)
            {
                if (listener.OnNewIntent(intent))
                {
                    return true;
                }
            }
            return false;
        }

        //@Override
        public void OnUserLeaveHint()
        {
            foreach (var listener in _userLeaveHintListeners)
            {
                listener.OnUserLeaveHint();
            }
        }

        //@Override
        public bool OnViewDestroy(FlutterNativeView view)
        {
            bool handled = false;
            foreach (var listener in _viewDestroyListeners)
            {
                if (listener.OnViewDestroy(view))
                {
                    handled = true;
                }
            }
            return handled;
        }

        public void Destroy()
        {
            _platformViewsController.OnFlutterViewDestroyed();
        }

    }

    internal class FlutterRegistrar : Registrar
    {
        private readonly string pluginKey;
        private readonly FlutterPluginRegistry _registry;

        public FlutterRegistrar(string pluginKey, FlutterPluginRegistry registry)
        {
            this.pluginKey = pluginKey;
            _registry = registry;
        }

        //@Override
        public Activity Activity() => _registry._activity;

        //@Override
        public Context Context() => _registry._appContext;

        //@Override
        public Context ActiveContext() => _registry._activity ?? _registry._appContext;

        //@Override
        public BinaryMessenger Messenger() => _registry._nativeView;

        //@Override
        public TextureRegistry Textures() => _registry._flutterView;

        //@Override
        public PlatformViewRegistry PlatformViewRegistry() => _registry._platformViewsController.GetRegistry();

        //@Override
        public FlutterView View() => _registry._flutterView;

        //@Override
        public string LookupKeyForAsset(string asset) => FlutterMain.GetLookupKeyForAsset(asset);

        //@Override
        public string LookupKeyForAsset(string asset, string packageName) => FlutterMain.GetLookupKeyForAsset(asset, packageName);

        //@Override
        public Registrar Publish(object value)
        {
            _registry._pluginMap[pluginKey] = value;
            return this;
        }

        /*
         * Method addRequestPermissionResultListener(RequestPermissionResultListener)
         * was made unavailable on 2018-02-28, following deprecation.
         * This comment is left as a temporary tombstone for reference, to be removed
         * on 2018-03-28 (or at least four weeks after release of unavailability).
         *
         * https://github.com/flutter/flutter/wiki/Changelog#typo-fixed-in-flutter-engine-android-api
         */
        //@Override
        public Registrar AddRequestPermissionsResultListener(RequestPermissionsResultListener listener)
        {
            _registry._requestPermissionsResultListeners.Add(listener);
            return this;
        }

        /// <inheritdoc />
        public Registrar AddActivityResultListener(ActivityResultListener listener)
        {
            _registry._activityResultListeners.Add(listener);
            return this;
        }

        //@Override
        public Registrar AddNewIntentListener(NewIntentListener listener)
        {
            _registry._newIntentListeners.Add(listener);
            return this;
        }

        //@Override
        public Registrar AddUserLeaveHintListener(UserLeaveHintListener listener)
        {
            _registry._userLeaveHintListeners.Add(listener);
            return this;
        }

        //@Override
        public Registrar AddViewDestroyListener(ViewDestroyListener listener)
        {
            _registry._viewDestroyListeners.Add(listener);
            return this;
        }
    }
}