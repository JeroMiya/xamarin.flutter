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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Rendering.Box
{
    public delegate bool BoxHitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position);
    internal static class BoxDefaultClass
    {
    }

    /// <Summary>
    /// Abstract [ParentData] subclass for [RenderBox] subclasses that want the
    /// [ContainerRenderObjectMixin].
    ///
    /// This is a convenience class that mixes in the relevant classes with
    /// the relevant type arguments.
    /// </Summary>
    public interface IContainerBoxParentData<ChildType>
    {
    }


    /// <Summary>
    /// A render object in a 2D Cartesian coordinate system.
    ///
    /// The [size] of each box is expressed as a width and a height. Each box has
    /// its own coordinate system in which its upper left corner is placed at (0,
    /// 0). The lower right corner of the box is therefore at (width, height). The
    /// box contains all the points including the upper left corner and extending
    /// to, but not including, the lower right corner.
    ///
    /// Box layout is performed by passing a [BoxConstraints] object down the tree.
    /// The box constraints establish a min and max value for the child's width and
    /// height. In determining its size, the child must respect the constraints
    /// given to it by its parent.
    ///
    /// This protocol is sufficient for expressing a number of common box layout
    /// data flows. For example, to implement a width-in-height-out data flow, call
    /// your child's [layout] function with a set of box constraints with a tight
    /// width value (and pass true for parentUsesSize). After the child determines
    /// its height, use the child's height to determine your size.
    ///
    /// ## Writing a RenderBox subclass
    ///
    /// One would implement a new [RenderBox] subclass to describe a new layout
    /// model, new paint model, new hit-testing model, or new semantics model, while
    /// remaining in the Cartesian space defined by the [RenderBox] protocol.
    ///
    /// To create a new protocol, consider subclassing [RenderObject] instead.
    ///
    /// ### Constructors and properties of a new RenderBox subclass
    ///
    /// The constructor will typically take a named argument for each property of
    /// the class. The value is then passed to a private field of the class and the
    /// constructor asserts its correctness (e.g. if it should not be null, it
    /// asserts it's not null).
    ///
    /// Properties have the form of a getter/setter/field group like the following:
    ///
    /// ```dart
    /// AxisDirection get axis => _axis;
    /// AxisDirection _axis;
    /// set axis(AxisDirection value) {
    ///   assert(value != null); // same check as in the constructor
    ///   if (value == _axis)
    ///     return;
    ///   _axis = value;
    ///   markNeedsLayout();
    /// }
    /// ```
    ///
    /// The setter will typically finish with either a call to [markNeedsLayout], if
    /// the layout uses this property, or [markNeedsPaint], if only the painter
    /// function does. (No need to call both, [markNeedsLayout] implies
    /// [markNeedsPaint].)
    ///
    /// Consider layout and paint to be expensive; be conservative about calling
    /// [markNeedsLayout] or [markNeedsPaint]. They should only be called if the
    /// layout (or paint, respectively) has actually changed.
    ///
    /// ### Children
    ///
    /// If a render object is a leaf, that is, it cannot have any children, then
    /// ignore this section. (Examples of leaf render objects are [RenderImage] and
    /// [RenderParagraph].)
    ///
    /// For render objects with children, there are four possible scenarios:
    ///
    /// * A single [RenderBox] child. In this scenario, consider inheriting from
    ///   [RenderProxyBox] (if the render object sizes itself to match the child) or
    ///   [RenderShiftedBox] (if the child will be smaller than the box and the box
    ///   will align the child inside itself).
    ///
    /// * A single child, but it isn't a [RenderBox]. Use the
    ///   [RenderObjectWithChildMixin] mixin.
    ///
    /// * A single list of children. Use the [ContainerRenderObjectMixin] mixin.
    ///
    /// * A more complicated child model.
    ///
    /// #### Using RenderProxyBox
    ///
    /// By default, a [RenderProxyBox] render object sizes itself to fit its child, or
    /// to be as small as possible if there is no child; it passes all hit testing
    /// and painting on to the child, and intrinsic dimensions and baseline
    /// measurements similarly are proxied to the child.
    ///
    /// A subclass of [RenderProxyBox] just needs to override the parts of the
    /// [RenderBox] protocol that matter. For example, [RenderOpacity] just
    /// overrides the paint method (and [alwaysNeedsCompositing] to reflect what the
    /// paint method does, and the [visitChildrenForSemantics] method so that the
    /// child is hidden from accessibility tools when it's invisible), and adds an
    /// [RenderOpacity.opacity] field.
    ///
    /// [RenderProxyBox] assumes that the child is the size of the parent and
    /// positioned at 0,0. If this is not true, then use [RenderShiftedBox] instead.
    ///
    /// See
    /// [proxy_box.dart](https://github.com/flutter/flutter/blob/master/packages/flutter/lib/src/rendering/proxy_box.dart)
    /// for examples of inheriting from [RenderProxyBox].
    ///
    /// #### Using RenderShiftedBox
    ///
    /// By default, a [RenderShiftedBox] acts much like a [RenderProxyBox] but
    /// without assuming that the child is positioned at 0,0 (the actual position
    /// recorded in the child's [parentData] field is used), and without providing a
    /// default layout algorithm.
    ///
    /// See
    /// [shifted_box.dart](https://github.com/flutter/flutter/blob/master/packages/flutter/lib/src/rendering/shifted_box.dart)
    /// for examples of inheriting from [RenderShiftedBox].
    ///
    /// #### Kinds of children and child-specific data
    ///
    /// A [RenderBox] doesn't have to have [RenderBox] children. One can use another
    /// subclass of [RenderObject] for a [RenderBox]'s children. See the discussion
    /// at [RenderObject].
    ///
    /// Children can have additional data owned by the parent but stored on the
    /// child using the [parentData] field. The class used for that data must
    /// inherit from [ParentData]. The [setupParentData] method is used to
    /// initialize the [parentData] field of a child when the child is attached.
    ///
    /// By convention, [RenderBox] objects that have [RenderBox] children use the
    /// [BoxParentData] class, which has a [BoxParentData.offset] field to store the
    /// position of the child relative to the parent. ([RenderProxyBox] does not
    /// need this offset and therefore is an exception to this rule.)
    ///
    /// #### Using RenderObjectWithChildMixin
    ///
    /// If a render object has a single child but it isn't a [RenderBox], then the
    /// [RenderObjectWithChildMixin] class, which is a mixin that will handle the
    /// boilerplate of managing a child, will be useful.
    ///
    /// It's a generic class with one type argument, the type of the child. For
    /// example, if you are building a `RenderFoo` class which takes a single
    /// `RenderBar` child, you would use the mixin as follows:
    ///
    /// ```dart
    /// class RenderFoo extends RenderBox
    ///   with RenderObjectWithChildMixin<RenderBar> {
    ///   // ...
    /// }
    /// ```
    ///
    /// Since the `RenderFoo` class itself is still a [RenderBox] in this case, you
    /// still have to implement the [RenderBox] layout algorithm, as well as
    /// features like intrinsics and baselines, painting, and hit testing.
    ///
    /// #### Using ContainerRenderObjectMixin
    ///
    /// If a render box can have multiple children, then the
    /// [ContainerRenderObjectMixin] mixin can be used to handle the boilerplate. It
    /// uses a linked list to model the children in a manner that is easy to mutate
    /// dynamically and that can be walked efficiently. Random access is not
    /// efficient in this model; if you need random access to the children consider
    /// the next section on more complicated child models.
    ///
    /// The [ContainerRenderObjectMixin] class has two type arguments. The first is
    /// the type of the child objects. The second is the type for their
    /// [parentData]. The class used for [parentData] must itself have the
    /// [ContainerParentDataMixin] class mixed into it; this is where
    /// [ContainerRenderObjectMixin] stores the linked list. A [ParentData] class
    /// can extend [ContainerBoxParentData]; this is essentially
    /// [BoxParentData] mixed with [ContainerParentDataMixin]. For example, if a
    /// `RenderFoo` class wanted to have a linked list of [RenderBox] children, one
    /// might create a `FooParentData` class as follows:
    ///
    /// ```dart
    /// class FooParentData extends ContainerBoxParentData<RenderBox> {
    ///   // (any fields you might need for these children)
    /// }
    /// ```
    ///
    /// When using [ContainerRenderObjectMixin] in a [RenderBox], consider mixing in
    /// [RenderBoxContainerDefaultsMixin], which provides a collection of utility
    /// methods that implement common parts of the [RenderBox] protocol (such as
    /// painting the children).
    ///
    /// The declaration of the `RenderFoo` class itself would thus look like this:
    ///
    /// ```dart
    /// class RenderFoo extends RenderBox with
    ///   ContainerRenderObjectMixin<RenderBox, FooParentData>,
    ///   RenderBoxContainerDefaultsMixin<RenderBox, FooParentData> {
    ///   // ...
    /// }
    /// ```
    ///
    /// When walking the children (e.g. during layout), the following pattern is
    /// commonly used (in this case assuming that the children are all [RenderBox]
    /// objects and that this render object uses `FooParentData` objects for its
    /// children's [parentData] fields):
    ///
    /// ```dart
    /// RenderBox child = firstChild;
    /// while (child != null) {
    ///   final FooParentData childParentData = child.parentData;
    ///   // ...operate on child and childParentData...
    ///   assert(child.parentData == childParentData);
    ///   child = childParentData.nextSibling;
    /// }
    /// ```
    ///
    /// #### More complicated child models
    ///
    /// Render objects can have more complicated models, for example a map of
    /// children keyed on an enum, or a 2D grid of efficiently randomly-accessible
    /// children, or multiple lists of children, etc. If a render object has a model
    /// that can't be handled by the mixins above, it must implement the
    /// [RenderObject] child protocol, as follows:
    ///
    /// * Any time a child is removed, call [dropChild] with the child.
    ///
    /// * Any time a child is added, call [adoptChild] with the child.
    ///
    /// * Implement the [attach] method such that it calls [attach] on each child.
    ///
    /// * Implement the [detach] method such that it calls [detach] on each child.
    ///
    /// * Implement the [redepthChildren] method such that it calls [redepthChild]
    ///   on each child.
    ///
    /// * Implement the [visitChildren] method such that it calls its argument for
    ///   each child, typically in paint order (back-most to front-most).
    ///
    /// * Implement [debugDescribeChildren] such that it outputs a [DiagnosticsNode]
    ///   for each child.
    ///
    /// Implementing these seven bullet points is essentially all that the two
    /// aforementioned mixins do.
    ///
    /// ### Layout
    ///
    /// [RenderBox] classes implement a layout algorithm. They have a set of
    /// constraints provided to them, and they size themselves based on those
    /// constraints and whatever other inputs they may have (for example, their
    /// children or properties).
    ///
    /// When implementing a [RenderBox] subclass, one must make a choice. Does it
    /// size itself exclusively based on the constraints, or does it use any other
    /// information in sizing itself? An example of sizing purely based on the
    /// constraints would be growing to fit the parent.
    ///
    /// Sizing purely based on the constraints allows the system to make some
    /// significant optimizations. Classes that use this approach should override
    /// [sizedByParent] to return true, and then override [performResize] to set the
    /// [size] using nothing but the constraints, e.g.:
    ///
    /// ```dart
    /// @override
    /// bool get sizedByParent => true;
    ///
    /// @override
    /// void performResize() {
    ///   size = constraints.smallest;
    /// }
    /// ```
    ///
    /// Otherwise, the size is set in the [performLayout] function.
    ///
    /// The [performLayout] function is where render boxes decide, if they are not
    /// [sizedByParent], what [size] they should be, and also where they decide
    /// where their children should be.
    ///
    /// #### Layout of RenderBox children
    ///
    /// The [performLayout] function should call the [layout] function of each (box)
    /// child, passing it a [BoxConstraints] object describing the constraints
    /// within which the child can render. Passing tight constraints (see
    /// [BoxConstraints.isTight]) to the child will allow the rendering library to
    /// apply some optimizations, as it knows that if the constraints are tight, the
    /// child's dimensions cannot change even if the layout of the child itself
    /// changes.
    ///
    /// If the [performLayout] function will use the child's size to affect other
    /// aspects of the layout, for example if the render box sizes itself around the
    /// child, or positions several children based on the size of those children,
    /// then it must specify the `parentUsesSize` argument to the child's [layout]
    /// function, setting it to true.
    ///
    /// This flag turns off some optimizations; algorithms that do not rely on the
    /// children's sizes will be more efficient. (In particular, relying on the
    /// child's [size] means that if the child is marked dirty for layout, the
    /// parent will probably also be marked dirty for layout, unless the
    /// [constraints] given by the parent to the child were tight constraints.)
    ///
    /// For [RenderBox] classes that do not inherit from [RenderProxyBox], once they
    /// have laid out their children, they should also position them, by setting the
    /// [BoxParentData.offset] field of each child's [parentData] object.
    ///
    /// #### Layout of non-RenderBox children
    ///
    /// The children of a [RenderBox] do not have to be [RenderBox]es themselves. If
    /// they use another protocol (as discussed at [RenderObject]), then instead of
    /// [BoxConstraints], the parent would pass in the appropriate [Constraints]
    /// subclass, and instead of reading the child's size, the parent would read
    /// whatever the output of [layout] is for that layout protocol. The
    /// `parentUsesSize` flag is still used to indicate whether the parent is going
    /// to read that output, and optimizations still kick in if the child has tight
    /// constraints (as defined by [Constraints.isTight]).
    ///
    /// ### Painting
    ///
    /// To describe how a render box paints, implement the [paint] method. It is
    /// given a [PaintingContext] object and an [Offset]. The painting context
    /// provides methods to affect the layer tree as well as a
    /// [PaintingContext.canvas] which can be used to add drawing commands. The
    /// canvas object should not be cached across calls to the [PaintingContext]'s
    /// methods; every time a method on [PaintingContext] is called, there is a
    /// chance that the canvas will change identity. The offset specifies the
    /// position of the top left corner of the box in the coordinate system of the
    /// [PaintingContext.canvas].
    ///
    /// To draw text on a canvas, use a [TextPainter].
    ///
    /// To draw an image to a canvas, use the [paintImage] method.
    ///
    /// A [RenderBox] that uses methods on [PaintingContext] that introduce new
    /// layers should override the [alwaysNeedsCompositing] getter and set it to
    /// true. If the object sometimes does and sometimes does not, it can have that
    /// getter return true in some cases and false in others. In that case, whenever
    /// the return value would change, call [markNeedsCompositingBitsUpdate]. (This
    /// is done automatically when a child is added or removed, so you don't have to
    /// call it explicitly if the [alwaysNeedsCompositing] getter only changes value
    /// based on the presence or absence of children.)
    ///
    /// Anytime anything changes on the object that would cause the [paint] method
    /// to paint something different (but would not cause the layout to change),
    /// the object should call [markNeedsPaint].
    ///
    /// #### Painting children
    ///
    /// The [paint] method's `context` argument has a [PaintingContext.paintChild]
    /// method, which should be called for each child that is to be painted. It
    /// should be given a reference to the child, and an [Offset] giving the
    /// position of the child relative to the parent.
    ///
    /// If the [paint] method applies a transform to the painting context before
    /// painting children (or generally applies an additional offset beyond the
    /// offset it was itself given as an argument), then the [applyPaintTransform]
    /// method should also be overridden. That method must adjust the matrix that it
    /// is given in the same manner as it transformed the painting context and
    /// offset before painting the given child. This is used by the [globalToLocal]
    /// and [localToGlobal] methods.
    ///
    /// #### Hit Tests
    ///
    /// Hit testing for render boxes is implemented by the [hitTest] method. The
    /// default implementation of this method defers to [hitTestSelf] and
    /// [hitTestChildren]. When implementing hit testing, you can either override
    /// these latter two methods, or ignore them and just override [hitTest].
    ///
    /// The [hitTest] method itself is given an [Offset], and must return true if the
    /// object or one of its children has absorbed the hit (preventing objects below
    /// this one from being hit), or false if the hit can continue to other objects
    /// below this one.
    ///
    /// For each child [RenderBox], the [hitTest] method on the child should be
    /// called with the same [HitTestResult] argument and with the point transformed
    /// into the child's coordinate space (in the same manner that the
    /// [applyPaintTransform] method would). The default implementation defers to
    /// [hitTestChildren] to call the children. [RenderBoxContainerDefaultsMixin]
    /// provides a [RenderBoxContainerDefaultsMixin.defaultHitTestChildren] method
    /// that does this assuming that the children are axis-aligned, not transformed,
    /// and positioned according to the [BoxParentData.offset] field of the
    /// [parentData]; more elaborate boxes can override [hitTestChildren]
    /// accordingly.
    ///
    /// If the object is hit, then it should also add itself to the [HitTestResult]
    /// object that is given as an argument to the [hitTest] method, using
    /// [HitTestResult.add]. The default implementation defers to [hitTestSelf] to
    /// determine if the box is hit. If the object adds itself before the children
    /// can add themselves, then it will be as if the object was above the children.
    /// If it adds itself after the children, then it will be as if it was below the
    /// children. Entries added to the [HitTestResult] object should use the
    /// [BoxHitTestEntry] class. The entries are subsequently walked by the system
    /// in the order they were added, and for each entry, the target's [handleEvent]
    /// method is called, passing in the [HitTestEntry] object.
    ///
    /// Hit testing cannot rely on painting having happened.
    ///
    /// ### Semantics
    ///
    /// For a render box to be accessible, implement the
    /// [describeApproximatePaintClip] and [visitChildrenForSemantics] methods, and
    /// the [semanticsAnnotator] getter. The default implementations are sufficient
    /// for objects that only affect layout, but nodes that represent interactive
    /// components or information (diagrams, text, images, etc) should provide more
    /// complete implementations. For more information, see the documentation for
    /// these members.
    ///
    /// ### Intrinsics and Baselines
    ///
    /// The layout, painting, hit testing, and semantics protocols are common to all
    /// render objects. [RenderBox] objects must implement two additional protocols:
    /// intrinsic sizing and baseline measurements.
    ///
    /// There are four methods to implement for intrinsic sizing, to compute the
    /// minimum and maximum intrinsic width and height of the box. The documentation
    /// for these methods discusses the protocol in detail:
    /// [computeMinIntrinsicWidth], [computeMaxIntrinsicWidth],
    /// [computeMinIntrinsicHeight], [computeMaxIntrinsicHeight].
    ///
    /// In addition, if the box has any children, it must implement
    /// [computeDistanceToActualBaseline]. [RenderProxyBox] provides a simple
    /// implementation that forwards to the child; [RenderShiftedBox] provides an
    /// implementation that offsets the child's baseline information by the position
    /// of the child relative to the parent. If you do not inherited from either of
    /// these classes, however, you must implement the algorithm yourself.
    /// </Summary>
    public interface IRenderBox
    {
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        double GetMinIntrinsicWidth(double height);
        double ComputeMinIntrinsicWidth(double height);
        double GetMaxIntrinsicWidth(double height);
        double ComputeMaxIntrinsicWidth(double height);
        double GetMinIntrinsicHeight(double width);
        double ComputeMinIntrinsicHeight(double width);
        double GetMaxIntrinsicHeight(double width);
        double ComputeMaxIntrinsicHeight(double width);
        Size DebugAdoptSize(Size value);
        void DebugResetSize();
        double GetDistanceToBaseline(TextBaseline baseline, bool onlyReal = false);
        double GetDistanceToActualBaseline(TextBaseline baseline);
        double ComputeDistanceToActualBaseline(TextBaseline baseline);
        void DebugAssertDoesMeetConstraints();
        void MarkNeedsLayout();
        void PerformResize();
        void PerformLayout();
        bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
        bool HitTestSelf(FlutterBinding.UI.Offset position);
        bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        Offset GlobalToLocal(FlutterBinding.UI.Offset point, FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject));
        Offset LocalToGlobal(FlutterBinding.UI.Offset point, FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject));
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry);
        bool DebugHandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry);
        void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugPaintBaselines(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugPaintPointers(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        bool HasSize { get; }
        Size Size { get; set; }
        FlutterBinding.UI.Rect SemanticBounds { get; }
        FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; }
        FlutterBinding.UI.Rect PaintBounds { get; }
    }


    public interface IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> { }

    public class RenderBoxContainerDefaultsMixin<ChildType, ParentDataType> : IContainerRenderObjectMixin<ChildType, ParentDataType>
    {

        /// <Summary>
        /// Returns the baseline of the first child with a baseline.
        ///
        /// Useful when the children are displayed vertically in the same order they
        /// appear in the child list.
        /// </Summary>
        public virtual double DefaultComputeDistanceToFirstActualBaseline(TextBaseline baseline)
        {

            ChildType child = FirstChild;
            while (child != null)
            {
                ParentDataType childParentData = child.ParentData as ParentDataType;
                double result = child.GetDistanceToActualBaseline(baseline);
                if (result != null) return result + childParentData.Offset.Dy;
                child = childParentData.NextSibling;
            }

            return null;
        }




        /// <Summary>
        /// Returns the minimum baseline value among every child.
        ///
        /// Useful when the vertical position of the children isn't determined by the
        /// order in the child list.
        /// </Summary>
        public virtual double DefaultComputeDistanceToHighestActualBaseline(TextBaseline baseline)
        {

            double result = default(double);
            ChildType child = FirstChild;
            while (child != null)
            {
                ParentDataType childParentData = child.ParentData as ParentDataType;
                double candidate = child.GetDistanceToActualBaseline(baseline);
                if (candidate != null)
                {
                    candidate += childParentData.Offset.Dy;
                    if (result != null) result = Math.Dart:mathDefaultClass.Min(result, candidate);else result = candidate;
                }

                child = childParentData.NextSibling;
            }

            return result;
        }




        /// <Summary>
        /// Performs a hit test on each child by walking the child list backwards.
        ///
        /// Stops walking once after the first child reports that it contains the
        /// given point. Returns whether any children contain the given point.
        ///
        /// See also:
        ///
        ///  * [defaultPaint], which paints the children appropriate for this
        ///    hit-testing strategy.
        /// </Summary>
        public virtual bool DefaultHitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            ChildType child = LastChild;
            while (child != null)
            {
                ParentDataType childParentData = child.ParentData as ParentDataType;
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




        /// <Summary>
        /// Paints each child by walking the child list forwards.
        ///
        /// See also:
        ///
        ///  * [defaultHitTestChildren], which implements hit-testing of the children
        ///    in a manner appropriate for this painting strategy.
        /// </Summary>
        public virtual void DefaultPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            ChildType child = FirstChild;
            while (child != null)
            {
                ParentDataType childParentData = child.ParentData as ParentDataType;
                context.PaintChild(child, childParentData.Offset + offset);
                child = childParentData.NextSibling;
            }

        }




        /// <Summary>
        /// Returns a list containing the children of this render object.
        ///
        /// This function is useful when you need random-access to the children of
        /// this render object. If you're accessing the children in order, consider
        /// walking the child list directly.
        /// </Summary>
        public virtual List<ChildType> GetChildrenAsList()
        {
            List<ChildType> result = new List<ChildType>() { };
            RenderBox child = FirstChild;
            while (child != null)
            {
                ParentDataType childParentData = child.ParentData as ParentDataType;
                result.Add(child as ChildType);
                child = childParentData.NextSibling;
            }

            return result;
        }



        internal virtual int _ChildCount { get; set; }
        internal virtual ChildType _FirstChild { get; set; }
        internal virtual ChildType _LastChild { get; set; }
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual ChildType FirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual ChildType LastChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private bool _DebugUltimatePreviousSiblingOf(ChildType child, ChildType equals = default(ChildType))
        {
            ParentDataType childParentData = child.ParentData as ParentDataType;
            while (childParentData.PreviousSibling != null)
            {

                child = childParentData.PreviousSibling;
                childParentData = child.ParentData as ParentDataType;
            }

            return child == equals;
        }




        private bool _DebugUltimateNextSiblingOf(ChildType child, ChildType equals = default(ChildType))
        {
            ParentDataType childParentData = child.ParentData as ParentDataType;
            while (childParentData.NextSibling != null)
            {

                child = childParentData.NextSibling;
                childParentData = child.ParentData as ParentDataType;
            }

            return child == equals;
        }




        /// <Summary>
        /// Checks whether the given render object has the correct [runtimeType] to be
        /// a child of this render object.
        ///
        /// Does nothing if assertions are disabled.
        ///
        /// Always returns true.
        /// </Summary>
        public virtual bool DebugValidateChild(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return true;
        }




        private void _InsertIntoChildList(ChildType child, ChildType after = default(ChildType))
        {
            ParentDataType childParentData = child.ParentData as ParentDataType;


            _ChildCount += 1;

            if (after == null)
            {
                childParentData.NextSibling = _FirstChild;
                if (_FirstChild != null)
                {
                    ParentDataType _firstChildParentData = _FirstChild.ParentData as ParentDataType;
                    _firstChildParentData.PreviousSibling = child;
                }

                _FirstChild = child;
                _LastChild = (_LastChild == null ? child : _LastChild);
            }
            else
            {




                ParentDataType afterParentData = after.ParentData as ParentDataType;
                if (afterParentData.NextSibling == null)
                {

                    childParentData.PreviousSibling = after;
                    afterParentData.NextSibling = child;
                    _LastChild = child;
                }
                else
                {
                    childParentData.NextSibling = afterParentData.NextSibling;
                    childParentData.PreviousSibling = after;
                    ParentDataType childPreviousSiblingParentData = childParentData.PreviousSibling.ParentData as ParentDataType;
                    ParentDataType childNextSiblingParentData = childParentData.NextSibling.ParentData as ParentDataType;
                    childPreviousSiblingParentData.NextSibling = child;
                    childNextSiblingParentData.PreviousSibling = child;

                }

            }

        }




        /// <Summary>
        /// Insert child into this render object's child list after the given child.
        ///
        /// If `after` is null, then this inserts the child at the start of the list,
        /// and the child becomes the new [firstChild].
        /// </Summary>
        public virtual void Insert(ChildType child, ChildType after = default(ChildType))
        {





            AdoptChild(child);
            _InsertIntoChildList(child, after: after);
        }




        /// <Summary>
        /// Append child to the end of this render object's child list.
        /// </Summary>
        public virtual void Add(ChildType child)
        {
            Insert(child, after: _LastChild);
        }




        /// <Summary>
        /// Add all the children to the end of this render object's child list.
        /// </Summary>
        public virtual void AddAll(List<ChildType> children)
        {
            children?.ForEach(Add);
        }




        private void _RemoveFromChildList(ChildType child)
        {
            ParentDataType childParentData = child.ParentData as ParentDataType;



            if (childParentData.PreviousSibling == null)
            {

                _FirstChild = childParentData.NextSibling;
            }
            else
            {
                ParentDataType childPreviousSiblingParentData = childParentData.PreviousSibling.ParentData as ParentDataType;
                childPreviousSiblingParentData.NextSibling = childParentData.NextSibling;
            }

            if (childParentData.NextSibling == null)
            {

                _LastChild = childParentData.PreviousSibling;
            }
            else
            {
                ParentDataType childNextSiblingParentData = childParentData.NextSibling.ParentData as ParentDataType;
                childNextSiblingParentData.PreviousSibling = childParentData.PreviousSibling;
            }

            childParentData.PreviousSibling = null;
            childParentData.NextSibling = null;
            _ChildCount -= 1;
        }




        /// <Summary>
        /// Remove this child from the child list.
        ///
        /// Requires the child to be present in the child list.
        /// </Summary>
        public virtual void Remove(ChildType child)
        {
            _RemoveFromChildList(child);
            DropChild(child);
        }




        /// <Summary>
        /// Remove all their children from this render object's child list.
        ///
        /// More efficient than removing them individually.
        /// </Summary>
        public virtual void RemoveAll()
        {
            ChildType child = _FirstChild;
            while (child != null)
            {
                ParentDataType childParentData = child.ParentData as ParentDataType;
                ChildType next = childParentData.NextSibling;
                childParentData.PreviousSibling = null;
                childParentData.NextSibling = null;
                DropChild(child);
                child = next;
            }

            _FirstChild = null;
            _LastChild = null;
            _ChildCount = 0;
        }




        /// <Summary>
        /// Move the given `child` in the child list to be after another child.
        ///
        /// More efficient than removing and re-adding the child. Requires the child
        /// to already be in the child list at some position. Pass null for `after` to
        /// move the child to the start of the child list.
        /// </Summary>
        public virtual void Move(ChildType child, ChildType after = default(ChildType))
        {




            ParentDataType childParentData = child.ParentData as ParentDataType;
            if (childParentData.PreviousSibling == after) return;
            _RemoveFromChildList(child);
            _InsertIntoChildList(child, after: after);
            MarkNeedsLayout();
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            ChildType child = _FirstChild;
            while (child != null)
            {
                child.Attach(owner);
                ParentDataType childParentData = child.ParentData as ParentDataType;
                child = childParentData.NextSibling;
            }

        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            ChildType child = _FirstChild;
            while (child != null)
            {
                child.Attach(owner);
                ParentDataType childParentData = child.ParentData as ParentDataType;
                child = childParentData.NextSibling;
            }

        }




        public new void Detach()
        {
            base.Detach();
            ChildType child = _FirstChild;
            while (child != null)
            {
                child.Detach();
                ParentDataType childParentData = child.ParentData as ParentDataType;
                child = childParentData.NextSibling;
            }

        }




        public new void RedepthChildren()
        {
            ChildType child = _FirstChild;
            while (child != null)
            {
                RedepthChild(child);
                ParentDataType childParentData = child.ParentData as ParentDataType;
                child = childParentData.NextSibling;
            }

        }




        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            ChildType child = _FirstChild;
            while (child != null)
            {
                visitor(child);
                ParentDataType childParentData = child.ParentData as ParentDataType;
                child = childParentData.NextSibling;
            }

        }




        /// <Summary>
        /// The previous child before the given child in the child list.
        /// </Summary>
        public virtual ChildType ChildBefore(ChildType child)
        {


            ParentDataType childParentData = child.ParentData as ParentDataType;
            return childParentData.PreviousSibling;
        }




        /// <Summary>
        /// The next child after the given child in the child list.
        /// </Summary>
        public virtual ChildType ChildAfter(ChildType child)
        {


            ParentDataType childParentData = child.ParentData as ParentDataType;
            return childParentData.NextSibling;
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> children = new List<DiagnosticsNode>() { };
            if (FirstChild != null)
            {
                ChildType child = FirstChild;
                int count = 1;
                while (true)
                {
                    children.Add(child.ToDiagnosticsNode(name: $"'child {count}'"));
                    if (child == LastChild) break;
                    count += 1;
                    ParentDataType childParentData = child.ParentData as ParentDataType;
                    child = childParentData.NextSibling;
                }

            }

            return children;
        }



    }
    public static class RenderBoxContainerDefaultsMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static RenderBoxContainerDefaultsMixin<ChildType, ParentDataType> GetOrCreate<ChildType, ParentDataType>(IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderBoxContainerDefaultsMixin<ChildType, ParentDataType>();
                _table.Add(instance, value);
            }
            return (RenderBoxContainerDefaultsMixin<ChildType, ParentDataType>)value;
        }
        public static double DefaultComputeDistanceToFirstActualBaseline<ChildType, ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> instance, TextBaseline baseline) => GetOrCreate(instance).DefaultComputeDistanceToFirstActualBaseline(baseline);
        public static double DefaultComputeDistanceToHighestActualBaseline<ChildType, ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> instance, TextBaseline baseline) => GetOrCreate(instance).DefaultComputeDistanceToHighestActualBaseline(baseline);
        public static bool DefaultHitTestChildren<ChildType, ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => GetOrCreate(instance).DefaultHitTestChildren(result, position);
        public static void DefaultPaint<ChildType, ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) => GetOrCreate(instance).DefaultPaint(context, offset);
        public static List<ChildType> GetChildrenAsList<ChildType, ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).GetChildrenAsList();
    }


    public class _DebugSize : Size
    {
        #region constructors
        public _DebugSize(Size source, FlutterSDK.Rendering.Box.RenderBox _owner, bool _canBeUsedByParent)
        : base(source)
    
}
    #endregion

    #region fields
    internal virtual FlutterSDK.Rendering.Box.RenderBox _Owner { get; set; }
    internal virtual bool _CanBeUsedByParent { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Immutable layout constraints for [RenderBox] layout.
///
/// A [Size] respects a [BoxConstraints] if, and only if, all of the following
/// relations hold:
///
/// * [minWidth] <= [Size.width] <= [maxWidth]
/// * [minHeight] <= [Size.height] <= [maxHeight]
///
/// The constraints themselves must satisfy these relations:
///
/// * 0.0 <= [minWidth] <= [maxWidth] <= [double.infinity]
/// * 0.0 <= [minHeight] <= [maxHeight] <= [double.infinity]
///
/// [double.infinity] is a legal value for each constraint.
///
/// ## The box layout model
///
/// Render objects in the Flutter framework are laid out by a one-pass layout
/// model which walks down the render tree passing constraints, then walks back
/// up the render tree passing concrete geometry.
///
/// For boxes, the constraints are [BoxConstraints], which, as described herein,
/// consist of four numbers: a minimum width [minWidth], a maximum width
/// [maxWidth], a minimum height [minHeight], and a maximum height [maxHeight].
///
/// The geometry for boxes consists of a [Size], which must satisfy the
/// constraints described above.
///
/// Each [RenderBox] (the objects that provide the layout models for box
/// widgets) receives [BoxConstraints] from its parent, then lays out each of
/// its children, then picks a [Size] that satisfies the [BoxConstraints].
///
/// Render objects position their children independently of laying them out.
/// Frequently, the parent will use the children's sizes to determine their
/// position. A child does not know its position and will not necessarily be
/// laid out again, or repainted, if its position changes.
///
/// ## Terminology
///
/// When the minimum constraints and the maximum constraint in an axis are the
/// same, that axis is _tightly_ constrained. See: [new
/// BoxConstraints.tightFor], [new BoxConstraints.tightForFinite], [tighten],
/// [hasTightWidth], [hasTightHeight], [isTight].
///
/// An axis with a minimum constraint of 0.0 is _loose_ (regardless of the
/// maximum constraint; if it is also 0.0, then the axis is simultaneously tight
/// and loose!). See: [new BoxConstraints.loose], [loosen].
///
/// An axis whose maximum constraint is not infinite is _bounded_. See:
/// [hasBoundedWidth], [hasBoundedHeight].
///
/// An axis whose maximum constraint is infinite is _unbounded_. An axis is
/// _expanding_ if it is tightly infinite (its minimum and maximum constraints
/// are both infinite). See: [new BoxConstraints.expand].
///
/// An axis whose _minimum_ constraint is infinite is just said to be _infinite_
/// (since by definition the maximum constraint must also be infinite in that
/// case). See: [hasInfiniteWidth], [hasInfiniteHeight].
///
/// A size is _constrained_ when it satisfies a [BoxConstraints] description.
/// See: [constrain], [constrainWidth], [constrainHeight],
/// [constrainDimensions], [constrainSizeAndAttemptToPreserveAspectRatio],
/// [isSatisfiedBy].
/// </Summary>
public class BoxConstraints : FlutterSDK.Rendering.@object.Constraints
{
    #region constructors
    public BoxConstraints(double minWidth = 0.0, double maxWidth = default(double), double minHeight = 0.0, double maxHeight = default(double))
    : base()

}
public static BoxConstraints Tight(Size size)

}
public static BoxConstraints TightFor(double width = default(double), double height = default(double))

}
public static BoxConstraints TightForFinite(double width = default(double), double height = default(double))

}
public static BoxConstraints Loose(Size size)

}
public static BoxConstraints Expand(double width = default(double), double height = default(double))

}
#endregion

#region fields
public virtual double MinWidth { get; set; }
public virtual double MaxWidth { get; set; }
public virtual double MinHeight { get; set; }
public virtual double MaxHeight { get; set; }
public virtual FlutterSDK.Rendering.Box.BoxConstraints Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual Size Biggest { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual Size Smallest { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasTightWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasTightHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IsTight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasBoundedWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasBoundedHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasInfiniteWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasInfiniteHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IsNormalized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Creates a copy of this box constraints but with the given fields replaced with the new values.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints CopyWith(double minWidth = default(double), double maxWidth = default(double), double minHeight = default(double), double maxHeight = default(double))
{
    return new BoxConstraints(minWidth: minWidth == default(double) ? this.minWidth : minWidth, maxWidth: maxWidth == default(double) ? this.maxWidth : maxWidth, minHeight: minHeight == default(double) ? this.minHeight : minHeight, maxHeight: maxHeight == default(double) ? this.maxHeight : maxHeight);
}




/// <Summary>
/// Returns new box constraints that are smaller by the given edge dimensions.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints Deflate(FlutterSDK.Painting.Edgeinsets.EdgeInsets edges)
{


    double horizontal = edges.Horizontal;
    double vertical = edges.Vertical;
    double deflatedMinWidth = Math.Dart:mathDefaultClass.Max(0.0, MinWidth - horizontal);
    double deflatedMinHeight = Math.Dart:mathDefaultClass.Max(0.0, MinHeight - vertical);
    return new BoxConstraints(minWidth: deflatedMinWidth, maxWidth: Math.Dart:mathDefaultClass.Max(deflatedMinWidth, MaxWidth - horizontal), minHeight: deflatedMinHeight, maxHeight: Math.Dart:mathDefaultClass.Max(deflatedMinHeight, MaxHeight - vertical));
}




/// <Summary>
/// Returns new box constraints that remove the minimum width and height requirements.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints Loosen()
{

    return new BoxConstraints(minWidth: 0.0, maxWidth: MaxWidth, minHeight: 0.0, maxHeight: MaxHeight);
}




/// <Summary>
/// Returns new box constraints that respect the given constraints while being
/// as close as possible to the original constraints.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints Enforce(FlutterSDK.Rendering.Box.BoxConstraints constraints)
{
    return new BoxConstraints(minWidth: MinWidth.Clamp(constraints.MinWidth, constraints.MaxWidth) as double, maxWidth: MaxWidth.Clamp(constraints.MinWidth, constraints.MaxWidth) as double, minHeight: MinHeight.Clamp(constraints.MinHeight, constraints.MaxHeight) as double, maxHeight: MaxHeight.Clamp(constraints.MinHeight, constraints.MaxHeight) as double);
}




/// <Summary>
/// Returns new box constraints with a tight width and/or height as close to
/// the given width and height as possible while still respecting the original
/// box constraints.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints Tighten(double width = default(double), double height = default(double))
{
    return new BoxConstraints(minWidth: width == null ? MinWidth : width.Clamp(MinWidth, MaxWidth) as double, maxWidth: width == null ? MaxWidth : width.Clamp(MinWidth, MaxWidth) as double, minHeight: height == null ? MinHeight : height.Clamp(MinHeight, MaxHeight) as double, maxHeight: height == null ? MaxHeight : height.Clamp(MinHeight, MaxHeight) as double);
}




/// <Summary>
/// Returns box constraints with the same width constraints but with
/// unconstrained height.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints WidthConstraints() => new BoxConstraints(minWidth: MinWidth, maxWidth: MaxWidth);



/// <Summary>
/// Returns box constraints with the same height constraints but with
/// unconstrained width
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints HeightConstraints() => new BoxConstraints(minHeight: MinHeight, maxHeight: MaxHeight);



/// <Summary>
/// Returns the width that both satisfies the constraints and is as close as
/// possible to the given width.
/// </Summary>
public virtual double ConstrainWidth(double width = default(double))
{

    return width.Clamp(MinWidth, MaxWidth) as double;
}




/// <Summary>
/// Returns the height that both satisfies the constraints and is as close as
/// possible to the given height.
/// </Summary>
public virtual double ConstrainHeight(double height = default(double))
{

    return height.Clamp(MinHeight, MaxHeight) as double;
}




private Size _DebugPropagateDebugSize(Size size, Size result)
{

    return result;
}




/// <Summary>
/// Returns the size that both satisfies the constraints and is as close as
/// possible to the given size.
///
/// See also:
///
///  * [constrainDimensions], which applies the same algorithm to
///    separately provided widths and heights.
/// </Summary>
public virtual Size Constrain(Size size)
{
    Size result = new Size(ConstrainWidth(size.Width), ConstrainHeight(size.Height));

    return result;
}




/// <Summary>
/// Returns the size that both satisfies the constraints and is as close as
/// possible to the given width and height.
///
/// When you already have a [Size], prefer [constrain], which applies the same
/// algorithm to a [Size] directly.
/// </Summary>
public virtual Size ConstrainDimensions(double width, double height)
{
    return new Size(ConstrainWidth(width), ConstrainHeight(height));
}




/// <Summary>
/// Returns a size that attempts to meet the following conditions, in order:
///
///  * The size must satisfy these constraints.
///  * The aspect ratio of the returned size matches the aspect ratio of the
///    given size.
///  * The returned size as big as possible while still being equal to or
///    smaller than the given size.
/// </Summary>
public virtual Size ConstrainSizeAndAttemptToPreserveAspectRatio(Size size)
{
    if (IsTight)
    {
        Size result = Smallest;

        return result;
    }

    double width = size.Width;
    double height = size.Height;


    double aspectRatio = width / height;
    if (width > MaxWidth)
    {
        width = MaxWidth;
        height = width / aspectRatio;
    }

    if (height > MaxHeight)
    {
        height = MaxHeight;
        width = height * aspectRatio;
    }

    if (width < MinWidth)
    {
        width = MinWidth;
        height = width / aspectRatio;
    }

    if (height < MinHeight)
    {
        height = MinHeight;
        width = height * aspectRatio;
    }

    Size result = new Size(ConstrainWidth(width), ConstrainHeight(height));

    return result;
}




/// <Summary>
/// Whether the given size satisfies the constraints.
/// </Summary>
public virtual bool IsSatisfiedBy(Size size)
{

    return (MinWidth <= size.Width) && (size.Width <= MaxWidth) && (MinHeight <= size.Height) && (size.Height <= MaxHeight);
}




/// <Summary>
/// Scales each constraint parameter by the given factor.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints MultiplyOperator(double factor)
{
    return new BoxConstraints(minWidth: MinWidth * factor, maxWidth: MaxWidth * factor, minHeight: MinHeight * factor, maxHeight: MaxHeight * factor);
}




/// <Summary>
/// Scales each constraint parameter by the inverse of the given factor.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints DivideOperator(double factor)
{
    return new BoxConstraints(minWidth: MinWidth / factor, maxWidth: MaxWidth / factor, minHeight: MinHeight / factor, maxHeight: MaxHeight / factor);
}




/// <Summary>
/// Scales each constraint parameter by the inverse of the given factor, rounded to the nearest integer.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints DivideIntegerResultOperator(double factor)
{
    return new BoxConstraints(minWidth: (MinWidth~/ factor).ToDouble(), maxWidth: (MaxWidth~/ factor).ToDouble(), minHeight: (MinHeight~/ factor).ToDouble(), maxHeight: (MaxHeight~/ factor).ToDouble());
}




/// <Summary>
/// Computes the remainder of each constraint parameter by the given value.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints ModuloOperator(double value)
{
    return new BoxConstraints(minWidth: MinWidth % value, maxWidth: MaxWidth % value, minHeight: MinHeight % value, maxHeight: MaxHeight % value);
}




/// <Summary>
/// Linearly interpolate between two BoxConstraints.
///
/// If either is null, this function interpolates from a [BoxConstraints]
/// object whose fields are all set to 0.0.
///
/// {@macro dart.ui.shadow.lerp}
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints Lerp(FlutterSDK.Rendering.Box.BoxConstraints a, FlutterSDK.Rendering.Box.BoxConstraints b, double t)
{

    if (a == null && b == null) return null;
    if (a == null) return b * t;
    if (b == null) return a * (1.0 - t);






    return new BoxConstraints(minWidth: a.MinWidth.IsFinite() ? Ui.Dart : uiDefaultClass.LerpDouble(a.MinWidth, b.MinWidth, t):Dart: coreDefaultClass.Double.Infinity, maxWidth: a.MaxWidth.IsFinite() ? Ui.Dart : uiDefaultClass.LerpDouble(a.MaxWidth, b.MaxWidth, t):Dart: coreDefaultClass.Double.Infinity, minHeight: a.MinHeight.IsFinite() ? Ui.Dart : uiDefaultClass.LerpDouble(a.MinHeight, b.MinHeight, t):Dart: coreDefaultClass.Double.Infinity, maxHeight: a.MaxHeight.IsFinite() ? Ui.Dart : uiDefaultClass.LerpDouble(a.MaxHeight, b.MaxHeight, t):Dart: coreDefaultClass.Double.Infinity);
}




public new bool DebugAssertIsValid(bool isAppliedConstraint = false, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
{

    return IsNormalized;
}




/// <Summary>
/// Returns a box constraints that [isNormalized].
///
/// The returned [maxWidth] is at least as large as the [minWidth]. Similarly,
/// the returned [maxHeight] is at least as large as the [minHeight].
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints Normalize()
{
    if (IsNormalized) return this;
    double minWidth = this.MinWidth >= 0.0 ? this.MinWidth : 0.0;
    double minHeight = this.MinHeight >= 0.0 ? this.MinHeight : 0.0;
    return new BoxConstraints(minWidth: minWidth, maxWidth: minWidth > MaxWidth ? minWidth : MaxWidth, minHeight: minHeight, maxHeight: minHeight > MaxHeight ? minHeight : MaxHeight);
}




public new bool Equals(@Object other)
{

    if (Dart:coreDefaultClass.Identical(this, other))return true;
    if (other.GetType() != GetType()) return false;

    return other is BoxConstraints && other.MinWidth == MinWidth && other.MaxWidth == MaxWidth && other.MinHeight == MinHeight && other.MaxHeight == MaxHeight;
}




#endregion
}


/// <Summary>
/// The result of performing a hit test on [RenderBox]es.
///
/// An instance of this class is provided to [RenderBox.hitTest] to record the
/// result of the hit test.
/// </Summary>
public class BoxHitTestResult : FlutterSDK.Gestures.Hittest.HitTestResult
{
    #region constructors
    public BoxHitTestResult()
    : base()

}
public static BoxHitTestResult Wrap(FlutterSDK.Gestures.Hittest.HitTestResult result)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Transforms `position` to the local coordinate system of a child for
/// hit-testing the child.
///
/// The actual hit testing of the child needs to be implemented in the
/// provided `hitTest` callback, which is invoked with the transformed
/// `position` as argument.
///
/// The provided paint `transform` (which describes the transform from the
/// child to the parent in 3D) is processed by
/// [PointerEvent.removePerspectiveTransform] to remove the
/// perspective component and inverted before it is used to transform
/// `position` from the coordinate system of the parent to the system of the
/// child.
///
/// If `transform` is null it will be treated as the identity transform and
/// `position` is provided to the `hitTest` callback as-is. If `transform`
/// cannot be inverted, the `hitTest` callback is not invoked and false is
/// returned. Otherwise, the return value of the `hitTest` callback is
/// returned.
///
/// The `position` argument may be null, which will be forwarded to the
/// `hitTest` callback as-is. Using null as the position can be useful if
/// the child speaks a different hit test protocol then the parent and the
/// position is not required to do the actual hit testing in that protocol.
///
/// {@tool snippet}
/// This method is used in [RenderBox.hitTestChildren] when the child and
/// parent don't share the same origin.
///
/// ```dart
/// abstract class Foo extends RenderBox {
///
///   final Matrix4 _effectiveTransform = Matrix4.rotationZ(50);
///
///   @override
///   void applyPaintTransform(RenderBox child, Matrix4 transform) {
///     transform.multiply(_effectiveTransform);
///   }
///
///   @override
///   bool hitTestChildren(BoxHitTestResult result, { Offset position }) {
///     return result.addWithPaintTransform(
///       transform: _effectiveTransform,
///       position: position,
///       hitTest: (BoxHitTestResult result, Offset position) {
///         return super.hitTestChildren(result, position: position);
///       },
///     );
///   }
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [addWithPaintOffset], which can be used for `transform`s that are just
///    simple matrix translations by an [Offset].
///  * [addWithRawTransform], which takes a transform matrix that is directly
///    used to transform the position without any pre-processing.
/// </Summary>
public virtual bool AddWithPaintTransform(Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterSDK.Rendering.Box.BoxHitTest hitTest = default(FlutterSDK.Rendering.Box.BoxHitTest))
{

    if (transform != null)
    {
        transform = Matrix4.TryInvert(EventsDefaultClass.PointerEvent.RemovePerspectiveTransform(transform));
        if (transform == null)
        {
            return false;
        }

    }

    return AddWithRawTransform(transform: transform, position: position, hitTest: hitTest);
}




/// <Summary>
/// Convenience method for hit testing children, that are translated by
/// an [Offset].
///
/// The actual hit testing of the child needs to be implemented in the
/// provided `hitTest` callback, which is invoked with the transformed
/// `position` as argument.
///
/// This method can be used as a convenience over [addWithPaintTransform] if
/// a parent paints a child at an `offset`.
///
/// A null value for `offset` is treated as if [Offset.zero] was provided.
///
/// Se also:
///
///  * [addWithPaintTransform], which takes a generic paint transform matrix and
///    documents the intended usage of this API in more detail.
/// </Summary>
public virtual bool AddWithPaintOffset(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterSDK.Rendering.Box.BoxHitTest hitTest = default(FlutterSDK.Rendering.Box.BoxHitTest))
{

    return AddWithRawTransform(transform: offset != null ? Matrix4.TranslationValues(-offset.Dx, -offset.Dy, 0.0) : null, position: position, hitTest: hitTest);
}




/// <Summary>
/// Transforms `position` to the local coordinate system of a child for
/// hit-testing the child.
///
/// The actual hit testing of the child needs to be implemented in the
/// provided `hitTest` callback, which is invoked with the transformed
/// `position` as argument.
///
/// Unlike [addWithPaintTransform], the provided `transform` matrix is used
/// directly to transform `position` without any pre-processing.
///
/// If `transform` is null it will be treated as the identity transform ad
/// `position` is provided to the `hitTest` callback as-is.
///
/// The function returns the return value of the `hitTest` callback.
///
/// The `position` argument may be null, which will be forwarded to the
/// `hitTest` callback as-is. Using null as the position can be useful if
/// the child speaks a different hit test protocol then the parent and the
/// position is not required to do the actual hit testing in that protocol.
///
/// Se also:
///
///  * [addWithPaintTransform], which accomplishes the same thing, but takes a
///    _paint_ transform matrix.
/// </Summary>
public virtual bool AddWithRawTransform(Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterSDK.Rendering.Box.BoxHitTest hitTest = default(FlutterSDK.Rendering.Box.BoxHitTest))
{

    Offset transformedPosition = position == null || transform == null ? position : MatrixutilsDefaultClass.MatrixUtils.TransformPoint(transform, position);
    if (transform != null)
    {
        PushTransform(transform);
    }

    bool isHit = hitTest(this, transformedPosition);
    if (transform != null)
    {
        PopTransform();
    }

    return isHit;
}



#endregion
}


/// <Summary>
/// A hit test entry used by [RenderBox].
/// </Summary>
public class BoxHitTestEntry : FlutterSDK.Gestures.Hittest.HitTestEntry
{
    #region constructors
    public BoxHitTestEntry(FlutterSDK.Rendering.Box.RenderBox target, FlutterBinding.UI.Offset localPosition)
    : base(target)

}
#endregion

#region fields
public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
public virtual FlutterSDK.Rendering.Box.RenderBox Target { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

#endregion
}


/// <Summary>
/// Parent data used by [RenderBox] and its subclasses.
/// </Summary>
public class BoxParentData : FlutterSDK.Rendering.@object.ParentData
{
    #region constructors
    public BoxParentData()
    { }
    #endregion

    #region fields
    public virtual FlutterBinding.UI.Offset Offset { get; set; }
    #endregion

    #region methods

    #endregion
}


/// <Summary>
/// Abstract [ParentData] subclass for [RenderBox] subclasses that want the
/// [ContainerRenderObjectMixin].
///
/// This is a convenience class that mixes in the relevant classes with
/// the relevant type arguments.
/// </Summary>
public class ContainerBoxParentData<ChildType> : FlutterSDK.Rendering.Box.BoxParentData, IContainerParentDataMixin<ChildType>
{
    #region constructors
    public ContainerBoxParentData()
    { }
    #endregion

    #region fields
    #endregion

    #region methods
    #endregion
}


public class _IntrinsicDimensionsCacheEntry
{
    #region constructors
    public _IntrinsicDimensionsCacheEntry(FlutterSDK.Rendering.Box._IntrinsicDimension dimension, double argument)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Box._IntrinsicDimension Dimension { get; set; }
public virtual double Argument { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool Equals(@Object other)
{
    return other is _IntrinsicDimensionsCacheEntry && other.Dimension == Dimension && other.Argument == Argument;
}



#endregion
}


/// <Summary>
/// A render object in a 2D Cartesian coordinate system.
///
/// The [size] of each box is expressed as a width and a height. Each box has
/// its own coordinate system in which its upper left corner is placed at (0,
/// 0). The lower right corner of the box is therefore at (width, height). The
/// box contains all the points including the upper left corner and extending
/// to, but not including, the lower right corner.
///
/// Box layout is performed by passing a [BoxConstraints] object down the tree.
/// The box constraints establish a min and max value for the child's width and
/// height. In determining its size, the child must respect the constraints
/// given to it by its parent.
///
/// This protocol is sufficient for expressing a number of common box layout
/// data flows. For example, to implement a width-in-height-out data flow, call
/// your child's [layout] function with a set of box constraints with a tight
/// width value (and pass true for parentUsesSize). After the child determines
/// its height, use the child's height to determine your size.
///
/// ## Writing a RenderBox subclass
///
/// One would implement a new [RenderBox] subclass to describe a new layout
/// model, new paint model, new hit-testing model, or new semantics model, while
/// remaining in the Cartesian space defined by the [RenderBox] protocol.
///
/// To create a new protocol, consider subclassing [RenderObject] instead.
///
/// ### Constructors and properties of a new RenderBox subclass
///
/// The constructor will typically take a named argument for each property of
/// the class. The value is then passed to a private field of the class and the
/// constructor asserts its correctness (e.g. if it should not be null, it
/// asserts it's not null).
///
/// Properties have the form of a getter/setter/field group like the following:
///
/// ```dart
/// AxisDirection get axis => _axis;
/// AxisDirection _axis;
/// set axis(AxisDirection value) {
///   assert(value != null); // same check as in the constructor
///   if (value == _axis)
///     return;
///   _axis = value;
///   markNeedsLayout();
/// }
/// ```
///
/// The setter will typically finish with either a call to [markNeedsLayout], if
/// the layout uses this property, or [markNeedsPaint], if only the painter
/// function does. (No need to call both, [markNeedsLayout] implies
/// [markNeedsPaint].)
///
/// Consider layout and paint to be expensive; be conservative about calling
/// [markNeedsLayout] or [markNeedsPaint]. They should only be called if the
/// layout (or paint, respectively) has actually changed.
///
/// ### Children
///
/// If a render object is a leaf, that is, it cannot have any children, then
/// ignore this section. (Examples of leaf render objects are [RenderImage] and
/// [RenderParagraph].)
///
/// For render objects with children, there are four possible scenarios:
///
/// * A single [RenderBox] child. In this scenario, consider inheriting from
///   [RenderProxyBox] (if the render object sizes itself to match the child) or
///   [RenderShiftedBox] (if the child will be smaller than the box and the box
///   will align the child inside itself).
///
/// * A single child, but it isn't a [RenderBox]. Use the
///   [RenderObjectWithChildMixin] mixin.
///
/// * A single list of children. Use the [ContainerRenderObjectMixin] mixin.
///
/// * A more complicated child model.
///
/// #### Using RenderProxyBox
///
/// By default, a [RenderProxyBox] render object sizes itself to fit its child, or
/// to be as small as possible if there is no child; it passes all hit testing
/// and painting on to the child, and intrinsic dimensions and baseline
/// measurements similarly are proxied to the child.
///
/// A subclass of [RenderProxyBox] just needs to override the parts of the
/// [RenderBox] protocol that matter. For example, [RenderOpacity] just
/// overrides the paint method (and [alwaysNeedsCompositing] to reflect what the
/// paint method does, and the [visitChildrenForSemantics] method so that the
/// child is hidden from accessibility tools when it's invisible), and adds an
/// [RenderOpacity.opacity] field.
///
/// [RenderProxyBox] assumes that the child is the size of the parent and
/// positioned at 0,0. If this is not true, then use [RenderShiftedBox] instead.
///
/// See
/// [proxy_box.dart](https://github.com/flutter/flutter/blob/master/packages/flutter/lib/src/rendering/proxy_box.dart)
/// for examples of inheriting from [RenderProxyBox].
///
/// #### Using RenderShiftedBox
///
/// By default, a [RenderShiftedBox] acts much like a [RenderProxyBox] but
/// without assuming that the child is positioned at 0,0 (the actual position
/// recorded in the child's [parentData] field is used), and without providing a
/// default layout algorithm.
///
/// See
/// [shifted_box.dart](https://github.com/flutter/flutter/blob/master/packages/flutter/lib/src/rendering/shifted_box.dart)
/// for examples of inheriting from [RenderShiftedBox].
///
/// #### Kinds of children and child-specific data
///
/// A [RenderBox] doesn't have to have [RenderBox] children. One can use another
/// subclass of [RenderObject] for a [RenderBox]'s children. See the discussion
/// at [RenderObject].
///
/// Children can have additional data owned by the parent but stored on the
/// child using the [parentData] field. The class used for that data must
/// inherit from [ParentData]. The [setupParentData] method is used to
/// initialize the [parentData] field of a child when the child is attached.
///
/// By convention, [RenderBox] objects that have [RenderBox] children use the
/// [BoxParentData] class, which has a [BoxParentData.offset] field to store the
/// position of the child relative to the parent. ([RenderProxyBox] does not
/// need this offset and therefore is an exception to this rule.)
///
/// #### Using RenderObjectWithChildMixin
///
/// If a render object has a single child but it isn't a [RenderBox], then the
/// [RenderObjectWithChildMixin] class, which is a mixin that will handle the
/// boilerplate of managing a child, will be useful.
///
/// It's a generic class with one type argument, the type of the child. For
/// example, if you are building a `RenderFoo` class which takes a single
/// `RenderBar` child, you would use the mixin as follows:
///
/// ```dart
/// class RenderFoo extends RenderBox
///   with RenderObjectWithChildMixin<RenderBar> {
///   // ...
/// }
/// ```
///
/// Since the `RenderFoo` class itself is still a [RenderBox] in this case, you
/// still have to implement the [RenderBox] layout algorithm, as well as
/// features like intrinsics and baselines, painting, and hit testing.
///
/// #### Using ContainerRenderObjectMixin
///
/// If a render box can have multiple children, then the
/// [ContainerRenderObjectMixin] mixin can be used to handle the boilerplate. It
/// uses a linked list to model the children in a manner that is easy to mutate
/// dynamically and that can be walked efficiently. Random access is not
/// efficient in this model; if you need random access to the children consider
/// the next section on more complicated child models.
///
/// The [ContainerRenderObjectMixin] class has two type arguments. The first is
/// the type of the child objects. The second is the type for their
/// [parentData]. The class used for [parentData] must itself have the
/// [ContainerParentDataMixin] class mixed into it; this is where
/// [ContainerRenderObjectMixin] stores the linked list. A [ParentData] class
/// can extend [ContainerBoxParentData]; this is essentially
/// [BoxParentData] mixed with [ContainerParentDataMixin]. For example, if a
/// `RenderFoo` class wanted to have a linked list of [RenderBox] children, one
/// might create a `FooParentData` class as follows:
///
/// ```dart
/// class FooParentData extends ContainerBoxParentData<RenderBox> {
///   // (any fields you might need for these children)
/// }
/// ```
///
/// When using [ContainerRenderObjectMixin] in a [RenderBox], consider mixing in
/// [RenderBoxContainerDefaultsMixin], which provides a collection of utility
/// methods that implement common parts of the [RenderBox] protocol (such as
/// painting the children).
///
/// The declaration of the `RenderFoo` class itself would thus look like this:
///
/// ```dart
/// class RenderFoo extends RenderBox with
///   ContainerRenderObjectMixin<RenderBox, FooParentData>,
///   RenderBoxContainerDefaultsMixin<RenderBox, FooParentData> {
///   // ...
/// }
/// ```
///
/// When walking the children (e.g. during layout), the following pattern is
/// commonly used (in this case assuming that the children are all [RenderBox]
/// objects and that this render object uses `FooParentData` objects for its
/// children's [parentData] fields):
///
/// ```dart
/// RenderBox child = firstChild;
/// while (child != null) {
///   final FooParentData childParentData = child.parentData;
///   // ...operate on child and childParentData...
///   assert(child.parentData == childParentData);
///   child = childParentData.nextSibling;
/// }
/// ```
///
/// #### More complicated child models
///
/// Render objects can have more complicated models, for example a map of
/// children keyed on an enum, or a 2D grid of efficiently randomly-accessible
/// children, or multiple lists of children, etc. If a render object has a model
/// that can't be handled by the mixins above, it must implement the
/// [RenderObject] child protocol, as follows:
///
/// * Any time a child is removed, call [dropChild] with the child.
///
/// * Any time a child is added, call [adoptChild] with the child.
///
/// * Implement the [attach] method such that it calls [attach] on each child.
///
/// * Implement the [detach] method such that it calls [detach] on each child.
///
/// * Implement the [redepthChildren] method such that it calls [redepthChild]
///   on each child.
///
/// * Implement the [visitChildren] method such that it calls its argument for
///   each child, typically in paint order (back-most to front-most).
///
/// * Implement [debugDescribeChildren] such that it outputs a [DiagnosticsNode]
///   for each child.
///
/// Implementing these seven bullet points is essentially all that the two
/// aforementioned mixins do.
///
/// ### Layout
///
/// [RenderBox] classes implement a layout algorithm. They have a set of
/// constraints provided to them, and they size themselves based on those
/// constraints and whatever other inputs they may have (for example, their
/// children or properties).
///
/// When implementing a [RenderBox] subclass, one must make a choice. Does it
/// size itself exclusively based on the constraints, or does it use any other
/// information in sizing itself? An example of sizing purely based on the
/// constraints would be growing to fit the parent.
///
/// Sizing purely based on the constraints allows the system to make some
/// significant optimizations. Classes that use this approach should override
/// [sizedByParent] to return true, and then override [performResize] to set the
/// [size] using nothing but the constraints, e.g.:
///
/// ```dart
/// @override
/// bool get sizedByParent => true;
///
/// @override
/// void performResize() {
///   size = constraints.smallest;
/// }
/// ```
///
/// Otherwise, the size is set in the [performLayout] function.
///
/// The [performLayout] function is where render boxes decide, if they are not
/// [sizedByParent], what [size] they should be, and also where they decide
/// where their children should be.
///
/// #### Layout of RenderBox children
///
/// The [performLayout] function should call the [layout] function of each (box)
/// child, passing it a [BoxConstraints] object describing the constraints
/// within which the child can render. Passing tight constraints (see
/// [BoxConstraints.isTight]) to the child will allow the rendering library to
/// apply some optimizations, as it knows that if the constraints are tight, the
/// child's dimensions cannot change even if the layout of the child itself
/// changes.
///
/// If the [performLayout] function will use the child's size to affect other
/// aspects of the layout, for example if the render box sizes itself around the
/// child, or positions several children based on the size of those children,
/// then it must specify the `parentUsesSize` argument to the child's [layout]
/// function, setting it to true.
///
/// This flag turns off some optimizations; algorithms that do not rely on the
/// children's sizes will be more efficient. (In particular, relying on the
/// child's [size] means that if the child is marked dirty for layout, the
/// parent will probably also be marked dirty for layout, unless the
/// [constraints] given by the parent to the child were tight constraints.)
///
/// For [RenderBox] classes that do not inherit from [RenderProxyBox], once they
/// have laid out their children, they should also position them, by setting the
/// [BoxParentData.offset] field of each child's [parentData] object.
///
/// #### Layout of non-RenderBox children
///
/// The children of a [RenderBox] do not have to be [RenderBox]es themselves. If
/// they use another protocol (as discussed at [RenderObject]), then instead of
/// [BoxConstraints], the parent would pass in the appropriate [Constraints]
/// subclass, and instead of reading the child's size, the parent would read
/// whatever the output of [layout] is for that layout protocol. The
/// `parentUsesSize` flag is still used to indicate whether the parent is going
/// to read that output, and optimizations still kick in if the child has tight
/// constraints (as defined by [Constraints.isTight]).
///
/// ### Painting
///
/// To describe how a render box paints, implement the [paint] method. It is
/// given a [PaintingContext] object and an [Offset]. The painting context
/// provides methods to affect the layer tree as well as a
/// [PaintingContext.canvas] which can be used to add drawing commands. The
/// canvas object should not be cached across calls to the [PaintingContext]'s
/// methods; every time a method on [PaintingContext] is called, there is a
/// chance that the canvas will change identity. The offset specifies the
/// position of the top left corner of the box in the coordinate system of the
/// [PaintingContext.canvas].
///
/// To draw text on a canvas, use a [TextPainter].
///
/// To draw an image to a canvas, use the [paintImage] method.
///
/// A [RenderBox] that uses methods on [PaintingContext] that introduce new
/// layers should override the [alwaysNeedsCompositing] getter and set it to
/// true. If the object sometimes does and sometimes does not, it can have that
/// getter return true in some cases and false in others. In that case, whenever
/// the return value would change, call [markNeedsCompositingBitsUpdate]. (This
/// is done automatically when a child is added or removed, so you don't have to
/// call it explicitly if the [alwaysNeedsCompositing] getter only changes value
/// based on the presence or absence of children.)
///
/// Anytime anything changes on the object that would cause the [paint] method
/// to paint something different (but would not cause the layout to change),
/// the object should call [markNeedsPaint].
///
/// #### Painting children
///
/// The [paint] method's `context` argument has a [PaintingContext.paintChild]
/// method, which should be called for each child that is to be painted. It
/// should be given a reference to the child, and an [Offset] giving the
/// position of the child relative to the parent.
///
/// If the [paint] method applies a transform to the painting context before
/// painting children (or generally applies an additional offset beyond the
/// offset it was itself given as an argument), then the [applyPaintTransform]
/// method should also be overridden. That method must adjust the matrix that it
/// is given in the same manner as it transformed the painting context and
/// offset before painting the given child. This is used by the [globalToLocal]
/// and [localToGlobal] methods.
///
/// #### Hit Tests
///
/// Hit testing for render boxes is implemented by the [hitTest] method. The
/// default implementation of this method defers to [hitTestSelf] and
/// [hitTestChildren]. When implementing hit testing, you can either override
/// these latter two methods, or ignore them and just override [hitTest].
///
/// The [hitTest] method itself is given an [Offset], and must return true if the
/// object or one of its children has absorbed the hit (preventing objects below
/// this one from being hit), or false if the hit can continue to other objects
/// below this one.
///
/// For each child [RenderBox], the [hitTest] method on the child should be
/// called with the same [HitTestResult] argument and with the point transformed
/// into the child's coordinate space (in the same manner that the
/// [applyPaintTransform] method would). The default implementation defers to
/// [hitTestChildren] to call the children. [RenderBoxContainerDefaultsMixin]
/// provides a [RenderBoxContainerDefaultsMixin.defaultHitTestChildren] method
/// that does this assuming that the children are axis-aligned, not transformed,
/// and positioned according to the [BoxParentData.offset] field of the
/// [parentData]; more elaborate boxes can override [hitTestChildren]
/// accordingly.
///
/// If the object is hit, then it should also add itself to the [HitTestResult]
/// object that is given as an argument to the [hitTest] method, using
/// [HitTestResult.add]. The default implementation defers to [hitTestSelf] to
/// determine if the box is hit. If the object adds itself before the children
/// can add themselves, then it will be as if the object was above the children.
/// If it adds itself after the children, then it will be as if it was below the
/// children. Entries added to the [HitTestResult] object should use the
/// [BoxHitTestEntry] class. The entries are subsequently walked by the system
/// in the order they were added, and for each entry, the target's [handleEvent]
/// method is called, passing in the [HitTestEntry] object.
///
/// Hit testing cannot rely on painting having happened.
///
/// ### Semantics
///
/// For a render box to be accessible, implement the
/// [describeApproximatePaintClip] and [visitChildrenForSemantics] methods, and
/// the [semanticsAnnotator] getter. The default implementations are sufficient
/// for objects that only affect layout, but nodes that represent interactive
/// components or information (diagrams, text, images, etc) should provide more
/// complete implementations. For more information, see the documentation for
/// these members.
///
/// ### Intrinsics and Baselines
///
/// The layout, painting, hit testing, and semantics protocols are common to all
/// render objects. [RenderBox] objects must implement two additional protocols:
/// intrinsic sizing and baseline measurements.
///
/// There are four methods to implement for intrinsic sizing, to compute the
/// minimum and maximum intrinsic width and height of the box. The documentation
/// for these methods discusses the protocol in detail:
/// [computeMinIntrinsicWidth], [computeMaxIntrinsicWidth],
/// [computeMinIntrinsicHeight], [computeMaxIntrinsicHeight].
///
/// In addition, if the box has any children, it must implement
/// [computeDistanceToActualBaseline]. [RenderProxyBox] provides a simple
/// implementation that forwards to the child; [RenderShiftedBox] provides an
/// implementation that offsets the child's baseline information by the position
/// of the child relative to the parent. If you do not inherited from either of
/// these classes, however, you must implement the algorithm yourself.
/// </Summary>
public class RenderBox : FlutterSDK.Rendering.@object.RenderObject
{
    #region constructors
    public RenderBox()
    { }
    #endregion

    #region fields
    internal virtual Dictionary<FlutterSDK.Rendering.Box._IntrinsicDimensionsCacheEntry, double> _CachedIntrinsicDimensions { get; set; }
    internal virtual Size _Size { get; set; }
    internal virtual Dictionary<TextBaseline, double> _CachedBaselines { get; set; }
    internal virtual bool _DebugDoingBaseline { get; set; }
    internal virtual int _DebugActivePointers { get; set; }
    public virtual bool HasSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Rect SemanticBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Rect PaintBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
    {
        if (!(child.ParentData is BoxParentData)) child.ParentData = new BoxParentData();
    }




    private double _ComputeIntrinsicDimension(FlutterSDK.Rendering.Box._IntrinsicDimension dimension, double argument, Func<double, double> computer)
    {

        bool shouldCache = true;

        if (shouldCache)
        {
            _CachedIntrinsicDimensions = (_CachedIntrinsicDimensions == null ? new Dictionary<_IntrinsicDimensionsCacheEntry, double> { } : _CachedIntrinsicDimensions);
            return _CachedIntrinsicDimensions.PutIfAbsent(new _IntrinsicDimensionsCacheEntry(dimension, argument), () => =>computer(argument));
        }

        return computer(argument);
    }




    /// <Summary>
    /// Returns the minimum width that this box could be without failing to
    /// correctly paint its contents within itself, without clipping.
    ///
    /// The height argument may give a specific height to assume. The given height
    /// can be infinite, meaning that the intrinsic width in an unconstrained
    /// environment is being requested. The given height should never be negative
    /// or null.
    ///
    /// This function should only be called on one's children. Calling this
    /// function couples the child with the parent so that when the child's layout
    /// changes, the parent is notified (via [markNeedsLayout]).
    ///
    /// Calling this function is expensive as it can result in O(N^2) behavior.
    ///
    /// Do not override this method. Instead, implement [computeMinIntrinsicWidth].
    /// </Summary>
    public virtual double GetMinIntrinsicWidth(double height)
    {

        return _ComputeIntrinsicDimension(_IntrinsicDimension.MinWidth, height, ComputeMinIntrinsicWidth);
    }




    /// <Summary>
    /// Computes the value returned by [getMinIntrinsicWidth]. Do not call this
    /// function directly, instead, call [getMinIntrinsicWidth].
    ///
    /// Override in subclasses that implement [performLayout]. This method should
    /// return the minimum width that this box could be without failing to
    /// correctly paint its contents within itself, without clipping.
    ///
    /// If the layout algorithm is independent of the context (e.g. it always
    /// tries to be a particular size), or if the layout algorithm is
    /// width-in-height-out, or if the layout algorithm uses both the incoming
    /// width and height constraints (e.g. it always sizes itself to
    /// [BoxConstraints.biggest]), then the `height` argument should be ignored.
    ///
    /// If the layout algorithm is strictly height-in-width-out, or is
    /// height-in-width-out when the width is unconstrained, then the height
    /// argument is the height to use.
    ///
    /// The `height` argument will never be negative or null. It may be infinite.
    ///
    /// If this algorithm depends on the intrinsic dimensions of a child, the
    /// intrinsic dimensions of that child should be obtained using the functions
    /// whose names start with `get`, not `compute`.
    ///
    /// This function should never return a negative or infinite value.
    ///
    /// ## Examples
    ///
    /// ### Text
    ///
    /// Text is the canonical example of a width-in-height-out algorithm. The
    /// `height` argument is therefore ignored.
    ///
    /// Consider the string "Hello World" The _maximum_ intrinsic width (as
    /// returned from [computeMaxIntrinsicWidth]) would be the width of the string
    /// with no line breaks.
    ///
    /// The minimum intrinsic width would be the width of the widest word, "Hello"
    /// or "World". If the text is rendered in an even narrower width, however, it
    /// might still not overflow. For example, maybe the rendering would put a
    /// line-break half-way through the words, as in "Hel⁞lo⁞Wor⁞ld". However,
    /// this wouldn't be a _correct_ rendering, and [computeMinIntrinsicWidth] is
    /// supposed to render the minimum width that the box could be without failing
    /// to _correctly_ paint the contents within itself.
    ///
    /// The minimum intrinsic _height_ for a given width smaller than the minimum
    /// intrinsic width could therefore be greater than the minimum intrinsic
    /// height for the minimum intrinsic width.
    ///
    /// ### Viewports (e.g. scrolling lists)
    ///
    /// Some render boxes are intended to clip their children. For example, the
    /// render box for a scrolling list might always size itself to its parents'
    /// size (or rather, to the maximum incoming constraints), regardless of the
    /// children's sizes, and then clip the children and position them based on
    /// the current scroll offset.
    ///
    /// The intrinsic dimensions in these cases still depend on the children, even
    /// though the layout algorithm sizes the box in a way independent of the
    /// children. It is the size that is needed to paint the box's contents (in
    /// this case, the children) _without clipping_ that matters.
    ///
    /// ### When the intrinsic dimensions cannot be known
    ///
    /// There are cases where render objects do not have an efficient way to
    /// compute their intrinsic dimensions. For example, it may be prohibitively
    /// expensive to reify and measure every child of a lazy viewport (viewports
    /// generally only instantiate the actually visible children), or the
    /// dimensions may be computed by a callback about which the render object
    /// cannot reason.
    ///
    /// In such cases, it may be impossible (or at least impractical) to actually
    /// return a valid answer. In such cases, the intrinsic functions should throw
    /// when [RenderObject.debugCheckingIntrinsics] is false and asserts are
    /// enabled, and return 0.0 otherwise.
    ///
    /// See the implementations of [LayoutBuilder] or [RenderViewportBase] for
    /// examples (in particular,
    /// [RenderViewportBase.debugThrowIfNotCheckingIntrinsics]).
    ///
    /// ### Aspect-ratio-driven boxes
    ///
    /// Some boxes always return a fixed size based on the constraints. For these
    /// boxes, the intrinsic functions should return the appropriate size when the
    /// incoming `height` or `width` argument is finite, treating that as a tight
    /// constraint in the respective direction and treating the other direction's
    /// constraints as unbounded. This is because the definitions of
    /// [computeMinIntrinsicWidth] and [computeMinIntrinsicHeight] are in terms of
    /// what the dimensions _could be_, and such boxes can only be one size in
    /// such cases.
    ///
    /// When the incoming argument is not finite, then they should return the
    /// actual intrinsic dimensions based on the contents, as any other box would.
    /// </Summary>
    public virtual double ComputeMinIntrinsicWidth(double height)
    {
        return 0.0;
    }




    /// <Summary>
    /// Returns the smallest width beyond which increasing the width never
    /// decreases the preferred height. The preferred height is the value that
    /// would be returned by [getMinIntrinsicHeight] for that width.
    ///
    /// The height argument may give a specific height to assume. The given height
    /// can be infinite, meaning that the intrinsic width in an unconstrained
    /// environment is being requested. The given height should never be negative
    /// or null.
    ///
    /// This function should only be called on one's children. Calling this
    /// function couples the child with the parent so that when the child's layout
    /// changes, the parent is notified (via [markNeedsLayout]).
    ///
    /// Calling this function is expensive as it can result in O(N^2) behavior.
    ///
    /// Do not override this method. Instead, implement
    /// [computeMaxIntrinsicWidth].
    /// </Summary>
    public virtual double GetMaxIntrinsicWidth(double height)
    {

        return _ComputeIntrinsicDimension(_IntrinsicDimension.MaxWidth, height, ComputeMaxIntrinsicWidth);
    }




    /// <Summary>
    /// Computes the value returned by [getMaxIntrinsicWidth]. Do not call this
    /// function directly, instead, call [getMaxIntrinsicWidth].
    ///
    /// Override in subclasses that implement [performLayout]. This should return
    /// the smallest width beyond which increasing the width never decreases the
    /// preferred height. The preferred height is the value that would be returned
    /// by [computeMinIntrinsicHeight] for that width.
    ///
    /// If the layout algorithm is strictly height-in-width-out, or is
    /// height-in-width-out when the width is unconstrained, then this should
    /// return the same value as [computeMinIntrinsicWidth] for the same height.
    ///
    /// Otherwise, the height argument should be ignored, and the returned value
    /// should be equal to or bigger than the value returned by
    /// [computeMinIntrinsicWidth].
    ///
    /// The `height` argument will never be negative or null. It may be infinite.
    ///
    /// The value returned by this method might not match the size that the object
    /// would actually take. For example, a [RenderBox] subclass that always
    /// exactly sizes itself using [BoxConstraints.biggest] might well size itself
    /// bigger than its max intrinsic size.
    ///
    /// If this algorithm depends on the intrinsic dimensions of a child, the
    /// intrinsic dimensions of that child should be obtained using the functions
    /// whose names start with `get`, not `compute`.
    ///
    /// This function should never return a negative or infinite value.
    ///
    /// See also:
    ///
    ///  * [computeMinIntrinsicWidth], which has usage examples.
    /// </Summary>
    public virtual double ComputeMaxIntrinsicWidth(double height)
    {
        return 0.0;
    }




    /// <Summary>
    /// Returns the minimum height that this box could be without failing to
    /// correctly paint its contents within itself, without clipping.
    ///
    /// The width argument may give a specific width to assume. The given width
    /// can be infinite, meaning that the intrinsic height in an unconstrained
    /// environment is being requested. The given width should never be negative
    /// or null.
    ///
    /// This function should only be called on one's children. Calling this
    /// function couples the child with the parent so that when the child's layout
    /// changes, the parent is notified (via [markNeedsLayout]).
    ///
    /// Calling this function is expensive as it can result in O(N^2) behavior.
    ///
    /// Do not override this method. Instead, implement
    /// [computeMinIntrinsicHeight].
    /// </Summary>
    public virtual double GetMinIntrinsicHeight(double width)
    {

        return _ComputeIntrinsicDimension(_IntrinsicDimension.MinHeight, width, ComputeMinIntrinsicHeight);
    }




    /// <Summary>
    /// Computes the value returned by [getMinIntrinsicHeight]. Do not call this
    /// function directly, instead, call [getMinIntrinsicHeight].
    ///
    /// Override in subclasses that implement [performLayout]. Should return the
    /// minimum height that this box could be without failing to correctly paint
    /// its contents within itself, without clipping.
    ///
    /// If the layout algorithm is independent of the context (e.g. it always
    /// tries to be a particular size), or if the layout algorithm is
    /// height-in-width-out, or if the layout algorithm uses both the incoming
    /// height and width constraints (e.g. it always sizes itself to
    /// [BoxConstraints.biggest]), then the `width` argument should be ignored.
    ///
    /// If the layout algorithm is strictly width-in-height-out, or is
    /// width-in-height-out when the height is unconstrained, then the width
    /// argument is the width to use.
    ///
    /// The `width` argument will never be negative or null. It may be infinite.
    ///
    /// If this algorithm depends on the intrinsic dimensions of a child, the
    /// intrinsic dimensions of that child should be obtained using the functions
    /// whose names start with `get`, not `compute`.
    ///
    /// This function should never return a negative or infinite value.
    ///
    /// See also:
    ///
    ///  * [computeMinIntrinsicWidth], which has usage examples.
    /// </Summary>
    public virtual double ComputeMinIntrinsicHeight(double width)
    {
        return 0.0;
    }




    /// <Summary>
    /// Returns the smallest height beyond which increasing the height never
    /// decreases the preferred width. The preferred width is the value that
    /// would be returned by [getMinIntrinsicWidth] for that height.
    ///
    /// The width argument may give a specific width to assume. The given width
    /// can be infinite, meaning that the intrinsic height in an unconstrained
    /// environment is being requested. The given width should never be negative
    /// or null.
    ///
    /// This function should only be called on one's children. Calling this
    /// function couples the child with the parent so that when the child's layout
    /// changes, the parent is notified (via [markNeedsLayout]).
    ///
    /// Calling this function is expensive as it can result in O(N^2) behavior.
    ///
    /// Do not override this method. Instead, implement
    /// [computeMaxIntrinsicHeight].
    /// </Summary>
    public virtual double GetMaxIntrinsicHeight(double width)
    {

        return _ComputeIntrinsicDimension(_IntrinsicDimension.MaxHeight, width, ComputeMaxIntrinsicHeight);
    }




    /// <Summary>
    /// Computes the value returned by [getMaxIntrinsicHeight]. Do not call this
    /// function directly, instead, call [getMaxIntrinsicHeight].
    ///
    /// Override in subclasses that implement [performLayout]. Should return the
    /// smallest height beyond which increasing the height never decreases the
    /// preferred width. The preferred width is the value that would be returned
    /// by [computeMinIntrinsicWidth] for that height.
    ///
    /// If the layout algorithm is strictly width-in-height-out, or is
    /// width-in-height-out when the height is unconstrained, then this should
    /// return the same value as [computeMinIntrinsicHeight] for the same width.
    ///
    /// Otherwise, the width argument should be ignored, and the returned value
    /// should be equal to or bigger than the value returned by
    /// [computeMinIntrinsicHeight].
    ///
    /// The `width` argument will never be negative or null. It may be infinite.
    ///
    /// The value returned by this method might not match the size that the object
    /// would actually take. For example, a [RenderBox] subclass that always
    /// exactly sizes itself using [BoxConstraints.biggest] might well size itself
    /// bigger than its max intrinsic size.
    ///
    /// If this algorithm depends on the intrinsic dimensions of a child, the
    /// intrinsic dimensions of that child should be obtained using the functions
    /// whose names start with `get`, not `compute`.
    ///
    /// This function should never return a negative or infinite value.
    ///
    /// See also:
    ///
    ///  * [computeMinIntrinsicWidth], which has usage examples.
    /// </Summary>
    public virtual double ComputeMaxIntrinsicHeight(double width)
    {
        return 0.0;
    }




    /// <Summary>
    /// Claims ownership of the given [Size].
    ///
    /// In debug mode, the [RenderBox] class verifies that [Size] objects obtained
    /// from other [RenderBox] objects are only used according to the semantics of
    /// the [RenderBox] protocol, namely that a [Size] from a [RenderBox] can only
    /// be used by its parent, and then only if `parentUsesSize` was set.
    ///
    /// Sometimes, a [Size] that can validly be used ends up no longer being valid
    /// over time. The common example is a [Size] taken from a child that is later
    /// removed from the parent. In such cases, this method can be called to first
    /// check whether the size can legitimately be used, and if so, to then create
    /// a new [Size] that can be used going forward, regardless of what happens to
    /// the original owner.
    /// </Summary>
    public virtual Size DebugAdoptSize(Size value)
    {
        Size result = value;

        return result;
    }




    public new void DebugResetSize()
    {
        Size = Size;
    }




    private bool _DebugSetDoingBaseline(bool value)
    {
        _DebugDoingBaseline = value;
        return true;
    }




    /// <Summary>
    /// Returns the distance from the y-coordinate of the position of the box to
    /// the y-coordinate of the first given baseline in the box's contents.
    ///
    /// Used by certain layout models to align adjacent boxes on a common
    /// baseline, regardless of padding, font size differences, etc. If there is
    /// no baseline, this function returns the distance from the y-coordinate of
    /// the position of the box to the y-coordinate of the bottom of the box
    /// (i.e., the height of the box) unless the caller passes true
    /// for `onlyReal`, in which case the function returns null.
    ///
    /// Only call this function after calling [layout] on this box. You
    /// are only allowed to call this from the parent of this box during
    /// that parent's [performLayout] or [paint] functions.
    ///
    /// When implementing a [RenderBox] subclass, to override the baseline
    /// computation, override [computeDistanceToActualBaseline].
    /// </Summary>
    public virtual double GetDistanceToBaseline(TextBaseline baseline, bool onlyReal = false)
    {




        double result = GetDistanceToActualBaseline(baseline);

        if (result == null && !onlyReal) return Size.Height;
        return result;
    }




    /// <Summary>
    /// Calls [computeDistanceToActualBaseline] and caches the result.
    ///
    /// This function must only be called from [getDistanceToBaseline] and
    /// [computeDistanceToActualBaseline]. Do not call this function directly from
    /// outside those two methods.
    /// </Summary>
    public virtual double GetDistanceToActualBaseline(TextBaseline baseline)
    {

        _CachedBaselines = (_CachedBaselines == null ? new Dictionary<TextBaseline, double> { } : _CachedBaselines);
        _CachedBaselines.PutIfAbsent(baseline, () => =>ComputeDistanceToActualBaseline(baseline));
        return _CachedBaselines[baseline];
    }




    /// <Summary>
    /// Returns the distance from the y-coordinate of the position of the box to
    /// the y-coordinate of the first given baseline in the box's contents, if
    /// any, or null otherwise.
    ///
    /// Do not call this function directly. If you need to know the baseline of a
    /// child from an invocation of [performLayout] or [paint], call
    /// [getDistanceToBaseline].
    ///
    /// Subclasses should override this method to supply the distances to their
    /// baselines. When implementing this method, there are generally three
    /// strategies:
    ///
    ///  * For classes that use the [ContainerRenderObjectMixin] child model,
    ///    consider mixing in the [RenderBoxContainerDefaultsMixin] class and
    ///    using
    ///    [RenderBoxContainerDefaultsMixin.defaultComputeDistanceToFirstActualBaseline].
    ///
    ///  * For classes that define a particular baseline themselves, return that
    ///    value directly.
    ///
    ///  * For classes that have a child to which they wish to defer the
    ///    computation, call [getDistanceToActualBaseline] on the child (not
    ///    [computeDistanceToActualBaseline], the internal implementation, and not
    ///    [getDistanceToBaseline], the public entry point for this API).
    /// </Summary>
    public virtual double ComputeDistanceToActualBaseline(TextBaseline baseline)
    {

        return null;
    }




    public new void DebugAssertDoesMeetConstraints()
    {


    }




    public new void MarkNeedsLayout()
    {
        if ((_CachedBaselines != null && _CachedBaselines.IsNotEmpty) || (_CachedIntrinsicDimensions != null && _CachedIntrinsicDimensions.IsNotEmpty))
        {
            _CachedBaselines?.Clear();
            _CachedIntrinsicDimensions?.Clear();
            if (((RenderObject)Parent) is RenderObject)
            {
                MarkParentNeedsLayout();
                return;
            }

        }

        base.MarkNeedsLayout();
    }




    public new void PerformResize()
    {
        Size = Constraints.Smallest;

    }




    public new void PerformLayout()
    {

    }




    /// <Summary>
    /// Determines the set of render objects located at the given position.
    ///
    /// Returns true, and adds any render objects that contain the point to the
    /// given hit test result, if this render object or one of its descendants
    /// absorbs the hit (preventing objects below this one from being hit).
    /// Returns false if the hit can continue to other objects below this one.
    ///
    /// The caller is responsible for transforming [position] from global
    /// coordinates to its location relative to the origin of this [RenderBox].
    /// This [RenderBox] is responsible for checking whether the given position is
    /// within its bounds.
    ///
    /// If transforming is necessary, [BoxHitTestResult.addWithPaintTransform],
    /// [BoxHitTestResult.addWithPaintOffset], or
    /// [BoxHitTestResult.addWithRawTransform] need to be invoked by the caller
    /// to record the required transform operations in the [HitTestResult]. These
    /// methods will also help with applying the transform to `position`.
    ///
    /// Hit testing requires layout to be up-to-date but does not require painting
    /// to be up-to-date. That means a render object can rely upon [performLayout]
    /// having been called in [hitTest] but cannot rely upon [paint] having been
    /// called. For example, a render object might be a child of a [RenderOpacity]
    /// object, which calls [hitTest] on its children when its opacity is zero
    /// even through it does not [paint] its children.
    /// </Summary>
    public virtual bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
    {

        if (_Size.Contains(position))
        {
            if (HitTestChildren(result, position: position) || HitTestSelf(position))
            {
                result.Add(new BoxHitTestEntry(this, position));
                return true;
            }

        }

        return false;
    }




    /// <Summary>
    /// Override this method if this render object can be hit even if its
    /// children were not hit.
    ///
    /// The caller is responsible for transforming [position] from global
    /// coordinates to its location relative to the origin of this [RenderBox].
    /// This [RenderBox] is responsible for checking whether the given position is
    /// within its bounds.
    ///
    /// Used by [hitTest]. If you override [hitTest] and do not call this
    /// function, then you don't need to implement this function.
    /// </Summary>
    public virtual bool HitTestSelf(FlutterBinding.UI.Offset position) => false;



    /// <Summary>
    /// Override this method to check whether any children are located at the
    /// given position.
    ///
    /// Typically children should be hit-tested in reverse paint order so that
    /// hit tests at locations where children overlap hit the child that is
    /// visually "on top" (i.e., paints later).
    ///
    /// The caller is responsible for transforming [position] from global
    /// coordinates to its location relative to the origin of this [RenderBox].
    /// This [RenderBox] is responsible for checking whether the given position is
    /// within its bounds.
    ///
    /// If transforming is necessary, [HitTestResult.addWithPaintTransform],
    /// [HitTestResult.addWithPaintOffset], or [HitTestResult.addWithRawTransform] need
    /// to be invoked by the caller to record the required transform operations
    /// in the [HitTestResult]. These methods will also help with applying the
    /// transform to `position`.
    ///
    /// Used by [hitTest]. If you override [hitTest] and do not call this
    /// function, then you don't need to implement this function.
    /// </Summary>
    public virtual bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => false;



    /// <Summary>
    /// Multiply the transform from the parent's coordinate system to this box's
    /// coordinate system into the given transform.
    ///
    /// This function is used to convert coordinate systems between boxes.
    /// Subclasses that apply transforms during painting should override this
    /// function to factor those transforms into the calculation.
    ///
    /// The [RenderBox] implementation takes care of adjusting the matrix for the
    /// position of the given child as determined during layout and stored on the
    /// child's [parentData] in the [BoxParentData.offset] field.
    /// </Summary>
    public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
    {



        BoxParentData childParentData = child.ParentData as BoxParentData;
        Offset offset = childParentData.Offset;
        transform.Translate(offset.Dx, offset.Dy);
    }




    /// <Summary>
    /// Convert the given point from the global coordinate system in logical pixels
    /// to the local coordinate system for this box.
    ///
    /// This method will un-project the point from the screen onto the widget,
    /// which makes it different from [MatrixUtils.transformPoint].
    ///
    /// If the transform from global coordinates to local coordinates is
    /// degenerate, this function returns [Offset.zero].
    ///
    /// If `ancestor` is non-null, this function converts the given point from the
    /// coordinate system of `ancestor` (which must be an ancestor of this render
    /// object) instead of from the global coordinate system.
    ///
    /// This method is implemented in terms of [getTransformTo].
    /// </Summary>
    public virtual Offset GlobalToLocal(FlutterBinding.UI.Offset point, FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject))
    {
        Matrix4 transform = GetTransformTo(ancestor);
        double det = transform.Invert();
        if (det == 0.0) return Dart:uiDefaultClass.Offset.Zero;
        Vector3 n = Vector3(0.0, 0.0, 1.0);
        Vector3 i = transform.PerspectiveTransform(Vector3(0.0, 0.0, 0.0));
        Vector3 d = transform.PerspectiveTransform(Vector3(0.0, 0.0, 1.0)) - i;
        Vector3 s = transform.PerspectiveTransform(Vector3(point.Dx, point.Dy, 0.0));
        Vector3 p = s - d * (n.Dot(s) / n.Dot(d));
        return new Offset(p.x, p.y);
    }




    /// <Summary>
    /// Convert the given point from the local coordinate system for this box to
    /// the global coordinate system in logical pixels.
    ///
    /// If `ancestor` is non-null, this function converts the given point to the
    /// coordinate system of `ancestor` (which must be an ancestor of this render
    /// object) instead of to the global coordinate system.
    ///
    /// This method is implemented in terms of [getTransformTo].
    /// </Summary>
    public virtual Offset LocalToGlobal(FlutterBinding.UI.Offset point, FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject))
    {
        return MatrixutilsDefaultClass.MatrixUtils.TransformPoint(GetTransformTo(ancestor), point);
    }




    /// <Summary>
    /// Override this method to handle pointer events that hit this render object.
    ///
    /// For [RenderBox] objects, the `entry` argument is a [BoxHitTestEntry]. From this
    /// object you can determine the [PointerDownEvent]'s position in local coordinates.
    /// (This is useful because [PointerEvent.position] is in global coordinates.)
    ///
    /// If you override this, consider calling [debugHandleEvent] as follows, so
    /// that you can support [debugPaintPointersEnabled]:
    ///
    /// ```dart
    /// @override
    /// void handleEvent(PointerEvent event, HitTestEntry entry) {
    ///   assert(debugHandleEvent(event, entry));
    ///   // ... handle the event ...
    /// }
    /// ```
    /// </Summary>
    public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
    {
        base.HandleEvent(@event, entry);
    }




    /// <Summary>
    /// Implements the [debugPaintPointersEnabled] debugging feature.
    ///
    /// [RenderBox] subclasses that implement [handleEvent] should call
    /// [debugHandleEvent] from their [handleEvent] method, as follows:
    ///
    /// ```dart
    /// @override
    /// void handleEvent(PointerEvent event, HitTestEntry entry) {
    ///   assert(debugHandleEvent(event, entry));
    ///   // ... handle the event ...
    /// }
    /// ```
    ///
    /// If you call this for a [PointerDownEvent], make sure you also call it for
    /// the corresponding [PointerUpEvent] or [PointerCancelEvent].
    /// </Summary>
    public virtual bool DebugHandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry)
    {

        return true;
    }




    public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {

    }




    /// <Summary>
    /// In debug mode, paints a border around this render box.
    ///
    /// Called for every [RenderBox] when [debugPaintSizeEnabled] is true.
    /// </Summary>
    public virtual void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {

    }




    /// <Summary>
    /// In debug mode, paints a line for each baseline.
    ///
    /// Called for every [RenderBox] when [debugPaintBaselinesEnabled] is true.
    /// </Summary>
    public virtual void DebugPaintBaselines(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {

    }




    /// <Summary>
    /// In debug mode, paints a rectangle if this render box has counted more
    /// pointer downs than pointer up events.
    ///
    /// Called for every [RenderBox] when [debugPaintPointersEnabled] is true.
    ///
    /// By default, events are not counted. For details on how to ensure that
    /// events are counted for your class, see [debugHandleEvent].
    /// </Summary>
    public virtual void DebugPaintPointers(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {

    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<Size>("size", _Size, missingIfNull: true));
    }



    #endregion
}


public enum _IntrinsicDimension
{

    MinWidth,
    MaxWidth,
    MinHeight,
    MaxHeight,
}

}
