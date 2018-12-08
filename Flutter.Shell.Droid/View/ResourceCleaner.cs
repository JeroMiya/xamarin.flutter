using Android.Content;
using Android.OS;
using Android.Util;
using Java.Lang;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using String = System.String;

namespace Flutter.Shell.Droid.View
{
    /**
     * A class to clean up orphaned resource directories after unclean shutdowns.
     **/
    public class ResourceCleaner
    {
        private static readonly string TAG = "ResourceCleaner";
        private static readonly long DELAY_MS = 5000;

        private void DeleteRecursively(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (var child in Directory.EnumerateFileSystemEntries(path))
                {
                    DeleteRecursively(child);
                }
                //Directory.Delete(path, false);
                return;
            }
            if (path.Contains(".xamarin.flutter.") && File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private static Context _context;

        public ResourceCleaner(Context context)
        {
            _context = context;
        }

        public void Start()
        {
            Task.Run(
                () =>
                {
                    var cacheDir = _context.CacheDir;
                    if (cacheDir == null)
                        return;

                    DeleteRecursively(cacheDir.Path);
                });
        }
    }
}