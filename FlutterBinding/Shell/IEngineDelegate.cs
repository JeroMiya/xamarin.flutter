using System.Threading.Tasks;
using FlutterBinding.UI;

namespace FlutterBinding.Shell
{
    public partial class Engine
    {
        public interface IEngineDelegate
        {
            void OnEngineUpdateSemantics(SemanticsNodeUpdates update, CustomAccessibilityActionUpdates actions);

            //void OnEngineHandlePlatformMessage(PlatformMessage message);
            Task OnPreEngineRestart();
        };

        //private bool HandleLifecyclePlatformMessage(PlatformMessage message)
        //{
        //    var data = message.Data;
        //    string state = (string)data;// (reinterpret_cast<const char*> (data.data()), data.size());
        //    if (state == "AppLifecycleState.paused" ||
        //        state == "AppLifecycleState.suspending")
        //    {
        //        activity_running_ = false;
        //        StopAnimator();
        //    }
        //    else if (state == "AppLifecycleState.resumed" ||
        //        state == "AppLifecycleState.inactive")
        //    {
        //        activity_running_ = true;
        //        StartAnimatorIfPossible();
        //    }

        //    // Always schedule a frame when the app does become active as per API
        //    // recommendation
        //    // https://developer.apple.com/documentation/uikit/uiapplicationdelegate/1622956-applicationdidbecomeactive?language=objc
        //    if (state == "AppLifecycleState.resumed" && have_surface_)
        //    {
        //        ScheduleFrame();
        //    }
        //    return false; 
        //}

        //private bool HandleNavigationPlatformMessage(PlatformMessage message)
        //{
        //    var data = message.data();

        //    rapidjson::Document document;
        //    document.Parse(reinterpret_cast <const char*> (data.data()), data.size());
        //    if (document.HasParseError() || !document.IsObject())
        //        return false;
        //    auto root = document.GetObject();
        //    auto method = root.FindMember("method");
        //    if (method->value != "setInitialRoute")
        //        return false;
        //    auto route = root.FindMember("args");
        //    initial_route_ = std::move(route->value.GetString());
        //    return true;
        //}

        //private bool HandleLocalizationPlatformMessage(PlatformMessage message)
        //{
        //    var data = message.Data;

        //    rapidjson::Document document = new rapidjson::Document();
        //    document.Parse(reinterpret_cast <const char*> (data.data()), data.size());
        //    if (document.HasParseError() || !document.IsObject())
        //        return false;
        //    var root = document.GetObject();
        //    var method = root.FindMember("method");
        //    if (method == root.MemberEnd() || method->value != "setLocale")
        //        return false;

        //    var args = root.FindMember("args");
        //    if (args == root.MemberEnd() || !args->value.IsArray())
        //        return false;

        //    int strings_per_locale = 4;
        //    if (args.value.Size() % strings_per_locale != 0)
        //        return false;
        //    var locale_data = new List<string>();
        //    for (var locale_index = 0; locale_index < args.value.Size(); locale_index += strings_per_locale)
        //    {
        //        if (!args.value[locale_index].IsString() ||
        //            !args.value[locale_index + 1].IsString())
        //            return false;
        //        locale_data.Add(args.value[locale_index].GetString());
        //        locale_data.Add(args.value[locale_index + 1].GetString());
        //        locale_data.Add(args.value[locale_index + 2].GetString());
        //        locale_data.Add(args.value[locale_index + 3].GetString());
        //    }

        //    return runtime_controller_.SetLocales(locale_data);
        //}

        //private void HandleSettingsPlatformMessage(PlatformMessage message)
        //{
        //    var data = (string)message.Data;
        //    if (runtime_controller_.SetUserSettingsData(data) && have_surface_)
        //    {
        //        ScheduleFrame();
        //    }
        //}

        //private void HandleAssetPlatformMessage(PlatformMessage message)
        //{
        //}

        // TODO: Can't find implmentation for this, or any use
        //private bool GetAssetAsBuffer(string name, List<byte> data)
        //{

        //}

        // Xamarin.Flutter doesn't use isolates
        //private RunStatus PrepareAndLaunchIsolate(RunConfiguration configuration)
        //{
        //    //TRACE_EVENT0("flutter", "Engine::PrepareAndLaunchIsolate");

        //    UpdateAssetManager(configuration.GetAssetManager());

        //    var isolate_configuration = configuration.TakeIsolateConfiguration();

        //    DartIsolate isolate = runtime_controller_.GetRootIsolate().lock () ;

        //    if (!isolate)
        //        return RunStatus.Failure;

        //    // This can happen on iOS after a plugin shows a native window and returns to
        //    // the Flutter ViewController.
        //    if (isolate.GetPhase() == DartIsolate::Phase::Running)
        //    {
        //        //FML_DLOG(WARNING) << "Isolate was already running!";
        //        return RunStatus.FailureAlreadyRunning;
        //    }

        //    if (!isolate_configuration.PrepareIsolate(*isolate))
        //    {
        //        //FML_LOG(ERROR) << "Could not prepare to run the isolate.";
        //        return RunStatus.Failure;
        //    }

        //    if (configuration.GetEntrypointLibrary().empty())
        //    {
        //        if (!isolate.Run(configuration.GetEntrypoint()))
        //        {
        //            //FML_LOG(ERROR) << "Could not run the isolate.";
        //            return RunStatus.Failure;
        //        }
        //    }
        //    else
        //    {
        //        if (!isolate.RunFromLibrary(configuration.GetEntrypointLibrary(), configuration.GetEntrypoint()))
        //        {
        //            //FML_LOG(ERROR) << "Could not run the isolate.";
        //            return RunStatus.Failure;
        //        }
        //    }

        //    return RunStatus.Success;
        //}

        //private FML_DISALLOW_COPY_AND_ASSIGN(Engine);
    }
}
