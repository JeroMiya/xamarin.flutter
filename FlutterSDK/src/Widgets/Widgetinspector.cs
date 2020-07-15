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
namespace FlutterSDK.Widgets.Widgetinspector
{
    public delegate FlutterSDK.Widgets.Framework.Widget InspectorSelectButtonBuilder(FlutterSDK.Widgets.Framework.BuildContext context, VoidCallback onPressed);
    public delegate void _RegisterServiceExtensionCallback(string name = default(string), FlutterSDK.Foundation.Binding.ServiceExtensionCallback callback = default(FlutterSDK.Foundation.Binding.ServiceExtensionCallback));
    public delegate void InspectorSelectionChangedCallback();
    internal static class WidgetinspectorDefaultClass
    {
        public static int _KMaxTooltipLines = default(int);
        public static Color _KTooltipBackgroundColor = default(Color);
        public static Color _KHighlightedRenderObjectFillColor = default(Color);
        public static Color _KHighlightedRenderObjectBorderColor = default(Color);
        public static double _KScreenEdgeMargin = default(double);
        public static double _KTooltipPadding = default(double);
        public static double _KInspectButtonMargin = default(double);
        public static double _KOffScreenMargin = default(double);
        public static FlutterSDK.Painting.Textstyle.TextStyle _MessageStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static Dictionary<FlutterSDK.Widgets.Widgetinspector._Location, int> _LocationToId = default(Dictionary<FlutterSDK.Widgets.Widgetinspector._Location, int>);
        public static List<FlutterSDK.Widgets.Widgetinspector._Location> _Locations = default(List<FlutterSDK.Widgets.Widgetinspector._Location>);
        internal static Rect _CalculateSubtreeBoundsHelper(FlutterSDK.Rendering.@object.RenderObject @object, Matrix4 transform)
        {
            throw new NotImplementedException();
        }

        internal static Rect _CalculateSubtreeBounds(FlutterSDK.Rendering.@object.RenderObject @object)
        {
            throw new NotImplementedException();
        }

        internal static List<FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode> _FollowDiagnosticableChain(List<FlutterSDK.Foundation.Diagnostics.Diagnosticable> chain, string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            throw new NotImplementedException();
        }

        internal static bool _IsDebugCreator(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
        {
            throw new NotImplementedException();
        }

        internal static Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TransformDebugCreator(Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties)
        {
            throw new NotImplementedException();
        }

        internal static Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _ParseDiagnosticsNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
        {
            throw new NotImplementedException();
        }

        internal static Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _DescribeRelevantUserCode(FlutterSDK.Widgets.Framework.Element element)
        {
            throw new NotImplementedException();
        }

        internal static bool _IsLocalCreationLocation(@Object @object)
        {
            throw new NotImplementedException();
        }

        internal static string _DescribeCreationLocation(@Object @object)
        {
            throw new NotImplementedException();
        }

        internal static FlutterSDK.Widgets.Widgetinspector._Location _GetCreationLocation(@Object @object)
        {
            throw new NotImplementedException();
        }

        internal static int _ToLocationId(FlutterSDK.Widgets.Widgetinspector._Location location)
        {
            throw new NotImplementedException();
        }

    }

    public interface IWidgetInspectorService { }

    public class WidgetInspectorService
    {
        internal virtual List<string> _SerializeRing { get; set; }
        internal virtual int _SerializeRingIndex { get; set; }
        internal virtual FlutterSDK.Widgets.Widgetinspector.WidgetInspectorService _Instance { get; set; }
        internal virtual bool _DebugServiceExtensionsRegistered { get; set; }
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get; set; }
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelectionChangedCallback SelectionChangedCallback { get; set; }
        internal virtual Dictionary<string, HashSet<FlutterSDK.Widgets.Widgetinspector._InspectorReferenceData>> _Groups { get; set; }
        internal virtual Dictionary<string, FlutterSDK.Widgets.Widgetinspector._InspectorReferenceData> _IdToReferenceData { get; set; }
        internal virtual Dictionary<@Object, string> _ObjectToId { get; set; }
        internal virtual int _NextId { get; set; }
        internal virtual List<string> _PubRootDirectories { get; set; }
        internal virtual bool _TrackRebuildDirtyWidgets { get; set; }
        internal virtual bool _TrackRepaintWidgets { get; set; }
        internal virtual FlutterSDK.Widgets.Widgetinspector._RegisterServiceExtensionCallback _RegisterServiceExtensionCallback { get; set; }
        internal virtual string _ConsoleObjectGroup { get; set; }
        internal virtual int _ErrorsSinceReload { get; set; }
        internal virtual bool _WidgetCreationTracked { get; set; }
        internal virtual TimeSpan _FrameStart { get; set; }
        internal virtual FlutterSDK.Widgets.Widgetinspector._ElementLocationStatsTracker _RebuildStats { get; set; }
        internal virtual FlutterSDK.Widgets.Widgetinspector._ElementLocationStatsTracker _RepaintStats { get; set; }
        public virtual FlutterSDK.Widgets.Widgetinspector.WidgetInspectorService Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name").
        ///
        /// The given callback is called when the extension method is called. The
        /// callback must return a value that can be converted to JSON using
        /// `json.encode()` (see [JsonEncoder]). The return value is stored as a
        /// property named `result` in the JSON. In case of failure, the failure is
        /// reported to the remote caller and is dumped to the logs.
        /// </Summary>
        public virtual void RegisterServiceExtension(string name = default(string), FlutterSDK.Foundation.Binding.ServiceExtensionCallback callback = default(FlutterSDK.Foundation.Binding.ServiceExtensionCallback))
        {
            _RegisterServiceExtensionCallback(name: $"'inspector.{name}'", callback: callback);
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), which takes no arguments.
        /// </Summary>
        private void _RegisterSignalServiceExtension(string name = default(string), Func<FutureOr<object>> callback = default(Func<FutureOr<object>>))
        {
            RegisterServiceExtension(name: name, callback: (Dictionary<string, string> parameters) => async {
                return new Dictionary<string, object> { { "result", await callback() } };
            }
);
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), which takes a single optional argument
        /// "objectGroup" specifying what group is used to manage lifetimes of
        /// object references in the returned JSON (see [disposeGroup]).
        /// If "objectGroup" is omitted, the returned JSON will not include any object
        /// references to avoid leaking memory.
        /// </Summary>
        private void _RegisterObjectGroupServiceExtension(string name = default(string), Func<FutureOr<object>, string> callback = default(Func<FutureOr<object>, string>))
        {
            RegisterServiceExtension(name: name, callback: (Dictionary<string, string> parameters) => async {
                return new Dictionary<string, object> { { "result", await callback(parameters["objectGroup"]) } };
            }
);
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), which takes a single argument
        /// "enabled" which can have the value "true" or the value "false"
        /// or can be omitted to read the current value. (Any value other
        /// than "true" is considered equivalent to "false". Other arguments
        /// are ignored.)
        ///
        /// Calls the `getter` callback to obtain the value when
        /// responding to the service extension method being called.
        ///
        /// Calls the `setter` callback with the new value when the
        /// service extension method is called with a new value.
        /// </Summary>
        private void _RegisterBoolServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool>))
        {



            RegisterServiceExtension(name: name, callback: (Dictionary<string, string> parameters) => async {
                if (parameters.ContainsKey("enabled"))
                {
                    bool value = parameters["enabled"] == "true";
                    await setter(value);
                    _PostExtensionStateChangedEvent(name, value);
                }

                return new Dictionary<string, object> { { "enabled", await getter() ? "true" : "false" } };
            }
);
        }




        /// <Summary>
        /// Sends an event when a service extension's state is changed.
        ///
        /// Clients should listen for this event to stay aware of the current service
        /// extension state. Any service extension that manages a state should call
        /// this method on state change.
        ///
        /// `value` reflects the newly updated service extension value.
        ///
        /// This will be called automatically for service extensions registered via
        /// [registerBoolServiceExtension].
        /// </Summary>
        private void _PostExtensionStateChangedEvent(string name, object value)
        {
            PostEvent("Flutter.ServiceExtensionStateChanged", new Dictionary<string, object> { { "extension", $"'ext.flutter.inspector.{name}'" }{ "value", value } });
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name") which takes an optional parameter named
        /// "arg" and a required parameter named "objectGroup" used to control the
        /// lifetimes of object references in the returned JSON (see [disposeGroup]).
        /// </Summary>
        private void _RegisterServiceExtensionWithArg(string name = default(string), Func<FutureOr<object>, string, string> callback = default(Func<FutureOr<object>, string, string>))
        {
            RegisterServiceExtension(name: name, callback: (Dictionary<string, string> parameters) => async {

                return new Dictionary<string, object> { { "result", await callback(parameters["arg"], parameters["objectGroup"]) } };
            }
);
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), that takes arguments
        /// "arg0", "arg1", "arg2", ..., "argn".
        /// </Summary>
        private void _RegisterServiceExtensionVarArgs(string name = default(string), Func<FutureOr<object>, List<string>> callback = default(Func<FutureOr<object>, List<string>>))
        {
            RegisterServiceExtension(name: name, callback: (Dictionary<string, string> parameters) => async {
                string argPrefix = "arg";
                List<string> args = new List<string>() { };
                parameters.ForEach((string name, string value) =>
                {
                    if (name.StartsWith(argPrefix))
                    {
                        int index = Dart:coreDefaultClass.Int.Parse(name.Substring(argPrefix.Length));
                        if (index >= args.Count)
                        {
                            args.Count = index + 1;
                        }

                        args[index] = value;
                    }

                }
                );
                return new Dictionary<string, object> { { "result", await callback(args) } };
            }
);
        }




        /// <Summary>
        /// Cause the entire tree to be rebuilt. This is used by development tools
        /// when the application code has changed and is being hot-reloaded, to cause
        /// the widget tree to pick up any changed implementations.
        ///
        /// This is expensive and should not be called except during development.
        /// </Summary>
        public virtual Future<object> ForceRebuild()
        {
            WidgetsBinding binding = BindingDefaultClass.WidgetsBinding.Instance;
            if (binding.RenderViewElement != null)
            {
                binding.BuildOwner.Reassemble(binding.RenderViewElement);
                return binding.EndOfFrame;
            }

            return Future<void>.Value();
        }




        private void _ReportError(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details)
        {
            Dictionary<string, object> errorJson = _NodeToJson(details.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: _ConsoleObjectGroup, subtreeDepth: 5, includeProperties: true, expandPropertyValues: true, maxDescendentsTruncatableNode: 5, service: this));
            errorJson["errorsSinceReload"] = _ErrorsSinceReload;
            _ErrorsSinceReload += 1;
            PostEvent("Flutter.Error", errorJson);
        }




        /// <Summary>
        /// Resets the count of errors since the last hot reload.
        ///
        /// This data is sent to clients as part of the 'Flutter.Error' service
        /// protocol event. Clients may choose to display errors received after the
        /// first error differently.
        /// </Summary>
        private void _ResetErrorCount()
        {
            _ErrorsSinceReload = 0;
        }




        /// <Summary>
        /// Called to register service extensions.
        ///
        /// See also:
        ///
        ///  * <https://github.com/dart-lang/sdk/blob/master/runtime/vm/service/service.md#rpcs-requests-and-responses>
        ///  * [BindingBase.initServiceExtensions], which explains when service
        ///    extensions can be used.
        /// </Summary>
        public virtual void InitServiceExtensions(FlutterSDK.Widgets.Widgetinspector._RegisterServiceExtensionCallback registerServiceExtensionCallback)
        {
            _RegisterServiceExtensionCallback = registerServiceExtensionCallback;


            BindingDefaultClass.SchedulerBinding.Instance.AddPersistentFrameCallback(_OnFrameStart);
            FlutterExceptionHandler structuredExceptionHandler = _ReportError;
            FlutterExceptionHandler defaultExceptionHandler = AssertionsDefaultClass.FlutterError.OnError;
            _RegisterBoolServiceExtension(name: "structuredErrors", getter: () => async => AssertionsDefaultClass.FlutterError.OnError == structuredExceptionHandler, setter: (bool value) =>
            {
                AssertionsDefaultClass.FlutterError.OnError = value ? structuredExceptionHandler : defaultExceptionHandler;
                return Future<void>.Value();
            }
            );
            _RegisterBoolServiceExtension(name: "show", getter: () => async => AppDefaultClass.WidgetsApp.DebugShowWidgetInspectorOverride, setter: (bool value) =>
            {
                if (AppDefaultClass.WidgetsApp.DebugShowWidgetInspectorOverride == value)
                {
                    return Future<void>.Value();
                }

                AppDefaultClass.WidgetsApp.DebugShowWidgetInspectorOverride = value;
                return ForceRebuild();
            }
            );
            if (IsWidgetCreationTracked())
            {
                _RegisterBoolServiceExtension(name: "trackRebuildDirtyWidgets", getter: () => async => _TrackRebuildDirtyWidgets, setter: (bool value) => async {
                    if (value == _TrackRebuildDirtyWidgets)
                    {
                        return;
                    }

                    _RebuildStats.ResetCounts();
                    _TrackRebuildDirtyWidgets = value;
                    if (value)
                    {

                        DebugDefaultClass.DebugOnRebuildDirtyWidget = _OnRebuildWidget;
                        await ForceRebuild();
                        return;
                    }
                    else
                    {
                        DebugDefaultClass.DebugOnRebuildDirtyWidget = null;
                        return;
                    }

                }
);
                _RegisterBoolServiceExtension(name: "trackRepaintWidgets", getter: () => async => _TrackRepaintWidgets, setter: (bool value) => async {
                    if (value == _TrackRepaintWidgets)
                    {
                        return;
                    }

                    _RepaintStats.ResetCounts();
                    _TrackRepaintWidgets = value;
                    if (value)
                    {

                        DebugDefaultClass.DebugOnProfilePaint = _OnPaint;
                        void MarkTreeNeedsPaint(RenderObject renderObject) => {
                            renderObject.MarkNeedsPaint();
                            renderObject.VisitChildren(MarkTreeNeedsPaint);
                        }

                        RenderObject root = BindingDefaultClass.RendererBinding.Instance.RenderView;
                        if (root != null)
                        {
                            MarkTreeNeedsPaint(root);
                        }

                    }
                    else
                    {
                        DebugDefaultClass.DebugOnProfilePaint = null;
                    }

                }
);
            }

            _RegisterSignalServiceExtension(name: "disposeAllGroups", callback: DisposeAllGroups);
            _RegisterObjectGroupServiceExtension(name: "disposeGroup", callback: DisposeGroup);
            _RegisterSignalServiceExtension(name: "isWidgetTreeReady", callback: IsWidgetTreeReady);
            _RegisterServiceExtensionWithArg(name: "disposeId", callback: DisposeId);
            _RegisterServiceExtensionVarArgs(name: "setPubRootDirectories", callback: SetPubRootDirectories);
            _RegisterServiceExtensionWithArg(name: "setSelectionById", callback: SetSelectionById);
            _RegisterServiceExtensionWithArg(name: "getParentChain", callback: _GetParentChain);
            _RegisterServiceExtensionWithArg(name: "getProperties", callback: _GetProperties);
            _RegisterServiceExtensionWithArg(name: "getChildren", callback: _GetChildren);
            _RegisterServiceExtensionWithArg(name: "getChildrenSummaryTree", callback: _GetChildrenSummaryTree);
            _RegisterServiceExtensionWithArg(name: "getChildrenDetailsSubtree", callback: _GetChildrenDetailsSubtree);
            _RegisterObjectGroupServiceExtension(name: "getRootWidget", callback: _GetRootWidget);
            _RegisterObjectGroupServiceExtension(name: "getRootRenderObject", callback: _GetRootRenderObject);
            _RegisterObjectGroupServiceExtension(name: "getRootWidgetSummaryTree", callback: _GetRootWidgetSummaryTree);
            RegisterServiceExtension(name: "getDetailsSubtree", callback: (Dictionary<string, string> parameters) => async {

                string subtreeDepth = parameters["subtreeDepth"];
                return new Dictionary<string, object> { { "result", _GetDetailsSubtree(parameters["arg"], parameters["objectGroup"], subtreeDepth != null ? Dart : coreDefaultClass.Int.Parse(subtreeDepth):2) } };
            }
);
            _RegisterServiceExtensionWithArg(name: "getSelectedRenderObject", callback: _GetSelectedRenderObject);
            _RegisterServiceExtensionWithArg(name: "getSelectedWidget", callback: _GetSelectedWidget);
            _RegisterServiceExtensionWithArg(name: "getSelectedSummaryWidget", callback: _GetSelectedSummaryWidget);
            _RegisterSignalServiceExtension(name: "isWidgetCreationTracked", callback: IsWidgetCreationTracked);
            RegisterServiceExtension(name: "screenshot", callback: (Dictionary<string, string> parameters) => async {



                Ui.Dart:uiDefaultClass.Image image = await Screenshot(ToObject(parameters["id"]), width: Dart:coreDefaultClass.Double.Parse(parameters["width"]), height: Dart: coreDefaultClass.Double.Parse(parameters["height"]), margin: parameters.ContainsKey("margin") ? Dart : coreDefaultClass.Double.Parse(parameters["margin"]):0.0, maxPixelRatio: parameters.ContainsKey("maxPixelRatio") ? Dart : coreDefaultClass.Double.Parse(parameters["maxPixelRatio"]):1.0, debugPaint: parameters["debugPaint"] == "true");
                if (image == null)
                {
                    return new Dictionary<string, object> { { "result", null } };
                }

                ByteData byteData = await image.ToByteData(format: Ui.ImageByteFormat.Png);
                return new Dictionary<string, object> { { "result", Dart:convertDefaultClass.Base64.Encoder.Convert(Uint8List.View(byteData.Buffer)) } };
            }
);
        }




        private void _ClearStats()
        {
            _RebuildStats.ResetCounts();
            _RepaintStats.ResetCounts();
        }




        /// <Summary>
        /// Clear all InspectorService object references.
        ///
        /// Use this method only for testing to ensure that object references from one
        /// test case do not impact other test cases.
        /// </Summary>
        public virtual void DisposeAllGroups()
        {
            _Groups.Clear();
            _IdToReferenceData.Clear();
            _ObjectToId.Clear();
            _NextId = 0;
        }




        /// <Summary>
        /// Free all references to objects in a group.
        ///
        /// Objects and their associated ids in the group may be kept alive by
        /// references from a different group.
        /// </Summary>
        public virtual void DisposeGroup(string name)
        {
            HashSet<_InspectorReferenceData> references = _Groups.Remove(name);
            if (references == null) return;
            references.ForEach(_DecrementReferenceCount);
        }




        private void _DecrementReferenceCount(FlutterSDK.Widgets.Widgetinspector._InspectorReferenceData reference)
        {
            reference.Count -= 1;

            if (reference.Count == 0)
            {
                string id = _ObjectToId.Remove(reference.Object);

                _IdToReferenceData.Remove(id);
            }

        }




        /// <Summary>
        /// Returns a unique id for [object] that will remain live at least until
        /// [disposeGroup] is called on [groupName] or [dispose] is called on the id
        /// returned by this method.
        /// </Summary>
        public virtual string ToId(@Object @object, string groupName)
        {
            if (object == null) return null;
            HashSet<_InspectorReferenceData> group = _Groups.PutIfAbsent(groupName, () => =>HashSet<_InspectorReferenceData>.Identity());
            string id = _ObjectToId[object];
            _InspectorReferenceData referenceData = default(_InspectorReferenceData);
            if (id == null)
            {
                id = $"'inspector-{_NextId}'";
                _NextId += 1;
                _ObjectToId[object] = id;
                referenceData = new _InspectorReferenceData(object);
                _IdToReferenceData[id] = referenceData;
                group.Add(referenceData);
            }
            else
            {
                referenceData = _IdToReferenceData[id];
                if (group.Add(referenceData)) referenceData.Count += 1;
            }

            return id;
        }




        /// <Summary>
        /// Returns whether the application has rendered its first frame and it is
        /// appropriate to display the Widget tree in the inspector.
        /// </Summary>
        public virtual bool IsWidgetTreeReady(string groupName = default(string))
        {
            return BindingDefaultClass.WidgetsBinding.Instance != null && BindingDefaultClass.WidgetsBinding.Instance.DebugDidSendFirstFrameEvent;
        }




        /// <Summary>
        /// Returns the Dart object associated with a reference id.
        ///
        /// The `groupName` parameter is not required by is added to regularize the
        /// API surface of the methods in this class called from the Flutter IntelliJ
        /// Plugin.
        /// </Summary>
        public virtual @Object ToObject(string id, string groupName = default(string))
        {
            if (id == null) return null;
            _InspectorReferenceData data = _IdToReferenceData[id];
            if (data == null)
            {
                throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary("Id does not exist.") });
            }

            return data.Object;
        }




        /// <Summary>
        /// Returns the object to introspect to determine the source location of an
        /// object's class.
        ///
        /// The Dart object for the id is returned for all cases but [Element] objects
        /// where the [Widget] configuring the [Element] is returned instead as the
        /// class of the [Widget] is more relevant than the class of the [Element].
        ///
        /// The `groupName` parameter is not required by is added to regularize the
        /// API surface of methods called from the Flutter IntelliJ Plugin.
        /// </Summary>
        public virtual @Object ToObjectForSourceLocation(string id, string groupName = default(string))
        {
            object   object= ToObject(id);
            if (object is Element)
            {
                return ((Element)object).Widget;
            }

            return object;
        }




        /// <Summary>
        /// Remove the object with the specified `id` from the specified object
        /// group.
        ///
        /// If the object exists in other groups it will remain alive and the object
        /// id will remain valid.
        /// </Summary>
        public virtual void DisposeId(string id, string groupName)
        {
            if (id == null) return;
            _InspectorReferenceData referenceData = _IdToReferenceData[id];
            if (referenceData == null) throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary("Id does not exist") });
            if (_Groups[groupName]?.Remove(referenceData) != true) throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary("Id is not in group") });
            _DecrementReferenceCount(referenceData);
        }




        /// <Summary>
        /// Set the list of directories that should be considered part of the local
        /// project.
        ///
        /// The local project directories are used to distinguish widgets created by
        /// the local project over widgets created from inside the framework.
        /// </Summary>
        public virtual void SetPubRootDirectories(List<string> pubRootDirectories)
        {
            _PubRootDirectories = pubRootDirectories.Map((string directory) => =>Dart: coreDefaultClass.Uri.Parse(directory).Path).ToList();
        }




        /// <Summary>
        /// Set the [WidgetInspector] selection to the object matching the specified
        /// id if the object is valid object to set as the inspector selection.
        ///
        /// Returns true if the selection was changed.
        ///
        /// The `groupName` parameter is not required by is added to regularize the
        /// API surface of methods called from the Flutter IntelliJ Plugin.
        /// </Summary>
        public virtual bool SetSelectionById(string id, string groupName = default(string))
        {
            return SetSelection(ToObject(id), groupName);
        }




        /// <Summary>
        /// Set the [WidgetInspector] selection to the specified `object` if it is
        /// a valid object to set as the inspector selection.
        ///
        /// Returns true if the selection was changed.
        ///
        /// The `groupName` parameter is not needed but is specified to regularize the
        /// API surface of methods called from the Flutter IntelliJ Plugin.
        /// </Summary>
        public virtual bool SetSelection(@Object @object, string groupName = default(string))
        {
            if (object is Element || object is RenderObject)
            {
                if (((Element)object) is Element)
                {
                    if (((Element)object) == Selection.CurrentElement)
                    {
                        return false;
                    }

                    Selection.CurrentElement = object;
                    Developer.Dart:developerDefaultClass.Inspect(Selection.CurrentElement);
                }
                else
                {
                    if (object == Selection.Current)
                    {
                        return false;
                    }

                    Selection.Current = object as RenderObject;
                    Developer.Dart:developerDefaultClass.Inspect(Selection.Current);
                }

                if (SelectionChangedCallback != null)
                {
                    if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase == SchedulerPhase.Idle)
                    {
                        SelectionChangedCallback();
                    }
                    else
                    {
                        BindingDefaultClass.SchedulerBinding.Instance.ScheduleTask(SelectionChangedCallback, PriorityDefaultClass.Priority.Touch);
                    }

                }

                return true;
            }

            return false;
        }




        /// <Summary>
        /// Returns JSON representing the chain of [DiagnosticsNode] instances from
        /// root of thee tree to the [Element] or [RenderObject] matching `id`.
        ///
        /// The JSON contains all information required to display a tree view with
        /// all nodes other than nodes along the path collapsed.
        /// </Summary>
        public virtual string GetParentChain(string id, string groupName)
        {
            return _SafeJsonEncode(_GetParentChain(id, groupName));
        }




        private List<@Object> _GetParentChain(string id, string groupName)
        {
            object value = ToObject(id);
            List<_DiagnosticsPathNode> path = default(List<_DiagnosticsPathNode>);
            if (value is RenderObject) path = _GetRenderObjectParentChain(value, groupName); else if (value is Element) path = _GetElementParentChain(value, groupName); else throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary($"'Cannot get parent chain for node of type {value.GetType()}'") });
            return path.Map((_DiagnosticsPathNode node) => =>_PathNodeToJson(node, new InspectorSerializationDelegate(groupName: groupName, service: this))).ToList();
        }




        private Dictionary<string, @Object> _PathNodeToJson(FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode pathNode, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate)
        {
            if (pathNode == null) return null;
            return new Dictionary<string, object> { { "node", _NodeToJson(pathNode.Node, delegate) }{ "children", _NodesToJson(pathNode.Children, delegate, parent: pathNode.Node) }{ "childIndex", pathNode.ChildIndex } };
        }




        private List<FlutterSDK.Widgets.Framework.Element> _GetRawElementParentChain(FlutterSDK.Widgets.Framework.Element element, int numLocalParents = default(int))
        {
            List<Element> elements = element?.DebugGetDiagnosticChain();
            if (numLocalParents != null)
            {
                for (int i = 0; i < elements.Count; i += 1)
                {
                    if (_IsValueCreatedByLocalProject(elements[i]))
                    {
                        numLocalParents--;
                        if (numLocalParents <= 0)
                        {
                            elements = elements.Take(i + 1).ToList();
                            break;
                        }

                    }

                }

            }

            return elements?.Reversed?.ToList();
        }




        private List<FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode> _GetElementParentChain(FlutterSDK.Widgets.Framework.Element element, string groupName, int numLocalParents = default(int))
        {
            return WidgetinspectorDefaultClass._FollowDiagnosticableChain(_GetRawElementParentChain(element, numLocalParents: numLocalParents)) ?? new List, < _DiagnosticsPathNode > (};
    }




    private List<FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode> _GetRenderObjectParentChain(FlutterSDK.Rendering.@object.RenderObject renderObject, string groupName, int maxparents = default(int))
    {
        List<RenderObject> chain = new List<RenderObject>() { };
        while (renderObject != null)
        {
            chain.Add(renderObject);
            renderObject = renderObject.Parent as RenderObject;
        }

        return WidgetinspectorDefaultClass._FollowDiagnosticableChain(chain.Reversed.ToList());
    }




    private Dictionary<string, @Object> _NodeToJson(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate)
    {
        return node?.ToJsonMap(delegate);
    }




    private bool _IsValueCreatedByLocalProject(@Object value)
    {
        _Location creationLocation = WidgetinspectorDefaultClass._GetCreationLocation(value);
        if (creationLocation == null)
        {
            return false;
        }

        return _IsLocalCreationLocation(creationLocation);
    }




    private bool _IsLocalCreationLocation(FlutterSDK.Widgets.Widgetinspector._Location location)
    {
        if (location == null || location.File == null)
        {
            return false;
        }

        string file = Dart:coreDefaultClass.Uri.Parse(location.File).Path;
        if (_PubRootDirectories == null)
        {
            return !file.Contains("packages/flutter/");
        }

        foreach (string directory in _PubRootDirectories)
        {
            if (file.StartsWith(directory))
            {
                return true;
            }

        }

        return false;
    }




    /// <Summary>
    /// Wrapper around `json.encode` that uses a ring of cached values to prevent
    /// the Dart garbage collector from collecting objects between when
    /// the value is returned over the Observatory protocol and when the
    /// separate observatory protocol command has to be used to retrieve its full
    /// contents.
    /// </Summary>
    private string _SafeJsonEncode(@Object @object)
    {
        string jsonString = Dart:convertDefaultClass.Json.Encode(object);
        _SerializeRing[_SerializeRingIndex] = jsonString;
        _SerializeRingIndex = (_SerializeRingIndex + 1) % _SerializeRing.Count;
        return jsonString;
    }




    private List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _TruncateNodes(Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, int maxDescendentsTruncatableNode)
    {
        if (nodes.Every((DiagnosticsNode node) => =>node.Value is Element) && IsWidgetCreationTracked())
        {
            List<DiagnosticsNode> localNodes = nodes.Where((DiagnosticsNode node) => =>_IsValueCreatedByLocalProject(((Element)node.Value))).ToList();
            if (localNodes.IsNotEmpty)
            {
                return localNodes;
            }

        }

        return nodes.Take(maxDescendentsTruncatableNode).ToList();
    }




    private List<Dictionary<string, @Object>> _NodesToJson(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode parent = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode))
    {
        return DiagnosticsDefaultClass.DiagnosticsNode.ToJsonList(nodes, parent, delegate);
    }




    /// <Summary>
    /// Returns a JSON representation of the properties of the [DiagnosticsNode]
    /// object that `diagnosticsNodeId` references.
    /// </Summary>
    public virtual string GetProperties(string diagnosticsNodeId, string groupName)
    {
        return _SafeJsonEncode(_GetProperties(diagnosticsNodeId, groupName));
    }




    private List<@Object> _GetProperties(string diagnosticsNodeId, string groupName)
    {
        DiagnosticsNode node = ToObject(diagnosticsNodeId) as DiagnosticsNode;
        return _NodesToJson(node == null ? new List, < DiagnosticsNode > (}:node.GetProperties(), new InspectorSerializationDelegate(groupName:groupName, service:this ), parent:node);
}




/// <Summary>
/// Returns a JSON representation of the children of the [DiagnosticsNode]
/// object that `diagnosticsNodeId` references.
/// </Summary>
public virtual string GetChildren(string diagnosticsNodeId, string groupName)
{
    return _SafeJsonEncode(_GetChildren(diagnosticsNodeId, groupName));
}




private List<@Object> _GetChildren(string diagnosticsNodeId, string groupName)
{
    DiagnosticsNode node = ToObject(diagnosticsNodeId) as DiagnosticsNode;
    InspectorSerializationDelegate   delegate= new InspectorSerializationDelegate(groupName: groupName, service: this);
    return _NodesToJson(node == null ? new List, < DiagnosticsNode > (}:_GetChildrenFiltered(node, delegate), delegate, parent:node);
}




/// <Summary>
/// Returns a JSON representation of the children of the [DiagnosticsNode]
/// object that `diagnosticsNodeId` references only including children that
/// were created directly by user code.
///
/// Requires [Widget] creation locations which are only available for debug
/// mode builds when the `--track-widget-creation` flag is passed to
/// `flutter_tool`.
///
/// See also:
///
///  * [isWidgetCreationTracked] which indicates whether this method can be
///    used.
/// </Summary>
public virtual string GetChildrenSummaryTree(string diagnosticsNodeId, string groupName)
{
    return _SafeJsonEncode(_GetChildrenSummaryTree(diagnosticsNodeId, groupName));
}




private List<@Object> _GetChildrenSummaryTree(string diagnosticsNodeId, string groupName)
{
    DiagnosticsNode node = ToObject(diagnosticsNodeId) as DiagnosticsNode;
    InspectorSerializationDelegate   delegate= new InspectorSerializationDelegate(groupName: groupName, summaryTree: true, service: this);
    return _NodesToJson(node == null ? new List, < DiagnosticsNode > (}:_GetChildrenFiltered(node, delegate), delegate, parent:node);
}




/// <Summary>
/// Returns a JSON representation of the children of the [DiagnosticsNode]
/// object that `diagnosticsNodeId` references providing information needed
/// for the details subtree view.
///
/// The details subtree shows properties inline and includes all children
/// rather than a filtered set of important children.
/// </Summary>
public virtual string GetChildrenDetailsSubtree(string diagnosticsNodeId, string groupName)
{
    return _SafeJsonEncode(_GetChildrenDetailsSubtree(diagnosticsNodeId, groupName));
}




private List<@Object> _GetChildrenDetailsSubtree(string diagnosticsNodeId, string groupName)
{
    DiagnosticsNode node = ToObject(diagnosticsNodeId) as DiagnosticsNode;
    InspectorSerializationDelegate   delegate= new InspectorSerializationDelegate(groupName: groupName, subtreeDepth: 1, includeProperties: true, service: this);
    return _NodesToJson(node == null ? new List, < DiagnosticsNode > (}:_GetChildrenFiltered(node, delegate), delegate, parent:node);
}




private bool _ShouldShowInSummaryTree(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
{
    if (node.Level == DiagnosticLevel.Error)
    {
        return true;
    }

    object value = node.Value;
    if (!(value is Diagnosticable))
    {
        return true;
    }

    if (!(value is Element) || !IsWidgetCreationTracked())
    {
        return true;
    }

    return _IsValueCreatedByLocalProject(value);
}




private List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _GetChildrenFiltered(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate)
{
    return _FilterChildren(node.GetChildren(), delegate);
}




private List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate)
{
    List<DiagnosticsNode> children = new List<DiagnosticsNode>() { };
    return children;
}




/// <Summary>
/// Returns a JSON representation of the [DiagnosticsNode] for the root
/// [Element].
/// </Summary>
public virtual string GetRootWidget(string groupName)
{
    return _SafeJsonEncode(_GetRootWidget(groupName));
}




private Dictionary<string, @Object> _GetRootWidget(string groupName)
{
    return _NodeToJson(BindingDefaultClass.WidgetsBinding.Instance?.RenderViewElement?.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: groupName, service: this));
}




/// <Summary>
/// Returns a JSON representation of the [DiagnosticsNode] for the root
/// [Element] showing only nodes that should be included in a summary tree.
/// </Summary>
public virtual string GetRootWidgetSummaryTree(string groupName)
{
    return _SafeJsonEncode(_GetRootWidgetSummaryTree(groupName));
}




private Dictionary<string, @Object> _GetRootWidgetSummaryTree(string groupName)
{
    return _NodeToJson(BindingDefaultClass.WidgetsBinding.Instance?.RenderViewElement?.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: groupName, subtreeDepth: 1000000, summaryTree: true, service: this));
}




/// <Summary>
/// Returns a JSON representation of the [DiagnosticsNode] for the root
/// [RenderObject].
/// </Summary>
public virtual string GetRootRenderObject(string groupName)
{
    return _SafeJsonEncode(_GetRootRenderObject(groupName));
}




private Dictionary<string, @Object> _GetRootRenderObject(string groupName)
{
    return _NodeToJson(BindingDefaultClass.RendererBinding.Instance?.RenderView?.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: groupName, service: this));
}




/// <Summary>
/// Returns a JSON representation of the subtree rooted at the
/// [DiagnosticsNode] object that `diagnosticsNodeId` references providing
/// information needed for the details subtree view.
///
/// The number of levels of the subtree that should be returned is specified
/// by the [subtreeDepth] parameter. This value defaults to 2 for backwards
/// compatibility.
///
/// See also:
///
///  * [getChildrenDetailsSubtree], a method to get children of a node
///    in the details subtree.
/// </Summary>
public virtual string GetDetailsSubtree(string id, string groupName, int subtreeDepth = 2)
{
    return _SafeJsonEncode(_GetDetailsSubtree(id, groupName, subtreeDepth));
}




private Dictionary<string, @Object> _GetDetailsSubtree(string id, string groupName, int subtreeDepth)
{
    DiagnosticsNode root = ToObject(id) as DiagnosticsNode;
    if (root == null)
    {
        return null;
    }

    return _NodeToJson(root, new InspectorSerializationDelegate(groupName: groupName, summaryTree: false, subtreeDepth: subtreeDepth, includeProperties: true, service: this));
}




/// <Summary>
/// Returns a [DiagnosticsNode] representing the currently selected
/// [RenderObject].
///
/// If the currently selected [RenderObject] is identical to the
/// [RenderObject] referenced by `previousSelectionId` then the previous
/// [DiagnosticsNode] is reused.
/// </Summary>
public virtual string GetSelectedRenderObject(string previousSelectionId, string groupName)
{
    return _SafeJsonEncode(_GetSelectedRenderObject(previousSelectionId, groupName));
}




private Dictionary<string, @Object> _GetSelectedRenderObject(string previousSelectionId, string groupName)
{
    DiagnosticsNode previousSelection = ToObject(previousSelectionId) as DiagnosticsNode;
    RenderObject current = Selection?.Current;
    return _NodeToJson(current == previousSelection?.Value ? previousSelection : current?.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: groupName, service: this));
}




/// <Summary>
/// Returns a [DiagnosticsNode] representing the currently selected [Element].
///
/// If the currently selected [Element] is identical to the [Element]
/// referenced by `previousSelectionId` then the previous [DiagnosticsNode] is
/// reused.
/// </Summary>
public virtual string GetSelectedWidget(string previousSelectionId, string groupName)
{
    return _SafeJsonEncode(_GetSelectedWidget(previousSelectionId, groupName));
}




/// <Summary>
/// Captures an image of the current state of an [object] that is a
/// [RenderObject] or [Element].
///
/// The returned [ui.Image] has uncompressed raw RGBA bytes and will be scaled
/// to be at most [width] pixels wide and [height] pixels tall. The returned
/// image will never have a scale between logical pixels and the
/// size of the output image larger than maxPixelRatio.
/// [margin] indicates the number of pixels relative to the un-scaled size of
/// the [object] to include as a margin to include around the bounds of the
/// [object] in the screenshot. Including a margin can be useful to capture
/// areas that are slightly outside of the normal bounds of an object such as
/// some debug paint information.
/// </Summary>
public virtual Future<SKImage> Screenshot(@Object @object, double width = default(double), double height = default(double), double margin = 0.0, double maxPixelRatio = 1.0, bool debugPaint = false)
async
{
    if (!(object is Element) && !(object is RenderObject))
    {
        return null;
    }

    RenderObject renderObject = object is Element ? object.RenderObject : (object as RenderObject);
    if (renderObject == null || !renderObject.Attached)
    {
        return null;
    }

    if (renderObject.DebugNeedsLayout)
    {
        PipelineOwner owner = renderObject.Owner;


        ;
        owner.FlushLayout();
        owner.FlushCompositingBits();
        owner.FlushPaint();
        if (renderObject.DebugNeedsLayout)
        {
            return null;
        }

    }

    Rect renderBounds = WidgetinspectorDefaultClass._CalculateSubtreeBounds(renderObject);
    if (margin != 0.0)
    {
        renderBounds = renderBounds.Inflate(margin);
    }

    if (renderBounds.IsEmpty())
    {
        return null;
    }

    double pixelRatio = Math.Dart:mathDefaultClass.Min(maxPixelRatio, Math.Dart:mathDefaultClass.Min(width / renderBounds.Width, height / renderBounds.Height));
    return WidgetinspectorDefaultClass._ScreenshotPaintingContext.ToImage(renderObject, renderBounds, pixelRatio: pixelRatio, debugPaint: debugPaint);
}




private Dictionary<string, @Object> _GetSelectedWidget(string previousSelectionId, string groupName)
{
    DiagnosticsNode previousSelection = ToObject(previousSelectionId) as DiagnosticsNode;
    Element current = Selection?.CurrentElement;
    return _NodeToJson(current == previousSelection?.Value ? previousSelection : current?.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: groupName, service: this));
}




/// <Summary>
/// Returns a [DiagnosticsNode] representing the currently selected [Element]
/// if the selected [Element] should be shown in the summary tree otherwise
/// returns the first ancestor of the selected [Element] shown in the summary
/// tree.
///
/// If the currently selected [Element] is identical to the [Element]
/// referenced by `previousSelectionId` then the previous [DiagnosticsNode] is
/// reused.
/// </Summary>
public virtual string GetSelectedSummaryWidget(string previousSelectionId, string groupName)
{
    return _SafeJsonEncode(_GetSelectedSummaryWidget(previousSelectionId, groupName));
}




private Dictionary<string, @Object> _GetSelectedSummaryWidget(string previousSelectionId, string groupName)
{
    if (!IsWidgetCreationTracked())
    {
        return _GetSelectedWidget(previousSelectionId, groupName);
    }

    DiagnosticsNode previousSelection = ToObject(previousSelectionId) as DiagnosticsNode;
    Element current = Selection?.CurrentElement;
    if (current != null && !_IsValueCreatedByLocalProject(current))
    {
        Element firstLocal = default(Element);
        foreach (Element candidate in current.DebugGetDiagnosticChain())
        {
            if (_IsValueCreatedByLocalProject(candidate))
            {
                firstLocal = candidate;
                break;
            }

        }

        current = firstLocal;
    }

    return _NodeToJson(current == previousSelection?.Value ? previousSelection : current?.ToDiagnosticsNode(), new InspectorSerializationDelegate(groupName: groupName, service: this));
}




/// <Summary>
/// Returns whether [Widget] creation locations are available.
///
/// [Widget] creation locations are only available for debug mode builds when
/// the `--track-widget-creation` flag is passed to `flutter_tool`. Dart 2.0
/// is required as injecting creation locations requires a
/// [Dart Kernel Transformer](https://github.com/dart-lang/sdk/wiki/Kernel-Documentation).
/// </Summary>
public virtual bool IsWidgetCreationTracked()
{
    _WidgetCreationTracked = (_WidgetCreationTracked == null ? new _WidgetForTypeTests() is _HasCreationLocation : _WidgetCreationTracked);
    return _WidgetCreationTracked;
}




private void _OnFrameStart(TimeSpan timeStamp)
{
    _FrameStart = timeStamp;
    BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback(_OnFrameEnd);
}




private void _OnFrameEnd(TimeSpan timeStamp)
{
    if (_TrackRebuildDirtyWidgets)
    {
        _PostStatsEvent("Flutter.RebuiltWidgets", _RebuildStats);
    }

    if (_TrackRepaintWidgets)
    {
        _PostStatsEvent("Flutter.RepaintWidgets", _RepaintStats);
    }

}




private void _PostStatsEvent(string eventName, FlutterSDK.Widgets.Widgetinspector._ElementLocationStatsTracker stats)
{
    PostEvent(eventName, stats.ExportToJson(_FrameStart));
}




/// <Summary>
/// All events dispatched by a [WidgetInspectorService] use this method
/// instead of calling [developer.postEvent] directly so that tests for
/// [WidgetInspectorService] can track which events were dispatched by
/// overriding this method.
/// </Summary>
public virtual void PostEvent(string eventKind, Dictionary<@Object, @Object> eventData)
{
    Developer.Dart:developerDefaultClass.PostEvent(eventKind, eventData);
}




private void _OnRebuildWidget(FlutterSDK.Widgets.Framework.Element element, bool builtOnce)
{
    _RebuildStats.Add(element);
}




private void _OnPaint(FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    try
    {
        Element element = renderObject.DebugCreator?.Element as Element;
        if (!(element is RenderObjectElement))
        {
            return;
        }

        _RepaintStats.Add(element);
        element.VisitAncestorElements((Element ancestor) =>
        {
            if (ancestor is RenderObjectElement)
            {
                return false;
            }

            _RepaintStats.Add(ancestor);
            return true;
        }
        );
    }
    catch (exception,stack){
    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack));
}

}




/// <Summary>
/// This method is called by [WidgetBinding.performReassemble] to flush caches
/// of obsolete values after a hot reload.
///
/// Do not call this method directly. Instead, use
/// [BindingBase.reassembleApplication].
/// </Summary>
public virtual void PerformReassemble()
{
    _ClearStats();
    _ResetErrorCount();
}



}
public static class WidgetInspectorServiceMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetInspectorService, WidgetInspectorService> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetInspectorService, WidgetInspectorService>();
    static WidgetInspectorService GetOrCreate(IWidgetInspectorService instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new WidgetInspectorService();
            _table.Add(instance, value);
        }
        return (WidgetInspectorService)value;
    }
    public static FlutterSDK.Widgets.Widgetinspector.InspectorSelection SelectionProperty(this IWidgetInspectorService instance) => GetOrCreate(instance).Selection;
    public static FlutterSDK.Widgets.Widgetinspector.InspectorSelectionChangedCallback SelectionChangedCallbackProperty(this IWidgetInspectorService instance) => GetOrCreate(instance).SelectionChangedCallback;
    public static FlutterSDK.Widgets.Widgetinspector.WidgetInspectorService InstanceProperty(this IWidgetInspectorService instance) => GetOrCreate(instance).Instance;
    public static void RegisterServiceExtension(this IWidgetInspectorService instance, string name = default(string), FlutterSDK.Foundation.Binding.ServiceExtensionCallback callback = default(FlutterSDK.Foundation.Binding.ServiceExtensionCallback)) => GetOrCreate(instance).RegisterServiceExtension(name, callback);
    public static Future<object> ForceRebuild(this IWidgetInspectorService instance) => GetOrCreate(instance).ForceRebuild();
    public static void InitServiceExtensions(this IWidgetInspectorService instance, FlutterSDK.Widgets.Widgetinspector._RegisterServiceExtensionCallback registerServiceExtensionCallback) => GetOrCreate(instance).InitServiceExtensions(registerServiceExtensionCallback);
    public static void DisposeAllGroups(this IWidgetInspectorService instance) => GetOrCreate(instance).DisposeAllGroups();
    public static void DisposeGroup(this IWidgetInspectorService instance, string name) => GetOrCreate(instance).DisposeGroup(name);
    public static string ToId(this IWidgetInspectorService instance, @Object @object, string groupName) => GetOrCreate(instance).ToId(@object, groupName);
    public static bool IsWidgetTreeReady(this IWidgetInspectorService instance, string groupName = default(string)) => GetOrCreate(instance).IsWidgetTreeReady(groupName);
    public static @Object ToObject(this IWidgetInspectorService instance, string id, string groupName = default(string)) => GetOrCreate(instance).ToObject(id, groupName);
    public static @Object ToObjectForSourceLocation(this IWidgetInspectorService instance, string id, string groupName = default(string)) => GetOrCreate(instance).ToObjectForSourceLocation(id, groupName);
    public static void DisposeId(this IWidgetInspectorService instance, string id, string groupName) => GetOrCreate(instance).DisposeId(id, groupName);
    public static void SetPubRootDirectories(this IWidgetInspectorService instance, List<string> pubRootDirectories) => GetOrCreate(instance).SetPubRootDirectories(pubRootDirectories);
    public static bool SetSelectionById(this IWidgetInspectorService instance, string id, string groupName = default(string)) => GetOrCreate(instance).SetSelectionById(id, groupName);
    public static bool SetSelection(this IWidgetInspectorService instance, @Object @object, string groupName = default(string)) => GetOrCreate(instance).SetSelection(@object, groupName);
    public static string GetParentChain(this IWidgetInspectorService instance, string id, string groupName) => GetOrCreate(instance).GetParentChain(id, groupName);
    public static string GetProperties(this IWidgetInspectorService instance, string diagnosticsNodeId, string groupName) => GetOrCreate(instance).GetProperties(diagnosticsNodeId, groupName);
    public static string GetChildren(this IWidgetInspectorService instance, string diagnosticsNodeId, string groupName) => GetOrCreate(instance).GetChildren(diagnosticsNodeId, groupName);
    public static string GetChildrenSummaryTree(this IWidgetInspectorService instance, string diagnosticsNodeId, string groupName) => GetOrCreate(instance).GetChildrenSummaryTree(diagnosticsNodeId, groupName);
    public static string GetChildrenDetailsSubtree(this IWidgetInspectorService instance, string diagnosticsNodeId, string groupName) => GetOrCreate(instance).GetChildrenDetailsSubtree(diagnosticsNodeId, groupName);
    public static string GetRootWidget(this IWidgetInspectorService instance, string groupName) => GetOrCreate(instance).GetRootWidget(groupName);
    public static string GetRootWidgetSummaryTree(this IWidgetInspectorService instance, string groupName) => GetOrCreate(instance).GetRootWidgetSummaryTree(groupName);
    public static string GetRootRenderObject(this IWidgetInspectorService instance, string groupName) => GetOrCreate(instance).GetRootRenderObject(groupName);
    public static string GetDetailsSubtree(this IWidgetInspectorService instance, string id, string groupName, int subtreeDepth = 2) => GetOrCreate(instance).GetDetailsSubtree(id, groupName, subtreeDepth);
    public static string GetSelectedRenderObject(this IWidgetInspectorService instance, string previousSelectionId, string groupName) => GetOrCreate(instance).GetSelectedRenderObject(previousSelectionId, groupName);
    public static string GetSelectedWidget(this IWidgetInspectorService instance, string previousSelectionId, string groupName) => GetOrCreate(instance).GetSelectedWidget(previousSelectionId, groupName);
    public static Future<SKImage> Screenshot(this IWidgetInspectorService instance, @Object @object, double width = default(double), double height = default(double), double margin = 0.0, double maxPixelRatio = 1.0, bool debugPaint = false) => GetOrCreate(instance).Screenshot(@object, width, height, margin, maxPixelRatio, debugPaint);
    public static string GetSelectedSummaryWidget(this IWidgetInspectorService instance, string previousSelectionId, string groupName) => GetOrCreate(instance).GetSelectedSummaryWidget(previousSelectionId, groupName);
    public static bool IsWidgetCreationTracked(this IWidgetInspectorService instance) => GetOrCreate(instance).IsWidgetCreationTracked();
    public static void PostEvent(this IWidgetInspectorService instance, string eventKind, Dictionary<@Object, @Object> eventData) => GetOrCreate(instance).PostEvent(eventKind, eventData);
    public static void PerformReassemble(this IWidgetInspectorService instance) => GetOrCreate(instance).PerformReassemble();
}


public interface I_WidgetInspectorService : IWidgetInspectorService { }

public class _WidgetInspectorService : IWidgetInspectorService
{
}
public static class _WidgetInspectorServiceMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<I_WidgetInspectorService, _WidgetInspectorService> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_WidgetInspectorService, _WidgetInspectorService>();
    static _WidgetInspectorService GetOrCreate(I_WidgetInspectorService instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new _WidgetInspectorService();
            _table.Add(instance, value);
        }
        return (_WidgetInspectorService)value;
    }
}


public interface I_ElementLocationStatsTracker { }

public class _ElementLocationStatsTracker
{
    internal virtual List<FlutterSDK.Widgets.Widgetinspector._LocationCount> _Stats { get; set; }
    public virtual List<FlutterSDK.Widgets.Widgetinspector._LocationCount> Active { get; set; }
    public virtual List<FlutterSDK.Widgets.Widgetinspector._LocationCount> NewLocations { get; set; }

    /// <Summary>
    /// Increments the count associated with the creation location of [element] if
    /// the creation location is local to the current project.
    /// </Summary>
    public virtual void Add(FlutterSDK.Widgets.Framework.Element element)
    {
        object widget = element.Widget;
        if (!(widget is _HasCreationLocation))
        {
            return;
        }

        _HasCreationLocation creationLocationSource = widget as _HasCreationLocation;
        _Location location = creationLocationSource._Location;
        int id = WidgetinspectorDefaultClass._ToLocationId(location);
        _LocationCount entry = default(_LocationCount);
        if (id >= _Stats.Count || _Stats[id] == null)
        {
            while (id >= _Stats.Count)
            {
                _Stats.Add(null);
            }

            entry = new _LocationCount(location: location, id: id, local: WidgetinspectorDefaultClass.WidgetInspectorService.Instance._IsLocalCreationLocation(location));
            if (entry.Local)
            {
                NewLocations.Add(entry);
            }

            _Stats[id] = entry;
        }
        else
        {
            entry = _Stats[id];
        }

        if (entry.Local)
        {
            if (entry.Count == 0)
            {
                Active.Add(entry);
            }

            entry.Increment();
        }

    }




    /// <Summary>
    /// Clear all aggregated statistics.
    /// </Summary>
    public virtual void ResetCounts()
    {
        foreach (_LocationCount entry in Active)
        {
            entry.Reset();
        }

        Active.Clear();
    }




    /// <Summary>
    /// Exports the current counts and then resets the stats to prepare to track
    /// the next frame of data.
    /// </Summary>
    public virtual Dictionary<string, object> ExportToJson(TimeSpan startTime)
    {
        List<int> events = List<int>.Filled(Active.Count * 2, 0);
        int j = 0;
        foreach (_LocationCount stat in Active)
        {
            events[j++] = stat.Id;
            events[j++] = stat.Count;
        }

        Dictionary<string, object> json = new Dictionary<string, object> { { "startTime", startTime.InMicroseconds() }{ "events", events } };
        if (NewLocations.IsNotEmpty)
        {
            Dictionary<string, List<int>> locationsJson = new Dictionary<string, List<int>> { };
            foreach (_LocationCount entry in NewLocations)
            {
                _Location location = entry.Location;
                List<int> jsonForFile = locationsJson.PutIfAbsent(location.File, () => =>new List<int>() { });
                ;
                jsonForFile.Add(entry.Id);
                jsonForFile.Add(location.Line);
                jsonForFile.Add(location.Column);
            }

            json["newLocations"] = locationsJson;
        }

        ResetCounts();
        NewLocations.Clear();
        return json;
    }



}
public static class _ElementLocationStatsTrackerMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<I_ElementLocationStatsTracker, _ElementLocationStatsTracker> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_ElementLocationStatsTracker, _ElementLocationStatsTracker>();
    static _ElementLocationStatsTracker GetOrCreate(I_ElementLocationStatsTracker instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new _ElementLocationStatsTracker();
            _table.Add(instance, value);
        }
        return (_ElementLocationStatsTracker)value;
    }
    public static List<FlutterSDK.Widgets.Widgetinspector._LocationCount> ActiveProperty(this I_ElementLocationStatsTracker instance) => GetOrCreate(instance).Active;
    public static List<FlutterSDK.Widgets.Widgetinspector._LocationCount> NewLocationsProperty(this I_ElementLocationStatsTracker instance) => GetOrCreate(instance).NewLocations;
    public static void Add(this I_ElementLocationStatsTracker instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).Add(element);
    public static void ResetCounts(this I_ElementLocationStatsTracker instance) => GetOrCreate(instance).ResetCounts();
    public static Dictionary<string, object> ExportToJson(this I_ElementLocationStatsTracker instance, TimeSpan startTime) => GetOrCreate(instance).ExportToJson(startTime);
}


public interface IInspectorSelection { }

public class InspectorSelection
{
    internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _Candidates { get; set; }
    internal virtual int _Index { get; set; }
    internal virtual FlutterSDK.Rendering.@object.RenderObject _Current { get; set; }
    internal virtual FlutterSDK.Widgets.Framework.Element _CurrentElement { get; set; }
    public virtual List<FlutterSDK.Rendering.@object.RenderObject> Candidates { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual int Index { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Rendering.@object.RenderObject Current { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Widgets.Framework.Element CurrentElement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool Active { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    /// <Summary>
    /// Set the selection to empty.
    /// </Summary>
    public virtual void Clear()
    {
        _Candidates = new List<RenderObject>() { };
        _Index = 0;
        _ComputeCurrent();
    }




    private void _ComputeCurrent()
    {
        if (_Index < Candidates.Count)
        {
            _Current = Candidates[Index];
            _CurrentElement = _Current.DebugCreator.Element as Element;
        }
        else
        {
            _Current = null;
            _CurrentElement = null;
        }

    }



}
public static class InspectorSelectionMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<IInspectorSelection, InspectorSelection> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IInspectorSelection, InspectorSelection>();
    static InspectorSelection GetOrCreate(IInspectorSelection instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new InspectorSelection();
            _table.Add(instance, value);
        }
        return (InspectorSelection)value;
    }
    public static List<FlutterSDK.Rendering.@object.RenderObject> CandidatesProperty(this IInspectorSelection instance) => GetOrCreate(instance).Candidates;
    public static int IndexProperty(this IInspectorSelection instance) => GetOrCreate(instance).Index;
    public static FlutterSDK.Rendering.@object.RenderObject CurrentProperty(this IInspectorSelection instance) => GetOrCreate(instance).Current;
    public static FlutterSDK.Widgets.Framework.Element CurrentElementProperty(this IInspectorSelection instance) => GetOrCreate(instance).CurrentElement;
    public static bool ActiveProperty(this IInspectorSelection instance) => GetOrCreate(instance).Active;
    public static void Clear(this IInspectorSelection instance) => GetOrCreate(instance).Clear();
}


public interface I_HasCreationLocation { }

public class _HasCreationLocation
{
    internal virtual FlutterSDK.Widgets.Widgetinspector._Location _Location { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
}
public static class _HasCreationLocationMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<I_HasCreationLocation, _HasCreationLocation> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_HasCreationLocation, _HasCreationLocation>();
    static _HasCreationLocation GetOrCreate(I_HasCreationLocation instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new _HasCreationLocation();
            _table.Add(instance, value);
        }
        return (_HasCreationLocation)value;
    }
}


/// <Summary>
/// A layer that mimics the behavior of another layer.
///
/// A proxy layer is used for cases where a layer needs to be placed into
/// multiple trees of layers.
/// </Summary>
public class _ProxyLayer : FlutterSDK.Rendering.Layer.Layer
{
    #region constructors
    public _ProxyLayer(FlutterSDK.Rendering.Layer.Layer _layer)

}
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.Layer _Layer { get; set; }
#endregion

#region methods

public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
{
    _Layer.AddToScene(builder, layerOffset);
}




public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
{
    return _Layer.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
}



#endregion
}


/// <Summary>
/// A [Canvas] that multicasts all method calls to a main canvas and a
/// secondary screenshot canvas so that a screenshot can be recorded at the same
/// time as performing a normal paint.
/// </Summary>
public class _MulticastCanvas : ICanvas
{
    #region constructors
    public _MulticastCanvas(Canvas main = default(Canvas), Canvas screenshot = default(Canvas))
    : base()

}
#endregion

#region fields
internal virtual Canvas _Main { get; set; }
internal virtual Canvas _Screenshot { get; set; }
#endregion

#region methods

public new void ClipPath(Path path, bool doAntiAlias = true)
{
    _Main.ClipPath(path, doAntiAlias: doAntiAlias);
    _Screenshot.ClipPath(path, doAntiAlias: doAntiAlias);
}




public new void ClipRRect(FlutterBinding.UI.RRect rrect, bool doAntiAlias = true)
{
    _Main.ClipRRect(rrect, doAntiAlias: doAntiAlias);
    _Screenshot.ClipRRect(rrect, doAntiAlias: doAntiAlias);
}




public new void ClipRect(FlutterBinding.UI.Rect rect, ClipOp clipOp = default(ClipOp), bool doAntiAlias = true)
{
    _Main.ClipRect(rect, clipOp: clipOp, doAntiAlias: doAntiAlias);
    _Screenshot.ClipRect(rect, clipOp: clipOp, doAntiAlias: doAntiAlias);
}




public new void DrawArc(FlutterBinding.UI.Rect rect, double startAngle, double sweepAngle, bool useCenter, SKPaint paint)
{
    _Main.DrawArc(rect, startAngle, sweepAngle, useCenter, paint);
    _Screenshot.DrawArc(rect, startAngle, sweepAngle, useCenter, paint);
}




public new void DrawAtlas(SKImage atlas, List<RSTransform> transforms, List<Rect> rects, List<Color> colors, FlutterBinding.UI.BlendMode blendMode, FlutterBinding.UI.Rect cullRect, SKPaint paint)
{
    _Main.DrawAtlas(atlas, transforms, rects, colors, blendMode, cullRect, paint);
    _Screenshot.DrawAtlas(atlas, transforms, rects, colors, blendMode, cullRect, paint);
}




public new void DrawCircle(FlutterBinding.UI.Offset c, double radius, SKPaint paint)
{
    _Main.DrawCircle(c, radius, paint);
    _Screenshot.DrawCircle(c, radius, paint);
}




public new void DrawColor(FlutterBinding.UI.Color color, FlutterBinding.UI.BlendMode blendMode)
{
    _Main.DrawColor(color, blendMode);
    _Screenshot.DrawColor(color, blendMode);
}




public new void DrawDRRect(FlutterBinding.UI.RRect outer, FlutterBinding.UI.RRect inner, SKPaint paint)
{
    _Main.DrawDRRect(outer, inner, paint);
    _Screenshot.DrawDRRect(outer, inner, paint);
}




public new void DrawImage(SKImage image, FlutterBinding.UI.Offset p, SKPaint paint)
{
    _Main.DrawImage(image, p, paint);
    _Screenshot.DrawImage(image, p, paint);
}




public new void DrawImageNine(SKImage image, FlutterBinding.UI.Rect center, FlutterBinding.UI.Rect dst, SKPaint paint)
{
    _Main.DrawImageNine(image, center, dst, paint);
    _Screenshot.DrawImageNine(image, center, dst, paint);
}




public new void DrawImageRect(SKImage image, FlutterBinding.UI.Rect src, FlutterBinding.UI.Rect dst, SKPaint paint)
{
    _Main.DrawImageRect(image, src, dst, paint);
    _Screenshot.DrawImageRect(image, src, dst, paint);
}




public new void DrawLine(FlutterBinding.UI.Offset p1, FlutterBinding.UI.Offset p2, SKPaint paint)
{
    _Main.DrawLine(p1, p2, paint);
    _Screenshot.DrawLine(p1, p2, paint);
}




public new void DrawOval(FlutterBinding.UI.Rect rect, SKPaint paint)
{
    _Main.DrawOval(rect, paint);
    _Screenshot.DrawOval(rect, paint);
}




public new void DrawPaint(SKPaint paint)
{
    _Main.DrawPaint(paint);
    _Screenshot.DrawPaint(paint);
}




public new void DrawParagraph(FlutterBinding.UI.Paragraph paragraph, FlutterBinding.UI.Offset offset)
{
    _Main.DrawParagraph(paragraph, offset);
    _Screenshot.DrawParagraph(paragraph, offset);
}




public new void DrawPath(Path path, SKPaint paint)
{
    _Main.DrawPath(path, paint);
    _Screenshot.DrawPath(path, paint);
}




public new void DrawPicture(SKPicture picture)
{
    _Main.DrawPicture(picture);
    _Screenshot.DrawPicture(picture);
}




public new void DrawPoints(FlutterBinding.UI.PointMode pointMode, List<FlutterBinding.UI.Offset> points, SKPaint paint)
{
    _Main.DrawPoints(pointMode, points, paint);
    _Screenshot.DrawPoints(pointMode, points, paint);
}




public new void DrawRRect(FlutterBinding.UI.RRect rrect, SKPaint paint)
{
    _Main.DrawRRect(rrect, paint);
    _Screenshot.DrawRRect(rrect, paint);
}




public new void DrawRawAtlas(SKImage atlas, List<double> rstTransforms, List<double> rects, List<uint> colors, FlutterBinding.UI.BlendMode blendMode, FlutterBinding.UI.Rect cullRect, SKPaint paint)
{
    _Main.DrawRawAtlas(atlas, rstTransforms, rects, colors, blendMode, cullRect, paint);
    _Screenshot.DrawRawAtlas(atlas, rstTransforms, rects, colors, blendMode, cullRect, paint);
}




public new void DrawRawPoints(FlutterBinding.UI.PointMode pointMode, List<double> points, SKPaint paint)
{
    _Main.DrawRawPoints(pointMode, points, paint);
    _Screenshot.DrawRawPoints(pointMode, points, paint);
}




public new void DrawRect(FlutterBinding.UI.Rect rect, SKPaint paint)
{
    _Main.DrawRect(rect, paint);
    _Screenshot.DrawRect(rect, paint);
}




public new void DrawShadow(Path path, FlutterBinding.UI.Color color, double elevation, bool transparentOccluder)
{
    _Main.DrawShadow(path, color, elevation, transparentOccluder);
    _Screenshot.DrawShadow(path, color, elevation, transparentOccluder);
}




public new void DrawVertices(SKVertices vertices, FlutterBinding.UI.BlendMode blendMode, SKPaint paint)
{
    _Main.DrawVertices(vertices, blendMode, paint);
    _Screenshot.DrawVertices(vertices, blendMode, paint);
}




public new int GetSaveCount()
{
    return _Main.GetSaveCount();
}




public new void Restore()
{
    _Main.Restore();
    _Screenshot.Restore();
}




public new void Rotate(double radians)
{
    _Main.Rotate(radians);
    _Screenshot.Rotate(radians);
}




public new void Save()
{
    _Main.Save();
    _Screenshot.Save();
}




public new void SaveLayer(FlutterBinding.UI.Rect bounds, SKPaint paint)
{
    _Main.SaveLayer(bounds, paint);
    _Screenshot.SaveLayer(bounds, paint);
}




public new void Scale(double sx, double sy = default(double))
{
    _Main.Scale(sx, sy);
    _Screenshot.Scale(sx, sy);
}




public new void Skew(double sx, double sy)
{
    _Main.Skew(sx, sy);
    _Screenshot.Skew(sx, sy);
}




public new void Transform(List<float> matrix4)
{
    _Main.Transform(matrix4);
    _Screenshot.Transform(matrix4);
}




public new void Translate(double dx, double dy)
{
    _Main.Translate(dx, dy);
    _Screenshot.Translate(dx, dy);
}



#endregion
}


/// <Summary>
/// A layer that omits its own offset when adding children to the scene so that
/// screenshots render to the scene in the local coordinate system of the layer.
/// </Summary>
public class _ScreenshotContainerLayer : FlutterSDK.Rendering.Layer.OffsetLayer
{
    #region constructors
    public _ScreenshotContainerLayer()
    { }
    #endregion

    #region fields
    #endregion

    #region methods

    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {
        AddChildrenToScene(builder, layerOffset);
    }



    #endregion
}


/// <Summary>
/// Data shared between nested [_ScreenshotPaintingContext] objects recording
/// a screenshot.
/// </Summary>
public class _ScreenshotData
{
    #region constructors
    public _ScreenshotData(FlutterSDK.Rendering.@object.RenderObject target = default(FlutterSDK.Rendering.@object.RenderObject))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.@object.RenderObject Target { get; set; }
public virtual FlutterSDK.Rendering.Layer.OffsetLayer ContainerLayer { get; set; }
public virtual bool FoundTarget { get; set; }
public virtual bool IncludeInScreenshot { get; set; }
public virtual bool IncludeInRegularContext { get; set; }
public virtual FlutterBinding.UI.Offset ScreenshotOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods
#endregion
}


/// <Summary>
/// A place to paint to build screenshots of [RenderObject]s.
///
/// Requires that the render objects have already painted successfully as part
/// of the regular rendering pipeline.
/// This painting context behaves the same as standard [PaintingContext] with
/// instrumentation added to compute a screenshot of a specified [RenderObject]
/// added. To correctly mimic the behavior of the regular rendering pipeline, the
/// full subtree of the first [RepaintBoundary] ancestor of the specified
/// [RenderObject] will also be rendered rather than just the subtree of the
/// render object.
/// </Summary>
public class _ScreenshotPaintingContext : FlutterSDK.Rendering.@object.PaintingContext
{
    #region constructors
    public _ScreenshotPaintingContext(FlutterSDK.Rendering.Layer.ContainerLayer containerLayer = default(FlutterSDK.Rendering.Layer.ContainerLayer), FlutterBinding.UI.Rect estimatedBounds = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Widgetinspector._ScreenshotData screenshotData = default(FlutterSDK.Widgets.Widgetinspector._ScreenshotData))
    : base(containerLayer, estimatedBounds)

}
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Widgetinspector._ScreenshotData _Data { get; set; }
internal virtual FlutterSDK.Rendering.Layer.PictureLayer _ScreenshotCurrentLayer { get; set; }
internal virtual PictureRecorder _ScreenshotRecorder { get; set; }
internal virtual Canvas _ScreenshotCanvas { get; set; }
internal virtual FlutterSDK.Widgets.Widgetinspector._MulticastCanvas _MulticastCanvas { get; set; }
public virtual Canvas Canvas { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual bool _IsScreenshotRecording { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _StartRecordingScreenshot()
{


    _ScreenshotCurrentLayer = new PictureLayer(EstimatedBounds);
    _ScreenshotRecorder = new Ui.PictureRecorder();
    _ScreenshotCanvas = new Canvas(_ScreenshotRecorder);
    _Data.ContainerLayer.Append(_ScreenshotCurrentLayer);
    if (_Data.IncludeInRegularContext)
    {
        _MulticastCanvas = new _MulticastCanvas(main: base.Canvas, screenshot: _ScreenshotCanvas);
    }
    else
    {
        _MulticastCanvas = null;
    }

}




public new void StopRecordingIfNeeded()
{
    base.StopRecordingIfNeeded();
    _StopRecordingScreenshotIfNeeded();
}




private void _StopRecordingScreenshotIfNeeded()
{
    if (!_IsScreenshotRecording) return;
    _ScreenshotCurrentLayer.Picture = _ScreenshotRecorder.EndRecording();
    _ScreenshotCurrentLayer = null;
    _ScreenshotRecorder = null;
    _MulticastCanvas = null;
    _ScreenshotCanvas = null;
}




public new void AppendLayer(FlutterSDK.Rendering.Layer.Layer layer)
{
    if (_Data.IncludeInRegularContext)
    {
        base.AppendLayer(layer);
        if (_Data.IncludeInScreenshot)
        {

            _Data.ContainerLayer.Append(new _ProxyLayer(layer));
        }

    }
    else
    {


        layer.Remove();
        _Data.ContainerLayer.Append(layer);
        return;
    }

}




public new FlutterSDK.Rendering.@object.PaintingContext CreateChildContext(FlutterSDK.Rendering.Layer.ContainerLayer childLayer, FlutterBinding.UI.Rect bounds)
{
    if (_Data.FoundTarget)
    {
        return base.CreateChildContext(childLayer, bounds);
    }
    else
    {
        return new _ScreenshotPaintingContext(containerLayer: childLayer, estimatedBounds: bounds, screenshotData: _Data);
    }

}




public new void PaintChild(FlutterSDK.Rendering.@object.RenderObject child, FlutterBinding.UI.Offset offset)
{
    bool isScreenshotTarget = Dart:coreDefaultClass.Identical(child, _Data.Target);
    if (isScreenshotTarget)
    {


        _Data.FoundTarget = true;
        _Data.ScreenshotOffset = offset;
        _Data.IncludeInScreenshot = true;
    }

    base.PaintChild(child, offset);
    if (isScreenshotTarget)
    {
        _StopRecordingScreenshotIfNeeded();
        _Data.IncludeInScreenshot = false;
    }

}




/// <Summary>
/// Captures an image of the current state of [renderObject] and its children.
///
/// The returned [ui.Image] has uncompressed raw RGBA bytes, will be offset
/// by the top-left corner of [renderBounds], and have dimensions equal to the
/// size of [renderBounds] multiplied by [pixelRatio].
///
/// To use [toImage], the render object must have gone through the paint phase
/// (i.e. [debugNeedsPaint] must be false).
///
/// The [pixelRatio] describes the scale between the logical pixels and the
/// size of the output image. It is independent of the
/// [window.devicePixelRatio] for the device, so specifying 1.0 (the default)
/// will give you a 1:1 mapping between logical pixels and the output pixels
/// in the image.
///
/// The [debugPaint] argument specifies whether the image should include the
/// output of [RenderObject.debugPaint] for [renderObject] with
/// [debugPaintSizeEnabled] set to true. Debug paint information is not
/// included for the children of [renderObject] so that it is clear precisely
/// which object the debug paint information references.
///
/// See also:
///
///  * [RenderRepaintBoundary.toImage] for a similar API for [RenderObject]s
///    that are repaint boundaries that can be used outside of the inspector.
///  * [OffsetLayer.toImage] for a similar API at the layer level.
///  * [dart:ui.Scene.toImage] for more information about the image returned.
/// </Summary>
public virtual Future<SKImage> ToImage(FlutterSDK.Rendering.@object.RenderObject renderObject, FlutterBinding.UI.Rect renderBounds, double pixelRatio = 1.0, bool debugPaint = false)
{
    RenderObject repaintBoundary = renderObject;
    while (repaintBoundary != null && !repaintBoundary.IsRepaintBoundary)
    {
        repaintBoundary = repaintBoundary.Parent as RenderObject;
    }


    _ScreenshotData data = new _ScreenshotData(target: renderObject);
    _ScreenshotPaintingContext context = new _ScreenshotPaintingContext(containerLayer: repaintBoundary.DebugLayer, estimatedBounds: repaintBoundary.PaintBounds, screenshotData: data);
    if (Dart:coreDefaultClass.Identical(renderObject, repaintBoundary)){
        data.ContainerLayer.Append(new _ProxyLayer(repaintBoundary.DebugLayer));
        data.FoundTarget = true;
        OffsetLayer offsetLayer = repaintBoundary.DebugLayer as OffsetLayer;
        data.ScreenshotOffset = offsetLayer.Offset;
    }
else
    {
        ObjectDefaultClass.PaintingContext.DebugInstrumentRepaintCompositedChild(repaintBoundary, customContext: context);
    }

    if (debugPaint && !DebugDefaultClass.DebugPaintSizeEnabled)
    {
        data.IncludeInRegularContext = false;
        context.StopRecordingIfNeeded();

        data.IncludeInScreenshot = true;
        DebugDefaultClass.DebugPaintSizeEnabled = true;
        try
        {
            renderObject.DebugPaint(context, data.ScreenshotOffset);
        }
        finally
        {
            DebugDefaultClass.DebugPaintSizeEnabled = false;
            context.StopRecordingIfNeeded();
        }

    }

    repaintBoundary.DebugLayer.BuildScene(new Ui.SceneBuilder());
    return data.ContainerLayer.ToImage(renderBounds, pixelRatio: pixelRatio);
}



#endregion
}


/// <Summary>
/// A class describing a step along a path through a tree of [DiagnosticsNode]
/// objects.
///
/// This class is used to bundle all data required to display the tree with just
/// the nodes along a path expanded into a single JSON payload.
/// </Summary>
public class _DiagnosticsPathNode
{
    #region constructors
    public _DiagnosticsPathNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> children = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>), int childIndex = default(int))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode Node { get; set; }
public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> Children { get; set; }
public virtual int ChildIndex { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// Structure to help reference count Dart objects referenced by a GUI tool
/// using [WidgetInspectorService].
/// </Summary>
public class _InspectorReferenceData
{
    #region constructors
    public _InspectorReferenceData(@Object @object)

}
#endregion

#region fields
public virtual @Object @object { get; set; }
public virtual int Count { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// Accumulator for a count associated with a specific source location.
///
/// The accumulator stores whether the source location is [local] and what its
/// [id] for efficiency encoding terse JSON payloads describing counts.
/// </Summary>
public class _LocationCount
{
    #region constructors
    public _LocationCount(FlutterSDK.Widgets.Widgetinspector._Location location = default(FlutterSDK.Widgets.Widgetinspector._Location), int id = default(int), bool local = default(bool))

}
#endregion

#region fields
public virtual int Id { get; set; }
public virtual bool Local { get; set; }
public virtual FlutterSDK.Widgets.Widgetinspector._Location Location { get; set; }
internal virtual int _Count { get; set; }
public virtual int Count { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Reset the count.
/// </Summary>
public virtual void Reset()
{
    _Count = 0;
}




/// <Summary>
/// Increment the count.
/// </Summary>
public virtual void Increment()
{
    _Count++;
}



#endregion
}


public class _WidgetForTypeTests : FlutterSDK.Widgets.Framework.Widget
{
    #region constructors
    public _WidgetForTypeTests()
    { }
    #endregion

    #region fields
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Framework.Element CreateElement() => null;


    #endregion
}


/// <Summary>
/// A widget that enables inspecting the child widget's structure.
///
/// Select a location on your device or emulator and view what widgets and
/// render object that best matches the location. An outline of the selected
/// widget and terse summary information is shown on device with detailed
/// information is shown in the observatory or in IntelliJ when using the
/// Flutter Plugin.
///
/// The inspector has a select mode and a view mode.
///
/// In the select mode, tapping the device selects the widget that best matches
/// the location of the touch and switches to view mode. Dragging a finger on
/// the device selects the widget under the drag location but does not switch
/// modes. Touching the very edge of the bounding box of a widget triggers
/// selecting the widget even if another widget that also overlaps that
/// location would otherwise have priority.
///
/// In the view mode, the previously selected widget is outlined, however,
/// touching the device has the same effect it would have if the inspector
/// wasn't present. This allows interacting with the application and viewing how
/// the selected widget changes position. Clicking on the select icon in the
/// bottom left corner of the application switches back to select mode.
/// </Summary>
public class WidgetInspector : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public WidgetInspector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder selectButtonBuilder = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder SelectButtonBuilder { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Widgetinspector._WidgetInspectorState CreateState() => new _WidgetInspectorState();


#endregion
}


public class _WidgetInspectorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Widgetinspector.WidgetInspector>, IWidgetsBindingObserver
{
    #region constructors
    public _WidgetInspectorState()
    : base()

}
#endregion

#region fields
internal virtual FlutterBinding.UI.Offset _LastPointerLocation { get; set; }
public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get; set; }
public virtual bool IsSelectMode { get; set; }
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _IgnorePointerKey { get; set; }
internal virtual double _EdgeHitMargin { get; set; }
internal virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelectionChangedCallback _SelectionChangedCallback { get; set; }
#endregion

#region methods

public new void InitState()
{
    base.InitState();
    _SelectionChangedCallback = () =>
    {
        SetState(() =>
        {
        }
        );
    }
    ;
    WidgetinspectorDefaultClass.WidgetInspectorService.Instance.SelectionChangedCallback = _SelectionChangedCallback;
}




public new void Dispose()
{
    if (WidgetinspectorDefaultClass.WidgetInspectorService.Instance.SelectionChangedCallback == _SelectionChangedCallback)
    {
        WidgetinspectorDefaultClass.WidgetInspectorService.Instance.SelectionChangedCallback = null;
    }

    base.Dispose();
}




private bool _HitTestHelper(List<FlutterSDK.Rendering.@object.RenderObject> hits, List<FlutterSDK.Rendering.@object.RenderObject> edgeHits, FlutterBinding.UI.Offset position, FlutterSDK.Rendering.@object.RenderObject @object, Matrix4 transform)
{
    bool hit = false;
    Matrix4 inverse = Matrix4.TryInvert(transform);
    if (inverse == null)
    {
        return false;
    }

    Offset localPosition = MatrixutilsDefaultClass.MatrixUtils.TransformPoint(inverse, position);
    List<DiagnosticsNode> children = object.DebugDescribeChildren();
    for (int i = children.Count - 1; i >= 0; i -= 1)
    {
        DiagnosticsNode diagnostics = children[i];

        if (diagnostics.Style == DiagnosticsTreeStyle.Offstage || !(diagnostics.Value is RenderObject)) continue;
        RenderObject child = diagnostics.Value as RenderObject;
        Rect paintClip = object.DescribeApproximatePaintClip(child);
        if (paintClip != null && !paintClip.Contains(localPosition)) continue;
        Matrix4 childTransform = transform.Clone();
        object.ApplyPaintTransform(child, childTransform);
        if (_HitTestHelper(hits, edgeHits, position, child, childTransform)) hit = true;
    }

    Rect bounds = object.SemanticBounds;
    if (bounds.Contains(localPosition))
    {
        hit = true;
        if (!bounds.Deflate(_EdgeHitMargin).Contains(localPosition)) edgeHits.Add(object);
    }

    if (hit) hits.Add(object);
    return hit;
}




/// <Summary>
/// Returns the list of render objects located at the given position ordered
/// by priority.
///
/// All render objects that are not offstage that match the location are
/// included in the list of matches. Priority is given to matches that occur
/// on the edge of a render object's bounding box and to matches found by
/// [RenderBox.hitTest].
/// </Summary>
public virtual List<FlutterSDK.Rendering.@object.RenderObject> HitTest(FlutterBinding.UI.Offset position, FlutterSDK.Rendering.@object.RenderObject root)
{
    List<RenderObject> regularHits = new List<RenderObject>() { };
    List<RenderObject> edgeHits = new List<RenderObject>() { };
    _HitTestHelper(regularHits, edgeHits, position, root, root.GetTransformTo(null));
    double _Area(RenderObject object) => {
        Size size = object.SemanticBounds?.Size;
        return size == null ? Dart : coreDefaultClass.Double.MaxFinite:size.Width* size.Height;
    }

    regularHits.Sort((RenderObject a, RenderObject b) => =>_Area(a).CompareTo(_Area(b)));
    HashSet<RenderObject> hits = new Dictionary<RenderObject> { {, edgeHits }{, regularHits } };
    return hits.ToList();
}




private void _InspectAt(FlutterBinding.UI.Offset position)
{
    if (!IsSelectMode) return;
    RenderIgnorePointer ignorePointer = _IgnorePointerKey.CurrentContext.FindRenderObject() as RenderIgnorePointer;
    RenderObject userRender = ignorePointer.Child;
    List<RenderObject> selected = HitTest(position, userRender);
    SetState(() =>
    {
        Selection.Candidates = selected;
    }
    );
}




private void _HandlePanDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails @event)
{
    _LastPointerLocation = @event.GlobalPosition;
    _InspectAt(@event.GlobalPosition);
}




private void _HandlePanUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails @event)
{
    _LastPointerLocation = @event.GlobalPosition;
    _InspectAt(@event.GlobalPosition);
}




private void _HandlePanEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
{
    Rect bounds = (Dart: uiDefaultClass.Offset.Zero & (BindingDefaultClass.WidgetsBinding.Instance.Window.PhysicalSize / BindingDefaultClass.WidgetsBinding.Instance.Window.DevicePixelRatio)).Deflate(WidgetinspectorDefaultClass._KOffScreenMargin);
    if (!bounds.Contains(_LastPointerLocation))
    {
        SetState(() =>
        {
            Selection.Clear();
        }
        );
    }

}




private void _HandleTap()
{
    if (!IsSelectMode) return;
    if (_LastPointerLocation != null)
    {
        _InspectAt(_LastPointerLocation);
        if (Selection != null)
        {
            Developer.Dart:developerDefaultClass.Inspect(Selection.Current);
}

}

SetState(() =>
{
    if (Widget.SelectButtonBuilder != null) IsSelectMode = false;
}
);
}




private void _HandleEnableSelect()
{
    SetState(() =>
    {
        IsSelectMode = true;
    }
    );
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new Stack(children: new List<Widget>() { new GestureDetector(onTap: _HandleTap, onPanDown: _HandlePanDown, onPanEnd: _HandlePanEnd, onPanUpdate: _HandlePanUpdate, behavior: HitTestBehavior.Opaque, excludeFromSemantics: true, child: new IgnorePointer(ignoring: IsSelectMode, key: _IgnorePointerKey, ignoringSemantics: false, child: Widget.Child)), });
}



#endregion
}


public class _InspectorOverlay : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
{
    #region constructors
    public _InspectorOverlay(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Widgetinspector.InspectorSelection selection = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelection))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Widgetinspector._RenderInspectorOverlay CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderInspectorOverlay(selection: Selection);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Widgetinspector._RenderInspectorOverlay renderObject)
{
    renderObject.Selection = Selection;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.Selection = Selection;
}



#endregion
}


public class _RenderInspectorOverlay : FlutterSDK.Rendering.Box.RenderBox
{
    #region constructors
    public _RenderInspectorOverlay(FlutterSDK.Widgets.Widgetinspector.InspectorSelection selection = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelection))
    : base()

}
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection _Selection { get; set; }
public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void PerformResize()
{
    Size = Constraints.Constrain(new Size(Dart: coreDefaultClass.Double.Infinity, Dart: coreDefaultClass.Double.Infinity));
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

    context.AddLayer(new _InspectorOverlayLayer(overlayRect: Rect.FromLTWH(offset.Dx, offset.Dy, Size.Width, Size.Height), selection: Selection));
}



#endregion
}


public class _TransformedRect
{
    #region constructors
    public _TransformedRect(FlutterSDK.Rendering.@object.RenderObject @object)
    : base()

}
#endregion

#region fields
public virtual FlutterBinding.UI.Rect Rect { get; set; }
public virtual Matrix4 Transform { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is _TransformedRect && other.Rect == Rect && other.Transform == Transform;
}



#endregion
}


/// <Summary>
/// State describing how the inspector overlay should be rendered.
///
/// The equality operator can be used to determine whether the overlay needs to
/// be rendered again.
/// </Summary>
public class _InspectorOverlayRenderState
{
    #region constructors
    public _InspectorOverlayRenderState(FlutterBinding.UI.Rect overlayRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Widgetinspector._TransformedRect selected = default(FlutterSDK.Widgets.Widgetinspector._TransformedRect), List<FlutterSDK.Widgets.Widgetinspector._TransformedRect> candidates = default(List<FlutterSDK.Widgets.Widgetinspector._TransformedRect>), string tooltip = default(string), TextDirection textDirection = default(TextDirection))

}
#endregion

#region fields
public virtual FlutterBinding.UI.Rect OverlayRect { get; set; }
public virtual FlutterSDK.Widgets.Widgetinspector._TransformedRect Selected { get; set; }
public virtual List<FlutterSDK.Widgets.Widgetinspector._TransformedRect> Candidates { get; set; }
public virtual string Tooltip { get; set; }
public virtual TextDirection TextDirection { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is _InspectorOverlayRenderState && other.OverlayRect == OverlayRect && other.Selected == Selected && CollectionsDefaultClass.ListEquals(other.Candidates, Candidates) && other.Tooltip == Tooltip;
}



#endregion
}


/// <Summary>
/// A layer that outlines the selected [RenderObject] and candidate render
/// objects that also match the last pointer location.
///
/// This approach is horrific for performance and is only used here because this
/// is limited to debug mode. Do not duplicate the logic in production code.
/// </Summary>
public class _InspectorOverlayLayer : FlutterSDK.Rendering.Layer.Layer
{
    #region constructors
    public _InspectorOverlayLayer(FlutterBinding.UI.Rect overlayRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Widgetinspector.InspectorSelection selection = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelection))
    : base()

bool inDebugMode = false;

if (inDebugMode==false ){
throw FlutterError.FromParts(new List<DiagnosticsNode>(){new ErrorSummary("The inspector should never be used in production mode due to the " + "negative performance impact.")});
}

}


#endregion

#region fields
public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get; set; }
public virtual FlutterBinding.UI.Rect OverlayRect { get; set; }
internal virtual FlutterSDK.Widgets.Widgetinspector._InspectorOverlayRenderState _LastState { get; set; }
internal virtual SKPicture _Picture { get; set; }
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _TextPainter { get; set; }
internal virtual double _TextPainterMaxWidth { get; set; }
#endregion

#region methods

public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
{
    if (!Selection.Active) return;
    RenderObject selected = Selection.Current;
    List<_TransformedRect> candidates = new List<_TransformedRect>() { };
    foreach (RenderObject candidate in Selection.Candidates)
    {
        if (candidate == selected || !candidate.Attached) continue;
        candidates.Add(new _TransformedRect(candidate));
    }

    _InspectorOverlayRenderState state = new _InspectorOverlayRenderState(overlayRect: OverlayRect, selected: new _TransformedRect(selected), tooltip: Selection.CurrentElement.ToStringShort(), textDirection: TextDirection.Ltr, candidates: candidates);
    if (state != _LastState)
    {
        _LastState = state;
        _Picture = _BuildPicture(state);
    }

    builder.AddPicture(layerOffset, _Picture);
}




private Picture _BuildPicture(FlutterSDK.Widgets.Widgetinspector._InspectorOverlayRenderState state)
{
    Ui.Dart:uiDefaultClass.PictureRecorder recorder = new Ui.PictureRecorder();
Canvas canvas = new Canvas(recorder, state.OverlayRect);
Size size = state.OverlayRect.Size;
Paint fillPaint = new Paint()..Style = PaintingStyle.Fill..Color = WidgetinspectorDefaultClass._KHighlightedRenderObjectFillColor;
Paint borderPaint = new Paint()..Style = PaintingStyle.Stroke..StrokeWidth = 1.0..Color = WidgetinspectorDefaultClass._KHighlightedRenderObjectBorderColor;
Rect selectedPaintRect = state.Selected.Rect.Deflate(0.5);
;
canvas.Save();
canvas.Transform(state.Selected.Transform.Storage);
canvas.DrawRect(selectedPaintRect, fillPaint);
canvas.DrawRect(selectedPaintRect, borderPaint);
canvas.Restore();
foreach (_TransformedRect transformedRect in state.Candidates)
{
    ;
    canvas.Save();
    canvas.Transform(transformedRect.Transform.Storage);
    canvas.DrawRect(transformedRect.Rect.Deflate(0.5), borderPaint);
    canvas.Restore();
}

Rect targetRect = MatrixutilsDefaultClass.MatrixUtils.TransformRect(state.Selected.Transform, state.Selected.Rect);
Offset target = new Offset(targetRect.Left, targetRect.Center.Dy);
double offsetFromWidget = 9.0;
double verticalOffset = (targetRect.Height) / 2 + offsetFromWidget;
_PaintDescription(canvas, state.Tooltip, state.TextDirection, target, verticalOffset, size, targetRect);
return recorder.EndRecording();
}




private void _PaintDescription(Canvas canvas, string message, TextDirection textDirection, FlutterBinding.UI.Offset target, double verticalOffset, Size size, FlutterBinding.UI.Rect targetRect)
{
    canvas.Save();
    double maxWidth = size.Width - 2 * (WidgetinspectorDefaultClass._KScreenEdgeMargin + WidgetinspectorDefaultClass._KTooltipPadding);
    TextSpan textSpan = _TextPainter?.Text as TextSpan;
    if (_TextPainter == null || textSpan.Text != message || _TextPainterMaxWidth != maxWidth)
    {
        _TextPainterMaxWidth = maxWidth;
        _TextPainter = new TextPainter()..MaxLines = WidgetinspectorDefaultClass._KMaxTooltipLines..Ellipsis = "..."..Text = new TextSpan(style: WidgetinspectorDefaultClass._MessageStyle, text: message)..TextDirection = textDirection;
        new TextPainter().Layout(maxWidth: maxWidth);
    }

    Size tooltipSize = _TextPainter.Size + new Offset(WidgetinspectorDefaultClass._KTooltipPadding * 2, WidgetinspectorDefaultClass._KTooltipPadding * 2);
    Offset tipOffset = GeometryDefaultClass.PositionDependentBox(size: size, childSize: tooltipSize, target: target, verticalOffset: verticalOffset, preferBelow: false);
    Paint tooltipBackground = new Paint()..Style = PaintingStyle.Fill..Color = WidgetinspectorDefaultClass._KTooltipBackgroundColor;
    canvas.DrawRect(Rect.FromPoints(tipOffset, tipOffset.Translate(tooltipSize.Width, tooltipSize.Height)), tooltipBackground);
    double wedgeY = tipOffset.Dy;
    bool tooltipBelow = tipOffset.Dy > target.Dy;
    if (!tooltipBelow) wedgeY += tooltipSize.Height;
    double wedgeSize = WidgetinspectorDefaultClass._KTooltipPadding * 2;
    double wedgeX = Math.Dart:mathDefaultClass.Max(tipOffset.Dx, target.Dx) + wedgeSize * 2;
wedgeX = Math.Dart:mathDefaultClass.Min(wedgeX, tipOffset.Dx + tooltipSize.Width - wedgeSize * 2);
List<Offset> wedge = new List<Offset>() { new Offset(wedgeX - wedgeSize, wedgeY), new Offset(wedgeX + wedgeSize, wedgeY), new Offset(wedgeX, wedgeY + (tooltipBelow ? -wedgeSize : wedgeSize)) };
canvas.DrawPath(new Path();
new Path().AddPolygon(wedge, true), tooltipBackground);
_TextPainter.Paint(canvas, tipOffset + new Offset(WidgetinspectorDefaultClass._KTooltipPadding, WidgetinspectorDefaultClass._KTooltipPadding));
canvas.Restore();
}




public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
{
    return false;
}



#endregion
}


/// <Summary>
/// A tuple with file, line, and column number, for displaying human-readable
/// file locations.
/// </Summary>
public class _Location
{
    #region constructors
    public _Location(string file = default(string), int line = default(int), int column = default(int), string name = default(string), List<FlutterSDK.Widgets.Widgetinspector._Location> parameterLocations = default(List<FlutterSDK.Widgets.Widgetinspector._Location>))

}
#endregion

#region fields
public virtual string File { get; set; }
public virtual int Line { get; set; }
public virtual int Column { get; set; }
public virtual string Name { get; set; }
public virtual List<FlutterSDK.Widgets.Widgetinspector._Location> ParameterLocations { get; set; }
#endregion

#region methods

public virtual Dictionary<string, @Object> ToJsonMap()
{
    Dictionary<string, object> json = new Dictionary<string, object> { { "file", File }{ "line", Line }{ "column", Column } };
    if (Name != null)
    {
        json["name"] = Name;
    }

    if (ParameterLocations != null)
    {
        json["parameterLocations"] = ParameterLocations.Map((_Location location) => =>location.ToJsonMap()).ToList();
    }

    return json;
}




#endregion
}


/// <Summary>
/// A delegate that configures how a hierarchy of [DiagnosticsNode]s are
/// serialized by the Flutter Inspector.
/// </Summary>
public class InspectorSerializationDelegate : IDiagnosticsSerializationDelegate
{
    #region constructors
    public InspectorSerializationDelegate(string groupName = default(string), bool summaryTree = false, int maxDescendentsTruncatableNode = -1, bool expandPropertyValues = true, int subtreeDepth = 1, bool includeProperties = false, FlutterSDK.Widgets.Widgetinspector.WidgetInspectorService service = default(FlutterSDK.Widgets.Widgetinspector.WidgetInspectorService), Func<Map<string, object>, DiagnosticsNode, InspectorSerializationDelegate> addAdditionalPropertiesCallback = default(Func<Map<string, object>, DiagnosticsNode, InspectorSerializationDelegate>))

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Widgetinspector.WidgetInspectorService Service { get; set; }
public virtual string GroupName { get; set; }
public virtual bool SummaryTree { get; set; }
public virtual int MaxDescendentsTruncatableNode { get; set; }
public new bool IncludeProperties { get; set; }
public new int SubtreeDepth { get; set; }
public new bool ExpandPropertyValues { get; set; }
public virtual Func<Map<string, object>, DiagnosticsNode, InspectorSerializationDelegate> AddAdditionalPropertiesCallback { get; set; }
internal virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _NodesCreatedByLocalProject { get; set; }
internal virtual bool _Interactive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new Dictionary<string, @Object> AdditionalNodeProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
{
    Dictionary<string, object> result = new Dictionary<string, object> { };
    object value = node.Value;
    if (_Interactive)
    {
        result["objectId"] = Service.ToId(node, GroupName);
        result["valueId"] = Service.ToId(value, GroupName);
    }

    if (SummaryTree)
    {
        result["summaryTree"] = true;
    }

    _Location creationLocation = WidgetinspectorDefaultClass._GetCreationLocation(value);
    if (creationLocation != null)
    {
        result["locationId"] = WidgetinspectorDefaultClass._ToLocationId(creationLocation);
        result["creationLocation"] = creationLocation.ToJsonMap();
        if (Service._IsLocalCreationLocation(creationLocation))
        {
            _NodesCreatedByLocalProject.Add(node);
            result["createdByLocalProject"] = true;
        }

    }

    if (AddAdditionalPropertiesCallback != null)
    {
        result.AddAll(AddAdditionalPropertiesCallback(node, this) ?? new Dictionary<string, object> { });
    }

    return result;
}




public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
{
    return SummaryTree || SubtreeDepth > 1 || Service._ShouldShowInSummaryTree(node) ? CopyWith(subtreeDepth: SubtreeDepth - 1) : this;
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> children, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
{
    return Service._FilterChildren(children, this);
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
{
    bool createdByLocalProject = _NodesCreatedByLocalProject.Contains(owner);
    return properties.Where((DiagnosticsNode node) =>
    {
        return !node.IsFiltered(createdByLocalProject ? DiagnosticLevel.Fine : DiagnosticLevel.Info);
    }
    ).ToList();
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
{
    if (MaxDescendentsTruncatableNode >= 0 && owner?.AllowTruncate == true && nodes.Count > MaxDescendentsTruncatableNode)
    {
        nodes = Service._TruncateNodes(nodes, MaxDescendentsTruncatableNode);
    }

    return nodes;
}




public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(int subtreeDepth = default(int), bool includeProperties = default(bool))
{
    return new InspectorSerializationDelegate(groupName: GroupName, summaryTree: SummaryTree, maxDescendentsTruncatableNode: MaxDescendentsTruncatableNode, expandPropertyValues: ExpandPropertyValues, subtreeDepth: subtreeDepth ?? this.SubtreeDepth, includeProperties: includeProperties ?? this.IncludeProperties, service: Service, addAdditionalPropertiesCallback: AddAdditionalPropertiesCallback);
}



#endregion
}

}
