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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Painting.Boxdecoration
{
    internal static class BoxdecorationDefaultClass
    {
    }

    /// <Summary>
    /// An immutable description of how to paint a box.
    ///
    /// The [BoxDecoration] class provides a variety of ways to draw a box.
    ///
    /// The box has a [border], a body, and may cast a [boxShadow].
    ///
    /// The [shape] of the box can be a circle or a rectangle. If it is a rectangle,
    /// then the [borderRadius] property controls the roundness of the corners.
    ///
    /// The body of the box is painted in layers. The bottom-most layer is the
    /// [color], which fills the box. Above that is the [gradient], which also fills
    /// the box. Finally there is the [image], the precise alignment of which is
    /// controlled by the [DecorationImage] class.
    ///
    /// The [border] paints over the body; the [boxShadow], naturally, paints below it.
    ///
    /// {@tool snippet}
    ///
    /// The following applies a [BoxDecoration] to a [Container] widget to draw an
    /// [image] of an owl with a thick black [border] and rounded corners.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/painting/box_decoration.png)
    ///
    /// ```dart
    /// Container(
    ///   decoration: BoxDecoration(
    ///     color: const Color(0xff7c94b6),
    ///     image: const DecorationImage(
    ///       image: NetworkImage('https:///flutter.github.io/assets-for-api-docs/assets/widgets/owl-2.jpg'),
    ///       fit: BoxFit.cover,
    ///     ),
    ///     border: Border.all(
    ///       color: Colors.black,
    ///       width: 8,
    ///     ),
    ///     borderRadius: BorderRadius.circular(12),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@template flutter.painting.boxDecoration.clip}
    /// The [shape] or the [borderRadius] won't clip the children of the
    /// decorated [Container]. If the clip is required, insert a clip widget
    /// (e.g., [ClipRect], [ClipRRect], [ClipPath]) as the child of the [Container].
    /// Be aware that clipping may be costly in terms of performance.
    /// {@endtemplate}
    ///
    /// See also:
    ///
    ///  * [DecoratedBox] and [Container], widgets that can be configured with
    ///    [BoxDecoration] objects.
    ///  * [CustomPaint], a widget that lets you draw arbitrary graphics.
    ///  * [Decoration], the base class which lets you define other decorations.
    /// </Summary>
    public class BoxDecoration : FlutterSDK.Painting.Decoration.Decoration
    {
        #region constructors
        public BoxDecoration(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Decorationimage.DecorationImage image = default(FlutterSDK.Painting.Decorationimage.DecorationImage), FlutterSDK.Painting.Boxborder.BoxBorder border = default(FlutterSDK.Painting.Boxborder.BoxBorder), FlutterSDK.Painting.Borderradius.BorderRadiusGeometry borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry), List<FlutterSDK.Painting.Boxshadow.BoxShadow> boxShadow = default(List<FlutterSDK.Painting.Boxshadow.BoxShadow>), FlutterSDK.Painting.Gradient.Gradient gradient = default(FlutterSDK.Painting.Gradient.Gradient), FlutterBinding.UI.BlendMode backgroundBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape))
        : base()
        {
            this.Color = color;
            this.Image = image;
            this.Border = border;
            this.BorderRadius = borderRadius;
            this.BoxShadow = boxShadow;
            this.Gradient = gradient;
            this.BackgroundBlendMode = backgroundBlendMode;
            this.Shape = shape; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterSDK.Painting.Decorationimage.DecorationImage Image { get; set; }
        public virtual FlutterSDK.Painting.Boxborder.BoxBorder Border { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry BorderRadius { get; set; }
        public virtual List<FlutterSDK.Painting.Boxshadow.BoxShadow> BoxShadow { get; set; }
        public virtual FlutterSDK.Painting.Gradient.Gradient Gradient { get; set; }
        public virtual FlutterBinding.UI.BlendMode BackgroundBlendMode { get; set; }
        public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsComplex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxdecoration.BoxDecoration CopyWith(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Decorationimage.DecorationImage image = default(FlutterSDK.Painting.Decorationimage.DecorationImage), FlutterSDK.Painting.Boxborder.BoxBorder border = default(FlutterSDK.Painting.Boxborder.BoxBorder), FlutterSDK.Painting.Borderradius.BorderRadiusGeometry borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry), List<FlutterSDK.Painting.Boxshadow.BoxShadow> boxShadow = default(List<FlutterSDK.Painting.Boxshadow.BoxShadow>), FlutterSDK.Painting.Gradient.Gradient gradient = default(FlutterSDK.Painting.Gradient.Gradient), FlutterBinding.UI.BlendMode backgroundBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape)) { throw new NotImplementedException(); }


        public new bool DebugAssertIsValid() { throw new NotImplementedException(); }


        public new Path GetClipPath(FlutterBinding.UI.Rect rect, TextDirection textDirection) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a new box decoration that is scaled by the given factor.
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxdecoration.BoxDecoration Scale(double factor) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Boxdecoration.BoxDecoration LerpFrom(FlutterSDK.Painting.Decoration.Decoration a, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Boxdecoration.BoxDecoration LerpTo(FlutterSDK.Painting.Decoration.Decoration b, double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Linearly interpolate between two box decorations.
        ///
        /// Interpolates each parameter of the box decoration separately.
        ///
        /// The [shape] is not interpolated. To interpolate the shape, consider using
        /// a [ShapeDecoration] with different border shapes.
        ///
        /// If both values are null, this returns null. Otherwise, it returns a
        /// non-null value. If one of the values is null, then the result is obtained
        /// by applying [scale] to the other value. If neither value is null and `t ==
        /// 0.0`, then `a` is returned unmodified; if `t == 1.0` then `b` is returned
        /// unmodified. Otherwise, the values are computed by interpolating the
        /// properties appropriately.
        ///
        /// {@macro dart.ui.shadow.lerp}
        ///
        /// See also:
        ///
        ///  * [Decoration.lerp], which can interpolate between any two types of
        ///    [Decoration]s, not just [BoxDecoration]s.
        ///  * [lerpFrom] and [lerpTo], which are used to implement [Decoration.lerp]
        ///    and which use [BoxDecoration.lerp] when interpolating two
        ///    [BoxDecoration]s or a [BoxDecoration] to or from null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxdecoration.BoxDecoration Lerp(FlutterSDK.Painting.Boxdecoration.BoxDecoration a, FlutterSDK.Painting.Boxdecoration.BoxDecoration b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new bool HitTest(Size size, FlutterBinding.UI.Offset position, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Boxdecoration._BoxDecorationPainter CreateBoxPainter(VoidCallback onChanged = default(VoidCallback)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An object that paints a [BoxDecoration] into a canvas.
    /// </Summary>
    public class _BoxDecorationPainter : FlutterSDK.Painting.Decoration.BoxPainter
    {
        #region constructors
        public _BoxDecorationPainter(FlutterSDK.Painting.Boxdecoration.BoxDecoration _decoration, VoidCallback onChanged)
        : base(onChanged)
        {
            this._Decoration = _decoration; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Boxdecoration.BoxDecoration _Decoration { get; set; }
        internal virtual SKPaint _CachedBackgroundPaint { get; set; }
        internal virtual FlutterBinding.UI.Rect _RectForCachedBackgroundPaint { get; set; }
        internal virtual FlutterSDK.Painting.Decorationimage.DecorationImagePainter _ImagePainter { get; set; }
        #endregion

        #region methods

        private Paint _GetBackgroundPaint(FlutterBinding.UI.Rect rect, TextDirection textDirection) { throw new NotImplementedException(); }


        private void _PaintBox(Canvas canvas, FlutterBinding.UI.Rect rect, SKPaint paint, TextDirection textDirection) { throw new NotImplementedException(); }


        private void _PaintShadows(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection) { throw new NotImplementedException(); }


        private void _PaintBackgroundColor(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection) { throw new NotImplementedException(); }


        private void _PaintBackgroundImage(Canvas canvas, FlutterBinding.UI.Rect rect, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        /// <Summary>
        /// Paint the box decoration into the given location on the given canvas
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        #endregion
    }

}
