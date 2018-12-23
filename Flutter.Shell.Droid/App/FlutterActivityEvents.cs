using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Flutter.Shell.Droid.Plugin.Common;

namespace Flutter.Shell.Droid.App
{
    /// <summary>
    /// A collection of Android {@code Activity} methods that are relevant to the
    /// core operation of Flutter applications.
    ///
    /// <p>Application authors that use an activity other than
    /// { @link FlutterActivity} should forward all events herein from their activity
    /// to an instance of {@link FlutterActivityDelegate} in order to wire the
    /// activity up to the Flutter framework.This forwarding is already provided in
    /// {@code FlutterActivity}.</p>
    /// </summary>
    public interface IFlutterActivityEvents : 
        Android.Content.IComponentCallbacks2, 
        IRequestPermissionsResultListener,
        IActivityResultListener
    {
        ///<summary> <see cref="Activity#onCreate(android.os.Bundle)"/> </summary>
        void OnCreate(Bundle savedInstanceState);

        ///<summary> <see cref="Activity#onNewIntent(Intent)"/> </summary>
        void OnNewIntent(Intent intent);

        ///<summary> <see cref="Activity#onPause()"/> </summary>
        void OnPause();

        ///<summary> <see cref="Activity#onStart()"/> </summary>
        void OnStart();

        ///<summary> <see cref="Activity#onResume()"/> </summary>
        void OnResume();

        ///<summary> <see cref="Activity#onPostResume()"/> </summary>
        void OnPostResume();

        ///<summary> <see cref="Activity#onDestroy()"/> </summary>
        void OnDestroy();

        ///<summary><see cref="Activity#onStop()"/></summary>
        void OnStop();

        ///<summary>
        /// Invoked when the activity has detected the user's press of the back key.
        ///
        /// @return {@code true} if the listener handled the event; { @code false}
        ///     to let the activity continue with its default back button handling.
        /// <see cref="Activity#onBackPressed()"/>
        /// </summary>
        bool OnBackPressed();

        ///<summary><see cref="Activity#onUserLeaveHint"/></summary>
        void OnUserLeaveHint();
    }
}