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
namespace FlutterSDK.Rendering.Viewportoffset
{
    internal static class ViewportoffsetDefaultClass
    {
        internal static FlutterSDK.Rendering.Viewportoffset.ScrollDirection FlipScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Which part of the content inside the viewport should be visible.
    ///
    /// The [pixels] value determines the scroll offset that the viewport uses to
    /// select which part of its content to display. As the user scrolls the
    /// viewport, this value changes, which changes the content that is displayed.
    ///
    /// This object is a [Listenable] that notifies its listeners when [pixels]
    /// changes.
    ///
    /// See also:
    ///
    ///  * [ScrollPosition], which is a commonly used concrete subclass.
    ///  * [RenderViewportBase], which is a render object that uses viewport
    ///    offsets.
    /// </Summary>
    public interface IViewportOffset
    {
        bool ApplyViewportDimension(double viewportDimension);
        bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent);
        void CorrectBy(double correction);
        void JumpTo(double pixels);
        Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        Future<object> MoveTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), bool clamp = default(bool));
        string ToString();
        void DebugFillDescription(List<string> description);
        double Pixels { get; }
        FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection { get; }
        bool AllowImplicitScrolling { get; }
    }


    /// <Summary>
    /// Which part of the content inside the viewport should be visible.
    ///
    /// The [pixels] value determines the scroll offset that the viewport uses to
    /// select which part of its content to display. As the user scrolls the
    /// viewport, this value changes, which changes the content that is displayed.
    ///
    /// This object is a [Listenable] that notifies its listeners when [pixels]
    /// changes.
    ///
    /// See also:
    ///
    ///  * [ScrollPosition], which is a commonly used concrete subclass.
    ///  * [RenderViewportBase], which is a render object that uses viewport
    ///    offsets.
    /// </Summary>
    public class ViewportOffset : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        #region constructors
        public ViewportOffset()
        {

        }
        public static ViewportOffset Fixed(double value)
        {
            var instance = new ViewportOffset();
        }
        public static ViewportOffset Zero()
        {
            var instance = new ViewportOffset();
        }
        #endregion

        #region fields
        public virtual double Pixels { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Called when the viewport's extents are established.
        ///
        /// The argument is the dimension of the [RenderViewport] in the main axis
        /// (e.g. the height, for a vertical viewport).
        ///
        /// This may be called redundantly, with the same value, each frame. This is
        /// called during layout for the [RenderViewport]. If the viewport is
        /// configured to shrink-wrap its contents, it may be called several times,
        /// since the layout is repeated each time the scroll offset is corrected.
        ///
        /// If this is called, it is called before [applyContentDimensions]. If this
        /// is called, [applyContentDimensions] will be called soon afterwards in the
        /// same layout phase. If the viewport is not configured to shrink-wrap its
        /// contents, then this will only be called when the viewport recomputes its
        /// size (i.e. when its parent lays out), and not during normal scrolling.
        ///
        /// If applying the viewport dimensions changes the scroll offset, return
        /// false. Otherwise, return true. If you return false, the [RenderViewport]
        /// will be laid out again with the new scroll offset. This is expensive. (The
        /// return value is answering the question "did you accept these viewport
        /// dimensions unconditionally?"; if the new dimensions change the
        /// [ViewportOffset]'s actual [pixels] value, then the viewport will need to
        /// be laid out again.)
        /// </Summary>
        public virtual bool ApplyViewportDimension(double viewportDimension)
        {
            return default(bool);
        }


        /// <Summary>
        /// Called when the viewport's content extents are established.
        ///
        /// The arguments are the minimum and maximum scroll extents respectively. The
        /// minimum will be equal to or less than the maximum. In the case of slivers,
        /// the minimum will be equal to or less than zero, the maximum will be equal
        /// to or greater than zero.
        ///
        /// The maximum scroll extent has the viewport dimension subtracted from it.
        /// For instance, if there is 100.0 pixels of scrollable content, and the
        /// viewport is 80.0 pixels high, then the minimum scroll extent will
        /// typically be 0.0 and the maximum scroll extent will typically be 20.0,
        /// because there's only 20.0 pixels of actual scroll slack.
        ///
        /// If applying the content dimensions changes the scroll offset, return
        /// false. Otherwise, return true. If you return false, the [RenderViewport]
        /// will be laid out again with the new scroll offset. This is expensive. (The
        /// return value is answering the question "did you accept these content
        /// dimensions unconditionally?"; if the new dimensions change the
        /// [ViewportOffset]'s actual [pixels] value, then the viewport will need to
        /// be laid out again.)
        ///
        /// This is called at least once each time the [RenderViewport] is laid out,
        /// even if the values have not changed. It may be called many times if the
        /// scroll offset is corrected (if this returns false). This is always called
        /// after [applyViewportDimension], if that method is called.
        /// </Summary>
        public virtual bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent)
        {
            return default(bool);
        }


        /// <Summary>
        /// Apply a layout-time correction to the scroll offset.
        ///
        /// This method should change the [pixels] value by `correction`, but without
        /// calling [notifyListeners]. It is called during layout by the
        /// [RenderViewport], before [applyContentDimensions]. After this method is
        /// called, the layout will be recomputed and that may result in this method
        /// being called again, though this should be very rare.
        ///
        /// See also:
        ///
        ///  * [jumpTo], for also changing the scroll position when not in layout.
        ///    [jumpTo] applies the change immediately and notifies its listeners.
        /// </Summary>
        public virtual void CorrectBy(double correction)
        {
        }


        /// <Summary>
        /// Jumps [pixels] from its current value to the given value,
        /// without animation, and without checking if the new value is in range.
        ///
        /// See also:
        ///
        ///  * [correctBy], for changing the current offset in the middle of layout
        ///    and that defers the notification of its listeners until after layout.
        /// </Summary>
        public virtual void JumpTo(double pixels)
        {
        }


        /// <Summary>
        /// Animates [pixels] from its current value to the given value.
        ///
        /// The returned [Future] will complete when the animation ends, whether it
        /// completed successfully or whether it was interrupted prematurely.
        ///
        /// The duration must not be zero. To jump to a particular value without an
        /// animation, use [jumpTo].
        /// </Summary>
        public virtual Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            return default(Future<void>);
        }


        /// <Summary>
        /// Calls [jumpTo] if duration is null or [Duration.zero], otherwise
        /// [animateTo] is called.
        ///
        /// If [animateTo] is called then [curve] defaults to [Curves.ease]. The
        /// [clamp] parameter is ignored by this stub implementation but subclasses
        /// like [ScrollPosition] handle it by adjusting [to] to prevent over or
        /// underscroll.
        /// </Summary>
        public virtual Future<object> MoveTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), bool clamp = default(bool))
        {

            if (duration == null || duration == Dart:coreDefaultClass.Duration.Zero){
                JumpTo(to);
                return Future<void>.Value();
            }
else
            {
                return AnimateTo(to, duration: duration, curve: curve ?? CurvesDefaultClass.Curves.Ease);
            }

        }





        /// <Summary>
        /// Add additional information to the given description for use by [toString].
        ///
        /// This method makes it easier for subclasses to coordinate to provide a
        /// high-quality [toString] implementation. The [toString] implementation on
        /// the [State] base class calls [debugFillDescription] to collect useful
        /// information from subclasses to incorporate into its return value.
        ///
        /// If you override this, make sure to start your method with a call to
        /// `super.debugFillDescription(description)`.
        /// </Summary>
        public virtual void DebugFillDescription(List<string> description)
        {
            description.Add($"'offset: {Pixels?.ToStringAsFixed(1)}'");
        }



        #endregion
    }


    public class _FixedViewportOffset : FlutterSDK.Rendering.Viewportoffset.ViewportOffset
    {
        #region constructors
        public _FixedViewportOffset(double _pixels)
        {
            this._Pixels = _pixels;
        }
        public static _FixedViewportOffset Zero()
        {
            var instance = new _FixedViewportOffset();
        }
        #endregion

        #region fields
        internal virtual double _Pixels { get; set; }
        public virtual double Pixels { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool ApplyViewportDimension(double viewportDimension) => true;



        public new bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent) => true;



        public new void CorrectBy(double correction)
        {
            _Pixels += correction;
        }




        public new void JumpTo(double pixels)
        {
        }




        public new Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
    async
{
}



    #endregion
}


/// <Summary>
/// The direction of a scroll, relative to the positive scroll offset axis given
/// by an [AxisDirection] and a [GrowthDirection].
///
/// This contrasts to [GrowthDirection] in that it has a third value, [idle],
/// for the case where no scroll is occurring.
///
/// This is used by [RenderSliverFloatingPersistentHeader] to only expand when
/// the user is scrolling in the same direction as the detected scroll offset
/// change.
/// </Summary>
public enum ScrollDirection
{

    /// <Summary>
    /// No scrolling is underway.
    /// </Summary>
    Idle,
    /// <Summary>
    /// Scrolling is happening in the positive scroll offset direction.
    ///
    /// For example, for the [GrowthDirection.forward] part of a vertical
    /// [AxisDirection.down] list, this means the content is moving up, exposing
    /// lower content.
    /// </Summary>
    Forward,
    /// <Summary>
    /// Scrolling is happening in the negative scroll offset direction.
    ///
    /// For example, for the [GrowthDirection.forward] part of a vertical
    /// [AxisDirection.down] list, this means the content is moving down, exposing
    /// earlier content.
    /// </Summary>
    Reverse,
}

}
