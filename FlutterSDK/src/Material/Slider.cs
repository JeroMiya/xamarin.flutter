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
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using FlutterSDK.Scheduler;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
namespace FlutterSDK.Material.Slider
{
    public delegate string SemanticFormatterCallback(double value);
    internal static class SliderDefaultClass
    {
    }

    /// <Summary>
    /// A Material Design slider.
    ///
    /// Used to select from a range of values.
    ///
    /// A slider can be used to select from either a continuous or a discrete set of
    /// values. The default is to use a continuous range of values from [min] to
    /// [max]. To use discrete values, use a non-null value for [divisions], which
    /// indicates the number of discrete intervals. For example, if [min] is 0.0 and
    /// [max] is 50.0 and [divisions] is 5, then the slider can take on the
    /// discrete values 0.0, 10.0, 20.0, 30.0, 40.0, and 50.0.
    ///
    /// The terms for the parts of a slider are:
    ///
    ///  * The "thumb", which is a shape that slides horizontally when the user
    ///    drags it.
    ///  * The "track", which is the line that the slider thumb slides along.
    ///  * The "value indicator", which is a shape that pops up when the user
    ///    is dragging the thumb to indicate the value being selected.
    ///  * The "active" side of the slider is the side between the thumb and the
    ///    minimum value.
    ///  * The "inactive" side of the slider is the side between the thumb and the
    ///    maximum value.
    ///
    /// The slider will be disabled if [onChanged] is null or if the range given by
    /// [min]..[max] is empty (i.e. if [min] is equal to [max]).
    ///
    /// The slider widget itself does not maintain any state. Instead, when the state
    /// of the slider changes, the widget calls the [onChanged] callback. Most
    /// widgets that use a slider will listen for the [onChanged] callback and
    /// rebuild the slider with a new [value] to update the visual appearance of the
    /// slider. To know when the value starts to change, or when it is done
    /// changing, set the optional callbacks [onChangeStart] and/or [onChangeEnd].
    ///
    /// By default, a slider will be as wide as possible, centered vertically. When
    /// given unbounded constraints, it will attempt to make the track 144 pixels
    /// wide (with margins on each side) and will shrink-wrap vertically.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// Requires one of its ancestors to be a [MediaQuery] widget. Typically, these
    /// are introduced by the [MaterialApp] or [WidgetsApp] widget at the top of
    /// your application widget tree.
    ///
    /// To determine how it should be displayed (e.g. colors, thumb shape, etc.),
    /// a slider uses the [SliderThemeData] available from either a [SliderTheme]
    /// widget or the [ThemeData.sliderTheme] a [Theme] widget above it in the
    /// widget tree. You can also override some of the colors with the [activeColor]
    /// and [inactiveColor] properties, although more fine-grained control of the
    /// look is achieved using a [SliderThemeData].
    ///
    /// See also:
    ///
    ///  * [SliderTheme] and [SliderThemeData] for information about controlling
    ///    the visual appearance of the slider.
    ///  * [Radio], for selecting among a set of explicit values.
    ///  * [Checkbox] and [Switch], for toggling a particular value on or off.
    ///  * <https://material.io/design/components/sliders.html>
    ///  * [MediaQuery], from which the text scale factor is obtained.
    /// </Summary>
    public class Slider : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Slider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), double min = 0.0, double max = 1.0, int divisions = default(int), string label = default(string), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Slider.SemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slider.SemanticFormatterCallback))
        : base(key: key)
    
}
    public static Slider Adaptive(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), double min = 0.0, double max = 1.0, int divisions = default(int), string label = default(string), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Slider.SemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slider.SemanticFormatterCallback))

}
#endregion

#region fields
public virtual double Value { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
public virtual double Min { get; set; }
public virtual double Max { get; set; }
public virtual int Divisions { get; set; }
public virtual string Label { get; set; }
public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
public virtual FlutterSDK.Material.Slider.SemanticFormatterCallback SemanticFormatterCallback { get; set; }
internal virtual FlutterSDK.Material.Slider._SliderType _SliderType { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Slider._SliderState CreateState() => new _SliderState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("value", Value));
    properties.Add(new ObjectFlagProperty<ValueChanged<double>>("onChanged", OnChanged, ifNull: "disabled"));
    properties.Add(ObjectFlagProperty<ValueChanged<double>>.Has("onChangeStart", OnChangeStart));
    properties.Add(ObjectFlagProperty<ValueChanged<double>>.Has("onChangeEnd", OnChangeEnd));
    properties.Add(new DoubleProperty("min", Min));
    properties.Add(new DoubleProperty("max", Max));
    properties.Add(new IntProperty("divisions", Divisions));
    properties.Add(new StringProperty("label", Label));
    properties.Add(new ColorProperty("activeColor", ActiveColor));
    properties.Add(new ColorProperty("inactiveColor", InactiveColor));
    properties.Add(ObjectFlagProperty<ValueChanged<double>>.Has("semanticFormatterCallback", SemanticFormatterCallback));
}



#endregion
}


public class _SliderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Slider.Slider>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _SliderState()
    { }
    #endregion

    #region fields
    public virtual TimeSpan EnableAnimationDuration { get; set; }
    public virtual TimeSpan ValueIndicatorAnimationDuration { get; set; }
    public virtual FlutterSDK.Animation.Animationcontroller.AnimationController OverlayController { get; set; }
    public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ValueIndicatorController { get; set; }
    public virtual FlutterSDK.Animation.Animationcontroller.AnimationController EnableController { get; set; }
    public virtual FlutterSDK.Animation.Animationcontroller.AnimationController PositionController { get; set; }
    public virtual Timer InteractionTimer { get; set; }
    internal virtual double _DefaultTrackHeight { get; set; }
    internal virtual FlutterSDK.Material.Slidertheme.SliderTrackShape _DefaultTrackShape { get; set; }
    internal virtual FlutterSDK.Material.Slidertheme.SliderTickMarkShape _DefaultTickMarkShape { get; set; }
    internal virtual FlutterSDK.Material.Slidertheme.SliderComponentShape _DefaultOverlayShape { get; set; }
    internal virtual FlutterSDK.Material.Slidertheme.SliderComponentShape _DefaultThumbShape { get; set; }
    internal virtual FlutterSDK.Material.Slidertheme.SliderComponentShape _DefaultValueIndicatorShape { get; set; }
    internal virtual FlutterSDK.Material.Slidertheme.ShowValueIndicator _DefaultShowValueIndicator { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        OverlayController = new AnimationController(duration: ConstantsDefaultClass.KRadialReactionDuration, vsync: this);
        ValueIndicatorController = new AnimationController(duration: ValueIndicatorAnimationDuration, vsync: this);
        EnableController = new AnimationController(duration: EnableAnimationDuration, vsync: this);
        PositionController = new AnimationController(duration: Dart:coreDefaultClass.Duration.Zero, vsync: this);
        EnableController.Value = Widget.OnChanged != null ? 1.0 : 0.0;
        PositionController.Value = _Unlerp(Widget.Value);
    }




    public new void Dispose()
    {
        InteractionTimer?.Cancel();
        OverlayController.Dispose();
        ValueIndicatorController.Dispose();
        EnableController.Dispose();
        PositionController.Dispose();
        base.Dispose();
    }




    private void _HandleChanged(double value)
    {

        double lerpValue = _Lerp(value);
        if (lerpValue != Widget.Value)
        {
            Widget.OnChanged(lerpValue);
        }

    }




    private void _HandleDragStart(double value)
    {

        Widget.OnChangeStart(_Lerp(value));
    }




    private void _HandleDragEnd(double value)
    {

        Widget.OnChangeEnd(_Lerp(value));
    }




    private double _Lerp(double value)
    {


        return value * (Widget.Max - Widget.Min) + Widget.Min;
    }




    private double _Unlerp(double value)
    {


        return Widget.Max > Widget.Min ? (value - Widget.Min) / (Widget.Max - Widget.Min) : 0.0;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {


        switch (Widget._SliderType)
        {
            case _SliderType.Material: return _BuildMaterialSlider(context);
            case _SliderType.Adaptive:
                {
                    ThemeData theme = ThemeDefaultClass.Theme.Of(context);

                    switch (theme.Platform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: return _BuildMaterialSlider(context); case TargetPlatform.IOS: case TargetPlatform.MacOS: return _BuildCupertinoSlider(context); }
                }
        }

        return null;
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildMaterialSlider(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        SliderThemeData sliderTheme = SliderthemeDefaultClass.SliderTheme.Of(context);
        sliderTheme = sliderTheme.CopyWith(trackHeight: sliderTheme.TrackHeight ?? _DefaultTrackHeight, activeTrackColor: Widget.ActiveColor ?? sliderTheme.ActiveTrackColor ?? theme.ColorScheme.Primary, inactiveTrackColor: Widget.InactiveColor ?? sliderTheme.InactiveTrackColor ?? theme.ColorScheme.Primary.WithOpacity(0.24), disabledActiveTrackColor: sliderTheme.DisabledActiveTrackColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.32), disabledInactiveTrackColor: sliderTheme.DisabledInactiveTrackColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.12), activeTickMarkColor: Widget.InactiveColor ?? sliderTheme.ActiveTickMarkColor ?? theme.ColorScheme.OnPrimary.WithOpacity(0.54), inactiveTickMarkColor: Widget.ActiveColor ?? sliderTheme.InactiveTickMarkColor ?? theme.ColorScheme.Primary.WithOpacity(0.54), disabledActiveTickMarkColor: sliderTheme.DisabledActiveTickMarkColor ?? theme.ColorScheme.OnPrimary.WithOpacity(0.12), disabledInactiveTickMarkColor: sliderTheme.DisabledInactiveTickMarkColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.12), thumbColor: Widget.ActiveColor ?? sliderTheme.ThumbColor ?? theme.ColorScheme.Primary, disabledThumbColor: sliderTheme.DisabledThumbColor ?? theme.ColorScheme.OnSurface.WithOpacity(0.38), overlayColor: Widget.ActiveColor?.WithOpacity(0.12) ?? sliderTheme.OverlayColor ?? theme.ColorScheme.Primary.WithOpacity(0.12), valueIndicatorColor: Widget.ActiveColor ?? sliderTheme.ValueIndicatorColor ?? theme.ColorScheme.Primary, trackShape: sliderTheme.TrackShape ?? _DefaultTrackShape, tickMarkShape: sliderTheme.TickMarkShape ?? _DefaultTickMarkShape, thumbShape: sliderTheme.ThumbShape ?? _DefaultThumbShape, overlayShape: sliderTheme.OverlayShape ?? _DefaultOverlayShape, valueIndicatorShape: sliderTheme.ValueIndicatorShape ?? _DefaultValueIndicatorShape, showValueIndicator: sliderTheme.ShowValueIndicator ?? _DefaultShowValueIndicator, valueIndicatorTextStyle: sliderTheme.ValueIndicatorTextStyle ?? theme.TextTheme.BodyText1.CopyWith(color: theme.ColorScheme.OnPrimary));
        return new _SliderRenderObjectWidget(value: _Unlerp(Widget.Value), divisions: Widget.Divisions, label: Widget.Label, sliderTheme: sliderTheme, mediaQueryData: MediaqueryDefaultClass.MediaQuery.Of(context), onChanged: (Widget.OnChanged != null) && (Widget.Max > Widget.Min) ? _HandleChanged : null, onChangeStart: Widget.OnChangeStart != null ? _HandleDragStart : null, onChangeEnd: Widget.OnChangeEnd != null ? _HandleDragEnd : null, state: this, semanticFormatterCallback: Widget.SemanticFormatterCallback);
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildCupertinoSlider(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new SizedBox(width: Dart:coreDefaultClass.Double.Infinity, child: new CupertinoSlider(value: Widget.Value, onChanged: Widget.OnChanged, onChangeStart: Widget.OnChangeStart, onChangeEnd: Widget.OnChangeEnd, min: Widget.Min, max: Widget.Max, divisions: Widget.Divisions, activeColor: Widget.ActiveColor));
    }



    #endregion
}


public class _SliderRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
{
    #region constructors
    public _SliderRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), int divisions = default(int), string label = default(string), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Widgets.Mediaquery.MediaQueryData mediaQueryData = default(FlutterSDK.Widgets.Mediaquery.MediaQueryData), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Material.Slider._SliderState state = default(FlutterSDK.Material.Slider._SliderState), FlutterSDK.Material.Slider.SemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slider.SemanticFormatterCallback))
    : base(key: key)

}
#endregion

#region fields
public virtual double Value { get; set; }
public virtual int Divisions { get; set; }
public virtual string Label { get; set; }
public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme { get; set; }
public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData MediaQueryData { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
public virtual FlutterSDK.Material.Slider.SemanticFormatterCallback SemanticFormatterCallback { get; set; }
public virtual FlutterSDK.Material.Slider._SliderState State { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Slider._RenderSlider CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderSlider(value: Value, divisions: Divisions, label: Label, sliderTheme: SliderTheme, mediaQueryData: MediaQueryData, onChanged: OnChanged, onChangeStart: OnChangeStart, onChangeEnd: OnChangeEnd, state: State, textDirection: BasicDefaultClass.Directionality.Of(context), semanticFormatterCallback: SemanticFormatterCallback, platform: ThemeDefaultClass.Theme.Of(context).Platform);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Slider._RenderSlider renderObject)
{
    ..Value = Value..Divisions = Divisions..Label = Label..SliderTheme = SliderTheme..Theme = ThemeDefaultClass.Theme.Of(context)..MediaQueryData = MediaQueryData..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context)..SemanticFormatterCallback = SemanticFormatterCallback..Platform = ThemeDefaultClass.Theme.Of(context).Platform;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    ..Value = Value..Divisions = Divisions..Label = Label..SliderTheme = SliderTheme..Theme = ThemeDefaultClass.Theme.Of(context)..MediaQueryData = MediaQueryData..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context)..SemanticFormatterCallback = SemanticFormatterCallback..Platform = ThemeDefaultClass.Theme.Of(context).Platform;
}



#endregion
}


public class _RenderSlider : FlutterSDK.Rendering.Box.RenderBox, IRelayoutWhenSystemFontsChangeMixin
{
    #region constructors
    public _RenderSlider(double value = default(double), int divisions = default(int), string label = default(string), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Widgets.Mediaquery.MediaQueryData mediaQueryData = default(FlutterSDK.Widgets.Mediaquery.MediaQueryData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Material.Slider.SemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slider.SemanticFormatterCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Material.Slider._SliderState state = default(FlutterSDK.Material.Slider._SliderState), TextDirection textDirection = default(TextDirection))
    : base()

_UpdateLabelPainter();
    GestureArenaTeam team = new GestureArenaTeam();
    _Drag=new HorizontalDragGestureRecognizer()..Team=team..OnStart=_HandleDragStart..OnUpdate=_HandleDragUpdate..OnEnd=_HandleDragEnd..OnCancel=_EndInteraction;
_Tap=new TapGestureRecognizer()..Team=team..OnTapDown=_HandleTapDown..OnTapUp=_HandleTapUp..OnTapCancel=_EndInteraction;
_OverlayAnimation=new CurvedAnimation(parent:_State.OverlayController, curve:CurvesDefaultClass.Curves.FastOutSlowIn);
    _ValueIndicatorAnimation=new CurvedAnimation(parent:_State.ValueIndicatorController, curve:CurvesDefaultClass.Curves.FastOutSlowIn);
    _EnableAnimation=new CurvedAnimation(parent:_State.EnableController, curve:CurvesDefaultClass.Curves.EaseInOut);
}


#endregion

#region fields
internal virtual TimeSpan _PositionAnimationDuration { get; set; }
internal virtual TimeSpan _MinimumInteractionTime { get; set; }
internal virtual double _MinPreferredTrackWidth { get; set; }
internal virtual FlutterSDK.Material.Slider._SliderState _State { get; set; }
internal virtual FlutterSDK.Animation.Animation.Animation<double> _OverlayAnimation { get; set; }
internal virtual FlutterSDK.Animation.Animation.Animation<double> _ValueIndicatorAnimation { get; set; }
internal virtual FlutterSDK.Animation.Animation.Animation<double> _EnableAnimation { get; set; }
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _LabelPainter { get; set; }
internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag { get; set; }
internal virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer _Tap { get; set; }
internal virtual bool _Active { get; set; }
internal virtual double _CurrentDragValue { get; set; }
internal virtual double _Value { get; set; }
internal virtual FlutterSDK.Foundation.Platform.TargetPlatform _Platform { get; set; }
internal virtual FlutterSDK.Material.Slider.SemanticFormatterCallback _SemanticFormatterCallback { get; set; }
internal virtual int _Divisions { get; set; }
internal virtual string _Label { get; set; }
internal virtual FlutterSDK.Material.Slidertheme.SliderThemeData _SliderTheme { get; set; }
internal virtual FlutterSDK.Material.Themedata.ThemeData _Theme { get; set; }
internal virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData _MediaQueryData { get; set; }
internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> _OnChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
internal virtual double _MaxSliderPartWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _MaxSliderPartHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual List<Size> _SliderPartSizes { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _MinPreferredTrackHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual FlutterBinding.UI.Rect _TrackRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IsInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IsDiscrete { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Foundation.Platform.TargetPlatform Platform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Material.Slider.SemanticFormatterCallback SemanticFormatterCallback { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int Divisions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Material.Themedata.ThemeData Theme { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData MediaQueryData { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ShowValueIndicator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _AdjustmentUnit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _SemanticActionUnit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _UpdateLabelPainter()
{
    if (Label != null)
    {
        ..Text = new TextSpan(style: _SliderTheme.ValueIndicatorTextStyle, text: Label)..TextDirection = TextDirection..TextScaleFactor = _MediaQueryData.TextScaleFactor;
        _LabelPainter.Layout();
    }
    else
    {
        _LabelPainter.Text = null;
    }

    MarkNeedsLayout();
}




public new void SystemFontsDidChange()
{
    base.SystemFontsDidChange();
    _LabelPainter.MarkNeedsLayout();
    _UpdateLabelPainter();
}




public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    _OverlayAnimation.AddListener(MarkNeedsPaint);
    _ValueIndicatorAnimation.AddListener(MarkNeedsPaint);
    _EnableAnimation.AddListener(MarkNeedsPaint);
    _State.PositionController.AddListener(MarkNeedsPaint);
}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    _OverlayAnimation.AddListener(MarkNeedsPaint);
    _ValueIndicatorAnimation.AddListener(MarkNeedsPaint);
    _EnableAnimation.AddListener(MarkNeedsPaint);
    _State.PositionController.AddListener(MarkNeedsPaint);
}




public new void Detach()
{
    _OverlayAnimation.RemoveListener(MarkNeedsPaint);
    _ValueIndicatorAnimation.RemoveListener(MarkNeedsPaint);
    _EnableAnimation.RemoveListener(MarkNeedsPaint);
    _State.PositionController.RemoveListener(MarkNeedsPaint);
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




private void _StartInteraction(FlutterBinding.UI.Offset globalPosition)
{
    if (IsInteractive)
    {
        _Active = true;
        if (OnChangeStart != null)
        {
            OnChangeStart(_Discretize(Value));
        }

        _CurrentDragValue = _GetValueFromGlobalPosition(globalPosition);
        OnChanged(_Discretize(_CurrentDragValue));
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




private void _EndInteraction()
{
    if (_Active && _State.Mounted)
    {
        if (OnChangeEnd != null)
        {
            OnChangeEnd(_Discretize(_CurrentDragValue));
        }

        _Active = false;
        _CurrentDragValue = 0.0;
        _State.OverlayController.Reverse();
        if (ShowValueIndicator && _State.InteractionTimer == null)
        {
            _State.ValueIndicatorController.Reverse();
        }

    }

}




private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) => _StartInteraction(details.GlobalPosition);



private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
{
    if (IsInteractive)
    {
        double valueDelta = details.PrimaryDelta / _TrackRect.Width;
        switch (TextDirection) { case TextDirection.Rtl: _CurrentDragValue -= valueDelta; break; case TextDirection.Ltr: _CurrentDragValue += valueDelta; break; }
        OnChanged(_Discretize(_CurrentDragValue));
    }

}




private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) => _EndInteraction();



private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) => _StartInteraction(details.GlobalPosition);



private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) => _EndInteraction();



public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
{

    if (@event is PointerDownEvent && IsInteractive)
    {
        _Drag.AddPointer(((PointerDownEvent)@event));
        _Tap.AddPointer(((PointerDownEvent)@event));
    }

}




public new double ComputeMinIntrinsicWidth(double height) => _MinPreferredTrackWidth + _MaxSliderPartWidth;



public new double ComputeMaxIntrinsicWidth(double height) => _MinPreferredTrackWidth + _MaxSliderPartWidth;



public new double ComputeMinIntrinsicHeight(double width) => Dart:mathDefaultClass.Max(_MinPreferredTrackHeight, _MaxSliderPartHeight);



public new double ComputeMaxIntrinsicHeight(double width) => Dart:mathDefaultClass.Max(_MinPreferredTrackHeight, _MaxSliderPartHeight);



public new void PerformResize()
{
    Size = new Size(Constraints.HasBoundedWidth ? Constraints.MaxWidth : _MinPreferredTrackWidth + _MaxSliderPartWidth, Constraints.HasBoundedHeight ? Constraints.MaxHeight : Dart:mathDefaultClass.Max(_MinPreferredTrackHeight, _MaxSliderPartHeight));
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    double value = _State.PositionController.Value;
    double visualPosition = default(double);
    switch (TextDirection) { case TextDirection.Rtl: visualPosition = 1.0 - value; break; case TextDirection.Ltr: visualPosition = value; break; }
    Rect trackRect = _SliderTheme.TrackShape.GetPreferredRect(parentBox: this, offset: offset, sliderTheme: _SliderTheme, isDiscrete: IsDiscrete);
    Offset thumbCenter = new Offset(trackRect.Left + visualPosition * trackRect.Width, trackRect.Center.Dy);
    _SliderTheme.TrackShape.Paint(context, offset, parentBox: this, sliderTheme: _SliderTheme, enableAnimation: _EnableAnimation, textDirection: _TextDirection, thumbCenter: thumbCenter, isDiscrete: IsDiscrete, isEnabled: IsInteractive);
    if (!_OverlayAnimation.IsDismissed)
    {
        _SliderTheme.OverlayShape.Paint(context, thumbCenter, activationAnimation: _OverlayAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, labelPainter: _LabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, value: _Value);
    }

    if (IsDiscrete)
    {
        double tickMarkWidth = _SliderTheme.TickMarkShape.GetPreferredSize(isEnabled: IsInteractive, sliderTheme: _SliderTheme).Width;
        double adjustedTrackWidth = trackRect.Width - tickMarkWidth;
        if (adjustedTrackWidth / Divisions >= 3.0 * tickMarkWidth)
        {
            double dy = trackRect.Center.Dy;
            for (int i = 0; i <= Divisions; i++)
            {
                double value = i / Divisions;
                double dx = trackRect.Left + value * adjustedTrackWidth + tickMarkWidth / 2;
                Offset tickMarkOffset = new Offset(dx, dy);
                _SliderTheme.TickMarkShape.Paint(context, tickMarkOffset, parentBox: this, sliderTheme: _SliderTheme, enableAnimation: _EnableAnimation, textDirection: _TextDirection, thumbCenter: thumbCenter, isEnabled: IsInteractive);
            }

        }

    }

    if (IsInteractive && Label != null && !_ValueIndicatorAnimation.IsDismissed)
    {
        if (ShowValueIndicator)
        {
            _SliderTheme.ValueIndicatorShape.Paint(context, thumbCenter, activationAnimation: _ValueIndicatorAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, labelPainter: _LabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, value: _Value);
        }

    }

    _SliderTheme.ThumbShape.Paint(context, thumbCenter, activationAnimation: _ValueIndicatorAnimation, enableAnimation: _EnableAnimation, isDiscrete: IsDiscrete, labelPainter: _LabelPainter, parentBox: this, sliderTheme: _SliderTheme, textDirection: _TextDirection, value: _Value);
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
        if (SemanticFormatterCallback != null)
        {
            config.Value = SemanticFormatterCallback(_State._Lerp(Value));
            config.IncreasedValue = SemanticFormatterCallback(_State._Lerp((Value + _SemanticActionUnit).Clamp(0.0, 1.0) as double));
            config.DecreasedValue = SemanticFormatterCallback(_State._Lerp((Value - _SemanticActionUnit).Clamp(0.0, 1.0) as double));
        }
        else
        {
            config.Value = $"'{(Value * 100).Round()}%'";
            config.IncreasedValue = $"'{((Value + _SemanticActionUnit).Clamp(0.0, 1.0) * 100).Round()}%'";
            config.DecreasedValue = $"'{((Value - _SemanticActionUnit).Clamp(0.0, 1.0) * 100).Round()}%'";
        }

    }

}




private void _IncreaseAction()
{
    if (IsInteractive)
    {
        OnChanged((Value + _SemanticActionUnit).Clamp(0.0, 1.0) as double);
    }

}




private void _DecreaseAction()
{
    if (IsInteractive)
    {
        OnChanged((Value - _SemanticActionUnit).Clamp(0.0, 1.0) as double);
    }

}



#endregion
}


public enum _SliderType
{

    Material,
    Adaptive,
}

}
