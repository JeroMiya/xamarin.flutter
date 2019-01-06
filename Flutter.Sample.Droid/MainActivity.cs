using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Flutter.Sample.App;
using Flutter.Shell.Droid.App;

namespace Flutter.Sample.Droid
{
    [Activity(
        Theme        = "@style/AppTheme",
        MainLauncher = true,
        LaunchMode   = LaunchMode.SingleTop,
        ConfigurationChanges =
            ConfigChanges.Orientation |
            ConfigChanges.KeyboardHidden |
            ConfigChanges.Keyboard |
            ConfigChanges.ScreenSize |
            ConfigChanges.LayoutDirection |
            ConfigChanges.FontScale |
            ConfigChanges.ScreenLayout |
            ConfigChanges.Density,
        HardwareAccelerated = true,
        WindowSoftInputMode = SoftInput.AdjustResize)]
    public class MainActivity : FlutterActivity
    {
        public MyFlutterApp _flutterApp;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);

            _flutterApp = new MyFlutterApp();
        }
    }
}