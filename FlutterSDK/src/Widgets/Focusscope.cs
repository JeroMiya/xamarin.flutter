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
namespace FlutterSDK.Widgets.Focusscope
{
    internal static class FocusscopeDefaultClass
    {
    }

    /// <Summary>
    /// A widget that manages a [FocusNode] to allow keyboard focus to be given
    /// to this widget and its descendants.
    ///
    /// When the focus is gained or lost, [onFocusChanged] is called.
    ///
    /// For keyboard events, [onKey] is called if [FocusNode.hasFocus] is true for
    /// this widget's [focusNode], unless a focused descendant's [onKey] callback
    /// returns false when called.
    ///
    /// This widget does not provide any visual indication that the focus has
    /// changed. Any desired visual changes should be made when [onFocusChanged] is
    /// called.
    ///
    /// To access the [FocusNode] of the nearest ancestor [Focus] widget and
    /// establish a relationship that will rebuild the widget when the focus
    /// changes, use the [Focus.of] and [FocusScope.of] static methods.
    ///
    /// To access the focused state of the nearest [Focus] widget, use
    /// [Focus.hasFocus] from a build method, which also establishes a relationship
    /// between the calling widget and the [Focus] widget that will rebuild the
    /// calling widget when the focus changes.
    ///
    /// Managing a [FocusNode] means managing its lifecycle, listening for changes
    /// in focus, and re-parenting it when needed to keep the focus hierarchy in
    /// sync with the widget hierarchy. This widget does all of those things for
    /// you. See [FocusNode] for more information about the details of what node
    /// management entails if you are not using a [Focus] widget and you need to do
    /// it yourself.
    ///
    /// To collect a sub-tree of nodes into an exclusive group that restricts focus
    /// traversal to the group, use a [FocusScope]. To collect a sub-tree of nodes
    /// into a group that has a specific order to its traversal but allows the
    /// traversal to escape the group, use a [FocusTraversalGroup].
    ///
    /// To move the focus, use methods on [FocusNode] by getting the [FocusNode]
    /// through the [of] method. For instance, to move the focus to the next node in
    /// the focus traversal order, call `Focus.of(context).nextFocus()`. To unfocus
    /// a widget, call `Focus.of(context).unfocus()`.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    /// This example shows how to manage focus using the [Focus] and [FocusScope]
    /// widgets. See [FocusNode] for a similar example that doesn't use [Focus] or
    /// [FocusScope].
    ///
    /// ```dart imports
    /// import 'package:flutter/services.dart';
    /// ```
    ///
    /// ```dart
    /// Color _color = Colors.white;
    ///
    /// bool _handleKeyPress(FocusNode node, RawKeyEvent event) {
    ///   if (event is RawKeyDownEvent) {
    ///     print('Focus node ${node.debugLabel} got key event: ${event.logicalKey}');
    ///     if (event.logicalKey == LogicalKeyboardKey.keyR) {
    ///       print('Changing color to red.');
    ///       setState(() {
    ///         _color = Colors.red;
    ///       });
    ///       return true;
    ///     } else if (event.logicalKey == LogicalKeyboardKey.keyG) {
    ///       print('Changing color to green.');
    ///       setState(() {
    ///         _color = Colors.green;
    ///       });
    ///       return true;
    ///     } else if (event.logicalKey == LogicalKeyboardKey.keyB) {
    ///       print('Changing color to blue.');
    ///       setState(() {
    ///         _color = Colors.blue;
    ///       });
    ///       return true;
    ///     }
    ///   }
    ///   return false;
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   final TextTheme textTheme = Theme.of(context).textTheme;
    ///   return FocusScope(
    ///     debugLabel: 'Scope',
    ///     autofocus: true,
    ///     child: DefaultTextStyle(
    ///       style: textTheme.headline4,
    ///       child: Focus(
    ///         onKey: _handleKeyPress,
    ///         debugLabel: 'Button',
    ///         child: Builder(
    ///           builder: (BuildContext context) {
    ///             final FocusNode focusNode = Focus.of(context);
    ///             final bool hasFocus = focusNode.hasFocus;
    ///             return GestureDetector(
    ///               onTap: () {
    ///                 if (hasFocus) {
    ///                   focusNode.unfocus();
    ///                 } else {
    ///                   focusNode.requestFocus();
    ///                 }
    ///               },
    ///               child: Center(
    ///                 child: Container(
    ///                   width: 400,
    ///                   height: 100,
    ///                   alignment: Alignment.center,
    ///                   color: hasFocus ? _color : Colors.white,
    ///                   child: Text(hasFocus ? "I'm in color! Press R,G,B!" : 'Press to focus'),
    ///                 ),
    ///               ),
    ///             );
    ///           },
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to wrap another widget in a [Focus] widget to make it
    /// focusable. It wraps a [Container], and changes the container's color when it
    /// is set as the [FocusManager.primaryFocus].
    ///
    /// If you also want to handle mouse hover and/or keyboard actions on a widget,
    /// consider using a [FocusableActionDetector], which combines several different
    /// widgets to provide those capabilities.
    ///
    /// ```dart preamble
    /// class FocusableText extends StatelessWidget {
    ///   const FocusableText(this.data, {Key key, this.autofocus}) : super(key: key);
    ///
    ///   /// The string to display as the text for this widget.
    ///   final String data;
    ///
    ///   /// Whether or not to focus this widget initially if nothing else is focused.
    ///   final bool autofocus;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Focus(
    ///       autofocus: autofocus,
    ///       child: Builder(builder: (BuildContext context) {
    ///         // The contents of this Builder are being made focusable. It is inside
    ///         // of a Builder because the builder provides the correct context
    ///         // variable for Focus.of() to be able to find the Focus widget that is
    ///         // the Builder's parent. Without the builder, the context variable used
    ///         // would be the one given the FocusableText build function, and that
    ///         // would start looking for a Focus widget ancestor of the FocusableText
    ///         // instead of finding the one inside of its build function.
    ///         return Container(
    ///           padding: EdgeInsets.all(8.0),
    ///           // Change the color based on whether or not this Container has focus.
    ///           color: Focus.of(context).hasPrimaryFocus ? Colors.black12 : null,
    ///           child: Text(data),
    ///         );
    ///       }),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: ListView.builder(
    ///       itemBuilder: (context, index) => FocusableText(
    ///         'Item $index',
    ///         autofocus: index == 0,
    ///       ),
    ///       itemCount: 50,
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example shows how to focus a newly-created widget immediately after it
    /// is created.
    ///
    /// The focus node will not actually be given the focus until after the frame in
    /// which it has requested focus is drawn, so it is OK to call
    /// [FocusNode.requestFocus] on a node which is not yet in the focus tree.
    ///
    /// ```dart
    /// int focusedChild = 0;
    /// List<Widget> children = <Widget>[];
    /// List<FocusNode> childFocusNodes = <FocusNode>[];
    ///
    /// @override
    /// void initState() {
    ///   super.initState();
    ///   // Add the first child.
    ///   _addChild();
    /// }
    ///
    /// @override
    /// void dispose() {
    ///   super.dispose();
    ///   childFocusNodes.forEach((FocusNode node) => node.dispose());
    /// }
    ///
    /// void _addChild() {
    ///   // Calling requestFocus here creates a deferred request for focus, since the
    ///   // node is not yet part of the focus tree.
    ///   childFocusNodes
    ///       .add(FocusNode(debugLabel: 'Child ${children.length}')..requestFocus());
    ///
    ///   children.add(Padding(
    ///     padding: const EdgeInsets.all(2.0),
    ///     child: ActionChip(
    ///       focusNode: childFocusNodes.last,
    ///       label: Text('CHILD ${children.length}'),
    ///       onPressed: () {},
    ///     ),
    ///   ));
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Center(
    ///       child: Wrap(
    ///         children: children,
    ///       ),
    ///     ),
    ///     floatingActionButton: FloatingActionButton(
    ///       onPressed: () {
    ///         setState(() {
    ///           focusedChild = children.length;
    ///           _addChild();
    ///         });
    ///       },
    ///       child: Icon(Icons.add),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [FocusNode], which represents a node in the focus hierarchy and
    ///    [FocusNode]'s API documentation includes a detailed explanation of its role
    ///    in the overall focus system.
    ///  * [FocusScope], a widget that manages a group of focusable widgets using a
    ///    [FocusScopeNode].
    ///  * [FocusScopeNode], a node that collects focus nodes into a group for
    ///    traversal.
    ///  * [FocusManager], a singleton that manages the primary focus and
    ///    distributes key events to focused nodes.
    ///  * [FocusTraversalPolicy], an object used to determine how to move the focus
    ///    to other nodes.
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    /// </Summary>
    public class Focus : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that manages a [FocusNode].
        ///
        /// The [child] argument is required and must not be null.
        ///
        /// The [autofocus] argument must not be null.
        /// </Summary>
        public Focus(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback onKey = default(FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback), string debugLabel = default(string), bool canRequestFocus = default(bool), bool skipTraversal = default(bool), bool includeSemantics = true)
        : base(key: key)
        {
            this.Child = child;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.OnFocusChange = onFocusChange;
            this.OnKey = onKey;
            this.DebugLabel = debugLabel;
            this.CanRequestFocus = canRequestFocus;
            this.SkipTraversal = skipTraversal;
            this.IncludeSemantics = includeSemantics;
        }
        /// <Summary>
        /// A debug label for this widget.
        ///
        /// Not used for anything except to be printed in the diagnostic output from
        /// [toString] or [toStringDeep]. Also unused if a [focusNode] is provided,
        /// since that node can have its own [FocusNode.debugLabel].
        ///
        /// To get a string with the entire tree, call [debugDescribeFocusTree]. To
        /// print it to the console call [debugDumpFocusTree].
        ///
        /// Defaults to null.
        /// </Summary>
        public virtual string DebugLabel { get; set; }
        /// <Summary>
        /// The child widget of this [Focus].
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// Handler for keys pressed when this object or one of its children has
        /// focus.
        ///
        /// Key events are first given to the [FocusNode] that has primary focus, and
        /// if its [onKey] method return false, then they are given to each ancestor
        /// node up the focus hierarchy in turn. If an event reaches the root of the
        /// hierarchy, it is discarded.
        ///
        /// This is not the way to get text input in the manner of a text field: it
        /// leaves out support for input method editors, and doesn't support soft
        /// keyboards in general. For text input, consider [TextField],
        /// [EditableText], or [CupertinoTextField] instead, which do support these
        /// things.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback OnKey { get; set; }
        /// <Summary>
        /// Handler called when the focus changes.
        ///
        /// Called with true if this widget's node gains focus, and false if it loses
        /// focus.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnFocusChange { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.Focus.autofocus}
        /// True if this widget will be selected as the initial focus when no other
        /// node in its scope is currently focused.
        ///
        /// Ideally, there is only one widget with autofocus set in each [FocusScope].
        /// If there is more than one widget with autofocus set, then the first one
        /// added to the tree will get focus.
        ///
        /// Must not be null. Defaults to false.
        /// {@endtemplate}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.Focus.focusNode}
        /// An optional focus node to use as the focus node for this widget.
        ///
        /// If one is not supplied, then one will be automatically allocated, owned,
        /// and managed by this widget. The widget will be focusable even if a
        /// [focusNode] is not supplied. If supplied, the given `focusNode` will be
        /// _hosted_ by this widget, but not owned. See [FocusNode] for more
        /// information on what being hosted and/or owned implies.
        ///
        /// Supplying a focus node is sometimes useful if an ancestor to this widget
        /// wants to control when this widget has the focus. The owner will be
        /// responsible for calling [FocusNode.dispose] on the focus node when it is
        /// done with it, but this widget will attach/detach and reparent the node
        /// when needed.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// Sets the [FocusNode.skipTraversal] flag on the focus node so that it won't
        /// be visited by the [FocusTraversalPolicy].
        ///
        /// This is sometimes useful if a [Focus] widget should receive key events as
        /// part of the focus chain, but shouldn't be accessible via focus traversal.
        ///
        /// This is different from [canRequestFocus] because it only implies that the
        /// widget can't be reached via traversal, not that it can't be focused. It may
        /// still be focused explicitly.
        /// </Summary>
        public virtual bool SkipTraversal { get; set; }
        /// <Summary>
        /// Include semantics information in this [Focus] widget.
        ///
        /// If true, this [Focus] widget will include a [Semantics] node that
        /// indicates the [Semantics.focusable] and [Semantics.focused] properties.
        ///
        /// It is not typical to set this to false, as that can affect the semantics
        /// information available to accessibility systems.
        ///
        /// Must not be null, defaults to true.
        /// </Summary>
        public virtual bool IncludeSemantics { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.Focus.canRequestFocus}
        /// If true, this widget may request the primary focus.
        ///
        /// Defaults to true.  Set to false if you want the [FocusNode] this widget
        /// manages to do nothing when [requestFocus] is called on it. Does not affect
        /// the children of this node, and [FocusNode.hasFocus] can still return true
        /// if this node is the ancestor of the primary focus.
        ///
        /// This is different than [skipTraversal] because [skipTraversal] still
        /// allows the widget to be focused, just not traversed to.
        ///
        /// Setting [canRequestFocus] to false implies that the widget will also be
        /// skipped for traversal purposes.
        ///
        /// See also:
        ///
        ///  * [DefaultFocusTraversal], a widget that sets the traversal policy for
        ///    its descendants.
        ///  * [FocusTraversalPolicy], a class that can be extended to describe a
        ///    traversal policy.
        /// {@endtemplate}
        /// </Summary>
        public virtual bool CanRequestFocus { get; set; }

        /// <Summary>
        /// Returns the [focusNode] of the [Focus] that most tightly encloses the
        /// given [BuildContext].
        ///
        /// If no [Focus] node is found before reaching the nearest [FocusScope]
        /// widget, or there is no [Focus] widget in scope, then this method will
        /// throw an exception. To return null instead of throwing, pass true for
        /// [nullOk].
        ///
        /// The [context] and [nullOk] arguments must not be null.
        ///
        /// Calling this function creates a dependency that will rebuild the given
        /// context when the focus changes.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false, bool scopeOk = false)
        {



            _FocusMarker marker = context.DependOnInheritedWidgetOfExactType();
            FocusNode node = marker?.Notifier;
            if (node == null)
            {
                if (!nullOk)
                {
                    throw FlutterError.CreateNew("Focus.of() was called with a context that does not contain a Focus widget.\n" + "No Focus widget ancestor could be found starting from the context that was passed to " + "Focus.of(). This can happen because you are using a widget that looks for a Focus " + "ancestor, and do not have a Focus widget descendant in the nearest FocusScope.\n" + "The context used was:\n" + $"'  {context}'");
                }

                return null;
            }

            if (!scopeOk && node is FocusScopeNode)
            {
                if (!nullOk)
                {
                    throw FlutterError.CreateNew("Focus.of() was called with a context that does not contain a Focus between the given " + "context and the nearest FocusScope widget.\n" + "No Focus ancestor could be found starting from the context that was passed to " + "Focus.of() to the point where it found the nearest FocusScope widget. This can happen " + "because you are using a widget that looks for a Focus ancestor, and do not have a " + "Focus widget ancestor in the current FocusScope.\n" + "The context used was:\n" + $"'  {context}'");
                }

                return null;
            }

            return node;
        }




        /// <Summary>
        /// Returns true if the nearest enclosing [Focus] widget's node is focused.
        ///
        /// A convenience method to allow build methods to write:
        /// `Focus.isAt(context)` to get whether or not the nearest [Focus] above them
        /// in the widget hierarchy currently has the input focus.
        ///
        /// Returns false if no [Focus] widget is found before reaching the nearest
        /// [FocusScope], or if the root of the focus tree is reached without finding
        /// a [Focus] widget.
        ///
        /// Calling this function creates a dependency that will rebuild the given
        /// context when the focus changes.
        /// </Summary>
        public virtual bool IsAt(FlutterSDK.Widgets.Framework.BuildContext context) => FocusscopeDefaultClass.Focus.Of(context, nullOk: true)?.HasFocus ?? false;



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("debugLabel", DebugLabel, defaultValue: null));
            properties.Add(new FlagProperty("autofocus", value: Autofocus, ifTrue: "AUTOFOCUS", defaultValue: false));
            properties.Add(new DiagnosticsProperty<FocusNode>("node", FocusNode, defaultValue: null));
        }




        public new FlutterSDK.Widgets.Focusscope._FocusState CreateState() => new _FocusState();


    }


    public class _FocusState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Focusscope.Focus>
    {
        public _FocusState()
        { }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _InternalNode { get; set; }
        internal virtual bool _HasPrimaryFocus { get; set; }
        internal virtual bool _CanRequestFocus { get; set; }
        internal virtual bool _DidAutofocus { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusAttachment _FocusAttachment { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _InitNode();
        }




        private void _InitNode()
        {
            if (Widget.FocusNode == null)
            {
                _InternalNode = (_InternalNode == null ? _CreateNode() : _InternalNode);
            }

            if (Widget.SkipTraversal != null)
            {
                FocusNode.SkipTraversal = Widget.SkipTraversal;
            }

            if (Widget.CanRequestFocus != null)
            {
                FocusNode.CanRequestFocus = Widget.CanRequestFocus;
            }

            _CanRequestFocus = FocusNode.CanRequestFocus;
            _HasPrimaryFocus = FocusNode.HasPrimaryFocus;
            _FocusAttachment = FocusNode.Attach(Context, onKey: Widget.OnKey);
            FocusNode.AddListener(_HandleFocusChanged);
        }




        private FlutterSDK.Widgets.Focusmanager.FocusNode _CreateNode()
        {
            return new FocusNode(debugLabel: Widget.DebugLabel, canRequestFocus: Widget.CanRequestFocus ?? true, skipTraversal: Widget.SkipTraversal ?? false);
        }




        public new void Dispose()
        {
            FocusNode.RemoveListener(_HandleFocusChanged);
            _FocusAttachment.Detach();
            _InternalNode?.Dispose();
            base.Dispose();
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _FocusAttachment?.Reparent();
            _HandleAutofocus();
        }




        private void _HandleAutofocus()
        {
            if (!_DidAutofocus && Widget.Autofocus)
            {
                FocusscopeDefaultClass.FocusScope.Of(Context).Autofocus(FocusNode);
                _DidAutofocus = true;
            }

        }




        public new void Deactivate()
        {
            base.Deactivate();
            _FocusAttachment?.Reparent();
            _DidAutofocus = false;
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Focusscope.Focus oldWidget)
        {
            base.DidUpdateWidget(oldWidget);

            if (oldWidget.FocusNode == Widget.FocusNode)
            {
                if (Widget.SkipTraversal != null)
                {
                    FocusNode.SkipTraversal = Widget.SkipTraversal;
                }

                if (Widget.CanRequestFocus != null)
                {
                    FocusNode.CanRequestFocus = Widget.CanRequestFocus;
                }

            }
            else
            {
                _FocusAttachment.Detach();
                FocusNode.RemoveListener(_HandleFocusChanged);
                _InitNode();
            }

            if (oldWidget.Autofocus != Widget.Autofocus)
            {
                _HandleAutofocus();
            }

        }




        private void _HandleFocusChanged()
        {
            bool hasPrimaryFocus = FocusNode.HasPrimaryFocus;
            bool canRequestFocus = FocusNode.CanRequestFocus;
            if (Widget.OnFocusChange != null)
            {
                Widget.OnFocusChange(FocusNode.HasFocus);
            }

            if (_HasPrimaryFocus != hasPrimaryFocus)
            {
                SetState(() =>
                {
                    _HasPrimaryFocus = hasPrimaryFocus;
                }
                );
            }

            if (_CanRequestFocus != canRequestFocus)
            {
                SetState(() =>
                {
                    _CanRequestFocus = canRequestFocus;
                }
                );
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _FocusAttachment.Reparent();
            Widget child = Widget.Child;
            if (Widget.IncludeSemantics)
            {
                child = new Semantics(focusable: _CanRequestFocus, focused: _HasPrimaryFocus, child: Widget.Child);
            }

            return new _FocusMarker(node: FocusNode, child: child);
        }



    }


    /// <Summary>
    /// A [FocusScope] is similar to a [Focus], but also serves as a scope for its
    /// descendants, restricting focus traversal to the scoped controls.
    ///
    /// For example a new [FocusScope] is created automatically when a route is
    /// pushed, keeping the focus traversal from moving to a control in a previous
    /// route.
    ///
    /// If you just want to group widgets together in a group so that they are
    /// traversed in a particular order, but the focus can still leave the group,
    /// use a [FocusTraversalGroup].
    ///
    /// Like [Focus], [FocusScope] provides an [onFocusChange] as a way to be
    /// notified when the focus is given to or removed from this widget.
    ///
    /// The [onKey] argument allows specification of a key event handler that is
    /// invoked when this node or one of its children has focus. Keys are handed to
    /// the primary focused widget first, and then they propagate through the
    /// ancestors of that node, stopping if one of them returns true from [onKey],
    /// indicating that it has handled the event.
    ///
    /// Managing a [FocusScopeNode] means managing its lifecycle, listening for
    /// changes in focus, and re-parenting it when needed to keep the focus
    /// hierarchy in sync with the widget hierarchy. This widget does all of those
    /// things for you. See [FocusScopeNode] for more information about the details
    /// of what node management entails if you are not using a [FocusScope] widget
    /// and you need to do it yourself.
    ///
    /// [FocusScopeNode]s remember the last [FocusNode] that was focused within
    /// their descendants, and can move that focus to the next/previous node, or a
    /// node in a particular direction when the [FocusNode.nextFocus],
    /// [FocusNode.previousFocus], or [FocusNode.focusInDirection] are called on a
    /// [FocusNode] or [FocusScopeNode].
    ///
    /// To move the focus, use methods on [FocusNode] by getting the [FocusNode]
    /// through the [of] method. For instance, to move the focus to the next node in
    /// the focus traversal order, call `Focus.of(context).nextFocus()`. To unfocus
    /// a widget, call `Focus.of(context).unfocus()`.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example demonstrates using a [FocusScope] to restrict focus to a particular
    /// portion of the app. In this case, restricting focus to the visible part of a
    /// Stack.
    ///
    /// ```dart preamble
    /// /// A demonstration pane.
    /// ///
    /// /// This is just a separate widget to simplify the example.
    /// class Pane extends StatelessWidget {
    ///   const Pane({
    ///     Key key,
    ///     this.focusNode,
    ///     this.onPressed,
    ///     this.child,
    ///     this.backgroundColor,
    ///     this.icon,
    ///   }) : super(key: key);
    ///
    ///   final FocusNode focusNode;
    ///   final VoidCallback onPressed;
    ///   final Widget child;
    ///   final Color backgroundColor;
    ///   final Widget icon;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Material(
    ///       color: backgroundColor,
    ///       child: Stack(
    ///         fit: StackFit.expand,
    ///         children: <Widget>[
    ///           Center(
    ///             child: child,
    ///           ),
    ///           Align(
    ///             alignment: Alignment.topLeft,
    ///             child: IconButton(
    ///               autofocus: true,
    ///               focusNode: focusNode,
    ///               onPressed: onPressed,
    ///               icon: icon,
    ///             ),
    ///           ),
    ///         ],
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    ///   bool backdropIsVisible = false;
    ///   FocusNode backdropNode = FocusNode(debugLabel: 'Close Backdrop Button');
    ///   FocusNode foregroundNode = FocusNode(debugLabel: 'Option Button');
    ///
    ///   @override
    ///   void dispose() {
    ///     super.dispose();
    ///     backdropNode.dispose();
    ///     foregroundNode.dispose();
    ///   }
    ///
    ///   Widget _buildStack(BuildContext context, BoxConstraints constraints) {
    ///     Size stackSize = constraints.biggest;
    ///     return Stack(
    ///       fit: StackFit.expand,
    ///       // The backdrop is behind the front widget in the Stack, but the widgets
    ///       // would still be active and traversable without the FocusScope.
    ///       children: <Widget>[
    ///         // TRY THIS: Try removing this FocusScope entirely to see how it affects
    ///         // the behavior. Without this FocusScope, the "ANOTHER BUTTON TO FOCUS"
    ///         // button, and the IconButton in the backdrop Pane would be focusable
    ///         // even when the backdrop wasn't visible.
    ///         FocusScope(
    ///           // TRY THIS: Try commenting out this line. Notice that the focus
    ///           // starts on the backdrop and is stuck there? It seems like the app is
    ///           // non-responsive, but it actually isn't. This line makes sure that
    ///           // this focus scope and its children can't be focused when they're not
    ///           // visible. It might help to make the background color of the
    ///           // foreground pane semi-transparent to see it clearly.
    ///           canRequestFocus: backdropIsVisible,
    ///           child: Pane(
    ///             icon: Icon(Icons.close),
    ///             focusNode: backdropNode,
    ///             backgroundColor: Colors.lightBlue,
    ///             onPressed: () => setState(() => backdropIsVisible = false),
    ///             child: Column(
    ///               mainAxisAlignment: MainAxisAlignment.center,
    ///               children: <Widget>[
    ///                 // This button would be not visible, but still focusable from
    ///                 // the foreground pane without the FocusScope.
    ///                 RaisedButton(
    ///                   onPressed: () => print('You pressed the other button!'),
    ///                   child: Text('ANOTHER BUTTON TO FOCUS'),
    ///                 ),
    ///                 DefaultTextStyle(
    ///                     style: Theme.of(context).textTheme.headline2,
    ///                     child: Text('BACKDROP')),
    ///               ],
    ///             ),
    ///           ),
    ///         ),
    ///         AnimatedPositioned(
    ///           curve: Curves.easeInOut,
    ///           duration: const Duration(milliseconds: 300),
    ///           top: backdropIsVisible ? stackSize.height * 0.9 : 0.0,
    ///           width: stackSize.width,
    ///           height: stackSize.height,
    ///           onEnd: () {
    ///             if (backdropIsVisible) {
    ///               backdropNode.requestFocus();
    ///             } else {
    ///               foregroundNode.requestFocus();
    ///             }
    ///           },
    ///           child: Pane(
    ///             icon: Icon(Icons.menu),
    ///             focusNode: foregroundNode,
    ///             // TRY THIS: Try changing this to Colors.green.withOpacity(0.8) to see for
    ///             // yourself that the hidden components do/don't get focus.
    ///             backgroundColor: Colors.green,
    ///             onPressed: backdropIsVisible
    ///                 ? null
    ///                 : () => setState(() => backdropIsVisible = true),
    ///             child: DefaultTextStyle(
    ///                 style: Theme.of(context).textTheme.headline2,
    ///                 child: Text('FOREGROUND')),
    ///           ),
    ///         ),
    ///       ],
    ///     );
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     // Use a LayoutBuilder so that we can base the size of the stack on the size
    ///     // of its parent.
    ///     return LayoutBuilder(builder: _buildStack);
    ///   }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [FocusScopeNode], which represents a scope node in the focus hierarchy.
    ///  * [FocusNode], which represents a node in the focus hierarchy and has an
    ///    explanation of the focus system.
    ///  * [Focus], a widget that manages a [FocusNode] and allows easy access to
    ///    managing focus without having to manage the node.
    ///  * [FocusManager], a singleton that manages the focus and distributes key
    ///    events to focused nodes.
    ///  * [FocusTraversalPolicy], an object used to determine how to move the focus
    ///    to other nodes.
    ///  * [FocusTraversalGroup], a widget used to configure the focus traversal
    ///    policy for a widget subtree.
    /// </Summary>
    public class FocusScope : FlutterSDK.Widgets.Focusscope.Focus
    {
        /// <Summary>
        /// Creates a widget that manages a [FocusScopeNode].
        ///
        /// The [child] argument is required and must not be null.
        ///
        /// The [autofocus], and [showDecorations] arguments must not be null.
        /// </Summary>
        public FocusScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Focusmanager.FocusScopeNode node = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool autofocus = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), bool canRequestFocus = default(bool), bool skipTraversal = default(bool), FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback onKey = default(FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback), string debugLabel = default(string))
        : base(key: key, child: child, focusNode: node, autofocus: autofocus, onFocusChange: onFocusChange, canRequestFocus: canRequestFocus, skipTraversal: skipTraversal, onKey: onKey, debugLabel: debugLabel)
        {

        }

        /// <Summary>
        /// Returns the [FocusScopeNode] of the [FocusScope] that most tightly
        /// encloses the given [context].
        ///
        /// If this node doesn't have a [Focus] widget ancestor, then the
        /// [FocusManager.rootScope] is returned.
        ///
        /// The [context] argument must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            _FocusMarker marker = context.DependOnInheritedWidgetOfExactType();
            return marker?.Notifier?.NearestScope ?? context.Owner.FocusManager.RootScope;
        }




        public new FlutterSDK.Widgets.Focusscope._FocusScopeState CreateState() => new _FocusScopeState();


    }


    public class _FocusScopeState : FlutterSDK.Widgets.Focusscope._FocusState
    {
        public _FocusScopeState()
        { }

        protected new FlutterSDK.Widgets.Focusmanager.FocusScopeNode _CreateNode()
        {
            return new FocusScopeNode(debugLabel: Widget.DebugLabel, canRequestFocus: Widget.CanRequestFocus ?? true, skipTraversal: Widget.SkipTraversal ?? false);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _FocusAttachment.Reparent();
            return new Semantics(explicitChildNodes: true, child: new _FocusMarker(node: FocusNode, child: Widget.Child));
        }



    }


    public class _FocusMarker : FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<FlutterSDK.Widgets.Focusmanager.FocusNode>
    {
        public _FocusMarker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, notifier: node, child: child)
        {

        }
    }

}
