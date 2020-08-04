using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Widgets.Inheritednotifier
{
    internal static class InheritednotifierDefaultClass
    {
    }

    /// <Summary>
    /// An inherited widget for a [Listenable] [notifier], which updates its
    /// dependencies when the [notifier] is triggered.
    ///
    /// This is a variant of [InheritedWidget], specialized for subclasses of
    /// [Listenable], such as [ChangeNotifier] or [ValueNotifier].
    ///
    /// Dependents are notified whenever the [notifier] sends notifications, or
    /// whenever the identity of the [notifier] changes.
    ///
    /// Multiple notifications are coalesced, so that dependents only rebuild once
    /// even if the [notifier] fires multiple times between two frames.
    ///
    /// Typically this class is subclassed with a class that provides an `of` static
    /// method that calls [BuildContext.dependOnInheritedWidgetOfExactType] with that
    /// class.
    ///
    /// The [updateShouldNotify] method may also be overridden, to change the logic
    /// in the cases where [notifier] itself is changed. The [updateShouldNotify]
    /// method is called with the old [notifier] in the case of the [notifier] being
    /// changed. When it returns true, the dependents are marked as needing to be
    /// rebuilt this frame.
    ///
    /// {@tool dartpad --template=stateful_widget_material_ticker}
    ///
    /// This example shows three spinning squares that use the value of the notifier
    /// on an ancestor [InheritedNotifier] (`SpinModel`) to give them their
    /// rotation. The [InheritedNotifier] doesn't need to know about the children,
    /// and the `notifier` argument doesn't need to be an animation controller, it
    /// can be anything that implements [Listenable] (like a [ChangeNotifier]).
    ///
    /// The `SpinModel` class could just as easily listen to another object (say, a
    /// separate object that keeps the value of an input or data model value) that
    /// is a [Listenable], and get the value from that. The descendants also don't
    /// need to have an instance of the [InheritedNotifier] in order to use it, they
    /// just need to know that there is one in their ancestry. This can help with
    /// decoupling widgets from their models.
    ///
    /// ```dart imports
    /// import 'dart:math' as math;
    /// ```
    ///
    /// ```dart preamble
    /// class SpinModel extends InheritedNotifier<AnimationController> {
    ///   SpinModel({
    ///     Key key,
    ///     AnimationController notifier,
    ///     Widget child,
    ///   }) : super(key: key, notifier: notifier, child: child);
    ///
    ///   static double of(BuildContext context) {
    ///     return context.dependOnInheritedWidgetOfExactType<SpinModel>().notifier.value;
    ///   }
    /// }
    ///
    /// class Spinner extends StatelessWidget {
    ///   const Spinner();
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Transform.rotate(
    ///       angle: SpinModel.of(context) * 2.0 * math.pi,
    ///       child: Container(
    ///         width: 100,
    ///         height: 100,
    ///         color: Colors.green,
    ///         child: const Center(
    ///           child: Text('Whee!'),
    ///         ),
    ///       ),
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
    ///   return SpinModel(
    ///     notifier: _controller,
    ///     child: Row(
    ///       mainAxisAlignment: MainAxisAlignment.spaceAround,
    ///       children: const <Widget>[
    ///         Spinner(),
    ///         Spinner(),
    ///         Spinner(),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Animation], an implementation of [Listenable] that ticks each frame to
    ///    update a value.
    ///  * [ViewportOffset] or its subclass [ScrollPosition], implementations of
    ///    [Listenable] that trigger when a view is scrolled.
    ///  * [InheritedWidget], an inherited widget that only notifies dependents
    ///    when its value is different.
    ///  * [InheritedModel], an inherited widget that allows clients to subscribe
    ///    to changes for subparts of the value.
    /// </Summary>
    public interface IInheritedNotifier<T>
    {
        bool UpdateShouldNotify(FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<T> oldWidget);
        _InheritedNotifierElement<T> CreateElement();
        T Notifier { get; }
    }


    /// <Summary>
    /// An inherited widget for a [Listenable] [notifier], which updates its
    /// dependencies when the [notifier] is triggered.
    ///
    /// This is a variant of [InheritedWidget], specialized for subclasses of
    /// [Listenable], such as [ChangeNotifier] or [ValueNotifier].
    ///
    /// Dependents are notified whenever the [notifier] sends notifications, or
    /// whenever the identity of the [notifier] changes.
    ///
    /// Multiple notifications are coalesced, so that dependents only rebuild once
    /// even if the [notifier] fires multiple times between two frames.
    ///
    /// Typically this class is subclassed with a class that provides an `of` static
    /// method that calls [BuildContext.dependOnInheritedWidgetOfExactType] with that
    /// class.
    ///
    /// The [updateShouldNotify] method may also be overridden, to change the logic
    /// in the cases where [notifier] itself is changed. The [updateShouldNotify]
    /// method is called with the old [notifier] in the case of the [notifier] being
    /// changed. When it returns true, the dependents are marked as needing to be
    /// rebuilt this frame.
    ///
    /// {@tool dartpad --template=stateful_widget_material_ticker}
    ///
    /// This example shows three spinning squares that use the value of the notifier
    /// on an ancestor [InheritedNotifier] (`SpinModel`) to give them their
    /// rotation. The [InheritedNotifier] doesn't need to know about the children,
    /// and the `notifier` argument doesn't need to be an animation controller, it
    /// can be anything that implements [Listenable] (like a [ChangeNotifier]).
    ///
    /// The `SpinModel` class could just as easily listen to another object (say, a
    /// separate object that keeps the value of an input or data model value) that
    /// is a [Listenable], and get the value from that. The descendants also don't
    /// need to have an instance of the [InheritedNotifier] in order to use it, they
    /// just need to know that there is one in their ancestry. This can help with
    /// decoupling widgets from their models.
    ///
    /// ```dart imports
    /// import 'dart:math' as math;
    /// ```
    ///
    /// ```dart preamble
    /// class SpinModel extends InheritedNotifier<AnimationController> {
    ///   SpinModel({
    ///     Key key,
    ///     AnimationController notifier,
    ///     Widget child,
    ///   }) : super(key: key, notifier: notifier, child: child);
    ///
    ///   static double of(BuildContext context) {
    ///     return context.dependOnInheritedWidgetOfExactType<SpinModel>().notifier.value;
    ///   }
    /// }
    ///
    /// class Spinner extends StatelessWidget {
    ///   const Spinner();
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Transform.rotate(
    ///       angle: SpinModel.of(context) * 2.0 * math.pi,
    ///       child: Container(
    ///         width: 100,
    ///         height: 100,
    ///         color: Colors.green,
    ///         child: const Center(
    ///           child: Text('Whee!'),
    ///         ),
    ///       ),
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
    ///   return SpinModel(
    ///     notifier: _controller,
    ///     child: Row(
    ///       mainAxisAlignment: MainAxisAlignment.spaceAround,
    ///       children: const <Widget>[
    ///         Spinner(),
    ///         Spinner(),
    ///         Spinner(),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Animation], an implementation of [Listenable] that ticks each frame to
    ///    update a value.
    ///  * [ViewportOffset] or its subclass [ScrollPosition], implementations of
    ///    [Listenable] that trigger when a view is scrolled.
    ///  * [InheritedWidget], an inherited widget that only notifies dependents
    ///    when its value is different.
    ///  * [InheritedModel], an inherited widget that allows clients to subscribe
    ///    to changes for subparts of the value.
    /// </Summary>
    public class InheritedNotifier<T> : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        /// <Summary>
        /// Create an inherited widget that updates its dependents when [notifier]
        /// sends notifications.
        ///
        /// The [child] argument must not be null.
        /// </Summary>
        public InheritedNotifier(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T notifier = default(T), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Notifier = notifier;
        }
        /// <Summary>
        /// The [Listenable] object to which to listen.
        ///
        /// Whenever this object sends change notifications, the dependents of this
        /// widget are triggered.
        ///
        /// By default, whenever the [notifier] is changed (including when changing to
        /// or from null), if the old notifier is not equal to the new notifier (as
        /// determined by the `==` operator), notifications are sent. This behavior
        /// can be overridden by overriding [updateShouldNotify].
        ///
        /// While the [notifier] is null, no notifications are sent, since the null
        /// object cannot itself send notifications.
        /// </Summary>
        public virtual T Notifier { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<T> oldWidget)
        {
            return oldWidget.Notifier != Notifier;
        }




        public new _InheritedNotifierElement<T> CreateElement() => new _InheritedNotifierElement<T>(this);


    }


    public class _InheritedNotifierElement<T> : FlutterSDK.Widgets.Framework.InheritedElement
    {
        public _InheritedNotifierElement(FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<T> widget)
        : base(widget)
        {

            widget.Notifier?.AddListener(_HandleUpdate);
        }


        internal virtual bool _Dirty { get; set; }
        public virtual FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Update(FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<T> newWidget)
        {
            T oldNotifier = Widget.Notifier;
            T newNotifier = newWidget.Notifier;
            if (oldNotifier != newNotifier)
            {
                oldNotifier?.RemoveListener(_HandleUpdate);
                newNotifier?.AddListener(_HandleUpdate);
            }

            base.Update(newWidget);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build()
        {
            if (_Dirty) NotifyClients(Widget);
            return base.Build();
        }




        private void _HandleUpdate()
        {
            _Dirty = true;
            MarkNeedsBuild();
        }




        public new void NotifyClients(FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<T> oldWidget)
        {
            base.NotifyClients(oldWidget);
            _Dirty = false;
        }




        public new void Unmount()
        {
            Widget.Notifier?.RemoveListener(_HandleUpdate);
            base.Unmount();
        }



    }

}
