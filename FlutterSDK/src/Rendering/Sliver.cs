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
namespace FlutterSDK.Rendering.Sliver
{
    public delegate bool SliverHitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
    internal static class SliverDefaultClass
    {
        internal static FlutterSDK.Painting.Basictypes.AxisDirection ApplyGrowthDirectionToAxisDirection(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {
            throw new NotImplementedException();
        }

        internal static FlutterSDK.Rendering.Viewportoffset.ScrollDirection ApplyGrowthDirectionToScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection scrollDirection, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {
            throw new NotImplementedException();
        }

        internal static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _DebugCompareFloats(string labelA, double valueA, string labelB, double valueB)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Base class for the render objects that implement scroll effects in viewports.
    ///
    /// A [RenderViewport] has a list of child slivers. Each sliver — literally a
    /// slice of the viewport's contents — is laid out in turn, covering the
    /// viewport in the process. (Every sliver is laid out each time, including
    /// those that have zero extent because they are "scrolled off" or are beyond
    /// the end of the viewport.)
    ///
    /// Slivers participate in the _sliver protocol_, wherein during [layout] each
    /// sliver receives a [SliverConstraints] object and computes a corresponding
    /// [SliverGeometry] that describes where it fits in the viewport. This is
    /// analogous to the box protocol used by [RenderBox], which gets a
    /// [BoxConstraints] as input and computes a [Size].
    ///
    /// Slivers have a leading edge, which is where the position described by
    /// [SliverConstraints.scrollOffset] for this sliver begins. Slivers have
    /// several dimensions, the primary of which is [SliverGeometry.paintExtent],
    /// which describes the extent of the sliver along the main axis, starting from
    /// the leading edge, reaching either the end of the viewport or the end of the
    /// sliver, whichever comes first.
    ///
    /// Slivers can change dimensions based on the changing constraints in a
    /// non-linear fashion, to achieve various scroll effects. For example, the
    /// various [RenderSliverPersistentHeader] subclasses, on which [SliverAppBar]
    /// is based, achieve effects such as staying visible despite the scroll offset,
    /// or reappearing at different offsets based on the user's scroll direction
    /// ([SliverConstraints.userScrollDirection]).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=Mz3kHQxBjGg}
    ///
    /// ## Writing a RenderSliver subclass
    ///
    /// Slivers can have sliver children, or children from another coordinate
    /// system, typically box children. (For details on the box protocol, see
    /// [RenderBox].) Slivers can also have different child models, typically having
    /// either one child, or a list of children.
    ///
    /// ### Examples of slivers
    ///
    /// A good example of a sliver with a single child that is also itself a sliver
    /// is [RenderSliverPadding], which indents its child. A sliver-to-sliver render
    /// object such as this must construct a [SliverConstraints] object for its
    /// child, then must take its child's [SliverGeometry] and use it to form its
    /// own [geometry].
    ///
    /// The other common kind of one-child sliver is a sliver that has a single
    /// [RenderBox] child. An example of that would be [RenderSliverToBoxAdapter],
    /// which lays out a single box and sizes itself around the box. Such a sliver
    /// must use its [SliverConstraints] to create a [BoxConstraints] for the
    /// child, lay the child out (using the child's [layout] method), and then use
    /// the child's [RenderBox.size] to generate the sliver's [SliverGeometry].
    ///
    /// The most common kind of sliver though is one with multiple children. The
    /// most straight-forward example of this is [RenderSliverList], which arranges
    /// its children one after the other in the main axis direction. As with the
    /// one-box-child sliver case, it uses its [constraints] to create a
    /// [BoxConstraints] for the children, and then it uses the aggregate
    /// information from all its children to generate its [geometry]. Unlike the
    /// one-child cases, however, it is judicious in which children it actually lays
    /// out (and later paints). If the scroll offset is 1000 pixels, and it
    /// previously determined that the first three children are each 400 pixels
    /// tall, then it will skip the first two and start the layout with its third
    /// child.
    ///
    /// ### Layout
    ///
    /// As they are laid out, slivers decide their [geometry], which includes their
    /// size ([SliverGeometry.paintExtent]) and the position of the next sliver
    /// ([SliverGeometry.layoutExtent]), as well as the position of each of their
    /// children, based on the input [constraints] from the viewport such as the
    /// scroll offset ([SliverConstraints.scrollOffset]).
    ///
    /// For example, a sliver that just paints a box 100 pixels high would say its
    /// [SliverGeometry.paintExtent] was 100 pixels when the scroll offset was zero,
    /// but would say its [SliverGeometry.paintExtent] was 25 pixels when the scroll
    /// offset was 75 pixels, and would say it was zero when the scroll offset was
    /// 100 pixels or more. (This is assuming that
    /// [SliverConstraints.remainingPaintExtent] was more than 100 pixels.)
    ///
    /// The various dimensions that are provided as input to this system are in the
    /// [constraints]. They are described in detail in the documentation for the
    /// [SliverConstraints] class.
    ///
    /// The [performLayout] function must take these [constraints] and create a
    /// [SliverGeometry] object that it must then assign to the [geometry] property.
    /// The different dimensions of the geometry that can be configured are
    /// described in detail in the documentation for the [SliverGeometry] class.
    ///
    /// ### Painting
    ///
    /// In addition to implementing layout, a sliver must also implement painting.
    /// This is achieved by overriding the [paint] method.
    ///
    /// The [paint] method is called with an [Offset] from the [Canvas] origin to
    /// the top-left corner of the sliver, _regardless of the axis direction_.
    ///
    /// Subclasses should also override [applyPaintTransform] to provide the
    /// [Matrix4] describing the position of each child relative to the sliver.
    /// (This is used by, among other things, the accessibility layer, to determine
    /// the bounds of the child.)
    ///
    /// ### Hit testing
    ///
    /// To implement hit testing, either override the [hitTestSelf] and
    /// [hitTestChildren] methods, or, for more complex cases, instead override the
    /// [hitTest] method directly.
    ///
    /// To actually react to pointer events, the [handleEvent] method may be
    /// implemented. By default it does nothing. (Typically gestures are handled by
    /// widgets in the box protocol, not by slivers directly.)
    ///
    /// ### Helper methods
    ///
    /// There are a number of methods that a sliver should implement which will make
    /// the other methods easier to implement. Each method listed below has detailed
    /// documentation. In addition, the [RenderSliverHelpers] class can be used to
    /// mix in some helpful methods.
    ///
    /// #### childScrollOffset
    ///
    /// If the subclass positions children anywhere other than at scroll offset
    /// zero, it should override [childScrollOffset]. For example,
    /// [RenderSliverList] and [RenderSliverGrid] override this method, but
    /// [RenderSliverToBoxAdapter] does not.
    ///
    /// This is used by, among other things, [Scrollable.ensureVisible].
    ///
    /// #### childMainAxisPosition
    ///
    /// Subclasses should implement [childMainAxisPosition] to describe where their
    /// children are positioned.
    ///
    /// #### childCrossAxisPosition
    ///
    /// If the subclass positions children in the cross-axis at a position other
    /// than zero, then it should override [childCrossAxisPosition]. For example
    /// [RenderSliverGrid] overrides this method.
    /// </Summary>
    public interface IRenderSliver
    {
        void DebugResetSize();
        void DebugAssertDoesMeetConstraints();
        void PerformResize();
        bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        bool HitTestSelf(double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double));
        double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double));
        double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child);
        double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child);
        double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        Size GetAbsoluteSizeRelativeToOrigin();
        Size GetAbsoluteSize();
        void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Rendering.Sliver.SliverConstraints Constraints { get; }
        FlutterSDK.Rendering.Sliver.SliverGeometry Geometry { get; set; }
        FlutterBinding.UI.Rect SemanticBounds { get; }
        FlutterBinding.UI.Rect PaintBounds { get; }
        double CenterOffsetAdjustment { get; }
    }


    /// <Summary>
    /// An abstract class for [RenderSliver]s that contains a single [RenderBox].
    ///
    /// See also:
    ///
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderSliverToBoxAdapter], which extends this class to size the child
    ///    according to its preferred size.
    ///  * [RenderSliverFillRemaining], which extends this class to size the child
    ///    to fill the remaining space in the viewport.
    /// </Summary>
    public interface IRenderSliverSingleBoxAdapter
    {
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        void SetChildParentData(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Rendering.Sliver.SliverConstraints constraints, FlutterSDK.Rendering.Sliver.SliverGeometry geometry);
        bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
    }


    public interface IRenderSliverHelpers { }

    public class RenderSliverHelpers : IRenderSliver
    {

        private bool _GetRightWayUp(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {


            bool rightWayUp = default(bool);
            switch (constraints.AxisDirection) { case AxisDirection.Up: case AxisDirection.Left: rightWayUp = false; break; case AxisDirection.Down: case AxisDirection.Right: rightWayUp = true; break; }

            switch (constraints.GrowthDirection) { case GrowthDirection.Forward: break; case GrowthDirection.Reverse: rightWayUp = !rightWayUp; break; }

            return rightWayUp;
        }




        /// <Summary>
        /// Utility function for [hitTestChildren] for use when the children are
        /// [RenderBox] widgets.
        ///
        /// This function takes care of converting the position from the sliver
        /// coordinate system to the Cartesian coordinate system used by [RenderBox].
        ///
        /// This function relies on [childMainAxisPosition] to determine the position of
        /// child in question.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual bool HitTestBoxChild(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterSDK.Rendering.Box.RenderBox child, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        {
            bool rightWayUp = _GetRightWayUp(Constraints);
            double delta = ChildMainAxisPosition(child);
            double crossAxisDelta = ChildCrossAxisPosition(child);
            double absolutePosition = mainAxisPosition - delta;
            double absoluteCrossAxisPosition = crossAxisPosition - crossAxisDelta;
            Offset paintOffset transformedPosition = default(Offset);

            switch (Constraints.Axis)
            {
                case Axis.Horizontal:
                    if (!rightWayUp)
                    {
                        absolutePosition = child.Size.Width - absolutePosition;
                        delta = Geometry.PaintExtent - child.Size.Width - delta;
                    }
                    paintOffset = new Offset(delta, crossAxisDelta); transformedPosition = new Offset(absolutePosition, absoluteCrossAxisPosition); break;
                case Axis.Vertical:
                    if (!rightWayUp)
                    {
                        absolutePosition = child.Size.Height - absolutePosition;
                        delta = Geometry.PaintExtent - child.Size.Height - delta;
                    }
                    paintOffset = new Offset(crossAxisDelta, delta); transformedPosition = new Offset(absoluteCrossAxisPosition, absolutePosition); break;
            }


            return result.AddWithPaintOffset(offset: paintOffset, position: null, hitTest: (BoxHitTestResult result, Offset _) =>
            {
                return child.HitTest(result, position: transformedPosition);
            }
            );
        }




        /// <Summary>
        /// Utility function for [applyPaintTransform] for use when the children are
        /// [RenderBox] widgets.
        ///
        /// This function turns the value returned by [childMainAxisPosition] and
        /// [childCrossAxisPosition]for the child in question into a translation that
        /// it then applies to the given matrix.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual void ApplyPaintTransformForBoxChild(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
        {
            bool rightWayUp = _GetRightWayUp(Constraints);
            double delta = ChildMainAxisPosition(child);
            double crossAxisDelta = ChildCrossAxisPosition(child);

            switch (Constraints.Axis) { case Axis.Horizontal: if (!rightWayUp) delta = Geometry.PaintExtent - child.Size.Width - delta; transform.Translate(delta, crossAxisDelta); break; case Axis.Vertical: if (!rightWayUp) delta = Geometry.PaintExtent - child.Size.Height - delta; transform.Translate(crossAxisDelta, delta); break; }
        }



        internal virtual FlutterSDK.Rendering.Sliver.SliverGeometry _Geometry { get; set; }
        public virtual FlutterSDK.Rendering.Sliver.SliverConstraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Geometry { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect SemanticBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect PaintBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CenterOffsetAdjustment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DebugResetSize()
        {
        }




        public new void DebugAssertDoesMeetConstraints()
        {


        }




        public new void PerformResize()
        {

        }




        /// <Summary>
        /// Determines the set of render objects located at the given position.
        ///
        /// Returns true if the given point is contained in this render object or one
        /// of its descendants. Adds any render objects that contain the point to the
        /// given hit test result.
        ///
        /// The caller is responsible for providing the position in the local
        /// coordinate space of the callee. The callee is responsible for checking
        /// whether the given position is within its bounds.
        ///
        /// Hit testing requires layout to be up-to-date but does not require painting
        /// to be up-to-date. That means a render object can rely upon [performLayout]
        /// having been called in [hitTest] but cannot rely upon [paint] having been
        /// called. For example, a render object might be a child of a [RenderOpacity]
        /// object, which calls [hitTest] on its children when its opacity is zero
        /// even through it does not [paint] its children.
        ///
        /// ## Coordinates for RenderSliver objects
        ///
        /// The `mainAxisPosition` is the distance in the [AxisDirection] (after
        /// applying the [GrowthDirection]) from the edge of the sliver's painted
        /// area. This can be an unusual direction, for example in the
        /// [AxisDirection.up] case this is a distance from the _bottom_ of the
        /// sliver's painted area.
        ///
        /// The `crossAxisPosition` is the distance in the other axis. If the cross
        /// axis is horizontal (i.e. the [SliverConstraints.axisDirection] is either
        /// [AxisDirection.down] or [AxisDirection.up]), then the `crossAxisPosition`
        /// is a distance from the left edge of the sliver. If the cross axis is
        /// vertical (i.e. the [SliverConstraints.axisDirection] is either
        /// [AxisDirection.right] or [AxisDirection.left]), then the
        /// `crossAxisPosition` is a distance from the top edge of the sliver.
        ///
        /// ## Implementing hit testing for slivers
        ///
        /// The most straight-forward way to implement hit testing for a new sliver
        /// render object is to override its [hitTestSelf] and [hitTestChildren]
        /// methods.
        /// </Summary>
        public virtual bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        {
            if (mainAxisPosition >= 0.0 && mainAxisPosition < Geometry.HitTestExtent && crossAxisPosition >= 0.0 && crossAxisPosition < Constraints.CrossAxisExtent)
            {
                if (HitTestChildren(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition) || HitTestSelf(mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition))
                {
                    result.Add(new SliverHitTestEntry(this, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition));
                    return true;
                }

            }

            return false;
        }




        /// <Summary>
        /// Override this method if this render object can be hit even if its
        /// children were not hit.
        ///
        /// Used by [hitTest]. If you override [hitTest] and do not call this
        /// function, then you don't need to implement this function.
        ///
        /// For a discussion of the semantics of the arguments, see [hitTest].
        /// </Summary>
        public virtual bool HitTestSelf(double mainAxisPosition = default(double), double crossAxisPosition = default(double)) => false;



        /// <Summary>
        /// Override this method to check whether any children are located at the
        /// given position.
        ///
        /// Typically children should be hit-tested in reverse paint order so that
        /// hit tests at locations where children overlap hit the child that is
        /// visually "on top" (i.e., paints later).
        ///
        /// Used by [hitTest]. If you override [hitTest] and do not call this
        /// function, then you don't need to implement this function.
        ///
        /// For a discussion of the semantics of the arguments, see [hitTest].
        /// </Summary>
        public virtual bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) => false;



        /// <Summary>
        /// Computes the portion of the region from `from` to `to` that is visible,
        /// assuming that only the region from the [SliverConstraints.scrollOffset]
        /// that is [SliverConstraints.remainingPaintExtent] high is visible, and that
        /// the relationship between scroll offsets and paint offsets is linear.
        ///
        /// For example, if the constraints have a scroll offset of 100 and a
        /// remaining paint extent of 100, and the arguments to this method describe
        /// the region 50..150, then the returned value would be 50 (from scroll
        /// offset 100 to scroll offset 150).
        ///
        /// This method is not useful if there is not a 1:1 relationship between
        /// consumed scroll offset and consumed paint extent. For example, if the
        /// sliver always paints the same amount but consumes a scroll offset extent
        /// that is proportional to the [SliverConstraints.scrollOffset], then this
        /// function's results will not be consistent.
        /// </Summary>
        public virtual double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double))
        {

            double a = constraints.ScrollOffset;
            double b = constraints.ScrollOffset + constraints.RemainingPaintExtent;
            return (to.Clamp(a, b) - from.Clamp(a, b)).Clamp(0.0, constraints.RemainingPaintExtent) as double;
        }




        /// <Summary>
        /// Computes the portion of the region from `from` to `to` that is within
        /// the cache extent of the viewport, assuming that only the region from the
        /// [SliverConstraints.cacheOrigin] that is
        /// [SliverConstraints.remainingCacheExtent] high is visible, and that
        /// the relationship between scroll offsets and paint offsets is linear.
        ///
        /// This method is not useful if there is not a 1:1 relationship between
        /// consumed scroll offset and consumed cache extent.
        /// </Summary>
        public virtual double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double))
        {

            double a = constraints.ScrollOffset + constraints.CacheOrigin;
            double b = constraints.ScrollOffset + constraints.RemainingCacheExtent;
            return (to.Clamp(a, b) - from.Clamp(a, b)).Clamp(0.0, constraints.RemainingCacheExtent) as double;
        }




        /// <Summary>
        /// Returns the distance from the leading _visible_ edge of the sliver to the
        /// side of the given child closest to that edge.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the top
        /// of the visible portion of the sliver to the top of the child. On the other
        /// hand, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.up], then this is the distance from the bottom
        /// of the visible portion of the sliver to the bottom of the child. In both
        /// cases, this is the direction of increasing
        /// [SliverConstraints.scrollOffset] and
        /// [SliverLogicalParentData.layoutOffset].
        ///
        /// For children that are [RenderSliver]s, the leading edge of the _child_
        /// will be the leading _visible_ edge of the child, not the part of the child
        /// that would locally be a scroll offset 0.0. For children that are not
        /// [RenderSliver]s, for example a [RenderBox] child, it's the actual distance
        /// to the edge of the box, since those boxes do not know how to handle being
        /// scrolled.
        ///
        /// This method differs from [childScrollOffset] in that
        /// [childMainAxisPosition] gives the distance from the leading _visible_ edge
        /// of the sliver whereas [childScrollOffset] gives the distance from the
        /// sliver's zero scroll offset.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return 0.0;
        }




        /// <Summary>
        /// Returns the distance along the cross axis from the zero of the cross axis
        /// in this sliver's [paint] coordinate space to the nearest side of the given
        /// child.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the left
        /// of the sliver to the left of the child. Similarly, if the [constraints]
        /// describe this sliver as having an axis direction of [AxisDirection.up],
        /// then this is value is the same. If the axis direction is
        /// [AxisDirection.left] or [AxisDirection.right], then it is the distance
        /// from the top of the sliver to the top of the child.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) => 0.0;



        /// <Summary>
        /// Returns the scroll offset for the leading edge of the given child.
        ///
        /// The `child` must be a child of this sliver.
        ///
        /// This method differs from [childMainAxisPosition] in that
        /// [childMainAxisPosition] gives the distance from the leading _visible_ edge
        /// of the sliver whereas [childScrollOffset] gives the distance from sliver's
        /// zero scroll offset.
        /// </Summary>
        public virtual double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return 0.0;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {

        }




        /// <Summary>
        /// This returns a [Size] with dimensions relative to the leading edge of the
        /// sliver, specifically the same offset that is given to the [paint] method.
        /// This means that the dimensions may be negative.
        ///
        /// This is only valid after [layout] has completed.
        ///
        /// See also:
        ///
        ///  * [getAbsoluteSize], which returns absolute size.
        /// </Summary>
        public virtual Size GetAbsoluteSizeRelativeToOrigin()
        {


            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(Constraints.AxisDirection, Constraints.GrowthDirection)) { case AxisDirection.Up: return new Size(Constraints.CrossAxisExtent, -Geometry.PaintExtent); case AxisDirection.Right: return new Size(Geometry.PaintExtent, Constraints.CrossAxisExtent); case AxisDirection.Down: return new Size(Constraints.CrossAxisExtent, Geometry.PaintExtent); case AxisDirection.Left: return new Size(-Geometry.PaintExtent, Constraints.CrossAxisExtent); }
            return null;
        }




        /// <Summary>
        /// This returns the absolute [Size] of the sliver.
        ///
        /// The dimensions are always positive and calling this is only valid after
        /// [layout] has completed.
        ///
        /// See also:
        ///
        ///  * [getAbsoluteSizeRelativeToOrigin], which returns the size relative to
        ///    the leading edge of the sliver.
        /// </Summary>
        public virtual Size GetAbsoluteSize()
        {


            switch (Constraints.AxisDirection) { case AxisDirection.Up: case AxisDirection.Down: return new Size(Constraints.CrossAxisExtent, Geometry.PaintExtent); case AxisDirection.Right: case AxisDirection.Left: return new Size(Geometry.PaintExtent, Constraints.CrossAxisExtent); }
            return null;
        }




        private void _DebugDrawArrow(Canvas canvas, SKPaint paint, FlutterBinding.UI.Offset p0, FlutterBinding.UI.Offset p1, FlutterSDK.Rendering.Sliver.GrowthDirection direction)
        {

        }




        public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry)
        {
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<SliverGeometry>("geometry", Geometry));
        }



    }
    public static class RenderSliverHelpersMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverHelpers, RenderSliverHelpers> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverHelpers, RenderSliverHelpers>();
        static RenderSliverHelpers GetOrCreate(IRenderSliverHelpers instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderSliverHelpers();
                _table.Add(instance, value);
            }
            return (RenderSliverHelpers)value;
        }
        public static bool HitTestBoxChild(this IRenderSliverHelpers instance, FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterSDK.Rendering.Box.RenderBox child, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) => GetOrCreate(instance).HitTestBoxChild(result, child, mainAxisPosition, crossAxisPosition);
        public static void ApplyPaintTransformForBoxChild(this IRenderSliverHelpers instance, FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform) => GetOrCreate(instance).ApplyPaintTransformForBoxChild(child, transform);
    }


    /// <Summary>
    /// Immutable layout constraints for [RenderSliver] layout.
    ///
    /// The [SliverConstraints] describe the current scroll state of the viewport
    /// from the point of view of the sliver receiving the constraints. For example,
    /// a [scrollOffset] of zero means that the leading edge of the sliver is
    /// visible in the viewport, not that the viewport itself has a zero scroll
    /// offset.
    /// </Summary>
    public class SliverConstraints : FlutterSDK.Rendering.@object.Constraints
    {
        #region constructors
        public SliverConstraints(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection), FlutterSDK.Rendering.Viewportoffset.ScrollDirection userScrollDirection = default(FlutterSDK.Rendering.Viewportoffset.ScrollDirection), double scrollOffset = default(double), double precedingScrollExtent = default(double), double overlap = default(double), double remainingPaintExtent = default(double), double crossAxisExtent = default(double), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double viewportMainAxisExtent = default(double), double remainingCacheExtent = default(double), double cacheOrigin = default(double))
        : base()
        {
            this.AxisDirection = axisDirection;
            this.GrowthDirection = growthDirection;
            this.UserScrollDirection = userScrollDirection;
            this.ScrollOffset = scrollOffset;
            this.PrecedingScrollExtent = precedingScrollExtent;
            this.Overlap = overlap;
            this.RemainingPaintExtent = remainingPaintExtent;
            this.CrossAxisExtent = crossAxisExtent;
            this.CrossAxisDirection = crossAxisDirection;
            this.ViewportMainAxisExtent = viewportMainAxisExtent;
            this.RemainingCacheExtent = remainingCacheExtent;
            this.CacheOrigin = cacheOrigin;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        public virtual FlutterSDK.Rendering.Sliver.GrowthDirection GrowthDirection { get; set; }
        public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection { get; set; }
        public virtual double ScrollOffset { get; set; }
        public virtual double PrecedingScrollExtent { get; set; }
        public virtual double Overlap { get; set; }
        public virtual double RemainingPaintExtent { get; set; }
        public virtual double CrossAxisExtent { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get; set; }
        public virtual double ViewportMainAxisExtent { get; set; }
        public virtual double CacheOrigin { get; set; }
        public virtual double RemainingCacheExtent { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliver.GrowthDirection NormalizedGrowthDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsTight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNormalized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Sliver.SliverConstraints CopyWith(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection), FlutterSDK.Rendering.Viewportoffset.ScrollDirection userScrollDirection = default(FlutterSDK.Rendering.Viewportoffset.ScrollDirection), double scrollOffset = default(double), double precedingScrollExtent = default(double), double overlap = default(double), double remainingPaintExtent = default(double), double crossAxisExtent = default(double), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double viewportMainAxisExtent = default(double), double remainingCacheExtent = default(double), double cacheOrigin = default(double))
        {
            return new SliverConstraints(axisDirection: axisDirection ?? this.AxisDirection, growthDirection: growthDirection ?? this.GrowthDirection, userScrollDirection: userScrollDirection ?? this.UserScrollDirection, scrollOffset: scrollOffset == default(double) ? this.scrollOffset : scrollOffset, precedingScrollExtent: precedingScrollExtent == default(double) ? this.precedingScrollExtent : precedingScrollExtent, overlap: overlap == default(double) ? this.overlap : overlap, remainingPaintExtent: remainingPaintExtent == default(double) ? this.remainingPaintExtent : remainingPaintExtent, crossAxisExtent: crossAxisExtent == default(double) ? this.crossAxisExtent : crossAxisExtent, crossAxisDirection: crossAxisDirection ?? this.CrossAxisDirection, viewportMainAxisExtent: viewportMainAxisExtent == default(double) ? this.viewportMainAxisExtent : viewportMainAxisExtent, remainingCacheExtent: remainingCacheExtent == default(double) ? this.remainingCacheExtent : remainingCacheExtent, cacheOrigin: cacheOrigin == default(double) ? this.cacheOrigin : cacheOrigin);
        }




        /// <Summary>
        /// Returns [BoxConstraints] that reflects the sliver constraints.
        ///
        /// The `minExtent` and `maxExtent` are used as the constraints in the main
        /// axis. If non-null, the given `crossAxisExtent` is used as a tight
        /// constraint in the cross axis. Otherwise, the [crossAxisExtent] from this
        /// object is used as a constraint in the cross axis.
        ///
        /// Useful for slivers that have [RenderBox] children.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints AsBoxConstraints(double minExtent = 0.0, double maxExtent = default(double), double crossAxisExtent = default(double))
        {
            crossAxisExtent = (crossAxisExtent == null ? this.CrossAxisExtent : crossAxisExtent);
            switch (Axis) { case Axis.Horizontal: return new BoxConstraints(minHeight: crossAxisExtent, maxHeight: crossAxisExtent, minWidth: minExtent, maxWidth: maxExtent); case Axis.Vertical: return new BoxConstraints(minWidth: crossAxisExtent, maxWidth: crossAxisExtent, minHeight: minExtent, maxHeight: maxExtent); }
            return null;
        }




        public new bool DebugAssertIsValid(bool isAppliedConstraint = false, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
        {

            return true;
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (!(other is SliverConstraints)) return false;

            return other is SliverConstraints && other.AxisDirection == AxisDirection && other.GrowthDirection == GrowthDirection && other.ScrollOffset == ScrollOffset && other.Overlap == Overlap && other.RemainingPaintExtent == RemainingPaintExtent && other.CrossAxisExtent == CrossAxisExtent && other.CrossAxisDirection == CrossAxisDirection && other.ViewportMainAxisExtent == ViewportMainAxisExtent && other.RemainingCacheExtent == RemainingCacheExtent && other.CacheOrigin == CacheOrigin;
        }




        #endregion
    }


    /// <Summary>
    /// Describes the amount of space occupied by a [RenderSliver].
    ///
    /// A sliver can occupy space in several different ways, which is why this class
    /// contains multiple values.
    /// </Summary>
    public class SliverGeometry : IDiagnosticable
    {
        #region constructors
        public SliverGeometry(double scrollExtent = 0.0, double paintExtent = 0.0, double paintOrigin = 0.0, double layoutExtent = default(double), double maxPaintExtent = 0.0, double maxScrollObstructionExtent = 0.0, double hitTestExtent = default(double), bool visible = default(bool), bool hasVisualOverflow = false, double scrollOffsetCorrection = default(double), double cacheExtent = default(double))
        : base()
        {
            this.ScrollExtent = scrollExtent;
            this.PaintExtent = paintExtent;
            this.PaintOrigin = paintOrigin;
            this.MaxPaintExtent = maxPaintExtent;
            this.MaxScrollObstructionExtent = maxScrollObstructionExtent;
            this.HasVisualOverflow = hasVisualOverflow;
            this.ScrollOffsetCorrection = scrollOffsetCorrection;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Zero { get; set; }
        public virtual double ScrollExtent { get; set; }
        public virtual double PaintOrigin { get; set; }
        public virtual double PaintExtent { get; set; }
        public virtual double LayoutExtent { get; set; }
        public virtual double MaxPaintExtent { get; set; }
        public virtual double MaxScrollObstructionExtent { get; set; }
        public virtual double HitTestExtent { get; set; }
        public virtual bool Visible { get; set; }
        public virtual bool HasVisualOverflow { get; set; }
        public virtual double ScrollOffsetCorrection { get; set; }
        public virtual double CacheExtent { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Asserts that this geometry is internally consistent.
        ///
        /// Does nothing if asserts are disabled. Always returns true.
        /// </Summary>
        public virtual bool DebugAssertIsValid(FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
        {

            return true;
        }




        public new string ToStringShort() => ObjectDefaultClass.ObjectRuntimeType(this, "SliverGeometry");



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("scrollExtent", ScrollExtent));
            if (PaintExtent > 0.0)
            {
                properties.Add(new DoubleProperty("paintExtent", PaintExtent, unit: Visible ? null : " but not painting"));
            }
            else if (PaintExtent == 0.0)
            {
                if (Visible)
                {
                    properties.Add(new DoubleProperty("paintExtent", PaintExtent, unit: Visible ? null : " but visible"));
                }

                properties.Add(new FlagProperty("visible", value: Visible, ifFalse: "hidden"));
            }
            else
            {
                properties.Add(new DoubleProperty("paintExtent", PaintExtent, tooltip: '!'));
            }

            properties.Add(new DoubleProperty("paintOrigin", PaintOrigin, defaultValue: 0.0));
            properties.Add(new DoubleProperty("layoutExtent", LayoutExtent, defaultValue: PaintExtent));
            properties.Add(new DoubleProperty("maxPaintExtent", MaxPaintExtent));
            properties.Add(new DoubleProperty("hitTestExtent", HitTestExtent, defaultValue: PaintExtent));
            properties.Add(new DiagnosticsProperty<bool>("hasVisualOverflow", HasVisualOverflow, defaultValue: false));
            properties.Add(new DoubleProperty("scrollOffsetCorrection", ScrollOffsetCorrection, defaultValue: null));
            properties.Add(new DoubleProperty("cacheExtent", CacheExtent, defaultValue: 0.0));
        }



        #endregion
    }


    /// <Summary>
    /// The result of performing a hit test on [RenderSliver]s.
    ///
    /// An instance of this class is provided to [RenderSliver.hitTest] to record
    /// the result of the hit test.
    /// </Summary>
    public class SliverHitTestResult : FlutterSDK.Gestures.Hittest.HitTestResult
    {
        #region constructors
        public SliverHitTestResult()
        : base()
        {

        }
        public static SliverHitTestResult Wrap(FlutterSDK.Gestures.Hittest.HitTestResult result)
        {
            var instance = new SliverHitTestResult(result);
        }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// Transforms `mainAxisPosition` and `crossAxisPosition` to the local
        /// coordinate system of a child for hit-testing the child.
        ///
        /// The actual hit testing of the child needs to be implemented in the
        /// provided `hitTest` callback, which is invoked with the transformed
        /// `position` as argument.
        ///
        /// For the transform `mainAxisOffset` is subtracted from `mainAxisPosition`
        /// and `crossAxisOffset` is subtracted from `crossAxisPosition`.
        ///
        /// The `paintOffset` describes how the paint position of a point painted at
        /// the provided `mainAxisPosition` and `crossAxisPosition` would change after
        /// `mainAxisOffset` and `crossAxisOffset` have been applied. This
        /// `paintOffset` is used to properly convert [PointerEvent]s to the local
        /// coordinate system of the event receiver.
        ///
        /// The `paintOffset` may be null if `mainAxisOffset` and `crossAxisOffset` are
        /// both zero.
        ///
        /// The function returns the return value of `hitTest`.
        /// </Summary>
        public virtual bool AddWithAxisOffset(FlutterBinding.UI.Offset paintOffset = default(FlutterBinding.UI.Offset), double mainAxisOffset = default(double), double crossAxisOffset = default(double), double mainAxisPosition = default(double), double crossAxisPosition = default(double), FlutterSDK.Rendering.Sliver.SliverHitTest hitTest = default(FlutterSDK.Rendering.Sliver.SliverHitTest))
        {





            if (paintOffset != null)
            {
                PushTransform(Matrix4.TranslationValues(-paintOffset.Dx, -paintOffset.Dy, 0));
            }

            bool isHit = hitTest(this, mainAxisPosition: mainAxisPosition - mainAxisOffset, crossAxisPosition: crossAxisPosition - crossAxisOffset);
            if (paintOffset != null)
            {
                PopTransform();
            }

            return isHit;
        }



        #endregion
    }


    /// <Summary>
    /// A hit test entry used by [RenderSliver].
    ///
    /// The coordinate system used by this hit test entry is relative to the
    /// [AxisDirection] of the target sliver.
    /// </Summary>
    public class SliverHitTestEntry : FlutterSDK.Gestures.Hittest.HitTestEntry
    {
        #region constructors
        public SliverHitTestEntry(FlutterSDK.Rendering.Sliver.RenderSliver target, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        : base(target)
        {
            this.MainAxisPosition = mainAxisPosition;
            this.CrossAxisPosition = crossAxisPosition;
        }
        #endregion

        #region fields
        public virtual double MainAxisPosition { get; set; }
        public virtual double CrossAxisPosition { get; set; }
        public virtual FlutterSDK.Rendering.Sliver.RenderSliver Target { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Parent data structure used by parents of slivers that position their
    /// children using layout offsets.
    ///
    /// This data structure is optimized for fast layout. It is best used by parents
    /// that expect to have many children whose relative positions don't change even
    /// when the scroll offset does.
    /// </Summary>
    public class SliverLogicalParentData : FlutterSDK.Rendering.@object.ParentData
    {
        #region constructors
        public SliverLogicalParentData()
        { }
        #endregion

        #region fields
        public virtual double LayoutOffset { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Parent data for slivers that have multiple children and that position their
    /// children using layout offsets.
    /// </Summary>
    public class SliverLogicalContainerParentData : FlutterSDK.Rendering.Sliver.SliverLogicalParentData, IContainerParentDataMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
    {
        #region constructors
        public SliverLogicalContainerParentData()
        { }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// Parent data structure used by parents of slivers that position their
    /// children using absolute coordinates.
    ///
    /// For example, used by [RenderViewport].
    ///
    /// This data structure is optimized for fast painting, at the cost of requiring
    /// additional work during layout when the children change their offsets. It is
    /// best used by parents that expect to have few children, especially if those
    /// children will themselves be very tall relative to the parent.
    /// </Summary>
    public class SliverPhysicalParentData : FlutterSDK.Rendering.@object.ParentData
    {
        #region constructors
        public SliverPhysicalParentData()
        { }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Offset PaintOffset { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Apply the [paintOffset] to the given [transform].
        ///
        /// Used to implement [RenderObject.applyPaintTransform] by slivers that use
        /// [SliverPhysicalParentData].
        /// </Summary>
        public virtual void ApplyPaintTransform(Matrix4 transform)
        {
            transform.Translate(PaintOffset.Dx, PaintOffset.Dy);
        }




        #endregion
    }


    /// <Summary>
    /// Parent data for slivers that have multiple children and that position their
    /// children using absolute coordinates.
    /// </Summary>
    public class SliverPhysicalContainerParentData : FlutterSDK.Rendering.Sliver.SliverPhysicalParentData, IContainerParentDataMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
    {
        #region constructors
        public SliverPhysicalContainerParentData()
        { }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// Base class for the render objects that implement scroll effects in viewports.
    ///
    /// A [RenderViewport] has a list of child slivers. Each sliver — literally a
    /// slice of the viewport's contents — is laid out in turn, covering the
    /// viewport in the process. (Every sliver is laid out each time, including
    /// those that have zero extent because they are "scrolled off" or are beyond
    /// the end of the viewport.)
    ///
    /// Slivers participate in the _sliver protocol_, wherein during [layout] each
    /// sliver receives a [SliverConstraints] object and computes a corresponding
    /// [SliverGeometry] that describes where it fits in the viewport. This is
    /// analogous to the box protocol used by [RenderBox], which gets a
    /// [BoxConstraints] as input and computes a [Size].
    ///
    /// Slivers have a leading edge, which is where the position described by
    /// [SliverConstraints.scrollOffset] for this sliver begins. Slivers have
    /// several dimensions, the primary of which is [SliverGeometry.paintExtent],
    /// which describes the extent of the sliver along the main axis, starting from
    /// the leading edge, reaching either the end of the viewport or the end of the
    /// sliver, whichever comes first.
    ///
    /// Slivers can change dimensions based on the changing constraints in a
    /// non-linear fashion, to achieve various scroll effects. For example, the
    /// various [RenderSliverPersistentHeader] subclasses, on which [SliverAppBar]
    /// is based, achieve effects such as staying visible despite the scroll offset,
    /// or reappearing at different offsets based on the user's scroll direction
    /// ([SliverConstraints.userScrollDirection]).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=Mz3kHQxBjGg}
    ///
    /// ## Writing a RenderSliver subclass
    ///
    /// Slivers can have sliver children, or children from another coordinate
    /// system, typically box children. (For details on the box protocol, see
    /// [RenderBox].) Slivers can also have different child models, typically having
    /// either one child, or a list of children.
    ///
    /// ### Examples of slivers
    ///
    /// A good example of a sliver with a single child that is also itself a sliver
    /// is [RenderSliverPadding], which indents its child. A sliver-to-sliver render
    /// object such as this must construct a [SliverConstraints] object for its
    /// child, then must take its child's [SliverGeometry] and use it to form its
    /// own [geometry].
    ///
    /// The other common kind of one-child sliver is a sliver that has a single
    /// [RenderBox] child. An example of that would be [RenderSliverToBoxAdapter],
    /// which lays out a single box and sizes itself around the box. Such a sliver
    /// must use its [SliverConstraints] to create a [BoxConstraints] for the
    /// child, lay the child out (using the child's [layout] method), and then use
    /// the child's [RenderBox.size] to generate the sliver's [SliverGeometry].
    ///
    /// The most common kind of sliver though is one with multiple children. The
    /// most straight-forward example of this is [RenderSliverList], which arranges
    /// its children one after the other in the main axis direction. As with the
    /// one-box-child sliver case, it uses its [constraints] to create a
    /// [BoxConstraints] for the children, and then it uses the aggregate
    /// information from all its children to generate its [geometry]. Unlike the
    /// one-child cases, however, it is judicious in which children it actually lays
    /// out (and later paints). If the scroll offset is 1000 pixels, and it
    /// previously determined that the first three children are each 400 pixels
    /// tall, then it will skip the first two and start the layout with its third
    /// child.
    ///
    /// ### Layout
    ///
    /// As they are laid out, slivers decide their [geometry], which includes their
    /// size ([SliverGeometry.paintExtent]) and the position of the next sliver
    /// ([SliverGeometry.layoutExtent]), as well as the position of each of their
    /// children, based on the input [constraints] from the viewport such as the
    /// scroll offset ([SliverConstraints.scrollOffset]).
    ///
    /// For example, a sliver that just paints a box 100 pixels high would say its
    /// [SliverGeometry.paintExtent] was 100 pixels when the scroll offset was zero,
    /// but would say its [SliverGeometry.paintExtent] was 25 pixels when the scroll
    /// offset was 75 pixels, and would say it was zero when the scroll offset was
    /// 100 pixels or more. (This is assuming that
    /// [SliverConstraints.remainingPaintExtent] was more than 100 pixels.)
    ///
    /// The various dimensions that are provided as input to this system are in the
    /// [constraints]. They are described in detail in the documentation for the
    /// [SliverConstraints] class.
    ///
    /// The [performLayout] function must take these [constraints] and create a
    /// [SliverGeometry] object that it must then assign to the [geometry] property.
    /// The different dimensions of the geometry that can be configured are
    /// described in detail in the documentation for the [SliverGeometry] class.
    ///
    /// ### Painting
    ///
    /// In addition to implementing layout, a sliver must also implement painting.
    /// This is achieved by overriding the [paint] method.
    ///
    /// The [paint] method is called with an [Offset] from the [Canvas] origin to
    /// the top-left corner of the sliver, _regardless of the axis direction_.
    ///
    /// Subclasses should also override [applyPaintTransform] to provide the
    /// [Matrix4] describing the position of each child relative to the sliver.
    /// (This is used by, among other things, the accessibility layer, to determine
    /// the bounds of the child.)
    ///
    /// ### Hit testing
    ///
    /// To implement hit testing, either override the [hitTestSelf] and
    /// [hitTestChildren] methods, or, for more complex cases, instead override the
    /// [hitTest] method directly.
    ///
    /// To actually react to pointer events, the [handleEvent] method may be
    /// implemented. By default it does nothing. (Typically gestures are handled by
    /// widgets in the box protocol, not by slivers directly.)
    ///
    /// ### Helper methods
    ///
    /// There are a number of methods that a sliver should implement which will make
    /// the other methods easier to implement. Each method listed below has detailed
    /// documentation. In addition, the [RenderSliverHelpers] class can be used to
    /// mix in some helpful methods.
    ///
    /// #### childScrollOffset
    ///
    /// If the subclass positions children anywhere other than at scroll offset
    /// zero, it should override [childScrollOffset]. For example,
    /// [RenderSliverList] and [RenderSliverGrid] override this method, but
    /// [RenderSliverToBoxAdapter] does not.
    ///
    /// This is used by, among other things, [Scrollable.ensureVisible].
    ///
    /// #### childMainAxisPosition
    ///
    /// Subclasses should implement [childMainAxisPosition] to describe where their
    /// children are positioned.
    ///
    /// #### childCrossAxisPosition
    ///
    /// If the subclass positions children in the cross-axis at a position other
    /// than zero, then it should override [childCrossAxisPosition]. For example
    /// [RenderSliverGrid] overrides this method.
    /// </Summary>
    public class RenderSliver : FlutterSDK.Rendering.@object.RenderObject
    {
        #region constructors
        public RenderSliver()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Sliver.SliverGeometry _Geometry { get; set; }
        public virtual FlutterSDK.Rendering.Sliver.SliverConstraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Geometry { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect SemanticBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect PaintBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CenterOffsetAdjustment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DebugResetSize()
        {
        }




        public new void DebugAssertDoesMeetConstraints()
        {


        }




        public new void PerformResize()
        {

        }




        /// <Summary>
        /// Determines the set of render objects located at the given position.
        ///
        /// Returns true if the given point is contained in this render object or one
        /// of its descendants. Adds any render objects that contain the point to the
        /// given hit test result.
        ///
        /// The caller is responsible for providing the position in the local
        /// coordinate space of the callee. The callee is responsible for checking
        /// whether the given position is within its bounds.
        ///
        /// Hit testing requires layout to be up-to-date but does not require painting
        /// to be up-to-date. That means a render object can rely upon [performLayout]
        /// having been called in [hitTest] but cannot rely upon [paint] having been
        /// called. For example, a render object might be a child of a [RenderOpacity]
        /// object, which calls [hitTest] on its children when its opacity is zero
        /// even through it does not [paint] its children.
        ///
        /// ## Coordinates for RenderSliver objects
        ///
        /// The `mainAxisPosition` is the distance in the [AxisDirection] (after
        /// applying the [GrowthDirection]) from the edge of the sliver's painted
        /// area. This can be an unusual direction, for example in the
        /// [AxisDirection.up] case this is a distance from the _bottom_ of the
        /// sliver's painted area.
        ///
        /// The `crossAxisPosition` is the distance in the other axis. If the cross
        /// axis is horizontal (i.e. the [SliverConstraints.axisDirection] is either
        /// [AxisDirection.down] or [AxisDirection.up]), then the `crossAxisPosition`
        /// is a distance from the left edge of the sliver. If the cross axis is
        /// vertical (i.e. the [SliverConstraints.axisDirection] is either
        /// [AxisDirection.right] or [AxisDirection.left]), then the
        /// `crossAxisPosition` is a distance from the top edge of the sliver.
        ///
        /// ## Implementing hit testing for slivers
        ///
        /// The most straight-forward way to implement hit testing for a new sliver
        /// render object is to override its [hitTestSelf] and [hitTestChildren]
        /// methods.
        /// </Summary>
        public virtual bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        {
            if (mainAxisPosition >= 0.0 && mainAxisPosition < Geometry.HitTestExtent && crossAxisPosition >= 0.0 && crossAxisPosition < Constraints.CrossAxisExtent)
            {
                if (HitTestChildren(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition) || HitTestSelf(mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition))
                {
                    result.Add(new SliverHitTestEntry(this, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition));
                    return true;
                }

            }

            return false;
        }




        /// <Summary>
        /// Override this method if this render object can be hit even if its
        /// children were not hit.
        ///
        /// Used by [hitTest]. If you override [hitTest] and do not call this
        /// function, then you don't need to implement this function.
        ///
        /// For a discussion of the semantics of the arguments, see [hitTest].
        /// </Summary>
        public virtual bool HitTestSelf(double mainAxisPosition = default(double), double crossAxisPosition = default(double)) => false;



        /// <Summary>
        /// Override this method to check whether any children are located at the
        /// given position.
        ///
        /// Typically children should be hit-tested in reverse paint order so that
        /// hit tests at locations where children overlap hit the child that is
        /// visually "on top" (i.e., paints later).
        ///
        /// Used by [hitTest]. If you override [hitTest] and do not call this
        /// function, then you don't need to implement this function.
        ///
        /// For a discussion of the semantics of the arguments, see [hitTest].
        /// </Summary>
        public virtual bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) => false;



        /// <Summary>
        /// Computes the portion of the region from `from` to `to` that is visible,
        /// assuming that only the region from the [SliverConstraints.scrollOffset]
        /// that is [SliverConstraints.remainingPaintExtent] high is visible, and that
        /// the relationship between scroll offsets and paint offsets is linear.
        ///
        /// For example, if the constraints have a scroll offset of 100 and a
        /// remaining paint extent of 100, and the arguments to this method describe
        /// the region 50..150, then the returned value would be 50 (from scroll
        /// offset 100 to scroll offset 150).
        ///
        /// This method is not useful if there is not a 1:1 relationship between
        /// consumed scroll offset and consumed paint extent. For example, if the
        /// sliver always paints the same amount but consumes a scroll offset extent
        /// that is proportional to the [SliverConstraints.scrollOffset], then this
        /// function's results will not be consistent.
        /// </Summary>
        public virtual double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double))
        {

            double a = constraints.ScrollOffset;
            double b = constraints.ScrollOffset + constraints.RemainingPaintExtent;
            return (to.Clamp(a, b) - from.Clamp(a, b)).Clamp(0.0, constraints.RemainingPaintExtent) as double;
        }




        /// <Summary>
        /// Computes the portion of the region from `from` to `to` that is within
        /// the cache extent of the viewport, assuming that only the region from the
        /// [SliverConstraints.cacheOrigin] that is
        /// [SliverConstraints.remainingCacheExtent] high is visible, and that
        /// the relationship between scroll offsets and paint offsets is linear.
        ///
        /// This method is not useful if there is not a 1:1 relationship between
        /// consumed scroll offset and consumed cache extent.
        /// </Summary>
        public virtual double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, double from = default(double), double to = default(double))
        {

            double a = constraints.ScrollOffset + constraints.CacheOrigin;
            double b = constraints.ScrollOffset + constraints.RemainingCacheExtent;
            return (to.Clamp(a, b) - from.Clamp(a, b)).Clamp(0.0, constraints.RemainingCacheExtent) as double;
        }




        /// <Summary>
        /// Returns the distance from the leading _visible_ edge of the sliver to the
        /// side of the given child closest to that edge.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the top
        /// of the visible portion of the sliver to the top of the child. On the other
        /// hand, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.up], then this is the distance from the bottom
        /// of the visible portion of the sliver to the bottom of the child. In both
        /// cases, this is the direction of increasing
        /// [SliverConstraints.scrollOffset] and
        /// [SliverLogicalParentData.layoutOffset].
        ///
        /// For children that are [RenderSliver]s, the leading edge of the _child_
        /// will be the leading _visible_ edge of the child, not the part of the child
        /// that would locally be a scroll offset 0.0. For children that are not
        /// [RenderSliver]s, for example a [RenderBox] child, it's the actual distance
        /// to the edge of the box, since those boxes do not know how to handle being
        /// scrolled.
        ///
        /// This method differs from [childScrollOffset] in that
        /// [childMainAxisPosition] gives the distance from the leading _visible_ edge
        /// of the sliver whereas [childScrollOffset] gives the distance from the
        /// sliver's zero scroll offset.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return 0.0;
        }




        /// <Summary>
        /// Returns the distance along the cross axis from the zero of the cross axis
        /// in this sliver's [paint] coordinate space to the nearest side of the given
        /// child.
        ///
        /// For example, if the [constraints] describe this sliver as having an axis
        /// direction of [AxisDirection.down], then this is the distance from the left
        /// of the sliver to the left of the child. Similarly, if the [constraints]
        /// describe this sliver as having an axis direction of [AxisDirection.up],
        /// then this is value is the same. If the axis direction is
        /// [AxisDirection.left] or [AxisDirection.right], then it is the distance
        /// from the top of the sliver to the top of the child.
        ///
        /// Calling this for a child that is not visible is not valid.
        /// </Summary>
        public virtual double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child) => 0.0;



        /// <Summary>
        /// Returns the scroll offset for the leading edge of the given child.
        ///
        /// The `child` must be a child of this sliver.
        ///
        /// This method differs from [childMainAxisPosition] in that
        /// [childMainAxisPosition] gives the distance from the leading _visible_ edge
        /// of the sliver whereas [childScrollOffset] gives the distance from sliver's
        /// zero scroll offset.
        /// </Summary>
        public virtual double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child)
        {

            return 0.0;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {

        }




        /// <Summary>
        /// This returns a [Size] with dimensions relative to the leading edge of the
        /// sliver, specifically the same offset that is given to the [paint] method.
        /// This means that the dimensions may be negative.
        ///
        /// This is only valid after [layout] has completed.
        ///
        /// See also:
        ///
        ///  * [getAbsoluteSize], which returns absolute size.
        /// </Summary>
        public virtual Size GetAbsoluteSizeRelativeToOrigin()
        {


            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(Constraints.AxisDirection, Constraints.GrowthDirection)) { case AxisDirection.Up: return new Size(Constraints.CrossAxisExtent, -Geometry.PaintExtent); case AxisDirection.Right: return new Size(Geometry.PaintExtent, Constraints.CrossAxisExtent); case AxisDirection.Down: return new Size(Constraints.CrossAxisExtent, Geometry.PaintExtent); case AxisDirection.Left: return new Size(-Geometry.PaintExtent, Constraints.CrossAxisExtent); }
            return null;
        }




        /// <Summary>
        /// This returns the absolute [Size] of the sliver.
        ///
        /// The dimensions are always positive and calling this is only valid after
        /// [layout] has completed.
        ///
        /// See also:
        ///
        ///  * [getAbsoluteSizeRelativeToOrigin], which returns the size relative to
        ///    the leading edge of the sliver.
        /// </Summary>
        public virtual Size GetAbsoluteSize()
        {


            switch (Constraints.AxisDirection) { case AxisDirection.Up: case AxisDirection.Down: return new Size(Constraints.CrossAxisExtent, Geometry.PaintExtent); case AxisDirection.Right: case AxisDirection.Left: return new Size(Geometry.PaintExtent, Constraints.CrossAxisExtent); }
            return null;
        }




        private void _DebugDrawArrow(Canvas canvas, SKPaint paint, FlutterBinding.UI.Offset p0, FlutterBinding.UI.Offset p1, FlutterSDK.Rendering.Sliver.GrowthDirection direction)
        {

        }




        public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry)
        {
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<SliverGeometry>("geometry", Geometry));
        }



        #endregion
    }


    /// <Summary>
    /// An abstract class for [RenderSliver]s that contains a single [RenderBox].
    ///
    /// See also:
    ///
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderSliverToBoxAdapter], which extends this class to size the child
    ///    according to its preferred size.
    ///  * [RenderSliverFillRemaining], which extends this class to size the child
    ///    to fill the remaining space in the viewport.
    /// </Summary>
    public class RenderSliverSingleBoxAdapter : FlutterSDK.Rendering.Sliver.RenderSliver, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>, IRenderSliverHelpers
    {
        #region constructors
        public RenderSliverSingleBoxAdapter(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        {

            this.Child = child;
        }


        #endregion

        #region fields
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is SliverPhysicalParentData)) child.ParentData = new SliverPhysicalParentData();
        }




        /// <Summary>
        /// Sets the [SliverPhysicalParentData.paintOffset] for the given child
        /// according to the [SliverConstraints.axisDirection] and
        /// [SliverConstraints.growthDirection] and the given geometry.
        /// </Summary>
        public virtual void SetChildParentData(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Rendering.Sliver.SliverConstraints constraints, FlutterSDK.Rendering.Sliver.SliverGeometry geometry)
        {
            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;


            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(constraints.AxisDirection, constraints.GrowthDirection)) { case AxisDirection.Up: childParentData.PaintOffset = new Offset(0.0, -(geometry.ScrollExtent - (geometry.PaintExtent + constraints.ScrollOffset))); break; case AxisDirection.Right: childParentData.PaintOffset = new Offset(-constraints.ScrollOffset, 0.0); break; case AxisDirection.Down: childParentData.PaintOffset = new Offset(0.0, -constraints.ScrollOffset); break; case AxisDirection.Left: childParentData.PaintOffset = new Offset(-(geometry.ScrollExtent - (geometry.PaintExtent + constraints.ScrollOffset)), 0.0); break; }

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
        {

            if (Child != null) return HitTestBoxChild(BoxHitTestResult.Wrap(result), Child, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
            return false;
        }




        public new double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child)
        {
            return -Constraints.ScrollOffset;
        }


        public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
        {
            return -Constraints.ScrollOffset;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {


            SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
            childParentData.ApplyPaintTransform(transform);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child != null && Geometry.Visible)
            {
                SliverPhysicalParentData childParentData = ((SliverPhysicalParentData)Child.ParentData) as SliverPhysicalParentData;
                context.PaintChild(Child, offset + childParentData.PaintOffset);
            }

        }



        #endregion
    }


    /// <Summary>
    /// A [RenderSliver] that contains a single [RenderBox].
    ///
    /// The child will not be laid out if it is not visible. It is sized according
    /// to the child's preferences in the main axis, and with a tight constraint
    /// forcing it to the dimensions of the viewport in the cross axis.
    ///
    /// See also:
    ///
    ///  * [RenderSliver], which explains more about the Sliver protocol.
    ///  * [RenderBox], which explains more about the Box protocol.
    ///  * [RenderViewport], which allows [RenderSliver] objects to be placed inside
    ///    a [RenderBox] (the opposite of this class).
    /// </Summary>
    public class RenderSliverToBoxAdapter : FlutterSDK.Rendering.Sliver.RenderSliverSingleBoxAdapter
    {
        #region constructors
        public RenderSliverToBoxAdapter(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child: child)
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void PerformLayout()
        {
            if (Child == null)
            {
                Geometry = SliverDefaultClass.SliverGeometry.Zero;
                return;
            }

            SliverConstraints constraints = this.Constraints;
            Child.Layout(constraints.AsBoxConstraints(), parentUsesSize: true);
            double childExtent = default(double);
            switch (constraints.Axis) { case Axis.Horizontal: childExtent = Child.Size.Width; break; case Axis.Vertical: childExtent = Child.Size.Height; break; }

            double paintedChildSize = CalculatePaintOffset(constraints, from: 0.0, to: childExtent);
            double cacheExtent = CalculateCacheOffset(constraints, from: 0.0, to: childExtent);


            Geometry = new SliverGeometry(scrollExtent: childExtent, paintExtent: paintedChildSize, cacheExtent: cacheExtent, maxPaintExtent: childExtent, hitTestExtent: paintedChildSize, hasVisualOverflow: childExtent > constraints.RemainingPaintExtent || constraints.ScrollOffset > 0.0);
            SetChildParentData(Child, constraints, Geometry);
        }



        #endregion
    }


    /// <Summary>
    /// The direction in which a sliver's contents are ordered, relative to the
    /// scroll offset axis.
    ///
    /// For example, a vertical alphabetical list that is going [AxisDirection.down]
    /// with a [GrowthDirection.forward] would have the A at the top and the Z at
    /// the bottom, with the A adjacent to the origin, as would such a list going
    /// [AxisDirection.up] with a [GrowthDirection.reverse]. On the other hand, a
    /// vertical alphabetical list that is going [AxisDirection.down] with a
    /// [GrowthDirection.reverse] would have the Z at the top (at scroll offset
    /// zero) and the A below it.
    ///
    /// The direction in which the scroll offset increases is given by
    /// [applyGrowthDirectionToAxisDirection].
    /// </Summary>
    public enum GrowthDirection
    {

        /// <Summary>
        /// This sliver's contents are ordered in the same direction as the
        /// [AxisDirection].
        /// </Summary>
        Forward,
        /// <Summary>
        /// This sliver's contents are ordered in the opposite direction of the
        /// [AxisDirection].
        /// </Summary>
        Reverse,
    }

}
