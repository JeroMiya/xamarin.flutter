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
using FlutterSDK.Material.Drawerheader;
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
using FlutterSDK.Material.Inksplash;
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
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
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
namespace FlutterSDK.Painting.Boxborder
{
    internal static class BoxborderDefaultClass
    {
    }

    /// <Summary>
    /// Base class for box borders that can paint as rectangles, circles, or rounded
    /// rectangles.
    ///
    /// This class is extended by [Border] and [BorderDirectional] to provide
    /// concrete versions of four-sided borders using different conventions for
    /// specifying the sides.
    ///
    /// The only API difference that this class introduces over [ShapeBorder] is
    /// that its [paint] method takes additional arguments.
    ///
    /// See also:
    ///
    ///  * [BorderSide], which is used to describe each side of the box.
    ///  * [RoundedRectangleBorder], another way of describing a box's border.
    ///  * [CircleBorder], another way of describing a circle border.
    ///  * [BoxDecoration], which uses a [BoxBorder] to describe its borders.
    /// </Summary>
    public interface IBoxBorder
    {
        FlutterSDK.Painting.Boxborder.BoxBorder Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false);
        FlutterSDK.Painting.Boxborder.BoxBorder Lerp(FlutterSDK.Painting.Boxborder.BoxBorder a, FlutterSDK.Painting.Boxborder.BoxBorder b, double t);
        Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection));
        Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection));
        void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius));
        FlutterSDK.Painting.Borders.BorderSide Top { get; }
        FlutterSDK.Painting.Borders.BorderSide Bottom { get; }
        bool IsUniform { get; }
    }


    /// <Summary>
    /// Base class for box borders that can paint as rectangles, circles, or rounded
    /// rectangles.
    ///
    /// This class is extended by [Border] and [BorderDirectional] to provide
    /// concrete versions of four-sided borders using different conventions for
    /// specifying the sides.
    ///
    /// The only API difference that this class introduces over [ShapeBorder] is
    /// that its [paint] method takes additional arguments.
    ///
    /// See also:
    ///
    ///  * [BorderSide], which is used to describe each side of the box.
    ///  * [RoundedRectangleBorder], another way of describing a box's border.
    ///  * [CircleBorder], another way of describing a circle border.
    ///  * [BoxDecoration], which uses a [BoxBorder] to describe its borders.
    /// </Summary>
    public class BoxBorder : FlutterSDK.Painting.Borders.ShapeBorder
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public BoxBorder()
        {

        }
        public virtual FlutterSDK.Painting.Borders.BorderSide Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Borders.BorderSide Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsUniform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Painting.Boxborder.BoxBorder Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false) => null;



        /// <Summary>
        /// Linearly interpolate between two borders.
        ///
        /// If a border is null, it is treated as having four [BorderSide.none]
        /// borders.
        ///
        /// This supports interpolating between [Border] and [BorderDirectional]
        /// objects. If both objects are different types but both have sides on one or
        /// both of their lateral edges (the two sides that aren't the top and bottom)
        /// other than [BorderSide.none], then the sides are interpolated by reducing
        /// `a`'s lateral edges to [BorderSide.none] over the first half of the
        /// animation, and then bringing `b`'s lateral edges _from_ [BorderSide.none]
        /// over the second half of the animation.
        ///
        /// For a more flexible approach, consider [ShapeBorder.lerp], which would
        /// instead [add] the two sets of sides and interpolate them simultaneously.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.BoxBorder Lerp(FlutterSDK.Painting.Boxborder.BoxBorder a, FlutterSDK.Painting.Boxborder.BoxBorder b, double t)
        {

            if ((a is Border || a == null) && (b is Border || b == null)) return BoxborderDefaultClass.Border.Lerp(a as Border, b as Border, t);
            if ((a is BorderDirectional || a == null) && (b is BorderDirectional || b == null)) return BoxborderDefaultClass.BorderDirectional.Lerp(a as BorderDirectional, b as BorderDirectional, t);
            if (b is Border && a is BorderDirectional)
            {
                BoxBorder c = ((Border)b);
                ((Border)b) = ((Border)a);
                ((Border)a) = c;
                t = 1.0 - t;
            }

            if (a is Border && b is BorderDirectional)
            {
                if (((BorderDirectional)b).Start == BordersDefaultClass.BorderSide.None && ((BorderDirectional)b).End == BordersDefaultClass.BorderSide.None)
                {
                    return new Border(top: BordersDefaultClass.BorderSide.Lerp(((Border)a).Top, ((BorderDirectional)b).Top, t), right: BordersDefaultClass.BorderSide.Lerp(((Border)a).Right, BordersDefaultClass.BorderSide.None, t), bottom: BordersDefaultClass.BorderSide.Lerp(((Border)a).Bottom, ((BorderDirectional)b).Bottom, t), left: BordersDefaultClass.BorderSide.Lerp(((Border)a).Left, BordersDefaultClass.BorderSide.None, t));
                }

                if (a.Left == BordersDefaultClass.BorderSide.None && a.Right == BordersDefaultClass.BorderSide.None)
                {
                    return new BorderDirectional(top: BordersDefaultClass.BorderSide.Lerp(a.Top, b.Top, t), start: BordersDefaultClass.BorderSide.Lerp(BordersDefaultClass.BorderSide.None, b.Start, t), end: BordersDefaultClass.BorderSide.Lerp(BordersDefaultClass.BorderSide.None, b.End, t), bottom: BordersDefaultClass.BorderSide.Lerp(a.Bottom, b.Bottom, t));
                }

                if (t < 0.5)
                {
                    return new Border(top: BordersDefaultClass.BorderSide.Lerp(a.Top, b.Top, t), right: BordersDefaultClass.BorderSide.Lerp(a.Right, BordersDefaultClass.BorderSide.None, t * 2.0), bottom: BordersDefaultClass.BorderSide.Lerp(a.Bottom, b.Bottom, t), left: BordersDefaultClass.BorderSide.Lerp(a.Left, BordersDefaultClass.BorderSide.None, t * 2.0));
                }

                return new BorderDirectional(top: BordersDefaultClass.BorderSide.Lerp(a.Top, b.Top, t), start: BordersDefaultClass.BorderSide.Lerp(BordersDefaultClass.BorderSide.None, b.Start, (t - 0.5) * 2.0), end: BordersDefaultClass.BorderSide.Lerp(BordersDefaultClass.BorderSide.None, b.End, (t - 0.5) * 2.0), bottom: BordersDefaultClass.BorderSide.Lerp(a.Bottom, b.Bottom, t));
            }

            throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary("BoxBorder.lerp can only interpolate Border and BorderDirectional classes."), new ErrorDescription($"'BoxBorder.lerp() was called with two objects of type {a.GetType()} and {b.GetType()}:\n'" + $"'  {a}\n'" + $"'  {b}\n'" + "However, only Border and BorderDirectional classes are supported by this method."), new ErrorHint("For a more general interpolation method, consider using ShapeBorder.lerp instead.") });
        }




        public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {

            return new Path();
            new Path().AddRect(Dimensions.Resolve(textDirection).DeflateRect(rect));
        }




        public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {

            return new Path();
            new Path().AddRect(rect);
        }




        /// <Summary>
        /// Paints the border within the given [Rect] on the given [Canvas].
        ///
        /// This is an extension of the [ShapeBorder.paint] method. It allows
        /// [BoxBorder] borders to be applied to different [BoxShape]s and with
        /// different [borderRadius] parameters, without changing the [BoxBorder]
        /// object itself.
        ///
        /// The `shape` argument specifies the [BoxShape] to draw the border on.
        ///
        /// If the `shape` is specifies a rectangular box shape
        /// ([BoxShape.rectangle]), then the `borderRadius` argument describes the
        /// corners of the rectangle.
        ///
        /// The [getInnerPath] and [getOuterPath] methods do not know about the
        /// `shape` and `borderRadius` arguments.
        ///
        /// See also:
        ///
        ///  * [paintBorder], which is used if the border is not uniform.
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
        {
        }


        private void _PaintUniformBorderWithRadius(Canvas canvas, FlutterBinding.UI.Rect rect, FlutterSDK.Painting.Borders.BorderSide side, FlutterSDK.Painting.Borderradius.BorderRadius borderRadius)
        {

            Paint paint = new Paint()..Color = side.Color;
            RRect outer = borderRadius.ToRRect(rect);
            double width = side.Width;
            if (width == 0.0)
            {
                ..Style = PaintingStyle.Stroke..StrokeWidth = 0.0;
                canvas.DrawRRect(outer, paint);
            }
            else
            {
                RRect inner = outer.Deflate(width);
                canvas.DrawDRRect(outer, inner, paint);
            }

        }




        private void _PaintUniformBorderWithCircle(Canvas canvas, FlutterBinding.UI.Rect rect, FlutterSDK.Painting.Borders.BorderSide side)
        {

            double width = side.Width;
            Paint paint = side.ToPaint();
            double radius = (rect.ShortestSide - width) / 2.0;
            canvas.DrawCircle(rect.Center, radius, paint);
        }




        private void _PaintUniformBorderWithRectangle(Canvas canvas, FlutterBinding.UI.Rect rect, FlutterSDK.Painting.Borders.BorderSide side)
        {

            double width = side.Width;
            Paint paint = side.ToPaint();
            canvas.DrawRect(rect.Deflate(width / 2.0), paint);
        }



    }


    /// <Summary>
    /// A border of a box, comprised of four sides: top, right, bottom, left.
    ///
    /// The sides are represented by [BorderSide] objects.
    ///
    /// {@tool snippet}
    ///
    /// All four borders the same, two-pixel wide solid white:
    ///
    /// ```dart
    /// Border.all(width: 2.0, color: const Color(0xFFFFFFFF))
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// The border for a material design divider:
    ///
    /// ```dart
    /// Border(bottom: BorderSide(color: Theme.of(context).dividerColor))
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// A 1990s-era "OK" button:
    ///
    /// ```dart
    /// Container(
    ///   decoration: const BoxDecoration(
    ///     border: Border(
    ///       top: BorderSide(width: 1.0, color: Color(0xFFFFFFFFFF)),
    ///       left: BorderSide(width: 1.0, color: Color(0xFFFFFFFFFF)),
    ///       right: BorderSide(width: 1.0, color: Color(0xFFFF000000)),
    ///       bottom: BorderSide(width: 1.0, color: Color(0xFFFF000000)),
    ///     ),
    ///   ),
    ///   child: Container(
    ///     padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 2.0),
    ///     decoration: const BoxDecoration(
    ///       border: Border(
    ///         top: BorderSide(width: 1.0, color: Color(0xFFFFDFDFDF)),
    ///         left: BorderSide(width: 1.0, color: Color(0xFFFFDFDFDF)),
    ///         right: BorderSide(width: 1.0, color: Color(0xFFFF7F7F7F)),
    ///         bottom: BorderSide(width: 1.0, color: Color(0xFFFF7F7F7F)),
    ///       ),
    ///       color: Color(0xFFBFBFBF),
    ///     ),
    ///     child: const Text(
    ///       'OK',
    ///       textAlign: TextAlign.center,
    ///       style: TextStyle(color: Color(0xFF000000))
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [BoxDecoration], which uses this class to describe its edge decoration.
    ///  * [BorderSide], which is used to describe each side of the box.
    ///  * [Theme], from the material layer, which can be queried to obtain appropriate colors
    ///    to use for borders in a material app, as shown in the "divider" sample above.
    /// </Summary>
    public class Border : FlutterSDK.Painting.Boxborder.BoxBorder
    {
        /// <Summary>
        /// Creates a border.
        ///
        /// All the sides of the border default to [BorderSide.none].
        ///
        /// The arguments must not be null.
        /// </Summary>
        public Border(FlutterSDK.Painting.Borders.BorderSide top = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide right = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide bottom = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide left = default(FlutterSDK.Painting.Borders.BorderSide))
        : base()
        {
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Left = left;
        }
        /// <Summary>
        /// Creates a border whose sides are all the same.
        ///
        /// The `side` argument must not be null.
        /// </Summary>
        public static Border FromBorderSide(FlutterSDK.Painting.Borders.BorderSide side)
        {
            var instance = new Border();
        }
        /// <Summary>
        /// Creates a border with symmetrical vertical and horizontal sides.
        ///
        /// All arguments default to [BorderSide.none] and must not be null.
        /// </Summary>
        public static Border Symmetric(FlutterSDK.Painting.Borders.BorderSide vertical = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide horizontal = default(FlutterSDK.Painting.Borders.BorderSide))
        {
            var instance = new Border();
        }
        /// <Summary>
        /// A uniform border with all sides the same color and width.
        ///
        /// The sides default to black solid borders, one logical pixel wide.
        /// </Summary>
        public static Border All(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), double width = 1.0, FlutterSDK.Painting.Borders.BorderStyle style = default(FlutterSDK.Painting.Borders.BorderStyle))
        {
            var instance = new Border();
            BorderSide side = new BorderSide(color: color, width: width, style: style);
            return Border.FromBorderSide(side);
        }


        public new FlutterSDK.Painting.Borders.BorderSide Top { get; set; }
        /// <Summary>
        /// The right side of this border.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide Right { get; set; }
        public new FlutterSDK.Painting.Borders.BorderSide Bottom { get; set; }
        /// <Summary>
        /// The left side of this border.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide Left { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsUniform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a [Border] that represents the addition of the two given
        /// [Border]s.
        ///
        /// It is only valid to call this if [BorderSide.canMerge] returns true for
        /// the pairwise combination of each side on both [Border]s.
        ///
        /// The arguments must not be null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.Border Merge(FlutterSDK.Painting.Boxborder.Border a, FlutterSDK.Painting.Boxborder.Border b)
        {






            return new Border(top: BordersDefaultClass.BorderSide.Merge(a.Top, b.Top), right: BordersDefaultClass.BorderSide.Merge(a.Right, b.Right), bottom: BordersDefaultClass.BorderSide.Merge(a.Bottom, b.Bottom), left: BordersDefaultClass.BorderSide.Merge(a.Left, b.Left));
        }




        public new FlutterSDK.Painting.Boxborder.Border Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false)
        {
            if (other is Border && BordersDefaultClass.BorderSide.CanMerge(Top, other.Top) && BordersDefaultClass.BorderSide.CanMerge(Right, other.Right) && BordersDefaultClass.BorderSide.CanMerge(Bottom, other.Bottom) && BordersDefaultClass.BorderSide.CanMerge(Left, other.Left))
            {
                return BoxborderDefaultClass.Border.Merge(this, ((Border)other));
            }

            return null;
        }




        public new FlutterSDK.Painting.Boxborder.Border Scale(double t)
        {
            return new Border(top: Top.Scale(t), right: Right.Scale(t), bottom: Bottom.Scale(t), left: Left.Scale(t));
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
        {
            if (a is Border) return BoxborderDefaultClass.Border.Lerp(a, this, t);
            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
        {
            if (b is Border) return BoxborderDefaultClass.Border.Lerp(this, b, t);
            return base.LerpTo(b, t);
        }




        /// <Summary>
        /// Linearly interpolate between two borders.
        ///
        /// If a border is null, it is treated as having four [BorderSide.none]
        /// borders.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.Border Lerp(FlutterSDK.Painting.Boxborder.Border a, FlutterSDK.Painting.Boxborder.Border b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b.Scale(t);
            if (b == null) return a.Scale(1.0 - t);
            return new Border(top: BordersDefaultClass.BorderSide.Lerp(a.Top, b.Top, t), right: BordersDefaultClass.BorderSide.Lerp(a.Right, b.Right, t), bottom: BordersDefaultClass.BorderSide.Lerp(a.Bottom, b.Bottom, t), left: BordersDefaultClass.BorderSide.Lerp(a.Left, b.Left, t));
        }




        /// <Summary>
        /// Paints the border within the given [Rect] on the given [Canvas].
        ///
        /// Uniform borders are more efficient to paint than more complex borders.
        ///
        /// You can provide a [BoxShape] to draw the border on. If the `shape` in
        /// [BoxShape.circle], there is the requirement that the border [isUniform].
        ///
        /// If you specify a rectangular box shape ([BoxShape.rectangle]), then you
        /// may specify a [BorderRadius]. If a `borderRadius` is specified, there is
        /// the requirement that the border [isUniform].
        ///
        /// The [getInnerPath] and [getOuterPath] methods do not know about the
        /// `shape` and `borderRadius` arguments.
        ///
        /// The `textDirection` argument is not used by this paint method.
        ///
        /// See also:
        ///
        ///  * [paintBorder], which is used if the border is not uniform.
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
        {
            if (IsUniform)
            {
                switch (Top.Style)
                {
                    case BorderStyle.None: return;
                    case BorderStyle.Solid:
                        switch (shape)
                        {
                            case BoxShape.Circle: BoxborderDefaultClass.BoxBorder._PaintUniformBorderWithCircle(canvas, rect, Top); break;
                            case BoxShape.Rectangle:
                                if (borderRadius != null)
                                {
                                    BoxborderDefaultClass.BoxBorder._PaintUniformBorderWithRadius(canvas, rect, Top, borderRadius);
                                    return;
                                }
                                BoxborderDefaultClass.BoxBorder._PaintUniformBorderWithRectangle(canvas, rect, Top); break;
                        }
                        return;
                }
            }



            BordersDefaultClass.PaintBorder(canvas, rect, top: Top, right: Right, bottom: Bottom, left: Left);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is Border && other.Top == Top && other.Right == Right && other.Bottom == Bottom && other.Left == Left;
        }




    }


    /// <Summary>
    /// A border of a box, comprised of four sides, the lateral sides of which
    /// flip over based on the reading direction.
    ///
    /// The lateral sides are called [start] and [end]. When painted in
    /// left-to-right environments, the [start] side will be painted on the left and
    /// the [end] side on the right; in right-to-left environments, it is the
    /// reverse. The other two sides are [top] and [bottom].
    ///
    /// The sides are represented by [BorderSide] objects.
    ///
    /// If the [start] and [end] sides are the same, then it is slightly more
    /// efficient to use a [Border] object rather than a [BorderDirectional] object.
    ///
    /// See also:
    ///
    ///  * [BoxDecoration], which uses this class to describe its edge decoration.
    ///  * [BorderSide], which is used to describe each side of the box.
    ///  * [Theme], from the material layer, which can be queried to obtain appropriate colors
    ///    to use for borders in a material app, as shown in the "divider" sample above.
    /// </Summary>
    public class BorderDirectional : FlutterSDK.Painting.Boxborder.BoxBorder
    {
        /// <Summary>
        /// Creates a border.
        ///
        /// The [start] and [end] sides represent the horizontal sides; the start side
        /// is on the leading edge given the reading direction, and the end side is on
        /// the trailing edge. They are resolved during [paint].
        ///
        /// All the sides of the border default to [BorderSide.none].
        ///
        /// The arguments must not be null.
        /// </Summary>
        public BorderDirectional(FlutterSDK.Painting.Borders.BorderSide top = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide start = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide end = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide bottom = default(FlutterSDK.Painting.Borders.BorderSide))
        : base()
        {
            this.Top = top;
            this.Start = start;
            this.End = end;
            this.Bottom = bottom;
        }
        public new FlutterSDK.Painting.Borders.BorderSide Top { get; set; }
        /// <Summary>
        /// The start side of this border.
        ///
        /// This is the side on the left in left-to-right text and on the right in
        /// right-to-left text.
        ///
        /// See also:
        ///
        ///  * [TextDirection], which is used to describe the reading direction.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide Start { get; set; }
        /// <Summary>
        /// The end side of this border.
        ///
        /// This is the side on the right in left-to-right text and on the left in
        /// right-to-left text.
        ///
        /// See also:
        ///
        ///  * [TextDirection], which is used to describe the reading direction.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide End { get; set; }
        public new FlutterSDK.Painting.Borders.BorderSide Bottom { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsUniform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a [BorderDirectional] that represents the addition of the two
        /// given [BorderDirectional]s.
        ///
        /// It is only valid to call this if [BorderSide.canMerge] returns true for
        /// the pairwise combination of each side on both [BorderDirectional]s.
        ///
        /// The arguments must not be null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.BorderDirectional Merge(FlutterSDK.Painting.Boxborder.BorderDirectional a, FlutterSDK.Painting.Boxborder.BorderDirectional b)
        {






            return new BorderDirectional(top: BordersDefaultClass.BorderSide.Merge(a.Top, b.Top), start: BordersDefaultClass.BorderSide.Merge(a.Start, b.Start), end: BordersDefaultClass.BorderSide.Merge(a.End, b.End), bottom: BordersDefaultClass.BorderSide.Merge(a.Bottom, b.Bottom));
        }




        public new FlutterSDK.Painting.Boxborder.BoxBorder Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false)
        {
            if (other is BorderDirectional)
            {
                BorderDirectional typedOther = ((Border)other);
                if (BordersDefaultClass.BorderSide.CanMerge(Top, typedOther.Top) && BordersDefaultClass.BorderSide.CanMerge(Start, typedOther.Start) && BordersDefaultClass.BorderSide.CanMerge(End, typedOther.End) && BordersDefaultClass.BorderSide.CanMerge(Bottom, typedOther.Bottom))
                {
                    return BoxborderDefaultClass.BorderDirectional.Merge(this, typedOther);
                }

                return null;
            }

            if (other is Border)
            {
                Border typedOther = ((Border)other);
                if (!BordersDefaultClass.BorderSide.CanMerge(typedOther.Top, Top) || !BordersDefaultClass.BorderSide.CanMerge(typedOther.Bottom, Bottom)) return null;
                if (Start != BordersDefaultClass.BorderSide.None || End != BordersDefaultClass.BorderSide.None)
                {
                    if (typedOther.Left != BordersDefaultClass.BorderSide.None || typedOther.Right != BordersDefaultClass.BorderSide.None) return null;


                    return new BorderDirectional(top: BordersDefaultClass.BorderSide.Merge(typedOther.Top, Top), start: Start, end: End, bottom: BordersDefaultClass.BorderSide.Merge(typedOther.Bottom, Bottom));
                }



                return new Border(top: BordersDefaultClass.BorderSide.Merge(typedOther.Top, Top), right: typedOther.Right, bottom: BordersDefaultClass.BorderSide.Merge(typedOther.Bottom, Bottom), left: typedOther.Left);
            }

            return null;
        }




        public new FlutterSDK.Painting.Boxborder.BorderDirectional Scale(double t)
        {
            return new BorderDirectional(top: Top.Scale(t), start: Start.Scale(t), end: End.Scale(t), bottom: Bottom.Scale(t));
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
        {
            if (a is BorderDirectional) return BoxborderDefaultClass.BorderDirectional.Lerp(a, this, t);
            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
        {
            if (b is BorderDirectional) return BoxborderDefaultClass.BorderDirectional.Lerp(this, b, t);
            return base.LerpTo(b, t);
        }




        /// <Summary>
        /// Linearly interpolate between two borders.
        ///
        /// If a border is null, it is treated as having four [BorderSide.none]
        /// borders.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.BorderDirectional Lerp(FlutterSDK.Painting.Boxborder.BorderDirectional a, FlutterSDK.Painting.Boxborder.BorderDirectional b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b.Scale(t);
            if (b == null) return a.Scale(1.0 - t);
            return new BorderDirectional(top: BordersDefaultClass.BorderSide.Lerp(a.Top, b.Top, t), end: BordersDefaultClass.BorderSide.Lerp(a.End, b.End, t), bottom: BordersDefaultClass.BorderSide.Lerp(a.Bottom, b.Bottom, t), start: BordersDefaultClass.BorderSide.Lerp(a.Start, b.Start, t));
        }




        /// <Summary>
        /// Paints the border within the given [Rect] on the given [Canvas].
        ///
        /// Uniform borders are more efficient to paint than more complex borders.
        ///
        /// You can provide a [BoxShape] to draw the border on. If the `shape` in
        /// [BoxShape.circle], there is the requirement that the border [isUniform].
        ///
        /// If you specify a rectangular box shape ([BoxShape.rectangle]), then you
        /// may specify a [BorderRadius]. If a `borderRadius` is specified, there is
        /// the requirement that the border [isUniform].
        ///
        /// The [getInnerPath] and [getOuterPath] methods do not know about the
        /// `shape` and `borderRadius` arguments.
        ///
        /// The `textDirection` argument is used to determine which of [start] and
        /// [end] map to the left and right. For [TextDirection.ltr], the [start] is
        /// the left and the [end] is the right; for [TextDirection.rtl], it is the
        /// reverse.
        ///
        /// See also:
        ///
        ///  * [paintBorder], which is used if the border is not uniform.
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
        {
            if (IsUniform)
            {
                switch (Top.Style)
                {
                    case BorderStyle.None: return;
                    case BorderStyle.Solid:
                        switch (shape)
                        {
                            case BoxShape.Circle: BoxborderDefaultClass.BoxBorder._PaintUniformBorderWithCircle(canvas, rect, Top); break;
                            case BoxShape.Rectangle:
                                if (borderRadius != null)
                                {
                                    BoxborderDefaultClass.BoxBorder._PaintUniformBorderWithRadius(canvas, rect, Top, borderRadius);
                                    return;
                                }
                                BoxborderDefaultClass.BoxBorder._PaintUniformBorderWithRectangle(canvas, rect, Top); break;
                        }
                        return;
                }
            }



            BorderSide left right = default(BorderSide);

            switch (textDirection) { case TextDirection.Rtl: left = End; right = Start; break; case TextDirection.Ltr: left = Start; right = End; break; }
            BordersDefaultClass.PaintBorder(canvas, rect, top: Top, left: left, bottom: Bottom, right: right);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is BorderDirectional && other.Top == Top && other.Start == Start && other.End == End && other.Bottom == Bottom;
        }




    }


    /// <Summary>
    /// The shape to use when rendering a [Border] or [BoxDecoration].
    ///
    /// Consider using [ShapeBorder] subclasses directly (with [ShapeDecoration]),
    /// instead of using [BoxShape] and [Border], if the shapes will need to be
    /// interpolated or animated. The [Border] class cannot interpolate between
    /// different shapes.
    /// </Summary>
    public enum BoxShape
    {

        /// <Summary>
        /// An axis-aligned, 2D rectangle. May have rounded corners (described by a
        /// [BorderRadius]). The edges of the rectangle will match the edges of the box
        /// into which the [Border] or [BoxDecoration] is painted.
        ///
        /// See also:
        ///
        ///  * [RoundedRectangleBorder], the equivalent [ShapeBorder].
        /// </Summary>
        Rectangle,
        /// <Summary>
        /// A circle centered in the middle of the box into which the [Border] or
        /// [BoxDecoration] is painted. The diameter of the circle is the shortest
        /// dimension of the box, either the width or the height, such that the circle
        /// touches the edges of the box.
        ///
        /// See also:
        ///
        ///  * [CircleBorder], the equivalent [ShapeBorder].
        /// </Summary>
        Circle,
    }

}
