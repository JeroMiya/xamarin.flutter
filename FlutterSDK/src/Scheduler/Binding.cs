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
namespace FlutterSDK.Scheduler.Binding
{
    public delegate void FrameCallback(TimeSpan timeStamp);
    public delegate T TaskCallback<T>();
    public delegate bool SchedulingStrategy(int priority = default(int), FlutterSDK.Scheduler.Binding.SchedulerBinding scheduler = default(FlutterSDK.Scheduler.Binding.SchedulerBinding));
    internal static class BindingDefaultClass
    {
        public static double TimeDilation = default(double);
        public static double _TimeDilation = default(double);
        internal static bool DefaultSchedulingStrategy(int priority = default(int), FlutterSDK.Scheduler.Binding.SchedulerBinding scheduler = default(FlutterSDK.Scheduler.Binding.SchedulerBinding))
        {
            throw new NotImplementedException();
        }

    }

    public interface ISchedulerBinding { }

    public class SchedulerBinding
    {
        internal virtual List<object> _TimingsCallbacks { get; set; }
        internal virtual FlutterSDK.Scheduler.Binding.SchedulerBinding _Instance { get; set; }
        internal virtual AppLifecycleState _LifecycleState { get; set; }
        public virtual FlutterSDK.Scheduler.Binding.SchedulingStrategy SchedulingStrategy { get; set; }
        internal virtual object _TaskQueue { get; set; }
        internal virtual bool _HasRequestedAnEventLoopCallback { get; set; }
        internal virtual int _NextFrameCallbackId { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Scheduler.Binding._FrameCallbackEntry> _TransientCallbacks { get; set; }
        internal virtual HashSet<int> _RemovedIds { get; set; }
        internal virtual List<object> _PersistentCallbacks { get; set; }
        internal virtual List<object> _PostFrameCallbacks { get; set; }
        internal virtual Completer<object> _NextFrameCompleter { get; set; }
        internal virtual bool _HasScheduledFrame { get; set; }
        internal virtual FlutterSDK.Scheduler.Binding.SchedulerPhase _SchedulerPhase { get; set; }
        internal virtual bool _FramesEnabled { get; set; }
        internal virtual bool _WarmUpFrame { get; set; }
        internal virtual TimeSpan _FirstRawTimeStampInEpoch { get; set; }
        internal virtual TimeSpan _EpochStart { get; set; }
        internal virtual TimeSpan _LastRawTimeStamp { get; set; }
        internal virtual TimeSpan _CurrentFrameTimeStamp { get; set; }
        internal virtual int _DebugFrameNumber { get; set; }
        internal virtual string _DebugBanner { get; set; }
        internal virtual bool _IgnoreNextEngineDrawFrame { get; set; }
        public virtual FlutterSDK.Scheduler.Binding.SchedulerBinding Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual AppLifecycleState LifecycleState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int TransientCallbackCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Future<object> EndOfFrame { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasScheduledFrame { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Scheduler.Binding.SchedulerPhase SchedulerPhase { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool FramesEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan CurrentFrameTimeStamp { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan CurrentSystemFrameTimeStamp { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitInstances()
        {
            base.InitInstances();
            _Instance = this;
            SystemchannelsDefaultClass.SystemChannels.Lifecycle.SetMessageHandler(_HandleLifecycleMessage);
            ReadInitialLifecycleStateFromNativeWindow();
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                int frameNumber = 0;
                AddTimingsCallback((List<FrameTiming> timings) =>
                {
                    foreach (FrameTiming frameTiming in timings)
                    {
                        frameNumber += 1;
                        _ProfileFramePostEvent(frameNumber, frameTiming);
                    }

                }
                );
            }

        }




        /// <Summary>
        /// Add a [TimingsCallback] that receives [FrameTiming] sent from the engine.
        ///
        /// This can be used, for example, to monitor the performance in release mode,
        /// or to get a signal when the first frame is rasterized.
        ///
        /// This is preferred over using [Window.onReportTimings] directly because
        /// [addTimingsCallback] allows multiple callbacks.
        ///
        /// If the same callback is added twice, it will be executed twice.
        /// </Summary>
        public virtual void AddTimingsCallback(TimingsCallback callback)
        {
            _TimingsCallbacks.Add(callback);
            if (_TimingsCallbacks.Count == 1)
            {

                Window.OnReportTimings = _ExecuteTimingsCallbacks;
            }


        }




        /// <Summary>
        /// Removes a callback that was earlier added by [addTimingsCallback].
        /// </Summary>
        public virtual void RemoveTimingsCallback(TimingsCallback callback)
        {

            _TimingsCallbacks.Remove(callback);
            if (_TimingsCallbacks.IsEmpty())
            {
                Window.OnReportTimings = null;
            }

        }




        private void _ExecuteTimingsCallbacks(List<FrameTiming> timings)
        {
            List<TimingsCallback> clonedCallbacks = List<TimingsCallback>.From(_TimingsCallbacks);
            foreach (TimingsCallback callback in clonedCallbacks)
            {
                try
                {
                    if (_TimingsCallbacks.Contains(callback))
                    {
                        callback(timings);
                    }

                }
                catch (exception,stack){
                    InformationCollector collector = default(InformationCollector);

                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, context: new ErrorDescription("while executing callbacks for FrameTiming"), informationCollector: collector));
                }

                }

            }




public new void InitServiceExtensions()
        {
            base.InitServiceExtensions();
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                RegisterNumericServiceExtension(name: "timeDilation", getter: () => async => BindingDefaultClass.TimeDilation, setter: (double value) => async {
                    BindingDefaultClass.TimeDilation = value;
                }
);
            }

        }




        /// <Summary>
        /// Initializes the [lifecycleState] with the [initialLifecycleState] from the
        /// window.
        ///
        /// Once the [lifecycleState] is populated through any means (including this
        /// method), this method will do nothing. This is because the
        /// [initialLifecycleState] may already be stale and it no longer makes sense
        /// to use the initial state at dart vm startup as the current state anymore.
        ///
        /// The latest state should be obtained by subscribing to
        /// [WidgetsBindingObserver.didChangeAppLifecycleState].
        /// </Summary>
        public virtual void ReadInitialLifecycleStateFromNativeWindow()
        {
            if (_LifecycleState == null && _ParseAppLifecycleMessage(Window.InitialLifecycleState) != null)
            {
                _HandleLifecycleMessage(Window.InitialLifecycleState);
            }

        }




        /// <Summary>
        /// Called when the application lifecycle state changes.
        ///
        /// Notifies all the observers using
        /// [WidgetsBindingObserver.didChangeAppLifecycleState].
        ///
        /// This method exposes notifications from [SystemChannels.lifecycle].
        /// </Summary>
        public virtual void HandleAppLifecycleStateChanged(AppLifecycleState state)
        {

            _LifecycleState = state;
            switch (state) { case AppLifecycleState.Resumed: case AppLifecycleState.Inactive: _SetFramesEnabledState(true); break; case AppLifecycleState.Paused: case AppLifecycleState.Detached: _SetFramesEnabledState(false); break; }
        }




        private Future<string> _HandleLifecycleMessage(string message)
    async
{
HandleAppLifecycleStateChanged(_ParseAppLifecycleMessage(message));
return null ;
}




    private AppLifecycleState _ParseAppLifecycleMessage(string message)
    {
        switch (message) { case "AppLifecycleState.paused": return AppLifecycleState.Paused; case "AppLifecycleState.resumed": return AppLifecycleState.Resumed; case "AppLifecycleState.inactive": return AppLifecycleState.Inactive; case "AppLifecycleState.detached": return AppLifecycleState.Detached; }
        return null;
    }




    private int _TaskSorter(FlutterSDK.Scheduler.Binding._TaskEntry<object> e1, FlutterSDK.Scheduler.Binding._TaskEntry<object> e2)
    {
        return -e1.Priority.CompareTo(e2.Priority);
    }




    /// <Summary>
    /// Schedules the given `task` with the given `priority` and returns a
    /// [Future] that completes to the `task`'s eventual return value.
    ///
    /// The `debugLabel` and `flow` are used to report the task to the [Timeline],
    /// for use when profiling.
    ///
    /// ## Processing model
    ///
    /// Tasks will be executed between frames, in priority order,
    /// excluding tasks that are skipped by the current
    /// [schedulingStrategy]. Tasks should be short (as in, up to a
    /// millisecond), so as to not cause the regular frame callbacks to
    /// get delayed.
    ///
    /// If an animation is running, including, for instance, a [ProgressIndicator]
    /// indicating that there are pending tasks, then tasks with a priority below
    /// [Priority.animation] won't run (at least, not with the
    /// [defaultSchedulingStrategy]; this can be configured using
    /// [schedulingStrategy]).
    /// </Summary>
    public virtual Future<T> ScheduleTask<T>(FlutterSDK.Scheduler.Binding.TaskCallback<T> task, FlutterSDK.Scheduler.Priority.Priority priority, string debugLabel = default(string), Flow flow = default(Flow))
    {
        bool isFirstTask = _TaskQueue.IsEmpty;
        _TaskEntry<T> entry = new _TaskEntry<T>(task, priority.Value, debugLabel, flow);
        _TaskQueue.Add(entry);
        if (isFirstTask && !Locked) _EnsureEventLoopCallback();
        return entry.Completer.Future;
    }




    public new void Unlocked()
    {
        base.Unlocked();
        if (_TaskQueue.IsNotEmpty) _EnsureEventLoopCallback();
    }




    private void _EnsureEventLoopCallback()
    {


        if (_HasRequestedAnEventLoopCallback) return;
        _HasRequestedAnEventLoopCallback = true;
    Dart: asyncDefaultClass.Timer.Run(_RunTasks);
    }




    private void _RunTasks()
    {
        _HasRequestedAnEventLoopCallback = false;
        if (HandleEventLoopCallback()) _EnsureEventLoopCallback();
    }




    /// <Summary>
    /// Execute the highest-priority task, if it is of a high enough priority.
    ///
    /// Returns true if a task was executed and there are other tasks remaining
    /// (even if they are not high-enough priority).
    ///
    /// Returns false if no task was executed, which can occur if there are no
    /// tasks scheduled, if the scheduler is [locked], or if the highest-priority
    /// task is of too low a priority given the current [schedulingStrategy].
    ///
    /// Also returns false if there are no tasks remaining.
    /// </Summary>
    public virtual bool HandleEventLoopCallback()
    {
        if (_TaskQueue.IsEmpty || Locked) return false;
        _TaskEntry<object> entry = _TaskQueue.First;
        if (SchedulingStrategy(priority: entry.Priority, scheduler: this))
        {
            try
            {
                _TaskQueue.RemoveFirst();
                entry.Run();
            }
            catch (exception,exceptionStack){
                StackTrace callbackStack = default(StackTrace);

                AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: exceptionStack, library: "scheduler library", context: new ErrorDescription("during a task callback"), informationCollector: (callbackStack == null) ? null : () => sync *{
yield new DiagnosticsStackTrace("\nThis exception was thrown in the context of a scheduler callback. " + "When the scheduler callback was _registered_ (as opposed to when the " + "exception was thrown), this was the stack", callbackStack);
            }
));
            }

            return _TaskQueue.IsNotEmpty;
        }

        return false;
    }




    /// <Summary>
    /// Schedules the given transient frame callback.
    ///
    /// Adds the given callback to the list of frame callbacks and ensures that a
    /// frame is scheduled.
    ///
    /// If this is a one-off registration, ignore the `rescheduling` argument.
    ///
    /// If this is a callback that will be re-registered each time it fires, then
    /// when you re-register the callback, set the `rescheduling` argument to
    /// true. This has no effect in release builds, but in debug builds, it
    /// ensures that the stack trace that is stored for this callback is the
    /// original stack trace for when the callback was _first_ registered, rather
    /// than the stack trace for when the callback is re-registered. This makes it
    /// easier to track down the original reason that a particular callback was
    /// called. If `rescheduling` is true, the call must be in the context of a
    /// frame callback.
    ///
    /// Callbacks registered with this method can be canceled using
    /// [cancelFrameCallbackWithId].
    /// </Summary>
    public virtual int ScheduleFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback, bool rescheduling = false)
    {
        ScheduleFrame();
        _NextFrameCallbackId += 1;
        _TransientCallbacks[_NextFrameCallbackId] = new _FrameCallbackEntry(callback, rescheduling: rescheduling);
        return _NextFrameCallbackId;
    }




    /// <Summary>
    /// Cancels the transient frame callback with the given [id].
    ///
    /// Removes the given callback from the list of frame callbacks. If a frame
    /// has been requested, this does not also cancel that request.
    ///
    /// Transient frame callbacks are those registered using
    /// [scheduleFrameCallback].
    /// </Summary>
    public virtual void CancelFrameCallbackWithId(int id)
    {

        _TransientCallbacks.Remove(id);
        _RemovedIds.Add(id);
    }




    /// <Summary>
    /// Asserts that there are no registered transient callbacks; if
    /// there are, prints their locations and throws an exception.
    ///
    /// A transient frame callback is one that was registered with
    /// [scheduleFrameCallback].
    ///
    /// This is expected to be called at the end of tests (the
    /// flutter_test framework does it automatically in normal cases).
    ///
    /// Call this method when you expect there to be no transient
    /// callbacks registered, in an assert statement with a message that
    /// you want printed when a transient callback is registered:
    ///
    /// ```dart
    /// assert(SchedulerBinding.instance.debugAssertNoTransientCallbacks(
    ///   'A leak of transient callbacks was detected while doing foo.'
    /// ));
    /// ```
    ///
    /// Does nothing if asserts are disabled. Always returns true.
    /// </Summary>
    public virtual bool DebugAssertNoTransientCallbacks(string reason)
    {

        return true;
    }




    /// <Summary>
    /// Prints the stack for where the current transient callback was registered.
    ///
    /// A transient frame callback is one that was registered with
    /// [scheduleFrameCallback].
    ///
    /// When called in debug more and in the context of a transient callback, this
    /// function prints the stack trace from where the current transient callback
    /// was registered (i.e. where it first called [scheduleFrameCallback]).
    ///
    /// When called in debug mode in other contexts, it prints a message saying
    /// that this function was not called in the context a transient callback.
    ///
    /// In release mode, this function does nothing.
    ///
    /// To call this function, use the following code:
    ///
    /// ```dart
    /// SchedulerBinding.debugPrintTransientCallbackRegistrationStack();
    /// ```
    /// </Summary>
    public virtual void DebugPrintTransientCallbackRegistrationStack()
    {

    }




    /// <Summary>
    /// Adds a persistent frame callback.
    ///
    /// Persistent callbacks are called after transient
    /// (non-persistent) frame callbacks.
    ///
    /// Does *not* request a new frame. Conceptually, persistent frame
    /// callbacks are observers of "begin frame" events. Since they are
    /// executed after the transient frame callbacks they can drive the
    /// rendering pipeline.
    ///
    /// Persistent frame callbacks cannot be unregistered. Once registered, they
    /// are called for every frame for the lifetime of the application.
    /// </Summary>
    public virtual void AddPersistentFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback)
    {
        _PersistentCallbacks.Add(callback);
    }




    /// <Summary>
    /// Schedule a callback for the end of this frame.
    ///
    /// Does *not* request a new frame.
    ///
    /// This callback is run during a frame, just after the persistent
    /// frame callbacks (which is when the main rendering pipeline has
    /// been flushed). If a frame is in progress and post-frame
    /// callbacks haven't been executed yet, then the registered
    /// callback is still executed during the frame. Otherwise, the
    /// registered callback is executed during the next frame.
    ///
    /// The callbacks are executed in the order in which they have been
    /// added.
    ///
    /// Post-frame callbacks cannot be unregistered. They are called exactly once.
    ///
    /// See also:
    ///
    ///  * [scheduleFrameCallback], which registers a callback for the start of
    ///    the next frame.
    /// </Summary>
    public virtual void AddPostFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback)
    {
        _PostFrameCallbacks.Add(callback);
    }




    private void _SetFramesEnabledState(bool enabled)
    {
        if (_FramesEnabled == enabled) return;
        _FramesEnabled = enabled;
        if (enabled) ScheduleFrame();
    }




    public virtual void EnsureFrameCallbacksRegistered()
    {
        Window.OnBeginFrame = (Window.OnBeginFrame == null ? _HandleBeginFrame : Window.OnBeginFrame);
        Window.OnDrawFrame = (Window.OnDrawFrame == null ? _HandleDrawFrame : Window.OnDrawFrame);
    }




    /// <Summary>
    /// Schedules a new frame using [scheduleFrame] if this object is not
    /// currently producing a frame.
    ///
    /// Calling this method ensures that [handleDrawFrame] will eventually be
    /// called, unless it's already in progress.
    ///
    /// This has no effect if [schedulerPhase] is
    /// [SchedulerPhase.transientCallbacks] or [SchedulerPhase.midFrameMicrotasks]
    /// (because a frame is already being prepared in that case), or
    /// [SchedulerPhase.persistentCallbacks] (because a frame is actively being
    /// rendered in that case). It will schedule a frame if the [schedulerPhase]
    /// is [SchedulerPhase.idle] (in between frames) or
    /// [SchedulerPhase.postFrameCallbacks] (after a frame).
    /// </Summary>
    public virtual void EnsureVisualUpdate()
    {
        switch (SchedulerPhase) { case SchedulerPhase.Idle: case SchedulerPhase.PostFrameCallbacks: ScheduleFrame(); return; case SchedulerPhase.TransientCallbacks: case SchedulerPhase.MidFrameMicrotasks: case SchedulerPhase.PersistentCallbacks: return; }
    }




    /// <Summary>
    /// If necessary, schedules a new frame by calling
    /// [Window.scheduleFrame].
    ///
    /// After this is called, the engine will (eventually) call
    /// [handleBeginFrame]. (This call might be delayed, e.g. if the device's
    /// screen is turned off it will typically be delayed until the screen is on
    /// and the application is visible.) Calling this during a frame forces
    /// another frame to be scheduled, even if the current frame has not yet
    /// completed.
    ///
    /// Scheduled frames are serviced when triggered by a "Vsync" signal provided
    /// by the operating system. The "Vsync" signal, or vertical synchronization
    /// signal, was historically related to the display refresh, at a time when
    /// hardware physically moved a beam of electrons vertically between updates
    /// of the display. The operation of contemporary hardware is somewhat more
    /// subtle and complicated, but the conceptual "Vsync" refresh signal continue
    /// to be used to indicate when applications should update their rendering.
    ///
    /// To have a stack trace printed to the console any time this function
    /// schedules a frame, set [debugPrintScheduleFrameStacks] to true.
    ///
    /// See also:
    ///
    ///  * [scheduleForcedFrame], which ignores the [lifecycleState] when
    ///    scheduling a frame.
    ///  * [scheduleWarmUpFrame], which ignores the "Vsync" signal entirely and
    ///    triggers a frame immediately.
    /// </Summary>
    public virtual void ScheduleFrame()
    {
        if (_HasScheduledFrame || !FramesEnabled) return;

        EnsureFrameCallbacksRegistered();
        Window.ScheduleFrame();
        _HasScheduledFrame = true;
    }




    /// <Summary>
    /// Schedules a new frame by calling [Window.scheduleFrame].
    ///
    /// After this is called, the engine will call [handleBeginFrame], even if
    /// frames would normally not be scheduled by [scheduleFrame] (e.g. even if
    /// the device's screen is turned off).
    ///
    /// The framework uses this to force a frame to be rendered at the correct
    /// size when the phone is rotated, so that a correctly-sized rendering is
    /// available when the screen is turned back on.
    ///
    /// To have a stack trace printed to the console any time this function
    /// schedules a frame, set [debugPrintScheduleFrameStacks] to true.
    ///
    /// Prefer using [scheduleFrame] unless it is imperative that a frame be
    /// scheduled immediately, since using [scheduleForceFrame] will cause
    /// significantly higher battery usage when the device should be idle.
    ///
    /// Consider using [scheduleWarmUpFrame] instead if the goal is to update the
    /// rendering as soon as possible (e.g. at application startup).
    /// </Summary>
    public virtual void ScheduleForcedFrame()
    {
        if (!FramesEnabled) return;
        if (_HasScheduledFrame) return;

        Window.ScheduleFrame();
        _HasScheduledFrame = true;
    }




    /// <Summary>
    /// Schedule a frame to run as soon as possible, rather than waiting for
    /// the engine to request a frame in response to a system "Vsync" signal.
    ///
    /// This is used during application startup so that the first frame (which is
    /// likely to be quite expensive) gets a few extra milliseconds to run.
    ///
    /// Locks events dispatching until the scheduled frame has completed.
    ///
    /// If a frame has already been scheduled with [scheduleFrame] or
    /// [scheduleForcedFrame], this call may delay that frame.
    ///
    /// If any scheduled frame has already begun or if another
    /// [scheduleWarmUpFrame] was already called, this call will be ignored.
    ///
    /// Prefer [scheduleFrame] to update the display in normal operation.
    /// </Summary>
    public virtual void ScheduleWarmUpFrame()
    {
        if (_WarmUpFrame || SchedulerPhase != SchedulerPhase.Idle) return;
        _WarmUpFrame = true;
    Dart: developerDefaultClass.Timeline.StartSync("Warm-up frame");
        bool hadScheduledFrame = _HasScheduledFrame;
    Dart: asyncDefaultClass.Timer.Run(() =>
    {

        HandleBeginFrame(null);
    }
     );
    Dart: asyncDefaultClass.Timer.Run(() =>
    {

        HandleDrawFrame();
        ResetEpoch();
        _WarmUpFrame = false;
        if (hadScheduledFrame) ScheduleFrame();
    }
     );
        LockEvents(() => async {
            await EndOfFrame;
        Dart: developerDefaultClass.Timeline.FinishSync();
        }
);
    }




    /// <Summary>
    /// Prepares the scheduler for a non-monotonic change to how time stamps are
    /// calculated.
    ///
    /// Callbacks received from the scheduler assume that their time stamps are
    /// monotonically increasing. The raw time stamp passed to [handleBeginFrame]
    /// is monotonic, but the scheduler might adjust those time stamps to provide
    /// [timeDilation]. Without careful handling, these adjusts could cause time
    /// to appear to run backwards.
    ///
    /// The [resetEpoch] function ensures that the time stamps are monotonic by
    /// resetting the base time stamp used for future time stamp adjustments to the
    /// current value. For example, if the [timeDilation] decreases, rather than
    /// scaling down the [Duration] since the beginning of time, [resetEpoch] will
    /// ensure that we only scale down the duration since [resetEpoch] was called.
    ///
    /// Setting [timeDilation] calls [resetEpoch] automatically. You don't need to
    /// call [resetEpoch] yourself.
    /// </Summary>
    public virtual void ResetEpoch()
    {
        _EpochStart = _AdjustForEpoch(_LastRawTimeStamp);
        _FirstRawTimeStampInEpoch = null;
    }




    /// <Summary>
    /// Adjusts the given time stamp into the current epoch.
    ///
    /// This both offsets the time stamp to account for when the epoch started
    /// (both in raw time and in the epoch's own time line) and scales the time
    /// stamp to reflect the time dilation in the current epoch.
    ///
    /// These mechanisms together combine to ensure that the durations we give
    /// during frame callbacks are monotonically increasing.
    /// </Summary>
    private TimeSpan _AdjustForEpoch(TimeSpan rawTimeStamp)
    {
        TimeSpan rawDurationSinceEpoch = _FirstRawTimeStampInEpoch == null ? Dart : coreDefaultClass.Duration.Zero:rawTimeStamp - _FirstRawTimeStampInEpoch;
        return new TimeSpan(microseconds: (rawDurationSinceEpoch.InMicroseconds() / BindingDefaultClass.TimeDilation).Round() + _EpochStart.InMicroseconds());
    }




    private void _HandleBeginFrame(TimeSpan rawTimeStamp)
    {
        if (_WarmUpFrame)
        {

            _IgnoreNextEngineDrawFrame = true;
            return;
        }

        HandleBeginFrame(rawTimeStamp);
    }




    private void _HandleDrawFrame()
    {
        if (_IgnoreNextEngineDrawFrame)
        {
            _IgnoreNextEngineDrawFrame = false;
            return;
        }

        HandleDrawFrame();
    }




    /// <Summary>
    /// Called by the engine to prepare the framework to produce a new frame.
    ///
    /// This function calls all the transient frame callbacks registered by
    /// [scheduleFrameCallback]. It then returns, any scheduled microtasks are run
    /// (e.g. handlers for any [Future]s resolved by transient frame callbacks),
    /// and [handleDrawFrame] is called to continue the frame.
    ///
    /// If the given time stamp is null, the time stamp from the last frame is
    /// reused.
    ///
    /// To have a banner shown at the start of every frame in debug mode, set
    /// [debugPrintBeginFrameBanner] to true. The banner will be printed to the
    /// console using [debugPrint] and will contain the frame number (which
    /// increments by one for each frame), and the time stamp of the frame. If the
    /// given time stamp was null, then the string "warm-up frame" is shown
    /// instead of the time stamp. This allows frames eagerly pushed by the
    /// framework to be distinguished from those requested by the engine in
    /// response to the "Vsync" signal from the operating system.
    ///
    /// You can also show a banner at the end of every frame by setting
    /// [debugPrintEndFrameBanner] to true. This allows you to distinguish log
    /// statements printed during a frame from those printed between frames (e.g.
    /// in response to events or timers).
    /// </Summary>
    public virtual void HandleBeginFrame(TimeSpan rawTimeStamp)
    {
    Dart: developerDefaultClass.Timeline.StartSync("Frame", arguments: DebugDefaultClass.TimelineWhitelistArguments);
        _FirstRawTimeStampInEpoch = (_FirstRawTimeStampInEpoch == null ? rawTimeStamp : _FirstRawTimeStampInEpoch);
        _CurrentFrameTimeStamp = _AdjustForEpoch(rawTimeStamp ?? _LastRawTimeStamp);
        if (rawTimeStamp != null) _LastRawTimeStamp = rawTimeStamp;


        _HasScheduledFrame = false;
        try
        {
        Dart: developerDefaultClass.Timeline.StartSync("Animate", arguments: DebugDefaultClass.TimelineWhitelistArguments);
            _SchedulerPhase = SchedulerPhase.TransientCallbacks;
            Dictionary<int, _FrameCallbackEntry> callbacks = _TransientCallbacks;
            _TransientCallbacks = new Dictionary<int, _FrameCallbackEntry> { };
            callbacks.ForEach((int id, _FrameCallbackEntry callbackEntry) =>
            {
                if (!_RemovedIds.Contains(id)) _InvokeFrameCallback(callbackEntry.Callback, _CurrentFrameTimeStamp, callbackEntry.DebugStack);
            }
            );
            _RemovedIds.Clear();
        }
        finally
        {
            _SchedulerPhase = SchedulerPhase.MidFrameMicrotasks;
        }

    }




    /// <Summary>
    /// Called by the engine to produce a new frame.
    ///
    /// This method is called immediately after [handleBeginFrame]. It calls all
    /// the callbacks registered by [addPersistentFrameCallback], which typically
    /// drive the rendering pipeline, and then calls the callbacks registered by
    /// [addPostFrameCallback].
    ///
    /// See [handleBeginFrame] for a discussion about debugging hooks that may be
    /// useful when working with frame callbacks.
    /// </Summary>
    public virtual void HandleDrawFrame()
    {

    Dart: developerDefaultClass.Timeline.FinishSync();
        try
        {
            _SchedulerPhase = SchedulerPhase.PersistentCallbacks;
            foreach (FrameCallback callback in _PersistentCallbacks) _InvokeFrameCallback(callback, _CurrentFrameTimeStamp);
            _SchedulerPhase = SchedulerPhase.PostFrameCallbacks;
            List<FrameCallback> localPostFrameCallbacks = List<FrameCallback>.From(_PostFrameCallbacks);
            _PostFrameCallbacks.Clear();
            foreach (FrameCallback callback in localPostFrameCallbacks) _InvokeFrameCallback(callback, _CurrentFrameTimeStamp);
        }
        finally
        {
            _SchedulerPhase = SchedulerPhase.Idle;
        Dart: developerDefaultClass.Timeline.FinishSync();

            _CurrentFrameTimeStamp = null;
        }

    }




    private void _ProfileFramePostEvent(int frameNumber, FrameTiming frameTiming)
    {
        PostEvent("Flutter.Frame", new Dictionary<string, object> { { "number", frameNumber }{ "startTime", frameTiming.TimestampInMicroseconds(FramePhase.BuildStart) }{ "elapsed", frameTiming.TotalSpan.InMicroseconds() }{ "build", frameTiming.BuildDuration.InMicroseconds() }{ "raster", frameTiming.RasterDuration.InMicroseconds() } });
    }




    private void _DebugDescribeTimeStamp(TimeSpan timeStamp, StringBuffer buffer)
    {
        if (timeStamp.InDays > 0) buffer.Write($"'{timeStamp.InDays}d '");
        if (timeStamp.InHours > 0) buffer.Write($"'{timeStamp.InHours - timeStamp.InDays * Dart:coreDefaultClass.Duration.HoursPerDay}h '");
        if (timeStamp.InMinutes > 0) buffer.Write($"'{timeStamp.InMinutes - timeStamp.InHours * Dart:coreDefaultClass.Duration.MinutesPerHour}m '");
        if (timeStamp.InSeconds > 0) buffer.Write($"'{timeStamp.InSeconds - timeStamp.InMinutes * Dart:coreDefaultClass.Duration.SecondsPerMinute}s '");
        buffer.Write($"'{timeStamp.InMilliseconds - timeStamp.InSeconds * Dart:coreDefaultClass.Duration.MillisecondsPerSecond}'");
        int microseconds = timeStamp.InMicroseconds() - timeStamp.InMilliseconds * Dart:coreDefaultClass.Duration.MicrosecondsPerMillisecond;
        if (microseconds > 0) buffer.Write($"'.{microseconds.ToString().PadLeft(3, '0')}'");
        buffer.Write("ms");
    }




    private void _InvokeFrameCallback(FlutterSDK.Scheduler.Binding.FrameCallback callback, TimeSpan timeStamp, StackTrace callbackStack = default(StackTrace))
    {



        try
        {
            callback(timeStamp);
        }
        catch (exception,exceptionStack){
            AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: exceptionStack, library: "scheduler library", context: new ErrorDescription("during a scheduler callback"), informationCollector: (callbackStack == null) ? null : () => sync *{
yield new DiagnosticsStackTrace("\nThis exception was thrown in the context of a scheduler callback. " + "When the scheduler callback was _registered_ (as opposed to when the " + "exception was thrown), this was the stack", callbackStack);
        }
));
        }


    }



}
public static class SchedulerBindingMixin
{
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
    public static void AddTimingsCallback(this ISchedulerBinding instance, TimingsCallback callback) => GetOrCreate(instance).AddTimingsCallback(callback);
    public static void RemoveTimingsCallback(this ISchedulerBinding instance, TimingsCallback callback) => GetOrCreate(instance).RemoveTimingsCallback(callback);
    public static void InitServiceExtensions(this ISchedulerBinding instance) => GetOrCreate(instance).InitServiceExtensions();
    public static void ReadInitialLifecycleStateFromNativeWindow(this ISchedulerBinding instance) => GetOrCreate(instance).ReadInitialLifecycleStateFromNativeWindow();
    public static void HandleAppLifecycleStateChanged(this ISchedulerBinding instance, AppLifecycleState state) => GetOrCreate(instance).HandleAppLifecycleStateChanged(state);
    public static Future<T> ScheduleTask<T>(this ISchedulerBinding instance, FlutterSDK.Scheduler.Binding.TaskCallback<T> task, FlutterSDK.Scheduler.Priority.Priority priority, string debugLabel = default(string), Flow flow = default(Flow)) => GetOrCreate(instance).ScheduleTask<T>(task, priority, debugLabel, flow);
    public static void Unlocked(this ISchedulerBinding instance) => GetOrCreate(instance).Unlocked();
    public static bool HandleEventLoopCallback(this ISchedulerBinding instance) => GetOrCreate(instance).HandleEventLoopCallback();
    public static int ScheduleFrameCallback(this ISchedulerBinding instance, FlutterSDK.Scheduler.Binding.FrameCallback callback, bool rescheduling = false) => GetOrCreate(instance).ScheduleFrameCallback(callback, rescheduling);
    public static void CancelFrameCallbackWithId(this ISchedulerBinding instance, int id) => GetOrCreate(instance).CancelFrameCallbackWithId(id);
    public static bool DebugAssertNoTransientCallbacks(this ISchedulerBinding instance, string reason) => GetOrCreate(instance).DebugAssertNoTransientCallbacks(reason);
    public static void DebugPrintTransientCallbackRegistrationStack(this ISchedulerBinding instance) => GetOrCreate(instance).DebugPrintTransientCallbackRegistrationStack();
    public static void AddPersistentFrameCallback(this ISchedulerBinding instance, FlutterSDK.Scheduler.Binding.FrameCallback callback) => GetOrCreate(instance).AddPersistentFrameCallback(callback);
    public static void AddPostFrameCallback(this ISchedulerBinding instance, FlutterSDK.Scheduler.Binding.FrameCallback callback) => GetOrCreate(instance).AddPostFrameCallback(callback);
    public static void EnsureFrameCallbacksRegistered(this ISchedulerBinding instance) => GetOrCreate(instance).EnsureFrameCallbacksRegistered();
    public static void EnsureVisualUpdate(this ISchedulerBinding instance) => GetOrCreate(instance).EnsureVisualUpdate();
    public static void ScheduleFrame(this ISchedulerBinding instance) => GetOrCreate(instance).ScheduleFrame();
    public static void ScheduleForcedFrame(this ISchedulerBinding instance) => GetOrCreate(instance).ScheduleForcedFrame();
    public static void ScheduleWarmUpFrame(this ISchedulerBinding instance) => GetOrCreate(instance).ScheduleWarmUpFrame();
    public static void ResetEpoch(this ISchedulerBinding instance) => GetOrCreate(instance).ResetEpoch();
    public static void HandleBeginFrame(this ISchedulerBinding instance, TimeSpan rawTimeStamp) => GetOrCreate(instance).HandleBeginFrame(rawTimeStamp);
    public static void HandleDrawFrame(this ISchedulerBinding instance) => GetOrCreate(instance).HandleDrawFrame();
}


public class _TaskEntry<T>
{
    #region constructors
    public _TaskEntry(FlutterSDK.Scheduler.Binding.TaskCallback<T> task, int priority, string debugLabel, Flow flow)
    {
        this.Task = task;
        this.Priority = priority;
        this.DebugLabel = debugLabel;
        this.Flow = flow;

        Completer = new Completer<T>();
    }


    #endregion

    #region fields
    public virtual FlutterSDK.Scheduler.Binding.TaskCallback<T> Task { get; set; }
    public virtual int Priority { get; set; }
    public virtual string DebugLabel { get; set; }
    public virtual Flow Flow { get; set; }
    public virtual StackTrace DebugStack { get; set; }
    public virtual Completer<T> Completer { get; set; }
    #endregion

    #region methods

    public virtual void Run()
    {
        if (!ConstantsDefaultClass.KReleaseMode)
        {
        Dart: developerDefaultClass.Timeline.TimeSync(DebugLabel ?? "Scheduled Task", () =>
        {
            Completer.Complete(Task());
        }
         , flow: Flow != null ? Dart : developerDefaultClass.Flow.Step(Flow.Id):null);
        }
        else
        {
            Completer.Complete(Task());
        }

    }



    #endregion
}


public class _FrameCallbackEntry
{
    #region constructors
    public _FrameCallbackEntry(FlutterSDK.Scheduler.Binding.FrameCallback callback, bool rescheduling = false)
    {
        this.Callback = callback;

    }


    #endregion

    #region fields
    public virtual FlutterSDK.Scheduler.Binding.FrameCallback Callback { get; set; }
    public virtual StackTrace DebugCurrentCallbackStack { get; set; }
    public virtual StackTrace DebugStack { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// The various phases that a [SchedulerBinding] goes through during
/// [SchedulerBinding.handleBeginFrame].
///
/// This is exposed by [SchedulerBinding.schedulerPhase].
///
/// The values of this enum are ordered in the same order as the phases occur,
/// so their relative index values can be compared to each other.
///
/// See also:
///
///  * [WidgetsBinding.drawFrame], which pumps the build and rendering pipeline
///    to generate a frame.
/// </Summary>
public enum SchedulerPhase
{

    /// <Summary>
    /// No frame is being processed. Tasks (scheduled by
    /// [WidgetsBinding.scheduleTask]), microtasks (scheduled by
    /// [scheduleMicrotask]), [Timer] callbacks, event handlers (e.g. from user
    /// input), and other callbacks (e.g. from [Future]s, [Stream]s, and the like)
    /// may be executing.
    /// </Summary>
    Idle,
    /// <Summary>
    /// The transient callbacks (scheduled by
    /// [WidgetsBinding.scheduleFrameCallback]) are currently executing.
    ///
    /// Typically, these callbacks handle updating objects to new animation
    /// states.
    ///
    /// See [SchedulerBinding.handleBeginFrame].
    /// </Summary>
    TransientCallbacks,
    /// <Summary>
    /// Microtasks scheduled during the processing of transient callbacks are
    /// current executing.
    ///
    /// This may include, for instance, callbacks from futures resolved during the
    /// [transientCallbacks] phase.
    /// </Summary>
    MidFrameMicrotasks,
    /// <Summary>
    /// The persistent callbacks (scheduled by
    /// [WidgetsBinding.addPersistentFrameCallback]) are currently executing.
    ///
    /// Typically, this is the build/layout/paint pipeline. See
    /// [WidgetsBinding.drawFrame] and [SchedulerBinding.handleDrawFrame].
    /// </Summary>
    PersistentCallbacks,
    /// <Summary>
    /// The post-frame callbacks (scheduled by
    /// [WidgetsBinding.addPostFrameCallback]) are currently executing.
    ///
    /// Typically, these callbacks handle cleanup and scheduling of work for the
    /// next frame.
    ///
    /// See [SchedulerBinding.handleDrawFrame].
    /// </Summary>
    PostFrameCallbacks,
}

}
