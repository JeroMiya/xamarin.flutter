using System;
using System.Collections.Generic;
using System.Linq;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Util;
using Android.Views;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.View;
using Java.Interop;
using Result = Android.App.Result;

namespace Flutter.Shell.Droid.App
{

    /**
     * Specifies the mechanism by which Flutter views are created during the
     * operation of a {@code FlutterActivityDelegate}.
     *
     * <p>A delegate's view factory will be consulted during
     * {@link #onCreate(Bundle)}. If it returns {@code null}, then the delegate
     * will fall back to instantiating a new full-screen {@code FlutterView}.</p>
     *
     * <p>A delegate's native view factory will be consulted during
     * {@link #onCreate(Bundle)}. If it returns {@code null}, then the delegate
     * will fall back to instantiating a new {@code FlutterNativeView}. This is
     * useful for applications to override to reuse the FlutterNativeView held
     * e.g. by a pre-existing background service.</p>
     */
    public interface ViewFactory
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

    /**
     * Class that performs the actual work of tying Android {@link Activity}
     * instances to Flutter.
     *
     * <p>This exists as a dedicated class (as opposed to being integrated directly
     * into {@link FlutterActivity}) to facilitate applications that don't wish
     * to subclass {@code FlutterActivity}. The most obvious example of when this
     * may come in handy is if an application wishes to subclass the Android v4
     * support library's {@code FragmentActivity}.</p>
     *
     * <h3>Usage:</h3>
     * <p>To wire this class up to your activity, simply forward the events defined
     * in {@link FlutterActivityEvents} from your activity to an instance of this
     * class. Optionally, you can make your activity implement
     * {@link PluginRegistry} and/or {@link io.flutter.view.FlutterView.Provider}
     * and forward those methods to this class as well.</p>
     */
    public sealed class FlutterActivityDelegate : JavaObject, FlutterActivityEvents, Provider, PluginRegistry
    {
        private static readonly string SPLASH_SCREEN_META_DATA_KEY = "io.flutter.app.android.SplashScreenUntilFirstFrame";
        private static readonly string TAG = "FlutterActivityDelegate";
        private static readonly ViewGroup.LayoutParams matchParent =
            new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);


        private readonly Activity activity;
        private readonly ViewFactory viewFactory;
        private FlutterView flutterView;
        private Android.Views.View launchView;

        public FlutterActivityDelegate(Activity activity, ViewFactory viewFactory)
        {
            this.activity = activity ?? throw new ArgumentNullException(nameof(activity));
            this.viewFactory = viewFactory ?? throw new ArgumentNullException(nameof(viewFactory));
        }

        //@Override
        public FlutterView GetFlutterView() => flutterView;

        // The implementation of PluginRegistry forwards to flutterView.
        //@Override
        public bool HasPlugin(String key)
        {
            return flutterView.getPluginRegistry().hasPlugin(key);
        }

        //@Override
        //@SuppressWarnings("unchecked")
        public T ValuePublishedByPlugin<T>(String pluginKey)
        {
            return (T)flutterView.getPluginRegistry().valuePublishedByPlugin(pluginKey);
        }

        //@Override
        public Registrar RegistrarFor(String pluginKey)
        {
            return flutterView.getPluginRegistry().registrarFor(pluginKey);
        }

        //@Override
        public bool OnRequestPermissionsResult(
            int requestCode, string[] permissions, Permission[] grantResults)
        {
            return flutterView.getPluginRegistry().onRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
        //@Override
        public bool OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            return flutterView.getPluginRegistry().onActivityResult(requestCode, resultCode, data);
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
        public void OnCreate(Bundle savedInstanceState)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window window = activity.Window;
                window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                window.SetStatusBarColor(new Color(0x40000000));
                window.DecorView.SystemUiVisibility = (StatusBarVisibility)(SystemUiFlags.Fullscreen | SystemUiFlags.LayoutStable);
            }

            string[] args = getArgsFromIntent(activity.Intent);
            FlutterMain.EnsureInitializationComplete(activity.ApplicationContext, args);

            flutterView = viewFactory.CreateFlutterView(activity);
            if (flutterView == null)
            {
                FlutterNativeView nativeView = viewFactory.CreateFlutterNativeView();
                flutterView = new FlutterView(activity, null, nativeView);
                flutterView.LayoutParameters = matchParent;
                activity.SetContentView(flutterView);
                launchView = createLaunchView();
                if (launchView != null)
                {
                    addLaunchView();
                }
            }

            if (loadIntent(activity.Intent))
            {
                return;
            }

            if (!flutterView.getFlutterNativeView().isApplicationRunning())
            {
                string appBundlePath = FlutterMain.FindAppBundlePath(activity.ApplicationContext);
                if (appBundlePath != null)
                {
                    FlutterRunArguments arguments = new FlutterRunArguments();
                    var bundlePaths = new List<string>();
                    if (FlutterMain.GetUpdateInstallationPath() != null)
                    {
                        bundlePaths.Add(FlutterMain.GetUpdateInstallationPath());
                    }
                    bundlePaths.Add(appBundlePath);
                    arguments.bundlePaths = bundlePaths.ToArray();
                    arguments.entrypoint = "main";
                    flutterView.runFromBundle(arguments);
                }
            }
        }

        //@Override
        public void OnNewIntent(Intent intent)
        {
            // Only attempt to reload the Flutter Dart code during development. Use
            // the debuggable flag as an indicator that we are in development mode.
            if (!isDebuggable() || !loadIntent(intent))
            {
                flutterView.getPluginRegistry().onNewIntent(intent);
            }
        }

        private bool isDebuggable() => activity.ApplicationInfo.Flags.HasFlag(ApplicationInfoFlags.Debuggable);

        //@Override
        public void OnPause()
        {
            Application app = (Application)activity.ApplicationContext;
            if (app is FlutterApplication flutterApp)
            {
                if (activity.Equals(flutterApp.CurrentActivity))
                {
                    flutterApp.CurrentActivity = null;
                }
            }
            if (flutterView != null)
            {
                flutterView.OnPause();
            }
        }

        //@Override
        public void OnStart()
        {
            if (flutterView != null)
            {
                flutterView.OnStart();
            }
        }

        //@Override
        public void OnResume()
        {
            Application app = (Application)activity.ApplicationContext;
            if (app is FlutterApplication flutterApp) {
                flutterApp.CurrentActivity = activity;
            }
        }

        //@Override
        public void OnStop()
        {
            flutterView.OnStop();
        }

        //@Override
        public void OnPostResume()
        {
            if (flutterView != null)
            {
                flutterView.OnPostResume();
            }
        }

        //@Override
        public void OnDestroy()
        {
            Application app = (Application)activity.ApplicationContext;
            if (app is FlutterApplication flutterApp)
            {
                if (activity.Equals(flutterApp.CurrentActivity))
                {
                    flutterApp.CurrentActivity = null;
                }
            }
            if (flutterView != null)
            {
                bool detach = flutterView.getPluginRegistry().onViewDestroy(flutterView.getFlutterNativeView());
                if (detach || viewFactory.RetainFlutterNativeView())
                {
                    // Detach, but do not destroy the FlutterView if a plugin
                    // expressed interest in its FlutterNativeView.
                    flutterView.Detach();
                }
                else
                {
                    flutterView.Destroy();
                }
            }
        }

        //@Override
        public bool OnBackPressed()
        {
            if (flutterView != null)
            {
                flutterView.popRoute();
                return true;
            }
            return false;
        }

        //@Override
        public void OnUserLeaveHint()
        {
            flutterView.getPluginRegistry().onUserLeaveHint();
        }

        //@Override
        public void OnTrimMemory(int level)
        {
            // Use a trim level delivered while the application is running so the
            // framework has a chance to react to the notification.
            if (level == TRIM_MEMORY_RUNNING_LOW)
            {
                flutterView.OnMemoryPressure();
            }
        }

        //@Override
        public void OnLowMemory()
        {
            flutterView.OnMemoryPressure();
        }

        /// <inheritdoc />
        public void OnTrimMemory(TrimMemory level)
        {
            throw new NotImplementedException();
        }

        //@Override
        public void OnConfigurationChanged(Configuration newConfig)
        {
        }

        private static string[] getArgsFromIntent(Intent intent)
        {
            // Before adding more entries to this list, consider that arbitrary
            // Android applications can generate intents with extra data and that
            // there are many security-sensitive args in the binary.
            List<string> args = new List<string>();
            if (intent.GetBooleanExtra("trace-startup", false))
            {
                args.Add("--trace-startup");
            }
            if (intent.GetBooleanExtra("start-paused", false))
            {
                args.Add("--start-paused");
            }
            if (intent.GetBooleanExtra("use-test-fonts", false))
            {
                args.Add("--use-test-fonts");
            }
            if (intent.GetBooleanExtra("enable-dart-profiling", false))
            {
                args.Add("--enable-dart-profiling");
            }
            if (intent.GetBooleanExtra("enable-software-rendering", false))
            {
                args.Add("--enable-software-rendering");
            }
            if (intent.GetBooleanExtra("skia-deterministic-rendering", false))
            {
                args.Add("--skia-deterministic-rendering");
            }
            if (intent.GetBooleanExtra("trace-skia", false))
            {
                args.Add("--trace-skia");
            }
            if (intent.GetBooleanExtra("verbose-logging", false))
            {
                args.Add("--verbose-logging");
            }
            if (args.Any())
            {
                return args.ToArray();
            }
            return null;
        }

        private bool loadIntent(Intent intent)
        {
            string action = intent.Action;
            if (Intent.ActionRun.Equals(action))
            {
                string route = intent.GetStringExtra("route");
                string appBundlePath = intent.DataString;
                if (appBundlePath == null)
                {
                    // Fall back to the installation path if no bundle path
                    // was specified.
                    appBundlePath = FlutterMain.FindAppBundlePath(activity.ApplicationContext);
                }
                if (route != null)
                {
                    flutterView.setInitialRoute(route);
                }
                if (!flutterView.getFlutterNativeView().isApplicationRunning())
                {
                    FlutterRunArguments args = new FlutterRunArguments();
                    var bundlePaths = new List<string>();
                    if (FlutterMain.GetUpdateInstallationPath() != null)
                    {
                        bundlePaths.Add(FlutterMain.GetUpdateInstallationPath());
                    }
                    bundlePaths.Add(appBundlePath);
                    args.bundlePaths = bundlePaths.ToArray();
                    args.entrypoint = "main";
                    flutterView.runFromBundle(args);
                }
                return true;
            }

            return false;
        }

        /**
         * Creates a {@link View} containing the same {@link Drawable} as the one set as the
         * {@code windowBackground} of the parent activity for use as a launch splash view.
         *
         * Returns null if no {@code windowBackground} is set for the activity.
         */
        private Android.Views.View createLaunchView()
        {
            if (!showSplashScreenUntilFirstFrame())
            {
                return null;
            }
            var launchScreenDrawable = getLaunchScreenDrawableFromActivityTheme();
            if (launchScreenDrawable == null)
            {
                return null;
            }

            var view = new Android.Views.View(activity)
            {
                LayoutParameters = matchParent,
                Background = launchScreenDrawable
            };
            return view;
        }

        /**
         * Extracts a {@link Drawable} from the parent activity's {@code windowBackground}.
         *
         * {@code android:windowBackground} is specifically reused instead of a other attributes
         * because the Android framework can display it fast enough when launching the app as opposed
         * to anything defined in the Activity subclass.
         *
         * Returns null if no {@code windowBackground} is set for the activity.
         */
        //@SuppressWarnings("deprecation")
        private Drawable getLaunchScreenDrawableFromActivityTheme()
        {
            TypedValue typedValue = new TypedValue();
            if (!activity.Theme.ResolveAttribute(
                Android.Resource.Attribute.WindowBackground,
                typedValue,
                true))
            {
                return null;
            }
            if (typedValue.ResourceId == 0)
            {
                return null;
            }
            try
            {
                #pragma warning disable 618 // Deprecation
                return activity.Resources.GetDrawable(typedValue.ResourceId);
                #pragma warning restore 618
            }
            catch (Resources.NotFoundException e)
            {
                Log.Error(TAG, "Referenced launch screen windowBackground resource does not exist");
                return null;
            }
        }

        /**
         * Let the user specify whether the activity's {@code windowBackground} is a launch screen
         * and should be shown until the first frame via a <meta-data> tag in the activity.
         */
        private bool showSplashScreenUntilFirstFrame()
        {
            try
            {
                var activityInfo = activity.PackageManager.GetActivityInfo(
                    activity.ComponentName, 
                    PackageInfoFlags.MetaData | PackageInfoFlags.Activities);
                Bundle metadata = activityInfo.MetaData;
                return metadata != null && metadata.GetBoolean(SPLASH_SCREEN_META_DATA_KEY);
            }
            catch (PackageManager.NameNotFoundException e)
            {
                return false;
            }
        }

        private class FirstFrameListener : AnimatorListenerAdapter
        {
            private readonly Android.Views.View _launchView;
            private readonly Action _onAnimationEnd;

            public FirstFrameListener(Android.Views.View launchView, Action onAnimationEnd)
            {
                _launchView = launchView;
                _onAnimationEnd = onAnimationEnd;
            }

            /// <inheritdoc />
            public override void OnAnimationEnd(Animator animation)
            {
                base.OnAnimationEnd(animation);
                // Views added to an Activity's addContentView is always added to its
                // root FrameLayout.
                ((ViewGroup)_launchView.Parent).RemoveView(_launchView);
                _onAnimationEnd?.Invoke();
            }
        }

        /**
         * Show and then automatically animate out the launch view.
         *
         * If a launch screen is defined in the user application's AndroidManifest.xml as the
         * activity's {@code windowBackground}, display it on top of the {@link FlutterView} and
         * remove the activity's {@code windowBackground}.
         *
         * Fade it out and remove it when the {@link FlutterView} renders its first frame.
         */
        private void addLaunchView()
        {
            if (launchView == null)
            {
                return;
            }

            activity.AddContentView(launchView, matchParent);
            flutterView.addFirstFrameListener(
                () =>
                {
                    var viewPropertyAnimate = launchView.Animate();
                    viewPropertyAnimate.Alpha(0f);
                    var adapter = new FirstFrameListener(launchView, () => launchView = null);
                    viewPropertyAnimate.SetListener(adapter);
                    flutterView.removeFirstFrameListener(this);
                });

            // Resets the activity theme from the one containing the launch screen in the window
            // background to a blank one since the launch screen is now in a view in front of the
            // FlutterView.
            //
            // We can make this configurable if users want it.
            activity.SetTheme(Android.Resource.Style.ThemeBlackNoTitleBar);
        }

        /// <inheritdoc />
        public IntPtr Handle { get; }

    }
}