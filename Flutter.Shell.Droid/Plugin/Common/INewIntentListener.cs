using Android.App;
using Android.Content;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /// <summary>
    /// Delegate interface for handling new intents on behalf of the main <see cref="Activity"/>
    /// </summary>
    public interface INewIntentListener
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if the new intent has been handled.</returns>
        bool OnNewIntent(Intent intent);
    }
}