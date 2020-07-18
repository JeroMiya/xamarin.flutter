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
namespace FlutterSDK.Material.Inkripple
{
    internal static class InkrippleDefaultClass
    {
        public static TimeSpan _KUnconfirmedRippleDuration = default(TimeSpan);
        public static TimeSpan _KFadeInDuration = default(TimeSpan);
        public static TimeSpan _KRadiusDuration = default(TimeSpan);
        public static TimeSpan _KFadeOutDuration = default(TimeSpan);
        public static TimeSpan _KCancelDuration = default(TimeSpan);
        public static double _KFadeOutIntervalStart = default(double);
        internal static FlutterSDK.Material.Material.RectCallback _GetClipCallback(FlutterSDK.Rendering.Box.RenderBox referenceBox, bool containedInkWell, FlutterSDK.Material.Material.RectCallback rectCallback)
        {
            throw new NotImplementedException();
        }

        internal static double _GetTargetRadius(FlutterSDK.Rendering.Box.RenderBox referenceBox, bool containedInkWell, FlutterSDK.Material.Material.RectCallback rectCallback, FlutterBinding.UI.Offset position)
        {
            throw new NotImplementedException();
        }

    }

    public class _InkRippleFactory : FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory
    {
        #region constructors
        public _InkRippleFactory()
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), bool containedInkWell = false, FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), double radius = default(double), VoidCallback onRemoved = default(VoidCallback))
        {
            return new InkRipple(controller: controller, referenceBox: referenceBox, position: position, color: color, containedInkWell: containedInkWell, rectCallback: rectCallback, borderRadius: borderRadius, customBorder: customBorder, radius: radius, onRemoved: onRemoved, textDirection: textDirection);
        }



        #endregion
    }


    /// <Summary>
    /// A visual reaction on a piece of [Material] to user input.
    ///
    /// A circular ink feature whose origin starts at the input touch point and
    /// whose radius expands from 60% of the final radius. The splash origin
    /// animates to the center of its [referenceBox].
    ///
    /// This object is rarely created directly. Instead of creating an ink ripple,
    /// consider using an [InkResponse] or [InkWell] widget, which uses
    /// gestures (such as tap and long-press) to trigger ink splashes. This class
    /// is used when the [Theme]'s [ThemeData.splashFactory] is [InkRipple.splashFactory].
    ///
    /// See also:
    ///
    ///  * [InkSplash], which is an ink splash feature that expands less
    ///    aggressively than the ripple.
    ///  * [InkResponse], which uses gestures to trigger ink highlights and ink
    ///    splashes in the parent [Material].
    ///  * [InkWell], which is a rectangular [InkResponse] (the most common type of
    ///    ink response).
    ///  * [Material], which is the widget on which the ink splash is painted.
    ///  * [InkHighlight], which is an ink feature that emphasizes a part of a
    ///    [Material].
    /// </Summary>
    public class InkRipple : FlutterSDK.Material.Inkwell.InteractiveInkFeature
    {
        #region constructors
        public InkRipple(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), bool containedInkWell = false, FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), double radius = default(double), VoidCallback onRemoved = default(VoidCallback))
        : base(controller: controller, referenceBox: referenceBox, color: color, onRemoved: onRemoved)
        {


            _FadeInController = new AnimationController(duration: InkrippleDefaultClass._KFadeInDuration, vsync: controller.Vsync);
            new AnimationController(duration: InkrippleDefaultClass._KFadeInDuration, vsync: controller.Vsync).AddListener(controller.MarkNeedsPaint);
            new AnimationController(duration: InkrippleDefaultClass._KFadeInDuration, vsync: controller.Vsync).Forward();
            _FadeIn = _FadeInController.Drive(new IntTween(begin: 0, end: color.Alpha));
            _RadiusController = new AnimationController(duration: InkrippleDefaultClass._KUnconfirmedRippleDuration, vsync: controller.Vsync);
            new AnimationController(duration: InkrippleDefaultClass._KUnconfirmedRippleDuration, vsync: controller.Vsync).AddListener(controller.MarkNeedsPaint);
            new AnimationController(duration: InkrippleDefaultClass._KUnconfirmedRippleDuration, vsync: controller.Vsync).Forward();
            _Radius = _RadiusController.Drive(new Tween<double>(begin: _TargetRadius * 0.30, end: _TargetRadius + 5.0).Chain(_EaseCurveTween));
            _FadeOutController = new AnimationController(duration: InkrippleDefaultClass._KFadeOutDuration, vsync: controller.Vsync);
            new AnimationController(duration: InkrippleDefaultClass._KFadeOutDuration, vsync: controller.Vsync).AddListener(controller.MarkNeedsPaint);
            new AnimationController(duration: InkrippleDefaultClass._KFadeOutDuration, vsync: controller.Vsync).AddStatusListener(_HandleAlphaStatusChanged);
            _FadeOut = _FadeOutController.Drive(new IntTween(begin: color.Alpha, end: 0).Chain(_FadeOutIntervalTween));
            controller.AddInkFeature(this);
        }


        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Offset _Position { get; set; }
        internal virtual FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius { get; set; }
        internal virtual FlutterSDK.Painting.Borders.ShapeBorder _CustomBorder { get; set; }
        internal virtual double _TargetRadius { get; set; }
        internal virtual FlutterSDK.Material.Material.RectCallback _ClipCallback { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Radius { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _RadiusController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<int> _FadeIn { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FadeInController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<int> _FadeOut { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FadeOutController { get; set; }
        public virtual FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory SplashFactory { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _EaseCurveTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _FadeOutIntervalTween { get; set; }
        #endregion

        #region methods

        public new void Confirm()
        {
            ..Duration = InkrippleDefaultClass._KRadiusDuration;
            _RadiusController.Forward();
            _FadeInController.Forward();
            _FadeOutController.AnimateTo(1.0, duration: InkrippleDefaultClass._KFadeOutDuration);
        }




        public new void Cancel()
        {
            _FadeInController.Stop();
            double fadeOutValue = 1.0 - _FadeInController.Value;
            _FadeOutController.Value = fadeOutValue;
            if (fadeOutValue < 1.0) _FadeOutController.AnimateTo(1.0, duration: InkrippleDefaultClass._KCancelDuration);
        }




        private void _HandleAlphaStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Completed) Dispose();
        }




        public new void Dispose()
        {
            _RadiusController.Dispose();
            _FadeInController.Dispose();
            _FadeOutController.Dispose();
            base.Dispose();
        }




        public new void PaintFeature(Canvas canvas, Matrix4 transform)
        {
            int alpha = _FadeInController.IsAnimating ? _FadeIn.Value : _FadeOut.Value;
            Paint paint = new Paint()..Color = Color.WithAlpha(alpha);
            Offset center = Dart:uiDefaultClass.Offset.Lerp(_Position, ReferenceBox.Size.Center(Dart: uiDefaultClass.Offset.Zero), CurvesDefaultClass.Curves.Ease.Transform(_RadiusController.Value));
            PaintInkCircle(canvas: canvas, transform: transform, paint: paint, center: center, textDirection: _TextDirection, radius: _Radius.Value, customBorder: _CustomBorder, borderRadius: _BorderRadius, clipCallback: _ClipCallback);
        }



        #endregion
    }

}
