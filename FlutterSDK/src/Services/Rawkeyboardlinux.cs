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
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
namespace FlutterSDK.Services.Rawkeyboardlinux
{
    internal static class RawkeyboardlinuxDefaultClass
    {
    }

    public interface IKeyHelper { }

    public class KeyHelper
    {

        /// <Summary>
        /// Returns a [KeyboardSide] enum value that describes which side or sides of
        /// the given keyboard modifier key were pressed at the time of this event.
        /// </Summary>
        public virtual FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(FlutterSDK.Services.Rawkeyboard.ModifierKey key)
        {
            return default(KeyboardSide);
        }


        /// <Summary>
        /// Returns true if the given [ModifierKey] was pressed at the time of this
        /// event.
        /// </Summary>
        public virtual bool IsModifierPressed(FlutterSDK.Services.Rawkeyboard.ModifierKey key, int modifiers, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide), int keyCode = default(int), bool isDown = default(bool))
        {
            return default(bool);
        }


        /// <Summary>
        /// The numpad key from the specific key code mapping.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadKey(int keyCode)
        {
            return default(LogicalKeyboardKey);
        }


        /// <Summary>
        /// The logical key key from the specific key code mapping.
        /// </Summary>
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey(int keyCode)
        {
            return default(LogicalKeyboardKey);
        }

    }
    public static class KeyHelperMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IKeyHelper, KeyHelper> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IKeyHelper, KeyHelper>();
        static KeyHelper GetOrCreate(IKeyHelper instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new KeyHelper();
                _table.Add(instance, value);
            }
            return (KeyHelper)value;
        }
        public static FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(this IKeyHelper instance, FlutterSDK.Services.Rawkeyboard.ModifierKey key) => GetOrCreate(instance).GetModifierSide(key);
        public static bool IsModifierPressed(this IKeyHelper instance, FlutterSDK.Services.Rawkeyboard.ModifierKey key, int modifiers, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide), int keyCode = default(int), bool isDown = default(bool)) => GetOrCreate(instance).IsModifierPressed(key, modifiers, side, keyCode, isDown);
        public static FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadKey(this IKeyHelper instance, int keyCode) => GetOrCreate(instance).NumpadKey(keyCode);
        public static FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey(this IKeyHelper instance, int keyCode) => GetOrCreate(instance).LogicalKey(keyCode);
    }


    public interface IGLFWKeyHelper : IKeyHelper { }

    public class GLFWKeyHelper : IKeyHelper
    {
        /// <Summary>
        /// This mask is used to check the [modifiers] field to test whether the CAPS
        /// LOCK modifier key is on.
        ///
        /// {@template flutter.services.glfwKeyHelper.modifiers}
        /// Use this value if you need to decode the [modifiers] field yourself, but
        /// it's much easier to use [isModifierPressed] if you just want to know if a
        /// modifier is pressed. This is especially true on GLFW, since its modifiers
        /// don't include the effects of the current key event.
        /// {@endtemplate}
        /// </Summary>
        public virtual int ModifierCapsLock { get; set; }
        /// <Summary>
        /// This mask is used to check the [modifiers] field to test whether one of the
        /// SHIFT modifier keys is pressed.
        ///
        /// {@macro flutter.services.glfwKeyHelper.modifiers}
        /// </Summary>
        public virtual int ModifierShift { get; set; }
        /// <Summary>
        /// This mask is used to check the [modifiers] field to test whether one of the
        /// CTRL modifier keys is pressed.
        ///
        /// {@macro flutter.services.glfwKeyHelper.modifiers}
        /// </Summary>
        public virtual int ModifierControl { get; set; }
        /// <Summary>
        /// This mask is used to check the [modifiers] field to test whether one of the
        /// ALT modifier keys is pressed.
        ///
        /// {@macro flutter.services.glfwKeyHelper.modifiers}
        /// </Summary>
        public virtual int ModifierAlt { get; set; }
        /// <Summary>
        /// This mask is used to check the [modifiers] field to test whether one of the
        /// Meta(SUPER) modifier keys is pressed.
        ///
        /// {@macro flutter.services.glfwKeyHelper.modifiers}
        /// </Summary>
        public virtual int ModifierMeta { get; set; }
        /// <Summary>
        /// This mask is used to check the [modifiers] field to test whether any key in
        /// the numeric keypad is pressed.
        ///
        /// {@macro flutter.services.glfwKeyHelper.modifiers}
        /// </Summary>
        public virtual int ModifierNumericPad { get; set; }

        private int _MergeModifiers(int modifiers = default(int), int keyCode = default(int), bool isDown = default(bool))
        {
            int shiftLeftKeyCode = 340;
            int shiftRightKeyCode = 344;
            int controlLeftKeyCode = 341;
            int controlRightKeyCode = 345;
            int altLeftKeyCode = 342;
            int altRightKeyCode = 346;
            int metaLeftKeyCode = 343;
            int metaRightKeyCode = 347;
            int capsLockKeyCode = 280;
            int numLockKeyCode = 282;
            int modifierChange = 0;
            switch (keyCode) { case shiftLeftKeyCode: case shiftRightKeyCode: modifierChange = ModifierShift; break; case controlLeftKeyCode: case controlRightKeyCode: modifierChange = ModifierControl; break; case altLeftKeyCode: case altRightKeyCode: modifierChange = ModifierAlt; break; case metaLeftKeyCode: case metaRightKeyCode: modifierChange = ModifierMeta; break; case capsLockKeyCode: modifierChange = ModifierCapsLock; break; case numLockKeyCode: modifierChange = ModifierNumericPad; break; default: break; }
            return isDown ? modifiers | modifierChange : modifiers & ~modifierChange;
        }




        public new bool IsModifierPressed(FlutterSDK.Services.Rawkeyboard.ModifierKey key, int modifiers, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide), int keyCode = default(int), bool isDown = default(bool))
        {
            modifiers = _MergeModifiers(modifiers: modifiers, keyCode: keyCode, isDown: isDown);
            switch (key) { case ModifierKey.ControlModifier: return modifiers & ModifierControl != 0; case ModifierKey.ShiftModifier: return modifiers & ModifierShift != 0; case ModifierKey.AltModifier: return modifiers & ModifierAlt != 0; case ModifierKey.MetaModifier: return modifiers & ModifierMeta != 0; case ModifierKey.CapsLockModifier: return modifiers & ModifierCapsLock != 0; case ModifierKey.NumLockModifier: return modifiers & ModifierNumericPad != 0; case ModifierKey.FunctionModifier: case ModifierKey.SymbolModifier: case ModifierKey.ScrollLockModifier: return false; }
            return false;
        }




        public new FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(FlutterSDK.Services.Rawkeyboard.ModifierKey key)
        {
            switch (key) { case ModifierKey.ControlModifier: case ModifierKey.ShiftModifier: case ModifierKey.AltModifier: case ModifierKey.MetaModifier: return KeyboardSide.Any; case ModifierKey.CapsLockModifier: case ModifierKey.NumLockModifier: case ModifierKey.FunctionModifier: case ModifierKey.SymbolModifier: case ModifierKey.ScrollLockModifier: return KeyboardSide.All; }

            return null;
        }




        public new FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadKey(int keyCode)
        {
            return KeyboardmapsDefaultClass.KGlfwNumpadMap[keyCode];
        }




        public new FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey(int keyCode)
        {
            return KeyboardmapsDefaultClass.KGlfwToLogicalKey[keyCode];
        }



    }
    public static class GLFWKeyHelperMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IGLFWKeyHelper, GLFWKeyHelper> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IGLFWKeyHelper, GLFWKeyHelper>();
        static GLFWKeyHelper GetOrCreate(IGLFWKeyHelper instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new GLFWKeyHelper();
                _table.Add(instance, value);
            }
            return (GLFWKeyHelper)value;
        }
        public static int ModifierCapsLockProperty(this IGLFWKeyHelper instance) => GetOrCreate(instance).ModifierCapsLock;
        public static int ModifierShiftProperty(this IGLFWKeyHelper instance) => GetOrCreate(instance).ModifierShift;
        public static int ModifierControlProperty(this IGLFWKeyHelper instance) => GetOrCreate(instance).ModifierControl;
        public static int ModifierAltProperty(this IGLFWKeyHelper instance) => GetOrCreate(instance).ModifierAlt;
        public static int ModifierMetaProperty(this IGLFWKeyHelper instance) => GetOrCreate(instance).ModifierMeta;
        public static int ModifierNumericPadProperty(this IGLFWKeyHelper instance) => GetOrCreate(instance).ModifierNumericPad;
        public static bool IsModifierPressed(this IGLFWKeyHelper instance, FlutterSDK.Services.Rawkeyboard.ModifierKey key, int modifiers, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide), int keyCode = default(int), bool isDown = default(bool)) => GetOrCreate(instance).IsModifierPressed(key, modifiers, side, keyCode, isDown);
        public static FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(this IGLFWKeyHelper instance, FlutterSDK.Services.Rawkeyboard.ModifierKey key) => GetOrCreate(instance).GetModifierSide(key);
        public static FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadKey(this IGLFWKeyHelper instance, int keyCode) => GetOrCreate(instance).NumpadKey(keyCode);
        public static FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey(this IGLFWKeyHelper instance, int keyCode) => GetOrCreate(instance).LogicalKey(keyCode);
    }


    /// <Summary>
    /// Platform-specific key event data for Linux.
    ///
    /// Different window toolkit implementations can map to different key codes. This class
    /// will use the correct mapping depending on the [toolkit] provided.
    ///
    /// See also:
    ///
    ///  * [RawKeyboard], which uses this interface to expose key data.
    /// </Summary>
    public class RawKeyEventDataLinux : FlutterSDK.Services.Rawkeyboard.RawKeyEventData
    {
        /// <Summary>
        /// Creates a key event data structure specific for macOS.
        ///
        /// The [toolkit], [scanCode], [unicodeScalarValues], [keyCode], and [modifiers],
        /// arguments must not be null.
        /// </Summary>
        public RawKeyEventDataLinux(FlutterSDK.Services.Rawkeyboardlinux.KeyHelper keyHelper = default(FlutterSDK.Services.Rawkeyboardlinux.KeyHelper), int unicodeScalarValues = 0, int scanCode = 0, int keyCode = 0, int modifiers = 0, bool isDown = default(bool))
        : base()
        {
            this.KeyHelper = keyHelper;
            this.UnicodeScalarValues = unicodeScalarValues;
            this.ScanCode = scanCode;
            this.KeyCode = keyCode;
            this.Modifiers = modifiers;
            this.IsDown = isDown;
        }
        /// <Summary>
        /// A helper class that abstracts the fetching of the toolkit-specific mappings.
        ///
        /// There is no real concept of a "native" window toolkit on Linux, and each implementation
        /// (GLFW, GTK, QT, etc) may have a different key code mapping.
        /// </Summary>
        public virtual FlutterSDK.Services.Rawkeyboardlinux.KeyHelper KeyHelper { get; set; }
        /// <Summary>
        /// An int with up to two Unicode scalar values generated by a single keystroke. An assertion
        /// will fire if more than two values are encoded in a single keystroke.
        ///
        /// This is typically the character that [keyCode] would produce without any modifier keys.
        /// For dead keys, it is typically the diacritic it would add to a character. Defaults to 0,
        /// asserted to be not null.
        /// </Summary>
        public virtual int UnicodeScalarValues { get; set; }
        /// <Summary>
        /// The hardware scan code id corresponding to this key event.
        ///
        /// These values are not reliable and vary from device to device, so this
        /// information is mainly useful for debugging.
        /// </Summary>
        public virtual int ScanCode { get; set; }
        /// <Summary>
        /// The hardware key code corresponding to this key event.
        ///
        /// This is the physical key that was pressed, not the Unicode character.
        /// This value may be different depending on the window toolkit used. See [KeyHelper].
        /// </Summary>
        public virtual int KeyCode { get; set; }
        /// <Summary>
        /// A mask of the current modifiers using the values in Modifier Flags.
        /// This value may be different depending on the window toolkit used. See [KeyHelper].
        /// </Summary>
        public virtual int Modifiers { get; set; }
        /// <Summary>
        /// Whether or not this key event is a key down (true) or key up (false).
        /// </Summary>
        public virtual bool IsDown { get; set; }
        public virtual string KeyLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PhysicalKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogicalKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsModifierPressed(FlutterSDK.Services.Rawkeyboard.ModifierKey key, FlutterSDK.Services.Rawkeyboard.KeyboardSide side = default(FlutterSDK.Services.Rawkeyboard.KeyboardSide))
        {
            return KeyHelper.IsModifierPressed(key, Modifiers, side: side, keyCode: KeyCode, isDown: IsDown);
        }




        public new FlutterSDK.Services.Rawkeyboard.KeyboardSide GetModifierSide(FlutterSDK.Services.Rawkeyboard.ModifierKey key)
        {
            return KeyHelper.GetModifierSide(key);
        }




    }

}
