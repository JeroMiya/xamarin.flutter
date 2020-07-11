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
namespace FlutterSDK.Painting.Gradient
{
    internal static class GradientDefaultClass
    {
        internal static Color _Sample(List<Color> colors, List<double> stops, double t)
        {
            throw new NotImplementedException();
        }

        internal static FlutterSDK.Painting.Gradient._ColorsAndStops _InterpolateColorsAndStops(List<Color> aColors, List<double> aStops, List<Color> bColors, List<double> bStops, double t)
        {
            throw new NotImplementedException();
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
        #region constructors
        public _ColorsAndStops(List<Color> colors, List<double> stops)
        {
            this.Colors = colors;
            this.Stops = stops; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<Color> Colors { get; set; }
        public virtual List<double> Stops { get; set; }
        #endregion

        #region methods
        #endregion
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
        #region constructors
        public GradientTransform()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// When a [Gradient] creates its [Shader], it will call this method to
        /// determine what transform to apply to the shader for the given [Rect] and
        /// [TextDirection].
        ///
        /// Implementers may return null from this method, which achieves the same
        /// final effect as returning [Matrix4.identity].
        /// </Summary>
        public virtual Matrix4 Transform(FlutterBinding.UI.Rect bounds, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public GradientRotation(double radians)
        {
            this.Radians = radians; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Radians { get; set; }
        #endregion

        #region methods

        public new Matrix4 Transform(FlutterBinding.UI.Rect bounds, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public Gradient(List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base()
        {
            this.Colors = colors;
            this.Stops = stops;
            this.Transform = transform; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<Color> Colors { get; set; }
        public virtual List<double> Stops { get; set; }
        public virtual FlutterSDK.Painting.Gradient.GradientTransform Transform { get; set; }
        #endregion

        #region methods

        private List<double> _ImpliedStops() { throw new NotImplementedException(); }


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
        public virtual SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.Gradient Scale(double factor) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.Gradient Lerp(FlutterSDK.Painting.Gradient.Gradient a, FlutterSDK.Painting.Gradient.Gradient b, double t) { throw new NotImplementedException(); }


        private List<float> _ResolveTransform(FlutterBinding.UI.Rect bounds, TextDirection textDirection) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public LinearGradient(FlutterSDK.Painting.Alignment.AlignmentGeometry begin = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Alignment.AlignmentGeometry end = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), TileMode tileMode = default(TileMode), FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base(colors: colors, stops: stops, transform: transform)
        {
            this.Begin = begin;
            this.End = end;
            this.TileMode = tileMode; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Begin { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry End { get; set; }
        public virtual TileMode TileMode { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a new [LinearGradient] with its colors scaled by the given factor.
        ///
        /// Since the alpha component of the Color is what is scaled, a factor
        /// of 0.0 or less results in a gradient that is fully transparent.
        /// </Summary>
        public new FlutterSDK.Painting.Gradient.LinearGradient Scale(double factor) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.LinearGradient Lerp(FlutterSDK.Painting.Gradient.LinearGradient a, FlutterSDK.Painting.Gradient.LinearGradient b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
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
        #region constructors
        public RadialGradient(FlutterSDK.Painting.Alignment.AlignmentGeometry center = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double radius = 0.5, List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), TileMode tileMode = default(TileMode), FlutterSDK.Painting.Alignment.AlignmentGeometry focal = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double focalRadius = 0.0, FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base(colors: colors, stops: stops, transform: transform)
        {
            this.Center = center;
            this.Radius = radius;
            this.TileMode = tileMode;
            this.Focal = focal;
            this.FocalRadius = focalRadius; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Center { get; set; }
        public virtual double Radius { get; set; }
        public virtual TileMode TileMode { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Focal { get; set; }
        public virtual double FocalRadius { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a new [RadialGradient] with its colors scaled by the given factor.
        ///
        /// Since the alpha component of the Color is what is scaled, a factor
        /// of 0.0 or less results in a gradient that is fully transparent.
        /// </Summary>
        public new FlutterSDK.Painting.Gradient.RadialGradient Scale(double factor) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.RadialGradient Lerp(FlutterSDK.Painting.Gradient.RadialGradient a, FlutterSDK.Painting.Gradient.RadialGradient b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
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
        #region constructors
        public SweepGradient(FlutterSDK.Painting.Alignment.AlignmentGeometry center = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double startAngle = 0.0, double endAngle = default(double), List<Color> colors = default(List<Color>), List<double> stops = default(List<double>), TileMode tileMode = default(TileMode), FlutterSDK.Painting.Gradient.GradientTransform transform = default(FlutterSDK.Painting.Gradient.GradientTransform))
        : base(colors: colors, stops: stops, transform: transform)
        {
            this.Center = center;
            this.StartAngle = startAngle;
            this.EndAngle = endAngle;
            this.TileMode = tileMode; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Center { get; set; }
        public virtual double StartAngle { get; set; }
        public virtual double EndAngle { get; set; }
        public virtual TileMode TileMode { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new SKShader CreateShader(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns a new [SweepGradient] with its colors scaled by the given factor.
        ///
        /// Since the alpha component of the Color is what is scaled, a factor
        /// of 0.0 or less results in a gradient that is fully transparent.
        /// </Summary>
        public new FlutterSDK.Painting.Gradient.SweepGradient Scale(double factor) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Gradient.Gradient LerpFrom(FlutterSDK.Painting.Gradient.Gradient a, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Gradient.Gradient LerpTo(FlutterSDK.Painting.Gradient.Gradient b, double t) { throw new NotImplementedException(); }


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
        public virtual FlutterSDK.Painting.Gradient.SweepGradient Lerp(FlutterSDK.Painting.Gradient.SweepGradient a, FlutterSDK.Painting.Gradient.SweepGradient b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }

}
