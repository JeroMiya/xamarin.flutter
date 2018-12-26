using System;
using System.Collections.Generic;
using FlutterBinding.Engine;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    //
    //  NOTE:
    //  This whole class feels like a simple intermediary between Dart/Flutter Window <=> Native Window <=> Shell
    //


    // TODO: Should ignore all this locale stuff
    public class WindowData
    {
        public ViewportMetrics ViewportMetrics;
        public string LanguageCode;
        public string CountryCode;
        public string ScriptCode;
        public string VariantCode;
        public List<string> LocaleData;
        public string UserSettingsData = "{}";
        public bool SemanticsEnabled = false;
        public bool AssistiveTechnologyEnabled = false;
        public AccessibilityFeatures AccessibilityFeatureFlags;
    };

    public class RuntimeController : IWindowClient
    {
        public RuntimeController(
            IRuntimeDelegate client,
            //DartVM vm,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            TaskRunners taskRunners,
            SnapshotDelegate snapshotDelegate,
            GRContext resourceContext,
            SkiaUnrefQueue unrefQueue
            //string advisory_script_uri,
            //string advisory_script_entrypoint
        ) : this(
            client,
            taskRunners,
            snapshotDelegate,
            resourceContext,
            unrefQueue,
            new WindowData()) { }

        private RuntimeController(
            IRuntimeDelegate client,
            //DartVM vm,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            TaskRunners taskRunners,
            SnapshotDelegate snapshotDelegate,
            GRContext resourceContext,
            SkiaUnrefQueue unrefQueue,
            //string advisory_script_uri,
            //string advisory_script_entrypoint,
            WindowData data)
        {
            _client = client;
            //vm_ = vm;
            //isolate_snapshot_ = isolate_snapshot;
            //shared_snapshot_ = shared_snapshot;
            _taskRunners      = taskRunners;
            _snapshotDelegate = snapshotDelegate;
            _resourceContext  = resourceContext;
            _unrefQueue       = unrefQueue;
            //advisory_script_uri_ = advisory_script_uri;
            //advisory_script_entrypoint_ = advisory_script_entrypoint;
            _windowData = data;
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
            if (window != null)
            {
                //tonic::DartState::Scope scope(root_isolate);
                //window.DidCreateIsolate();
                if (!FlushRuntimeStateToIsolate())
                {
                    //FML_DLOG(ERROR) << "Could not setup intial isolate state.";
                }
            }
            else
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
                _client, //
                //vm_,                         //
                //isolate_snapshot_,           //
                //shared_snapshot_,            //
                _taskRunners,      //
                _snapshotDelegate, //
                _resourceContext,  //
                _unrefQueue,       //
                //advisory_script_uri_,        //
                //advisory_script_entrypoint_, //
                _windowData //
            );
        }

        public bool SetViewportMetrics(ViewportMetrics metrics)
        {
            _windowData.ViewportMetrics = metrics;

            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateWindowMetrics(metrics);
                return true;
            }

            return false;
        }

        public bool SetLocales(List<string> localeData)
        {
            _windowData.LocaleData = localeData;

            var window = GetWindowIfAvailable();
            window?.UpdateLocales(localeData);
            return window != null;
        }

        public bool SetUserSettingsData(string data)
        {
            _windowData.UserSettingsData = data;

            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateUserSettingsData(_windowData.UserSettingsData);
                return true;
            }

            return false;
        }

        public bool SetSemanticsEnabled(bool enabled)
        {
            _windowData.SemanticsEnabled = enabled;

            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateSemanticsEnabled(_windowData.SemanticsEnabled);
                return true;
            }

            return false;
        }

        public bool SetAccessibilityFeatures(AccessibilityFeatures flags)
        {
            _windowData.AccessibilityFeatureFlags = flags;
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.UpdateAccessibilityFeatures(_windowData.AccessibilityFeatureFlags);
                return true;
            }

            return false;
        }

        public bool BeginFrame(TimePoint frameTime)
        {
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                window.BeginFrame(frameTime);
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

        public bool DispatchPlatformMessage(PlatformMessage message)
        {
            var window = GetWindowIfAvailable();
            if (window != null)
            {
                //TRACE_EVENT1("flutter", "RuntimeController::DispatchPlatformMessage", "mode", "basic");
                window.DispatchPlatformMessage(message);
                return true;
            }

            return false;
        }

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

        public bool DispatchSemanticsAction(Int32 id, SemanticsAction action, object args)
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
                string languageCode,
                string countryCode,
                string scriptCode,
                string variantCode)
            {
                LanguageCode = languageCode;
                CountryCode  = countryCode;
                ScriptCode   = scriptCode;
                VariantCode  = variantCode;
            }

            public string LanguageCode;
            public string CountryCode;
            public string ScriptCode;
            public string VariantCode;
        };

        private IRuntimeDelegate _client;

        //DartVM const vm_;
        //DartSnapshot isolate_snapshot_;
        //DartSnapshot shared_snapshot_;
        private TaskRunners _taskRunners;
        private SnapshotDelegate _snapshotDelegate;
        private GRContext _resourceContext;

        SkiaUnrefQueue _unrefQueue;

        //string advisory_script_uri_;
        //string advisory_script_entrypoint_;
        private WindowData _windowData;

        //DartIsolate root_isolate_;
        private Tuple<bool, uint> _rootIsolateReturnCode = new Tuple<bool, uint>(false, 0);

        private Window GetWindowIfAvailable()
        {
            //DartIsolate root_isolate = root_isolate_.lock () ;
            //return root_isolate ? root_isolate->window() : null;
            return null;
        }

        private bool FlushRuntimeStateToIsolate()
        {
            return SetViewportMetrics(_windowData.ViewportMetrics) &&
                SetLocales(_windowData.LocaleData) &&
                SetSemanticsEnabled(_windowData.SemanticsEnabled) &&
                SetAccessibilityFeatures(_windowData.AccessibilityFeatureFlags);
        }

        // |blink::WindowClient|
        public string DefaultRouteName()
        {
            return _client.DefaultRouteName();
        }

        // |blink::WindowClient|
        public void ScheduleFrame()
        {
            _client.ScheduleFrame();
        }

        // |blink::WindowClient|
        public void Render(Scene scene)
        {
            _client.Render(scene.TakeLayerTree());
        }

        // |blink::WindowClient|
        public void UpdateSemantics(SemanticsUpdate update)
        {
            if (_windowData.SemanticsEnabled)
                _client.UpdateSemantics(update.takeNodes(), update.takeActions());
        }

        // |blink::WindowClient|
        public void HandlePlatformMessage(PlatformMessage message)
        {
            _client.HandlePlatformMessage(message);
        }

        // |blink::WindowClient|
        public void SetIsolateDebugName(string name)
        {
            //DartIsolate root_isolate = root_isolate_.lock();
            //if (root_isolate == null) 
            //    return;
            //root_isolate.set_debug_name(name);
        }

        // TODO: How are we going to do Fonts
        // |blink::WindowClient|
        //public FontCollection GetFontCollection()
        //{
        //    return client_.GetFontCollection();
        //}

        //FML_DISALLOW_COPY_AND_ASSIGN(RuntimeController);
    }
}
