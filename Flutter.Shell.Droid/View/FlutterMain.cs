using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Flutter.Shell.Droid.App;

namespace Flutter.Shell.Droid.View
{
    public class FlutterMain
    {
        public static Context MainContext { get; private set; }

        public static void startInitialization(Context context)
        {
            if (Looper.MyLooper() != Looper.MainLooper)
            {
                throw new ThreadStateException("startInitialization must be called from the main thread");
            }

            MainContext = context;
        }

        private static void InitResources()
        {
            new ResourceCleaner(MainContext).Start();
        }
    }
}