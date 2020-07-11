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
        public virtual void RegisterServiceExtension(string name = default(string), FlutterSDK.Foundation.Binding.ServiceExtensionCallback callback = default(FlutterSDK.Foundation.Binding.ServiceExtensionCallback)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), which takes no arguments.
        /// </Summary>
        private void _RegisterSignalServiceExtension(string name = default(string), Func<FutureOr<object>> callback = default(Func<FutureOr<object>>)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), which takes a single optional argument
        /// "objectGroup" specifying what group is used to manage lifetimes of
        /// object references in the returned JSON (see [disposeGroup]).
        /// If "objectGroup" is omitted, the returned JSON will not include any object
        /// references to avoid leaking memory.
        /// </Summary>
        private void _RegisterObjectGroupServiceExtension(string name = default(string), Func<FutureOr<object>, string> callback = default(Func<FutureOr<object>, string>)) { throw new NotImplementedException(); }


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
        private void _RegisterBoolServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool>)) { throw new NotImplementedException(); }


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
        private void _PostExtensionStateChangedEvent(string name, object value) { throw new NotImplementedException(); }


        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name") which takes an optional parameter named
        /// "arg" and a required parameter named "objectGroup" used to control the
        /// lifetimes of object references in the returned JSON (see [disposeGroup]).
        /// </Summary>
        private void _RegisterServiceExtensionWithArg(string name = default(string), Func<FutureOr<object>, string, string> callback = default(Func<FutureOr<object>, string, string>)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.inspector.name"), that takes arguments
        /// "arg0", "arg1", "arg2", ..., "argn".
        /// </Summary>
        private void _RegisterServiceExtensionVarArgs(string name = default(string), Func<FutureOr<object>, List<string>> callback = default(Func<FutureOr<object>, List<string>>)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Cause the entire tree to be rebuilt. This is used by development tools
        /// when the application code has changed and is being hot-reloaded, to cause
        /// the widget tree to pick up any changed implementations.
        ///
        /// This is expensive and should not be called except during development.
        /// </Summary>
        public virtual Future<object> ForceRebuild() { throw new NotImplementedException(); }


        private void _ReportError(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details) { throw new NotImplementedException(); }


        /// <Summary>
        /// Resets the count of errors since the last hot reload.
        ///
        /// This data is sent to clients as part of the 'Flutter.Error' service
        /// protocol event. Clients may choose to display errors received after the
        /// first error differently.
        /// </Summary>
        private void _ResetErrorCount() { throw new NotImplementedException(); }


        /// <Summary>
        /// Called to register service extensions.
        ///
        /// See also:
        ///
        ///  * <https://github.com/dart-lang/sdk/blob/master/runtime/vm/service/service.md#rpcs-requests-and-responses>
        ///  * [BindingBase.initServiceExtensions], which explains when service
        ///    extensions can be used.
        /// </Summary>
        public virtual void InitServiceExtensions(FlutterSDK.Widgets.Widgetinspector._RegisterServiceExtensionCallback registerServiceExtensionCallback) { throw new NotImplementedException(); }


        private void _ClearStats() { throw new NotImplementedException(); }


        /// <Summary>
        /// Clear all InspectorService object references.
        ///
        /// Use this method only for testing to ensure that object references from one
        /// test case do not impact other test cases.
        /// </Summary>
        public virtual void DisposeAllGroups() { throw new NotImplementedException(); }


        /// <Summary>
        /// Free all references to objects in a group.
        ///
        /// Objects and their associated ids in the group may be kept alive by
        /// references from a different group.
        /// </Summary>
        public virtual void DisposeGroup(string name) { throw new NotImplementedException(); }


        private void _DecrementReferenceCount(FlutterSDK.Widgets.Widgetinspector._InspectorReferenceData reference) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a unique id for [object] that will remain live at least until
        /// [disposeGroup] is called on [groupName] or [dispose] is called on the id
        /// returned by this method.
        /// </Summary>
        public virtual string ToId(@Object @object, string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns whether the application has rendered its first frame and it is
        /// appropriate to display the Widget tree in the inspector.
        /// </Summary>
        public virtual bool IsWidgetTreeReady(string groupName = default(string)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the Dart object associated with a reference id.
        ///
        /// The `groupName` parameter is not required by is added to regularize the
        /// API surface of the methods in this class called from the Flutter IntelliJ
        /// Plugin.
        /// </Summary>
        public virtual @Object ToObject(string id, string groupName = default(string)) { throw new NotImplementedException(); }


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
        public virtual @Object ToObjectForSourceLocation(string id, string groupName = default(string)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Remove the object with the specified `id` from the specified object
        /// group.
        ///
        /// If the object exists in other groups it will remain alive and the object
        /// id will remain valid.
        /// </Summary>
        public virtual void DisposeId(string id, string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Set the list of directories that should be considered part of the local
        /// project.
        ///
        /// The local project directories are used to distinguish widgets created by
        /// the local project over widgets created from inside the framework.
        /// </Summary>
        public virtual void SetPubRootDirectories(List<string> pubRootDirectories) { throw new NotImplementedException(); }


        /// <Summary>
        /// Set the [WidgetInspector] selection to the object matching the specified
        /// id if the object is valid object to set as the inspector selection.
        ///
        /// Returns true if the selection was changed.
        ///
        /// The `groupName` parameter is not required by is added to regularize the
        /// API surface of methods called from the Flutter IntelliJ Plugin.
        /// </Summary>
        public virtual bool SetSelectionById(string id, string groupName = default(string)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Set the [WidgetInspector] selection to the specified `object` if it is
        /// a valid object to set as the inspector selection.
        ///
        /// Returns true if the selection was changed.
        ///
        /// The `groupName` parameter is not needed but is specified to regularize the
        /// API surface of methods called from the Flutter IntelliJ Plugin.
        /// </Summary>
        public virtual bool SetSelection(@Object @object, string groupName = default(string)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns JSON representing the chain of [DiagnosticsNode] instances from
        /// root of thee tree to the [Element] or [RenderObject] matching `id`.
        ///
        /// The JSON contains all information required to display a tree view with
        /// all nodes other than nodes along the path collapsed.
        /// </Summary>
        public virtual string GetParentChain(string id, string groupName) { throw new NotImplementedException(); }


        private List<@Object> _GetParentChain(string id, string groupName) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _PathNodeToJson(FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode pathNode, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate) { throw new NotImplementedException(); }


        private List<FlutterSDK.Widgets.Framework.Element> _GetRawElementParentChain(FlutterSDK.Widgets.Framework.Element element, int numLocalParents = default(int)) { throw new NotImplementedException(); }


        private List<FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode> _GetElementParentChain(FlutterSDK.Widgets.Framework.Element element, string groupName, int numLocalParents = default(int)) { throw new NotImplementedException(); }


        private List<FlutterSDK.Widgets.Widgetinspector._DiagnosticsPathNode> _GetRenderObjectParentChain(FlutterSDK.Rendering.@object.RenderObject renderObject, string groupName, int maxparents = default(int)) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _NodeToJson(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate) { throw new NotImplementedException(); }


        private bool _IsValueCreatedByLocalProject(@Object value) { throw new NotImplementedException(); }


        private bool _IsLocalCreationLocation(FlutterSDK.Widgets.Widgetinspector._Location location) { throw new NotImplementedException(); }


        /// <Summary>
        /// Wrapper around `json.encode` that uses a ring of cached values to prevent
        /// the Dart garbage collector from collecting objects between when
        /// the value is returned over the Observatory protocol and when the
        /// separate observatory protocol command has to be used to retrieve its full
        /// contents.
        /// </Summary>
        private string _SafeJsonEncode(@Object @object) { throw new NotImplementedException(); }


        private List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _TruncateNodes(Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, int maxDescendentsTruncatableNode) { throw new NotImplementedException(); }


        private List<Dictionary<string, @Object>> _NodesToJson(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode parent = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a JSON representation of the properties of the [DiagnosticsNode]
        /// object that `diagnosticsNodeId` references.
        /// </Summary>
        public virtual string GetProperties(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        private List<@Object> _GetProperties(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a JSON representation of the children of the [DiagnosticsNode]
        /// object that `diagnosticsNodeId` references.
        /// </Summary>
        public virtual string GetChildren(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        private List<@Object> _GetChildren(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


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
        public virtual string GetChildrenSummaryTree(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        private List<@Object> _GetChildrenSummaryTree(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a JSON representation of the children of the [DiagnosticsNode]
        /// object that `diagnosticsNodeId` references providing information needed
        /// for the details subtree view.
        ///
        /// The details subtree shows properties inline and includes all children
        /// rather than a filtered set of important children.
        /// </Summary>
        public virtual string GetChildrenDetailsSubtree(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        private List<@Object> _GetChildrenDetailsSubtree(string diagnosticsNodeId, string groupName) { throw new NotImplementedException(); }


        private bool _ShouldShowInSummaryTree(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        private List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _GetChildrenFiltered(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate) { throw new NotImplementedException(); }


        private List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Widgets.Widgetinspector.InspectorSerializationDelegate @delegate) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a JSON representation of the [DiagnosticsNode] for the root
        /// [Element].
        /// </Summary>
        public virtual string GetRootWidget(string groupName) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetRootWidget(string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a JSON representation of the [DiagnosticsNode] for the root
        /// [Element] showing only nodes that should be included in a summary tree.
        /// </Summary>
        public virtual string GetRootWidgetSummaryTree(string groupName) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetRootWidgetSummaryTree(string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a JSON representation of the [DiagnosticsNode] for the root
        /// [RenderObject].
        /// </Summary>
        public virtual string GetRootRenderObject(string groupName) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetRootRenderObject(string groupName) { throw new NotImplementedException(); }


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
        public virtual string GetDetailsSubtree(string id, string groupName, int subtreeDepth = 2) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetDetailsSubtree(string id, string groupName, int subtreeDepth) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a [DiagnosticsNode] representing the currently selected
        /// [RenderObject].
        ///
        /// If the currently selected [RenderObject] is identical to the
        /// [RenderObject] referenced by `previousSelectionId` then the previous
        /// [DiagnosticsNode] is reused.
        /// </Summary>
        public virtual string GetSelectedRenderObject(string previousSelectionId, string groupName) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetSelectedRenderObject(string previousSelectionId, string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a [DiagnosticsNode] representing the currently selected [Element].
        ///
        /// If the currently selected [Element] is identical to the [Element]
        /// referenced by `previousSelectionId` then the previous [DiagnosticsNode] is
        /// reused.
        /// </Summary>
        public virtual string GetSelectedWidget(string previousSelectionId, string groupName) { throw new NotImplementedException(); }


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
        public virtual Future<SKImage> Screenshot(@Object @object, double width = default(double), double height = default(double), double margin = 0.0, double maxPixelRatio = 1.0, bool debugPaint = false) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetSelectedWidget(string previousSelectionId, string groupName) { throw new NotImplementedException(); }


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
        public virtual string GetSelectedSummaryWidget(string previousSelectionId, string groupName) { throw new NotImplementedException(); }


        private Dictionary<string, @Object> _GetSelectedSummaryWidget(string previousSelectionId, string groupName) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns whether [Widget] creation locations are available.
        ///
        /// [Widget] creation locations are only available for debug mode builds when
        /// the `--track-widget-creation` flag is passed to `flutter_tool`. Dart 2.0
        /// is required as injecting creation locations requires a
        /// [Dart Kernel Transformer](https://github.com/dart-lang/sdk/wiki/Kernel-Documentation).
        /// </Summary>
        public virtual bool IsWidgetCreationTracked() { throw new NotImplementedException(); }


        private void _OnFrameStart(TimeSpan timeStamp) { throw new NotImplementedException(); }


        private void _OnFrameEnd(TimeSpan timeStamp) { throw new NotImplementedException(); }


        private void _PostStatsEvent(string eventName, FlutterSDK.Widgets.Widgetinspector._ElementLocationStatsTracker stats) { throw new NotImplementedException(); }


        /// <Summary>
        /// All events dispatched by a [WidgetInspectorService] use this method
        /// instead of calling [developer.postEvent] directly so that tests for
        /// [WidgetInspectorService] can track which events were dispatched by
        /// overriding this method.
        /// </Summary>
        public virtual void PostEvent(string eventKind, Dictionary<@Object, @Object> eventData) { throw new NotImplementedException(); }


        private void _OnRebuildWidget(FlutterSDK.Widgets.Framework.Element element, bool builtOnce) { throw new NotImplementedException(); }


        private void _OnPaint(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        /// <Summary>
        /// This method is called by [WidgetBinding.performReassemble] to flush caches
        /// of obsolete values after a hot reload.
        ///
        /// Do not call this method directly. Instead, use
        /// [BindingBase.reassembleApplication].
        /// </Summary>
        public virtual void PerformReassemble() { throw new NotImplementedException(); }

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
        public virtual void Add(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        /// <Summary>
        /// Clear all aggregated statistics.
        /// </Summary>
        public virtual void ResetCounts() { throw new NotImplementedException(); }


        /// <Summary>
        /// Exports the current counts and then resets the stats to prepare to track
        /// the next frame of data.
        /// </Summary>
        public virtual Dictionary<string, object> ExportToJson(TimeSpan startTime) { throw new NotImplementedException(); }

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
        public virtual void Clear() { throw new NotImplementedException(); }


        private void _ComputeCurrent() { throw new NotImplementedException(); }

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
        {
            this._Layer = _layer; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Layer.Layer _Layer { get; set; }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }

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
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Canvas _Main { get; set; }
        internal virtual Canvas _Screenshot { get; set; }
        #endregion

        #region methods

        public new void ClipPath(Path path, bool doAntiAlias = true) { throw new NotImplementedException(); }


        public new void ClipRRect(FlutterBinding.UI.RRect rrect, bool doAntiAlias = true) { throw new NotImplementedException(); }


        public new void ClipRect(FlutterBinding.UI.Rect rect, ClipOp clipOp = default(ClipOp), bool doAntiAlias = true) { throw new NotImplementedException(); }


        public new void DrawArc(FlutterBinding.UI.Rect rect, double startAngle, double sweepAngle, bool useCenter, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawAtlas(SKImage atlas, List<RSTransform> transforms, List<Rect> rects, List<Color> colors, FlutterBinding.UI.BlendMode blendMode, FlutterBinding.UI.Rect cullRect, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawCircle(FlutterBinding.UI.Offset c, double radius, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawColor(FlutterBinding.UI.Color color, FlutterBinding.UI.BlendMode blendMode) { throw new NotImplementedException(); }


        public new void DrawDRRect(FlutterBinding.UI.RRect outer, FlutterBinding.UI.RRect inner, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawImage(SKImage image, FlutterBinding.UI.Offset p, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawImageNine(SKImage image, FlutterBinding.UI.Rect center, FlutterBinding.UI.Rect dst, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawImageRect(SKImage image, FlutterBinding.UI.Rect src, FlutterBinding.UI.Rect dst, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawLine(FlutterBinding.UI.Offset p1, FlutterBinding.UI.Offset p2, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawOval(FlutterBinding.UI.Rect rect, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawPaint(SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawParagraph(FlutterBinding.UI.Paragraph paragraph, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DrawPath(Path path, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawPicture(SKPicture picture) { throw new NotImplementedException(); }


        public new void DrawPoints(FlutterBinding.UI.PointMode pointMode, List<FlutterBinding.UI.Offset> points, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawRRect(FlutterBinding.UI.RRect rrect, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawRawAtlas(SKImage atlas, List<double> rstTransforms, List<double> rects, List<uint> colors, FlutterBinding.UI.BlendMode blendMode, FlutterBinding.UI.Rect cullRect, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawRawPoints(FlutterBinding.UI.PointMode pointMode, List<double> points, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawRect(FlutterBinding.UI.Rect rect, SKPaint paint) { throw new NotImplementedException(); }


        public new void DrawShadow(Path path, FlutterBinding.UI.Color color, double elevation, bool transparentOccluder) { throw new NotImplementedException(); }


        public new void DrawVertices(SKVertices vertices, FlutterBinding.UI.BlendMode blendMode, SKPaint paint) { throw new NotImplementedException(); }


        public new int GetSaveCount() { throw new NotImplementedException(); }


        public new void Restore() { throw new NotImplementedException(); }


        public new void Rotate(double radians) { throw new NotImplementedException(); }


        public new void Save() { throw new NotImplementedException(); }


        public new void SaveLayer(FlutterBinding.UI.Rect bounds, SKPaint paint) { throw new NotImplementedException(); }


        public new void Scale(double sx, double sy = default(double)) { throw new NotImplementedException(); }


        public new void Skew(double sx, double sy) { throw new NotImplementedException(); }


        public new void Transform(List<float> matrix4) { throw new NotImplementedException(); }


        public new void Translate(double dx, double dy) { throw new NotImplementedException(); }

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

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }

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
        {
            this.Target = target; throw new NotImplementedException();
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
        {
            throw new NotImplementedException();
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

        private void _StartRecordingScreenshot() { throw new NotImplementedException(); }


        public new void StopRecordingIfNeeded() { throw new NotImplementedException(); }


        private void _StopRecordingScreenshotIfNeeded() { throw new NotImplementedException(); }


        public new void AppendLayer(FlutterSDK.Rendering.Layer.Layer layer) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.@object.PaintingContext CreateChildContext(FlutterSDK.Rendering.Layer.ContainerLayer childLayer, FlutterBinding.UI.Rect bounds) { throw new NotImplementedException(); }


        public new void PaintChild(FlutterSDK.Rendering.@object.RenderObject child, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


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
        public virtual Future<SKImage> ToImage(FlutterSDK.Rendering.@object.RenderObject renderObject, FlutterBinding.UI.Rect renderBounds, double pixelRatio = 1.0, bool debugPaint = false) { throw new NotImplementedException(); }

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
        {
            this.Node = node;
            this.Children = children;
            this.ChildIndex = childIndex; throw new NotImplementedException();
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
        {
            this.@object = @object; throw new NotImplementedException();
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
        {
            this.Location = location;
            this.Id = id;
            this.Local = local; throw new NotImplementedException();
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
        public virtual void Reset() { throw new NotImplementedException(); }


        /// <Summary>
        /// Increment the count.
        /// </Summary>
        public virtual void Increment() { throw new NotImplementedException(); }

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

        public new FlutterSDK.Widgets.Framework.Element CreateElement() { throw new NotImplementedException(); }

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
        {
            this.Child = child;
            this.SelectButtonBuilder = selectButtonBuilder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder SelectButtonBuilder { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Widgetinspector._WidgetInspectorState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _WidgetInspectorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Widgetinspector.WidgetInspector>, IWidgetsBindingObserver
    {
        #region constructors
        public _WidgetInspectorState()
        : base()
        {
            throw new NotImplementedException();
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

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private bool _HitTestHelper(List<FlutterSDK.Rendering.@object.RenderObject> hits, List<FlutterSDK.Rendering.@object.RenderObject> edgeHits, FlutterBinding.UI.Offset position, FlutterSDK.Rendering.@object.RenderObject @object, Matrix4 transform) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the list of render objects located at the given position ordered
        /// by priority.
        ///
        /// All render objects that are not offstage that match the location are
        /// included in the list of matches. Priority is given to matches that occur
        /// on the edge of a render object's bounding box and to matches found by
        /// [RenderBox.hitTest].
        /// </Summary>
        public virtual List<FlutterSDK.Rendering.@object.RenderObject> HitTest(FlutterBinding.UI.Offset position, FlutterSDK.Rendering.@object.RenderObject root) { throw new NotImplementedException(); }


        private void _InspectAt(FlutterBinding.UI.Offset position) { throw new NotImplementedException(); }


        private void _HandlePanDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails @event) { throw new NotImplementedException(); }


        private void _HandlePanUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails @event) { throw new NotImplementedException(); }


        private void _HandlePanEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        private void _HandleTap() { throw new NotImplementedException(); }


        private void _HandleEnableSelect() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _InspectorOverlay : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _InspectorOverlay(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Widgetinspector.InspectorSelection selection = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelection))
        : base(key: key)
        {
            this.Selection = selection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Widgetinspector._RenderInspectorOverlay CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Widgetinspector._RenderInspectorOverlay renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderInspectorOverlay : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public _RenderInspectorOverlay(FlutterSDK.Widgets.Widgetinspector.InspectorSelection selection = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelection))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection _Selection { get; set; }
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelection Selection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void PerformResize() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TransformedRect
    {
        #region constructors
        public _TransformedRect(FlutterSDK.Rendering.@object.RenderObject @object)
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual Matrix4 Transform { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

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
        {
            this.OverlayRect = overlayRect;
            this.Selected = selected;
            this.Candidates = candidates;
            this.Tooltip = tooltip;
            this.TextDirection = textDirection; throw new NotImplementedException();
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

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

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
        {
            this.OverlayRect = overlayRect;
            this.Selection = selection; throw new NotImplementedException();
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

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        private Picture _BuildPicture(FlutterSDK.Widgets.Widgetinspector._InspectorOverlayRenderState state) { throw new NotImplementedException(); }


        private void _PaintDescription(Canvas canvas, string message, TextDirection textDirection, FlutterBinding.UI.Offset target, double verticalOffset, Size size, FlutterBinding.UI.Rect targetRect) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }

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
        {
            this.File = file;
            this.Line = line;
            this.Column = column;
            this.Name = name;
            this.ParameterLocations = parameterLocations; throw new NotImplementedException();
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

        public virtual Dictionary<string, @Object> ToJsonMap() { throw new NotImplementedException(); }


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
        {
            this.GroupName = groupName;
            this.SummaryTree = summaryTree;
            this.MaxDescendentsTruncatableNode = maxDescendentsTruncatableNode;
            this.ExpandPropertyValues = expandPropertyValues;
            this.SubtreeDepth = subtreeDepth;
            this.IncludeProperties = includeProperties;
            this.Service = service;
            this.AddAdditionalPropertiesCallback = addAdditionalPropertiesCallback; throw new NotImplementedException();
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

        public new Dictionary<string, @Object> AdditionalNodeProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> children, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(int subtreeDepth = default(int), bool includeProperties = default(bool)) { throw new NotImplementedException(); }

        #endregion
    }

}
