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
        public string[] BundlePaths;
        public string BundlePath;
        public string Entrypoint;
        public string LibraryPath;
        public string DefaultPath;
    }
}