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
namespace FlutterSDK.Widgets.Heroes
{
    public delegate FlutterSDK.Animation.Tween.Tween<Rect> CreateRectTween(FlutterBinding.UI.Rect begin, FlutterBinding.UI.Rect end);
    public delegate FlutterSDK.Widgets.Framework.Widget HeroPlaceholderBuilder(FlutterSDK.Widgets.Framework.BuildContext context, Size heroSize, FlutterSDK.Widgets.Framework.Widget child);
    public delegate FlutterSDK.Widgets.Framework.Widget HeroFlightShuttleBuilder(FlutterSDK.Widgets.Framework.BuildContext flightContext, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Widgets.Heroes.HeroFlightDirection flightDirection, FlutterSDK.Widgets.Framework.BuildContext fromHeroContext, FlutterSDK.Widgets.Framework.BuildContext toHeroContext);
    public delegate void _OnFlightEnded(FlutterSDK.Widgets.Heroes._HeroFlight flight);
    internal static class HeroesDefaultClass
    {
        internal static Rect _BoundingBoxFor(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.BuildContext ancestorContext = default(FlutterSDK.Widgets.Framework.BuildContext))
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A widget that marks its child as being a candidate for
    /// [hero animations](https://flutter.dev/docs/development/ui/animations/hero-animations).
    ///
    /// When a [PageRoute] is pushed or popped with the [Navigator], the entire
    /// screen's content is replaced. An old route disappears and a new route
    /// appears. If there's a common visual feature on both routes then it can
    /// be helpful for orienting the user for the feature to physically move from
    /// one page to the other during the routes' transition. Such an animation
    /// is called a *hero animation*. The hero widgets "fly" in the Navigator's
    /// overlay during the transition and while they're in-flight they're, by
    /// default, not shown in their original locations in the old and new routes.
    ///
    /// To label a widget as such a feature, wrap it in a [Hero] widget. When
    /// navigation happens, the [Hero] widgets on each route are identified
    /// by the [HeroController]. For each pair of [Hero] widgets that have the
    /// same tag, a hero animation is triggered.
    ///
    /// If a [Hero] is already in flight when navigation occurs, its
    /// flight animation will be redirected to its new destination. The
    /// widget shown in-flight during the transition is, by default, the
    /// destination route's [Hero]'s child.
    ///
    /// For a Hero animation to trigger, the Hero has to exist on the very first
    /// frame of the new page's animation.
    ///
    /// Routes must not contain more than one [Hero] for each [tag].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=Be9UH1kXFDw}
    ///
    /// ## Discussion
    ///
    /// Heroes and the [Navigator]'s [Overlay] [Stack] must be axis-aligned for
    /// all this to work. The top left and bottom right coordinates of each animated
    /// Hero will be converted to global coordinates and then from there converted
    /// to that [Stack]'s coordinate space, and the entire Hero subtree will, for
    /// the duration of the animation, be lifted out of its original place, and
    /// positioned on that stack. If the [Hero] isn't axis aligned, this is going to
    /// fail in a rather ugly fashion. Don't rotate your heroes!
    ///
    /// To make the animations look good, it's critical that the widget tree for the
    /// hero in both locations be essentially identical. The widget of the *target*
    /// is, by default, used to do the transition: when going from route A to route
    /// B, route B's hero's widget is placed over route A's hero's widget. If a
    /// [flightShuttleBuilder] is supplied, its output widget is shown during the
    /// flight transition instead.
    ///
    /// By default, both route A and route B's heroes are hidden while the
    /// transitioning widget is animating in-flight above the 2 routes.
    /// [placeholderBuilder] can be used to show a custom widget in their place
    /// instead once the transition has taken flight.
    ///
    /// During the transition, the transition widget is animated to route B's hero's
    /// position, and then the widget is inserted into route B. When going back from
    /// B to A, route A's hero's widget is, by default, placed over where route B's
    /// hero's widget was, and then the animation goes the other way.
    ///
    /// ### Nested Navigators
    ///
    /// If either or both routes contain nested [Navigator]s, only [Hero]es
    /// contained in the top-most routes (as defined by [Route.isCurrent]) *of those
    /// nested [Navigator]s* are considered for animation. Just like in the
    /// non-nested case the top-most routes containing these [Hero]es in the nested
    /// [Navigator]s have to be [PageRoute]s.
    ///
    /// ## Parts of a Hero Transition
    ///
    /// ![Diagrams with parts of the Hero transition.](https://flutter.github.io/assets-for-api-docs/assets/interaction/heroes.png)
    /// </Summary>
    public class Hero : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Hero(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), @Object tag = default(@Object), FlutterSDK.Widgets.Heroes.CreateRectTween createRectTween = default(FlutterSDK.Widgets.Heroes.CreateRectTween), FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder flightShuttleBuilder = default(FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder), FlutterSDK.Widgets.Heroes.HeroPlaceholderBuilder placeholderBuilder = default(FlutterSDK.Widgets.Heroes.HeroPlaceholderBuilder), bool transitionOnUserGestures = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Tag = tag;
            this.CreateRectTween = createRectTween;
            this.FlightShuttleBuilder = flightShuttleBuilder;
            this.PlaceholderBuilder = placeholderBuilder;
            this.TransitionOnUserGestures = transitionOnUserGestures;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual @Object Tag { get; set; }
        public virtual FlutterSDK.Widgets.Heroes.CreateRectTween CreateRectTween { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder FlightShuttleBuilder { get; set; }
        public virtual FlutterSDK.Widgets.Heroes.HeroPlaceholderBuilder PlaceholderBuilder { get; set; }
        public virtual bool TransitionOnUserGestures { get; set; }
        #endregion

        #region methods

        private Dictionary<@Object, FlutterSDK.Widgets.Heroes._HeroState> _AllHeroesFor(FlutterSDK.Widgets.Framework.BuildContext context, bool isUserGestureTransition, FlutterSDK.Widgets.Navigator.NavigatorState navigator)
        {



            Dictionary<object, _HeroState> result = new Dictionary<object, _HeroState> { };
            void InviteHero(StatefulElement hero, object tag) => {

                Hero heroWidget = hero.Widget as Hero;
                _HeroState heroState = hero.State as _HeroState;
                if (!isUserGestureTransition || heroWidget.TransitionOnUserGestures)
                {
                    result[tag] = heroState;
                }
                else
                {
                    heroState.EnsurePlaceholderIsHidden();
                }

            }

            void Visitor(Element element) => {
                Widget widget = element.Widget;
                if (widget is Hero)
                {
                    StatefulElement hero = element as StatefulElement;
                    object tag = ((Hero)widget).Tag;

                    if (NavigatorDefaultClass.Navigator.Of(hero) == navigator)
                    {
                        InviteHero(hero, tag);
                    }
                    else
                    {
                        ModalRoute<object> heroRoute = RoutesDefaultClass.ModalRoute.Of(hero);
                        if (heroRoute != null && ((PageRoute)heroRoute) is PageRoute && ((PageRoute)heroRoute).IsCurrent)
                        {
                            InviteHero(hero, tag);
                        }

                    }

                }

                element.VisitChildren(Visitor);
            }

            context.VisitChildElements(Visitor);
            return result;
        }




        public new FlutterSDK.Widgets.Heroes._HeroState CreateState() => new _HeroState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<object>("tag", Tag));
        }



        #endregion
    }


    public class _HeroState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Heroes.Hero>
    {
        #region constructors
        public _HeroState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _Key { get; set; }
        internal virtual Size _PlaceholderSize { get; set; }
        internal virtual bool _ShouldIncludeChild { get; set; }
        #endregion

        #region methods

        public virtual void StartFlight(bool shouldIncludedChildInPlaceholder = false)
        {
            _ShouldIncludeChild = shouldIncludedChildInPlaceholder;

            RenderBox box = Context.FindRenderObject() as RenderBox;

            SetState(() =>
            {
                _PlaceholderSize = box.Size;
            }
            );
        }




        public virtual void EnsurePlaceholderIsHidden()
        {
            if (Mounted)
            {
                SetState(() =>
                {
                    _PlaceholderSize = null;
                }
                );
            }

        }




        public virtual void EndFlight(bool keepPlaceholder = false)
        {
            if (!keepPlaceholder)
            {
                EnsurePlaceholderIsHidden();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            bool showPlaceholder = _PlaceholderSize != null;
            if (showPlaceholder && Widget.PlaceholderBuilder != null)
            {
                return Widget.PlaceholderBuilder(context, _PlaceholderSize, Widget.Child);
            }

            if (showPlaceholder && !_ShouldIncludeChild)
            {
                return new SizedBox(width: _PlaceholderSize.Width, height: _PlaceholderSize.Height);
            }

            return new SizedBox(width: _PlaceholderSize?.Width, height: _PlaceholderSize?.Height, child: new Offstage(offstage: showPlaceholder, child: new TickerMode(enabled: !showPlaceholder, child: new KeyedSubtree(key: _Key, child: Widget.Child))));
        }



        #endregion
    }


    public class _HeroFlightManifest
    {
        #region constructors
        public _HeroFlightManifest(FlutterSDK.Widgets.Heroes.HeroFlightDirection type = default(FlutterSDK.Widgets.Heroes.HeroFlightDirection), FlutterSDK.Widgets.Overlay.OverlayState overlay = default(FlutterSDK.Widgets.Overlay.OverlayState), FlutterBinding.UI.Rect navigatorRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Pages.PageRoute<object> fromRoute = default(FlutterSDK.Widgets.Pages.PageRoute<object>), FlutterSDK.Widgets.Pages.PageRoute<object> toRoute = default(FlutterSDK.Widgets.Pages.PageRoute<object>), FlutterSDK.Widgets.Heroes._HeroState fromHero = default(FlutterSDK.Widgets.Heroes._HeroState), FlutterSDK.Widgets.Heroes._HeroState toHero = default(FlutterSDK.Widgets.Heroes._HeroState), FlutterSDK.Widgets.Heroes.CreateRectTween createRectTween = default(FlutterSDK.Widgets.Heroes.CreateRectTween), FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder shuttleBuilder = default(FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder), bool isUserGestureTransition = default(bool), bool isDiverted = default(bool))
        : base()
        {
            this.Type = type;
            this.Overlay = overlay;
            this.NavigatorRect = navigatorRect;
            this.FromRoute = fromRoute;
            this.ToRoute = toRoute;
            this.FromHero = fromHero;
            this.ToHero = toHero;
            this.CreateRectTween = createRectTween;
            this.ShuttleBuilder = shuttleBuilder;
            this.IsUserGestureTransition = isUserGestureTransition;
            this.IsDiverted = isDiverted;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Heroes.HeroFlightDirection Type { get; set; }
        public virtual FlutterSDK.Widgets.Overlay.OverlayState Overlay { get; set; }
        public virtual FlutterBinding.UI.Rect NavigatorRect { get; set; }
        public virtual FlutterSDK.Widgets.Pages.PageRoute<object> FromRoute { get; set; }
        public virtual FlutterSDK.Widgets.Pages.PageRoute<object> ToRoute { get; set; }
        public virtual FlutterSDK.Widgets.Heroes._HeroState FromHero { get; set; }
        public virtual FlutterSDK.Widgets.Heroes._HeroState ToHero { get; set; }
        public virtual FlutterSDK.Widgets.Heroes.CreateRectTween CreateRectTween { get; set; }
        public virtual FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder ShuttleBuilder { get; set; }
        public virtual bool IsUserGestureTransition { get; set; }
        public virtual bool IsDiverted { get; set; }
        public virtual @Object Tag { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        #endregion
    }


    public class _HeroFlight
    {
        #region constructors
        public _HeroFlight(FlutterSDK.Widgets.Heroes._OnFlightEnded onFlightEnded)
        {
            this.OnFlightEnded = onFlightEnded;
            _ProxyAnimation = new ProxyAnimation();
            new ProxyAnimation().AddStatusListener(_HandleAnimationUpdate);
        }


        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Heroes._OnFlightEnded OnFlightEnded { get; set; }
        public virtual FlutterSDK.Animation.Tween.Tween<Rect> HeroRectTween { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Shuttle { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _HeroOpacity { get; set; }
        internal virtual FlutterSDK.Animation.Animations.ProxyAnimation _ProxyAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Heroes._HeroFlightManifest Manifest { get; set; }
        public virtual FlutterSDK.Widgets.Overlay.OverlayEntry OverlayEntry { get; set; }
        internal virtual bool _Aborted { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _ReverseTween { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Animation.Tween.Tween<Rect> _DoCreateRectTween(FlutterBinding.UI.Rect begin, FlutterBinding.UI.Rect end)
        {
            CreateRectTween createRectTween = Manifest.ToHero.Widget.CreateRectTween ?? Manifest.CreateRectTween;
            if (createRectTween != null) return createRectTween(begin, end);
            return new RectTween(begin: begin, end: end);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildOverlay(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            Shuttle = (Shuttle == null ? Manifest.ShuttleBuilder(context, Manifest.Animation, Manifest.Type, Manifest.FromHero.Context, Manifest.ToHero.Context) : Shuttle);

            return new AnimatedBuilder(animation: _ProxyAnimation, child: Shuttle, builder: (BuildContext context, Widget child) =>
            {
                RenderBox toHeroBox = Manifest.ToHero.Context?.FindRenderObject() as RenderBox;
                if (_Aborted || toHeroBox == null || !toHeroBox.Attached)
                {
                    if (_HeroOpacity.IsCompleted)
                    {
                        _HeroOpacity = _ProxyAnimation.Drive(_ReverseTween.Chain(new CurveTween(curve: new Interval(_ProxyAnimation.Value, 1.0))));
                    }

                }
                else if (toHeroBox.HasSize)
                {
                    RenderBox finalRouteBox = Manifest.ToRoute.SubtreeContext?.FindRenderObject() as RenderBox;
                    Offset toHeroOrigin = toHeroBox.LocalToGlobal(Dart: uiDefaultClass.Offset.Zero, ancestor: finalRouteBox);
                    if (toHeroOrigin != HeroRectTween.End.TopLeft)
                    {
                        Rect heroRectEnd = toHeroOrigin & HeroRectTween.End.Size;
                        HeroRectTween = _DoCreateRectTween(HeroRectTween.Begin, heroRectEnd);
                    }

                }

                Rect rect = HeroRectTween.Evaluate(_ProxyAnimation);
                Size size = Manifest.NavigatorRect.Size;
                RelativeRect offsets = RelativeRect.FromSize(rect, size);
                return new Positioned(top: offsets.Top, right: offsets.Right, bottom: offsets.Bottom, left: offsets.Left, child: new IgnorePointer(child: new RepaintBoundary(child: new Opacity(opacity: _HeroOpacity.Value, child: child))));
            }
            );
        }




        private void _HandleAnimationUpdate(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Completed || status == AnimationStatus.Dismissed)
            {
                _ProxyAnimation.Parent = null;

                OverlayEntry.Remove();
                OverlayEntry = null;
                Manifest.FromHero.EndFlight(keepPlaceholder: status == AnimationStatus.Completed);
                Manifest.ToHero.EndFlight(keepPlaceholder: status == AnimationStatus.Dismissed);
                OnFlightEnded(this);
            }

        }




        public virtual void Start(FlutterSDK.Widgets.Heroes._HeroFlightManifest initialManifest)
        {


            Manifest = initialManifest;
            if (Manifest.Type == HeroFlightDirection.Pop) _ProxyAnimation.Parent = new ReverseAnimation(Manifest.Animation); else _ProxyAnimation.Parent = Manifest.Animation;
            Manifest.FromHero.StartFlight(shouldIncludedChildInPlaceholder: Manifest.Type == HeroFlightDirection.Push);
            Manifest.ToHero.StartFlight();
            HeroRectTween = _DoCreateRectTween(HeroesDefaultClass._BoundingBoxFor(Manifest.FromHero.Context, Manifest.FromRoute.SubtreeContext), HeroesDefaultClass._BoundingBoxFor(Manifest.ToHero.Context, Manifest.ToRoute.SubtreeContext));
            OverlayEntry = new OverlayEntry(builder: _BuildOverlay);
            Manifest.Overlay.Insert(OverlayEntry);
        }




        public virtual void Divert(FlutterSDK.Widgets.Heroes._HeroFlightManifest newManifest)
        {

            if (Manifest.Type == HeroFlightDirection.Push && newManifest.Type == HeroFlightDirection.Pop)
            {





                _ProxyAnimation.Parent = new ReverseAnimation(newManifest.Animation);
                HeroRectTween = new ReverseTween<Rect>(HeroRectTween);
            }
            else if (Manifest.Type == HeroFlightDirection.Pop && newManifest.Type == HeroFlightDirection.Push)
            {



                _ProxyAnimation.Parent = newManifest.Animation.Drive(new Tween<double>(begin: Manifest.Animation.Value, end: 1.0));
                if (Manifest.FromHero != newManifest.ToHero)
                {
                    Manifest.FromHero.EndFlight(keepPlaceholder: true);
                    newManifest.ToHero.StartFlight();
                    HeroRectTween = _DoCreateRectTween(HeroRectTween.End, HeroesDefaultClass._BoundingBoxFor(newManifest.ToHero.Context, newManifest.ToRoute.SubtreeContext));
                }
                else
                {
                    HeroRectTween = _DoCreateRectTween(HeroRectTween.End, HeroRectTween.Begin);
                }

            }
            else
            {


                HeroRectTween = _DoCreateRectTween(HeroRectTween.Evaluate(_ProxyAnimation), HeroesDefaultClass._BoundingBoxFor(newManifest.ToHero.Context, newManifest.ToRoute.SubtreeContext));
                Shuttle = null;
                if (newManifest.Type == HeroFlightDirection.Pop) _ProxyAnimation.Parent = new ReverseAnimation(newManifest.Animation); else _ProxyAnimation.Parent = newManifest.Animation;
                Manifest.FromHero.EndFlight(keepPlaceholder: true);
                Manifest.ToHero.EndFlight(keepPlaceholder: true);
                newManifest.FromHero.StartFlight(shouldIncludedChildInPlaceholder: newManifest.Type == HeroFlightDirection.Push);
                newManifest.ToHero.StartFlight();
                OverlayEntry.MarkNeedsBuild();
            }

            _Aborted = false;
            Manifest = newManifest;
        }




        public virtual void Abort()
        {
            _Aborted = true;
        }




        #endregion
    }


    /// <Summary>
    /// A [Navigator] observer that manages [Hero] transitions.
    ///
    /// An instance of [HeroController] should be used in [Navigator.observers].
    /// This is done automatically by [MaterialApp].
    /// </Summary>
    public class HeroController : FlutterSDK.Widgets.Navigator.NavigatorObserver
    {
        #region constructors
        public HeroController(FlutterSDK.Widgets.Heroes.CreateRectTween createRectTween = default(FlutterSDK.Widgets.Heroes.CreateRectTween))
        {
            this.CreateRectTween = createRectTween;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Heroes.CreateRectTween CreateRectTween { get; set; }
        internal virtual Dictionary<@Object, FlutterSDK.Widgets.Heroes._HeroFlight> _Flights { get; set; }
        internal virtual FlutterSDK.Widgets.Heroes.HeroFlightShuttleBuilder _DefaultHeroFlightShuttleBuilder { get; set; }
        #endregion

        #region methods

        public new void DidPush(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {


            _MaybeStartHeroTransition(previousRoute, route, HeroFlightDirection.Push, false);
        }




        public new void DidPop(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {


            if (!Navigator.UserGestureInProgress) _MaybeStartHeroTransition(route, previousRoute, HeroFlightDirection.Pop, false);
        }




        public new void DidReplace(FlutterSDK.Widgets.Navigator.Route<object> newRoute = default(FlutterSDK.Widgets.Navigator.Route<object>), FlutterSDK.Widgets.Navigator.Route<object> oldRoute = default(FlutterSDK.Widgets.Navigator.Route<object>))
        {

            if (newRoute?.IsCurrent == true)
            {
                _MaybeStartHeroTransition(oldRoute, newRoute, HeroFlightDirection.Push, false);
            }

        }




        public new void DidStartUserGesture(FlutterSDK.Widgets.Navigator.Route<object> route, FlutterSDK.Widgets.Navigator.Route<object> previousRoute)
        {


            _MaybeStartHeroTransition(route, previousRoute, HeroFlightDirection.Pop, true);
        }




        public new void DidStopUserGesture()
        {
            if (Navigator.UserGestureInProgress) return;
            bool IsInvalidFlight(_HeroFlight flight) => {
                return flight.Manifest.IsUserGestureTransition && flight.Manifest.Type == HeroFlightDirection.Pop && flight._ProxyAnimation.IsDismissed;
            }

            List<_HeroFlight> invalidFlights = _Flights.Values.Where(IsInvalidFlight).ToList(growable: false);
            foreach (_HeroFlight flight in invalidFlights)
            {
                flight._HandleAnimationUpdate(AnimationStatus.Dismissed);
            }

        }




        private void _MaybeStartHeroTransition(FlutterSDK.Widgets.Navigator.Route<object> fromRoute, FlutterSDK.Widgets.Navigator.Route<object> toRoute, FlutterSDK.Widgets.Heroes.HeroFlightDirection flightType, bool isUserGestureTransition)
        {
            if (toRoute != fromRoute && toRoute is PageRoute<object> && fromRoute is PageRoute<object>)
            {
                PageRoute<object> from = ((PageRoute<dynamic>)fromRoute);
                PageRoute<object> to = ((PageRoute<dynamic>)toRoute);
                Animation<double> animation = (flightType == HeroFlightDirection.Push) ? to.Animation : from.Animation;
                switch (flightType)
                {
                    case HeroFlightDirection.Pop:
                        if (animation.Value == 0.0)
                        {
                            return;
                        }
                        break;
                    case HeroFlightDirection.Push:
                        if (animation.Value == 1.0)
                        {
                            return;
                        }
                        break;
                }
                if (isUserGestureTransition && flightType == HeroFlightDirection.Pop && to.MaintainState)
                {
                    _StartHeroTransition(from, to, animation, flightType, isUserGestureTransition);
                }
                else
                {
                    to.Offstage = to.Animation.Value == 0.0;
                    BindingDefaultClass.WidgetsBinding.Instance.AddPostFrameCallback((TimeSpan value) =>
                    {
                        _StartHeroTransition(from, to, animation, flightType, isUserGestureTransition);
                    }
                    );
                }

            }

        }




        private void _StartHeroTransition(FlutterSDK.Widgets.Pages.PageRoute<object> from, FlutterSDK.Widgets.Pages.PageRoute<object> to, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Widgets.Heroes.HeroFlightDirection flightType, bool isUserGestureTransition)
        {
            if (Navigator == null || from.SubtreeContext == null || to.SubtreeContext == null)
            {
                to.Offstage = false;
                return;
            }

            Rect navigatorRect = HeroesDefaultClass._BoundingBoxFor(Navigator.Context);
            Dictionary<object, _HeroState> fromHeroes = HeroesDefaultClass.Hero._AllHeroesFor(from.SubtreeContext, isUserGestureTransition, Navigator);
            Dictionary<object, _HeroState> toHeroes = HeroesDefaultClass.Hero._AllHeroesFor(to.SubtreeContext, isUserGestureTransition, Navigator);
            to.Offstage = false;
            foreach (object tag in fromHeroes.Keys)
            {
                if (toHeroes[tag] != null)
                {
                    HeroFlightShuttleBuilder fromShuttleBuilder = fromHeroes[tag].Widget.FlightShuttleBuilder;
                    HeroFlightShuttleBuilder toShuttleBuilder = toHeroes[tag].Widget.FlightShuttleBuilder;
                    bool isDiverted = _Flights[tag] != null;
                    _HeroFlightManifest manifest = new _HeroFlightManifest(type: flightType, overlay: Navigator.Overlay, navigatorRect: navigatorRect, fromRoute: from, toRoute: to, fromHero: fromHeroes[tag], toHero: toHeroes[tag], createRectTween: CreateRectTween, shuttleBuilder: toShuttleBuilder ?? fromShuttleBuilder ?? _DefaultHeroFlightShuttleBuilder, isUserGestureTransition: isUserGestureTransition, isDiverted: isDiverted);
                    if (isDiverted) _Flights[tag].Divert(manifest); else _Flights[tag] = new _HeroFlight(_HandleFlightEnded);
                    new _HeroFlight(_HandleFlightEnded).Start(manifest);
                }
                else if (_Flights[tag] != null)
                {
                    _Flights[tag].Abort();
                }

            }

            foreach (object tag in toHeroes.Keys)
            {
                if (fromHeroes[tag] == null) toHeroes[tag].EnsurePlaceholderIsHidden();
            }

        }




        private void _HandleFlightEnded(FlutterSDK.Widgets.Heroes._HeroFlight flight)
        {
            _Flights.Remove(flight.Manifest.Tag);
        }



        #endregion
    }


    /// <Summary>
    /// Direction of the hero's flight based on the navigation operation.
    /// </Summary>
    public enum HeroFlightDirection
    {

        /// <Summary>
        /// A flight triggered by a route push.
        ///
        /// The animation goes from 0 to 1.
        ///
        /// If no custom [HeroFlightShuttleBuilder] is supplied, the top route's
        /// [Hero] child is shown in flight.
        /// </Summary>
        Push,
        /// <Summary>
        /// A flight triggered by a route pop.
        ///
        /// The animation goes from 1 to 0.
        ///
        /// If no custom [HeroFlightShuttleBuilder] is supplied, the bottom route's
        /// [Hero] child is shown in flight.
        /// </Summary>
        Pop,
    }

}
