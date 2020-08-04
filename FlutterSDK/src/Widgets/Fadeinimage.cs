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
using FlutterSDK.Widgets.Constants;
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
namespace FlutterSDK.Widgets.Fadeinimage
{
    internal static class FadeinimageDefaultClass
    {
    }

    /// <Summary>
    /// An image that shows a [placeholder] image while the target [image] is
    /// loading, then fades in the new image when it loads.
    ///
    /// Use this class to display long-loading images, such as [new NetworkImage],
    /// so that the image appears on screen with a graceful animation rather than
    /// abruptly popping onto the screen.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=pK738Pg9cxc}
    ///
    /// If the [image] emits an [ImageInfo] synchronously, such as when the image
    /// has been loaded and cached, the [image] is displayed immediately, and the
    /// [placeholder] is never displayed.
    ///
    /// The [fadeOutDuration] and [fadeOutCurve] properties control the fade-out
    /// animation of the [placeholder].
    ///
    /// The [fadeInDuration] and [fadeInCurve] properties control the fade-in
    /// animation of the target [image].
    ///
    /// Prefer a [placeholder] that's already cached so that it is displayed
    /// immediately. This prevents it from popping onto the screen.
    ///
    /// When [image] changes, it is resolved to a new [ImageStream]. If the new
    /// [ImageStream.key] is different, this widget subscribes to the new stream and
    /// replaces the displayed image with images emitted by the new stream.
    ///
    /// When [placeholder] changes and the [image] has not yet emitted an
    /// [ImageInfo], then [placeholder] is resolved to a new [ImageStream]. If the
    /// new [ImageStream.key] is different, this widget subscribes to the new stream
    /// and replaces the displayed image to images emitted by the new stream.
    ///
    /// When either [placeholder] or [image] changes, this widget continues showing
    /// the previously loaded image (if any) until the new image provider provides a
    /// different image. This is known as "gapless playback" (see also
    /// [Image.gaplessPlayback]).
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// FadeInImage(
    ///   // here `bytes` is a Uint8List containing the bytes for the in-memory image
    ///   placeholder: MemoryImage(bytes),
    ///   image: NetworkImage('https://backend.example.com/image.png'),
    /// )
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class FadeInImage : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a widget that displays a [placeholder] while an [image] is loading,
        /// then fades-out the placeholder and fades-in the image.
        ///
        /// The [placeholder] and [image] may be composed in a [ResizeImage] to provide
        /// a custom decode/cache size.
        ///
        /// The [placeholder], [image], [fadeOutDuration], [fadeOutCurve],
        /// [fadeInDuration], [fadeInCurve], [alignment], [repeat], and
        /// [matchTextDirection] arguments must not be null.
        ///
        /// If [excludeFromSemantics] is true, then [imageSemanticLabel] will be ignored.
        /// </Summary>
        public FadeInImage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Imageprovider.ImageProvider<object> placeholder = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), bool excludeFromSemantics = false, string imageSemanticLabel = default(string), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve), double width = default(double), double height = default(double), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false)
        : base(key: key)
        {
            this.Placeholder = placeholder;
            this.PlaceholderErrorBuilder = placeholderErrorBuilder;
            this.Image = image;
            this.ImageErrorBuilder = imageErrorBuilder;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.ImageSemanticLabel = imageSemanticLabel;
            this.FadeOutDuration = fadeOutDuration;
            this.FadeOutCurve = fadeOutCurve;
            this.FadeInDuration = fadeInDuration;
            this.FadeInCurve = fadeInCurve;
            this.Width = width;
            this.Height = height;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.MatchTextDirection = matchTextDirection;
        }
        /// <Summary>
        /// Creates a widget that uses a placeholder image stored in memory while
        /// loading the final image from the network.
        ///
        /// The `placeholder` argument contains the bytes of the in-memory image.
        ///
        /// The `image` argument is the URL of the final image.
        ///
        /// The `placeholderScale` and `imageScale` arguments are passed to their
        /// respective [ImageProvider]s (see also [ImageInfo.scale]).
        ///
        /// If [placeholderCacheWidth], [placeholderCacheHeight], [imageCacheWidth],
        /// or [imageCacheHeight] are provided, it indicates to the
        /// engine that the respective image should be decoded at the specified size.
        /// The image will be rendered to the constraints of the layout or [width]
        /// and [height] regardless of these parameters. These parameters are primarily
        /// intended to reduce the memory usage of [ImageCache].
        ///
        /// The [placeholder], [image], [placeholderScale], [imageScale],
        /// [fadeOutDuration], [fadeOutCurve], [fadeInDuration], [fadeInCurve],
        /// [alignment], [repeat], and [matchTextDirection] arguments must not be
        /// null.
        ///
        /// See also:
        ///
        ///  * [new Image.memory], which has more details about loading images from
        ///    memory.
        ///  * [new Image.network], which has more details about loading images from
        ///    the network.
        /// </Summary>
        public static FadeInImage MemoryNetwork(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Uint8List placeholder = default(Uint8List), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string image = default(string), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), double placeholderScale = 1.0, double imageScale = 1.0, bool excludeFromSemantics = false, string imageSemanticLabel = default(string), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve), double width = default(double), double height = default(double), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false, int placeholderCacheWidth = default(int), int placeholderCacheHeight = default(int), int imageCacheWidth = default(int), int imageCacheHeight = default(int))
        => new FadeInImage(key, placeholder, placeholderErrorBuilder, image, imageErrorBuilder, placeholderScale, imageScale, excludeFromSemantics, imageSemanticLabel, fadeOutDuration, fadeOutCurve, fadeInDuration, fadeInCurve, width, height, fit, alignment, repeat, matchTextDirection, placeholderCacheWidth, placeholderCacheHeight, imageCacheWidth, imageCacheHeight);

        private FadeInImage(FlutterSDK.Foundation.Key.Key key, Uint8List placeholder, FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder, string image, FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder, double placeholderScale, double imageScale, bool excludeFromSemantics, string imageSemanticLabel, TimeSpan fadeOutDuration, FlutterSDK.Animation.Curves.Curve fadeOutCurve, TimeSpan fadeInDuration, FlutterSDK.Animation.Curves.Curve fadeInCurve, double width, double height, FlutterSDK.Painting.Boxfit.BoxFit fit, FlutterSDK.Painting.Alignment.AlignmentGeometry alignment, FlutterSDK.Painting.Decorationimage.ImageRepeat repeat, bool matchTextDirection, int placeholderCacheWidth, int placeholderCacheHeight, int imageCacheWidth, int imageCacheHeight)
        : base(key: key)
        {
            this.PlaceholderErrorBuilder = placeholderErrorBuilder;
            this.ImageErrorBuilder = imageErrorBuilder;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.ImageSemanticLabel = imageSemanticLabel;
            this.FadeOutDuration = fadeOutDuration;
            this.FadeOutCurve = fadeOutCurve;
            this.FadeInDuration = fadeInDuration;
            this.FadeInCurve = fadeInCurve;
            this.Width = width;
            this.Height = height;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.MatchTextDirection = matchTextDirection;
        }
        /// <Summary>
        /// Creates a widget that uses a placeholder image stored in an asset bundle
        /// while loading the final image from the network.
        ///
        /// The `placeholder` argument is the key of the image in the asset bundle.
        ///
        /// The `image` argument is the URL of the final image.
        ///
        /// The `placeholderScale` and `imageScale` arguments are passed to their
        /// respective [ImageProvider]s (see also [ImageInfo.scale]).
        ///
        /// If `placeholderScale` is omitted or is null, pixel-density-aware asset
        /// resolution will be attempted for the [placeholder] image. Otherwise, the
        /// exact asset specified will be used.
        ///
        /// If [placeholderCacheWidth], [placeholderCacheHeight], [imageCacheWidth],
        /// or [imageCacheHeight] are provided, it indicates to the
        /// engine that the respective image should be decoded at the specified size.
        /// The image will be rendered to the constraints of the layout or [width]
        /// and [height] regardless of these parameters. These parameters are primarily
        /// intended to reduce the memory usage of [ImageCache].
        ///
        /// The [placeholder], [image], [imageScale], [fadeOutDuration],
        /// [fadeOutCurve], [fadeInDuration], [fadeInCurve], [alignment], [repeat],
        /// and [matchTextDirection] arguments must not be null.
        ///
        /// See also:
        ///
        ///  * [new Image.asset], which has more details about loading images from
        ///    asset bundles.
        ///  * [new Image.network], which has more details about loading images from
        ///    the network.
        /// </Summary>
        public static FadeInImage AssetNetwork(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string placeholder = default(string), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string image = default(string), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), double placeholderScale = default(double), double imageScale = 1.0, bool excludeFromSemantics = false, string imageSemanticLabel = default(string), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve), double width = default(double), double height = default(double), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false, int placeholderCacheWidth = default(int), int placeholderCacheHeight = default(int), int imageCacheWidth = default(int), int imageCacheHeight = default(int))
        => new FadeInImage(key, placeholder, placeholderErrorBuilder, image, imageErrorBuilder, bundle, placeholderScale, imageScale, excludeFromSemantics, imageSemanticLabel, fadeOutDuration, fadeOutCurve, fadeInDuration, fadeInCurve, width, height, fit, alignment, repeat, matchTextDirection, placeholderCacheWidth, placeholderCacheHeight, imageCacheWidth, imageCacheHeight);

        private FadeInImage(FlutterSDK.Foundation.Key.Key key, string placeholder, FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder, string image, FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder, FlutterSDK.Services.Assetbundle.AssetBundle bundle, double placeholderScale, double imageScale, bool excludeFromSemantics, string imageSemanticLabel, TimeSpan fadeOutDuration, FlutterSDK.Animation.Curves.Curve fadeOutCurve, TimeSpan fadeInDuration, FlutterSDK.Animation.Curves.Curve fadeInCurve, double width, double height, FlutterSDK.Painting.Boxfit.BoxFit fit, FlutterSDK.Painting.Alignment.AlignmentGeometry alignment, FlutterSDK.Painting.Decorationimage.ImageRepeat repeat, bool matchTextDirection, int placeholderCacheWidth, int placeholderCacheHeight, int imageCacheWidth, int imageCacheHeight)
        : base(key: key)
        {
            this.PlaceholderErrorBuilder = placeholderErrorBuilder;
            this.ImageErrorBuilder = imageErrorBuilder;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.ImageSemanticLabel = imageSemanticLabel;
            this.FadeOutDuration = fadeOutDuration;
            this.FadeOutCurve = fadeOutCurve;
            this.FadeInDuration = fadeInDuration;
            this.FadeInCurve = fadeInCurve;
            this.Width = width;
            this.Height = height;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.MatchTextDirection = matchTextDirection;
        }
        /// <Summary>
        /// Image displayed while the target [image] is loading.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> Placeholder { get; set; }
        /// <Summary>
        /// A builder function that is called if an error occurs during placeholder
        /// image loading.
        ///
        /// If this builder is not provided, any exceptions will be reported to
        /// [FlutterError.onError]. If it is provided, the caller should either handle
        /// the exception by providing a replacement widget, or rethrow the exception.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder PlaceholderErrorBuilder { get; set; }
        /// <Summary>
        /// The target image that is displayed once it has loaded.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> Image { get; set; }
        /// <Summary>
        /// A builder function that is called if an error occurs during image loading.
        ///
        /// If this builder is not provided, any exceptions will be reported to
        /// [FlutterError.onError]. If it is provided, the caller should either handle
        /// the exception by providing a replacement widget, or rethrow the exception.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder ImageErrorBuilder { get; set; }
        /// <Summary>
        /// The duration of the fade-out animation for the [placeholder].
        /// </Summary>
        public virtual TimeSpan FadeOutDuration { get; set; }
        /// <Summary>
        /// The curve of the fade-out animation for the [placeholder].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve FadeOutCurve { get; set; }
        /// <Summary>
        /// The duration of the fade-in animation for the [image].
        /// </Summary>
        public virtual TimeSpan FadeInDuration { get; set; }
        /// <Summary>
        /// The curve of the fade-in animation for the [image].
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve FadeInCurve { get; set; }
        /// <Summary>
        /// If non-null, require the image to have this width.
        ///
        /// If null, the image will pick a size that best preserves its intrinsic
        /// aspect ratio. This may result in a sudden change if the size of the
        /// placeholder image does not match that of the target image. The size is
        /// also affected by the scale factor.
        /// </Summary>
        public virtual double Width { get; set; }
        /// <Summary>
        /// If non-null, require the image to have this height.
        ///
        /// If null, the image will pick a size that best preserves its intrinsic
        /// aspect ratio. This may result in a sudden change if the size of the
        /// placeholder image does not match that of the target image. The size is
        /// also affected by the scale factor.
        /// </Summary>
        public virtual double Height { get; set; }
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
        /// Whether to exclude this image from semantics.
        ///
        /// This is useful for images which do not contribute meaningful information
        /// to an application.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }
        /// <Summary>
        /// A semantic description of the [image].
        ///
        /// Used to provide a description of the [image] to TalkBack on Android, and
        /// VoiceOver on iOS.
        ///
        /// This description will be used both while the [placeholder] is shown and
        /// once the image has loaded.
        /// </Summary>
        public virtual string ImageSemanticLabel { get; set; }

        private FlutterSDK.Widgets.Image.Image _Image(FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder))
        {

            return new Image(image: image, errorBuilder: errorBuilder, frameBuilder: frameBuilder, width: Width, height: Height, fit: Fit, alignment: Alignment, repeat: Repeat, matchTextDirection: MatchTextDirection, gaplessPlayback: true, excludeFromSemantics: true);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget result = _Image(image: Image, errorBuilder: ImageErrorBuilder, frameBuilder: (BuildContext context, Widget child, int frame, bool wasSynchronouslyLoaded) =>
            {
                if (wasSynchronouslyLoaded) return child;
                return new _AnimatedFadeOutFadeIn(target: child, placeholder: _Image(image: Placeholder, errorBuilder: PlaceholderErrorBuilder), isTargetLoaded: frame != null, fadeInDuration: FadeInDuration, fadeOutDuration: FadeOutDuration, fadeInCurve: FadeInCurve, fadeOutCurve: FadeOutCurve);
            }
            );
            if (!ExcludeFromSemantics)
            {
                result = new Semantics(container: ImageSemanticLabel != null, image: true, label: ImageSemanticLabel ?? "", child: result);
            }

            return result;
        }



    }


    public class _AnimatedFadeOutFadeIn : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
    {
        public _AnimatedFadeOutFadeIn(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget target = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget placeholder = default(FlutterSDK.Widgets.Framework.Widget), bool isTargetLoaded = default(bool), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve))
        : base(key: key, duration: fadeInDuration + fadeOutDuration)
        {
            this.Target = target;
            this.Placeholder = placeholder;
            this.IsTargetLoaded = isTargetLoaded;
            this.FadeOutDuration = fadeOutDuration;
            this.FadeOutCurve = fadeOutCurve;
            this.FadeInDuration = fadeInDuration;
            this.FadeInCurve = fadeInCurve;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Target { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Placeholder { get; set; }
        public virtual bool IsTargetLoaded { get; set; }
        public virtual TimeSpan FadeInDuration { get; set; }
        public virtual TimeSpan FadeOutDuration { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve FadeInCurve { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve FadeOutCurve { get; set; }

        public new FlutterSDK.Widgets.Fadeinimage._AnimatedFadeOutFadeInState CreateState() => new _AnimatedFadeOutFadeInState();


    }


    public class _AnimatedFadeOutFadeInState : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Fadeinimage._AnimatedFadeOutFadeIn>
    {
        public _AnimatedFadeOutFadeInState()
        { }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _TargetOpacity { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _PlaceholderOpacity { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _TargetOpacityAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _PlaceholderOpacityAnimation { get; set; }

        public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
        {
            _TargetOpacity = visitor(_TargetOpacity, Widget.IsTargetLoaded ? 1.0 : 0.0, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
            _PlaceholderOpacity = visitor(_PlaceholderOpacity, Widget.IsTargetLoaded ? 0.0 : 1.0, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        }




        public new void DidUpdateTweens()
        {
            _PlaceholderOpacityAnimation = Animation.Drive(new TweenSequence<double>(new List<TweenSequenceItem<double>>() { new TweenSequenceItem<double>(tween: _PlaceholderOpacity.Chain(new CurveTween(curve: Widget.FadeOutCurve)), weight: Widget.FadeOutDuration.InMilliseconds.ToDouble()), new TweenSequenceItem<double>(tween: new ConstantTween<double>(0), weight: Widget.FadeInDuration.InMilliseconds.ToDouble()) }));
            Animation.Drive(new TweenSequence<double>(new List<TweenSequenceItem<double>>() { new TweenSequenceItem<double>(tween: _PlaceholderOpacity.Chain(new CurveTween(curve: Widget.FadeOutCurve)), weight: Widget.FadeOutDuration.InMilliseconds.ToDouble()), new TweenSequenceItem<double>(tween: new ConstantTween<double>(0), weight: Widget.FadeInDuration.InMilliseconds.ToDouble()) })).AddStatusListener((AnimationStatus status) =>
            {
                if (_PlaceholderOpacityAnimation.IsCompleted)
                {
                    SetState(() =>
                    {
                    }
                    );
                }

            }
            );
            _TargetOpacityAnimation = Animation.Drive(new TweenSequence<double>(new List<TweenSequenceItem<double>>() { new TweenSequenceItem<double>(tween: new ConstantTween<double>(0), weight: Widget.FadeOutDuration.InMilliseconds.ToDouble()), new TweenSequenceItem<double>(tween: _TargetOpacity.Chain(new CurveTween(curve: Widget.FadeInCurve)), weight: Widget.FadeInDuration.InMilliseconds.ToDouble()) }));
            if (!Widget.IsTargetLoaded && _IsValid(_PlaceholderOpacity) && _IsValid(_TargetOpacity))
            {
                Controller.Value = Controller.UpperBound;
            }

        }




        private bool _IsValid(FlutterSDK.Animation.Tween.Tween<double> tween)
        {
            return tween.Begin != null && tween.End != null;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget target = new FadeTransition(opacity: _TargetOpacityAnimation, child: Widget.Target);
            if (_PlaceholderOpacityAnimation.IsCompleted)
            {
                return target;
            }

            return new Stack(fit: StackFit.Passthrough, alignment: AlignmentDefaultClass.AlignmentDirectional.Center, textDirection: TextDirection.Ltr, children: new List<Widget>() { target, new FadeTransition(opacity: _PlaceholderOpacityAnimation, child: Widget.Placeholder) });
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Animation<double>>("targetOpacity", _TargetOpacityAnimation));
            properties.Add(new DiagnosticsProperty<Animation<double>>("placeholderOpacity", _PlaceholderOpacityAnimation));
        }



    }

}
