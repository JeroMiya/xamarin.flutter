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
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Shortcuts
{
    internal static class ShortcutsDefaultClass
    {
    }

    /// <Summary>
    /// A set of [KeyboardKey]s that can be used as the keys in a [Map].
    ///
    /// A key set contains the keys that are down simultaneously to represent a
    /// shortcut.
    ///
    /// This is a thin wrapper around a [Set], but changes the equality comparison
    /// from an identity comparison to a contents comparison so that non-identical
    /// sets with the same keys in them will compare as equal.
    ///
    /// See also:
    ///
    ///  * [ShortcutManager], which uses [LogicalKeySet] (a [KeySet] subclass) to
    ///    define its key map.
    /// </Summary>
    public class KeySet<T>
    {
        /// <Summary>
        /// A constructor for making a [KeySet] of up to four keys.
        ///
        /// If you need a set of more than four keys, use [KeySet.fromSet].
        ///
        /// The `key1` parameter must not be null. The same [KeyboardKey] may
        /// not be appear more than once in the set.
        /// </Summary>
        public KeySet(T key1, T key2 = default(T), T key3 = default(T), T key4 = default(T))
        : base()
        {

            int count = 1;
            if (key2 != null)
            {
                _Keys.Add(key2);

            }

            if (key3 != null)
            {
                _Keys.Add(key3);

            }

            if (key4 != null)
            {
                _Keys.Add(key4);

            }


        }


        /// <Summary>
        /// Create  a [KeySet] from a set of [KeyboardKey]s.
        ///
        /// Do not mutate the `keys` set after passing it to this object.
        ///
        /// The `keys` set must not be null, contain nulls, or be empty.
        /// </Summary>
        public static KeySet<T> FromSet(HashSet<T> keys)
        {
            var instance = new KeySet<T>();
        }
        internal virtual HashSet<T> _Keys { get; set; }
        internal virtual List<int> _TempHashStore3 { get; set; }
        internal virtual List<int> _TempHashStore4 { get; set; }
        internal virtual int _HashCode { get; set; }
        public virtual HashSet<T> Keys { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is KeySet<T> && CollectionsDefaultClass.SetEquals(other._Keys, _Keys);
        }



    }


    /// <Summary>
    /// A set of [LogicalKeyboardKey]s that can be used as the keys in a map.
    ///
    /// A key set contains the keys that are down simultaneously to represent a
    /// shortcut.
    ///
    /// This is mainly used by [ShortcutManager] to allow the definition of shortcut
    /// mappings.
    ///
    /// This is a thin wrapper around a [Set], but changes the equality comparison
    /// from an identity comparison to a contents comparison so that non-identical
    /// sets with the same keys in them will compare as equal.
    /// </Summary>
    public class LogicalKeySet : FlutterSDK.Widgets.Shortcuts.KeySet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey>, IDiagnosticable
    {
        /// <Summary>
        /// A constructor for making a [LogicalKeySet] of up to four keys.
        ///
        /// If you need a set of more than four keys, use [LogicalKeySet.fromSet].
        ///
        /// The `key1` parameter must not be null. The same [LogicalKeyboardKey] may
        /// not be appear more than once in the set.
        /// </Summary>
        public LogicalKeySet(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key1, FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key2 = default(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey), FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key3 = default(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey), FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key4 = default(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey))
        : base(key1, key2, key3, key4)
        {

        }
        /// <Summary>
        /// Create  a [LogicalKeySet] from a set of [LogicalKeyboardKey]s.
        ///
        /// Do not mutate the `keys` set after passing it to this object.
        ///
        /// The `keys` must not be null.
        /// </Summary>
        public static LogicalKeySet FromSet(HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> keys)
        {
            var instance = new LogicalKeySet(keys);
        }
        internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _Modifiers { get; set; }

        /// <Summary>
        /// Returns a description of the key set that is short and readable.
        ///
        /// Intended to be used in debug mode for logging purposes.
        /// </Summary>
        public virtual string DebugDescribeKeys()
        {
            List<LogicalKeyboardKey> sortedKeys = Keys.ToList();
            Keys.ToList().Sort((LogicalKeyboardKey a, LogicalKeyboardKey b) =>
            {
                bool aIsModifier = a.Synonyms.IsNotEmpty || _Modifiers.Contains(a);
                bool bIsModifier = b.Synonyms.IsNotEmpty || _Modifiers.Contains(b);
                if (aIsModifier && !bIsModifier)
                {
                    return -1;
                }
                else if (bIsModifier && !aIsModifier)
                {
                    return 1;
                }

                return a.DebugName.CompareTo(b.DebugName);
            }
            );
            return sortedKeys.Map((LogicalKeyboardKey key) => =>key.DebugName.ToString()).Join(" + ");
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<HashSet<LogicalKeyboardKey>>("keys", _Keys, description: DebugDescribeKeys()));
        }



    }


    /// <Summary>
    /// Diagnostics property which handles formatting a `Map<LogicalKeySet, Intent>`
    /// (the same type as the [Shortcuts.shortcuts] property) so that it is human-readable.
    /// </Summary>
    public class ShortcutMapProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>>
    {
        /// <Summary>
        /// Create a diagnostics property for `Map<LogicalKeySet, Intent>` objects,
        /// which are the same type as the [Shortcuts.shortcuts] property.
        ///
        /// The [showName] and [level] arguments must not be null.
        /// </Summary>
        public ShortcutMapProperty(string name, Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> value, bool showName = true, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), string description = default(string))
        : base(name, value, showName: showName, defaultValue: defaultValue, level: level, description: description)
        {

        }

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
        {
            return $"'{{Value.Keys.Map((LogicalKeySet keySet) => =>$"'{{keySet.DebugDescribeKeys()}}: {Value[keySet]}'").Join(", ")}}'";
        }



    }


    /// <Summary>
    /// A manager of keyboard shortcut bindings.
    ///
    /// A [ShortcutManager] is obtained by calling [Shortcuts.of] on the context of
    /// the widget that you want to find a manager for.
    /// </Summary>
    public class ShortcutManager : FlutterSDK.Foundation.Changenotifier.ChangeNotifier, IDiagnosticable
    {
        /// <Summary>
        /// Constructs a [ShortcutManager].
        ///
        /// The [shortcuts] argument must not  be null.
        /// </Summary>
        public ShortcutManager(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> shortcuts = default(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>), bool modal = false)
        : base()
        {
            this.Modal = modal;
        }
        /// <Summary>
        /// True if the [ShortcutManager] should not pass on keys that it doesn't
        /// handle to any key-handling widgets that are ancestors to this one.
        ///
        /// Setting [modal] to true is the equivalent of always handling any key given
        /// to it, even if that key doesn't appear in the [shortcuts] map. Keys that
        /// don't appear in the map will be dropped.
        /// </Summary>
        public virtual bool Modal { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _Shortcuts { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Handles a key pressed `event` in the given `context`.
        ///
        /// The optional `keysPressed` argument provides an override to keys that the
        /// [RawKeyboard] reports. If not specified, uses [RawKeyboard.keysPressed]
        /// instead.
        /// </Summary>
        public virtual bool HandleKeypress(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Services.Rawkeyboard.RawKeyEvent @event, FlutterSDK.Widgets.Shortcuts.LogicalKeySet keysPressed = default(FlutterSDK.Widgets.Shortcuts.LogicalKeySet))
        {
            if (!(@event is RawKeyDownEvent))
            {
                return false;
            }


            LogicalKeySet keySet = keysPressed ?? LogicalKeySet.FromSet(RawkeyboardDefaultClass.RawKeyboard.Instance.KeysPressed);
            Intent matchedIntent = _Shortcuts[keySet];
            if (matchedIntent == null)
            {
                HashSet<LogicalKeyboardKey> pseudoKeys = new Dictionary<LogicalKeyboardKey> { };
                foreach (LogicalKeyboardKey setKey in keySet.Keys)
                {
                    HashSet<LogicalKeyboardKey> synonyms = setKey.Synonyms;
                    if (synonyms.IsNotEmpty)
                    {
                        pseudoKeys.Add(synonyms.First);
                    }
                    else
                    {
                        pseudoKeys.Add(setKey);
                    }

                }

                matchedIntent = _Shortcuts[LogicalKeySet.FromSet(pseudoKeys)];
            }

            if (matchedIntent != null)
            {
                BuildContext primaryContext = FocusmanagerDefaultClass.PrimaryFocus?.Context;
                if (primaryContext == null)
                {
                    return false;
                }

                return ActionsDefaultClass.Actions.Invoke(primaryContext, matchedIntent, nullOk: true);
            }

            return false;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Dictionary<LogicalKeySet, Intent>>("shortcuts", _Shortcuts));
            properties.Add(new FlagProperty("modal", value: Modal, ifTrue: "modal", defaultValue: false));
        }



    }


    /// <Summary>
    /// A widget that establishes an [ShortcutManager] to be used by its descendants
    /// when invoking an [Action] via a keyboard key combination that maps to an
    /// [Intent].
    ///
    /// See also:
    ///
    ///  * [Intent], a class for containing a description of a user action to be
    ///    invoked.
    ///  * [Action], a class for defining an invocation of a user action.
    /// </Summary>
    public class Shortcuts : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a ActionManager object.
        ///
        /// The [child] argument must not be null.
        /// </Summary>
        public Shortcuts(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Shortcuts.ShortcutManager manager = default(FlutterSDK.Widgets.Shortcuts.ShortcutManager), Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> shortcuts = default(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), string debugLabel = default(string))
        : base(key: key)
        {
            this.Manager = manager;
            this.ShortcutsValue = shortcuts;
            this.Child = child;
            this.DebugLabel = debugLabel;
        }
        /// <Summary>
        /// The [ShortcutManager] that will manage the mapping between key
        /// combinations and [Action]s.
        ///
        /// If not specified, uses a default-constructed [ShortcutManager].
        ///
        /// This manager will be given new [shortcuts] to manage whenever the
        /// [shortcuts] change materially.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Shortcuts.ShortcutManager Manager { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.shortcuts.shortcuts}
        /// The map of shortcuts that the [ShortcutManager] will be given to manage.
        ///
        /// For performance reasons, it is recommended that a pre-built map is passed
        /// in here (e.g. a final variable from your widget class) instead of defining
        /// it inline in the build function.
        /// {@endtemplate}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> ShortcutsValue { get; set; }
        /// <Summary>
        /// The child widget for this [Shortcuts] widget.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The debug label that is printed for this node when logged.
        ///
        /// If this label is set, then it will be displayed instead of the shortcut
        /// map when logged.
        ///
        /// This allows simplifying the diagnostic output to avoid cluttering it
        /// unnecessarily with the default shortcut map.
        /// </Summary>
        public virtual string DebugLabel { get; set; }

        /// <Summary>
        /// Returns the [ActionDispatcher] that most tightly encloses the given
        /// [BuildContext].
        ///
        /// The [context] argument must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Shortcuts.ShortcutManager Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {

            _ShortcutsMarker inherited = context.DependOnInheritedWidgetOfExactType();

            return inherited?.Notifier;
        }




        public new FlutterSDK.Widgets.Shortcuts._ShortcutsState CreateState() => new _ShortcutsState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<ShortcutManager>("manager", Manager, defaultValue: null));
            properties.Add(new ShortcutMapProperty("shortcuts", Shortcuts, description: DebugLabel?.IsNotEmpty ?? false ? DebugLabel : null));
        }



    }


    public class _ShortcutsState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Shortcuts.Shortcuts>
    {
        public _ShortcutsState()
        { }
        internal virtual FlutterSDK.Widgets.Shortcuts.ShortcutManager _InternalManager { get; set; }
        public virtual FlutterSDK.Widgets.Shortcuts.ShortcutManager Manager { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Dispose()
        {
            _InternalManager?.Dispose();
            base.Dispose();
        }




        public new void InitState()
        {
            base.InitState();
            if (Widget.Manager == null)
            {
                _InternalManager = new ShortcutManager();
            }

            Manager.Shortcuts = Widget.Shortcuts;
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Shortcuts.Shortcuts oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Manager != oldWidget.Manager)
            {
                if (Widget.Manager != null)
                {
                    _InternalManager?.Dispose();
                    _InternalManager = null;
                }
                else
                {
                    _InternalManager = (_InternalManager == null ? new ShortcutManager() : _InternalManager);
                }

            }

            Manager.Shortcuts = Widget.Shortcuts;
        }




        private bool _HandleOnKey(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Services.Rawkeyboard.RawKeyEvent @event)
        {
            if (node.Context == null)
            {
                return false;
            }

            return Manager.HandleKeypress(node.Context, @event) || Manager.Modal;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Focus(debugLabel: $"'{ShortcutsDefaultClass.Shortcuts}'", canRequestFocus: false, onKey: _HandleOnKey, child: new _ShortcutsMarker(manager: Manager, child: Widget.Child));
        }



    }


    public class _ShortcutsMarker : FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<FlutterSDK.Widgets.Shortcuts.ShortcutManager>
    {
        public _ShortcutsMarker(FlutterSDK.Widgets.Shortcuts.ShortcutManager manager = default(FlutterSDK.Widgets.Shortcuts.ShortcutManager), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(notifier: manager, child: child)
        {

        }
    }

}
