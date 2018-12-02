using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Synchronization;
using FlutterBinding.Engine.Window;
using FlutterBinding.Flow;
using FlutterBinding.Flow.Layers;
using FlutterBinding.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    //using CreateCallback = std::function<std::unique_ptr<T>(Shell&)>;
    public delegate T CreateCallback<out T>(Shell shell);

    //using ServiceProtocolHandler = std::function<bool(const blink::ServiceProtocol::Handler::ServiceProtocolMap&,rapidjson::Document&)>;
    //public delegate bool ServiceProtocolHandler(ServiceProtocol.Handler.ServiceProtocolMap, JObject document);

    public sealed class Shell : PlatformView.Delegate,
                    Animator.Delegate,
                    Engine.Delegate
                    //public blink::ServiceProtocol::Handler 
    {
        // Create a shell with the given task runners and settings. The isolate
        // snapshot will be shared with the snapshot of the service isolate.
        public static async Task<Shell> Create(
            TaskRunners task_runners,
            Settings settings,
            CreateCallback<PlatformView> on_create_platform_view,
            CreateCallback<Rasterizer> on_create_rasterizer)
        {
            PerformInitializationTasks(settings);

            if (!task_runners.IsValid() || 
                on_create_platform_view == null ||
                on_create_rasterizer == null)
            {
                return null;
            }

            //fml::AutoResetWaitableEvent latch;
            var tcs = new TaskCompletionSource<bool>();
            Shell shell = null;
            TaskRunner.RunNowOrPostTask(
                task_runners.PlatformTaskRunner,
                async () => 
                {
                    shell = await CreateShellOnPlatformThread(
                        task_runners, 
                        settings,
                        //std::move(isolate_snapshot),
                        //std::move(shared_snapshot),
                        on_create_platform_view,
                        on_create_rasterizer
                    );
                    tcs.SetResult(true);
                });
            await tcs.Task;

            return shell;
        }

        // Creates a shell with the given task runners and settings. The isolate
        //// snapshot is specified upfront.
        //static Shell Create(
        //    TaskRunners task_runners,
        //    Settings settings,
        //    DartSnapshot isolate_snapshot,
        //    DartSnapshot shared_snapshot,
        //    CreateCallback<PlatformView> on_create_platform_view,
        //    CreateCallback<Rasterizer> on_create_rasterizer) { }


        public Settings Settings => settings_;
        public TaskRunners TaskRunners => task_runners_;
        public Rasterizer Rasterizer => rasterizer_;
        public Engine Engine => engine_;
        public PlatformView PlatformView => platform_view_;
        //public DartVM DartVM => vm_;
        public bool IsSetup => is_setup_;

        public async Task<Rasterizer.Screenshot> Screenshot(Rasterizer.ScreenshotType type, bool base64_encode)
        {
            //TRACE_EVENT0("flutter", "Shell::Screenshot");
            
            Rasterizer.Screenshot screenshot = null;
            await task_runners_.GPUTaskRunner.RunNowOrPostTask( () =>
            {
                screenshot = rasterizer_?.ScreenshotLastLayerTree(type, base64_encode);
            });
            return screenshot;
        }

        private TaskRunners task_runners_;
        private Settings settings_;
        //private DartVM vm_;
        private PlatformView platform_view_;  // on platform task runner
        private Engine engine_;               // on UI task runner
        private Rasterizer rasterizer_;       // on GPU task runner
        private IOManager io_manager_;        // on IO task runner

        //private Dictionary<string,  Tuple<TaskRunner, ServiceProtocolHandler> service_protocol_handlers_;
        private bool is_setup_ = false;

        private Shell(TaskRunners task_runners, Settings settings)
        {
            task_runners_ = task_runners;
            settings_ = settings;
            //vm_ = DartVM.ForProcess(settings_);

            //FML_DCHECK(task_runners_.IsValid());
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            // Install service protocol handlers.
            /*
            service_protocol_handlers_[ServiceProtocol::kScreenshotExtensionName.ToString()] = {
                task_runners_.GPUTaskRunner,
                bind(Shell.OnServiceProtocolScreenshot, this, placeholders._1, placeholders._2)};
            service_protocol_handlers_[ServiceProtocol::kScreenshotSkpExtensionName.ToString()] = {
                task_runners_.GPUTaskRunner,
                bind(Shell.OnServiceProtocolScreenshotSKP, this, placeholders::_1, placeholders::_2)};
            service_protocol_handlers_[ServiceProtocol::kRunInViewExtensionName.ToString()] = {
                task_runners_.UITaskRunner,
                bind(Shell.OnServiceProtocolRunInView, this, placeholders::_1, placeholders::_2)};
            service_protocol_handlers_[ServiceProtocol::kFlushUIThreadTasksExtensionName.ToString()] =  {
                task_runners_.UITaskRunner,
                bind(Shell.OnServiceProtocolFlushUIThreadTasks, this, placeholders::_1, placeholders::_2)};
            service_protocol_handlers_[ServiceProtocol::kSetAssetBundlePathExtensionName.ToString()] =  {
                task_runners_.UITaskRunner,
                bind(Shell.OnServiceProtocolSetAssetBundlePath, this, placeholders::_1, placeholders::_2)};
                */
        }

        private static async Task<Shell> CreateShellOnPlatformThread(
            TaskRunners task_runners,
            Settings settings,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            CreateCallback<PlatformView> on_create_platform_view,
            CreateCallback<Rasterizer> on_create_rasterizer)
        {
            if (!task_runners.IsValid())
                return null;

            var shell = new Shell(task_runners, settings);

            // Create the platform view on the platform thread (this thread).
            var platform_view = on_create_platform_view(shell) ?? throw new FlutterException("PlatformView not created");

            // Ask the platform view for the vsync waiter. This will be used by the engine
            // to create the animator.
            var vsync_waiter = platform_view.CreateVSyncWaiter() ?? throw new FlutterException("VSyncWaiter not created");

            // Create the IO manager on the IO thread. The IO manager must be initialized
            // first because it has state that the other subsystems depend on. It must
            // first be booted and the necessary references obtained to initialize the
            // other subsystems.
            IOManager io_manager = null;
            GRContext resource_context = null;
            SkiaUnrefQueue unref_queue = null;
            await shell.TaskRunners.IOTaskRunner.RunNowOrPostTask(
                () => 
                {
                    io_manager = new IOManager(platform_view.CreateResourceContext(), shell.TaskRunners.IOTaskRunner);
                    resource_context = io_manager.GetResourceContext();
                    unref_queue = io_manager.GetSkiaUnrefQueue();
                });

            // Create the rasterizer on the GPU thread.
            Rasterizer rasterizer = null;
            SnapshotDelegate snapshot_delegate = null;
            await task_runners.GPUTaskRunner.RunNowOrPostTask(
                () =>
                {
                    var new_rasterizer = on_create_rasterizer(shell);
                    if (new_rasterizer != null)
                    {
                        rasterizer = new_rasterizer;
                        snapshot_delegate = rasterizer.GetSnapshotDelegate();
                    }
                });

            // Create the engine on the UI thread.
            Engine engine = null;
            await shell.TaskRunners.UITaskRunner.RunNowOrPostTask(
                () => 
                {
                    // The animator is owned by the UI thread but it gets its vsync pulses
                    // from the platform.
                    var animator = new Animator(shell, task_runners, vsync_waiter);

                    engine = new Engine(shell,                        //
                                        //shell.GetDartVM(),            //
                                        //isolate_snapshot,   //
                                        //shared_snapshot,    //
                                        task_runners,                  //
                                        shell.Settings,          //
                                        animator,           //
                                        snapshot_delegate,  //
                                        resource_context,   //
                                        unref_queue         //
                    );
                });

            // We are already on the platform thread. So there is no platform latch to
            // wait on.

            if (!shell.Setup(platform_view,  
                             engine,         
                             rasterizer,     
                             io_manager))
            {
                return null;
            }

            return shell;
        }

        private bool Setup(
            PlatformView platform_view,
            Engine engine,
            Rasterizer rasterizer,
            IOManager io_manager)
        {
            if (is_setup_)
                return false;

            if (platform_view == null || 
                engine == null || 
                rasterizer == null || 
                io_manager == null)
                return false;

            platform_view_ = platform_view;
            engine_        = engine;
            rasterizer_    = rasterizer;
            io_manager_    = io_manager;

            is_setup_ = true;

            //var vm = DartVM.ForProcessIfInitialized();
            //if (vm != null)
            //    vm.GetServiceProtocol().AddHandler(this);

            PersistentCache.GetCacheForProcess()
                           .AddWorkerTaskRunner(task_runners_.IOTaskRunner);

            return true;
        }

        // |shell::PlatformView::Delegate|
        public async Task OnPlatformViewCreated(Surface surface)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            // Note:
            // This is a synchronous operation because certain platforms depend on
            // setup/suspension of all activities that may be interacting with the GPU in
            // a synchronous fashion.

            // Step 0: Post a task onto the UI thread to tell the engine that it has an output surface.
            await task_runners_.UITaskRunner.RunNowOrPostTask(
                () => { engine_?.OnOutputSurfaceCreated(); });

            // Step 1: Next, tell the GPU thread that it should create a surface for its rasterizer.
            await task_runners_.GPUTaskRunner.RunNowOrPostTask(
                () => { rasterizer_?.Setup(surface); });
        }

        // |shell::PlatformView::Delegate|
        public async Task OnPlatformViewDestroyed()
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            // Note:
            // This is a synchronous operation because certain platforms depend on
            // setup/suspension of all activities that may be interacting with the GPU in
            // a synchronous fashion.

            // Step 0: Post a task onto the UI thread to tell the engine that its output
            // surface is about to go away.
            await task_runners_.UITaskRunner.RunNowOrPostTask(
                () => engine_?.OnOutputSurfaceDestroyed());

            // Step 1: Next, tell the GPU thread that its rasterizer should suspend
            // access to the underlying surface.
            await task_runners_.GPUTaskRunner.RunNowOrPostTask(
                () => { rasterizer_?.Teardown(); });

            // Step 2: Next, tell the IO thread to complete its remaining work.
            // Execute any pending Skia object deletions while GPU access is still allowed.
            await task_runners_.IOTaskRunner.RunNowOrPostTask(
                () => { io_manager_.GetSkiaUnrefQueue().Drain(); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewSetViewportMetrics(ViewportMetrics metrics)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.UITaskRunner.PostTask(
                () => { engine_?.SetViewportMetrics(metrics); });
        }

        // |shell::PlatformView::Delegate|
        //public void OnPlatformViewDispatchPlatformMessage(PlatformMessage message) { }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewDispatchPointerDataPacket(PointerDataPacket packet)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.UITaskRunner.PostTask(
                () => { engine_?.DispatchPointerDataPacket(packet); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewDispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.UITaskRunner.PostTask(
                () => { engine_?.DispatchSemanticsAction(id, action, args); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewSetSemanticsEnabled(bool enabled)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.UITaskRunner.PostTask(
                () => { engine_?.SetSemanticsEnabled(enabled); });
        }

        // |shell:PlatformView::Delegate|
        public void OnPlatformViewSetAccessibilityFeatures(AccessibilityFeatures flags)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.UITaskRunner.PostTask(
                () => { engine_?.SetAccessibilityFeatures(flags); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewRegisterTexture(Texture texture)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.GPUTaskRunner.PostTask(
                () => { rasterizer_?.GetTextureRegistry()?.RegisterTexture(texture); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewUnregisterTexture(long texture_id)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.GPUTaskRunner.PostTask(
                () => { rasterizer_?.GetTextureRegistry()?.UnregisterTexture(texture_id); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewMarkTextureFrameAvailable(long texture_id)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            // Tell the rasterizer that one of its textures has a new frame available.
            task_runners_.GPUTaskRunner.PostTask(
                    () =>
                    {
                        rasterizer_
                            ?.GetTextureRegistry()
                            ?.GetTexture(texture_id)
                            ?.MarkNewFrameAvailable();
                    });

            // Schedule a new frame without having to rebuild the layer tree.
            task_runners_.UITaskRunner.PostTask(
                () => { engine_.ScheduleFrame(false); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewSetNextFrameCallback( Action action )
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.GPUTaskRunner.PostTask(
                () => { rasterizer_.SetNextFrameCallback(action); });
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorBeginFrame(TimePoint frame_time)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            engine_?.BeginFrame(frame_time);
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorNotifyIdle(long deadline)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            engine_?.NotifyIdle(deadline);
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorDraw(Pipeline<LayerTree> pipeline)
        {
            //FML_DCHECK(is_setup_);

            task_runners_.GPUTaskRunner.PostTask(
                () => { rasterizer_?.Draw(pipeline); });
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorDrawLastLayerTree()
        {
            //FML_DCHECK(is_setup_);

            task_runners_.GPUTaskRunner.PostTask(
                () => { rasterizer_?.DrawLastLayerTree(); });
        }

        // |shell::Engine::Delegate|
        public void OnEngineUpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            task_runners_.PlatformTaskRunner.PostTask(
                () => { platform_view_?.UpdateSemantics(update, actions); });
        }

        // |shell::Engine::Delegate|
        //public void OnEngineHandlePlatformMessage(PlatformMessage message) { }

        // |shell::Engine::Delegate|
        public async Task OnPreEngineRestart()
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            await task_runners_.PlatformTaskRunner.RunNowOrPostTask(
                () => { platform_view_?.OnPreEngineRestart(); });

            // This is blocking as any embedded platform views has to be flushed before
            // we re-run the Dart code.
        }

        // |blink::ServiceProtocol::Handler|
        //public TaskRunner GetServiceProtocolHandlerTaskRunner(StringView method) { }

        // |blink::ServiceProtocol::Handler|
        //public bool HandleServiceProtocolMessage(StringView method, ServiceProtocolMap @params, JObject response) { }

        // |blink::ServiceProtocol::Handler|
        //public ServiceProtocol.Handler.Description GetServiceProtocolDescription() { }

        // Service protocol handler
        //public bool OnServiceProtocolScreenshot( ServiceProtocol.Handler.ServiceProtocolMap @params, JObject response) { }

        // Service protocol handler
        //public bool OnServiceProtocolScreenshotSKP(ServiceProtocol.Handler.ServiceProtocolMap @params, JObject response) { }

        // Service protocol handler
        //public bool OnServiceProtocolRunInView(ServiceProtocol.Handler.ServiceProtocolMap @params, JObject response) { }

        // Service protocol handler
        //public bool OnServiceProtocolFlushUIThreadTasks(ServiceProtocol.Handler.ServiceProtocolMap @params, JObject response) { }

        // Service protocol handler
        //bool OnServiceProtocolSetAssetBundlePath( ServiceProtocol.Handler.ServiceProtocolMap @params, JObject response) { }

        //FML_DISALLOW_COPY_AND_ASSIGN(Shell);

        private static long _engineMainEnterTs = 0;
        private static void RecordStartupTimestamp()
        {
            if (_engineMainEnterTs == 0)
                _engineMainEnterTs = TimePoint.Now().Microseconds;
        }

        private static int gShellSettingsInitialization = 0;

        // Though there can be multiple shells, some settings apply to all components in
        // the process. These have to be setup before the shell or any of its
        // sub-components can be initialized. In a perfect world, this would be empty.
        // TODO(chinmaygarde): The unfortunate side effect of this call is that settings
        // that cause shell initialization failures will still lead to some of their
        // settings being applied.
        static void PerformInitializationTasks(Settings settings)
        {
            var prev = Interlocked.Increment(ref gShellSettingsInitialization);
            if (prev != 0)
                return;

            RecordStartupTimestamp();
        }
    }
}
