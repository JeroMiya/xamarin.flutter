using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Flutter.Shell.Droid.Util;
using FlutterBinding.Shell;
using Java.Lang;
using Java.Util;
using Exception = System.Exception;
using File = Java.IO.File;

namespace Flutter.Shell.Droid.View
{
    public class FlutterMain
    {
        private static readonly string DEFAULT_AOT_ISOLATE_SNAPSHOT_DATA = "isolate_snapshot_data";
        private static string _aotIsolateSnapshotData = DEFAULT_AOT_ISOLATE_SNAPSHOT_DATA;
        private static readonly string DEFAULT_AOT_ISOLATE_SNAPSHOT_INSTR = "isolate_snapshot_instr";
        private static string _aotIsolateSnapshotInstr = DEFAULT_AOT_ISOLATE_SNAPSHOT_INSTR;

        // Mutable because default values can be overridden via config properties
        private static readonly string DEFAULT_AOT_SHARED_LIBRARY_PATH = "app.so";
        private static string _aotSharedLibraryPath = DEFAULT_AOT_SHARED_LIBRARY_PATH;
        private static readonly string DEFAULT_AOT_VM_SNAPSHOT_DATA = "vm_snapshot_data";
        private static string _aotVmSnapshotData = DEFAULT_AOT_VM_SNAPSHOT_DATA;
        private static readonly string DEFAULT_AOT_VM_SNAPSHOT_INSTR = "vm_snapshot_instr";
        private static string _aotVmSnapshotInstr = DEFAULT_AOT_VM_SNAPSHOT_INSTR;
        private static readonly string DEFAULT_FLUTTER_ASSETS_DIR = "flutter_assets";
        private static string _flutterAssetsDir = DEFAULT_FLUTTER_ASSETS_DIR;
        private static readonly string DEFAULT_FLX = "app.flx";
        private static string _flx = DEFAULT_FLX;
        private static string _icuDataPath;

        private static bool _initialized;
        private static bool _isPrecompiledAsBlobs;
        private static bool _isPrecompiledAsSharedLibrary;
        private static ResourceExtractor _resourceExtractor;
        private static ResourceUpdater _resourceUpdater;
        private static FlutterSettings _settings;
        private static Stopwatch _stopwatch;
        private static readonly string AOT_ISOLATE_SNAPSHOT_DATA_KEY = "isolate-snapshot-data";
        private static readonly string AOT_ISOLATE_SNAPSHOT_INSTR_KEY = "isolate-snapshot-instr";

        // Must match values in sky::shell::switches
        private static readonly string AOT_SHARED_LIBRARY_PATH = "aot-shared-library-path";
        private static readonly string AOT_SNAPSHOT_PATH_KEY = "aot-snapshot-path";
        private static readonly string AOT_VM_SNAPSHOT_DATA_KEY = "vm-snapshot-data";
        private static readonly string AOT_VM_SNAPSHOT_INSTR_KEY = "vm-snapshot-instr";


        // Resource names used for components of the precompiled snapshot.


        private static readonly string DEFAULT_KERNEL_BLOB = "kernel_blob.bin";
        private static readonly string FLUTTER_ASSETS_DIR_KEY = "flutter-assets-dir";
        private static readonly string FLX_KEY = "flx";

        // XML Attribute keys supported in AndroidManifest.xml
        public static readonly string PUBLIC_AOT_AOT_SHARED_LIBRARY_PATH = nameof(FlutterMain) + '.' + AOT_SHARED_LIBRARY_PATH;
        public static readonly string PUBLIC_AOT_ISOLATE_SNAPSHOT_DATA_KEY = nameof(FlutterMain) + '.' + AOT_ISOLATE_SNAPSHOT_DATA_KEY;
        public static readonly string PUBLIC_AOT_ISOLATE_SNAPSHOT_INSTR_KEY = nameof(FlutterMain) + '.' + AOT_ISOLATE_SNAPSHOT_INSTR_KEY;
        public static readonly string PUBLIC_AOT_VM_SNAPSHOT_DATA_KEY = nameof(FlutterMain) + '.' + AOT_VM_SNAPSHOT_DATA_KEY;
        public static readonly string PUBLIC_AOT_VM_SNAPSHOT_INSTR_KEY = nameof(FlutterMain) + '.' + AOT_VM_SNAPSHOT_INSTR_KEY;
        public static readonly string PUBLIC_FLUTTER_ASSETS_DIR_KEY = nameof(FlutterMain) + "." + FLUTTER_ASSETS_DIR_KEY;
        public static readonly string PUBLIC_FLX_KEY = nameof(FlutterMain) + "." + FLX_KEY;

        // Assets that are shared among all Flutter apps within an APK.
        private static readonly string SHARED_ASSET_DIR = "flutter_shared";
        private static readonly string SHARED_ASSET_ICU_DATA = "icudtl.dat";

        private static readonly string TAG = "FlutterMain";

        private static bool IsMainLoop => Looper.MyLooper() == Looper.MainLooper;
        public static Context MainContext { get; private set; }

        /**
         * Blocks until initialization of the native system has completed.
         * @param applicationContext The Android application context.
         * @param args Flags sent to the Flutter runtime.
         */
        public static async Task EnsureInitializationComplete(Context applicationContext, string[] args)
        {
            if (!IsMainLoop)
                throw new IllegalStateException("ensureInitializationComplete must be called on the main thread");

            if (_settings == null)
                throw new IllegalStateException("ensureInitializationComplete must be called after startInitialization");

            if (_initialized)
                return;

            try
            {
                await _resourceExtractor.WaitForCompletion();

                var shellArgs = new List<string>
                {
                    "--icu-data-file-path=" + _icuDataPath
                };

                if (args != null)
                {
                    Collections.AddAll(shellArgs, args);
                }

                if (_isPrecompiledAsSharedLibrary)
                {
                    shellArgs.Add(
                        "--" + AOT_SHARED_LIBRARY_PATH + "=" +
                        Path.Combine(PathUtils.GetDataDirectory(applicationContext), _aotSharedLibraryPath));
                }
                else
                {
                    if (_isPrecompiledAsBlobs)
                    {
                        shellArgs.Add("--" + AOT_SNAPSHOT_PATH_KEY + "=" + PathUtils.GetDataDirectory(applicationContext));
                    }
                    else
                    {
                        shellArgs.Add("--cache-dir-path=" + PathUtils.GetCacheDirectory(applicationContext));
                        shellArgs.Add(
                            "--" + AOT_SNAPSHOT_PATH_KEY + "=" +
                            Path.Combine(PathUtils.GetDataDirectory(applicationContext), _flutterAssetsDir));
                    }

                    shellArgs.Add("--" + AOT_VM_SNAPSHOT_DATA_KEY + "=" + _aotVmSnapshotData);
                    shellArgs.Add("--" + AOT_VM_SNAPSHOT_INSTR_KEY + "=" + _aotVmSnapshotInstr);
                    shellArgs.Add("--" + AOT_ISOLATE_SNAPSHOT_DATA_KEY + "=" + _aotIsolateSnapshotData);
                    shellArgs.Add("--" + AOT_ISOLATE_SNAPSHOT_INSTR_KEY + "=" + _aotIsolateSnapshotInstr);
                }

                if (_settings.LogTag != null)
                {
                    shellArgs.Add("--log-tag=" + _settings.LogTag);
                }

                var appBundlePath = FindAppBundlePath(applicationContext);
                var appStoragePath = PathUtils.GetFilesDir(applicationContext);
                var engineCachesPath = PathUtils.GetCacheDirectory(applicationContext);

                NativeInit(
                    applicationContext,
                    shellArgs.ToArray(),
                    appBundlePath,
                    appStoragePath,
                    engineCachesPath);

                _initialized = true;
            }
            catch (Exception e)
            {
                Log.Error(TAG, "Flutter initialization failed.", e);
                throw;
            }
        }

        public static string FindAppBundlePath(Context applicationContext)
        {
            var dataDirectory = PathUtils.GetDataDirectory(applicationContext);
            var appBundle = new File(dataDirectory, _flutterAssetsDir);
            return appBundle.Exists() ? appBundle.Path : null;
        }

        /**
         * Returns the file name for the given asset.
         * The returned file name can be used to access the asset in the APK
         * through the {@link AssetManager} API.
         *
         * @param asset the name of the asset. The name can be hierarchical
         * @return      the filename to be used with {@link AssetManager}
         */
        public static string GetLookupKeyForAsset(string asset)
        {
            return FromFlutterAssets(asset);
        }

        /**
         * Returns the file name for the given asset which originates from the
         * specified packageName. The returned file name can be used to access
         * the asset in the APK through the {@link AssetManager} API.
         *
         * @param asset       the name of the asset. The name can be hierarchical
         * @param packageName the name of the package from which the asset originates
         * @return            the file name to be used with {@link AssetManager}
         */
        public static string GetLookupKeyForAsset(string asset, string packageName)
        {
            return GetLookupKeyForAsset(Path.Combine("packages", packageName, asset));
        }

        public static string GetUpdateInstallationPath()
        {
            return _resourceUpdater?.GetUpdateInstallationPath();
        }

        public static bool IsRunningPrecompiledCode()
        {
            return _isPrecompiledAsBlobs || _isPrecompiledAsSharedLibrary;
        }

        /**
         * Starts initialization of the native system.
         * @param applicationContext The Android application context.
         * @param settings Configuration settings.
         */
        public static async Task StartInitialization(Context applicationContext, FlutterSettings settings = null)
        {
            if (!IsMainLoop)
                throw new ThreadStateException("startInitialization must be called on the main thread");

            // Do not run startInitialization more than once.
            if (_settings != null)
                return;

            _settings   = settings ?? new Settings();
            MainContext = applicationContext;

            _stopwatch = Stopwatch.StartNew();
            _stopwatch.Start();

            InitConfig(applicationContext);
            InitAot(applicationContext);
            await InitResources(applicationContext);
        }

        private static string FromFlutterAssets(string filePath)
        {
            return Path.Combine(_flutterAssetsDir, filePath);
        }

        private static void InitAot(Context applicationContext)
        {
            var assets = ListAssets(applicationContext, "");
            _isPrecompiledAsBlobs =
                assets.Contains(_aotVmSnapshotData) &&
                assets.Contains(_aotVmSnapshotInstr) &&
                assets.Contains(_aotIsolateSnapshotData) &&
                assets.Contains(_aotIsolateSnapshotInstr);

            _isPrecompiledAsSharedLibrary = assets.Contains(_aotSharedLibraryPath);
            if (_isPrecompiledAsBlobs && _isPrecompiledAsSharedLibrary)
            {
                throw new RuntimeException(
                    "Found precompiled app as shared library and as Dart VM snapshots.");
            }
        }

        /// <summary>
        /// Src: flutter_main.cc + .h
        /// This was all the native Dart stuff and optimizations
        /// </summary>
        private static void NativeInit(
            Context context,
            string[] args,
            string bundlePath,
            string appStoragePath,
            string engineCachesPath)
        { }

        /**
         * Initialize our Flutter config values by obtaining them from the
         * manifest XML file, falling back to default values.
         */
        private static void InitConfig(Context applicationContext)
        {
            try
            {
                var metadata = applicationContext.PackageManager.GetApplicationInfo(
                    applicationContext.PackageName,
                    PackageInfoFlags.MetaData).MetaData;
                if (metadata != null)
                {
                    _aotSharedLibraryPath    = metadata.GetString(PUBLIC_AOT_AOT_SHARED_LIBRARY_PATH, DEFAULT_AOT_SHARED_LIBRARY_PATH);
                    _aotVmSnapshotData       = metadata.GetString(PUBLIC_AOT_VM_SNAPSHOT_DATA_KEY, DEFAULT_AOT_VM_SNAPSHOT_DATA);
                    _aotVmSnapshotInstr      = metadata.GetString(PUBLIC_AOT_VM_SNAPSHOT_INSTR_KEY, DEFAULT_AOT_VM_SNAPSHOT_INSTR);
                    _aotIsolateSnapshotData  = metadata.GetString(PUBLIC_AOT_ISOLATE_SNAPSHOT_DATA_KEY, DEFAULT_AOT_ISOLATE_SNAPSHOT_DATA);
                    _aotIsolateSnapshotInstr = metadata.GetString(PUBLIC_AOT_ISOLATE_SNAPSHOT_INSTR_KEY, DEFAULT_AOT_ISOLATE_SNAPSHOT_INSTR);
                    _flx                     = metadata.GetString(PUBLIC_FLX_KEY, DEFAULT_FLX);
                    _flutterAssetsDir        = metadata.GetString(PUBLIC_FLUTTER_ASSETS_DIR_KEY, DEFAULT_FLUTTER_ASSETS_DIR);
                }
            }
            catch (PackageManager.NameNotFoundException e)
            {
                throw new RuntimeException(e);
            }
        }

        private static async Task InitResources(Context applicationContext)
        {
            var context = applicationContext;
            new ResourceCleaner(context).Start();

            Bundle metaData = null;
            try
            {
                metaData = context.PackageManager.GetApplicationInfo(
                    context.PackageName,
                    PackageInfoFlags.MetaData).MetaData;
            }
            catch (PackageManager.NameNotFoundException e)
            {
                Log.Error(TAG, "Unable to read application info", e);
            }

            if (metaData != null && metaData.GetBoolean("DynamicUpdates"))
            {
                _resourceUpdater = new ResourceUpdater(context);
                _resourceUpdater.StartUpdateDownloadOnce();
                await _resourceUpdater.WaitForDownloadCompletion();
            }

            _resourceExtractor = new ResourceExtractor(context);

            var icuAssetPath = Path.Combine(SHARED_ASSET_DIR, SHARED_ASSET_ICU_DATA);
            _resourceExtractor.AddResource(icuAssetPath);
            _icuDataPath = Path.Combine(PathUtils.GetDataDirectory(applicationContext), icuAssetPath);

            _resourceExtractor
               .AddResource(FromFlutterAssets(_flx))
               .AddResource(FromFlutterAssets(_aotVmSnapshotData))
               .AddResource(FromFlutterAssets(_aotVmSnapshotInstr))
               .AddResource(FromFlutterAssets(_aotIsolateSnapshotData))
               .AddResource(FromFlutterAssets(_aotIsolateSnapshotInstr))
               .AddResource(FromFlutterAssets(DEFAULT_KERNEL_BLOB));
            if (_isPrecompiledAsSharedLibrary)
            {
                _resourceExtractor
                   .AddResource(_aotSharedLibraryPath);
            }
            else
            {
                _resourceExtractor
                   .AddResource(_aotVmSnapshotData)
                   .AddResource(_aotVmSnapshotInstr)
                   .AddResource(_aotIsolateSnapshotData)
                   .AddResource(_aotIsolateSnapshotInstr);
            }

            _resourceExtractor.Start();
        }

        private static void InitResources()
        {
            new ResourceCleaner(MainContext).Start();
        }

        /**
         * Returns a list of the file names at the root of the application's asset
         * path.
         */
        private static List<string> ListAssets(Context applicationContext, string path)
        {
            var manager = applicationContext.Resources.Assets;
            try
            {
                return manager.List(path).ToList();
            }
            catch (Exception e)
            {
                Log.Error(TAG, "Unable to list assets", e);
                throw;
            }
        }

        public static Settings Settings { get; }
    }
}
