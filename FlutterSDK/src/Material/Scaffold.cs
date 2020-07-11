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
namespace FlutterSDK.Material.Scaffold
{
    internal static class ScaffoldDefaultClass
    {
        public static FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation _KDefaultFloatingActionButtonLocation = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation);
        public static FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator _KDefaultFloatingActionButtonAnimator = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator);
        public static FlutterSDK.Animation.Curves.Curve _StandardBottomSheetCurve = default(FlutterSDK.Animation.Curves.Curve);
        public static double _KBottomSheetDominatesPercentage = default(double);
        public static double _KMinBottomSheetScrimOpacity = default(double);
        public static double _KMaxBottomSheetScrimOpacity = default(double);
    }

    /// <Summary>
    /// The geometry of the [Scaffold] after all its contents have been laid out
    /// except the [FloatingActionButton].
    ///
    /// The [Scaffold] passes this pre-layout geometry to its
    /// [FloatingActionButtonLocation], which produces an [Offset] that the
    /// [Scaffold] uses to position the [FloatingActionButton].
    ///
    /// For a description of the [Scaffold]'s geometry after it has
    /// finished laying out, see the [ScaffoldGeometry].
    /// </Summary>
    public class ScaffoldPrelayoutGeometry
    {
        #region constructors
        public ScaffoldPrelayoutGeometry(Size bottomSheetSize = default(Size), double contentBottom = default(double), double contentTop = default(double), Size floatingActionButtonSize = default(Size), FlutterSDK.Painting.Edgeinsets.EdgeInsets minInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), Size scaffoldSize = default(Size), Size snackBarSize = default(Size), TextDirection textDirection = default(TextDirection))
        {
            this.BottomSheetSize = bottomSheetSize;
            this.ContentBottom = contentBottom;
            this.ContentTop = contentTop;
            this.FloatingActionButtonSize = floatingActionButtonSize;
            this.MinInsets = minInsets;
            this.ScaffoldSize = scaffoldSize;
            this.SnackBarSize = snackBarSize;
            this.TextDirection = textDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Size FloatingActionButtonSize { get; set; }
        public virtual Size BottomSheetSize { get; set; }
        public virtual double ContentBottom { get; set; }
        public virtual double ContentTop { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets MinInsets { get; set; }
        public virtual Size ScaffoldSize { get; set; }
        public virtual Size SnackBarSize { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A snapshot of a transition between two [FloatingActionButtonLocation]s.
    ///
    /// [ScaffoldState] uses this to seamlessly change transition animations
    /// when a running [FloatingActionButtonLocation] transition is interrupted by a new transition.
    /// </Summary>
    public class _TransitionSnapshotFabLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        #region constructors
        public _TransitionSnapshotFabLocation(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation begin, FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation end, FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator animator, double progress)
        {
            this.Begin = begin;
            this.End = end;
            this.Animator = animator;
            this.Progress = progress; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation Begin { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation End { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator Animator { get; set; }
        public virtual double Progress { get; set; }
        #endregion

        #region methods

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// Geometry information for [Scaffold] components after layout is finished.
    ///
    /// To get a [ValueNotifier] for the scaffold geometry of a given
    /// [BuildContext], use [Scaffold.geometryOf].
    ///
    /// The ScaffoldGeometry is only available during the paint phase, because
    /// its value is computed during the animation and layout phases prior to painting.
    ///
    /// For an example of using the [ScaffoldGeometry], see the [BottomAppBar],
    /// which uses the [ScaffoldGeometry] to paint a notch around the
    /// [FloatingActionButton].
    ///
    /// For information about the [Scaffold]'s geometry that is used while laying
    /// out the [FloatingActionButton], see [ScaffoldPrelayoutGeometry].
    /// </Summary>
    public class ScaffoldGeometry
    {
        #region constructors
        public ScaffoldGeometry(double bottomNavigationBarTop = default(double), FlutterBinding.UI.Rect floatingActionButtonArea = default(FlutterBinding.UI.Rect))
        {
            this.BottomNavigationBarTop = bottomNavigationBarTop;
            this.FloatingActionButtonArea = floatingActionButtonArea; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double BottomNavigationBarTop { get; set; }
        public virtual FlutterBinding.UI.Rect FloatingActionButtonArea { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Material.Scaffold.ScaffoldGeometry _ScaleFloatingActionButton(double scaleFactor) { throw new NotImplementedException(); }


        /// <Summary>
        /// Creates a copy of this [ScaffoldGeometry] but with the given fields replaced with
        /// the new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Scaffold.ScaffoldGeometry CopyWith(double bottomNavigationBarTop = default(double), FlutterBinding.UI.Rect floatingActionButtonArea = default(FlutterBinding.UI.Rect)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ScaffoldGeometryNotifier : FlutterSDK.Foundation.Changenotifier.ChangeNotifier, IValueListenable<FlutterSDK.Material.Scaffold.ScaffoldGeometry>
    {
        #region constructors
        public _ScaffoldGeometryNotifier(FlutterSDK.Material.Scaffold.ScaffoldGeometry geometry, FlutterSDK.Widgets.Framework.BuildContext context)
        : base()
        {
            this.Geometry = geometry;
            this.Context = context; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get; set; }
        public virtual double FloatingActionButtonScale { get; set; }
        public virtual FlutterSDK.Material.Scaffold.ScaffoldGeometry Geometry { get; set; }
        public virtual FlutterSDK.Material.Scaffold.ScaffoldGeometry Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _UpdateWith(double bottomNavigationBarTop = default(double), FlutterBinding.UI.Rect floatingActionButtonArea = default(FlutterBinding.UI.Rect), double floatingActionButtonScale = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _BodyBoxConstraints : FlutterSDK.Rendering.Box.BoxConstraints
    {
        #region constructors
        public _BodyBoxConstraints(double minWidth = 0.0, double maxWidth = default(double), double minHeight = 0.0, double maxHeight = default(double), double bottomWidgetsHeight = default(double), double appBarHeight = default(double))
        : base(minWidth: minWidth, maxWidth: maxWidth, minHeight: minHeight, maxHeight: maxHeight)
        {
            this.BottomWidgetsHeight = bottomWidgetsHeight;
            this.AppBarHeight = appBarHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double BottomWidgetsHeight { get; set; }
        public virtual double AppBarHeight { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class _BodyBuilder : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _BodyBuilder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool extendBody = default(bool), bool extendBodyBehindAppBar = default(bool), FlutterSDK.Widgets.Framework.Widget body = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.ExtendBody = extendBody;
            this.ExtendBodyBehindAppBar = extendBodyBehindAppBar;
            this.Body = body; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Body { get; set; }
        public virtual bool ExtendBody { get; set; }
        public virtual bool ExtendBodyBehindAppBar { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ScaffoldLayout : FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate
    {
        #region constructors
        public _ScaffoldLayout(FlutterSDK.Painting.Edgeinsets.EdgeInsets minInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier geometryNotifier = default(FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier), FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation previousFloatingActionButtonLocation = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation), FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation currentFloatingActionButtonLocation = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation), double floatingActionButtonMoveAnimationProgress = default(double), FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator floatingActionButtonMotionAnimator = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator), bool isSnackBarFloating = default(bool), bool extendBody = default(bool), bool extendBodyBehindAppBar = default(bool))
        : base()
        {
            this.MinInsets = minInsets;
            this.TextDirection = textDirection;
            this.GeometryNotifier = geometryNotifier;
            this.PreviousFloatingActionButtonLocation = previousFloatingActionButtonLocation;
            this.CurrentFloatingActionButtonLocation = currentFloatingActionButtonLocation;
            this.FloatingActionButtonMoveAnimationProgress = floatingActionButtonMoveAnimationProgress;
            this.FloatingActionButtonMotionAnimator = floatingActionButtonMotionAnimator;
            this.IsSnackBarFloating = isSnackBarFloating;
            this.ExtendBody = extendBody;
            this.ExtendBodyBehindAppBar = extendBodyBehindAppBar; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool ExtendBody { get; set; }
        public virtual bool ExtendBodyBehindAppBar { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets MinInsets { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier GeometryNotifier { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation PreviousFloatingActionButtonLocation { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation CurrentFloatingActionButtonLocation { get; set; }
        public virtual double FloatingActionButtonMoveAnimationProgress { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator FloatingActionButtonMotionAnimator { get; set; }
        public virtual bool IsSnackBarFloating { get; set; }
        #endregion

        #region methods

        public new void PerformLayout(Size size) { throw new NotImplementedException(); }


        public new bool ShouldRelayout(FlutterSDK.Material.Scaffold._ScaffoldLayout oldDelegate) { throw new NotImplementedException(); }
        public new bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Handler for scale and rotation animations in the [FloatingActionButton].
    ///
    /// Currently, there are two types of [FloatingActionButton] animations:
    ///
    /// * Entrance/Exit animations, which this widget triggers
    ///   when the [FloatingActionButton] is added, updated, or removed.
    /// * Motion animations, which are triggered by the [Scaffold]
    ///   when its [FloatingActionButtonLocation] is updated.
    /// </Summary>
    public class _FloatingActionButtonTransition : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _FloatingActionButtonTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Animation.Animation<double> fabMoveAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator fabMotionAnimator = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator), FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier geometryNotifier = default(FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier), FlutterSDK.Animation.Animationcontroller.AnimationController currentController = default(FlutterSDK.Animation.Animationcontroller.AnimationController))
        : base(key: key)
        {
            this.Child = child;
            this.FabMoveAnimation = fabMoveAnimation;
            this.FabMotionAnimator = fabMotionAnimator;
            this.GeometryNotifier = geometryNotifier;
            this.CurrentController = currentController; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> FabMoveAnimation { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator FabMotionAnimator { get; set; }
        public virtual FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier GeometryNotifier { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController CurrentController { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Scaffold._FloatingActionButtonTransitionState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _FloatingActionButtonTransitionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Scaffold._FloatingActionButtonTransition>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _FloatingActionButtonTransitionState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _PreviousController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _PreviousScaleAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _PreviousRotationAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _CurrentScaleAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ExtendedCurrentScaleAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _CurrentRotationAnimation { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _PreviousChild { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _EntranceTurnTween { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Scaffold._FloatingActionButtonTransition oldWidget) { throw new NotImplementedException(); }


        private void _UpdateAnimations() { throw new NotImplementedException(); }


        private void _HandlePreviousAnimationStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        private bool _IsExtendedFloatingActionButton(FlutterSDK.Widgets.Framework.Widget widget) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private void _OnProgressChanged() { throw new NotImplementedException(); }


        private void _UpdateGeometryScale(double scale) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Implements the basic material design visual layout structure.
    ///
    /// This class provides APIs for showing drawers, snack bars, and bottom sheets.
    ///
    /// To display a snackbar or a persistent bottom sheet, obtain the
    /// [ScaffoldState] for the current [BuildContext] via [Scaffold.of] and use the
    /// [ScaffoldState.showSnackBar] and [ScaffoldState.showBottomSheet] functions.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example shows a [Scaffold] with a [body] and [FloatingActionButton].
    /// The [body] is a [Text] placed in a [Center] in order to center the text
    /// within the [Scaffold]. The [FloatingActionButton] is connected to a
    /// callback that increments a counter.
    ///
    /// ![The Scaffold has a white background with a blue AppBar at the top. A blue FloatingActionButton is positioned at the bottom right corner of the Scaffold.](https://flutter.github.io/assets-for-api-docs/assets/material/scaffold.png)
    ///
    /// ```dart
    /// int _count = 0;
    ///
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('Sample Code'),
    ///     ),
    ///     body: Center(
    ///       child: Text('You have pressed the button $_count times.')
    ///     ),
    ///     floatingActionButton: FloatingActionButton(
    ///       onPressed: () => setState(() => _count++),
    ///       tooltip: 'Increment Counter',
    ///       child: const Icon(Icons.add),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example shows a [Scaffold] with a blueGrey [backgroundColor], [body]
    /// and [FloatingActionButton]. The [body] is a [Text] placed in a [Center] in
    /// order to center the text within the [Scaffold]. The [FloatingActionButton]
    /// is connected to a callback that increments a counter.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/scaffold_background_color.png)
    ///
    /// ```dart
    /// int _count = 0;
    ///
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('Sample Code'),
    ///     ),
    ///     body: Center(
    ///       child: Text('You have pressed the button $_count times.')
    ///     ),
    ///     backgroundColor: Colors.blueGrey.shade200,
    ///     floatingActionButton: FloatingActionButton(
    ///       onPressed: () => setState(() => _count++),
    ///       tooltip: 'Increment Counter',
    ///       child: const Icon(Icons.add),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example shows a [Scaffold] with an [AppBar], a [BottomAppBar] and a
    /// [FloatingActionButton]. The [body] is a [Text] placed in a [Center] in order
    /// to center the text within the [Scaffold]. The [FloatingActionButton] is
    /// centered and docked within the [BottomAppBar] using
    /// [FloatingActionButtonLocation.centerDocked]. The [FloatingActionButton] is
    /// connected to a callback that increments a counter.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/scaffold_bottom_app_bar.png)
    ///
    /// ```dart
    /// int _count = 0;
    ///
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: Text('Sample Code'),
    ///     ),
    ///     body: Center(
    ///       child: Text('You have pressed the button $_count times.'),
    ///     ),
    ///     bottomNavigationBar: BottomAppBar(
    ///       shape: const CircularNotchedRectangle(),
    ///       child: Container(height: 50.0,),
    ///     ),
    ///     floatingActionButton: FloatingActionButton(
    ///       onPressed: () => setState(() {
    ///         _count++;
    ///       }),
    ///       tooltip: 'Increment Counter',
    ///       child: Icon(Icons.add),
    ///     ),
    ///     floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked,
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ## Scaffold layout, the keyboard, and display "notches"
    ///
    /// The scaffold will expand to fill the available space. That usually
    /// means that it will occupy its entire window or device screen. When
    /// the device's keyboard appears the Scaffold's ancestor [MediaQuery]
    /// widget's [MediaQueryData.viewInsets] changes and the Scaffold will
    /// be rebuilt. By default the scaffold's [body] is resized to make
    /// room for the keyboard. To prevent the resize set
    /// [resizeToAvoidBottomInset] to false. In either case the focused
    /// widget will be scrolled into view if it's within a scrollable
    /// container.
    ///
    /// The [MediaQueryData.padding] value defines areas that might
    /// not be completely visible, like the display "notch" on the iPhone
    /// X. The scaffold's [body] is not inset by this padding value
    /// although an [appBar] or [bottomNavigationBar] will typically
    /// cause the body to avoid the padding. The [SafeArea]
    /// widget can be used within the scaffold's body to avoid areas
    /// like display notches.
    ///
    /// ## Troubleshooting
    ///
    /// ### Nested Scaffolds
    ///
    /// The Scaffold was designed to be the single top level container for
    /// a [MaterialApp] and it's typically not necessary to nest
    /// scaffolds. For example in a tabbed UI, where the
    /// [bottomNavigationBar] is a [TabBar] and the body is a
    /// [TabBarView], you might be tempted to make each tab bar view a
    /// scaffold with a differently titled AppBar. It would be better to add a
    /// listener to the [TabController] that updates the AppBar.
    ///
    /// {@tool snippet}
    /// Add a listener to the app's tab controller so that the [AppBar] title of the
    /// app's one and only scaffold is reset each time a new tab is selected.
    ///
    /// ```dart
    /// TabController(vsync: tickerProvider, length: tabCount)..addListener(() {
    ///   if (!tabController.indexIsChanging) {
    ///     setState(() {
    ///       // Rebuild the enclosing scaffold with a new AppBar title
    ///       appBarTitle = 'Tab ${tabController.index}';
    ///     });
    ///   }
    /// })
    /// ```
    /// {@end-tool}
    ///
    /// Although there are some use cases, like a presentation app that
    /// shows embedded flutter content, where nested scaffolds are
    /// appropriate, it's best to avoid nesting scaffolds.
    ///
    /// See also:
    ///
    ///  * [AppBar], which is a horizontal bar typically shown at the top of an app
    ///    using the [appBar] property.
    ///  * [BottomAppBar], which is a horizontal bar typically shown at the bottom
    ///    of an app using the [bottomNavigationBar] property.
    ///  * [FloatingActionButton], which is a circular button typically shown in the
    ///    bottom right corner of the app using the [floatingActionButton] property.
    ///  * [Drawer], which is a vertical panel that is typically displayed to the
    ///    left of the body (and often hidden on phones) using the [drawer]
    ///    property.
    ///  * [BottomNavigationBar], which is a horizontal array of buttons typically
    ///    shown along the bottom of the app using the [bottomNavigationBar]
    ///    property.
    ///  * [SnackBar], which is a temporary notification typically shown near the
    ///    bottom of the app using the [ScaffoldState.showSnackBar] method.
    ///  * [BottomSheet], which is an overlay typically shown near the bottom of the
    ///    app. A bottom sheet can either be persistent, in which case it is shown
    ///    using the [ScaffoldState.showBottomSheet] method, or modal, in which case
    ///    it is shown using the [showModalBottomSheet] function.
    ///  * [ScaffoldState], which is the state associated with this widget.
    ///  * <https://material.io/design/layout/responsive-layout-grid.html>
    /// </Summary>
    public class Scaffold : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Scaffold(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget appBar = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), FlutterSDK.Widgets.Framework.Widget body = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget floatingActionButton = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation floatingActionButtonLocation = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation), FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator floatingActionButtonAnimator = default(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator), List<FlutterSDK.Widgets.Framework.Widget> persistentFooterButtons = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget drawer = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget endDrawer = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget bottomNavigationBar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget bottomSheet = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), bool resizeToAvoidBottomPadding = default(bool), bool resizeToAvoidBottomInset = default(bool), bool primary = true, FlutterSDK.Gestures.Recognizer.DragStartBehavior drawerDragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool extendBody = false, bool extendBodyBehindAppBar = false, FlutterBinding.UI.Color drawerScrimColor = default(FlutterBinding.UI.Color), double drawerEdgeDragWidth = default(double), bool drawerEnableOpenDragGesture = true, bool endDrawerEnableOpenDragGesture = true)
        : base(key: key)
        {
            this.AppBar = appBar;
            this.Body = body;
            this.FloatingActionButton = floatingActionButton;
            this.FloatingActionButtonLocation = floatingActionButtonLocation;
            this.FloatingActionButtonAnimator = floatingActionButtonAnimator;
            this.PersistentFooterButtons = persistentFooterButtons;
            this.Drawer = drawer;
            this.EndDrawer = endDrawer;
            this.BottomNavigationBar = bottomNavigationBar;
            this.BottomSheet = bottomSheet;
            this.BackgroundColor = backgroundColor;
            this.ResizeToAvoidBottomPadding = resizeToAvoidBottomPadding;
            this.ResizeToAvoidBottomInset = resizeToAvoidBottomInset;
            this.Primary = primary;
            this.DrawerDragStartBehavior = drawerDragStartBehavior;
            this.ExtendBody = extendBody;
            this.ExtendBodyBehindAppBar = extendBodyBehindAppBar;
            this.DrawerScrimColor = drawerScrimColor;
            this.DrawerEdgeDragWidth = drawerEdgeDragWidth;
            this.DrawerEnableOpenDragGesture = drawerEnableOpenDragGesture;
            this.EndDrawerEnableOpenDragGesture = endDrawerEnableOpenDragGesture; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool ExtendBody { get; set; }
        public virtual bool ExtendBodyBehindAppBar { get; set; }
        public virtual FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget AppBar { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Body { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget FloatingActionButton { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation FloatingActionButtonLocation { get; set; }
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator FloatingActionButtonAnimator { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> PersistentFooterButtons { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Drawer { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget EndDrawer { get; set; }
        public virtual FlutterBinding.UI.Color DrawerScrimColor { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomNavigationBar { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomSheet { get; set; }
        public virtual bool ResizeToAvoidBottomPadding { get; set; }
        public virtual bool ResizeToAvoidBottomInset { get; set; }
        public virtual bool Primary { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DrawerDragStartBehavior { get; set; }
        public virtual double DrawerEdgeDragWidth { get; set; }
        public virtual bool DrawerEnableOpenDragGesture { get; set; }
        public virtual bool EndDrawerEnableOpenDragGesture { get; set; }
        public virtual bool ShouldSnackBarIgnoreFABRect { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// The state from the closest instance of this class that encloses the given context.
        ///
        /// {@tool dartpad --template=freeform}
        /// Typical usage of the [Scaffold.of] function is to call it from within the
        /// `build` method of a child of a [Scaffold].
        ///
        /// ```dart imports
        /// import 'package:flutter/material.dart';
        /// ```
        ///
        /// ```dart main
        /// void main() => runApp(MyApp());
        /// ```
        ///
        /// ```dart preamble
        /// class MyApp extends StatelessWidget {
        ///   // This widget is the root of your application.
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return MaterialApp(
        ///       title: 'Flutter Code Sample for Scaffold.of.',
        ///       theme: ThemeData(
        ///         primarySwatch: Colors.blue,
        ///       ),
        ///       home: Scaffold(
        ///         body: MyScaffoldBody(),
        ///         appBar: AppBar(title: Text('Scaffold.of Example')),
        ///       ),
        ///       color: Colors.white,
        ///     );
        ///   }
        /// }
        /// ```
        ///
        /// ```dart
        /// class MyScaffoldBody extends StatelessWidget {
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return Center(
        ///       child: RaisedButton(
        ///         child: Text('SHOW A SNACKBAR'),
        ///         onPressed: () {
        ///           Scaffold.of(context).showSnackBar(
        ///             SnackBar(
        ///               content: Text('Have a snack!'),
        ///             ),
        ///           );
        ///         },
        ///       ),
        ///     );
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// {@tool dartpad --template=stateless_widget_material}
        /// When the [Scaffold] is actually created in the same `build` function, the
        /// `context` argument to the `build` function can't be used to find the
        /// [Scaffold] (since it's "above" the widget being returned in the widget
        /// tree). In such cases, the following technique with a [Builder] can be used
        /// to provide a new scope with a [BuildContext] that is "under" the
        /// [Scaffold]:
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return Scaffold(
        ///     appBar: AppBar(
        ///       title: Text('Demo')
        ///     ),
        ///     body: Builder(
        ///       // Create an inner BuildContext so that the onPressed methods
        ///       // can refer to the Scaffold with Scaffold.of().
        ///       builder: (BuildContext context) {
        ///         return Center(
        ///           child: RaisedButton(
        ///             child: Text('SHOW A SNACKBAR'),
        ///             onPressed: () {
        ///               Scaffold.of(context).showSnackBar(SnackBar(
        ///                 content: Text('Have a snack!'),
        ///               ));
        ///             },
        ///           ),
        ///         );
        ///       },
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// A more efficient solution is to split your build function into several
        /// widgets. This introduces a new context from which you can obtain the
        /// [Scaffold]. In this solution, you would have an outer widget that creates
        /// the [Scaffold] populated by instances of your new inner widgets, and then
        /// in these inner widgets you would use [Scaffold.of].
        ///
        /// A less elegant but more expedient solution is assign a [GlobalKey] to the
        /// [Scaffold], then use the `key.currentState` property to obtain the
        /// [ScaffoldState] rather than using the [Scaffold.of] function.
        ///
        /// If there is no [Scaffold] in scope, then this will throw an exception.
        /// To return null if there is no [Scaffold], then pass `nullOk: true`.
        /// </Summary>
        public virtual FlutterSDK.Material.Scaffold.ScaffoldState Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a [ValueListenable] for the [ScaffoldGeometry] for the closest
        /// [Scaffold] ancestor of the given context.
        ///
        /// The [ValueListenable.value] is only available at paint time.
        ///
        /// Notifications are guaranteed to be sent before the first paint pass
        /// with the new geometry, but there is no guarantee whether a build or
        /// layout passes are going to happen between the notification and the next
        /// paint pass.
        ///
        /// The closest [Scaffold] ancestor for the context might change, e.g when
        /// an element is moved from one scaffold to another. For [StatefulWidget]s
        /// using this listenable, a change of the [Scaffold] ancestor will
        /// trigger a [State.didChangeDependencies].
        ///
        /// A typical pattern for listening to the scaffold geometry would be to
        /// call [Scaffold.geometryOf] in [State.didChangeDependencies], compare the
        /// return value with the previous listenable, if it has changed, unregister
        /// the listener, and register a listener to the new [ScaffoldGeometry]
        /// listenable.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Changenotifier.ValueListenable<FlutterSDK.Material.Scaffold.ScaffoldGeometry> GeometryOf(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        /// <Summary>
        /// Whether the Scaffold that most tightly encloses the given context has a
        /// drawer.
        ///
        /// If this is being used during a build (for example to decide whether to
        /// show an "open drawer" button), set the `registerForUpdates` argument to
        /// true. This will then set up an [InheritedWidget] relationship with the
        /// [Scaffold] so that the client widget gets rebuilt whenever the [hasDrawer]
        /// value changes.
        ///
        /// See also:
        ///
        ///  * [Scaffold.of], which provides access to the [ScaffoldState] object as a
        ///    whole, from which you can show snackbars, bottom sheets, and so forth.
        /// </Summary>
        public virtual bool HasDrawer(FlutterSDK.Widgets.Framework.BuildContext context, bool registerForUpdates = true) { throw new NotImplementedException(); }


        public new FlutterSDK.Material.Scaffold.ScaffoldState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// State for a [Scaffold].
    ///
    /// Can display [SnackBar]s and [BottomSheet]s. Retrieve a [ScaffoldState] from
    /// the current [BuildContext] using [Scaffold.of].
    /// </Summary>
    public class ScaffoldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Scaffold.Scaffold>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public ScaffoldState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Material.Drawer.DrawerControllerState> _DrawerKey { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Material.Drawer.DrawerControllerState> _EndDrawerKey { get; set; }
        internal virtual double _AppBarMaxHeight { get; set; }
        internal virtual bool _DrawerOpened { get; set; }
        internal virtual bool _EndDrawerOpened { get; set; }
        internal virtual Queue<FlutterSDK.Material.Scaffold.ScaffoldFeatureController<FlutterSDK.Material.Snackbar.SnackBar, FlutterSDK.Material.Snackbar.SnackBarClosedReason>> _SnackBars { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _SnackBarController { get; set; }
        internal virtual Timer _SnackBarTimer { get; set; }
        internal virtual bool _AccessibleNavigation { get; set; }
        internal virtual List<FlutterSDK.Material.Scaffold._StandardBottomSheet> _DismissedBottomSheets { get; set; }
        internal virtual FlutterSDK.Material.Scaffold.PersistentBottomSheetController<object> _CurrentBottomSheet { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FloatingActionButtonMoveController { get; set; }
        internal virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator _FloatingActionButtonAnimator { get; set; }
        internal virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation _PreviousFloatingActionButtonLocation { get; set; }
        internal virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation _FloatingActionButtonLocation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FloatingActionButtonVisibilityController { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _PrimaryScrollController { get; set; }
        internal virtual FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier _GeometryNotifier { get; set; }
        internal virtual bool _ShowBodyScrim { get; set; }
        internal virtual FlutterBinding.UI.Color _BodyScrimColor { get; set; }
        public virtual bool HasAppBar { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasDrawer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasEndDrawer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasFloatingActionButton { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double AppBarMaxHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsDrawerOpen { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEndDrawerOpen { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _FloatingActionButtonVisibilityValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _ResizeToAvoidBottomInset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _DrawerOpenedCallback(bool isOpened) { throw new NotImplementedException(); }


        private void _EndDrawerOpenedCallback(bool isOpened) { throw new NotImplementedException(); }


        /// <Summary>
        /// Opens the [Drawer] (if any).
        ///
        /// If the scaffold has a non-null [Scaffold.drawer], this function will cause
        /// the drawer to begin its entrance animation.
        ///
        /// Normally this is not needed since the [Scaffold] automatically shows an
        /// appropriate [IconButton], and handles the edge-swipe gesture, to show the
        /// drawer.
        ///
        /// To close the drawer once it is open, use [Navigator.pop].
        ///
        /// See [Scaffold.of] for information about how to obtain the [ScaffoldState].
        /// </Summary>
        public virtual void OpenDrawer() { throw new NotImplementedException(); }


        /// <Summary>
        /// Opens the end side [Drawer] (if any).
        ///
        /// If the scaffold has a non-null [Scaffold.endDrawer], this function will cause
        /// the end side drawer to begin its entrance animation.
        ///
        /// Normally this is not needed since the [Scaffold] automatically shows an
        /// appropriate [IconButton], and handles the edge-swipe gesture, to show the
        /// drawer.
        ///
        /// To close the end side drawer once it is open, use [Navigator.pop].
        ///
        /// See [Scaffold.of] for information about how to obtain the [ScaffoldState].
        /// </Summary>
        public virtual void OpenEndDrawer() { throw new NotImplementedException(); }


        /// <Summary>
        /// Shows a [SnackBar] at the bottom of the scaffold.
        ///
        /// A scaffold can show at most one snack bar at a time. If this function is
        /// called while another snack bar is already visible, the given snack bar
        /// will be added to a queue and displayed after the earlier snack bars have
        /// closed.
        ///
        /// To control how long a [SnackBar] remains visible, use [SnackBar.duration].
        ///
        /// To remove the [SnackBar] with an exit animation, use [hideCurrentSnackBar]
        /// or call [ScaffoldFeatureController.close] on the returned
        /// [ScaffoldFeatureController]. To remove a [SnackBar] suddenly (without an
        /// animation), use [removeCurrentSnackBar].
        ///
        /// See [Scaffold.of] for information about how to obtain the [ScaffoldState].
        /// </Summary>
        public virtual FlutterSDK.Material.Scaffold.ScaffoldFeatureController<FlutterSDK.Material.Snackbar.SnackBar, FlutterSDK.Material.Snackbar.SnackBarClosedReason> ShowSnackBar(FlutterSDK.Material.Snackbar.SnackBar snackbar) { throw new NotImplementedException(); }


        private void _HandleSnackBarStatusChange(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        /// <Summary>
        /// Removes the current [SnackBar] (if any) immediately.
        ///
        /// The removed snack bar does not run its normal exit animation. If there are
        /// any queued snack bars, they begin their entrance animation immediately.
        /// </Summary>
        public virtual void RemoveCurrentSnackBar(FlutterSDK.Material.Snackbar.SnackBarClosedReason reason = default(FlutterSDK.Material.Snackbar.SnackBarClosedReason)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Removes the current [SnackBar] by running its normal exit animation.
        ///
        /// The closed completer is called after the animation is complete.
        /// </Summary>
        public virtual void HideCurrentSnackBar(FlutterSDK.Material.Snackbar.SnackBarClosedReason reason = default(FlutterSDK.Material.Snackbar.SnackBarClosedReason)) { throw new NotImplementedException(); }


        private void _MaybeBuildPersistentBottomSheet() { throw new NotImplementedException(); }


        private void _CloseCurrentBottomSheet() { throw new NotImplementedException(); }


        private PersistentBottomSheetController<T> _BuildBottomSheet<T>(FlutterSDK.Widgets.Framework.WidgetBuilder builder, bool isPersistent, FlutterSDK.Animation.Animationcontroller.AnimationController animationController = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Shows a material design bottom sheet in the nearest [Scaffold]. To show
        /// a persistent bottom sheet, use the [Scaffold.bottomSheet].
        ///
        /// Returns a controller that can be used to close and otherwise manipulate the
        /// bottom sheet.
        ///
        /// To rebuild the bottom sheet (e.g. if it is stateful), call
        /// [PersistentBottomSheetController.setState] on the controller returned by
        /// this method.
        ///
        /// The new bottom sheet becomes a [LocalHistoryEntry] for the enclosing
        /// [ModalRoute] and a back button is added to the app bar of the [Scaffold]
        /// that closes the bottom sheet.
        ///
        /// To create a persistent bottom sheet that is not a [LocalHistoryEntry] and
        /// does not add a back button to the enclosing Scaffold's app bar, use the
        /// [Scaffold.bottomSheet] constructor parameter.
        ///
        /// A persistent bottom sheet shows information that supplements the primary
        /// content of the app. A persistent bottom sheet remains visible even when
        /// the user interacts with other parts of the app.
        ///
        /// A closely related widget is a modal bottom sheet, which is an alternative
        /// to a menu or a dialog and prevents the user from interacting with the rest
        /// of the app. Modal bottom sheets can be created and displayed with the
        /// [showModalBottomSheet] function.
        ///
        /// {@tool dartpad --template=stateless_widget_scaffold}
        ///
        /// This example demonstrates how to use `showBottomSheet` to display a
        /// bottom sheet when a user taps a button. It also demonstrates how to
        /// close a bottom sheet using the Navigator.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return Center(
        ///     child: RaisedButton(
        ///       child: const Text('showBottomSheet'),
        ///       onPressed: () {
        ///         Scaffold.of(context).showBottomSheet<void>(
        ///           (BuildContext context) {
        ///             return Container(
        ///               height: 200,
        ///               color: Colors.amber,
        ///               child: Center(
        ///                 child: Column(
        ///                   mainAxisAlignment: MainAxisAlignment.center,
        ///                   mainAxisSize: MainAxisSize.min,
        ///                   children: <Widget>[
        ///                     const Text('BottomSheet'),
        ///                     RaisedButton(
        ///                       child: const Text('Close BottomSheet'),
        ///                       onPressed: () => Navigator.pop(context),
        ///                     )
        ///                   ],
        ///                 ),
        ///               ),
        ///             );
        ///           },
        ///         );
        ///       },
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// See also:
        ///
        ///  * [BottomSheet], which becomes the parent of the widget returned by the
        ///    `builder`.
        ///  * [showBottomSheet], which calls this method given a [BuildContext].
        ///  * [showModalBottomSheet], which can be used to display a modal bottom
        ///    sheet.
        ///  * [Scaffold.of], for information about how to obtain the [ScaffoldState].
        ///  * <https://material.io/design/components/sheets-bottom.html#standard-bottom-sheet>
        /// </Summary>
        public virtual PersistentBottomSheetController<T> ShowBottomSheet<T>(FlutterSDK.Widgets.Framework.WidgetBuilder builder, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Shows the [Scaffold.floatingActionButton].
        /// </Summary>
        private FlutterSDK.Scheduler.Ticker.TickerFuture _ShowFloatingActionButton() { throw new NotImplementedException(); }


        private void _MoveFloatingActionButton(FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation newLocation) { throw new NotImplementedException(); }


        private void _HandleStatusBarTap() { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Scaffold.Scaffold oldWidget) { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _AddIfNonNull(List<FlutterSDK.Widgets.Basic.LayoutId> children, FlutterSDK.Widgets.Framework.Widget child, @Object childId, bool removeLeftPadding = default(bool), bool removeTopPadding = default(bool), bool removeRightPadding = default(bool), bool removeBottomPadding = default(bool), bool removeBottomInset = false, bool maintainBottomViewPadding = false) { throw new NotImplementedException(); }


        private void _BuildEndDrawer(List<FlutterSDK.Widgets.Basic.LayoutId> children, TextDirection textDirection) { throw new NotImplementedException(); }


        private void _BuildDrawer(List<FlutterSDK.Widgets.Basic.LayoutId> children, TextDirection textDirection) { throw new NotImplementedException(); }


        /// <Summary>
        /// Whether to show a [ModalBarrier] over the body of the scaffold.
        ///
        /// The `value` parameter must not be null.
        /// </Summary>
        public virtual void ShowBodyScrim(bool value, double opacity) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An interface for controlling a feature of a [Scaffold].
    ///
    /// Commonly obtained from [ScaffoldState.showSnackBar] or [ScaffoldState.showBottomSheet].
    /// </Summary>
    public class ScaffoldFeatureController<T, U>
    {
        #region constructors
        internal ScaffoldFeatureController(T _widget, Completer<U> _completer, VoidCallback close, FlutterSDK.Widgets.Framework.StateSetter setState)
        {
            this._Widget = _widget;
            this._Completer = _completer;
            this.Close = close;
            this.SetState = setState; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual T _Widget { get; set; }
        internal virtual Completer<U> _Completer { get; set; }
        public virtual VoidCallback Close { get; set; }
        public virtual FlutterSDK.Widgets.Framework.StateSetter SetState { get; set; }
        public virtual Future<U> Closed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A curve that progresses linearly until a specified [startingPoint], at which
    /// point [curve] will begin. Unlike [Interval], [curve] will not start at zero,
    /// but will use [startingPoint] as the Y position.
    ///
    /// For example, if [startingPoint] is set to `0.5`, and [curve] is set to
    /// [Curves.easeOut], then the bottom-left quarter of the curve will be a
    /// straight line, and the top-right quarter will contain the entire contents of
    /// [Curves.easeOut].
    ///
    /// This is useful in situations where a widget must track the user's finger
    /// (which requires a linear animation), and afterwards can be flung using a
    /// curve specified with the [curve] argument, after the finger is released. In
    /// such a case, the value of [startingPoint] would be the progress of the
    /// animation at the time when the finger was released.
    ///
    /// The [startingPoint] and [curve] arguments must not be null.
    /// </Summary>
    public class _BottomSheetSuspendedCurve : FlutterSDK.Animation.Curves.ParametricCurve<double>
    {
        #region constructors
        public _BottomSheetSuspendedCurve(double startingPoint, FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        : base()
        {
            this.StartingPoint = startingPoint;
            this.Curve = curve; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double StartingPoint { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
        #endregion

        #region methods

        public new double Transform(double t) { throw new NotImplementedException(); }


        #endregion
    }


    public class _StandardBottomSheet : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _StandardBottomSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animationcontroller.AnimationController animationController = default(FlutterSDK.Animation.Animationcontroller.AnimationController), bool enableDrag = true, VoidCallback onClosing = default(VoidCallback), VoidCallback onDismissed = default(VoidCallback), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool isPersistent = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
        : base(key: key)
        {
            this.AnimationController = animationController;
            this.EnableDrag = enableDrag;
            this.OnClosing = onClosing;
            this.OnDismissed = onDismissed;
            this.Builder = builder;
            this.IsPersistent = isPersistent;
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController AnimationController { get; set; }
        public virtual bool EnableDrag { get; set; }
        public virtual VoidCallback OnClosing { get; set; }
        public virtual VoidCallback OnDismissed { get; set; }
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
        public virtual bool IsPersistent { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Scaffold._StandardBottomSheetState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _StandardBottomSheetState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Scaffold._StandardBottomSheet>
    {
        #region constructors
        public _StandardBottomSheetState()
        { }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Curves.ParametricCurve<double> AnimationCurve { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Scaffold._StandardBottomSheet oldWidget) { throw new NotImplementedException(); }


        public virtual Future<object> Close() { throw new NotImplementedException(); }


        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details, bool isClosing = default(bool)) { throw new NotImplementedException(); }


        private void _HandleStatusChange(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        public virtual bool ExtentChanged(FlutterSDK.Widgets.Draggablescrollablesheet.DraggableScrollableNotification notification) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _WrapBottomSheet(FlutterSDK.Widgets.Framework.Widget bottomSheet) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A [ScaffoldFeatureController] for standard bottom sheets.
    ///
    /// This is the type of objects returned by [ScaffoldState.showBottomSheet].
    ///
    /// This controller is used to display both standard and persistent bottom
    /// sheets. A bottom sheet is only persistent if it is set as the
    /// [Scaffold.bottomSheet].
    /// </Summary>
    public class PersistentBottomSheetController<T> : FlutterSDK.Material.Scaffold.ScaffoldFeatureController<FlutterSDK.Material.Scaffold._StandardBottomSheet, T>
    {
        #region constructors
        internal PersistentBottomSheetController(FlutterSDK.Material.Scaffold._StandardBottomSheet widget, Completer<T> completer, VoidCallback close, FlutterSDK.Widgets.Framework.StateSetter setState, bool _isLocalHistoryEntry)
        : base(widget, completer, close, setState)
        {
            this._IsLocalHistoryEntry = _isLocalHistoryEntry; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual bool _IsLocalHistoryEntry { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _ScaffoldScope : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public _ScaffoldScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool hasDrawer = default(bool), FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier geometryNotifier = default(FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.HasDrawer = hasDrawer;
            this.GeometryNotifier = geometryNotifier; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool HasDrawer { get; set; }
        public virtual FlutterSDK.Material.Scaffold._ScaffoldGeometryNotifier GeometryNotifier { get; set; }
        #endregion

        #region methods

        public new bool UpdateShouldNotify(FlutterSDK.Material.Scaffold._ScaffoldScope oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public enum _ScaffoldSlot
    {

        Body,
        AppBar,
        BodyScrim,
        BottomSheet,
        SnackBar,
        PersistentFooter,
        BottomNavigationBar,
        FloatingActionButton,
        Drawer,
        EndDrawer,
        StatusBar,
    }

}
