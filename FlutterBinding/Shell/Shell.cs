using System;
using System.Threading;
using System.Threading.Tasks;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Synchronization;
using FlutterBinding.Flow;
using FlutterBinding.Flow.Layers;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    //using CreateCallback = std::function<std::unique_ptr<T>(Shell&)>;
    public delegate T CreateCallback<out T>(Shell shell);

    //using ServiceProtocolHandler = std::function<bool(const blink::ServiceProtocol::Handler::ServiceProtocolMap&,rapidjson::Document&)>;
    //public delegate bool ServiceProtocolHandler(ServiceProtocol.Handler.ServiceProtocolMap, JObject document);

    public sealed class Shell : PlatformView.Delegate,
                    Animator.IAnimatorDelegate,
                    Engine.IEngineDelegate
                    //public blink::ServiceProtocol::Handler 
    {
        // Create a shell with the given task runners and settings. The isolate
        // snapshot will be shared with the snapshot of the service isolate.
        public static async Task<Shell> Create(
            TaskRunners taskRunners,
            Settings settings,
            CreateCallback<PlatformView> onCreatePlatformView,
            CreateCallback<Rasterizer> onCreateRasterizer)
        {
            PerformInitializationTasks(settings);

            if (!taskRunners.IsValid() || 
                onCreatePlatformView == null ||
                onCreateRasterizer == null)
            {
                return null;
            }

            Shell shell = null;
            await TaskRunner.RunNowOrPostTask(
                taskRunners.PlatformTaskRunner,
                async () => 
                {
                    shell = await CreateShellOnPlatformThread(
                        taskRunners, 
                        settings,
                        //std::move(isolate_snapshot),
                        //std::move(shared_snapshot),
                        onCreatePlatformView,
                        onCreateRasterizer
                    );
                });

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


        public Settings Settings => _settings;
        public TaskRunners TaskRunners => _taskRunners;
        public Rasterizer Rasterizer => _rasterizer;
        public Engine Engine => _engine;
        public PlatformView PlatformView => _platformView;
        //public DartVM DartVM => vm_;
        public bool IsSetup => _isSetup;

        public async Task<Rasterizer.Screenshot> Screenshot(Rasterizer.ScreenshotType type, bool base64Encode)
        {
            //TRACE_EVENT0("flutter", "Shell::Screenshot");
            
            Rasterizer.Screenshot screenshot = null;
            await _taskRunners.GPUTaskRunner.RunNowOrPostTask( () =>
            {
                screenshot = _rasterizer?.ScreenshotLastLayerTree(type, base64Encode);
            });
            return screenshot;
        }

        private TaskRunners _taskRunners;
        private Settings _settings;
        //private DartVM vm_;
        private PlatformView _platformView;   // on platform task runner
        private Engine _engine;               // on UI task runner
        private Rasterizer _rasterizer;       // on GPU task runner
        private IOManager _ioManager;         // on IO task runner

        //private Dictionary<string,  Tuple<TaskRunner, ServiceProtocolHandler> service_protocol_handlers_;
        private bool _isSetup = false;

        private Shell(TaskRunners taskRunners, Settings settings)
        {
            _taskRunners = taskRunners;
            _settings = settings;
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
            TaskRunners taskRunners,
            Settings settings,
            //DartSnapshot isolate_snapshot,
            //DartSnapshot shared_snapshot,
            CreateCallback<PlatformView> onCreatePlatformView,
            CreateCallback<Rasterizer> onCreateRasterizer)
        {
            if (!taskRunners.IsValid())
                return null;

            var shell = new Shell(taskRunners, settings);

            // Create the platform view on the platform thread (this thread).
            var platformView = onCreatePlatformView(shell) ?? throw new FlutterException("PlatformView not created");

            // Ask the platform view for the vsync waiter. This will be used by the engine
            // to create the animator.
            var vsyncWaiter = platformView.CreateVSyncWaiter() ?? throw new FlutterException("VSyncWaiter not created");

            // Create the IO manager on the IO thread. The IO manager must be initialized
            // first because it has state that the other subsystems depend on. It must
            // first be booted and the necessary references obtained to initialize the
            // other subsystems.
            IOManager ioManager = null;
            GRContext resourceContext = null;
            SkiaUnrefQueue unrefQueue = null;
            await shell.TaskRunners.IOTaskRunner.RunNowOrPostTask(
                () => 
                {
                    ioManager = new IOManager(platformView.CreateResourceContext(), shell.TaskRunners.IOTaskRunner);
                    resourceContext = ioManager.GetResourceContext();
                    unrefQueue = ioManager.GetSkiaUnrefQueue();
                });

            // Create the rasterizer on the GPU thread.
            Rasterizer rasterizer = null;
            SnapshotDelegate snapshotDelegate = null;
            await taskRunners.GPUTaskRunner.RunNowOrPostTask(
                () =>
                {
                    var newRasterizer = onCreateRasterizer(shell);
                    if (newRasterizer != null)
                    {
                        rasterizer = newRasterizer;
                        snapshotDelegate = rasterizer.GetSnapshotDelegate();
                    }
                });

            // Create the engine on the UI thread.
            Engine engine = null;
            await shell.TaskRunners.UITaskRunner.RunNowOrPostTask(
                () => 
                {
                    // The animator is owned by the UI thread but it gets its vsync pulses
                    // from the platform.
                    var animator = new Animator(shell, taskRunners, vsyncWaiter);

                    engine = new Engine(shell,               
                                        //shell.GetDartVM(), 
                                        //isolate_snapshot,  
                                        //shared_snapshot,   
                                        taskRunners,         
                                        shell.Settings,      
                                        animator,          
                                        snapshotDelegate,  
                                        resourceContext,   
                                        unrefQueue         
                    );
                });

            // We are already on the platform thread. So there is no platform latch to
            // wait on.

            if (!shell.Setup(platformView,  
                             engine,         
                             rasterizer,     
                             ioManager))
            {
                return null;
            }

            return shell;
        }

        private bool Setup(
            PlatformView platformView,
            Engine engine,
            Rasterizer rasterizer,
            IOManager ioManager)
        {
            if (_isSetup)
                return false;

            if (platformView == null || 
                engine == null || 
                rasterizer == null || 
                ioManager == null)
                return false;

            _platformView = platformView;
            _engine       = engine;
            _rasterizer   = rasterizer;
            _ioManager    = ioManager;

            _isSetup = true;

            //var vm = DartVM.ForProcessIfInitialized();
            //if (vm != null)
            //    vm.GetServiceProtocol().AddHandler(this);

            // TODO: Not supported by SkiaSharp
            //PersistentCache.GetCacheForProcess().AddWorkerTaskRunner(task_runners_.IOTaskRunner);

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
            await _taskRunners.UITaskRunner.RunNowOrPostTask(
                () => { _engine?.OnOutputSurfaceCreated(); });

            // Step 1: Next, tell the GPU thread that it should create a surface for its rasterizer.
            await _taskRunners.GPUTaskRunner.RunNowOrPostTask(
                () => { _rasterizer?.Setup(surface); });
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
            await _taskRunners.UITaskRunner.RunNowOrPostTask(
                () => _engine?.OnOutputSurfaceDestroyed());

            // Step 1: Next, tell the GPU thread that its rasterizer should suspend
            // access to the underlying surface.
            await _taskRunners.GPUTaskRunner.RunNowOrPostTask(
                () => { _rasterizer?.Teardown(); });

            // Step 2: Next, tell the IO thread to complete its remaining work.
            // Execute any pending Skia object deletions while GPU access is still allowed.
            await _taskRunners.IOTaskRunner.RunNowOrPostTask(
                () => { _ioManager.GetSkiaUnrefQueue().Drain(); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewSetViewportMetrics(ViewportMetrics metrics)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.UITaskRunner.PostTask(
                () => { _engine?.SetViewportMetrics(metrics); });
        }

        // |shell::PlatformView::Delegate|
        //public void OnPlatformViewDispatchPlatformMessage(PlatformMessage message) { }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewDispatchPointerDataPacket(PointerDataPacket packet)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.UITaskRunner.PostTask(
                () => { _engine?.DispatchPointerDataPacket(packet); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewDispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.UITaskRunner.PostTask(
                () => { _engine?.DispatchSemanticsAction(id, action, args); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewSetSemanticsEnabled(bool enabled)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.UITaskRunner.PostTask(
                () => { _engine?.SetSemanticsEnabled(enabled); });
        }

        // |shell:PlatformView::Delegate|
        public void OnPlatformViewSetAccessibilityFeatures(AccessibilityFeatures flags)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.UITaskRunner.PostTask(
                () => { _engine?.SetAccessibilityFeatures(flags); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewRegisterTexture(Texture texture)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.GPUTaskRunner.PostTask(
                () => { _rasterizer?.GetTextureRegistry()?.RegisterTexture(texture); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewUnregisterTexture(long textureId)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.GPUTaskRunner.PostTask(
                () => { _rasterizer?.GetTextureRegistry()?.UnregisterTexture(textureId); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewMarkTextureFrameAvailable(long textureId)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            // Tell the rasterizer that one of its textures has a new frame available.
            _taskRunners.GPUTaskRunner.PostTask(
                    () =>
                    {
                        _rasterizer
                            ?.GetTextureRegistry()
                            ?.GetTexture(textureId)
                            ?.MarkNewFrameAvailable();
                    });

            // Schedule a new frame without having to rebuild the layer tree.
            _taskRunners.UITaskRunner.PostTask(
                () => { _engine.ScheduleFrame(false); });
        }

        // |shell::PlatformView::Delegate|
        public void OnPlatformViewSetNextFrameCallback( Action action )
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetPlatformTaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.GPUTaskRunner.PostTask(
                () => { _rasterizer.SetNextFrameCallback(action); });
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorBeginFrame(TimePoint frameTime)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            _engine?.BeginFrame(frameTime);
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorNotifyIdle(long deadline)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            _engine?.NotifyIdle(deadline);
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorDraw(Pipeline<LayerTree> pipeline)
        {
            //FML_DCHECK(is_setup_);

            _taskRunners.GPUTaskRunner.PostTask(
                () => { _rasterizer?.Draw(pipeline); });
        }

        // |shell::Animator::Delegate|
        public void OnAnimatorDrawLastLayerTree()
        {
            //FML_DCHECK(is_setup_);

            _taskRunners.GPUTaskRunner.PostTask(
                () => { _rasterizer?.DrawLastLayerTree(); });
        }

        // |shell::Engine::Delegate|
        public void OnEngineUpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions)
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            _taskRunners.PlatformTaskRunner.PostTask(
                () => { _platformView?.UpdateSemantics(update, actions); });
        }

        // |shell::Engine::Delegate|
        //public void OnEngineHandlePlatformMessage(PlatformMessage message) { }

        // |shell::Engine::Delegate|
        public async Task OnPreEngineRestart()
        {
            //FML_DCHECK(is_setup_);
            //FML_DCHECK(task_runners_.GetUITaskRunner()->RunsTasksOnCurrentThread());

            await _taskRunners.PlatformTaskRunner.RunNowOrPostTask(
                () => { _platformView?.OnPreEngineRestart(); });

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

        private static int _shellSettingsInitialization = 0;

        // Though there can be multiple shells, some settings apply to all components in
        // the process. These have to be setup before the shell or any of its
        // sub-components can be initialized. In a perfect world, this would be empty.
        // TODO(chinmaygarde): The unfortunate side effect of this call is that settings
        // that cause shell initialization failures will still lead to some of their
        // settings being applied.
        static void PerformInitializationTasks(Settings settings)
        {
            var prev = Interlocked.Increment(ref _shellSettingsInitialization);
            if (prev != 0)
                return;

            RecordStartupTimestamp();
        }
    }
}
