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
namespace FlutterSDK.Services.Keyboardkey
{
    internal static class KeyboardkeyDefaultClass
    {
    }

    /// <Summary>
    /// A base class for all keyboard key types.
    ///
    /// See also:
    ///
    ///  * [PhysicalKeyboardKey], a class with static values that describe the keys
    ///    that are returned from [RawKeyEvent.physicalKey].
    ///  * [LogicalKeyboardKey], a class with static values that describe the keys
    ///    that are returned from [RawKeyEvent.logicalKey].
    /// </Summary>
    public interface IKeyboardKey
    {
    }


    /// <Summary>
    /// A base class for all keyboard key types.
    ///
    /// See also:
    ///
    ///  * [PhysicalKeyboardKey], a class with static values that describe the keys
    ///    that are returned from [RawKeyEvent.physicalKey].
    ///  * [LogicalKeyboardKey], a class with static values that describe the keys
    ///    that are returned from [RawKeyEvent.logicalKey].
    /// </Summary>
    public class KeyboardKey : IDiagnosticable
    {
        /// <Summary>
        /// A const constructor so that subclasses may be const.
        /// </Summary>
        public KeyboardKey()
        {

        }
    }


    /// <Summary>
    /// A class with static values that describe the keys that are returned from
    /// [RawKeyEvent.logicalKey].
    ///
    /// These represent *logical* keys, which are keys which are interpreted in the
    /// context of any modifiers, modes, or keyboard layouts which may be in effect.
    ///
    /// This is contrast to [PhysicalKeyboardKey], which represents a physical key
    /// in a particular location on the keyboard, without regard for the modifier
    /// state, mode, or keyboard layout.
    ///
    /// As an example, if you wanted to implement an app where the "Q" key "quit"
    /// something, you'd want to look at the logical key to detect this, since you
    /// would like to have it match the key with "Q" on it, instead of always
    /// looking for "the key next next to the TAB key", since on a French keyboard,
    /// the key next to the TAB key has an "A" on it.
    ///
    /// Conversely, if you wanted a game where the key next to the CAPS LOCK (the
    /// "A" key on a QWERTY keyboard) moved the player to the left, you'd want to
    /// look at the physical key to make sure that regardless of the character the
    /// key produces, you got the key that is in that location on the keyboard.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    /// This example shows how to detect if the user has selected the logical "Q"
    /// key.
    ///
    /// ```dart imports
    /// import 'package:flutter/foundation.dart';
    /// import 'package:flutter/services.dart';
    /// ```
    ///
    /// ```dart
    /// // The node used to request the keyboard focus.
    /// final FocusNode _focusNode = FocusNode();
    /// // The message to display.
    /// String _message;
    ///
    /// // Focus nodes need to be disposed.
    /// @override
    /// void dispose() {
    ///   _focusNode.dispose();
    ///   super.dispose();
    /// }
    ///
    /// // Handles the key events from the RawKeyboardListener and update the
    /// // _message.
    /// void _handleKeyEvent(RawKeyEvent event) {
    ///   setState(() {
    ///     if (event.logicalKey == LogicalKeyboardKey.keyQ) {
    ///       _message = 'Pressed the "Q" key!';
    ///     } else {
    ///       if (kReleaseMode) {
    ///         _message = 'Not a Q: Key label is "${event.logicalKey.keyLabel ?? '<none>'}"';
    ///       } else {
    ///         // This will only print useful information in debug mode.
    ///         _message = 'Not a Q: Pressed ${event.logicalKey.debugName}';
    ///       }
    ///     }
    ///   });
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   final TextTheme textTheme = Theme.of(context).textTheme;
    ///   return Container(
    ///     color: Colors.white,
    ///     alignment: Alignment.center,
    ///     child: DefaultTextStyle(
    ///       style: textTheme.headline4,
    ///       child: RawKeyboardListener(
    ///         focusNode: _focusNode,
    ///         onKey: _handleKeyEvent,
    ///         child: AnimatedBuilder(
    ///           animation: _focusNode,
    ///           builder: (BuildContext context, Widget child) {
    ///             if (!_focusNode.hasFocus) {
    ///               return GestureDetector(
    ///                 onTap: () {
    ///                   FocusScope.of(context).requestFocus(_focusNode);
    ///                 },
    ///                 child: const Text('Tap to focus'),
    ///               );
    ///             }
    ///             return Text(_message ?? 'Press a key');
    ///           },
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    /// See also:
    ///
    ///  * [RawKeyEvent], the keyboard event object received by widgets that listen
    ///    to keyboard events.
    ///  * [RawKeyboardListener], a widget used to listen to and supply handlers for
    ///    keyboard events.
    /// </Summary>
    public class LogicalKeyboardKey : FlutterSDK.Services.Keyboardkey.KeyboardKey
    {
        /// <Summary>
        /// Creates a LogicalKeyboardKey object with an optional key label and debug
        /// name.
        ///
        /// [keyId] must not be null.
        ///
        /// {@tool snippet}
        /// To save executable size, it is recommended that the [debugName] be null in
        /// release mode. You can do this by using the [kReleaseMode] constant.
        ///
        /// ```dart
        /// const LogicalKeyboardKey(0x0010000000a, debugName: kReleaseMode ? null : 'Special Key')
        /// ```
        /// {@end-tool}
        /// </Summary>
        public LogicalKeyboardKey(int keyId, string debugName = default(string), string keyLabel = default(string))
        : base()
        {
            this.KeyId = keyId;
            this.DebugName = debugName;
            this.KeyLabel = keyLabel;
        }
        /// <Summary>
        /// A unique code representing this key.
        ///
        /// This is an opaque code. It should not be unpacked to derive information
        /// from it, as the representation of the code could change at any time.
        /// </Summary>
        public virtual int KeyId { get; set; }
        /// <Summary>
        /// The debug string to print for this keyboard key, which will be null in
        /// release mode.
        /// </Summary>
        public virtual string DebugName { get; set; }
        /// <Summary>
        /// The Unicode string representing the character produced by a [RawKeyEvent].
        ///
        /// This value is useful for describing or matching mnemonic keyboard
        /// shortcuts.
        ///
        /// On most platforms this is a single code point, but it could contain any
        /// Unicode string. The `keyLabel` differs from [RawKeyEvent.character]
        /// because `keyLabel` only takes into account the key being pressed, not any
        /// combining keys pressed before it, so, for example, an “o” that follows a
        /// combining dieresis (“¨”, COMBINING DIAERESIS (U+0308)) would just return
        /// “o” for [keyLabel], but would return “ö” for [RawKeyEvent.character].
        ///
        /// {@macro flutter.services.RawKeyEventData.keyLabel}
        /// </Summary>
        public virtual string KeyLabel { get; set; }
        /// <Summary>
        /// Mask for the 32-bit value portion of the key code.
        ///
        /// This is used by platform-specific code to generate Flutter key codes.
        /// </Summary>
        public virtual int ValueMask { get; set; }
        /// <Summary>
        /// Mask for the platform prefix portion of the key code.
        ///
        /// This is used by platform-specific code to generate Flutter key codes.
        /// </Summary>
        public virtual int PlatformMask { get; set; }
        /// <Summary>
        /// Mask for the auto-generated bit portion of the key code.
        ///
        /// This is used by platform-specific code to generate new Flutter key codes
        /// for keys which are not recognized.
        /// </Summary>
        public virtual int AutogeneratedMask { get; set; }
        /// <Summary>
        /// Mask for the synonym pseudo-keys generated for keys which appear in more
        /// than one place on the keyboard.
        ///
        /// IDs in this range are used to represent keys which appear in multiple
        /// places on the keyboard, such as the SHIFT, ALT, CTRL, and numeric keypad
        /// keys. These key codes will never be generated by the key event system, but
        /// may be used in key maps to represent the union of all the keys of each
        /// type in order to match them.
        ///
        /// To look up the synonyms that are defined, look in the [synonyms] map.
        /// </Summary>
        public virtual int SynonymMask { get; set; }
        /// <Summary>
        /// The code prefix for keys which have a Unicode representation.
        ///
        /// This is used by platform-specific code to generate Flutter key codes.
        /// </Summary>
        public virtual int UnicodePlane { get; set; }
        /// <Summary>
        /// The code prefix for keys which do not have a Unicode representation.
        ///
        /// This is used by platform-specific code to generate Flutter key codes using
        /// HID Usage codes.
        /// </Summary>
        public virtual int HidPlane { get; set; }
        /// <Summary>
        /// Represents the logical "None" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey None { get; set; }
        /// <Summary>
        /// Represents the logical "Hyper" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Hyper { get; set; }
        /// <Summary>
        /// Represents the logical "Super Key" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SuperKey { get; set; }
        /// <Summary>
        /// Represents the logical "Fn Lock" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey FnLock { get; set; }
        /// <Summary>
        /// Represents the logical "Suspend" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Suspend { get; set; }
        /// <Summary>
        /// Represents the logical "Resume" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Resume { get; set; }
        /// <Summary>
        /// Represents the logical "Turbo" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Turbo { get; set; }
        /// <Summary>
        /// Represents the logical "Privacy Screen Toggle" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PrivacyScreenToggle { get; set; }
        /// <Summary>
        /// Represents the logical "Sleep" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Sleep { get; set; }
        /// <Summary>
        /// Represents the logical "Wake Up" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey WakeUp { get; set; }
        /// <Summary>
        /// Represents the logical "Display Toggle Int Ext" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey DisplayToggleIntExt { get; set; }
        /// <Summary>
        /// Represents the logical "Usb Reserved" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbReserved { get; set; }
        /// <Summary>
        /// Represents the logical "Usb Error Roll Over" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbErrorRollOver { get; set; }
        /// <Summary>
        /// Represents the logical "Usb Post Fail" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbPostFail { get; set; }
        /// <Summary>
        /// Represents the logical "Usb Error Undefined" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbErrorUndefined { get; set; }
        /// <Summary>
        /// Represents the logical "Key A" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyA { get; set; }
        /// <Summary>
        /// Represents the logical "Key B" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyB { get; set; }
        /// <Summary>
        /// Represents the logical "Key C" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyC { get; set; }
        /// <Summary>
        /// Represents the logical "Key D" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyD { get; set; }
        /// <Summary>
        /// Represents the logical "Key E" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyE { get; set; }
        /// <Summary>
        /// Represents the logical "Key F" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyF { get; set; }
        /// <Summary>
        /// Represents the logical "Key G" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyG { get; set; }
        /// <Summary>
        /// Represents the logical "Key H" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyH { get; set; }
        /// <Summary>
        /// Represents the logical "Key I" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyI { get; set; }
        /// <Summary>
        /// Represents the logical "Key J" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyJ { get; set; }
        /// <Summary>
        /// Represents the logical "Key K" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyK { get; set; }
        /// <Summary>
        /// Represents the logical "Key L" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyL { get; set; }
        /// <Summary>
        /// Represents the logical "Key M" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyM { get; set; }
        /// <Summary>
        /// Represents the logical "Key N" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyN { get; set; }
        /// <Summary>
        /// Represents the logical "Key O" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyO { get; set; }
        /// <Summary>
        /// Represents the logical "Key P" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyP { get; set; }
        /// <Summary>
        /// Represents the logical "Key Q" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyQ { get; set; }
        /// <Summary>
        /// Represents the logical "Key R" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyR { get; set; }
        /// <Summary>
        /// Represents the logical "Key S" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyS { get; set; }
        /// <Summary>
        /// Represents the logical "Key T" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyT { get; set; }
        /// <Summary>
        /// Represents the logical "Key U" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyU { get; set; }
        /// <Summary>
        /// Represents the logical "Key V" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyV { get; set; }
        /// <Summary>
        /// Represents the logical "Key W" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyW { get; set; }
        /// <Summary>
        /// Represents the logical "Key X" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyX { get; set; }
        /// <Summary>
        /// Represents the logical "Key Y" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyY { get; set; }
        /// <Summary>
        /// Represents the logical "Key Z" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyZ { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit1 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit2 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 3" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit3 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 4" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit4 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 5" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit5 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 6" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit6 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 7" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit7 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 8" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit8 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 9" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit9 { get; set; }
        /// <Summary>
        /// Represents the logical "Digit 0" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit0 { get; set; }
        /// <Summary>
        /// Represents the logical "Enter" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Enter { get; set; }
        /// <Summary>
        /// Represents the logical "Escape" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Escape { get; set; }
        /// <Summary>
        /// Represents the logical "Backspace" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Backspace { get; set; }
        /// <Summary>
        /// Represents the logical "Tab" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Tab { get; set; }
        /// <Summary>
        /// Represents the logical "Space" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Space { get; set; }
        /// <Summary>
        /// Represents the logical "Minus" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Minus { get; set; }
        /// <Summary>
        /// Represents the logical "Equal" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Equal { get; set; }
        /// <Summary>
        /// Represents the logical "Bracket Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BracketLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Bracket Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BracketRight { get; set; }
        /// <Summary>
        /// Represents the logical "Backslash" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Backslash { get; set; }
        /// <Summary>
        /// Represents the logical "Semicolon" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Semicolon { get; set; }
        /// <Summary>
        /// Represents the logical "Quote" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Quote { get; set; }
        /// <Summary>
        /// Represents the logical "Backquote" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Backquote { get; set; }
        /// <Summary>
        /// Represents the logical "Comma" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Comma { get; set; }
        /// <Summary>
        /// Represents the logical "Period" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Period { get; set; }
        /// <Summary>
        /// Represents the logical "Slash" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Slash { get; set; }
        /// <Summary>
        /// Represents the logical "Caps Lock" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey CapsLock { get; set; }
        /// <Summary>
        /// Represents the logical "F1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F1 { get; set; }
        /// <Summary>
        /// Represents the logical "F2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F2 { get; set; }
        /// <Summary>
        /// Represents the logical "F3" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F3 { get; set; }
        /// <Summary>
        /// Represents the logical "F4" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F4 { get; set; }
        /// <Summary>
        /// Represents the logical "F5" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F5 { get; set; }
        /// <Summary>
        /// Represents the logical "F6" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F6 { get; set; }
        /// <Summary>
        /// Represents the logical "F7" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F7 { get; set; }
        /// <Summary>
        /// Represents the logical "F8" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F8 { get; set; }
        /// <Summary>
        /// Represents the logical "F9" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F9 { get; set; }
        /// <Summary>
        /// Represents the logical "F10" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F10 { get; set; }
        /// <Summary>
        /// Represents the logical "F11" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F11 { get; set; }
        /// <Summary>
        /// Represents the logical "F12" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F12 { get; set; }
        /// <Summary>
        /// Represents the logical "Print Screen" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PrintScreen { get; set; }
        /// <Summary>
        /// Represents the logical "Scroll Lock" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ScrollLock { get; set; }
        /// <Summary>
        /// Represents the logical "Pause" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Pause { get; set; }
        /// <Summary>
        /// Represents the logical "Insert" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Insert { get; set; }
        /// <Summary>
        /// Represents the logical "Home" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Home { get; set; }
        /// <Summary>
        /// Represents the logical "Page Up" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PageUp { get; set; }
        /// <Summary>
        /// Represents the logical "Delete" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Delete { get; set; }
        /// <Summary>
        /// Represents the logical "End" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey End { get; set; }
        /// <Summary>
        /// Represents the logical "Page Down" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PageDown { get; set; }
        /// <Summary>
        /// Represents the logical "Arrow Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowRight { get; set; }
        /// <Summary>
        /// Represents the logical "Arrow Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Arrow Down" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowDown { get; set; }
        /// <Summary>
        /// Represents the logical "Arrow Up" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowUp { get; set; }
        /// <Summary>
        /// Represents the logical "Num Lock" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumLock { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Divide" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadDivide { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Multiply" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMultiply { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Subtract" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadSubtract { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Add" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadAdd { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Enter" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadEnter { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad1 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad2 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 3" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad3 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 4" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad4 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 5" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad5 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 6" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad6 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 7" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad7 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 8" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad8 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 9" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad9 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad 0" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad0 { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Decimal" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadDecimal { get; set; }
        /// <Summary>
        /// Represents the logical "Intl Backslash" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey IntlBackslash { get; set; }
        /// <Summary>
        /// Represents the logical "Context Menu" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ContextMenu { get; set; }
        /// <Summary>
        /// Represents the logical "Power" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Power { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Equal" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadEqual { get; set; }
        /// <Summary>
        /// Represents the logical "F13" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F13 { get; set; }
        /// <Summary>
        /// Represents the logical "F14" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F14 { get; set; }
        /// <Summary>
        /// Represents the logical "F15" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F15 { get; set; }
        /// <Summary>
        /// Represents the logical "F16" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F16 { get; set; }
        /// <Summary>
        /// Represents the logical "F17" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F17 { get; set; }
        /// <Summary>
        /// Represents the logical "F18" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F18 { get; set; }
        /// <Summary>
        /// Represents the logical "F19" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F19 { get; set; }
        /// <Summary>
        /// Represents the logical "F20" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F20 { get; set; }
        /// <Summary>
        /// Represents the logical "F21" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F21 { get; set; }
        /// <Summary>
        /// Represents the logical "F22" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F22 { get; set; }
        /// <Summary>
        /// Represents the logical "F23" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F23 { get; set; }
        /// <Summary>
        /// Represents the logical "F24" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F24 { get; set; }
        /// <Summary>
        /// Represents the logical "Open" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Open { get; set; }
        /// <Summary>
        /// Represents the logical "Help" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Help { get; set; }
        /// <Summary>
        /// Represents the logical "Select" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Select { get; set; }
        /// <Summary>
        /// Represents the logical "Again" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Again { get; set; }
        /// <Summary>
        /// Represents the logical "Undo" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Undo { get; set; }
        /// <Summary>
        /// Represents the logical "Cut" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Cut { get; set; }
        /// <Summary>
        /// Represents the logical "Copy" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Copy { get; set; }
        /// <Summary>
        /// Represents the logical "Paste" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Paste { get; set; }
        /// <Summary>
        /// Represents the logical "Find" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Find { get; set; }
        /// <Summary>
        /// Represents the logical "Audio Volume Mute" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AudioVolumeMute { get; set; }
        /// <Summary>
        /// Represents the logical "Audio Volume Up" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AudioVolumeUp { get; set; }
        /// <Summary>
        /// Represents the logical "Audio Volume Down" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AudioVolumeDown { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Comma" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadComma { get; set; }
        /// <Summary>
        /// Represents the logical "Intl Ro" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey IntlRo { get; set; }
        /// <Summary>
        /// Represents the logical "Kana Mode" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KanaMode { get; set; }
        /// <Summary>
        /// Represents the logical "Intl Yen" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey IntlYen { get; set; }
        /// <Summary>
        /// Represents the logical "Convert" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Convert { get; set; }
        /// <Summary>
        /// Represents the logical "Non Convert" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NonConvert { get; set; }
        /// <Summary>
        /// Represents the logical "Lang 1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang1 { get; set; }
        /// <Summary>
        /// Represents the logical "Lang 2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang2 { get; set; }
        /// <Summary>
        /// Represents the logical "Lang 3" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang3 { get; set; }
        /// <Summary>
        /// Represents the logical "Lang 4" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang4 { get; set; }
        /// <Summary>
        /// Represents the logical "Lang 5" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang5 { get; set; }
        /// <Summary>
        /// Represents the logical "Abort" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Abort { get; set; }
        /// <Summary>
        /// Represents the logical "Props" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Props { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Paren Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadParenLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Paren Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadParenRight { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Backspace" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadBackspace { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Memory Store" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryStore { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Memory Recall" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryRecall { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Memory Clear" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryClear { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Memory Add" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryAdd { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Memory Subtract" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemorySubtract { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Sign Change" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadSignChange { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Clear" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadClear { get; set; }
        /// <Summary>
        /// Represents the logical "Numpad Clear Entry" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadClearEntry { get; set; }
        /// <Summary>
        /// Represents the logical "Control Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ControlLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Shift Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ShiftLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Alt Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AltLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Meta Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MetaLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Control Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ControlRight { get; set; }
        /// <Summary>
        /// Represents the logical "Shift Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ShiftRight { get; set; }
        /// <Summary>
        /// Represents the logical "Alt Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AltRight { get; set; }
        /// <Summary>
        /// Represents the logical "Meta Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MetaRight { get; set; }
        /// <Summary>
        /// Represents the logical "Info" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Info { get; set; }
        /// <Summary>
        /// Represents the logical "Closed Caption Toggle" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ClosedCaptionToggle { get; set; }
        /// <Summary>
        /// Represents the logical "Brightness Up" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessUp { get; set; }
        /// <Summary>
        /// Represents the logical "Brightness Down" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessDown { get; set; }
        /// <Summary>
        /// Represents the logical "Brightness Toggle" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessToggle { get; set; }
        /// <Summary>
        /// Represents the logical "Brightness Minimum" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessMinimum { get; set; }
        /// <Summary>
        /// Represents the logical "Brightness Maximum" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessMaximum { get; set; }
        /// <Summary>
        /// Represents the logical "Brightness Auto" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessAuto { get; set; }
        /// <Summary>
        /// Represents the logical "Media Last" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaLast { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Phone" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchPhone { get; set; }
        /// <Summary>
        /// Represents the logical "Program Guide" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ProgramGuide { get; set; }
        /// <Summary>
        /// Represents the logical "Exit" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Exit { get; set; }
        /// <Summary>
        /// Represents the logical "Channel Up" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ChannelUp { get; set; }
        /// <Summary>
        /// Represents the logical "Channel Down" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ChannelDown { get; set; }
        /// <Summary>
        /// Represents the logical "Media Play" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaPlay { get; set; }
        /// <Summary>
        /// Represents the logical "Media Pause" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaPause { get; set; }
        /// <Summary>
        /// Represents the logical "Media Record" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaRecord { get; set; }
        /// <Summary>
        /// Represents the logical "Media Fast Forward" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaFastForward { get; set; }
        /// <Summary>
        /// Represents the logical "Media Rewind" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaRewind { get; set; }
        /// <Summary>
        /// Represents the logical "Media Track Next" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaTrackNext { get; set; }
        /// <Summary>
        /// Represents the logical "Media Track Previous" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaTrackPrevious { get; set; }
        /// <Summary>
        /// Represents the logical "Media Stop" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaStop { get; set; }
        /// <Summary>
        /// Represents the logical "Eject" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Eject { get; set; }
        /// <Summary>
        /// Represents the logical "Media Play Pause" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaPlayPause { get; set; }
        /// <Summary>
        /// Represents the logical "Speech Input Toggle" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SpeechInputToggle { get; set; }
        /// <Summary>
        /// Represents the logical "Bass Boost" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BassBoost { get; set; }
        /// <Summary>
        /// Represents the logical "Media Select" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaSelect { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Word Processor" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchWordProcessor { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Spreadsheet" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchSpreadsheet { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Mail" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchMail { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Contacts" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchContacts { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Calendar" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchCalendar { get; set; }
        /// <Summary>
        /// Represents the logical "Launch App2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchApp2 { get; set; }
        /// <Summary>
        /// Represents the logical "Launch App1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchApp1 { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Internet Browser" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchInternetBrowser { get; set; }
        /// <Summary>
        /// Represents the logical "Log Off" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogOff { get; set; }
        /// <Summary>
        /// Represents the logical "Lock Screen" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LockScreen { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Control Panel" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchControlPanel { get; set; }
        /// <Summary>
        /// Represents the logical "Select Task" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SelectTask { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Documents" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchDocuments { get; set; }
        /// <Summary>
        /// Represents the logical "Spell Check" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SpellCheck { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Keyboard Layout" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchKeyboardLayout { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Screen Saver" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchScreenSaver { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Assistant" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchAssistant { get; set; }
        /// <Summary>
        /// Represents the logical "Launch Audio Browser" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchAudioBrowser { get; set; }
        /// <Summary>
        /// Represents the logical "New Key" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NewKey { get; set; }
        /// <Summary>
        /// Represents the logical "Close" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Close { get; set; }
        /// <Summary>
        /// Represents the logical "Save" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Save { get; set; }
        /// <Summary>
        /// Represents the logical "Print" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Print { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Search" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserSearch { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Home" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserHome { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Back" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserBack { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Forward" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserForward { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Stop" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserStop { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Refresh" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserRefresh { get; set; }
        /// <Summary>
        /// Represents the logical "Browser Favorites" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserFavorites { get; set; }
        /// <Summary>
        /// Represents the logical "Zoom In" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ZoomIn { get; set; }
        /// <Summary>
        /// Represents the logical "Zoom Out" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ZoomOut { get; set; }
        /// <Summary>
        /// Represents the logical "Zoom Toggle" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ZoomToggle { get; set; }
        /// <Summary>
        /// Represents the logical "Redo" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Redo { get; set; }
        /// <Summary>
        /// Represents the logical "Mail Reply" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MailReply { get; set; }
        /// <Summary>
        /// Represents the logical "Mail Forward" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MailForward { get; set; }
        /// <Summary>
        /// Represents the logical "Mail Send" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MailSend { get; set; }
        /// <Summary>
        /// Represents the logical "Keyboard Layout Select" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyboardLayoutSelect { get; set; }
        /// <Summary>
        /// Represents the logical "Show All Windows" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ShowAllWindows { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton1 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton2 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 3" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton3 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 4" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton4 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 5" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton5 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 6" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton6 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 7" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton7 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 8" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton8 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 9" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton9 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 10" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton10 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 11" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton11 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 12" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton12 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 13" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton13 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 14" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton14 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 15" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton15 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button 16" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton16 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button A" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonA { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button B" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonB { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button C" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonC { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Left 1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonLeft1 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Left 2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonLeft2 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Mode" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonMode { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Right 1" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonRight1 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Right 2" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonRight2 { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Select" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonSelect { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Start" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonStart { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Thumb Left" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonThumbLeft { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Thumb Right" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonThumbRight { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button X" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonX { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Y" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonY { get; set; }
        /// <Summary>
        /// Represents the logical "Game Button Z" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonZ { get; set; }
        /// <Summary>
        /// Represents the logical "Fn" key on the keyboard.
        ///
        /// See the function [RawKeyEvent.logicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Fn { get; set; }
        /// <Summary>
        /// Represents the logical "Shift" key on the keyboard.
        ///
        /// This key represents the union of the keys {shiftLeft, shiftRight} when
        /// comparing keys. This key will never be generated directly, its main use is
        /// in defining key maps.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Shift { get; set; }
        /// <Summary>
        /// Represents the logical "Meta" key on the keyboard.
        ///
        /// This key represents the union of the keys {metaLeft, metaRight} when
        /// comparing keys. This key will never be generated directly, its main use is
        /// in defining key maps.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Meta { get; set; }
        /// <Summary>
        /// Represents the logical "Alt" key on the keyboard.
        ///
        /// This key represents the union of the keys {altLeft, altRight} when
        /// comparing keys. This key will never be generated directly, its main use is
        /// in defining key maps.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Alt { get; set; }
        /// <Summary>
        /// Represents the logical "Control" key on the keyboard.
        ///
        /// This key represents the union of the keys {controlLeft, controlRight} when
        /// comparing keys. This key will never be generated directly, its main use is
        /// in defining key maps.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Control { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _KnownLogicalKeys { get; set; }
        internal virtual Dictionary<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey, FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _Synonyms { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsAutogenerated { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> Synonyms { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is LogicalKeyboardKey && other.KeyId == KeyId;
        }




        /// <Summary>
        /// Returns the [LogicalKeyboardKey] constant that matches the given ID, or
        /// null, if not found.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey FindKeyByKeyId(int keyId) => _KnownLogicalKeys[keyId];



        /// <Summary>
        /// Returns true if the given label represents a Unicode control character.
        ///
        /// Examples of control characters are characters like "U+000A LINE FEED (LF)"
        /// or "U+001B ESCAPE (ESC)".
        ///
        /// See <https://en.wikipedia.org/wiki/Unicode_control_characters> for more
        /// information.
        ///
        /// Used by [RawKeyEvent] subclasses to help construct IDs.
        /// </Summary>
        public virtual bool IsControlCharacter(string label)
        {
            if (label.Length > 1)
            {
                return false;
            }

            int codeUnit = label.CodeUnitAt(0);
            return (codeUnit <= 0x1f && codeUnit >= 0x00) || (codeUnit >= 0x7f && codeUnit <= 0x9f);
        }




        /// <Summary>
        /// Takes a set of keys, and returns the same set, but with any keys that have
        /// synonyms replaced.
        ///
        /// It is used, for example, to make sets of keys with members like
        /// [controlRight] and [controlLeft] and convert that set to contain just
        /// [control], so that the question "is any control key down?" can be asked.
        /// </Summary>
        public virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> CollapseSynonyms(HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> input)
        {
            HashSet<LogicalKeyboardKey> result = new Dictionary<LogicalKeyboardKey> { };
            foreach (LogicalKeyboardKey key in input)
            {
                LogicalKeyboardKey synonym = _Synonyms[key];
                result.Add(synonym ?? key);
            }

            return result;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("keyId", $"'0x{KeyId.ToRadixString(16).PadLeft(8, '0')}'", showName: true));
            properties.Add(new StringProperty("keyLabel", KeyLabel, showName: true));
            properties.Add(new StringProperty("debugName", DebugName, showName: true, defaultValue: null));
        }



    }


    /// <Summary>
    /// A class with static values that describe the keys that are returned from
    /// [RawKeyEvent.physicalKey].
    ///
    /// These represent *physical* keys, which are keys which represent a particular
    /// key location on a QWERTY keyboard. It ignores any modifiers, modes, or
    /// keyboard layouts which may be in effect. This is contrast to
    /// [LogicalKeyboardKey], which represents a logical key interpreted in the
    /// context of modifiers, modes, and/or keyboard layouts.
    ///
    /// As an example, if you wanted a game where the key next to the CAPS LOCK (the
    /// "A" key on a QWERTY keyboard) moved the player to the left, you'd want to
    /// look at the physical key to make sure that regardless of the character the
    /// key produces, you got the key that is in that location on the keyboard.
    ///
    /// Conversely, if you wanted to implement an app where the "Q" key "quit"
    /// something, you'd want to look at the logical key to detect this, since you
    /// would like to have it match the key with "Q" on it, instead of always
    /// looking for "the key next next to the TAB key", since on a French keyboard,
    /// the key next to the TAB key has an "A" on it.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    /// This example shows how to detect if the user has selected the physical key
    /// to the right of the CAPS LOCK key.
    ///
    /// ```dart imports
    /// import 'package:flutter/services.dart';
    /// ```
    ///
    /// ```dart
    /// // The node used to request the keyboard focus.
    /// final FocusNode _focusNode = FocusNode();
    /// // The message to display.
    /// String _message;
    ///
    /// // Focus nodes need to be disposed.
    /// @override
    /// void dispose() {
    ///   _focusNode.dispose();
    ///   super.dispose();
    /// }
    ///
    /// // Handles the key events from the RawKeyboardListener and update the
    /// // _message.
    /// void _handleKeyEvent(RawKeyEvent event) {
    ///   setState(() {
    ///     if (event.physicalKey == PhysicalKeyboardKey.keyA) {
    ///       _message = 'Pressed the key next to CAPS LOCK!';
    ///     } else {
    ///       _message = 'Wrong key.';
    ///     }
    ///   });
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   final TextTheme textTheme = Theme.of(context).textTheme;
    ///   return Container(
    ///     color: Colors.white,
    ///     alignment: Alignment.center,
    ///     child: DefaultTextStyle(
    ///       style: textTheme.headline4,
    ///       child: RawKeyboardListener(
    ///         focusNode: _focusNode,
    ///         onKey: _handleKeyEvent,
    ///         child: AnimatedBuilder(
    ///           animation: _focusNode,
    ///           builder: (BuildContext context, Widget child) {
    ///             if (!_focusNode.hasFocus) {
    ///               return GestureDetector(
    ///                 onTap: () {
    ///                   FocusScope.of(context).requestFocus(_focusNode);
    ///                 },
    ///                 child: Text('Tap to focus'),
    ///               );
    ///             }
    ///             return Text(_message ?? 'Press a key');
    ///           },
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RawKeyEvent], the keyboard event object received by widgets that listen
    ///    to keyboard events.
    ///  * [RawKeyboardListener], a widget used to listen to and supply handlers for
    ///    keyboard events.
    /// </Summary>
    public class PhysicalKeyboardKey : FlutterSDK.Services.Keyboardkey.KeyboardKey
    {
        /// <Summary>
        /// Creates a PhysicalKeyboardKey object with an optional debug name.
        ///
        /// The [usbHidUsage] must not be null.
        ///
        /// {@tool snippet}
        /// To save executable size, it is recommended that the [debugName] be null in
        /// release mode. You can do this using the [kReleaseMode] constant.
        ///
        /// ```dart
        /// const PhysicalKeyboardKey(0x0000ffff, debugName: kReleaseMode ? null : 'Special Key')
        /// ```
        /// {@end-tool}
        /// </Summary>
        public PhysicalKeyboardKey(int usbHidUsage, string debugName = default(string))
        : base()
        {
            this.UsbHidUsage = usbHidUsage;
            this.DebugName = debugName;
        }
        /// <Summary>
        /// The unique USB HID usage ID of this physical key on the keyboard.
        ///
        /// Due to the variations in platform APIs, this may not be the actual HID
        /// usage code from the hardware, but a value derived from available
        /// information on the platform.
        ///
        /// See <https://www.usb.org/sites/default/files/documents/hut1_12v2.pdf>
        /// for the HID usage values and their meanings.
        /// </Summary>
        public virtual int UsbHidUsage { get; set; }
        /// <Summary>
        /// The debug string to print for this keyboard key, which will be null in
        /// release mode.
        /// </Summary>
        public virtual string DebugName { get; set; }
        /// <Summary>
        /// Represents the location of the "None" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey None { get; set; }
        /// <Summary>
        /// Represents the location of the "Hyper" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Hyper { get; set; }
        /// <Summary>
        /// Represents the location of the "Super Key" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SuperKey { get; set; }
        /// <Summary>
        /// Represents the location of the "Fn Lock" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey FnLock { get; set; }
        /// <Summary>
        /// Represents the location of the "Suspend" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Suspend { get; set; }
        /// <Summary>
        /// Represents the location of the "Resume" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Resume { get; set; }
        /// <Summary>
        /// Represents the location of the "Turbo" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Turbo { get; set; }
        /// <Summary>
        /// Represents the location of the "Privacy Screen Toggle" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PrivacyScreenToggle { get; set; }
        /// <Summary>
        /// Represents the location of the "Sleep" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Sleep { get; set; }
        /// <Summary>
        /// Represents the location of the "Wake Up" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey WakeUp { get; set; }
        /// <Summary>
        /// Represents the location of the "Display Toggle Int Ext" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey DisplayToggleIntExt { get; set; }
        /// <Summary>
        /// Represents the location of the "Usb Reserved" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbReserved { get; set; }
        /// <Summary>
        /// Represents the location of the "Usb Error Roll Over" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbErrorRollOver { get; set; }
        /// <Summary>
        /// Represents the location of the "Usb Post Fail" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbPostFail { get; set; }
        /// <Summary>
        /// Represents the location of the "Usb Error Undefined" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbErrorUndefined { get; set; }
        /// <Summary>
        /// Represents the location of the "Key A" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyA { get; set; }
        /// <Summary>
        /// Represents the location of the "Key B" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyB { get; set; }
        /// <Summary>
        /// Represents the location of the "Key C" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyC { get; set; }
        /// <Summary>
        /// Represents the location of the "Key D" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyD { get; set; }
        /// <Summary>
        /// Represents the location of the "Key E" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyE { get; set; }
        /// <Summary>
        /// Represents the location of the "Key F" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyF { get; set; }
        /// <Summary>
        /// Represents the location of the "Key G" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyG { get; set; }
        /// <Summary>
        /// Represents the location of the "Key H" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyH { get; set; }
        /// <Summary>
        /// Represents the location of the "Key I" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyI { get; set; }
        /// <Summary>
        /// Represents the location of the "Key J" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyJ { get; set; }
        /// <Summary>
        /// Represents the location of the "Key K" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyK { get; set; }
        /// <Summary>
        /// Represents the location of the "Key L" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyL { get; set; }
        /// <Summary>
        /// Represents the location of the "Key M" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyM { get; set; }
        /// <Summary>
        /// Represents the location of the "Key N" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyN { get; set; }
        /// <Summary>
        /// Represents the location of the "Key O" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyO { get; set; }
        /// <Summary>
        /// Represents the location of the "Key P" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyP { get; set; }
        /// <Summary>
        /// Represents the location of the "Key Q" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyQ { get; set; }
        /// <Summary>
        /// Represents the location of the "Key R" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyR { get; set; }
        /// <Summary>
        /// Represents the location of the "Key S" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyS { get; set; }
        /// <Summary>
        /// Represents the location of the "Key T" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyT { get; set; }
        /// <Summary>
        /// Represents the location of the "Key U" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyU { get; set; }
        /// <Summary>
        /// Represents the location of the "Key V" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyV { get; set; }
        /// <Summary>
        /// Represents the location of the "Key W" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyW { get; set; }
        /// <Summary>
        /// Represents the location of the "Key X" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyX { get; set; }
        /// <Summary>
        /// Represents the location of the "Key Y" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyY { get; set; }
        /// <Summary>
        /// Represents the location of the "Key Z" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyZ { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 1" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 2" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 3" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit3 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 4" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit4 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 5" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit5 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 6" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit6 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 7" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit7 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 8" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit8 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 9" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit9 { get; set; }
        /// <Summary>
        /// Represents the location of the "Digit 0" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit0 { get; set; }
        /// <Summary>
        /// Represents the location of the "Enter" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Enter { get; set; }
        /// <Summary>
        /// Represents the location of the "Escape" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Escape { get; set; }
        /// <Summary>
        /// Represents the location of the "Backspace" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Backspace { get; set; }
        /// <Summary>
        /// Represents the location of the "Tab" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Tab { get; set; }
        /// <Summary>
        /// Represents the location of the "Space" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Space { get; set; }
        /// <Summary>
        /// Represents the location of the "Minus" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Minus { get; set; }
        /// <Summary>
        /// Represents the location of the "Equal" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Equal { get; set; }
        /// <Summary>
        /// Represents the location of the "Bracket Left" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BracketLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Bracket Right" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BracketRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Backslash" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Backslash { get; set; }
        /// <Summary>
        /// Represents the location of the "Semicolon" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Semicolon { get; set; }
        /// <Summary>
        /// Represents the location of the "Quote" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Quote { get; set; }
        /// <Summary>
        /// Represents the location of the "Backquote" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Backquote { get; set; }
        /// <Summary>
        /// Represents the location of the "Comma" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Comma { get; set; }
        /// <Summary>
        /// Represents the location of the "Period" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Period { get; set; }
        /// <Summary>
        /// Represents the location of the "Slash" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Slash { get; set; }
        /// <Summary>
        /// Represents the location of the "Caps Lock" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey CapsLock { get; set; }
        /// <Summary>
        /// Represents the location of the "F1" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F1 { get; set; }
        /// <Summary>
        /// Represents the location of the "F2" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F2 { get; set; }
        /// <Summary>
        /// Represents the location of the "F3" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F3 { get; set; }
        /// <Summary>
        /// Represents the location of the "F4" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F4 { get; set; }
        /// <Summary>
        /// Represents the location of the "F5" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F5 { get; set; }
        /// <Summary>
        /// Represents the location of the "F6" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F6 { get; set; }
        /// <Summary>
        /// Represents the location of the "F7" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F7 { get; set; }
        /// <Summary>
        /// Represents the location of the "F8" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F8 { get; set; }
        /// <Summary>
        /// Represents the location of the "F9" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F9 { get; set; }
        /// <Summary>
        /// Represents the location of the "F10" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F10 { get; set; }
        /// <Summary>
        /// Represents the location of the "F11" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F11 { get; set; }
        /// <Summary>
        /// Represents the location of the "F12" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F12 { get; set; }
        /// <Summary>
        /// Represents the location of the "Print Screen" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PrintScreen { get; set; }
        /// <Summary>
        /// Represents the location of the "Scroll Lock" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ScrollLock { get; set; }
        /// <Summary>
        /// Represents the location of the "Pause" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Pause { get; set; }
        /// <Summary>
        /// Represents the location of the "Insert" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Insert { get; set; }
        /// <Summary>
        /// Represents the location of the "Home" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Home { get; set; }
        /// <Summary>
        /// Represents the location of the "Page Up" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PageUp { get; set; }
        /// <Summary>
        /// Represents the location of the "Delete" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Delete { get; set; }
        /// <Summary>
        /// Represents the location of the "End" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey End { get; set; }
        /// <Summary>
        /// Represents the location of the "Page Down" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PageDown { get; set; }
        /// <Summary>
        /// Represents the location of the "Arrow Right" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Arrow Left" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Arrow Down" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowDown { get; set; }
        /// <Summary>
        /// Represents the location of the "Arrow Up" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowUp { get; set; }
        /// <Summary>
        /// Represents the location of the "Num Lock" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumLock { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Divide" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadDivide { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Multiply" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMultiply { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Subtract" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadSubtract { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Add" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadAdd { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Enter" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadEnter { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 1" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 2" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 3" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad3 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 4" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad4 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 5" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad5 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 6" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad6 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 7" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad7 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 8" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad8 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 9" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad9 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad 0" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad0 { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Decimal" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadDecimal { get; set; }
        /// <Summary>
        /// Represents the location of the "Intl Backslash" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey IntlBackslash { get; set; }
        /// <Summary>
        /// Represents the location of the "Context Menu" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ContextMenu { get; set; }
        /// <Summary>
        /// Represents the location of the "Power" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Power { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Equal" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadEqual { get; set; }
        /// <Summary>
        /// Represents the location of the "F13" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F13 { get; set; }
        /// <Summary>
        /// Represents the location of the "F14" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F14 { get; set; }
        /// <Summary>
        /// Represents the location of the "F15" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F15 { get; set; }
        /// <Summary>
        /// Represents the location of the "F16" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F16 { get; set; }
        /// <Summary>
        /// Represents the location of the "F17" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F17 { get; set; }
        /// <Summary>
        /// Represents the location of the "F18" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F18 { get; set; }
        /// <Summary>
        /// Represents the location of the "F19" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F19 { get; set; }
        /// <Summary>
        /// Represents the location of the "F20" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F20 { get; set; }
        /// <Summary>
        /// Represents the location of the "F21" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F21 { get; set; }
        /// <Summary>
        /// Represents the location of the "F22" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F22 { get; set; }
        /// <Summary>
        /// Represents the location of the "F23" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F23 { get; set; }
        /// <Summary>
        /// Represents the location of the "F24" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F24 { get; set; }
        /// <Summary>
        /// Represents the location of the "Open" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Open { get; set; }
        /// <Summary>
        /// Represents the location of the "Help" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Help { get; set; }
        /// <Summary>
        /// Represents the location of the "Select" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Select { get; set; }
        /// <Summary>
        /// Represents the location of the "Again" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Again { get; set; }
        /// <Summary>
        /// Represents the location of the "Undo" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Undo { get; set; }
        /// <Summary>
        /// Represents the location of the "Cut" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Cut { get; set; }
        /// <Summary>
        /// Represents the location of the "Copy" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Copy { get; set; }
        /// <Summary>
        /// Represents the location of the "Paste" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Paste { get; set; }
        /// <Summary>
        /// Represents the location of the "Find" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Find { get; set; }
        /// <Summary>
        /// Represents the location of the "Audio Volume Mute" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AudioVolumeMute { get; set; }
        /// <Summary>
        /// Represents the location of the "Audio Volume Up" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AudioVolumeUp { get; set; }
        /// <Summary>
        /// Represents the location of the "Audio Volume Down" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AudioVolumeDown { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Comma" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadComma { get; set; }
        /// <Summary>
        /// Represents the location of the "Intl Ro" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey IntlRo { get; set; }
        /// <Summary>
        /// Represents the location of the "Kana Mode" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KanaMode { get; set; }
        /// <Summary>
        /// Represents the location of the "Intl Yen" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey IntlYen { get; set; }
        /// <Summary>
        /// Represents the location of the "Convert" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Convert { get; set; }
        /// <Summary>
        /// Represents the location of the "Non Convert" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NonConvert { get; set; }
        /// <Summary>
        /// Represents the location of the "Lang 1" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Lang 2" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Lang 3" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang3 { get; set; }
        /// <Summary>
        /// Represents the location of the "Lang 4" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang4 { get; set; }
        /// <Summary>
        /// Represents the location of the "Lang 5" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang5 { get; set; }
        /// <Summary>
        /// Represents the location of the "Abort" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Abort { get; set; }
        /// <Summary>
        /// Represents the location of the "Props" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Props { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Paren Left" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadParenLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Paren Right" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadParenRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Backspace" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadBackspace { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Memory Store" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryStore { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Memory Recall" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryRecall { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Memory Clear" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryClear { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Memory Add" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryAdd { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Memory Subtract" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemorySubtract { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Sign Change" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadSignChange { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Clear" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadClear { get; set; }
        /// <Summary>
        /// Represents the location of the "Numpad Clear Entry" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadClearEntry { get; set; }
        /// <Summary>
        /// Represents the location of the "Control Left" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ControlLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Shift Left" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ShiftLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Alt Left" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AltLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Meta Left" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MetaLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Control Right" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ControlRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Shift Right" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ShiftRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Alt Right" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AltRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Meta Right" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MetaRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Info" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Info { get; set; }
        /// <Summary>
        /// Represents the location of the "Closed Caption Toggle" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ClosedCaptionToggle { get; set; }
        /// <Summary>
        /// Represents the location of the "Brightness Up" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessUp { get; set; }
        /// <Summary>
        /// Represents the location of the "Brightness Down" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessDown { get; set; }
        /// <Summary>
        /// Represents the location of the "Brightness Toggle" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessToggle { get; set; }
        /// <Summary>
        /// Represents the location of the "Brightness Minimum" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessMinimum { get; set; }
        /// <Summary>
        /// Represents the location of the "Brightness Maximum" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessMaximum { get; set; }
        /// <Summary>
        /// Represents the location of the "Brightness Auto" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessAuto { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Last" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaLast { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Phone" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchPhone { get; set; }
        /// <Summary>
        /// Represents the location of the "Program Guide" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ProgramGuide { get; set; }
        /// <Summary>
        /// Represents the location of the "Exit" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Exit { get; set; }
        /// <Summary>
        /// Represents the location of the "Channel Up" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ChannelUp { get; set; }
        /// <Summary>
        /// Represents the location of the "Channel Down" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ChannelDown { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Play" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaPlay { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Pause" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaPause { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Record" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaRecord { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Fast Forward" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaFastForward { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Rewind" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaRewind { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Track Next" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaTrackNext { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Track Previous" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaTrackPrevious { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Stop" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaStop { get; set; }
        /// <Summary>
        /// Represents the location of the "Eject" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Eject { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Play Pause" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaPlayPause { get; set; }
        /// <Summary>
        /// Represents the location of the "Speech Input Toggle" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SpeechInputToggle { get; set; }
        /// <Summary>
        /// Represents the location of the "Bass Boost" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BassBoost { get; set; }
        /// <Summary>
        /// Represents the location of the "Media Select" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaSelect { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Word Processor" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchWordProcessor { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Spreadsheet" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchSpreadsheet { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Mail" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchMail { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Contacts" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchContacts { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Calendar" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchCalendar { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch App2" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchApp2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch App1" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchApp1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Internet Browser" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchInternetBrowser { get; set; }
        /// <Summary>
        /// Represents the location of the "Log Off" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LogOff { get; set; }
        /// <Summary>
        /// Represents the location of the "Lock Screen" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LockScreen { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Control Panel" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchControlPanel { get; set; }
        /// <Summary>
        /// Represents the location of the "Select Task" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SelectTask { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Documents" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchDocuments { get; set; }
        /// <Summary>
        /// Represents the location of the "Spell Check" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SpellCheck { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Keyboard Layout" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchKeyboardLayout { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Screen Saver" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchScreenSaver { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Assistant" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchAssistant { get; set; }
        /// <Summary>
        /// Represents the location of the "Launch Audio Browser" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchAudioBrowser { get; set; }
        /// <Summary>
        /// Represents the location of the "New Key" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NewKey { get; set; }
        /// <Summary>
        /// Represents the location of the "Close" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Close { get; set; }
        /// <Summary>
        /// Represents the location of the "Save" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Save { get; set; }
        /// <Summary>
        /// Represents the location of the "Print" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Print { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Search" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserSearch { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Home" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserHome { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Back" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserBack { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Forward" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserForward { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Stop" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserStop { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Refresh" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserRefresh { get; set; }
        /// <Summary>
        /// Represents the location of the "Browser Favorites" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserFavorites { get; set; }
        /// <Summary>
        /// Represents the location of the "Zoom In" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ZoomIn { get; set; }
        /// <Summary>
        /// Represents the location of the "Zoom Out" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ZoomOut { get; set; }
        /// <Summary>
        /// Represents the location of the "Zoom Toggle" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ZoomToggle { get; set; }
        /// <Summary>
        /// Represents the location of the "Redo" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Redo { get; set; }
        /// <Summary>
        /// Represents the location of the "Mail Reply" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MailReply { get; set; }
        /// <Summary>
        /// Represents the location of the "Mail Forward" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MailForward { get; set; }
        /// <Summary>
        /// Represents the location of the "Mail Send" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MailSend { get; set; }
        /// <Summary>
        /// Represents the location of the "Keyboard Layout Select" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyboardLayoutSelect { get; set; }
        /// <Summary>
        /// Represents the location of the "Show All Windows" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ShowAllWindows { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 1" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 2" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 3" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton3 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 4" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton4 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 5" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton5 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 6" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton6 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 7" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton7 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 8" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton8 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 9" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton9 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 10" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton10 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 11" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton11 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 12" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton12 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 13" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton13 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 14" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton14 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 15" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton15 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button 16" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton16 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button A" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonA { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button B" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonB { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button C" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonC { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Left 1" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonLeft1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Left 2" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonLeft2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Mode" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonMode { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Right 1" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonRight1 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Right 2" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonRight2 { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Select" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonSelect { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Start" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonStart { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Thumb Left" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonThumbLeft { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Thumb Right" key on a
        /// generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonThumbRight { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button X" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonX { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Y" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonY { get; set; }
        /// <Summary>
        /// Represents the location of the "Game Button Z" key on a generalized
        /// keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonZ { get; set; }
        /// <Summary>
        /// Represents the location of the "Fn" key on a generalized keyboard.
        ///
        /// See the function [RawKeyEvent.physicalKey] for more information.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Fn { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey> _KnownPhysicalKeys { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Finds a known [PhysicalKeyboardKey] that matches the given USB HID usage
        /// code.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey FindKeyByCode(int usageCode) => _KnownPhysicalKeys[usageCode];



        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is PhysicalKeyboardKey && other.UsbHidUsage == UsbHidUsage;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("usbHidUsage", $"'0x{UsbHidUsage.ToRadixString(16).PadLeft(8, '0')}'", showName: true));
            properties.Add(new StringProperty("debugName", DebugName, showName: true, defaultValue: null));
        }



    }

}
