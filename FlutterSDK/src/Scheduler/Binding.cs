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
namespace FlutterSDK.Scheduler.Binding{
public delegate void FrameCallback(TimeSpan timeStamp);
public delegate T TaskCallback<T>();
public delegate bool SchedulingStrategy(int priority = default(int),FlutterSDK.Scheduler.Binding.SchedulerBinding scheduler = default(FlutterSDK.Scheduler.Binding.SchedulerBinding));
internal static class BindingDefaultClass{
public static double TimeDilation = default(double);
public static double _TimeDilation = default(double);
internal static bool DefaultSchedulingStrategy(int priority = default(int),FlutterSDK.Scheduler.Binding.SchedulerBinding scheduler = default(FlutterSDK.Scheduler.Binding.SchedulerBinding)){
throw new NotImplementedException();
}

}

public interface ISchedulerBinding{}

public class SchedulerBinding{
internal virtual List<object> _TimingsCallbacks{get;set;}
internal virtual FlutterSDK.Scheduler.Binding.SchedulerBinding _Instance{get;set;}
internal virtual AppLifecycleState _LifecycleState{get;set;}
public virtual FlutterSDK.Scheduler.Binding.SchedulingStrategy SchedulingStrategy{get;set;}
internal virtual object _TaskQueue{get;set;}
internal virtual bool _HasRequestedAnEventLoopCallback{get;set;}
internal virtual int _NextFrameCallbackId{get;set;}
internal virtual Dictionary<int,FlutterSDK.Scheduler.Binding._FrameCallbackEntry> _TransientCallbacks{get;set;}
internal virtual HashSet<int> _RemovedIds{get;set;}
internal virtual List<object> _PersistentCallbacks{get;set;}
internal virtual List<object> _PostFrameCallbacks{get;set;}
internal virtual Completer<object> _NextFrameCompleter{get;set;}
internal virtual bool _HasScheduledFrame{get;set;}
internal virtual FlutterSDK.Scheduler.Binding.SchedulerPhase _SchedulerPhase{get;set;}
internal virtual bool _FramesEnabled{get;set;}
internal virtual bool _WarmUpFrame{get;set;}
internal virtual TimeSpan _FirstRawTimeStampInEpoch{get;set;}
internal virtual TimeSpan _EpochStart{get;set;}
internal virtual TimeSpan _LastRawTimeStamp{get;set;}
internal virtual TimeSpan _CurrentFrameTimeStamp{get;set;}
internal virtual int _DebugFrameNumber{get;set;}
internal virtual string _DebugBanner{get;set;}
internal virtual bool _IgnoreNextEngineDrawFrame{get;set;}
public virtual FlutterSDK.Scheduler.Binding.SchedulerBinding Instance{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual AppLifecycleState LifecycleState{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int TransientCallbackCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual Future<object> EndOfFrame{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasScheduledFrame{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Scheduler.Binding.SchedulerPhase SchedulerPhase{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool FramesEnabled{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual TimeSpan CurrentFrameTimeStamp{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual TimeSpan CurrentSystemFrameTimeStamp{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public new void InitInstances(){ throw new NotImplementedException(); }


public virtual void AddTimingsCallback(TimingsCallback callback){ throw new NotImplementedException(); }


public virtual void RemoveTimingsCallback(TimingsCallback callback){ throw new NotImplementedException(); }


private void _ExecuteTimingsCallbacks(List<FrameTiming> timings){ throw new NotImplementedException(); }


public new void InitServiceExtensions(){ throw new NotImplementedException(); }


public virtual void ReadInitialLifecycleStateFromNativeWindow(){ throw new NotImplementedException(); }


public virtual void HandleAppLifecycleStateChanged(AppLifecycleState state){ throw new NotImplementedException(); }


private Future<string> _HandleLifecycleMessage(string message){ throw new NotImplementedException(); }


private AppLifecycleState _ParseAppLifecycleMessage(string message){ throw new NotImplementedException(); }


private int _TaskSorter(FlutterSDK.Scheduler.Binding._TaskEntry<object> e1,FlutterSDK.Scheduler.Binding._TaskEntry<object> e2){ throw new NotImplementedException(); }


public virtual Future<T> ScheduleTask<T>(FlutterSDK.Scheduler.Binding.TaskCallback<T> task,FlutterSDK.Scheduler.Priority.Priority priority,string debugLabel = default(string),Flow flow = default(Flow)){ throw new NotImplementedException(); }


public new void Unlocked(){ throw new NotImplementedException(); }


private void _EnsureEventLoopCallback(){ throw new NotImplementedException(); }


private void _RunTasks(){ throw new NotImplementedException(); }


public virtual bool HandleEventLoopCallback(){ throw new NotImplementedException(); }


public virtual int ScheduleFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback,bool rescheduling = false){ throw new NotImplementedException(); }


public virtual void CancelFrameCallbackWithId(int id){ throw new NotImplementedException(); }


public virtual bool DebugAssertNoTransientCallbacks(string reason){ throw new NotImplementedException(); }


public virtual void DebugPrintTransientCallbackRegistrationStack(){ throw new NotImplementedException(); }


public virtual void AddPersistentFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback){ throw new NotImplementedException(); }


public virtual void AddPostFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback){ throw new NotImplementedException(); }


private void _SetFramesEnabledState(bool enabled){ throw new NotImplementedException(); }


public virtual void EnsureFrameCallbacksRegistered(){ throw new NotImplementedException(); }


public virtual void EnsureVisualUpdate(){ throw new NotImplementedException(); }


public virtual void ScheduleFrame(){ throw new NotImplementedException(); }


public virtual void ScheduleForcedFrame(){ throw new NotImplementedException(); }


public virtual void ScheduleWarmUpFrame(){ throw new NotImplementedException(); }


public virtual void ResetEpoch(){ throw new NotImplementedException(); }


private TimeSpan _AdjustForEpoch(TimeSpan rawTimeStamp){ throw new NotImplementedException(); }


private void _HandleBeginFrame(TimeSpan rawTimeStamp){ throw new NotImplementedException(); }


private void _HandleDrawFrame(){ throw new NotImplementedException(); }


public virtual void HandleBeginFrame(TimeSpan rawTimeStamp){ throw new NotImplementedException(); }


public virtual void HandleDrawFrame(){ throw new NotImplementedException(); }


private void _ProfileFramePostEvent(int frameNumber,FrameTiming frameTiming){ throw new NotImplementedException(); }


private void _DebugDescribeTimeStamp(TimeSpan timeStamp,StringBuffer buffer){ throw new NotImplementedException(); }


private void _InvokeFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback,TimeSpan timeStamp,StackTrace callbackStack = default(StackTrace)){ throw new NotImplementedException(); }

}
public static class SchedulerBindingMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<ISchedulerBinding, SchedulerBinding> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ISchedulerBinding, SchedulerBinding>();
static SchedulerBinding GetOrCreate(ISchedulerBinding instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new SchedulerBinding();
_table.Add(instance, value);
}
return (SchedulerBinding)value;
}
public static FlutterSDK.Scheduler.Binding.SchedulingStrategy SchedulingStrategyProperty(this ISchedulerBinding instance) => GetOrCreate(instance).SchedulingStrategy;
public static FlutterSDK.Scheduler.Binding.SchedulerBinding InstanceProperty(this ISchedulerBinding instance) => GetOrCreate(instance).Instance;
public static AppLifecycleState LifecycleStateProperty(this ISchedulerBinding instance) => GetOrCreate(instance).LifecycleState;
public static int TransientCallbackCountProperty(this ISchedulerBinding instance) => GetOrCreate(instance).TransientCallbackCount;
public static Future<object> EndOfFrameProperty(this ISchedulerBinding instance) => GetOrCreate(instance).EndOfFrame;
public static bool HasScheduledFrameProperty(this ISchedulerBinding instance) => GetOrCreate(instance).HasScheduledFrame;
public static FlutterSDK.Scheduler.Binding.SchedulerPhase SchedulerPhaseProperty(this ISchedulerBinding instance) => GetOrCreate(instance).SchedulerPhase;
public static bool FramesEnabledProperty(this ISchedulerBinding instance) => GetOrCreate(instance).FramesEnabled;
public static TimeSpan CurrentFrameTimeStampProperty(this ISchedulerBinding instance) => GetOrCreate(instance).CurrentFrameTimeStamp;
public static TimeSpan CurrentSystemFrameTimeStampProperty(this ISchedulerBinding instance) => GetOrCreate(instance).CurrentSystemFrameTimeStamp;
public static void InitInstances(this ISchedulerBinding instance) => GetOrCreate(instance).InitInstances();
public static void AddTimingsCallback(this ISchedulerBinding instance,TimingsCallback callback) => GetOrCreate(instance).AddTimingsCallback(callback);
public static void RemoveTimingsCallback(this ISchedulerBinding instance,TimingsCallback callback) => GetOrCreate(instance).RemoveTimingsCallback(callback);
public static void InitServiceExtensions(this ISchedulerBinding instance) => GetOrCreate(instance).InitServiceExtensions();
public static void ReadInitialLifecycleStateFromNativeWindow(this ISchedulerBinding instance) => GetOrCreate(instance).ReadInitialLifecycleStateFromNativeWindow();
public static void HandleAppLifecycleStateChanged(this ISchedulerBinding instance,AppLifecycleState state) => GetOrCreate(instance).HandleAppLifecycleStateChanged(state);
public static Future<T> ScheduleTask<T>(this ISchedulerBinding instance,FlutterSDK.Scheduler.Binding.TaskCallback<T> task,FlutterSDK.Scheduler.Priority.Priority priority,string debugLabel = default(string),Flow flow = default(Flow)) => GetOrCreate(instance).ScheduleTask<T>(task, priority, debugLabel, flow);
public static void Unlocked(this ISchedulerBinding instance) => GetOrCreate(instance).Unlocked();
public static bool HandleEventLoopCallback(this ISchedulerBinding instance) => GetOrCreate(instance).HandleEventLoopCallback();
public static int ScheduleFrameCallback(this ISchedulerBinding instance,FlutterSDK.Scheduler.Binding.FrameCallback callback,bool rescheduling = false) => GetOrCreate(instance).ScheduleFrameCallback(callback, rescheduling);
public static void CancelFrameCallbackWithId(this ISchedulerBinding instance,int id) => GetOrCreate(instance).CancelFrameCallbackWithId(id);
public static bool DebugAssertNoTransientCallbacks(this ISchedulerBinding instance,string reason) => GetOrCreate(instance).DebugAssertNoTransientCallbacks(reason);
public static void DebugPrintTransientCallbackRegistrationStack(this ISchedulerBinding instance) => GetOrCreate(instance).DebugPrintTransientCallbackRegistrationStack();
public static void AddPersistentFrameCallback(this ISchedulerBinding instance,FlutterSDK.Scheduler.Binding.FrameCallback callback) => GetOrCreate(instance).AddPersistentFrameCallback(callback);
public static void AddPostFrameCallback(this ISchedulerBinding instance,FlutterSDK.Scheduler.Binding.FrameCallback callback) => GetOrCreate(instance).AddPostFrameCallback(callback);
public static void EnsureFrameCallbacksRegistered(this ISchedulerBinding instance) => GetOrCreate(instance).EnsureFrameCallbacksRegistered();
public static void EnsureVisualUpdate(this ISchedulerBinding instance) => GetOrCreate(instance).EnsureVisualUpdate();
public static void ScheduleFrame(this ISchedulerBinding instance) => GetOrCreate(instance).ScheduleFrame();
public static void ScheduleForcedFrame(this ISchedulerBinding instance) => GetOrCreate(instance).ScheduleForcedFrame();
public static void ScheduleWarmUpFrame(this ISchedulerBinding instance) => GetOrCreate(instance).ScheduleWarmUpFrame();
public static void ResetEpoch(this ISchedulerBinding instance) => GetOrCreate(instance).ResetEpoch();
public static void HandleBeginFrame(this ISchedulerBinding instance,TimeSpan rawTimeStamp) => GetOrCreate(instance).HandleBeginFrame(rawTimeStamp);
public static void HandleDrawFrame(this ISchedulerBinding instance) => GetOrCreate(instance).HandleDrawFrame();
}


public class _TaskEntry<T>
{
#region constructors
public _TaskEntry(FlutterSDK.Scheduler.Binding.TaskCallback<T> task,int priority,string debugLabel,Flow flow)
{
this.Task = task;
this.Priority = priority;
this.DebugLabel = debugLabel;
this.Flow = flow;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Scheduler.Binding.TaskCallback<T> Task{get;set;}
public virtual int Priority{get;set;}
public virtual string DebugLabel{get;set;}
public virtual Flow Flow{get;set;}
public virtual StackTrace DebugStack{get;set;}
public virtual Completer<T> Completer{get;set;}
#endregion

#region methods

public virtual void Run(){ throw new NotImplementedException(); }

#endregion
}


public class _FrameCallbackEntry
{
#region constructors
public _FrameCallbackEntry(FlutterSDK.Scheduler.Binding.FrameCallback callback,bool rescheduling = false)
{
this.Callback = callback;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Scheduler.Binding.FrameCallback Callback{get;set;}
public virtual StackTrace DebugCurrentCallbackStack{get;set;}
public virtual StackTrace DebugStack{get;set;}
#endregion

#region methods
#endregion
}


public enum SchedulerPhase{

Idle,
TransientCallbacks,
MidFrameMicrotasks,
PersistentCallbacks,
PostFrameCallbacks,
}

}
