using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Flutter.Shell.Droid.View
{
    /// <summary>
    /// A class containing arguments for entering a FlutterNativeView's isolate for the first time.
    /// </summary>
    public class FlutterRunArguments
    {
        public string[] BundlePaths { get; set; }
        public string BundlePath { get; set; }
        public string Entrypoint { get; set; }
        public string LibraryPath { get; set; }
        public string DefaultPath { get; set; }
    }
}
