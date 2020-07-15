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
namespace FlutterSDK.Material.Checkboxlisttile
{
    internal static class CheckboxlisttileDefaultClass
    {
    }

    /// <Summary>
    /// A [ListTile] with a [Checkbox]. In other words, a checkbox with a label.
    ///
    /// The entire list tile is interactive: tapping anywhere in the tile toggles
    /// the checkbox.
    ///
    /// The [value], [onChanged], [activeColor] and [checkColor] properties of this widget are
    /// identical to the similarly-named properties on the [Checkbox] widget.
    ///
    /// The [title], [subtitle], [isThreeLine], and [dense] properties are like
    /// those of the same name on [ListTile].
    ///
    /// The [selected] property on this widget is similar to the [ListTile.selected]
    /// property, but the color used is that described by [activeColor], if any,
    /// defaulting to the accent color of the current [Theme]. No effort is made to
    /// coordinate the [selected] state and the [value] state; to have the list tile
    /// appear selected when the checkbox is checked, pass the same value to both.
    ///
    /// The checkbox is shown on the right by default in left-to-right languages
    /// (i.e. the trailing edge). This can be changed using [controlAffinity]. The
    /// [secondary] widget is placed on the opposite side. This maps to the
    /// [ListTile.leading] and [ListTile.trailing] properties of [ListTile].
    ///
    /// To show the [CheckboxListTile] as disabled, pass null as the [onChanged]
    /// callback.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// ![CheckboxListTile sample](https://flutter.github.io/assets-for-api-docs/assets/material/checkbox_list_tile.png)
    ///
    /// This widget shows a checkbox that, when checked, slows down all animations
    /// (including the animation of the checkbox itself getting checked!).
    ///
    /// This sample requires that you also import 'package:flutter/scheduler.dart',
    /// so that you can reference [timeDilation].
    ///
    /// ```dart imports
    /// import 'package:flutter/scheduler.dart' show timeDilation;
    /// ```
    /// ```dart
    /// @override
    /// Widget build(BuildContext context) {
    ///   return CheckboxListTile(
    ///     title: const Text('Animate Slowly'),
    ///     value: timeDilation != 1.0,
    ///     onChanged: (bool value) {
    ///       setState(() { timeDilation = value ? 10.0 : 1.0; });
    ///     },
    ///     secondary: const Icon(Icons.hourglass_empty),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ## Semantics in CheckboxListTile
    ///
    /// Since the entirety of the CheckboxListTile is interactive, it should represent
    /// itself as a single interactive entity.
    ///
    /// To do so, a CheckboxListTile widget wraps its children with a [MergeSemantics]
    /// widget. [MergeSemantics] will attempt to merge its descendant [Semantics]
    /// nodes into one node in the semantics tree. Therefore, CheckboxListTile will
    /// throw an error if any of its children requires its own [Semantics] node.
    ///
    /// For example, you cannot nest a [RichText] widget as a descendant of
    /// CheckboxListTile. [RichText] has an embedded gesture recognizer that
    /// requires its own [Semantics] node, which directly conflicts with
    /// CheckboxListTile's desire to merge all its descendants' semantic nodes
    /// into one. Therefore, it may be necessary to create a custom radio tile
    /// widget to accommodate similar use cases.
    ///
    /// {@tool sample --template=stateful_widget_scaffold_center}
    ///
    /// ![Checkbox list tile semantics sample](https://flutter.github.io/assets-for-api-docs/assets/material/checkbox_list_tile_semantics.png)
    ///
    /// Here is an example of a custom labeled checkbox widget, called
    /// LinkedLabelCheckbox, that includes an interactive [RichText] widget that
    /// handles tap gestures.
    ///
    /// ```dart imports
    /// import 'package:flutter/gestures.dart';
    /// ```
    /// ```dart preamble
    /// class LinkedLabelCheckbox extends StatelessWidget {
    ///   const LinkedLabelCheckbox({
    ///     this.label,
    ///     this.padding,
    ///     this.value,
    ///     this.onChanged,
    ///   });
    ///
    ///   final String label;
    ///   final EdgeInsets padding;
    ///   final bool value;
    ///   final Function onChanged;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Padding(
    ///       padding: padding,
    ///       child: Row(
    ///         children: <Widget>[
    ///           Expanded(
    ///             child: RichText(
    ///               text: TextSpan(
    ///                 text: label,
    ///                 style: TextStyle(
    ///                   color: Colors.blueAccent,
    ///                   decoration: TextDecoration.underline,
    ///                 ),
    ///                 recognizer: TapGestureRecognizer()
    ///                   ..onTap = () {
    ///                   print('Label has been tapped.');
    ///                 },
    ///               ),
    ///             ),
    ///           ),
    ///           Checkbox(
    ///             value: value,
    ///             onChanged: (bool newValue) {
    ///               onChanged(newValue);
    ///             },
    ///           ),
    ///         ],
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// ```dart
    /// bool _isSelected = false;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return LinkedLabelCheckbox(
    ///     label: 'Linked, tappable label text',
    ///     padding: const EdgeInsets.symmetric(horizontal: 20.0),
    ///     value: _isSelected,
    ///     onChanged: (bool newValue) {
    ///       setState(() {
    ///         _isSelected = newValue;
    ///       });
    ///     },
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ## CheckboxListTile isn't exactly what I want
    ///
    /// If the way CheckboxListTile pads and positions its elements isn't quite
    /// what you're looking for, you can create custom labeled checkbox widgets by
    /// combining [Checkbox] with other widgets, such as [Text], [Padding] and
    /// [InkWell].
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// ![Custom checkbox list tile sample](https://flutter.github.io/assets-for-api-docs/assets/material/checkbox_list_tile_custom.png)
    ///
    /// Here is an example of a custom LabeledCheckbox widget, but you can easily
    /// make your own configurable widget.
    ///
    /// ```dart preamble
    /// class LabeledCheckbox extends StatelessWidget {
    ///   const LabeledCheckbox({
    ///     this.label,
    ///     this.padding,
    ///     this.value,
    ///     this.onChanged,
    ///   });
    ///
    ///   final String label;
    ///   final EdgeInsets padding;
    ///   final bool value;
    ///   final Function onChanged;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return InkWell(
    ///       onTap: () {
    ///         onChanged(!value);
    ///       },
    ///       child: Padding(
    ///         padding: padding,
    ///         child: Row(
    ///           children: <Widget>[
    ///             Expanded(child: Text(label)),
    ///             Checkbox(
    ///               value: value,
    ///               onChanged: (bool newValue) {
    ///                 onChanged(newValue);
    ///               },
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// ```dart
    /// bool _isSelected = false;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return LabeledCheckbox(
    ///     label: 'This is the label text',
    ///     padding: const EdgeInsets.symmetric(horizontal: 20.0),
    ///     value: _isSelected,
    ///     onChanged: (bool newValue) {
    ///       setState(() {
    ///         _isSelected = newValue;
    ///       });
    ///     },
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ListTileTheme], which can be used to affect the style of list tiles,
    ///    including checkbox list tiles.
    ///  * [RadioListTile], a similar widget for radio buttons.
    ///  * [SwitchListTile], a similar widget for switches.
    ///  * [ListTile] and [Checkbox], the widgets from which this widget is made.
    /// </Summary>
    public class CheckboxListTile : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CheckboxListTile(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color checkColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), bool isThreeLine = false, bool dense = default(bool), FlutterSDK.Widgets.Framework.Widget secondary = default(FlutterSDK.Widgets.Framework.Widget), bool selected = false, FlutterSDK.Material.Listtile.ListTileControlAffinity controlAffinity = default(FlutterSDK.Material.Listtile.ListTileControlAffinity))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual bool Value { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
    public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
    public virtual FlutterBinding.UI.Color CheckColor { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Subtitle { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Secondary { get; set; }
    public virtual bool IsThreeLine { get; set; }
    public virtual bool Dense { get; set; }
    public virtual bool Selected { get; set; }
    public virtual FlutterSDK.Material.Listtile.ListTileControlAffinity ControlAffinity { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        Widget control = new Checkbox(value: Value, onChanged: OnChanged, activeColor: ActiveColor, checkColor: CheckColor, materialTapTargetSize: MaterialTapTargetSize.ShrinkWrap);
        Widget leading trailing = default(Widget);
        switch (ControlAffinity) { case ListTileControlAffinity.Leading: leading = control; trailing = Secondary; break; case ListTileControlAffinity.Trailing: case ListTileControlAffinity.Platform: leading = Secondary; trailing = control; break; }
        return new MergeSemantics(child: ListtileDefaultClass.ListTileTheme.Merge(selectedColor: ActiveColor ?? ThemeDefaultClass.Theme.Of(context).AccentColor, child: new ListTile(leading: leading, title: Title, subtitle: Subtitle, trailing: trailing, isThreeLine: IsThreeLine, dense: Dense, enabled: OnChanged != null, onTap: OnChanged != null ? () =>
        {
            OnChanged(!Value);
        }
        : null, selected: Selected)));
    }



    #endregion
}

}
