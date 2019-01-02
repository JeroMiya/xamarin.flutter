using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Widget;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.View;
using FlutterBinding.UI;
using SkiaSharp.Views.Android;

namespace Flutter.Shell.Droid.App
{
    public class FlutterActivity : Activity, IFlutterViewProvider, IViewFactory
    {
        private readonly FlutterActivityDelegate _delegate;

        // These aliases ensure that the methods we forward to the delegate adhere
        // to relevant interfaces versus just existing in FlutterActivityDelegate.
        private readonly IFlutterActivityEvents _eventDelegate;
        private readonly IFlutterViewProvider _flutterViewProvider;
        private readonly IPluginRegistry _pluginRegistry;

        public FlutterActivity()
        {
            _delegate       = new FlutterActivityDelegate(this, this);
            _eventDelegate  = _delegate;
            _flutterViewProvider   = _delegate;
            _pluginRegistry = _delegate;
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
        /// Returns the Flutter view used by this activity; will be null before <code>onCreate(Bundle)</code> is called.
        /// </summary>
        public FlutterView GetFlutterView()
        {
            return _flutterViewProvider.GetFlutterView();
        }

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
            return _pluginRegistry.HasPlugin(key);
        }

        public T ValuePublishedByPlugin<T>(string pluginKey)
        {
            return _pluginRegistry.ValuePublishedByPlugin<T>(pluginKey);
        }

        public IRegistrar RegistrarFor(string pluginKey)
        {
            return _pluginRegistry.RegistrarFor(pluginKey);
        }

        /// <inheritdoc />
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _delegate.OnCreate(savedInstanceState);

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
            _eventDelegate.OnStart();
        }

        /// <inheritdoc />
        protected override void OnResume()
        {
            base.OnResume();
            _eventDelegate.OnResume();
        }

        /// <inheritdoc />
        protected override void OnDestroy()
        {
            _eventDelegate.OnDestroy();
            base.OnDestroy();
        }

        /// <inheritdoc />
        public override void OnBackPressed()
        {
            if (!_eventDelegate.OnBackPressed())
            {
                base.OnBackPressed();
            }
        }

        /// <inheritdoc />
        protected override void OnStop()
        {
            _eventDelegate.OnStop();
            base.OnStop();
        }

        /// <inheritdoc />
        protected override void OnPause()
        {
            base.OnPause();
            _eventDelegate.OnPause();
        }

        /// <inheritdoc />
        protected override void OnPostResume()
        {
            base.OnPostResume();
            _eventDelegate.OnPostResume();
        }

        /// <inheritdoc />
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            //base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            _eventDelegate.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        /// <inheritdoc />
        protected override void OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data)
        {
            if (!_eventDelegate.OnActivityResult(requestCode, resultCode, data))
            {
                base.OnActivityResult(requestCode, resultCode, data);
            }
        }

        /// <inheritdoc />
        protected override void OnNewIntent(Intent intent)
        {
            //base.OnNewIntent(intent);
            _eventDelegate.OnNewIntent(intent);
        }

        /// <inheritdoc />
        protected override void OnUserLeaveHint()
        {
            //base.OnUserLeaveHint();
            _eventDelegate.OnUserLeaveHint();
        }

        /// <inheritdoc />
        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            _eventDelegate.OnConfigurationChanged(newConfig);
        }
    }
}
