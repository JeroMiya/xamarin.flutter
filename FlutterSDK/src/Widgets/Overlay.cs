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
namespace FlutterSDK.Widgets.Overlay
{
    internal static class OverlayDefaultClass
    {
    }

    /// <Summary>
    /// A place in an [Overlay] that can contain a widget.
    ///
    /// Overlay entries are inserted into an [Overlay] using the
    /// [OverlayState.insert] or [OverlayState.insertAll] functions. To find the
    /// closest enclosing overlay for a given [BuildContext], use the [Overlay.of]
    /// function.
    ///
    /// An overlay entry can be in at most one overlay at a time. To remove an entry
    /// from its overlay, call the [remove] function on the overlay entry.
    ///
    /// Because an [Overlay] uses a [Stack] layout, overlay entries can use
    /// [Positioned] and [AnimatedPositioned] to position themselves within the
    /// overlay.
    ///
    /// For example, [Draggable] uses an [OverlayEntry] to show the drag avatar that
    /// follows the user's finger across the screen after the drag begins. Using the
    /// overlay to display the drag avatar lets the avatar float over the other
    /// widgets in the app. As the user's finger moves, draggable calls
    /// [markNeedsBuild] on the overlay entry to cause it to rebuild. It its build,
    /// the entry includes a [Positioned] with its top and left property set to
    /// position the drag avatar near the user's finger. When the drag is over,
    /// [Draggable] removes the entry from the overlay to remove the drag avatar
    /// from view.
    ///
    /// By default, if there is an entirely [opaque] entry over this one, then this
    /// one will not be included in the widget tree (in particular, stateful widgets
    /// within the overlay entry will not be instantiated). To ensure that your
    /// overlay entry is still built even if it is not visible, set [maintainState]
    /// to true. This is more expensive, so should be done with care. In particular,
    /// if widgets in an overlay entry with [maintainState] set to true repeatedly
    /// call [State.setState], the user's battery will be drained unnecessarily.
    ///
    /// See also:
    ///
    ///  * [Overlay]
    ///  * [OverlayState]
    ///  * [WidgetsApp]
    ///  * [MaterialApp]
    /// </Summary>
    public class OverlayEntry
    {
        public OverlayEntry(FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool opaque = false, bool maintainState = false)
        : base()
        {
            this.Builder = builder;
        }
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
        internal virtual bool _Opaque { get; set; }
        internal virtual bool _MaintainState { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayState _Overlay { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Overlay._OverlayEntryWidgetState> _Key { get; set; }
        public virtual bool Opaque { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool MaintainState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Remove this entry from the overlay.
        ///
        /// This should only be called once.
        ///
        /// If this method is called while the [SchedulerBinding.schedulerPhase] is
        /// [SchedulerPhase.persistentCallbacks], i.e. during the build, layout, or
        /// paint phases (see [WidgetsBinding.drawFrame]), then the removal is
        /// delayed until the post-frame callbacks phase. Otherwise the removal is
        /// done synchronously. This means that it is safe to call during builds, but
        /// also that if you do call this during a build, the UI will not update until
        /// the next frame (i.e. many milliseconds later).
        /// </Summary>
        public virtual void Remove()
        {

            OverlayState overlay = _Overlay;
            _Overlay = null;
            if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase == SchedulerPhase.PersistentCallbacks)
            {
                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan duration) =>
                {
                    overlay._Remove(this);
                }
                );
            }
            else
            {
                overlay._Remove(this);
            }

        }




        /// <Summary>
        /// Cause this entry to rebuild during the next pipeline flush.
        ///
        /// You need to call this function if the output of [builder] has changed.
        /// </Summary>
        public virtual void MarkNeedsBuild()
        {
            _Key.CurrentState?._MarkNeedsBuild();
        }




    }


    public class _OverlayEntryWidget : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _OverlayEntryWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Overlay.OverlayEntry entry = default(FlutterSDK.Widgets.Overlay.OverlayEntry), bool tickerEnabled = true)
        : base(key: key)
        {
            this.Entry = entry;
            this.TickerEnabled = tickerEnabled;
        }
        public virtual FlutterSDK.Widgets.Overlay.OverlayEntry Entry { get; set; }
        public virtual bool TickerEnabled { get; set; }

        public new FlutterSDK.Widgets.Overlay._OverlayEntryWidgetState CreateState() => new _OverlayEntryWidgetState();


    }


    public class _OverlayEntryWidgetState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Overlay._OverlayEntryWidget>
    {
        public _OverlayEntryWidgetState()
        { }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new TickerMode(enabled: Widget.TickerEnabled, child: Widget.Entry.Builder(context));
        }




        private void _MarkNeedsBuild()
        {
            SetState(() =>
            {
            }
            );
        }



    }


    /// <Summary>
    /// A [Stack] of entries that can be managed independently.
    ///
    /// Overlays let independent child widgets "float" visual elements on top of
    /// other widgets by inserting them into the overlay's [Stack]. The overlay lets
    /// each of these widgets manage their participation in the overlay using
    /// [OverlayEntry] objects.
    ///
    /// Although you can create an [Overlay] directly, it's most common to use the
    /// overlay created by the [Navigator] in a [WidgetsApp] or a [MaterialApp]. The
    /// navigator uses its overlay to manage the visual appearance of its routes.
    ///
    /// See also:
    ///
    ///  * [OverlayEntry].
    ///  * [OverlayState].
    ///  * [WidgetsApp].
    ///  * [MaterialApp].
    /// </Summary>
    public class Overlay : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public Overlay(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Overlay.OverlayEntry> initialEntries = default(List<FlutterSDK.Widgets.Overlay.OverlayEntry>))
        : base(key: key)
        {
            this.InitialEntries = initialEntries;
        }
        public virtual List<FlutterSDK.Widgets.Overlay.OverlayEntry> InitialEntries { get; set; }

        /// <Summary>
        /// The state from the closest instance of this class that encloses the given context.
        ///
        /// In debug mode, if the `debugRequiredFor` argument is provided then this
        /// function will assert that an overlay was found and will throw an exception
        /// if not. The exception attempts to explain that the calling [Widget] (the
        /// one given by the `debugRequiredFor` argument) needs an [Overlay] to be
        /// present to function.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// OverlayState overlay = Overlay.of(context);
        /// ```
        ///
        /// If `rootOverlay` is set to true, the state from the furthest instance of
        /// this class is given instead. Useful for installing overlay entries
        /// above all subsequent instances of [Overlay].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Overlay.OverlayState Of(FlutterSDK.Widgets.Framework.BuildContext context, bool rootOverlay = false, FlutterSDK.Widgets.Framework.Widget debugRequiredFor = default(FlutterSDK.Widgets.Framework.Widget))
        {
            OverlayState result = rootOverlay ? context.FindRootAncestorStateOfType() : context.FindAncestorStateOfType();

            return result;
        }




        public new FlutterSDK.Widgets.Overlay.OverlayState CreateState() => new OverlayState();


    }


    /// <Summary>
    /// The current state of an [Overlay].
    ///
    /// Used to insert [OverlayEntry]s into the overlay using the [insert] and
    /// [insertAll] functions.
    /// </Summary>
    public class OverlayState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Overlay.Overlay>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public OverlayState()
        { }
        internal virtual List<FlutterSDK.Widgets.Overlay.OverlayEntry> _Entries { get; set; }

        public new void InitState()
        {
            base.InitState();
            InsertAll(Widget.InitialEntries);
        }




        private int _InsertionIndex(FlutterSDK.Widgets.Overlay.OverlayEntry below, FlutterSDK.Widgets.Overlay.OverlayEntry above)
        {

            if (below != null) return _Entries.IndexOf(below);
            if (above != null) return _Entries.IndexOf(above) + 1;
            return _Entries.Count;
        }




        /// <Summary>
        /// Insert the given entry into the overlay.
        ///
        /// If `below` is non-null, the entry is inserted just below `below`.
        /// If `above` is non-null, the entry is inserted just above `above`.
        /// Otherwise, the entry is inserted on top.
        ///
        /// It is an error to specify both `above` and `below`.
        /// </Summary>
        public virtual void Insert(FlutterSDK.Widgets.Overlay.OverlayEntry entry, FlutterSDK.Widgets.Overlay.OverlayEntry below = default(FlutterSDK.Widgets.Overlay.OverlayEntry), FlutterSDK.Widgets.Overlay.OverlayEntry above = default(FlutterSDK.Widgets.Overlay.OverlayEntry))
        {





            entry._Overlay = this;
            SetState(() =>
            {
                _Entries.Insert(_InsertionIndex(below, above), entry);
            }
            );
        }




        /// <Summary>
        /// Insert all the entries in the given iterable.
        ///
        /// If `below` is non-null, the entries are inserted just below `below`.
        /// If `above` is non-null, the entries are inserted just above `above`.
        /// Otherwise, the entries are inserted on top.
        ///
        /// It is an error to specify both `above` and `below`.
        /// </Summary>
        public virtual void InsertAll(Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> entries, FlutterSDK.Widgets.Overlay.OverlayEntry below = default(FlutterSDK.Widgets.Overlay.OverlayEntry), FlutterSDK.Widgets.Overlay.OverlayEntry above = default(FlutterSDK.Widgets.Overlay.OverlayEntry))
        {





            if (entries.IsEmpty()) return;
            foreach (OverlayEntry entry in entries)
            {

                entry._Overlay = this;
            }

            SetState(() =>
            {
                _Entries.InsertAll(_InsertionIndex(below, above), entries);
            }
            );
        }




        /// <Summary>
        /// Remove all the entries listed in the given iterable, then reinsert them
        /// into the overlay in the given order.
        ///
        /// Entries mention in `newEntries` but absent from the overlay are inserted
        /// as if with [insertAll].
        ///
        /// Entries not mentioned in `newEntries` but present in the overlay are
        /// positioned as a group in the resulting list relative to the entries that
        /// were moved, as specified by one of `below` or `above`, which, if
        /// specified, must be one of the entries in `newEntries`:
        ///
        /// If `below` is non-null, the group is positioned just below `below`.
        /// If `above` is non-null, the group is positioned just above `above`.
        /// Otherwise, the group is left on top, with all the rearranged entries
        /// below.
        ///
        /// It is an error to specify both `above` and `below`.
        /// </Summary>
        public virtual void Rearrange(Iterable<FlutterSDK.Widgets.Overlay.OverlayEntry> newEntries, FlutterSDK.Widgets.Overlay.OverlayEntry below = default(FlutterSDK.Widgets.Overlay.OverlayEntry), FlutterSDK.Widgets.Overlay.OverlayEntry above = default(FlutterSDK.Widgets.Overlay.OverlayEntry))
        {
            List<OverlayEntry> newEntriesList = newEntries is List<OverlayEntry> ? newEntries : newEntries.ToList(growable: false);





            if (newEntriesList.IsEmpty()) return;
            if (CollectionsDefaultClass.ListEquals(_Entries, newEntriesList)) return;
            LinkedHashSet<OverlayEntry> old = LinkedHashSet<OverlayEntry>.From(_Entries);
            foreach (OverlayEntry entry in newEntriesList)
            {
                entry._Overlay = (entry._Overlay == null ? this : entry._Overlay);
            }

            SetState(() =>
            {
                _Entries.Clear();
                _Entries.AddAll(newEntriesList);
                old.RemoveAll(newEntriesList);
                _Entries.InsertAll(_InsertionIndex(below, above), old);
            }
            );
        }




        private void _Remove(FlutterSDK.Widgets.Overlay.OverlayEntry entry)
        {
            if (Mounted)
            {
                SetState(() =>
                {
                    _Entries.Remove(entry);
                }
                );
            }

        }




        /// <Summary>
        /// (DEBUG ONLY) Check whether a given entry is visible (i.e., not behind an
        /// opaque entry).
        ///
        /// This is an O(N) algorithm, and should not be necessary except for debug
        /// asserts. To avoid people depending on it, this function is implemented
        /// only in debug mode, and always returns false in release mode.
        /// </Summary>
        public virtual bool DebugIsVisible(FlutterSDK.Widgets.Overlay.OverlayEntry entry)
        {
            bool result = false;


            return result;
        }




        private void _DidChangeEntryOpacity()
        {
            SetState(() =>
            {
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> children = new List<Widget>() { };
            bool onstage = true;
            int onstageCount = 0;
            for (int i = _Entries.Count - 1; i >= 0; i -= 1)
            {
                OverlayEntry entry = _Entries[i];
                if (onstage)
                {
                    onstageCount += 1;
                    children.Add(new _OverlayEntryWidget(key: entry._Key, entry: entry));
                    if (entry.Opaque) onstage = false;
                }
                else if (entry.MaintainState)
                {
                    children.Add(new _OverlayEntryWidget(key: entry._Key, entry: entry, tickerEnabled: false));
                }

            }

            return new _Theatre(skipCount: children.Count - onstageCount, children: children.Reversed.ToList(growable: false));
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<List<OverlayEntry>>("entries", _Entries));
        }



    }


    /// <Summary>
    /// Special version of a [Stack], that doesn't layout and render the first
    /// [skipCount] children.
    ///
    /// The first [skipCount] children are considered "offstage".
    /// </Summary>
    public class _Theatre : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        public _Theatre(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int skipCount = 0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.SkipCount = skipCount;
        }
        public virtual int SkipCount { get; set; }

        public new FlutterSDK.Widgets.Overlay._TheatreElement CreateElement() => new _TheatreElement(this);



        public new FlutterSDK.Widgets.Overlay._RenderTheatre CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderTheatre(skipCount: SkipCount, textDirection: BasicDefaultClass.Directionality.Of(context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Overlay._RenderTheatre renderObject)
        {
            ..SkipCount = SkipCount..TextDirection = BasicDefaultClass.Directionality.Of(context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..SkipCount = SkipCount..TextDirection = BasicDefaultClass.Directionality.Of(context);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new IntProperty("skipCount", SkipCount));
        }



    }


    public class _TheatreElement : FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement
    {
        public _TheatreElement(FlutterSDK.Widgets.Overlay._Theatre widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Overlay._Theatre Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Overlay._RenderTheatre RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {

            Children.Skip(Widget.SkipCount).ForEach(visitor);
        }



    }


    public class _RenderTheatre : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Stack.StackParentData>
    {
        public _RenderTheatre(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), TextDirection textDirection = default(TextDirection), int skipCount = 0)
        : base()
        {

            AddAll(children);
        }


        internal virtual bool _HasVisualOverflow { get; set; }
        internal virtual FlutterSDK.Painting.Alignment.Alignment _ResolvedAlignment { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual int _SkipCount { get; set; }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int SkipCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _FirstOnstageChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _LastOnstageChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual int _OnstageChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is StackParentData)) child.ParentData = new StackParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is StackParentData)) child.ParentData = new StackParentData();
        }




        private void _Resolve()
        {
            if (_ResolvedAlignment != null) return;
            _ResolvedAlignment = AlignmentDefaultClass.AlignmentDirectional.TopStart.Resolve(TextDirection);
        }




        private void _MarkNeedResolution()
        {
            _ResolvedAlignment = null;
            MarkNeedsLayout();
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return StackDefaultClass.RenderStack.GetIntrinsicDimension(_FirstOnstageChild, (RenderBox child) => =>child.GetMinIntrinsicWidth(height));
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return StackDefaultClass.RenderStack.GetIntrinsicDimension(_FirstOnstageChild, (RenderBox child) => =>child.GetMaxIntrinsicWidth(height));
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            return StackDefaultClass.RenderStack.GetIntrinsicDimension(_FirstOnstageChild, (RenderBox child) => =>child.GetMinIntrinsicHeight(width));
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return StackDefaultClass.RenderStack.GetIntrinsicDimension(_FirstOnstageChild, (RenderBox child) => =>child.GetMaxIntrinsicHeight(width));
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {

            double result = default(double);
            RenderBox child = _FirstOnstageChild;
            while (child != null)
            {

                StackParentData childParentData = child.ParentData as StackParentData;
                double candidate = child.GetDistanceToActualBaseline(baseline);
                if (candidate != null)
                {
                    candidate += childParentData.Offset.Dy;
                    if (result != null)
                    {
                        result = Math.Dart:mathDefaultClass.Min(result, candidate);
                    }
                    else
                    {
                        result = candidate;
                    }

                }

                child = childParentData.NextSibling;
            }

            return result;
        }




        public new void PerformResize()
        {
            Size = Constraints.Biggest;

        }




        public new void PerformLayout()
        {
            _HasVisualOverflow = false;
            if (_OnstageChildCount == 0)
            {
                return;
            }

            _Resolve();

            BoxConstraints nonPositionedConstraints = BoxConstraints.Tight(Constraints.Biggest);
            RenderBox child = _FirstOnstageChild;
            while (child != null)
            {
                StackParentData childParentData = child.ParentData as StackParentData;
                if (!childParentData.IsPositioned)
                {
                    child.Layout(nonPositionedConstraints, parentUsesSize: true);
                    childParentData.Offset = _ResolvedAlignment.AlongOffset(Size - child.Size as Offset);
                }
                else
                {
                    _HasVisualOverflow = StackDefaultClass.RenderStack.LayoutPositionedChild(child, childParentData, Size, _ResolvedAlignment) || _HasVisualOverflow;
                }


                child = childParentData.NextSibling;
            }

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            RenderBox child = _LastOnstageChild;
            for (int i = 0; i < _OnstageChildCount; i++)
            {

                StackParentData childParentData = child.ParentData as StackParentData;
                bool isHit = result.AddWithPaintOffset(offset: childParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
                {

                    return child.HitTest(result, position: transformed);
                }
                );
                if (isHit) return true;
                child = childParentData.PreviousSibling;
            }

            return false;
        }




        public virtual void PaintStack(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            RenderBox child = _FirstOnstageChild;
            while (child != null)
            {
                StackParentData childParentData = child.ParentData as StackParentData;
                context.PaintChild(child, childParentData.Offset + offset);
                child = childParentData.NextSibling;
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (_HasVisualOverflow)
            {
                context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, PaintStack);
            }
            else
            {
                PaintStack(context, offset);
            }

        }




        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            RenderBox child = _FirstOnstageChild;
            while (child != null)
            {
                visitor(child);
                StackParentData childParentData = child.ParentData as StackParentData;
                child = childParentData.NextSibling;
            }

        }




        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) => _HasVisualOverflow ? Dart : uiDefaultClass.Offset.Zero & Size:null ;



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new IntProperty("skipCount", SkipCount));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection));
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> offstageChildren = new List<DiagnosticsNode>() { };
            List<DiagnosticsNode> onstageChildren = new List<DiagnosticsNode>() { };
            int count = 1;
            bool onstage = false;
            RenderBox child = FirstChild;
            RenderBox firstOnstageChild = _FirstOnstageChild;
            while (child != null)
            {
                if (child == firstOnstageChild)
                {
                    onstage = true;
                    count = 1;
                }

                if (onstage)
                {
                    onstageChildren.Add(child.ToDiagnosticsNode(name: $"'onstage {count}'"));
                }
                else
                {
                    offstageChildren.Add(child.ToDiagnosticsNode(name: $"'offstage {count}'", style: DiagnosticsTreeStyle.Offstage));
                }

                StackParentData childParentData = child.ParentData as StackParentData;
                child = childParentData.NextSibling;
                count += 1;
            }

            return new List<DiagnosticsNode>() { /* ...onstageChildren, */ };
        }



    }

}
