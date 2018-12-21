using System;
using System.Threading.Tasks;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Java.IO;
using Java.Lang;
using Java.Net;
using Exception = System.Exception;

namespace Flutter.Shell.Droid.View
{
    public sealed class ResourceUpdater
    {
        private static readonly string TAG = "ResourceUpdater";

        private Task _downloadTask;
        private readonly Context _context;

        public ResourceUpdater(Context context)
        {
            _context = context;
        }

        public string BuildUpdateDownloadUrl()
        {
            Bundle metaData;
            try
            {
                metaData = _context.PackageManager.GetApplicationInfo(
                    _context.PackageName,
                    PackageInfoFlags.MetaData).MetaData;
            }
            catch (PackageManager.NameNotFoundException e)
            {
                throw new RuntimeException(e);
            }

            if (metaData?.GetString("UpdateServerURL") == null)
                return null;

            URI uri;
            try
            {
                uri = new URI(metaData.GetString("UpdateServerURL") + "/" + GetApkVersion());
            }
            catch (URISyntaxException e)
            {
                Log.Warn(TAG, "Invalid AndroidManifest.xml UpdateServerURL: " + e.Message);
                return null;
            }

            return uri.Normalize().ToString();
        }

        public string GetApkVersion()
        {
            try
            {
                var packageManager = _context.PackageManager;
                var packageInfo = packageManager.GetPackageInfo(_context.PackageName, 0);
                return packageInfo?.VersionCode.ToString();
            }
            catch (PackageManager.NameNotFoundException e)
            {
                Log.Warn(TAG, "NameNotFoundException " + e);
                return null;
            }
        }

        public string GetUpdateInstallationPath()
        {
            return _context.FilesDir + "/update.zip";
        }

        public void StartUpdateDownloadOnce()
        {
            //assert downloadTask == null;
            _downloadTask = Task.Run(
                () => DoInBackground(BuildUpdateDownloadUrl(), GetUpdateInstallationPath()));
        }

        public async Task WaitForDownloadCompletion()
        {
            //assert downloadTask != null;
            try
            {
                await _downloadTask;
            }
            catch (Exception e)
            {
                Log.Warn(TAG, "Download cancelled: " + e.Message);
            }
        }

        internal object DoInBackground(string url, string filename)
        {
            try
            {
                var unresolvedUrl = new URL(url);
                var localFile = new File(filename);

                var startMillis = DateTime.Now.Ticks;
                Log.Info(TAG, "Checking for updates at " + unresolvedUrl);

                var connection = (HttpURLConnection)unresolvedUrl.OpenConnection();

                var lastModified = localFile.LastModified();
                if (lastModified != 0)
                {
                    Log.Info(TAG, "Active update timestamp " + lastModified);
                    connection.IfModifiedSince = lastModified;
                }

                using (var input = connection.InputStream)
                {
                    var resolvedUrl = connection.URL;
                    Log.Info(TAG, "Resolved update URL " + resolvedUrl);

                    if (connection.ResponseCode == HttpStatus.NotFound)
                    {
                        if (resolvedUrl.Equals(unresolvedUrl))
                        {
                            Log.Info(TAG, "Rolled back all updates");
                            localFile.Delete();
                            return null;
                        }

                        Log.Info(TAG, "Latest update not found");
                        return null;
                    }

                    if (connection.ResponseCode == HttpStatus.NotModified)
                    {
                        Log.Info(TAG, "Already have latest update");
                        return null;
                    }

                    Log.Info(TAG, "Downloading update " + unresolvedUrl);

                    using (OutputStream output = new FileOutputStream(localFile))
                    {
                        int count;
                        var data = new byte[1024];
                        while ((count = input.Read(data, 0, data.Length)) != -1)
                        {
                            output.Write(data, 0, count);
                        }

                        var totalMillis = DateTime.Now.Ticks - startMillis;
                        Log.Info(TAG, "Update downloaded in " + (totalMillis / 1000.0) + "s");

                        output.Flush();
                        return null;
                    }
                }
            }
            catch (IOException e)
            {
                Log.Warn(TAG, "Could not download update " + e.Message);
                return null;
            }
        }
    }
}
