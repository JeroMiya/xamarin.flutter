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
namespace FlutterSDK.Widgets.Scrollable
{
    /// <Summary>
    /// Signature used by [Scrollable] to build the viewport through which the
    /// scrollable content is displayed.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget ViewportBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewportoffset.ViewportOffset position);
    /// <Summary>
    /// A typedef for a function that can calculate the offset for a type of scroll
    /// increment given a [ScrollIncrementDetails].
    ///
    /// This function is used as the type for [Scrollable.incrementCalculator],
    /// which is called from a [ScrollAction].
    /// </Summary>
    public delegate double ScrollIncrementCalculator(FlutterSDK.Widgets.Scrollable.ScrollIncrementDetails details);
    internal static class ScrollableDefaultClass
    {
    }

    /// <Summary>
    /// A widget that scrolls.
    ///
    /// [Scrollable] implements the interaction model for a scrollable widget,
    /// including gesture recognition, but does not have an opinion about how the
    /// viewport, which actually displays the children, is constructed.
    ///
    /// It's rare to construct a [Scrollable] directly. Instead, consider [ListView]
    /// or [GridView], which combine scrolling, viewporting, and a layout model. To
    /// combine layout models (or to use a custom layout mode), consider using
    /// [CustomScrollView].
    ///
    /// The static [Scrollable.of] and [Scrollable.ensureVisible] functions are
    /// often used to interact with the [Scrollable] widget inside a [ListView] or
    /// a [GridView].
    ///
    /// To further customize scrolling behavior with a [Scrollable]:
    ///
    /// 1. You can provide a [viewportBuilder] to customize the child model. For
    ///    example, [SingleChildScrollView] uses a viewport that displays a single
    ///    box child whereas [CustomScrollView] uses a [Viewport] or a
    ///    [ShrinkWrappingViewport], both of which display a list of slivers.
    ///
    /// 2. You can provide a custom [ScrollController] that creates a custom
    ///    [ScrollPosition] subclass. For example, [PageView] uses a
    ///    [PageController], which creates a page-oriented scroll position subclass
    ///    that keeps the same page visible when the [Scrollable] resizes.
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
    ///  * [SingleChildScrollView], which is a scrollable widget that has a single
    ///    child.
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public class Scrollable : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that scrolls.
        ///
        /// The [axisDirection] and [viewportBuilder] arguments must not be null.
        /// </Summary>
        public Scrollable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollable.ViewportBuilder viewportBuilder = default(FlutterSDK.Widgets.Scrollable.ViewportBuilder), FlutterSDK.Widgets.Scrollable.ScrollIncrementCalculator incrementCalculator = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementCalculator), bool excludeFromSemantics = false, int semanticChildCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.AxisDirection = axisDirection;
            this.Controller = controller;
            this.Physics = physics;
            this.ViewportBuilder = viewportBuilder;
            this.IncrementCalculator = incrementCalculator;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.SemanticChildCount = semanticChildCount;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// The direction in which this widget scrolls.
        ///
        /// For example, if the [axisDirection] is [AxisDirection.down], increasing
        /// the scroll position will cause content below the bottom of the viewport to
        /// become visible through the viewport. Similarly, if [axisDirection] is
        /// [AxisDirection.right], increasing the scroll position will cause content
        /// beyond the right edge of the viewport to become visible through the
        /// viewport.
        ///
        /// Defaults to [AxisDirection.down].
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        /// <Summary>
        /// An object that can be used to control the position to which this widget is
        /// scrolled.
        ///
        /// A [ScrollController] serves several purposes. It can be used to control
        /// the initial scroll position (see [ScrollController.initialScrollOffset]).
        /// It can be used to control whether the scroll view should automatically
        /// save and restore its scroll position in the [PageStorage] (see
        /// [ScrollController.keepScrollOffset]). It can be used to read the current
        /// scroll position (see [ScrollController.offset]), or change it (see
        /// [ScrollController.animateTo]).
        ///
        /// See also:
        ///
        ///  * [ensureVisible], which animates the scroll position to reveal a given
        ///    [BuildContext].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
        /// <Summary>
        /// How the widgets should respond to user input.
        ///
        /// For example, determines how the widget continues to animate after the
        /// user stops dragging the scroll view.
        ///
        /// Defaults to matching platform conventions via the physics provided from
        /// the ambient [ScrollConfiguration].
        ///
        /// The physics can be changed dynamically, but new physics will only take
        /// effect if the _class_ of the provided object changes. Merely constructing
        /// a new instance with a different configuration is insufficient to cause the
        /// physics to be reapplied. (This is because the final object used is
        /// generated dynamically, which can be relatively expensive, and it would be
        /// inefficient to speculatively create this object each frame to see if the
        /// physics should be updated.)
        ///
        /// See also:
        ///
        ///  * [AlwaysScrollableScrollPhysics], which can be used to indicate that the
        ///    scrollable should react to scroll requests (and possible overscroll)
        ///    even if the scrollable's contents fit without scrolling being necessary.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        /// <Summary>
        /// Builds the viewport through which the scrollable content is displayed.
        ///
        /// A typical viewport uses the given [ViewportOffset] to determine which part
        /// of its content is actually visible through the viewport.
        ///
        /// See also:
        ///
        ///  * [Viewport], which is a viewport that displays a list of slivers.
        ///  * [ShrinkWrappingViewport], which is a viewport that displays a list of
        ///    slivers and sizes itself based on the size of the slivers.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollable.ViewportBuilder ViewportBuilder { get; set; }
        /// <Summary>
        /// An optional function that will be called to calculate the distance to
        /// scroll when the scrollable is asked to scroll via the keyboard using a
        /// [ScrollAction].
        ///
        /// If not supplied, the [Scrollable] will scroll a default amount when a
        /// keyboard navigation key is pressed (e.g. pageUp/pageDown, control-upArrow,
        /// etc.), or otherwise invoked by a [ScrollAction].
        ///
        /// If [incrementCalculator] is null, the default for
        /// [ScrollIncrementType.page] is 80% of the size of the scroll window, and
        /// for [ScrollIncrementType.line], 50 logical pixels.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollable.ScrollIncrementCalculator IncrementCalculator { get; set; }
        /// <Summary>
        /// Whether the scroll actions introduced by this [Scrollable] are exposed
        /// in the semantics tree.
        ///
        /// Text fields with an overflow are usually scrollable to make sure that the
        /// user can get to the beginning/end of the entered text. However, these
        /// scrolling actions are generally not exposed to the semantics layer.
        ///
        /// See also:
        ///
        ///  * [GestureDetector.excludeFromSemantics], which is used to accomplish the
        ///    exclusion.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }
        /// <Summary>
        /// The number of children that will contribute semantic information.
        ///
        /// The value will be null if the number of children is unknown or unbounded.
        ///
        /// Some subtypes of [ScrollView] can infer this value automatically. For
        /// example [ListView] will use the number of widgets in the child list,
        /// while the [new ListView.separated] constructor will use half that amount.
        ///
        /// For [CustomScrollView] and other types which do not receive a builder
        /// or list of widgets, the child count must be explicitly provided.
        ///
        /// See also:
        ///
        ///  * [CustomScrollView], for an explanation of scroll semantics.
        ///  * [SemanticsConfiguration.scrollChildCount], the corresponding semantics property.
        /// </Summary>
        public virtual int SemanticChildCount { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.scrollable.dragStartBehavior}
        /// Determines the way that drag start behavior is handled.
        ///
        /// If set to [DragStartBehavior.start], scrolling drag behavior will
        /// begin upon the detection of a drag gesture. If set to
        /// [DragStartBehavior.down] it will begin when a down event is first detected.
        ///
        /// In general, setting this to [DragStartBehavior.start] will make drag
        /// animation smoother and setting it to [DragStartBehavior.down] will make
        /// drag behavior feel slightly more reactive.
        ///
        /// By default, the drag start behavior is [DragStartBehavior.start].
        ///
        /// See also:
        ///
        ///  * [DragGestureRecognizer.dragStartBehavior], which gives an example for
        ///    the different behaviors.
        ///
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Scrollable.ScrollableState CreateState() => new ScrollableState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<AxisDirection>("axisDirection", AxisDirection));
            properties.Add(new DiagnosticsProperty<ScrollPhysics>("physics", Physics));
        }




        /// <Summary>
        /// The state from the closest instance of this class that encloses the given context.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// ScrollableState scrollable = Scrollable.of(context);
        /// ```
        ///
        /// Calling this method will create a dependency on the closest [Scrollable]
        /// in the [context], if there is one.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollable.ScrollableState Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _ScrollableScope widget = context.DependOnInheritedWidgetOfExactType();
            return widget?.Scrollable;
        }




        /// <Summary>
        /// Provides a heuristic to determine if expensive frame-bound tasks should be
        /// deferred for the [context] at a specific point in time.
        ///
        /// Calling this method does _not_ create a dependency on any other widget.
        /// This also means that the value returned is only good for the point in time
        /// when it is called, and callers will not get updated if the value changes.
        ///
        /// The heuristic used is determined by the [physics] of this [Scrollable]
        /// via [ScrollPhysics.recommendDeferredScrolling]. That method is called with
        /// the current [activity]'s [ScrollActivity.velocity].
        ///
        /// If there is no [Scrollable] in the widget tree above the [context], this
        /// method returns false.
        /// </Summary>
        public virtual bool RecommendDeferredLoadingForContext(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _ScrollableScope widget = context.GetElementForInheritedWidgetOfExactType()?.Widget as _ScrollableScope;
            if (widget == null)
            {
                return false;
            }

            return widget.Position.RecommendDeferredLoading(context);
        }




        /// <Summary>
        /// Scrolls the scrollables that enclose the given context so as to make the
        /// given context visible.
        /// </Summary>
        public virtual Future<object> EnsureVisible(FlutterSDK.Widgets.Framework.BuildContext context, double alignment = 0.0, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy alignmentPolicy = default(FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy))
        {
            List<Future<void>> futures = new List<Future<void>>() { };
            ScrollableState scrollable = ScrollableDefaultClass.Scrollable.Of(context);
            while (scrollable != null)
            {
                futures.Add(scrollable.Position.EnsureVisible(context.FindRenderObject(), alignment: alignment, duration: duration, curve: curve, alignmentPolicy: alignmentPolicy));
                context = scrollable.Context;
                scrollable = ScrollableDefaultClass.Scrollable.Of(context);
            }

            if (futures.IsEmpty() || duration == Dart.CoreDefaultClass.Duration.Zero) return Future<void>.Value();
            if (futures.Count == 1) return futures.Single();
            return Dart.AsyncDefaultClass.Future.Wait(futures).Then((List<void> _) => =>null);
        }



    }


    public class _ScrollableScope : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        public _ScrollableScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Scrollable.ScrollableState scrollable = default(FlutterSDK.Widgets.Scrollable.ScrollableState), FlutterSDK.Widgets.Scrollposition.ScrollPosition position = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Scrollable = scrollable;
            this.Position = position;
        }
        public virtual FlutterSDK.Widgets.Scrollable.ScrollableState Scrollable { get; set; }
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Scrollable._ScrollableScope old)
        {
            return Position != old.Position;
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return Position != old.Position;
        }



    }


    /// <Summary>
    /// State object for a [Scrollable] widget.
    ///
    /// To manipulate a [Scrollable] widget's scroll position, use the object
    /// obtained from the [position] property.
    ///
    /// To be informed of when a [Scrollable] widget is scrolling, use a
    /// [NotificationListener] to listen for [ScrollNotification] notifications.
    ///
    /// This class is not intended to be subclassed. To specialize the behavior of a
    /// [Scrollable], provide it with a [ScrollPhysics].
    /// </Summary>
    public class ScrollableState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Scrollable.Scrollable>, IScrollContext, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public ScrollableState()
        { }
        internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _Position { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior _Configuration { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics _Physics { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ScrollSemanticsKey { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState> _GestureDetectorKey { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _IgnorePointerKey { get; set; }
        internal virtual Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> _GestureRecognizers { get; set; }
        internal virtual bool _ShouldIgnorePointer { get; set; }
        internal virtual bool _LastCanDrag { get; set; }
        internal virtual FlutterSDK.Painting.Basictypes.Axis _LastAxisDirection { get; set; }
        internal virtual FlutterSDK.Gestures.Drag.Drag _Drag { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollHoldController _Hold { get; set; }
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext NotificationContext { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext StorageContext { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _UpdatePosition()
        {
            _Configuration = ScrollconfigurationDefaultClass.ScrollConfiguration.Of(Context);
            _Physics = _Configuration.GetScrollPhysics(Context);
            if (Widget.Physics != null) _Physics = Widget.Physics.ApplyTo(_Physics);
            ScrollController controller = Widget.Controller;
            ScrollPosition oldPosition = Position;
            if (oldPosition != null)
            {
                controller?.Detach(oldPosition);
                Dart.AsyncDefaultClass.ScheduleMicrotask(oldPosition.Dispose);
            }

            _Position = controller?.CreateScrollPosition(_Physics, this, oldPosition) ?? new ScrollPositionWithSingleContext(physics: _Physics, context: this, oldPosition: oldPosition);

            controller?.Attach(Position);
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _UpdatePosition();
        }




        private bool _ShouldUpdatePosition(FlutterSDK.Widgets.Scrollable.Scrollable oldWidget)
        {
            ScrollPhysics newPhysics = Widget.Physics;
            ScrollPhysics oldPhysics = oldWidget.Physics;
            do
            {
                if (newPhysics?.GetType() != oldPhysics?.GetType()) return true;
                newPhysics = newPhysics?.Parent;
                oldPhysics = oldPhysics?.Parent;
            }
            while (newPhysics != null || oldPhysics != null);
            return Widget.Controller?.GetType() != oldWidget.Controller?.GetType();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Scrollable.Scrollable oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller != oldWidget.Controller)
            {
                oldWidget.Controller?.Detach(Position);
                Widget.Controller?.Attach(Position);
            }

            if (_ShouldUpdatePosition(oldWidget)) _UpdatePosition();
        }




        public new void Dispose()
        {
            Widget.Controller?.Detach(Position);
            Position.Dispose();
            base.Dispose();
        }




        public new void SetSemanticsActions(HashSet<SemanticsAction> actions)
        {
            if (_GestureDetectorKey.CurrentState != null) _GestureDetectorKey.CurrentState.ReplaceSemanticsActions(actions);
        }




        public new void SetCanDrag(bool canDrag)
        {
            if (canDrag == _LastCanDrag && (!canDrag || Widget.Axis == _LastAxisDirection)) return;
            if (!canDrag)
            {
                _GestureRecognizers = new Dictionary<Type, GestureRecognizerFactory> { };
            }
            else
            {
                switch (Widget.Axis)
                {
                    case Axis.Vertical:
                        _GestureRecognizers = new Dictionary<Type, GestureRecognizerFactory>{{MonodragDefaultClass.VerticalDragGestureRecognizer, new GestureRecognizerFactoryWithHandlers<VerticalDragGestureRecognizer>(() => =>new VerticalDragGestureRecognizer(), (VerticalDragGestureRecognizer instance) => {
..OnDown=_HandleDragDown..OnStart=_HandleDragStart..OnUpdate=_HandleDragUpdate..OnEnd=_HandleDragEnd..OnCancel=_HandleDragCancel..MinFlingDistance=_Physics?.MinFlingDistance..MinFlingVelocity=_Physics?.MinFlingVelocity..MaxFlingVelocity=_Physics?.MaxFlingVelocity..DragStartBehavior=Widget.DragStartBehavior;
}
)}}; break;
                    case Axis.Horizontal:
                        _GestureRecognizers = new Dictionary<Type, GestureRecognizerFactory>{{MonodragDefaultClass.HorizontalDragGestureRecognizer, new GestureRecognizerFactoryWithHandlers<HorizontalDragGestureRecognizer>(() => =>new HorizontalDragGestureRecognizer(), (HorizontalDragGestureRecognizer instance) => {
..OnDown=_HandleDragDown..OnStart=_HandleDragStart..OnUpdate=_HandleDragUpdate..OnEnd=_HandleDragEnd..OnCancel=_HandleDragCancel..MinFlingDistance=_Physics?.MinFlingDistance..MinFlingVelocity=_Physics?.MinFlingVelocity..MaxFlingVelocity=_Physics?.MaxFlingVelocity..DragStartBehavior=Widget.DragStartBehavior;
}
)}}; break;
                }
            }

            _LastCanDrag = canDrag;
            _LastAxisDirection = Widget.Axis;
            if (_GestureDetectorKey.CurrentState != null) _GestureDetectorKey.CurrentState.ReplaceGestureRecognizers(_GestureRecognizers);
        }




        public new void SetIgnorePointer(bool value)
        {
            if (_ShouldIgnorePointer == value) return;
            _ShouldIgnorePointer = value;
            if (_IgnorePointerKey.CurrentContext != null)
            {
                RenderIgnorePointer renderBox = _IgnorePointerKey.CurrentContext.FindRenderObject() as RenderIgnorePointer;
                renderBox.Ignoring = _ShouldIgnorePointer;
            }

        }




        private void _HandleDragDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails details)
        {


            _Hold = Position.Hold(_DisposeHold);
        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {

            _Drag = Position.Drag(details, _DisposeDrag);


        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {

            _Drag?.Update(details);
        }




        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {

            _Drag?.End(details);

        }




        private void _HandleDragCancel()
        {

            _Hold?.Cancel();
            _Drag?.Cancel();


        }




        private void _DisposeHold()
        {
            _Hold = null;
        }




        private void _DisposeDrag()
        {
            _Drag = null;
        }




        private double _TargetScrollOffsetForPointerScroll(FlutterSDK.Gestures.Events.PointerScrollEvent @event)
        {
            double delta = Widget.Axis == Axis.Horizontal ? @event.ScrollDelta.Dx : @event.ScrollDelta.Dy;
            if (BasictypesDefaultClass.AxisDirectionIsReversed(Widget.AxisDirection))
            {
                delta *= -1;
            }

            return Dart.Math.MathDefaultClass.Min(Dart.Math.MathDefaultClass.Max(Position.Pixels + delta, Position.MinScrollExtent), Position.MaxScrollExtent);
        }




        private void _ReceivedPointerSignal(FlutterSDK.Gestures.Events.PointerSignalEvent @event)
        {
            if (@event is PointerScrollEvent && Position != null)
            {
                double targetScrollOffset = _TargetScrollOffsetForPointerScroll(((PointerScrollEvent)@event));
                if (targetScrollOffset != Position.Pixels)
                {
                    BindingDefaultClass.GestureBinding.Instance.PointerSignalResolver.Register(((PointerScrollEvent)@event), _HandlePointerScroll);
                }

            }

        }




        private void _HandlePointerScroll(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            if (_Physics != null && !_Physics.ShouldAcceptUserOffset(Position))
            {
                return;
            }

            double targetScrollOffset = _TargetScrollOffsetForPointerScroll(@event as PointerScrollEvent);
            if (targetScrollOffset != Position.Pixels)
            {
                Position.JumpTo(targetScrollOffset);
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            Widget result = new _ScrollableScope(scrollable: this, position: Position, child: new Listener(onPointerSignal: _ReceivedPointerSignal, child: new RawGestureDetector(key: _GestureDetectorKey, gestures: _GestureRecognizers, behavior: HitTestBehavior.Opaque, excludeFromSemantics: Widget.ExcludeFromSemantics, child: new Semantics(explicitChildNodes: !Widget.ExcludeFromSemantics, child: new IgnorePointer(key: _IgnorePointerKey, ignoring: _ShouldIgnorePointer, ignoringSemantics: false, child: Widget.ViewportBuilder(context, Position))))));
            if (!Widget.ExcludeFromSemantics)
            {
                result = new _ScrollSemantics(key: _ScrollSemanticsKey, child: result, position: Position, allowImplicitScrolling: Widget?.Physics?.AllowImplicitScrolling ?? _Physics.AllowImplicitScrolling, semanticChildCount: Widget.SemanticChildCount);
            }

            return _Configuration.BuildViewportChrome(context, result, Widget.AxisDirection);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<ScrollPosition>("position", Position));
        }



    }


    /// <Summary>
    /// With [_ScrollSemantics] certain child [SemanticsNode]s can be
    /// excluded from the scrollable area for semantics purposes.
    ///
    /// Nodes, that are to be excluded, have to be tagged with
    /// [RenderViewport.excludeFromScrolling] and the [RenderAbstractViewport] in
    /// use has to add the [RenderViewport.useTwoPaneSemantics] tag to its
    /// [SemanticsConfiguration] by overriding
    /// [RenderObject.describeSemanticsConfiguration].
    ///
    /// If the tag [RenderViewport.useTwoPaneSemantics] is present on the viewport,
    /// two semantics nodes will be used to represent the [Scrollable]: The outer
    /// node will contain all children, that are excluded from scrolling. The inner
    /// node, which is annotated with the scrolling actions, will house the
    /// scrollable children.
    /// </Summary>
    public class _ScrollSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _ScrollSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Scrollposition.ScrollPosition position = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), bool allowImplicitScrolling = default(bool), int semanticChildCount = default(int), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Position = position;
            this.AllowImplicitScrolling = allowImplicitScrolling;
            this.SemanticChildCount = semanticChildCount;
        }
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position { get; set; }
        public virtual bool AllowImplicitScrolling { get; set; }
        public virtual int SemanticChildCount { get; set; }

        public new FlutterSDK.Widgets.Scrollable._RenderScrollSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderScrollSemantics(position: Position, allowImplicitScrolling: AllowImplicitScrolling, semanticChildCount: SemanticChildCount);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Scrollable._RenderScrollSemantics renderObject)
        {
            ..AllowImplicitScrolling = AllowImplicitScrolling..Position = Position..SemanticChildCount = SemanticChildCount;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..AllowImplicitScrolling = AllowImplicitScrolling..Position = Position..SemanticChildCount = SemanticChildCount;
        }



    }


    public class _RenderScrollSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
    {
        public _RenderScrollSemantics(FlutterSDK.Widgets.Scrollposition.ScrollPosition position = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), bool allowImplicitScrolling = default(bool), int semanticChildCount = default(int), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {

            position.AddListener(MarkNeedsSemanticsUpdate);
        }


        internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _Position { get; set; }
        internal virtual bool _AllowImplicitScrolling { get; set; }
        internal virtual int _SemanticChildCount { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsNode _InnerNode { get; set; }
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int SemanticChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.IsSemanticBoundary = true;
            if (Position.HaveDimensions)
            {
                ..HasImplicitScrolling = AllowImplicitScrolling..ScrollPosition = _Position.Pixels..ScrollExtentMax = _Position.MaxScrollExtent..ScrollExtentMin = _Position.MinScrollExtent..ScrollChildCount = SemanticChildCount;
            }

        }




        public new void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children)
        {
            if (children.IsEmpty() || !children.First.IsTagged(ViewportDefaultClass.RenderViewport.UseTwoPaneSemantics))
            {
                base.AssembleSemanticsNode(node, config, children);
                return;
            }

            _InnerNode = (_InnerNode == null ? new SemanticsNode(showOnScreen: ShowOnScreen) : _InnerNode);
            ..IsMergedIntoParent = node.IsPartOfNodeMerging..Rect = Dart.UiDefaultClass.Offset.Zero & node.Rect.Size;
            int firstVisibleIndex = default(int);
            List<SemanticsNode> excluded = new List<SemanticsNode>() { _InnerNode };
            List<SemanticsNode> included = new List<SemanticsNode>() { };
            foreach (SemanticsNode child in children)
            {

                if (child.IsTagged(ViewportDefaultClass.RenderViewport.ExcludeFromScrolling))
                {
                    excluded.Add(child);
                }
                else
                {
                    if (!child.HasFlag(Dart.UI.UiDefaultClass.SemanticsFlag.IsHidden)) firstVisibleIndex = (firstVisibleIndex == null ? child.IndexInParent : firstVisibleIndex);
                    included.Add(child);
                }

            }

            config.ScrollIndex = firstVisibleIndex;
            node.UpdateWith(config: null, childrenInInversePaintOrder: excluded);
            _InnerNode.UpdateWith(config: config, childrenInInversePaintOrder: included);
        }




        public new void ClearSemantics()
        {
            base.ClearSemantics();
            _InnerNode = null;
        }



    }


    /// <Summary>
    /// A details object that describes the type of scroll increment being requested
    /// of a [ScrollIncrementCalculator] function, as well as the current metrics
    /// for the scrollable.
    /// </Summary>
    public class ScrollIncrementDetails
    {
        /// <Summary>
        /// A const constructor for a [ScrollIncrementDetails].
        ///
        /// All of the arguments must not be null, and are required.
        /// </Summary>
        public ScrollIncrementDetails(FlutterSDK.Widgets.Scrollable.ScrollIncrementType type = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementType), FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics))
        : base()
        {
            this.Type = type;
            this.Metrics = metrics;
        }
        /// <Summary>
        /// The type of scroll this is (e.g. line, page, etc.).
        ///
        /// {@macro flutter.widgets.scrollable.scroll_increment_type.intent}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollable.ScrollIncrementType Type { get; set; }
        /// <Summary>
        /// The current metrics of the scrollable that is being scrolled.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics Metrics { get; set; }
    }


    /// <Summary>
    /// An [Intent] that represents scrolling the nearest scrollable by an amount
    /// appropriate for the [type] specified.
    ///
    /// The actual amount of the scroll is determined by the
    /// [Scrollable.incrementCalculator], or by its defaults if that is not
    /// specified.
    /// </Summary>
    public class ScrollIntent : FlutterSDK.Widgets.Actions.Intent
    {
        /// <Summary>
        /// Creates a const [ScrollIntent] that requests scrolling in the given
        /// [direction], with the given [type].
        ///
        /// If [reversed] is specified, then the scroll will happen in the opposite
        /// direction from the normal scroll direction.
        /// </Summary>
        public ScrollIntent(FlutterSDK.Painting.Basictypes.AxisDirection direction = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Widgets.Scrollable.ScrollIncrementType type = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementType))
        : base(ScrollableDefaultClass.ScrollAction.Key)
        {
            this.Direction = direction;
            this.Type = type;
        }
        /// <Summary>
        /// The direction in which to scroll the scrollable containing the focused
        /// widget.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection Direction { get; set; }
        /// <Summary>
        /// The type of scrolling that is intended.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollable.ScrollIncrementType Type { get; set; }

        public new bool IsEnabled(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return ScrollableDefaultClass.Scrollable.Of(context) != null;
        }



    }


    /// <Summary>
    /// An [Action] that scrolls the [Scrollable] that encloses the current
    /// [primaryFocus] by the amount configured in the [ScrollIntent] given to it.
    ///
    /// If [Scrollable.incrementCalculator] is null for the scrollable, the default
    /// for a [ScrollIntent.type] set to [ScrollIncrementType.page] is 80% of the
    /// size of the scroll window, and for [ScrollIncrementType.line], 50 logical
    /// pixels.
    /// </Summary>
    public class ScrollAction : FlutterSDK.Widgets.Actions.Action
    {
        /// <Summary>
        /// Creates a const [ScrollAction].
        /// </Summary>
        public ScrollAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely connects this action to a [ScrollIntent].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        private double _CalculateScrollIncrement(FlutterSDK.Widgets.Scrollable.ScrollableState state, FlutterSDK.Widgets.Scrollable.ScrollIncrementType type = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementType))
        {







            if (state.Widget.IncrementCalculator != null)
            {
                return state.Widget.IncrementCalculator(new ScrollIncrementDetails(type: type, metrics: state.Position));
            }

            switch (type) { case ScrollIncrementType.Line: return 50.0; case ScrollIncrementType.Page: return 0.8 * state.Position.ViewportDimension; }
            return 0.0;
        }




        private double _GetIncrement(FlutterSDK.Widgets.Scrollable.ScrollableState state, FlutterSDK.Widgets.Scrollable.ScrollIntent intent)
        {
            double increment = _CalculateScrollIncrement(state, type: intent.Type);
            switch (intent.Direction) { case AxisDirection.Down: switch (state.AxisDirection) { case AxisDirection.Up: return -increment; break; case AxisDirection.Down: return increment; break; case AxisDirection.Right: case AxisDirection.Left: return 0.0; } break; case AxisDirection.Up: switch (state.AxisDirection) { case AxisDirection.Up: return increment; break; case AxisDirection.Down: return -increment; break; case AxisDirection.Right: case AxisDirection.Left: return 0.0; } break; case AxisDirection.Left: switch (state.AxisDirection) { case AxisDirection.Right: return -increment; break; case AxisDirection.Left: return increment; break; case AxisDirection.Up: case AxisDirection.Down: return 0.0; } break; case AxisDirection.Right: switch (state.AxisDirection) { case AxisDirection.Right: return increment; break; case AxisDirection.Left: return -increment; break; case AxisDirection.Up: case AxisDirection.Down: return 0.0; } break; }
            return 0.0;
        }




        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Scrollable.ScrollIntent intent)
        {
            ScrollableState state = ScrollableDefaultClass.Scrollable.Of(node.Context);





            if (state.Widget.Physics != null && !state.Widget.Physics.ShouldAcceptUserOffset(state.Position))
            {
                return;
            }

            double increment = _GetIncrement(state, intent);
            if (increment == 0.0)
            {
                return;
            }

            state.Position.MoveTo(state.Position.Pixels + increment, duration: new TimeSpan(milliseconds: 100), curve: CurvesDefaultClass.Curves.EaseInOut);
        }


        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
            ScrollableState state = ScrollableDefaultClass.Scrollable.Of(node.Context);





            if (state.Widget.Physics != null && !state.Widget.Physics.ShouldAcceptUserOffset(state.Position))
            {
                return;
            }

            double increment = _GetIncrement(state, intent);
            if (increment == 0.0)
            {
                return;
            }

            state.Position.MoveTo(state.Position.Pixels + increment, duration: new TimeSpan(milliseconds: 100), curve: CurvesDefaultClass.Curves.EaseInOut);
        }



    }


    /// <Summary>
    /// Describes the type of scroll increment that will be performed by a
    /// [ScrollAction] on a [Scrollable].
    ///
    /// This is used to configure a [ScrollIncrementDetails] object to pass to a
    /// [ScrollIncrementCalculator] function on a [Scrollable].
    ///
    /// {@template flutter.widgets.scrollable.scroll_increment_type.intent}
    /// This indicates the *intent* of the scroll, not necessarily the size. Not all
    /// scrollable areas will have the concept of a "line" or "page", but they can
    /// respond to the different standard key bindings that cause scrolling, which
    /// are bound to keys that people use to indicate a "line" scroll (e.g.
    /// control-arrowDown keys) or a "page" scroll (e.g. pageDown key). It is
    /// recommended that at least the relative magnitudes of the scrolls match
    /// expectations.
    /// {@endtemplate}
    /// </Summary>
    public enum ScrollIncrementType
    {

        /// <Summary>
        /// Indicates that the [ScrollIncrementCalculator] should return the scroll
        /// distance it should move when the user requests to scroll by a "line".
        ///
        /// The distance a "line" scrolls refers to what should happen when the key
        /// binding for "scroll down/up by a line" is triggered. It's up to the
        /// [ScrollIncrementCalculator] function to decide what that means for a
        /// particular scrollable.
        /// </Summary>
        Line,
        /// <Summary>
        /// Indicates that the [ScrollIncrementCalculator] should return the scroll
        /// distance it should move when the user requests to scroll by a "page".
        ///
        /// The distance a "page" scrolls refers to what should happen when the key
        /// binding for "scroll down/up by a page" is triggered. It's up to the
        /// [ScrollIncrementCalculator] function to decide what that means for a
        /// particular scrollable.
        /// </Summary>
        Page,
    }

}
