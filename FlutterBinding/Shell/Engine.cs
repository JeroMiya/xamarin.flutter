using System;
using System.Collections.Generic;
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

        void ScheduleFrame(bool regenerate_layer_tree = true);

        void Render(LayerTree layer_tree);

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
            void OnPreEngineRestart();
        };

        private Engine(
            Delegate @delegate,
            //DartVM vm,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            TaskRunners task_runners,
            Settings settings,
            Animator animator,
            SnapshotDelegate snapshot_delegate,
            GRContext resource_context
            //SkiaUnrefQueue unref_queue
            )
        {
            delegate_ = @delegate;
            settings_ = settings;
            animator_ = animator;
            activity_running_ = false;
            have_surface_ = false;

            // Runtime controller is initialized here because it takes a reference to this
            // object as its delegate. The delegate may be called in the constructor and
            // we want to be fully initilazed by that point.
            runtime_controller_ = new RuntimeController(
                this,                       // runtime delegate
                //vm,                       // VM
                //isolate_snapshot,         // isolate snapshot
                //shared_snapshot,          // shared snapshot
                task_runners,               // task runners
                snapshot_delegate,          // snapshot delegate
                resource_context            // resource context
                //unref_queue,              // skia unref queue
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

            delegate_.OnPreEngineRestart();
            runtime_controller_ = runtime_controller_.Clone();
            UpdateAssetManager(null);

            return Run(configuration) == RunStatus.Success;
        }

        private bool UpdateAssetManager(AssetManager new_asset_manager)
        {
            if (asset_manager_ == new_asset_manager)
                return false;

            asset_manager_ = new_asset_manager;
            if (asset_manager_ == null)
                return false;

            // TODO: Figure out how to use Fonts
            // Using libTXT as the text engine.
            //if (settings_.use_test_fonts)
            //    font_collection_.RegisterTestFonts();
            //else
            //    font_collection_.RegisterFonts(asset_manager_);

            return true;
        }

        private void BeginFrame(TimePoint frame_time)
        {
            //TRACE_EVENT0("flutter", "Engine::BeginFrame");
            runtime_controller_.BeginFrame(frame_time);
        }

        private void NotifyIdle(long deadline)
        {
            //TRACE_EVENT1("flutter", "Engine::NotifyIdle", "deadline_now_delta", (deadline - TimePoint.Now().TotalMicroseconds).ToString());
            runtime_controller_.NotifyIdle(deadline);
        }

        //private Dart_Port GetUIIsolateMainPort();
        //private string GetUIIsolateName();
        //private bool UIIsolateHasLivePorts();
        //private tonic::DartErrorHandleType GetUIIsolateLastError();
        //private std::pair<bool, uint32_t> GetUIIsolateReturnCode();

        private void OnOutputSurfaceCreated()
        {
            have_surface_ = true;
            StartAnimatorIfPossible();
            ScheduleFrame();
        }

        private void OnOutputSurfaceDestroyed()
        {
            have_surface_ = false;
            StopAnimator();
        }

        private void SetViewportMetrics(ViewportMetrics metrics)
        {
            bool dimensions_changed =
                viewport_metrics_.physical_height != metrics.physical_height ||
                viewport_metrics_.physical_width != metrics.physical_width;
            viewport_metrics_ = metrics;
            runtime_controller_.SetViewportMetrics(viewport_metrics_);
            if (animator_ != null)
            {
                if (dimensions_changed)
                    animator_.SetDimensionChangePending();
                if (have_surface_)
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

        private void DispatchPointerDataPacket(PointerDataPacket packet)
        {
            runtime_controller_.DispatchPointerDataPacket(packet);
        }

        private void DispatchSemanticsAction(
            int id,
            SemanticsAction action,
            List<byte> args)
        {
            runtime_controller_.DispatchSemanticsAction(id, action, args);
        }

        private void SetSemanticsEnabled(bool enabled)
        {
            runtime_controller_.SetSemanticsEnabled(enabled);
        }

        private void SetAccessibilityFeatures(AccessibilityFeatures flags)
        {
            runtime_controller_.SetAccessibilityFeatures(flags);
        }

        public void ScheduleFrame(bool regenerate_layer_tree = true)
        {
            animator_.RequestFrame(regenerate_layer_tree);
        }

        // |blink::RuntimeDelegate|
        //public FontCollection private GetFontCollection() => font_collection_;

        private Engine.Delegate delegate_;
        private Settings settings_;
        private Animator animator_;
        private RuntimeController runtime_controller_;
        private string initial_route_;
        private ViewportMetrics viewport_metrics_;
        private AssetManager asset_manager_;
        private bool activity_running_;
        private bool have_surface_;
        //private readonly FontCollection font_collection_;
        //private readonly Engine weak_factory_;

        // |blink::RuntimeDelegate|
        public string DefaultRouteName()
        {
            if (!string.IsNullOrWhiteSpace(initial_route_))
                return initial_route_;
            return "/";
        }

        // |blink::RuntimeDelegate|
        public void Render(LayerTree layer_tree)
        {
            if (layer_tree == null)
                return;

            var frame_size = new SKSizeI((int)viewport_metrics_.physical_width, (int)viewport_metrics_.physical_height);
            if (frame_size.IsEmpty)
                return;

            layer_tree.set_frame_size(frame_size);
            animator_.Render(layer_tree);
        }

        // |blink::RuntimeDelegate|
        public void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions)
        {
            delegate_.OnEngineUpdateSemantics(update, actions);
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
            animator_.Stop();
        }

        private void StartAnimatorIfPossible()
        {
            if (activity_running_ && have_surface_)
                animator_.Start();
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
