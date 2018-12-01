using FlutterBinding.Engine;
using FlutterBinding.Engine.Assets;

namespace FlutterBinding.Shell
{
    public class RunConfiguration
    {
        public static RunConfiguration InferFromSettings(
            Settings settings, 
            TaskRunner io_worker = null)
        {
            var asset_manager = new AssetManager();

            asset_manager.PushBack(new DirectoryAssetBundle(settings.assets_dir));
            asset_manager.PushBack(new DirectoryAssetBundle(settings.assets_path));

            return new RunConfiguration(
                //IsolateConfiguration::InferFromSettings(settings, asset_manager, io_worker),
                asset_manager);
        }

        public RunConfiguration(
            //IsolateConfiguration configuration, 
            AssetManager asset_manager = null)
        {
            //isolate_configuration_ = configuration;
            asset_manager_ = asset_manager ?? new AssetManager();
        }

        public bool IsValid() => asset_manager_ != null;
            //&& isolate_configuration_ != null;

        public bool AddAssetResolver(AssetResolver resolver)
        {
            if (resolver == null || !resolver.IsValid())
                return false;

            asset_manager_.PushBack(resolver);
            return true;
        }

        public void SetEntrypoint(string entrypoint)
        {
            entrypoint_ = entrypoint;
        }

        public void SetEntrypointAndLibrary(string entrypoint, string library)
        {
            SetEntrypoint(entrypoint);
            entrypoint_library_ = library;
        }

        public AssetManager GetAssetManager() => asset_manager_;

        public string GetEntrypoint() => entrypoint_;

        public string GetEntrypointLibrary() => entrypoint_library_;

        //public IsolateConfiguration TakeIsolateConfiguration()
        //{
        //    var result = isolate_configuration_;
        //    isolate_configuration_ = null;
        //    return result;
        //}


        //private IsolateConfiguration isolate_configuration_;
        private AssetManager asset_manager_;
        private string entrypoint_ = "main";
        private string entrypoint_library_ = "";

        //FML_DISALLOW_COPY_AND_ASSIGN(RunConfiguration);
    };
}