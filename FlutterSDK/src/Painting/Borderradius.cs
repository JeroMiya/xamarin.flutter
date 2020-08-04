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
namespace FlutterSDK.Painting.Borderradius
{
    internal static class BorderradiusDefaultClass
    {
    }

    /// <Summary>
    /// Base class for [BorderRadius] that allows for text-direction aware resolution.
    ///
    /// A property or argument of this type accepts classes created either with [new
    /// BorderRadius.only] and its variants, or [new BorderRadiusDirectional.only]
    /// and its variants.
    ///
    /// To convert a [BorderRadiusGeometry] object of indeterminate type into a
    /// [BorderRadius] object, call the [resolve] method.
    /// </Summary>
    public interface IBorderRadiusGeometry
    {
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other);
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other);
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Unary();
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry MultiplyOperator(double other);
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideOperator(double other);
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideIntegerResultOperator(double other);
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry ModuloOperator(double other);
        FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Lerp(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry a, FlutterSDK.Painting.Borderradius.BorderRadiusGeometry b, double t);
        FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction);
        string ToString();
        bool Equals(@Object other);
        int HashCode { get; }
    }


    /// <Summary>
    /// Base class for [BorderRadius] that allows for text-direction aware resolution.
    ///
    /// A property or argument of this type accepts classes created either with [new
    /// BorderRadius.only] and its variants, or [new BorderRadiusDirectional.only]
    /// and its variants.
    ///
    /// To convert a [BorderRadiusGeometry] object of indeterminate type into a
    /// [BorderRadius] object, call the [resolve] method.
    /// </Summary>
    public class BorderRadiusGeometry
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public BorderRadiusGeometry()
        {

        }
        internal virtual Radius _TopLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns the difference between two [BorderRadiusGeometry] objects.
        ///
        /// If you know you are applying this to two [BorderRadius] or two
        /// [BorderRadiusDirectional] objects, consider using the binary infix `-`
        /// operator instead, which always returns an object of the same type as the
        /// operands, and is typed accordingly.
        ///
        /// If [subtract] is applied to two objects of the same type ([BorderRadius] or
        /// [BorderRadiusDirectional]), an object of that type will be returned (though
        /// this is not reflected in the type system). Otherwise, an object
        /// representing a combination of both is returned. That object can be turned
        /// into a concrete [BorderRadius] using [resolve].
        ///
        /// This method returns the same result as [add] applied to the result of
        /// negating the argument (using the prefix unary `-` operator or multiplying
        /// the argument by -1.0 using the `*` operator).
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other)
        {
            return new _MixedBorderRadius(_TopLeft - other._TopLeft, _TopRight - other._TopRight, _BottomLeft - other._BottomLeft, _BottomRight - other._BottomRight, _TopStart - other._TopStart, _TopEnd - other._TopEnd, _BottomStart - other._BottomStart, _BottomEnd - other._BottomEnd);
        }




        /// <Summary>
        /// Returns the sum of two [BorderRadiusGeometry] objects.
        ///
        /// If you know you are adding two [BorderRadius] or two [BorderRadiusDirectional]
        /// objects, consider using the `+` operator instead, which always returns an
        /// object of the same type as the operands, and is typed accordingly.
        ///
        /// If [add] is applied to two objects of the same type ([BorderRadius] or
        /// [BorderRadiusDirectional]), an object of that type will be returned (though
        /// this is not reflected in the type system). Otherwise, an object
        /// representing a combination of both is returned. That object can be turned
        /// into a concrete [BorderRadius] using [resolve].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other)
        {
            return new _MixedBorderRadius(_TopLeft + other._TopLeft, _TopRight + other._TopRight, _BottomLeft + other._BottomLeft, _BottomRight + other._BottomRight, _TopStart + other._TopStart, _TopEnd + other._TopEnd, _BottomStart + other._BottomStart, _BottomEnd + other._BottomEnd);
        }




        /// <Summary>
        /// Returns the [BorderRadiusGeometry] object with each corner radius negated.
        ///
        /// This is the same as multiplying the object by -1.0.
        ///
        /// This operator returns an object of the same type as the operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Unary()
        {
            return default(BorderRadiusGeometry);
        }


        /// <Summary>
        /// Scales the [BorderRadiusGeometry] object's corners by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry MultiplyOperator(double other)
        {
            return default(BorderRadiusGeometry);
        }


        /// <Summary>
        /// Divides the [BorderRadiusGeometry] object's corners by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideOperator(double other)
        {
            return default(BorderRadiusGeometry);
        }


        /// <Summary>
        /// Integer divides the [BorderRadiusGeometry] object's corners by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        ///
        /// This operator may have unexpected results when applied to a mixture of
        /// [BorderRadius] and [BorderRadiusDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideIntegerResultOperator(double other)
        {
            return default(BorderRadiusGeometry);
        }


        /// <Summary>
        /// Computes the remainder of each corner by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        ///
        /// This operator may have unexpected results when applied to a mixture of
        /// [BorderRadius] and [BorderRadiusDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry ModuloOperator(double other)
        {
            return default(BorderRadiusGeometry);
        }


        /// <Summary>
        /// Linearly interpolate between two [BorderRadiusGeometry] objects.
        ///
        /// If either is null, this function interpolates from [BorderRadius.zero],
        /// and the result is an object of the same type as the non-null argument. (If
        /// both are null, this returns null.)
        ///
        /// If [lerp] is applied to two objects of the same type ([BorderRadius] or
        /// [BorderRadiusDirectional]), an object of that type will be returned (though
        /// this is not reflected in the type system). Otherwise, an object
        /// representing a combination of both is returned. That object can be turned
        /// into a concrete [BorderRadius] using [resolve].
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Lerp(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry a, FlutterSDK.Painting.Borderradius.BorderRadiusGeometry b, double t)
        {

            if (a == null && b == null) return null;
            a = (a == null ? BorderradiusDefaultClass.BorderRadius.Zero : a);
            b = (b == null ? BorderradiusDefaultClass.BorderRadius.Zero : b);
            return a.Add((b.Subtract(a)) * t);
        }




        /// <Summary>
        /// Convert this instance into a [BorderRadius], so that the radii are
        /// expressed for specific physical corners (top-left, top-right, etc) rather
        /// than in a direction-dependent manner.
        ///
        /// See also:
        ///
        ///  * [BorderRadius], for which this is a no-op (returns itself).
        ///  * [BorderRadiusDirectional], which flips the horizontal direction
        ///    based on the `direction` argument.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction)
        {
            return default(BorderRadius);
        }



        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is BorderRadiusGeometry && other._TopLeft == _TopLeft && other._TopRight == _TopRight && other._BottomLeft == _BottomLeft && other._BottomRight == _BottomRight && other._TopStart == _TopStart && other._TopEnd == _TopEnd && other._BottomStart == _BottomStart && other._BottomEnd == _BottomEnd;
        }



    }


    /// <Summary>
    /// An immutable set of radii for each corner of a rectangle.
    ///
    /// Used by [BoxDecoration] when the shape is a [BoxShape.rectangle].
    ///
    /// The [BorderRadius] class specifies offsets in terms of visual corners, e.g.
    /// [topLeft]. These values are not affected by the [TextDirection]. To support
    /// both left-to-right and right-to-left layouts, consider using
    /// [BorderRadiusDirectional], which is expressed in terms that are relative to
    /// a [TextDirection] (typically obtained from the ambient [Directionality]).
    /// </Summary>
    public class BorderRadius : FlutterSDK.Painting.Borderradius.BorderRadiusGeometry
    {
        /// <Summary>
        /// Creates a border radius where all radii are [radius].
        /// </Summary>
        public static BorderRadius All(Radius radius)
        {
            var instance = new BorderRadius();
        }
        /// <Summary>
        /// Creates a border radius where all radii are [Radius.circular(radius)].
        /// </Summary>
        public static BorderRadius Circular(double radius)
        {
            var instance = new BorderRadius();
        }
        /// <Summary>
        /// Creates a vertically symmetric border radius where the top and bottom
        /// sides of the rectangle have the same radii.
        /// </Summary>
        public static BorderRadius Vertical(Radius top = default(Radius), Radius bottom = default(Radius))
        {
            var instance = new BorderRadius();
        }
        /// <Summary>
        /// Creates a horizontally symmetrical border radius where the left and right
        /// sides of the rectangle have the same radii.
        /// </Summary>
        public static BorderRadius Horizontal(Radius left = default(Radius), Radius right = default(Radius))
        {
            var instance = new BorderRadius();
        }
        /// <Summary>
        /// Creates a border radius with only the given non-zero values. The other
        /// corners will be right angles.
        /// </Summary>
        public static BorderRadius Only(Radius topLeft = default(Radius), Radius topRight = default(Radius), Radius bottomLeft = default(Radius), Radius bottomRight = default(Radius))
        {
            var instance = new BorderRadius(); instance.TopLeft = topLeft;
            instance.TopRight = topRight;
            instance.BottomLeft = bottomLeft;
            instance.BottomRight = bottomRight;
        }
        /// <Summary>
        /// A border radius with all zero radii.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius Zero { get; set; }
        /// <Summary>
        /// The top-left [Radius].
        /// </Summary>
        public virtual Radius TopLeft { get; set; }
        /// <Summary>
        /// The top-right [Radius].
        /// </Summary>
        public virtual Radius TopRight { get; set; }
        /// <Summary>
        /// The bottom-left [Radius].
        /// </Summary>
        public virtual Radius BottomLeft { get; set; }
        /// <Summary>
        /// The bottom-right [Radius].
        /// </Summary>
        public virtual Radius BottomRight { get; set; }
        internal virtual Radius _TopLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates an [RRect] from the current border radius and a [Rect].
        /// </Summary>
        public virtual RRect ToRRect(FlutterBinding.UI.Rect rect)
        {
            return RRect.FromRectAndCorners(rect, topLeft: TopLeft, topRight: TopRight, bottomLeft: BottomLeft, bottomRight: BottomRight);
        }




        public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other)
        {
            if (other is BorderRadius) return this - other;
            return base.Subtract(other);
        }




        public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other)
        {
            if (other is BorderRadius) return this + other;
            return base.Add(other);
        }




        /// <Summary>
        /// Returns the difference between two [BorderRadius] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius Unary(FlutterSDK.Painting.Borderradius.BorderRadius other)
        {
            return BorderRadius.Only(topLeft: TopLeft - other.TopLeft, topRight: TopRight - other.TopRight, bottomLeft: BottomLeft - other.BottomLeft, bottomRight: BottomRight - other.BottomRight);
        }




        /// <Summary>
        /// Returns the sum of two [BorderRadius] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius AddOperator(FlutterSDK.Painting.Borderradius.BorderRadius other)
        {
            return BorderRadius.Only(topLeft: TopLeft + other.TopLeft, topRight: TopRight + other.TopRight, bottomLeft: BottomLeft + other.BottomLeft, bottomRight: BottomRight + other.BottomRight);
        }




        /// <Summary>
        /// Returns the [BorderRadius] object with each corner negated.
        ///
        /// This is the same as multiplying the object by -1.0.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadius Unary()
        {
            return BorderRadius.Only(topLeft: -TopLeft, topRight: -TopRight, bottomLeft: -BottomLeft, bottomRight: -BottomRight);
        }




        /// <Summary>
        /// Scales each corner of the [BorderRadius] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadius MultiplyOperator(double other)
        {
            return BorderRadius.Only(topLeft: TopLeft * other, topRight: TopRight * other, bottomLeft: BottomLeft * other, bottomRight: BottomRight * other);
        }




        /// <Summary>
        /// Divides each corner of the [BorderRadius] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadius DivideOperator(double other)
        {
            return BorderRadius.Only(topLeft: TopLeft / other, topRight: TopRight / other, bottomLeft: BottomLeft / other, bottomRight: BottomRight / other);
        }




        /// <Summary>
        /// Integer divides each corner of the [BorderRadius] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadius DivideIntegerResultOperator(double other)
        {
            return BorderRadius.Only(topLeft: TopLeft~/ other, topRight: TopRight~/ other, bottomLeft: BottomLeft~/ other, bottomRight: BottomRight~/ other);
        }




        /// <Summary>
        /// Computes the remainder of each corner by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadius ModuloOperator(double other)
        {
            return BorderRadius.Only(topLeft: TopLeft % other, topRight: TopRight % other, bottomLeft: BottomLeft % other, bottomRight: BottomRight % other);
        }




        /// <Summary>
        /// Linearly interpolate between two [BorderRadius] objects.
        ///
        /// If either is null, this function interpolates from [BorderRadius.zero].
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius Lerp(FlutterSDK.Painting.Borderradius.BorderRadius a, FlutterSDK.Painting.Borderradius.BorderRadius b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b * t;
            if (b == null) return a * (1.0 - t);
            return BorderRadius.Only(topLeft: Dart.UI.UiDefaultClass.Radius.Lerp(a.TopLeft, b.TopLeft, t), topRight: Dart.UI.UiDefaultClass.Radius.Lerp(a.TopRight, b.TopRight, t), bottomLeft: Dart.UI.UiDefaultClass.Radius.Lerp(a.BottomLeft, b.BottomLeft, t), bottomRight: Dart.UI.UiDefaultClass.Radius.Lerp(a.BottomRight, b.BottomRight, t));
        }




        public new FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction) => this;


    }


    /// <Summary>
    /// An immutable set of radii for each corner of a rectangle, but with the
    /// corners specified in a manner dependent on the writing direction.
    ///
    /// This can be used to specify a corner radius on the leading or trailing edge
    /// of a box, so that it flips to the other side when the text alignment flips
    /// (e.g. being on the top right in English text but the top left in Arabic
    /// text).
    ///
    /// See also:
    ///
    ///  * [BorderRadius], a variant that uses physical labels (`topLeft` and
    ///    `topRight` instead of `topStart` and `topEnd`).
    /// </Summary>
    public class BorderRadiusDirectional : FlutterSDK.Painting.Borderradius.BorderRadiusGeometry
    {
        /// <Summary>
        /// Creates a border radius where all radii are [radius].
        /// </Summary>
        public static BorderRadiusDirectional All(Radius radius)
        {
            var instance = new BorderRadiusDirectional();
        }
        /// <Summary>
        /// Creates a border radius where all radii are [Radius.circular(radius)].
        /// </Summary>
        public static BorderRadiusDirectional Circular(double radius)
        {
            var instance = new BorderRadiusDirectional();
        }
        /// <Summary>
        /// Creates a vertically symmetric border radius where the top and bottom
        /// sides of the rectangle have the same radii.
        /// </Summary>
        public static BorderRadiusDirectional Vertical(Radius top = default(Radius), Radius bottom = default(Radius))
        {
            var instance = new BorderRadiusDirectional();
        }
        /// <Summary>
        /// Creates a horizontally symmetrical border radius where the start and end
        /// sides of the rectangle have the same radii.
        /// </Summary>
        public static BorderRadiusDirectional Horizontal(Radius start = default(Radius), Radius end = default(Radius))
        {
            var instance = new BorderRadiusDirectional();
        }
        /// <Summary>
        /// Creates a border radius with only the given non-zero values. The other
        /// corners will be right angles.
        /// </Summary>
        public static BorderRadiusDirectional Only(Radius topStart = default(Radius), Radius topEnd = default(Radius), Radius bottomStart = default(Radius), Radius bottomEnd = default(Radius))
        {
            var instance = new BorderRadiusDirectional(); instance.TopStart = topStart;
            instance.TopEnd = topEnd;
            instance.BottomStart = bottomStart;
            instance.BottomEnd = bottomEnd;
        }
        /// <Summary>
        /// A border radius with all zero radii.
        ///
        /// Consider using [EdgeInsets.zero] instead, since that object has the same
        /// effect, but will be cheaper to [resolve].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Zero { get; set; }
        /// <Summary>
        /// The top-start [Radius].
        /// </Summary>
        public virtual Radius TopStart { get; set; }
        /// <Summary>
        /// The top-end [Radius].
        /// </Summary>
        public virtual Radius TopEnd { get; set; }
        /// <Summary>
        /// The bottom-start [Radius].
        /// </Summary>
        public virtual Radius BottomStart { get; set; }
        /// <Summary>
        /// The bottom-end [Radius].
        /// </Summary>
        public virtual Radius BottomEnd { get; set; }
        internal virtual Radius _TopStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _TopRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Radius _BottomRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other)
        {
            if (other is BorderRadiusDirectional) return this - other;
            return base.Subtract(other);
        }




        public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other)
        {
            if (other is BorderRadiusDirectional) return this + other;
            return base.Add(other);
        }




        /// <Summary>
        /// Returns the difference between two [BorderRadiusDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Unary(FlutterSDK.Painting.Borderradius.BorderRadiusDirectional other)
        {
            return BorderRadiusDirectional.Only(topStart: TopStart - other.TopStart, topEnd: TopEnd - other.TopEnd, bottomStart: BottomStart - other.BottomStart, bottomEnd: BottomEnd - other.BottomEnd);
        }




        /// <Summary>
        /// Returns the sum of two [BorderRadiusDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional AddOperator(FlutterSDK.Painting.Borderradius.BorderRadiusDirectional other)
        {
            return BorderRadiusDirectional.Only(topStart: TopStart + other.TopStart, topEnd: TopEnd + other.TopEnd, bottomStart: BottomStart + other.BottomStart, bottomEnd: BottomEnd + other.BottomEnd);
        }




        /// <Summary>
        /// Returns the [BorderRadiusDirectional] object with each corner negated.
        ///
        /// This is the same as multiplying the object by -1.0.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Unary()
        {
            return BorderRadiusDirectional.Only(topStart: -TopStart, topEnd: -TopEnd, bottomStart: -BottomStart, bottomEnd: -BottomEnd);
        }




        /// <Summary>
        /// Scales each corner of the [BorderRadiusDirectional] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional MultiplyOperator(double other)
        {
            return BorderRadiusDirectional.Only(topStart: TopStart * other, topEnd: TopEnd * other, bottomStart: BottomStart * other, bottomEnd: BottomEnd * other);
        }




        /// <Summary>
        /// Divides each corner of the [BorderRadiusDirectional] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional DivideOperator(double other)
        {
            return BorderRadiusDirectional.Only(topStart: TopStart / other, topEnd: TopEnd / other, bottomStart: BottomStart / other, bottomEnd: BottomEnd / other);
        }




        /// <Summary>
        /// Integer divides each corner of the [BorderRadiusDirectional] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional DivideIntegerResultOperator(double other)
        {
            return BorderRadiusDirectional.Only(topStart: TopStart~/ other, topEnd: TopEnd~/ other, bottomStart: BottomStart~/ other, bottomEnd: BottomEnd~/ other);
        }




        /// <Summary>
        /// Computes the remainder of each corner by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional ModuloOperator(double other)
        {
            return BorderRadiusDirectional.Only(topStart: TopStart % other, topEnd: TopEnd % other, bottomStart: BottomStart % other, bottomEnd: BottomEnd % other);
        }




        /// <Summary>
        /// Linearly interpolate between two [BorderRadiusDirectional] objects.
        ///
        /// If either is null, this function interpolates from [BorderRadiusDirectional.zero].
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Lerp(FlutterSDK.Painting.Borderradius.BorderRadiusDirectional a, FlutterSDK.Painting.Borderradius.BorderRadiusDirectional b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b * t;
            if (b == null) return a * (1.0 - t);
            return BorderRadiusDirectional.Only(topStart: Dart.UI.UiDefaultClass.Radius.Lerp(a.TopStart, b.TopStart, t), topEnd: Dart.UI.UiDefaultClass.Radius.Lerp(a.TopEnd, b.TopEnd, t), bottomStart: Dart.UI.UiDefaultClass.Radius.Lerp(a.BottomStart, b.BottomStart, t), bottomEnd: Dart.UI.UiDefaultClass.Radius.Lerp(a.BottomEnd, b.BottomEnd, t));
        }




        public new FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction)
        {

            switch (direction) { case TextDirection.Rtl: return BorderRadius.Only(topLeft: TopEnd, topRight: TopStart, bottomLeft: BottomEnd, bottomRight: BottomStart); case TextDirection.Ltr: return BorderRadius.Only(topLeft: TopStart, topRight: TopEnd, bottomLeft: BottomStart, bottomRight: BottomEnd); }
            return null;
        }



    }


    public class _MixedBorderRadius : FlutterSDK.Painting.Borderradius.BorderRadiusGeometry
    {
        public _MixedBorderRadius(Radius _topLeft, Radius _topRight, Radius _bottomLeft, Radius _bottomRight, Radius _topStart, Radius _topEnd, Radius _bottomStart, Radius _bottomEnd)
        {
            this._TopLeft = _topLeft;
            this._TopRight = _topRight;
            this._BottomLeft = _bottomLeft;
            this._BottomRight = _bottomRight;
            this._TopStart = _topStart;
            this._TopEnd = _topEnd;
            this._BottomStart = _bottomStart;
            this._BottomEnd = _bottomEnd;
        }
        internal new Radius _TopLeft { get; set; }
        internal new Radius _TopRight { get; set; }
        internal new Radius _BottomLeft { get; set; }
        internal new Radius _BottomRight { get; set; }
        internal new Radius _TopStart { get; set; }
        internal new Radius _TopEnd { get; set; }
        internal new Radius _BottomStart { get; set; }
        internal new Radius _BottomEnd { get; set; }

        public new FlutterSDK.Painting.Borderradius._MixedBorderRadius Unary()
        {
            return new _MixedBorderRadius(-_TopLeft, -_TopRight, -_BottomLeft, -_BottomRight, -_TopStart, -_TopEnd, -_BottomStart, -_BottomEnd);
        }




        /// <Summary>
        /// Scales each corner of the [_MixedBorderRadius] by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Borderradius._MixedBorderRadius MultiplyOperator(double other)
        {
            return new _MixedBorderRadius(_TopLeft * other, _TopRight * other, _BottomLeft * other, _BottomRight * other, _TopStart * other, _TopEnd * other, _BottomStart * other, _BottomEnd * other);
        }




        public new FlutterSDK.Painting.Borderradius._MixedBorderRadius DivideOperator(double other)
        {
            return new _MixedBorderRadius(_TopLeft / other, _TopRight / other, _BottomLeft / other, _BottomRight / other, _TopStart / other, _TopEnd / other, _BottomStart / other, _BottomEnd / other);
        }




        public new FlutterSDK.Painting.Borderradius._MixedBorderRadius DivideIntegerResultOperator(double other)
        {
            return new _MixedBorderRadius(_TopLeft~/ other, _TopRight~/ other, _BottomLeft~/ other, _BottomRight~/ other, _TopStart~/ other, _TopEnd~/ other, _BottomStart~/ other, _BottomEnd~/ other);
        }




        public new FlutterSDK.Painting.Borderradius._MixedBorderRadius ModuloOperator(double other)
        {
            return new _MixedBorderRadius(_TopLeft % other, _TopRight % other, _BottomLeft % other, _BottomRight % other, _TopStart % other, _TopEnd % other, _BottomStart % other, _BottomEnd % other);
        }




        public new FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction)
        {

            switch (direction) { case TextDirection.Rtl: return BorderRadius.Only(topLeft: _TopLeft + _TopEnd, topRight: _TopRight + _TopStart, bottomLeft: _BottomLeft + _BottomEnd, bottomRight: _BottomRight + _BottomStart); case TextDirection.Ltr: return BorderRadius.Only(topLeft: _TopLeft + _TopStart, topRight: _TopRight + _TopEnd, bottomLeft: _BottomLeft + _BottomStart, bottomRight: _BottomRight + _BottomEnd); }
            return null;
        }



    }

}
