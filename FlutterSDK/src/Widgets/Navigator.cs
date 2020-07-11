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


    public interface IPage<T>
    {
        bool CanUpdate(FlutterSDK.Widgets.Navigator.Page<object> other);
        Route<T> CreateRoute(FlutterSDK.Widgets.Framework.BuildContext context);
        string ToString();
        FlutterSDK.Foundation.Key.LocalKey Key { get; }
    }


    public interface ITransitionDelegate<T>
    {
        Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> Resolve(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>));
    }


    public interface INavigatorObserver { }

    public class NavigatorObserver
    {
        internal virtual FlutterSDK.Widgets.Navigator.NavigatorState _Navigator { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual void DidPush(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public virtual void DidPop(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public virtual void DidRemove(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public virtual void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> newRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>)) { throw new NotImplementedException(); }


        public virtual void DidStartUserGesture(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public virtual void DidStopUserGesture() { throw new NotImplementedException(); }

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

        public virtual void MarkForPush() { throw new NotImplementedException(); }


        public virtual void MarkForAdd() { throw new NotImplementedException(); }


        public virtual void MarkForPop(object result = default(object)) { throw new NotImplementedException(); }


        public virtual void MarkForComplete(object result = default(object)) { throw new NotImplementedException(); }


        public virtual void MarkForRemove() { throw new NotImplementedException(); }

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


    public class Route<T>
    {
        #region constructors
        public Route(FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base()
        {
            throw new NotImplementedException();
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

        private void _UpdateSettings(FlutterSDK.Widgets.Navigator.RouteSettings newSettings) { throw new NotImplementedException(); }


        public virtual void Install() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture DidPush() { throw new NotImplementedException(); }


        public virtual void DidAdd() { throw new NotImplementedException(); }


        public virtual void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> oldRoute) { throw new NotImplementedException(); }


        public virtual Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop() { throw new NotImplementedException(); }


        public virtual bool DidPop(T result) { throw new NotImplementedException(); }


        public virtual void DidComplete(T result) { throw new NotImplementedException(); }


        public virtual void DidPopNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute) { throw new NotImplementedException(); }


        public virtual void DidChangeNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute) { throw new NotImplementedException(); }


        public virtual void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public virtual void ChangedInternalState() { throw new NotImplementedException(); }


        public virtual void ChangedExternalState() { throw new NotImplementedException(); }


        public virtual void Dispose() { throw new NotImplementedException(); }

        #endregion
    }


    public class RouteSettings
    {
        #region constructors
        public RouteSettings(string name = default(string), @Object arguments = default(@Object))
        {
            this.Name = name;
            this.Arguments = arguments; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string Name { get; set; }
        public virtual @Object Arguments { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Widgets.Navigator.RouteSettings CopyWith(string name = default(string), @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        #endregion
    }


    public class Page<T> : FlutterSDK.Widgets.Navigator.RouteSettings
    {
        #region constructors
        public Page(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), string name = default(string), @Object arguments = default(@Object))
        : base(name: name, arguments: arguments)
        {
            this.Key = key; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
        #endregion

        #region methods

        public virtual bool CanUpdate(FlutterSDK.Widgets.Navigator.Page<object> other) { throw new NotImplementedException(); }


        public virtual Route<T> CreateRoute(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        #endregion
    }


    public class CustomBuilderPage<T> : FlutterSDK.Widgets.Navigator.Page<T>
    {
        #region constructors
        public CustomBuilderPage(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), FlutterSDK.Widgets.Navigator.RouteBuilder<T> routeBuilder = default(FlutterSDK.Widgets.Navigator.RouteBuilder<T>), string name = default(string), @Object arguments = default(@Object))
        : base(key: key, name: name, arguments: arguments)
        {
            this.RouteBuilder = routeBuilder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Navigator.RouteBuilder<T> RouteBuilder { get; set; }
        #endregion

        #region methods

        public new Route<T> CreateRoute(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class TransitionDelegate<T>
    {
        #region constructors
        public TransitionDelegate()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        private Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> _Transition(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>)) { throw new NotImplementedException(); }


        public virtual Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> Resolve(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>)) { throw new NotImplementedException(); }

        #endregion
    }


    public class DefaultTransitionDelegate<T> : FlutterSDK.Widgets.Navigator.TransitionDelegate<T>
    {
        #region constructors
        public DefaultTransitionDelegate()
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Iterable<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> Resolve(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord> newPageRouteHistory = default(List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord> locationToExitingPageRoute = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, FlutterSDK.Widgets.Navigator.RouteTransitionRecord>), Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>> pageRouteToPagelessRoutes = default(Dictionary<FlutterSDK.Widgets.Navigator.RouteTransitionRecord, List<FlutterSDK.Widgets.Navigator.RouteTransitionRecord>>)) { throw new NotImplementedException(); }

        #endregion
    }


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
            this.Observers = observers; throw new NotImplementedException();
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

        public virtual Future<T> PushNamed<T>(FlutterSDK.Widgets.Framework.BuildContext context, string routeName, @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> PushReplacementNamed<T, TO>(FlutterSDK.Widgets.Framework.BuildContext context, string routeName, TO result = default(TO), @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> PopAndPushNamed<T, TO>(FlutterSDK.Widgets.Framework.BuildContext context, string routeName, TO result = default(TO), @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> PushNamedAndRemoveUntil<T>(FlutterSDK.Widgets.Framework.BuildContext context, string newRouteName, FlutterSDK.Widgets.Navigator.RoutePredicate predicate, @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> Push<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<T> route) { throw new NotImplementedException(); }


        public virtual Future<T> PushReplacement<T, TO>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<T> newRoute, TO result = default(TO)) { throw new NotImplementedException(); }


        public virtual Future<T> PushAndRemoveUntil<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<T> newRoute, FlutterSDK.Widgets.Navigator.RoutePredicate predicate) { throw new NotImplementedException(); }


        public virtual void Replace<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>)) { throw new NotImplementedException(); }


        public virtual void ReplaceRouteBelow<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> anchorRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>)) { throw new NotImplementedException(); }


        public virtual bool CanPop(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public virtual Future<bool> MaybePop<T>(FlutterSDK.Widgets.Framework.BuildContext context, T result = default(T)) { throw new NotImplementedException(); }


        public virtual void Pop<T>(FlutterSDK.Widgets.Framework.BuildContext context, T result = default(T)) { throw new NotImplementedException(); }


        public virtual void PopUntil(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.RoutePredicate predicate) { throw new NotImplementedException(); }


        public virtual void RemoveRoute(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> route) { throw new NotImplementedException(); }


        public virtual void RemoveRouteBelow(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Navigator.Route<object> anchorRoute) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Of(FlutterSDK.Widgets.Framework.BuildContext context, bool rootNavigator = false, bool nullOk = false) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Widgets.Navigator.Route<object>> DefaultGenerateInitialRoutes(FlutterSDK.Widgets.Navigator.NavigatorState navigator, string initialRouteName) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Navigator.NavigatorState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _RouteEntry : FlutterSDK.Widgets.Navigator.RouteTransitionRecord
    {
        #region constructors
        public _RouteEntry(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator._RouteLifecycle initialState = default(FlutterSDK.Widgets.Navigator._RouteLifecycle))
        : base()
        {
            this.Route = route; throw new NotImplementedException();
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

        public virtual bool CanUpdateFrom(FlutterSDK.Widgets.Navigator.Page<object> page) { throw new NotImplementedException(); }


        public virtual void HandleAdd(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState)) { throw new NotImplementedException(); }


        public virtual void HandlePush(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), bool isNewFirst = default(bool), FlutterSDK.Widgets.Navigator.Route<object> previous = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>)) { throw new NotImplementedException(); }


        public virtual void HandleDidPopNext(FlutterSDK.Widgets.Navigator.Route<object> poppedRoute) { throw new NotImplementedException(); }


        public virtual void HandlePop(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>)) { throw new NotImplementedException(); }


        public virtual void HandleRemoval(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>)) { throw new NotImplementedException(); }


        public virtual void DidAdd(FlutterSDK.Widgets.Navigator.NavigatorState navigator = default(FlutterSDK.Widgets.Navigator.NavigatorState), bool isNewFirst = default(bool), FlutterSDK.Widgets.Navigator.Route<object> previous = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> previousPresent = default(FlutterSDK.Widgets.Navigator.Route<object>)) { throw new NotImplementedException(); }


        public virtual void Pop<T>(T result) { throw new NotImplementedException(); }


        public virtual void Remove(bool isReplaced = false) { throw new NotImplementedException(); }


        public virtual void Complete<T>(T result, bool isReplaced = false) { throw new NotImplementedException(); }


        public virtual void Finalize() { throw new NotImplementedException(); }


        public virtual void Dispose() { throw new NotImplementedException(); }


        public virtual bool ShouldAnnounceChangeToNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Navigator._RouteEntryPredicate IsRoutePredicate(FlutterSDK.Widgets.Navigator.Route<object> route) { throw new NotImplementedException(); }


        public new void MarkForPush() { throw new NotImplementedException(); }


        public new void MarkForAdd() { throw new NotImplementedException(); }


        public new void MarkForPop(object result = default(object)) { throw new NotImplementedException(); }


        public new void MarkForComplete(object result = default(object)) { throw new NotImplementedException(); }


        public new void MarkForRemove() { throw new NotImplementedException(); }

        #endregion
    }


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

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Navigator.Navigator oldWidget) { throw new NotImplementedException(); }


        private void _DebugCheckDuplicatedPageKeys() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _UpdatePages() { throw new NotImplementedException(); }


        private void _FlushHistoryUpdates(bool rearrangeOverlay = true) { throw new NotImplementedException(); }


        private void _FlushRouteAnnouncement() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Navigator._RouteEntry _GetRouteBefore(int index, FlutterSDK.Widgets.Navigator._RouteEntryPredicate predicate) { throw new NotImplementedException(); }


        private int _GetIndexBefore(int index, FlutterSDK.Widgets.Navigator._RouteEntryPredicate predicate) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Navigator._RouteEntry _GetRouteAfter(int index, FlutterSDK.Widgets.Navigator._RouteEntryPredicate predicate) { throw new NotImplementedException(); }


        private Route<T> _RouteNamed<T>(string name, @Object arguments = default(@Object), bool allowNull = false) { throw new NotImplementedException(); }


        public virtual Future<T> PushNamed<T>(string routeName, @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> PushReplacementNamed<T, TO>(string routeName, TO result = default(TO), @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> PopAndPushNamed<T, TO>(string routeName, TO result = default(TO), @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> PushNamedAndRemoveUntil<T>(string newRouteName, FlutterSDK.Widgets.Navigator.RoutePredicate predicate, @Object arguments = default(@Object)) { throw new NotImplementedException(); }


        public virtual Future<T> Push<T>(FlutterSDK.Widgets.Navigator.Route<T> route) { throw new NotImplementedException(); }


        private void _AfterNavigation<T>(FlutterSDK.Widgets.Navigator.Route<T> route) { throw new NotImplementedException(); }


        public virtual Future<T> PushReplacement<T, TO>(FlutterSDK.Widgets.Navigator.Route<T> newRoute, TO result = default(TO)) { throw new NotImplementedException(); }


        public virtual Future<T> PushAndRemoveUntil<T>(FlutterSDK.Widgets.Navigator.Route<T> newRoute, FlutterSDK.Widgets.Navigator.RoutePredicate predicate) { throw new NotImplementedException(); }


        public virtual void Replace<T>(FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>)) { throw new NotImplementedException(); }


        public virtual void ReplaceRouteBelow<T>(FlutterSDK.Widgets.Navigator.Route<object> anchorRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<T> newRoute = default(FlutterSDK.Widgets.Navigator.Route<T>)) { throw new NotImplementedException(); }


        public virtual bool CanPop() { throw new NotImplementedException(); }


        public virtual Future<bool> MaybePop<T>(T result = default(T)) { throw new NotImplementedException(); }


        public virtual void Pop<T>(T result = default(T)) { throw new NotImplementedException(); }


        public virtual void PopUntil(FlutterSDK.Widgets.Navigator.RoutePredicate predicate) { throw new NotImplementedException(); }


        public virtual void RemoveRoute(FlutterSDK.Widgets.Navigator.Route<object> route) { throw new NotImplementedException(); }


        public virtual void RemoveRouteBelow(FlutterSDK.Widgets.Navigator.Route<object> anchorRoute) { throw new NotImplementedException(); }


        public virtual void FinalizeRoute(FlutterSDK.Widgets.Navigator.Route<object> route) { throw new NotImplementedException(); }


        public virtual void DidStartUserGesture() { throw new NotImplementedException(); }


        public virtual void DidStopUserGesture() { throw new NotImplementedException(); }


        private void _HandlePointerDown(FlutterSDK.Gestures.Events.PointerDownEvent @event) { throw new NotImplementedException(); }


        private void _HandlePointerUpOrCancel(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        private void _CancelActivePointers() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public enum RoutePopDisposition
    {

        Pop,
        DoNotPop,
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
