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
namespace FlutterSDK.Material.Slidertheme
{
    public delegate string RangeSemanticFormatterCallback(FlutterSDK.Material.Slidertheme.RangeValues values);
    public delegate FlutterSDK.Material.Slidertheme.Thumb RangeThumbSelector(TextDirection textDirection, FlutterSDK.Material.Slidertheme.RangeValues values, double tapValue, Size thumbSize, Size trackSize, double dx);
    internal static class SliderthemeDefaultClass
    {
    }

    /// <Summary>
    /// {@template flutter.material.slider.shape.center}
    /// [center] is the offset for where this shape's center should be painted.
    /// This offset is relative to the origin of the [context] canvas.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.context}
    /// [context] is the same as the one that includes the [Slider]'s render box.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.enableAnimation}
    /// [enableAnimation] is an animation triggered when the [Slider] is enabled,
    /// and it reverses when the slider is disabled. Enabled is the
    /// [Slider.isInteractive] state. Use this to paint intermediate frames for
    /// this shape when the slider changes enabled state.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.isDiscrete}
    /// [isDiscrete] is true if [Slider.divisions] is non-null. If true, the
    /// slider will render tick marks on top of the track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.isEnabled}
    /// [isEnabled] has the same value as [Slider.isInteractive]. If true, the
    /// slider will respond to input.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.parentBox}
    /// [parentBox] is the [RenderBox] of the [Slider]. Its attributes, such as
    /// size, can be used to assist in painting this shape.
    /// {@endtemplate}
    /// {@template flutter.material.slider.shape.sliderTheme}
    /// [sliderTheme] is the theme assigned to the [Slider] that this shape
    /// belongs to.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.activationAnimation}
    /// [activationAnimation] is an animation triggered when the user begins
    /// to interact with the [RangeSlider]. It reverses when the user stops
    /// interacting with the slider.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.context}
    /// [context] is the same as the one that includes the [RangeSlider]'s render
    /// box.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.enableAnimation}
    /// [enableAnimation] is an animation triggered when the [RangeSlider] is
    /// enabled, and it reverses when the slider is disabled. Enabled is the
    /// [RangeSlider.isEnabled] state. Use this to paint intermediate frames for
    /// this shape when the slider changes enabled state.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.isDiscrete}
    /// [isDiscrete] is true if [RangeSlider.divisions] is non-null. If true, the
    /// slider will render tick marks on top of the track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.isEnabled}
    /// [isEnabled] has the same value as [RangeSlider.isEnabled]. If true, the
    /// slider will respond to input.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.parentBox}
    /// [parentBox] is the [RenderBox] of the [RangeSlider]. Its attributes, such as
    /// size, can be used to assist in painting this shape.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.sliderTheme}
    /// [sliderTheme] is the theme assigned to the [RangeSlider] that this shape
    /// belongs to.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.thumb}
    /// [thumb] Is the specifier for which of the two thumbs this method should
    /// paint, start or end.
    /// {@endtemplate}
    /// Base class for slider thumb, thumb overlay, and value indicator shapes.
    ///
    /// Create a subclass of this if you would like a custom shape.
    ///
    /// All shapes are painted to the same canvas and ordering is important.
    /// The overlay is painted first, then the value indicator, then the thumb.
    ///
    /// The thumb painting can be skipped by specifying [noThumb] for
    /// [SliderThemeData.thumbShape].
    ///
    /// The overlay painting can be skipped by specifying [noOverlay] for
    /// [SliderThemeData.overlayShape].
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.roundSliderOverlayShape}
    /// {@macro flutter.material.slider.seeAlso.paddleSliderValueIndicatorShape}
    /// </Summary>
    public interface ISliderComponentShape
    {
        Size GetPreferredSize(bool isEnabled, bool isDiscrete);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double));
        FlutterSDK.Material.Slidertheme.SliderComponentShape NoThumb { get; }
        FlutterSDK.Material.Slidertheme.SliderComponentShape NoOverlay { get; }
    }


    /// <Summary>
    /// Base class for [Slider] tick mark shapes.
    ///
    /// Create a subclass of this if you would like a custom slider tick mark shape.
    ///
    /// The tick mark painting can be skipped by specifying [noTickMark] for
    /// [SliderThemeData.tickMarkShape].
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public interface ISliderTickMarkShape
    {
        Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection));
        FlutterSDK.Material.Slidertheme.SliderTickMarkShape NoTickMark { get; }
    }


    /// <Summary>
    /// Base class for slider track shapes.
    ///
    /// The slider's thumb moves along the track. A discrete slider's tick marks
    /// are drawn after the track, but before the thumb, and are aligned with the
    /// track.
    ///
    /// The [getPreferredRect] helps position the slider thumb and tick marks
    /// relative to the track.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundedRectSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public interface ISliderTrackShape
    {
        Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection));
    }


    /// <Summary>
    /// Base class for [RangeSlider] thumb shapes.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundRangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public interface IRangeSliderThumbShape
    {
        Size GetPreferredSize(bool isEnabled, bool isDiscrete);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isEnabled = default(bool), bool isOnTop = default(bool), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb));
    }


    /// <Summary>
    /// Base class for [RangeSlider] value indicator shapes.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.paddleRangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public interface IRangeSliderValueIndicatorShape
    {
        Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter));
        double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isOnTop = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb));
    }


    /// <Summary>
    /// Base class for [RangeSlider] tick mark shapes.
    ///
    /// This is a simplified version of [SliderComponentShape] with a
    /// [SliderThemeData] passed when getting the preferred size.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundRangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public interface IRangeSliderTickMarkShape
    {
        Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection));
    }


    /// <Summary>
    /// Base class for [RangeSlider] track shapes.
    ///
    /// The slider's thumbs move along the track. A discrete slider's tick marks
    /// are drawn after the track, but before the thumb, and are aligned with the
    /// track.
    ///
    /// The [getPreferredRect] helps position the slider thumbs and tick marks
    /// relative to the track.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundedRectRangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public interface IRangeSliderTrackShape
    {
        Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection));
    }


    public interface IBaseSliderTrackShape { }

    public class BaseSliderTrackShape
    {

        /// <Summary>
        /// Returns a rect that represents the track bounds that fits within the
        /// [Slider].
        ///
        /// The width is the width of the [Slider] or [RangeSlider], but padded by
        /// the max  of the overlay and thumb radius. The height is defined by the
        /// [SliderThemeData.trackHeight].
        ///
        /// The [Rect] is centered both horizontally and vertically within the slider
        /// bounds.
        /// </Summary>
        public virtual Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false)
        {




            double thumbWidth = sliderTheme.ThumbShape.GetPreferredSize(isEnabled, isDiscrete).Width;
            double overlayWidth = sliderTheme.OverlayShape.GetPreferredSize(isEnabled, isDiscrete).Width;
            double trackHeight = sliderTheme.TrackHeight;




            double trackLeft = offset.Dx + overlayWidth / 2;
            double trackTop = offset.Dy + (parentBox.Size.Height - trackHeight) / 2;
            double trackWidth = parentBox.Size.Width - Math.Dart:mathDefaultClass.Max(thumbWidth, overlayWidth);
            return Rect.FromLTWH(trackLeft, trackTop, trackWidth, trackHeight);
        }



    }
    public static class BaseSliderTrackShapeMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IBaseSliderTrackShape, BaseSliderTrackShape> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IBaseSliderTrackShape, BaseSliderTrackShape>();
        static BaseSliderTrackShape GetOrCreate(IBaseSliderTrackShape instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new BaseSliderTrackShape();
                _table.Add(instance, value);
            }
            return (BaseSliderTrackShape)value;
        }
        public static Rect GetPreferredRect(this IBaseSliderTrackShape instance, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false) => GetOrCreate(instance).GetPreferredRect(parentBox, offset, sliderTheme, isEnabled, isDiscrete);
    }


    /// <Summary>
    /// {@template flutter.material.slider.seeAlso.sliderComponentShape}
    ///  * [SliderComponentShape], which can be used to create custom shapes for
    ///    the [Slider]'s thumb, overlay, and value indicator and the
    ///    [RangeSlider]'s overlay.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.sliderTrackShape}
    ///  * [SliderTrackShape], which can be used to create custom shapes for the
    ///    [Slider]'s track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.sliderTickMarkShape}
    ///  * [SliderTickMarkShape], which can be used to create custom shapes for the
    ///    [Slider]'s tick marks.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.rangeSliderThumbShape}
    ///  * [RangeSliderThumbShape], which can be used to create custom shapes for
    ///    the [RangeSlider]'s thumb.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    ///  * [RangeSliderValueIndicatorShape], which can be used to create custom
    ///    shapes for the [RangeSlider]'s value indicator.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.rangeSliderTrackShape}
    ///  * [RangeSliderTrackShape], which can be used to create custom shapes for
    ///    the [RangeSlider]'s track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    ///  * [RangeSliderTickMarkShape], which can be used to create custom shapes for
    ///    the [RangeSlider]'s tick marks.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundSliderThumbShape}
    ///  * [RoundSliderThumbShape], which is the default [Slider]'s thumb shape that
    ///     paints a solid circle.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundSliderOverlayShape}
    ///  * [RoundSliderOverlayShape], which is the default [Slider] and
    ///   [RangeSlider]'s overlay shape that paints a transparent circle.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.paddleSliderValueIndicatorShape}
    ///  * [PaddleSliderValueIndicatorShape], which is the default [Slider]'s value
    ///    indicator shape that paints a custom path with text in it.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundSliderTickMarkShape}
    ///  * [RoundSliderTickMarkShape], which is the default [Slider]'s tick mark
    ///    shape that paints a solid circle.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundedRectSliderTrackShape}
    ///  * [RoundedRectSliderTrackShape] for the default [Slider]'s track shape that
    ///  paints a stadium-like track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundRangeSliderThumbShape}
    ///  * [RoundRangeSliderThumbShape] for the default [RangeSlider]'s thumb shape
    ///    that paints a solid circle.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.paddleRangeSliderValueIndicatorShape}
    ///  * [PaddleRangeSliderValueIndicatorShape] for the default [RangeSlider]'s
    ///     value indicator shape that paints a custom path with text in it.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundRangeSliderTickMarkShape}
    ///  * [RoundRangeSliderTickMarkShape] for the default [RangeSlider]'s tick mark
    ///    shape that paints a solid circle.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.seeAlso.roundedRectRangeSliderTrackShape}
    ///  * [RoundedRectRangeSliderTrackShape] for the default [RangeSlider]'s track
    ///     shape that paints a stadium-like track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.trackSegment}
    /// The track segment between the start of the slider and the thumb is the
    /// active track segment. The track segment between the thumb and the end of the
    /// slider is the inactive track segment. In [TextDirection.ltr], the start of
    /// the slider is on the left, and in [TextDirection.rtl], the start of the
    /// slider is on the right.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.trackSegment}
    /// The track segment between the two thumbs is the active track segment. The
    /// track segments between the thumb and each end of the slider are the inactive
    /// track segments. In [TextDirection.ltr], the start of the slider is on the
    /// left, and in [TextDirection.rtl], the start of the slider is on the right.
    /// {@endtemplate}
    /// Applies a slider theme to descendant [Slider] widgets.
    ///
    /// A slider theme describes the colors and shape choices of the slider
    /// components.
    ///
    /// Descendant widgets obtain the current theme's [SliderThemeData] object using
    /// [SliderTheme.of]. When a widget uses [SliderTheme.of], it is automatically
    /// rebuilt if the theme later changes.
    ///
    /// The slider is as big as the largest of
    /// the [SliderComponentShape.getPreferredSize] of the thumb shape,
    /// the [SliderComponentShape.getPreferredSize] of the overlay shape,
    /// and the [SliderTickMarkShape.getPreferredSize] of the tick mark shape
    ///
    /// See also:
    ///
    ///  * [SliderThemeData], which describes the actual configuration of a slider
    ///    theme.
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// </Summary>
    public class SliderTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        public SliderTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Slidertheme.SliderThemeData data = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data;
        }
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData Data { get; set; }

        /// <Summary>
        /// Returns the data from the closest [SliderTheme] instance that encloses
        /// the given context.
        ///
        /// Defaults to the ambient [ThemeData.sliderTheme] if there is no
        /// [SliderTheme] in the given build context.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// class Launch extends StatefulWidget {
        ///   @override
        ///   State createState() => LaunchState();
        /// }
        ///
        /// class LaunchState extends State<Launch> {
        ///   double _rocketThrust;
        ///
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return SliderTheme(
        ///       data: SliderTheme.of(context).copyWith(activeTrackColor: const Color(0xff804040)),
        ///       child: Slider(
        ///         onChanged: (double value) { setState(() { _rocketThrust = value; }); },
        ///         value: _rocketThrust,
        ///       ),
        ///     );
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [SliderThemeData], which describes the actual configuration of a slider
        ///    theme.
        /// </Summary>
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            SliderTheme inheritedTheme = context.DependOnInheritedWidgetOfExactType();
            return inheritedTheme != null ? inheritedTheme.Data : ThemeDefaultClass.Theme.Of(context).SliderTheme;
        }




        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            SliderTheme ancestorTheme = context.FindAncestorWidgetOfExactType();
            return Dart:coreDefaultClass.Identical(this, ancestorTheme) ? child : new SliderTheme(data: Data, child: child);
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Slidertheme.SliderTheme oldWidget) => Data != oldWidget.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


    }


    /// <Summary>
    /// Holds the color, shape, and typography values for a material design slider
    /// theme.
    ///
    /// Use this class to configure a [SliderTheme] widget, or to set the
    /// [ThemeData.sliderTheme] for a [Theme] widget.
    ///
    /// To obtain the current ambient slider theme, use [SliderTheme.of].
    ///
    /// This theme is for both the [Slider] and the [RangeSlider]. The properties
    /// that are only for the [Slider] are: [tickMarkShape], [thumbShape],
    /// [trackShape], and [valueIndicatorShape]. The properties that are only for
    /// the [RangeSlider] are [rangeTickMarkShape], [rangeThumbShape],
    /// [rangeTrackShape], [rangeValueIndicatorShape],
    /// [overlappingShapeStrokeColor], [minThumbSeparation], and [thumbSelector].
    /// All other properties are used by both the [Slider] and the [RangeSlider].
    ///
    /// The parts of a slider are:
    ///
    ///  * The "thumb", which is a shape that slides horizontally when the user
    ///    drags it.
    ///  * The "track", which is the line that the slider thumb slides along.
    ///  * The "tick marks", which are regularly spaced marks that are drawn when
    ///    using discrete divisions.
    ///  * The "value indicator", which appears when the user is dragging the thumb
    ///    to indicate the value being selected.
    ///  * The "overlay", which appears around the thumb, and is shown when the
    ///    thumb is pressed, focused, or hovered. It is painted underneath the
    ///    thumb, so it must extend beyond the bounds of the thumb itself to
    ///    actually be visible.
    ///  * The "active" side of the slider is the side between the thumb and the
    ///    minimum value.
    ///  * The "inactive" side of the slider is the side between the thumb and the
    ///    maximum value.
    ///  * The [Slider] is disabled when it is not accepting user input. See
    ///    [Slider] for details on when this happens.
    ///
    /// The thumb, track, tick marks, value indicator, and overlay can be customized
    /// by creating subclasses of [SliderTrackShape],
    /// [SliderComponentShape], and/or [SliderTickMarkShape]. See
    /// [RoundSliderThumbShape], [RectangularSliderTrackShape],
    /// [RoundSliderTickMarkShape], [PaddleSliderValueIndicatorShape], and
    /// [RoundSliderOverlayShape] for examples.
    ///
    /// The track painting can be skipped by specifying 0 for [trackHeight].
    /// The thumb painting can be skipped by specifying
    /// [SliderComponentShape.noThumb] for [SliderThemeData.thumbShape].
    /// The overlay painting can be skipped by specifying
    /// [SliderComponentShape.noOverlay] for [SliderThemeData.overlayShape].
    /// The tick mark painting can be skipped by specifying
    /// [SliderTickMarkShape.noTickMark] for [SliderThemeData.tickMarkShape].
    /// The value indicator painting can be skipped by specifying the
    /// appropriate [ShowValueIndicator] for [SliderThemeData.showValueIndicator].
    ///
    /// See also:
    ///
    ///  * [SliderTheme] widget, which can override the slider theme of its
    ///    children.
    ///  * [Theme] widget, which performs a similar function to [SliderTheme],
    ///    but for overall themes.
    ///  * [ThemeData], which has a default [SliderThemeData].
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// </Summary>
    public class SliderThemeData : IDiagnosticable
    {
        public SliderThemeData(double trackHeight = default(double), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledActiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledInactiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledActiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledInactiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color overlappingShapeStrokeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color overlayColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color valueIndicatorColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Slidertheme.SliderComponentShape overlayShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.SliderTickMarkShape tickMarkShape = default(FlutterSDK.Material.Slidertheme.SliderTickMarkShape), FlutterSDK.Material.Slidertheme.SliderComponentShape thumbShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.SliderTrackShape trackShape = default(FlutterSDK.Material.Slidertheme.SliderTrackShape), FlutterSDK.Material.Slidertheme.SliderComponentShape valueIndicatorShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape rangeTickMarkShape = default(FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape), FlutterSDK.Material.Slidertheme.RangeSliderThumbShape rangeThumbShape = default(FlutterSDK.Material.Slidertheme.RangeSliderThumbShape), FlutterSDK.Material.Slidertheme.RangeSliderTrackShape rangeTrackShape = default(FlutterSDK.Material.Slidertheme.RangeSliderTrackShape), FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape rangeValueIndicatorShape = default(FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape), FlutterSDK.Material.Slidertheme.ShowValueIndicator showValueIndicator = default(FlutterSDK.Material.Slidertheme.ShowValueIndicator), FlutterSDK.Painting.Textstyle.TextStyle valueIndicatorTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), double minThumbSeparation = default(double), FlutterSDK.Material.Slidertheme.RangeThumbSelector thumbSelector = default(FlutterSDK.Material.Slidertheme.RangeThumbSelector))
        {
            this.TrackHeight = trackHeight;
            this.ActiveTrackColor = activeTrackColor;
            this.InactiveTrackColor = inactiveTrackColor;
            this.DisabledActiveTrackColor = disabledActiveTrackColor;
            this.DisabledInactiveTrackColor = disabledInactiveTrackColor;
            this.ActiveTickMarkColor = activeTickMarkColor;
            this.InactiveTickMarkColor = inactiveTickMarkColor;
            this.DisabledActiveTickMarkColor = disabledActiveTickMarkColor;
            this.DisabledInactiveTickMarkColor = disabledInactiveTickMarkColor;
            this.ThumbColor = thumbColor;
            this.OverlappingShapeStrokeColor = overlappingShapeStrokeColor;
            this.DisabledThumbColor = disabledThumbColor;
            this.OverlayColor = overlayColor;
            this.ValueIndicatorColor = valueIndicatorColor;
            this.OverlayShape = overlayShape;
            this.TickMarkShape = tickMarkShape;
            this.ThumbShape = thumbShape;
            this.TrackShape = trackShape;
            this.ValueIndicatorShape = valueIndicatorShape;
            this.RangeTickMarkShape = rangeTickMarkShape;
            this.RangeThumbShape = rangeThumbShape;
            this.RangeTrackShape = rangeTrackShape;
            this.RangeValueIndicatorShape = rangeValueIndicatorShape;
            this.ShowValueIndicator = showValueIndicator;
            this.ValueIndicatorTextStyle = valueIndicatorTextStyle;
            this.MinThumbSeparation = minThumbSeparation;
            this.ThumbSelector = thumbSelector;
        }
        public static SliderThemeData FromPrimaryColors(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle valueIndicatorTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle))
        {
            var instance = new SliderThemeData();




            int activeTrackAlpha = 0xff;
            int inactiveTrackAlpha = 0x3d;
            int disabledActiveTrackAlpha = 0x52;
            int disabledInactiveTrackAlpha = 0x1f;
            int activeTickMarkAlpha = 0x8a;
            int inactiveTickMarkAlpha = 0x8a;
            int disabledActiveTickMarkAlpha = 0x1f;
            int disabledInactiveTickMarkAlpha = 0x1f;
            int thumbAlpha = 0xff;
            int disabledThumbAlpha = 0x52;
            int overlayAlpha = 0x1f;
            int valueIndicatorAlpha = 0xff;
            return new SliderThemeData(trackHeight: 2.0, activeTrackColor: primaryColor.WithAlpha(activeTrackAlpha), inactiveTrackColor: primaryColor.WithAlpha(inactiveTrackAlpha), disabledActiveTrackColor: primaryColorDark.WithAlpha(disabledActiveTrackAlpha), disabledInactiveTrackColor: primaryColorDark.WithAlpha(disabledInactiveTrackAlpha), activeTickMarkColor: primaryColorLight.WithAlpha(activeTickMarkAlpha), inactiveTickMarkColor: primaryColor.WithAlpha(inactiveTickMarkAlpha), disabledActiveTickMarkColor: primaryColorLight.WithAlpha(disabledActiveTickMarkAlpha), disabledInactiveTickMarkColor: primaryColorDark.WithAlpha(disabledInactiveTickMarkAlpha), thumbColor: primaryColor.WithAlpha(thumbAlpha), overlappingShapeStrokeColor: ColorsDefaultClass.Colors.White, disabledThumbColor: primaryColorDark.WithAlpha(disabledThumbAlpha), overlayColor: primaryColor.WithAlpha(overlayAlpha), valueIndicatorColor: primaryColor.WithAlpha(valueIndicatorAlpha), overlayShape: new RoundSliderOverlayShape(), tickMarkShape: new RoundSliderTickMarkShape(), thumbShape: new RoundSliderThumbShape(), trackShape: new RoundedRectSliderTrackShape(), valueIndicatorShape: new PaddleSliderValueIndicatorShape(), rangeTickMarkShape: new RoundRangeSliderTickMarkShape(), rangeThumbShape: new RoundRangeSliderThumbShape(), rangeTrackShape: new RoundedRectRangeSliderTrackShape(), rangeValueIndicatorShape: new PaddleRangeSliderValueIndicatorShape(), valueIndicatorTextStyle: valueIndicatorTextStyle, showValueIndicator: ShowValueIndicator.OnlyForDiscrete);
        }


        public virtual double TrackHeight { get; set; }
        public virtual FlutterBinding.UI.Color ActiveTrackColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveTrackColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledActiveTrackColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledInactiveTrackColor { get; set; }
        public virtual FlutterBinding.UI.Color ActiveTickMarkColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveTickMarkColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledActiveTickMarkColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledInactiveTickMarkColor { get; set; }
        public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
        public virtual FlutterBinding.UI.Color OverlappingShapeStrokeColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledThumbColor { get; set; }
        public virtual FlutterBinding.UI.Color OverlayColor { get; set; }
        public virtual FlutterBinding.UI.Color ValueIndicatorColor { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape OverlayShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderTickMarkShape TickMarkShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape ThumbShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderTrackShape TrackShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape ValueIndicatorShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape RangeTickMarkShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeSliderThumbShape RangeThumbShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeSliderTrackShape RangeTrackShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape RangeValueIndicatorShape { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.ShowValueIndicator ShowValueIndicator { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ValueIndicatorTextStyle { get; set; }
        public virtual double MinThumbSeparation { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.RangeThumbSelector ThumbSelector { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData CopyWith(double trackHeight = default(double), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledActiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledInactiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledActiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledInactiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color overlappingShapeStrokeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color overlayColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color valueIndicatorColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Slidertheme.SliderComponentShape overlayShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.SliderTickMarkShape tickMarkShape = default(FlutterSDK.Material.Slidertheme.SliderTickMarkShape), FlutterSDK.Material.Slidertheme.SliderComponentShape thumbShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.SliderTrackShape trackShape = default(FlutterSDK.Material.Slidertheme.SliderTrackShape), FlutterSDK.Material.Slidertheme.SliderComponentShape valueIndicatorShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape rangeTickMarkShape = default(FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape), FlutterSDK.Material.Slidertheme.RangeSliderThumbShape rangeThumbShape = default(FlutterSDK.Material.Slidertheme.RangeSliderThumbShape), FlutterSDK.Material.Slidertheme.RangeSliderTrackShape rangeTrackShape = default(FlutterSDK.Material.Slidertheme.RangeSliderTrackShape), FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape rangeValueIndicatorShape = default(FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape), FlutterSDK.Material.Slidertheme.ShowValueIndicator showValueIndicator = default(FlutterSDK.Material.Slidertheme.ShowValueIndicator), FlutterSDK.Painting.Textstyle.TextStyle valueIndicatorTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), double minThumbSeparation = default(double), FlutterSDK.Material.Slidertheme.RangeThumbSelector thumbSelector = default(FlutterSDK.Material.Slidertheme.RangeThumbSelector))
        {
            return new SliderThemeData(trackHeight: trackHeight == default(double) ? this.trackHeight : trackHeight, activeTrackColor: activeTrackColor ?? this.ActiveTrackColor, inactiveTrackColor: inactiveTrackColor ?? this.InactiveTrackColor, disabledActiveTrackColor: disabledActiveTrackColor ?? this.DisabledActiveTrackColor, disabledInactiveTrackColor: disabledInactiveTrackColor ?? this.DisabledInactiveTrackColor, activeTickMarkColor: activeTickMarkColor ?? this.ActiveTickMarkColor, inactiveTickMarkColor: inactiveTickMarkColor ?? this.InactiveTickMarkColor, disabledActiveTickMarkColor: disabledActiveTickMarkColor ?? this.DisabledActiveTickMarkColor, disabledInactiveTickMarkColor: disabledInactiveTickMarkColor ?? this.DisabledInactiveTickMarkColor, thumbColor: thumbColor ?? this.ThumbColor, overlappingShapeStrokeColor: overlappingShapeStrokeColor ?? this.OverlappingShapeStrokeColor, disabledThumbColor: disabledThumbColor ?? this.DisabledThumbColor, overlayColor: overlayColor ?? this.OverlayColor, valueIndicatorColor: valueIndicatorColor ?? this.ValueIndicatorColor, overlayShape: overlayShape ?? this.OverlayShape, tickMarkShape: tickMarkShape ?? this.TickMarkShape, thumbShape: thumbShape ?? this.ThumbShape, trackShape: trackShape ?? this.TrackShape, valueIndicatorShape: valueIndicatorShape ?? this.ValueIndicatorShape, rangeTickMarkShape: rangeTickMarkShape ?? this.RangeTickMarkShape, rangeThumbShape: rangeThumbShape ?? this.RangeThumbShape, rangeTrackShape: rangeTrackShape ?? this.RangeTrackShape, rangeValueIndicatorShape: rangeValueIndicatorShape ?? this.RangeValueIndicatorShape, showValueIndicator: showValueIndicator ?? this.ShowValueIndicator, valueIndicatorTextStyle: valueIndicatorTextStyle ?? this.ValueIndicatorTextStyle, minThumbSeparation: minThumbSeparation == default(double) ? this.minThumbSeparation : minThumbSeparation, thumbSelector: thumbSelector ?? this.ThumbSelector);
        }




        /// <Summary>
        /// Linearly interpolate between two slider themes.
        ///
        /// The arguments must not be null.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData Lerp(FlutterSDK.Material.Slidertheme.SliderThemeData a, FlutterSDK.Material.Slidertheme.SliderThemeData b, double t)
        {



            return new SliderThemeData(trackHeight: Dart:uiDefaultClass.LerpDouble(a.TrackHeight, b.TrackHeight, t), activeTrackColor: Dart:uiDefaultClass.Color.Lerp(a.ActiveTrackColor, b.ActiveTrackColor, t), inactiveTrackColor: Dart:uiDefaultClass.Color.Lerp(a.InactiveTrackColor, b.InactiveTrackColor, t), disabledActiveTrackColor: Dart:uiDefaultClass.Color.Lerp(a.DisabledActiveTrackColor, b.DisabledActiveTrackColor, t), disabledInactiveTrackColor: Dart:uiDefaultClass.Color.Lerp(a.DisabledInactiveTrackColor, b.DisabledInactiveTrackColor, t), activeTickMarkColor: Dart:uiDefaultClass.Color.Lerp(a.ActiveTickMarkColor, b.ActiveTickMarkColor, t), inactiveTickMarkColor: Dart:uiDefaultClass.Color.Lerp(a.InactiveTickMarkColor, b.InactiveTickMarkColor, t), disabledActiveTickMarkColor: Dart:uiDefaultClass.Color.Lerp(a.DisabledActiveTickMarkColor, b.DisabledActiveTickMarkColor, t), disabledInactiveTickMarkColor: Dart:uiDefaultClass.Color.Lerp(a.DisabledInactiveTickMarkColor, b.DisabledInactiveTickMarkColor, t), thumbColor: Dart:uiDefaultClass.Color.Lerp(a.ThumbColor, b.ThumbColor, t), overlappingShapeStrokeColor: Dart:uiDefaultClass.Color.Lerp(a.OverlappingShapeStrokeColor, b.OverlappingShapeStrokeColor, t), disabledThumbColor: Dart:uiDefaultClass.Color.Lerp(a.DisabledThumbColor, b.DisabledThumbColor, t), overlayColor: Dart:uiDefaultClass.Color.Lerp(a.OverlayColor, b.OverlayColor, t), valueIndicatorColor: Dart:uiDefaultClass.Color.Lerp(a.ValueIndicatorColor, b.ValueIndicatorColor, t), overlayShape: t < 0.5 ? a.OverlayShape : b.OverlayShape, tickMarkShape: t < 0.5 ? a.TickMarkShape : b.TickMarkShape, thumbShape: t < 0.5 ? a.ThumbShape : b.ThumbShape, trackShape: t < 0.5 ? a.TrackShape : b.TrackShape, valueIndicatorShape: t < 0.5 ? a.ValueIndicatorShape : b.ValueIndicatorShape, rangeTickMarkShape: t < 0.5 ? a.RangeTickMarkShape : b.RangeTickMarkShape, rangeThumbShape: t < 0.5 ? a.RangeThumbShape : b.RangeThumbShape, rangeTrackShape: t < 0.5 ? a.RangeTrackShape : b.RangeTrackShape, rangeValueIndicatorShape: t < 0.5 ? a.RangeValueIndicatorShape : b.RangeValueIndicatorShape, showValueIndicator: t < 0.5 ? a.ShowValueIndicator : b.ShowValueIndicator, valueIndicatorTextStyle: TextstyleDefaultClass.TextStyle.Lerp(a.ValueIndicatorTextStyle, b.ValueIndicatorTextStyle, t), minThumbSeparation: Dart:uiDefaultClass.LerpDouble(a.MinThumbSeparation, b.MinThumbSeparation, t), thumbSelector: t < 0.5 ? a.ThumbSelector : b.ThumbSelector);
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other)){
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is SliderThemeData && other.TrackHeight == TrackHeight && other.ActiveTrackColor == ActiveTrackColor && other.InactiveTrackColor == InactiveTrackColor && other.DisabledActiveTrackColor == DisabledActiveTrackColor && other.DisabledInactiveTrackColor == DisabledInactiveTrackColor && other.ActiveTickMarkColor == ActiveTickMarkColor && other.InactiveTickMarkColor == InactiveTickMarkColor && other.DisabledActiveTickMarkColor == DisabledActiveTickMarkColor && other.DisabledInactiveTickMarkColor == DisabledInactiveTickMarkColor && other.ThumbColor == ThumbColor && other.OverlappingShapeStrokeColor == OverlappingShapeStrokeColor && other.DisabledThumbColor == DisabledThumbColor && other.OverlayColor == OverlayColor && other.ValueIndicatorColor == ValueIndicatorColor && other.OverlayShape == OverlayShape && other.TickMarkShape == TickMarkShape && other.ThumbShape == ThumbShape && other.TrackShape == TrackShape && other.ValueIndicatorShape == ValueIndicatorShape && other.RangeTickMarkShape == RangeTickMarkShape && other.RangeThumbShape == RangeThumbShape && other.RangeTrackShape == RangeTrackShape && other.RangeValueIndicatorShape == RangeValueIndicatorShape && other.ShowValueIndicator == ShowValueIndicator && other.ValueIndicatorTextStyle == ValueIndicatorTextStyle && other.MinThumbSeparation == MinThumbSeparation && other.ThumbSelector == ThumbSelector;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            SliderThemeData defaultData = new SliderThemeData();
            properties.Add(new DoubleProperty("trackHeight", TrackHeight, defaultValue: defaultData.TrackHeight));
            properties.Add(new ColorProperty("activeTrackColor", ActiveTrackColor, defaultValue: defaultData.ActiveTrackColor));
            properties.Add(new ColorProperty("inactiveTrackColor", InactiveTrackColor, defaultValue: defaultData.InactiveTrackColor));
            properties.Add(new ColorProperty("disabledActiveTrackColor", DisabledActiveTrackColor, defaultValue: defaultData.DisabledActiveTrackColor));
            properties.Add(new ColorProperty("disabledInactiveTrackColor", DisabledInactiveTrackColor, defaultValue: defaultData.DisabledInactiveTrackColor));
            properties.Add(new ColorProperty("activeTickMarkColor", ActiveTickMarkColor, defaultValue: defaultData.ActiveTickMarkColor));
            properties.Add(new ColorProperty("inactiveTickMarkColor", InactiveTickMarkColor, defaultValue: defaultData.InactiveTickMarkColor));
            properties.Add(new ColorProperty("disabledActiveTickMarkColor", DisabledActiveTickMarkColor, defaultValue: defaultData.DisabledActiveTickMarkColor));
            properties.Add(new ColorProperty("disabledInactiveTickMarkColor", DisabledInactiveTickMarkColor, defaultValue: defaultData.DisabledInactiveTickMarkColor));
            properties.Add(new ColorProperty("thumbColor", ThumbColor, defaultValue: defaultData.ThumbColor));
            properties.Add(new ColorProperty("overlappingShapeStrokeColor", OverlappingShapeStrokeColor, defaultValue: defaultData.OverlappingShapeStrokeColor));
            properties.Add(new ColorProperty("disabledThumbColor", DisabledThumbColor, defaultValue: defaultData.DisabledThumbColor));
            properties.Add(new ColorProperty("overlayColor", OverlayColor, defaultValue: defaultData.OverlayColor));
            properties.Add(new ColorProperty("valueIndicatorColor", ValueIndicatorColor, defaultValue: defaultData.ValueIndicatorColor));
            properties.Add(new DiagnosticsProperty<SliderComponentShape>("overlayShape", OverlayShape, defaultValue: defaultData.OverlayShape));
            properties.Add(new DiagnosticsProperty<SliderTickMarkShape>("tickMarkShape", TickMarkShape, defaultValue: defaultData.TickMarkShape));
            properties.Add(new DiagnosticsProperty<SliderComponentShape>("thumbShape", ThumbShape, defaultValue: defaultData.ThumbShape));
            properties.Add(new DiagnosticsProperty<SliderTrackShape>("trackShape", TrackShape, defaultValue: defaultData.TrackShape));
            properties.Add(new DiagnosticsProperty<SliderComponentShape>("valueIndicatorShape", ValueIndicatorShape, defaultValue: defaultData.ValueIndicatorShape));
            properties.Add(new DiagnosticsProperty<RangeSliderTickMarkShape>("rangeTickMarkShape", RangeTickMarkShape, defaultValue: defaultData.RangeTickMarkShape));
            properties.Add(new DiagnosticsProperty<RangeSliderThumbShape>("rangeThumbShape", RangeThumbShape, defaultValue: defaultData.RangeThumbShape));
            properties.Add(new DiagnosticsProperty<RangeSliderTrackShape>("rangeTrackShape", RangeTrackShape, defaultValue: defaultData.RangeTrackShape));
            properties.Add(new DiagnosticsProperty<RangeSliderValueIndicatorShape>("rangeValueIndicatorShape", RangeValueIndicatorShape, defaultValue: defaultData.RangeValueIndicatorShape));
            properties.Add(new EnumProperty<ShowValueIndicator>("showValueIndicator", ShowValueIndicator, defaultValue: defaultData.ShowValueIndicator));
            properties.Add(new DiagnosticsProperty<TextStyle>("valueIndicatorTextStyle", ValueIndicatorTextStyle, defaultValue: defaultData.ValueIndicatorTextStyle));
            properties.Add(new DoubleProperty("minThumbSeparation", MinThumbSeparation, defaultValue: defaultData.MinThumbSeparation));
            properties.Add(new DiagnosticsProperty<RangeThumbSelector>("thumbSelector", ThumbSelector, defaultValue: defaultData.ThumbSelector));
        }



    }


    /// <Summary>
    /// {@template flutter.material.slider.shape.center}
    /// [center] is the offset for where this shape's center should be painted.
    /// This offset is relative to the origin of the [context] canvas.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.context}
    /// [context] is the same as the one that includes the [Slider]'s render box.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.enableAnimation}
    /// [enableAnimation] is an animation triggered when the [Slider] is enabled,
    /// and it reverses when the slider is disabled. Enabled is the
    /// [Slider.isInteractive] state. Use this to paint intermediate frames for
    /// this shape when the slider changes enabled state.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.isDiscrete}
    /// [isDiscrete] is true if [Slider.divisions] is non-null. If true, the
    /// slider will render tick marks on top of the track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.isEnabled}
    /// [isEnabled] has the same value as [Slider.isInteractive]. If true, the
    /// slider will respond to input.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.slider.shape.parentBox}
    /// [parentBox] is the [RenderBox] of the [Slider]. Its attributes, such as
    /// size, can be used to assist in painting this shape.
    /// {@endtemplate}
    /// {@template flutter.material.slider.shape.sliderTheme}
    /// [sliderTheme] is the theme assigned to the [Slider] that this shape
    /// belongs to.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.activationAnimation}
    /// [activationAnimation] is an animation triggered when the user begins
    /// to interact with the [RangeSlider]. It reverses when the user stops
    /// interacting with the slider.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.context}
    /// [context] is the same as the one that includes the [RangeSlider]'s render
    /// box.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.enableAnimation}
    /// [enableAnimation] is an animation triggered when the [RangeSlider] is
    /// enabled, and it reverses when the slider is disabled. Enabled is the
    /// [RangeSlider.isEnabled] state. Use this to paint intermediate frames for
    /// this shape when the slider changes enabled state.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.isDiscrete}
    /// [isDiscrete] is true if [RangeSlider.divisions] is non-null. If true, the
    /// slider will render tick marks on top of the track.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.isEnabled}
    /// [isEnabled] has the same value as [RangeSlider.isEnabled]. If true, the
    /// slider will respond to input.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.parentBox}
    /// [parentBox] is the [RenderBox] of the [RangeSlider]. Its attributes, such as
    /// size, can be used to assist in painting this shape.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.sliderTheme}
    /// [sliderTheme] is the theme assigned to the [RangeSlider] that this shape
    /// belongs to.
    /// {@endtemplate}
    ///
    /// {@template flutter.material.rangeSlider.shape.thumb}
    /// [thumb] Is the specifier for which of the two thumbs this method should
    /// paint, start or end.
    /// {@endtemplate}
    /// Base class for slider thumb, thumb overlay, and value indicator shapes.
    ///
    /// Create a subclass of this if you would like a custom shape.
    ///
    /// All shapes are painted to the same canvas and ordering is important.
    /// The overlay is painted first, then the value indicator, then the thumb.
    ///
    /// The thumb painting can be skipped by specifying [noThumb] for
    /// [SliderThemeData.thumbShape].
    ///
    /// The overlay painting can be skipped by specifying [noOverlay] for
    /// [SliderThemeData.overlayShape].
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.roundSliderOverlayShape}
    /// {@macro flutter.material.slider.seeAlso.paddleSliderValueIndicatorShape}
    /// </Summary>
    public class SliderComponentShape
    {
        public SliderComponentShape()
        {

        }
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape NoThumb { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape NoOverlay { get; set; }

        /// <Summary>
        /// Returns the preferred size of the shape, based on the given conditions.
        /// </Summary>
        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete)
        {
            return default(Size);
        }


        /// <Summary>
        /// Paints the shape, taking into account the state passed to it.
        ///
        /// {@macro flutter.material.slider.shape.context}
        ///
        /// {@macro flutter.material.slider.shape.center}
        ///
        /// [activationAnimation] is an animation triggered when the user begins
        /// to interact with the slider. It reverses when the user stops interacting
        /// with the slider.
        ///
        /// {@macro flutter.material.slider.shape.enableAnimation}
        ///
        /// {@macro flutter.material.slider.shape.isDiscrete}
        ///
        /// If [labelPainter] is non-null, then [labelPainter.paint] should be
        /// called with the location that the label should appear. If the labelPainter
        /// parameter is null, then no label was supplied to the [Slider].
        ///
        /// {@macro flutter.material.slider.shape.parentBox}
        ///
        /// {@macro flutter.material.slider.shape.sliderTheme}
        ///
        /// [textDirection] can be used to determine how any extra text or graphics,
        /// besides the text painted by the [labelPainter] should be positioned. The
        /// [labelPainter] already has the [textDirection] set.
        ///
        /// [value] is the current parametric value (from 0.0 to 1.0) of the slider.
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double))
        {
        }

    }


    /// <Summary>
    /// Base class for [Slider] tick mark shapes.
    ///
    /// Create a subclass of this if you would like a custom slider tick mark shape.
    ///
    /// The tick mark painting can be skipped by specifying [noTickMark] for
    /// [SliderThemeData.tickMarkShape].
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public class SliderTickMarkShape
    {
        public SliderTickMarkShape()
        {

        }
        public virtual FlutterSDK.Material.Slidertheme.SliderTickMarkShape NoTickMark { get; set; }

        /// <Summary>
        /// Returns the preferred size of the shape.
        ///
        /// It is used to help position the tick marks within the slider.
        ///
        /// {@macro flutter.material.slider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.slider.shape.isEnabled}
        /// </Summary>
        public virtual Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool))
        {
            return default(Size);
        }


        /// <Summary>
        /// Paints the slider track.
        ///
        /// {@macro flutter.material.slider.shape.context}
        ///
        /// {@macro flutter.material.slider.shape.center}
        ///
        /// {@macro flutter.material.slider.shape.parentBox}
        ///
        /// {@macro flutter.material.slider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.slider.shape.enableAnimation}
        ///
        /// {@macro flutter.material.slider.shape.isEnabled}
        ///
        /// [textDirection] can be used to determine how the tick marks are painting
        /// depending on whether they are on an active track segment or not. The track
        /// segment between the start of the slider and the thumb is the active track
        /// segment. The track segment between the thumb and the end of the slider is
        /// the inactive track segment. In LTR text direction, the start of the slider
        /// is on the left, and in RTL text direction, the start of the slider is on
        /// the right.
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection))
        {
        }

    }


    /// <Summary>
    /// Base class for slider track shapes.
    ///
    /// The slider's thumb moves along the track. A discrete slider's tick marks
    /// are drawn after the track, but before the thumb, and are aligned with the
    /// track.
    ///
    /// The [getPreferredRect] helps position the slider thumb and tick marks
    /// relative to the track.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundedRectSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public class SliderTrackShape
    {
        public SliderTrackShape()
        {

        }

        /// <Summary>
        /// Returns the preferred bounds of the shape.
        ///
        /// It is used to provide horizontal boundaries for the thumb's position, and
        /// to help position the slider thumb and tick marks relative to the track.
        ///
        /// The [parentBox] argument can be used to help determine the preferredRect relative to
        /// attributes of the render box of the slider itself, such as size.
        ///
        /// The [offset] argument is relative to the caller's bounding box. It can be used to
        /// convert gesture coordinates from global to slider-relative coordinates.
        ///
        /// {@macro flutter.material.slider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.slider.shape.isEnabled}
        ///
        /// {@macro flutter.material.slider.shape.isDiscrete}
        /// </Summary>
        public virtual Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool))
        {
            return default(Rect);
        }


        /// <Summary>
        /// Paints the track shape based on the state passed to it.
        ///
        /// {@macro flutter.material.slider.shape.context}
        ///
        /// [offset] is the offset of the origin of the [parentBox] to the origin of
        /// its [context] canvas. This shape must be painted relative to this
        /// offset. See [PaintingContextCallback].
        ///
        /// {@macro flutter.material.slider.shape.parentBox}
        ///
        /// {@macro flutter.material.slider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.slider.shape.enableAnimation}
        ///
        /// The [thumbCenter] argument is the offset of the center of the thumb relative to the
        /// origin of the [PaintingContext.canvas]. It can be used as the point that
        /// divides the track into 2 segments.
        ///
        /// {@macro flutter.material.slider.shape.isEnabled}
        ///
        /// {@macro flutter.material.slider.shape.isDiscrete}
        ///
        /// The [textDirection] argument can be used to determine how the track segments are
        /// painted depending on whether they are active or not.
        /// {@macro flutter.material.slider.trackSegment}
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection))
        {
        }

    }


    /// <Summary>
    /// Base class for [RangeSlider] thumb shapes.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundRangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public class RangeSliderThumbShape
    {
        public RangeSliderThumbShape()
        {

        }

        /// <Summary>
        /// Returns the preferred size of the shape, based on the given conditions.
        ///
        /// {@macro flutter.material.rangeSlider.shape.isDiscrete}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        /// </Summary>
        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete)
        {
            return default(Size);
        }


        /// <Summary>
        /// Paints the thumb shape based on the state passed to it.
        ///
        /// {@macro flutter.material.rangeSlider.shape.context}
        ///
        /// {@macro flutter.material.slider.shape.center}
        ///
        /// {@macro flutter.material.rangeSlider.shape.activationAnimation}
        ///
        /// {@macro flutter.material.rangeSlider.shape.enableAnimation}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isDiscrete}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        ///
        /// If [isOnTop] is true this thumb is painted on top of the other slider
        /// thumb because this thumb is the one that was most recently selected.
        ///
        /// {@macro flutter.material.rangeSlider.shape.sliderTheme}
        ///
        /// [textDirection] can be used to determine how the orientation of either
        /// slider thumb should be changed, such as drawing different shapes for the
        /// left and right thumb.
        ///
        /// {@macro flutter.material.rangeSlider.shape.thumb}
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isEnabled = default(bool), bool isOnTop = default(bool), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb))
        {
        }

    }


    /// <Summary>
    /// Base class for [RangeSlider] value indicator shapes.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.paddleRangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public class RangeSliderValueIndicatorShape
    {
        public RangeSliderValueIndicatorShape()
        {

        }

        /// <Summary>
        /// Returns the preferred size of the shape, based on the given conditions.
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isDiscrete}
        ///
        /// [labelPainter] helps determine the width of the shape. It is variable
        /// width because it is derived from a formatted string.
        /// </Summary>
        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter))
        {
            return default(Size);
        }


        /// <Summary>
        /// Determines the best offset to keep this shape on the screen.
        ///
        /// Override this method when the center of the value indicator should be
        /// shifted from the vertical center of the thumb.
        /// </Summary>
        public virtual double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            return 0;
        }




        /// <Summary>
        /// Paints the value indicator shape based on the state passed to it.
        ///
        /// {@macro flutter.material.rangeSlider.shape.context}
        ///
        /// {@macro flutter.material.slider.shape.center}
        ///
        /// {@macro flutter.material.rangeSlider.shape.activationAnimation}
        ///
        /// {@macro flutter.material.rangeSlider.shape.enableAnimation}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isDiscrete}
        ///
        /// The [isOnTop] argument is the top-most value indicator between the two value
        /// indicators, which is always the indicator for the most recently selected thumb. In
        /// the default case, this is used to paint a stroke around the top indicator
        /// for better visibility between the two indicators.
        ///
        /// {@macro flutter.material.rangeSlider.shape.sliderTheme}
        ///
        /// [textDirection] can be used to determine how any extra text or graphics,
        /// besides the text painted by the [labelPainter] should be positioned. The
        /// [labelPainter] already has the [textDirection] set.
        ///
        /// [value] is the current parametric value (from 0.0 to 1.0) of the slider.
        ///
        /// {@macro flutter.material.rangeSlider.shape.thumb}
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isOnTop = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb))
        {
        }

    }


    /// <Summary>
    /// Base class for [RangeSlider] tick mark shapes.
    ///
    /// This is a simplified version of [SliderComponentShape] with a
    /// [SliderThemeData] passed when getting the preferred size.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundRangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public class RangeSliderTickMarkShape
    {
        public RangeSliderTickMarkShape()
        {

        }

        /// <Summary>
        /// Returns the preferred size of the shape.
        ///
        /// It is used to help position the tick marks within the slider.
        ///
        /// {@macro flutter.material.rangeSlider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        /// </Summary>
        public virtual Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool))
        {
            return default(Size);
        }


        /// <Summary>
        /// Paints the slider track.
        ///
        /// {@macro flutter.material.rangeSlider.shape.context}
        ///
        /// {@macro flutter.material.slider.shape.center}
        ///
        /// {@macro flutter.material.rangeSlider.shape.parentBox}
        ///
        /// {@macro flutter.material.rangeSlider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.rangeSlider.shape.enableAnimation}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        ///
        /// The [textDirection] argument can be used to determine how the tick marks are painted
        /// depending on whether they are on an active track segment or not.
        /// {@macro flutter.material.rangeSlider.trackSegment}
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection))
        {
        }

    }


    /// <Summary>
    /// Base class for [RangeSlider] track shapes.
    ///
    /// The slider's thumbs move along the track. A discrete slider's tick marks
    /// are drawn after the track, but before the thumb, and are aligned with the
    /// track.
    ///
    /// The [getPreferredRect] helps position the slider thumbs and tick marks
    /// relative to the track.
    ///
    /// See also:
    ///
    /// {@macro flutter.material.slider.seeAlso.roundedRectRangeSliderTrackShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTickMarkShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderThumbShape}
    /// {@macro flutter.material.slider.seeAlso.rangeSliderValueIndicatorShape}
    /// {@macro flutter.material.slider.seeAlso.sliderComponentShape}
    /// </Summary>
    public class RangeSliderTrackShape
    {
        public RangeSliderTrackShape()
        {

        }

        /// <Summary>
        /// Returns the preferred bounds of the shape.
        ///
        /// It is used to provide horizontal boundaries for the position of the
        /// thumbs, and to help position the slider thumbs and tick marks relative to
        /// the track.
        ///
        /// The [parentBox] argument can be used to help determine the preferredRect relative to
        /// attributes of the render box of the slider itself, such as size.
        ///
        /// The [offset] argument is relative to the caller's bounding box. It can be used to
        /// convert gesture coordinates from global to slider-relative coordinates.
        ///
        /// {@macro flutter.material.rangeSlider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isDiscrete}
        /// </Summary>
        public virtual Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool))
        {
            return default(Rect);
        }


        /// <Summary>
        /// Paints the track shape based on the state passed to it.
        ///
        /// {@macro flutter.material.slider.shape.context}
        ///
        /// [offset] is the offset of the origin of the [parentBox] to the origin of
        /// its [context] canvas. This shape must be painted relative to this
        /// offset. See [PaintingContextCallback].
        ///
        /// {@macro flutter.material.rangeSlider.shape.parentBox}
        ///
        /// {@macro flutter.material.rangeSlider.shape.sliderTheme}
        ///
        /// {@macro flutter.material.rangeSlider.shape.enableAnimation}
        ///
        /// [startThumbCenter] is the offset of the center of the start thumb relative
        /// to the origin of the [PaintingContext.canvas]. It can be used as one point
        /// that divides the track between inactive and active.
        ///
        /// [endThumbCenter] is the offset of the center of the end thumb relative
        /// to the origin of the [PaintingContext.canvas]. It can be used as one point
        /// that divides the track between inactive and active.
        ///
        /// {@macro flutter.material.rangeSlider.shape.isEnabled}
        ///
        /// {@macro flutter.material.rangeSlider.shape.isDiscrete}
        ///
        /// [textDirection] can be used to determine how the track segments are
        /// painted depending on whether they are on an active track segment or not.
        /// {@macro flutter.material.rangeSlider.trackSegment}
        /// </Summary>
        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection))
        {
        }

    }


    /// <Summary>
    /// A [Slider] track that's a simple rectangle.
    ///
    /// It paints a solid colored rectangle, vertically centered in the
    /// [parentBox]. The track rectangle extends to the bounds of the [parentBox],
    /// but is padded by the [RoundSliderOverlayShape] radius. The height is defined
    /// by the [SliderThemeData.trackHeight]. The color is determined by the
    /// [Slider]'s enabled state and the track segment's active state which are
    /// defined by:
    ///   [SliderThemeData.activeTrackColor],
    ///   [SliderThemeData.inactiveTrackColor],
    ///   [SliderThemeData.disabledActiveTrackColor],
    ///   [SliderThemeData.disabledInactiveTrackColor].
    ///
    /// {@macro flutter.material.slider.trackSegment}
    ///
    /// See also:
    ///
    ///  * [Slider], for the component that is meant to display this shape.
    ///  * [SliderThemeData], where an instance of this class is set to inform the
    ///    slider of the visual details of the its track.
    /// {@macro flutter.material.slider.seeAlso.sliderTrackShape}
    ///  * [RoundedRectSliderTrackShape], for a similar track with rounded edges.
    /// </Summary>
    public class RectangularSliderTrackShape : FlutterSDK.Material.Slidertheme.SliderTrackShape, IBaseSliderTrackShape
    {
        public RectangularSliderTrackShape(double disabledThumbGapWidth = 2.0)
        {
            this.DisabledThumbGapWidth = disabledThumbGapWidth;
        }
        public virtual double DisabledThumbGapWidth { get; set; }

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isDiscrete = false, bool isEnabled = false)
        {














            if (sliderTheme.TrackHeight <= 0)
            {
                return;
            }

            ColorTween activeTrackColorTween = new ColorTween(begin: sliderTheme.DisabledActiveTrackColor, end: sliderTheme.ActiveTrackColor);
            ColorTween inactiveTrackColorTween = new ColorTween(begin: sliderTheme.DisabledInactiveTrackColor, end: sliderTheme.InactiveTrackColor);
            Paint activePaint = new Paint()..Color = activeTrackColorTween.Evaluate(enableAnimation);
            Paint inactivePaint = new Paint()..Color = inactiveTrackColorTween.Evaluate(enableAnimation);
            Paint leftTrackPaint = default(Paint);
            Paint rightTrackPaint = default(Paint);
            switch (textDirection) { case TextDirection.Ltr: leftTrackPaint = activePaint; rightTrackPaint = inactivePaint; break; case TextDirection.Rtl: leftTrackPaint = inactivePaint; rightTrackPaint = activePaint; break; }
            Rect trackRect = GetPreferredRect(parentBox: parentBox, offset: offset, sliderTheme: sliderTheme, isEnabled: isEnabled, isDiscrete: isDiscrete);
            Size thumbSize = sliderTheme.ThumbShape.GetPreferredSize(isEnabled, isDiscrete);
            Rect leftTrackSegment = Rect.FromLTRB(trackRect.Left + trackRect.Height / 2, trackRect.Top, thumbCenter.Dx - thumbSize.Width / 2, trackRect.Bottom);
            if (!leftTrackSegment.IsEmpty()) context.Canvas.DrawRect(leftTrackSegment, leftTrackPaint);
            Rect rightTrackSegment = Rect.FromLTRB(thumbCenter.Dx + thumbSize.Width / 2, trackRect.Top, trackRect.Right, trackRect.Bottom);
            if (!rightTrackSegment.IsEmpty()) context.Canvas.DrawRect(rightTrackSegment, rightTrackPaint);
        }



    }


    /// <Summary>
    /// The default shape of a [Slider]'s track.
    ///
    /// It paints a solid colored rectangle with rounded edges, vertically centered
    /// in the [parentBox]. The track rectangle extends to the bounds of the
    /// [parentBox], but is padded by the larger of [RoundSliderOverlayShape]'s
    /// radius and [RoundSliderThumbShape]'s radius. The height is defined by the
    /// [SliderThemeData.trackHeight]. The color is determined by the [Slider]'s
    /// enabled state and the track segment's active state which are defined by:
    ///   [SliderThemeData.activeTrackColor],
    ///   [SliderThemeData.inactiveTrackColor],
    ///   [SliderThemeData.disabledActiveTrackColor],
    ///   [SliderThemeData.disabledInactiveTrackColor].
    ///
    /// {@macro flutter.material.slider.trackSegment}
    ///
    /// See also:
    ///
    ///  * [Slider], for the component that is meant to display this shape.
    ///  * [SliderThemeData], where an instance of this class is set to inform the
    ///    slider of the visual details of the its track.
    /// {@macro flutter.material.slider.seeAlso.sliderTrackShape}
    ///  * [RectangularSliderTrackShape], for a similar track with sharp edges.
    /// </Summary>
    public class RoundedRectSliderTrackShape : FlutterSDK.Material.Slidertheme.SliderTrackShape, IBaseSliderTrackShape
    {
        public RoundedRectSliderTrackShape()
        {

        }

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isDiscrete = false, bool isEnabled = false)
        {












            if (sliderTheme.TrackHeight <= 0)
            {
                return;
            }

            ColorTween activeTrackColorTween = new ColorTween(begin: sliderTheme.DisabledActiveTrackColor, end: sliderTheme.ActiveTrackColor);
            ColorTween inactiveTrackColorTween = new ColorTween(begin: sliderTheme.DisabledInactiveTrackColor, end: sliderTheme.InactiveTrackColor);
            Paint activePaint = new Paint()..Color = activeTrackColorTween.Evaluate(enableAnimation);
            Paint inactivePaint = new Paint()..Color = inactiveTrackColorTween.Evaluate(enableAnimation);
            Paint leftTrackPaint = default(Paint);
            Paint rightTrackPaint = default(Paint);
            switch (textDirection) { case TextDirection.Ltr: leftTrackPaint = activePaint; rightTrackPaint = inactivePaint; break; case TextDirection.Rtl: leftTrackPaint = inactivePaint; rightTrackPaint = activePaint; break; }
            Rect trackRect = GetPreferredRect(parentBox: parentBox, offset: offset, sliderTheme: sliderTheme, isEnabled: isEnabled, isDiscrete: isDiscrete);
            Rect leftTrackArcRect = Rect.FromLTWH(trackRect.Left, trackRect.Top, trackRect.Height, trackRect.Height);
            if (!leftTrackArcRect.IsEmpty()) context.Canvas.DrawArc(leftTrackArcRect, Math.Dart:mathDefaultClass.Pi / 2, Math.Dart:mathDefaultClass.Pi, false, leftTrackPaint);
            Rect rightTrackArcRect = Rect.FromLTWH(trackRect.Right - trackRect.Height / 2, trackRect.Top, trackRect.Height, trackRect.Height);
            if (!rightTrackArcRect.IsEmpty()) context.Canvas.DrawArc(rightTrackArcRect, -Math.Dart:mathDefaultClass.Pi / 2, Math.Dart:mathDefaultClass.Pi, false, rightTrackPaint);
            Size thumbSize = sliderTheme.ThumbShape.GetPreferredSize(isEnabled, isDiscrete);
            Rect leftTrackSegment = Rect.FromLTRB(trackRect.Left + trackRect.Height / 2, trackRect.Top, thumbCenter.Dx - thumbSize.Width / 2, trackRect.Bottom);
            if (!leftTrackSegment.IsEmpty()) context.Canvas.DrawRect(leftTrackSegment, leftTrackPaint);
            Rect rightTrackSegment = Rect.FromLTRB(thumbCenter.Dx + thumbSize.Width / 2, trackRect.Top, trackRect.Right, trackRect.Bottom);
            if (!rightTrackSegment.IsEmpty()) context.Canvas.DrawRect(rightTrackSegment, rightTrackPaint);
        }



    }


    /// <Summary>
    /// A [RangeSlider] track that's a simple rectangle.
    ///
    /// It paints a solid colored rectangle, vertically centered in the
    /// [parentBox]. The track rectangle extends to the bounds of the [parentBox],
    /// but is padded by the [RoundSliderOverlayShape] radius. The height is
    /// defined by the [SliderThemeData.trackHeight]. The color is determined by the
    /// [Slider]'s enabled state and the track segment's active state which are
    /// defined by:
    ///   [SliderThemeData.activeTrackColor],
    ///   [SliderThemeData.inactiveTrackColor],
    ///   [SliderThemeData.disabledActiveTrackColor],
    ///   [SliderThemeData.disabledInactiveTrackColor].
    ///
    /// {@macro flutter.material.rangeSlider.trackSegment}
    ///
    /// See also:
    ///
    ///  * [RangeSlider], for the component that is meant to display this shape.
    ///  * [SliderThemeData], where an instance of this class is set to inform the
    ///    slider of the visual details of the its track.
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    ///  * [RoundedRectRangeSliderTrackShape], for a similar track with rounded
    ///    edges.
    /// </Summary>
    public class RectangularRangeSliderTrackShape : FlutterSDK.Material.Slidertheme.RangeSliderTrackShape
    {
        public RectangularRangeSliderTrackShape()
        {

        }

        public new Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false)
        {






            double overlayWidth = sliderTheme.OverlayShape.GetPreferredSize(isEnabled, isDiscrete).Width;
            double trackHeight = sliderTheme.TrackHeight;




            double trackLeft = offset.Dx + overlayWidth / 2;
            double trackTop = offset.Dy + (parentBox.Size.Height - trackHeight) / 2;
            double trackWidth = parentBox.Size.Width - overlayWidth;
            return Rect.FromLTWH(trackLeft, trackTop, trackWidth, trackHeight);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false, bool isDiscrete = false, TextDirection textDirection = default(TextDirection))
        {















            ColorTween activeTrackColorTween = new ColorTween(begin: sliderTheme.DisabledActiveTrackColor, end: sliderTheme.ActiveTrackColor);
            ColorTween inactiveTrackColorTween = new ColorTween(begin: sliderTheme.DisabledInactiveTrackColor, end: sliderTheme.InactiveTrackColor);
            Paint activePaint = new Paint()..Color = activeTrackColorTween.Evaluate(enableAnimation);
            Paint inactivePaint = new Paint()..Color = inactiveTrackColorTween.Evaluate(enableAnimation);
            Offset leftThumbOffset = default(Offset);
            Offset rightThumbOffset = default(Offset);
            switch (textDirection) { case TextDirection.Ltr: leftThumbOffset = startThumbCenter; rightThumbOffset = endThumbCenter; break; case TextDirection.Rtl: leftThumbOffset = endThumbCenter; rightThumbOffset = startThumbCenter; break; }
            Size thumbSize = sliderTheme.RangeThumbShape.GetPreferredSize(isEnabled, isDiscrete);
            double thumbRadius = thumbSize.Width / 2;
            Rect trackRect = GetPreferredRect(parentBox: parentBox, offset: offset, sliderTheme: sliderTheme, isEnabled: isEnabled, isDiscrete: isDiscrete);
            Rect leftTrackSegment = Rect.FromLTRB(trackRect.Left, trackRect.Top, leftThumbOffset.Dx - thumbRadius, trackRect.Bottom);
            if (!leftTrackSegment.IsEmpty()) context.Canvas.DrawRect(leftTrackSegment, inactivePaint);
            Rect middleTrackSegment = Rect.FromLTRB(leftThumbOffset.Dx + thumbRadius, trackRect.Top, rightThumbOffset.Dx - thumbRadius, trackRect.Bottom);
            if (!middleTrackSegment.IsEmpty()) context.Canvas.DrawRect(middleTrackSegment, activePaint);
            Rect rightTrackSegment = Rect.FromLTRB(rightThumbOffset.Dx + thumbRadius, trackRect.Top, trackRect.Right, trackRect.Bottom);
            if (!rightTrackSegment.IsEmpty()) context.Canvas.DrawRect(rightTrackSegment, inactivePaint);
        }



    }


    /// <Summary>
    /// The default shape of a [RangeSlider]'s track.
    ///
    /// It paints a solid colored rectangle with rounded edges, vertically centered
    /// in the [parentBox]. The track rectangle extends to the bounds of the
    /// [parentBox], but is padded by the larger of [RoundSliderOverlayShape]'s
    /// radius and [RoundRangeSliderThumbShape]'s radius. The height is defined by
    /// the [SliderThemeData.trackHeight]. The color is determined by the
    /// [RangeSlider]'s enabled state and the track segment's active state which are
    /// defined by:
    ///   [SliderThemeData.activeTrackColor],
    ///   [SliderThemeData.inactiveTrackColor],
    ///   [SliderThemeData.disabledActiveTrackColor],
    ///   [SliderThemeData.disabledInactiveTrackColor].
    ///
    /// {@macro flutter.material.rangeSlider.trackSegment}
    ///
    /// See also:
    ///
    ///  * [RangeSlider], for the component that is meant to display this shape.
    ///  * [SliderThemeData], where an instance of this class is set to inform the
    ///    slider of the visual details of the its track.
    /// {@macro flutter.material.slider.seeAlso.rangeSliderTrackShape}
    ///  * [RectangularRangeSliderTrackShape], for a similar track with sharp edges.
    /// </Summary>
    public class RoundedRectRangeSliderTrackShape : FlutterSDK.Material.Slidertheme.RangeSliderTrackShape
    {
        public RoundedRectRangeSliderTrackShape()
        {

        }

        public new Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false)
        {







            double overlayWidth = sliderTheme.OverlayShape.GetPreferredSize(isEnabled, isDiscrete).Width;
            double trackHeight = sliderTheme.TrackHeight;




            double trackLeft = offset.Dx + overlayWidth / 2;
            double trackTop = offset.Dy + (parentBox.Size.Height - trackHeight) / 2;
            double trackWidth = parentBox.Size.Width - overlayWidth;
            return Rect.FromLTWH(trackLeft, trackTop, trackWidth, trackHeight);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false, bool isDiscrete = false, TextDirection textDirection = default(TextDirection))
        {















            ColorTween activeTrackColorTween = new ColorTween(begin: sliderTheme.DisabledActiveTrackColor, end: sliderTheme.ActiveTrackColor);
            ColorTween inactiveTrackColorTween = new ColorTween(begin: sliderTheme.DisabledInactiveTrackColor, end: sliderTheme.InactiveTrackColor);
            Paint activePaint = new Paint()..Color = activeTrackColorTween.Evaluate(enableAnimation);
            Paint inactivePaint = new Paint()..Color = inactiveTrackColorTween.Evaluate(enableAnimation);
            Offset leftThumbOffset = default(Offset);
            Offset rightThumbOffset = default(Offset);
            switch (textDirection) { case TextDirection.Ltr: leftThumbOffset = startThumbCenter; rightThumbOffset = endThumbCenter; break; case TextDirection.Rtl: leftThumbOffset = endThumbCenter; rightThumbOffset = startThumbCenter; break; }
            Size thumbSize = sliderTheme.RangeThumbShape.GetPreferredSize(isEnabled, isDiscrete);
            double thumbRadius = thumbSize.Width / 2;

            Rect trackRect = GetPreferredRect(parentBox: parentBox, offset: offset, sliderTheme: sliderTheme, isEnabled: isEnabled, isDiscrete: isDiscrete);
            double trackRadius = trackRect.Height / 2;
            Rect leftTrackArcRect = Rect.FromLTWH(trackRect.Left, trackRect.Top, trackRect.Height, trackRect.Height);
            if (!leftTrackArcRect.IsEmpty()) context.Canvas.DrawArc(leftTrackArcRect, Math.Dart:mathDefaultClass.Pi / 2, Math.Dart:mathDefaultClass.Pi, false, inactivePaint);
            Rect leftTrackSegment = Rect.FromLTRB(trackRect.Left + trackRadius, trackRect.Top, leftThumbOffset.Dx - thumbRadius, trackRect.Bottom);
            if (!leftTrackSegment.IsEmpty()) context.Canvas.DrawRect(leftTrackSegment, inactivePaint);
            Rect middleTrackSegment = Rect.FromLTRB(leftThumbOffset.Dx + thumbRadius, trackRect.Top, rightThumbOffset.Dx - thumbRadius, trackRect.Bottom);
            if (!middleTrackSegment.IsEmpty()) context.Canvas.DrawRect(middleTrackSegment, activePaint);
            Rect rightTrackSegment = Rect.FromLTRB(rightThumbOffset.Dx + thumbRadius, trackRect.Top, trackRect.Right - trackRadius, trackRect.Bottom);
            if (!rightTrackSegment.IsEmpty()) context.Canvas.DrawRect(rightTrackSegment, inactivePaint);
            Rect rightTrackArcRect = Rect.FromLTWH(trackRect.Right - trackRect.Height, trackRect.Top, trackRect.Height, trackRect.Height);
            if (!rightTrackArcRect.IsEmpty()) context.Canvas.DrawArc(rightTrackArcRect, -Math.Dart:mathDefaultClass.Pi / 2, Math.Dart:mathDefaultClass.Pi, false, inactivePaint);
        }



    }


    /// <Summary>
    /// The default shape of each [Slider] tick mark.
    ///
    /// Tick marks are only displayed if the slider is discrete, which can be done
    /// by setting the [Slider.divisions] to an integer value.
    ///
    /// It paints a solid circle, centered in the on the track.
    /// The color is determined by the [Slider]'s enabled state and track's active
    /// states. These colors are defined in:
    ///   [SliderThemeData.activeTrackColor],
    ///   [SliderThemeData.inactiveTrackColor],
    ///   [SliderThemeData.disabledActiveTrackColor],
    ///   [SliderThemeData.disabledInactiveTrackColor].
    ///
    /// See also:
    ///
    ///  * [Slider], which includes tick marks defined by this shape.
    ///  * [SliderTheme], which can be used to configure the tick mark shape of all
    ///    sliders in a widget subtree.
    /// </Summary>
    public class RoundSliderTickMarkShape : FlutterSDK.Material.Slidertheme.SliderTickMarkShape
    {
        public RoundSliderTickMarkShape(double tickMarkRadius = default(double))
        {
            this.TickMarkRadius = tickMarkRadius;
        }
        public virtual double TickMarkRadius { get; set; }

        public new Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false)
        {



            return Size.FromRadius(tickMarkRadius == default(double) ? sliderTheme.trackHeight / 2 : tickMarkRadius);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false)
        {












            Color begin = default(Color);
            Color end = default(Color);
            switch (textDirection) { case TextDirection.Ltr: bool isTickMarkRightOfThumb = center.Dx > thumbCenter.Dx; begin = isTickMarkRightOfThumb ? sliderTheme.DisabledInactiveTickMarkColor : sliderTheme.DisabledActiveTickMarkColor; end = isTickMarkRightOfThumb ? sliderTheme.InactiveTickMarkColor : sliderTheme.ActiveTickMarkColor; break; case TextDirection.Rtl: bool isTickMarkLeftOfThumb = center.Dx < thumbCenter.Dx; begin = isTickMarkLeftOfThumb ? sliderTheme.DisabledInactiveTickMarkColor : sliderTheme.DisabledActiveTickMarkColor; end = isTickMarkLeftOfThumb ? sliderTheme.InactiveTickMarkColor : sliderTheme.ActiveTickMarkColor; break; }
            Paint paint = new Paint()..Color = new ColorTween(begin: begin, end: end).Evaluate(enableAnimation);
            double tickMarkRadius = GetPreferredSize(isEnabled: isEnabled, sliderTheme: sliderTheme).Width / 2;
            if (tickMarkRadius > 0)
            {
                context.Canvas.DrawCircle(center, tickMarkRadius, paint);
            }

        }



    }


    /// <Summary>
    /// The default shape of each [RangeSlider] tick mark.
    ///
    /// Tick marks are only displayed if the slider is discrete, which can be done
    /// by setting the [RangeSlider.divisions] to an integer value.
    ///
    /// It paints a solid circle, centered on the track.
    /// The color is determined by the [Slider]'s enabled state and track's active
    /// states. These colors are defined in:
    ///   [SliderThemeData.activeTrackColor],
    ///   [SliderThemeData.inactiveTrackColor],
    ///   [SliderThemeData.disabledActiveTrackColor],
    ///   [SliderThemeData.disabledInactiveTrackColor].
    ///
    /// See also:
    ///
    ///  * [RangeSlider], which includes tick marks defined by this shape.
    ///  * [SliderTheme], which can be used to configure the tick mark shape of all
    ///    sliders in a widget subtree.
    /// </Summary>
    public class RoundRangeSliderTickMarkShape : FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape
    {
        public RoundRangeSliderTickMarkShape(double tickMarkRadius = default(double))
        {
            this.TickMarkRadius = tickMarkRadius;
        }
        public virtual double TickMarkRadius { get; set; }

        public new Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false)
        {



            return Size.FromRadius(tickMarkRadius == default(double) ? sliderTheme.trackHeight / 2 : tickMarkRadius);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false, TextDirection textDirection = default(TextDirection))
        {













            bool isBetweenThumbs = default(bool);
            switch (textDirection) { case TextDirection.Ltr: isBetweenThumbs = startThumbCenter.Dx < center.Dx && center.Dx < endThumbCenter.Dx; break; case TextDirection.Rtl: isBetweenThumbs = endThumbCenter.Dx < center.Dx && center.Dx < startThumbCenter.Dx; break; }
            Color begin = isBetweenThumbs ? sliderTheme.DisabledActiveTickMarkColor : sliderTheme.DisabledInactiveTickMarkColor;
            Color end = isBetweenThumbs ? sliderTheme.ActiveTickMarkColor : sliderTheme.InactiveTickMarkColor;
            Paint paint = new Paint()..Color = new ColorTween(begin: begin, end: end).Evaluate(enableAnimation);
            double tickMarkRadius = GetPreferredSize(isEnabled: isEnabled, sliderTheme: sliderTheme).Width / 2;
            if (tickMarkRadius > 0)
            {
                context.Canvas.DrawCircle(center, tickMarkRadius, paint);
            }

        }



    }


    /// <Summary>
    /// A special version of [SliderTickMarkShape] that has a zero size and paints
    /// nothing.
    ///
    /// This class is used to create a special instance of a [SliderTickMarkShape]
    /// that will not paint any tick mark shape. A static reference is stored in
    /// [SliderTickMarkShape.noTickMark]. When this value is specified for
    /// [SliderThemeData.tickMarkShape], the tick mark painting is skipped.
    /// </Summary>
    public class _EmptySliderTickMarkShape : FlutterSDK.Material.Slidertheme.SliderTickMarkShape
    {
        public _EmptySliderTickMarkShape()
        { }

        public new Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool))
        {
            return Dart:uiDefaultClass.Size.Zero;
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection))
        {
        }



    }


    /// <Summary>
    /// A special version of [SliderComponentShape] that has a zero size and paints
    /// nothing.
    ///
    /// This class is used to create a special instance of a [SliderComponentShape]
    /// that will not paint any component shape. A static reference is stored in
    /// [SliderTickMarkShape.noThumb] and [SliderTickMarkShape.noOverlay]. When this value
    /// is specified for [SliderThemeData.thumbShape], the thumb painting is
    /// skipped.  When this value is specified for [SliderThemeData.overlaySHape],
    /// the overlay painting is skipped.
    /// </Summary>
    public class _EmptySliderComponentShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        public _EmptySliderComponentShape()
        { }

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete) => Dart:uiDefaultClass.Size.Zero;



public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double))
        {
        }



    }


    /// <Summary>
    /// The default shape of a [Slider]'s thumb.
    ///
    /// See also:
    ///
    ///  * [Slider], which includes a thumb defined by this shape.
    ///  * [SliderTheme], which can be used to configure the thumb shape of all
    ///    sliders in a widget subtree.
    /// </Summary>
    public class RoundSliderThumbShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        public RoundSliderThumbShape(double enabledThumbRadius = 10.0, double disabledThumbRadius = default(double))
        {
            this.EnabledThumbRadius = enabledThumbRadius;
            this.DisabledThumbRadius = disabledThumbRadius;
        }
        public virtual double EnabledThumbRadius { get; set; }
        public virtual double DisabledThumbRadius { get; set; }
        internal virtual double _DisabledThumbRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete)
        {
            return Size.FromRadius(isEnabled == true ? EnabledThumbRadius : _DisabledThumbRadius);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double))
        {






            Canvas canvas = context.Canvas;
            Tween<double> radiusTween = new Tween<double>(begin: _DisabledThumbRadius, end: EnabledThumbRadius);
            ColorTween colorTween = new ColorTween(begin: sliderTheme.DisabledThumbColor, end: sliderTheme.ThumbColor);
            canvas.DrawCircle(center, radiusTween.Evaluate(enableAnimation), new Paint()..Color = colorTween.Evaluate(enableAnimation));
        }



    }


    /// <Summary>
    /// The default shape of a [RangeSlider]'s thumbs.
    ///
    /// See also:
    ///
    ///  * [RangeSlider], which includes thumbs defined by this shape.
    ///  * [SliderTheme], which can be used to configure the thumb shapes of all
    ///    range sliders in a widget subtree.
    /// </Summary>
    public class RoundRangeSliderThumbShape : FlutterSDK.Material.Slidertheme.RangeSliderThumbShape
    {
        public RoundRangeSliderThumbShape(double enabledThumbRadius = 10.0, double disabledThumbRadius = default(double))
        : base()
        {
            this.EnabledThumbRadius = enabledThumbRadius;
            this.DisabledThumbRadius = disabledThumbRadius;
        }
        public virtual double EnabledThumbRadius { get; set; }
        public virtual double DisabledThumbRadius { get; set; }
        internal virtual double _DisabledThumbRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete)
        {
            return Size.FromRadius(isEnabled == true ? EnabledThumbRadius : _DisabledThumbRadius);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = false, bool isEnabled = false, bool isOnTop = default(bool), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb))
        {







            Canvas canvas = context.Canvas;
            Tween<double> radiusTween = new Tween<double>(begin: _DisabledThumbRadius, end: EnabledThumbRadius);
            ColorTween colorTween = new ColorTween(begin: sliderTheme.DisabledThumbColor, end: sliderTheme.ThumbColor);
            double radius = radiusTween.Evaluate(enableAnimation);
            if (isOnTop == true)
            {
                bool showValueIndicator = default(bool);
                switch (sliderTheme.ShowValueIndicator) { case ShowValueIndicator.OnlyForDiscrete: showValueIndicator = isDiscrete; break; case ShowValueIndicator.OnlyForContinuous: showValueIndicator = !isDiscrete; break; case ShowValueIndicator.Always: showValueIndicator = true; break; case ShowValueIndicator.Never: showValueIndicator = false; break; }
                if (!showValueIndicator || activationAnimation.Value == 0)
                {
                    Paint strokePaint = new Paint()..Color = sliderTheme.OverlappingShapeStrokeColor..StrokeWidth = 1.0..Style = PaintingStyle.Stroke;
                    canvas.DrawCircle(center, radius, strokePaint);
                }

            }

            canvas.DrawCircle(center, radius, new Paint()..Color = colorTween.Evaluate(enableAnimation));
        }



    }


    /// <Summary>
    /// The default shape of a [Slider]'s thumb overlay.
    ///
    /// The shape of the overlay is a circle with the same center as the thumb, but
    /// with a larger radius. It animates to full size when the thumb is pressed,
    /// and animates back down to size 0 when it is released. It is painted behind
    /// the thumb, and is expected to extend beyond the bounds of the thumb so that
    /// it is visible.
    ///
    /// The overlay color is defined by [SliderThemeData.overlayColor].
    ///
    /// See also:
    ///
    ///  * [Slider], which includes an overlay defined by this shape.
    ///  * [SliderTheme], which can be used to configure the overlay shape of all
    ///    sliders in a widget subtree.
    /// </Summary>
    public class RoundSliderOverlayShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        public RoundSliderOverlayShape(double overlayRadius = 24.0)
        {
            this.OverlayRadius = overlayRadius;
        }
        public virtual double OverlayRadius { get; set; }

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete)
        {
            return Size.FromRadius(OverlayRadius);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = false, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double))
        {









            Canvas canvas = context.Canvas;
            Tween<double> radiusTween = new Tween<double>(begin: 0.0, end: OverlayRadius);
            canvas.DrawCircle(center, radiusTween.Evaluate(activationAnimation), new Paint()..Color = sliderTheme.OverlayColor);
        }



    }


    /// <Summary>
    /// The default shape of a [Slider]'s value indicator.
    ///
    /// See also:
    ///
    ///  * [Slider], which includes a value indicator defined by this shape.
    ///  * [SliderTheme], which can be used to configure the slider value indicator
    ///    of all sliders in a widget subtree.
    /// </Summary>
    public class PaddleSliderValueIndicatorShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        public PaddleSliderValueIndicatorShape()
        {

        }
        internal virtual FlutterSDK.Material.Slidertheme._PaddleSliderTrackShapePathPainter _PathPainter { get; set; }

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter))
        {

            return _PathPainter.GetPreferredSize(isEnabled, isDiscrete, labelPainter);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double))
        {







            ColorTween enableColor = new ColorTween(begin: sliderTheme.DisabledThumbColor, end: sliderTheme.ValueIndicatorColor);
            _PathPainter.DrawValueIndicator(parentBox, context.Canvas, center, new Paint()..Color = enableColor.Evaluate(enableAnimation), activationAnimation.Value, labelPainter, null);
        }



    }


    /// <Summary>
    /// The default shape of a [RangeSlider]'s value indicators.
    ///
    /// See also:
    ///
    ///  * [RangeSlider], which includes value indicators defined by this shape.
    ///  * [SliderTheme], which can be used to configure the range slider value
    ///    indicator of all sliders in a widget subtree.
    /// </Summary>
    public class PaddleRangeSliderValueIndicatorShape : FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape
    {
        public PaddleRangeSliderValueIndicatorShape()
        {

        }
        internal virtual FlutterSDK.Material.Slidertheme._PaddleSliderTrackShapePathPainter _PathPainter { get; set; }

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter))
        {

            return _PathPainter.GetPreferredSize(isEnabled, isDiscrete, labelPainter);
        }




        public new double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            return _PathPainter.GetHorizontalShift(parentBox: parentBox, center: center, labelPainter: labelPainter, scale: activationAnimation.Value);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isOnTop = false, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb), double value = default(double))
        {







            ColorTween enableColor = new ColorTween(begin: sliderTheme.DisabledThumbColor, end: sliderTheme.ValueIndicatorColor);
            _PathPainter.DrawValueIndicator(parentBox, context.Canvas, center, new Paint()..Color = enableColor.Evaluate(enableAnimation), activationAnimation.Value, labelPainter, isOnTop ? sliderTheme.OverlappingShapeStrokeColor : null);
        }



    }


    public class _PaddleSliderTrackShapePathPainter
    {
        public _PaddleSliderTrackShapePathPainter()
        {

        }
        internal virtual double _TopLobeRadius { get; set; }
        internal virtual double _LabelTextDesignSize { get; set; }
        internal virtual double _BottomLobeRadius { get; set; }
        internal virtual double _LabelPadding { get; set; }
        internal virtual double _DistanceBetweenTopBottomCenters { get; set; }
        internal virtual double _MiddleNeckWidth { get; set; }
        internal virtual double _BottomNeckRadius { get; set; }
        internal virtual double _NeckTriangleBase { get; set; }
        internal virtual double _RightBottomNeckCenterX { get; set; }
        internal virtual double _RightBottomNeckAngleStart { get; set; }
        internal virtual FlutterBinding.UI.Offset _TopLobeCenter { get; set; }
        internal virtual double _TopNeckRadius { get; set; }
        internal virtual double _NeckTriangleHypotenuse { get; set; }
        internal virtual double _TwoSeventyDegrees { get; set; }
        internal virtual double _NinetyDegrees { get; set; }
        internal virtual double _ThirtyDegrees { get; set; }
        internal virtual double _PreferredHeight { get; set; }
        internal virtual bool _DebuggingLabelLocation { get; set; }

        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter)
        {

            double textScaleFactor = labelPainter.Height / _LabelTextDesignSize;
            return new Size(labelPainter.Width + 2 * _LabelPadding * textScaleFactor, _PreferredHeight * textScaleFactor);
        }




        private void _AddArc(Path path, FlutterBinding.UI.Offset center, double radius, double startAngle, double endAngle)
        {

            Rect arcRect = Rect.FromCircle(center: center, radius: radius);
            path.ArcTo(arcRect, startAngle, endAngle - startAngle, false);
        }




        public virtual double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), double scale = default(double))
        {
            double textScaleFactor = labelPainter.Height / _LabelTextDesignSize;
            double inverseTextScale = textScaleFactor != 0 ? 1.0 / textScaleFactor : 0.0;
            double labelHalfWidth = labelPainter.Width / 2.0;
            double halfWidthNeeded = Math.Dart:mathDefaultClass.Max(0.0, inverseTextScale * labelHalfWidth - (_TopLobeRadius - _LabelPadding));
            double shift = _GetIdealOffset(parentBox, halfWidthNeeded, textScaleFactor * scale, center);
            return shift * textScaleFactor;
        }




        private double _GetIdealOffset(FlutterSDK.Rendering.Box.RenderBox parentBox, double halfWidthNeeded, double scale, FlutterBinding.UI.Offset center)
        {
            double edgeMargin = 4.0;
            Rect topLobeRect = Rect.FromLTWH(-_TopLobeRadius - halfWidthNeeded, -_TopLobeRadius - _DistanceBetweenTopBottomCenters, 2.0 * (_TopLobeRadius + halfWidthNeeded), 2.0 * _TopLobeRadius);
            Offset topLeft = (topLobeRect.TopLeft * scale) + center;
            Offset bottomRight = (topLobeRect.BottomRight * scale) + center;
            double shift = 0.0;
            double startGlobal = parentBox.LocalToGlobal(Dart: uiDefaultClass.Offset.Zero).Dx;
            if (topLeft.Dx < startGlobal + edgeMargin)
            {
                shift = startGlobal + edgeMargin - topLeft.Dx;
            }

            double endGlobal = parentBox.LocalToGlobal(new Offset(parentBox.Size.Width, parentBox.Size.Height)).Dx;
            if (bottomRight.Dx > endGlobal - edgeMargin)
            {
                shift = endGlobal - edgeMargin - bottomRight.Dx;
            }

            shift = scale == 0.0 ? 0.0 : shift / scale;
            if (shift < 0.0)
            {
                shift = Math.Dart:mathDefaultClass.Max(shift, -halfWidthNeeded);
            }
            else
            {
                shift = Math.Dart:mathDefaultClass.Min(shift, halfWidthNeeded);
            }

            return shift;
        }




        public virtual void DrawValueIndicator(FlutterSDK.Rendering.Box.RenderBox parentBox, Canvas canvas, FlutterBinding.UI.Offset center, SKPaint paint, double scale, FlutterSDK.Painting.Textpainter.TextPainter labelPainter, FlutterBinding.UI.Color strokePaintColor)
        {
            if (scale == 0.0)
            {
                return;
            }

            double textScaleFactor = labelPainter.Height / _LabelTextDesignSize;
            double overallScale = scale * textScaleFactor;
            double inverseTextScale = textScaleFactor != 0 ? 1.0 / textScaleFactor : 0.0;
            double labelHalfWidth = labelPainter.Width / 2.0;
            canvas.Save();
            canvas.Translate(center.Dx, center.Dy);
            canvas.Scale(overallScale, overallScale);
            double bottomNeckTriangleHypotenuse = _BottomNeckRadius + _BottomLobeRadius / overallScale;
            double rightBottomNeckCenterY = -Math.Dart:mathDefaultClass.Sqrt(Math.Dart:mathDefaultClass.Pow(bottomNeckTriangleHypotenuse, 2) - Math.Dart:mathDefaultClass.Pow(_RightBottomNeckCenterX, 2));
            double rightBottomNeckAngleEnd = Math.Dart:mathDefaultClass.Pi + Math.Dart:mathDefaultClass.Atan(rightBottomNeckCenterY / _RightBottomNeckCenterX);
            Path path = new Path();
            new Path().MoveTo(_MiddleNeckWidth / 2, rightBottomNeckCenterY);
            _AddArc(path, new Offset(_RightBottomNeckCenterX, rightBottomNeckCenterY), _BottomNeckRadius, _RightBottomNeckAngleStart, rightBottomNeckAngleEnd);
            _AddArc(path, Dart: uiDefaultClass.Offset.Zero, _BottomLobeRadius / overallScale, rightBottomNeckAngleEnd - Math.Dart:mathDefaultClass.Pi, 2 * Math.Dart:mathDefaultClass.Pi - rightBottomNeckAngleEnd);
            _AddArc(path, new Offset(-_RightBottomNeckCenterX, rightBottomNeckCenterY), _BottomNeckRadius, Math.Dart:mathDefaultClass.Pi - rightBottomNeckAngleEnd, 0);
            double halfWidthNeeded = Math.Dart:mathDefaultClass.Max(0.0, inverseTextScale * labelHalfWidth - (_TopLobeRadius - _LabelPadding));
            double shift = _GetIdealOffset(parentBox, halfWidthNeeded, overallScale, center);
            double leftWidthNeeded = halfWidthNeeded - shift;
            double rightWidthNeeded = halfWidthNeeded + shift;
            double leftAmount = Math.Dart:mathDefaultClass.Max(0.0, Math.Dart:mathDefaultClass.Min(1.0, leftWidthNeeded / _NeckTriangleBase));
            double rightAmount = Math.Dart:mathDefaultClass.Max(0.0, Math.Dart:mathDefaultClass.Min(1.0, rightWidthNeeded / _NeckTriangleBase));
            double leftTheta = (1.0 - leftAmount) * _ThirtyDegrees;
            double rightTheta = (1.0 - rightAmount) * _ThirtyDegrees;
            Offset leftTopNeckCenter = new Offset(-_NeckTriangleBase, _TopLobeCenter.Dy + Math.Dart:mathDefaultClass.Cos(leftTheta) * _NeckTriangleHypotenuse);
            Offset neckRightCenter = new Offset(_NeckTriangleBase, _TopLobeCenter.Dy + Math.Dart:mathDefaultClass.Cos(rightTheta) * _NeckTriangleHypotenuse);
            double leftNeckArcAngle = _NinetyDegrees - leftTheta;
            double rightNeckArcAngle = Math.Dart:mathDefaultClass.Pi + _NinetyDegrees - rightTheta;
            double neckStretchBaseline = Math.Dart:mathDefaultClass.Max(0.0, rightBottomNeckCenterY - Math.Dart:mathDefaultClass.Max(leftTopNeckCenter.Dy, neckRightCenter.Dy));
            double t = Math.Dart:mathDefaultClass.Pow(inverseTextScale, 3.0) as double;
            double stretch = (neckStretchBaseline * t).Clamp(0.0, 10.0 * neckStretchBaseline) as double;
            Offset neckStretch = new Offset(0.0, neckStretchBaseline - stretch);

            _AddArc(path, leftTopNeckCenter + neckStretch, _TopNeckRadius, 0.0, -leftNeckArcAngle);
            _AddArc(path, _TopLobeCenter - new Offset(leftWidthNeeded, 0.0) + neckStretch, _TopLobeRadius, _NinetyDegrees + leftTheta, _TwoSeventyDegrees);
            _AddArc(path, _TopLobeCenter + new Offset(rightWidthNeeded, 0.0) + neckStretch, _TopLobeRadius, _TwoSeventyDegrees, _TwoSeventyDegrees + Math.Dart:mathDefaultClass.Pi - rightTheta);
            _AddArc(path, neckRightCenter + neckStretch, _TopNeckRadius, rightNeckArcAngle, Math.Dart:mathDefaultClass.Pi);
            if (strokePaintColor != null)
            {
                Paint strokePaint = new Paint()..Color = strokePaintColor..StrokeWidth = 1.0..Style = PaintingStyle.Stroke;
                canvas.DrawPath(path, strokePaint);
            }

            canvas.DrawPath(path, paint);
            canvas.Save();
            canvas.Translate(shift, -_DistanceBetweenTopBottomCenters + neckStretch.Dy);
            canvas.Scale(inverseTextScale, inverseTextScale);
            labelPainter.Paint(canvas, Dart: uiDefaultClass.Offset.Zero - new Offset(labelHalfWidth, labelPainter.Height / 2.0));
            canvas.Restore();
            canvas.Restore();
        }



    }


    /// <Summary>
    /// Object for representing range slider thumb values.
    ///
    /// This object is passed into [RangeSlider.values] to set its values, and it
    /// is emitted in [RangeSlider.onChange], [RangeSlider.onChangeStart], and
    /// [RangeSlider.onChangeEnd] when the values change.
    /// </Summary>
    public class RangeValues
    {
        public RangeValues(double start, double end)
        {
            this.Start = start;
            this.End = end;
        }
        public virtual double Start { get; set; }
        public virtual double End { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is RangeValues && other.Start == Start && other.End == End;
        }




    }


    /// <Summary>
    /// Object for setting range slider label values that appear in the value
    /// indicator for each thumb.
    ///
    /// Used in combination with [RangeSlider.showValueIndicator] to display
    /// labels above the thumbs.
    /// </Summary>
    public class RangeLabels
    {
        public RangeLabels(string start, string end)
        {
            this.Start = start;
            this.End = end;
        }
        public virtual string Start { get; set; }
        public virtual string End { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is RangeLabels && other.Start == Start && other.End == End;
        }




    }


    /// <Summary>
    /// Describes the conditions under which the value indicator on a [Slider]
    /// will be shown. Used with [SliderThemeData.showValueIndicator].
    ///
    /// See also:
    ///
    ///  * [Slider], a Material Design slider widget.
    ///  * [SliderThemeData], which describes the actual configuration of a slider
    ///    theme.
    /// </Summary>
    public enum ShowValueIndicator
    {

        /// <Summary>
        /// The value indicator will only be shown for discrete sliders (sliders
        /// where [Slider.divisions] is non-null).
        /// </Summary>
        OnlyForDiscrete,
        /// <Summary>
        /// The value indicator will only be shown for continuous sliders (sliders
        /// where [Slider.divisions] is null).
        /// </Summary>
        OnlyForContinuous,
        /// <Summary>
        /// The value indicator will be shown for all types of sliders.
        /// </Summary>
        Always,
        /// <Summary>
        /// The value indicator will never be shown.
        /// </Summary>
        Never,
    }


    /// <Summary>
    /// Identifier for a thumb.
    ///
    /// There are 2 thumbs in a [RangeSlider], [start] and [end].
    ///
    /// For [TextDirection.ltr], the [start] thumb is the left-most thumb and the
    /// [end] thumb is the right-most thumb. For [TextDirection.rtl] the [start]
    /// thumb is the right-most thumb, and the [end] thumb is the left-most thumb.
    /// </Summary>
    public enum Thumb
    {

        /// <Summary>
        /// Left-most thumb for [TextDirection.ltr], otherwise, right-most thumb.
        /// </Summary>
        Start,
        /// <Summary>
        /// Right-most thumb for [TextDirection.ltr], otherwise, left-most thumb.
        /// </Summary>
        End,
    }

}
