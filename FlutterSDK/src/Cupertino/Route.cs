using System;
using FlutterSDK;
using FlutterSDK.Widgets.Framework;
using System.Net.Http;
using FlutterBinding.UI;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using SkiaSharp;
using FlutterBinding.Engine.Painting;
using static FlutterSDK.Global;
using FlutterBinding.Mapping;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Willpopscope;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Scrollview;
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
        internal static Future<T> ShowCupertinoModalPopup<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), ImageFilter filter = default(ImageFilter), bool useRootNavigator = true, bool semanticsDismissible = default(bool))
        {
            throw new NotImplementedException();
        }

        internal static FlutterSDK.Widgets.Framework.Widget _BuildCupertinoDialogTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            throw new NotImplementedException();
        }

        internal static Future<T> ShowCupertinoDialog<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {
            throw new NotImplementedException();
        }

    }

    public class CupertinoPageRoute<T> : FlutterSDK.Widgets.Pages.PageRoute<T>
    {
        #region constructors
        public CupertinoPageRoute(FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), string title = default(string), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings), bool maintainState = true, bool fullscreenDialog = false)
        : base(settings: settings, fullscreenDialog: fullscreenDialog)
        {
            this.Builder = builder;
            this.Title = title;
            this.MaintainState = maintainState; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
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
        #endregion

        #region methods

        public new void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public new bool CanTransitionTo(FlutterSDK.Widgets.Routes.TransitionRoute<object> nextRoute) { throw new NotImplementedException(); }


        public virtual bool IsPopGestureInProgress(FlutterSDK.Widgets.Pages.PageRoute<object> route) { throw new NotImplementedException(); }


        private bool _IsPopGestureEnabled<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }


        private _CupertinoBackGestureController<T> _StartPopGesture<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget BuildPageTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }

        #endregion
    }


    public class CupertinoPageTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoPageTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> primaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> secondaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool linearTransition = default(bool))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _PrimaryPositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _SecondaryPositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Decoration.Decoration> _PrimaryShadowAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class CupertinoFullscreenDialogTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoFullscreenDialogTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> primaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> secondaryRouteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool linearTransition = default(bool))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _PositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _SecondaryPositionAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoBackGestureDetector<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _CupertinoBackGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Basictypes.ValueGetter<bool> enabledCallback = default(FlutterSDK.Foundation.Basictypes.ValueGetter<bool>), FlutterSDK.Foundation.Basictypes.ValueGetter<_CupertinoBackGestureController<T>> onStartPopGesture = default(FlutterSDK.Foundation.Basictypes.ValueGetter<_CupertinoBackGestureController<T>>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.EnabledCallback = enabledCallback;
            this.OnStartPopGesture = onStartPopGesture;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueGetter<bool> EnabledCallback { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueGetter<_CupertinoBackGestureController<T>> OnStartPopGesture { get; set; }
        #endregion

        #region methods

        public new _CupertinoBackGestureDetectorState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoBackGestureDetectorState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Route._CupertinoBackGestureDetector<T>>
    {
        #region constructors
        public _CupertinoBackGestureDetectorState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Cupertino.Route._CupertinoBackGestureController<T> _BackGestureController { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Recognizer { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        private void _HandleDragCancel() { throw new NotImplementedException(); }


        private void _HandlePointerDown(FlutterSDK.Gestures.Events.PointerDownEvent @event) { throw new NotImplementedException(); }


        private double _ConvertToLogical(double value) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoBackGestureController<T>
    {
        #region constructors
        public _CupertinoBackGestureController(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController))
        : base()
        {
            this.Navigator = navigator;
            this.Controller = controller; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get; set; }
        #endregion

        #region methods

        public virtual void DragUpdate(double delta) { throw new NotImplementedException(); }


        public virtual void DragEnd(double velocity) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoEdgeShadowDecoration : FlutterSDK.Painting.Decoration.Decoration
    {
        #region constructors
        public _CupertinoEdgeShadowDecoration(FlutterSDK.Painting.Gradient.LinearGradient edgeGradient = default(FlutterSDK.Painting.Gradient.LinearGradient))
        {
            this.EdgeGradient = edgeGradient; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration None { get; set; }
        public virtual FlutterSDK.Painting.Gradient.LinearGradient EdgeGradient { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration Lerp(FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration a, FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration b, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration LerpFrom(FlutterSDK.Painting.Decoration.Decoration a, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration LerpTo(FlutterSDK.Painting.Decoration.Decoration b, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Cupertino.Route._CupertinoEdgeShadowPainter CreateBoxPainter(VoidCallback onChanged = default(VoidCallback)) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoEdgeShadowPainter : FlutterSDK.Painting.Decoration.BoxPainter
    {
        #region constructors
        public _CupertinoEdgeShadowPainter(FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration _decoration, VoidCallback onChange)
        : base(onChange)
        {
            this._Decoration = _decoration; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Cupertino.Route._CupertinoEdgeShadowDecoration _Decoration { get; set; }
        #endregion

        #region methods

        public new void Paint(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoModalPopupRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
    {
        #region constructors
        public _CupertinoModalPopupRoute(FlutterBinding.UI.Color barrierColor = default(FlutterBinding.UI.Color), string barrierLabel = default(string), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool semanticsDismissible = default(bool), ImageFilter filter = default(ImageFilter), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(filter: filter, settings: settings)
        {
            this.BarrierColor = barrierColor;
            this.BarrierLabel = barrierLabel;
            this.Builder = builder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
        internal virtual bool _SemanticsDismissible { get; set; }
        public new string BarrierLabel { get; set; }
        public new FlutterBinding.UI.Color BarrierColor { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<Offset> _OffsetTween { get; set; }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SemanticsDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Animation.Animation.Animation<double> CreateAnimation() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }

        #endregion
    }

}
