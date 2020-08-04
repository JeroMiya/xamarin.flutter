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
namespace FlutterSDK.Material.Snackbar
{
    internal static class SnackbarDefaultClass
    {
        public static double _SingleLineVerticalPadding = default(double);
        public static TimeSpan _SnackBarTransitionDuration = default(TimeSpan);
        public static TimeSpan _SnackBarDisplayDuration = default(TimeSpan);
        public static FlutterSDK.Animation.Curves.Curve _SnackBarHeightCurve = default(FlutterSDK.Animation.Curves.Curve);
        public static FlutterSDK.Animation.Curves.Curve _SnackBarFadeInCurve = default(FlutterSDK.Animation.Curves.Curve);
        public static FlutterSDK.Animation.Curves.Curve _SnackBarFadeOutCurve = default(FlutterSDK.Animation.Curves.Curve);
    }

    /// <Summary>
    /// A button for a [SnackBar], known as an "action".
    ///
    /// Snack bar actions are always enabled. If you want to disable a snack bar
    /// action, simply don't include it in the snack bar.
    ///
    /// Snack bar actions can only be pressed once. Subsequent presses are ignored.
    ///
    /// See also:
    ///
    ///  * [SnackBar]
    ///  * <https://material.io/design/components/snackbars.html>
    /// </Summary>
    public class SnackBarAction : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates an action for a [SnackBar].
        ///
        /// The [label] and [onPressed] arguments must be non-null.
        /// </Summary>
        public SnackBarAction(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), string label = default(string), VoidCallback onPressed = default(VoidCallback))
        : base(key: key)
        {
            this.TextColor = textColor;
            this.DisabledTextColor = disabledTextColor;
            this.Label = label;
            this.OnPressed = onPressed;
        }
        /// <Summary>
        /// The button label color. If not provided, defaults to [accentColor].
        /// </Summary>
        public virtual FlutterBinding.UI.Color TextColor { get; set; }
        /// <Summary>
        /// The button disabled label color. This color is shown after the
        /// [snackBarAction] is dismissed.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DisabledTextColor { get; set; }
        /// <Summary>
        /// The button label.
        /// </Summary>
        public virtual string Label { get; set; }
        /// <Summary>
        /// The callback to be called when the button is pressed. Must not be null.
        ///
        /// This callback will be called at most once each time this action is
        /// displayed in a [SnackBar].
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }

        public new FlutterSDK.Material.Snackbar._SnackBarActionState CreateState() => new _SnackBarActionState();


    }


    public class _SnackBarActionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Snackbar.SnackBarAction>
    {
        public _SnackBarActionState()
        { }
        internal virtual bool _HaveTriggeredAction { get; set; }

        private void _HandlePressed()
        {
            if (_HaveTriggeredAction) return;
            SetState(() =>
            {
                _HaveTriggeredAction = true;
            }
            );
            Widget.OnPressed();
            ScaffoldDefaultClass.Scaffold.Of(Context).HideCurrentSnackBar(reason: SnackBarClosedReason.Action);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            SnackBarThemeData snackBarTheme = ThemeDefaultClass.Theme.Of(context).SnackBarTheme;
            Color textColor = Widget.TextColor ?? snackBarTheme.ActionTextColor;
            Color disabledTextColor = Widget.DisabledTextColor ?? snackBarTheme.DisabledActionTextColor;
            return new FlatButton(onPressed: _HaveTriggeredAction ? null : _HandlePressed, child: new Text(Widget.Label), textColor: textColor, disabledTextColor: disabledTextColor);
        }



    }


    /// <Summary>
    /// A lightweight message with an optional action which briefly displays at the
    /// bottom of the screen.
    ///
    /// To display a snack bar, call `Scaffold.of(context).showSnackBar()`, passing
    /// an instance of [SnackBar] that describes the message.
    ///
    /// To control how long the [SnackBar] remains visible, specify a [duration].
    ///
    /// A SnackBar with an action will not time out when TalkBack or VoiceOver are
    /// enabled. This is controlled by [AccessibilityFeatures.accessibleNavigation].
    ///
    /// See also:
    ///
    ///  * [Scaffold.of], to obtain the current [ScaffoldState], which manages the
    ///    display and animation of snack bars.
    ///  * [ScaffoldState.showSnackBar], which displays a [SnackBar].
    ///  * [ScaffoldState.removeCurrentSnackBar], which abruptly hides the currently
    ///    displayed snack bar, if any, and allows the next to be displayed.
    ///  * [SnackBarAction], which is used to specify an [action] button to show
    ///    on the snack bar.
    ///  * [SnackBarThemeData], to configure the default property values for
    ///    [SnackBar] widgets.
    ///  * <https://material.io/design/components/snackbars.html>
    /// </Summary>
    public class SnackBar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a snack bar.
        ///
        /// The [content] argument must be non-null. The [elevation] must be null or
        /// non-negative.
        /// </Summary>
        public SnackBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Material.Snackbartheme.SnackBarBehavior behavior = default(FlutterSDK.Material.Snackbartheme.SnackBarBehavior), FlutterSDK.Material.Snackbar.SnackBarAction action = default(FlutterSDK.Material.Snackbar.SnackBarAction), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), VoidCallback onVisible = default(VoidCallback))
        : base(key: key)
        {
            this.Content = content;
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.Shape = shape;
            this.Behavior = behavior;
            this.Action = action;
            this.Duration = duration;
            this.Animation = animation;
            this.OnVisible = onVisible;
        }
        /// <Summary>
        /// The primary content of the snack bar.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
        /// <Summary>
        /// The Snackbar's background color. If not specified it will use
        /// [ThemeData.snackBarTheme.backgroundColor]. If that is not specified
        /// it will default to a dark variation of [ColorScheme.surface] for light
        /// themes, or [ColorScheme.onSurface] for dark themes.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place the snack bar. This controls the size
        /// of the shadow below the snack bar.
        ///
        /// Defines the card's [Material.elevation].
        ///
        /// If this property is null, then [ThemeData.snackBarTheme.elevation] is
        /// used, if that is also null, the default value is 6.0.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The shape of the snack bar's [Material].
        ///
        /// Defines the snack bar's [Material.shape].
        ///
        /// If this property is null then [ThemeData.snackBarTheme.shape] is used.
        /// If that's null then the shape will depend on the [SnackBarBehavior]. For
        /// [SnackBarBehavior.fixed], no overriding shape is specified, so the
        /// [SnackBar] is rectangular. For [SnackBarBehavior.floating], it uses a
        /// [RoundedRectangleBorder] with a circular corner radius of 4.0.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// This defines the behavior and location of the snack bar.
        ///
        /// Defines where a [SnackBar] should appear within a [Scaffold] and how its
        /// location should be adjusted when the scaffold also includes a
        /// [FloatingActionButton] or a [BottomNavigationBar]
        ///
        /// If this property is null, then [ThemeData.snackBarTheme.behavior]
        /// is used. If that is null, then the default is [SnackBarBehavior.fixed].
        /// </Summary>
        public virtual FlutterSDK.Material.Snackbartheme.SnackBarBehavior Behavior { get; set; }
        /// <Summary>
        /// (optional) An action that the user can take based on the snack bar.
        ///
        /// For example, the snack bar might let the user undo the operation that
        /// prompted the snackbar. Snack bars can have at most one action.
        ///
        /// The action should not be "dismiss" or "cancel".
        /// </Summary>
        public virtual FlutterSDK.Material.Snackbar.SnackBarAction Action { get; set; }
        /// <Summary>
        /// The amount of time the snack bar should be displayed.
        ///
        /// Defaults to 4.0s.
        ///
        /// See also:
        ///
        ///  * [ScaffoldState.removeCurrentSnackBar], which abruptly hides the
        ///    currently displayed snack bar, if any, and allows the next to be
        ///    displayed.
        ///  * <https://material.io/design/components/snackbars.html>
        /// </Summary>
        public virtual TimeSpan Duration { get; set; }
        /// <Summary>
        /// The animation driving the entrance and exit of the snack bar.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        /// <Summary>
        /// Called the first time that the snackbar is visible within a [Scaffold].
        /// </Summary>
        public virtual VoidCallback OnVisible { get; set; }

        /// <Summary>
        /// Creates an animation controller useful for driving a snack bar's entrance and exit animation.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController(FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        {
            return new AnimationController(duration: SnackbarDefaultClass._SnackBarTransitionDuration, debugLabel: "SnackBar", vsync: vsync);
        }




        /// <Summary>
        /// Creates a copy of this snack bar but with the animation replaced with the given animation.
        ///
        /// If the original snack bar lacks a key, the newly created snack bar will
        /// use the given fallback key.
        /// </Summary>
        public virtual FlutterSDK.Material.Snackbar.SnackBar WithAnimation(FlutterSDK.Animation.Animation.Animation<double> newAnimation, FlutterSDK.Foundation.Key.Key fallbackKey = default(FlutterSDK.Foundation.Key.Key))
        {
            return new SnackBar(key: Key ?? fallbackKey, content: Content, backgroundColor: BackgroundColor, elevation: Elevation, shape: Shape, behavior: Behavior, action: Action, duration: Duration, animation: newAnimation, onVisible: OnVisible);
        }




        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Snackbar.SnackBar> CreateState() => new _SnackBarState();


    }


    public class _SnackBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Snackbar.SnackBar>
    {
        public _SnackBarState()
        { }
        internal virtual bool _WasVisible { get; set; }

        public new void InitState()
        {
            base.InitState();
            Widget.Animation.AddStatusListener(_OnAnimationStatusChanged);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Snackbar.SnackBar oldWidget)
        {
            if (Widget.Animation != oldWidget.Animation)
            {
                oldWidget.Animation.RemoveStatusListener(_OnAnimationStatusChanged);
                Widget.Animation.AddStatusListener(_OnAnimationStatusChanged);
            }

            base.DidUpdateWidget(oldWidget);
        }




        public new void Dispose()
        {
            Widget.Animation.RemoveStatusListener(_OnAnimationStatusChanged);
            base.Dispose();
        }




        private void _OnAnimationStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus animationStatus)
        {
            switch (animationStatus)
            {
                case AnimationStatus.Dismissed: case AnimationStatus.Forward: case AnimationStatus.Reverse: break;
                case AnimationStatus.Completed:
                    if (Widget.OnVisible != null && !_WasVisible)
                    {
                        Widget.OnVisible();
                    }
                    _WasVisible = true;
            }
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            MediaQueryData mediaQueryData = MediaqueryDefaultClass.MediaQuery.Of(context);

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            ColorScheme colorScheme = theme.ColorScheme;
            SnackBarThemeData snackBarTheme = theme.SnackBarTheme;
            bool isThemeDark = theme.Brightness == Brightness.Dark;
            Brightness brightness = isThemeDark ? Brightness.Light : Brightness.Dark;
            Color themeBackgroundColor = isThemeDark ? colorScheme.OnSurface : Dart.UI.UiDefaultClass.Color.AlphaBlend(colorScheme.OnSurface.WithOpacity(0.80), colorScheme.Surface);
            ThemeData inverseTheme = ThemeData.CreateNew(brightness: brightness, backgroundColor: themeBackgroundColor, colorScheme: new ColorScheme(primary: colorScheme.OnPrimary, primaryVariant: colorScheme.OnPrimary, secondary: isThemeDark ? colorScheme.PrimaryVariant : colorScheme.Secondary, secondaryVariant: colorScheme.OnSecondary, surface: colorScheme.OnSurface, background: themeBackgroundColor, error: colorScheme.OnError, onPrimary: colorScheme.Primary, onSecondary: colorScheme.Secondary, onSurface: colorScheme.Surface, onBackground: colorScheme.Background, onError: colorScheme.Error, brightness: brightness), snackBarTheme: snackBarTheme);
            TextStyle contentTextStyle = snackBarTheme.ContentTextStyle ?? inverseTheme.TextTheme.Subtitle1;
            SnackBarBehavior snackBarBehavior = Widget.Behavior ?? snackBarTheme.Behavior ?? SnackBarBehavior.Fixed;
            bool isFloatingSnackBar = snackBarBehavior == SnackBarBehavior.Floating;
            double snackBarPadding = isFloatingSnackBar ? 16.0 : 24.0;
            CurvedAnimation heightAnimation = new CurvedAnimation(parent: Widget.Animation, curve: SnackbarDefaultClass._SnackBarHeightCurve);
            CurvedAnimation fadeInAnimation = new CurvedAnimation(parent: Widget.Animation, curve: SnackbarDefaultClass._SnackBarFadeInCurve);
            CurvedAnimation fadeOutAnimation = new CurvedAnimation(parent: Widget.Animation, curve: SnackbarDefaultClass._SnackBarFadeOutCurve, reverseCurve: new Threshold(0.0));
            Widget snackBar = new SafeArea(top: false, bottom: !isFloatingSnackBar, child: new Row(crossAxisAlignment: CrossAxisAlignment.Center, children: new List<Widget>() { new SizedBox(width: snackBarPadding), new Expanded(child: new Container(padding: EdgeInsets.Symmetric(vertical: SnackbarDefaultClass._SingleLineVerticalPadding), child: new DefaultTextStyle(style: contentTextStyle, child: Widget.Content))) }));
            double elevation = Widget.Elevation ?? snackBarTheme.Elevation ?? 6.0;
            Color backgroundColor = Widget.BackgroundColor ?? snackBarTheme.BackgroundColor ?? inverseTheme.BackgroundColor;
            ShapeBorder shape = Widget.Shape ?? snackBarTheme.Shape ?? (isFloatingSnackBar ? new RoundedRectangleBorder(borderRadius: BorderRadius.Circular(4.0)) : null);
            snackBar = new Material(shape: shape, elevation: elevation, color: backgroundColor, child: new Theme(data: inverseTheme, child: mediaQueryData.AccessibleNavigation ? snackBar : new FadeTransition(opacity: fadeOutAnimation, child: snackBar)));
            if (isFloatingSnackBar)
            {
                snackBar = new Padding(padding: EdgeInsets.FromLTRB(15.0, 5.0, 15.0, 10.0), child: snackBar);
            }

            snackBar = new Semantics(container: true, liveRegion: true, onDismiss: () =>
            {
                ScaffoldDefaultClass.Scaffold.Of(context).RemoveCurrentSnackBar(reason: SnackBarClosedReason.Dismiss);
            }
            , child: new Dismissible(key: Key.CreateNew("dismissible"), direction: DismissDirection.Down, resizeDuration: null, onDismissed: (DismissDirection direction) =>
            {
                ScaffoldDefaultClass.Scaffold.Of(context).RemoveCurrentSnackBar(reason: SnackBarClosedReason.Swipe);
            }
            , child: snackBar));
            Widget snackBarTransition = default(Widget);
            if (mediaQueryData.AccessibleNavigation)
            {
                snackBarTransition = snackBar;
            }
            else if (isFloatingSnackBar)
            {
                snackBarTransition = new FadeTransition(opacity: fadeInAnimation, child: snackBar);
            }
            else
            {
                snackBarTransition = new AnimatedBuilder(animation: heightAnimation, builder: (BuildContext context, Widget child) =>
                {
                    return new Align(alignment: AlignmentDefaultClass.AlignmentDirectional.TopStart, heightFactor: heightAnimation.Value, child: child);
                }
                , child: snackBar);
            }

            return new ClipRect(child: snackBarTransition);
        }



    }


    /// <Summary>
    /// Specify how a [SnackBar] was closed.
    ///
    /// The [ScaffoldState.showSnackBar] function returns a
    /// [ScaffoldFeatureController]. The value of the controller's closed property
    /// is a Future that resolves to a SnackBarClosedReason. Applications that need
    /// to know how a snackbar was closed can use this value.
    ///
    /// Example:
    ///
    /// ```dart
    /// Scaffold.of(context).showSnackBar(
    ///   SnackBar( ... )
    /// ).closed.then((SnackBarClosedReason reason) {
    ///    ...
    /// });
    /// ```
    /// </Summary>
    public enum SnackBarClosedReason
    {

        /// <Summary>
        /// The snack bar was closed after the user tapped a [SnackBarAction].
        /// </Summary>
        Action,
        /// <Summary>
        /// The snack bar was closed through a [SemanticAction.dismiss].
        /// </Summary>
        Dismiss,
        /// <Summary>
        /// The snack bar was closed by a user's swipe.
        /// </Summary>
        Swipe,
        /// <Summary>
        /// The snack bar was closed by the [ScaffoldFeatureController] close callback
        /// or by calling [ScaffoldState.hideCurrentSnackBar] directly.
        /// </Summary>
        Hide,
        /// <Summary>
        /// The snack bar was closed by an call to [ScaffoldState.removeCurrentSnackBar].
        /// </Summary>
        Remove,
        /// <Summary>
        /// The snack bar was closed because its timer expired.
        /// </Summary>
        Timeout,
    }

}
