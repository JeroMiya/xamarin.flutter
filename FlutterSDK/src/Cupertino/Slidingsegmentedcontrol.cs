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
namespace FlutterSDK.Cupertino.Slidingsegmentedcontrol
{
    internal static class SlidingsegmentedcontrolDefaultClass
    {
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _KHorizontalItemPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry);
        public static Radius _KThumbRadius = default(Radius);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KThumbInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static double _KMinSegmentedControlHeight = default(double);
        public static Color _KSeparatorColor = default(Color);
        public static FlutterSDK.Cupertino.Colors.CupertinoDynamicColor _KThumbColor = default(FlutterSDK.Cupertino.Colors.CupertinoDynamicColor);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KSeparatorInset = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static double _KSeparatorWidth = default(double);
        public static Radius _KSeparatorRadius = default(Radius);
        public static double _KMinThumbScale = default(double);
        public static double _KSegmentMinPadding = default(double);
        public static double _KTouchYDistanceThreshold = default(double);
        public static double _KCornerRadius = default(double);
        public static FlutterSDK.Physics.Springsimulation.SpringSimulation _KThumbSpringAnimationSimulation = default(FlutterSDK.Physics.Springsimulation.SpringSimulation);
        public static TimeSpan _KSpringAnimationDuration = default(TimeSpan);
        public static TimeSpan _KOpacityAnimationDuration = default(TimeSpan);
        public static TimeSpan _KHighlightAnimationDuration = default(TimeSpan);
    }

    public class _FontWeightTween : FlutterSDK.Animation.Tween.Tween<FontWeight>
    {
        #region constructors
        public _FontWeightTween(FontWeight begin = default(FontWeight), FontWeight end = default(FontWeight))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FontWeight Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class CupertinoSlidingSegmentedControl<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoSlidingSegmentedControl(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Dictionary<T, FlutterSDK.Widgets.Framework.Widget> children = default(Dictionary<T, FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onValueChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), T groupValue = default(T), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Children = children;
            this.OnValueChanged = onValueChanged;
            this.GroupValue = groupValue;
            this.ThumbColor = thumbColor;
            this.Padding = padding;
            this.BackgroundColor = backgroundColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<T, FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual T GroupValue { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnValueChanged { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        #endregion

        #region methods

        public new _SegmentedControlState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _SegmentedControlState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Slidingsegmentedcontrol.CupertinoSlidingSegmentedControl<T>>, ITickerProviderStateMixin<FlutterSDK.Cupertino.Slidingsegmentedcontrol.CupertinoSlidingSegmentedControl<T>>
    {
        #region constructors
        public _SegmentedControlState()
        { }
        #endregion

        #region fields
        internal virtual Dictionary<T, FlutterSDK.Animation.Animationcontroller.AnimationController> _HighlightControllers { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<FontWeight> _HighlightTween { get; set; }
        internal virtual Dictionary<T, FlutterSDK.Animation.Animationcontroller.AnimationController> _PressControllers { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _PressTween { get; set; }
        public virtual List<T> Keys { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ThumbController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController SeparatorOpacityController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ThumbScaleController { get; set; }
        public virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer Tap { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer Drag { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.LongPressGestureRecognizer LongPress { get; set; }
        internal virtual T _Highlighted { get; set; }
        internal virtual T _Pressed { get; set; }
        public virtual T Highlighted { set { throw new NotImplementedException(); } }
        public virtual T Pressed { set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Animation.Animationcontroller.AnimationController _CreateHighlightAnimationController(bool isCompleted = false) { throw new NotImplementedException(); }


        private FlutterSDK.Animation.Animationcontroller.AnimationController _CreateFadeoutAnimationController() { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Cupertino.Slidingsegmentedcontrol.CupertinoSlidingSegmentedControl<T> oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _AnimateHighlightController(T at = default(T), bool forward = default(bool)) { throw new NotImplementedException(); }


        public virtual void DidChangeSelectedViaGesture() { throw new NotImplementedException(); }


        public virtual T IndexToKey(int index) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SegmentedControlRenderWidget<T> : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public _SegmentedControlRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int selectedIndex = default(int), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> state = default(FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T>))
        : base(key: key, children: children)
        {
            this.SelectedIndex = selectedIndex;
            this.ThumbColor = thumbColor;
            this.State = state; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int SelectedIndex { get; set; }
        public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
        public virtual FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> State { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Slidingsegmentedcontrol._RenderSegmentedControl<T> renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ChildAnimationManifest
    {
        #region constructors
        public _ChildAnimationManifest(double opacity = 1, double separatorOpacity = default(double))
        : base()
        {
            this.Opacity = opacity;
            this.SeparatorOpacity = separatorOpacity; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Opacity { get; set; }
        public virtual FlutterSDK.Animation.Tween.Tween<double> OpacityTween { get; set; }
        public virtual double SeparatorOpacity { get; set; }
        public virtual FlutterSDK.Animation.Tween.Tween<double> SeparatorTween { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _SegmentedControlContainerBoxParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        #region constructors
        public _SegmentedControlContainerBoxParentData()
        { }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class _RenderSegmentedControl<T> : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>
    {
        #region constructors
        public _RenderSegmentedControl(int selectedIndex = default(int), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> state = default(FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T>))
        : base()
        {
            this.State = state; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> State { get; set; }
        internal virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Cupertino.Slidingsegmentedcontrol._ChildAnimationManifest> _ChildAnimations { get; set; }
        public virtual FlutterBinding.UI.Rect CurrentThumbRect { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<Rect> _CurrentThumbTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _ThumbScaleTween { get; set; }
        public virtual double CurrentThumbScale { get; set; }
        internal virtual FlutterBinding.UI.Offset _LocalDragOffset { get; set; }
        internal virtual bool _StartedOnSelectedSegment { get; set; }
        internal virtual bool _NeedsThumbAnimationUpdate { get; set; }
        internal virtual int _HighlightedIndex { get; set; }
        internal virtual int _PressedIndex { get; set; }
        internal virtual FlutterBinding.UI.Color _ThumbColor { get; set; }
        public virtual int HighlightedIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int PressedIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ThumbColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TotalSeparatorWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Insert(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) { throw new NotImplementedException(); }


        public new void Remove(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public virtual void GuardedSetHighlightedIndex(int value) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry) { throw new NotImplementedException(); }


        public virtual int IndexFromLocation(FlutterBinding.UI.Offset location) { throw new NotImplementedException(); }


        private void _OnTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) { throw new NotImplementedException(); }


        private void _OnDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails details) { throw new NotImplementedException(); }


        private void _OnUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _OnEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        private void _OnCancel() { throw new NotImplementedException(); }


        private void _PlayThumbScaleAnimation(bool isExpanding = default(bool)) { throw new NotImplementedException(); }


        private bool _HasDraggedTooFar(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }
        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _PaintSeparator(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        private void _PaintChild(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, int childIndex) { throw new NotImplementedException(); }


        private void _PaintThumb(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect thumbRect) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }

        #endregion
    }

}
