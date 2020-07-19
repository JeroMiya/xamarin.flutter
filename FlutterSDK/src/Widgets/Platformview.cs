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
namespace FlutterSDK.Widgets.Platformview
{
    public delegate FlutterSDK.Widgets.Framework.Widget PlatformViewSurfaceFactory(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Services.Platformviews.PlatformViewController controller);
    public delegate FlutterSDK.Services.Platformviews.PlatformViewController CreatePlatformViewCallback(FlutterSDK.Widgets.Platformview.PlatformViewCreationParams params);
    internal static class PlatformviewDefaultClass
    {
    }

    /// <Summary>
    /// Embeds an Android view in the Widget hierarchy.
    ///
    /// Requires Android API level 20 or greater.
    ///
    /// Embedding Android views is an expensive operation and should be avoided when a Flutter
    /// equivalent is possible.
    ///
    /// The embedded Android view is painted just like any other Flutter widget and transformations
    /// apply to it as well.
    ///
    /// {@template flutter.widgets.platformViews.layout}
    /// The widget fills all available space, the parent of this object must provide bounded layout
    /// constraints.
    /// {@endtemplate}
    ///
    /// {@template flutter.widgets.platformViews.gestures}
    /// The widget participates in Flutter's [GestureArena]s, and dispatches touch events to the
    /// platform view iff it won the arena. Specific gestures that should be dispatched to the platform
    /// view can be specified in the `gestureRecognizers` constructor parameter. If
    /// the set of gesture recognizers is empty, a gesture will be dispatched to the platform
    /// view iff it was not claimed by any other gesture recognizer.
    /// {@endtemplate}
    ///
    /// The Android view object is created using a [PlatformViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html).
    /// Plugins can register platform view factories with [PlatformViewRegistry#registerViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewRegistry.html#registerViewFactory-java.lang.String-io.flutter.plugin.platform.PlatformViewFactory-).
    ///
    /// Registration is typically done in the plugin's registerWith method, e.g:
    ///
    /// ```java
    ///   public static void registerWith(Registrar registrar) {
    ///     registrar.platformViewRegistry().registerViewFactory("webview", WebViewFactory(registrar.messenger()));
    ///   }
    /// ```
    ///
    /// {@template flutter.widgets.platformViews.lifetime}
    /// The platform view's lifetime is the same as the lifetime of the [State] object for this widget.
    /// When the [State] is disposed the platform view (and auxiliary resources) are lazily
    /// released (some resources are immediately released and some by platform garbage collector).
    /// A stateful widget's state is disposed when the widget is removed from the tree or when it is
    /// moved within the tree. If the stateful widget has a key and it's only moved relative to its siblings,
    /// or it has a [GlobalKey] and it's moved within the tree, it will not be disposed.
    /// {@endtemplate}
    /// </Summary>
    public class AndroidView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public AndroidView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string viewType = default(string), FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback onPlatformViewCreated = default(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), TextDirection layoutDirection = default(TextDirection), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>), object creationParams = default(object), FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec = default(FlutterSDK.Services.Messagecodec.MessageCodec<object>))
        : base(key: key)
        {
            this.ViewType = viewType;
            this.OnPlatformViewCreated = onPlatformViewCreated;
            this.HitTestBehavior = hitTestBehavior;
            this.LayoutDirection = layoutDirection;
            this.GestureRecognizers = gestureRecognizers;
            this.CreationParams = creationParams;
            this.CreationParamsCodec = creationParamsCodec;
        }
        #endregion

        #region fields
        public virtual string ViewType { get; set; }
        public virtual FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback OnPlatformViewCreated { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        public virtual TextDirection LayoutDirection { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        public virtual object CreationParams { get; set; }
        public virtual FlutterSDK.Services.Messagecodec.MessageCodec<object> CreationParamsCodec { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.AndroidView> CreateState() => new _AndroidViewState();


        #endregion
    }


    /// <Summary>
    /// Embeds an iOS view in the Widget hierarchy.
    ///
    /// {@macro flutter.rendering.platformView.preview}
    ///
    /// Embedding iOS views is an expensive operation and should be avoided when a Flutter
    /// equivalent is possible.
    ///
    /// {@macro flutter.widgets.platformViews.layout}
    ///
    /// {@macro flutter.widgets.platformViews.gestures}
    ///
    /// {@macro flutter.widgets.platformViews.lifetime}
    ///
    /// Construction of UIViews is done asynchronously, before the UIView is ready this widget paints
    /// nothing while maintaining the same layout constraints.
    ///
    /// If a conic path clipping is applied to a UIKitView,
    /// a quad path is used to approximate the clip due to limitation of Quartz.
    /// </Summary>
    public class UiKitView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public UiKitView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string viewType = default(string), FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback onPlatformViewCreated = default(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), TextDirection layoutDirection = default(TextDirection), object creationParams = default(object), FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec = default(FlutterSDK.Services.Messagecodec.MessageCodec<object>), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.ViewType = viewType;
            this.OnPlatformViewCreated = onPlatformViewCreated;
            this.HitTestBehavior = hitTestBehavior;
            this.LayoutDirection = layoutDirection;
            this.CreationParams = creationParams;
            this.CreationParamsCodec = creationParamsCodec;
            this.GestureRecognizers = gestureRecognizers;
        }
        #endregion

        #region fields
        public virtual string ViewType { get; set; }
        public virtual FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback OnPlatformViewCreated { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        public virtual TextDirection LayoutDirection { get; set; }
        public virtual object CreationParams { get; set; }
        public virtual FlutterSDK.Services.Messagecodec.MessageCodec<object> CreationParamsCodec { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.UiKitView> CreateState() => new _UiKitViewState();


        #endregion
    }


    /// <Summary>
    /// Embeds an HTML element in the Widget hierarchy in Flutter Web.
    ///
    /// *NOTE*: This only works in Flutter Web. To embed web content on other
    /// platforms, consider using the `flutter_webview` plugin.
    ///
    /// Embedding HTML is an expensive operation and should be avoided when a
    /// Flutter equivalent is possible.
    ///
    /// The embedded HTML is painted just like any other Flutter widget and
    /// transformations apply to it as well. This widget should only be used in
    /// Flutter Web.
    ///
    /// {@macro flutter.widgets.platformViews.layout}
    ///
    /// Due to security restrictions with cross-origin `<iframe>` elements, Flutter
    /// cannot dispatch pointer events to an HTML view. If an `<iframe>` is the
    /// target of an event, the window containing the `<iframe>` is not notified
    /// of the event. In particular, this means that any pointer events which land
    /// on an `<iframe>` will not be seen by Flutter, and so the HTML view cannot
    /// participate in gesture detection with other widgets.
    ///
    /// The way we enable accessibility on Flutter for web is to have a full-page
    /// button which waits for a double tap. Placing this full-page button in front
    /// of the scene would cause platform views not to receive pointer events. The
    /// tradeoff is that by placing the scene in front of the semantics placeholder
    /// will cause platform views to block pointer events from reaching the
    /// placeholder. This means that in order to enable accessibility, you must
    /// double tap the app *outside of a platform view*. As a consequence, a
    /// full-screen platform view will make it impossible to enable accessibility.
    /// Make sure that your HTML views are sized no larger than necessary, or you
    /// may cause difficulty for users trying to enable accessibility.
    ///
    /// {@macro flutter.widgets.platformViews.lifetime}
    /// </Summary>
    public class HtmlElementView : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public HtmlElementView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string viewType = default(string))
        : base(key: key)
        {
            this.ViewType = viewType;
        }
        #endregion

        #region fields
        public virtual string ViewType { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new PlatformViewLink(viewType: ViewType, onCreatePlatformView: _CreateHtmlElementView, surfaceFactory: (BuildContext context, PlatformViewController controller) =>
            {
                return new PlatformViewSurface(controller: controller, gestureRecognizers: new Dictionary<Factory<OneSequenceGestureRecognizer>> { }, hitTestBehavior: PlatformViewHitTestBehavior.Opaque);
            }
            );
        }




        /// <Summary>
        /// Creates the controller and kicks off its initialization.
        /// </Summary>
        private FlutterSDK.Widgets.Platformview._HtmlElementViewController _CreateHtmlElementView(FlutterSDK.Widgets.Platformview.PlatformViewCreationParams params)
        {
            _HtmlElementViewController controller = new _HtmlElementViewController(params.Id, ViewType);
            controller._Initialize().Then((_) =>
            {
params.OnPlatformViewCreated(params.Id);
            }
            );
            return controller;
        }



        #endregion
    }


    public class _HtmlElementViewController : FlutterSDK.Services.Platformviews.PlatformViewController
    {
        #region constructors
        public _HtmlElementViewController(int viewId, string viewType)
        {
            this.ViewId = viewId;
            this.ViewType = viewType;
        }
        #endregion

        #region fields
        public new int ViewId { get; set; }
        public virtual string ViewType { get; set; }
        internal virtual bool _Initialized { get; set; }
        #endregion

        #region methods

        private Future<object> _Initialize()
        {
            Dictionary<string, object> args = new Dictionary<string, object> { { "id", ViewId }{ "viewType", ViewType } };
            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("create", args);
            _Initialized = true;
        }




        public new void ClearFocus()
        {
        }




        public new void DispatchPointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
        }




        public new void Dispose()
        {
            if (_Initialized)
            {
                SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("dispose", ViewId);
            }

        }



        #endregion
    }


    public class _AndroidViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.AndroidView>
    {
        #region constructors
        public _AndroidViewState()
        { }
        #endregion

        #region fields
        internal virtual int _Id { get; set; }
        internal virtual FlutterSDK.Services.Platformviews.AndroidViewController _Controller { get; set; }
        internal virtual TextDirection _LayoutDirection { get; set; }
        internal virtual bool _Initialized { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> _EmptyRecognizersSet { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Focus(focusNode: _FocusNode, onFocusChange: _OnFocusChange, child: new _AndroidPlatformView(controller: _Controller, hitTestBehavior: Widget.HitTestBehavior, gestureRecognizers: Widget.GestureRecognizers ?? _EmptyRecognizersSet));
        }




        private void _InitializeOnce()
        {
            if (_Initialized)
            {
                return;
            }

            _Initialized = true;
            _CreateNewAndroidView();
            _FocusNode = new FocusNode(debugLabel: $"'AndroidView(id: {_Id})'");
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            _InitializeOnce();
            if (didChangeLayoutDirection)
            {
                _Controller.SetLayoutDirection(_LayoutDirection);
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Platformview.AndroidView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            if (Widget.ViewType != oldWidget.ViewType)
            {
                _Controller.Dispose();
                _CreateNewAndroidView();
                return;
            }

            if (didChangeLayoutDirection)
            {
                _Controller.SetLayoutDirection(_LayoutDirection);
            }

        }




        private TextDirection _FindLayoutDirection()
        {

            return Widget.LayoutDirection ?? BasicDefaultClass.Directionality.Of(Context);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        private void _CreateNewAndroidView()
        {
            _Id = PlatformviewsDefaultClass.PlatformViewsRegistry.GetNextPlatformViewId();
            _Controller = PlatformviewsDefaultClass.PlatformViewsService.InitAndroidView(id: _Id, viewType: Widget.ViewType, layoutDirection: _LayoutDirection, creationParams: Widget.CreationParams, creationParamsCodec: Widget.CreationParamsCodec, onFocus: () =>
            {
                _FocusNode.RequestFocus();
            }
            );
            if (Widget.OnPlatformViewCreated != null)
            {
                _Controller.AddOnPlatformViewCreatedListener(Widget.OnPlatformViewCreated);
            }

        }




        private void _OnFocusChange(bool isFocused)
        {
            if (!_Controller.IsCreated)
            {
                return;
            }

            if (!isFocused)
            {
                _Controller.ClearFocus().CatchError((object e) =>
                {
                    if (((MissingPluginException)e) is MissingPluginException)
                    {
                        return;
                    }

                }
                );
                return;
            }

            SystemchannelsDefaultClass.SystemChannels.TextInput.InvokeMethod("TextInput.setPlatformViewClient", _Id).CatchError((object e) =>
            {
                if (e is MissingPluginException)
                {
                    return;
                }

            }
            );
        }



        #endregion
    }


    public class _UiKitViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.UiKitView>
    {
        #region constructors
        public _UiKitViewState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Services.Platformviews.UiKitViewController _Controller { get; set; }
        internal virtual TextDirection _LayoutDirection { get; set; }
        internal virtual bool _Initialized { get; set; }
        internal virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> _EmptyRecognizersSet { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_Controller == null)
            {
                return SizedBox.Expand();
            }

            return new _UiKitPlatformView(controller: _Controller, hitTestBehavior: Widget.HitTestBehavior, gestureRecognizers: Widget.GestureRecognizers ?? _EmptyRecognizersSet);
        }




        private void _InitializeOnce()
        {
            if (_Initialized)
            {
                return;
            }

            _Initialized = true;
            _CreateNewUiKitView();
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            _InitializeOnce();
            if (didChangeLayoutDirection)
            {
                _Controller?.SetLayoutDirection(_LayoutDirection);
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Platformview.UiKitView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            if (Widget.ViewType != oldWidget.ViewType)
            {
                _Controller?.Dispose();
                _CreateNewUiKitView();
                return;
            }

            if (didChangeLayoutDirection)
            {
                _Controller?.SetLayoutDirection(_LayoutDirection);
            }

        }




        private TextDirection _FindLayoutDirection()
        {

            return Widget.LayoutDirection ?? BasicDefaultClass.Directionality.Of(Context);
        }




        public new void Dispose()
        {
            _Controller?.Dispose();
            base.Dispose();
        }




        private Future<object> _CreateNewUiKitView()
        {
            int id = PlatformviewsDefaultClass.PlatformViewsRegistry.GetNextPlatformViewId();
            UiKitViewController controller = await PlatformviewsDefaultClass.PlatformViewsService.InitUiKitView(id: id, viewType: Widget.ViewType, layoutDirection: _LayoutDirection, creationParams: Widget.CreationParams, creationParamsCodec: Widget.CreationParamsCodec);
            if (!Mounted)
            {
                controller.Dispose();
                return;
            }

            if (Widget.OnPlatformViewCreated != null)
            {
                Widget.OnPlatformViewCreated(id);
            }

            SetState(() =>
            {
                _Controller = controller;
            }
            );
        }



        #endregion
    }


    public class _AndroidPlatformView : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _AndroidPlatformView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Platformviews.AndroidViewController controller = default(FlutterSDK.Services.Platformviews.AndroidViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.Controller = controller;
            this.HitTestBehavior = hitTestBehavior;
            this.GestureRecognizers = gestureRecognizers;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Platformviews.AndroidViewController Controller { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderAndroidView(viewController: Controller, hitTestBehavior: HitTestBehavior, gestureRecognizers: GestureRecognizers);



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Platformview.RenderAndroidView renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }



        #endregion
    }


    public class _UiKitPlatformView : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _UiKitPlatformView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Platformviews.UiKitViewController controller = default(FlutterSDK.Services.Platformviews.UiKitViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.Controller = controller;
            this.HitTestBehavior = hitTestBehavior;
            this.GestureRecognizers = gestureRecognizers;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Platformviews.UiKitViewController Controller { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderUiKitView(viewController: Controller, hitTestBehavior: HitTestBehavior, gestureRecognizers: GestureRecognizers);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Platformview.RenderUiKitView renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }



        #endregion
    }


    /// <Summary>
    /// The parameters used to create a [PlatformViewController].
    ///
    /// See also:
    ///
    ///  * [CreatePlatformViewCallback] which uses this object to create a [PlatformViewController].
    /// </Summary>
    public class PlatformViewCreationParams
    {
        #region constructors
        internal PlatformViewCreationParams(int id = default(int), string viewType = default(string), FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback onPlatformViewCreated = default(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>))
        : base()
        {
            this.Id = id;
            this.ViewType = viewType;
            this.OnPlatformViewCreated = onPlatformViewCreated;
            this.OnFocusChanged = onFocusChanged;
        }
        #endregion

        #region fields
        public virtual int Id { get; set; }
        public virtual string ViewType { get; set; }
        public virtual FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback OnPlatformViewCreated { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnFocusChanged { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// Links a platform view with the Flutter framework.
    ///
    /// Provides common functionality for embedding a platform view (e.g an android.view.View on Android)
    /// with the Flutter framework.
    ///
    /// {@macro flutter.widgets.platformViews.lifetime}
    ///
    /// To implement a new platform view widget, return this widget in the `build` method.
    /// For example:
    /// ```dart
    /// class FooPlatformView extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return PlatformViewLink(
    ///       viewType: 'webview',
    ///       onCreatePlatformView: createFooWebView,
    ///       surfaceFactory: (BuildContext context, PlatformViewController controller) {
    ///        return PlatformViewSurface(
    ///            gestureRecognizers: gestureRecognizers,
    ///            controller: controller,
    ///            hitTestBehavior: PlatformViewHitTestBehavior.opaque,
    ///        );
    ///       },
    ///    );
    ///   }
    /// }
    /// ```
    ///
    /// The `surfaceFactory` and the `onCreatePlatformView` are only called when the
    /// state of this widget is initialized, or when the `viewType` changes.
    /// </Summary>
    public class PlatformViewLink : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public PlatformViewLink(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Platformview.PlatformViewSurfaceFactory surfaceFactory = default(FlutterSDK.Widgets.Platformview.PlatformViewSurfaceFactory), FlutterSDK.Widgets.Platformview.CreatePlatformViewCallback onCreatePlatformView = default(FlutterSDK.Widgets.Platformview.CreatePlatformViewCallback), string viewType = default(string))
        : base(key: key)
        {
            this.ViewType = viewType;
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Platformview.PlatformViewSurfaceFactory _SurfaceFactory { get; set; }
        internal virtual FlutterSDK.Widgets.Platformview.CreatePlatformViewCallback _OnCreatePlatformView { get; set; }
        public virtual string ViewType { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _PlatformViewLinkState();


        #endregion
    }


    public class _PlatformViewLinkState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.PlatformViewLink>
    {
        #region constructors
        public _PlatformViewLinkState()
        { }
        #endregion

        #region fields
        internal virtual int _Id { get; set; }
        internal virtual FlutterSDK.Services.Platformviews.PlatformViewController _Controller { get; set; }
        internal virtual bool _PlatformViewCreated { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Surface { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (!_PlatformViewCreated)
            {
                return SizedBox.Expand();
            }

            _Surface = (_Surface == null ? Widget._SurfaceFactory(context, _Controller) : _Surface);
            return new Focus(focusNode: _FocusNode, onFocusChange: _HandleFrameworkFocusChanged, child: _Surface);
        }




        public new void InitState()
        {
            _FocusNode = new FocusNode(debugLabel: $"'PlatformView(id: {_Id})'");
            _Initialize();
            base.InitState();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Platformview.PlatformViewLink oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.ViewType != oldWidget.ViewType)
            {
                _Controller?.Dispose();
                _Surface = null;
                _PlatformViewCreated = false;
                _Initialize();
            }

        }




        private void _Initialize()
        {
            _Id = PlatformviewsDefaultClass.PlatformViewsRegistry.GetNextPlatformViewId();
            _Controller = Widget._OnCreatePlatformView(PlatformViewCreationParams._(id: _Id, viewType: Widget.ViewType, onPlatformViewCreated: _OnPlatformViewCreated, onFocusChanged: _HandlePlatformFocusChanged));
        }




        private void _OnPlatformViewCreated(int id)
        {
            SetState(() =>
            {
                _PlatformViewCreated = true;
            }
            );
        }




        private void _HandleFrameworkFocusChanged(bool isFocused)
        {
            if (!isFocused)
            {
                _Controller?.ClearFocus();
            }

        }




        private void _HandlePlatformFocusChanged(bool isFocused)
        {
            if (isFocused)
            {
                _FocusNode.RequestFocus();
            }

        }




        public new void Dispose()
        {
            _Controller?.Dispose();
            _Controller = null;
            base.Dispose();
        }



        #endregion
    }


    /// <Summary>
    /// Integrates a platform view with Flutter's compositor, touch, and semantics subsystems.
    ///
    /// The compositor integration is done by adding a [PlatformViewLayer] to the layer tree. [PlatformViewLayer]
    /// isn't supported on all platforms (e.g on Android platform views are composited using a [TextureLayer]).
    /// Custom Flutter embedders can support [PlatformViewLayer]s by implementing a SystemCompositor.
    ///
    /// The widget fills all available space, the parent of this object must provide bounded layout
    /// constraints.
    ///
    /// If the associated platform view is not created the [PlatformViewSurface] does not paint any contents.
    ///
    /// See also:
    ///
    ///  * [AndroidView] which embeds an Android platform view in the widget hierarchy.
    ///  * [UIKitView] which embeds an iOS platform view in the widget hierarchy.
    /// </Summary>
    public class PlatformViewSurface : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public PlatformViewSurface(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Platformviews.PlatformViewController controller = default(FlutterSDK.Services.Platformviews.PlatformViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.Controller = controller;
            this.HitTestBehavior = hitTestBehavior;
            this.GestureRecognizers = gestureRecognizers;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Platformviews.PlatformViewController Controller { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new PlatformViewRenderBox(controller: Controller, gestureRecognizers: GestureRecognizers, hitTestBehavior: HitTestBehavior);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Platformview.PlatformViewRenderBox renderObject)
        {
            ..Controller = Controller..HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Controller = Controller..HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }



        #endregion
    }

}
