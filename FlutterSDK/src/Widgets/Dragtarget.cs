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
namespace FlutterSDK.Widgets.Dragtarget
{
    public delegate bool DragTargetWillAccept<T>(T data);
    public delegate void DragTargetAccept<T>(T data);
    public delegate FlutterSDK.Widgets.Framework.Widget DragTargetBuilder<T>(FlutterSDK.Widgets.Framework.BuildContext context, List<T> candidateData, List<object> rejectedData);
    public delegate void DraggableCanceledCallback(FlutterSDK.Gestures.Velocitytracker.Velocity velocity, FlutterBinding.UI.Offset offset);
    public delegate void DragEndCallback(FlutterSDK.Widgets.Dragtarget.DraggableDetails details);
    public delegate void DragTargetLeave(@Object data);
    public delegate void _OnDragEnd(FlutterSDK.Gestures.Velocitytracker.Velocity velocity, FlutterBinding.UI.Offset offset, bool wasAccepted);
    internal static class DragtargetDefaultClass
    {
        internal static List<T> _MapAvatarsToData<T>(List<FlutterSDK.Widgets.Dragtarget._DragAvatar<T>> avatars)
        {
            return avatars.Map((_DragAvatar<T> avatar) => =>avatar.Data).ToList();
        }



    }

    /// <Summary>
    /// A widget that can be dragged from to a [DragTarget].
    ///
    /// When a draggable widget recognizes the start of a drag gesture, it displays
    /// a [feedback] widget that tracks the user's finger across the screen. If the
    /// user lifts their finger while on top of a [DragTarget], that target is given
    /// the opportunity to accept the [data] carried by the draggable.
    ///
    /// On multitouch devices, multiple drags can occur simultaneously because there
    /// can be multiple pointers in contact with the device at once. To limit the
    /// number of simultaneous drags, use the [maxSimultaneousDrags] property. The
    /// default is to allow an unlimited number of simultaneous drags.
    ///
    /// This widget displays [child] when zero drags are under way. If
    /// [childWhenDragging] is non-null, this widget instead displays
    /// [childWhenDragging] when one or more drags are underway. Otherwise, this
    /// widget always displays [child].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=QzA4c4QHZCY}
    ///
    /// See also:
    ///
    ///  * [DragTarget]
    ///  * [LongPressDraggable]
    /// </Summary>
    public class Draggable<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public Draggable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget feedback = default(FlutterSDK.Widgets.Framework.Widget), T data = default(T), FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Widgets.Framework.Widget childWhenDragging = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Offset feedbackOffset = default(FlutterBinding.UI.Offset), FlutterSDK.Widgets.Dragtarget.DragAnchor dragAnchor = default(FlutterSDK.Widgets.Dragtarget.DragAnchor), FlutterSDK.Painting.Basictypes.Axis affinity = default(FlutterSDK.Painting.Basictypes.Axis), int maxSimultaneousDrags = default(int), VoidCallback onDragStarted = default(VoidCallback), FlutterSDK.Widgets.Dragtarget.DraggableCanceledCallback onDraggableCanceled = default(FlutterSDK.Widgets.Dragtarget.DraggableCanceledCallback), FlutterSDK.Widgets.Dragtarget.DragEndCallback onDragEnd = default(FlutterSDK.Widgets.Dragtarget.DragEndCallback), VoidCallback onDragCompleted = default(VoidCallback), bool ignoringFeedbackSemantics = true)
        : base(key: key)
        {
            this.Child = child;
            this.Feedback = feedback;
            this.Data = data;
            this.Axis = axis;
            this.ChildWhenDragging = childWhenDragging;
            this.FeedbackOffset = feedbackOffset;
            this.DragAnchor = dragAnchor;
            this.Affinity = affinity;
            this.MaxSimultaneousDrags = maxSimultaneousDrags;
            this.OnDragStarted = onDragStarted;
            this.OnDraggableCanceled = onDraggableCanceled;
            this.OnDragEnd = onDragEnd;
            this.OnDragCompleted = onDragCompleted;
            this.IgnoringFeedbackSemantics = ignoringFeedbackSemantics;
        }
        public virtual T Data { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget ChildWhenDragging { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Feedback { get; set; }
        public virtual FlutterBinding.UI.Offset FeedbackOffset { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget.DragAnchor DragAnchor { get; set; }
        public virtual bool IgnoringFeedbackSemantics { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Affinity { get; set; }
        public virtual int MaxSimultaneousDrags { get; set; }
        public virtual VoidCallback OnDragStarted { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget.DraggableCanceledCallback OnDraggableCanceled { get; set; }
        public virtual VoidCallback OnDragCompleted { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget.DragEndCallback OnDragEnd { get; set; }

        /// <Summary>
        /// Creates a gesture recognizer that recognizes the start of the drag.
        ///
        /// Subclasses can override this function to customize when they start
        /// recognizing a drag.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multidrag.MultiDragGestureRecognizer<FlutterSDK.Gestures.Multidrag.MultiDragPointerState> CreateRecognizer(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback onStart)
        {
            switch (Affinity) { case Axis.Horizontal: return new HorizontalMultiDragGestureRecognizer()..OnStart = onStart; case Axis.Vertical: return new VerticalMultiDragGestureRecognizer()..OnStart = onStart; }
            return new ImmediateMultiDragGestureRecognizer()..OnStart = onStart;
        }




        public new _DraggableState<T> CreateState() => new _DraggableState<T>();


    }


    /// <Summary>
    /// Makes its child draggable starting from long press.
    /// </Summary>
    public class LongPressDraggable<T> : FlutterSDK.Widgets.Dragtarget.Draggable<T>
    {
        public LongPressDraggable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget feedback = default(FlutterSDK.Widgets.Framework.Widget), T data = default(T), FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Widgets.Framework.Widget childWhenDragging = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Offset feedbackOffset = default(FlutterBinding.UI.Offset), FlutterSDK.Widgets.Dragtarget.DragAnchor dragAnchor = default(FlutterSDK.Widgets.Dragtarget.DragAnchor), int maxSimultaneousDrags = default(int), VoidCallback onDragStarted = default(VoidCallback), FlutterSDK.Widgets.Dragtarget.DraggableCanceledCallback onDraggableCanceled = default(FlutterSDK.Widgets.Dragtarget.DraggableCanceledCallback), FlutterSDK.Widgets.Dragtarget.DragEndCallback onDragEnd = default(FlutterSDK.Widgets.Dragtarget.DragEndCallback), VoidCallback onDragCompleted = default(VoidCallback), bool hapticFeedbackOnStart = true, bool ignoringFeedbackSemantics = true)
        : base(key: key, child: child, feedback: feedback, data: data, axis: axis, childWhenDragging: childWhenDragging, feedbackOffset: feedbackOffset, dragAnchor: dragAnchor, maxSimultaneousDrags: maxSimultaneousDrags, onDragStarted: onDragStarted, onDraggableCanceled: onDraggableCanceled, onDragEnd: onDragEnd, onDragCompleted: onDragCompleted, ignoringFeedbackSemantics: ignoringFeedbackSemantics)
        {
            this.HapticFeedbackOnStart = hapticFeedbackOnStart;
        }
        public virtual bool HapticFeedbackOnStart { get; set; }

        public new FlutterSDK.Gestures.Multidrag.DelayedMultiDragGestureRecognizer CreateRecognizer(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback onStart)
        {
            return new DelayedMultiDragGestureRecognizer()..OnStart = (Offset position) =>
            {
                Drag result = onStart(position);
                if (result != null && HapticFeedbackOnStart) HapticfeedbackDefaultClass.HapticFeedback.SelectionClick();
                return result;
            }
            ;
        }



    }


    public class _DraggableState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Dragtarget.Draggable<T>>
    {
        public _DraggableState()
        { }
        internal virtual FlutterSDK.Gestures.Recognizer.GestureRecognizer _Recognizer { get; set; }
        internal virtual int _ActiveCount { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Recognizer = Widget.CreateRecognizer(_StartDrag);
        }




        public new void Dispose()
        {
            _DisposeRecognizerIfInactive();
            base.Dispose();
        }




        private void _DisposeRecognizerIfInactive()
        {
            if (_ActiveCount > 0) return;
            _Recognizer.Dispose();
            _Recognizer = null;
        }




        private void _RoutePointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            if (Widget.MaxSimultaneousDrags != null && _ActiveCount >= Widget.MaxSimultaneousDrags) return;
            _Recognizer.AddPointer(@event);
        }




        private _DragAvatar<T> _StartDrag(FlutterBinding.UI.Offset position)
        {
            if (Widget.MaxSimultaneousDrags != null && _ActiveCount >= Widget.MaxSimultaneousDrags) return null;
            Offset dragStartPoint = default(Offset);
            switch (Widget.DragAnchor) { case DragAnchor.Child: RenderBox renderObject = Context.FindRenderObject() as RenderBox; dragStartPoint = renderObject.GlobalToLocal(position); break; case DragAnchor.Pointer: dragStartPoint = Dart.UiDefaultClass.Offset.Zero; break; }
            SetState(() =>
            {
                _ActiveCount += 1;
            }
            );
            _DragAvatar<T> avatar = new _DragAvatar<T>(overlayState: OverlayDefaultClass.Overlay.Of(Context, debugRequiredFor: Widget), data: Widget.Data, axis: Widget.Axis, initialPosition: position, dragStartPoint: dragStartPoint, feedback: Widget.Feedback, feedbackOffset: Widget.FeedbackOffset, ignoringFeedbackSemantics: Widget.IgnoringFeedbackSemantics, onDragEnd: (Velocity velocity, Offset offset, bool wasAccepted) =>
            {
                if (Mounted)
                {
                    SetState(() =>
                    {
                        _ActiveCount -= 1;
                    }
                    );
                }
                else
                {
                    _ActiveCount -= 1;
                    _DisposeRecognizerIfInactive();
                }

                if (Mounted && Widget.OnDragEnd != null)
                {
                    Widget.OnDragEnd(new DraggableDetails(wasAccepted: wasAccepted, velocity: velocity, offset: offset));
                }

                if (wasAccepted && Widget.OnDragCompleted != null) Widget.OnDragCompleted();
                if (!wasAccepted && Widget.OnDraggableCanceled != null) Widget.OnDraggableCanceled(velocity, offset);
            }
            );
            if (Widget.OnDragStarted != null) Widget.OnDragStarted();
            return avatar;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            bool canDrag = Widget.MaxSimultaneousDrags == null || _ActiveCount < Widget.MaxSimultaneousDrags;
            bool showChild = _ActiveCount == 0 || Widget.ChildWhenDragging == null;
            return new Listener(onPointerDown: canDrag ? _RoutePointer : null, child: showChild ? Widget.Child : Widget.ChildWhenDragging);
        }



    }


    /// <Summary>
    /// Represents the details when a specific pointer event occurred on
    /// the [Draggable].
    ///
    /// This includes the [Velocity] at which the pointer was moving and [Offset]
    /// when the draggable event occurred, and whether its [DragTarget] accepted it.
    ///
    /// Also, this is the details object for callbacks that use [DragEndCallback].
    /// </Summary>
    public class DraggableDetails
    {
        public DraggableDetails(bool wasAccepted = false, FlutterSDK.Gestures.Velocitytracker.Velocity velocity = default(FlutterSDK.Gestures.Velocitytracker.Velocity), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.WasAccepted = wasAccepted;
            this.Velocity = velocity;
            this.Offset = offset;
        }
        public virtual bool WasAccepted { get; set; }
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Velocity { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
    }


    /// <Summary>
    /// A widget that receives data when a [Draggable] widget is dropped.
    ///
    /// When a draggable is dragged on top of a drag target, the drag target is
    /// asked whether it will accept the data the draggable is carrying. If the user
    /// does drop the draggable on top of the drag target (and the drag target has
    /// indicated that it will accept the draggable's data), then the drag target is
    /// asked to accept the draggable's data.
    ///
    /// See also:
    ///
    ///  * [Draggable]
    ///  * [LongPressDraggable]
    /// </Summary>
    public class DragTarget<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public DragTarget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Dragtarget.DragTargetBuilder<T> builder = default(FlutterSDK.Widgets.Dragtarget.DragTargetBuilder<T>), FlutterSDK.Widgets.Dragtarget.DragTargetWillAccept<T> onWillAccept = default(FlutterSDK.Widgets.Dragtarget.DragTargetWillAccept<T>), FlutterSDK.Widgets.Dragtarget.DragTargetAccept<T> onAccept = default(FlutterSDK.Widgets.Dragtarget.DragTargetAccept<T>), FlutterSDK.Widgets.Dragtarget.DragTargetLeave onLeave = default(FlutterSDK.Widgets.Dragtarget.DragTargetLeave))
        : base(key: key)
        {
            this.Builder = builder;
            this.OnWillAccept = onWillAccept;
            this.OnAccept = onAccept;
            this.OnLeave = onLeave;
        }
        public virtual FlutterSDK.Widgets.Dragtarget.DragTargetBuilder<T> Builder { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget.DragTargetWillAccept<T> OnWillAccept { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget.DragTargetAccept<T> OnAccept { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget.DragTargetLeave OnLeave { get; set; }

        public new _DragTargetState<T> CreateState() => new _DragTargetState<T>();


    }


    public class _DragTargetState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Dragtarget.DragTarget<T>>
    {
        public _DragTargetState()
        { }
        internal virtual List<FlutterSDK.Widgets.Dragtarget._DragAvatar<T>> _CandidateAvatars { get; set; }
        internal virtual List<FlutterSDK.Widgets.Dragtarget._DragAvatar<@Object>> _RejectedAvatars { get; set; }

        public virtual bool DidEnter(FlutterSDK.Widgets.Dragtarget._DragAvatar<@Object> avatar)
        {


            if (avatar is _DragAvatar<T> && (Widget.OnWillAccept == null || Widget.OnWillAccept(avatar.Data)))
            {
                SetState(() =>
                {
                    _CandidateAvatars.Add(((_DragAvatar<T>)avatar));
                }
                );
                return true;
            }
            else
            {
                SetState(() =>
                {
                    _RejectedAvatars.Add(avatar);
                }
                );
                return false;
            }

        }




        public virtual void DidLeave(FlutterSDK.Widgets.Dragtarget._DragAvatar<@Object> avatar)
        {

            if (!Mounted) return;
            SetState(() =>
            {
                _CandidateAvatars.Remove(avatar);
                _RejectedAvatars.Remove(avatar);
            }
            );
            if (Widget.OnLeave != null) Widget.OnLeave(avatar.Data);
        }




        public virtual void DidDrop(FlutterSDK.Widgets.Dragtarget._DragAvatar<@Object> avatar)
        {

            if (!Mounted) return;
            SetState(() =>
            {
                _CandidateAvatars.Remove(avatar);
            }
            );
            if (Widget.OnAccept != null) Widget.OnAccept(avatar.Data as T);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return new MetaData(metaData: this, behavior: HitTestBehavior.Translucent, child: Widget.Builder(context, DragtargetDefaultClass._MapAvatarsToData(_CandidateAvatars), DragtargetDefaultClass._MapAvatarsToData(_RejectedAvatars)));
        }



    }


    public class _DragAvatar<T> : FlutterSDK.Gestures.Drag.Drag
    {
        public _DragAvatar(FlutterSDK.Widgets.Overlay.OverlayState overlayState = default(FlutterSDK.Widgets.Overlay.OverlayState), T data = default(T), FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterBinding.UI.Offset initialPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset dragStartPoint = default(FlutterBinding.UI.Offset), FlutterSDK.Widgets.Framework.Widget feedback = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Offset feedbackOffset = default(FlutterBinding.UI.Offset), FlutterSDK.Widgets.Dragtarget._OnDragEnd onDragEnd = default(FlutterSDK.Widgets.Dragtarget._OnDragEnd), bool ignoringFeedbackSemantics = default(bool))
        : base()
        {
            this.OverlayState = overlayState;
            this.Data = data;
            this.Axis = axis;
            this.DragStartPoint = dragStartPoint;
            this.Feedback = feedback;
            this.FeedbackOffset = feedbackOffset;
            this.OnDragEnd = onDragEnd;
            this.IgnoringFeedbackSemantics = ignoringFeedbackSemantics;
            _Entry = new OverlayEntry(builder: _Build);
            OverlayState.Insert(_Entry);
            _Position = initialPosition;
            UpdateDrag(initialPosition);
        }


        public virtual T Data { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get; set; }
        public virtual FlutterBinding.UI.Offset DragStartPoint { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Feedback { get; set; }
        public virtual FlutterBinding.UI.Offset FeedbackOffset { get; set; }
        public virtual FlutterSDK.Widgets.Dragtarget._OnDragEnd OnDragEnd { get; set; }
        public virtual FlutterSDK.Widgets.Overlay.OverlayState OverlayState { get; set; }
        public virtual bool IgnoringFeedbackSemantics { get; set; }
        internal virtual FlutterSDK.Widgets.Dragtarget._DragTargetState<T> _ActiveTarget { get; set; }
        internal virtual List<FlutterSDK.Widgets.Dragtarget._DragTargetState<T>> _EnteredTargets { get; set; }
        internal virtual FlutterBinding.UI.Offset _Position { get; set; }
        internal virtual FlutterBinding.UI.Offset _LastOffset { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _Entry { get; set; }

        public new void Update(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            _Position += _RestrictAxis(details.Delta);
            UpdateDrag(_Position);
        }




        public new void End(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            FinishDrag(_DragEndKind.Dropped, _RestrictVelocityAxis(details.Velocity));
        }




        public new void Cancel()
        {
            FinishDrag(_DragEndKind.Canceled);
        }




        public virtual void UpdateDrag(FlutterBinding.UI.Offset globalPosition)
        {
            _LastOffset = globalPosition - DragStartPoint;
            _Entry.MarkNeedsBuild();
            HitTestResult result = new HitTestResult();
            BindingDefaultClass.WidgetsBinding.Instance.HitTest(result, globalPosition + FeedbackOffset);
            List<_DragTargetState<T>> targets = _GetDragTargets(result.Path).ToList();
            bool listsMatch = false;
            if (targets.Count >= _EnteredTargets.Count && _EnteredTargets.IsNotEmpty)
            {
                listsMatch = true;
                Iterator<_DragTargetState<T>> iterator = targets.Iterator;
                for (int i = 0; i < _EnteredTargets.Count; i += 1)
                {
                    iterator.MoveNext();
                    if (iterator.Current != _EnteredTargets[i])
                    {
                        listsMatch = false;
                        break;
                    }

                }

            }

            if (listsMatch) return;
            _LeaveAllEntered();
            _DragTargetState<T> newTarget = targets.FirstWhere((_DragTargetState<T> target) =>
            {
                _EnteredTargets.Add(target);
                return target.DidEnter(this);
            }
            , orElse: () => =>null);
            _ActiveTarget = newTarget;
        }




        private Iterable<FlutterSDK.Widgets.Dragtarget._DragTargetState<T>> _GetDragTargets(Iterable<FlutterSDK.Gestures.Hittest.HitTestEntry> path)
        {
            foreach (HitTestEntry entry in path)
            {
                HitTestTarget target = entry.Target;
                if (target is RenderMetaData)
                {
                    object metaData = ((RenderMetaData)target).MetaData;
                    if (((_DragTargetState<T>)metaData) is _DragTargetState<T>) yield return ((_DragTargetState<T>)metaData);
                }

            }

        }




        private void _LeaveAllEntered()
        {
            for (int i = 0; i < _EnteredTargets.Count; i += 1) _EnteredTargets[i].DidLeave(this);
            _EnteredTargets.Clear();
        }




        public virtual void FinishDrag(FlutterSDK.Widgets.Dragtarget._DragEndKind endKind, FlutterSDK.Gestures.Velocitytracker.Velocity velocity = default(FlutterSDK.Gestures.Velocitytracker.Velocity))
        {
            bool wasAccepted = false;
            if (endKind == _DragEndKind.Dropped && _ActiveTarget != null)
            {
                _ActiveTarget.DidDrop(this);
                wasAccepted = true;
                _EnteredTargets.Remove(_ActiveTarget);
            }

            _LeaveAllEntered();
            _ActiveTarget = null;
            _Entry.Remove();
            _Entry = null;
            if (OnDragEnd != null) OnDragEnd(velocity ?? VelocitytrackerDefaultClass.Velocity.Zero, _LastOffset, wasAccepted);
        }




        private FlutterSDK.Widgets.Framework.Widget _Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            RenderBox box = OverlayState.Context.FindRenderObject() as RenderBox;
            Offset overlayTopLeft = box.LocalToGlobal(Dart.UI.UiDefaultClass.Offset.Zero);
            return new Positioned(left: _LastOffset.Dx - overlayTopLeft.Dx, top: _LastOffset.Dy - overlayTopLeft.Dy, child: new IgnorePointer(child: Feedback, ignoringSemantics: IgnoringFeedbackSemantics));
        }




        private FlutterSDK.Gestures.Velocitytracker.Velocity _RestrictVelocityAxis(FlutterSDK.Gestures.Velocitytracker.Velocity velocity)
        {
            if (Axis == null)
            {
                return velocity;
            }

            return new Velocity(pixelsPerSecond: _RestrictAxis(velocity.PixelsPerSecond));
        }




        private Offset _RestrictAxis(FlutterBinding.UI.Offset offset)
        {
            if (Axis == null)
            {
                return offset;
            }

            if (Axis == Axis.Horizontal)
            {
                return new Offset(offset.Dx, 0.0);
            }

            return new Offset(0.0, offset.Dy);
        }



    }


    /// <Summary>
    /// Where the [Draggable] should be anchored during a drag.
    /// </Summary>
    public enum DragAnchor
    {

        /// <Summary>
        /// Display the feedback anchored at the position of the original child. If
        /// feedback is identical to the child, then this means the feedback will
        /// exactly overlap the original child when the drag starts.
        /// </Summary>
        Child,
        /// <Summary>
        /// Display the feedback anchored at the position of the touch that started
        /// the drag. If feedback is identical to the child, then this means the top
        /// left of the feedback will be under the finger when the drag starts. This
        /// will likely not exactly overlap the original child, e.g. if the child is
        /// big and the touch was not centered. This mode is useful when the feedback
        /// is transformed so as to move the feedback to the left by half its width,
        /// and up by half its width plus the height of the finger, since then it
        /// appears as if putting the finger down makes the touch feedback appear
        /// above the finger. (It feels weird for it to appear offset from the
        /// original child if it's anchored to the child and not the finger.)
        /// </Summary>
        Pointer,
    }


    public enum _DragEndKind
    {

        Dropped,
        Canceled,
    }

}
