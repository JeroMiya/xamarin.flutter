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
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
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
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Floatingactionbutton
{
    internal static class FloatingactionbuttonDefaultClass
    {
        public static FlutterSDK.Rendering.Box.BoxConstraints _KSizeConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints);
        public static FlutterSDK.Rendering.Box.BoxConstraints _KMiniSizeConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints);
        public static FlutterSDK.Rendering.Box.BoxConstraints _KExtendedSizeConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints);
    }

    public class _DefaultHeroTag
    {
        public _DefaultHeroTag()
        {

        }

    }


    /// <Summary>
    /// A material design floating action button.
    ///
    /// A floating action button is a circular icon button that hovers over content
    /// to promote a primary action in the application. Floating action buttons are
    /// most commonly used in the [Scaffold.floatingActionButton] field.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=2uaoEDOgk_I}
    ///
    /// Use at most a single floating action button per screen. Floating action
    /// buttons should be used for positive actions such as "create", "share", or
    /// "navigate". (If more than one floating action button is used within a
    /// [Route], then make sure that each button has a unique [heroTag], otherwise
    /// an exception will be thrown.)
    ///
    /// If the [onPressed] callback is null, then the button will be disabled and
    /// will not react to touch. It is highly discouraged to disable a floating
    /// action button as there is no indication to the user that the button is
    /// disabled. Consider changing the [backgroundColor] if disabling the floating
    /// action button.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to display a [FloatingActionButton] in a
    /// [Scaffold], with a pink [backgroundColor] and a thumbs up [Icon].
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/floating_action_button.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('Floating Action Button'),
    ///     ),
    ///     body: Center(
    ///       child: const Text('Press the button below!')
    ///     ),
    ///     floatingActionButton: FloatingActionButton(
    ///       onPressed: () {
    ///         // Add your onPressed code here!
    ///       },
    ///       child: Icon(Icons.navigation),
    ///       backgroundColor: Colors.green,
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to make an extended [FloatingActionButton] in a
    /// [Scaffold], with a  pink [backgroundColor], a thumbs up [Icon] and a
    /// [Text] label that reads "Approve".
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/floating_action_button_label.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('Floating Action Button Label'),
    ///     ),
    ///     body: Center(
    ///       child: const Text('Press the button with a label below!'),
    ///     ),
    ///     floatingActionButton: FloatingActionButton.extended(
    ///       onPressed: () {
    ///         // Add your onPressed code here!
    ///       },
    ///       label: Text('Approve'),
    ///       icon: Icon(Icons.thumb_up),
    ///       backgroundColor: Colors.pink,
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Scaffold], in which floating action buttons typically live.
    ///  * [RaisedButton], another kind of button that appears to float above the
    ///    content.
    ///  * <https://material.io/design/components/buttons-floating-action-button.html>
    /// </Summary>
    public class FloatingActionButton : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a circular floating action button.
        ///
        /// The [mini] and [clipBehavior] arguments must not be null. Additionally,
        /// [elevation], [highlightElevation], and [disabledElevation] (if specified)
        /// must be non-negative.
        /// </Summary>
        public FloatingActionButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), string tooltip = default(string), FlutterBinding.UI.Color foregroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), @Object heroTag = default(@Object), double elevation = default(double), double focusElevation = default(double), double hoverElevation = default(double), double highlightElevation = default(double), double disabledElevation = default(double), VoidCallback onPressed = default(VoidCallback), bool mini = false, FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool isExtended = false)
        : base(key: key)
        {
            this.Child = child;
            this.Tooltip = tooltip;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.SplashColor = splashColor;
            this.HeroTag = heroTag;
            this.Elevation = elevation;
            this.FocusElevation = focusElevation;
            this.HoverElevation = hoverElevation;
            this.HighlightElevation = highlightElevation;
            this.DisabledElevation = disabledElevation;
            this.OnPressed = onPressed;
            this.Mini = mini;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.IsExtended = isExtended;
        }
        /// <Summary>
        /// Creates a wider [StadiumBorder]-shaped floating action button with
        /// an optional [icon] and a [label].
        ///
        /// The [label], [autofocus], and [clipBehavior] arguments must not be null.
        /// Additionally, [elevation], [highlightElevation], and [disabledElevation]
        /// (if specified) must be non-negative.
        /// </Summary>
        public static FloatingActionButton Extended(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string tooltip = default(string), FlutterBinding.UI.Color foregroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), @Object heroTag = default(@Object), double elevation = default(double), double focusElevation = default(double), double hoverElevation = default(double), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double highlightElevation = default(double), double disabledElevation = default(double), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool isExtended = true, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))
        => new FloatingActionButton(key, tooltip, foregroundColor, backgroundColor, focusColor, hoverColor, heroTag, elevation, focusElevation, hoverElevation, splashColor, highlightElevation, disabledElevation, onPressed, shape, isExtended, materialTapTargetSize, clipBehavior, focusNode, autofocus, icon, label);

        private FloatingActionButton(FlutterSDK.Foundation.Key.Key key, string tooltip, FlutterBinding.UI.Color foregroundColor, FlutterBinding.UI.Color backgroundColor, FlutterBinding.UI.Color focusColor, FlutterBinding.UI.Color hoverColor, @Object heroTag, double elevation, double focusElevation, double hoverElevation, FlutterBinding.UI.Color splashColor, double highlightElevation, double disabledElevation, VoidCallback onPressed, FlutterSDK.Painting.Borders.ShapeBorder shape, bool isExtended, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize, FlutterBinding.UI.Clip clipBehavior, FlutterSDK.Widgets.Focusmanager.FocusNode focusNode, bool autofocus, FlutterSDK.Widgets.Framework.Widget icon, FlutterSDK.Widgets.Framework.Widget label)
        : base(key: key)
        {
            this.Tooltip = tooltip;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.HeroTag = heroTag;
            this.Elevation = elevation;
            this.FocusElevation = focusElevation;
            this.HoverElevation = hoverElevation;
            this.SplashColor = splashColor;
            this.HighlightElevation = highlightElevation;
            this.DisabledElevation = disabledElevation;
            this.OnPressed = onPressed;
            this.Shape = shape;
            this.IsExtended = isExtended;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// Typically an [Icon].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// Text that describes the action that will occur when the button is pressed.
        ///
        /// This text is displayed when the user long-presses on the button and is
        /// used for accessibility.
        /// </Summary>
        public virtual string Tooltip { get; set; }
        /// <Summary>
        /// The default foreground color for icons and text within the button.
        ///
        /// If this property is null, then the [Theme]'s
        /// [ThemeData.floatingActionButtonTheme.foregroundColor] is used. If that
        /// property is also null, then the [Theme]'s
        /// [ThemeData.colorScheme.onSecondary] color is used.
        ///
        /// Although the color of theme's `accentIconTheme` currently provides a
        /// default that supercedes the `onSecondary` color, this dependency
        /// has been deprecated:  https://flutter.dev/go/remove-fab-accent-theme-dependency.
        /// It will be removed in the future.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ForegroundColor { get; set; }
        /// <Summary>
        /// The button's background color.
        ///
        /// If this property is null, then the [Theme]'s
        /// [ThemeData.floatingActionButtonTheme.backgroundColor] is used. If that
        /// property is also null, then the [Theme]'s
        /// [ThemeData.colorScheme.secondary] color is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The color to use for filling the button when the button has input focus.
        ///
        /// Defaults to [ThemeData.focusColor] for the current theme.
        /// </Summary>
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        /// <Summary>
        /// The color to use for filling the button when the button has a pointer
        /// hovering over it.
        ///
        /// Defaults to [ThemeData.hoverColor] for the current theme.
        /// </Summary>
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        /// <Summary>
        /// The splash color for this [FloatingActionButton]'s [InkWell].
        ///
        /// If null, [FloatingActionButtonThemeData.splashColor] is used, if that is
        /// null, [ThemeData.splashColor] is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        /// <Summary>
        /// The tag to apply to the button's [Hero] widget.
        ///
        /// Defaults to a tag that matches other floating action buttons.
        ///
        /// Set this to null explicitly if you don't want the floating action button to
        /// have a hero tag.
        ///
        /// If this is not explicitly set, then there can only be one
        /// [FloatingActionButton] per route (that is, per screen), since otherwise
        /// there would be a tag conflict (multiple heroes on one route can't have the
        /// same tag). The material design specification recommends only using one
        /// floating action button per screen.
        /// </Summary>
        public virtual @Object HeroTag { get; set; }
        /// <Summary>
        /// The callback that is called when the button is tapped or otherwise activated.
        ///
        /// If this is set to null, the button will be disabled.
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this button relative to its parent.
        ///
        /// This controls the size of the shadow below the floating action button.
        ///
        /// Defaults to 6, the appropriate elevation for floating action buttons. The
        /// value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [highlightElevation], the elevation when the button is pressed.
        ///  * [disabledElevation], the elevation when the button is disabled.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this button relative to its parent when
        /// the button has the input focus.
        ///
        /// This controls the size of the shadow below the floating action button.
        ///
        /// Defaults to 8, the appropriate elevation for floating action buttons
        /// while they have focus. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [highlightElevation], the elevation when the button is pressed.
        ///  * [disabledElevation], the elevation when the button is disabled.
        /// </Summary>
        public virtual double FocusElevation { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this button relative to its parent when
        /// the button is enabled and has a pointer hovering over it.
        ///
        /// This controls the size of the shadow below the floating action button.
        ///
        /// Defaults to 8, the appropriate elevation for floating action buttons while
        /// they have a pointer hovering over them. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [highlightElevation], the elevation when the button is pressed.
        ///  * [disabledElevation], the elevation when the button is disabled.
        /// </Summary>
        public virtual double HoverElevation { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this button relative to its parent when
        /// the user is touching the button.
        ///
        /// This controls the size of the shadow below the floating action button.
        ///
        /// Defaults to 12, the appropriate elevation for floating action buttons
        /// while they are being touched. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        /// </Summary>
        public virtual double HighlightElevation { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this button when the button is disabled
        /// ([onPressed] is null).
        ///
        /// This controls the size of the shadow below the floating action button.
        ///
        /// Defaults to the same value as [elevation]. Setting this to zero makes the
        /// floating action button work similar to a [RaisedButton] but the titular
        /// "floating" effect is lost. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [highlightElevation], the elevation when the button is pressed.
        /// </Summary>
        public virtual double DisabledElevation { get; set; }
        /// <Summary>
        /// Controls the size of this button.
        ///
        /// By default, floating action buttons are non-mini and have a height and
        /// width of 56.0 logical pixels. Mini floating action buttons have a height
        /// and width of 40.0 logical pixels with a layout width and height of 48.0
        /// logical pixels. (The extra 4 pixels of padding on each side are added as a
        /// result of the floating action button having [MaterialTapTargetSize.padded]
        /// set on the underlying [RawMaterialButton.materialTapTargetSize].)
        /// </Summary>
        public virtual bool Mini { get; set; }
        /// <Summary>
        /// The shape of the button's [Material].
        ///
        /// The button's highlight and splash are clipped to this shape. If the
        /// button has an elevation, then its drop shadow is defined by this
        /// shape as well.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Clip}
        ///
        /// Defaults to [Clip.none], and must not be null.
        /// </Summary>
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        /// <Summary>
        /// True if this is an "extended" floating action button.
        ///
        /// Typically [extended] buttons have a [StadiumBorder] [shape]
        /// and have been created with the [FloatingActionButton.extended]
        /// constructor.
        ///
        /// The [Scaffold] animates the appearance of ordinary floating
        /// action buttons with scale and rotation transitions. Extended
        /// floating action buttons are scaled and faded in.
        /// </Summary>
        public virtual bool IsExtended { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.focusNode}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
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
        internal virtual FlutterSDK.Rendering.Box.BoxConstraints _SizeConstraints { get; set; }
        internal virtual double _DefaultElevation { get; set; }
        internal virtual double _DefaultFocusElevation { get; set; }
        internal virtual double _DefaultHoverElevation { get; set; }
        internal virtual double _DefaultHighlightElevation { get; set; }
        internal virtual FlutterSDK.Painting.Borders.ShapeBorder _DefaultShape { get; set; }
        internal virtual FlutterSDK.Painting.Borders.ShapeBorder _DefaultExtendedShape { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            FloatingActionButtonThemeData floatingActionButtonTheme = theme.FloatingActionButtonTheme;
            if (this.ForegroundColor == null && floatingActionButtonTheme.ForegroundColor == null)
            {
                bool accentIsDark = theme.AccentColorBrightness == Brightness.Dark;
                Color defaultAccentIconThemeColor = accentIsDark ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black;
                if (theme.AccentIconTheme.Color != defaultAccentIconThemeColor)
                {
                    PrintDefaultClass.DebugPrint("Warning: " + "The support for configuring the foreground color of " + "FloatingActionButtons using ThemeData.accentIconTheme " + "has been deprecated. Please use ThemeData.floatingActionButtonTheme " + "instead. See " + "https://flutter.dev/go/remove-fab-accent-theme-dependency. " + "This feature was deprecated after v1.13.2.");
                }

            }

            Color foregroundColor = this.ForegroundColor ?? floatingActionButtonTheme.ForegroundColor ?? theme.ColorScheme.OnSecondary;
            Color backgroundColor = this.BackgroundColor ?? floatingActionButtonTheme.BackgroundColor ?? theme.ColorScheme.Secondary;
            Color focusColor = this.FocusColor ?? floatingActionButtonTheme.FocusColor ?? theme.FocusColor;
            Color hoverColor = this.HoverColor ?? floatingActionButtonTheme.HoverColor ?? theme.HoverColor;
            Color splashColor = this.SplashColor ?? floatingActionButtonTheme.SplashColor ?? theme.SplashColor;
            double elevation = this.Elevation ?? floatingActionButtonTheme.Elevation ?? _DefaultElevation;
            double focusElevation = this.FocusElevation ?? floatingActionButtonTheme.FocusElevation ?? _DefaultFocusElevation;
            double hoverElevation = this.HoverElevation ?? floatingActionButtonTheme.HoverElevation ?? _DefaultHoverElevation;
            double disabledElevation = this.DisabledElevation ?? floatingActionButtonTheme.DisabledElevation ?? elevation;
            double highlightElevation = this.HighlightElevation ?? floatingActionButtonTheme.HighlightElevation ?? _DefaultHighlightElevation;
            MaterialTapTargetSize materialTapTargetSize = this.MaterialTapTargetSize ?? theme.MaterialTapTargetSize;
            TextStyle textStyle = theme.TextTheme.Button.CopyWith(color: foregroundColor, letterSpacing: 1.2);
            ShapeBorder shape = this.Shape ?? floatingActionButtonTheme.Shape ?? (IsExtended ? _DefaultExtendedShape : _DefaultShape);
            Widget result = new RawMaterialButton(onPressed: OnPressed, elevation: elevation, focusElevation: focusElevation, hoverElevation: hoverElevation, highlightElevation: highlightElevation, disabledElevation: disabledElevation, constraints: _SizeConstraints, materialTapTargetSize: materialTapTargetSize, fillColor: backgroundColor, focusColor: focusColor, hoverColor: hoverColor, splashColor: splashColor, textStyle: textStyle, shape: shape, clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, child: Child);
            if (Tooltip != null)
            {
                result = new Tooltip(message: Tooltip, child: result);
            }

            if (HeroTag != null)
            {
                result = new Hero(tag: HeroTag, child: result);
            }

            return new MergeSemantics(child: result);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new ObjectFlagProperty<VoidCallback>("onPressed", OnPressed, ifNull: "disabled"));
            properties.Add(new StringProperty("tooltip", Tooltip, defaultValue: null));
            properties.Add(new ColorProperty("foregroundColor", ForegroundColor, defaultValue: null));
            properties.Add(new ColorProperty("backgroundColor", BackgroundColor, defaultValue: null));
            properties.Add(new ColorProperty("focusColor", FocusColor, defaultValue: null));
            properties.Add(new ColorProperty("hoverColor", HoverColor, defaultValue: null));
            properties.Add(new ColorProperty("splashColor", SplashColor, defaultValue: null));
            properties.Add(new ObjectFlagProperty<object>("heroTag", HeroTag, ifPresent: "hero"));
            properties.Add(new DoubleProperty("elevation", Elevation, defaultValue: null));
            properties.Add(new DoubleProperty("focusElevation", FocusElevation, defaultValue: null));
            properties.Add(new DoubleProperty("hoverElevation", HoverElevation, defaultValue: null));
            properties.Add(new DoubleProperty("highlightElevation", HighlightElevation, defaultValue: null));
            properties.Add(new DoubleProperty("disabledElevation", DisabledElevation, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode, defaultValue: null));
            properties.Add(new FlagProperty("isExtended", value: IsExtended, ifTrue: "extended"));
            properties.Add(new DiagnosticsProperty<MaterialTapTargetSize>("materialTapTargetSize", MaterialTapTargetSize, defaultValue: null));
        }



    }


    public class _ChildOverflowBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _ChildOverflowBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

        public new FlutterSDK.Material.Floatingactionbutton._RenderChildOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderChildOverflowBox(textDirection: BasicDefaultClass.Directionality.Of(context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Floatingactionbutton._RenderChildOverflowBox renderObject)
        {
            renderObject.TextDirection = BasicDefaultClass.Directionality.Of(context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.TextDirection = BasicDefaultClass.Directionality.Of(context);
        }



    }


    public class _RenderChildOverflowBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
    {
        public _RenderChildOverflowBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), TextDirection textDirection = default(TextDirection))
        : base(child: child, alignment: AlignmentDefaultClass.Alignment.Center, textDirection: textDirection)
        {

        }

        public new double ComputeMinIntrinsicWidth(double height) => 0.0;



        public new double ComputeMinIntrinsicHeight(double width) => 0.0;



        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            if (Child != null)
            {
                Child.Layout(new BoxConstraints(), parentUsesSize: true);
                Size = new Size(Dart.Math.MathDefaultClass.Max(constraints.MinWidth, Dart.Math.MathDefaultClass.Min(constraints.MaxWidth, Child.Size.Width)), Dart.Math.MathDefaultClass.Max(constraints.MinHeight, Dart.Math.MathDefaultClass.Min(constraints.MaxHeight, Child.Size.Height)));
                AlignChild();
            }
            else
            {
                Size = constraints.Biggest;
            }

        }



    }

}
