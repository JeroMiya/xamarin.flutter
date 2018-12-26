using System;
using Android.App;
using Android.Runtime;
using Android.Support.V7.App;
using Flutter.Shell.Droid.View;

namespace Flutter.Shell.Droid.App
{
    public class FlutterApplication : Application
    {
        public FlutterApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        /// <inheritdoc />
        public override void OnCreate()
        {
            base.OnCreate();
            FlutterMain.StartInitialization(this);
        }

        public Activity CurrentActivity { get; set; }
    }
}
