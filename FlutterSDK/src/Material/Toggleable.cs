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
        /// <Summary>
        /// Creates a toggleable render object.
        ///
        /// The [activeColor], and [inactiveColor] arguments must not be
        /// null. The [value] can only be null if tristate is true.
        /// </Summary>
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
                Paint reactionPaint = new Paint()..Color = Dart.UI.UiDefaultClass.Color.Lerp(Dart.UI.UiDefaultClass.Color.Lerp(ActiveColor.WithAlpha(ConstantsDefaultClass.KRadialReactionAlpha), HoverColor, _ReactionHoverFade.Value), FocusColor, _ReactionFocusFade.Value);
                Offset center = Dart.UI.UiDefaultClass.Offset.Lerp(_DownPosition ?? origin, origin, _Reaction.Value);
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
