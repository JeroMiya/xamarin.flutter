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
namespace FlutterSDK.Rendering.Flow
{
    internal static class FlowDefaultClass
    {
    }

    /// <Summary>
    /// A delegate that controls the appearance of a flow layout.
    ///
    /// Flow layouts are optimized for moving children around the screen using
    /// transformation matrices. For optimal performance, construct the
    /// [FlowDelegate] with an [Animation] that ticks whenever the delegate wishes
    /// to change the transformation matrices for the children and avoid rebuilding
    /// the [Flow] widget itself every animation frame.
    ///
    /// See also:
    ///
    ///  * [Flow]
    ///  * [RenderFlow]
    /// </Summary>
    public interface IFlowDelegate
    {
        Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints);
        FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(int i, FlutterSDK.Rendering.Box.BoxConstraints constraints);
        void PaintChildren(FlutterSDK.Rendering.Flow.FlowPaintingContext context);
        bool ShouldRelayout(FlutterSDK.Rendering.Flow.FlowDelegate oldDelegate);
        bool ShouldRepaint(FlutterSDK.Rendering.Flow.FlowDelegate oldDelegate);
        string ToString();
    }


    public interface IFlowPaintingContext { }

    public class FlowPaintingContext
    {
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The size of the [i]th child.
        ///
        /// If [i] is negative or exceeds [childCount], returns null.
        /// </Summary>
        public virtual Size GetChildSize(int i)
        {
            return default(Size);
        }


        /// <Summary>
        /// Paint the [i]th child using the given transform.
        ///
        /// The child will be painted in a coordinate system that concatenates the
        /// container's coordinate system with the given transform. The origin of the
        /// parent's coordinate system is the upper left corner of the parent, with
        /// x increasing rightward and y increasing downward.
        ///
        /// The container will clip the children to its bounds.
        /// </Summary>
        public virtual void PaintChild(int i, Matrix4 transform = default(Matrix4), double opacity = 1.0)
        {
        }

    }
    public static class FlowPaintingContextMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IFlowPaintingContext, FlowPaintingContext> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IFlowPaintingContext, FlowPaintingContext>();
        static FlowPaintingContext GetOrCreate(IFlowPaintingContext instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new FlowPaintingContext();
                _table.Add(instance, value);
            }
            return (FlowPaintingContext)value;
        }
        public static Size SizeProperty(this IFlowPaintingContext instance) => GetOrCreate(instance).Size;
        public static int ChildCountProperty(this IFlowPaintingContext instance) => GetOrCreate(instance).ChildCount;
        public static Size GetChildSize(this IFlowPaintingContext instance, int i) => GetOrCreate(instance).GetChildSize(i);
        public static void PaintChild(this IFlowPaintingContext instance, int i, Matrix4 transform = default(Matrix4), double opacity = 1.0) => GetOrCreate(instance).PaintChild(i, transform, opacity);
    }


    /// <Summary>
    /// A delegate that controls the appearance of a flow layout.
    ///
    /// Flow layouts are optimized for moving children around the screen using
    /// transformation matrices. For optimal performance, construct the
    /// [FlowDelegate] with an [Animation] that ticks whenever the delegate wishes
    /// to change the transformation matrices for the children and avoid rebuilding
    /// the [Flow] widget itself every animation frame.
    ///
    /// See also:
    ///
    ///  * [Flow]
    ///  * [RenderFlow]
    /// </Summary>
    public class FlowDelegate
    {
        public FlowDelegate(FlutterSDK.Foundation.Changenotifier.Listenable repaint = default(FlutterSDK.Foundation.Changenotifier.Listenable))
        : base()
        {

        }
        internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Repaint { get; set; }

        /// <Summary>
        /// Override to control the size of the container for the children.
        ///
        /// By default, the flow will be as large as possible. If this function
        /// returns a size that does not respect the given constraints, the size will
        /// be adjusted to be as close to the returned size as possible while still
        /// respecting the constraints.
        ///
        /// If this function depends on information other than the given constraints,
        /// override [shouldRelayout] to indicate when when the container should
        /// relayout.
        /// </Summary>
        public virtual Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints) => constraints.Biggest;



        /// <Summary>
        /// Override to control the layout constraints given to each child.
        ///
        /// By default, the children will receive the given constraints, which are the
        /// constraints used to size the container. The children need
        /// not respect the given constraints, but they are required to respect the
        /// returned constraints. For example, the incoming constraints might require
        /// the container to have a width of exactly 100.0 and a height of exactly
        /// 100.0, but this function might give the children looser constraints that
        /// let them be larger or smaller than 100.0 by 100.0.
        ///
        /// If this function depends on information other than the given constraints,
        /// override [shouldRelayout] to indicate when when the container should
        /// relayout.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(int i, FlutterSDK.Rendering.Box.BoxConstraints constraints) => constraints;



        /// <Summary>
        /// Override to paint the children of the flow.
        ///
        /// Children can be painted in any order, but each child can be painted at
        /// most once. Although the container clips the children to its own bounds, it
        /// is more efficient to skip painting a child altogether rather than having
        /// it paint entirely outside the container's clip.
        ///
        /// To paint a child, call [FlowPaintingContext.paintChild] on the given
        /// [FlowPaintingContext] (the `context` argument). The given context is valid
        /// only within the scope of this function call and contains information (such
        /// as the size of the container) that is useful for picking transformation
        /// matrices for the children.
        ///
        /// If this function depends on information other than the given context,
        /// override [shouldRepaint] to indicate when when the container should
        /// relayout.
        /// </Summary>
        public virtual void PaintChildren(FlutterSDK.Rendering.Flow.FlowPaintingContext context)
        {
        }


        /// <Summary>
        /// Override this method to return true when the children need to be laid out.
        /// This should compare the fields of the current delegate and the given
        /// oldDelegate and return true if the fields are such that the layout would
        /// be different.
        /// </Summary>
        public virtual bool ShouldRelayout(FlutterSDK.Rendering.Flow.FlowDelegate oldDelegate) => false;



        /// <Summary>
        /// Override this method to return true when the children need to be
        /// repainted. This should compare the fields of the current delegate and the
        /// given oldDelegate and return true if the fields are such that
        /// paintChildren would act differently.
        ///
        /// The delegate can also trigger a repaint if the delegate provides the
        /// repaint animation argument to this object's constructor and that animation
        /// ticks. Triggering a repaint using this animation-based mechanism is more
        /// efficient than rebuilding the [Flow] widget to change its delegate.
        ///
        /// The flow container might repaint even if this function returns false, for
        /// example if layout triggers painting (e.g., if [shouldRelayout] returns
        /// true).
        /// </Summary>
        public virtual bool ShouldRepaint(FlutterSDK.Rendering.Flow.FlowDelegate oldDelegate)
        {
            return default(bool);
        }


    }


    /// <Summary>
    /// Parent data for use with [RenderFlow].
    ///
    /// The [offset] property is ignored by [RenderFlow] and is always set to
    /// [Offset.zero]. Children of a [RenderFlow] are positioned using a
    /// transformation matrix, which is private to the [RenderFlow]. To set the
    /// matrix, use the [FlowPaintingContext.paintChild] function from an override
    /// of the [FlowDelegate.paintChildren] function.
    /// </Summary>
    public class FlowParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        public FlowParentData()
        { }
        internal virtual Matrix4 _Transform { get; set; }
    }


    /// <Summary>
    /// Implements the flow layout algorithm.
    ///
    /// Flow layouts are optimized for repositioning children using transformation
    /// matrices.
    ///
    /// The flow container is sized independently from the children by the
    /// [FlowDelegate.getSize] function of the delegate. The children are then sized
    /// independently given the constraints from the
    /// [FlowDelegate.getConstraintsForChild] function.
    ///
    /// Rather than positioning the children during layout, the children are
    /// positioned using transformation matrices during the paint phase using the
    /// matrices from the [FlowDelegate.paintChildren] function. The children can be
    /// repositioned efficiently by simply repainting the flow.
    ///
    /// The most efficient way to trigger a repaint of the flow is to supply a
    /// repaint argument to the constructor of the [FlowDelegate]. The flow will
    /// listen to this animation and repaint whenever the animation ticks, avoiding
    /// both the build and layout phases of the pipeline.
    ///
    /// See also:
    ///
    ///  * [FlowDelegate]
    ///  * [RenderStack]
    /// </Summary>
    public class RenderFlow : FlutterSDK.Rendering.Box.RenderBox, IFlowPaintingContext, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Flow.FlowParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Flow.FlowParentData>
    {
        public RenderFlow(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Rendering.Flow.FlowDelegate @delegate = default(FlutterSDK.Rendering.Flow.FlowDelegate))
        : base()
        {

            AddAll(children);
        }


        internal virtual FlutterSDK.Rendering.Flow.FlowDelegate _Delegate { get; set; }
        internal virtual List<FlutterSDK.Rendering.Box.RenderBox> _RandomAccessChildren { get; set; }
        internal virtual List<int> _LastPaintOrder { get; set; }
        internal virtual FlutterSDK.Rendering.@object.PaintingContext _PaintingContext { get; set; }
        internal virtual FlutterBinding.UI.Offset _PaintingOffset { get; set; }
        public virtual FlutterSDK.Rendering.Flow.FlowDelegate @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            ParentData childParentData = child.ParentData;
            if (childParentData is FlowParentData) childParentData._Transform = null; else child.ParentData = new FlowParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            ParentData childParentData = child.ParentData;
            if (childParentData is FlowParentData) childParentData._Transform = null; else child.ParentData = new FlowParentData();
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _Delegate._Repaint?.AddListener(MarkNeedsPaint);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _Delegate._Repaint?.AddListener(MarkNeedsPaint);
        }




        public new void Detach()
        {
            _Delegate._Repaint?.RemoveListener(MarkNeedsPaint);
            base.Detach();
        }




        private Size _GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {

            return constraints.Constrain(_Delegate.GetSize(constraints));
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            double width = _GetSize(BoxConstraints.TightForFinite(height: height)).Width;
            if (width.IsFinite()) return width;
            return 0.0;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            double width = _GetSize(BoxConstraints.TightForFinite(height: height)).Width;
            if (width.IsFinite()) return width;
            return 0.0;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double height = _GetSize(BoxConstraints.TightForFinite(width: width)).Height;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            double height = _GetSize(BoxConstraints.TightForFinite(width: width)).Height;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            Size = _GetSize(constraints);
            int i = 0;
            _RandomAccessChildren.Clear();
            RenderBox child = FirstChild;
            while (child != null)
            {
                _RandomAccessChildren.Add(child);
                BoxConstraints innerConstraints = _Delegate.GetConstraintsForChild(i, constraints);
                child.Layout(innerConstraints, parentUsesSize: true);
                FlowParentData childParentData = child.ParentData as FlowParentData;
                childParentData.Offset = Dart.UiDefaultClass.Offset.Zero;
                child = childParentData.NextSibling;
                i += 1;
            }

        }




        public new Size GetChildSize(int i)
        {
            if (i < 0 || i >= _RandomAccessChildren.Count) return null;
            return _RandomAccessChildren[i].Size;
        }




        public new void PaintChild(int i, Matrix4 transform = default(Matrix4), double opacity = 1.0)
        {
            transform = (transform == null ? Matrix4.Identity() : transform);
            RenderBox child = _RandomAccessChildren[i];
            FlowParentData childParentData = child.ParentData as FlowParentData;

            _LastPaintOrder.Add(i);
            childParentData._Transform = transform;
            if (opacity == 0.0) return;
            void Painter(PaintingContext context, Offset offset)
            {
                context.PaintChild(child, offset);
            }

            if (opacity == 1.0)
            {
                _PaintingContext.PushTransform(NeedsCompositing, _PaintingOffset, transform, Painter);
            }
            else
            {
                _PaintingContext.PushOpacity(_PaintingOffset, Dart.UI.UiDefaultClass.Color.GetAlphaFromOpacity(opacity), (PaintingContext context, Offset offset) =>
                {
                    context.PushTransform(NeedsCompositing, offset, transform, Painter);
                }
                );
            }

        }




        private void _PaintWithDelegate(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            _LastPaintOrder.Clear();
            _PaintingContext = context;
            _PaintingOffset = offset;
            foreach (RenderBox child in _RandomAccessChildren)
            {
                FlowParentData childParentData = child.ParentData as FlowParentData;
                childParentData._Transform = null;
            }

            try
            {
                _Delegate.PaintChildren(this);
            }
            finally
            {
                _PaintingContext = null;
                _PaintingOffset = null;
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            context.PushClipRect(NeedsCompositing, offset, Dart.UI.UiDefaultClass.Offset.Zero & Size, _PaintWithDelegate);
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            List<RenderBox> children = GetChildrenAsList();
            for (int i = _LastPaintOrder.Count - 1; i >= 0; --i)
            {
                int childIndex = _LastPaintOrder[i];
                if (childIndex >= children.Count) continue;
                RenderBox child = children[childIndex];
                FlowParentData childParentData = child.ParentData as FlowParentData;
                Matrix4 transform = childParentData._Transform;
                if (transform == null) continue;
                bool absorbed = result.AddWithPaintTransform(transform: transform, position: position, hitTest: (BoxHitTestResult result, Offset position) =>
                {
                    return child.HitTest(result, position: position);
                }
                );
                if (absorbed) return true;
            }

            return false;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
        {
            FlowParentData childParentData = child.ParentData as FlowParentData;
            if (childParentData._Transform != null) transform.Multiply(childParentData._Transform);
            base.ApplyPaintTransform(child, transform);
        }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {
            FlowParentData childParentData = child.ParentData as FlowParentData;
            if (childParentData._Transform != null) transform.Multiply(childParentData._Transform);
            base.ApplyPaintTransform(child, transform);
        }



    }

}
