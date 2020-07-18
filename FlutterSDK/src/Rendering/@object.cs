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
namespace FlutterSDK.Rendering.@object
{
    public delegate void PaintingContextCallback(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
    public delegate void RenderObjectVisitor(FlutterSDK.Rendering.@object.RenderObject child);
    public delegate void LayoutCallback<T>(T constraints);
    internal static class ObjectDefaultClass
    {
    }

    /// <Summary>
    /// An abstract set of layout constraints.
    ///
    /// Concrete layout models (such as box) will create concrete subclasses to
    /// communicate layout constraints between parents and children.
    ///
    /// ## Writing a Constraints subclass
    ///
    /// When creating a new [RenderObject] subclass with a new layout protocol, one
    /// will usually need to create a new [Constraints] subclass to express the
    /// input to the layout algorithms.
    ///
    /// A [Constraints] subclass should be immutable (all fields final). There are
    /// several members to implement, in addition to whatever fields, constructors,
    /// and helper methods one may find useful for a particular layout protocol:
    ///
    /// * The [isTight] getter, which should return true if the object represents a
    ///   case where the [RenderObject] class has no choice for how to lay itself
    ///   out. For example, [BoxConstraints] returns true for [isTight] when both
    ///   the minimum and maximum widths and the minimum and maximum heights are
    ///   equal.
    ///
    /// * The [isNormalized] getter, which should return true if the object
    ///   represents its data in its canonical form. Sometimes, it is possible for
    ///   fields to be redundant with each other, such that several different
    ///   representations have the same implications. For example, a
    ///   [BoxConstraints] instance with its minimum width greater than its maximum
    ///   width is equivalent to one where the maximum width is set to that minimum
    ///   width (`2<w<1` is equivalent to `2<w<2`, since minimum constraints have
    ///   priority). This getter is used by the default implementation of
    ///   [debugAssertIsValid].
    ///
    /// * The [debugAssertIsValid] method, which should assert if there's anything
    ///   wrong with the constraints object. (We use this approach rather than
    ///   asserting in constructors so that our constructors can be `const` and so
    ///   that it is possible to create invalid constraints temporarily while
    ///   building valid ones.) See the implementation of
    ///   [BoxConstraints.debugAssertIsValid] for an example of the detailed checks
    ///   that can be made.
    ///
    /// * The [==] operator and the [hashCode] getter, so that constraints can be
    ///   compared for equality. If a render object is given constraints that are
    ///   equal, then the rendering library will avoid laying the object out again
    ///   if it is not dirty.
    ///
    /// * The [toString] method, which should describe the constraints so that they
    ///   appear in a usefully readable form in the output of [debugDumpRenderTree].
    /// </Summary>
    public interface IConstraints
    {
        bool DebugAssertIsValid(bool isAppliedConstraint = false, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector));
        bool IsTight { get; }
        bool IsNormalized { get; }
    }


    /// <Summary>
    /// An object in the render tree.
    ///
    /// The [RenderObject] class hierarchy is the core of the rendering
    /// library's reason for being.
    ///
    /// [RenderObject]s have a [parent], and have a slot called [parentData] in
    /// which the parent [RenderObject] can store child-specific data, for example,
    /// the child position. The [RenderObject] class also implements the basic
    /// layout and paint protocols.
    ///
    /// The [RenderObject] class, however, does not define a child model (e.g.
    /// whether a node has zero, one, or more children). It also doesn't define a
    /// coordinate system (e.g. whether children are positioned in Cartesian
    /// coordinates, in polar coordinates, etc) or a specific layout protocol (e.g.
    /// whether the layout is width-in-height-out, or constraint-in-size-out, or
    /// whether the parent sets the size and position of the child before or after
    /// the child lays out, etc; or indeed whether the children are allowed to read
    /// their parent's [parentData] slot).
    ///
    /// The [RenderBox] subclass introduces the opinion that the layout
    /// system uses Cartesian coordinates.
    ///
    /// ## Writing a RenderObject subclass
    ///
    /// In most cases, subclassing [RenderObject] itself is overkill, and
    /// [RenderBox] would be a better starting point. However, if a render object
    /// doesn't want to use a Cartesian coordinate system, then it should indeed
    /// inherit from [RenderObject] directly. This allows it to define its own
    /// layout protocol by using a new subclass of [Constraints] rather than using
    /// [BoxConstraints], and by potentially using an entirely new set of objects
    /// and values to represent the result of the output rather than just a [Size].
    /// This increased flexibility comes at the cost of not being able to rely on
    /// the features of [RenderBox]. For example, [RenderBox] implements an
    /// intrinsic sizing protocol that allows you to measure a child without fully
    /// laying it out, in such a way that if that child changes size, the parent
    /// will be laid out again (to take into account the new dimensions of the
    /// child). This is a subtle and bug-prone feature to get right.
    ///
    /// Most aspects of writing a [RenderBox] apply to writing a [RenderObject] as
    /// well, and therefore the discussion at [RenderBox] is recommended background
    /// reading. The main differences are around layout and hit testing, since those
    /// are the aspects that [RenderBox] primarily specializes.
    ///
    /// ### Layout
    ///
    /// A layout protocol begins with a subclass of [Constraints]. See the
    /// discussion at [Constraints] for more information on how to write a
    /// [Constraints] subclass.
    ///
    /// The [performLayout] method should take the [constraints], and apply them.
    /// The output of the layout algorithm is fields set on the object that describe
    /// the geometry of the object for the purposes of the parent's layout. For
    /// example, with [RenderBox] the output is the [RenderBox.size] field. This
    /// output should only be read by the parent if the parent specified
    /// `parentUsesSize` as true when calling [layout] on the child.
    ///
    /// Anytime anything changes on a render object that would affect the layout of
    /// that object, it should call [markNeedsLayout].
    ///
    /// ### Hit Testing
    ///
    /// Hit testing is even more open-ended than layout. There is no method to
    /// override, you are expected to provide one.
    ///
    /// The general behavior of your hit-testing method should be similar to the
    /// behavior described for [RenderBox]. The main difference is that the input
    /// need not be an [Offset]. You are also allowed to use a different subclass of
    /// [HitTestEntry] when adding entries to the [HitTestResult]. When the
    /// [handleEvent] method is called, the same object that was added to the
    /// [HitTestResult] will be passed in, so it can be used to track information
    /// like the precise coordinate of the hit, in whatever coordinate system is
    /// used by the new layout protocol.
    ///
    /// ### Adapting from one protocol to another
    ///
    /// In general, the root of a Flutter render object tree is a [RenderView]. This
    /// object has a single child, which must be a [RenderBox]. Thus, if you want to
    /// have a custom [RenderObject] subclass in the render tree, you have two
    /// choices: you either need to replace the [RenderView] itself, or you need to
    /// have a [RenderBox] that has your class as its child. (The latter is the much
    /// more common case.)
    ///
    /// This [RenderBox] subclass converts from the box protocol to the protocol of
    /// your class.
    ///
    /// In particular, this means that for hit testing it overrides
    /// [RenderBox.hitTest], and calls whatever method you have in your class for
    /// hit testing.
    ///
    /// Similarly, it overrides [performLayout] to create a [Constraints] object
    /// appropriate for your class and passes that to the child's [layout] method.
    ///
    /// ### Layout interactions between render objects
    ///
    /// In general, the layout of a render object should only depend on the output of
    /// its child's layout, and then only if `parentUsesSize` is set to true in the
    /// [layout] call. Furthermore, if it is set to true, the parent must call the
    /// child's [layout] if the child is to be rendered, because otherwise the
    /// parent will not be notified when the child changes its layout outputs.
    ///
    /// It is possible to set up render object protocols that transfer additional
    /// information. For example, in the [RenderBox] protocol you can query your
    /// children's intrinsic dimensions and baseline geometry. However, if this is
    /// done then it is imperative that the child call [markNeedsLayout] on the
    /// parent any time that additional information changes, if the parent used it
    /// in the last layout phase. For an example of how to implement this, see the
    /// [RenderBox.markNeedsLayout] method. It overrides
    /// [RenderObject.markNeedsLayout] so that if a parent has queried the intrinsic
    /// or baseline information, it gets marked dirty whenever the child's geometry
    /// changes.
    /// </Summary>
    public interface IRenderObject
    {
        void Reassemble();
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        void AdoptChild(FlutterSDK.Rendering.@object.RenderObject child);
        void DropChild(FlutterSDK.Rendering.@object.RenderObject child);
        void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void DebugAssertDoesMeetConstraints();
        void MarkNeedsLayout();
        void MarkParentNeedsLayout();
        void MarkNeedsLayoutForSizedByParentChange();
        void ScheduleInitialLayout();
        void Layout(FlutterSDK.Rendering.@object.Constraints constraints, bool parentUsesSize = false);
        void DebugResetSize();
        void PerformResize();
        void PerformLayout();
        void InvokeLayoutCallback<T>(FlutterSDK.Rendering.@object.LayoutCallback<T> callback);
        void Rotate(int oldAngle = default(int), int newAngle = default(int), TimeSpan time = default(TimeSpan));
        void DebugRegisterRepaintBoundaryPaint(bool includedParent = true, bool includedChild = false);
        void MarkNeedsCompositingBitsUpdate();
        void MarkNeedsPaint();
        void ScheduleInitialPaint(FlutterSDK.Rendering.Layer.ContainerLayer rootLayer);
        void ReplaceRootLayer(FlutterSDK.Rendering.Layer.OffsetLayer rootLayer);
        void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        Matrix4 GetTransformTo(FlutterSDK.Rendering.@object.RenderObject ancestor);
        Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child);
        Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child);
        void ScheduleInitialSemantics();
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void SendSemanticsEvent(FlutterSDK.Semantics.Semanticsevent.SemanticsEvent semanticsEvent);
        void ClearSemantics();
        void MarkNeedsSemanticsUpdate();
        void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry);
        string ToStringShort();
        string ToString(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeForError(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        FlutterSDK.Rendering.@object.ParentData ParentData { get; set; }
        object DebugCreator { get; set; }
        bool DebugCheckingIntrinsics { get; set; }
        bool DebugDoingThisResize { get; }
        bool DebugDoingThisLayout { get; }
        FlutterSDK.Rendering.@object.RenderObject DebugActiveLayout { get; }
        bool DebugCanParentUseSize { get; }
        FlutterSDK.Rendering.@object.PipelineOwner Owner { get; }
        bool DebugNeedsLayout { get; }
        FlutterSDK.Rendering.@object.Constraints Constraints { get; }
        bool SizedByParent { get; }
        bool DebugDoingThisPaint { get; }
        FlutterSDK.Rendering.@object.RenderObject DebugActivePaint { get; }
        bool IsRepaintBoundary { get; }
        bool AlwaysNeedsCompositing { get; }
        FlutterSDK.Rendering.Layer.ContainerLayer Layer { get; set; }
        FlutterSDK.Rendering.Layer.ContainerLayer DebugLayer { get; }
        bool NeedsCompositing { get; }
        bool DebugNeedsPaint { get; }
        FlutterBinding.UI.Rect PaintBounds { get; }
        FlutterBinding.UI.Rect SemanticBounds { get; }
        FlutterSDK.Semantics.Semantics.SemanticsNode DebugSemantics { get; }
    }


    /// <Summary>
    /// Describes the semantics information a [RenderObject] wants to add to its
    /// parent.
    ///
    /// It has two notable subclasses:
    ///  * [_InterestingSemanticsFragment] describing actual semantic information to
    ///    be added to the parent.
    ///  * [_ContainerSemanticsFragment]: a container class to transport the semantic
    ///    information of multiple [_InterestingSemanticsFragment] to a parent.
    /// </Summary>
    internal interface I_SemanticsFragment
    {
        void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments);
        bool DropsSemanticsOfPreviousSiblings { get; }
        Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get; }
        bool AbortsWalk { get; }
    }


    /// <Summary>
    /// A [_SemanticsFragment] that describes which concrete semantic information
    /// a [RenderObject] wants to add to the [SemanticsNode] of its parent.
    ///
    /// Specifically, it describes which children (as returned by [compileChildren])
    /// should be added to the parent's [SemanticsNode] and which [config] should be
    /// merged into the parent's [SemanticsNode].
    /// </Summary>
    internal interface I_InterestingSemanticsFragment
    {
        Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double));
        void MarkAsExplicit();
        void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments);
        void AddTags(Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> tags);
        void AddAncestor(FlutterSDK.Rendering.@object.RenderObject ancestor);
        FlutterSDK.Rendering.@object.RenderObject Owner { get; }
        FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get; }
        bool HasConfigForParent { get; }
        Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get; }
    }


    public interface IRenderObjectWithChildMixin<ChildType> { }

    public class RenderObjectWithChildMixin<ChildType>
    {
        internal virtual ChildType _Child { get; set; }
        public virtual ChildType Child { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

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




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            if (_Child != null) _Child.Attach(owner);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            if (_Child != null) _Child.Attach(owner);
        }




        public new void Detach()
        {
            base.Detach();
            if (_Child != null) _Child.Detach();
        }




        public new void RedepthChildren()
        {
            if (_Child != null) RedepthChild(_Child);
        }




        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            if (_Child != null) visitor(_Child);
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            return Child != null ? new List<DiagnosticsNode>() { Child.ToDiagnosticsNode(name: "child") } : new List<DiagnosticsNode>() { };
        }



    }
    public static class RenderObjectWithChildMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static RenderObjectWithChildMixin<ChildType> GetOrCreate<ChildType>(IRenderObjectWithChildMixin<ChildType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderObjectWithChildMixin<ChildType>();
                _table.Add(instance, value);
            }
            return (RenderObjectWithChildMixin<ChildType>)value;
        }
        public static ChildType ChildProperty<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).Child;
        public static bool DebugValidateChild<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance, FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).DebugValidateChild(child);
        public static void Attach<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).Detach();
        public static void RedepthChildren<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).RedepthChildren();
        public static void VisitChildren<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance, FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) => GetOrCreate(instance).VisitChildren(visitor);
        public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).DebugDescribeChildren();
    }


    public interface IContainerParentDataMixin<ChildType> { }

    public class ContainerParentDataMixin<ChildType>
    {
        public virtual ChildType PreviousSibling { get; set; }
        public virtual ChildType NextSibling { get; set; }

        /// <Summary>
        /// Clear the sibling pointers.
        /// </Summary>
        public new void Detach()
        {


            base.Detach();
        }



    }
    public static class ContainerParentDataMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static ContainerParentDataMixin<ChildType> GetOrCreate<ChildType>(IContainerParentDataMixin<ChildType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ContainerParentDataMixin<ChildType>();
                _table.Add(instance, value);
            }
            return (ContainerParentDataMixin<ChildType>)value;
        }
        public static ChildType PreviousSiblingProperty<ChildType>(this IContainerParentDataMixin<ChildType> instance) => GetOrCreate(instance).PreviousSibling;
        public static ChildType NextSiblingProperty<ChildType>(this IContainerParentDataMixin<ChildType> instance) => GetOrCreate(instance).NextSibling;
        public static void Detach<ChildType>(this IContainerParentDataMixin<ChildType> instance) => GetOrCreate(instance).Detach();
    }


    public interface IContainerRenderObjectMixin<ChildType, ParentDataType> { }

    public class ContainerRenderObjectMixin<ChildType, ParentDataType>
    {
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
    public static class ContainerRenderObjectMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static ContainerRenderObjectMixin<ChildType, ParentDataType> GetOrCreate<ChildType, ParentDataType>(IContainerRenderObjectMixin<ChildType, ParentDataType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ContainerRenderObjectMixin<ChildType, ParentDataType>();
                _table.Add(instance, value);
            }
            return (ContainerRenderObjectMixin<ChildType, ParentDataType>)value;
        }
        public static int ChildCountProperty<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).ChildCount;
        public static ChildType FirstChildProperty<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).FirstChild;
        public static ChildType LastChildProperty<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).LastChild;
        public static bool DebugValidateChild<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).DebugValidateChild(child);
        public static void Insert<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child, ChildType after = default(ChildType)) => GetOrCreate(instance).Insert(child, after);
        public static void Add<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).Add(child);
        public static void AddAll<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, List<ChildType> children) => GetOrCreate(instance).AddAll(children);
        public static void Remove<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).Remove(child);
        public static void RemoveAll<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).RemoveAll();
        public static void Move<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child, ChildType after = default(ChildType)) => GetOrCreate(instance).Move(child, after);
        public static void Attach<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).Detach();
        public static void RedepthChildren<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).RedepthChildren();
        public static void VisitChildren<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) => GetOrCreate(instance).VisitChildren(visitor);
        public static ChildType ChildBefore<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).ChildBefore(child);
        public static ChildType ChildAfter<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).ChildAfter(child);
        public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).DebugDescribeChildren();
    }


    public interface IRelayoutWhenSystemFontsChangeMixin { }

    public class RelayoutWhenSystemFontsChangeMixin
    {

        /// <Summary>
        /// A callback that is called when system fonts have changed.
        ///
        /// By default, [markNeedsLayout] is called on the [RenderObject]
        /// implementing this mixin.
        ///
        /// Subclass should override this method to clear any extra cache that depend
        /// on font-related metrics.
        /// </Summary>
        public virtual void SystemFontsDidChange()
        {
            MarkNeedsLayout();
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            BindingDefaultClass.PaintingBinding.Instance.SystemFonts.AddListener(SystemFontsDidChange);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            BindingDefaultClass.PaintingBinding.Instance.SystemFonts.AddListener(SystemFontsDidChange);
        }




        public new void Detach()
        {
            BindingDefaultClass.PaintingBinding.Instance.SystemFonts.RemoveListener(SystemFontsDidChange);
            base.Detach();
        }



    }
    public static class RelayoutWhenSystemFontsChangeMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRelayoutWhenSystemFontsChangeMixin, RelayoutWhenSystemFontsChangeMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRelayoutWhenSystemFontsChangeMixin, RelayoutWhenSystemFontsChangeMixin>();
        static RelayoutWhenSystemFontsChangeMixin GetOrCreate(IRelayoutWhenSystemFontsChangeMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RelayoutWhenSystemFontsChangeMixin();
                _table.Add(instance, value);
            }
            return (RelayoutWhenSystemFontsChangeMixin)value;
        }
        public static void SystemFontsDidChange(this IRelayoutWhenSystemFontsChangeMixin instance) => GetOrCreate(instance).SystemFontsDidChange();
        public static void Attach(this IRelayoutWhenSystemFontsChangeMixin instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach(this IRelayoutWhenSystemFontsChangeMixin instance) => GetOrCreate(instance).Detach();
    }


    public interface IParentData { }

    public class ParentData
    {

        /// <Summary>
        /// Called when the RenderObject is removed from the tree.
        /// </Summary>
        public virtual void Detach()
        {
        }




    }
    public static class ParentDataMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IParentData, ParentData> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IParentData, ParentData>();
        static ParentData GetOrCreate(IParentData instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ParentData();
                _table.Add(instance, value);
            }
            return (ParentData)value;
        }
        public static void Detach(this IParentData instance) => GetOrCreate(instance).Detach();
        public static string ToString(this IParentData instance) => GetOrCreate(instance).ToString();
    }


    /// <Summary>
    /// A place to paint.
    ///
    /// Rather than holding a canvas directly, [RenderObject]s paint using a painting
    /// context. The painting context has a [Canvas], which receives the
    /// individual draw operations, and also has functions for painting child
    /// render objects.
    ///
    /// When painting a child render object, the canvas held by the painting context
    /// can change because the draw operations issued before and after painting the
    /// child might be recorded in separate compositing layers. For this reason, do
    /// not hold a reference to the canvas across operations that might paint
    /// child render objects.
    ///
    /// New [PaintingContext] objects are created automatically when using
    /// [PaintingContext.repaintCompositedChild] and [pushLayer].
    /// </Summary>
    public class PaintingContext : FlutterSDK.Painting.Clip.ClipContext
    {
        #region constructors
        public PaintingContext(FlutterSDK.Rendering.Layer.ContainerLayer _containerLayer, FlutterBinding.UI.Rect estimatedBounds)
        : base()
        {
            this._ContainerLayer = _containerLayer;
            this.EstimatedBounds = estimatedBounds;
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Layer.ContainerLayer _ContainerLayer { get; set; }
        public virtual FlutterBinding.UI.Rect EstimatedBounds { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.PictureLayer _CurrentLayer { get; set; }
        internal virtual PictureRecorder _Recorder { get; set; }
        internal virtual Canvas _Canvas { get; set; }
        internal virtual bool _IsRecording { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Canvas Canvas { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Repaint the given render object.
        ///
        /// The render object must be attached to a [PipelineOwner], must have a
        /// composited layer, and must be in need of painting. The render object's
        /// layer, if any, is re-used, along with any layers in the subtree that don't
        /// need to be repainted.
        ///
        /// See also:
        ///
        ///  * [RenderObject.isRepaintBoundary], which determines if a [RenderObject]
        ///    has a composited layer.
        /// </Summary>
        public virtual void RepaintCompositedChild(FlutterSDK.Rendering.@object.RenderObject child, bool debugAlsoPaintedParent = false)
        {

            _RepaintCompositedChild(child, debugAlsoPaintedParent: debugAlsoPaintedParent);
        }




        private void _RepaintCompositedChild(FlutterSDK.Rendering.@object.RenderObject child, bool debugAlsoPaintedParent = false, FlutterSDK.Rendering.@object.PaintingContext childContext = default(FlutterSDK.Rendering.@object.PaintingContext))
        {


            OffsetLayer childLayer = child._Layer as OffsetLayer;
            if (childLayer == null)
            {

                child._Layer = childLayer = new OffsetLayer();
            }
            else
            {


                childLayer.RemoveAllChildren();
            }




            childContext = (childContext == null ? new PaintingContext(child._Layer, child.PaintBounds) : childContext);
            child._PaintWithContext(childContext, Dart: uiDefaultClass.Offset.Zero);

            childContext.StopRecordingIfNeeded();
        }




        /// <Summary>
        /// In debug mode, repaint the given render object using a custom painting
        /// context that can record the results of the painting operation in addition
        /// to performing the regular paint of the child.
        ///
        /// See also:
        ///
        ///  * [repaintCompositedChild], for repainting a composited child without
        ///    instrumentation.
        /// </Summary>
        public virtual void DebugInstrumentRepaintCompositedChild(FlutterSDK.Rendering.@object.RenderObject child, bool debugAlsoPaintedParent = false, FlutterSDK.Rendering.@object.PaintingContext customContext = default(FlutterSDK.Rendering.@object.PaintingContext))
        {

        }




        /// <Summary>
        /// Paint a child [RenderObject].
        ///
        /// If the child has its own composited layer, the child will be composited
        /// into the layer subtree associated with this painting context. Otherwise,
        /// the child will be painted into the current PictureLayer for this context.
        /// </Summary>
        public virtual void PaintChild(FlutterSDK.Rendering.@object.RenderObject child, FlutterBinding.UI.Offset offset)
        {

            if (child.IsRepaintBoundary)
            {
                StopRecordingIfNeeded();
                _CompositeChild(child, offset);
            }
            else
            {
                child._PaintWithContext(this, offset);
            }


        }




        private void _CompositeChild(FlutterSDK.Rendering.@object.RenderObject child, FlutterBinding.UI.Offset offset)
        {



            if (child._NeedsPaint)
            {
                RepaintCompositedChild(child, debugAlsoPaintedParent: true);
            }
            else
            {

            }


            OffsetLayer childOffsetLayer = child._Layer as OffsetLayer;
            childOffsetLayer.Offset = offset;
            AppendLayer(child._Layer);
        }




        /// <Summary>
        /// Adds a layer to the recording requiring that the recording is already
        /// stopped.
        ///
        /// Do not call this function directly: call [addLayer] or [pushLayer]
        /// instead. This function is called internally when all layers not
        /// generated from the [canvas] are added.
        ///
        /// Subclasses that need to customize how layers are added should override
        /// this method.
        /// </Summary>
        public virtual void AppendLayer(FlutterSDK.Rendering.Layer.Layer layer)
        {

            layer.Remove();
            _ContainerLayer.Append(layer);
        }




        private void _StartRecording()
        {

            _CurrentLayer = new PictureLayer(EstimatedBounds);
            _Recorder = new Ui.PictureRecorder();
            _Canvas = new Canvas(_Recorder);
            _ContainerLayer.Append(_CurrentLayer);
        }




        /// <Summary>
        /// Stop recording to a canvas if recording has started.
        ///
        /// Do not call this function directly: functions in this class will call
        /// this method as needed. This function is called internally to ensure that
        /// recording is stopped before adding layers or finalizing the results of a
        /// paint.
        ///
        /// Subclasses that need to customize how recording to a canvas is performed
        /// should override this method to save the results of the custom canvas
        /// recordings.
        /// </Summary>
        public virtual void StopRecordingIfNeeded()
        {
            if (!_IsRecording) return;

            _CurrentLayer.Picture = _Recorder.EndRecording();
            _CurrentLayer = null;
            _Recorder = null;
            _Canvas = null;
        }




        /// <Summary>
        /// Hints that the painting in the current layer is complex and would benefit
        /// from caching.
        ///
        /// If this hint is not set, the compositor will apply its own heuristics to
        /// decide whether the current layer is complex enough to benefit from
        /// caching.
        /// </Summary>
        public virtual void SetIsComplexHint()
        {
            _CurrentLayer?.IsComplexHint = true;
        }




        /// <Summary>
        /// Hints that the painting in the current layer is likely to change next frame.
        ///
        /// This hint tells the compositor not to cache the current layer because the
        /// cache will not be used in the future. If this hint is not set, the
        /// compositor will apply its own heuristics to decide whether the current
        /// layer is likely to be reused in the future.
        /// </Summary>
        public virtual void SetWillChangeHint()
        {
            _CurrentLayer?.WillChangeHint = true;
        }




        /// <Summary>
        /// Adds a composited leaf layer to the recording.
        ///
        /// After calling this function, the [canvas] property will change to refer to
        /// a new [Canvas] that draws on top of the given layer.
        ///
        /// A [RenderObject] that uses this function is very likely to require its
        /// [RenderObject.alwaysNeedsCompositing] property to return true. That informs
        /// ancestor render objects that this render object will include a composited
        /// layer, which, for example, causes them to use composited clips.
        ///
        /// See also:
        ///
        ///  * [pushLayer], for adding a layer and painting further contents within
        ///    it.
        /// </Summary>
        public virtual void AddLayer(FlutterSDK.Rendering.Layer.Layer layer)
        {
            StopRecordingIfNeeded();
            AppendLayer(layer);
        }




        /// <Summary>
        /// Appends the given layer to the recording, and calls the `painter` callback
        /// with that layer, providing the `childPaintBounds` as the estimated paint
        /// bounds of the child. The `childPaintBounds` can be used for debugging but
        /// have no effect on painting.
        ///
        /// The given layer must be an unattached orphan. (Providing a newly created
        /// object, rather than reusing an existing layer, satisfies that
        /// requirement.)
        ///
        /// {@template flutter.rendering.object.pushLayer.offset}
        /// The `offset` is the offset to pass to the `painter`. In particular, it is
        /// not an offset applied to the layer itself. Layers conceptually by default
        /// have no position or size, though they can transform their contents. For
        /// example, an [OffsetLayer] applies an offset to its children.
        /// {@endtemplate}
        ///
        /// If the `childPaintBounds` are not specified then the current layer's paint
        /// bounds are used. This is appropriate if the child layer does not apply any
        /// transformation or clipping to its contents. The `childPaintBounds`, if
        /// specified, must be in the coordinate system of the new layer (i.e. as seen
        /// by its children after it applies whatever transform to its contents), and
        /// should not go outside the current layer's paint bounds.
        ///
        /// See also:
        ///
        ///  * [addLayer], for pushing a layer without painting further contents
        ///    within it.
        /// </Summary>
        public virtual void PushLayer(FlutterSDK.Rendering.Layer.ContainerLayer childLayer, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect childPaintBounds = default(FlutterBinding.UI.Rect))
        {

            if (childLayer.HasChildren)
            {
                childLayer.RemoveAllChildren();
            }

            StopRecordingIfNeeded();
            AppendLayer(childLayer);
            PaintingContext childContext = CreateChildContext(childLayer, childPaintBounds ?? EstimatedBounds);
            painter(childContext, offset);
            childContext.StopRecordingIfNeeded();
        }




        /// <Summary>
        /// Creates a painting context configured to paint into [childLayer].
        ///
        /// The `bounds` are estimated paint bounds for debugging purposes.
        /// </Summary>
        public virtual FlutterSDK.Rendering.@object.PaintingContext CreateChildContext(FlutterSDK.Rendering.Layer.ContainerLayer childLayer, FlutterBinding.UI.Rect bounds)
        {
            return new PaintingContext(childLayer, bounds);
        }




        /// <Summary>
        /// Clip further painting using a rectangle.
        ///
        /// {@template flutter.rendering.object.needsCompositing}
        /// The `needsCompositing` argument specifies whether the child needs
        /// compositing. Typically this matches the value of
        /// [RenderObject.needsCompositing] for the caller. If false, this method
        /// returns null, indicating that a layer is no longer necessary. If a render
        /// object calling this method stores the `oldLayer` in its
        /// [RenderObject.layer] field, it should set that field to null.
        ///
        /// When `needsCompositing` is false, this method will use a more efficient
        /// way to apply the layer effect than actually creating a layer.
        /// {@endtemplate}
        ///
        /// {@template flutter.rendering.object.pushClipLayer.offset}
        /// The `offset` argument is the offset from the origin of the canvas'
        /// coordinate system to the origin of the caller's coordinate system.
        /// {@endtemplate}
        ///
        /// The `clipRect` is the rectangle (in the caller's coordinate system) to use
        /// to clip the painting done by [painter]. It should not include the
        /// `offset`.
        ///
        /// The `painter` callback will be called while the `clipRect` is applied. It
        /// is called synchronously during the call to [pushClipRect].
        ///
        /// The `clipBehavior` argument controls how the rectangle is clipped.
        ///
        /// {@template flutter.rendering.object.oldLayer}
        /// For the `oldLayer` argument, specify the layer created in the previous
        /// frame. This gives the engine more information for performance
        /// optimizations. Typically this is the value of [RenderObject.layer] that a
        /// render object creates once, then reuses for all subsequent frames until a
        /// layer is no longer needed (e.g. the render object no longer needs
        /// compositing) or until the render object changes the type of the layer
        /// (e.g. from opacity layer to a clip rect layer).
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Layer.ClipRectLayer PushClipRect(bool needsCompositing, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect clipRect, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Layer.ClipRectLayer oldLayer = default(FlutterSDK.Rendering.Layer.ClipRectLayer))
        {
            Rect offsetClipRect = clipRect.Shift(offset);
            if (needsCompositing)
            {
                ClipRectLayer layer = oldLayer ?? new ClipRectLayer();
                ..ClipRect = offsetClipRect..ClipBehavior = clipBehavior;
                PushLayer(layer, painter, offset, childPaintBounds: offsetClipRect);
                return layer;
            }
            else
            {
                ClipRectAndPaint(offsetClipRect, clipBehavior, offsetClipRect, () => =>painter(this, offset));
                return null;
            }

        }




        /// <Summary>
        /// Clip further painting using a rounded rectangle.
        ///
        /// {@macro flutter.rendering.object.needsCompositing}
        ///
        /// {@macro flutter.rendering.object.pushClipLayer.offset}
        ///
        /// The `bounds` argument is used to specify the region of the canvas (in the
        /// caller's coordinate system) into which `painter` will paint.
        ///
        /// The `clipRRect` argument specifies the rounded-rectangle (in the caller's
        /// coordinate system) to use to clip the painting done by `painter`. It
        /// should not include the `offset`.
        ///
        /// The `painter` callback will be called while the `clipRRect` is applied. It
        /// is called synchronously during the call to [pushClipRRect].
        ///
        /// The `clipBehavior` argument controls how the rounded rectangle is clipped.
        ///
        /// {@macro flutter.rendering.object.oldLayer}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Layer.ClipRRectLayer PushClipRRect(bool needsCompositing, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect bounds, FlutterBinding.UI.RRect clipRRect, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Layer.ClipRRectLayer oldLayer = default(FlutterSDK.Rendering.Layer.ClipRRectLayer))
        {

            Rect offsetBounds = bounds.Shift(offset);
            RRect offsetClipRRect = clipRRect.Shift(offset);
            if (needsCompositing)
            {
                ClipRRectLayer layer = oldLayer ?? new ClipRRectLayer();
                ..ClipRRect = offsetClipRRect..ClipBehavior = clipBehavior;
                PushLayer(layer, painter, offset, childPaintBounds: offsetBounds);
                return layer;
            }
            else
            {
                ClipRRectAndPaint(offsetClipRRect, clipBehavior, offsetBounds, () => =>painter(this, offset));
                return null;
            }

        }




        /// <Summary>
        /// Clip further painting using a path.
        ///
        /// {@macro flutter.rendering.object.needsCompositing}
        ///
        /// {@macro flutter.rendering.object.pushClipLayer.offset}
        ///
        /// The `bounds` argument is used to specify the region of the canvas (in the
        /// caller's coordinate system) into which `painter` will paint.
        ///
        /// The `clipPath` argument specifies the [Path] (in the caller's coordinate
        /// system) to use to clip the painting done by `painter`. It should not
        /// include the `offset`.
        ///
        /// The `painter` callback will be called while the `clipPath` is applied. It
        /// is called synchronously during the call to [pushClipPath].
        ///
        /// The `clipBehavior` argument controls how the path is clipped.
        ///
        /// {@macro flutter.rendering.object.oldLayer}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Layer.ClipPathLayer PushClipPath(bool needsCompositing, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect bounds, Path clipPath, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Layer.ClipPathLayer oldLayer = default(FlutterSDK.Rendering.Layer.ClipPathLayer))
        {

            Rect offsetBounds = bounds.Shift(offset);
            Path offsetClipPath = clipPath.Shift(offset);
            if (needsCompositing)
            {
                ClipPathLayer layer = oldLayer ?? new ClipPathLayer();
                ..ClipPath = offsetClipPath..ClipBehavior = clipBehavior;
                PushLayer(layer, painter, offset, childPaintBounds: offsetBounds);
                return layer;
            }
            else
            {
                ClipPathAndPaint(offsetClipPath, clipBehavior, offsetBounds, () => =>painter(this, offset));
                return null;
            }

        }




        /// <Summary>
        /// Blend further painting with a color filter.
        ///
        /// {@macro flutter.rendering.object.pushLayer.offset}
        ///
        /// The `colorFilter` argument is the [ColorFilter] value to use when blending
        /// the painting done by `painter`.
        ///
        /// The `painter` callback will be called while the `colorFilter` is applied.
        /// It is called synchronously during the call to [pushColorFilter].
        ///
        /// {@macro flutter.rendering.object.oldLayer}
        ///
        /// A [RenderObject] that uses this function is very likely to require its
        /// [RenderObject.alwaysNeedsCompositing] property to return true. That informs
        /// ancestor render objects that this render object will include a composited
        /// layer, which, for example, causes them to use composited clips.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Layer.ColorFilterLayer PushColorFilter(FlutterBinding.UI.Offset offset, ColorFilter colorFilter, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterSDK.Rendering.Layer.ColorFilterLayer oldLayer = default(FlutterSDK.Rendering.Layer.ColorFilterLayer))
        {

            ColorFilterLayer layer = oldLayer ?? new ColorFilterLayer();
            layer.ColorFilter = colorFilter;
            PushLayer(layer, painter, offset);
            return layer;
        }




        /// <Summary>
        /// Transform further painting using a matrix.
        ///
        /// {@macro flutter.rendering.object.needsCompositing}
        ///
        /// The `offset` argument is the offset to pass to `painter` and the offset to
        /// the origin used by `transform`.
        ///
        /// The `transform` argument is the [Matrix4] with which to transform the
        /// coordinate system while calling `painter`. It should not include `offset`.
        /// It is applied effectively after applying `offset`.
        ///
        /// The `painter` callback will be called while the `transform` is applied. It
        /// is called synchronously during the call to [pushTransform].
        ///
        /// {@macro flutter.rendering.object.oldLayer}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Layer.TransformLayer PushTransform(bool needsCompositing, FlutterBinding.UI.Offset offset, Matrix4 transform, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterSDK.Rendering.Layer.TransformLayer oldLayer = default(FlutterSDK.Rendering.Layer.TransformLayer))
        {
            Matrix4 effectiveTransform = Matrix4.TranslationValues(offset.Dx, offset.Dy, 0.0);
            Matrix4.TranslationValues(offset.Dx, offset.Dy, 0.0).Multiply(transform);
            Matrix4.TranslationValues(offset.Dx, offset.Dy, 0.0).Translate(-offset.Dx, -offset.Dy);
            if (needsCompositing)
            {
                TransformLayer layer = oldLayer ?? new TransformLayer();
                layer.Transform = effectiveTransform;
                PushLayer(layer, painter, offset, childPaintBounds: MatrixutilsDefaultClass.MatrixUtils.InverseTransformRect(effectiveTransform, EstimatedBounds));
                return layer;
            }
            else
            {
                ;
                Canvas.Save();
                Canvas.Transform(effectiveTransform.Storage);
                painter(this, offset);
                Canvas.Restore();
                return null;
            }

        }




        /// <Summary>
        /// Blend further painting with an alpha value.
        ///
        /// The `offset` argument indicates an offset to apply to all the children
        /// (the rendering created by `painter`).
        ///
        /// The `alpha` argument is the alpha value to use when blending the painting
        /// done by `painter`. An alpha value of 0 means the painting is fully
        /// transparent and an alpha value of 255 means the painting is fully opaque.
        ///
        /// The `painter` callback will be called while the `alpha` is applied. It
        /// is called synchronously during the call to [pushOpacity].
        ///
        /// {@macro flutter.rendering.object.oldLayer}
        ///
        /// A [RenderObject] that uses this function is very likely to require its
        /// [RenderObject.alwaysNeedsCompositing] property to return true. That informs
        /// ancestor render objects that this render object will include a composited
        /// layer, which, for example, causes them to use composited clips.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Layer.OpacityLayer PushOpacity(FlutterBinding.UI.Offset offset, int alpha, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterSDK.Rendering.Layer.OpacityLayer oldLayer = default(FlutterSDK.Rendering.Layer.OpacityLayer))
        {
            OpacityLayer layer = oldLayer ?? new OpacityLayer();
            ..Alpha = alpha..Offset = offset;
            PushLayer(layer, painter, Dart: uiDefaultClass.Offset.Zero);
            return layer;
        }




        #endregion
    }


    /// <Summary>
    /// An abstract set of layout constraints.
    ///
    /// Concrete layout models (such as box) will create concrete subclasses to
    /// communicate layout constraints between parents and children.
    ///
    /// ## Writing a Constraints subclass
    ///
    /// When creating a new [RenderObject] subclass with a new layout protocol, one
    /// will usually need to create a new [Constraints] subclass to express the
    /// input to the layout algorithms.
    ///
    /// A [Constraints] subclass should be immutable (all fields final). There are
    /// several members to implement, in addition to whatever fields, constructors,
    /// and helper methods one may find useful for a particular layout protocol:
    ///
    /// * The [isTight] getter, which should return true if the object represents a
    ///   case where the [RenderObject] class has no choice for how to lay itself
    ///   out. For example, [BoxConstraints] returns true for [isTight] when both
    ///   the minimum and maximum widths and the minimum and maximum heights are
    ///   equal.
    ///
    /// * The [isNormalized] getter, which should return true if the object
    ///   represents its data in its canonical form. Sometimes, it is possible for
    ///   fields to be redundant with each other, such that several different
    ///   representations have the same implications. For example, a
    ///   [BoxConstraints] instance with its minimum width greater than its maximum
    ///   width is equivalent to one where the maximum width is set to that minimum
    ///   width (`2<w<1` is equivalent to `2<w<2`, since minimum constraints have
    ///   priority). This getter is used by the default implementation of
    ///   [debugAssertIsValid].
    ///
    /// * The [debugAssertIsValid] method, which should assert if there's anything
    ///   wrong with the constraints object. (We use this approach rather than
    ///   asserting in constructors so that our constructors can be `const` and so
    ///   that it is possible to create invalid constraints temporarily while
    ///   building valid ones.) See the implementation of
    ///   [BoxConstraints.debugAssertIsValid] for an example of the detailed checks
    ///   that can be made.
    ///
    /// * The [==] operator and the [hashCode] getter, so that constraints can be
    ///   compared for equality. If a render object is given constraints that are
    ///   equal, then the rendering library will avoid laying the object out again
    ///   if it is not dirty.
    ///
    /// * The [toString] method, which should describe the constraints so that they
    ///   appear in a usefully readable form in the output of [debugDumpRenderTree].
    /// </Summary>
    public class Constraints
    {
        #region constructors
        public Constraints()
        {

        }
        #endregion

        #region fields
        public virtual bool IsTight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNormalized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Asserts that the constraints are valid.
        ///
        /// This might involve checks more detailed than [isNormalized].
        ///
        /// For example, the [BoxConstraints] subclass verifies that the constraints
        /// are not [double.nan].
        ///
        /// If the `isAppliedConstraint` argument is true, then even stricter rules
        /// are enforced. This argument is set to true when checking constraints that
        /// are about to be applied to a [RenderObject] during layout, as opposed to
        /// constraints that may be further affected by other constraints. For
        /// example, the asserts for verifying the validity of
        /// [RenderConstrainedBox.additionalConstraints] do not set this argument, but
        /// the asserts for verifying the argument passed to the [RenderObject.layout]
        /// method do.
        ///
        /// The `informationCollector` argument takes an optional callback which is
        /// called when an exception is to be thrown. The collected information is
        /// then included in the message after the error line.
        ///
        /// Returns the same as [isNormalized] if asserts are disabled.
        /// </Summary>
        public virtual bool DebugAssertIsValid(bool isAppliedConstraint = false, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
        {

            return IsNormalized;
        }



        #endregion
    }


    /// <Summary>
    /// A reference to the semantics tree.
    ///
    /// The framework maintains the semantics tree (used for accessibility and
    /// indexing) only when there is at least one client holding an open
    /// [SemanticsHandle].
    ///
    /// The framework notifies the client that it has updated the semantics tree by
    /// calling the [listener] callback. When the client no longer needs the
    /// semantics tree, the client can call [dispose] on the [SemanticsHandle],
    /// which stops these callbacks and closes the [SemanticsHandle]. When all the
    /// outstanding [SemanticsHandle] objects are closed, the framework stops
    /// updating the semantics tree.
    ///
    /// To obtain a [SemanticsHandle], call [PipelineOwner.ensureSemantics] on the
    /// [PipelineOwner] for the render tree from which you wish to read semantics.
    /// You can obtain the [PipelineOwner] using the [RenderObject.owner] property.
    /// </Summary>
    public class SemanticsHandle
    {
        #region constructors
        internal SemanticsHandle(FlutterSDK.Rendering.@object.PipelineOwner _owner, VoidCallback listener)
        : base()
        {
            this._Owner = _owner;
            this.Listener = listener;
            if (Listener != null) _Owner.SemanticsOwner.AddListener(Listener);
        }


        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.@object.PipelineOwner _Owner { get; set; }
        public virtual VoidCallback Listener { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Closes the semantics handle and stops calling [listener] when the
        /// semantics updates.
        ///
        /// When all the outstanding [SemanticsHandle] objects for a given
        /// [PipelineOwner] are closed, the [PipelineOwner] will stop updating the
        /// semantics tree.
        /// </Summary>
        public virtual void Dispose()
        {

            if (_Owner != null)
            {
                if (Listener != null) _Owner.SemanticsOwner.RemoveListener(Listener);
                _Owner._DidDisposeSemanticsHandle();
                _Owner = null;
            }

        }



        #endregion
    }


    /// <Summary>
    /// The pipeline owner manages the rendering pipeline.
    ///
    /// The pipeline owner provides an interface for driving the rendering pipeline
    /// and stores the state about which render objects have requested to be visited
    /// in each stage of the pipeline. To flush the pipeline, call the following
    /// functions in order:
    ///
    /// 1. [flushLayout] updates any render objects that need to compute their
    ///    layout. During this phase, the size and position of each render
    ///    object is calculated. Render objects might dirty their painting or
    ///    compositing state during this phase.
    /// 2. [flushCompositingBits] updates any render objects that have dirty
    ///    compositing bits. During this phase, each render object learns whether
    ///    any of its children require compositing. This information is used during
    ///    the painting phase when selecting how to implement visual effects such as
    ///    clipping. If a render object has a composited child, its needs to use a
    ///    [Layer] to create the clip in order for the clip to apply to the
    ///    composited child (which will be painted into its own [Layer]).
    /// 3. [flushPaint] visits any render objects that need to paint. During this
    ///    phase, render objects get a chance to record painting commands into
    ///    [PictureLayer]s and construct other composited [Layer]s.
    /// 4. Finally, if semantics are enabled, [flushSemantics] will compile the
    ///    semantics for the render objects. This semantic information is used by
    ///    assistive technology to improve the accessibility of the render tree.
    ///
    /// The [RendererBinding] holds the pipeline owner for the render objects that
    /// are visible on screen. You can create other pipeline owners to manage
    /// off-screen objects, which can flush their pipelines independently of the
    /// on-screen render objects.
    /// </Summary>
    public class PipelineOwner
    {
        #region constructors
        public PipelineOwner(VoidCallback onNeedVisualUpdate = default(VoidCallback), VoidCallback onSemanticsOwnerCreated = default(VoidCallback), VoidCallback onSemanticsOwnerDisposed = default(VoidCallback))
        {
            this.OnNeedVisualUpdate = onNeedVisualUpdate;
            this.OnSemanticsOwnerCreated = onSemanticsOwnerCreated;
            this.OnSemanticsOwnerDisposed = onSemanticsOwnerDisposed;
        }
        #endregion

        #region fields
        public virtual VoidCallback OnNeedVisualUpdate { get; set; }
        public virtual VoidCallback OnSemanticsOwnerCreated { get; set; }
        public virtual VoidCallback OnSemanticsOwnerDisposed { get; set; }
        internal virtual FlutterSDK.Foundation.Node.AbstractNode _RootNode { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingLayout { get; set; }
        internal virtual bool _DebugDoingLayout { get; set; }
        internal virtual bool _DebugAllowMutationsToDirtySubtrees { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingCompositingBitsUpdate { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingPaint { get; set; }
        internal virtual bool _DebugDoingPaint { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsOwner _SemanticsOwner { get; set; }
        internal virtual int _OutstandingSemanticsHandles { get; set; }
        internal virtual bool _DebugDoingSemantics { get; set; }
        internal virtual HashSet<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingSemantics { get; set; }
        public virtual FlutterSDK.Foundation.Node.AbstractNode RootNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingPaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsOwner SemanticsOwner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int DebugOutstandingSemanticsHandles { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Calls [onNeedVisualUpdate] if [onNeedVisualUpdate] is not null.
        ///
        /// Used to notify the pipeline owner that an associated render object wishes
        /// to update its visual appearance.
        /// </Summary>
        public virtual void RequestVisualUpdate()
        {
            if (OnNeedVisualUpdate != null) OnNeedVisualUpdate();
        }




        /// <Summary>
        /// Update the layout information for all dirty render objects.
        ///
        /// This function is one of the core stages of the rendering pipeline. Layout
        /// information is cleaned prior to painting so that render objects will
        /// appear on screen in their up-to-date locations.
        ///
        /// See [RendererBinding] for an example of how this function is used.
        /// </Summary>
        public virtual void FlushLayout()
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.StartSync("Layout", arguments: DebugDefaultClass.TimelineWhitelistArguments);
            }


            try
            {
                while (_NodesNeedingLayout.IsNotEmpty)
                {
                    List<RenderObject> dirtyNodes = _NodesNeedingLayout;
                    _NodesNeedingLayout = new List<RenderObject>() { };
                    foreach (RenderObject node in ;
                    dirtyNodes.Sort((RenderObject a, RenderObject b) => =>a.Depth - b.Depth)){
                        if (node._NeedsLayout && node.Owner == this) node._LayoutWithoutResize();
                    }

                }

            }
            finally
            {

                if (!ConstantsDefaultClass.KReleaseMode)
                {
                Dart: developerDefaultClass.Timeline.FinishSync();
                }

            }

        }




        private void _EnableMutationsToDirtySubtrees(VoidCallback callback)
        {

            bool oldState = default(bool);

            try
            {
                callback();
            }
            finally
            {

            }

        }




        /// <Summary>
        /// Updates the [RenderObject.needsCompositing] bits.
        ///
        /// Called as part of the rendering pipeline after [flushLayout] and before
        /// [flushPaint].
        /// </Summary>
        public virtual void FlushCompositingBits()
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.StartSync("Compositing bits");
            }

            _NodesNeedingCompositingBitsUpdate.Sort((RenderObject a, RenderObject b) => =>a.Depth - b.Depth);
            foreach (RenderObject node in _NodesNeedingCompositingBitsUpdate)
            {
                if (node._NeedsCompositingBitsUpdate && node.Owner == this) node._UpdateCompositingBits();
            }

            _NodesNeedingCompositingBitsUpdate.Clear();
            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.FinishSync();
            }

        }




        /// <Summary>
        /// Update the display lists for all render objects.
        ///
        /// This function is one of the core stages of the rendering pipeline.
        /// Painting occurs after layout and before the scene is recomposited so that
        /// scene is composited with up-to-date display lists for every render object.
        ///
        /// See [RendererBinding] for an example of how this function is used.
        /// </Summary>
        public virtual void FlushPaint()
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.StartSync("Paint", arguments: DebugDefaultClass.TimelineWhitelistArguments);
            }


            try
            {
                List<RenderObject> dirtyNodes = _NodesNeedingPaint;
                _NodesNeedingPaint = new List<RenderObject>() { };
                foreach (RenderObject node in ;
                dirtyNodes.Sort((RenderObject a, RenderObject b) => =>b.Depth - a.Depth)){

                    if (node._NeedsPaint && node.Owner == this)
                    {
                        if (node._Layer.Attached)
                        {
                            ObjectDefaultClass.PaintingContext.RepaintCompositedChild(node);
                        }
                        else
                        {
                            node._SkippedPaintingOnLayer();
                        }

                    }

                }


            }
            finally
            {

                if (!ConstantsDefaultClass.KReleaseMode)
                {
                Dart: developerDefaultClass.Timeline.FinishSync();
                }

            }

        }




        /// <Summary>
        /// Opens a [SemanticsHandle] and calls [listener] whenever the semantics tree
        /// updates.
        ///
        /// The [PipelineOwner] updates the semantics tree only when there are clients
        /// that wish to use the semantics tree. These clients express their interest
        /// by holding [SemanticsHandle] objects that notify them whenever the
        /// semantics tree updates.
        ///
        /// Clients can close their [SemanticsHandle] by calling
        /// [SemanticsHandle.dispose]. Once all the outstanding [SemanticsHandle]
        /// objects for a given [PipelineOwner] are closed, the [PipelineOwner] stops
        /// maintaining the semantics tree.
        /// </Summary>
        public virtual FlutterSDK.Rendering.@object.SemanticsHandle EnsureSemantics(VoidCallback listener = default(VoidCallback))
        {
            _OutstandingSemanticsHandles += 1;
            if (_OutstandingSemanticsHandles == 1)
            {

                _SemanticsOwner = new SemanticsOwner();
                if (OnSemanticsOwnerCreated != null) OnSemanticsOwnerCreated();
            }

            return SemanticsHandle._(this, listener);
        }




        private void _DidDisposeSemanticsHandle()
        {

            _OutstandingSemanticsHandles -= 1;
            if (_OutstandingSemanticsHandles == 0)
            {
                _SemanticsOwner.Dispose();
                _SemanticsOwner = null;
                if (OnSemanticsOwnerDisposed != null) OnSemanticsOwnerDisposed();
            }

        }




        /// <Summary>
        /// Update the semantics for render objects marked as needing a semantics
        /// update.
        ///
        /// Initially, only the root node, as scheduled by
        /// [RenderObject.scheduleInitialSemantics], needs a semantics update.
        ///
        /// This function is one of the core stages of the rendering pipeline. The
        /// semantics are compiled after painting and only after
        /// [RenderObject.scheduleInitialSemantics] has been called.
        ///
        /// See [RendererBinding] for an example of how this function is used.
        /// </Summary>
        public virtual void FlushSemantics()
        {
            if (_SemanticsOwner == null) return;
            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.StartSync("Semantics");
            }



            try
            {
                List<RenderObject> nodesToProcess = _NodesNeedingSemantics.ToList();
                _NodesNeedingSemantics.ToList().Sort((RenderObject a, RenderObject b) => =>a.Depth - b.Depth);
                _NodesNeedingSemantics.Clear();
                foreach (RenderObject node in nodesToProcess)
                {
                    if (node._NeedsSemanticsUpdate && node.Owner == this) node._UpdateSemantics();
                }

                _SemanticsOwner.SendSemanticsUpdate();
            }
            finally
            {


                if (!ConstantsDefaultClass.KReleaseMode)
                {
                Dart: developerDefaultClass.Timeline.FinishSync();
                }

            }

        }



        #endregion
    }


    /// <Summary>
    /// An object in the render tree.
    ///
    /// The [RenderObject] class hierarchy is the core of the rendering
    /// library's reason for being.
    ///
    /// [RenderObject]s have a [parent], and have a slot called [parentData] in
    /// which the parent [RenderObject] can store child-specific data, for example,
    /// the child position. The [RenderObject] class also implements the basic
    /// layout and paint protocols.
    ///
    /// The [RenderObject] class, however, does not define a child model (e.g.
    /// whether a node has zero, one, or more children). It also doesn't define a
    /// coordinate system (e.g. whether children are positioned in Cartesian
    /// coordinates, in polar coordinates, etc) or a specific layout protocol (e.g.
    /// whether the layout is width-in-height-out, or constraint-in-size-out, or
    /// whether the parent sets the size and position of the child before or after
    /// the child lays out, etc; or indeed whether the children are allowed to read
    /// their parent's [parentData] slot).
    ///
    /// The [RenderBox] subclass introduces the opinion that the layout
    /// system uses Cartesian coordinates.
    ///
    /// ## Writing a RenderObject subclass
    ///
    /// In most cases, subclassing [RenderObject] itself is overkill, and
    /// [RenderBox] would be a better starting point. However, if a render object
    /// doesn't want to use a Cartesian coordinate system, then it should indeed
    /// inherit from [RenderObject] directly. This allows it to define its own
    /// layout protocol by using a new subclass of [Constraints] rather than using
    /// [BoxConstraints], and by potentially using an entirely new set of objects
    /// and values to represent the result of the output rather than just a [Size].
    /// This increased flexibility comes at the cost of not being able to rely on
    /// the features of [RenderBox]. For example, [RenderBox] implements an
    /// intrinsic sizing protocol that allows you to measure a child without fully
    /// laying it out, in such a way that if that child changes size, the parent
    /// will be laid out again (to take into account the new dimensions of the
    /// child). This is a subtle and bug-prone feature to get right.
    ///
    /// Most aspects of writing a [RenderBox] apply to writing a [RenderObject] as
    /// well, and therefore the discussion at [RenderBox] is recommended background
    /// reading. The main differences are around layout and hit testing, since those
    /// are the aspects that [RenderBox] primarily specializes.
    ///
    /// ### Layout
    ///
    /// A layout protocol begins with a subclass of [Constraints]. See the
    /// discussion at [Constraints] for more information on how to write a
    /// [Constraints] subclass.
    ///
    /// The [performLayout] method should take the [constraints], and apply them.
    /// The output of the layout algorithm is fields set on the object that describe
    /// the geometry of the object for the purposes of the parent's layout. For
    /// example, with [RenderBox] the output is the [RenderBox.size] field. This
    /// output should only be read by the parent if the parent specified
    /// `parentUsesSize` as true when calling [layout] on the child.
    ///
    /// Anytime anything changes on a render object that would affect the layout of
    /// that object, it should call [markNeedsLayout].
    ///
    /// ### Hit Testing
    ///
    /// Hit testing is even more open-ended than layout. There is no method to
    /// override, you are expected to provide one.
    ///
    /// The general behavior of your hit-testing method should be similar to the
    /// behavior described for [RenderBox]. The main difference is that the input
    /// need not be an [Offset]. You are also allowed to use a different subclass of
    /// [HitTestEntry] when adding entries to the [HitTestResult]. When the
    /// [handleEvent] method is called, the same object that was added to the
    /// [HitTestResult] will be passed in, so it can be used to track information
    /// like the precise coordinate of the hit, in whatever coordinate system is
    /// used by the new layout protocol.
    ///
    /// ### Adapting from one protocol to another
    ///
    /// In general, the root of a Flutter render object tree is a [RenderView]. This
    /// object has a single child, which must be a [RenderBox]. Thus, if you want to
    /// have a custom [RenderObject] subclass in the render tree, you have two
    /// choices: you either need to replace the [RenderView] itself, or you need to
    /// have a [RenderBox] that has your class as its child. (The latter is the much
    /// more common case.)
    ///
    /// This [RenderBox] subclass converts from the box protocol to the protocol of
    /// your class.
    ///
    /// In particular, this means that for hit testing it overrides
    /// [RenderBox.hitTest], and calls whatever method you have in your class for
    /// hit testing.
    ///
    /// Similarly, it overrides [performLayout] to create a [Constraints] object
    /// appropriate for your class and passes that to the child's [layout] method.
    ///
    /// ### Layout interactions between render objects
    ///
    /// In general, the layout of a render object should only depend on the output of
    /// its child's layout, and then only if `parentUsesSize` is set to true in the
    /// [layout] call. Furthermore, if it is set to true, the parent must call the
    /// child's [layout] if the child is to be rendered, because otherwise the
    /// parent will not be notified when the child changes its layout outputs.
    ///
    /// It is possible to set up render object protocols that transfer additional
    /// information. For example, in the [RenderBox] protocol you can query your
    /// children's intrinsic dimensions and baseline geometry. However, if this is
    /// done then it is imperative that the child call [markNeedsLayout] on the
    /// parent any time that additional information changes, if the parent used it
    /// in the last layout phase. For an example of how to implement this, see the
    /// [RenderBox.markNeedsLayout] method. It overrides
    /// [RenderObject.markNeedsLayout] so that if a parent has queried the intrinsic
    /// or baseline information, it gets marked dirty whenever the child's geometry
    /// changes.
    /// </Summary>
    public class RenderObject : FlutterSDK.Foundation.Node.AbstractNode, IHitTestTarget, IDiagnosticableTreeMixin
    {
        #region constructors
        public RenderObject()
        {

            _NeedsCompositing = IsRepaintBoundary || AlwaysNeedsCompositing;
        }


        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.@object.ParentData ParentData { get; set; }
        public virtual object DebugCreator { get; set; }
        internal virtual bool _DebugDoingThisResize { get; set; }
        internal virtual bool _DebugDoingThisLayout { get; set; }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _DebugActiveLayout { get; set; }
        internal virtual bool _DebugCanParentUseSize { get; set; }
        internal virtual bool _DebugMutationsLocked { get; set; }
        internal virtual bool _NeedsLayout { get; set; }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _RelayoutBoundary { get; set; }
        internal virtual bool _DoingThisLayoutWithCallback { get; set; }
        internal virtual FlutterSDK.Rendering.@object.Constraints _Constraints { get; set; }
        public virtual bool DebugCheckingIntrinsics { get; set; }
        internal virtual bool _DebugDoingThisPaint { get; set; }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _DebugActivePaint { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.ContainerLayer _Layer { get; set; }
        internal virtual bool _NeedsCompositingBitsUpdate { get; set; }
        internal virtual bool _NeedsCompositing { get; set; }
        internal virtual bool _NeedsPaint { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _CachedSemanticsConfiguration { get; set; }
        internal virtual bool _NeedsSemanticsUpdate { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsNode _Semantics { get; set; }
        public virtual bool DebugDoingThisResize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingThisLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject DebugActiveLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugCanParentUseSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DebugCanPerformMutations { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.PipelineOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugNeedsLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.Constraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingThisPaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject DebugActivePaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.ContainerLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.ContainerLayer DebugLayer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool NeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugNeedsPaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect PaintBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _SemanticsConfiguration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect SemanticBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsNode DebugSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Cause the entire subtree rooted at the given [RenderObject] to be marked
        /// dirty for layout, paint, etc, so that the effects of a hot reload can be
        /// seen, or so that the effect of changing a global debug flag (such as
        /// [debugPaintSizeEnabled]) can be applied.
        ///
        /// This is called by the [RendererBinding] in response to the
        /// `ext.flutter.reassemble` hook, which is used by development tools when the
        /// application code has changed, to cause the widget tree to pick up any
        /// changed implementations.
        ///
        /// This is expensive and should not be called except during development.
        ///
        /// See also:
        ///
        ///  * [BindingBase.reassembleApplication]
        /// </Summary>
        public virtual void Reassemble()
        {
            MarkNeedsLayout();
            MarkNeedsCompositingBitsUpdate();
            MarkNeedsPaint();
            MarkNeedsSemanticsUpdate();
            VisitChildren((RenderObject child) =>
            {
                child.Reassemble();
            }
            );
        }




        /// <Summary>
        /// Override to setup parent data correctly for your children.
        ///
        /// You can call this function to set up the parent data for child before the
        /// child is added to the parent's child list.
        /// </Summary>
        public virtual void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {

            if (!(child.ParentData is ParentData)) child.ParentData = new ParentData();
        }




        /// <Summary>
        /// Called by subclasses when they decide a render object is a child.
        ///
        /// Only for use by subclasses when changing their child lists. Calling this
        /// in other cases will lead to an inconsistent tree and probably cause crashes.
        /// </Summary>
        public new void AdoptChild(FlutterSDK.Rendering.@object.RenderObject child)
        {


            SetupParentData(child);
            MarkNeedsLayout();
            MarkNeedsCompositingBitsUpdate();
            MarkNeedsSemanticsUpdate();
            base.AdoptChild(child);
        }


        public new void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child)
        {


            SetupParentData(child);
            MarkNeedsLayout();
            MarkNeedsCompositingBitsUpdate();
            MarkNeedsSemanticsUpdate();
            base.AdoptChild(child);
        }




        /// <Summary>
        /// Called by subclasses when they decide a render object is no longer a child.
        ///
        /// Only for use by subclasses when changing their child lists. Calling this
        /// in other cases will lead to an inconsistent tree and probably cause crashes.
        /// </Summary>
        public new void DropChild(FlutterSDK.Rendering.@object.RenderObject child)
        {



            child._CleanRelayoutBoundary();
            child.ParentData.Detach();
            child.ParentData = null;
            base.DropChild(child);
            MarkNeedsLayout();
            MarkNeedsCompositingBitsUpdate();
            MarkNeedsSemanticsUpdate();
        }


        public new void DropChild(FlutterSDK.Foundation.Node.AbstractNode child)
        {



            child._CleanRelayoutBoundary();
            child.ParentData.Detach();
            child.ParentData = null;
            base.DropChild(child);
            MarkNeedsLayout();
            MarkNeedsCompositingBitsUpdate();
            MarkNeedsSemanticsUpdate();
        }




        /// <Summary>
        /// Calls visitor for each immediate child of this render object.
        ///
        /// Override in subclasses with children and call the visitor for each child.
        /// </Summary>
        public virtual void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
        }




        private void _DebugReportException(string method, object exception, StackTrace stack)
        {
            AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForRendering(exception: exception, stack: stack, library: "rendering library", context: new ErrorDescription($"'during {method}()'"), renderObject: this, informationCollector: () => sync *{
if (DebugCreator != null) yield new DiagnosticsDebugCreator(DebugCreator);
            yield DescribeForError("The following RenderObject was being processed when the exception was fired");
            yield DescribeForError("RenderObject", style: DiagnosticsTreeStyle.TruncateChildren);
        }
));
}




    public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
    {
        base.Attach(owner);
        if (_NeedsLayout && _RelayoutBoundary != null)
        {
            _NeedsLayout = false;
            MarkNeedsLayout();
        }

        if (_NeedsCompositingBitsUpdate)
        {
            _NeedsCompositingBitsUpdate = false;
            MarkNeedsCompositingBitsUpdate();
        }

        if (_NeedsPaint && _Layer != null)
        {
            _NeedsPaint = false;
            MarkNeedsPaint();
        }

        if (_NeedsSemanticsUpdate && _SemanticsConfiguration.IsSemanticBoundary)
        {
            _NeedsSemanticsUpdate = false;
            MarkNeedsSemanticsUpdate();
        }

    }


    public new void Attach(@Object owner)
    {
        base.Attach(owner);
        if (_NeedsLayout && _RelayoutBoundary != null)
        {
            _NeedsLayout = false;
            MarkNeedsLayout();
        }

        if (_NeedsCompositingBitsUpdate)
        {
            _NeedsCompositingBitsUpdate = false;
            MarkNeedsCompositingBitsUpdate();
        }

        if (_NeedsPaint && _Layer != null)
        {
            _NeedsPaint = false;
            MarkNeedsPaint();
        }

        if (_NeedsSemanticsUpdate && _SemanticsConfiguration.IsSemanticBoundary)
        {
            _NeedsSemanticsUpdate = false;
            MarkNeedsSemanticsUpdate();
        }

    }




    /// <Summary>
    /// Verify that the object's constraints are being met. Override
    /// this function in a subclass to verify that your state matches
    /// the constraints object. This function is only called in checked
    /// mode and only when needsLayout is false. If the constraints are
    /// not met, it should assert or throw an exception.
    /// </Summary>
    public virtual void DebugAssertDoesMeetConstraints()
    {
    }


    private bool _DebugSubtreeRelayoutRootAlreadyMarkedNeedsLayout()
    {
        if (_RelayoutBoundary == null) return true;
        RenderObject node = this;
        while (node != _RelayoutBoundary)
        {


            node = node.Parent as RenderObject;
            if ((!node._NeedsLayout) && (!node._DebugDoingThisLayout)) return false;
        }


        return true;
    }




    /// <Summary>
    /// Mark this render object's layout information as dirty, and either register
    /// this object with its [PipelineOwner], or defer to the parent, depending on
    /// whether this object is a relayout boundary or not respectively.
    ///
    /// ## Background
    ///
    /// Rather than eagerly updating layout information in response to writes into
    /// a render object, we instead mark the layout information as dirty, which
    /// schedules a visual update. As part of the visual update, the rendering
    /// pipeline updates the render object's layout information.
    ///
    /// This mechanism batches the layout work so that multiple sequential writes
    /// are coalesced, removing redundant computation.
    ///
    /// If a render object's parent indicates that it uses the size of one of its
    /// render object children when computing its layout information, this
    /// function, when called for the child, will also mark the parent as needing
    /// layout. In that case, since both the parent and the child need to have
    /// their layout recomputed, the pipeline owner is only notified about the
    /// parent; when the parent is laid out, it will call the child's [layout]
    /// method and thus the child will be laid out as well.
    ///
    /// Once [markNeedsLayout] has been called on a render object,
    /// [debugNeedsLayout] returns true for that render object until just after
    /// the pipeline owner has called [layout] on the render object.
    ///
    /// ## Special cases
    ///
    /// Some subclasses of [RenderObject], notably [RenderBox], have other
    /// situations in which the parent needs to be notified if the child is
    /// dirtied (e.g., if the child's intrinsic dimensions or baseline changes).
    /// Such subclasses override markNeedsLayout and either call
    /// `super.markNeedsLayout()`, in the normal case, or call
    /// [markParentNeedsLayout], in the case where the parent needs to be laid out
    /// as well as the child.
    ///
    /// If [sizedByParent] has changed, calls
    /// [markNeedsLayoutForSizedByParentChange] instead of [markNeedsLayout].
    /// </Summary>
    public virtual void MarkNeedsLayout()
    {

        if (_NeedsLayout)
        {

            return;
        }


        if (_RelayoutBoundary != this)
        {
            MarkParentNeedsLayout();
        }
        else
        {
            _NeedsLayout = true;
            if (Owner != null)
            {

                Owner._NodesNeedingLayout.Add(this);
                Owner.RequestVisualUpdate();
            }

        }

    }




    /// <Summary>
    /// Mark this render object's layout information as dirty, and then defer to
    /// the parent.
    ///
    /// This function should only be called from [markNeedsLayout] or
    /// [markNeedsLayoutForSizedByParentChange] implementations of subclasses that
    /// introduce more reasons for deferring the handling of dirty layout to the
    /// parent. See [markNeedsLayout] for details.
    ///
    /// Only call this if [parent] is not null.
    /// </Summary>
    public virtual void MarkParentNeedsLayout()
    {
        _NeedsLayout = true;
        RenderObject parent = this.Parent as RenderObject;
        if (!_DoingThisLayoutWithCallback)
        {
            parent.MarkNeedsLayout();
        }
        else
        {

        }


    }




    /// <Summary>
    /// Mark this render object's layout information as dirty (like
    /// [markNeedsLayout]), and additionally also handle any necessary work to
    /// handle the case where [sizedByParent] has changed value.
    ///
    /// This should be called whenever [sizedByParent] might have changed.
    ///
    /// Only call this if [parent] is not null.
    /// </Summary>
    public virtual void MarkNeedsLayoutForSizedByParentChange()
    {
        MarkNeedsLayout();
        MarkParentNeedsLayout();
    }




    private void _CleanRelayoutBoundary()
    {
        if (_RelayoutBoundary != this)
        {
            _RelayoutBoundary = null;
            _NeedsLayout = true;
            VisitChildren(_CleanChildRelayoutBoundary);
        }

    }




    private void _CleanChildRelayoutBoundary(FlutterSDK.Rendering.@object.RenderObject child)
    {
        child._CleanRelayoutBoundary();
    }




    /// <Summary>
    /// Bootstrap the rendering pipeline by scheduling the very first layout.
    ///
    /// Requires this render object to be attached and that this render object
    /// is the root of the render tree.
    ///
    /// See [RenderView] for an example of how this function is used.
    /// </Summary>
    public virtual void ScheduleInitialLayout()
    {




        _RelayoutBoundary = this;

        Owner._NodesNeedingLayout.Add(this);
    }




    private void _LayoutWithoutResize()
    {

        RenderObject debugPreviousActiveLayout = default(RenderObject);




        try
        {
            PerformLayout();
            MarkNeedsSemanticsUpdate();
        }
        catch (e,stack){
            _DebugReportException("performLayout", e, stack);
        }


        _NeedsLayout = false;
        MarkNeedsPaint();
        }




/// <Summary>
/// Compute the layout for this render object.
///
/// This method is the main entry point for parents to ask their children to
/// update their layout information. The parent passes a constraints object,
/// which informs the child as to which layouts are permissible. The child is
/// required to obey the given constraints.
///
/// If the parent reads information computed during the child's layout, the
/// parent must pass true for `parentUsesSize`. In that case, the parent will
/// be marked as needing layout whenever the child is marked as needing layout
/// because the parent's layout information depends on the child's layout
/// information. If the parent uses the default value (false) for
/// `parentUsesSize`, the child can change its layout information (subject to
/// the given constraints) without informing the parent.
///
/// Subclasses should not override [layout] directly. Instead, they should
/// override [performResize] and/or [performLayout]. The [layout] method
/// delegates the actual work to [performResize] and [performLayout].
///
/// The parent's [performLayout] method should call the [layout] of all its
/// children unconditionally. It is the [layout] method's responsibility (as
/// implemented here) to return early if the child does not need to do any
/// work to update its layout information.
/// </Summary>
    public virtual void Layout(FlutterSDK.Rendering.@object.Constraints constraints, bool parentUsesSize = false)
    {




        RenderObject relayoutBoundary = default(RenderObject);
        if (!parentUsesSize || SizedByParent || constraints.IsTight || !(Parent is RenderObject))
        {
            relayoutBoundary = this;
        }
        else
        {
            relayoutBoundary = (Parent as RenderObject)._RelayoutBoundary;
        }


        if (!_NeedsLayout && constraints == _Constraints && relayoutBoundary == _RelayoutBoundary)
        {

            return;
        }

        _Constraints = constraints;
        if (_RelayoutBoundary != null && relayoutBoundary != _RelayoutBoundary)
        {
            VisitChildren(_CleanChildRelayoutBoundary);
        }

        _RelayoutBoundary = relayoutBoundary;



        if (SizedByParent)
        {

            try
            {
                PerformResize();

            }
            catch (e,stack){
                _DebugReportException("performResize", e, stack);
            }


            }

            RenderObject debugPreviousActiveLayout = default(RenderObject);

            try
            {
                PerformLayout();
                MarkNeedsSemanticsUpdate();

            }
            catch (e,stack){
                _DebugReportException("performLayout", e, stack);
            }


            _NeedsLayout = false;
            MarkNeedsPaint();
            }




/// <Summary>
/// If a subclass has a "size" (the state controlled by `parentUsesSize`,
/// whatever it is in the subclass, e.g. the actual `size` property of
/// [RenderBox]), and the subclass verifies that in checked mode this "size"
/// property isn't used when [debugCanParentUseSize] isn't set, then that
/// subclass should override [debugResetSize] to reapply the current values of
/// [debugCanParentUseSize] to that state.
/// </Summary>
    public virtual void DebugResetSize()
    {
    }




    /// <Summary>
    /// Updates the render objects size using only the constraints.
    ///
    /// Do not call this function directly: call [layout] instead. This function
    /// is called by [layout] when there is actually work to be done by this
    /// render object during layout. The layout constraints provided by your
    /// parent are available via the [constraints] getter.
    ///
    /// Subclasses that set [sizedByParent] to true should override this method
    /// to compute their size.
    ///
    /// This function is called only if [sizedByParent] is true.
    /// </Summary>
    public virtual void PerformResize()
    {
    }


    /// <Summary>
    /// Do the work of computing the layout for this render object.
    ///
    /// Do not call this function directly: call [layout] instead. This function
    /// is called by [layout] when there is actually work to be done by this
    /// render object during layout. The layout constraints provided by your
    /// parent are available via the [constraints] getter.
    ///
    /// If [sizedByParent] is true, then this function should not actually change
    /// the dimensions of this render object. Instead, that work should be done by
    /// [performResize]. If [sizedByParent] is false, then this function should
    /// both change the dimensions of this render object and instruct its children
    /// to layout.
    ///
    /// In implementing this function, you must call [layout] on each of your
    /// children, passing true for parentUsesSize if your layout information is
    /// dependent on your child's layout information. Passing true for
    /// parentUsesSize ensures that this render object will undergo layout if the
    /// child undergoes layout. Otherwise, the child can change its layout
    /// information without informing this render object.
    /// </Summary>
    public virtual void PerformLayout()
    {
    }


    /// <Summary>
    /// Allows mutations to be made to this object's child list (and any
    /// descendants) as well as to any other dirty nodes in the render tree owned
    /// by the same [PipelineOwner] as this object. The `callback` argument is
    /// invoked synchronously, and the mutations are allowed only during that
    /// callback's execution.
    ///
    /// This exists to allow child lists to be built on-demand during layout (e.g.
    /// based on the object's size), and to enable nodes to be moved around the
    /// tree as this happens (e.g. to handle [GlobalKey] reparenting), while still
    /// ensuring that any particular node is only laid out once per frame.
    ///
    /// Calling this function disables a number of assertions that are intended to
    /// catch likely bugs. As such, using this function is generally discouraged.
    ///
    /// This function can only be called during layout.
    /// </Summary>
    public virtual void InvokeLayoutCallback<T>(FlutterSDK.Rendering.@object.LayoutCallback<T> callback)
    {



        _DoingThisLayoutWithCallback = true;
        try
        {
            Owner._EnableMutationsToDirtySubtrees(() =>
            {
                callback(Constraints as T);
            }
            );
        }
        finally
        {
            _DoingThisLayoutWithCallback = false;
        }

    }




    /// <Summary>
    /// Rotate this render object (not yet implemented).
    /// </Summary>
    public virtual void Rotate(int oldAngle = default(int), int newAngle = default(int), TimeSpan time = default(TimeSpan))
    {
    }




    /// <Summary>
    /// Called, in checked mode, if [isRepaintBoundary] is true, when either the
    /// this render object or its parent attempt to paint.
    ///
    /// This can be used to record metrics about whether the node should actually
    /// be a repaint boundary.
    /// </Summary>
    public virtual void DebugRegisterRepaintBoundaryPaint(bool includedParent = true, bool includedChild = false)
    {
    }




    /// <Summary>
    /// Mark the compositing state for this render object as dirty.
    ///
    /// This is called to indicate that the value for [needsCompositing] needs to
    /// be recomputed during the next [PipelineOwner.flushCompositingBits] engine
    /// phase.
    ///
    /// When the subtree is mutated, we need to recompute our
    /// [needsCompositing] bit, and some of our ancestors need to do the
    /// same (in case ours changed in a way that will change theirs). To
    /// this end, [adoptChild] and [dropChild] call this method, and, as
    /// necessary, this method calls the parent's, etc, walking up the
    /// tree to mark all the nodes that need updating.
    ///
    /// This method does not schedule a rendering frame, because since
    /// it cannot be the case that _only_ the compositing bits changed,
    /// something else will have scheduled a frame for us.
    /// </Summary>
    public virtual void MarkNeedsCompositingBitsUpdate()
    {
        if (_NeedsCompositingBitsUpdate) return;
        _NeedsCompositingBitsUpdate = true;
        if (Parent is RenderObject)
        {
            RenderObject((RenderObject)parent) = this.((RenderObject)Parent) as RenderObject;
            if (((RenderObject)parent)._NeedsCompositingBitsUpdate) return;
            if (!IsRepaintBoundary && !((RenderObject)parent).IsRepaintBoundary)
            {
                ((RenderObject)parent).MarkNeedsCompositingBitsUpdate();
                return;
            }

        }


        if (Owner != null) Owner._NodesNeedingCompositingBitsUpdate.Add(this);
    }




    private void _UpdateCompositingBits()
    {
        if (!_NeedsCompositingBitsUpdate) return;
        bool oldNeedsCompositing = _NeedsCompositing;
        _NeedsCompositing = false;
        VisitChildren((RenderObject child) =>
        {
            child._UpdateCompositingBits();
            if (child.NeedsCompositing) _NeedsCompositing = true;
        }
        );
        if (IsRepaintBoundary || AlwaysNeedsCompositing) _NeedsCompositing = true;
        if (oldNeedsCompositing != _NeedsCompositing) MarkNeedsPaint();
        _NeedsCompositingBitsUpdate = false;
    }




    /// <Summary>
    /// Mark this render object as having changed its visual appearance.
    ///
    /// Rather than eagerly updating this render object's display list
    /// in response to writes, we instead mark the render object as needing to
    /// paint, which schedules a visual update. As part of the visual update, the
    /// rendering pipeline will give this render object an opportunity to update
    /// its display list.
    ///
    /// This mechanism batches the painting work so that multiple sequential
    /// writes are coalesced, removing redundant computation.
    ///
    /// Once [markNeedsPaint] has been called on a render object,
    /// [debugNeedsPaint] returns true for that render object until just after
    /// the pipeline owner has called [paint] on the render object.
    ///
    /// See also:
    ///
    ///  * [RepaintBoundary], to scope a subtree of render objects to their own
    ///    layer, thus limiting the number of nodes that [markNeedsPaint] must mark
    ///    dirty.
    /// </Summary>
    public virtual void MarkNeedsPaint()
    {

        if (_NeedsPaint) return;
        _NeedsPaint = true;
        if (IsRepaintBoundary)
        {


            if (Owner != null)
            {
                Owner._NodesNeedingPaint.Add(this);
                Owner.RequestVisualUpdate();
            }

        }
        else if (Parent is RenderObject)
        {
            RenderObject((RenderObject)parent) = this.((RenderObject)Parent) as RenderObject;
            ((RenderObject)parent).MarkNeedsPaint();

        }
        else
        {

            if (Owner != null) Owner.RequestVisualUpdate();
        }

    }




    private void _SkippedPaintingOnLayer()
    {





        AbstractNode ancestor = Parent;
        while (ancestor is RenderObject)
        {
            RenderObject node = ancestor as RenderObject;
            if (node.IsRepaintBoundary)
            {
                if (node._Layer == null) break;
                if (node._Layer.Attached) break;
                node._NeedsPaint = true;
            }

            ancestor = node.Parent;
        }

    }




    /// <Summary>
    /// Bootstrap the rendering pipeline by scheduling the very first paint.
    ///
    /// Requires that this render object is attached, is the root of the render
    /// tree, and has a composited layer.
    ///
    /// See [RenderView] for an example of how this function is used.
    /// </Summary>
    public virtual void ScheduleInitialPaint(FlutterSDK.Rendering.Layer.ContainerLayer rootLayer)
    {






        _Layer = rootLayer;

        Owner._NodesNeedingPaint.Add(this);
    }




    /// <Summary>
    /// Replace the layer. This is only valid for the root of a render
    /// object subtree (whatever object [scheduleInitialPaint] was
    /// called on).
    ///
    /// This might be called if, e.g., the device pixel ratio changed.
    /// </Summary>
    public virtual void ReplaceRootLayer(FlutterSDK.Rendering.Layer.OffsetLayer rootLayer)
    {






        _Layer.Detach();
        _Layer = rootLayer;
        MarkNeedsPaint();
    }




    private void _PaintWithContext(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {

        if (_NeedsLayout) return;

        RenderObject debugLastActivePaint = default(RenderObject);

        _NeedsPaint = false;
        try
        {
            Paint(context, offset);


        }
        catch (e,stack){
            _DebugReportException("paint", e, stack);
        }


        }




/// <Summary>
/// Override this method to paint debugging information.
/// </Summary>
    public virtual void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {
    }




    /// <Summary>
    /// Paint this render object into the given context at the given offset.
    ///
    /// Subclasses should override this method to provide a visual appearance
    /// for themselves. The render object's local coordinate system is
    /// axis-aligned with the coordinate system of the context's canvas and the
    /// render object's local origin (i.e, x=0 and y=0) is placed at the given
    /// offset in the context's canvas.
    ///
    /// Do not call this function directly. If you wish to paint yourself, call
    /// [markNeedsPaint] instead to schedule a call to this function. If you wish
    /// to paint one of your children, call [PaintingContext.paintChild] on the
    /// given `context`.
    ///
    /// When painting one of your children (via a paint child function on the
    /// given context), the current canvas held by the context might change
    /// because draw operations before and after painting children might need to
    /// be recorded on separate compositing layers.
    /// </Summary>
    public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {
    }




    /// <Summary>
    /// Applies the transform that would be applied when painting the given child
    /// to the given matrix.
    ///
    /// Used by coordinate conversion functions to translate coordinates local to
    /// one render object into coordinates local to another render object.
    /// </Summary>
    public virtual void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
    {

    }




    /// <Summary>
    /// Applies the paint transform up the tree to `ancestor`.
    ///
    /// Returns a matrix that maps the local paint coordinate system to the
    /// coordinate system of `ancestor`.
    ///
    /// If `ancestor` is null, this method returns a matrix that maps from the
    /// local paint coordinate system to the coordinate system of the
    /// [PipelineOwner.rootNode]. For the render tree owner by the
    /// [RendererBinding] (i.e. for the main render tree displayed on the device)
    /// this means that this method maps to the global coordinate system in
    /// logical pixels. To get physical pixels, use [applyPaintTransform] from the
    /// [RenderView] to further transform the coordinate.
    /// </Summary>
    public virtual Matrix4 GetTransformTo(FlutterSDK.Rendering.@object.RenderObject ancestor)
    {
        bool ancestorSpecified = ancestor != null;

        if (ancestor == null)
        {
            AbstractNode rootNode = Owner.RootNode;
            if (((RenderObject)rootNode) is RenderObject) ancestor = ((RenderObject)rootNode);
        }

        List<RenderObject> renderers = new List<RenderObject>() { };
        for (RenderObject renderer = this; renderer != ancestor; renderer = renderer.Parent as RenderObject)
        {

            renderers.Add(renderer);
        }

        if (ancestorSpecified) renderers.Add(ancestor);
        Matrix4 transform = Matrix4.Identity();
        for (int index = renderers.Count - 1; index > 0; index -= 1)
        {
            renderers[index].ApplyPaintTransform(renderers[index - 1], transform);
        }

        return transform;
    }




    /// <Summary>
    /// Returns a rect in this object's coordinate system that describes
    /// the approximate bounding box of the clip rect that would be
    /// applied to the given child during the paint phase, if any.
    ///
    /// Returns null if the child would not be clipped.
    ///
    /// This is used in the semantics phase to avoid including children
    /// that are not physically visible.
    /// </Summary>
    public virtual Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) => null;



    /// <Summary>
    /// Returns a rect in this object's coordinate system that describes
    /// which [SemanticsNode]s produced by the `child` should be included in the
    /// semantics tree. [SemanticsNode]s from the `child` that are positioned
    /// outside of this rect will be dropped. Child [SemanticsNode]s that are
    /// positioned inside this rect, but outside of [describeApproximatePaintClip]
    /// will be included in the tree marked as hidden. Child [SemanticsNode]s
    /// that are inside of both rect will be included in the tree as regular
    /// nodes.
    ///
    /// This method only returns a non-null value if the semantics clip rect
    /// is different from the rect returned by [describeApproximatePaintClip].
    /// If the semantics clip rect and the paint clip rect are the same, this
    /// method returns null.
    ///
    /// A viewport would typically implement this method to include semantic nodes
    /// in the semantics tree that are currently hidden just before the leading
    /// or just after the trailing edge. These nodes have to be included in the
    /// semantics tree to implement implicit accessibility scrolling on iOS where
    /// the viewport scrolls implicitly when moving the accessibility focus from
    /// a the last visible node in the viewport to the first hidden one.
    /// </Summary>
    public virtual Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child) => null;



    /// <Summary>
    /// Bootstrap the semantics reporting mechanism by marking this node
    /// as needing a semantics update.
    ///
    /// Requires that this render object is attached, and is the root of
    /// the render tree.
    ///
    /// See [RendererBinding] for an example of how this function is used.
    /// </Summary>
    public virtual void ScheduleInitialSemantics()
    {






        Owner._NodesNeedingSemantics.Add(this);
        Owner.RequestVisualUpdate();
    }




    /// <Summary>
    /// Report the semantics of this node, for example for accessibility purposes.
    ///
    /// This method should be overridden by subclasses that have interesting
    /// semantic information.
    ///
    /// The given [SemanticsConfiguration] object is mutable and should be
    /// annotated in a manner that describes the current state. No reference
    /// should be kept to that object; mutating it outside of the context of the
    /// [describeSemanticsConfiguration] call (for example as a result of
    /// asynchronous computation) will at best have no useful effect and at worse
    /// will cause crashes as the data will be in an inconsistent state.
    ///
    /// {@tool snippet}
    ///
    /// The following snippet will describe the node as a button that responds to
    /// tap actions.
    ///
    /// ```dart
    /// abstract class SemanticButtonRenderObject extends RenderObject {
    ///   @override
    ///   void describeSemanticsConfiguration(SemanticsConfiguration config) {
    ///     super.describeSemanticsConfiguration(config);
    ///     config
    ///       ..onTap = _handleTap
    ///       ..label = 'I am a button'
    ///       ..isButton = true;
    ///   }
    ///
    ///   void _handleTap() {
    ///     // Do something.
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public virtual void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
    {
    }




    /// <Summary>
    /// Sends a [SemanticsEvent] associated with this render object's [SemanticsNode].
    ///
    /// If this render object has no semantics information, the first parent
    /// render object with a non-null semantic node is used.
    ///
    /// If semantics are disabled, no events are dispatched.
    ///
    /// See [SemanticsNode.sendEvent] for a full description of the behavior.
    /// </Summary>
    public virtual void SendSemanticsEvent(FlutterSDK.Semantics.Semanticsevent.SemanticsEvent semanticsEvent)
    {
        if (Owner.SemanticsOwner == null) return;
        if (_Semantics != null && !_Semantics.IsMergedIntoParent)
        {
            _Semantics.SendEvent(semanticsEvent);
        }
        else if (Parent != null)
        {
            RenderObject renderParent = Parent as RenderObject;
            renderParent.SendSemanticsEvent(semanticsEvent);
        }

    }




    /// <Summary>
    /// Removes all semantics from this render object and its descendants.
    ///
    /// Should only be called on objects whose [parent] is not a [RenderObject].
    ///
    /// Override this method if you instantiate new [SemanticsNode]s in an
    /// overridden [assembleSemanticsNode] method, to dispose of those nodes.
    /// </Summary>
    public virtual void ClearSemantics()
    {
        _NeedsSemanticsUpdate = true;
        _Semantics = null;
        VisitChildren((RenderObject child) =>
        {
            child.ClearSemantics();
        }
        );
    }




    /// <Summary>
    /// Mark this node as needing an update to its semantics description.
    ///
    /// This must be called whenever the semantics configuration of this
    /// [RenderObject] as annotated by [describeSemanticsConfiguration] changes in
    /// any way to update the semantics tree.
    /// </Summary>
    public virtual void MarkNeedsSemanticsUpdate()
    {

        if (!Attached || Owner._SemanticsOwner == null)
        {
            _CachedSemanticsConfiguration = null;
            return;
        }

        bool wasSemanticsBoundary = _Semantics != null && _CachedSemanticsConfiguration?.IsSemanticBoundary == true;
        _CachedSemanticsConfiguration = null;
        bool isEffectiveSemanticsBoundary = _SemanticsConfiguration.IsSemanticBoundary && wasSemanticsBoundary;
        RenderObject node = this;
        while (!isEffectiveSemanticsBoundary && node.Parent is RenderObject)
        {
            if (node != this && node._NeedsSemanticsUpdate) break;
            node._NeedsSemanticsUpdate = true;
            node = node.Parent as RenderObject;
            isEffectiveSemanticsBoundary = node._SemanticsConfiguration.IsSemanticBoundary;
            if (isEffectiveSemanticsBoundary && node._Semantics == null)
            {
                return;
            }

        }

        if (node != this && _Semantics != null && _NeedsSemanticsUpdate)
        {
            Owner._NodesNeedingSemantics.Remove(this);
        }

        if (!node._NeedsSemanticsUpdate)
        {
            node._NeedsSemanticsUpdate = true;
            if (Owner != null)
            {

                Owner._NodesNeedingSemantics.Add(node);
                Owner.RequestVisualUpdate();
            }

        }

    }




    /// <Summary>
    /// Updates the semantic information of the render object.
    /// </Summary>
    private void _UpdateSemantics()
    {

        if (_NeedsLayout)
        {
            return;
        }

        _SemanticsFragment fragment = _GetSemanticsForParent(mergeIntoParent: _Semantics?.Parent?.IsPartOfNodeMerging ?? false);

        _InterestingSemanticsFragment interestingFragment = fragment as _InterestingSemanticsFragment;
        SemanticsNode node = interestingFragment.CompileChildren(parentSemanticsClipRect: _Semantics?.ParentSemanticsClipRect, parentPaintClipRect: _Semantics?.ParentPaintClipRect, elevationAdjustment: _Semantics?.ElevationAdjustment ?? 0.0).Single();

    }




    /// <Summary>
    /// Returns the semantics that this node would like to add to its parent.
    /// </Summary>
    private FlutterSDK.Rendering.@object._SemanticsFragment _GetSemanticsForParent(bool mergeIntoParent = default(bool))
    {


        SemanticsConfiguration config = _SemanticsConfiguration;
        bool dropSemanticsOfPreviousSiblings = config.IsBlockingSemanticsOfPreviouslyPaintedNodes;
        bool producesForkingFragment = !config.HasBeenAnnotated && !config.IsSemanticBoundary;
        List<_InterestingSemanticsFragment> fragments = new List<_InterestingSemanticsFragment>() { };
        HashSet<_InterestingSemanticsFragment> toBeMarkedExplicit = new Dictionary<_InterestingSemanticsFragment> { };
        bool childrenMergeIntoParent = mergeIntoParent || config.IsMergingSemanticsOfDescendants;
        bool abortWalk = false;
        VisitChildrenForSemantics((RenderObject renderChild) =>
        {
            if (abortWalk || _NeedsLayout)
            {
                abortWalk = true;
                return;
            }

            _SemanticsFragment parentFragment = renderChild._GetSemanticsForParent(mergeIntoParent: childrenMergeIntoParent);
            if (parentFragment.AbortsWalk)
            {
                abortWalk = true;
                return;
            }

            if (parentFragment.DropsSemanticsOfPreviousSiblings)
            {
                fragments.Clear();
                toBeMarkedExplicit.Clear();
                if (!config.IsSemanticBoundary) dropSemanticsOfPreviousSiblings = true;
            }

            foreach (_InterestingSemanticsFragment fragment in parentFragment.InterestingFragments)
            {
                fragments.Add(fragment);
                fragment.AddAncestor(this);
                fragment.AddTags(config.TagsForChildren);
                if (config.ExplicitChildNodes || !(Parent is RenderObject))
                {
                    fragment.MarkAsExplicit();
                    continue;
                }

                if (!fragment.HasConfigForParent || producesForkingFragment) continue;
                if (!config.IsCompatibleWith(fragment.Config)) toBeMarkedExplicit.Add(fragment);
                foreach (_InterestingSemanticsFragment siblingFragment in fragments.Sublist(0, fragments.Count - 1))
                {
                    if (!fragment.Config.IsCompatibleWith(siblingFragment.Config))
                    {
                        toBeMarkedExplicit.Add(fragment);
                        toBeMarkedExplicit.Add(siblingFragment);
                    }

                }

            }

        }
        );
        if (abortWalk)
        {
            return new _AbortingSemanticsFragment(owner: this);
        }

        foreach (_InterestingSemanticsFragment fragment in toBeMarkedExplicit) fragment.MarkAsExplicit();
        _NeedsSemanticsUpdate = false;
        _SemanticsFragment result = default(_SemanticsFragment);
        if (!(Parent is RenderObject))
        {


            result = new _RootSemanticsFragment(owner: this, dropsSemanticsOfPreviousSiblings: dropSemanticsOfPreviousSiblings);
        }
        else if (producesForkingFragment)
        {
            result = new _ContainerSemanticsFragment(dropsSemanticsOfPreviousSiblings: dropSemanticsOfPreviousSiblings);
        }
        else
        {
            result = new _SwitchableSemanticsFragment(config: config, mergeIntoParent: mergeIntoParent, owner: this, dropsSemanticsOfPreviousSiblings: dropSemanticsOfPreviousSiblings);
            if (config.IsSemanticBoundary)
            {
                _SwitchableSemanticsFragment fragment = result as _SwitchableSemanticsFragment;
                fragment.MarkAsExplicit();
            }

        }

        result.AddAll(fragments);
        return result;
    }




    /// <Summary>
    /// Called when collecting the semantics of this node.
    ///
    /// The implementation has to return the children in paint order skipping all
    /// children that are not semantically relevant (e.g. because they are
    /// invisible).
    ///
    /// The default implementation mirrors the behavior of
    /// [visitChildren] (which is supposed to walk all the children).
    /// </Summary>
    public virtual void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
    {
        VisitChildren(visitor);
    }




    /// <Summary>
    /// Assemble the [SemanticsNode] for this [RenderObject].
    ///
    /// If [isSemanticBoundary] is true, this method is called with the `node`
    /// created for this [RenderObject], the `config` to be applied to that node
    /// and the `children` [SemanticsNode]s that descendants of this RenderObject
    /// have generated.
    ///
    /// By default, the method will annotate `node` with `config` and add the
    /// `children` to it.
    ///
    /// Subclasses can override this method to add additional [SemanticsNode]s
    /// to the tree. If new [SemanticsNode]s are instantiated in this method
    /// they must be disposed in [clearSemantics].
    /// </Summary>
    public virtual void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children)
    {

        node.UpdateWith(config: config, childrenInInversePaintOrder: children as List<SemanticsNode>);
    }




    /// <Summary>
    /// Override this method to handle pointer events that hit this render object.
    /// </Summary>
    public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry)
    {
    }




    /// <Summary>
    /// Returns a human understandable name.
    /// </Summary>
    public new string ToStringShort()
    {
        string header = DiagnosticsDefaultClass.DescribeIdentity(this);
        if (_RelayoutBoundary != null && _RelayoutBoundary != this)
        {
            int count = 1;
            RenderObject target = Parent as RenderObject;
            while (target != null && target != _RelayoutBoundary)
            {
                target = target.Parent as RenderObject;
                count += 1;
            }

            header += $"' relayoutBoundary=up{count}'";
        }

        if (_NeedsLayout) header += " NEEDS-LAYOUT";
        if (_NeedsPaint) header += " NEEDS-PAINT";
        if (_NeedsCompositingBitsUpdate) header += " NEEDS-COMPOSITING-BITS-UPDATE";
        if (!Attached) header += " DETACHED";
        return header;
    }





    /// <Summary>
    /// Returns a description of the tree rooted at this node.
    /// If the prefix argument is provided, then every line in the output
    /// will be prefixed by that string.
    /// </Summary>
    public new string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        RenderObject debugPreviousActiveLayout = default(RenderObject);

        string result = base.ToStringDeep(prefixLineOne: prefixLineOne, prefixOtherLines: prefixOtherLines, minLevel: minLevel);

        return result;
    }




    /// <Summary>
    /// Returns a one-line detailed description of the render object.
    /// This description is often somewhat long.
    ///
    /// This includes the same information for this RenderObject as given by
    /// [toStringDeep], but does not recurse to any children.
    /// </Summary>
    public new string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        RenderObject debugPreviousActiveLayout = default(RenderObject);

        string result = base.ToStringShallow(joiner: joiner, minLevel: minLevel);

        return result;
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new FlagProperty("needsCompositing", value: _NeedsCompositing, ifTrue: "needs compositing"));
        properties.Add(new DiagnosticsProperty<object>("creator", DebugCreator, defaultValue: null, level: DiagnosticLevel.Debug));
        properties.Add(new DiagnosticsProperty<ParentData>("parentData", ParentData, tooltip: _DebugCanParentUseSize == true ? "can use size" : null, missingIfNull: true));
        properties.Add(new DiagnosticsProperty<Constraints>("constraints", Constraints, missingIfNull: true));
        properties.Add(new DiagnosticsProperty<ContainerLayer>("layer", _Layer, defaultValue: null));
        properties.Add(new DiagnosticsProperty<SemanticsNode>("semantics node", _Semantics, defaultValue: null));
        properties.Add(new FlagProperty("isBlockingSemanticsOfPreviouslyPaintedNodes", value: _SemanticsConfiguration.IsBlockingSemanticsOfPreviouslyPaintedNodes, ifTrue: "blocks semantics of earlier render objects below the common boundary"));
        properties.Add(new FlagProperty("isSemanticBoundary", value: _SemanticsConfiguration.IsSemanticBoundary, ifTrue: "semantic boundary"));
    }




    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() => new List<DiagnosticsNode>() { };



    /// <Summary>
    /// Attempt to make (a portion of) this or a descendant [RenderObject] visible
    /// on screen.
    ///
    /// If `descendant` is provided, that [RenderObject] is made visible. If
    /// `descendant` is omitted, this [RenderObject] is made visible.
    ///
    /// The optional `rect` parameter describes which area of that [RenderObject]
    /// should be shown on screen. If `rect` is null, the entire
    /// [RenderObject] (as defined by its [paintBounds]) will be revealed. The
    /// `rect` parameter is interpreted relative to the coordinate system of
    /// `descendant` if that argument is provided and relative to this
    /// [RenderObject] otherwise.
    ///
    /// The `duration` parameter can be set to a non-zero value to bring the
    /// target object on screen in an animation defined by `curve`.
    /// </Summary>
    public virtual void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
    {
        if (Parent is RenderObject)
        {
            RenderObject renderParent = ((RenderObject)Parent) as RenderObject;
            renderParent.ShowOnScreen(descendant: descendant ?? this, rect: rect, duration: duration, curve: curve);
        }

    }




    /// <Summary>
    /// Adds a debug representation of a [RenderObject] optimized for including in
    /// error messages.
    ///
    /// The default [style] of [DiagnosticsTreeStyle.shallow] ensures that all of
    /// the properties of the render object are included in the error output but
    /// none of the children of the object are.
    ///
    /// You should always include a RenderObject in an error message if it is the
    /// [RenderObject] causing the failure or contract violation of the error.
    /// </Summary>
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeForError(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
    {
        return ToDiagnosticsNode(name: name, style: style);
    }



    #endregion
}


/// <Summary>
/// Variant of [FlutterErrorDetails] with extra fields for the rendering
/// library.
/// </Summary>
public class FlutterErrorDetailsForRendering : FlutterSDK.Foundation.Assertions.FlutterErrorDetails
{
    #region constructors
    public FlutterErrorDetailsForRendering(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Rendering.@object.RenderObject renderObject = default(FlutterSDK.Rendering.@object.RenderObject), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
    : base(exception: exception, stack: stack, library: library, context: context, informationCollector: informationCollector, silent: silent)
    {
        this.RenderObject = renderObject;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Rendering.@object.RenderObject RenderObject { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Describes the semantics information a [RenderObject] wants to add to its
/// parent.
///
/// It has two notable subclasses:
///  * [_InterestingSemanticsFragment] describing actual semantic information to
///    be added to the parent.
///  * [_ContainerSemanticsFragment]: a container class to transport the semantic
///    information of multiple [_InterestingSemanticsFragment] to a parent.
/// </Summary>
public class _SemanticsFragment
{
    #region constructors
    public _SemanticsFragment(bool dropsSemanticsOfPreviousSiblings = default(bool))
    : base()
    {
        this.DropsSemanticsOfPreviousSiblings = dropsSemanticsOfPreviousSiblings;
    }
    #endregion

    #region fields
    public virtual bool DropsSemanticsOfPreviousSiblings { get; set; }
    public virtual Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AbortsWalk { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Incorporate the fragments of children into this fragment.
    /// </Summary>
    public virtual void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments)
    {
    }

    #endregion
}


/// <Summary>
/// A container used when a [RenderObject] wants to add multiple independent
/// [_InterestingSemanticsFragment] to its parent.
///
/// The [_InterestingSemanticsFragment] to be added to the parent can be
/// obtained via [interestingFragments].
/// </Summary>
public class _ContainerSemanticsFragment : FlutterSDK.Rendering.@object._SemanticsFragment
{
    #region constructors
    public _ContainerSemanticsFragment(bool dropsSemanticsOfPreviousSiblings = default(bool))
    : base(dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
    {

    }
    #endregion

    #region fields
    public new List<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get; set; }
    #endregion

    #region methods

    public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments)
    {
        InterestingFragments.AddAll(fragments);
    }



    #endregion
}


/// <Summary>
/// A [_SemanticsFragment] that describes which concrete semantic information
/// a [RenderObject] wants to add to the [SemanticsNode] of its parent.
///
/// Specifically, it describes which children (as returned by [compileChildren])
/// should be added to the parent's [SemanticsNode] and which [config] should be
/// merged into the parent's [SemanticsNode].
/// </Summary>
public class _InterestingSemanticsFragment : FlutterSDK.Rendering.@object._SemanticsFragment
{
    #region constructors
    public _InterestingSemanticsFragment(FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject), bool dropsSemanticsOfPreviousSiblings = default(bool))
    : base(dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
    {

    }
    #endregion

    #region fields
    internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _AncestorChain { get; set; }
    internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> _TagsForChildren { get; set; }
    public virtual FlutterSDK.Rendering.@object.RenderObject Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool HasConfigForParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// The children to be added to the parent.
    ///
    /// See also:
    ///
    ///  * [SemanticsNode.parentSemanticsClipRect] for the source and definition
    ///    of the `parentSemanticsClipRect` argument.
    ///  * [SemanticsNode.parentPaintClipRect] for the source and definition
    ///  * [SemanticsNode.elevationAdjustment] for the source and definition
    /// </Summary>
    public virtual Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double))
    {
        return default(Iterable<SemanticsNode>);
    }


    /// <Summary>
    /// Disallows this fragment to merge any configuration into its parent's
    /// [SemanticsNode].
    ///
    /// After calling this the fragment will only produce children to be added
    /// to the parent and it will return null for [config].
    /// </Summary>
    public virtual void MarkAsExplicit()
    {
    }


    /// <Summary>
    /// Consume the fragments of children.
    ///
    /// For each provided fragment it will add that fragment's children to
    /// this fragment's children (as returned by [compileChildren]) and merge that
    /// fragment's [config] into this fragment's [config].
    ///
    /// If a provided fragment should not merge anything into [config] call
    /// [markAsExplicit] before passing the fragment to this method.
    /// </Summary>
    public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments)
    {
    }


    /// <Summary>
    /// Tag all children produced by [compileChildren] with `tags`.
    /// </Summary>
    public virtual void AddTags(Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> tags)
    {
        if (tags == null || tags.IsEmpty()) return;
        _TagsForChildren = (_TagsForChildren == null ? new Dictionary<SemanticsTag> { } : _TagsForChildren);
        _TagsForChildren.AddAll(tags);
    }




    /// <Summary>
    /// Adds the geometric information of `ancestor` to this object.
    ///
    /// Those information are required to properly compute the value for
    /// [SemanticsNode.transform], [SemanticsNode.clipRect], and
    /// [SemanticsNode.rect].
    ///
    /// Ancestors have to be added in order from [owner] up until the next
    /// [RenderObject] that owns a [SemanticsNode] is reached.
    /// </Summary>
    public virtual void AddAncestor(FlutterSDK.Rendering.@object.RenderObject ancestor)
    {
        _AncestorChain.Add(ancestor);
    }



    #endregion
}


/// <Summary>
/// An [_InterestingSemanticsFragment] that produces the root [SemanticsNode] of
/// the semantics tree.
///
/// The root node is available as the only element in the Iterable returned by
/// [children].
/// </Summary>
public class _RootSemanticsFragment : FlutterSDK.Rendering.@object._InterestingSemanticsFragment
{
    #region constructors
    public _RootSemanticsFragment(FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject), bool dropsSemanticsOfPreviousSiblings = default(bool))
    : base(owner: owner, dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
    {

    }
    #endregion

    #region fields
    internal virtual List<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> _Children { get; set; }
    public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double))
sync
*
{





Owner._Semantics = (Owner._Semantics == null ? SemanticsNode.Root(showOnScreen:Owner.ShowOnScreen, owner:Owner.Owner.SemanticsOwner) : Owner._Semantics );
SemanticsNode node = Owner._Semantics;



    node.Rect=Owner.SemanticBounds;
List<SemanticsNode> children = _Children.Expand((_InterestingSemanticsFragment fragment) =>
{

    return fragment.CompileChildren(parentSemanticsClipRect: parentSemanticsClipRect, parentPaintClipRect: parentPaintClipRect, elevationAdjustment: 0.0);
}
).ToList();
    node.UpdateWith(config:null , childrenInInversePaintOrder:children);

yield node;
}




public new void MarkAsExplicit()
{
}




public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments)
{
    _Children.AddAll(fragments);
}



#endregion
}


/// <Summary>
/// An [_InterestingSemanticsFragment] that can be told to only add explicit
/// [SemanticsNode]s to the parent.
///
/// If [markAsExplicit] was not called before this fragment is added to
/// another fragment it will merge [config] into the parent's [SemanticsNode]
/// and add its [children] to it.
///
/// If [markAsExplicit] was called before adding this fragment to another
/// fragment it will create a new [SemanticsNode]. The newly created node will
/// be annotated with the [SemanticsConfiguration] that - without the call to
/// [markAsExplicit] - would have been merged into the parent's [SemanticsNode].
/// Similarly, the new node will also take over the children that otherwise
/// would have been added to the parent's [SemanticsNode].
///
/// After a call to [markAsExplicit] the only element returned by [children]
/// is the newly created node and [config] will return null as the fragment
/// no longer wants to merge any semantic information into the parent's
/// [SemanticsNode].
/// </Summary>
public class _SwitchableSemanticsFragment : FlutterSDK.Rendering.@object._InterestingSemanticsFragment
{
    #region constructors
    public _SwitchableSemanticsFragment(bool mergeIntoParent = default(bool), FlutterSDK.Semantics.Semantics.SemanticsConfiguration config = default(FlutterSDK.Semantics.Semantics.SemanticsConfiguration), FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject), bool dropsSemanticsOfPreviousSiblings = default(bool))
    : base(owner: owner, dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
    {

    }
    #endregion

    #region fields
    internal virtual bool _MergeIntoParent { get; set; }
    internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _Config { get; set; }
    internal virtual bool _IsConfigWritable { get; set; }
    internal virtual List<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> _Children { get; set; }
    internal virtual bool _IsExplicit { get; set; }
    public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual bool _NeedsGeometryUpdate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double))
sync
*
{
if (!_IsExplicit){
Owner._Semantics=null ;
foreach(_InterestingSemanticsFragment fragment  in _Children){

fragment._AncestorChain.AddAll(_AncestorChain.Sublist(1));
yield* fragment.CompileChildren(parentSemanticsClipRect:parentSemanticsClipRect, parentPaintClipRect:parentPaintClipRect, elevationAdjustment:elevationAdjustment+_Config.Elevation);
}

return;
}

_SemanticsGeometry geometry = _NeedsGeometryUpdate ? new _SemanticsGeometry(parentSemanticsClipRect: parentSemanticsClipRect, parentPaintClipRect: parentPaintClipRect, ancestors: _AncestorChain) : null;
if (!_MergeIntoParent && (geometry?.DropFromTree == true)) return;
Owner._Semantics = (Owner._Semantics == null ? new SemanticsNode(showOnScreen: Owner.ShowOnScreen) : Owner._Semantics);
SemanticsNode node = Owner._Semantics..IsMergedIntoParent = _MergeIntoParent..Tags = _TagsForChildren;
node.ElevationAdjustment = elevationAdjustment;
if (elevationAdjustment != 0.0)
{
    _EnsureConfigIsWritable();
    _Config.Elevation += elevationAdjustment;
}

if (geometry != null)
{

    ..Rect = geometry.Rect..Transform = geometry.Transform..ParentSemanticsClipRect = geometry.SemanticsClipRect..ParentPaintClipRect = geometry.PaintClipRect;
    if (!_MergeIntoParent && geometry.MarkAsHidden)
    {
        _EnsureConfigIsWritable();
        _Config.IsHidden = true;
    }

}

List<SemanticsNode> children = _Children.Expand((_InterestingSemanticsFragment fragment) => =>fragment.CompileChildren(parentSemanticsClipRect: node.ParentSemanticsClipRect, parentPaintClipRect: node.ParentPaintClipRect, elevationAdjustment: 0.0)).ToList();
if (_Config.IsSemanticBoundary)
{
    Owner.AssembleSemanticsNode(node, _Config, children);
}
else
{
    node.UpdateWith(config: _Config, childrenInInversePaintOrder: children);
}

yield node;
}




public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments)
{
    foreach (_InterestingSemanticsFragment fragment in fragments)
    {
        _Children.Add(fragment);
        if (fragment.Config == null) continue;
        _EnsureConfigIsWritable();
        _Config.Absorb(fragment.Config);
    }

}




private void _EnsureConfigIsWritable()
{
    if (!_IsConfigWritable)
    {
        _Config = _Config.Copy();
        _IsConfigWritable = true;
    }

}




public new void MarkAsExplicit()
{
    _IsExplicit = true;
}



#endregion
}


/// <Summary>
/// [_SemanticsFragment] used to indicate that the current information in this
/// subtree is not sufficient to update semantics.
///
/// Anybody processing this [_SemanticsFragment] should abort the walk of the
/// current subtree without updating any [SemanticsNode]s as there is no semantic
/// information to compute. As a result, this fragment also doesn't carry any
/// semantics information either.
/// </Summary>
public class _AbortingSemanticsFragment : FlutterSDK.Rendering.@object._InterestingSemanticsFragment
{
    #region constructors
    public _AbortingSemanticsFragment(FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject))
    : base(owner: owner, dropsSemanticsOfPreviousSiblings: false)
    {

    }
    #endregion

    #region fields
    public virtual bool AbortsWalk { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments)
    {

    }




    public new Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double))
sync
*
{
yield Owner._Semantics;
}




public new void MarkAsExplicit()
{
}



#endregion
}


/// <Summary>
/// Helper class that keeps track of the geometry of a [SemanticsNode].
///
/// It is used to annotate a [SemanticsNode] with the current information for
/// [SemanticsNode.rect] and [SemanticsNode.transform].
/// </Summary>
public class _SemanticsGeometry
{
    #region constructors
    public _SemanticsGeometry(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), List<FlutterSDK.Rendering.@object.RenderObject> ancestors = default(List<FlutterSDK.Rendering.@object.RenderObject>))
    {

        _ComputeValues(parentSemanticsClipRect, parentPaintClipRect, ancestors);
    }


    #endregion

    #region fields
    internal virtual FlutterBinding.UI.Rect _PaintClipRect { get; set; }
    internal virtual FlutterBinding.UI.Rect _SemanticsClipRect { get; set; }
    internal virtual Matrix4 _Transform { get; set; }
    internal virtual FlutterBinding.UI.Rect _Rect { get; set; }
    internal virtual Matrix4 _TemporaryTransformHolder { get; set; }
    internal virtual bool _MarkAsHidden { get; set; }
    public virtual object Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Rect SemanticsClipRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Rect PaintClipRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Rect Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool DropFromTree { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool MarkAsHidden { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    private void _ComputeValues(FlutterBinding.UI.Rect parentSemanticsClipRect, FlutterBinding.UI.Rect parentPaintClipRect, List<FlutterSDK.Rendering.@object.RenderObject> ancestors)
    {

        _Transform = Matrix4.Identity();
        _SemanticsClipRect = parentSemanticsClipRect;
        _PaintClipRect = parentPaintClipRect;
        for (int index = ancestors.Count - 1; index > 0; index -= 1)
        {
            RenderObject parent = ancestors[index];
            RenderObject child = ancestors[index - 1];
            Rect parentSemanticsClipRect = parent.DescribeSemanticsClip(child);
            if (parentSemanticsClipRect != null)
            {
                _SemanticsClipRect = parentSemanticsClipRect;
                _PaintClipRect = _IntersectRects(_PaintClipRect, parent.DescribeApproximatePaintClip(child));
            }
            else
            {
                _SemanticsClipRect = _IntersectRects(_SemanticsClipRect, parent.DescribeApproximatePaintClip(child));
            }

            _TemporaryTransformHolder.SetIdentity();
            _ApplyIntermediatePaintTransforms(parent, child, _Transform, _TemporaryTransformHolder);
            _SemanticsClipRect = _TransformRect(_SemanticsClipRect, _TemporaryTransformHolder);
            _PaintClipRect = _TransformRect(_PaintClipRect, _TemporaryTransformHolder);
        }

        RenderObject owner = ancestors.First;
        _Rect = _SemanticsClipRect == null ? owner.SemanticBounds : _SemanticsClipRect.Intersect(owner.SemanticBounds);
        if (_PaintClipRect != null)
        {
            Rect paintRect = _PaintClipRect.Intersect(_Rect);
            _MarkAsHidden = paintRect.IsEmpty() && !_Rect.IsEmpty();
            if (!_MarkAsHidden) _Rect = paintRect;
        }

    }




    /// <Summary>
    /// From parent to child coordinate system.
    /// </Summary>
    private Rect _TransformRect(FlutterBinding.UI.Rect rect, Matrix4 transform)
    {

        if (rect == null) return null;
        if (rect.IsEmpty() || transform.IsZero()) return Dart:uiDefaultClass.Rect.Zero;
        return MatrixutilsDefaultClass.MatrixUtils.InverseTransformRect(transform, rect);
    }




    private void _ApplyIntermediatePaintTransforms(FlutterSDK.Rendering.@object.RenderObject ancestor, FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform, Matrix4 clipRectTransform)
    {





        RenderObject intermediateParent = child.Parent as RenderObject;

        while (intermediateParent != ancestor)
        {
            intermediateParent.ApplyPaintTransform(child, transform);
            intermediateParent = intermediateParent.Parent as RenderObject;
            child = child.Parent as RenderObject;

        }

        ancestor.ApplyPaintTransform(child, transform);
        ancestor.ApplyPaintTransform(child, clipRectTransform);
    }




    private Rect _IntersectRects(FlutterBinding.UI.Rect a, FlutterBinding.UI.Rect b)
    {
        if (a == null) return b;
        if (b == null) return a;
        return a.Intersect(b);
    }



    #endregion
}


/// <Summary>
/// A class that creates [DiagnosticsNode] by wrapping [RenderObject.debugCreator].
///
/// Attach a [DiagnosticsDebugCreator] into [FlutterErrorDetails.informationCollector]
/// when a [RenderObject.debugCreator] is available. This will lead to improved
/// error message.
/// </Summary>
public class DiagnosticsDebugCreator : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<@Object>
{
    #region constructors
    public DiagnosticsDebugCreator(@Object value)
    : base("debugCreator", value, level: DiagnosticLevel.Hidden)
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods
    #endregion
}

}
