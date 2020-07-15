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
namespace FlutterSDK.Material.Tooltip
{
    internal static class TooltipDefaultClass
    {
    }

    /// <Summary>
    /// A material design tooltip.
    ///
    /// Tooltips provide text labels that help explain the function of a button or
    /// other user interface action. Wrap the button in a [Tooltip] widget to
    /// show a label when the widget long pressed (or when the user takes some
    /// other appropriate action).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=EeEfD5fI-5Q}
    ///
    /// Many widgets, such as [IconButton], [FloatingActionButton], and
    /// [PopupMenuButton] have a `tooltip` property that, when non-null, causes the
    /// widget to include a [Tooltip] in its build.
    ///
    /// Tooltips improve the accessibility of visual widgets by proving a textual
    /// representation of the widget, which, for example, can be vocalized by a
    /// screen reader.
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/components/tooltips.html>
    ///  * [TooltipTheme] or [ThemeData.tooltipTheme]
    /// </Summary>
    public class Tooltip : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Tooltip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string message = default(string), double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double verticalOffset = default(double), bool preferBelow = default(bool), bool excludeFromSemantics = default(bool), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), TimeSpan waitDuration = default(TimeSpan), TimeSpan showDuration = default(TimeSpan), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual string Message { get; set; }
    public virtual double Height { get; set; }
    public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
    public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
    public virtual double VerticalOffset { get; set; }
    public virtual bool PreferBelow { get; set; }
    public virtual bool ExcludeFromSemantics { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
    public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
    public virtual TimeSpan WaitDuration { get; set; }
    public virtual TimeSpan ShowDuration { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Material.Tooltip._TooltipState CreateState() => new _TooltipState();



    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new StringProperty("message", Message, showName: false));
        properties.Add(new DoubleProperty("height", Height, defaultValue: null));
        properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
        properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("margin", Margin, defaultValue: null));
        properties.Add(new DoubleProperty("vertical offset", VerticalOffset, defaultValue: null));
        properties.Add(new FlagProperty("position", value: PreferBelow, ifTrue: "below", ifFalse: "above", showName: true, defaultValue: null));
        properties.Add(new FlagProperty("semantics", value: ExcludeFromSemantics, ifTrue: "excluded", showName: true, defaultValue: null));
        properties.Add(new DiagnosticsProperty<TimeSpan>("wait duration", WaitDuration, defaultValue: null));
        properties.Add(new DiagnosticsProperty<TimeSpan>("show duration", ShowDuration, defaultValue: null));
    }



    #endregion
}


public class _TooltipState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tooltip.Tooltip>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _TooltipState()
    { }
    #endregion

    #region fields
    internal virtual double _DefaultTooltipHeight { get; set; }
    internal virtual double _DefaultVerticalOffset { get; set; }
    internal virtual bool _DefaultPreferBelow { get; set; }
    internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _DefaultPadding { get; set; }
    internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _DefaultMargin { get; set; }
    internal virtual TimeSpan _FadeInDuration { get; set; }
    internal virtual TimeSpan _FadeOutDuration { get; set; }
    internal virtual TimeSpan _DefaultShowDuration { get; set; }
    internal virtual TimeSpan _DefaultWaitDuration { get; set; }
    internal virtual bool _DefaultExcludeFromSemantics { get; set; }
    public virtual double Height { get; set; }
    public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
    public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
    public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
    public virtual double VerticalOffset { get; set; }
    public virtual bool PreferBelow { get; set; }
    public virtual bool ExcludeFromSemantics { get; set; }
    internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
    internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _Entry { get; set; }
    internal virtual Timer _HideTimer { get; set; }
    internal virtual Timer _ShowTimer { get; set; }
    public virtual TimeSpan ShowDuration { get; set; }
    public virtual TimeSpan WaitDuration { get; set; }
    internal virtual bool _MouseIsConnected { get; set; }
    internal virtual bool _LongPressActivated { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _MouseIsConnected = BindingDefaultClass.RendererBinding.Instance.MouseTracker.MouseIsConnected;
        _Controller = new AnimationController(duration: _FadeInDuration, reverseDuration: _FadeOutDuration, vsync: this);
        new AnimationController(duration: _FadeInDuration, reverseDuration: _FadeOutDuration, vsync: this).AddStatusListener(_HandleStatusChanged);
        BindingDefaultClass.RendererBinding.Instance.MouseTracker.AddListener(_HandleMouseTrackerChange);
        BindingDefaultClass.GestureBinding.Instance.PointerRouter.AddGlobalRoute(_HandlePointerEvent);
    }




    private void _HandleMouseTrackerChange()
    {
        if (!Mounted)
        {
            return;
        }

        bool mouseIsConnected = BindingDefaultClass.RendererBinding.Instance.MouseTracker.MouseIsConnected;
        if (mouseIsConnected != _MouseIsConnected)
        {
            SetState(() =>
            {
                _MouseIsConnected = mouseIsConnected;
            }
            );
        }

    }




    private void _HandleStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
    {
        if (status == AnimationStatus.Dismissed)
        {
            _HideTooltip(immediately: true);
        }

    }




    private void _HideTooltip(bool immediately = false)
    {
        _ShowTimer?.Cancel();
        _ShowTimer = null;
        if (immediately)
        {
            _RemoveEntry();
            return;
        }

        if (_LongPressActivated)
        {
            _HideTimer = (_HideTimer == null ? new Timer(ShowDuration, _Controller.Reverse) : _HideTimer);
        }
        else
        {
            _Controller.Reverse();
        }

        _LongPressActivated = false;
    }




    private void _ShowTooltip(bool immediately = false)
    {
        _HideTimer?.Cancel();
        _HideTimer = null;
        if (immediately)
        {
            EnsureTooltipVisible();
            return;
        }

        _ShowTimer = (_ShowTimer == null ? new Timer(WaitDuration, EnsureTooltipVisible) : _ShowTimer);
    }




    /// <Summary>
    /// Shows the tooltip if it is not already visible.
    ///
    /// Returns `false` when the tooltip was already visible.
    /// </Summary>
    public virtual bool EnsureTooltipVisible()
    {
        _ShowTimer?.Cancel();
        _ShowTimer = null;
        if (_Entry != null)
        {
            _HideTimer?.Cancel();
            _HideTimer = null;
            _Controller.Forward();
            return false;
        }

        _CreateNewEntry();
        _Controller.Forward();
        return true;
    }




    private void _CreateNewEntry()
    {
        RenderBox box = Context.FindRenderObject() as RenderBox;
        Offset target = box.LocalToGlobal(box.Size.Center(Dart: uiDefaultClass.Offset.Zero));
        Widget overlay = new Directionality(textDirection: BasicDefaultClass.Directionality.Of(Context), child: new _TooltipOverlay(message: Widget.Message, height: Height, padding: Padding, margin: Margin, decoration: Decoration, textStyle: TextStyle, animation: new CurvedAnimation(parent: _Controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn), target: target, verticalOffset: VerticalOffset, preferBelow: PreferBelow));
        _Entry = new OverlayEntry(builder: (BuildContext context) => =>overlay);
        OverlayDefaultClass.Overlay.Of(Context, debugRequiredFor: Widget).Insert(_Entry);
        SemanticsserviceDefaultClass.SemanticsService.Tooltip(Widget.Message);
    }




    private void _RemoveEntry()
    {
        _HideTimer?.Cancel();
        _HideTimer = null;
        _ShowTimer?.Cancel();
        _ShowTimer = null;
        _Entry?.Remove();
        _Entry = null;
    }




    private void _HandlePointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
    {
        if (_Entry == null)
        {
            return;
        }

        if (@event is PointerUpEvent || @event is PointerCancelEvent)
        {
            _HideTooltip();
        }
        else if (@event is PointerDownEvent)
        {
            _HideTooltip(immediately: true);
        }

    }




    public new void Deactivate()
    {
        if (_Entry != null)
        {
            _HideTooltip(immediately: true);
        }

        base.Deactivate();
    }




    public new void Dispose()
    {
        BindingDefaultClass.GestureBinding.Instance.PointerRouter.RemoveGlobalRoute(_HandlePointerEvent);
        BindingDefaultClass.RendererBinding.Instance.MouseTracker.RemoveListener(_HandleMouseTrackerChange);
        if (_Entry != null) _RemoveEntry();
        _Controller.Dispose();
        base.Dispose();
    }




    private void _HandleLongPress()
    {
        _LongPressActivated = true;
        bool tooltipCreated = EnsureTooltipVisible();
        if (tooltipCreated) FeedbackDefaultClass.Feedback.ForLongPress(Context);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {

        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        TooltipThemeData tooltipTheme = TooltipthemeDefaultClass.TooltipTheme.Of(context);
        TextStyle defaultTextStyle = default(TextStyle);
        BoxDecoration defaultDecoration = default(BoxDecoration);
        if (theme.Brightness == Brightness.Dark)
        {
            defaultTextStyle = theme.TextTheme.BodyText2.CopyWith(color: ColorsDefaultClass.Colors.Black);
            defaultDecoration = new BoxDecoration(color: ColorsDefaultClass.Colors.White.WithOpacity(0.9), borderRadius: BorderRadius.All(Radius.Circular(4)));
        }
        else
        {
            defaultTextStyle = theme.TextTheme.BodyText2.CopyWith(color: ColorsDefaultClass.Colors.White);
            defaultDecoration = new BoxDecoration(color: ColorsDefaultClass.Colors.Grey[700].WithOpacity(0.9), borderRadius: BorderRadius.All(Radius.Circular(4)));
        }

        Height = Widget.Height ?? tooltipTheme.Height ?? _DefaultTooltipHeight;
        Padding = Widget.Padding ?? tooltipTheme.Padding ?? _DefaultPadding;
        Margin = Widget.Margin ?? tooltipTheme.Margin ?? _DefaultMargin;
        VerticalOffset = Widget.VerticalOffset ?? tooltipTheme.VerticalOffset ?? _DefaultVerticalOffset;
        PreferBelow = Widget.PreferBelow ?? tooltipTheme.PreferBelow ?? _DefaultPreferBelow;
        ExcludeFromSemantics = Widget.ExcludeFromSemantics ?? tooltipTheme.ExcludeFromSemantics ?? _DefaultExcludeFromSemantics;
        Decoration = Widget.Decoration ?? tooltipTheme.Decoration ?? defaultDecoration;
        TextStyle = Widget.TextStyle ?? tooltipTheme.TextStyle ?? defaultTextStyle;
        WaitDuration = Widget.WaitDuration ?? tooltipTheme.WaitDuration ?? _DefaultWaitDuration;
        ShowDuration = Widget.ShowDuration ?? tooltipTheme.ShowDuration ?? _DefaultShowDuration;
        Widget result = new GestureDetector(behavior: HitTestBehavior.Opaque, onLongPress: _HandleLongPress, excludeFromSemantics: true, child: new Semantics(label: ExcludeFromSemantics ? null : Widget.Message, child: Widget.Child));
        if (_MouseIsConnected)
        {
            result = new MouseRegion(onEnter: (PointerEnterEvent @event) => =>_ShowTooltip(), onExit: (PointerExitEvent @event) => =>_HideTooltip(), child: result);
        }

        return result;
    }



    #endregion
}


/// <Summary>
/// A delegate for computing the layout of a tooltip to be displayed above or
/// bellow a target specified in the global coordinate system.
/// </Summary>
public class _TooltipPositionDelegate : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
{
    #region constructors
    public _TooltipPositionDelegate(FlutterBinding.UI.Offset target = default(FlutterBinding.UI.Offset), double verticalOffset = default(double), bool preferBelow = default(bool))
    : base()

}
#endregion

#region fields
public virtual FlutterBinding.UI.Offset Target { get; set; }
public virtual double VerticalOffset { get; set; }
public virtual bool PreferBelow { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints) => constraints.Loosen();



public new Offset GetPositionForChild(Size size, Size childSize)
{
    return GeometryDefaultClass.PositionDependentBox(size: size, childSize: childSize, target: Target, verticalOffset: VerticalOffset, preferBelow: PreferBelow);
}




public new bool ShouldRelayout(FlutterSDK.Material.Tooltip._TooltipPositionDelegate oldDelegate)
{
    return Target != oldDelegate.Target || VerticalOffset != oldDelegate.VerticalOffset || PreferBelow != oldDelegate.PreferBelow;
}


public new bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate)
{
    return Target != oldDelegate.Target || VerticalOffset != oldDelegate.VerticalOffset || PreferBelow != oldDelegate.PreferBelow;
}



#endregion
}


public class _TooltipOverlay : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _TooltipOverlay(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string message = default(string), double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset target = default(FlutterBinding.UI.Offset), double verticalOffset = default(double), bool preferBelow = default(bool))
    : base(key: key)

}
#endregion

#region fields
public virtual string Message { get; set; }
public virtual double Height { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
public virtual FlutterBinding.UI.Offset Target { get; set; }
public virtual double VerticalOffset { get; set; }
public virtual bool PreferBelow { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return Positioned.Fill(child: new IgnorePointer(child: new CustomSingleChildLayout(@delegate: new _TooltipPositionDelegate(target: Target, verticalOffset: VerticalOffset, preferBelow: PreferBelow), child: new FadeTransition(opacity: Animation, child: new ConstrainedBox(constraints: new BoxConstraints(minHeight: Height), child: new DefaultTextStyle(style: ThemeDefaultClass.Theme.Of(context).TextTheme.BodyText2, child: new Container(decoration: Decoration, padding: Padding, margin: Margin, child: new Center(widthFactor: 1.0, heightFactor: 1.0, child: new Text(Message, style: TextStyle)))))))));
}



#endregion
}

}
