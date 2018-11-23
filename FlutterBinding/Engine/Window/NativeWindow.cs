using FlutterBinding.UI;
using System;
using System.Collections.Generic;
using System.Text;
using FlutterBinding.Flow.Layers;

namespace FlutterBinding.Engine.Window
{
    public class NativeWindow
    {
        public void Render(Scene scene)
        {
            Engine.Instance.Render(scene.TakeLayerTree());
        }
    }

    public interface WindowClient
    {
        string DefaultRouteName();
        void ScheduleFrame();
        void Render(Scene scene);

        void UpdateSemantics(SemanticsUpdate update);

        //void HandlePlatformMessage(PlatformMessage message);
        void SetIsolateDebugName(string isolateName);
        //FontCollection GetFontCollection();
    };

    public interface RuntimeDelegate
    {
        string DefaultRouteName();
        void ScheduleFrame(bool regenerate_layer_tree = true);
        void Render(LayerTree layer_tree);

        void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions);

        //void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };


    public sealed class RuntimeController : WindowClient
    {
        private readonly RuntimeDelegate _client;

        public RuntimeController(RuntimeDelegate client) 
            : this(client, new WindowData())
        {
            //DartVM vm
            //DartSnapshot isolate_snapshot
            //DartSnapshot shared_snapshot
            //TaskRunners task_runners
            //SnapshotDelegate snapshot_delegate
            //GrContext resource_context
            //SkiaUnrefQueue unref_queue
            //string advisory_script_uri
            //string advisory_script_entrypoint
        }

        RuntimeController(RuntimeDelegate client, WindowData data)
        {
            window_data_ = data;
            client_      = client;

            //DartVM dartVM
            //DartSnapshot isolate_snapshot
            //DartSnapshot shared_snapshot
            //TaskRunners task_runners
            //SnapshotDelegate snapshot_delegate
            //GrContext resource_context
            //SkiaUnrefQueue unref_queue
            //string advisory_script_uri
            //string advisory_script_entrypoint

            DartIsolate root_isolate = root_isolate_.lock();
            root_isolate.SetReturnCodeCallback(
                (uint code) =>
                {
                    root_isolate_return_code_ = new Tuple<bool, uint>(true, code);
                });
            if (var window = GetWindowIfAvailable())
            {
                tonic::DartState::Scope scope = new Scope(root_isolate);
                window.DidCreateIsolate();
                if (!FlushRuntimeStateToIsolate())
                {
                    FML_DLOG(ERROR) << "Could not setup intial isolate state.";
                }
            } 
            else 
            {
                FML_DCHECK(false) << "RuntimeController created without window binding.";
            }
            FML_DCHECK(Dart_CurrentIsolate() == nullptr);
        }

        public RuntimeController Clone()
        {
            return new RuntimeController(
                client_, //
                //vm_,                         //
                //isolate_snapshot_,           //
                //shared_snapshot_,            //
                //task_runners_,               //
                //snapshot_delegate_,          //
                //resource_context_,           //
                //unref_queue_,                //
                //advisory_script_uri_,        //
                //advisory_script_entrypoint_, //
                window_data_ //
            );
        }

        public bool SetViewportMetrics(ViewportMetrics metrics)
        {
            window_data_.viewport_metrics = metrics;

            var window = GetWindowIfAvailable();
            window?.UpdateWindowMetrics(metrics);
            return window != null;
        }

        public bool SetLocales(List<string> locale_data)
        {
            window_data_.locale_data = locale_data;

            var window = GetWindowIfAvailable();
            window?.UpdateLocales(locale_data);
            return window != null;
        }

        public bool SetUserSettingsData(string data)
        {
            window_data_.user_settings_data = data;

            var window = GetWindowIfAvailable();
            window?.UpdateUserSettingsData(window_data_.user_settings_data);
            return window != null;
        }

        public bool SetSemanticsEnabled(bool enabled)
        {
            window_data_.semantics_enabled = enabled;

            var window = GetWindowIfAvailable();
            window?.UpdateSemanticsEnabled(window_data_.semantics_enabled);
            return window != null;
        }

        public bool SetAccessibilityFeatures(int flags)
        {
            window_data_.accessibility_feature_flags_ = flags;
            var window = GetWindowIfAvailable();
            window?.UpdateAccessibilityFeatures(window_data_.accessibility_feature_flags_);
            return window != null;
        }

        public bool BeginFrame(fml::TimePoint frame_time)
        {
            var window = GetWindowIfAvailable();
            window?.BeginFrame(frame_time);
            return window != null;
        }

        public bool NotifyIdle(long deadline)
        {
            DartIsolate root_isolate = root_isolate_.lock();
            if (root_isolate == null)
                return false;

            tonic::DartState::Scope scope = new Scope(root_isolate);
            Dart_NotifyIdle(deadline);
            return true;
        }

        public bool IsRootIsolateRunning()
        {
            DartIsolate root_isolate = root_isolate_.lock();
            if (root_isolate != null)
            {
                return root_isolate.GetPhase() ==  ::Phase::Running;
            }
            return false;
        }

        public bool DispatchPlatformMessage(PlatformMessage message)
        {
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                TRACE_EVENT1("flutter", "RuntimeController::DispatchPlatformMessage", "mode", "basic");
                window.DispatchPlatformMessage(message);
            }
            return window != null;
        }

        public bool DispatchPointerDataPacket(PointerDataPacket packet)
        {
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                TRACE_EVENT1("flutter", "RuntimeController::DispatchPointerDataPacket", "mode", "basic");
                window.DispatchPointerDataPacket(packet);
            }
            return window != null;
        }

        public bool DispatchSemanticsAction(
            int id,
            SemanticsAction action,
            List<byte> args);

        public Dart_Port GetMainPort()
        {
            DartIsolate root_isolate = root_isolate_.lock();
            return root_isolate?.main_port() ?? ILLEGAL_PORT;
        }

        public string GetIsolateName()
        {
            DartIsolate root_isolate = root_isolate_.lock();
            return root_isolate?.debug_name() ?? "";
        }

        public bool HasLivePorts()
        {
            DartIsolate root_isolate = root_isolate_.lock();
            if (root_isolate == null)
                return false;

            tonic::DartState::Scope scope = new Scope(root_isolate);
            return Dart_HasLivePorts();
        }

        public DartErrorHandleType GetLastError()
        {
            DartIsolate root_isolate = root_isolate_.lock();
            return root_isolate?.GetLastError() ?? tonic::kNoError;
        }

        public DartIsolate GetRootIsolate() { return root_isolate_; }

        public Tuple<bool, uint> GetRootIsolateReturnCode() { return root_isolate_return_code_; }

        private struct Locale
        {
            string language_code;
            string country_code;
            string script_code;
            string variant_code;
        };

        private struct WindowData
        {
            public ViewportMetrics viewport_metrics;
            public string language_code;
            public string country_code;
            public string script_code;
            public string variant_code;
            public List<string> locale_data;
            public string user_settings_data = "{}";
            public bool semantics_enabled = false;
            public bool assistive_technology_enabled = false;
            public int accessibility_feature_flags_ = 0;
        };

        WindowData window_data_;
        RuntimeDelegate client_;

        //DartVM* const vm_;
        //DartSnapshot isolate_snapshot_;
        //DartSnapshot shared_snapshot_;
        //TaskRunners task_runners_;
        //SnapshotDelegate snapshot_delegate_;
        //GrContext resource_context_;
        //SkiaUnrefQueue unref_queue_;
        //string advisory_script_uri_;
        //string advisory_script_entrypoint_;
        //DartIsolate root_isolate_;
        Tuple<bool, uint> root_isolate_return_code_ = new Tuple<bool, uint>(false, 0 );

        private UI.Window GetWindowIfAvailable()
        {
            DartIsolate root_isolate = root_isolate_.lock();
            return root_isolate?.window();
        }

        private bool FlushRuntimeStateToIsolate()
        {
            return SetViewportMetrics(window_data_.viewport_metrics) &&
                SetLocales(window_data_.locale_data) &&
                SetSemanticsEnabled(window_data_.semantics_enabled) &&
                SetAccessibilityFeatures(window_data_.accessibility_feature_flags_);
        }

        // |blink::WindowClient|
        public string DefaultRouteName() => client_.DefaultRouteName();

        // |blink::WindowClient|
        public void ScheduleFrame() { client_.ScheduleFrame(); }

        // |blink::WindowClient|
        public void Render(Scene scene) { client_.Render(scene.TakeLayerTree()); }

        // |blink::WindowClient|
        public void UpdateSemantics(SemanticsUpdate update)
        {
            if (window_data_.semantics_enabled)
                client_.UpdateSemantics(update.takeNodes(), update.takeActions());
        }

        // |blink::WindowClient|
        public void HandlePlatformMessage(PlatformMessage message)
        {
            client_.HandlePlatformMessage(message);
        }

        // |blink::WindowClient|
        public void SetIsolateDebugName(string name)
        {
            DartIsolate root_isolate = root_isolate_.lock();
            if (root_isolate == null)
                return;
            
            root_isolate.set_debug_name(name);
        }

        // |blink::WindowClient|
        public FontCollection GetFontCollection() => client_.GetFontCollection(); 
    }
}
