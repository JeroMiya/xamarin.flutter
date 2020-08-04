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
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Inkdecoration
{
    internal static class InkdecorationDefaultClass
    {
    }

    /// <Summary>
    /// A convenience widget for drawing images and other decorations on [Material]
    /// widgets, so that [InkWell] and [InkResponse] splashes will render over them.
    ///
    /// Ink splashes and highlights, as rendered by [InkWell] and [InkResponse],
    /// draw on the actual underlying [Material], under whatever widgets are drawn
    /// over the material (such as [Text] and [Icon]s). If an opaque image is drawn
    /// over the [Material] (maybe using a [Container] or [DecoratedBox]), these ink
    /// effects will not be visible, as they will be entirely obscured by the opaque
    /// graphics drawn above the [Material].
    ///
    /// This widget draws the given [Decoration] directly on the [Material], in the
    /// same way that [InkWell] and [InkResponse] draw there. This allows the
    /// splashes to be drawn above the otherwise opaque graphics.
    ///
    /// An alternative solution is to use a [MaterialType.transparency] material
    /// above the opaque graphics, so that the ink responses from [InkWell]s and
    /// [InkResponse]s will be drawn on the transparent material on top of the
    /// opaque graphics, rather than under the opaque graphics on the underlying
    /// [Material].
    ///
    /// ## Limitations
    ///
    /// This widget is subject to the same limitations as other ink effects, as
    /// described in the documentation for [Material]. Most notably, the position of
    /// an [Ink] widget must not change during the lifetime of the [Material] object
    /// unless a [LayoutChangedNotification] is dispatched each frame that the
    /// position changes. This is done automatically for [ListView] and other
    /// scrolling widgets, but is not done for animated transitions such as
    /// [SlideTransition].
    ///
    /// Additionally, if multiple [Ink] widgets paint on the same [Material] in the
    /// same location, their relative order is not guaranteed. The decorations will
    /// be painted in the order that they were added to the material, which
    /// generally speaking will match the order they are given in the widget tree,
    /// but this order may appear to be somewhat random in more dynamic situations.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how a [Material] widget can have a yellow rectangle drawn
    /// on it using [Ink], while still having ink effects over the yellow rectangle:
    ///
    /// ```dart
    /// Material(
    ///   color: Colors.teal[900],
    ///   child: Center(
    ///     child: Ink(
    ///       color: Colors.yellow,
    ///       width: 200.0,
    ///       height: 100.0,
    ///       child: InkWell(
    ///         onTap: () { /* ... */ },
    ///         child: Center(
    ///           child: Text('YELLOW'),
    ///         )
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// The following example shows how an image can be printed on a [Material]
    /// widget with an [InkWell] above it:
    ///
    /// ```dart
    /// Material(
    ///   color: Colors.grey[800],
    ///   child: Center(
    ///     child: Ink.image(
    ///       image: AssetImage('cat.jpeg'),
    ///       fit: BoxFit.cover,
    ///       width: 300.0,
    ///       height: 200.0,
    ///       child: InkWell(
    ///         onTap: () { /* ... */ },
    ///         child: Align(
    ///           alignment: Alignment.topLeft,
    ///           child: Padding(
    ///             padding: const EdgeInsets.all(10.0),
    ///             child: Text('KITTEN', style: TextStyle(fontWeight: FontWeight.w900, color: Colors.white)),
    ///           ),
    ///         )
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Container], a more generic form of this widget which paints itself,
    ///    rather that deferring to the nearest [Material] widget.
    ///  * [InkDecoration], the [InkFeature] subclass used by this widget to paint
    ///    on [Material] widgets.
    ///  * [InkWell] and [InkResponse], which also draw on [Material] widgets.
    /// </Summary>
    public class Ink : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Paints a decoration (which can be a simple color) on a [Material].
        ///
        /// The [height] and [width] values include the [padding].
        ///
        /// The `color` argument is a shorthand for
        /// `decoration: BoxDecoration(color: color)`, which means you cannot supply
        /// both a `color` and a `decoration` argument. If you want to have both a
        /// `color` and a `decoration`, you can pass the color as the `color`
        /// argument to the `BoxDecoration`.
        ///
        /// If there is no intention to render anything on this decoration, consider
        /// using a [Container] with a [BoxDecoration] instead.
        /// </Summary>
        public Ink(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Padding = padding;
            this.Width = width;
            this.Height = height;
            this.Child = child;
        }
        /// <Summary>
        /// Creates a widget that shows an image (obtained from an [ImageProvider]) on
        /// a [Material].
        ///
        /// This argument is a shorthand for passing a [BoxDecoration] that has only
        /// its [BoxDecoration.image] property set to the [Ink] constructor. The
        /// properties of the [DecorationImage] of that [BoxDecoration] are set
        /// according to the arguments passed to this method.
        ///
        /// The `image` argument must not be null. If there is no
        /// intention to render anything on this image, consider using a
        /// [Container] with a [BoxDecoration.image] instead. The `onImageError`
        /// argument may be provided to listen for errors when resolving the image.
        ///
        /// The `alignment`, `repeat`, and `matchTextDirection` arguments must not
        /// be null either, but they have default values.
        ///
        /// See [paintImage] for a description of the meaning of these arguments.
        /// </Summary>
        public static Ink Image(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), ColorFilter colorFilter = default(ColorFilter), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false, double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        => new Ink(key, padding, image, onImageError, colorFilter, fit, alignment, centerSlice, repeat, matchTextDirection, width, height, child);

        private Ink(FlutterSDK.Foundation.Key.Key key, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding, FlutterSDK.Painting.Imageprovider.ImageProvider<object> image, FlutterSDK.Painting.Imagestream.ImageErrorListener onImageError, ColorFilter colorFilter, FlutterSDK.Painting.Boxfit.BoxFit fit, FlutterSDK.Painting.Alignment.AlignmentGeometry alignment, FlutterBinding.UI.Rect centerSlice, FlutterSDK.Painting.Decorationimage.ImageRepeat repeat, bool matchTextDirection, double width, double height, FlutterSDK.Widgets.Framework.Widget child)
        : base(key: key)
        {
            this.Padding = padding;
            this.Width = width;
            this.Height = height;
            this.Child = child;
        }
        /// <Summary>
        /// The [child] contained by the container.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// Empty space to inscribe inside the [decoration]. The [child], if any, is
        /// placed inside this padding.
        ///
        /// This padding is in addition to any padding inherent in the [decoration];
        /// see [Decoration.padding].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// The decoration to paint on the nearest ancestor [Material] widget.
        ///
        /// A shorthand for specifying just a solid color is available in the
        /// constructor: set the `color` argument instead of the `decoration`
        /// argument.
        ///
        /// A shorthand for specifying just an image is also available using the
        /// [Ink.image] constructor.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        /// <Summary>
        /// A width to apply to the [decoration] and the [child]. The width includes
        /// any [padding].
        /// </Summary>
        public virtual double Width { get; set; }
        /// <Summary>
        /// A height to apply to the [decoration] and the [child]. The height includes
        /// any [padding].
        /// </Summary>
        public virtual double Height { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _PaddingIncludingDecoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Decoration>("bg", Decoration, defaultValue: null));
        }




        public new FlutterSDK.Material.Inkdecoration._InkState CreateState() => new _InkState();


    }


    public class _InkState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inkdecoration.Ink>
    {
        public _InkState()
        { }
        internal virtual FlutterSDK.Material.Inkdecoration.InkDecoration _Ink { get; set; }

        private void _HandleRemoved()
        {
            _Ink = null;
        }




        public new void Deactivate()
        {
            _Ink?.Dispose();

            base.Deactivate();
        }




        private FlutterSDK.Widgets.Framework.Widget _Build(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            if (_Ink == null)
            {
                _Ink = new InkDecoration(decoration: Widget.Decoration, configuration: ImageDefaultClass.CreateLocalImageConfiguration(context), controller: MaterialDefaultClass.Material.Of(context), referenceBox: context.FindRenderObject() as RenderBox, onRemoved: _HandleRemoved);
            }
            else
            {
                _Ink.Decoration = Widget.Decoration;
                _Ink.Configuration = ImageDefaultClass.CreateLocalImageConfiguration(context);
            }

            Widget current = Widget.Child;
            EdgeInsetsGeometry effectivePadding = Widget._PaddingIncludingDecoration;
            if (effectivePadding != null) current = new Padding(padding: effectivePadding, child: current);
            return current ?? new Container();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            Widget result = new LayoutBuilder(builder: _Build);
            if (Widget.Width != null || Widget.Height != null)
            {
                result = new SizedBox(width: Widget.Width, height: Widget.Height, child: result);
            }

            return result;
        }



    }


    /// <Summary>
    /// A decoration on a part of a [Material].
    ///
    /// This object is rarely created directly. Instead of creating an ink
    /// decoration directly, consider using an [Ink] widget, which uses this class
    /// in combination with [Padding] and [ConstrainedBox] to draw a decoration on a
    /// [Material].
    ///
    /// See also:
    ///
    ///  * [Ink], the corresponding widget.
    ///  * [InkResponse], which uses gestures to trigger ink highlights and ink
    ///    splashes in the parent [Material].
    ///  * [InkWell], which is a rectangular [InkResponse] (the most common type of
    ///    ink response).
    ///  * [Material], which is the widget on which the ink is painted.
    /// </Summary>
    public class InkDecoration : FlutterSDK.Material.Material.InkFeature
    {
        /// <Summary>
        /// Draws a decoration on a [Material].
        /// </Summary>
        public InkDecoration(FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), VoidCallback onRemoved = default(VoidCallback))
        : base(controller: controller, referenceBox: referenceBox, onRemoved: onRemoved)
        {

            this.Decoration = decoration;
            controller.AddInkFeature(this);
        }


        internal virtual FlutterSDK.Painting.Decoration.BoxPainter _Painter { get; set; }
        internal virtual FlutterSDK.Painting.Decoration.Decoration _Decoration { get; set; }
        internal virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration _Configuration { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Configuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _HandleChanged()
        {
            Controller.MarkNeedsPaint();
        }




        public new void Dispose()
        {
            _Painter?.Dispose();
            base.Dispose();
        }




        public new void PaintFeature(Canvas canvas, Matrix4 transform)
        {
            if (_Painter == null) return;
            Offset originOffset = MatrixutilsDefaultClass.MatrixUtils.GetAsTranslation(transform);
            ImageConfiguration sizedConfiguration = Configuration.CopyWith(size: ReferenceBox.Size);
            if (originOffset == null)
            {
                canvas.Save();
                canvas.Transform(transform.Storage);
                _Painter.Paint(canvas, Dart.UI.UiDefaultClass.Offset.Zero, sizedConfiguration);
                canvas.Restore();
            }
            else
            {
                _Painter.Paint(canvas, originOffset, sizedConfiguration);
            }

        }



    }

}
