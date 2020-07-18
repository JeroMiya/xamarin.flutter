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
namespace FlutterSDK.Rendering.Sliverfixedextentlist
{
    internal static class SliverfixedextentlistDefaultClass
    {
    }

    /// <Summary>
    /// A sliver that contains multiple box children that have the same extent in
    /// the main axis.
    ///
    /// [RenderSliverFixedExtentBoxAdaptor] places its children in a linear array
    /// along the main axis. Each child is forced to have the [itemExtent] in the
    /// main axis and the [SliverConstraints.crossAxisExtent] in the cross axis.
    ///
    /// Subclasses should override [itemExtent] to control the size of the children
    /// in the main axis. For a concrete subclass with a configurable [itemExtent],
    /// see [RenderSliverFixedExtentList].
    ///
    /// [RenderSliverFixedExtentBoxAdaptor] is more efficient than
    /// [RenderSliverList] because [RenderSliverFixedExtentBoxAdaptor] does not need
    /// to perform layout on its children to obtain their extent in the main axis.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFixedExtentList], which has a configurable [itemExtent].
    ///  * [RenderSliverFillViewport], which determines the [itemExtent] based on
    ///    [SliverConstraints.viewportMainAxisExtent].
    ///  * [RenderSliverFillRemaining], which determines the [itemExtent] based on
    ///    [SliverConstraints.remainingPaintExtent].
    ///  * [RenderSliverList], which does not require its children to have the same
    ///    extent in the main axis.
    /// </Summary>
    public interface IRenderSliverFixedExtentBoxAdaptor
    {
        double IndexToLayoutOffset(double itemExtent, int index);
        int GetMinChildIndexForScrollOffset(double scrollOffset, double itemExtent);
        int GetMaxChildIndexForScrollOffset(double scrollOffset, double itemExtent);
        double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex = default(int), int lastIndex = default(int), double leadingScrollOffset = default(double), double trailingScrollOffset = default(double));
        double ComputeMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double itemExtent);
        void PerformLayout();
        double ItemExtent { get; }
    }


    /// <Summary>
    /// A sliver that contains multiple box children that have the same extent in
    /// the main axis.
    ///
    /// [RenderSliverFixedExtentBoxAdaptor] places its children in a linear array
    /// along the main axis. Each child is forced to have the [itemExtent] in the
    /// main axis and the [SliverConstraints.crossAxisExtent] in the cross axis.
    ///
    /// Subclasses should override [itemExtent] to control the size of the children
    /// in the main axis. For a concrete subclass with a configurable [itemExtent],
    /// see [RenderSliverFixedExtentList].
    ///
    /// [RenderSliverFixedExtentBoxAdaptor] is more efficient than
    /// [RenderSliverList] because [RenderSliverFixedExtentBoxAdaptor] does not need
    /// to perform layout on its children to obtain their extent in the main axis.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFixedExtentList], which has a configurable [itemExtent].
    ///  * [RenderSliverFillViewport], which determines the [itemExtent] based on
    ///    [SliverConstraints.viewportMainAxisExtent].
    ///  * [RenderSliverFillRemaining], which determines the [itemExtent] based on
    ///    [SliverConstraints.remainingPaintExtent].
    ///  * [RenderSliverList], which does not require its children to have the same
    ///    extent in the main axis.
    /// </Summary>
    public class RenderSliverFixedExtentBoxAdaptor : FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor
    {
        #region constructors
        public RenderSliverFixedExtentBoxAdaptor(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager childManager = default(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager))
        : base(childManager: childManager)
        {

        }
        #endregion

        #region fields
        public virtual double ItemExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// The layout offset for the child with the given index.
        ///
        /// This function is given the [itemExtent] as an argument to avoid
        /// recomputing [itemExtent] repeatedly during layout.
        ///
        /// By default, places the children in order, without gaps, starting from
        /// layout offset zero.
        /// </Summary>
        public virtual double IndexToLayoutOffset(double itemExtent, int index) => itemExtent * index;



        /// <Summary>
        /// The minimum child index that is visible at the given scroll offset.
        ///
        /// This function is given the [itemExtent] as an argument to avoid
        /// recomputing [itemExtent] repeatedly during layout.
        ///
        /// By default, returns a value consistent with the children being placed in
        /// order, without gaps, starting from layout offset zero.
        /// </Summary>
        public virtual int GetMinChildIndexForScrollOffset(double scrollOffset, double itemExtent)
        {
            if (itemExtent > 0.0)
            {
                double actual = scrollOffset / itemExtent;
                int round = actual.Round();
                if ((actual - round).Abs() < ConstantsDefaultClass.PrecisionErrorTolerance)
                {
                    return round;
                }

                return actual.Floor();
            }

            return 0;
        }




        /// <Summary>
        /// The maximum child index that is visible at the given scroll offset.
        ///
        /// This function is given the [itemExtent] as an argument to avoid
        /// recomputing [itemExtent] repeatedly during layout.
        ///
        /// By default, returns a value consistent with the children being placed in
        /// order, without gaps, starting from layout offset zero.
        /// </Summary>
        public virtual int GetMaxChildIndexForScrollOffset(double scrollOffset, double itemExtent)
        {
            return itemExtent > 0.0 ? Math.Dart : mathDefaultClass.Max(0, (scrollOffset / itemExtent).Ceil() - 1):0;
        }




        /// <Summary>
        /// Called to estimate the total scrollable extents of this object.
        ///
        /// Must return the total distance from the start of the child with the
        /// earliest possible index to the end of the child with the last possible
        /// index.
        ///
        /// By default, defers to [RenderSliverBoxChildManager.estimateMaxScrollOffset].
        ///
        /// See also:
        ///
        ///  * [computeMaxScrollOffset], which is similar but must provide a precise
        ///    value.
        /// </Summary>
        public virtual double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex = default(int), int lastIndex = default(int), double leadingScrollOffset = default(double), double trailingScrollOffset = default(double))
        {
            return ChildManager.EstimateMaxScrollOffset(constraints, firstIndex: firstIndex, lastIndex: lastIndex, leadingScrollOffset: leadingScrollOffset, trailingScrollOffset: trailingScrollOffset);
        }




        /// <Summary>
        /// Called to obtain a precise measure of the total scrollable extents of this
        /// object.
        ///
        /// Must return the precise total distance from the start of the child with
        /// the earliest possible index to the end of the child with the last possible
        /// index.
        ///
        /// This is used when no child is available for the index corresponding to the
        /// current scroll offset, to determine the precise dimensions of the sliver.
        /// It must return a precise value. It will not be called if the
        /// [childManager] returns an infinite number of children for positive
        /// indices.
        ///
        /// By default, multiplies the [itemExtent] by the number of children reported
        /// by [RenderSliverBoxChildManager.childCount].
        ///
        /// See also:
        ///
        ///  * [estimateMaxScrollOffset], which is similar but may provide inaccurate
        ///    values.
        /// </Summary>
        public virtual double ComputeMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double itemExtent)
        {
            return ChildManager.ChildCount * itemExtent;
        }




        private int _CalculateLeadingGarbage(int firstIndex)
        {
            RenderBox walker = FirstChild;
            int leadingGarbage = 0;
            while (walker != null && IndexOf(walker) < firstIndex)
            {
                leadingGarbage += 1;
                walker = ChildAfter(walker);
            }

            return leadingGarbage;
        }




        private int _CalculateTrailingGarbage(int targetLastIndex)
        {
            RenderBox walker = LastChild;
            int trailingGarbage = 0;
            while (walker != null && IndexOf(walker) > targetLastIndex)
            {
                trailingGarbage += 1;
                walker = ChildBefore(walker);
            }

            return trailingGarbage;
        }




        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;
            ChildManager.DidStartLayout();
            ChildManager.SetDidUnderflow(false);
            double itemExtent = this.ItemExtent;
            double scrollOffset = constraints.ScrollOffset + constraints.CacheOrigin;

            double remainingExtent = constraints.RemainingCacheExtent;

            double targetEndScrollOffset = scrollOffset + remainingExtent;
            BoxConstraints childConstraints = constraints.AsBoxConstraints(minExtent: itemExtent, maxExtent: itemExtent);
            int firstIndex = GetMinChildIndexForScrollOffset(scrollOffset, itemExtent);
            int targetLastIndex = targetEndScrollOffset.IsFinite() ? GetMaxChildIndexForScrollOffset(targetEndScrollOffset, itemExtent) : null;
            if (FirstChild != null)
            {
                int leadingGarbage = _CalculateLeadingGarbage(firstIndex);
                int trailingGarbage = _CalculateTrailingGarbage(targetLastIndex);
                CollectGarbage(leadingGarbage, trailingGarbage);
            }
            else
            {
                CollectGarbage(0, 0);
            }

            if (FirstChild == null)
            {
                if (!AddInitialChild(index: firstIndex, layoutOffset: IndexToLayoutOffset(itemExtent, firstIndex)))
                {
                    double max = default(double);
                    if (ChildManager.ChildCount != null)
                    {
                        max = ComputeMaxScrollOffset(constraints, itemExtent);
                    }
                    else if (firstIndex <= 0)
                    {
                        max = 0.0;
                    }
                    else
                    {
                        int possibleFirstIndex = firstIndex - 1;
                        while (possibleFirstIndex > 0 && !AddInitialChild(index: possibleFirstIndex, layoutOffset: IndexToLayoutOffset(itemExtent, possibleFirstIndex)))
                        {
                            possibleFirstIndex -= 1;
                        }

                        max = possibleFirstIndex * itemExtent;
                    }

                    Geometry = new SliverGeometry(scrollExtent: max, maxPaintExtent: max);
                    ChildManager.DidFinishLayout();
                    return;
                }

            }

            RenderBox trailingChildWithLayout = default(RenderBox);
            for (int index = IndexOf(FirstChild) - 1; index >= firstIndex; --index)
            {
                RenderBox child = InsertAndLayoutLeadingChild(childConstraints);
                if (child == null)
                {
                    Geometry = new SliverGeometry(scrollOffsetCorrection: index * itemExtent);
                    return;
                }

                SliverMultiBoxAdaptorParentData childParentData = child.ParentData as SliverMultiBoxAdaptorParentData;
                childParentData.LayoutOffset = IndexToLayoutOffset(itemExtent, index);

                trailingChildWithLayout = (trailingChildWithLayout == null ? child : trailingChildWithLayout);
            }

            if (trailingChildWithLayout == null)
            {
                FirstChild.Layout(childConstraints);
                SliverMultiBoxAdaptorParentData childParentData = FirstChild.ParentData as SliverMultiBoxAdaptorParentData;
                childParentData.LayoutOffset = IndexToLayoutOffset(itemExtent, firstIndex);
                trailingChildWithLayout = FirstChild;
            }

            double estimatedMaxScrollOffset = Dart:coreDefaultClass.Double.Infinity;
            for (int index = IndexOf(trailingChildWithLayout) + 1; targetLastIndex == null || index <= targetLastIndex; ++index)
            {
                RenderBox child = ChildAfter(trailingChildWithLayout);
                if (child == null || IndexOf(child) != index)
                {
                    child = InsertAndLayoutChild(childConstraints, after: trailingChildWithLayout);
                    if (child == null)
                    {
                        estimatedMaxScrollOffset = index * itemExtent;
                        break;
                    }

                }
                else
                {
                    child.Layout(childConstraints);
                }

                trailingChildWithLayout = child;

                SliverMultiBoxAdaptorParentData childParentData = child.ParentData as SliverMultiBoxAdaptorParentData;

                childParentData.LayoutOffset = IndexToLayoutOffset(itemExtent, childParentData.Index);
            }

            int lastIndex = IndexOf(LastChild);
            double leadingScrollOffset = IndexToLayoutOffset(itemExtent, firstIndex);
            double trailingScrollOffset = IndexToLayoutOffset(itemExtent, lastIndex + 1);




            estimatedMaxScrollOffset = Math.Dart:mathDefaultClass.Min(estimatedMaxScrollOffset, EstimateMaxScrollOffset(constraints, firstIndex: firstIndex, lastIndex: lastIndex, leadingScrollOffset: leadingScrollOffset, trailingScrollOffset: trailingScrollOffset));
            double paintExtent = CalculatePaintOffset(constraints, from: leadingScrollOffset, to: trailingScrollOffset);
            double cacheExtent = CalculateCacheOffset(constraints, from: leadingScrollOffset, to: trailingScrollOffset);
            double targetEndScrollOffsetForPaint = constraints.ScrollOffset + constraints.RemainingPaintExtent;
            int targetLastIndexForPaint = targetEndScrollOffsetForPaint.IsFinite() ? GetMaxChildIndexForScrollOffset(targetEndScrollOffsetForPaint, itemExtent) : null;
            Geometry = new SliverGeometry(scrollExtent: estimatedMaxScrollOffset, paintExtent: paintExtent, cacheExtent: cacheExtent, maxPaintExtent: estimatedMaxScrollOffset, hasVisualOverflow: (targetLastIndexForPaint != null && lastIndex >= targetLastIndexForPaint) || constraints.ScrollOffset > 0.0);
            if (estimatedMaxScrollOffset == trailingScrollOffset) ChildManager.SetDidUnderflow(true);
            ChildManager.DidFinishLayout();
        }



        #endregion
    }


    /// <Summary>
    /// A sliver that places multiple box children with the same main axis extent in
    /// a linear array.
    ///
    /// [RenderSliverFixedExtentList] places its children in a linear array along
    /// the main axis starting at offset zero and without gaps. Each child is forced
    /// to have the [itemExtent] in the main axis and the
    /// [SliverConstraints.crossAxisExtent] in the cross axis.
    ///
    /// [RenderSliverFixedExtentList] is more efficient than [RenderSliverList]
    /// because [RenderSliverFixedExtentList] does not need to perform layout on its
    /// children to obtain their extent in the main axis.
    ///
    /// See also:
    ///
    ///  * [RenderSliverList], which does not require its children to have the same
    ///    extent in the main axis.
    ///  * [RenderSliverFillViewport], which determines the [itemExtent] based on
    ///    [SliverConstraints.viewportMainAxisExtent].
    ///  * [RenderSliverFillRemaining], which determines the [itemExtent] based on
    ///    [SliverConstraints.remainingPaintExtent].
    /// </Summary>
    public class RenderSliverFixedExtentList : FlutterSDK.Rendering.Sliverfixedextentlist.RenderSliverFixedExtentBoxAdaptor
    {
        #region constructors
        public RenderSliverFixedExtentList(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager childManager = default(FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverBoxChildManager), double itemExtent = default(double))
        : base(childManager: childManager)
        {

        }
        #endregion

        #region fields
        internal virtual double _ItemExtent { get; set; }
        public virtual double ItemExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }

}
