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
namespace FlutterSDK.Material.Radiolisttile
{
    internal static class RadiolisttileDefaultClass
    {
    }

    /// <Summary>
    /// A [ListTile] with a [Radio]. In other words, a radio button with a label.
    ///
    /// The entire list tile is interactive: tapping anywhere in the tile selects
    /// the radio button.
    ///
    /// The [value], [groupValue], [onChanged], and [activeColor] properties of this
    /// widget are identical to the similarly-named properties on the [Radio]
    /// widget. The type parameter `T` serves the same purpose as that of the
    /// [Radio] class' type parameter.
    ///
    /// The [title], [subtitle], [isThreeLine], and [dense] properties are like
    /// those of the same name on [ListTile].
    ///
    /// The [selected] property on this widget is similar to the [ListTile.selected]
    /// property, but the color used is that described by [activeColor], if any,
    /// defaulting to the accent color of the current [Theme]. No effort is made to
    /// coordinate the [selected] state and the [checked] state; to have the list
    /// tile appear selected when the radio button is the selected radio button, set
    /// [selected] to true when [value] matches [groupValue].
    ///
    /// The radio button is shown on the left by default in left-to-right languages
    /// (i.e. the leading edge). This can be changed using [controlAffinity]. The
    /// [secondary] widget is placed on the opposite side. This maps to the
    /// [ListTile.leading] and [ListTile.trailing] properties of [ListTile].
    ///
    /// To show the [RadioListTile] as disabled, pass null as the [onChanged]
    /// callback.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    ///
    /// ![RadioListTile sample](https://flutter.github.io/assets-for-api-docs/assets/material/radio_list_tile.png)
    ///
    /// This widget shows a pair of radio buttons that control the `_character`
    /// field. The field is of the type `SingingCharacter`, an enum.
    ///
    /// ```dart preamble
    /// enum SingingCharacter { lafayette, jefferson }
    /// ```
    /// ```dart
    /// SingingCharacter _character = SingingCharacter.lafayette;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Column(
    ///     children: <Widget>[
    ///       RadioListTile<SingingCharacter>(
    ///         title: const Text('Lafayette'),
    ///         value: SingingCharacter.lafayette,
    ///         groupValue: _character,
    ///         onChanged: (SingingCharacter value) { setState(() { _character = value; }); },
    ///       ),
    ///       RadioListTile<SingingCharacter>(
    ///         title: const Text('Thomas Jefferson'),
    ///         value: SingingCharacter.jefferson,
    ///         groupValue: _character,
    ///         onChanged: (SingingCharacter value) { setState(() { _character = value; }); },
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ## Semantics in RadioListTile
    ///
    /// Since the entirety of the RadioListTile is interactive, it should represent
    /// itself as a single interactive entity.
    ///
    /// To do so, a RadioListTile widget wraps its children with a [MergeSemantics]
    /// widget. [MergeSemantics] will attempt to merge its descendant [Semantics]
    /// nodes into one node in the semantics tree. Therefore, RadioListTile will
    /// throw an error if any of its children requires its own [Semantics] node.
    ///
    /// For example, you cannot nest a [RichText] widget as a descendant of
    /// RadioListTile. [RichText] has an embedded gesture recognizer that
    /// requires its own [Semantics] node, which directly conflicts with
    /// RadioListTile's desire to merge all its descendants' semantic nodes
    /// into one. Therefore, it may be necessary to create a custom radio tile
    /// widget to accommodate similar use cases.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    ///
    /// ![Radio list tile semantics sample](https://flutter.github.io/assets-for-api-docs/assets/material/radio_list_tile_semantics.png)
    ///
    /// Here is an example of a custom labeled radio widget, called
    /// LinkedLabelRadio, that includes an interactive [RichText] widget that
    /// handles tap gestures.
    ///
    /// ```dart imports
    /// import 'package:flutter/gestures.dart';
    /// ```
    /// ```dart preamble
    /// class LinkedLabelRadio extends StatelessWidget {
    ///   const LinkedLabelRadio({
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
    ///     return Padding(
    ///       padding: padding,
    ///       child: Row(
    ///         children: <Widget>[
    ///           Radio<bool>(
    ///             groupValue: groupValue,
    ///             value: value,
    ///             onChanged: (bool newValue) {
    ///               onChanged(newValue);
    ///             }
    ///           ),
    ///           RichText(
    ///             text: TextSpan(
    ///               text: label,
    ///               style: TextStyle(
    ///                 color: Colors.blueAccent,
    ///                 decoration: TextDecoration.underline,
    ///               ),
    ///               recognizer: TapGestureRecognizer()
    ///                 ..onTap = () {
    ///                 print('Label has been tapped.');
    ///               },
    ///             ),
    ///           ),
    ///         ],
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// ```dart
    /// bool _isRadioSelected = false;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Column(
    ///       mainAxisAlignment: MainAxisAlignment.center,
    ///       children: <Widget>[
    ///         LinkedLabelRadio(
    ///           label: 'First tappable label text',
    ///           padding: EdgeInsets.symmetric(horizontal: 5.0),
    ///           value: true,
    ///           groupValue: _isRadioSelected,
    ///           onChanged: (bool newValue) {
    ///             setState(() {
    ///               _isRadioSelected = newValue;
    ///             });
    ///           },
    ///         ),
    ///         LinkedLabelRadio(
    ///           label: 'Second tappable label text',
    ///           padding: EdgeInsets.symmetric(horizontal: 5.0),
    ///           value: false,
    ///           groupValue: _isRadioSelected,
    ///           onChanged: (bool newValue) {
    ///             setState(() {
    ///               _isRadioSelected = newValue;
    ///             });
    ///           },
    ///         ),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ## RadioListTile isn't exactly what I want
    ///
    /// If the way RadioListTile pads and positions its elements isn't quite what
    /// you're looking for, you can create custom labeled radio widgets by
    /// combining [Radio] with other widgets, such as [Text], [Padding] and
    /// [InkWell].
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    ///
    /// ![Custom radio list tile sample](https://flutter.github.io/assets-for-api-docs/assets/material/radio_list_tile_custom.png)
    ///
    /// Here is an example of a custom LabeledRadio widget, but you can easily
    /// make your own configurable widget.
    ///
    /// ```dart preamble
    /// class LabeledRadio extends StatelessWidget {
    ///   const LabeledRadio({
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
    ///         if (value != groupValue)
    ///           onChanged(value);
    ///       },
    ///       child: Padding(
    ///         padding: padding,
    ///         child: Row(
    ///           children: <Widget>[
    ///             Radio<bool>(
    ///               groupValue: groupValue,
    ///               value: value,
    ///               onChanged: (bool newValue) {
    ///                 onChanged(newValue);
    ///               },
    ///             ),
    ///             Text(label),
    ///           ],
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// ```dart
    /// bool _isRadioSelected = false;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Column(
    ///       mainAxisAlignment: MainAxisAlignment.center,
    ///       children: <LabeledRadio>[
    ///         LabeledRadio(
    ///           label: 'This is the first label text',
    ///           padding: const EdgeInsets.symmetric(horizontal: 5.0),
    ///           value: true,
    ///           groupValue: _isRadioSelected,
    ///           onChanged: (bool newValue) {
    ///             setState(() {
    ///               _isRadioSelected = newValue;
    ///             });
    ///           },
    ///         ),
    ///         LabeledRadio(
    ///           label: 'This is the second label text',
    ///           padding: const EdgeInsets.symmetric(horizontal: 5.0),
    ///           value: false,
    ///           groupValue: _isRadioSelected,
    ///           onChanged: (bool newValue) {
    ///             setState(() {
    ///               _isRadioSelected = newValue;
    ///             });
    ///           },
    ///         ),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ListTileTheme], which can be used to affect the style of list tiles,
    ///    including radio list tiles.
    ///  * [CheckboxListTile], a similar widget for checkboxes.
    ///  * [SwitchListTile], a similar widget for switches.
    ///  * [ListTile] and [Radio], the widgets from which this widget is made.
    /// </Summary>
    public class RadioListTile<T> : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public RadioListTile(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T value = default(T), T groupValue = default(T), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), bool isThreeLine = false, bool dense = default(bool), FlutterSDK.Widgets.Framework.Widget secondary = default(FlutterSDK.Widgets.Framework.Widget), bool selected = false, FlutterSDK.Material.Listtile.ListTileControlAffinity controlAffinity = default(FlutterSDK.Material.Listtile.ListTileControlAffinity))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual T Value { get; set; }
    public virtual T GroupValue { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnChanged { get; set; }
    public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Subtitle { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Secondary { get; set; }
    public virtual bool IsThreeLine { get; set; }
    public virtual bool Dense { get; set; }
    public virtual bool Selected { get; set; }
    public virtual FlutterSDK.Material.Listtile.ListTileControlAffinity ControlAffinity { get; set; }
    public virtual bool @checked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        Widget control = new Radio<T>(value: Value, groupValue: GroupValue, onChanged: OnChanged, activeColor: ActiveColor, materialTapTargetSize: MaterialTapTargetSize.ShrinkWrap);
        Widget leading trailing = default(Widget);
        switch (ControlAffinity) { case ListTileControlAffinity.Leading: case ListTileControlAffinity.Platform: leading = control; trailing = Secondary; break; case ListTileControlAffinity.Trailing: leading = Secondary; trailing = control; break; }
        return new MergeSemantics(child: ListtileDefaultClass.ListTileTheme.Merge(selectedColor: ActiveColor ?? ThemeDefaultClass.Theme.Of(context).AccentColor, child: new ListTile(leading: leading, title: Title, subtitle: Subtitle, trailing: trailing, isThreeLine: IsThreeLine, dense: Dense, enabled: OnChanged != null, onTap: OnChanged != null && !Checked ? () =>
        {
            OnChanged(Value);
        }
        : null, selected: Selected)));
    }



    #endregion
}

}
