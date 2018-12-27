using Android.Content;

namespace Flutter.Shell.Droid.Util
{
    public static class PathUtils
    {
        public static string GetFilesDir(Context applicationContext)
        {
            return applicationContext.FilesDir.Path;
        }

        public static string GetDataDirectory(Context applicationContext)
        {
            return applicationContext.GetDir("flutter", FileCreationMode.Private).Path;
        }

        public static string GetCacheDirectory(Context applicationContext)
        {
            return applicationContext.CacheDir.Path;
        }
    }
}
