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
namespace FlutterSDK.Rendering.Custompaint
{
    public delegate List<FlutterSDK.Rendering.Custompaint.CustomPainterSemantics> SemanticsBuilderCallback(Size size);
    internal static class CustompaintDefaultClass
    {
    }

    /// <Summary>
    /// The interface used by [CustomPaint] (in the widgets library) and
    /// [RenderCustomPaint] (in the rendering library).
    ///
    /// To implement a custom painter, either subclass or implement this interface
    /// to define your custom paint delegate. [CustomPaint] subclasses must
    /// implement the [paint] and [shouldRepaint] methods, and may optionally also
    /// implement the [hitTest] and [shouldRebuildSemantics] methods, and the
    /// [semanticsBuilder] getter.
    ///
    /// The [paint] method is called whenever the custom object needs to be repainted.
    ///
    /// The [shouldRepaint] method is called when a new instance of the class
    /// is provided, to check if the new instance actually represents different
    /// information.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=vvI_NUXK00s}
    ///
    /// The most efficient way to trigger a repaint is to either:
    ///
    /// * Extend this class and supply a `repaint` argument to the constructor of
    ///   the [CustomPainter], where that object notifies its listeners when it is
    ///   time to repaint.
    /// * Extend [Listenable] (e.g. via [ChangeNotifier]) and implement
    ///   [CustomPainter], so that the object itself provides the notifications
    ///   directly.
    ///
    /// In either case, the [CustomPaint] widget or [RenderCustomPaint]
    /// render object will listen to the [Listenable] and repaint whenever the
    /// animation ticks, avoiding both the build and layout phases of the pipeline.
    ///
    /// The [hitTest] method is called when the user interacts with the underlying
    /// render object, to determine if the user hit the object or missed it.
    ///
    /// The [semanticsBuilder] is called whenever the custom object needs to rebuild
    /// its semantics information.
    ///
    /// The [shouldRebuildSemantics] method is called when a new instance of the
    /// class is provided, to check if the new instance contains different
    /// information that affects the semantics tree.
    ///
    /// {@tool snippet}
    ///
    /// This sample extends the same code shown for [RadialGradient] to create a
    /// custom painter that paints a sky.
    ///
    /// ```dart
    /// class Sky extends CustomPainter {
    ///   @override
    ///   void paint(Canvas canvas, Size size) {
    ///     var rect = Offset.zero & size;
    ///     var gradient = RadialGradient(
    ///       center: const Alignment(0.7, -0.6),
    ///       radius: 0.2,
    ///       colors: [const Color(0xFFFFFF00), const Color(0xFF0099FF)],
    ///       stops: [0.4, 1.0],
    ///     );
    ///     canvas.drawRect(
    ///       rect,
    ///       Paint()..shader = gradient.createShader(rect),
    ///     );
    ///   }
    ///
    ///   @override
    ///   SemanticsBuilderCallback get semanticsBuilder {
    ///     return (Size size) {
    ///       // Annotate a rectangle containing the picture of the sun
    ///       // with the label "Sun". When text to speech feature is enabled on the
    ///       // device, a user will be able to locate the sun on this picture by
    ///       // touch.
    ///       var rect = Offset.zero & size;
    ///       var width = size.shortestSide * 0.4;
    ///       rect = const Alignment(0.8, -0.9).inscribe(Size(width, width), rect);
    ///       return [
    ///         CustomPainterSemantics(
    ///           rect: rect,
    ///           properties: SemanticsProperties(
    ///             label: 'Sun',
    ///             textDirection: TextDirection.ltr,
    ///           ),
    ///         ),
    ///       ];
    ///     };
    ///   }
    ///
    ///   // Since this Sky painter has no fields, it always paints
    ///   // the same thing and semantics information is the same.
    ///   // Therefore we return false here. If we had fields (set
    ///   // from the constructor) then we would return true if any
    ///   // of them differed from the same fields on the oldDelegate.
    ///   @override
    ///   bool shouldRepaint(Sky oldDelegate) => false;
    ///   @override
    ///   bool shouldRebuildSemantics(Sky oldDelegate) => false;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Canvas], the class that a custom painter uses to paint.
    ///  * [CustomPaint], the widget that uses [CustomPainter], and whose sample
    ///    code shows how to use the above `Sky` class.
    ///  * [RadialGradient], whose sample code section shows a different take
    ///    on the sample code above.
    /// </Summary>
    public interface ICustomPainter
    {
        void AddListener(VoidCallback listener);
        void RemoveListener(VoidCallback listener);
        void Paint(Canvas canvas, Size size);
        bool ShouldRebuildSemantics(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate);
        bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate);
        bool HitTest(FlutterBinding.UI.Offset position);
        string ToString();
        FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback SemanticsBuilder { get; }
    }


    /// <Summary>
    /// The interface used by [CustomPaint] (in the widgets library) and
    /// [RenderCustomPaint] (in the rendering library).
    ///
    /// To implement a custom painter, either subclass or implement this interface
    /// to define your custom paint delegate. [CustomPaint] subclasses must
    /// implement the [paint] and [shouldRepaint] methods, and may optionally also
    /// implement the [hitTest] and [shouldRebuildSemantics] methods, and the
    /// [semanticsBuilder] getter.
    ///
    /// The [paint] method is called whenever the custom object needs to be repainted.
    ///
    /// The [shouldRepaint] method is called when a new instance of the class
    /// is provided, to check if the new instance actually represents different
    /// information.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=vvI_NUXK00s}
    ///
    /// The most efficient way to trigger a repaint is to either:
    ///
    /// * Extend this class and supply a `repaint` argument to the constructor of
    ///   the [CustomPainter], where that object notifies its listeners when it is
    ///   time to repaint.
    /// * Extend [Listenable] (e.g. via [ChangeNotifier]) and implement
    ///   [CustomPainter], so that the object itself provides the notifications
    ///   directly.
    ///
    /// In either case, the [CustomPaint] widget or [RenderCustomPaint]
    /// render object will listen to the [Listenable] and repaint whenever the
    /// animation ticks, avoiding both the build and layout phases of the pipeline.
    ///
    /// The [hitTest] method is called when the user interacts with the underlying
    /// render object, to determine if the user hit the object or missed it.
    ///
    /// The [semanticsBuilder] is called whenever the custom object needs to rebuild
    /// its semantics information.
    ///
    /// The [shouldRebuildSemantics] method is called when a new instance of the
    /// class is provided, to check if the new instance contains different
    /// information that affects the semantics tree.
    ///
    /// {@tool snippet}
    ///
    /// This sample extends the same code shown for [RadialGradient] to create a
    /// custom painter that paints a sky.
    ///
    /// ```dart
    /// class Sky extends CustomPainter {
    ///   @override
    ///   void paint(Canvas canvas, Size size) {
    ///     var rect = Offset.zero & size;
    ///     var gradient = RadialGradient(
    ///       center: const Alignment(0.7, -0.6),
    ///       radius: 0.2,
    ///       colors: [const Color(0xFFFFFF00), const Color(0xFF0099FF)],
    ///       stops: [0.4, 1.0],
    ///     );
    ///     canvas.drawRect(
    ///       rect,
    ///       Paint()..shader = gradient.createShader(rect),
    ///     );
    ///   }
    ///
    ///   @override
    ///   SemanticsBuilderCallback get semanticsBuilder {
    ///     return (Size size) {
    ///       // Annotate a rectangle containing the picture of the sun
    ///       // with the label "Sun". When text to speech feature is enabled on the
    ///       // device, a user will be able to locate the sun on this picture by
    ///       // touch.
    ///       var rect = Offset.zero & size;
    ///       var width = size.shortestSide * 0.4;
    ///       rect = const Alignment(0.8, -0.9).inscribe(Size(width, width), rect);
    ///       return [
    ///         CustomPainterSemantics(
    ///           rect: rect,
    ///           properties: SemanticsProperties(
    ///             label: 'Sun',
    ///             textDirection: TextDirection.ltr,
    ///           ),
    ///         ),
    ///       ];
    ///     };
    ///   }
    ///
    ///   // Since this Sky painter has no fields, it always paints
    ///   // the same thing and semantics information is the same.
    ///   // Therefore we return false here. If we had fields (set
    ///   // from the constructor) then we would return true if any
    ///   // of them differed from the same fields on the oldDelegate.
    ///   @override
    ///   bool shouldRepaint(Sky oldDelegate) => false;
    ///   @override
    ///   bool shouldRebuildSemantics(Sky oldDelegate) => false;
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Canvas], the class that a custom painter uses to paint.
    ///  * [CustomPaint], the widget that uses [CustomPainter], and whose sample
    ///    code shows how to use the above `Sky` class.
    ///  * [RadialGradient], whose sample code section shows a different take
    ///    on the sample code above.
    /// </Summary>
    public class CustomPainter : FlutterSDK.Foundation.Changenotifier.Listenable
    {
        public CustomPainter(FlutterSDK.Foundation.Changenotifier.Listenable repaint = default(FlutterSDK.Foundation.Changenotifier.Listenable))
        : base()
        {

        }
        internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Repaint { get; set; }
        public virtual FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback SemanticsBuilder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Register a closure to be notified when it is time to repaint.
        ///
        /// The [CustomPainter] implementation merely forwards to the same method on
        /// the [Listenable] provided to the constructor in the `repaint` argument, if
        /// it was not null.
        /// </Summary>
        public new void AddListener(VoidCallback listener) => _Repaint?.AddListener(listener);



        /// <Summary>
        /// Remove a previously registered closure from the list of closures that the
        /// object notifies when it is time to repaint.
        ///
        /// The [CustomPainter] implementation merely forwards to the same method on
        /// the [Listenable] provided to the constructor in the `repaint` argument, if
        /// it was not null.
        /// </Summary>
        public new void RemoveListener(VoidCallback listener) => _Repaint?.RemoveListener(listener);



        /// <Summary>
        /// Called whenever the object needs to paint. The given [Canvas] has its
        /// coordinate space configured such that the origin is at the top left of the
        /// box. The area of the box is the size of the [size] argument.
        ///
        /// Paint operations should remain inside the given area. Graphical
        /// operations outside the bounds may be silently ignored, clipped, or not
        /// clipped. It may sometimes be difficult to guarantee that a certain
        /// operation is inside the bounds (e.g., drawing a rectangle whose size is
        /// determined by user inputs). In that case, consider calling
        /// [Canvas.clipRect] at the beginning of [paint] so everything that follows
        /// will be guaranteed to only draw within the clipped area.
        ///
        /// Implementations should be wary of correctly pairing any calls to
        /// [Canvas.save]/[Canvas.saveLayer] and [Canvas.restore], otherwise all
        /// subsequent painting on this canvas may be affected, with potentially
        /// hilarious but confusing results.
        ///
        /// To paint text on a [Canvas], use a [TextPainter].
        ///
        /// To paint an image on a [Canvas]:
        ///
        /// 1. Obtain an [ImageStream], for example by calling [ImageProvider.resolve]
        ///    on an [AssetImage] or [NetworkImage] object.
        ///
        /// 2. Whenever the [ImageStream]'s underlying [ImageInfo] object changes
        ///    (see [ImageStream.addListener]), create a new instance of your custom
        ///    paint delegate, giving it the new [ImageInfo] object.
        ///
        /// 3. In your delegate's [paint] method, call the [Canvas.drawImage],
        ///    [Canvas.drawImageRect], or [Canvas.drawImageNine] methods to paint the
        ///    [ImageInfo.image] object, applying the [ImageInfo.scale] value to
        ///    obtain the correct rendering size.
        /// </Summary>
        public virtual void Paint(Canvas canvas, Size size)
        {
        }


        /// <Summary>
        /// Called whenever a new instance of the custom painter delegate class is
        /// provided to the [RenderCustomPaint] object, or any time that a new
        /// [CustomPaint] object is created with a new instance of the custom painter
        /// delegate class (which amounts to the same thing, because the latter is
        /// implemented in terms of the former).
        ///
        /// If the new instance would cause [semanticsBuilder] to create different
        /// semantics information, then this method should return true, otherwise it
        /// should return false.
        ///
        /// If the method returns false, then the [semanticsBuilder] call might be
        /// optimized away.
        ///
        /// It's possible that the [semanticsBuilder] will get called even if
        /// [shouldRebuildSemantics] would return false. For example, it is called
        /// when the [CustomPaint] is rendered for the very first time, or when the
        /// box changes its size.
        ///
        /// By default this method delegates to [shouldRepaint] under the assumption
        /// that in most cases semantics change when something new is drawn.
        /// </Summary>
        public virtual bool ShouldRebuildSemantics(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate) => ShouldRepaint(oldDelegate);



        /// <Summary>
        /// Called whenever a new instance of the custom painter delegate class is
        /// provided to the [RenderCustomPaint] object, or any time that a new
        /// [CustomPaint] object is created with a new instance of the custom painter
        /// delegate class (which amounts to the same thing, because the latter is
        /// implemented in terms of the former).
        ///
        /// If the new instance represents different information than the old
        /// instance, then the method should return true, otherwise it should return
        /// false.
        ///
        /// If the method returns false, then the [paint] call might be optimized
        /// away.
        ///
        /// It's possible that the [paint] method will get called even if
        /// [shouldRepaint] returns false (e.g. if an ancestor or descendant needed to
        /// be repainted). It's also possible that the [paint] method will get called
        /// without [shouldRepaint] being called at all (e.g. if the box changes
        /// size).
        ///
        /// If a custom delegate has a particularly expensive paint function such that
        /// repaints should be avoided as much as possible, a [RepaintBoundary] or
        /// [RenderRepaintBoundary] (or other render object with
        /// [RenderObject.isRepaintBoundary] set to true) might be helpful.
        ///
        /// The `oldDelegate` argument will never be null.
        /// </Summary>
        public virtual bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return default(bool);
        }


        /// <Summary>
        /// Called whenever a hit test is being performed on an object that is using
        /// this custom paint delegate.
        ///
        /// The given point is relative to the same coordinate space as the last
        /// [paint] call.
        ///
        /// The default behavior is to consider all points to be hits for
        /// background painters, and no points to be hits for foreground painters.
        ///
        /// Return true if the given position corresponds to a point on the drawn
        /// image that should be considered a "hit", false if it corresponds to a
        /// point that should be considered outside the painted image, and null to use
        /// the default behavior.
        /// </Summary>
        public virtual bool HitTest(FlutterBinding.UI.Offset position) => null;



    }


    /// <Summary>
    /// Contains properties describing information drawn in a rectangle contained by
    /// the [Canvas] used by a [CustomPaint].
    ///
    /// This information is used, for example, by assistive technologies to improve
    /// the accessibility of applications.
    ///
    /// Implement [CustomPainter.semanticsBuilder] to build the semantic
    /// description of the whole picture drawn by a [CustomPaint], rather that one
    /// particular rectangle.
    ///
    /// See also:
    ///
    ///  * [SemanticsNode], which is created using the properties of this class.
    ///  * [CustomPainter], which creates instances of this class.
    /// </Summary>
    public class CustomPainterSemantics
    {
        public CustomPainterSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Semantics.Semantics.SemanticsProperties properties = default(FlutterSDK.Semantics.Semantics.SemanticsProperties), Matrix4 transform = default(Matrix4), HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> tags = default(HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag>))
        : base()
        {
            this.Key = key;
            this.Rect = rect;
            this.Properties = properties;
            this.Transform = transform;
            this.Tags = tags;
        }
        public virtual FlutterSDK.Foundation.Key.Key Key { get; set; }
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual Matrix4 Transform { get; set; }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsProperties Properties { get; set; }
        public virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> Tags { get; set; }
    }


    /// <Summary>
    /// Provides a canvas on which to draw during the paint phase.
    ///
    /// When asked to paint, [RenderCustomPaint] first asks its [painter] to paint
    /// on the current canvas, then it paints its child, and then, after painting
    /// its child, it asks its [foregroundPainter] to paint. The coordinate system of
    /// the canvas matches the coordinate system of the [CustomPaint] object. The
    /// painters are expected to paint within a rectangle starting at the origin and
    /// encompassing a region of the given size. (If the painters paint outside
    /// those bounds, there might be insufficient memory allocated to rasterize the
    /// painting commands and the resulting behavior is undefined.)
    ///
    /// Painters are implemented by subclassing or implementing [CustomPainter].
    ///
    /// Because custom paint calls its painters during paint, you cannot mark the
    /// tree as needing a new layout during the callback (the layout for this frame
    /// has already happened).
    ///
    /// Custom painters normally size themselves to their child. If they do not have
    /// a child, they attempt to size themselves to the [preferredSize], which
    /// defaults to [Size.zero].
    ///
    /// See also:
    ///
    ///  * [CustomPainter], the class that custom painter delegates should extend.
    ///  * [Canvas], the API provided to custom painter delegates.
    /// </Summary>
    public class RenderCustomPaint : FlutterSDK.Rendering.Proxybox.RenderProxyBox
    {
        public RenderCustomPaint(FlutterSDK.Rendering.Custompaint.CustomPainter painter = default(FlutterSDK.Rendering.Custompaint.CustomPainter), FlutterSDK.Rendering.Custompaint.CustomPainter foregroundPainter = default(FlutterSDK.Rendering.Custompaint.CustomPainter), Size preferredSize = default(Size), bool isComplex = false, bool willChange = false, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            this.IsComplex = isComplex;
            this.WillChange = willChange;
        }
        internal virtual FlutterSDK.Rendering.Custompaint.CustomPainter _Painter { get; set; }
        internal virtual FlutterSDK.Rendering.Custompaint.CustomPainter _ForegroundPainter { get; set; }
        internal virtual Size _PreferredSize { get; set; }
        public virtual bool IsComplex { get; set; }
        public virtual bool WillChange { get; set; }
        internal virtual FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback _BackgroundSemanticsBuilder { get; set; }
        internal virtual FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback _ForegroundSemanticsBuilder { get; set; }
        internal virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> _BackgroundSemanticsNodes { get; set; }
        internal virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> _ForegroundSemanticsNodes { get; set; }
        public virtual FlutterSDK.Rendering.Custompaint.CustomPainter Painter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Custompaint.CustomPainter ForegroundPainter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size PreferredSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _DidUpdatePainter(FlutterSDK.Rendering.Custompaint.CustomPainter newPainter, FlutterSDK.Rendering.Custompaint.CustomPainter oldPainter)
        {
            if (newPainter == null)
            {

                MarkNeedsPaint();
            }
            else if (oldPainter == null || newPainter.GetType() != oldPainter.GetType() || newPainter.ShouldRepaint(oldPainter))
            {
                MarkNeedsPaint();
            }

            if (Attached)
            {
                oldPainter?.RemoveListener(MarkNeedsPaint);
                newPainter?.AddListener(MarkNeedsPaint);
            }

            if (newPainter == null)
            {

                if (Attached) MarkNeedsSemanticsUpdate();
            }
            else if (oldPainter == null || newPainter.GetType() != oldPainter.GetType() || newPainter.ShouldRebuildSemantics(oldPainter))
            {
                MarkNeedsSemanticsUpdate();
            }

        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _Painter?.AddListener(MarkNeedsPaint);
            _ForegroundPainter?.AddListener(MarkNeedsPaint);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _Painter?.AddListener(MarkNeedsPaint);
            _ForegroundPainter?.AddListener(MarkNeedsPaint);
        }




        public new void Detach()
        {
            _Painter?.RemoveListener(MarkNeedsPaint);
            _ForegroundPainter?.RemoveListener(MarkNeedsPaint);
            base.Detach();
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            if (_ForegroundPainter != null && (_ForegroundPainter.HitTest(position) ?? false)) return true;
            return base.HitTestChildren(result, position: position);
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position)
        {
            return _Painter != null && (_Painter.HitTest(position) ?? true);
        }




        public new void PerformResize()
        {
            Size = Constraints.Constrain(PreferredSize);
            MarkNeedsSemanticsUpdate();
        }




        private void _PaintWithPainter(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Custompaint.CustomPainter painter)
        {
            int debugPreviousCanvasSaveCount = default(int);
            canvas.Save();

            if (offset != Dart:uiDefaultClass.Offset.Zero)canvas.Translate(offset.Dx, offset.Dy);
            painter.Paint(canvas, Size);

            canvas.Restore();
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (_Painter != null)
            {
                _PaintWithPainter(context.Canvas, offset, _Painter);
                _SetRasterCacheHints(context);
            }

            base.Paint(context, offset);
            if (_ForegroundPainter != null)
            {
                _PaintWithPainter(context.Canvas, offset, _ForegroundPainter);
                _SetRasterCacheHints(context);
            }

        }




        private void _SetRasterCacheHints(FlutterSDK.Rendering.@object.PaintingContext context)
        {
            if (IsComplex) context.SetIsComplexHint();
            if (WillChange) context.SetWillChangeHint();
        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            _BackgroundSemanticsBuilder = Painter?.SemanticsBuilder;
            _ForegroundSemanticsBuilder = ForegroundPainter?.SemanticsBuilder;
            config.IsSemanticBoundary = _BackgroundSemanticsBuilder != null || _ForegroundSemanticsBuilder != null;
        }




        public new void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children)
        {

            List<CustomPainterSemantics> backgroundSemantics = _BackgroundSemanticsBuilder != null ? _BackgroundSemanticsBuilder(Size) : new List<CustomPainterSemantics>() { };
            _BackgroundSemanticsNodes = _UpdateSemanticsChildren(_BackgroundSemanticsNodes, backgroundSemantics);
            List<CustomPainterSemantics> foregroundSemantics = _ForegroundSemanticsBuilder != null ? _ForegroundSemanticsBuilder(Size) : new List<CustomPainterSemantics>() { };
            _ForegroundSemanticsNodes = _UpdateSemanticsChildren(_ForegroundSemanticsNodes, foregroundSemantics);
            bool hasBackgroundSemantics = _BackgroundSemanticsNodes != null && _BackgroundSemanticsNodes.IsNotEmpty;
            bool hasForegroundSemantics = _ForegroundSemanticsNodes != null && _ForegroundSemanticsNodes.IsNotEmpty;
            List<SemanticsNode> finalChildren = new List<SemanticsNode>() { };
            base.AssembleSemanticsNode(node, config, finalChildren);
        }




        public new void ClearSemantics()
        {
            base.ClearSemantics();
            _BackgroundSemanticsNodes = null;
            _ForegroundSemanticsNodes = null;
        }




        /// <Summary>
        /// Updates the nodes of `oldSemantics` using data in `newChildSemantics`, and
        /// returns a new list containing child nodes sorted according to the order
        /// specified by `newChildSemantics`.
        ///
        /// [SemanticsNode]s that match [CustomPainterSemantics] by [Key]s preserve
        /// their [SemanticsNode.key] field. If a node with the same key appears in
        /// a different position in the list, it is moved to the new position, but the
        /// same object is reused.
        ///
        /// [SemanticsNode]s whose `key` is null may be updated from
        /// [CustomPainterSemantics] whose `key` is also null. However, the algorithm
        /// does not guarantee it. If your semantics require that specific nodes are
        /// updated from specific [CustomPainterSemantics], it is recommended to match
        /// them by specifying non-null keys.
        ///
        /// The algorithm tries to be as close to [RenderObjectElement.updateChildren]
        /// as possible, deviating only where the concepts diverge between widgets and
        /// semantics. For example, a [SemanticsNode] can be updated from a
        /// [CustomPainterSemantics] based on `Key` alone; their types are not
        /// considered because there is only one type of [SemanticsNode]. There is no
        /// concept of a "forgotten" node in semantics, deactivated nodes, or global
        /// keys.
        /// </Summary>
        private List<FlutterSDK.Semantics.Semantics.SemanticsNode> _UpdateSemanticsChildren(List<FlutterSDK.Semantics.Semantics.SemanticsNode> oldSemantics, List<FlutterSDK.Rendering.Custompaint.CustomPainterSemantics> newChildSemantics)
        {
            oldSemantics = oldSemantics ?? new List<SemanticsNode>() { };
            newChildSemantics = newChildSemantics ?? new List<CustomPainterSemantics>() { };

            int newChildrenTop = 0;
            int oldChildrenTop = 0;
            int newChildrenBottom = newChildSemantics.Count - 1;
            int oldChildrenBottom = oldSemantics.Count - 1;
            List<SemanticsNode> newChildren = new List<SemanticsNode>(newChildSemantics.Count);
            while ((oldChildrenTop <= oldChildrenBottom) && (newChildrenTop <= newChildrenBottom))
            {
                SemanticsNode oldChild = oldSemantics[oldChildrenTop];
                CustomPainterSemantics newSemantics = newChildSemantics[newChildrenTop];
                if (!_CanUpdateSemanticsChild(oldChild, newSemantics)) break;
                SemanticsNode newChild = _UpdateSemanticsChild(oldChild, newSemantics);
                newChildren[newChildrenTop] = newChild;
                newChildrenTop += 1;
                oldChildrenTop += 1;
            }

            while ((oldChildrenTop <= oldChildrenBottom) && (newChildrenTop <= newChildrenBottom))
            {
                SemanticsNode oldChild = oldSemantics[oldChildrenBottom];
                CustomPainterSemantics newChild = newChildSemantics[newChildrenBottom];
                if (!_CanUpdateSemanticsChild(oldChild, newChild)) break;
                oldChildrenBottom -= 1;
                newChildrenBottom -= 1;
            }

            bool haveOldChildren = oldChildrenTop <= oldChildrenBottom;
            Dictionary<Key, SemanticsNode> oldKeyedChildren = default(Dictionary<Key, SemanticsNode>);
            if (haveOldChildren)
            {
                oldKeyedChildren = new Dictionary<Key, SemanticsNode> { };
                while (oldChildrenTop <= oldChildrenBottom)
                {
                    SemanticsNode oldChild = oldSemantics[oldChildrenTop];
                    if (oldChild.Key != null) oldKeyedChildren[oldChild.Key] = oldChild;
                    oldChildrenTop += 1;
                }

            }

            while (newChildrenTop <= newChildrenBottom)
            {
                SemanticsNode oldChild = default(SemanticsNode);
                CustomPainterSemantics newSemantics = newChildSemantics[newChildrenTop];
                if (haveOldChildren)
                {
                    Key key = newSemantics.Key;
                    if (key != null)
                    {
                        oldChild = oldKeyedChildren[key];
                        if (oldChild != null)
                        {
                            if (_CanUpdateSemanticsChild(oldChild, newSemantics))
                            {
                                oldKeyedChildren.Remove(key);
                            }
                            else
                            {
                                oldChild = null;
                            }

                        }

                    }

                }


                SemanticsNode newChild = _UpdateSemanticsChild(oldChild, newSemantics);

                newChildren[newChildrenTop] = newChild;
                newChildrenTop += 1;
            }




            newChildrenBottom = newChildSemantics.Count - 1;
            oldChildrenBottom = oldSemantics.Count - 1;
            while ((oldChildrenTop <= oldChildrenBottom) && (newChildrenTop <= newChildrenBottom))
            {
                SemanticsNode oldChild = oldSemantics[oldChildrenTop];
                CustomPainterSemantics newSemantics = newChildSemantics[newChildrenTop];

                SemanticsNode newChild = _UpdateSemanticsChild(oldChild, newSemantics);

                newChildren[newChildrenTop] = newChild;
                newChildrenTop += 1;
                oldChildrenTop += 1;
            }


            return newChildren;
        }




        /// <Summary>
        /// Whether `oldChild` can be updated with properties from `newSemantics`.
        ///
        /// If `oldChild` can be updated, it is updated using [_updateSemanticsChild].
        /// Otherwise, the node is replaced by a new instance of [SemanticsNode].
        /// </Summary>
        private bool _CanUpdateSemanticsChild(FlutterSDK.Semantics.Semantics.SemanticsNode oldChild, FlutterSDK.Rendering.Custompaint.CustomPainterSemantics newSemantics)
        {
            return oldChild.Key == newSemantics.Key;
        }




        /// <Summary>
        /// Updates `oldChild` using the properties of `newSemantics`.
        ///
        /// This method requires that `_canUpdateSemanticsChild(oldChild, newSemantics)`
        /// is true prior to calling it.
        /// </Summary>
        private FlutterSDK.Semantics.Semantics.SemanticsNode _UpdateSemanticsChild(FlutterSDK.Semantics.Semantics.SemanticsNode oldChild, FlutterSDK.Rendering.Custompaint.CustomPainterSemantics newSemantics)
        {

            SemanticsNode newChild = oldChild ?? new SemanticsNode(key: newSemantics.Key);
            SemanticsProperties properties = newSemantics.Properties;
            SemanticsConfiguration config = new SemanticsConfiguration();
            if (properties.SortKey != null)
            {
                config.SortKey = properties.SortKey;
            }

            if (properties.Checked != null)
            {
                config.IsChecked = properties.Checked;
            }

            if (properties.Selected != null)
            {
                config.IsSelected = properties.Selected;
            }

            if (properties.Button != null)
            {
                config.IsButton = properties.Button;
            }

            if (properties.Link != null)
            {
                config.IsLink = properties.Link;
            }

            if (properties.TextField != null)
            {
                config.IsTextField = properties.TextField;
            }

            if (properties.ReadOnly != null)
            {
                config.IsReadOnly = properties.ReadOnly;
            }

            if (properties.Focusable != null)
            {
                config.IsFocusable = properties.Focusable;
            }

            if (properties.Focused != null)
            {
                config.IsFocused = properties.Focused;
            }

            if (properties.Enabled != null)
            {
                config.IsEnabled = properties.Enabled;
            }

            if (properties.InMutuallyExclusiveGroup != null)
            {
                config.IsInMutuallyExclusiveGroup = properties.InMutuallyExclusiveGroup;
            }

            if (properties.Obscured != null)
            {
                config.IsObscured = properties.Obscured;
            }

            if (properties.Multiline != null)
            {
                config.IsMultiline = properties.Multiline;
            }

            if (properties.Hidden != null)
            {
                config.IsHidden = properties.Hidden;
            }

            if (properties.Header != null)
            {
                config.IsHeader = properties.Header;
            }

            if (properties.ScopesRoute != null)
            {
                config.ScopesRoute = properties.ScopesRoute;
            }

            if (properties.NamesRoute != null)
            {
                config.NamesRoute = properties.NamesRoute;
            }

            if (properties.LiveRegion != null)
            {
                config.LiveRegion = properties.LiveRegion;
            }

            if (properties.MaxValueLength != null)
            {
                config.MaxValueLength = properties.MaxValueLength;
            }

            if (properties.CurrentValueLength != null)
            {
                config.CurrentValueLength = properties.CurrentValueLength;
            }

            if (properties.Toggled != null)
            {
                config.IsToggled = properties.Toggled;
            }

            if (properties.Image != null)
            {
                config.IsImage = properties.Image;
            }

            if (properties.Label != null)
            {
                config.Label = properties.Label;
            }

            if (properties.Value != null)
            {
                config.Value = properties.Value;
            }

            if (properties.IncreasedValue != null)
            {
                config.IncreasedValue = properties.IncreasedValue;
            }

            if (properties.DecreasedValue != null)
            {
                config.DecreasedValue = properties.DecreasedValue;
            }

            if (properties.Hint != null)
            {
                config.Hint = properties.Hint;
            }

            if (properties.TextDirection != null)
            {
                config.TextDirection = properties.TextDirection;
            }

            if (properties.OnTap != null)
            {
                config.OnTap = properties.OnTap;
            }

            if (properties.OnLongPress != null)
            {
                config.OnLongPress = properties.OnLongPress;
            }

            if (properties.OnScrollLeft != null)
            {
                config.OnScrollLeft = properties.OnScrollLeft;
            }

            if (properties.OnScrollRight != null)
            {
                config.OnScrollRight = properties.OnScrollRight;
            }

            if (properties.OnScrollUp != null)
            {
                config.OnScrollUp = properties.OnScrollUp;
            }

            if (properties.OnScrollDown != null)
            {
                config.OnScrollDown = properties.OnScrollDown;
            }

            if (properties.OnIncrease != null)
            {
                config.OnIncrease = properties.OnIncrease;
            }

            if (properties.OnDecrease != null)
            {
                config.OnDecrease = properties.OnDecrease;
            }

            if (properties.OnCopy != null)
            {
                config.OnCopy = properties.OnCopy;
            }

            if (properties.OnCut != null)
            {
                config.OnCut = properties.OnCut;
            }

            if (properties.OnPaste != null)
            {
                config.OnPaste = properties.OnPaste;
            }

            if (properties.OnMoveCursorForwardByCharacter != null)
            {
                config.OnMoveCursorForwardByCharacter = properties.OnMoveCursorForwardByCharacter;
            }

            if (properties.OnMoveCursorBackwardByCharacter != null)
            {
                config.OnMoveCursorBackwardByCharacter = properties.OnMoveCursorBackwardByCharacter;
            }

            if (properties.OnMoveCursorForwardByWord != null)
            {
                config.OnMoveCursorForwardByWord = properties.OnMoveCursorForwardByWord;
            }

            if (properties.OnMoveCursorBackwardByWord != null)
            {
                config.OnMoveCursorBackwardByWord = properties.OnMoveCursorBackwardByWord;
            }

            if (properties.OnSetSelection != null)
            {
                config.OnSetSelection = properties.OnSetSelection;
            }

            if (properties.OnDidGainAccessibilityFocus != null)
            {
                config.OnDidGainAccessibilityFocus = properties.OnDidGainAccessibilityFocus;
            }

            if (properties.OnDidLoseAccessibilityFocus != null)
            {
                config.OnDidLoseAccessibilityFocus = properties.OnDidLoseAccessibilityFocus;
            }

            if (properties.OnDismiss != null)
            {
                config.OnDismiss = properties.OnDismiss;
            }

            newChild.UpdateWith(config: config, childrenInInversePaintOrder: new List<SemanticsNode>() { });
            ..Rect = newSemantics.Rect..Transform = newSemantics.Transform..Tags = newSemantics.Tags;
            return newChild;
        }



    }

}
