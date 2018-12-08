using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FlutterBinding.UI;
using SkiaSharp.Views.Android;

namespace Flutter.Shell.Droid.App
{
    public class FlutterActivity : AppCompatActivity
    {
        public SKCanvasView Canvas { get; private set; }
        public FlutterSurface Surface { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FlutterPage);

            Canvas = FindViewById<SKCanvasView>(Resource.Id.skiaView);

            var scale = Resources.DisplayMetrics.Density;

            if (Canvas != null)
            {
                Surface = new FlutterSurface(scale);
            }

            Canvas.PaintSurface += OnCanvasPaintSurface;
        }

        private void OnCanvasPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            Surface.OnPaintSurface(args.Surface, args.Info);
        }

        protected override void OnDestroy()
        {
            Canvas.PaintSurface -= OnCanvasPaintSurface;
            base.OnDestroy();
        }
    }
}