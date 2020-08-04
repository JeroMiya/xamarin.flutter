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
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Typography;
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
namespace FlutterSDK.Material.Switchlisttile
{
    internal static class SwitchlisttileDefaultClass
    {
    }

    /// <Summary>
    /// A [ListTile] with a [Switch]. In other words, a switch with a label.
    ///
    /// The entire list tile is interactive: tapping anywhere in the tile toggles
    /// the switch. Tapping and dragging the [Switch] also triggers the [onChanged]
    /// callback.
    ///
    /// To ensure that [onChanged] correctly triggers, the state passed
    /// into [value] must be properly managed. This is typically done by invoking
    /// [State.setState] in [onChanged] to toggle the state value.
    ///
    /// The [value], [onChanged], [activeColor], [activeThumbImage], and
    /// [inactiveThumbImage] properties of this widget are identical to the
    /// similarly-named properties on the [Switch] widget.
    ///
    /// The [title], [subtitle], [isThreeLine], and [dense] properties are like
    /// those of the same name on [ListTile].
    ///
    /// The [selected] property on this widget is similar to the [ListTile.selected]
    /// property, but the color used is that described by [activeColor], if any,
    /// defaulting to the accent color of the current [Theme]. No effort is made to
    /// coordinate the [selected] state and the [value] state; to have the list tile
    /// appear selected when the switch is on, pass the same value to both.
    ///
    /// The switch is shown on the right by default in left-to-right languages (i.e.
    /// in the [ListTile.trailing] slot). The [secondary] widget is placed in the
    /// [ListTile.leading] slot. This cannot be changed; there is not sufficient
    /// space in a [ListTile]'s [ListTile.leading] slot for a [Switch].
    ///
    /// To show the [SwitchListTile] as disabled, pass null as the [onChanged]
    /// callback.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// ![SwitchListTile sample](https://flutter.github.io/assets-for-api-docs/assets/material/switch_list_tile.png)
    ///
    /// This widget shows a switch that, when toggled, changes the state of a [bool]
    /// member field called `_lights`.
    ///
    /// ```dart
    /// bool _lights = false;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return SwitchListTile(
    ///     title: const Text('Lights'),
    ///     value: _lights,
    ///     onChanged: (bool value) { setState(() { _lights = value; }); },
    ///     secondary: const Icon(Icons.lightbulb_outline),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ## Semantics in SwitchListTile
    ///
    /// Since the entirety of the SwitchListTile is interactive, it should represent
    /// itself as a single interactive entity.
    ///
    /// To do so, a SwitchListTile widget wraps its children with a [MergeSemantics]
    /// widget. [MergeSemantics] will attempt to merge its descendant [Semantics]
    /// nodes into one node in the semantics tree. Therefore, SwitchListTile will
    /// throw an error if any of its children requires its own [Semantics] node.
    ///
    /// For example, you cannot nest a [RichText] widget as a descendant of
    /// SwitchListTile. [RichText] has an embedded gesture recognizer that
    /// requires its own [Semantics] node, which directly conflicts with
    /// SwitchListTile's desire to merge all its descendants' semantic nodes
    /// into one. Therefore, it may be necessary to create a custom radio tile
    /// widget to accommodate similar use cases.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// ![Switch list tile semantics sample](https://flutter.github.io/assets-for-api-docs/assets/material/switch_list_tile_semantics.png)
    ///
    /// Here is an example of a custom labeled radio widget, called
    /// LinkedLabelRadio, that includes an interactive [RichText] widget that
    /// handles tap gestures.
    ///
    /// ```dart imports
    /// import 'package:flutter/gestures.dart';
    /// ```
    /// ```dart preamble
    /// class LinkedLabelSwitch extends StatelessWidget {
    ///   const LinkedLabelSwitch({
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
    ///           Switch(
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
    ///   return LinkedLabelSwitch(
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
    /// ## SwitchListTile isn't exactly what I want
    ///
    /// If the way SwitchListTile pads and positions its elements isn't quite what
    /// you're looking for, you can create custom labeled switch widgets by
    /// combining [Switch] with other widgets, such as [Text], [Padding] and
    /// [InkWell].
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// ![Custom switch list tile sample](https://flutter.github.io/assets-for-api-docs/assets/material/switch_list_tile_custom.png)
    ///
    /// Here is an example of a custom LabeledSwitch widget, but you can easily
    /// make your own configurable widget.
    ///
    /// ```dart preamble
    /// class LabeledSwitch extends StatelessWidget {
    ///   const LabeledSwitch({
    ///     this.label,
    ///     this.padding,
    ///     this.groupValue,
    ///     this.value,
    ///     this.onChanged,
    ///   });
    ///
    ///   final String label;
    ///   final EdgeInsets padding;
    ///   final bool groupValue;
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
    ///             Switch(
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
    ///   return LabeledSwitch(
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
    ///    including switch list tiles.
    ///  * [CheckboxListTile], a similar widget for checkboxes.
    ///  * [RadioListTile], a similar widget for radio buttons.
    ///  * [ListTile] and [Switch], the widgets from which this widget is made.
    /// </Summary>
    public class SwitchListTile : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a combination of a list tile and a switch.
        ///
        /// The switch tile itself does not maintain any state. Instead, when the
        /// state of the switch changes, the widget calls the [onChanged] callback.
        /// Most widgets that use a switch will listen for the [onChanged] callback
        /// and rebuild the switch tile with a new [value] to update the visual
        /// appearance of the switch.
        ///
        /// The following arguments are required:
        ///
        /// * [value] determines whether this switch is on or off.
        /// * [onChanged] is called when the user toggles the switch on or off.
        /// </Summary>
        public SwitchListTile(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), bool isThreeLine = false, bool dense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget secondary = default(FlutterSDK.Widgets.Framework.Widget), bool selected = false)
        : base(key: key)
        {
            this.Value = value;
            this.OnChanged = onChanged;
            this.ActiveColor = activeColor;
            this.ActiveTrackColor = activeTrackColor;
            this.InactiveThumbColor = inactiveThumbColor;
            this.InactiveTrackColor = inactiveTrackColor;
            this.ActiveThumbImage = activeThumbImage;
            this.InactiveThumbImage = inactiveThumbImage;
            this.Title = title;
            this.Subtitle = subtitle;
            this.IsThreeLine = isThreeLine;
            this.Dense = dense;
            this.ContentPadding = contentPadding;
            this.Secondary = secondary;
            this.Selected = selected;
        }
        /// <Summary>
        /// Creates the wrapped switch with [Switch.adaptive].
        ///
        /// Creates a [CupertinoSwitch] if the target platform is iOS, creates a
        /// material design switch otherwise.
        ///
        /// If a [CupertinoSwitch] is created, the following parameters are
        /// ignored: [activeTrackColor], [inactiveThumbColor], [inactiveTrackColor],
        /// [activeThumbImage], [inactiveThumbImage], [materialTapTargetSize].
        /// </Summary>
        public static SwitchListTile Adaptive(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), bool isThreeLine = false, bool dense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget secondary = default(FlutterSDK.Widgets.Framework.Widget), bool selected = false)
        => new SwitchListTile(key, value, onChanged, activeColor, activeTrackColor, inactiveThumbColor, inactiveTrackColor, activeThumbImage, inactiveThumbImage, title, subtitle, isThreeLine, dense, contentPadding, secondary, selected);

        private SwitchListTile(FlutterSDK.Foundation.Key.Key key, bool value, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged, FlutterBinding.UI.Color activeColor, FlutterBinding.UI.Color activeTrackColor, FlutterBinding.UI.Color inactiveThumbColor, FlutterBinding.UI.Color inactiveTrackColor, FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage, FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage, FlutterSDK.Widgets.Framework.Widget title, FlutterSDK.Widgets.Framework.Widget subtitle, bool isThreeLine, bool dense, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding, FlutterSDK.Widgets.Framework.Widget secondary, bool selected)
        : base(key: key)
        {
            this.Value = value;
            this.OnChanged = onChanged;
            this.ActiveColor = activeColor;
            this.ActiveTrackColor = activeTrackColor;
            this.InactiveThumbColor = inactiveThumbColor;
            this.InactiveTrackColor = inactiveTrackColor;
            this.ActiveThumbImage = activeThumbImage;
            this.InactiveThumbImage = inactiveThumbImage;
            this.Title = title;
            this.Subtitle = subtitle;
            this.IsThreeLine = isThreeLine;
            this.Dense = dense;
            this.ContentPadding = contentPadding;
            this.Secondary = secondary;
            this.Selected = selected;
        }
        /// <Summary>
        /// Whether this switch is checked.
        ///
        /// This property must not be null.
        /// </Summary>
        public virtual bool Value { get; set; }
        /// <Summary>
        /// Called when the user toggles the switch on or off.
        ///
        /// The switch passes the new value to the callback but does not actually
        /// change state until the parent widget rebuilds the switch tile with the
        /// new value.
        ///
        /// If null, the switch will be displayed as disabled.
        ///
        /// The callback provided to [onChanged] should update the state of the parent
        /// [StatefulWidget] using the [State.setState] method, so that the parent
        /// gets rebuilt; for example:
        ///
        /// ```dart
        /// SwitchListTile(
        ///   value: _isSelected,
        ///   onChanged: (bool newValue) {
        ///     setState(() {
        ///       _isSelected = newValue;
        ///     });
        ///   },
        ///   title: Text('Selection'),
        /// )
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        /// <Summary>
        /// The color to use when this switch is on.
        ///
        /// Defaults to accent color of the current [Theme].
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        /// <Summary>
        /// The color to use on the track when this switch is on.
        ///
        /// Defaults to [ThemeData.toggleableActiveColor] with the opacity set at 50%.
        ///
        /// Ignored if created with [SwitchListTile.adaptive].
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActiveTrackColor { get; set; }
        /// <Summary>
        /// The color to use on the thumb when this switch is off.
        ///
        /// Defaults to the colors described in the Material design specification.
        ///
        /// Ignored if created with [SwitchListTile.adaptive].
        /// </Summary>
        public virtual FlutterBinding.UI.Color InactiveThumbColor { get; set; }
        /// <Summary>
        /// The color to use on the track when this switch is off.
        ///
        /// Defaults to the colors described in the Material design specification.
        ///
        /// Ignored if created with [SwitchListTile.adaptive].
        /// </Summary>
        public virtual FlutterBinding.UI.Color InactiveTrackColor { get; set; }
        /// <Summary>
        /// An image to use on the thumb of this switch when the switch is on.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ActiveThumbImage { get; set; }
        /// <Summary>
        /// An image to use on the thumb of this switch when the switch is off.
        ///
        /// Ignored if created with [SwitchListTile.adaptive].
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> InactiveThumbImage { get; set; }
        /// <Summary>
        /// The primary content of the list tile.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// Additional content displayed below the title.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Subtitle { get; set; }
        /// <Summary>
        /// A widget to display on the opposite side of the tile from the switch.
        ///
        /// Typically an [Icon] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Secondary { get; set; }
        /// <Summary>
        /// Whether this list tile is intended to display three lines of text.
        ///
        /// If false, the list tile is treated as having one line if the subtitle is
        /// null and treated as having two lines if the subtitle is non-null.
        /// </Summary>
        public virtual bool IsThreeLine { get; set; }
        /// <Summary>
        /// Whether this list tile is part of a vertically dense list.
        ///
        /// If this property is null then its value is based on [ListTileTheme.dense].
        /// </Summary>
        public virtual bool Dense { get; set; }
        /// <Summary>
        /// The tile's internal padding.
        ///
        /// Insets a [SwitchListTile]'s contents: its [title], [subtitle],
        /// [secondary], and [Switch] widgets.
        ///
        /// If null, [ListTile]'s default of `EdgeInsets.symmetric(horizontal: 16.0)`
        /// is used.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        /// <Summary>
        /// Whether to render icons and text in the [activeColor].
        ///
        /// No effort is made to automatically coordinate the [selected] state and the
        /// [value] state. To have the list tile appear selected when the switch is
        /// on, pass the same value to both.
        ///
        /// Normally, this property is left to its default value, false.
        /// </Summary>
        public virtual bool Selected { get; set; }
        /// <Summary>
        /// If adaptive, creates the switch with [Switch.adaptive].
        /// </Summary>
        internal virtual FlutterSDK.Material.Switchlisttile._SwitchListTileType _SwitchListTileType { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget control = default(Widget);
            switch (_SwitchListTileType) { case _SwitchListTileType.Adaptive: control = Switch.Adaptive(value: Value, onChanged: OnChanged, activeColor: ActiveColor, activeThumbImage: ActiveThumbImage, inactiveThumbImage: InactiveThumbImage, materialTapTargetSize: MaterialTapTargetSize.ShrinkWrap, activeTrackColor: ActiveTrackColor, inactiveTrackColor: InactiveTrackColor, inactiveThumbColor: InactiveThumbColor); break; case _SwitchListTileType.Material: control = new Switch(value: Value, onChanged: OnChanged, activeColor: ActiveColor, activeThumbImage: ActiveThumbImage, inactiveThumbImage: InactiveThumbImage, materialTapTargetSize: MaterialTapTargetSize.ShrinkWrap, activeTrackColor: ActiveTrackColor, inactiveTrackColor: InactiveTrackColor, inactiveThumbColor: InactiveThumbColor); }
            return new MergeSemantics(child: ListtileDefaultClass.ListTileTheme.Merge(selectedColor: ActiveColor ?? ThemeDefaultClass.Theme.Of(context).AccentColor, child: new ListTile(leading: Secondary, title: Title, subtitle: Subtitle, trailing: control, isThreeLine: IsThreeLine, dense: Dense, contentPadding: ContentPadding, enabled: OnChanged != null, onTap: OnChanged != null ? () =>
            {
                OnChanged(!Value);
            }
            : null, selected: Selected)));
        }



    }


    public enum _SwitchListTileType
    {

        Material,
        Adaptive,
    }

}
