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
namespace FlutterSDK.Rendering.Sliverpadding
{
    internal static class SliverpaddingDefaultClass
    {
    }

    /// <Summary>
    /// Insets a [RenderSliver] by applying [resolvedPadding] on each side.
    ///
    /// A [RenderSliverEdgeInsetsPadding] subclass wraps the [SliverGeometry.layoutExtent]
    /// of its child. Any incoming [SliverConstraints.overlap] is ignored and not
    /// passed on to the child.
    ///
    /// {@template flutter.rendering.sliverPadding.limitation}
    /// Applying padding to anything but the most mundane sliver is likely to have
    /// undesired effects. For example, wrapping a [RenderSliverPinnedPersistentHeader]
    /// will cause the app bar to overlap earlier slivers (contrary to the normal
    /// behavior of pinned app bars), and while the app bar is pinned, the padding
    /// will scroll away.
    /// {@endtemplate}
    /// </Summary>
    public interface IRenderSliverEdgeInsetsPadding
    {
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        void PerformLayout();
        bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        double ChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child);
        double ChildCrossAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child);
        double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        FlutterSDK.Painting.Edgeinsets.EdgeInsets ResolvedPadding { get; }
        double BeforePadding { get; }
        double AfterPadding { get; }
        double MainAxisPadding { get; }
        double CrossAxisPadding { get; }
    }


    /// <Summary>
    /// Insets a [RenderSliver] by applying [resolvedPadding] on each side.
    ///
    /// A [RenderSliverEdgeInsetsPadding] subclass wraps the [SliverGeometry.layoutExtent]
    /// of its child. Any incoming [SliverConstraints.overlap] is ignored and not
    /// passed on to the child.
    ///
    /// {@template flutter.rendering.sliverPadding.limitation}
    /// Applying padding to anything but the most mundane sliver is likely to have
    /// undesired effects. For example, wrapping a [RenderSliverPinnedPersistentHeader]
    /// will cause the app bar to overlap earlier slivers (contrary to the normal
    /// behavior of pinned app bars), and while the app bar is pinned, the padding
    /// will scroll away.
    /// {@endtemplate}
    /// </Summary>
    public class RenderSliverEdgeInsetsPadding : FlutterSDK.Rendering.Sliver.RenderSliver, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
    {
        public RenderSliverEdgeInsetsPadding()
        { }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ResolvedPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double BeforePadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double AfterPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MainAxisPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CrossAxisPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is SliverPhysicalParentData)) child.ParentData = new SliverPhysicalParentData();
        }




        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;

            double beforePadding = this.BeforePadding;
            double afterPadding = this.AfterPadding;
            double mainAxisPadding = this.MainAxisPadding;
            double crossAxisPadding = this.CrossAxisPadding;
            if (Child == null)
            {
                Geometry = new SliverGeometry(scrollExtent: mainAxisPadding, paintExtent: Dart.Math.MathDefaultClass.Min(mainAxisPadding, constraints.RemainingPaintExtent), maxPaintExtent: mainAxisPadding);
                return;
            }

            Child.Layout(constraints.CopyWith(scrollOffset: Dart.Math.MathDefaultClass.Max(0.0, constraints.ScrollOffset - beforePadding), cacheOrigin: Dart.Math.MathDefaultClass.Min(0.0, constraints.CacheOrigin + beforePadding), overlap: 0.0, remainingPaintExtent: constraints.RemainingPaintExtent - CalculatePaintOffset(constraints, from: 0.0, to: beforePadding), remainingCacheExtent: constraints.RemainingCacheExtent - CalculateCacheOffset(constraints, from: 0.0, to: beforePadding), crossAxisExtent: Dart.Math.MathDefaultClass.Max(0.0, constraints.CrossAxisExtent - crossAxisPadding), precedingScrollExtent: beforePadding + constraints.PrecedingScrollExtent), parentUsesSize: true);
            SliverGeometry childLayoutGeometry = Child.Geometry;
            if (childLayoutGeometry.ScrollOffsetCorrection != null)
            {
                Geometry = new SliverGeometry(scrollOffsetCorrection: childLayoutGeometry.ScrollOffsetCorrection);
                return;
            }

            double beforePaddingPaintExtent = CalculatePaintOffset(constraints, from: 0.0, to: beforePadding);
            double afterPaddingPaintExtent = CalculatePaintOffset(constraints, from: beforePadding + childLayoutGeometry.ScrollExtent, to: mainAxisPadding + childLayoutGeometry.ScrollExtent);
            double mainAxisPaddingPaintExtent = beforePaddingPaintExtent + afterPaddingPaintExtent;
            double beforePaddingCacheExtent = CalculateCacheOffset(constraints, from: 0.0, to: beforePadding);
            double afterPaddingCacheExtent = CalculateCacheOffset(constraints, from: beforePadding + childLayoutGeometry.ScrollExtent, to: mainAxisPadding + childLayoutGeometry.ScrollExtent);
            double mainAxisPaddingCacheExtent = afterPaddingCacheExtent + beforePaddingCacheExtent;
            double paintExtent = Dart.Math.MathDefaultClass.Min(beforePaddingPaintExtent + Dart.Math.MathDefaultClass.Max(childLayoutGeometry.PaintExtent, childLayoutGeometry.LayoutExtent + afterPaddingPaintExtent), constraints.RemainingPaintExtent);
            Geometry = new SliverGeometry(scrollExtent: mainAxisPadding + childLayoutGeometry.ScrollExtent, paintExtent: paintExtent, layoutExtent: Dart.Math.MathDefaultClass.Min(mainAxisPaddingPaintExtent + childLayoutGeometry.LayoutExtent, paintExtent), cacheExtent: Dart.Math.MathDefaultClass.Min(mainAxisPaddingCacheExtent + childLayoutGeometry.CacheExtent, constraints.RemainingCacheExtent), maxPaintExtent: mainAxisPadding + childLayoutGeometry.MaxPaintExtent, hitTestExtent: Dart.Math.MathDefaultClass.Max(mainAxisPaddingPaintExtent + childLayoutGeometry.PaintExtent, beforePaddingPaintExtent + childLayoutGeometry.HitTestExtent), hasVisualOverflow: childLayoutGeometry.HasVisualOverflow);
            SliverPhysicalParentData childParentData = Child.ParentData as SliverPhysicalParentData;


            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(constraints.AxisDirection, constraints.GrowthDirection)) { case AxisDirection.Up: childParentData.PaintOffset = new Offset(ResolvedPadding.Left, CalculatePaintOffset(constraints, from: ResolvedPadding.Bottom + childLayoutGeometry.ScrollExtent, to: ResolvedPadding.Bottom + childLayoutGeometry.ScrollExtent + ResolvedPadding.Top)); break; case AxisDirection.Right: childParentData.PaintOffset = new Offset(CalculatePaintOffset(constraints, from: 0.0, to: ResolvedPadding.Left), ResolvedPadding.Top); break; case AxisDirection.Down: childParentData.PaintOffset = new Offset(ResolvedPadding.Left, CalculatePaintOffset(constraints, from: 0.0, to: ResolvedPadding.Top)); break; case AxisDirection.Left: childParentData.PaintOffset = new Offset(CalculatePaintOffset(constraints, from: ResolvedPadding.Right + childLayoutGeometry.ScrollExtent, to: ResolvedPadding.Right + childLayoutGeometry.ScrollExtent + ResolvedPadding.Left), ResolvedPadding.Top); break; }





        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        {
            if (Child != null && Child.Geometry.HitTestExtent > 0.0)
            {
                SliverPhysicalParentData childParentData = Child.ParentData as SliverPhysicalParentData;
                result.AddWithAxisOffset(mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition, mainAxisOffset: ChildMainAxisPosition(Child), crossAxisOffset: ChildCrossAxisPosition(Child), paintOffset: childParentData.PaintOffset, hitTest: Child.HitTest);
            }

            return false;
        }




        public new double ChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {


            return CalculatePaintOffset(Constraints, from: 0.0, to: BeforePadding);
        }


        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {


            return CalculatePaintOffset(Constraints, from: 0.0, to: BeforePadding);
        }




        public new double ChildCrossAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child)
        {






            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(Constraints.AxisDirection, Constraints.GrowthDirection)) { case AxisDirection.Up: case AxisDirection.Down: return ResolvedPadding.Left; case AxisDirection.Left: case AxisDirection.Right: return ResolvedPadding.Top; }
            return null;
        }


        public new double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {






            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(Constraints.AxisDirection, Constraints.GrowthDirection)) { case AxisDirection.Up: case AxisDirection.Down: return ResolvedPadding.Left; case AxisDirection.Left: case AxisDirection.Right: return ResolvedPadding.Top; }
            return null;
        }




        public new double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return BeforePadding;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {


            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
            childParentData.ApplyPaintTransform(transform);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child != null && Child.Geometry.Visible)
            {
                SliverPhysicalParentData childParentData = Child.ParentData as SliverPhysicalParentData;
                context.PaintChild(Child, offset + childParentData.PaintOffset);
            }

        }




        public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            base.DebugPaint(context, offset);

        }



    }


    /// <Summary>
    /// Insets a [RenderSliver], applying padding on each side.
    ///
    /// A [RenderSliverPadding] object wraps the [SliverGeometry.layoutExtent] of
    /// its child. Any incoming [SliverConstraints.overlap] is ignored and not
    /// passed on to the child.
    ///
    /// {@macro flutter.rendering.sliverPadding.limitation}
    /// </Summary>
    public class RenderSliverPadding : FlutterSDK.Rendering.Sliverpadding.RenderSliverEdgeInsetsPadding
    {
        /// <Summary>
        /// Creates a render object that insets its child in a viewport.
        ///
        /// The [padding] argument must not be null and must have non-negative insets.
        /// </Summary>
        public RenderSliverPadding(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver))
        : base()
        {

            this.Child = child;
        }


        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets _ResolvedPadding { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _Padding { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ResolvedPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _Resolve()
        {
            if (ResolvedPadding != null) return;
            _ResolvedPadding = Padding.Resolve(TextDirection);

        }




        private void _MarkNeedsResolution()
        {
            _ResolvedPadding = null;
            MarkNeedsLayout();
        }




        public new void PerformLayout()
        {
            _Resolve();
            base.PerformLayout();
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
        }



    }

}
