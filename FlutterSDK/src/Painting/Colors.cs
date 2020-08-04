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
namespace FlutterSDK.Painting.Colors
{
    internal static class ColorsDefaultClass
    {
        internal static double _GetHue(double red, double green, double blue, double max, double delta)
        {
            double hue = default(double);
            if (max == 0.0)
            {
                hue = 0.0;
            }
            else if (max == red)
            {
                hue = 60.0 * (((green - blue) / delta) % 6);
            }
            else if (max == green)
            {
                hue = 60.0 * (((blue - red) / delta) + 2);
            }
            else if (max == blue)
            {
                hue = 60.0 * (((red - green) / delta) + 4);
            }

            hue = hue.IsNaN ? 0.0 : hue;
            return hue;
        }



        internal static Color _ColorFromHue(double alpha, double hue, double chroma, double secondary, double match)
        {
            double red = default(double);
            double green = default(double);
            double blue = default(double);
            if (hue < 60.0)
            {
                red = chroma;
                green = secondary;
                blue = 0.0;
            }
            else if (hue < 120.0)
            {
                red = secondary;
                green = chroma;
                blue = 0.0;
            }
            else if (hue < 180.0)
            {
                red = 0.0;
                green = chroma;
                blue = secondary;
            }
            else if (hue < 240.0)
            {
                red = 0.0;
                green = secondary;
                blue = chroma;
            }
            else if (hue < 300.0)
            {
                red = secondary;
                green = 0.0;
                blue = chroma;
            }
            else
            {
                red = chroma;
                green = 0.0;
                blue = secondary;
            }

            return Color.FromARGB((alpha * 0xFF).Round(), ((red + match) * 0xFF).Round(), ((green + match) * 0xFF).Round(), ((blue + match) * 0xFF).Round());
        }



    }

    /// <Summary>
    /// A color represented using [alpha], [hue], [saturation], and [value].
    ///
    /// An [HSVColor] is represented in a parameter space that's based on human
    /// perception of color in pigments (e.g. paint and printer's ink). The
    /// representation is useful for some color computations (e.g. rotating the hue
    /// through the colors), because interpolation and picking of
    /// colors as red, green, and blue channels doesn't always produce intuitive
    /// results.
    ///
    /// The HSV color space models the way that different pigments are perceived
    /// when mixed. The hue describes which pigment is used, the saturation
    /// describes which shade of the pigment, and the value resembles mixing the
    /// pigment with different amounts of black or white pigment.
    ///
    /// See also:
    ///
    ///  * [HSLColor], a color that uses a color space based on human perception of
    ///    colored light.
    ///  * [HSV and HSL](https://en.wikipedia.org/wiki/HSL_and_HSV) Wikipedia
    ///    article, which this implementation is based upon.
    /// </Summary>
    public class HSVColor
    {
        /// <Summary>
        /// Creates a color.
        ///
        /// All the arguments must not be null and be in their respective ranges. See
        /// the fields for each parameter for a description of their ranges.
        /// </Summary>
        public static HSVColor FromAHSV(double alpha, double hue, double saturation, double value)
        => new HSVColor(alpha, hue, saturation, value);

        private HSVColor(double alpha, double hue, double saturation, double value)
        : base()
        {
            this.Alpha = alpha;
            this.Hue = hue;
            this.Saturation = saturation;
            this.Value = value;
        }
        /// <Summary>
        /// Creates an [HSVColor] from an RGB [Color].
        ///
        /// This constructor does not necessarily round-trip with [toColor] because
        /// of floating point imprecision.
        /// </Summary>
        public static HSVColor FromColor(FlutterBinding.UI.Color color)
        {

            double red = color.Red / 0xFF;
            double green = color.Green / 0xFF;
            double blue = color.Blue / 0xFF;
            double max = Dart.Math.MathDefaultClass.Max(red, Dart.Math.MathDefaultClass.Max(green, blue));
            double min = Dart.Math.MathDefaultClass.Min(red, Dart.Math.MathDefaultClass.Min(green, blue));
            double delta = max - min;
            double alpha = color.Alpha / 0xFF;
            double hue = ColorsDefaultClass._GetHue(red, green, blue, max, delta);
            double saturation = max == 0.0 ? 0.0 : delta / max;
            return HSVColor.FromAHSV(alpha, hue, saturation, max);
        }


        /// <Summary>
        /// Alpha, from 0.0 to 1.0. The describes the transparency of the color.
        /// A value of 0.0 is fully transparent, and 1.0 is fully opaque.
        /// </Summary>
        public virtual double Alpha { get; set; }
        /// <Summary>
        /// Hue, from 0.0 to 360.0. Describes which color of the spectrum is
        /// represented. A value of 0.0 represents red, as does 360.0. Values in
        /// between go through all the hues representable in RGB. You can think of
        /// this as selecting which pigment will be added to a color.
        /// </Summary>
        public virtual double Hue { get; set; }
        /// <Summary>
        /// Saturation, from 0.0 to 1.0. This describes how colorful the color is.
        /// 0.0 implies a shade of grey (i.e. no pigment), and 1.0 implies a color as
        /// vibrant as that hue gets. You can think of this as the equivalent of
        /// how much of a pigment is added.
        /// </Summary>
        public virtual double Saturation { get; set; }
        /// <Summary>
        /// Value, from 0.0 to 1.0. The "value" of a color that, in this context,
        /// describes how bright a color is. A value of 0.0 indicates black, and 1.0
        /// indicates full intensity color. You can think of this as the equivalent of
        /// removing black from the color as value increases.
        /// </Summary>
        public virtual double Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a copy of this color with the [alpha] parameter replaced with the
        /// given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSVColor WithAlpha(double alpha)
        {
            return HSVColor.FromAHSV(alpha, Hue, Saturation, Value);
        }




        /// <Summary>
        /// Returns a copy of this color with the [hue] parameter replaced with the
        /// given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSVColor WithHue(double hue)
        {
            return HSVColor.FromAHSV(Alpha, hue, Saturation, Value);
        }




        /// <Summary>
        /// Returns a copy of this color with the [saturation] parameter replaced with
        /// the given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSVColor WithSaturation(double saturation)
        {
            return HSVColor.FromAHSV(Alpha, Hue, saturation, Value);
        }




        /// <Summary>
        /// Returns a copy of this color with the [value] parameter replaced with the
        /// given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSVColor WithValue(double value)
        {
            return HSVColor.FromAHSV(Alpha, Hue, Saturation, value);
        }




        /// <Summary>
        /// Returns this color in RGB.
        /// </Summary>
        public virtual Color ToColor()
        {
            double chroma = Saturation * Value;
            double secondary = chroma * (1.0 - (((Hue / 60.0) % 2.0) - 1.0).Abs());
            double match = Value - chroma;
            return ColorsDefaultClass._ColorFromHue(Alpha, Hue, chroma, secondary, match);
        }




        private FlutterSDK.Painting.Colors.HSVColor _ScaleAlpha(double factor)
        {
            return WithAlpha(Alpha * factor);
        }




        /// <Summary>
        /// Linearly interpolate between two HSVColors.
        ///
        /// The colors are interpolated by interpolating the [alpha], [hue],
        /// [saturation], and [value] channels separately, which usually leads to a
        /// more pleasing effect than [Color.lerp] (which interpolates the red, green,
        /// and blue channels separately).
        ///
        /// If either color is null, this function linearly interpolates from a
        /// transparent instance of the other color. This is usually preferable to
        /// interpolating from [Colors.transparent] (`const Color(0x00000000)`) since
        /// that will interpolate from a transparent red and cycle through the hues to
        /// match the target color, regardless of what that color's hue is.
        ///
        /// {@macro dart.ui.shadow.lerp}
        ///
        /// Values outside of the valid range for each channel will be clamped.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSVColor Lerp(FlutterSDK.Painting.Colors.HSVColor a, FlutterSDK.Painting.Colors.HSVColor b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b._ScaleAlpha(t);
            if (b == null) return a._ScaleAlpha(1.0 - t);
            return HSVColor.FromAHSV(Dart.UI.UiDefaultClass.LerpDouble(a.Alpha, b.Alpha, t).Clamp(0.0, 1.0) as double, Dart.UI.UiDefaultClass.LerpDouble(a.Hue, b.Hue, t) % 360.0, Dart.UI.UiDefaultClass.LerpDouble(a.Saturation, b.Saturation, t).Clamp(0.0, 1.0) as double, Dart.UI.UiDefaultClass.LerpDouble(a.Value, b.Value, t).Clamp(0.0, 1.0) as double);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            return other is HSVColor && other.Alpha == Alpha && other.Hue == Hue && other.Saturation == Saturation && other.Value == Value;
        }




    }


    /// <Summary>
    /// A color represented using [alpha], [hue], [saturation], and [lightness].
    ///
    /// An [HSLColor] is represented in a parameter space that's based up human
    /// perception of colored light. The representation is useful for some color
    /// computations (e.g., combining colors of light), because interpolation and
    /// picking of colors as red, green, and blue channels doesn't always produce
    /// intuitive results.
    ///
    /// HSL is a perceptual color model, placing fully saturated colors around a
    /// circle (conceptually) at a lightness of ​0.5, with a lightness of 0.0 being
    /// completely black, and a lightness of 1.0 being completely white. As the
    /// lightness increases or decreases from 0.5, the apparent saturation decreases
    /// proportionally (even though the [saturation] parameter hasn't changed).
    ///
    /// See also:
    ///
    ///  * [HSVColor], a color that uses a color space based on human perception of
    ///    pigments (e.g. paint and printer's ink).
    ///  * [HSV and HSL](https://en.wikipedia.org/wiki/HSL_and_HSV) Wikipedia
    ///    article, which this implementation is based upon.
    /// </Summary>
    public class HSLColor
    {
        /// <Summary>
        /// Creates a color.
        ///
        /// All the arguments must not be null and be in their respective ranges. See
        /// the fields for each parameter for a description of their ranges.
        /// </Summary>
        public static HSLColor FromAHSL(double alpha, double hue, double saturation, double lightness)
        => new HSLColor(alpha, hue, saturation, lightness);

        private HSLColor(double alpha, double hue, double saturation, double lightness)
        : base()
        {
            this.Alpha = alpha;
            this.Hue = hue;
            this.Saturation = saturation;
            this.Lightness = lightness;
        }
        /// <Summary>
        /// Creates an [HSLColor] from an RGB [Color].
        ///
        /// This constructor does not necessarily round-trip with [toColor] because
        /// of floating point imprecision.
        /// </Summary>
        public static HSLColor FromColor(FlutterBinding.UI.Color color)
        {

            double red = color.Red / 0xFF;
            double green = color.Green / 0xFF;
            double blue = color.Blue / 0xFF;
            double max = Dart.Math.MathDefaultClass.Max(red, Dart.Math.MathDefaultClass.Max(green, blue));
            double min = Dart.Math.MathDefaultClass.Min(red, Dart.Math.MathDefaultClass.Min(green, blue));
            double delta = max - min;
            double alpha = color.Alpha / 0xFF;
            double hue = ColorsDefaultClass._GetHue(red, green, blue, max, delta);
            double lightness = (max + min) / 2.0;
            double saturation = lightness == 1.0 ? 0.0 : ((delta / (1.0 - (2.0 * lightness - 1.0).Abs())).Clamp(0.0, 1.0) as double);
            return HSLColor.FromAHSL(alpha, hue, saturation, lightness);
        }


        /// <Summary>
        /// Alpha, from 0.0 to 1.0. The describes the transparency of the color.
        /// A value of 0.0 is fully transparent, and 1.0 is fully opaque.
        /// </Summary>
        public virtual double Alpha { get; set; }
        /// <Summary>
        /// Hue, from 0.0 to 360.0. Describes which color of the spectrum is
        /// represented. A value of 0.0 represents red, as does 360.0. Values in
        /// between go through all the hues representable in RGB. You can think of
        /// this as selecting which color filter is placed over a light.
        /// </Summary>
        public virtual double Hue { get; set; }
        /// <Summary>
        /// Saturation, from 0.0 to 1.0. This describes how colorful the color is.
        /// 0.0 implies a shade of grey (i.e. no pigment), and 1.0 implies a color as
        /// vibrant as that hue gets. You can think of this as the purity of the
        /// color filter over the light.
        /// </Summary>
        public virtual double Saturation { get; set; }
        /// <Summary>
        /// Lightness, from 0.0 to 1.0. The lightness of a color describes how bright
        /// a color is. A value of 0.0 indicates black, and 1.0 indicates white. You
        /// can think of this as the intensity of the light behind the filter. As the
        /// lightness approaches 0.5, the colors get brighter and appear more
        /// saturated, and over 0.5, the colors start to become less saturated and
        /// approach white at 1.0.
        /// </Summary>
        public virtual double Lightness { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a copy of this color with the alpha parameter replaced with the
        /// given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSLColor WithAlpha(double alpha)
        {
            return HSLColor.FromAHSL(alpha, Hue, Saturation, Lightness);
        }




        /// <Summary>
        /// Returns a copy of this color with the [hue] parameter replaced with the
        /// given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSLColor WithHue(double hue)
        {
            return HSLColor.FromAHSL(Alpha, hue, Saturation, Lightness);
        }




        /// <Summary>
        /// Returns a copy of this color with the [saturation] parameter replaced with
        /// the given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSLColor WithSaturation(double saturation)
        {
            return HSLColor.FromAHSL(Alpha, Hue, saturation, Lightness);
        }




        /// <Summary>
        /// Returns a copy of this color with the [lightness] parameter replaced with
        /// the given value.
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSLColor WithLightness(double lightness)
        {
            return HSLColor.FromAHSL(Alpha, Hue, Saturation, lightness);
        }




        /// <Summary>
        /// Returns this HSL color in RGB.
        /// </Summary>
        public virtual Color ToColor()
        {
            double chroma = (1.0 - (2.0 * Lightness - 1.0).Abs()) * Saturation;
            double secondary = chroma * (1.0 - (((Hue / 60.0) % 2.0) - 1.0).Abs());
            double match = Lightness - chroma / 2.0;
            return ColorsDefaultClass._ColorFromHue(Alpha, Hue, chroma, secondary, match);
        }




        private FlutterSDK.Painting.Colors.HSLColor _ScaleAlpha(double factor)
        {
            return WithAlpha(Alpha * factor);
        }




        /// <Summary>
        /// Linearly interpolate between two HSLColors.
        ///
        /// The colors are interpolated by interpolating the [alpha], [hue],
        /// [saturation], and [lightness] channels separately, which usually leads to
        /// a more pleasing effect than [Color.lerp] (which interpolates the red,
        /// green, and blue channels separately).
        ///
        /// If either color is null, this function linearly interpolates from a
        /// transparent instance of the other color. This is usually preferable to
        /// interpolating from [Colors.transparent] (`const Color(0x00000000)`) since
        /// that will interpolate from a transparent red and cycle through the hues to
        /// match the target color, regardless of what that color's hue is.
        ///
        /// The `t` argument represents position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `a` (or something
        /// equivalent to `a`), 1.0 meaning that the interpolation has finished,
        /// returning `b` (or something equivalent to `b`), and values between them
        /// meaning that the interpolation is at the relevant point on the timeline
        /// between `a` and `b`. The interpolation can be extrapolated beyond 0.0 and
        /// 1.0, so negative values and values greater than 1.0 are valid
        /// (and can easily be generated by curves such as [Curves.elasticInOut]).
        ///
        /// Values outside of the valid range for each channel will be clamped.
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        /// </Summary>
        public virtual FlutterSDK.Painting.Colors.HSLColor Lerp(FlutterSDK.Painting.Colors.HSLColor a, FlutterSDK.Painting.Colors.HSLColor b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b._ScaleAlpha(t);
            if (b == null) return a._ScaleAlpha(1.0 - t);
            return HSLColor.FromAHSL(Dart.UI.UiDefaultClass.LerpDouble(a.Alpha, b.Alpha, t).Clamp(0.0, 1.0) as double, Dart.UI.UiDefaultClass.LerpDouble(a.Hue, b.Hue, t) % 360.0, Dart.UI.UiDefaultClass.LerpDouble(a.Saturation, b.Saturation, t).Clamp(0.0, 1.0) as double, Dart.UI.UiDefaultClass.LerpDouble(a.Lightness, b.Lightness, t).Clamp(0.0, 1.0) as double);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            return other is HSLColor && other.Alpha == Alpha && other.Hue == Hue && other.Saturation == Saturation && other.Lightness == Lightness;
        }




    }


    /// <Summary>
    /// A color that has a small table of related colors called a "swatch".
    ///
    /// The table is indexed by values of type `T`.
    ///
    /// See also:
    ///
    ///  * [MaterialColor] and [MaterialAccentColor], which define material design
    ///    primary and accent color swatches.
    ///  * [material.Colors], which defines all of the standard material design
    ///    colors.
    /// </Summary>
    public class ColorSwatch<T> : Color
    {
        /// <Summary>
        /// Creates a color that has a small table of related colors called a "swatch".
        ///
        /// The `primary` argument should be the 32 bit ARGB value of one of the
        /// values in the swatch, as would be passed to the [new Color] constructor
        /// for that same color, and as is exposed by [value]. (This is distinct from
        /// the specific index of the color in the swatch.)
        /// </Summary>
        public ColorSwatch(int primary, Dictionary<T, Color> _swatch)
        : base(primary)
        {
            this._Swatch = _swatch;
        }
        internal virtual Dictionary<T, Color> _Swatch { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns an element of the swatch table.
        /// </Summary>
        public virtual Color IndexOfOperator(T index) => _Swatch[index];



        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return base == other && other is ColorSwatch<T> && other._Swatch == _Swatch;
        }




    }


    /// <Summary>
    /// [DiagnosticsProperty] that has an [Color] as value.
    /// </Summary>
    public class ColorProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Color>
    {
        /// <Summary>
        /// Create a diagnostics property for [Color].
        ///
        /// The [showName], [style], and [level] arguments must not be null.
        /// </Summary>
        public ColorProperty(string name, FlutterBinding.UI.Color value, bool showName = true, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, defaultValue: defaultValue, showName: showName, style: style, level: level)
        {

        }

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
        {
            Dictionary<string, object> json = base.ToJsonMap(delegate);
            if (Value != null)
            {
                json["valueProperties"] = new Dictionary<string, object> { { "red", Value.Red }{ "green", Value.Green }{ "blue", Value.Blue }{ "alpha", Value.Alpha } };
            }

            return json;
        }



    }

}
