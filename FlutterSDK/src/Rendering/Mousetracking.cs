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
namespace FlutterSDK.Rendering.Mousetracking
{
    public delegate void PointerEnterEventListener(FlutterSDK.Gestures.Events.PointerEnterEvent @event);
    public delegate void PointerExitEventListener(FlutterSDK.Gestures.Events.PointerExitEvent @event);
    public delegate void PointerHoverEventListener(FlutterSDK.Gestures.Events.PointerHoverEvent @event);
    public delegate Iterable<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> MouseDetectorAnnotationFinder(FlutterBinding.UI.Offset offset);
    public delegate void _UpdatedDeviceHandler(FlutterSDK.Rendering.Mousetracking._MouseState mouseState, LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> previousAnnotations);
    internal static class MousetrackingDefaultClass
    {
    }

    /// <Summary>
    /// The annotation object used to annotate layers that are interested in mouse
    /// movements.
    ///
    /// This is added to a layer and managed by the [MouseRegion] widget.
    /// </Summary>
    public class MouseTrackerAnnotation : IDiagnosticable
    {
        #region constructors
        public MouseTrackerAnnotation(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener), FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener), FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener))
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnEnter { get; set; }
    public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnHover { get; set; }
    public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnExit { get; set; }
    #endregion

    #region methods

    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new FlagsSummary<Function>("callbacks", new Dictionary<string, Function> { { "enter", OnEnter }{ "hover", OnHover }{ "exit", OnExit } }, ifEmpty: "<none>"));
    }



    #endregion
}


public class _MouseState
{
    #region constructors
    public _MouseState(FlutterSDK.Gestures.Events.PointerEvent initialEvent = default(FlutterSDK.Gestures.Events.PointerEvent))
    : base()

}
#endregion

#region fields
internal virtual LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> _Annotations { get; set; }
internal virtual FlutterSDK.Gestures.Events.PointerEvent _LatestEvent { get; set; }
public virtual LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> Annotations { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Gestures.Events.PointerEvent LatestEvent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int Device { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public virtual LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> ReplaceAnnotations(LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> value)
{
    LinkedHashSet<MouseTrackerAnnotation> previous = _Annotations;
    _Annotations = value;
    return previous;
}




#endregion
}


/// <Summary>
/// Maintains the relationship between mouse devices and
/// [MouseTrackerAnnotation]s, and notifies interested callbacks of the changes
/// thereof.
///
/// This class is a [ChangeNotifier] that notifies its listeners if the value of
/// [mouseIsConnected] changes.
///
/// An instance of [MouseTracker] is owned by the global singleton of
/// [RendererBinding].
///
/// ### Details
///
/// The state of [MouseTracker] consists of two parts:
///
///  * The mouse devices that are connected.
///  * In which annotations each device is contained.
///
/// The states remain stable most of the time, and are only changed at the
/// following moments:
///
///  * An eligible [PointerEvent] has been observed, e.g. a device is added,
///    removed, or moved. In this case, the state related to this device will
///    be immediately updated.
///  * A frame has been painted. In this case, a callback will be scheduled for
///    the upcoming post-frame phase to update all devices.
/// </Summary>
public class MouseTracker : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
{
    #region constructors
    public MouseTracker(FlutterSDK.Gestures.Pointerrouter.PointerRouter _router, FlutterSDK.Rendering.Mousetracking.MouseDetectorAnnotationFinder annotationFinder)
    : base()

_Router.AddGlobalRoute(_HandleEvent);
}


#endregion

#region fields
public virtual FlutterSDK.Rendering.Mousetracking.MouseDetectorAnnotationFinder AnnotationFinder { get; set; }
internal virtual FlutterSDK.Gestures.Pointerrouter.PointerRouter _Router { get; set; }
internal virtual Dictionary<int, FlutterSDK.Rendering.Mousetracking._MouseState> _MouseStates { get; set; }
internal virtual bool _DuringDeviceUpdate { get; set; }
internal virtual bool _HasScheduledPostFrameCheck { get; set; }
internal virtual bool _DuringBuildPhase { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool MouseIsConnected { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Dispose()
{
    base.Dispose();
    _Router.RemoveGlobalRoute(_HandleEvent);
}




private bool _ShouldMarkStateDirty(FlutterSDK.Rendering.Mousetracking._MouseState state, FlutterSDK.Gestures.Events.PointerEvent value)
{
    if (state == null) return true;

    PointerEvent lastEvent = state.LatestEvent;


    if (value is PointerSignalEvent) return false;
    return lastEvent is PointerAddedEvent || value is PointerRemovedEvent || lastEvent.Position != value.Position;
}




private void _HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
{
    if (@event.Kind != PointerDeviceKind.Mouse) return;
    if (@event is PointerSignalEvent) return;
    int device = @event.Device;
    _MouseState existingState = _MouseStates[device];
    if (!_ShouldMarkStateDirty(existingState, @event)) return;
    PointerEvent previousEvent = existingState?.LatestEvent;
    _UpdateDevices(targetEvent: @event, handleUpdatedDevice: (_MouseState mouseState, LinkedHashSet<MouseTrackerAnnotation> previousAnnotations) =>
    {

        _DispatchDeviceCallbacks(lastAnnotations: previousAnnotations, nextAnnotations: mouseState.Annotations, previousEvent: previousEvent, unhandledEvent: @event);
    }
    );
}




private LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> _FindAnnotations(FlutterSDK.Rendering.Mousetracking._MouseState state)
{
    Offset globalPosition = state.LatestEvent.Position;
    int device = state.Device;
    return (_MouseStates.ContainsKey(device)) ? LinkedHashSet<MouseTrackerAnnotation>.From(AnnotationFinder(globalPosition)) : new Dictionary<MouseTrackerAnnotation> { } as LinkedHashSet<MouseTrackerAnnotation>;
}




private void _UpdateAllDevices()
{
    _UpdateDevices(handleUpdatedDevice: (_MouseState mouseState, LinkedHashSet<MouseTrackerAnnotation> previousAnnotations) =>
    {
        _DispatchDeviceCallbacks(lastAnnotations: previousAnnotations, nextAnnotations: mouseState.Annotations, previousEvent: mouseState.LatestEvent, unhandledEvent: null);
    }
    );
}




private void _UpdateDevices(FlutterSDK.Gestures.Events.PointerEvent targetEvent = default(FlutterSDK.Gestures.Events.PointerEvent), FlutterSDK.Rendering.Mousetracking._UpdatedDeviceHandler handleUpdatedDevice = default(FlutterSDK.Rendering.Mousetracking._UpdatedDeviceHandler))
{



    bool mouseWasConnected = MouseIsConnected;
    _MouseState targetState = default(_MouseState);
    if (targetEvent != null)
    {
        targetState = _MouseStates[targetEvent.Device];
        if (targetState == null)
        {
            targetState = new _MouseState(initialEvent: targetEvent);
            _MouseStates[targetState.Device] = targetState;
        }
        else
        {

            targetState.LatestEvent = targetEvent;
            if (((PointerRemovedEvent)targetEvent) is PointerRemovedEvent) _MouseStates.Remove(((PointerRemovedEvent)targetEvent).Device);
        }

    }



    Iterable<_MouseState> dirtyStates = targetEvent == null ? _MouseStates.Values : new List<_MouseState>() { targetState };
    foreach (_MouseState dirtyState in dirtyStates)
    {
        LinkedHashSet<MouseTrackerAnnotation> nextAnnotations = _FindAnnotations(dirtyState);
        LinkedHashSet<MouseTrackerAnnotation> lastAnnotations = dirtyState.ReplaceAnnotations(nextAnnotations);
        handleUpdatedDevice(dirtyState, lastAnnotations);
    }


    if (mouseWasConnected != MouseIsConnected) NotifyListeners();
}




private void _DispatchDeviceCallbacks(LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> lastAnnotations = default(LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation>), LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation> nextAnnotations = default(LinkedHashSet<FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation>), FlutterSDK.Gestures.Events.PointerEvent previousEvent = default(FlutterSDK.Gestures.Events.PointerEvent), FlutterSDK.Gestures.Events.PointerEvent unhandledEvent = default(FlutterSDK.Gestures.Events.PointerEvent))
{


    PointerEvent latestEvent = unhandledEvent ?? previousEvent;

    Iterable<MouseTrackerAnnotation> exitingAnnotations = lastAnnotations.Where((MouseTrackerAnnotation value) => =>!nextAnnotations.Contains(value));
    foreach (MouseTrackerAnnotation annotation in exitingAnnotations)
    {
        if (annotation.OnExit != null)
        {
            annotation.OnExit(PointerExitEvent.FromMouseEvent(latestEvent));
        }

    }

    Iterable<MouseTrackerAnnotation> enteringAnnotations = nextAnnotations.Difference(lastAnnotations).ToList().Reversed;
    foreach (MouseTrackerAnnotation annotation in enteringAnnotations)
    {
        if (annotation.OnEnter != null)
        {
            annotation.OnEnter(PointerEnterEvent.FromMouseEvent(latestEvent));
        }

    }

    if (unhandledEvent is PointerHoverEvent)
    {
        Offset lastHoverPosition = ((PointerHoverEvent)previousEvent) is PointerHoverEvent ? ((PointerHoverEvent)previousEvent).Position : null;
        bool pointerHasMoved = lastHoverPosition == null || lastHoverPosition != ((PointerHoverEvent)unhandledEvent).Position;
        Iterable<MouseTrackerAnnotation> hoveringAnnotations = pointerHasMoved ? nextAnnotations.ToList().Reversed : enteringAnnotations;
        foreach (MouseTrackerAnnotation annotation in hoveringAnnotations)
        {
            if (annotation.OnHover != null)
            {
                annotation.OnHover(((PointerHoverEvent)unhandledEvent));
            }

        }

    }

}




/// <Summary>
/// Mark all devices as dirty, and schedule a callback that is executed in the
/// upcoming post-frame phase to check their updates.
///
/// Checking a device means to collect the annotations that the pointer
/// hovers, and triggers necessary callbacks accordingly.
///
/// Although the actual callback belongs to the scheduler's post-frame phase,
/// this method must be called in persistent callback phase to ensure that
/// the callback is scheduled after every frame, since every frame can change
/// the position of annotations. Typically the method is called by
/// [RendererBinding]'s drawing method.
/// </Summary>
public virtual void SchedulePostFrameCheck()
{


    if (!MouseIsConnected) return;
    if (!_HasScheduledPostFrameCheck)
    {
        _HasScheduledPostFrameCheck = true;
        BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan duration) =>
        {

            _HasScheduledPostFrameCheck = false;
            _UpdateAllDevices();
        }
        );
    }

}



#endregion
}

}
