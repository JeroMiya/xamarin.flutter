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
namespace FlutterSDK.Rendering.Viewport
{
    internal static class ViewportDefaultClass
    {
    }

    /// <Summary>
    /// An interface for render objects that are bigger on the inside.
    ///
    /// Some render objects, such as [RenderViewport], present a portion of their
    /// content, which can be controlled by a [ViewportOffset]. This interface lets
    /// the framework recognize such render objects and interact with them without
    /// having specific knowledge of all the various types of viewports.
    /// </Summary>
    public interface IRenderAbstractViewport
    {
        FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object);
        FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect));
        double DefaultCacheExtent { get; }
    }


    /// <Summary>
    /// A base class for render objects that are bigger on the inside.
    ///
    /// This render object provides the shared code for render objects that host
    /// [RenderSliver] render objects inside a [RenderBox]. The viewport establishes
    /// an [axisDirection], which orients the sliver's coordinate system, which is
    /// based on scroll offsets rather than Cartesian coordinates.
    ///
    /// The viewport also listens to an [offset], which determines the
    /// [SliverConstraints.scrollOffset] input to the sliver layout protocol.
    ///
    /// Subclasses typically override [performLayout] and call
    /// [layoutChildSequence], perhaps multiple times.
    ///
    /// See also:
    ///
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderSliverToBoxAdapter], which allows a [RenderBox] object to be
    ///    placed inside a [RenderSliver] (the opposite of this class).
    /// </Summary>
    public interface IRenderViewportBase<ParentDataClass>
    {
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void Detach();
        bool DebugThrowIfNotCheckingIntrinsics();
        double ComputeMinIntrinsicWidth(double height);
        double ComputeMaxIntrinsicWidth(double height);
        double ComputeMinIntrinsicHeight(double width);
        double ComputeMaxIntrinsicHeight(double width);
        double LayoutChildSequence(FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver), double scrollOffset = default(double), double overlap = default(double), double layoutOffset = default(double), double remainingPaintExtent = default(double), double mainAxisExtent = default(double), double crossAxisExtent = default(double), FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection), Func<RenderSliver, RenderSliver> advance = default(Func<RenderSliver, RenderSliver>), double remainingCacheExtent = default(double), double cacheOrigin = default(double));
        Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.Sliver.RenderSliver child);
        Rect DescribeSemanticsClip(FlutterSDK.Rendering.Sliver.RenderSliver child);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
        FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect));
        Offset ComputeAbsolutePaintOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry);
        void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection);
        Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child);
        double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild);
        double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child);
        double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition);
        string LabelForChild(int index);
        void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        Rect ShowInViewport(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Rendering.Viewport.RenderAbstractViewport viewport = default(FlutterSDK.Rendering.Viewport.RenderAbstractViewport), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get; set; }
        FlutterSDK.Painting.Basictypes.Axis Axis { get; }
        FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }
        double CacheExtent { get; set; }
        FlutterSDK.Rendering.Viewport.CacheExtentStyle CacheExtentStyle { get; set; }
        bool IsRepaintBoundary { get; }
        bool HasVisualOverflow { get; }
        int IndexOfFirstChild { get; }
        Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get; }
        Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get; }
    }


    /// <Summary>
    /// An interface for render objects that are bigger on the inside.
    ///
    /// Some render objects, such as [RenderViewport], present a portion of their
    /// content, which can be controlled by a [ViewportOffset]. This interface lets
    /// the framework recognize such render objects and interact with them without
    /// having specific knowledge of all the various types of viewports.
    /// </Summary>
    public class RenderAbstractViewport : FlutterSDK.Rendering.@object.RenderObject
    {
        #region constructors
        internal RenderAbstractViewport()
        {
            null;

#endregion

            #region fields
        public virtual double DefaultCacheExtent { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Returns the [RenderAbstractViewport] that most tightly encloses the given
        /// render object.
        ///
        /// If the object does not have a [RenderAbstractViewport] as an ancestor,
        /// this function returns null.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object)
        {
            while (object != null)
            {
                if (object is RenderAbstractViewport) return object;
                object= object.Parent as RenderObject;
            }

            return null;
        }




        /// <Summary>
        /// Returns the offset that would be needed to reveal the `target`
        /// [RenderObject].
        ///
        /// The optional `rect` parameter describes which area of that `target` object
        /// should be revealed in the viewport. If `rect` is null, the entire
        /// `target` [RenderObject] (as defined by its [RenderObject.paintBounds])
        /// will be revealed. If `rect` is provided it has to be given in the
        /// coordinate system of the `target` object.
        ///
        /// The `alignment` argument describes where the target should be positioned
        /// after applying the returned offset. If `alignment` is 0.0, the child must
        /// be positioned as close to the leading edge of the viewport as possible. If
        /// `alignment` is 1.0, the child must be positioned as close to the trailing
        /// edge of the viewport as possible. If `alignment` is 0.5, the child must be
        /// positioned as close to the center of the viewport as possible.
        ///
        /// The `target` might not be a direct child of this viewport but it must be a
        /// descendant of the viewport. Other viewports in between this viewport and
        /// the `target` will not be adjusted.
        ///
        /// This method assumes that the content of the viewport moves linearly, i.e.
        /// when the offset of the viewport is changed by x then `target` also moves
        /// by x within the viewport.
        ///
        /// See also:
        ///
        ///  * [RevealedOffset], which describes the return value of this method.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect))
        {
            return default(RevealedOffset);
        }

        #endregion
    }


    /// <Summary>
    /// Return value for [RenderAbstractViewport.getOffsetToReveal].
    ///
    /// It indicates the [offset] required to reveal an element in a viewport and
    /// the [rect] position said element would have in the viewport at that
    /// [offset].
    /// </Summary>
    public class RevealedOffset
    {
        #region constructors
        public RevealedOffset(double offset = default(double), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect))
        : base()
        {
            this.Offset = offset;
            this.Rect = rect;
        }
        #endregion

        #region fields
        public virtual double Offset { get; set; }
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// A base class for render objects that are bigger on the inside.
    ///
    /// This render object provides the shared code for render objects that host
    /// [RenderSliver] render objects inside a [RenderBox]. The viewport establishes
    /// an [axisDirection], which orients the sliver's coordinate system, which is
    /// based on scroll offsets rather than Cartesian coordinates.
    ///
    /// The viewport also listens to an [offset], which determines the
    /// [SliverConstraints.scrollOffset] input to the sliver layout protocol.
    ///
    /// Subclasses typically override [performLayout] and call
    /// [layoutChildSequence], perhaps multiple times.
    ///
    /// See also:
    ///
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderSliverToBoxAdapter], which allows a [RenderBox] object to be
    ///    placed inside a [RenderSliver] (the opposite of this class).
    /// </Summary>
    public class RenderViewportBase<ParentDataClass> : FlutterSDK.Rendering.Box.RenderBox, IRenderAbstractViewport, IContainerRenderObjectMixin<FlutterSDK.Rendering.Sliver.RenderSliver, ParentDataClass>
    {
        #region constructors
        public RenderViewportBase(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double cacheExtent = default(double), FlutterSDK.Rendering.Viewport.CacheExtentStyle cacheExtentStyle = default(FlutterSDK.Rendering.Viewport.CacheExtentStyle))
        : base()
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Basictypes.AxisDirection _AxisDirection { get; set; }
        internal virtual FlutterSDK.Painting.Basictypes.AxisDirection _CrossAxisDirection { get; set; }
        internal virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset _Offset { get; set; }
        internal virtual double _CacheExtent { get; set; }
        internal virtual double _CalculatedCacheExtent { get; set; }
        internal virtual FlutterSDK.Rendering.Viewport.CacheExtentStyle _CacheExtentStyle { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CacheExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewport.CacheExtentStyle CacheExtentStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexOfFirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.AddTagForChildren(ViewportDefaultClass.RenderViewport.UseTwoPaneSemantics);
        }




        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            ChildrenInPaintOrder.Where((RenderSliver sliver) => =>sliver.Geometry.Visible || sliver.Geometry.CacheExtent > 0.0).ForEach(visitor);
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _Offset.AddListener(MarkNeedsLayout);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _Offset.AddListener(MarkNeedsLayout);
        }




        public new void Detach()
        {
            _Offset.RemoveListener(MarkNeedsLayout);
            base.Detach();
        }




        /// <Summary>
        /// Throws an exception saying that the object does not support returning
        /// intrinsic dimensions if, in checked mode, we are not in the
        /// [RenderObject.debugCheckingIntrinsics] mode.
        ///
        /// This is used by [computeMinIntrinsicWidth] et al because viewports do not
        /// generally support returning intrinsic dimensions. See the discussion at
        /// [computeMinIntrinsicWidth].
        /// </Summary>
        public virtual bool DebugThrowIfNotCheckingIntrinsics()
        {

            return true;
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {

            return 0.0;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {

            return 0.0;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {

            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {

            return 0.0;
        }




        /// <Summary>
        /// Determines the size and position of some of the children of the viewport.
        ///
        /// This function is the workhorse of `performLayout` implementations in
        /// subclasses.
        ///
        /// Layout starts with `child`, proceeds according to the `advance` callback,
        /// and stops once `advance` returns null.
        ///
        ///  * `scrollOffset` is the [SliverConstraints.scrollOffset] to pass the
        ///    first child. The scroll offset is adjusted by
        ///    [SliverGeometry.scrollExtent] for subsequent children.
        ///  * `overlap` is the [SliverConstraints.overlap] to pass the first child.
        ///    The overlay is adjusted by the [SliverGeometry.paintOrigin] and
        ///    [SliverGeometry.paintExtent] for subsequent children.
        ///  * `layoutOffset` is the layout offset at which to place the first child.
        ///    The layout offset is updated by the [SliverGeometry.layoutExtent] for
        ///    subsequent children.
        ///  * `remainingPaintExtent` is [SliverConstraints.remainingPaintExtent] to
        ///    pass the first child. The remaining paint extent is updated by the
        ///    [SliverGeometry.layoutExtent] for subsequent children.
        ///  * `mainAxisExtent` is the [SliverConstraints.viewportMainAxisExtent] to
        ///    pass to each child.
        ///  * `crossAxisExtent` is the [SliverConstraints.crossAxisExtent] to pass to
        ///    each child.
        ///  * `growthDirection` is the [SliverConstraints.growthDirection] to pass to
        ///    each child.
        ///
        /// Returns the first non-zero [SliverGeometry.scrollOffsetCorrection]
        /// encountered, if any. Otherwise returns 0.0. Typical callers will call this
        /// function repeatedly until it returns 0.0.
        /// </Summary>
        public virtual double LayoutChildSequence(FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver), double scrollOffset = default(double), double overlap = default(double), double layoutOffset = default(double), double remainingPaintExtent = default(double), double mainAxisExtent = default(double), double crossAxisExtent = default(double), FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection), Func<RenderSliver, RenderSliver> advance = default(Func<RenderSliver, RenderSliver>), double remainingCacheExtent = default(double), double cacheOrigin = default(double))
        {


            double initialLayoutOffset = layoutOffset;
            ScrollDirection adjustedUserScrollDirection = SliverDefaultClass.ApplyGrowthDirectionToScrollDirection(Offset.UserScrollDirection, growthDirection);

            double maxPaintOffset = layoutOffset + overlap;
            double precedingScrollExtent = 0.0;
            while (child != null)
            {
                double sliverScrollOffset = scrollOffset <= 0.0 ? 0.0 : scrollOffset;
                double correctedCacheOrigin = Math.Dart:mathDefaultClass.Max(cacheOrigin, -sliverScrollOffset);
                double cacheExtentCorrection = cacheOrigin - correctedCacheOrigin;




                child.Layout(new SliverConstraints(axisDirection: AxisDirection, growthDirection: growthDirection, userScrollDirection: adjustedUserScrollDirection, scrollOffset: sliverScrollOffset, precedingScrollExtent: precedingScrollExtent, overlap: maxPaintOffset - layoutOffset, remainingPaintExtent: Math.Dart:mathDefaultClass.Max(0.0, remainingPaintExtent - layoutOffset + initialLayoutOffset), crossAxisExtent: crossAxisExtent, crossAxisDirection: CrossAxisDirection, viewportMainAxisExtent: mainAxisExtent, remainingCacheExtent: Math.Dart:mathDefaultClass.Max(0.0, remainingCacheExtent + cacheExtentCorrection), cacheOrigin: correctedCacheOrigin), parentUsesSize: true);
                SliverGeometry childLayoutGeometry = child.Geometry;

                if (childLayoutGeometry.ScrollOffsetCorrection != null) return childLayoutGeometry.ScrollOffsetCorrection;
                double effectiveLayoutOffset = layoutOffset + childLayoutGeometry.PaintOrigin;
                if (childLayoutGeometry.Visible || scrollOffset > 0)
                {
                    UpdateChildLayoutOffset(child, effectiveLayoutOffset, growthDirection);
                }
                else
                {
                    UpdateChildLayoutOffset(child, -scrollOffset + initialLayoutOffset, growthDirection);
                }

                maxPaintOffset = Math.Dart:mathDefaultClass.Max(effectiveLayoutOffset + childLayoutGeometry.PaintExtent, maxPaintOffset);
                scrollOffset -= childLayoutGeometry.ScrollExtent;
                precedingScrollExtent += childLayoutGeometry.ScrollExtent;
                layoutOffset += childLayoutGeometry.LayoutExtent;
                if (childLayoutGeometry.CacheExtent != 0.0)
                {
                    remainingCacheExtent -= childLayoutGeometry.CacheExtent - cacheExtentCorrection;
                    cacheOrigin = Math.Dart:mathDefaultClass.Min(correctedCacheOrigin + childLayoutGeometry.CacheExtent, 0.0);
                }

                UpdateOutOfBandData(growthDirection, childLayoutGeometry);
                child = advance(child);
            }

            return 0.0;
        }




        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {
            Rect viewportClip = Dart:uiDefaultClass.Offset.Zero & Size;
            if (child.Constraints.Overlap == 0 || !child.Constraints.ViewportMainAxisExtent.IsFinite())
            {
                return viewportClip;
            }

            double left = viewportClip.Left;
            double right = viewportClip.Right;
            double top = viewportClip.Top;
            double bottom = viewportClip.Bottom;
            double startOfOverlap = child.Constraints.ViewportMainAxisExtent - child.Constraints.RemainingPaintExtent;
            double overlapCorrection = startOfOverlap + child.Constraints.Overlap;
            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(AxisDirection, child.Constraints.GrowthDirection)) { case AxisDirection.Down: top += overlapCorrection; break; case AxisDirection.Up: bottom -= overlapCorrection; break; case AxisDirection.Right: left += overlapCorrection; break; case AxisDirection.Left: right -= overlapCorrection; break; }
            return Rect.FromLTRB(left, top, right, bottom);
        }


        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child)
        {
            Rect viewportClip = Dart:uiDefaultClass.Offset.Zero & Size;
            if (child.Constraints.Overlap == 0 || !child.Constraints.ViewportMainAxisExtent.IsFinite())
            {
                return viewportClip;
            }

            double left = viewportClip.Left;
            double right = viewportClip.Right;
            double top = viewportClip.Top;
            double bottom = viewportClip.Bottom;
            double startOfOverlap = child.Constraints.ViewportMainAxisExtent - child.Constraints.RemainingPaintExtent;
            double overlapCorrection = startOfOverlap + child.Constraints.Overlap;
            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(AxisDirection, child.Constraints.GrowthDirection)) { case AxisDirection.Down: top += overlapCorrection; break; case AxisDirection.Up: bottom -= overlapCorrection; break; case AxisDirection.Right: left += overlapCorrection; break; case AxisDirection.Left: right -= overlapCorrection; break; }
            return Rect.FromLTRB(left, top, right, bottom);
        }




        public new Rect DescribeSemanticsClip(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {

            if (_CalculatedCacheExtent == null)
            {
                return SemanticBounds;
            }

            switch (Axis) { case Axis.Vertical: return Rect.FromLTRB(SemanticBounds.Left, SemanticBounds.Top - _CalculatedCacheExtent, SemanticBounds.Right, SemanticBounds.Bottom + _CalculatedCacheExtent); case Axis.Horizontal: return Rect.FromLTRB(SemanticBounds.Left - _CalculatedCacheExtent, SemanticBounds.Top, SemanticBounds.Right + _CalculatedCacheExtent, SemanticBounds.Bottom); }
            return null;
        }


        public new Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child)
        {

            if (_CalculatedCacheExtent == null)
            {
                return SemanticBounds;
            }

            switch (Axis) { case Axis.Vertical: return Rect.FromLTRB(SemanticBounds.Left, SemanticBounds.Top - _CalculatedCacheExtent, SemanticBounds.Right, SemanticBounds.Bottom + _CalculatedCacheExtent); case Axis.Horizontal: return Rect.FromLTRB(SemanticBounds.Left - _CalculatedCacheExtent, SemanticBounds.Top, SemanticBounds.Right + _CalculatedCacheExtent, SemanticBounds.Bottom); }
            return null;
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (FirstChild == null) return;
            if (HasVisualOverflow)
            {
                context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, _PaintContents);
            }
            else
            {
                _PaintContents(context, offset);
            }

        }




        private void _PaintContents(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            foreach (RenderSliver child in ChildrenInPaintOrder)
            {
                if (child.Geometry.Visible) context.PaintChild(child, offset + PaintOffsetOf(child));
            }

        }




        public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            double mainAxisPosition crossAxisPosition = default(double);
            switch (Axis) { case Axis.Vertical: mainAxisPosition = position.Dy; crossAxisPosition = position.Dx; break; case Axis.Horizontal: mainAxisPosition = position.Dx; crossAxisPosition = position.Dy; break; }


            SliverHitTestResult sliverResult = SliverHitTestResult.Wrap(result);
            foreach (RenderSliver child in ChildrenInHitTestOrder)
            {
                if (!child.Geometry.Visible)
                {
                    continue;
                }

                Matrix4 transform = Matrix4.Identity();
                ApplyPaintTransform(child, transform);
                bool isHit = result.AddWithPaintTransform(transform: transform, position: null, hitTest: (BoxHitTestResult result, Offset _) =>
                {
                    return child.HitTest(sliverResult, mainAxisPosition: ComputeChildMainAxisPosition(child, mainAxisPosition), crossAxisPosition: crossAxisPosition);
                }
                );
                if (isHit)
                {
                    return true;
                }

            }

            return false;
        }




        public new FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect))
        {
            double leadingScrollOffset = 0.0;
            double targetMainAxisExtent = default(double);
            rect = (rect == null ? target.PaintBounds : rect);
            RenderObject child = target;
            RenderBox pivot = default(RenderBox);
            bool onlySlivers = target is RenderSliver;
            while (child.Parent != this)
            {
                RenderObject parent = child.Parent as RenderObject;

                if (child is RenderBox)
                {
                    pivot = ((RenderBox)child);
                }

                if (parent is RenderSliver)
                {
                    leadingScrollOffset += ((RenderSliver)parent).ChildScrollOffset(child);
                }
                else
                {
                    onlySlivers = false;
                    leadingScrollOffset = 0.0;
                }

                child = parent;
            }

            if (pivot != null)
            {




                RenderSliver pivotParent = pivot.Parent as RenderSliver;
                Matrix4 transform = target.GetTransformTo(pivot);
                Rect bounds = MatrixutilsDefaultClass.MatrixUtils.TransformRect(transform, rect);
                GrowthDirection growthDirection = pivotParent.Constraints.GrowthDirection;
                switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(AxisDirection, growthDirection)) { case AxisDirection.Up: double offset = default(double); switch (growthDirection) { case GrowthDirection.Forward: offset = bounds.Bottom; break; case GrowthDirection.Reverse: offset = bounds.Top; break; } leadingScrollOffset += pivot.Size.Height - offset; targetMainAxisExtent = bounds.Height; break; case AxisDirection.Right: double offset = default(double); switch (growthDirection) { case GrowthDirection.Forward: offset = bounds.Left; break; case GrowthDirection.Reverse: offset = bounds.Right; break; } leadingScrollOffset += offset; targetMainAxisExtent = bounds.Width; break; case AxisDirection.Down: double offset = default(double); switch (growthDirection) { case GrowthDirection.Forward: offset = bounds.Top; break; case GrowthDirection.Reverse: offset = bounds.Bottom; break; } leadingScrollOffset += offset; targetMainAxisExtent = bounds.Height; break; case AxisDirection.Left: double offset = default(double); switch (growthDirection) { case GrowthDirection.Forward: offset = bounds.Right; break; case GrowthDirection.Reverse: offset = bounds.Left; break; } leadingScrollOffset += pivot.Size.Width - offset; targetMainAxisExtent = bounds.Width; break; }
            }
            else if (onlySlivers)
            {
                RenderSliver targetSliver = target as RenderSliver;
                targetMainAxisExtent = targetSliver.Geometry.ScrollExtent;
            }
            else
            {
                return new RevealedOffset(offset: Offset.Pixels, rect: rect);
            }



            RenderSliver sliver = child as RenderSliver;
            double extentOfPinnedSlivers = MaxScrollObstructionExtentBefore(sliver);
            leadingScrollOffset = ScrollOffsetOf(sliver, leadingScrollOffset);
            switch (sliver.Constraints.GrowthDirection) { case GrowthDirection.Forward: leadingScrollOffset -= extentOfPinnedSlivers; break; case GrowthDirection.Reverse: break; }
            double mainAxisExtent = default(double);
            switch (Axis) { case Axis.Horizontal: mainAxisExtent = Size.Width - extentOfPinnedSlivers; break; case Axis.Vertical: mainAxisExtent = Size.Height - extentOfPinnedSlivers; break; }
            double targetOffset = leadingScrollOffset - (mainAxisExtent - targetMainAxisExtent) * alignment;
            double offsetDifference = Offset.Pixels - targetOffset;
            Matrix4 transform = target.GetTransformTo(this);
            ApplyPaintTransform(child, transform);
            Rect targetRect = MatrixutilsDefaultClass.MatrixUtils.TransformRect(transform, rect);
            switch (AxisDirection) { case AxisDirection.Down: targetRect = targetRect.Translate(0.0, offsetDifference); break; case AxisDirection.Right: targetRect = targetRect.Translate(offsetDifference, 0.0); break; case AxisDirection.Up: targetRect = targetRect.Translate(0.0, -offsetDifference); break; case AxisDirection.Left: targetRect = targetRect.Translate(-offsetDifference, 0.0); break; }
            return new RevealedOffset(offset: targetOffset, rect: targetRect);
        }




        /// <Summary>
        /// The offset at which the given `child` should be painted.
        ///
        /// The returned offset is from the top left corner of the inside of the
        /// viewport to the top left corner of the paint coordinate system of the
        /// `child`.
        ///
        /// See also:
        ///
        ///  * [paintOffsetOf], which uses the layout offset and growth direction
        ///    computed for the child during layout.
        /// </Summary>
        public virtual Offset ComputeAbsolutePaintOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {





            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(AxisDirection, growthDirection)) { case AxisDirection.Up: return new Offset(0.0, Size.Height - (layoutOffset + child.Geometry.PaintExtent)); case AxisDirection.Right: return new Offset(layoutOffset, 0.0); case AxisDirection.Down: return new Offset(0.0, layoutOffset); case AxisDirection.Left: return new Offset(Size.Width - (layoutOffset + child.Geometry.PaintExtent), 0.0); }
            return null;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<AxisDirection>("axisDirection", AxisDirection));
            properties.Add(new EnumProperty<AxisDirection>("crossAxisDirection", CrossAxisDirection));
            properties.Add(new DiagnosticsProperty<ViewportOffset>("offset", Offset));
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> children = new List<DiagnosticsNode>() { };
            RenderSliver child = FirstChild;
            if (child == null) return children;
            int count = IndexOfFirstChild;
            while (true)
            {
                children.Add(child.ToDiagnosticsNode(name: LabelForChild(count)));
                if (child == LastChild) break;
                count += 1;
                child = ChildAfter(child);
            }

            return children;
        }




        /// <Summary>
        /// Called during [layoutChildSequence] for each child.
        ///
        /// Typically used by subclasses to update any out-of-band data, such as the
        /// max scroll extent, for each child.
        /// </Summary>
        public virtual void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry)
        {
        }


        /// <Summary>
        /// Called during [layoutChildSequence] to store the layout offset for the
        /// given child.
        ///
        /// Different subclasses using different representations for their children's
        /// layout offset (e.g., logical or physical coordinates). This function lets
        /// subclasses transform the child's layout offset before storing it in the
        /// child's parent data.
        /// </Summary>
        public virtual void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {
        }


        /// <Summary>
        /// The offset at which the given `child` should be painted.
        ///
        /// The returned offset is from the top left corner of the inside of the
        /// viewport to the top left corner of the paint coordinate system of the
        /// `child`.
        ///
        /// See also:
        ///
        ///  * [computeAbsolutePaintOffset], which computes the paint offset from an
        ///    explicit layout offset and growth direction instead of using the values
        ///    computed for the child during layout.
        /// </Summary>
        public virtual Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {
            return default(Offset);
        }


        /// <Summary>
        /// Returns the scroll offset within the viewport for the given
        /// `scrollOffsetWithinChild` within the given `child`.
        ///
        /// The returned value is an estimate that assumes the slivers within the
        /// viewport do not change the layout extent in response to changes in their
        /// scroll offset.
        /// </Summary>
        public virtual double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild)
        {
            return default(double);
        }


        /// <Summary>
        /// Returns the total scroll obstruction extent of all slivers in the viewport
        /// before [child].
        ///
        /// This is the extent by which the actual area in which content can scroll
        /// is reduced. For example, an app bar that is pinned at the top will reduce
        /// the area in which content can actually scroll by the height of the app bar.
        /// </Summary>
        public virtual double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {
            return default(double);
        }


        /// <Summary>
        /// Converts the `parentMainAxisPosition` into the child's coordinate system.
        ///
        /// The `parentMainAxisPosition` is a distance from the top edge (for vertical
        /// viewports) or left edge (for horizontal viewports) of the viewport bounds.
        /// This describes a line, perpendicular to the viewport's main axis, heretofor
        /// known as the target line.
        ///
        /// The child's coordinate system's origin in the main axis is at the leading
        /// edge of the given child, as given by the child's
        /// [SliverConstraints.axisDirection] and [SliverConstraints.growthDirection].
        ///
        /// This method returns the distance from the leading edge of the given child to
        /// the target line described above.
        ///
        /// (The `parentMainAxisPosition` is not from the leading edge of the
        /// viewport, it's always the top or left edge.)
        /// </Summary>
        public virtual double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition)
        {
            return default(double);
        }


        /// <Summary>
        /// A short string to identify the child with the given index.
        ///
        /// Used by [debugDescribeChildren] to label the children.
        /// </Summary>
        public virtual string LabelForChild(int index)
        {
            return default(string);
        }


        public new void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            if (!Offset.AllowImplicitScrolling)
            {
                return base.ShowOnScreen(descendant: descendant, rect: rect, duration: duration, curve: curve);
            }

            Rect newRect = ViewportDefaultClass.RenderViewportBase.ShowInViewport(descendant: descendant, viewport: this, offset: Offset, rect: rect, duration: duration, curve: curve);
            base.ShowOnScreen(rect: newRect, duration: duration, curve: curve);
        }




        /// <Summary>
        /// Make (a portion of) the given `descendant` of the given `viewport` fully
        /// visible in the `viewport` by manipulating the provided [ViewportOffset]
        /// `offset`.
        ///
        /// The optional `rect` parameter describes which area of the `descendant`
        /// should be shown in the viewport. If `rect` is null, the entire
        /// `descendant` will be revealed. The `rect` parameter is interpreted
        /// relative to the coordinate system of `descendant`.
        ///
        /// The returned [Rect] describes the new location of `descendant` or `rect`
        /// in the viewport after it has been revealed. See [RevealedOffset.rect]
        /// for a full definition of this [Rect].
        ///
        /// The parameters `viewport` and `offset` are required and cannot be null.
        /// If `descendant` is null, this is a no-op and `rect` is returned.
        ///
        /// If both `descendant` and `rect` are null, null is returned because there is
        /// nothing to be shown in the viewport.
        ///
        /// The `duration` parameter can be set to a non-zero value to animate the
        /// target object into the viewport with an animation defined by `curve`.
        /// </Summary>
        public virtual Rect ShowInViewport(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Rendering.Viewport.RenderAbstractViewport viewport = default(FlutterSDK.Rendering.Viewport.RenderAbstractViewport), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {


            if (descendant == null)
            {
                return rect;
            }

            RevealedOffset leadingEdgeOffset = viewport.GetOffsetToReveal(descendant, 0.0, rect: rect);
            RevealedOffset trailingEdgeOffset = viewport.GetOffsetToReveal(descendant, 1.0, rect: rect);
            double currentOffset = offset.Pixels;
            RevealedOffset targetOffset = default(RevealedOffset);
            if (leadingEdgeOffset.Offset < trailingEdgeOffset.Offset)
            {
                double leadingEdgeDiff = (offset.Pixels - leadingEdgeOffset.Offset).Abs();
                double trailingEdgeDiff = (offset.Pixels - trailingEdgeOffset.Offset).Abs();
                targetOffset = leadingEdgeDiff < trailingEdgeDiff ? leadingEdgeOffset : trailingEdgeOffset;
            }
            else if (currentOffset > leadingEdgeOffset.Offset)
            {
                targetOffset = leadingEdgeOffset;
            }
            else if (currentOffset < trailingEdgeOffset.Offset)
            {
                targetOffset = trailingEdgeOffset;
            }
            else
            {
                Matrix4 transform = descendant.GetTransformTo(viewport.Parent as RenderObject);
                return MatrixutilsDefaultClass.MatrixUtils.TransformRect(transform, rect ?? descendant.PaintBounds);
            }


            offset.MoveTo(targetOffset.Offset, duration: duration, curve: curve);
            return targetOffset.Rect;
        }



        #endregion
        RenderAbstractViewport _RenderAbstractViewportInstance = new RenderAbstractViewport();
        public FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object) => _RenderAbstractViewportInstance.Of(@object);
        public double DefaultCacheExtent => _RenderAbstractViewportInstance.DefaultCacheExtent;
    }


    /// <Summary>
    /// A render object that is bigger on the inside.
    ///
    /// [RenderViewport] is the visual workhorse of the scrolling machinery. It
    /// displays a subset of its children according to its own dimensions and the
    /// given [offset]. As the offset varies, different children are visible through
    /// the viewport.
    ///
    /// [RenderViewport] hosts a bidirectional list of slivers, anchored on a
    /// [center] sliver, which is placed at the zero scroll offset. The center
    /// widget is displayed in the viewport according to the [anchor] property.
    ///
    /// Slivers that are earlier in the child list than [center] are displayed in
    /// reverse order in the reverse [axisDirection] starting from the [center]. For
    /// example, if the [axisDirection] is [AxisDirection.down], the first sliver
    /// before [center] is placed above the [center]. The slivers that are later in
    /// the child list than [center] are placed in order in the [axisDirection]. For
    /// example, in the preceding scenario, the first sliver after [center] is
    /// placed below the [center].
    ///
    /// [RenderViewport] cannot contain [RenderBox] children directly. Instead, use
    /// a [RenderSliverList], [RenderSliverFixedExtentList], [RenderSliverGrid], or
    /// a [RenderSliverToBoxAdapter], for example.
    ///
    /// See also:
    ///
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderSliverToBoxAdapter], which allows a [RenderBox] object to be
    ///    placed inside a [RenderSliver] (the opposite of this class).
    ///  * [RenderShrinkWrappingViewport], a variant of [RenderViewport] that
    ///    shrink-wraps its contents along the main axis.
    /// </Summary>
    public class RenderViewport : FlutterSDK.Rendering.Viewport.RenderViewportBase<FlutterSDK.Rendering.Sliver.SliverPhysicalContainerParentData>
    {
        #region constructors
        public RenderViewport(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double anchor = 0.0, List<FlutterSDK.Rendering.Sliver.RenderSliver> children = default(List<FlutterSDK.Rendering.Sliver.RenderSliver>), FlutterSDK.Rendering.Sliver.RenderSliver center = default(FlutterSDK.Rendering.Sliver.RenderSliver), double cacheExtent = default(double), FlutterSDK.Rendering.Viewport.CacheExtentStyle cacheExtentStyle = default(FlutterSDK.Rendering.Viewport.CacheExtentStyle))
        : base(axisDirection: axisDirection, crossAxisDirection: crossAxisDirection, offset: offset, cacheExtent: cacheExtent, cacheExtentStyle: cacheExtentStyle)
        {

            AddAll(children);
            if (center == null && FirstChild != null) _Center = FirstChild;
        }


        #endregion

        #region fields
        public virtual FlutterSDK.Semantics.Semantics.SemanticsTag UseTwoPaneSemantics { get; set; }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsTag ExcludeFromScrolling { get; set; }
        internal virtual double _Anchor { get; set; }
        internal virtual FlutterSDK.Rendering.Sliver.RenderSliver _Center { get; set; }
        internal virtual int _MaxLayoutCycles { get; set; }
        internal virtual double _MinScrollExtent { get; set; }
        internal virtual double _MaxScrollExtent { get; set; }
        internal virtual bool _HasVisualOverflow { get; set; }
        public virtual double Anchor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliver.RenderSliver Center { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexOfFirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is SliverPhysicalContainerParentData)) child.ParentData = new SliverPhysicalContainerParentData();
        }




        public new void PerformResize()
        {

            Size = Constraints.Biggest;
            switch (Axis) { case Axis.Vertical: Offset.ApplyViewportDimension(Size.Height); break; case Axis.Horizontal: Offset.ApplyViewportDimension(Size.Width); break; }
        }




        public new void PerformLayout()
        {
            if (Center == null)
            {

                _MinScrollExtent = 0.0;
                _MaxScrollExtent = 0.0;
                _HasVisualOverflow = false;
                Offset.ApplyContentDimensions(0.0, 0.0);
                return;
            }


            double mainAxisExtent = default(double);
            double crossAxisExtent = default(double);
            switch (Axis) { case Axis.Vertical: mainAxisExtent = Size.Height; crossAxisExtent = Size.Width; break; case Axis.Horizontal: mainAxisExtent = Size.Width; crossAxisExtent = Size.Height; break; }
            double centerOffsetAdjustment = Center.CenterOffsetAdjustment;
            double correction = default(double);
            int count = 0;
            do
            {

                correction = _AttemptLayout(mainAxisExtent, crossAxisExtent, Offset.Pixels + centerOffsetAdjustment);
                if (correction != 0.0)
                {
                    Offset.CorrectBy(correction);
                }
                else
                {
                    if (Offset.ApplyContentDimensions(Math.Dart:mathDefaultClass.Min(0.0, _MinScrollExtent + mainAxisExtent * Anchor), Math.Dart:mathDefaultClass.Max(0.0, _MaxScrollExtent - mainAxisExtent * (1.0 - Anchor)))) break;
                }

                count += 1;
            }
            while (count < _MaxLayoutCycles);

        }




        private double _AttemptLayout(double mainAxisExtent, double crossAxisExtent, double correctedOffset)
        {





            _MinScrollExtent = 0.0;
            _MaxScrollExtent = 0.0;
            _HasVisualOverflow = false;
            double centerOffset = mainAxisExtent * Anchor - correctedOffset;
            double reverseDirectionRemainingPaintExtent = centerOffset.Clamp(0.0, mainAxisExtent) as double;
            double forwardDirectionRemainingPaintExtent = (mainAxisExtent - centerOffset).Clamp(0.0, mainAxisExtent) as double;
            switch (CacheExtentStyle) { case CacheExtentStyle.Pixel: _CalculatedCacheExtent = CacheExtent; break; case CacheExtentStyle.Viewport: _CalculatedCacheExtent = mainAxisExtent * CacheExtent; break; }
            double fullCacheExtent = mainAxisExtent + 2 * _CalculatedCacheExtent;
            double centerCacheOffset = centerOffset + _CalculatedCacheExtent;
            double reverseDirectionRemainingCacheExtent = centerCacheOffset.Clamp(0.0, fullCacheExtent) as double;
            double forwardDirectionRemainingCacheExtent = (fullCacheExtent - centerCacheOffset).Clamp(0.0, fullCacheExtent) as double;
            RenderSliver leadingNegativeChild = ChildBefore(Center);
            if (leadingNegativeChild != null)
            {
                double result = LayoutChildSequence(child: leadingNegativeChild, scrollOffset: Math.Dart:mathDefaultClass.Max(mainAxisExtent, centerOffset) - mainAxisExtent, overlap: 0.0, layoutOffset: forwardDirectionRemainingPaintExtent, remainingPaintExtent: reverseDirectionRemainingPaintExtent, mainAxisExtent: mainAxisExtent, crossAxisExtent: crossAxisExtent, growthDirection: GrowthDirection.Reverse, advance: ChildBefore, remainingCacheExtent: reverseDirectionRemainingCacheExtent, cacheOrigin: (mainAxisExtent - centerOffset).Clamp(-_CalculatedCacheExtent, 0.0) as double);
                if (result != 0.0) return -result;
            }

            return LayoutChildSequence(child: Center, scrollOffset: Math.Dart:mathDefaultClass.Max(0.0, -centerOffset), overlap: leadingNegativeChild == null ? Math.Dart : mathDefaultClass.Min(0.0, -centerOffset):0.0, layoutOffset: centerOffset >= mainAxisExtent ? centerOffset : reverseDirectionRemainingPaintExtent, remainingPaintExtent: forwardDirectionRemainingPaintExtent, mainAxisExtent: mainAxisExtent, crossAxisExtent: crossAxisExtent, growthDirection: GrowthDirection.Forward, advance: ChildAfter, remainingCacheExtent: forwardDirectionRemainingCacheExtent, cacheOrigin: centerOffset.Clamp(-_CalculatedCacheExtent, 0.0) as double);
        }




        public new void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry)
        {
            switch (growthDirection) { case GrowthDirection.Forward: _MaxScrollExtent += childLayoutGeometry.ScrollExtent; break; case GrowthDirection.Reverse: _MinScrollExtent -= childLayoutGeometry.ScrollExtent; break; }
            if (childLayoutGeometry.HasVisualOverflow) _HasVisualOverflow = true;
        }




        public new void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {
            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
            childParentData.PaintOffset = ComputeAbsolutePaintOffset(child, layoutOffset, growthDirection);
        }




        public new Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {
            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
            return childParentData.PaintOffset;
        }




        public new double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild)
        {

            GrowthDirection growthDirection = child.Constraints.GrowthDirection;

            switch (growthDirection)
            {
                case GrowthDirection.Forward:
                    double scrollOffsetToChild = 0.0; RenderSliver current = Center; while (current != child)
                    {
                        scrollOffsetToChild += current.Geometry.ScrollExtent;
                        current = ChildAfter(current);
                    }
                    return scrollOffsetToChild + scrollOffsetWithinChild;
                case GrowthDirection.Reverse:
                    double scrollOffsetToChild = 0.0; RenderSliver current = ChildBefore(Center); while (current != child)
                    {
                        scrollOffsetToChild -= current.Geometry.ScrollExtent;
                        current = ChildBefore(current);
                    }
                    return scrollOffsetToChild - scrollOffsetWithinChild;
            }
            return null;
        }




        public new double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {

            GrowthDirection growthDirection = child.Constraints.GrowthDirection;

            switch (growthDirection)
            {
                case GrowthDirection.Forward:
                    double pinnedExtent = 0.0; RenderSliver current = Center; while (current != child)
                    {
                        pinnedExtent += current.Geometry.MaxScrollObstructionExtent;
                        current = ChildAfter(current);
                    }
                    return pinnedExtent;
                case GrowthDirection.Reverse:
                    double pinnedExtent = 0.0; RenderSliver current = ChildBefore(Center); while (current != child)
                    {
                        pinnedExtent += current.Geometry.MaxScrollObstructionExtent;
                        current = ChildBefore(current);
                    }
                    return pinnedExtent;
            }
            return null;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {

            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
            childParentData.ApplyPaintTransform(transform);
        }




        public new double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition)
        {


            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(child.Constraints.AxisDirection, child.Constraints.GrowthDirection)) { case AxisDirection.Down: return parentMainAxisPosition - childParentData.PaintOffset.Dy; case AxisDirection.Right: return parentMainAxisPosition - childParentData.PaintOffset.Dx; case AxisDirection.Up: return child.Geometry.PaintExtent - (parentMainAxisPosition - childParentData.PaintOffset.Dy); case AxisDirection.Left: return child.Geometry.PaintExtent - (parentMainAxisPosition - childParentData.PaintOffset.Dx); }
            return 0.0;
        }




        public new string LabelForChild(int index)
        {
            if (index == 0) return "center child";
            return $"'child {index}'";
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("anchor", Anchor));
        }



        #endregion
    }


    /// <Summary>
    /// A render object that is bigger on the inside and shrink wraps its children
    /// in the main axis.
    ///
    /// [RenderShrinkWrappingViewport] displays a subset of its children according
    /// to its own dimensions and the given [offset]. As the offset varies, different
    /// children are visible through the viewport.
    ///
    /// [RenderShrinkWrappingViewport] differs from [RenderViewport] in that
    /// [RenderViewport] expands to fill the main axis whereas
    /// [RenderShrinkWrappingViewport] sizes itself to match its children in the
    /// main axis. This shrink wrapping behavior is expensive because the children,
    /// and hence the viewport, could potentially change size whenever the [offset]
    /// changes (e.g., because of a collapsing header).
    ///
    /// [RenderShrinkWrappingViewport] cannot contain [RenderBox] children directly.
    /// Instead, use a [RenderSliverList], [RenderSliverFixedExtentList],
    /// [RenderSliverGrid], or a [RenderSliverToBoxAdapter], for example.
    ///
    /// See also:
    ///
    ///  * [RenderViewport], a viewport that does not shrink-wrap its contents.
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderSliverToBoxAdapter], which allows a [RenderBox] object to be
    ///    placed inside a [RenderSliver] (the opposite of this class).
    /// </Summary>
    public class RenderShrinkWrappingViewport : FlutterSDK.Rendering.Viewport.RenderViewportBase<FlutterSDK.Rendering.Sliver.SliverLogicalContainerParentData>
    {
        #region constructors
        public RenderShrinkWrappingViewport(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), List<FlutterSDK.Rendering.Sliver.RenderSliver> children = default(List<FlutterSDK.Rendering.Sliver.RenderSliver>))
        : base(axisDirection: axisDirection, crossAxisDirection: crossAxisDirection, offset: offset)
        {

            AddAll(children);
        }


        #endregion

        #region fields
        internal virtual double _MaxScrollExtent { get; set; }
        internal virtual double _ShrinkWrapExtent { get; set; }
        internal virtual bool _HasVisualOverflow { get; set; }
        public virtual bool HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexOfFirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is SliverLogicalContainerParentData)) child.ParentData = new SliverLogicalContainerParentData();
        }




        public new bool DebugThrowIfNotCheckingIntrinsics()
        {

            return true;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            if (FirstChild == null)
            {
                switch (Axis) { case Axis.Vertical: Size = new Size(constraints.MaxWidth, constraints.MinHeight); break; case Axis.Horizontal: Size = new Size(constraints.MinWidth, constraints.MaxHeight); break; }
                Offset.ApplyViewportDimension(0.0);
                _MaxScrollExtent = 0.0;
                _ShrinkWrapExtent = 0.0;
                _HasVisualOverflow = false;
                Offset.ApplyContentDimensions(0.0, 0.0);
                return;
            }

            double mainAxisExtent = default(double);
            double crossAxisExtent = default(double);
            switch (Axis) { case Axis.Vertical: mainAxisExtent = constraints.MaxHeight; crossAxisExtent = constraints.MaxWidth; break; case Axis.Horizontal: mainAxisExtent = constraints.MaxWidth; crossAxisExtent = constraints.MaxHeight; break; }
            double correction = default(double);
            double effectiveExtent = default(double);
            do
            {

                correction = _AttemptLayout(mainAxisExtent, crossAxisExtent, Offset.Pixels);
                if (correction != 0.0)
                {
                    Offset.CorrectBy(correction);
                }
                else
                {
                    switch (Axis) { case Axis.Vertical: effectiveExtent = constraints.ConstrainHeight(_ShrinkWrapExtent); break; case Axis.Horizontal: effectiveExtent = constraints.ConstrainWidth(_ShrinkWrapExtent); break; }
                    bool didAcceptViewportDimension = Offset.ApplyViewportDimension(effectiveExtent);
                    bool didAcceptContentDimension = Offset.ApplyContentDimensions(0.0, Math.Dart:mathDefaultClass.Max(0.0, _MaxScrollExtent - effectiveExtent));
                    if (didAcceptViewportDimension && didAcceptContentDimension) break;
                }

            }
            while (true);
            switch (Axis) { case Axis.Vertical: Size = constraints.ConstrainDimensions(crossAxisExtent, effectiveExtent); break; case Axis.Horizontal: Size = constraints.ConstrainDimensions(effectiveExtent, crossAxisExtent); break; }
        }




        private double _AttemptLayout(double mainAxisExtent, double crossAxisExtent, double correctedOffset)
        {





            _MaxScrollExtent = 0.0;
            _ShrinkWrapExtent = 0.0;
            _HasVisualOverflow = false;
            return LayoutChildSequence(child: FirstChild, scrollOffset: Math.Dart:mathDefaultClass.Max(0.0, correctedOffset), overlap: Math.Dart:mathDefaultClass.Min(0.0, correctedOffset), layoutOffset: 0.0, remainingPaintExtent: mainAxisExtent, mainAxisExtent: mainAxisExtent, crossAxisExtent: crossAxisExtent, growthDirection: GrowthDirection.Forward, advance: ChildAfter, remainingCacheExtent: mainAxisExtent + 2 * CacheExtent, cacheOrigin: -CacheExtent);
        }




        public new void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry)
        {

            _MaxScrollExtent += childLayoutGeometry.ScrollExtent;
            if (childLayoutGeometry.HasVisualOverflow) _HasVisualOverflow = true;
            _ShrinkWrapExtent += childLayoutGeometry.MaxPaintExtent;
        }




        public new void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {

            SliverLogicalParentData childParentData = child.ParentData as SliverLogicalParentData;
            childParentData.LayoutOffset = layoutOffset;
        }




        public new Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {
            SliverLogicalParentData childParentData = child.ParentData as SliverLogicalParentData;
            return ComputeAbsolutePaintOffset(child, childParentData.LayoutOffset, GrowthDirection.Forward);
        }




        public new double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild)
        {


            double scrollOffsetToChild = 0.0;
            RenderSliver current = FirstChild;
            while (current != child)
            {
                scrollOffsetToChild += current.Geometry.ScrollExtent;
                current = ChildAfter(current);
            }

            return scrollOffsetToChild + scrollOffsetWithinChild;
        }




        public new double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {


            double pinnedExtent = 0.0;
            RenderSliver current = FirstChild;
            while (current != child)
            {
                pinnedExtent += current.Geometry.MaxScrollObstructionExtent;
                current = ChildAfter(current);
            }

            return pinnedExtent;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {

            Offset offset = PaintOffsetOf(child as RenderSliver);
            transform.Translate(offset.Dx, offset.Dy);
        }




        public new double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition)
        {



            SliverLogicalParentData childParentData = child.ParentData as SliverLogicalParentData;
            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(child.Constraints.AxisDirection, child.Constraints.GrowthDirection)) { case AxisDirection.Down: case AxisDirection.Right: return parentMainAxisPosition - childParentData.LayoutOffset; case AxisDirection.Up: return (Size.Height - parentMainAxisPosition) - childParentData.LayoutOffset; case AxisDirection.Left: return (Size.Width - parentMainAxisPosition) - childParentData.LayoutOffset; }
            return 0.0;
        }




        public new string LabelForChild(int index) => $"'child {index}'";


        #endregion
    }


    /// <Summary>
    /// The unit of measurement for a [Viewport.cacheExtent].
    /// </Summary>
    public enum CacheExtentStyle
    {

        /// <Summary>
        /// Treat the [Viewport.cacheExtent] as logical pixels.
        /// </Summary>
        Pixel,
        /// <Summary>
        /// Treat the [Viewport.cacheExtent] as a multiplier of the main axis extent.
        /// </Summary>
        Viewport,
    }

}
