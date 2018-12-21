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
    /**
     * A class containing arguments for entering a FlutterNativeView's isolate for
     * the first time.
     */
    public class FlutterRunArguments
    {
        public string[] bundlePaths;
        public string bundlePath;
        public string entrypoint;
        public string libraryPath;
        public string defaultPath;
    }
}