using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Scheduler.Ticker
{
    /// <Summary>
    /// Signature for the callback passed to the [Ticker] class's constructor.
    ///
    /// The argument is the time that the object had spent enabled so far
    /// at the time of the callback being called.
    /// </Summary>
    public delegate void TickerCallback(TimeSpan elapsed);
    internal static class TickerDefaultClass
    {
    }

    /// <Summary>
    /// An interface implemented by classes that can vend [Ticker] objects.
    ///
    /// Tickers can be used by any object that wants to be notified whenever a frame
    /// triggers, but are most commonly used indirectly via an
    /// [AnimationController]. [AnimationController]s need a [TickerProvider] to
    /// obtain their [Ticker]. If you are creating an [AnimationController] from a
    /// [State], then you can use the [TickerProviderStateMixin] and
    /// [SingleTickerProviderStateMixin] classes to obtain a suitable
    /// [TickerProvider]. The widget test framework [WidgetTester] object can be
    /// used as a ticker provider in the context of tests. In other contexts, you
    /// will have to either pass a [TickerProvider] from a higher level (e.g.
    /// indirectly from a [State] that mixes in [TickerProviderStateMixin]), or
    /// create a custom [TickerProvider] subclass.
    /// </Summary>
    public interface ITickerProvider
    {
        FlutterSDK.Scheduler.Ticker.Ticker CreateTicker(FlutterSDK.Scheduler.Ticker.TickerCallback onTick);
    }


    /// <Summary>
    /// An interface implemented by classes that can vend [Ticker] objects.
    ///
    /// Tickers can be used by any object that wants to be notified whenever a frame
    /// triggers, but are most commonly used indirectly via an
    /// [AnimationController]. [AnimationController]s need a [TickerProvider] to
    /// obtain their [Ticker]. If you are creating an [AnimationController] from a
    /// [State], then you can use the [TickerProviderStateMixin] and
    /// [SingleTickerProviderStateMixin] classes to obtain a suitable
    /// [TickerProvider]. The widget test framework [WidgetTester] object can be
    /// used as a ticker provider in the context of tests. In other contexts, you
    /// will have to either pass a [TickerProvider] from a higher level (e.g.
    /// indirectly from a [State] that mixes in [TickerProviderStateMixin]), or
    /// create a custom [TickerProvider] subclass.
    /// </Summary>
    public class TickerProvider
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public TickerProvider()
        {

        }

        /// <Summary>
        /// Creates a ticker with the given callback.
        ///
        /// The kind of ticker provided depends on the kind of ticker provider.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.Ticker CreateTicker(FlutterSDK.Scheduler.Ticker.TickerCallback onTick)
        {
            return default(Ticker);
        }

    }


    /// <Summary>
    /// Calls its callback once per animation frame.
    ///
    /// When created, a ticker is initially disabled. Call [start] to
    /// enable the ticker.
    ///
    /// A [Ticker] can be silenced by setting [muted] to true. While silenced, time
    /// still elapses, and [start] and [stop] can still be called, but no callbacks
    /// are called.
    ///
    /// By convention, the [start] and [stop] methods are used by the ticker's
    /// consumer, and the [muted] property is controlled by the [TickerProvider]
    /// that created the ticker.
    ///
    /// Tickers are driven by the [SchedulerBinding]. See
    /// [SchedulerBinding.scheduleFrameCallback].
    /// </Summary>
    public class Ticker
    {
        /// <Summary>
        /// Creates a ticker that will call the provided callback once per frame while
        /// running.
        ///
        /// An optional label can be provided for debugging purposes. That label
        /// will appear in the [toString] output in debug builds.
        /// </Summary>
        public Ticker(FlutterSDK.Scheduler.Ticker.TickerCallback _onTick, string debugLabel = default(string))
        {
            this._OnTick = _onTick;
            this.DebugLabel = debugLabel;

        }


        internal virtual FlutterSDK.Scheduler.Ticker.TickerFuture _Future { get; set; }
        internal virtual bool _Muted { get; set; }
        internal virtual TimeSpan _StartTime { get; set; }
        internal virtual FlutterSDK.Scheduler.Ticker.TickerCallback _OnTick { get; set; }
        internal virtual int _AnimationId { get; set; }
        /// <Summary>
        /// An optional label can be provided for debugging purposes.
        ///
        /// This label will appear in the [toString] output in debug builds.
        /// </Summary>
        public virtual string DebugLabel { get; set; }
        internal virtual StackTrace _DebugCreationStack { get; set; }
        public virtual bool Muted { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsTicking { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsActive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Scheduled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ShouldScheduleTick { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Starts the clock for this [Ticker]. If the ticker is not [muted], then this
        /// also starts calling the ticker's callback once per animation frame.
        ///
        /// The returned future resolves once the ticker [stop]s ticking. If the
        /// ticker is disposed, the future does not resolve. A derivative future is
        /// available from the returned [TickerFuture] object that resolves with an
        /// error in that case, via [TickerFuture.orCancel].
        ///
        /// Calling this sets [isActive] to true.
        ///
        /// This method cannot be called while the ticker is active. To restart the
        /// ticker, first [stop] it.
        ///
        /// By convention, this method is used by the object that receives the ticks
        /// (as opposed to the [TickerProvider] which created the ticker).
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Start()
        {


            _Future = TickerFuture._();
            if (ShouldScheduleTick)
            {
                ScheduleTick();
            }

            if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase.Index > SchedulerPhase.Idle.Index && BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase.Index < SchedulerPhase.PostFrameCallbacks.Index) _StartTime = BindingDefaultClass.SchedulerBinding.Instance.CurrentFrameTimeStamp;
            return _Future;
        }




        /// <Summary>
        /// Adds a debug representation of a [Ticker] optimized for including in error
        /// messages.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeForError(string name)
        {
            return new DiagnosticsProperty<Ticker>(name, this, description: ToString(debugIncludeStack: true));
        }




        /// <Summary>
        /// Stops calling this [Ticker]'s callback.
        ///
        /// If called with the `canceled` argument set to false (the default), causes
        /// the future returned by [start] to resolve. If called with the `canceled`
        /// argument set to true, the future does not resolve, and the future obtained
        /// from [TickerFuture.orCancel], if any, resolves with a [TickerCanceled]
        /// error.
        ///
        /// Calling this sets [isActive] to false.
        ///
        /// This method does nothing if called when the ticker is inactive.
        ///
        /// By convention, this method is used by the object that receives the ticks
        /// (as opposed to the [TickerProvider] which created the ticker).
        /// </Summary>
        public virtual void Stop(bool canceled = false)
        {
            if (!IsActive) return;
            TickerFuture localFuture = _Future;
            _Future = null;
            _StartTime = null;

            UnscheduleTick();
            if (canceled)
            {
                localFuture._Cancel(this);
            }
            else
            {
                localFuture._Complete();
            }

        }




        private void _Tick(TimeSpan timeStamp)
        {


            _AnimationId = null;
            _StartTime = (_StartTime == null ? timeStamp : _StartTime);
            _OnTick(timeStamp - _StartTime);
            if (ShouldScheduleTick) ScheduleTick(rescheduling: true);
        }




        /// <Summary>
        /// Schedules a tick for the next frame.
        ///
        /// This should only be called if [shouldScheduleTick] is true.
        /// </Summary>
        public virtual void ScheduleTick(bool rescheduling = false)
        {


            _AnimationId = BindingDefaultClass.SchedulerBinding.Instance.ScheduleFrameCallback(_Tick, rescheduling: rescheduling);
        }




        /// <Summary>
        /// Cancels the frame callback that was requested by [scheduleTick], if any.
        ///
        /// Calling this method when no tick is [scheduled] is harmless.
        ///
        /// This method should not be called when [shouldScheduleTick] would return
        /// true if no tick was scheduled.
        /// </Summary>
        public virtual void UnscheduleTick()
        {
            if (Scheduled)
            {
                BindingDefaultClass.SchedulerBinding.Instance.CancelFrameCallbackWithId(_AnimationId);
                _AnimationId = null;
            }


        }




        /// <Summary>
        /// Makes this [Ticker] take the state of another ticker, and disposes the
        /// other ticker.
        ///
        /// This is useful if an object with a [Ticker] is given a new
        /// [TickerProvider] but needs to maintain continuity. In particular, this
        /// maintains the identity of the [TickerFuture] returned by the [start]
        /// function of the original [Ticker] if the original ticker is active.
        ///
        /// This ticker must not be active when this method is called.
        /// </Summary>
        public virtual void AbsorbTicker(FlutterSDK.Scheduler.Ticker.Ticker originalTicker)
        {





            if (originalTicker._Future != null)
            {
                _Future = originalTicker._Future;
                _StartTime = originalTicker._StartTime;
                if (ShouldScheduleTick) ScheduleTick();
                originalTicker._Future = null;
                originalTicker.UnscheduleTick();
            }

            originalTicker.Dispose();
        }




        /// <Summary>
        /// Release the resources used by this object. The object is no longer usable
        /// after this method is called.
        /// </Summary>
        public virtual void Dispose()
        {
            if (_Future != null)
            {
                TickerFuture localFuture = _Future;
                _Future = null;

                UnscheduleTick();
                localFuture._Cancel(this);
            }


        }




    }


    /// <Summary>
    /// An object representing an ongoing [Ticker] sequence.
    ///
    /// The [Ticker.start] method returns a [TickerFuture]. The [TickerFuture] will
    /// complete successfully if the [Ticker] is stopped using [Ticker.stop] with
    /// the `canceled` argument set to false (the default).
    ///
    /// If the [Ticker] is disposed without being stopped, or if it is stopped with
    /// `canceled` set to true, then this Future will never complete.
    ///
    /// This class works like a normal [Future], but has an additional property,
    /// [orCancel], which returns a derivative [Future] that completes with an error
    /// if the [Ticker] that returned the [TickerFuture] was stopped with `canceled`
    /// set to true, or if it was disposed without being stopped.
    ///
    /// To run a callback when either this future resolves or when the ticker is
    /// canceled, use [whenCompleteOrCancel].
    /// </Summary>
    public class TickerFuture : IFuture<object>
    {
        internal TickerFuture()
        {

        }
        /// <Summary>
        /// Creates a [TickerFuture] instance that represents an already-complete
        /// [Ticker] sequence.
        ///
        /// This is useful for implementing objects that normally defer to a [Ticker]
        /// but sometimes can skip the ticker because the animation is of zero
        /// duration, but which still need to represent the completed animation in the
        /// form of a [TickerFuture].
        /// </Summary>
        public static TickerFuture Complete()
        => new TickerFuture();

        private TickerFuture()
        {

            _Complete();
        }


        internal virtual Completer<object> _PrimaryCompleter { get; set; }
        internal virtual Completer<object> _SecondaryCompleter { get; set; }
        internal virtual bool _Completed { get; set; }
        public virtual Future<object> OrCancel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _Complete()
        {

            _Completed = true;
            _PrimaryCompleter.Complete(null);
            _SecondaryCompleter?.Complete(null);
        }




        private void _Cancel(FlutterSDK.Scheduler.Ticker.Ticker ticker)
        {

            _Completed = false;
            _SecondaryCompleter?.CompleteError(new TickerCanceled(ticker));
        }




        /// <Summary>
        /// Calls `callback` either when this future resolves or when the ticker is
        /// canceled.
        ///
        /// Calling this method registers an exception handler for the [orCancel]
        /// future, so even if the [orCancel] property is accessed, canceling the
        /// ticker will not cause an uncaught exception in the current zone.
        /// </Summary>
        public virtual void WhenCompleteOrCancel(VoidCallback callback)
        {
            void Thunk(object value)
            {
                callback();
            }

            OrCancel.Then(Thunk, onError: Thunk);
        }




        public new Stream<object> AsStream()
        {
            return _PrimaryCompleter.Future.AsStream();
        }




        public new Future<object> CatchError(Function onError, Func<bool, object> test = default(Func<bool, object>))
        {
            return _PrimaryCompleter.Future.CatchError(onError, test: test);
        }




        public new Future<R> Then<R>(Func<FutureOr<R>> onValue, Function onError = default(Function))
        {
            return _PrimaryCompleter.Future.Then(onValue, onError: onError);
        }




        public new Future<object> Timeout(TimeSpan timeLimit, Func<dynamic> onTimeout = default(Func<dynamic>))
        {
            return _PrimaryCompleter.Future.Timeout(timeLimit, onTimeout: onTimeout);
        }




        public new Future<object> WhenComplete(Func<dynamic> action)
        {
            return _PrimaryCompleter.Future.WhenComplete(action);
        }




    }


    /// <Summary>
    /// Exception thrown by [Ticker] objects on the [TickerFuture.orCancel] future
    /// when the ticker is canceled.
    /// </Summary>
    public class TickerCanceled : IException
    {
        /// <Summary>
        /// Creates a canceled-ticker exception.
        /// </Summary>
        public TickerCanceled(FlutterSDK.Scheduler.Ticker.Ticker ticker = default(FlutterSDK.Scheduler.Ticker.Ticker))
        {
            this.Ticker = ticker;
        }
        /// <Summary>
        /// Reference to the [Ticker] object that was canceled.
        ///
        /// This may be null in the case that the [Future] created for
        /// [TickerFuture.orCancel] was created after the ticker was canceled.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.Ticker Ticker { get; set; }

    }

}
