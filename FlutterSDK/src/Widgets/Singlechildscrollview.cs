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
namespace FlutterSDK.Widgets.Singlechildscrollview
{
    internal static class SinglechildscrollviewDefaultClass
    {
    }

    /// <Summary>
    /// A box in which a single widget can be scrolled.
    ///
    /// This widget is useful when you have a single box that will normally be
    /// entirely visible, for example a clock face in a time picker, but you need to
    /// make sure it can be scrolled if the container gets too small in one axis
    /// (the scroll direction).
    ///
    /// It is also useful if you need to shrink-wrap in both axes (the main
    /// scrolling direction as well as the cross axis), as one might see in a dialog
    /// or pop-up menu. In that case, you might pair the [SingleChildScrollView]
    /// with a [ListBody] child.
    ///
    /// When you have a list of children and do not require cross-axis
    /// shrink-wrapping behavior, for example a scrolling list that is always the
    /// width of the screen, consider [ListView], which is vastly more efficient
    /// that a [SingleChildScrollView] containing a [ListBody] or [Column] with
    /// many children.
    ///
    /// ## Sample code: Using [SingleChildScrollView] with a [Column]
    ///
    /// Sometimes a layout is designed around the flexible properties of a
    /// [Column], but there is the concern that in some cases, there might not
    /// be enough room to see the entire contents. This could be because some
    /// devices have unusually small screens, or because the application can
    /// be used in landscape mode where the aspect ratio isn't what was
    /// originally envisioned, or because the application is being shown in a
    /// small window in split-screen mode. In any case, as a result, it might
    /// make sense to wrap the layout in a [SingleChildScrollView].
    ///
    /// Simply doing so, however, usually results in a conflict between the [Column],
    /// which typically tries to grow as big as it can, and the [SingleChildScrollView],
    /// which provides its children with an infinite amount of space.
    ///
    /// To resolve this apparent conflict, there are a couple of techniques, as
    /// discussed below. These techniques should only be used when the content is
    /// normally expected to fit on the screen, so that the lazy instantiation of
    /// a sliver-based [ListView] or [CustomScrollView] is not expected to provide
    /// any performance benefit. If the viewport is expected to usually contain
    /// content beyond the dimensions of the screen, then [SingleChildScrollView]
    /// would be very expensive.
    ///
    /// ### Centering, spacing, or aligning fixed-height content
    ///
    /// If the content has fixed (or intrinsic) dimensions but needs to be spaced out,
    /// centered, or otherwise positioned using the [Flex] layout model of a [Column],
    /// the following technique can be used to provide the [Column] with a minimum
    /// dimension while allowing it to shrink-wrap the contents when there isn't enough
    /// room to apply these spacing or alignment needs.
    ///
    /// A [LayoutBuilder] is used to obtain the size of the viewport (implicitly via
    /// the constraints that the [SingleChildScrollView] sees, since viewports
    /// typically grow to fit their maximum height constraint). Then, inside the
    /// scroll view, a [ConstrainedBox] is used to set the minimum height of the
    /// [Column].
    ///
    /// The [Column] has no [Expanded] children, so rather than take on the infinite
    /// height from its [BoxConstraints.maxHeight], (the viewport provides no maximum height
    /// constraint), it automatically tries to shrink to fit its children. It cannot
    /// be smaller than its [BoxConstraints.minHeight], though, and It therefore
    /// becomes the bigger of the minimum height provided by the
    /// [ConstrainedBox] and the sum of the heights of the children.
    ///
    /// If the children aren't enough to fit that minimum size, the [Column] ends up
    /// with some remaining space to allocate as specified by its
    /// [Column.mainAxisAlignment] argument.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// In this example, the children are spaced out equally, unless there's no more
    /// room, in which case they stack vertically and scroll.
    ///
    /// When using this technique, [Expanded] and [Flexible] are not useful, because
    /// in both cases the "available space" is infinite (since this is in a viewport).
    /// The next section describes a technique for providing a maximum height constraint.
    ///
    /// ```dart
    ///  Widget build(BuildContext context) {
    ///    return DefaultTextStyle(
    ///      style: Theme.of(context).textTheme.bodyText2,
    ///      child: LayoutBuilder(
    ///        builder: (BuildContext context, BoxConstraints viewportConstraints) {
    ///          return SingleChildScrollView(
    ///            child: ConstrainedBox(
    ///              constraints: BoxConstraints(
    ///                minHeight: viewportConstraints.maxHeight,
    ///              ),
    ///              child: Column(
    ///                mainAxisSize: MainAxisSize.min,
    ///                mainAxisAlignment: MainAxisAlignment.spaceAround,
    ///                children: <Widget>[
    ///                  Container(
    ///                    // A fixed-height child.
    ///                    color: const Color(0xffeeee00), // Yellow
    ///                    height: 120.0,
    ///                    alignment: Alignment.center,
    ///                    child: const Text('Fixed Height Content'),
    ///                  ),
    ///                  Container(
    ///                    // Another fixed-height child.
    ///                    color: const Color(0xff008000), // Green
    ///                    height: 120.0,
    ///                    alignment: Alignment.center,
    ///                    child: const Text('Fixed Height Content'),
    ///                  ),
    ///                ],
    ///              ),
    ///            ),
    ///          );
    ///        },
    ///      ),
    ///    );
    ///  }
    /// ```
    /// {@end-tool}
    ///
    /// ### Expanding content to fit the viewport
    ///
    /// The following example builds on the previous one. In addition to providing a
    /// minimum dimension for the child [Column], an [IntrinsicHeight] widget is used
    /// to force the column to be exactly as big as its contents. This constraint
    /// combines with the [ConstrainedBox] constraints discussed previously to ensure
    /// that the column becomes either as big as viewport, or as big as the contents,
    /// whichever is biggest.
    ///
    /// Both constraints must be used to get the desired effect. If only the
    /// [IntrinsicHeight] was specified, then the column would not grow to fit the
    /// entire viewport when its children were smaller than the whole screen. If only
    /// the size of the viewport was used, then the [Column] would overflow if the
    /// children were bigger than the viewport.
    ///
    /// The widget that is to grow to fit the remaining space so provided is wrapped
    /// in an [Expanded] widget.
    ///
    /// This technique is quite expensive, as it more or less requires that the contents
    /// of the viewport be laid out twice (once to find their intrinsic dimensions, and
    /// once to actually lay them out). The number of widgets within the column should
    /// therefore be kept small. Alternatively, subsets of the children that have known
    /// dimensions can be wrapped in a [SizedBox] that has tight vertical constraints,
    /// so that the intrinsic sizing algorithm can short-circuit the computation when it
    /// reaches those parts of the subtree.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// In this example, the column becomes either as big as viewport, or as big as
    /// the contents, whichever is biggest.
    ///
    /// ```dart
    ///  Widget build(BuildContext context) {
    ///    return DefaultTextStyle(
    ///      style: Theme.of(context).textTheme.bodyText2,
    ///      child: LayoutBuilder(
    ///        builder: (BuildContext context, BoxConstraints viewportConstraints) {
    ///          return SingleChildScrollView(
    ///            child: ConstrainedBox(
    ///              constraints: BoxConstraints(
    ///                minHeight: viewportConstraints.maxHeight,
    ///              ),
    ///              child: IntrinsicHeight(
    ///                child: Column(
    ///                  children: <Widget>[
    ///                    Container(
    ///                      // A fixed-height child.
    ///                      color: const Color(0xffeeee00), // Yellow
    ///                      height: 120.0,
    ///                      alignment: Alignment.center,
    ///                      child: const Text('Fixed Height Content'),
    ///                    ),
    ///                    Expanded(
    ///                      // A flexible child that will grow to fit the viewport but
    ///                      // still be at least as big as necessary to fit its contents.
    ///                      child: Container(
    ///                        color: const Color(0xffee0000), // Red
    ///                        height: 120.0,
    ///                        alignment: Alignment.center,
    ///                        child: const Text('Flexible Content'),
    ///                      ),
    ///                    ),
    ///                  ],
    ///                ),
    ///              ),
    ///            ),
    ///          );
    ///        },
    ///      ),
    ///    );
    ///  }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ListView], which handles multiple children in a scrolling list.
    ///  * [GridView], which handles multiple children in a scrolling grid.
    ///  * [PageView], for a scrollable that works page by page.
    ///  * [Scrollable], which handles arbitrary scrolling effects.
    /// </Summary>
    public class SingleChildScrollView : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public SingleChildScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.ScrollDirection = scrollDirection;
            this.Reverse = reverse;
            this.Padding = padding;
            this.Physics = physics;
            this.Controller = controller;
            this.Child = child;
            this.DragStartBehavior = dragStartBehavior;
        }
        public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
        public virtual bool Reverse { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
        public virtual bool Primary { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        private FlutterSDK.Painting.Basictypes.AxisDirection _GetDirection(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return BasicDefaultClass.GetAxisDirectionFromAxisReverseAndDirectionality(context, ScrollDirection, Reverse);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            AxisDirection axisDirection = _GetDirection(context);
            Widget contents = Child;
            if (Padding != null) contents = new Padding(padding: Padding, child: contents);
            ScrollController scrollController = Primary ? PrimaryscrollcontrollerDefaultClass.PrimaryScrollController.Of(context) : Controller;
            Scrollable scrollable = new Scrollable(dragStartBehavior: DragStartBehavior, axisDirection: axisDirection, controller: scrollController, physics: Physics, viewportBuilder: (BuildContext context, ViewportOffset offset) =>
            {
                return new _SingleChildViewport(axisDirection: axisDirection, offset: offset, child: contents);
            }
            );
            return Primary && scrollController != null ? PrimaryScrollController.None(child: scrollable) : scrollable;
        }



    }


    public class _SingleChildViewport : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _SingleChildViewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.AxisDirection = axisDirection;
            this.Offset = offset;
        }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }

        public new FlutterSDK.Widgets.Singlechildscrollview._RenderSingleChildViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderSingleChildViewport(axisDirection: AxisDirection, offset: Offset);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Singlechildscrollview._RenderSingleChildViewport renderObject)
        {
            ..AxisDirection = AxisDirection..Offset = Offset;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..AxisDirection = AxisDirection..Offset = Offset;
        }



    }


    public class _RenderSingleChildViewport : FlutterSDK.Rendering.Box.RenderBox, IRenderAbstractViewport, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>
    {
        public _RenderSingleChildViewport(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double cacheExtent = default(double), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base()
        {

            this.Child = child;
        }


        internal virtual FlutterSDK.Painting.Basictypes.AxisDirection _AxisDirection { get; set; }
        internal virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset _Offset { get; set; }
        internal virtual double _CacheExtent { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CacheExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _ViewportExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _MinScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _MaxScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Offset _PaintOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _HasScrolled()
        {
            MarkNeedsPaint();
            MarkNeedsSemanticsUpdate();
        }




        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is ParentData)) child.ParentData = new ParentData();
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _Offset.AddListener(_HasScrolled);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _Offset.AddListener(_HasScrolled);
        }




        public new void Detach()
        {
            _Offset.RemoveListener(_HasScrolled);
            base.Detach();
        }




        private FlutterSDK.Rendering.Box.BoxConstraints _GetInnerConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            switch (Axis) { case Axis.Horizontal: return constraints.HeightConstraints(); case Axis.Vertical: return constraints.WidthConstraints(); }
            return null;
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            if (Child != null) return Child.GetMinIntrinsicWidth(height);
            return 0.0;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            if (Child != null) return Child.GetMaxIntrinsicWidth(height);
            return 0.0;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            if (Child != null) return Child.GetMinIntrinsicHeight(width);
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            if (Child != null) return Child.GetMaxIntrinsicHeight(width);
            return 0.0;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            if (Child == null)
            {
                Size = constraints.Smallest;
            }
            else
            {
                Child.Layout(_GetInnerConstraints(constraints), parentUsesSize: true);
                Size = constraints.Constrain(Child.Size);
            }

            Offset.ApplyViewportDimension(_ViewportExtent);
            Offset.ApplyContentDimensions(_MinScrollExtent, _MaxScrollExtent);
        }




        private Offset _PaintOffsetForPosition(double position)
        {

            switch (AxisDirection) { case AxisDirection.Up: return new Offset(0.0, position - Child.Size.Height + Size.Height); case AxisDirection.Down: return new Offset(0.0, -position); case AxisDirection.Left: return new Offset(position - Child.Size.Width + Size.Width, 0.0); case AxisDirection.Right: return new Offset(-position, 0.0); }
            return null;
        }




        private bool _ShouldClipAtPaintOffset(FlutterBinding.UI.Offset paintOffset)
        {

            return paintOffset < Dart.UiDefaultClass.Offset.Zero || !(Dart.UI.UiDefaultClass.Offset.Zero & Size).Contains((paintOffset & Child.Size).BottomRight);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child != null)
            {
                Offset paintOffset = _PaintOffset;
                void PaintContents(PaintingContext context, Offset offset)
                {
                    context.PaintChild(Child, offset + paintOffset);
                }

                if (_ShouldClipAtPaintOffset(paintOffset))
                {
                    context.PushClipRect(NeedsCompositing, offset, Dart.UI.UiDefaultClass.Offset.Zero & Size, PaintContents);
                }
                else
                {
                    PaintContents(context, offset);
                }

            }

        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
        {
            Offset paintOffset = _PaintOffset;
            transform.Translate(paintOffset.Dx, paintOffset.Dy);
        }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {
            Offset paintOffset = _PaintOffset;
            transform.Translate(paintOffset.Dx, paintOffset.Dy);
        }




        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (child != null && _ShouldClipAtPaintOffset(_PaintOffset)) return Dart.UiDefaultClass.Offset.Zero & Size;
            return null;
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            if (Child != null)
            {
                return result.AddWithPaintOffset(offset: _PaintOffset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
                {

                    return Child.HitTest(result, position: transformed);
                }
                );
            }

            return false;
        }




        public new FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect))
        {
            rect = (rect == null ? target.PaintBounds : rect);
            if (!(target is RenderBox)) return new RevealedOffset(offset: Offset.Pixels, rect: rect);
            RenderBox targetBox = target as RenderBox;
            Matrix4 transform = targetBox.GetTransformTo(Child);
            Rect bounds = MatrixutilsDefaultClass.MatrixUtils.TransformRect(transform, rect);
            Size contentSize = Child.Size;
            double leadingScrollOffset = default(double);
            double targetMainAxisExtent = default(double);
            double mainAxisExtent = default(double);

            switch (AxisDirection) { case AxisDirection.Up: mainAxisExtent = Size.Height; leadingScrollOffset = contentSize.Height - bounds.Bottom; targetMainAxisExtent = bounds.Height; break; case AxisDirection.Right: mainAxisExtent = Size.Width; leadingScrollOffset = bounds.Left; targetMainAxisExtent = bounds.Width; break; case AxisDirection.Down: mainAxisExtent = Size.Height; leadingScrollOffset = bounds.Top; targetMainAxisExtent = bounds.Height; break; case AxisDirection.Left: mainAxisExtent = Size.Width; leadingScrollOffset = contentSize.Width - bounds.Right; targetMainAxisExtent = bounds.Width; break; }
            double targetOffset = leadingScrollOffset - (mainAxisExtent - targetMainAxisExtent) * alignment;
            Rect targetRect = bounds.Shift(_PaintOffsetForPosition(targetOffset));
            return new RevealedOffset(offset: targetOffset, rect: targetRect);
        }




        public new void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            if (!Offset.AllowImplicitScrolling)
            {
                return base.ShowOnScreen(descendant: descendant, rect: rect, duration: duration, curve: curve);
            }

            Rect newRect = ViewportDefaultClass.RenderViewportBase.ShowInViewport(descendant: descendant, viewport: this, offset: Offset, rect: rect, duration: duration, curve: curve);
            base.ShowOnScreen(rect: newRect, duration: duration, curve: curve);
        }




        public new Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child)
        {

            switch (Axis) { case Axis.Vertical: return Rect.FromLTRB(SemanticBounds.Left, SemanticBounds.Top - CacheExtent, SemanticBounds.Right, SemanticBounds.Bottom + CacheExtent); case Axis.Horizontal: return Rect.FromLTRB(SemanticBounds.Left - CacheExtent, SemanticBounds.Top, SemanticBounds.Right + CacheExtent, SemanticBounds.Bottom); }
            return null;
        }



        RenderAbstractViewport _RenderAbstractViewportInstance = new RenderAbstractViewport();
        public FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object) => _RenderAbstractViewportInstance.Of(@object);
        public double DefaultCacheExtent => _RenderAbstractViewportInstance.DefaultCacheExtent;
    }

}
