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
namespace FlutterSDK.Widgets.Framework
{
    public delegate void StateSetter(VoidCallback fn);
    public delegate void ElementVisitor(FlutterSDK.Widgets.Framework.Element element);
    public delegate FlutterSDK.Widgets.Framework.Widget ErrorWidgetBuilder(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details);
    public delegate FlutterSDK.Widgets.Framework.Widget WidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context);
    public delegate FlutterSDK.Widgets.Framework.Widget IndexedWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, int index);
    public delegate FlutterSDK.Widgets.Framework.Widget TransitionBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child);
    public delegate FlutterSDK.Widgets.Framework.Widget ControlsWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, VoidCallback onStepContinue = default(VoidCallback), VoidCallback onStepCancel = default(VoidCallback));
    internal static class FrameworkDefaultClass
    {
        internal static FlutterSDK.Foundation.Assertions.FlutterErrorDetails _DebugReportException(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context, object exception, StackTrace stack, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
        {
            FlutterErrorDetails details = new FlutterErrorDetails(exception: exception, stack: stack, library: "widgets library", context: context, informationCollector: informationCollector);
            AssertionsDefaultClass.FlutterError.ReportError(details);
            return details;
        }



    }

    /// <Summary>
    /// A key that is unique across the entire app.
    ///
    /// Global keys uniquely identify elements. Global keys provide access to other
    /// objects that are associated with those elements, such as [BuildContext].
    /// For [StatefulWidget]s, global keys also provide access to [State].
    ///
    /// Widgets that have global keys reparent their subtrees when they are moved
    /// from one location in the tree to another location in the tree. In order to
    /// reparent its subtree, a widget must arrive at its new location in the tree
    /// in the same animation frame in which it was removed from its old location in
    /// the tree.
    ///
    /// Global keys are relatively expensive. If you don't need any of the features
    /// listed above, consider using a [Key], [ValueKey], [ObjectKey], or
    /// [UniqueKey] instead.
    ///
    /// You cannot simultaneously include two widgets in the tree with the same
    /// global key. Attempting to do so will assert at runtime.
    ///
    /// See also:
    ///
    ///  * The discussion at [Widget.key] for more information about how widgets use
    ///    keys.
    /// </Summary>
    public interface IGlobalKey<T>
    {
        FlutterSDK.Widgets.Framework.BuildContext CurrentContext { get; }
        FlutterSDK.Widgets.Framework.Widget CurrentWidget { get; }
        T CurrentState { get; }
    }


    /// <Summary>
    /// Describes the configuration for an [Element].
    ///
    /// Widgets are the central class hierarchy in the Flutter framework. A widget
    /// is an immutable description of part of a user interface. Widgets can be
    /// inflated into elements, which manage the underlying render tree.
    ///
    /// Widgets themselves have no mutable state (all their fields must be final).
    /// If you wish to associate mutable state with a widget, consider using a
    /// [StatefulWidget], which creates a [State] object (via
    /// [StatefulWidget.createState]) whenever it is inflated into an element and
    /// incorporated into the tree.
    ///
    /// A given widget can be included in the tree zero or more times. In particular
    /// a given widget can be placed in the tree multiple times. Each time a widget
    /// is placed in the tree, it is inflated into an [Element], which means a
    /// widget that is incorporated into the tree multiple times will be inflated
    /// multiple times.
    ///
    /// The [key] property controls how one widget replaces another widget in the
    /// tree. If the [runtimeType] and [key] properties of the two widgets are
    /// [operator==], respectively, then the new widget replaces the old widget by
    /// updating the underlying element (i.e., by calling [Element.update] with the
    /// new widget). Otherwise, the old element is removed from the tree, the new
    /// widget is inflated into an element, and the new element is inserted into the
    /// tree.
    ///
    /// See also:
    ///
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    /// </Summary>
    public interface IWidget
    {
        FlutterSDK.Widgets.Framework.Element CreateElement();
        string ToStringShort();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        bool Equals(@Object other);
        bool CanUpdate(FlutterSDK.Widgets.Framework.Widget oldWidget, FlutterSDK.Widgets.Framework.Widget newWidget);
        FlutterSDK.Foundation.Key.Key Key { get; }
        int HashCode { get; }
    }


    /// <Summary>
    /// A widget that does not require mutable state.
    ///
    /// A stateless widget is a widget that describes part of the user interface by
    /// building a constellation of other widgets that describe the user interface
    /// more concretely. The building process continues recursively until the
    /// description of the user interface is fully concrete (e.g., consists
    /// entirely of [RenderObjectWidget]s, which describe concrete [RenderObject]s).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=wE7khGHVkYY}
    ///
    /// Stateless widget are useful when the part of the user interface you are
    /// describing does not depend on anything other than the configuration
    /// information in the object itself and the [BuildContext] in which the widget
    /// is inflated. For compositions that can change dynamically, e.g. due to
    /// having an internal clock-driven state, or depending on some system state,
    /// consider using [StatefulWidget].
    ///
    /// ## Performance considerations
    ///
    /// The [build] method of a stateless widget is typically only called in three
    /// situations: the first time the widget is inserted in the tree, when the
    /// widget's parent changes its configuration, and when an [InheritedWidget] it
    /// depends on changes.
    ///
    /// If a widget's parent will regularly change the widget's configuration, or if
    /// it depends on inherited widgets that frequently change, then it is important
    /// to optimize the performance of the [build] method to maintain a fluid
    /// rendering performance.
    ///
    /// There are several techniques one can use to minimize the impact of
    /// rebuilding a stateless widget:
    ///
    ///  * Minimize the number of nodes transitively created by the build method and
    ///    any widgets it creates. For example, instead of an elaborate arrangement
    ///    of [Row]s, [Column]s, [Padding]s, and [SizedBox]es to position a single
    ///    child in a particularly fancy manner, consider using just an [Align] or a
    ///    [CustomSingleChildLayout]. Instead of an intricate layering of multiple
    ///    [Container]s and with [Decoration]s to draw just the right graphical
    ///    effect, consider a single [CustomPaint] widget.
    ///
    ///  * Use `const` widgets where possible, and provide a `const` constructor for
    ///    the widget so that users of the widget can also do so.
    ///
    ///  * Consider refactoring the stateless widget into a stateful widget so that
    ///    it can use some of the techniques described at [StatefulWidget], such as
    ///    caching common parts of subtrees and using [GlobalKey]s when changing the
    ///    tree structure.
    ///
    ///  * If the widget is likely to get rebuilt frequently due to the use of
    ///    [InheritedWidget]s, consider refactoring the stateless widget into
    ///    multiple widgets, with the parts of the tree that change being pushed to
    ///    the leaves. For example instead of building a tree with four widgets, the
    ///    inner-most widget depending on the [Theme], consider factoring out the
    ///    part of the build function that builds the inner-most widget into its own
    ///    widget, so that only the inner-most widget needs to be rebuilt when the
    ///    theme changes.
    ///
    /// {@tool snippet}
    ///
    /// The following is a skeleton of a stateless widget subclass called `GreenFrog`.
    ///
    /// Normally, widgets have more constructor arguments, each of which corresponds
    /// to a `final` property.
    ///
    /// ```dart
    /// class GreenFrog extends StatelessWidget {
    ///   const GreenFrog({ Key key }) : super(key: key);
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(color: const Color(0xFF2DBD3A));
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    ///
    /// This next example shows the more generic widget `Frog` which can be given
    /// a color and a child:
    ///
    /// ```dart
    /// class Frog extends StatelessWidget {
    ///   const Frog({
    ///     Key key,
    ///     this.color = const Color(0xFF2DBD3A),
    ///     this.child,
    ///   }) : super(key: key);
    ///
    ///   final Color color;
    ///   final Widget child;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(color: color, child: child);
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// By convention, widget constructors only use named arguments. Named arguments
    /// can be marked as required using [@required]. Also by convention, the first
    /// argument is [key], and the last argument is `child`, `children`, or the
    /// equivalent.
    ///
    /// See also:
    ///
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    /// </Summary>
    public interface IStatelessWidget
    {
        FlutterSDK.Widgets.Framework.StatelessElement CreateElement();
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
    }


    /// <Summary>
    /// A widget that has mutable state.
    ///
    /// State is information that (1) can be read synchronously when the widget is
    /// built and (2) might change during the lifetime of the widget. It is the
    /// responsibility of the widget implementer to ensure that the [State] is
    /// promptly notified when such state changes, using [State.setState].
    ///
    /// A stateful widget is a widget that describes part of the user interface by
    /// building a constellation of other widgets that describe the user interface
    /// more concretely. The building process continues recursively until the
    /// description of the user interface is fully concrete (e.g., consists
    /// entirely of [RenderObjectWidget]s, which describe concrete [RenderObject]s).
    ///
    /// Stateful widgets are useful when the part of the user interface you are
    /// describing can change dynamically, e.g. due to having an internal
    /// clock-driven state, or depending on some system state. For compositions that
    /// depend only on the configuration information in the object itself and the
    /// [BuildContext] in which the widget is inflated, consider using
    /// [StatelessWidget].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=AqCMFXEmf3w}
    ///
    /// [StatefulWidget] instances themselves are immutable and store their mutable
    /// state either in separate [State] objects that are created by the
    /// [createState] method, or in objects to which that [State] subscribes, for
    /// example [Stream] or [ChangeNotifier] objects, to which references are stored
    /// in final fields on the [StatefulWidget] itself.
    ///
    /// The framework calls [createState] whenever it inflates a
    /// [StatefulWidget], which means that multiple [State] objects might be
    /// associated with the same [StatefulWidget] if that widget has been inserted
    /// into the tree in multiple places. Similarly, if a [StatefulWidget] is
    /// removed from the tree and later inserted in to the tree again, the framework
    /// will call [createState] again to create a fresh [State] object, simplifying
    /// the lifecycle of [State] objects.
    ///
    /// A [StatefulWidget] keeps the same [State] object when moving from one
    /// location in the tree to another if its creator used a [GlobalKey] for its
    /// [key]. Because a widget with a [GlobalKey] can be used in at most one
    /// location in the tree, a widget that uses a [GlobalKey] has at most one
    /// associated element. The framework takes advantage of this property when
    /// moving a widget with a global key from one location in the tree to another
    /// by grafting the (unique) subtree associated with that widget from the old
    /// location to the new location (instead of recreating the subtree at the new
    /// location). The [State] objects associated with [StatefulWidget] are grafted
    /// along with the rest of the subtree, which means the [State] object is reused
    /// (instead of being recreated) in the new location. However, in order to be
    /// eligible for grafting, the widget must be inserted into the new location in
    /// the same animation frame in which it was removed from the old location.
    ///
    /// ## Performance considerations
    ///
    /// There are two primary categories of [StatefulWidget]s.
    ///
    /// The first is one which allocates resources in [State.initState] and disposes
    /// of them in [State.dispose], but which does not depend on [InheritedWidget]s
    /// or call [State.setState]. Such widgets are commonly used at the root of an
    /// application or page, and communicate with subwidgets via [ChangeNotifier]s,
    /// [Stream]s, or other such objects. Stateful widgets following such a pattern
    /// are relatively cheap (in terms of CPU and GPU cycles), because they are
    /// built once then never update. They can, therefore, have somewhat complicated
    /// and deep build methods.
    ///
    /// The second category is widgets that use [State.setState] or depend on
    /// [InheritedWidget]s. These will typically rebuild many times during the
    /// application's lifetime, and it is therefore important to minimize the impact
    /// of rebuilding such a widget. (They may also use [State.initState] or
    /// [State.didChangeDependencies] and allocate resources, but the important part
    /// is that they rebuild.)
    ///
    /// There are several techniques one can use to minimize the impact of
    /// rebuilding a stateful widget:
    ///
    ///  * Push the state to the leaves. For example, if your page has a ticking
    ///    clock, rather than putting the state at the top of the page and
    ///    rebuilding the entire page each time the clock ticks, create a dedicated
    ///    clock widget that only updates itself.
    ///
    ///  * Minimize the number of nodes transitively created by the build method and
    ///    any widgets it creates. Ideally, a stateful widget would only create a
    ///    single widget, and that widget would be a [RenderObjectWidget].
    ///    (Obviously this isn't always practical, but the closer a widget gets to
    ///    this ideal, the more efficient it will be.)
    ///
    ///  * If a subtree does not change, cache the widget that represents that
    ///    subtree and re-use it each time it can be used. It is massively more
    ///    efficient for a widget to be re-used than for a new (but
    ///    identically-configured) widget to be created. Factoring out the stateful
    ///    part into a widget that takes a child argument is a common way of doing
    ///    this.
    ///
    ///  * Use `const` widgets where possible. (This is equivalent to caching a
    ///    widget and re-using it.)
    ///
    ///  * Avoid changing the depth of any created subtrees or changing the type of
    ///    any widgets in the subtree. For example, rather than returning either the
    ///    child or the child wrapped in an [IgnorePointer], always wrap the child
    ///    widget in an [IgnorePointer] and control the [IgnorePointer.ignoring]
    ///    property. This is because changing the depth of the subtree requires
    ///    rebuilding, laying out, and painting the entire subtree, whereas just
    ///    changing the property will require the least possible change to the
    ///    render tree (in the case of [IgnorePointer], for example, no layout or
    ///    repaint is necessary at all).
    ///
    ///  * If the depth must be changed for some reason, consider wrapping the
    ///    common parts of the subtrees in widgets that have a [GlobalKey] that
    ///    remains consistent for the life of the stateful widget. (The
    ///    [KeyedSubtree] widget may be useful for this purpose if no other widget
    ///    can conveniently be assigned the key.)
    ///
    /// {@tool snippet}
    ///
    /// This is a skeleton of a stateful widget subclass called `YellowBird`.
    ///
    /// In this example. the [State] has no actual state. State is normally
    /// represented as private member fields. Also, normally widgets have more
    /// constructor arguments, each of which corresponds to a `final` property.
    ///
    /// ```dart
    /// class YellowBird extends StatefulWidget {
    ///   const YellowBird({ Key key }) : super(key: key);
    ///
    ///   @override
    ///   _YellowBirdState createState() => _YellowBirdState();
    /// }
    ///
    /// class _YellowBirdState extends State<YellowBird> {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(color: const Color(0xFFFFE306));
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// This example shows the more generic widget `Bird` which can be given a
    /// color and a child, and which has some internal state with a method that
    /// can be called to mutate it:
    ///
    /// ```dart
    /// class Bird extends StatefulWidget {
    ///   const Bird({
    ///     Key key,
    ///     this.color = const Color(0xFFFFE306),
    ///     this.child,
    ///   }) : super(key: key);
    ///
    ///   final Color color;
    ///   final Widget child;
    ///
    ///   _BirdState createState() => _BirdState();
    /// }
    ///
    /// class _BirdState extends State<Bird> {
    ///   double _size = 1.0;
    ///
    ///   void grow() {
    ///     setState(() { _size += 0.1; });
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(
    ///       color: widget.color,
    ///       transform: Matrix4.diagonal3Values(_size, _size, 1.0),
    ///       child: widget.child,
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// By convention, widget constructors only use named arguments. Named arguments
    /// can be marked as required using [@required]. Also by convention, the first
    /// argument is [key], and the last argument is `child`, `children`, or the
    /// equivalent.
    ///
    /// See also:
    ///
    ///  * [State], where the logic behind a [StatefulWidget] is hosted.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    /// </Summary>
    public interface IStatefulWidget
    {
        FlutterSDK.Widgets.Framework.StatefulElement CreateElement();
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState();
    }


    /// <Summary>
    /// The logic and internal state for a [StatefulWidget].
    ///
    /// State is information that (1) can be read synchronously when the widget is
    /// built and (2) might change during the lifetime of the widget. It is the
    /// responsibility of the widget implementer to ensure that the [State] is
    /// promptly notified when such state changes, using [State.setState].
    ///
    /// [State] objects are created by the framework by calling the
    /// [StatefulWidget.createState] method when inflating a [StatefulWidget] to
    /// insert it into the tree. Because a given [StatefulWidget] instance can be
    /// inflated multiple times (e.g., the widget is incorporated into the tree in
    /// multiple places at once), there might be more than one [State] object
    /// associated with a given [StatefulWidget] instance. Similarly, if a
    /// [StatefulWidget] is removed from the tree and later inserted in to the tree
    /// again, the framework will call [StatefulWidget.createState] again to create
    /// a fresh [State] object, simplifying the lifecycle of [State] objects.
    ///
    /// [State] objects have the following lifecycle:
    ///
    ///  * The framework creates a [State] object by calling
    ///    [StatefulWidget.createState].
    ///  * The newly created [State] object is associated with a [BuildContext].
    ///    This association is permanent: the [State] object will never change its
    ///    [BuildContext]. However, the [BuildContext] itself can be moved around
    ///    the tree along with its subtree. At this point, the [State] object is
    ///    considered [mounted].
    ///  * The framework calls [initState]. Subclasses of [State] should override
    ///    [initState] to perform one-time initialization that depends on the
    ///    [BuildContext] or the widget, which are available as the [context] and
    ///    [widget] properties, respectively, when the [initState] method is
    ///    called.
    ///  * The framework calls [didChangeDependencies]. Subclasses of [State] should
    ///    override [didChangeDependencies] to perform initialization involving
    ///    [InheritedWidget]s. If [BuildContext.dependOnInheritedWidgetOfExactType] is
    ///    called, the [didChangeDependencies] method will be called again if the
    ///    inherited widgets subsequently change or if the widget moves in the tree.
    ///  * At this point, the [State] object is fully initialized and the framework
    ///    might call its [build] method any number of times to obtain a
    ///    description of the user interface for this subtree. [State] objects can
    ///    spontaneously request to rebuild their subtree by callings their
    ///    [setState] method, which indicates that some of their internal state
    ///    has changed in a way that might impact the user interface in this
    ///    subtree.
    ///  * During this time, a parent widget might rebuild and request that this
    ///    location in the tree update to display a new widget with the same
    ///    [runtimeType] and [Widget.key]. When this happens, the framework will
    ///    update the [widget] property to refer to the new widget and then call the
    ///    [didUpdateWidget] method with the previous widget as an argument. [State]
    ///    objects should override [didUpdateWidget] to respond to changes in their
    ///    associated widget (e.g., to start implicit animations). The framework
    ///    always calls [build] after calling [didUpdateWidget], which means any
    ///    calls to [setState] in [didUpdateWidget] are redundant.
    ///  * During development, if a hot reload occurs (whether initiated from the
    ///    command line `flutter` tool by pressing `r`, or from an IDE), the
    ///    [reassemble] method is called. This provides an opportunity to
    ///    reinitialize any data that was prepared in the [initState] method.
    ///  * If the subtree containing the [State] object is removed from the tree
    ///    (e.g., because the parent built a widget with a different [runtimeType]
    ///    or [Widget.key]), the framework calls the [deactivate] method. Subclasses
    ///    should override this method to clean up any links between this object
    ///    and other elements in the tree (e.g. if you have provided an ancestor
    ///    with a pointer to a descendant's [RenderObject]).
    ///  * At this point, the framework might reinsert this subtree into another
    ///    part of the tree. If that happens, the framework will ensure that it
    ///    calls [build] to give the [State] object a chance to adapt to its new
    ///    location in the tree. If the framework does reinsert this subtree, it
    ///    will do so before the end of the animation frame in which the subtree was
    ///    removed from the tree. For this reason, [State] objects can defer
    ///    releasing most resources until the framework calls their [dispose]
    ///    method.
    ///  * If the framework does not reinsert this subtree by the end of the current
    ///    animation frame, the framework will call [dispose], which indicates that
    ///    this [State] object will never build again. Subclasses should override
    ///    this method to release any resources retained by this object (e.g.,
    ///    stop any active animations).
    ///  * After the framework calls [dispose], the [State] object is considered
    ///    unmounted and the [mounted] property is false. It is an error to call
    ///    [setState] at this point. This stage of the lifecycle is terminal: there
    ///    is no way to remount a [State] object that has been disposed.
    ///
    /// See also:
    ///
    ///  * [StatefulWidget], where the current configuration of a [State] is hosted,
    ///    and whose documentation has sample code for [State].
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    ///  * [Widget], for an overview of widgets in general.
    /// </Summary>
    public interface IState<T>
    {
        void InitState();
        void DidUpdateWidget(T oldWidget);
        void Reassemble();
        void SetState(VoidCallback fn);
        void Deactivate();
        void Dispose();
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
        void DidChangeDependencies();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        T Widget { get; }
        FlutterSDK.Widgets.Framework.BuildContext Context { get; }
        bool Mounted { get; }
    }


    /// <Summary>
    /// A widget that has a child widget provided to it, instead of building a new
    /// widget.
    ///
    /// Useful as a base class for other widgets, such as [InheritedWidget] and
    /// [ParentDataWidget].
    ///
    /// See also:
    ///
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    ///  * [ParentDataWidget], for widgets that populate the
    ///    [RenderObject.parentData] slot of their child's [RenderObject] to
    ///    configure the parent widget's layout.
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [Widget], for an overview of widgets in general.
    /// </Summary>
    public interface IProxyWidget
    {
        FlutterSDK.Widgets.Framework.Widget Child { get; }
    }


    /// <Summary>
    /// Base class for widgets that hook [ParentData] information to children of
    /// [RenderObjectWidget]s.
    ///
    /// This can be used to provide per-child configuration for
    /// [RenderObjectWidget]s with more than one child. For example, [Stack] uses
    /// the [Positioned] parent data widget to position each child.
    ///
    /// A [ParentDataWidget] is specific to a particular kind of [ParentData]. That
    /// class is `T`, the [ParentData] type argument.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how you would build a [ParentDataWidget] to configure a
    /// `FrogJar` widget's children by specifying a [Size] for each one.
    ///
    /// ```dart
    /// class FrogSize extends ParentDataWidget<FrogJarParentData> {
    ///   FrogSize({
    ///     Key key,
    ///     @required this.size,
    ///     @required Widget child,
    ///   }) : assert(child != null),
    ///        assert(size != null),
    ///        super(key: key, child: child);
    ///
    ///   final Size size;
    ///
    ///   @override
    ///   void applyParentData(RenderObject renderObject) {
    ///     final FrogJarParentData parentData = renderObject.parentData;
    ///     if (parentData.size != size) {
    ///       parentData.size = size;
    ///       final RenderFrogJar targetParent = renderObject.parent;
    ///       targetParent.markNeedsLayout();
    ///     }
    ///   }
    ///
    ///   @override
    ///   Type get debugTypicalAncestorWidgetClass => FrogJar;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RenderObject], the superclass for layout algorithms.
    ///  * [RenderObject.parentData], the slot that this class configures.
    ///  * [ParentData], the superclass of the data that will be placed in
    ///    [RenderObject.parentData] slots. The `T` type parameter for
    ///    [ParentDataWidget] is a [ParentData].
    ///  * [RenderObjectWidget], the class for widgets that wrap [RenderObject]s.
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    /// </Summary>
    public interface IParentDataWidget<T>
    {
        ParentDataElement<T> CreateElement();
        bool DebugIsValidRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject);
        void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject);
        bool DebugCanApplyOutOfTurn();
        Type DebugTypicalAncestorWidgetClass { get; }
    }


    /// <Summary>
    /// Base class for widgets that efficiently propagate information down the tree.
    ///
    /// To obtain the nearest instance of a particular type of inherited widget from
    /// a build context, use [BuildContext.dependOnInheritedWidgetOfExactType].
    ///
    /// Inherited widgets, when referenced in this way, will cause the consumer to
    /// rebuild when the inherited widget itself changes state.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=Zbm3hjPjQMk}
    ///
    /// {@tool snippet}
    ///
    /// The following is a skeleton of an inherited widget called `FrogColor`:
    ///
    /// ```dart
    /// class FrogColor extends InheritedWidget {
    ///   const FrogColor({
    ///     Key key,
    ///     @required this.color,
    ///     @required Widget child,
    ///   }) : assert(color != null),
    ///        assert(child != null),
    ///        super(key: key, child: child);
    ///
    ///   final Color color;
    ///
    ///   static FrogColor of(BuildContext context) {
    ///     return context.dependOnInheritedWidgetOfExactType<FrogColor>();
    ///   }
    ///
    ///   @override
    ///   bool updateShouldNotify(FrogColor old) => color != old.color;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// The convention is to provide a static method `of` on the [InheritedWidget]
    /// which does the call to [BuildContext.dependOnInheritedWidgetOfExactType]. This
    /// allows the class to define its own fallback logic in case there isn't
    /// a widget in scope. In the example above, the value returned will be
    /// null in that case, but it could also have defaulted to a value.
    ///
    /// Sometimes, the `of` method returns the data rather than the inherited
    /// widget; for example, in this case it could have returned a [Color] instead
    /// of the `FrogColor` widget.
    ///
    /// Occasionally, the inherited widget is an implementation detail of another
    /// class, and is therefore private. The `of` method in that case is typically
    /// put on the public class instead. For example, [Theme] is implemented as a
    /// [StatelessWidget] that builds a private inherited widget; [Theme.of] looks
    /// for that inherited widget using [BuildContext.dependOnInheritedWidgetOfExactType]
    /// and then returns the [ThemeData].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=1t-8rBCGBYw}
    ///
    /// See also:
    ///
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [Widget], for an overview of widgets in general.
    ///  * [InheritedNotifier], an inherited widget whose value can be a
    ///    [Listenable], and which will notify dependents whenever the value
    ///    sends notifications.
    ///  * [InheritedModel], an inherited widget that allows clients to subscribe
    ///    to changes for subparts of the value.
    /// </Summary>
    public interface IInheritedWidget
    {
        FlutterSDK.Widgets.Framework.InheritedElement CreateElement();
        bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget);
    }


    /// <Summary>
    /// RenderObjectWidgets provide the configuration for [RenderObjectElement]s,
    /// which wrap [RenderObject]s, which provide the actual rendering of the
    /// application.
    /// </Summary>
    public interface IRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement();
        FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
        void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject);
        void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject);
    }


    /// <Summary>
    /// A superclass for RenderObjectWidgets that configure RenderObject subclasses
    /// that have no children.
    /// </Summary>
    public interface ILeafRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.LeafRenderObjectElement CreateElement();
    }


    /// <Summary>
    /// A superclass for [RenderObjectWidget]s that configure [RenderObject] subclasses
    /// that have a single child slot. (This superclass only provides the storage
    /// for that child, it doesn't actually provide the updating logic.)
    ///
    /// Typically, the render object assigned to this widget will make use of
    /// [RenderObjectWithChildMixin] to implement a single-child model. The mixin
    /// exposes a [RenderObjectWithChildMixin.child] property that allows
    /// retrieving the render object belonging to the [child] widget.
    /// </Summary>
    public interface ISingleChildRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement CreateElement();
        FlutterSDK.Widgets.Framework.Widget Child { get; }
    }


    /// <Summary>
    /// A superclass for [RenderObjectWidget]s that configure [RenderObject] subclasses
    /// that have a single list of children. (This superclass only provides the
    /// storage for that child list, it doesn't actually provide the updating
    /// logic.)
    ///
    /// This will return a [RenderObject] mixing in [ContainerRenderObjectMixin],
    /// which provides the necessary functionality to visit the children of the
    /// container render object (the render object belonging to the [children] widgets).
    /// Typically, this is a [RenderBox] with [RenderBoxContainerDefaultsMixin].
    ///
    /// See also:
    ///
    ///  * [Stack], which uses [MultiChildRenderObjectWidget].
    ///  * [RenderStack], for an example implementation of the associated render object.
    /// </Summary>
    public interface IMultiChildRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement CreateElement();
        List<FlutterSDK.Widgets.Framework.Widget> Children { get; }
    }


    /// <Summary>
    /// An instantiation of a [Widget] at a particular location in the tree.
    ///
    /// Widgets describe how to configure a subtree but the same widget can be used
    /// to configure multiple subtrees simultaneously because widgets are immutable.
    /// An [Element] represents the use of a widget to configure a specific location
    /// in the tree. Over time, the widget associated with a given element can
    /// change, for example, if the parent widget rebuilds and creates a new widget
    /// for this location.
    ///
    /// Elements form a tree. Most elements have a unique child, but some widgets
    /// (e.g., subclasses of [RenderObjectElement]) can have multiple children.
    ///
    /// Elements have the following lifecycle:
    ///
    ///  * The framework creates an element by calling [Widget.createElement] on the
    ///    widget that will be used as the element's initial configuration.
    ///  * The framework calls [mount] to add the newly created element to the tree
    ///    at a given slot in a given parent. The [mount] method is responsible for
    ///    inflating any child widgets and calling [attachRenderObject] as
    ///    necessary to attach any associated render objects to the render tree.
    ///  * At this point, the element is considered "active" and might appear on
    ///    screen.
    ///  * At some point, the parent might decide to change the widget used to
    ///    configure this element, for example because the parent rebuilt with new
    ///    state. When this happens, the framework will call [update] with the new
    ///    widget. The new widget will always have the same [runtimeType] and key as
    ///    old widget. If the parent wishes to change the [runtimeType] or key of
    ///    the widget at this location in the tree, it can do so by unmounting this
    ///    element and inflating the new widget at this location.
    ///  * At some point, an ancestor might decide to remove this element (or an
    ///    intermediate ancestor) from the tree, which the ancestor does by calling
    ///    [deactivateChild] on itself. Deactivating the intermediate ancestor will
    ///    remove that element's render object from the render tree and add this
    ///    element to the [owner]'s list of inactive elements, causing the framework
    ///    to call [deactivate] on this element.
    ///  * At this point, the element is considered "inactive" and will not appear
    ///    on screen. An element can remain in the inactive state only until
    ///    the end of the current animation frame. At the end of the animation
    ///    frame, any elements that are still inactive will be unmounted.
    ///  * If the element gets reincorporated into the tree (e.g., because it or one
    ///    of its ancestors has a global key that is reused), the framework will
    ///    remove the element from the [owner]'s list of inactive elements, call
    ///    [activate] on the element, and reattach the element's render object to
    ///    the render tree. (At this point, the element is again considered "active"
    ///    and might appear on screen.)
    ///  * If the element does not get reincorporated into the tree by the end of
    ///    the current animation frame, the framework will call [unmount] on the
    ///    element.
    ///  * At this point, the element is considered "defunct" and will not be
    ///    incorporated into the tree in the future.
    /// </Summary>
    public interface IElement
    {
        bool Equals(@Object other);
        void Reassemble();
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(Type expectedAncestorType = default(Type));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElements(string name, Iterable<FlutterSDK.Widgets.Framework.Element> elements);
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(string name);
        void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        void VisitChildElements(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot);
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
        void Update(FlutterSDK.Widgets.Framework.Widget newWidget);
        void UpdateSlotForChild(FlutterSDK.Widgets.Framework.Element child, object newSlot);
        void DetachRenderObject();
        void AttachRenderObject(object newSlot);
        FlutterSDK.Widgets.Framework.Element InflateWidget(FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot);
        void DeactivateChild(FlutterSDK.Widgets.Framework.Element child);
        void ForgetChild(FlutterSDK.Widgets.Framework.Element child);
        void Activate();
        void Deactivate();
        void DebugDeactivated();
        void Unmount();
        FlutterSDK.Rendering.@object.RenderObject FindRenderObject();
        FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object));
        FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object));
        FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(Type targetType, @Object aspect = default(@Object));
        T DependOnInheritedWidgetOfExactType<T>(@Object aspect = default(@Object));
        FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(Type targetType);
        FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>();
        FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(Type targetType);
        T FindAncestorWidgetOfExactType<T>();
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher);
        T FindAncestorStateOfType<T>();
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher);
        T FindRootAncestorStateOfType<T>();
        FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher);
        T FindAncestorRenderObjectOfType<T>();
        void VisitAncestorElements(Func<bool, Element> visitor);
        void DidChangeDependencies();
        string DebugGetCreatorChain(int limit);
        List<FlutterSDK.Widgets.Framework.Element> DebugGetDiagnosticChain();
        string ToStringShort();
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        void MarkNeedsBuild();
        void Rebuild();
        void PerformRebuild();
        int HashCode { get; }
        object Slot { get; }
        int Depth { get; }
        FlutterSDK.Widgets.Framework.Widget Widget { get; }
        FlutterSDK.Widgets.Framework.BuildOwner Owner { get; }
        FlutterSDK.Rendering.@object.RenderObject RenderObject { get; }
        Size Size { get; }
        bool Dirty { get; }
    }


    /// <Summary>
    /// An [Element] that composes other [Element]s.
    ///
    /// Rather than creating a [RenderObject] directly, a [ComponentElement] creates
    /// [RenderObject]s indirectly by creating other [Element]s.
    ///
    /// Contrast with [RenderObjectElement].
    /// </Summary>
    public interface IComponentElement
    {
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
        void PerformRebuild();
        FlutterSDK.Widgets.Framework.Widget Build();
        void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        void ForgetChild(FlutterSDK.Widgets.Framework.Element child);
        bool DebugDoingBuild { get; }
    }


    /// <Summary>
    /// An [Element] that uses a [ProxyWidget] as its configuration.
    /// </Summary>
    public interface IProxyElement
    {
        FlutterSDK.Widgets.Framework.Widget Build();
        void Update(FlutterSDK.Widgets.Framework.ProxyWidget newWidget);
        void Updated(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget);
        void NotifyClients(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget);
        FlutterSDK.Widgets.Framework.ProxyWidget Widget { get; }
    }


    /// <Summary>
    /// An [Element] that uses a [RenderObjectWidget] as its configuration.
    ///
    /// [RenderObjectElement] objects have an associated [RenderObject] widget in
    /// the render tree, which handles concrete operations like laying out,
    /// painting, and hit testing.
    ///
    /// Contrast with [ComponentElement].
    ///
    /// For details on the lifecycle of an element, see the discussion at [Element].
    ///
    /// ## Writing a RenderObjectElement subclass
    ///
    /// There are three common child models used by most [RenderObject]s:
    ///
    /// * Leaf render objects, with no children: The [LeafRenderObjectElement] class
    ///   handles this case.
    ///
    /// * A single child: The [SingleChildRenderObjectElement] class handles this
    ///   case.
    ///
    /// * A linked list of children: The [MultiChildRenderObjectElement] class
    ///   handles this case.
    ///
    /// Sometimes, however, a render object's child model is more complicated. Maybe
    /// it has a two-dimensional array of children. Maybe it constructs children on
    /// demand. Maybe it features multiple lists. In such situations, the
    /// corresponding [Element] for the [Widget] that configures that [RenderObject]
    /// will be a new subclass of [RenderObjectElement].
    ///
    /// Such a subclass is responsible for managing children, specifically the
    /// [Element] children of this object, and the [RenderObject] children of its
    /// corresponding [RenderObject].
    ///
    /// ### Specializing the getters
    ///
    /// [RenderObjectElement] objects spend much of their time acting as
    /// intermediaries between their [widget] and their [renderObject]. To make this
    /// more tractable, most [RenderObjectElement] subclasses override these getters
    /// so that they return the specific type that the element expects, e.g.:
    ///
    /// ```dart
    /// class FooElement extends RenderObjectElement {
    ///
    ///   @override
    ///   Foo get widget => super.widget;
    ///
    ///   @override
    ///   RenderFoo get renderObject => super.renderObject;
    ///
    ///   // ...
    /// }
    /// ```
    ///
    /// ### Slots
    ///
    /// Each child [Element] corresponds to a [RenderObject] which should be
    /// attached to this element's render object as a child.
    ///
    /// However, the immediate children of the element may not be the ones that
    /// eventually produce the actual [RenderObject] that they correspond to. For
    /// example a [StatelessElement] (the element of a [StatelessWidget]) simply
    /// corresponds to whatever [RenderObject] its child (the element returned by
    /// its [StatelessWidget.build] method) corresponds to.
    ///
    /// Each child is therefore assigned a _slot_ token. This is an identifier whose
    /// meaning is private to this [RenderObjectElement] node. When the descendant
    /// that finally produces the [RenderObject] is ready to attach it to this
    /// node's render object, it passes that slot token back to this node, and that
    /// allows this node to cheaply identify where to put the child render object
    /// relative to the others in the parent render object.
    ///
    /// ### Updating children
    ///
    /// Early in the lifecycle of an element, the framework calls the [mount]
    /// method. This method should call [updateChild] for each child, passing in
    /// the widget for that child, and the slot for that child, thus obtaining a
    /// list of child [Element]s.
    ///
    /// Subsequently, the framework will call the [update] method. In this method,
    /// the [RenderObjectElement] should call [updateChild] for each child, passing
    /// in the [Element] that was obtained during [mount] or the last time [update]
    /// was run (whichever happened most recently), the new [Widget], and the slot.
    /// This provides the object with a new list of [Element] objects.
    ///
    /// Where possible, the [update] method should attempt to map the elements from
    /// the last pass to the widgets in the new pass. For example, if one of the
    /// elements from the last pass was configured with a particular [Key], and one
    /// of the widgets in this new pass has that same key, they should be paired up,
    /// and the old element should be updated with the widget (and the slot
    /// corresponding to the new widget's new position, also). The [updateChildren]
    /// method may be useful in this regard.
    ///
    /// [updateChild] should be called for children in their logical order. The
    /// order can matter; for example, if two of the children use [PageStorage]'s
    /// `writeState` feature in their build method (and neither has a [Widget.key]),
    /// then the state written by the first will be overwritten by the second.
    ///
    /// #### Dynamically determining the children during the build phase
    ///
    /// The child widgets need not necessarily come from this element's widget
    /// verbatim. They could be generated dynamically from a callback, or generated
    /// in other more creative ways.
    ///
    /// #### Dynamically determining the children during layout
    ///
    /// If the widgets are to be generated at layout time, then generating them when
    /// the [update] method won't work: layout of this element's render object
    /// hasn't started yet at that point. Instead, the [update] method can mark the
    /// render object as needing layout (see [RenderObject.markNeedsLayout]), and
    /// then the render object's [RenderObject.performLayout] method can call back
    /// to the element to have it generate the widgets and call [updateChild]
    /// accordingly.
    ///
    /// For a render object to call an element during layout, it must use
    /// [RenderObject.invokeLayoutCallback]. For an element to call [updateChild]
    /// outside of its [update] method, it must use [BuildOwner.buildScope].
    ///
    /// The framework provides many more checks in normal operation than it does
    /// when doing a build during layout. For this reason, creating widgets with
    /// layout-time build semantics should be done with great care.
    ///
    /// #### Handling errors when building
    ///
    /// If an element calls a builder function to obtain widgets for its children,
    /// it may find that the build throws an exception. Such exceptions should be
    /// caught and reported using [FlutterError.reportError]. If a child is needed
    /// but a builder has failed in this way, an instance of [ErrorWidget] can be
    /// used instead.
    ///
    /// ### Detaching children
    ///
    /// It is possible, when using [GlobalKey]s, for a child to be proactively
    /// removed by another element before this element has been updated.
    /// (Specifically, this happens when the subtree rooted at a widget with a
    /// particular [GlobalKey] is being moved from this element to an element
    /// processed earlier in the build phase.) When this happens, this element's
    /// [forgetChild] method will be called with a reference to the affected child
    /// element.
    ///
    /// The [forgetChild] method of a [RenderObjectElement] subclass must remove the
    /// child element from its child list, so that when it next [update]s its
    /// children, the removed child is not considered.
    ///
    /// For performance reasons, if there are many elements, it may be quicker to
    /// track which elements were forgotten by storing them in a [Set], rather than
    /// proactively mutating the local record of the child list and the identities
    /// of all the slots. For example, see the implementation of
    /// [MultiChildRenderObjectElement].
    ///
    /// ### Maintaining the render object tree
    ///
    /// Once a descendant produces a render object, it will call
    /// [insertChildRenderObject]. If the descendant's slot changes identity, it
    /// will call [moveChildRenderObject]. If a descendant goes away, it will call
    /// [removeChildRenderObject].
    ///
    /// These three methods should update the render tree accordingly, attaching,
    /// moving, and detaching the given child render object from this element's own
    /// render object respectively.
    ///
    /// ### Walking the children
    ///
    /// If a [RenderObjectElement] object has any children [Element]s, it must
    /// expose them in its implementation of the [visitChildren] method. This method
    /// is used by many of the framework's internal mechanisms, and so should be
    /// fast. It is also used by the test framework and [debugDumpApp].
    /// </Summary>
    public interface IRenderObjectElement
    {
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
        void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget);
        void PerformRebuild();
        List<FlutterSDK.Widgets.Framework.Element> UpdateChildren(List<FlutterSDK.Widgets.Framework.Element> oldChildren, List<FlutterSDK.Widgets.Framework.Widget> newWidgets, HashSet<FlutterSDK.Widgets.Framework.Element> forgottenChildren = default(HashSet<FlutterSDK.Widgets.Framework.Element>));
        void Deactivate();
        void Unmount();
        void AttachRenderObject(object newSlot);
        void DetachRenderObject();
        void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot);
        void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot);
        void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Widgets.Framework.RenderObjectWidget Widget { get; }
        FlutterSDK.Rendering.@object.RenderObject RenderObject { get; }
        bool DebugDoingBuild { get; }
    }


    /// <Summary>
    /// The element at the root of the tree.
    ///
    /// Only root elements may have their owner set explicitly. All other
    /// elements inherit their owner from their parent.
    /// </Summary>
    public interface IRootRenderObjectElement
    {
        void AssignOwner(FlutterSDK.Widgets.Framework.BuildOwner owner);
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
    }


    public interface I_InactiveElements { }

    public class _InactiveElements
    {
        internal virtual bool _Locked { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _Elements { get; set; }

        private void _Unmount(FlutterSDK.Widgets.Framework.Element element)
        {


            element.VisitChildren((Element child) =>
            {

                _Unmount(child);
            }
            );
            element.Unmount();

        }




        private void _UnmountAll()
        {
            _Locked = true;
            List<Element> elements = _Elements.ToList();
            _Elements.ToList().Sort(FrameworkDefaultClass.Element._Sort);
            _Elements.Clear();
            try
            {
                elements.Reversed.ForEach(_Unmount);
            }
            finally
            {

                _Locked = false;
            }

        }




        private void _DeactivateRecursively(FlutterSDK.Widgets.Framework.Element element)
        {

            element.Deactivate();

            element.VisitChildren(_DeactivateRecursively);

        }




        public virtual void Add(FlutterSDK.Widgets.Framework.Element element)
        {



            if (element._Active) _DeactivateRecursively(element);
            _Elements.Add(element);
        }




        public virtual void Remove(FlutterSDK.Widgets.Framework.Element element)
        {



            _Elements.Remove(element);

        }




        public virtual bool DebugContains(FlutterSDK.Widgets.Framework.Element element)
        {
            bool result = default(bool);

            return result;
        }



    }
    public static class _InactiveElementsMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<I_InactiveElements, _InactiveElements> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_InactiveElements, _InactiveElements>();
        static _InactiveElements GetOrCreate(I_InactiveElements instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new _InactiveElements();
                _table.Add(instance, value);
            }
            return (_InactiveElements)value;
        }
        public static void Add(this I_InactiveElements instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).Add(element);
        public static void Remove(this I_InactiveElements instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).Remove(element);
        public static bool DebugContains(this I_InactiveElements instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).DebugContains(element);
    }


    public interface IBuildContext { }

    public class BuildContext
    {
        public virtual FlutterSDK.Widgets.Framework.Widget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingBuild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The current [RenderObject] for the widget. If the widget is a
        /// [RenderObjectWidget], this is the render object that the widget created
        /// for itself. Otherwise, it is the render object of the first descendant
        /// [RenderObjectWidget].
        ///
        /// This method will only return a valid result after the build phase is
        /// complete. It is therefore not valid to call this from a build method.
        /// It should only be called from interaction event handlers (e.g.
        /// gesture callbacks) or layout or paint callbacks.
        ///
        /// If the render object is a [RenderBox], which is the common case, then the
        /// size of the render object can be obtained from the [size] getter. This is
        /// only valid after the layout phase, and should therefore only be examined
        /// from paint callbacks or interaction event handlers (e.g. gesture
        /// callbacks).
        ///
        /// For details on the different phases of a frame, see the discussion at
        /// [WidgetsBinding.drawFrame].
        ///
        /// Calling this method is theoretically relatively expensive (O(N) in the
        /// depth of the tree), but in practice is usually cheap because the tree
        /// usually has many render objects and therefore the distance to the nearest
        /// render object is usually short.
        /// </Summary>
        public virtual FlutterSDK.Rendering.@object.RenderObject FindRenderObject()
        {
            return default(RenderObject);
        }


        /// <Summary>
        /// Registers this build context with [ancestor] such that when
        /// [ancestor]'s widget changes this build context is rebuilt.
        ///
        /// This method is deprecated. Please use [dependOnInheritedElement] instead.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object))
        {
            return default(InheritedWidget);
        }


        /// <Summary>
        /// Registers this build context with [ancestor] such that when
        /// [ancestor]'s widget changes this build context is rebuilt.
        ///
        /// Returns `ancestor.widget`.
        ///
        /// This method is rarely called directly. Most applications should use
        /// [dependOnInheritedWidgetOfExactType], which calls this method after finding
        /// the appropriate [InheritedElement] ancestor.
        ///
        /// All of the qualifications about when [dependOnInheritedWidgetOfExactType] can
        /// be called apply to this method as well.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object))
        {
            return default(InheritedWidget);
        }


        /// <Summary>
        /// Obtains the nearest widget of the given type, which must be the type of a
        /// concrete [InheritedWidget] subclass, and registers this build context with
        /// that widget such that when that widget changes (or a new widget of that
        /// type is introduced, or the widget goes away), this build context is
        /// rebuilt so that it can obtain new values from that widget.
        ///
        /// This method is deprecated. Please use [dependOnInheritedWidgetOfExactType] instead.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(Type targetType, @Object aspect = default(@Object))
        {
            return default(InheritedWidget);
        }


        /// <Summary>
        /// Obtains the nearest widget of the given type [T], which must be the type of a
        /// concrete [InheritedWidget] subclass, and registers this build context with
        /// that widget such that when that widget changes (or a new widget of that
        /// type is introduced, or the widget goes away), this build context is
        /// rebuilt so that it can obtain new values from that widget.
        ///
        /// This is typically called implicitly from `of()` static methods, e.g.
        /// [Theme.of].
        ///
        /// This method should not be called from widget constructors or from
        /// [State.initState] methods, because those methods would not get called
        /// again if the inherited value were to change. To ensure that the widget
        /// correctly updates itself when the inherited value changes, only call this
        /// (directly or indirectly) from build methods, layout and paint callbacks, or
        /// from [State.didChangeDependencies].
        ///
        /// This method should not be called from [State.dispose] because the element
        /// tree is no longer stable at that time. To refer to an ancestor from that
        /// method, save a reference to the ancestor in [State.didChangeDependencies].
        /// It is safe to use this method from [State.deactivate], which is called
        /// whenever the widget is removed from the tree.
        ///
        /// It is also possible to call this method from interaction event handlers
        /// (e.g. gesture callbacks) or timers, to obtain a value once, if that value
        /// is not going to be cached and reused later.
        ///
        /// Calling this method is O(1) with a small constant factor, but will lead to
        /// the widget being rebuilt more often.
        ///
        /// Once a widget registers a dependency on a particular type by calling this
        /// method, it will be rebuilt, and [State.didChangeDependencies] will be
        /// called, whenever changes occur relating to that widget until the next time
        /// the widget or one of its ancestors is moved (for example, because an
        /// ancestor is added or removed).
        ///
        /// The [aspect] parameter is only used when [T] is an
        /// [InheritedWidget] subclasses that supports partial updates, like
        /// [InheritedModel]. It specifies what "aspect" of the inherited
        /// widget this context depends on.
        /// </Summary>
        public virtual T DependOnInheritedWidgetOfExactType<T>(@Object aspect = default(@Object))
        {
            return default(T);
        }


        /// <Summary>
        /// Obtains the element corresponding to the nearest widget of the given type,
        /// which must be the type of a concrete [InheritedWidget] subclass.
        ///
        /// This method is deprecated. Please use [getElementForInheritedWidgetOfExactType] instead.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(Type targetType)
        {
            return default(InheritedElement);
        }


        /// <Summary>
        /// Obtains the element corresponding to the nearest widget of the given type [T],
        /// which must be the type of a concrete [InheritedWidget] subclass.
        ///
        /// Returns null if no such element is found.
        ///
        /// Calling this method is O(1) with a small constant factor.
        ///
        /// This method does not establish a relationship with the target in the way
        /// that [dependOnInheritedWidgetOfExactType] does.
        ///
        /// This method should not be called from [State.dispose] because the element
        /// tree is no longer stable at that time. To refer to an ancestor from that
        /// method, save a reference to the ancestor by calling
        /// [dependOnInheritedWidgetOfExactType] in [State.didChangeDependencies]. It is
        /// safe to use this method from [State.deactivate], which is called whenever
        /// the widget is removed from the tree.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>()
        {
            return default(InheritedElement);
        }


        /// <Summary>
        /// Returns the nearest ancestor widget of the given type, which must be the
        /// type of a concrete [Widget] subclass.
        ///
        /// This method is deprecated. Please use [findAncestorWidgetOfExactType] instead.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(Type targetType)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Returns the nearest ancestor widget of the given type [T], which must be the
        /// type of a concrete [Widget] subclass.
        ///
        /// In general, [dependOnInheritedWidgetOfExactType] is more useful, since
        /// inherited widgets will trigger consumers to rebuild when they change. This
        /// method is appropriate when used in interaction event handlers (e.g.
        /// gesture callbacks) or for performing one-off tasks such as asserting that
        /// you have or don't have a widget of a specific type as an ancestor. The
        /// return value of a Widget's build method should not depend on the value
        /// returned by this method, because the build context will not rebuild if the
        /// return value of this method changes. This could lead to a situation where
        /// data used in the build method changes, but the widget is not rebuilt.
        ///
        /// Calling this method is relatively expensive (O(N) in the depth of the
        /// tree). Only call this method if the distance from this widget to the
        /// desired ancestor is known to be small and bounded.
        ///
        /// This method should not be called from [State.deactivate] or [State.dispose]
        /// because the widget tree is no longer stable at that time. To refer to
        /// an ancestor from one of those methods, save a reference to the ancestor
        /// by calling [findAncestorWidgetOfExactType] in [State.didChangeDependencies].
        ///
        /// Returns null if a widget of the requested type does not appear in the
        /// ancestors of this context.
        /// </Summary>
        public virtual T FindAncestorWidgetOfExactType<T>()
        {
            return default(T);
        }


        /// <Summary>
        /// Returns the [State] object of the nearest ancestor [StatefulWidget] widget
        /// that matches the given [TypeMatcher].
        ///
        /// This method is deprecated. Please use [findAncestorStateOfType] instead.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher)
        {
            return default(State);
        }


        /// <Summary>
        /// Returns the [State] object of the nearest ancestor [StatefulWidget] widget
        /// that is an instance of the given type [T].
        ///
        /// This should not be used from build methods, because the build context will
        /// not be rebuilt if the value that would be returned by this method changes.
        /// In general, [dependOnInheritedWidgetOfExactType] is more appropriate for such
        /// cases. This method is useful for changing the state of an ancestor widget in
        /// a one-off manner, for example, to cause an ancestor scrolling list to
        /// scroll this build context's widget into view, or to move the focus in
        /// response to user interaction.
        ///
        /// In general, though, consider using a callback that triggers a stateful
        /// change in the ancestor rather than using the imperative style implied by
        /// this method. This will usually lead to more maintainable and reusable code
        /// since it decouples widgets from each other.
        ///
        /// Calling this method is relatively expensive (O(N) in the depth of the
        /// tree). Only call this method if the distance from this widget to the
        /// desired ancestor is known to be small and bounded.
        ///
        /// This method should not be called from [State.deactivate] or [State.dispose]
        /// because the widget tree is no longer stable at that time. To refer to
        /// an ancestor from one of those methods, save a reference to the ancestor
        /// by calling [findAncestorStateOfType] in [State.didChangeDependencies].
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// ScrollableState scrollable = context.findAncestorStateOfType<ScrollableState>();
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual T FindAncestorStateOfType<T>()
        {
            return default(T);
        }


        /// <Summary>
        /// Returns the [State] object of the furthest ancestor [StatefulWidget] widget
        /// that matches the given [TypeMatcher].
        ///
        /// This method is deprecated. Please use [findRootAncestorStateOfType] instead.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher)
        {
            return default(State);
        }


        /// <Summary>
        /// Returns the [State] object of the furthest ancestor [StatefulWidget] widget
        /// that is an instance of the given type [T].
        ///
        /// Functions the same way as [findAncestorStateOfType] but keeps visiting subsequent
        /// ancestors until there are none of the type instance of [T] remaining.
        /// Then returns the last one found.
        ///
        /// This operation is O(N) as well though N is the entire widget tree rather than
        /// a subtree.
        /// </Summary>
        public virtual T FindRootAncestorStateOfType<T>()
        {
            return default(T);
        }


        /// <Summary>
        /// Returns the [RenderObject] object of the nearest ancestor [RenderObjectWidget] widget
        /// that matches the given [TypeMatcher].
        ///
        /// This method is deprecated. Please use [findAncestorRenderObjectOfType] instead.
        /// </Summary>
        public virtual FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher)
        {
            return default(RenderObject);
        }


        /// <Summary>
        /// Returns the [RenderObject] object of the nearest ancestor [RenderObjectWidget] widget
        /// that is an instance of the given type [T].
        ///
        /// This should not be used from build methods, because the build context will
        /// not be rebuilt if the value that would be returned by this method changes.
        /// In general, [dependOnInheritedWidgetOfExactType] is more appropriate for such
        /// cases. This method is useful only in esoteric cases where a widget needs
        /// to cause an ancestor to change its layout or paint behavior. For example,
        /// it is used by [Material] so that [InkWell] widgets can trigger the ink
        /// splash on the [Material]'s actual render object.
        ///
        /// Calling this method is relatively expensive (O(N) in the depth of the
        /// tree). Only call this method if the distance from this widget to the
        /// desired ancestor is known to be small and bounded.
        ///
        /// This method should not be called from [State.deactivate] or [State.dispose]
        /// because the widget tree is no longer stable at that time. To refer to
        /// an ancestor from one of those methods, save a reference to the ancestor
        /// by calling [findAncestorRenderObjectOfType] in [State.didChangeDependencies].
        /// </Summary>
        public virtual T FindAncestorRenderObjectOfType<T>()
        {
            return default(T);
        }


        /// <Summary>
        /// Walks the ancestor chain, starting with the parent of this build context's
        /// widget, invoking the argument for each ancestor. The callback is given a
        /// reference to the ancestor widget's corresponding [Element] object. The
        /// walk stops when it reaches the root widget or when the callback returns
        /// false. The callback must not return null.
        ///
        /// This is useful for inspecting the widget tree.
        ///
        /// Calling this method is relatively expensive (O(N) in the depth of the tree).
        ///
        /// This method should not be called from [State.deactivate] or [State.dispose]
        /// because the element tree is no longer stable at that time. To refer to
        /// an ancestor from one of those methods, save a reference to the ancestor
        /// by calling [visitAncestorElements] in [State.didChangeDependencies].
        /// </Summary>
        public virtual void VisitAncestorElements(Func<bool, Element> visitor)
        {
        }


        /// <Summary>
        /// Walks the children of this widget.
        ///
        /// This is useful for applying changes to children after they are built
        /// without waiting for the next frame, especially if the children are known,
        /// and especially if there is exactly one child (as is always the case for
        /// [StatefulWidget]s or [StatelessWidget]s).
        ///
        /// Calling this method is very cheap for build contexts that correspond to
        /// [StatefulWidget]s or [StatelessWidget]s (O(1), since there's only one
        /// child).
        ///
        /// Calling this method is potentially expensive for build contexts that
        /// correspond to [RenderObjectWidget]s (O(N) in the number of children).
        ///
        /// Calling this method recursively is extremely expensive (O(N) in the number
        /// of descendants), and should be avoided if possible. Generally it is
        /// significantly cheaper to use an [InheritedWidget] and have the descendants
        /// pull data down, than it is to use [visitChildElements] recursively to push
        /// data down to them.
        /// </Summary>
        public virtual void VisitChildElements(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
        }


        /// <Summary>
        /// Returns a description of an [Element] from the current build context.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return default(DiagnosticsNode);
        }


        /// <Summary>
        /// Returns a description of the [Widget] associated with the current build context.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return default(DiagnosticsNode);
        }


        /// <Summary>
        /// Adds a description of a specific type of widget missing from the current
        /// build context's ancestry tree.
        ///
        /// You can find an example of using this method in [debugCheckHasMaterial].
        /// </Summary>
        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(Type expectedAncestorType = default(Type))
        {
            return default(List<DiagnosticsNode>);
        }


        /// <Summary>
        /// Adds a description of the ownership chain from a specific [Element]
        /// to the error report.
        ///
        /// The ownership chain is useful for debugging the source of an element.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(string name)
        {
            return default(DiagnosticsNode);
        }

    }
    public static class BuildContextMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IBuildContext, BuildContext> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IBuildContext, BuildContext>();
        static BuildContext GetOrCreate(IBuildContext instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new BuildContext();
                _table.Add(instance, value);
            }
            return (BuildContext)value;
        }
        public static FlutterSDK.Widgets.Framework.Widget WidgetProperty(this IBuildContext instance) => GetOrCreate(instance).Widget;
        public static FlutterSDK.Widgets.Framework.BuildOwner OwnerProperty(this IBuildContext instance) => GetOrCreate(instance).Owner;
        public static bool DebugDoingBuildProperty(this IBuildContext instance) => GetOrCreate(instance).DebugDoingBuild;
        public static Size SizeProperty(this IBuildContext instance) => GetOrCreate(instance).Size;
        public static FlutterSDK.Rendering.@object.RenderObject FindRenderObject(this IBuildContext instance) => GetOrCreate(instance).FindRenderObject();
        public static FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(this IBuildContext instance, FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) => GetOrCreate(instance).InheritFromElement(ancestor, aspect);
        public static FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(this IBuildContext instance, FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) => GetOrCreate(instance).DependOnInheritedElement(ancestor, aspect);
        public static FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(this IBuildContext instance, Type targetType, @Object aspect = default(@Object)) => GetOrCreate(instance).InheritFromWidgetOfExactType(targetType, aspect);
        public static T DependOnInheritedWidgetOfExactType<T>(this IBuildContext instance, @Object aspect = default(@Object)) => GetOrCreate(instance).DependOnInheritedWidgetOfExactType<T>(aspect);
        public static FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(this IBuildContext instance, Type targetType) => GetOrCreate(instance).AncestorInheritedElementForWidgetOfExactType(targetType);
        public static FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>(this IBuildContext instance) => GetOrCreate(instance).GetElementForInheritedWidgetOfExactType<T>();
        public static FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(this IBuildContext instance, Type targetType) => GetOrCreate(instance).AncestorWidgetOfExactType(targetType);
        public static T FindAncestorWidgetOfExactType<T>(this IBuildContext instance) => GetOrCreate(instance).FindAncestorWidgetOfExactType<T>();
        public static FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(this IBuildContext instance, FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) => GetOrCreate(instance).AncestorStateOfType(matcher);
        public static T FindAncestorStateOfType<T>(this IBuildContext instance) => GetOrCreate(instance).FindAncestorStateOfType<T>();
        public static FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(this IBuildContext instance, FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) => GetOrCreate(instance).RootAncestorStateOfType(matcher);
        public static T FindRootAncestorStateOfType<T>(this IBuildContext instance) => GetOrCreate(instance).FindRootAncestorStateOfType<T>();
        public static FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(this IBuildContext instance, FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) => GetOrCreate(instance).AncestorRenderObjectOfType(matcher);
        public static T FindAncestorRenderObjectOfType<T>(this IBuildContext instance) => GetOrCreate(instance).FindAncestorRenderObjectOfType<T>();
        public static void VisitAncestorElements(this IBuildContext instance, Func<bool, Element> visitor) => GetOrCreate(instance).VisitAncestorElements(visitor);
        public static void VisitChildElements(this IBuildContext instance, FlutterSDK.Widgets.Framework.ElementVisitor visitor) => GetOrCreate(instance).VisitChildElements(visitor);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(this IBuildContext instance, string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).DescribeElement(name, style);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(this IBuildContext instance, string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).DescribeWidget(name, style);
        public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(this IBuildContext instance, Type expectedAncestorType = default(Type)) => GetOrCreate(instance).DescribeMissingAncestor(expectedAncestorType);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(this IBuildContext instance, string name) => GetOrCreate(instance).DescribeOwnershipChain(name);
    }


    /// <Summary>
    /// A key that is only equal to itself.
    ///
    /// This cannot be created with a const constructor because that implies that
    /// all instantiated keys would be the same instance and therefore not be unique.
    /// </Summary>
    public class UniqueKey : FlutterSDK.Foundation.Key.LocalKey
    {
        public UniqueKey()
        {

        }

    }


    /// <Summary>
    /// A key that takes its identity from the object used as its value.
    ///
    /// Used to tie the identity of a widget to the identity of an object used to
    /// generate that widget.
    ///
    /// See also:
    ///
    ///  * [Key], the base class for all keys.
    ///  * The discussion at [Widget.key] for more information about how widgets use
    ///    keys.
    /// </Summary>
    public class ObjectKey : FlutterSDK.Foundation.Key.LocalKey
    {
        public ObjectKey(@Object value)
        {
            this.Value = value;
        }
        public virtual @Object Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is ObjectKey && Dart:coreDefaultClass.Identical(other.Value, Value);
        }




    }


    /// <Summary>
    /// A key that is unique across the entire app.
    ///
    /// Global keys uniquely identify elements. Global keys provide access to other
    /// objects that are associated with those elements, such as [BuildContext].
    /// For [StatefulWidget]s, global keys also provide access to [State].
    ///
    /// Widgets that have global keys reparent their subtrees when they are moved
    /// from one location in the tree to another location in the tree. In order to
    /// reparent its subtree, a widget must arrive at its new location in the tree
    /// in the same animation frame in which it was removed from its old location in
    /// the tree.
    ///
    /// Global keys are relatively expensive. If you don't need any of the features
    /// listed above, consider using a [Key], [ValueKey], [ObjectKey], or
    /// [UniqueKey] instead.
    ///
    /// You cannot simultaneously include two widgets in the tree with the same
    /// global key. Attempting to do so will assert at runtime.
    ///
    /// See also:
    ///
    ///  * The discussion at [Widget.key] for more information about how widgets use
    ///    keys.
    /// </Summary>
    public class GlobalKey<T> : FlutterSDK.Foundation.Key.Key
    {
        public GlobalKey(string debugLabel = default(string))
        {
            new LabeledGlobalKey<T>(debugLabel);

            public static GlobalKey<T> Constructor()
            {
                var instance = new GlobalKey<T>();
            }
internal virtual Dictionary<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>, FlutterSDK.Widgets.Framework.Element> _Registry { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _DebugIllFatedElements { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.Element, Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>>> _DebugReservations { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _CurrentElement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext CurrentContext { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget CurrentWidget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual T CurrentState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _DebugRemoveReservationFor(FlutterSDK.Widgets.Framework.Element parent, FlutterSDK.Widgets.Framework.Element child)
        {

        }




        private void _Register(FlutterSDK.Widgets.Framework.Element element)
        {

            _Registry[this] = element;
        }




        private void _Unregister(FlutterSDK.Widgets.Framework.Element element)
        {

            if (_Registry[this] == element) _Registry.Remove(this);
        }




        private void _DebugReserveFor(FlutterSDK.Widgets.Framework.Element parent, FlutterSDK.Widgets.Framework.Element child)
        {

        }




        private void _DebugVerifyGlobalKeyReservation()
        {

        }




        private void _DebugVerifyIllFatedPopulation()
        {

        }



    }


    /// <Summary>
    /// A global key with a debugging label.
    ///
    /// The debug label is useful for documentation and for debugging. The label
    /// does not affect the key's identity.
    /// </Summary>
    public class LabeledGlobalKey<T> : FlutterSDK.Widgets.Framework.GlobalKey<T>
    {
        public LabeledGlobalKey(string _debugLabel)
        : base()
        {
            this._DebugLabel = _debugLabel;
        }
        internal virtual string _DebugLabel { get; set; }

    }


    /// <Summary>
    /// A global key that takes its identity from the object used as its value.
    ///
    /// Used to tie the identity of a widget to the identity of an object used to
    /// generate that widget.
    ///
    /// If the object is not private, then it is possible that collisions will occur
    /// where independent widgets will reuse the same object as their
    /// [GlobalObjectKey] value in a different part of the tree, leading to a global
    /// key conflict. To avoid this problem, create a private [GlobalObjectKey]
    /// subclass, as in:
    ///
    /// ```dart
    /// class _MyKey extends GlobalObjectKey {
    ///   const _MyKey(Object value) : super(value);
    /// }
    /// ```
    ///
    /// Since the [runtimeType] of the key is part of its identity, this will
    /// prevent clashes with other [GlobalObjectKey]s even if they have the same
    /// value.
    ///
    /// Any [GlobalObjectKey] created for the same value will match.
    /// </Summary>
    public class GlobalObjectKey<T> : FlutterSDK.Widgets.Framework.GlobalKey<T>
    {
        public GlobalObjectKey(@Object value)
        : base()
        {
            this.Value = value;
        }
        public virtual @Object Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is GlobalObjectKey<T> && Dart:coreDefaultClass.Identical(other.Value, Value);
        }




    }


    /// <Summary>
    /// This class is a work-around for the "is" operator not accepting a variable value as its right operand.
    ///
    /// This class is deprecated. It will be deleted soon.
    /// </Summary>
    public class TypeMatcher<T>
    {
        public TypeMatcher()
        {

        }

        /// <Summary>
        /// Returns true if the given object is of type `T`.
        /// </Summary>
        public virtual bool Check(object @object) => object is T;


    }


    /// <Summary>
    /// Describes the configuration for an [Element].
    ///
    /// Widgets are the central class hierarchy in the Flutter framework. A widget
    /// is an immutable description of part of a user interface. Widgets can be
    /// inflated into elements, which manage the underlying render tree.
    ///
    /// Widgets themselves have no mutable state (all their fields must be final).
    /// If you wish to associate mutable state with a widget, consider using a
    /// [StatefulWidget], which creates a [State] object (via
    /// [StatefulWidget.createState]) whenever it is inflated into an element and
    /// incorporated into the tree.
    ///
    /// A given widget can be included in the tree zero or more times. In particular
    /// a given widget can be placed in the tree multiple times. Each time a widget
    /// is placed in the tree, it is inflated into an [Element], which means a
    /// widget that is incorporated into the tree multiple times will be inflated
    /// multiple times.
    ///
    /// The [key] property controls how one widget replaces another widget in the
    /// tree. If the [runtimeType] and [key] properties of the two widgets are
    /// [operator==], respectively, then the new widget replaces the old widget by
    /// updating the underlying element (i.e., by calling [Element.update] with the
    /// new widget). Otherwise, the old element is removed from the tree, the new
    /// widget is inflated into an element, and the new element is inserted into the
    /// tree.
    ///
    /// See also:
    ///
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    /// </Summary>
    public class Widget : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
    {
        public Widget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        {
            this.Key = key;
        }
        public virtual FlutterSDK.Foundation.Key.Key Key { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Inflates this configuration to a concrete instance.
        ///
        /// A given widget can be included in the tree zero or more times. In particular
        /// a given widget can be placed in the tree multiple times. Each time a widget
        /// is placed in the tree, it is inflated into an [Element], which means a
        /// widget that is incorporated into the tree multiple times will be inflated
        /// multiple times.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Element CreateElement()
        {
            return default(Element);
        }


        /// <Summary>
        /// A short, textual description of this widget.
        /// </Summary>
        public new string ToStringShort()
        {
            string type = ObjectDefaultClass.ObjectRuntimeType(this, "Widget");
            return Key == null ? type : $"'{type}-{Key}'";
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.DefaultDiagnosticsTreeStyle = DiagnosticsTreeStyle.Dense;
        }




        public new bool Equals(@Object other) => base == other;



        /// <Summary>
        /// Whether the `newWidget` can be used to update an [Element] that currently
        /// has the `oldWidget` as its configuration.
        ///
        /// An element that uses a given widget as its configuration can be updated to
        /// use another widget as its configuration if, and only if, the two widgets
        /// have [runtimeType] and [key] properties that are [operator==].
        ///
        /// If the widgets have no key (their key is null), then they are considered a
        /// match if they have the same type, even if their children are completely
        /// different.
        /// </Summary>
        public virtual bool CanUpdate(FlutterSDK.Widgets.Framework.Widget oldWidget, FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            return oldWidget.GetType() == newWidget.GetType() && oldWidget.Key == newWidget.Key;
        }




        private int _DebugConcreteSubtype(FlutterSDK.Widgets.Framework.Widget widget)
        {
            return widget is StatefulWidget ? 1 : widget is StatelessWidget ? 2 : 0;
        }



    }


    /// <Summary>
    /// A widget that does not require mutable state.
    ///
    /// A stateless widget is a widget that describes part of the user interface by
    /// building a constellation of other widgets that describe the user interface
    /// more concretely. The building process continues recursively until the
    /// description of the user interface is fully concrete (e.g., consists
    /// entirely of [RenderObjectWidget]s, which describe concrete [RenderObject]s).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=wE7khGHVkYY}
    ///
    /// Stateless widget are useful when the part of the user interface you are
    /// describing does not depend on anything other than the configuration
    /// information in the object itself and the [BuildContext] in which the widget
    /// is inflated. For compositions that can change dynamically, e.g. due to
    /// having an internal clock-driven state, or depending on some system state,
    /// consider using [StatefulWidget].
    ///
    /// ## Performance considerations
    ///
    /// The [build] method of a stateless widget is typically only called in three
    /// situations: the first time the widget is inserted in the tree, when the
    /// widget's parent changes its configuration, and when an [InheritedWidget] it
    /// depends on changes.
    ///
    /// If a widget's parent will regularly change the widget's configuration, or if
    /// it depends on inherited widgets that frequently change, then it is important
    /// to optimize the performance of the [build] method to maintain a fluid
    /// rendering performance.
    ///
    /// There are several techniques one can use to minimize the impact of
    /// rebuilding a stateless widget:
    ///
    ///  * Minimize the number of nodes transitively created by the build method and
    ///    any widgets it creates. For example, instead of an elaborate arrangement
    ///    of [Row]s, [Column]s, [Padding]s, and [SizedBox]es to position a single
    ///    child in a particularly fancy manner, consider using just an [Align] or a
    ///    [CustomSingleChildLayout]. Instead of an intricate layering of multiple
    ///    [Container]s and with [Decoration]s to draw just the right graphical
    ///    effect, consider a single [CustomPaint] widget.
    ///
    ///  * Use `const` widgets where possible, and provide a `const` constructor for
    ///    the widget so that users of the widget can also do so.
    ///
    ///  * Consider refactoring the stateless widget into a stateful widget so that
    ///    it can use some of the techniques described at [StatefulWidget], such as
    ///    caching common parts of subtrees and using [GlobalKey]s when changing the
    ///    tree structure.
    ///
    ///  * If the widget is likely to get rebuilt frequently due to the use of
    ///    [InheritedWidget]s, consider refactoring the stateless widget into
    ///    multiple widgets, with the parts of the tree that change being pushed to
    ///    the leaves. For example instead of building a tree with four widgets, the
    ///    inner-most widget depending on the [Theme], consider factoring out the
    ///    part of the build function that builds the inner-most widget into its own
    ///    widget, so that only the inner-most widget needs to be rebuilt when the
    ///    theme changes.
    ///
    /// {@tool snippet}
    ///
    /// The following is a skeleton of a stateless widget subclass called `GreenFrog`.
    ///
    /// Normally, widgets have more constructor arguments, each of which corresponds
    /// to a `final` property.
    ///
    /// ```dart
    /// class GreenFrog extends StatelessWidget {
    ///   const GreenFrog({ Key key }) : super(key: key);
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(color: const Color(0xFF2DBD3A));
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    ///
    /// This next example shows the more generic widget `Frog` which can be given
    /// a color and a child:
    ///
    /// ```dart
    /// class Frog extends StatelessWidget {
    ///   const Frog({
    ///     Key key,
    ///     this.color = const Color(0xFF2DBD3A),
    ///     this.child,
    ///   }) : super(key: key);
    ///
    ///   final Color color;
    ///   final Widget child;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(color: color, child: child);
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// By convention, widget constructors only use named arguments. Named arguments
    /// can be marked as required using [@required]. Also by convention, the first
    /// argument is [key], and the last argument is `child`, `children`, or the
    /// equivalent.
    ///
    /// See also:
    ///
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    /// </Summary>
    public class StatelessWidget : FlutterSDK.Widgets.Framework.Widget
    {
        public StatelessWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {

        }

        /// <Summary>
        /// Creates a [StatelessElement] to manage this widget's location in the tree.
        ///
        /// It is uncommon for subclasses to override this method.
        /// </Summary>
        public new FlutterSDK.Widgets.Framework.StatelessElement CreateElement() => new StatelessElement(this);



        /// <Summary>
        /// Describes the part of the user interface represented by this widget.
        ///
        /// The framework calls this method when this widget is inserted into the
        /// tree in a given [BuildContext] and when the dependencies of this widget
        /// change (e.g., an [InheritedWidget] referenced by this widget changes).
        ///
        /// The framework replaces the subtree below this widget with the widget
        /// returned by this method, either by updating the existing subtree or by
        /// removing the subtree and inflating a new subtree, depending on whether the
        /// widget returned by this method can update the root of the existing
        /// subtree, as determined by calling [Widget.canUpdate].
        ///
        /// Typically implementations return a newly created constellation of widgets
        /// that are configured with information from this widget's constructor and
        /// from the given [BuildContext].
        ///
        /// The given [BuildContext] contains information about the location in the
        /// tree at which this widget is being built. For example, the context
        /// provides the set of inherited widgets for this location in the tree. A
        /// given widget might be built with multiple different [BuildContext]
        /// arguments over time if the widget is moved around the tree or if the
        /// widget is inserted into the tree in multiple places at once.
        ///
        /// The implementation of this method must only depend on:
        ///
        /// * the fields of the widget, which themselves must not change over time,
        ///   and
        /// * any ambient state obtained from the `context` using
        ///   [BuildContext.dependOnInheritedWidgetOfExactType].
        ///
        /// If a widget's [build] method is to depend on anything else, use a
        /// [StatefulWidget] instead.
        ///
        /// See also:
        ///
        ///  * [StatelessWidget], which contains the discussion on performance considerations.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Widget);
        }

    }


    /// <Summary>
    /// A widget that has mutable state.
    ///
    /// State is information that (1) can be read synchronously when the widget is
    /// built and (2) might change during the lifetime of the widget. It is the
    /// responsibility of the widget implementer to ensure that the [State] is
    /// promptly notified when such state changes, using [State.setState].
    ///
    /// A stateful widget is a widget that describes part of the user interface by
    /// building a constellation of other widgets that describe the user interface
    /// more concretely. The building process continues recursively until the
    /// description of the user interface is fully concrete (e.g., consists
    /// entirely of [RenderObjectWidget]s, which describe concrete [RenderObject]s).
    ///
    /// Stateful widgets are useful when the part of the user interface you are
    /// describing can change dynamically, e.g. due to having an internal
    /// clock-driven state, or depending on some system state. For compositions that
    /// depend only on the configuration information in the object itself and the
    /// [BuildContext] in which the widget is inflated, consider using
    /// [StatelessWidget].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=AqCMFXEmf3w}
    ///
    /// [StatefulWidget] instances themselves are immutable and store their mutable
    /// state either in separate [State] objects that are created by the
    /// [createState] method, or in objects to which that [State] subscribes, for
    /// example [Stream] or [ChangeNotifier] objects, to which references are stored
    /// in final fields on the [StatefulWidget] itself.
    ///
    /// The framework calls [createState] whenever it inflates a
    /// [StatefulWidget], which means that multiple [State] objects might be
    /// associated with the same [StatefulWidget] if that widget has been inserted
    /// into the tree in multiple places. Similarly, if a [StatefulWidget] is
    /// removed from the tree and later inserted in to the tree again, the framework
    /// will call [createState] again to create a fresh [State] object, simplifying
    /// the lifecycle of [State] objects.
    ///
    /// A [StatefulWidget] keeps the same [State] object when moving from one
    /// location in the tree to another if its creator used a [GlobalKey] for its
    /// [key]. Because a widget with a [GlobalKey] can be used in at most one
    /// location in the tree, a widget that uses a [GlobalKey] has at most one
    /// associated element. The framework takes advantage of this property when
    /// moving a widget with a global key from one location in the tree to another
    /// by grafting the (unique) subtree associated with that widget from the old
    /// location to the new location (instead of recreating the subtree at the new
    /// location). The [State] objects associated with [StatefulWidget] are grafted
    /// along with the rest of the subtree, which means the [State] object is reused
    /// (instead of being recreated) in the new location. However, in order to be
    /// eligible for grafting, the widget must be inserted into the new location in
    /// the same animation frame in which it was removed from the old location.
    ///
    /// ## Performance considerations
    ///
    /// There are two primary categories of [StatefulWidget]s.
    ///
    /// The first is one which allocates resources in [State.initState] and disposes
    /// of them in [State.dispose], but which does not depend on [InheritedWidget]s
    /// or call [State.setState]. Such widgets are commonly used at the root of an
    /// application or page, and communicate with subwidgets via [ChangeNotifier]s,
    /// [Stream]s, or other such objects. Stateful widgets following such a pattern
    /// are relatively cheap (in terms of CPU and GPU cycles), because they are
    /// built once then never update. They can, therefore, have somewhat complicated
    /// and deep build methods.
    ///
    /// The second category is widgets that use [State.setState] or depend on
    /// [InheritedWidget]s. These will typically rebuild many times during the
    /// application's lifetime, and it is therefore important to minimize the impact
    /// of rebuilding such a widget. (They may also use [State.initState] or
    /// [State.didChangeDependencies] and allocate resources, but the important part
    /// is that they rebuild.)
    ///
    /// There are several techniques one can use to minimize the impact of
    /// rebuilding a stateful widget:
    ///
    ///  * Push the state to the leaves. For example, if your page has a ticking
    ///    clock, rather than putting the state at the top of the page and
    ///    rebuilding the entire page each time the clock ticks, create a dedicated
    ///    clock widget that only updates itself.
    ///
    ///  * Minimize the number of nodes transitively created by the build method and
    ///    any widgets it creates. Ideally, a stateful widget would only create a
    ///    single widget, and that widget would be a [RenderObjectWidget].
    ///    (Obviously this isn't always practical, but the closer a widget gets to
    ///    this ideal, the more efficient it will be.)
    ///
    ///  * If a subtree does not change, cache the widget that represents that
    ///    subtree and re-use it each time it can be used. It is massively more
    ///    efficient for a widget to be re-used than for a new (but
    ///    identically-configured) widget to be created. Factoring out the stateful
    ///    part into a widget that takes a child argument is a common way of doing
    ///    this.
    ///
    ///  * Use `const` widgets where possible. (This is equivalent to caching a
    ///    widget and re-using it.)
    ///
    ///  * Avoid changing the depth of any created subtrees or changing the type of
    ///    any widgets in the subtree. For example, rather than returning either the
    ///    child or the child wrapped in an [IgnorePointer], always wrap the child
    ///    widget in an [IgnorePointer] and control the [IgnorePointer.ignoring]
    ///    property. This is because changing the depth of the subtree requires
    ///    rebuilding, laying out, and painting the entire subtree, whereas just
    ///    changing the property will require the least possible change to the
    ///    render tree (in the case of [IgnorePointer], for example, no layout or
    ///    repaint is necessary at all).
    ///
    ///  * If the depth must be changed for some reason, consider wrapping the
    ///    common parts of the subtrees in widgets that have a [GlobalKey] that
    ///    remains consistent for the life of the stateful widget. (The
    ///    [KeyedSubtree] widget may be useful for this purpose if no other widget
    ///    can conveniently be assigned the key.)
    ///
    /// {@tool snippet}
    ///
    /// This is a skeleton of a stateful widget subclass called `YellowBird`.
    ///
    /// In this example. the [State] has no actual state. State is normally
    /// represented as private member fields. Also, normally widgets have more
    /// constructor arguments, each of which corresponds to a `final` property.
    ///
    /// ```dart
    /// class YellowBird extends StatefulWidget {
    ///   const YellowBird({ Key key }) : super(key: key);
    ///
    ///   @override
    ///   _YellowBirdState createState() => _YellowBirdState();
    /// }
    ///
    /// class _YellowBirdState extends State<YellowBird> {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(color: const Color(0xFFFFE306));
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// This example shows the more generic widget `Bird` which can be given a
    /// color and a child, and which has some internal state with a method that
    /// can be called to mutate it:
    ///
    /// ```dart
    /// class Bird extends StatefulWidget {
    ///   const Bird({
    ///     Key key,
    ///     this.color = const Color(0xFFFFE306),
    ///     this.child,
    ///   }) : super(key: key);
    ///
    ///   final Color color;
    ///   final Widget child;
    ///
    ///   _BirdState createState() => _BirdState();
    /// }
    ///
    /// class _BirdState extends State<Bird> {
    ///   double _size = 1.0;
    ///
    ///   void grow() {
    ///     setState(() { _size += 0.1; });
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(
    ///       color: widget.color,
    ///       transform: Matrix4.diagonal3Values(_size, _size, 1.0),
    ///       child: widget.child,
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// By convention, widget constructors only use named arguments. Named arguments
    /// can be marked as required using [@required]. Also by convention, the first
    /// argument is [key], and the last argument is `child`, `children`, or the
    /// equivalent.
    ///
    /// See also:
    ///
    ///  * [State], where the logic behind a [StatefulWidget] is hosted.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    /// </Summary>
    public class StatefulWidget : FlutterSDK.Widgets.Framework.Widget
    {
        public StatefulWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {

        }

        /// <Summary>
        /// Creates a [StatefulElement] to manage this widget's location in the tree.
        ///
        /// It is uncommon for subclasses to override this method.
        /// </Summary>
        public new FlutterSDK.Widgets.Framework.StatefulElement CreateElement() => new StatefulElement(this);



        /// <Summary>
        /// Creates the mutable state for this widget at a given location in the tree.
        ///
        /// Subclasses should override this method to return a newly created
        /// instance of their associated [State] subclass:
        ///
        /// ```dart
        /// @override
        /// _MyState createState() => _MyState();
        /// ```
        ///
        /// The framework can call this method multiple times over the lifetime of
        /// a [StatefulWidget]. For example, if the widget is inserted into the tree
        /// in multiple locations, the framework will create a separate [State] object
        /// for each location. Similarly, if the widget is removed from the tree and
        /// later inserted into the tree again, the framework will call [createState]
        /// again to create a fresh [State] object, simplifying the lifecycle of
        /// [State] objects.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState()
        {
            return default(State);
        }

    }


    /// <Summary>
    /// The logic and internal state for a [StatefulWidget].
    ///
    /// State is information that (1) can be read synchronously when the widget is
    /// built and (2) might change during the lifetime of the widget. It is the
    /// responsibility of the widget implementer to ensure that the [State] is
    /// promptly notified when such state changes, using [State.setState].
    ///
    /// [State] objects are created by the framework by calling the
    /// [StatefulWidget.createState] method when inflating a [StatefulWidget] to
    /// insert it into the tree. Because a given [StatefulWidget] instance can be
    /// inflated multiple times (e.g., the widget is incorporated into the tree in
    /// multiple places at once), there might be more than one [State] object
    /// associated with a given [StatefulWidget] instance. Similarly, if a
    /// [StatefulWidget] is removed from the tree and later inserted in to the tree
    /// again, the framework will call [StatefulWidget.createState] again to create
    /// a fresh [State] object, simplifying the lifecycle of [State] objects.
    ///
    /// [State] objects have the following lifecycle:
    ///
    ///  * The framework creates a [State] object by calling
    ///    [StatefulWidget.createState].
    ///  * The newly created [State] object is associated with a [BuildContext].
    ///    This association is permanent: the [State] object will never change its
    ///    [BuildContext]. However, the [BuildContext] itself can be moved around
    ///    the tree along with its subtree. At this point, the [State] object is
    ///    considered [mounted].
    ///  * The framework calls [initState]. Subclasses of [State] should override
    ///    [initState] to perform one-time initialization that depends on the
    ///    [BuildContext] or the widget, which are available as the [context] and
    ///    [widget] properties, respectively, when the [initState] method is
    ///    called.
    ///  * The framework calls [didChangeDependencies]. Subclasses of [State] should
    ///    override [didChangeDependencies] to perform initialization involving
    ///    [InheritedWidget]s. If [BuildContext.dependOnInheritedWidgetOfExactType] is
    ///    called, the [didChangeDependencies] method will be called again if the
    ///    inherited widgets subsequently change or if the widget moves in the tree.
    ///  * At this point, the [State] object is fully initialized and the framework
    ///    might call its [build] method any number of times to obtain a
    ///    description of the user interface for this subtree. [State] objects can
    ///    spontaneously request to rebuild their subtree by callings their
    ///    [setState] method, which indicates that some of their internal state
    ///    has changed in a way that might impact the user interface in this
    ///    subtree.
    ///  * During this time, a parent widget might rebuild and request that this
    ///    location in the tree update to display a new widget with the same
    ///    [runtimeType] and [Widget.key]. When this happens, the framework will
    ///    update the [widget] property to refer to the new widget and then call the
    ///    [didUpdateWidget] method with the previous widget as an argument. [State]
    ///    objects should override [didUpdateWidget] to respond to changes in their
    ///    associated widget (e.g., to start implicit animations). The framework
    ///    always calls [build] after calling [didUpdateWidget], which means any
    ///    calls to [setState] in [didUpdateWidget] are redundant.
    ///  * During development, if a hot reload occurs (whether initiated from the
    ///    command line `flutter` tool by pressing `r`, or from an IDE), the
    ///    [reassemble] method is called. This provides an opportunity to
    ///    reinitialize any data that was prepared in the [initState] method.
    ///  * If the subtree containing the [State] object is removed from the tree
    ///    (e.g., because the parent built a widget with a different [runtimeType]
    ///    or [Widget.key]), the framework calls the [deactivate] method. Subclasses
    ///    should override this method to clean up any links between this object
    ///    and other elements in the tree (e.g. if you have provided an ancestor
    ///    with a pointer to a descendant's [RenderObject]).
    ///  * At this point, the framework might reinsert this subtree into another
    ///    part of the tree. If that happens, the framework will ensure that it
    ///    calls [build] to give the [State] object a chance to adapt to its new
    ///    location in the tree. If the framework does reinsert this subtree, it
    ///    will do so before the end of the animation frame in which the subtree was
    ///    removed from the tree. For this reason, [State] objects can defer
    ///    releasing most resources until the framework calls their [dispose]
    ///    method.
    ///  * If the framework does not reinsert this subtree by the end of the current
    ///    animation frame, the framework will call [dispose], which indicates that
    ///    this [State] object will never build again. Subclasses should override
    ///    this method to release any resources retained by this object (e.g.,
    ///    stop any active animations).
    ///  * After the framework calls [dispose], the [State] object is considered
    ///    unmounted and the [mounted] property is false. It is an error to call
    ///    [setState] at this point. This stage of the lifecycle is terminal: there
    ///    is no way to remount a [State] object that has been disposed.
    ///
    /// See also:
    ///
    ///  * [StatefulWidget], where the current configuration of a [State] is hosted,
    ///    and whose documentation has sample code for [State].
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    ///  * [Widget], for an overview of widgets in general.
    /// </Summary>
    public class State<T> : IDiagnosticable
    {
        public State()
        { }
        internal virtual T _Widget { get; set; }
        internal virtual FlutterSDK.Widgets.Framework._StateLifecycle _DebugLifecycleState { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.StatefulElement _Element { get; set; }
        public virtual T Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Mounted { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Verifies that the [State] that was created is one that expects to be
        /// created for that particular [Widget].
        /// </Summary>
        private bool _DebugTypesAreRight(FlutterSDK.Widgets.Framework.Widget widget) => widget is T;



        /// <Summary>
        /// Called when this object is inserted into the tree.
        ///
        /// The framework will call this method exactly once for each [State] object
        /// it creates.
        ///
        /// Override this method to perform initialization that depends on the
        /// location at which this object was inserted into the tree (i.e., [context])
        /// or on the widget used to configure this object (i.e., [widget]).
        ///
        /// {@template flutter.widgets.subscriptions}
        /// If a [State]'s [build] method depends on an object that can itself
        /// change state, for example a [ChangeNotifier] or [Stream], or some
        /// other object to which one can subscribe to receive notifications, then
        /// be sure to subscribe and unsubscribe properly in [initState],
        /// [didUpdateWidget], and [dispose]:
        ///
        ///  * In [initState], subscribe to the object.
        ///  * In [didUpdateWidget] unsubscribe from the old object and subscribe
        ///    to the new one if the updated widget configuration requires
        ///    replacing the object.
        ///  * In [dispose], unsubscribe from the object.
        ///
        /// {@endtemplate}
        ///
        /// You cannot use [BuildContext.dependOnInheritedWidgetOfExactType] from this
        /// method. However, [didChangeDependencies] will be called immediately
        /// following this method, and [BuildContext.dependOnInheritedWidgetOfExactType] can
        /// be used there.
        ///
        /// If you override this, make sure your method starts with a call to
        /// super.initState().
        /// </Summary>
        public virtual void InitState()
        {

        }




        /// <Summary>
        /// Called whenever the widget configuration changes.
        ///
        /// If the parent widget rebuilds and request that this location in the tree
        /// update to display a new widget with the same [runtimeType] and
        /// [Widget.key], the framework will update the [widget] property of this
        /// [State] object to refer to the new widget and then call this method
        /// with the previous widget as an argument.
        ///
        /// Override this method to respond when the [widget] changes (e.g., to start
        /// implicit animations).
        ///
        /// The framework always calls [build] after calling [didUpdateWidget], which
        /// means any calls to [setState] in [didUpdateWidget] are redundant.
        ///
        /// {@macro flutter.widgets.subscriptions}
        ///
        /// If you override this, make sure your method starts with a call to
        /// super.didUpdateWidget(oldWidget).
        /// </Summary>
        public virtual void DidUpdateWidget(T oldWidget)
        {
        }




        /// <Summary>
        /// {@macro flutter.widgets.reassemble}
        ///
        /// In addition to this method being invoked, it is guaranteed that the
        /// [build] method will be invoked when a reassemble is signaled. Most
        /// widgets therefore do not need to do anything in the [reassemble] method.
        ///
        /// See also:
        ///
        ///  * [Element.reassemble]
        ///  * [BindingBase.reassembleApplication]
        ///  * [Image], which uses this to reload images.
        /// </Summary>
        public virtual void Reassemble()
        {
        }




        /// <Summary>
        /// Notify the framework that the internal state of this object has changed.
        ///
        /// Whenever you change the internal state of a [State] object, make the
        /// change in a function that you pass to [setState]:
        ///
        /// ```dart
        /// setState(() { _myState = newValue; });
        /// ```
        ///
        /// The provided callback is immediately called synchronously. It must not
        /// return a future (the callback cannot be `async`), since then it would be
        /// unclear when the state was actually being set.
        ///
        /// Calling [setState] notifies the framework that the internal state of this
        /// object has changed in a way that might impact the user interface in this
        /// subtree, which causes the framework to schedule a [build] for this [State]
        /// object.
        ///
        /// If you just change the state directly without calling [setState], the
        /// framework might not schedule a [build] and the user interface for this
        /// subtree might not be updated to reflect the new state.
        ///
        /// Generally it is recommended that the `setState` method only be used to
        /// wrap the actual changes to the state, not any computation that might be
        /// associated with the change. For example, here a value used by the [build]
        /// function is incremented, and then the change is written to disk, but only
        /// the increment is wrapped in the `setState`:
        ///
        /// ```dart
        /// Future<void> _incrementCounter() async {
        ///   setState(() {
        ///     _counter++;
        ///   });
        ///   Directory directory = await getApplicationDocumentsDirectory();
        ///   final String dirName = directory.path;
        ///   await File('$dir/counter.txt').writeAsString('$_counter');
        /// }
        /// ```
        ///
        /// It is an error to call this method after the framework calls [dispose].
        /// You can determine whether it is legal to call this method by checking
        /// whether the [mounted] property is true.
        /// </Summary>
        public virtual void SetState(VoidCallback fn)
        {


            object result = fn() as object;

            _Element.MarkNeedsBuild();
        }




        /// <Summary>
        /// Called when this object is removed from the tree.
        ///
        /// The framework calls this method whenever it removes this [State] object
        /// from the tree. In some cases, the framework will reinsert the [State]
        /// object into another part of the tree (e.g., if the subtree containing this
        /// [State] object is grafted from one location in the tree to another). If
        /// that happens, the framework will ensure that it calls [build] to give the
        /// [State] object a chance to adapt to its new location in the tree. If
        /// the framework does reinsert this subtree, it will do so before the end of
        /// the animation frame in which the subtree was removed from the tree. For
        /// this reason, [State] objects can defer releasing most resources until the
        /// framework calls their [dispose] method.
        ///
        /// Subclasses should override this method to clean up any links between
        /// this object and other elements in the tree (e.g. if you have provided an
        /// ancestor with a pointer to a descendant's [RenderObject]).
        ///
        /// If you override this, make sure to end your method with a call to
        /// super.deactivate().
        ///
        /// See also:
        ///
        ///  * [dispose], which is called after [deactivate] if the widget is removed
        ///    from the tree permanently.
        /// </Summary>
        public virtual void Deactivate()
        {
        }




        /// <Summary>
        /// Called when this object is removed from the tree permanently.
        ///
        /// The framework calls this method when this [State] object will never
        /// build again. After the framework calls [dispose], the [State] object is
        /// considered unmounted and the [mounted] property is false. It is an error
        /// to call [setState] at this point. This stage of the lifecycle is terminal:
        /// there is no way to remount a [State] object that has been disposed.
        ///
        /// Subclasses should override this method to release any resources retained
        /// by this object (e.g., stop any active animations).
        ///
        /// {@macro flutter.widgets.subscriptions}
        ///
        /// If you override this, make sure to end your method with a call to
        /// super.dispose().
        ///
        /// See also:
        ///
        ///  * [deactivate], which is called prior to [dispose].
        /// </Summary>
        public virtual void Dispose()
        {


        }




        /// <Summary>
        /// Describes the part of the user interface represented by this widget.
        ///
        /// The framework calls this method in a number of different situations:
        ///
        ///  * After calling [initState].
        ///  * After calling [didUpdateWidget].
        ///  * After receiving a call to [setState].
        ///  * After a dependency of this [State] object changes (e.g., an
        ///    [InheritedWidget] referenced by the previous [build] changes).
        ///  * After calling [deactivate] and then reinserting the [State] object into
        ///    the tree at another location.
        ///
        /// The framework replaces the subtree below this widget with the widget
        /// returned by this method, either by updating the existing subtree or by
        /// removing the subtree and inflating a new subtree, depending on whether the
        /// widget returned by this method can update the root of the existing
        /// subtree, as determined by calling [Widget.canUpdate].
        ///
        /// Typically implementations return a newly created constellation of widgets
        /// that are configured with information from this widget's constructor, the
        /// given [BuildContext], and the internal state of this [State] object.
        ///
        /// The given [BuildContext] contains information about the location in the
        /// tree at which this widget is being built. For example, the context
        /// provides the set of inherited widgets for this location in the tree. The
        /// [BuildContext] argument is always the same as the [context] property of
        /// this [State] object and will remain the same for the lifetime of this
        /// object. The [BuildContext] argument is provided redundantly here so that
        /// this method matches the signature for a [WidgetBuilder].
        ///
        /// ## Design discussion
        ///
        /// ### Why is the [build] method on [State], and not [StatefulWidget]?
        ///
        /// Putting a `Widget build(BuildContext context)` method on [State] rather
        /// than putting a `Widget build(BuildContext context, State state)` method
        /// on [StatefulWidget] gives developers more flexibility when subclassing
        /// [StatefulWidget].
        ///
        /// For example, [AnimatedWidget] is a subclass of [StatefulWidget] that
        /// introduces an abstract `Widget build(BuildContext context)` method for its
        /// subclasses to implement. If [StatefulWidget] already had a [build] method
        /// that took a [State] argument, [AnimatedWidget] would be forced to provide
        /// its [State] object to subclasses even though its [State] object is an
        /// internal implementation detail of [AnimatedWidget].
        ///
        /// Conceptually, [StatelessWidget] could also be implemented as a subclass of
        /// [StatefulWidget] in a similar manner. If the [build] method were on
        /// [StatefulWidget] rather than [State], that would not be possible anymore.
        ///
        /// Putting the [build] function on [State] rather than [StatefulWidget] also
        /// helps avoid a category of bugs related to closures implicitly capturing
        /// `this`. If you defined a closure in a [build] function on a
        /// [StatefulWidget], that closure would implicitly capture `this`, which is
        /// the current widget instance, and would have the (immutable) fields of that
        /// instance in scope:
        ///
        /// ```dart
        /// class MyButton extends StatefulWidget {
        ///   ...
        ///   final Color color;
        ///
        ///   @override
        ///   Widget build(BuildContext context, MyButtonState state) {
        ///     ... () { print("color: $color"); } ...
        ///   }
        /// }
        /// ```
        ///
        /// For example, suppose the parent builds `MyButton` with `color` being blue,
        /// the `$color` in the print function refers to blue, as expected. Now,
        /// suppose the parent rebuilds `MyButton` with green. The closure created by
        /// the first build still implicitly refers to the original widget and the
        /// `$color` still prints blue even through the widget has been updated to
        /// green.
        ///
        /// In contrast, with the [build] function on the [State] object, closures
        /// created during [build] implicitly capture the [State] instance instead of
        /// the widget instance:
        ///
        /// ```dart
        /// class MyButtonState extends State<MyButton> {
        ///   ...
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     ... () { print("color: ${widget.color}"); } ...
        ///   }
        /// }
        /// ```
        ///
        /// Now when the parent rebuilds `MyButton` with green, the closure created by
        /// the first build still refers to [State] object, which is preserved across
        /// rebuilds, but the framework has updated that [State] object's [widget]
        /// property to refer to the new `MyButton` instance and `${widget.color}`
        /// prints green, as expected.
        ///
        /// See also:
        ///
        ///  * [StatefulWidget], which contains the discussion on performance considerations.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Called when a dependency of this [State] object changes.
        ///
        /// For example, if the previous call to [build] referenced an
        /// [InheritedWidget] that later changed, the framework would call this
        /// method to notify this object about the change.
        ///
        /// This method is also called immediately after [initState]. It is safe to
        /// call [BuildContext.dependOnInheritedWidgetOfExactType] from this method.
        ///
        /// Subclasses rarely override this method because the framework always
        /// calls [build] after a dependency changes. Some subclasses do override
        /// this method because they need to do some expensive work (e.g., network
        /// fetches) when their dependencies change, and that work would be too
        /// expensive to do for every build.
        /// </Summary>
        public virtual void DidChangeDependencies()
        {
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);

            properties.Add(new ObjectFlagProperty<T>("_widget", _Widget, ifNull: "no widget"));
            properties.Add(new ObjectFlagProperty<StatefulElement>("_element", _Element, ifNull: "not mounted"));
        }



    }


    /// <Summary>
    /// A widget that has a child widget provided to it, instead of building a new
    /// widget.
    ///
    /// Useful as a base class for other widgets, such as [InheritedWidget] and
    /// [ParentDataWidget].
    ///
    /// See also:
    ///
    ///  * [InheritedWidget], for widgets that introduce ambient state that can
    ///    be read by descendant widgets.
    ///  * [ParentDataWidget], for widgets that populate the
    ///    [RenderObject.parentData] slot of their child's [RenderObject] to
    ///    configure the parent widget's layout.
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [Widget], for an overview of widgets in general.
    /// </Summary>
    public class ProxyWidget : FlutterSDK.Widgets.Framework.Widget
    {
        public ProxyWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
    }


    /// <Summary>
    /// Base class for widgets that hook [ParentData] information to children of
    /// [RenderObjectWidget]s.
    ///
    /// This can be used to provide per-child configuration for
    /// [RenderObjectWidget]s with more than one child. For example, [Stack] uses
    /// the [Positioned] parent data widget to position each child.
    ///
    /// A [ParentDataWidget] is specific to a particular kind of [ParentData]. That
    /// class is `T`, the [ParentData] type argument.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how you would build a [ParentDataWidget] to configure a
    /// `FrogJar` widget's children by specifying a [Size] for each one.
    ///
    /// ```dart
    /// class FrogSize extends ParentDataWidget<FrogJarParentData> {
    ///   FrogSize({
    ///     Key key,
    ///     @required this.size,
    ///     @required Widget child,
    ///   }) : assert(child != null),
    ///        assert(size != null),
    ///        super(key: key, child: child);
    ///
    ///   final Size size;
    ///
    ///   @override
    ///   void applyParentData(RenderObject renderObject) {
    ///     final FrogJarParentData parentData = renderObject.parentData;
    ///     if (parentData.size != size) {
    ///       parentData.size = size;
    ///       final RenderFrogJar targetParent = renderObject.parent;
    ///       targetParent.markNeedsLayout();
    ///     }
    ///   }
    ///
    ///   @override
    ///   Type get debugTypicalAncestorWidgetClass => FrogJar;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RenderObject], the superclass for layout algorithms.
    ///  * [RenderObject.parentData], the slot that this class configures.
    ///  * [ParentData], the superclass of the data that will be placed in
    ///    [RenderObject.parentData] slots. The `T` type parameter for
    ///    [ParentDataWidget] is a [ParentData].
    ///  * [RenderObjectWidget], the class for widgets that wrap [RenderObject]s.
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    /// </Summary>
    public class ParentDataWidget<T> : FlutterSDK.Widgets.Framework.ProxyWidget
    {
        public ParentDataWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new ParentDataElement<T> CreateElement() => new ParentDataElement<T>(this);



        /// <Summary>
        /// Checks if this widget can apply its parent data to the provided
        /// `renderObject`.
        ///
        /// The [RenderObject.parentData] of the provided `renderObject` is
        /// typically set up by an ancestor [RenderObjectWidget] of the type returned
        /// by [debugTypicalAncestorWidgetClass].
        ///
        /// This is called just before [applyParentData] is invoked with the same
        /// [RenderObject] provided to that method.
        /// </Summary>
        public virtual bool DebugIsValidRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject)
        {


            return renderObject.ParentData is T;
        }




        private Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _DebugDescribeIncorrectParentDataType(FlutterSDK.Rendering.@object.ParentData parentData = default(FlutterSDK.Rendering.@object.ParentData), FlutterSDK.Widgets.Framework.RenderObjectWidget parentDataCreator = default(FlutterSDK.Widgets.Framework.RenderObjectWidget), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ownershipChain = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode))
        {



            string description = $"'The ParentDataWidget {this } wants to apply ParentData of type {T} to a RenderObject'";
            if (parentData == null)
            {
                yield return new ErrorDescription($"'{description}, which has not been set up to receive any ParentData.'");
            }
            else
            {
                yield return new ErrorDescription($"'{description}, which has been set up to accept ParentData of incompatible type {parentData.GetType()}.'");
            }

            yield return new ErrorHint($"'Usually, this means that the {GetType()} widget has the wrong ancestor RenderObjectWidget. '" + $"'Typically, {GetType()} widgets are placed directly inside {DebugTypicalAncestorWidgetClass} widgets.'");
            if (parentDataCreator != null)
            {
                yield return new ErrorHint($"'The offending {GetType()} is currently placed inside a {parentDataCreator.GetType()} widget.'");
            }

            if (ownershipChain != null)
            {
                yield return new ErrorDescription($"'The ownership chain for the RenderObject that received the incompatible parent data was:\n  {ownershipChain}'");
            }

        }




        /// <Summary>
        /// Write the data from this widget into the given render object's parent data.
        ///
        /// The framework calls this function whenever it detects that the
        /// [RenderObject] associated with the [child] has outdated
        /// [RenderObject.parentData]. For example, if the render object was recently
        /// inserted into the render tree, the render object's parent data might not
        /// match the data in this widget.
        ///
        /// Subclasses are expected to override this function to copy data from their
        /// fields into the [RenderObject.parentData] field of the given render
        /// object. The render object's parent is guaranteed to have been created by a
        /// widget of type `T`, which usually means that this function can assume that
        /// the render object's parent data object inherits from a particular class.
        ///
        /// If this function modifies data that can change the parent's layout or
        /// painting, this function is responsible for calling
        /// [RenderObject.markNeedsLayout] or [RenderObject.markNeedsPaint] on the
        /// parent, as appropriate.
        /// </Summary>
        public virtual void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
        }


        /// <Summary>
        /// Whether the [ParentDataElement.applyWidgetOutOfTurn] method is allowed
        /// with this widget.
        ///
        /// This should only return true if this widget represents a [ParentData]
        /// configuration that will have no impact on the layout or paint phase.
        ///
        /// See also:
        ///
        ///  * [ParentDataElement.applyWidgetOutOfTurn], which verifies this in debug
        ///    mode.
        /// </Summary>
        public virtual bool DebugCanApplyOutOfTurn() => false;


    }


    /// <Summary>
    /// Base class for widgets that efficiently propagate information down the tree.
    ///
    /// To obtain the nearest instance of a particular type of inherited widget from
    /// a build context, use [BuildContext.dependOnInheritedWidgetOfExactType].
    ///
    /// Inherited widgets, when referenced in this way, will cause the consumer to
    /// rebuild when the inherited widget itself changes state.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=Zbm3hjPjQMk}
    ///
    /// {@tool snippet}
    ///
    /// The following is a skeleton of an inherited widget called `FrogColor`:
    ///
    /// ```dart
    /// class FrogColor extends InheritedWidget {
    ///   const FrogColor({
    ///     Key key,
    ///     @required this.color,
    ///     @required Widget child,
    ///   }) : assert(color != null),
    ///        assert(child != null),
    ///        super(key: key, child: child);
    ///
    ///   final Color color;
    ///
    ///   static FrogColor of(BuildContext context) {
    ///     return context.dependOnInheritedWidgetOfExactType<FrogColor>();
    ///   }
    ///
    ///   @override
    ///   bool updateShouldNotify(FrogColor old) => color != old.color;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// The convention is to provide a static method `of` on the [InheritedWidget]
    /// which does the call to [BuildContext.dependOnInheritedWidgetOfExactType]. This
    /// allows the class to define its own fallback logic in case there isn't
    /// a widget in scope. In the example above, the value returned will be
    /// null in that case, but it could also have defaulted to a value.
    ///
    /// Sometimes, the `of` method returns the data rather than the inherited
    /// widget; for example, in this case it could have returned a [Color] instead
    /// of the `FrogColor` widget.
    ///
    /// Occasionally, the inherited widget is an implementation detail of another
    /// class, and is therefore private. The `of` method in that case is typically
    /// put on the public class instead. For example, [Theme] is implemented as a
    /// [StatelessWidget] that builds a private inherited widget; [Theme.of] looks
    /// for that inherited widget using [BuildContext.dependOnInheritedWidgetOfExactType]
    /// and then returns the [ThemeData].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=1t-8rBCGBYw}
    ///
    /// See also:
    ///
    ///  * [StatefulWidget] and [State], for widgets that can build differently
    ///    several times over their lifetime.
    ///  * [StatelessWidget], for widgets that always build the same way given a
    ///    particular configuration and ambient state.
    ///  * [Widget], for an overview of widgets in general.
    ///  * [InheritedNotifier], an inherited widget whose value can be a
    ///    [Listenable], and which will notify dependents whenever the value
    ///    sends notifications.
    ///  * [InheritedModel], an inherited widget that allows clients to subscribe
    ///    to changes for subparts of the value.
    /// </Summary>
    public class InheritedWidget : FlutterSDK.Widgets.Framework.ProxyWidget
    {
        public InheritedWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

        public new FlutterSDK.Widgets.Framework.InheritedElement CreateElement() => new InheritedElement(this);



        /// <Summary>
        /// Whether the framework should notify widgets that inherit from this widget.
        ///
        /// When this widget is rebuilt, sometimes we need to rebuild the widgets that
        /// inherit from this widget but sometimes we do not. For example, if the data
        /// held by this widget is the same as the data held by `oldWidget`, then we
        /// do not need to rebuild the widgets that inherited the data held by
        /// `oldWidget`.
        ///
        /// The framework distinguishes these cases by calling this function with the
        /// widget that previously occupied this location in the tree as an argument.
        /// The given widget is guaranteed to have the same [runtimeType] as this
        /// object.
        /// </Summary>
        public virtual bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return default(bool);
        }

    }


    /// <Summary>
    /// RenderObjectWidgets provide the configuration for [RenderObjectElement]s,
    /// which wrap [RenderObject]s, which provide the actual rendering of the
    /// application.
    /// </Summary>
    public class RenderObjectWidget : FlutterSDK.Widgets.Framework.Widget
    {
        public RenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {

        }

        /// <Summary>
        /// RenderObjectWidgets always inflate to a [RenderObjectElement] subclass.
        /// </Summary>
        public new FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement()
        {
            return default(RenderObjectElement);
        }


        /// <Summary>
        /// Creates an instance of the [RenderObject] class that this
        /// [RenderObjectWidget] represents, using the configuration described by this
        /// [RenderObjectWidget].
        ///
        /// This method should not do anything with the children of the render object.
        /// That should instead be handled by the method that overrides
        /// [RenderObjectElement.mount] in the object rendered by this object's
        /// [createElement] method. See, for example,
        /// [SingleChildRenderObjectElement.mount].
        /// </Summary>
        public virtual FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(RenderObject);
        }


        /// <Summary>
        /// Copies the configuration described by this [RenderObjectWidget] to the
        /// given [RenderObject], which will be of the same type as returned by this
        /// object's [createRenderObject].
        ///
        /// This method should not do anything to update the children of the render
        /// object. That should instead be handled by the method that overrides
        /// [RenderObjectElement.update] in the object rendered by this object's
        /// [createElement] method. See, for example,
        /// [SingleChildRenderObjectElement.update].
        /// </Summary>
        public virtual void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
        }




        /// <Summary>
        /// A render object previously associated with this widget has been removed
        /// from the tree. The given [RenderObject] will be of the same type as
        /// returned by this object's [createRenderObject].
        /// </Summary>
        public virtual void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
        }



    }


    /// <Summary>
    /// A superclass for RenderObjectWidgets that configure RenderObject subclasses
    /// that have no children.
    /// </Summary>
    public class LeafRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        public LeafRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {

        }

        public new FlutterSDK.Widgets.Framework.LeafRenderObjectElement CreateElement() => new LeafRenderObjectElement(this);


    }


    /// <Summary>
    /// A superclass for [RenderObjectWidget]s that configure [RenderObject] subclasses
    /// that have a single child slot. (This superclass only provides the storage
    /// for that child, it doesn't actually provide the updating logic.)
    ///
    /// Typically, the render object assigned to this widget will make use of
    /// [RenderObjectWithChildMixin] to implement a single-child model. The mixin
    /// exposes a [RenderObjectWithChildMixin.child] property that allows
    /// retrieving the render object belonging to the [child] widget.
    /// </Summary>
    public class SingleChildRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        public SingleChildRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement CreateElement() => new SingleChildRenderObjectElement(this);


    }


    /// <Summary>
    /// A superclass for [RenderObjectWidget]s that configure [RenderObject] subclasses
    /// that have a single list of children. (This superclass only provides the
    /// storage for that child list, it doesn't actually provide the updating
    /// logic.)
    ///
    /// This will return a [RenderObject] mixing in [ContainerRenderObjectMixin],
    /// which provides the necessary functionality to visit the children of the
    /// container render object (the render object belonging to the [children] widgets).
    /// Typically, this is a [RenderBox] with [RenderBoxContainerDefaultsMixin].
    ///
    /// See also:
    ///
    ///  * [Stack], which uses [MultiChildRenderObjectWidget].
    ///  * [RenderStack], for an example implementation of the associated render object.
    /// </Summary>
    public class MultiChildRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        public MultiChildRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key)
        {
            this.Children = children;
        }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }

        public new FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement CreateElement() => new MultiChildRenderObjectElement(this);


    }


    /// <Summary>
    /// Manager class for the widgets framework.
    ///
    /// This class tracks which widgets need rebuilding, and handles other tasks
    /// that apply to widget trees as a whole, such as managing the inactive element
    /// list for the tree and triggering the "reassemble" command when necessary
    /// during hot reload when debugging.
    ///
    /// The main build owner is typically owned by the [WidgetsBinding], and is
    /// driven from the operating system along with the rest of the
    /// build/layout/paint pipeline.
    ///
    /// Additional build owners can be built to manage off-screen widget trees.
    ///
    /// To assign a build owner to a tree, use the
    /// [RootRenderObjectElement.assignOwner] method on the root element of the
    /// widget tree.
    /// </Summary>
    public class BuildOwner
    {
        public BuildOwner(VoidCallback onBuildScheduled = default(VoidCallback))
        {
            this.OnBuildScheduled = onBuildScheduled;
        }
        public virtual VoidCallback OnBuildScheduled { get; set; }
        internal virtual FlutterSDK.Widgets.Framework._InactiveElements _InactiveElements { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Element> _DirtyElements { get; set; }
        internal virtual bool _ScheduledFlushDirtyElements { get; set; }
        internal virtual bool _DirtyElementsNeedsResorting { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusManager FocusManager { get; set; }
        internal virtual int _DebugStateLockLevel { get; set; }
        internal virtual bool _DebugBuilding { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _DebugCurrentBuildTarget { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.Element, HashSet<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>>> _DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans { get; set; }
        internal virtual bool _DebugIsInBuildScope { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DebugStateLocked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugBuilding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Adds an element to the dirty elements list so that it will be rebuilt
        /// when [WidgetsBinding.drawFrame] calls [buildScope].
        /// </Summary>
        public virtual void ScheduleBuildFor(FlutterSDK.Widgets.Framework.Element element)
        {



            if (element._InDirtyList)
            {

                _DirtyElementsNeedsResorting = true;
                return;
            }

            if (!_ScheduledFlushDirtyElements && OnBuildScheduled != null)
            {
                _ScheduledFlushDirtyElements = true;
                OnBuildScheduled();
            }

            _DirtyElements.Add(element);
            element._InDirtyList = true;

        }




        /// <Summary>
        /// Establishes a scope in which calls to [State.setState] are forbidden, and
        /// calls the given `callback`.
        ///
        /// This mechanism is used to ensure that, for instance, [State.dispose] does
        /// not call [State.setState].
        /// </Summary>
        public virtual void LockState(Action callback)
        {



            try
            {
                callback();
            }
            finally
            {

            }


        }




        /// <Summary>
        /// Establishes a scope for updating the widget tree, and calls the given
        /// `callback`, if any. Then, builds all the elements that were marked as
        /// dirty using [scheduleBuildFor], in depth order.
        ///
        /// This mechanism prevents build methods from transitively requiring other
        /// build methods to run, potentially causing infinite loops.
        ///
        /// The dirty list is processed after `callback` returns, building all the
        /// elements that were marked as dirty using [scheduleBuildFor], in depth
        /// order. If elements are marked as dirty while this method is running, they
        /// must be deeper than the `context` node, and deeper than any
        /// previously-built node in this pass.
        ///
        /// To flush the current dirty list without performing any other work, this
        /// function can be called with no callback. This is what the framework does
        /// each frame, in [WidgetsBinding.drawFrame].
        ///
        /// Only one [buildScope] can be active at a time.
        ///
        /// A [buildScope] implies a [lockState] scope as well.
        ///
        /// To print a console message every time this method is called, set
        /// [debugPrintBuildScope] to true. This is useful when debugging problems
        /// involving widgets not getting marked dirty, or getting marked dirty too
        /// often.
        /// </Summary>
        public virtual void BuildScope(FlutterSDK.Widgets.Framework.Element context, VoidCallback callback = default(VoidCallback))
        {
            if (callback == null && _DirtyElements.IsEmpty()) return;




            Dart: developerDefaultClass.Timeline.StartSync("Build", arguments: DebugDefaultClass.TimelineWhitelistArguments);
            try
            {
                _ScheduledFlushDirtyElements = true;
                if (callback != null)
                {

                    Element debugPreviousBuildTarget = default(Element);

                    _DirtyElementsNeedsResorting = false;
                    try
                    {
                        callback();
                    }
                    finally
                    {

                    }

                }

                _DirtyElements.Sort(FrameworkDefaultClass.Element._Sort);
                _DirtyElementsNeedsResorting = false;
                int dirtyCount = _DirtyElements.Count;
                int index = 0;
                while (index < dirtyCount)
                {



                    try
                    {
                        _DirtyElements[index].Rebuild();
                    }
                    catch (e,stack){
                        FrameworkDefaultClass._DebugReportException(new ErrorDescription("while rebuilding dirty elements"), e, stack, informationCollector: () =>
                        {
                            yield return new DiagnosticsDebugCreator(new DebugCreator(_DirtyElements[index]));
                            yield return _DirtyElements[index].DescribeElement($"'The element being rebuilt at the time was index {index} of {dirtyCount}'");
                        }
                        );
                    }

                    index += 1;
                    if (dirtyCount < _DirtyElements.Count || _DirtyElementsNeedsResorting)
                    {
                        _DirtyElements.Sort(FrameworkDefaultClass.Element._Sort);
                        _DirtyElementsNeedsResorting = false;
                        dirtyCount = _DirtyElements.Count;
                        while (index > 0 && _DirtyElements[index - 1].Dirty)
                        {
                            index -= 1;
                        }

                    }

                    }


                }
finally
            {
                foreach (Element element in _DirtyElements)
                {

                    element._InDirtyList = false;
                }

                _DirtyElements.Clear();
                _ScheduledFlushDirtyElements = false;
                _DirtyElementsNeedsResorting = null;
            Dart: developerDefaultClass.Timeline.FinishSync();


            }


        }




        private void _DebugTrackElementThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans(FlutterSDK.Widgets.Framework.Element node, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key)
        {
            _DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans = (_DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans == null ? new HashMap<Element, HashSet<GlobalKey>>() : _DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans);
            HashSet<GlobalKey> keys = _DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans.PutIfAbsent(node, () => =>new HashSet<GlobalKey>());
            keys.Add(key);
        }




        private void _DebugElementWasRebuilt(FlutterSDK.Widgets.Framework.Element node)
        {
            _DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans?.Remove(node);
        }




        /// <Summary>
        /// Complete the element build pass by unmounting any elements that are no
        /// longer active.
        ///
        /// This is called by [WidgetsBinding.drawFrame].
        ///
        /// In debug mode, this also runs some sanity checks, for example checking for
        /// duplicate global keys.
        ///
        /// After the current call stack unwinds, a microtask that notifies listeners
        /// about changes to global keys will run.
        /// </Summary>
        public virtual void FinalizeTree()
        {
        Dart: developerDefaultClass.Timeline.StartSync("Finalize tree", arguments: DebugDefaultClass.TimelineWhitelistArguments);
            try
            {
                LockState(() =>
                {
                    _InactiveElements._UnmountAll();
                }
                );

            }
            catch (e,stack){
                FrameworkDefaultClass._DebugReportException(new ErrorSummary("while finalizing the widget tree"), e, stack);
            }
finally
            {
            Dart: developerDefaultClass.Timeline.FinishSync();
            }

        }




        /// <Summary>
        /// Cause the entire subtree rooted at the given [Element] to be entirely
        /// rebuilt. This is used by development tools when the application code has
        /// changed and is being hot-reloaded, to cause the widget tree to pick up any
        /// changed implementations.
        ///
        /// This is expensive and should not be called except during development.
        /// </Summary>
        public virtual void Reassemble(FlutterSDK.Widgets.Framework.Element root)
        {
        Dart: developerDefaultClass.Timeline.StartSync("Dirty Element Tree");
            try
            {


                root.Reassemble();
            }
            finally
            {
            Dart: developerDefaultClass.Timeline.FinishSync();
            }

        }



    }


    /// <Summary>
    /// An instantiation of a [Widget] at a particular location in the tree.
    ///
    /// Widgets describe how to configure a subtree but the same widget can be used
    /// to configure multiple subtrees simultaneously because widgets are immutable.
    /// An [Element] represents the use of a widget to configure a specific location
    /// in the tree. Over time, the widget associated with a given element can
    /// change, for example, if the parent widget rebuilds and creates a new widget
    /// for this location.
    ///
    /// Elements form a tree. Most elements have a unique child, but some widgets
    /// (e.g., subclasses of [RenderObjectElement]) can have multiple children.
    ///
    /// Elements have the following lifecycle:
    ///
    ///  * The framework creates an element by calling [Widget.createElement] on the
    ///    widget that will be used as the element's initial configuration.
    ///  * The framework calls [mount] to add the newly created element to the tree
    ///    at a given slot in a given parent. The [mount] method is responsible for
    ///    inflating any child widgets and calling [attachRenderObject] as
    ///    necessary to attach any associated render objects to the render tree.
    ///  * At this point, the element is considered "active" and might appear on
    ///    screen.
    ///  * At some point, the parent might decide to change the widget used to
    ///    configure this element, for example because the parent rebuilt with new
    ///    state. When this happens, the framework will call [update] with the new
    ///    widget. The new widget will always have the same [runtimeType] and key as
    ///    old widget. If the parent wishes to change the [runtimeType] or key of
    ///    the widget at this location in the tree, it can do so by unmounting this
    ///    element and inflating the new widget at this location.
    ///  * At some point, an ancestor might decide to remove this element (or an
    ///    intermediate ancestor) from the tree, which the ancestor does by calling
    ///    [deactivateChild] on itself. Deactivating the intermediate ancestor will
    ///    remove that element's render object from the render tree and add this
    ///    element to the [owner]'s list of inactive elements, causing the framework
    ///    to call [deactivate] on this element.
    ///  * At this point, the element is considered "inactive" and will not appear
    ///    on screen. An element can remain in the inactive state only until
    ///    the end of the current animation frame. At the end of the animation
    ///    frame, any elements that are still inactive will be unmounted.
    ///  * If the element gets reincorporated into the tree (e.g., because it or one
    ///    of its ancestors has a global key that is reused), the framework will
    ///    remove the element from the [owner]'s list of inactive elements, call
    ///    [activate] on the element, and reattach the element's render object to
    ///    the render tree. (At this point, the element is again considered "active"
    ///    and might appear on screen.)
    ///  * If the element does not get reincorporated into the tree by the end of
    ///    the current animation frame, the framework will call [unmount] on the
    ///    element.
    ///  * At this point, the element is considered "defunct" and will not be
    ///    incorporated into the tree in the future.
    /// </Summary>
    public class Element : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree, IBuildContext
    {
        public Element(FlutterSDK.Widgets.Framework.Widget widget)
        : base()
        {

        }
        internal virtual FlutterSDK.Widgets.Framework.Element _Parent { get; set; }
        internal virtual int _CachedHash { get; set; }
        internal virtual int _NextHashCode { get; set; }
        internal virtual object _Slot { get; set; }
        internal virtual int _Depth { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Widget { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.BuildOwner _Owner { get; set; }
        internal virtual bool _Active { get; set; }
        internal virtual FlutterSDK.Widgets.Framework._ElementLifecycle _DebugLifecycleState { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _DebugForgottenChildrenWithGlobalKey { get; set; }
        internal virtual Dictionary<Type, FlutterSDK.Widgets.Framework.InheritedElement> _InheritedWidgets { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.InheritedElement> _Dependencies { get; set; }
        internal virtual bool _HadUnsatisfiedDependencies { get; set; }
        internal virtual bool _Dirty { get; set; }
        internal virtual bool _InDirtyList { get; set; }
        internal virtual bool _DebugBuiltOnce { get; set; }
        internal virtual bool _DebugAllowIgnoredCallsToMarkNeedsBuild { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual object Slot { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int Depth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Dirty { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other) => Dart:coreDefaultClass.Identical(this , other);



private int _Sort(FlutterSDK.Widgets.Framework.Element a, FlutterSDK.Widgets.Framework.Element b)
        {
            if (a.Depth < b.Depth) return -1;
            if (b.Depth < a.Depth) return 1;
            if (b.Dirty && !a.Dirty) return -1;
            if (a.Dirty && !b.Dirty) return 1;
            return 0;
        }




        private int _DebugConcreteSubtype(FlutterSDK.Widgets.Framework.Element element)
        {
            return element is StatefulElement ? 1 : element is StatelessElement ? 2 : 0;
        }




        /// <Summary>
        /// {@template flutter.widgets.reassemble}
        /// Called whenever the application is reassembled during debugging, for
        /// example during hot reload.
        ///
        /// This method should rerun any initialization logic that depends on global
        /// state, for example, image loading from asset bundles (since the asset
        /// bundle may have changed).
        ///
        /// This function will only be called during development. In release builds,
        /// the `ext.flutter.reassemble` hook is not available, and so this code will
        /// never execute.
        ///
        /// Implementers should not rely on any ordering for hot reload source update,
        /// reassemble, and build methods after a hot reload has been initiated. It is
        /// possible that a [Timer] (e.g. an [Animation]) or a debugging session
        /// attached to the isolate could trigger a build with reloaded code _before_
        /// reassemble is called. Code that expects preconditions to be set by
        /// reassemble after a hot reload must be resilient to being called out of
        /// order, e.g. by fizzling instead of throwing. That said, once reassemble is
        /// called, build will be called after it at least once.
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [State.reassemble]
        ///  * [BindingBase.reassembleApplication]
        ///  * [Image], which uses this to reload images.
        /// </Summary>
        public virtual void Reassemble()
        {
            MarkNeedsBuild();
            VisitChildren((Element child) =>
            {
                child.Reassemble();
            }
            );
        }




        private bool _DebugIsInScope(FlutterSDK.Widgets.Framework.Element target)
        {
            Element current = this;
            while (current != null)
            {
                if (target == current) return true;
                current = current._Parent;
            }

            return false;
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(Type expectedAncestorType = default(Type))
        {
            List<DiagnosticsNode> information = new List<DiagnosticsNode>() { };
            List<Element> ancestors = new List<Element>() { };
            VisitAncestorElements((Element element) =>
            {
                ancestors.Add(element);
                return true;
            }
            );
            information.Add(new DiagnosticsProperty<Element>($"'The specific widget that could not find a {expectedAncestorType} ancestor was'", this, style: DiagnosticsTreeStyle.ErrorProperty));
            if (ancestors.IsNotEmpty)
            {
                information.Add(DescribeElements("The ancestors of this widget were", ancestors));
            }
            else
            {
                information.Add(new ErrorDescription("This widget is the root of the tree, so it has no " + $"'ancestors, let alone a "{ expectedAncestorType }" ancestor.'"));
            }

            return information;
        }




        /// <Summary>
        /// Returns a list of [Element]s from the current build context to the error report.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElements(string name, Iterable<FlutterSDK.Widgets.Framework.Element> elements)
        {
            return new DiagnosticsBlock(name: name, children: elements.Map((Element element) => =>new DiagnosticsProperty<Element>("", element)).ToList(), allowTruncate: true);
        }




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new DiagnosticsProperty<Element>(name, this, style: style);
        }




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new DiagnosticsProperty<Element>(name, this, style: style);
        }




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(string name)
        {
            return new StringProperty(name, DebugGetCreatorChain(10));
        }




        /// <Summary>
        /// Calls the argument for each child. Must be overridden by subclasses that
        /// support having children.
        ///
        /// There is no guaranteed order in which the children will be visited, though
        /// it should be consistent over time.
        ///
        /// Calling this during build is dangerous: the child list might still be
        /// being updated at that point, so the children might not be constructed yet,
        /// or might be old children that are going to be replaced. This method should
        /// only be called if it is provable that the children are available.
        /// </Summary>
        public virtual void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
        }




        /// <Summary>
        /// Calls the argument for each child considered onstage.
        ///
        /// Classes like [Offstage] and [Overlay] override this method to hide their
        /// children.
        ///
        /// Being onstage affects the element's discoverability during testing when
        /// you use Flutter's [Finder] objects. For example, when you instruct the
        /// test framework to tap on a widget, by default the finder will look for
        /// onstage elements and ignore the offstage ones.
        ///
        /// The default implementation defers to [visitChildren] and therefore treats
        /// the element as onstage.
        ///
        /// See also:
        ///
        ///  * [Offstage] widget that hides its children.
        ///  * [Finder] that skips offstage widgets by default.
        ///  * [RenderObject.visitChildrenForSemantics], in contrast to this method,
        ///    designed specifically for excluding parts of the UI from the semantics
        ///    tree.
        /// </Summary>
        public virtual void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) => VisitChildren(visitor);



        /// <Summary>
        /// Wrapper around [visitChildren] for [BuildContext].
        /// </Summary>
        public new void VisitChildElements(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {

            VisitChildren(visitor);
        }




        /// <Summary>
        /// Update the given child with the given new configuration.
        ///
        /// This method is the core of the widgets system. It is called each time we
        /// are to add, update, or remove a child based on an updated configuration.
        ///
        /// If the `child` is null, and the `newWidget` is not null, then we have a new
        /// child for which we need to create an [Element], configured with `newWidget`.
        ///
        /// If the `newWidget` is null, and the `child` is not null, then we need to
        /// remove it because it no longer has a configuration.
        ///
        /// If neither are null, then we need to update the `child`'s configuration to
        /// be the new configuration given by `newWidget`. If `newWidget` can be given
        /// to the existing child (as determined by [Widget.canUpdate]), then it is so
        /// given. Otherwise, the old child needs to be disposed and a new child
        /// created for the new configuration.
        ///
        /// If both are null, then we don't have a child and won't have a child, so we
        /// do nothing.
        ///
        /// The [updateChild] method returns the new child, if it had to create one,
        /// or the child that was passed in, if it just had to update the child, or
        /// null, if it removed the child and did not replace it.
        ///
        /// The following table summarizes the above:
        ///
        /// |                     | **newWidget == null**  | **newWidget != null**   |
        /// | :-----------------: | :--------------------- | :---------------------- |
        /// |  **child == null**  |  Returns null.         |  Returns new [Element]. |
        /// |  **child != null**  |  Old child is removed, returns null. | Old child updated if possible, returns child or new [Element]. |
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot)
        {
            if (newWidget == null)
            {
                if (child != null) DeactivateChild(child);
                return null;
            }

            Element newChild = default(Element);
            if (child != null)
            {
                bool hasSameSuperclass = true;

                if (hasSameSuperclass && child.Widget == newWidget)
                {
                    if (child.Slot != newSlot) UpdateSlotForChild(child, newSlot);
                    newChild = child;
                }
                else if (hasSameSuperclass && FrameworkDefaultClass.Widget.CanUpdate(child.Widget, newWidget))
                {
                    if (child.Slot != newSlot) UpdateSlotForChild(child, newSlot);
                    child.Update(newWidget);


                    newChild = child;
                }
                else
                {
                    DeactivateChild(child);

                    newChild = InflateWidget(newWidget, newSlot);
                }

            }
            else
            {
                newChild = InflateWidget(newWidget, newSlot);
            }


            return newChild;
        }




        /// <Summary>
        /// Add this element to the tree in the given slot of the given parent.
        ///
        /// The framework calls this function when a newly created element is added to
        /// the tree for the first time. Use this method to initialize state that
        /// depends on having a parent. State that is independent of the parent can
        /// more easily be initialized in the constructor.
        ///
        /// This method transitions the element from the "initial" lifecycle state to
        /// the "active" lifecycle state.
        /// </Summary>
        public virtual void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {







            _Parent = parent;
            _Slot = newSlot;
            _Depth = _Parent != null ? _Parent.Depth + 1 : 1;
            _Active = true;
            if (parent != null) _Owner = parent.Owner;
            Key key = Widget.Key;
            if (key is GlobalKey)
            {
                ((GlobalKey)key)._Register(this);
            }

            _UpdateInheritance();

        }




        private void _DebugRemoveGlobalKeyReservation(FlutterSDK.Widgets.Framework.Element child)
        {
            FrameworkDefaultClass.GlobalKey._DebugRemoveReservationFor(this, child);
        }




        /// <Summary>
        /// Change the widget used to configure this element.
        ///
        /// The framework calls this function when the parent wishes to use a
        /// different widget to configure this element. The new widget is guaranteed
        /// to have the same [runtimeType] as the old widget.
        ///
        /// This function is called only during the "active" lifecycle state.
        /// </Summary>
        public virtual void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {


            _Widget = newWidget;
        }




        /// <Summary>
        /// Change the slot that the given child occupies in its parent.
        ///
        /// Called by [MultiChildRenderObjectElement], and other [RenderObjectElement]
        /// subclasses that have multiple children, when child moves from one position
        /// to another in this element's child list.
        /// </Summary>
        public virtual void UpdateSlotForChild(FlutterSDK.Widgets.Framework.Element child, object newSlot)
        {



            void Visit(Element element)
            {
                element._UpdateSlot(newSlot);
                if (!(element is RenderObjectElement)) element.VisitChildren(Visit);
            }

            Visit(child);
        }




        private void _UpdateSlot(object newSlot)
        {





            _Slot = newSlot;
        }




        private void _UpdateDepth(int parentDepth)
        {
            int expectedDepth = parentDepth + 1;
            if (_Depth < expectedDepth)
            {
                _Depth = expectedDepth;
                VisitChildren((Element child) =>
                {
                    child._UpdateDepth(expectedDepth);
                }
                );
            }

        }




        /// <Summary>
        /// Remove [renderObject] from the render tree.
        ///
        /// The default implementation of this function simply calls
        /// [detachRenderObject] recursively on its child. The
        /// [RenderObjectElement.detachRenderObject] override does the actual work of
        /// removing [renderObject] from the render tree.
        ///
        /// This is called by [deactivateChild].
        /// </Summary>
        public virtual void DetachRenderObject()
        {
            VisitChildren((Element child) =>
            {
                child.DetachRenderObject();
            }
            );
            _Slot = null;
        }




        /// <Summary>
        /// Add [renderObject] to the render tree at the location specified by [slot].
        ///
        /// The default implementation of this function simply calls
        /// [attachRenderObject] recursively on its child. The
        /// [RenderObjectElement.attachRenderObject] override does the actual work of
        /// adding [renderObject] to the render tree.
        /// </Summary>
        public virtual void AttachRenderObject(object newSlot)
        {

            VisitChildren((Element child) =>
            {
                child.AttachRenderObject(newSlot);
            }
            );
            _Slot = newSlot;
        }




        private FlutterSDK.Widgets.Framework.Element _RetakeInactiveElement(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key, FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            Element element = key._CurrentElement;
            if (element == null) return null;
            if (!FrameworkDefaultClass.Widget.CanUpdate(element.Widget, newWidget)) return null;

            Element parent = element._Parent;
            if (parent != null)
            {

                parent.ForgetChild(element);
                parent.DeactivateChild(element);
            }


            Owner._InactiveElements.Remove(element);
            return element;
        }




        /// <Summary>
        /// Create an element for the given widget and add it as a child of this
        /// element in the given slot.
        ///
        /// This method is typically called by [updateChild] but can be called
        /// directly by subclasses that need finer-grained control over creating
        /// elements.
        ///
        /// If the given widget has a global key and an element already exists that
        /// has a widget with that global key, this function will reuse that element
        /// (potentially grafting it from another location in the tree or reactivating
        /// it from the list of inactive elements) rather than creating a new element.
        ///
        /// The element returned by this function will already have been mounted and
        /// will be in the "active" lifecycle state.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Element InflateWidget(FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot)
        {

            Key key = newWidget.Key;
            if (key is GlobalKey)
            {
                Element newChild = _RetakeInactiveElement(((GlobalKey)key), newWidget);
                if (newChild != null)
                {


                    newChild._ActivateWithParent(this, newSlot);
                    Element updatedChild = UpdateChild(newChild, newWidget, newSlot);

                    return updatedChild;
                }

            }

            Element newChild = newWidget.CreateElement();

            newChild.Mount(this, newSlot);

            return newChild;
        }




        private void _DebugCheckForCycles(FlutterSDK.Widgets.Framework.Element newChild)
        {


        }




        /// <Summary>
        /// Move the given element to the list of inactive elements and detach its
        /// render object from the render tree.
        ///
        /// This method stops the given element from being a child of this element by
        /// detaching its render object from the render tree and moving the element to
        /// the list of inactive elements.
        ///
        /// This method (indirectly) calls [deactivate] on the child.
        ///
        /// The caller is responsible for removing the child from its child model.
        /// Typically [deactivateChild] is called by the element itself while it is
        /// updating its child model; however, during [GlobalKey] reparenting, the new
        /// parent proactively calls the old parent's [deactivateChild], first using
        /// [forgetChild] to cause the old parent to update its child model.
        /// </Summary>
        public virtual void DeactivateChild(FlutterSDK.Widgets.Framework.Element child)
        {


            child._Parent = null;
            child.DetachRenderObject();
            Owner._InactiveElements.Add(child);

        }




        /// <Summary>
        /// Remove the given child from the element's child list, in preparation for
        /// the child being reused elsewhere in the element tree.
        ///
        /// This updates the child model such that, e.g., [visitChildren] does not
        /// walk that child anymore.
        ///
        /// The element will still have a valid parent when this is called. After this
        /// is called, [deactivateChild] is called to sever the link to this object.
        ///
        /// The [update] is responsible for updating or creating the new child that
        /// will replace this [child].
        /// </Summary>
        public virtual void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

        }




        private void _ActivateWithParent(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {

            _Parent = parent;

            _UpdateDepth(_Parent.Depth);
            _ActivateRecursively(this);
            AttachRenderObject(newSlot);

        }




        private void _ActivateRecursively(FlutterSDK.Widgets.Framework.Element element)
        {

            element.Activate();

            element.VisitChildren(_ActivateRecursively);
        }




        /// <Summary>
        /// Transition from the "inactive" to the "active" lifecycle state.
        ///
        /// The framework calls this method when a previously deactivated element has
        /// been reincorporated into the tree. The framework does not call this method
        /// the first time an element becomes active (i.e., from the "initial"
        /// lifecycle state). Instead, the framework calls [mount] in that situation.
        ///
        /// See the lifecycle documentation for [Element] for additional information.
        /// </Summary>
        public virtual void Activate()
        {





            bool hadDependencies = (_Dependencies != null && _Dependencies.IsNotEmpty) || _HadUnsatisfiedDependencies;
            _Active = true;
            _Dependencies?.Clear();
            _HadUnsatisfiedDependencies = false;
            _UpdateInheritance();

            if (_Dirty) Owner.ScheduleBuildFor(this);
            if (hadDependencies) DidChangeDependencies();
        }




        /// <Summary>
        /// Transition from the "active" to the "inactive" lifecycle state.
        ///
        /// The framework calls this method when a previously active element is moved
        /// to the list of inactive elements. While in the inactive state, the element
        /// will not appear on screen. The element can remain in the inactive state
        /// only until the end of the current animation frame. At the end of the
        /// animation frame, if the element has not be reactivated, the framework will
        /// unmount the element.
        ///
        /// This is (indirectly) called by [deactivateChild].
        ///
        /// See the lifecycle documentation for [Element] for additional information.
        /// </Summary>
        public virtual void Deactivate()
        {




            if (_Dependencies != null && _Dependencies.IsNotEmpty)
            {
                foreach (InheritedElement dependency in _Dependencies) dependency._Dependents.Remove(this);
            }

            _InheritedWidgets = null;
            _Active = false;

        }




        /// <Summary>
        /// Called, in debug mode, after children have been deactivated (see [deactivate]).
        ///
        /// This method is not called in release builds.
        /// </Summary>
        public virtual void DebugDeactivated()
        {

        }




        /// <Summary>
        /// Transition from the "inactive" to the "defunct" lifecycle state.
        ///
        /// Called when the framework determines that an inactive element will never
        /// be reactivated. At the end of each animation frame, the framework calls
        /// [unmount] on any remaining inactive elements, preventing inactive elements
        /// from remaining inactive for longer than a single animation frame.
        ///
        /// After this function is called, the element will not be incorporated into
        /// the tree again.
        ///
        /// See the lifecycle documentation for [Element] for additional information.
        /// </Summary>
        public virtual void Unmount()
        {




            Key key = _Widget.Key;
            if (key is GlobalKey)
            {
                ((GlobalKey)key)._Unregister(this);
            }


        }




        public new FlutterSDK.Rendering.@object.RenderObject FindRenderObject() => RenderObject;



        private bool _DebugCheckStateIsActiveForAncestorLookup()
        {

            return true;
        }




        public new FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object))
        {
            return DependOnInheritedElement(ancestor, aspect: aspect);
        }




        public new FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object))
        {

            _Dependencies = (_Dependencies == null ? new HashSet<InheritedElement>() : _Dependencies);
            _Dependencies.Add(ancestor);
            ancestor.UpdateDependencies(this, aspect);
            return ancestor.Widget;
        }




        public new FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(Type targetType, @Object aspect = default(@Object))
        {

            InheritedElement ancestor = _InheritedWidgets == null ? null : _InheritedWidgets[targetType];
            if (ancestor != null)
            {

                return InheritFromElement(ancestor, aspect: aspect);
            }

            _HadUnsatisfiedDependencies = true;
            return null;
        }




        public new T DependOnInheritedWidgetOfExactType<T>(@Object aspect = default(@Object))
        {

            InheritedElement ancestor = _InheritedWidgets == null ? null : _InheritedWidgets[T];
            if (ancestor != null)
            {

                return DependOnInheritedElement(ancestor, aspect: aspect) as T;
            }

            _HadUnsatisfiedDependencies = true;
            return null;
        }




        public new FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(Type targetType)
        {

            InheritedElement ancestor = _InheritedWidgets == null ? null : _InheritedWidgets[targetType];
            return ancestor;
        }




        public new FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>()
        {

            InheritedElement ancestor = _InheritedWidgets == null ? null : _InheritedWidgets[T];
            return ancestor;
        }




        private void _UpdateInheritance()
        {

            _InheritedWidgets = _Parent?._InheritedWidgets;
        }




        public new FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(Type targetType)
        {

            Element ancestor = _Parent;
            while (ancestor != null && ancestor.Widget.GetType() != targetType) ancestor = ancestor._Parent;
            return ancestor?.Widget;
        }




        public new T FindAncestorWidgetOfExactType<T>()
        {

            Element ancestor = _Parent;
            while (ancestor != null && ancestor.Widget.GetType() != T) ancestor = ancestor._Parent;
            return ancestor?.Widget as T;
        }




        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher)
        {

            Element ancestor = _Parent;
            while (ancestor != null)
            {
                if (ancestor is StatefulElement && matcher.Check(ancestor.State)) break;
                ancestor = ancestor._Parent;
            }

            StatefulElement statefulAncestor = ancestor as StatefulElement;
            return statefulAncestor?.State;
        }




        public new T FindAncestorStateOfType<T>()
        {

            Element ancestor = _Parent;
            while (ancestor != null)
            {
                if (ancestor is StatefulElement && ancestor.State is T) break;
                ancestor = ancestor._Parent;
            }

            StatefulElement statefulAncestor = ancestor as StatefulElement;
            return statefulAncestor?.State as T;
        }




        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher)
        {

            Element ancestor = _Parent;
            StatefulElement statefulAncestor = default(StatefulElement);
            while (ancestor != null)
            {
                if (ancestor is StatefulElement && matcher.Check(ancestor.State)) statefulAncestor = ancestor;
                ancestor = ancestor._Parent;
            }

            return statefulAncestor?.State;
        }




        public new T FindRootAncestorStateOfType<T>()
        {

            Element ancestor = _Parent;
            StatefulElement statefulAncestor = default(StatefulElement);
            while (ancestor != null)
            {
                if (ancestor is StatefulElement && ancestor.State is T) statefulAncestor = ancestor;
                ancestor = ancestor._Parent;
            }

            return statefulAncestor?.State as T;
        }




        public new FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher)
        {

            Element ancestor = _Parent;
            while (ancestor != null)
            {
                if (ancestor is RenderObjectElement && matcher.Check(ancestor.RenderObject)) return ancestor.RenderObject;
                ancestor = ancestor._Parent;
            }

            return null;
        }




        public new T FindAncestorRenderObjectOfType<T>()
        {

            Element ancestor = _Parent;
            while (ancestor != null)
            {
                if (ancestor is RenderObjectElement && ancestor.RenderObject is T) return ancestor.RenderObject as T;
                ancestor = ancestor._Parent;
            }

            return null;
        }




        public new void VisitAncestorElements(Func<bool, Element> visitor)
        {

            Element ancestor = _Parent;
            while (ancestor != null && visitor(ancestor)) ancestor = ancestor._Parent;
        }




        /// <Summary>
        /// Called when a dependency of this element changes.
        ///
        /// The [dependOnInheritedWidgetOfExactType] registers this element as depending on
        /// inherited information of the given type. When the information of that type
        /// changes at this location in the tree (e.g., because the [InheritedElement]
        /// updated to a new [InheritedWidget] and
        /// [InheritedWidget.updateShouldNotify] returned true), the framework calls
        /// this function to notify this element of the change.
        /// </Summary>
        public virtual void DidChangeDependencies()
        {


            MarkNeedsBuild();
        }




        private bool _DebugCheckOwnerBuildTargetExists(string methodName)
        {

            return true;
        }




        /// <Summary>
        /// Returns a description of what caused this element to be created.
        ///
        /// Useful for debugging the source of an element.
        /// </Summary>
        public virtual string DebugGetCreatorChain(int limit)
        {
            List<string> chain = new List<string>() { };
            Element node = this;
            while (chain.Count < limit && node != null)
            {
                chain.Add(node.ToStringShort());
                node = node._Parent;
            }

            if (node != null) chain.Add("\u22EF");
            return chain.Join(" \u2190 ");
        }




        /// <Summary>
        /// Returns the parent chain from this element back to the root of the tree.
        ///
        /// Useful for debug display of a tree of Elements with only nodes in the path
        /// from the root to this Element expanded.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Element> DebugGetDiagnosticChain()
        {
            List<Element> chain = new List<Element>() { this };
            Element node = _Parent;
            while (node != null)
            {
                chain.Add(node);
                node = node._Parent;
            }

            return chain;
        }




        /// <Summary>
        /// A short, textual description of this element.
        /// </Summary>
        public new string ToStringShort()
        {
            return Widget != null ? Widget.ToStringShort() : $"'[{ObjectDefaultClass.ObjectRuntimeType(this, "Element")}]'";
        }




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new _ElementDiagnosticableTreeNode(name: name, value: this, style: style);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.DefaultDiagnosticsTreeStyle = DiagnosticsTreeStyle.Dense;
            properties.Add(new ObjectFlagProperty<int>("depth", Depth, ifNull: "no depth"));
            properties.Add(new ObjectFlagProperty<Widget>("widget", Widget, ifNull: "no widget"));
            if (Widget != null)
            {
                properties.Add(new DiagnosticsProperty<Key>("key", Widget?.Key, showName: false, defaultValue: null, level: DiagnosticLevel.Hidden));
                Widget.DebugFillProperties(properties);
            }

            properties.Add(new FlagProperty("dirty", value: Dirty, ifTrue: "dirty"));
            if (_Dependencies != null && _Dependencies.IsNotEmpty)
            {
                List<DiagnosticsNode> diagnosticsDependencies = _Dependencies.Map((InheritedElement element) => =>element.Widget.ToDiagnosticsNode(style: DiagnosticsTreeStyle.Sparse)).ToList();
                properties.Add(new DiagnosticsProperty<List<DiagnosticsNode>>("dependencies", diagnosticsDependencies));
            }

        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> children = new List<DiagnosticsNode>() { };
            VisitChildren((Element child) =>
            {
                if (child != null)
                {
                    children.Add(child.ToDiagnosticsNode());
                }
                else
                {
                    children.Add(DiagnosticsNode.Message("<null child>"));
                }

            }
            );
            return children;
        }




        private bool _DebugSetAllowIgnoredCallsToMarkNeedsBuild(bool value)
        {

            _DebugAllowIgnoredCallsToMarkNeedsBuild = value;
            return true;
        }




        /// <Summary>
        /// Marks the element as dirty and adds it to the global list of widgets to
        /// rebuild in the next frame.
        ///
        /// Since it is inefficient to build an element twice in one frame,
        /// applications and widgets should be structured so as to only mark
        /// widgets dirty during event handlers before the frame begins, not during
        /// the build itself.
        /// </Summary>
        public virtual void MarkNeedsBuild()
        {

            if (!_Active) return;



            if (Dirty) return;
            _Dirty = true;
            Owner.ScheduleBuildFor(this);
        }




        /// <Summary>
        /// Called by the [BuildOwner] when [BuildOwner.scheduleBuildFor] has been
        /// called to mark this element dirty, by [mount] when the element is first
        /// built, and by [update] when the widget has changed.
        /// </Summary>
        public virtual void Rebuild()
        {

            if (!_Active || !_Dirty) return;



            Element debugPreviousBuildTarget = default(Element);

            PerformRebuild();


        }




        /// <Summary>
        /// Called by rebuild() after the appropriate checks have been made.
        /// </Summary>
        public virtual void PerformRebuild()
        {
        }

    }


    public class _ElementDiagnosticableTreeNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableTreeNode
    {
        public _ElementDiagnosticableTreeNode(string name = default(string), FlutterSDK.Widgets.Framework.Element value = default(FlutterSDK.Widgets.Framework.Element), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool stateful = false)
        : base(name: name, value: value, style: style)
        {
            this.Stateful = stateful;
        }
        public virtual bool Stateful { get; set; }

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
        {
            Dictionary<string, object> json = base.ToJsonMap(delegate);
            Element element = Value as Element;
            json["widgetRuntimeType"] = element.Widget?.GetType()?.ToString();
            json["stateful"] = Stateful;
            return json;
        }



    }


    /// <Summary>
    /// A widget that renders an exception's message.
    ///
    /// This widget is used when a build method fails, to help with determining
    /// where the problem lies. Exceptions are also logged to the console, which you
    /// can read using `flutter logs`. The console will also include additional
    /// information such as the stack trace for the exception.
    ///
    /// It is possible to override this widget.
    ///
    /// {@tool sample --template=freeform}
    /// ```dart
    /// import 'package:flutter/material.dart';
    ///
    /// void main() {
    ///   ErrorWidget.builder = (FlutterErrorDetails details) {
    ///     bool inDebug = false;
    ///     assert(() { inDebug = true; return true; }());
    ///     // In debug mode, use the normal error widget which shows
    ///     // the error message:
    ///     if (inDebug)
    ///       return ErrorWidget(details.exception);
    ///     // In release builds, show a yellow-on-blue message instead:
    ///     return Container(
    ///       alignment: Alignment.center,
    ///       child: Text(
    ///         'Error!',
    ///         style: TextStyle(color: Colors.yellow),
    ///         textDirection: TextDirection.ltr,
    ///       ),
    ///     );
    ///   };
    ///   // Here we would normally runApp() the root widget, but to demonstrate
    ///   // the error handling we artificially fail:
    ///   return runApp(Builder(
    ///     builder: (BuildContext context) {
    ///       throw 'oh no, an error';
    ///     },
    ///   ));
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [FlutterError.onError], which can be set to a method that exits the
    ///    application if that is preferable to showing an error message.
    ///  * <https://flutter.dev/docs/testing/errors>, more information about error
    ///    handling in Flutter.
    /// </Summary>
    public class ErrorWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public ErrorWidget(@Object exception)
        : base(key: new UniqueKey())
        {

        }
        public static ErrorWidget WithDetails(string message = default(string), FlutterSDK.Foundation.Assertions.FlutterError error = default(FlutterSDK.Foundation.Assertions.FlutterError))
        {
            var instance = new ErrorWidget(key: new UniqueKey()); instance.Message = message;
        }
        public virtual FlutterSDK.Widgets.Framework.ErrorWidgetBuilder Builder { get; set; }
        public virtual string Message { get; set; }
        internal virtual FlutterSDK.Foundation.Assertions.FlutterError _FlutterError { get; set; }

        private FlutterSDK.Widgets.Framework.Widget _DefaultErrorWidgetBuilder(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details)
        {
            string message = "";

            object exception = details.Exception;
            return ErrorWidget.WithDetails(message: message, error: exception is FlutterError ? exception : null);
        }




        private string _Stringify(@Object exception)
        {
            try
            {
                return exception.ToString();
            }
            catch (e)
            {
            }

            return "Error";
        }




        public new FlutterSDK.Rendering.Box.RenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderErrorBox(Message);



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            if (_FlutterError == null) properties.Add(new StringProperty("message", Message, quoted: false)); else properties.Add(_FlutterError.ToDiagnosticsNode(style: DiagnosticsTreeStyle.Whitespace));
        }



    }


    /// <Summary>
    /// An [Element] that composes other [Element]s.
    ///
    /// Rather than creating a [RenderObject] directly, a [ComponentElement] creates
    /// [RenderObject]s indirectly by creating other [Element]s.
    ///
    /// Contrast with [RenderObjectElement].
    /// </Summary>
    public class ComponentElement : FlutterSDK.Widgets.Framework.Element
    {
        public ComponentElement(FlutterSDK.Widgets.Framework.Widget widget)
        : base(widget)
        {

        }
        internal virtual FlutterSDK.Widgets.Framework.Element _Child { get; set; }
        internal virtual bool _DebugDoingBuild { get; set; }
        public virtual bool DebugDoingBuild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);


            _FirstBuild();

        }




        private void _FirstBuild()
        {
            Rebuild();
        }




        /// <Summary>
        /// Calls the [StatelessWidget.build] method of the [StatelessWidget] object
        /// (for stateless widgets) or the [State.build] method of the [State] object
        /// (for stateful widgets) and then updates the widget tree.
        ///
        /// Called automatically during [mount] to generate the first build, and by
        /// [rebuild] when the element needs updating.
        /// </Summary>
        public new void PerformRebuild()
        {
            if (!ConstantsDefaultClass.KReleaseMode && DebugDefaultClass.DebugProfileBuildsEnabled) Dart: developerDefaultClass.Timeline.StartSync($"'{Widget.GetType()}'", arguments: DebugDefaultClass.TimelineWhitelistArguments);

            Widget built = default(Widget);
            try
            {

                built = Build();

                DebugDefaultClass.DebugWidgetBuilderValue(Widget, built);
            }
            catch (e,stack){
                _DebugDoingBuild = false;
                built = FrameworkDefaultClass.ErrorWidget.Builder(FrameworkDefaultClass._DebugReportException(new ErrorDescription($"'building {this }'"), e, stack, informationCollector: () =>
                {
                    yield return new DiagnosticsDebugCreator(new DebugCreator(this));
                }
                ));
            }
finally
            {
                _Dirty = false;

            }

            try
            {
                _Child = UpdateChild(_Child, built, Slot);

            }
            catch (e,stack){
                built = FrameworkDefaultClass.ErrorWidget.Builder(FrameworkDefaultClass._DebugReportException(new ErrorDescription($"'building {this }'"), e, stack, informationCollector: () =>
                {
                    yield return new DiagnosticsDebugCreator(new DebugCreator(this));
                }
                ));
                _Child = UpdateChild(null, built, Slot);
            }

            if (!ConstantsDefaultClass.KReleaseMode && DebugDefaultClass.DebugProfileBuildsEnabled) Dart: developerDefaultClass.Timeline.FinishSync();
            }




/// <Summary>
/// Subclasses should override this function to actually call the appropriate
/// `build` function (e.g., [StatelessWidget.build] or [State.build]) for
/// their widget.
/// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build()
        {
            return default(Widget);
        }


        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            if (_Child != null) visitor(_Child);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            _Child = null;
            base.ForgetChild(child);
        }



    }


    /// <Summary>
    /// An [Element] that uses a [StatelessWidget] as its configuration.
    /// </Summary>
    public class StatelessElement : FlutterSDK.Widgets.Framework.ComponentElement
    {
        public StatelessElement(FlutterSDK.Widgets.Framework.StatelessWidget widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Framework.StatelessWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build() => Widget.Build(this);



        public new void Update(FlutterSDK.Widgets.Framework.StatelessWidget newWidget)
        {
            base.Update(newWidget);

            _Dirty = true;
            Rebuild();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            _Dirty = true;
            Rebuild();
        }



    }


    /// <Summary>
    /// An [Element] that uses a [StatefulWidget] as its configuration.
    /// </Summary>
    public class StatefulElement : FlutterSDK.Widgets.Framework.ComponentElement
    {
        public StatefulElement(FlutterSDK.Widgets.Framework.StatefulWidget widget)
        : base(widget)
        {



            _State._Element = this;

            _State._Widget = widget;

        }


        internal virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> _State { get; set; }
        internal virtual bool _DidChangeDependencies { get; set; }
        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> State { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build() => _State.Build(this);



        public new void Reassemble()
        {
            State.Reassemble();
            base.Reassemble();
        }




        protected new void _FirstBuild()
        {

            try
            {
                _DebugSetAllowIgnoredCallsToMarkNeedsBuild(true);
                object debugCheckForReturnedFuture = _State.InitState() as object;

            }
            finally
            {
                _DebugSetAllowIgnoredCallsToMarkNeedsBuild(false);
            }


            _State.DidChangeDependencies();

            base._FirstBuild();
        }




        public new void PerformRebuild()
        {
            if (_DidChangeDependencies)
            {
                _State.DidChangeDependencies();
                _DidChangeDependencies = false;
            }

            base.PerformRebuild();
        }




        public new void Update(FlutterSDK.Widgets.Framework.StatefulWidget newWidget)
        {
            base.Update(newWidget);

            StatefulWidget oldWidget = _State._Widget;
            _Dirty = true;
            _State._Widget = Widget as StatefulWidget;
            try
            {
                _DebugSetAllowIgnoredCallsToMarkNeedsBuild(true);
                object debugCheckForReturnedFuture = _State.DidUpdateWidget(oldWidget) as object;

            }
            finally
            {
                _DebugSetAllowIgnoredCallsToMarkNeedsBuild(false);
            }

            Rebuild();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            StatefulWidget oldWidget = _State._Widget;
            _Dirty = true;
            _State._Widget = Widget as StatefulWidget;
            try
            {
                _DebugSetAllowIgnoredCallsToMarkNeedsBuild(true);
                object debugCheckForReturnedFuture = _State.DidUpdateWidget(oldWidget) as object;

            }
            finally
            {
                _DebugSetAllowIgnoredCallsToMarkNeedsBuild(false);
            }

            Rebuild();
        }




        public new void Activate()
        {
            base.Activate();

            MarkNeedsBuild();
        }




        public new void Deactivate()
        {
            _State.Deactivate();
            base.Deactivate();
        }




        public new void Unmount()
        {
            base.Unmount();
            _State.Dispose();

            _State._Element = null;
            _State = null;
        }




        public new FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.Element ancestor, @Object aspect = default(@Object))
        {
            return DependOnInheritedElement(ancestor, aspect: aspect);
        }




        public new FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.Element ancestor, @Object aspect = default(@Object))
        {


            return base.DependOnInheritedElement(ancestor as InheritedElement, aspect: aspect);
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _DidChangeDependencies = true;
        }




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new _ElementDiagnosticableTreeNode(name: name, value: this, style: style, stateful: true);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<State<StatefulWidget>>("state", State, defaultValue: null));
        }



    }


    /// <Summary>
    /// An [Element] that uses a [ProxyWidget] as its configuration.
    /// </Summary>
    public class ProxyElement : FlutterSDK.Widgets.Framework.ComponentElement
    {
        public ProxyElement(FlutterSDK.Widgets.Framework.ProxyWidget widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Framework.ProxyWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build() => Widget.Child;



        public new void Update(FlutterSDK.Widgets.Framework.ProxyWidget newWidget)
        {
            ProxyWidget oldWidget = Widget;


            base.Update(newWidget);

            Updated(oldWidget);
            _Dirty = true;
            Rebuild();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            ProxyWidget oldWidget = Widget;


            base.Update(newWidget);

            Updated(oldWidget);
            _Dirty = true;
            Rebuild();
        }




        /// <Summary>
        /// Called during build when the [widget] has changed.
        ///
        /// By default, calls [notifyClients]. Subclasses may override this method to
        /// avoid calling [notifyClients] unnecessarily (e.g. if the old and new
        /// widgets are equivalent).
        /// </Summary>
        public virtual void Updated(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget)
        {
            NotifyClients(oldWidget);
        }




        /// <Summary>
        /// Notify other objects that the widget associated with this element has
        /// changed.
        ///
        /// Called during [update] (via [updated]) after changing the widget
        /// associated with this element but before rebuilding this element.
        /// </Summary>
        public virtual void NotifyClients(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget)
        {
        }

    }


    /// <Summary>
    /// An [Element] that uses a [ParentDataWidget] as its configuration.
    /// </Summary>
    public class ParentDataElement<T> : FlutterSDK.Widgets.Framework.ProxyElement
    {
        public ParentDataElement(FlutterSDK.Widgets.Framework.ParentDataWidget<T> widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Framework.ParentDataWidget<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _ApplyParentData(FlutterSDK.Widgets.Framework.ParentDataWidget<T> widget)
        {
            void ApplyParentDataToChild(Element child)
            {
                if (child is RenderObjectElement)
                {
                    ((RenderObjectElement)child)._UpdateParentData(widget);
                }
                else
                {

                    child.VisitChildren(ApplyParentDataToChild);
                }

            }

            VisitChildren(ApplyParentDataToChild);
        }




        /// <Summary>
        /// Calls [ParentDataWidget.applyParentData] on the given widget, passing it
        /// the [RenderObject] whose parent data this element is ultimately
        /// responsible for.
        ///
        /// This allows a render object's [RenderObject.parentData] to be modified
        /// without triggering a build. This is generally ill-advised, but makes sense
        /// in situations such as the following:
        ///
        ///  * Build and layout are currently under way, but the [ParentData] in question
        ///    does not affect layout, and the value to be applied could not be
        ///    determined before build and layout (e.g. it depends on the layout of a
        ///    descendant).
        ///
        ///  * Paint is currently under way, but the [ParentData] in question does not
        ///    affect layout or paint, and the value to be applied could not be
        ///    determined before paint (e.g. it depends on the compositing phase).
        ///
        /// In either case, the next build is expected to cause this element to be
        /// configured with the given new widget (or a widget with equivalent data).
        ///
        /// Only [ParentDataWidget]s that return true for
        /// [ParentDataWidget.debugCanApplyOutOfTurn] can be applied this way.
        ///
        /// The new widget must have the same child as the current widget.
        ///
        /// An example of when this is used is the [AutomaticKeepAlive] widget. If it
        /// receives a notification during the build of one of its descendants saying
        /// that its child must be kept alive, it will apply a [KeepAlive] widget out
        /// of turn. This is safe, because by definition the child is already alive,
        /// and therefore this will not change the behavior of the parent this frame.
        /// It is more efficient than requesting an additional frame just for the
        /// purpose of updating the [KeepAlive] widget.
        /// </Summary>
        public virtual void ApplyWidgetOutOfTurn(FlutterSDK.Widgets.Framework.ParentDataWidget<T> newWidget)
        {



            _ApplyParentData(newWidget);
        }




        public new void NotifyClients(FlutterSDK.Widgets.Framework.ParentDataWidget<T> oldWidget)
        {
            _ApplyParentData(Widget);
        }



    }


    /// <Summary>
    /// An [Element] that uses an [InheritedWidget] as its configuration.
    /// </Summary>
    public class InheritedElement : FlutterSDK.Widgets.Framework.ProxyElement
    {
        public InheritedElement(FlutterSDK.Widgets.Framework.InheritedWidget widget)
        : base(widget)
        {

        }
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.Element, @Object> _Dependents { get; set; }
        public virtual FlutterSDK.Widgets.Framework.InheritedWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        protected new void _UpdateInheritance()
        {

            Dictionary<Type, InheritedElement> incomingWidgets = _Parent?._InheritedWidgets;
            if (incomingWidgets != null) _InheritedWidgets = HashMap<Type, InheritedElement>.From(incomingWidgets); else _InheritedWidgets = new HashMap<Type, InheritedElement>();
            _InheritedWidgets[Widget.GetType()] = this;
        }




        public new void DebugDeactivated()
        {

            base.DebugDeactivated();
        }




        /// <Summary>
        /// Returns the dependencies value recorded for [dependent]
        /// with [setDependencies].
        ///
        /// Each dependent element is mapped to a single object value
        /// which represents how the element depends on this
        /// [InheritedElement]. This value is null by default and by default
        /// dependent elements are rebuilt unconditionally.
        ///
        /// Subclasses can manage these values with [updateDependencies]
        /// so that they can selectively rebuild dependents in
        /// [notifyDependent].
        ///
        /// This method is typically only called in overrides of [updateDependencies].
        ///
        /// See also:
        ///
        ///  * [updateDependencies], which is called each time a dependency is
        ///    created with [dependOnInheritedWidgetOfExactType].
        ///  * [setDependencies], which sets dependencies value for a dependent
        ///    element.
        ///  * [notifyDependent], which can be overridden to use a dependent's
        ///    dependencies value to decide if the dependent needs to be rebuilt.
        ///  * [InheritedModel], which is an example of a class that uses this method
        ///    to manage dependency values.
        /// </Summary>
        public virtual @Object GetDependencies(FlutterSDK.Widgets.Framework.Element dependent)
        {
            return _Dependents[dependent];
        }




        /// <Summary>
        /// Sets the value returned by [getDependencies] value for [dependent].
        ///
        /// Each dependent element is mapped to a single object value
        /// which represents how the element depends on this
        /// [InheritedElement]. The [updateDependencies] method sets this value to
        /// null by default so that dependent elements are rebuilt unconditionally.
        ///
        /// Subclasses can manage these values with [updateDependencies]
        /// so that they can selectively rebuild dependents in [notifyDependent].
        ///
        /// This method is typically only called in overrides of [updateDependencies].
        ///
        /// See also:
        ///
        ///  * [updateDependencies], which is called each time a dependency is
        ///    created with [dependOnInheritedWidgetOfExactType].
        ///  * [getDependencies], which returns the current value for a dependent
        ///    element.
        ///  * [notifyDependent], which can be overridden to use a dependent's
        ///    [getDependencies] value to decide if the dependent needs to be rebuilt.
        ///  * [InheritedModel], which is an example of a class that uses this method
        ///    to manage dependency values.
        /// </Summary>
        public virtual void SetDependencies(FlutterSDK.Widgets.Framework.Element dependent, @Object value)
        {
            _Dependents[dependent] = value;
        }




        /// <Summary>
        /// Called by [dependOnInheritedWidgetOfExactType] when a new [dependent] is added.
        ///
        /// Each dependent element can be mapped to a single object value with
        /// [setDependencies]. This method can lookup the existing dependencies with
        /// [getDependencies].
        ///
        /// By default this method sets the inherited dependencies for [dependent]
        /// to null. This only serves to record an unconditional dependency on
        /// [dependent].
        ///
        /// Subclasses can manage their own dependencies values so that they
        /// can selectively rebuild dependents in [notifyDependent].
        ///
        /// See also:
        ///
        ///  * [getDependencies], which returns the current value for a dependent
        ///    element.
        ///  * [setDependencies], which sets the value for a dependent element.
        ///  * [notifyDependent], which can be overridden to use a dependent's
        ///    dependencies value to decide if the dependent needs to be rebuilt.
        ///  * [InheritedModel], which is an example of a class that uses this method
        ///    to manage dependency values.
        /// </Summary>
        public virtual void UpdateDependencies(FlutterSDK.Widgets.Framework.Element dependent, @Object aspect)
        {
            SetDependencies(dependent, null);
        }




        /// <Summary>
        /// Called by [notifyClients] for each dependent.
        ///
        /// Calls `dependent.didChangeDependencies()` by default.
        ///
        /// Subclasses can override this method to selectively call
        /// [didChangeDependencies] based on the value of [getDependencies].
        ///
        /// See also:
        ///
        ///  * [updateDependencies], which is called each time a dependency is
        ///    created with [dependOnInheritedWidgetOfExactType].
        ///  * [getDependencies], which returns the current value for a dependent
        ///    element.
        ///  * [setDependencies], which sets the value for a dependent element.
        ///  * [InheritedModel], which is an example of a class that uses this method
        ///    to manage dependency values.
        /// </Summary>
        public virtual void NotifyDependent(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget, FlutterSDK.Widgets.Framework.Element dependent)
        {
            dependent.DidChangeDependencies();
        }




        /// <Summary>
        /// Calls [Element.didChangeDependencies] of all dependent elements, if
        /// [InheritedWidget.updateShouldNotify] returns true.
        ///
        /// Called by [update], immediately prior to [build].
        ///
        /// Calls [notifyClients] to actually trigger the notifications.
        /// </Summary>
        public new void Updated(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            if (Widget.UpdateShouldNotify(oldWidget)) base.Updated(oldWidget);
        }


        public new void Updated(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget)
        {
            if (Widget.UpdateShouldNotify(oldWidget)) base.Updated(oldWidget);
        }




        /// <Summary>
        /// Notifies all dependent elements that this inherited widget has changed, by
        /// calling [Element.didChangeDependencies].
        ///
        /// This method must only be called during the build phase. Usually this
        /// method is called automatically when an inherited widget is rebuilt, e.g.
        /// as a result of calling [State.setState] above the inherited widget.
        ///
        /// See also:
        ///
        ///  * [InheritedNotifier], a subclass of [InheritedWidget] that also calls
        ///    this method when its [Listenable] sends a notification.
        /// </Summary>
        public new void NotifyClients(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {

            foreach (Element dependent in _Dependents.Keys)
            {


                NotifyDependent(oldWidget, dependent);
            }

        }


        public new void NotifyClients(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget)
        {

            foreach (Element dependent in _Dependents.Keys)
            {


                NotifyDependent(oldWidget, dependent);
            }

        }



    }


    /// <Summary>
    /// An [Element] that uses a [RenderObjectWidget] as its configuration.
    ///
    /// [RenderObjectElement] objects have an associated [RenderObject] widget in
    /// the render tree, which handles concrete operations like laying out,
    /// painting, and hit testing.
    ///
    /// Contrast with [ComponentElement].
    ///
    /// For details on the lifecycle of an element, see the discussion at [Element].
    ///
    /// ## Writing a RenderObjectElement subclass
    ///
    /// There are three common child models used by most [RenderObject]s:
    ///
    /// * Leaf render objects, with no children: The [LeafRenderObjectElement] class
    ///   handles this case.
    ///
    /// * A single child: The [SingleChildRenderObjectElement] class handles this
    ///   case.
    ///
    /// * A linked list of children: The [MultiChildRenderObjectElement] class
    ///   handles this case.
    ///
    /// Sometimes, however, a render object's child model is more complicated. Maybe
    /// it has a two-dimensional array of children. Maybe it constructs children on
    /// demand. Maybe it features multiple lists. In such situations, the
    /// corresponding [Element] for the [Widget] that configures that [RenderObject]
    /// will be a new subclass of [RenderObjectElement].
    ///
    /// Such a subclass is responsible for managing children, specifically the
    /// [Element] children of this object, and the [RenderObject] children of its
    /// corresponding [RenderObject].
    ///
    /// ### Specializing the getters
    ///
    /// [RenderObjectElement] objects spend much of their time acting as
    /// intermediaries between their [widget] and their [renderObject]. To make this
    /// more tractable, most [RenderObjectElement] subclasses override these getters
    /// so that they return the specific type that the element expects, e.g.:
    ///
    /// ```dart
    /// class FooElement extends RenderObjectElement {
    ///
    ///   @override
    ///   Foo get widget => super.widget;
    ///
    ///   @override
    ///   RenderFoo get renderObject => super.renderObject;
    ///
    ///   // ...
    /// }
    /// ```
    ///
    /// ### Slots
    ///
    /// Each child [Element] corresponds to a [RenderObject] which should be
    /// attached to this element's render object as a child.
    ///
    /// However, the immediate children of the element may not be the ones that
    /// eventually produce the actual [RenderObject] that they correspond to. For
    /// example a [StatelessElement] (the element of a [StatelessWidget]) simply
    /// corresponds to whatever [RenderObject] its child (the element returned by
    /// its [StatelessWidget.build] method) corresponds to.
    ///
    /// Each child is therefore assigned a _slot_ token. This is an identifier whose
    /// meaning is private to this [RenderObjectElement] node. When the descendant
    /// that finally produces the [RenderObject] is ready to attach it to this
    /// node's render object, it passes that slot token back to this node, and that
    /// allows this node to cheaply identify where to put the child render object
    /// relative to the others in the parent render object.
    ///
    /// ### Updating children
    ///
    /// Early in the lifecycle of an element, the framework calls the [mount]
    /// method. This method should call [updateChild] for each child, passing in
    /// the widget for that child, and the slot for that child, thus obtaining a
    /// list of child [Element]s.
    ///
    /// Subsequently, the framework will call the [update] method. In this method,
    /// the [RenderObjectElement] should call [updateChild] for each child, passing
    /// in the [Element] that was obtained during [mount] or the last time [update]
    /// was run (whichever happened most recently), the new [Widget], and the slot.
    /// This provides the object with a new list of [Element] objects.
    ///
    /// Where possible, the [update] method should attempt to map the elements from
    /// the last pass to the widgets in the new pass. For example, if one of the
    /// elements from the last pass was configured with a particular [Key], and one
    /// of the widgets in this new pass has that same key, they should be paired up,
    /// and the old element should be updated with the widget (and the slot
    /// corresponding to the new widget's new position, also). The [updateChildren]
    /// method may be useful in this regard.
    ///
    /// [updateChild] should be called for children in their logical order. The
    /// order can matter; for example, if two of the children use [PageStorage]'s
    /// `writeState` feature in their build method (and neither has a [Widget.key]),
    /// then the state written by the first will be overwritten by the second.
    ///
    /// #### Dynamically determining the children during the build phase
    ///
    /// The child widgets need not necessarily come from this element's widget
    /// verbatim. They could be generated dynamically from a callback, or generated
    /// in other more creative ways.
    ///
    /// #### Dynamically determining the children during layout
    ///
    /// If the widgets are to be generated at layout time, then generating them when
    /// the [update] method won't work: layout of this element's render object
    /// hasn't started yet at that point. Instead, the [update] method can mark the
    /// render object as needing layout (see [RenderObject.markNeedsLayout]), and
    /// then the render object's [RenderObject.performLayout] method can call back
    /// to the element to have it generate the widgets and call [updateChild]
    /// accordingly.
    ///
    /// For a render object to call an element during layout, it must use
    /// [RenderObject.invokeLayoutCallback]. For an element to call [updateChild]
    /// outside of its [update] method, it must use [BuildOwner.buildScope].
    ///
    /// The framework provides many more checks in normal operation than it does
    /// when doing a build during layout. For this reason, creating widgets with
    /// layout-time build semantics should be done with great care.
    ///
    /// #### Handling errors when building
    ///
    /// If an element calls a builder function to obtain widgets for its children,
    /// it may find that the build throws an exception. Such exceptions should be
    /// caught and reported using [FlutterError.reportError]. If a child is needed
    /// but a builder has failed in this way, an instance of [ErrorWidget] can be
    /// used instead.
    ///
    /// ### Detaching children
    ///
    /// It is possible, when using [GlobalKey]s, for a child to be proactively
    /// removed by another element before this element has been updated.
    /// (Specifically, this happens when the subtree rooted at a widget with a
    /// particular [GlobalKey] is being moved from this element to an element
    /// processed earlier in the build phase.) When this happens, this element's
    /// [forgetChild] method will be called with a reference to the affected child
    /// element.
    ///
    /// The [forgetChild] method of a [RenderObjectElement] subclass must remove the
    /// child element from its child list, so that when it next [update]s its
    /// children, the removed child is not considered.
    ///
    /// For performance reasons, if there are many elements, it may be quicker to
    /// track which elements were forgotten by storing them in a [Set], rather than
    /// proactively mutating the local record of the child list and the identities
    /// of all the slots. For example, see the implementation of
    /// [MultiChildRenderObjectElement].
    ///
    /// ### Maintaining the render object tree
    ///
    /// Once a descendant produces a render object, it will call
    /// [insertChildRenderObject]. If the descendant's slot changes identity, it
    /// will call [moveChildRenderObject]. If a descendant goes away, it will call
    /// [removeChildRenderObject].
    ///
    /// These three methods should update the render tree accordingly, attaching,
    /// moving, and detaching the given child render object from this element's own
    /// render object respectively.
    ///
    /// ### Walking the children
    ///
    /// If a [RenderObjectElement] object has any children [Element]s, it must
    /// expose them in its implementation of the [visitChildren] method. This method
    /// is used by many of the framework's internal mechanisms, and so should be
    /// fast. It is also used by the test framework and [debugDumpApp].
    /// </Summary>
    public class RenderObjectElement : FlutterSDK.Widgets.Framework.Element
    {
        public RenderObjectElement(FlutterSDK.Widgets.Framework.RenderObjectWidget widget)
        : base(widget)
        {

        }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _RenderObject { get; set; }
        internal virtual bool _DebugDoingBuild { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.RenderObjectElement _AncestorRenderObjectElement { get; set; }
        public virtual FlutterSDK.Widgets.Framework.RenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingBuild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private FlutterSDK.Widgets.Framework.RenderObjectElement _FindAncestorRenderObjectElement()
        {
            Element ancestor = _Parent;
            while (ancestor != null && !(ancestor is RenderObjectElement)) ancestor = ancestor._Parent;
            return ancestor as RenderObjectElement;
        }




        private FlutterSDK.Widgets.Framework.ParentDataElement<FlutterSDK.Rendering.@object.ParentData> _FindAncestorParentDataElement()
        {
            Element ancestor = _Parent;
            ParentDataElement<ParentData> result = default(ParentDataElement<ParentData>);
            while (ancestor != null && !(ancestor is RenderObjectElement))
            {
                if (ancestor is ParentDataElement<ParentData>)
                {
                    result = ((RenderObjectElement)ancestor) as ParentDataElement<ParentData>;
                    break;
                }

                ancestor = ancestor._Parent;
            }


            return result;
        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);

            _RenderObject = Widget.CreateRenderObject(this);



            AttachRenderObject(newSlot);
            _Dirty = false;
        }




        public new void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget)
        {
            base.Update(newWidget);



            Widget.UpdateRenderObject(this, RenderObject);

            _Dirty = false;
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);



            Widget.UpdateRenderObject(this, RenderObject);

            _Dirty = false;
        }




        private void _DebugUpdateRenderObjectOwner()
        {

        }




        public new void PerformRebuild()
        {

            Widget.UpdateRenderObject(this, RenderObject);

            _Dirty = false;
        }




        /// <Summary>
        /// Updates the children of this element to use new widgets.
        ///
        /// Attempts to update the given old children list using the given new
        /// widgets, removing obsolete elements and introducing new ones as necessary,
        /// and then returns the new child list.
        ///
        /// During this function the `oldChildren` list must not be modified. If the
        /// caller wishes to remove elements from `oldChildren` re-entrantly while
        /// this function is on the stack, the caller can supply a `forgottenChildren`
        /// argument, which can be modified while this function is on the stack.
        /// Whenever this function reads from `oldChildren`, this function first
        /// checks whether the child is in `forgottenChildren`. If it is, the function
        /// acts as if the child was not in `oldChildren`.
        ///
        /// This function is a convenience wrapper around [updateChild], which updates
        /// each individual child. When calling [updateChild], this function uses an
        /// [IndexedSlot<Element>] as the value for the `newSlot` argument.
        /// [IndexedSlot.index] is set to the index that the currently processed
        /// `child` corresponds to in the `newWidgets` list and [IndexedSlot.value] is
        /// set to the [Element] of the previous widget in that list (or null if it is
        /// the first child).
        ///
        /// When the [slot] value of an [Element] changes, its
        /// associated [renderObject] needs to move to a new position in the child
        /// list of its parents. If that [RenderObject] organizes its children in a
        /// linked list (as is done by the [ContainerRenderObjectMixin]) this can
        /// be implemented by re-inserting the child [RenderObject] into the
        /// list after the [RenderObject] associated with the [Element] provided as
        /// [IndexedSlot.value] in the [slot] object.
        ///
        /// Simply using the previous sibling as a [slot] is not enough, though, because
        /// child [RenderObject]s are only moved around when the [slot] of their
        /// associated [RenderObjectElement]s is updated. When the order of child
        /// [Element]s is changed, some elements in the list may move to a new index
        /// but still have the same previous sibling. For example, when
        /// `[e1, e2, e3, e4]` is changed to `[e1, e3, e4, e2]` the element e4
        /// continues to have e3 as a previous sibling even though its index in the list
        /// has changed and its [RenderObject] needs to move to come before e2's
        /// [RenderObject]. In order to trigger this move, a new [slot] value needs to
        /// be assigned to its [Element] whenever its index in its
        /// parent's child list changes. Using an [IndexedSlot<Element>] achieves
        /// exactly that and also ensures that the underlying parent [RenderObject]
        /// knows where a child needs to move to in a linked list by providing its new
        /// previous sibling.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Element> UpdateChildren(List<FlutterSDK.Widgets.Framework.Element> oldChildren, List<FlutterSDK.Widgets.Framework.Widget> newWidgets, HashSet<FlutterSDK.Widgets.Framework.Element> forgottenChildren = default(HashSet<FlutterSDK.Widgets.Framework.Element>))
        {


            Element ReplaceWithNullIfForgotten(Element child)
            {
                return forgottenChildren != null && forgottenChildren.Contains(child) ? null : child;
            }

            int newChildrenTop = 0;
            int oldChildrenTop = 0;
            int newChildrenBottom = newWidgets.Count - 1;
            int oldChildrenBottom = oldChildren.Count - 1;
            List<Element> newChildren = oldChildren.Count == newWidgets.Count ? oldChildren : new List<Element>(newWidgets.Count);
            Element previousChild = default(Element);
            while ((oldChildrenTop <= oldChildrenBottom) && (newChildrenTop <= newChildrenBottom))
            {
                Element oldChild = ReplaceWithNullIfForgotten(oldChildren[oldChildrenTop]);
                Widget newWidget = newWidgets[newChildrenTop];

                if (oldChild == null || !FrameworkDefaultClass.Widget.CanUpdate(oldChild.Widget, newWidget)) break;
                Element newChild = UpdateChild(oldChild, newWidget, new IndexedSlot<Element>(newChildrenTop, previousChild));

                newChildren[newChildrenTop] = newChild;
                previousChild = newChild;
                newChildrenTop += 1;
                oldChildrenTop += 1;
            }

            while ((oldChildrenTop <= oldChildrenBottom) && (newChildrenTop <= newChildrenBottom))
            {
                Element oldChild = ReplaceWithNullIfForgotten(oldChildren[oldChildrenBottom]);
                Widget newWidget = newWidgets[newChildrenBottom];

                if (oldChild == null || !FrameworkDefaultClass.Widget.CanUpdate(oldChild.Widget, newWidget)) break;
                oldChildrenBottom -= 1;
                newChildrenBottom -= 1;
            }

            bool haveOldChildren = oldChildrenTop <= oldChildrenBottom;
            Dictionary<Key, Element> oldKeyedChildren = default(Dictionary<Key, Element>);
            if (haveOldChildren)
            {
                oldKeyedChildren = new Dictionary<Key, Element> { };
                while (oldChildrenTop <= oldChildrenBottom)
                {
                    Element oldChild = ReplaceWithNullIfForgotten(oldChildren[oldChildrenTop]);

                    if (oldChild != null)
                    {
                        if (oldChild.Widget.Key != null) oldKeyedChildren[oldChild.Widget.Key] = oldChild; else DeactivateChild(oldChild);
                    }

                    oldChildrenTop += 1;
                }

            }

            while (newChildrenTop <= newChildrenBottom)
            {
                Element oldChild = default(Element);
                Widget newWidget = newWidgets[newChildrenTop];
                if (haveOldChildren)
                {
                    Key key = newWidget.Key;
                    if (key != null)
                    {
                        oldChild = oldKeyedChildren[key];
                        if (oldChild != null)
                        {
                            if (FrameworkDefaultClass.Widget.CanUpdate(oldChild.Widget, newWidget))
                            {
                                oldKeyedChildren.Remove(key);
                            }
                            else
                            {
                                oldChild = null;
                            }

                        }

                    }

                }


                Element newChild = UpdateChild(oldChild, newWidget, new IndexedSlot<Element>(newChildrenTop, previousChild));


                newChildren[newChildrenTop] = newChild;
                previousChild = newChild;
                newChildrenTop += 1;
            }




            newChildrenBottom = newWidgets.Count - 1;
            oldChildrenBottom = oldChildren.Count - 1;
            while ((oldChildrenTop <= oldChildrenBottom) && (newChildrenTop <= newChildrenBottom))
            {
                Element oldChild = oldChildren[oldChildrenTop];


                Widget newWidget = newWidgets[newChildrenTop];

                Element newChild = UpdateChild(oldChild, newWidget, new IndexedSlot<Element>(newChildrenTop, previousChild));


                newChildren[newChildrenTop] = newChild;
                previousChild = newChild;
                newChildrenTop += 1;
                oldChildrenTop += 1;
            }

            if (haveOldChildren && oldKeyedChildren.IsNotEmpty)
            {
                foreach (Element oldChild in oldKeyedChildren.Values)
                {
                    if (forgottenChildren == null || !forgottenChildren.Contains(oldChild)) DeactivateChild(oldChild);
                }

            }

            return newChildren;
        }




        public new void Deactivate()
        {
            base.Deactivate();

        }




        public new void Unmount()
        {
            base.Unmount();

            Widget.DidUnmountRenderObject(RenderObject);
        }




        private void _UpdateParentData(FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.@object.ParentData> parentDataWidget)
        {
            bool applyParentData = true;

            if (applyParentData) parentDataWidget.ApplyParentData(RenderObject);
        }




        protected new void _UpdateSlot(object newSlot)
        {

            base._UpdateSlot(newSlot);

            _AncestorRenderObjectElement.MoveChildRenderObject(RenderObject, Slot);
        }




        public new void AttachRenderObject(object newSlot)
        {

            _Slot = newSlot;
            _AncestorRenderObjectElement = _FindAncestorRenderObjectElement();
            _AncestorRenderObjectElement?.InsertChildRenderObject(RenderObject, newSlot);
            ParentDataElement<ParentData> parentDataElement = _FindAncestorParentDataElement();
            if (parentDataElement != null) _UpdateParentData(parentDataElement.Widget);
        }




        public new void DetachRenderObject()
        {
            if (_AncestorRenderObjectElement != null)
            {
                _AncestorRenderObjectElement.RemoveChildRenderObject(RenderObject);
                _AncestorRenderObjectElement = null;
            }

            _Slot = null;
        }




        /// <Summary>
        /// Insert the given child into [renderObject] at the given slot.
        ///
        /// {@template flutter.widgets.slots}
        /// The semantics of `slot` are determined by this element. For example, if
        /// this element has a single child, the slot should always be null. If this
        /// element has a list of children, the previous sibling element wrapped in an
        /// [IndexedSlot] is a convenient value for the slot.
        /// {@endtemplate}
        /// </Summary>
        public virtual void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
        }


        /// <Summary>
        /// Move the given child to the given slot.
        ///
        /// The given child is guaranteed to have [renderObject] as its parent.
        ///
        /// {@macro flutter.widgets.slots}
        ///
        /// This method is only ever called if [updateChild] can end up being called
        /// with an existing [Element] child and a `slot` that differs from the slot
        /// that element was previously given. [MultiChildRenderObjectElement] does this,
        /// for example. [SingleChildRenderObjectElement] does not (since the `slot` is
        /// always null). An [Element] that has a specific set of slots with each child
        /// always having the same slot (and where children in different slots are never
        /// compared against each other for the purposes of updating one slot with the
        /// element from another slot) would never call this.
        /// </Summary>
        public virtual void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
        }


        /// <Summary>
        /// Remove the given child from [renderObject].
        ///
        /// The given child is guaranteed to have [renderObject] as its parent.
        /// </Summary>
        public virtual void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {
        }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<RenderObject>("renderObject", RenderObject, defaultValue: null));
        }



    }


    /// <Summary>
    /// The element at the root of the tree.
    ///
    /// Only root elements may have their owner set explicitly. All other
    /// elements inherit their owner from their parent.
    /// </Summary>
    public class RootRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public RootRenderObjectElement(FlutterSDK.Widgets.Framework.RenderObjectWidget widget)
        : base(widget)
        {

        }

        /// <Summary>
        /// Set the owner of the element. The owner will be propagated to all the
        /// descendants of this element.
        ///
        /// The owner manages the dirty elements list.
        ///
        /// The [WidgetsBinding] introduces the primary owner,
        /// [WidgetsBinding.buildOwner], and assigns it to the widget tree in the call
        /// to [runApp]. The binding is responsible for driving the build pipeline by
        /// calling the build owner's [BuildOwner.buildScope] method. See
        /// [WidgetsBinding.drawFrame].
        /// </Summary>
        public virtual void AssignOwner(FlutterSDK.Widgets.Framework.BuildOwner owner)
        {
            _Owner = owner;
        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {


            base.Mount(parent, newSlot);
        }



    }


    /// <Summary>
    /// An [Element] that uses a [LeafRenderObjectWidget] as its configuration.
    /// </Summary>
    public class LeafRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public LeafRenderObjectElement(FlutterSDK.Widgets.Framework.LeafRenderObjectWidget widget)
        : base(widget)
        {

        }

        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            base.ForgetChild(child);
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {

        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            return Widget.DebugDescribeChildren();
        }



    }


    /// <Summary>
    /// An [Element] that uses a [SingleChildRenderObjectWidget] as its configuration.
    ///
    /// The child is optional.
    ///
    /// This element subclass can be used for RenderObjectWidgets whose
    /// RenderObjects use the [RenderObjectWithChildMixin] mixin. Such widgets are
    /// expected to inherit from [SingleChildRenderObjectWidget].
    /// </Summary>
    public class SingleChildRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public SingleChildRenderObjectElement(FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget widget)
        : base(widget)
        {

        }
        internal virtual FlutterSDK.Widgets.Framework.Element _Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            if (_Child != null) visitor(_Child);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            _Child = null;
            base.ForgetChild(child);
        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _Child = UpdateChild(_Child, Widget.Child, null);
        }




        public new void Update(FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget newWidget)
        {
            base.Update(newWidget);

            _Child = UpdateChild(_Child, Widget.Child, null);
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            _Child = UpdateChild(_Child, Widget.Child, null);
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            RenderObjectWithChildMixin<RenderObject> renderObject = this.RenderObject as RenderObjectWithChildMixin<RenderObject>;


            renderObject.Child = child;

        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {
            RenderObjectWithChildMixin<RenderObject> renderObject = this.RenderObject as RenderObjectWithChildMixin<RenderObject>;

            renderObject.Child = null;

        }



    }


    /// <Summary>
    /// An [Element] that uses a [MultiChildRenderObjectWidget] as its configuration.
    ///
    /// This element subclass can be used for RenderObjectWidgets whose
    /// RenderObjects use the [ContainerRenderObjectMixin] mixin with a parent data
    /// type that implements [ContainerParentDataMixin<RenderObject>]. Such widgets
    /// are expected to inherit from [MultiChildRenderObjectWidget].
    ///
    /// See also:
    ///
    /// * [IndexedSlot], which is used as [Element.slot]s for the children of a
    ///   [MultiChildRenderObjectElement].
    /// * [RenderObjectElement.updateChildren], which discusses why [IndexedSlot]
    ///   is used for the slots of the children.
    /// </Summary>
    public class MultiChildRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public MultiChildRenderObjectElement(FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget widget)
        : base(widget)
        {

        }
        internal virtual List<FlutterSDK.Widgets.Framework.Element> _Children { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _ForgottenChildren { get; set; }
        public virtual FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Framework.Element> Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Widgets.Framework.IndexedSlot<FlutterSDK.Widgets.Framework.Element> slot)
        {
            ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>> renderObject = this.RenderObject as ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>>;

            renderObject.Insert(child, after: slot?.Value?.RenderObject);

        }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>> renderObject = this.RenderObject as ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>>;

            renderObject.Insert(child, after: slot?.Value?.RenderObject);

        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Widgets.Framework.IndexedSlot<FlutterSDK.Widgets.Framework.Element> slot)
        {
            ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>> renderObject = this.RenderObject as ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>>;

            renderObject.Move(child, after: slot?.Value?.RenderObject);

        }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>> renderObject = this.RenderObject as ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>>;

            renderObject.Move(child, after: slot?.Value?.RenderObject);

        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {
            ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>> renderObject = this.RenderObject as ContainerRenderObjectMixin<RenderObject, ContainerParentDataMixin<RenderObject>>;

            renderObject.Remove(child);

        }




        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            foreach (Element child in _Children)
            {
                if (!_ForgottenChildren.Contains(child)) visitor(child);
            }

        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {


            _ForgottenChildren.Add(child);
            base.ForgetChild(child);
        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _Children = new List<Element>(Widget.Children.Count);
            Element previousChild = default(Element);
            for (int i = 0; i < _Children.Count; i += 1)
            {
                Element newChild = InflateWidget(Widget.Children[i], new IndexedSlot<Element>(i, previousChild));
                _Children[i] = newChild;
                previousChild = newChild;
            }

        }




        public new void Update(FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget newWidget)
        {
            base.Update(newWidget);

            _Children = UpdateChildren(_Children, Widget.Children, forgottenChildren: _ForgottenChildren);
            _ForgottenChildren.Clear();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            _Children = UpdateChildren(_Children, Widget.Children, forgottenChildren: _ForgottenChildren);
            _ForgottenChildren.Clear();
        }



    }


    /// <Summary>
    /// A wrapper class for the [Element] that is the creator of a [RenderObject].
    ///
    /// Attaching a [DebugCreator] attach the [RenderObject] will lead to better error
    /// message.
    /// </Summary>
    public class DebugCreator
    {
        public DebugCreator(FlutterSDK.Widgets.Framework.Element element)
        {
            this.Element = element;
        }
        public virtual FlutterSDK.Widgets.Framework.Element Element { get; set; }

    }


    /// <Summary>
    /// A value for [Element.slot] used for children of
    /// [MultiChildRenderObjectElement]s.
    ///
    /// A slot for a [MultiChildRenderObjectElement] consists of an [index]
    /// identifying where the child occupying this slot is located in the
    /// [MultiChildRenderObjectElement]'s child list and an arbitrary [value] that
    /// can further define where the child occupying this slot fits in its
    /// parent's child list.
    ///
    /// See also:
    ///
    ///  * [RenderObjectElement.updateChildren], which discusses why this class is
    ///    used as slot values for the children of a [MultiChildRenderObjectElement].
    /// </Summary>
    public class IndexedSlot<T>
    {
        public IndexedSlot(int index, T value)
        {
            this.Index = index;
            this.Value = value;
        }
        public virtual T Value { get; set; }
        public virtual int Index { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is IndexedSlot && Index == other.Index && Value == other.Value;
        }



    }


    /// <Summary>
    /// Tracks the lifecycle of [State] objects when asserts are enabled.
    /// </Summary>
    public enum _StateLifecycle
    {

        /// <Summary>
        /// The [State] object has been created. [State.initState] is called at this
        /// time.
        /// </Summary>
        Created,
        /// <Summary>
        /// The [State.initState] method has been called but the [State] object is
        /// not yet ready to build. [State.didChangeDependencies] is called at this time.
        /// </Summary>
        Initialized,
        /// <Summary>
        /// The [State] object is ready to build and [State.dispose] has not yet been
        /// called.
        /// </Summary>
        Ready,
        /// <Summary>
        /// The [State.dispose] method has been called and the [State] object is
        /// no longer able to build.
        /// </Summary>
        Defunct,
    }


    public enum _ElementLifecycle
    {

        Initial,
        Active,
        Inactive,
        Defunct,
    }

}
