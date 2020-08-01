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
namespace FlutterSDK.Material.Colors
{
    internal static class ColorsDefaultClass
    {
    }

    /// <Summary>
    /// Defines a single color as well a color swatch with ten shades of the color.
    ///
    /// The color's shades are referred to by index. The greater the index, the
    /// darker the color. There are 10 valid indices: 50, 100, 200, ..., 900.
    /// The value of this color should the same the value of index 500 and [shade500].
    ///
    /// See also:
    ///
    ///  * [Colors], which defines all of the standard material colors.
    /// </Summary>
    public class MaterialColor : FlutterSDK.Painting.Colors.ColorSwatch<int>
    {
        /// <Summary>
        /// Creates a color swatch with a variety of shades.
        ///
        /// The `primary` argument should be the 32 bit ARGB value of one of the
        /// values in the swatch, as would be passed to the [new Color] constructor
        /// for that same color, and as is exposed by [value]. (This is distinct from
        /// the specific index of the color in the swatch.)
        /// </Summary>
        public MaterialColor(int primary, Dictionary<int, Color> swatch)
        : base(primary, swatch)
        {

        }
        public virtual FlutterBinding.UI.Color Shade50 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade100 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade200 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade300 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade400 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade500 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade600 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade700 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade800 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade900 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// Defines a single accent color as well a swatch of four shades of the
    /// accent color.
    ///
    /// The color's shades are referred to by index, the colors with smaller
    /// indices are lighter, larger indices are darker. There are four valid
    /// indices: 100, 200, 400, and 700. The value of this color should be the
    /// same as the value of index 200 and [shade200].
    ///
    /// See also:
    ///
    ///  * [Colors], which defines all of the standard material colors.
    ///  * <https://material.io/go/design-theming#color-color-schemes>
    /// </Summary>
    public class MaterialAccentColor : FlutterSDK.Painting.Colors.ColorSwatch<int>
    {
        /// <Summary>
        /// Creates a color swatch with a variety of shades appropriate for accent
        /// colors.
        /// </Summary>
        public MaterialAccentColor(int primary, Dictionary<int, Color> swatch)
        : base(primary, swatch)
        {

        }
        public virtual FlutterBinding.UI.Color Shade50 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade100 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade200 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade400 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color Shade700 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// [Color] and [ColorSwatch] constants which represent Material design's
    /// [color palette](https://material.io/design/color/).
    ///
    /// Instead of using an absolute color from these palettes, consider using
    /// [Theme.of] to obtain the local [ThemeData] structure, which exposes the
    /// colors selected for the current theme, such as [ThemeData.primaryColor] and
    /// [ThemeData.accentColor] (among many others).
    ///
    /// Most swatches have colors from 100 to 900 in increments of one hundred, plus
    /// the color 50. The smaller the number, the more pale the color. The greater
    /// the number, the darker the color. The accent swatches (e.g. [redAccent]) only
    /// have the values 100, 200, 400, and 700.
    ///
    /// In addition, a series of blacks and whites with common opacities are
    /// available. For example, [black54] is a pure black with 54% opacity.
    ///
    /// {@tool snippet}
    ///
    /// To select a specific color from one of the swatches, index into the swatch
    /// using an integer for the specific color desired, as follows:
    ///
    /// ```dart
    /// Color selection = Colors.green[400]; // Selects a mid-range green.
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// Each [ColorSwatch] constant is a color and can used directly. For example:
    ///
    /// ```dart
    /// Container(
    ///   color: Colors.blue, // same as Colors.blue[500] or Colors.blue.shade500
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Color palettes
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueGrey.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.brown.png)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.grey.png)
    ///
    /// ## Blacks and whites
    ///
    /// These colors are identified by their transparency. The low transparency
    /// levels (e.g. [Colors.white12] and [Colors.white10]) are very hard to see and
    /// should be avoided in general. They are intended for very subtle effects.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
    ///
    /// The [Colors.transparent] color isn't shown here because it is entirely
    /// invisible!
    /// </Summary>
    public class Colors
    {
        internal Colors()
        {

        }
        /// <Summary>
        /// Completely invisible.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Transparent { get; set; }
        /// <Summary>
        /// Completely opaque black.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// See also:
        ///
        ///  * [black87], [black54], [black45], [black38], [black26], [black12], which
        ///    are variants on this color but with different opacities.
        ///  * [white], a solid white color.
        ///  * [transparent], a fully-transparent color.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black { get; set; }
        /// <Summary>
        /// Black with 87% opacity.
        ///
        /// This is a good contrasting color for text in light themes.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// See also:
        ///
        ///  * [Typography.black], which uses this color for its text styles.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [black], [black54], [black45], [black38], [black26], [black12], which
        ///    are variants on this color but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black87 { get; set; }
        /// <Summary>
        /// Black with 54% opacity.
        ///
        /// This is a color commonly used for headings in light themes. It's also used
        /// as the mask color behind dialogs.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// See also:
        ///
        ///  * [Typography.black], which uses this color for its text styles.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [black], [black87], [black45], [black38], [black26], [black12], which
        ///    are variants on this color but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black54 { get; set; }
        /// <Summary>
        /// Black with 45% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// See also:
        ///
        ///  * [black], [black87], [black54], [black38], [black26], [black12], which
        ///    are variants on this color but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black45 { get; set; }
        /// <Summary>
        /// Black with 38% opacity.
        ///
        /// For light themes, i.e. when the Theme's [ThemeData.brightness] is
        /// [Brightness.light], this color is used for disabled icons and for
        /// placeholder text in [DataTable].
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// See also:
        ///
        ///  * [black], [black87], [black54], [black45], [black26], [black12], which
        ///    are variants on this color but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black38 { get; set; }
        /// <Summary>
        /// Black with 26% opacity.
        ///
        /// Used for disabled radio buttons and the text of disabled flat buttons in light themes.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// See also:
        ///
        ///  * [ThemeData.disabledColor], which uses this color by default in light themes.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [black], [black87], [black54], [black45], [black38], [black12], which
        ///    are variants on this color but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black26 { get; set; }
        /// <Summary>
        /// Black with 12% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blacks.png)
        ///
        /// Used for the background of disabled raised buttons in light themes.
        ///
        /// See also:
        ///
        ///  * [black], [black87], [black54], [black45], [black38], [black26], which
        ///    are variants on this color but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black12 { get; set; }
        /// <Summary>
        /// Completely opaque white.
        ///
        /// This is a good contrasting color for the [ThemeData.primaryColor] in the
        /// dark theme. See [ThemeData.brightness].
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [Typography.white], which uses this color for its text styles.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [white70, white60, white54, white38, white30, white12, white10], which are variants on this color
        ///    but with different opacities.
        ///  * [black], a solid black color.
        ///  * [transparent], a fully-transparent color.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White { get; set; }
        /// <Summary>
        /// White with 70% opacity.
        ///
        /// This is a color commonly used for headings in dark themes.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [Typography.white], which uses this color for its text styles.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [white, white60, white54, white38, white30, white12, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White70 { get; set; }
        /// <Summary>
        /// White with 60% opacity.
        ///
        /// Used for medium-emphasis text and hint text when [Theme.brightness] is
        /// set to [Brightness.dark].
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [ExpandIcon], which uses this color for dark themes.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [white, white54, white30, white38, white12, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White60 { get; set; }
        /// <Summary>
        /// White with 54% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [white, white60, white38, white30, white12, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White54 { get; set; }
        /// <Summary>
        /// White with 38% opacity.
        ///
        /// Used for disabled radio buttons and the text of disabled flat buttons in dark themes.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [ThemeData.disabledColor], which uses this color by default in dark themes.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [white, white60, white54, white70, white30, white12, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White38 { get; set; }
        /// <Summary>
        /// White with 30% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        ///  * [white, white60, white54, white70, white38, white12, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White30 { get; set; }
        /// <Summary>
        /// White with 24% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// Used for the splash color for filled buttons.
        ///
        /// See also:
        ///
        ///  * [white, white60, white54, white70, white38, white30, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White24 { get; set; }
        /// <Summary>
        /// White with 12% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// Used for the background of disabled raised buttons in dark themes.
        ///
        /// See also:
        ///
        ///  * [white, white60, white54, white70, white38, white30, white10], which are variants on this color
        ///    but with different opacities.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White12 { get; set; }
        /// <Summary>
        /// White with 10% opacity.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.whites.png)
        ///
        /// See also:
        ///
        ///  * [white, white60, white54, white70, white38, white30, white12], which are variants on this color
        ///    but with different opacities.
        ///  * [transparent], a fully-transparent color, not far from this one.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White10 { get; set; }
        /// <Summary>
        /// The red primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.red[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [redAccent], the corresponding accent colors.
        ///  * [deepOrange] and [pink], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Red { get; set; }
        internal virtual int _RedPrimaryValue { get; set; }
        /// <Summary>
        /// The red accent swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.redAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [red], the corresponding primary colors.
        ///  * [deepOrangeAccent] and [pinkAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor RedAccent { get; set; }
        internal virtual int _RedAccentValue { get; set; }
        /// <Summary>
        /// The pink primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.pink[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [pinkAccent], the corresponding accent colors.
        ///  * [red] and [purple], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Pink { get; set; }
        internal virtual int _PinkPrimaryValue { get; set; }
        /// <Summary>
        /// The pink accent color swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.pinkAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [pink], the corresponding primary colors.
        ///  * [redAccent] and [purpleAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor PinkAccent { get; set; }
        internal virtual int _PinkAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The purple primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.purple[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [purpleAccent], the corresponding accent colors.
        ///  * [deepPurple] and [pink], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Purple { get; set; }
        internal virtual int _PurplePrimaryValue { get; set; }
        /// <Summary>
        /// The purple accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pink.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.pinkAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.purpleAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [purple], the corresponding primary colors.
        ///  * [deepPurpleAccent] and [pinkAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor PurpleAccent { get; set; }
        internal virtual int _PurpleAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The deep purple primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.deepPurple[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [deepPurpleAccent], the corresponding accent colors.
        ///  * [purple] and [indigo], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor DeepPurple { get; set; }
        internal virtual int _DeepPurplePrimaryValue { get; set; }
        /// <Summary>
        /// The deep purple accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.purpleAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.deepPurpleAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [deepPurple], the corresponding primary colors.
        ///  * [purpleAccent] and [indigoAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor DeepPurpleAccent { get; set; }
        internal virtual int _DeepPurpleAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The indigo primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.indigo[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [indigoAccent], the corresponding accent colors.
        ///  * [blue] and [deepPurple], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Indigo { get; set; }
        internal virtual int _IndigoPrimaryValue { get; set; }
        /// <Summary>
        /// The indigo accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurple.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepPurpleAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.indigoAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [indigo], the corresponding primary colors.
        ///  * [blueAccent] and [deepPurpleAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor IndigoAccent { get; set; }
        internal virtual int _IndigoAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The blue primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueGrey.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.blue[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [blueAccent], the corresponding accent colors.
        ///  * [indigo], [lightBlue], and [blueGrey], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Blue { get; set; }
        internal virtual int _BluePrimaryValue { get; set; }
        /// <Summary>
        /// The blue accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigo.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.indigoAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.blueAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [blue], the corresponding primary colors.
        ///  * [indigoAccent] and [lightBlueAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor BlueAccent { get; set; }
        internal virtual int _BlueAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The light blue primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.lightBlue[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [lightBlueAccent], the corresponding accent colors.
        ///  * [blue] and [cyan], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor LightBlue { get; set; }
        internal virtual int _LightBluePrimaryValue { get; set; }
        /// <Summary>
        /// The light blue accent swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.lightBlueAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [lightBlue], the corresponding primary colors.
        ///  * [blueAccent] and [cyanAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor LightBlueAccent { get; set; }
        internal virtual int _LightBlueAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The cyan primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueGrey.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.cyan[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [cyanAccent], the corresponding accent colors.
        ///  * [lightBlue], [teal], and [blueGrey], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Cyan { get; set; }
        internal virtual int _CyanPrimaryValue { get; set; }
        /// <Summary>
        /// The cyan accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlue.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightBlueAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.cyanAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [cyan], the corresponding primary colors.
        ///  * [lightBlueAccent] and [tealAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor CyanAccent { get; set; }
        internal virtual int _CyanAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The teal primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.teal[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [tealAccent], the corresponding accent colors.
        ///  * [green] and [cyan], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Teal { get; set; }
        internal virtual int _TealPrimaryValue { get; set; }
        /// <Summary>
        /// The teal accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyanAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.tealAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [teal], the corresponding primary colors.
        ///  * [greenAccent] and [cyanAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor TealAccent { get; set; }
        internal virtual int _TealAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The green primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.green[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [greenAccent], the corresponding accent colors.
        ///  * [teal], [lightGreen], and [lime], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Green { get; set; }
        internal virtual int _GreenPrimaryValue { get; set; }
        /// <Summary>
        /// The green accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.teal.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.tealAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.greenAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [green], the corresponding primary colors.
        ///  * [tealAccent], [lightGreenAccent], and [limeAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor GreenAccent { get; set; }
        internal virtual int _GreenAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The light green primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.lightGreen[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [lightGreenAccent], the corresponding accent colors.
        ///  * [green] and [lime], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor LightGreen { get; set; }
        internal virtual int _LightGreenPrimaryValue { get; set; }
        /// <Summary>
        /// The light green accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.green.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.greenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.lightGreenAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [lightGreen], the corresponding primary colors.
        ///  * [greenAccent] and [limeAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor LightGreenAccent { get; set; }
        internal virtual int _LightGreenAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The lime primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.lime[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [limeAccent], the corresponding accent colors.
        ///  * [lightGreen] and [yellow], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Lime { get; set; }
        internal virtual int _LimePrimaryValue { get; set; }
        /// <Summary>
        /// The lime accent primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreen.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lightGreenAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.limeAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [lime], the corresponding primary colors.
        ///  * [lightGreenAccent] and [yellowAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor LimeAccent { get; set; }
        internal virtual int _LimeAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The yellow primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.yellow[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [yellowAccent], the corresponding accent colors.
        ///  * [lime] and [amber], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Yellow { get; set; }
        internal virtual int _YellowPrimaryValue { get; set; }
        /// <Summary>
        /// The yellow accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.lime.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.limeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.yellowAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [yellow], the corresponding primary colors.
        ///  * [limeAccent] and [amberAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor YellowAccent { get; set; }
        internal virtual int _YellowAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The amber primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.amber[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [amberAccent], the corresponding accent colors.
        ///  * [yellow] and [orange], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Amber { get; set; }
        internal virtual int _AmberPrimaryValue { get; set; }
        /// <Summary>
        /// The amber accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellow.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.yellowAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.amberAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [amber], the corresponding primary colors.
        ///  * [yellowAccent] and [orangeAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor AmberAccent { get; set; }
        internal virtual int _AmberAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The orange primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.brown.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.orange[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [orangeAccent], the corresponding accent colors.
        ///  * [amber], [deepOrange], and [brown], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Orange { get; set; }
        internal virtual int _OrangePrimaryValue { get; set; }
        /// <Summary>
        /// The orange accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amber.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.amberAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.orangeAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [orange], the corresponding primary colors.
        ///  * [amberAccent] and [deepOrangeAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor OrangeAccent { get; set; }
        internal virtual int _OrangeAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The deep orange primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.brown.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.deepOrange[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [deepOrangeAccent], the corresponding accent colors.
        ///  * [orange], [red], and [brown], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor DeepOrange { get; set; }
        internal virtual int _DeepOrangePrimaryValue { get; set; }
        /// <Summary>
        /// The deep orange accent color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.deepOrangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orangeAccent.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.red.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.redAccent.png)
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.deepOrangeAccent[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [deepOrange], the corresponding primary colors.
        ///  * [orangeAccent] [redAccent], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialAccentColor DeepOrangeAccent { get; set; }
        internal virtual int _DeepOrangeAccentPrimaryValue { get; set; }
        /// <Summary>
        /// The brown primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.brown.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.orange.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueGrey.png)
        ///
        /// This swatch has no corresponding accent color and swatch.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.brown[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [orange] and [blueGrey], vaguely similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Brown { get; set; }
        internal virtual int _BrownPrimaryValue { get; set; }
        /// <Summary>
        /// The grey primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.grey.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueGrey.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.brown.png)
        ///
        /// This swatch has no corresponding accent swatch.
        ///
        /// This swatch, in addition to the values 50 and 100 to 900 in 100
        /// increments, also features the special values 350 and 850. The 350 value is
        /// used for raised button while pressed in light themes, and 850 is used for
        /// the background color of the dark theme. See [ThemeData.brightness].
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.grey[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [blueGrey] and [brown], somewhat similar colors.
        ///  * [black], [black87], [black54], [black45], [black38], [black26], [black12], which
        ///    provide a different approach to showing shades of grey.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor Grey { get; set; }
        internal virtual int _GreyPrimaryValue { get; set; }
        /// <Summary>
        /// The blue-grey primary color and swatch.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blueGrey.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.grey.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.cyan.png)
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/Colors.blue.png)
        ///
        /// This swatch has no corresponding accent swatch.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Icon(
        ///   Icons.widgets,
        ///   color: Colors.blueGrey[400],
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [grey], [cyan], and [blue], similar colors.
        ///  * [Theme.of], which allows you to select colors from the current theme
        ///    rather than hard-coding colors in your build methods.
        /// </Summary>
        public virtual FlutterSDK.Material.Colors.MaterialColor BlueGrey { get; set; }
        internal virtual int _BlueGreyPrimaryValue { get; set; }
        /// <Summary>
        /// The material design primary color swatches, excluding grey.
        /// </Summary>
        public virtual List<FlutterSDK.Material.Colors.MaterialColor> Primaries { get; set; }
        /// <Summary>
        /// The material design accent color swatches.
        /// </Summary>
        public virtual List<FlutterSDK.Material.Colors.MaterialAccentColor> Accents { get; set; }
    }

}
