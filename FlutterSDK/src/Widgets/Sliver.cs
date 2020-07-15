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
namespace FlutterSDK.Widgets.Sliver
{
    public delegate int SemanticIndexCallback(FlutterSDK.Widgets.Framework.Widget widget, int localIndex);
    public delegate int ChildIndexGetter(FlutterSDK.Foundation.Key.Key key);
    internal static class SliverDefaultClass
    {
        internal static int _KDefaultSemanticIndexCallback(FlutterSDK.Widgets.Framework.Widget _, int localIndex)
        {
            throw new NotImplementedException();
        }

        internal static FlutterSDK.Widgets.Framework.Widget _CreateErrorWidget(object exception, StackTrace stackTrace)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A delegate that supplies children for slivers.
    ///
    /// Many slivers lazily construct their box children to avoid creating more
    /// children than are visible through the [Viewport]. Rather than receiving
    /// their children as an explicit [List], they receive their children using a
    /// [SliverChildDelegate].
    ///
    /// It's uncommon to subclass [SliverChildDelegate]. Instead, consider using one
    /// of the existing subclasses that provide adaptors to builder callbacks or
    /// explicit child lists.
    ///
    /// {@template flutter.widgets.sliverChildDelegate.lifecycle}
    /// ## Child elements' lifecycle
    ///
    /// ### Creation
    ///
    /// While laying out the list, visible children's elements, states and render
    /// objects will be created lazily based on existing widgets (such as in the
    /// case of [SliverChildListDelegate]) or lazily provided ones (such as in the
    /// case of [SliverChildBuilderDelegate]).
    ///
    /// ### Destruction
    ///
    /// When a child is scrolled out of view, the associated element subtree, states
    /// and render objects are destroyed. A new child at the same position in the
    /// sliver will be lazily recreated along with new elements, states and render
    /// objects when it is scrolled back.
    ///
    /// ### Destruction mitigation
    ///
    /// In order to preserve state as child elements are scrolled in and out of
    /// view, the following options are possible:
    ///
    ///  * Moving the ownership of non-trivial UI-state-driving business logic
    ///    out of the sliver child subtree. For instance, if a list contains posts
    ///    with their number of upvotes coming from a cached network response, store
    ///    the list of posts and upvote number in a data model outside the list. Let
    ///    the sliver child UI subtree be easily recreate-able from the
    ///    source-of-truth model object. Use [StatefulWidget]s in the child widget
    ///    subtree to store instantaneous UI state only.
    ///
    ///  * Letting [KeepAlive] be the root widget of the sliver child widget subtree
    ///    that needs to be preserved. The [KeepAlive] widget marks the child
    ///    subtree's top render object child for keepalive. When the associated top
    ///    render object is scrolled out of view, the sliver keeps the child's
    ///    render object (and by extension, its associated elements and states) in a
    ///    cache list instead of destroying them. When scrolled back into view, the
    ///    render object is repainted as-is (if it wasn't marked dirty in the
    ///    interim).
    ///
    ///    This only works if the [SliverChildDelegate] subclasses don't wrap the
    ///    child widget subtree with other widgets such as [AutomaticKeepAlive] and
    ///    [RepaintBoundary] via `addAutomaticKeepAlives` and
    ///    `addRepaintBoundaries`.
    ///
    ///  * Using [AutomaticKeepAlive] widgets (inserted by default in
    ///    [SliverChildListDelegate] or [SliverChildListDelegate]).
    ///    [AutomaticKeepAlive] allows descendant widgets to control whether the
    ///    subtree is actually kept alive or not. This behavior is in contrast with
    ///    [KeepAlive], which will unconditionally keep the subtree alive.
    ///
    ///    As an example, the [EditableText] widget signals its sliver child element
    ///    subtree to stay alive while its text field has input focus. If it doesn't
    ///    have focus and no other descendants signaled for keepalive via a
    ///    [KeepAliveNotification], the sliver child element subtree will be
    ///    destroyed when scrolled away.
    ///
    ///    [AutomaticKeepAlive] descendants typically signal it to be kept alive by
    ///    using the [AutomaticKeepAliveClientMixin], then implementing the
    ///    [wantKeepAlive] getter and calling [updateKeepAlive].
    /// {@endtemplate}
    ///
    /// See also:
    ///
    ///  * [SliverChildBuilderDelegate], which is a delegate that uses a builder
    ///    callback to construct the children.
    ///  * [SliverChildListDelegate], which is a delegate that has an explicit list
    ///    of children.
    /// </Summary>
    public interface ISliverChildDelegate
    {
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index);
        double EstimateMaxScrollOffset(int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset);
        void DidFinishLayout(int firstIndex, int lastIndex);
        bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate);
        int FindIndexByKey(FlutterSDK.Foundation.Key.Key key);
        string ToString();
        void DebugFillDescription(List<string> description);
        int EstimatedChildCount { get; }
    }


    /// <Summary>
    /// A base class for sliver that have [KeepAlive] children.
    /// </Summary>
    public interface ISliverWithKeepAliveWidget
    {
        FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverWithKeepAliveMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
    }


    /// <Summary>
    /// A base class for sliver that have multiple box children.
    ///
    /// Helps subclasses build their children lazily using a [SliverChildDelegate].
    ///
    /// The widgets returned by the [delegate] are cached and the delegate is only
    /// consulted again if it changes and the new delegate's [shouldRebuild] method
    /// returns true.
    /// </Summary>
    public interface ISliverMultiBoxAdaptorWidget
    {
        FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorElement CreateElement();
        FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
        double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate { get; }
    }


    /// <Summary>
    /// A delegate that supplies children for slivers.
    ///
    /// Many slivers lazily construct their box children to avoid creating more
    /// children than are visible through the [Viewport]. Rather than receiving
    /// their children as an explicit [List], they receive their children using a
    /// [SliverChildDelegate].
    ///
    /// It's uncommon to subclass [SliverChildDelegate]. Instead, consider using one
    /// of the existing subclasses that provide adaptors to builder callbacks or
    /// explicit child lists.
    ///
    /// {@template flutter.widgets.sliverChildDelegate.lifecycle}
    /// ## Child elements' lifecycle
    ///
    /// ### Creation
    ///
    /// While laying out the list, visible children's elements, states and render
    /// objects will be created lazily based on existing widgets (such as in the
    /// case of [SliverChildListDelegate]) or lazily provided ones (such as in the
    /// case of [SliverChildBuilderDelegate]).
    ///
    /// ### Destruction
    ///
    /// When a child is scrolled out of view, the associated element subtree, states
    /// and render objects are destroyed. A new child at the same position in the
    /// sliver will be lazily recreated along with new elements, states and render
    /// objects when it is scrolled back.
    ///
    /// ### Destruction mitigation
    ///
    /// In order to preserve state as child elements are scrolled in and out of
    /// view, the following options are possible:
    ///
    ///  * Moving the ownership of non-trivial UI-state-driving business logic
    ///    out of the sliver child subtree. For instance, if a list contains posts
    ///    with their number of upvotes coming from a cached network response, store
    ///    the list of posts and upvote number in a data model outside the list. Let
    ///    the sliver child UI subtree be easily recreate-able from the
    ///    source-of-truth model object. Use [StatefulWidget]s in the child widget
    ///    subtree to store instantaneous UI state only.
    ///
    ///  * Letting [KeepAlive] be the root widget of the sliver child widget subtree
    ///    that needs to be preserved. The [KeepAlive] widget marks the child
    ///    subtree's top render object child for keepalive. When the associated top
    ///    render object is scrolled out of view, the sliver keeps the child's
    ///    render object (and by extension, its associated elements and states) in a
    ///    cache list instead of destroying them. When scrolled back into view, the
    ///    render object is repainted as-is (if it wasn't marked dirty in the
    ///    interim).
    ///
    ///    This only works if the [SliverChildDelegate] subclasses don't wrap the
    ///    child widget subtree with other widgets such as [AutomaticKeepAlive] and
    ///    [RepaintBoundary] via `addAutomaticKeepAlives` and
    ///    `addRepaintBoundaries`.
    ///
    ///  * Using [AutomaticKeepAlive] widgets (inserted by default in
    ///    [SliverChildListDelegate] or [SliverChildListDelegate]).
    ///    [AutomaticKeepAlive] allows descendant widgets to control whether the
    ///    subtree is actually kept alive or not. This behavior is in contrast with
    ///    [KeepAlive], which will unconditionally keep the subtree alive.
    ///
    ///    As an example, the [EditableText] widget signals its sliver child element
    ///    subtree to stay alive while its text field has input focus. If it doesn't
    ///    have focus and no other descendants signaled for keepalive via a
    ///    [KeepAliveNotification], the sliver child element subtree will be
    ///    destroyed when scrolled away.
    ///
    ///    [AutomaticKeepAlive] descendants typically signal it to be kept alive by
    ///    using the [AutomaticKeepAliveClientMixin], then implementing the
    ///    [wantKeepAlive] getter and calling [updateKeepAlive].
    /// {@endtemplate}
    ///
    /// See also:
    ///
    ///  * [SliverChildBuilderDelegate], which is a delegate that uses a builder
    ///    callback to construct the children.
    ///  * [SliverChildListDelegate], which is a delegate that has an explicit list
    ///    of children.
    /// </Summary>
    public class SliverChildDelegate
    {
        #region constructors
        public SliverChildDelegate()
    
}
    #endregion

    #region fields
    public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Returns the child with the given index.
    ///
    /// Should return null if asked to build a widget with a greater index than
    /// exists. If this returns null, [estimatedChildCount] must subsequently
    /// return a precise non-null value.
    ///
    /// Subclasses typically override this function and wrap their children in
    /// [AutomaticKeepAlive], [IndexedSemantics], and [RepaintBoundary] widgets.
    ///
    /// The values returned by this method are cached. To indicate that the
    /// widgets have changed, a new delegate must be provided, and the new
    /// delegate's [shouldRebuild] method must return true.
    /// </Summary>
    public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
    {
        return default(Widget);
    }


    /// <Summary>
    /// Returns an estimate of the max scroll extent for all the children.
    ///
    /// Subclasses should override this function if they have additional
    /// information about their max scroll extent.
    ///
    /// The default implementation returns null, which causes the caller to
    /// extrapolate the max scroll offset from the given parameters.
    /// </Summary>
    public virtual double EstimateMaxScrollOffset(int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset) => null;



    /// <Summary>
    /// Called at the end of layout to indicate that layout is now complete.
    ///
    /// The `firstIndex` argument is the index of the first child that was
    /// included in the current layout. The `lastIndex` argument is the index of
    /// the last child that was included in the current layout.
    ///
    /// Useful for subclasses that which to track which children are included in
    /// the underlying render tree.
    /// </Summary>
    public virtual void DidFinishLayout(int firstIndex, int lastIndex)
    {
    }




    /// <Summary>
    /// Called whenever a new instance of the child delegate class is
    /// provided to the sliver.
    ///
    /// If the new instance represents different information than the old
    /// instance, then the method should return true, otherwise it should return
    /// false.
    ///
    /// If the method returns false, then the [build] call might be optimized
    /// away.
    /// </Summary>
    public virtual bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate)
    {
        return default(bool);
    }


    /// <Summary>
    /// Find index of child element with associated key.
    ///
    /// This will be called during [performRebuild] in [SliverMultiBoxAdaptorElement]
    /// to check if a child has moved to a different position. It should return the
    /// index of the child element with associated key, null if not found.
    /// </Summary>
    public virtual int FindIndexByKey(FlutterSDK.Foundation.Key.Key key) => null;




    /// <Summary>
    /// Add additional information to the given description for use by [toString].
    /// </Summary>
    public virtual void DebugFillDescription(List<string> description)
    {
        try
        {
            int children = EstimatedChildCount;
            if (children != null) description.Add($"'estimated child count: {children}'");
        }
        catch (e)
        {
            description.Add($"'estimated child count: EXCEPTION ({e.GetType()})'");
        }

    }



    #endregion
}


public class _SaltedValueKey : FlutterSDK.Foundation.Key.ValueKey<FlutterSDK.Foundation.Key.Key>
{
    #region constructors
    public _SaltedValueKey(FlutterSDK.Foundation.Key.Key key)
    : base(key)

}
#endregion

#region fields
#endregion

#region methods
#endregion
}


/// <Summary>
/// A delegate that supplies children for slivers using a builder callback.
///
/// Many slivers lazily construct their box children to avoid creating more
/// children than are visible through the [Viewport]. This delegate provides
/// children using an [IndexedWidgetBuilder] callback, so that the children do
/// not even have to be built until they are displayed.
///
/// The widgets returned from the builder callback are automatically wrapped in
/// [AutomaticKeepAlive] widgets if [addAutomaticKeepAlives] is true (the
/// default) and in [RepaintBoundary] widgets if [addRepaintBoundaries] is true
/// (also the default).
///
/// ## Accessibility
///
/// The [CustomScrollView] requires that its semantic children are annotated
/// using [IndexedSemantics]. This is done by default in the delegate with
/// the `addSemanticIndexes` parameter set to true.
///
/// If multiple delegates are used in a single scroll view, then the indexes
/// will not be correct by default. The `semanticIndexOffset` can be used to
/// offset the semantic indexes of each delegate so that the indexes are
/// monotonically increasing. For example, if a scroll view contains two
/// delegates where the first has 10 children contributing semantics, then the
/// second delegate should offset its children by 10.
///
/// {@tool snippet}
///
/// This sample code shows how to use `semanticIndexOffset` to handle multiple
/// delegates in a single scroll view.
///
/// ```dart
/// CustomScrollView(
///   semanticChildCount: 4,
///   slivers: <Widget>[
///     SliverGrid(
///       gridDelegate: _gridDelegate,
///       delegate: SliverChildBuilderDelegate(
///         (BuildContext context, int index) {
///            return Text('...');
///          },
///          childCount: 2,
///        ),
///      ),
///     SliverGrid(
///       gridDelegate: _gridDelegate,
///       delegate: SliverChildBuilderDelegate(
///         (BuildContext context, int index) {
///            return Text('...');
///          },
///          childCount: 2,
///          semanticIndexOffset: 2,
///        ),
///      ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// In certain cases, only a subset of child widgets should be annotated
/// with a semantic index. For example, in [new ListView.separated()] the
/// separators do not have an index associated with them. This is done by
/// providing a `semanticIndexCallback` which returns null for separators
/// indexes and rounds the non-separator indexes down by half.
///
/// {@tool snippet}
///
/// This sample code shows how to use `semanticIndexCallback` to handle
/// annotating a subset of child nodes with a semantic index. There is
/// a [Spacer] widget at odd indexes which should not have a semantic
/// index.
///
/// ```dart
/// CustomScrollView(
///   semanticChildCount: 5,
///   slivers: <Widget>[
///     SliverGrid(
///       gridDelegate: _gridDelegate,
///       delegate: SliverChildBuilderDelegate(
///         (BuildContext context, int index) {
///            if (index.isEven) {
///              return Text('...');
///            }
///            return Spacer();
///          },
///          semanticIndexCallback: (Widget widget, int localIndex) {
///            if (localIndex.isEven) {
///              return localIndex ~/ 2;
///            }
///            return null;
///          },
///          childCount: 10,
///        ),
///      ),
///   ],
/// )
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [SliverChildListDelegate], which is a delegate that has an explicit list
///    of children.
///  * [IndexedSemantics], for an example of manually annotating child nodes
///    with semantic indexes.
/// </Summary>
public class SliverChildBuilderDelegate : FlutterSDK.Widgets.Sliver.SliverChildDelegate
{
    #region constructors
    public SliverChildBuilderDelegate(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder builder, FlutterSDK.Widgets.Sliver.ChildIndexGetter findChildIndexCallback = default(FlutterSDK.Widgets.Sliver.ChildIndexGetter), int childCount = default(int), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, FlutterSDK.Widgets.Sliver.SemanticIndexCallback semanticIndexCallback = default(FlutterSDK.Widgets.Sliver.SemanticIndexCallback), int semanticIndexOffset = 0)
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder Builder { get; set; }
public virtual int ChildCount { get; set; }
public virtual bool AddAutomaticKeepAlives { get; set; }
public virtual bool AddRepaintBoundaries { get; set; }
public virtual bool AddSemanticIndexes { get; set; }
public virtual int SemanticIndexOffset { get; set; }
public virtual FlutterSDK.Widgets.Sliver.SemanticIndexCallback SemanticIndexCallback { get; set; }
public virtual FlutterSDK.Widgets.Sliver.ChildIndexGetter FindChildIndexCallback { get; set; }
public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new int FindIndexByKey(FlutterSDK.Foundation.Key.Key key)
{
    if (FindChildIndexCallback == null) return null;

    Key childKey = default(Key);
    if (key is _SaltedValueKey)
    {
        _SaltedValueKey saltedValueKey = ((_SaltedValueKey)key);
        childKey = saltedValueKey.Value;
    }
    else
    {
        childKey = key;
    }

    return FindChildIndexCallback(childKey);
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
{

    if (index < 0 || (ChildCount != null && index >= ChildCount)) return null;
    Widget child = default(Widget);
    try
    {
        child = Builder(context, index);
    }
    catch (exception,stackTrace){
        child = SliverDefaultClass._CreateErrorWidget(exception, stackTrace);
    }

    if (child == null) return null;
    Key key = child.Key != null ? new _SaltedValueKey(child.Key) : null;
    if (AddRepaintBoundaries) child = new RepaintBoundary(child: child);
    if (AddSemanticIndexes)
    {
        int semanticIndex = SemanticIndexCallback(child, index);
        if (semanticIndex != null) child = new IndexedSemantics(index: semanticIndex + SemanticIndexOffset, child: child);
    }

    if (AddAutomaticKeepAlives) child = new AutomaticKeepAlive(child: child);
    return new KeyedSubtree(child: child, key: key);
    }




public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildBuilderDelegate oldDelegate) => true;

public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate) => true;


#endregion
}


/// <Summary>
/// A delegate that supplies children for slivers using an explicit list.
///
/// Many slivers lazily construct their box children to avoid creating more
/// children than are visible through the [Viewport]. This delegate provides
/// children using an explicit list, which is convenient but reduces the benefit
/// of building children lazily.
///
/// In general building all the widgets in advance is not efficient. It is
/// better to create a delegate that builds them on demand using
/// [SliverChildBuilderDelegate] or by subclassing [SliverChildDelegate]
/// directly.
///
/// This class is provided for the cases where either the list of children is
/// known well in advance (ideally the children are themselves compile-time
/// constants, for example), and therefore will not be built each time the
/// delegate itself is created, or the list is small, such that it's likely
/// always visible (and thus there is nothing to be gained by building it on
/// demand). For example, the body of a dialog box might fit both of these
/// conditions.
///
/// The widgets in the given [children] list are automatically wrapped in
/// [AutomaticKeepAlive] widgets if [addAutomaticKeepAlives] is true (the
/// default) and in [RepaintBoundary] widgets if [addRepaintBoundaries] is true
/// (also the default).
///
/// ## Accessibility
///
/// The [CustomScrollView] requires that its semantic children are annotated
/// using [IndexedSemantics]. This is done by default in the delegate with
/// the `addSemanticIndexes` parameter set to true.
///
/// If multiple delegates are used in a single scroll view, then the indexes
/// will not be correct by default. The `semanticIndexOffset` can be used to
/// offset the semantic indexes of each delegate so that the indexes are
/// monotonically increasing. For example, if a scroll view contains two
/// delegates where the first has 10 children contributing semantics, then the
/// second delegate should offset its children by 10.
///
/// In certain cases, only a subset of child widgets should be annotated
/// with a semantic index. For example, in [new ListView.separated()] the
/// separators do not have an index associated with them. This is done by
/// providing a `semanticIndexCallback` which returns null for separators
/// indexes and rounds the non-separator indexes down by half.
///
/// See [SliverChildBuilderDelegate] for sample code using
/// `semanticIndexOffset` and `semanticIndexCallback`.
///
/// See also:
///
///  * [SliverChildBuilderDelegate], which is a delegate that uses a builder
///    callback to construct the children.
/// </Summary>
public class SliverChildListDelegate : FlutterSDK.Widgets.Sliver.SliverChildDelegate
{
    #region constructors
    public SliverChildListDelegate(List<FlutterSDK.Widgets.Framework.Widget> children, bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, FlutterSDK.Widgets.Sliver.SemanticIndexCallback semanticIndexCallback = default(FlutterSDK.Widgets.Sliver.SemanticIndexCallback), int semanticIndexOffset = 0)
    : base()

}
public static SliverChildListDelegate Fixed(List<FlutterSDK.Widgets.Framework.Widget> children, bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, FlutterSDK.Widgets.Sliver.SemanticIndexCallback semanticIndexCallback = default(FlutterSDK.Widgets.Sliver.SemanticIndexCallback), int semanticIndexOffset = 0)

}
#endregion

#region fields
public virtual bool AddAutomaticKeepAlives { get; set; }
public virtual bool AddRepaintBoundaries { get; set; }
public virtual bool AddSemanticIndexes { get; set; }
public virtual int SemanticIndexOffset { get; set; }
public virtual FlutterSDK.Widgets.Sliver.SemanticIndexCallback SemanticIndexCallback { get; set; }
public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
internal virtual Dictionary<FlutterSDK.Foundation.Key.Key, int> _KeyToIndex { get; set; }
internal virtual bool _IsConstantInstance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private int _FindChildIndex(FlutterSDK.Foundation.Key.Key key)
{
    if (_IsConstantInstance)
    {
        return null;
    }

    if (!_KeyToIndex.ContainsKey(key))
    {
        int index = _KeyToIndex[null];
        while (index < Children.Count)
        {
            Widget child = Children[index];
            if (child.Key != null)
            {
                _KeyToIndex[child.Key] = index;
            }

            if (child.Key == key)
            {
                _KeyToIndex[null] = index + 1;
                return index;
            }

            index += 1;
        }

        _KeyToIndex[null] = index;
    }
    else
    {
        return _KeyToIndex[key];
    }

    return null;
}




public new int FindIndexByKey(FlutterSDK.Foundation.Key.Key key)
{

    Key childKey = default(Key);
    if (key is _SaltedValueKey)
    {
        _SaltedValueKey saltedValueKey = ((_SaltedValueKey)key);
        childKey = saltedValueKey.Value;
    }
    else
    {
        childKey = key;
    }

    return _FindChildIndex(childKey);
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
{

    if (index < 0 || index >= Children.Count) return null;
    Widget child = Children[index];
    Key key = child.Key != null ? new _SaltedValueKey(child.Key) : null;

    if (AddRepaintBoundaries) child = new RepaintBoundary(child: child);
    if (AddSemanticIndexes)
    {
        int semanticIndex = SemanticIndexCallback(child, index);
        if (semanticIndex != null) child = new IndexedSemantics(index: semanticIndex + SemanticIndexOffset, child: child);
    }

    if (AddAutomaticKeepAlives) child = new AutomaticKeepAlive(child: child);
    return new KeyedSubtree(child: child, key: key);
}




public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildListDelegate oldDelegate)
{
    return Children != oldDelegate.Children;
}


public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate)
{
    return Children != oldDelegate.Children;
}



#endregion
}


/// <Summary>
/// A base class for sliver that have [KeepAlive] children.
/// </Summary>
public class SliverWithKeepAliveWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
{
    #region constructors
    public SliverWithKeepAliveWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
    : base(key: key)

}
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverWithKeepAliveMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return default(RenderSliverWithKeepAliveMixin);
}

#endregion
}


/// <Summary>
/// A base class for sliver that have multiple box children.
///
/// Helps subclasses build their children lazily using a [SliverChildDelegate].
///
/// The widgets returned by the [delegate] are cached and the delegate is only
/// consulted again if it changes and the new delegate's [shouldRebuild] method
/// returns true.
/// </Summary>
public class SliverMultiBoxAdaptorWidget : FlutterSDK.Widgets.Sliver.SliverWithKeepAliveWidget
{
    #region constructors
    public SliverMultiBoxAdaptorWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorElement CreateElement() => new SliverMultiBoxAdaptorElement(this);



public new FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return default(RenderSliverMultiBoxAdaptor);
}


/// <Summary>
/// Returns an estimate of the max scroll extent for all the children.
///
/// Subclasses should override this function if they have additional
/// information about their max scroll extent.
///
/// This is used by [SliverMultiBoxAdaptorElement] to implement part of the
/// [RenderSliverBoxChildManager] API.
///
/// The default implementation defers to [delegate] via its
/// [SliverChildDelegate.estimateMaxScrollOffset] method.
/// </Summary>
public virtual double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset)
{

    return Delegate.EstimateMaxScrollOffset(firstIndex, lastIndex, leadingScrollOffset, trailingScrollOffset);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<SliverChildDelegate>("delegate", Delegate));
}



#endregion
}


/// <Summary>
/// A sliver that places multiple box children in a linear array along the main
/// axis.
///
/// Each child is forced to have the [SliverConstraints.crossAxisExtent] in the
/// cross axis but determines its own main axis extent.
///
/// [SliverList] determines its scroll offset by "dead reckoning" because
/// children outside the visible part of the sliver are not materialized, which
/// means [SliverList] cannot learn their main axis extent. Instead, newly
/// materialized children are placed adjacent to existing children.
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=ORiTTaVY6mM}
///
/// If the children have a fixed extent in the main axis, consider using
/// [SliverFixedExtentList] rather than [SliverList] because
/// [SliverFixedExtentList] does not need to perform layout on its children to
/// obtain their extent in the main axis and is therefore more efficient.
///
/// {@macro flutter.widgets.sliverChildDelegate.lifecycle}
///
/// See also:
///
///  * [SliverFixedExtentList], which is more efficient for children with
///    the same extent in the main axis.
///  * [SliverPrototypeExtentList], which is similar to [SliverFixedExtentList]
///    except that it uses a prototype list item instead of a pixel value to define
///    the main axis extent of each item.
///  * [SliverGrid], which places its children in arbitrary positions.
/// </Summary>
public class SliverList : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
{
    #region constructors
    public SliverList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate))
    : base(key: key, @delegate: @delegate)

}
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Rendering.Sliverlist.RenderSliverList CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    SliverMultiBoxAdaptorElement element = context as SliverMultiBoxAdaptorElement;
    return new RenderSliverList(childManager: element);
}



#endregion
}


/// <Summary>
/// A sliver that places multiple box children with the same main axis extent in
/// a linear array.
///
/// [SliverFixedExtentList] places its children in a linear array along the main
/// axis starting at offset zero and without gaps. Each child is forced to have
/// the [itemExtent] in the main axis and the
/// [SliverConstraints.crossAxisExtent] in the cross axis.
///
/// [SliverFixedExtentList] is more efficient than [SliverList] because
/// [SliverFixedExtentList] does not need to perform layout on its children to
/// obtain their extent in the main axis.
///
/// {@tool snippet}
///
/// This example, which would be inserted into a [CustomScrollView.slivers]
/// list, shows an infinite number of items in varying shades of blue:
///
/// ```dart
/// SliverFixedExtentList(
///   itemExtent: 50.0,
///   delegate: SliverChildBuilderDelegate(
///     (BuildContext context, int index) {
///       return Container(
///         alignment: Alignment.center,
///         color: Colors.lightBlue[100 * (index % 9)],
///         child: Text('list item $index'),
///       );
///     },
///   ),
/// )
/// ```
/// {@end-tool}
///
/// {@macro flutter.widgets.sliverChildDelegate.lifecycle}
///
/// See also:
///
///  * [SliverPrototypeExtentList], which is similar to [SliverFixedExtentList]
///    except that it uses a prototype list item instead of a pixel value to define
///    the main axis extent of each item.
///  * [SliverFillViewport], which determines the [itemExtent] based on
///    [SliverConstraints.viewportMainAxisExtent].
///  * [SliverList], which does not require its children to have the same
///    extent in the main axis.
/// </Summary>
public class SliverFixedExtentList : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
{
    #region constructors
    public SliverFixedExtentList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), double itemExtent = default(double))
    : base(key: key, @delegate: @delegate)

}
#endregion

#region fields
public virtual double ItemExtent { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.Sliverfixedextentlist.RenderSliverFixedExtentList CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    SliverMultiBoxAdaptorElement element = context as SliverMultiBoxAdaptorElement;
    return new RenderSliverFixedExtentList(childManager: element, itemExtent: ItemExtent);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Sliverfixedextentlist.RenderSliverFixedExtentList renderObject)
{
    renderObject.ItemExtent = ItemExtent;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.ItemExtent = ItemExtent;
}



#endregion
}


/// <Summary>
/// A sliver that places multiple box children in a two dimensional arrangement.
///
/// [SliverGrid] places its children in arbitrary positions determined by
/// [gridDelegate]. Each child is forced to have the size specified by the
/// [gridDelegate].
///
/// The main axis direction of a grid is the direction in which it scrolls; the
/// cross axis direction is the orthogonal direction.
///
/// {@youtube 560 315 https://www.youtube.com/watch?v=ORiTTaVY6mM}
///
/// {@tool snippet}
///
/// This example, which would be inserted into a [CustomScrollView.slivers]
/// list, shows twenty boxes in a pretty teal grid:
///
/// ```dart
/// SliverGrid(
///   gridDelegate: SliverGridDelegateWithMaxCrossAxisExtent(
///     maxCrossAxisExtent: 200.0,
///     mainAxisSpacing: 10.0,
///     crossAxisSpacing: 10.0,
///     childAspectRatio: 4.0,
///   ),
///   delegate: SliverChildBuilderDelegate(
///     (BuildContext context, int index) {
///       return Container(
///         alignment: Alignment.center,
///         color: Colors.teal[100 * (index % 9)],
///         child: Text('grid item $index'),
///       );
///     },
///     childCount: 20,
///   ),
/// )
/// ```
/// {@end-tool}
///
/// {@macro flutter.widgets.sliverChildDelegate.lifecycle}
///
/// See also:
///
///  * [SliverList], which places its children in a linear array.
///  * [SliverFixedExtentList], which places its children in a linear
///    array with a fixed extent in the main axis.
///  * [SliverPrototypeExtentList], which is similar to [SliverFixedExtentList]
///    except that it uses a prototype list item instead of a pixel value to define
///    the main axis extent of each item.
/// </Summary>
public class SliverGrid : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
{
    #region constructors
    public SliverGrid(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate))
    : base(key: key, @delegate: @delegate)

}
public static SliverGrid Count(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int crossAxisCount = default(int), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))

}
public static SliverGrid Extent(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double maxCrossAxisExtent = default(double), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Slivergrid.SliverGridDelegate GridDelegate { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.Slivergrid.RenderSliverGrid CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    SliverMultiBoxAdaptorElement element = context as SliverMultiBoxAdaptorElement;
    return new RenderSliverGrid(childManager: element, gridDelegate: GridDelegate);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Slivergrid.RenderSliverGrid renderObject)
{
    renderObject.GridDelegate = GridDelegate;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.GridDelegate = GridDelegate;
}




public new double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset)
{
    return base.EstimateMaxScrollOffset(constraints, firstIndex, lastIndex, leadingScrollOffset, trailingScrollOffset) ?? GridDelegate.GetLayout(constraints).ComputeMaxScrollOffset(Delegate.EstimatedChildCount);
}



#endregion
}


/// <Summary>
/// An element that lazily builds children for a [SliverMultiBoxAdaptorWidget].
///
/// Implements [RenderSliverBoxChildManager], which lets this element manage
/// the children of subclasses of [RenderSliverMultiBoxAdaptor].
/// </Summary>
public class SliverMultiBoxAdaptorElement : FlutterSDK.Widgets.Framework.RenderObjectElement, IRenderSliverBoxChildManager
{
    #region constructors
    public SliverMultiBoxAdaptorElement(FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget widget)
    : base(widget)

}
#endregion

#region fields
internal virtual Dictionary<int, FlutterSDK.Widgets.Framework.Widget> _ChildWidgets { get; set; }
internal virtual SplayTreeMap<int, FlutterSDK.Widgets.Framework.Element> _ChildElements { get; set; }
internal virtual FlutterSDK.Rendering.Box.RenderBox _CurrentBeforeChild { get; set; }
internal virtual int _CurrentlyUpdatingChildIndex { get; set; }
internal virtual bool _DidUnderflow { get; set; }
public virtual FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Update(FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget newWidget)
{
    SliverMultiBoxAdaptorWidget oldWidget = Widget;
    base.Update(newWidget);
    SliverChildDelegate newDelegate = newWidget.Delegate;
    SliverChildDelegate oldDelegate = oldWidget.Delegate;
    if (newDelegate != oldDelegate && (newDelegate.GetType() != oldDelegate.GetType() || newDelegate.ShouldRebuild(oldDelegate))) PerformRebuild();
}


public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
{
    SliverMultiBoxAdaptorWidget oldWidget = Widget;
    base.Update(newWidget);
    SliverChildDelegate newDelegate = newWidget.Delegate;
    SliverChildDelegate oldDelegate = oldWidget.Delegate;
    if (newDelegate != oldDelegate && (newDelegate.GetType() != oldDelegate.GetType() || newDelegate.ShouldRebuild(oldDelegate))) PerformRebuild();
}




public new void PerformRebuild()
{
    _ChildWidgets.Clear();
    base.PerformRebuild();
    _CurrentBeforeChild = null;

    try
    {
        SplayTreeMap<int, Element> newChildren = new SplayTreeMap<int, Element>();
        Dictionary<int, double> indexToLayoutOffset = new HashMap<int, double>();
        void ProcessElement(int index) => {
            _CurrentlyUpdatingChildIndex = index;
            if (_ChildElements[index] != null && _ChildElements[index] != newChildren[index])
            {
                _ChildElements[index] = UpdateChild(_ChildElements[index], null, index);
            }

            Element newChild = UpdateChild(newChildren[index], _Build(index), index);
            if (newChild != null)
            {
                _ChildElements[index] = newChild;
                SliverMultiBoxAdaptorParentData parentData = newChild.RenderObject.ParentData as SliverMultiBoxAdaptorParentData;
                if (index == 0)
                {
                    parentData.LayoutOffset = 0.0;
                }
                else if (indexToLayoutOffset.ContainsKey(index))
                {
                    parentData.LayoutOffset = indexToLayoutOffset[index];
                }

                if (!parentData.KeptAlive) _CurrentBeforeChild = newChild.RenderObject as RenderBox;
            }
            else
            {
                _ChildElements.Remove(index);
            }

        }

        foreach (int index in _ChildElements.Keys.ToList())
        {
            Key key = _ChildElements[index].Widget.Key;
            int newIndex = key == null ? null : Widget.Delegate.FindIndexByKey(key);
            SliverMultiBoxAdaptorParentData childParentData = _ChildElements[index].RenderObject?.ParentData as SliverMultiBoxAdaptorParentData;
            if (childParentData != null && childParentData.LayoutOffset != null) indexToLayoutOffset[index] = childParentData.LayoutOffset;
            if (newIndex != null && newIndex != index)
            {
                if (childParentData != null) childParentData.LayoutOffset = null;
                newChildren[newIndex] = _ChildElements[index];
                newChildren.PutIfAbsent(index, () => =>null);
                _ChildElements.Remove(index);
            }
            else
            {
                newChildren.PutIfAbsent(index, () => =>_ChildElements[index]);
            }

        }

        RenderObject.DebugChildIntegrityEnabled = false;
        newChildren.Keys.ForEach(ProcessElement);
        if (_DidUnderflow)
        {
            int lastKey = _ChildElements.LastKey() ?? -1;
            int rightBoundary = lastKey + 1;
            newChildren[rightBoundary] = _ChildElements[rightBoundary];
            ProcessElement(rightBoundary);
        }

    }
    finally
    {
        _CurrentlyUpdatingChildIndex = null;
        RenderObject.DebugChildIntegrityEnabled = true;
    }

}




private FlutterSDK.Widgets.Framework.Widget _Build(int index)
{
    return _ChildWidgets.PutIfAbsent(index, () => =>Widget.Delegate.Build(this, index));
}




public new void CreateChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox))
{

    Owner.BuildScope(this, () =>
    {
        bool insertFirst = after == null;

        _CurrentBeforeChild = insertFirst ? null : (_ChildElements[index - 1].RenderObject as RenderBox);
        Element newChild = default(Element);
        try
        {
            _CurrentlyUpdatingChildIndex = index;
            newChild = UpdateChild(_ChildElements[index], _Build(index), index);
        }
        finally
        {
            _CurrentlyUpdatingChildIndex = null;
        }

        if (newChild != null)
        {
            _ChildElements[index] = newChild;
        }
        else
        {
            _ChildElements.Remove(index);
        }

    }
    );
}




public new FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot)
{
    SliverMultiBoxAdaptorParentData oldParentData = child?.RenderObject?.ParentData as SliverMultiBoxAdaptorParentData;
    Element newChild = base.UpdateChild(child, newWidget, newSlot);
    SliverMultiBoxAdaptorParentData newParentData = newChild?.RenderObject?.ParentData as SliverMultiBoxAdaptorParentData;
    if (oldParentData != newParentData && oldParentData != null && newParentData != null)
    {
        newParentData.LayoutOffset = oldParentData.LayoutOffset;
    }

    return newChild;
}




public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
{



    _ChildElements.Remove(child.Slot);
    base.ForgetChild(child);
}




public new void RemoveChild(FlutterSDK.Rendering.Box.RenderBox child)
{
    int index = RenderObject.IndexOf(child);


    Owner.BuildScope(this, () =>
    {

        try
        {
            _CurrentlyUpdatingChildIndex = index;
            Element result = UpdateChild(_ChildElements[index], null, index);

        }
        finally
        {
            _CurrentlyUpdatingChildIndex = null;
        }

        _ChildElements.Remove(index);

    }
    );
}




private double _ExtrapolateMaxScrollOffset(int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset, int childCount)
{
    if (lastIndex == childCount - 1) return trailingScrollOffset;
    int reifiedCount = lastIndex - firstIndex + 1;
    double averageExtent = (trailingScrollOffset - leadingScrollOffset) / reifiedCount;
    int remainingCount = childCount - lastIndex - 1;
    return trailingScrollOffset + averageExtent * remainingCount;
}




public new double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex = default(int), int lastIndex = default(int), double leadingScrollOffset = default(double), double trailingScrollOffset = default(double))
{
    int childCount = this.ChildCount;
    if (childCount == null) return Dart:coreDefaultClass.Double.Infinity;
    return Widget.EstimateMaxScrollOffset(constraints, firstIndex, lastIndex, leadingScrollOffset, trailingScrollOffset) ?? _ExtrapolateMaxScrollOffset(firstIndex, lastIndex, leadingScrollOffset, trailingScrollOffset, childCount);
}




public new void DidStartLayout()
{

}




public new void DidFinishLayout()
{

    int firstIndex = _ChildElements.FirstKey() ?? 0;
    int lastIndex = _ChildElements.LastKey() ?? 0;
    Widget.Delegate.DidFinishLayout(firstIndex, lastIndex);
}




public new bool DebugAssertChildListLocked()
{

    return true;
}




public new void DidAdoptChild(FlutterSDK.Rendering.Box.RenderBox child)
{

    SliverMultiBoxAdaptorParentData childParentData = child.ParentData as SliverMultiBoxAdaptorParentData;
    childParentData.Index = _CurrentlyUpdatingChildIndex;
}




public new void SetDidUnderflow(bool value)
{
    _DidUnderflow = value;
}




public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, int slot)
{



    RenderObject.Insert(child as RenderBox, after: _CurrentBeforeChild);

}


public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
{



    RenderObject.Insert(child as RenderBox, after: _CurrentBeforeChild);

}




public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, int slot)
{


    RenderObject.Move(child as RenderBox, after: _CurrentBeforeChild);
}


public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
{


    RenderObject.Move(child as RenderBox, after: _CurrentBeforeChild);
}




public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
{

    RenderObject.Remove(child as RenderBox);
}




public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
{

    _ChildElements.Values.ToList().ForEach(visitor);
}




public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
{
    _ChildElements.Values.Where((Element child) =>
    {
        SliverMultiBoxAdaptorParentData parentData = child.RenderObject.ParentData as SliverMultiBoxAdaptorParentData;
        double itemExtent = default(double);
        switch (RenderObject.Constraints.Axis) { case Axis.Horizontal: itemExtent = child.RenderObject.PaintBounds.Width; break; case Axis.Vertical: itemExtent = child.RenderObject.PaintBounds.Height; break; }
        return parentData.LayoutOffset != null && parentData.LayoutOffset < RenderObject.Constraints.ScrollOffset + RenderObject.Constraints.RemainingPaintExtent && parentData.LayoutOffset + itemExtent > RenderObject.Constraints.ScrollOffset;
    }
    ).ForEach(visitor);
}



#endregion
}


/// <Summary>
/// A sliver widget that makes its sliver child partially transparent.
///
/// This class paints its sliver child into an intermediate buffer and then
/// blends the sliver back into the scene partially transparent.
///
/// For values of opacity other than 0.0 and 1.0, this class is relatively
/// expensive because it requires painting the sliver child into an intermediate
/// buffer. For the value 0.0, the sliver child is simply not painted at all.
/// For the value 1.0, the sliver child is painted immediately without an
/// intermediate buffer.
///
/// {@tool snippet}
///
/// This example shows a [SliverList] when the `_visible` member field is true,
/// and hides it when it is false:
///
/// ```dart
/// bool _visible = true;
/// List<Widget> listItems = <Widget>[
///   Text('Now you see me,'),
///   Text("Now you don't!"),
/// ];
///
/// SliverOpacity(
///   opacity: _visible ? 1.0 : 0.0,
///   sliver: SliverList(
///     delegate: SliverChildListDelegate(listItems),
///   ),
/// )
/// ```
/// {@end-tool}
///
/// This is more efficient than adding and removing the sliver child widget
/// from the tree on demand.
///
/// See also:
///
///  * [Opacity], which can apply a uniform alpha effect to its child using the
///    RenderBox layout protocol.
///  * [AnimatedOpacity], which uses an animation internally to efficiently
///    animate [Opacity].
/// </Summary>
public class SliverOpacity : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public SliverOpacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double opacity = default(double), bool alwaysIncludeSemantics = false, FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: sliver)

}
#endregion

#region fields
public virtual double Opacity { get; set; }
public virtual bool AlwaysIncludeSemantics { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.Proxysliver.RenderSliverOpacity CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new RenderSliverOpacity(opacity: Opacity, alwaysIncludeSemantics: AlwaysIncludeSemantics);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverOpacity renderObject)
{
    ..Opacity = Opacity..AlwaysIncludeSemantics = AlwaysIncludeSemantics;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    ..Opacity = Opacity..AlwaysIncludeSemantics = AlwaysIncludeSemantics;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<double>("opacity", Opacity));
    properties.Add(new FlagProperty("alwaysIncludeSemantics", value: AlwaysIncludeSemantics, ifTrue: "alwaysIncludeSemantics"));
}



#endregion
}


/// <Summary>
/// A sliver widget that is invisible during hit testing.
///
/// When [ignoring] is true, this widget (and its subtree) is invisible
/// to hit testing. It still consumes space during layout and paints its sliver
/// child as usual. It just cannot be the target of located events, because it
/// returns false from [RenderSliver.hitTest].
///
/// When [ignoringSemantics] is true, the subtree will be invisible to
/// the semantics layer (and thus e.g. accessibility tools). If
/// [ignoringSemantics] is null, it uses the value of [ignoring].
/// </Summary>
public class SliverIgnorePointer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public SliverIgnorePointer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool ignoring = true, bool ignoringSemantics = default(bool), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: sliver)

}
#endregion

#region fields
public virtual bool Ignoring { get; set; }
public virtual bool IgnoringSemantics { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.Proxysliver.RenderSliverIgnorePointer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new RenderSliverIgnorePointer(ignoring: Ignoring, ignoringSemantics: IgnoringSemantics);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverIgnorePointer renderObject)
{
    ..Ignoring = Ignoring..IgnoringSemantics = IgnoringSemantics;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    ..Ignoring = Ignoring..IgnoringSemantics = IgnoringSemantics;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("ignoring", Ignoring));
    properties.Add(new DiagnosticsProperty<bool>("ignoringSemantics", IgnoringSemantics, defaultValue: null));
}



#endregion
}


/// <Summary>
/// A sliver that lays its sliver child out as if it was in the tree, but
/// without painting anything, without making the sliver child available for hit
/// testing, and without taking any room in the parent.
///
/// Animations continue to run in offstage sliver children, and therefore use
/// battery and CPU time, regardless of whether the animations end up being
/// visible.
///
/// To hide a sliver widget from view while it is
/// not needed, prefer removing the widget from the tree entirely rather than
/// keeping it alive in an [Offstage] subtree.
/// </Summary>
public class SliverOffstage : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public SliverOffstage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool offstage = true, FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: sliver)

}
#endregion

#region fields
public virtual bool Offstage { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.Proxysliver.RenderSliverOffstage CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderSliverOffstage(offstage: Offstage);



public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverOffstage renderObject)
{
    renderObject.Offstage = Offstage;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.Offstage = Offstage;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("offstage", Offstage));
}




public new FlutterSDK.Widgets.Sliver._SliverOffstageElement CreateElement() => new _SliverOffstageElement(this);


#endregion
}


public class _SliverOffstageElement : FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement
{
    #region constructors
    public _SliverOffstageElement(FlutterSDK.Widgets.Sliver.SliverOffstage widget)
    : base(widget)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Sliver.SliverOffstage Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
{
    if (!Widget.Offstage) base.DebugVisitOnstageChildren(visitor);
}



#endregion
}


/// <Summary>
/// Mark a child as needing to stay alive even when it's in a lazy list that
/// would otherwise remove it.
///
/// This widget is for use in [SliverWithKeepAliveWidget]s, such as
/// [SliverGrid] or [SliverList].
///
/// This widget is rarely used directly. The [SliverChildBuilderDelegate] and
/// [SliverChildListDelegate] delegates, used with [SliverList] and
/// [SliverGrid], as well as the scroll view counterparts [ListView] and
/// [GridView], have an `addAutomaticKeepAlives` feature, which is enabled by
/// default, and which causes [AutomaticKeepAlive] widgets to be inserted around
/// each child, causing [KeepAlive] widgets to be automatically added and
/// configured in response to [KeepAliveNotification]s.
///
/// Therefore, to keep a widget alive, it is more common to use those
/// notifications than to directly deal with [KeepAlive] widgets.
///
/// In practice, the simplest way to deal with these notifications is to mix
/// [AutomaticKeepAliveClientMixin] into one's [State]. See the documentation
/// for that mixin class for details.
/// </Summary>
public class KeepAlive : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Slivermultiboxadaptor.KeepAliveParentDataMixin>
{
    #region constructors
    public KeepAlive(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool keepAlive = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: child)

}
#endregion

#region fields
public virtual bool KeepAliveValue { get; set; }
public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject)
{

    KeepAliveParentDataMixin parentData = renderObject.ParentData as KeepAliveParentDataMixin;
    if (parentData.KeepAlive != KeepAlive)
    {
        parentData.KeepAlive = KeepAlive;
        AbstractNode targetParent = renderObject.Parent;
        if (((RenderObject)targetParent) is RenderObject && !KeepAlive) ((RenderObject)targetParent).MarkNeedsLayout();
    }

}




public new bool DebugCanApplyOutOfTurn() => KeepAlive;



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("keepAlive", KeepAlive));
}



#endregion
}

}
