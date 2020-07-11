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
namespace FlutterSDK.Widgets.Routes
{
    public delegate FlutterSDK.Widgets.Framework.Widget RoutePageBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation);
    public delegate FlutterSDK.Widgets.Framework.Widget RouteTransitionsBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child);
    internal static class RoutesDefaultClass
    {
        public static Color _KTransparent = default(Color);
        internal static Future<T> ShowGeneralDialog<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Routes.RoutePageBuilder pageBuilder = default(FlutterSDK.Widgets.Routes.RoutePageBuilder), bool barrierDismissible = default(bool), string barrierLabel = default(string), FlutterBinding.UI.Color barrierColor = default(FlutterBinding.UI.Color), TimeSpan transitionDuration = default(TimeSpan), FlutterSDK.Widgets.Routes.RouteTransitionsBuilder transitionBuilder = default(FlutterSDK.Widgets.Routes.RouteTransitionsBuilder), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A route that displays widgets in the [Navigator]'s [Overlay].
    /// </Summary>
    public interface IOverlayRoute<T>
    {
        Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> CreateOverlayEntries();
        void Install();
        bool DidPop(T result);
        void Dispose();
        List<FlutterSDK.Widgets.Overlay.OverlayEntry> OverlayEntries { get; }
        bool FinishedWhenPopped { get; }
    }


    /// <Summary>
    /// A route with entrance and exit transitions.
    /// </Summary>
    public interface ITransitionRoute<T>
    {
        FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController();
        FlutterSDK.Animation.Animation.Animation<double> CreateAnimation();
        void Install();
        FlutterSDK.Scheduler.Ticker.TickerFuture DidPush();
        void DidAdd();
        void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> oldRoute);
        bool DidPop(T result);
        void DidPopNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute);
        void DidChangeNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute);
        bool CanTransitionTo(FlutterSDK.Widgets.Routes.TransitionRoute<object> nextRoute);
        bool CanTransitionFrom(FlutterSDK.Widgets.Routes.TransitionRoute<object> previousRoute);
        void Dispose();
        string ToString();
        Future<T> Completed { get; }
        TimeSpan TransitionDuration { get; }
        TimeSpan ReverseTransitionDuration { get; }
        bool Opaque { get; }
        bool FinishedWhenPopped { get; }
        FlutterSDK.Animation.Animation.Animation<double> Animation { get; }
        FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; }
        FlutterSDK.Animation.Animation.Animation<double> SecondaryAnimation { get; }
        string DebugLabel { get; }
    }


    /// <Summary>
    /// A route that blocks interaction with previous routes.
    ///
    /// [ModalRoute]s cover the entire [Navigator]. They are not necessarily
    /// [opaque], however; for example, a pop-up menu uses a [ModalRoute] but only
    /// shows the menu in a small box overlapping the previous route.
    ///
    /// The `T` type argument is the return value of the route. If there is no
    /// return value, consider using `void` as the return value.
    /// </Summary>
    public interface IModalRoute<T>
    {
        ModalRoute<T> Of<T>(FlutterSDK.Widgets.Framework.BuildContext context);
        void SetState(VoidCallback fn);
        FlutterSDK.Widgets.Navigator.RoutePredicate WithName(string name);
        FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation);
        FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child);
        void Install();
        FlutterSDK.Scheduler.Ticker.TickerFuture DidPush();
        void DidAdd();
        Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop();
        void AddScopedWillPopCallback(FlutterSDK.Widgets.Navigator.WillPopCallback callback);
        void RemoveScopedWillPopCallback(FlutterSDK.Widgets.Navigator.WillPopCallback callback);
        void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute);
        void ChangedInternalState();
        void ChangedExternalState();
        Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> CreateOverlayEntries();
        string ToString();
        bool BarrierDismissible { get; }
        bool SemanticsDismissible { get; }
        FlutterBinding.UI.Color BarrierColor { get; }
        string BarrierLabel { get; }
        FlutterSDK.Animation.Curves.Curve BarrierCurve { get; }
        bool MaintainState { get; }
        bool Offstage { get; set; }
        FlutterSDK.Widgets.Framework.BuildContext SubtreeContext { get; }
        FlutterSDK.Animation.Animation.Animation<double> Animation { get; }
        FlutterSDK.Animation.Animation.Animation<double> SecondaryAnimation { get; }
        bool HasScopedWillPopCallback { get; }
        bool CanPop { get; }
    }


    /// <Summary>
    /// A modal route that overlays a widget over the current route.
    /// </Summary>
    public interface IPopupRoute<T>
    {
        bool Opaque { get; }
        bool MaintainState { get; }
    }


    public interface ILocalHistoryRoute<T> { }

    public class LocalHistoryRoute<T>
    {
        internal virtual List<FlutterSDK.Widgets.Routes.LocalHistoryEntry> _LocalHistory { get; set; }
        public virtual bool WillHandlePopInternally { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Adds a local history entry to this route.
        ///
        /// When asked to pop, if this route has any local history entries, this route
        /// will handle the pop internally by removing the most recently added local
        /// history entry.
        ///
        /// The given local history entry must not already be part of another local
        /// history route.
        ///
        /// {@tool snippet}
        ///
        /// The following example is an app with 2 pages: `HomePage` and `SecondPage`.
        /// The `HomePage` can navigate to the `SecondPage`.
        ///
        /// The `SecondPage` uses a [LocalHistoryEntry] to implement local navigation
        /// within that page. Pressing 'show rectangle' displays a red rectangle and
        /// adds a local history entry. At that point, pressing the '< back' button
        /// pops the latest route, which is the local history entry, and the red
        /// rectangle disappears. Pressing the '< back' button a second time
        /// once again pops the latest route, which is the `SecondPage`, itself.
        /// Therefore, the second press navigates back to the `HomePage`.
        ///
        /// ```dart
        /// class App extends StatelessWidget {
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return MaterialApp(
        ///       initialRoute: '/',
        ///       routes: {
        ///         '/': (BuildContext context) => HomePage(),
        ///         '/second_page': (BuildContext context) => SecondPage(),
        ///       },
        ///     );
        ///   }
        /// }
        ///
        /// class HomePage extends StatefulWidget {
        ///   HomePage();
        ///
        ///   @override
        ///   _HomePageState createState() => _HomePageState();
        /// }
        ///
        /// class _HomePageState extends State<HomePage> {
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return Scaffold(
        ///       body: Center(
        ///         child: Column(
        ///           mainAxisSize: MainAxisSize.min,
        ///           children: <Widget>[
        ///             Text('HomePage'),
        ///             // Press this button to open the SecondPage.
        ///             RaisedButton(
        ///               child: Text('Second Page >'),
        ///               onPressed: () {
        ///                 Navigator.pushNamed(context, '/second_page');
        ///               },
        ///             ),
        ///           ],
        ///         ),
        ///       ),
        ///     );
        ///   }
        /// }
        ///
        /// class SecondPage extends StatefulWidget {
        ///   @override
        ///   _SecondPageState createState() => _SecondPageState();
        /// }
        ///
        /// class _SecondPageState extends State<SecondPage> {
        ///
        ///   bool _showRectangle = false;
        ///
        ///   void _navigateLocallyToShowRectangle() async {
        ///     // This local history entry essentially represents the display of the red
        ///     // rectangle. When this local history entry is removed, we hide the red
        ///     // rectangle.
        ///     setState(() => _showRectangle = true);
        ///     ModalRoute.of(context).addLocalHistoryEntry(
        ///         LocalHistoryEntry(
        ///             onRemove: () {
        ///               // Hide the red rectangle.
        ///               setState(() => _showRectangle = false);
        ///             }
        ///         )
        ///     );
        ///   }
        ///
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     final localNavContent = _showRectangle
        ///       ? Container(
        ///           width: 100.0,
        ///           height: 100.0,
        ///           color: Colors.red,
        ///         )
        ///       : RaisedButton(
        ///           child: Text('Show Rectangle'),
        ///           onPressed: _navigateLocallyToShowRectangle,
        ///         );
        ///
        ///     return Scaffold(
        ///       body: Center(
        ///         child: Column(
        ///           mainAxisAlignment: MainAxisAlignment.center,
        ///           children: <Widget>[
        ///             localNavContent,
        ///             RaisedButton(
        ///               child: Text('< Back'),
        ///               onPressed: () {
        ///                 // Pop a route. If this is pressed while the red rectangle is
        ///                 // visible then it will will pop our local history entry, which
        ///                 // will hide the red rectangle. Otherwise, the SecondPage will
        ///                 // navigate back to the HomePage.
        ///                 Navigator.of(context).pop();
        ///               },
        ///             ),
        ///           ],
        ///         ),
        ///       ),
        ///     );
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual void AddLocalHistoryEntry(FlutterSDK.Widgets.Routes.LocalHistoryEntry entry) { throw new NotImplementedException(); }


        /// <Summary>
        /// Remove a local history entry from this route.
        ///
        /// The entry's [LocalHistoryEntry.onRemove] callback, if any, will be called
        /// synchronously.
        /// </Summary>
        public virtual void RemoveLocalHistoryEntry(FlutterSDK.Widgets.Routes.LocalHistoryEntry entry) { throw new NotImplementedException(); }


        public new Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop() { throw new NotImplementedException(); }


        public new bool DidPop(T result) { throw new NotImplementedException(); }

    }
    public static class LocalHistoryRouteMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static LocalHistoryRoute<T> GetOrCreate<T>(ILocalHistoryRoute<T> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new LocalHistoryRoute<T>();
                _table.Add(instance, value);
            }
            return (LocalHistoryRoute<T>)value;
        }
        public static bool WillHandlePopInternallyProperty<T>(this ILocalHistoryRoute<T> instance) => GetOrCreate(instance).WillHandlePopInternally;
        public static void AddLocalHistoryEntry<T>(this ILocalHistoryRoute<T> instance, FlutterSDK.Widgets.Routes.LocalHistoryEntry entry) => GetOrCreate(instance).AddLocalHistoryEntry(entry);
        public static void RemoveLocalHistoryEntry<T>(this ILocalHistoryRoute<T> instance, FlutterSDK.Widgets.Routes.LocalHistoryEntry entry) => GetOrCreate(instance).RemoveLocalHistoryEntry(entry);
        public static Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop<T>(this ILocalHistoryRoute<T> instance) => GetOrCreate(instance).WillPop();
        public static bool DidPop<T>(this ILocalHistoryRoute<T> instance, T result) => GetOrCreate(instance).DidPop(result);
    }


    public interface IRouteAware { }

    public class RouteAware
    {

        /// <Summary>
        /// Called when the top route has been popped off, and the current route
        /// shows up.
        /// </Summary>
        public virtual void DidPopNext() { throw new NotImplementedException(); }


        /// <Summary>
        /// Called when the current route has been pushed.
        /// </Summary>
        public virtual void DidPush() { throw new NotImplementedException(); }


        /// <Summary>
        /// Called when the current route has been popped off.
        /// </Summary>
        public virtual void DidPop() { throw new NotImplementedException(); }


        /// <Summary>
        /// Called when a new route has been pushed, and the current route is no
        /// longer visible.
        /// </Summary>
        public virtual void DidPushNext() { throw new NotImplementedException(); }

    }
    public static class RouteAwareMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRouteAware, RouteAware> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRouteAware, RouteAware>();
        static RouteAware GetOrCreate(IRouteAware instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RouteAware();
                _table.Add(instance, value);
            }
            return (RouteAware)value;
        }
        public static void DidPopNext(this IRouteAware instance) => GetOrCreate(instance).DidPopNext();
        public static void DidPush(this IRouteAware instance) => GetOrCreate(instance).DidPush();
        public static void DidPop(this IRouteAware instance) => GetOrCreate(instance).DidPop();
        public static void DidPushNext(this IRouteAware instance) => GetOrCreate(instance).DidPushNext();
    }


    /// <Summary>
    /// A route that displays widgets in the [Navigator]'s [Overlay].
    /// </Summary>
    public class OverlayRoute<T> : FlutterSDK.Widgets.Navigator.Route<T>
    {
        #region constructors
        public OverlayRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(settings: settings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<FlutterSDK.Widgets.Overlay.OverlayEntry> _OverlayEntries { get; set; }
        public virtual List<FlutterSDK.Widgets.Overlay.OverlayEntry> OverlayEntries { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool FinishedWhenPopped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Subclasses should override this getter to return the builders for the overlay.
        /// </Summary>
        public virtual Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> CreateOverlayEntries() { throw new NotImplementedException(); }


        public new void Install() { throw new NotImplementedException(); }


        public new bool DidPop(T result) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A route with entrance and exit transitions.
    /// </Summary>
    public class TransitionRoute<T> : FlutterSDK.Widgets.Routes.OverlayRoute<T>
    {
        #region constructors
        public TransitionRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(settings: settings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Completer<T> _TransitionCompleter { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animations.ProxyAnimation _SecondaryAnimation { get; set; }
        internal virtual T _Result { get; set; }
        internal virtual VoidCallback _TrainHoppingListenerRemover { get; set; }
        public virtual Future<T> Completed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan ReverseTransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Opaque { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool FinishedWhenPopped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> SecondaryAnimation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Called to create the animation controller that will drive the transitions to
        /// this route from the previous one, and back to the previous route from this
        /// one.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController() { throw new NotImplementedException(); }


        /// <Summary>
        /// Called to create the animation that exposes the current progress of
        /// the transition controlled by the animation controller created by
        /// [createAnimationController()].
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> CreateAnimation() { throw new NotImplementedException(); }


        private void _HandleStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        public new void Install() { throw new NotImplementedException(); }


        public new FlutterSDK.Scheduler.Ticker.TickerFuture DidPush() { throw new NotImplementedException(); }


        public new void DidAdd() { throw new NotImplementedException(); }


        public new void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> oldRoute) { throw new NotImplementedException(); }


        private void _DidPushOrReplace() { throw new NotImplementedException(); }


        public new bool DidPop(T result) { throw new NotImplementedException(); }


        public new void DidPopNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute) { throw new NotImplementedException(); }


        public new void DidChangeNext(FlutterSDK.Widgets.Navigator.Route<object> nextRoute) { throw new NotImplementedException(); }


        private void _UpdateSecondaryAnimation(FlutterSDK.Widgets.Navigator.Route<object> nextRoute) { throw new NotImplementedException(); }


        private void _SetSecondaryAnimation(FlutterSDK.Animation.Animation.Animation<double> animation, Future<object> disposed = default(Future<object>)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns true if this route supports a transition animation that runs
        /// when [nextRoute] is pushed on top of it or when [nextRoute] is popped
        /// off of it.
        ///
        /// Subclasses can override this method to restrict the set of routes they
        /// need to coordinate transitions with.
        ///
        /// If true, and `nextRoute.canTransitionFrom()` is true, then the
        /// [buildTransitions] `secondaryAnimation` will run from 0.0 - 1.0
        /// when [nextRoute] is pushed on top of this one.  Similarly, if
        /// the [nextRoute] is popped off of this route, the
        /// `secondaryAnimation` will run from 1.0 - 0.0.
        ///
        /// If false, this route's [buildTransitions] `secondaryAnimation` parameter
        /// value will be [kAlwaysDismissedAnimation]. In other words, this route
        /// will not animate when when [nextRoute] is pushed on top of it or when
        /// [nextRoute] is popped off of it.
        ///
        /// Returns true by default.
        ///
        /// See also:
        ///
        ///  * [canTransitionFrom], which must be true for [nextRoute] for the
        ///    [buildTransitions] `secondaryAnimation` to run.
        /// </Summary>
        public virtual bool CanTransitionTo(FlutterSDK.Widgets.Routes.TransitionRoute<object> nextRoute) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns true if [previousRoute] should animate when this route
        /// is pushed on top of it or when then this route is popped off of it.
        ///
        /// Subclasses can override this method to restrict the set of routes they
        /// need to coordinate transitions with.
        ///
        /// If true, and `previousRoute.canTransitionTo()` is true, then the
        /// previous route's [buildTransitions] `secondaryAnimation` will
        /// run from 0.0 - 1.0 when this route is pushed on top of
        /// it. Similarly, if this route is popped off of [previousRoute]
        /// the previous route's `secondaryAnimation` will run from 1.0 - 0.0.
        ///
        /// If false, then the previous route's [buildTransitions]
        /// `secondaryAnimation` value will be kAlwaysDismissedAnimation. In
        /// other words [previousRoute] will not animate when this route is
        /// pushed on top of it or when then this route is popped off of it.
        ///
        /// Returns true by default.
        ///
        /// See also:
        ///
        ///  * [canTransitionTo], which must be true for [previousRoute] for its
        ///    [buildTransitions] `secondaryAnimation` to run.
        /// </Summary>
        public virtual bool CanTransitionFrom(FlutterSDK.Widgets.Routes.TransitionRoute<object> previousRoute) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// An entry in the history of a [LocalHistoryRoute].
    /// </Summary>
    public class LocalHistoryEntry
    {
        #region constructors
        public LocalHistoryEntry(VoidCallback onRemove = default(VoidCallback))
        {
            this.OnRemove = onRemove; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual VoidCallback OnRemove { get; set; }
        internal virtual FlutterSDK.Widgets.Routes.LocalHistoryRoute<object> _Owner { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Remove this entry from the history of its associated [LocalHistoryRoute].
        /// </Summary>
        public virtual void Remove() { throw new NotImplementedException(); }


        private void _NotifyRemoved() { throw new NotImplementedException(); }

        #endregion
    }


    public class _ModalScopeStatus : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public _ModalScopeStatus(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool isCurrent = default(bool), bool canPop = default(bool), FlutterSDK.Widgets.Navigator.Route<object> route = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.IsCurrent = isCurrent;
            this.CanPop = canPop;
            this.Route = route; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool IsCurrent { get; set; }
        public virtual bool CanPop { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.Route<object> Route { get; set; }
        #endregion

        #region methods

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Routes._ModalScopeStatus old) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ModalScope<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _ModalScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Routes.ModalRoute<T> route = default(FlutterSDK.Widgets.Routes.ModalRoute<T>))
        : base(key: key)
        {
            this.Route = route; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Routes.ModalRoute<T> Route { get; set; }
        #endregion

        #region methods

        public new _ModalScopeState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _ModalScopeState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Routes._ModalScope<T>>
    {
        #region constructors
        public _ModalScopeState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Widget _Page { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Listenable { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode FocusScopeNode { get; set; }
        internal virtual bool _ShouldIgnoreFocusRequest { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Routes._ModalScope<T> oldWidget) { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        private void _ForceRebuildPage() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _RouteSetState(VoidCallback fn) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A route that blocks interaction with previous routes.
    ///
    /// [ModalRoute]s cover the entire [Navigator]. They are not necessarily
    /// [opaque], however; for example, a pop-up menu uses a [ModalRoute] but only
    /// shows the menu in a small box overlapping the previous route.
    ///
    /// The `T` type argument is the return value of the route. If there is no
    /// return value, consider using `void` as the return value.
    /// </Summary>
    public class ModalRoute<T> : FlutterSDK.Widgets.Routes.TransitionRoute<T>, ILocalHistoryRoute<T>
    {
        #region constructors
        public ModalRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings), ImageFilter filter = default(ImageFilter))
        : base(settings: settings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual ImageFilter _Filter { get; set; }
        internal virtual bool _Offstage { get; set; }
        internal virtual FlutterSDK.Animation.Animations.ProxyAnimation _AnimationProxy { get; set; }
        internal virtual FlutterSDK.Animation.Animations.ProxyAnimation _SecondaryAnimationProxy { get; set; }
        internal virtual List<object> _WillPopCallbacks { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Routes._ModalScopeState<T>> _ScopeKey { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _SubtreeKey { get; set; }
        internal virtual FlutterSDK.Widgets.Pagestorage.PageStorageBucket _StorageBucket { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _ModalBarrier { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _ModalScopeCache { get; set; }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SemanticsDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string BarrierLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Curves.Curve BarrierCurve { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool MaintainState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Offstage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext SubtreeContext { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> SecondaryAnimation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasScopedWillPopCallback { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CanPop { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Returns the modal route most closely associated with the given context.
        ///
        /// Returns null if the given context is not associated with a modal route.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// ModalRoute route = ModalRoute.of(context);
        /// ```
        ///
        /// The given [BuildContext] will be rebuilt if the state of the route changes
        /// (specifically, if [isCurrent] or [canPop] change value).
        /// </Summary>
        public virtual ModalRoute<T> Of<T>(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        /// <Summary>
        /// Schedule a call to [buildTransitions].
        ///
        /// Whenever you need to change internal state for a [ModalRoute] object, make
        /// the change in a function that you pass to [setState], as in:
        ///
        /// ```dart
        /// setState(() { myState = newValue });
        /// ```
        ///
        /// If you just change the state directly without calling [setState], then the
        /// route will not be scheduled for rebuilding, meaning that its rendering
        /// will not be updated.
        /// </Summary>
        public virtual void SetState(VoidCallback fn) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a predicate that's true if the route has the specified name and if
        /// popping the route will not yield the same route, i.e. if the route's
        /// [willHandlePopInternally] property is false.
        ///
        /// This function is typically used with [Navigator.popUntil()].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RoutePredicate WithName(string name) { throw new NotImplementedException(); }


        /// <Summary>
        /// Override this method to build the primary content of this route.
        ///
        /// The arguments have the following meanings:
        ///
        ///  * `context`: The context in which the route is being built.
        ///  * [animation]: The animation for this route's transition. When entering,
        ///    the animation runs forward from 0.0 to 1.0. When exiting, this animation
        ///    runs backwards from 1.0 to 0.0.
        ///  * [secondaryAnimation]: The animation for the route being pushed on top of
        ///    this route. This animation lets this route coordinate with the entrance
        ///    and exit transition of routes pushed on top of this route.
        ///
        /// This method is only called when the route is first built, and rarely
        /// thereafter. In particular, it is not automatically called again when the
        /// route's state changes unless it uses [ModalRoute.of]. For a builder that
        /// is called every time the route's state changes, consider
        /// [buildTransitions]. For widgets that change their behavior when the
        /// route's state changes, consider [ModalRoute.of] to obtain a reference to
        /// the route; this will cause the widget to be rebuilt each time the route
        /// changes state.
        ///
        /// In general, [buildPage] should be used to build the page contents, and
        /// [buildTransitions] for the widgets that change as the page is brought in
        /// and out of view. Avoid using [buildTransitions] for content that never
        /// changes; building such content once from [buildPage] is more efficient.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }


        /// <Summary>
        /// Override this method to wrap the [child] with one or more transition
        /// widgets that define how the route arrives on and leaves the screen.
        ///
        /// By default, the child (which contains the widget returned by [buildPage])
        /// is not wrapped in any transition widgets.
        ///
        /// The [buildTransitions] method, in contrast to [buildPage], is called each
        /// time the [Route]'s state changes (e.g. the value of [canPop]).
        ///
        /// The [buildTransitions] method is typically used to define transitions
        /// that animate the new topmost route's comings and goings. When the
        /// [Navigator] pushes a route on the top of its stack, the new route's
        /// primary [animation] runs from 0.0 to 1.0. When the Navigator pops the
        /// topmost route, e.g. because the use pressed the back button, the
        /// primary animation runs from 1.0 to 0.0.
        ///
        /// The following example uses the primary animation to drive a
        /// [SlideTransition] that translates the top of the new route vertically
        /// from the bottom of the screen when it is pushed on the Navigator's
        /// stack. When the route is popped the SlideTransition translates the
        /// route from the top of the screen back to the bottom.
        ///
        /// ```dart
        /// PageRouteBuilder(
        ///   pageBuilder: (BuildContext context,
        ///       Animation<double> animation,
        ///       Animation<double> secondaryAnimation,
        ///       Widget child,
        ///   ) {
        ///     return Scaffold(
        ///       appBar: AppBar(title: Text('Hello')),
        ///       body: Center(
        ///         child: Text('Hello World'),
        ///       ),
        ///     );
        ///   },
        ///   transitionsBuilder: (
        ///       BuildContext context,
        ///       Animation<double> animation,
        ///       Animation<double> secondaryAnimation,
        ///       Widget child,
        ///    ) {
        ///     return SlideTransition(
        ///       position: Tween<Offset>(
        ///         begin: const Offset(0.0, 1.0),
        ///         end: Offset.zero,
        ///       ).animate(animation),
        ///       child: child, // child is the value returned by pageBuilder
        ///     );
        ///   },
        /// );
        /// ```
        ///
        /// We've used [PageRouteBuilder] to demonstrate the [buildTransitions] method
        /// here. The body of an override of the [buildTransitions] method would be
        /// defined in the same way.
        ///
        /// When the [Navigator] pushes a route on the top of its stack, the
        /// [secondaryAnimation] can be used to define how the route that was on
        /// the top of the stack leaves the screen. Similarly when the topmost route
        /// is popped, the secondaryAnimation can be used to define how the route
        /// below it reappears on the screen. When the Navigator pushes a new route
        /// on the top of its stack, the old topmost route's secondaryAnimation
        /// runs from 0.0 to 1.0. When the Navigator pops the topmost route, the
        /// secondaryAnimation for the route below it runs from 1.0 to 0.0.
        ///
        /// The example below adds a transition that's driven by the
        /// [secondaryAnimation]. When this route disappears because a new route has
        /// been pushed on top of it, it translates in the opposite direction of
        /// the new route. Likewise when the route is exposed because the topmost
        /// route has been popped off.
        ///
        /// ```dart
        ///   transitionsBuilder: (
        ///       BuildContext context,
        ///       Animation<double> animation,
        ///       Animation<double> secondaryAnimation,
        ///       Widget child,
        ///   ) {
        ///     return SlideTransition(
        ///       position: AlignmentTween(
        ///         begin: const Offset(0.0, 1.0),
        ///         end: Offset.zero,
        ///       ).animate(animation),
        ///       child: SlideTransition(
        ///         position: TweenOffset(
        ///           begin: Offset.zero,
        ///           end: const Offset(0.0, 1.0),
        ///         ).animate(secondaryAnimation),
        ///         child: child,
        ///       ),
        ///     );
        ///   }
        /// ```
        ///
        /// In practice the `secondaryAnimation` is used pretty rarely.
        ///
        /// The arguments to this method are as follows:
        ///
        ///  * `context`: The context in which the route is being built.
        ///  * [animation]: When the [Navigator] pushes a route on the top of its stack,
        ///    the new route's primary [animation] runs from 0.0 to 1.0. When the [Navigator]
        ///    pops the topmost route this animation runs from 1.0 to 0.0.
        ///  * [secondaryAnimation]: When the Navigator pushes a new route
        ///    on the top of its stack, the old topmost route's [secondaryAnimation]
        ///    runs from 0.0 to 1.0. When the [Navigator] pops the topmost route, the
        ///    [secondaryAnimation] for the route below it runs from 1.0 to 0.0.
        ///  * `child`, the page contents, as returned by [buildPage].
        ///
        /// See also:
        ///
        ///  * [buildPage], which is used to describe the actual contents of the page,
        ///    and whose result is passed to the `child` argument of this method.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        public new void Install() { throw new NotImplementedException(); }


        public new FlutterSDK.Scheduler.Ticker.TickerFuture DidPush() { throw new NotImplementedException(); }


        public new void DidAdd() { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the value of the first callback added with
        /// [addScopedWillPopCallback] that returns false. If they all return true,
        /// returns the inherited method's result (see [Route.willPop]).
        ///
        /// Typically this method is not overridden because applications usually
        /// don't create modal routes directly, they use higher level primitives
        /// like [showDialog]. The scoped [WillPopCallback] list makes it possible
        /// for ModalRoute descendants to collectively define the value of `willPop`.
        ///
        /// See also:
        ///
        ///  * [Form], which provides an `onWillPop` callback that uses this mechanism.
        ///  * [addScopedWillPopCallback], which adds a callback to the list this
        ///    method checks.
        ///  * [removeScopedWillPopCallback], which removes a callback from the list
        ///    this method checks.
        /// </Summary>
        public new Future<FlutterSDK.Widgets.Navigator.RoutePopDisposition> WillPop() { throw new NotImplementedException(); }


        /// <Summary>
        /// Enables this route to veto attempts by the user to dismiss it.
        ///
        /// This callback is typically added using a [WillPopScope] widget. That
        /// widget finds the enclosing [ModalRoute] and uses this function to register
        /// this callback:
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return WillPopScope(
        ///     onWillPop: askTheUserIfTheyAreSure,
        ///     child: ...,
        ///   );
        /// }
        /// ```
        ///
        /// This callback runs asynchronously and it's possible that it will be called
        /// after its route has been disposed. The callback should check [State.mounted]
        /// before doing anything.
        ///
        /// A typical application of this callback would be to warn the user about
        /// unsaved [Form] data if the user attempts to back out of the form. In that
        /// case, use the [Form.onWillPop] property to register the callback.
        ///
        /// To register a callback manually, look up the enclosing [ModalRoute] in a
        /// [State.didChangeDependencies] callback:
        ///
        /// ```dart
        /// ModalRoute<dynamic> _route;
        ///
        /// @override
        /// void didChangeDependencies() {
        ///  super.didChangeDependencies();
        ///  _route?.removeScopedWillPopCallback(askTheUserIfTheyAreSure);
        ///  _route = ModalRoute.of(context);
        ///  _route?.addScopedWillPopCallback(askTheUserIfTheyAreSure);
        /// }
        /// ```
        ///
        /// If you register a callback manually, be sure to remove the callback with
        /// [removeScopedWillPopCallback] by the time the widget has been disposed. A
        /// stateful widget can do this in its dispose method (continuing the previous
        /// example):
        ///
        /// ```dart
        /// @override
        /// void dispose() {
        ///   _route?.removeScopedWillPopCallback(askTheUserIfTheyAreSure);
        ///   _route = null;
        ///   super.dispose();
        /// }
        /// ```
        ///
        /// See also:
        ///
        ///  * [WillPopScope], which manages the registration and unregistration
        ///    process automatically.
        ///  * [Form], which provides an `onWillPop` callback that uses this mechanism.
        ///  * [willPop], which runs the callbacks added with this method.
        ///  * [removeScopedWillPopCallback], which removes a callback from the list
        ///    that [willPop] checks.
        /// </Summary>
        public virtual void AddScopedWillPopCallback(FlutterSDK.Widgets.Navigator.WillPopCallback callback) { throw new NotImplementedException(); }


        /// <Summary>
        /// Remove one of the callbacks run by [willPop].
        ///
        /// See also:
        ///
        ///  * [Form], which provides an `onWillPop` callback that uses this mechanism.
        ///  * [addScopedWillPopCallback], which adds callback to the list
        ///    checked by [willPop].
        /// </Summary>
        public virtual void RemoveScopedWillPopCallback(FlutterSDK.Widgets.Navigator.WillPopCallback callback) { throw new NotImplementedException(); }


        public new void DidChangePrevious(FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public new void ChangedInternalState() { throw new NotImplementedException(); }


        public new void ChangedExternalState() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildModalBarrier(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildModalScope(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> CreateOverlayEntries() { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// A modal route that overlays a widget over the current route.
    /// </Summary>
    public class PopupRoute<T> : FlutterSDK.Widgets.Routes.ModalRoute<T>
    {
        #region constructors
        public PopupRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings), ImageFilter filter = default(ImageFilter))
        : base(filter: filter, settings: settings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Opaque { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool MaintainState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A [Navigator] observer that notifies [RouteAware]s of changes to the
    /// state of their [Route].
    ///
    /// [RouteObserver] informs subscribers whenever a route of type `R` is pushed
    /// on top of their own route of type `R` or popped from it. This is for example
    /// useful to keep track of page transitions, e.g. a `RouteObserver<PageRoute>`
    /// will inform subscribed [RouteAware]s whenever the user navigates away from
    /// the current page route to another page route.
    ///
    /// To be informed about route changes of any type, consider instantiating a
    /// `RouteObserver<Route>`.
    ///
    /// ## Type arguments
    ///
    /// When using more aggressive
    /// [lints](http://dart-lang.github.io/linter/lints/), in particular lints such
    /// as `always_specify_types`, the Dart analyzer will require that certain types
    /// be given with their type arguments. Since the [Route] class and its
    /// subclasses have a type argument, this includes the arguments passed to this
    /// class. Consider using `dynamic` to specify the entire class of routes rather
    /// than only specific subtypes. For example, to watch for all [PageRoute]
    /// variants, the `RouteObserver<PageRoute<dynamic>>` type may be used.
    ///
    /// {@tool snippet}
    ///
    /// To make a [StatefulWidget] aware of its current [Route] state, implement
    /// [RouteAware] in its [State] and subscribe it to a [RouteObserver]:
    ///
    /// ```dart
    /// // Register the RouteObserver as a navigation observer.
    /// final RouteObserver<PageRoute> routeObserver = RouteObserver<PageRoute>();
    /// void main() {
    ///   runApp(MaterialApp(
    ///     home: Container(),
    ///     navigatorObservers: [routeObserver],
    ///   ));
    /// }
    ///
    /// class RouteAwareWidget extends StatefulWidget {
    ///   State<RouteAwareWidget> createState() => RouteAwareWidgetState();
    /// }
    ///
    /// // Implement RouteAware in a widget's state and subscribe it to the RouteObserver.
    /// class RouteAwareWidgetState extends State<RouteAwareWidget> with RouteAware {
    ///
    ///   @override
    ///   void didChangeDependencies() {
    ///     super.didChangeDependencies();
    ///     routeObserver.subscribe(this, ModalRoute.of(context));
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     routeObserver.unsubscribe(this);
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   void didPush() {
    ///     // Route was pushed onto navigator and is now topmost route.
    ///   }
    ///
    ///   @override
    ///   void didPopNext() {
    ///     // Covering route was popped off the navigator.
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) => Container();
    ///
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class RouteObserver<R> : FlutterSDK.Widgets.Navigator.NavigatorObserver
    {
        #region constructors
        public RouteObserver()
        { }
        #endregion

        #region fields
        internal virtual Dictionary<R, HashSet<FlutterSDK.Widgets.Routes.RouteAware>> _Listeners { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Subscribe [routeAware] to be informed about changes to [route].
        ///
        /// Going forward, [routeAware] will be informed about qualifying changes
        /// to [route], e.g. when [route] is covered by another route or when [route]
        /// is popped off the [Navigator] stack.
        /// </Summary>
        public virtual void Subscribe(FlutterSDK.Widgets.Routes.RouteAware routeAware, R route) { throw new NotImplementedException(); }


        /// <Summary>
        /// Unsubscribe [routeAware].
        ///
        /// [routeAware] is no longer informed about changes to its route. If the given argument was
        /// subscribed to multiple types, this will unregister it (once) from each type.
        /// </Summary>
        public virtual void Unsubscribe(FlutterSDK.Widgets.Routes.RouteAware routeAware) { throw new NotImplementedException(); }


        public new void DidPop(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }


        public new void DidPush(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DialogRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
    {
        #region constructors
        public _DialogRoute(FlutterSDK.Widgets.Routes.RoutePageBuilder pageBuilder = default(FlutterSDK.Widgets.Routes.RoutePageBuilder), bool barrierDismissible = true, string barrierLabel = default(string), FlutterBinding.UI.Color barrierColor = default(FlutterBinding.UI.Color), TimeSpan transitionDuration = default(TimeSpan), FlutterSDK.Widgets.Routes.RouteTransitionsBuilder transitionBuilder = default(FlutterSDK.Widgets.Routes.RouteTransitionsBuilder), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(settings: settings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Routes.RoutePageBuilder _PageBuilder { get; set; }
        internal virtual bool _BarrierDismissible { get; set; }
        internal virtual string _BarrierLabel { get; set; }
        internal virtual FlutterBinding.UI.Color _BarrierColor { get; set; }
        internal virtual TimeSpan _TransitionDuration { get; set; }
        internal virtual FlutterSDK.Widgets.Routes.RouteTransitionsBuilder _TransitionBuilder { get; set; }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string BarrierLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }

        #endregion
    }

}
