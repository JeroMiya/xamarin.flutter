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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
        #region constructors
        public SnackBarAction(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), string label = default(string), VoidCallback onPressed = default(VoidCallback))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual FlutterBinding.UI.Color TextColor { get; set; }
    public virtual FlutterBinding.UI.Color DisabledTextColor { get; set; }
    public virtual string Label { get; set; }
    public virtual VoidCallback OnPressed { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Material.Snackbar._SnackBarActionState CreateState() => new _SnackBarActionState();


    #endregion
}


public class _SnackBarActionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Snackbar.SnackBarAction>
{
    #region constructors
    public _SnackBarActionState()
    { }
    #endregion

    #region fields
    internal virtual bool _HaveTriggeredAction { get; set; }
    #endregion

    #region methods

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



    #endregion
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
    #region constructors
    public SnackBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Material.Snackbartheme.SnackBarBehavior behavior = default(FlutterSDK.Material.Snackbartheme.SnackBarBehavior), FlutterSDK.Material.Snackbar.SnackBarAction action = default(FlutterSDK.Material.Snackbar.SnackBarAction), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), VoidCallback onVisible = default(VoidCallback))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
public virtual double Elevation { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual FlutterSDK.Material.Snackbartheme.SnackBarBehavior Behavior { get; set; }
public virtual FlutterSDK.Material.Snackbar.SnackBarAction Action { get; set; }
public virtual TimeSpan Duration { get; set; }
public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
public virtual VoidCallback OnVisible { get; set; }
#endregion

#region methods

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


#endregion
}


public class _SnackBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Snackbar.SnackBar>
{
    #region constructors
    public _SnackBarState()
    { }
    #endregion

    #region fields
    internal virtual bool _WasVisible { get; set; }
    #endregion

    #region methods

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
        Color themeBackgroundColor = isThemeDark ? colorScheme.OnSurface : Dart:uiDefaultClass.Color.AlphaBlend(colorScheme.OnSurface.WithOpacity(0.80), colorScheme.Surface);
        ThemeData inverseTheme = new ThemeData(brightness: brightness, backgroundColor: themeBackgroundColor, colorScheme: new ColorScheme(primary: colorScheme.OnPrimary, primaryVariant: colorScheme.OnPrimary, secondary: isThemeDark ? colorScheme.PrimaryVariant : colorScheme.Secondary, secondaryVariant: colorScheme.OnSecondary, surface: colorScheme.OnSurface, background: themeBackgroundColor, error: colorScheme.OnError, onPrimary: colorScheme.Primary, onSecondary: colorScheme.Secondary, onSurface: colorScheme.Surface, onBackground: colorScheme.Background, onError: colorScheme.Error, brightness: brightness), snackBarTheme: snackBarTheme);
        TextStyle contentTextStyle = snackBarTheme.ContentTextStyle ?? inverseTheme.TextTheme.Subtitle1;
        SnackBarBehavior snackBarBehavior = Widget.Behavior ?? snackBarTheme.Behavior ?? SnackBarBehavior.Fixed;
        bool isFloatingSnackBar = snackBarBehavior == SnackBarBehavior.Floating;
        double snackBarPadding = isFloatingSnackBar ? 16.0 : 24.0;
        CurvedAnimation heightAnimation = new CurvedAnimation(parent: Widget.Animation, curve: SnackbarDefaultClass._SnackBarHeightCurve);
        CurvedAnimation fadeInAnimation = new CurvedAnimation(parent: Widget.Animation, curve: SnackbarDefaultClass._SnackBarFadeInCurve);
        CurvedAnimation fadeOutAnimation = new CurvedAnimation(parent: Widget.Animation, curve: SnackbarDefaultClass._SnackBarFadeOutCurve, reverseCurve: new Threshold(0.0));
        Widget snackBar = new SafeArea(top: false, bottom: !isFloatingSnackBar, child: new Row(crossAxisAlignment: CrossAxisAlignment.Center, children: new List<Widget>() { new SizedBox(width: snackBarPadding), new Expanded(child: new Container(padding: EdgeInsets.Symmetric(vertical: SnackbarDefaultClass._SingleLineVerticalPadding), child: new DefaultTextStyle(style: contentTextStyle, child: Widget.Content))), }));
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
        , child: new Dismissible(key: new Key("dismissible"), direction: DismissDirection.Down, resizeDuration: null, onDismissed: (DismissDirection direction) =>
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



    #endregion
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
