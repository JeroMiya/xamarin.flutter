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
namespace FlutterSDK.Widgets.Animatedcrossfade
{
    /// <Summary>
    /// Signature for the [AnimatedCrossFade.layoutBuilder] callback.
    ///
    /// The `topChild` is the child fading in, which is normally drawn on top. The
    /// `bottomChild` is the child fading out, normally drawn on the bottom.
    ///
    /// For good performance, the returned widget tree should contain both the
    /// `topChild` and the `bottomChild`; the depth of the tree, and the types of
    /// the widgets in the tree, from the returned widget to each of the children
    /// should be the same; and where there is a widget with multiple children, the
    /// top child and the bottom child should be keyed using the provided
    /// `topChildKey` and `bottomChildKey` keys respectively.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// Widget defaultLayoutBuilder(Widget topChild, Key topChildKey, Widget bottomChild, Key bottomChildKey) {
    ///   return Stack(
    ///     fit: StackFit.loose,
    ///     children: <Widget>[
    ///       Positioned(
    ///         key: bottomChildKey,
    ///         left: 0.0,
    ///         top: 0.0,
    ///         right: 0.0,
    ///         child: bottomChild,
    ///       ),
    ///       Positioned(
    ///         key: topChildKey,
    ///         child: topChild,
    ///       )
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedCrossFadeBuilder(FlutterSDK.Widgets.Framework.Widget topChild, FlutterSDK.Foundation.Key.Key topChildKey, FlutterSDK.Widgets.Framework.Widget bottomChild, FlutterSDK.Foundation.Key.Key bottomChildKey);
    internal static class AnimatedcrossfadeDefaultClass
    {
    }

    /// <Summary>
    /// A widget that cross-fades between two given children and animates itself
    /// between their sizes.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=PGK2UUAyE54}
    ///
    /// The animation is controlled through the [crossFadeState] parameter.
    /// [firstCurve] and [secondCurve] represent the opacity curves of the two
    /// children. The [firstCurve] is inverted, i.e. it fades out when providing a
    /// growing curve like [Curves.linear]. The [sizeCurve] is the curve used to
    /// animate between the size of the fading-out child and the size of the
    /// fading-in child.
    ///
    /// This widget is intended to be used to fade a pair of widgets with the same
    /// width. In the case where the two children have different heights, the
    /// animation crops overflowing children during the animation by aligning their
    /// top edge, which means that the bottom will be clipped.
    ///
    /// The animation is automatically triggered when an existing
    /// [AnimatedCrossFade] is rebuilt with a different value for the
    /// [crossFadeState] property.
    ///
    /// {@tool snippet}
    ///
    /// This code fades between two representations of the Flutter logo. It depends
    /// on a boolean field `_first`; when `_first` is true, the first logo is shown,
    /// otherwise the second logo is shown. When the field changes state, the
    /// [AnimatedCrossFade] widget cross-fades between the two forms of the logo
    /// over three seconds.
    ///
    /// ```dart
    /// AnimatedCrossFade(
    ///   duration: const Duration(seconds: 3),
    ///   firstChild: const FlutterLogo(style: FlutterLogoStyle.horizontal, size: 100.0),
    ///   secondChild: const FlutterLogo(style: FlutterLogoStyle.stacked, size: 100.0),
    ///   crossFadeState: _first ? CrossFadeState.showFirst : CrossFadeState.showSecond,
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [AnimatedOpacity], which fades between nothing and a single child.
    ///  * [AnimatedSwitcher], which switches out a child for a new one with a
    ///    customizable transition, supporting multiple cross-fades at once.
    ///  * [AnimatedSize], the lower-level widget which [AnimatedCrossFade] uses to
    ///    automatically change size.
    /// </Summary>
    public class AnimatedCrossFade : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a cross-fade animation widget.
        ///
        /// The [duration] of the animation is the same for all components (fade in,
        /// fade out, and size), and you can pass [Interval]s instead of [Curve]s in
        /// order to have finer control, e.g., creating an overlap between the fades.
        ///
        /// All the arguments other than [key] must be non-null.
        /// </Summary>
        public AnimatedCrossFade(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget firstChild = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget secondChild = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Curves.Curve firstCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Animation.Curves.Curve secondCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Animation.Curves.Curve sizeCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Animatedcrossfade.CrossFadeState crossFadeState = default(FlutterSDK.Widgets.Animatedcrossfade.CrossFadeState), TimeSpan duration = default(TimeSpan), TimeSpan reverseDuration = default(TimeSpan), FlutterSDK.Widgets.Animatedcrossfade.AnimatedCrossFadeBuilder layoutBuilder = default(FlutterSDK.Widgets.Animatedcrossfade.AnimatedCrossFadeBuilder))
        : base(key: key)
        {
            this.FirstChild = firstChild;
            this.SecondChild = secondChild;
            this.FirstCurve = firstCurve;
            this.SecondCurve = secondCurve;
            this.SizeCurve = sizeCurve;
            this.Alignment = alignment;
            this.CrossFadeState = crossFadeState;
            this.Duration = duration;
            this.ReverseDuration = reverseDuration;
            this.LayoutBuilder = layoutBuilder;
        }
        /// <Summary>
        /// The child that is visible when [crossFadeState] is
        /// [CrossFadeState.showFirst]. It fades out when transitioning
        /// [crossFadeState] from [CrossFadeState.showFirst] to
        /// [CrossFadeState.showSecond] and vice versa.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget FirstChild { get; set; }
        /// <Summary>
        /// The child that is visible when [crossFadeState] is
        /// [CrossFadeState.showSecond]. It fades in when transitioning
        /// [crossFadeState] from [CrossFadeState.showFirst] to
        /// [CrossFadeState.showSecond] and vice versa.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget SecondChild { get; set; }
        /// <Summary>
        /// The child that will be shown when the animation has completed.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Animatedcrossfade.CrossFadeState CrossFadeState { get; set; }
        /// <Summary>
        /// The duration of the whole orchestrated animation.
        /// </Summary>
        public virtual TimeSpan Duration { get; set; }
        /// <Summary>
        /// The duration of the whole orchestrated animation when running in reverse.
        ///
        /// If not supplied, this defaults to [duration].
        /// </Summary>
        public virtual TimeSpan ReverseDuration { get; set; }
        /// <Summary>
        /// The fade curve of the first child.
        ///
        /// Defaults to [Curves.linear].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve FirstCurve { get; set; }
        /// <Summary>
        /// The fade curve of the second child.
        ///
        /// Defaults to [Curves.linear].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve SecondCurve { get; set; }
        /// <Summary>
        /// The curve of the animation between the two children's sizes.
        ///
        /// Defaults to [Curves.linear].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve SizeCurve { get; set; }
        /// <Summary>
        /// How the children should be aligned while the size is animating.
        ///
        /// Defaults to [Alignment.topCenter].
        ///
        /// See also:
        ///
        ///  * [Alignment], a class with convenient constants typically used to
        ///    specify an [AlignmentGeometry].
        ///  * [AlignmentDirectional], like [Alignment] for specifying alignments
        ///    relative to text direction.
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        /// <Summary>
        /// A builder that positions the [firstChild] and [secondChild] widgets.
        ///
        /// The widget returned by this method is wrapped in an [AnimatedSize].
        ///
        /// By default, this uses [AnimatedCrossFade.defaultLayoutBuilder], which uses
        /// a [Stack] and aligns the `bottomChild` to the top of the stack while
        /// providing the `topChild` as the non-positioned child to fill the provided
        /// constraints. This works well when the [AnimatedCrossFade] is in a position
        /// to change size and when the children are not flexible. However, if the
        /// children are less fussy about their sizes (for example a
        /// [CircularProgressIndicator] inside a [Center]), or if the
        /// [AnimatedCrossFade] is being forced to a particular size, then it can
        /// result in the widgets jumping about when the cross-fade state is changed.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Animatedcrossfade.AnimatedCrossFadeBuilder LayoutBuilder { get; set; }

        /// <Summary>
        /// The default layout algorithm used by [AnimatedCrossFade].
        ///
        /// The top child is placed in a stack that sizes itself to match the top
        /// child. The bottom child is positioned at the top of the same stack, sized
        /// to fit its width but without forcing the height. The stack is then
        /// clipped.
        ///
        /// This is the default value for [layoutBuilder]. It implements
        /// [AnimatedCrossFadeBuilder].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget DefaultLayoutBuilder(FlutterSDK.Widgets.Framework.Widget topChild, FlutterSDK.Foundation.Key.Key topChildKey, FlutterSDK.Widgets.Framework.Widget bottomChild, FlutterSDK.Foundation.Key.Key bottomChildKey)
        {
            return new Stack(overflow: Overflow.Visible, children: new List<Widget>() { new Positioned(key: bottomChildKey, left: 0.0, top: 0.0, right: 0.0, child: bottomChild), new Positioned(key: topChildKey, child: topChild) });
        }




        public new FlutterSDK.Widgets.Animatedcrossfade._AnimatedCrossFadeState CreateState() => new _AnimatedCrossFadeState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<CrossFadeState>("crossFadeState", CrossFadeState));
            properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment, defaultValue: AlignmentDefaultClass.Alignment.TopCenter));
            properties.Add(new IntProperty("duration", Duration.InMilliseconds, unit: "ms"));
            properties.Add(new IntProperty("reverseDuration", ReverseDuration?.InMilliseconds, unit: "ms", defaultValue: null));
        }



    }


    public class _AnimatedCrossFadeState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Animatedcrossfade.AnimatedCrossFade>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _AnimatedCrossFadeState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _FirstAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _SecondAnimation { get; set; }
        internal virtual bool _IsTransitioning { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(duration: Widget.Duration, reverseDuration: Widget.ReverseDuration, vsync: this);
            if (Widget.CrossFadeState == CrossFadeState.ShowSecond) _Controller.Value = 1.0;
            _FirstAnimation = _InitAnimation(Widget.FirstCurve, true);
            _SecondAnimation = _InitAnimation(Widget.SecondCurve, false);
            _Controller.AddStatusListener((AnimationStatus status) =>
            {
                SetState(() =>
                {
                }
                );
            }
            );
        }




        private FlutterSDK.Animation.Animation.Animation<double> _InitAnimation(FlutterSDK.Animation.Curves.Curve curve, bool inverted)
        {
            Animation<double> result = _Controller.Drive(new CurveTween(curve: curve));
            if (inverted) result = result.Drive(new Tween<double>(begin: 1.0, end: 0.0));
            return result;
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Animatedcrossfade.AnimatedCrossFade oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Duration != oldWidget.Duration) _Controller.Duration = Widget.Duration;
            if (Widget.ReverseDuration != oldWidget.ReverseDuration) _Controller.ReverseDuration = Widget.ReverseDuration;
            if (Widget.FirstCurve != oldWidget.FirstCurve) _FirstAnimation = _InitAnimation(Widget.FirstCurve, true);
            if (Widget.SecondCurve != oldWidget.SecondCurve) _SecondAnimation = _InitAnimation(Widget.SecondCurve, false);
            if (Widget.CrossFadeState != oldWidget.CrossFadeState)
            {
                switch (Widget.CrossFadeState) { case CrossFadeState.ShowFirst: _Controller.Reverse(); break; case CrossFadeState.ShowSecond: _Controller.Forward(); break; }
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Key kFirstChildKey = new ValueKey<CrossFadeState>(CrossFadeState.ShowFirst);
            Key kSecondChildKey = new ValueKey<CrossFadeState>(CrossFadeState.ShowSecond);
            bool transitioningForwards = _Controller.Status == AnimationStatus.Completed || _Controller.Status == AnimationStatus.Forward;
            Key topKey = default(Key);
            Widget topChild = default(Widget);
            Animation<double> topAnimation = default(Animation<double>);
            Key bottomKey = default(Key);
            Widget bottomChild = default(Widget);
            Animation<double> bottomAnimation = default(Animation<double>);
            if (transitioningForwards)
            {
                topKey = kSecondChildKey;
                topChild = Widget.SecondChild;
                topAnimation = _SecondAnimation;
                bottomKey = kFirstChildKey;
                bottomChild = Widget.FirstChild;
                bottomAnimation = _FirstAnimation;
            }
            else
            {
                topKey = kFirstChildKey;
                topChild = Widget.FirstChild;
                topAnimation = _FirstAnimation;
                bottomKey = kSecondChildKey;
                bottomChild = Widget.SecondChild;
                bottomAnimation = _SecondAnimation;
            }

            bottomChild = new TickerMode(key: bottomKey, enabled: _IsTransitioning, child: new ExcludeSemantics(excluding: true, child: new FadeTransition(opacity: bottomAnimation, child: bottomChild)));
            topChild = new TickerMode(key: topKey, enabled: true, child: new ExcludeSemantics(excluding: false, child: new FadeTransition(opacity: topAnimation, child: topChild)));
            return new ClipRect(child: new AnimatedSize(alignment: Widget.Alignment, duration: Widget.Duration, reverseDuration: Widget.ReverseDuration, curve: Widget.SizeCurve, vsync: this, child: Widget.LayoutBuilder(topChild, topKey, bottomChild, bottomKey)));
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
        {
            base.DebugFillProperties(description);
            description.Add(new EnumProperty<CrossFadeState>("crossFadeState", Widget.CrossFadeState));
            description.Add(new DiagnosticsProperty<AnimationController>("controller", _Controller, showName: false));
            description.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Widget.Alignment, defaultValue: AlignmentDefaultClass.Alignment.TopCenter));
        }



    }


    /// <Summary>
    /// Specifies which of two children to show. See [AnimatedCrossFade].
    ///
    /// The child that is shown will fade in, while the other will fade out.
    /// </Summary>
    public enum CrossFadeState
    {

        /// <Summary>
        /// Show the first child ([AnimatedCrossFade.firstChild]) and hide the second
        /// ([AnimatedCrossFade.secondChild]]).
        /// </Summary>
        ShowFirst,
        /// <Summary>
        /// Show the second child ([AnimatedCrossFade.secondChild]) and hide the first
        /// ([AnimatedCrossFade.firstChild]).
        /// </Summary>
        ShowSecond,
    }

}
