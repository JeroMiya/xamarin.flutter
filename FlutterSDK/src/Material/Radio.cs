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
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
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
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
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
namespace FlutterSDK.Material.Radio
{
    internal static class RadioDefaultClass
    {
        public static double _KOuterRadius = default(double);
        public static double _KInnerRadius = default(double);
    }

    /// <Summary>
    /// A material design radio button.
    ///
    /// Used to select between a number of mutually exclusive values. When one radio
    /// button in a group is selected, the other radio buttons in the group cease to
    /// be selected. The values are of type `T`, the type parameter of the [Radio]
    /// class. Enums are commonly used for this purpose.
    ///
    /// The radio button itself does not maintain any state. Instead, selecting the
    /// radio invokes the [onChanged] callback, passing [value] as a parameter. If
    /// [groupValue] and [value] match, this radio will be selected. Most widgets
    /// will respond to [onChanged] by calling [State.setState] to update the
    /// radio button's [groupValue].
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// Here is an example of Radio widgets wrapped in ListTiles, which is similar
    /// to what you could get with the RadioListTile widget.
    ///
    /// The currently selected character is passed into `groupValue`, which is
    /// maintained by the example's `State`. In this case, the first `Radio`
    /// will start off selected because `_character` is initialized to
    /// `SingingCharacter.lafayette`.
    ///
    /// If the second radio button is pressed, the example's state is updated
    /// with `setState`, updating `_character` to `SingingCharacter.jefferson`.
    /// This causes the buttons to rebuild with the updated `groupValue`, and
    /// therefore the selection of the second button.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// ```dart preamble
    /// enum SingingCharacter { lafayette, jefferson }
    /// ```
    ///
    /// ```dart
    /// SingingCharacter _character = SingingCharacter.lafayette;
    ///
    /// Widget build(BuildContext context) {
    ///   return Column(
    ///     children: <Widget>[
    ///       ListTile(
    ///         title: const Text('Lafayette'),
    ///         leading: Radio(
    ///           value: SingingCharacter.lafayette,
    ///           groupValue: _character,
    ///           onChanged: (SingingCharacter value) {
    ///             setState(() { _character = value; });
    ///           },
    ///         ),
    ///       ),
    ///       ListTile(
    ///         title: const Text('Thomas Jefferson'),
    ///         leading: Radio(
    ///           value: SingingCharacter.jefferson,
    ///           groupValue: _character,
    ///           onChanged: (SingingCharacter value) {
    ///             setState(() { _character = value; });
    ///           },
    ///         ),
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RadioListTile], which combines this widget with a [ListTile] so that
    ///    you can give the radio button a label.
    ///  * [Slider], for selecting a value in a range.
    ///  * [Checkbox] and [Switch], for toggling a particular value on or off.
    ///  * <https://material.io/design/components/selection-controls.html#radio-buttons>
    /// </Summary>
    public class Radio<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a material design radio button.
        ///
        /// The radio button itself does not maintain any state. Instead, when the
        /// radio button is selected, the widget calls the [onChanged] callback. Most
        /// widgets that use a radio button will listen for the [onChanged] callback
        /// and rebuild the radio button with a new [groupValue] to update the visual
        /// appearance of the radio button.
        ///
        /// The following arguments are required:
        ///
        /// * [value] and [groupValue] together determine whether the radio button is
        ///   selected.
        /// * [onChanged] is called when the user selects this radio button.
        /// </Summary>
        public Radio(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T value = default(T), T groupValue = default(T), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false)
        : base(key: key)
        {
            this.Value = value;
            this.GroupValue = groupValue;
            this.OnChanged = onChanged;
            this.ActiveColor = activeColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.VisualDensity = visualDensity;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
        }
        /// <Summary>
        /// The value represented by this radio button.
        /// </Summary>
        public virtual T Value { get; set; }
        /// <Summary>
        /// The currently selected value for a group of radio buttons.
        ///
        /// This radio button is considered selected if its [value] matches the
        /// [groupValue].
        /// </Summary>
        public virtual T GroupValue { get; set; }
        /// <Summary>
        /// Called when the user selects this radio button.
        ///
        /// The radio button passes [value] as a parameter to this callback. The radio
        /// button does not actually change state until the parent widget rebuilds the
        /// radio button with the new [groupValue].
        ///
        /// If null, the radio button will be displayed as disabled.
        ///
        /// The provided callback will not be invoked if this radio button is already
        /// selected.
        ///
        /// The callback provided to [onChanged] should update the state of the parent
        /// [StatefulWidget] using the [State.setState] method, so that the parent
        /// gets rebuilt; for example:
        ///
        /// ```dart
        /// Radio<SingingCharacter>(
        ///   value: SingingCharacter.lafayette,
        ///   groupValue: _character,
        ///   onChanged: (SingingCharacter newValue) {
        ///     setState(() {
        ///       _character = newValue;
        ///     });
        ///   },
        /// )
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnChanged { get; set; }
        /// <Summary>
        /// The color to use when this radio button is selected.
        ///
        /// Defaults to [ThemeData.toggleableActiveColor].
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        /// <Summary>
        /// Configures the minimum size of the tap target.
        ///
        /// Defaults to [ThemeData.materialTapTargetSize].
        ///
        /// See also:
        ///
        ///  * [MaterialTapTargetSize], for a description of how this affects tap targets.
        /// </Summary>
        public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        /// <Summary>
        /// Defines how compact the radio's layout will be.
        ///
        /// {@macro flutter.material.themedata.visualDensity}
        ///
        /// See also:
        ///
        ///  * [ThemeData.visualDensity], which specifies the [density] for all widgets
        ///    within a [Theme].
        /// </Summary>
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        /// <Summary>
        /// The color for the radio's [Material] when it has the input focus.
        /// </Summary>
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        /// <Summary>
        /// The color for the radio's [Material] when a pointer is hovering over it.
        /// </Summary>
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.focusNode}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }

        public new _RadioState<T> CreateState() => new _RadioState<T>();


    }


    public class _RadioState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Radio.Radio<T>>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _RadioState()
        { }
        internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> _ActionMap { get; set; }
        internal virtual bool _Focused { get; set; }
        internal virtual bool _Hovering { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _ActionMap = new Dictionary<LocalKey, ActionFactory> { { ActionsDefaultClass.ActivateAction.Key, _CreateAction } };
        }




        private void _ActionHandler(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
            if (Widget.OnChanged != null)
            {
                Widget.OnChanged(Widget.Value);
            }

            RenderObject renderObject = node.Context.FindRenderObject();
            renderObject.SendSemanticsEvent(new TapSemanticEvent());
        }




        private FlutterSDK.Widgets.Actions.Action _CreateAction()
        {
            return new CallbackAction(ActionsDefaultClass.ActivateAction.Key, onInvoke: _ActionHandler);
        }




        private void _HandleHighlightChanged(bool focused)
        {
            if (_Focused != focused)
            {
                SetState(() =>
                {
                    _Focused = focused;
                }
                );
            }

        }




        private void _HandleHoverChanged(bool hovering)
        {
            if (_Hovering != hovering)
            {
                SetState(() =>
                {
                    _Hovering = hovering;
                }
                );
            }

        }




        private Color _GetInactiveColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            return Enabled ? themeData.UnselectedWidgetColor : themeData.DisabledColor;
        }




        private void _HandleChanged(bool selected)
        {
            if (selected) Widget.OnChanged(Widget.Value);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            Size size = default(Size);
            switch (Widget.MaterialTapTargetSize ?? themeData.MaterialTapTargetSize) { case MaterialTapTargetSize.Padded: size = new Size(2 * ConstantsDefaultClass.KRadialReactionRadius + 8.0, 2 * ConstantsDefaultClass.KRadialReactionRadius + 8.0); break; case MaterialTapTargetSize.ShrinkWrap: size = new Size(2 * ConstantsDefaultClass.KRadialReactionRadius, 2 * ConstantsDefaultClass.KRadialReactionRadius); break; }
            size += (Widget.VisualDensity ?? themeData.VisualDensity).BaseSizeAdjustment;
            BoxConstraints additionalConstraints = BoxConstraints.Tight(size);
            return new FocusableActionDetector(actions: _ActionMap, focusNode: Widget.FocusNode, autofocus: Widget.Autofocus, enabled: Enabled, onShowFocusHighlight: _HandleHighlightChanged, onShowHoverHighlight: _HandleHoverChanged, child: new Builder(builder: (BuildContext context) =>
            {
                return new _RadioRenderObjectWidget(selected: Widget.Value == Widget.GroupValue, activeColor: Widget.ActiveColor ?? themeData.ToggleableActiveColor, inactiveColor: _GetInactiveColor(themeData), focusColor: Widget.FocusColor ?? themeData.FocusColor, hoverColor: Widget.HoverColor ?? themeData.HoverColor, onChanged: Enabled ? _HandleChanged : null, additionalConstraints: additionalConstraints, vsync: this, hasFocus: _Focused, hovering: _Hovering);
            }
            ));
        }



    }


    public class _RadioRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public _RadioRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool selected = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), bool hasFocus = default(bool), bool hovering = default(bool))
        : base(key: key)
        {
            this.Selected = selected;
            this.ActiveColor = activeColor;
            this.InactiveColor = inactiveColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.AdditionalConstraints = additionalConstraints;
            this.OnChanged = onChanged;
            this.Vsync = vsync;
            this.HasFocus = hasFocus;
            this.Hovering = hovering;
        }
        public virtual bool Selected { get; set; }
        public virtual bool HasFocus { get; set; }
        public virtual bool Hovering { get; set; }
        public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints AdditionalConstraints { get; set; }

        public new FlutterSDK.Material.Radio._RenderRadio CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new _RenderRadio(value: Selected, activeColor: ActiveColor, inactiveColor: InactiveColor, focusColor: FocusColor, hoverColor: HoverColor, onChanged: OnChanged, vsync: Vsync, additionalConstraints: AdditionalConstraints, hasFocus: HasFocus, hovering: Hovering);



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Radio._RenderRadio renderObject)
        {
            ..Value = Selected..ActiveColor = ActiveColor..InactiveColor = InactiveColor..FocusColor = FocusColor..HoverColor = HoverColor..OnChanged = OnChanged..AdditionalConstraints = AdditionalConstraints..Vsync = Vsync..HasFocus = HasFocus..Hovering = Hovering;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Value = Selected..ActiveColor = ActiveColor..InactiveColor = InactiveColor..FocusColor = FocusColor..HoverColor = HoverColor..OnChanged = OnChanged..AdditionalConstraints = AdditionalConstraints..Vsync = Vsync..HasFocus = HasFocus..Hovering = Hovering;
        }



    }


    public class _RenderRadio : FlutterSDK.Material.Toggleable.RenderToggleable
    {
        public _RenderRadio(bool value = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), bool hasFocus = default(bool), bool hovering = default(bool))
        : base(value: value, tristate: false, activeColor: activeColor, inactiveColor: inactiveColor, focusColor: focusColor, hoverColor: hoverColor, onChanged: onChanged, additionalConstraints: additionalConstraints, vsync: vsync, hasFocus: hasFocus, hovering: hovering)
        {

        }

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            Canvas canvas = context.Canvas;
            PaintRadialReaction(canvas, offset, Size.Center(Dart.UI.UiDefaultClass.Offset.Zero));
            Offset center = (offset & Size).Center;
            Color radioColor = OnChanged != null ? ActiveColor : InactiveColor;
            Paint paint = new Paint()..Color = Dart.UI.UiDefaultClass.Color.Lerp(InactiveColor, radioColor, Position.Value)..Style = PaintingStyle.Stroke..StrokeWidth = 2.0;
            canvas.DrawCircle(center, RadioDefaultClass._KOuterRadius, paint);
            if (!Position.IsDismissed)
            {
                paint.Style = PaintingStyle.Fill;
                canvas.DrawCircle(center, RadioDefaultClass._KInnerRadius * Position.Value, paint);
            }

        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            ..IsInMutuallyExclusiveGroup = true..IsChecked = Value == true;
        }



    }

}
