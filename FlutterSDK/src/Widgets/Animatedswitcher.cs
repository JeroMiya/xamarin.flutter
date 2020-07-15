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
namespace FlutterSDK.Widgets.Animatedswitcher
{
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedSwitcherTransitionBuilder(FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Animation.Animation.Animation<double> animation);
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedSwitcherLayoutBuilder(FlutterSDK.Widgets.Framework.Widget currentChild, List<FlutterSDK.Widgets.Framework.Widget> previousChildren);
    internal static class AnimatedswitcherDefaultClass
    {
    }

    public class _ChildEntry
    {
        #region constructors
        public _ChildEntry(FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget transition = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget widgetChild = default(FlutterSDK.Widgets.Framework.Widget))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
    public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Transition { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget WidgetChild { get; set; }
    #endregion

    #region methods

    #endregion
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
    #region constructors
    public AnimatedSwitcher(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), TimeSpan duration = default(TimeSpan), TimeSpan reverseDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve switchInCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Animation.Curves.Curve switchOutCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder transitionBuilder = default(FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder), FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherLayoutBuilder layoutBuilder = default(FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherLayoutBuilder))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual TimeSpan Duration { get; set; }
public virtual TimeSpan ReverseDuration { get; set; }
public virtual FlutterSDK.Animation.Curves.Curve SwitchInCurve { get; set; }
public virtual FlutterSDK.Animation.Curves.Curve SwitchOutCurve { get; set; }
public virtual FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherTransitionBuilder TransitionBuilder { get; set; }
public virtual FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcherLayoutBuilder LayoutBuilder { get; set; }
#endregion

#region methods

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
    return new Stack(children: new List<Widget>() {, previousChildren, }, alignment: AlignmentDefaultClass.Alignment.Center);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new IntProperty("duration", Duration.InMilliseconds, unit: "ms"));
    properties.Add(new IntProperty("reverseDuration", ReverseDuration?.InMilliseconds, unit: "ms", defaultValue: null));
}



#endregion
}


public class _AnimatedSwitcherState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Animatedswitcher.AnimatedSwitcher>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _AnimatedSwitcherState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Animatedswitcher._ChildEntry _CurrentEntry { get; set; }
    internal virtual HashSet<FlutterSDK.Widgets.Animatedswitcher._ChildEntry> _OutgoingEntries { get; set; }
    internal virtual List<FlutterSDK.Widgets.Framework.Widget> _OutgoingWidgets { get; set; }
    internal virtual int _ChildNumber { get; set; }
    #endregion

    #region methods

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



    #endregion
}

}
