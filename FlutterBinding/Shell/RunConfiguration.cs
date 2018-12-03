using FlutterBinding.Engine;
using FlutterBinding.Engine.Assets;

namespace FlutterBinding.Shell
{
    public class RunConfiguration
    {
        public static RunConfiguration InferFromSettings(
            Settings settings, 
            TaskRunner ioWorker = null)
        {
            var assetManager = new AssetManager();

            assetManager.PushBack(new DirectoryAssetBundle(settings.AssetsDir));
            assetManager.PushBack(new DirectoryAssetBundle(settings.AssetsPath));

            return new RunConfiguration(
                //IsolateConfiguration::InferFromSettings(settings, asset_manager, io_worker),
                assetManager);
        }

        public RunConfiguration(
            //IsolateConfiguration configuration, 
            AssetManager assetManager = null)
        {
            //isolate_configuration_ = configuration;
            _assetManager = assetManager ?? new AssetManager();
        }

        public bool IsValid() => _assetManager != null;
            //&& isolate_configuration_ != null;

        public bool AddAssetResolver(AssetResolver resolver)
        {
            if (resolver == null || !resolver.IsValid())
                return false;

            _assetManager.PushBack(resolver);
            return true;
        }

        public void SetEntrypoint(string entrypoint)
        {
            _entrypoint = entrypoint;
        }

        public void SetEntrypointAndLibrary(string entrypoint, string library)
        {
            SetEntrypoint(entrypoint);
            _entrypointLibrary = library;
        }

        public AssetManager GetAssetManager() => _assetManager;

        public string GetEntrypoint() => _entrypoint;

        public string GetEntrypointLibrary() => _entrypointLibrary;

        //public IsolateConfiguration TakeIsolateConfiguration()
        //{
        //    var result = isolate_configuration_;
        //    isolate_configuration_ = null;
        //    return result;
        //}


        //private IsolateConfiguration isolate_configuration_;
        private readonly AssetManager _assetManager;
        private string _entrypoint = "main";
        private string _entrypointLibrary = "";

        //FML_DISALLOW_COPY_AND_ASSIGN(RunConfiguration);
    };
}