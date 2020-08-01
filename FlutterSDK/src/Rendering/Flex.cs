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
namespace FlutterSDK.Rendering.Flex
{
    public delegate double _ChildSizingFunction(FlutterSDK.Rendering.Box.RenderBox child, double extent);
    internal static class FlexDefaultClass
    {
        internal static bool _StartIsTopLeft(FlutterSDK.Painting.Basictypes.Axis direction, TextDirection textDirection, FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection)
        {

            switch (direction) { case Axis.Horizontal: switch (textDirection) { case TextDirection.Ltr: return true; case TextDirection.Rtl: return false; } break; case Axis.Vertical: switch (verticalDirection) { case VerticalDirection.Down: return true; case VerticalDirection.Up: return false; } break; }
            return null;
        }



    }

    /// <Summary>
    /// Parent data for use with [RenderFlex].
    /// </Summary>
    public class FlexParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        public FlexParentData()
        { }
        /// <Summary>
        /// The flex factor to use for this child
        ///
        /// If null or zero, the child is inflexible and determines its own size. If
        /// non-zero, the amount of space the child's can occupy in the main axis is
        /// determined by dividing the free space (after placing the inflexible
        /// children) according to the flex factors of the flexible children.
        /// </Summary>
        public virtual int Flex { get; set; }
        /// <Summary>
        /// How a flexible child is inscribed into the available space.
        ///
        /// If [flex] is non-zero, the [fit] determines whether the child fills the
        /// space the parent makes available during layout. If the fit is
        /// [FlexFit.tight], the child is required to fill the available space. If the
        /// fit is [FlexFit.loose], the child can be at most as large as the available
        /// space (but is allowed to be smaller).
        /// </Summary>
        public virtual FlutterSDK.Rendering.Flex.FlexFit Fit { get; set; }

    }


    /// <Summary>
    /// Displays its children in a one-dimensional array.
    ///
    /// ## Layout algorithm
    ///
    /// _This section describes how the framework causes [RenderFlex] to position
    /// its children._
    /// _See [BoxConstraints] for an introduction to box layout models._
    ///
    /// Layout for a [RenderFlex] proceeds in six steps:
    ///
    /// 1. Layout each child a null or zero flex factor with unbounded main axis
    ///    constraints and the incoming cross axis constraints. If the
    ///    [crossAxisAlignment] is [CrossAxisAlignment.stretch], instead use tight
    ///    cross axis constraints that match the incoming max extent in the cross
    ///    axis.
    /// 2. Divide the remaining main axis space among the children with non-zero
    ///    flex factors according to their flex factor. For example, a child with a
    ///    flex factor of 2.0 will receive twice the amount of main axis space as a
    ///    child with a flex factor of 1.0.
    /// 3. Layout each of the remaining children with the same cross axis
    ///    constraints as in step 1, but instead of using unbounded main axis
    ///    constraints, use max axis constraints based on the amount of space
    ///    allocated in step 2. Children with [Flexible.fit] properties that are
    ///    [FlexFit.tight] are given tight constraints (i.e., forced to fill the
    ///    allocated space), and children with [Flexible.fit] properties that are
    ///    [FlexFit.loose] are given loose constraints (i.e., not forced to fill the
    ///    allocated space).
    /// 4. The cross axis extent of the [RenderFlex] is the maximum cross axis
    ///    extent of the children (which will always satisfy the incoming
    ///    constraints).
    /// 5. The main axis extent of the [RenderFlex] is determined by the
    ///    [mainAxisSize] property. If the [mainAxisSize] property is
    ///    [MainAxisSize.max], then the main axis extent of the [RenderFlex] is the
    ///    max extent of the incoming main axis constraints. If the [mainAxisSize]
    ///    property is [MainAxisSize.min], then the main axis extent of the [Flex]
    ///    is the sum of the main axis extents of the children (subject to the
    ///    incoming constraints).
    /// 6. Determine the position for each child according to the
    ///    [mainAxisAlignment] and the [crossAxisAlignment]. For example, if the
    ///    [mainAxisAlignment] is [MainAxisAlignment.spaceBetween], any main axis
    ///    space that has not been allocated to children is divided evenly and
    ///    placed between the children.
    ///
    /// See also:
    ///
    ///  * [Flex], the widget equivalent.
    ///  * [Row] and [Column], direction-specific variants of [Flex].
    /// </Summary>
    public class RenderFlex : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Flex.FlexParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Flex.FlexParentData>, IDebugOverflowIndicatorMixin
    {
        /// <Summary>
        /// Creates a flex render object.
        ///
        /// By default, the flex layout is horizontal and children are aligned to the
        /// start of the main axis and the center of the cross axis.
        /// </Summary>
        public RenderFlex(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline))
        : base()
        {

            AddAll(children);
        }


        internal virtual FlutterSDK.Painting.Basictypes.Axis _Direction { get; set; }
        internal virtual FlutterSDK.Rendering.Flex.MainAxisAlignment _MainAxisAlignment { get; set; }
        internal virtual FlutterSDK.Rendering.Flex.MainAxisSize _MainAxisSize { get; set; }
        internal virtual FlutterSDK.Rendering.Flex.CrossAxisAlignment _CrossAxisAlignment { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Painting.Basictypes.VerticalDirection _VerticalDirection { get; set; }
        internal virtual TextBaseline _TextBaseline { get; set; }
        internal virtual double _Overflow { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Direction { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Flex.MainAxisAlignment MainAxisAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Flex.MainAxisSize MainAxisSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Flex.CrossAxisAlignment CrossAxisAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection VerticalDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextBaseline TextBaseline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DebugHasNecessaryDirections { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is FlexParentData)) child.ParentData = new FlexParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is FlexParentData)) child.ParentData = new FlexParentData();
        }




        private double _GetIntrinsicSize(FlutterSDK.Painting.Basictypes.Axis sizingDirection = default(FlutterSDK.Painting.Basictypes.Axis), double extent = default(double), FlutterSDK.Rendering.Flex._ChildSizingFunction childSize = default(FlutterSDK.Rendering.Flex._ChildSizingFunction))
        {
            if (_Direction == sizingDirection)
            {
                double totalFlex = 0.0;
                double inflexibleSpace = 0.0;
                double maxFlexFractionSoFar = 0.0;
                RenderBox child = FirstChild;
                while (child != null)
                {
                    int flex = _GetFlex(child);
                    totalFlex += flex;
                    if (flex > 0)
                    {
                        double flexFraction = childSize(child, extent) / _GetFlex(child);
                        maxFlexFractionSoFar = Dart.Math.MathDefaultClass.Max(maxFlexFractionSoFar, flexFraction);
                    }
                    else
                    {
                        inflexibleSpace += childSize(child, extent);
                    }

                    FlexParentData childParentData = child.ParentData as FlexParentData;
                    child = childParentData.NextSibling;
                }

                return maxFlexFractionSoFar * totalFlex + inflexibleSpace;
            }
            else
            {
                double availableMainSpace = extent;
                int totalFlex = 0;
                double inflexibleSpace = 0.0;
                double maxCrossSize = 0.0;
                RenderBox child = FirstChild;
                while (child != null)
                {
                    int flex = _GetFlex(child);
                    totalFlex += flex;
                    double mainSize = default(double);
                    double crossSize = default(double);
                    if (flex == 0)
                    {
                        switch (_Direction) { case Axis.Horizontal: mainSize = child.GetMaxIntrinsicWidth(Dart.CoreDefaultClass.Double.Infinity); crossSize = childSize(child, mainSize); break; case Axis.Vertical: mainSize = child.GetMaxIntrinsicHeight(Dart.CoreDefaultClass.Double.Infinity); crossSize = childSize(child, mainSize); break; }
                        inflexibleSpace += mainSize;
                        maxCrossSize = Dart.Math.MathDefaultClass.Max(maxCrossSize, crossSize);
                    }

                    FlexParentData childParentData = child.ParentData as FlexParentData;
                    child = childParentData.NextSibling;
                }

                double spacePerFlex = Dart.Math.MathDefaultClass.Max(0.0, (availableMainSpace - inflexibleSpace) / totalFlex);
                child = FirstChild;
                while (child != null)
                {
                    int flex = _GetFlex(child);
                    if (flex > 0) maxCrossSize = Dart.Math.MathDefaultClass.Max(maxCrossSize, childSize(child, spacePerFlex * flex));
                    FlexParentData childParentData = child.ParentData as FlexParentData;
                    child = childParentData.NextSibling;
                }

                return maxCrossSize;
            }

        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return _GetIntrinsicSize(sizingDirection: Axis.Horizontal, extent: height, childSize: (RenderBox child, double extent) => =>child.GetMinIntrinsicWidth(extent));
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return _GetIntrinsicSize(sizingDirection: Axis.Horizontal, extent: height, childSize: (RenderBox child, double extent) => =>child.GetMaxIntrinsicWidth(extent));
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            return _GetIntrinsicSize(sizingDirection: Axis.Vertical, extent: width, childSize: (RenderBox child, double extent) => =>child.GetMinIntrinsicHeight(extent));
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return _GetIntrinsicSize(sizingDirection: Axis.Vertical, extent: width, childSize: (RenderBox child, double extent) => =>child.GetMaxIntrinsicHeight(extent));
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {
            if (_Direction == Axis.Horizontal) return DefaultComputeDistanceToHighestActualBaseline(baseline);
            return DefaultComputeDistanceToFirstActualBaseline(baseline);
        }




        private int _GetFlex(FlutterSDK.Rendering.Box.RenderBox child)
        {
            FlexParentData childParentData = child.ParentData as FlexParentData;
            return childParentData.Flex ?? 0;
        }




        private FlutterSDK.Rendering.Flex.FlexFit _GetFit(FlutterSDK.Rendering.Box.RenderBox child)
        {
            FlexParentData childParentData = child.ParentData as FlexParentData;
            return childParentData.Fit ?? FlexFit.Tight;
        }




        private double _GetCrossSize(FlutterSDK.Rendering.Box.RenderBox child)
        {
            switch (_Direction) { case Axis.Horizontal: return child.Size.Height; case Axis.Vertical: return child.Size.Width; }
            return null;
        }




        private double _GetMainSize(FlutterSDK.Rendering.Box.RenderBox child)
        {
            switch (_Direction) { case Axis.Horizontal: return child.Size.Width; case Axis.Vertical: return child.Size.Height; }
            return null;
        }




        public new void PerformLayout()
        {

            BoxConstraints constraints = this.Constraints;
            int totalFlex = 0;
            int totalChildren = 0;

            double maxMainSize = _Direction == Axis.Horizontal ? constraints.MaxWidth : constraints.MaxHeight;
            bool canFlex = maxMainSize < Dart.CoreDefaultClass.Double.Infinity;
            double crossSize = 0.0;
            double allocatedSize = 0.0;
            RenderBox child = FirstChild;
            RenderBox lastFlexChild = default(RenderBox);
            while (child != null)
            {
                FlexParentData childParentData = child.ParentData as FlexParentData;
                totalChildren++;
                int flex = _GetFlex(child);
                if (flex > 0)
                {

                    totalFlex += childParentData.Flex;
                    lastFlexChild = child;
                }
                else
                {
                    BoxConstraints innerConstraints = default(BoxConstraints);
                    if (CrossAxisAlignment == CrossAxisAlignment.Stretch)
                    {
                        switch (_Direction) { case Axis.Horizontal: innerConstraints = new BoxConstraints(minHeight: constraints.MaxHeight, maxHeight: constraints.MaxHeight); break; case Axis.Vertical: innerConstraints = new BoxConstraints(minWidth: constraints.MaxWidth, maxWidth: constraints.MaxWidth); break; }
                    }
                    else
                    {
                        switch (_Direction) { case Axis.Horizontal: innerConstraints = new BoxConstraints(maxHeight: constraints.MaxHeight); break; case Axis.Vertical: innerConstraints = new BoxConstraints(maxWidth: constraints.MaxWidth); break; }
                    }

                    child.Layout(innerConstraints, parentUsesSize: true);
                    allocatedSize += _GetMainSize(child);
                    crossSize = Dart.Math.MathDefaultClass.Max(crossSize, _GetCrossSize(child));
                }


                child = childParentData.NextSibling;
            }

            double freeSpace = Dart.Math.MathDefaultClass.Max(0.0, (canFlex ? maxMainSize : 0.0) - allocatedSize);
            double allocatedFlexSpace = 0.0;
            double maxBaselineDistance = 0.0;
            if (totalFlex > 0 || CrossAxisAlignment == CrossAxisAlignment.Baseline)
            {
                double spacePerFlex = canFlex && totalFlex > 0 ? (freeSpace / totalFlex) : Dart.CoreDefaultClass.Double.Nan;
                child = FirstChild;
                double maxSizeAboveBaseline = 0;
                double maxSizeBelowBaseline = 0;
                while (child != null)
                {
                    int flex = _GetFlex(child);
                    if (flex > 0)
                    {
                        double maxChildExtent = canFlex ? (child == lastFlexChild ? (freeSpace - allocatedFlexSpace) : spacePerFlex * flex) : Dart.CoreDefaultClass.Double.Infinity;
                        double minChildExtent = default(double);
                        switch (_GetFit(child)) { case FlexFit.Tight: minChildExtent = maxChildExtent; break; case FlexFit.Loose: minChildExtent = 0.0; break; }

                        BoxConstraints innerConstraints = default(BoxConstraints);
                        if (CrossAxisAlignment == CrossAxisAlignment.Stretch)
                        {
                            switch (_Direction) { case Axis.Horizontal: innerConstraints = new BoxConstraints(minWidth: minChildExtent, maxWidth: maxChildExtent, minHeight: constraints.MaxHeight, maxHeight: constraints.MaxHeight); break; case Axis.Vertical: innerConstraints = new BoxConstraints(minWidth: constraints.MaxWidth, maxWidth: constraints.MaxWidth, minHeight: minChildExtent, maxHeight: maxChildExtent); break; }
                        }
                        else
                        {
                            switch (_Direction) { case Axis.Horizontal: innerConstraints = new BoxConstraints(minWidth: minChildExtent, maxWidth: maxChildExtent, maxHeight: constraints.MaxHeight); break; case Axis.Vertical: innerConstraints = new BoxConstraints(maxWidth: constraints.MaxWidth, minHeight: minChildExtent, maxHeight: maxChildExtent); break; }
                        }

                        child.Layout(innerConstraints, parentUsesSize: true);
                        double childSize = _GetMainSize(child);

                        allocatedSize += childSize;
                        allocatedFlexSpace += maxChildExtent;
                        crossSize = Dart.Math.MathDefaultClass.Max(crossSize, _GetCrossSize(child));
                    }

                    if (CrossAxisAlignment == CrossAxisAlignment.Baseline)
                    {

                        double distance = child.GetDistanceToBaseline(TextBaseline, onlyReal: true);
                        if (distance != null)
                        {
                            maxBaselineDistance = Dart.Math.MathDefaultClass.Max(maxBaselineDistance, distance);
                            maxSizeAboveBaseline = Dart.Math.MathDefaultClass.Max(distance, maxSizeAboveBaseline);
                            maxSizeBelowBaseline = Dart.Math.MathDefaultClass.Max(child.Size.Height - distance, maxSizeBelowBaseline);
                            crossSize = maxSizeAboveBaseline + maxSizeBelowBaseline;
                        }

                    }

                    FlexParentData childParentData = child.ParentData as FlexParentData;
                    child = childParentData.NextSibling;
                }

            }

            double idealSize = canFlex && MainAxisSize == MainAxisSize.Max ? maxMainSize : allocatedSize;
            double actualSize = default(double);
            double actualSizeDelta = default(double);
            switch (_Direction) { case Axis.Horizontal: Size = constraints.Constrain(new Size(idealSize, crossSize)); actualSize = Size.Width; crossSize = Size.Height; break; case Axis.Vertical: Size = constraints.Constrain(new Size(crossSize, idealSize)); actualSize = Size.Height; crossSize = Size.Width; break; }
            actualSizeDelta = actualSize - allocatedSize;
            _Overflow = Dart.Math.MathDefaultClass.Max(0.0, -actualSizeDelta);
            double remainingSpace = Dart.Math.MathDefaultClass.Max(0.0, actualSizeDelta);
            double leadingSpace = default(double);
            double betweenSpace = default(double);
            bool flipMainAxis = !(FlexDefaultClass._StartIsTopLeft(Direction, TextDirection, VerticalDirection) ?? true);
            switch (_MainAxisAlignment) { case MainAxisAlignment.Start: leadingSpace = 0.0; betweenSpace = 0.0; break; case MainAxisAlignment.End: leadingSpace = remainingSpace; betweenSpace = 0.0; break; case MainAxisAlignment.Center: leadingSpace = remainingSpace / 2.0; betweenSpace = 0.0; break; case MainAxisAlignment.SpaceBetween: leadingSpace = 0.0; betweenSpace = totalChildren > 1 ? remainingSpace / (totalChildren - 1) : 0.0; break; case MainAxisAlignment.SpaceAround: betweenSpace = totalChildren > 0 ? remainingSpace / totalChildren : 0.0; leadingSpace = betweenSpace / 2.0; break; case MainAxisAlignment.SpaceEvenly: betweenSpace = totalChildren > 0 ? remainingSpace / (totalChildren + 1) : 0.0; leadingSpace = betweenSpace; break; }
            double childMainPosition = flipMainAxis ? actualSize - leadingSpace : leadingSpace;
            child = FirstChild;
            while (child != null)
            {
                FlexParentData childParentData = child.ParentData as FlexParentData;
                double childCrossPosition = default(double);
                switch (_CrossAxisAlignment)
                {
                    case CrossAxisAlignment.Start: case CrossAxisAlignment.End: childCrossPosition = FlexDefaultClass._StartIsTopLeft(BasictypesDefaultClass.FlipAxis(Direction), TextDirection, VerticalDirection) == (_CrossAxisAlignment == CrossAxisAlignment.Start) ? 0.0 : crossSize - _GetCrossSize(child); break;
                    case CrossAxisAlignment.Center: childCrossPosition = crossSize / 2.0 - _GetCrossSize(child) / 2.0; break;
                    case CrossAxisAlignment.Stretch: childCrossPosition = 0.0; break;
                    case CrossAxisAlignment.Baseline:
                        childCrossPosition = 0.0; if (_Direction == Axis.Horizontal)
                        {

                            double distance = child.GetDistanceToBaseline(TextBaseline, onlyReal: true);
                            if (distance != null) childCrossPosition = maxBaselineDistance - distance;
                        }
                        break;
                }
                if (flipMainAxis) childMainPosition -= _GetMainSize(child);
                switch (_Direction) { case Axis.Horizontal: childParentData.Offset = new Offset(childMainPosition, childCrossPosition); break; case Axis.Vertical: childParentData.Offset = new Offset(childCrossPosition, childMainPosition); break; }
                if (flipMainAxis)
                {
                    childMainPosition -= betweenSpace;
                }
                else
                {
                    childMainPosition += _GetMainSize(child) + betweenSpace;
                }

                child = childParentData.NextSibling;
            }

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            return DefaultHitTestChildren(result, position: position);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (!_HasOverflow)
            {
                DefaultPaint(context, offset);
                return;
            }

            if (Size.IsEmpty()) return;
            context.PushClipRect(NeedsCompositing, offset, Dart.UI.UiDefaultClass.Offset.Zero & Size, DefaultPaint);

        }




        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) => _HasOverflow ? Dart.UiDefaultClass.Offset.Zero & Size : null;



        public new string ToStringShort()
        {
            string header = base.ToStringShort();
            if (_Overflow is double && _HasOverflow) header += " OVERFLOWING";
            return header;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<Axis>("direction", Direction));
            properties.Add(new EnumProperty<MainAxisAlignment>("mainAxisAlignment", MainAxisAlignment));
            properties.Add(new EnumProperty<MainAxisSize>("mainAxisSize", MainAxisSize));
            properties.Add(new EnumProperty<CrossAxisAlignment>("crossAxisAlignment", CrossAxisAlignment));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            properties.Add(new EnumProperty<VerticalDirection>("verticalDirection", VerticalDirection, defaultValue: null));
            properties.Add(new EnumProperty<TextBaseline>("textBaseline", TextBaseline, defaultValue: null));
        }



    }


    /// <Summary>
    /// How the child is inscribed into the available space.
    ///
    /// See also:
    ///
    ///  * [RenderFlex], the flex render object.
    ///  * [Column], [Row], and [Flex], the flex widgets.
    ///  * [Expanded], the widget equivalent of [tight].
    ///  * [Flexible], the widget equivalent of [loose].
    /// </Summary>
    public enum FlexFit
    {

        /// <Summary>
        /// The child is forced to fill the available space.
        ///
        /// The [Expanded] widget assigns this kind of [FlexFit] to its child.
        /// </Summary>
        Tight,
        /// <Summary>
        /// The child can be at most as large as the available space (but is
        /// allowed to be smaller).
        ///
        /// The [Flexible] widget assigns this kind of [FlexFit] to its child.
        /// </Summary>
        Loose,
    }


    /// <Summary>
    /// How much space should be occupied in the main axis.
    ///
    /// During a flex layout, available space along the main axis is allocated to
    /// children. After allocating space, there might be some remaining free space.
    /// This value controls whether to maximize or minimize the amount of free
    /// space, subject to the incoming layout constraints.
    ///
    /// See also:
    ///
    ///  * [Column], [Row], and [Flex], the flex widgets.
    ///  * [Expanded] and [Flexible], the widgets that controls a flex widgets'
    ///    children's flex.
    ///  * [RenderFlex], the flex render object.
    ///  * [MainAxisAlignment], which controls how the free space is distributed.
    /// </Summary>
    public enum MainAxisSize
    {

        /// <Summary>
        /// Minimize the amount of free space along the main axis, subject to the
        /// incoming layout constraints.
        ///
        /// If the incoming layout constraints have a large enough
        /// [BoxConstraints.minWidth] or [BoxConstraints.minHeight], there might still
        /// be a non-zero amount of free space.
        ///
        /// If the incoming layout constraints are unbounded, and any children have a
        /// non-zero [FlexParentData.flex] and a [FlexFit.tight] fit (as applied by
        /// [Expanded]), the [RenderFlex] will assert, because there would be infinite
        /// remaining free space and boxes cannot be given infinite size.
        /// </Summary>
        Min,
        /// <Summary>
        /// Maximize the amount of free space along the main axis, subject to the
        /// incoming layout constraints.
        ///
        /// If the incoming layout constraints have a small enough
        /// [BoxConstraints.maxWidth] or [BoxConstraints.maxHeight], there might still
        /// be no free space.
        ///
        /// If the incoming layout constraints are unbounded, the [RenderFlex] will
        /// assert, because there would be infinite remaining free space and boxes
        /// cannot be given infinite size.
        /// </Summary>
        Max,
    }


    /// <Summary>
    /// How the children should be placed along the main axis in a flex layout.
    ///
    /// See also:
    ///
    ///  * [Column], [Row], and [Flex], the flex widgets.
    ///  * [RenderFlex], the flex render object.
    /// </Summary>
    public enum MainAxisAlignment
    {

        /// <Summary>
        /// Place the children as close to the start of the main axis as possible.
        ///
        /// If this value is used in a horizontal direction, a [TextDirection] must be
        /// available to determine if the start is the left or the right.
        ///
        /// If this value is used in a vertical direction, a [VerticalDirection] must be
        /// available to determine if the start is the top or the bottom.
        /// </Summary>
        Start,
        /// <Summary>
        /// Place the children as close to the end of the main axis as possible.
        ///
        /// If this value is used in a horizontal direction, a [TextDirection] must be
        /// available to determine if the end is the left or the right.
        ///
        /// If this value is used in a vertical direction, a [VerticalDirection] must be
        /// available to determine if the end is the top or the bottom.
        /// </Summary>
        End,
        /// <Summary>
        /// Place the children as close to the middle of the main axis as possible.
        /// </Summary>
        Center,
        /// <Summary>
        /// Place the free space evenly between the children.
        /// </Summary>
        SpaceBetween,
        /// <Summary>
        /// Place the free space evenly between the children as well as half of that
        /// space before and after the first and last child.
        /// </Summary>
        SpaceAround,
        /// <Summary>
        /// Place the free space evenly between the children as well as before and
        /// after the first and last child.
        /// </Summary>
        SpaceEvenly,
    }


    /// <Summary>
    /// How the children should be placed along the cross axis in a flex layout.
    ///
    /// See also:
    ///
    ///  * [Column], [Row], and [Flex], the flex widgets.
    ///  * [RenderFlex], the flex render object.
    /// </Summary>
    public enum CrossAxisAlignment
    {

        /// <Summary>
        /// Place the children with their start edge aligned with the start side of
        /// the cross axis.
        ///
        /// For example, in a column (a flex with a vertical axis) whose
        /// [TextDirection] is [TextDirection.ltr], this aligns the left edge of the
        /// children along the left edge of the column.
        ///
        /// If this value is used in a horizontal direction, a [TextDirection] must be
        /// available to determine if the start is the left or the right.
        ///
        /// If this value is used in a vertical direction, a [VerticalDirection] must be
        /// available to determine if the start is the top or the bottom.
        /// </Summary>
        Start,
        /// <Summary>
        /// Place the children as close to the end of the cross axis as possible.
        ///
        /// For example, in a column (a flex with a vertical axis) whose
        /// [TextDirection] is [TextDirection.ltr], this aligns the right edge of the
        /// children along the right edge of the column.
        ///
        /// If this value is used in a horizontal direction, a [TextDirection] must be
        /// available to determine if the end is the left or the right.
        ///
        /// If this value is used in a vertical direction, a [VerticalDirection] must be
        /// available to determine if the end is the top or the bottom.
        /// </Summary>
        End,
        /// <Summary>
        /// Place the children so that their centers align with the middle of the
        /// cross axis.
        ///
        /// This is the default cross-axis alignment.
        /// </Summary>
        Center,
        /// <Summary>
        /// Require the children to fill the cross axis.
        ///
        /// This causes the constraints passed to the children to be tight in the
        /// cross axis.
        /// </Summary>
        Stretch,
        /// <Summary>
        /// Place the children along the cross axis such that their baselines match.
        ///
        /// If the main axis is vertical, then this value is treated like [start]
        /// (since baselines are always horizontal).
        /// </Summary>
        Baseline,
    }

}
