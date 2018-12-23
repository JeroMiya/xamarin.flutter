
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.Lang.Reflect;

namespace Flutter.Shell.Droid.Plugin.Platform
{
    /*
     * A presentation used for hosting a single Android view in a virtual display.
     *
     * This presentation overrides the WindowManager's addView/removeView/updateViewLayout methods, such that views added
     * directly to the WindowManager are added as part of the presentation's view hierarchy (to mFakeWindowRootView).
     *
     * The view hierarchy for the presentation is as following:
     *
     *          mRootView
     *         /         \
     *        /           \
     *       /             \
     *   mContainer       mState.mFakeWindowRootView
     *      |
     *   EmbeddedView
     */
    //@TargetApi(Build.VERSION_CODES.JELLY_BEAN_MR1)
    internal class SingleViewPresentation : Presentation
    {

        /*
         * When an embedded view is resized in Flutterverse we move the Android view to a new virtual display
         * that has the new size. This class keeps the presentation state that moves with the view to the presentation of
         * the new virtual display.
         */
        public class PresentationState
        {
            // The Android view we are embedding in the Flutter app.
            public IPlatformView View;

            // The InvocationHandler for a WindowManager proxy. This is essentially the custom window manager for the
            // presentation.
            public WindowManagerHandler WindowManagerHandler;

            // Contains views that were added directly to the window manager (e.g android.widget.PopupWindow).
            public FakeWindowViewGroup FakeWindowRootView;
        }

        private readonly PlatformViewFactory _viewFactory;

        // This is the view id assigned by the Flutter framework to the embedded view, we keep it here
        // so when we create the platform view we can tell it its view id.
        private readonly int _viewId;

        // This is the creation parameters for the platform view, we keep it here
        // so when we create the platform view we can tell it its view id.
        private readonly object _createParams;

        // The root view for the presentation, it has 2 children: mContainer which contains the embedded view, and
        // mFakeWindowRootView which contains views that were added directly to the presentation's window manager.
        private FrameLayout _rootView;

        // Contains the embedded platform view (mView.getView()) when it is attached to the presentation.
        private FrameLayout _container;

        private readonly PresentationState _state;

        /**
         * Creates a presentation that will use the view factory to create a new
         * platform view in the presentation's onCreate, and attach it.
         */
        public SingleViewPresentation(
                Context outerContext,
                Display display,
                PlatformViewFactory viewFactory,
                int viewId,
                object createParams) : base(outerContext, display)
        {
            _viewFactory = viewFactory;
            _viewId = viewId;
            _createParams = createParams;
            _state = new PresentationState();
            Window.SetFlags(WindowManagerFlags.NotFocusable, WindowManagerFlags.NotFocusable);
        }

        /**
         * Creates a presentation that will attach an already existing view as
         * its root view.
         *
         * <p>The display's density must match the density of the context used
         * when the view was created.
         */
        public SingleViewPresentation(Context outerContext, Display display, PresentationState state) : base(outerContext, display)
        {
            _viewFactory = null;
            _state = state;
            Window.SetFlags(WindowManagerFlags.NotFocusable, WindowManagerFlags.NotFocusable);
        }

        //@Override
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            if (_state.FakeWindowRootView == null)
            {
                _state.FakeWindowRootView = new FakeWindowViewGroup(Context);
            }
            if (_state.WindowManagerHandler == null)
            {
                IWindowManager windowManagerDelegate = (IWindowManager)Context.GetSystemService(Context.WindowService);
                _state.WindowManagerHandler = new WindowManagerHandler(windowManagerDelegate, _state.FakeWindowRootView);
            }

            _container = new FrameLayout(Context);
            PresentationContext context = new PresentationContext(Context, _state.WindowManagerHandler);

            if (_state.View == null)
            {
                _state.View = _viewFactory.Create(context, _viewId, _createParams);
            }

            _container.AddView(_state.View.GetView());
            _rootView = new FrameLayout(Context);
            _rootView.AddView(_container);
            _rootView.AddView(_state.FakeWindowRootView);
            SetContentView(_rootView);
        }

        public PresentationState DetachState()
        {
            _container.RemoveAllViews();
            _rootView.RemoveAllViews();
            return _state;
        }

        public IPlatformView GetView()
        {
            return _state.View;
        }

        /*
         * A view group that implements the same layout protocol that exist between the WindowManager and its direct
         * children.
         *
         * Currently only a subset of the protocol is supported (gravity, x, and y).
         */
        public class FakeWindowViewGroup : ViewGroup
        {
            // Used in onLayout to keep the bounds of the current view.
            // We keep it as a member to avoid object allocations during onLayout which are discouraged.
            private readonly Rect _viewBounds;

            // Used in onLayout to keep the bounds of the child views.
            // We keep it as a member to avoid object allocations during onLayout which are discouraged.
            private readonly Rect _childRect;

            public FakeWindowViewGroup(Context context) : base(context)
            {
                _viewBounds = new Rect();
                _childRect = new Rect();
            }

            //@Override
            protected override void OnLayout(bool changed, int l, int t, int r, int b)
            {
                for (int i = 0; i < ChildCount; i++)
                {
                    Android.Views.View child = GetChildAt(i);
                    WindowManagerLayoutParams @params = (WindowManagerLayoutParams)child.LayoutParameters;
                    _viewBounds.Set(l, t, r, b);
                    Gravity.Apply(
                        @params.Gravity,
                        child.MeasuredWidth,
                        child.MeasuredHeight,
                        _viewBounds,
                        @params.X,
                        @params.Y,
                        _childRect);
                    child.Layout(_childRect.Left, _childRect.Top, _childRect.Right, _childRect.Bottom);
                }
            }

            //@Override
            protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
            {
                for (int i = 0; i < ChildCount; i++)
                {
                    Android.Views.View child = GetChildAt(i);
                    child.Measure(AtMost(widthMeasureSpec), AtMost(heightMeasureSpec));
                }
                base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            }

            private static int AtMost(int measureSpec)
            {
                return MeasureSpec.MakeMeasureSpec(MeasureSpec.GetSize(measureSpec), MeasureSpecMode.AtMost);
            }
        }

        /**
         * Proxies a Context replacing the WindowManager with our custom instance.
         */
        public class PresentationContext : ContextWrapper
        {
            private IWindowManager _windowManager;
            private readonly WindowManagerHandler _windowManagerHandler;

            public PresentationContext(Context @base, WindowManagerHandler windowManagerHandler) : base(@base)
            {
                _windowManagerHandler = windowManagerHandler;
            }

            //@Override
            public override Object GetSystemService(string name)
            {
                if (WindowService.Equals(name))
                {
                    return (Object)GetWindowManager();
                }
                return base.GetSystemService(name);
            }

            private IWindowManager GetWindowManager()
            {
                return _windowManager ?? (_windowManager = _windowManagerHandler.GetWindowManager());
            }
        }

        /*
         * A dynamic proxy handler for a WindowManager with custom overrides.
         *
         * The presentation's window manager delegates all calls to the default window manager.
         * WindowManager#addView calls triggered by views that are attached to the virtual display are crashing
         * (see: https://github.com/flutter/flutter/issues/20714). This was triggered when selecting text in an embedded
         * WebView (as the selection handles are implemented as popup windows).
         *
         * This dynamic proxy overrides the addView, removeView, removeViewImmediate, and updateViewLayout methods
         * to prevent these crashes.
         *
         * This will be more efficient as a static proxy that's not using reflection, but as the engine is currently
         * not being built against the latest Android SDK we cannot override all relevant method.
         * Tracking issue for upgrading the engine's Android sdk: https://github.com/flutter/flutter/issues/20717
         */
        public class WindowManagerHandler : Object, IInvocationHandler
        {
            private static readonly string TAG = "PlatformViewsController";

            private readonly IWindowManager _delegate;
            private readonly FakeWindowViewGroup _fakeWindowRootView;

            public WindowManagerHandler(
                IWindowManager @delegate,
                FakeWindowViewGroup fakeWindowViewGroup)
            {
                _delegate = @delegate;
                _fakeWindowRootView = fakeWindowViewGroup;
            }

            public IWindowManager GetWindowManager()
            {
                Class @class = Class.FromType(typeof(IWindowManager));
                return (IWindowManager)Proxy.NewProxyInstance(
                    @class.ClassLoader,
                    new[] { @class },
                    this);
            }

            /// <inheritdoc />
            public Java.Lang.Object Invoke(Java.Lang.Object proxy, Method method, Java.Lang.Object[] args)
            {
                switch (method.Name)
                {
                    case "addView":
                        AddView(args);
                        return null;
                    case "removeView":
                        RemoveView(args);
                        return null;
                    case "removeViewImmediate":
                        RemoveViewImmediate(args);
                        return null;
                    case "updateViewLayout":
                        UpdateViewLayout(args);
                        return null;
                }
                try
                {
                    return method.Invoke((Object)_delegate, args);
                }
                catch (InvocationTargetException e)
                {
                    throw e.Cause;
                }
            }

            private void AddView(Object[] args)
            {
                if (_fakeWindowRootView == null)
                {
                    Log.Warn(TAG, "Embedded view called addView while detached from presentation");
                    return;
                }
                Android.Views.View view = (Android.Views.View)args[0];
                WindowManagerLayoutParams layoutParams = (WindowManagerLayoutParams)args[1];
                _fakeWindowRootView.AddView(view, layoutParams);
            }

            private void RemoveView(object[] args)
            {
                if (_fakeWindowRootView == null)
                {
                    Log.Warn(TAG, "Embedded view called removeView while detached from presentation");
                    return;
                }
                Android.Views.View view = (Android.Views.View)args[0];
                _fakeWindowRootView.RemoveView(view);
            }

            private void RemoveViewImmediate(object[] args)
            {
                if (_fakeWindowRootView == null)
                {
                    Log.Warn(TAG, "Embedded view called removeViewImmediate while detached from presentation");
                    return;
                }
                Android.Views.View view = (Android.Views.View)args[0];
                view.ClearAnimation();
                _fakeWindowRootView.RemoveView(view);
            }

            private void UpdateViewLayout(object[] args)
            {
                if (_fakeWindowRootView == null)
                {
                    Log.Warn(TAG, "Embedded view called updateViewLayout while detached from presentation");
                    return;
                }
                Android.Views.View view = (Android.Views.View)args[0];
                WindowManagerLayoutParams layoutParams = (WindowManagerLayoutParams)args[1];
                _fakeWindowRootView.UpdateViewLayout(view, layoutParams);
            }

        }
    }
}