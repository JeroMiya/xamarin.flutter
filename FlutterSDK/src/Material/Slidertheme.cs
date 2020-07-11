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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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

    public interface ISliderComponentShape
    {
        Size GetPreferredSize(bool isEnabled, bool isDiscrete);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double));
        FlutterSDK.Material.Slidertheme.SliderComponentShape NoThumb { get; }
        FlutterSDK.Material.Slidertheme.SliderComponentShape NoOverlay { get; }
    }


    public interface ISliderTickMarkShape
    {
        Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection));
        FlutterSDK.Material.Slidertheme.SliderTickMarkShape NoTickMark { get; }
    }


    public interface ISliderTrackShape
    {
        Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection));
    }


    public interface IRangeSliderThumbShape
    {
        Size GetPreferredSize(bool isEnabled, bool isDiscrete);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isEnabled = default(bool), bool isOnTop = default(bool), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb));
    }


    public interface IRangeSliderValueIndicatorShape
    {
        Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter));
        double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isOnTop = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb));
    }


    public interface IRangeSliderTickMarkShape
    {
        Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection));
    }


    public interface IRangeSliderTrackShape
    {
        Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool));
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection));
    }


    public interface IBaseSliderTrackShape { }

    public class BaseSliderTrackShape
    {

        public virtual Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false) { throw new NotImplementedException(); }

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


    public class SliderTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        #region constructors
        public SliderTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Slidertheme.SliderThemeData data = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData Data { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        public new bool UpdateShouldNotify(FlutterSDK.Material.Slidertheme.SliderTheme oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliderThemeData : IDiagnosticable
    {
        #region constructors
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
            this.ThumbSelector = thumbSelector; throw new NotImplementedException();
        }
        public static SliderThemeData FromPrimaryColors(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle valueIndicatorTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle))
        {
            var instance = new SliderThemeData(); throw new NotImplementedException();
        }
        #endregion

        #region fields
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
        #endregion

        #region methods

        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData CopyWith(double trackHeight = default(double), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledActiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledInactiveTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledActiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledInactiveTickMarkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color overlappingShapeStrokeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color overlayColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color valueIndicatorColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Slidertheme.SliderComponentShape overlayShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.SliderTickMarkShape tickMarkShape = default(FlutterSDK.Material.Slidertheme.SliderTickMarkShape), FlutterSDK.Material.Slidertheme.SliderComponentShape thumbShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.SliderTrackShape trackShape = default(FlutterSDK.Material.Slidertheme.SliderTrackShape), FlutterSDK.Material.Slidertheme.SliderComponentShape valueIndicatorShape = default(FlutterSDK.Material.Slidertheme.SliderComponentShape), FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape rangeTickMarkShape = default(FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape), FlutterSDK.Material.Slidertheme.RangeSliderThumbShape rangeThumbShape = default(FlutterSDK.Material.Slidertheme.RangeSliderThumbShape), FlutterSDK.Material.Slidertheme.RangeSliderTrackShape rangeTrackShape = default(FlutterSDK.Material.Slidertheme.RangeSliderTrackShape), FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape rangeValueIndicatorShape = default(FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape), FlutterSDK.Material.Slidertheme.ShowValueIndicator showValueIndicator = default(FlutterSDK.Material.Slidertheme.ShowValueIndicator), FlutterSDK.Painting.Textstyle.TextStyle valueIndicatorTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), double minThumbSeparation = default(double), FlutterSDK.Material.Slidertheme.RangeThumbSelector thumbSelector = default(FlutterSDK.Material.Slidertheme.RangeThumbSelector)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Material.Slidertheme.SliderThemeData Lerp(FlutterSDK.Material.Slidertheme.SliderThemeData a, FlutterSDK.Material.Slidertheme.SliderThemeData b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliderComponentShape
    {
        #region constructors
        public SliderComponentShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape NoThumb { get; set; }
        public virtual FlutterSDK.Material.Slidertheme.SliderComponentShape NoOverlay { get; set; }
        #endregion

        #region methods

        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliderTickMarkShape
    {
        #region constructors
        public SliderTickMarkShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Slidertheme.SliderTickMarkShape NoTickMark { get; set; }
        #endregion

        #region methods

        public virtual Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool)) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliderTrackShape
    {
        #region constructors
        public SliderTrackShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool)) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RangeSliderThumbShape
    {
        #region constructors
        public RangeSliderThumbShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isEnabled = default(bool), bool isOnTop = default(bool), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RangeSliderValueIndicatorShape
    {
        #region constructors
        public RangeSliderValueIndicatorShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter)) { throw new NotImplementedException(); }


        public virtual double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>)) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isOnTop = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RangeSliderTickMarkShape
    {
        #region constructors
        public RangeSliderTickMarkShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool)) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RangeSliderTrackShape
    {
        #region constructors
        public RangeSliderTrackShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool), bool isDiscrete = default(bool)) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), bool isDiscrete = default(bool), TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RectangularSliderTrackShape : FlutterSDK.Material.Slidertheme.SliderTrackShape, IBaseSliderTrackShape
    {
        #region constructors
        public RectangularSliderTrackShape(double disabledThumbGapWidth = 2.0)
        {
            this.DisabledThumbGapWidth = disabledThumbGapWidth; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double DisabledThumbGapWidth { get; set; }
        #endregion

        #region methods

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isDiscrete = false, bool isEnabled = false) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundedRectSliderTrackShape : FlutterSDK.Material.Slidertheme.SliderTrackShape, IBaseSliderTrackShape
    {
        #region constructors
        public RoundedRectSliderTrackShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isDiscrete = false, bool isEnabled = false) { throw new NotImplementedException(); }

        #endregion
    }


    public class RectangularRangeSliderTrackShape : FlutterSDK.Material.Slidertheme.RangeSliderTrackShape
    {
        #region constructors
        public RectangularRangeSliderTrackShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false, bool isDiscrete = false, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundedRectRangeSliderTrackShape : FlutterSDK.Material.Slidertheme.RangeSliderTrackShape
    {
        #region constructors
        public RoundedRectRangeSliderTrackShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Rect GetPreferredRect(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false, bool isDiscrete = false) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false, bool isDiscrete = false, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundSliderTickMarkShape : FlutterSDK.Material.Slidertheme.SliderTickMarkShape
    {
        #region constructors
        public RoundSliderTickMarkShape(double tickMarkRadius = default(double))
        {
            this.TickMarkRadius = tickMarkRadius; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double TickMarkRadius { get; set; }
        #endregion

        #region methods

        public new Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundRangeSliderTickMarkShape : FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape
    {
        #region constructors
        public RoundRangeSliderTickMarkShape(double tickMarkRadius = default(double))
        {
            this.TickMarkRadius = tickMarkRadius; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double TickMarkRadius { get; set; }
        #endregion

        #region methods

        public new Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = false) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset startThumbCenter = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endThumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = false, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _EmptySliderTickMarkShape : FlutterSDK.Material.Slidertheme.SliderTickMarkShape
    {
        #region constructors
        public _EmptySliderTickMarkShape()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Size GetPreferredSize(FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), bool isEnabled = default(bool)) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset thumbCenter = default(FlutterBinding.UI.Offset), bool isEnabled = default(bool), TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _EmptySliderComponentShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        #region constructors
        public _EmptySliderComponentShape()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundSliderThumbShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        #region constructors
        public RoundSliderThumbShape(double enabledThumbRadius = 10.0, double disabledThumbRadius = default(double))
        {
            this.EnabledThumbRadius = enabledThumbRadius;
            this.DisabledThumbRadius = disabledThumbRadius; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double EnabledThumbRadius { get; set; }
        public virtual double DisabledThumbRadius { get; set; }
        internal virtual double _DisabledThumbRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundRangeSliderThumbShape : FlutterSDK.Material.Slidertheme.RangeSliderThumbShape
    {
        #region constructors
        public RoundRangeSliderThumbShape(double enabledThumbRadius = 10.0, double disabledThumbRadius = default(double))
        : base()
        {
            this.EnabledThumbRadius = enabledThumbRadius;
            this.DisabledThumbRadius = disabledThumbRadius; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double EnabledThumbRadius { get; set; }
        public virtual double DisabledThumbRadius { get; set; }
        internal virtual double _DisabledThumbRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = false, bool isEnabled = false, bool isOnTop = default(bool), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RoundSliderOverlayShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        #region constructors
        public RoundSliderOverlayShape(double overlayRadius = 24.0)
        {
            this.OverlayRadius = overlayRadius; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double OverlayRadius { get; set; }
        #endregion

        #region methods

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = false, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class PaddleSliderValueIndicatorShape : FlutterSDK.Material.Slidertheme.SliderComponentShape
    {
        #region constructors
        public PaddleSliderValueIndicatorShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Material.Slidertheme._PaddleSliderTrackShapePathPainter _PathPainter { get; set; }
        #endregion

        #region methods

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter)) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), double value = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class PaddleRangeSliderValueIndicatorShape : FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape
    {
        #region constructors
        public PaddleRangeSliderValueIndicatorShape()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Material.Slidertheme._PaddleSliderTrackShapePathPainter _PathPainter { get; set; }
        #endregion

        #region methods

        public new Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter)) { throw new NotImplementedException(); }


        public new double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>)) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset center, FlutterSDK.Animation.Animation.Animation<double> activationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), bool isDiscrete = default(bool), bool isOnTop = false, FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Slidertheme.Thumb thumb = default(FlutterSDK.Material.Slidertheme.Thumb), double value = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _PaddleSliderTrackShapePathPainter
    {
        #region constructors
        public _PaddleSliderTrackShapePathPainter()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
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
        #endregion

        #region methods

        public virtual Size GetPreferredSize(bool isEnabled, bool isDiscrete, FlutterSDK.Painting.Textpainter.TextPainter labelPainter) { throw new NotImplementedException(); }


        private void _AddArc(Path path, FlutterBinding.UI.Offset center, double radius, double startAngle, double endAngle) { throw new NotImplementedException(); }


        public virtual double GetHorizontalShift(FlutterSDK.Rendering.Box.RenderBox parentBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Textpainter.TextPainter labelPainter = default(FlutterSDK.Painting.Textpainter.TextPainter), double scale = default(double)) { throw new NotImplementedException(); }


        private double _GetIdealOffset(FlutterSDK.Rendering.Box.RenderBox parentBox, double halfWidthNeeded, double scale, FlutterBinding.UI.Offset center) { throw new NotImplementedException(); }


        public virtual void DrawValueIndicator(FlutterSDK.Rendering.Box.RenderBox parentBox, Canvas canvas, FlutterBinding.UI.Offset center, SKPaint paint, double scale, FlutterSDK.Painting.Textpainter.TextPainter labelPainter, FlutterBinding.UI.Color strokePaintColor) { throw new NotImplementedException(); }

        #endregion
    }


    public class RangeValues
    {
        #region constructors
        public RangeValues(double start, double end)
        {
            this.Start = start;
            this.End = end; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Start { get; set; }
        public virtual double End { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class RangeLabels
    {
        #region constructors
        public RangeLabels(string start, string end)
        {
            this.Start = start;
            this.End = end; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string Start { get; set; }
        public virtual string End { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public enum ShowValueIndicator
    {

        OnlyForDiscrete,
        OnlyForContinuous,
        Always,
        Never,
    }


    public enum Thumb
    {

        Start,
        End,
    }

}
