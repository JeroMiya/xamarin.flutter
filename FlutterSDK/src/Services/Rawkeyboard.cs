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
using FlutterSDK.Painting._Networkimageio;
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
namespace FlutterSDK.Services.Rawkeyboard
{
    internal static class RawkeyboardDefaultClass
    {
    }

    /// <Summary>
    /// Base class for platform-specific key event data.
    ///
    /// This base class exists to have a common type to use for each of the
    /// target platform's key event data structures.
    ///
    /// See also:
    ///
    ///  * [RawKeyEventDataAndroid], a specialization for Android.
    ///  * [RawKeyEventDataFuchsia], a specialization for Fuchsia.
    ///  * [RawKeyDownEvent] and [RawKeyUpEvent], the classes that hold the
    ///    reference to [RawKeyEventData] subclasses.
    ///  * [RawKeyboard], which uses these interfaces to expose key data.
    /// </Summary>
    public interface IRawKeyEventData
    {
        bool IsModifierPressed(FlutterSDK.Services.Rawkeyboard.ModifierKey key, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide));
        FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(FlutterSDK.Services.Rawkeyboard.ModifierKey key);
        bool IsControlPressed { get; }
        bool IsShiftPressed { get; }
        bool IsAltPressed { get; }
        bool IsMetaPressed { get; }
        Dictionary<FlutterSDK.Services.Rawkeyboard.ModifierKey, FlutterSDK.Services.Rawkeyboard.KeyboardSide> ModifiersPressed { get; }
        FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PhysicalKey { get; }
        FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey { get; }
        string KeyLabel { get; }
    }


    /// <Summary>
    /// Defines the interface for raw key events.
    ///
    /// Raw key events pass through as much information as possible from the
    /// underlying platform's key events, which allows them to provide a high level
    /// of fidelity but a low level of portability.
    ///
    /// The event also provides an abstraction for the [physicalKey] and the
    /// [logicalKey], describing the physical location of the key, and the logical
    /// meaning of the key, respectively. These are more portable representations of
    /// the key events, and should produce the same results regardless of platform.
    ///
    /// See also:
    ///
    ///  * [LogicalKeyboardKey], an object that describes the logical meaning of a
    ///    key.
    ///  * [PhysicalKeyboardKey], an object that describes the physical location of
    ///    a key.
    ///  * [RawKeyDownEvent], a specialization for events representing the user
    ///    pressing a key.
    ///  * [RawKeyUpEvent], a specialization for events representing the user
    ///    releasing a key.
    ///  * [RawKeyboard], which uses this interface to expose key data.
    ///  * [RawKeyboardListener], a widget that listens for raw key events.
    /// </Summary>
    public interface IRawKeyEvent
    {
        bool IsKeyPressed(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        string Character { get; }
        FlutterSDK.Services.Rawkeyboard.RawKeyEventData Data { get; }
        bool IsControlPressed { get; }
        bool IsShiftPressed { get; }
        bool IsAltPressed { get; }
        bool IsMetaPressed { get; }
        FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PhysicalKey { get; }
        FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey { get; }
    }


    /// <Summary>
    /// Base class for platform-specific key event data.
    ///
    /// This base class exists to have a common type to use for each of the
    /// target platform's key event data structures.
    ///
    /// See also:
    ///
    ///  * [RawKeyEventDataAndroid], a specialization for Android.
    ///  * [RawKeyEventDataFuchsia], a specialization for Fuchsia.
    ///  * [RawKeyDownEvent] and [RawKeyUpEvent], the classes that hold the
    ///    reference to [RawKeyEventData] subclasses.
    ///  * [RawKeyboard], which uses these interfaces to expose key data.
    /// </Summary>
    public class RawKeyEventData
    {
        /// <Summary>
        /// Abstract const constructor.
        ///
        /// This constructor enables subclasses to provide const constructors so that
        /// they can be used in const expressions.
        /// </Summary>
        public RawKeyEventData()
        {

        }
        public virtual bool IsControlPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsShiftPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsAltPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsMetaPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Dictionary<FlutterSDK.Services.Rawkeyboard.ModifierKey, FlutterSDK.Services.Rawkeyboard.KeyboardSide> ModifiersPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PhysicalKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string KeyLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns true if the given [ModifierKey] was pressed at the time of this
        /// event.
        ///
        /// If [side] is specified, then this restricts its check to the specified
        /// side of the keyboard. Defaults to checking for the key being down on
        /// either side of the keyboard. If there is only one instance of the key on
        /// the keyboard, then [side] is ignored.
        /// </Summary>
        public virtual bool IsModifierPressed(FlutterSDK.Services.Rawkeyboard.ModifierKey key, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide))
        {
            return default(bool);
        }


        /// <Summary>
        /// Returns a [KeyboardSide] enum value that describes which side or sides of
        /// the given keyboard modifier key were pressed at the time of this event.
        ///
        /// If the modifier key wasn't pressed at the time of this event, returns
        /// null. If the given key only appears in one place on the keyboard, returns
        /// [KeyboardSide.all] if pressed. Never returns [KeyboardSide.any], because
        /// that doesn't make sense in this context.
        /// </Summary>
        public virtual FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(FlutterSDK.Services.Rawkeyboard.ModifierKey key)
        {
            return default(KeyboardSide);
        }

    }


    /// <Summary>
    /// Defines the interface for raw key events.
    ///
    /// Raw key events pass through as much information as possible from the
    /// underlying platform's key events, which allows them to provide a high level
    /// of fidelity but a low level of portability.
    ///
    /// The event also provides an abstraction for the [physicalKey] and the
    /// [logicalKey], describing the physical location of the key, and the logical
    /// meaning of the key, respectively. These are more portable representations of
    /// the key events, and should produce the same results regardless of platform.
    ///
    /// See also:
    ///
    ///  * [LogicalKeyboardKey], an object that describes the logical meaning of a
    ///    key.
    ///  * [PhysicalKeyboardKey], an object that describes the physical location of
    ///    a key.
    ///  * [RawKeyDownEvent], a specialization for events representing the user
    ///    pressing a key.
    ///  * [RawKeyUpEvent], a specialization for events representing the user
    ///    releasing a key.
    ///  * [RawKeyboard], which uses this interface to expose key data.
    ///  * [RawKeyboardListener], a widget that listens for raw key events.
    /// </Summary>
    public class RawKeyEvent : IDiagnosticable
    {
        /// <Summary>
        /// Initializes fields for subclasses, and provides a const constructor for
        /// const subclasses.
        /// </Summary>
        public RawKeyEvent(FlutterSDK.Services.Rawkeyboard.RawKeyEventData data = default(FlutterSDK.Services.Rawkeyboard.RawKeyEventData), string character = default(string))
        {
            this.Data = data;
            this.Character = character;
        }
        /// <Summary>
        /// Creates a concrete [RawKeyEvent] class from a message in the form received
        /// on the [SystemChannels.keyEvent] channel.
        /// </Summary>
        public static RawKeyEvent FromMessage(Dictionary<string, object> message)
        {
            var instance = new RawKeyEvent();
            RawKeyEventData data = default(RawKeyEventData);
            string keymap = message["keymap"] as string;
            switch (keymap) { case "android": data = new RawKeyEventDataAndroid(flags: message["flags"] as int ?? 0, codePoint: message["codePoint"] as int ?? 0, keyCode: message["keyCode"] as int ?? 0, plainCodePoint: message["plainCodePoint"] as int ?? 0, scanCode: message["scanCode"] as int ?? 0, metaState: message["metaState"] as int ?? 0, eventSource: message["source"] as int ?? 0, vendorId: message["vendorId"] as int ?? 0, productId: message["productId"] as int ?? 0, deviceId: message["deviceId"] as int ?? 0, repeatCount: message["repeatCount"] as int ?? 0); break; case "fuchsia": data = new RawKeyEventDataFuchsia(hidUsage: message["hidUsage"] as int ?? 0, codePoint: message["codePoint"] as int ?? 0, modifiers: message["modifiers"] as int ?? 0); break; case "macos": data = new RawKeyEventDataMacOs(characters: message["characters"] as string ?? "", charactersIgnoringModifiers: message["charactersIgnoringModifiers"] as string ?? "", keyCode: message["keyCode"] as int ?? 0, modifiers: message["modifiers"] as int ?? 0); break; case "linux": data = new RawKeyEventDataLinux(keyHelper: new KeyHelper(message["toolkit"] as string ?? ""), unicodeScalarValues: message["unicodeScalarValues"] as int ?? 0, keyCode: message["keyCode"] as int ?? 0, scanCode: message["scanCode"] as int ?? 0, modifiers: message["modifiers"] as int ?? 0, isDown: message["type"] == "keydown"); break; case "web": data = new RawKeyEventDataWeb(code: message["code"] as string, key: message["key"] as string, metaState: message["metaState"] as int); break; default: throw new FlutterError($"'Unknown keymap for key events: {keymap}'"); }
            string type = message["type"] as string;
            switch (type) { case "keydown": return new RawKeyDownEvent(data: data, character: message["character"] as string); case "keyup": return new RawKeyUpEvent(data: data); default: throw new FlutterError($"'Unknown key event type: {type}'"); }
        }


        /// <Summary>
        /// Returns the Unicode character (grapheme cluster) completed by this
        /// keystroke, if any.
        ///
        /// This will only return a character if this keystroke, combined with any
        /// preceding keystroke(s), generated a character, and only on a "key down"
        /// event. It will return null if no character has been generated by the
        /// keystroke (e.g. a "dead" or "combining" key), or if the corresponding key
        /// is a key without a visual representation, such as a modifier key or a
        /// control key.
        ///
        /// This can return multiple Unicode code points, since some characters (more
        /// accurately referred to as grapheme clusters) are made up of more than one
        /// code point.
        ///
        /// The `character` doesn't take into account edits by an input method editor
        /// (IME), or manage the visibility of the soft keyboard on touch devices. For
        /// composing text, use the [TextField] or [CupertinoTextField] widgets, since
        /// those automatically handle many of the complexities of managing keyboard
        /// input.
        /// </Summary>
        public virtual string Character { get; set; }
        /// <Summary>
        /// Platform-specific information about the key event.
        /// </Summary>
        public virtual FlutterSDK.Services.Rawkeyboard.RawKeyEventData Data { get; set; }
        public virtual bool IsControlPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsShiftPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsAltPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsMetaPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PhysicalKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns true if the given [KeyboardKey] is pressed.
        /// </Summary>
        public virtual bool IsKeyPressed(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key) => RawkeyboardDefaultClass.RawKeyboard.Instance.KeysPressed.Contains(key);



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<LogicalKeyboardKey>("logicalKey", LogicalKey));
            properties.Add(new DiagnosticsProperty<PhysicalKeyboardKey>("physicalKey", PhysicalKey));
        }



    }


    /// <Summary>
    /// The user has pressed a key on the keyboard.
    ///
    /// See also:
    ///
    ///  * [RawKeyboard], which uses this interface to expose key data.
    /// </Summary>
    public class RawKeyDownEvent : FlutterSDK.Services.Rawkeyboard.RawKeyEvent
    {
        /// <Summary>
        /// Creates a key event that represents the user pressing a key.
        /// </Summary>
        public RawKeyDownEvent(FlutterSDK.Services.Rawkeyboard.RawKeyEventData data = default(FlutterSDK.Services.Rawkeyboard.RawKeyEventData), string character = default(string))
        : base(data: data, character: character)
        {

        }
    }


    /// <Summary>
    /// The user has released a key on the keyboard.
    ///
    /// See also:
    ///
    ///  * [RawKeyboard], which uses this interface to expose key data.
    /// </Summary>
    public class RawKeyUpEvent : FlutterSDK.Services.Rawkeyboard.RawKeyEvent
    {
        /// <Summary>
        /// Creates a key event that represents the user releasing a key.
        /// </Summary>
        public RawKeyUpEvent(FlutterSDK.Services.Rawkeyboard.RawKeyEventData data = default(FlutterSDK.Services.Rawkeyboard.RawKeyEventData), string character = default(string))
        : base(data: data, character: character)
        {

        }
    }


    /// <Summary>
    /// An interface for listening to raw key events.
    ///
    /// Raw key events pass through as much information as possible from the
    /// underlying platform's key events, which makes them provide a high level of
    /// fidelity but a low level of portability.
    ///
    /// A [RawKeyboard] is useful for listening to raw key events and hardware
    /// buttons that are represented as keys. Typically used by games and other apps
    /// that use keyboards for purposes other than text entry.
    ///
    /// See also:
    ///
    ///  * [RawKeyDownEvent] and [RawKeyUpEvent], the classes used to describe
    ///    specific raw key events.
    ///  * [RawKeyboardListener], a widget that listens for raw key events.
    ///  * [SystemChannels.keyEvent], the low-level channel used for receiving
    ///    events from the system.
    /// </Summary>
    public class RawKeyboard
    {
        internal RawKeyboard()
        {

            SystemchannelsDefaultClass.SystemChannels.KeyEvent.SetMessageHandler(_HandleKeyEvent);
        }


        /// <Summary>
        /// The shared instance of [RawKeyboard].
        /// </Summary>
        public virtual FlutterSDK.Services.Rawkeyboard.RawKeyboard Instance { get; set; }
        internal virtual List<object> _Listeners { get; set; }
        internal virtual Dictionary<FlutterSDK.Services.Rawkeyboard._ModifierSidePair, HashSet<FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey>> _ModifierKeyMap { get; set; }
        internal virtual Dictionary<FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey, FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _AllModifiersExceptFn { get; set; }
        internal virtual Dictionary<FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey, FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _AllModifiers { get; set; }
        internal virtual Dictionary<FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey, FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _KeysPressed { get; set; }
        public virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> KeysPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual HashSet<FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey> PhysicalKeysPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Calls the listener every time the user presses or releases a key.
        ///
        /// Listeners can be removed with [removeListener].
        /// </Summary>
        public virtual void AddListener(FlutterSDK.Foundation.Basictypes.ValueChanged<RawKeyEvent> listener)
        {
            _Listeners.Add(listener);
        }




        /// <Summary>
        /// Stop calling the listener every time the user presses or releases a key.
        ///
        /// Listeners can be added with [addListener].
        /// </Summary>
        public virtual void RemoveListener(FlutterSDK.Foundation.Basictypes.ValueChanged<RawKeyEvent> listener)
        {
            _Listeners.Remove(listener);
        }




        private async Future<object> _HandleKeyEvent(object message)
        {
            RawKeyEvent @event = RawKeyEvent.FromMessage(message as Dictionary<string, object>);
            if (@event == null)
            {
                return;
            }

            if (@event.Data is RawKeyEventDataMacOs && @event.LogicalKey == KeyboardkeyDefaultClass.LogicalKeyboardKey.Fn)
            {
                return;
            }

            if (@event is RawKeyDownEvent)
            {
                _KeysPressed[((RawKeyDownEvent)@event).PhysicalKey] = ((RawKeyDownEvent)@event).LogicalKey;
            }

            if (@event is RawKeyUpEvent)
            {
                _KeysPressed.Remove(((RawKeyUpEvent)@event).PhysicalKey);
            }

            _SynchronizeModifiers(@event);
            if (_Listeners.IsEmpty())
            {
                return;
            }

            foreach (ValueChanged<RawKeyEvent> listener in List<ValueChanged<RawKeyEvent>>.From(_Listeners))
            {
                if (_Listeners.Contains(listener))
                {
                    listener(@event);
                }

            }

        }




        private void _SynchronizeModifiers(FlutterSDK.Services.Rawkeyboard.RawKeyEvent @event)
        {
            Dictionary<ModifierKey, KeyboardSide> modifiersPressed = @event.Data.ModifiersPressed;
            Dictionary<PhysicalKeyboardKey, LogicalKeyboardKey> modifierKeys = new Dictionary<PhysicalKeyboardKey, LogicalKeyboardKey> { };
            foreach (ModifierKey key in modifiersPressed.Keys)
            {
                HashSet<PhysicalKeyboardKey> mappedKeys = _ModifierKeyMap[new _ModifierSidePair(key, modifiersPressed[key])];

                foreach (PhysicalKeyboardKey physicalModifier in mappedKeys)
                {
                    modifierKeys[physicalModifier] = _AllModifiers[physicalModifier];
                }

            }

            _AllModifiersExceptFn.Keys.ForEach(_KeysPressed.Remove);
            if (!(@event.Data is RawKeyEventDataFuchsia) && !(@event.Data is RawKeyEventDataMacOs))
            {
                _KeysPressed.Remove(KeyboardkeyDefaultClass.PhysicalKeyboardKey.Fn);
            }

            _KeysPressed.AddAll(modifierKeys);
        }




        /// <Summary>
        /// Clears the list of keys returned from [keysPressed].
        ///
        /// This is used by the testing framework to make sure tests are hermetic.
        /// </Summary>
        public virtual void ClearKeysPressed() => _KeysPressed.Clear();


    }


    public class _ModifierSidePair
    {
        public _ModifierSidePair(FlutterSDK.Services.Rawkeyboard.ModifierKey modifier, FlutterSDK.Services.Rawkeyboard.KeyboardSide side)
        {
            this.Modifier = modifier;
            this.Side = side;
        }
        public virtual FlutterSDK.Services.Rawkeyboard.ModifierKey Modifier { get; set; }
        public virtual FlutterSDK.Services.Rawkeyboard.KeyboardSide Side { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is _ModifierSidePair && other.Modifier == Modifier && other.Side == Side;
        }



    }


    /// <Summary>
    /// An enum describing the side of the keyboard that a key is on, to allow
    /// discrimination between which key is pressed (e.g. the left or right SHIFT
    /// key).
    ///
    /// See also:
    ///
    ///  * [RawKeyEventData.isModifierPressed], which accepts this enum as an
    ///    argument.
    /// </Summary>
    public enum KeyboardSide
    {

        /// <Summary>
        /// Matches if either the left, right or both versions of the key are pressed.
        /// </Summary>
        Any,
        /// <Summary>
        /// Matches the left version of the key.
        /// </Summary>
        Left,
        /// <Summary>
        /// Matches the right version of the key.
        /// </Summary>
        Right,
        /// <Summary>
        /// Matches the left and right version of the key pressed simultaneously.
        /// </Summary>
        All,
    }


    /// <Summary>
    /// An enum describing the type of modifier key that is being pressed.
    ///
    /// See also:
    ///
    ///  * [RawKeyEventData.isModifierPressed], which accepts this enum as an
    ///    argument.
    /// </Summary>
    public enum ModifierKey
    {

        /// <Summary>
        /// The CTRL modifier key.
        ///
        /// Typically, there are two of these.
        /// </Summary>
        ControlModifier,
        /// <Summary>
        /// The SHIFT modifier key.
        ///
        /// Typically, there are two of these.
        /// </Summary>
        ShiftModifier,
        /// <Summary>
        /// The ALT modifier key.
        ///
        /// Typically, there are two of these.
        /// </Summary>
        AltModifier,
        /// <Summary>
        /// The META modifier key.
        ///
        /// Typically, there are two of these. This is, for example, the Windows key
        /// on Windows (⊞), the Command (⌘) key on macOS and iOS, and the Search (🔍)
        /// key on Android.
        /// </Summary>
        MetaModifier,
        /// <Summary>
        /// The CAPS LOCK modifier key.
        ///
        /// Typically, there is one of these. Only shown as "pressed" when the caps
        /// lock is on, so on a key up when the mode is turned on, on each key press
        /// when it's enabled, and on a key down when it is turned off.
        /// </Summary>
        CapsLockModifier,
        /// <Summary>
        /// The NUM LOCK modifier key.
        ///
        /// Typically, there is one of these. Only shown as "pressed" when the num
        /// lock is on, so on a key up when the mode is turned on, on each key press
        /// when it's enabled, and on a key down when it is turned off.
        /// </Summary>
        NumLockModifier,
        /// <Summary>
        /// The SCROLL LOCK modifier key.
        ///
        /// Typically, there is one of these.  Only shown as "pressed" when the scroll
        /// lock is on, so on a key up when the mode is turned on, on each key press
        /// when it's enabled, and on a key down when it is turned off.
        /// </Summary>
        ScrollLockModifier,
        /// <Summary>
        /// The FUNCTION (Fn) modifier key.
        ///
        /// Typically, there is one of these.
        /// </Summary>
        FunctionModifier,
        /// <Summary>
        /// The SYMBOL modifier key.
        ///
        /// Typically, there is one of these.
        /// </Summary>
        SymbolModifier,
    }

}
