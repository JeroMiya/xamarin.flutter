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
namespace FlutterSDK.Rendering.Platformview
{
    public delegate void _HandlePointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event);
    public delegate Offset _GlobalToLocal(FlutterBinding.UI.Offset point);
    internal static class PlatformviewDefaultClass
    {
        internal static bool _FactoryTypesSetEquals<T>(HashSet<FlutterSDK.Foundation.Basictypes.Factory<T>> a, HashSet<FlutterSDK.Foundation.Basictypes.Factory<T>> b)
        {
            throw new NotImplementedException();
        }

        internal static HashSet<Type> _FactoriesTypeSet<T>(HashSet<FlutterSDK.Foundation.Basictypes.Factory<T>> factories)
        {
            throw new NotImplementedException();
        }

    }

    public interface I_PlatformViewGestureMixin { }

    public class _PlatformViewGestureMixin
    {
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        internal virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation _HoverAnnotation { get; set; }
        internal virtual FlutterSDK.Rendering.Platformview._HandlePointerEvent _HandlePointerEvent { get; set; }
        internal virtual FlutterSDK.Rendering.Platformview._PlatformViewGestureRecognizer _GestureRecognizer { get; set; }

        private void _UpdateGestureRecognizersWithCallBack(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers, FlutterSDK.Rendering.Platformview._HandlePointerEvent handlePointerEvent) { throw new NotImplementedException(); }


        public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new bool HitTestSelf(FlutterBinding.UI.Offset position) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }

    }
    public static class _PlatformViewGestureMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<I_PlatformViewGestureMixin, _PlatformViewGestureMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_PlatformViewGestureMixin, _PlatformViewGestureMixin>();
        static _PlatformViewGestureMixin GetOrCreate(I_PlatformViewGestureMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new _PlatformViewGestureMixin();
                _table.Add(instance, value);
            }
            return (_PlatformViewGestureMixin)value;
        }
        public static FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehaviorProperty(this I_PlatformViewGestureMixin instance) => GetOrCreate(instance).HitTestBehavior;
        public static bool HitTest(this I_PlatformViewGestureMixin instance, FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => GetOrCreate(instance).HitTest(result, position);
        public static bool HitTestSelf(this I_PlatformViewGestureMixin instance, FlutterBinding.UI.Offset position) => GetOrCreate(instance).HitTestSelf(position);
        public static void HandleEvent(this I_PlatformViewGestureMixin instance, FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry) => GetOrCreate(instance).HandleEvent(@event, entry);
        public static void Attach(this I_PlatformViewGestureMixin instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach(this I_PlatformViewGestureMixin instance) => GetOrCreate(instance).Detach();
    }


    public class RenderAndroidView : FlutterSDK.Rendering.Box.RenderBox, I_PlatformViewGestureMixin
    {
        #region constructors
        public RenderAndroidView(FlutterSDK.Services.Platformviews.AndroidViewController viewController = default(FlutterSDK.Services.Platformviews.AndroidViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Platformview._PlatformViewState _State { get; set; }
        internal virtual FlutterSDK.Services.Platformviews.AndroidViewController _ViewController { get; set; }
        internal virtual FlutterSDK.Rendering.Platformview._MotionEventsDispatcher _MotionEventsDispatcher { get; set; }
        internal virtual Size _CurrentAndroidViewSize { get; set; }
        public virtual FlutterSDK.Services.Platformviews.AndroidViewController Viewcontroller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Platformviews.AndroidViewController ViewController { set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _OnPlatformViewCreated(int id) { throw new NotImplementedException(); }


        public virtual void UpdateGestureRecognizers(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers) { throw new NotImplementedException(); }


        public new void PerformResize() { throw new NotImplementedException(); }


        private Future<object> _SizePlatformView() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _PaintTexture(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }

        #endregion
    }


    public class RenderUiKitView : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public RenderUiKitView(FlutterSDK.Services.Platformviews.UiKitViewController viewController = default(FlutterSDK.Services.Platformviews.UiKitViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base()
        {
            this.HitTestBehavior = hitTestBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Services.Platformviews.UiKitViewController _ViewController { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        internal virtual FlutterSDK.Rendering.Platformview._UiKitViewGestureRecognizer _GestureRecognizer { get; set; }
        internal virtual FlutterSDK.Gestures.Events.PointerEvent _LastPointerDownEvent { get; set; }
        public virtual FlutterSDK.Services.Platformviews.UiKitViewController ViewController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void UpdateGestureRecognizers(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers) { throw new NotImplementedException(); }


        public new void PerformResize() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new bool HitTestSelf(FlutterBinding.UI.Offset position) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry) { throw new NotImplementedException(); }


        private void _HandleGlobalPointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }

        #endregion
    }


    public class _UiKitViewGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
    {
        #region constructors
        public _UiKitViewGestureRecognizer(FlutterSDK.Services.Platformviews.UiKitViewController controller, HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizerFactories, PointerDeviceKind kind = default(PointerDeviceKind))
        : base(kind: kind)
        {
            this.Controller = controller;
            this.GestureRecognizerFactories = gestureRecognizerFactories; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizerFactories { get; set; }
        internal virtual HashSet<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer> _GestureRecognizers { get; set; }
        public virtual FlutterSDK.Services.Platformviews.UiKitViewController Controller { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event) { throw new NotImplementedException(); }


        public new void DidStopTrackingLastPointer(int pointer) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AcceptGesture(int pointer) { throw new NotImplementedException(); }


        public new void RejectGesture(int pointer) { throw new NotImplementedException(); }


        public virtual void Reset() { throw new NotImplementedException(); }

        #endregion
    }


    public class _PlatformViewGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
    {
        #region constructors
        public _PlatformViewGestureRecognizer(FlutterSDK.Rendering.Platformview._HandlePointerEvent handlePointerEvent, HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizerFactories, PointerDeviceKind kind = default(PointerDeviceKind))
        : base(kind: kind)
        {
            this.GestureRecognizerFactories = gestureRecognizerFactories; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Platformview._HandlePointerEvent _HandlePointerEvent { get; set; }
        public virtual Dictionary<int, List<FlutterSDK.Gestures.Events.PointerEvent>> CachedEvents { get; set; }
        public virtual HashSet<int> ForwardedPointers { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizerFactories { get; set; }
        internal virtual HashSet<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer> _GestureRecognizers { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event) { throw new NotImplementedException(); }


        public new void DidStopTrackingLastPointer(int pointer) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AcceptGesture(int pointer) { throw new NotImplementedException(); }


        public new void RejectGesture(int pointer) { throw new NotImplementedException(); }


        private void _CacheEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        private void _FlushPointerCache(int pointer) { throw new NotImplementedException(); }


        public new void StopTrackingPointer(int pointer) { throw new NotImplementedException(); }


        public virtual void Reset() { throw new NotImplementedException(); }

        #endregion
    }


    public class _MotionEventsDispatcher
    {
        #region constructors
        public _MotionEventsDispatcher(FlutterSDK.Rendering.Platformview._GlobalToLocal globalToLocal, FlutterSDK.Services.Platformviews.AndroidViewController viewController)
        {
            this.GlobalToLocal = globalToLocal;
            this.ViewController = viewController; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<int, FlutterSDK.Services.Platformviews.AndroidPointerCoords> PointerPositions { get; set; }
        public virtual Dictionary<int, FlutterSDK.Services.Platformviews.AndroidPointerProperties> PointerProperties { get; set; }
        public virtual FlutterSDK.Rendering.Platformview._GlobalToLocal GlobalToLocal { get; set; }
        public virtual FlutterSDK.Services.Platformviews.AndroidViewController ViewController { get; set; }
        public virtual int NextPointerId { get; set; }
        public virtual int DownTimeMillis { get; set; }
        #endregion

        #region methods

        public virtual void HandlePointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public virtual void DispatchPointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Services.Platformviews.AndroidPointerCoords CoordsFor(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Services.Platformviews.AndroidPointerProperties PropertiesFor(FlutterSDK.Gestures.Events.PointerEvent @event, int pointerId) { throw new NotImplementedException(); }


        public virtual bool IsSinglePointerAction(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }

        #endregion
    }


    public class PlatformViewRenderBox : FlutterSDK.Rendering.Box.RenderBox, I_PlatformViewGestureMixin
    {
        #region constructors
        public PlatformViewRenderBox(FlutterSDK.Services.Platformviews.PlatformViewController controller = default(FlutterSDK.Services.Platformviews.PlatformViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Services.Platformviews.PlatformViewController _Controller { get; set; }
        public virtual FlutterSDK.Services.Platformviews.PlatformViewController Controller { set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void UpdateGestureRecognizers(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers) { throw new NotImplementedException(); }


        public new void PerformResize() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }

        #endregion
    }


    public enum PlatformViewHitTestBehavior
    {

        Opaque,
        Translucent,
        Transparent,
    }


    public enum _PlatformViewState
    {

        Uninitialized,
        Resizing,
        Ready,
    }

}
