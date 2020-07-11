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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Implicitanimations
{
    public delegate FlutterSDK.Animation.Tween.Tween<T> TweenConstructor<T>(T targetValue);
    public delegate FlutterSDK.Animation.Tween.Tween<T> TweenVisitor<T>(FlutterSDK.Animation.Tween.Tween<T> tween, T targetValue, FlutterSDK.Widgets.Implicitanimations.TweenConstructor<T> constructor);
    internal static class ImplicitanimationsDefaultClass
    {
    }

    public interface IImplicitlyAnimatedWidget
    {
        FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget> CreateState();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Animation.Curves.Curve Curve { get; }
        TimeSpan Duration { get; }
        VoidCallback OnEnd { get; }
    }


    public interface IImplicitlyAnimatedWidgetState<T>
    {
        void InitState();
        void DidUpdateWidget(T oldWidget);
        void Dispose();
        void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor);
        void DidUpdateTweens();
        FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; }
        FlutterSDK.Animation.Animation.Animation<double> Animation { get; }
    }


    public interface IAnimatedWidgetBaseState<T>
    {
        void InitState();
    }


    public class BoxConstraintsTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Rendering.Box.BoxConstraints>
    {
        #region constructors
        public BoxConstraintsTween(FlutterSDK.Rendering.Box.BoxConstraints begin = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Rendering.Box.BoxConstraints end = default(FlutterSDK.Rendering.Box.BoxConstraints))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Box.BoxConstraints Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class DecorationTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Decoration.Decoration>
    {
        #region constructors
        public DecorationTween(FlutterSDK.Painting.Decoration.Decoration begin = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Decoration.Decoration end = default(FlutterSDK.Painting.Decoration.Decoration))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Decoration.Decoration Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class EdgeInsetsTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Edgeinsets.EdgeInsets>
    {
        #region constructors
        public EdgeInsetsTween(FlutterSDK.Painting.Edgeinsets.EdgeInsets begin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets end = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class EdgeInsetsGeometryTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry>
    {
        #region constructors
        public EdgeInsetsGeometryTween(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry begin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry end = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class BorderRadiusTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Borderradius.BorderRadius>
    {
        #region constructors
        public BorderRadiusTween(FlutterSDK.Painting.Borderradius.BorderRadius begin = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borderradius.BorderRadius end = default(FlutterSDK.Painting.Borderradius.BorderRadius))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Borderradius.BorderRadius Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class BorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Boxborder.Border>
    {
        #region constructors
        public BorderTween(FlutterSDK.Painting.Boxborder.Border begin = default(FlutterSDK.Painting.Boxborder.Border), FlutterSDK.Painting.Boxborder.Border end = default(FlutterSDK.Painting.Boxborder.Border))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Boxborder.Border Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class Matrix4Tween : FlutterSDK.Animation.Tween.Tween<object>
    {
        #region constructors
        public Matrix4Tween(Matrix4 begin = default(Matrix4), Matrix4 end = default(Matrix4))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Matrix4 Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class TextStyleTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Textstyle.TextStyle>
    {
        #region constructors
        public TextStyleTween(FlutterSDK.Painting.Textstyle.TextStyle begin = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle end = default(FlutterSDK.Painting.Textstyle.TextStyle))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Textstyle.TextStyle Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class ImplicitlyAnimatedWidget : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public ImplicitlyAnimatedWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key)
        {
            this.Curve = curve;
            this.Duration = duration;
            this.OnEnd = onEnd; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
        public virtual TimeSpan Duration { get; set; }
        public virtual VoidCallback OnEnd { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget> CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ImplicitlyAnimatedWidgetState<T> : FlutterSDK.Widgets.Framework.State<T>, ISingleTickerProviderStateMixin<T>
    {
        #region constructors
        public ImplicitlyAnimatedWidgetState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(T oldWidget) { throw new NotImplementedException(); }


        private void _UpdateCurve() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private bool _ShouldAnimateTween(FlutterSDK.Animation.Tween.Tween<object> tween, object targetValue) { throw new NotImplementedException(); }


        private void _UpdateTween(FlutterSDK.Animation.Tween.Tween<object> tween, object targetValue) { throw new NotImplementedException(); }


        private bool _ConstructTweens() { throw new NotImplementedException(); }


        public virtual void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public virtual void DidUpdateTweens() { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedWidgetBaseState<T> : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<T>
    {
        #region constructors
        public AnimatedWidgetBaseState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _HandleAnimationChanged() { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedContainer : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Decoration.Decoration foregroundDecoration = default(FlutterSDK.Painting.Decoration.Decoration), double width = default(double), double height = default(double), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), Matrix4 transform = default(Matrix4), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Alignment = alignment;
            this.Padding = padding;
            this.ForegroundDecoration = foregroundDecoration;
            this.Margin = margin;
            this.Transform = transform;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration ForegroundDecoration { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
        public virtual Matrix4 Transform { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedContainerState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedContainerState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedContainer>
    {
        #region constructors
        public _AnimatedContainerState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Tweens.AlignmentGeometryTween _Alignment { get; set; }
        internal virtual FlutterSDK.Widgets.Implicitanimations.EdgeInsetsGeometryTween _Padding { get; set; }
        internal virtual FlutterSDK.Widgets.Implicitanimations.DecorationTween _Decoration { get; set; }
        internal virtual FlutterSDK.Widgets.Implicitanimations.DecorationTween _ForegroundDecoration { get; set; }
        internal virtual FlutterSDK.Widgets.Implicitanimations.BoxConstraintsTween _Constraints { get; set; }
        internal virtual FlutterSDK.Widgets.Implicitanimations.EdgeInsetsGeometryTween _Margin { get; set; }
        internal virtual FlutterSDK.Widgets.Implicitanimations.Matrix4Tween _Transform { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedPadding : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedPadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Padding = padding;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedPaddingState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedPaddingState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPadding>
    {
        #region constructors
        public _AnimatedPaddingState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Implicitanimations.EdgeInsetsGeometryTween _Padding { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedAlign : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedAlign(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Alignment = alignment;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedAlignState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedAlignState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedAlign>
    {
        #region constructors
        public _AnimatedAlignState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Tweens.AlignmentGeometryTween _Alignment { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedPositioned : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedPositioned(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double left = default(double), double top = default(double), double right = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Child = child;
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        public static AnimatedPositioned FromRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        {
            var instance = new AnimatedPositioned(key: key, curve: curve, duration: duration, onEnd: onEnd); instance.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual double Left { get; set; }
        public virtual double Top { get; set; }
        public virtual double Right { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedPositionedState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedPositionedState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPositioned>
    {
        #region constructors
        public _AnimatedPositionedState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Left { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Top { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Right { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Bottom { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Width { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Height { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedPositionedDirectional : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedPositionedDirectional(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double start = default(double), double top = default(double), double end = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Child = child;
            this.Start = start;
            this.Top = top;
            this.End = end;
            this.Bottom = bottom;
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual double Start { get; set; }
        public virtual double Top { get; set; }
        public virtual double End { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedPositionedDirectionalState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedPositionedDirectionalState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPositionedDirectional>
    {
        #region constructors
        public _AnimatedPositionedDirectionalState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Start { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Top { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _End { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Bottom { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Width { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Height { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedOpacity : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedOpacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double opacity = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback), bool alwaysIncludeSemantics = false)
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Child = child;
            this.Opacity = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual double Opacity { get; set; }
        public virtual bool AlwaysIncludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedOpacityState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedOpacityState : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.AnimatedOpacity>
    {
        #region constructors
        public _AnimatedOpacityState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Opacity { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new void DidUpdateTweens() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverAnimatedOpacity : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public SliverAnimatedOpacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget), double opacity = default(double), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback), bool alwaysIncludeSemantics = false)
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Sliver = sliver;
            this.Opacity = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Sliver { get; set; }
        public virtual double Opacity { get; set; }
        public virtual bool AlwaysIncludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._SliverAnimatedOpacityState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SliverAnimatedOpacityState : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Implicitanimations.SliverAnimatedOpacity>
    {
        #region constructors
        public _SliverAnimatedOpacityState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Opacity { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new void DidUpdateTweens() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedDefaultTextStyle : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedDefaultTextStyle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), TextAlign textAlign = default(TextAlign), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), int maxLines = default(int), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Child = child;
            this.Style = style;
            this.TextAlign = textAlign;
            this.SoftWrap = softWrap;
            this.Overflow = overflow;
            this.MaxLines = maxLines;
            this.TextWidthBasis = textWidthBasis;
            this.TextHeightBehavior = textHeightBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual bool SoftWrap { get; set; }
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedDefaultTextStyleState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedDefaultTextStyleState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedDefaultTextStyle>
    {
        #region constructors
        public _AnimatedDefaultTextStyleState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Implicitanimations.TextStyleTween _Style { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class AnimatedPhysicalModel : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        #region constructors
        public AnimatedPhysicalModel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double elevation = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool animateColor = true, FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), bool animateShadowColor = true, FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan), VoidCallback onEnd = default(VoidCallback))
        : base(key: key, curve: curve, duration: duration, onEnd: onEnd)
        {
            this.Child = child;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.BorderRadius = borderRadius;
            this.Elevation = elevation;
            this.Color = color;
            this.AnimateColor = animateColor;
            this.ShadowColor = shadowColor;
            this.AnimateShadowColor = animateShadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual bool AnimateColor { get; set; }
        public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
        public virtual bool AnimateShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Implicitanimations._AnimatedPhysicalModelState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AnimatedPhysicalModelState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Widgets.Implicitanimations.AnimatedPhysicalModel>
    {
        #region constructors
        public _AnimatedPhysicalModelState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Implicitanimations.BorderRadiusTween _BorderRadius { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _Elevation { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _Color { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _ShadowColor { get; set; }
        #endregion

        #region methods

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }

}
