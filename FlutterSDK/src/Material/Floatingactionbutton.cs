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
        public static FloatingActionButton Extended(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string tooltip = default(string), FlutterBinding.UI.Color foregroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), @Object heroTag = default(@Object), double elevation = default(double), double focusElevation = default(double), double hoverElevation = default(double), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double highlightElevation = default(double), double disabledElevation = default(double), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool isExtended = true, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new FloatingActionButton(key: key); instance.Tooltip = tooltip;
            instance.ForegroundColor = foregroundColor;
            instance.BackgroundColor = backgroundColor;
            instance.FocusColor = focusColor;
            instance.HoverColor = hoverColor;
            instance.HeroTag = heroTag;
            instance.Elevation = elevation;
            instance.FocusElevation = focusElevation;
            instance.HoverElevation = hoverElevation;
            instance.SplashColor = splashColor;
            instance.HighlightElevation = highlightElevation;
            instance.DisabledElevation = disabledElevation;
            instance.OnPressed = onPressed;
            instance.Shape = shape;
            instance.IsExtended = isExtended;
            instance.MaterialTapTargetSize = materialTapTargetSize;
            instance.ClipBehavior = clipBehavior;
            instance.FocusNode = focusNode;
            instance.Autofocus = autofocus;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual string Tooltip { get; set; }
        public virtual FlutterBinding.UI.Color ForegroundColor { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        public virtual @Object HeroTag { get; set; }
        public virtual VoidCallback OnPressed { get; set; }
        public virtual double Elevation { get; set; }
        public virtual double FocusElevation { get; set; }
        public virtual double HoverElevation { get; set; }
        public virtual double HighlightElevation { get; set; }
        public virtual double DisabledElevation { get; set; }
        public virtual bool Mini { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual bool IsExtended { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool Autofocus { get; set; }
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
                Size = new Size(Math.Dart:mathDefaultClass.Max(constraints.MinWidth, Math.Dart:mathDefaultClass.Min(constraints.MaxWidth, Child.Size.Width)), Math.Dart:mathDefaultClass.Max(constraints.MinHeight, Math.Dart:mathDefaultClass.Min(constraints.MaxHeight, Child.Size.Height)));
                AlignChild();
            }
            else
            {
                Size = constraints.Biggest;
            }

        }



    }

}
