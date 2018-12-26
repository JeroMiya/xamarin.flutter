using Android.Content;
using Android.Hardware.Display;
using Android.Util;
using Android.Views;
using Flutter.Shell.Droid.View;
using Java.Lang;
using System;

namespace Flutter.Shell.Droid.Plugin.Platform
{
    public sealed class OnAttachStateChangeListenerImplementor :
        Java.Lang.Object,
        Android.Views.View.IOnAttachStateChangeListener
    {
        private readonly object _sender;
        public EventHandler<Android.Views.View.ViewAttachedToWindowEventArgs> OnViewAttachedToWindowHandler;
        public EventHandler<Android.Views.View.ViewDetachedFromWindowEventArgs> OnViewDetachedFromWindowHandler;

        public OnAttachStateChangeListenerImplementor(object sender)
        {
            _sender = sender;
        }

        public void OnViewAttachedToWindow(Android.Views.View attachedView)
        {
            OnViewAttachedToWindowHandler?.Invoke(_sender, new Android.Views.View.ViewAttachedToWindowEventArgs(attachedView));
        }

        public void OnViewDetachedFromWindow(Android.Views.View detachedView)
        {
            OnViewDetachedFromWindowHandler?.Invoke(_sender, new Android.Views.View.ViewDetachedFromWindowEventArgs(detachedView));
        }
    }

    //@TargetApi(Build.VERSION_CODES.KITKAT_WATCH)
    internal class VirtualDisplayController
    {
        public static VirtualDisplayController Create(
            Context context,
            PlatformViewFactory viewFactory,
            ITextureRegistrySurfaceTextureEntry textureEntry,
            int width,
            int height,
            int viewId,
            object createParams
        )
        {
            textureEntry.SurfaceTexture.SetDefaultBufferSize(width, height);
            Surface surface = new Surface(textureEntry.SurfaceTexture);
            DisplayManager displayManager = (DisplayManager)context.GetSystemService(Context.DisplayService);

            DisplayMetricsDensity densityDpi = context.Resources.DisplayMetrics.DensityDpi;
            VirtualDisplay virtualDisplay = displayManager.CreateVirtualDisplay(
                "flutter-vd",
                width,
                height,
                (int)densityDpi,
                surface,
                0
            );

            if (virtualDisplay == null)
                return null;

            return new VirtualDisplayController(
                context,
                virtualDisplay,
                viewFactory,
                surface,
                textureEntry,
                viewId,
                createParams);
        }

        private readonly Context _context;
        private readonly DisplayMetricsDensity _densityDpi;
        private readonly ITextureRegistrySurfaceTextureEntry _textureEntry;
        private VirtualDisplay _virtualDisplay;
        private SingleViewPresentation _presentation;
        private readonly Surface _surface;


        private VirtualDisplayController(
            Context context,
            VirtualDisplay virtualDisplay,
            PlatformViewFactory viewFactory,
            Surface surface,
            ITextureRegistrySurfaceTextureEntry textureEntry,
            int viewId,
            object createParams)
        {
            _textureEntry   = textureEntry;
            _surface        = surface;
            _context        = context;
            _virtualDisplay = virtualDisplay;
            _densityDpi     = context.Resources.DisplayMetrics.DensityDpi;
            _presentation = new SingleViewPresentation(
                context,
                _virtualDisplay.Display,
                viewFactory,
                viewId,
                createParams);
            _presentation.Show();
        }

        public void Resize(int width, int height, Action onNewSizeFrameAvailable)
        {
            SingleViewPresentation.PresentationState presentationState = _presentation.DetachState();
            // We detach the surface to prevent it being destroyed when releasing the vd.
            //
            // setSurface is only available starting API 20. We could support API 19 by re-creating a new
            // SurfaceTexture here. This will require refactoring the TextureRegistry to allow recycling texture
            // entry IDs.
            _virtualDisplay.Surface = null;
            _virtualDisplay.Release();

            _textureEntry.SurfaceTexture.SetDefaultBufferSize(width, height);
            DisplayManager displayManager = (DisplayManager)_context.GetSystemService(Context.DisplayService);
            _virtualDisplay = displayManager.CreateVirtualDisplay(
                "flutter-vd",
                width,
                height,
                (int)_densityDpi,
                _surface,
                0
            );

            Android.Views.View embeddedView = GetView();
            // There's a bug in Android version older than O where view tree observer onDrawListeners don't get properly
            // merged when attaching to window, as a workaround we register the on draw listener after the view is attached.

            OnAttachStateChangeListenerImplementor listener = new OnAttachStateChangeListenerImplementor(embeddedView);
            listener.OnViewAttachedToWindowHandler += (sender, args) =>
            {
                Android.Views.View view = (Android.Views.View)sender;

                OneTimeOnDrawListener.Schedule(
                    embeddedView,
                    new Runnable(
                        () =>
                        {
                            // We need some delay here until the frame propagates through the vd surface to the texture,
                            // 128ms was picked pretty arbitrarily based on trial and error.
                            // As long as we invoke the runnable after a new frame is available we avoid the scaling jank
                            // described in: https://github.com/flutter/flutter/issues/19572
                            // We should ideally run onNewSizeFrameAvailable ASAP to make the embedded view more responsive
                            // following a resize.
                            embeddedView.PostDelayed(onNewSizeFrameAvailable, 128);
                        }));
                embeddedView.RemoveOnAttachStateChangeListener(listener);
            };
            embeddedView.AddOnAttachStateChangeListener(listener);

            _presentation = new SingleViewPresentation(_context, _virtualDisplay.Display, presentationState);
            _presentation.Show();
        }

        public void Dispose()
        {
            IPlatformView view = _presentation.GetView();
            _presentation.DetachState();
            view.Dispose();
            _virtualDisplay.Release();
            _textureEntry.Release();
        }

        public Android.Views.View GetView()
        {
            var platformView = _presentation?.GetView();
            return platformView?.GetView();
        }

        //@TargetApi(Build.VERSION_CODES.JELLY_BEAN)
        public class OneTimeOnDrawListener : Java.Lang.Object, ViewTreeObserver.IOnDrawListener
        {
            public static void Schedule(Android.Views.View view, Runnable runnable)
            {
                OneTimeOnDrawListener listener = new OneTimeOnDrawListener(view, runnable);
                view.ViewTreeObserver.AddOnDrawListener(listener);
            }

            private readonly Android.Views.View _view;
            private Runnable _onDrawRunnable;

            public OneTimeOnDrawListener(Android.Views.View view, Runnable onDrawRunnable)
            {
                _view           = view;
                _onDrawRunnable = onDrawRunnable;
            }

            //@Override
            public void OnDraw()
            {
                if (_onDrawRunnable == null)
                    return;

                _onDrawRunnable.Run();
                _onDrawRunnable = null;
                _view.Post(new Runnable(() => { _view.ViewTreeObserver.RemoveOnDrawListener(this); }));
            }
        }
    }
}
