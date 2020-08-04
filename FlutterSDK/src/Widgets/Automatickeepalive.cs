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
namespace FlutterSDK.Widgets.Automatickeepalive
{
    internal static class AutomatickeepaliveDefaultClass
    {
    }

    public interface IAutomaticKeepAliveClientMixin<T> { }

    public class AutomaticKeepAliveClientMixin<T>
    {
        internal virtual FlutterSDK.Widgets.Automatickeepalive.KeepAliveHandle _KeepAliveHandle { get; set; }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _EnsureKeepAlive()
        {

            _KeepAliveHandle = new KeepAliveHandle();
            new KeepAliveNotification(_KeepAliveHandle).Dispatch(Context);
        }




        private void _ReleaseKeepAlive()
        {
            _KeepAliveHandle.Release();
            _KeepAliveHandle = null;
        }




        /// <Summary>
        /// Ensures that any [AutomaticKeepAlive] ancestors are in a good state, by
        /// firing a [KeepAliveNotification] or triggering the [KeepAliveHandle] as
        /// appropriate.
        /// </Summary>
        public virtual void UpdateKeepAlive()
        {
            if (WantKeepAlive)
            {
                if (_KeepAliveHandle == null) _EnsureKeepAlive();
            }
            else
            {
                if (_KeepAliveHandle != null) _ReleaseKeepAlive();
            }

        }




        public new void InitState()
        {
            base.InitState();
            if (WantKeepAlive) _EnsureKeepAlive();
        }




        public new void Deactivate()
        {
            if (_KeepAliveHandle != null) _ReleaseKeepAlive();
            base.Deactivate();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (WantKeepAlive && _KeepAliveHandle == null) _EnsureKeepAlive();
            return null;
        }



    }
    public static class AutomaticKeepAliveClientMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static AutomaticKeepAliveClientMixin<T> GetOrCreate<T>(IAutomaticKeepAliveClientMixin<T> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new AutomaticKeepAliveClientMixin<T>();
                _table.Add(instance, value);
            }
            return (AutomaticKeepAliveClientMixin<T>)value;
        }
        public static bool WantKeepAliveProperty<T>(this IAutomaticKeepAliveClientMixin<T> instance) => GetOrCreate(instance).WantKeepAlive;
        public static void UpdateKeepAlive<T>(this IAutomaticKeepAliveClientMixin<T> instance) => GetOrCreate(instance).UpdateKeepAlive();
        public static void InitState<T>(this IAutomaticKeepAliveClientMixin<T> instance) => GetOrCreate(instance).InitState();
        public static void Deactivate<T>(this IAutomaticKeepAliveClientMixin<T> instance) => GetOrCreate(instance).Deactivate();
        public static FlutterSDK.Widgets.Framework.Widget Build<T>(this IAutomaticKeepAliveClientMixin<T> instance, FlutterSDK.Widgets.Framework.BuildContext context) => GetOrCreate(instance).Build(context);
    }


    /// <Summary>
    /// Allows subtrees to request to be kept alive in lazy lists.
    ///
    /// This widget is like [KeepAlive] but instead of being explicitly configured,
    /// it listens to [KeepAliveNotification] messages from the [child] and other
    /// descendants.
    ///
    /// The subtree is kept alive whenever there is one or more descendant that has
    /// sent a [KeepAliveNotification] and not yet triggered its
    /// [KeepAliveNotification.handle].
    ///
    /// To send these notifications, consider using [AutomaticKeepAliveClientMixin].
    /// </Summary>
    public class AutomaticKeepAlive : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that listens to [KeepAliveNotification]s and maintains a
        /// [KeepAlive] widget appropriately.
        /// </Summary>
        public AutomaticKeepAlive(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Automatickeepalive._AutomaticKeepAliveState CreateState() => new _AutomaticKeepAliveState();


    }


    public class _AutomaticKeepAliveState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Automatickeepalive.AutomaticKeepAlive>
    {
        public _AutomaticKeepAliveState()
        { }
        internal virtual Dictionary<FlutterSDK.Foundation.Changenotifier.Listenable, object> _Handles { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Child { get; set; }
        internal virtual bool _KeepingAlive { get; set; }

        public new void InitState()
        {
            base.InitState();
            _UpdateChild();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Automatickeepalive.AutomaticKeepAlive oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            _UpdateChild();
        }




        private void _UpdateChild()
        {
            _Child = new NotificationListener<KeepAliveNotification>(onNotification: _AddClient, child: Widget.Child);
        }




        public new void Dispose()
        {
            if (_Handles != null)
            {
                foreach (Listenable handle in _Handles.Keys) handle.RemoveListener(_Handles[handle]);
            }

            base.Dispose();
        }




        private bool _AddClient(FlutterSDK.Widgets.Automatickeepalive.KeepAliveNotification notification)
        {
            Listenable handle = notification.Handle;
            _Handles = (_Handles == null ? new Dictionary<Listenable, VoidCallback> { } : _Handles);

            _Handles[handle] = _CreateCallback(handle);
            handle.AddListener(_Handles[handle]);
            if (!_KeepingAlive)
            {
                _KeepingAlive = true;
                ParentDataElement<KeepAliveParentDataMixin> childElement = _GetChildElement();
                if (childElement != null)
                {
                    _UpdateParentDataOfChild(childElement);
                }
                else
                {
                    BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timeStamp) =>
                    {
                        if (!Mounted)
                        {
                            return;
                        }

                        ParentDataElement<KeepAliveParentDataMixin> childElement = _GetChildElement();

                        _UpdateParentDataOfChild(childElement);
                    }
                    );
                }

            }

            return false;
        }




        /// <Summary>
        /// Get the [Element] for the only [KeepAlive] child.
        ///
        /// While this widget is guaranteed to have a child, this may return null if
        /// the first build of that child has not completed yet.
        /// </Summary>
        private FlutterSDK.Widgets.Framework.ParentDataElement<FlutterSDK.Rendering.Slivermultiboxadaptor.KeepAliveParentDataMixin> _GetChildElement()
        {

            Element element = Context as Element;
            Element childElement = default(Element);
            element.VisitChildren((Element child) =>
            {
                childElement = child;
            }
            );

            return childElement as ParentDataElement<KeepAliveParentDataMixin>;
        }




        private void _UpdateParentDataOfChild(FlutterSDK.Widgets.Framework.ParentDataElement<FlutterSDK.Rendering.Slivermultiboxadaptor.KeepAliveParentDataMixin> childElement)
        {
            childElement.ApplyWidgetOutOfTurn(Build(Context) as ParentDataWidget<KeepAliveParentDataMixin>);
        }




        private VoidCallback _CreateCallback(FlutterSDK.Foundation.Changenotifier.Listenable handle)
        {
            return () =>
            {

                _Handles.Remove(handle);
                if (_Handles.IsEmpty())
                {
                    if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase.Index < SchedulerPhase.PersistentCallbacks.Index)
                    {
                        SetState(() =>
                        {
                            _KeepingAlive = false;
                        }
                        );
                    }
                    else
                    {
                        _KeepingAlive = false;
                        Dart.AsyncDefaultClass.ScheduleMicrotask(() =>
                        {
                            if (Mounted && _Handles.IsEmpty())
                            {
                                SetState(() =>
                                {

                                }
                                );
                            }

                        }
                        );
                    }

                }

            }
            ;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return new KeepAlive(keepAlive: _KeepingAlive, child: _Child);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
        {
            base.DebugFillProperties(description);
            description.Add(new FlagProperty("_keepingAlive", value: _KeepingAlive, ifTrue: "keeping subtree alive"));
            description.Add(new DiagnosticsProperty<Dictionary<Listenable, VoidCallback>>("handles", _Handles, description: _Handles != null ? $"'{_Handles.Length} active client{_Handles.Length == 1 ? "":'s'}'" : null, ifNull: "no notifications ever received"));
        }



    }


    /// <Summary>
    /// Indicates that the subtree through which this notification bubbles must be
    /// kept alive even if it would normally be discarded as an optimization.
    ///
    /// For example, a focused text field might fire this notification to indicate
    /// that it should not be disposed even if the user scrolls the field off
    /// screen.
    ///
    /// Each [KeepAliveNotification] is configured with a [handle] that consists of
    /// a [Listenable] that is triggered when the subtree no longer needs to be kept
    /// alive.
    ///
    /// The [handle] should be triggered any time the sending widget is removed from
    /// the tree (in [State.deactivate]). If the widget is then rebuilt and still
    /// needs to be kept alive, it should immediately send a new notification
    /// (possible with the very same [Listenable]) during build.
    ///
    /// This notification is listened to by the [AutomaticKeepAlive] widget, which
    /// is added to the tree automatically by [SliverList] (and [ListView]) and
    /// [SliverGrid] (and [GridView]) widgets.
    ///
    /// Failure to trigger the [handle] in the manner described above will likely
    /// cause the [AutomaticKeepAlive] to lose track of whether the widget should be
    /// kept alive or not, leading to memory leaks or lost data. For example, if the
    /// widget that requested keepalive is removed from the subtree but doesn't
    /// trigger its [Listenable] on the way out, then the subtree will continue to
    /// be kept alive until the list itself is disposed. Similarly, if the
    /// [Listenable] is triggered while the widget needs to be kept alive, but a new
    /// [KeepAliveNotification] is not immediately sent, then the widget risks being
    /// garbage collected while it wants to be kept alive.
    ///
    /// It is an error to use the same [handle] in two [KeepAliveNotification]s
    /// within the same [AutomaticKeepAlive] without triggering that [handle] before
    /// the second notification is sent.
    ///
    /// For a more convenient way to interact with [AutomaticKeepAlive] widgets,
    /// consider using [AutomaticKeepAliveClientMixin], which uses
    /// [KeepAliveNotification] internally.
    /// </Summary>
    public class KeepAliveNotification : FlutterSDK.Widgets.Notificationlistener.Notification
    {
        /// <Summary>
        /// Creates a notification to indicate that a subtree must be kept alive.
        ///
        /// The [handle] must not be null.
        /// </Summary>
        public KeepAliveNotification(FlutterSDK.Foundation.Changenotifier.Listenable handle)
        : base()
        {
            this.Handle = handle;
        }
        /// <Summary>
        /// A [Listenable] that will inform its clients when the widget that fired the
        /// notification no longer needs to be kept alive.
        ///
        /// The [Listenable] should be triggered any time the sending widget is
        /// removed from the tree (in [State.deactivate]). If the widget is then
        /// rebuilt and still needs to be kept alive, it should immediately send a new
        /// notification (possible with the very same [Listenable]) during build.
        ///
        /// See also:
        ///
        ///  * [KeepAliveHandle], a convenience class for use with this property.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Changenotifier.Listenable Handle { get; set; }
    }


    /// <Summary>
    /// A [Listenable] which can be manually triggered.
    ///
    /// Used with [KeepAliveNotification] objects as their
    /// [KeepAliveNotification.handle].
    ///
    /// For a more convenient way to interact with [AutomaticKeepAlive] widgets,
    /// consider using [AutomaticKeepAliveClientMixin], which uses a
    /// [KeepAliveHandle] internally.
    /// </Summary>
    public class KeepAliveHandle : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        public KeepAliveHandle()
        { }

        /// <Summary>
        /// Trigger the listeners to indicate that the widget
        /// no longer needs to be kept alive.
        /// </Summary>
        public virtual void Release()
        {
            NotifyListeners();
        }



    }

}
