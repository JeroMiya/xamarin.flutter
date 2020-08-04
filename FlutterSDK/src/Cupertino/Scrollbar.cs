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
namespace FlutterSDK.Cupertino.Scrollbar
{
    internal static class ScrollbarDefaultClass
    {
        public static double _KScrollbarMinLength = default(double);
        public static double _KScrollbarMinOverscrollLength = default(double);
        public static TimeSpan _KScrollbarTimeToFade = default(TimeSpan);
        public static TimeSpan _KScrollbarFadeDuration = default(TimeSpan);
        public static TimeSpan _KScrollbarResizeDuration = default(TimeSpan);
        public static Color _KScrollbarColor = default(Color);
        public static double _KScrollbarThickness = default(double);
        public static double _KScrollbarThicknessDragging = default(double);
        public static Radius _KScrollbarRadius = default(Radius);
        public static Radius _KScrollbarRadiusDragging = default(Radius);
        public static double _KScrollbarMainAxisMargin = default(double);
        public static double _KScrollbarCrossAxisMargin = default(double);
        internal static bool _HitTestInteractive(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> customPaintKey, FlutterBinding.UI.Offset offset)
        {
            if (customPaintKey.CurrentContext == null)
            {
                return false;
            }

            CustomPaint customPaint = customPaintKey.CurrentContext.Widget as CustomPaint;
            ScrollbarPainter painter = customPaint.ForegroundPainter as ScrollbarPainter;
            RenderBox renderBox = customPaintKey.CurrentContext.FindRenderObject() as RenderBox;
            Offset localOffset = renderBox.GlobalToLocal(offset);
            return painter.HitTestInteractive(localOffset);
        }



    }

    /// <Summary>
    /// An iOS style scrollbar.
    ///
    /// A scrollbar indicates which portion of a [Scrollable] widget is actually
    /// visible.
    ///
    /// To add a scrollbar to a [ScrollView], simply wrap the scroll view widget in
    /// a [CupertinoScrollbar] widget.
    ///
    /// By default, the CupertinoScrollbar will be draggable (a feature introduced
    /// in iOS 13), it uses the PrimaryScrollController. For multiple scrollbars, or
    /// other more complicated situations, see the [controller] parameter.
    ///
    /// See also:
    ///
    ///  * [ListView], which display a linear, scrollable list of children.
    ///  * [GridView], which display a 2 dimensional, scrollable array of children.
    ///  * [Scrollbar], a Material Design scrollbar that dynamically adapts to the
    ///    platform showing either an Android style or iOS style scrollbar.
    /// </Summary>
    public class CupertinoScrollbar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates an iOS style scrollbar that wraps the given [child].
        ///
        /// The [child] should be a source of [ScrollNotification] notifications,
        /// typically a [Scrollable] widget.
        /// </Summary>
        public CupertinoScrollbar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool isAlwaysShown = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Controller = controller;
            this.IsAlwaysShown = isAlwaysShown;
            this.Child = child;
        }
        /// <Summary>
        /// The subtree to place inside the [CupertinoScrollbar].
        ///
        /// This should include a source of [ScrollNotification] notifications,
        /// typically a [Scrollable] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.cupertinoScrollbar.controller}
        /// The [ScrollController] used to implement Scrollbar dragging.
        ///
        /// introduced in iOS 13.
        ///
        /// If nothing is passed to controller, the default behavior is to automatically
        /// enable scrollbar dragging on the nearest ScrollController using
        /// [PrimaryScrollController.of].
        ///
        /// If a ScrollController is passed, then scrollbar dragging will be enabled on
        /// the given ScrollController. A stateful ancestor of this CupertinoScrollbar
        /// needs to manage the ScrollController and either pass it to a scrollable
        /// descendant or use a PrimaryScrollController to share it.
        ///
        /// Here is an example of using the `controller` parameter to enable
        /// scrollbar dragging for multiple independent ListViews:
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// final ScrollController _controllerOne = ScrollController();
        /// final ScrollController _controllerTwo = ScrollController();
        ///
        /// build(BuildContext context) {
        /// return Column(
        ///   children: <Widget>[
        ///     Container(
        ///        height: 200,
        ///        child: CupertinoScrollbar(
        ///          controller: _controllerOne,
        ///          child: ListView.builder(
        ///            controller: _controllerOne,
        ///            itemCount: 120,
        ///            itemBuilder: (BuildContext context, int index) => Text('item $index'),
        ///          ),
        ///        ),
        ///      ),
        ///      Container(
        ///        height: 200,
        ///        child: CupertinoScrollbar(
        ///          controller: _controllerTwo,
        ///          child: ListView.builder(
        ///            controller: _controllerTwo,
        ///            itemCount: 120,
        ///            itemBuilder: (BuildContext context, int index) => Text('list 2 item $index'),
        ///          ),
        ///        ),
        ///      ),
        ///    ],
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.cupertinoScrollbar.isAlwaysShown}
        /// Indicates whether the [Scrollbar] should always be visible.
        ///
        /// When false, the scrollbar will be shown during scrolling
        /// and will fade out otherwise.
        ///
        /// When true, the scrollbar will always be visible and never fade out.
        ///
        /// The [controller] property must be set in this case.
        /// It should be passed the relevant [Scrollable]'s [ScrollController].
        ///
        /// Defaults to false.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// final ScrollController _controllerOne = ScrollController();
        /// final ScrollController _controllerTwo = ScrollController();
        ///
        /// build(BuildContext context) {
        /// return Column(
        ///   children: <Widget>[
        ///     Container(
        ///        height: 200,
        ///        child: Scrollbar(
        ///          isAlwaysShown: true,
        ///          controller: _controllerOne,
        ///          child: ListView.builder(
        ///            controller: _controllerOne,
        ///            itemCount: 120,
        ///            itemBuilder: (BuildContext context, int index)
        ///                => Text('item $index'),
        ///          ),
        ///        ),
        ///      ),
        ///      Container(
        ///        height: 200,
        ///        child: CupertinoScrollbar(
        ///          isAlwaysShown: true,
        ///          controller: _controllerTwo,
        ///          child: SingleChildScrollView(
        ///            controller: _controllerTwo,
        ///            child: SizedBox(height: 2000, width: 500,),
        ///          ),
        ///        ),
        ///      ),
        ///    ],
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// {@endtemplate}
        /// </Summary>
        public virtual bool IsAlwaysShown { get; set; }

        public new FlutterSDK.Cupertino.Scrollbar._CupertinoScrollbarState CreateState() => new _CupertinoScrollbarState();


    }


    public class _CupertinoScrollbarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Scrollbar.CupertinoScrollbar>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _CupertinoScrollbarState()
        { }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _CustomPaintKey { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollbar.ScrollbarPainter _Painter { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FadeoutAnimationController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _FadeoutOpacityAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ThicknessAnimationController { get; set; }
        internal virtual Timer _FadeoutTimer { get; set; }
        internal virtual double _DragScrollbarPositionY { get; set; }
        internal virtual FlutterSDK.Gestures.Drag.Drag _Drag { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _CurrentController { get; set; }
        internal virtual double _PressStartY { get; set; }
        internal virtual double _Thickness { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _Radius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _Controller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> _Gestures { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _FadeoutAnimationController = new AnimationController(vsync: this, duration: ScrollbarDefaultClass._KScrollbarFadeDuration);
            _FadeoutOpacityAnimation = new CurvedAnimation(parent: _FadeoutAnimationController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            _ThicknessAnimationController = new AnimationController(vsync: this, duration: ScrollbarDefaultClass._KScrollbarResizeDuration);
            _ThicknessAnimationController.AddListener(() =>
            {
                _Painter.UpdateThickness(_Thickness, _Radius);
            }
            );
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            if (_Painter == null)
            {
                _Painter = _BuildCupertinoScrollbarPainter(Context);
            }
            else
            {
                ..TextDirection = BasicDefaultClass.Directionality.Of(Context)..Color = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ScrollbarDefaultClass._KScrollbarColor, Context)..Padding = MediaqueryDefaultClass.MediaQuery.Of(Context).Padding;
            }

            BindingDefaultClass.WidgetsBinding.Instance.AddPostFrameCallback((TimeSpan duration) =>
            {
                if (Widget.IsAlwaysShown)
                {

                    Widget.Controller.Position.DidUpdateScrollPositionBy(0);
                }

            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Scrollbar.CupertinoScrollbar oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.IsAlwaysShown != oldWidget.IsAlwaysShown)
            {
                if (Widget.IsAlwaysShown == true)
                {

                    _FadeoutAnimationController.AnimateTo(1.0);
                }
                else
                {
                    _FadeoutAnimationController.Reverse();
                }

            }

        }




        /// <Summary>
        /// Returns a [ScrollbarPainter] visually styled like the iOS scrollbar.
        /// </Summary>
        private FlutterSDK.Widgets.Scrollbar.ScrollbarPainter _BuildCupertinoScrollbarPainter(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new ScrollbarPainter(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ScrollbarDefaultClass._KScrollbarColor, context), textDirection: BasicDefaultClass.Directionality.Of(context), thickness: _Thickness, fadeoutOpacityAnimation: _FadeoutOpacityAnimation, mainAxisMargin: ScrollbarDefaultClass._KScrollbarMainAxisMargin, crossAxisMargin: ScrollbarDefaultClass._KScrollbarCrossAxisMargin, radius: _Radius, padding: MediaqueryDefaultClass.MediaQuery.Of(context).Padding, minLength: ScrollbarDefaultClass._KScrollbarMinLength, minOverscrollLength: ScrollbarDefaultClass._KScrollbarMinOverscrollLength);
        }




        private void _DragScrollbar(double primaryDelta)
        {

            double scrollOffsetLocal = _Painter.GetTrackToScroll(primaryDelta);
            double scrollOffsetGlobal = scrollOffsetLocal + _CurrentController.Position.Pixels;
            if (_Drag == null)
            {
                _Drag = _CurrentController.Position.Drag(new DragStartDetails(globalPosition: new Offset(0.0, scrollOffsetGlobal)), () =>
                {
                }
                );
            }
            else
            {
                _Drag.Update(new DragUpdateDetails(globalPosition: new Offset(0.0, scrollOffsetGlobal), delta: new Offset(0.0, -scrollOffsetLocal), primaryDelta: -scrollOffsetLocal));
            }

        }




        private void _StartFadeoutTimer()
        {
            if (!Widget.IsAlwaysShown)
            {
                _FadeoutTimer?.Cancel();
                _FadeoutTimer = Timer.CreateNew(ScrollbarDefaultClass._KScrollbarTimeToFade, () =>
                {
                    _FadeoutAnimationController.Reverse();
                    _FadeoutTimer = null;
                }
                );
            }

        }




        private bool _CheckVertical()
        {
            try
            {
                return _CurrentController.Position.Axis == Axis.Vertical;
            }
            catch (_)
            {
                return false;
            }

        }




        private void _HandleLongPressStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details)
        {
            _CurrentController = _Controller;
            if (!_CheckVertical())
            {
                return;
            }

            _PressStartY = details.LocalPosition.Dy;
            _FadeoutTimer?.Cancel();
            _FadeoutAnimationController.Forward();
            _DragScrollbar(details.LocalPosition.Dy);
            _DragScrollbarPositionY = details.LocalPosition.Dy;
        }




        private void _HandleLongPress()
        {
            if (!_CheckVertical())
            {
                return;
            }

            _FadeoutTimer?.Cancel();
            _ThicknessAnimationController.Forward().Then((_) => =>HapticfeedbackDefaultClass.HapticFeedback.MediumImpact());
        }




        private void _HandleLongPressMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details)
        {
            if (!_CheckVertical())
            {
                return;
            }

            _DragScrollbar(details.LocalPosition.Dy - _DragScrollbarPositionY);
            _DragScrollbarPositionY = details.LocalPosition.Dy;
        }




        private void _HandleLongPressEnd(FlutterSDK.Gestures.Longpress.LongPressEndDetails details)
        {
            if (!_CheckVertical())
            {
                return;
            }

            _HandleDragScrollEnd(details.Velocity.PixelsPerSecond.Dy);
            if (details.Velocity.PixelsPerSecond.Dy.Abs() < 10 && (details.LocalPosition.Dy - _PressStartY).Abs() > 0)
            {
                HapticfeedbackDefaultClass.HapticFeedback.MediumImpact();
            }

            _CurrentController = null;
        }




        private void _HandleDragScrollEnd(double trackVelocityY)
        {
            _StartFadeoutTimer();
            _ThicknessAnimationController.Reverse();
            _DragScrollbarPositionY = null;
            double scrollVelocityY = _Painter.GetTrackToScroll(trackVelocityY);
            _Drag?.End(new DragEndDetails(primaryVelocity: -scrollVelocityY, velocity: new Velocity(pixelsPerSecond: new Offset(0.0, -scrollVelocityY))));
            _Drag = null;
        }




        private bool _HandleScrollNotification(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification)
        {
            ScrollMetrics metrics = notification.Metrics;
            if (metrics.MaxScrollExtent <= metrics.MinScrollExtent)
            {
                return false;
            }

            if (notification is ScrollUpdateNotification || notification is OverscrollNotification)
            {
                if (_FadeoutAnimationController.Status != AnimationStatus.Forward)
                {
                    _FadeoutAnimationController.Forward();
                }

                _FadeoutTimer?.Cancel();
                _Painter.Update(notification.Metrics, notification.Metrics.AxisDirection);
            }
            else if (notification is ScrollEndNotification)
            {
                if (_DragScrollbarPositionY == null)
                {
                    _StartFadeoutTimer();
                }

            }

            return false;
        }




        public new void Dispose()
        {
            _FadeoutAnimationController.Dispose();
            _ThicknessAnimationController.Dispose();
            _FadeoutTimer?.Cancel();
            _Painter.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new NotificationListener<ScrollNotification>(onNotification: _HandleScrollNotification, child: new RepaintBoundary(child: new RawGestureDetector(gestures: _Gestures, child: new CustomPaint(key: _CustomPaintKey, foregroundPainter: _Painter, child: new RepaintBoundary(child: Widget.Child)))));
        }



    }


    public class _ThumbPressGestureRecognizer : FlutterSDK.Gestures.Longpress.LongPressGestureRecognizer
    {
        public _ThumbPressGestureRecognizer(double postAcceptSlopTolerance = default(double), PointerDeviceKind kind = default(PointerDeviceKind), @Object debugOwner = default(@Object), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> customPaintKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>))
        : base(postAcceptSlopTolerance: postAcceptSlopTolerance, kind: kind, debugOwner: debugOwner, duration: new TimeSpan(milliseconds: 100))
        {

        }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _CustomPaintKey { get; set; }

        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            if (!ScrollbarDefaultClass._HitTestInteractive(_CustomPaintKey, @event.Position))
            {
                return false;
            }

            return base.IsPointerAllowed(@event);
        }



    }

}
