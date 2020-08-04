using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Cupertino.Route
{
    internal static class RouteDefaultClass
    {
        public static double _KBackGestureWidth = default(double);
        public static double _KMinFlingVelocity = default(double);
        public static int _KMaxDroppedSwipePageForwardAnimationTime = default(int);
        public static int _KMaxPageBackAnimationTime = default(int);
        public static Color _KModalBarrierColor = default(Color);
        public static TimeSpan _KModalPopupTransitionDuration = default(TimeSpan);
        public static FlutterSDK.Animation.Tween.Animatable<Offset> _KRightMiddleTween = default(FlutterSDK.Animation.Tween.Animatable<Offset>);
        public static FlutterSDK.Animation.Tween.Animatable<Offset> _KMiddleLeftTween = default(FlutterSDK.Animation.Tween.Animatable<Offset>);
        public static FlutterSDK.Animation.Tween.Animatable<Offset> _KBottomUpTween = default(FlutterSDK.Animation.Tween.Animatable<Offset>);
        public static FlutterSDK.Widgets.Implicitanimations.DecorationTween _KGradientShadowTween = default(FlutterSDK.Widgets.Implicitanimations.DecorationTween);
        public static FlutterSDK.Animation.Tween.Animatable<double> _DialogScaleTween = default(FlutterSDK.Animation.Tween.Animatable<double>);
        /// <Summary>
        /// Shows a modal iOS-style popup that slides up from the bottom of the screen.
        ///
        /// Such a popup is an alternative to a menu or a dialog and prevents the user
        /// from interacting with the rest of the app.
        ///
        /// The `context` argument is used to look up the [Navigator] for the popup.
        /// It is only used when the method is called. Its corresponding widget can be
        /// safely removed from the tree before the popup is closed.
        ///
        /// The `useRootNavigator` argument is used to determine whether to push the
        /// popup to the [Navigator] furthest from or nearest to the given `context`. It
        /// is `false` by default.
        ///
        /// The `semanticsDismissble` argument is used to determine whether the
        /// semantics of the modal barrier are included in the semantics tree.
        ///
        /// The `builder` argument typically builds a [CupertinoActionSheet] widget.
        /// Content below the widget is dimmed with a [ModalBarrier]. The widget built
        /// by the `builder` does not share a context with the location that
        /// `showCupertinoModalPopup` is originally called from. Use a
        /// [StatefulBuilder] or a custom [StatefulWidget] if the widget needs to
        /// update dynamically.
        ///
        /// Returns a `Future` that resolves to the value that was passed to
        /// [Navigator.pop] when the popup was closed.
        ///
        /// See also:
        ///
        ///  * [CupertinoActionSheet], which is the widget usually returned by the
        ///    `builder` argument to [showCupertinoModalPopup].
        ///  * <https://developer.apple.com/design/human-interface-guidelines/ios/views/action-sheets/>
        /// </Summary>
        internal static Future<T> ShowCupertinoModalPopup<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), ImageFilter filter = default(ImageFilter), bool useRootNavigator = true, bool semanticsDismissible = default(bool))
        {

            return NavigatorDefaultClass.Navigator.Of(context, rootNavigator: useRootNavigator).Push(new _CupertinoModalPopupRoute<T>(barrierColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(RouteDefaultClass._KModalBarrierColor, context), barrierLabel: "Dismiss", builder: builder, filter: filter, semanticsDismissible: semanticsDismissible));
        }



        internal static FlutterSDK.Widgets.Framework.Widget _BuildCupertinoDialogTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            CurvedAnimation fadeAnimation = new CurvedAnimation(parent: animation, curve: CurvesDefaultClass.Curves.EaseInOut);
            if (animation.Status == AnimationStatus.Reverse)
            {
                return new FadeTransition(opacity: fadeAnimation, child: child);
            }

            return new FadeTransition(opacity: fadeAnimation, child: new ScaleTransition(child: child, scale: animation.Drive(RouteDefaultClass._DialogScaleTween)));
        }



        /// <Summary>
        /// Displays an iOS-style dialog above the current contents of the app, with
        /// iOS-style entrance and exit animations, modal barrier color, and modal
        /// barrier behavior (the dialog is not dismissible with a tap on the barrier).
        ///
        /// This function takes a `builder` which typically builds a [CupertinoDialog]
        /// or [CupertinoAlertDialog] widget. Content below the dialog is dimmed with a
        /// [ModalBarrier]. The widget returned by the `builder` does not share a
        /// context with the location that `showCupertinoDialog` is originally called
        /// from. Use a [StatefulBuilder] or a custom [StatefulWidget] if the dialog
        /// needs to update dynamically.
        ///
        /// The `context` argument is used to look up the [Navigator] for the dialog.
        /// It is only used when the method is called. Its corresponding widget can
        /// be safely removed from the tree before the dialog is closed.
        ///
        /// The `useRootNavigator` argument is used to determine whether to push the
        /// dialog to the [Navigator] furthest from or nearest to the given `context`.
        /// By default, `useRootNavigator` is `true` and the dialog route created by
        /// this method is pushed to the root navigator.
        ///
        /// If the application has multiple [Navigator] objects, it may be necessary to
        /// call `Navigator.of(context, rootNavigator: true).pop(result)` to close the
        /// dialog rather than just `Navigator.pop(context, result)`.
        ///
        /// Returns a [Future] that resolves to the value (if any) that was passed to
        /// [Navigator.pop] when the dialog was closed.
        ///
        /// See also:
        ///
        ///  * [CupertinoDialog], an iOS-style dialog.
        ///  * [CupertinoAlertDialog], an iOS-style alert dialog.
        ///  * [showDialog], which displays a Material-style dialog.
        ///  * [showGeneralDialog], which allows for customization of the dialog popup.
        ///  * <https://developer.apple.com/ios/human-interface-guidelines/views/alerts/>
        /// </Summary>
        internal static Future<T> ShowCupertinoDialog<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {


            return RoutesDefaultClass.ShowGeneralDialog(context: context, barrierDismissible: false, barrierColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(RouteDefaultClass._KModalBarrierColor, context), transitionDuration: new TimeSpan(milliseconds: 250), pageBuilder: (BuildContext context, Animation<double> animation, Animation<double> secondaryAnimation) =>
            {
                return builder(context);
            }
            , transitionBuilder: RouteDefaultClass._BuildCupertinoDialogTransitions, useRootNavigator: useRootNavigator, routeSettings: routeSettings);
        }



    }

    /// <Summary>
    /// A modal route that replaces the entire screen with an iOS transition.
    ///
    /// The page slides in from the right and exits in reverse. The page also shifts
    /// to the left in parallax when another page enters to cover it.
    ///
    /// The page slides in from the bottom and exits in reverse with no parallax
    /// effect for fullscreen dialogs.
    ///
    /// By default, when a modal route is replaced by another, the previous route
    /// remains in memory. To free all the resources when this is not necessary, set
    /// [maintainState] to false.
    ///
    /// The type `T` specifies the return type of the route which can be supplied as
    /// the route is popped from the stack via [Navigator.pop] when an optional
    /// `result` can be provided.
    ///
    /// See also:
    ///
    ///  * [MaterialPageRoute], for an adaptive [PageRoute] that uses a
    ///    platform-appropriate transition.
    ///  * [CupertinoPageScaffold], for applications that have one page with a fixed
    ///    navigation bar on top.
    ///  * [CupertinoTabScaffold], for applications that have a tab bar at the
    ///    bottom with multiple pages.
    /// </Summary>
    public class CupertinoPageRoute<T> : FlutterSDK.Widgets.Pages.PageRoute<T>
    {
        /// <Summary>
        /// Creates a page route for use in an iOS designed app.
        ///
        /// The [builder], [maintainState], and [fullscreenDialog] arguments must not
        /// be null.
        /// </Summary>
        public CupertinoPageRoute(FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), string title = default(string), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings), bool maintainState = true, bool fullscreenDialog = false)
        : base(settings: settings, fullscreenDialog: fullscreenDialog)
        {
            this.Builder = builder;
            this.Title = title;
            this.MaintainState = maintainState;
        }
        /// <Summary>
        /// Builds the primary contents of the route.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
        /// <Summary>
        /// A title string for this route.
        ///
        /// Used to auto-populate [CupertinoNavigationBar] and
        /// [CupertinoSliverNavigationBar]'s `middle`/`largeTitle` widgets when
        /// one is not manually supplied.
        /// </Summary>
        public virtual string Title { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<string> _PreviousTitle { get; set; }
        public new bool MaintainState { get; set; }
        public virtual FlutterSDK.Foundation.Changenotifier.ValueListenable<string> PreviousTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string BarrierLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool PopGestureInProgress { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool PopGestureEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {
            string previousTitleString = previousRoute is CupertinoPageRoute ? previousRoute.Title : null;
            if (_PreviousTitle == null)
            {
                _PreviousTitle = new ValueNotifier<string>(previousTitleString);
            }
            else
            {
                _PreviousTitle.Value = previousTitleString;
            }

            base.DidChangePrevious(previousRoute);
        }




        public new bool CanTransitionTo(FlutterSDK.Widgets.Routes.TransitionRoute<object> nextRoute)
        {
            return nextRoute is CupertinoPageRoute && !nextRoute.FullscreenDialog;
        }




        /// <Summary>
        /// True if an iOS-style back swipe pop gesture is currently underway for [route].
        ///
        /// This just check the route's [NavigatorState.userGestureInProgress].
        ///
        /// See also:
        ///
        ///  * [popGestureEnabled], which returns true if a user-triggered pop gesture
        ///    would be allowed.
        /// </Summary>
        public virtual bool IsPopGestureInProgress(FlutterSDK.Widgets.Pages.PageRoute<object> route)
        {
            return route.Navigator.UserGestureInProgress;
        }




        private bool _IsPopGestureEnabled<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route)
        {
            if (route.IsFirst) return false;
            if (route.WillHandlePopInternally) return false;
            if (route.HasScopedWillPopCallback) return false;
            if (route.FullscreenDialog) return false;
            if (route.Animation.Status != AnimationStatus.Completed) return false;
            if (route.SecondaryAnimation.Status != AnimationStatus.Dismissed) return false;
            if (IsPopGestureInProgress(route)) return false;
            return true;
        }




        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation)
        {
            Widget child = Builder(context);
            Widget result = new Semantics(scopesRoute: true, explicitChildNodes: true, child: child);

            return result;
        }




        private _CupertinoBackGestureController<T> _StartPopGesture<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route)
        {

            return new _CupertinoBackGestureController<T>(navigator: route.Navigator, controller: route.Controller);
        }




        /// <Summary>
        /// Returns a [CupertinoFullscreenDialogTransition] if [route] is a full
        /// screen dialog, otherwise a [CupertinoPageTransition] is returned.
        ///
        /// Used by [CupertinoPageRoute.buildTransitions].
        ///
        /// This method can be applied to any [PageRoute], not just
        /// [CupertinoPageRoute]. It's typically used to provide a Cupertino style
        /// horizontal transition for material widgets when the target platform
        /// is [TargetPlatform.iOS].
        ///
        /// See also:
        ///
        ///  * [CupertinoPageTransitionsBuilder], which uses this method to define a
        ///    [PageTransitionsBuilder] for the [PageTransitionsTheme].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildPageTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            bool linearTransition = IsPopGestureInProgress(route);
            if (route.FullscreenDialog)
            {
                return new CupertinoFullscreenDialogTransition(primaryRouteAnimation: animation, secondaryRouteAnimation: secondaryAnimation, child: child, linearTransition: linearTransition);
            }
            else
            {
                return new CupertinoPageTransition(primaryRouteAnimation: animation, secondaryRouteAnimation: secondaryAnimation, linearTransition: linearTransition, child: new _CupertinoBackGestureDetector<T>(enabledCallback: () => =>_IsPopGestureEnabled(route), onStartPopGesture: () => =>_StartPopGesture(route), child: child));
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return BuildPageTransitions(this, context, animation, secondaryAnimation, child);
        }



    }


    /// <Summary>
    /// Provides an iOS-style page transition animation.
    ///
    /// The page slides in from the right and exits in reverse. It also shifts to the left in
    /// a parallax motion when another page enters to cover it.
    /// </Summary>
    public class CupertinoPageTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an iOS-style page transition.
        ///
        ///  * `primaryRouteAnimation` is a linear route animation from 0.0 to 1.0
        ///    when this screen is being pushed.
        ///  * `secondaryRouteAnimation` is a linear route animation from 0.0 to 1.0
        ///    when another screen is being pushed on top of this one.
        ///  * `linearTransition` is whether to perform the transitions linearly.
        ///    Used to precisely track back gesture drags.
        /// </Summary>
        public CupertinoPageTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> primaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> secondaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool linearTransition = default(bool))
        : base(key: key)
        {
            this.Child = child;
        }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _PrimaryPositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _SecondaryPositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Decoration.Decoration> _PrimaryShadowAnimation { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            return new SlideTransition(position: _SecondaryPositionAnimation, textDirection: textDirection, transformHitTests: false, child: new SlideTransition(position: _PrimaryPositionAnimation, textDirection: textDirection, child: new DecoratedBoxTransition(decoration: _PrimaryShadowAnimation, child: Child)));
        }



    }


    /// <Summary>
    /// An iOS-style transition used for summoning fullscreen dialogs.
    ///
    /// For example, used when creating a new calendar event by bringing in the next
    /// screen from the bottom.
    /// </Summary>
    public class CupertinoFullscreenDialogTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an iOS-style transition used for summoning fullscreen dialogs.
        ///
        ///  * `primaryRouteAnimation` is a linear route animation from 0.0 to 1.0
        ///    when this screen is being pushed.
        ///  * `secondaryRouteAnimation` is a linear route animation from 0.0 to 1.0
        ///    when another screen is being pushed on top of this one.
        ///  * `linearTransition` is whether to perform the secondary transition linearly.
        ///    Used to precisely track back gesture drags.
        /// </Summary>
        public CupertinoFullscreenDialogTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> primaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> secondaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool linearTransition = default(bool))
        : base(key: key)
        {
            this.Child = child;
        }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _PositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _SecondaryPositionAnimation { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            return new SlideTransition(position: _SecondaryPositionAnimation, textDirection: textDirection, transformHitTests: false, child: new SlideTransition(position: _PositionAnimation, child: Child));
        }



    }


    /// <Summary>
    /// This is the widget side of [_CupertinoBackGestureController].
    ///
    /// This widget provides a gesture recognizer which, when it determines the
    /// route can be closed with a back gesture, creates the controller and
    /// feeds it the input from the gesture recognizer.
    ///
    /// The gesture data is converted from absolute coordinates to logical
    /// coordinates by this widget.
    ///
    /// The type `T` specifies the return type of the route with which this gesture
    /// detector is associated.
    /// </Summary>
    public class _CupertinoBackGestureDetector<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _CupertinoBackGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Basictypes.ValueGetter<bool> enabledCallback = default(FlutterSDK.Foundation.Basictypes.ValueGetter<bool>), FlutterSDK.Foundation.Basictypes.ValueGetter<_CupertinoBackGestureController<T>> onStartPopGesture = default(FlutterSDK.Foundation.Basictypes.ValueGetter<_CupertinoBackGestureController<T>>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.EnabledCallback = enabledCallback;
            this.OnStartPopGesture = onStartPopGesture;
            this.Child = child;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueGetter<bool> EnabledCallback { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueGetter<_CupertinoBackGestureController<T>> OnStartPopGesture { get; set; }

        public new _CupertinoBackGestureDetectorState<T> CreateState() => new _CupertinoBackGestureDetectorState<T>();


    }


    public class _CupertinoBackGestureDetectorState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Route._CupertinoBackGestureDetector<T>>
    {
        public _CupertinoBackGestureDetectorState()
        { }
        internal virtual FlutterSDK.Cupertino.Route._CupertinoBackGestureController<T> _BackGestureController { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Recognizer { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Recognizer = new HorizontalDragGestureRecognizer(debugOwner: this)..OnStart = _HandleDragStart..OnUpdate = _HandleDragUpdate..OnEnd = _HandleDragEnd..OnCancel = _HandleDragCancel;
        }




        public new void Dispose()
        {
            _Recognizer.Dispose();
            base.Dispose();
        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {


            _BackGestureController = Widget.OnStartPopGesture();
        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {


            _BackGestureController.DragUpdate(_ConvertToLogical(details.PrimaryDelta / Context.Size.Width));
        }




        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {


            _BackGestureController.DragEnd(_ConvertToLogical(details.Velocity.PixelsPerSecond.Dx / Context.Size.Width));
            _BackGestureController = null;
        }




        private void _HandleDragCancel()
        {

            _BackGestureController?.DragEnd(0.0);
            _BackGestureController = null;
        }




        private void _HandlePointerDown(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            if (Widget.EnabledCallback()) _Recognizer.AddPointer(@event);
        }




        private double _ConvertToLogical(double value)
        {
            switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: return -value; case TextDirection.Ltr: return value; }
            return null;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            double dragAreaWidth = BasicDefaultClass.Directionality.Of(context) == TextDirection.Ltr ? MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Left : MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Right;
            dragAreaWidth = Dart.Math.MathDefaultClass.Max(dragAreaWidth, RouteDefaultClass._KBackGestureWidth);
            return new Stack(fit: StackFit.Passthrough, children: new List<Widget>() { Widget.Child, new PositionedDirectional(start: 0.0, width: dragAreaWidth, top: 0.0, bottom: 0.0, child: new Listener(onPointerDown: _HandlePointerDown, behavior: HitTestBehavior.Translucent)) });
        }



    }


    /// <Summary>
    /// A controller for an iOS-style back gesture.
    ///
    /// This is created by a [CupertinoPageRoute] in response from a gesture caught
    /// by a [_CupertinoBackGestureDetector] widget, which then also feeds it input
    /// from the gesture. It controls the animation controller owned by the route,
    /// based on the input provided by the gesture detector.
    ///
    /// This class works entirely in logical coordinates (0.0 is new page dismissed,
    /// 1.0 is new page on top).
    ///
    /// The type `T` specifies the return type of the route with which this gesture
    /// detector controller is associated.
    /// </Summary>
    public class _CupertinoBackGestureController<T>
    {
        /// <Summary>
        /// Creates a controller for an iOS-style back gesture.
        ///
        /// The [navigator] and [controller] arguments must not be null.
        /// </Summary>
        public _CupertinoBackGestureController(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController))
        : base()
        {
            this.Navigator = navigator;
            this.Controller = controller;
            Navigator.DidStartUserGesture();
        }


        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get; set; }

        /// <Summary>
        /// The drag gesture has changed by [fractionalDelta]. The total range of the
        /// drag should be 0.0 to 1.0.
        /// </Summary>
        public virtual void DragUpdate(double delta)
        {
            Controller.Value -= delta;
        }




        /// <Summary>
        /// The drag gesture has ended with a horizontal motion of
        /// [fractionalVelocity] as a fraction of screen width per second.
        /// </Summary>
        public virtual void DragEnd(double velocity)
        {
            Curve animationCurve = CurvesDefaultClass.Curves.FastLinearToSlowEaseIn;
            bool animateForward = default(bool);
            if (velocity.Abs() >= RouteDefaultClass._KMinFlingVelocity) animateForward = velocity <= 0; else animateForward = Controller.Value > 0.5;
            if (animateForward)
            {
                int droppedPageForwardAnimationTime = Dart.Math.MathDefaultClass.Min(Dart.UI.UiDefaultClass.LerpDouble(RouteDefaultClass._KMaxDroppedSwipePageForwardAnimationTime, 0, Controller.Value).Floor(), RouteDefaultClass._KMaxPageBackAnimationTime);
                Controller.AnimateTo(1.0, duration: new TimeSpan(milliseconds: droppedPageForwardAnimationTime), curve: animationCurve);
            }
            else
            {
                Navigator.Pop();
                if (Controller.IsAnimating)
                {
                    int droppedPageBackAnimationTime = Dart.UI.UiDefaultClass.LerpDouble(0, RouteDefaultClass._KMaxDroppedSwipePageForwardAnimationTime, Controller.Value).Floor();
                    Controller.AnimateBack(0.0, duration: new TimeSpan(milliseconds: droppedPageBackAnimationTime), curve: animationCurve);
                }

            }

            if (Controller.IsAnimating)
            {
                AnimationStatusListener animationStatusCallback = default(AnimationStatusListener);
                animationStatusCallback = (AnimationStatus status) =>
                {
                    Navigator.DidStopUserGesture();
                    Controller.RemoveStatusListener(animationStatusCallback);
                }
                ;
                Controller.AddStatusListener(animationStatusCallback);
            }
            else
            {
                Navigator.DidStopUserGesture();
            }

        }



    }


    public class _CupertinoEdgeShadowDecoration : FlutterSDK.Painting.Decoration.Decoration
    {
        public _CupertinoEdgeShadowDecoration(FlutterSDK.Painting.Gradient.LinearGradient edgeGradient = default(FlutterSDK.Painting.Gradient.LinearGradient))
        {
            this.EdgeGradient = edgeGradient;
        }
        public virtual FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration None { get; set; }
        public virtual FlutterSDK.Painting.Gradient.LinearGradient EdgeGradient { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration Lerp(FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration a, FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration b, double t)
        {

            if (a == null && b == null) return null;
            return new _CupertinoEdgeShadowDecoration(edgeGradient: GradientDefaultClass.LinearGradient.Lerp(a?.EdgeGradient, b?.EdgeGradient, t));
        }




        public new FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration LerpFrom(FlutterSDK.Painting.Decoration.Decoration a, double t)
        {
            if (a is _CupertinoEdgeShadowDecoration) return RouteDefaultClass._CupertinoEdgeShadowDecoration.Lerp(a, this, t);
            return RouteDefaultClass._CupertinoEdgeShadowDecoration.Lerp(null, this, t);
        }




        public new FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration LerpTo(FlutterSDK.Painting.Decoration.Decoration b, double t)
        {
            if (b is _CupertinoEdgeShadowDecoration) return RouteDefaultClass._CupertinoEdgeShadowDecoration.Lerp(this, b, t);
            return RouteDefaultClass._CupertinoEdgeShadowDecoration.Lerp(this, null, t);
        }




        public new FlutterSDK.Cupertino.Route._CupertinoEdgeShadowPainter CreateBoxPainter(VoidCallback onChanged = default(VoidCallback))
        {
            return new _CupertinoEdgeShadowPainter(this, onChanged);
        }




        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is _CupertinoEdgeShadowDecoration && other.EdgeGradient == EdgeGradient;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<LinearGradient>("edgeGradient", EdgeGradient));
        }



    }


    /// <Summary>
    /// A [BoxPainter] used to draw the page transition shadow using gradients.
    /// </Summary>
    public class _CupertinoEdgeShadowPainter : FlutterSDK.Painting.Decoration.BoxPainter
    {
        public _CupertinoEdgeShadowPainter(FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration _decoration, VoidCallback onChange)
        : base(onChange)
        {
            this._Decoration = _decoration;
        }
        internal virtual FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration _Decoration { get; set; }

        public new void Paint(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {
            LinearGradient gradient = _Decoration.EdgeGradient;
            if (gradient == null) return;
            TextDirection textDirection = configuration.TextDirection;

            double deltaX = default(double);
            switch (textDirection) { case TextDirection.Rtl: deltaX = configuration.Size.Width; break; case TextDirection.Ltr: deltaX = -configuration.Size.Width; break; }
            Rect rect = (offset & configuration.Size).Translate(deltaX, 0.0);
            Paint paint = new Paint()..Shader = gradient.CreateShader(rect, textDirection: textDirection);
            canvas.DrawRect(rect, paint);
        }



    }


    public class _CupertinoModalPopupRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
    {
        public _CupertinoModalPopupRoute(FlutterBinding.UI.Color barrierColor = default(FlutterBinding.UI.Color), string barrierLabel = default(string), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool semanticsDismissible = default(bool), ImageFilter filter = default(ImageFilter), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(filter: filter, settings: settings)
        {
            this.BarrierColor = barrierColor;
            this.BarrierLabel = barrierLabel;
            this.Builder = builder;
            _SemanticsDismissible = semanticsDismissible;
        }


        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
        internal virtual bool _SemanticsDismissible { get; set; }
        public new string BarrierLabel { get; set; }
        public new FlutterBinding.UI.Color BarrierColor { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<Offset> _OffsetTween { get; set; }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SemanticsDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Animation.Animation.Animation<double> CreateAnimation()
        {

            _Animation = new CurvedAnimation(parent: base.CreateAnimation(), curve: CurvesDefaultClass.Curves.LinearToEaseOut, reverseCurve: CurvesDefaultClass.Curves.LinearToEaseOut.Flipped);
            _OffsetTween = new Tween<Offset>(begin: new Offset(0.0, 1.0), end: new Offset(0.0, 0.0));
            return _Animation;
        }




        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation)
        {
            return new CupertinoUserInterfaceLevel(data: CupertinoUserInterfaceLevelData.Elevated, child: new Builder(builder: Builder));
        }




        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new Align(alignment: AlignmentDefaultClass.Alignment.BottomCenter, child: new FractionalTranslation(translation: _OffsetTween.Evaluate(_Animation), child: child));
        }



    }

}
