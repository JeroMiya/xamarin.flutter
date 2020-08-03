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
namespace FlutterSDK.Widgets.Image
{
    /// <Summary>
    /// Signature used by [Image.frameBuilder] to control the widget that will be
    /// used when an [Image] is built.
    ///
    /// The `child` argument contains the default image widget and is guaranteed to
    /// be non-null. Typically, this builder will wrap the `child` widget in some
    /// way and return the wrapped widget. If this builder returns `child` directly,
    /// it will yield the same result as if [Image.frameBuilder] was null.
    ///
    /// The `frame` argument specifies the index of the current image frame being
    /// rendered. It will be null before the first image frame is ready, and zero
    /// for the first image frame. For single-frame images, it will never be greater
    /// than zero. For multi-frame images (such as animated GIFs), it will increase
    /// by one every time a new image frame is shown (including when the image
    /// animates in a loop).
    ///
    /// The `wasSynchronouslyLoaded` argument specifies whether the image was
    /// available synchronously (on the same
    /// [rendering pipeline frame](rendering/RendererBinding/drawFrame.html) as the
    /// `Image` widget itself was created) and thus able to be painted immediately.
    /// If this is false, then there was one or more rendering pipeline frames where
    /// the image wasn't yet available to be painted. For multi-frame images (such
    /// as animated GIFs), the value of this argument will be the same for all image
    /// frames. In other words, if the first image frame was available immediately,
    /// then this argument will be true for all image frames.
    ///
    /// This builder must not return null.
    ///
    /// See also:
    ///
    ///  * [Image.frameBuilder], which makes use of this signature in the [Image]
    ///    widget.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget ImageFrameBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, int frame, bool wasSynchronouslyLoaded);
    /// <Summary>
    /// Signature used by [Image.loadingBuilder] to build a representation of the
    /// image's loading progress.
    ///
    /// This is useful for images that are incrementally loaded (e.g. over a local
    /// file system or a network), and the application wishes to give the user an
    /// indication of when the image will be displayed.
    ///
    /// The `child` argument contains the default image widget and is guaranteed to
    /// be non-null. Typically, this builder will wrap the `child` widget in some
    /// way and return the wrapped widget. If this builder returns `child` directly,
    /// it will yield the same result as if [Image.loadingBuilder] was null.
    ///
    /// The `loadingProgress` argument contains the current progress towards loading
    /// the image. This argument will be non-null while the image is loading, but it
    /// will be null in the following cases:
    ///
    ///   * When the widget is first rendered before any bytes have been loaded.
    ///   * When an image has been fully loaded and is available to be painted.
    ///
    /// If callers are implementing custom [ImageProvider] and [ImageStream]
    /// instances (which is very rare), it's possible to produce image streams that
    /// continue to fire image chunk events after an image frame has been loaded.
    /// In such cases, the `child` parameter will represent the current
    /// fully-loaded image frame.
    ///
    /// This builder must not return null.
    ///
    /// See also:
    ///
    ///  * [Image.loadingBuilder], which makes use of this signature in the [Image]
    ///    widget.
    ///  * [ImageChunkListener], a lower-level signature for listening to raw
    ///    [ImageChunkEvent]s.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget ImageLoadingBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Imagestream.ImageChunkEvent loadingProgress);
    /// <Summary>
    /// Signature used by [Image.errorBuilder] to create a replacement widget to
    /// render instead of the image.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget ImageErrorWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, @Object error, StackTrace stackTrace);
    internal static class ImageDefaultClass
    {
        /// <Summary>
        /// Creates an [ImageConfiguration] based on the given [BuildContext] (and
        /// optionally size).
        ///
        /// This is the object that must be passed to [BoxPainter.paint] and to
        /// [ImageProvider.resolve].
        ///
        /// If this is not called from a build method, then it should be reinvoked
        /// whenever the dependencies change, e.g. by calling it from
        /// [State.didChangeDependencies], so that any changes in the environment are
        /// picked up (e.g. if the device pixel ratio changes).
        ///
        /// See also:
        ///
        ///  * [ImageProvider], which has an example showing how this might be used.
        /// </Summary>
        internal static FlutterSDK.Painting.Imageprovider.ImageConfiguration CreateLocalImageConfiguration(FlutterSDK.Widgets.Framework.BuildContext context, Size size = default(Size))
        {
            return new ImageConfiguration(bundle: BasicDefaultClass.DefaultAssetBundle.Of(context), devicePixelRatio: MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true)?.DevicePixelRatio ?? 1.0, locale: LocalizationsDefaultClass.Localizations.LocaleOf(context, nullOk: true), textDirection: BasicDefaultClass.Directionality.Of(context), size: size, platform: PlatformDefaultClass.DefaultTargetPlatform);
        }



        /// <Summary>
        /// Prefetches an image into the image cache.
        ///
        /// Returns a [Future] that will complete when the first image yielded by the
        /// [ImageProvider] is available or failed to load.
        ///
        /// If the image is later used by an [Image] or [BoxDecoration] or [FadeInImage],
        /// it will probably be loaded faster. The consumer of the image does not need
        /// to use the same [ImageProvider] instance. The [ImageCache] will find the image
        /// as long as both images share the same key, and the image is held by the
        /// cache.
        ///
        /// The cache may refuse to hold the image if it is disabled, the image is too
        /// large, or some other criteria implemented by a custom [ImageCache]
        /// implementation.
        ///
        /// The [ImageCache] holds a reference to all images passed to [putIfAbsent] as
        /// long as their [ImageStreamCompleter] has at least one listener. This method
        /// will wait until the end of the frame after its future completes before
        /// releasing its own listener. This gives callers a chance to listen to the
        /// stream if necessary. A caller can determine if the image ended up in the
        /// cache by calling [ImageProvider.obtainCacheStatus]. If it is only held as
        /// [ImageCacheStatus.live], and the caller wishes to keep the resolved
        /// image in memory, the caller should immediately call `provider.resolve` and
        /// add a listener to the returned [ImageStream]. The image will remain pinned
        /// in memory at least until the caller removes its listener from the stream,
        /// even if it would not otherwise fit into the cache.
        ///
        /// Callers should be cautious about pinning large images or a large number of
        /// images in memory, as this can result in running out of memory and being
        /// killed by the operating system. The lower the avilable physical memory, the
        /// more susceptible callers will be to running into OOM issues. These issues
        /// manifest as immediate process death, sometimes with no other error messages.
        ///
        /// The [BuildContext] and [Size] are used to select an image configuration
        /// (see [createLocalImageConfiguration]).
        ///
        /// The `onError` argument can be used to manually handle errors while
        /// pre-caching.
        ///
        /// See also:
        ///
        ///  * [ImageCache], which holds images that may be reused.
        /// </Summary>
        internal static Future<object> PrecacheImage(FlutterSDK.Painting.Imageprovider.ImageProvider<object> provider, FlutterSDK.Widgets.Framework.BuildContext context, Size size = default(Size), FlutterSDK.Painting.Imagestream.ImageErrorListener onError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener))
        {
            ImageConfiguration config = ImageDefaultClass.CreateLocalImageConfiguration(context, size: size);
            Completer<void> completer = new Completer<void>();
            ImageStream stream = provider.Resolve(config);
            ImageStreamListener listener = default(ImageStreamListener);
            listener = new ImageStreamListener((ImageInfo image, bool sync) =>
            {
                if (!completer.IsCompleted)
                {
                    completer.Complete();
                }

                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timeStamp) =>
                {
                    stream.RemoveListener(listener);
                }
                );
            }
            , onError: (object exception, StackTrace stackTrace) =>
            {
                if (!completer.IsCompleted)
                {
                    completer.Complete();
                }

                stream.RemoveListener(listener);
                if (onError != null)
                {
                    onError(exception, stackTrace);
                }
                else
                {
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(context: new ErrorDescription("image failed to precache"), library: "image resource service", exception: exception, stack: stackTrace, silent: true));
                }

            }
            );
            stream.AddListener(listener);
            return completer.Future;
        }



    }

    /// <Summary>
    /// A widget that displays an image.
    ///
    /// Several constructors are provided for the various ways that an image can be
    /// specified:
    ///
    ///  * [new Image], for obtaining an image from an [ImageProvider].
    ///  * [new Image.asset], for obtaining an image from an [AssetBundle]
    ///    using a key.
    ///  * [new Image.network], for obtaining an image from a URL.
    ///  * [new Image.file], for obtaining an image from a [File].
    ///  * [new Image.memory], for obtaining an image from a [Uint8List].
    ///
    /// The following image formats are supported: {@macro flutter.dart:ui.imageFormats}
    ///
    /// To automatically perform pixel-density-aware asset resolution, specify the
    /// image using an [AssetImage] and make sure that a [MaterialApp], [WidgetsApp],
    /// or [MediaQuery] widget exists above the [Image] widget in the widget tree.
    ///
    /// The image is painted using [paintImage], which describes the meanings of the
    /// various fields on this class in more detail.
    ///
    /// {@tool snippet}
    /// The default constructor can be used with any [ImageProvider], such as a
    /// [NetworkImage], to display an image from the internet.
    ///
    /// ![An image of an owl displayed by the image widget](https://flutter.github.io/assets-for-api-docs/assets/widgets/owl.jpg)
    ///
    /// ```dart
    /// const Image(
    ///   image: NetworkImage('https://flutter.github.io/assets-for-api-docs/assets/widgets/owl.jpg'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// The [Image] Widget also provides several constructors to display different
    /// types of images for convenience. In this example, use the [Image.network]
    /// constructor to display an image from the internet.
    ///
    /// ![An image of an owl displayed by the image widget using the shortcut constructor](https://flutter.github.io/assets-for-api-docs/assets/widgets/owl-2.jpg)
    ///
    /// ```dart
    /// Image.network('https://flutter.github.io/assets-for-api-docs/assets/widgets/owl-2.jpg')
    /// ```
    /// {@end-tool}
    ///
    /// The [Image.asset], [Image.network], [Image.file], and [Image.memory]
    /// constructors allow a custom decode size to be specified through
    /// [cacheWidth] and [cacheHeight] parameters. The engine will decode the
    /// image to the specified size, which is primarily intended to reduce the
    /// memory usage of [ImageCache].
    ///
    /// In the case where a network image is used on the Web platform, the
    /// [cacheWidth] and [cacheHeight] parameters are ignored as the Web engine
    /// delegates image decoding of network images to the Web, which does not support
    /// custom decode sizes.
    ///
    /// See also:
    ///
    ///  * [Icon], which shows an image from a font.
    ///  * [new Ink.image], which is the preferred way to show an image in a
    ///    material application (especially if the image is in a [Material] and will
    ///    have an [InkWell] on top of it).
    ///  * [Image](dart-ui/Image-class.html), the class in the [dart:ui] library.
    ///
    /// </Summary>
    public class Image : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that displays an image.
        ///
        /// To show an image from the network or from an asset bundle, consider using
        /// [new Image.network] and [new Image.asset] respectively.
        ///
        /// The [image], [alignment], [repeat], and [matchTextDirection] arguments
        /// must not be null.
        ///
        /// Either the [width] and [height] arguments should be specified, or the
        /// widget should be placed in a context that sets tight layout constraints.
        /// Otherwise, the image dimensions will change as the image is loaded, which
        /// will result in ugly layout changes.
        ///
        /// Use [filterQuality] to change the quality when scaling an image.
        /// Use the [FilterQuality.low] quality setting to scale the image,
        /// which corresponds to bilinear interpolation, rather than the default
        /// [FilterQuality.none] which corresponds to nearest-neighbor.
        ///
        /// If [excludeFromSemantics] is true, then [semanticLabel] will be ignored.
        /// </Summary>
        public Image(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageLoadingBuilder loadingBuilder = default(FlutterSDK.Widgets.Image.ImageLoadingBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality))
        : base(key: key)
        {
            this.ImageValue = image;
            this.FrameBuilder = frameBuilder;
            this.LoadingBuilder = loadingBuilder;
            this.ErrorBuilder = errorBuilder;
            this.SemanticLabel = semanticLabel;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.ColorBlendMode = colorBlendMode;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.CenterSlice = centerSlice;
            this.MatchTextDirection = matchTextDirection;
            this.GaplessPlayback = gaplessPlayback;
            this.FilterQuality = filterQuality;
        }
        /// <Summary>
        /// Creates a widget that displays an [ImageStream] obtained from the network.
        ///
        /// The [src], [scale], and [repeat] arguments must not be null.
        ///
        /// Either the [width] and [height] arguments should be specified, or the
        /// widget should be placed in a context that sets tight layout constraints.
        /// Otherwise, the image dimensions will change as the image is loaded, which
        /// will result in ugly layout changes.
        ///
        /// All network images are cached regardless of HTTP headers.
        ///
        /// An optional [headers] argument can be used to send custom HTTP headers
        /// with the image request.
        ///
        /// Use [filterQuality] to change the quality when scaling an image.
        /// Use the [FilterQuality.low] quality setting to scale the image,
        /// which corresponds to bilinear interpolation, rather than the default
        /// [FilterQuality.none] which corresponds to nearest-neighbor.
        ///
        /// If [excludeFromSemantics] is true, then [semanticLabel] will be ignored.
        ///
        /// If [cacheWidth] or [cacheHeight] are provided, it indicates to the
        /// engine that the image should be decoded at the specified size. The image
        /// will be rendered to the constraints of the layout or [width] and [height]
        /// regardless of these parameters. These parameters are primarily intended
        /// to reduce the memory usage of [ImageCache].
        ///
        /// In the case where the network image is on the Web platform, the [cacheWidth]
        /// and [cacheHeight] parameters are ignored as the web engine delegates
        /// image decoding to the web which does not support custom decode sizes.
        /// </Summary>
        public static Image Network(string src, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = 1.0, FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageLoadingBuilder loadingBuilder = default(FlutterSDK.Widgets.Image.ImageLoadingBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality), Dictionary<string, string> headers = default(Dictionary<string, string>), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.LoadingBuilder = loadingBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality;
        }
        /// <Summary>
        /// Creates a widget that displays an [ImageStream] obtained from a [File].
        ///
        /// The [file], [scale], and [repeat] arguments must not be null.
        ///
        /// Either the [width] and [height] arguments should be specified, or the
        /// widget should be placed in a context that sets tight layout constraints.
        /// Otherwise, the image dimensions will change as the image is loaded, which
        /// will result in ugly layout changes.
        ///
        /// On Android, this may require the
        /// `android.permission.READ_EXTERNAL_STORAGE` permission.
        ///
        /// Use [filterQuality] to change the quality when scaling an image.
        /// Use the [FilterQuality.low] quality setting to scale the image,
        /// which corresponds to bilinear interpolation, rather than the default
        /// [FilterQuality.none] which corresponds to nearest-neighbor.
        ///
        /// If [excludeFromSemantics] is true, then [semanticLabel] will be ignored.
        ///
        /// If [cacheWidth] or [cacheHeight] are provided, it indicates to the
        /// engine that the image must be decoded at the specified size. The image
        /// will be rendered to the constraints of the layout or [width] and [height]
        /// regardless of these parameters. These parameters are primarily intended
        /// to reduce the memory usage of [ImageCache].
        /// </Summary>
        public static Image File(File file, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = 1.0, FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality;
        }
        /// <Summary>
        /// Creates a widget that displays an [ImageStream] obtained from an asset
        /// bundle. The key for the image is given by the `name` argument.
        ///
        /// The `package` argument must be non-null when displaying an image from a
        /// package and null otherwise. See the `Assets in packages` section for
        /// details.
        ///
        /// If the `bundle` argument is omitted or null, then the
        /// [DefaultAssetBundle] will be used.
        ///
        /// By default, the pixel-density-aware asset resolution will be attempted. In
        /// addition:
        ///
        /// * If the `scale` argument is provided and is not null, then the exact
        /// asset specified will be used. To display an image variant with a specific
        /// density, the exact path must be provided (e.g. `images/2x/cat.png`).
        ///
        /// If [excludeFromSemantics] is true, then [semanticLabel] will be ignored.
        ///
        /// If [cacheWidth] or [cacheHeight] are provided, it indicates to the
        /// engine that the image must be decoded at the specified size. The image
        /// will be rendered to the constraints of the layout or [width] and [height]
        /// regardless of these parameters. These parameters are primarily intended
        /// to reduce the memory usage of [ImageCache].
        ///
        /// The [name] and [repeat] arguments must not be null.
        ///
        /// Either the [width] and [height] arguments should be specified, or the
        /// widget should be placed in a context that sets tight layout constraints.
        /// Otherwise, the image dimensions will change as the image is loaded, which
        /// will result in ugly layout changes.
        ///
        /// Use [filterQuality] to change the quality when scaling an image.
        /// Use the [FilterQuality.low] quality setting to scale the image,
        /// which corresponds to bilinear interpolation, rather than the default
        /// [FilterQuality.none] which corresponds to nearest-neighbor.
        ///
        /// {@tool snippet}
        ///
        /// Suppose that the project's `pubspec.yaml` file contains the following:
        ///
        /// ```yaml
        /// flutter:
        ///   assets:
        ///     - images/cat.png
        ///     - images/2x/cat.png
        ///     - images/3.5x/cat.png
        /// ```
        /// {@end-tool}
        ///
        /// On a screen with a device pixel ratio of 2.0, the following widget would
        /// render the `images/2x/cat.png` file:
        ///
        /// ```dart
        /// Image.asset('images/cat.png')
        /// ```
        ///
        /// This corresponds to the file that is in the project's `images/2x/`
        /// directory with the name `cat.png` (the paths are relative to the
        /// `pubspec.yaml` file).
        ///
        /// On a device with a 4.0 device pixel ratio, the `images/3.5x/cat.png` asset
        /// would be used. On a device with a 1.0 device pixel ratio, the
        /// `images/cat.png` resource would be used.
        ///
        /// The `images/cat.png` image can be omitted from disk (though it must still
        /// be present in the manifest). If it is omitted, then on a device with a 1.0
        /// device pixel ratio, the `images/2x/cat.png` image would be used instead.
        ///
        ///
        /// ## Assets in packages
        ///
        /// To create the widget with an asset from a package, the [package] argument
        /// must be provided. For instance, suppose a package called `my_icons` has
        /// `icons/heart.png` .
        ///
        /// {@tool snippet}
        /// Then to display the image, use:
        ///
        /// ```dart
        /// Image.asset('icons/heart.png', package: 'my_icons')
        /// ```
        /// {@end-tool}
        ///
        /// Assets used by the package itself should also be displayed using the
        /// [package] argument as above.
        ///
        /// If the desired asset is specified in the `pubspec.yaml` of the package, it
        /// is bundled automatically with the app. In particular, assets used by the
        /// package itself must be specified in its `pubspec.yaml`.
        ///
        /// A package can also choose to have assets in its 'lib/' folder that are not
        /// specified in its `pubspec.yaml`. In this case for those images to be
        /// bundled, the app has to specify which ones to include. For instance a
        /// package named `fancy_backgrounds` could have:
        ///
        /// ```
        /// lib/backgrounds/background1.png
        /// lib/backgrounds/background2.png
        /// lib/backgrounds/background3.png
        /// ```
        ///
        /// To include, say the first image, the `pubspec.yaml` of the app should
        /// specify it in the assets section:
        ///
        /// ```yaml
        ///   assets:
        ///     - packages/fancy_backgrounds/backgrounds/background1.png
        /// ```
        ///
        /// The `lib/` is implied, so it should not be included in the asset path.
        ///
        ///
        /// See also:
        ///
        ///  * [AssetImage], which is used to implement the behavior when the scale is
        ///    omitted.
        ///  * [ExactAssetImage], which is used to implement the behavior when the
        ///    scale is present.
        ///  * <https://flutter.dev/assets-and-images/>, an introduction to assets in
        ///    Flutter.
        /// </Summary>
        public static Image Asset(string name, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double scale = default(double), double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, string package = default(string), FilterQuality filterQuality = default(FilterQuality), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality;
        }
        /// <Summary>
        /// Creates a widget that displays an [ImageStream] obtained from a [Uint8List].
        ///
        /// The [bytes], [scale], and [repeat] arguments must not be null.
        ///
        /// This only accepts compressed image formats (e.g. PNG). Uncompressed
        /// formats like rawRgba (the default format of [ui.Image.toByteData]) will
        /// lead to exceptions.
        ///
        /// Either the [width] and [height] arguments should be specified, or the
        /// widget should be placed in a context that sets tight layout constraints.
        /// Otherwise, the image dimensions will change as the image is loaded, which
        /// will result in ugly layout changes.
        ///
        /// Use [filterQuality] to change the quality when scaling an image.
        /// Use the [FilterQuality.low] quality setting to scale the image,
        /// which corresponds to bilinear interpolation, rather than the default
        /// [FilterQuality.none] which corresponds to nearest-neighbor.
        ///
        /// If [excludeFromSemantics] is true, then [semanticLabel] will be ignored.
        ///
        /// If [cacheWidth] or [cacheHeight] are provided, it indicates to the
        /// engine that the image must be decoded at the specified size. The image
        /// will be rendered to the constraints of the layout or [width] and [height]
        /// regardless of these parameters. These parameters are primarily intended
        /// to reduce the memory usage of [ImageCache].
        /// </Summary>
        public static Image Memory(Uint8List bytes, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = 1.0, FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality;
        }
        /// <Summary>
        /// The image to display.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ImageValue { get; set; }
        /// <Summary>
        /// A builder function responsible for creating the widget that represents
        /// this image.
        ///
        /// If this is null, this widget will display an image that is painted as
        /// soon as the first image frame is available (and will appear to "pop" in
        /// if it becomes available asynchronously). Callers might use this builder to
        /// add effects to the image (such as fading the image in when it becomes
        /// available) or to display a placeholder widget while the image is loading.
        ///
        /// To have finer-grained control over the way that an image's loading
        /// progress is communicated to the user, see [loadingBuilder].
        ///
        /// ## Chaining with [loadingBuilder]
        ///
        /// If a [loadingBuilder] has _also_ been specified for an image, the two
        /// builders will be chained together: the _result_ of this builder will
        /// be passed as the `child` argument to the [loadingBuilder]. For example,
        /// consider the following builders used in conjunction:
        ///
        /// {@template flutter.widgets.image.chainedBuildersExample}
        /// ```dart
        /// Image(
        ///   ...
        ///   frameBuilder: (BuildContext context, Widget child, int frame, bool wasSynchronouslyLoaded) {
        ///     return Padding(
        ///       padding: EdgeInsets.all(8.0),
        ///       child: child,
        ///     );
        ///   },
        ///   loadingBuilder: (BuildContext context, Widget child, ImageChunkEvent loadingProgress) {
        ///     return Center(child: child);
        ///   },
        /// )
        /// ```
        ///
        /// In this example, the widget hierarchy will contain the following:
        ///
        /// ```dart
        /// Center(
        ///   Padding(
        ///     padding: EdgeInsets.all(8.0),
        ///     child: <image>,
        ///   ),
        /// )
        /// ```
        /// {@endtemplate}
        ///
        /// {@tool dartpad --template=stateless_widget_material}
        ///
        /// The following sample demonstrates how to use this builder to implement an
        /// image that fades in once it's been loaded.
        ///
        /// This sample contains a limited subset of the functionality that the
        /// [FadeInImage] widget provides out of the box.
        ///
        /// ```dart
        /// @override
        /// Widget build(BuildContext context) {
        ///   return DecoratedBox(
        ///     decoration: BoxDecoration(
        ///       color: Colors.white,
        ///       border: Border.all(),
        ///       borderRadius: BorderRadius.circular(20),
        ///     ),
        ///     child: Image.network(
        ///       'https://flutter.github.io/assets-for-api-docs/assets/widgets/puffin.jpg',
        ///       frameBuilder: (BuildContext context, Widget child, int frame, bool wasSynchronouslyLoaded) {
        ///         if (wasSynchronouslyLoaded) {
        ///           return child;
        ///         }
        ///         return AnimatedOpacity(
        ///           child: child,
        ///           opacity: frame == null ? 0 : 1,
        ///           duration: const Duration(seconds: 1),
        ///           curve: Curves.easeOut,
        ///         );
        ///       },
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Image.ImageFrameBuilder FrameBuilder { get; set; }
        /// <Summary>
        /// A builder that specifies the widget to display to the user while an image
        /// is still loading.
        ///
        /// If this is null, and the image is loaded incrementally (e.g. over a
        /// network), the user will receive no indication of the progress as the
        /// bytes of the image are loaded.
        ///
        /// For more information on how to interpret the arguments that are passed to
        /// this builder, see the documentation on [ImageLoadingBuilder].
        ///
        /// ## Performance implications
        ///
        /// If a [loadingBuilder] is specified for an image, the [Image] widget is
        /// likely to be rebuilt on every
        /// [rendering pipeline frame](rendering/RendererBinding/drawFrame.html) until
        /// the image has loaded. This is useful for cases such as displaying a loading
        /// progress indicator, but for simpler cases such as displaying a placeholder
        /// widget that doesn't depend on the loading progress (e.g. static "loading"
        /// text), [frameBuilder] will likely work and not incur as much cost.
        ///
        /// ## Chaining with [frameBuilder]
        ///
        /// If a [frameBuilder] has _also_ been specified for an image, the two
        /// builders will be chained together: the `child` argument to this
        /// builder will contain the _result_ of the [frameBuilder]. For example,
        /// consider the following builders used in conjunction:
        ///
        /// {@macro flutter.widgets.image.chainedBuildersExample}
        ///
        /// {@tool dartpad --template=stateless_widget_material}
        ///
        /// The following sample uses [loadingBuilder] to show a
        /// [CircularProgressIndicator] while an image loads over the network.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return DecoratedBox(
        ///     decoration: BoxDecoration(
        ///       color: Colors.white,
        ///       border: Border.all(),
        ///       borderRadius: BorderRadius.circular(20),
        ///     ),
        ///     child: Image.network(
        ///       'https://example.com/image.jpg',
        ///       loadingBuilder: (BuildContext context, Widget child, ImageChunkEvent loadingProgress) {
        ///         if (loadingProgress == null)
        ///           return child;
        ///         return Center(
        ///           child: CircularProgressIndicator(
        ///             value: loadingProgress.expectedTotalBytes != null
        ///                 ? loadingProgress.cumulativeBytesLoaded / loadingProgress.expectedTotalBytes
        ///                 : null,
        ///           ),
        ///         );
        ///       },
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// Run against a real-world image on a slow network, the previous example
        /// renders the following loading progress indicator while the image loads
        /// before rendering the completed image.
        ///
        /// {@animation 400 400 https://flutter.github.io/assets-for-api-docs/assets/widgets/loading_progress_image.mp4}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Image.ImageLoadingBuilder LoadingBuilder { get; set; }
        /// <Summary>
        /// A builder function that is called if an error occurs during image loading.
        ///
        /// If this builder is not provided, any exceptions will be reported to
        /// [FlutterError.onError]. If it is provided, the caller should either handle
        /// the exception by providing a replacement widget, or rethrow the exception.
        ///
        /// {@tool dartpad --template=stateless_widget_material}
        ///
        /// The following sample uses [errorBuilder] to show a '😢' in place of the
        /// image that fails to load, and prints the error to the console.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return DecoratedBox(
        ///     decoration: BoxDecoration(
        ///       color: Colors.white,
        ///       border: Border.all(),
        ///       borderRadius: BorderRadius.circular(20),
        ///     ),
        ///     child: Image.network(
        ///       'https://example.does.not.exist/image.jpg',
        ///       errorBuilder: (BuildContext context, Object exception, StackTrace stackTrace) {
        ///         // Appropriate logging or analytics, e.g.
        ///         // myAnalytics.recordError(
        ///         //   'An error occurred loading "https://example.does.not.exist/image.jpg"',
        ///         //   exception,
        ///         //   stackTrace,
        ///         // );
        ///         return Text('😢');
        ///       },
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder ErrorBuilder { get; set; }
        /// <Summary>
        /// If non-null, require the image to have this width.
        ///
        /// If null, the image will pick a size that best preserves its intrinsic
        /// aspect ratio.
        ///
        /// It is strongly recommended that either both the [width] and the [height]
        /// be specified, or that the widget be placed in a context that sets tight
        /// layout constraints, so that the image does not change size as it loads.
        /// Consider using [fit] to adapt the image's rendering to fit the given width
        /// and height if the exact image dimensions are not known in advance.
        /// </Summary>
        public virtual double Width { get; set; }
        /// <Summary>
        /// If non-null, require the image to have this height.
        ///
        /// If null, the image will pick a size that best preserves its intrinsic
        /// aspect ratio.
        ///
        /// It is strongly recommended that either both the [width] and the [height]
        /// be specified, or that the widget be placed in a context that sets tight
        /// layout constraints, so that the image does not change size as it loads.
        /// Consider using [fit] to adapt the image's rendering to fit the given width
        /// and height if the exact image dimensions are not known in advance.
        /// </Summary>
        public virtual double Height { get; set; }
        /// <Summary>
        /// If non-null, this color is blended with each image pixel using [colorBlendMode].
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// Used to set the [FilterQuality] of the image.
        ///
        /// Use the [FilterQuality.low] quality setting to scale the image with
        /// bilinear interpolation, or the [FilterQuality.none] which corresponds
        /// to nearest-neighbor.
        /// </Summary>
        public virtual FilterQuality FilterQuality { get; set; }
        /// <Summary>
        /// Used to combine [color] with this image.
        ///
        /// The default is [BlendMode.srcIn]. In terms of the blend mode, [color] is
        /// the source and this image is the destination.
        ///
        /// See also:
        ///
        ///  * [BlendMode], which includes an illustration of the effect of each blend mode.
        /// </Summary>
        public virtual FlutterBinding.UI.BlendMode ColorBlendMode { get; set; }
        /// <Summary>
        /// How to inscribe the image into the space allocated during layout.
        ///
        /// The default varies based on the other fields. See the discussion at
        /// [paintImage].
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        /// <Summary>
        /// How to align the image within its bounds.
        ///
        /// The alignment aligns the given position in the image to the given position
        /// in the layout bounds. For example, an [Alignment] alignment of (-1.0,
        /// -1.0) aligns the image to the top-left corner of its layout bounds, while an
        /// [Alignment] alignment of (1.0, 1.0) aligns the bottom right of the
        /// image with the bottom right corner of its layout bounds. Similarly, an
        /// alignment of (0.0, 1.0) aligns the bottom middle of the image with the
        /// middle of the bottom edge of its layout bounds.
        ///
        /// To display a subpart of an image, consider using a [CustomPainter] and
        /// [Canvas.drawImageRect].
        ///
        /// If the [alignment] is [TextDirection]-dependent (i.e. if it is a
        /// [AlignmentDirectional]), then an ambient [Directionality] widget
        /// must be in scope.
        ///
        /// Defaults to [Alignment.center].
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
        /// How to paint any portions of the layout bounds not covered by the image.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decorationimage.ImageRepeat Repeat { get; set; }
        /// <Summary>
        /// The center slice for a nine-patch image.
        ///
        /// The region of the image inside the center slice will be stretched both
        /// horizontally and vertically to fit the image into its destination. The
        /// region of the image above and below the center slice will be stretched
        /// only horizontally and the region of the image to the left and right of
        /// the center slice will be stretched only vertically.
        /// </Summary>
        public virtual FlutterBinding.UI.Rect CenterSlice { get; set; }
        /// <Summary>
        /// Whether to paint the image in the direction of the [TextDirection].
        ///
        /// If this is true, then in [TextDirection.ltr] contexts, the image will be
        /// drawn with its origin in the top left (the "normal" painting direction for
        /// images); and in [TextDirection.rtl] contexts, the image will be drawn with
        /// a scaling factor of -1 in the horizontal direction so that the origin is
        /// in the top right.
        ///
        /// This is occasionally used with images in right-to-left environments, for
        /// images that were designed for left-to-right locales. Be careful, when
        /// using this, to not flip images with integral shadows, text, or other
        /// effects that will look incorrect when flipped.
        ///
        /// If this is true, there must be an ambient [Directionality] widget in
        /// scope.
        /// </Summary>
        public virtual bool MatchTextDirection { get; set; }
        /// <Summary>
        /// Whether to continue showing the old image (true), or briefly show nothing
        /// (false), when the image provider changes.
        /// </Summary>
        public virtual bool GaplessPlayback { get; set; }
        /// <Summary>
        /// A Semantic description of the image.
        ///
        /// Used to provide a description of the image to TalkBack on Android, and
        /// VoiceOver on iOS.
        /// </Summary>
        public virtual string SemanticLabel { get; set; }
        /// <Summary>
        /// Whether to exclude this image from semantics.
        ///
        /// Useful for images which do not contribute meaningful information to an
        /// application.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }

        public new FlutterSDK.Widgets.Image._ImageState CreateState() => new _ImageState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<ImageProvider>("image", Image));
            properties.Add(new DiagnosticsProperty<Function>("frameBuilder", FrameBuilder));
            properties.Add(new DiagnosticsProperty<Function>("loadingBuilder", LoadingBuilder));
            properties.Add(new DoubleProperty("width", Width, defaultValue: null));
            properties.Add(new DoubleProperty("height", Height, defaultValue: null));
            properties.Add(new ColorProperty("color", Color, defaultValue: null));
            properties.Add(new EnumProperty<BlendMode>("colorBlendMode", ColorBlendMode, defaultValue: null));
            properties.Add(new EnumProperty<BoxFit>("fit", Fit, defaultValue: null));
            properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment, defaultValue: null));
            properties.Add(new EnumProperty<ImageRepeat>("repeat", Repeat, defaultValue: ImageRepeat.NoRepeat));
            properties.Add(new DiagnosticsProperty<Rect>("centerSlice", CenterSlice, defaultValue: null));
            properties.Add(new FlagProperty("matchTextDirection", value: MatchTextDirection, ifTrue: "match text direction"));
            properties.Add(new StringProperty("semanticLabel", SemanticLabel, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("this.excludeFromSemantics", ExcludeFromSemantics));
            properties.Add(new EnumProperty<FilterQuality>("filterQuality", FilterQuality));
        }



    }


    public class _ImageState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Image.Image>, IWidgetsBindingObserver
    {
        public _ImageState()
        { }
        internal virtual FlutterSDK.Painting.Imagestream.ImageStream _ImageStream { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageInfo _ImageInfo { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageChunkEvent _LoadingProgress { get; set; }
        internal virtual bool _IsListeningToStream { get; set; }
        internal virtual bool _InvertColors { get; set; }
        internal virtual int _FrameNumber { get; set; }
        internal virtual bool _WasSynchronouslyLoaded { get; set; }
        internal virtual FlutterSDK.Widgets.Disposablebuildcontext.DisposableBuildContext<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Image.Image>> _ScrollAwareContext { get; set; }
        internal virtual @Object _LastException { get; set; }
        internal virtual StackTrace _LastStack { get; set; }

        public new void InitState()
        {
            base.InitState();
            BindingDefaultClass.WidgetsBinding.Instance.AddObserver(this);
            _ScrollAwareContext = new DisposableBuildContext<State<Image>>(this);
        }




        public new void Dispose()
        {

            BindingDefaultClass.WidgetsBinding.Instance.RemoveObserver(this);
            _StopListeningToStream();
            _ScrollAwareContext.Dispose();
            base.Dispose();
        }




        public new void DidChangeDependencies()
        {
            _UpdateInvertColors();
            _ResolveImage();
            if (TickerproviderDefaultClass.TickerMode.Of(Context)) _ListenToStream(); else _StopListeningToStream();
            base.DidChangeDependencies();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Image.Image oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (_IsListeningToStream && (Widget.LoadingBuilder == null) != (oldWidget.LoadingBuilder == null))
            {
                _ImageStream.RemoveListener(_GetListener(oldWidget.LoadingBuilder));
                _ImageStream.AddListener(_GetListener());
            }

            if (Widget.Image != oldWidget.Image) _ResolveImage();
        }




        public new void DidChangeAccessibilityFeatures()
        {
            base.DidChangeAccessibilityFeatures();
            SetState(() =>
            {
                _UpdateInvertColors();
            }
            );
        }




        public new void Reassemble()
        {
            _ResolveImage();
            base.Reassemble();
        }




        private void _UpdateInvertColors()
        {
            _InvertColors = MediaqueryDefaultClass.MediaQuery.Of(Context, nullOk: true)?.InvertColors ?? BindingDefaultClass.SemanticsBinding.Instance.AccessibilityFeatures.InvertColors;
        }




        private void _ResolveImage()
        {
            ScrollAwareImageProvider provider = new ScrollAwareImageProvider<object>(context: _ScrollAwareContext, imageProvider: Widget.Image);
            ImageStream newStream = provider.Resolve(ImageDefaultClass.CreateLocalImageConfiguration(Context, size: Widget.Width != null && Widget.Height != null ? new Size(Widget.Width, Widget.Height) : null));

            _UpdateSourceStream(newStream);
        }




        private FlutterSDK.Painting.Imagestream.ImageStreamListener _GetListener(FlutterSDK.Widgets.Image.ImageLoadingBuilder loadingBuilder = default(FlutterSDK.Widgets.Image.ImageLoadingBuilder))
        {
            loadingBuilder = (loadingBuilder == null ? Widget.LoadingBuilder : loadingBuilder);
            _LastException = null;
            _LastStack = null;
            return new ImageStreamListener(_HandleImageFrame, onChunk: loadingBuilder == null ? null : _HandleImageChunk, onError: Widget.ErrorBuilder != null ? (object error, StackTrace stackTrace) =>
            {
                SetState(() =>
                {
                    _LastException = error;
                    _LastStack = stackTrace;
                }
                );
            }
            : null);
        }




        private void _HandleImageFrame(FlutterSDK.Painting.Imagestream.ImageInfo imageInfo, bool synchronousCall)
        {
            SetState(() =>
            {
                _ImageInfo = imageInfo;
                _LoadingProgress = null;
                _FrameNumber = _FrameNumber == null ? 0 : _FrameNumber + 1;
                _WasSynchronouslyLoaded |= synchronousCall;
            }
            );
        }




        private void _HandleImageChunk(FlutterSDK.Painting.Imagestream.ImageChunkEvent @event)
        {

            SetState(() =>
            {
                _LoadingProgress = @event;
            }
            );
        }




        private void _UpdateSourceStream(FlutterSDK.Painting.Imagestream.ImageStream newStream)
        {
            if (_ImageStream?.Key == newStream?.Key) return;
            if (_IsListeningToStream) _ImageStream.RemoveListener(_GetListener());
            if (!Widget.GaplessPlayback) SetState(() =>
            {
                _ImageInfo = null;
            }
             );
            SetState(() =>
            {
                _LoadingProgress = null;
                _FrameNumber = null;
                _WasSynchronouslyLoaded = false;
            }
            );
            _ImageStream = newStream;
            if (_IsListeningToStream) _ImageStream.AddListener(_GetListener());
        }




        private void _ListenToStream()
        {
            if (_IsListeningToStream) return;
            _ImageStream.AddListener(_GetListener());
            _IsListeningToStream = true;
        }




        private void _StopListeningToStream()
        {
            if (!_IsListeningToStream) return;
            _ImageStream.RemoveListener(_GetListener());
            _IsListeningToStream = false;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_LastException != null)
            {

                return Widget.ErrorBuilder(context, _LastException, _LastStack);
            }

            Widget result = new RawImage(image: _ImageInfo?.Image, width: Widget.Width, height: Widget.Height, scale: _ImageInfo?.Scale ?? 1.0, color: Widget.Color, colorBlendMode: Widget.ColorBlendMode, fit: Widget.Fit, alignment: Widget.Alignment, repeat: Widget.Repeat, centerSlice: Widget.CenterSlice, matchTextDirection: Widget.MatchTextDirection, invertColors: _InvertColors, filterQuality: Widget.FilterQuality);
            if (!Widget.ExcludeFromSemantics)
            {
                result = new Semantics(container: Widget.SemanticLabel != null, image: true, label: Widget.SemanticLabel ?? "", child: result);
            }

            if (Widget.FrameBuilder != null) result = Widget.FrameBuilder(context, result, _FrameNumber, _WasSynchronouslyLoaded);
            if (Widget.LoadingBuilder != null) result = Widget.LoadingBuilder(context, result, _LoadingProgress);
            return result;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
        {
            base.DebugFillProperties(description);
            description.Add(new DiagnosticsProperty<ImageStream>("stream", _ImageStream));
            description.Add(new DiagnosticsProperty<ImageInfo>("pixels", _ImageInfo));
            description.Add(new DiagnosticsProperty<ImageChunkEvent>("loadingProgress", _LoadingProgress));
            description.Add(new DiagnosticsProperty<int>("frameNumber", _FrameNumber));
            description.Add(new DiagnosticsProperty<bool>("wasSynchronouslyLoaded", _WasSynchronouslyLoaded));
        }



    }

}
