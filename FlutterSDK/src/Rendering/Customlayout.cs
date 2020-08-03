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
namespace FlutterSDK.Rendering.Customlayout
{
    internal static class CustomlayoutDefaultClass
    {
    }

    /// <Summary>
    /// A delegate that controls the layout of multiple children.
    ///
    /// Used with [CustomMultiChildLayout] (in the widgets library) and
    /// [RenderCustomMultiChildLayoutBox] (in the rendering library).
    ///
    /// Delegates must be idempotent. Specifically, if two delegates are equal, then
    /// they must produce the same layout. To change the layout, replace the
    /// delegate with a different instance whose [shouldRelayout] returns true when
    /// given the previous instance.
    ///
    /// Override [getSize] to control the overall size of the layout. The size of
    /// the layout cannot depend on layout properties of the children. This was
    /// a design decision to simplify the delegate implementations: This way,
    /// the delegate implementations do not have to also handle various intrinsic
    /// sizing functions if the parent's size depended on the children.
    /// If you want to build a custom layout where you define the size of that widget
    /// based on its children, then you will have to create a custom render object.
    /// See [MultiChildRenderObjectWidget] with [ContainerRenderObjectMixin] and
    /// [RenderBoxContainerDefaultsMixin] to get started or [RenderStack] for an
    /// example implementation.
    ///
    /// Override [performLayout] to size and position the children. An
    /// implementation of [performLayout] must call [layoutChild] exactly once for
    /// each child, but it may call [layoutChild] on children in an arbitrary order.
    /// Typically a delegate will use the size returned from [layoutChild] on one
    /// child to determine the constraints for [performLayout] on another child or
    /// to determine the offset for [positionChild] for that child or another child.
    ///
    /// Override [shouldRelayout] to determine when the layout of the children needs
    /// to be recomputed when the delegate changes.
    ///
    /// The most efficient way to trigger a relayout is to supply a `relayout`
    /// argument to the constructor of the [MultiChildLayoutDelegate]. The custom
    /// layout will listen to this value and relayout whenever the Listenable
    /// notifies its listeners, such as when an [Animation] ticks. This allows
    /// the custom layout to avoid the build phase of the pipeline.
    ///
    /// Each child must be wrapped in a [LayoutId] widget to assign the id that
    /// identifies it to the delegate. The [LayoutId.id] needs to be unique among
    /// the children that the [CustomMultiChildLayout] manages.
    ///
    /// {@tool snippet}
    ///
    /// Below is an example implementation of [performLayout] that causes one widget
    /// (the follower) to be the same size as another (the leader):
    ///
    /// ```dart
    /// // Define your own slot numbers, depending upon the id assigned by LayoutId.
    /// // Typical usage is to define an enum like the one below, and use those
    /// // values as the ids.
    /// enum _Slot {
    ///   leader,
    ///   follower,
    /// }
    ///
    /// class FollowTheLeader extends MultiChildLayoutDelegate {
    ///   @override
    ///   void performLayout(Size size) {
    ///     Size leaderSize = Size.zero;
    ///
    ///     if (hasChild(_Slot.leader)) {
    ///       leaderSize = layoutChild(_Slot.leader, BoxConstraints.loose(size));
    ///       positionChild(_Slot.leader, Offset.zero);
    ///     }
    ///
    ///     if (hasChild(_Slot.follower)) {
    ///       layoutChild(_Slot.follower, BoxConstraints.tight(leaderSize));
    ///       positionChild(_Slot.follower, Offset(size.width - leaderSize.width,
    ///           size.height - leaderSize.height));
    ///     }
    ///   }
    ///
    ///   @override
    ///   bool shouldRelayout(MultiChildLayoutDelegate oldDelegate) => false;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// The delegate gives the leader widget loose constraints, which means the
    /// child determines what size to be (subject to fitting within the given size).
    /// The delegate then remembers the size of that child and places it in the
    /// upper left corner.
    ///
    /// The delegate then gives the follower widget tight constraints, forcing it to
    /// match the size of the leader widget. The delegate then places the follower
    /// widget in the bottom right corner.
    ///
    /// The leader and follower widget will paint in the order they appear in the
    /// child list, regardless of the order in which [layoutChild] is called on
    /// them.
    ///
    /// See also:
    ///
    ///  * [CustomMultiChildLayout], the widget that uses this delegate.
    ///  * [RenderCustomMultiChildLayoutBox], render object that uses this
    ///    delegate.
    /// </Summary>
    public interface IMultiChildLayoutDelegate
    {
        bool HasChild(@Object childId);
        Size LayoutChild(@Object childId, FlutterSDK.Rendering.Box.BoxConstraints constraints);
        void PositionChild(@Object childId, FlutterBinding.UI.Offset offset);
        Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints);
        void PerformLayout(Size size);
        bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate);
        string ToString();
    }


    /// <Summary>
    /// [ParentData] used by [RenderCustomMultiChildLayoutBox].
    /// </Summary>
    public class MultiChildLayoutParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        public MultiChildLayoutParentData()
        { }
        /// <Summary>
        /// An object representing the identity of this child.
        /// </Summary>
        public virtual @Object Id { get; set; }

    }


    /// <Summary>
    /// A delegate that controls the layout of multiple children.
    ///
    /// Used with [CustomMultiChildLayout] (in the widgets library) and
    /// [RenderCustomMultiChildLayoutBox] (in the rendering library).
    ///
    /// Delegates must be idempotent. Specifically, if two delegates are equal, then
    /// they must produce the same layout. To change the layout, replace the
    /// delegate with a different instance whose [shouldRelayout] returns true when
    /// given the previous instance.
    ///
    /// Override [getSize] to control the overall size of the layout. The size of
    /// the layout cannot depend on layout properties of the children. This was
    /// a design decision to simplify the delegate implementations: This way,
    /// the delegate implementations do not have to also handle various intrinsic
    /// sizing functions if the parent's size depended on the children.
    /// If you want to build a custom layout where you define the size of that widget
    /// based on its children, then you will have to create a custom render object.
    /// See [MultiChildRenderObjectWidget] with [ContainerRenderObjectMixin] and
    /// [RenderBoxContainerDefaultsMixin] to get started or [RenderStack] for an
    /// example implementation.
    ///
    /// Override [performLayout] to size and position the children. An
    /// implementation of [performLayout] must call [layoutChild] exactly once for
    /// each child, but it may call [layoutChild] on children in an arbitrary order.
    /// Typically a delegate will use the size returned from [layoutChild] on one
    /// child to determine the constraints for [performLayout] on another child or
    /// to determine the offset for [positionChild] for that child or another child.
    ///
    /// Override [shouldRelayout] to determine when the layout of the children needs
    /// to be recomputed when the delegate changes.
    ///
    /// The most efficient way to trigger a relayout is to supply a `relayout`
    /// argument to the constructor of the [MultiChildLayoutDelegate]. The custom
    /// layout will listen to this value and relayout whenever the Listenable
    /// notifies its listeners, such as when an [Animation] ticks. This allows
    /// the custom layout to avoid the build phase of the pipeline.
    ///
    /// Each child must be wrapped in a [LayoutId] widget to assign the id that
    /// identifies it to the delegate. The [LayoutId.id] needs to be unique among
    /// the children that the [CustomMultiChildLayout] manages.
    ///
    /// {@tool snippet}
    ///
    /// Below is an example implementation of [performLayout] that causes one widget
    /// (the follower) to be the same size as another (the leader):
    ///
    /// ```dart
    /// // Define your own slot numbers, depending upon the id assigned by LayoutId.
    /// // Typical usage is to define an enum like the one below, and use those
    /// // values as the ids.
    /// enum _Slot {
    ///   leader,
    ///   follower,
    /// }
    ///
    /// class FollowTheLeader extends MultiChildLayoutDelegate {
    ///   @override
    ///   void performLayout(Size size) {
    ///     Size leaderSize = Size.zero;
    ///
    ///     if (hasChild(_Slot.leader)) {
    ///       leaderSize = layoutChild(_Slot.leader, BoxConstraints.loose(size));
    ///       positionChild(_Slot.leader, Offset.zero);
    ///     }
    ///
    ///     if (hasChild(_Slot.follower)) {
    ///       layoutChild(_Slot.follower, BoxConstraints.tight(leaderSize));
    ///       positionChild(_Slot.follower, Offset(size.width - leaderSize.width,
    ///           size.height - leaderSize.height));
    ///     }
    ///   }
    ///
    ///   @override
    ///   bool shouldRelayout(MultiChildLayoutDelegate oldDelegate) => false;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// The delegate gives the leader widget loose constraints, which means the
    /// child determines what size to be (subject to fitting within the given size).
    /// The delegate then remembers the size of that child and places it in the
    /// upper left corner.
    ///
    /// The delegate then gives the follower widget tight constraints, forcing it to
    /// match the size of the leader widget. The delegate then places the follower
    /// widget in the bottom right corner.
    ///
    /// The leader and follower widget will paint in the order they appear in the
    /// child list, regardless of the order in which [layoutChild] is called on
    /// them.
    ///
    /// See also:
    ///
    ///  * [CustomMultiChildLayout], the widget that uses this delegate.
    ///  * [RenderCustomMultiChildLayoutBox], render object that uses this
    ///    delegate.
    /// </Summary>
    public class MultiChildLayoutDelegate
    {
        /// <Summary>
        /// Creates a layout delegate.
        ///
        /// The layout will update whenever [relayout] notifies its listeners.
        /// </Summary>
        public MultiChildLayoutDelegate(FlutterSDK.Foundation.Changenotifier.Listenable relayout = default(FlutterSDK.Foundation.Changenotifier.Listenable))
        : base()
        {

        }
        internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Relayout { get; set; }
        internal virtual Dictionary<@Object, FlutterSDK.Rendering.Box.RenderBox> _IdToChild { get; set; }
        internal virtual HashSet<FlutterSDK.Rendering.Box.RenderBox> _DebugChildrenNeedingLayout { get; set; }

        /// <Summary>
        /// True if a non-null LayoutChild was provided for the specified id.
        ///
        /// Call this from the [performLayout] or [getSize] methods to
        /// determine which children are available, if the child list might
        /// vary.
        /// </Summary>
        public virtual bool HasChild(@Object childId) => _IdToChild[childId] != null;



        /// <Summary>
        /// Ask the child to update its layout within the limits specified by
        /// the constraints parameter. The child's size is returned.
        ///
        /// Call this from your [performLayout] function to lay out each
        /// child. Every child must be laid out using this function exactly
        /// once each time the [performLayout] function is called.
        /// </Summary>
        public virtual Size LayoutChild(@Object childId, FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            RenderBox child = _IdToChild[childId];

            child.Layout(constraints, parentUsesSize: true);
            return child.Size;
        }




        /// <Summary>
        /// Specify the child's origin relative to this origin.
        ///
        /// Call this from your [performLayout] function to position each
        /// child. If you do not call this for a child, its position will
        /// remain unchanged. Children initially have their position set to
        /// (0,0), i.e. the top left of the [RenderCustomMultiChildLayoutBox].
        /// </Summary>
        public virtual void PositionChild(@Object childId, FlutterBinding.UI.Offset offset)
        {
            RenderBox child = _IdToChild[childId];

            MultiChildLayoutParentData childParentData = child.ParentData as MultiChildLayoutParentData;
            childParentData.Offset = offset;
        }




        private FlutterSDK.Foundation.Diagnostics.DiagnosticsNode _DebugDescribeChild(FlutterSDK.Rendering.Box.RenderBox child)
        {
            MultiChildLayoutParentData childParentData = child.ParentData as MultiChildLayoutParentData;
            return new DiagnosticsProperty<RenderBox>($"'{childParentData.Id}'", child);
        }




        private void _CallPerformLayout(Size size, FlutterSDK.Rendering.Box.RenderBox firstChild)
        {
            Dictionary<object, RenderBox> previousIdToChild = _IdToChild;
            HashSet<RenderBox> debugPreviousChildrenNeedingLayout = default(HashSet<RenderBox>);

            try
            {
                _IdToChild = new Dictionary<object, RenderBox> { };
                RenderBox child = firstChild;
                while (child != null)
                {
                    MultiChildLayoutParentData childParentData = child.ParentData as MultiChildLayoutParentData;

                    _IdToChild[childParentData.Id] = child;

                    child = childParentData.NextSibling;
                }

                PerformLayout(size);

            }
            finally
            {
                _IdToChild = previousIdToChild;

            }

        }




        /// <Summary>
        /// Override this method to return the size of this object given the
        /// incoming constraints.
        ///
        /// The size cannot reflect the sizes of the children. If this layout has a
        /// fixed width or height the returned size can reflect that; the size will be
        /// constrained to the given constraints.
        ///
        /// By default, attempts to size the box to the biggest size
        /// possible given the constraints.
        /// </Summary>
        public virtual Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints) => constraints.Biggest;



        /// <Summary>
        /// Override this method to lay out and position all children given this
        /// widget's size.
        ///
        /// This method must call [layoutChild] for each child. It should also specify
        /// the final position of each child with [positionChild].
        /// </Summary>
        public virtual void PerformLayout(Size size)
        {
        }


        /// <Summary>
        /// Override this method to return true when the children need to be
        /// laid out.
        ///
        /// This should compare the fields of the current delegate and the given
        /// `oldDelegate` and return true if the fields are such that the layout would
        /// be different.
        /// </Summary>
        public virtual bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate)
        {
            return default(bool);
        }


    }


    /// <Summary>
    /// Defers the layout of multiple children to a delegate.
    ///
    /// The delegate can determine the layout constraints for each child and can
    /// decide where to position each child. The delegate can also determine the
    /// size of the parent, but the size of the parent cannot depend on the sizes of
    /// the children.
    /// </Summary>
    public class RenderCustomMultiChildLayoutBox : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>
    {
        /// <Summary>
        /// Creates a render object that customizes the layout of multiple children.
        ///
        /// The [delegate] argument must not be null.
        /// </Summary>
        public RenderCustomMultiChildLayoutBox(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate @delegate = default(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate))
        : base()
        {

            AddAll(children);
        }


        internal virtual FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate _Delegate { get; set; }
        public virtual FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is MultiChildLayoutParentData)) child.ParentData = new MultiChildLayoutParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is MultiChildLayoutParentData)) child.ParentData = new MultiChildLayoutParentData();
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _Delegate?._Relayout?.AddListener(MarkNeedsLayout);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _Delegate?._Relayout?.AddListener(MarkNeedsLayout);
        }




        public new void Detach()
        {
            _Delegate?._Relayout?.RemoveListener(MarkNeedsLayout);
            base.Detach();
        }




        private Size _GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {

            return constraints.Constrain(_Delegate.GetSize(constraints));
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            double width = _GetSize(BoxConstraints.TightForFinite(height: height)).Width;
            if (width.IsFinite()) return width;
            return 0.0;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            double width = _GetSize(BoxConstraints.TightForFinite(height: height)).Width;
            if (width.IsFinite()) return width;
            return 0.0;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double height = _GetSize(BoxConstraints.TightForFinite(width: width)).Height;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            double height = _GetSize(BoxConstraints.TightForFinite(width: width)).Height;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new void PerformLayout()
        {
            Size = _GetSize(Constraints);
            Delegate._CallPerformLayout(Size, FirstChild);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            DefaultPaint(context, offset);
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            return DefaultHitTestChildren(result, position: position);
        }



    }

}
