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
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Scrollview
{
    internal static class ScrollviewDefaultClass
    {
    }

    /// <Summary>
    /// A widget that scrolls.
    ///
    /// Scrollable widgets consist of three pieces:
    ///
    ///  1. A [Scrollable] widget, which listens for various user gestures and
    ///     implements the interaction design for scrolling.
    ///  2. A viewport widget, such as [Viewport] or [ShrinkWrappingViewport], which
    ///     implements the visual design for scrolling by displaying only a portion
    ///     of the widgets inside the scroll view.
    ///  3. One or more slivers, which are widgets that can be composed to created
    ///     various scrolling effects, such as lists, grids, and expanding headers.
    ///
    /// [ScrollView] helps orchestrate these pieces by creating the [Scrollable] and
    /// the viewport and deferring to its subclass to create the slivers.
    ///
    /// To control the initial scroll offset of the scroll view, provide a
    /// [controller] with its [ScrollController.initialScrollOffset] property set.
    ///
    /// See also:
    ///
    ///  * [ListView], which is a commonly used [ScrollView] that displays a
    ///    scrolling, linear list of child widgets.
    ///  * [PageView], which is a scrolling list of child widgets that are each the
    ///    size of the viewport.
    ///  * [GridView], which is a [ScrollView] that displays a scrolling, 2D array
    ///    of child widgets.
    ///  * [CustomScrollView], which is a [ScrollView] that creates custom scroll
    ///    effects using slivers.
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public interface IScrollView
    {
        FlutterSDK.Painting.Basictypes.AxisDirection GetDirection(FlutterSDK.Widgets.Framework.BuildContext context);
        List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context);
        FlutterSDK.Widgets.Framework.Widget BuildViewport(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection, List<FlutterSDK.Widgets.Framework.Widget> slivers);
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; }
        bool Reverse { get; }
        FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; }
        bool Primary { get; }
        FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; }
        bool ShrinkWrap { get; }
        FlutterSDK.Foundation.Key.Key Center { get; }
        double Anchor { get; }
        double CacheExtent { get; }
        int SemanticChildCount { get; }
        FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; }
        FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior KeyboardDismissBehavior { get; }
    }


    /// <Summary>
    /// A [ScrollView] that uses a single child layout model.
    ///
    /// See also:
    ///
    ///  * [ListView], which is a [BoxScrollView] that uses a linear layout model.
    ///  * [GridView], which is a [BoxScrollView] that uses a 2D layout model.
    ///  * [CustomScrollView], which can combine multiple child layout models into a
    ///    single scroll view.
    /// </Summary>
    public interface IBoxScrollView
    {
        List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context);
        FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; }
    }


    /// <Summary>
    /// A widget that scrolls.
    ///
    /// Scrollable widgets consist of three pieces:
    ///
    ///  1. A [Scrollable] widget, which listens for various user gestures and
    ///     implements the interaction design for scrolling.
    ///  2. A viewport widget, such as [Viewport] or [ShrinkWrappingViewport], which
    ///     implements the visual design for scrolling by displaying only a portion
    ///     of the widgets inside the scroll view.
    ///  3. One or more slivers, which are widgets that can be composed to created
    ///     various scrolling effects, such as lists, grids, and expanding headers.
    ///
    /// [ScrollView] helps orchestrate these pieces by creating the [Scrollable] and
    /// the viewport and deferring to its subclass to create the slivers.
    ///
    /// To control the initial scroll offset of the scroll view, provide a
    /// [controller] with its [ScrollController.initialScrollOffset] property set.
    ///
    /// See also:
    ///
    ///  * [ListView], which is a commonly used [ScrollView] that displays a
    ///    scrolling, linear list of child widgets.
    ///  * [PageView], which is a scrolling list of child widgets that are each the
    ///    size of the viewport.
    ///  * [GridView], which is a [ScrollView] that displays a scrolling, 2D array
    ///    of child widgets.
    ///  * [CustomScrollView], which is a [ScrollView] that creates custom scroll
    ///    effects using slivers.
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public class ScrollView : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public ScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Foundation.Key.Key center = default(FlutterSDK.Foundation.Key.Key), double anchor = 0.0, double cacheExtent = default(double), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
    public virtual bool Reverse { get; set; }
    public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
    public virtual bool Primary { get; set; }
    public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
    public virtual bool ShrinkWrap { get; set; }
    public virtual FlutterSDK.Foundation.Key.Key Center { get; set; }
    public virtual double Anchor { get; set; }
    public virtual double CacheExtent { get; set; }
    public virtual int SemanticChildCount { get; set; }
    public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
    public virtual FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior KeyboardDismissBehavior { get; set; }
    #endregion

    #region methods

    /// <Summary>
    /// Returns the [AxisDirection] in which the scroll view scrolls.
    ///
    /// Combines the [scrollDirection] with the [reverse] boolean to obtain the
    /// concrete [AxisDirection].
    ///
    /// If the [scrollDirection] is [Axis.horizontal], the ambient
    /// [Directionality] is also considered when selecting the concrete
    /// [AxisDirection]. For example, if the ambient [Directionality] is
    /// [TextDirection.rtl], then the non-reversed [AxisDirection] is
    /// [AxisDirection.left] and the reversed [AxisDirection] is
    /// [AxisDirection.right].
    /// </Summary>
    public virtual FlutterSDK.Painting.Basictypes.AxisDirection GetDirection(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return BasicDefaultClass.GetAxisDirectionFromAxisReverseAndDirectionality(context, ScrollDirection, Reverse);
    }




    /// <Summary>
    /// Build the list of widgets to place inside the viewport.
    ///
    /// Subclasses should override this method to build the slivers for the inside
    /// of the viewport.
    /// </Summary>
    public virtual List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return default(List<Widget>);
    }


    /// <Summary>
    /// Build the viewport.
    ///
    /// Subclasses may override this method to change how the viewport is built.
    /// The default implementation uses a [ShrinkWrappingViewport] if [shrinkWrap]
    /// is true, and a regular [Viewport] otherwise.
    ///
    /// The `offset` argument is the value obtained from
    /// [Scrollable.viewportBuilder].
    ///
    /// The `axisDirection` argument is the value obtained from [getDirection],
    /// which by default uses [scrollDirection] and [reverse].
    ///
    /// The `slivers` argument is the value obtained from [buildSlivers].
    /// </Summary>
    public virtual FlutterSDK.Widgets.Framework.Widget BuildViewport(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection, List<FlutterSDK.Widgets.Framework.Widget> slivers)
    {
        if (ShrinkWrap)
        {
            return new ShrinkWrappingViewport(axisDirection: axisDirection, offset: offset, slivers: slivers);
        }

        return new Viewport(axisDirection: axisDirection, offset: offset, slivers: slivers, cacheExtent: CacheExtent, center: Center, anchor: Anchor);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        List<Widget> slivers = BuildSlivers(context);
        AxisDirection axisDirection = GetDirection(context);
        ScrollController scrollController = Primary ? PrimaryscrollcontrollerDefaultClass.PrimaryScrollController.Of(context) : Controller;
        Scrollable scrollable = new Scrollable(dragStartBehavior: DragStartBehavior, axisDirection: axisDirection, controller: scrollController, physics: Physics, semanticChildCount: SemanticChildCount, viewportBuilder: (BuildContext context, ViewportOffset offset) =>
        {
            return BuildViewport(context, offset, axisDirection, slivers);
        }
        );
        Widget scrollableResult = Primary && scrollController != null ? PrimaryScrollController.None(child: scrollable) : scrollable;
        if (KeyboardDismissBehavior == ScrollViewKeyboardDismissBehavior.OnDrag)
        {
            return new NotificationListener<ScrollUpdateNotification>(child: scrollableResult, onNotification: (ScrollUpdateNotification notification) =>
            {
                FocusScopeNode focusScope = FocusscopeDefaultClass.FocusScope.Of(context);
                if (notification.DragDetails != null && focusScope.HasFocus)
                {
                    focusScope.Unfocus();
                }

                return false;
            }
            );
        }
        else
        {
            return scrollableResult;
        }

    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new EnumProperty<Axis>("scrollDirection", ScrollDirection));
        properties.Add(new FlagProperty("reverse", value: Reverse, ifTrue: "reversed", showName: true));
        properties.Add(new DiagnosticsProperty<ScrollController>("controller", Controller, showName: false, defaultValue: null));
        properties.Add(new FlagProperty("primary", value: Primary, ifTrue: "using primary controller", showName: true));
        properties.Add(new DiagnosticsProperty<ScrollPhysics>("physics", Physics, showName: false, defaultValue: null));
        properties.Add(new FlagProperty("shrinkWrap", value: ShrinkWrap, ifTrue: "shrink-wrapping", showName: true));
    }



    #endregion
}


/// <Summary>
/// A [ScrollView] that creates custom scroll effects using slivers.
///
/// A [CustomScrollView] lets you supply [slivers] directly to create various
/// scrolling effects, such as lists, grids, and expanding headers. For example,
/// to create a scroll view that contains an expanding app bar followed by a
/// list and a grid, use a list of three slivers: [SliverAppBar], [SliverList],
/// and [SliverGrid].
///
/// [Widget]s in these [slivers] must produce [RenderSliver] objects.
///
/// To control the initial scroll offset of the scroll view, provide a
/// [controller] with its [ScrollController.initialScrollOffset] property set.
///
/// {@animation 400 376 https://flutter.github.io/assets-for-api-docs/assets/widgets/custom_scroll_view.mp4}
///
/// {@tool snippet}
///
/// This sample code shows a scroll view that contains a flexible pinned app
/// bar, a grid, and an infinite list.
///
/// ```dart
/// CustomScrollView(
///   slivers: <Widget>[
///     const SliverAppBar(
///       pinned: true,
///       expandedHeight: 250.0,
///       flexibleSpace: FlexibleSpaceBar(
///         title: Text('Demo'),
///       ),
///     ),
///     SliverGrid(
///       gridDelegate: SliverGridDelegateWithMaxCrossAxisExtent(
///         maxCrossAxisExtent: 200.0,
///         mainAxisSpacing: 10.0,
///         crossAxisSpacing: 10.0,
///         childAspectRatio: 4.0,
///       ),
///       delegate: SliverChildBuilderDelegate(
///         (BuildContext context, int index) {
///           return Container(
///             alignment: Alignment.center,
///             color: Colors.teal[100 * (index % 9)],
///             child: Text('Grid Item $index'),
///           );
///         },
///         childCount: 20,
///       ),
///     ),
///     SliverFixedExtentList(
///       itemExtent: 50.0,
///       delegate: SliverChildBuilderDelegate(
///         (BuildContext context, int index) {
///           return Container(
///             alignment: Alignment.center,
///             color: Colors.lightBlue[100 * (index % 9)],
///             child: Text('List Item $index'),
///           );
///         },
///       ),
///     ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// ## Accessibility
///
/// A [CustomScrollView] can allow Talkback/VoiceOver to make announcements
/// to the user when the scroll state changes. For example, on Android an
/// announcement might be read as "showing items 1 to 10 of 23". To produce
/// this announcement, the scroll view needs three pieces of information:
///
///   * The first visible child index.
///   * The total number of children.
///   * The total number of visible children.
///
/// The last value can be computed exactly by the framework, however the first
/// two must be provided. Most of the higher-level scrollable widgets provide
/// this information automatically. For example, [ListView] provides each child
/// widget with a semantic index automatically and sets the semantic child
/// count to the length of the list.
///
/// To determine visible indexes, the scroll view needs a way to associate the
/// generated semantics of each scrollable item with a semantic index. This can
/// be done by wrapping the child widgets in an [IndexedSemantics].
///
/// This semantic index is not necessarily the same as the index of the widget in
/// the scrollable, because some widgets may not contribute semantic
/// information. Consider a [ListView.separated]: every other widget is a
/// divider with no semantic information. In this case, only odd numbered
/// widgets have a semantic index (equal to the index ~/ 2). Furthermore, the
/// total number of children in this example would be half the number of
/// widgets. (The [ListView.separated] constructor handles this
/// automatically; this is only used here as an example.)
///
/// The total number of visible children can be provided by the constructor
/// parameter `semanticChildCount`. This should always be the same as the
/// number of widgets wrapped in [IndexedSemantics].
///
/// See also:
///
///  * [SliverList], which is a sliver that displays linear list of children.
///  * [SliverFixedExtentList], which is a more efficient sliver that displays
///    linear list of children that have the same extent along the scroll axis.
///  * [SliverGrid], which is a sliver that displays a 2D array of children.
///  * [SliverPadding], which is a sliver that adds blank space around another
///    sliver.
///  * [SliverAppBar], which is a sliver that displays a header that can expand
///    and float as the scroll view scrolls.
///  * [ScrollNotification] and [NotificationListener], which can be used to watch
///    the scroll position without using a [ScrollController].
///  * [IndexedSemantics], which allows annotating child lists with an index
///    for scroll announcements.
/// </Summary>
public class CustomScrollView : FlutterSDK.Widgets.Scrollview.ScrollView
{
    #region constructors
    public CustomScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Foundation.Key.Key center = default(FlutterSDK.Foundation.Key.Key), double anchor = 0.0, double cacheExtent = default(double), List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
    : base(key: key, scrollDirection: scrollDirection, reverse: reverse, controller: controller, primary: primary, physics: physics, shrinkWrap: shrinkWrap, center: center, anchor: anchor, cacheExtent: cacheExtent, semanticChildCount: semanticChildCount, dragStartBehavior: dragStartBehavior)

}
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Framework.Widget> Slivers { get; set; }
#endregion

#region methods

public new List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context) => Slivers;


#endregion
}


/// <Summary>
/// A [ScrollView] that uses a single child layout model.
///
/// See also:
///
///  * [ListView], which is a [BoxScrollView] that uses a linear layout model.
///  * [GridView], which is a [BoxScrollView] that uses a 2D layout model.
///  * [CustomScrollView], which can combine multiple child layout models into a
///    single scroll view.
/// </Summary>
public class BoxScrollView : FlutterSDK.Widgets.Scrollview.ScrollView
{
    #region constructors
    public BoxScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double cacheExtent = default(double), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
    : base(key: key, scrollDirection: scrollDirection, reverse: reverse, controller: controller, primary: primary, physics: physics, shrinkWrap: shrinkWrap, cacheExtent: cacheExtent, semanticChildCount: semanticChildCount, dragStartBehavior: dragStartBehavior, keyboardDismissBehavior: keyboardDismissBehavior)

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
#endregion

#region methods

public new List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context)
{
    Widget sliver = BuildChildLayout(context);
    EdgeInsetsGeometry effectivePadding = Padding;
    if (Padding == null)
    {
        MediaQueryData mediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true);
        if (mediaQuery != null)
        {
            EdgeInsets mediaQueryHorizontalPadding = mediaQuery.Padding.CopyWith(top: 0.0, bottom: 0.0);
            EdgeInsets mediaQueryVerticalPadding = mediaQuery.Padding.CopyWith(left: 0.0, right: 0.0);
            effectivePadding = ScrollDirection == Axis.Vertical ? mediaQueryVerticalPadding : mediaQueryHorizontalPadding;
            sliver = new MediaQuery(data: mediaQuery.CopyWith(padding: ScrollDirection == Axis.Vertical ? mediaQueryHorizontalPadding : mediaQueryVerticalPadding), child: sliver);
        }

    }

    if (effectivePadding != null) sliver = new SliverPadding(padding: effectivePadding, sliver: sliver);
    return new List<Widget>() { sliver };
}




/// <Summary>
/// Subclasses should override this method to build the layout model.
/// </Summary>
public virtual FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return default(Widget);
}


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
}



#endregion
}


/// <Summary>
/// A scrollable list of widgets arranged linearly.
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=KJpkjHGiI5A}
///
/// [ListView] is the most commonly used scrolling widget. It displays its
/// children one after another in the scroll direction. In the cross axis, the
/// children are required to fill the [ListView].
///
/// If non-null, the [itemExtent] forces the children to have the given extent
/// in the scroll direction. Specifying an [itemExtent] is more efficient than
/// letting the children determine their own extent because the scrolling
/// machinery can make use of the foreknowledge of the children's extent to save
/// work, for example when the scroll position changes drastically.
///
/// There are four options for constructing a [ListView]:
///
///  1. The default constructor takes an explicit [List<Widget>] of children. This
///     constructor is appropriate for list views with a small number of
///     children because constructing the [List] requires doing work for every
///     child that could possibly be displayed in the list view instead of just
///     those children that are actually visible.
///
///  2. The [ListView.builder] constructor takes an [IndexedWidgetBuilder], which
///     builds the children on demand. This constructor is appropriate for list views
///     with a large (or infinite) number of children because the builder is called
///     only for those children that are actually visible.
///
///  3. The [ListView.separated] constructor takes two [IndexedWidgetBuilder]s:
///     `itemBuilder` builds child items on demand, and `separatorBuilder`
///     similarly builds separator children which appear in between the child items.
///     This constructor is appropriate for list views with a fixed number of children.
///
///  4. The [ListView.custom] constructor takes a [SliverChildDelegate], which provides
///     the ability to customize additional aspects of the child model. For example,
///     a [SliverChildDelegate] can control the algorithm used to estimate the
///     size of children that are not actually visible.
///
/// To control the initial scroll offset of the scroll view, provide a
/// [controller] with its [ScrollController.initialScrollOffset] property set.
///
/// By default, [ListView] will automatically pad the list's scrollable
/// extremities to avoid partial obstructions indicated by [MediaQuery]'s
/// padding. To avoid this behavior, override with a zero [padding] property.
///
/// {@tool snippet}
/// This example uses the default constructor for [ListView] which takes an
/// explicit [List<Widget>] of children. This [ListView]'s children are made up
/// of [Container]s with [Text].
///
/// ![A ListView of 3 amber colored containers with sample text.](https://flutter.github.io/assets-for-api-docs/assets/widgets/list_view.png)
///
/// ```dart
/// ListView(
///   padding: const EdgeInsets.all(8),
///   children: <Widget>[
///     Container(
///       height: 50,
///       color: Colors.amber[600],
///       child: const Center(child: Text('Entry A')),
///     ),
///     Container(
///       height: 50,
///       color: Colors.amber[500],
///       child: const Center(child: Text('Entry B')),
///     ),
///     Container(
///       height: 50,
///       color: Colors.amber[100],
///       child: const Center(child: Text('Entry C')),
///     ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// {@tool snippet}
/// This example mirrors the previous one, creating the same list using the
/// [ListView.builder] constructor. Using the [IndexedWidgetBuilder], children
/// are built lazily and can be infinite in number.
///
/// ![A ListView of 3 amber colored containers with sample text.](https://flutter.github.io/assets-for-api-docs/assets/widgets/list_view_builder.png)
///
/// ```dart
/// final List<String> entries = <String>['A', 'B', 'C'];
/// final List<int> colorCodes = <int>[600, 500, 100];
///
/// ListView.builder(
///   padding: const EdgeInsets.all(8),
///   itemCount: entries.length,
///   itemBuilder: (BuildContext context, int index) {
///     return Container(
///       height: 50,
///       color: Colors.amber[colorCodes[index]],
///       child: Center(child: Text('Entry ${entries[index]}')),
///     );
///   }
/// );
/// ```
/// {@end-tool}
///
/// {@tool snippet}
/// This example continues to build from our the previous ones, creating a
/// similar list using [ListView.separated]. Here, a [Divider] is used as a
/// separator.
///
/// ![A ListView of 3 amber colored containers with sample text and a Divider
/// between each of them.](https://flutter.github.io/assets-for-api-docs/assets/widgets/list_view_separated.png)
///
/// ```dart
/// final List<String> entries = <String>['A', 'B', 'C'];
/// final List<int> colorCodes = <int>[600, 500, 100];
///
/// ListView.separated(
///   padding: const EdgeInsets.all(8),
///   itemCount: entries.length,
///   itemBuilder: (BuildContext context, int index) {
///     return Container(
///       height: 50,
///       color: Colors.amber[colorCodes[index]],
///       child: Center(child: Text('Entry ${entries[index]}')),
///     );
///   },
///   separatorBuilder: (BuildContext context, int index) => const Divider(),
/// );
/// ```
/// {@end-tool}
///
/// ## Child elements' lifecycle
///
/// ### Creation
///
/// While laying out the list, visible children's elements, states and render
/// objects will be created lazily based on existing widgets (such as when using
/// the default constructor) or lazily provided ones (such as when using the
/// [ListView.builder] constructor).
///
/// ### Destruction
///
/// When a child is scrolled out of view, the associated element subtree,
/// states and render objects are destroyed. A new child at the same position
/// in the list will be lazily recreated along with new elements, states and
/// render objects when it is scrolled back.
///
/// ### Destruction mitigation
///
/// In order to preserve state as child elements are scrolled in and out of
/// view, the following options are possible:
///
///  * Moving the ownership of non-trivial UI-state-driving business logic
///    out of the list child subtree. For instance, if a list contains posts
///    with their number of upvotes coming from a cached network response, store
///    the list of posts and upvote number in a data model outside the list. Let
///    the list child UI subtree be easily recreate-able from the
///    source-of-truth model object. Use [StatefulWidget]s in the child
///    widget subtree to store instantaneous UI state only.
///
///  * Letting [KeepAlive] be the root widget of the list child widget subtree
///    that needs to be preserved. The [KeepAlive] widget marks the child
///    subtree's top render object child for keepalive. When the associated top
///    render object is scrolled out of view, the list keeps the child's render
///    object (and by extension, its associated elements and states) in a cache
///    list instead of destroying them. When scrolled back into view, the render
///    object is repainted as-is (if it wasn't marked dirty in the interim).
///
///    This only works if [addAutomaticKeepAlives] and [addRepaintBoundaries]
///    are false since those parameters cause the [ListView] to wrap each child
///    widget subtree with other widgets.
///
///  * Using [AutomaticKeepAlive] widgets (inserted by default when
///    [addAutomaticKeepAlives] is true). [AutomaticKeepAlive] allows descendant
///    widgets to control whether the subtree is actually kept alive or not.
///    This behavior is in contrast with [KeepAlive], which will unconditionally keep
///    the subtree alive.
///
///    As an example, the [EditableText] widget signals its list child element
///    subtree to stay alive while its text field has input focus. If it doesn't
///    have focus and no other descendants signaled for keepalive via a
///    [KeepAliveNotification], the list child element subtree will be destroyed
///    when scrolled away.
///
///    [AutomaticKeepAlive] descendants typically signal it to be kept alive
///    by using the [AutomaticKeepAliveClientMixin], then implementing the
///    [wantKeepAlive] getter and calling [updateKeepAlive].
///
/// ## Transitioning to [CustomScrollView]
///
/// A [ListView] is basically a [CustomScrollView] with a single [SliverList] in
/// its [CustomScrollView.slivers] property.
///
/// If [ListView] is no longer sufficient, for example because the scroll view
/// is to have both a list and a grid, or because the list is to be combined
/// with a [SliverAppBar], etc, it is straight-forward to port code from using
/// [ListView] to using [CustomScrollView] directly.
///
/// The [key], [scrollDirection], [reverse], [controller], [primary], [physics],
/// and [shrinkWrap] properties on [ListView] map directly to the identically
/// named properties on [CustomScrollView].
///
/// The [CustomScrollView.slivers] property should be a list containing either a
/// [SliverList] or a [SliverFixedExtentList]; the former if [itemExtent] on the
/// [ListView] was null, and the latter if [itemExtent] was not null.
///
/// The [childrenDelegate] property on [ListView] corresponds to the
/// [SliverList.delegate] (or [SliverFixedExtentList.delegate]) property. The
/// [ListView] constructor's `children` argument corresponds to the
/// [childrenDelegate] being a [SliverChildListDelegate] with that same
/// argument. The [ListView.builder] constructor's `itemBuilder` and
/// `itemCount` arguments correspond to the [childrenDelegate] being a
/// [SliverChildBuilderDelegate] with the equivalent arguments.
///
/// The [padding] property corresponds to having a [SliverPadding] in the
/// [CustomScrollView.slivers] property instead of the list itself, and having
/// the [SliverList] instead be a child of the [SliverPadding].
///
/// [CustomScrollView]s don't automatically avoid obstructions from [MediaQuery]
/// like [ListView]s do. To reproduce the behavior, wrap the slivers in
/// [SliverSafeArea]s.
///
/// Once code has been ported to use [CustomScrollView], other slivers, such as
/// [SliverGrid] or [SliverAppBar], can be put in the [CustomScrollView.slivers]
/// list.
///
/// {@tool snippet}
///
/// Here are two brief snippets showing a [ListView] and its equivalent using
/// [CustomScrollView]:
///
/// ```dart
/// ListView(
///   shrinkWrap: true,
///   padding: const EdgeInsets.all(20.0),
///   children: <Widget>[
///     const Text("I'm dedicating every day to you"),
///     const Text('Domestic life was never quite my style'),
///     const Text('When you smile, you knock me out, I fall apart'),
///     const Text('And I thought I was so smart'),
///   ],
/// )
/// ```
/// {@end-tool}
/// {@tool snippet}
///
/// ```dart
/// CustomScrollView(
///   shrinkWrap: true,
///   slivers: <Widget>[
///     SliverPadding(
///       padding: const EdgeInsets.all(20.0),
///       sliver: SliverList(
///         delegate: SliverChildListDelegate(
///           <Widget>[
///             const Text("I'm dedicating every day to you"),
///             const Text('Domestic life was never quite my style'),
///             const Text('When you smile, you knock me out, I fall apart'),
///             const Text('And I thought I was so smart'),
///           ],
///         ),
///       ),
///     ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [SingleChildScrollView], which is a scrollable widget that has a single
///    child.
///  * [PageView], which is a scrolling list of child widgets that are each the
///    size of the viewport.
///  * [GridView], which is scrollable, 2D array of widgets.
///  * [CustomScrollView], which is a scrollable widget that creates custom
///    scroll effects using slivers.
///  * [ListBody], which arranges its children in a similar manner, but without
///    scrolling.
///  * [ScrollNotification] and [NotificationListener], which can be used to watch
///    the scroll position without using a [ScrollController].
///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
/// </Summary>
public class ListView : FlutterSDK.Widgets.Scrollview.BoxScrollView
{
    #region constructors
    public ListView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double itemExtent = default(double), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, double cacheExtent = default(double), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
    : base(key: key, scrollDirection: scrollDirection, reverse: reverse, controller: controller, primary: primary, physics: physics, shrinkWrap: shrinkWrap, padding: padding, cacheExtent: cacheExtent, semanticChildCount: semanticChildCount ?? children.Count, dragStartBehavior: dragStartBehavior, keyboardDismissBehavior: keyboardDismissBehavior)

}
public static ListView Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double itemExtent = default(double), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), int itemCount = default(int), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, double cacheExtent = default(double), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))

}
public static ListView Separated(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder separatorBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), int itemCount = default(int), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, double cacheExtent = default(double), FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))

}
public static ListView Custom(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double itemExtent = default(double), FlutterSDK.Widgets.Sliver.SliverChildDelegate childrenDelegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), double cacheExtent = default(double), int semanticChildCount = default(int))

}
#endregion

#region fields
public virtual double ItemExtent { get; set; }
public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate ChildrenDelegate { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context)
{
    if (ItemExtent != null)
    {
        return new SliverFixedExtentList(@delegate: ChildrenDelegate, itemExtent: ItemExtent);
    }

    return new SliverList(@delegate: ChildrenDelegate);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("itemExtent", ItemExtent, defaultValue: null));
}




private int _ComputeActualChildCount(int itemCount)
{
    return Math.Dart:mathDefaultClass.Max(0, itemCount * 2 - 1);
}



#endregion
}


/// <Summary>
/// A scrollable, 2D array of widgets.
///
/// The main axis direction of a grid is the direction in which it scrolls (the
/// [scrollDirection]).
///
/// The most commonly used grid layouts are [GridView.count], which creates a
/// layout with a fixed number of tiles in the cross axis, and
/// [GridView.extent], which creates a layout with tiles that have a maximum
/// cross-axis extent. A custom [SliverGridDelegate] can produce an arbitrary 2D
/// arrangement of children, including arrangements that are unaligned or
/// overlapping.
///
/// To create a grid with a large (or infinite) number of children, use the
/// [GridView.builder] constructor with either a
/// [SliverGridDelegateWithFixedCrossAxisCount] or a
/// [SliverGridDelegateWithMaxCrossAxisExtent] for the [gridDelegate].
///
/// To use a custom [SliverChildDelegate], use [GridView.custom].
///
/// To create a linear array of children, use a [ListView].
///
/// To control the initial scroll offset of the scroll view, provide a
/// [controller] with its [ScrollController.initialScrollOffset] property set.
///
/// ## Transitioning to [CustomScrollView]
///
/// A [GridView] is basically a [CustomScrollView] with a single [SliverGrid] in
/// its [CustomScrollView.slivers] property.
///
/// If [GridView] is no longer sufficient, for example because the scroll view
/// is to have both a grid and a list, or because the grid is to be combined
/// with a [SliverAppBar], etc, it is straight-forward to port code from using
/// [GridView] to using [CustomScrollView] directly.
///
/// The [key], [scrollDirection], [reverse], [controller], [primary], [physics],
/// and [shrinkWrap] properties on [GridView] map directly to the identically
/// named properties on [CustomScrollView].
///
/// The [CustomScrollView.slivers] property should be a list containing just a
/// [SliverGrid].
///
/// The [childrenDelegate] property on [GridView] corresponds to the
/// [SliverGrid.delegate] property, and the [gridDelegate] property on the
/// [GridView] corresponds to the [SliverGrid.gridDelegate] property.
///
/// The [GridView], [GridView.count], and [GridView.extent]
/// constructors' `children` arguments correspond to the [childrenDelegate]
/// being a [SliverChildListDelegate] with that same argument. The
/// [GridView.builder] constructor's `itemBuilder` and `childCount` arguments
/// correspond to the [childrenDelegate] being a [SliverChildBuilderDelegate]
/// with the matching arguments.
///
/// The [GridView.count] and [GridView.extent] constructors create
/// custom grid delegates, and have equivalently named constructors on
/// [SliverGrid] to ease the transition: [SliverGrid.count] and
/// [SliverGrid.extent] respectively.
///
/// The [padding] property corresponds to having a [SliverPadding] in the
/// [CustomScrollView.slivers] property instead of the grid itself, and having
/// the [SliverGrid] instead be a child of the [SliverPadding].
///
/// By default, [ListView] will automatically pad the list's scrollable
/// extremities to avoid partial obstructions indicated by [MediaQuery]'s
/// padding. To avoid this behavior, override with a zero [padding] property.
///
/// Once code has been ported to use [CustomScrollView], other slivers, such as
/// [SliverList] or [SliverAppBar], can be put in the [CustomScrollView.slivers]
/// list.
///
/// {@tool snippet}
/// This example demonstrates how to create a [GridView] with two columns. The
/// children are spaced apart using the [crossAxisSpacing] and [mainAxisSpacing]
/// properties.
///
/// ![The GridView displays six children with different background colors arranged in two columns](https://flutter.github.io/assets-for-api-docs/assets/widgets/grid_view.png)
///
/// ```dart
/// GridView.count(
///   primary: false,
///   padding: const EdgeInsets.all(20),
///   crossAxisSpacing: 10,
///   mainAxisSpacing: 10,
///   crossAxisCount: 2,
///   children: <Widget>[
///     Container(
///       padding: const EdgeInsets.all(8),
///       child: const Text("He'd have you all unravel at the"),
///       color: Colors.teal[100],
///     ),
///     Container(
///       padding: const EdgeInsets.all(8),
///       child: const Text('Heed not the rabble'),
///       color: Colors.teal[200],
///     ),
///     Container(
///       padding: const EdgeInsets.all(8),
///       child: const Text('Sound of screams but the'),
///       color: Colors.teal[300],
///     ),
///     Container(
///       padding: const EdgeInsets.all(8),
///       child: const Text('Who scream'),
///       color: Colors.teal[400],
///     ),
///     Container(
///       padding: const EdgeInsets.all(8),
///       child: const Text('Revolution is coming...'),
///       color: Colors.teal[500],
///     ),
///     Container(
///       padding: const EdgeInsets.all(8),
///       child: const Text('Revolution, they...'),
///       color: Colors.teal[600],
///     ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// {@tool snippet}
/// This example shows how to create the same grid as the previous example
/// using a [CustomScrollView] and a [SliverGrid].
///
/// ![The CustomScrollView contains a SliverGrid that displays six children with different background colors arranged in two columns](https://flutter.github.io/assets-for-api-docs/assets/widgets/grid_view_custom_scroll.png)
///
/// ```dart
/// CustomScrollView(
///   primary: false,
///   slivers: <Widget>[
///     SliverPadding(
///       padding: const EdgeInsets.all(20),
///       sliver: SliverGrid.count(
///         crossAxisSpacing: 10,
///         mainAxisSpacing: 10,
///         crossAxisCount: 2,
///         children: <Widget>[
///           Container(
///             padding: const EdgeInsets.all(8),
///             child: const Text("He'd have you all unravel at the"),
///             color: Colors.green[100],
///           ),
///           Container(
///             padding: const EdgeInsets.all(8),
///             child: const Text('Heed not the rabble'),
///             color: Colors.green[200],
///           ),
///           Container(
///             padding: const EdgeInsets.all(8),
///             child: const Text('Sound of screams but the'),
///             color: Colors.green[300],
///           ),
///           Container(
///             padding: const EdgeInsets.all(8),
///             child: const Text('Who scream'),
///             color: Colors.green[400],
///           ),
///           Container(
///             padding: const EdgeInsets.all(8),
///             child: const Text('Revolution is coming...'),
///             color: Colors.green[500],
///           ),
///           Container(
///             padding: const EdgeInsets.all(8),
///             child: const Text('Revolution, they...'),
///             color: Colors.green[600],
///           ),
///         ],
///       ),
///     ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [SingleChildScrollView], which is a scrollable widget that has a single
///    child.
///  * [ListView], which is scrollable, linear list of widgets.
///  * [PageView], which is a scrolling list of child widgets that are each the
///    size of the viewport.
///  * [CustomScrollView], which is a scrollable widget that creates custom
///    scroll effects using slivers.
///  * [SliverGridDelegateWithFixedCrossAxisCount], which creates a layout with
///    a fixed number of tiles in the cross axis.
///  * [SliverGridDelegateWithMaxCrossAxisExtent], which creates a layout with
///    tiles that have a maximum cross-axis extent.
///  * [ScrollNotification] and [NotificationListener], which can be used to watch
///    the scroll position without using a [ScrollController].
///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
/// </Summary>
public class GridView : FlutterSDK.Widgets.Scrollview.BoxScrollView
{
    #region constructors
    public GridView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, double cacheExtent = default(double), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int semanticChildCount = default(int))
    : base(key: key, scrollDirection: scrollDirection, reverse: reverse, controller: controller, primary: primary, physics: physics, shrinkWrap: shrinkWrap, padding: padding, cacheExtent: cacheExtent, semanticChildCount: semanticChildCount ?? children.Count)

}
public static GridView Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), int itemCount = default(int), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, double cacheExtent = default(double), int semanticChildCount = default(int))

}
public static GridView Custom(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate), FlutterSDK.Widgets.Sliver.SliverChildDelegate childrenDelegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), double cacheExtent = default(double), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))

}
public static GridView Count(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), int crossAxisCount = default(int), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0, bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, double cacheExtent = default(double), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))

}
public static GridView Extent(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double maxCrossAxisExtent = default(double), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0, bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Slivergrid.SliverGridDelegate GridDelegate { get; set; }
public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate ChildrenDelegate { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new SliverGrid(@delegate: ChildrenDelegate, gridDelegate: GridDelegate);
}



#endregion
}


/// <Summary>
/// A representation of how a [ScrollView] should dismiss the on-screen
/// keyboard.
/// </Summary>
public enum ScrollViewKeyboardDismissBehavior
{

    /// <Summary>
    /// `manual` means there is no automatic dimissal of the on-screen keyboard.
    /// It is up to the client to dismiss the keyboard.
    /// </Summary>
    Manual,
    /// <Summary>
    /// `onDrag` means that the [ScrollView] will dismiss an on-screen keyboard
    /// when a drag begins.
    /// </Summary>
    OnDrag,
}

}
