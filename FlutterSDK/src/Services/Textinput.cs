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
namespace FlutterSDK.Services.Textinput
{
    internal static class TextinputDefaultClass
    {
        public static bool _KIsBrowser = default(bool);
        internal static TextAffinity _ToTextAffinity(string affinity)
        {
            switch (affinity) { case "TextAffinity.downstream": return TextAffinity.Downstream; case "TextAffinity.upstream": return TextAffinity.Upstream; }
            return null;
        }



        internal static FlutterSDK.Services.Textinput.TextInputAction _ToTextInputAction(string action)
        {
            switch (action) { case "TextInputAction.none": return TextInputAction.None; case "TextInputAction.unspecified": return TextInputAction.Unspecified; case "TextInputAction.go": return TextInputAction.Go; case "TextInputAction.search": return TextInputAction.Search; case "TextInputAction.send": return TextInputAction.Send; case "TextInputAction.next": return TextInputAction.Next; case "TextInputAction.previuos": return TextInputAction.Previous; case "TextInputAction.continue_action": return TextInputAction.ContinueAction; case "TextInputAction.join": return TextInputAction.Join; case "TextInputAction.route": return TextInputAction.Route; case "TextInputAction.emergencyCall": return TextInputAction.EmergencyCall; case "TextInputAction.done": return TextInputAction.Done; case "TextInputAction.newline": return TextInputAction.Newline; }
            throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary($"'Unknown text input action: {action}'") });
        }



        internal static FlutterSDK.Services.Textinput.FloatingCursorDragState _ToTextCursorAction(string state)
        {
            switch (state) { case "FloatingCursorDragState.start": return FloatingCursorDragState.Start; case "FloatingCursorDragState.update": return FloatingCursorDragState.Update; case "FloatingCursorDragState.end": return FloatingCursorDragState.End; }
            throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary($"'Unknown text cursor action: {state}'") });
        }



        internal static FlutterSDK.Services.Textinput.RawFloatingCursorPoint _ToTextPoint(FlutterSDK.Services.Textinput.FloatingCursorDragState state, Dictionary<string, object> encoded)
        {



            Offset offset = state == FloatingCursorDragState.Update ? new Offset(encoded['X'] as double, encoded['Y'] as double) : new Offset(0, 0);
            return new RawFloatingCursorPoint(offset: offset, state: state);
        }



    }

    /// <Summary>
    /// An interface to receive information from [TextInput].
    ///
    /// See also:
    ///
    ///  * [TextInput.attach]
    /// </Summary>
    public interface ITextInputClient
    {
        void UpdateEditingValue(FlutterSDK.Services.Textinput.TextEditingValue value);
        void PerformAction(FlutterSDK.Services.Textinput.TextInputAction action);
        void UpdateFloatingCursor(FlutterSDK.Services.Textinput.RawFloatingCursorPoint point);
        void ConnectionClosed();
        FlutterSDK.Services.Textinput.TextEditingValue CurrentTextEditingValue { get; }
    }


    public interface ITextSelectionDelegate { }

    public class TextSelectionDelegate
    {
        public virtual FlutterSDK.Services.Textinput.TextEditingValue TextEditingValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CutEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CopyEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool PasteEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectAllEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Hides the text selection toolbar.
        /// </Summary>
        public virtual void HideToolbar()
        {
        }


        /// <Summary>
        /// Brings the provided [TextPosition] into the visible area of the text
        /// input.
        /// </Summary>
        public virtual void BringIntoView(TextPosition position)
        {
        }

    }
    public static class TextSelectionDelegateMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ITextSelectionDelegate, TextSelectionDelegate> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ITextSelectionDelegate, TextSelectionDelegate>();
        static TextSelectionDelegate GetOrCreate(ITextSelectionDelegate instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new TextSelectionDelegate();
                _table.Add(instance, value);
            }
            return (TextSelectionDelegate)value;
        }
        public static FlutterSDK.Services.Textinput.TextEditingValue TextEditingValueProperty(this ITextSelectionDelegate instance) => GetOrCreate(instance).TextEditingValue;
        public static bool CutEnabledProperty(this ITextSelectionDelegate instance) => GetOrCreate(instance).CutEnabled;
        public static bool CopyEnabledProperty(this ITextSelectionDelegate instance) => GetOrCreate(instance).CopyEnabled;
        public static bool PasteEnabledProperty(this ITextSelectionDelegate instance) => GetOrCreate(instance).PasteEnabled;
        public static bool SelectAllEnabledProperty(this ITextSelectionDelegate instance) => GetOrCreate(instance).SelectAllEnabled;
        public static void HideToolbar(this ITextSelectionDelegate instance) => GetOrCreate(instance).HideToolbar();
        public static void BringIntoView(this ITextSelectionDelegate instance, TextPosition position) => GetOrCreate(instance).BringIntoView(position);
    }


    /// <Summary>
    /// The type of information for which to optimize the text input control.
    ///
    /// On Android, behavior may vary across device and keyboard provider.
    ///
    /// This class stays as close to [Enum] interface as possible, and allows
    /// for additional flags for some input types. For example, numeric input
    /// can specify whether it supports decimal numbers and/or signed numbers.
    /// </Summary>
    public class TextInputType
    {
        internal TextInputType(int index)
        : base()
        {
            this.Index = index;
        }
        /// <Summary>
        /// Optimize for numerical information.
        ///
        /// Requests a numeric keyboard with additional settings.
        /// The [signed] and [decimal] parameters are optional.
        /// </Summary>
        public static TextInputType NumberWithOptions(bool signed = false, bool @decimal = false)
        {
            var instance = new TextInputType(); instance.Signed = signed;
            instance.@decimal = @decimal;
        }
        /// <Summary>
        /// Enum value index, corresponds to one of the [values].
        /// </Summary>
        public virtual int Index { get; set; }
        /// <Summary>
        /// The number is signed, allowing a positive or negative sign at the start.
        ///
        /// This flag is only used for the [number] input type, otherwise `null`.
        /// Use `const TextInputType.numberWithOptions(signed: true)` to set this.
        /// </Summary>
        public virtual bool Signed { get; set; }
        /// <Summary>
        /// The number is decimal, allowing a decimal point to provide fractional.
        ///
        /// This flag is only used for the [number] input type, otherwise `null`.
        /// Use `const TextInputType.numberWithOptions(decimal: true)` to set this.
        /// </Summary>
        public virtual bool @decimal { get; set; }
        /// <Summary>
        /// Optimize for textual information.
        ///
        /// Requests the default platform keyboard.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType Text { get; set; }
        /// <Summary>
        /// Optimize for multiline textual information.
        ///
        /// Requests the default platform keyboard, but accepts newlines when the
        /// enter key is pressed. This is the input type used for all multiline text
        /// fields.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType Multiline { get; set; }
        /// <Summary>
        /// Optimize for unsigned numerical information without a decimal point.
        ///
        /// Requests a default keyboard with ready access to the number keys.
        /// Additional options, such as decimal point and/or positive/negative
        /// signs, can be requested using [new TextInputType.numberWithOptions].
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType Number { get; set; }
        /// <Summary>
        /// Optimize for telephone numbers.
        ///
        /// Requests a keyboard with ready access to the number keys, "*", and "#".
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType Phone { get; set; }
        /// <Summary>
        /// Optimize for date and time information.
        ///
        /// On iOS, requests the default keyboard.
        ///
        /// On Android, requests a keyboard with ready access to the number keys,
        /// ":", and "-".
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType Datetime { get; set; }
        /// <Summary>
        /// Optimize for email addresses.
        ///
        /// Requests a keyboard with ready access to the "@" and "." keys.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType EmailAddress { get; set; }
        /// <Summary>
        /// Optimize for URLs.
        ///
        /// Requests a keyboard with ready access to the "/" and "." keys.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType Url { get; set; }
        /// <Summary>
        /// Optimize for passwords that are visible to the user.
        ///
        /// Requests a keyboard with ready access to both letters and numbers.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType VisiblePassword { get; set; }
        /// <Summary>
        /// All possible enum values.
        /// </Summary>
        public virtual List<FlutterSDK.Services.Textinput.TextInputType> Values { get; set; }
        internal virtual List<string> _Names { get; set; }
        internal virtual string _Name { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a representation of this object as a JSON object.
        /// </Summary>
        public virtual Dictionary<string, object> ToJson()
        {
            return new Dictionary<string, object> { { "name", _Name }{ "signed", Signed }{ "decimal", Decimal } };
        }





        public new bool Equals(@Object other)
        {
            return other is TextInputType && other.Index == Index && other.Signed == Signed && other.Decimal == Decimal;
        }



    }


    /// <Summary>
    /// Controls the visual appearance of the text input control.
    ///
    /// Many [TextInputAction]s are common between Android and iOS. However, if an
    /// [inputAction] is provided that is not supported by the current
    /// platform in debug mode, an error will be thrown when the corresponding
    /// text input is attached. For example, providing iOS's "emergencyCall"
    /// action when running on an Android device will result in an error when in
    /// debug mode. In release mode, incompatible [TextInputAction]s are replaced
    /// either with "unspecified" on Android, or "default" on iOS. Appropriate
    /// [inputAction]s can be chosen by checking the current platform and then
    /// selecting the appropriate action.
    ///
    /// See also:
    ///
    ///  * [TextInput.attach]
    ///  * [TextInputAction]
    /// </Summary>
    public class TextInputConfiguration
    {
        /// <Summary>
        /// Creates configuration information for a text input control.
        ///
        /// All arguments have default values, except [actionLabel]. Only
        /// [actionLabel] may be null.
        /// </Summary>
        public TextInputConfiguration(FlutterSDK.Services.Textinput.TextInputType inputType = default(FlutterSDK.Services.Textinput.TextInputType), bool obscureText = false, bool autocorrect = true, FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = true, string actionLabel = default(string), FlutterSDK.Services.Textinput.TextInputAction inputAction = default(FlutterSDK.Services.Textinput.TextInputAction), Brightness keyboardAppearance = default(Brightness), FlutterSDK.Services.Textinput.TextCapitalization textCapitalization = default(FlutterSDK.Services.Textinput.TextCapitalization))
        : base()
        {
            this.InputType = inputType;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.EnableSuggestions = enableSuggestions;
            this.ActionLabel = actionLabel;
            this.InputAction = inputAction;
            this.KeyboardAppearance = keyboardAppearance;
            this.TextCapitalization = textCapitalization;
        }
        /// <Summary>
        /// The type of information for which to optimize the text input control.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType InputType { get; set; }
        /// <Summary>
        /// Whether to hide the text being edited (e.g., for passwords).
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool ObscureText { get; set; }
        /// <Summary>
        /// Whether to enable autocorrection.
        ///
        /// Defaults to true.
        /// </Summary>
        public virtual bool Autocorrect { get; set; }
        /// <Summary>
        /// {@template flutter.services.textInput.smartDashesType}
        /// Whether to allow the platform to automatically format dashes.
        ///
        /// This flag only affects iOS versions 11 and above. It sets
        /// [`UITextSmartDashesType`](https://developer.apple.com/documentation/uikit/uitextsmartdashestype?language=objc)
        /// in the engine. When true, it passes
        /// [`UITextSmartDashesTypeYes`](https://developer.apple.com/documentation/uikit/uitextsmartdashestype/uitextsmartdashestypeyes?language=objc),
        /// and when false, it passes
        /// [`UITextSmartDashesTypeNo`](https://developer.apple.com/documentation/uikit/uitextsmartdashestype/uitextsmartdashestypeno?language=objc).
        ///
        /// As an example of what this does, two consecutive hyphen characters will be
        /// automatically replaced with one en dash, and three consecutive hyphens
        /// will become one em dash.
        ///
        /// Defaults to true, unless [obscureText] is true, when it defaults to false.
        /// This is to avoid the problem where password fields receive autoformatted
        /// characters.
        ///
        /// See also:
        ///
        ///  * [smartQuotesType]
        ///  * <https://developer.apple.com/documentation/uikit/uitextinputtraits>
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        /// <Summary>
        /// {@template flutter.services.textInput.smartQuotesType}
        /// Whether to allow the platform to automatically format quotes.
        ///
        /// This flag only affects iOS. It sets
        /// [`UITextSmartQuotesType`](https://developer.apple.com/documentation/uikit/uitextsmartquotestype?language=objc)
        /// in the engine. When true, it passes
        /// [`UITextSmartQuotesTypeYes`](https://developer.apple.com/documentation/uikit/uitextsmartquotestype/uitextsmartquotestypeyes?language=objc),
        /// and when false, it passes
        /// [`UITextSmartQuotesTypeNo`](https://developer.apple.com/documentation/uikit/uitextsmartquotestype/uitextsmartquotestypeno?language=objc).
        ///
        /// As an example of what this does, a standard vertical double quote
        /// character will be automatically replaced by a left or right double quote
        /// depending on its position in a word.
        ///
        /// Defaults to true, unless [obscureText] is true, when it defaults to false.
        /// This is to avoid the problem where password fields receive autoformatted
        /// characters.
        ///
        /// See also:
        ///
        ///  * [smartDashesType]
        ///  * <https://developer.apple.com/documentation/uikit/uitextinputtraits>
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        /// <Summary>
        /// {@template flutter.services.textInput.enableSuggestions}
        /// Whether to show input suggestions as the user types.
        ///
        /// This flag only affects Android. On iOS, suggestions are tied directly to
        /// [autocorrect], so that suggestions are only shown when [autocorrect] is
        /// true. On Android autocorrection and suggestion are controlled separately.
        ///
        /// Defaults to true. Cannot be null.
        ///
        /// See also:
        ///
        ///  * <https://developer.android.com/reference/android/text/InputType.html#TYPE_TEXT_FLAG_NO_SUGGESTIONS>
        /// {@endtemplate}
        /// </Summary>
        public virtual bool EnableSuggestions { get; set; }
        /// <Summary>
        /// What text to display in the text input control's action button.
        /// </Summary>
        public virtual string ActionLabel { get; set; }
        /// <Summary>
        /// What kind of action to request for the action button on the IME.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputAction InputAction { get; set; }
        /// <Summary>
        /// Specifies how platforms may automatically capitalize text entered by the
        /// user.
        ///
        /// Defaults to [TextCapitalization.none].
        ///
        /// See also:
        ///
        ///  * [TextCapitalization], for a description of each capitalization behavior.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextCapitalization TextCapitalization { get; set; }
        /// <Summary>
        /// The appearance of the keyboard.
        ///
        /// This setting is only honored on iOS devices.
        ///
        /// Defaults to [Brightness.light].
        /// </Summary>
        public virtual Brightness KeyboardAppearance { get; set; }

        /// <Summary>
        /// Returns a representation of this object as a JSON object.
        /// </Summary>
        public virtual Dictionary<string, object> ToJson()
        {
            return new Dictionary<string, object> { { "inputType", InputType.ToJson() }{ "obscureText", ObscureText }{ "autocorrect", Autocorrect }{ "smartDashesType", SmartDashesType.Index.ToString() }{ "smartQuotesType", SmartQuotesType.Index.ToString() }{ "enableSuggestions", EnableSuggestions }{ "actionLabel", ActionLabel }{ "inputAction", InputAction.ToString() }{ "textCapitalization", TextCapitalization.ToString() }{ "keyboardAppearance", KeyboardAppearance.ToString() } };
        }



    }


    /// <Summary>
    /// The current state and position of the floating cursor.
    /// </Summary>
    public class RawFloatingCursorPoint
    {
        /// <Summary>
        /// Creates information for setting the position and state of a floating
        /// cursor.
        ///
        /// [state] must not be null and [offset] must not be null if the state is
        /// [FloatingCursorDragState.Update].
        /// </Summary>
        public RawFloatingCursorPoint(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Services.Textinput.FloatingCursorDragState state = default(FlutterSDK.Services.Textinput.FloatingCursorDragState))
        : base()
        {
            this.Offset = offset;
            this.State = state;
        }
        /// <Summary>
        /// The raw position of the floating cursor as determined by the iOS sdk.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        /// <Summary>
        /// The state of the floating cursor.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.FloatingCursorDragState State { get; set; }
    }


    /// <Summary>
    /// The current text, selection, and composing state for editing a run of text.
    /// </Summary>
    public class TextEditingValue
    {
        /// <Summary>
        /// Creates information for editing a run of text.
        ///
        /// The selection and composing range must be within the text.
        ///
        /// The [text], [selection], and [composing] arguments must not be null but
        /// each have default values.
        /// </Summary>
        public TextEditingValue(string text = default(string), FlutterSDK.Services.Textediting.TextSelection selection = default(FlutterSDK.Services.Textediting.TextSelection), TextRange composing = default(TextRange))
        : base()
        {
            this.Text = text;
            this.Selection = selection;
            this.Composing = composing;
        }
        /// <Summary>
        /// Creates an instance of this class from a JSON object.
        /// </Summary>
        public static TextEditingValue FromJSON(Dictionary<string, object> encoded)
        {
            var instance = new TextEditingValue();
            return new TextEditingValue(text: encoded["text"] as string, selection: new TextSelection(baseOffset: encoded["selectionBase"] as int ?? -1, extentOffset: encoded["selectionExtent"] as int ?? -1, affinity: TextinputDefaultClass._ToTextAffinity(encoded["selectionAffinity"] as string) ?? TextAffinity.Downstream, isDirectional: encoded["selectionIsDirectional"] as bool ?? false), composing: new TextRange(start: encoded["composingBase"] as int ?? -1, end: encoded["composingExtent"] as int ?? -1));
        }


        /// <Summary>
        /// The current text being edited.
        /// </Summary>
        public virtual string Text { get; set; }
        /// <Summary>
        /// The range of text that is currently selected.
        /// </Summary>
        public virtual FlutterSDK.Services.Textediting.TextSelection Selection { get; set; }
        /// <Summary>
        /// The range of text that is still being composed.
        /// </Summary>
        public virtual TextRange Composing { get; set; }
        /// <Summary>
        /// A value that corresponds to the empty string with no selection and no composing range.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextEditingValue Empty { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a representation of this object as a JSON object.
        /// </Summary>
        public virtual Dictionary<string, object> ToJSON()
        {
            return new Dictionary<string, object> { { "text", Text }{ "selectionBase", Selection.BaseOffset }{ "selectionExtent", Selection.ExtentOffset }{ "selectionAffinity", Selection.Affinity.ToString() }{ "selectionIsDirectional", Selection.IsDirectional }{ "composingBase", Composing.Start }{ "composingExtent", Composing.End } };
        }




        /// <Summary>
        /// Creates a copy of this value but with the given fields replaced with the new values.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextEditingValue CopyWith(string text = default(string), FlutterSDK.Services.Textediting.TextSelection selection = default(FlutterSDK.Services.Textediting.TextSelection), TextRange composing = default(TextRange))
        {
            return new TextEditingValue(text: text ?? this.Text, selection: selection ?? this.Selection, composing: composing ?? this.Composing);
        }





        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            return other is TextEditingValue && other.Text == Text && other.Selection == Selection && other.Composing == Composing;
        }



    }


    /// <Summary>
    /// An interface to receive information from [TextInput].
    ///
    /// See also:
    ///
    ///  * [TextInput.attach]
    /// </Summary>
    public class TextInputClient
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public TextInputClient()
        {

        }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue CurrentTextEditingValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Requests that this client update its editing state to the given value.
        /// </Summary>
        public virtual void UpdateEditingValue(FlutterSDK.Services.Textinput.TextEditingValue value)
        {
        }


        /// <Summary>
        /// Requests that this client perform the given action.
        /// </Summary>
        public virtual void PerformAction(FlutterSDK.Services.Textinput.TextInputAction action)
        {
        }


        /// <Summary>
        /// Updates the floating cursor position and state.
        /// </Summary>
        public virtual void UpdateFloatingCursor(FlutterSDK.Services.Textinput.RawFloatingCursorPoint point)
        {
        }


        /// <Summary>
        /// Platform notified framework of closed connection.
        ///
        /// [TextInputClient] should cleanup its connection and finalize editing.
        /// </Summary>
        public virtual void ConnectionClosed()
        {
        }

    }


    /// <Summary>
    /// An interface for interacting with a text input control.
    ///
    /// See also:
    ///
    ///  * [TextInput.attach]
    /// </Summary>
    public class TextInputConnection
    {
        internal TextInputConnection(FlutterSDK.Services.Textinput.TextInputClient _client)
        : base()
        {
            this._Client = _client;
        }
        internal virtual Size _CachedSize { get; set; }
        internal virtual Matrix4 _CachedTransform { get; set; }
        internal virtual int _NextId { get; set; }
        internal virtual int _Id { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextInputClient _Client { get; set; }
        public virtual bool Attached { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Resets the internal ID counter for testing purposes.
        ///
        /// This call has no effect when asserts are disabled. Calling it from
        /// application code will likely break text input for the application.
        /// </Summary>
        public virtual void DebugResetId(int to = 1)
        {


        }




        /// <Summary>
        /// Requests that the text input control become visible.
        /// </Summary>
        public virtual void Show()
        {

            TextinputDefaultClass.TextInput._Instance._Show();
        }




        /// <Summary>
        /// Requests that the text input control change its internal state to match the given state.
        /// </Summary>
        public virtual void SetEditingState(FlutterSDK.Services.Textinput.TextEditingValue value)
        {

            TextinputDefaultClass.TextInput._Instance._SetEditingState(value);
        }




        /// <Summary>
        /// Send the size and transform of the editable text to engine.
        ///
        /// The values are sent as platform messages so they can be used on web for
        /// example to correctly position and size the html input field.
        ///
        /// 1. [editableBoxSize]: size of the render editable box.
        ///
        /// 2. [transform]: a matrix that maps the local paint coordinate system
        ///                 to the [PipelineOwner.rootNode].
        /// </Summary>
        public virtual void SetEditableSizeAndTransform(Size editableBoxSize, Matrix4 transform)
        {
            if (editableBoxSize != _CachedSize || transform != _CachedTransform)
            {
                _CachedSize = editableBoxSize;
                _CachedTransform = transform;
                TextinputDefaultClass.TextInput._Instance._SetEditableSizeAndTransform(new Dictionary<string, object> { { "width", editableBoxSize.Width }{ "height", editableBoxSize.Height }{ "transform", transform.Storage } });
            }

        }




        /// <Summary>
        /// Send text styling information.
        ///
        /// This information is used by the Flutter Web Engine to change the style
        /// of the hidden native input's content. Hence, the content size will match
        /// to the size of the editable widget's content.
        /// </Summary>
        public virtual void SetStyle(string fontFamily = default(string), double fontSize = default(double), FontWeight fontWeight = default(FontWeight), TextDirection textDirection = default(TextDirection), TextAlign textAlign = default(TextAlign))
        {

            TextinputDefaultClass.TextInput._Instance._SetStyle(new Dictionary<string, object> { { "fontFamily", fontFamily }{ "fontSize", fontSize }{ "fontWeightIndex", fontWeight?.Index }{ "textAlignIndex", textAlign.Index }{ "textDirectionIndex", textDirection.Index } });
        }




        /// <Summary>
        /// Stop interacting with the text input control.
        ///
        /// After calling this method, the text input control might disappear if no
        /// other client attaches to it within this animation frame.
        /// </Summary>
        public virtual void Close()
        {
            if (Attached)
            {
                TextinputDefaultClass.TextInput._Instance._ClearClient();
            }


        }




        /// <Summary>
        /// Platform sent a notification informing the connection is closed.
        ///
        /// [TextInputConnection] should clean current client connection.
        /// </Summary>
        public virtual void ConnectionClosedReceived()
        {
            TextinputDefaultClass.TextInput._Instance._CurrentConnection = null;

        }



    }


    /// <Summary>
    /// An interface to the system's text input control.
    /// </Summary>
    public class TextInput
    {
        internal TextInput()
        {

            _Channel = SystemchannelsDefaultClass.SystemChannels.TextInput;
            _Channel.SetMethodCallHandler(_HandleTextInputInvocation);
        }


        internal virtual FlutterSDK.Services.Textinput.TextInput _Instance { get; set; }
        internal virtual List<FlutterSDK.Services.Textinput.TextInputAction> _AndroidSupportedInputActions { get; set; }
        internal virtual List<FlutterSDK.Services.Textinput.TextInputAction> _IOSSupportedInputActions { get; set; }
        internal virtual FlutterSDK.Services.Platformchannel.MethodChannel _Channel { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextInputConnection _CurrentConnection { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextInputConfiguration _CurrentConfiguration { get; set; }
        internal virtual bool _HidePending { get; set; }

        /// <Summary>
        /// Set the [MethodChannel] used to communicate with the system's text input
        /// control.
        ///
        /// This is only meant for testing within the Flutter SDK. Changing this
        /// will break the ability to input text. This has no effect if asserts are
        /// disabled.
        /// </Summary>
        public virtual void SetChannel(FlutterSDK.Services.Platformchannel.MethodChannel newChannel)
        {

        }




        /// <Summary>
        /// Begin interacting with the text input control.
        ///
        /// Calling this function helps multiple clients coordinate about which one is
        /// currently interacting with the text input control. The returned
        /// [TextInputConnection] provides an interface for actually interacting with
        /// the text input control.
        ///
        /// A client that no longer wishes to interact with the text input control
        /// should call [TextInputConnection.close] on the returned
        /// [TextInputConnection].
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputConnection Attach(FlutterSDK.Services.Textinput.TextInputClient client, FlutterSDK.Services.Textinput.TextInputConfiguration configuration)
        {


            TextInputConnection connection = TextInputConnection._(client);
            _Instance._Attach(connection, configuration);
            return connection;
        }




        /// <Summary>
        /// This method actually notifies the embedding of the client. It is utilized
        /// by [attach] and by [_handleTextInputInvocation] for the
        /// `TextInputClient.requestExistingInputState` method.
        /// </Summary>
        private void _Attach(FlutterSDK.Services.Textinput.TextInputConnection connection, FlutterSDK.Services.Textinput.TextInputConfiguration configuration)
        {




            _Channel.InvokeMethod("TextInput.setClient", new List<object>() { connection._Id, configuration.ToJson() });
            _CurrentConnection = connection;
            _CurrentConfiguration = configuration;
        }




        private bool _DebugEnsureInputActionWorksOnPlatform(FlutterSDK.Services.Textinput.TextInputAction inputAction)
        {

            return true;
        }




        private async Future<object> _HandleTextInputInvocation(FlutterSDK.Services.Messagecodec.MethodCall methodCall)
        {
            if (_CurrentConnection == null) return;
            string method = methodCall.Method;
            if (method == "TextInputClient.requestExistingInputState")
            {

                _Attach(_CurrentConnection, _CurrentConfiguration);
                TextEditingValue editingValue = _CurrentConnection._Client.CurrentTextEditingValue;
                if (editingValue != null)
                {
                    _SetEditingState(editingValue);
                }

                return;
            }

            List<object> args = methodCall.Arguments as List<object>;
            int client = args[0] as int;
            if (client != _CurrentConnection._Id) return;
            switch (method) { case "TextInputClient.updateEditingState": _CurrentConnection._Client.UpdateEditingValue(TextEditingValue.FromJSON(args[1] as Dictionary<string, object>)); break; case "TextInputClient.performAction": _CurrentConnection._Client.PerformAction(TextinputDefaultClass._ToTextInputAction(args[1] as string)); break; case "TextInputClient.updateFloatingCursor": _CurrentConnection._Client.UpdateFloatingCursor(TextinputDefaultClass._ToTextPoint(TextinputDefaultClass._ToTextCursorAction(args[1] as string), args[2] as Dictionary<string, object>)); break; case "TextInputClient.onConnectionClosed": _CurrentConnection._Client.ConnectionClosed(); break; default: throw new MissingPluginException(); }
        }




        private void _ScheduleHide()
        {
            if (_HidePending) return;
            _HidePending = true;
            Dart.AsyncDefaultClass.ScheduleMicrotask(() =>
            {
                _HidePending = false;
                if (_CurrentConnection == null) _Channel.InvokeMethod("TextInput.hide");
            }
            );
        }




        private void _ClearClient()
        {
            _Channel.InvokeMethod("TextInput.clearClient");
            _CurrentConnection = null;
            _ScheduleHide();
        }




        private void _SetEditingState(FlutterSDK.Services.Textinput.TextEditingValue value)
        {

            _Channel.InvokeMethod("TextInput.setEditingState", value.ToJSON());
        }




        private void _Show()
        {
            _Channel.InvokeMethod("TextInput.show");
        }




        private void _SetEditableSizeAndTransform(Dictionary<string, object> args)
        {
            _Channel.InvokeMethod("TextInput.setEditableSizeAndTransform", args);
        }




        private void _SetStyle(Dictionary<string, object> args)
        {
            _Channel.InvokeMethod("TextInput.setStyle", args);
        }



    }


    /// <Summary>
    /// Indicates how to handle the intelligent replacement of dashes in text input.
    ///
    /// See also:
    ///
    ///  * [TextField.smartDashesType]
    ///  * [TextFormField.smartDashesType]
    ///  * [CupertinoTextField.smartDashesType]
    ///  * [EditableText.smartDashesType]
    ///  * [SmartQuotesType]
    ///  * <https://developer.apple.com/documentation/uikit/uitextinputtraits>
    /// </Summary>
    public enum SmartDashesType
    {

        /// <Summary>
        /// Smart dashes is disabled.
        ///
        /// This corresponds to the
        /// ["no" value of UITextSmartDashesType](https://developer.apple.com/documentation/uikit/uitextsmartdashestype/no).
        /// </Summary>
        Disabled,
        /// <Summary>
        /// Smart dashes is enabled.
        ///
        /// This corresponds to the
        /// ["yes" value of UITextSmartDashesType](https://developer.apple.com/documentation/uikit/uitextsmartdashestype/yes).
        /// </Summary>
        Enabled,
    }


    /// <Summary>
    /// Indicates how to handle the intelligent replacement of quotes in text input.
    ///
    /// See also:
    ///
    ///  * [TextField.smartQuotesType]
    ///  * [TextFormField.smartQuotesType]
    ///  * [CupertinoTextField.smartQuotesType]
    ///  * [EditableText.smartQuotesType]
    ///  * [SmartDashesType]
    ///  * <https://developer.apple.com/documentation/uikit/uitextinputtraits>
    /// </Summary>
    public enum SmartQuotesType
    {

        /// <Summary>
        /// Smart quotes is disabled.
        ///
        /// This corresponds to the
        /// ["no" value of UITextSmartQuotesType](https://developer.apple.com/documentation/uikit/uitextsmartquotestype/no).
        /// </Summary>
        Disabled,
        /// <Summary>
        /// Smart quotes is enabled.
        ///
        /// This corresponds to the
        /// ["yes" value of UITextSmartQuotesType](https://developer.apple.com/documentation/uikit/uitextsmartquotestype/yes).
        /// </Summary>
        Enabled,
    }


    /// <Summary>
    /// An action the user has requested the text input control to perform.
    ///
    /// Each action represents a logical meaning, and also configures the soft
    /// keyboard to display a certain kind of action button. The visual appearance
    /// of the action button might differ between versions of the same OS.
    ///
    /// Despite the logical meaning of each action, choosing a particular
    /// [TextInputAction] does not necessarily cause any specific behavior to
    /// happen. It is up to the developer to ensure that the behavior that occurs
    /// when an action button is pressed is appropriate for the action button chosen.
    ///
    /// For example: If the user presses the keyboard action button on iOS when it
    /// reads "Emergency Call", the result should not be a focus change to the next
    /// TextField. This behavior is not logically appropriate for a button that says
    /// "Emergency Call".
    ///
    /// See [EditableText] for more information about customizing action button
    /// behavior.
    ///
    /// Most [TextInputAction]s are supported equally by both Android and iOS.
    /// However, there is not a complete, direct mapping between Android's IME input
    /// types and iOS's keyboard return types. Therefore, some [TextInputAction]s
    /// are inappropriate for one of the platforms. If a developer chooses an
    /// inappropriate [TextInputAction] when running in debug mode, an error will be
    /// thrown. If the same thing is done in release mode, then instead of sending
    /// the inappropriate value, Android will use "unspecified" on the platform
    /// side and iOS will use "default" on the platform side.
    ///
    /// See also:
    ///
    ///  * [TextInput], which configures the platform's keyboard setup.
    ///  * [EditableText], which invokes callbacks when the action button is pressed.
    /// </Summary>
    public enum TextInputAction
    {

        /// <Summary>
        /// Logical meaning: There is no relevant input action for the current input
        /// source, e.g., [TextField].
        ///
        /// Android: Corresponds to Android's "IME_ACTION_NONE". The keyboard setup
        /// is decided by the OS. The keyboard will likely show a return key.
        ///
        /// iOS: iOS does not have a keyboard return type of "none." It is
        /// inappropriate to choose this [TextInputAction] when running on iOS.
        /// </Summary>
        None,
        /// <Summary>
        /// Logical meaning: Let the OS decide which action is most appropriate.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_UNSPECIFIED". The OS chooses
        /// which keyboard action to display. The decision will likely be a done
        /// button or a return key.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyDefault". The title displayed in
        /// the action button is "return".
        /// </Summary>
        Unspecified,
        /// <Summary>
        /// Logical meaning: The user is done providing input to a group of inputs
        /// (like a form). Some kind of finalization behavior should now take place.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_DONE". The OS displays a
        /// button that represents completion, e.g., a checkmark button.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyDone". The title displayed in the
        /// action button is "Done".
        /// </Summary>
        Done,
        /// <Summary>
        /// Logical meaning: The user has entered some text that represents a
        /// destination, e.g., a restaurant name. The "go" button is intended to take
        /// the user to a part of the app that corresponds to this destination.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_GO". The OS displays a
        /// button that represents taking "the user to the target of the text they
        /// typed", e.g., a right-facing arrow button.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyGo". The title displayed in the
        /// action button is "Go".
        /// </Summary>
        Go,
        /// <Summary>
        /// Logical meaning: Execute a search query.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_SEARCH". The OS displays a
        /// button that represents a search, e.g., a magnifying glass button.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeySearch". The title displayed in the
        /// action button is "Search".
        /// </Summary>
        Search,
        /// <Summary>
        /// Logical meaning: Sends something that the user has composed, e.g., an
        /// email or a text message.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_SEND". The OS displays a
        /// button that represents sending something, e.g., a paper plane button.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeySend". The title displayed in the
        /// action button is "Send".
        /// </Summary>
        Send,
        /// <Summary>
        /// Logical meaning: The user is done with the current input source and wants
        /// to move to the next one.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_NEXT". The OS displays a
        /// button that represents moving forward, e.g., a right-facing arrow button.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyNext". The title displayed in the
        /// action button is "Next".
        /// </Summary>
        Next,
        /// <Summary>
        /// Logical meaning: The user wishes to return to the previous input source
        /// in the group, e.g., a form with multiple [TextField]s.
        ///
        /// Android: Corresponds to Android's "IME_ACTION_PREVIOUS". The OS displays a
        /// button that represents moving backward, e.g., a left-facing arrow button.
        ///
        /// iOS: iOS does not have a keyboard return type of "previous." It is
        /// inappropriate to choose this [TextInputAction] when running on iOS.
        /// </Summary>
        Previous,
        /// <Summary>
        /// Logical meaning: In iOS apps, it is common for a "Back" button and
        /// "Continue" button to appear at the top of the screen. However, when the
        /// keyboard is open, these buttons are often hidden off-screen. Therefore,
        /// the purpose of the "Continue" return key on iOS is to make the "Continue"
        /// button available when the user is entering text.
        ///
        /// Historical context aside, [TextInputAction.continueAction] can be used any
        /// time that the term "Continue" seems most appropriate for the given action.
        ///
        /// Android: Android does not have an IME input type of "continue." It is
        /// inappropriate to choose this [TextInputAction] when running on Android.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyContinue". The title displayed in the
        /// action button is "Continue". This action is only available on iOS 9.0+.
        ///
        /// The reason that this value has "Action" post-fixed to it is because
        /// "continue" is a reserved word in Dart, as well as many other languages.
        /// </Summary>
        ContinueAction,
        /// <Summary>
        /// Logical meaning: The user wants to join something, e.g., a wireless
        /// network.
        ///
        /// Android: Android does not have an IME input type of "join." It is
        /// inappropriate to choose this [TextInputAction] when running on Android.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyJoin". The title displayed in the
        /// action button is "Join".
        /// </Summary>
        Join,
        /// <Summary>
        /// Logical meaning: The user wants routing options, e.g., driving directions.
        ///
        /// Android: Android does not have an IME input type of "route." It is
        /// inappropriate to choose this [TextInputAction] when running on Android.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyRoute". The title displayed in the
        /// action button is "Route".
        /// </Summary>
        Route,
        /// <Summary>
        /// Logical meaning: Initiate a call to emergency services.
        ///
        /// Android: Android does not have an IME input type of "emergencyCall." It is
        /// inappropriate to choose this [TextInputAction] when running on Android.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyEmergencyCall". The title displayed
        /// in the action button is "Emergency Call".
        /// </Summary>
        EmergencyCall,
        /// <Summary>
        /// Logical meaning: Insert a newline character in the focused text input,
        /// e.g., [TextField].
        ///
        /// Android: Corresponds to Android's "IME_ACTION_NONE". The OS displays a
        /// button that represents a new line, e.g., a carriage return button.
        ///
        /// iOS: Corresponds to iOS's "UIReturnKeyDefault". The title displayed in the
        /// action button is "return".
        ///
        /// The term [TextInputAction.newline] exists in Flutter but not in Android
        /// or iOS. The reason for introducing this term is so that developers can
        /// achieve the common result of inserting new lines without needing to
        /// understand the various IME actions on Android and return keys on iOS.
        /// Thus, [TextInputAction.newline] is a convenience term that alleviates the
        /// need to understand the underlying platforms to achieve this common behavior.
        /// </Summary>
        Newline,
    }


    /// <Summary>
    /// Configures how the platform keyboard will select an uppercase or
    /// lowercase keyboard.
    ///
    /// Only supports text keyboards, other keyboard types will ignore this
    /// configuration. Capitalization is locale-aware.
    /// </Summary>
    public enum TextCapitalization
    {

        /// <Summary>
        /// Defaults to an uppercase keyboard for the first letter of each word.
        ///
        /// Corresponds to `InputType.TYPE_TEXT_FLAG_CAP_WORDS` on Android, and
        /// `UITextAutocapitalizationTypeWords` on iOS.
        /// </Summary>
        Words,
        /// <Summary>
        /// Defaults to an uppercase keyboard for the first letter of each sentence.
        ///
        /// Corresponds to `InputType.TYPE_TEXT_FLAG_CAP_SENTENCES` on Android, and
        /// `UITextAutocapitalizationTypeSentences` on iOS.
        /// </Summary>
        Sentences,
        /// <Summary>
        /// Defaults to an uppercase keyboard for each character.
        ///
        /// Corresponds to `InputType.TYPE_TEXT_FLAG_CAP_CHARACTERS` on Android, and
        /// `UITextAutocapitalizationTypeAllCharacters` on iOS.
        /// </Summary>
        Characters,
        /// <Summary>
        /// Defaults to a lowercase keyboard.
        /// </Summary>
        None,
    }


    /// <Summary>
    /// A floating cursor state the user has induced by force pressing an iOS
    /// keyboard.
    /// </Summary>
    public enum FloatingCursorDragState
    {

        /// <Summary>
        /// A user has just activated a floating cursor.
        /// </Summary>
        Start,
        /// <Summary>
        /// A user is dragging a floating cursor.
        /// </Summary>
        Update,
        /// <Summary>
        /// A user has lifted their finger off the screen after using a floating
        /// cursor.
        /// </Summary>
        End,
    }

}
