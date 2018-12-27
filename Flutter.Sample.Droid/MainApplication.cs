using System;
using Android.App;
using Android.Runtime;
using Flutter.Shell.Droid.App;
using Flutter.Shell.Droid.View;

namespace Flutter.Sample.Droid
{
    [Application(
        Label       = "@string/app_name",
        Icon        = "@mipmap/ic_launcher",
        RoundIcon   = "@mipmap/ic_launcher_round",
        SupportsRtl = true,
        Theme       = "@style/AppTheme")]
    public class MainApplication : FlutterApplication
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        /// <inheritdoc />
        public override void OnCreate()
        {
            base.OnCreate();

            FlutterMain.StartInitialization(this)
                       .ConfigureAwait(true)
                       .GetAwaiter()
                       .GetResult();
        }
    }
}