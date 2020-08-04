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
namespace FlutterSDK.Painting.Gradient
{
    internal static class GradientDefaultClass
    {
        /// <Summary>
        /// Calculate the color at position [t] of the gradient defined by [colors] and [stops].
        /// </Summary>
        internal static Color _Sample(List<Color> colors, List<double> stops, double t)
        {





            if (t <= stops.First) return colors.First;
            if (t >= stops.Last()) return colors.Last();
            int index = stops.LastIndexWhere((double s) => =>s <= t);

            return Dart.UI.UiDefaultClass.Color.Lerp(colors[index], colors[index + 1], (t - stops[index]) / (stops[index + 1] - stops[index]));
        }



        internal static FlutterSDK.Painting.Gradient._ColorsAndStops _InterpolateColorsAndStops(List<Color> aColors, List<double> aStops, List<Color> bColors, List<double> bStops, double t)
        {




            SplayTreeSet<double> stops = new SplayTreeSet<double>();
            new SplayTreeSet<double>().AddAll(aStops);
            new SplayTreeSet<double>().AddAll(bStops);
            List<double> interpolatedStops = stops.ToList(growable: false);
            List<Color> interpolatedColors = interpolatedStops.Map((double stop) => =>Dart.UI.UiDefaultClass.Color.Lerp(GradientDefaultClass._Sample(aColors, aStops, stop), GradientDefaultClass._Sample(bColors, bStops, stop), t)).ToList(growable: false);
            return new _ColorsAndStops(interpolatedColors, interpolatedStops);
        }



    }

    /// <Summary>
    /// Base class for transforming gradient shaders without applying the same
    /// transform to the entire canvas.
    ///
    /// For example, a [SweepGradient] normally starts its gradation at 3 o'clock
    /// and draws clockwise. To have the sweep appear to start at 6 o'clock, supply
    /// a [GradientRotation] of `pi/4` radians (i.e. 45 degrees).
    /// </Summary>
    public interface IGradientTransform
    {
        Matrix4 Transform(FlutterBinding.UI.Rect bounds, TextDirection textDirection = default(TextDirection));
    }


    /// <Summary>
    /// A 2D gradient.
    ///
    /// This is an interface that allows [LinearGradient], [RadialGradient], and
    /// [SweepGradient] classes to be used interchangeably in [BoxDecoration]s.
    ///
    /// See also:
    ///
    ///  * [Gradient](dart-ui/Gradient-class.html), the class in the [dart:ui] library.
    ///
    /// </Summary>
    public interface IGradient
    {
        SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection));
        FlutterSDK.Painting.Gradient.Gradient Scale(double factor);
        FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t);
        FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t);
        FlutterSDK.Painting.Gradient.Gradient Lerp(FlutterSDK.Painting.Gradient.Gradient a, FlutterSDK.Painting.Gradient.Gradient b, double t);
        List<Color> Colors { get; }
        List<double> Stops { get; }
        FlutterSDK.Painting.Gradient.GradientTransform Transform { get; }
    }


    public class _ColorsAndStops
    {
        public _ColorsAndStops(List<Color> colors, List<double> stops)
        {
            this.Colors = colors;
            this.Stops = stops;
        }
        public virtual List<Color> Colors { get; set; }
        public virtual List<double> Stops { get; set; }
    }


    /// <Summary>
    /// Base class for transforming gradient shaders without applying the same
    /// transform to the entire canvas.
    ///
    /// For example, a [SweepGradient] normally starts its gradation at 3 o'clock
    /// and draws clockwise. To have the sweep appear to start at 6 o'clock, supply
    /// a [GradientRotation] of `pi/4` radians (i.e. 45 degrees).
    /// </Summary>
    public class GradientTransform
    {
        /// <Summary>
        /// A const constructor so that subclasses may be const.
        /// </Summary>
        public GradientTransform()
        {

        }

        /// <Summary>
        /// When a [Gradient] creates its [Shader], it will call this method to
        /// determine what transform to apply to the shader for the given [Rect] and
        /// [TextDirection].
        ///
        /// Implementers may return null from this method, which achieves the same
        /// final effect as returning [Matrix4.identity].
        /// </Summary>
        public virtual Matrix4 Transform(FlutterBinding.UI.Rect bounds, TextDirection textDirection = default(TextDirection))
        {
            return default(Matrix4);
        }

    }


    /// <Summary>
    /// A [GradientTransform] that rotates the gradient around the center-point of
    /// its bounding box.
    ///
    /// {@tool snippet}
    ///
    /// This sample would rotate a sweep gradient by a quarter turn clockwise:
    ///
    /// ```dart
    /// const SweepGradient gradient = SweepGradient(
    ///   colors: <Color>[Color(0xFFFFFFFF), Color(0xFF009900)],
    ///   transform: GradientRotation(math.pi/4),
    /// );
    /// ```
    /// </Summary>
    public class GradientRotation : FlutterSDK.Painting.Gradient.GradientTransform
    {
        /// <Summary>
        /// Constructs a [GradientRotation] for the specified angle.
        ///
        /// The angle is in radians in the clockwise direction.
        /// </Summary>
        public GradientRotation(double radians)
        {
            this.Radians = radians;
        }
        /// <Summary>
        /// The angle of rotation in radians in the clockwise direction.
        /// </Summary>
        public virtual double Radians { get; set; }

        public new Matrix4 Transform(FlutterBinding.UI.Rect bounds, TextDirection textDirection = default(TextDirection))
        {

            double sinRadians = Dart.Math.MathDefaultClass.Sin(Radians);
            double oneMinusCosRadians = 1 - Dart.Math.MathDefaultClass.Cos(Radians);
            Offset center = bounds.Center;
            double originX = sinRadians * center.Dy + oneMinusCosRadians * center.Dx;
            double originY = -sinRadians * center.Dx + oneMinusCosRadians * center.Dy;
            return Matrix4.Identity();
            Matrix4.Identity().Translate(originX, originY);
            Matrix4.Identity().RotateZ(Radians);
        }



    }


    /// <Summary>
    /// A 2D gradient.
    ///
    /// This is an interface that allows [LinearGradient], [RadialGradient], and
    /// [SweepGradient] classes to be used interchangeably in [BoxDecoration]s.
    ///
    /// See also:
    ///
    ///  * [Gradient](dart-ui/Gradient-class.html), the class in the [dart:ui] library.
    ///
    /// </Summary>
    public class Gradient
    {
        /// <Summary>
        /// Initialize the gradient's colors and stops.
        ///
        /// The [colors] argument must not be null, and must have at least two colors
        /// (the length is not verified until the [createShader] method is called).
        ///
        /// If specified, the [stops] argument must have the same number of entries as
        /// [colors] (this is also not verified until the [createShader] method is
        /// called).
        ///
        /// The [transform] argument can be applied to transform _only_ the gradient,
        /// without rotating the canvas itself or other geometry on the canvas. For
        /// example, a `GradientRotation(math.pi/4)` will result in a [SweepGradient]
        /// that starts from a position of 6 o'clock instead of 3 o'clock, assuming
        /// no other rotation or perspective transformations have been applied to the
        /// [Canvas]. If null, no transformation is applied.
        /// </Summary>
        public Gradient(List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base()
        {
            this.Colors = colors;
            this.Stops = stops;
            this.Transform = transform;
        }
        /// <Summary>
        /// The colors the gradient should obtain at each of the stops.
        ///
        /// If [stops] is non-null, this list must have the same length as [stops].
        ///
        /// This list must have at least two colors in it (otherwise, it's not a
        /// gradient!).
        /// </Summary>
        public virtual List<Color> Colors { get; set; }
        /// <Summary>
        /// A list of values from 0.0 to 1.0 that denote fractions along the gradient.
        ///
        /// If non-null, this list must have the same length as [colors].
        ///
        /// If the first value is not 0.0, then a stop with position 0.0 and a color
        /// equal to the first color in [colors] is implied.
        ///
        /// If the last value is not 1.0, then a stop with position 1.0 and a color
        /// equal to the last color in [colors] is implied.
        ///
        /// The values in the [stops] list must be in ascending order. If a value in
        /// the [stops] list is less than an earlier value in the list, then its value
        /// is assumed to equal the previous value.
        ///
        /// If stops is null, then a set of uniformly distributed stops is implied,
        /// with the first stop at 0.0 and the last stop at 1.0.
        /// </Summary>
        public virtual List<double> Stops { get; set; }
        /// <Summary>
        /// The transform, if any, to apply to the gradient.
        ///
        /// This transform is in addition to any other transformations applied to the
        /// canvas, but does not add any transformations to the canvas.
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.GradientTransform Transform { get; set; }

        private List<double> _ImpliedStops()
        {
            if (Stops != null) return Stops;

            double separation = 1.0 / (Colors.Count - 1);
            return List<double>.Generate(Colors.Count, (int index) => =>index * separation, growable: false);
        }




        /// <Summary>
        /// Creates a [Shader] for this gradient to fill the given rect.
        ///
        /// If the gradient's configuration is text-direction-dependent, for example
        /// it uses [AlignmentDirectional] objects instead of [Alignment]
        /// objects, then the `textDirection` argument must not be null.
        ///
        /// The shader's transform will be resolved from the [transform] of this
        /// gradient.
        /// </Summary>
        public virtual SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return default(SKShader);
        }


        /// <Summary>
        /// Returns a new gradient with its properties scaled by the given factor.
        ///
        /// A factor of 0.0 (or less) should result in a variant of the gradient that
        /// is invisible; any two factors epsilon apart should be unnoticeably
        /// different from each other at first glance. From this it follows that
        /// scaling a gradient with values from 1.0 to 0.0 over time should cause the
        /// gradient to smoothly disappear.
        ///
        /// Typically this is the same as interpolating from null (with [lerp]).
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.Gradient Scale(double factor)
        {
            return default(Gradient);
        }


        /// <Summary>
        /// Linearly interpolates from another [Gradient] to `this`.
        ///
        /// When implementing this method in subclasses, return null if this class
        /// cannot interpolate from `a`. In that case, [lerp] will try `a`'s [lerpTo]
        /// method instead.
        ///
        /// If `a` is null, this must not return null. The base class implements this
        /// by deferring to [scale].
        ///
        /// The `t` argument represents position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `a` (or something
        /// equivalent to `a`), 1.0 meaning that the interpolation has finished,
        /// returning `this` (or something equivalent to `this`), and values in
        /// between meaning that the interpolation is at the relevant point on the
        /// timeline between `a` and `this`. The interpolation can be extrapolated
        /// beyond 0.0 and 1.0, so negative values and values greater than 1.0 are
        /// valid (and can easily be generated by curves such as
        /// [Curves.elasticInOut]).
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        ///
        /// Instead of calling this directly, use [Gradient.lerp].
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t)
        {
            if (a == null) return Scale(t);
            return null;
        }




        /// <Summary>
        /// Linearly interpolates from `this` to another [Gradient].
        ///
        /// This is called if `b`'s [lerpTo] did not know how to handle this class.
        ///
        /// When implementing this method in subclasses, return null if this class
        /// cannot interpolate from `b`. In that case, [lerp] will apply a default
        /// behavior instead.
        ///
        /// If `b` is null, this must not return null. The base class implements this
        /// by deferring to [scale].
        ///
        /// The `t` argument represents position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `this` (or something
        /// equivalent to `this`), 1.0 meaning that the interpolation has finished,
        /// returning `b` (or something equivalent to `b`), and values in between
        /// meaning that the interpolation is at the relevant point on the timeline
        /// between `this` and `b`. The interpolation can be extrapolated beyond 0.0
        /// and 1.0, so negative values and values greater than 1.0 are valid (and can
        /// easily be generated by curves such as [Curves.elasticInOut]).
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        ///
        /// Instead of calling this directly, use [Gradient.lerp].
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t)
        {
            if (b == null) return Scale(1.0 - t);
            return null;
        }




        /// <Summary>
        /// Linearly interpolates between two [Gradient]s.
        ///
        /// This defers to `b`'s [lerpTo] function if `b` is not null. If `b` is
        /// null or if its [lerpTo] returns null, it uses `a`'s [lerpFrom]
        /// function instead. If both return null, it returns `a` before `t == 0.5`
        /// and `b` after `t == 0.5`.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.Gradient Lerp(FlutterSDK.Painting.Gradient.Gradient a, FlutterSDK.Painting.Gradient.Gradient b, double t)
        {

            Gradient result = default(Gradient);
            if (b != null) result = b.LerpFrom(a, t);
            if (result == null && a != null) result = a.LerpTo(b, t);
            if (result != null) return result;
            if (a == null && b == null) return null;

            return t < 0.5 ? a.Scale(1.0 - (t * 2.0)) : b.Scale((t - 0.5) * 2.0);
        }




        private List<float> _ResolveTransform(FlutterBinding.UI.Rect bounds, TextDirection textDirection)
        {
            return Transform?.Transform(bounds, textDirection: textDirection)?.Storage;
        }



    }


    /// <Summary>
    /// A 2D linear gradient.
    ///
    /// This class is used by [BoxDecoration] to represent linear gradients. This
    /// abstracts out the arguments to the [new ui.Gradient.linear] constructor from
    /// the `dart:ui` library.
    ///
    /// A gradient has two anchor points, [begin] and [end]. The [begin] point
    /// corresponds to 0.0, and the [end] point corresponds to 1.0. These points are
    /// expressed in fractions, so that the same gradient can be reused with varying
    /// sized boxes without changing the parameters. (This contrasts with [new
    /// ui.Gradient.linear], whose arguments are expressed in logical pixels.)
    ///
    /// The [colors] are described by a list of [Color] objects. There must be at
    /// least two colors. The [stops] list, if specified, must have the same length
    /// as [colors]. It specifies fractions of the vector from start to end, between
    /// 0.0 and 1.0, for each color. If it is null, a uniform distribution is
    /// assumed.
    ///
    /// The region of the canvas before [begin] and after [end] is colored according
    /// to [tileMode].
    ///
    /// Typically this class is used with [BoxDecoration], which does the painting.
    /// To use a [LinearGradient] to paint on a canvas directly, see [createShader].
    ///
    /// {@tool snippet}
    ///
    /// This sample draws a picture that looks like vertical window shades by having
    /// a [Container] display a [BoxDecoration] with a [LinearGradient].
    ///
    /// ```dart
    /// Container(
    ///   decoration: BoxDecoration(
    ///     gradient: LinearGradient(
    ///       begin: Alignment.topLeft,
    ///       end: Alignment(0.8, 0.0), // 10% of the width, so there are ten blinds.
    ///       colors: [const Color(0xFFFFFFEE), const Color(0xFF999999)], // whitish to gray
    ///       tileMode: TileMode.repeated, // repeats the gradient over the canvas
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RadialGradient], which displays a gradient in concentric circles, and
    ///    has an example which shows a different way to use [Gradient] objects.
    ///  * [SweepGradient], which displays a gradient in a sweeping arc around a
    ///    center point.
    ///  * [BoxDecoration], which can take a [LinearGradient] in its
    ///    [BoxDecoration.gradient] property.
    /// </Summary>
    public class LinearGradient : FlutterSDK.Painting.Gradient.Gradient
    {
        /// <Summary>
        /// Creates a linear gradient.
        ///
        /// The [colors] argument must not be null. If [stops] is non-null, it must
        /// have the same length as [colors].
        /// </Summary>
        public LinearGradient(FlutterSDK.Painting.Alignment.AlignmentGeometry begin = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Alignment.AlignmentGeometry end = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), TileMode tileMode = default(TileMode), FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base(colors: colors, stops: stops, transform: transform)
        {
            this.Begin = begin;
            this.End = end;
            this.TileMode = tileMode;
        }
        /// <Summary>
        /// The offset at which stop 0.0 of the gradient is placed.
        ///
        /// If this is an [Alignment], then it is expressed as a vector from
        /// coordinate (0.0, 0.0), in a coordinate space that maps the center of the
        /// paint box at (0.0, 0.0) and the bottom right at (1.0, 1.0).
        ///
        /// For example, a begin offset of (-1.0, 0.0) is half way down the
        /// left side of the box.
        ///
        /// It can also be an [AlignmentDirectional], where the start is the
        /// left in left-to-right contexts and the right in right-to-left contexts. If
        /// a text-direction-dependent value is provided here, then the [createShader]
        /// method will need to be given a [TextDirection].
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Begin { get; set; }
        /// <Summary>
        /// The offset at which stop 1.0 of the gradient is placed.
        ///
        /// If this is an [Alignment], then it is expressed as a vector from
        /// coordinate (0.0, 0.0), in a coordinate space that maps the center of the
        /// paint box at (0.0, 0.0) and the bottom right at (1.0, 1.0).
        ///
        /// For example, a begin offset of (1.0, 0.0) is half way down the
        /// right side of the box.
        ///
        /// It can also be an [AlignmentDirectional], where the start is the left in
        /// left-to-right contexts and the right in right-to-left contexts. If a
        /// text-direction-dependent value is provided here, then the [createShader]
        /// method will need to be given a [TextDirection].
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry End { get; set; }
        /// <Summary>
        /// How this gradient should tile the plane beyond in the region before
        /// [begin] and after [end].
        ///
        /// For details, see [TileMode].
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_linear.png)
        /// </Summary>
        public virtual TileMode TileMode { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return Dart.UI.Gradient.Linear(Begin.Resolve(textDirection).WithinRect(rect), End.Resolve(textDirection).WithinRect(rect), Colors, _ImpliedStops(), TileMode, _ResolveTransform(rect, textDirection));
        }




        /// <Summary>
        /// Returns a new [LinearGradient] with its colors scaled by the given factor.
        ///
        /// Since the alpha component of the Color is what is scaled, a factor
        /// of 0.0 or less results in a gradient that is fully transparent.
        /// </Summary>
        public new FlutterSDK.Painting.Gradient.LinearGradient Scale(double factor)
        {
            return new LinearGradient(begin: Begin, end: End, colors: Colors.Map((Color color) => =>Dart.UI.UiDefaultClass.Color.Lerp(null, color, factor)).ToList(), stops: Stops, tileMode: TileMode);
        }




        public new FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t)
        {
            if (a == null || (a is LinearGradient)) return GradientDefaultClass.LinearGradient.Lerp(a as LinearGradient, this, t);
            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t)
        {
            if (b == null || (b is LinearGradient)) return GradientDefaultClass.LinearGradient.Lerp(this, b as LinearGradient, t);
            return base.LerpTo(b, t);
        }




        /// <Summary>
        /// Linearly interpolate between two [LinearGradient]s.
        ///
        /// If either gradient is null, this function linearly interpolates from a
        /// a gradient that matches the other gradient in [begin], [end], [stops] and
        /// [tileMode] and with the same [colors] but transparent (using [scale]).
        ///
        /// If neither gradient is null, they must have the same number of [colors].
        ///
        /// The `t` argument represents a position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `a` (or something
        /// equivalent to `a`), 1.0 meaning that the interpolation has finished,
        /// returning `b` (or something equivalent to `b`), and values in between
        /// meaning that the interpolation is at the relevant point on the timeline
        /// between `a` and `b`. The interpolation can be extrapolated beyond 0.0 and
        /// 1.0, so negative values and values greater than 1.0 are valid (and can
        /// easily be generated by curves such as [Curves.elasticInOut]).
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.LinearGradient Lerp(FlutterSDK.Painting.Gradient.LinearGradient a, FlutterSDK.Painting.Gradient.LinearGradient b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b.Scale(t);
            if (b == null) return a.Scale(1.0 - t);
            _ColorsAndStops interpolated = GradientDefaultClass._InterpolateColorsAndStops(a.Colors, a._ImpliedStops(), b.Colors, b._ImpliedStops(), t);
            return new LinearGradient(begin: AlignmentDefaultClass.AlignmentGeometry.Lerp(a.Begin, b.Begin, t), end: AlignmentDefaultClass.AlignmentGeometry.Lerp(a.End, b.End, t), colors: interpolated.Colors, stops: interpolated.Stops, tileMode: t < 0.5 ? a.TileMode : b.TileMode);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is LinearGradient && other.Begin == Begin && other.End == End && other.TileMode == TileMode && CollectionsDefaultClass.ListEquals(other.Colors, Colors) && CollectionsDefaultClass.ListEquals(other.Stops, Stops);
        }




    }


    /// <Summary>
    /// A 2D radial gradient.
    ///
    /// This class is used by [BoxDecoration] to represent radial gradients. This
    /// abstracts out the arguments to the [new ui.Gradient.radial] constructor from
    /// the `dart:ui` library.
    ///
    /// A normal radial gradient has a [center] and a [radius]. The [center] point
    /// corresponds to 0.0, and the ring at [radius] from the center corresponds
    /// to 1.0. These lengths are expressed in fractions, so that the same gradient
    /// can be reused with varying sized boxes without changing the parameters.
    /// (This contrasts with [new ui.Gradient.radial], whose arguments are expressed
    /// in logical pixels.)
    ///
    /// It is also possible to create a two-point (or focal pointed) radial gradient
    /// (which is sometimes referred to as a two point conic gradient, but is not the
    /// same as a CSS conic gradient which corresponds to a [SweepGradient]). A [focal]
    /// point and [focalRadius] can be specified similarly to [center] and [radius],
    /// which will make the rendered gradient appear to be pointed or directed in the
    /// direction of the [focal] point. This is only important if [focal] and [center]
    /// are not equal or [focalRadius] > 0.0 (as this case is visually identical to a
    /// normal radial gradient).  One important case to avoid is having [focal] and
    /// [center] both resolve to [Offset.zero] when [focalRadius] > 0.0. In such a case,
    /// a valid shader cannot be created by the framework.
    ///
    /// The [colors] are described by a list of [Color] objects. There must be at
    /// least two colors. The [stops] list, if specified, must have the same length
    /// as [colors]. It specifies fractions of the radius between 0.0 and 1.0,
    /// giving concentric rings for each color stop. If it is null, a uniform
    /// distribution is assumed.
    ///
    /// The region of the canvas beyond [radius] from the [center] is colored
    /// according to [tileMode].
    ///
    /// Typically this class is used with [BoxDecoration], which does the painting.
    /// To use a [RadialGradient] to paint on a canvas directly, see [createShader].
    ///
    /// {@tool snippet}
    ///
    /// This function draws a gradient that looks like a sun in a blue sky.
    ///
    /// ```dart
    /// void paintSky(Canvas canvas, Rect rect) {
    ///   var gradient = RadialGradient(
    ///     center: const Alignment(0.7, -0.6), // near the top right
    ///     radius: 0.2,
    ///     colors: [
    ///       const Color(0xFFFFFF00), // yellow sun
    ///       const Color(0xFF0099FF), // blue sky
    ///     ],
    ///     stops: [0.4, 1.0],
    ///   );
    ///   // rect is the area we are painting over
    ///   var paint = Paint()
    ///     ..shader = gradient.createShader(rect);
    ///   canvas.drawRect(rect, paint);
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [LinearGradient], which displays a gradient in parallel lines, and has an
    ///    example which shows a different way to use [Gradient] objects.
    ///  * [SweepGradient], which displays a gradient in a sweeping arc around a
    ///    center point.
    ///  * [BoxDecoration], which can take a [RadialGradient] in its
    ///    [BoxDecoration.gradient] property.
    ///  * [CustomPainter], which shows how to use the above sample code in a custom
    ///    painter.
    /// </Summary>
    public class RadialGradient : FlutterSDK.Painting.Gradient.Gradient
    {
        /// <Summary>
        /// Creates a radial gradient.
        ///
        /// The [colors] argument must not be null. If [stops] is non-null, it must
        /// have the same length as [colors].
        /// </Summary>
        public RadialGradient(FlutterSDK.Painting.Alignment.AlignmentGeometry center = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double radius = 0.5, List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), TileMode tileMode = default(TileMode), FlutterSDK.Painting.Alignment.AlignmentGeometry focal = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double focalRadius = 0.0, FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base(colors: colors, stops: stops, transform: transform)
        {
            this.Center = center;
            this.Radius = radius;
            this.TileMode = tileMode;
            this.Focal = focal;
            this.FocalRadius = focalRadius;
        }
        /// <Summary>
        /// The center of the gradient, as an offset into the (-1.0, -1.0) x (1.0, 1.0)
        /// square describing the gradient which will be mapped onto the paint box.
        ///
        /// For example, an alignment of (0.0, 0.0) will place the radial
        /// gradient in the center of the box.
        ///
        /// If this is an [Alignment], then it is expressed as a vector from
        /// coordinate (0.0, 0.0), in a coordinate space that maps the center of the
        /// paint box at (0.0, 0.0) and the bottom right at (1.0, 1.0).
        ///
        /// It can also be an [AlignmentDirectional], where the start is the left in
        /// left-to-right contexts and the right in right-to-left contexts. If a
        /// text-direction-dependent value is provided here, then the [createShader]
        /// method will need to be given a [TextDirection].
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Center { get; set; }
        /// <Summary>
        /// The radius of the gradient, as a fraction of the shortest side
        /// of the paint box.
        ///
        /// For example, if a radial gradient is painted on a box that is
        /// 100.0 pixels wide and 200.0 pixels tall, then a radius of 1.0
        /// will place the 1.0 stop at 100.0 pixels from the [center].
        /// </Summary>
        public virtual double Radius { get; set; }
        /// <Summary>
        /// How this gradient should tile the plane beyond the outer ring at [radius]
        /// pixels from the [center].
        ///
        /// For details, see [TileMode].
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_radial.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_radial.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_radial.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_radialWithFocal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_radialWithFocal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_radialWithFocal.png)
        /// </Summary>
        public virtual TileMode TileMode { get; set; }
        /// <Summary>
        /// The focal point of the gradient.  If specified, the gradient will appear
        /// to be focused along the vector from [center] to focal.
        ///
        /// See [center] for a description of how the coordinates are mapped.
        ///
        /// If this value is specified and [focalRadius] > 0.0, care should be taken
        /// to ensure that either this value or [center] will not both resolve to
        /// [Offset.zero], which would fail to create a valid gradient.
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Focal { get; set; }
        /// <Summary>
        /// The radius of the focal point of gradient, as a fraction of the shortest
        /// side of the paint box.
        ///
        /// For example, if a radial gradient is painted on a box that is
        /// 100.0 pixels wide and 200.0 pixels tall, then a radius of 1.0
        /// will place the 1.0 stop at 100.0 pixels from the [focus].
        ///
        /// If this value is specified and is greater than 0.0, either [focal] or
        /// [center] must not resolve to [Offset.zero], which would fail to create
        /// a valid gradient.
        /// </Summary>
        public virtual double FocalRadius { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return Dart.UI.Gradient.Radial(Center.Resolve(textDirection).WithinRect(rect), Radius * rect.ShortestSide, Colors, _ImpliedStops(), TileMode, _ResolveTransform(rect, textDirection), Focal == null ? null : Focal.Resolve(textDirection).WithinRect(rect), FocalRadius * rect.ShortestSide);
        }




        /// <Summary>
        /// Returns a new [RadialGradient] with its colors scaled by the given factor.
        ///
        /// Since the alpha component of the Color is what is scaled, a factor
        /// of 0.0 or less results in a gradient that is fully transparent.
        /// </Summary>
        public new FlutterSDK.Painting.Gradient.RadialGradient Scale(double factor)
        {
            return new RadialGradient(center: Center, radius: Radius, colors: Colors.Map((Color color) => =>Dart.UI.UiDefaultClass.Color.Lerp(null, color, factor)).ToList(), stops: Stops, tileMode: TileMode, focal: Focal, focalRadius: FocalRadius);
        }




        public new FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t)
        {
            if (a == null || (a is RadialGradient)) return GradientDefaultClass.RadialGradient.Lerp(a as RadialGradient, this, t);
            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t)
        {
            if (b == null || (b is RadialGradient)) return GradientDefaultClass.RadialGradient.Lerp(this, b as RadialGradient, t);
            return base.LerpTo(b, t);
        }




        /// <Summary>
        /// Linearly interpolate between two [RadialGradient]s.
        ///
        /// If either gradient is null, this function linearly interpolates from a
        /// a gradient that matches the other gradient in [center], [radius], [stops] and
        /// [tileMode] and with the same [colors] but transparent (using [scale]).
        ///
        /// If neither gradient is null, they must have the same number of [colors].
        ///
        /// The `t` argument represents a position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `a` (or something
        /// equivalent to `a`), 1.0 meaning that the interpolation has finished,
        /// returning `b` (or something equivalent to `b`), and values in between
        /// meaning that the interpolation is at the relevant point on the timeline
        /// between `a` and `b`. The interpolation can be extrapolated beyond 0.0 and
        /// 1.0, so negative values and values greater than 1.0 are valid (and can
        /// easily be generated by curves such as [Curves.elasticInOut]).
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.RadialGradient Lerp(FlutterSDK.Painting.Gradient.RadialGradient a, FlutterSDK.Painting.Gradient.RadialGradient b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b.Scale(t);
            if (b == null) return a.Scale(1.0 - t);
            _ColorsAndStops interpolated = GradientDefaultClass._InterpolateColorsAndStops(a.Colors, a._ImpliedStops(), b.Colors, b._ImpliedStops(), t);
            return new RadialGradient(center: AlignmentDefaultClass.AlignmentGeometry.Lerp(a.Center, b.Center, t), radius: Dart.Math.MathDefaultClass.Max(0.0, Dart.UI.UiDefaultClass.LerpDouble(a.Radius, b.Radius, t)), colors: interpolated.Colors, stops: interpolated.Stops, tileMode: t < 0.5 ? a.TileMode : b.TileMode, focal: AlignmentDefaultClass.AlignmentGeometry.Lerp(a.Focal, b.Focal, t), focalRadius: Dart.Math.MathDefaultClass.Max(0.0, Dart.UI.UiDefaultClass.LerpDouble(a.FocalRadius, b.FocalRadius, t)));
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is RadialGradient && other.Center == Center && other.Radius == Radius && other.TileMode == TileMode && CollectionsDefaultClass.ListEquals(other.Colors, Colors) && CollectionsDefaultClass.ListEquals(other.Stops, Stops) && other.Focal == Focal && other.FocalRadius == FocalRadius;
        }




    }


    /// <Summary>
    /// A 2D sweep gradient.
    ///
    /// This class is used by [BoxDecoration] to represent sweep gradients. This
    /// abstracts out the arguments to the [new ui.Gradient.sweep] constructor from
    /// the `dart:ui` library.
    ///
    /// A gradient has a [center], a [startAngle], and an [endAngle]. The [startAngle]
    /// corresponds to 0.0, and the [endAngle] corresponds to 1.0. These angles are
    /// expressed in radians.
    ///
    /// The [colors] are described by a list of [Color] objects. There must be at
    /// least two colors. The [stops] list, if specified, must have the same length
    /// as [colors]. It specifies fractions of the vector from start to end, between
    /// 0.0 and 1.0, for each color. If it is null, a uniform distribution is
    /// assumed.
    ///
    /// The region of the canvas before [startAngle] and after [endAngle] is colored
    /// according to [tileMode].
    ///
    /// Typically this class is used with [BoxDecoration], which does the painting.
    /// To use a [SweepGradient] to paint on a canvas directly, see [createShader].
    ///
    /// {@tool snippet}
    ///
    /// This sample draws a different color in each quadrant.
    ///
    /// ```dart
    /// Container(
    ///   decoration: BoxDecoration(
    ///     gradient: SweepGradient(
    ///       center: FractionalOffset.center,
    ///       startAngle: 0.0,
    ///       endAngle: math.pi * 2,
    ///       colors: const <Color>[
    ///         Color(0xFF4285F4), // blue
    ///         Color(0xFF34A853), // green
    ///         Color(0xFFFBBC05), // yellow
    ///         Color(0xFFEA4335), // red
    ///         Color(0xFF4285F4), // blue again to seamlessly transition to the start
    ///       ],
    ///       stops: const <double>[0.0, 0.25, 0.5, 0.75, 1.0],
    ///     ),
    ///   )
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    ///
    /// This sample takes the above gradient and rotates it by `math.pi/4` radians,
    /// i.e. 45 degrees.
    ///
    /// ```dart
    /// Container(
    ///   decoration: BoxDecoration(
    ///     gradient: SweepGradient(
    ///       center: FractionalOffset.center,
    ///       startAngle: 0.0,
    ///       endAngle: math.pi * 2,
    ///       colors: const <Color>[
    ///         Color(0xFF4285F4), // blue
    ///         Color(0xFF34A853), // green
    ///         Color(0xFFFBBC05), // yellow
    ///         Color(0xFFEA4335), // red
    ///         Color(0xFF4285F4), // blue again to seamlessly transition to the start
    ///       ],
    ///       stops: const <double>[0.0, 0.25, 0.5, 0.75, 1.0],
    ///       transform: GradientRotation(math.pi/4),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [LinearGradient], which displays a gradient in parallel lines, and has an
    ///    example which shows a different way to use [Gradient] objects.
    ///  * [RadialGradient], which displays a gradient in concentric circles, and
    ///    has an example which shows a different way to use [Gradient] objects.
    ///  * [BoxDecoration], which can take a [SweepGradient] in its
    ///    [BoxDecoration.gradient] property.
    /// </Summary>
    public class SweepGradient : FlutterSDK.Painting.Gradient.Gradient
    {
        /// <Summary>
        /// Creates a sweep gradient.
        ///
        /// The [colors] argument must not be null. If [stops] is non-null, it must
        /// have the same length as [colors].
        /// </Summary>
        public SweepGradient(FlutterSDK.Painting.Alignment.AlignmentGeometry center = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double startAngle = 0.0, double endAngle = default(double), List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), TileMode tileMode = default(TileMode), FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base(colors: colors, stops: stops, transform: transform)
        {
            this.Center = center;
            this.StartAngle = startAngle;
            this.EndAngle = endAngle;
            this.TileMode = tileMode;
        }
        /// <Summary>
        /// The center of the gradient, as an offset into the (-1.0, -1.0) x (1.0, 1.0)
        /// square describing the gradient which will be mapped onto the paint box.
        ///
        /// For example, an alignment of (0.0, 0.0) will place the sweep
        /// gradient in the center of the box.
        ///
        /// If this is an [Alignment], then it is expressed as a vector from
        /// coordinate (0.0, 0.0), in a coordinate space that maps the center of the
        /// paint box at (0.0, 0.0) and the bottom right at (1.0, 1.0).
        ///
        /// It can also be an [AlignmentDirectional], where the start is the left in
        /// left-to-right contexts and the right in right-to-left contexts. If a
        /// text-direction-dependent value is provided here, then the [createShader]
        /// method will need to be given a [TextDirection].
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Center { get; set; }
        /// <Summary>
        /// The angle in radians at which stop 0.0 of the gradient is placed.
        ///
        /// Defaults to 0.0.
        /// </Summary>
        public virtual double StartAngle { get; set; }
        /// <Summary>
        /// The angle in radians at which stop 1.0 of the gradient is placed.
        ///
        /// Defaults to math.pi * 2.
        /// </Summary>
        public virtual double EndAngle { get; set; }
        /// <Summary>
        /// How this gradient should tile the plane beyond in the region before
        /// [startAngle] and after [endAngle].
        ///
        /// For details, see [TileMode].
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_sweep.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_sweep.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_sweep.png)
        /// </Summary>
        public virtual TileMode TileMode { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return Dart.UI.Gradient.Sweep(Center.Resolve(textDirection).WithinRect(rect), Colors, _ImpliedStops(), TileMode, StartAngle, EndAngle, _ResolveTransform(rect, textDirection));
        }




        /// <Summary>
        /// Returns a new [SweepGradient] with its colors scaled by the given factor.
        ///
        /// Since the alpha component of the Color is what is scaled, a factor
        /// of 0.0 or less results in a gradient that is fully transparent.
        /// </Summary>
        public new FlutterSDK.Painting.Gradient.SweepGradient Scale(double factor)
        {
            return new SweepGradient(center: Center, startAngle: StartAngle, endAngle: EndAngle, colors: Colors.Map((Color color) => =>Dart.UI.UiDefaultClass.Color.Lerp(null, color, factor)).ToList(), stops: Stops, tileMode: TileMode);
        }




        public new FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t)
        {
            if (a == null || (a is SweepGradient)) return GradientDefaultClass.SweepGradient.Lerp(a as SweepGradient, this, t);
            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t)
        {
            if (b == null || (b is SweepGradient)) return GradientDefaultClass.SweepGradient.Lerp(this, b as SweepGradient, t);
            return base.LerpTo(b, t);
        }




        /// <Summary>
        /// Linearly interpolate between two [SweepGradient]s.
        ///
        /// If either gradient is null, then the non-null gradient is returned with
        /// its color scaled in the same way as the [scale] function.
        ///
        /// If neither gradient is null, they must have the same number of [colors].
        ///
        /// The `t` argument represents a position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `a` (or something
        /// equivalent to `a`), 1.0 meaning that the interpolation has finished,
        /// returning `b` (or something equivalent to `b`), and values in between
        /// meaning that the interpolation is at the relevant point on the timeline
        /// between `a` and `b`. The interpolation can be extrapolated beyond 0.0 and
        /// 1.0, so negative values and values greater than 1.0 are valid (and can
        /// easily be generated by curves such as [Curves.elasticInOut]).
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        /// </Summary>
        public virtual FlutterSDK.Painting.Gradient.SweepGradient Lerp(FlutterSDK.Painting.Gradient.SweepGradient a, FlutterSDK.Painting.Gradient.SweepGradient b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b.Scale(t);
            if (b == null) return a.Scale(1.0 - t);
            _ColorsAndStops interpolated = GradientDefaultClass._InterpolateColorsAndStops(a.Colors, a._ImpliedStops(), b.Colors, b._ImpliedStops(), t);
            return new SweepGradient(center: AlignmentDefaultClass.AlignmentGeometry.Lerp(a.Center, b.Center, t), startAngle: Dart.Math.MathDefaultClass.Max(0.0, Dart.UI.UiDefaultClass.LerpDouble(a.StartAngle, b.StartAngle, t)), endAngle: Dart.Math.MathDefaultClass.Max(0.0, Dart.UI.UiDefaultClass.LerpDouble(a.EndAngle, b.EndAngle, t)), colors: interpolated.Colors, stops: interpolated.Stops, tileMode: t < 0.5 ? a.TileMode : b.TileMode);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is SweepGradient && other.Center == Center && other.StartAngle == StartAngle && other.EndAngle == EndAngle && other.TileMode == TileMode && CollectionsDefaultClass.ListEquals(other.Colors, Colors) && CollectionsDefaultClass.ListEquals(other.Stops, Stops);
        }




    }

}
