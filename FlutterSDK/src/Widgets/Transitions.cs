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
namespace FlutterSDK.Widgets.Transitions
{
    internal static class TransitionsDefaultClass
    {
    }

    /// <Summary>
    /// A widget that rebuilds when the given [Listenable] changes value.
    ///
    /// [AnimatedWidget] is most commonly used with [Animation] objects, which are
    /// [Listenable], but it can be used with any [Listenable], including
    /// [ChangeNotifier] and [ValueNotifier].
    ///
    /// [AnimatedWidget] is most useful for widgets that are otherwise stateless. To
    /// use [AnimatedWidget], simply subclass it and implement the build function.
    ///
    ///{@tool dartpad --template=stateful_widget_material_ticker}
    ///
    /// This code defines a widget called `Spinner` that spins a green square
    /// continually. It is built with an [AnimatedWidget].
    ///
    /// ```dart imports
    /// import 'dart:math' as math;
    /// ```
    ///
    /// ```dart preamble
    /// class SpinningContainer extends AnimatedWidget {
    ///   const SpinningContainer({Key key, AnimationController controller})
    ///       : super(key: key, listenable: controller);
    ///
    ///   Animation<double> get _progress => listenable;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Transform.rotate(
    ///       angle: _progress.value * 2.0 * math.pi,
    ///       child: Container(width: 200.0, height: 200.0, color: Colors.green),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// AnimationController _controller;
    ///
    /// @override
    /// void initState() {
    ///   super.initState();
    ///   _controller = AnimationController(
    ///     duration: const Duration(seconds: 10),
    ///     vsync: this,
    ///   )..repeat();
    /// }
    ///
    /// @override
    /// void dispose() {
    ///   _controller.dispose();
    ///   super.dispose();
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return SpinningContainer(controller: _controller);
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// For more complex case involving additional state, consider using
    /// [AnimatedBuilder].
    ///
    /// ## Relationship to [ImplicitlyAnimatedWidget]s
    ///
    /// [AnimatedWidget]s (and their subclasses) take an explicit [Listenable] as
    /// argument, which is usually an [Animation] derived from an
    /// [AnimationController]. In most cases, the lifecycle of that
    /// [AnimationController] has to be managed manually by the developer.
    /// In contrast to that, [ImplicitlyAnimatedWidget]s (and their subclasses)
    /// automatically manage their own internal [AnimationController] making those
    /// classes easier to use as no external [Animation] has to be provided by the
    /// developer. If you only need to set a target value for the animation and
    /// configure its duration/curve, consider using (a subclass of)
    /// [ImplicitlyAnimatedWidget]s instead of (a subclass of) this class.
    ///
    /// ## Common animated widgets
    ///
    /// A number of animated widgets ship with the framework. They are usually named
    /// `FooTransition`, where `Foo` is the name of the non-animated
    /// version of that widget. The subclasses of this class should not be confused
    /// with subclasses of [ImplicitlyAnimatedWidget] (see above), which are usually
    /// named `AnimatedFoo`. Commonly used animated widgets include:
    ///
    ///  * [AnimatedBuilder], which is useful for complex animation use cases and a
    ///    notable exception to the naming scheme of [AnimatedWidget] subclasses.
    ///  * [AlignTransition], which is an animated version of [Align].
    ///  * [DecoratedBoxTransition], which is an animated version of [DecoratedBox].
    ///  * [DefaultTextStyleTransition], which is an animated version of
    ///    [DefaultTextStyle].
    ///  * [PositionedTransition], which is an animated version of [Positioned].
    ///  * [RelativePositionedTransition], which is an animated version of
    ///    [Positioned].
    ///  * [RotationTransition], which animates the rotation of a widget.
    ///  * [ScaleTransition], which animates the scale of a widget.
    ///  * [SizeTransition], which animates its own size.
    ///  * [SlideTransition], which animates the position of a widget relative to
    ///    its normal position.
    ///  * [FadeTransition], which is an animated version of [Opacity].
    ///  * [AnimatedModalBarrier], which is an animated version of [ModalBarrier].
    /// </Summary>
    public interface IAnimatedWidget
    {
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
        FlutterSDK.Widgets.Transitions._AnimatedState CreateState();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Foundation.Changenotifier.Listenable Listenable { get; }
    }


    /// <Summary>
    /// A widget that rebuilds when the given [Listenable] changes value.
    ///
    /// [AnimatedWidget] is most commonly used with [Animation] objects, which are
    /// [Listenable], but it can be used with any [Listenable], including
    /// [ChangeNotifier] and [ValueNotifier].
    ///
    /// [AnimatedWidget] is most useful for widgets that are otherwise stateless. To
    /// use [AnimatedWidget], simply subclass it and implement the build function.
    ///
    ///{@tool dartpad --template=stateful_widget_material_ticker}
    ///
    /// This code defines a widget called `Spinner` that spins a green square
    /// continually. It is built with an [AnimatedWidget].
    ///
    /// ```dart imports
    /// import 'dart:math' as math;
    /// ```
    ///
    /// ```dart preamble
    /// class SpinningContainer extends AnimatedWidget {
    ///   const SpinningContainer({Key key, AnimationController controller})
    ///       : super(key: key, listenable: controller);
    ///
    ///   Animation<double> get _progress => listenable;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Transform.rotate(
    ///       angle: _progress.value * 2.0 * math.pi,
    ///       child: Container(width: 200.0, height: 200.0, color: Colors.green),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// AnimationController _controller;
    ///
    /// @override
    /// void initState() {
    ///   super.initState();
    ///   _controller = AnimationController(
    ///     duration: const Duration(seconds: 10),
    ///     vsync: this,
    ///   )..repeat();
    /// }
    ///
    /// @override
    /// void dispose() {
    ///   _controller.dispose();
    ///   super.dispose();
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return SpinningContainer(controller: _controller);
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// For more complex case involving additional state, consider using
    /// [AnimatedBuilder].
    ///
    /// ## Relationship to [ImplicitlyAnimatedWidget]s
    ///
    /// [AnimatedWidget]s (and their subclasses) take an explicit [Listenable] as
    /// argument, which is usually an [Animation] derived from an
    /// [AnimationController]. In most cases, the lifecycle of that
    /// [AnimationController] has to be managed manually by the developer.
    /// In contrast to that, [ImplicitlyAnimatedWidget]s (and their subclasses)
    /// automatically manage their own internal [AnimationController] making those
    /// classes easier to use as no external [Animation] has to be provided by the
    /// developer. If you only need to set a target value for the animation and
    /// configure its duration/curve, consider using (a subclass of)
    /// [ImplicitlyAnimatedWidget]s instead of (a subclass of) this class.
    ///
    /// ## Common animated widgets
    ///
    /// A number of animated widgets ship with the framework. They are usually named
    /// `FooTransition`, where `Foo` is the name of the non-animated
    /// version of that widget. The subclasses of this class should not be confused
    /// with subclasses of [ImplicitlyAnimatedWidget] (see above), which are usually
    /// named `AnimatedFoo`. Commonly used animated widgets include:
    ///
    ///  * [AnimatedBuilder], which is useful for complex animation use cases and a
    ///    notable exception to the naming scheme of [AnimatedWidget] subclasses.
    ///  * [AlignTransition], which is an animated version of [Align].
    ///  * [DecoratedBoxTransition], which is an animated version of [DecoratedBox].
    ///  * [DefaultTextStyleTransition], which is an animated version of
    ///    [DefaultTextStyle].
    ///  * [PositionedTransition], which is an animated version of [Positioned].
    ///  * [RelativePositionedTransition], which is an animated version of
    ///    [Positioned].
    ///  * [RotationTransition], which animates the rotation of a widget.
    ///  * [ScaleTransition], which animates the scale of a widget.
    ///  * [SizeTransition], which animates its own size.
    ///  * [SlideTransition], which animates the position of a widget relative to
    ///    its normal position.
    ///  * [FadeTransition], which is an animated version of [Opacity].
    ///  * [AnimatedModalBarrier], which is an animated version of [ModalBarrier].
    /// </Summary>
    public class AnimatedWidget : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that rebuilds when the given listenable changes.
        ///
        /// The [listenable] argument is required.
        /// </Summary>
        public AnimatedWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Changenotifier.Listenable listenable = default(FlutterSDK.Foundation.Changenotifier.Listenable))
        : base(key: key)
        {
            this.Listenable = listenable;
        }
        /// <Summary>
        /// The [Listenable] to which this widget is listening.
        ///
        /// Commonly an [Animation] or a [ChangeNotifier].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Changenotifier.Listenable Listenable { get; set; }

        /// <Summary>
        /// Override this method to build widgets that depend on the state of the
        /// listenable (e.g., the current value of the animation).
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Subclasses typically do not override this method.
        /// </Summary>
        public new FlutterSDK.Widgets.Transitions._AnimatedState CreateState() => new _AnimatedState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Listenable>("animation", Listenable));
        }



    }


    public class _AnimatedState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Transitions.AnimatedWidget>
    {
        public _AnimatedState()
        { }

        public new void InitState()
        {
            base.InitState();
            Widget.Listenable.AddListener(_HandleChange);
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Transitions.AnimatedWidget oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Listenable != oldWidget.Listenable)
            {
                oldWidget.Listenable.RemoveListener(_HandleChange);
                Widget.Listenable.AddListener(_HandleChange);
            }

        }




        public new void Dispose()
        {
            Widget.Listenable.RemoveListener(_HandleChange);
            base.Dispose();
        }




        private void _HandleChange()
        {
            SetState(() =>
            {
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) => Widget.Build(context);


    }


    /// <Summary>
    /// Animates the position of a widget relative to its normal position.
    ///
    /// The translation is expressed as an [Offset] scaled to the child's size. For
    /// example, an [Offset] with a `dx` of 0.25 will result in a horizontal
    /// translation of one quarter the width of the child.
    ///
    /// By default, the offsets are applied in the coordinate system of the canvas
    /// (so positive x offsets move the child towards the right). If a
    /// [textDirection] is provided, then the offsets are applied in the reading
    /// direction, so in right-to-left text, positive x offsets move towards the
    /// left, and in left-to-right text, positive x offsets move towards the right.
    ///
    /// Here's an illustration of the [SlideTransition] widget, with its [position]
    /// animated by a [CurvedAnimation] set to [Curves.elasticIn]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/slide_transition.mp4}
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center_freeform_state}
    /// The following code implements the [SlideTransition] as seen in the video
    /// above:
    ///
    /// ```dart
    /// class _MyStatefulWidgetState extends State<MyStatefulWidget> with SingleTickerProviderStateMixin {
    ///   AnimationController _controller;
    ///   Animation<Offset> _offsetAnimation;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _controller = AnimationController(
    ///       duration: const Duration(seconds: 2),
    ///       vsync: this,
    ///     )..repeat(reverse: true);
    ///     _offsetAnimation = Tween<Offset>(
    ///       begin: Offset.zero,
    ///       end: const Offset(1.5, 0.0),
    ///     ).animate(CurvedAnimation(
    ///       parent: _controller,
    ///       curve: Curves.elasticIn,
    ///     ));
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     super.dispose();
    ///     _controller.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return SlideTransition(
    ///       position: _offsetAnimation,
    ///       child: const Padding(
    ///         padding: EdgeInsets.all(8.0),
    ///         child: FlutterLogo(size: 150.0),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [AlignTransition], an animated version of an [Align] that animates its
    ///    [Align.alignment] property.
    ///  * [PositionedTransition], a widget that animates its child from a start
    ///    position to an end position over the lifetime of the animation.
    ///  * [RelativePositionedTransition], a widget that transitions its child's
    ///    position based on the value of a rectangle relative to a bounding box.
    /// </Summary>
    public class SlideTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates a fractional translation transition.
        ///
        /// The [position] argument must not be null.
        /// </Summary>
        public SlideTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<Offset> position = default(FlutterSDK.Animation.Animation.Animation<Offset>), bool transformHitTests = true, TextDirection textDirection = default(TextDirection), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: position)
        {
            this.TransformHitTests = transformHitTests;
            this.TextDirection = textDirection;
            this.Child = child;
        }
        /// <Summary>
        /// The direction to use for the x offset described by the [position].
        ///
        /// If [textDirection] is null, the x offset is applied in the coordinate
        /// system of the canvas (so positive x offsets move the child towards the
        /// right).
        ///
        /// If [textDirection] is [TextDirection.rtl], the x offset is applied in the
        /// reading direction such that x offsets move the child towards the left.
        ///
        /// If [textDirection] is [TextDirection.ltr], the x offset is applied in the
        /// reading direction such that x offsets move the child towards the right.
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// Whether hit testing should be affected by the slide animation.
        ///
        /// If false, hit testing will proceed as if the child was not translated at
        /// all. Setting this value to false is useful for fast animations where you
        /// expect the user to commonly interact with the child widget in its final
        /// location and you want the user to benefit from "muscle memory".
        /// </Summary>
        public virtual bool TransformHitTests { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<Offset> Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Offset offset = Position.Value;
            if (TextDirection == TextDirection.Rtl) offset = new Offset(-offset.Dx, offset.Dy);
            return new FractionalTranslation(translation: offset, transformHitTests: TransformHitTests, child: Child);
        }



    }


    /// <Summary>
    /// Animates the scale of a transformed widget.
    ///
    /// Here's an illustration of the [ScaleTransition] widget, with it's [alignment]
    /// animated by a [CurvedAnimation] set to [Curves.fastOutSlowIn]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/scale_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [PositionedTransition], a widget that animates its child from a start
    ///    position to an end position over the lifetime of the animation.
    ///  * [RelativePositionedTransition], a widget that transitions its child's
    ///    position based on the value of a rectangle relative to a bounding box.
    ///  * [SizeTransition], a widget that animates its own size and clips and
    ///    aligns its child.
    /// </Summary>
    public class ScaleTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates a scale transition.
        ///
        /// The [scale] argument must not be null. The [alignment] argument defaults
        /// to [Alignment.center].
        /// </Summary>
        public ScaleTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> scale = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Alignment.Alignment alignment = default(FlutterSDK.Painting.Alignment.Alignment), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: scale)
        {
            this.Alignment = alignment;
            this.Child = child;
        }
        /// <Summary>
        /// The alignment of the origin of the coordinate system in which the scale
        /// takes place, relative to the size of the box.
        ///
        /// For example, to set the origin of the scale to bottom middle, you can use
        /// an alignment of (0.0, 1.0).
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.Alignment Alignment { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Scale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            double scaleValue = Scale.Value;
            Matrix4 transform = Matrix4.Identity();
            Matrix4.Identity().Scale(scaleValue, scaleValue, 1.0);
            return new Transform(transform: transform, alignment: Alignment, child: Child);
        }



    }


    /// <Summary>
    /// Animates the rotation of a widget.
    ///
    /// Here's an illustration of the [RotationTransition] widget, with it's [turns]
    /// animated by a [CurvedAnimation] set to [Curves.elasticOut]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/rotation_transition.mp4}
    /// See also:
    ///
    ///  * [ScaleTransition], a widget that animates the scale of a transformed
    ///    widget.
    ///  * [SizeTransition], a widget that animates its own size and clips and
    ///    aligns its child.
    /// </Summary>
    public class RotationTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates a rotation transition.
        ///
        /// The [turns] argument must not be null.
        /// </Summary>
        public RotationTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> turns = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Alignment.Alignment alignment = default(FlutterSDK.Painting.Alignment.Alignment), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: turns)
        {
            this.Alignment = alignment;
            this.Child = child;
        }
        /// <Summary>
        /// The alignment of the origin of the coordinate system around which the
        /// rotation occurs, relative to the size of the box.
        ///
        /// For example, to set the origin of the rotation to top right corner, use
        /// an alignment of (1.0, -1.0) or use [Alignment.topRight]
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.Alignment Alignment { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Turns { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            double turnsValue = Turns.Value;
            Matrix4 transform = Matrix4.RotationZ(turnsValue * Dart.Math.MathDefaultClass.Pi * 2.0);
            return new Transform(transform: transform, alignment: Alignment, child: Child);
        }



    }


    /// <Summary>
    /// Animates its own size and clips and aligns its child.
    ///
    /// [SizeTransition] acts as a [ClipRect] that animates either its width or its
    /// height, depending upon the value of [axis]. The alignment of the child along
    /// the [axis] is specified by the [axisAlignment].
    ///
    /// Like most widgets, [SizeTransition] will conform to the constraints it is
    /// given, so be sure to put it in a context where it can change size. For
    /// instance, if you place it into a [Container] with a fixed size, then the
    /// [SizeTransition] will not be able to change size, and will appear to do
    /// nothing.
    ///
    /// Here's an illustration of the [SizeTransition] widget, with it's [sizeFactor]
    /// animated by a [CurvedAnimation] set to [Curves.fastOutSlowIn]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/size_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [AnimatedCrossFade], for a widget that automatically animates between
    ///    the sizes of two children, fading between them.
    ///  * [ScaleTransition], a widget that scales the size of the child instead of
    ///    clipping it.
    ///  * [PositionedTransition], a widget that animates its child from a start
    ///    position to an end position over the lifetime of the animation.
    ///  * [RelativePositionedTransition], a widget that transitions its child's
    ///    position based on the value of a rectangle relative to a bounding box.
    /// </Summary>
    public class SizeTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates a size transition.
        ///
        /// The [axis], [sizeFactor], and [axisAlignment] arguments must not be null.
        /// The [axis] argument defaults to [Axis.vertical]. The [axisAlignment]
        /// defaults to 0.0, which centers the child along the main axis during the
        /// transition.
        /// </Summary>
        public SizeTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Animation.Animation.Animation<double> sizeFactor = default(FlutterSDK.Animation.Animation.Animation<double>), double axisAlignment = 0.0, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: sizeFactor)
        {
            this.Axis = axis;
            this.AxisAlignment = axisAlignment;
            this.Child = child;
        }
        /// <Summary>
        /// [Axis.horizontal] if [sizeFactor] modifies the width, otherwise
        /// [Axis.vertical].
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get; set; }
        /// <Summary>
        /// Describes how to align the child along the axis that [sizeFactor] is
        /// modifying.
        ///
        /// A value of -1.0 indicates the top when [axis] is [Axis.vertical], and the
        /// start when [axis] is [Axis.horizontal]. The start is on the left when the
        /// text direction in effect is [TextDirection.ltr] and on the right when it
        /// is [TextDirection.rtl].
        ///
        /// A value of 1.0 indicates the bottom or end, depending upon the [axis].
        ///
        /// A value of 0.0 (the default) indicates the center for either [axis] value.
        /// </Summary>
        public virtual double AxisAlignment { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> SizeFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            AlignmentDirectional alignment = default(AlignmentDirectional);
            if (Axis == Axis.Vertical) alignment = new AlignmentDirectional(-1.0, AxisAlignment); else alignment = new AlignmentDirectional(AxisAlignment, -1.0);
            return new ClipRect(child: new Align(alignment: alignment, heightFactor: Axis == Axis.Vertical ? Dart.Math.MathDefaultClass.Max(SizeFactor.Value, 0.0) : null, widthFactor: Axis == Axis.Horizontal ? Dart.Math.MathDefaultClass.Max(SizeFactor.Value, 0.0) : null, child: Child));
        }



    }


    /// <Summary>
    /// Animates the opacity of a widget.
    ///
    /// For a widget that automatically animates between the sizes of two children,
    /// fading between them, see [AnimatedCrossFade].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=rLwWVbv3xDQ}
    ///
    /// Here's an illustration of the [FadeTransition] widget, with it's [opacity]
    /// animated by a [CurvedAnimation] set to [Curves.fastOutSlowIn]:
    ///
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/fade_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [Opacity], which does not animate changes in opacity.
    ///  * [AnimatedOpacity], which animates changes in opacity without taking an
    ///    explicit [Animation] argument.
    /// </Summary>
    public class FadeTransition : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        /// <Summary>
        /// Creates an opacity transition.
        ///
        /// The [opacity] argument must not be null.
        /// </Summary>
        public FadeTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> opacity = default(FlutterSDK.Animation.Animation.Animation<double>), bool alwaysIncludeSemantics = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Opacity = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics;
        }
        /// <Summary>
        /// The animation that controls the opacity of the child.
        ///
        /// If the current value of the opacity animation is v, the child will be
        /// painted with an opacity of v. For example, if v is 0.5, the child will be
        /// blended 50% with its background. Similarly, if v is 0.0, the child will be
        /// completely transparent.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> Opacity { get; set; }
        /// <Summary>
        /// Whether the semantic information of the children is always included.
        ///
        /// Defaults to false.
        ///
        /// When true, regardless of the opacity settings the child semantic
        /// information is exposed as if the widget were fully visible. This is
        /// useful in cases where labels may be hidden during animations that
        /// would otherwise contribute relevant semantics.
        /// </Summary>
        public virtual bool AlwaysIncludeSemantics { get; set; }

        public new FlutterSDK.Rendering.Proxybox.RenderAnimatedOpacity CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderAnimatedOpacity(opacity: Opacity, alwaysIncludeSemantics: AlwaysIncludeSemantics);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderAnimatedOpacity renderObject)
        {
            ..Opacity = Opacity..AlwaysIncludeSemantics = AlwaysIncludeSemantics;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Opacity = Opacity..AlwaysIncludeSemantics = AlwaysIncludeSemantics;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Animation<double>>("opacity", Opacity));
            properties.Add(new FlagProperty("alwaysIncludeSemantics", value: AlwaysIncludeSemantics, ifTrue: "alwaysIncludeSemantics"));
        }



    }


    /// <Summary>
    /// Animates the opacity of a sliver widget.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center_freeform_state}
    /// Creates a [CustomScrollView] with a [SliverFixedExtentList] that uses a
    /// [SliverFadeTransition] to fade the list in and out.
    ///
    /// ```dart
    /// class _MyStatefulWidgetState extends State<MyStatefulWidget> with SingleTickerProviderStateMixin {
    ///   AnimationController controller;
    ///   Animation<double> animation;
    ///
    ///   initState() {
    ///     super.initState();
    ///     controller = AnimationController(
    ///         duration: const Duration(milliseconds: 1000), vsync: this);
    ///     animation = CurvedAnimation(parent: controller, curve: Curves.easeIn);
    ///
    ///     animation.addStatusListener((status) {
    ///       if (status == AnimationStatus.completed) {
    ///         controller.reverse();
    ///       } else if (status == AnimationStatus.dismissed) {
    ///         controller.forward();
    ///       }
    ///     });
    ///     controller.forward();
    ///   }
    ///
    ///   Widget build(BuildContext context) {
    ///     return CustomScrollView(
    ///       slivers: <Widget>[
    ///         SliverFadeTransition(
    ///           opacity: animation,
    ///           sliver: SliverFixedExtentList(
    ///             itemExtent: 100.0,
    ///             delegate: SliverChildBuilderDelegate(
    ///               (BuildContext context, int index) {
    ///                 return Container(
    ///                   color: index % 2 == 0
    ///                     ? Colors.indigo[200]
    ///                     : Colors.orange[200],
    ///                 );
    ///               },
    ///               childCount: 5,
    ///             ),
    ///           ),
    ///         )
    ///       ]
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// Here's an illustration of the [FadeTransition] widget, the [RenderBox]
    /// equivalent widget, with it's [opacity] animated by a [CurvedAnimation] set
    /// to [Curves.fastOutSlowIn]:
    ///
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/fade_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [SliverOpacity], which does not animate changes in opacity.
    /// </Summary>
    public class SliverFadeTransition : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        /// <Summary>
        /// Creates an opacity transition.
        ///
        /// The [opacity] argument must not be null.
        /// </Summary>
        public SliverFadeTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> opacity = default(FlutterSDK.Animation.Animation.Animation<double>), bool alwaysIncludeSemantics = false, FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: sliver)
        {
            this.Opacity = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics;
        }
        /// <Summary>
        /// The animation that controls the opacity of the sliver child.
        ///
        /// If the current value of the opacity animation is v, the child will be
        /// painted with an opacity of v. For example, if v is 0.5, the child will be
        /// blended 50% with its background. Similarly, if v is 0.0, the child will be
        /// completely transparent.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> Opacity { get; set; }
        /// <Summary>
        /// Whether the semantic information of the sliver child is always included.
        ///
        /// Defaults to false.
        ///
        /// When true, regardless of the opacity settings the sliver child's semantic
        /// information is exposed as if the widget were fully visible. This is
        /// useful in cases where labels may be hidden during animations that
        /// would otherwise contribute relevant semantics.
        /// </Summary>
        public virtual bool AlwaysIncludeSemantics { get; set; }

        public new FlutterSDK.Rendering.Proxysliver.RenderSliverAnimatedOpacity CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderSliverAnimatedOpacity(opacity: Opacity, alwaysIncludeSemantics: AlwaysIncludeSemantics);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverAnimatedOpacity renderObject)
        {
            ..Opacity = Opacity..AlwaysIncludeSemantics = AlwaysIncludeSemantics;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Opacity = Opacity..AlwaysIncludeSemantics = AlwaysIncludeSemantics;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Animation<double>>("opacity", Opacity));
            properties.Add(new FlagProperty("alwaysIncludeSemantics", value: AlwaysIncludeSemantics, ifTrue: "alwaysIncludeSemantics"));
        }



    }


    /// <Summary>
    /// An interpolation between two relative rects.
    ///
    /// This class specializes the interpolation of [Tween<RelativeRect>] to
    /// use [RelativeRect.lerp].
    ///
    /// See [Tween] for a discussion on how to use interpolation objects.
    /// </Summary>
    public class RelativeRectTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Rendering.Stack.RelativeRect>
    {
        /// <Summary>
        /// Creates a [RelativeRect] tween.
        ///
        /// The [begin] and [end] properties may be null; the null value
        /// is treated as [RelativeRect.fill].
        /// </Summary>
        public RelativeRectTween(FlutterSDK.Rendering.Stack.RelativeRect begin = default(FlutterSDK.Rendering.Stack.RelativeRect), FlutterSDK.Rendering.Stack.RelativeRect end = default(FlutterSDK.Rendering.Stack.RelativeRect))
        : base(begin: begin, end: end)
        {

        }

        /// <Summary>
        /// Returns the value this variable has at the given animation clock value.
        /// </Summary>
        public new FlutterSDK.Rendering.Stack.RelativeRect Lerp(double t) => StackDefaultClass.RelativeRect.Lerp(Begin, End, t);


    }


    /// <Summary>
    /// Animated version of [Positioned] which takes a specific
    /// [Animation<RelativeRect>] to transition the child's position from a start
    /// position to an end position over the lifetime of the animation.
    ///
    /// Only works if it's the child of a [Stack].
    ///
    /// Here's an illustration of the [PositionedTransition] widget, with it's [rect]
    /// animated by a [CurvedAnimation] set to [Curves.elasticInOut]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/positioned_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [AnimatedPositioned], which transitions a child's position without
    ///    taking an explicit [Animation] argument.
    ///  * [RelativePositionedTransition], a widget that transitions its child's
    ///    position based on the value of a rectangle relative to a bounding box.
    ///  * [SlideTransition], a widget that animates the position of a widget
    ///    relative to its normal position.
    ///  * [AlignTransition], an animated version of an [Align] that animates its
    ///    [Align.alignment] property.
    ///  * [ScaleTransition], a widget that animates the scale of a transformed
    ///    widget.
    ///  * [SizeTransition], a widget that animates its own size and clips and
    ///    aligns its child.
    /// </Summary>
    public class PositionedTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates a transition for [Positioned].
        ///
        /// The [rect] argument must not be null.
        /// </Summary>
        public PositionedTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<FlutterSDK.Rendering.Stack.RelativeRect> rect = default(FlutterSDK.Animation.Animation.Animation<FlutterSDK.Rendering.Stack.RelativeRect>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: rect)
        {
            this.Child = child;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<FlutterSDK.Rendering.Stack.RelativeRect> Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return Positioned.FromRelativeRect(rect: Rect.Value, child: Child);
        }



    }


    /// <Summary>
    /// Animated version of [Positioned] which transitions the child's position
    /// based on the value of [rect] relative to a bounding box with the
    /// specified [size].
    ///
    /// Only works if it's the child of a [Stack].
    ///
    /// Here's an illustration of the [RelativePositionedTransition] widget, with it's [rect]
    /// animated by a [CurvedAnimation] set to [Curves.elasticInOut]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/relative_positioned_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [PositionedTransition], a widget that animates its child from a start
    ///    position to an end position over the lifetime of the animation.
    ///  * [AlignTransition], an animated version of an [Align] that animates its
    ///    [Align.alignment] property.
    ///  * [ScaleTransition], a widget that animates the scale of a transformed
    ///    widget.
    ///  * [SizeTransition], a widget that animates its own size and clips and
    ///    aligns its child.
    ///  * [SlideTransition], a widget that animates the position of a widget
    ///    relative to its normal position.
    /// </Summary>
    public class RelativePositionedTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Create an animated version of [Positioned].
        ///
        /// Each frame, the [Positioned] widget will be configured to represent the
        /// current value of the [rect] argument assuming that the stack has the given
        /// [size]. Both [rect] and [size] must not be null.
        /// </Summary>
        public RelativePositionedTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<Rect> rect = default(FlutterSDK.Animation.Animation.Animation<Rect>), Size size = default(Size), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: rect)
        {
            this.Size = size;
            this.Child = child;
        }
        /// <Summary>
        /// The [Positioned] widget's offsets are relative to a box of this
        /// size whose origin is 0,0.
        /// </Summary>
        public virtual Size Size { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<Rect> Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            RelativeRect offsets = RelativeRect.FromSize(Rect.Value, Size);
            return new Positioned(top: offsets.Top, right: offsets.Right, bottom: offsets.Bottom, left: offsets.Left, child: Child);
        }



    }


    /// <Summary>
    /// Animated version of a [DecoratedBox] that animates the different properties
    /// of its [Decoration].
    ///
    /// Here's an illustration of the [DecoratedBoxTransition] widget, with it's
    /// [decoration] animated by a [CurvedAnimation] set to [Curves.decelerate]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/decorated_box_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [DecoratedBox], which also draws a [Decoration] but is not animated.
    ///  * [AnimatedContainer], a more full-featured container that also animates on
    ///    decoration using an internal animation.
    /// </Summary>
    public class DecoratedBoxTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates an animated [DecoratedBox] whose [Decoration] animation updates
        /// the widget.
        ///
        /// The [decoration] and [position] must not be null.
        ///
        /// See also:
        ///
        ///  * [new DecoratedBox]
        /// </Summary>
        public DecoratedBoxTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Decoration.Decoration> decoration = default(FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Decoration.Decoration>), FlutterSDK.Rendering.Proxybox.DecorationPosition position = default(FlutterSDK.Rendering.Proxybox.DecorationPosition), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: decoration)
        {
            this.Decoration = decoration;
            this.Position = position;
            this.Child = child;
        }
        /// <Summary>
        /// Animation of the decoration to paint.
        ///
        /// Can be created using a [DecorationTween] interpolating typically between
        /// two [BoxDecoration].
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Decoration.Decoration> Decoration { get; set; }
        /// <Summary>
        /// Whether to paint the box decoration behind or in front of the child.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Proxybox.DecorationPosition Position { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new DecoratedBox(decoration: Decoration.Value, position: Position, child: Child);
        }



    }


    /// <Summary>
    /// Animated version of an [Align] that animates its [Align.alignment] property.
    ///
    /// Here's an illustration of the [DecoratedBoxTransition] widget, with it's
    /// [decoration] animated by a [CurvedAnimation] set to [Curves.decelerate]:
    /// {@animation 300 378 https://flutter.github.io/assets-for-api-docs/assets/widgets/align_transition.mp4}
    ///
    /// See also:
    ///
    ///  * [AnimatedAlign], which animates changes to the [alignment] without
    ///    taking an explicit [Animation] argument.
    ///  * [PositionedTransition], a widget that animates its child from a start
    ///    position to an end position over the lifetime of the animation.
    ///  * [RelativePositionedTransition], a widget that transitions its child's
    ///    position based on the value of a rectangle relative to a bounding box.
    ///  * [SizeTransition], a widget that animates its own size and clips and
    ///    aligns its child.
    ///  * [SlideTransition], a widget that animates the position of a widget
    ///    relative to its normal position.
    /// </Summary>
    public class AlignTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates an animated [Align] whose [AlignmentGeometry] animation updates
        /// the widget.
        ///
        /// See also:
        ///
        ///  * [new Align].
        /// </Summary>
        public AlignTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Alignment.AlignmentGeometry> alignment = default(FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Alignment.AlignmentGeometry>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double widthFactor = default(double), double heightFactor = default(double))
        : base(key: key, listenable: alignment)
        {
            this.Child = child;
            this.WidthFactor = widthFactor;
            this.HeightFactor = heightFactor;
        }
        /// <Summary>
        /// If non-null, the child's width factor, see [Align.widthFactor].
        /// </Summary>
        public virtual double WidthFactor { get; set; }
        /// <Summary>
        /// If non-null, the child's height factor, see [Align.heightFactor].
        /// </Summary>
        public virtual double HeightFactor { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Alignment.AlignmentGeometry> Alignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Align(alignment: Alignment.Value, widthFactor: WidthFactor, heightFactor: HeightFactor, child: Child);
        }



    }


    /// <Summary>
    /// Animated version of a [DefaultTextStyle] that animates the different properties
    /// of its [TextStyle].
    ///
    /// See also:
    ///
    ///  * [AnimatedDefaultTextStyle], which animates changes in text style without
    ///    taking an explicit [Animation] argument.
    ///  * [DefaultTextStyle], which also defines a [TextStyle] for its descendants
    ///    but is not animated.
    /// </Summary>
    public class DefaultTextStyleTransition : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates an animated [DefaultTextStyle] whose [TextStyle] animation updates
        /// the widget.
        /// </Summary>
        public DefaultTextStyleTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Textstyle.TextStyle> style = default(FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Textstyle.TextStyle>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), TextAlign textAlign = default(TextAlign), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), int maxLines = default(int))
        : base(key: key, listenable: style)
        {
            this.Child = child;
            this.TextAlign = textAlign;
            this.SoftWrap = softWrap;
            this.Overflow = overflow;
            this.MaxLines = maxLines;
        }
        /// <Summary>
        /// How the text should be aligned horizontally.
        /// </Summary>
        public virtual TextAlign TextAlign { get; set; }
        /// <Summary>
        /// Whether the text should break at soft line breaks.
        ///
        /// See [DefaultTextStyle.softWrap] for more details.
        /// </Summary>
        public virtual bool SoftWrap { get; set; }
        /// <Summary>
        /// How visual overflow should be handled.
        ///
        /// </Summary>
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        /// <Summary>
        /// An optional maximum number of lines for the text to span, wrapping if necessary.
        ///
        /// See [DefaultTextStyle.maxLines] for more details.
        /// </Summary>
        public virtual int MaxLines { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<FlutterSDK.Painting.Textstyle.TextStyle> Style { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new DefaultTextStyle(style: Style.Value, textAlign: TextAlign, softWrap: SoftWrap, overflow: Overflow, maxLines: MaxLines, child: Child);
        }



    }


    /// <Summary>
    /// A general-purpose widget for building animations.
    ///
    /// AnimatedBuilder is useful for more complex widgets that wish to include
    /// an animation as part of a larger build function. To use AnimatedBuilder,
    /// simply construct the widget and pass it a builder function.
    ///
    /// For simple cases without additional state, consider using
    /// [AnimatedWidget].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=N-RiyZlv8v8}
    ///
    /// ## Performance optimizations
    ///
    /// If your [builder] function contains a subtree that does not depend on the
    /// animation, it's more efficient to build that subtree once instead of
    /// rebuilding it on every animation tick.
    ///
    /// If you pass the pre-built subtree as the [child] parameter, the
    /// AnimatedBuilder will pass it back to your builder function so that you
    /// can incorporate it into your build.
    ///
    /// Using this pre-built child is entirely optional, but can improve
    /// performance significantly in some cases and is therefore a good practice.
    ///
    /// {@tool dartpad --template=stateful_widget_material_ticker}
    ///
    /// This code defines a widget that spins a green square continually. It is
    /// built with an [AnimatedBuilder] and makes use of the [child] feature to
    /// avoid having to rebuild the [Container] each time.
    ///
    /// ```dart imports
    /// import 'dart:math' as math;
    /// ```
    ///
    /// ```dart
    /// AnimationController _controller;
    ///
    /// @override
    /// void initState() {
    ///   super.initState();
    ///   _controller = AnimationController(
    ///     duration: const Duration(seconds: 10),
    ///     vsync: this,
    ///   )..repeat();
    /// }
    ///
    /// @override
    /// void dispose() {
    ///   _controller.dispose();
    ///   super.dispose();
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return AnimatedBuilder(
    ///     animation: _controller,
    ///     child: Container(
    ///       width: 200.0,
    ///       height: 200.0,
    ///       color: Colors.green,
    ///       child: const Center(
    ///         child: Text('Whee!'),
    ///       ),
    ///     ),
    ///     builder: (BuildContext context, Widget child) {
    ///       return Transform.rotate(
    ///         angle: _controller.value * 2.0 * math.pi,
    ///         child: child,
    ///       );
    ///     },
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [TweenAnimationBuilder], which animates a property to a target value
    ///    without requiring manual management of an [AnimationController].
    /// </Summary>
    public class AnimatedBuilder : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates an animated builder.
        ///
        /// The [animation] and [builder] arguments must not be null.
        /// </Summary>
        public AnimatedBuilder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Changenotifier.Listenable animation = default(FlutterSDK.Foundation.Changenotifier.Listenable), FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: animation)
        {
            this.Builder = builder;
            this.Child = child;
        }
        /// <Summary>
        /// Called every time the animation changes value.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.TransitionBuilder Builder { get; set; }
        /// <Summary>
        /// The child widget to pass to the [builder].
        ///
        /// If a [builder] callback's return value contains a subtree that does not
        /// depend on the animation, it's more efficient to build that subtree once
        /// instead of rebuilding it on every animation tick.
        ///
        /// If the pre-built subtree is passed as the [child] parameter, the
        /// [AnimatedBuilder] will pass it back to the [builder] function so that it
        /// can be incorporated into the build.
        ///
        /// Using this pre-built child is entirely optional, but can improve
        /// performance significantly in some cases and is therefore a good practice.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return Builder(context, Child);
        }



    }

}
