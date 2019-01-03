using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Android.Content;
using Android.Content.PM;
using Android.Util;
using Flutter.Shell.Droid.Util;
using Java.IO;
using Java.Lang;
using Java.Util;
using Java.Util.Zip;
using Org.Json;

namespace Flutter.Shell.Droid.View
{
    /**
     * A class to initialize the native code.
     **/
    internal class ResourceExtractor
    {
        private static readonly int BUFFER_SIZE = 16 * 1024;
        private static readonly string TAG = "ResourceExtractor";
        private static readonly string TIMESTAMP_PREFIX = "res_timestamp-";
        private Task _extractTask;

        private readonly Context _context;
        private readonly HashSet<string> _resources;

        internal ResourceExtractor(Context context)
        {
            _context   = context;
            _resources = new HashSet<string>();
        }

        internal ResourceExtractor AddResource(string resource)
        {
            _resources.Add(resource);
            return this;
        }

        internal ResourceExtractor AddResources(Collection<string> resources)
        {
            foreach (var resource in resources)
                _resources.Add(resource);
            return this;
        }

        // Returns null if extracted resources are found and match the current APK version
        // and update version if any, otherwise returns the current APK and update version.
        internal string CheckTimestamp(File dataDir, JSONObject updateManifest)
        {
            var packageManager = _context.PackageManager;
            PackageInfo packageInfo = null;

            try
            {
                packageInfo = packageManager.GetPackageInfo(_context.PackageName, 0);
            }
            catch (PackageManager.NameNotFoundException e)
            {
                return TIMESTAMP_PREFIX;
            }

            if (packageInfo == null)
                return TIMESTAMP_PREFIX;

            var expectedTimestamp =
                TIMESTAMP_PREFIX + packageInfo.VersionCode + "-" + packageInfo.LastUpdateTime;

            if (updateManifest != null)
            {
                var baselineVersion = updateManifest.OptString("baselineVersion", null);
                if (baselineVersion == null)
                    Log.Warn(TAG, "Invalid update manifest: baselineVersion");

                var updateVersion = updateManifest.OptString("updateVersion", null);
                if (updateVersion == null)
                    Log.Warn(TAG, "Invalid update manifest: updateVersion");

                if (baselineVersion != null && updateVersion != null)
                {
                    if (!baselineVersion.Equals(packageInfo.VersionCode.ToString()))
                    {
                        Log.Warn(TAG, "Outdated update file for " + packageInfo.VersionCode);
                    }
                    else
                    {
                        var updateFile = new File(FlutterMainAndroid.GetUpdateInstallationPath());
                        expectedTimestamp += "-" + updateVersion + "-" + updateFile.LastModified();
                    }
                }
            }

            var existingTimestamps = GetExistingTimestamps(dataDir).ToList();
            if (existingTimestamps.Count == 0)
            {
                Log.Info(TAG, "No extracted resources found");
                return expectedTimestamp;
            }

            if (existingTimestamps.Count == 1)
                Log.Info(TAG, "Found extracted resources " + existingTimestamps[0]);

            if (existingTimestamps.Count != 1 ||
                !expectedTimestamp.Equals(existingTimestamps[0]))
            {
                Log.Info(TAG, "Resource version mismatch " + expectedTimestamp);
                return expectedTimestamp;
            }

            return null;
        }

        internal void DeleteFiles()
        {
            var dataDir = new File(PathUtils.GetDataDirectory(_context));
            foreach (var resource in _resources)
            {
                var file = new File(dataDir, resource);
                if (file.Exists())
                    file.Delete();
            }

            var existingTimestamps = GetExistingTimestamps(dataDir);
            foreach (var timestamp in existingTimestamps)
            {
                new File(dataDir, timestamp).Delete();
            }
        }

        /// Returns true if successfully unpacked APK resources,
        /// otherwise deletes all resources and returns false.
        internal bool ExtractApk(File dataDir)
        {
            var manager = _context.Resources.Assets;

            byte[] buffer = null;
            foreach (var asset in _resources)
            {
                try
                {
                    var output = new File(dataDir, asset);
                    if (output.Exists())
                    {
                        continue;
                    }

                    output.ParentFile?.Mkdirs();

                    using (var @is = manager.Open(asset))
                    {
                        using (OutputStream os = new FileOutputStream(output))
                        {
                            if (buffer == null)
                            {
                                buffer = new byte[BUFFER_SIZE];
                            }

                            var count = 0;
                            while ((count = @is.Read(buffer, 0, BUFFER_SIZE)) != -1)
                            {
                                os.Write(buffer, 0, count);
                            }

                            os.Flush();
                            Log.Info(TAG, "Extracted baseline resource " + asset);
                        }
                    }
                }
                catch (FileNotFoundException fnfe) { }
                catch (IOException ioe)
                {
                    Log.Warn(TAG, "Exception unpacking resources: " + ioe.Message);
                    DeleteFiles();
                    return false;
                }
            }

            return true;
        }

        internal void ExtractResources()
        {
            var dataDir = new File(PathUtils.GetDataDirectory(_context));

            var updateManifest = ReadUpdateManifest();
            if (!ValidateUpdateManifest(updateManifest))
            {
                updateManifest = null;
            }

            var timestamp = CheckTimestamp(dataDir, updateManifest);
            if (timestamp == null)
                return;
            DeleteFiles();

            if (updateManifest != null)
            {
                if (!ExtractUpdate(dataDir))
                    return;
            }

            if (!ExtractApk(dataDir))
                return;

            try
            {
                new File(dataDir, timestamp).CreateNewFile();
            }
            catch (IOException e)
            {
                Log.Warn(TAG, "Failed to write resource timestamp");
            }
        }

        /// Returns true if successfully unpacked update resources or if there is no update,
        /// otherwise deletes all resources and returns false.
        internal bool ExtractUpdate(File dataDir)
        {
            if (FlutterMainAndroid.GetUpdateInstallationPath() == null)
                return true;

            var updateFile = new File(FlutterMainAndroid.GetUpdateInstallationPath());
            if (!updateFile.Exists())
                return true;

            ZipFile zipFile;
            try
            {
                zipFile = new ZipFile(updateFile);
            }
            catch (ZipException e)
            {
                Log.Warn(TAG, "Exception unpacking resources: " + e.Message);
                DeleteFiles();
                return false;
            }
            catch (IOException e)
            {
                Log.Warn(TAG, "Exception unpacking resources: " + e.Message);
                DeleteFiles();
                return false;
            }

            byte[] buffer = null;
            foreach (var asset in _resources)
            {
                var entry = zipFile.GetEntry(asset);
                if (entry == null)
                    continue;

                var output = new File(dataDir, asset);
                if (output.Exists())
                    continue;
                output.ParentFile?.Mkdirs();

                try
                {
                    using (var @is = zipFile.GetInputStream(entry))
                    {
                        using (OutputStream os = new FileOutputStream(output))
                        {
                            if (buffer == null)
                                buffer = new byte[BUFFER_SIZE];

                            var count = 0;
                            while ((count = @is.Read(buffer, 0, BUFFER_SIZE)) != -1)
                            {
                                os.Write(buffer, 0, count);
                            }

                            os.Flush();
                            Log.Info(TAG, "Extracted override resource " + asset);
                        }
                    }
                }
                catch (FileNotFoundException fnfe) { }
                catch (IOException ioe)
                {
                    Log.Warn(TAG, "Exception unpacking resources: " + ioe.Message);
                    DeleteFiles();
                    return false;
                }
            }

            return true;
        }

        internal IEnumerable<string> GetExistingTimestamps(File dataDir)
        {
            return dataDir
                  .List()
                  .Where(f => f.Contains(TIMESTAMP_PREFIX));
        }

        /// Returns null if no update manifest is found.
        internal JSONObject ReadUpdateManifest()
        {
            if (FlutterMainAndroid.GetUpdateInstallationPath() == null)
                return null;

            var updateFile = new File(FlutterMainAndroid.GetUpdateInstallationPath());
            if (!updateFile.Exists())
                return null;

            try
            {
                var zipFile = new ZipFile(updateFile);
                var entry = zipFile.GetEntry("manifest.json");
                if (entry == null)
                {
                    Log.Warn(TAG, "Invalid update file: " + updateFile);
                    return null;
                }

                // Read and parse the entire JSON file as single operation.
                var scanner = new Scanner(zipFile.GetInputStream(entry));
                return new JSONObject(scanner.UseDelimiter("\\A").Next());
            }
            catch (ZipException e)
            {
                Log.Warn(TAG, "Invalid update file: " + e);
                return null;
            }
            catch (IOException e)
            {
                Log.Warn(TAG, "Invalid update file: " + e);
                return null;
            }
            catch (JSONException e)
            {
                Log.Warn(TAG, "Invalid update file: " + e);
                return null;
            }
        }

        internal ResourceExtractor Start()
        {
            if (_extractTask != null)
                throw new IllegalStateException("Extraction task already started");

            _extractTask = Task.Run(() => ExtractResources());
            return this;
        }

        /// Returns true if the downloaded update file was indeed built for this APK.
        internal bool ValidateUpdateManifest(JSONObject updateManifest)
        {
            if (updateManifest == null)
                return false;

            var baselineChecksum = updateManifest.OptString("baselineChecksum", null);
            if (baselineChecksum == null)
            {
                Log.Warn(TAG, "Invalid update manifest: baselineChecksum");
                return false;
            }

            var manager = _context.Resources.Assets;
            try
            {
                using (var @is = manager.Open("flutter_assets/isolate_snapshot_data"))
                {
                    var checksum = new CRC32();

                    var count = 0;
                    var buffer = new byte[BUFFER_SIZE];
                    while ((count = @is.Read(buffer, 0, BUFFER_SIZE)) != -1)
                    {
                        checksum.Update(buffer, 0, count);
                    }

                    if (!baselineChecksum.Equals(checksum.Value.ToString()))
                    {
                        Log.Warn(TAG, "Mismatched update file for APK");
                        return false;
                    }

                    return true;
                }
            }
            catch (IOException e)
            {
                Log.Warn(TAG, "Could not read APK: " + e);
                return false;
            }
        }

        internal async Task WaitForCompletion()
        {
            if (_extractTask == null)
                throw new IllegalStateException("Extraction task not started");

            try
            {
                await _extractTask;
            }
            catch (Exception e)
            {
                DeleteFiles();
            }
        }
    }
}
