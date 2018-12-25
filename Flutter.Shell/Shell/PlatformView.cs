using System;
using System.Threading.Tasks;
using Flutter.Framework.Engine;
using FlutterBinding.Engine;
using SkiaSharp;

namespace Flutter.Framework.Shell
{
    public class PlatformView
    {
        public interface Delegate
        {
            Task OnPlatformViewCreated(Surface surface);
            Task OnPlatformViewDestroyed();
            void OnPlatformViewSetNextFrameCallback(Action callback);
            void OnPlatformViewSetViewportMetrics(ViewportMetrics metrics);
            //void OnPlatformViewDispatchPlatformMessage(PlatformMessage message);
            void OnPlatformViewDispatchPointerDataPacket(PointerDataPacket packet);
            void OnPlatformViewDispatchSemanticsAction(int id, SemanticsAction action, object args);
            void OnPlatformViewSetSemanticsEnabled(bool enabled);
            void OnPlatformViewSetAccessibilityFeatures(AccessibilityFeatures flags);
            void OnPlatformViewRegisterTexture(Texture texture);
            void OnPlatformViewUnregisterTexture(long textureId);
            void OnPlatformViewMarkTextureFrameAvailable(long textureId);
        }

        public PlatformView(Delegate @delegate, TaskRunners taskRunners)
        {
            delegate_ = @delegate;
            _taskRunners = taskRunners;
            _size = SKSizeI.Empty;
        }

        public virtual VsyncWaiter CreateVSyncWaiter()
        {
            //FML_DLOG(WARNING) << "This platform does not provide a Vsync waiter implementation. A simple timer based fallback is being used.";

            return new VsyncWaiterFallback(_taskRunners);
        }

        //public void DispatchPlatformMessage(PlatformMessage message) => delegate_.OnPlatformViewDispatchPlatformMessage(message);

        public void DispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            delegate_.OnPlatformViewDispatchSemanticsAction(id, action, args);
        }

        public virtual void SetSemanticsEnabled(bool enabled)
        {
            delegate_.OnPlatformViewSetSemanticsEnabled(enabled);
        }

        public virtual void SetAccessibilityFeatures(AccessibilityFeatures flags)
        {
            delegate_.OnPlatformViewSetAccessibilityFeatures(flags);
        }

        public void SetViewportMetrics(ViewportMetrics metrics)
        {
            delegate_.OnPlatformViewSetViewportMetrics(metrics);
        }

        public void NotifyCreated()
        {
            delegate_.OnPlatformViewCreated(CreateRenderingSurface());
        }

        public virtual void NotifyDestroyed()
        {
            delegate_.OnPlatformViewDestroyed();
        }

        // Unlike all other methods on the platform view, this one may be called on a
        // non-platform task runner.
        public virtual GRContext CreateResourceContext()
        {
            //FML_DLOG(WARNING) << "This platform does not setup the resource context on the IO thread for async texture uploads.";
            return null;
        }

        // Unlike all other methods on the platform view, this one may be called on a
        // non-platform task runner.
        public virtual void ReleaseResourceContext() { }

        public virtual void UpdateSemantics(SemanticsNodeUpdates updates, CustomAccessibilityActionUpdates actions) { }

        //public virtual void HandlePlatformMessage( PlatformMessage message) { }

        public virtual void OnPreEngineRestart() { }

        public void SetNextFrameCallback(Action callback)
        {
            delegate_.OnPlatformViewSetNextFrameCallback(callback);
        }

        public void DispatchPointerDataPacket(PointerDataPacket packet) { }

        // Called once per texture, on the platform thread.
        public void RegisterTexture(Texture texture)
        {
            delegate_.OnPlatformViewRegisterTexture(texture);
        }

        // Called once per texture, on the platform thread.
        public void UnregisterTexture(long textureId)
        {
            delegate_.OnPlatformViewUnregisterTexture(textureId);
        }

        // Called once per texture update (e.g. video frame), on the platform thread.
        public void MarkTextureFrameAvailable(long textureId)
        {
            delegate_.OnPlatformViewMarkTextureFrameAvailable(textureId);
        }

        protected PlatformView.Delegate delegate_;
        protected TaskRunners _taskRunners;

        protected SKSizeI _size;

        protected virtual Surface CreateRenderingSurface()
        {
            // We have a default implementation because tests create a platform view but
            // never a rendering surface.
            //FML_DCHECK(false) << "This platform does not provide a rendering surface but it was notified of surface rendering surface creation.";
            return null;
        }

        //FML_DISALLOW_COPY_AND_ASSIGN(PlatformView);
    }
}
