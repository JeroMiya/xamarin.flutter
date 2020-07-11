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
namespace FlutterSDK.Cupertino.Segmentedcontrol
{
    public delegate FlutterSDK.Rendering.Box.RenderBox _NextChild(FlutterSDK.Rendering.Box.RenderBox child);
    internal static class SegmentedcontrolDefaultClass
    {
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _KHorizontalItemPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry);
        public static double _KMinSegmentedControlHeight = default(double);
        public static TimeSpan _KFadeDuration = default(TimeSpan);
    }

    /// <Summary>
    /// An iOS-style segmented control.
    ///
    /// Displays the widgets provided in the [Map] of [children] in a
    /// horizontal list. Used to select between a number of mutually exclusive
    /// options. When one option in the segmented control is selected, the other
    /// options in the segmented control cease to be selected.
    ///
    /// A segmented control can feature any [Widget] as one of the values in its
    /// [Map] of [children]. The type T is the type of the keys used
    /// to identify each widget and determine which widget is selected. As
    /// required by the [Map] class, keys must be of consistent types
    /// and must be comparable. The ordering of the keys will determine the order
    /// of the widgets in the segmented control.
    ///
    /// When the state of the segmented control changes, the widget calls the
    /// [onValueChanged] callback. The map key associated with the newly selected
    /// widget is returned in the [onValueChanged] callback. Typically, widgets
    /// that use a segmented control will listen for the [onValueChanged] callback
    /// and rebuild the segmented control with a new [groupValue] to update which
    /// option is currently selected.
    ///
    /// The [children] will be displayed in the order of the keys in the [Map].
    /// The height of the segmented control is determined by the height of the
    /// tallest widget provided as a value in the [Map] of [children].
    /// The width of each child in the segmented control will be equal to the width
    /// of widest child, unless the combined width of the children is wider than
    /// the available horizontal space. In this case, the available horizontal space
    /// is divided by the number of provided [children] to determine the width of
    /// each widget. The selection area for each of the widgets in the [Map] of
    /// [children] will then be expanded to fill the calculated space, so each
    /// widget will appear to have the same dimensions.
    ///
    /// A segmented control may optionally be created with custom colors. The
    /// [unselectedColor], [selectedColor], [borderColor], and [pressedColor]
    /// arguments can be used to override the segmented control's colors from
    /// [CupertinoTheme] defaults.
    ///
    /// See also:
    ///
    ///  * [CupertinoSegmentedControl], a segmented control widget in the style used
    ///    up until iOS 13.
    ///  * <https://developer.apple.com/design/human-interface-guidelines/ios/controls/segmented-controls/>
    /// </Summary>
    public class CupertinoSegmentedControl<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoSegmentedControl(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Dictionary<T, FlutterSDK.Widgets.Framework.Widget> children = default(Dictionary<T, FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onValueChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), T groupValue = default(T), FlutterBinding.UI.Color unselectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color pressedColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry))
        : base(key: key)
        {
            this.Children = children;
            this.OnValueChanged = onValueChanged;
            this.GroupValue = groupValue;
            this.UnselectedColor = unselectedColor;
            this.SelectedColor = selectedColor;
            this.BorderColor = borderColor;
            this.PressedColor = pressedColor;
            this.Padding = padding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<T, FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual T GroupValue { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnValueChanged { get; set; }
        public virtual FlutterBinding.UI.Color UnselectedColor { get; set; }
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }
        public virtual FlutterBinding.UI.Color PressedColor { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        #endregion

        #region methods

        public new _SegmentedControlState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _SegmentedControlState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Segmentedcontrol.CupertinoSegmentedControl<T>>, ITickerProviderStateMixin<FlutterSDK.Cupertino.Segmentedcontrol.CupertinoSegmentedControl<T>>
    {
        #region constructors
        public _SegmentedControlState()
        { }
        #endregion

        #region fields
        internal virtual T _PressedKey { get; set; }
        internal virtual List<FlutterSDK.Animation.Animationcontroller.AnimationController> _SelectionControllers { get; set; }
        internal virtual List<FlutterSDK.Animation.Tween.ColorTween> _ChildTweens { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _ForwardBackgroundColorTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _ReverseBackgroundColorTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _TextColorTween { get; set; }
        internal virtual FlutterBinding.UI.Color _SelectedColor { get; set; }
        internal virtual FlutterBinding.UI.Color _UnselectedColor { get; set; }
        internal virtual FlutterBinding.UI.Color _BorderColor { get; set; }
        internal virtual FlutterBinding.UI.Color _PressedColor { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController() { throw new NotImplementedException(); }


        private bool _UpdateColors() { throw new NotImplementedException(); }


        private void _UpdateAnimationControllers() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Cupertino.Segmentedcontrol.CupertinoSegmentedControl<T> oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _OnTapDown(T currentKey) { throw new NotImplementedException(); }


        private void _OnTapCancel() { throw new NotImplementedException(); }


        private void _OnTap(T currentKey) { throw new NotImplementedException(); }


        public virtual Color GetTextColor(int index, T currentKey) { throw new NotImplementedException(); }


        public virtual Color GetBackgroundColor(int index, T currentKey) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SegmentedControlRenderWidget<T> : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public _SegmentedControlRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int selectedIndex = default(int), int pressedIndex = default(int), List<Color> backgroundColors = default(List<Color>), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color))
        : base(key: key, children: children)
        {
            this.SelectedIndex = selectedIndex;
            this.PressedIndex = pressedIndex;
            this.BackgroundColors = backgroundColors;
            this.BorderColor = borderColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int SelectedIndex { get; set; }
        public virtual int PressedIndex { get; set; }
        public virtual List<Color> BackgroundColors { get; set; }
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Segmentedcontrol._RenderSegmentedControl<T> renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SegmentedControlContainerBoxParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        #region constructors
        public _SegmentedControlContainerBoxParentData()
        { }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.RRect SurroundingRect { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _RenderSegmentedControl<T> : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>
    {
        #region constructors
        public _RenderSegmentedControl(int selectedIndex = default(int), int pressedIndex = default(int), TextDirection textDirection = default(TextDirection), List<Color> backgroundColors = default(List<Color>), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual int _SelectedIndex { get; set; }
        internal virtual int _PressedIndex { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual List<Color> _BackgroundColors { get; set; }
        internal virtual FlutterBinding.UI.Color _BorderColor { get; set; }
        public virtual int SelectedIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int PressedIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<Color> BackgroundColors { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BorderColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }
        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        private void _LayoutRects(FlutterSDK.Cupertino.Segmentedcontrol._NextChild nextChild, FlutterSDK.Rendering.Box.RenderBox leftChild, FlutterSDK.Rendering.Box.RenderBox rightChild) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _PaintChild(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, int childIndex) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }

        #endregion
    }

}
