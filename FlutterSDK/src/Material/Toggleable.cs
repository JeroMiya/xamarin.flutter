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
namespace FlutterSDK.Material.Toggleable
{
    internal static class ToggleableDefaultClass
    {
        public static TimeSpan _KToggleDuration = default(TimeSpan);
        public static FlutterSDK.Animation.Tween.Animatable<double> _KRadialReactionRadiusTween = default(FlutterSDK.Animation.Tween.Animatable<double>);
        public static TimeSpan _KReactionFadeDuration = default(TimeSpan);
    }

    /// <Summary>
    /// A base class for material style toggleable controls with toggle animations.
    ///
    /// This class handles storing the current value, dispatching ValueChanged on a
    /// tap gesture and driving a changed animation. Subclasses are responsible for
    /// painting.
    /// </Summary>
    public interface IRenderToggleable
    {
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void Detach();
        bool HitTestSelf(FlutterBinding.UI.Offset position);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry);
        void PaintRadialReaction(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Offset origin);
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Animation.Animationcontroller.AnimationController PositionController { get; }
        FlutterSDK.Animation.Animations.CurvedAnimation Position { get; }
        FlutterSDK.Animation.Animationcontroller.AnimationController ReactionController { get; }
        FlutterSDK.Animation.Animationcontroller.AnimationController ReactionFocusFadeController { get; }
        FlutterSDK.Animation.Animationcontroller.AnimationController ReactionHoverFadeController { get; }
        bool HasFocus { get; set; }
        bool Hovering { get; set; }
        FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
        bool Value { get; set; }
        bool Tristate { get; set; }
        FlutterBinding.UI.Color ActiveColor { get; set; }
        FlutterBinding.UI.Color InactiveColor { get; set; }
        FlutterBinding.UI.Color HoverColor { get; set; }
        FlutterBinding.UI.Color FocusColor { get; set; }
        FlutterBinding.UI.Color ReactionColor { get; set; }
        FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        bool IsInteractive { get; }
    }


    /// <Summary>
    /// A base class for material style toggleable controls with toggle animations.
    ///
    /// This class handles storing the current value, dispatching ValueChanged on a
    /// tap gesture and driving a changed animation. Subclasses are responsible for
    /// painting.
    /// </Summary>
    public class RenderToggleable : FlutterSDK.Rendering.Proxybox.RenderConstrainedBox
    {
        public RenderToggleable(bool value = default(bool), bool tristate = false, FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), bool hasFocus = false, bool hovering = false)
        : base(additionalConstraints: additionalConstraints)
        {

            _Tap = new TapGestureRecognizer()..OnTapDown = _HandleTapDown..OnTap = _HandleTap..OnTapUp = _HandleTapUp..OnTapCancel = _HandleTapCancel;
            _PositionController = new AnimationController(duration: ToggleableDefaultClass._KToggleDuration, value: value == false ? 0.0 : 1.0, vsync: vsync);
            _Position = new CurvedAnimation(parent: _PositionController, curve: CurvesDefaultClass.Curves.Linear);
            new CurvedAnimation(parent: _PositionController, curve: CurvesDefaultClass.Curves.Linear).AddListener(MarkNeedsPaint);
            _ReactionController = new AnimationController(duration: ConstantsDefaultClass.KRadialReactionDuration, vsync: vsync);
            _Reaction = new CurvedAnimation(parent: _ReactionController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            new CurvedAnimation(parent: _ReactionController, curve: CurvesDefaultClass.Curves.FastOutSlowIn).AddListener(MarkNeedsPaint);
            _ReactionHoverFadeController = new AnimationController(duration: ToggleableDefaultClass._KReactionFadeDuration, value: hovering || hasFocus ? 1.0 : 0.0, vsync: vsync);
            _ReactionHoverFade = new CurvedAnimation(parent: _ReactionHoverFadeController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            new CurvedAnimation(parent: _ReactionHoverFadeController, curve: CurvesDefaultClass.Curves.FastOutSlowIn).AddListener(MarkNeedsPaint);
            _ReactionFocusFadeController = new AnimationController(duration: ToggleableDefaultClass._KReactionFadeDuration, value: hovering || hasFocus ? 1.0 : 0.0, vsync: vsync);
            _ReactionFocusFade = new CurvedAnimation(parent: _ReactionFocusFadeController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            new CurvedAnimation(parent: _ReactionFocusFadeController, curve: CurvesDefaultClass.Curves.FastOutSlowIn).AddListener(MarkNeedsPaint);
        }


        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _PositionController { get; set; }
        internal virtual FlutterSDK.Animation.Animations.CurvedAnimation _Position { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ReactionController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Reaction { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ReactionFocusFadeController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ReactionFocusFade { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ReactionHoverFadeController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ReactionHoverFade { get; set; }
        internal virtual bool _HasFocus { get; set; }
        internal virtual bool _Hovering { get; set; }
        internal virtual FlutterSDK.Scheduler.Ticker.TickerProvider _Vsync { get; set; }
        internal virtual bool _Value { get; set; }
        internal virtual bool _Tristate { get; set; }
        internal virtual FlutterBinding.UI.Color _ActiveColor { get; set; }
        internal virtual FlutterBinding.UI.Color _InactiveColor { get; set; }
        internal virtual FlutterBinding.UI.Color _HoverColor { get; set; }
        internal virtual FlutterBinding.UI.Color _FocusColor { get; set; }
        internal virtual FlutterBinding.UI.Color _ReactionColor { get; set; }
        internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> _OnChanged { get; set; }
        internal virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer _Tap { get; set; }
        internal virtual FlutterBinding.UI.Offset _DownPosition { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController PositionController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animations.CurvedAnimation Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ReactionController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ReactionFocusFadeController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ReactionHoverFadeController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Hovering { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Tristate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ActiveColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color InactiveColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color HoverColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color FocusColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ReactionColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            if (Value == false) _PositionController.Reverse(); else _PositionController.Forward();
            if (IsInteractive)
            {
                switch (_ReactionController.Status) { case AnimationStatus.Forward: _ReactionController.Forward(); break; case AnimationStatus.Reverse: _ReactionController.Reverse(); break; case AnimationStatus.Dismissed: case AnimationStatus.Completed: break; }
            }

        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            if (Value == false) _PositionController.Reverse(); else _PositionController.Forward();
            if (IsInteractive)
            {
                switch (_ReactionController.Status) { case AnimationStatus.Forward: _ReactionController.Forward(); break; case AnimationStatus.Reverse: _ReactionController.Reverse(); break; case AnimationStatus.Dismissed: case AnimationStatus.Completed: break; }
            }

        }




        public new void Detach()
        {
            _PositionController.Stop();
            _ReactionController.Stop();
            base.Detach();
        }




        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
        {
            if (IsInteractive)
            {
                _DownPosition = GlobalToLocal(details.GlobalPosition);
                _ReactionController.Forward();
            }

        }




        private void _HandleTap()
        {
            if (!IsInteractive) return;
            switch (Value) { case false: OnChanged(true); break; case true: OnChanged(Tristate ? null : false); break; default: OnChanged(false); break; }
            SendSemanticsEvent(new TapSemanticEvent());
        }




        private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            _DownPosition = null;
            if (IsInteractive) _ReactionController.Reverse();
        }




        private void _HandleTapCancel()
        {
            _DownPosition = null;
            if (IsInteractive) _ReactionController.Reverse();
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
        {

            if (@event is PointerDownEvent && IsInteractive) _Tap.AddPointer(@event);
        }




        /// <Summary>
        /// Used by subclasses to paint the radial ink reaction for this control.
        ///
        /// The reaction is painted on the given canvas at the given offset. The
        /// origin is the center point of the reaction (usually distinct from the
        /// point at which the user interacted with the control, which is handled
        /// automatically).
        /// </Summary>
        public virtual void PaintRadialReaction(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Offset origin)
        {
            if (!_Reaction.IsDismissed || !_ReactionFocusFade.IsDismissed || !_ReactionHoverFade.IsDismissed)
            {
                Paint reactionPaint = new Paint()..Color = Dart:uiDefaultClass.Color.Lerp(Dart: uiDefaultClass.Color.Lerp(ActiveColor.WithAlpha(ConstantsDefaultClass.KRadialReactionAlpha), HoverColor, _ReactionHoverFade.Value), FocusColor, _ReactionFocusFade.Value);
                Offset center = Dart:uiDefaultClass.Offset.Lerp(_DownPosition ?? origin, origin, _Reaction.Value);
                double reactionRadius = HasFocus || Hovering ? ConstantsDefaultClass.KRadialReactionRadius : ToggleableDefaultClass._KRadialReactionRadiusTween.Evaluate(_Reaction);
                if (reactionRadius > 0.0)
                {
                    canvas.DrawCircle(center + offset, reactionRadius, reactionPaint);
                }

            }

        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.IsEnabled = IsInteractive;
            if (IsInteractive) config.OnTap = _HandleTap;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new FlagProperty("value", value: Value, ifTrue: "checked", ifFalse: "unchecked", showName: true));
            properties.Add(new FlagProperty("isInteractive", value: IsInteractive, ifTrue: "enabled", ifFalse: "disabled", defaultValue: true));
        }



    }

}
