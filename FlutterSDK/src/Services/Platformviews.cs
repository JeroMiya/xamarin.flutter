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
namespace FlutterSDK.Services.Platformviews
{
    /// <Summary>
    /// Callback signature for when a platform view was created.
    ///
    /// `id` is the platform view's unique identifier.
    /// </Summary>
    public delegate void PlatformViewCreatedCallback(int id);
    internal static class PlatformviewsDefaultClass
    {
        public static FlutterSDK.Services.Platformviews.PlatformViewsRegistry PlatformViewsRegistry = default(FlutterSDK.Services.Platformviews.PlatformViewsRegistry);
    }

    public interface IPlatformViewController { }

    public class PlatformViewController
    {
        public virtual int ViewId { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Dispatches the `event` to the platform view.
        /// </Summary>
        public virtual void DispatchPointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
        }


        /// <Summary>
        /// Disposes the platform view.
        ///
        /// The [PlatformViewController] is unusable after calling dispose.
        /// </Summary>
        public virtual void Dispose()
        {
        }


        /// <Summary>
        /// Clears the view's focus on the platform side.
        /// </Summary>
        public virtual void ClearFocus()
        {
        }

    }
    public static class PlatformViewControllerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IPlatformViewController, PlatformViewController> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IPlatformViewController, PlatformViewController>();
        static PlatformViewController GetOrCreate(IPlatformViewController instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new PlatformViewController();
                _table.Add(instance, value);
            }
            return (PlatformViewController)value;
        }
        public static int ViewIdProperty(this IPlatformViewController instance) => GetOrCreate(instance).ViewId;
        public static void DispatchPointerEvent(this IPlatformViewController instance, FlutterSDK.Gestures.Events.PointerEvent @event) => GetOrCreate(instance).DispatchPointerEvent(@event);
        public static void Dispose(this IPlatformViewController instance) => GetOrCreate(instance).Dispose();
        public static void ClearFocus(this IPlatformViewController instance) => GetOrCreate(instance).ClearFocus();
    }


    /// <Summary>
    /// A registry responsible for generating unique identifier for platform views.
    ///
    /// A Flutter application has a single [PlatformViewsRegistry] which can be accesses
    /// through the [platformViewsRegistry] getter.
    /// </Summary>
    public class PlatformViewsRegistry
    {
        internal static PlatformViewsRegistry _Instance()
        {
            var instance = new PlatformViewsRegistry();
        }
        internal virtual int _NextPlatformViewId { get; set; }

        /// <Summary>
        /// Allocates a unique identifier for a platform view.
        ///
        /// A platform view identifier can refer to a platform view that was never created,
        /// a platform view that was disposed, or a platform view that is alive.
        ///
        /// Typically a platform view identifier is passed to a [PlatformView] widget
        /// which creates the platform view and manages its lifecycle.
        /// </Summary>
        public virtual int GetNextPlatformViewId() => _NextPlatformViewId++;


    }


    /// <Summary>
    /// Provides access to the platform views service.
    ///
    /// This service allows creating and controlling platform-specific views.
    /// </Summary>
    public class PlatformViewsService
    {
        internal PlatformViewsService()
        {

            SystemchannelsDefaultClass.SystemChannels.Platform_views.SetMethodCallHandler(_OnMethodCall);
        }


        internal virtual FlutterSDK.Services.Platformviews.PlatformViewsService _ServiceInstance { get; set; }
        /// <Summary>
        /// Maps platform view IDs to focus callbacks.
        ///
        /// The callbacks are invoked when the platform view asks to be focused.
        /// </Summary>
        internal virtual Dictionary<int, object> _FocusCallbacks { get; set; }
        internal virtual FlutterSDK.Services.Platformviews.PlatformViewsService _Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private Future<object> _OnMethodCall(FlutterSDK.Services.Messagecodec.MethodCall call)
        {
            switch (call.Method)
            {
                case "viewFocused":
                    int id = call.Arguments as int; if (_FocusCallbacks.ContainsKey(id))
                    {
                        _FocusCallbacks[id]();
                    }
                    break;
                default:
                    throw new UnimplementedError($""{ call.Method } was invoked but isn't implemented by PlatformViewsService"");}
            return null;
            }




/// <Summary>
/// Creates a controller for a new Android view.
///
/// `id` is an unused unique identifier generated with [platformViewsRegistry].
///
/// `viewType` is the identifier of the Android view type to be created, a
/// factory for this view type must have been registered on the platform side.
/// Platform view factories are typically registered by plugin code.
/// Plugins can register a platform view factory with
/// [PlatformViewRegistry#registerViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewRegistry.html#registerViewFactory-java.lang.String-io.flutter.plugin.platform.PlatformViewFactory-).
///
/// `creationParams` will be passed as the args argument of [PlatformViewFactory#create](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html#create-android.content.Context-int-java.lang.Object-)
///
/// `creationParamsCodec` is the codec used to encode `creationParams` before sending it to the
/// platform side. It should match the codec passed to the constructor of [PlatformViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html#PlatformViewFactory-io.flutter.plugin.common.MessageCodec-).
/// This is typically one of: [StandardMessageCodec], [JSONMessageCodec], [StringCodec], or [BinaryCodec].
///
/// `onFocus` is a callback that will be invoked when the Android View asks to get the
/// input focus.
///
/// The Android view will only be created after [AndroidViewController.setSize] is called for the
/// first time.
///
/// The `id, `viewType, and `layoutDirection` parameters must not be null.
/// If `creationParams` is non null then `cretaionParamsCodec` must not be null.
/// </Summary>
        public virtual FlutterSDK.Services.Platformviews.AndroidViewController InitAndroidView(int id = default(int), string viewType = default(string), TextDirection layoutDirection = default(TextDirection), object creationParams = default(object), FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec = default(FlutterSDK.Services.Messagecodec.MessageCodec<object>), VoidCallback onFocus = default(VoidCallback))
        {




            AndroidViewController controller = AndroidViewController._(id, viewType, creationParams, creationParamsCodec, layoutDirection);
            _Instance._FocusCallbacks[id] = onFocus ?? () => {
            }
;
            return controller;
        }




        /// <Summary>
        /// This is work in progress, not yet ready to be used, and requires a custom engine build. Creates a controller for a new iOS UIView.
        ///
        /// `id` is an unused unique identifier generated with [platformViewsRegistry].
        ///
        /// `viewType` is the identifier of the iOS view type to be created, a
        /// factory for this view type must have been registered on the platform side.
        /// Platform view factories are typically registered by plugin code.
        ///
        /// The `id, `viewType, and `layoutDirection` parameters must not be null.
        /// If `creationParams` is non null then `creationParamsCodec` must not be null.
        /// </Summary>
        public virtual async Future<FlutterSDK.Services.Platformviews.UiKitViewController> InitUiKitView(int id = default(int), string viewType = default(string), TextDirection layoutDirection = default(TextDirection), object creationParams = default(object), FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec = default(FlutterSDK.Services.Messagecodec.MessageCodec<object>))
        {




            Dictionary<string, object> args = new Dictionary<string, object> { { "id", id }{ "viewType", viewType } };
            if (creationParams != null)
            {
                ByteData paramsByteData = creationParamsCodec.EncodeMessage(creationParams);
                args["params"] = Uint8List.View(paramsByteData.Buffer, 0, paramsByteData.LengthInBytes);
            }

            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("create", args);
            return UiKitViewController._(id, layoutDirection);
        }



    }


    /// <Summary>
    /// Properties of an Android pointer.
    ///
    /// A Dart version of Android's [MotionEvent.PointerProperties](https://developer.android.com/reference/android/view/MotionEvent.PointerProperties).
    /// </Summary>
    public class AndroidPointerProperties
    {
        /// <Summary>
        /// Creates an AndroidPointerProperties.
        ///
        /// All parameters must not be null.
        /// </Summary>
        public AndroidPointerProperties(int id = default(int), int toolType = default(int))
        : base()
        {
            this.Id = id;
            this.ToolType = toolType;
        }
        /// <Summary>
        /// See Android's [MotionEvent.PointerProperties#id](https://developer.android.com/reference/android/view/MotionEvent.PointerProperties.html#id).
        /// </Summary>
        public virtual int Id { get; set; }
        /// <Summary>
        /// The type of tool used to make contact such as a finger or stylus, if known.
        /// See Android's [MotionEvent.PointerProperties#toolType](https://developer.android.com/reference/android/view/MotionEvent.PointerProperties.html#toolType).
        /// </Summary>
        public virtual int ToolType { get; set; }
        /// <Summary>
        /// Value for `toolType` when the tool type is unknown.
        /// </Summary>
        public virtual int KToolTypeUnknown { get; set; }
        /// <Summary>
        /// Value for `toolType` when the tool type is a finger.
        /// </Summary>
        public virtual int KToolTypeFinger { get; set; }
        /// <Summary>
        /// Value for `toolType` when the tool type is a stylus.
        /// </Summary>
        public virtual int KToolTypeStylus { get; set; }
        /// <Summary>
        /// Value for `toolType` when the tool type is a mouse.
        /// </Summary>
        public virtual int KToolTypeMouse { get; set; }
        /// <Summary>
        /// Value for `toolType` when the tool type is an eraser.
        /// </Summary>
        public virtual int KToolTypeEraser { get; set; }

        private List<int> _AsList() => new List<int>() { Id, ToolType };



    }


    /// <Summary>
    /// Position information for an Android pointer.
    ///
    /// A Dart version of Android's [MotionEvent.PointerCoords](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords).
    /// </Summary>
    public class AndroidPointerCoords
    {
        /// <Summary>
        /// Creates an AndroidPointerCoords.
        ///
        /// All parameters must not be null.
        /// </Summary>
        public AndroidPointerCoords(double orientation = default(double), double pressure = default(double), double size = default(double), double toolMajor = default(double), double toolMinor = default(double), double touchMajor = default(double), double touchMinor = default(double), double x = default(double), double y = default(double))
        : base()
        {
            this.Orientation = orientation;
            this.Pressure = pressure;
            this.Size = size;
            this.ToolMajor = toolMajor;
            this.ToolMinor = toolMinor;
            this.TouchMajor = touchMajor;
            this.TouchMinor = touchMinor;
            this.x = x;
            this.y = y;
        }
        /// <Summary>
        /// The orientation of the touch area and tool area in radians clockwise from vertical.
        ///
        /// See Android's [MotionEvent.PointerCoords#orientation](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#orientation).
        /// </Summary>
        public virtual double Orientation { get; set; }
        /// <Summary>
        /// A normalized value that describes the pressure applied to the device by a finger or other tool.
        ///
        /// See Android's [MotionEvent.PointerCoords#pressure](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#pressure).
        /// </Summary>
        public virtual double Pressure { get; set; }
        /// <Summary>
        /// A normalized value that describes the approximate size of the pointer touch area in relation to the maximum detectable size of the device.
        ///
        /// See Android's [MotionEvent.PointerCoords#size](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#size).
        /// </Summary>
        public virtual double Size { get; set; }
        /// <Summary>
        /// See Android's [MotionEvent.PointerCoords#toolMajor](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#toolMajor).
        /// </Summary>
        public virtual double ToolMajor { get; set; }
        /// <Summary>
        /// See Android's [MotionEvent.PointerCoords#toolMinor](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#toolMinor).
        /// </Summary>
        public virtual double ToolMinor { get; set; }
        /// <Summary>
        /// See Android's [MotionEvent.PointerCoords#touchMajor](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#touchMajor).
        /// </Summary>
        public virtual double TouchMajor { get; set; }
        /// <Summary>
        /// See Android's [MotionEvent.PointerCoords#touchMinor](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#touchMinor).
        /// </Summary>
        public virtual double TouchMinor { get; set; }
        /// <Summary>
        /// The X component of the pointer movement.
        ///
        /// See Android's [MotionEvent.PointerCoords#x](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#x).
        /// </Summary>
        public virtual double x { get; set; }
        /// <Summary>
        /// The Y component of the pointer movement.
        ///
        /// See Android's [MotionEvent.PointerCoords#y](https://developer.android.com/reference/android/view/MotionEvent.PointerCoords.html#y).
        /// </Summary>
        public virtual double y { get; set; }

        private List<double> _AsList()
        {
            return new List<double>() { Orientation, Pressure, Size, ToolMajor, ToolMinor, TouchMajor, TouchMinor, x, y };
        }




    }


    /// <Summary>
    /// A Dart version of Android's [MotionEvent](https://developer.android.com/reference/android/view/MotionEvent).
    /// </Summary>
    public class AndroidMotionEvent
    {
        /// <Summary>
        /// Creates an AndroidMotionEvent.
        ///
        /// All parameters must not be null.
        /// </Summary>
        public AndroidMotionEvent(int downTime = default(int), int eventTime = default(int), int action = default(int), int pointerCount = default(int), List<FlutterSDK.Services.Platformviews.AndroidPointerProperties> pointerProperties = default(List<FlutterSDK.Services.Platformviews.AndroidPointerProperties>), List<FlutterSDK.Services.Platformviews.AndroidPointerCoords> pointerCoords = default(List<FlutterSDK.Services.Platformviews.AndroidPointerCoords>), int metaState = default(int), int buttonState = default(int), double xPrecision = default(double), double yPrecision = default(double), int deviceId = default(int), int edgeFlags = default(int), int source = default(int), int flags = default(int))
        : base()
        {
            this.DownTime = downTime;
            this.EventTime = eventTime;
            this.Action = action;
            this.PointerCount = pointerCount;
            this.PointerProperties = pointerProperties;
            this.PointerCoords = pointerCoords;
            this.MetaState = metaState;
            this.ButtonState = buttonState;
            this.XPrecision = xPrecision;
            this.YPrecision = yPrecision;
            this.DeviceId = deviceId;
            this.EdgeFlags = edgeFlags;
            this.Source = source;
            this.Flags = flags;
        }
        /// <Summary>
        /// The time (in ms) when the user originally pressed down to start a stream of position events,
        /// relative to an arbitrary timeline.
        ///
        /// See Android's [MotionEvent#getDownTime](https://developer.android.com/reference/android/view/MotionEvent.html#getDownTime()).
        /// </Summary>
        public virtual int DownTime { get; set; }
        /// <Summary>
        /// The time this event occurred, relative to an arbitrary timeline.
        ///
        /// See Android's [MotionEvent#getEventTime](https://developer.android.com/reference/android/view/MotionEvent.html#getEventTime()).
        /// </Summary>
        public virtual int EventTime { get; set; }
        /// <Summary>
        /// A value representing the kind of action being performed.
        ///
        /// See Android's [MotionEvent#getAction](https://developer.android.com/reference/android/view/MotionEvent.html#getAction()).
        /// </Summary>
        public virtual int Action { get; set; }
        /// <Summary>
        /// The number of pointers that are part of this event.
        /// This must be equivalent to the length of `pointerProperties` and `pointerCoords`.
        ///
        /// See Android's [MotionEvent#getPointerCount](https://developer.android.com/reference/android/view/MotionEvent.html#getPointerCount()).
        /// </Summary>
        public virtual int PointerCount { get; set; }
        /// <Summary>
        /// List of [AndroidPointerProperties] for each pointer that is part of this event.
        /// </Summary>
        public virtual List<FlutterSDK.Services.Platformviews.AndroidPointerProperties> PointerProperties { get; set; }
        /// <Summary>
        /// List of [AndroidPointerCoords] for each pointer that is part of this event.
        /// </Summary>
        public virtual List<FlutterSDK.Services.Platformviews.AndroidPointerCoords> PointerCoords { get; set; }
        /// <Summary>
        /// The state of any meta / modifier keys that were in effect when the event was generated.
        ///
        /// See Android's [MotionEvent#getMetaState](https://developer.android.com/reference/android/view/MotionEvent.html#getMetaState()).
        /// </Summary>
        public virtual int MetaState { get; set; }
        /// <Summary>
        /// The state of all buttons that are pressed such as a mouse or stylus button.
        ///
        /// See Android's [MotionEvent#getButtonState](https://developer.android.com/reference/android/view/MotionEvent.html#getButtonState()).
        /// </Summary>
        public virtual int ButtonState { get; set; }
        /// <Summary>
        /// The precision of the X coordinates being reported, in physical pixels.
        ///
        /// See Android's [MotionEvent#getXPrecision](https://developer.android.com/reference/android/view/MotionEvent.html#getXPrecision()).
        /// </Summary>
        public virtual double XPrecision { get; set; }
        /// <Summary>
        /// The precision of the Y coordinates being reported, in physical pixels.
        ///
        /// See Android's [MotionEvent#getYPrecision](https://developer.android.com/reference/android/view/MotionEvent.html#getYPrecision()).
        /// </Summary>
        public virtual double YPrecision { get; set; }
        /// <Summary>
        /// See Android's [MotionEvent#getDeviceId](https://developer.android.com/reference/android/view/MotionEvent.html#getDeviceId()).
        /// </Summary>
        public virtual int DeviceId { get; set; }
        /// <Summary>
        /// A bit field indicating which edges, if any, were touched by this MotionEvent.
        ///
        /// See Android's [MotionEvent#getEdgeFlags](https://developer.android.com/reference/android/view/MotionEvent.html#getEdgeFlags()).
        /// </Summary>
        public virtual int EdgeFlags { get; set; }
        /// <Summary>
        /// The source of this event (e.g a touchpad or stylus).
        ///
        /// See Android's [MotionEvent#getSource](https://developer.android.com/reference/android/view/MotionEvent.html#getSource()).
        /// </Summary>
        public virtual int Source { get; set; }
        /// <Summary>
        /// See Android's [MotionEvent#getFlags](https://developer.android.com/reference/android/view/MotionEvent.html#getFlags()).
        /// </Summary>
        public virtual int Flags { get; set; }

        private List<object> _AsList(int viewId)
        {
            return new List<object>() { viewId, DownTime, EventTime, Action, PointerCount, PointerProperties.Map((AndroidPointerProperties p) => =>p._AsList()).ToList(), PointerCoords.Map((AndroidPointerCoords p) => =>p._AsList()).ToList(), MetaState, ButtonState, XPrecision, YPrecision, DeviceId, EdgeFlags, Source, Flags };
        }




    }


    /// <Summary>
    /// Controls an Android view.
    ///
    /// Typically created with [PlatformViewsService.initAndroidView].
    /// </Summary>
    public class AndroidViewController
    {
        internal AndroidViewController(int id, string viewType, object creationParams, FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec, TextDirection layoutDirection)
        : base()
        {
            this.Id = id;
        }
        /// <Summary>
        /// Action code for when a primary pointer touched the screen.
        ///
        /// Android's [MotionEvent.ACTION_DOWN](https://developer.android.com/reference/android/view/MotionEvent#ACTION_DOWN)
        /// </Summary>
        public virtual int KActionDown { get; set; }
        /// <Summary>
        /// Action code for when a primary pointer stopped touching the screen.
        ///
        /// Android's [MotionEvent.ACTION_UP](https://developer.android.com/reference/android/view/MotionEvent#ACTION_UP)
        /// </Summary>
        public virtual int KActionUp { get; set; }
        /// <Summary>
        /// Action code for when the event only includes information about pointer movement.
        ///
        /// Android's [MotionEvent.ACTION_MOVE](https://developer.android.com/reference/android/view/MotionEvent#ACTION_MOVE)
        /// </Summary>
        public virtual int KActionMove { get; set; }
        /// <Summary>
        /// Action code for when a motion event has been canceled.
        ///
        /// Android's [MotionEvent.ACTION_CANCEL](https://developer.android.com/reference/android/view/MotionEvent#ACTION_CANCEL)
        /// </Summary>
        public virtual int KActionCancel { get; set; }
        /// <Summary>
        /// Action code for when a secondary pointer touched the screen.
        ///
        /// Android's [MotionEvent.ACTION_POINTER_DOWN](https://developer.android.com/reference/android/view/MotionEvent#ACTION_POINTER_DOWN)
        /// </Summary>
        public virtual int KActionPointerDown { get; set; }
        /// <Summary>
        /// Action code for when a secondary pointer stopped touching the screen.
        ///
        /// Android's [MotionEvent.ACTION_POINTER_UP](https://developer.android.com/reference/android/view/MotionEvent#ACTION_POINTER_UP)
        /// </Summary>
        public virtual int KActionPointerUp { get; set; }
        /// <Summary>
        /// Android's [View.LAYOUT_DIRECTION_LTR](https://developer.android.com/reference/android/view/View.html#LAYOUT_DIRECTION_LTR) value.
        /// </Summary>
        public virtual int KAndroidLayoutDirectionLtr { get; set; }
        /// <Summary>
        /// Android's [View.LAYOUT_DIRECTION_RTL](https://developer.android.com/reference/android/view/View.html#LAYOUT_DIRECTION_RTL) value.
        /// </Summary>
        public virtual int KAndroidLayoutDirectionRtl { get; set; }
        /// <Summary>
        /// The unique identifier of the Android view controlled by this controller.
        /// </Summary>
        public virtual int Id { get; set; }
        internal virtual string _ViewType { get; set; }
        /// <Summary>
        /// The texture entry id into which the Android view is rendered.
        /// </Summary>
        internal virtual int _TextureId { get; set; }
        internal virtual TextDirection _LayoutDirection { get; set; }
        internal virtual FlutterSDK.Services.Platformviews._AndroidViewState _State { get; set; }
        internal virtual object _CreationParams { get; set; }
        internal virtual FlutterSDK.Services.Messagecodec.MessageCodec<object> _CreationParamsCodec { get; set; }
        internal virtual List<object> _PlatformViewCreatedCallbacks { get; set; }
        public virtual int TextureId { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsCreated { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Adds a callback that will get invoke after the platform view has been
        /// created.
        /// </Summary>
        public virtual void AddOnPlatformViewCreatedListener(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback listener)
        {


            _PlatformViewCreatedCallbacks.Add(listener);
        }




        /// <Summary>
        /// Removes a callback added with [addOnPlatformViewCreatedListener].
        /// </Summary>
        public virtual void RemoveOnPlatformViewCreatedListener(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback listener)
        {

            _PlatformViewCreatedCallbacks.Remove(listener);
        }




        /// <Summary>
        /// Disposes the Android view.
        ///
        /// The [AndroidViewController] object is unusable after calling this.
        /// The identifier of the platform view cannot be reused after the view is
        /// disposed.
        /// </Summary>
        public virtual async Future<object> Dispose()
        {
            if (_State == _AndroidViewState.Creating || _State == _AndroidViewState.Created) await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("dispose", Id);
            _PlatformViewCreatedCallbacks.Clear();
            _State = _AndroidViewState.Disposed;
        }




        /// <Summary>
        /// Sizes the Android View.
        ///
        /// `size` is the view's new size in logical pixel, it must not be null and must
        /// be bigger than zero.
        ///
        /// The first time a size is set triggers the creation of the Android view.
        /// </Summary>
        public virtual async Future<object> SetSize(Size size)
        {



            if (_State == _AndroidViewState.WaitingForSize) return _Create(size);
            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("resize", new Dictionary<string, object> { { "id", Id }{ "width", size.Width }{ "height", size.Height } });
        }




        /// <Summary>
        /// Sets the layout direction for the Android view.
        /// </Summary>
        public virtual async Future<object> SetLayoutDirection(TextDirection layoutDirection)
        {

            if (layoutDirection == _LayoutDirection) return;

            _LayoutDirection = layoutDirection;
            if (_State == _AndroidViewState.WaitingForSize) return;
            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("setDirection", new Dictionary<string, object> { { "id", Id }{ "direction", _GetAndroidDirection(layoutDirection) } });
        }




        /// <Summary>
        /// Clears the focus from the Android View if it is focused.
        /// </Summary>
        public virtual Future<object> ClearFocus()
        {
            if (_State != _AndroidViewState.Created)
            {
                return null;
            }

            return SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("clearFocus", Id);
        }




        private int _GetAndroidDirection(TextDirection direction)
        {

            switch (direction) { case TextDirection.Ltr: return KAndroidLayoutDirectionLtr; case TextDirection.Rtl: return KAndroidLayoutDirectionRtl; }
            return null;
        }




        /// <Summary>
        /// Sends an Android [MotionEvent](https://developer.android.com/reference/android/view/MotionEvent)
        /// to the view.
        ///
        /// The Android MotionEvent object is created with [MotionEvent.obtain](https://developer.android.com/reference/android/view/MotionEvent.html#obtain(long,%20long,%20int,%20float,%20float,%20float,%20float,%20int,%20float,%20float,%20int,%20int)).
        /// See documentation of [MotionEvent.obtain](https://developer.android.com/reference/android/view/MotionEvent.html#obtain(long,%20long,%20int,%20float,%20float,%20float,%20float,%20int,%20float,%20float,%20int,%20int))
        /// for description of the parameters.
        /// </Summary>
        public virtual async Future<object> SendMotionEvent(FlutterSDK.Services.Platformviews.AndroidMotionEvent @event)
        {
            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("touch", @event._AsList(Id));
        }




        /// <Summary>
        /// Creates a masked Android MotionEvent action value for an indexed pointer.
        /// </Summary>
        public virtual int PointerAction(int pointerId, int action)
        {
            return ((pointerId << 8) & 0xff00) | (action & 0xff);
        }




        private async Future<object> _Create(Size size)
        {
            Dictionary<string, object> args = new Dictionary<string, object> { { "id", Id }{ "viewType", _ViewType }{ "width", size.Width }{ "height", size.Height }{ "direction", _GetAndroidDirection(_LayoutDirection) } };
            if (_CreationParams != null)
            {
                ByteData paramsByteData = _CreationParamsCodec.EncodeMessage(_CreationParams);
                args["params"] = Uint8List.View(paramsByteData.Buffer, 0, paramsByteData.LengthInBytes);
            }

            _TextureId = await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("create", args);
            _State = _AndroidViewState.Created;
            foreach (PlatformViewCreatedCallback callback in _PlatformViewCreatedCallbacks)
            {
                callback(Id);
            }

        }



    }


    /// <Summary>
    /// Controls an iOS UIView.
    ///
    /// Typically created with [PlatformViewsService.initUiKitView].
    /// </Summary>
    public class UiKitViewController
    {
        internal UiKitViewController(int id, TextDirection layoutDirection)
        : base()
        {
            this.Id = id;
        }
        /// <Summary>
        /// The unique identifier of the iOS view controlled by this controller.
        ///
        /// This identifier is typically generated by
        /// [PlatformViewsRegistry.getNextPlatformViewId].
        /// </Summary>
        public virtual int Id { get; set; }
        internal virtual bool _DebugDisposed { get; set; }
        internal virtual TextDirection _LayoutDirection { get; set; }

        /// <Summary>
        /// Sets the layout direction for the iOS UIView.
        /// </Summary>
        public virtual async Future<object> SetLayoutDirection(TextDirection layoutDirection)
        {

            if (layoutDirection == _LayoutDirection) return;

            _LayoutDirection = layoutDirection;
        }




        /// <Summary>
        /// Accept an active gesture.
        ///
        /// When a touch sequence is happening on the embedded UIView all touch events are delayed.
        /// Calling this method releases the delayed events to the embedded UIView and makes it consume
        /// any following touch events for the pointers involved in the active gesture.
        /// </Summary>
        public virtual Future<object> AcceptGesture()
        {
            Dictionary<string, object> args = new Dictionary<string, object> { { "id", Id } };
            return SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("acceptGesture", args);
        }




        /// <Summary>
        /// Rejects an active gesture.
        ///
        /// When a touch sequence is happening on the embedded UIView all touch events are delayed.
        /// Calling this method drops the buffered touch events and prevents any future touch events for
        /// the pointers that are part of the active touch sequence from arriving to the embedded view.
        /// </Summary>
        public virtual Future<object> RejectGesture()
        {
            Dictionary<string, object> args = new Dictionary<string, object> { { "id", Id } };
            return SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("rejectGesture", args);
        }




        /// <Summary>
        /// Disposes the view.
        ///
        /// The [UiKitViewController] object is unusable after calling this.
        /// The `id` of the platform view cannot be reused after the view is
        /// disposed.
        /// </Summary>
        public virtual async Future<object> Dispose()
        {
            _DebugDisposed = true;
            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("dispose", Id);
        }



    }


    public enum _AndroidViewState
    {

        WaitingForSize,
        Creating,
        Created,
        Disposed,
    }

}
