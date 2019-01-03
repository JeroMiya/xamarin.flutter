using Android.App;
using Android.Content;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.Plugin.Platform;
using Flutter.Shell.Droid.View;
using Java.Lang;
using System.Collections.Generic;
using Android.Content.PM;
using FlutterBinding.Plugin.Common;

namespace Flutter.Shell.Droid.App
{
    public class FlutterPluginRegistry :
        IPluginRegistry,
        IRequestPermissionsResultListener,
        IActivityResultListener,
        INewIntentListener,
        IUserLeaveHintListener,
        IViewDestroyListener
    {
        private static readonly string TAG = "FlutterPluginRegistry";

        internal Activity _activity;
        internal readonly Context _appContext;
        internal readonly FlutterNativeView _nativeView;
        internal FlutterView _flutterView;

        internal PlatformViewsController _platformViewsController;
        internal Dictionary<string, object> _pluginMap = new Dictionary<string, object>();
        internal readonly List<IRequestPermissionsResultListener> _requestPermissionsResultListeners = new List<IRequestPermissionsResultListener>();
        internal readonly List<IActivityResultListener> _activityResultListeners = new List<IActivityResultListener>();
        internal readonly List<INewIntentListener> _newIntentListeners = new List<INewIntentListener>();
        internal readonly List<IUserLeaveHintListener> _userLeaveHintListeners = new List<IUserLeaveHintListener>();
        internal readonly List<IViewDestroyListener> _viewDestroyListeners = new List<IViewDestroyListener>();

        public FlutterPluginRegistry(FlutterNativeView nativeView, Context context)
        {
            _nativeView              = nativeView;
            _appContext              = context;
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
        public IRegistrar RegistrarFor(string pluginKey)
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
            _activity    = activity;
            _platformViewsController.Attach(activity, flutterView, flutterView);
        }

        public void Detach()
        {
            _platformViewsController.Detach();
            _platformViewsController.OnFlutterViewDestroyed();
            _flutterView = null;
            _activity    = null;
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
        public bool OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data)
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

    internal class FlutterRegistrar : IRegistrar
    {
        private readonly string pluginKey;
        private readonly FlutterPluginRegistry _registry;

        public FlutterRegistrar(string pluginKey, FlutterPluginRegistry registry)
        {
            this.pluginKey = pluginKey;
            _registry      = registry;
        }

        //@Override
        public Activity Activity() => _registry._activity;

        //@Override
        public Context Context() => _registry._appContext;

        //@Override
        public Context ActiveContext() => _registry._activity ?? _registry._appContext;

        //@Override
        public IBinaryMessenger Messenger() => _registry._nativeView;

        //@Override
        public ITextureRegistry Textures() => _registry._flutterView;

        //@Override
        public IPlatformViewRegistry PlatformViewRegistry() => _registry._platformViewsController.GetRegistry();

        //@Override
        public FlutterView View() => _registry._flutterView;

        //@Override
        public string LookupKeyForAsset(string asset) => FlutterMainAndroid.GetLookupKeyForAsset(asset);

        //@Override
        public string LookupKeyForAsset(string asset, string packageName) => FlutterMainAndroid.GetLookupKeyForAsset(asset, packageName);

        //@Override
        public IRegistrar Publish(object value)
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
        public IRegistrar AddRequestPermissionsResultListener(IRequestPermissionsResultListener listener)
        {
            _registry._requestPermissionsResultListeners.Add(listener);
            return this;
        }

        /// <inheritdoc />
        public IRegistrar AddActivityResultListener(IActivityResultListener listener)
        {
            _registry._activityResultListeners.Add(listener);
            return this;
        }

        //@Override
        public IRegistrar AddNewIntentListener(INewIntentListener listener)
        {
            _registry._newIntentListeners.Add(listener);
            return this;
        }

        //@Override
        public IRegistrar AddUserLeaveHintListener(IUserLeaveHintListener listener)
        {
            _registry._userLeaveHintListeners.Add(listener);
            return this;
        }

        //@Override
        public IRegistrar AddViewDestroyListener(IViewDestroyListener listener)
        {
            _registry._viewDestroyListeners.Add(listener);
            return this;
        }
    }
}
