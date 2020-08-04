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
namespace FlutterSDK.Cupertino.Slider
{
    internal static class SliderDefaultClass
    {
        public static double _KPadding = default(double);
        public static double _KSliderHeight = default(double);
        public static double _KSliderWidth = default(double);
        public static TimeSpan _KDiscreteTransitionDuration = default(TimeSpan);
        public static double _KAdjustmentUnit = default(double);
    }

    /// <Summary>
    /// An iOS-style slider.
    ///
    /// Used to select from a range of values.
    ///
    /// A slider can be used to select from either a continuous or a discrete set of
    /// values. The default is use a continuous range of values from [min] to [max].
    /// To use discrete values, use a non-null value for [divisions], which
    /// indicates the number of discrete intervals. For example, if [min] is 0.0 and
    /// [max] is 50.0 and [divisions] is 5, then the slider can take on the values
    /// discrete values 0.0, 10.0, 20.0, 30.0, 40.0, and 50.0.
    ///
    /// The slider itself does not maintain any state. Instead, when the state of
    /// the slider changes, the widget calls the [onChanged] callback. Most widgets
    /// that use a slider will listen for the [onChanged] callback and rebuild the
    /// slider with a new [value] to update the visual appearance of the slider.
    ///
    /// See also:
    ///
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/controls/sliders/>
    /// </Summary>
    public class CupertinoSlider : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates an iOS-style slider.
        ///
        /// The slider itself does not maintain any state. Instead, when the state of
        /// the slider changes, the widget calls the [onChanged] callback. Most widgets
        /// that use a slider will listen for the [onChanged] callback and rebuild the
        /// slider with a new [value] to update the visual appearance of the slider.
        ///
        /// * [value] determines currently selected value for this slider.
        /// * [onChanged] is called when the user selects a new value for the slider.
        /// * [onChangeStart] is called when the user starts to select a new value for
        ///   the slider.
        /// * [onChangeEnd] is called when the user is done selecting a new value for
        ///   the slider.
        /// </Summary>
        public CupertinoSlider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), double min = 0.0, double max = 1.0, int divisions = default(int), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Value = value;
            this.OnChanged = onChanged;
            this.OnChangeStart = onChangeStart;
            this.OnChangeEnd = onChangeEnd;
            this.Min = min;
            this.Max = max;
            this.Divisions = divisions;
            this.ActiveColor = activeColor;
            this.ThumbColor = thumbColor;
        }
        /// <Summary>
        /// The currently selected value for this slider.
        ///
        /// The slider's thumb is drawn at a position that corresponds to this value.
        /// </Summary>
        public virtual double Value { get; set; }
        /// <Summary>
        /// Called when the user selects a new value for the slider.
        ///
        /// The slider passes the new value to the callback but does not actually
        /// change state until the parent widget rebuilds the slider with the new
        /// value.
        ///
        /// If null, the slider will be displayed as disabled.
        ///
        /// The callback provided to onChanged should update the state of the parent
        /// [StatefulWidget] using the [State.setState] method, so that the parent
        /// gets rebuilt; for example:
        ///
        /// ```dart
        /// CupertinoSlider(
        ///   value: _cupertinoSliderValue.toDouble(),
        ///   min: 1.0,
        ///   max: 10.0,
        ///   divisions: 10,
        ///   onChanged: (double newValue) {
        ///     setState(() {
        ///       _cupertinoSliderValue = newValue.round();
        ///     });
        ///   },
        /// )
        /// ```
        ///
        /// See also:
        ///
        ///  * [onChangeStart] for a callback that is called when the user starts
        ///    changing the value.
        ///  * [onChangeEnd] for a callback that is called when the user stops
        ///    changing the value.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get; set; }
        /// <Summary>
        /// Called when the user starts selecting a new value for the slider.
        ///
        /// This callback shouldn't be used to update the slider [value] (use
        /// [onChanged] for that), but rather to be notified when the user has started
        /// selecting a new value by starting a drag.
        ///
        /// The value passed will be the last [value] that the slider had before the
        /// change began.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// CupertinoSlider(
        ///   value: _cupertinoSliderValue.toDouble(),
        ///   min: 1.0,
        ///   max: 10.0,
        ///   divisions: 10,
        ///   onChanged: (double newValue) {
        ///     setState(() {
        ///       _cupertinoSliderValue = newValue.round();
        ///     });
        ///   },
        ///   onChangeStart: (double startValue) {
        ///     print('Started change at $startValue');
        ///   },
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [onChangeEnd] for a callback that is called when the value change is
        ///    complete.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
        /// <Summary>
        /// Called when the user is done selecting a new value for the slider.
        ///
        /// This callback shouldn't be used to update the slider [value] (use
        /// [onChanged] for that), but rather to know when the user has completed
        /// selecting a new [value] by ending a drag.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// CupertinoSlider(
        ///   value: _cupertinoSliderValue.toDouble(),
        ///   min: 1.0,
        ///   max: 10.0,
        ///   divisions: 10,
        ///   onChanged: (double newValue) {
        ///     setState(() {
        ///       _cupertinoSliderValue = newValue.round();
        ///     });
        ///   },
        ///   onChangeEnd: (double newValue) {
        ///     print('Ended change on $newValue');
        ///   },
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [onChangeStart] for a callback that is called when a value change
        ///    begins.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
        /// <Summary>
        /// The minimum value the user can select.
        ///
        /// Defaults to 0.0.
        /// </Summary>
        public virtual double Min { get; set; }
        /// <Summary>
        /// The maximum value the user can select.
        ///
        /// Defaults to 1.0.
        /// </Summary>
        public virtual double Max { get; set; }
        /// <Summary>
        /// The number of discrete divisions.
        ///
        /// If null, the slider is continuous.
        /// </Summary>
        public virtual int Divisions { get; set; }
        /// <Summary>
        /// The color to use for the portion of the slider that has been selected.
        ///
        /// Defaults to the [CupertinoTheme]'s primary color if null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        /// <Summary>
        /// The color to use for the thumb of the slider.
        ///
        /// Thumb color must not be null.
        ///
        /// Defaults to [CupertinoColors.white].
        /// </Summary>
        public virtual FlutterBinding.UI.Color ThumbColor { get; set; }

        public new FlutterSDK.Cupertino.Slider._CupertinoSliderState CreateState() => new _CupertinoSliderState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("value", Value));
            properties.Add(new DoubleProperty("min", Min));
            properties.Add(new DoubleProperty("max", Max));
        }



    }


    public class _CupertinoSliderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Slider.CupertinoSlider>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _CupertinoSliderState()
        { }

        private void _HandleChanged(double value)
        {

            double lerpValue = Dart.UI.UiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value);
            if (lerpValue != Widget.Value)
            {
                Widget.OnChanged(lerpValue);
            }

        }




        private void _HandleDragStart(double value)
        {

            Widget.OnChangeStart(Dart.UI.UiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value));
        }




        private void _HandleDragEnd(double value)
        {

            Widget.OnChangeEnd(Dart.UI.UiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _CupertinoSliderRenderObjectWidget(value: (Widget.Value - Widget.Min) / (Widget.Max - Widget.Min), divisions: Widget.Divisions, activeColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.ActiveColor ?? ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor, context), thumbColor: Widget.ThumbColor, onChanged: Widget.OnChanged != null ? _HandleChanged : null, onChangeStart: Widget.OnChangeStart != null ? _HandleDragStart : null, onChangeEnd: Widget.OnChangeEnd != null ? _HandleDragEnd : null, vsync: this);
        }



    }


    public class _CupertinoSliderRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public _CupertinoSliderRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), int divisions = default(int), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        : base(key: key)
        {
            this.Value = value;
            this.Divisions = divisions;
            this.ActiveColor = activeColor;
            this.ThumbColor = thumbColor;
            this.OnChanged = onChanged;
            this.OnChangeStart = onChangeStart;
            this.OnChangeEnd = onChangeEnd;
            this.Vsync = vsync;
        }
        public virtual double Value { get; set; }
        public virtual int Divisions { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }

        public new FlutterSDK.Cupertino.Slider._RenderCupertinoSlider CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderCupertinoSlider(value: Value, divisions: Divisions, activeColor: ActiveColor, thumbColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context), trackColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemFill, context), onChanged: OnChanged, onChangeStart: OnChangeStart, onChangeEnd: OnChangeEnd, vsync: Vsync, textDirection: BasicDefaultClass.Directionality.Of(context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Slider._RenderCupertinoSlider renderObject)
        {
            ..Value = Value..Divisions = Divisions..ActiveColor = ActiveColor..ThumbColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context)..TrackColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemFill, context)..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Value = Value..Divisions = Divisions..ActiveColor = ActiveColor..ThumbColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context)..TrackColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemFill, context)..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context);
        }



    }


    public class _RenderCupertinoSlider : FlutterSDK.Rendering.Proxybox.RenderConstrainedBox
    {
        public _RenderCupertinoSlider(double value = default(double), int divisions = default(int), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color trackColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), TextDirection textDirection = default(TextDirection))
        : base(additionalConstraints: BoxConstraints.TightFor(width: SliderDefaultClass._KSliderWidth, height: SliderDefaultClass._KSliderHeight))
        {
            this.OnChangeStart = onChangeStart;
            this.OnChangeEnd = onChangeEnd;
            _Drag = new HorizontalDragGestureRecognizer()..OnStart = _HandleDragStart..OnUpdate = _HandleDragUpdate..OnEnd = _HandleDragEnd;
            _Position = new AnimationController(value: value, duration: SliderDefaultClass._KDiscreteTransitionDuration, vsync: vsync);
            new AnimationController(value: value, duration: SliderDefaultClass._KDiscreteTransitionDuration, vsync: vsync).AddListener(MarkNeedsPaint);
        }


        internal virtual double _Value { get; set; }
        internal virtual int _Divisions { get; set; }
        internal virtual FlutterBinding.UI.Color _ActiveColor { get; set; }
        internal virtual FlutterBinding.UI.Color _ThumbColor { get; set; }
        internal virtual FlutterBinding.UI.Color _TrackColor { get; set; }
        internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> _OnChanged { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Position { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag { get; set; }
        internal virtual double _CurrentDragValue { get; set; }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int Divisions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ActiveColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ThumbColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color TrackColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _DiscretizedCurrentDragValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _TrackLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _TrackRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _ThumbCenter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _SemanticActionUnit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) => _StartInteraction(details.GlobalPosition);



        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            if (IsInteractive)
            {
                double extent = Dart.Math.MathDefaultClass.Max(SliderDefaultClass._KPadding, Size.Width - 2.0 * (SliderDefaultClass._KPadding + ThumbpainterDefaultClass.CupertinoThumbPainter.Radius));
                double valueDelta = details.PrimaryDelta / extent;
                switch (TextDirection) { case TextDirection.Rtl: _CurrentDragValue -= valueDelta; break; case TextDirection.Ltr: _CurrentDragValue += valueDelta; break; }
                OnChanged(_DiscretizedCurrentDragValue);
            }

        }




        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) => _EndInteraction();



        private void _StartInteraction(FlutterBinding.UI.Offset globalPosition)
        {
            if (IsInteractive)
            {
                if (OnChangeStart != null)
                {
                    OnChangeStart(_DiscretizedCurrentDragValue);
                }

                _CurrentDragValue = _Value;
                OnChanged(_DiscretizedCurrentDragValue);
            }

        }




        private void _EndInteraction()
        {
            if (OnChangeEnd != null)
            {
                OnChangeEnd(_DiscretizedCurrentDragValue);
            }

            _CurrentDragValue = 0.0;
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position)
        {
            return (position.Dx - _ThumbCenter).Abs() < ThumbpainterDefaultClass.CupertinoThumbPainter.Radius + SliderDefaultClass._KPadding;
        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
        {

            if (@event is PointerDownEvent && IsInteractive) _Drag.AddPointer(@event);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            double visualPosition = default(double);
            Color leftColor = default(Color);
            Color rightColor = default(Color);
            switch (TextDirection) { case TextDirection.Rtl: visualPosition = 1.0 - _Position.Value; leftColor = _ActiveColor; rightColor = TrackColor; break; case TextDirection.Ltr: visualPosition = _Position.Value; leftColor = TrackColor; rightColor = _ActiveColor; break; }
            double trackCenter = offset.Dy + Size.Height / 2.0;
            double trackLeft = offset.Dx + _TrackLeft;
            double trackTop = trackCenter - 1.0;
            double trackBottom = trackCenter + 1.0;
            double trackRight = offset.Dx + _TrackRight;
            double trackActive = offset.Dx + _ThumbCenter;
            Canvas canvas = context.Canvas;
            if (visualPosition > 0.0)
            {
                Paint paint = new Paint()..Color = rightColor;
                canvas.DrawRRect(RRect.FromLTRBXY(trackLeft, trackTop, trackActive, trackBottom, 1.0, 1.0), paint);
            }

            if (visualPosition < 1.0)
            {
                Paint paint = new Paint()..Color = leftColor;
                canvas.DrawRRect(RRect.FromLTRBXY(trackActive, trackTop, trackRight, trackBottom, 1.0, 1.0), paint);
            }

            Offset thumbCenter = new Offset(trackActive, trackCenter);
            new CupertinoThumbPainter(color: ThumbColor).Paint(canvas, Rect.FromCircle(center: thumbCenter, radius: ThumbpainterDefaultClass.CupertinoThumbPainter.Radius));
        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.IsSemanticBoundary = IsInteractive;
            if (IsInteractive)
            {
                config.TextDirection = TextDirection;
                config.OnIncrease = _IncreaseAction;
                config.OnDecrease = _DecreaseAction;
                config.Value = $"'{(Value * 100).Round()}%'";
                config.IncreasedValue = $"'{((Value + _SemanticActionUnit).Clamp(0.0, 1.0) * 100).Round()}%'";
                config.DecreasedValue = $"'{((Value - _SemanticActionUnit).Clamp(0.0, 1.0) * 100).Round()}%'";
            }

        }




        private void _IncreaseAction()
        {
            if (IsInteractive) OnChanged((Value + _SemanticActionUnit).Clamp(0.0, 1.0) as double);
        }




        private void _DecreaseAction()
        {
            if (IsInteractive) OnChanged((Value - _SemanticActionUnit).Clamp(0.0, 1.0) as double);
        }



    }

}
