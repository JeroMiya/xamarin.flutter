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
namespace FlutterSDK.Widgets.Animatedswitcher
{
    /// <Summary>
    /// Signature for builders used to generate custom transitions for
    /// [AnimatedSwitcher].
    ///
    /// The `child` should be transitioning in when the `animation` is running in
    /// the forward direction.
    ///
    /// The function should return a widget which wraps the given `child`. It may
    /// also use the `animation` to inform its transition. It must not return null.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedSwitcherTransitionBuilder(FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Animation.Animation.Animation<double> animation);
    /// <Summary>
    /// Signature for builders used to generate custom layouts for
    /// [AnimatedSwitcher].
    ///
    /// The builder should return a widget which contains the given children, laid
    /// out as desired. It must not return null. The builder should be able to
    /// handle an empty list of `previousChildren`, or a null `currentChild`.
    ///
    /// The `previousChildren` list is an unmodifiable list, sorted with the oldest
    /// at the beginning and the newest at the end. It does not include the
    /// `currentChild`.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedSwitcherLayoutBuilder(FlutterSDK.Widgets.Framework.Widget currentChild, List<FlutterSDK.Widgets.Framework.Widget> previousChildren);
    internal static class AnimatedswitcherDefaultClass
    {
    }

    public class _ChildEntry
    {
        public _ChildEntry(FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget transition = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget widgetChild = default(FlutterSDK.Widgets.Framework.Widget))
        : base()
        {
            this.Controller = controller;
            this.Animation = animation;
            this.Transition = transition;
            this.WidgetChild = widgetChild;
        }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Transition { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget WidgetChild { get; set; }

    }


    /// <Summary>
    /// A widget that by default does a cross-fade between a new widget and the
    /// widget previously set on the [AnimatedSwitcher] as a child.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=2W7POjFb88g}
    ///
    /// If they are swapped fast enough (i.e. before [duration] elapses), more than
    /// one previous child can exist and be transitioning out while the newest one
    /// is transitioning in.
    ///
    /// If the "new" child is the same widget type and key as the "old" child, but
    /// with different parameters, then [AnimatedSwitcher] will *not* do a
    /// transition between them, since as far as the framework is concerned, they
    /// are the same widget and the existing widget can be updated with the new
    /// parameters. To force the transition to occur, set a [Key] on each child
    /// widget that you wish to be considered unique (typically a [ValueKey] on the
    /// widget data that distinguishes this child from the others).
    ///
    /// The same key can be used for a new child as was used for an already-outgoing
    /// child; the two will not be considered related. (For example, if a progress
    /// indicator with key A is first shown, then an image with key B, then another
    /// progress indicator with key A again, all in rapid succession, then the old
    /// progress indicator and the image will be fading out while a new progress
    /// indicator is fading in.)
    ///
    /// The type of transition can be changed from a cross-fade to a custom
    /// transition by setting the [transitionBuilder].
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This sample shows a counter that animates the scale of a text widget
    /// whenever the value changes.
    ///
    /// ```dart
    /// int _count = 0;
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Container(
    ///     color: Colors.white,
    ///     child: Column(
    ///       mainAxisAlignment: MainAxisAlignment.center,
    ///       children: <Widget>[
    ///         AnimatedSwitcher(
    ///           duration: const Duration(milliseconds: 500),
    ///           transitionBuilder: (Widget child, Animation<double> animation) {
    ///             return ScaleTransition(child: child, scale: animation);
    ///           },
    ///           child: Text(
    ///             '$_count',
    ///             // This key causes the AnimatedSwitcher to interpret this as a "new"
    ///             // child each time the count changes, so that it will begin its animation
    ///             // when the count changes.
    ///             key: ValueKey<int>(_count),
    ///             style: Theme.of(context).textTheme.headline4,
    ///           ),
    ///         ),
    ///         RaisedButton(
    ///           child: const Text('Increment'),
    ///           onPressed: () {
    ///             setState(() {
    ///               _count += 1;
    ///             });
    ///           },
    ///         ),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [AnimatedCrossFade], which only fades between two children, but also
    ///    interpolates their sizes, and is reversible.
    ///  * [AnimatedOpacity], which can be used to switch between nothingness and
    ///    a given child by fading the child in and out.
    ///  * [FadeTransition], which [AnimatedSwitcher] uses to perform the transition.
    /// </Summary>
    public class AnimatedSwitcher : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates an [AnimatedSwitcher].
        ///
        /// The [duration], [transitionBuilder], [layoutBuilder], [switchInCurve], and
        /// [switchOutCurve] parameters must not be null.
        /// </Summary>
        public AnimatedSwitcher(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), TimeSpan duration = default(TimeSpan), TimeSpan reverseDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve switchInCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Animation.Curves.Curve switchOutCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder transitionBuilder = default(FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder), FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherLayoutBuilder layoutBuilder = default(FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherLayoutBuilder))
        : base(key: key)
        {
            this.Child = child;
            this.Duration = duration;
            this.ReverseDuration = reverseDuration;
            this.SwitchInCurve = switchInCurve;
            this.SwitchOutCurve = switchOutCurve;
            this.TransitionBuilder = transitionBuilder;
            this.LayoutBuilder = layoutBuilder;
        }
        /// <Summary>
        /// The current child widget to display. If there was a previous child, then
        /// that child will be faded out using the [switchOutCurve], while the new
        /// child is faded in with the [switchInCurve], over the [duration].
        ///
        /// If there was no previous child, then this child will fade in using the
        /// [switchInCurve] over the [duration].
        ///
        /// The child is considered to be "new" if it has a different type or [Key]
        /// (see [Widget.canUpdate]).
        ///
        /// To change the kind of transition used, see [transitionBuilder].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The duration of the transition from the old [child] value to the new one.
        ///
        /// This duration is applied to the given [child] when that property is set to
        /// a new child. The same duration is used when fading out, unless
        /// [reverseDuration] is set. Changing [duration] will not affect the
        /// durations of transitions already in progress.
        /// </Summary>
        public virtual TimeSpan Duration { get; set; }
        /// <Summary>
        /// The duration of the transition from the new [child] value to the old one.
        ///
        /// This duration is applied to the given [child] when that property is set to
        /// a new child. Changing [reverseDuration] will not affect the durations of
        /// transitions already in progress.
        ///
        /// If not set, then the value of [duration] is used by default.
        /// </Summary>
        public virtual TimeSpan ReverseDuration { get; set; }
        /// <Summary>
        /// The animation curve to use when transitioning in a new [child].
        ///
        /// This curve is applied to the given [child] when that property is set to a
        /// new child. Changing [switchInCurve] will not affect the curve of a
        /// transition already in progress.
        ///
        /// The [switchOutCurve] is used when fading out, except that if [child] is
        /// changed while the current child is in the middle of fading in,
        /// [switchInCurve] will be run in reverse from that point instead of jumping
        /// to the corresponding point on [switchOutCurve].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve SwitchInCurve { get; set; }
        /// <Summary>
        /// The animation curve to use when transitioning a previous [child] out.
        ///
        /// This curve is applied to the [child] when the child is faded in (or when
        /// the widget is created, for the first child). Changing [switchOutCurve]
        /// will not affect the curves of already-visible widgets, it only affects the
        /// curves of future children.
        ///
        /// If [child] is changed while the current child is in the middle of fading
        /// in, [switchInCurve] will be run in reverse from that point instead of
        /// jumping to the corresponding point on [switchOutCurve].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve SwitchOutCurve { get; set; }
        /// <Summary>
        /// A function that wraps a new [child] with an animation that transitions
        /// the [child] in when the animation runs in the forward direction and out
        /// when the animation runs in the reverse direction. This is only called
        /// when a new [child] is set (not for each build), or when a new
        /// [transitionBuilder] is set. If a new [transitionBuilder] is set, then
        /// the transition is rebuilt for the current child and all previous children
        /// using the new [transitionBuilder]. The function must not return null.
        ///
        /// The default is [AnimatedSwitcher.defaultTransitionBuilder].
        ///
        /// The animation provided to the builder has the [duration] and
        /// [switchInCurve] or [switchOutCurve] applied as provided when the
        /// corresponding [child] was first provided.
        ///
        /// See also:
        ///
        ///  * [AnimatedSwitcherTransitionBuilder] for more information about
        ///    how a transition builder should function.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder TransitionBuilder { get; set; }
        /// <Summary>
        /// A function that wraps all of the children that are transitioning out, and
        /// the [child] that's transitioning in, with a widget that lays all of them
        /// out. This is called every time this widget is built. The function must not
        /// return null.
        ///
        /// The default is [AnimatedSwitcher.defaultLayoutBuilder].
        ///
        /// See also:
        ///
        ///  * [AnimatedSwitcherLayoutBuilder] for more information about
        ///    how a layout builder should function.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherLayoutBuilder LayoutBuilder { get; set; }

        public new FlutterSDK.Widgets.Animatedswitcher._AnimatedSwitcherState CreateState() => new _AnimatedSwitcherState();



        /// <Summary>
        /// The transition builder used as the default value of [transitionBuilder].
        ///
        /// The new child is given a [FadeTransition] which increases opacity as
        /// the animation goes from 0.0 to 1.0, and decreases when the animation is
        /// reversed.
        ///
        /// This is an [AnimatedSwitcherTransitionBuilder] function.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget DefaultTransitionBuilder(FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Animation.Animation.Animation<double> animation)
        {
            return new FadeTransition(opacity: animation, child: child);
        }




        /// <Summary>
        /// The layout builder used as the default value of [layoutBuilder].
        ///
        /// The new child is placed in a [Stack] that sizes itself to match the
        /// largest of the child or a previous child. The children are centered on
        /// each other.
        ///
        /// This is an [AnimatedSwitcherLayoutBuilder] function.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget DefaultLayoutBuilder(FlutterSDK.Widgets.Framework.Widget currentChild, List<FlutterSDK.Widgets.Framework.Widget> previousChildren)
        {
            return new Stack(children: new List<Widget>() { /* ...previousChildren, */ }, alignment: AlignmentDefaultClass.Alignment.Center);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new IntProperty("duration", Duration.InMilliseconds, unit: "ms"));
            properties.Add(new IntProperty("reverseDuration", ReverseDuration?.InMilliseconds, unit: "ms", defaultValue: null));
        }



    }


    public class _AnimatedSwitcherState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcher>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _AnimatedSwitcherState()
        { }
        internal virtual FlutterSDK.Widgets.Animatedswitcher._ChildEntry _CurrentEntry { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Animatedswitcher._ChildEntry> _OutgoingEntries { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _OutgoingWidgets { get; set; }
        internal virtual int _ChildNumber { get; set; }

        public new void InitState()
        {
            base.InitState();
            _AddEntryForNewChild(animate: false);
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcher oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.TransitionBuilder != oldWidget.TransitionBuilder)
            {
                _OutgoingEntries.ForEach(_UpdateTransitionForEntry);
                if (_CurrentEntry != null) _UpdateTransitionForEntry(_CurrentEntry);
                _MarkChildWidgetCacheAsDirty();
            }

            bool hasNewChild = Widget.Child != null;
            bool hasOldChild = _CurrentEntry != null;
            if (hasNewChild != hasOldChild || hasNewChild && !FrameworkDefaultClass.Widget.CanUpdate(Widget.Child, _CurrentEntry.WidgetChild))
            {
                _ChildNumber += 1;
                _AddEntryForNewChild(animate: true);
            }
            else if (_CurrentEntry != null)
            {


                _CurrentEntry.WidgetChild = Widget.Child;
                _UpdateTransitionForEntry(_CurrentEntry);
                _MarkChildWidgetCacheAsDirty();
            }

        }




        private void _AddEntryForNewChild(bool animate = default(bool))
        {

            if (_CurrentEntry != null)
            {


                _OutgoingEntries.Add(_CurrentEntry);
                _CurrentEntry.Controller.Reverse();
                _MarkChildWidgetCacheAsDirty();
                _CurrentEntry = null;
            }

            if (Widget.Child == null) return;
            AnimationController controller = new AnimationController(duration: Widget.Duration, reverseDuration: Widget.ReverseDuration, vsync: this);
            Animation<double> animation = new CurvedAnimation(parent: controller, curve: Widget.SwitchInCurve, reverseCurve: Widget.SwitchOutCurve);
            _CurrentEntry = _NewEntry(child: Widget.Child, controller: controller, animation: animation, builder: Widget.TransitionBuilder);
            if (animate)
            {
                controller.Forward();
            }
            else
            {

                controller.Value = 1.0;
            }

        }




        private FlutterSDK.Widgets.Animatedswitcher._ChildEntry _NewEntry(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder builder = default(FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder), FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            _ChildEntry entry = new _ChildEntry(widgetChild: child, transition: KeyedSubtree.Wrap(builder(child, animation), _ChildNumber), animation: animation, controller: controller);
            animation.AddStatusListener((AnimationStatus status) =>
            {
                if (status == AnimationStatus.Dismissed)
                {
                    SetState(() =>
                    {


                        _OutgoingEntries.Remove(entry);
                        _MarkChildWidgetCacheAsDirty();
                    }
                    );
                    controller.Dispose();
                }

            }
            );
            return entry;
        }




        private void _MarkChildWidgetCacheAsDirty()
        {
            _OutgoingWidgets = null;
        }




        private void _UpdateTransitionForEntry(FlutterSDK.Widgets.Animatedswitcher._ChildEntry entry)
        {
            entry.Transition = new KeyedSubtree(key: entry.Transition.Key, child: Widget.TransitionBuilder(entry.WidgetChild, entry.Animation));
        }




        private void _RebuildOutgoingWidgetsIfNeeded()
        {
            _OutgoingWidgets = (_OutgoingWidgets == null ? List<Widget>.Unmodifiable(_OutgoingEntries.Map((_ChildEntry entry) => =>entry.Transition)) : _OutgoingWidgets);


        }




        public new void Dispose()
        {
            if (_CurrentEntry != null) _CurrentEntry.Controller.Dispose();
            foreach (_ChildEntry entry in _OutgoingEntries) entry.Controller.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _RebuildOutgoingWidgetsIfNeeded();
            return Widget.LayoutBuilder(_CurrentEntry?.Transition, _OutgoingWidgets);
        }



    }

}
