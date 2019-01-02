using Android.App;
using Android.Content;

namespace Flutter.Shell.Droid.Plugin.Common
{

    /// <summary>
    /// Delegate interface for handling activity results on behalf of the main <see cref="Activity"/>.
    /// </summary>
    public interface IActivityResultListener
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if the result has been handled.</returns>
        bool OnActivityResult(int requestCode, Result resultCode, Intent data);
    }
}