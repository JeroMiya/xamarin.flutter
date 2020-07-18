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
namespace FlutterSDK.Widgets.Editabletext
{
    public delegate void SelectionChangedCallback(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.SelectionChangedCause cause);
    internal static class EditabletextDefaultClass
    {
        public static TimeSpan _KCursorBlinkHalfPeriod = default(TimeSpan);
        public static TimeSpan _KCursorBlinkWaitForStart = default(TimeSpan);
        public static int _KObscureShowLatestCharCursorTicks = default(int);
    }

    /// <Summary>
    /// A controller for an editable text field.
    ///
    /// Whenever the user modifies a text field with an associated
    /// [TextEditingController], the text field updates [value] and the controller
    /// notifies its listeners. Listeners can then read the [text] and [selection]
    /// properties to learn what the user has typed or how the selection has been
    /// updated.
    ///
    /// Similarly, if you modify the [text] or [selection] properties, the text
    /// field will be notified and will update itself appropriately.
    ///
    /// A [TextEditingController] can also be used to provide an initial value for a
    /// text field. If you build a text field with a controller that already has
    /// [text], the text field will use that text as its initial value.
    ///
    /// The [text] or [selection] properties can be set from within a listener
    /// added to this controller. If both properties need to be changed then the
    /// controller's [value] should be set instead.
    ///
    /// Remember to [dispose] of the [TextEditingController] when it is no longer needed.
    /// This will ensure we discard any resources used by the object.
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example creates a [TextField] with a [TextEditingController] whose
    /// change listener forces the entered text to be lower case and keeps the
    /// cursor at the end of the input.
    ///
    /// ```dart
    /// final _controller = TextEditingController();
    ///
    /// void initState() {
    ///   super.initState();
    ///   _controller.addListener(() {
    ///     final text = _controller.text.toLowerCase();
    ///     _controller.value = _controller.value.copyWith(
    ///       text: text,
    ///       selection: TextSelection(baseOffset: text.length, extentOffset: text.length),
    ///       composing: TextRange.empty,
    ///     );
    ///   });
    /// }
    ///
    /// void dispose() {
    ///   _controller.dispose();
    ///   super.dispose();
    /// }
    ///
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Container(
    ///      alignment: Alignment.center,
    ///       padding: const EdgeInsets.all(6),
    ///       child: TextFormField(
    ///         controller: _controller,
    ///         decoration: InputDecoration(border: OutlineInputBorder()),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [TextField], which is a Material Design text field that can be controlled
    ///    with a [TextEditingController].
    ///  * [EditableText], which is a raw region of editable text that can be
    ///    controlled with a [TextEditingController].
    ///  * Learn how to use a [TextEditingController] in one of our [cookbook recipe]s.(https://flutter.dev/docs/cookbook/forms/text-field-changes#2-use-a-texteditingcontroller)
    /// </Summary>
    public class TextEditingController : FlutterSDK.Foundation.Changenotifier.ValueNotifier<FlutterSDK.Services.Textinput.TextEditingValue>
    {
        #region constructors
        public TextEditingController(string text = default(string))
        : base(text == null ? TextinputDefaultClass.TextEditingValue.Empty : new TextEditingValue(text: text))
        {

        }
        public static TextEditingController FromValue(FlutterSDK.Services.Textinput.TextEditingValue value)
        {
            var instance = new TextEditingController(value ?? TextinputDefaultClass.TextEditingValue.Empty);
        }
        #endregion

        #region fields
        public virtual string Text { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textediting.TextSelection Selection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Builds [TextSpan] from current editing value.
        ///
        /// By default makes text in composing range appear as underlined.
        /// Descendants can override this method to customize appearance of text.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textspan.TextSpan BuildTextSpan(FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), bool withComposing = default(bool))
        {
            if (!Value.Composing.IsValid || !withComposing)
            {
                return new TextSpan(style: style, text: Text);
            }

            TextStyle composingStyle = style.Merge(new TextStyle(decoration: Dart:uiDefaultClass.TextDecoration.Underline));
            return new TextSpan(style: style, children: new List<TextSpan>() { new TextSpan(text: Value.Composing.TextBefore(Value.Text)), new TextSpan(style: composingStyle, text: Value.Composing.TextInside(Value.Text)), new TextSpan(text: Value.Composing.TextAfter(Value.Text)) });
        }




        /// <Summary>
        /// Set the [value] to empty.
        ///
        /// After calling this function, [text] will be the empty string and the
        /// selection will be invalid.
        ///
        /// Calling this will notify all the listeners of this [TextEditingController]
        /// that they need to update (it calls [notifyListeners]). For this reason,
        /// this method should only be called between frames, e.g. in response to user
        /// actions, not during the build, layout, or paint phases.
        /// </Summary>
        public virtual void Clear()
        {
            Value = TextinputDefaultClass.TextEditingValue.Empty;
        }




        /// <Summary>
        /// Set the composing region to an empty range.
        ///
        /// The composing region is the range of text that is still being composed.
        /// Calling this function indicates that the user is done composing that
        /// region.
        ///
        /// Calling this will notify all the listeners of this [TextEditingController]
        /// that they need to update (it calls [notifyListeners]). For this reason,
        /// this method should only be called between frames, e.g. in response to user
        /// actions, not during the build, layout, or paint phases.
        /// </Summary>
        public virtual void ClearComposing()
        {
            Value = Value.CopyWith(composing: Dart:uiDefaultClass.TextRange.Empty);
        }




        /// <Summary>
        /// Check that the [selection] is inside of the bounds of [text].
        /// </Summary>
        public virtual bool IsSelectionWithinTextBounds(FlutterSDK.Services.Textediting.TextSelection selection)
        {
            return selection.Start <= Text.Length && selection.End <= Text.Length;
        }



        #endregion
    }


    /// <Summary>
    /// Toolbar configuration for [EditableText].
    ///
    /// Toolbar is a context menu that will show up when user right click or long
    /// press the [EditableText]. It includes several options: cut, copy, paste,
    /// and select all.
    ///
    /// [EditableText] and its derived widgets have their own default [ToolbarOptions].
    /// Create a custom [ToolbarOptions] if you want explicit control over the toolbar
    /// option.
    /// </Summary>
    public class ToolbarOptions
    {
        #region constructors
        public ToolbarOptions(bool copy = false, bool cut = false, bool paste = false, bool selectAll = false)
        : base()
        {
            this.Copy = copy;
            this.Cut = cut;
            this.Paste = paste;
            this.SelectAll = selectAll;
        }
        #endregion

        #region fields
        public virtual bool Copy { get; set; }
        public virtual bool Cut { get; set; }
        public virtual bool Paste { get; set; }
        public virtual bool SelectAll { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A basic text input field.
    ///
    /// This widget interacts with the [TextInput] service to let the user edit the
    /// text it contains. It also provides scrolling, selection, and cursor
    /// movement. This widget does not provide any focus management (e.g.,
    /// tap-to-focus).
    ///
    /// ## Input Actions
    ///
    /// A [TextInputAction] can be provided to customize the appearance of the
    /// action button on the soft keyboard for Android and iOS. The default action
    /// is [TextInputAction.done].
    ///
    /// Many [TextInputAction]s are common between Android and iOS. However, if an
    /// [inputAction] is provided that is not supported by the current
    /// platform in debug mode, an error will be thrown when the corresponding
    /// EditableText receives focus. For example, providing iOS's "emergencyCall"
    /// action when running on an Android device will result in an error when in
    /// debug mode. In release mode, incompatible [TextInputAction]s are replaced
    /// either with "unspecified" on Android, or "default" on iOS. Appropriate
    /// [inputAction]s can be chosen by checking the current platform and then
    /// selecting the appropriate action.
    ///
    /// ## Lifecycle
    ///
    /// Upon completion of editing, like pressing the "done" button on the keyboard,
    /// two actions take place:
    ///
    ///   1st: Editing is finalized. The default behavior of this step includes
    ///   an invocation of [onChanged]. That default behavior can be overridden.
    ///   See [onEditingComplete] for details.
    ///
    ///   2nd: [onSubmitted] is invoked with the user's input value.
    ///
    /// [onSubmitted] can be used to manually move focus to another input widget
    /// when a user finishes with the currently focused input widget.
    ///
    /// Rather than using this widget directly, consider using [TextField], which
    /// is a full-featured, material-design text input field with placeholder text,
    /// labels, and [Form] integration.
    ///
    /// ## Gesture Events Handling
    ///
    /// This widget provides rudimentary, platform-agnostic gesture handling for
    /// user actions such as tapping, long-pressing and scrolling when
    /// [rendererIgnoresPointer] is false (false by default). To tightly conform
    /// to the platform behavior with respect to input gestures in text fields, use
    /// [TextField] or [CupertinoTextField]. For custom selection behavior, call
    /// methods such as [RenderEditable.selectPosition],
    /// [RenderEditable.selectWord], etc. programmatically.
    ///
    /// See also:
    ///
    ///  * [TextField], which is a full-featured, material-design text input field
    ///    with placeholder text, labels, and [Form] integration.
    /// </Summary>
    public class EditableText : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public EditableText(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Editabletext.TextEditingController controller = default(FlutterSDK.Widgets.Editabletext.TextEditingController), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool readOnly = false, bool obscureText = false, bool autocorrect = true, FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = true, FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundCursorColor = default(FlutterBinding.UI.Color), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), Locale locale = default(Locale), double textScaleFactor = default(double), int maxLines = 1, int minLines = default(int), bool expands = false, bool forceLine = true, FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), bool autofocus = false, bool showCursor = default(bool), bool showSelectionHandles = false, FlutterBinding.UI.Color selectionColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Textselection.TextSelectionControls selectionControls = default(FlutterSDK.Widgets.Textselection.TextSelectionControls), FlutterSDK.Services.Textinput.TextInputType keyboardType = default(FlutterSDK.Services.Textinput.TextInputType), FlutterSDK.Services.Textinput.TextInputAction textInputAction = default(FlutterSDK.Services.Textinput.TextInputAction), FlutterSDK.Services.Textinput.TextCapitalization textCapitalization = default(FlutterSDK.Services.Textinput.TextCapitalization), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), VoidCallback onEditingComplete = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onSubmitted = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), FlutterSDK.Widgets.Editabletext.SelectionChangedCallback onSelectionChanged = default(FlutterSDK.Widgets.Editabletext.SelectionChangedCallback), VoidCallback onSelectionHandleTapped = default(VoidCallback), List<FlutterSDK.Services.Textformatter.TextInputFormatter> inputFormatters = default(List<FlutterSDK.Services.Textformatter.TextInputFormatter>), bool rendererIgnoresPointer = false, double cursorWidth = 2.0, Radius cursorRadius = default(Radius), bool cursorOpacityAnimates = false, FlutterBinding.UI.Offset cursorOffset = default(FlutterBinding.UI.Offset), bool paintCursorAboveText = false, BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsets scrollPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), Brightness keyboardAppearance = default(Brightness), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions))
        : base(key: key)
        {
            this.Controller = controller;
            this.FocusNode = focusNode;
            this.ReadOnly = readOnly;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.EnableSuggestions = enableSuggestions;
            this.Style = style;
            this.CursorColor = cursorColor;
            this.BackgroundCursorColor = backgroundCursorColor;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.Locale = locale;
            this.TextScaleFactor = textScaleFactor;
            this.MaxLines = maxLines;
            this.MinLines = minLines;
            this.Expands = expands;
            this.ForceLine = forceLine;
            this.TextWidthBasis = textWidthBasis;
            this.Autofocus = autofocus;
            this.ShowSelectionHandles = showSelectionHandles;
            this.SelectionColor = selectionColor;
            this.SelectionControls = selectionControls;
            this.TextInputAction = textInputAction;
            this.TextCapitalization = textCapitalization;
            this.OnChanged = onChanged;
            this.OnEditingComplete = onEditingComplete;
            this.OnSubmitted = onSubmitted;
            this.OnSelectionChanged = onSelectionChanged;
            this.OnSelectionHandleTapped = onSelectionHandleTapped;
            this.RendererIgnoresPointer = rendererIgnoresPointer;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorOpacityAnimates = cursorOpacityAnimates;
            this.CursorOffset = cursorOffset;
            this.PaintCursorAboveText = paintCursorAboveText;
            this.SelectionHeightStyle = selectionHeightStyle;
            this.SelectionWidthStyle = selectionWidthStyle;
            this.ScrollPadding = scrollPadding;
            this.KeyboardAppearance = keyboardAppearance;
            this.DragStartBehavior = dragStartBehavior;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.ScrollController = scrollController;
            this.ScrollPhysics = scrollPhysics;
            this.ToolbarOptions = toolbarOptions;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Editabletext.TextEditingController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool ObscureText { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual bool ReadOnly { get; set; }
        public virtual bool ForceLine { get; set; }
        public virtual FlutterSDK.Widgets.Editabletext.ToolbarOptions ToolbarOptions { get; set; }
        public virtual bool ShowSelectionHandles { get; set; }
        public virtual bool ShowCursor { get; set; }
        public virtual bool Autocorrect { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        public virtual bool EnableSuggestions { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        internal virtual FlutterSDK.Painting.Strutstyle.StrutStyle _StrutStyle { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextCapitalization TextCapitalization { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundCursorColor { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual int MinLines { get; set; }
        public virtual bool Expands { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual FlutterBinding.UI.Color SelectionColor { get; set; }
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionControls SelectionControls { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnChanged { get; set; }
        public virtual VoidCallback OnEditingComplete { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnSubmitted { get; set; }
        public virtual FlutterSDK.Widgets.Editabletext.SelectionChangedCallback OnSelectionChanged { get; set; }
        public virtual VoidCallback OnSelectionHandleTapped { get; set; }
        public virtual List<FlutterSDK.Services.Textformatter.TextInputFormatter> InputFormatters { get; set; }
        public virtual bool RendererIgnoresPointer { get; set; }
        public virtual double CursorWidth { get; set; }
        public virtual Radius CursorRadius { get; set; }
        public virtual bool CursorOpacityAnimates { get; set; }
        public virtual FlutterBinding.UI.Offset CursorOffset { get; set; }
        public virtual bool PaintCursorAboveText { get; set; }
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        public virtual Brightness KeyboardAppearance { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ScrollPadding { get; set; }
        public virtual bool EnableInteractiveSelection { get; set; }
        public virtual bool DebugDeterministicCursor { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ScrollPhysics { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Editabletext.EditableTextState CreateState() => new EditableTextState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<TextEditingController>("controller", Controller));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode));
            properties.Add(new DiagnosticsProperty<bool>("obscureText", ObscureText, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("autocorrect", Autocorrect, defaultValue: true));
            properties.Add(new EnumProperty<SmartDashesType>("smartDashesType", SmartDashesType, defaultValue: ObscureText ? SmartDashesType.Disabled : SmartDashesType.Enabled));
            properties.Add(new EnumProperty<SmartQuotesType>("smartQuotesType", SmartQuotesType, defaultValue: ObscureText ? SmartQuotesType.Disabled : SmartQuotesType.Enabled));
            properties.Add(new DiagnosticsProperty<bool>("enableSuggestions", EnableSuggestions, defaultValue: true));
            Style?.DebugFillProperties(properties);
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: null));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Locale>("locale", Locale, defaultValue: null));
            properties.Add(new DoubleProperty("textScaleFactor", TextScaleFactor, defaultValue: null));
            properties.Add(new IntProperty("maxLines", MaxLines, defaultValue: 1));
            properties.Add(new IntProperty("minLines", MinLines, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("expands", Expands, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("autofocus", Autofocus, defaultValue: false));
            properties.Add(new DiagnosticsProperty<TextInputType>("keyboardType", KeyboardType, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ScrollController>("scrollController", ScrollController, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ScrollPhysics>("scrollPhysics", ScrollPhysics, defaultValue: null));
        }



        #endregion
    }


    /// <Summary>
    /// State for a [EditableText].
    /// </Summary>
    public class EditableTextState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Editabletext.EditableText>, ITextInputClient, ITextSelectionDelegate, IAutomaticKeepAliveClientMixin<FlutterSDK.Widgets.Editabletext.EditableText>, IWidgetsBindingObserver, ITickerProviderStateMixin<FlutterSDK.Widgets.Editabletext.EditableText>
    {
        #region constructors
        public EditableTextState()
        { }
        #endregion

        #region fields
        internal virtual Timer _CursorTimer { get; set; }
        internal virtual bool _TargetCursorVisibility { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> _CursorVisibilityNotifier { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _EditableKey { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextInputConnection _TextInputConnection { get; set; }
        internal virtual FlutterSDK.Widgets.Textselection.TextSelectionOverlay _SelectionOverlay { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _ScrollController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _CursorBlinkOpacityController { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _ToolbarLayerLink { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _StartHandleLayerLink { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _EndHandleLayerLink { get; set; }
        internal virtual bool _DidAutoFocus { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusAttachment _FocusAttachment { get; set; }
        internal virtual TimeSpan _FadeDuration { get; set; }
        internal virtual TimeSpan _FloatingCursorResetTime { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FloatingCursorResetController { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _LastFormattedUnmodifiedTextEditingValue { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _LastFormattedValue { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _ReceivedRemoteTextEditingValue { get; set; }
        internal virtual FlutterBinding.UI.Rect _StartCaretRect { get; set; }
        internal virtual TextPosition _LastTextPosition { get; set; }
        internal virtual FlutterBinding.UI.Offset _PointOffsetOrigin { get; set; }
        internal virtual FlutterBinding.UI.Offset _LastBoundedOffset { get; set; }
        internal virtual bool _TextChangedSinceLastCaretUpdate { get; set; }
        internal virtual FlutterBinding.UI.Rect _CurrentCaretRect { get; set; }
        internal virtual TimeSpan _CaretAnimationDuration { get; set; }
        internal virtual FlutterSDK.Animation.Curves.Curve _CaretAnimationCurve { get; set; }
        internal virtual bool _ShowCaretOnScreenScheduled { get; set; }
        internal virtual double _LastBottomViewInset { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext._WhitespaceDirectionalityFormatter _WhitespaceFormatter { get; set; }
        internal virtual int _ObscureShowCharTicksPending { get; set; }
        internal virtual int _ObscureLatestCharIndex { get; set; }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Color _CursorColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CutEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CopyEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool PasteEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectAllEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue CurrentTextEditingValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Offset _FloatingCursorOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsMultiline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasInputConnection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CursorCurrentlyVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan CursorBlinkInterval { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionOverlay SelectionOverlay { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual TextDirection _TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Editable.RenderEditable RenderEditable { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue TextEditingValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _DevicePixelRatio { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            Widget.Controller.AddListener(_DidChangeTextEditingValue);
            _FocusAttachment = Widget.FocusNode.Attach(Context);
            Widget.FocusNode.AddListener(_HandleFocusChanged);
            _ScrollController = Widget.ScrollController ?? new ScrollController();
            _ScrollController.AddListener(() =>
            {
                _SelectionOverlay?.UpdateForScroll();
            }
            );
            _CursorBlinkOpacityController = new AnimationController(vsync: this, duration: _FadeDuration);
            _CursorBlinkOpacityController.AddListener(_OnCursorColorTick);
            _FloatingCursorResetController = new AnimationController(vsync: this);
            _FloatingCursorResetController.AddListener(_OnFloatingCursorResetTick);
            _CursorVisibilityNotifier.Value = Widget.ShowCursor;
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            if (!_DidAutoFocus && Widget.Autofocus)
            {
                _DidAutoFocus = true;
                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((_) =>
                {
                    if (Mounted)
                    {
                        FocusscopeDefaultClass.FocusScope.Of(Context).Autofocus(Widget.FocusNode);
                    }

                }
                );
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Editabletext.EditableText oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller != oldWidget.Controller)
            {
                oldWidget.Controller.RemoveListener(_DidChangeTextEditingValue);
                Widget.Controller.AddListener(_DidChangeTextEditingValue);
                _UpdateRemoteEditingValueIfNeeded();
            }

            if (Widget.Controller.Selection != oldWidget.Controller.Selection)
            {
                _SelectionOverlay?.Update(_Value);
            }

            _SelectionOverlay?.HandlesVisible = Widget.ShowSelectionHandles;
            if (Widget.FocusNode != oldWidget.FocusNode)
            {
                oldWidget.FocusNode.RemoveListener(_HandleFocusChanged);
                _FocusAttachment?.Detach();
                _FocusAttachment = Widget.FocusNode.Attach(Context);
                Widget.FocusNode.AddListener(_HandleFocusChanged);
                UpdateKeepAlive();
            }

            if (Widget.ReadOnly)
            {
                _CloseInputConnectionIfNeeded();
            }
            else
            {
                if (oldWidget.ReadOnly && _HasFocus) _OpenInputConnection();
            }

            if (Widget.Style != oldWidget.Style)
            {
                TextStyle style = Widget.Style;
                if (_TextInputConnection != null && _TextInputConnection.Attached)
                {
                    _TextInputConnection.SetStyle(fontFamily: style.FontFamily, fontSize: style.FontSize, fontWeight: style.FontWeight, textDirection: _TextDirection, textAlign: Widget.TextAlign);
                }

            }

        }




        public new void Dispose()
        {
            Widget.Controller.RemoveListener(_DidChangeTextEditingValue);
            _CursorBlinkOpacityController.RemoveListener(_OnCursorColorTick);
            _FloatingCursorResetController.RemoveListener(_OnFloatingCursorResetTick);
            _CloseInputConnectionIfNeeded();

            _StopCursorTimer();

            _SelectionOverlay?.Dispose();
            _SelectionOverlay = null;
            _FocusAttachment.Detach();
            Widget.FocusNode.RemoveListener(_HandleFocusChanged);
            base.Dispose();
        }




        public new void UpdateEditingValue(FlutterSDK.Services.Textinput.TextEditingValue value)
        {
            if (Widget.ReadOnly)
            {
                return;
            }

            _ReceivedRemoteTextEditingValue = value;
            if (value.Text != _Value.Text)
            {
                HideToolbar();
                _ShowCaretOnScreen();
                if (Widget.ObscureText && value.Text.Length == _Value.Text.Length + 1)
                {
                    _ObscureShowCharTicksPending = EditabletextDefaultClass._KObscureShowLatestCharCursorTicks;
                    _ObscureLatestCharIndex = _Value.Selection.BaseOffset;
                }

            }

            _FormatAndSetValue(value);
            _StopCursorTimer(resetCharTicks: false);
            _StartCursorTimer();
        }




        public new void PerformAction(FlutterSDK.Services.Textinput.TextInputAction action)
        {
            switch (action) { case TextInputAction.Newline: if (!_IsMultiline) _FinalizeEditing(true); break; case TextInputAction.Done: case TextInputAction.Go: case TextInputAction.Send: case TextInputAction.Search: _FinalizeEditing(true); break; default: _FinalizeEditing(false); break; }
        }




        public new void UpdateFloatingCursor(FlutterSDK.Services.Textinput.RawFloatingCursorPoint point)
        {
            switch (point.State)
            {
                case FloatingCursorDragState.Start:
                    if (_FloatingCursorResetController.IsAnimating)
                    {
                        _FloatingCursorResetController.Stop();
                        _OnFloatingCursorResetTick();
                    }
                    TextPosition currentTextPosition = new TextPosition(offset: RenderEditable.Selection.BaseOffset); _StartCaretRect = RenderEditable.GetLocalRectForCaret(currentTextPosition); RenderEditable.SetFloatingCursor(point.State, _StartCaretRect.Center - _FloatingCursorOffset, currentTextPosition); break;
                case FloatingCursorDragState.Update:
                    if (_PointOffsetOrigin != null)
                    {
                        Offset centeredPoint = point.Offset - _PointOffsetOrigin;
                        Offset rawCursorOffset = _StartCaretRect.Center + centeredPoint - _FloatingCursorOffset;
                        _LastBoundedOffset = RenderEditable.CalculateBoundedFloatingCursorOffset(rawCursorOffset);
                        _LastTextPosition = RenderEditable.GetPositionForPoint(RenderEditable.LocalToGlobal(_LastBoundedOffset + _FloatingCursorOffset));
                        RenderEditable.SetFloatingCursor(point.State, _LastBoundedOffset, _LastTextPosition);
                    }
                    else
                    {
                        _PointOffsetOrigin = point.Offset;
                    }
                    break;
                case FloatingCursorDragState.End:
                    if (_LastTextPosition != null && _LastBoundedOffset != null)
                    {
                        _FloatingCursorResetController.Value = 0.0;
                        _FloatingCursorResetController.AnimateTo(1.0, duration: _FloatingCursorResetTime, curve: CurvesDefaultClass.Curves.Decelerate);
                    }
                    break;
            }
        }




        private void _OnFloatingCursorResetTick()
        {
            Offset finalPosition = RenderEditable.GetLocalRectForCaret(_LastTextPosition).CenterLeft - _FloatingCursorOffset;
            if (_FloatingCursorResetController.IsCompleted)
            {
                RenderEditable.SetFloatingCursor(FloatingCursorDragState.End, finalPosition, _LastTextPosition);
                if (_LastTextPosition.Offset != RenderEditable.Selection.BaseOffset) _HandleSelectionChanged(TextSelection.Collapsed(offset: _LastTextPosition.Offset), RenderEditable, SelectionChangedCause.ForcePress);
                _StartCaretRect = null;
                _LastTextPosition = null;
                _PointOffsetOrigin = null;
                _LastBoundedOffset = null;
            }
            else
            {
                double lerpValue = _FloatingCursorResetController.Value;
                double lerpX = Ui.Dart:uiDefaultClass.LerpDouble(_LastBoundedOffset.Dx, finalPosition.Dx, lerpValue);
                double lerpY = Ui.Dart:uiDefaultClass.LerpDouble(_LastBoundedOffset.Dy, finalPosition.Dy, lerpValue);
                RenderEditable.SetFloatingCursor(FloatingCursorDragState.Update, new Offset(lerpX, lerpY), _LastTextPosition, resetLerpValue: lerpValue);
            }

        }




        private void _FinalizeEditing(bool shouldUnfocus)
        {
            if (Widget.OnEditingComplete != null)
            {
                Widget.OnEditingComplete();
            }
            else
            {
                Widget.Controller.ClearComposing();
                if (shouldUnfocus) Widget.FocusNode.Unfocus();
            }

            if (Widget.OnSubmitted != null) Widget.OnSubmitted(_Value.Text);
        }




        private void _UpdateRemoteEditingValueIfNeeded()
        {
            if (!_HasInputConnection) return;
            TextEditingValue localValue = _Value;
            if (localValue == _ReceivedRemoteTextEditingValue) return;
            _TextInputConnection.SetEditingState(localValue);
        }




        private double _GetScrollOffsetForCaret(FlutterBinding.UI.Rect caretRect)
        {
            double caretStart = default(double);
            double caretEnd = default(double);
            if (_IsMultiline)
            {
                double lineHeight = RenderEditable.PreferredLineHeight;
                double caretOffset = (lineHeight - caretRect.Height) / 2;
                caretStart = caretRect.Top - caretOffset;
                caretEnd = caretRect.Bottom + caretOffset;
            }
            else
            {
                caretStart = caretRect.Left;
                caretEnd = caretRect.Right;
            }

            double scrollOffset = _ScrollController.Offset;
            double viewportExtent = _ScrollController.Position.ViewportDimension;
            if (caretStart < 0.0)
            {
                scrollOffset += caretStart;
            }
            else if (caretEnd >= viewportExtent)
            {
                scrollOffset += caretEnd - viewportExtent;
            }

            if (_IsMultiline)
            {
                scrollOffset = scrollOffset.Clamp(0.0, RenderEditable.MaxScrollExtent) as double;
            }

            return scrollOffset;
        }




        private Rect _GetCaretRectAtScrollOffset(FlutterBinding.UI.Rect caretRect, double scrollOffset)
        {
            double offsetDiff = _ScrollController.Offset - scrollOffset;
            return _IsMultiline ? caretRect.Translate(0.0, offsetDiff) : caretRect.Translate(offsetDiff, 0.0);
        }




        private void _OpenInputConnection()
        {
            if (Widget.ReadOnly)
            {
                return;
            }

            if (!_HasInputConnection)
            {
                TextEditingValue localValue = _Value;
                _LastFormattedUnmodifiedTextEditingValue = localValue;
                _TextInputConnection = TextinputDefaultClass.TextInput.Attach(this, new TextInputConfiguration(inputType: Widget.KeyboardType, obscureText: Widget.ObscureText, autocorrect: Widget.Autocorrect, smartDashesType: Widget.SmartDashesType ?? (Widget.ObscureText ? SmartDashesType.Disabled : SmartDashesType.Enabled), smartQuotesType: Widget.SmartQuotesType ?? (Widget.ObscureText ? SmartQuotesType.Disabled : SmartQuotesType.Enabled), enableSuggestions: Widget.EnableSuggestions, inputAction: Widget.TextInputAction ?? (Widget.KeyboardType == TextinputDefaultClass.TextInputType.Multiline ? TextInputAction.Newline : TextInputAction.Done), textCapitalization: Widget.TextCapitalization, keyboardAppearance: Widget.KeyboardAppearance));
                _TextInputConnection.Show();
                _UpdateSizeAndTransform();
                TextStyle style = Widget.Style;
                ;
                _TextInputConnection.SetStyle(fontFamily: style.FontFamily, fontSize: style.FontSize, fontWeight: style.FontWeight, textDirection: _TextDirection, textAlign: Widget.TextAlign);
                _TextInputConnection.SetEditingState(localValue);
            }
            else
            {
                _TextInputConnection.Show();
            }

        }




        private void _CloseInputConnectionIfNeeded()
        {
            if (_HasInputConnection)
            {
                _TextInputConnection.Close();
                _TextInputConnection = null;
                _LastFormattedUnmodifiedTextEditingValue = null;
                _ReceivedRemoteTextEditingValue = null;
            }

        }




        private void _OpenOrCloseInputConnectionIfNeeded()
        {
            if (_HasFocus && Widget.FocusNode.ConsumeKeyboardToken())
            {
                _OpenInputConnection();
            }
            else if (!_HasFocus)
            {
                _CloseInputConnectionIfNeeded();
                Widget.Controller.ClearComposing();
            }

        }




        public new void ConnectionClosed()
        {
            if (_HasInputConnection)
            {
                _TextInputConnection.ConnectionClosedReceived();
                _TextInputConnection = null;
                _LastFormattedUnmodifiedTextEditingValue = null;
                _ReceivedRemoteTextEditingValue = null;
                _FinalizeEditing(true);
            }

        }




        /// <Summary>
        /// Express interest in interacting with the keyboard.
        ///
        /// If this control is already attached to the keyboard, this function will
        /// request that the keyboard become visible. Otherwise, this function will
        /// ask the focus system that it become focused. If successful in acquiring
        /// focus, the control will then attach to the keyboard and request that the
        /// keyboard become visible.
        /// </Summary>
        public virtual void RequestKeyboard()
        {
            if (_HasFocus)
            {
                _OpenInputConnection();
            }
            else
            {
                Widget.FocusNode.RequestFocus();
            }

        }




        private void _UpdateOrDisposeSelectionOverlayIfNeeded()
        {
            if (_SelectionOverlay != null)
            {
                if (_HasFocus)
                {
                    _SelectionOverlay.Update(_Value);
                }
                else
                {
                    _SelectionOverlay.Dispose();
                    _SelectionOverlay = null;
                }

            }

        }




        private void _HandleSelectionChanged(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.RenderEditable renderObject, FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
        {
            if (!Widget.Controller.IsSelectionWithinTextBounds(selection)) return;
            Widget.Controller.Selection = selection;
            RequestKeyboard();
            _SelectionOverlay?.Hide();
            _SelectionOverlay = null;
            if (Widget.SelectionControls != null)
            {
                _SelectionOverlay = new TextSelectionOverlay(context: Context, value: _Value, debugRequiredFor: Widget, toolbarLayerLink: _ToolbarLayerLink, startHandleLayerLink: _StartHandleLayerLink, endHandleLayerLink: _EndHandleLayerLink, renderObject: renderObject, selectionControls: Widget.SelectionControls, selectionDelegate: this, dragStartBehavior: Widget.DragStartBehavior, onSelectionHandleTapped: Widget.OnSelectionHandleTapped);
                _SelectionOverlay.HandlesVisible = Widget.ShowSelectionHandles;
                _SelectionOverlay.ShowHandles();
                if (Widget.OnSelectionChanged != null) Widget.OnSelectionChanged(selection, cause);
            }

        }




        private void _HandleCaretChanged(FlutterBinding.UI.Rect caretRect)
        {
            _CurrentCaretRect = caretRect;
            if (_TextChangedSinceLastCaretUpdate)
            {
                _TextChangedSinceLastCaretUpdate = false;
                _ShowCaretOnScreen();
            }

        }




        private void _ShowCaretOnScreen()
        {
            if (_ShowCaretOnScreenScheduled)
            {
                return;
            }

            _ShowCaretOnScreenScheduled = true;
            BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan _) =>
            {
                _ShowCaretOnScreenScheduled = false;
                if (_CurrentCaretRect == null || !_ScrollController.HasClients)
                {
                    return;
                }

                double scrollOffsetForCaret = _GetScrollOffsetForCaret(_CurrentCaretRect);
                _ScrollController.AnimateTo(scrollOffsetForCaret, duration: _CaretAnimationDuration, curve: _CaretAnimationCurve);
                Rect newCaretRect = _GetCaretRectAtScrollOffset(_CurrentCaretRect, scrollOffsetForCaret);
                double bottomSpacing = Widget.ScrollPadding.Bottom;
                if (_SelectionOverlay?.SelectionControls != null)
                {
                    double handleHeight = _SelectionOverlay.SelectionControls.GetHandleSize(RenderEditable.PreferredLineHeight).Height;
                    double interactiveHandleHeight = Math.Dart:mathDefaultClass.Max(handleHeight, ConstantsDefaultClass.KMinInteractiveDimension);
                    Offset anchor = _SelectionOverlay.SelectionControls.GetHandleAnchor(TextSelectionHandleType.Collapsed, RenderEditable.PreferredLineHeight);
                    double handleCenter = handleHeight / 2 - anchor.Dy;
                    bottomSpacing = Math.Dart:mathDefaultClass.Max(handleCenter + interactiveHandleHeight / 2, bottomSpacing);
                }

                Rect inflatedRect = Rect.FromLTRB(newCaretRect.Left - Widget.ScrollPadding.Left, newCaretRect.Top - Widget.ScrollPadding.Top, newCaretRect.Right + Widget.ScrollPadding.Right, newCaretRect.Bottom + bottomSpacing);
                _EditableKey.CurrentContext.FindRenderObject().ShowOnScreen(rect: inflatedRect, duration: _CaretAnimationDuration, curve: _CaretAnimationCurve);
            }
            );
        }




        public new void DidChangeMetrics()
        {
            if (_LastBottomViewInset < BindingDefaultClass.WidgetsBinding.Instance.Window.ViewInsets.Bottom)
            {
                _ShowCaretOnScreen();
            }

            _LastBottomViewInset = BindingDefaultClass.WidgetsBinding.Instance.Window.ViewInsets.Bottom;
        }




        private void _FormatAndSetValue(FlutterSDK.Services.Textinput.TextEditingValue value)
        {
            _WhitespaceFormatter = (_WhitespaceFormatter == null ? new _WhitespaceDirectionalityFormatter(textDirection: _TextDirection) : _WhitespaceFormatter);
            bool textChanged = _Value?.Text != value?.Text;
            bool isRepeatText = value?.Text == _LastFormattedUnmodifiedTextEditingValue?.Text;
            bool isRepeatSelection = value?.Selection == _LastFormattedUnmodifiedTextEditingValue?.Selection;
            bool isRepeatComposing = value?.Composing == _LastFormattedUnmodifiedTextEditingValue?.Composing;
            if (!isRepeatText && textChanged && Widget.InputFormatters != null && Widget.InputFormatters.IsNotEmpty)
            {
                foreach (TextInputFormatter formatter in Widget.InputFormatters)
                {
                    value = formatter.FormatEditUpdate(_Value, value);
                }

                value = _WhitespaceFormatter.FormatEditUpdate(_Value, value);
                _LastFormattedValue = value;
            }

            _Value = value;
            if (isRepeatText && isRepeatSelection && isRepeatComposing && textChanged && _LastFormattedValue != null)
            {
                _Value = _LastFormattedValue;
            }

            _UpdateRemoteEditingValueIfNeeded();
            if (textChanged && Widget.OnChanged != null) Widget.OnChanged(value.Text);
            _LastFormattedUnmodifiedTextEditingValue = _ReceivedRemoteTextEditingValue;
        }




        private void _OnCursorColorTick()
        {
            RenderEditable.CursorColor = Widget.CursorColor.WithOpacity(_CursorBlinkOpacityController.Value);
            _CursorVisibilityNotifier.Value = Widget.ShowCursor && _CursorBlinkOpacityController.Value > 0;
        }




        private void _CursorTick(Timer timer)
        {
            _TargetCursorVisibility = !_TargetCursorVisibility;
            double targetOpacity = _TargetCursorVisibility ? 1.0 : 0.0;
            if (Widget.CursorOpacityAnimates)
            {
                _CursorBlinkOpacityController.AnimateTo(targetOpacity, curve: CurvesDefaultClass.Curves.EaseOut);
            }
            else
            {
                _CursorBlinkOpacityController.Value = targetOpacity;
            }

            if (_ObscureShowCharTicksPending > 0)
            {
                SetState(() =>
                {
                    _ObscureShowCharTicksPending--;
                }
                );
            }

        }




        private void _CursorWaitForStart(Timer timer)
        {

            _CursorTimer?.Cancel();
            _CursorTimer = Timer.Periodic(EditabletextDefaultClass._KCursorBlinkHalfPeriod, _CursorTick);
        }




        private void _StartCursorTimer()
        {
            _TargetCursorVisibility = true;
            _CursorBlinkOpacityController.Value = 1.0;
            if (EditabletextDefaultClass.EditableText.DebugDeterministicCursor) return;
            if (Widget.CursorOpacityAnimates)
            {
                _CursorTimer = Timer.Periodic(EditabletextDefaultClass._KCursorBlinkWaitForStart, _CursorWaitForStart);
            }
            else
            {
                _CursorTimer = Timer.Periodic(EditabletextDefaultClass._KCursorBlinkHalfPeriod, _CursorTick);
            }

        }




        private void _StopCursorTimer(bool resetCharTicks = true)
        {
            _CursorTimer?.Cancel();
            _CursorTimer = null;
            _TargetCursorVisibility = false;
            _CursorBlinkOpacityController.Value = 0.0;
            if (EditabletextDefaultClass.EditableText.DebugDeterministicCursor) return;
            if (resetCharTicks) _ObscureShowCharTicksPending = 0;
            if (Widget.CursorOpacityAnimates)
            {
                _CursorBlinkOpacityController.Stop();
                _CursorBlinkOpacityController.Value = 0.0;
            }

        }




        private void _StartOrStopCursorTimerIfNeeded()
        {
            if (_CursorTimer == null && _HasFocus && _Value.Selection.IsCollapsed) _StartCursorTimer(); else if (_CursorTimer != null && (!_HasFocus || !_Value.Selection.IsCollapsed)) _StopCursorTimer();
        }




        private void _DidChangeTextEditingValue()
        {
            _UpdateRemoteEditingValueIfNeeded();
            _StartOrStopCursorTimerIfNeeded();
            _UpdateOrDisposeSelectionOverlayIfNeeded();
            _TextChangedSinceLastCaretUpdate = true;
            SetState(() =>
            {
            }
            );
        }




        private void _HandleFocusChanged()
        {
            _OpenOrCloseInputConnectionIfNeeded();
            _StartOrStopCursorTimerIfNeeded();
            _UpdateOrDisposeSelectionOverlayIfNeeded();
            if (_HasFocus)
            {
                BindingDefaultClass.WidgetsBinding.Instance.AddObserver(this);
                _LastBottomViewInset = BindingDefaultClass.WidgetsBinding.Instance.Window.ViewInsets.Bottom;
                _ShowCaretOnScreen();
                if (!_Value.Selection.IsValid)
                {
                    _HandleSelectionChanged(TextSelection.Collapsed(offset: _Value.Text.Length), RenderEditable, null);
                }

            }
            else
            {
                BindingDefaultClass.WidgetsBinding.Instance.RemoveObserver(this);
                _Value = new TextEditingValue(text: _Value.Text);
            }

            UpdateKeepAlive();
        }




        private void _UpdateSizeAndTransform()
        {
            if (_HasInputConnection)
            {
                Size size = RenderEditable.Size;
                Matrix4 transform = RenderEditable.GetTransformTo(null);
                _TextInputConnection.SetEditableSizeAndTransform(size, transform);
                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan _) => =>_UpdateSizeAndTransform());
            }

        }




        public new void BringIntoView(TextPosition position)
        {
            _ScrollController.JumpTo(_GetScrollOffsetForCaret(RenderEditable.GetLocalRectForCaret(position)));
        }




        /// <Summary>
        /// Shows the selection toolbar at the location of the current cursor.
        ///
        /// Returns `false` if a toolbar couldn't be shown, such as when the toolbar
        /// is already shown, or when no text selection currently exists.
        /// </Summary>
        public virtual bool ShowToolbar()
        {
            if (ConstantsDefaultClass.KIsWeb)
            {
                return false;
            }

            if (_SelectionOverlay == null || _SelectionOverlay.ToolbarIsVisible)
            {
                return false;
            }

            _SelectionOverlay.ShowToolbar();
            return true;
        }




        public new void HideToolbar()
        {
            _SelectionOverlay?.Hide();
        }




        /// <Summary>
        /// Toggles the visibility of the toolbar.
        /// </Summary>
        public virtual void ToggleToolbar()
        {

            if (_SelectionOverlay.ToolbarIsVisible)
            {
                HideToolbar();
            }
            else
            {
                ShowToolbar();
            }

        }




        private VoidCallback _SemanticsOnCopy(FlutterSDK.Widgets.Textselection.TextSelectionControls controls)
        {
            return Widget.SelectionEnabled && CopyEnabled && _HasFocus && controls?.CanCopy(this) == true ? () => =>controls.HandleCopy(this):null;
        }




        private VoidCallback _SemanticsOnCut(FlutterSDK.Widgets.Textselection.TextSelectionControls controls)
        {
            return Widget.SelectionEnabled && CutEnabled && _HasFocus && controls?.CanCut(this) == true ? () => =>controls.HandleCut(this):null;
        }




        private VoidCallback _SemanticsOnPaste(FlutterSDK.Widgets.Textselection.TextSelectionControls controls)
        {
            return Widget.SelectionEnabled && PasteEnabled && _HasFocus && controls?.CanPaste(this) == true ? () => =>controls.HandlePaste(this):null;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            _FocusAttachment.Reparent();
            base.Build(context);
            TextSelectionControls controls = Widget.SelectionControls;
            return new Scrollable(excludeFromSemantics: true, axisDirection: _IsMultiline ? AxisDirection.Down : AxisDirection.Right, controller: _ScrollController, physics: Widget.ScrollPhysics, dragStartBehavior: Widget.DragStartBehavior, viewportBuilder: (BuildContext context, ViewportOffset offset) =>
            {
                return new CompositedTransformTarget(link: _ToolbarLayerLink, child: new Semantics(onCopy: _SemanticsOnCopy(controls), onCut: _SemanticsOnCut(controls), onPaste: _SemanticsOnPaste(controls), child: new _Editable(key: _EditableKey, startHandleLayerLink: _StartHandleLayerLink, endHandleLayerLink: _EndHandleLayerLink, textSpan: BuildTextSpan(), value: _Value, cursorColor: _CursorColor, backgroundCursorColor: Widget.BackgroundCursorColor, showCursor: EditabletextDefaultClass.EditableText.DebugDeterministicCursor ? new ValueNotifier<bool>(Widget.ShowCursor) : _CursorVisibilityNotifier, forceLine: Widget.ForceLine, readOnly: Widget.ReadOnly, hasFocus: _HasFocus, maxLines: Widget.MaxLines, minLines: Widget.MinLines, expands: Widget.Expands, strutStyle: Widget.StrutStyle, selectionColor: Widget.SelectionColor, textScaleFactor: Widget.TextScaleFactor ?? MediaqueryDefaultClass.MediaQuery.TextScaleFactorOf(context), textAlign: Widget.TextAlign, textDirection: _TextDirection, locale: Widget.Locale, textWidthBasis: Widget.TextWidthBasis, obscureText: Widget.ObscureText, autocorrect: Widget.Autocorrect, smartDashesType: Widget.SmartDashesType, smartQuotesType: Widget.SmartQuotesType, enableSuggestions: Widget.EnableSuggestions, offset: offset, onSelectionChanged: _HandleSelectionChanged, onCaretChanged: _HandleCaretChanged, rendererIgnoresPointer: Widget.RendererIgnoresPointer, cursorWidth: Widget.CursorWidth, cursorRadius: Widget.CursorRadius, cursorOffset: Widget.CursorOffset, selectionHeightStyle: Widget.SelectionHeightStyle, selectionWidthStyle: Widget.SelectionWidthStyle, paintCursorAboveText: Widget.PaintCursorAboveText, enableInteractiveSelection: Widget.EnableInteractiveSelection, textSelectionDelegate: this, devicePixelRatio: _DevicePixelRatio)));
            }
            );
        }




        /// <Summary>
        /// Builds [TextSpan] from current editing value.
        ///
        /// By default makes text in composing range appear as underlined.
        /// Descendants can override this method to customize appearance of text.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textspan.TextSpan BuildTextSpan()
        {
            if (Widget.ObscureText)
            {
                string text = _Value.Text;
                text = EditableDefaultClass.RenderEditable.ObscuringCharacter * text.Length;
                int o = _ObscureShowCharTicksPending > 0 ? _ObscureLatestCharIndex : null;
                if (o != null && o >= 0 && o < text.Length) text = text.ReplaceRange(o, o + 1, _Value.Text.Substring(o, o + 1));
                return new TextSpan(style: Widget.Style, text: text);
            }

            return Widget.Controller.BuildTextSpan(style: Widget.Style, withComposing: !Widget.ReadOnly);
        }



        #endregion
    }


    public class _Editable : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _Editable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Textspan.TextSpan textSpan = default(FlutterSDK.Painting.Textspan.TextSpan), FlutterSDK.Services.Textinput.TextEditingValue value = default(FlutterSDK.Services.Textinput.TextEditingValue), FlutterSDK.Rendering.Layer.LayerLink startHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Layer.LayerLink endHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundCursorColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> showCursor = default(FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool>), bool forceLine = default(bool), bool readOnly = default(bool), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), bool hasFocus = default(bool), int maxLines = default(int), int minLines = default(int), bool expands = default(bool), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterBinding.UI.Color selectionColor = default(FlutterBinding.UI.Color), double textScaleFactor = default(double), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), Locale locale = default(Locale), bool obscureText = default(bool), bool autocorrect = default(bool), FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = default(bool), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Rendering.Editable.SelectionChangedHandler onSelectionChanged = default(FlutterSDK.Rendering.Editable.SelectionChangedHandler), FlutterSDK.Rendering.Editable.CaretChangedHandler onCaretChanged = default(FlutterSDK.Rendering.Editable.CaretChangedHandler), bool rendererIgnoresPointer = false, double cursorWidth = default(double), Radius cursorRadius = default(Radius), FlutterBinding.UI.Offset cursorOffset = default(FlutterBinding.UI.Offset), bool paintCursorAboveText = default(bool), BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), bool enableInteractiveSelection = true, FlutterSDK.Services.Textinput.TextSelectionDelegate textSelectionDelegate = default(FlutterSDK.Services.Textinput.TextSelectionDelegate), double devicePixelRatio = default(double))
        : base(key: key)
        {
            this.TextSpan = textSpan;
            this.Value = value;
            this.StartHandleLayerLink = startHandleLayerLink;
            this.EndHandleLayerLink = endHandleLayerLink;
            this.CursorColor = cursorColor;
            this.BackgroundCursorColor = backgroundCursorColor;
            this.ShowCursor = showCursor;
            this.ForceLine = forceLine;
            this.ReadOnly = readOnly;
            this.TextWidthBasis = textWidthBasis;
            this.HasFocus = hasFocus;
            this.MaxLines = maxLines;
            this.MinLines = minLines;
            this.Expands = expands;
            this.StrutStyle = strutStyle;
            this.SelectionColor = selectionColor;
            this.TextScaleFactor = textScaleFactor;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.Locale = locale;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.SmartDashesType = smartDashesType;
            this.SmartQuotesType = smartQuotesType;
            this.EnableSuggestions = enableSuggestions;
            this.Offset = offset;
            this.OnSelectionChanged = onSelectionChanged;
            this.OnCaretChanged = onCaretChanged;
            this.RendererIgnoresPointer = rendererIgnoresPointer;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorOffset = cursorOffset;
            this.PaintCursorAboveText = paintCursorAboveText;
            this.SelectionHeightStyle = selectionHeightStyle;
            this.SelectionWidthStyle = selectionWidthStyle;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.TextSelectionDelegate = textSelectionDelegate;
            this.DevicePixelRatio = devicePixelRatio;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Textspan.TextSpan TextSpan { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue Value { get; set; }
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink StartHandleLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink EndHandleLayerLink { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundCursorColor { get; set; }
        public virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> ShowCursor { get; set; }
        public virtual bool ForceLine { get; set; }
        public virtual bool ReadOnly { get; set; }
        public virtual bool HasFocus { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual int MinLines { get; set; }
        public virtual bool Expands { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual FlutterBinding.UI.Color SelectionColor { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual bool ObscureText { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual bool Autocorrect { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        public virtual bool EnableSuggestions { get; set; }
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }
        public virtual FlutterSDK.Rendering.Editable.SelectionChangedHandler OnSelectionChanged { get; set; }
        public virtual FlutterSDK.Rendering.Editable.CaretChangedHandler OnCaretChanged { get; set; }
        public virtual bool RendererIgnoresPointer { get; set; }
        public virtual double CursorWidth { get; set; }
        public virtual Radius CursorRadius { get; set; }
        public virtual FlutterBinding.UI.Offset CursorOffset { get; set; }
        public virtual bool PaintCursorAboveText { get; set; }
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        public virtual bool EnableInteractiveSelection { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextSelectionDelegate TextSelectionDelegate { get; set; }
        public virtual double DevicePixelRatio { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Editable.RenderEditable CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderEditable(text: TextSpan, cursorColor: CursorColor, startHandleLayerLink: StartHandleLayerLink, endHandleLayerLink: EndHandleLayerLink, backgroundCursorColor: BackgroundCursorColor, showCursor: ShowCursor, forceLine: ForceLine, readOnly: ReadOnly, hasFocus: HasFocus, maxLines: MaxLines, minLines: MinLines, expands: Expands, strutStyle: StrutStyle, selectionColor: SelectionColor, textScaleFactor: TextScaleFactor, textAlign: TextAlign, textDirection: TextDirection, locale: Locale ?? LocalizationsDefaultClass.Localizations.LocaleOf(context, nullOk: true), selection: Value.Selection, offset: Offset, onSelectionChanged: OnSelectionChanged, onCaretChanged: OnCaretChanged, ignorePointer: RendererIgnoresPointer, obscureText: ObscureText, textWidthBasis: TextWidthBasis, cursorWidth: CursorWidth, cursorRadius: CursorRadius, cursorOffset: CursorOffset, paintCursorAboveText: PaintCursorAboveText, selectionHeightStyle: SelectionHeightStyle, selectionWidthStyle: SelectionWidthStyle, enableInteractiveSelection: EnableInteractiveSelection, textSelectionDelegate: TextSelectionDelegate, devicePixelRatio: DevicePixelRatio);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Editable.RenderEditable renderObject)
        {
            ..Text = TextSpan..CursorColor = CursorColor..StartHandleLayerLink = StartHandleLayerLink..EndHandleLayerLink = EndHandleLayerLink..ShowCursor = ShowCursor..ForceLine = ForceLine..ReadOnly = ReadOnly..HasFocus = HasFocus..MaxLines = MaxLines..MinLines = MinLines..Expands = Expands..StrutStyle = StrutStyle..SelectionColor = SelectionColor..TextScaleFactor = TextScaleFactor..TextAlign = TextAlign..TextDirection = TextDirection..Locale = Locale ?? LocalizationsDefaultClass.Localizations.LocaleOf(context, nullOk: true)..Selection = Value.Selection..Offset = Offset..OnSelectionChanged = OnSelectionChanged..OnCaretChanged = OnCaretChanged..IgnorePointer = RendererIgnoresPointer..TextWidthBasis = TextWidthBasis..ObscureText = ObscureText..CursorWidth = CursorWidth..CursorRadius = CursorRadius..CursorOffset = CursorOffset..SelectionHeightStyle = SelectionHeightStyle..SelectionWidthStyle = SelectionWidthStyle..TextSelectionDelegate = TextSelectionDelegate..DevicePixelRatio = DevicePixelRatio..PaintCursorAboveText = PaintCursorAboveText;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Text = TextSpan..CursorColor = CursorColor..StartHandleLayerLink = StartHandleLayerLink..EndHandleLayerLink = EndHandleLayerLink..ShowCursor = ShowCursor..ForceLine = ForceLine..ReadOnly = ReadOnly..HasFocus = HasFocus..MaxLines = MaxLines..MinLines = MinLines..Expands = Expands..StrutStyle = StrutStyle..SelectionColor = SelectionColor..TextScaleFactor = TextScaleFactor..TextAlign = TextAlign..TextDirection = TextDirection..Locale = Locale ?? LocalizationsDefaultClass.Localizations.LocaleOf(context, nullOk: true)..Selection = Value.Selection..Offset = Offset..OnSelectionChanged = OnSelectionChanged..OnCaretChanged = OnCaretChanged..IgnorePointer = RendererIgnoresPointer..TextWidthBasis = TextWidthBasis..ObscureText = ObscureText..CursorWidth = CursorWidth..CursorRadius = CursorRadius..CursorOffset = CursorOffset..SelectionHeightStyle = SelectionHeightStyle..SelectionWidthStyle = SelectionWidthStyle..TextSelectionDelegate = TextSelectionDelegate..DevicePixelRatio = DevicePixelRatio..PaintCursorAboveText = PaintCursorAboveText;
        }



        #endregion
    }


    public class _WhitespaceDirectionalityFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        #region constructors
        public _WhitespaceDirectionalityFormatter(TextDirection textDirection = default(TextDirection))
        : base()
        {

        }
        #endregion

        #region fields
        internal virtual RegExp _LtrRegExp { get; set; }
        internal virtual RegExp _RtlRegExp { get; set; }
        internal virtual RegExp _WhitespaceRegExp { get; set; }
        internal virtual TextDirection _BaseDirection { get; set; }
        internal virtual TextDirection _PreviousNonWhitespaceDirection { get; set; }
        internal virtual bool _HasOpposingDirection { get; set; }
        internal virtual int _Rlm { get; set; }
        internal virtual int _Lrm { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            if (!_HasOpposingDirection)
            {
                _HasOpposingDirection = _BaseDirection == TextDirection.Ltr ? _RtlRegExp.HasMatch(newValue.Text) : _LtrRegExp.HasMatch(newValue.Text);
            }

            if (_HasOpposingDirection)
            {
                _PreviousNonWhitespaceDirection = _BaseDirection;
                List<int> outputCodepoints = new List<int>() { };
                int selectionBase = newValue.Selection.BaseOffset;
                int selectionExtent = newValue.Selection.ExtentOffset;
                int composingStart = newValue.Composing.Start;
                int composingEnd = newValue.Composing.End;
                void AddToLength() => {
                    selectionBase += outputCodepoints.Count <= selectionBase ? 1 : 0;
                    selectionExtent += outputCodepoints.Count <= selectionExtent ? 1 : 0;
                    composingStart += outputCodepoints.Count <= composingStart ? 1 : 0;
                    composingEnd += outputCodepoints.Count <= composingEnd ? 1 : 0;
                }

                void SubtractFromLength() => {
                    selectionBase -= outputCodepoints.Count < selectionBase ? 1 : 0;
                    selectionExtent -= outputCodepoints.Count < selectionExtent ? 1 : 0;
                    composingStart -= outputCodepoints.Count < composingStart ? 1 : 0;
                    composingEnd -= outputCodepoints.Count < composingEnd ? 1 : 0;
                }

                bool previousWasWhitespace = false;
                bool previousWasDirectionalityMarker = false;
                int previousNonWhitespaceCodepoint = default(int);
                foreach (int codepoint in newValue.Text.Runes)
                {
                    if (IsWhitespace(codepoint))
                    {
                        if (!previousWasWhitespace && previousNonWhitespaceCodepoint != null)
                        {
                            _PreviousNonWhitespaceDirection = GetDirection(previousNonWhitespaceCodepoint);
                        }

                        if (previousWasWhitespace)
                        {
                            SubtractFromLength();
                            outputCodepoints.RemoveLast();
                        }

                        outputCodepoints.Add(codepoint);
                        AddToLength();
                        outputCodepoints.Add(_PreviousNonWhitespaceDirection == TextDirection.Rtl ? _Rlm : _Lrm);
                        previousWasWhitespace = true;
                        previousWasDirectionalityMarker = false;
                    }
                    else if (IsDirectionalityMarker(codepoint))
                    {
                        if (previousWasWhitespace)
                        {
                            SubtractFromLength();
                            outputCodepoints.RemoveLast();
                        }

                        outputCodepoints.Add(codepoint);
                        previousWasWhitespace = false;
                        previousWasDirectionalityMarker = true;
                    }
                    else
                    {
                        if (!previousWasDirectionalityMarker && previousWasWhitespace && GetDirection(codepoint) == _PreviousNonWhitespaceDirection)
                        {
                            SubtractFromLength();
                            outputCodepoints.RemoveLast();
                        }

                        previousNonWhitespaceCodepoint = codepoint;
                        outputCodepoints.Add(codepoint);
                        previousWasWhitespace = false;
                        previousWasDirectionalityMarker = false;
                    }

                }

                string formatted = string.FromCharCodes(outputCodepoints);
                return new TextEditingValue(text: formatted, selection: new TextSelection(baseOffset: selectionBase, extentOffset: selectionExtent, affinity: newValue.Selection.Affinity, isDirectional: newValue.Selection.IsDirectional), composing: new TextRange(start: composingStart, end: composingEnd));
            }

            return newValue;
        }




        public virtual bool IsWhitespace(int value)
        {
            return _WhitespaceRegExp.HasMatch(string.FromCharCode(value));
        }




        public virtual bool IsDirectionalityMarker(int value)
        {
            return value == _Rlm || value == _Lrm;
        }




        public virtual TextDirection GetDirection(int value)
        {
            return _LtrRegExp.HasMatch(string.FromCharCode(value)) ? TextDirection.Ltr : TextDirection.Rtl;
        }



        #endregion
    }

}
