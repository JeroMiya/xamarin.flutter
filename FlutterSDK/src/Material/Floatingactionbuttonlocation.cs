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
namespace FlutterSDK.Material.Floatingactionbuttonlocation
{
    internal static class FloatingactionbuttonlocationDefaultClass
    {
        public static double KFloatingActionButtonMargin = default(double);
        public static TimeSpan KFloatingActionButtonSegue = default(TimeSpan);
        public static double KFloatingActionButtonTurnInterval = default(double);
        internal static double _LeftOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry, double offset = 0.0)
        {
            return FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin + scaffoldGeometry.MinInsets.Left - offset;
        }



        internal static double _RightOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry, double offset = 0.0)
        {
            return scaffoldGeometry.ScaffoldSize.Width - FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin - scaffoldGeometry.MinInsets.Right - scaffoldGeometry.FloatingActionButtonSize.Width + offset;
        }



        internal static double _EndOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry, double offset = 0.0)
        {

            switch (scaffoldGeometry.TextDirection) { case TextDirection.Rtl: return FloatingactionbuttonlocationDefaultClass._LeftOffset(scaffoldGeometry, offset: offset); case TextDirection.Ltr: return FloatingactionbuttonlocationDefaultClass._RightOffset(scaffoldGeometry, offset: offset); }
            return null;
        }



        internal static double _StartOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry, double offset = 0.0)
        {

            switch (scaffoldGeometry.TextDirection) { case TextDirection.Rtl: return FloatingactionbuttonlocationDefaultClass._RightOffset(scaffoldGeometry, offset: offset); case TextDirection.Ltr: return FloatingactionbuttonlocationDefaultClass._LeftOffset(scaffoldGeometry, offset: offset); }
            return null;
        }



        internal static double _StraddleAppBar(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            double fabHalfHeight = scaffoldGeometry.FloatingActionButtonSize.Height / 2.0;
            return scaffoldGeometry.ContentTop - fabHalfHeight;
        }



    }

    /// <Summary>
    /// An object that defines a position for the [FloatingActionButton]
    /// based on the [Scaffold]'s [ScaffoldPrelayoutGeometry].
    ///
    /// Flutter provides [FloatingActionButtonLocation]s for the common
    /// [FloatingActionButton] placements in Material Design applications. These
    /// locations are available as static members of this class.
    ///
    /// See also:
    ///
    ///  * [FloatingActionButton], which is a circular button typically shown in the
    ///    bottom right corner of the app.
    ///  * [FloatingActionButtonAnimator], which is used to animate the
    ///    [Scaffold.floatingActionButton] from one [FloatingActionButtonLocation] to
    ///    another.
    ///  * [ScaffoldPrelayoutGeometry], the geometry that
    ///    [FloatingActionButtonLocation]s use to position the [FloatingActionButton].
    /// </Summary>
    public interface IFloatingActionButtonLocation
    {
        Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry);
        string ToString();
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation EndFloat { get; }
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation CenterFloat { get; }
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation EndDocked { get; }
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation CenterDocked { get; }
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation StartTop { get; }
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation MiniStartTop { get; }
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation EndTop { get; }
    }


    internal interface I_DockedFloatingActionButtonLocation
    {
        double GetDockedY(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry);
    }


    /// <Summary>
    /// Provider of animations to move the [FloatingActionButton] between [FloatingActionButtonLocation]s.
    ///
    /// The [Scaffold] uses [Scaffold.floatingActionButtonAnimator] to define:
    ///
    ///  * The [Offset] of the [FloatingActionButton] between the old and new
    ///    [FloatingActionButtonLocation]s as part of the transition animation.
    ///  * An [Animation] to scale the [FloatingActionButton] during the transition.
    ///  * An [Animation] to rotate the [FloatingActionButton] during the transition.
    ///  * Where to start a new animation from if an animation is interrupted.
    ///
    /// See also:
    ///
    ///  * [FloatingActionButton], which is a circular button typically shown in the
    ///    bottom right corner of the app.
    ///  * [FloatingActionButtonLocation], which the [Scaffold] uses to place the
    ///    [Scaffold.floatingActionButton] within the [Scaffold]'s layout.
    /// </Summary>
    public interface IFloatingActionButtonAnimator
    {
        Offset GetOffset(FlutterBinding.UI.Offset begin = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset end = default(FlutterBinding.UI.Offset), double progress = default(double));
        FlutterSDK.Animation.Animation.Animation<double> GetScaleAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>));
        FlutterSDK.Animation.Animation.Animation<double> GetRotationAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>));
        double GetAnimationRestart(double previousValue);
        string ToString();
        FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator Scaling { get; }
    }


    /// <Summary>
    /// An object that defines a position for the [FloatingActionButton]
    /// based on the [Scaffold]'s [ScaffoldPrelayoutGeometry].
    ///
    /// Flutter provides [FloatingActionButtonLocation]s for the common
    /// [FloatingActionButton] placements in Material Design applications. These
    /// locations are available as static members of this class.
    ///
    /// See also:
    ///
    ///  * [FloatingActionButton], which is a circular button typically shown in the
    ///    bottom right corner of the app.
    ///  * [FloatingActionButtonAnimator], which is used to animate the
    ///    [Scaffold.floatingActionButton] from one [FloatingActionButtonLocation] to
    ///    another.
    ///  * [ScaffoldPrelayoutGeometry], the geometry that
    ///    [FloatingActionButtonLocation]s use to position the [FloatingActionButton].
    /// </Summary>
    public class FloatingActionButtonLocation
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public FloatingActionButtonLocation()
        {

        }
        /// <Summary>
        /// End-aligned [FloatingActionButton], floating at the bottom of the screen.
        ///
        /// This is the default alignment of [FloatingActionButton]s in Material applications.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation EndFloat { get; set; }
        /// <Summary>
        /// Centered [FloatingActionButton], floating at the bottom of the screen.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation CenterFloat { get; set; }
        /// <Summary>
        /// End-aligned [FloatingActionButton], floating over the
        /// [Scaffold.bottomNavigationBar] so that the center of the floating
        /// action button lines up with the top of the bottom navigation bar.
        ///
        /// If the value of [Scaffold.bottomNavigationBar] is a [BottomAppBar],
        /// the bottom app bar can include a "notch" in its shape that accommodates
        /// the overlapping floating action button.
        ///
        /// This is unlikely to be a useful location for apps that lack a bottom
        /// navigation bar.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation EndDocked { get; set; }
        /// <Summary>
        /// Center-aligned [FloatingActionButton], floating over the
        /// [Scaffold.bottomNavigationBar] so that the center of the floating
        /// action button lines up with the top of the bottom navigation bar.
        ///
        /// If the value of [Scaffold.bottomNavigationBar] is a [BottomAppBar],
        /// the bottom app bar can include a "notch" in its shape that accommodates
        /// the overlapping floating action button.
        ///
        /// This is unlikely to be a useful location for apps that lack a bottom
        /// navigation bar.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation CenterDocked { get; set; }
        /// <Summary>
        /// Start-aligned [FloatingActionButton], floating over the transition between
        /// the [Scaffold.appBar] and the [Scaffold.body].
        ///
        /// To align a floating action button with [FloatingActionButton.mini] set to
        /// true with [CircleAvatar]s in the [ListTile.leading] slots of [ListTile]s
        /// in a [ListView] in the [Scaffold.body], consider using [miniStartTop].
        ///
        /// This is unlikely to be a useful location for apps that lack a top [AppBar]
        /// or that use a [SliverAppBar] in the scaffold body itself.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation StartTop { get; set; }
        /// <Summary>
        /// Start-aligned [FloatingActionButton], floating over the transition between
        /// the [Scaffold.appBar] and the [Scaffold.body], optimized for mini floating
        /// action buttons.
        ///
        /// This is intended to be used with [FloatingActionButton.mini] set to true,
        /// so that the floating action button appears to align with [CircleAvatar]s
        /// in the [ListTile.leading] slot of a [ListTile] in a [ListView] in the
        /// [Scaffold.body].
        ///
        /// This is unlikely to be a useful location for apps that lack a top [AppBar]
        /// or that use a [SliverAppBar] in the scaffold body itself.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation MiniStartTop { get; set; }
        /// <Summary>
        /// End-aligned [FloatingActionButton], floating over the transition between
        /// the [Scaffold.appBar] and the [Scaffold.body].
        ///
        /// This is unlikely to be a useful location for apps that lack a top [AppBar]
        /// or that use a [SliverAppBar] in the scaffold body itself.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation EndTop { get; set; }

        /// <Summary>
        /// Places the [FloatingActionButton] based on the [Scaffold]'s layout.
        ///
        /// This uses a [ScaffoldPrelayoutGeometry], which the [Scaffold] constructs
        /// during its layout phase after it has laid out every widget it can lay out
        /// except the [FloatingActionButton]. The [Scaffold] uses the [Offset]
        /// returned from this method to position the [FloatingActionButton] and
        /// complete its layout.
        /// </Summary>
        public virtual Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            return default(Offset);
        }


    }


    public class _CenterFloatFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        public _CenterFloatFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            double fabX = (scaffoldGeometry.ScaffoldSize.Width - scaffoldGeometry.FloatingActionButtonSize.Width) / 2.0;
            double contentBottom = scaffoldGeometry.ContentBottom;
            double bottomSheetHeight = scaffoldGeometry.BottomSheetSize.Height;
            double fabHeight = scaffoldGeometry.FloatingActionButtonSize.Height;
            double snackBarHeight = scaffoldGeometry.SnackBarSize.Height;
            double fabY = contentBottom - fabHeight - FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin;
            if (snackBarHeight > 0.0) fabY = Dart.Math.MathDefaultClass.Min(fabY, contentBottom - snackBarHeight - fabHeight - FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin);
            if (bottomSheetHeight > 0.0) fabY = Dart.Math.MathDefaultClass.Min(fabY, contentBottom - bottomSheetHeight - fabHeight / 2.0);
            return new Offset(fabX, fabY);
        }




    }


    public class _EndFloatFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        public _EndFloatFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            double fabX = FloatingactionbuttonlocationDefaultClass._EndOffset(scaffoldGeometry);
            double contentBottom = scaffoldGeometry.ContentBottom;
            double bottomSheetHeight = scaffoldGeometry.BottomSheetSize.Height;
            double fabHeight = scaffoldGeometry.FloatingActionButtonSize.Height;
            double snackBarHeight = scaffoldGeometry.SnackBarSize.Height;
            double fabY = contentBottom - fabHeight - FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin;
            if (snackBarHeight > 0.0) fabY = Dart.Math.MathDefaultClass.Min(fabY, contentBottom - snackBarHeight - fabHeight - FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin);
            if (bottomSheetHeight > 0.0) fabY = Dart.Math.MathDefaultClass.Min(fabY, contentBottom - bottomSheetHeight - fabHeight / 2.0);
            return new Offset(fabX, fabY);
        }




    }


    public class _DockedFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        public _DockedFloatingActionButtonLocation()
        {

        }

        public virtual double GetDockedY(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            double contentBottom = scaffoldGeometry.ContentBottom;
            double bottomSheetHeight = scaffoldGeometry.BottomSheetSize.Height;
            double fabHeight = scaffoldGeometry.FloatingActionButtonSize.Height;
            double snackBarHeight = scaffoldGeometry.SnackBarSize.Height;
            double fabY = contentBottom - fabHeight / 2.0;
            if (snackBarHeight > 0.0) fabY = Dart.Math.MathDefaultClass.Min(fabY, contentBottom - snackBarHeight - fabHeight - FloatingactionbuttonlocationDefaultClass.KFloatingActionButtonMargin);
            if (bottomSheetHeight > 0.0) fabY = Dart.Math.MathDefaultClass.Min(fabY, contentBottom - bottomSheetHeight - fabHeight / 2.0);
            double maxFabY = scaffoldGeometry.ScaffoldSize.Height - fabHeight;
            return Dart.Math.MathDefaultClass.Min(maxFabY, fabY);
        }



    }


    public class _EndDockedFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation._DockedFloatingActionButtonLocation
    {
        public _EndDockedFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            double fabX = FloatingactionbuttonlocationDefaultClass._EndOffset(scaffoldGeometry);
            return new Offset(fabX, GetDockedY(scaffoldGeometry));
        }




    }


    public class _CenterDockedFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation._DockedFloatingActionButtonLocation
    {
        public _CenterDockedFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            double fabX = (scaffoldGeometry.ScaffoldSize.Width - scaffoldGeometry.FloatingActionButtonSize.Width) / 2.0;
            return new Offset(fabX, GetDockedY(scaffoldGeometry));
        }




    }


    public class _StartTopFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        public _StartTopFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            return new Offset(FloatingactionbuttonlocationDefaultClass._StartOffset(scaffoldGeometry), FloatingactionbuttonlocationDefaultClass._StraddleAppBar(scaffoldGeometry));
        }




    }


    public class _MiniStartTopFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        public _MiniStartTopFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            return new Offset(FloatingactionbuttonlocationDefaultClass._StartOffset(scaffoldGeometry, offset: 4.0), FloatingactionbuttonlocationDefaultClass._StraddleAppBar(scaffoldGeometry));
        }




    }


    public class _EndTopFloatingActionButtonLocation : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonLocation
    {
        public _EndTopFloatingActionButtonLocation()
        {

        }

        public new Offset GetOffset(FlutterSDK.Material.Scaffold.ScaffoldPrelayoutGeometry scaffoldGeometry)
        {
            return new Offset(FloatingactionbuttonlocationDefaultClass._EndOffset(scaffoldGeometry), FloatingactionbuttonlocationDefaultClass._StraddleAppBar(scaffoldGeometry));
        }




    }


    /// <Summary>
    /// Provider of animations to move the [FloatingActionButton] between [FloatingActionButtonLocation]s.
    ///
    /// The [Scaffold] uses [Scaffold.floatingActionButtonAnimator] to define:
    ///
    ///  * The [Offset] of the [FloatingActionButton] between the old and new
    ///    [FloatingActionButtonLocation]s as part of the transition animation.
    ///  * An [Animation] to scale the [FloatingActionButton] during the transition.
    ///  * An [Animation] to rotate the [FloatingActionButton] during the transition.
    ///  * Where to start a new animation from if an animation is interrupted.
    ///
    /// See also:
    ///
    ///  * [FloatingActionButton], which is a circular button typically shown in the
    ///    bottom right corner of the app.
    ///  * [FloatingActionButtonLocation], which the [Scaffold] uses to place the
    ///    [Scaffold.floatingActionButton] within the [Scaffold]'s layout.
    /// </Summary>
    public class FloatingActionButtonAnimator
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public FloatingActionButtonAnimator()
        {

        }
        /// <Summary>
        /// Moves the [FloatingActionButton] by scaling out and then in at a new
        /// [FloatingActionButtonLocation].
        ///
        /// This animator shrinks the [FloatingActionButton] down until it disappears, then
        /// grows it back to full size at its new [FloatingActionButtonLocation].
        ///
        /// This is the default [FloatingActionButton] motion animation.
        /// </Summary>
        public virtual FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator Scaling { get; set; }

        /// <Summary>
        /// Gets the [FloatingActionButton]'s position relative to the origin of the
        /// [Scaffold] based on [progress].
        ///
        /// [begin] is the [Offset] provided by the previous
        /// [FloatingActionButtonLocation].
        ///
        /// [end] is the [Offset] provided by the new
        /// [FloatingActionButtonLocation].
        ///
        /// [progress] is the current progress of the transition animation.
        /// When [progress] is 0.0, the returned [Offset] should be equal to [begin].
        /// when [progress] is 1.0, the returned [Offset] should be equal to [end].
        /// </Summary>
        public virtual Offset GetOffset(FlutterBinding.UI.Offset begin = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset end = default(FlutterBinding.UI.Offset), double progress = default(double))
        {
            return default(Offset);
        }


        /// <Summary>
        /// Animates the scale of the [FloatingActionButton].
        ///
        /// The animation should both start and end with a value of 1.0.
        ///
        /// For example, to create an animation that linearly scales out and then back in,
        /// you could join animations that pass each other:
        ///
        /// ```dart
        ///   @override
        ///   Animation<double> getScaleAnimation({@required Animation<double> parent}) {
        ///     // The animations will cross at value 0, and the train will return to 1.0.
        ///     return TrainHoppingAnimation(
        ///       Tween<double>(begin: 1.0, end: -1.0).animate(parent),
        ///       Tween<double>(begin: -1.0, end: 1.0).animate(parent),
        ///     );
        ///   }
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> GetScaleAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            return default(Animation<double>);
        }


        /// <Summary>
        /// Animates the rotation of [Scaffold.floatingActionButton].
        ///
        /// The animation should both start and end with a value of 0.0 or 1.0.
        ///
        /// The animation values are a fraction of a full circle, with 0.0 and 1.0
        /// corresponding to 0 and 360 degrees, while 0.5 corresponds to 180 degrees.
        ///
        /// For example, to create a rotation animation that rotates the
        /// [FloatingActionButton] through a full circle:
        ///
        /// ```dart
        /// @override
        /// Animation<double> getRotationAnimation({@required Animation<double> parent}) {
        ///   return Tween<double>(begin: 0.0, end: 1.0).animate(parent);
        /// }
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> GetRotationAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            return default(Animation<double>);
        }


        /// <Summary>
        /// Gets the progress value to restart a motion animation from when the animation is interrupted.
        ///
        /// [previousValue] is the value of the animation before it was interrupted.
        ///
        /// The restart of the animation will affect all three parts of the motion animation:
        /// offset animation, scale animation, and rotation animation.
        ///
        /// An interruption triggers if the [Scaffold] is given a new [FloatingActionButtonLocation]
        /// while it is still animating a transition between two previous [FloatingActionButtonLocation]s.
        ///
        /// A sensible default is usually 0.0, which is the same as restarting
        /// the animation from the beginning, regardless of the original state of the animation.
        /// </Summary>
        public virtual double GetAnimationRestart(double previousValue) => 0.0;



    }


    public class _ScalingFabMotionAnimator : FlutterSDK.Material.Floatingactionbuttonlocation.FloatingActionButtonAnimator
    {
        public _ScalingFabMotionAnimator()
        {

        }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _RotationTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _ThresholdCenterTween { get; set; }

        public new Offset GetOffset(FlutterBinding.UI.Offset begin = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset end = default(FlutterBinding.UI.Offset), double progress = default(double))
        {
            if (progress < 0.5)
            {
                return begin;
            }
            else
            {
                return end;
            }

        }




        public new FlutterSDK.Animation.Animation.Animation<double> GetScaleAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            Curve curve = new Interval(0.5, 1.0, curve: CurvesDefaultClass.Curves.Ease);
            return new _AnimationSwap<double>(new ReverseAnimation(parent.Drive(new CurveTween(curve: curve.Flipped))), parent.Drive(new CurveTween(curve: curve)), parent, 0.5);
        }




        public new FlutterSDK.Animation.Animation.Animation<double> GetRotationAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            return new _AnimationSwap<double>(parent.Drive(_RotationTween), new ReverseAnimation(parent.Drive(_ThresholdCenterTween)), parent, 0.5);
        }




        public new double GetAnimationRestart(double previousValue) => Dart.Math.MathDefaultClass.Min(1.0 - previousValue, previousValue);


    }


    /// <Summary>
    /// An animation that swaps from one animation to the next when the [parent] passes [swapThreshold].
    ///
    /// The [value] of this animation is the value of [first] when [parent.value] < [swapThreshold]
    /// and the value of [next] otherwise.
    /// </Summary>
    public class _AnimationSwap<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
    {
        /// <Summary>
        /// Creates an [_AnimationSwap].
        ///
        /// Both arguments must be non-null. Either can be an [_AnimationSwap] itself
        /// to combine multiple animations.
        /// </Summary>
        public _AnimationSwap(FlutterSDK.Animation.Animation.Animation<T> first, FlutterSDK.Animation.Animation.Animation<T> next, FlutterSDK.Animation.Animation.Animation<double> parent, double swapThreshold)
        : base(first: first, next: next)
        {
            this.Parent = parent;
            this.SwapThreshold = swapThreshold;
        }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get; set; }
        public virtual double SwapThreshold { get; set; }
        public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }

}
