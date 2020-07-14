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
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    public new FontWeight Lerp(double t) => Dart:uiDefaultClass.FontWeight.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An iOS 13 style segmented control.
///
/// Displays the widgets provided in the [Map] of [children] in a horizontal list.
/// Used to select between a number of mutually exclusive options. When one option
/// in the segmented control is selected, the other options in the segmented
/// control cease to be selected.
///
/// A segmented control can feature any [Widget] as one of the values in its
/// [Map] of [children]. The type T is the type of the [Map] keys used to identify
/// each widget and determine which widget is selected. As required by the [Map]
/// class, keys must be of consistent types and must be comparable. The [children]
/// argument must be an ordered [Map] such as a [LinkedHashMap], the ordering of
/// the keys will determine the order of the widgets in the segmented control.
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
/// [thumbColor], [backgroundColor] arguments can be used to override the segmented
/// control's colors from its defaults.
///
/// See also:
///
///  * [CupertinoSlidingSegmentedControl], a segmented control widget in the
///    style introduced in iOS 13.
///  * <https://developer.apple.com/design/human-interface-guidelines/ios/controls/segmented-controls/>
/// </Summary>
public class CupertinoSlidingSegmentedControl<T> : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public CupertinoSlidingSegmentedControl(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Dictionary<T, FlutterSDK.Widgets.Framework.Widget> children = default(Dictionary<T, FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onValueChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), T groupValue = default(T), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color))
    : base(key: key)

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

public new _SegmentedControlState<T> CreateState() => new _SegmentedControlState<T>();


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

    private FlutterSDK.Animation.Animationcontroller.AnimationController _CreateHighlightAnimationController(bool isCompleted = false)
    {
        return new AnimationController(duration: SlidingsegmentedcontrolDefaultClass._KHighlightAnimationDuration, value: isCompleted ? 1 : 0, vsync: this);
    }




    private FlutterSDK.Animation.Animationcontroller.AnimationController _CreateFadeoutAnimationController()
    {
        return new AnimationController(duration: SlidingsegmentedcontrolDefaultClass._KOpacityAnimationDuration, vsync: this);
    }




    public new void InitState()
    {
        base.InitState();
        GestureArenaTeam team = new GestureArenaTeam();
        LongPress.Team = team;
        Drag.Team = team;
        team.Captain = Drag;
        _Highlighted = Widget.GroupValue;
        ThumbController = new AnimationController(duration: SlidingsegmentedcontrolDefaultClass._KSpringAnimationDuration, value: 0, vsync: this);
        ThumbScaleController = new AnimationController(duration: SlidingsegmentedcontrolDefaultClass._KSpringAnimationDuration, value: 1, vsync: this);
        SeparatorOpacityController = new AnimationController(duration: SlidingsegmentedcontrolDefaultClass._KSpringAnimationDuration, value: 0, vsync: this);
        foreach (T currentKey in Widget.Children.Keys)
        {
            _HighlightControllers[currentKey] = _CreateHighlightAnimationController(isCompleted: currentKey == Widget.GroupValue);
            _PressControllers[currentKey] = _CreateFadeoutAnimationController();
        }

    }




    public new void DidUpdateWidget(FlutterSDK.Cupertino.Slidingsegmentedcontrol.CupertinoSlidingSegmentedControl<T> oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        foreach (T oldKey in oldWidget.Children.Keys)
        {
            if (!Widget.Children.ContainsKey(oldKey))
            {
                _HighlightControllers[oldKey].Dispose();
                _PressControllers[oldKey].Dispose();
                _HighlightControllers.Remove(oldKey);
                _PressControllers.Remove(oldKey);
            }

        }

        foreach (T newKey in Widget.Children.Keys)
        {
            if (!_HighlightControllers.Keys.Contains(newKey))
            {
                _HighlightControllers[newKey] = _CreateHighlightAnimationController();
                _PressControllers[newKey] = _CreateFadeoutAnimationController();
            }

        }

        Highlighted = Widget.GroupValue;
    }




    public new void Dispose()
    {
        foreach (AnimationController animationController in _HighlightControllers.Values)
        {
            animationController.Dispose();
        }

        foreach (AnimationController animationController in _PressControllers.Values)
        {
            animationController.Dispose();
        }

        ThumbScaleController.Dispose();
        ThumbController.Dispose();
        SeparatorOpacityController.Dispose();
        Drag.Dispose();
        Tap.Dispose();
        LongPress.Dispose();
        base.Dispose();
    }




    private void _AnimateHighlightController(T at = default(T), bool forward = default(bool))
    {
        if (at == null) return;
        AnimationController controller = _HighlightControllers[at];

        controller?.AnimateTo(forward ? 1 : 0, duration: SlidingsegmentedcontrolDefaultClass._KHighlightAnimationDuration, curve: CurvesDefaultClass.Curves.Ease);
    }




    public virtual void DidChangeSelectedViaGesture()
    {
        Widget.OnValueChanged(_Highlighted);
    }




    public virtual T IndexToKey(int index) => index == null ? null : Keys[index];



    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        DebugDefaultClass.DebugCheckHasDirectionality(context);
        switch (BasicDefaultClass.Directionality.Of(context)) { case TextDirection.Ltr: Keys = Widget.Children.Keys.ToList(growable: false); break; case TextDirection.Rtl: Keys = Widget.Children.Keys.ToList().Reversed.ToList(growable: false); break; }
        return new AnimatedBuilder(animation: Listenable.Merge(new List<Listenable>() {, _HighlightControllers.Values, , _PressControllers.Values }), builder: (BuildContext context, Widget child) =>
        {
            List<Widget> children = new List<Widget>() { };
            foreach (T currentKey in Keys)
            {
                TextStyle textStyle = TextDefaultClass.DefaultTextStyle.Of(context).Style.CopyWith(fontWeight: _HighlightTween.Evaluate(_HighlightControllers[currentKey]));
                Widget child = new DefaultTextStyle(style: textStyle, child: new Semantics(button: true, onTap: () =>
                {
                    Widget.OnValueChanged(currentKey);
                }
                , inMutuallyExclusiveGroup: true, selected: Widget.GroupValue == currentKey, child: new Opacity(opacity: _PressTween.Evaluate(_PressControllers[currentKey]), child: new MetaData(behavior: HitTestBehavior.Opaque, child: new Center(child: Widget.Children[currentKey])))));
                children.Add(child);
            }

            int selectedIndex = Widget.GroupValue == null ? null : Keys.IndexOf(Widget.GroupValue);
            Widget box = new _SegmentedControlRenderWidget<T>(children: children, selectedIndex: selectedIndex, thumbColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.ThumbColor, context), state: this);
            return new UnconstrainedBox(constrainedAxis: Axis.Horizontal, child: new Container(padding: Widget.Padding.Resolve(BasicDefaultClass.Directionality.Of(context)), decoration: new BoxDecoration(borderRadius: BorderRadius.All(Radius.Circular(SlidingsegmentedcontrolDefaultClass._KCornerRadius)), color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context)), child: box));
        }
        );
    }



    #endregion
}


public class _SegmentedControlRenderWidget<T> : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
{
    #region constructors
    public _SegmentedControlRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int selectedIndex = default(int), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> state = default(FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T>))
    : base(key: key, children: children)

}
#endregion

#region fields
public virtual int SelectedIndex { get; set; }
public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
public virtual FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> State { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderSegmentedControl<T>(selectedIndex: SelectedIndex, thumbColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context), state: State);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Slidingsegmentedcontrol._RenderSegmentedControl<T> renderObject)
{
    ..ThumbColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context);
    renderObject.GuardedSetHighlightedIndex(SelectedIndex);
}



#endregion
}


public class _ChildAnimationManifest
{
    #region constructors
    public _ChildAnimationManifest(double opacity = 1, double separatorOpacity = default(double))
    : base()

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


/// <Summary>
///   corresponding tap up event inverts the process (eyeballed).
/// </Summary>
public class _RenderSegmentedControl<T> : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>
{
    #region constructors
    public _RenderSegmentedControl(int selectedIndex = default(int), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T> state = default(FlutterSDK.Cupertino.Slidingsegmentedcontrol._SegmentedControlState<T>))
    : base()

State.Drag..OnDown=_OnDown..OnUpdate=_OnUpdate..OnEnd=_OnEnd..OnCancel=_OnCancel;
State.Tap.OnTapUp=_OnTapUp;
State.LongPress.OnLongPress=() => {
}
;
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

public new void Insert(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox))
{
    base.Insert(child, after: after);
    if (_ChildAnimations == null) return;

    _ChildAnimations[child] = new _ChildAnimationManifest(separatorOpacity: 1);
}




public new void Remove(FlutterSDK.Rendering.Box.RenderBox child)
{
    base.Remove(child);
    _ChildAnimations?.Remove(child);
}




public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    State.ThumbController.AddListener(MarkNeedsPaint);
    State.ThumbScaleController.AddListener(MarkNeedsPaint);
    State.SeparatorOpacityController.AddListener(MarkNeedsPaint);
}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    State.ThumbController.AddListener(MarkNeedsPaint);
    State.ThumbScaleController.AddListener(MarkNeedsPaint);
    State.SeparatorOpacityController.AddListener(MarkNeedsPaint);
}




public new void Detach()
{
    State.ThumbController.RemoveListener(MarkNeedsPaint);
    State.ThumbScaleController.RemoveListener(MarkNeedsPaint);
    State.SeparatorOpacityController.RemoveListener(MarkNeedsPaint);
    base.Detach();
}




public virtual void GuardedSetHighlightedIndex(int value)
{
    if (_StartedOnSelectedSegment == true) return;
    HighlightedIndex = value;
}




public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
{

    if (@event is PointerDownEvent)
    {
        State.Tap.AddPointer(((PointerDownEvent)@event));
        State.LongPress.AddPointer(((PointerDownEvent)@event));
        State.Drag.AddPointer(((PointerDownEvent)@event));
    }

}




public virtual int IndexFromLocation(FlutterBinding.UI.Offset location)
{
    return ChildCount == 0 ? null : ((location.Dx / (Size.Width / ChildCount)).Floor().Clamp(0, ChildCount - 1) as int);
}




private void _OnTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
{
    HighlightedIndex = IndexFromLocation(details.LocalPosition);
    State.DidChangeSelectedViaGesture();
}




private void _OnDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails details)
{

    _LocalDragOffset = details.LocalPosition;
    int index = IndexFromLocation(_LocalDragOffset);
    _StartedOnSelectedSegment = index == HighlightedIndex;
    PressedIndex = index;
    if (_StartedOnSelectedSegment)
    {
        _PlayThumbScaleAnimation(isExpanding: false);
    }

}




private void _OnUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
{
    _LocalDragOffset = details.LocalPosition;
    int newIndex = IndexFromLocation(_LocalDragOffset);
    if (_StartedOnSelectedSegment)
    {
        HighlightedIndex = newIndex;
        PressedIndex = newIndex;
    }
    else
    {
        PressedIndex = _HasDraggedTooFar(details) ? null : newIndex;
    }

}




private void _OnEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
{
    if (_StartedOnSelectedSegment)
    {
        _PlayThumbScaleAnimation(isExpanding: true);
        State.DidChangeSelectedViaGesture();
    }

    if (PressedIndex != null)
    {
        HighlightedIndex = PressedIndex;
        State.DidChangeSelectedViaGesture();
    }

    PressedIndex = null;
    _LocalDragOffset = null;
    _StartedOnSelectedSegment = null;
}




private void _OnCancel()
{
    if (_StartedOnSelectedSegment)
    {
        _PlayThumbScaleAnimation(isExpanding: true);
    }

    _LocalDragOffset = null;
    PressedIndex = null;
    _StartedOnSelectedSegment = null;
}




private void _PlayThumbScaleAnimation(bool isExpanding = default(bool))
{

    _ThumbScaleTween = new Tween<double>(begin: CurrentThumbScale, end: isExpanding ? 1 : SlidingsegmentedcontrolDefaultClass._KMinThumbScale);
    State.ThumbScaleController.AnimateWith(SlidingsegmentedcontrolDefaultClass._KThumbSpringAnimationSimulation);
}




private bool _HasDraggedTooFar(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
{
    Offset offCenter = details.LocalPosition - new Offset(Size.Width / 2, Size.Height / 2);
    return Math.Dart:mathDefaultClass.Pow(Math.Dart:mathDefaultClass.Max(0, offCenter.Dx.Abs() - Size.Width / 2), 2) + Math.Dart:mathDefaultClass.Pow(Math.Dart:mathDefaultClass.Max(0, offCenter.Dy.Abs() - Size.Height / 2), 2) > SlidingsegmentedcontrolDefaultClass._KTouchYDistanceThreshold;
}




public new double ComputeMinIntrinsicWidth(double height)
{
    RenderBox child = FirstChild;
    double maxMinChildWidth = 0;
    while (child != null)
    {
        _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
        double childWidth = child.GetMinIntrinsicWidth(height);
        maxMinChildWidth = Math.Dart:mathDefaultClass.Max(maxMinChildWidth, childWidth);
        child = childParentData.NextSibling;
    }

    return (maxMinChildWidth + 2 * SlidingsegmentedcontrolDefaultClass._KSegmentMinPadding) * ChildCount + TotalSeparatorWidth;
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    RenderBox child = FirstChild;
    double maxMaxChildWidth = 0;
    while (child != null)
    {
        _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
        double childWidth = child.GetMaxIntrinsicWidth(height);
        maxMaxChildWidth = Math.Dart:mathDefaultClass.Max(maxMaxChildWidth, childWidth);
        child = childParentData.NextSibling;
    }

    return (maxMaxChildWidth + 2 * SlidingsegmentedcontrolDefaultClass._KSegmentMinPadding) * ChildCount + TotalSeparatorWidth;
}




public new double ComputeMinIntrinsicHeight(double width)
{
    RenderBox child = FirstChild;
    double maxMinChildHeight = 0;
    while (child != null)
    {
        _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
        double childHeight = child.GetMinIntrinsicHeight(width);
        maxMinChildHeight = Math.Dart:mathDefaultClass.Max(maxMinChildHeight, childHeight);
        child = childParentData.NextSibling;
    }

    return maxMinChildHeight;
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    RenderBox child = FirstChild;
    double maxMaxChildHeight = 0;
    while (child != null)
    {
        _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
        double childHeight = child.GetMaxIntrinsicHeight(width);
        maxMaxChildHeight = Math.Dart:mathDefaultClass.Max(maxMaxChildHeight, childHeight);
        child = childParentData.NextSibling;
    }

    return maxMaxChildHeight;
}




public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
{
    return DefaultComputeDistanceToHighestActualBaseline(baseline);
}




public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
{
    if (!(child.ParentData is _SegmentedControlContainerBoxParentData))
    {
        ((_SegmentedControlContainerBoxParentData)child.ParentData) = new _SegmentedControlContainerBoxParentData();
    }

}


public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
{
    if (!(child.ParentData is _SegmentedControlContainerBoxParentData))
    {
        ((_SegmentedControlContainerBoxParentData)child.ParentData) = new _SegmentedControlContainerBoxParentData();
    }

}




public new void PerformLayout()
{
    BoxConstraints constraints = this.Constraints;
    double childWidth = (constraints.MinWidth - TotalSeparatorWidth) / ChildCount;
    double maxHeight = SlidingsegmentedcontrolDefaultClass._KMinSegmentedControlHeight;
    foreach (RenderBox child in GetChildrenAsList())
    {
        childWidth = Math.Dart:mathDefaultClass.Max(childWidth, child.GetMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity) + 2 * SlidingsegmentedcontrolDefaultClass._KSegmentMinPadding);
    }

    childWidth = Math.Dart:mathDefaultClass.Min(childWidth, (constraints.MaxWidth - TotalSeparatorWidth) / ChildCount);
    RenderBox child = FirstChild;
    while (child != null)
    {
        double boxHeight = child.GetMaxIntrinsicHeight(childWidth);
        maxHeight = Math.Dart:mathDefaultClass.Max(maxHeight, boxHeight);
        child = ChildAfter(child);
    }

    constraints.ConstrainHeight(maxHeight);
    BoxConstraints childConstraints = BoxConstraints.TightFor(width: childWidth, height: maxHeight);
    child = FirstChild;
    while (child != null)
    {
        child.Layout(childConstraints, parentUsesSize: true);
        child = ChildAfter(child);
    }

    double start = 0;
    child = FirstChild;
    while (child != null)
    {
        _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
        Offset childOffset = new Offset(start, 0);
        childParentData.Offset = childOffset;
        start += child.Size.Width + SlidingsegmentedcontrolDefaultClass._KSeparatorWidth + SlidingsegmentedcontrolDefaultClass._KSeparatorInset.Horizontal;
        child = ChildAfter(child);
    }

    Size = constraints.Constrain(new Size(childWidth * ChildCount + TotalSeparatorWidth, maxHeight));
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    List<RenderBox> children = GetChildrenAsList();
    if (HighlightedIndex != null)
    {
        if (_ChildAnimations == null)
        {
            _ChildAnimations = new Dictionary<RenderBox, _ChildAnimationManifest> { };
            for (int i = 0; i < ChildCount - 1; i += 1)
            {
                bool shouldFadeOut = i == HighlightedIndex || i == HighlightedIndex - 1;
                RenderBox child = children[i];
                _ChildAnimations[child] = new _ChildAnimationManifest(separatorOpacity: shouldFadeOut ? 0 : 1);
            }

        }

        RenderBox selectedChild = children[HighlightedIndex];
        _SegmentedControlContainerBoxParentData childParentData = selectedChild.ParentData as _SegmentedControlContainerBoxParentData;
        Rect unscaledThumbTargetRect = SlidingsegmentedcontrolDefaultClass._KThumbInsets.InflateRect(childParentData.Offset & selectedChild.Size);
        if (_NeedsThumbAnimationUpdate)
        {
            _CurrentThumbTween = new RectTween(begin: CurrentThumbRect ?? unscaledThumbTargetRect, end: unscaledThumbTargetRect);
            for (int i = 0; i < ChildCount - 1; i += 1)
            {
                bool shouldFadeOut = i == HighlightedIndex || i == HighlightedIndex - 1;
                RenderBox child = children[i];
                _ChildAnimationManifest manifest = _ChildAnimations[child];

                manifest.SeparatorTween = new Tween<double>(begin: manifest.SeparatorOpacity, end: shouldFadeOut ? 0 : 1);
            }

            _NeedsThumbAnimationUpdate = false;
        }
        else if (_CurrentThumbTween != null && unscaledThumbTargetRect != _CurrentThumbTween.Begin)
        {
            _CurrentThumbTween = new RectTween(begin: _CurrentThumbTween.Begin, end: unscaledThumbTargetRect);
        }

        for (int index = 0; index < ChildCount - 1; index += 1)
        {
            _PaintSeparator(context, offset, children[index]);
        }

        CurrentThumbRect = _CurrentThumbTween?.Evaluate(State.ThumbController) ?? unscaledThumbTargetRect;
        CurrentThumbScale = _ThumbScaleTween.Evaluate(State.ThumbScaleController);
        Rect thumbRect = Rect.FromCenter(center: CurrentThumbRect.Center, width: CurrentThumbRect.Width * CurrentThumbScale, height: CurrentThumbRect.Height * CurrentThumbScale);
        _PaintThumb(context, offset, thumbRect);
    }
    else
    {
        CurrentThumbRect = null;
        _ChildAnimations = null;
        for (int index = 0; index < ChildCount - 1; index += 1)
        {
            _PaintSeparator(context, offset, children[index]);
        }

    }

    for (int index = 0; index < children.Count; index++)
    {
        _PaintChild(context, offset, children[index], index);
    }

}




private void _PaintSeparator(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child)
{

    _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
    Paint paint = new Paint();
    _ChildAnimationManifest manifest = _ChildAnimations == null ? null : _ChildAnimations[child];
    double opacity = manifest?.SeparatorTween?.Evaluate(State.SeparatorOpacityController) ?? 1;
    manifest?.SeparatorOpacity = opacity;
    paint.Color = SlidingsegmentedcontrolDefaultClass._KSeparatorColor.WithOpacity(SlidingsegmentedcontrolDefaultClass._KSeparatorColor.Opacity * opacity);
    Rect childRect = (childParentData.Offset + offset) & child.Size;
    Rect separatorRect = SlidingsegmentedcontrolDefaultClass._KSeparatorInset.DeflateRect(childRect.TopRight & new Size(SlidingsegmentedcontrolDefaultClass._KSeparatorInset.Horizontal + SlidingsegmentedcontrolDefaultClass._KSeparatorWidth, child.Size.Height));
    context.Canvas.DrawRRect(RRect.FromRectAndRadius(separatorRect, SlidingsegmentedcontrolDefaultClass._KSeparatorRadius), paint);
}




private void _PaintChild(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, int childIndex)
{

    _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
    context.PaintChild(child, childParentData.Offset + offset);
}




private void _PaintThumb(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect thumbRect)
{
    List<BoxShadow> thumbShadow = new List<BoxShadow>() { new BoxShadow(color: new Color(0x1F000000), offset: new Offset(0, 3), blurRadius: 8), new BoxShadow(color: new Color(0x0A000000), offset: new Offset(0, 3), blurRadius: 1) };
    RRect thumbRRect = RRect.FromRectAndRadius(thumbRect.Shift(offset), SlidingsegmentedcontrolDefaultClass._KThumbRadius);
    foreach (BoxShadow shadow in thumbShadow)
    {
        context.Canvas.DrawRRect(thumbRRect.Shift(shadow.Offset), shadow.ToPaint());
    }

    context.Canvas.DrawRRect(thumbRRect.Inflate(0.5), new Paint()..Color = new Color(0x0A000000));
    context.Canvas.DrawRRect(thumbRRect, new Paint()..Color = ThumbColor);
}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{

    RenderBox child = LastChild;
    while (child != null)
    {
        _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
        if ((childParentData.Offset & child.Size).Contains(position))
        {
            Offset center = (Dart: uiDefaultClass.Offset.Zero & child.Size).Center;
            return result.AddWithRawTransform(transform: MatrixutilsDefaultClass.MatrixUtils.ForceToPoint(center), position: center, hitTest: (BoxHitTestResult result, Offset position) =>
            {

                return child.HitTest(result, position: center);
            }
            );
        }

        child = childParentData.PreviousSibling;
    }

    return false;
}



#endregion
}

}
