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
namespace FlutterSDK.Widgets.Navigator
{
    public delegate FlutterSDK.Widgets.Navigator.Route<object> RouteFactory(FlutterSDK.Widgets.Navigator.RouteSettings settings);
    public delegate FlutterSDK.Widgets.Navigator.Route<T> RouteBuilder<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.RouteSettings settings);
    public delegate List<FlutterSDK.Widgets.Navigator.Route<object>> RouteListFactory(FlutterSDK.Widgets.Navigator.NavigatorState navigator, string initialRoute);
    public delegate bool RoutePredicate(FlutterSDK.Widgets.Navigator.Route<object> route);
    public delegate Future<bool> WillPopCallback();
    public delegate bool PopPageCallback(FlutterSDK.Widgets.Navigator.Route<object> route, object result);
    public delegate bool _RouteEntryPredicate(FlutterSDK.Widgets.Navigator._RouteEntry entry);
    internal static class NavigatorDefaultClass
    {
    }

    /// <Summary>
    /// An abstraction for an entry managed by a [Navigator].
    ///
    /// This class defines an abstract interface between the navigator and the
    /// "routes" that are pushed on and popped off the navigator. Most routes have
    /// visual affordances, which they place in the navigators [Overlay] using one
    /// or more [OverlayEntry] objects.
    ///
    /// See [Navigator] for more explanation of how to use a [Route] with
    /// navigation, including code examples.
    ///
    /// See [MaterialPageRoute] for a route that replaces the entire screen with a
    /// platform-adaptive transition.
    ///
    /// A route can belong to a page if the [settings] are a subclass of [Page]. A
    /// page-based route, as opposite to pageless route, is created from
    /// [Page.createRoute] during [Navigator.pages] updates. The page associated
    /// with this route may change during the lifetime of the route. If the
    /// [Navigator] updates the page of this route, it calls [changedInternalState]
    /// to notify the route that the page has been updated.
    ///
    /// The type argument `T` is the route's return type, as used by
    /// [currentResult], [popped], and [didPop]. The type `void` may be used if the
    /// route does not return a value.
    /// </Summary>
    public interface IRoute<T>
    {
        void Install();
        FlutterSDK.Scheduler.Ticker.TickerFuture DidPush();
        void DidAdd();
        void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> oldRoute);
        Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop();
        bool DidPop(T result);
        void DidComplete(T result);
        void DidPopNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute);
        void DidChangeNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute);
        void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute);
        void ChangedInternalState();
        void ChangedExternalState();
        void Dispose();
        FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get; }
        FlutterSDK.Widgets.Navigator.RouteSettings Settings { get; }
        List<FlutterSDK.Widgets.Overlay.OverlayEntry> OverlayEntries { get; }
        bool WillHandlePopInternally { get; }
        T CurrentResult { get; }
        Future<T> Popped { get; }
        bool IsCurrent { get; }
        bool IsFirst { get; }
        bool IsActive { get; }
    }


    /// <Summary>
    /// Describes the configuration of a [Route].
    ///
    /// The type argument `T` is the corresponding [Route]'s return type, as
    /// used by [Route.currentResult], [Route.popped], and [Route.didPop].
    ///
    /// See also:
    ///
    ///  * [Navigator.pages], which accepts a list of [Page]s and updates its routes
    ///    history.
    ///  * [CustomBuilderPage], a [Page] subclass that provides the API to build a
    ///    customized route.
    /// </Summary>
    public interface IPage<T>
    {
        bool CanUpdate(FlutterSDK.Widgets.Navigator.Page<object> other);
        Route<T> CreateRoute(FlutterSDK.Widgets.Framework.BuildContext context);
        string ToString();
        FlutterSDK.Foundation.Key.LocalKey Key { get; }
    }


    /// <Summary>
    /// The delegate that decides how pages added and removed from [Navigator.pages]
    /// transition in or out of the screen.
    ///
    /// This abstract class implements the API to be called by [Navigator] when it
    /// requires explicit decisions on how the routes transition on or off the screen.
    ///
    /// To make route transition decisions, subclass must implement [resolve].
    ///
    /// {@tool sample --template=freeform}
    /// The following example demonstrates how to implement a subclass that always
    /// removes or adds routes without animated transitions and puts the removed
    /// routes at the top of the list.
    ///
    /// ```dart imports
    /// import 'package:flutter/widgets.dart';
    /// ```
    ///
    /// ```dart
    /// class NoAnimationTransitionDelegate extends TransitionDelegate<void> {
    ///   @override
    ///   Iterable<RouteTransitionRecord> resolve({
    ///     List<RouteTransitionRecord> newPageRouteHistory,
    ///     Map<RouteTransitionRecord, RouteTransitionRecord> locationToExitingPageRoute,
    ///     Map<RouteTransitionRecord, List<RouteTransitionRecord>> pageRouteToPagelessRoutes,
    ///   }) {
    ///     final List<RouteTransitionRecord> results = <RouteTransitionRecord>[];
    ///
    ///     for (final RouteTransitionRecord pageRoute in newPageRouteHistory) {
    ///       if (pageRoute.isEntering) {
    ///         pageRoute.markForAdd();
    ///       }
    ///       results.add(pageRoute);
    ///
    ///     }
    ///     for (final RouteTransitionRecord exitingPageRoute in locationToExitingPageRoute.values) {
    ///       exitingPageRoute.markForRemove();
    ///       final List<RouteTransitionRecord> pagelessRoutes = pageRouteToPagelessRoutes[exitingPageRoute];
    ///       if (pagelessRoutes != null) {
    ///         for (final RouteTransitionRecord pagelessRoute in pagelessRoutes) {
    ///           pagelessRoute.markForRemove();
    ///         }
    ///       }
    ///       results.add(exitingPageRoute);
    ///
    ///     }
    ///     return results;
    ///   }
    /// }
    ///
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Navigator.transitionDelegate], which uses this class to make route
    ///    transition decisions.
    ///  * [DefaultTransitionDelegate], which implements the default way to decide
    ///    how routes transition in or out of the screen.
    /// </Summary>
    public interface ITransitionDelegate<T>
    {
        Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> Resolve(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>));
    }


    public interface INavigatorObserver { }

    public class NavigatorObserver
    {
        internal virtual FlutterSDK.Widgets.Navigator.NavigatorState _Navigator { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The [Navigator] pushed `route`.
        ///
        /// The route immediately below that one, and thus the previously active
        /// route, is `previousRoute`.
        /// </Summary>
        public virtual void DidPush(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {
        }




        /// <Summary>
        /// The [Navigator] popped `route`.
        ///
        /// The route immediately below that one, and thus the newly active
        /// route, is `previousRoute`.
        /// </Summary>
        public virtual void DidPop(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {
        }




        /// <Summary>
        /// The [Navigator] removed `route`.
        ///
        /// If only one route is being removed, then the route immediately below
        /// that one, if any, is `previousRoute`.
        ///
        /// If multiple routes are being removed, then the route below the
        /// bottommost route being removed, if any, is `previousRoute`, and this
        /// method will be called once for each removed route, from the topmost route
        /// to the bottommost route.
        /// </Summary>
        public virtual void DidRemove(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {
        }




        /// <Summary>
        /// The [Navigator] replaced `oldRoute` with `newRoute`.
        /// </Summary>
        public virtual void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> newRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>))
        {
        }




        /// <Summary>
        /// The [Navigator]'s routes are being moved by a user gesture.
        ///
        /// For example, this is called when an iOS back gesture starts, and is used
        /// to disabled hero animations during such interactions.
        /// </Summary>
        public virtual void DidStartUserGesture(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {
        }




        /// <Summary>
        /// User gesture is no longer controlling the [Navigator].
        ///
        /// Paired with an earlier call to [didStartUserGesture].
        /// </Summary>
        public virtual void DidStopUserGesture()
        {
        }



    }
    public static class NavigatorObserverMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<INavigatorObserver, NavigatorObserver> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<INavigatorObserver, NavigatorObserver>();
        static NavigatorObserver GetOrCreate(INavigatorObserver instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new NavigatorObserver();
                _table.Add(instance, value);
            }
            return (NavigatorObserver)value;
        }
        public static FlutterSDK.Widgets.Navigator.NavigatorState NavigatorProperty(this INavigatorObserver instance) => GetOrCreate(instance).Navigator;
        public static void DidPush(this INavigatorObserver instance, FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) => GetOrCreate(instance).DidPush(route, previousRoute);
        public static void DidPop(this INavigatorObserver instance, FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) => GetOrCreate(instance).DidPop(route, previousRoute);
        public static void DidRemove(this INavigatorObserver instance, FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) => GetOrCreate(instance).DidRemove(route, previousRoute);
        public static void DidReplace(this INavigatorObserver instance, FlutterSDK.Widgets.Navigator.Route<object> newRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>)) => GetOrCreate(instance).DidReplace(newRoute, oldRoute);
        public static void DidStartUserGesture(this INavigatorObserver instance, FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) => GetOrCreate(instance).DidStartUserGesture(route, previousRoute);
        public static void DidStopUserGesture(this INavigatorObserver instance) => GetOrCreate(instance).DidStopUserGesture();
    }


    public interface IRouteTransitionRecord { }

    public class RouteTransitionRecord
    {
        internal virtual bool _DebugWaitingForExitDecision { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.Route<object> Route { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEntering { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Marks the [route] to be pushed with transition.
        ///
        /// During [TransitionDelegate.resolve], this can be called on an entering
        /// route (where [RouteTransitionRecord.isEntering] is true) in indicate that the
        /// route should be pushed onto the [Navigator] with an animated transition.
        /// </Summary>
        public virtual void MarkForPush()
        {
        }


        /// <Summary>
        /// Marks the [route] to be added without transition.
        ///
        /// During [TransitionDelegate.resolve], this can be called on an entering
        /// route (where [RouteTransitionRecord.isEntering] is true) in indicate that the
        /// route should be added onto the [Navigator] without an animated transition.
        /// </Summary>
        public virtual void MarkForAdd()
        {
        }


        /// <Summary>
        /// Marks the [route] to be popped with transition.
        ///
        /// During [TransitionDelegate.resolve], this can be called on an exiting
        /// route to indicate that the route should be popped off the [Navigator] with
        /// an animated transition.
        /// </Summary>
        public virtual void MarkForPop(object result = default(object))
        {
        }


        /// <Summary>
        /// Marks the [route] to be completed without transition.
        ///
        /// During [TransitionDelegate.resolve], this can be called on an exiting
        /// route to indicate that the route should be completed with the provided
        /// result and removed from the [Navigator] without an animated transition.
        /// </Summary>
        public virtual void MarkForComplete(object result = default(object))
        {
        }


        /// <Summary>
        /// Marks the [route] to be removed without transition.
        ///
        /// During [TransitionDelegate.resolve], this can be called on an exiting
        /// route to indicate that the route should be removed from the [Navigator]
        /// without completing and without an animated transition.
        /// </Summary>
        public virtual void MarkForRemove()
        {
        }

    }
    public static class RouteTransitionRecordMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRouteTransitionRecord, RouteTransitionRecord> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRouteTransitionRecord, RouteTransitionRecord>();
        static RouteTransitionRecord GetOrCreate(IRouteTransitionRecord instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RouteTransitionRecord();
                _table.Add(instance, value);
            }
            return (RouteTransitionRecord)value;
        }
        public static FlutterSDK.Widgets.Navigator.Route<object> RouteProperty(this IRouteTransitionRecord instance) => GetOrCreate(instance).Route;
        public static bool IsEnteringProperty(this IRouteTransitionRecord instance) => GetOrCreate(instance).IsEntering;
        public static void MarkForPush(this IRouteTransitionRecord instance) => GetOrCreate(instance).MarkForPush();
        public static void MarkForAdd(this IRouteTransitionRecord instance) => GetOrCreate(instance).MarkForAdd();
        public static void MarkForPop(this IRouteTransitionRecord instance, object result = default(object)) => GetOrCreate(instance).MarkForPop(result);
        public static void MarkForComplete(this IRouteTransitionRecord instance, object result = default(object)) => GetOrCreate(instance).MarkForComplete(result);
        public static void MarkForRemove(this IRouteTransitionRecord instance) => GetOrCreate(instance).MarkForRemove();
    }


    /// <Summary>
    /// An abstraction for an entry managed by a [Navigator].
    ///
    /// This class defines an abstract interface between the navigator and the
    /// "routes" that are pushed on and popped off the navigator. Most routes have
    /// visual affordances, which they place in the navigators [Overlay] using one
    /// or more [OverlayEntry] objects.
    ///
    /// See [Navigator] for more explanation of how to use a [Route] with
    /// navigation, including code examples.
    ///
    /// See [MaterialPageRoute] for a route that replaces the entire screen with a
    /// platform-adaptive transition.
    ///
    /// A route can belong to a page if the [settings] are a subclass of [Page]. A
    /// page-based route, as opposite to pageless route, is created from
    /// [Page.createRoute] during [Navigator.pages] updates. The page associated
    /// with this route may change during the lifetime of the route. If the
    /// [Navigator] updates the page of this route, it calls [changedInternalState]
    /// to notify the route that the page has been updated.
    ///
    /// The type argument `T` is the route's return type, as used by
    /// [currentResult], [popped], and [didPop]. The type `void` may be used if the
    /// route does not return a value.
    /// </Summary>
    public class Route<T>
    {
        #region constructors
        public Route(FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base()
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Navigator.NavigatorState _Navigator { get; set; }
        internal virtual FlutterSDK.Widgets.Navigator.RouteSettings _Settings { get; set; }
        internal virtual Completer<T> _PopCompleter { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Navigator.RouteSettings Settings { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<FlutterSDK.Widgets.Overlay.OverlayEntry> OverlayEntries { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool WillHandlePopInternally { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual T CurrentResult { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Future<T> Popped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsCurrent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFirst { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsActive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _UpdateSettings(FlutterSDK.Widgets.Navigator.RouteSettings newSettings)
        {

            if (_Settings != newSettings)
            {
                _Settings = newSettings;
                ChangedInternalState();
            }

        }




        /// <Summary>
        /// Called when the route is inserted into the navigator.
        ///
        /// Uses this to populate [overlayEntries]. There must be at least one entry in
        /// this list after [install] has been invoked. The [Navigator] will be in charge
        /// to add them to the [Overlay] or remove them from it by calling
        /// [OverlayEntry.remove].
        /// </Summary>
        public virtual void Install()
        {
        }




        /// <Summary>
        /// Called after [install] when the route is pushed onto the navigator.
        ///
        /// The returned value resolves when the push transition is complete.
        ///
        /// The [didAdd] method will be called instead of [didPush] when the route
        /// immediately appears on screen without any push transition.
        ///
        /// The [didChangeNext] and [didChangePrevious] methods are typically called
        /// immediately after this method is called.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture DidPush()
        {
            return TickerFuture.Complete();
            TickerFuture.Complete().Then((void _) =>
            {
                Navigator?.FocusScopeNode?.RequestFocus();
            }
            );
        }




        /// <Summary>
        /// Called after [install] when the route is added to the navigator.
        ///
        /// This method is called instead of [didPush] when the route immediately
        /// appears on screen without any push transition.
        ///
        /// The [didChangeNext] and [didChangePrevious] methods are typically called
        /// immediately after this method is called.
        /// </Summary>
        public virtual void DidAdd()
        {
            TickerFuture.Complete().Then((void _) =>
            {
                Navigator.FocusScopeNode.RequestFocus();
            }
            );
        }




        /// <Summary>
        /// Called after [install] when the route replaced another in the navigator.
        ///
        /// The [didChangeNext] and [didChangePrevious] methods are typically called
        /// immediately after this method is called.
        /// </Summary>
        public virtual void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> oldRoute)
        {
        }




        /// <Summary>
        /// Returns whether calling [Navigator.maybePop] when this [Route] is current
        /// ([isCurrent]) should do anything.
        ///
        /// [Navigator.maybePop] is usually used instead of [pop] to handle the system
        /// back button.
        ///
        /// By default, if a [Route] is the first route in the history (i.e., if
        /// [isFirst]), it reports that pops should be bubbled
        /// ([RoutePopDisposition.bubble]). This behavior prevents the user from
        /// popping the first route off the history and being stranded at a blank
        /// screen; instead, the larger scope is popped (e.g. the application quits,
        /// so that the user returns to the previous application).
        ///
        /// In other cases, the default behaviour is to accept the pop
        /// ([RoutePopDisposition.pop]).
        ///
        /// The third possible value is [RoutePopDisposition.doNotPop], which causes
        /// the pop request to be ignored entirely.
        ///
        /// See also:
        ///
        ///  * [Form], which provides a [Form.onWillPop] callback that uses this
        ///    mechanism.
        ///  * [WillPopScope], another widget that provides a way to intercept the
        ///    back button.
        /// </Summary>
        public virtual Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop()
        {
            return IsFirst ? RoutePopDisposition.Bubble : RoutePopDisposition.Pop;
        }




        /// <Summary>
        /// A request was made to pop this route. If the route can handle it
        /// internally (e.g. because it has its own stack of internal state) then
        /// return false, otherwise return true (by returning the value of calling
        /// `super.didPop`). Returning false will prevent the default behavior of
        /// [NavigatorState.pop].
        ///
        /// When this function returns true, the navigator removes this route from
        /// the history but does not yet call [dispose]. Instead, it is the route's
        /// responsibility to call [NavigatorState.finalizeRoute], which will in turn
        /// call [dispose] on the route. This sequence lets the route perform an
        /// exit animation (or some other visual effect) after being popped but prior
        /// to being disposed.
        ///
        /// This method should call [didComplete] to resolve the [popped] future (and
        /// this is all that the default implementation does); routes should not wait
        /// for their exit animation to complete before doing so.
        ///
        /// See [popped], [didComplete], and [currentResult] for a discussion of the
        /// `result` argument.
        /// </Summary>
        public virtual bool DidPop(T result)
        {
            DidComplete(result);
            return true;
        }




        /// <Summary>
        /// The route was popped or is otherwise being removed somewhat gracefully.
        ///
        /// This is called by [didPop] and in response to
        /// [NavigatorState.pushReplacement]. If [didPop] was not called, then the
        /// [Navigator.finalizeRoute] method must be called immediately, and no exit
        /// animation will run.
        ///
        /// The [popped] future is completed by this method. The `result` argument
        /// specifies the value that this future is completed with, unless it is null,
        /// in which case [currentResult] is used instead.
        ///
        /// This should be called before the pop animation, if any, takes place,
        /// though in some cases the animation may be driven by the user before the
        /// route is committed to being popped; this can in particular happen with the
        /// iOS-style back gesture. See [Navigator.didStartUserGesture].
        /// </Summary>
        public virtual void DidComplete(T result)
        {
            _PopCompleter.Complete(result ?? CurrentResult);
        }




        /// <Summary>
        /// The given route, which was above this one, has been popped off the
        /// navigator.
        ///
        /// This route is now the current route ([isCurrent] is now true), and there
        /// is no next route.
        /// </Summary>
        public virtual void DidPopNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute)
        {
        }




        /// <Summary>
        /// This route's next route has changed to the given new route.
        ///
        /// This is called on a route whenever the next route changes for any reason,
        /// so long as it is in the history, including when a route is first added to
        /// a [Navigator] (e.g. by [Navigator.push]), except for cases when
        /// [didPopNext] would be called.
        ///
        /// The `nextRoute` argument will be null if there's no new next route (i.e.
        /// if [isCurrent] is true).
        /// </Summary>
        public virtual void DidChangeNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute)
        {
        }




        /// <Summary>
        /// This route's previous route has changed to the given new route.
        ///
        /// This is called on a route whenever the previous route changes for any
        /// reason, so long as it is in the history, except for immediately after the
        /// route itself has been pushed (in which case [didPush] or [didReplace] will
        /// be called instead).
        ///
        /// The `previousRoute` argument will be null if there's no previous route
        /// (i.e. if [isFirst] is true).
        /// </Summary>
        public virtual void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {
        }




        /// <Summary>
        /// Called whenever the internal state of the route has changed.
        ///
        /// This should be called whenever [willHandlePopInternally], [didPop],
        /// [offstage], or other internal state of the route changes value. It is used
        /// by [ModalRoute], for example, to report the new information via its
        /// inherited widget to any children of the route.
        ///
        /// See also:
        ///
        ///  * [changedExternalState], which is called when the [Navigator] rebuilds.
        /// </Summary>
        public virtual void ChangedInternalState()
        {
        }




        /// <Summary>
        /// Called whenever the [Navigator] has its widget rebuilt, to indicate that
        /// the route may wish to rebuild as well.
        ///
        /// This is called by the [Navigator] whenever the [NavigatorState]'s
        /// [widget] changes, for example because the [MaterialApp] has been rebuilt.
        /// This ensures that routes that directly refer to the state of the widget
        /// that built the [MaterialApp] will be notified when that widget rebuilds,
        /// since it would otherwise be difficult to notify the routes that state they
        /// depend on may have changed.
        ///
        /// See also:
        ///
        ///  * [changedInternalState], the equivalent but for changes to the internal
        ///    state of the route.
        /// </Summary>
        public virtual void ChangedExternalState()
        {
        }




        /// <Summary>
        /// Discards any resources used by the object.
        ///
        /// This method should not remove its [overlayEntries] from the [Overlay]. The
        /// object's owner is in charge of doing that.
        ///
        /// After this is called, the object is not in a usable state and should be
        /// discarded.
        ///
        /// This method should only be called by the object's owner; typically the
        /// [Navigator] owns a route and so will call this method when the route is
        /// removed, after which the route is no longer referenced by the navigator.
        /// </Summary>
        public virtual void Dispose()
        {
            _Navigator = null;
        }



        #endregion
    }


    /// <Summary>
    /// Data that might be useful in constructing a [Route].
    /// </Summary>
    public class RouteSettings
    {
        #region constructors
        public RouteSettings(string name = default(string), @Object arguments = default(@Object))
        {
            this.Name = name;
            this.Arguments = arguments;
        }
        #endregion

        #region fields
        public virtual string Name { get; set; }
        public virtual @Object Arguments { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a copy of this route settings object with the given fields
        /// replaced with the new values.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteSettings CopyWith(string name = default(string), @Object arguments = default(@Object))
        {
            return new RouteSettings(name: name ?? this.Name, arguments: arguments ?? this.Arguments);
        }




        #endregion
    }


    /// <Summary>
    /// Describes the configuration of a [Route].
    ///
    /// The type argument `T` is the corresponding [Route]'s return type, as
    /// used by [Route.currentResult], [Route.popped], and [Route.didPop].
    ///
    /// See also:
    ///
    ///  * [Navigator.pages], which accepts a list of [Page]s and updates its routes
    ///    history.
    ///  * [CustomBuilderPage], a [Page] subclass that provides the API to build a
    ///    customized route.
    /// </Summary>
    public class Page<T> : FlutterSDK.Widgets.Navigator.RouteSettings
    {
        #region constructors
        public Page(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), string name = default(string), @Object arguments = default(@Object))
        : base(name: name, arguments: arguments)
        {
            this.Key = key;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Whether this page can be updated with the [other] page.
        ///
        /// Two pages are consider updatable if they have same the [runtimeType] and
        /// [key].
        /// </Summary>
        public virtual bool CanUpdate(FlutterSDK.Widgets.Navigator.Page<object> other)
        {
            return other.GetType() == GetType() && other.Key == Key;
        }




        /// <Summary>
        /// Creates the [Route] that corresponds to this page.
        ///
        /// The created [Route] must have its [Route.settings] property set to this [Page].
        /// </Summary>
        public virtual Route<T> CreateRoute(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Route<T>);
        }


        #endregion
    }


    /// <Summary>
    /// A [Page] that builds a customized [Route] based on the [routeBuilder].
    ///
    /// The type argument `T` is the corresponding [Route]'s return type, as
    /// used by [Route.currentResult], [Route.popped], and [Route.didPop].
    /// </Summary>
    public class CustomBuilderPage<T> : FlutterSDK.Widgets.Navigator.Page<T>
    {
        #region constructors
        public CustomBuilderPage(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), FlutterSDK.Widgets.Navigator.RouteBuilder<T> routeBuilder = default(FlutterSDK.Widgets.Navigator.RouteBuilder<T>), string name = default(string), @Object arguments = default(@Object))
        : base(key: key, name: name, arguments: arguments)
        {
            this.RouteBuilder = routeBuilder;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Navigator.RouteBuilder<T> RouteBuilder { get; set; }
        #endregion

        #region methods

        public new Route<T> CreateRoute(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Route<T> route = RouteBuilder(context, this);

            return route;
        }



        #endregion
    }


    /// <Summary>
    /// The delegate that decides how pages added and removed from [Navigator.pages]
    /// transition in or out of the screen.
    ///
    /// This abstract class implements the API to be called by [Navigator] when it
    /// requires explicit decisions on how the routes transition on or off the screen.
    ///
    /// To make route transition decisions, subclass must implement [resolve].
    ///
    /// {@tool sample --template=freeform}
    /// The following example demonstrates how to implement a subclass that always
    /// removes or adds routes without animated transitions and puts the removed
    /// routes at the top of the list.
    ///
    /// ```dart imports
    /// import 'package:flutter/widgets.dart';
    /// ```
    ///
    /// ```dart
    /// class NoAnimationTransitionDelegate extends TransitionDelegate<void> {
    ///   @override
    ///   Iterable<RouteTransitionRecord> resolve({
    ///     List<RouteTransitionRecord> newPageRouteHistory,
    ///     Map<RouteTransitionRecord, RouteTransitionRecord> locationToExitingPageRoute,
    ///     Map<RouteTransitionRecord, List<RouteTransitionRecord>> pageRouteToPagelessRoutes,
    ///   }) {
    ///     final List<RouteTransitionRecord> results = <RouteTransitionRecord>[];
    ///
    ///     for (final RouteTransitionRecord pageRoute in newPageRouteHistory) {
    ///       if (pageRoute.isEntering) {
    ///         pageRoute.markForAdd();
    ///       }
    ///       results.add(pageRoute);
    ///
    ///     }
    ///     for (final RouteTransitionRecord exitingPageRoute in locationToExitingPageRoute.values) {
    ///       exitingPageRoute.markForRemove();
    ///       final List<RouteTransitionRecord> pagelessRoutes = pageRouteToPagelessRoutes[exitingPageRoute];
    ///       if (pagelessRoutes != null) {
    ///         for (final RouteTransitionRecord pagelessRoute in pagelessRoutes) {
    ///           pagelessRoute.markForRemove();
    ///         }
    ///       }
    ///       results.add(exitingPageRoute);
    ///
    ///     }
    ///     return results;
    ///   }
    /// }
    ///
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Navigator.transitionDelegate], which uses this class to make route
    ///    transition decisions.
    ///  * [DefaultTransitionDelegate], which implements the default way to decide
    ///    how routes transition in or out of the screen.
    /// </Summary>
    public class TransitionDelegate<T>
    {
        #region constructors
        public TransitionDelegate()
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        private Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> _Transition(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>))
        {
            Iterable<RouteTransitionRecord> results = Resolve(newPageRouteHistory: newPageRouteHistory, locationToExitingPageRoute: locationToExitingPageRoute, pageRouteToPagelessRoutes: pageRouteToPagelessRoutes);

            return results;
        }




        /// <Summary>
        /// A method that will be called by the [Navigator] to decide how routes
        /// transition in or out of the screen when [Navigator.pages] is updated.
        ///
        /// The `newPageRouteHistory` list contains all page-based routes in the order
        /// that will be on the [Navigator]'s history stack after this update
        /// completes. If a route in `newPageRouteHistory` has its
        /// [RouteTransitionRecord.isEntering] set to true, this route requires explicit
        /// decision on how it should transition onto the Navigator. To make a
        /// decision, call [RouteTransitionRecord.markForPush] or
        /// [RouteTransitionRecord.markForAdd].
        ///
        /// The `locationToExitingPageRoute` contains the pages-based routes that
        /// are removed from the routes history after page update and require explicit
        /// decision on how to transition off the screen. This map records page-based
        /// routes to be removed with the location of the route in the original route
        /// history before the update. The keys are the locations represented by the
        /// page-based routes that are directly below the removed routes, and the value
        /// are the page-based routes to be removed. The location is null if the route
        /// to be removed is the bottom most route. To make a decision for a removed
        /// route, call [RouteTransitionRecord.markForPop],
        /// [RouteTransitionRecord.markForComplete] or
        /// [RouteTransitionRecord.markForRemove].
        ///
        /// The `pageRouteToPagelessRoutes` records the page-based routes and their
        /// associated pageless routes. If a page-based route is to be removed, its
        /// associated pageless routes also require explicit decisions on how to
        /// transition off the screen.
        ///
        /// Once all the decisions have been made, this method must merge the removed
        /// routes and the `newPageRouteHistory` and return the merged result. The
        /// order in the result will be the order the [Navigator] uses for updating
        /// the route history. The return list must preserve the same order of routes
        /// in `newPageRouteHistory`. The removed routes, however, can be inserted
        /// into the return list freely as long as all of them are included.
        ///
        /// For example, consider the following case.
        ///
        ///    newPageRouteHistory = [A, B, C]
        ///
        ///    locationToExitingPageRoute = {A -> D, C -> E}
        ///
        /// The following outputs are valid.
        ///
        ///    result = [A, B ,C ,D ,E] is valid
        ///    result = [D, A, B ,C ,E] is also valid because exiting route can be
        ///    inserted in any place
        ///
        /// The following outputs are invalid.
        ///
        ///    result = [B, A, C ,D ,E] is invalid because B must be after A.
        ///    result = [A, B, C ,E] is invalid because results must include D.
        ///
        /// See also:
        ///
        ///  * [RouteTransitionRecord.markForPush], which makes route enter the screen
        ///    with an animated transition.
        ///  * [RouteTransitionRecord.markForAdd], which makes route enter the screen
        ///    without an animated transition.
        ///  * [RouteTransitionRecord.markForPop], which makes route exit the screen
        ///    with an animated transition.
        ///  * [RouteTransitionRecord.markForRemove], which does not complete the
        ///    route and makes it exit the screen without an animated transition.
        ///  * [RouteTransitionRecord.markForComplete], which completes the route and
        ///    makes it exit the screen without an animated transition.
        ///  * [DefaultTransitionDelegate.resolve], which implements the default way
        ///    to decide how routes transition in or out of the screen.
        /// </Summary>
        public virtual Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> Resolve(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>))
        {
            return default(Iterable<RouteTransitionRecord>);
        }

        #endregion
    }


    /// <Summary>
    /// The default implementation of [TransitionDelegate] that the [Navigator] will
    /// use if its [Navigator.transitionDelegate] is not specified.
    ///
    /// This transition delegate follows two rules. Firstly, all the entering routes
    /// are placed on top of the exiting routes if they are at the same location.
    /// Secondly, the top most route will always transition with an animated transition.
    /// All the other routes below will either be completed with
    /// [Route.currentResult] or added without an animated transition.
    /// </Summary>
    public class DefaultTransitionDelegate<T> : FlutterSDK.Widgets.Navigator.TransitionDelegate<T>
    {
        #region constructors
        public DefaultTransitionDelegate()
        : base()
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> Resolve(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>))
        {
            List<RouteTransitionRecord> results = new List<RouteTransitionRecord>() { };
            void HandleExitingRoute(RouteTransitionRecord location, bool isLast) => {
                RouteTransitionRecord exitingPageRoute = locationToExitingPageRoute[location];
                if (exitingPageRoute == null) return;

                bool hasPagelessRoute = pageRouteToPagelessRoutes.ContainsKey(exitingPageRoute);
                bool isLastExitingPageRoute = isLast && !locationToExitingPageRoute.ContainsKey(exitingPageRoute);
                if (isLastExitingPageRoute && !hasPagelessRoute)
                {
                    exitingPageRoute.MarkForPop(exitingPageRoute.Route.CurrentResult);
                }
                else
                {
                    exitingPageRoute.MarkForComplete(exitingPageRoute.Route.CurrentResult);
                }

                results.Add(exitingPageRoute);
                if (hasPagelessRoute)
                {
                    List<RouteTransitionRecord> pagelessRoutes = pageRouteToPagelessRoutes[exitingPageRoute];
                    foreach (RouteTransitionRecord pagelessRoute in pagelessRoutes)
                    {

                        if (isLastExitingPageRoute && pagelessRoute == pagelessRoutes.Last())
                        {
                            pagelessRoute.MarkForPop(pagelessRoute.Route.CurrentResult);
                        }
                        else
                        {
                            pagelessRoute.MarkForComplete(pagelessRoute.Route.CurrentResult);
                        }

                    }

                }

                HandleExitingRoute(exitingPageRoute, isLast);
            }

            HandleExitingRoute(null, newPageRouteHistory.IsEmpty());
            foreach (RouteTransitionRecord pageRoute in newPageRouteHistory)
            {
                bool isLastIteration = newPageRouteHistory.Last() == pageRoute;
                if (pageRoute.IsEntering)
                {
                    if (!locationToExitingPageRoute.ContainsKey(pageRoute) && isLastIteration)
                    {
                        pageRoute.MarkForPush();
                    }
                    else
                    {
                        pageRoute.MarkForAdd();
                    }

                }

                results.Add(pageRoute);
                HandleExitingRoute(pageRoute, isLastIteration);
            }

            return results;
        }



        #endregion
    }


    /// <Summary>
    /// A widget that manages a set of child widgets with a stack discipline.
    ///
    /// Many apps have a navigator near the top of their widget hierarchy in order
    /// to display their logical history using an [Overlay] with the most recently
    /// visited pages visually on top of the older pages. Using this pattern lets
    /// the navigator visually transition from one page to another by moving the widgets
    /// around in the overlay. Similarly, the navigator can be used to show a dialog
    /// by positioning the dialog widget above the current page.
    ///
    /// ## Using the Navigator API
    ///
    /// Mobile apps typically reveal their contents via full-screen elements
    /// called "screens" or "pages". In Flutter these elements are called
    /// routes and they're managed by a [Navigator] widget. The navigator
    /// manages a stack of [Route] objects and provides two ways for managing
    /// the stack, the declarative API [Navigator.pages] or imperative API
    /// [Navigator.push] and [Navigator.pop].
    ///
    /// When your user interface fits this paradigm of a stack, where the user
    /// should be able to _navigate_ back to an earlier element in the stack,
    /// the use of routes and the Navigator is appropriate. On certain platforms,
    /// such as Android, the system UI will provide a back button (outside the
    /// bounds of your application) that will allow the user to navigate back
    /// to earlier routes in your application's stack. On platforms that don't
    /// have this build-in navigation mechanism, the use of an [AppBar] (typically
    /// used in the [Scaffold.appBar] property) can automatically add a back
    /// button for user navigation.
    ///
    /// ## Using the Pages API
    ///
    /// The [Navigator] will convert its [Navigator.pages] into a stack of [Route]s
    /// if it is provided. A change in [Navigator.pages] will trigger an update to
    /// the stack of [Route]s. The [Navigator] will update its routes to match the
    /// new configuration of its [Navigator.pages]. To use this API, one can use
    /// [CustomBuilderPage] or create a [Page] subclass and defines a list of
    /// [Page]s for [Navigator.pages]. A [Navigator.onPopPage] callback is also
    /// required to properly clean up the input pages in case of a pop.
    ///
    /// By Default, the [Navigator] will use [DefaultTransitionDelegate] to decide
    /// how routes transition in or out of the screen. To customize it, define a
    /// [TransitionDelegate] subclass and provide it to the
    /// [Navigator.transitionDelegate].
    ///
    /// ### Displaying a full-screen route
    ///
    /// Although you can create a navigator directly, it's most common to use the
    /// navigator created by the [Router] which itself is created and configured by
    /// a [WidgetsApp] or a [MaterialApp] widget. You can refer to that navigator
    /// with [Navigator.of].
    ///
    /// A [MaterialApp] is the simplest way to set things up. The [MaterialApp]'s
    /// home becomes the route at the bottom of the [Navigator]'s stack. It is what
    /// you see when the app is launched.
    ///
    /// ```dart
    /// void main() {
    ///   runApp(MaterialApp(home: MyAppHome()));
    /// }
    /// ```
    ///
    /// To push a new route on the stack you can create an instance of
    /// [MaterialPageRoute] with a builder function that creates whatever you
    /// want to appear on the screen. For example:
    ///
    /// ```dart
    /// Navigator.push(context, MaterialPageRoute<void>(
    ///   builder: (BuildContext context) {
    ///     return Scaffold(
    ///       appBar: AppBar(title: Text('My Page')),
    ///       body: Center(
    ///         child: FlatButton(
    ///           child: Text('POP'),
    ///           onPressed: () {
    ///             Navigator.pop(context);
    ///           },
    ///         ),
    ///       ),
    ///     );
    ///   },
    /// ));
    /// ```
    ///
    /// The route defines its widget with a builder function instead of a
    /// child widget because it will be built and rebuilt in different
    /// contexts depending on when it's pushed and popped.
    ///
    /// As you can see, the new route can be popped, revealing the app's home
    /// page, with the Navigator's pop method:
    ///
    /// ```dart
    /// Navigator.pop(context);
    /// ```
    ///
    /// It usually isn't necessary to provide a widget that pops the Navigator
    /// in a route with a [Scaffold] because the Scaffold automatically adds a
    /// 'back' button to its AppBar. Pressing the back button causes
    /// [Navigator.pop] to be called. On Android, pressing the system back
    /// button does the same thing.
    ///
    /// ### Using named navigator routes
    ///
    /// Mobile apps often manage a large number of routes and it's often
    /// easiest to refer to them by name. Route names, by convention,
    /// use a path-like structure (for example, '/a/b/c').
    /// The app's home page route is named '/' by default.
    ///
    /// The [MaterialApp] can be created
    /// with a [Map<String, WidgetBuilder>] which maps from a route's name to
    /// a builder function that will create it. The [MaterialApp] uses this
    /// map to create a value for its navigator's [onGenerateRoute] callback.
    ///
    /// ```dart
    /// void main() {
    ///   runApp(MaterialApp(
    ///     home: MyAppHome(), // becomes the route named '/'
    ///     routes: <String, WidgetBuilder> {
    ///       '/a': (BuildContext context) => MyPage(title: 'page A'),
    ///       '/b': (BuildContext context) => MyPage(title: 'page B'),
    ///       '/c': (BuildContext context) => MyPage(title: 'page C'),
    ///     },
    ///   ));
    /// }
    /// ```
    ///
    /// To show a route by name:
    ///
    /// ```dart
    /// Navigator.pushNamed(context, '/b');
    /// ```
    ///
    /// ### Routes can return a value
    ///
    /// When a route is pushed to ask the user for a value, the value can be
    /// returned via the [pop] method's result parameter.
    ///
    /// Methods that push a route return a [Future]. The Future resolves when the
    /// route is popped and the [Future]'s value is the [pop] method's `result`
    /// parameter.
    ///
    /// For example if we wanted to ask the user to press 'OK' to confirm an
    /// operation we could `await` the result of [Navigator.push]:
    ///
    /// ```dart
    /// bool value = await Navigator.push(context, MaterialPageRoute<bool>(
    ///   builder: (BuildContext context) {
    ///     return Center(
    ///       child: GestureDetector(
    ///         child: Text('OK'),
    ///         onTap: () { Navigator.pop(context, true); }
    ///       ),
    ///     );
    ///   }
    /// ));
    /// ```
    ///
    /// If the user presses 'OK' then value will be true. If the user backs
    /// out of the route, for example by pressing the Scaffold's back button,
    /// the value will be null.
    ///
    /// When a route is used to return a value, the route's type parameter must
    /// match the type of [pop]'s result. That's why we've used
    /// `MaterialPageRoute<bool>` instead of `MaterialPageRoute<void>` or just
    /// `MaterialPageRoute`. (If you prefer to not specify the types, though, that's
    /// fine too.)
    ///
    /// ### Popup routes
    ///
    /// Routes don't have to obscure the entire screen. [PopupRoute]s cover the
    /// screen with a [ModalRoute.barrierColor] that can be only partially opaque to
    /// allow the current screen to show through. Popup routes are "modal" because
    /// they block input to the widgets below.
    ///
    /// There are functions which create and show popup routes. For
    /// example: [showDialog], [showMenu], and [showModalBottomSheet]. These
    /// functions return their pushed route's Future as described above.
    /// Callers can await the returned value to take an action when the
    /// route is popped, or to discover the route's value.
    ///
    /// There are also widgets which create popup routes, like [PopupMenuButton] and
    /// [DropdownButton]. These widgets create internal subclasses of PopupRoute
    /// and use the Navigator's push and pop methods to show and dismiss them.
    ///
    /// ### Custom routes
    ///
    /// You can create your own subclass of one of the widget library route classes
    /// like [PopupRoute], [ModalRoute], or [PageRoute], to control the animated
    /// transition employed to show the route, the color and behavior of the route's
    /// modal barrier, and other aspects of the route.
    ///
    /// The [PageRouteBuilder] class makes it possible to define a custom route
    /// in terms of callbacks. Here's an example that rotates and fades its child
    /// when the route appears or disappears. This route does not obscure the entire
    /// screen because it specifies `opaque: false`, just as a popup route does.
    ///
    /// ```dart
    /// Navigator.push(context, PageRouteBuilder(
    ///   opaque: false,
    ///   pageBuilder: (BuildContext context, _, __) {
    ///     return Center(child: Text('My PageRoute'));
    ///   },
    ///   transitionsBuilder: (___, Animation<double> animation, ____, Widget child) {
    ///     return FadeTransition(
    ///       opacity: animation,
    ///       child: RotationTransition(
    ///         turns: Tween<double>(begin: 0.5, end: 1.0).animate(animation),
    ///         child: child,
    ///       ),
    ///     );
    ///   }
    /// ));
    /// ```
    ///
    /// The page route is built in two parts, the "page" and the
    /// "transitions". The page becomes a descendant of the child passed to
    /// the `transitionsBuilder` function. Typically the page is only built once,
    /// because it doesn't depend on its animation parameters (elided with `_`
    /// and `__` in this example). The transition is built on every frame
    /// for its duration.
    ///
    /// ### Nesting Navigators
    ///
    /// An app can use more than one [Navigator]. Nesting one [Navigator] below
    /// another [Navigator] can be used to create an "inner journey" such as tabbed
    /// navigation, user registration, store checkout, or other independent journeys
    /// that represent a subsection of your overall application.
    ///
    /// #### Example
    ///
    /// It is standard practice for iOS apps to use tabbed navigation where each
    /// tab maintains its own navigation history. Therefore, each tab has its own
    /// [Navigator], creating a kind of "parallel navigation."
    ///
    /// In addition to the parallel navigation of the tabs, it is still possible to
    /// launch full-screen pages that completely cover the tabs. For example: an
    /// on-boarding flow, or an alert dialog. Therefore, there must exist a "root"
    /// [Navigator] that sits above the tab navigation. As a result, each of the
    /// tab's [Navigator]s are actually nested [Navigator]s sitting below a single
    /// root [Navigator].
    ///
    /// In practice, the nested [Navigator]s for tabbed navigation sit in the
    /// [WidgetApp] and [CupertinoTabView] widgets and do not need to be explicitly
    /// created or managed.
    ///
    /// {@tool sample --template=freeform}
    /// The following example demonstrates how a nested [Navigator] can be used to
    /// present a standalone user registration journey.
    ///
    /// Even though this example uses two [Navigator]s to demonstrate nested
    /// [Navigator]s, a similar result is possible using only a single [Navigator].
    ///
    /// Run this example with `flutter run --route=/signup` to start it with
    /// the signup flow instead of on the home page.
    ///
    /// ```dart imports
    /// import 'package:flutter/material.dart';
    /// ```
    ///
    /// ```dart main
    /// void main() => runApp(MyApp());
    /// ```
    ///
    /// ```dart
    /// class MyApp extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return MaterialApp(
    ///       title: 'Flutter Code Sample for Navigator',
    ///       // MaterialApp contains our top-level Navigator
    ///       initialRoute: '/',
    ///       routes: {
    ///         '/': (BuildContext context) => HomePage(),
    ///         '/signup': (BuildContext context) => SignUpPage(),
    ///       },
    ///     );
    ///   }
    /// }
    ///
    /// class HomePage extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return DefaultTextStyle(
    ///       style: Theme.of(context).textTheme.headline4,
    ///       child: Container(
    ///         color: Colors.white,
    ///         alignment: Alignment.center,
    ///         child: Text('Home Page'),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// class CollectPersonalInfoPage extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return DefaultTextStyle(
    ///       style: Theme.of(context).textTheme.headline4,
    ///       child: GestureDetector(
    ///         onTap: () {
    ///           // This moves from the personal info page to the credentials page,
    ///           // replacing this page with that one.
    ///           Navigator.of(context)
    ///             .pushReplacementNamed('signup/choose_credentials');
    ///         },
    ///         child: Container(
    ///           color: Colors.lightBlue,
    ///           alignment: Alignment.center,
    ///           child: Text('Collect Personal Info Page'),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// class ChooseCredentialsPage extends StatelessWidget {
    ///   const ChooseCredentialsPage({
    ///     this.onSignupComplete,
    ///   });
    ///
    ///   final VoidCallback onSignupComplete;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return GestureDetector(
    ///       onTap: onSignupComplete,
    ///       child: DefaultTextStyle(
    ///         style: Theme.of(context).textTheme.headline4,
    ///         child: Container(
    ///           color: Colors.pinkAccent,
    ///           alignment: Alignment.center,
    ///           child: Text('Choose Credentials Page'),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// class SignUpPage extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     // SignUpPage builds its own Navigator which ends up being a nested
    ///     // Navigator in our app.
    ///     return Navigator(
    ///       initialRoute: 'signup/personal_info',
    ///       onGenerateRoute: (RouteSettings settings) {
    ///         WidgetBuilder builder;
    ///         switch (settings.name) {
    ///           case 'signup/personal_info':
    ///           // Assume CollectPersonalInfoPage collects personal info and then
    ///           // navigates to 'signup/choose_credentials'.
    ///             builder = (BuildContext _) => CollectPersonalInfoPage();
    ///             break;
    ///           case 'signup/choose_credentials':
    ///           // Assume ChooseCredentialsPage collects new credentials and then
    ///           // invokes 'onSignupComplete()'.
    ///             builder = (BuildContext _) => ChooseCredentialsPage(
    ///               onSignupComplete: () {
    ///                 // Referencing Navigator.of(context) from here refers to the
    ///                 // top level Navigator because SignUpPage is above the
    ///                 // nested Navigator that it created. Therefore, this pop()
    ///                 // will pop the entire "sign up" journey and return to the
    ///                 // "/" route, AKA HomePage.
    ///                 Navigator.of(context).pop();
    ///               },
    ///             );
    ///             break;
    ///           default:
    ///             throw Exception('Invalid route: ${settings.name}');
    ///         }
    ///         return MaterialPageRoute(builder: builder, settings: settings);
    ///       },
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// [Navigator.of] operates on the nearest ancestor [Navigator] from the given
    /// [BuildContext]. Be sure to provide a [BuildContext] below the intended
    /// [Navigator], especially in large [build] methods where nested [Navigator]s
    /// are created. The [Builder] widget can be used to access a [BuildContext] at
    /// a desired location in the widget subtree.
    /// </Summary>
    public class Navigator : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Navigator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Navigator.Page<object>> pages = default(List<FlutterSDK.Widgets.Navigator.Page<object>>), FlutterSDK.Widgets.Navigator.PopPageCallback onPopPage = default(FlutterSDK.Widgets.Navigator.PopPageCallback), string initialRoute = default(string), FlutterSDK.Widgets.Navigator.RouteListFactory onGenerateInitialRoutes = default(FlutterSDK.Widgets.Navigator.RouteListFactory), FlutterSDK.Widgets.Navigator.RouteFactory onGenerateRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), FlutterSDK.Widgets.Navigator.RouteFactory onUnknownRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), FlutterSDK.Widgets.Navigator.TransitionDelegate<object> transitionDelegate = default(FlutterSDK.Widgets.Navigator.TransitionDelegate<object>), List<FlutterSDK.Widgets.Navigator.NavigatorObserver> observers = default(List<FlutterSDK.Widgets.Navigator.NavigatorObserver>))
        : base(key: key)
        {
            this.Pages = pages;
            this.OnPopPage = onPopPage;
            this.InitialRoute = initialRoute;
            this.OnGenerateInitialRoutes = onGenerateInitialRoutes;
            this.OnGenerateRoute = onGenerateRoute;
            this.OnUnknownRoute = onUnknownRoute;
            this.TransitionDelegate = transitionDelegate;
            this.Observers = observers;
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Navigator.Page<object>> Pages { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.PopPageCallback OnPopPage { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.TransitionDelegate<object> TransitionDelegate { get; set; }
        public virtual string InitialRoute { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
        public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> Observers { get; set; }
        public virtual string DefaultRouteName { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteListFactory OnGenerateInitialRoutes { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Push a named route onto the navigator that most tightly encloses the given
        /// context.
        ///
        /// {@template flutter.widgets.navigator.pushNamed}
        /// The route name will be passed to that navigator's [onGenerateRoute]
        /// callback. The returned route will be pushed into the navigator.
        ///
        /// The new route and the previous route (if any) are notified (see
        /// [Route.didPush] and [Route.didChangeNext]). If the [Navigator] has any
        /// [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didPush]).
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the route.
        ///
        /// To use [pushNamed], an [onGenerateRoute] callback must be provided,
        /// {@endtemplate}
        ///
        /// {@template flutter.widgets.navigator.pushNamed.arguments}
        /// The provided `arguments` are passed to the pushed route via
        /// [RouteSettings.arguments]. Any object can be passed as `arguments` (e.g. a
        /// [String], [int], or an instance of a custom `MyRouteArguments` class).
        /// Often, a [Map] is used to pass key-value pairs.
        ///
        /// The `arguments` may be used in [Navigator.onGenerateRoute] or
        /// [Navigator.onUnknownRoute] to construct the route.
        /// {@endtemplate}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _didPushButton() {
        ///   Navigator.pushNamed(context, '/settings');
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        ///
        /// The following example shows how to pass additional `arguments` to the
        /// route:
        ///
        /// ```dart
        /// void _showBerlinWeather() {
        ///   Navigator.pushNamed(
        ///     context,
        ///     '/weather',
        ///     arguments: <String, String>{
        ///       'city': 'Berlin',
        ///       'country': 'Germany',
        ///     },
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        ///
        /// The following example shows how to pass a custom Object to the route:
        ///
        /// ```dart
        /// class WeatherRouteArguments {
        ///   WeatherRouteArguments({ this.city, this.country });
        ///   final String city;
        ///   final String country;
        ///
        ///   bool get isGermanCapital {
        ///     return country == 'Germany' && city == 'Berlin';
        ///   }
        /// }
        ///
        /// void _showWeather() {
        ///   Navigator.pushNamed(
        ///     context,
        ///     '/weather',
        ///     arguments: WeatherRouteArguments(city: 'Berlin', country: 'Germany'),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushNamed<T>(FlutterSDK.Widgets.Framework.BuildContext context, string routeName, @Object arguments = default(@Object))
        {
            return NavigatorDefaultClass.Navigator.Of(context).PushNamed(routeName, arguments: arguments);
        }




        /// <Summary>
        /// Replace the current route of the navigator that most tightly encloses the
        /// given context by pushing the route named [routeName] and then disposing
        /// the previous route once the new route has finished animating in.
        ///
        /// {@template flutter.widgets.navigator.pushReplacementNamed}
        /// If non-null, `result` will be used as the result of the route that is
        /// removed; the future that had been returned from pushing that old route
        /// will complete with `result`. Routes such as dialogs or popup menus
        /// typically use this mechanism to return the value selected by the user to
        /// the widget that created their route. The type of `result`, if provided,
        /// must match the type argument of the class of the old route (`TO`).
        ///
        /// The route name will be passed to the navigator's [onGenerateRoute]
        /// callback. The returned route will be pushed into the navigator.
        ///
        /// The new route and the route below the removed route are notified (see
        /// [Route.didPush] and [Route.didChangeNext]). If the [Navigator] has any
        /// [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didReplace]). The removed route is notified once the
        /// new route has finished animating (see [Route.didComplete]). The removed
        /// route's exit animation is not run (see [popAndPushNamed] for a variant
        /// that does animated the removed route).
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the new route,
        /// and `TO` is the type of the return value of the old route.
        ///
        /// To use [pushReplacementNamed], an [onGenerateRoute] callback must be
        /// provided.
        /// {@endtemplate}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _switchToBrightness() {
        ///   Navigator.pushReplacementNamed(context, '/settings/brightness');
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushReplacementNamed<T, TO>(FlutterSDK.Widgets.Framework.BuildContext context, string routeName, TO result = default(TO), @Object arguments = default(@Object))
        {
            return NavigatorDefaultClass.Navigator.Of(context).PushReplacementNamed(routeName, arguments: arguments, result: result);
        }




        /// <Summary>
        /// Pop the current route off the navigator that most tightly encloses the
        /// given context and push a named route in its place.
        ///
        /// {@template flutter.widgets.navigator.popAndPushNamed}
        /// The popping of the previous route is handled as per [pop].
        ///
        /// The new route's name will be passed to the navigator's [onGenerateRoute]
        /// callback. The returned route will be pushed into the navigator.
        ///
        /// The new route, the old route, and the route below the old route (if any)
        /// are all notified (see [Route.didPop], [Route.didComplete],
        /// [Route.didPopNext], [Route.didPush], and [Route.didChangeNext]). If the
        /// [Navigator] has any [Navigator.observers], they will be notified as well
        /// (see [NavigatorObserver.didPop] and [NavigatorObservers.didPush]). The
        /// animations for the pop and the push are performed simultaneously, so the
        /// route below may be briefly visible even if both the old route and the new
        /// route are opaque (see [TransitionRoute.opaque]).
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the new route,
        /// and `TO` is the return value type of the old route.
        ///
        /// To use [popAndPushNamed], an [onGenerateRoute] callback must be provided.
        ///
        /// {@endtemplate}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _selectAccessibility() {
        ///   Navigator.popAndPushNamed(context, '/settings/accessibility');
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PopAndPushNamed<T, TO>(FlutterSDK.Widgets.Framework.BuildContext context, string routeName, TO result = default(TO), @Object arguments = default(@Object))
        {
            return NavigatorDefaultClass.Navigator.Of(context).PopAndPushNamed(routeName, arguments: arguments, result: result);
        }




        /// <Summary>
        /// Push the route with the given name onto the navigator that most tightly
        /// encloses the given context, and then remove all the previous routes until
        /// the `predicate` returns true.
        ///
        /// {@template flutter.widgets.navigator.pushNamedAndRemoveUntil}
        /// The predicate may be applied to the same route more than once if
        /// [Route.willHandlePopInternally] is true.
        ///
        /// To remove routes until a route with a certain name, use the
        /// [RoutePredicate] returned from [ModalRoute.withName].
        ///
        /// To remove all the routes below the pushed route, use a [RoutePredicate]
        /// that always returns false (e.g. `(Route<dynamic> route) => false`).
        ///
        /// The removed routes are removed without being completed, so this method
        /// does not take a return value argument.
        ///
        /// The new route's name (`routeName`) will be passed to the navigator's
        /// [onGenerateRoute] callback. The returned route will be pushed into the
        /// navigator.
        ///
        /// The new route and the route below the bottommost removed route (which
        /// becomes the route below the new route) are notified (see [Route.didPush]
        /// and [Route.didChangeNext]). If the [Navigator] has any
        /// [Navigator.observers], they will be notified as well (see
        /// [NavigatorObservers.didPush] and [NavigatorObservers.didRemove]). The
        /// removed routes are disposed, without being notified, once the new route
        /// has finished animating. The futures that had been returned from pushing
        /// those routes will not complete.
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the new route.
        ///
        /// To use [pushNamedAndRemoveUntil], an [onGenerateRoute] callback must be
        /// provided.
        /// {@endtemplate}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _resetToCalendar() {
        ///   Navigator.pushNamedAndRemoveUntil(context, '/calendar', ModalRoute.withName('/'));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushNamedAndRemoveUntil<T>(FlutterSDK.Widgets.Framework.BuildContext context, string newRouteName, FlutterSDK.Widgets.Navigator.RoutePredicate predicate, @Object arguments = default(@Object))
        {
            return NavigatorDefaultClass.Navigator.Of(context).PushNamedAndRemoveUntil(newRouteName, predicate, arguments: arguments);
        }




        /// <Summary>
        /// Push the given route onto the navigator that most tightly encloses the
        /// given context.
        ///
        /// {@template flutter.widgets.navigator.push}
        /// The new route and the previous route (if any) are notified (see
        /// [Route.didPush] and [Route.didChangeNext]). If the [Navigator] has any
        /// [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didPush]).
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the route.
        /// {@endtemplate}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _openMyPage() {
        ///   Navigator.push(context, MaterialPageRoute(builder: (BuildContext context) => MyPage()));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> Push<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<T> route)
        {
            return NavigatorDefaultClass.Navigator.Of(context).Push(route);
        }




        /// <Summary>
        /// Replace the current route of the navigator that most tightly encloses the
        /// given context by pushing the given route and then disposing the previous
        /// route once the new route has finished animating in.
        ///
        /// {@template flutter.widgets.navigator.pushReplacement}
        /// If non-null, `result` will be used as the result of the route that is
        /// removed; the future that had been returned from pushing that old route will
        /// complete with `result`. Routes such as dialogs or popup menus typically
        /// use this mechanism to return the value selected by the user to the widget
        /// that created their route. The type of `result`, if provided, must match
        /// the type argument of the class of the old route (`TO`).
        ///
        /// The new route and the route below the removed route are notified (see
        /// [Route.didPush] and [Route.didChangeNext]). If the [Navigator] has any
        /// [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didReplace]). The removed route is notified once the
        /// new route has finished animating (see [Route.didComplete]).
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the new route,
        /// and `TO` is the type of the return value of the old route.
        /// {@endtemplate}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _completeLogin() {
        ///   Navigator.pushReplacement(
        ///       context, MaterialPageRoute(builder: (BuildContext context) => MyHomePage()));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushReplacement<T, TO>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<T> newRoute, TO result = default(TO))
        {
            return NavigatorDefaultClass.Navigator.Of(context).PushReplacement(newRoute, result: result);
        }




        /// <Summary>
        /// Push the given route onto the navigator that most tightly encloses the
        /// given context, and then remove all the previous routes until the
        /// `predicate` returns true.
        ///
        /// {@template flutter.widgets.navigator.pushAndRemoveUntil}
        /// The predicate may be applied to the same route more than once if
        /// [Route.willHandlePopInternally] is true.
        ///
        /// To remove routes until a route with a certain name, use the
        /// [RoutePredicate] returned from [ModalRoute.withName].
        ///
        /// To remove all the routes below the pushed route, use a [RoutePredicate]
        /// that always returns false (e.g. `(Route<dynamic> route) => false`).
        ///
        /// The removed routes are removed without being completed, so this method
        /// does not take a return value argument.
        ///
        /// The newly pushed route and its preceding route are notified for
        /// [Route.didPush]. After removal, the new route and its new preceding route,
        /// (the route below the bottommost removed route) are notified through
        /// [Route.didChangeNext]). If the [Navigator] has any [Navigator.observers],
        /// they will be notified as well (see [NavigatorObservers.didPush] and
        /// [NavigatorObservers.didRemove]). The removed routes are disposed of and
        /// notified, once the new route has finished animating. The futures that had
        /// been returned from pushing those routes will not complete.
        ///
        /// Ongoing gestures within the current route are canceled when a new route is
        /// pushed.
        ///
        /// Returns a [Future] that completes to the `result` value passed to [pop]
        /// when the pushed route is popped off the navigator.
        ///
        /// The `T` type argument is the type of the return value of the new route.
        /// {@endtemplate}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _finishAccountCreation() {
        ///   Navigator.pushAndRemoveUntil(
        ///     context,
        ///     MaterialPageRoute(builder: (BuildContext context) => MyHomePage()),
        ///     ModalRoute.withName('/'),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushAndRemoveUntil<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<T> newRoute, FlutterSDK.Widgets.Navigator.RoutePredicate predicate)
        {
            return NavigatorDefaultClass.Navigator.Of(context).PushAndRemoveUntil(newRoute, predicate);
        }




        /// <Summary>
        /// Replaces a route on the navigator that most tightly encloses the given
        /// context with a new route.
        ///
        /// {@template flutter.widgets.navigator.replace}
        /// The old route must not be currently visible, as this method skips the
        /// animations and therefore the removal would be jarring if it was visible.
        /// To replace the top-most route, consider [pushReplacement] instead, which
        /// _does_ animate the new route, and delays removing the old route until the
        /// new route has finished animating.
        ///
        /// The removed route is removed without being completed, so this method does
        /// not take a return value argument.
        ///
        /// The new route, the route below the new route (if any), and the route above
        /// the new route, are all notified (see [Route.didReplace],
        /// [Route.didChangeNext], and [Route.didChangePrevious]). If the [Navigator]
        /// has any [Navigator.observers], they will be notified as well (see
        /// [NavigatorObservers.didReplace]). The removed route is disposed without
        /// being notified. The future that had been returned from pushing that routes
        /// will not complete.
        ///
        /// This can be useful in combination with [removeRouteBelow] when building a
        /// non-linear user experience.
        ///
        /// The `T` type argument is the type of the return value of the new route.
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [replaceRouteBelow], which is the same but identifies the route to be
        ///    removed by reference to the route above it, rather than directly.
        /// </Summary>
        public virtual void Replace<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>))
        {
            return NavigatorDefaultClass.Navigator.Of(context).Replace(oldRoute: oldRoute, newRoute: newRoute);
        }




        /// <Summary>
        /// Replaces a route on the navigator that most tightly encloses the given
        /// context with a new route. The route to be replaced is the one below the
        /// given `anchorRoute`.
        ///
        /// {@template flutter.widgets.navigator.replaceRouteBelow}
        /// The old route must not be current visible, as this method skips the
        /// animations and therefore the removal would be jarring if it was visible.
        /// To replace the top-most route, consider [pushReplacement] instead, which
        /// _does_ animate the new route, and delays removing the old route until the
        /// new route has finished animating.
        ///
        /// The removed route is removed without being completed, so this method does
        /// not take a return value argument.
        ///
        /// The new route, the route below the new route (if any), and the route above
        /// the new route, are all notified (see [Route.didReplace],
        /// [Route.didChangeNext], and [Route.didChangePrevious]). If the [Navigator]
        /// has any [Navigator.observers], they will be notified as well (see
        /// [NavigatorObservers.didReplace]). The removed route is disposed without
        /// being notified. The future that had been returned from pushing that routes
        /// will not complete.
        ///
        /// The `T` type argument is the type of the return value of the new route.
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [replace], which is the same but identifies the route to be removed
        ///    directly.
        /// </Summary>
        public virtual void ReplaceRouteBelow<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> anchorRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>))
        {
            return NavigatorDefaultClass.Navigator.Of(context).ReplaceRouteBelow(anchorRoute: anchorRoute, newRoute: newRoute);
        }




        /// <Summary>
        /// Whether the navigator that most tightly encloses the given context can be
        /// popped.
        ///
        /// {@template flutter.widgets.navigator.canPop}
        /// The initial route cannot be popped off the navigator, which implies that
        /// this function returns true only if popping the navigator would not remove
        /// the initial route.
        ///
        /// If there is no [Navigator] in scope, returns false.
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [Route.isFirst], which returns true for routes for which [canPop]
        ///    returns false.
        /// </Summary>
        public virtual bool CanPop(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            NavigatorState navigator = NavigatorDefaultClass.Navigator.Of(context, nullOk: true);
            return navigator != null && navigator.CanPop();
        }




        /// <Summary>
        /// Consults the current route's [Route.willPop] method, and acts accordingly,
        /// potentially popping the route as a result; returns whether the pop request
        /// should be considered handled.
        ///
        /// {@template flutter.widgets.navigator.maybePop}
        /// If [Route.willPop] returns [RoutePopDisposition.pop], then the [pop]
        /// method is called, and this method returns true, indicating that it handled
        /// the pop request.
        ///
        /// If [Route.willPop] returns [RoutePopDisposition.doNotPop], then this
        /// method returns true, but does not do anything beyond that.
        ///
        /// If [Route.willPop] returns [RoutePopDisposition.bubble], then this method
        /// returns false, and the caller is responsible for sending the request to
        /// the containing scope (e.g. by closing the application).
        ///
        /// This method is typically called for a user-initiated [pop]. For example on
        /// Android it's called by the binding for the system's back button.
        ///
        /// The `T` type argument is the type of the return value of the current
        /// route. (Typically this isn't known; consider specifying `dynamic` or
        /// `Null`.)
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [Form], which provides an `onWillPop` callback that enables the form
        ///    to veto a [pop] initiated by the app's back button.
        ///  * [ModalRoute], which provides a `scopedWillPopCallback` that can be used
        ///    to define the route's `willPop` method.
        /// </Summary>
        public virtual Future<bool> MaybePop<T>(FlutterSDK.Widgets.Framework.BuildContext context, T result = default(T))
        {
            return NavigatorDefaultClass.Navigator.Of(context).MaybePop(result);
        }




        /// <Summary>
        /// Pop the top-most route off the navigator that most tightly encloses the
        /// given context.
        ///
        /// {@template flutter.widgets.navigator.pop}
        /// The current route's [Route.didPop] method is called first. If that method
        /// returns false, then the route remains in the [Navigator]'s history (the
        /// route is expected to have popped some internal state; see e.g.
        /// [LocalHistoryRoute]). Otherwise, the rest of this description applies.
        ///
        /// If non-null, `result` will be used as the result of the route that is
        /// popped; the future that had been returned from pushing the popped route
        /// will complete with `result`. Routes such as dialogs or popup menus
        /// typically use this mechanism to return the value selected by the user to
        /// the widget that created their route. The type of `result`, if provided,
        /// must match the type argument of the class of the popped route (`T`).
        ///
        /// The popped route and the route below it are notified (see [Route.didPop],
        /// [Route.didComplete], and [Route.didPopNext]). If the [Navigator] has any
        /// [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didPop]).
        ///
        /// The `T` type argument is the type of the return value of the popped route.
        ///
        /// The type of `result`, if provided, must match the type argument of the
        /// class of the popped route (`T`).
        /// {@endtemplate}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage for closing a route is as follows:
        ///
        /// ```dart
        /// void _close() {
        ///   Navigator.pop(context);
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// A dialog box might be closed with a result:
        ///
        /// ```dart
        /// void _accept() {
        ///   Navigator.pop(context, true); // dialog returns true
        /// }
        /// ```
        /// </Summary>
        public virtual void Pop<T>(FlutterSDK.Widgets.Framework.BuildContext context, T result = default(T))
        {
            NavigatorDefaultClass.Navigator.Of(context).Pop(result);
        }




        /// <Summary>
        /// Calls [pop] repeatedly on the navigator that most tightly encloses the
        /// given context until the predicate returns true.
        ///
        /// {@template flutter.widgets.navigator.popUntil}
        /// The predicate may be applied to the same route more than once if
        /// [Route.willHandlePopInternally] is true.
        ///
        /// To pop until a route with a certain name, use the [RoutePredicate]
        /// returned from [ModalRoute.withName].
        ///
        /// The routes are closed with null as their `return` value.
        ///
        /// See [pop] for more details of the semantics of popping a route.
        /// {@endtemplate}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _logout() {
        ///   Navigator.popUntil(context, ModalRoute.withName('/login'));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual void PopUntil(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.RoutePredicate predicate)
        {
            NavigatorDefaultClass.Navigator.Of(context).PopUntil(predicate);
        }




        /// <Summary>
        /// Immediately remove `route` from the navigator that most tightly encloses
        /// the given context, and [Route.dispose] it.
        ///
        /// {@template flutter.widgets.navigator.removeRoute}
        /// The removed route is removed without being completed, so this method does
        /// not take a return value argument. No animations are run as a result of
        /// this method call.
        ///
        /// The routes below and above the removed route are notified (see
        /// [Route.didChangeNext] and [Route.didChangePrevious]). If the [Navigator]
        /// has any [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didRemove]). The removed route is disposed without
        /// being notified. The future that had been returned from pushing that routes
        /// will not complete.
        ///
        /// The given `route` must be in the history; this method will throw an
        /// exception if it is not.
        ///
        /// Ongoing gestures within the current route are canceled.
        /// {@endtemplate}
        ///
        /// This method is used, for example, to instantly dismiss dropdown menus that
        /// are up when the screen's orientation changes.
        /// </Summary>
        public virtual void RemoveRoute(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> route)
        {
            return NavigatorDefaultClass.Navigator.Of(context).RemoveRoute(route);
        }




        /// <Summary>
        /// Immediately remove a route from the navigator that most tightly encloses
        /// the given context, and [Route.dispose] it. The route to be removed is the
        /// one below the given `anchorRoute`.
        ///
        /// {@template flutter.widgets.navigator.removeRouteBelow}
        /// The removed route is removed without being completed, so this method does
        /// not take a return value argument. No animations are run as a result of
        /// this method call.
        ///
        /// The routes below and above the removed route are notified (see
        /// [Route.didChangeNext] and [Route.didChangePrevious]). If the [Navigator]
        /// has any [Navigator.observers], they will be notified as well (see
        /// [NavigatorObserver.didRemove]). The removed route is disposed without
        /// being notified. The future that had been returned from pushing that routes
        /// will not complete.
        ///
        /// The given `anchorRoute` must be in the history and must have a route below
        /// it; this method will throw an exception if it is not or does not.
        ///
        /// Ongoing gestures within the current route are canceled.
        /// {@endtemplate}
        /// </Summary>
        public virtual void RemoveRouteBelow(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> anchorRoute)
        {
            return NavigatorDefaultClass.Navigator.Of(context).RemoveRouteBelow(anchorRoute);
        }




        /// <Summary>
        /// The state from the closest instance of this class that encloses the given context.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// Navigator.of(context)
        ///   ..pop()
        ///   ..pop()
        ///   ..pushNamed('/settings');
        /// ```
        ///
        /// If `rootNavigator` is set to true, the state from the furthest instance of
        /// this class is given instead. Useful for pushing contents above all subsequent
        /// instances of [Navigator].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Of(FlutterSDK.Widgets.Framework.BuildContext context, bool rootNavigator = false, bool nullOk = false)
        {
            NavigatorState navigator = rootNavigator ? context.FindRootAncestorStateOfType() : context.FindAncestorStateOfType();

            return navigator;
        }




        /// <Summary>
        /// Turn a route name into a set of [Route] objects.
        ///
        /// This is the default value of [onGenerateInitialRoutes], which is used if
        /// [initialRoute] is not null.
        ///
        /// If this string contains any `/` characters, then the string is split on
        /// those characters and substrings from the start of the string up to each
        /// such character are, in turn, used as routes to push.
        ///
        /// For example, if the route `/stocks/HOOLI` was used as the [initialRoute],
        /// then the [Navigator] would push the following routes on startup: `/`,
        /// `/stocks`, `/stocks/HOOLI`. This enables deep linking while allowing the
        /// application to maintain a predictable route history.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Navigator.Route<object>> DefaultGenerateInitialRoutes(FlutterSDK.Widgets.Navigator.NavigatorState navigator, string initialRouteName)
        {
            List<Route<object>> result = new List<Route<object>>() { };
            if (initialRouteName.StartsWith('/') && initialRouteName.Length > 1)
            {
                initialRouteName = initialRouteName.Substring(1);

                List<string> debugRouteNames = default(List<string>);

                result.Add(navigator._RouteNamed(NavigatorDefaultClass.Navigator.DefaultRouteName, arguments: null, allowNull: true));
                List<string> routeParts = initialRouteName.Split('/').ToList();
                if (initialRouteName.IsNotEmpty)
                {
                    string routeName = "";
                    foreach (string part in routeParts)
                    {
                        routeName += $"'/{part}'";

                        result.Add(navigator._RouteNamed(routeName, arguments: null, allowNull: true));
                    }

                }

                if (result.Last() == null)
                {

                    result.Clear();
                }

            }
            else if (initialRouteName != NavigatorDefaultClass.Navigator.DefaultRouteName)
            {
                result.Add(navigator._RouteNamed(initialRouteName, arguments: null, allowNull: true));
            }

            result.RemoveWhere((Route<object> route) => =>route == null);
            if (result.IsEmpty()) result.Add(navigator._RouteNamed(NavigatorDefaultClass.Navigator.DefaultRouteName, arguments: null));
            return result;
        }




        public new FlutterSDK.Widgets.Navigator.NavigatorState CreateState() => new NavigatorState();


        #endregion
    }


    public class _RouteEntry : FlutterSDK.Widgets.Navigator.RouteTransitionRecord
    {
        #region constructors
        public _RouteEntry(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator._RouteLifecycle initialState = default(FlutterSDK.Widgets.Navigator._RouteLifecycle))
        : base()
        {
            this.Route = route;
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Navigator.Route<object> Route { get; set; }
        public virtual FlutterSDK.Widgets.Navigator._RouteLifecycle CurrentState { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.Route<object> LastAnnouncedPreviousRoute { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.Route<object> LastAnnouncedPoppedNextRoute { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.Route<object> LastAnnouncedNextRoute { get; set; }
        public virtual bool DoingPop { get; set; }
        internal virtual bool _ReportRemovalToObserver { get; set; }
        public virtual FlutterSDK.Widgets.Navigator._RouteEntryPredicate IsPresentPredicate { get; set; }
        public virtual FlutterSDK.Widgets.Navigator._RouteEntryPredicate SuitableForTransitionAnimationPredicate { get; set; }
        public virtual FlutterSDK.Widgets.Navigator._RouteEntryPredicate WillBePresentPredicate { get; set; }
        public virtual bool HasPage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool WillBePresent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsPresent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SuitableForAnnouncement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SuitableForTransitionAnimation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEntering { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual bool CanUpdateFrom(FlutterSDK.Widgets.Navigator.Page<object> page)
        {
            if (CurrentState.Index > _RouteLifecycle.Idle.Index) return false;
            if (!HasPage) return false;
            Page<object> routePage = Route.Settings as Page<object>;
            return page.CanUpdate(routePage);
        }




        public virtual void HandleAdd(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState))
        {




            Route._Navigator = navigator;
            Route.Install();

            CurrentState = _RouteLifecycle.Adding;
        }




        public virtual void HandlePush(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), bool isNewFirst = default(bool), FlutterSDK.Widgets.Navigator.Route<object> previous = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>))
        {




            _RouteLifecycle previousState = CurrentState;
            Route._Navigator = navigator;
            Route.Install();

            if (CurrentState == _RouteLifecycle.Push || CurrentState == _RouteLifecycle.PushReplace)
            {
                TickerFuture routeFuture = Route.DidPush();
                CurrentState = _RouteLifecycle.Pushing;
                routeFuture.WhenCompleteOrCancel(() =>
                {
                    if (CurrentState == _RouteLifecycle.Pushing)
                    {
                        CurrentState = _RouteLifecycle.Idle;


                        navigator._FlushHistoryUpdates();

                    }

                }
                );
            }
            else
            {

                Route.DidReplace(previous);
                CurrentState = _RouteLifecycle.Idle;
            }

            if (isNewFirst)
            {
                Route.DidChangeNext(null);
            }

            if (previousState == _RouteLifecycle.Replace || previousState == _RouteLifecycle.PushReplace)
            {
                foreach (NavigatorObserver observer in navigator.Widget.Observers) observer.DidReplace(newRoute: Route, oldRoute: previous);
            }
            else
            {

                foreach (NavigatorObserver observer in navigator.Widget.Observers) observer.DidPush(Route, previousPresent);
            }

        }




        public virtual void HandleDidPopNext(FlutterSDK.Widgets.Navigator.Route<object> poppedRoute)
        {
            Route.DidPopNext(poppedRoute);
            LastAnnouncedPoppedNextRoute = poppedRoute;
        }




        public virtual void HandlePop(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>))
        {



            CurrentState = _RouteLifecycle.Popping;
            foreach (NavigatorObserver observer in navigator.Widget.Observers) observer.DidPop(Route, previousPresent);
        }




        public virtual void HandleRemoval(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>))
        {



            CurrentState = _RouteLifecycle.Removing;
            if (_ReportRemovalToObserver)
            {
                foreach (NavigatorObserver observer in navigator.Widget.Observers) observer.DidRemove(Route, previousPresent);
            }

        }




        public virtual void DidAdd(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), bool isNewFirst = default(bool), FlutterSDK.Widgets.Navigator.Route<object> previous = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>))
        {
            Route.DidAdd();
            CurrentState = _RouteLifecycle.Idle;
            if (isNewFirst)
            {
                Route.DidChangeNext(null);
            }

            foreach (NavigatorObserver observer in navigator.Widget.Observers) observer.DidPush(Route, previousPresent);
        }




        public virtual void Pop<T>(T result)
        {

            DoingPop = true;
            if (Route.DidPop(result) && DoingPop)
            {
                CurrentState = _RouteLifecycle.Pop;
            }

            DoingPop = false;
        }




        public virtual void Remove(bool isReplaced = false)
        {

            if (CurrentState.Index >= _RouteLifecycle.Remove.Index) return;

            _ReportRemovalToObserver = !isReplaced;
            CurrentState = _RouteLifecycle.Remove;
        }




        public virtual void Complete<T>(T result, bool isReplaced = false)
        {

            if (CurrentState.Index >= _RouteLifecycle.Remove.Index) return;

            _ReportRemovalToObserver = !isReplaced;
            Route.DidComplete(result);

            CurrentState = _RouteLifecycle.Remove;
        }




        public virtual void Finalize()
        {

            CurrentState = _RouteLifecycle.Dispose;
        }




        public virtual void Dispose()
        {

            Route.Dispose();
            CurrentState = _RouteLifecycle.Disposed;
        }




        public virtual bool ShouldAnnounceChangeToNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute)
        {

            return !(nextRoute == null && LastAnnouncedPoppedNextRoute != null && LastAnnouncedPoppedNextRoute == LastAnnouncedNextRoute);
        }




        public virtual FlutterSDK.Widgets.Navigator._RouteEntryPredicate IsRoutePredicate(FlutterSDK.Widgets.Navigator.Route<object> route)
        {
            return (_RouteEntry entry) => =>entry.Route == route;
        }




        public new void MarkForPush()
        {

            CurrentState = _RouteLifecycle.Push;
        }




        public new void MarkForAdd()
        {

            CurrentState = _RouteLifecycle.Add;
        }




        public new void MarkForPop(object result = default(object))
        {

            Pop(result);
            _DebugWaitingForExitDecision = false;
        }




        public new void MarkForComplete(object result = default(object))
        {

            Complete(result);
            _DebugWaitingForExitDecision = false;
        }




        public new void MarkForRemove()
        {

            Remove();
            _DebugWaitingForExitDecision = false;
        }



        #endregion
    }


    /// <Summary>
    /// The state for a [Navigator] widget.
    /// </Summary>
    public class NavigatorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Navigator.Navigator>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public NavigatorState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Overlay.OverlayState> _OverlayKey { get; set; }
        internal virtual List<FlutterSDK.Widgets.Navigator._RouteEntry> _History { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode FocusScopeNode { get; set; }
        internal virtual bool _DebugLocked { get; set; }
        internal virtual string _LastAnnouncedRouteName { get; set; }
        internal virtual bool _DebugUpdatingPage { get; set; }
        internal virtual int _UserGesturesInProgressCount { get; set; }
        public virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> UserGestureInProgressNotifier { get; set; }
        internal virtual HashSet<int> _ActivePointers { get; set; }
        public virtual FlutterSDK.Widgets.Overlay.OverlayState Overlay { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> _AllRouteOverlayEntries { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual int _UserGesturesInProgress { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool UserGestureInProgress { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();

            foreach (NavigatorObserver observer in Widget.Observers)
            {

                observer._Navigator = this;
            }

            string initialRoute = Widget.InitialRoute;
            if (Widget.Pages.IsNotEmpty)
            {
                _History.AddAll(Widget.Pages.Map((Page<object> page) => =>new _RouteEntry(page.CreateRoute(Context), initialState: _RouteLifecycle.Add)));
            }
            else
            {
                initialRoute = initialRoute ?? NavigatorDefaultClass.Navigator.DefaultRouteName;
            }

            if (initialRoute != null)
            {
                _History.AddAll(Widget.OnGenerateInitialRoutes(this, Widget.InitialRoute ?? NavigatorDefaultClass.Navigator.DefaultRouteName).Map((Route<object> route) => =>new _RouteEntry(route, initialState: _RouteLifecycle.Add)));
            }



            _FlushHistoryUpdates();

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Navigator.Navigator oldWidget)
        {
            base.DidUpdateWidget(oldWidget);

            if (oldWidget.Observers != Widget.Observers)
            {
                foreach (NavigatorObserver observer in oldWidget.Observers) observer._Navigator = null;
                foreach (NavigatorObserver observer in Widget.Observers)
                {

                    observer._Navigator = this;
                }

            }

            if (oldWidget.Pages != Widget.Pages)
            {

                _UpdatePages();
            }

            foreach (_RouteEntry entry in _History) entry.Route.ChangedExternalState();
        }




        private void _DebugCheckDuplicatedPageKeys()
        {

        }




        public new void Dispose()
        {


            foreach (NavigatorObserver observer in Widget.Observers) observer._Navigator = null;
            FocusScopeNode.Dispose();
            foreach (_RouteEntry entry in _History) entry.Dispose();
            base.Dispose();

        }




        private void _UpdatePages()
        {

            bool needsExplicitDecision = false;
            int newPagesBottom = 0;
            int oldEntriesBottom = 0;
            int newPagesTop = Widget.Pages.Count - 1;
            int oldEntriesTop = _History.Count - 1;
            List<_RouteEntry> newHistory = new List<_RouteEntry>() { };
            Dictionary<_RouteEntry, List<_RouteEntry>> pageRouteToPagelessRoutes = new Dictionary<_RouteEntry, List<_RouteEntry>> { };
            _RouteEntry previousOldPageRouteEntry = default(_RouteEntry);
            while (oldEntriesBottom <= oldEntriesTop)
            {
                _RouteEntry oldEntry = _History[oldEntriesBottom];

                if (!oldEntry.HasPage)
                {
                    List<_RouteEntry> pagelessRoutes = pageRouteToPagelessRoutes.PutIfAbsent(previousOldPageRouteEntry, () => =>new List<_RouteEntry>() { });
                    pagelessRoutes.Add(oldEntry);
                    oldEntriesBottom += 1;
                    continue;
                }

                if (newPagesBottom > newPagesTop) break;
                Page<object> newPage = Widget.Pages[newPagesBottom];
                if (!oldEntry.CanUpdateFrom(newPage)) break;
                previousOldPageRouteEntry = oldEntry;
                oldEntry.Route._UpdateSettings(newPage);
                newHistory.Add(oldEntry);
                newPagesBottom += 1;
                oldEntriesBottom += 1;
            }

            int pagelessRoutesToSkip = 0;
            while ((oldEntriesBottom <= oldEntriesTop) && (newPagesBottom <= newPagesTop))
            {
                _RouteEntry oldEntry = _History[oldEntriesTop];

                if (!oldEntry.HasPage)
                {
                    pagelessRoutesToSkip += 1;
                    oldEntriesTop -= 1;
                    continue;
                }

                Page<object> newPage = Widget.Pages[newPagesTop];
                if (!oldEntry.CanUpdateFrom(newPage)) break;
                pagelessRoutesToSkip = 0;
                oldEntriesTop -= 1;
                newPagesTop -= 1;
            }

            oldEntriesTop += pagelessRoutesToSkip;
            int oldEntriesBottomToScan = oldEntriesBottom;
            Dictionary<LocalKey, _RouteEntry> pageKeyToOldEntry = new Dictionary<LocalKey, _RouteEntry> { };
            while (oldEntriesBottomToScan <= oldEntriesTop)
            {
                _RouteEntry oldEntry = _History[oldEntriesBottomToScan];
                oldEntriesBottomToScan += 1;

                if (!oldEntry.HasPage) continue;

                Page<object> page = oldEntry.Route.Settings as Page<object>;
                if (page.Key == null) continue;

                pageKeyToOldEntry[page.Key] = oldEntry;
            }

            while (newPagesBottom <= newPagesTop)
            {
                Page<object> nextPage = Widget.Pages[newPagesBottom];
                newPagesBottom += 1;
                if (nextPage.Key == null || !pageKeyToOldEntry.ContainsKey(nextPage.Key) || !pageKeyToOldEntry[nextPage.Key].CanUpdateFrom(nextPage))
                {
                    _RouteEntry newEntry = new _RouteEntry(nextPage.CreateRoute(Context), initialState: _RouteLifecycle.Staging);
                    needsExplicitDecision = true;

                    newHistory.Add(newEntry);
                }
                else
                {
                    _RouteEntry matchingEntry = pageKeyToOldEntry.Remove(nextPage.Key);

                    matchingEntry.Route._UpdateSettings(nextPage);
                    newHistory.Add(matchingEntry);
                }

            }

            Dictionary<RouteTransitionRecord, RouteTransitionRecord> locationToExitingPageRoute = new Dictionary<RouteTransitionRecord, RouteTransitionRecord> { };
            while (oldEntriesBottom <= oldEntriesTop)
            {
                _RouteEntry potentialEntryToRemove = _History[oldEntriesBottom];
                oldEntriesBottom += 1;
                if (!potentialEntryToRemove.HasPage)
                {

                    List<_RouteEntry> pagelessRoutes = pageRouteToPagelessRoutes.PutIfAbsent(previousOldPageRouteEntry, () => =>new List<_RouteEntry>() { });
                    pagelessRoutes.Add(potentialEntryToRemove);

                    continue;
                }

                Page<object> potentialPageToRemove = potentialEntryToRemove.Route.Settings as Page<object>;
                if (potentialPageToRemove.Key == null || pageKeyToOldEntry.ContainsKey(potentialPageToRemove.Key))
                {
                    locationToExitingPageRoute[previousOldPageRouteEntry] = potentialEntryToRemove;

                }

                previousOldPageRouteEntry = potentialEntryToRemove;
            }



            newPagesTop = Widget.Pages.Count - 1;
            oldEntriesTop = _History.Count - 1;

            while ((oldEntriesBottom <= oldEntriesTop) && (newPagesBottom <= newPagesTop))
            {
                _RouteEntry oldEntry = _History[oldEntriesBottom];

                if (!oldEntry.HasPage)
                {

                    List<_RouteEntry> pagelessRoutes = pageRouteToPagelessRoutes.PutIfAbsent(previousOldPageRouteEntry, () => =>new List<_RouteEntry>() { });
                    pagelessRoutes.Add(oldEntry);
                    continue;
                }

                previousOldPageRouteEntry = oldEntry;
                Page<object> newPage = Widget.Pages[newPagesBottom];

                oldEntry.Route._UpdateSettings(newPage);
                newHistory.Add(oldEntry);
                oldEntriesBottom += 1;
                newPagesBottom += 1;
            }

            needsExplicitDecision = needsExplicitDecision || locationToExitingPageRoute.IsNotEmpty;
            Iterable<_RouteEntry> results = newHistory;
            if (needsExplicitDecision)
            {
                results = Widget.TransitionDelegate._Transition(newPageRouteHistory: newHistory, locationToExitingPageRoute: locationToExitingPageRoute, pageRouteToPagelessRoutes: pageRouteToPagelessRoutes).Cast();
            }

            _History = new List<_RouteEntry>() { };
            if (pageRouteToPagelessRoutes.ContainsKey(null))
            {
                _History.AddAll(pageRouteToPagelessRoutes[null]);
            }

            foreach (_RouteEntry result in results)
            {
                _History.Add(result);
                if (pageRouteToPagelessRoutes.ContainsKey(result))
                {
                    _History.AddAll(pageRouteToPagelessRoutes[result]);
                }

            }



            _FlushHistoryUpdates();

        }




        private void _FlushHistoryUpdates(bool rearrangeOverlay = true)
        {

            int index = _History.Count - 1;
            _RouteEntry next = default(_RouteEntry);
            _RouteEntry entry = _History[index];
            _RouteEntry previous = index > 0 ? _History[index - 1] : null;
            bool canRemoveOrAdd = false;
            Route<object> poppedRoute = default(Route<object>);
            bool seenTopActiveRoute = false;
            List<_RouteEntry> toBeDisposed = new List<_RouteEntry>() { };
            while (index >= 0)
            {
                switch (entry.CurrentState)
                {
                    case _RouteLifecycle.Add: entry.HandleAdd(navigator: this); continue;
                    case _RouteLifecycle.Adding:
                        if (canRemoveOrAdd || next == null)
                        {
                            entry.DidAdd(navigator: this, previous: previous?.Route, previousPresent: _GetRouteBefore(index - 1, NavigatorDefaultClass._RouteEntry.IsPresentPredicate)?.Route, isNewFirst: next == null);

                            continue;
                        }
                        break;
                    case _RouteLifecycle.Push:
                    case _RouteLifecycle.PushReplace:
                    case _RouteLifecycle.Replace:
                        entry.HandlePush(navigator: this, previous: previous?.Route, previousPresent: _GetRouteBefore(index - 1, NavigatorDefaultClass._RouteEntry.IsPresentPredicate)?.Route, isNewFirst: next == null); if (entry.CurrentState == _RouteLifecycle.Idle)
                        {
                            continue;
                        }
                        break;
                    case _RouteLifecycle.Pushing: if (!seenTopActiveRoute && poppedRoute != null) entry.HandleDidPopNext(poppedRoute); seenTopActiveRoute = true; break;
                    case _RouteLifecycle.Idle: if (!seenTopActiveRoute && poppedRoute != null) entry.HandleDidPopNext(poppedRoute); seenTopActiveRoute = true; canRemoveOrAdd = true; break;
                    case _RouteLifecycle.Pop:
                        if (!seenTopActiveRoute)
                        {
                            if (poppedRoute != null) entry.HandleDidPopNext(poppedRoute);
                            poppedRoute = entry.Route;
                        }
                        entry.HandlePop(navigator: this, previousPresent: _GetRouteBefore(index, NavigatorDefaultClass._RouteEntry.WillBePresentPredicate)?.Route); canRemoveOrAdd = true; break;
                    case _RouteLifecycle.Popping: break;
                    case _RouteLifecycle.Remove:
                        if (!seenTopActiveRoute)
                        {
                            if (poppedRoute != null) entry.Route.DidPopNext(poppedRoute);
                            poppedRoute = null;
                        }
                        entry.HandleRemoval(navigator: this, previousPresent: _GetRouteBefore(index, NavigatorDefaultClass._RouteEntry.WillBePresentPredicate)?.Route); continue;
                    case _RouteLifecycle.Removing:
                        if (!canRemoveOrAdd && next != null)
                        {
                            break;
                        }
                        entry.CurrentState = _RouteLifecycle.Dispose; continue;
                    case _RouteLifecycle.Dispose: toBeDisposed.Add(_History.RemoveAt(index)); entry = next; break;
                    case _RouteLifecycle.Disposed: case _RouteLifecycle.Staging: break;
                }
                index -= 1;
                next = entry;
                entry = previous;
                previous = index > 0 ? _History[index - 1] : null;
            }

            _FlushRouteAnnouncement();
            _RouteEntry lastEntry = _History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate, orElse: () => =>null);
            string routeName = lastEntry?.Route?.Settings?.Name;
            if (routeName != _LastAnnouncedRouteName)
            {
                RoutenotificationmessagesDefaultClass.RouteNotificationMessages.MaybeNotifyRouteChange(routeName, _LastAnnouncedRouteName);
                _LastAnnouncedRouteName = routeName;
            }

            foreach (_RouteEntry entry in toBeDisposed)
            {
                foreach (OverlayEntry overlayEntry in entry.Route.OverlayEntries) overlayEntry.Remove();
                entry.Dispose();
            }

            if (rearrangeOverlay) Overlay?.Rearrange(_AllRouteOverlayEntries);
        }




        private void _FlushRouteAnnouncement()
        {
            int index = _History.Count - 1;
            while (index >= 0)
            {
                _RouteEntry entry = _History[index];
                if (!entry.SuitableForAnnouncement)
                {
                    index -= 1;
                    continue;
                }

                _RouteEntry next = _GetRouteAfter(index + 1, NavigatorDefaultClass._RouteEntry.SuitableForTransitionAnimationPredicate);
                if (next?.Route != entry.LastAnnouncedNextRoute)
                {
                    if (entry.ShouldAnnounceChangeToNext(next?.Route))
                    {
                        entry.Route.DidChangeNext(next?.Route);
                    }

                    entry.LastAnnouncedNextRoute = next?.Route;
                }

                _RouteEntry previous = _GetRouteBefore(index - 1, NavigatorDefaultClass._RouteEntry.SuitableForTransitionAnimationPredicate);
                if (previous?.Route != entry.LastAnnouncedPreviousRoute)
                {
                    entry.Route.DidChangePrevious(previous?.Route);
                    entry.LastAnnouncedPreviousRoute = previous?.Route;
                }

                index -= 1;
            }

        }




        private FlutterSDK.Widgets.Navigator._RouteEntry _GetRouteBefore(int index, FlutterSDK.Widgets.Navigator._RouteEntryPredicate predicate)
        {
            index = _GetIndexBefore(index, predicate);
            return index >= 0 ? _History[index] : null;
        }




        private int _GetIndexBefore(int index, FlutterSDK.Widgets.Navigator._RouteEntryPredicate predicate)
        {
            while (index >= 0 && !predicate(_History[index]))
            {
                index -= 1;
            }

            return index;
        }




        private FlutterSDK.Widgets.Navigator._RouteEntry _GetRouteAfter(int index, FlutterSDK.Widgets.Navigator._RouteEntryPredicate predicate)
        {
            while (index < _History.Count && !predicate(_History[index]))
            {
                index += 1;
            }

            return index < _History.Count ? _History[index] : null;
        }




        private Route<T> _RouteNamed<T>(string name, @Object arguments = default(@Object), bool allowNull = false)
        {


            if (allowNull && Widget.OnGenerateRoute == null) return null;

            RouteSettings settings = new RouteSettings(name: name, arguments: arguments);
            Route<T> route = Widget.OnGenerateRoute(settings) as Route<T>;
            if (route == null && !allowNull)
            {

                route = Widget.OnUnknownRoute(settings) as Route<T>;

            }


            return route;
        }




        /// <Summary>
        /// Push a named route onto the navigator.
        ///
        /// {@macro flutter.widgets.navigator.pushNamed}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _aaronBurrSir() {
        ///   navigator.pushNamed('/nyc/1776');
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushNamed<T>(string routeName, @Object arguments = default(@Object))
        {
            return Push(_RouteNamed(routeName, arguments: arguments));
        }




        /// <Summary>
        /// Replace the current route of the navigator by pushing the route named
        /// [routeName] and then disposing the previous route once the new route has
        /// finished animating in.
        ///
        /// {@macro flutter.widgets.navigator.pushReplacementNamed}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _startBike() {
        ///   navigator.pushReplacementNamed('/jouett/1781');
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushReplacementNamed<T, TO>(string routeName, TO result = default(TO), @Object arguments = default(@Object))
        {
            return PushReplacement(_RouteNamed(routeName, arguments: arguments), result: result);
        }




        /// <Summary>
        /// Pop the current route off the navigator and push a named route in its
        /// place.
        ///
        /// {@macro flutter.widgets.navigator.popAndPushNamed}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _begin() {
        ///   navigator.popAndPushNamed('/nyc/1776');
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PopAndPushNamed<T, TO>(string routeName, TO result = default(TO), @Object arguments = default(@Object))
        {
            Pop(result);
            return PushNamed(routeName, arguments: arguments);
        }




        /// <Summary>
        /// Push the route with the given name onto the navigator, and then remove all
        /// the previous routes until the `predicate` returns true.
        ///
        /// {@macro flutter.widgets.navigator.pushNamedAndRemoveUntil}
        ///
        /// {@macro flutter.widgets.navigator.pushNamed.arguments}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _handleOpenCalendar() {
        ///   navigator.pushNamedAndRemoveUntil('/calendar', ModalRoute.withName('/'));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushNamedAndRemoveUntil<T>(string newRouteName, FlutterSDK.Widgets.Navigator.RoutePredicate predicate, @Object arguments = default(@Object))
        {
            return PushAndRemoveUntil(_RouteNamed(newRouteName, arguments: arguments), predicate);
        }




        /// <Summary>
        /// Push the given route onto the navigator.
        ///
        /// {@macro flutter.widgets.navigator.push}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _openPage() {
        ///   navigator.push(MaterialPageRoute(builder: (BuildContext context) => MyPage()));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> Push<T>(FlutterSDK.Widgets.Navigator.Route<T> route)
        {




            _History.Add(new _RouteEntry(route, initialState: _RouteLifecycle.Push));
            _FlushHistoryUpdates();

            _AfterNavigation(route);
            return route.Popped;
        }




        private void _AfterNavigation<T>(FlutterSDK.Widgets.Navigator.Route<T> route)
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                Dictionary<string, object> routeJsonable = default(Dictionary<string, object>);
                if (route != null)
                {
                    routeJsonable = new Dictionary<string, object> { };
                    string description = default(string);
                    if (((TransitionRoute<T>)route) is TransitionRoute<T>)
                    {
                        TransitionRoute<T> transitionRoute = ((TransitionRoute<T>)route);
                        description = transitionRoute.DebugLabel;
                    }
                    else
                    {
                        description = $"'{route}'";
                    }

                    routeJsonable["description"] = description;
                    RouteSettings settings = route.Settings;
                    Dictionary<string, object> settingsJsonable = new Dictionary<string, object> { { "name", settings.Name } };
                    if (settings.Arguments != null)
                    {
                        settingsJsonable["arguments"] = Dart:convertDefaultClass.JsonEncode(settings.Arguments, toEncodable: (object object) => =>$"'{object}'");
                    }

                    routeJsonable["settings"] = settingsJsonable;
                }

                Developer.Dart:developerDefaultClass.PostEvent("Flutter.Navigation", new Dictionary<string, object> { { "route", routeJsonable } });
            }

            _CancelActivePointers();
        }




        /// <Summary>
        /// Replace the current route of the navigator by pushing the given route and
        /// then disposing the previous route once the new route has finished
        /// animating in.
        ///
        /// {@macro flutter.widgets.navigator.pushReplacement}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _doOpenPage() {
        ///   navigator.pushReplacement(
        ///       MaterialPageRoute(builder: (BuildContext context) => MyHomePage()));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushReplacement<T, TO>(FlutterSDK.Widgets.Navigator.Route<T> newRoute, TO result = default(TO))
        {






            _History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate).Complete(result, isReplaced: true);
            _History.Add(new _RouteEntry(newRoute, initialState: _RouteLifecycle.PushReplace));
            _FlushHistoryUpdates();

            _AfterNavigation(newRoute);
            return newRoute.Popped;
        }




        /// <Summary>
        /// Push the given route onto the navigator, and then remove all the previous
        /// routes until the `predicate` returns true.
        ///
        /// {@macro flutter.widgets.navigator.pushAndRemoveUntil}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _resetAndOpenPage() {
        ///   navigator.pushAndRemoveUntil(
        ///     MaterialPageRoute(builder: (BuildContext context) => MyHomePage()),
        ///     ModalRoute.withName('/'),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual Future<T> PushAndRemoveUntil<T>(FlutterSDK.Widgets.Navigator.Route<T> newRoute, FlutterSDK.Widgets.Navigator.RoutePredicate predicate)
        {






            int index = _History.Count - 1;
            _History.Add(new _RouteEntry(newRoute, initialState: _RouteLifecycle.Push));
            while (index >= 0 && !predicate(_History[index].Route))
            {
                if (_History[index].IsPresent) _History[index].Remove();
                index -= 1;
            }

            _FlushHistoryUpdates();

            _AfterNavigation(newRoute);
            return newRoute.Popped;
        }




        /// <Summary>
        /// Replaces a route on the navigator with a new route.
        ///
        /// {@macro flutter.widgets.navigator.replace}
        ///
        /// See also:
        ///
        ///  * [replaceRouteBelow], which is the same but identifies the route to be
        ///    removed by reference to the route above it, rather than directly.
        /// </Summary>
        public virtual void Replace<T>(FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>))
        {



            if (oldRoute == newRoute) return;



            int index = _History.IndexWhere(NavigatorDefaultClass._RouteEntry.IsRoutePredicate(oldRoute));


            bool wasCurrent = oldRoute.IsCurrent;
            _History.Insert(index + 1, new _RouteEntry(newRoute, initialState: _RouteLifecycle.Replace));
            _History[index].Remove(isReplaced: true);
            _FlushHistoryUpdates();

            if (wasCurrent) _AfterNavigation(newRoute);
        }




        /// <Summary>
        /// Replaces a route on the navigator with a new route. The route to be
        /// replaced is the one below the given `anchorRoute`.
        ///
        /// {@macro flutter.widgets.navigator.replaceRouteBelow}
        ///
        /// See also:
        ///
        ///  * [replace], which is the same but identifies the route to be removed
        ///    directly.
        /// </Summary>
        public virtual void ReplaceRouteBelow<T>(FlutterSDK.Widgets.Navigator.Route<object> anchorRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>))
        {






            int anchorIndex = _History.IndexWhere(NavigatorDefaultClass._RouteEntry.IsRoutePredicate(anchorRoute));


            int index = anchorIndex - 1;
            while (index >= 0)
            {
                if (_History[index].IsPresent) break;
                index -= 1;
            }


            _History.Insert(index + 1, new _RouteEntry(newRoute, initialState: _RouteLifecycle.Replace));
            _History[index].Remove(isReplaced: true);
            _FlushHistoryUpdates();

        }




        /// <Summary>
        /// Whether the navigator can be popped.
        ///
        /// {@macro flutter.widgets.navigator.canPop}
        ///
        /// See also:
        ///
        ///  * [Route.isFirst], which returns true for routes for which [canPop]
        ///    returns false.
        /// </Summary>
        public virtual bool CanPop()
        {
            Iterator<_RouteEntry> iterator = _History.Where(NavigatorDefaultClass._RouteEntry.IsPresentPredicate).Iterator;
            if (!iterator.MoveNext()) return false;
            if (iterator.Current.Route.WillHandlePopInternally) return true;
            if (!iterator.MoveNext()) return false;
            return true;
        }




        /// <Summary>
        /// Consults the current route's [Route.willPop] method, and acts accordingly,
        /// potentially popping the route as a result; returns whether the pop request
        /// should be considered handled.
        ///
        /// {@macro flutter.widgets.navigator.maybePop}
        ///
        /// See also:
        ///
        ///  * [Form], which provides an `onWillPop` callback that enables the form
        ///    to veto a [pop] initiated by the app's back button.
        ///  * [ModalRoute], which provides a `scopedWillPopCallback` that can be used
        ///    to define the route's `willPop` method.
        /// </Summary>
        public virtual Future<bool> MaybePop<T>(T result = default(T))
        {
            _RouteEntry lastEntry = _History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate, orElse: () => =>null);
            if (lastEntry == null) return false;

            RoutePopDisposition disposition = await lastEntry.Route.WillPop();

            if (!Mounted) return true;
            _RouteEntry newLastEntry = _History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate, orElse: () => =>null);
            if (lastEntry != newLastEntry) return true;
            switch (disposition) { case RoutePopDisposition.Bubble: return false; case RoutePopDisposition.Pop: Pop(result); return true; case RoutePopDisposition.DoNotPop: return true; }
            return null;
        }




        /// <Summary>
        /// Pop the top-most route off the navigator.
        ///
        /// {@macro flutter.widgets.navigator.pop}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage for closing a route is as follows:
        ///
        /// ```dart
        /// void _handleClose() {
        ///   navigator.pop();
        /// }
        /// ```
        /// {@end-tool}
        /// {@tool snippet}
        ///
        /// A dialog box might be closed with a result:
        ///
        /// ```dart
        /// void _handleAccept() {
        ///   navigator.pop(true); // dialog returns true
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual void Pop<T>(T result = default(T))
        {


            _RouteEntry entry = _History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate);
            if (entry.HasPage)
            {
                if (Widget.OnPopPage(entry.Route, result)) entry.CurrentState = _RouteLifecycle.Pop;
            }
            else
            {
                entry.Pop(result);
            }

            if (entry.CurrentState == _RouteLifecycle.Pop)
            {
                _FlushHistoryUpdates(rearrangeOverlay: false);

            }


            _AfterNavigation(entry.Route);
        }




        /// <Summary>
        /// Calls [pop] repeatedly until the predicate returns true.
        ///
        /// {@macro flutter.widgets.navigator.popUntil}
        ///
        /// {@tool snippet}
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// void _doLogout() {
        ///   navigator.popUntil(ModalRoute.withName('/login'));
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual void PopUntil(FlutterSDK.Widgets.Navigator.RoutePredicate predicate)
        {
            while (!predicate(_History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate).Route))
            {
                Pop();
            }

        }




        /// <Summary>
        /// Immediately remove `route` from the navigator, and [Route.dispose] it.
        ///
        /// {@macro flutter.widgets.navigator.removeRoute}
        /// </Summary>
        public virtual void RemoveRoute(FlutterSDK.Widgets.Navigator.Route<object> route)
        {




            bool wasCurrent = route.IsCurrent;
            _RouteEntry entry = _History.FirstWhere(NavigatorDefaultClass._RouteEntry.IsRoutePredicate(route), orElse: () => =>null);

            entry.Remove();
            _FlushHistoryUpdates(rearrangeOverlay: false);

            if (wasCurrent) _AfterNavigation(_History.LastWhere(NavigatorDefaultClass._RouteEntry.IsPresentPredicate, orElse: () => =>null)?.Route);
        }




        /// <Summary>
        /// Immediately remove a route from the navigator, and [Route.dispose] it. The
        /// route to be removed is the one below the given `anchorRoute`.
        ///
        /// {@macro flutter.widgets.navigator.removeRouteBelow}
        /// </Summary>
        public virtual void RemoveRouteBelow(FlutterSDK.Widgets.Navigator.Route<object> anchorRoute)
        {




            int anchorIndex = _History.IndexWhere(NavigatorDefaultClass._RouteEntry.IsRoutePredicate(anchorRoute));


            int index = anchorIndex - 1;
            while (index >= 0)
            {
                if (_History[index].IsPresent) break;
                index -= 1;
            }


            _History[index].Remove();
            _FlushHistoryUpdates(rearrangeOverlay: false);

        }




        /// <Summary>
        /// Complete the lifecycle for a route that has been popped off the navigator.
        ///
        /// When the navigator pops a route, the navigator retains a reference to the
        /// route in order to call [Route.dispose] if the navigator itself is removed
        /// from the tree. When the route is finished with any exit animation, the
        /// route should call this function to complete its lifecycle (e.g., to
        /// receive a call to [Route.dispose]).
        ///
        /// The given `route` must have already received a call to [Route.didPop].
        /// This function may be called directly from [Route.didPop] if [Route.didPop]
        /// will return true.
        /// </Summary>
        public virtual void FinalizeRoute(FlutterSDK.Widgets.Navigator.Route<object> route)
        {
            bool wasDebugLocked = default(bool);


            _RouteEntry entry = _History.FirstWhere(NavigatorDefaultClass._RouteEntry.IsRoutePredicate(route));
            if (entry.DoingPop)
            {
                entry.CurrentState = _RouteLifecycle.Pop;
                _FlushHistoryUpdates(rearrangeOverlay: false);
            }


            entry.Finalize();
            _FlushHistoryUpdates(rearrangeOverlay: false);

        }




        /// <Summary>
        /// The navigator is being controlled by a user gesture.
        ///
        /// For example, called when the user beings an iOS back gesture.
        ///
        /// When the gesture finishes, call [didStopUserGesture].
        /// </Summary>
        public virtual void DidStartUserGesture()
        {
            _UserGesturesInProgress += 1;
            if (_UserGesturesInProgress == 1)
            {
                int routeIndex = _GetIndexBefore(_History.Count - 1, NavigatorDefaultClass._RouteEntry.WillBePresentPredicate);

                Route<object> route = _History[routeIndex].Route;
                Route<object> previousRoute = default(Route<object>);
                if (!route.WillHandlePopInternally && routeIndex > 0)
                {
                    previousRoute = _GetRouteBefore(routeIndex - 1, NavigatorDefaultClass._RouteEntry.WillBePresentPredicate).Route;
                }

                foreach (NavigatorObserver observer in Widget.Observers) observer.DidStartUserGesture(route, previousRoute);
            }

        }




        /// <Summary>
        /// A user gesture completed.
        ///
        /// Notifies the navigator that a gesture regarding which the navigator was
        /// previously notified with [didStartUserGesture] has completed.
        /// </Summary>
        public virtual void DidStopUserGesture()
        {

            _UserGesturesInProgress -= 1;
            if (_UserGesturesInProgress == 0)
            {
                foreach (NavigatorObserver observer in Widget.Observers) observer.DidStopUserGesture();
            }

        }




        private void _HandlePointerDown(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            _ActivePointers.Add(@event.Pointer);
        }




        private void _HandlePointerUpOrCancel(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            _ActivePointers.Remove(@event.Pointer);
        }




        private void _CancelActivePointers()
        {
            if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase == SchedulerPhase.Idle)
            {
                RenderAbsorbPointer absorber = _OverlayKey.CurrentContext?.FindAncestorRenderObjectOfType();
                SetState(() =>
                {
                    absorber?.Absorbing = true;
                }
                );
            }

            _ActivePointers.ToList().ForEach(BindingDefaultClass.WidgetsBinding.Instance.CancelPointer);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            return new Listener(onPointerDown: _HandlePointerDown, onPointerUp: _HandlePointerUpOrCancel, onPointerCancel: _HandlePointerUpOrCancel, child: new AbsorbPointer(absorbing: false, child: new FocusScope(node: FocusScopeNode, autofocus: true, child: new Overlay(key: _OverlayKey, initialEntries: Overlay == null ? _AllRouteOverlayEntries.ToList(growable: false) : new List, < OverlayEntry > (}))));
}



    #endregion
}


/// <Summary>
/// Indicates whether the current route should be popped.
///
/// Used as the return value for [Route.willPop].
///
/// See also:
///
///  * [WillPopScope], a widget that hooks into the route's [Route.willPop]
///    mechanism.
/// </Summary>
public enum RoutePopDisposition
{

    /// <Summary>
    /// Pop the route.
    ///
    /// If [Route.willPop] returns [pop] then the back button will actually pop
    /// the current route.
    /// </Summary>
    Pop,
    /// <Summary>
    /// Do not pop the route.
    ///
    /// If [Route.willPop] returns [doNotPop] then the back button will be ignored.
    /// </Summary>
    DoNotPop,
    /// <Summary>
    /// Delegate this to the next level of navigation.
    ///
    /// If [Route.willPop] returns [bubble] then the back button will be handled
    /// by the [SystemNavigator], which will usually close the application.
    /// </Summary>
    Bubble,
}


public enum _RouteLifecycle
{

    Staging,
    Add,
    Adding,
    Push,
    PushReplace,
    Pushing,
    Replace,
    Idle,
    Pop,
    Remove,
    Popping,
    Removing,
    Dispose,
    Disposed,
}

}
