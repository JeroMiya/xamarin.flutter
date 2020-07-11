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
namespace FlutterSDK.Rendering.Slivermultiboxadaptor
{
    internal static class SlivermultiboxadaptorDefaultClass
    {
    }

    /// <Summary>
    /// A sliver with multiple box children.
    ///
    /// [RenderSliverMultiBoxAdaptor] is a base class for slivers that have multiple
    /// box children. The children are managed by a [RenderSliverBoxChildManager],
    /// which lets subclasses create children lazily during layout. Typically
    /// subclasses will create only those children that are actually needed to fill
    /// the [SliverConstraints.remainingPaintExtent].
    ///
    /// The contract for adding and removing children from this render object is
    /// more strict than for normal render objects:
    ///
    /// * Children can be removed except during a layout pass if they have already
    ///   been laid out during that layout pass.
    /// * Children cannot be added except during a call to [childManager], and
    ///   then only if there is no child corresponding to that index (or the child
    ///   child corresponding to that index was first removed).
    ///
    /// See also:
    ///
    ///  * [RenderSliverToBoxAdapter], which has a single box child.
    ///  * [RenderSliverList], which places its children in a linear
    ///    array.
    ///  * [RenderSliverFixedExtentList], which places its children in a linear
    ///    array with a fixed extent in the main axis.
    ///  * [RenderSliverGrid], which places its children in arbitrary positions.
    /// </Summary>
    public interface IRenderSliverMultiBoxAdaptor
    {
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        void AdoptChild(FlutterSDK.Rendering.@object.RenderObject child);
        void Insert(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox));
        void Move(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox));
        void Remove(FlutterSDK.Rendering.Box.RenderBox child);
        void RemoveAll();
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void Detach();
        void RedepthChildren();
        void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        bool AddInitialChild(int index = 0, double layoutOffset = 0.0);
        FlutterSDK.Rendering.Box.RenderBox InsertAndLayoutLeadingChild(FlutterSDK.Rendering.Box.BoxConstraints childConstraints, bool parentUsesSize = false);
        FlutterSDK.Rendering.Box.RenderBox InsertAndLayoutChild(FlutterSDK.Rendering.Box.BoxConstraints childConstraints, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox), bool parentUsesSize = false);
        void CollectGarbage(int leadingGarbage, int trailingGarbage);
        int IndexOf(FlutterSDK.Rendering.Box.RenderBox child);
        double PaintExtentOf(FlutterSDK.Rendering.Box.RenderBox child);
        bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child);
        double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        bool DebugAssertChildListIsNonEmptyAndContiguous();
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager ChildManager { get; }
        bool DebugChildIntegrityEnabled { get; set; }
    }


    public interface IKeepAliveParentDataMixin { }

    public class KeepAliveParentDataMixin : IParentData
    {
        public virtual bool KeepAlive { get; set; }
        public virtual bool KeptAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Called when the RenderObject is removed from the tree.
        /// </Summary>
        public virtual void Detach() { throw new NotImplementedException(); }


    }
    public static class KeepAliveParentDataMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IKeepAliveParentDataMixin, KeepAliveParentDataMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IKeepAliveParentDataMixin, KeepAliveParentDataMixin>();
        static KeepAliveParentDataMixin GetOrCreate(IKeepAliveParentDataMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new KeepAliveParentDataMixin();
                _table.Add(instance, value);
            }
            return (KeepAliveParentDataMixin)value;
        }
        public static bool KeepAliveProperty(this IKeepAliveParentDataMixin instance) => GetOrCreate(instance).KeepAlive;
        public static bool KeptAliveProperty(this IKeepAliveParentDataMixin instance) => GetOrCreate(instance).KeptAlive;
    }


    public interface IRenderSliverWithKeepAliveMixin { }

    public class RenderSliverWithKeepAliveMixin : IRenderSliver
    {

        /// <Summary>
        /// Alerts the developer that the child's parentData needs to be of type
        /// [KeepAliveParentDataMixin].
        /// </Summary>
        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }

        internal virtual FlutterSDK.Rendering.Sliver.SliverGeometry _Geometry { get; set; }
        public virtual FlutterSDK.Rendering.Sliver.SliverConstraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Geometry { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect SemanticBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect PaintBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CenterOffsetAdjustment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DebugResetSize() { throw new NotImplementedException(); }


        public new void DebugAssertDoesMeetConstraints() { throw new NotImplementedException(); }


        public new void PerformResize() { throw new NotImplementedException(); }


        /// <Summary>
        /// Determines the set of render objects located at the given position.
        ///
        /// Returns true if the given point is contained in this render object or one
        /// of its descendants. Adds any render objects that contain the point to the
        /// given hit test result.
        ///
        /// The caller is responsible for providing the position in the local
        /// coordinate space of the callee. The callee is responsible for checking
        /// whether the given position is within its bounds.
        ///
        /// Hit testing requires layout to be up-to-date but does not require painting
        /// to be up-to-date. That means a render object can rely upon [performLayout]
        /// having been called in [hitTest] but cannot rely upon [paint] having been
        /// called. For example, a render object might be a child of a [RenderOpacity]
        /// object, which calls [hitTest] on its children when its opacity is zero
        /// even through it does not [paint] its children.
        ///
        /// ## Coordinates for RenderSliver objects
        ///
        /// The `mainAxisPosition` is the distance in the [AxisDirection] (after
        /// applying the [GrowthDirection]) from the edge of the sliver's painted
        /// area. This can be an unusual direction, for example in the
        /// [AxisDirection.up] case this is a distance from the _bottom_ of the
        /// sliver's painted area.
        ///
        /// The `crossAxisPosition` is the distance in the other axis. If the cross
        /// axis is horizontal (i.e. the [SliverConstraints.axisDirection] is either
        /// [AxisDirection.down] or [AxisDirection.up]), then the `crossAxisPosition`
        /// is a distance from the left edge of the sliver. If the cross axis is
        /// vertical (i.e. the [SliverConstraints.axisDirection] is either
        /// [AxisDirection.right] or [AxisDirection.left]), then the
        /// `crossAxisPosition` is a distance from the top edge of the sliver.
        ///
        /// ## Implementing hit testing for slivers
        ///
        /// The most straight-forward way to implement hit testing for a new sliver
        /// render object is to override its [hitTestSelf] and [hitTestChildren]
        /// methods.
        /// </Summary>
        public virtual bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Override this method if this render object can be hit even if its
        /// children were not hit.
        ///
        /// Used by [hitTest]. If you override [hitTest] and do not call this
        /// function, then you don't need to implement this function.
        ///
        /// For a discussion of the semantics of the arguments, see [hitTest].
        /// </Summary>
        public virtual bool HitTestSelf(double mainAxisPosition = default(double), double crossAxisPosition = default(double)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Override this method to check whether any children are located at the
        /// given position.
        ///
        /// Typically children should be hit-tested in reverse paint order so that
        /// hit tests at locations where children overlap hit the child that is
        /// visually "on top" (i.e., paints later).
        ///
        /// Used by [hitTest]. If you override [hitTest] and do not call this
        /// function, then you don't need to implement this function.
        ///
        /// For a discussion of the semantics of the arguments, see [hitTest].
        /// </Summary>
        public virtual bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Computes the portion of the region from `from` to `to` that is visible,
        /// assuming that only the region from the [SliverConstraints.scrollOffset]
        /// that is [SliverConstraints.remainingPaintExtent] high is visible, and that
        /// the relationship between scroll offsets and paint offsets is linear.
        ///
        /// For example, if the constraints have a scroll offset of 100 and a
        /// remaining paint extent of 100, and the arguments to this method describe
        /// the region 50..150, then the returned value would be 50 (from scroll
        /// offset 100 to scroll offset 150).
        ///
        /// This method is not useful if there is not a 1:1 relationship between
        /// consumed scroll offset and consumed paint extent. For example, if the
        /// sliver always paints the same amount but consumes a scroll offset extent
        /// that is proportional to the [SliverConstraints.scrollOffset], then this
        /// function's results will not be consistent.
        /// </Summary>
        public virtual double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Computes the portion of the region from `from` to `to` that is within
        /// the cache extent of the viewport, assuming that only the region from the
        /// [SliverConstraints.cacheOrigin] that is
        /// [SliverConstraints.remainingCacheExtent] high is visible, and that
        /// the relationship between scroll offsets and paint offsets is linear.
        ///
        /// This method is not useful if there is not a 1:1 relationship between
        /// consumed scroll offset and consumed cache extent.
        /// </Summary>
        public virtual double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the distance from the leading _visible_ edge of the sliver to the
        /// side of the given child closest to that edge.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the top
        /// of the visible portion of the sliver to the top of the child. On the other
        /// hand, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.up], then this is the distance from the bottom
        /// of the visible portion of the sliver to the bottom of the child. In both
        /// cases, this is the direction of increasing
        /// [SliverConstraints.scrollOffset] and
        /// [SliverLogicalParentData.layoutOffset].
        ///
        /// For children that are [RenderSliver]s, the leading edge of the _child_
        /// will be the leading _visible_ edge of the child, not the part of the child
        /// that would locally be a scroll offset 0.0. For children that are not
        /// [RenderSliver]s, for example a [RenderBox] child, it's the actual distance
        /// to the edge of the box, since those boxes do not know how to handle being
        /// scrolled.
        ///
        /// This method differs from [childScrollOffset] in that
        /// [childMainAxisPosition] gives the distance from the leading _visible_ edge
        /// of the sliver whereas [childScrollOffset] gives the distance from the
        /// sliver's zero scroll offset.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the distance along the cross axis from the zero of the cross axis
        /// in this sliver's [paint] coordinate space to the nearest side of the given
        /// child.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the left
        /// of the sliver to the left of the child. Similarly, if the [constraints]
        /// describe this sliver as having an axis direction of [AxisDirection.up],
        /// then this is value is the same. If the axis direction is
        /// [AxisDirection.left] or [AxisDirection.right], then it is the distance
        /// from the top of the sliver to the top of the child.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the scroll offset for the leading edge of the given child.
        ///
        /// The `child` must be a child of this sliver.
        ///
        /// This method differs from [childMainAxisPosition] in that
        /// [childMainAxisPosition] gives the distance from the leading _visible_ edge
        /// of the sliver whereas [childScrollOffset] gives the distance from sliver's
        /// zero scroll offset.
        /// </Summary>
        public virtual double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }


        /// <Summary>
        /// This returns a [Size] with dimensions relative to the leading edge of the
        /// sliver, specifically the same offset that is given to the [paint] method.
        /// This means that the dimensions may be negative.
        ///
        /// This is only valid after [layout] has completed.
        ///
        /// See also:
        ///
        ///  * [getAbsoluteSize], which returns absolute size.
        /// </Summary>
        public virtual Size GetAbsoluteSizeRelativeToOrigin() { throw new NotImplementedException(); }


        /// <Summary>
        /// This returns the absolute [Size] of the sliver.
        ///
        /// The dimensions are always positive and calling this is only valid after
        /// [layout] has completed.
        ///
        /// See also:
        ///
        ///  * [getAbsoluteSizeRelativeToOrigin], which returns the size relative to
        ///    the leading edge of the sliver.
        /// </Summary>
        public virtual Size GetAbsoluteSize() { throw new NotImplementedException(); }


        private void _DebugDrawArrow(Canvas canvas, SKPaint paint, FlutterBinding.UI.Offset p0, FlutterBinding.UI.Offset p1, FlutterSDK.Rendering.Sliver.GrowthDirection direction) { throw new NotImplementedException(); }


        public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

    }
    public static class RenderSliverWithKeepAliveMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverWithKeepAliveMixin, RenderSliverWithKeepAliveMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverWithKeepAliveMixin, RenderSliverWithKeepAliveMixin>();
        static RenderSliverWithKeepAliveMixin GetOrCreate(IRenderSliverWithKeepAliveMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderSliverWithKeepAliveMixin();
                _table.Add(instance, value);
            }
            return (RenderSliverWithKeepAliveMixin)value;
        }
        public static void SetupParentData(this IRenderSliverWithKeepAliveMixin instance, FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).SetupParentData(child);
    }


    public interface IRenderSliverBoxChildManager { }

    public class RenderSliverBoxChildManager
    {
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Called during layout when a new child is needed. The child should be
        /// inserted into the child list in the appropriate position, after the
        /// `after` child (at the start of the list if `after` is null). Its index and
        /// scroll offsets will automatically be set appropriately.
        ///
        /// The `index` argument gives the index of the child to show. It is possible
        /// for negative indices to be requested. For example: if the user scrolls
        /// from child 0 to child 10, and then those children get much smaller, and
        /// then the user scrolls back up again, this method will eventually be asked
        /// to produce a child for index -1.
        ///
        /// If no child corresponds to `index`, then do nothing.
        ///
        /// Which child is indicated by index zero depends on the [GrowthDirection]
        /// specified in the [RenderSliverMultiBoxAdaptor.constraints]. For example
        /// if the children are the alphabet, then if
        /// [SliverConstraints.growthDirection] is [GrowthDirection.forward] then
        /// index zero is A, and index 25 is Z. On the other hand if
        /// [SliverConstraints.growthDirection] is [GrowthDirection.reverse]
        /// then index zero is Z, and index 25 is A.
        ///
        /// During a call to [createChild] it is valid to remove other children from
        /// the [RenderSliverMultiBoxAdaptor] object if they were not created during
        /// this frame and have not yet been updated during this frame. It is not
        /// valid to add any other children to this render object.
        ///
        /// If this method does not create a child for a given `index` greater than or
        /// equal to zero, then [computeMaxScrollOffset] must be able to return a
        /// precise value.
        /// </Summary>
        public virtual void CreateChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Remove the given child from the child list.
        ///
        /// Called by [RenderSliverMultiBoxAdaptor.collectGarbage], which itself is
        /// called from [RenderSliverMultiBoxAdaptor.performLayout].
        ///
        /// The index of the given child can be obtained using the
        /// [RenderSliverMultiBoxAdaptor.indexOf] method, which reads it from the
        /// [SliverMultiBoxAdaptorParentData.index] field of the child's
        /// [RenderObject.parentData].
        /// </Summary>
        public virtual void RemoveChild(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called to estimate the total scrollable extents of this object.
        ///
        /// Must return the total distance from the start of the child with the
        /// earliest possible index to the end of the child with the last possible
        /// index.
        /// </Summary>
        public virtual double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex = default(int), int lastIndex = default(int), double leadingScrollOffset = default(double), double trailingScrollOffset = default(double)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called during [RenderSliverMultiBoxAdaptor.adoptChild] or
        /// [RenderSliverMultiBoxAdaptor.move].
        ///
        /// Subclasses must ensure that the [SliverMultiBoxAdaptorParentData.index]
        /// field of the child's [RenderObject.parentData] accurately reflects the
        /// child's index in the child list after this function returns.
        /// </Summary>
        public virtual void DidAdoptChild(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called during layout to indicate whether this object provided insufficient
        /// children for the [RenderSliverMultiBoxAdaptor] to fill the
        /// [SliverConstraints.remainingPaintExtent].
        ///
        /// Typically called unconditionally at the start of layout with false and
        /// then later called with true when the [RenderSliverMultiBoxAdaptor]
        /// fails to create a child required to fill the
        /// [SliverConstraints.remainingPaintExtent].
        ///
        /// Useful for subclasses to determine whether newly added children could
        /// affect the visible contents of the [RenderSliverMultiBoxAdaptor].
        /// </Summary>
        public virtual void SetDidUnderflow(bool value) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called at the beginning of layout to indicate that layout is about to
        /// occur.
        /// </Summary>
        public virtual void DidStartLayout() { throw new NotImplementedException(); }


        /// <Summary>
        /// Called at the end of layout to indicate that layout is now complete.
        /// </Summary>
        public virtual void DidFinishLayout() { throw new NotImplementedException(); }


        /// <Summary>
        /// In debug mode, asserts that this manager is not expecting any
        /// modifications to the [RenderSliverMultiBoxAdaptor]'s child list.
        ///
        /// This function always returns true.
        ///
        /// The manager is not required to track whether it is expecting modifications
        /// to the [RenderSliverMultiBoxAdaptor]'s child list and can simply return
        /// true without making any assertions.
        /// </Summary>
        public virtual bool DebugAssertChildListLocked() { throw new NotImplementedException(); }

    }
    public static class RenderSliverBoxChildManagerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverBoxChildManager, RenderSliverBoxChildManager> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverBoxChildManager, RenderSliverBoxChildManager>();
        static RenderSliverBoxChildManager GetOrCreate(IRenderSliverBoxChildManager instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderSliverBoxChildManager();
                _table.Add(instance, value);
            }
            return (RenderSliverBoxChildManager)value;
        }
        public static int ChildCountProperty(this IRenderSliverBoxChildManager instance) => GetOrCreate(instance).ChildCount;
        public static void CreateChild(this IRenderSliverBoxChildManager instance, int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) => GetOrCreate(instance).CreateChild(index, after);
        public static void RemoveChild(this IRenderSliverBoxChildManager instance, FlutterSDK.Rendering.Box.RenderBox child) => GetOrCreate(instance).RemoveChild(child);
        public static double EstimateMaxScrollOffset(this IRenderSliverBoxChildManager instance, FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex = default(int), int lastIndex = default(int), double leadingScrollOffset = default(double), double trailingScrollOffset = default(double)) => GetOrCreate(instance).EstimateMaxScrollOffset(constraints, firstIndex, lastIndex, leadingScrollOffset, trailingScrollOffset);
        public static void DidAdoptChild(this IRenderSliverBoxChildManager instance, FlutterSDK.Rendering.Box.RenderBox child) => GetOrCreate(instance).DidAdoptChild(child);
        public static void SetDidUnderflow(this IRenderSliverBoxChildManager instance, bool value) => GetOrCreate(instance).SetDidUnderflow(value);
        public static void DidStartLayout(this IRenderSliverBoxChildManager instance) => GetOrCreate(instance).DidStartLayout();
        public static void DidFinishLayout(this IRenderSliverBoxChildManager instance) => GetOrCreate(instance).DidFinishLayout();
        public static bool DebugAssertChildListLocked(this IRenderSliverBoxChildManager instance) => GetOrCreate(instance).DebugAssertChildListLocked();
    }


    /// <Summary>
    /// Parent data structure used by [RenderSliverMultiBoxAdaptor].
    /// </Summary>
    public class SliverMultiBoxAdaptorParentData : FlutterSDK.Rendering.Sliver.SliverLogicalParentData, IContainerParentDataMixin<FlutterSDK.Rendering.Box.RenderBox>, IKeepAliveParentDataMixin
    {
        #region constructors
        public SliverMultiBoxAdaptorParentData()
        { }
        #endregion

        #region fields
        public virtual int Index { get; set; }
        internal virtual bool _KeptAlive { get; set; }
        public virtual bool KeptAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// A sliver with multiple box children.
    ///
    /// [RenderSliverMultiBoxAdaptor] is a base class for slivers that have multiple
    /// box children. The children are managed by a [RenderSliverBoxChildManager],
    /// which lets subclasses create children lazily during layout. Typically
    /// subclasses will create only those children that are actually needed to fill
    /// the [SliverConstraints.remainingPaintExtent].
    ///
    /// The contract for adding and removing children from this render object is
    /// more strict than for normal render objects:
    ///
    /// * Children can be removed except during a layout pass if they have already
    ///   been laid out during that layout pass.
    /// * Children cannot be added except during a call to [childManager], and
    ///   then only if there is no child corresponding to that index (or the child
    ///   child corresponding to that index was first removed).
    ///
    /// See also:
    ///
    ///  * [RenderSliverToBoxAdapter], which has a single box child.
    ///  * [RenderSliverList], which places its children in a linear
    ///    array.
    ///  * [RenderSliverFixedExtentList], which places its children in a linear
    ///    array with a fixed extent in the main axis.
    ///  * [RenderSliverGrid], which places its children in arbitrary positions.
    /// </Summary>
    public class RenderSliverMultiBoxAdaptor : FlutterSDK.Rendering.Sliver.RenderSliver, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Slivermultiboxadaptor.SliverMultiBoxAdaptorParentData>, IRenderSliverHelpers, IRenderSliverWithKeepAliveMixin
    {
        #region constructors
        public RenderSliverMultiBoxAdaptor(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager childManager = default(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager _ChildManager { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Rendering.Box.RenderBox> _KeepAliveBucket { get; set; }
        internal virtual List<FlutterSDK.Rendering.Box.RenderBox> _DebugDanglingKeepAlives { get; set; }
        internal virtual bool _DebugChildIntegrityEnabled { get; set; }
        public virtual FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager ChildManager { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugChildIntegrityEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void AdoptChild(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }
        public new void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child) { throw new NotImplementedException(); }


        private bool _DebugAssertChildListLocked() { throw new NotImplementedException(); }


        /// <Summary>
        /// Verify that the child list index is in strictly increasing order.
        ///
        /// This has no effect in release builds.
        /// </Summary>
        private bool _DebugVerifyChildOrder() { throw new NotImplementedException(); }


        public new void Insert(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) { throw new NotImplementedException(); }


        public new void Move(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) { throw new NotImplementedException(); }


        public new void Remove(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        public new void RemoveAll() { throw new NotImplementedException(); }


        private void _CreateOrObtainChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) { throw new NotImplementedException(); }


        private void _DestroyOrCacheChild(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void RedepthChildren() { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called during layout to create and add the child with the given index and
        /// scroll offset.
        ///
        /// Calls [RenderSliverBoxChildManager.createChild] to actually create and add
        /// the child if necessary. The child may instead be obtained from a cache;
        /// see [SliverMultiBoxAdaptorParentData.keepAlive].
        ///
        /// Returns false if there was no cached child and `createChild` did not add
        /// any child, otherwise returns true.
        ///
        /// Does not layout the new child.
        ///
        /// When this is called, there are no visible children, so no children can be
        /// removed during the call to `createChild`. No child should be added during
        /// that call either, except for the one that is created and returned by
        /// `createChild`.
        /// </Summary>
        public virtual bool AddInitialChild(int index = 0, double layoutOffset = 0.0) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called during layout to create, add, and layout the child before
        /// [firstChild].
        ///
        /// Calls [RenderSliverBoxChildManager.createChild] to actually create and add
        /// the child if necessary. The child may instead be obtained from a cache;
        /// see [SliverMultiBoxAdaptorParentData.keepAlive].
        ///
        /// Returns the new child or null if no child was obtained.
        ///
        /// The child that was previously the first child, as well as any subsequent
        /// children, may be removed by this call if they have not yet been laid out
        /// during this layout pass. No child should be added during that call except
        /// for the one that is created and returned by `createChild`.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.RenderBox InsertAndLayoutLeadingChild(FlutterSDK.Rendering.Box.BoxConstraints childConstraints, bool parentUsesSize = false) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called during layout to create, add, and layout the child after
        /// the given child.
        ///
        /// Calls [RenderSliverBoxChildManager.createChild] to actually create and add
        /// the child if necessary. The child may instead be obtained from a cache;
        /// see [SliverMultiBoxAdaptorParentData.keepAlive].
        ///
        /// Returns the new child. It is the responsibility of the caller to configure
        /// the child's scroll offset.
        ///
        /// Children after the `after` child may be removed in the process. Only the
        /// new child may be added.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.RenderBox InsertAndLayoutChild(FlutterSDK.Rendering.Box.BoxConstraints childConstraints, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox), bool parentUsesSize = false) { throw new NotImplementedException(); }


        /// <Summary>
        /// Called after layout with the number of children that can be garbage
        /// collected at the head and tail of the child list.
        ///
        /// Children whose [SliverMultiBoxAdaptorParentData.keepAlive] property is
        /// set to true will be removed to a cache instead of being dropped.
        ///
        /// This method also collects any children that were previously kept alive but
        /// are now no longer necessary. As such, it should be called every time
        /// [performLayout] is run, even if the arguments are both zero.
        /// </Summary>
        public virtual void CollectGarbage(int leadingGarbage, int trailingGarbage) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the index of the given child, as given by the
        /// [SliverMultiBoxAdaptorParentData.index] field of the child's [parentData].
        /// </Summary>
        public virtual int IndexOf(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the dimension of the given child in the main axis, as given by the
        /// child's [RenderBox.size] property. This is only valid after layout.
        /// </Summary>
        public virtual double PaintExtentOf(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) { throw new NotImplementedException(); }


        public new double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }
        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        /// <Summary>
        /// Asserts that the reified child list is not empty and has a contiguous
        /// sequence of indices.
        ///
        /// Always returns true.
        /// </Summary>
        public virtual bool DebugAssertChildListIsNonEmptyAndContiguous() { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }

        #endregion
    }

}
