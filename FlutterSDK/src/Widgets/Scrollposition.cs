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
namespace FlutterSDK.Widgets.Scrollposition
{
    internal static class ScrollpositionDefaultClass
    {
    }

    /// <Summary>
    /// Determines which portion of the content is visible in a scroll view.
    ///
    /// The [pixels] value determines the scroll offset that the scroll view uses to
    /// select which part of its content to display. As the user scrolls the
    /// viewport, this value changes, which changes the content that is displayed.
    ///
    /// The [ScrollPosition] applies [physics] to scrolling, and stores the
    /// [minScrollExtent] and [maxScrollExtent].
    ///
    /// Scrolling is controlled by the current [activity], which is set by
    /// [beginActivity]. [ScrollPosition] itself does not start any activities.
    /// Instead, concrete subclasses, such as [ScrollPositionWithSingleContext],
    /// typically start activities in response to user input or instructions from a
    /// [ScrollController].
    ///
    /// This object is a [Listenable] that notifies its listeners when [pixels]
    /// changes.
    ///
    /// ## Subclassing ScrollPosition
    ///
    /// Over time, a [Scrollable] might have many different [ScrollPosition]
    /// objects. For example, if [Scrollable.physics] changes type, [Scrollable]
    /// creates a new [ScrollPosition] with the new physics. To transfer state from
    /// the old instance to the new instance, subclasses implement [absorb]. See
    /// [absorb] for more details.
    ///
    /// Subclasses also need to call [didUpdateScrollDirection] whenever
    /// [userScrollDirection] changes values.
    ///
    /// See also:
    ///
    ///  * [Scrollable], which uses a [ScrollPosition] to determine which portion of
    ///    its content to display.
    ///  * [ScrollController], which can be used with [ListView], [GridView] and
    ///    other scrollable widgets to control a [ScrollPosition].
    ///  * [ScrollPositionWithSingleContext], which is the most commonly used
    ///    concrete subclass of [ScrollPosition].
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public interface IScrollPosition
    {
        void Absorb(FlutterSDK.Widgets.Scrollposition.ScrollPosition other);
        double SetPixels(double newPixels);
        void CorrectPixels(double value);
        void CorrectBy(double correction);
        void ForcePixels(double value);
        void SaveScrollOffset();
        void RestoreScrollOffset();
        double ApplyBoundaryConditions(double value);
        bool ApplyViewportDimension(double viewportDimension);
        bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent);
        void ApplyNewDimensions();
        Future<object> EnsureVisible(FlutterSDK.Rendering.@object.RenderObject @object, double alignment = 0.0, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy alignmentPolicy = default(FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy));
        Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        void JumpTo(double value);
        Future<object> MoveTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), bool clamp = true);
        void JumpToWithoutSettling(double value);
        FlutterSDK.Widgets.Scrollactivity.ScrollHoldController Hold(VoidCallback holdCancelCallback);
        FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback);
        void BeginActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivity newActivity);
        void DidStartScroll();
        void DidUpdateScrollPositionBy(double delta);
        void DidEndScroll();
        void DidOverscrollBy(double value);
        void DidUpdateScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction);
        bool RecommendDeferredLoading(FlutterSDK.Widgets.Framework.BuildContext context);
        void Dispose();
        void NotifyListeners();
        void DebugFillDescription(List<string> description);
        FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; }
        FlutterSDK.Widgets.Scrollcontext.ScrollContext Context { get; }
        bool KeepScrollOffset { get; }
        string DebugLabel { get; }
        FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> IsScrollingNotifier { get; }
        double MinScrollExtent { get; }
        double MaxScrollExtent { get; }
        double Pixels { get; }
        double ViewportDimension { get; }
        bool HaveDimensions { get; }
        bool AllowImplicitScrolling { get; }
        FlutterSDK.Widgets.Scrollactivity.ScrollActivity Activity { get; }
    }


    /// <Summary>
    /// Determines which portion of the content is visible in a scroll view.
    ///
    /// The [pixels] value determines the scroll offset that the scroll view uses to
    /// select which part of its content to display. As the user scrolls the
    /// viewport, this value changes, which changes the content that is displayed.
    ///
    /// The [ScrollPosition] applies [physics] to scrolling, and stores the
    /// [minScrollExtent] and [maxScrollExtent].
    ///
    /// Scrolling is controlled by the current [activity], which is set by
    /// [beginActivity]. [ScrollPosition] itself does not start any activities.
    /// Instead, concrete subclasses, such as [ScrollPositionWithSingleContext],
    /// typically start activities in response to user input or instructions from a
    /// [ScrollController].
    ///
    /// This object is a [Listenable] that notifies its listeners when [pixels]
    /// changes.
    ///
    /// ## Subclassing ScrollPosition
    ///
    /// Over time, a [Scrollable] might have many different [ScrollPosition]
    /// objects. For example, if [Scrollable.physics] changes type, [Scrollable]
    /// creates a new [ScrollPosition] with the new physics. To transfer state from
    /// the old instance to the new instance, subclasses implement [absorb]. See
    /// [absorb] for more details.
    ///
    /// Subclasses also need to call [didUpdateScrollDirection] whenever
    /// [userScrollDirection] changes values.
    ///
    /// See also:
    ///
    ///  * [Scrollable], which uses a [ScrollPosition] to determine which portion of
    ///    its content to display.
    ///  * [ScrollController], which can be used with [ListView], [GridView] and
    ///    other scrollable widgets to control a [ScrollPosition].
    ///  * [ScrollPositionWithSingleContext], which is the most commonly used
    ///    concrete subclass of [ScrollPosition].
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public class ScrollPosition : FlutterSDK.Rendering.Viewportoffset.ViewportOffset, IScrollMetrics
    {
        public ScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), bool keepScrollOffset = true, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), string debugLabel = default(string))
        : base()
        {
            this.Physics = physics;
            this.Context = context;
            this.KeepScrollOffset = keepScrollOffset;
            this.DebugLabel = debugLabel;
            if (oldPosition != null) Absorb(oldPosition);
            if (KeepScrollOffset) RestoreScrollOffset();
        }


        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontext.ScrollContext Context { get; set; }
        public virtual bool KeepScrollOffset { get; set; }
        public virtual string DebugLabel { get; set; }
        internal virtual double _MinScrollExtent { get; set; }
        internal virtual double _MaxScrollExtent { get; set; }
        internal virtual double _Pixels { get; set; }
        internal virtual double _ViewportDimension { get; set; }
        internal virtual bool _HaveDimensions { get; set; }
        internal virtual bool _DidChangeViewportDimensionOrReceiveCorrection { get; set; }
        internal virtual HashSet<SemanticsAction> _SemanticActions { get; set; }
        public virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> IsScrollingNotifier { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity _Activity { get; set; }
        public virtual double MinScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Pixels { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double ViewportDimension { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HaveDimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity Activity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Take any current applicable state from the given [ScrollPosition].
        ///
        /// This method is called by the constructor if it is given an `oldPosition`.
        /// The `other` argument might not have the same [runtimeType] as this object.
        ///
        /// This method can be destructive to the other [ScrollPosition]. The other
        /// object must be disposed immediately after this call (in the same call
        /// stack, before microtask resolution, by whomever called this object's
        /// constructor).
        ///
        /// If the old [ScrollPosition] object is a different [runtimeType] than this
        /// one, the [ScrollActivity.resetActivity] method is invoked on the newly
        /// adopted [ScrollActivity].
        ///
        /// ## Overriding
        ///
        /// Overrides of this method must call `super.absorb` after setting any
        /// metrics-related or activity-related state, since this method may restart
        /// the activity and scroll activities tend to use those metrics when being
        /// restarted.
        ///
        /// Overrides of this method might need to start an [IdleScrollActivity] if
        /// they are unable to absorb the activity from the other [ScrollPosition].
        ///
        /// Overrides of this method might also need to update the delegates of
        /// absorbed scroll activities if they use themselves as a
        /// [ScrollActivityDelegate].
        /// </Summary>
        public virtual void Absorb(FlutterSDK.Widgets.Scrollposition.ScrollPosition other)
        {



            _MinScrollExtent = other.MinScrollExtent;
            _MaxScrollExtent = other.MaxScrollExtent;
            _Pixels = other._Pixels;
            _ViewportDimension = other.ViewportDimension;


            _Activity = other.Activity;
            other._Activity = null;
            if (other.GetType() != GetType()) Activity.ResetActivity();
            Context.SetIgnorePointer(Activity.ShouldIgnorePointer);
            IsScrollingNotifier.Value = Activity.IsScrolling;
        }




        /// <Summary>
        /// Update the scroll position ([pixels]) to a given pixel value.
        ///
        /// This should only be called by the current [ScrollActivity], either during
        /// the transient callback phase or in response to user input.
        ///
        /// Returns the overscroll, if any. If the return value is 0.0, that means
        /// that [pixels] now returns the given `value`. If the return value is
        /// positive, then [pixels] is less than the requested `value` by the given
        /// amount (overscroll past the max extent), and if it is negative, it is
        /// greater than the requested `value` by the given amount (underscroll past
        /// the min extent).
        ///
        /// The amount of overscroll is computed by [applyBoundaryConditions].
        ///
        /// The amount of the change that is applied is reported using [didUpdateScrollPositionBy].
        /// If there is any overscroll, it is reported using [didOverscrollBy].
        /// </Summary>
        public virtual double SetPixels(double newPixels)
        {


            if (newPixels != Pixels)
            {
                double overscroll = ApplyBoundaryConditions(newPixels);

                double oldPixels = _Pixels;
                _Pixels = newPixels - overscroll;
                if (_Pixels != oldPixels)
                {
                    NotifyListeners();
                    DidUpdateScrollPositionBy(_Pixels - oldPixels);
                }

                if (overscroll != 0.0)
                {
                    DidOverscrollBy(overscroll);
                    return overscroll;
                }

            }

            return 0.0;
        }




        /// <Summary>
        /// Change the value of [pixels] to the new value, without notifying any
        /// customers.
        ///
        /// This is used to adjust the position while doing layout. In particular,
        /// this is typically called as a response to [applyViewportDimension] or
        /// [applyContentDimensions] (in both cases, if this method is called, those
        /// methods should then return false to indicate that the position has been
        /// adjusted).
        ///
        /// Calling this is rarely correct in other contexts. It will not immediately
        /// cause the rendering to change, since it does not notify the widgets or
        /// render objects that might be listening to this object: they will only
        /// change when they next read the value, which could be arbitrarily later. It
        /// is generally only appropriate in the very specific case of the value being
        /// corrected during layout (since then the value is immediately read), in the
        /// specific case of a [ScrollPosition] with a single viewport customer.
        ///
        /// To cause the position to jump or animate to a new value, consider [jumpTo]
        /// or [animateTo], which will honor the normal conventions for changing the
        /// scroll offset.
        ///
        /// To force the [pixels] to a particular value without honoring the normal
        /// conventions for changing the scroll offset, consider [forcePixels]. (But
        /// see the discussion there for why that might still be a bad idea.)
        ///
        /// See also:
        ///
        ///  * [correctBy], which is a method of [ViewportOffset] used
        ///    by viewport render objects to correct the offset during layout
        ///    without notifying its listeners.
        ///  * [jumpTo], for making changes to position while not in the
        ///    middle of layout and applying the new position immediately.
        ///  * [animateTo], which is like [jumpTo] but animating to the
        ///    destination offset.
        /// </Summary>
        public virtual void CorrectPixels(double value)
        {
            _Pixels = value;
        }




        /// <Summary>
        /// Apply a layout-time correction to the scroll offset.
        ///
        /// This method should change the [pixels] value by `correction`, but without
        /// calling [notifyListeners]. It is called during layout by the
        /// [RenderViewport], before [applyContentDimensions]. After this method is
        /// called, the layout will be recomputed and that may result in this method
        /// being called again, though this should be very rare.
        ///
        /// See also:
        ///
        ///  * [jumpTo], for also changing the scroll position when not in layout.
        ///    [jumpTo] applies the change immediately and notifies its listeners.
        ///  * [correctPixels], which is used by the [ScrollPosition] itself to
        ///    set the offset initially during construction or after
        ///    [applyViewportDimension] or [applyContentDimensions] is called.
        /// </Summary>
        public new void CorrectBy(double correction)
        {

            _Pixels += correction;
            _DidChangeViewportDimensionOrReceiveCorrection = true;
        }




        /// <Summary>
        /// Change the value of [pixels] to the new value, and notify any customers,
        /// but without honoring normal conventions for changing the scroll offset.
        ///
        /// This is used to implement [jumpTo]. It can also be used adjust the
        /// position when the dimensions of the viewport change. It should only be
        /// used when manually implementing the logic for honoring the relevant
        /// conventions of the class. For example, [ScrollPositionWithSingleContext]
        /// introduces [ScrollActivity] objects and uses [forcePixels] in conjunction
        /// with adjusting the activity, e.g. by calling
        /// [ScrollPositionWithSingleContext.goIdle], so that the activity does
        /// not immediately set the value back. (Consider, for instance, a case where
        /// one is using a [DrivenScrollActivity]. That object will ignore any calls
        /// to [forcePixels], which would result in the rendering stuttering: changing
        /// in response to [forcePixels], and then changing back to the next value
        /// derived from the animation.)
        ///
        /// To cause the position to jump or animate to a new value, consider [jumpTo]
        /// or [animateTo].
        ///
        /// This should not be called during layout (e.g. when setting the initial
        /// scroll offset). Consider [correctPixels] if you find you need to adjust
        /// the position during layout.
        /// </Summary>
        public virtual void ForcePixels(double value)
        {

            _Pixels = value;
            NotifyListeners();
        }




        /// <Summary>
        /// Called whenever scrolling ends, to store the current scroll offset in a
        /// storage mechanism with a lifetime that matches the app's lifetime.
        ///
        /// The stored value will be used by [restoreScrollOffset] when the
        /// [ScrollPosition] is recreated, in the case of the [Scrollable] being
        /// disposed then recreated in the same session. This might happen, for
        /// instance, if a [ListView] is on one of the pages inside a [TabBarView],
        /// and that page is displayed, then hidden, then displayed again.
        ///
        /// The default implementation writes the [pixels] using the nearest
        /// [PageStorage] found from the [context]'s [ScrollContext.storageContext]
        /// property.
        /// </Summary>
        public virtual void SaveScrollOffset()
        {
            PagestorageDefaultClass.PageStorage.Of(Context.StorageContext)?.WriteState(Context.StorageContext, Pixels);
        }




        /// <Summary>
        /// Called whenever the [ScrollPosition] is created, to restore the scroll
        /// offset if possible.
        ///
        /// The value is stored by [saveScrollOffset] when the scroll position
        /// changes, so that it can be restored in the case of the [Scrollable] being
        /// disposed then recreated in the same session. This might happen, for
        /// instance, if a [ListView] is on one of the pages inside a [TabBarView],
        /// and that page is displayed, then hidden, then displayed again.
        ///
        /// The default implementation reads the value from the nearest [PageStorage]
        /// found from the [context]'s [ScrollContext.storageContext] property, and
        /// sets it using [correctPixels], if [pixels] is still null.
        ///
        /// This method is called from the constructor, so layout has not yet
        /// occurred, and the viewport dimensions aren't yet known when it is called.
        /// </Summary>
        public virtual void RestoreScrollOffset()
        {
            if (Pixels == null)
            {
                double value = PagestorageDefaultClass.PageStorage.Of(Context.StorageContext)?.ReadState(Context.StorageContext) as double;
                if (value != null) CorrectPixels(value);
            }

        }




        /// <Summary>
        /// Returns the overscroll by applying the boundary conditions.
        ///
        /// If the given value is in bounds, returns 0.0. Otherwise, returns the
        /// amount of value that cannot be applied to [pixels] as a result of the
        /// boundary conditions. If the [physics] allow out-of-bounds scrolling, this
        /// method always returns 0.0.
        ///
        /// The default implementation defers to the [physics] object's
        /// [ScrollPhysics.applyBoundaryConditions].
        /// </Summary>
        public virtual double ApplyBoundaryConditions(double value)
        {
            double result = Physics.ApplyBoundaryConditions(this, value);

            return result;
        }




        public new bool ApplyViewportDimension(double viewportDimension)
        {
            if (_ViewportDimension != viewportDimension)
            {
                _ViewportDimension = viewportDimension;
                _DidChangeViewportDimensionOrReceiveCorrection = true;
            }

            return true;
        }




        /// <Summary>
        /// Called whenever the scroll position or the dimensions of the scroll view
        /// change to schedule an update of the available semantics actions. The
        /// actual update will be performed in the next frame. If non is pending
        /// a frame will be scheduled.
        ///
        /// For example: If the scroll view has been scrolled all the way to the top,
        /// the action to scroll further up needs to be removed as the scroll view
        /// cannot be scrolled in that direction anymore.
        ///
        /// This method is potentially called twice per frame (if scroll position and
        /// scroll view dimensions both change) and therefore shouldn't do anything
        /// expensive.
        /// </Summary>
        private void _UpdateSemanticActions()
        {
            SemanticsAction forward = default(SemanticsAction);
            SemanticsAction backward = default(SemanticsAction);
            switch (AxisDirection) { case AxisDirection.Up: forward = Dart:uiDefaultClass.SemanticsAction.ScrollDown; backward = Dart:uiDefaultClass.SemanticsAction.ScrollUp; break; case AxisDirection.Right: forward = Dart:uiDefaultClass.SemanticsAction.ScrollLeft; backward = Dart:uiDefaultClass.SemanticsAction.ScrollRight; break; case AxisDirection.Down: forward = Dart:uiDefaultClass.SemanticsAction.ScrollUp; backward = Dart:uiDefaultClass.SemanticsAction.ScrollDown; break; case AxisDirection.Left: forward = Dart:uiDefaultClass.SemanticsAction.ScrollRight; backward = Dart:uiDefaultClass.SemanticsAction.ScrollLeft; break; }
            HashSet<SemanticsAction> actions = new Dictionary<SemanticsAction> { };
            if (Pixels > MinScrollExtent) actions.Add(backward);
            if (Pixels < MaxScrollExtent) actions.Add(forward);
            if (CollectionsDefaultClass.SetEquals(actions, _SemanticActions)) return;
            _SemanticActions = actions;
            Context.SetSemanticsActions(_SemanticActions);
        }




        public new bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent)
        {


            if (!UtilsDefaultClass.NearEqual(_MinScrollExtent, minScrollExtent, ToleranceDefaultClass.Tolerance.DefaultTolerance.Distance) || !UtilsDefaultClass.NearEqual(_MaxScrollExtent, maxScrollExtent, ToleranceDefaultClass.Tolerance.DefaultTolerance.Distance) || _DidChangeViewportDimensionOrReceiveCorrection)
            {



                _MinScrollExtent = minScrollExtent;
                _MaxScrollExtent = maxScrollExtent;
                _HaveDimensions = true;
                ApplyNewDimensions();
                _DidChangeViewportDimensionOrReceiveCorrection = false;
            }

            return true;
        }




        /// <Summary>
        /// Notifies the activity that the dimensions of the underlying viewport or
        /// contents have changed.
        ///
        /// Called after [applyViewportDimension] or [applyContentDimensions] have
        /// changed the [minScrollExtent], the [maxScrollExtent], or the
        /// [viewportDimension]. When this method is called, it should be called
        /// _after_ any corrections are applied to [pixels] using [correctPixels], not
        /// before.
        ///
        /// The default implementation informs the [activity] of the new dimensions by
        /// calling its [ScrollActivity.applyNewDimensions] method.
        ///
        /// See also:
        ///
        ///  * [applyViewportDimension], which is called when new
        ///    viewport dimensions are established.
        ///  * [applyContentDimensions], which is called after new
        ///    viewport dimensions are established, and also if new content dimensions
        ///    are established, and which calls [ScrollPosition.applyNewDimensions].
        /// </Summary>
        public virtual void ApplyNewDimensions()
        {

            Activity.ApplyNewDimensions();
            _UpdateSemanticActions();
        }




        /// <Summary>
        /// Animates the position such that the given object is as visible as possible
        /// by just scrolling this position.
        ///
        /// See also:
        ///
        ///  * [ScrollPositionAlignmentPolicy] for the way in which `alignment` is
        ///    applied, and the way the given `object` is aligned.
        /// </Summary>
        public virtual Future<object> EnsureVisible(FlutterSDK.Rendering.@object.RenderObject @object, double alignment = 0.0, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy alignmentPolicy = default(FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy))
        {


            RenderAbstractViewport viewport = ViewportDefaultClass.RenderAbstractViewport.Of(object);

            double target = default(double);
            switch (alignmentPolicy)
            {
                case ScrollPositionAlignmentPolicy.Explicit: target = viewport.GetOffsetToReveal(object, alignment).Offset.Clamp(MinScrollExtent, MaxScrollExtent) as double; break;
                case ScrollPositionAlignmentPolicy.KeepVisibleAtEnd:
                    target = viewport.GetOffsetToReveal(object, 1.0).Offset.Clamp(MinScrollExtent, MaxScrollExtent) as double; if (target < Pixels)
                    {
                        target = Pixels;
                    }
                    break;
                case ScrollPositionAlignmentPolicy.KeepVisibleAtStart:
                    target = viewport.GetOffsetToReveal(object, 0.0).Offset.Clamp(MinScrollExtent, MaxScrollExtent) as double; if (target > Pixels)
                    {
                        target = Pixels;
                    }
                    break;
            }
            if (target == Pixels) return Future<void>.Value();
            if (duration == Dart:coreDefaultClass.Duration.Zero){
                JumpTo(target);
                return Future<void>.Value();
            }

            return AnimateTo(target, duration: duration, curve: curve);
        }




        /// <Summary>
        /// Animates the position from its current value to the given value.
        ///
        /// Any active animation is canceled. If the user is currently scrolling, that
        /// action is canceled.
        ///
        /// The returned [Future] will complete when the animation ends, whether it
        /// completed successfully or whether it was interrupted prematurely.
        ///
        /// An animation will be interrupted whenever the user attempts to scroll
        /// manually, or whenever another activity is started, or whenever the
        /// animation reaches the edge of the viewport and attempts to overscroll. (If
        /// the [ScrollPosition] does not overscroll but instead allows scrolling
        /// beyond the extents, then going beyond the extents will not interrupt the
        /// animation.)
        ///
        /// The animation is indifferent to changes to the viewport or content
        /// dimensions.
        ///
        /// Once the animation has completed, the scroll position will attempt to
        /// begin a ballistic activity in case its value is not stable (for example,
        /// if it is scrolled beyond the extents and in that situation the scroll
        /// position would normally bounce back).
        ///
        /// The duration must not be zero. To jump to a particular value without an
        /// animation, use [jumpTo].
        ///
        /// The animation is typically handled by an [DrivenScrollActivity].
        /// </Summary>
        public new Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            return default(Future<void>);
        }


        /// <Summary>
        /// Jumps the scroll position from its current value to the given value,
        /// without animation, and without checking if the new value is in range.
        ///
        /// Any active animation is canceled. If the user is currently scrolling, that
        /// action is canceled.
        ///
        /// If this method changes the scroll position, a sequence of start/update/end
        /// scroll notifications will be dispatched. No overscroll notifications can
        /// be generated by this method.
        /// </Summary>
        public new void JumpTo(double value)
        {
        }


        /// <Summary>
        /// Calls [jumpTo] if duration is null or [Duration.zero], otherwise
        /// [animateTo] is called.
        ///
        /// If [clamp] is true (the default) then [to] is adjusted to prevent over or
        /// underscroll.
        ///
        /// If [animateTo] is called then [curve] defaults to [Curves.ease].
        /// </Summary>
        public new Future<object> MoveTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), bool clamp = true)
        {


            if (clamp) to = to.Clamp(MinScrollExtent, MaxScrollExtent) as double;
            return base.MoveTo(to, duration: duration, curve: curve);
        }




        /// <Summary>
        /// Deprecated. Use [jumpTo] or a custom [ScrollPosition] instead.
        /// </Summary>
        public virtual void JumpToWithoutSettling(double value)
        {
        }


        /// <Summary>
        /// Stop the current activity and start a [HoldScrollActivity].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollHoldController Hold(VoidCallback holdCancelCallback)
        {
            return default(ScrollHoldController);
        }


        /// <Summary>
        /// Start a drag activity corresponding to the given [DragStartDetails].
        ///
        /// The `onDragCanceled` argument will be invoked if the drag is ended
        /// prematurely (e.g. from another activity taking over). See
        /// [ScrollDragController.onDragCanceled] for details.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback)
        {
            return default(Drag);
        }


        /// <Summary>
        /// Change the current [activity], disposing of the old one and
        /// sending scroll notifications as necessary.
        ///
        /// If the argument is null, this method has no effect. This is convenient for
        /// cases where the new activity is obtained from another method, and that
        /// method might return null, since it means the caller does not have to
        /// explicitly null-check the argument.
        /// </Summary>
        public virtual void BeginActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivity newActivity)
        {
            if (newActivity == null) return;
            bool wasScrolling oldIgnorePointer = default(bool);
            if (_Activity != null)
            {
                oldIgnorePointer = _Activity.ShouldIgnorePointer;
                wasScrolling = _Activity.IsScrolling;
                if (wasScrolling && !newActivity.IsScrolling) DidEndScroll();
                _Activity.Dispose();
            }
            else
            {
                oldIgnorePointer = false;
                wasScrolling = false;
            }

            _Activity = newActivity;
            if (oldIgnorePointer != Activity.ShouldIgnorePointer) Context.SetIgnorePointer(Activity.ShouldIgnorePointer);
            IsScrollingNotifier.Value = Activity.IsScrolling;
            if (!wasScrolling && _Activity.IsScrolling) DidStartScroll();
        }




        /// <Summary>
        /// Called by [beginActivity] to report when an activity has started.
        /// </Summary>
        public virtual void DidStartScroll()
        {
            Activity.DispatchScrollStartNotification(CopyWith(), Context.NotificationContext);
        }




        /// <Summary>
        /// Called by [setPixels] to report a change to the [pixels] position.
        /// </Summary>
        public virtual void DidUpdateScrollPositionBy(double delta)
        {
            Activity.DispatchScrollUpdateNotification(CopyWith(), Context.NotificationContext, delta);
        }




        /// <Summary>
        /// Called by [beginActivity] to report when an activity has ended.
        ///
        /// This also saves the scroll offset using [saveScrollOffset].
        /// </Summary>
        public virtual void DidEndScroll()
        {
            Activity.DispatchScrollEndNotification(CopyWith(), Context.NotificationContext);
            if (KeepScrollOffset) SaveScrollOffset();
        }




        /// <Summary>
        /// Called by [setPixels] to report overscroll when an attempt is made to
        /// change the [pixels] position. Overscroll is the amount of change that was
        /// not applied to the [pixels] value.
        /// </Summary>
        public virtual void DidOverscrollBy(double value)
        {

            Activity.DispatchOverscrollNotification(CopyWith(), Context.NotificationContext, value);
        }




        /// <Summary>
        /// Dispatches a notification that the [userScrollDirection] has changed.
        ///
        /// Subclasses should call this function when they change [userScrollDirection].
        /// </Summary>
        public virtual void DidUpdateScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction)
        {
            new UserScrollNotification(metrics: CopyWith(), context: Context.NotificationContext, direction: direction).Dispatch(Context.NotificationContext);
        }




        /// <Summary>
        /// Provides a heuristic to determine if expensive frame-bound tasks should be
        /// deferred.
        ///
        /// The actual work of this is delegated to the [physics] via
        /// [ScrollPhysics.recommendDeferredScrolling] called with the current
        /// [activity]'s [ScrollActivity.velocity].
        ///
        /// Returning true from this method indicates that the [ScrollPhysics]
        /// evaluate the current scroll velocity to be great enough that expensive
        /// operations impacting the UI should be deferred.
        /// </Summary>
        public virtual bool RecommendDeferredLoading(FlutterSDK.Widgets.Framework.BuildContext context)
        {



            return Physics.RecommendDeferredLoading(Activity.Velocity, CopyWith(), context);
        }




        public new void Dispose()
        {
            Activity?.Dispose();
            _Activity = null;
            base.Dispose();
        }




        public new void NotifyListeners()
        {
            _UpdateSemanticActions();
            base.NotifyListeners();
        }




        public new void DebugFillDescription(List<string> description)
        {
            if (DebugLabel != null) description.Add(DebugLabel);
            base.DebugFillDescription(description);
            description.Add($"'range: {MinScrollExtent?.ToStringAsFixed(1)}..{MaxScrollExtent?.ToStringAsFixed(1)}'");
            description.Add($"'viewport: {ViewportDimension?.ToStringAsFixed(1)}'");
        }



    }


    /// <Summary>
    /// The policy to use when applying the `alignment` parameter of
    /// [ScrollPosition.ensureVisible].
    /// </Summary>
    public enum ScrollPositionAlignmentPolicy
    {

        /// <Summary>
        /// Use the `alignment` property of [ScrollPosition.ensureVisible] to decide
        /// where to align the visible object.
        /// </Summary>
        Explicit,
        /// <Summary>
        /// Find the bottom edge of the scroll container, and scroll the container, if
        /// necessary, to show the bottom of the object.
        ///
        /// For example, find the bottom edge of the scroll container. If the bottom
        /// edge of the item is below the bottom edge of the scroll container, scroll
        /// the item so that the bottom of the item is just visible. If the entire
        /// item is already visible, then do nothing.
        /// </Summary>
        KeepVisibleAtEnd,
        /// <Summary>
        /// Find the top edge of the scroll container, and scroll the container if
        /// necessary to show the top of the object.
        ///
        /// For example, find the top edge of the scroll container. If the top edge of
        /// the item is above the top edge of the scroll container, scroll the item so
        /// that the top of the item is just visible. If the entire item is already
        /// visible, then do nothing.
        /// </Summary>
        KeepVisibleAtStart,
    }

}
