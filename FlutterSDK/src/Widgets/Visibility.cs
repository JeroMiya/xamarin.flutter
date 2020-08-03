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
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Visibility
{
    internal static class VisibilityDefaultClass
    {
    }

    /// <Summary>
    /// Whether to show or hide a child.
    ///
    /// By default, the [visible] property controls whether the [child] is included
    /// in the subtree or not; when it is not [visible], the [replacement] child
    /// (typically a zero-sized box) is included instead.
    ///
    /// A variety of flags can be used to tweak exactly how the child is hidden.
    /// (Changing the flags dynamically is discouraged, as it can cause the [child]
    /// subtree to be rebuilt, with any state in the subtree being discarded.
    /// Typically, only the [visible] flag is changed dynamically.)
    ///
    /// These widgets provide some of the facets of this one:
    ///
    ///  * [Opacity], which can stop its child from being painted.
    ///  * [Offstage], which can stop its child from being laid out or painted.
    ///  * [TickerMode], which can stop its child from being animated.
    ///  * [ExcludeSemantics], which can hide the child from accessibility tools.
    ///  * [IgnorePointer], which can disable touch interactions with the child.
    ///
    /// Using this widget is not necessary to hide children. The simplest way to
    /// hide a child is just to not include it, or, if a child _must_ be given (e.g.
    /// because the parent is a [StatelessWidget]) then to use [SizedBox.shrink]
    /// instead of the child that would otherwise be included.
    ///
    /// See also:
    ///
    ///  * [AnimatedSwitcher], which can fade from one child to the next as the
    ///    subtree changes.
    ///  * [AnimatedCrossFade], which can fade between two specific children.
    /// </Summary>
    public class Visibility : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Control whether the given [child] is [visible].
        ///
        /// The [child] and [replacement] arguments must not be null.
        ///
        /// The boolean arguments must not be null.
        ///
        /// The [maintainSemantics] and [maintainInteractivity] arguments can only be
        /// set if [maintainSize] is set.
        ///
        /// The [maintainSize] argument can only be set if [maintainAnimation] is set.
        ///
        /// The [maintainAnimation] argument can only be set if [maintainState] is
        /// set.
        /// </Summary>
        public Visibility(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget replacement = default(FlutterSDK.Widgets.Framework.Widget), bool visible = true, bool maintainState = false, bool maintainAnimation = false, bool maintainSize = false, bool maintainSemantics = false, bool maintainInteractivity = false)
        : base(key: key)
        {
            this.Child = child;
            this.Replacement = replacement;
            this.Visible = visible;
            this.MaintainState = maintainState;
            this.MaintainAnimation = maintainAnimation;
            this.MaintainSize = maintainSize;
            this.MaintainSemantics = maintainSemantics;
            this.MaintainInteractivity = maintainInteractivity;
        }
        /// <Summary>
        /// The widget to show or hide, as controlled by [visible].
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The widget to use when the child is not [visible], assuming that none of
        /// the `maintain` flags (in particular, [maintainState]) are set.
        ///
        /// The normal behavior is to replace the widget with a zero by zero box
        /// ([SizedBox.shrink]).
        ///
        /// See also:
        ///
        ///  * [AnimatedCrossFade], which can animate between two children.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Replacement { get; set; }
        /// <Summary>
        /// Switches between showing the [child] or hiding it.
        ///
        /// The `maintain` flags should be set to the same values regardless of the
        /// state of the [visible] property, otherwise they will not operate correctly
        /// (specifically, the state will be lost regardless of the state of
        /// [maintainState] whenever any of the `maintain` flags are changed, since
        /// doing so will result in a subtree shape change).
        ///
        /// Unless [maintainState] is set, the [child] subtree will be disposed
        /// (removed from the tree) while hidden.
        /// </Summary>
        public virtual bool Visible { get; set; }
        /// <Summary>
        /// Whether to maintain the [State] objects of the [child] subtree when it is
        /// not [visible].
        ///
        /// Keeping the state of the subtree is potentially expensive (because it
        /// means all the objects are still in memory; their resources are not
        /// released). It should only be maintained if it cannot be recreated on
        /// demand. One example of when the state would be maintained is if the child
        /// subtree contains a [Navigator], since that widget maintains elaborate
        /// state that cannot be recreated on the fly.
        ///
        /// If this property is true, an [Offstage] widget is used to hide the child
        /// instead of replacing it with [replacement].
        ///
        /// If this property is false, then [maintainAnimation] must also be false.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainState { get; set; }
        /// <Summary>
        /// Whether to maintain animations within the [child] subtree when it is
        /// not [visible].
        ///
        /// To set this, [maintainState] must also be set.
        ///
        /// Keeping animations active when the widget is not visible is even more
        /// expensive than only maintaining the state.
        ///
        /// One example when this might be useful is if the subtree is animating its
        /// layout in time with an [AnimationController], and the result of that
        /// layout is being used to influence some other logic. If this flag is false,
        /// then any [AnimationController]s hosted inside the [child] subtree will be
        /// muted while the [visible] flag is false.
        ///
        /// If this property is true, no [TickerMode] widget is used.
        ///
        /// If this property is false, then [maintainSize] must also be false.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainAnimation { get; set; }
        /// <Summary>
        /// Whether to maintain space for where the widget would have been.
        ///
        /// To set this, [maintainAnimation] must also be set.
        ///
        /// Maintaining the size when the widget is not [visible] is not notably more
        /// expensive than just keeping animations running without maintaining the
        /// size, and may in some circumstances be slightly cheaper if the subtree is
        /// simple and the [visible] property is frequently toggled, since it avoids
        /// triggering a layout change when the [visible] property is toggled. If the
        /// [child] subtree is not trivial then it is significantly cheaper to not
        /// even keep the state (see [maintainState]).
        ///
        /// If this property is true, [Opacity] is used instead of [Offstage].
        ///
        /// If this property is false, then [maintainSemantics] and
        /// [maintainInteractivity] must also be false.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        ///
        /// See also:
        ///
        ///  * [AnimatedOpacity] and [FadeTransition], which apply animations to the
        ///    opacity for a more subtle effect.
        /// </Summary>
        public virtual bool MaintainSize { get; set; }
        /// <Summary>
        /// Whether to maintain the semantics for the widget when it is hidden (e.g.
        /// for accessibility).
        ///
        /// To set this, [maintainSize] must also be set.
        ///
        /// By default, with [maintainSemantics] set to false, the [child] is not
        /// visible to accessibility tools when it is hidden from the user. If this
        /// flag is set to true, then accessibility tools will report the widget as if
        /// it was present.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainSemantics { get; set; }
        /// <Summary>
        /// Whether to allow the widget to be interactive when hidden.
        ///
        /// To set this, [maintainSize] must also be set.
        ///
        /// By default, with [maintainInteractivity] set to false, touch events cannot
        /// reach the [child] when it is hidden from the user. If this flag is set to
        /// true, then touch events will nonetheless be passed through.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainInteractivity { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (MaintainSize)
            {
                Widget result = Child;
                if (!MaintainInteractivity)
                {
                    result = new IgnorePointer(child: Child, ignoring: !Visible, ignoringSemantics: !Visible && !MaintainSemantics);
                }

                return new Opacity(opacity: Visible ? 1.0 : 0.0, alwaysIncludeSemantics: MaintainSemantics, child: result);
            }




            if (MaintainState)
            {
                Widget result = Child;
                if (!MaintainAnimation) result = new TickerMode(child: Child, enabled: Visible);
                return new Offstage(child: result, offstage: !Visible);
            }



            return Visible ? Child : Replacement;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new FlagProperty("visible", value: Visible, ifFalse: "hidden", ifTrue: "visible"));
            properties.Add(new FlagProperty("maintainState", value: MaintainState, ifFalse: "maintainState"));
            properties.Add(new FlagProperty("maintainAnimation", value: MaintainAnimation, ifFalse: "maintainAnimation"));
            properties.Add(new FlagProperty("maintainSize", value: MaintainSize, ifFalse: "maintainSize"));
            properties.Add(new FlagProperty("maintainSemantics", value: MaintainSemantics, ifFalse: "maintainSemantics"));
            properties.Add(new FlagProperty("maintainInteractivity", value: MaintainInteractivity, ifFalse: "maintainInteractivity"));
        }



    }


    /// <Summary>
    /// Whether to show or hide a sliver child.
    ///
    /// By default, the [visible] property controls whether the [sliver] is included
    /// in the subtree or not; when it is not [visible], the [replacementSliver] is
    /// included instead.
    ///
    /// A variety of flags can be used to tweak exactly how the sliver is hidden.
    /// (Changing the flags dynamically is discouraged, as it can cause the [sliver]
    /// subtree to be rebuilt, with any state in the subtree being discarded.
    /// Typically, only the [visible] flag is changed dynamically.)
    ///
    /// These widgets provide some of the facets of this one:
    ///
    ///  * [SliverOpacity], which can stop its sliver child from being painted.
    ///  * [SliverOffstage], which can stop its sliver child from being laid out or
    ///    painted.
    ///  * [TickerMode], which can stop its child from being animated.
    ///  * [ExcludeSemantics], which can hide the child from accessibility tools.
    ///  * [SliverIgnorePointer], which can disable touch interactions with the
    ///    sliver child.
    ///
    /// Using this widget is not necessary to hide children. The simplest way to
    /// hide a child is just to not include it, or, if a child _must_ be given (e.g.
    /// because the parent is a [StatelessWidget]) then to use a childless
    /// [SliverToBoxAdapter] instead of the child that would otherwise be included.
    /// </Summary>
    public class SliverVisibility : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Control whether the given [sliver] is [visible].
        ///
        /// The [sliver] and [replacementSliver] arguments must not be null.
        ///
        /// The boolean arguments must not be null.
        ///
        /// The [maintainSemantics] and [maintainInteractivity] arguments can only be
        /// set if [maintainSize] is set.
        ///
        /// The [maintainSize] argument can only be set if [maintainAnimation] is set.
        ///
        /// The [maintainAnimation] argument can only be set if [maintainState] is
        /// set.
        /// </Summary>
        public SliverVisibility(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget replacementSliver = default(FlutterSDK.Widgets.Framework.Widget), bool visible = true, bool maintainState = false, bool maintainAnimation = false, bool maintainSize = false, bool maintainSemantics = false, bool maintainInteractivity = false)
        : base(key: key)
        {
            this.Sliver = sliver;
            this.ReplacementSliver = replacementSliver;
            this.Visible = visible;
            this.MaintainState = maintainState;
            this.MaintainAnimation = maintainAnimation;
            this.MaintainSize = maintainSize;
            this.MaintainSemantics = maintainSemantics;
            this.MaintainInteractivity = maintainInteractivity;
        }
        /// <Summary>
        /// The sliver to show or hide, as controlled by [visible].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Sliver { get; set; }
        /// <Summary>
        /// The widget to use when the sliver child is not [visible], assuming that
        /// none of the `maintain` flags (in particular, [maintainState]) are set.
        ///
        /// The normal behavior is to replace the widget with a childless
        /// [SliverToBoxAdapter], which by default has a geometry of
        /// [SliverGeometry.zero].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget ReplacementSliver { get; set; }
        /// <Summary>
        /// Switches between showing the [sliver] or hiding it.
        ///
        /// The `maintain` flags should be set to the same values regardless of the
        /// state of the [visible] property, otherwise they will not operate correctly
        /// (specifically, the state will be lost regardless of the state of
        /// [maintainState] whenever any of the `maintain` flags are changed, since
        /// doing so will result in a subtree shape change).
        ///
        /// Unless [maintainState] is set, the [sliver] subtree will be disposed
        /// (removed from the tree) while hidden.
        /// </Summary>
        public virtual bool Visible { get; set; }
        /// <Summary>
        /// Whether to maintain the [State] objects of the [sliver] subtree when it is
        /// not [visible].
        ///
        /// Keeping the state of the subtree is potentially expensive (because it
        /// means all the objects are still in memory; their resources are not
        /// released). It should only be maintained if it cannot be recreated on
        /// demand. One example of when the state would be maintained is if the sliver
        /// subtree contains a [Navigator], since that widget maintains elaborate
        /// state that cannot be recreated on the fly.
        ///
        /// If this property is true, a [SliverOffstage] widget is used to hide the
        /// sliver instead of replacing it with [replacementSliver].
        ///
        /// If this property is false, then [maintainAnimation] must also be false.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainState { get; set; }
        /// <Summary>
        /// Whether to maintain animations within the [sliver] subtree when it is
        /// not [visible].
        ///
        /// To set this, [maintainState] must also be set.
        ///
        /// Keeping animations active when the widget is not visible is even more
        /// expensive than only maintaining the state.
        ///
        /// One example when this might be useful is if the subtree is animating its
        /// layout in time with an [AnimationController], and the result of that
        /// layout is being used to influence some other logic. If this flag is false,
        /// then any [AnimationController]s hosted inside the [sliver] subtree will be
        /// muted while the [visible] flag is false.
        ///
        /// If this property is true, no [TickerMode] widget is used.
        ///
        /// If this property is false, then [maintainSize] must also be false.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainAnimation { get; set; }
        /// <Summary>
        /// Whether to maintain space for where the sliver would have been.
        ///
        /// To set this, [maintainAnimation] must also be set.
        ///
        /// Maintaining the size when the sliver is not [visible] is not notably more
        /// expensive than just keeping animations running without maintaining the
        /// size, and may in some circumstances be slightly cheaper if the subtree is
        /// simple and the [visible] property is frequently toggled, since it avoids
        /// triggering a layout change when the [visible] property is toggled. If the
        /// [sliver] subtree is not trivial then it is significantly cheaper to not
        /// even keep the state (see [maintainState]).
        ///
        /// If this property is true, [SliverOpacity] is used instead of
        /// [SliverOffstage].
        ///
        /// If this property is false, then [maintainSemantics] and
        /// [maintainInteractivity] must also be false.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainSize { get; set; }
        /// <Summary>
        /// Whether to maintain the semantics for the sliver when it is hidden (e.g.
        /// for accessibility).
        ///
        /// To set this, [maintainSize] must also be set.
        ///
        /// By default, with [maintainSemantics] set to false, the [sliver] is not
        /// visible to accessibility tools when it is hidden from the user. If this
        /// flag is set to true, then accessibility tools will report the widget as if
        /// it was present.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainSemantics { get; set; }
        /// <Summary>
        /// Whether to allow the sliver to be interactive when hidden.
        ///
        /// To set this, [maintainSize] must also be set.
        ///
        /// By default, with [maintainInteractivity] set to false, touch events cannot
        /// reach the [sliver] when it is hidden from the user. If this flag is set to
        /// true, then touch events will nonetheless be passed through.
        ///
        /// Dynamically changing this value may cause the current state of the
        /// subtree to be lost (and a new instance of the subtree, with new [State]
        /// objects, to be immediately created if [visible] is true).
        /// </Summary>
        public virtual bool MaintainInteractivity { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (MaintainSize)
            {
                Widget result = Sliver;
                if (!MaintainInteractivity)
                {
                    result = new SliverIgnorePointer(sliver: Sliver, ignoring: !Visible, ignoringSemantics: !Visible && !MaintainSemantics);
                }

                return new SliverOpacity(opacity: Visible ? 1.0 : 0.0, alwaysIncludeSemantics: MaintainSemantics, sliver: result);
            }




            if (MaintainState)
            {
                Widget result = Sliver;
                if (!MaintainAnimation) result = new TickerMode(child: Sliver, enabled: Visible);
                return new SliverOffstage(sliver: result, offstage: !Visible);
            }



            return Visible ? Sliver : ReplacementSliver;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new FlagProperty("visible", value: Visible, ifFalse: "hidden", ifTrue: "visible"));
            properties.Add(new FlagProperty("maintainState", value: MaintainState, ifFalse: "maintainState"));
            properties.Add(new FlagProperty("maintainAnimation", value: MaintainAnimation, ifFalse: "maintainAnimation"));
            properties.Add(new FlagProperty("maintainSize", value: MaintainSize, ifFalse: "maintainSize"));
            properties.Add(new FlagProperty("maintainSemantics", value: MaintainSemantics, ifFalse: "maintainSemantics"));
            properties.Add(new FlagProperty("maintainInteractivity", value: MaintainInteractivity, ifFalse: "maintainInteractivity"));
        }



    }

}
