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
namespace FlutterSDK.Widgets.Dismissible
{
    /// <Summary>
    /// Signature used by [Dismissible] to indicate that it has been dismissed in
    /// the given `direction`.
    ///
    /// Used by [Dismissible.onDismissed].
    /// </Summary>
    public delegate void DismissDirectionCallback(FlutterSDK.Widgets.Dismissible.DismissDirection direction);
    /// <Summary>
    /// Signature used by [Dismissible] to give the application an opportunity to
    /// confirm or veto a dismiss gesture.
    ///
    /// Used by [Dismissible.confirmDismiss].
    /// </Summary>
    public delegate Future<bool> ConfirmDismissCallback(FlutterSDK.Widgets.Dismissible.DismissDirection direction);
    internal static class DismissibleDefaultClass
    {
        public static FlutterSDK.Animation.Curves.Curve _KResizeTimeCurve = default(FlutterSDK.Animation.Curves.Curve);
        public static double _KMinFlingVelocity = default(double);
        public static double _KMinFlingVelocityDelta = default(double);
        public static double _KFlingVelocityScale = default(double);
        public static double _KDismissThreshold = default(double);
    }

    /// <Summary>
    /// A widget that can be dismissed by dragging in the indicated [direction].
    ///
    /// Dragging or flinging this widget in the [DismissDirection] causes the child
    /// to slide out of view. Following the slide animation, if [resizeDuration] is
    /// non-null, the Dismissible widget animates its height (or width, whichever is
    /// perpendicular to the dismiss direction) to zero over the [resizeDuration].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=iEMgjrfuc58}
    ///
    /// Backgrounds can be used to implement the "leave-behind" idiom. If a background
    /// is specified it is stacked behind the Dismissible's child and is exposed when
    /// the child moves.
    ///
    /// The widget calls the [onDismissed] callback either after its size has
    /// collapsed to zero (if [resizeDuration] is non-null) or immediately after
    /// the slide animation (if [resizeDuration] is null). If the Dismissible is a
    /// list item, it must have a key that distinguishes it from the other items and
    /// its [onDismissed] callback must remove the item from the list.
    /// </Summary>
    public class Dismissible : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that can be dismissed.
        ///
        /// The [key] argument must not be null because [Dismissible]s are commonly
        /// used in lists and removed from the list when dismissed. Without keys, the
        /// default behavior is to sync widgets based on their index in the list,
        /// which means the item after the dismissed item would be synced with the
        /// state of the dismissed item. Using keys causes the widgets to sync
        /// according to their keys and avoids this pitfall.
        /// </Summary>
        public Dismissible(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget background = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget secondaryBackground = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Dismissible.ConfirmDismissCallback confirmDismiss = default(FlutterSDK.Widgets.Dismissible.ConfirmDismissCallback), VoidCallback onResize = default(VoidCallback), FlutterSDK.Widgets.Dismissible.DismissDirectionCallback onDismissed = default(FlutterSDK.Widgets.Dismissible.DismissDirectionCallback), FlutterSDK.Widgets.Dismissible.DismissDirection direction = default(FlutterSDK.Widgets.Dismissible.DismissDirection), TimeSpan resizeDuration = default(TimeSpan), Dictionary<FlutterSDK.Widgets.Dismissible.DismissDirection, double> dismissThresholds = default(Dictionary<FlutterSDK.Widgets.Dismissible.DismissDirection, double>), TimeSpan movementDuration = default(TimeSpan), double crossAxisEndOffset = 0.0, FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Child = child;
            this.Background = background;
            this.SecondaryBackground = secondaryBackground;
            this.ConfirmDismiss = confirmDismiss;
            this.OnResize = onResize;
            this.OnDismissed = onDismissed;
            this.Direction = direction;
            this.ResizeDuration = resizeDuration;
            this.DismissThresholds = dismissThresholds;
            this.MovementDuration = movementDuration;
            this.CrossAxisEndOffset = crossAxisEndOffset;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// A widget that is stacked behind the child. If secondaryBackground is also
        /// specified then this widget only appears when the child has been dragged
        /// down or to the right.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Background { get; set; }
        /// <Summary>
        /// A widget that is stacked behind the child and is exposed when the child
        /// has been dragged up or to the left. It may only be specified when background
        /// has also been specified.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget SecondaryBackground { get; set; }
        /// <Summary>
        /// Gives the app an opportunity to confirm or veto a pending dismissal.
        ///
        /// If the returned Future<bool> completes true, then this widget will be
        /// dismissed, otherwise it will be moved back to its original location.
        ///
        /// If the returned Future<bool> completes to false or null the [onResize]
        /// and [onDismissed] callbacks will not run.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Dismissible.ConfirmDismissCallback ConfirmDismiss { get; set; }
        /// <Summary>
        /// Called when the widget changes size (i.e., when contracting before being dismissed).
        /// </Summary>
        public virtual VoidCallback OnResize { get; set; }
        /// <Summary>
        /// Called when the widget has been dismissed, after finishing resizing.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Dismissible.DismissDirectionCallback OnDismissed { get; set; }
        /// <Summary>
        /// The direction in which the widget can be dismissed.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Dismissible.DismissDirection Direction { get; set; }
        /// <Summary>
        /// The amount of time the widget will spend contracting before [onDismissed] is called.
        ///
        /// If null, the widget will not contract and [onDismissed] will be called
        /// immediately after the widget is dismissed.
        /// </Summary>
        public virtual TimeSpan ResizeDuration { get; set; }
        /// <Summary>
        /// The offset threshold the item has to be dragged in order to be considered
        /// dismissed.
        ///
        /// Represented as a fraction, e.g. if it is 0.4 (the default), then the item
        /// has to be dragged at least 40% towards one direction to be considered
        /// dismissed. Clients can define different thresholds for each dismiss
        /// direction.
        ///
        /// Flinging is treated as being equivalent to dragging almost to 1.0, so
        /// flinging can dismiss an item past any threshold less than 1.0.
        ///
        /// Setting a threshold of 1.0 (or greater) prevents a drag in the given
        /// [DismissDirection] even if it would be allowed by the [direction]
        /// property.
        ///
        /// See also:
        ///
        ///  * [direction], which controls the directions in which the items can
        ///    be dismissed.
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Widgets.Dismissible.DismissDirection, double> DismissThresholds { get; set; }
        /// <Summary>
        /// Defines the duration for card to dismiss or to come back to original position if not dismissed.
        /// </Summary>
        public virtual TimeSpan MovementDuration { get; set; }
        /// <Summary>
        /// Defines the end offset across the main axis after the card is dismissed.
        ///
        /// If non-zero value is given then widget moves in cross direction depending on whether
        /// it is positive or negative.
        /// </Summary>
        public virtual double CrossAxisEndOffset { get; set; }
        /// <Summary>
        /// Determines the way that drag start behavior is handled.
        ///
        /// If set to [DragStartBehavior.start], the drag gesture used to dismiss a
        /// dismissible will begin upon the detection of a drag gesture. If set to
        /// [DragStartBehavior.down] it will begin when a down event is first detected.
        ///
        /// In general, setting this to [DragStartBehavior.start] will make drag
        /// animation smoother and setting it to [DragStartBehavior.down] will make
        /// drag behavior feel slightly more reactive.
        ///
        /// By default, the drag start behavior is [DragStartBehavior.start].
        ///
        /// See also:
        ///
        ///  * [DragGestureRecognizer.dragStartBehavior], which gives an example for the different behaviors.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        public new FlutterSDK.Widgets.Dismissible._DismissibleState CreateState() => new _DismissibleState();


    }


    public class _DismissibleClipper : FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>
    {
        public _DismissibleClipper(FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Animation.Animation.Animation<Offset> moveAnimation = default(FlutterSDK.Animation.Animation.Animation<Offset>))
        : base(reclip: moveAnimation)
        {
            this.Axis = axis;
            this.MoveAnimation = moveAnimation;
        }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<Offset> MoveAnimation { get; set; }

        public new Rect GetClip(Size size)
        {

            switch (Axis) { case Axis.Horizontal: double offset = MoveAnimation.Value.Dx * size.Width; if (offset < 0) return Rect.FromLTRB(size.Width + offset, 0.0, size.Width, size.Height); return Rect.FromLTRB(0.0, 0.0, offset, size.Height); case Axis.Vertical: double offset = MoveAnimation.Value.Dy * size.Height; if (offset < 0) return Rect.FromLTRB(0.0, size.Height + offset, size.Width, size.Height); return Rect.FromLTRB(0.0, 0.0, size.Width, offset); }
            return null;
        }




        public new Rect GetApproximateClipRect(Size size) => GetClip(size);



        public new bool ShouldReclip(FlutterSDK.Widgets.Dismissible._DismissibleClipper oldClipper)
        {
            return oldClipper.Axis != Axis || oldClipper.MoveAnimation.Value != MoveAnimation.Value;
        }



    }


    public class _DismissibleState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Dismissible.Dismissible>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>, IAutomaticKeepAliveClientMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _DismissibleState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _MoveController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _MoveAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ResizeController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ResizeAnimation { get; set; }
        internal virtual double _DragExtent { get; set; }
        internal virtual bool _DragUnderway { get; set; }
        internal virtual Size _SizePriorToCollapse { get; set; }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DirectionIsXAxis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Dismissible.DismissDirection _DismissDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsActive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _OverallDragAxisExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _MoveController = new AnimationController(duration: Widget.MovementDuration, vsync: this);
            new AnimationController(duration: Widget.MovementDuration, vsync: this).AddStatusListener(_HandleDismissStatusChanged);
            _UpdateMoveAnimation();
        }




        public new void Dispose()
        {
            _MoveController.Dispose();
            _ResizeController?.Dispose();
            base.Dispose();
        }




        private FlutterSDK.Widgets.Dismissible.DismissDirection _ExtentToDirection(double extent)
        {
            if (extent == 0.0) return null;
            if (_DirectionIsXAxis)
            {
                switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: return extent < 0 ? DismissDirection.StartToEnd : DismissDirection.EndToStart; case TextDirection.Ltr: return extent > 0 ? DismissDirection.StartToEnd : DismissDirection.EndToStart; }

                return null;
            }

            return extent > 0 ? DismissDirection.Down : DismissDirection.Up;
        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {
            _DragUnderway = true;
            if (_MoveController.IsAnimating)
            {
                _DragExtent = _MoveController.Value * _OverallDragAxisExtent * _DragExtent.Sign;
                _MoveController.Stop();
            }
            else
            {
                _DragExtent = 0.0;
                _MoveController.Value = 0.0;
            }

            SetState(() =>
            {
                _UpdateMoveAnimation();
            }
            );
        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            if (!_IsActive || _MoveController.IsAnimating) return;
            double delta = details.PrimaryDelta;
            double oldDragExtent = _DragExtent;
            switch (Widget.Direction) { case DismissDirection.Horizontal: case DismissDirection.Vertical: _DragExtent += delta; break; case DismissDirection.Up: if (_DragExtent + delta < 0) _DragExtent += delta; break; case DismissDirection.Down: if (_DragExtent + delta > 0) _DragExtent += delta; break; case DismissDirection.EndToStart: switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: if (_DragExtent + delta > 0) _DragExtent += delta; break; case TextDirection.Ltr: if (_DragExtent + delta < 0) _DragExtent += delta; break; } break; case DismissDirection.StartToEnd: switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: if (_DragExtent + delta < 0) _DragExtent += delta; break; case TextDirection.Ltr: if (_DragExtent + delta > 0) _DragExtent += delta; break; } break; }
            if (oldDragExtent.Sign != _DragExtent.Sign)
            {
                SetState(() =>
                {
                    _UpdateMoveAnimation();
                }
                );
            }

            if (!_MoveController.IsAnimating)
            {
                _MoveController.Value = _DragExtent.Abs() / _OverallDragAxisExtent;
            }

        }




        private void _UpdateMoveAnimation()
        {
            double end = _DragExtent.Sign;
            _MoveAnimation = _MoveController.Drive(new Tween<Offset>(begin: Dart.UI.UiDefaultClass.Offset.Zero, end: _DirectionIsXAxis ? new Offset(end, Widget.CrossAxisEndOffset) : new Offset(Widget.CrossAxisEndOffset, end)));
        }




        private FlutterSDK.Widgets.Dismissible._FlingGestureKind _DescribeFlingGesture(FlutterSDK.Gestures.Velocitytracker.Velocity velocity)
        {

            if (_DragExtent == 0.0)
            {
                return _FlingGestureKind.None;
            }

            double vx = velocity.PixelsPerSecond.Dx;
            double vy = velocity.PixelsPerSecond.Dy;
            DismissDirection flingDirection = default(DismissDirection);
            if (_DirectionIsXAxis)
            {
                if (vx.Abs() - vy.Abs() < DismissibleDefaultClass._KMinFlingVelocityDelta || vx.Abs() < DismissibleDefaultClass._KMinFlingVelocity) return _FlingGestureKind.None;

                flingDirection = _ExtentToDirection(vx);
            }
            else
            {
                if (vy.Abs() - vx.Abs() < DismissibleDefaultClass._KMinFlingVelocityDelta || vy.Abs() < DismissibleDefaultClass._KMinFlingVelocity) return _FlingGestureKind.None;

                flingDirection = _ExtentToDirection(vy);
            }


            if (flingDirection == _DismissDirection) return _FlingGestureKind.Forward;
            return _FlingGestureKind.Reverse;
        }




        private async Future<object> _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            if (!_IsActive || _MoveController.IsAnimating) return;
            _DragUnderway = false;
            if (_MoveController.IsCompleted && await _ConfirmStartResizeAnimation() == true)
            {
                _StartResizeAnimation();
                return;
            }

            double flingVelocity = _DirectionIsXAxis ? details.Velocity.PixelsPerSecond.Dx : details.Velocity.PixelsPerSecond.Dy;
            switch (_DescribeFlingGesture(details.Velocity))
            {
                case _FlingGestureKind.Forward:
                    if ((Widget.DismissThresholds[_DismissDirection] ?? DismissibleDefaultClass._KDismissThreshold) >= 1.0)
                    {
                        _MoveController.Reverse();
                        break;
                    }
                    _DragExtent = flingVelocity.Sign; _MoveController.Fling(velocity: flingVelocity.Abs() * DismissibleDefaultClass._KFlingVelocityScale); break;
                case _FlingGestureKind.Reverse: _DragExtent = flingVelocity.Sign; _MoveController.Fling(velocity: -flingVelocity.Abs() * DismissibleDefaultClass._KFlingVelocityScale); break;
                case _FlingGestureKind.None:
                    if (!_MoveController.IsDismissed)
                    {
                        if (_MoveController.Value > (Widget.DismissThresholds[_DismissDirection] ?? DismissibleDefaultClass._KDismissThreshold))
                        {
                            _MoveController.Forward();
                        }
                        else
                        {
                            _MoveController.Reverse();
                        }

                    }
                    break;
            }
        }




        private async Future<object> _HandleDismissStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Completed && !_DragUnderway)
            {
                if (await _ConfirmStartResizeAnimation() == true) _StartResizeAnimation(); else _MoveController.Reverse();
            }

            UpdateKeepAlive();
        }




        private async Future<bool> _ConfirmStartResizeAnimation()
        {
            if (Widget.ConfirmDismiss != null)
            {
                DismissDirection direction = _DismissDirection;

                return Widget.ConfirmDismiss(direction);
            }

            return true;
        }




        private void _StartResizeAnimation()
        {




            if (Widget.ResizeDuration == null)
            {
                if (Widget.OnDismissed != null)
                {
                    DismissDirection direction = _DismissDirection;

                    Widget.OnDismissed(direction);
                }

            }
            else
            {
                _ResizeController = new AnimationController(duration: Widget.ResizeDuration, vsync: this);
                new AnimationController(duration: Widget.ResizeDuration, vsync: this).AddListener(_HandleResizeProgressChanged);
                new AnimationController(duration: Widget.ResizeDuration, vsync: this).AddStatusListener((AnimationStatus status) => =>UpdateKeepAlive());
                _ResizeController.Forward();
                SetState(() =>
                {
                    _SizePriorToCollapse = Context.Size;
                    _ResizeAnimation = _ResizeController.Drive(new CurveTween(curve: DismissibleDefaultClass._KResizeTimeCurve)).Drive(new Tween<double>(begin: 1.0, end: 0.0));
                }
                );
            }

        }




        private void _HandleResizeProgressChanged()
        {
            if (_ResizeController.IsCompleted)
            {
                if (Widget.OnDismissed != null)
                {
                    DismissDirection direction = _DismissDirection;

                    Widget.OnDismissed(direction);
                }

            }
            else
            {
                if (Widget.OnResize != null) Widget.OnResize();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            base.Build(context);

            Widget background = Widget.Background;
            if (Widget.SecondaryBackground != null)
            {
                DismissDirection direction = _DismissDirection;
                if (direction == DismissDirection.EndToStart || direction == DismissDirection.Up) background = Widget.SecondaryBackground;
            }

            if (_ResizeAnimation != null)
            {

                return new SizeTransition(sizeFactor: _ResizeAnimation, axis: _DirectionIsXAxis ? Axis.Vertical : Axis.Horizontal, child: new SizedBox(width: _SizePriorToCollapse.Width, height: _SizePriorToCollapse.Height, child: background));
            }

            Widget content = new SlideTransition(position: _MoveAnimation, child: Widget.Child);
            if (background != null)
            {
                content = new Stack(children: new List<Widget>() { });
            }

            return new GestureDetector(onHorizontalDragStart: _DirectionIsXAxis ? _HandleDragStart : null, onHorizontalDragUpdate: _DirectionIsXAxis ? _HandleDragUpdate : null, onHorizontalDragEnd: _DirectionIsXAxis ? _HandleDragEnd : null, onVerticalDragStart: _DirectionIsXAxis ? null : _HandleDragStart, onVerticalDragUpdate: _DirectionIsXAxis ? null : _HandleDragUpdate, onVerticalDragEnd: _DirectionIsXAxis ? null : _HandleDragEnd, behavior: HitTestBehavior.Opaque, child: content, dragStartBehavior: Widget.DragStartBehavior);
        }



    }


    /// <Summary>
    /// The direction in which a [Dismissible] can be dismissed.
    /// </Summary>
    public enum DismissDirection
    {

        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging either up or down.
        /// </Summary>
        Vertical,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging either left or right.
        /// </Summary>
        Horizontal,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging in the reverse of the
        /// reading direction (e.g., from right to left in left-to-right languages).
        /// </Summary>
        EndToStart,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging in the reading direction
        /// (e.g., from left to right in left-to-right languages).
        /// </Summary>
        StartToEnd,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging up only.
        /// </Summary>
        Up,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging down only.
        /// </Summary>
        Down,
    }


    public enum _FlingGestureKind
    {

        None,
        Forward,
        Reverse,
    }

}
