using System;
using System.Collections.Generic;
using System.Text;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Window;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    //
    //  NOTE:
    //  This whole class feels like a simple intermediary between Dart/Flutter Window <=> Native Window <=> Shell
    //



    public interface  WindowClient
    {
        string DefaultRouteName();
        void ScheduleFrame();
        void Render(Scene scene);
        void UpdateSemantics(SemanticsUpdate update);
        //void HandlePlatformMessage(PlatformMessage message);
        //void SetIsolateDebugName(string isolateName);
        //FontCollection GetFontCollection();
    };

    // TODO: Should ignore all this locale stuff
    public class WindowData
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
        public Int32 accessibility_feature_flags_ = 0;
    };

    public class RuntimeController : WindowClient
    {
        public RuntimeController(
            RuntimeDelegate client,
            //DartVM vm,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            TaskRunners task_runners,
            SnapshotDelegate snapshot_delegate,
            GRContext resource_context
            //SkiaUnrefQueue unref_queue,
            //string advisory_script_uri,
            //string advisory_script_entrypoint
            ) : this(
            client, 
            task_runners, 
            snapshot_delegate, 
            resource_context, 
            new WindowData())
        { }

        private RuntimeController(
            RuntimeDelegate client,
            //DartVM vm,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            TaskRunners task_runners,
            SnapshotDelegate snapshot_delegate,
            GRContext resource_context,
            //SkiaUnrefQueue unref_queue,
            //string advisory_script_uri,
            //string advisory_script_entrypoint,
            WindowData data)
        {
            client_ = client;
            //vm_ = vm;
            //isolate_snapshot_ = isolate_snapshot;
            //shared_snapshot_ = shared_snapshot;
            task_runners_ = task_runners;
            snapshot_delegate_ = snapshot_delegate;
            resource_context_ = resource_context;
            //unref_queue_ = unref_queue;
            //advisory_script_uri_ = advisory_script_uri;
            //advisory_script_entrypoint_ = advisory_script_entrypoint;
            window_data_ = data;
            //root_isolate_ = DartIsolate::CreateRootIsolate(
            //    vm_,
            //    isolate_snapshot_,
            //    shared_snapshot_,
            //    task_runners_,
            //    this,
            //    snapshot_delegate_,
            //    resource_context_,
            //    unref_queue_,
            //    advisory_script_uri,
            //    advisory_script_entrypoint);

            //DartIsolate root_isolate = root_isolate_.lock () ;
            //root_isolate->SetReturnCodeCallback([this](uint32_t code) {
            //    root_isolate_return_code_ =  { true, code};
            //});
            var window = GetWindowIfAvailable();
            if (window != null ) 
            {
                //tonic::DartState::Scope scope(root_isolate);
                //window.DidCreateIsolate();
                if (!FlushRuntimeStateToIsolate())
                {
                    //FML_DLOG(ERROR) << "Could not setup intial isolate state.";
                }
            } else
            {
                //FML_DCHECK(false) << "RuntimeController created without window binding.";
            }
            //FML_DCHECK(Dart_CurrentIsolate() == nullptr);
        }

        ~RuntimeController()
        {
            //FML_DCHECK(Dart_CurrentIsolate() == nullptr);
            //DartIsolate root_isolate = root_isolate_.lock () ;
            //if (root_isolate)
            //{
            //    root_isolate.SetReturnCodeCallback(null);
            //    var result = root_isolate.Shutdown();
            //    if (!result)
            //    {
            //        FML_DLOG(ERROR) << "Could not shutdown the root isolate.";
            //    }
            //    root_isolate_ =  { };
            //}
        }


        public RuntimeController Clone()
        {
            return new RuntimeController(
                client_,                     //
                //vm_,                         //
                //isolate_snapshot_,           //
                //shared_snapshot_,            //
                task_runners_,               //
                snapshot_delegate_,          //
                resource_context_,           //
                //unref_queue_,                //
                //advisory_script_uri_,        //
                //advisory_script_entrypoint_, //
                window_data_                 //
            );
        }

        public bool SetViewportMetrics(ViewportMetrics metrics)
        {
            window_data_.viewport_metrics = metrics;

            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateWindowMetrics(metrics);
                return true;
            }
            return false;
        }

        public bool SetLocales(List<string> locale_data)
        {
            window_data_.locale_data = locale_data;

            var window = GetWindowIfAvailable();
            if (window != null)
            { 
                window.UpdateLocales(locale_data);
                return true;
            }
            return true;
        }

        public bool SetUserSettingsData(string data)
        {
            window_data_.user_settings_data = data;

            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateUserSettingsData(window_data_.user_settings_data);
                return true;
            }

            return false;
        }

        public bool SetSemanticsEnabled(bool enabled)
        {
            window_data_.semantics_enabled = enabled;

            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateSemanticsEnabled(window_data_.semantics_enabled);
                return true;
            }

            return false;
        }

        public bool SetAccessibilityFeatures(int flags)
        {
            window_data_.accessibility_feature_flags_ = flags;
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateAccessibilityFeatures(window_data_.accessibility_feature_flags_);
                return true;
            }

            return false;
        }

        public bool BeginFrame(TimePoint frame_time)
        {
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.BeginFrame(frame_time);
                return true;
            }
            return false;
        }

        public bool NotifyIdle(Int64 deadline)
        {
            //DartIsolate root_isolate = root_isolate_.lock () ;
            //if (root_isolate == null)
            //    return false;

            //tonic::DartState::Scope scope(root_isolate);
            //Dart_NotifyIdle(deadline);
            return true;
        }

        //public bool IsRootIsolateRunning() { }

        //public bool DispatchPlatformMessage(PlatformMessage message)
        //{
        //    var window = GetWindowIfAvailable();
        //    if (window != null)
        //    {
        //        //TRACE_EVENT1("flutter", "RuntimeController::DispatchPlatformMessage", "mode", "basic");
        //        window.DispatchPlatformMessage(std::move(message));
        //        return true;
        //    }
        //    return false;
        //}

        public bool DispatchPointerDataPacket(PointerDataPacket packet)
        {
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                //TRACE_EVENT1("flutter", "RuntimeController::DispatchPointerDataPacket", "mode", "basic");
                window.DispatchPointerDataPacket(packet);
                return true;
            }
            return false;
        }

        public bool DispatchSemanticsAction(Int32 id, SemanticsAction action, List<byte> args)
        {
            //TRACE_EVENT1("flutter", "RuntimeController::DispatchSemanticsAction", "mode", "basic");
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.DispatchSemanticsAction(id, action, args);
                return true;
            }
            return false;
        }

        //public Dart_Port GetMainPort() { }
        public string GetIsolateName()
        {
            //DartIsolate root_isolate = root_isolate_.lock () ;
            //return root_isolate ? root_isolate.debug_name() : "";
            return "";
        }
        //public bool HasLivePorts() { }
        //public DartErrorHandleType GetLastError() { }
        //public DartIsolate GetRootIsolate() { }
        //Tuple<bool, UInt32> GetRootIsolateReturnCode() { }

        private class Locale
        {
            Locale(
                string language_code_,
                string country_code_,
                string script_code_,
                string variant_code_)
            {
                language_code = language_code_;
                country_code = country_code_;
                script_code = script_code_;
                variant_code = variant_code_;
            }
            string language_code;
            string country_code;
            string script_code;
            string variant_code;
        };

        private RuntimeDelegate client_;
        //DartVM const vm_;
        //DartSnapshot isolate_snapshot_;
        //DartSnapshot shared_snapshot_;
        private TaskRunners task_runners_;
        private SnapshotDelegate snapshot_delegate_;
        private GRContext resource_context_;
        //SkiaUnrefQueue unref_queue_;
        //string advisory_script_uri_;
        //string advisory_script_entrypoint_;
        private WindowData window_data_;
        //DartIsolate root_isolate_;
        private Tuple<bool, UInt32> root_isolate_return_code_ = new Tuple<bool, uint>(false, 0);

        private Window GetWindowIfAvailable()
        {
            //DartIsolate root_isolate = root_isolate_.lock () ;
            //return root_isolate ? root_isolate->window() : null;
            return null;
        }

        private bool FlushRuntimeStateToIsolate()
        {
            return SetViewportMetrics(window_data_.viewport_metrics) &&
                SetLocales(window_data_.locale_data) &&
                SetSemanticsEnabled(window_data_.semantics_enabled) &&
                SetAccessibilityFeatures(window_data_.accessibility_feature_flags_);
        }

        // |blink::WindowClient|
        public string DefaultRouteName()
        {
            return client_.DefaultRouteName();
        }

        // |blink::WindowClient|
        public void ScheduleFrame()
        {
            client_.ScheduleFrame();
        }

        // |blink::WindowClient|
        public void Render(Scene scene)
        {
            client_.Render(scene.takeLayerTree());
        }

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
            //DartIsolate root_isolate = root_isolate_.lock();
            //if (root_isolate == null) 
            //    return;
            //root_isolate.set_debug_name(name);
        }

        // |blink::WindowClient|
        public FontCollection GetFontCollection()
        {
            return client_.GetFontCollection();
        }

        //FML_DISALLOW_COPY_AND_ASSIGN(RuntimeController);
    }
}
