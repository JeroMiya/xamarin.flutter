using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Assets;
using FlutterBinding.Flow.Layers;
using FlutterBinding.Plugin.Common;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    public partial class Engine : IRuntimeDelegate
    {
        private const string kAssetChannel = "flutter/assets";
        private const string kLifecycleChannel = "flutter/lifecycle";
        private const string kNavigationChannel = "flutter/navigation";
        private const string kLocalizationChannel = "flutter/localization";
        private const string kSettingsChannel = "flutter/settings";

        public enum RunStatus
        {
            Success,               // Successful call to Run()
            FailureAlreadyRunning, // Isolate was already running; may not be

            // considered a failure by callers
            Failure, // Isolate could not be started or other unspecified failure
        };

        public interface IEngineDelegate
        {
            void OnEngineUpdateSemantics(SemanticsNodeUpdates update, CustomAccessibilityActionUpdates actions);

            void OnEngineHandlePlatformMessage(PlatformMessage message);
            Task OnPreEngineRestart();
        };

        public Engine(
            Engine.IEngineDelegate @delegate,
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
            _delegate        = @delegate;
            _settings        = settings;
            _animator        = animator;
            _activityRunning = false;
            _haveSurface     = false;

            // Runtime controller is initialized here because it takes a reference to this
            // object as its delegate. The delegate may be called in the constructor and
            // we want to be fully initilazed by that point.
            _runtimeController = new RuntimeController(
                this, // runtime delegate
                //vm,                       // VM
                //isolate_snapshot,         // isolate snapshot
                //shared_snapshot,          // shared snapshot
                taskRunners,      // task runners
                snapshotDelegate, // snapshot delegate
                resourceContext,  // resource context
                unrefQueue        // skia unref queue
                //settings_.advisory_script_uri,       // advisory script uri
                //settings_.advisory_script_entrypoint // advisory script entrypoint
            );
        }

        //private readonly FML_WARN_UNUSED_RESULT
        public RunStatus Run(RunConfiguration configuration)
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
        public bool Restart(RunConfiguration configuration)
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

        public bool UpdateAssetManager(AssetManager newAssetManager)
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
                _viewportMetrics.PhysicalHeight != metrics.PhysicalHeight ||
                _viewportMetrics.PhysicalWidth != metrics.PhysicalWidth;
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

        private void DispatchPlatformMessage(PlatformMessage message)
        {
            switch (message.Channel)
            {
            case kLifecycleChannel:
                if (HandleLifecyclePlatformMessage(message))
                    return;
                break;

            case kLocalizationChannel:
                if (HandleLocalizationPlatformMessage(message))
                    return;
                break;

            case kSettingsChannel:
                HandleSettingsPlatformMessage(message);
                return;
            }

            if ( //TODO: Assume always running ->
                 //_runtimeController.IsRootIsolateRunning() &&
                _runtimeController.DispatchPlatformMessage(message))
            {
                return;
            }

            // If there's no runtime_, we may still need to set the initial route.
            if (message.Channel == kNavigationChannel)
                HandleNavigationPlatformMessage(message);
        }

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

        private readonly Engine.IEngineDelegate _delegate;
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

            SKSizeI frameSize = new SKSizeI(_viewportMetrics.PhysicalWidth, _viewportMetrics.PhysicalHeight);
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
        public void HandlePlatformMessage(PlatformMessage message)
        {
            if (message.Channel == kAssetChannel)
                HandleAssetPlatformMessage(message);
            else
                _delegate.OnEngineHandlePlatformMessage(message);
        }

        private void StopAnimator()
        {
            _animator.Stop();
        }

        private void StartAnimatorIfPossible()
        {
            if (_activityRunning && _haveSurface)
                _animator.Start();
        }

        private bool HandleLifecyclePlatformMessage(PlatformMessage message)
        {
            string state = message.ResponseData.ToString(); // (reinterpret_cast<const char*> (data.data()), data.size());
            if (state == "AppLifecycleState.paused" ||
                state == "AppLifecycleState.suspending")
            {
                _activityRunning = false;
                StopAnimator();
            }
            else if (state == "AppLifecycleState.resumed" ||
                state == "AppLifecycleState.inactive")
            {
                _activityRunning = true;
                StartAnimatorIfPossible();
            }

            // Always schedule a frame when the app does become active as per API
            // recommendation
            // https://developer.apple.com/documentation/uikit/uiapplicationdelegate/1622956-applicationdidbecomeactive?language=objc
            if (state == "AppLifecycleState.resumed" && _haveSurface)
            {
                ScheduleFrame();
            }
            return false;
        }

        private bool HandleNavigationPlatformMessage(PlatformMessage message)
        {
            if (!(message.RequestData is MethodCall methodCall))
                throw new InvalidOperationException($"HandleNavigationPlatformMessage: {message}");

            switch (methodCall.Method)
            {
                case "setInitialRoute":
                    _initialRoute = (string)methodCall.Arguments;
                    return true;
            }
            throw new InvalidOperationException($"HandleNavigationPlatformMessage: Method: {methodCall.Method}");
        }

        private bool HandleLocalizationPlatformMessage(PlatformMessage message)
        {
            if (!(message.RequestData is MethodCall methodCall))
                throw new InvalidOperationException($"HandleLocalizationPlatformMessage: {message}");

            switch (methodCall.Method)
            {
                case "setLocale":
                    var locales = methodCall.GetArguments<List<Locale>>();
                    _runtimeController.SetLocales(locales);
                    return true;
            }

            throw new InvalidOperationException($"HandleLocalizationPlatformMessage: Method: {methodCall.Method}");
        }

        private void HandleSettingsPlatformMessage(PlatformMessage message)
        {
            var data = (string)message.RequestData;
            if (_runtimeController.SetUserSettingsData(data) && _haveSurface)
            {
                ScheduleFrame();
            }
        }

        private void HandleAssetPlatformMessage(PlatformMessage message)
        {
            if (!(message.ResponseData is string assetName))
                return;

            var assetMapping = _assetManager?.GetAsMapping(assetName);
            if (assetMapping != null)
            {
                message.OnResponse?.Invoke(assetMapping);
                return;
            }

            message.OnResponse?.Invoke(null);
        }

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
