using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flutter.Shell;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Assets;
using FlutterBinding.Engine.Window;
using FlutterBinding.Flow.Layers;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    public interface RuntimeDelegate
    {
        string DefaultRouteName();

        void ScheduleFrame(bool regenerateLayerTree = true);

        void Render(LayerTree layerTree);

        void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions);

        // Use dependency injection, not platform messages!
        //void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };

    public class Engine : RuntimeDelegate
    {
        private const string kAssetChannel = "flutter/assets";
        private const string kLifecycleChannel = "flutter/lifecycle";
        private const string kNavigationChannel = "flutter/navigation";
        private const string kLocalizationChannel = "flutter/localization";
        private const string kSettingsChannel = "flutter/settings";

        public enum RunStatus
        {
            Success,                // Successful call to Run()
            FailureAlreadyRunning,  // Isolate was already running; may not be
                                    // considered a failure by callers
            Failure,  // Isolate could not be started or other unspecified failure
        };

        public interface Delegate
        {
            void OnEngineUpdateSemantics(SemanticsNodeUpdates update, CustomAccessibilityActionUpdates actions);
            //void OnEngineHandlePlatformMessage(PlatformMessage message);
            Task OnPreEngineRestart();
        };

        public Engine(
            Delegate @delegate,
            //DartVM vm,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            TaskRunners taskRunners,
            Settings settings,
            Animator animator,
            SnapshotDelegate snapshotDelegate,
            GRContext resourceContext,
            SkiaUnrefQueue unrefQueue
            )
        {
            _delegate = @delegate;
            _settings = settings;
            _animator = animator;
            _activityRunning = false;
            _haveSurface = false;

            // Runtime controller is initialized here because it takes a reference to this
            // object as its delegate. The delegate may be called in the constructor and
            // we want to be fully initilazed by that point.
            _runtimeController = new RuntimeController(
                this,                       // runtime delegate
                //vm,                       // VM
                //isolate_snapshot,         // isolate snapshot
                //shared_snapshot,          // shared snapshot
                taskRunners,               // task runners
                snapshotDelegate,          // snapshot delegate
                resourceContext,           // resource context
                unrefQueue                 // skia unref queue
                //settings_.advisory_script_uri,       // advisory script uri
                //settings_.advisory_script_entrypoint // advisory script entrypoint
            );
        }

        //private readonly FML_WARN_UNUSED_RESULT
        private RunStatus Run(RunConfiguration configuration)
        {
            if (!configuration.IsValid())
            {
                //FML_LOG(ERROR) << "Engine run configuration was invalid.";
                return RunStatus.Failure;
            }

            return RunStatus.Success;

            // Xamarin.Flutter does not use Isolates

            //var isolate_launch_status = PrepareAndLaunchIsolate(configuration);
            //if (isolate_launch_status == RunStatus.Failure)
            //{
            //    //FML_LOG(ERROR) << "Engine not prepare and launch isolate.";
            //    return isolate_launch_status;
            //}
            //else if (isolate_launch_status == RunStatus.FailureAlreadyRunning)
            //{
            //    return isolate_launch_status;
            //}

            //// Xamarin.Flutter doesn't use isolates
            //DartIsolate isolate = runtime_controller_.GetRootIsolate().lock () ;

            //bool isolate_running = isolate != null && isolate.GetPhase() == DartIsolate::Phase::Running;
            //if (isolate_running)
            //{
            //    tonic::DartState::Scope scope(isolate.get());

            //    if (settings_.root_isolate_create_callback)
            //    {
            //        settings_.root_isolate_create_callback();
            //    }

            //    if (settings_.root_isolate_shutdown_callback)
            //    {
            //        isolate.AddIsolateShutdownCallback(settings_.root_isolate_shutdown_callback);
            //    }
            //}

            //return isolate_running ? RunStatus.Success : RunStatus.Failure;
        }

        // Used to "cold reload" a running application where the shell (along with the
        // platform view and its rasterizer bindings) remains the same but the root
        // isolate is torn down and restarted with the new configuration. Only used in
        // the development workflow.
        //FML_WARN_UNUSED_RESULT 
        private bool Restart(RunConfiguration configuration)
        {
            //TRACE_EVENT0("flutter", "Engine::Restart");
            if (!configuration.IsValid())
            {
                //FML_LOG(ERROR) << "Engine run configuration was invalid.";
                return false;
            }

            _delegate.OnPreEngineRestart();
            _runtimeController = _runtimeController.Clone();
            UpdateAssetManager(null);

            return Run(configuration) == RunStatus.Success;
        }

        private bool UpdateAssetManager(AssetManager newAssetManager)
        {
            if (_assetManager == newAssetManager)
                return false;

            _assetManager = newAssetManager;
            if (_assetManager == null)
                return false;

            // TODO: Figure out how to use Fonts
            // Using libTXT as the text engine.
            //if (settings_.use_test_fonts)
            //    font_collection_.RegisterTestFonts();
            //else
            //    font_collection_.RegisterFonts(asset_manager_);

            return true;
        }

        public void BeginFrame(TimePoint frameTime)
        {
            //TRACE_EVENT0("flutter", "Engine::BeginFrame");
            _runtimeController.BeginFrame(frameTime);
        }

        public void NotifyIdle(long deadline)
        {
            //TRACE_EVENT1("flutter", "Engine::NotifyIdle", "deadline_now_delta", (deadline - TimePoint.Now().TotalMicroseconds).ToString());
            _runtimeController.NotifyIdle(deadline);
        }

        //private Dart_Port GetUIIsolateMainPort();
        //private string GetUIIsolateName();
        //private bool UIIsolateHasLivePorts();
        //private tonic::DartErrorHandleType GetUIIsolateLastError();
        //private std::pair<bool, uint32_t> GetUIIsolateReturnCode();

        public void OnOutputSurfaceCreated()
        {
            _haveSurface = true;
            StartAnimatorIfPossible();
            ScheduleFrame();
        }

        public void OnOutputSurfaceDestroyed()
        {
            _haveSurface = false;
            StopAnimator();
        }

        public void SetViewportMetrics(ViewportMetrics metrics)
        {
            bool dimensionsChanged =
                _viewportMetrics.physical_height != metrics.physical_height ||
                _viewportMetrics.physical_width != metrics.physical_width;
            _viewportMetrics = metrics;
            _runtimeController.SetViewportMetrics(_viewportMetrics);
            if (_animator != null)
            {
                if (dimensionsChanged)
                    _animator.SetDimensionChangePending();
                if (_haveSurface)
                    ScheduleFrame();
            }
        }

        //private void DispatchPlatformMessage(PlatformMessage message)
        //{
        //    switch (message.channel())
        //    {
        //        case kLifecycleChannel:
        //            if (HandleLifecyclePlatformMessage(message))
        //                return;
        //            break;

        //        case kLocalizationChannel:
        //            if (HandleLocalizationPlatformMessage(message))
        //                return;
        //            break;

        //        case kSettingsChannel:
        //            HandleSettingsPlatformMessage(message);
        //            return;

        //    }

        //    if (runtime_controller_.IsRootIsolateRunning() &&
        //        runtime_controller_.DispatchPlatformMessage(message))
        //    {
        //        return;
        //    }

        //    // If there's no runtime_, we may still need to set the initial route.
        //    if (message.channel() == kNavigationChannel)
        //        HandleNavigationPlatformMessage(message);
        //}

        public void DispatchPointerDataPacket(PointerDataPacket packet)
        {
            _runtimeController.DispatchPointerDataPacket(packet);
        }

        public void DispatchSemanticsAction(
            int id,
            SemanticsAction action,
            object args)
        {
            _runtimeController.DispatchSemanticsAction(id, action, args);
        }

        public void SetSemanticsEnabled(bool enabled)
        {
            _runtimeController.SetSemanticsEnabled(enabled);
        }

        public void SetAccessibilityFeatures(AccessibilityFeatures flags)
        {
            _runtimeController.SetAccessibilityFeatures(flags);
        }

        public void ScheduleFrame(bool regenerate_layer_tree = true)
        {
            _animator.RequestFrame(regenerate_layer_tree);
        }

        // |blink::RuntimeDelegate|
        //public FontCollection private GetFontCollection() => font_collection_;

        private readonly Delegate _delegate;
        private Settings _settings;
        private readonly Animator _animator;
        private RuntimeController _runtimeController;
        private string _initialRoute;
        private ViewportMetrics _viewportMetrics;
        private AssetManager _assetManager;
        private bool _activityRunning;
        private bool _haveSurface;
        //private readonly FontCollection font_collection_;
        //private readonly Engine weak_factory_;

        // |blink::RuntimeDelegate|
        public string DefaultRouteName()
        {
            if (!string.IsNullOrWhiteSpace(_initialRoute))
                return _initialRoute;
            return "/";
        }

        // |blink::RuntimeDelegate|
        public void Render(LayerTree layerTree)
        {
            if (layerTree == null)
                return;

            var frameSize = new SKSizeI((int)_viewportMetrics.physical_width, (int)_viewportMetrics.physical_height);
            if (frameSize.IsEmpty)
                return;

            layerTree.set_frame_size(frameSize);
            _animator.Render(layerTree);
        }

        // |blink::RuntimeDelegate|
        public void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions)
        {
            _delegate.OnEngineUpdateSemantics(update, actions);
        }

        // |blink::RuntimeDelegate|
        //public void HandlePlatformMessage(PlatformMessage message)
        //{
        //    if (message.channel() == kAssetChannel)
        //        HandleAssetPlatformMessage(message);
        //    else
        //        delegate_.OnEngineHandlePlatformMessage(message);
        //}

        private void StopAnimator()
        {
            _animator.Stop();
        }

        private void StartAnimatorIfPossible()
        {
            if (_activityRunning && _haveSurface)
                _animator.Start();
        }

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
