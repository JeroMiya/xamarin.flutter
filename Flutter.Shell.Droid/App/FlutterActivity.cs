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

namespace Flutter.Shell.Droid.App
{
    public class FlutterActivity : Activity, IViewFactory, IPluginRegistry
    {
        public FlutterView FlutterView { get; private set; }
        private Android.Views.View _launchView;

        private static readonly string SplashScreenMetaDataKey = "io.flutter.app.android.SplashScreenUntilFirstFrame";
        private static readonly string Tag = "FlutterActivity";

        private static readonly ViewGroup.LayoutParams MatchParent =
            new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

        public FlutterActivity()
        {
        }

        // public SKCanvasView Canvas { get; private set; }
        // public FlutterSurface Surface { get; private set; }

        //private void OnCanvasPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        //{
        //    Surface.OnPaintSurface(args.Surface, args.Info);
        //}

        //protected override void OnDestroy()
        //{
        //    Canvas.PaintSurface -= OnCanvasPaintSurface;
        //    _eventDelegate.OnDestroy();
        //    base.OnDestroy();
        //}

        /// <summary>
        /// Hook for subclasses to customize the creation of the <see cref="FlutterView"/>
        ///
        /// The default implementation returns <code>null</code> , which will cause the
        /// activity to use a newly instantiated full-screen view.
        /// </summary>
        public FlutterView CreateFlutterView(Context context)
        {
            return null;
        }

        /// <summary>
        /// Hook for subclasses to customize the creation of the {@code FlutterNativeView}.
        ///
        /// The default implementation returns <code>null</code>, which will cause the
        /// activity to use a newly instantiated native view object.
        /// </summary>
        /// <returns></returns>
        public FlutterNativeView CreateFlutterNativeView()
        {
            return null;
        }

        public bool RetainFlutterNativeView()
        {
            return false;
        }

        public bool HasPlugin(string key)
        {
            return FlutterView.GetPluginRegistry().HasPlugin(key);
        }

        public T ValuePublishedByPlugin<T>(string pluginKey)
        {
            return FlutterView.GetPluginRegistry().ValuePublishedByPlugin<T>(pluginKey);
        }

        public IRegistrar RegistrarFor(string pluginKey)
        {
            return FlutterView.GetPluginRegistry().RegistrarFor(pluginKey);
        }

        /// <inheritdoc />
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                Window.SetStatusBarColor(new Color(0x40000000));
                Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(SystemUiFlags.Fullscreen | SystemUiFlags.LayoutStable);
            }

            string[] args = GetArgsFromIntent(Intent);
            await FlutterMainAndroid.EnsureInitializationComplete(ApplicationContext, args);

            FlutterView = CreateFlutterView(this);
            if (FlutterView == null)
            {
                FlutterNativeView nativeView = CreateFlutterNativeView();
                FlutterView = new FlutterView(this, null, nativeView)
                {
                    LayoutParameters = MatchParent
                };

                SetContentView(FlutterView);
                _launchView = CreateLaunchView();
                if (_launchView != null)
                {
                    AddLaunchView();
                }
            }

            if (LoadIntent(Intent))
            {
                return;
            }

            if (!FlutterView.GetFlutterNativeView().IsApplicationRunning())
            {
                string appBundlePath = FlutterMainAndroid.FindAppBundlePath(ApplicationContext);
                if (appBundlePath != null)
                {
                    FlutterRunArguments arguments = new FlutterRunArguments();
                    List<string> bundlePaths = new List<string>();
                    if (FlutterMainAndroid.GetUpdateInstallationPath() != null)
                    {
                        bundlePaths.Add(FlutterMainAndroid.GetUpdateInstallationPath());
                    }

                    bundlePaths.Add(appBundlePath);
                    arguments.BundlePaths = bundlePaths.ToArray();
                    arguments.Entrypoint = "main";
                    FlutterView.RunFromBundle(arguments);
                }
            }

            /*
            FrameLayout.LayoutParams rootLayout;
            FrameLayout root = new FrameLayout(this)
            {
                LayoutParameters = rootLayout = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
            };
            rootLayout.SetMargins(0, 0, 0, 0);
            Canvas = new SKCanvasView(this)
            {
                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
            };
            root.AddView(Canvas);
            SetContentView(root);

            float scale = Resources.DisplayMetrics.Density;
            Surface = new FlutterSurface(scale);

            Canvas.PaintSurface += OnCanvasPaintSurface;
            */
        }


        /// <inheritdoc />
        protected override void OnStart()
        {
            base.OnStart();
            FlutterView?.OnStart();
        }

        /// <inheritdoc />
        protected override void OnResume()
        {
            base.OnResume();
            Application app = (Application)ApplicationContext;
            if (app is FlutterApplication flutterApp)
                flutterApp.CurrentActivity = this;
         }

        /// <inheritdoc />
        protected override void OnDestroy()
        {
            if (ApplicationContext is FlutterApplication flutterApp)
            {
                if (flutterApp.CurrentActivity.Equals(this))
                {
                    flutterApp.CurrentActivity = null;
                }
            }

            if (FlutterView != null)
            {
                bool detach = FlutterView.GetPluginRegistry().OnViewDestroy(FlutterView.GetFlutterNativeView());
                if (detach || RetainFlutterNativeView())
                {
                    // Detach, but do not destroy the FlutterView if a plugin
                    // expressed interest in its FlutterNativeView.
                    FlutterView.Detach();
                }
                else
                {
                    FlutterView.Destroy();
                }
            }

            base.OnDestroy();
        }

        /// <inheritdoc />
        public override void OnBackPressed()
        {
            if (FlutterView != null)
            {
                FlutterView.PopRoute();
                return;
            }
            base.OnBackPressed();
        }

        /// <inheritdoc />
        protected override void OnStop()
        {
            FlutterView?.OnStop();
            base.OnStop();
        }

        /// <inheritdoc />
        protected override void OnPause()
        {
            base.OnPause();
            if (ApplicationContext is FlutterApplication flutterApp)
            {
                if (flutterApp.CurrentActivity.Equals(this))
                {
                    flutterApp.CurrentActivity = null;
                }
            }
            FlutterView?.OnPause();
        }

        /// <inheritdoc />
        protected override void OnPostResume()
        {
            base.OnPostResume();
            FlutterView?.OnPostResume();
        }

        /// <inheritdoc />
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            //base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            FlutterView.GetPluginRegistry().OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        /// <inheritdoc />
        protected override void OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data)
        {
            if (FlutterView != null && FlutterView.GetPluginRegistry().OnActivityResult(requestCode, resultCode, data))
                return;

            base.OnActivityResult(requestCode, resultCode, data);
        }

        /// <inheritdoc />
        protected override void OnNewIntent(Intent intent)
        {
            //base.OnNewIntent(intent);
            // Only attempt to reload the Flutter Dart code during development. Use
            // the debuggable flag as an indicator that we are in development mode.
            if (!IsDebuggable() || !LoadIntent(intent))
            {
                FlutterView.GetPluginRegistry().OnNewIntent(intent);
            }
        }

        /// <inheritdoc />
        protected override void OnUserLeaveHint()
        {
            //base.OnUserLeaveHint();
            FlutterView.GetPluginRegistry().OnUserLeaveHint();
        }

        /// <inheritdoc />
        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
        }

        private static string[] GetArgsFromIntent(Intent intent)
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

        private bool LoadIntent(Intent intent)
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
                    appBundlePath = FlutterMainAndroid.FindAppBundlePath(ApplicationContext);
                }

                if (route != null)
                {
                    FlutterView.SetInitialRoute(route);
                }

                if (!FlutterView.GetFlutterNativeView().IsApplicationRunning())
                {
                    FlutterRunArguments args = new FlutterRunArguments();
                    List<string> bundlePaths = new List<string>();
                    if (FlutterMainAndroid.GetUpdateInstallationPath() != null)
                    {
                        bundlePaths.Add(FlutterMainAndroid.GetUpdateInstallationPath());
                    }

                    bundlePaths.Add(appBundlePath);
                    args.BundlePaths = bundlePaths.ToArray();
                    args.Entrypoint = "main";
                    FlutterView.RunFromBundle(args);
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
        private Android.Views.View CreateLaunchView()
        {
            if (!ShowSplashScreenUntilFirstFrame())
            {
                return null;
            }

            var launchScreenDrawable = GetLaunchScreenDrawableFromActivityTheme();
            if (launchScreenDrawable == null)
            {
                return null;
            }

            Android.Views.View view = new Android.Views.View(this)
            {
                LayoutParameters = MatchParent,
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
        private Drawable GetLaunchScreenDrawableFromActivityTheme()
        {
            TypedValue typedValue = new TypedValue();
            if (!Theme.ResolveAttribute(
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
                return Resources.GetDrawable(typedValue.ResourceId);
                #pragma warning restore 618
            }
            catch (Resources.NotFoundException e)
            {
                Log.Error(Tag, "Referenced launch screen windowBackground resource does not exist");
                return null;
            }
        }

        /**
         * Let the user specify whether the activity's {@code windowBackground} is a launch screen
         * and should be shown until the first frame via a <meta-data> tag in the activity.
         */
        private bool ShowSplashScreenUntilFirstFrame()
        {
            try
            {
                ActivityInfo activityInfo = PackageManager.GetActivityInfo(
                    ComponentName,
                    PackageInfoFlags.MetaData | PackageInfoFlags.Activities);
                Bundle metadata = activityInfo.MetaData;
                return metadata != null && metadata.GetBoolean(SplashScreenMetaDataKey);
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
        private void AddLaunchView()
        {
            if (_launchView == null)
            {
                return;
            }

            AddContentView(_launchView, MatchParent);
            FlutterView.FirstFrame += (s, e) =>
            {
                ViewPropertyAnimator viewPropertyAnimate = _launchView.Animate();
                viewPropertyAnimate.Alpha(0f);
                FirstFrameListener adapter = new FirstFrameListener(_launchView, () => _launchView = null);
                viewPropertyAnimate.SetListener(adapter);
                //flutterView.RemoveFirstFrameListener(this);
            };

            // Resets the activity theme from the one containing the launch screen in the window
            // background to a blank one since the launch screen is now in a view in front of the
            // FlutterView.
            //
            // We can make this configurable if users want it.
            SetTheme(Android.Resource.Style.ThemeBlackNoTitleBar);
        }

        private bool IsDebuggable()
        {
            return ApplicationInfo.Flags.HasFlag(ApplicationInfoFlags.Debuggable);
        }

    }
}
