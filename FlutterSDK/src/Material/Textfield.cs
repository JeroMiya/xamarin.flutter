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
namespace FlutterSDK.Material.Textfield
{
    public delegate FlutterSDK.Widgets.Framework.Widget InputCounterWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, int currentLength = default(int), int maxLength = default(int), bool isFocused = default(bool));
    internal static class TextfieldDefaultClass
    {
    }

    public class _TextFieldSelectionGestureDetectorBuilder : FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilder
    {
        #region constructors
        public _TextFieldSelectionGestureDetectorBuilder(FlutterSDK.Material.Textfield._TextFieldState state = default(FlutterSDK.Material.Textfield._TextFieldState))
        : base(@delegate: state)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Material.Textfield._TextFieldState _State { get; set; }
        #endregion

        #region methods

        public new void OnForcePressStart(FlutterSDK.Gestures.Forcepress.ForcePressDetails details) { throw new NotImplementedException(); }


        public new void OnForcePressEnd(FlutterSDK.Gestures.Forcepress.ForcePressDetails details) { throw new NotImplementedException(); }


        public new void OnSingleLongTapMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details) { throw new NotImplementedException(); }


        public new void OnSingleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) { throw new NotImplementedException(); }


        public new void OnSingleLongTapStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A material design text field.
    ///
    /// A text field lets the user enter text, either with hardware keyboard or with
    /// an onscreen keyboard.
    ///
    /// The text field calls the [onChanged] callback whenever the user changes the
    /// text in the field. If the user indicates that they are done typing in the
    /// field (e.g., by pressing a button on the soft keyboard), the text field
    /// calls the [onSubmitted] callback.
    ///
    /// To control the text that is displayed in the text field, use the
    /// [controller]. For example, to set the initial value of the text field, use
    /// a [controller] that already contains some text. The [controller] can also
    /// control the selection and composing region (and to observe changes to the
    /// text, selection, and composing region).
    ///
    /// By default, a text field has a [decoration] that draws a divider below the
    /// text field. You can use the [decoration] property to control the decoration,
    /// for example by adding a label or an icon. If you set the [decoration]
    /// property to null, the decoration will be removed entirely, including the
    /// extra padding introduced by the decoration to save space for the labels.
    ///
    /// If [decoration] is non-null (which is the default), the text field requires
    /// one of its ancestors to be a [Material] widget.
    ///
    /// To integrate the [TextField] into a [Form] with other [FormField] widgets,
    /// consider using [TextFormField].
    ///
    /// Remember to [dispose] of the [TextEditingController] when it is no longer needed.
    /// This will ensure we discard any resources used by the object.
    ///
    /// {@tool snippet}
    /// This example shows how to create a [TextField] that will obscure input. The
    /// [InputDecoration] surrounds the field in a border using [OutlineInputBorder]
    /// and adds a label.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/text_field.png)
    ///
    /// ```dart
    /// TextField(
    ///   obscureText: true,
    ///   decoration: InputDecoration(
    ///     border: OutlineInputBorder(),
    ///     labelText: 'Password',
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Reading values
    ///
    /// A common way to read a value from a TextField is to use the [onSubmitted]
    /// callback. This callback is applied to the text field's current value when
    /// the user finishes editing.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    ///
    /// This sample shows how to get a value from a TextField via the [onSubmitted]
    /// callback.
    ///
    /// ```dart
    /// TextEditingController _controller;
    ///
    /// void initState() {
    ///   super.initState();
    ///   _controller = TextEditingController();
    /// }
    ///
    /// void dispose() {
    ///   _controller.dispose();
    ///   super.dispose();
    /// }
    ///
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Center(
    ///       child: TextField(
    ///         controller: _controller,
    ///         onSubmitted: (String value) async {
    ///           await showDialog<void>(
    ///             context: context,
    ///             builder: (BuildContext context) {
    ///               return AlertDialog(
    ///                 title: const Text('Thanks!'),
    ///                 content: Text ('You typed "$value".'),
    ///                 actions: <Widget>[
    ///                   FlatButton(
    ///                     onPressed: () { Navigator.pop(context); },
    ///                     child: const Text('OK'),
    ///                   ),
    ///                 ],
    ///               );
    ///             },
    ///           );
    ///         },
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// For most applications the [onSubmitted] callback will be sufficient for
    /// reacting to user input.
    ///
    /// The [onEditingComplete] callback also runs when the user finishes editing.
    /// It's different from [onSubmitted] because it has a default value which
    /// updates the text controller and yields the keyboard focus. Applications that
    /// require different behavior can override the default [onEditingComplete]
    /// callback.
    ///
    /// Keep in mind you can also always read the current string from a TextField's
    /// [TextEditingController] using [TextEditingController.text].
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/components/text-fields.html>
    ///  * [TextFormField], which integrates with the [Form] widget.
    ///  * [InputDecorator], which shows the labels and other visual elements that
    ///    surround the actual text editing widget.
    ///  * [EditableText], which is the raw text editing control at the heart of a
    ///    [TextField]. The [EditableText] widget is rarely used directly unless
    ///    you are implementing an entirely different design language, such as
    ///    Cupertino.
    ///  * Learn how to use a [TextEditingController] in one of our
    ///    [cookbook recipe](https://flutter.dev/docs/cookbook/forms/text-field-changes#2-use-a-texteditingcontroller)s.
    /// </Summary>
    public class TextField : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public TextField(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Editabletext.TextEditingController controller = default(FlutterSDK.Widgets.Editabletext.TextEditingController), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Material.Inputdecorator.InputDecoration decoration = default(FlutterSDK.Material.Inputdecorator.InputDecoration), FlutterSDK.Services.Textinput.TextInputType keyboardType = default(FlutterSDK.Services.Textinput.TextInputType), FlutterSDK.Services.Textinput.TextInputAction textInputAction = default(FlutterSDK.Services.Textinput.TextInputAction), FlutterSDK.Services.Textinput.TextCapitalization textCapitalization = default(FlutterSDK.Services.Textinput.TextCapitalization), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), TextDirection textDirection = default(TextDirection), bool readOnly = false, FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions), bool showCursor = default(bool), bool autofocus = false, bool obscureText = false, bool autocorrect = true, FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = true, int maxLines = 1, int minLines = default(int), bool expands = false, int maxLength = default(int), bool maxLengthEnforced = true, FlutterSDK.Foundation.Basictypes.ValueChanged<string> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), VoidCallback onEditingComplete = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onSubmitted = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), List<FlutterSDK.Services.Textformatter.TextInputFormatter> inputFormatters = default(List<FlutterSDK.Services.Textformatter.TextInputFormatter>), bool enabled = default(bool), double cursorWidth = 2.0, Radius cursorRadius = default(Radius), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), Brightness keyboardAppearance = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets scrollPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Material.Textfield.InputCounterWidgetBuilder buildCounter = default(FlutterSDK.Material.Textfield.InputCounterWidgetBuilder), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
        : base(key: key)
        {
            this.Controller = controller;
            this.FocusNode = focusNode;
            this.Decoration = decoration;
            this.TextInputAction = textInputAction;
            this.TextCapitalization = textCapitalization;
            this.Style = style;
            this.StrutStyle = strutStyle;
            this.TextAlign = textAlign;
            this.TextAlignVertical = textAlignVertical;
            this.TextDirection = textDirection;
            this.ReadOnly = readOnly;
            this.ShowCursor = showCursor;
            this.Autofocus = autofocus;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.EnableSuggestions = enableSuggestions;
            this.MaxLines = maxLines;
            this.MinLines = minLines;
            this.Expands = expands;
            this.MaxLength = maxLength;
            this.MaxLengthEnforced = maxLengthEnforced;
            this.OnChanged = onChanged;
            this.OnEditingComplete = onEditingComplete;
            this.OnSubmitted = onSubmitted;
            this.InputFormatters = inputFormatters;
            this.Enabled = enabled;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorColor = cursorColor;
            this.SelectionHeightStyle = selectionHeightStyle;
            this.SelectionWidthStyle = selectionWidthStyle;
            this.KeyboardAppearance = keyboardAppearance;
            this.ScrollPadding = scrollPadding;
            this.DragStartBehavior = dragStartBehavior;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.OnTap = onTap;
            this.BuildCounter = buildCounter;
            this.ScrollController = scrollController;
            this.ScrollPhysics = scrollPhysics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Editabletext.TextEditingController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextCapitalization TextCapitalization { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual bool ObscureText { get; set; }
        public virtual bool Autocorrect { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        public virtual bool EnableSuggestions { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual int MinLines { get; set; }
        public virtual bool Expands { get; set; }
        public virtual bool ReadOnly { get; set; }
        public virtual FlutterSDK.Widgets.Editabletext.ToolbarOptions ToolbarOptions { get; set; }
        public virtual bool ShowCursor { get; set; }
        public virtual int NoMaxLength { get; set; }
        public virtual int MaxLength { get; set; }
        public virtual bool MaxLengthEnforced { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnChanged { get; set; }
        public virtual VoidCallback OnEditingComplete { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnSubmitted { get; set; }
        public virtual List<FlutterSDK.Services.Textformatter.TextInputFormatter> InputFormatters { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual double CursorWidth { get; set; }
        public virtual Radius CursorRadius { get; set; }
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        public virtual Brightness KeyboardAppearance { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ScrollPadding { get; set; }
        public virtual bool EnableInteractiveSelection { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        public virtual FlutterSDK.Material.Textfield.InputCounterWidgetBuilder BuildCounter { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ScrollPhysics { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Material.Textfield._TextFieldState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TextFieldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Textfield.TextField>, ITextSelectionGestureDetectorBuilderDelegate
    {
        #region constructors
        public _TextFieldState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual bool _IsHovering { get; set; }
        internal virtual bool _ShowSelectionHandles { get; set; }
        internal virtual FlutterSDK.Material.Textfield._TextFieldSelectionGestureDetectorBuilder _SelectionGestureDetectorBuilder { get; set; }
        public new bool ForcePressEnabled { get; set; }
        public new FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Editabletext.EditableTextState> EditableTextKey { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _EffectiveController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _EffectiveFocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool NeedsCounter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual int _CurrentLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Editabletext.EditableTextState _EditableText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Material.Inputdecorator.InputDecoration _GetEffectiveDecoration() { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Textfield.TextField oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _RequestKeyboard() { throw new NotImplementedException(); }


        private bool _ShouldShowSelectionHandles(FlutterSDK.Rendering.Editable.SelectionChangedCause cause) { throw new NotImplementedException(); }


        private void _HandleSelectionChanged(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.SelectionChangedCause cause) { throw new NotImplementedException(); }


        /// <Summary>
        /// Toggle the toolbar when a selection handle is tapped.
        /// </Summary>
        private void _HandleSelectionHandleTapped() { throw new NotImplementedException(); }


        private void _HandleHover(bool hovering) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }

}
