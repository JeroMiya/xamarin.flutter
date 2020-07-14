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
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Implicitanimations
{
    public delegate FlutterSDK.Animation.Tween.Tween<T> TweenConstructor<T>(T targetValue);
    public delegate FlutterSDK.Animation.Tween.Tween<T> TweenVisitor<T>(FlutterSDK.Animation.Tween.Tween<T> tween, T targetValue, FlutterSDK.Widgets.Implicitanimations.TweenConstructor<T> constructor);
    internal static class ImplicitanimationsDefaultClass
    {
    }

    /// <Summary>
    /// An abstract class for building widgets that animate changes to their
    /// properties.
    ///
    /// Widgets of this type will not animate when they are first added to the
    /// widget tree. Rather, when they are rebuilt with different values, they will
    /// respond to those _changes_ by animating the changes over a specified
    /// [duration].
    ///
    /// Which properties are animated is left up to the subclass. Subclasses' [State]s
    /// must extend [ImplicitlyAnimatedWidgetState] and provide a way to visit the
    /// relevant fields to animate.
    ///
    /// ## Relationship to [AnimatedWidget]s
    ///
    /// [ImplicitlyAnimatedWidget]s (and their subclasses) automatically animate
    /// changes in their properties whenever they change. For this,
    /// they create and manage their own internal [AnimationController]s to power
    /// the animation. While these widgets are simple to use and don't require you
    /// to manually manage the lifecycle of an [AnimationController], they
    /// are also somewhat limited: Besides the target value for the animated
    /// property, developers can only chose a [duration] and [curve] for the
    /// animation. If you require more control over the animation (e.g. you want
    /// to stop it somewhere in the middle), consider using a
    /// [AnimatedWidget] or one of its subclasses. These widget take an [Animation]
    /// as an argument to power the animation. This gives the developer full control
    /// over the animation at the cost of requiring you to manually manage the
    /// underlying [AnimationController].
    ///
    /// ## Common implicitly animated widgets
    ///
    /// A number of implicitly animated widgets ship with the framework. They are
    /// usually named `AnimatedFoo`, where `Foo` is the name of the non-animated
    /// version of that widget. Commonly used implicitly animated widgets include:
    ///
    ///  * [TweenAnimationBuilder], which animates any property expressed by
    ///    a [Tween] to a specified target value.
    ///  * [AnimatedAlign], which is an implicitly animated version of [Align].
    ///  * [AnimatedContainer], which is an implicitly animated version of
    ///    [Container].
    ///  * [AnimatedDefaultTextStyle], which is an implicitly animated version of
    ///    [DefaultTextStyle].
    ///  * [AnimatedOpacity], which is an implicitly animated version of [Opacity].
    ///  * [AnimatedPadding], which is an implicitly animated version of [Padding].
    ///  * [AnimatedPhysicalModel], which is an implicitly animated version of
    ///    [PhysicalModel].
    ///  * [AnimatedPositioned], which is an implicitly animated version of
    ///    [Positioned].
    ///  * [AnimatedPositionedDirectional], which is an implicitly animated version
    ///    of [PositionedDirectional].
    ///  * [AnimatedTheme], which is an implicitly animated version of [Theme].
    ///  * [AnimatedCrossFade], which cross-fades between two given children and
    ///    animates itself between their sizes.
    ///  * [AnimatedSize], which automatically transitions its size over a given
    ///    duration.
    ///  * [AnimatedSwitcher], which fades from one widget to another.
    /// </Summary>
    public interface IImplicitlyAnimatedWidget
    {
        FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget> CreateState();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Animation.Curves.Curve Curve { get; }
        TimeSpan Duration { get; }
        VoidCallback OnEnd { get; }
    }


    /// <Summary>
    /// A base class for the `State` of widgets with implicit animations.
    ///
    /// [ImplicitlyAnimatedWidgetState] requires that subclasses respond to the
    /// animation themselves. If you would like `setState()` to be called
    /// automatically as the animation changes, use [AnimatedWidgetBaseState].
    ///
    /// Properties that subclasses choose to animate are represented by [Tween]
    /// instances. Subclasses must implement the [forEachTween] method to allow
    /// [ImplicitlyAnimatedWidgetState] to iterate through the widget's fields and
    /// animate them.
    /// </Summary>
    public interface IImplicitlyAnimatedWidgetState<T>
    {
        void InitState();
        void DidUpdateWidget(T oldWidget);
        void Dispose();
        void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor);
        void DidUpdateTweens();
        FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; }
        FlutterSDK.Animation.Animation.Animation<double> Animation { get; }
    }


    /// <Summary>
    /// A base class for widgets with implicit animations that need to rebuild their
    /// widget tree as the animation runs.
    ///
    /// This class calls [build] each frame that the animation tickets. For a
    /// variant that does not rebuild each frame, consider subclassing
    /// [ImplicitlyAnimatedWidgetState] directly.
    ///
    /// Subclasses must implement the [forEachTween] method to allow
    /// [AnimatedWidgetBaseState] to iterate through the subclasses' widget's fields
    /// and animate them.
    /// </Summary>
    public interface IAnimatedWidgetBaseState<T>
    {
        void InitState();
    }


    /// <Summary>
    /// An interpolation between two [BoxConstraints].
    ///
    /// This class specializes the interpolation of [Tween<BoxConstraints>] to use
    /// [BoxConstraints.lerp].
    ///
    /// See [Tween] for a discussion on how to use interpolation objects.
    /// </Summary>
    public class BoxConstraintsTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Rendering.Box.BoxConstraints>
    {
        #region constructors
        public BoxConstraintsTween(FlutterSDK.Rendering.Box.BoxConstraints begin = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Rendering.Box.BoxConstraints end = default(FlutterSDK.Rendering.Box.BoxConstraints))
        : base(begin: begin, end: end)
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    /// <Summary>
    /// Returns the value this variable has at the given animation clock value.
    /// </Summary>
    public new FlutterSDK.Rendering.Box.BoxConstraints Lerp(double t) => BoxDefaultClass.BoxConstraints.Lerp(Begin, End, t);


    #endregion
}


/// <Summary>
/// An interpolation between two [Decoration]s.
///
/// This class specializes the interpolation of [Tween<BoxConstraints>] to use
/// [Decoration.lerp].
///
/// For [ShapeDecoration]s which know how to [ShapeDecoration.lerpTo] or
/// [ShapeDecoration.lerpFrom] each other, this will produce a smooth
/// interpolation between decorations.
///
/// See also:
///
///  * [Tween] for a discussion on how to use interpolation objects.
///  * [ShapeDecoration], [RoundedRectangleBorder], [CircleBorder], and
///    [StadiumBorder] for examples of shape borders that can be smoothly
///    interpolated.
///  * [BoxBorder] for a border that can only be smoothly interpolated between other
///    [BoxBorder]s.
/// </Summary>
public class DecorationTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Decoration.Decoration>
{
    #region constructors
    public DecorationTween(FlutterSDK.Painting.Decoration.Decoration begin = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Decoration.Decoration end = default(FlutterSDK.Painting.Decoration.Decoration))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Decoration.Decoration Lerp(double t) => DecorationDefaultClass.Decoration.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two [EdgeInsets]s.
///
/// This class specializes the interpolation of [Tween<EdgeInsets>] to use
/// [EdgeInsets.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
///
/// See also:
///
///  * [EdgeInsetsGeometryTween], which interpolates between two
///    [EdgeInsetsGeometry] objects.
/// </Summary>
public class EdgeInsetsTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Edgeinsets.EdgeInsets>
{
    #region constructors
    public EdgeInsetsTween(FlutterSDK.Painting.Edgeinsets.EdgeInsets begin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets end = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Lerp(double t) => EdgeinsetsDefaultClass.EdgeInsets.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two [EdgeInsetsGeometry]s.
///
/// This class specializes the interpolation of [Tween<EdgeInsetsGeometry>] to
/// use [EdgeInsetsGeometry.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
///
/// See also:
///
///  * [EdgeInsetsTween], which interpolates between two [EdgeInsets] objects.
/// </Summary>
public class EdgeInsetsGeometryTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry>
{
    #region constructors
    public EdgeInsetsGeometryTween(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry begin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry end = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Lerp(double t) => EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two [BorderRadius]s.
///
/// This class specializes the interpolation of [Tween<BorderRadius>] to use
/// [BorderRadius.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class BorderRadiusTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Borderradius.BorderRadius>
{
    #region constructors
    public BorderRadiusTween(FlutterSDK.Painting.Borderradius.BorderRadius begin = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borderradius.BorderRadius end = default(FlutterSDK.Painting.Borderradius.BorderRadius))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Borderradius.BorderRadius Lerp(double t) => BorderradiusDefaultClass.BorderRadius.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two [Border]s.
///
/// This class specializes the interpolation of [Tween<Border>] to use
/// [Border.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class BorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Boxborder.Border>
{
    #region constructors
    public BorderTween(FlutterSDK.Painting.Boxborder.Border begin = default(FlutterSDK.Painting.Boxborder.Border), FlutterSDK.Painting.Boxborder.Border end = default(FlutterSDK.Painting.Boxborder.Border))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Boxborder.Border Lerp(double t) => BoxborderDefaultClass.Border.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two [Matrix4]s.
///
/// This class specializes the interpolation of [Tween<Matrix4>] to be
/// appropriate for transformation matrices.
///
/// Currently this class works only for translations.
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class Matrix4Tween : FlutterSDK.Animation.Tween.Tween<object>
{
    #region constructors
    public Matrix4Tween(Matrix4 begin = default(Matrix4), Matrix4 end = default(Matrix4))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

public new Matrix4 Lerp(double t)
{


    Vector3 beginTranslation = Vector3.Zero();
    Vector3 endTranslation = Vector3.Zero();
    Quaternion beginRotation = Quaternion.Identity();
    Quaternion endRotation = Quaternion.Identity();
    Vector3 beginScale = Vector3.Zero();
    Vector3 endScale = Vector3.Zero();
    Begin.Decompose(beginTranslation, beginRotation, beginScale);
    End.Decompose(endTranslation, endRotation, endScale);
    Vector3 lerpTranslation = beginTranslation * (1.0 - t) + endTranslation * t;
    Quaternion lerpRotation = (beginRotation.Scaled(1.0 - t) + endRotation.Scaled(t)).Normalized();
    Vector3 lerpScale = beginScale * (1.0 - t) + endScale * t;
    return Matrix4.Compose(lerpTranslation, lerpRotation, lerpScale);
}



#endregion
}


/// <Summary>
/// An interpolation between two [TextStyle]s.
///
/// This class specializes the interpolation of [Tween<TextStyle>] to use
/// [TextStyle.lerp].
///
/// This will not work well if the styles don't set the same fields.
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class TextStyleTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Textstyle.TextStyle>
{
    #region constructors
    public TextStyleTween(FlutterSDK.Painting.Textstyle.TextStyle begin = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle end = default(FlutterSDK.Painting.Textstyle.TextStyle))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Textstyle.TextStyle Lerp(double t) => TextstyleDefaultClass.TextStyle.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An abstract class for building widgets that animate changes to their
/// properties.
///
/// Widgets of this type will not animate when they are first added to the
/// widget tree. Rather, when they are rebuilt with different values, they will
/// respond to those _changes_ by animating the changes over a specified
/// [duration].
///
/// Which properties are animated is left up to the subclass. Subclasses' [State]s
/// must extend [ImplicitlyAnimatedWidgetState] and provide a way to visit the
/// relevant fields to animate.
///
/// ## Relationship to [AnimatedWidget]s
///
/// [ImplicitlyAnimatedWidget]s (and their subclasses) automatically animate
/// changes in their properties whenever they change. For this,
/// they create and manage their own internal [AnimationController]s to power
/// the animation. While these widgets are simple to use and don't require you
/// to manually manage the lifecycle of an [AnimationController], they
/// are also somewhat limited: Besides the target value for the animated
/// property, developers can only chose a [duration] and [curve] for the
/// animation. If you require more control over the animation (e.g. you want
/// to stop it somewhere in the middle), consider using a
/// [AnimatedWidget] or one of its subclasses. These widget take an [Animation]
/// as an argument to power the animation. This gives the developer full control
/// over the animation at the cost of requiring you to manually manage the
/// underlying [AnimationController].
///
/// ## Common implicitly animated widgets
///
/// A number of implicitly animated widgets ship with the framework. They are
/// usually named `AnimatedFoo`, where `Foo` is the name of the non-animated
/// version of that widget. Commonly used implicitly animated widgets include:
///
///  * [TweenAnimationBuilder], which animates any property expressed by
///    a [Tween] to a specified target value.
///  * [AnimatedAlign], which is an implicitly animated version of [Align].
///  * [AnimatedContainer], which is an implicitly animated version of
///    [Container].
///  * [AnimatedDefaultTextStyle], which is an implicitly animated version of
///    [DefaultTextStyle].
///  * [AnimatedOpacity], which is an implicitly animated version of [Opacity].
///  * [AnimatedPadding], which is an implicitly animated version of [Padding].
///  * [AnimatedPhysicalModel], which is an implicitly animated version of
///    [PhysicalModel].
///  * [AnimatedPositioned], which is an implicitly animated version of
///    [Positioned].
///  * [AnimatedPositionedDirectional], which is an implicitly animated version
///    of [PositionedDirectional].
///  * [AnimatedTheme], which is an implicitly animated version of [Theme].
///  * [AnimatedCrossFade], which cross-fades between two given children and
///    animates itself between their sizes.
///  * [AnimatedSize], which automatically transitions its size over a given
///    duration.
///  * [AnimatedSwitcher], which fades from one widget to another.
/// </Summary>
public class ImplicitlyAnimatedWidget : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public ImplicitlyAnimatedWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
public virtual TimeSpan Duration { get; set; }
public virtual VoidCallback OnEnd { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget> CreateState()
{
    return default(ImplicitlyAnimatedWidgetState<ImplicitlyAnimatedWidget>);
}


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new IntProperty("duration", Duration.InMilliseconds, unit: "ms"));
}



#endregion
}


/// <Summary>
/// A base class for the `State` of widgets with implicit animations.
///
/// [ImplicitlyAnimatedWidgetState] requires that subclasses respond to the
/// animation themselves. If you would like `setState()` to be called
/// automatically as the animation changes, use [AnimatedWidgetBaseState].
///
/// Properties that subclasses choose to animate are represented by [Tween]
/// instances. Subclasses must implement the [forEachTween] method to allow
/// [ImplicitlyAnimatedWidgetState] to iterate through the widget's fields and
/// animate them.
/// </Summary>
public class ImplicitlyAnimatedWidgetState<T> : FlutterSDK.Widgets.Framework.State<T>, ISingleTickerProviderStateMixin<T>
{
    #region constructors
    public ImplicitlyAnimatedWidgetState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
    public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _Controller = new AnimationController(duration: Widget.Duration, debugLabel: ConstantsDefaultClass.KDebugMode ? Widget.ToStringShort() : null, vsync: this);
        _Controller.AddStatusListener((AnimationStatus status) =>
        {
            switch (status) { case AnimationStatus.Completed: if (Widget.OnEnd != null) Widget.OnEnd(); break; case AnimationStatus.Dismissed: case AnimationStatus.Forward: case AnimationStatus.Reverse: }
        }
        );
        _UpdateCurve();
        _ConstructTweens();
        DidUpdateTweens();
    }




    public new void DidUpdateWidget(T oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        if (Widget.Curve != oldWidget.Curve) _UpdateCurve();
        _Controller.Duration = Widget.Duration;
        if (_ConstructTweens())
        {
            ForEachTween((Tween<object> tween, object targetValue, TweenConstructor<object> constructor) =>
            {
                _UpdateTween(tween, targetValue);
                return tween;
            }
            );
            ..Value = 0.0;
            _Controller.Forward();
            DidUpdateTweens();
        }

    }




    private void _UpdateCurve()
    {
        if (Widget.Curve != null) _Animation = new CurvedAnimation(parent: _Controller, curve: Widget.Curve); else _Animation = _Controller;
    }




    public new void Dispose()
    {
        _Controller.Dispose();
        base.Dispose();
    }




    private bool _ShouldAnimateTween(FlutterSDK.Animation.Tween.Tween<object> tween, object targetValue)
    {
        return targetValue != (tween.End ?? tween.Begin);
    }




    private void _UpdateTween(FlutterSDK.Animation.Tween.Tween<object> tween, object targetValue)
    {
        if (tween == null) return;
        ..Begin = tween.Evaluate(_Animation)..End = targetValue;
    }




    private bool _ConstructTweens()
    {
        bool shouldStartAnimation = false;
        ForEachTween((Tween<object> tween, object targetValue, TweenConstructor<object> constructor) =>
        {
            if (targetValue != null)
            {
                tween = (tween == null ? constructor(targetValue) : tween);
                if (_ShouldAnimateTween(tween, targetValue)) shouldStartAnimation = true;
            }
            else
            {
                tween = null;
            }

            return tween;
        }
        );
        return shouldStartAnimation;
    }




    /// <Summary>
    /// Visits each tween controlled by this state with the specified `visitor`
    /// function.
    ///
    /// ### Subclass responsibility
    ///
    /// Properties to be animated are represented by [Tween] member variables in
    /// the state. For each such tween, [forEachTween] implementations are
    /// expected to call `visitor` with the appropriate arguments and store the
    /// result back into the member variable. The arguments to `visitor` are as
    /// follows:
    ///
    /// {@macro flutter.widgets.implicit_animations.tweenVisitorArguments}
    ///
    /// ### When this method will be called
    ///
    /// [forEachTween] is initially called during [initState]. It is expected that
    /// the visitor's `tween` argument will be set to null, causing the visitor to
    /// call its `constructor` argument to construct the tween for the first time.
    /// The resulting tween will have its `begin` value set to the target value
    /// and will have its `end` value set to null. The animation will not be
    /// started.
    ///
    /// When this state's [widget] is updated (thus triggering the
    /// [didUpdateWidget] method to be called), [forEachTween] will be called
    /// again to check if the target value has changed. If the target value has
    /// changed, signaling that the [animation] should start, then the visitor
    /// will update the tween's `start` and `end` values accordingly, and the
    /// animation will be started.
    ///
    /// ### Other member variables
    ///
    /// Subclasses that contain properties based on tweens created by
    /// [forEachTween] should override [didUpdateTweens] to update those
    /// properties. Dependent properties should not be updated within
    /// [forEachTween].
    ///
    /// {@tool snippet}
    ///
    /// This sample implements an implicitly animated widget's `State`.
    /// The widget animates between colors whenever `widget.targetColor`
    /// changes.
    ///
    /// ```dart
    /// class MyWidgetState extends AnimatedWidgetBaseState<MyWidget> {
    ///   ColorTween _colorTween;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Text(
    ///       'Hello World',
    ///       // Computes the value of the text color at any given time.
    ///       style: TextStyle(color: _colorTween.evaluate(animation)),
    ///     );
    ///   }
    ///
    ///   @override
    ///   void forEachTween(TweenVisitor<dynamic> visitor) {
    ///     // Update the tween using the provided visitor function.
    ///     _colorTween = visitor(
    ///       // The latest tween value. Can be `null`.
    ///       _colorTween,
    ///       // The color value toward which we are animating.
    ///       widget.targetColor,
    ///       // A function that takes a color value and returns a tween
    ///       // beginning at that value.
    ///       (value) => ColorTween(begin: value),
    ///     );
    ///
    ///     // We could have more tweens than one by using the visitor
    ///     // multiple times.
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public virtual void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
    }


    /// <Summary>
    /// Optional hook for subclasses that runs after all tweens have been updated
    /// via [forEachTween].
    ///
    /// Any properties that depend upon tweens created by [forEachTween] should be
    /// updated within [didUpdateTweens], not within [forEachTween].
    ///
    /// This method will be called both:
    ///
    ///  1. After the tweens are _initially_ constructed (by
    ///     the `constructor` argument to the [TweenVisitor] that's passed to
    ///     [forEachTween]). In this case, the tweens are likely to contain only
    ///     a [Tween.begin] value and not a [Tween.end].
    ///
    ///  2. When the state's [widget] is updated, and one or more of the tweens
    ///     visited by [forEachTween] specifies a target value that's different
    ///     than the widget's current value, thus signaling that the [animation]
    ///     should run. In this case, the [Tween.begin] value for each tween will
    ///     an evaluation of the tween against the current [animation], and the
    ///     [Tween.end] value for each tween will be the target value.
    /// </Summary>
    public virtual void DidUpdateTweens()
    {
    }



    #endregion
}


/// <Summary>
/// A base class for widgets with implicit animations that need to rebuild their
/// widget tree as the animation runs.
///
/// This class calls [build] each frame that the animation tickets. For a
/// variant that does not rebuild each frame, consider subclassing
/// [ImplicitlyAnimatedWidgetState] directly.
///
/// Subclasses must implement the [forEachTween] method to allow
/// [AnimatedWidgetBaseState] to iterate through the subclasses' widget's fields
/// and animate them.
/// </Summary>
public class AnimatedWidgetBaseState<T> : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<T>
{
    #region constructors
    public AnimatedWidgetBaseState()
    { }
    #endregion

    #region fields
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        Controller.AddListener(_HandleAnimationChanged);
    }




    private void _HandleAnimationChanged()
    {
        SetState(() =>
        {
        }
        );
    }



    #endregion
}


/// <Summary>
/// Animated version of [Container] that gradually changes its values over a period of time.
///
/// The [AnimatedContainer] will automatically animate between the old and
/// new values of properties when they change using the provided curve and
/// duration. Properties that are null are not animated. Its child and
/// descendants are not animated.
///
/// This class is useful for generating simple implicit transitions between
/// different parameters to [Container] with its internal [AnimationController].
/// For more complex animations, you'll likely want to use a subclass of
/// [AnimatedWidget] such as the [DecoratedBoxTransition] or use your own
/// [AnimationController].
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=yI-8QHpGIP4}
///
/// {@tool dartpad --template=stateful_widget_scaffold}
///
/// The following example (depicted above) transitions an AnimatedContainer
/// between two states. It adjusts the [height], [width], [color], and
/// [alignment] properties when tapped.
///
/// ```dart
/// bool selected = false;
///
/// @override
/// Widget build(BuildContext context) {
///   return GestureDetector(
///     onTap: () {
///       setState(() {
///         selected = !selected;
///       });
///     },
///     child: Center(
///       child: AnimatedContainer(
///         width: selected ? 200.0 : 100.0,
///         height: selected ? 100.0 : 200.0,
///         color: selected ? Colors.red : Colors.blue,
///         alignment: selected ? Alignment.center : AlignmentDirectional.topCenter,
///         duration: Duration(seconds: 2),
///         curve: Curves.fastOutSlowIn,
///         child: FlutterLogo(size: 75),
///       ),
///     ),
///   );
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [AnimatedPadding], which is a subset of this widget that only
///    supports animating the [padding].
///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
///  * [AnimatedPositioned], which, as a child of a [Stack], automatically
///    transitions its child's position over a given duration whenever the given
///    position changes.
///  * [AnimatedAlign], which automatically transitions its child's
///    position over a given duration whenever the given [alignment] changes.
///  * [AnimatedSwitcher], which switches out a child for a new one with a customizable transition.
///  * [AnimatedCrossFade], which fades between two children and interpolates their sizes.
/// </Summary>
public class AnimatedContainer : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Decoration.Decoration foregroundDecoration = default(FlutterSDK.Painting.Decoration.Decoration), double width = default(double), double height = default(double), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), Matrix4 transform = default(Matrix4), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
public virtual FlutterSDK.Painting.Decoration.Decoration ForegroundDecoration { get; set; }
public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
public virtual Matrix4 Transform { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedContainerState CreateState() => new _AnimatedContainerState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment, showName: false, defaultValue: null));
    properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
    properties.Add(new DiagnosticsProperty<Decoration>("bg", Decoration, defaultValue: null));
    properties.Add(new DiagnosticsProperty<Decoration>("fg", ForegroundDecoration, defaultValue: null));
    properties.Add(new DiagnosticsProperty<BoxConstraints>("constraints", Constraints, defaultValue: null, showName: false));
    properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("margin", Margin, defaultValue: null));
    properties.Add(ObjectFlagProperty<Matrix4>.Has("transform", Transform));
}



#endregion
}


public class _AnimatedContainerState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedContainer>
{
    #region constructors
    public _AnimatedContainerState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Rendering.Tweens.AlignmentGeometryTween _Alignment { get; set; }
    internal virtual FlutterSDK.Widgets.Implicitanimations.EdgeInsetsGeometryTween _Padding { get; set; }
    internal virtual FlutterSDK.Widgets.Implicitanimations.DecorationTween _Decoration { get; set; }
    internal virtual FlutterSDK.Widgets.Implicitanimations.DecorationTween _ForegroundDecoration { get; set; }
    internal virtual FlutterSDK.Widgets.Implicitanimations.BoxConstraintsTween _Constraints { get; set; }
    internal virtual FlutterSDK.Widgets.Implicitanimations.EdgeInsetsGeometryTween _Margin { get; set; }
    internal virtual FlutterSDK.Widgets.Implicitanimations.Matrix4Tween _Transform { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Alignment = visitor(_Alignment, Widget.Alignment, (object value) => =>new AlignmentGeometryTween(begin: value as AlignmentGeometry)) as AlignmentGeometryTween;
        _Padding = visitor(_Padding, Widget.Padding, (object value) => =>new EdgeInsetsGeometryTween(begin: value as EdgeInsetsGeometry)) as EdgeInsetsGeometryTween;
        _Decoration = visitor(_Decoration, Widget.Decoration, (object value) => =>new DecorationTween(begin: value as Decoration)) as DecorationTween;
        _ForegroundDecoration = visitor(_ForegroundDecoration, Widget.ForegroundDecoration, (object value) => =>new DecorationTween(begin: value as Decoration)) as DecorationTween;
        _Constraints = visitor(_Constraints, Widget.Constraints, (object value) => =>new BoxConstraintsTween(begin: value as BoxConstraints)) as BoxConstraintsTween;
        _Margin = visitor(_Margin, Widget.Margin, (object value) => =>new EdgeInsetsGeometryTween(begin: value as EdgeInsetsGeometry)) as EdgeInsetsGeometryTween;
        _Transform = visitor(_Transform, Widget.Transform, (object value) => =>new Matrix4Tween(begin: value as Matrix4)) as Matrix4Tween;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new Container(child: Widget.Child, alignment: _Alignment?.Evaluate(Animation), padding: _Padding?.Evaluate(Animation), decoration: _Decoration?.Evaluate(Animation), foregroundDecoration: _ForegroundDecoration?.Evaluate(Animation), constraints: _Constraints?.Evaluate(Animation), margin: _Margin?.Evaluate(Animation), transform: _Transform?.Evaluate(Animation));
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
    {
        base.DebugFillProperties(description);
        description.Add(new DiagnosticsProperty<AlignmentGeometryTween>("alignment", _Alignment, showName: false, defaultValue: null));
        description.Add(new DiagnosticsProperty<EdgeInsetsGeometryTween>("padding", _Padding, defaultValue: null));
        description.Add(new DiagnosticsProperty<DecorationTween>("bg", _Decoration, defaultValue: null));
        description.Add(new DiagnosticsProperty<DecorationTween>("fg", _ForegroundDecoration, defaultValue: null));
        description.Add(new DiagnosticsProperty<BoxConstraintsTween>("constraints", _Constraints, showName: false, defaultValue: null));
        description.Add(new DiagnosticsProperty<EdgeInsetsGeometryTween>("margin", _Margin, defaultValue: null));
        description.Add(ObjectFlagProperty<Matrix4Tween>.Has("transform", _Transform));
    }



    #endregion
}


/// <Summary>
/// Animated version of [Padding] which automatically transitions the
/// indentation over a given duration whenever the given inset changes.
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=PY2m0fhGNz4}
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.fastOutSlowIn].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_padding.mp4}
///
/// See also:
///
///  * [AnimatedContainer], which can transition more values at once.
///  * [AnimatedAlign], which automatically transitions its child's
///    position over a given duration whenever the given [alignment] changes.
/// </Summary>
public class AnimatedPadding : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedPadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedPaddingState CreateState() => new _AnimatedPaddingState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding));
}



#endregion
}


public class _AnimatedPaddingState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPadding>
{
    #region constructors
    public _AnimatedPaddingState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Implicitanimations.EdgeInsetsGeometryTween _Padding { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Padding = visitor(_Padding, Widget.Padding, (object value) => =>new EdgeInsetsGeometryTween(begin: value as EdgeInsetsGeometry)) as EdgeInsetsGeometryTween;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new Padding(padding: _Padding.Evaluate(Animation).Clamp(EdgeinsetsDefaultClass.EdgeInsets.Zero, EdgeinsetsDefaultClass.EdgeInsetsGeometry.Infinity), child: Widget.Child);
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
    {
        base.DebugFillProperties(description);
        description.Add(new DiagnosticsProperty<EdgeInsetsGeometryTween>("padding", _Padding, defaultValue: null));
    }



    #endregion
}


/// <Summary>
/// Animated version of [Align] which automatically transitions the child's
/// position over a given duration whenever the given [alignment] changes.
///
/// Here's an illustration of what this can look like, using a [curve] of
/// [Curves.fastOutSlowIn].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_align.mp4}
///
/// For the animation, you can chose a [curve] as well as a [duration] and the
/// widget will automatically animate to the new target [alignment]. If you require
/// more control over the animation (e.g. if you want to stop it mid-animation),
/// consider using an [AlignTransition] instead, which takes a provided
/// [Animation] as argument. While that allows you to fine-tune the animation,
/// it also requires more development overhead as you have to manually manage
/// the lifecycle of the underlying [AnimationController].
///
/// See also:
///
///  * [AnimatedContainer], which can transition more values at once.
///  * [AnimatedPadding], which can animate the padding instead of the
///    alignment.
///  * [AnimatedPositioned], which, as a child of a [Stack], automatically
///    transitions its child's position over a given duration whenever the given
///    position changes.
/// </Summary>
public class AnimatedAlign : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedAlign(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedAlignState CreateState() => new _AnimatedAlignState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment));
}



#endregion
}


public class _AnimatedAlignState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedAlign>
{
    #region constructors
    public _AnimatedAlignState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Rendering.Tweens.AlignmentGeometryTween _Alignment { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Alignment = visitor(_Alignment, Widget.Alignment, (object value) => =>new AlignmentGeometryTween(begin: value as AlignmentGeometry)) as AlignmentGeometryTween;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new Align(alignment: _Alignment.Evaluate(Animation), child: Widget.Child);
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
    {
        base.DebugFillProperties(description);
        description.Add(new DiagnosticsProperty<AlignmentGeometryTween>("alignment", _Alignment, defaultValue: null));
    }



    #endregion
}


/// <Summary>
/// Animated version of [Positioned] which automatically transitions the child's
/// position over a given duration whenever the given position changes.
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=hC3s2YdtWt8}
///
/// Only works if it's the child of a [Stack].
///
/// This widget is a good choice if the _size_ of the child would end up
/// changing as a result of this animation. If the size is intended to remain
/// the same, with only the _position_ changing over time, then consider
/// [SlideTransition] instead. [SlideTransition] only triggers a repaint each
/// frame of the animation, whereas [AnimatedPositioned] will trigger a relayout
/// as well.
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.fastOutSlowIn].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_positioned.mp4}
///
/// For the animation, you can chose a [curve] as well as a [duration] and the
/// widget will automatically animate to the new target position. If you require
/// more control over the animation (e.g. if you want to stop it mid-animation),
/// consider using an [PositionedTransition] instead, which takes a provided
/// [Animation] as argument. While that allows you to fine-tune the animation,
/// it also requires more development overhead as you have to manually manage
/// the lifecycle of the underlying [AnimationController].
///
/// See also:
///
///  * [AnimatedPositionedDirectional], which adapts to the ambient
///    [Directionality] (the same as this widget, but for animating
///    [PositionedDirectional]).
/// </Summary>
public class AnimatedPositioned : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedPositioned(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double left = default(double), double top = default(double), double right = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
public static AnimatedPositioned FromRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual double Left { get; set; }
public virtual double Top { get; set; }
public virtual double Right { get; set; }
public virtual double Bottom { get; set; }
public virtual double Width { get; set; }
public virtual double Height { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedPositionedState CreateState() => new _AnimatedPositionedState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("left", Left, defaultValue: null));
    properties.Add(new DoubleProperty("top", Top, defaultValue: null));
    properties.Add(new DoubleProperty("right", Right, defaultValue: null));
    properties.Add(new DoubleProperty("bottom", Bottom, defaultValue: null));
    properties.Add(new DoubleProperty("width", Width, defaultValue: null));
    properties.Add(new DoubleProperty("height", Height, defaultValue: null));
}



#endregion
}


public class _AnimatedPositionedState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPositioned>
{
    #region constructors
    public _AnimatedPositionedState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Left { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Top { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Right { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Bottom { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Width { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Height { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Left = visitor(_Left, Widget.Left, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Top = visitor(_Top, Widget.Top, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Right = visitor(_Right, Widget.Right, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Bottom = visitor(_Bottom, Widget.Bottom, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Width = visitor(_Width, Widget.Width, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Height = visitor(_Height, Widget.Height, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new Positioned(child: Widget.Child, left: _Left?.Evaluate(Animation), top: _Top?.Evaluate(Animation), right: _Right?.Evaluate(Animation), bottom: _Bottom?.Evaluate(Animation), width: _Width?.Evaluate(Animation), height: _Height?.Evaluate(Animation));
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
    {
        base.DebugFillProperties(description);
        description.Add(ObjectFlagProperty<Tween<double>>.Has("left", _Left));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("top", _Top));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("right", _Right));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("bottom", _Bottom));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("width", _Width));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("height", _Height));
    }



    #endregion
}


/// <Summary>
/// Animated version of [PositionedDirectional] which automatically transitions
/// the child's position over a given duration whenever the given position
/// changes.
///
/// The ambient [Directionality] is used to determine whether [start] is to the
/// left or to the right.
///
/// Only works if it's the child of a [Stack].
///
/// This widget is a good choice if the _size_ of the child would end up
/// changing as a result of this animation. If the size is intended to remain
/// the same, with only the _position_ changing over time, then consider
/// [SlideTransition] instead. [SlideTransition] only triggers a repaint each
/// frame of the animation, whereas [AnimatedPositionedDirectional] will trigger
/// a relayout as well. ([SlideTransition] is also text-direction-aware.)
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.fastOutSlowIn].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_positioned_directional.mp4}
///
/// See also:
///
///  * [AnimatedPositioned], which specifies the widget's position visually (the
///    same as this widget, but for animating [Positioned]).
/// </Summary>
public class AnimatedPositionedDirectional : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedPositionedDirectional(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double start = default(double), double top = default(double), double end = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual double Start { get; set; }
public virtual double Top { get; set; }
public virtual double End { get; set; }
public virtual double Bottom { get; set; }
public virtual double Width { get; set; }
public virtual double Height { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedPositionedDirectionalState CreateState() => new _AnimatedPositionedDirectionalState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("start", Start, defaultValue: null));
    properties.Add(new DoubleProperty("top", Top, defaultValue: null));
    properties.Add(new DoubleProperty("end", End, defaultValue: null));
    properties.Add(new DoubleProperty("bottom", Bottom, defaultValue: null));
    properties.Add(new DoubleProperty("width", Width, defaultValue: null));
    properties.Add(new DoubleProperty("height", Height, defaultValue: null));
}



#endregion
}


public class _AnimatedPositionedDirectionalState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPositionedDirectional>
{
    #region constructors
    public _AnimatedPositionedDirectionalState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Start { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Top { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _End { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Bottom { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Width { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Height { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Start = visitor(_Start, Widget.Start, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Top = visitor(_Top, Widget.Top, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _End = visitor(_End, Widget.End, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Bottom = visitor(_Bottom, Widget.Bottom, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Width = visitor(_Width, Widget.Width, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Height = visitor(_Height, Widget.Height, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {

        return Positioned.Directional(textDirection: BasicDefaultClass.Directionality.Of(context), child: Widget.Child, start: _Start?.Evaluate(Animation), top: _Top?.Evaluate(Animation), end: _End?.Evaluate(Animation), bottom: _Bottom?.Evaluate(Animation), width: _Width?.Evaluate(Animation), height: _Height?.Evaluate(Animation));
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
    {
        base.DebugFillProperties(description);
        description.Add(ObjectFlagProperty<Tween<double>>.Has("start", _Start));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("top", _Top));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("end", _End));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("bottom", _Bottom));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("width", _Width));
        description.Add(ObjectFlagProperty<Tween<double>>.Has("height", _Height));
    }



    #endregion
}


/// <Summary>
/// Animated version of [Opacity] which automatically transitions the child's
/// opacity over a given duration whenever the given opacity changes.
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=QZAvjqOqiLY}
///
/// Animating an opacity is relatively expensive because it requires painting
/// the child into an intermediate buffer.
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.fastOutSlowIn].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_opacity.mp4}
///
/// {@tool snippet}
///
/// ```dart
/// class LogoFade extends StatefulWidget {
///   @override
///   createState() => LogoFadeState();
/// }
///
/// class LogoFadeState extends State<LogoFade> {
///   double opacityLevel = 1.0;
///
///   void _changeOpacity() {
///     setState(() => opacityLevel = opacityLevel == 0 ? 1.0 : 0.0);
///   }
///
///   @override
///   Widget build(BuildContext context) {
///     return Column(
///       mainAxisAlignment: MainAxisAlignment.center,
///       children: [
///         AnimatedOpacity(
///           opacity: opacityLevel,
///           duration: Duration(seconds: 3),
///           child: FlutterLogo(),
///         ),
///         RaisedButton(
///           child: Text('Fade Logo'),
///           onPressed: _changeOpacity,
///         ),
///       ],
///     );
///   }
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [AnimatedCrossFade], for fading between two children.
///  * [AnimatedSwitcher], for fading between many children in sequence.
///  * [FadeTransition], an explicitly animated version of this widget, where
///    an [Animation] is provided by the caller instead of being built in.
///  * [SliverAnimatedOpacity], for automatically transitioning a sliver's
///    opacity over a given duration whenever the given opacity changes.
/// </Summary>
public class AnimatedOpacity : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedOpacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double opacity = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback), bool alwaysIncludeSemantics = false)
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual double Opacity { get; set; }
public virtual bool AlwaysIncludeSemantics { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedOpacityState CreateState() => new _AnimatedOpacityState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("opacity", Opacity));
}



#endregion
}


public class _AnimatedOpacityState : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.AnimatedOpacity>
{
    #region constructors
    public _AnimatedOpacityState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Opacity { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Opacity = visitor(_Opacity, Widget.Opacity, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
    }




    public new void DidUpdateTweens()
    {
        _OpacityAnimation = Animation.Drive(_Opacity);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new FadeTransition(opacity: _OpacityAnimation, child: Widget.Child, alwaysIncludeSemantics: Widget.AlwaysIncludeSemantics);
    }



    #endregion
}


/// <Summary>
/// Animated version of [SliverOpacity] which automatically transitions the
/// sliver child's opacity over a given duration whenever the given opacity
/// changes.
///
/// Animating an opacity is relatively expensive because it requires painting
/// the sliver child into an intermediate buffer.
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.fastOutSlowIn].
///
/// {@tool dartpad --template=stateful_widget_scaffold_center_freeform_state}
/// Creates a [CustomScrollView] with a [SliverFixedExtentList] and a
/// [FloatingActionButton]. Pressing the button animates the lists' opacity.
///
/// ```dart
/// class _MyStatefulWidgetState extends State<MyStatefulWidget> with SingleTickerProviderStateMixin {
///   bool _visible = true;
///
///   Widget build(BuildContext context) {
///     return CustomScrollView(
///       slivers: <Widget>[
///         SliverAnimatedOpacity(
///           opacity: _visible ? 1.0 : 0.0,
///           duration: Duration(milliseconds: 500),
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
///         ),
///         SliverToBoxAdapter(
///           child: FloatingActionButton(
///             onPressed: () {
///               setState(() {
///                 _visible = !_visible;
///               });
///             },
///             tooltip: 'Toggle opacity',
///             child: Icon(Icons.flip),
///           )
///         ),
///       ]
///     );
///   }
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [SliverFadeTransition], an explicitly animated version of this widget, where
///    an [Animation] is provided by the caller instead of being built in.
///  * [AnimatedOpacity], for automatically transitioning a box child's
///    opacity over a given duration whenever the given opacity changes.
/// </Summary>
public class SliverAnimatedOpacity : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public SliverAnimatedOpacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget), double opacity = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback), bool alwaysIncludeSemantics = false)
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Sliver { get; set; }
public virtual double Opacity { get; set; }
public virtual bool AlwaysIncludeSemantics { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._SliverAnimatedOpacityState CreateState() => new _SliverAnimatedOpacityState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("opacity", Opacity));
}



#endregion
}


public class _SliverAnimatedOpacityState : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.SliverAnimatedOpacity>
{
    #region constructors
    public _SliverAnimatedOpacityState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Opacity { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Opacity = visitor(_Opacity, Widget.Opacity, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
    }




    public new void DidUpdateTweens()
    {
        _OpacityAnimation = Animation.Drive(_Opacity);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new SliverFadeTransition(opacity: _OpacityAnimation, sliver: Widget.Sliver, alwaysIncludeSemantics: Widget.AlwaysIncludeSemantics);
    }



    #endregion
}


/// <Summary>
/// Animated version of [DefaultTextStyle] which automatically transitions the
/// default text style (the text style to apply to descendant [Text] widgets
/// without explicit style) over a given duration whenever the given style
/// changes.
///
/// The [textAlign], [softWrap], [textOverflow], [maxLines], [textWidthBasis]
/// and [textHeightBehavior] properties are not animated and take effect
/// immediately when changed.
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.elasticInOut].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_default_text_style.mp4}
///
/// For the animation, you can chose a [curve] as well as a [duration] and the
/// widget will automatically animate to the new default text style. If you require
/// more control over the animation (e.g. if you want to stop it mid-animation),
/// consider using an [DefaultTextStyleTransition] instead, which takes a provided
/// [Animation] as argument. While that allows you to fine-tune the animation,
/// it also requires more development overhead as you have to manually manage
/// the lifecycle of the underlying [AnimationController].
/// </Summary>
public class AnimatedDefaultTextStyle : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedDefaultTextStyle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), TextAlign textAlign = default(TextAlign), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), int maxLines = default(int), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
public virtual TextAlign TextAlign { get; set; }
public virtual bool SoftWrap { get; set; }
public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
public virtual int MaxLines { get; set; }
public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
public virtual TextHeightBehavior TextHeightBehavior { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedDefaultTextStyleState CreateState() => new _AnimatedDefaultTextStyleState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    Style?.DebugFillProperties(properties);
    properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: null));
    properties.Add(new FlagProperty("softWrap", value: SoftWrap, ifTrue: "wrapping at box width", ifFalse: "no wrapping except at line break characters", showName: true));
    properties.Add(new EnumProperty<TextOverflow>("overflow", Overflow, defaultValue: null));
    properties.Add(new IntProperty("maxLines", MaxLines, defaultValue: null));
    properties.Add(new EnumProperty<TextWidthBasis>("textWidthBasis", TextWidthBasis, defaultValue: TextWidthBasis.Parent));
    properties.Add(new DiagnosticsProperty<Ui.Dart:uiDefaultClass.TextHeightBehavior>("textHeightBehavior", TextHeightBehavior, defaultValue: null));
}



#endregion
}


public class _AnimatedDefaultTextStyleState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedDefaultTextStyle>
{
    #region constructors
    public _AnimatedDefaultTextStyleState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Implicitanimations.TextStyleTween _Style { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Style = visitor(_Style, Widget.Style, (object value) => =>new TextStyleTween(begin: value as TextStyle)) as TextStyleTween;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new DefaultTextStyle(style: _Style.Evaluate(Animation), textAlign: Widget.TextAlign, softWrap: Widget.SoftWrap, overflow: Widget.Overflow, maxLines: Widget.MaxLines, textWidthBasis: Widget.TextWidthBasis, textHeightBehavior: Widget.TextHeightBehavior, child: Widget.Child);
    }



    #endregion
}


/// <Summary>
/// Animated version of [PhysicalModel].
///
/// The [borderRadius] and [elevation] are animated.
///
/// The [color] is animated if the [animateColor] property is set; otherwise,
/// the color changes immediately at the start of the animation for the other
/// two properties. This allows the color to be animated independently (e.g.
/// because it is being driven by an [AnimatedTheme]).
///
/// The [shape] is not animated.
///
/// Here's an illustration of what using this widget looks like, using a [curve]
/// of [Curves.fastOutSlowIn].
/// {@animation 250 266 https://flutter.github.io/assets-for-api-docs/assets/widgets/animated_physical_model.mp4}
/// </Summary>
public class AnimatedPhysicalModel : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public AnimatedPhysicalModel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double elevation = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool animateColor = true, FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), bool animateShadowColor = true, FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
    : base(key: key, curve: curve, duration: duration, onEnd: onEnd)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape { get; set; }
public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
public virtual double Elevation { get; set; }
public virtual FlutterBinding.UI.Color Color { get; set; }
public virtual bool AnimateColor { get; set; }
public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
public virtual bool AnimateShadowColor { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Implicitanimations._AnimatedPhysicalModelState CreateState() => new _AnimatedPhysicalModelState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new EnumProperty<BoxShape>("shape", Shape));
    properties.Add(new DiagnosticsProperty<BorderRadius>("borderRadius", BorderRadius));
    properties.Add(new DoubleProperty("elevation", Elevation));
    properties.Add(new ColorProperty("color", Color));
    properties.Add(new DiagnosticsProperty<bool>("animateColor", AnimateColor));
    properties.Add(new ColorProperty("shadowColor", ShadowColor));
    properties.Add(new DiagnosticsProperty<bool>("animateShadowColor", AnimateShadowColor));
}



#endregion
}


public class _AnimatedPhysicalModelState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPhysicalModel>
{
    #region constructors
    public _AnimatedPhysicalModelState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Implicitanimations.BorderRadiusTween _BorderRadius { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Elevation { get; set; }
    internal virtual FlutterSDK.Animation.Tween.ColorTween _Color { get; set; }
    internal virtual FlutterSDK.Animation.Tween.ColorTween _ShadowColor { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _BorderRadius = visitor(_BorderRadius, Widget.BorderRadius, (object value) => =>new BorderRadiusTween(begin: value as BorderRadius)) as BorderRadiusTween;
        _Elevation = visitor(_Elevation, Widget.Elevation, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _Color = visitor(_Color, Widget.Color, (object value) => =>new ColorTween(begin: value as Color)) as ColorTween;
        _ShadowColor = visitor(_ShadowColor, Widget.ShadowColor, (object value) => =>new ColorTween(begin: value as Color)) as ColorTween;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new PhysicalModel(child: Widget.Child, shape: Widget.Shape, clipBehavior: Widget.ClipBehavior, borderRadius: _BorderRadius.Evaluate(Animation), elevation: _Elevation.Evaluate(Animation), color: Widget.AnimateColor ? _Color.Evaluate(Animation) : Widget.Color, shadowColor: Widget.AnimateShadowColor ? _ShadowColor.Evaluate(Animation) : Widget.ShadowColor);
    }



    #endregion
}

}
