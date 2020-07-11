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
namespace FlutterSDK.Widgets.Binding
{
    internal static class BindingDefaultClass
    {
        internal static void RunApp(FlutterSDK.Widgets.Framework.Widget app)
        {
            throw new NotImplementedException();
        }

        internal static void DebugDumpApp()
        {
            throw new NotImplementedException();
        }

    }

    public interface IWidgetsBinding { }

    public class WidgetsBinding
    {
        internal virtual FlutterSDK.Widgets.Binding.WidgetsBinding _Instance { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.BuildOwner _BuildOwner { get; set; }
        internal virtual List<FlutterSDK.Widgets.Binding.WidgetsBindingObserver> _Observers { get; set; }
        internal virtual bool _NeedToReportFirstFrame { get; set; }
        internal virtual Completer<object> _FirstFrameCompleter { get; set; }
        public virtual bool DebugBuildingDirtyElements { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _RenderViewElement { get; set; }
        internal virtual bool _ReadyToProduceFrames { get; set; }
        public virtual FlutterSDK.Widgets.Binding.WidgetsBinding Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildOwner BuildOwner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusManager FocusManager { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool FirstFrameRasterized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Future<object> WaitUntilFirstFrameRasterized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDidSendFirstFrameEvent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Element RenderViewElement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool FramesEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRootWidgetAttached { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitInstances() { throw new NotImplementedException(); }


        private void _DebugAddStackFilters() { throw new NotImplementedException(); }


        public new void InitServiceExtensions() { throw new NotImplementedException(); }


        private Future<object> _ForceRebuild() { throw new NotImplementedException(); }


        public virtual void AddObserver(FlutterSDK.Widgets.Binding.WidgetsBindingObserver observer) { throw new NotImplementedException(); }


        public virtual bool RemoveObserver(FlutterSDK.Widgets.Binding.WidgetsBindingObserver observer) { throw new NotImplementedException(); }


        public new void HandleMetricsChanged() { throw new NotImplementedException(); }


        public new void HandleTextScaleFactorChanged() { throw new NotImplementedException(); }


        public new void HandlePlatformBrightnessChanged() { throw new NotImplementedException(); }


        public new void HandleAccessibilityFeaturesChanged() { throw new NotImplementedException(); }


        public virtual void HandleLocaleChanged() { throw new NotImplementedException(); }


        public virtual void DispatchLocalesChanged(List<Locale> locales) { throw new NotImplementedException(); }


        public virtual void DispatchAccessibilityFeaturesChanged() { throw new NotImplementedException(); }


        public virtual Future<object> HandlePopRoute() { throw new NotImplementedException(); }


        public virtual Future<object> HandlePushRoute(string route) { throw new NotImplementedException(); }


        private Future<object> _HandleNavigationInvocation(FlutterSDK.Services.Messagecodec.MethodCall methodCall) { throw new NotImplementedException(); }


        public new void HandleAppLifecycleStateChanged(AppLifecycleState state) { throw new NotImplementedException(); }


        public virtual void HandleMemoryPressure() { throw new NotImplementedException(); }


        public new Future<object> HandleSystemMessage(@Object systemMessage) { throw new NotImplementedException(); }


        public virtual void DeferFirstFrameReport() { throw new NotImplementedException(); }


        public virtual void AllowFirstFrameReport() { throw new NotImplementedException(); }


        private void _HandleBuildScheduled() { throw new NotImplementedException(); }


        public new void DrawFrame() { throw new NotImplementedException(); }


        public virtual void ScheduleAttachRootWidget(FlutterSDK.Widgets.Framework.Widget rootWidget) { throw new NotImplementedException(); }


        public virtual void AttachRootWidget(FlutterSDK.Widgets.Framework.Widget rootWidget) { throw new NotImplementedException(); }


        public new Future<object> PerformReassemble() { throw new NotImplementedException(); }

    }
    public static class WidgetsBindingMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetsBinding, WidgetsBinding> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetsBinding, WidgetsBinding>();
        static WidgetsBinding GetOrCreate(IWidgetsBinding instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new WidgetsBinding();
                _table.Add(instance, value);
            }
            return (WidgetsBinding)value;
        }
        public static bool DebugBuildingDirtyElementsProperty(this IWidgetsBinding instance) => GetOrCreate(instance).DebugBuildingDirtyElements;
        public static FlutterSDK.Widgets.Binding.WidgetsBinding InstanceProperty(this IWidgetsBinding instance) => GetOrCreate(instance).Instance;
        public static FlutterSDK.Widgets.Framework.BuildOwner BuildOwnerProperty(this IWidgetsBinding instance) => GetOrCreate(instance).BuildOwner;
        public static FlutterSDK.Widgets.Focusmanager.FocusManager FocusManagerProperty(this IWidgetsBinding instance) => GetOrCreate(instance).FocusManager;
        public static bool FirstFrameRasterizedProperty(this IWidgetsBinding instance) => GetOrCreate(instance).FirstFrameRasterized;
        public static Future<object> WaitUntilFirstFrameRasterizedProperty(this IWidgetsBinding instance) => GetOrCreate(instance).WaitUntilFirstFrameRasterized;
        public static bool DebugDidSendFirstFrameEventProperty(this IWidgetsBinding instance) => GetOrCreate(instance).DebugDidSendFirstFrameEvent;
        public static FlutterSDK.Widgets.Framework.Element RenderViewElementProperty(this IWidgetsBinding instance) => GetOrCreate(instance).RenderViewElement;
        public static bool FramesEnabledProperty(this IWidgetsBinding instance) => GetOrCreate(instance).FramesEnabled;
        public static bool IsRootWidgetAttachedProperty(this IWidgetsBinding instance) => GetOrCreate(instance).IsRootWidgetAttached;
        public static void InitInstances(this IWidgetsBinding instance) => GetOrCreate(instance).InitInstances();
        public static void InitServiceExtensions(this IWidgetsBinding instance) => GetOrCreate(instance).InitServiceExtensions();
        public static void AddObserver(this IWidgetsBinding instance, FlutterSDK.Widgets.Binding.WidgetsBindingObserver observer) => GetOrCreate(instance).AddObserver(observer);
        public static bool RemoveObserver(this IWidgetsBinding instance, FlutterSDK.Widgets.Binding.WidgetsBindingObserver observer) => GetOrCreate(instance).RemoveObserver(observer);
        public static void HandleMetricsChanged(this IWidgetsBinding instance) => GetOrCreate(instance).HandleMetricsChanged();
        public static void HandleTextScaleFactorChanged(this IWidgetsBinding instance) => GetOrCreate(instance).HandleTextScaleFactorChanged();
        public static void HandlePlatformBrightnessChanged(this IWidgetsBinding instance) => GetOrCreate(instance).HandlePlatformBrightnessChanged();
        public static void HandleAccessibilityFeaturesChanged(this IWidgetsBinding instance) => GetOrCreate(instance).HandleAccessibilityFeaturesChanged();
        public static void HandleLocaleChanged(this IWidgetsBinding instance) => GetOrCreate(instance).HandleLocaleChanged();
        public static void DispatchLocalesChanged(this IWidgetsBinding instance, List<Locale> locales) => GetOrCreate(instance).DispatchLocalesChanged(locales);
        public static void DispatchAccessibilityFeaturesChanged(this IWidgetsBinding instance) => GetOrCreate(instance).DispatchAccessibilityFeaturesChanged();
        public static Future<object> HandlePopRoute(this IWidgetsBinding instance) => GetOrCreate(instance).HandlePopRoute();
        public static Future<object> HandlePushRoute(this IWidgetsBinding instance, string route) => GetOrCreate(instance).HandlePushRoute(route);
        public static void HandleAppLifecycleStateChanged(this IWidgetsBinding instance, AppLifecycleState state) => GetOrCreate(instance).HandleAppLifecycleStateChanged(state);
        public static void HandleMemoryPressure(this IWidgetsBinding instance) => GetOrCreate(instance).HandleMemoryPressure();
        public static Future<object> HandleSystemMessage(this IWidgetsBinding instance, @Object systemMessage) => GetOrCreate(instance).HandleSystemMessage(systemMessage);
        public static void DeferFirstFrameReport(this IWidgetsBinding instance) => GetOrCreate(instance).DeferFirstFrameReport();
        public static void AllowFirstFrameReport(this IWidgetsBinding instance) => GetOrCreate(instance).AllowFirstFrameReport();
        public static void DrawFrame(this IWidgetsBinding instance) => GetOrCreate(instance).DrawFrame();
        public static void ScheduleAttachRootWidget(this IWidgetsBinding instance, FlutterSDK.Widgets.Framework.Widget rootWidget) => GetOrCreate(instance).ScheduleAttachRootWidget(rootWidget);
        public static void AttachRootWidget(this IWidgetsBinding instance, FlutterSDK.Widgets.Framework.Widget rootWidget) => GetOrCreate(instance).AttachRootWidget(rootWidget);
        public static Future<object> PerformReassemble(this IWidgetsBinding instance) => GetOrCreate(instance).PerformReassemble();
    }


    public interface IWidgetsBindingObserver { }

    public class WidgetsBindingObserver
    {

        public virtual Future<bool> DidPopRoute() { throw new NotImplementedException(); }


        public virtual Future<bool> DidPushRoute(string route) { throw new NotImplementedException(); }


        public virtual void DidChangeMetrics() { throw new NotImplementedException(); }


        public virtual void DidChangeTextScaleFactor() { throw new NotImplementedException(); }


        public virtual void DidChangePlatformBrightness() { throw new NotImplementedException(); }


        public virtual void DidChangeLocales(List<Locale> locale) { throw new NotImplementedException(); }


        public virtual void DidChangeAppLifecycleState(AppLifecycleState state) { throw new NotImplementedException(); }


        public virtual void DidHaveMemoryPressure() { throw new NotImplementedException(); }


        public virtual void DidChangeAccessibilityFeatures() { throw new NotImplementedException(); }

    }
    public static class WidgetsBindingObserverMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetsBindingObserver, WidgetsBindingObserver> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IWidgetsBindingObserver, WidgetsBindingObserver>();
        static WidgetsBindingObserver GetOrCreate(IWidgetsBindingObserver instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new WidgetsBindingObserver();
                _table.Add(instance, value);
            }
            return (WidgetsBindingObserver)value;
        }
        public static Future<bool> DidPopRoute(this IWidgetsBindingObserver instance) => GetOrCreate(instance).DidPopRoute();
        public static Future<bool> DidPushRoute(this IWidgetsBindingObserver instance, string route) => GetOrCreate(instance).DidPushRoute(route);
        public static void DidChangeMetrics(this IWidgetsBindingObserver instance) => GetOrCreate(instance).DidChangeMetrics();
        public static void DidChangeTextScaleFactor(this IWidgetsBindingObserver instance) => GetOrCreate(instance).DidChangeTextScaleFactor();
        public static void DidChangePlatformBrightness(this IWidgetsBindingObserver instance) => GetOrCreate(instance).DidChangePlatformBrightness();
        public static void DidChangeLocales(this IWidgetsBindingObserver instance, List<Locale> locale) => GetOrCreate(instance).DidChangeLocales(locale);
        public static void DidChangeAppLifecycleState(this IWidgetsBindingObserver instance, AppLifecycleState state) => GetOrCreate(instance).DidChangeAppLifecycleState(state);
        public static void DidHaveMemoryPressure(this IWidgetsBindingObserver instance) => GetOrCreate(instance).DidHaveMemoryPressure();
        public static void DidChangeAccessibilityFeatures(this IWidgetsBindingObserver instance) => GetOrCreate(instance).DidChangeAccessibilityFeatures();
    }


    public class RenderObjectToWidgetAdapter<T> : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public RenderObjectToWidgetAdapter(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T> container = default(FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T>), string debugShortDescription = default(string))
        : base(key: new GlobalObjectKey(container))
        {
            this.Child = child;
            this.Container = container;
            this.DebugShortDescription = debugShortDescription; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T> Container { get; set; }
        public virtual string DebugShortDescription { get; set; }
        #endregion

        #region methods

        public new RenderObjectToWidgetElement<T> CreateElement() { throw new NotImplementedException(); }


        public new RenderObjectWithChildMixin<T> CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public virtual RenderObjectToWidgetElement<T> AttachToRenderTree(FlutterSDK.Widgets.Framework.BuildOwner owner, FlutterSDK.Widgets.Binding.RenderObjectToWidgetElement<T> element = default(FlutterSDK.Widgets.Binding.RenderObjectToWidgetElement<T>)) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }

        #endregion
    }


    public class RenderObjectToWidgetElement<T> : FlutterSDK.Widgets.Framework.RootRenderObjectElement
    {
        #region constructors
        public RenderObjectToWidgetElement(FlutterSDK.Widgets.Binding.RenderObjectToWidgetAdapter<T> widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Element _Child { get; set; }
        internal virtual @Object _RootChildSlot { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _NewWidget { get; set; }
        public virtual FlutterSDK.Widgets.Binding.RenderObjectToWidgetAdapter<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T> RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Binding.RenderObjectToWidgetAdapter<T> newWidget) { throw new NotImplementedException(); }


        public new void PerformRebuild() { throw new NotImplementedException(); }


        private void _Rebuild() { throw new NotImplementedException(); }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }

        #endregion
    }


    public class WidgetsFlutterBinding : FlutterSDK.Foundation.Binding.BindingBase, IGestureBinding, IServicesBinding, ISchedulerBinding, IPaintingBinding, ISemanticsBinding, IRendererBinding, IWidgetsBinding
    {
        #region constructors
        public WidgetsFlutterBinding()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual FlutterSDK.Widgets.Binding.WidgetsBinding EnsureInitialized() { throw new NotImplementedException(); }

        #endregion
    }

}
