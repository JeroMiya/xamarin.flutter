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
namespace FlutterSDK.Material.Outlinebutton
{
    internal static class OutlinebuttonDefaultClass
    {
        public static TimeSpan _KPressDuration = default(TimeSpan);
        public static TimeSpan _KElevationDuration = default(TimeSpan);
    }

    /// <Summary>
    /// Similar to a [FlatButton] with a thin grey rounded rectangle border.
    ///
    /// The outline button's border shape is defined by [shape]
    /// and its appearance is defined by [borderSide], [disabledBorderColor],
    /// and [highlightedBorderColor]. By default the border is a one pixel
    /// wide grey rounded rectangle that does not change when the button is
    /// pressed or disabled. By default the button's background is transparent.
    ///
    /// If the [onPressed] or [onLongPress] callbacks are null, then the button will be disabled and by
    /// default will resemble a flat button in the [disabledColor].
    ///
    /// The button's [highlightElevation], which defines the size of the
    /// drop shadow when the button is pressed, is 0.0 (no shadow) by default.
    /// If [highlightElevation] is given a value greater than 0.0 then the button
    /// becomes a cross between [RaisedButton] and [FlatButton]: a bordered
    /// button whose elevation increases and whose background becomes opaque
    /// when the button is pressed.
    ///
    /// If you want an ink-splash effect for taps, but don't want to use a button,
    /// consider using [InkWell] directly.
    ///
    /// Outline buttons have a minimum size of 88.0 by 36.0 which can be overridden
    /// with [ButtonTheme].
    ///
    /// See also:
    ///
    ///  * [RaisedButton], a filled material design button with a shadow.
    ///  * [FlatButton], a material design button without a shadow.
    ///  * [DropdownButton], a button that shows options to select from.
    ///  * [FloatingActionButton], the round button in material applications.
    ///  * [IconButton], to create buttons that just contain icons.
    ///  * [InkWell], which implements the ink splash part of a flat button.
    ///  * <https://material.io/design/components/buttons.html>
    /// </Summary>
    public class OutlineButton : FlutterSDK.Material.Materialbutton.MaterialButton
    {
        #region constructors
        public OutlineButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double highlightElevation = default(double), FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterBinding.UI.Color disabledBorderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightedBorderColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, onPressed: onPressed, onLongPress: onLongPress, textTheme: textTheme, textColor: textColor, disabledTextColor: disabledTextColor, color: color, focusColor: focusColor, hoverColor: hoverColor, highlightColor: highlightColor, splashColor: splashColor, highlightElevation: highlightElevation, padding: padding, visualDensity: visualDensity, shape: shape, clipBehavior: clipBehavior, focusNode: focusNode, autofocus: autofocus, child: child)
    
}
    public static OutlineButton Icon(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double highlightElevation = default(double), FlutterBinding.UI.Color highlightedBorderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledBorderColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = default(bool), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))

}
#endregion

#region fields
public virtual FlutterBinding.UI.Color HighlightedBorderColor { get; set; }
public virtual FlutterBinding.UI.Color DisabledBorderColor { get; set; }
public virtual FlutterSDK.Painting.Borders.BorderSide BorderSide { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    ButtonThemeData buttonTheme = ButtonthemeDefaultClass.ButtonTheme.Of(context);
    return new _OutlineButton(onPressed: OnPressed, onLongPress: OnLongPress, brightness: buttonTheme.GetBrightness(this), textTheme: TextTheme, textColor: buttonTheme.GetTextColor(this), disabledTextColor: buttonTheme.GetDisabledTextColor(this), color: Color, focusColor: buttonTheme.GetFocusColor(this), hoverColor: buttonTheme.GetHoverColor(this), highlightColor: buttonTheme.GetHighlightColor(this), splashColor: buttonTheme.GetSplashColor(this), highlightElevation: buttonTheme.GetHighlightElevation(this), borderSide: BorderSide, disabledBorderColor: DisabledBorderColor, highlightedBorderColor: HighlightedBorderColor ?? buttonTheme.ColorScheme.Primary, padding: buttonTheme.GetPadding(this), visualDensity: VisualDensity, shape: buttonTheme.GetShape(this), clipBehavior: ClipBehavior, focusNode: FocusNode, child: Child);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<BorderSide>("borderSide", BorderSide, defaultValue: null));
    properties.Add(new ColorProperty("disabledBorderColor", DisabledBorderColor, defaultValue: null));
    properties.Add(new ColorProperty("highlightedBorderColor", HighlightedBorderColor, defaultValue: null));
}



#endregion
}


public class _OutlineButtonWithIcon : FlutterSDK.Material.Outlinebutton.OutlineButton, IMaterialButtonWithIconMixin
{
    #region constructors
    public _OutlineButtonWithIcon(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double highlightElevation = default(double), FlutterBinding.UI.Color highlightedBorderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledBorderColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, onPressed: onPressed, onLongPress: onLongPress, textTheme: textTheme, textColor: textColor, disabledTextColor: disabledTextColor, color: color, focusColor: focusColor, hoverColor: hoverColor, highlightColor: highlightColor, splashColor: splashColor, highlightElevation: highlightElevation, disabledBorderColor: disabledBorderColor, highlightedBorderColor: highlightedBorderColor, borderSide: borderSide, padding: padding, visualDensity: visualDensity, shape: shape, clipBehavior: clipBehavior, focusNode: focusNode, autofocus: autofocus, child: new Row(mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { icon, new SizedBox(width: 8.0), label }))

}
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class _OutlineButton : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public _OutlineButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), Brightness brightness = default(Brightness), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double highlightElevation = default(double), FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterBinding.UI.Color disabledBorderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightedBorderColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key)

}
#endregion

#region fields
public virtual VoidCallback OnPressed { get; set; }
public virtual VoidCallback OnLongPress { get; set; }
public virtual Brightness Brightness { get; set; }
public virtual FlutterSDK.Material.Buttontheme.ButtonTextTheme TextTheme { get; set; }
public virtual FlutterBinding.UI.Color TextColor { get; set; }
public virtual FlutterBinding.UI.Color DisabledTextColor { get; set; }
public virtual FlutterBinding.UI.Color Color { get; set; }
public virtual FlutterBinding.UI.Color SplashColor { get; set; }
public virtual FlutterBinding.UI.Color FocusColor { get; set; }
public virtual FlutterBinding.UI.Color HoverColor { get; set; }
public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
public virtual double HighlightElevation { get; set; }
public virtual FlutterSDK.Painting.Borders.BorderSide BorderSide { get; set; }
public virtual FlutterBinding.UI.Color DisabledBorderColor { get; set; }
public virtual FlutterBinding.UI.Color HighlightedBorderColor { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
public virtual bool Autofocus { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Material.Outlinebutton._OutlineButtonState CreateState() => new _OutlineButtonState();


#endregion
}


public class _OutlineButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Outlinebutton._OutlineButton>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _OutlineButtonState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _FillAnimation { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _ElevationAnimation { get; set; }
    internal virtual bool _Pressed { get; set; }
    internal virtual FlutterBinding.UI.Color _OutlineColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _Controller = new AnimationController(duration: OutlinebuttonDefaultClass._KPressDuration, vsync: this);
        _FillAnimation = new CurvedAnimation(parent: _Controller, curve: new Interval(0.0, 0.5, curve: CurvesDefaultClass.Curves.FastOutSlowIn));
        _ElevationAnimation = new CurvedAnimation(parent: _Controller, curve: new Interval(0.5, 0.5), reverseCurve: new Interval(1.0, 1.0));
    }




    public new void DidUpdateWidget(FlutterSDK.Material.Outlinebutton._OutlineButton oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        if (_Pressed && !Widget.Enabled)
        {
            _Pressed = false;
            _Controller.Reverse();
        }

    }




    private void _HandleHighlightChanged(bool value)
    {
        if (_Pressed == value) return;
        SetState(() =>
        {
            _Pressed = value;
            if (value) _Controller.Forward(); else _Controller.Reverse();
        }
        );
    }




    public new void Dispose()
    {
        _Controller.Dispose();
        base.Dispose();
    }




    private Color _GetFillColor()
    {
        if (Widget.HighlightElevation == null || Widget.HighlightElevation == 0.0) return ColorsDefaultClass.Colors.Transparent;
        Color color = Widget.Color ?? ThemeDefaultClass.Theme.Of(Context).CanvasColor;
        Tween<Color> colorTween = new ColorTween(begin: color.WithAlpha(0x00), end: color.WithAlpha(0xFF));
        return colorTween.Evaluate(_FillAnimation);
    }




    private FlutterSDK.Painting.Borders.BorderSide _GetOutline()
    {
        if (Widget.BorderSide?.Style == BorderStyle.None) return Widget.BorderSide;
        Color themeColor = ThemeDefaultClass.Theme.Of(Context).ColorScheme.OnSurface.WithOpacity(0.12);
        return new BorderSide(color: _OutlineColor ?? themeColor, width: Widget.BorderSide?.Width ?? 1.0);
    }




    private double _GetHighlightElevation()
    {
        if (Widget.HighlightElevation == null || Widget.HighlightElevation == 0.0) return 0.0;
        return new Tween<double>(begin: 0.0, end: Widget.HighlightElevation).Evaluate(_ElevationAnimation);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        return new AnimatedBuilder(animation: _Controller, builder: (BuildContext context, Widget child) =>
        {
            return new RaisedButton(textColor: Widget.TextColor, disabledTextColor: Widget.DisabledTextColor, color: _GetFillColor(), splashColor: Widget.SplashColor, focusColor: Widget.FocusColor, hoverColor: Widget.HoverColor, highlightColor: Widget.HighlightColor, disabledColor: ColorsDefaultClass.Colors.Transparent, onPressed: Widget.OnPressed, onLongPress: Widget.OnLongPress, elevation: 0.0, disabledElevation: 0.0, focusElevation: 0.0, hoverElevation: 0.0, highlightElevation: _GetHighlightElevation(), onHighlightChanged: _HandleHighlightChanged, padding: Widget.Padding, visualDensity: Widget.VisualDensity ?? theme.VisualDensity, shape: new _OutlineBorder(shape: Widget.Shape, side: _GetOutline()), clipBehavior: Widget.ClipBehavior, focusNode: Widget.FocusNode, animationDuration: OutlinebuttonDefaultClass._KElevationDuration, child: Widget.Child);
        }
        );
    }



    #endregion
}


public class _OutlineBorder : FlutterSDK.Painting.Borders.ShapeBorder, IMaterialStateProperty<FlutterSDK.Painting.Borders.ShapeBorder>
{
    #region constructors
    public _OutlineBorder(FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Borders.BorderSide side = default(FlutterSDK.Painting.Borders.BorderSide))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual FlutterSDK.Painting.Borders.BorderSide Side { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Painting.Borders.ShapeBorder Scale(double t)
{
    return new _OutlineBorder(shape: Shape.Scale(t), side: Side.Scale(t));
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
{

    if (a is _OutlineBorder)
    {
        return new _OutlineBorder(side: BordersDefaultClass.BorderSide.Lerp(((_OutlineBorder)a).Side, Side, t), shape: BordersDefaultClass.ShapeBorder.Lerp(((_OutlineBorder)a).Shape, Shape, t));
    }

    return base.LerpFrom(a, t);
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
{

    if (b is _OutlineBorder)
    {
        return new _OutlineBorder(side: BordersDefaultClass.BorderSide.Lerp(Side, ((_OutlineBorder)b).Side, t), shape: BordersDefaultClass.ShapeBorder.Lerp(Shape, ((_OutlineBorder)b).Shape, t));
    }

    return base.LerpTo(b, t);
}




public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return Shape.GetInnerPath(rect.Deflate(Side.Width), textDirection: textDirection);
}




public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return Shape.GetOuterPath(rect, textDirection: textDirection);
}




public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    switch (Side.Style) { case BorderStyle.None: break; case BorderStyle.Solid: canvas.DrawPath(Shape.GetOuterPath(rect, textDirection: textDirection), Side.ToPaint()); }
}




public new bool Equals(@Object other)
{
    if (Dart:coreDefaultClass.Identical(this, other))return true;
    if (other.GetType() != GetType()) return false;
    return other is _OutlineBorder && other.Side == Side && other.Shape == Shape;
}




public new FlutterSDK.Painting.Borders.ShapeBorder Resolve(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states)
{
    return new _OutlineBorder(shape: Shape, side: Side.CopyWith(color: MaterialstateDefaultClass.MaterialStateProperty.ResolveAs(Side.Color, states)));
}



#endregion
}

}
