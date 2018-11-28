using System;
using System.Collections.Generic;
using FlutterBinding.Engine;
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

        // TODO: PlatformMessage?
        // TODO: Do we need these?
        //void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };

    public class Engine : RuntimeDelegate
    {
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
            // TODO: PlatformMessage
            //void OnEngineHandlePlatformMessage(PlatformMessage message);
            void OnPreEngineRestart();
        };

        private Engine(
            Delegate @delegate,
            TaskRunners task_runners,
            Settings settings,
            Animator animator,
            GRContext resource_context)
        {
            delegate_ = @delegate;
            settings_ = settings;
            animator_ = animator;
            activity_running_ = false;
            have_surface_ = false;
        }

        //private readonly FML_WARN_UNUSED_RESULT
        private RunStatus Run(RunConfiguration configuration)
        {

        }

        // Used to "cold reload" a running application where the shell (along with the
        // platform view and its rasterizer bindings) remains the same but the root
        // isolate is torn down and restarted with the new configuration. Only used in
        // the development workflow.
        //FML_WARN_UNUSED_RESULT 
        private bool Restart(RunConfiguration configuration)
        {

        }

        private bool UpdateAssetManager(AssetManager asset_manager)
        {

        }

        private void BeginFrame(TimePoint frame_time)
        {

        }

        private void NotifyIdle(long deadline)
        {

        }

        //private Dart_Port GetUIIsolateMainPort();
        //private string GetUIIsolateName();
        //private bool UIIsolateHasLivePorts();
        //private tonic::DartErrorHandleType GetUIIsolateLastError();
        //private std::pair<bool, uint32_t> GetUIIsolateReturnCode();

        private void OnOutputSurfaceCreated()
        {

        }

        private void OnOutputSurfaceDestroyed()
        {

        }

        private void SetViewportMetrics(ViewportMetrics metrics)
        {

        }

        //private void DispatchPlatformMessage(PlatformMessage message);

        private void DispatchPointerDataPacket(PointerDataPacket packet)
        {

        }

        private void DispatchSemanticsAction(
            int id,
            SemanticsAction action,
            List<byte> args)
        {

        }

        private void SetSemanticsEnabled(bool enabled)
        {

        }

        private void SetAccessibilityFeatures(Int32 flags)
        {

        }

        public void ScheduleFrame(bool regenerate_layer_tree = true)
        {

        }

        // |blink::RuntimeDelegate|
        // FontCollection private GetFontCollection();

        private Engine.Delegate delegate_;
        private Settings settings_;
        private readonly Animator animator_;
        //private readonly RuntimeController runtime_controller_;
        private readonly string initial_route_;
        private readonly ViewportMetrics viewport_metrics_;
        private readonly AssetManager asset_manager_;
        private readonly bool activity_running_;
        private readonly bool have_surface_;
        //private readonly FontCollection font_collection_;
        //private readonly Engine weak_factory_;

        // |blink::RuntimeDelegate|
        public string DefaultRouteName()
        {

        }

        // |blink::RuntimeDelegate|
        public void Render(LayerTree layer_tree)
        {

        }

        // |blink::RuntimeDelegate|
        public void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions)
        {

        }

        // |blink::RuntimeDelegate|
        //public void HandlePlatformMessage(PlatformMessage message);

        private void StopAnimator()
        {

        }

        private void StartAnimatorIfPossible()
        {

        }

        //private bool HandleLifecyclePlatformMessage(PlatformMessage message);
        //private bool HandleNavigationPlatformMessage(PlatformMessage message);
        //private bool HandleLocalizationPlatformMessage(PlatformMessage message);
        //private void HandleSettingsPlatformMessage(PlatformMessage message);
        //private void HandleAssetPlatformMessage(PlatformMessage message);
        private bool GetAssetAsBuffer(string name, List<byte> data)
        {

        }

        private RunStatus PrepareAndLaunchIsolate(RunConfiguration configuration)
        {

        }

        //private FML_DISALLOW_COPY_AND_ASSIGN(Engine);
    }
}
