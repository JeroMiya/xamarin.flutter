using Flutter.Shell.Droid.View;
using FlutterBinding.Engine;
using FlutterBinding.Shell;
using FlutterBinding.UI;
using SkiaSharp;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Android.Graphics;
using Android.Util;
using Surface = FlutterBinding.Shell.Surface;

namespace Flutter.Shell.Droid
{
    public class PlatformViewAndroid : PlatformView
    {
        private const string Tag = "PlatformViewAndroid";
        private readonly FlutterNativeView _view; //java_object_

        private readonly AndroidSurface android_surface_;

        // We use id 0 to mean that no response is expected.
        private int _nextResponseId = 1;
        private readonly Dictionary<int, PlatformMessageResponse> pending_responses_;


        // TODO: Remove? This was used to register all the java native calls in c++
        //public static bool Register(JNIEnv* env);

        // Creates a PlatformViewAndroid with no rendering surface for use with
        // background execution.
        /// <inheritdoc />
        public PlatformViewAndroid(
            Delegate @delegate,
            TaskRunners taskRunners,
            FlutterNativeView view)
            : base(@delegate, taskRunners)
        {
            _view = view;
        }

        public void NotifyCreated(AndroidNativeWindow nativeWindow)
        {
            if (android_surface_ != null)
            {
                InstallFirstFrameCallback();
                android_surface_.SetNativeWindow(nativeWindow);
            }
            base.NotifyCreated();
        }

        public override async Task NotifyChanged(SKSizeI size)
        {
            if (android_surface_ == null)
                return;

            await _taskRunners.GPUTaskRunner.RunNowOrPostTask(
                () =>
                {
                    android_surface_.OnScreenSurfaceResize(size);
                });
        }

        // |shell::PlatformView|
        public override void NotifyDestroyed()
        {
            android_surface_?.TeardownOnScreenContext();
        }

        public void DispatchPlatformMessage(
            string name,
            object messageData,
            int responseId)
        {

            PlatformMessageResponse responseMessage = null;
            if (responseId > 0)
            {
                responseMessage = new PlatformMessageResponse(responseId, _taskRunners.PlatformTaskRunner);
            }

            DispatchPlatformMessage(new PlatformMessage(name, messageData, responseMessage));
        }

        public void DispatchEmptyPlatformMessage(
            string name,
            int responseId)
        {
            DispatchPlatformMessage(name, null, responseId);
        }

        public void InvokePlatformMessageResponseCallback(
            int responseId,
            object responseData)
        {
            if (responseId == 0)
                return;

            if (!pending_responses_.TryGetValue(responseId, out PlatformMessageResponse messageResponse))
                return;

            pending_responses_.Remove(responseId);
            messageResponse.Complete(responseData);
        }

        public void InvokePlatformMessageEmptyResponseCallback(int responseId)
        {
            InvokePlatformMessageResponseCallback(responseId, null);
        }

        public void DispatchSemanticsAction(
            int id,
            int action,
            object args)
        {
            base.DispatchSemanticsAction(id, (SemanticsAction)action, args);
        }

        public void RegisterExternalTexture(
            long textureId,
            SurfaceTexture surfaceTexture)
        {
            RegisterTexture(new AndroidExternalTexture(textureId, surfaceTexture));
        }

        // |shell::PlatformView|
        public override void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions)
        {
            _view.UpdateSemantics(update, actions);
        }

        // |shell::PlatformView|
        public override void HandlePlatformMessage(PlatformMessage message)
        {
            if (_view == null)
                return;

            int responseId = 0;
            if (message.ResponseMessage != null)
            {
                responseId = Interlocked.Increment(ref _nextResponseId);
                pending_responses_[responseId] = message.ResponseMessage;
            }

            _view.HandlePlatformMessage(message.Channel, message.RequestData, responseId);
        }

        // |shell::PlatformView|
        public override void OnPreEngineRestart()
        {
            _view?.OnPreEngineRestart();
        }

        // |shell::PlatformView|
        public override FlutterBinding.Shell.VsyncWaiter CreateVSyncWaiter()
        {
            return new VsyncWaiterAndroid(_taskRunners);
        }

        // |shell::PlatformView|
        protected override Surface CreateRenderingSurface()
        {
            return android_surface_?.CreateGPUSurface();
        }

        // |shell::PlatformView|
        public override GRContext CreateResourceContext()
        {
            if (android_surface_ == null)
                return null;

            GRContext resourceContext = null;
            if (android_surface_.ResourceContextMakeCurrent())
            {
                // TODO(chinmaygarde): Currently, this code depends on the fact that only
                // the OpenGL surface will be able to make a resource context current. If
                // this changes, this assumption breaks. Handle the same.

                // TODO: ???
                //resourceContext = IOManager::CreateCompatibleResourceLoadingContext(GRBackend.OpenGL);
            }
            else
            {
                Log.Error(Tag, "Could not make the resource context current.");
            }

            return resourceContext;
        }

        // |shell::PlatformView|
        public override void ReleaseResourceContext()
        {
            android_surface_?.ResourceContextClearCurrent();
        }

        public void InstallFirstFrameCallback()
        {
            SetNextFrameCallback(() => 
            {
                _taskRunners.PlatformTaskRunner.PostTask(FireFirstFrameCallback);
            });
        }

        public void FireFirstFrameCallback()
        {
            _view?.RaiseFirstFrame();
        }
    }
}
