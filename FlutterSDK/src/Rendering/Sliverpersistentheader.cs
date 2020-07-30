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
namespace FlutterSDK.Rendering.Sliverpersistentheader
{
    internal static class SliverpersistentheaderDefaultClass
    {
    }

    /// <Summary>
    /// A base class for slivers that have a [RenderBox] child which scrolls
    /// normally, except that when it hits the leading edge (typically the top) of
    /// the viewport, it shrinks to a minimum size ([minExtent]).
    ///
    /// This class primarily provides helpers for managing the child, in particular:
    ///
    ///  * [layoutChild], which applies min and max extents and a scroll offset to
    ///    lay out the child. This is normally called from [performLayout].
    ///
    ///  * [childExtent], to convert the child's box layout dimensions to the sliver
    ///    geometry model.
    ///
    ///  * hit testing, painting, and other details of the sliver protocol.
    ///
    /// Subclasses must implement [performLayout], [minExtent], and [maxExtent], and
    /// typically also will implement [updateChild].
    /// </Summary>
    public interface IRenderSliverPersistentHeader
    {
        void UpdateChild(double shrinkOffset, bool overlapsContent);
        void MarkNeedsLayout();
        void LayoutChild(double scrollOffset, double maxExtent, bool overlapsContent = false);
        double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child);
        bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration StretchConfiguration { get; set; }
        double MaxExtent { get; }
        double MinExtent { get; }
        double ChildExtent { get; }
        bool ExcludeFromSemanticsScrolling { get; set; }
    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which scrolls normally, except that when
    /// it hits the leading edge (typically the top) of the viewport, it shrinks to
    /// a minimum size before continuing to scroll.
    ///
    /// This sliver makes no effort to avoid overlapping other content.
    /// </Summary>
    public interface IRenderSliverScrollingPersistentHeader
    {
        double UpdateGeometry();
        void PerformLayout();
        double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child);
    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which never scrolls off the viewport in
    /// the positive scroll direction, and which first scrolls on at a full size but
    /// then shrinks as the viewport continues to scroll.
    ///
    /// This sliver avoids overlapping other earlier slivers where possible.
    /// </Summary>
    public interface IRenderSliverPinnedPersistentHeader
    {
        void PerformLayout();
        double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child);
    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which shrinks and scrolls like a
    /// [RenderSliverScrollingPersistentHeader], but immediately comes back when the
    /// user scrolls in the reverse direction.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFloatingPinnedPersistentHeader], which is similar but sticks
    ///    to the start of the viewport rather than scrolling off.
    /// </Summary>
    public interface IRenderSliverFloatingPersistentHeader
    {
        void Detach();
        double UpdateGeometry();
        void MaybeStartSnapAnimation(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction);
        void MaybeStopSnapAnimation(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction);
        void PerformLayout();
        double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration SnapConfiguration { get; set; }
    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which shrinks and then remains pinned to
    /// the start of the viewport like a [RenderSliverPinnedPersistentHeader], but
    /// immediately grows when the user scrolls in the reverse direction.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFloatingPersistentHeader], which is similar but scrolls off
    ///    the top rather than sticking to it.
    /// </Summary>
    public interface IRenderSliverFloatingPinnedPersistentHeader
    {
        double UpdateGeometry();
    }


    /// <Summary>
    /// Specifies how a stretched header is to trigger an [AsyncCallback].
    ///
    /// See also:
    ///
    ///  * [SliverAppBar], which creates a header that can be stretched into an
    ///    overscroll area and trigger a callback function.
    /// </Summary>
    public class OverScrollHeaderStretchConfiguration
    {
        public OverScrollHeaderStretchConfiguration(double stretchTriggerOffset = 100.0, FlutterSDK.Foundation.Basictypes.AsyncCallback onStretchTrigger = default(FlutterSDK.Foundation.Basictypes.AsyncCallback))
        : base()
        {
            this.StretchTriggerOffset = stretchTriggerOffset;
            this.OnStretchTrigger = onStretchTrigger;
        }
        public virtual double StretchTriggerOffset { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.AsyncCallback OnStretchTrigger { get; set; }
    }


    /// <Summary>
    /// A base class for slivers that have a [RenderBox] child which scrolls
    /// normally, except that when it hits the leading edge (typically the top) of
    /// the viewport, it shrinks to a minimum size ([minExtent]).
    ///
    /// This class primarily provides helpers for managing the child, in particular:
    ///
    ///  * [layoutChild], which applies min and max extents and a scroll offset to
    ///    lay out the child. This is normally called from [performLayout].
    ///
    ///  * [childExtent], to convert the child's box layout dimensions to the sliver
    ///    geometry model.
    ///
    ///  * hit testing, painting, and other details of the sliver protocol.
    ///
    /// Subclasses must implement [performLayout], [minExtent], and [maxExtent], and
    /// typically also will implement [updateChild].
    /// </Summary>
    public class RenderSliverPersistentHeader : FlutterSDK.Rendering.Sliver.RenderSliver, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>, IRenderSliverHelpers
    {
        public RenderSliverPersistentHeader(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        {
            this.StretchConfiguration = stretchConfiguration;
            this.Child = child;
        }


        internal virtual double _LastStretchOffset { get; set; }
        internal virtual bool _NeedsUpdateChild { get; set; }
        internal virtual double _LastShrinkOffset { get; set; }
        internal virtual bool _LastOverlapsContent { get; set; }
        public virtual FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration StretchConfiguration { get; set; }
        internal virtual bool _ExcludeFromSemanticsScrolling { get; set; }
        public virtual double MaxExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MinExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ChildExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ExcludeFromSemanticsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Update the child render object if necessary.
        ///
        /// Called before the first layout, any time [markNeedsLayout] is called, and
        /// any time the scroll offset changes. The `shrinkOffset` is the difference
        /// between the [maxExtent] and the current size. Zero means the header is
        /// fully expanded, any greater number up to [maxExtent] means that the header
        /// has been scrolled by that much. The `overlapsContent` argument is true if
        /// the sliver's leading edge is beyond its normal place in the viewport
        /// contents, and false otherwise. It may still paint beyond its normal place
        /// if the [minExtent] after this call is greater than the amount of space that
        /// would normally be left.
        ///
        /// The render object will size itself to the larger of (a) the [maxExtent]
        /// minus the child's intrinsic height and (b) the [maxExtent] minus the
        /// shrink offset.
        ///
        /// When this method is called by [layoutChild], the [child] can be set,
        /// mutated, or replaced. (It should not be called outside [layoutChild].)
        ///
        /// Any time this method would mutate the child, call [markNeedsLayout].
        /// </Summary>
        public virtual void UpdateChild(double shrinkOffset, bool overlapsContent)
        {
        }




        public new void MarkNeedsLayout()
        {
            _NeedsUpdateChild = true;
            base.MarkNeedsLayout();
        }




        /// <Summary>
        /// Lays out the [child].
        ///
        /// This is called by [performLayout]. It applies the given `scrollOffset`
        /// (which need not match the offset given by the [constraints]) and the
        /// `maxExtent` (which need not match the value returned by the [maxExtent]
        /// getter).
        ///
        /// The `overlapsContent` argument is passed to [updateChild].
        /// </Summary>
        public virtual void LayoutChild(double scrollOffset, double maxExtent, bool overlapsContent = false)
        {

            double shrinkOffset = Dart.Math.MathDefaultClass.Min(scrollOffset, maxExtent);
            if (_NeedsUpdateChild || _LastShrinkOffset != shrinkOffset || _LastOverlapsContent != overlapsContent)
            {
                InvokeLayoutCallback((SliverConstraints constraints) =>
                {

                    UpdateChild(shrinkOffset, overlapsContent);
                }
                );
                _LastShrinkOffset = shrinkOffset;
                _LastOverlapsContent = overlapsContent;
                _NeedsUpdateChild = false;
            }



            double stretchOffset = 0.0;
            if (StretchConfiguration != null && ChildMainAxisPosition(Child) == 0.0) stretchOffset += Constraints.Overlap.Abs();
            Child?.Layout(Constraints.AsBoxConstraints(maxExtent: Dart.Math.MathDefaultClass.Max(MinExtent, maxExtent - shrinkOffset) + stretchOffset), parentUsesSize: true);
            if (StretchConfiguration != null && StretchConfiguration.OnStretchTrigger != null && stretchOffset >= StretchConfiguration.StretchTriggerOffset && _LastStretchOffset <= StretchConfiguration.StretchTriggerOffset)
            {
                StretchConfiguration.OnStretchTrigger();
            }

            _LastStretchOffset = stretchOffset;
        }




        /// <Summary>
        /// Returns the distance from the leading _visible_ edge of the sliver to the
        /// side of the child closest to that edge, in the scroll axis direction.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the top
        /// of the visible portion of the sliver to the top of the child. If the child
        /// is scrolled partially off the top of the viewport, then this will be
        /// negative. On the other hand, if the [constraints] describe this sliver as
        /// having an axis direction of [AxisDirection.up], then this is the distance
        /// from the bottom of the visible portion of the sliver to the bottom of the
        /// child. In both cases, this is the direction of increasing
        /// [SliverConstraints.scrollOffset].
        ///
        /// Calling this when the child is not visible is not valid.
        ///
        /// The argument must be the value of the [child] property.
        ///
        /// This must be implemented by [RenderSliverPersistentHeader] subclasses.
        ///
        /// If there is no child, this should return 0.0.
        /// </Summary>
        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) => base.ChildMainAxisPosition(child);



        public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        {

            if (Child != null) return HitTestBoxChild(BoxHitTestResult.Wrap(result), Child, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
            return false;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {


            ApplyPaintTransformForBoxChild(child as RenderBox, transform);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child != null && Geometry.Visible)
            {

                switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(Constraints.AxisDirection, Constraints.GrowthDirection)) { case AxisDirection.Up: offset += new Offset(0.0, Geometry.PaintExtent - ChildMainAxisPosition(Child) - ChildExtent); break; case AxisDirection.Down: offset += new Offset(0.0, ChildMainAxisPosition(Child)); break; case AxisDirection.Left: offset += new Offset(Geometry.PaintExtent - ChildMainAxisPosition(Child) - ChildExtent, 0.0); break; case AxisDirection.Right: offset += new Offset(ChildMainAxisPosition(Child), 0.0); break; }
                context.PaintChild(Child, offset);
            }

        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            if (_ExcludeFromSemanticsScrolling) config.AddTagForChildren(ViewportDefaultClass.RenderViewport.ExcludeFromScrolling);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(DoubleProperty.Lazy("maxExtent", () => =>MaxExtent));
            properties.Add(DoubleProperty.Lazy("child position", () => =>ChildMainAxisPosition(Child)));
        }



    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which scrolls normally, except that when
    /// it hits the leading edge (typically the top) of the viewport, it shrinks to
    /// a minimum size before continuing to scroll.
    ///
    /// This sliver makes no effort to avoid overlapping other content.
    /// </Summary>
    public class RenderSliverScrollingPersistentHeader : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverPersistentHeader
    {
        public RenderSliverScrollingPersistentHeader(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, stretchConfiguration: stretchConfiguration)
        {

        }
        internal virtual double _ChildPosition { get; set; }

        /// <Summary>
        /// Updates [geometry], and returns the new value for [childMainAxisPosition].
        ///
        /// This is used by [performLayout].
        /// </Summary>
        public virtual double UpdateGeometry()
        {
            double stretchOffset = 0.0;
            if (StretchConfiguration != null && _ChildPosition == 0.0)
            {
                stretchOffset += Constraints.Overlap.Abs();
            }

            double maxExtent = this.MaxExtent;
            double paintExtent = maxExtent - Constraints.ScrollOffset;
            Geometry = new SliverGeometry(scrollExtent: maxExtent, paintOrigin: Dart.Math.MathDefaultClass.Min(Constraints.Overlap, 0.0), paintExtent: paintExtent.Clamp(0.0, Constraints.RemainingPaintExtent) as double, maxPaintExtent: maxExtent + stretchOffset, hasVisualOverflow: true);
            return stretchOffset > 0 ? 0.0 : Dart.Math.MathDefaultClass.Min(0.0, paintExtent - ChildExtent);
        }




        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;
            double maxExtent = this.MaxExtent;
            LayoutChild(constraints.ScrollOffset, maxExtent);
            double paintExtent = maxExtent - constraints.ScrollOffset;
            Geometry = new SliverGeometry(scrollExtent: maxExtent, paintOrigin: Dart.Math.MathDefaultClass.Min(constraints.Overlap, 0.0), paintExtent: paintExtent.Clamp(0.0, constraints.RemainingPaintExtent) as double, maxPaintExtent: maxExtent, hasVisualOverflow: true);
            _ChildPosition = UpdateGeometry();
        }




        public new double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child)
        {

            return _ChildPosition;
        }


        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return _ChildPosition;
        }



    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which never scrolls off the viewport in
    /// the positive scroll direction, and which first scrolls on at a full size but
    /// then shrinks as the viewport continues to scroll.
    ///
    /// This sliver avoids overlapping other earlier slivers where possible.
    /// </Summary>
    public class RenderSliverPinnedPersistentHeader : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverPersistentHeader
    {
        public RenderSliverPinnedPersistentHeader(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, stretchConfiguration: stretchConfiguration)
        {

        }

        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;
            double maxExtent = this.MaxExtent;
            bool overlapsContent = constraints.Overlap > 0.0;
            ExcludeFromSemanticsScrolling = overlapsContent || (constraints.ScrollOffset > maxExtent - MinExtent);
            LayoutChild(constraints.ScrollOffset, maxExtent, overlapsContent: overlapsContent);
            double effectiveRemainingPaintExtent = Dart.Math.MathDefaultClass.Max(0, constraints.RemainingPaintExtent - constraints.Overlap);
            double layoutExtent = (maxExtent - constraints.ScrollOffset).Clamp(0.0, effectiveRemainingPaintExtent) as double;
            double stretchOffset = StretchConfiguration != null ? constraints.Overlap.Abs() : 0.0;
            Geometry = new SliverGeometry(scrollExtent: maxExtent, paintOrigin: constraints.Overlap, paintExtent: Dart.Math.MathDefaultClass.Min(ChildExtent, effectiveRemainingPaintExtent), layoutExtent: layoutExtent, maxPaintExtent: maxExtent + stretchOffset, maxScrollObstructionExtent: MinExtent, cacheExtent: layoutExtent > 0.0 ? -constraints.CacheOrigin + layoutExtent : layoutExtent, hasVisualOverflow: true);
        }




        public new double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child) => 0.0;

        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) => 0.0;


    }


    /// <Summary>
    /// Specifies how a floating header is to be "snapped" (animated) into or out
    /// of view.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFloatingPersistentHeader.maybeStartSnapAnimation] and
    ///    [RenderSliverFloatingPersistentHeader.maybeStopSnapAnimation], which
    ///    start or stop the floating header's animation.
    ///  * [SliverAppBar], which creates a header that can be pinned, floating,
    ///    and snapped into view via the corresponding parameters.
    /// </Summary>
    public class FloatingHeaderSnapConfiguration
    {
        public FloatingHeaderSnapConfiguration(FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan))
        : base()
        {
            this.Vsync = vsync;
            this.Curve = curve;
            this.Duration = duration;
        }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
        public virtual TimeSpan Duration { get; set; }
    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which shrinks and scrolls like a
    /// [RenderSliverScrollingPersistentHeader], but immediately comes back when the
    /// user scrolls in the reverse direction.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFloatingPinnedPersistentHeader], which is similar but sticks
    ///    to the start of the viewport rather than scrolling off.
    /// </Summary>
    public class RenderSliverFloatingPersistentHeader : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverPersistentHeader
    {
        public RenderSliverFloatingPersistentHeader(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration snapConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, stretchConfiguration: stretchConfiguration)
        {

        }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
        internal virtual double _LastActualScrollOffset { get; set; }
        internal virtual double _EffectiveScrollOffset { get; set; }
        internal virtual double _ChildPosition { get; set; }
        internal virtual FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration _SnapConfiguration { get; set; }
        public virtual FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration SnapConfiguration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Detach()
        {
            _Controller?.Dispose();
            _Controller = null;
            base.Detach();
        }




        /// <Summary>
        /// Updates [geometry], and returns the new value for [childMainAxisPosition].
        ///
        /// This is used by [performLayout].
        /// </Summary>
        public virtual double UpdateGeometry()
        {
            double stretchOffset = 0.0;
            if (StretchConfiguration != null && _ChildPosition == 0.0)
            {
                stretchOffset += Constraints.Overlap.Abs();
            }

            double maxExtent = this.MaxExtent;
            double paintExtent = maxExtent - _EffectiveScrollOffset;
            double layoutExtent = maxExtent - Constraints.ScrollOffset;
            Geometry = new SliverGeometry(scrollExtent: maxExtent, paintOrigin: Dart.Math.MathDefaultClass.Min(Constraints.Overlap, 0.0), paintExtent: paintExtent.Clamp(0.0, Constraints.RemainingPaintExtent) as double, layoutExtent: layoutExtent.Clamp(0.0, Constraints.RemainingPaintExtent) as double, maxPaintExtent: maxExtent + stretchOffset, hasVisualOverflow: true);
            return stretchOffset > 0 ? 0.0 : Dart.Math.MathDefaultClass.Min(0.0, paintExtent - ChildExtent);
        }




        /// <Summary>
        /// If the header isn't already fully exposed, then scroll it into view.
        /// </Summary>
        public virtual void MaybeStartSnapAnimation(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction)
        {
            if (SnapConfiguration == null) return;
            if (direction == ScrollDirection.Forward && _EffectiveScrollOffset <= 0.0) return;
            if (direction == ScrollDirection.Reverse && _EffectiveScrollOffset >= MaxExtent) return;
            TickerProvider vsync = SnapConfiguration.Vsync;
            TimeSpan duration = SnapConfiguration.Duration;
            _Controller = (_Controller == null ? new AnimationController(vsync: vsync, duration: duration);
            new AnimationController(vsync: vsync, duration: duration).AddListener(() =>
            {
                if (_EffectiveScrollOffset == _Animation.Value) return;
                _EffectiveScrollOffset = _Animation.Value;
                MarkNeedsLayout();
            }
            ) : _Controller );
            _Animation = _Controller.Drive(new Tween<double>(begin: _EffectiveScrollOffset, end: direction == ScrollDirection.Forward ? 0.0 : MaxExtent).Chain(new CurveTween(curve: SnapConfiguration.Curve)));
            _Controller.Forward(from: 0.0);
        }




        /// <Summary>
        /// If a header snap animation is underway then stop it.
        /// </Summary>
        public virtual void MaybeStopSnapAnimation(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction)
        {
            _Controller?.Stop();
        }




        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;
            double maxExtent = this.MaxExtent;
            if (_LastActualScrollOffset != null && ((constraints.ScrollOffset < _LastActualScrollOffset) || (_EffectiveScrollOffset < maxExtent)))
            {
                double delta = _LastActualScrollOffset - constraints.ScrollOffset;
                bool allowFloatingExpansion = constraints.UserScrollDirection == ScrollDirection.Forward;
                if (allowFloatingExpansion)
                {
                    if (_EffectiveScrollOffset > maxExtent) _EffectiveScrollOffset = maxExtent;
                }
                else
                {
                    if (delta > 0.0) delta = 0.0;
                }

                _EffectiveScrollOffset = (_EffectiveScrollOffset - delta).Clamp(0.0, constraints.ScrollOffset) as double;
            }
            else
            {
                _EffectiveScrollOffset = constraints.ScrollOffset;
            }

            ExcludeFromSemanticsScrolling = _EffectiveScrollOffset <= constraints.ScrollOffset;
            bool overlapsContent = _EffectiveScrollOffset < constraints.ScrollOffset;
            LayoutChild(_EffectiveScrollOffset, maxExtent, overlapsContent: overlapsContent);
            _ChildPosition = UpdateGeometry();
            _LastActualScrollOffset = constraints.ScrollOffset;
        }




        public new double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child)
        {

            return _ChildPosition;
        }


        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return _ChildPosition;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("effective scroll offset", _EffectiveScrollOffset));
        }



    }


    /// <Summary>
    /// A sliver with a [RenderBox] child which shrinks and then remains pinned to
    /// the start of the viewport like a [RenderSliverPinnedPersistentHeader], but
    /// immediately grows when the user scrolls in the reverse direction.
    ///
    /// See also:
    ///
    ///  * [RenderSliverFloatingPersistentHeader], which is similar but scrolls off
    ///    the top rather than sticking to it.
    /// </Summary>
    public class RenderSliverFloatingPinnedPersistentHeader : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverFloatingPersistentHeader
    {
        public RenderSliverFloatingPinnedPersistentHeader(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration snapConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, snapConfiguration: snapConfiguration, stretchConfiguration: stretchConfiguration)
        {

        }

        public new double UpdateGeometry()
        {
            double minExtent = this.MinExtent;
            double minAllowedExtent = Constraints.RemainingPaintExtent > minExtent ? minExtent : Constraints.RemainingPaintExtent;
            double maxExtent = this.MaxExtent;
            double paintExtent = maxExtent - _EffectiveScrollOffset;
            double clampedPaintExtent = paintExtent.Clamp(minAllowedExtent, Constraints.RemainingPaintExtent) as double;
            double layoutExtent = maxExtent - Constraints.ScrollOffset;
            double stretchOffset = StretchConfiguration != null ? Constraints.Overlap.Abs() : 0.0;
            Geometry = new SliverGeometry(scrollExtent: maxExtent, paintOrigin: Dart.Math.MathDefaultClass.Min(Constraints.Overlap, 0.0), paintExtent: clampedPaintExtent, layoutExtent: layoutExtent.Clamp(0.0, clampedPaintExtent) as double, maxPaintExtent: maxExtent + stretchOffset, maxScrollObstructionExtent: maxExtent, hasVisualOverflow: true);
            return 0.0;
        }



    }

}
