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
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
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
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Typography;
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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Material.Rangeslider
{
    internal static class RangesliderDefaultClass
    {
    }

    /// <Summary>
    /// A Material Design range slider.
    ///
    /// Used to select a range from a range of values.
    ///
    /// A range slider can be used to select from either a continuous or a discrete
    /// set of values. The default is to use a continuous range of values from [min]
    /// to [max]. To use discrete values, use a non-null value for [divisions], which
    /// indicates the number of discrete intervals. For example, if [min] is 0.0 and
    /// [max] is 50.0 and [divisions] is 5, then the slider can take on the
    /// discrete values 0.0, 10.0, 20.0, 30.0, 40.0, and 50.0.
    ///
    /// The terms for the parts of a slider are:
    ///
    ///  * The "thumbs", which are the shapes that slide horizontally when the user
    ///    drags them to change the selected range.
    ///  * The "track", which is the horizontal line that the thumbs can be dragged
    ///    along.
    ///  * The "tick marks", which mark the discrete values of a discrete slider.
    ///  * The "overlay", which is a highlight that's drawn over a thumb in response
    ///    to a user tap-down gesture.
    ///  * The "value indicators", which are the shapes that pop up when the user
    ///    is dragging a thumb to show the value being selected.
    ///  * The "active" segment of the slider is the segment between the two thumbs.
    ///  * The "inactive" slider segments are the two track intervals outside of the
    ///    slider's thumbs.
    ///
    /// The range slider will be disabled if [onChanged] is null or if the range
    /// given by [min]..[max] is empty (i.e. if [min] is equal to [max]).
    ///
    /// The range slider widget itself does not maintain any state. Instead, when
    /// the state of the slider changes, the widget calls the [onChanged] callback.
    /// Most widgets that use a range slider will listen for the [onChanged] callback
    /// and rebuild the slider with a new [value] to update the visual appearance of
    /// the slider. To know when the value starts to change, or when it is done
    /// changing, set the optional callbacks [onChangeStart] and/or [onChangeEnd].
    ///
    /// By default, a slider will be as wide as possible, centered vertically. When
    /// given unbounded constraints, it will attempt to make the track 144 pixels
    /// wide (including margins on each side) and will shrink-wrap vertically.
    ///
    /// Requires one of its ancestors to be a [Material] widget. This is typically
    /// provided by a [Scaffold] widget.
    ///
    /// Requires one of its ancestors to be a [MediaQuery] widget. Typically, a
    /// [MediaQuery] widget is introduced by the [MaterialApp] or [WidgetsApp]
    /// widget at the top of your application widget tree.
    ///
    /// To determine how it should be displayed (e.g. colors, thumb shape, etc.),
    /// a slider uses the [SliderThemeData] available from either a [SliderTheme]
    /// widget, or the [ThemeData.sliderTheme] inside a [Theme] widget above it in
    /// the widget tree. You can also override some of the colors with the
    /// [activeColor] and [inactiveColor] properties, although more fine-grained
    /// control of the colors, and other visual properties is achieved using a
    /// [SliderThemeData].
    ///
    /// See also:
    ///
    ///  * [SliderTheme] and [SliderThemeData] for information about controlling
    ///    the visual appearance of the slider.
    ///  * [Slider], for a single-valued slider.
    ///  * [Radio], for selecting among a set of explicit values.
    ///  * [Checkbox] and [Switch], for toggling a particular value on or off.
    ///  * <https://material.io/design/components/sliders.html>
    ///  * [MediaQuery], from which the text scale factor is obtained.
    /// </Summary>
    public class RangeSlider : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a Material Design range slider.
        ///
        /// The range slider widget itself does not maintain any state. Instead, when
        /// the state of the slider changes, the widget calls the [onChanged] callback.
        /// Most widgets that use a range slider will listen for the [onChanged] callback
        /// and rebuild the slider with a new [value] to update the visual appearance of
        /// the slider. To know when the value starts to change, or when it is done
        /// changing, set the optional callbacks [onChangeStart] and/or [onChangeEnd].
        ///
        /// * [values], which  determines currently selected values for this range
        ///   slider.
        /// * [onChanged], which is called while the user is selecting a new value for
        ///   the range slider.
        /// * [onChangeStart], which is called when the user starts to select a new
        ///   value for the range slider.
        /// * [onChangeEnd], which is called when the user is done selecting a new
        ///   value for the range slider.
        ///
        /// You can override some of the colors with the [activeColor] and
        /// [inactiveColor] properties, although more fine-grained control of the
        /// appearance is achieved using a [SliderThemeData].
        ///
        /// The [values], [min], [max] must not be null. The [min] must be less than
        /// or equal to the [max]. [values.start] must be less than or equal to
        /// [values.end]. [values.start] and [values.end] must be greater than or
        /// equal to the [min] and less than or equal to the [max]. The [divisions]
        /// must be null or greater than 0.
        /// </Summary>
        public RangeSlider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Slidertheme.RangeValues values = default(FlutterSDK.Material.Slidertheme.RangeValues), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), double min = 0.0, double max = 1.0, int divisions = default(int), FlutterSDK.Material.Slidertheme.RangeLabels labels = default(FlutterSDK.Material.Slidertheme.RangeLabels), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback))
        : base(key: key)
        {
            this.Values = values;
            this.OnChanged = onChanged;
            this.OnChangeStart = onChangeStart;
            this.OnChangeEnd = onChangeEnd;
            this.Min = min;
            this.Max = max;
            this.Divisions = divisions;
            this.Labels = labels;
            this.ActiveColor = activeColor;
            this.InactiveColor = inactiveColor;
            this.SemanticFormatterCallback = semanticFormatterCallback;
        }
        /// <Summary>
        /// The currently selected values for this range slider.
        ///
        /// The slider's thumbs are drawn at horizontal positions that corresponds to
        /// these values.
        /// </Summary>
        public virtual FlutterSDK.Material.Slidertheme.RangeValues Values { get; set; }
        /// <Summary>
        /// Called when the user is selecting a new value for the slider by dragging.
        ///
        /// The slider passes the new values to the callback but does not actually
        /// change state until the parent widget rebuilds the slider with the new
        /// values.
        ///
        /// If null, the slider will be displayed as disabled.
        ///
        /// The callback provided to [onChanged] should update the state of the parent
        /// [StatefulWidget] using the [State.setState] method, so that the parent
        /// gets rebuilt; for example:
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// RangeSlider(
        ///   values: _rangeValues,
        ///   min: 1.0,
        ///   max: 10.0,
        ///   onChanged: (RangeValues newValues) {
        ///     setState(() {
        ///       _rangeValues = newValues;
        ///     });
        ///   },
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [onChangeStart], which  is called when the user starts  changing the
        ///    values.
        ///  * [onChangeEnd], which is called when the user stops changing the values.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChanged { get; set; }
        /// <Summary>
        /// Called when the user starts selecting new values for the slider.
        ///
        /// This callback shouldn't be used to update the slider [values] (use
        /// [onChanged] for that). Rather, it should be used to be notified when the
        /// user has started selecting a new value by starting a drag or with a tap.
        ///
        /// The values passed will be the last [values] that the slider had before the
        /// change began.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// RangeSlider(
        ///   values: _rangeValues,
        ///   min: 1.0,
        ///   max: 10.0,
        ///   onChanged: (RangeValues newValues) {
        ///     setState(() {
        ///       _rangeValues = newValues;
        ///     });
        ///   },
        ///   onChangeStart: (RangeValues startValues) {
        ///     print('Started change at $startValues');
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
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeStart { get; set; }
        /// <Summary>
        /// Called when the user is done selecting new values for the slider.
        ///
        /// This differs from [onChanged] because it is only called once at the end
        /// of the interaction, while [onChanged] is called as the value is getting
        /// updated within the interaction.
        ///
        /// This callback shouldn't be used to update the slider [values] (use
        /// [onChanged] for that). Rather, it should be used to know when the user has
        /// completed selecting a new [values] by ending a drag or a click.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// RangeSlider(
        ///   values: _rangeValues,
        ///   min: 1.0,
        ///   max: 10.0,
        ///   onChanged: (RangeValues newValues) {
        ///     setState(() {
        ///       _rangeValues = newValues;
        ///     });
        ///   },
        ///   onChangeEnd: (RangeValues endValues) {
        ///     print('Ended change at $endValues');
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
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeEnd { get; set; }
        /// <Summary>
        /// The minimum value the user can select.
        ///
        /// Defaults to 0.0. Must be less than or equal to [max].
        ///
        /// If the [max] is equal to the [min], then the slider is disabled.
        /// </Summary>
        public virtual double Min { get; set; }
        /// <Summary>
        /// The maximum value the user can select.
        ///
        /// Defaults to 1.0. Must be greater than or equal to [min].
        ///
        /// If the [max] is equal to the [min], then the slider is disabled.
        /// </Summary>
        public virtual double Max { get; set; }
        /// <Summary>
        /// The number of discrete divisions.
        ///
        /// Typically used with [labels] to show the current discrete values.
        ///
        /// If null, the slider is continuous.
        /// </Summary>
        public virtual int Divisions { get; set; }
        /// <Summary>
        /// Labels to show as text in the [SliderThemeData.rangeValueIndicatorShape].
        ///
        /// There are two labels: one for the start thumb and one for the end thumb.
        ///
        /// Each label is rendered using the active [ThemeData]'s
        /// [ThemeData.textTheme.bodyText1] text style, with the
        /// theme data's [ThemeData.colorScheme.onPrimaryColor]. The label's text
        /// style can be overridden with [SliderThemeData.valueIndicatorTextStyle].
        ///
        /// If null, then the value indicator will not be displayed.
        ///
        /// See also:
        ///
        ///  * [RangeSliderValueIndicatorShape] for how to create a custom value
        ///    indicator shape.
        /// </Summary>
        public virtual FlutterSDK.Material.Slidertheme.RangeLabels Labels { get; set; }
        /// <Summary>
        /// The color of the track's active segment, i.e. the span of track between
        /// the thumbs.
        ///
        /// Defaults to [ColorScheme.primary].
        ///
        /// Using a [SliderTheme] gives more fine-grained control over the
        /// appearance of various components of the slider.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        /// <Summary>
        /// The color of the track's inactive segments, i.e. the span of tracks
        /// between the min and the start thumb, and the end thumb and the max.
        ///
        /// Defaults to [ColorScheme.primary] with 24% opacity.
        ///
        /// Using a [SliderTheme] gives more fine-grained control over the
        /// appearance of various components of the slider.
        /// </Summary>
        public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
        /// <Summary>
        /// The callback used to create a semantic value from the slider's values.
        ///
        /// Defaults to formatting values as a percentage.
        ///
        /// This is used by accessibility frameworks like TalkBack on Android to
        /// inform users what the currently selected value is with more context.
        ///
        /// {@tool snippet}
        ///
        /// In the example below, a slider for currency values is configured to
        /// announce a value with a currency label.
        ///
        /// ```dart
        /// RangeSlider(
        ///   values: _dollarsRange,
        ///   min: 20.0,
        ///   max: 330.0,
        ///   onChanged: (RangeValues newValues) {
        ///     setState(() {
        ///       _dollarsRange = newValues;
        ///     });
        ///   },
        ///   semanticFormatterCallback: (RangeValues rangeValues) {
        ///     return '${rangeValues.start.round()} - ${rangeValues.end.round()} dollars';
        ///   }
        ///  )
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback SemanticFormatterCallback { get; set; }
        internal virtual double _MinTouchTargetWidth { get; set; }

        public new FlutterSDK.Material.Rangeslider._RangeSliderState CreateState() => new _RangeSliderState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("valueStart", Values.Start));
            properties.Add(new DoubleProperty("valueEnd", Values.End));
            properties.Add(new ObjectFlagProperty<ValueChanged<RangeValues>>("onChanged", OnChanged, ifNull: "disabled"));
            properties.Add(ObjectFlagProperty<ValueChanged<RangeValues>>.Has("onChangeStart", OnChangeStart));
            properties.Add(ObjectFlagProperty<ValueChanged<RangeValues>>.Has("onChangeEnd", OnChangeEnd));
            properties.Add(new DoubleProperty("min", Min));
            properties.Add(new DoubleProperty("max", Max));
            properties.Add(new IntProperty("divisions", Divisions));
            properties.Add(new StringProperty("labelStart", Labels?.Start));
            properties.Add(new StringProperty("labelEnd", Labels?.End));
            properties.Add(new ColorProperty("activeColor", ActiveColor));
            properties.Add(new ColorProperty("inactiveColor", InactiveColor));
            properties.Add(ObjectFlagProperty<ValueChanged<RangeValues>>.Has("semanticFormatterCallback", SemanticFormatterCallback));
        }



    }


    public class _RangeSliderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Rangeslider.RangeSlider>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _RangeSliderState()
        { }
        public virtual TimeSpan EnableAnimationDuration { get; set; }
        public virtual TimeSpan ValueIndicatorAnimationDuration { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController OverlayController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ValueIndicatorController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController EnableController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController StartPositionController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController EndPositionController { get; set; }
        public virtual Timer InteractionTimer { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeThumbSelector _DefaultRangeThumbSelector { get; set; }
        internal virtual double _DefaultTrackHeight { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeSliderTrackShape _DefaultTrackShape { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape _DefaultTickMarkShape { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.SliderComponentShape _DefaultOverlayShape { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeSliderThumbShape _DefaultThumbShape { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape _DefaultValueIndicatorShape { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.ShowValueIndicator _DefaultShowValueIndicator { get; set; }
        internal virtual double _DefaultMinThumbSeparation { get; set; }

        public new void InitState()
        {
            base.InitState();
            OverlayController = new AnimationController(duration: ConstantsDefaultClass.KRadialReactionDuration, vsync: this);
            ValueIndicatorController = new AnimationController(duration: ValueIndicatorAnimationDuration, vsync: this);
            EnableController = new AnimationController(duration: EnableAnimationDuration, vsync: this, value: Widget.OnChanged != null ? 1.0 : 0.0);
            StartPositionController = new AnimationController(duration: Dart.CoreDefaultClass.Duration.Zero, vsync: this, value: _Unlerp(Widget.Values.Start));
            EndPositionController = new AnimationController(duration: Dart.CoreDefaultClass.Duration.Zero, vsync: this, value: _Unlerp(Widget.Values.End));
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Rangeslider.RangeSlider oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.OnChanged == Widget.OnChanged) return;
            bool wasEnabled = oldWidget.OnChanged != null;
            bool isEnabled = Widget.OnChanged != null;
            if (wasEnabled != isEnabled)
            {
                if (isEnabled)
                {
                    EnableController.Forward();
                }
                else
                {
                    EnableController.Reverse();
                }

            }

        }




        public new void Dispose()
        {
            InteractionTimer?.Cancel();
            OverlayController.Dispose();
            ValueIndicatorController.Dispose();
            EnableController.Dispose();
            StartPositionController.Dispose();
            EndPositionController.Dispose();
            base.Dispose();
        }




        private void _HandleChanged(FlutterSDK.Material.Slidertheme.RangeValues values)
        {

            RangeValues lerpValues = _LerpRangeValues(values);
            if (lerpValues != Widget.Values)
            {
                Widget.OnChanged(lerpValues);
            }

        }




        private void _HandleDragStart(FlutterSDK.Material.Slidertheme.RangeValues values)
        {

            Widget.OnChangeStart(_LerpRangeValues(values));
        }




        private void _HandleDragEnd(FlutterSDK.Material.Slidertheme.RangeValues values)
        {

            Widget.OnChangeEnd(_LerpRangeValues(values));
        }




        private double _Lerp(double value) => Dart.UI.UiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value);



        private FlutterSDK.Material.Slidertheme.RangeValues _LerpRangeValues(FlutterSDK.Material.Slidertheme.RangeValues values)
        {
            return new RangeValues(_Lerp(values.Start), _Lerp(values.End));
        }




        private double _Unlerp(double value)
        {


            return Widget.Max > Widget.Min ? (value - Widget.Min) / (Widget.Max - Widget.Min) : 0.0;
        }




        private FlutterSDK.Material.Slidertheme.RangeValues _UnlerpRangeValues(FlutterSDK.Material.Slidertheme.RangeValues values)
        {
            return new RangeValues(_Unlerp(values.Start), _Unlerp(values.End));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            SliderThemeData sliderTheme = SliderthemeDefaultClass.SliderTheme.Of(context);
            sliderTheme = sliderTheme.CopyWith(trackHeight: sliderTheme.TrackHeight ?? _DefaultTrackHeight, activeTrackColor: Widget.ActiveColor ?? sliderTheme.ActiveTrackColor ?? theme.ColorScheme.Primary, inactiveTrackColor: Widget.InactiveColor ?? sliderTheme.InactiveTrackColor ?? theme.ColorScheme.Primary.WithOpacity(0.24), disabledActiveTrackColor: sliderTheme.DisabledActiveTrackColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.32), disabledInactiveTrackColor: sliderTheme.DisabledInactiveTrackColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.12), activeTickMarkColor: Widget.InactiveColor ?? sliderTheme.ActiveTickMarkColor ?? theme.ColorScheme.OnPrimary.WithOpacity(0.54), inactiveTickMarkColor: Widget.ActiveColor ?? sliderTheme.InactiveTickMarkColor ?? theme.ColorScheme.Primary.WithOpacity(0.54), disabledActiveTickMarkColor: sliderTheme.DisabledActiveTickMarkColor ?? theme.ColorScheme.OnPrimary.WithOpacity(0.12), disabledInactiveTickMarkColor: sliderTheme.DisabledInactiveTickMarkColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.12), thumbColor: Widget.ActiveColor ?? sliderTheme.ThumbColor ?? theme.ColorScheme.Primary, overlappingShapeStrokeColor: sliderTheme.OverlappingShapeStrokeColor ?? theme.ColorScheme.Surface, disabledThumbColor: sliderTheme.DisabledThumbColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.38), overlayColor: Widget.ActiveColor?.WithOpacity(0.12) ?? sliderTheme.OverlayColor ?? theme.ColorScheme.Primary.WithOpacity(0.12), valueIndicatorColor: Widget.ActiveColor ?? sliderTheme.ValueIndicatorColor ?? theme.ColorScheme.Primary, rangeTrackShape: sliderTheme.RangeTrackShape ?? _DefaultTrackShape, rangeTickMarkShape: sliderTheme.RangeTickMarkShape ?? _DefaultTickMarkShape, rangeThumbShape: sliderTheme.RangeThumbShape ?? _DefaultThumbShape, overlayShape: sliderTheme.OverlayShape ?? _DefaultOverlayShape, rangeValueIndicatorShape: sliderTheme.RangeValueIndicatorShape ?? _DefaultValueIndicatorShape, showValueIndicator: sliderTheme.ShowValueIndicator ?? _DefaultShowValueIndicator, valueIndicatorTextStyle: sliderTheme.ValueIndicatorTextStyle ?? theme.TextTheme.BodyText1.CopyWith(color: theme.ColorScheme.OnPrimary), minThumbSeparation: sliderTheme.MinThumbSeparation ?? _DefaultMinThumbSeparation, thumbSelector: sliderTheme.ThumbSelector ?? _DefaultRangeThumbSelector);
            return new _RangeSliderRenderObjectWidget(values: _UnlerpRangeValues(Widget.Values), divisions: Widget.Divisions, labels: Widget.Labels, sliderTheme: sliderTheme, textScaleFactor: MediaqueryDefaultClass.MediaQuery.Of(context).TextScaleFactor, onChanged: (Widget.OnChanged != null) && (Widget.Max > Widget.Min) ? _HandleChanged : null, onChangeStart: Widget.OnChangeStart != null ? _HandleDragStart : null, onChangeEnd: Widget.OnChangeEnd != null ? _HandleDragEnd : null, state: this, semanticFormatterCallback: Widget.SemanticFormatterCallback);
        }



    }


    public class _RangeSliderRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public _RangeSliderRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Slidertheme.RangeValues values = default(FlutterSDK.Material.Slidertheme.RangeValues), int divisions = default(int), FlutterSDK.Material.Slidertheme.RangeLabels labels = default(FlutterSDK.Material.Slidertheme.RangeLabels), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), double textScaleFactor = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Material.Rangeslider._RangeSliderState state = default(FlutterSDK.Material.Rangeslider._RangeSliderState), FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback))
        : base(key: key)
        {
            this.Values = values;
            this.Divisions = divisions;
            this.Labels = labels;
            this.SliderTheme = sliderTheme;
            this.TextScaleFactor = textScaleFactor;
            this.OnChanged = onChanged;
            this.OnChangeStart = onChangeStart;
            this.OnChangeEnd = onChangeEnd;
            this.State = state;
            this.SemanticFormatterCallback = semanticFormatterCallback;
        }
        public virtual FlutterSDK.Material.Slidertheme.RangeValues Values { get; set; }
        public virtual int Divisions { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeLabels Labels { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChanged { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeStart { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeEnd { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback SemanticFormatterCallback { get; set; }
        public virtual FlutterSDK.Material.Rangeslider._RangeSliderState State { get; set; }

        public new FlutterSDK.Material.Rangeslider._RenderRangeSlider CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderRangeSlider(values: Values, divisions: Divisions, labels: Labels, sliderTheme: SliderTheme, theme: ThemeDefaultClass.Theme.Of(context), textScaleFactor: TextScaleFactor, onChanged: OnChanged, onChangeStart: OnChangeStart, onChangeEnd: OnChangeEnd, state: State, textDirection: BasicDefaultClass.Directionality.Of(context), semanticFormatterCallback: SemanticFormatterCallback, platform: ThemeDefaultClass.Theme.Of(context).Platform);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Rangeslider._RenderRangeSlider renderObject)
        {
            ..Values = Values..Divisions = Divisions..Labels = Labels..SliderTheme = SliderTheme..Theme = ThemeDefaultClass.Theme.Of(context)..TextScaleFactor = TextScaleFactor..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context)..SemanticFormatterCallback = SemanticFormatterCallback..Platform = ThemeDefaultClass.Theme.Of(context).Platform;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Values = Values..Divisions = Divisions..Labels = Labels..SliderTheme = SliderTheme..Theme = ThemeDefaultClass.Theme.Of(context)..TextScaleFactor = TextScaleFactor..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context)..SemanticFormatterCallback = SemanticFormatterCallback..Platform = ThemeDefaultClass.Theme.Of(context).Platform;
        }



    }


    public class _RenderRangeSlider : FlutterSDK.Rendering.Box.RenderBox, IRelayoutWhenSystemFontsChangeMixin
    {
        public _RenderRangeSlider(FlutterSDK.Material.Slidertheme.RangeValues values = default(FlutterSDK.Material.Slidertheme.RangeValues), int divisions = default(int), FlutterSDK.Material.Slidertheme.RangeLabels labels = default(FlutterSDK.Material.Slidertheme.RangeLabels), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData), double textScaleFactor = default(double), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>), FlutterSDK.Material.Rangeslider._RangeSliderState state = default(FlutterSDK.Material.Rangeslider._RangeSliderState), TextDirection textDirection = default(TextDirection))
        : base()
        {
            this.OnChangeStart = onChangeStart;
            this.OnChangeEnd = onChangeEnd;
            _UpdateLabelPainters();
            GestureArenaTeam team = new GestureArenaTeam();
            _Drag = new HorizontalDragGestureRecognizer()..Team = team..OnStart = _HandleDragStart..OnUpdate = _HandleDragUpdate..OnEnd = _HandleDragEnd..OnCancel = _HandleDragCancel;
            _Tap = new TapGestureRecognizer()..Team = team..OnTapDown = _HandleTapDown..OnTapUp = _HandleTapUp..OnTapCancel = _HandleTapCancel;
            _OverlayAnimation = new CurvedAnimation(parent: _State.OverlayController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            _ValueIndicatorAnimation = new CurvedAnimation(parent: _State.ValueIndicatorController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            _EnableAnimation = new CurvedAnimation(parent: _State.EnableController, curve: CurvesDefaultClass.Curves.EaseInOut);
        }


        internal virtual FlutterSDK.Material.Slidertheme.Thumb _LastThumbSelection { get; set; }
        internal virtual TimeSpan _PositionAnimationDuration { get; set; }
        internal virtual double _MinPreferredTrackWidth { get; set; }
        internal virtual TimeSpan _MinimumInteractionTime { get; set; }
        internal virtual FlutterSDK.Material.Rangeslider._RangeSliderState _State { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OverlayAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ValueIndicatorAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _EnableAnimation { get; set; }
        internal virtual FlutterSDK.Painting.Textpainter.TextPainter _StartLabelPainter { get; set; }
        internal virtual FlutterSDK.Painting.Textpainter.TextPainter _EndLabelPainter { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag { get; set; }
        internal virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer _Tap { get; set; }
        internal virtual bool _Active { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeValues _NewValues { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeValues _Values { get; set; }
        internal virtual FlutterSDK.Foundation.Platform.TargetPlatform _Platform { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback _SemanticFormatterCallback { get; set; }
        internal virtual int _Divisions { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.RangeLabels _Labels { get; set; }
        internal virtual FlutterSDK.Material.Slidertheme.SliderThemeData _SliderTheme { get; set; }
        internal virtual FlutterSDK.Material.Themedata.ThemeData _Theme { get; set; }
        internal virtual double _TextScaleFactor { get; set; }
        internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> _OnChanged { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeStart { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeEnd { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _DecreaseStart { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _IncreaseStart { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _DecreaseEnd { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _IncreaseEnd { get; set; }
        internal virtual double _MaxSliderPartWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _MaxSliderPartHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual List<Size> _SliderPartSizes { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _MinPreferredTrackHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Rect _TrackRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsDiscrete { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Slidertheme.RangeValues Values { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Platform.TargetPlatform Platform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback SemanticFormatterCallback { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int Divisions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Slidertheme.RangeLabels Labels { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Themedata.ThemeData Theme { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TextScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChanged { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ShowValueIndicator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Size _ThumbSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _AdjustmentUnit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _SemanticActionUnit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _UpdateLabelPainters()
        {
            _UpdateLabelPainter(Thumb.Start);
            _UpdateLabelPainter(Thumb.End);
        }




        private void _UpdateLabelPainter(FlutterSDK.Material.Slidertheme.Thumb thumb)
        {
            if (Labels == null) return;
            string text = default(string);
            TextPainter labelPainter = default(TextPainter);
            switch (thumb) { case Thumb.Start: text = Labels.Start; labelPainter = _StartLabelPainter; break; case Thumb.End: text = Labels.End; labelPainter = _EndLabelPainter; break; }
            if (Labels != null)
            {
                ..Text = new TextSpan(style: _SliderTheme.ValueIndicatorTextStyle, text: text)..TextDirection = TextDirection..TextScaleFactor = TextScaleFactor;
                labelPainter.Layout();
            }
            else
            {
                labelPainter.Text = null;
            }

            MarkNeedsLayout();
        }




        public new void SystemFontsDidChange()
        {
            base.SystemFontsDidChange();
            _StartLabelPainter.MarkNeedsLayout();
            _EndLabelPainter.MarkNeedsLayout();
            _UpdateLabelPainters();
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _OverlayAnimation.AddListener(MarkNeedsPaint);
            _ValueIndicatorAnimation.AddListener(MarkNeedsPaint);
            _EnableAnimation.AddListener(MarkNeedsPaint);
            _State.StartPositionController.AddListener(MarkNeedsPaint);
            _State.EndPositionController.AddListener(MarkNeedsPaint);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _OverlayAnimation.AddListener(MarkNeedsPaint);
            _ValueIndicatorAnimation.AddListener(MarkNeedsPaint);
            _EnableAnimation.AddListener(MarkNeedsPaint);
            _State.StartPositionController.AddListener(MarkNeedsPaint);
            _State.EndPositionController.AddListener(MarkNeedsPaint);
        }




        public new void Detach()
        {
            _OverlayAnimation.RemoveListener(MarkNeedsPaint);
            _ValueIndicatorAnimation.RemoveListener(MarkNeedsPaint);
            _EnableAnimation.RemoveListener(MarkNeedsPaint);
            _State.StartPositionController.RemoveListener(MarkNeedsPaint);
            _State.EndPositionController.RemoveListener(MarkNeedsPaint);
            base.Detach();
        }




        private double _GetValueFromVisualPosition(double visualPosition)
        {
            switch (TextDirection) { case TextDirection.Rtl: return 1.0 - visualPosition; case TextDirection.Ltr: return visualPosition; }
            return null;
        }




        private double _GetValueFromGlobalPosition(FlutterBinding.UI.Offset globalPosition)
        {
            double visualPosition = (GlobalToLocal(globalPosition).Dx - _TrackRect.Left) / _TrackRect.Width;
            return _GetValueFromVisualPosition(visualPosition);
        }




        private double _Discretize(double value)
        {
            double result = value.Clamp(0.0, 1.0) as double;
            if (IsDiscrete)
            {
                result = (result * Divisions).Round() / Divisions;
            }

            return result;
        }




        private FlutterSDK.Material.Slidertheme.RangeValues _DiscretizeRangeValues(FlutterSDK.Material.Slidertheme.RangeValues values)
        {
            return new RangeValues(_Discretize(values.Start), _Discretize(values.End));
        }




        private void _StartInteraction(FlutterBinding.UI.Offset globalPosition)
        {
            double tapValue = _GetValueFromGlobalPosition(globalPosition).Clamp(0.0, 1.0) as double;
            _LastThumbSelection = SliderTheme.ThumbSelector(TextDirection, Values, tapValue, _ThumbSize, Size, 0);
            if (_LastThumbSelection != null)
            {
                _Active = true;
                RangeValues currentValues = _DiscretizeRangeValues(Values);
                if (_LastThumbSelection == Thumb.Start)
                {
                    _NewValues = new RangeValues(tapValue, currentValues.End);
                }
                else if (_LastThumbSelection == Thumb.End)
                {
                    _NewValues = new RangeValues(currentValues.Start, tapValue);
                }

                _UpdateLabelPainter(_LastThumbSelection);
                if (OnChangeStart != null)
                {
                    OnChangeStart(currentValues);
                }

                OnChanged(_DiscretizeRangeValues(_NewValues));
                _State.OverlayController.Forward();
                if (ShowValueIndicator)
                {
                    _State.ValueIndicatorController.Forward();
                    _State.InteractionTimer?.Cancel();
                    _State.InteractionTimer = new Timer(_MinimumInteractionTime * BindingDefaultClass.TimeDilation, () =>
                    {
                        _State.InteractionTimer = null;
                        if (!_Active && _State.ValueIndicatorController.Status == AnimationStatus.Completed)
                        {
                            _State.ValueIndicatorController.Reverse();
                        }

                    }
                    );
                }

            }

        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            double dragValue = _GetValueFromGlobalPosition(details.GlobalPosition);
            bool shouldCallOnChangeStart = false;
            if (_LastThumbSelection == null)
            {
                _LastThumbSelection = SliderTheme.ThumbSelector(TextDirection, Values, dragValue, _ThumbSize, Size, details.Delta.Dx);
                if (_LastThumbSelection != null)
                {
                    shouldCallOnChangeStart = true;
                    _Active = true;
                    _State.OverlayController.Forward();
                    if (ShowValueIndicator)
                    {
                        _State.ValueIndicatorController.Forward();
                    }

                }

            }

            if (IsEnabled && _LastThumbSelection != null)
            {
                RangeValues currentValues = _DiscretizeRangeValues(Values);
                if (OnChangeStart != null && shouldCallOnChangeStart)
                {
                    OnChangeStart(currentValues);
                }

                double currentDragValue = _Discretize(dragValue);
                double minThumbSeparationValue = IsDiscrete ? 0 : SliderTheme.MinThumbSeparation / _TrackRect.Width;
                if (_LastThumbSelection == Thumb.Start)
                {
                    _NewValues = new RangeValues(Dart.Math.MathDefaultClass.Min(currentDragValue, currentValues.End - minThumbSeparationValue), currentValues.End);
                }
                else if (_LastThumbSelection == Thumb.End)
                {
                    _NewValues = new RangeValues(currentValues.Start, Dart.Math.MathDefaultClass.Max(currentDragValue, currentValues.Start + minThumbSeparationValue));
                }

                OnChanged(_NewValues);
            }

        }




        private void _EndInteraction()
        {
            _State.OverlayController.Reverse();
            if (ShowValueIndicator && _State.InteractionTimer == null)
            {
                _State.ValueIndicatorController.Reverse();
            }

            if (_Active && _State.Mounted && _LastThumbSelection != null)
            {
                RangeValues discreteValues = _DiscretizeRangeValues(_NewValues);
                if (OnChangeEnd != null)
                {
                    OnChangeEnd(discreteValues);
                }

                _Active = false;
            }

        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {
            _StartInteraction(details.GlobalPosition);
        }




        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            _EndInteraction();
        }




        private void _HandleDragCancel()
        {
            _EndInteraction();
        }




        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
        {
            _StartInteraction(details.GlobalPosition);
        }




        private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            _EndInteraction();
        }




        private void _HandleTapCancel()
        {
            _EndInteraction();
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry)
        {

            if (@event is PointerDownEvent && IsEnabled)
            {
                _Drag.AddPointer(((PointerDownEvent)@event));
                _Tap.AddPointer(((PointerDownEvent)@event));
            }

        }




        public new double ComputeMinIntrinsicWidth(double height) => _MinPreferredTrackWidth + _MaxSliderPartWidth;



        public new double ComputeMaxIntrinsicWidth(double height) => _MinPreferredTrackWidth + _MaxSliderPartWidth;



        public new double ComputeMinIntrinsicHeight(double width) => Dart.Math.MathDefaultClass.Max(_MinPreferredTrackHeight, _MaxSliderPartHeight);



        public new double ComputeMaxIntrinsicHeight(double width) => Dart.Math.MathDefaultClass.Max(_MinPreferredTrackHeight, _MaxSliderPartHeight);



        public new void PerformResize()
        {
            Size = new Size(Constraints.HasBoundedWidth ? Constraints.MaxWidth : _MinPreferredTrackWidth + _MaxSliderPartWidth, Constraints.HasBoundedHeight ? Constraints.MaxHeight : Dart.Math.MathDefaultClass.Max(_MinPreferredTrackHeight, _MaxSliderPartHeight));
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            double startValue = _State.StartPositionController.Value;
            double endValue = _State.EndPositionController.Value;
            double startVisualPosition = default(double);
            double endVisualPosition = default(double);
            switch (TextDirection) { case TextDirection.Rtl: startVisualPosition = 1.0 - startValue; endVisualPosition = 1.0 - endValue; break; case TextDirection.Ltr: startVisualPosition = startValue; endVisualPosition = endValue; break; }
            Rect trackRect = _SliderTheme.RangeTrackShape.GetPreferredRect(parentBox: this, offset: offset, sliderTheme: _SliderTheme, isDiscrete: IsDiscrete);
            Offset startThumbCenter = new Offset(trackRect.Left + startVisualPosition * trackRect.Width, trackRect.Center.Dy);
            Offset endThumbCenter = new Offset(trackRect.Left + endVisualPosition * trackRect.Width, trackRect.Center.Dy);
            _SliderTheme.RangeTrackShape.Paint(context, offset, parentBox: this, sliderTheme: _SliderTheme, enableAnimation: _EnableAnimation, textDirection: _TextDirection, startThumbCenter: startThumbCenter, endThumbCenter: endThumbCenter, isDiscrete: IsDiscrete, isEnabled: IsEnabled);
            if (!_OverlayAnimation.IsDismissed)
            {
                if (_LastThumbSelection == Thumb.Start)
                {
                    _SliderTheme.OverlayShape.Paint(context, startThumbCenter, activationAnimation: _OverlayAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, labelPainter: _StartLabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, value: startValue);
                }

                if (_LastThumbSelection == Thumb.End)
                {
                    _SliderTheme.OverlayShape.Paint(context, endThumbCenter, activationAnimation: _OverlayAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, labelPainter: _EndLabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, value: endValue);
                }

            }

            if (IsDiscrete)
            {
                double tickMarkWidth = _SliderTheme.RangeTickMarkShape.GetPreferredSize(isEnabled: IsEnabled, sliderTheme: _SliderTheme).Width;
                double adjustedTrackWidth = trackRect.Width - tickMarkWidth;
                if (adjustedTrackWidth / Divisions >= 3.0 * tickMarkWidth)
                {
                    double dy = trackRect.Center.Dy;
                    for (int i = 0; i <= Divisions; i++)
                    {
                        double value = i / Divisions;
                        double dx = trackRect.Left + value * adjustedTrackWidth + tickMarkWidth / 2;
                        Offset tickMarkOffset = new Offset(dx, dy);
                        _SliderTheme.RangeTickMarkShape.Paint(context, tickMarkOffset, parentBox: this, sliderTheme: _SliderTheme, enableAnimation: _EnableAnimation, textDirection: _TextDirection, startThumbCenter: startThumbCenter, endThumbCenter: endThumbCenter, isEnabled: IsEnabled);
                    }

                }

            }

            double thumbDelta = (endThumbCenter.Dx - startThumbCenter.Dx).Abs();
            bool isLastThumbStart = _LastThumbSelection == Thumb.Start;
            Thumb bottomThumb = isLastThumbStart ? Thumb.End : Thumb.Start;
            Thumb topThumb = isLastThumbStart ? Thumb.Start : Thumb.End;
            Offset bottomThumbCenter = isLastThumbStart ? endThumbCenter : startThumbCenter;
            Offset topThumbCenter = isLastThumbStart ? startThumbCenter : endThumbCenter;
            TextPainter bottomLabelPainter = isLastThumbStart ? _EndLabelPainter : _StartLabelPainter;
            TextPainter topLabelPainter = isLastThumbStart ? _StartLabelPainter : _EndLabelPainter;
            double bottomValue = isLastThumbStart ? endValue : startValue;
            double topValue = isLastThumbStart ? startValue : endValue;
            bool shouldPaintValueIndicators = IsEnabled && Labels != null && !_ValueIndicatorAnimation.IsDismissed && ShowValueIndicator;
            if (shouldPaintValueIndicators)
            {
                _SliderTheme.RangeValueIndicatorShape.Paint(context, bottomThumbCenter, activationAnimation: _ValueIndicatorAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, isOnTop: false, labelPainter: bottomLabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, thumb: bottomThumb, value: bottomValue);
            }

            _SliderTheme.RangeThumbShape.Paint(context, bottomThumbCenter, activationAnimation: _ValueIndicatorAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, isOnTop: false, textDirection: TextDirection, sliderTheme: _SliderTheme, thumb: bottomThumb);
            if (shouldPaintValueIndicators)
            {
                double startOffset = SliderTheme.RangeValueIndicatorShape.GetHorizontalShift(parentBox: this, center: startThumbCenter, labelPainter: _StartLabelPainter, activationAnimation: _ValueIndicatorAnimation);
                double endOffset = SliderTheme.RangeValueIndicatorShape.GetHorizontalShift(parentBox: this, center: endThumbCenter, labelPainter: _EndLabelPainter, activationAnimation: _ValueIndicatorAnimation);
                double startHalfWidth = SliderTheme.RangeValueIndicatorShape.GetPreferredSize(IsEnabled, IsDiscrete, labelPainter: _StartLabelPainter).Width / 2;
                double endHalfWidth = SliderTheme.RangeValueIndicatorShape.GetPreferredSize(IsEnabled, IsDiscrete, labelPainter: _EndLabelPainter).Width / 2;
                double innerOverflow = startHalfWidth + endHalfWidth;
                switch (TextDirection) { case TextDirection.Ltr: innerOverflow += startOffset; innerOverflow -= endOffset; break; case TextDirection.Rtl: innerOverflow -= startOffset; innerOverflow += endOffset; break; }
                _SliderTheme.RangeValueIndicatorShape.Paint(context, topThumbCenter, activationAnimation: _ValueIndicatorAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, isOnTop: thumbDelta < innerOverflow, labelPainter: topLabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, thumb: topThumb, value: topValue);
            }

            _SliderTheme.RangeThumbShape.Paint(context, topThumbCenter, activationAnimation: _ValueIndicatorAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, isOnTop: thumbDelta < SliderTheme.RangeThumbShape.GetPreferredSize(IsEnabled, IsDiscrete).Width, textDirection: TextDirection, sliderTheme: _SliderTheme, thumb: topThumb);
        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.IsSemanticBoundary = IsEnabled;
            if (IsEnabled)
            {
                config.TextDirection = TextDirection;
                config.CustomSemanticsActions = new Dictionary<CustomSemanticsAction, VoidCallback> { { _DecreaseStart, _DecreaseStartAction }{ _IncreaseStart, _IncreaseStartAction }{ _DecreaseEnd, _DecreaseEndAction }{ _IncreaseEnd, _IncreaseEndAction } };
                if (SemanticFormatterCallback != null)
                {
                    config.Value = SemanticFormatterCallback(_State._LerpRangeValues(Values));
                }
                else
                {
                    config.Value = Values.ToString();
                }

            }

        }




        private void _IncreaseStartAction()
        {
            if (IsEnabled)
            {
                OnChanged(new RangeValues(_IncreaseValue(Values.Start), Values.End));
            }

        }




        private void _DecreaseStartAction()
        {
            if (IsEnabled)
            {
                OnChanged(new RangeValues(_DecreaseValue(Values.Start), Values.End));
            }

        }




        private void _IncreaseEndAction()
        {
            if (IsEnabled)
            {
                OnChanged(new RangeValues(Values.Start, _IncreaseValue(Values.End)));
            }

        }




        private void _DecreaseEndAction()
        {
            if (IsEnabled)
            {
                OnChanged(new RangeValues(Values.Start, _DecreaseValue(Values.End)));
            }

        }




        private double _IncreaseValue(double value)
        {
            return (value + _SemanticActionUnit).Clamp(0.0, 1.0) as double;
        }




        private double _DecreaseValue(double value)
        {
            return (value - _SemanticActionUnit).Clamp(0.0, 1.0) as double;
        }



    }

}
