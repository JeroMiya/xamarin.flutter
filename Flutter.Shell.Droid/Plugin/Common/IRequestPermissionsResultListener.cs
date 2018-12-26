using Android.Content.PM;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /*
     * interface RequestPermissionResultListener was made unavailable on
     * 2018-02-28, leaving this comment as a temporary tombstone for reference.
     * This comment will be removed on 2018-03-28 (or at least four weeks after
     * the unavailability is released).
     *
     * https://github.com/flutter/flutter/wiki/Changelog#typo-fixed-in-flutter-engine-android-api
     *
     * Delegate interface for handling result of permissions requests on
     * behalf of the main {@link Activity}.
     *
     * Deprecated on 2018-01-02 because of misspelling. This interface will be made
     * unavailable on 2018-02-06 (or at least four weeks after the deprecation is released).
     * Use {@link RequestPermissionsResultListener} instead.
     */

    /**
     * Delegate interface for handling result of permissions requests on
     * behalf of the main {@link Activity}.
     */
    public interface IRequestPermissionsResultListener
    {
        /**
         * @return true if the result has been handled.
         */
        bool OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults);
    }
}
