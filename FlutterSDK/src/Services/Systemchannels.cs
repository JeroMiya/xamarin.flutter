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
namespace FlutterSDK.Services.Systemchannels
{
    internal static class SystemchannelsDefaultClass
    {
    }

    /// <Summary>
    /// Platform channels used by the Flutter system.
    /// </Summary>
    public class SystemChannels
    {
        internal SystemChannels()
        {

        }
        /// <Summary>
        /// A JSON [MethodChannel] for navigation.
        ///
        /// The following incoming methods are defined for this channel (registered
        /// using [MethodChannel.setMethodCallHandler]):
        ///
        ///  * `popRoute`, which is called when the system wants the current route to
        ///    be removed (e.g. if the user hits a system-level back button).
        ///
        ///  * `pushRoute`, which is called with a single string argument when the
        ///    operating system instructs the application to open a particular page.
        ///
        /// The following methods are used for the opposite direction data flow. The
        /// framework notifies the engine about the route changes.
        ///
        ///  * `routePushed`, which is called when a route is pushed. (e.g. A modal
        ///    replaces the entire screen.)
        ///
        ///  * `routePopped`, which is called when a route is popped. (e.g. A dialog,
        ///    such as time picker is closed.)
        ///
        ///  * `routeReplaced`, which is called when a route is replaced.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver.didPopRoute] and
        ///    [WidgetsBindingObserver.didPushRoute], which expose this channel's
        ///    methods.
        ///  * [Navigator] which manages transitions from one page to another.
        ///    [Navigator.push], [Navigator.pushReplacement], [Navigator.pop] and
        ///    [Navigator.replace], utilize this channel's methods to send route
        ///    change information from framework to engine.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.MethodChannel Navigation { get; set; }
        /// <Summary>
        /// A JSON [MethodChannel] for invoking miscellaneous platform methods.
        ///
        /// The following outgoing methods are defined for this channel (invoked using
        /// [OptionalMethodChannel.invokeMethod]):
        ///
        ///  * `Clipboard.setData`: Places the data from the `text` entry of the
        ///    argument, which must be a [Map], onto the system clipboard. See
        ///    [Clipboard.setData].
        ///
        ///  * `Clipboard.getData`: Returns the data that has the format specified in
        ///    the argument, a [String], from the system clipboard. The only format
        ///    currently supported is `text/plain` ([Clipboard.kTextPlain]). The
        ///    result is a [Map] with a single key, `text`. See [Clipboard.getData].
        ///
        ///  * `HapticFeedback.vibrate`: Triggers a system-default haptic response.
        ///    See [HapticFeedback.vibrate].
        ///
        ///  * `SystemSound.play`: Triggers a system audio effect. The argument must
        ///    be a [String] describing the desired effect; currently only `click` is
        ///    supported. See [SystemSound.play].
        ///
        ///  * `SystemChrome.setPreferredOrientations`: Informs the operating system
        ///    of the desired orientation of the display. The argument is a [List] of
        ///    values which are string representations of values of the
        ///    [DeviceOrientation] enum. See [SystemChrome.setPreferredOrientations].
        ///
        ///  * `SystemChrome.setApplicationSwitcherDescription`: Informs the operating
        ///    system of the desired label and color to be used to describe the
        ///    application in any system-level application lists (e.g. application
        ///    switchers). The argument is a [Map] with two keys, `label` giving a
        ///    [String] description, and `primaryColor` giving a 32 bit integer value
        ///    (the lower eight bits being the blue channel, the next eight bits being
        ///    the green channel, the next eight bits being the red channel, and the
        ///    high eight bits being set, as from [Color.value] for an opaque color).
        ///    The `primaryColor` can also be zero to indicate that the system default
        ///    should be used. See [SystemChrome.setPreferredOrientations].
        ///
        ///  * `SystemChrome.setEnabledSystemUIOverlays`: Specifies the set of system
        ///    overlays to have visible when the application is running. The argument
        ///    is a [List] of values which are string representations of values of the
        ///    [SystemUiOverlay] enum. See [SystemChrome.setEnabledSystemUIOverlays].
        ///
        ///  * `SystemChrome.setSystemUIOverlayStyle`: Specifies whether system
        ///    overlays (e.g. the status bar on Android or iOS) should be `light` or
        ///    `dark`. The argument is one of those two strings. See
        ///    [SystemChrome.setSystemUIOverlayStyle].
        ///
        ///  * `SystemNavigator.pop`: Tells the operating system to close the
        ///    application, or the closest equivalent. See [SystemNavigator.pop].
        ///
        /// Calls to methods that are not implemented on the shell side are ignored
        /// (so it is safe to call methods when the relevant plugin might be missing).
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.MethodChannel Platform { get; set; }
        /// <Summary>
        /// A JSON [MethodChannel] for handling text input.
        ///
        /// This channel exposes a system text input control for interacting with IMEs
        /// (input method editors, for example on-screen keyboards). There is one
        /// control, and at any time it can have one active transaction. Transactions
        /// are represented by an integer. New Transactions are started by
        /// `TextInput.setClient`. Messages that are sent are assumed to be for the
        /// current transaction (the last "client" set by `TextInput.setClient`).
        /// Messages received from the shell side specify the transaction to which
        /// they apply, so that stale messages referencing past transactions can be
        /// ignored.
        ///
        /// The methods described below are wrapped in a more convenient form by the
        /// [TextInput] and [TextInputConnection] class.
        ///
        /// The following outgoing methods are defined for this channel (invoked using
        /// [OptionalMethodChannel.invokeMethod]):
        ///
        ///  * `TextInput.setClient`: Establishes a new transaction. The arguments is
        ///    a [List] whose first value is an integer representing a previously
        ///    unused transaction identifier, and the second is a [String] with a
        ///    JSON-encoded object with five keys, as obtained from
        ///    [TextInputConfiguration.toJSON]. This method must be invoked before any
        ///    others (except `TextInput.hide`). See [TextInput.attach].
        ///
        ///  * `TextInput.show`: Show the keyboard. See [TextInputConnection.show].
        ///
        ///  * `TextInput.setEditingState`: Update the value in the text editing
        ///    control. The argument is a [String] with a JSON-encoded object with
        ///    seven keys, as obtained from [TextEditingValue.toJSON]. See
        ///    [TextInputConnection.setEditingState].
        ///
        ///  * `TextInput.clearClient`: End the current transaction. The next method
        ///    called must be `TextInput.setClient` (or `TextInput.hide`). See
        ///    [TextInputConnection.close].
        ///
        ///  * `TextInput.hide`: Hide the keyboard. Unlike the other methods, this can
        ///    be called at any time. See [TextInputConnection.close].
        ///
        /// The following incoming methods are defined for this channel (registered
        /// using [MethodChannel.setMethodCallHandler]). In each case, the first argument
        /// is a transaction identifier. Calls for stale transactions should be ignored.
        ///
        ///  * `TextInputClient.updateEditingState`: The user has changed the contents
        ///    of the text control. The second argument is a [String] containing a
        ///    JSON-encoded object with seven keys, in the form expected by [new
        ///    TextEditingValue.fromJSON].
        ///
        ///  * `TextInputClient.performAction`: The user has triggered an action. The
        ///    second argument is a [String] consisting of the stringification of one
        ///    of the values of the [TextInputAction] enum.
        ///
        ///  * `TextInputClient.requestExistingInputState`: The embedding may have
        ///    lost its internal state about the current editing client, if there is
        ///    one. The framework should call `TextInput.setClient` and
        ///    `TextInput.setEditingState` again with its most recent information. If
        ///    there is no existing state on the framework side, the call should
        ///    fizzle.
        ///
        ///  * `TextInputClient.onConnectionClosed`: The text input connection closed
        ///    on the platform side. For example the application is moved to
        ///    background or used closed the virtual keyboard. This method informs
        ///    [TextInputClient] to clear connection and finalize editing.
        ///    `TextInput.clearClient` and `TextInput.hide` is not called after
        ///    clearing the connection since on the platform side the connection is
        ///    already finalized.
        ///
        /// Calls to methods that are not implemented on the shell side are ignored
        /// (so it is safe to call methods when the relevant plugin might be missing).
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.MethodChannel TextInput { get; set; }
        /// <Summary>
        /// A JSON [BasicMessageChannel] for keyboard events.
        ///
        /// Each incoming message received on this channel (registered using
        /// [BasicMessageChannel.setMessageHandler]) consists of a [Map] with
        /// platform-specific data, plus a `type` field which is either `keydown`, or
        /// `keyup`.
        ///
        /// On Android, the available fields are those described by
        /// [RawKeyEventDataAndroid]'s properties.
        ///
        /// On Fuchsia, the available fields are those described by
        /// [RawKeyEventDataFuchsia]'s properties.
        ///
        /// No messages are sent on other platforms currently.
        ///
        /// See also:
        ///
        ///  * [RawKeyboard], which uses this channel to expose key data.
        ///  * [new RawKeyEvent.fromMessage], which can decode this data into the [RawKeyEvent]
        ///    subclasses mentioned above.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.BasicMessageChannel<object> KeyEvent { get; set; }
        /// <Summary>
        /// A string [BasicMessageChannel] for lifecycle events.
        ///
        /// Valid messages are string representations of the values of the
        /// [AppLifecycleState] enumeration. A handler can be registered using
        /// [BasicMessageChannel.setMessageHandler].
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver.didChangeAppLifecycleState], which triggers
        ///    whenever a message is received on this channel.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.BasicMessageChannel<string> Lifecycle { get; set; }
        /// <Summary>
        /// A JSON [BasicMessageChannel] for system events.
        ///
        /// Events are exposed as [Map]s with string keys. The `type` key specifies
        /// the type of the event; the currently supported system event types are
        /// those listed below. A handler can be registered using
        /// [BasicMessageChannel.setMessageHandler].
        ///
        ///  * `memoryPressure`: Indicates that the operating system would like
        ///    applications to release caches to free up more memory. See
        ///    [WidgetsBindingObserver.didHaveMemoryPressure], which triggers whenever
        ///    a message is received on this channel.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.BasicMessageChannel<object> System { get; set; }
        /// <Summary>
        /// A [BasicMessageChannel] for accessibility events.
        ///
        /// See also:
        ///
        ///  * [SemanticsEvent] and its subclasses for a list of valid accessibility
        ///    events that can be sent over this channel.
        ///  * [SemanticsNode.sendEvent], which uses this channel to dispatch events.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.BasicMessageChannel<object> Accessibility { get; set; }
        /// <Summary>
        /// A [MethodChannel] for controlling platform views.
        ///
        /// See also:
        ///
        ///  * [PlatformViewsService] for the available operations on this channel.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.MethodChannel Platformviews { get; set; }
        /// <Summary>
        /// A [MethodChannel] for configuring the Skia graphics library.
        ///
        /// The following outgoing methods are defined for this channel (invoked using
        /// [OptionalMethodChannel.invokeMethod]):
        ///
        ///  * `Skia.setResourceCacheMaxBytes`: Set the maximum number of bytes that
        ///    can be held in the GPU resource cache.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformchannel.MethodChannel Skia { get; set; }
    }

}
