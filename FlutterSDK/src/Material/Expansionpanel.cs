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
namespace FlutterSDK.Material.Expansionpanel
{
    /// <Summary>
    /// Signature for the callback that's called when an [ExpansionPanel] is
    /// expanded or collapsed.
    ///
    /// The position of the panel within an [ExpansionPanelList] is given by
    /// [panelIndex].
    /// </Summary>
    public delegate void ExpansionPanelCallback(int panelIndex, bool isExpanded);
    /// <Summary>
    /// Signature for the callback that's called when the header of the
    /// [ExpansionPanel] needs to rebuild.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget ExpansionPanelHeaderBuilder(FlutterSDK.Widgets.Framework.BuildContext context, bool isExpanded);
    internal static class ExpansionpanelDefaultClass
    {
        public static double _KPanelHeaderCollapsedHeight = default(double);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KPanelHeaderExpandedDefaultPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
    }

    public class _SaltedKey<S, V> : FlutterSDK.Foundation.Key.LocalKey
    {
        public _SaltedKey(S salt, V value)
        {
            this.Salt = salt;
            this.Value = value;
        }
        public virtual S Salt { get; set; }
        public virtual V Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is _SaltedKey<S, V> && other.Salt == Salt && other.Value == Value;
        }




    }


    /// <Summary>
    /// A material expansion panel. It has a header and a body and can be either
    /// expanded or collapsed. The body of the panel is only visible when it is
    /// expanded.
    ///
    /// Expansion panels are only intended to be used as children for
    /// [ExpansionPanelList].
    ///
    /// See [ExpansionPanelList] for a sample implementation.
    ///
    /// See also:
    ///
    ///  * [ExpansionPanelList]
    ///  * <https://material.io/design/components/lists.html#types>
    /// </Summary>
    public class ExpansionPanel
    {
        /// <Summary>
        /// Creates an expansion panel to be used as a child for [ExpansionPanelList].
        /// See [ExpansionPanelList] for an example on how to use this widget.
        ///
        /// The [headerBuilder], [body], and [isExpanded] arguments must not be null.
        /// </Summary>
        public ExpansionPanel(FlutterSDK.Material.Expansionpanel.ExpansionPanelHeaderBuilder headerBuilder = default(FlutterSDK.Material.Expansionpanel.ExpansionPanelHeaderBuilder), FlutterSDK.Widgets.Framework.Widget body = default(FlutterSDK.Widgets.Framework.Widget), bool isExpanded = false, bool canTapOnHeader = false)
        : base()
        {
            this.HeaderBuilder = headerBuilder;
            this.Body = body;
            this.IsExpanded = isExpanded;
            this.CanTapOnHeader = canTapOnHeader;
        }
        /// <Summary>
        /// The widget builder that builds the expansion panels' header.
        /// </Summary>
        public virtual FlutterSDK.Material.Expansionpanel.ExpansionPanelHeaderBuilder HeaderBuilder { get; set; }
        /// <Summary>
        /// The body of the expansion panel that's displayed below the header.
        ///
        /// This widget is visible only when the panel is expanded.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Body { get; set; }
        /// <Summary>
        /// Whether the panel is expanded.
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool IsExpanded { get; set; }
        /// <Summary>
        /// Whether tapping on the panel's header will expand/collapse it.
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool CanTapOnHeader { get; set; }
    }


    /// <Summary>
    /// An expansion panel that allows for radio-like functionality.
    /// This means that at any given time, at most, one [ExpansionPanelRadio]
    /// can remain expanded.
    ///
    /// A unique identifier [value] must be assigned to each panel.
    /// This identifier allows the [ExpansionPanelList] to determine
    /// which [ExpansionPanelRadio] instance should be expanded.
    ///
    /// See [ExpansionPanelList.radio] for a sample implementation.
    /// </Summary>
    public class ExpansionPanelRadio : FlutterSDK.Material.Expansionpanel.ExpansionPanel
    {
        /// <Summary>
        /// An expansion panel that allows for radio functionality.
        ///
        /// A unique [value] must be passed into the constructor. The
        /// [headerBuilder], [body], [value] must not be null.
        /// </Summary>
        public ExpansionPanelRadio(@Object value = default(@Object), FlutterSDK.Material.Expansionpanel.ExpansionPanelHeaderBuilder headerBuilder = default(FlutterSDK.Material.Expansionpanel.ExpansionPanelHeaderBuilder), FlutterSDK.Widgets.Framework.Widget body = default(FlutterSDK.Widgets.Framework.Widget), bool canTapOnHeader = false)
        : base(body: body, headerBuilder: headerBuilder, canTapOnHeader: canTapOnHeader)
        {
            this.Value = value;
        }
        /// <Summary>
        /// The value that uniquely identifies a radio panel so that the currently
        /// selected radio panel can be identified.
        /// </Summary>
        public virtual @Object Value { get; set; }
    }


    /// <Summary>
    /// A material expansion panel list that lays out its children and animates
    /// expansions.
    ///
    /// Note that [expansionCallback] behaves differently for [ExpansionPanelList]
    /// and [ExpansionPanelList.radio].
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    ///
    /// Here is a simple example of how to implement ExpansionPanelList.
    ///
    /// ```dart preamble
    /// // stores ExpansionPanel state information
    /// class Item {
    ///   Item({
    ///     this.expandedValue,
    ///     this.headerValue,
    ///     this.isExpanded = false,
    ///   });
    ///
    ///   String expandedValue;
    ///   String headerValue;
    ///   bool isExpanded;
    /// }
    ///
    /// List<Item> generateItems(int numberOfItems) {
    ///   return List.generate(numberOfItems, (int index) {
    ///     return Item(
    ///       headerValue: 'Panel $index',
    ///       expandedValue: 'This is item number $index',
    ///     );
    ///   });
    /// }
    /// ```
    ///
    /// ```dart
    /// List<Item> _data = generateItems(8);
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return SingleChildScrollView(
    ///     child: Container(
    ///       child: _buildPanel(),
    ///     ),
    ///   );
    /// }
    ///
    /// Widget _buildPanel() {
    ///   return ExpansionPanelList(
    ///     expansionCallback: (int index, bool isExpanded) {
    ///       setState(() {
    ///         _data[index].isExpanded = !isExpanded;
    ///       });
    ///     },
    ///     children: _data.map<ExpansionPanel>((Item item) {
    ///       return ExpansionPanel(
    ///         headerBuilder: (BuildContext context, bool isExpanded) {
    ///           return ListTile(
    ///             title: Text(item.headerValue),
    ///           );
    ///         },
    ///         body: ListTile(
    ///           title: Text(item.expandedValue),
    ///           subtitle: Text('To delete this panel, tap the trash can icon'),
    ///           trailing: Icon(Icons.delete),
    ///           onTap: () {
    ///             setState(() {
    ///               _data.removeWhere((currentItem) => item == currentItem);
    ///             });
    ///           }
    ///         ),
    ///         isExpanded: item.isExpanded,
    ///       );
    ///     }).toList(),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ExpansionPanel]
    ///  * [ExpansionPanelList.radio]
    ///  * <https://material.io/design/components/lists.html#types>
    /// </Summary>
    public class ExpansionPanelList : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates an expansion panel list widget. The [expansionCallback] is
        /// triggered when an expansion panel expand/collapse button is pushed.
        ///
        /// The [children] and [animationDuration] arguments must not be null.
        /// </Summary>
        public ExpansionPanelList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Material.Expansionpanel.ExpansionPanel> children = default(List<FlutterSDK.Material.Expansionpanel.ExpansionPanel>), FlutterSDK.Material.Expansionpanel.ExpansionPanelCallback expansionCallback = default(FlutterSDK.Material.Expansionpanel.ExpansionPanelCallback), TimeSpan animationDuration = default(TimeSpan), FlutterSDK.Painting.Edgeinsets.EdgeInsets expandedHeaderPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets))
        : base(key: key)
        {
            this.Children = children;
            this.ExpansionCallback = expansionCallback;
            this.AnimationDuration = animationDuration;
            this.ExpandedHeaderPadding = expandedHeaderPadding;
        }
        /// <Summary>
        /// Creates a radio expansion panel list widget.
        ///
        /// This widget allows for at most one panel in the list to be open.
        /// The expansion panel callback is triggered when an expansion panel
        /// expand/collapse button is pushed. The [children] and [animationDuration]
        /// arguments must not be null. The [children] objects must be instances
        /// of [ExpansionPanelRadio].
        ///
        /// {@tool dartpad --template=stateful_widget_scaffold}
        ///
        /// Here is a simple example of how to implement ExpansionPanelList.radio.
        ///
        /// ```dart preamble
        /// // stores ExpansionPanel state information
        /// class Item {
        ///   Item({
        ///     this.id,
        ///     this.expandedValue,
        ///     this.headerValue,
        ///   });
        ///
        ///   int id;
        ///   String expandedValue;
        ///   String headerValue;
        /// }
        ///
        /// List<Item> generateItems(int numberOfItems) {
        ///   return List.generate(numberOfItems, (int index) {
        ///     return Item(
        ///       id: index,
        ///       headerValue: 'Panel $index',
        ///       expandedValue: 'This is item number $index',
        ///     );
        ///   });
        /// }
        /// ```
        ///
        /// ```dart
        /// List<Item> _data = generateItems(8);
        ///
        /// @override
        /// Widget build(BuildContext context) {
        ///   return SingleChildScrollView(
        ///     child: Container(
        ///       child: _buildPanel(),
        ///     ),
        ///   );
        /// }
        ///
        /// Widget _buildPanel() {
        ///   return ExpansionPanelList.radio(
        ///     initialOpenPanelValue: 2,
        ///     children: _data.map<ExpansionPanelRadio>((Item item) {
        ///       return ExpansionPanelRadio(
        ///         value: item.id,
        ///         headerBuilder: (BuildContext context, bool isExpanded) {
        ///           return ListTile(
        ///             title: Text(item.headerValue),
        ///           );
        ///         },
        ///         body: ListTile(
        ///           title: Text(item.expandedValue),
        ///           subtitle: Text('To delete this panel, tap the trash can icon'),
        ///           trailing: Icon(Icons.delete),
        ///           onTap: () {
        ///             setState(() {
        ///               _data.removeWhere((currentItem) => item == currentItem);
        ///             });
        ///           }
        ///         )
        ///       );
        ///     }).toList(),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public static ExpansionPanelList Radio(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Material.Expansionpanel.ExpansionPanel> children = default(List<FlutterSDK.Material.Expansionpanel.ExpansionPanel>), FlutterSDK.Material.Expansionpanel.ExpansionPanelCallback expansionCallback = default(FlutterSDK.Material.Expansionpanel.ExpansionPanelCallback), TimeSpan animationDuration = default(TimeSpan), @Object initialOpenPanelValue = default(@Object), FlutterSDK.Painting.Edgeinsets.EdgeInsets expandedHeaderPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets))
        {
            var instance = new ExpansionPanelList(key: key); instance.Children = children;
            instance.ExpansionCallback = expansionCallback;
            instance.AnimationDuration = animationDuration;
            instance.InitialOpenPanelValue = initialOpenPanelValue;
            instance.ExpandedHeaderPadding = expandedHeaderPadding;
        }
        /// <Summary>
        /// The children of the expansion panel list. They are laid out in a similar
        /// fashion to [ListBody].
        /// </Summary>
        public virtual List<FlutterSDK.Material.Expansionpanel.ExpansionPanel> Children { get; set; }
        /// <Summary>
        /// The callback that gets called whenever one of the expand/collapse buttons
        /// is pressed. The arguments passed to the callback are the index of the
        /// pressed panel and whether the panel is currently expanded or not.
        ///
        /// If ExpansionPanelList.radio is used, the callback may be called a
        /// second time if a different panel was previously open. The arguments
        /// passed to the second callback are the index of the panel that will close
        /// and false, marking that it will be closed.
        ///
        /// For ExpansionPanelList, the callback needs to setState when it's notified
        /// about the closing/opening panel. On the other hand, the callback for
        /// ExpansionPanelList.radio is simply meant to inform the parent widget of
        /// changes, as the radio panels' open/close states are managed internally.
        ///
        /// This callback is useful in order to keep track of the expanded/collapsed
        /// panels in a parent widget that may need to react to these changes.
        /// </Summary>
        public virtual FlutterSDK.Material.Expansionpanel.ExpansionPanelCallback ExpansionCallback { get; set; }
        /// <Summary>
        /// The duration of the expansion animation.
        /// </Summary>
        public virtual TimeSpan AnimationDuration { get; set; }
        internal virtual bool _AllowOnlyOnePanelOpen { get; set; }
        /// <Summary>
        /// The value of the panel that initially begins open. (This value is
        /// only used when initializing with the [ExpansionPanelList.radio]
        /// constructor.)
        /// </Summary>
        public virtual @Object InitialOpenPanelValue { get; set; }
        /// <Summary>
        /// The padding that surrounds the panel header when expanded.
        ///
        /// By default, 16px of space is added to the header vertically (above and below)
        /// during expansion.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ExpandedHeaderPadding { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _ExpansionPanelListState();


    }


    public class _ExpansionPanelListState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Expansionpanel.ExpansionPanelList>
    {
        public _ExpansionPanelListState()
        { }
        internal virtual FlutterSDK.Material.Expansionpanel.ExpansionPanelRadio _CurrentOpenPanel { get; set; }

        public new void InitState()
        {
            base.InitState();
            if (Widget._AllowOnlyOnePanelOpen)
            {

                if (Widget.InitialOpenPanelValue != null)
                {
                    _CurrentOpenPanel = SearchPanelByValue(Widget.Children.Cast(), Widget.InitialOpenPanelValue);
                }

            }

        }




        public new void DidUpdateWidget(FlutterSDK.Material.Expansionpanel.ExpansionPanelList oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget._AllowOnlyOnePanelOpen)
            {

                if (!oldWidget._AllowOnlyOnePanelOpen)
                {
                    _CurrentOpenPanel = SearchPanelByValue(Widget.Children.Cast(), Widget.InitialOpenPanelValue);
                }

            }
            else
            {
                _CurrentOpenPanel = null;
            }

        }




        private bool _AllIdentifiersUnique()
        {
            Dictionary<object, bool> identifierMap = new Dictionary<object, bool> { };
            foreach (ExpansionPanelRadio child in Widget.Children.Cast())
            {
                identifierMap[child.Value] = true;
            }

            return identifierMap.Length == Widget.Children.Count;
        }




        private bool _IsChildExpanded(int index)
        {
            if (Widget._AllowOnlyOnePanelOpen)
            {
                ExpansionPanelRadio radioWidget = Widget.Children[index] as ExpansionPanelRadio;
                return _CurrentOpenPanel?.Value == radioWidget.Value;
            }

            return Widget.Children[index].IsExpanded;
        }




        private void _HandlePressed(bool isExpanded, int index)
        {
            if (Widget.ExpansionCallback != null) Widget.ExpansionCallback(index, isExpanded);
            if (Widget._AllowOnlyOnePanelOpen)
            {
                ExpansionPanelRadio pressedChild = Widget.Children[index] as ExpansionPanelRadio;
                for (int childIndex = 0; childIndex < Widget.Children.Count; childIndex += 1)
                {
                    ExpansionPanelRadio child = Widget.Children[childIndex] as ExpansionPanelRadio;
                    if (Widget.ExpansionCallback != null && childIndex != index && child.Value == _CurrentOpenPanel?.Value) Widget.ExpansionCallback(childIndex, false);
                }

                SetState(() =>
                {
                    _CurrentOpenPanel = isExpanded ? null : pressedChild;
                }
                );
            }

        }




        public virtual FlutterSDK.Material.Expansionpanel.ExpansionPanelRadio SearchPanelByValue(List<FlutterSDK.Material.Expansionpanel.ExpansionPanelRadio> panels, @Object value)
        {
            foreach (ExpansionPanelRadio panel in panels)
            {
                if (panel.Value == value) return panel;
            }

            return null;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<MergeableMaterialItem> items = new List<MergeableMaterialItem>() { };
            for (int index = 0; index < Widget.Children.Count; index += 1)
            {
                if (_IsChildExpanded(index) && index != 0 && !_IsChildExpanded(index - 1)) items.Add(new MaterialGap(key: new _SaltedKey<BuildContext, int>(context, index * 2 - 1)));
                ExpansionPanel child = Widget.Children[index];
                Widget headerWidget = child.HeaderBuilder(context, _IsChildExpanded(index));
                Widget expandIconContainer = new Container(margin: EdgeInsetsDirectional.Only(end: 8.0), child: new ExpandIcon(isExpanded: _IsChildExpanded(index), padding: EdgeInsets.All(16.0), onPressed: !child.CanTapOnHeader ? (bool isExpanded) => =>_HandlePressed(isExpanded, index):null ));
            if (!child.CanTapOnHeader)
            {
                MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
                expandIconContainer = new Semantics(label: _IsChildExpanded(index) ? localizations.ExpandedIconTapHint : localizations.CollapsedIconTapHint, container: true, child: expandIconContainer);
            }

            Widget header = new Row(children: new List<Widget>() { new Expanded(child: new AnimatedContainer(duration: Widget.AnimationDuration, curve: CurvesDefaultClass.Curves.FastOutSlowIn, margin: _IsChildExpanded(index) ? Widget.ExpandedHeaderPadding : EdgeinsetsDefaultClass.EdgeInsets.Zero, child: new ConstrainedBox(constraints: new BoxConstraints(minHeight: ExpansionpanelDefaultClass._KPanelHeaderCollapsedHeight), child: headerWidget))), expandIconContainer });
            if (child.CanTapOnHeader)
            {
                header = new MergeSemantics(child: new InkWell(onTap: () => =>_HandlePressed(_IsChildExpanded(index), index), child: header));
            }

            items.Add(new MaterialSlice(key: new _SaltedKey<BuildContext, int>(context, index * 2), child: new Column(children: new List<Widget>() { header, new AnimatedCrossFade(firstChild: new Container(height: 0.0), secondChild: child.Body, firstCurve: new Interval(0.0, 0.6, curve: CurvesDefaultClass.Curves.FastOutSlowIn), secondCurve: new Interval(0.4, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn), sizeCurve: CurvesDefaultClass.Curves.FastOutSlowIn, crossFadeState: _IsChildExpanded(index) ? CrossFadeState.ShowSecond : CrossFadeState.ShowFirst, duration: Widget.AnimationDuration) })));
            if (_IsChildExpanded(index) && index != Widget.Children.Count - 1) items.Add(new MaterialGap(key: new _SaltedKey<BuildContext, int>(context, index * 2 + 1)));
        }

return new MergeableMaterial(hasDividers:true , children:items);
    }



}

}
