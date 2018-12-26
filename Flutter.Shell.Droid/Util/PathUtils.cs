using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Flutter.Shell.Droid.Util
{
    public static class PathUtils
    {
        public static string GetFilesDir(Context applicationContext) => applicationContext.FilesDir.Path;

        public static string GetDataDirectory(Context applicationContext) => applicationContext.GetDir("flutter", FileCreationMode.Private).Path;

        public static string GetCacheDirectory(Context applicationContext) => applicationContext.CacheDir.Path;
    }
}
