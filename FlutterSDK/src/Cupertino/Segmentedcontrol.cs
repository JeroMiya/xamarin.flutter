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
        /// <Summary>
        /// Creates an iOS-style segmented control bar.
        ///
        /// The [children] and [onValueChanged] arguments must not be null. The
        /// [children] argument must be an ordered [Map] such as a [LinkedHashMap].
        /// Further, the length of the [children] list must be greater than one.
        ///
        /// Each widget value in the map of [children] must have an associated key
        /// that uniquely identifies this widget. This key is what will be returned
        /// in the [onValueChanged] callback when a new value from the [children] map
        /// is selected.
        ///
        /// The [groupValue] is the currently selected value for the segmented control.
        /// If no [groupValue] is provided, or the [groupValue] is null, no widget will
        /// appear as selected. The [groupValue] must be either null or one of the keys
        /// in the [children] map.
        /// </Summary>
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
            this.Padding = padding;
        }
        /// <Summary>
        /// The identifying keys and corresponding widget values in the
        /// segmented control.
        ///
        /// The map must have more than one entry.
        /// This attribute must be an ordered [Map] such as a [LinkedHashMap].
        /// </Summary>
        public virtual Dictionary<T, FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        /// <Summary>
        /// The identifier of the widget that is currently selected.
        ///
        /// This must be one of the keys in the [Map] of [children].
        /// If this attribute is null, no widget will be initially selected.
        /// </Summary>
        public virtual T GroupValue { get; set; }
        /// <Summary>
        /// The callback that is called when a new option is tapped.
        ///
        /// This attribute must not be null.
        ///
        /// The segmented control passes the newly selected widget's associated key
        /// to the callback but does not actually change state until the parent
        /// widget rebuilds the segmented control with the new [groupValue].
        ///
        /// The callback provided to [onValueChanged] should update the state of
        /// the parent [StatefulWidget] using the [State.setState] method, so that
        /// the parent gets rebuilt; for example:
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// class SegmentedControlExample extends StatefulWidget {
        ///   @override
        ///   State createState() => SegmentedControlExampleState();
        /// }
        ///
        /// class SegmentedControlExampleState extends State<SegmentedControlExample> {
        ///   final Map<int, Widget> children = const {
        ///     0: Text('Child 1'),
        ///     1: Text('Child 2'),
        ///   };
        ///
        ///   int currentValue;
        ///
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return Container(
        ///       child: CupertinoSegmentedControl<int>(
        ///         children: children,
        ///         onValueChanged: (int newValue) {
        ///           setState(() {
        ///             currentValue = newValue;
        ///           });
        ///         },
        ///         groupValue: currentValue,
        ///       ),
        ///     );
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnValueChanged { get; set; }
        /// <Summary>
        /// The color used to fill the backgrounds of unselected widgets and as the
        /// text color of the selected widget.
        ///
        /// Defaults to [CupertinoTheme]'s `primaryContrastingColor` if null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color UnselectedColor { get; set; }
        /// <Summary>
        /// The color used to fill the background of the selected widget and as the text
        /// color of unselected widgets.
        ///
        /// Defaults to [CupertinoTheme]'s `primaryColor` if null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        /// <Summary>
        /// The color used as the border around each widget.
        ///
        /// Defaults to [CupertinoTheme]'s `primaryColor` if null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }
        /// <Summary>
        /// The color used to fill the background of the widget the user is
        /// temporarily interacting with through a long press or drag.
        ///
        /// Defaults to the selectedColor at 20% opacity if null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color PressedColor { get; set; }
        /// <Summary>
        /// The CupertinoSegmentedControl will be placed inside this padding
        ///
        /// Defaults to EdgeInsets.symmetric(horizontal: 16.0)
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }

        public new _SegmentedControlState<T> CreateState() => new _SegmentedControlState<T>();


    }


    public class _SegmentedControlState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Segmentedcontrol.CupertinoSegmentedControl<T>>, ITickerProviderStateMixin<FlutterSDK.Cupertino.Segmentedcontrol.CupertinoSegmentedControl<T>>
    {
        public _SegmentedControlState()
        { }
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

        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController()
        {
            return new AnimationController(duration: SegmentedcontrolDefaultClass._KFadeDuration, vsync: this);
            new AnimationController(duration: SegmentedcontrolDefaultClass._KFadeDuration, vsync: this).AddListener(() =>
            {
                SetState(() =>
                {
                }
                );
            }
            );
        }




        private bool _UpdateColors()
        {

            bool changed = false;
            Color selectedColor = Widget.SelectedColor ?? ThemeDefaultClass.CupertinoTheme.Of(Context).PrimaryColor;
            if (_SelectedColor != selectedColor)
            {
                changed = true;
                _SelectedColor = selectedColor;
            }

            Color unselectedColor = Widget.UnselectedColor ?? ThemeDefaultClass.CupertinoTheme.Of(Context).PrimaryContrastingColor;
            if (_UnselectedColor != unselectedColor)
            {
                changed = true;
                _UnselectedColor = unselectedColor;
            }

            Color borderColor = Widget.BorderColor ?? ThemeDefaultClass.CupertinoTheme.Of(Context).PrimaryColor;
            if (_BorderColor != borderColor)
            {
                changed = true;
                _BorderColor = borderColor;
            }

            Color pressedColor = Widget.PressedColor ?? ThemeDefaultClass.CupertinoTheme.Of(Context).PrimaryColor.WithOpacity(0.2);
            if (_PressedColor != pressedColor)
            {
                changed = true;
                _PressedColor = pressedColor;
            }

            _ForwardBackgroundColorTween = new ColorTween(begin: _PressedColor, end: _SelectedColor);
            _ReverseBackgroundColorTween = new ColorTween(begin: _UnselectedColor, end: _SelectedColor);
            _TextColorTween = new ColorTween(begin: _SelectedColor, end: _UnselectedColor);
            return changed;
        }




        private void _UpdateAnimationControllers()
        {

            foreach (AnimationController controller in _SelectionControllers)
            {
                controller.Dispose();
            }

            _SelectionControllers.Clear();
            _ChildTweens.Clear();
            foreach (T key in Widget.Children.Keys)
            {
                AnimationController animationController = CreateAnimationController();
                if (Widget.GroupValue == key)
                {
                    _ChildTweens.Add(_ReverseBackgroundColorTween);
                    animationController.Value = 1.0;
                }
                else
                {
                    _ChildTweens.Add(_ForwardBackgroundColorTween);
                }

                _SelectionControllers.Add(animationController);
            }

        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            if (_UpdateColors())
            {
                _UpdateAnimationControllers();
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Segmentedcontrol.CupertinoSegmentedControl<T> oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (_UpdateColors() || oldWidget.Children.Length != Widget.Children.Length)
            {
                _UpdateAnimationControllers();
            }

            if (oldWidget.GroupValue != Widget.GroupValue)
            {
                int index = 0;
                foreach (T key in Widget.Children.Keys)
                {
                    if (Widget.GroupValue == key)
                    {
                        _ChildTweens[index] = _ForwardBackgroundColorTween;
                        _SelectionControllers[index].Forward();
                    }
                    else
                    {
                        _ChildTweens[index] = _ReverseBackgroundColorTween;
                        _SelectionControllers[index].Reverse();
                    }

                    index += 1;
                }

            }

        }




        public new void Dispose()
        {
            foreach (AnimationController animationController in _SelectionControllers)
            {
                animationController.Dispose();
            }

            base.Dispose();
        }




        private void _OnTapDown(T currentKey)
        {
            if (_PressedKey == null && currentKey != Widget.GroupValue)
            {
                SetState(() =>
                {
                    _PressedKey = currentKey;
                }
                );
            }

        }




        private void _OnTapCancel()
        {
            SetState(() =>
            {
                _PressedKey = null;
            }
            );
        }




        private void _OnTap(T currentKey)
        {
            if (currentKey != _PressedKey) return;
            if (currentKey != Widget.GroupValue)
            {
                Widget.OnValueChanged(currentKey);
            }

            _PressedKey = null;
        }




        public virtual Color GetTextColor(int index, T currentKey)
        {
            if (_SelectionControllers[index].IsAnimating) return _TextColorTween.Evaluate(_SelectionControllers[index]);
            if (Widget.GroupValue == currentKey) return _UnselectedColor;
            return _SelectedColor;
        }




        public virtual Color GetBackgroundColor(int index, T currentKey)
        {
            if (_SelectionControllers[index].IsAnimating) return _ChildTweens[index].Evaluate(_SelectionControllers[index]);
            if (Widget.GroupValue == currentKey) return _SelectedColor;
            if (_PressedKey == currentKey) return _PressedColor;
            return _UnselectedColor;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> _gestureChildren = new List<Widget>() { };
            List<Color> _backgroundColors = new List<Color>() { };
            int index = 0;
            int selectedIndex = default(int);
            int pressedIndex = default(int);
            foreach (T currentKey in Widget.Children.Keys)
            {
                selectedIndex = (Widget.GroupValue == currentKey) ? index : selectedIndex;
                pressedIndex = (_PressedKey == currentKey) ? index : pressedIndex;
                TextStyle textStyle = TextDefaultClass.DefaultTextStyle.Of(context).Style.CopyWith(color: GetTextColor(index, currentKey));
                IconThemeData iconTheme = new IconThemeData(color: GetTextColor(index, currentKey));
                Widget child = new Center(child: Widget.Children[currentKey]);
                child = new GestureDetector(behavior: HitTestBehavior.Opaque, onTapDown: (TapDownDetails @event) =>
                {
                    _OnTapDown(currentKey);
                }
                , onTapCancel: _OnTapCancel, onTap: () =>
                {
                    _OnTap(currentKey);
                }
                , child: new IconTheme(data: iconTheme, child: new DefaultTextStyle(style: textStyle, child: new Semantics(button: true, inMutuallyExclusiveGroup: true, selected: Widget.GroupValue == currentKey, child: child))));
                _backgroundColors.Add(GetBackgroundColor(index, currentKey));
                _gestureChildren.Add(child);
                index += 1;
            }

            Widget box = new _SegmentedControlRenderWidget<T>(children: _gestureChildren, selectedIndex: selectedIndex, pressedIndex: pressedIndex, backgroundColors: _backgroundColors, borderColor: _BorderColor);
            return new Padding(padding: Widget.Padding ?? SegmentedcontrolDefaultClass._KHorizontalItemPadding, child: new UnconstrainedBox(constrainedAxis: Axis.Horizontal, child: box));
        }



    }


    public class _SegmentedControlRenderWidget<T> : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        public _SegmentedControlRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int selectedIndex = default(int), int pressedIndex = default(int), List<Color> backgroundColors = default(List<Color>), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color))
        : base(key: key, children: children)
        {
            this.SelectedIndex = selectedIndex;
            this.PressedIndex = pressedIndex;
            this.BackgroundColors = backgroundColors;
            this.BorderColor = borderColor;
        }
        public virtual int SelectedIndex { get; set; }
        public virtual int PressedIndex { get; set; }
        public virtual List<Color> BackgroundColors { get; set; }
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderSegmentedControl<T>(textDirection: BasicDefaultClass.Directionality.Of(context), selectedIndex: SelectedIndex, pressedIndex: PressedIndex, backgroundColors: BackgroundColors, borderColor: BorderColor);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Segmentedcontrol._RenderSegmentedControl<T> renderObject)
        {
            ..TextDirection = BasicDefaultClass.Directionality.Of(context)..SelectedIndex = SelectedIndex..PressedIndex = PressedIndex..BackgroundColors = BackgroundColors..BorderColor = BorderColor;
        }



    }


    public class _SegmentedControlContainerBoxParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        public _SegmentedControlContainerBoxParentData()
        { }
        public virtual FlutterBinding.UI.RRect SurroundingRect { get; set; }
    }


    public class _RenderSegmentedControl<T> : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>>
    {
        public _RenderSegmentedControl(int selectedIndex = default(int), int pressedIndex = default(int), TextDirection textDirection = default(TextDirection), List<Color> backgroundColors = default(List<Color>), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color))
        : base()
        {

        }
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

        public new double ComputeMinIntrinsicWidth(double height)
        {
            RenderBox child = FirstChild;
            double minWidth = 0.0;
            while (child != null)
            {
                _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
                double childWidth = child.GetMinIntrinsicWidth(height);
                minWidth = Dart.Math.MathDefaultClass.Max(minWidth, childWidth);
                child = childParentData.NextSibling;
            }

            return minWidth * ChildCount;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            RenderBox child = FirstChild;
            double maxWidth = 0.0;
            while (child != null)
            {
                _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
                double childWidth = child.GetMaxIntrinsicWidth(height);
                maxWidth = Dart.Math.MathDefaultClass.Max(maxWidth, childWidth);
                child = childParentData.NextSibling;
            }

            return maxWidth * ChildCount;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            RenderBox child = FirstChild;
            double minHeight = 0.0;
            while (child != null)
            {
                _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
                double childHeight = child.GetMinIntrinsicHeight(width);
                minHeight = Dart.Math.MathDefaultClass.Max(minHeight, childHeight);
                child = childParentData.NextSibling;
            }

            return minHeight;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            RenderBox child = FirstChild;
            double maxHeight = 0.0;
            while (child != null)
            {
                _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
                double childHeight = child.GetMaxIntrinsicHeight(width);
                maxHeight = Dart.Math.MathDefaultClass.Max(maxHeight, childHeight);
                child = childParentData.NextSibling;
            }

            return maxHeight;
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




        private void _LayoutRects(FlutterSDK.Cupertino.Segmentedcontrol._NextChild nextChild, FlutterSDK.Rendering.Box.RenderBox leftChild, FlutterSDK.Rendering.Box.RenderBox rightChild)
        {
            RenderBox child = leftChild;
            double start = 0.0;
            while (child != null)
            {
                _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
                Offset childOffset = new Offset(start, 0.0);
                childParentData.Offset = childOffset;
                Rect childRect = Rect.FromLTWH(start, 0.0, child.Size.Width, child.Size.Height);
                RRect rChildRect = default(RRect);
                if (child == leftChild)
                {
                    rChildRect = RRect.FromRectAndCorners(childRect, topLeft: Radius.Circular(3.0), bottomLeft: Radius.Circular(3.0));
                }
                else if (child == rightChild)
                {
                    rChildRect = RRect.FromRectAndCorners(childRect, topRight: Radius.Circular(3.0), bottomRight: Radius.Circular(3.0));
                }
                else
                {
                    rChildRect = RRect.FromRectAndCorners(childRect);
                }

                childParentData.SurroundingRect = rChildRect;
                start += child.Size.Width;
                child = nextChild(child);
            }

        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            double maxHeight = SegmentedcontrolDefaultClass._KMinSegmentedControlHeight;
            double childWidth = constraints.MinWidth / ChildCount;
            foreach (RenderBox child in GetChildrenAsList())
            {
                childWidth = Dart.Math.MathDefaultClass.Max(childWidth, child.GetMaxIntrinsicWidth(Dart.CoreDefaultClass.Double.Infinity));
            }

            childWidth = Dart.Math.MathDefaultClass.Min(childWidth, constraints.MaxWidth / ChildCount);
            RenderBox child = FirstChild;
            while (child != null)
            {
                double boxHeight = child.GetMaxIntrinsicHeight(childWidth);
                maxHeight = Dart.Math.MathDefaultClass.Max(maxHeight, boxHeight);
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

            switch (TextDirection) { case TextDirection.Rtl: _LayoutRects(ChildBefore, LastChild, FirstChild); break; case TextDirection.Ltr: _LayoutRects(ChildAfter, FirstChild, LastChild); break; }
            Size = constraints.Constrain(new Size(childWidth * ChildCount, maxHeight));
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            RenderBox child = FirstChild;
            int index = 0;
            while (child != null)
            {
                _PaintChild(context, offset, child, index);
                child = ChildAfter(child);
                index += 1;
            }

        }




        private void _PaintChild(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, int childIndex)
        {

            _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
            context.Canvas.DrawRRect(childParentData.SurroundingRect.Shift(offset), new Paint()..Color = BackgroundColors[childIndex]..Style = PaintingStyle.Fill);
            context.Canvas.DrawRRect(childParentData.SurroundingRect.Shift(offset), new Paint()..Color = BorderColor..StrokeWidth = 1.0..Style = PaintingStyle.Stroke);
            context.PaintChild(child, childParentData.Offset + offset);
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {

            RenderBox child = LastChild;
            while (child != null)
            {
                _SegmentedControlContainerBoxParentData childParentData = child.ParentData as _SegmentedControlContainerBoxParentData;
                if (childParentData.SurroundingRect.Contains(position))
                {
                    Offset center = (Dart.UiDefaultClass.Offset.Zero & child.Size).Center;
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



    }

}
