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
namespace FlutterSDK.Widgets.Scrollcontroller
{
    internal static class ScrollcontrollerDefaultClass
    {
    }

    /// <Summary>
    /// Controls a scrollable widget.
    ///
    /// Scroll controllers are typically stored as member variables in [State]
    /// objects and are reused in each [State.build]. A single scroll controller can
    /// be used to control multiple scrollable widgets, but some operations, such
    /// as reading the scroll [offset], require the controller to be used with a
    /// single scrollable widget.
    ///
    /// A scroll controller creates a [ScrollPosition] to manage the state specific
    /// to an individual [Scrollable] widget. To use a custom [ScrollPosition],
    /// subclass [ScrollController] and override [createScrollPosition].
    ///
    /// A [ScrollController] is a [Listenable]. It notifies its listeners whenever
    /// any of the attached [ScrollPosition]s notify _their_ listeners (i.e.
    /// whenever any of them scroll). It does not notify its listeners when the list
    /// of attached [ScrollPosition]s changes.
    ///
    /// Typically used with [ListView], [GridView], [CustomScrollView].
    ///
    /// See also:
    ///
    ///  * [ListView], [GridView], [CustomScrollView], which can be controlled by a
    ///    [ScrollController].
    ///  * [Scrollable], which is the lower-level widget that creates and associates
    ///    [ScrollPosition] objects with [ScrollController] objects.
    ///  * [PageController], which is an analogous object for controlling a
    ///    [PageView].
    ///  * [ScrollPosition], which manages the scroll offset for an individual
    ///    scrolling widget.
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public class ScrollController : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        public ScrollController(double initialScrollOffset = 0.0, bool keepScrollOffset = true, string debugLabel = default(string))
        : base()
        {
            this.KeepScrollOffset = keepScrollOffset;
            this.DebugLabel = debugLabel;
        }
        internal virtual double _InitialScrollOffset { get; set; }
        public virtual bool KeepScrollOffset { get; set; }
        public virtual string DebugLabel { get; set; }
        internal virtual List<FlutterSDK.Widgets.Scrollposition.ScrollPosition> _Positions { get; set; }
        public virtual double InitialScrollOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Scrollposition.ScrollPosition> Positions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasClients { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Animates the position from its current value to the given value.
        ///
        /// Any active animation is canceled. If the user is currently scrolling, that
        /// action is canceled.
        ///
        /// The returned [Future] will complete when the animation ends, whether it
        /// completed successfully or whether it was interrupted prematurely.
        ///
        /// An animation will be interrupted whenever the user attempts to scroll
        /// manually, or whenever another activity is started, or whenever the
        /// animation reaches the edge of the viewport and attempts to overscroll. (If
        /// the [ScrollPosition] does not overscroll but instead allows scrolling
        /// beyond the extents, then going beyond the extents will not interrupt the
        /// animation.)
        ///
        /// The animation is indifferent to changes to the viewport or content
        /// dimensions.
        ///
        /// Once the animation has completed, the scroll position will attempt to
        /// begin a ballistic activity in case its value is not stable (for example,
        /// if it is scrolled beyond the extents and in that situation the scroll
        /// position would normally bounce back).
        ///
        /// The duration must not be zero. To jump to a particular value without an
        /// animation, use [jumpTo].
        ///
        /// When calling [animateTo] in widget tests, `await`ing the returned
        /// [Future] may cause the test to hang and timeout. Instead, use
        /// [WidgetTester.pumpAndSettle].
        /// </Summary>
        public virtual Future<object> AnimateTo(double offset, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {

            List<Future<void>> animations = new List<Future<void>>(_Positions.Count);
            for (int i = 0; i < _Positions.Count; i += 1) animations[i] = _Positions[i].AnimateTo(offset, duration: duration, curve: curve);
            return Dart:asyncDefaultClass.Future.Wait(animations).Then((List<void> _) => =>null);
        }




        /// <Summary>
        /// Jumps the scroll position from its current value to the given value,
        /// without animation, and without checking if the new value is in range.
        ///
        /// Any active animation is canceled. If the user is currently scrolling, that
        /// action is canceled.
        ///
        /// If this method changes the scroll position, a sequence of start/update/end
        /// scroll notifications will be dispatched. No overscroll notifications can
        /// be generated by this method.
        ///
        /// Immediately after the jump, a ballistic activity is started, in case the
        /// value was out of range.
        /// </Summary>
        public virtual void JumpTo(double value)
        {

            foreach (ScrollPosition position in List<ScrollPosition>.From(_Positions)) position.JumpTo(value);
        }




        /// <Summary>
        /// Register the given position with this controller.
        ///
        /// After this function returns, the [animateTo] and [jumpTo] methods on this
        /// controller will manipulate the given position.
        /// </Summary>
        public virtual void Attach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position)
        {

            _Positions.Add(position);
            position.AddListener(NotifyListeners);
        }




        /// <Summary>
        /// Unregister the given position with this controller.
        ///
        /// After this function returns, the [animateTo] and [jumpTo] methods on this
        /// controller will not manipulate the given position.
        /// </Summary>
        public virtual void Detach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position)
        {

            position.RemoveListener(NotifyListeners);
            _Positions.Remove(position);
        }




        public new void Dispose()
        {
            foreach (ScrollPosition position in _Positions) position.RemoveListener(NotifyListeners);
            base.Dispose();
        }




        /// <Summary>
        /// Creates a [ScrollPosition] for use by a [Scrollable] widget.
        ///
        /// Subclasses can override this function to customize the [ScrollPosition]
        /// used by the scrollable widgets they control. For example, [PageController]
        /// overrides this function to return a page-oriented scroll position
        /// subclass that keeps the same page visible when the scrollable widget
        /// resizes.
        ///
        /// By default, returns a [ScrollPositionWithSingleContext].
        ///
        /// The arguments are generally passed to the [ScrollPosition] being created:
        ///
        ///  * `physics`: An instance of [ScrollPhysics] that determines how the
        ///    [ScrollPosition] should react to user interactions, how it should
        ///    simulate scrolling when released or flung, etc. The value will not be
        ///    null. It typically comes from the [ScrollView] or other widget that
        ///    creates the [Scrollable], or, if none was provided, from the ambient
        ///    [ScrollConfiguration].
        ///  * `context`: A [ScrollContext] used for communicating with the object
        ///    that is to own the [ScrollPosition] (typically, this is the
        ///    [Scrollable] itself).
        ///  * `oldPosition`: If this is not the first time a [ScrollPosition] has
        ///    been created for this [Scrollable], this will be the previous instance.
        ///    This is used when the environment has changed and the [Scrollable]
        ///    needs to recreate the [ScrollPosition] object. It is null the first
        ///    time the [ScrollPosition] is created.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition)
        {
            return new ScrollPositionWithSingleContext(physics: physics, context: context, initialPixels: InitialScrollOffset, keepScrollOffset: KeepScrollOffset, oldPosition: oldPosition, debugLabel: DebugLabel);
        }





        /// <Summary>
        /// Add additional information to the given description for use by [toString].
        ///
        /// This method makes it easier for subclasses to coordinate to provide a
        /// high-quality [toString] implementation. The [toString] implementation on
        /// the [ScrollController] base class calls [debugFillDescription] to collect
        /// useful information from subclasses to incorporate into its return value.
        ///
        /// If you override this, make sure to start your method with a call to
        /// `super.debugFillDescription(description)`.
        /// </Summary>
        public virtual void DebugFillDescription(List<string> description)
        {
            if (DebugLabel != null) description.Add(DebugLabel);
            if (InitialScrollOffset != 0.0) description.Add($"'initialScrollOffset: {InitialScrollOffset.ToStringAsFixed(1)}, '");
            if (_Positions.IsEmpty())
            {
                description.Add("no clients");
            }
            else if (_Positions.Count == 1)
            {
                description.Add($"'one client, offset {Offset?.ToStringAsFixed(1)}'");
            }
            else
            {
                description.Add($"'{_Positions.Count} clients'");
            }

        }



    }


    /// <Summary>
    /// A [ScrollController] whose [initialScrollOffset] tracks its most recently
    /// updated [ScrollPosition].
    ///
    /// This class can be used to synchronize the scroll offset of two or more
    /// lazily created scroll views that share a single [TrackingScrollController].
    /// It tracks the most recently updated scroll position and reports it as its
    /// `initialScrollOffset`.
    ///
    /// {@tool snippet}
    ///
    /// In this example each [PageView] page contains a [ListView] and all three
    /// [ListView]'s share a [TrackingScrollController]. The scroll offsets of all
    /// three list views will track each other, to the extent that's possible given
    /// the different list lengths.
    ///
    /// ```dart
    /// PageView(
    ///   children: <Widget>[
    ///     ListView(
    ///       controller: _trackingScrollController,
    ///       children: List<Widget>.generate(100, (int i) => Text('page 0 item $i')).toList(),
    ///     ),
    ///     ListView(
    ///       controller: _trackingScrollController,
    ///       children: List<Widget>.generate(200, (int i) => Text('page 1 item $i')).toList(),
    ///     ),
    ///     ListView(
    ///      controller: _trackingScrollController,
    ///      children: List<Widget>.generate(300, (int i) => Text('page 2 item $i')).toList(),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// In this example the `_trackingController` would have been created by the
    /// stateful widget that built the widget tree.
    /// </Summary>
    public class TrackingScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
    {
        public TrackingScrollController(double initialScrollOffset = 0.0, bool keepScrollOffset = true, string debugLabel = default(string))
        : base(initialScrollOffset: initialScrollOffset, keepScrollOffset: keepScrollOffset, debugLabel: debugLabel)
        {

        }
        internal virtual Dictionary<FlutterSDK.Widgets.Scrollposition.ScrollPosition, object> _PositionToListener { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _LastUpdated { get; set; }
        internal virtual double _LastUpdatedOffset { get; set; }
        public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition MostRecentlyUpdatedPosition { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double InitialScrollOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Attach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position)
        {
            base.Attach(position);

            _PositionToListener[position] = () =>
            {
                _LastUpdated = position;
                _LastUpdatedOffset = position.Pixels;
            }
            ;
            position.AddListener(_PositionToListener[position]);
        }




        public new void Detach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position)
        {
            base.Detach(position);

            position.RemoveListener(_PositionToListener[position]);
            _PositionToListener.Remove(position);
            if (_LastUpdated == position) _LastUpdated = null;
            if (_PositionToListener.IsEmpty()) _LastUpdatedOffset = null;
        }




        public new void Dispose()
        {
            foreach (ScrollPosition position in Positions)
            {

                position.RemoveListener(_PositionToListener[position]);
            }

            base.Dispose();
        }



    }

}
