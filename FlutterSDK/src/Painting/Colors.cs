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
namespace FlutterSDK.Painting.Colors
{
    internal static class ColorsDefaultClass
    {
        internal static double _GetHue(double red, double green, double blue, double max, double delta)
        {
            throw new NotImplementedException();
        }

        internal static Color _ColorFromHue(double alpha, double hue, double chroma, double secondary, double match)
        {
            throw new NotImplementedException();
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
        #region constructors
        public static HSVColor FromAHSV(double alpha, double hue, double saturation, double value)
        {
            var instance = new HSVColor(); instance.Alpha = alpha;
            instance.Hue = hue;
            instance.Saturation = saturation;
            instance.Value = value;
        }
        public static HSVColor FromColor(FlutterBinding.UI.Color color)
        {
            var instance = new HSVColor();
            double red = color.Red / 0xFF;
            double green = color.Green / 0xFF;
            double blue = color.Blue / 0xFF;
            double max = Math.Dart:mathDefaultClass.Max(red, Math.Dart:mathDefaultClass.Max(green, blue));
            double min = Math.Dart:mathDefaultClass.Min(red, Math.Dart:mathDefaultClass.Min(green, blue));
            double delta = max - min;
            double alpha = color.Alpha / 0xFF;
            double hue = ColorsDefaultClass._GetHue(red, green, blue, max, delta);
            double saturation = max == 0.0 ? 0.0 : delta / max;
            return HSVColor.FromAHSV(alpha, hue, saturation, max);
        }


        #endregion

        #region fields
        public virtual double Alpha { get; set; }
        public virtual double Hue { get; set; }
        public virtual double Saturation { get; set; }
        public virtual double Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

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
            return HSVColor.FromAHSV(Dart: uiDefaultClass.LerpDouble(a.Alpha, b.Alpha, t).Clamp(0.0, 1.0) as double, Dart: uiDefaultClass.LerpDouble(a.Hue, b.Hue, t) % 360.0, Dart: uiDefaultClass.LerpDouble(a.Saturation, b.Saturation, t).Clamp(0.0, 1.0) as double, Dart: uiDefaultClass.LerpDouble(a.Value, b.Value, t).Clamp(0.0, 1.0) as double);
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            return other is HSVColor && other.Alpha == Alpha && other.Hue == Hue && other.Saturation == Saturation && other.Value == Value;
        }




        #endregion
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
        #region constructors
        public static HSLColor FromAHSL(double alpha, double hue, double saturation, double lightness)
        {
            var instance = new HSLColor(); instance.Alpha = alpha;
            instance.Hue = hue;
            instance.Saturation = saturation;
            instance.Lightness = lightness;
        }
        public static HSLColor FromColor(FlutterBinding.UI.Color color)
        {
            var instance = new HSLColor();
            double red = color.Red / 0xFF;
            double green = color.Green / 0xFF;
            double blue = color.Blue / 0xFF;
            double max = Math.Dart:mathDefaultClass.Max(red, Math.Dart:mathDefaultClass.Max(green, blue));
            double min = Math.Dart:mathDefaultClass.Min(red, Math.Dart:mathDefaultClass.Min(green, blue));
            double delta = max - min;
            double alpha = color.Alpha / 0xFF;
            double hue = ColorsDefaultClass._GetHue(red, green, blue, max, delta);
            double lightness = (max + min) / 2.0;
            double saturation = lightness == 1.0 ? 0.0 : ((delta / (1.0 - (2.0 * lightness - 1.0).Abs())).Clamp(0.0, 1.0) as double);
            return HSLColor.FromAHSL(alpha, hue, saturation, lightness);
        }


        #endregion

        #region fields
        public virtual double Alpha { get; set; }
        public virtual double Hue { get; set; }
        public virtual double Saturation { get; set; }
        public virtual double Lightness { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

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
            return HSLColor.FromAHSL(Dart: uiDefaultClass.LerpDouble(a.Alpha, b.Alpha, t).Clamp(0.0, 1.0) as double, Dart: uiDefaultClass.LerpDouble(a.Hue, b.Hue, t) % 360.0, Dart: uiDefaultClass.LerpDouble(a.Saturation, b.Saturation, t).Clamp(0.0, 1.0) as double, Dart: uiDefaultClass.LerpDouble(a.Lightness, b.Lightness, t).Clamp(0.0, 1.0) as double);
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            return other is HSLColor && other.Alpha == Alpha && other.Hue == Hue && other.Saturation == Saturation && other.Lightness == Lightness;
        }




        #endregion
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
        #region constructors
        public ColorSwatch(int primary, Dictionary<T, Color> _swatch)
        : base(primary)
        {
            this._Swatch = _swatch;
        }
        #endregion

        #region fields
        internal virtual Dictionary<T, Color> _Swatch { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Returns an element of the swatch table.
        /// </Summary>
        public virtual Color IndexOfOperator(T index) => _Swatch[index];



        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            return base == other && other is ColorSwatch<T> && other._Swatch == _Swatch;
        }




        #endregion
    }


    /// <Summary>
    /// [DiagnosticsProperty] that has an [Color] as value.
    /// </Summary>
    public class ColorProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Color>
    {
        #region constructors
        public ColorProperty(string name, FlutterBinding.UI.Color value, bool showName = true, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, defaultValue: defaultValue, showName: showName, style: style, level: level)
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
        {
            Dictionary<string, object> json = base.ToJsonMap(delegate);
            if (Value != null)
            {
                json["valueProperties"] = new Dictionary<string, object> { { "red", Value.Red }{ "green", Value.Green }{ "blue", Value.Blue }{ "alpha", Value.Alpha } };
            }

            return json;
        }



        #endregion
    }

}
