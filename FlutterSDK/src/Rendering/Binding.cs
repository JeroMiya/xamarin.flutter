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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Rendering.Binding
{
    internal static class BindingDefaultClass
    {
        internal static void DebugDumpRenderTree()
        {
            throw new NotImplementedException();
        }

        internal static void DebugDumpLayerTree()
        {
            throw new NotImplementedException();
        }

        internal static void DebugDumpSemanticsTree(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder)
        {
            throw new NotImplementedException();
        }

    }

    public interface IRendererBinding { }

    public class RendererBinding
    {
        internal virtual FlutterSDK.Rendering.Binding.RendererBinding _Instance { get; set; }
        internal virtual FlutterSDK.Rendering.Mousetracking.MouseTracker _MouseTracker { get; set; }
        internal virtual FlutterSDK.Rendering.@object.PipelineOwner _PipelineOwner { get; set; }
        internal virtual FlutterSDK.Rendering.@object.SemanticsHandle _SemanticsHandle { get; set; }
        internal virtual int _FirstFrameDeferredCount { get; set; }
        internal virtual bool _FirstFrameSent { get; set; }
        public virtual FlutterSDK.Rendering.Binding.RendererBinding Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Mousetracking.MouseTracker MouseTracker { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.PipelineOwner PipelineOwner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.View.RenderView RenderView { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SendFramesToEngine { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitInstances()
        {
            base.InitInstances();
            _Instance = this;
            _PipelineOwner = new PipelineOwner(onNeedVisualUpdate: EnsureVisualUpdate, onSemanticsOwnerCreated: _HandleSemanticsOwnerCreated, onSemanticsOwnerDisposed: _HandleSemanticsOwnerDisposed);
            ..OnMetricsChanged = HandleMetricsChanged..OnTextScaleFactorChanged = HandleTextScaleFactorChanged..OnPlatformBrightnessChanged = HandlePlatformBrightnessChanged..OnSemanticsEnabledChanged = _HandleSemanticsEnabledChanged..OnSemanticsAction = _HandleSemanticsAction;
            InitRenderView();
            _HandleSemanticsEnabledChanged();

            AddPersistentFrameCallback(_HandlePersistentFrameCallback);
            InitMouseTracker();
        }




        public new void InitServiceExtensions()
        {
            base.InitServiceExtensions();

            if (!ConstantsDefaultClass.KReleaseMode)
            {
                RegisterSignalServiceExtension(name: "debugDumpRenderTree", callback: () =>
                {
                    BindingDefaultClass.DebugDumpRenderTree();
                    return PrintDefaultClass.DebugPrintDone;
                }
                );
                RegisterSignalServiceExtension(name: "debugDumpSemanticsTreeInTraversalOrder", callback: () =>
                {
                    BindingDefaultClass.DebugDumpSemanticsTree(DebugSemanticsDumpOrder.TraversalOrder);
                    return PrintDefaultClass.DebugPrintDone;
                }
                );
                RegisterSignalServiceExtension(name: "debugDumpSemanticsTreeInInverseHitTestOrder", callback: () =>
                {
                    BindingDefaultClass.DebugDumpSemanticsTree(DebugSemanticsDumpOrder.InverseHitTest);
                    return PrintDefaultClass.DebugPrintDone;
                }
                );
            }

        }




        /// <Summary>
        /// Creates a [RenderView] object to be the root of the
        /// [RenderObject] rendering tree, and initializes it so that it
        /// will be rendered when the next frame is requested.
        ///
        /// Called automatically when the binding is created.
        /// </Summary>
        public virtual void InitRenderView()
        {

            RenderView = new RenderView(configuration: CreateViewConfiguration(), window: Window);
            RenderView.PrepareInitialFrame();
        }




        /// <Summary>
        /// Called when the system metrics change.
        ///
        /// See [Window.onMetricsChanged].
        /// </Summary>
        public virtual void HandleMetricsChanged()
        {

            RenderView.Configuration = CreateViewConfiguration();
            ScheduleForcedFrame();
        }




        /// <Summary>
        /// Called when the platform text scale factor changes.
        ///
        /// See [Window.onTextScaleFactorChanged].
        /// </Summary>
        public virtual void HandleTextScaleFactorChanged()
        {
        }




        /// <Summary>
        /// Called when the platform brightness changes.
        ///
        /// The current platform brightness can be queried from a Flutter binding or
        /// from a [MediaQuery] widget. The latter is preferred from widgets because
        /// it causes the widget to be automatically rebuilt when the brightness
        /// changes.
        ///
        /// {@tool snippet}
        /// Querying [Window.platformBrightness].
        ///
        /// ```dart
        /// final Brightness brightness = WidgetsBinding.instance.window.platformBrightness;
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        /// Querying [MediaQuery] directly. Preferred.
        ///
        /// ```dart
        /// final Brightness brightness = MediaQuery.platformBrightnessOf(context);
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        /// Querying [MediaQueryData].
        ///
        /// ```dart
        /// final MediaQueryData mediaQueryData = MediaQuery.of(context);
        /// final Brightness brightness = mediaQueryData.platformBrightness;
        /// ```
        /// {@end-tool}
        ///
        /// See [Window.onPlatformBrightnessChanged].
        /// </Summary>
        public virtual void HandlePlatformBrightnessChanged()
        {
        }




        /// <Summary>
        /// Returns a [ViewConfiguration] configured for the [RenderView] based on the
        /// current environment.
        ///
        /// This is called during construction and also in response to changes to the
        /// system metrics.
        ///
        /// Bindings can override this method to change what size or device pixel
        /// ratio the [RenderView] will use. For example, the testing framework uses
        /// this to force the display into 800x600 when a test is run on the device
        /// using `flutter run`.
        /// </Summary>
        public virtual FlutterSDK.Rendering.View.ViewConfiguration CreateViewConfiguration()
        {
            double devicePixelRatio = Window.DevicePixelRatio;
            return new ViewConfiguration(size: Window.PhysicalSize / devicePixelRatio, devicePixelRatio: devicePixelRatio);
        }




        /// <Summary>
        /// Creates a [MouseTracker] which manages state about currently connected
        /// mice, for hover notification.
        ///
        /// Used by testing framework to reinitialize the mouse tracker between tests.
        /// </Summary>
        public virtual void InitMouseTracker(FlutterSDK.Rendering.Mousetracking.MouseTracker tracker = default(FlutterSDK.Rendering.Mousetracking.MouseTracker))
        {
            _MouseTracker?.Dispose();
            _MouseTracker = tracker ?? new MouseTracker(PointerRouter, RenderView.HitTestMouseTrackers);
        }




        private void _HandleSemanticsEnabledChanged()
        {
            SetSemanticsEnabled(Window.SemanticsEnabled);
        }




        /// <Summary>
        /// Whether the render tree associated with this binding should produce a tree
        /// of [SemanticsNode] objects.
        /// </Summary>
        public virtual void SetSemanticsEnabled(bool enabled)
        {
            if (enabled)
            {
                _SemanticsHandle = (_SemanticsHandle == null ? _PipelineOwner.EnsureSemantics() : _SemanticsHandle);
            }
            else
            {
                _SemanticsHandle?.Dispose();
                _SemanticsHandle = null;
            }

        }




        private void _HandleSemanticsAction(int id, SemanticsAction action, ByteData args)
        {
            _PipelineOwner.SemanticsOwner?.PerformAction(id, action, args != null ? new StandardMessageCodec().DecodeMessage(args) : null);
        }




        private void _HandleSemanticsOwnerCreated()
        {
            RenderView.ScheduleInitialSemantics();
        }




        private void _HandleSemanticsOwnerDisposed()
        {
            RenderView.ClearSemantics();
        }




        private void _HandlePersistentFrameCallback(TimeSpan timeStamp)
        {
            DrawFrame();
            _MouseTracker.SchedulePostFrameCheck();
        }




        /// <Summary>
        /// Tell the framework to not send the first frames to the engine until there
        /// is a corresponding call to [allowFirstFrame].
        ///
        /// Call this to perform asynchronous initialization work before the first
        /// frame is rendered (which takes down the splash screen). The framework
        /// will still do all the work to produce frames, but those frames are never
        /// sent to the engine and will not appear on screen.
        ///
        /// Calling this has no effect after the first frame has been sent to the
        /// engine.
        /// </Summary>
        public virtual void DeferFirstFrame()
        {

            _FirstFrameDeferredCount += 1;
        }




        /// <Summary>
        /// Called after [deferFirstFrame] to tell the framework that it is ok to
        /// send the first frame to the engine now.
        ///
        /// For best performance, this method should only be called while the
        /// [schedulerPhase] is [SchedulerPhase.idle].
        ///
        /// This method may only be called once for each corresponding call
        /// to [deferFirstFrame].
        /// </Summary>
        public virtual void AllowFirstFrame()
        {

            _FirstFrameDeferredCount -= 1;
            if (!_FirstFrameSent) ScheduleWarmUpFrame();
        }




        /// <Summary>
        /// Call this to pretend that no frames have been sent to the engine yet.
        ///
        /// This is useful for tests that want to call [deferFirstFrame] and
        /// [allowFirstFrame] since those methods only have an effect if no frames
        /// have been sent to the engine yet.
        /// </Summary>
        public virtual void ResetFirstFrameSent()
        {
            _FirstFrameSent = false;
        }




        /// <Summary>
        /// Pump the rendering pipeline to generate a frame.
        ///
        /// This method is called by [handleDrawFrame], which itself is called
        /// automatically by the engine when it is time to lay out and paint a frame.
        ///
        /// Each frame consists of the following phases:
        ///
        /// 1. The animation phase: The [handleBeginFrame] method, which is registered
        /// with [Window.onBeginFrame], invokes all the transient frame callbacks
        /// registered with [scheduleFrameCallback], in registration order. This
        /// includes all the [Ticker] instances that are driving [AnimationController]
        /// objects, which means all of the active [Animation] objects tick at this
        /// point.
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
        /// 3. The layout phase: All the dirty [RenderObject]s in the system are laid
        /// out (see [RenderObject.performLayout]). See [RenderObject.markNeedsLayout]
        /// for further details on marking an object dirty for layout.
        ///
        /// 4. The compositing bits phase: The compositing bits on any dirty
        /// [RenderObject] objects are updated. See
        /// [RenderObject.markNeedsCompositingBitsUpdate].
        ///
        /// 5. The paint phase: All the dirty [RenderObject]s in the system are
        /// repainted (see [RenderObject.paint]). This generates the [Layer] tree. See
        /// [RenderObject.markNeedsPaint] for further details on marking an object
        /// dirty for paint.
        ///
        /// 6. The compositing phase: The layer tree is turned into a [Scene] and
        /// sent to the GPU.
        ///
        /// 7. The semantics phase: All the dirty [RenderObject]s in the system have
        /// their semantics updated (see [RenderObject.semanticsAnnotator]). This
        /// generates the [SemanticsNode] tree. See
        /// [RenderObject.markNeedsSemanticsUpdate] for further details on marking an
        /// object dirty for semantics.
        ///
        /// For more details on steps 3-7, see [PipelineOwner].
        ///
        /// 8. The finalization phase: After [drawFrame] returns, [handleDrawFrame]
        /// then invokes post-frame callbacks (registered with [addPostFrameCallback]).
        ///
        /// Some bindings (for example, the [WidgetsBinding]) add extra steps to this
        /// list (for example, see [WidgetsBinding.drawFrame]).
        /// </Summary>
        public virtual void DrawFrame()
        {

            PipelineOwner.FlushLayout();
            PipelineOwner.FlushCompositingBits();
            PipelineOwner.FlushPaint();
            if (SendFramesToEngine)
            {
                RenderView.CompositeFrame();
                PipelineOwner.FlushSemantics();
                _FirstFrameSent = true;
            }

        }




        public new Future<object> PerformReassemble()
    async
{
await base.PerformReassemble();
        Dart:developerDefaultClass.Timeline.StartSync("Dirty Render Tree", arguments:DebugDefaultClass.TimelineWhitelistArguments);
try {
RenderView.Reassemble();
}
finally {
Dart:developerDefaultClass.Timeline.FinishSync();
}

ScheduleWarmUpFrame();
await EndOfFrame;
}




public new void HitTest(FlutterSDK.Gestures.Hittest.HitTestResult result, FlutterBinding.UI.Offset position)
{

    RenderView.HitTest(result, position: position);
    base.HitTest(result, position);
}




private Future<object> _ForceRepaint()
{
    RenderObjectVisitor visitor = default(RenderObjectVisitor);
    visitor = (RenderObject child) =>
    {
        child.MarkNeedsPaint();
        child.VisitChildren(visitor);
    }
    ;
    Instance?.RenderView?.VisitChildren(visitor);
    return EndOfFrame;
}



}
public static class RendererBindingMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<IRendererBinding, RendererBinding> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRendererBinding, RendererBinding>();
    static RendererBinding GetOrCreate(IRendererBinding instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new RendererBinding();
            _table.Add(instance, value);
        }
        return (RendererBinding)value;
    }
    public static FlutterSDK.Rendering.Binding.RendererBinding InstanceProperty(this IRendererBinding instance) => GetOrCreate(instance).Instance;
    public static FlutterSDK.Rendering.Mousetracking.MouseTracker MouseTrackerProperty(this IRendererBinding instance) => GetOrCreate(instance).MouseTracker;
    public static FlutterSDK.Rendering.@object.PipelineOwner PipelineOwnerProperty(this IRendererBinding instance) => GetOrCreate(instance).PipelineOwner;
    public static FlutterSDK.Rendering.View.RenderView RenderViewProperty(this IRendererBinding instance) => GetOrCreate(instance).RenderView;
    public static bool SendFramesToEngineProperty(this IRendererBinding instance) => GetOrCreate(instance).SendFramesToEngine;
    public static void InitInstances(this IRendererBinding instance) => GetOrCreate(instance).InitInstances();
    public static void InitServiceExtensions(this IRendererBinding instance) => GetOrCreate(instance).InitServiceExtensions();
    public static void InitRenderView(this IRendererBinding instance) => GetOrCreate(instance).InitRenderView();
    public static void HandleMetricsChanged(this IRendererBinding instance) => GetOrCreate(instance).HandleMetricsChanged();
    public static void HandleTextScaleFactorChanged(this IRendererBinding instance) => GetOrCreate(instance).HandleTextScaleFactorChanged();
    public static void HandlePlatformBrightnessChanged(this IRendererBinding instance) => GetOrCreate(instance).HandlePlatformBrightnessChanged();
    public static FlutterSDK.Rendering.View.ViewConfiguration CreateViewConfiguration(this IRendererBinding instance) => GetOrCreate(instance).CreateViewConfiguration();
    public static void InitMouseTracker(this IRendererBinding instance, FlutterSDK.Rendering.Mousetracking.MouseTracker tracker = default(FlutterSDK.Rendering.Mousetracking.MouseTracker)) => GetOrCreate(instance).InitMouseTracker(tracker);
    public static void SetSemanticsEnabled(this IRendererBinding instance, bool enabled) => GetOrCreate(instance).SetSemanticsEnabled(enabled);
    public static void DeferFirstFrame(this IRendererBinding instance) => GetOrCreate(instance).DeferFirstFrame();
    public static void AllowFirstFrame(this IRendererBinding instance) => GetOrCreate(instance).AllowFirstFrame();
    public static void ResetFirstFrameSent(this IRendererBinding instance) => GetOrCreate(instance).ResetFirstFrameSent();
    public static void DrawFrame(this IRendererBinding instance) => GetOrCreate(instance).DrawFrame();
    public static Future<object> PerformReassemble(this IRendererBinding instance) => GetOrCreate(instance).PerformReassemble();
    public static void HitTest(this IRendererBinding instance, FlutterSDK.Gestures.Hittest.HitTestResult result, FlutterBinding.UI.Offset position) => GetOrCreate(instance).HitTest(result, position);
}


/// <Summary>
/// A concrete binding for applications that use the Rendering framework
/// directly. This is the glue that binds the framework to the Flutter engine.
///
/// You would only use this binding if you are writing to the
/// rendering layer directly. If you are writing to a higher-level
/// library, such as the Flutter Widgets library, then you would use
/// that layer's binding.
/// </Summary>
public class RenderingFlutterBinding : FlutterSDK.Foundation.Binding.BindingBase, IGestureBinding, IServicesBinding, ISchedulerBinding, ISemanticsBinding, IPaintingBinding, IRendererBinding
{
    #region constructors
    public RenderingFlutterBinding(FlutterSDK.Rendering.Box.RenderBox root = default(FlutterSDK.Rendering.Box.RenderBox))


RenderView.Child=root;
}


#endregion

#region fields
#endregion

#region methods
#endregion
}

}
