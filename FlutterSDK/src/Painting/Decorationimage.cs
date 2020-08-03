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
namespace FlutterSDK.Painting.Decorationimage
{
    internal static class DecorationimageDefaultClass
    {
        /// <Summary>
        /// Paints an image into the given rectangle on the canvas.
        ///
        /// The arguments have the following meanings:
        ///
        ///  * `canvas`: The canvas onto which the image will be painted.
        ///
        ///  * `rect`: The region of the canvas into which the image will be painted.
        ///    The image might not fill the entire rectangle (e.g., depending on the
        ///    `fit`). If `rect` is empty, nothing is painted.
        ///
        ///  * `image`: The image to paint onto the canvas.
        ///
        ///  * `scale`: The number of image pixels for each logical pixel.
        ///
        ///  * `colorFilter`: If non-null, the color filter to apply when painting the
        ///    image.
        ///
        ///  * `fit`: How the image should be inscribed into `rect`. If null, the
        ///    default behavior depends on `centerSlice`. If `centerSlice` is also null,
        ///    the default behavior is [BoxFit.scaleDown]. If `centerSlice` is
        ///    non-null, the default behavior is [BoxFit.fill]. See [BoxFit] for
        ///    details.
        ///
        ///  * `alignment`: How the destination rectangle defined by applying `fit` is
        ///    aligned within `rect`. For example, if `fit` is [BoxFit.contain] and
        ///    `alignment` is [Alignment.bottomRight], the image will be as large
        ///    as possible within `rect` and placed with its bottom right corner at the
        ///    bottom right corner of `rect`. Defaults to [Alignment.center].
        ///
        ///  * `centerSlice`: The image is drawn in nine portions described by splitting
        ///    the image by drawing two horizontal lines and two vertical lines, where
        ///    `centerSlice` describes the rectangle formed by the four points where
        ///    these four lines intersect each other. (This forms a 3-by-3 grid
        ///    of regions, the center region being described by `centerSlice`.)
        ///    The four regions in the corners are drawn, without scaling, in the four
        ///    corners of the destination rectangle defined by applying `fit`. The
        ///    remaining five regions are drawn by stretching them to fit such that they
        ///    exactly cover the destination rectangle while maintaining their relative
        ///    positions.
        ///
        ///  * `repeat`: If the image does not fill `rect`, whether and how the image
        ///    should be repeated to fill `rect`. By default, the image is not repeated.
        ///    See [ImageRepeat] for details.
        ///
        ///  * `flipHorizontally`: Whether to flip the image horizontally. This is
        ///    occasionally used with images in right-to-left environments, for images
        ///    that were designed for left-to-right locales (or vice versa). Be careful,
        ///    when using this, to not flip images with integral shadows, text, or other
        ///    effects that will look incorrect when flipped.
        ///
        ///  * `invertColors`: Inverting the colors of an image applies a new color
        ///    filter to the paint. If there is another specified color filter, the
        ///    invert will be applied after it. This is primarily used for implementing
        ///    smart invert on iOS.
        ///
        ///  * `filterQuality`: Use this to change the quality when scaling an image.
        ///     Use the [FilterQuality.low] quality setting to scale the image, which corresponds to
        ///     bilinear interpolation, rather than the default [FilterQuality.none] which corresponds
        ///     to nearest-neighbor.
        ///
        /// The `canvas`, `rect`, `image`, `scale`, `alignment`, `repeat`, `flipHorizontally` and `filterQuality`
        /// arguments must not be null.
        ///
        /// See also:
        ///
        ///  * [paintBorder], which paints a border around a rectangle on a canvas.
        ///  * [DecorationImage], which holds a configuration for calling this function.
        ///  * [BoxDecoration], which uses this function to paint a [DecorationImage].
        /// </Summary>
        internal static void PaintImage(Canvas canvas = default(Canvas), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), SKImage image = default(SKImage), double scale = 1.0, ColorFilter colorFilter = default(ColorFilter), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.Alignment alignment = default(FlutterSDK.Painting.Alignment.Alignment), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool flipHorizontally = false, bool invertColors = false, FilterQuality filterQuality = default(FilterQuality))
        {





            if (rect.IsEmpty()) return;
            Size outputSize = rect.Size;
            Size inputSize = new Size(image.Width.ToDouble(), image.Height.ToDouble());
            Offset sliceBorder = default(Offset);
            if (centerSlice != null)
            {
                sliceBorder = new Offset(centerSlice.Left + inputSize.Width - centerSlice.Right, centerSlice.Top + inputSize.Height - centerSlice.Bottom);
                outputSize = outputSize - sliceBorder as Size;
                inputSize = inputSize - sliceBorder as Size;
            }

            fit = (fit == null ? centerSlice == null ? BoxFit.ScaleDown : BoxFit.Fill : fit);

            FittedSizes fittedSizes = BoxfitDefaultClass.ApplyBoxFit(fit, inputSize / scale, outputSize);
            Size sourceSize = fittedSizes.Source * scale;
            Size destinationSize = fittedSizes.Destination;
            if (centerSlice != null)
            {
                outputSize += sliceBorder;
                destinationSize += sliceBorder;

            }

            if (repeat != ImageRepeat.NoRepeat && destinationSize == outputSize)
            {
                repeat = ImageRepeat.NoRepeat;
            }

            Paint paint = new Paint()..IsAntiAlias = false;
            if (colorFilter != null) paint.ColorFilter = colorFilter;
            if (sourceSize != destinationSize)
            {
                paint.FilterQuality = filterQuality;
            }

            paint.InvertColors = invertColors;
            double halfWidthDelta = (outputSize.Width - destinationSize.Width) / 2.0;
            double halfHeightDelta = (outputSize.Height - destinationSize.Height) / 2.0;
            double dx = halfWidthDelta + (flipHorizontally ? -alignment.x : alignment.x) * halfWidthDelta;
            double dy = halfHeightDelta + alignment.y * halfHeightDelta;
            Offset destinationPosition = rect.TopLeft.Translate(dx, dy);
            Rect destinationRect = destinationPosition & destinationSize;
            bool needSave = repeat != ImageRepeat.NoRepeat || flipHorizontally;
            if (needSave) canvas.Save();
            if (repeat != ImageRepeat.NoRepeat) canvas.ClipRect(rect);
            if (flipHorizontally)
            {
                double dx = -(rect.Left + rect.Width / 2.0);
                canvas.Translate(-dx, 0.0);
                canvas.Scale(-1.0, 1.0);
                canvas.Translate(dx, 0.0);
            }

            if (centerSlice == null)
            {
                Rect sourceRect = alignment.Inscribe(sourceSize, Dart.UI.UiDefaultClass.Offset.Zero & inputSize);
                if (repeat == ImageRepeat.NoRepeat)
                {
                    canvas.DrawImageRect(image, sourceRect, destinationRect, paint);
                }
                else
                {
                    foreach (Rect tileRect in DecorationimageDefaultClass._GenerateImageTileRects(rect, destinationRect, repeat)) canvas.DrawImageRect(image, sourceRect, tileRect, paint);
                }

            }
            else
            {
                if (repeat == ImageRepeat.NoRepeat)
                {
                    canvas.DrawImageNine(image, centerSlice, destinationRect, paint);
                }
                else
                {
                    foreach (Rect tileRect in DecorationimageDefaultClass._GenerateImageTileRects(rect, destinationRect, repeat)) canvas.DrawImageNine(image, centerSlice, tileRect, paint);
                }

            }

            if (needSave) canvas.Restore();
        }



        internal static Iterable<Rect> _GenerateImageTileRects(FlutterBinding.UI.Rect outputRect, FlutterBinding.UI.Rect fundamentalRect, FlutterSDK.Painting.Decorationimage.ImageRepeat repeat)
        {
            int startX = 0;
            int startY = 0;
            int stopX = 0;
            int stopY = 0;
            double strideX = fundamentalRect.Width;
            double strideY = fundamentalRect.Height;
            if (repeat == ImageRepeat.Repeat || repeat == ImageRepeat.RepeatX)
            {
                startX = ((outputRect.Left - fundamentalRect.Left) / strideX).Floor();
                stopX = ((outputRect.Right - fundamentalRect.Right) / strideX).Ceil();
            }

            if (repeat == ImageRepeat.Repeat || repeat == ImageRepeat.RepeatY)
            {
                startY = ((outputRect.Top - fundamentalRect.Top) / strideY).Floor();
                stopY = ((outputRect.Bottom - fundamentalRect.Bottom) / strideY).Ceil();
            }

            for (int i = startX; i <= stopX; ++i)
            {
                for (int j = startY; j <= stopY; ++j) yield return fundamentalRect.Shift(new Offset(i * strideX, j * strideY));
            }

        }



    }

    /// <Summary>
    /// An image for a box decoration.
    ///
    /// The image is painted using [paintImage], which describes the meanings of the
    /// various fields on this class in more detail.
    /// </Summary>
    public class DecorationImage
    {
        /// <Summary>
        /// Creates an image to show in a [BoxDecoration].
        ///
        /// The [image], [alignment], [repeat], and [matchTextDirection] arguments
        /// must not be null.
        /// </Summary>
        public DecorationImage(FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), ColorFilter colorFilter = default(ColorFilter), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false)
        : base()
        {
            this.Image = image;
            this.OnError = onError;
            this.ColorFilter = colorFilter;
            this.Fit = fit;
            this.Alignment = alignment;
            this.CenterSlice = centerSlice;
            this.Repeat = repeat;
            this.MatchTextDirection = matchTextDirection;
        }
        /// <Summary>
        /// The image to be painted into the decoration.
        ///
        /// Typically this will be an [AssetImage] (for an image shipped with the
        /// application) or a [NetworkImage] (for an image obtained from the network).
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> Image { get; set; }
        /// <Summary>
        /// An optional error callback for errors emitted when loading [image].
        /// </Summary>
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnError { get; set; }
        /// <Summary>
        /// A color filter to apply to the image before painting it.
        /// </Summary>
        public virtual ColorFilter ColorFilter { get; set; }
        /// <Summary>
        /// How the image should be inscribed into the box.
        ///
        /// The default is [BoxFit.scaleDown] if [centerSlice] is null, and
        /// [BoxFit.fill] if [centerSlice] is not null.
        ///
        /// See the discussion at [paintImage] for more details.
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        /// <Summary>
        /// How to align the image within its bounds.
        ///
        /// The alignment aligns the given position in the image to the given position
        /// in the layout bounds. For example, an [Alignment] alignment of (-1.0,
        /// -1.0) aligns the image to the top-left corner of its layout bounds, while a
        /// [Alignment] alignment of (1.0, 1.0) aligns the bottom right of the
        /// image with the bottom right corner of its layout bounds. Similarly, an
        /// alignment of (0.0, 1.0) aligns the bottom middle of the image with the
        /// middle of the bottom edge of its layout bounds.
        ///
        /// To display a subpart of an image, consider using a [CustomPainter] and
        /// [Canvas.drawImageRect].
        ///
        /// If the [alignment] is [TextDirection]-dependent (i.e. if it is a
        /// [AlignmentDirectional]), then a [TextDirection] must be available
        /// when the image is painted.
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
        /// The center slice for a nine-patch image.
        ///
        /// The region of the image inside the center slice will be stretched both
        /// horizontally and vertically to fit the image into its destination. The
        /// region of the image above and below the center slice will be stretched
        /// only horizontally and the region of the image to the left and right of
        /// the center slice will be stretched only vertically.
        ///
        /// The stretching will be applied in order to make the image fit into the box
        /// specified by [fit]. When [centerSlice] is not null, [fit] defaults to
        /// [BoxFit.fill], which distorts the destination image size relative to the
        /// image's original aspect ratio. Values of [BoxFit] which do not distort the
        /// destination image size will result in [centerSlice] having no effect
        /// (since the nine regions of the image will be rendered with the same
        /// scaling, as if it wasn't specified).
        /// </Summary>
        public virtual FlutterBinding.UI.Rect CenterSlice { get; set; }
        /// <Summary>
        /// How to paint any portions of the box that would not otherwise be covered
        /// by the image.
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
        /// </Summary>
        public virtual bool MatchTextDirection { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a [DecorationImagePainter] for this [DecorationImage].
        ///
        /// The `onChanged` argument must not be null. It will be called whenever the
        /// image needs to be repainted, e.g. because it is loading incrementally or
        /// because it is animated.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decorationimage.DecorationImagePainter CreatePainter(VoidCallback onChanged)
        {

            return DecorationImagePainter._(this, onChanged);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is DecorationImage && other.Image == Image && other.ColorFilter == ColorFilter && other.Fit == Fit && other.Alignment == Alignment && other.CenterSlice == CenterSlice && other.Repeat == Repeat && other.MatchTextDirection == MatchTextDirection;
        }




    }


    /// <Summary>
    /// The painter for a [DecorationImage].
    ///
    /// To obtain a painter, call [DecorationImage.createPainter].
    ///
    /// To paint, call [paint]. The `onChanged` callback passed to
    /// [DecorationImage.createPainter] will be called if the image needs to paint
    /// again (e.g. because it is animated or because it had not yet loaded the
    /// first time the [paint] method was called).
    ///
    /// This object should be disposed using the [dispose] method when it is no
    /// longer needed.
    /// </Summary>
    public class DecorationImagePainter
    {
        internal DecorationImagePainter(FlutterSDK.Painting.Decorationimage.DecorationImage _details, VoidCallback _onChanged)
        : base()
        {
            this._Details = _details;
            this._OnChanged = _onChanged;
        }
        internal virtual FlutterSDK.Painting.Decorationimage.DecorationImage _Details { get; set; }
        internal virtual VoidCallback _OnChanged { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageStream _ImageStream { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageInfo _Image { get; set; }

        /// <Summary>
        /// Draw the image onto the given canvas.
        ///
        /// The image is drawn at the position and size given by the `rect` argument.
        ///
        /// The image is clipped to the given `clipPath`, if any.
        ///
        /// The `configuration` object is used to resolve the image (e.g. to pick
        /// resolution-specific assets), and to implement the
        /// [DecorationImage.matchTextDirection] feature.
        ///
        /// If the image needs to be painted again, e.g. because it is animated or
        /// because it had not yet been loaded the first time this method was called,
        /// then the `onChanged` callback passed to [DecorationImage.createPainter]
        /// will be called.
        /// </Summary>
        public virtual void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, Path clipPath, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {



            bool flipHorizontally = false;
            if (_Details.MatchTextDirection)
            {

                if (configuration.TextDirection == TextDirection.Rtl) flipHorizontally = true;
            }

            ImageStream newImageStream = _Details.Image.Resolve(configuration);
            if (newImageStream.Key != _ImageStream?.Key)
            {
                ImageStreamListener listener = new ImageStreamListener(_HandleImage, onError: _Details.OnError);
                _ImageStream?.RemoveListener(listener);
                _ImageStream = newImageStream;
                _ImageStream.AddListener(listener);
            }

            if (_Image == null) return;
            if (clipPath != null)
            {
                canvas.Save();
                canvas.ClipPath(clipPath);
            }

            DecorationimageDefaultClass.PaintImage(canvas: canvas, rect: rect, image: _Image.Image, scale: _Image.Scale, colorFilter: _Details.ColorFilter, fit: _Details.Fit, alignment: _Details.Alignment.Resolve(configuration.TextDirection), centerSlice: _Details.CenterSlice, repeat: _Details.Repeat, flipHorizontally: flipHorizontally, filterQuality: FilterQuality.Low);
            if (clipPath != null) canvas.Restore();
        }




        private void _HandleImage(FlutterSDK.Painting.Imagestream.ImageInfo value, bool synchronousCall)
        {
            if (_Image == value) return;
            _Image = value;

            if (!synchronousCall) _OnChanged();
        }




        /// <Summary>
        /// Releases the resources used by this painter.
        ///
        /// This should be called whenever the painter is no longer needed.
        ///
        /// After this method has been called, the object is no longer usable.
        /// </Summary>
        public virtual void Dispose()
        {
            _ImageStream?.RemoveListener(new ImageStreamListener(_HandleImage, onError: _Details.OnError));
        }




    }


    /// <Summary>
    /// How to paint any portions of a box not covered by an image.
    /// </Summary>
    public enum ImageRepeat
    {

        /// <Summary>
        /// Repeat the image in both the x and y directions until the box is filled.
        /// </Summary>
        Repeat,
        /// <Summary>
        /// Repeat the image in the x direction until the box is filled horizontally.
        /// </Summary>
        RepeatX,
        /// <Summary>
        /// Repeat the image in the y direction until the box is filled vertically.
        /// </Summary>
        RepeatY,
        /// <Summary>
        /// Leave uncovered portions of the box transparent.
        /// </Summary>
        NoRepeat,
    }

}
