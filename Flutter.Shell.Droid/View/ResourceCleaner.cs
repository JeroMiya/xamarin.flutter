using Android.Content;
using System.IO;
using System.Threading.Tasks;

namespace Flutter.Shell.Droid.View
{
    /**
     * A class to clean up orphaned resource directories after unclean shutdowns.
     **/
    public class ResourceCleaner
    {
        private static readonly string TAG = "ResourceCleaner";
        private static readonly long DelayMs = 5000;

        private void DeleteRecursively(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string child in Directory.EnumerateFileSystemEntries(path))
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

        public Task Start()
        {
            return Task.Run(
                () =>
                {
                    Java.IO.File cacheDir = _context.CacheDir;
                    if (cacheDir == null)
                        return;

                    DeleteRecursively(cacheDir.Path);
                });
        }
    }
}
