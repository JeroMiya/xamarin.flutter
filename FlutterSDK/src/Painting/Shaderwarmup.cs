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
namespace FlutterSDK.Painting.Shaderwarmup
{
    internal static class ShaderwarmupDefaultClass
    {
    }

    /// <Summary>
    /// Interface for drawing an image to warm up Skia shader compilations.
    ///
    /// When Skia first sees a certain type of draw operation on the GPU, it needs
    /// to compile the corresponding shader. The compilation can be slow (20ms-
    /// 200ms). Having that time as startup latency is often better than having
    /// jank in the middle of an animation.
    ///
    /// Therefore, we use this during the [PaintingBinding.initInstances] call to
    /// move common shader compilations from animation time to startup time. By
    /// default, a [DefaultShaderWarmUp] is used. If needed, app developers can
    /// create a custom [ShaderWarmUp] subclass and hand it to
    /// [PaintingBinding.shaderWarmUp] (so it replaces [DefaultShaderWarmUp])
    /// before [PaintingBinding.initInstances] is called. Usually, that can be
    /// done before calling [runApp].
    ///
    /// To determine whether a draw operation is useful for warming up shaders,
    /// check whether it improves the slowest GPU frame. Also, tracing with
    /// `flutter run --profile --trace-skia` may reveal whether there is shader-
    /// compilation-related jank. If there is such jank, some long
    /// `GrGLProgramBuilder::finalize` calls would appear in the middle of an
    /// animation. Their parent calls, which look like `XyzOp` (e.g., `FillRecOp`,
    /// `CircularRRectOp`) would suggest Xyz draw operations are causing the
    /// shaders to be compiled. A useful shader warm-up draw operation would
    /// eliminate such long compilation calls in the animation. To double-check
    /// the warm-up, trace with
    /// `flutter run --profile --trace-skia --start-paused`.
    /// The `GrGLProgramBuilder` with the associated `XyzOp` should
    /// appear during startup rather than in the middle of a later animation.
    ///
    /// This warm-up needs to be run on each individual device because the shader
    /// compilation depends on the specific GPU hardware and driver a device has. It
    /// can't be pre-computed during the Flutter engine compilation as the engine is
    /// device-agnostic.
    ///
    /// If no warm-up is desired (e.g., when the startup latency is crucial), set
    /// [PaintingBinding.shaderWarmUp] either to a custom ShaderWarmUp with an empty
    /// [warmUpOnCanvas] or null.
    ///
    /// See also:
    ///
    ///  * [PaintingBinding.shaderWarmUp], the actual instance of [ShaderWarmUp]
    ///    that's used to warm up the shaders.
    /// </Summary>
    public interface IShaderWarmUp
    {
        Future<object> WarmUpOnCanvas(Canvas canvas);
        Future<object> Execute();
        Size Size { get; }
    }


    /// <Summary>
    /// Interface for drawing an image to warm up Skia shader compilations.
    ///
    /// When Skia first sees a certain type of draw operation on the GPU, it needs
    /// to compile the corresponding shader. The compilation can be slow (20ms-
    /// 200ms). Having that time as startup latency is often better than having
    /// jank in the middle of an animation.
    ///
    /// Therefore, we use this during the [PaintingBinding.initInstances] call to
    /// move common shader compilations from animation time to startup time. By
    /// default, a [DefaultShaderWarmUp] is used. If needed, app developers can
    /// create a custom [ShaderWarmUp] subclass and hand it to
    /// [PaintingBinding.shaderWarmUp] (so it replaces [DefaultShaderWarmUp])
    /// before [PaintingBinding.initInstances] is called. Usually, that can be
    /// done before calling [runApp].
    ///
    /// To determine whether a draw operation is useful for warming up shaders,
    /// check whether it improves the slowest GPU frame. Also, tracing with
    /// `flutter run --profile --trace-skia` may reveal whether there is shader-
    /// compilation-related jank. If there is such jank, some long
    /// `GrGLProgramBuilder::finalize` calls would appear in the middle of an
    /// animation. Their parent calls, which look like `XyzOp` (e.g., `FillRecOp`,
    /// `CircularRRectOp`) would suggest Xyz draw operations are causing the
    /// shaders to be compiled. A useful shader warm-up draw operation would
    /// eliminate such long compilation calls in the animation. To double-check
    /// the warm-up, trace with
    /// `flutter run --profile --trace-skia --start-paused`.
    /// The `GrGLProgramBuilder` with the associated `XyzOp` should
    /// appear during startup rather than in the middle of a later animation.
    ///
    /// This warm-up needs to be run on each individual device because the shader
    /// compilation depends on the specific GPU hardware and driver a device has. It
    /// can't be pre-computed during the Flutter engine compilation as the engine is
    /// device-agnostic.
    ///
    /// If no warm-up is desired (e.g., when the startup latency is crucial), set
    /// [PaintingBinding.shaderWarmUp] either to a custom ShaderWarmUp with an empty
    /// [warmUpOnCanvas] or null.
    ///
    /// See also:
    ///
    ///  * [PaintingBinding.shaderWarmUp], the actual instance of [ShaderWarmUp]
    ///    that's used to warm up the shaders.
    /// </Summary>
    public class ShaderWarmUp
    {
        #region constructors
        public ShaderWarmUp()
    
}
    #endregion

    #region fields
    public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Trigger draw operations on a given canvas to warm up GPU shader
    /// compilation cache.
    ///
    /// To decide which draw operations to be added to your custom warm up
    /// process, try capture an skp using
    /// `flutter screenshot --observatory-uri=<uri> --type=skia`
    /// and analyze it with https://debugger.skia.org.
    /// Alternatively, one may run the app with `flutter run --trace-skia` and
    /// then examine the GPU thread in the observatory timeline to see which
    /// Skia draw operations are commonly used, and which shader compilations
    /// are causing jank.
    /// </Summary>
    public virtual Future<object> WarmUpOnCanvas(Canvas canvas)
    {
        return default(Future<void>);
    }


    /// <Summary>
    /// Construct an offscreen image of [size], and execute [warmUpOnCanvas] on a
    /// canvas associated with that image.
    /// </Summary>
    public virtual Future<object> Execute()
async
{
Ui.Dart:uiDefaultClass.PictureRecorder recorder = new Ui.PictureRecorder();
    Ui.Dart:uiDefaultClass.Canvas canvas = new Ui.Canvas(recorder);
    await WarmUpOnCanvas(canvas);
    Ui.Dart:uiDefaultClass.Picture picture = recorder.EndRecording();
    TimelineTask shaderWarmUpTask = new TimelineTask();
    shaderWarmUpTask.Start("Warm-up shader");
await picture.ToImage(Size.Width.Ceil(), Size.Height.Ceil());
    shaderWarmUpTask.Finish();
}



#endregion
}


/// <Summary>
/// Default way of warming up Skia shader compilations.
///
/// The draw operations being warmed up here are decided according to Flutter
/// engineers' observation and experience based on the apps and the performance
/// issues seen so far.
/// </Summary>
public class DefaultShaderWarmUp : FlutterSDK.Painting.Shaderwarmup.ShaderWarmUp
{
    #region constructors
    public DefaultShaderWarmUp(double drawCallSpacing = 0.0, Size canvasSize = default(Size))

}
#endregion

#region fields
public virtual double DrawCallSpacing { get; set; }
public virtual Size CanvasSize { get; set; }
public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Trigger common draw operations on a canvas to warm up GPU shader
/// compilation cache.
/// </Summary>
public new Future<object> WarmUpOnCanvas(Canvas canvas)
async
{
    Ui.Dart:uiDefaultClass.RRect rrect = Ui.Dart:uiDefaultClass.RRect.FromLTRBXY(20.0, 20.0, 60.0, 60.0, 10.0, 10.0);
    Ui.Dart:uiDefaultClass.Path rrectPath = new Ui.Path();
    new Ui.Path().AddRRect(rrect);
    Ui.Dart:uiDefaultClass.Path circlePath = new Ui.Path();
    new Ui.Path().AddOval(Ui.Dart:uiDefaultClass.Rect.FromCircle(center: new Ui.Dart:uiDefaultClass.Offset(40.0, 40.0), radius: 20.0));
    Ui.Dart:uiDefaultClass.Path path = new Ui.Path();
    path.MoveTo(20.0, 60.0);
    path.QuadraticBezierTo(60.0, 20.0, 60.0, 60.0);
    path.Close();
    path.MoveTo(60.0, 20.0);
    path.QuadraticBezierTo(60.0, 60.0, 20.0, 60.0);
    Ui.Dart:uiDefaultClass.Path convexPath = new Ui.Path();
    convexPath.MoveTo(20.0, 30.0);
    convexPath.LineTo(40.0, 20.0);
    convexPath.LineTo(60.0, 30.0);
    convexPath.LineTo(60.0, 60.0);
    convexPath.LineTo(20.0, 60.0);
    convexPath.Close();
    List < Ui.Dart:uiDefaultClass.Path > paths = new List<Ui.Dart:uiDefaultClass.Path>() { rrectPath, circlePath, path, convexPath };
    List < Ui.Dart:uiDefaultClass.Paint > paints = new List<Ui.Dart:uiDefaultClass.Paint>() { new Ui.Paint()..IsAntiAlias = true..Style = Ui.PaintingStyle.Fill, new Ui.Paint()..IsAntiAlias = false..Style = Ui.PaintingStyle.Fill, new Ui.Paint()..IsAntiAlias = true..Style = Ui.PaintingStyle.Stroke..StrokeWidth = 10, new Ui.Paint()..IsAntiAlias = true..Style = Ui.PaintingStyle.Stroke..StrokeWidth = 0.1 };
    for (int i = 0; i < paths.Count; i += 1)
    {
        canvas.Save();
        foreach (Ui.Dart:uiDefaultClass.Paint paint  in paints){
        canvas.DrawPath(paths[i], paint);
        canvas.Translate(DrawCallSpacing, 0.0);
    }

    canvas.Restore();
    canvas.Translate(0.0, DrawCallSpacing);
}

Ui.Dart:uiDefaultClass.Color black = new Ui.Color(0xFF000000);
canvas.Save();
canvas.DrawShadow(rrectPath, black, 10.0, true);
canvas.Translate(DrawCallSpacing, 0.0);
canvas.DrawShadow(rrectPath, black, 10.0, false);
canvas.Restore();
canvas.Translate(0.0, DrawCallSpacing);
Ui.Dart:uiDefaultClass.ParagraphBuilder paragraphBuilder = new Ui.ParagraphBuilder(new Ui.ParagraphStyle(textDirection: Ui.TextDirection.Ltr));
new Ui.ParagraphBuilder(new Ui.ParagraphStyle(textDirection: Ui.TextDirection.Ltr)).PushStyle(new Ui.TextStyle(color: black));
new Ui.ParagraphBuilder(new Ui.ParagraphStyle(textDirection: Ui.TextDirection.Ltr)).AddText('_');
Ui.Dart:uiDefaultClass.Paragraph paragraph = paragraphBuilder.Build();
paragraphBuilder.Build().Layout(new Ui.Dart:uiDefaultClass.ParagraphConstraints(width: 60.0));
canvas.DrawParagraph(paragraph, new Ui.Dart:uiDefaultClass.Offset(20.0, 20.0));
foreach (double fraction in new List<double>() { 0.0, 0.5 })
{
    ;
    canvas.Save();
    canvas.Translate(fraction, fraction);
    canvas.ClipRRect(Ui.Dart:uiDefaultClass.RRect.FromLTRBR(8, 8, 328, 248, Ui.Dart:uiDefaultClass.Radius.Circular(16)));
    canvas.DrawRect(Ui.Dart:uiDefaultClass.Rect.FromLTRB(10, 10, 320, 240), new Ui.Paint());
    canvas.Restore();
    canvas.Translate(DrawCallSpacing, 0.0);
}

canvas.Translate(0.0, DrawCallSpacing);
}



#endregion
}

}
