using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Flutter.Shell.Droid.Plugin.Common;

namespace Flutter.Shell.Droid.App
{
    /**
     * A collection of Android {@code Activity} methods that are relevant to the
     * core operation of Flutter applications.
     *
     * <p>Application authors that use an activity other than
     * {@link FlutterActivity} should forward all events herein from their activity
     * to an instance of {@link FlutterActivityDelegate} in order to wire the
     * activity up to the Flutter framework. This forwarding is already provided in
     * {@code FlutterActivity}.</p>
     */
    public interface FlutterActivityEvents : 
        Android.Content.IComponentCallbacks2, 
        RequestPermissionsResultListener,
        ActivityResultListener
    {
        /**
         * @see android.app.Activity#onCreate(android.os.Bundle)
         */
        void OnCreate(Bundle savedInstanceState);

        /**
         * @see android.app.Activity#onNewIntent(Intent)
         */
        void OnNewIntent(Intent intent);

        /**
         * @see android.app.Activity#onPause()
         */
        void OnPause();

        /**
         * @see android.app.Activity#onStart()
         */
        void OnStart();

        /**
         * @see android.app.Activity#onResume()
         */
        void OnResume();

        /**
         * @see android.app.Activity#onPostResume()
         */
        void OnPostResume();

        /**
         * @see android.app.Activity#onDestroy()
         */
        void OnDestroy();

        /**
         * @see android.app.Activity#onStop()
         */
        void OnStop();

        /**
         * Invoked when the activity has detected the user's press of the back key.
         *
         * @return {@code true} if the listener handled the event; {@code false}
         *     to let the activity continue with its default back button handling.
         * @see android.app.Activity#onBackPressed()
         */
        bool OnBackPressed();

        /**
         * @see android.app.Activity#onUserLeaveHint()
         */
        void OnUserLeaveHint();
    }
}