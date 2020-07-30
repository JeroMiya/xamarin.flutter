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
namespace FlutterSDK.Widgets.Binding
{
    internal static class BindingDefaultClass
    {
        internal static void RunApp(FlutterSDK.Widgets.Framework.Widget app)
        {
            BindingDefaultClass.WidgetsFlutterBinding.EnsureInitialized();
            BindingDefaultClass.WidgetsFlutterBinding.EnsureInitialized().ScheduleAttachRootWidget(app);
            BindingDefaultClass.WidgetsFlutterBinding.EnsureInitialized().ScheduleWarmUpFrame();
        }



        internal static void DebugDumpApp()
        {

            string mode = "RELEASE MODE";

            PrintDefaultClass.DebugPrint($"'{BindingDefaultClass.WidgetsBinding.Instance.GetType()} - {mode}'");
            if (BindingDefaultClass.WidgetsBinding.Instance.RenderViewElement != null)
            {
                PrintDefaultClass.DebugPrint(BindingDefaultClass.WidgetsBinding.Instance.RenderViewElement.ToStringDeep());
            }
            else
            {
                PrintDefaultClass.DebugPrint("<no tree currently mounted>");
            }

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

        public new void InitInstances()
        {
            base.InitInstances();
            _Instance = this;

            _BuildOwner = new BuildOwner();
            BuildOwner.OnBuildScheduled = _HandleBuildScheduled;
            Window.OnLocaleChanged = HandleLocaleChanged;
            Window.OnAccessibilityFeaturesChanged = HandleAccessibilityFeaturesChanged;
            SystemchannelsDefaultClass.SystemChannels.Navigation.SetMethodCallHandler(_HandleNavigationInvocation);
            AssertionsDefaultClass.FlutterErrorDetails.PropertiesTransformers.Add(WidgetinspectorDefaultClass.TransformDebugCreator);
        }




        private void _DebugAddStackFilters()
        {
            PartialStackFrame elementInflateWidget = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "Element", method: "inflateWidget");
            PartialStackFrame elementUpdateChild = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "Element", method: "updateChild");
            PartialStackFrame elementRebuild = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "Element", method: "rebuild");
            PartialStackFrame componentElementPerformRebuild = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "ComponentElement", method: "performRebuild");
            PartialStackFrame componentElementFirstBuild = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "ComponentElement", method: "_firstBuild");
            PartialStackFrame componentElementMount = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "ComponentElement", method: "mount");
            PartialStackFrame statefulElementFirstBuild = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "StatefulElement", method: "_firstBuild");
            PartialStackFrame singleChildMount = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "SingleChildRenderObjectElement", method: "mount");
            PartialStackFrame statefulElementRebuild = new PartialStackFrame(package: "package:flutter/src/widgets/framework.dart", className: "StatefulElement", method: "performRebuild");
            string replacementString = "...     Normal element mounting";
            AssertionsDefaultClass.FlutterError.AddDefaultStackFilter(new RepetitiveStackFrameFilter(frames: new List<PartialStackFrame>() { elementInflateWidget, elementUpdateChild, componentElementPerformRebuild, elementRebuild, componentElementFirstBuild, componentElementMount }, replacement: replacementString));
            AssertionsDefaultClass.FlutterError.AddDefaultStackFilter(new RepetitiveStackFrameFilter(frames: new List<PartialStackFrame>() { elementUpdateChild, componentElementPerformRebuild, elementRebuild, componentElementFirstBuild, componentElementMount }, replacement: replacementString));
            AssertionsDefaultClass.FlutterError.AddDefaultStackFilter(new RepetitiveStackFrameFilter(frames: new List<PartialStackFrame>() { elementInflateWidget, elementUpdateChild, componentElementPerformRebuild, statefulElementRebuild, elementRebuild, componentElementFirstBuild, statefulElementFirstBuild, componentElementMount }, replacement: replacementString));
            AssertionsDefaultClass.FlutterError.AddDefaultStackFilter(new RepetitiveStackFrameFilter(frames: new List<PartialStackFrame>() { elementUpdateChild, componentElementPerformRebuild, statefulElementRebuild, elementRebuild, componentElementFirstBuild, statefulElementFirstBuild, componentElementMount }, replacement: replacementString));
            AssertionsDefaultClass.FlutterError.AddDefaultStackFilter(new RepetitiveStackFrameFilter(frames: new List<PartialStackFrame>() { elementInflateWidget, elementUpdateChild, singleChildMount }, replacement: replacementString));
            AssertionsDefaultClass.FlutterError.AddDefaultStackFilter(new RepetitiveStackFrameFilter(frames: new List<PartialStackFrame>() { elementUpdateChild, singleChildMount }, replacement: replacementString));
        }




        public new void InitServiceExtensions()
        {
            base.InitServiceExtensions();
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                RegisterSignalServiceExtension(name: "debugDumpApp", callback: () =>
                {
                    BindingDefaultClass.DebugDumpApp();
                    return PrintDefaultClass.DebugPrintDone;
                }
                );
                if (!ConstantsDefaultClass.KIsWeb)
                {
                    RegisterBoolServiceExtension(name: "showPerformanceOverlay", getter: () => =>Future<bool>.Value(AppDefaultClass.WidgetsApp.ShowPerformanceOverlayOverride), setter: (bool value) =>
                    {
                        if (AppDefaultClass.WidgetsApp.ShowPerformanceOverlayOverride == value) return Future<void>.Value();
                        AppDefaultClass.WidgetsApp.ShowPerformanceOverlayOverride = value;
                        return _ForceRebuild();
                    }
                    );
                }

                RegisterServiceExtension(name: "didSendFirstFrameEvent", callback: async (_) =>
                {
                    return new Dictionary<string, object> { { "enabled", _NeedToReportFirstFrame ? "false" : "true" } };
                }
                );
                RegisterServiceExtension(name: "didSendFirstFrameRasterizedEvent", callback: async (_) =>
                {
                    return new Dictionary<string, object> { { "enabled", FirstFrameRasterized ? "true" : "false" } };
                }
                );
                RegisterServiceExtension(name: "fastReassemble", callback: async(Dictionary<string, object> params) => {
                    string className =params["class"] as string;
                    void MarkElementsDirty(Element element)
                    {
                        if (element == null)
                        {
                            return;
                        }

                        if (element.Widget?.GetType()?.ToString()?.StartsWith(className) ?? false)
                        {
                            element.MarkNeedsBuild();
                        }

                        element.VisitChildElements(MarkElementsDirty);
                    }

                    MarkElementsDirty(RenderViewElement);
                    return new Dictionary<string, string> { { "Success", "true" } };
                }
);
                RegisterBoolServiceExtension(name: "profileWidgetBuilds", getter: async () => async => DebugDefaultClass.DebugProfileBuildsEnabled, setter: async (bool value) =>
                {
                    if (DebugDefaultClass.DebugProfileBuildsEnabled != value) DebugDefaultClass.DebugProfileBuildsEnabled = value;
                }
                );
            }


        }




        private Future<object> _ForceRebuild()
        {
            if (RenderViewElement != null)
            {
                BuildOwner.Reassemble(RenderViewElement);
                return EndOfFrame;
            }

            return Future<void>.Value();
        }




        /// <Summary>
        /// Registers the given object as a binding observer. Binding
        /// observers are notified when various application events occur,
        /// for example when the system locale changes. Generally, one
        /// widget in the widget tree registers itself as a binding
        /// observer, and converts the system state into inherited widgets.
        ///
        /// For example, the [WidgetsApp] widget registers as a binding
        /// observer and passes the screen size to a [MediaQuery] widget
        /// each time it is built, which enables other widgets to use the
        /// [MediaQuery.of] static method and (implicitly) the
        /// [InheritedWidget] mechanism to be notified whenever the screen
        /// size changes (e.g. whenever the screen rotates).
        ///
        /// See also:
        ///
        ///  * [removeObserver], to release the resources reserved by this method.
        ///  * [WidgetsBindingObserver], which has an example of using this method.
        /// </Summary>
        public virtual void AddObserver(FlutterSDK.Widgets.Binding.WidgetsBindingObserver observer) => _Observers.Add(observer);



        /// <Summary>
        /// Unregisters the given observer. This should be used sparingly as
        /// it is relatively expensive (O(N) in the number of registered
        /// observers).
        ///
        /// See also:
        ///
        ///  * [addObserver], for the method that adds observers in the first place.
        ///  * [WidgetsBindingObserver], which has an example of using this method.
        /// </Summary>
        public virtual bool RemoveObserver(FlutterSDK.Widgets.Binding.WidgetsBindingObserver observer) => _Observers.Remove(observer);



        public new void HandleMetricsChanged()
        {
            base.HandleMetricsChanged();
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangeMetrics();
        }




        public new void HandleTextScaleFactorChanged()
        {
            base.HandleTextScaleFactorChanged();
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangeTextScaleFactor();
        }




        public new void HandlePlatformBrightnessChanged()
        {
            base.HandlePlatformBrightnessChanged();
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangePlatformBrightness();
        }




        public new void HandleAccessibilityFeaturesChanged()
        {
            base.HandleAccessibilityFeaturesChanged();
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangeAccessibilityFeatures();
        }




        /// <Summary>
        /// Called when the system locale changes.
        ///
        /// Calls [dispatchLocaleChanged] to notify the binding observers.
        ///
        /// See [Window.onLocaleChanged].
        /// </Summary>
        public virtual void HandleLocaleChanged()
        {
            DispatchLocalesChanged(Window.Locales);
        }




        /// <Summary>
        /// Notify all the observers that the locale has changed (using
        /// [WidgetsBindingObserver.didChangeLocales]), giving them the
        /// `locales` argument.
        ///
        /// This is called by [handleLocaleChanged] when the [Window.onLocaleChanged]
        /// notification is received.
        /// </Summary>
        public virtual void DispatchLocalesChanged(List<Locale> locales)
        {
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangeLocales(locales);
        }




        /// <Summary>
        /// Notify all the observers that the active set of [AccessibilityFeatures]
        /// has changed (using [WidgetsBindingObserver.didChangeAccessibilityFeatures]),
        /// giving them the `features` argument.
        ///
        /// This is called by [handleAccessibilityFeaturesChanged] when the
        /// [Window.onAccessibilityFeaturesChanged] notification is received.
        /// </Summary>
        public virtual void DispatchAccessibilityFeaturesChanged()
        {
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangeAccessibilityFeatures();
        }




        /// <Summary>
        /// Called when the system pops the current route.
        ///
        /// This first notifies the binding observers (using
        /// [WidgetsBindingObserver.didPopRoute]), in registration order, until one
        /// returns true, meaning that it was able to handle the request (e.g. by
        /// closing a dialog box). If none return true, then the application is shut
        /// down by calling [SystemNavigator.pop].
        ///
        /// [WidgetsApp] uses this in conjunction with a [Navigator] to
        /// cause the back button to close dialog boxes, return from modal
        /// pages, and so forth.
        ///
        /// This method exposes the `popRoute` notification from
        /// [SystemChannels.navigation].
        /// </Summary>
        public virtual async Future<object> HandlePopRoute()
        {
            foreach (WidgetsBindingObserver observer in List<WidgetsBindingObserver>.From(_Observers))
            {
                if (await observer.DidPopRoute()) return;
            }

            SystemnavigatorDefaultClass.SystemNavigator.Pop();
        }




        /// <Summary>
        /// Called when the host tells the app to push a new route onto the
        /// navigator.
        ///
        /// This notifies the binding observers (using
        /// [WidgetsBindingObserver.didPushRoute]), in registration order, until one
        /// returns true, meaning that it was able to handle the request (e.g. by
        /// opening a dialog box). If none return true, then nothing happens.
        ///
        /// This method exposes the `pushRoute` notification from
        /// [SystemChannels.navigation].
        /// </Summary>
        public virtual async Future<object> HandlePushRoute(string route)
        {
            foreach (WidgetsBindingObserver observer in List<WidgetsBindingObserver>.From(_Observers))
            {
                if (await observer.DidPushRoute(route)) return;
            }

        }




        private Future<object> _HandleNavigationInvocation(FlutterSDK.Services.Messagecodec.MethodCall methodCall)
        {
            switch (methodCall.Method) { case "popRoute": return HandlePopRoute(); case "pushRoute": return HandlePushRoute(methodCall.Arguments as string); }
            return Future<object>.Value();
        }




        public new void HandleAppLifecycleStateChanged(AppLifecycleState state)
        {
            base.HandleAppLifecycleStateChanged(state);
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidChangeAppLifecycleState(state);
        }




        /// <Summary>
        /// Called when the operating system notifies the application of a memory
        /// pressure situation.
        ///
        /// Notifies all the observers using
        /// [WidgetsBindingObserver.didHaveMemoryPressure].
        ///
        /// This method exposes the `memoryPressure` notification from
        /// [SystemChannels.system].
        /// </Summary>
        public virtual void HandleMemoryPressure()
        {
            foreach (WidgetsBindingObserver observer in _Observers) observer.DidHaveMemoryPressure();
        }




        public new async Future<object> HandleSystemMessage(@Object systemMessage)
        {
            await base.HandleSystemMessage(systemMessage);
            Dictionary<string, object> message = systemMessage as Dictionary<string, object>;
            string type = message["type"] as string;
            switch (type) { case "memoryPressure": HandleMemoryPressure(); break; }
            return;
        }




        /// <Summary>
        /// Tell the framework not to report the frame it is building as a "useful"
        /// first frame until there is a corresponding call to [allowFirstFrameReport].
        ///
        /// Deprecated. Use [deferFirstFrame]/[allowFirstFrame] to delay rendering the
        /// first frame.
        /// </Summary>
        public virtual void DeferFirstFrameReport()
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                DeferFirstFrame();
            }

        }




        /// <Summary>
        /// When called after [deferFirstFrameReport]: tell the framework to report
        /// the frame it is building as a "useful" first frame.
        ///
        /// Deprecated. Use [deferFirstFrame]/[allowFirstFrame] to delay rendering the
        /// first frame.
        /// </Summary>
        public virtual void AllowFirstFrameReport()
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                AllowFirstFrame();
            }

        }




        private void _HandleBuildScheduled()
        {

            EnsureVisualUpdate();
        }




        /// <Summary>
        /// Pump the build and rendering pipeline to generate a frame.
        ///
        /// This method is called by [handleDrawFrame], which itself is called
        /// automatically by the engine when it is time to lay out and paint a
        /// frame.
        ///
        /// Each frame consists of the following phases:
        ///
        /// 1. The animation phase: The [handleBeginFrame] method, which is registered
        /// with [Window.onBeginFrame], invokes all the transient frame callbacks
        /// registered with [scheduleFrameCallback], in
        /// registration order. This includes all the [Ticker] instances that are
        /// driving [AnimationController] objects, which means all of the active
        /// [Animation] objects tick at this point.
        ///
        /// 2. Microtasks: After [handleBeginFrame] returns, any microtasks that got
        /// scheduled by transient frame callbacks get to run. This typically includes
        /// callbacks for futures from [Ticker]s and [AnimationController]s that
        /// completed this frame.
        ///
        /// After [handleBeginFrame], [handleDrawFrame], which is registered with
        /// [Window.onDrawFrame], is called, which invokes all the persistent frame
        /// callbacks, of which the most notable is this method, [drawFrame], which
        /// proceeds as follows:
        ///
        /// 3. The build phase: All the dirty [Element]s in the widget tree are
        /// rebuilt (see [State.build]). See [State.setState] for further details on
        /// marking a widget dirty for building. See [BuildOwner] for more information
        /// on this step.
        ///
        /// 4. The layout phase: All the dirty [RenderObject]s in the system are laid
        /// out (see [RenderObject.performLayout]). See [RenderObject.markNeedsLayout]
        /// for further details on marking an object dirty for layout.
        ///
        /// 5. The compositing bits phase: The compositing bits on any dirty
        /// [RenderObject] objects are updated. See
        /// [RenderObject.markNeedsCompositingBitsUpdate].
        ///
        /// 6. The paint phase: All the dirty [RenderObject]s in the system are
        /// repainted (see [RenderObject.paint]). This generates the [Layer] tree. See
        /// [RenderObject.markNeedsPaint] for further details on marking an object
        /// dirty for paint.
        ///
        /// 7. The compositing phase: The layer tree is turned into a [Scene] and
        /// sent to the GPU.
        ///
        /// 8. The semantics phase: All the dirty [RenderObject]s in the system have
        /// their semantics updated (see [RenderObject.assembleSemanticsNode]). This
        /// generates the [SemanticsNode] tree. See
        /// [RenderObject.markNeedsSemanticsUpdate] for further details on marking an
        /// object dirty for semantics.
        ///
        /// For more details on steps 4-8, see [PipelineOwner].
        ///
        /// 9. The finalization phase in the widgets layer: The widgets tree is
        /// finalized. This causes [State.dispose] to be invoked on any objects that
        /// were removed from the widgets tree this frame. See
        /// [BuildOwner.finalizeTree] for more details.
        ///
        /// 10. The finalization phase in the scheduler layer: After [drawFrame]
        /// returns, [handleDrawFrame] then invokes post-frame callbacks (registered
        /// with [addPostFrameCallback]).
        /// </Summary>
        public new void DrawFrame()
        {


            TimingsCallback firstFrameCallback = default(TimingsCallback);
            if (_NeedToReportFirstFrame)
            {

                firstFrameCallback = (List<FrameTiming> timings) =>
                {

                    if (!ConstantsDefaultClass.KReleaseMode)
                    {
                        Dart.Developer.DeveloperDefaultClass.Timeline.InstantSync("Rasterized first useful frame");
                        Dart.Developer.DeveloperDefaultClass.PostEvent("Flutter.FirstFrame", new Dictionary<string, object> { });
                    }

                    BindingDefaultClass.SchedulerBinding.Instance.RemoveTimingsCallback(firstFrameCallback);
                    firstFrameCallback = null;
                    _FirstFrameCompleter.Complete();
                }
                ;
                BindingDefaultClass.SchedulerBinding.Instance.AddTimingsCallback(firstFrameCallback);
            }

            try
            {
                if (RenderViewElement != null) BuildOwner.BuildScope(RenderViewElement);
                base.DrawFrame();
                BuildOwner.FinalizeTree();
            }
            finally
            {

            }

            if (!ConstantsDefaultClass.KReleaseMode)
            {
                if (_NeedToReportFirstFrame && SendFramesToEngine)
                {
                    Dart.Developer.DeveloperDefaultClass.Timeline.InstantSync("Widgets built first useful frame");
                }

            }

            _NeedToReportFirstFrame = false;
            if (firstFrameCallback != null && !SendFramesToEngine)
            {
                BindingDefaultClass.SchedulerBinding.Instance.RemoveTimingsCallback(firstFrameCallback);
            }

        }




        /// <Summary>
        /// Schedules a [Timer] for attaching the root widget.
        ///
        /// This is called by [runApp] to configure the widget tree. Consider using
        /// [attachRootWidget] if you want to build the widget tree synchronously.
        /// </Summary>
        public virtual void ScheduleAttachRootWidget(FlutterSDK.Widgets.Framework.Widget rootWidget)
        {
            Dart.AsyncDefaultClass.Timer.Run(() =>
            {
                AttachRootWidget(rootWidget);
            }
            );
        }




        /// <Summary>
        /// Takes a widget and attaches it to the [renderViewElement], creating it if
        /// necessary.
        ///
        /// This is called by [runApp] to configure the widget tree.
        ///
        /// See also:
        ///
        ///  * [RenderObjectToWidgetAdapter.attachToRenderTree], which inflates a
        ///    widget and attaches it to the render tree.
        /// </Summary>
        public virtual void AttachRootWidget(FlutterSDK.Widgets.Framework.Widget rootWidget)
        {
            _ReadyToProduceFrames = true;
            _RenderViewElement = new RenderObjectToWidgetAdapter<RenderBox>(container: RenderView, debugShortDescription: "[root]", child: rootWidget).AttachToRenderTree(BuildOwner, RenderViewElement as RenderObjectToWidgetElement<RenderBox>);
        }




        public new Future<object> PerformReassemble()
        {

            if (RenderViewElement != null) BuildOwner.Reassemble(RenderViewElement);
            return base.PerformReassemble();
        }



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

        /// <Summary>
        /// Called when the system tells the app to pop the current route.
        /// For example, on Android, this is called when the user presses
        /// the back button.
        ///
        /// Observers are notified in registration order until one returns
        /// true. If none return true, the application quits.
        ///
        /// Observers are expected to return true if they were able to
        /// handle the notification, for example by closing an active dialog
        /// box, and false otherwise. The [WidgetsApp] widget uses this
        /// mechanism to notify the [Navigator] widget that it should pop
        /// its current route if possible.
        ///
        /// This method exposes the `popRoute` notification from
        /// [SystemChannels.navigation].
        /// </Summary>
        public virtual Future<bool> DidPopRoute() => Future<bool>.Value(false);



        /// <Summary>
        /// Called when the host tells the app to push a new route onto the
        /// navigator.
        ///
        /// Observers are expected to return true if they were able to
        /// handle the notification. Observers are notified in registration
        /// order until one returns true.
        ///
        /// This method exposes the `pushRoute` notification from
        /// [SystemChannels.navigation].
        /// </Summary>
        public virtual Future<bool> DidPushRoute(string route) => Future<bool>.Value(false);



        /// <Summary>
        /// Called when the application's dimensions change. For example,
        /// when a phone is rotated.
        ///
        /// This method exposes notifications from [Window.onMetricsChanged].
        ///
        /// {@tool snippet}
        ///
        /// This [StatefulWidget] implements the parts of the [State] and
        /// [WidgetsBindingObserver] protocols necessary to react when the device is
        /// rotated (or otherwise changes dimensions).
        ///
        /// ```dart
        /// class MetricsReactor extends StatefulWidget {
        ///   const MetricsReactor({ Key key }) : super(key: key);
        ///
        ///   @override
        ///   _MetricsReactorState createState() => _MetricsReactorState();
        /// }
        ///
        /// class _MetricsReactorState extends State<MetricsReactor> with WidgetsBindingObserver {
        ///   Size _lastSize;
        ///
        ///   @override
        ///   void initState() {
        ///     super.initState();
        ///     _lastSize = WidgetsBinding.instance.window.physicalSize;
        ///     WidgetsBinding.instance.addObserver(this);
        ///   }
        ///
        ///   @override
        ///   void dispose() {
        ///     WidgetsBinding.instance.removeObserver(this);
        ///     super.dispose();
        ///   }
        ///
        ///   @override
        ///   void didChangeMetrics() {
        ///     setState(() { _lastSize = WidgetsBinding.instance.window.physicalSize; });
        ///   }
        ///
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return Text('Current size: $_lastSize');
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// In general, this is unnecessary as the layout system takes care of
        /// automatically recomputing the application geometry when the application
        /// size changes.
        ///
        /// See also:
        ///
        ///  * [MediaQuery.of], which provides a similar service with less
        ///    boilerplate.
        /// </Summary>
        public virtual void DidChangeMetrics()
        {
        }




        /// <Summary>
        /// Called when the platform's text scale factor changes.
        ///
        /// This typically happens as the result of the user changing system
        /// preferences, and it should affect all of the text sizes in the
        /// application.
        ///
        /// This method exposes notifications from [Window.onTextScaleFactorChanged].
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// class TextScaleFactorReactor extends StatefulWidget {
        ///   const TextScaleFactorReactor({ Key key }) : super(key: key);
        ///
        ///   @override
        ///   _TextScaleFactorReactorState createState() => _TextScaleFactorReactorState();
        /// }
        ///
        /// class _TextScaleFactorReactorState extends State<TextScaleFactorReactor> with WidgetsBindingObserver {
        ///   @override
        ///   void initState() {
        ///     super.initState();
        ///     WidgetsBinding.instance.addObserver(this);
        ///   }
        ///
        ///   @override
        ///   void dispose() {
        ///     WidgetsBinding.instance.removeObserver(this);
        ///     super.dispose();
        ///   }
        ///
        ///   double _lastTextScaleFactor;
        ///
        ///   @override
        ///   void didChangeTextScaleFactor() {
        ///     setState(() { _lastTextScaleFactor = WidgetsBinding.instance.window.textScaleFactor; });
        ///   }
        ///
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return Text('Current scale factor: $_lastTextScaleFactor');
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [MediaQuery.of], which provides a similar service with less
        ///    boilerplate.
        /// </Summary>
        public virtual void DidChangeTextScaleFactor()
        {
        }




        /// <Summary>
        /// Called when the platform brightness changes.
        ///
        /// This method exposes notifications from [Window.onPlatformBrightnessChanged].
        /// </Summary>
        public virtual void DidChangePlatformBrightness()
        {
        }




        /// <Summary>
        /// Called when the system tells the app that the user's locale has
        /// changed. For example, if the user changes the system language
        /// settings.
        ///
        /// This method exposes notifications from [Window.onLocaleChanged].
        /// </Summary>
        public virtual void DidChangeLocales(List<Locale> locale)
        {
        }




        /// <Summary>
        /// Called when the system puts the app in the background or returns
        /// the app to the foreground.
        ///
        /// An example of implementing this method is provided in the class-level
        /// documentation for the [WidgetsBindingObserver] class.
        ///
        /// This method exposes notifications from [SystemChannels.lifecycle].
        /// </Summary>
        public virtual void DidChangeAppLifecycleState(AppLifecycleState state)
        {
        }




        /// <Summary>
        /// Called when the system is running low on memory.
        ///
        /// This method exposes the `memoryPressure` notification from
        /// [SystemChannels.system].
        /// </Summary>
        public virtual void DidHaveMemoryPressure()
        {
        }




        /// <Summary>
        /// Called when the system changes the set of currently active accessibility
        /// features.
        ///
        /// This method exposes notifications from [Window.onAccessibilityFeaturesChanged].
        /// </Summary>
        public virtual void DidChangeAccessibilityFeatures()
        {
        }



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


    /// <Summary>
    /// A bridge from a [RenderObject] to an [Element] tree.
    ///
    /// The given container is the [RenderObject] that the [Element] tree should be
    /// inserted into. It must be a [RenderObject] that implements the
    /// [RenderObjectWithChildMixin] protocol. The type argument `T` is the kind of
    /// [RenderObject] that the container expects as its child.
    ///
    /// Used by [runApp] to bootstrap applications.
    /// </Summary>
    public class RenderObjectToWidgetAdapter<T> : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        public RenderObjectToWidgetAdapter(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T> container = default(FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T>), string debugShortDescription = default(string))
        : base(key: new GlobalObjectKey(container))
        {
            this.Child = child;
            this.Container = container;
            this.DebugShortDescription = debugShortDescription;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T> Container { get; set; }
        public virtual string DebugShortDescription { get; set; }

        public new RenderObjectToWidgetElement<T> CreateElement() => new RenderObjectToWidgetElement<T>(this);



        public new RenderObjectWithChildMixin<T> CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => Container;



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
        }




        /// <Summary>
        /// Inflate this widget and actually set the resulting [RenderObject] as the
        /// child of [container].
        ///
        /// If `element` is null, this function will create a new element. Otherwise,
        /// the given element will have an update scheduled to switch to this widget.
        ///
        /// Used by [runApp] to bootstrap applications.
        /// </Summary>
        public virtual RenderObjectToWidgetElement<T> AttachToRenderTree(FlutterSDK.Widgets.Framework.BuildOwner owner, FlutterSDK.Widgets.Binding.RenderObjectToWidgetElement<T> element = default(FlutterSDK.Widgets.Binding.RenderObjectToWidgetElement<T>))
        {
            if (element == null)
            {
                owner.LockState(() =>
                {
                    element = CreateElement();

                    element.AssignOwner(owner);
                }
                );
                owner.BuildScope(element, () =>
                {
                    element.Mount(null, null);
                }
                );
                BindingDefaultClass.SchedulerBinding.Instance.EnsureVisualUpdate();
            }
            else
            {
                element._NewWidget = this;
                element.MarkNeedsBuild();
            }

            return element;
        }




        public new string ToStringShort() => DebugShortDescription ?? base.ToStringShort();


    }


    /// <Summary>
    /// A [RootRenderObjectElement] that is hosted by a [RenderObject].
    ///
    /// This element class is the instantiation of a [RenderObjectToWidgetAdapter]
    /// widget. It can be used only as the root of an [Element] tree (it cannot be
    /// mounted into another [Element]; it's parent must be null).
    ///
    /// In typical usage, it will be instantiated for a [RenderObjectToWidgetAdapter]
    /// whose container is the [RenderView] that connects to the Flutter engine. In
    /// this usage, it is normally instantiated by the bootstrapping logic in the
    /// [WidgetsFlutterBinding] singleton created by [runApp].
    /// </Summary>
    public class RenderObjectToWidgetElement<T> : FlutterSDK.Widgets.Framework.RootRenderObjectElement
    {
        public RenderObjectToWidgetElement(FlutterSDK.Widgets.Binding.RenderObjectToWidgetAdapter<T> widget)
        : base(widget)
        {

        }
        internal virtual FlutterSDK.Widgets.Framework.Element _Child { get; set; }
        internal virtual @Object _RootChildSlot { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _NewWidget { get; set; }
        public virtual FlutterSDK.Widgets.Binding.RenderObjectToWidgetAdapter<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObjectWithChildMixin<T> RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            if (_Child != null) visitor(_Child);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            _Child = null;
            base.ForgetChild(child);
        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {

            base.Mount(parent, newSlot);
            _Rebuild();
        }




        public new void Update(FlutterSDK.Widgets.Binding.RenderObjectToWidgetAdapter<T> newWidget)
        {
            base.Update(newWidget);

            _Rebuild();
        }




        public new void PerformRebuild()
        {
            if (_NewWidget != null)
            {
                Widget newWidget = _NewWidget;
                _NewWidget = null;
                Update(newWidget as RenderObjectToWidgetAdapter<T>);
            }

            base.PerformRebuild();

        }




        private void _Rebuild()
        {
            try
            {
                _Child = UpdateChild(_Child, Widget.Child, _RootChildSlot);

            }
            catch (exception,stack){
                FlutterErrorDetails details = new FlutterErrorDetails(exception: exception, stack: stack, library: "widgets library", context: new ErrorDescription("attaching to the render tree"));
                AssertionsDefaultClass.FlutterError.ReportError(details);
                Widget error = FrameworkDefaultClass.ErrorWidget.Builder(details);
                _Child = UpdateChild(null, error, _RootChildSlot);
            }

            }




public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {


            RenderObject.Child = child as T;
        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {

            RenderObject.Child = null;
        }



    }


    /// <Summary>
    /// A concrete binding for applications based on the Widgets framework.
    ///
    /// This is the glue that binds the framework to the Flutter engine.
    /// </Summary>
    public class WidgetsFlutterBinding : FlutterSDK.Foundation.Binding.BindingBase, IGestureBinding, IServicesBinding, ISchedulerBinding, IPaintingBinding, ISemanticsBinding, IRendererBinding, IWidgetsBinding
    {
        public WidgetsFlutterBinding()
        { }

        /// <Summary>
        /// Returns an instance of the [WidgetsBinding], creating and
        /// initializing it if necessary. If one is created, it will be a
        /// [WidgetsFlutterBinding]. If one was previously initialized, then
        /// it will at least implement [WidgetsBinding].
        ///
        /// You only need to call this method if you need the binding to be
        /// initialized before calling [runApp].
        ///
        /// In the `flutter_test` framework, [testWidgets] initializes the
        /// binding instance to a [TestWidgetsFlutterBinding], not a
        /// [WidgetsFlutterBinding].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Binding.WidgetsBinding EnsureInitialized()
        {
            if (BindingDefaultClass.WidgetsBinding.Instance == null) new WidgetsFlutterBinding();
            return BindingDefaultClass.WidgetsBinding.Instance;
        }



    }

}
