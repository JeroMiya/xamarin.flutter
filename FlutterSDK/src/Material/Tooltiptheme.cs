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
namespace FlutterSDK.Material.Tooltiptheme
{
    internal static class TooltipthemeDefaultClass
    {
    }

    /// <Summary>
    /// Defines the visual properties of [Tooltip] widgets.
    ///
    /// Used by [TooltipTheme] to control the visual properties of tooltips in a
    /// widget subtree.
    ///
    /// To obtain this configuration, use [TooltipTheme.of] to access the closest
    /// ancestor [TooltipTheme] of the current [BuildContext].
    ///
    /// See also:
    ///
    ///  * [TooltipTheme], an [InheritedWidget] that propagates the theme down its
    ///    subtree.
    ///  * [TooltipThemeData], which describes the actual configuration of a
    ///    tooltip theme.
    /// </Summary>
    public class TooltipThemeData : IDiagnosticable
    {
        /// <Summary>
        /// Creates the set of properties used to configure [Tooltip]s.
        /// </Summary>
        public TooltipThemeData(double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double verticalOffset = default(double), bool preferBelow = default(bool), bool excludeFromSemantics = default(bool), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), TimeSpan waitDuration = default(TimeSpan), TimeSpan showDuration = default(TimeSpan))
        {
            this.Height = height;
            this.Padding = padding;
            this.Margin = margin;
            this.VerticalOffset = verticalOffset;
            this.PreferBelow = preferBelow;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.Decoration = decoration;
            this.TextStyle = textStyle;
            this.WaitDuration = waitDuration;
            this.ShowDuration = showDuration;
        }
        /// <Summary>
        /// The height of [Tooltip.child].
        /// </Summary>
        public virtual double Height { get; set; }
        /// <Summary>
        /// If provided, the amount of space by which to inset [Tooltip.child].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// If provided, the amount of empty space to surround the [Tooltip].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
        /// <Summary>
        /// The vertical gap between the widget and the displayed tooltip.
        ///
        /// When [preferBelow] is set to true and tooltips have sufficient space to
        /// display themselves, this property defines how much vertical space
        /// tooltips will position themselves under their corresponding widgets.
        /// Otherwise, tooltips will position themselves above their corresponding
        /// widgets with the given offset.
        /// </Summary>
        public virtual double VerticalOffset { get; set; }
        /// <Summary>
        /// Whether the tooltip is displayed below its widget by default.
        ///
        /// If there is insufficient space to display the tooltip in the preferred
        /// direction, the tooltip will be displayed in the opposite direction.
        /// </Summary>
        public virtual bool PreferBelow { get; set; }
        /// <Summary>
        /// Whether the tooltip's [message] should be excluded from the semantics
        /// tree.
        ///
        /// By default, [Tooltip]s will add a [Semantics.label] that is set to
        /// [Tooltip.message]. Set this property to true if the app is going to
        /// provide its own custom semantics label.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }
        /// <Summary>
        /// The [Tooltip]'s shape and background color.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        /// <Summary>
        /// The style to use for the message of [Tooltip]s.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        /// <Summary>
        /// The length of time that a pointer must hover over a tooltip's widget
        /// before the tooltip will be shown.
        /// </Summary>
        public virtual TimeSpan WaitDuration { get; set; }
        /// <Summary>
        /// The length of time that the tooltip will be shown once it has appeared.
        /// </Summary>
        public virtual TimeSpan ShowDuration { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Tooltiptheme.TooltipThemeData CopyWith(double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double verticalOffset = default(double), bool preferBelow = default(bool), bool excludeFromSemantics = default(bool), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), TimeSpan waitDuration = default(TimeSpan), TimeSpan showDuration = default(TimeSpan))
        {
            return new TooltipThemeData(height: height == default(double) ? this.height : height, padding: padding ?? this.Padding, margin: margin ?? this.Margin, verticalOffset: verticalOffset == default(double) ? this.verticalOffset : verticalOffset, preferBelow: preferBelow ?? this.PreferBelow, excludeFromSemantics: excludeFromSemantics ?? this.ExcludeFromSemantics, decoration: decoration ?? this.Decoration, textStyle: textStyle ?? this.TextStyle, waitDuration: waitDuration ?? this.WaitDuration, showDuration: showDuration ?? this.ShowDuration);
        }




        /// <Summary>
        /// Linearly interpolate between two tooltip themes.
        ///
        /// If both arguments are null, then null is returned.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Tooltiptheme.TooltipThemeData Lerp(FlutterSDK.Material.Tooltiptheme.TooltipThemeData a, FlutterSDK.Material.Tooltiptheme.TooltipThemeData b, double t)
        {
            if (a == null && b == null) return null;

            return new TooltipThemeData(height: Dart.UI.UiDefaultClass.LerpDouble(a?.Height, b?.Height, t), padding: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.Padding, b?.Padding, t), margin: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.Margin, b?.Margin, t), verticalOffset: Dart.UI.UiDefaultClass.LerpDouble(a?.VerticalOffset, b?.VerticalOffset, t), preferBelow: t < 0.5 ? a.PreferBelow : b.PreferBelow, excludeFromSemantics: t < 0.5 ? a.ExcludeFromSemantics : b.ExcludeFromSemantics, decoration: DecorationDefaultClass.Decoration.Lerp(a?.Decoration, b?.Decoration, t), textStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.TextStyle, b?.TextStyle, t));
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is TooltipThemeData && other.Height == Height && other.Padding == Padding && other.Margin == Margin && other.VerticalOffset == VerticalOffset && other.PreferBelow == PreferBelow && other.ExcludeFromSemantics == ExcludeFromSemantics && other.Decoration == Decoration && other.TextStyle == TextStyle && other.WaitDuration == WaitDuration && other.ShowDuration == ShowDuration;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("height", Height, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("margin", Margin, defaultValue: null));
            properties.Add(new DoubleProperty("vertical offset", VerticalOffset, defaultValue: null));
            properties.Add(new FlagProperty("position", value: PreferBelow, ifTrue: "below", ifFalse: "above", showName: true, defaultValue: null));
            properties.Add(new FlagProperty("semantics", value: ExcludeFromSemantics, ifTrue: "excluded", showName: true, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Decoration>("decoration", Decoration, defaultValue: null));
            properties.Add(new DiagnosticsProperty<TextStyle>("textStyle", TextStyle, defaultValue: null));
            properties.Add(new DiagnosticsProperty<TimeSpan>("wait duration", WaitDuration, defaultValue: null));
            properties.Add(new DiagnosticsProperty<TimeSpan>("show duration", ShowDuration, defaultValue: null));
        }



    }


    /// <Summary>
    /// An inherited widget that defines the configuration for
    /// [Tooltip]s in this widget's subtree.
    ///
    /// Values specified here are used for [Tooltip] properties that are not
    /// given an explicit non-null value.
    ///
    /// {@tool snippet}
    ///
    /// Here is an example of a tooltip theme that applies a blue foreground
    /// with non-rounded corners.
    ///
    /// ```dart
    /// TooltipTheme(
    ///   data: TooltipThemeData(
    ///     decoration: BoxDecoration(
    ///       color: Colors.blue.withOpacity(0.9),
    ///       borderRadius: BorderRadius.zero,
    ///     ),
    ///   ),
    ///   child: Tooltip(
    ///     message: 'Example tooltip',
    ///     child: IconButton(
    ///       iconSize: 36.0,
    ///       icon: Icon(Icons.touch_app),
    ///       onPressed: () {},
    ///     ),
    ///   ),
    /// ),
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class TooltipTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        /// <Summary>
        /// Creates a tooltip theme that controls the configurations for
        /// [Tooltip].
        ///
        /// The data argument must not be null.
        /// </Summary>
        public TooltipTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Tooltiptheme.TooltipThemeData data = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data;
        }
        /// <Summary>
        /// The properties for descendant [Tooltip] widgets.
        /// </Summary>
        public virtual FlutterSDK.Material.Tooltiptheme.TooltipThemeData Data { get; set; }

        /// <Summary>
        /// Returns the [data] from the closest [TooltipTheme] ancestor. If there is
        /// no ancestor, it returns [ThemeData.tooltipTheme]. Applications can assume
        /// that the returned value will not be null.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// TooltipThemeData theme = TooltipTheme.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Material.Tooltiptheme.TooltipThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            TooltipTheme tooltipTheme = context.DependOnInheritedWidgetOfExactType();
            return tooltipTheme?.Data ?? ThemeDefaultClass.Theme.Of(context).TooltipTheme;
        }




        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            TooltipTheme ancestorTheme = context.FindAncestorWidgetOfExactType();
            return Dart.CoreDefaultClass.Identical(this, ancestorTheme) ? child : new TooltipTheme(data: Data, child: child);
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Tooltiptheme.TooltipTheme oldWidget) => Data != oldWidget.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


    }

}
