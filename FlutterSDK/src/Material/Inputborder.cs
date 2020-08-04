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
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Inputborder
{
    internal static class InputborderDefaultClass
    {
    }

    /// <Summary>
    /// Defines the appearance of an [InputDecorator]'s border.
    ///
    /// An input decorator's border is specified by [InputDecoration.border].
    ///
    /// The border is drawn relative to the input decorator's "container" which
    /// is the optionally filled area above the decorator's helper, error,
    /// and counter.
    ///
    /// Input border's are decorated with a line whose weight and color are defined
    /// by [borderSide]. The input decorator's renderer animates the input border's
    /// appearance in response to state changes, like gaining or losing the focus,
    /// by creating new copies of its input border with [copyWith].
    ///
    /// See also:
    ///
    ///  * [UnderlineInputBorder], the default [InputDecorator] border which
    ///    draws a horizontal line at the bottom of the input decorator's container.
    ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
    ///    rounded rectangle around the input decorator's container.
    ///  * [InputDecoration], which is used to configure an [InputDecorator].
    /// </Summary>
    public interface IInputBorder
    {
        FlutterSDK.Material.Inputborder.InputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide));
        void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection));
        FlutterSDK.Material.Inputborder.InputBorder None { get; }
        FlutterSDK.Painting.Borders.BorderSide BorderSide { get; }
        bool IsOutline { get; }
    }


    /// <Summary>
    /// Defines the appearance of an [InputDecorator]'s border.
    ///
    /// An input decorator's border is specified by [InputDecoration.border].
    ///
    /// The border is drawn relative to the input decorator's "container" which
    /// is the optionally filled area above the decorator's helper, error,
    /// and counter.
    ///
    /// Input border's are decorated with a line whose weight and color are defined
    /// by [borderSide]. The input decorator's renderer animates the input border's
    /// appearance in response to state changes, like gaining or losing the focus,
    /// by creating new copies of its input border with [copyWith].
    ///
    /// See also:
    ///
    ///  * [UnderlineInputBorder], the default [InputDecorator] border which
    ///    draws a horizontal line at the bottom of the input decorator's container.
    ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
    ///    rounded rectangle around the input decorator's container.
    ///  * [InputDecoration], which is used to configure an [InputDecorator].
    /// </Summary>
    public class InputBorder : FlutterSDK.Painting.Borders.ShapeBorder
    {
        /// <Summary>
        /// Creates a border for an [InputDecorator].
        ///
        /// The [borderSide] parameter must not be null. Applications typically do
        /// not specify a [borderSide] parameter because the input decorator
        /// substitutes its own, using [copyWith], based on the current theme and
        /// [InputDecorator.isFocused].
        /// </Summary>
        public InputBorder(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide))
        : base()
        {
            this.BorderSide = borderSide;
        }
        /// <Summary>
        /// No input border.
        ///
        /// Use this value with [InputDecoration.border] to specify that no border
        /// should be drawn. The [InputDecoration.shrinkWrap] constructor sets
        /// its border to this value.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder None { get; set; }
        /// <Summary>
        /// Defines the border line's color and weight.
        ///
        /// The [InputDecorator] creates copies of its input border, using [copyWith],
        /// based on the current theme and [InputDecorator.isFocused].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide BorderSide { get; set; }
        public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this input border with the specified `borderSide`.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide))
        {
            return default(InputBorder);
        }


        /// <Summary>
        /// Paint this input border on [canvas].
        ///
        /// The [rect] parameter bounds the [InputDecorator]'s container.
        ///
        /// The additional `gap` parameters reflect the state of the [InputDecorator]'s
        /// floating label. When an input decorator gains the focus, its label
        /// animates upwards, to make room for the input child. The [gapStart] and
        /// [gapExtent] parameters define a floating label width interval, and
        /// [gapPercentage] defines the animation's progress (0.0 to 1.0).
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
        {
        }

    }


    public class _NoInputBorder : FlutterSDK.Material.Inputborder.InputBorder
    {
        public _NoInputBorder()
        : base(borderSide: BordersDefaultClass.BorderSide.None)
        {

        }
        public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Inputborder._NoInputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide)) => new _NoInputBorder();



        public new FlutterSDK.Material.Inputborder._NoInputBorder Scale(double t) => new _NoInputBorder();



        public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return new Path();
            new Path().AddRect(rect);
        }




        public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return new Path();
            new Path().AddRect(rect);
        }




        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
        {
        }



    }


    /// <Summary>
    /// Draws a horizontal line at the bottom of an [InputDecorator]'s container and
    /// defines the container's shape.
    ///
    /// The input decorator's "container" is the optionally filled area above the
    /// decorator's helper, error, and counter.
    ///
    /// See also:
    ///
    ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
    ///    rounded rectangle around the input decorator's container.
    ///  * [InputDecoration], which is used to configure an [InputDecorator].
    /// </Summary>
    public class UnderlineInputBorder : FlutterSDK.Material.Inputborder.InputBorder
    {
        /// <Summary>
        /// Creates an underline border for an [InputDecorator].
        ///
        /// The [borderSide] parameter defaults to [BorderSide.none] (it must not be
        /// null). Applications typically do not specify a [borderSide] parameter
        /// because the input decorator substitutes its own, using [copyWith], based
        /// on the current theme and [InputDecorator.isFocused].
        ///
        /// The [borderRadius] parameter defaults to a value where the top left
        /// and right corners have a circular radius of 4.0. The [borderRadius]
        /// parameter must not be null.
        /// </Summary>
        public UnderlineInputBorder(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
        : base(borderSide: borderSide)
        {
            this.BorderRadius = borderRadius;
        }
        /// <Summary>
        /// The radii of the border's rounded rectangle corners.
        ///
        /// When this border is used with a filled input decorator, see
        /// [InputDecoration.filled], the border radius defines the shape
        /// of the background fill as well as the bottom left and right
        /// edges of the underline itself.
        ///
        /// By default the top right and top left corners have a circular radius
        /// of 4.0.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Inputborder.UnderlineInputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
        {
            return new UnderlineInputBorder(borderSide: borderSide ?? this.BorderSide, borderRadius: borderRadius ?? this.BorderRadius);
        }




        public new FlutterSDK.Material.Inputborder.UnderlineInputBorder Scale(double t)
        {
            return new UnderlineInputBorder(borderSide: BorderSide.Scale(t));
        }




        public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return new Path();
            new Path().AddRect(Rect.FromLTWH(rect.Left, rect.Top, rect.Width, Dart.Math.MathDefaultClass.Max(0.0, rect.Height - BorderSide.Width)));
        }




        public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return new Path();
            new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect));
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
        {
            if (a is UnderlineInputBorder)
            {
                return new UnderlineInputBorder(borderSide: BordersDefaultClass.BorderSide.Lerp(((UnderlineInputBorder)a).BorderSide, BorderSide, t), borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(((UnderlineInputBorder)a).BorderRadius, BorderRadius, t));
            }

            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
        {
            if (b is UnderlineInputBorder)
            {
                return new UnderlineInputBorder(borderSide: BordersDefaultClass.BorderSide.Lerp(BorderSide, ((UnderlineInputBorder)b).BorderSide, t), borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(BorderRadius, ((UnderlineInputBorder)b).BorderRadius, t));
            }

            return base.LerpTo(b, t);
        }




        /// <Summary>
        /// Draw a horizontal line at the bottom of [rect].
        ///
        /// The [borderSide] defines the line's color and weight. The `textDirection`
        /// `gap` and `textDirection` parameters are ignored.
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
        {
            if (BorderRadius.BottomLeft != Dart.UiDefaultClass.Radius.Zero || BorderRadius.BottomRight != Dart.UiDefaultClass.Radius.Zero) canvas.ClipPath(GetOuterPath(rect, textDirection: textDirection));
            canvas.DrawLine(rect.BottomLeft, rect.BottomRight, BorderSide.ToPaint());
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is InputBorder && other.BorderSide == BorderSide;
        }



    }


    /// <Summary>
    /// Draws a rounded rectangle around an [InputDecorator]'s container.
    ///
    /// When the input decorator's label is floating, for example because its
    /// input child has the focus, the label appears in a gap in the border outline.
    ///
    /// The input decorator's "container" is the optionally filled area above the
    /// decorator's helper, error, and counter.
    ///
    /// See also:
    ///
    ///  * [UnderlineInputBorder], the default [InputDecorator] border which
    ///    draws a horizontal line at the bottom of the input decorator's container.
    ///  * [InputDecoration], which is used to configure an [InputDecorator].
    /// </Summary>
    public class OutlineInputBorder : FlutterSDK.Material.Inputborder.InputBorder
    {
        /// <Summary>
        /// Creates a rounded rectangle outline border for an [InputDecorator].
        ///
        /// If the [borderSide] parameter is [BorderSide.none], it will not draw a
        /// border. However, it will still define a shape (which you can see if
        /// [InputDecoration.filled] is true).
        ///
        /// If an application does not specify a [borderSide] parameter of
        /// value [BorderSide.none], the input decorator substitutes its own, using
        /// [copyWith], based on the current theme and [InputDecorator.isFocused].
        ///
        /// The [borderRadius] parameter defaults to a value where all four
        /// corners have a circular radius of 4.0. The [borderRadius] parameter
        /// must not be null and the corner radii must be circular, i.e. their
        /// [Radius.x] and [Radius.y] values must be the same.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.hasFloatingPlaceholder], which should be set to false
        ///    when the [borderSide] is [BorderSide.none]. If let as true, the label
        ///    will extend beyond the container as if the border were still being
        ///    drawn.
        /// </Summary>
        public OutlineInputBorder(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double gapPadding = 4.0)
        : base(borderSide: borderSide)
        {
            this.BorderRadius = borderRadius;
            this.GapPadding = gapPadding;
        }
        /// <Summary>
        /// Horizontal padding on either side of the border's
        /// [InputDecoration.labelText] width gap.
        ///
        /// This value is used by the [paint] method to compute the actual gap width.
        /// </Summary>
        public virtual double GapPadding { get; set; }
        /// <Summary>
        /// The radii of the border's rounded rectangle corners.
        ///
        /// The corner radii must be circular, i.e. their [Radius.x] and [Radius.y]
        /// values must be the same.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private bool _CornersAreCircular(FlutterSDK.Painting.Borderradius.BorderRadius borderRadius)
        {
            return borderRadius.TopLeft.x == borderRadius.TopLeft.y && borderRadius.BottomLeft.x == borderRadius.BottomLeft.y && borderRadius.TopRight.x == borderRadius.TopRight.y && borderRadius.BottomRight.x == borderRadius.BottomRight.y;
        }




        public new FlutterSDK.Material.Inputborder.OutlineInputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double gapPadding = default(double))
        {
            return new OutlineInputBorder(borderSide: borderSide ?? this.BorderSide, borderRadius: borderRadius ?? this.BorderRadius, gapPadding: gapPadding == default(double) ? this.gapPadding : gapPadding);
        }




        public new FlutterSDK.Material.Inputborder.OutlineInputBorder Scale(double t)
        {
            return new OutlineInputBorder(borderSide: BorderSide.Scale(t), borderRadius: BorderRadius * t, gapPadding: GapPadding * t);
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
        {
            if (a is OutlineInputBorder)
            {
                OutlineInputBorder outline = ((OutlineInputBorder)a);
                return new OutlineInputBorder(borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(outline.BorderRadius, BorderRadius, t), borderSide: BordersDefaultClass.BorderSide.Lerp(outline.BorderSide, BorderSide, t), gapPadding: outline.GapPadding);
            }

            return base.LerpFrom(a, t);
        }




        public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
        {
            if (b is OutlineInputBorder)
            {
                OutlineInputBorder outline = ((OutlineInputBorder)b);
                return new OutlineInputBorder(borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(BorderRadius, outline.BorderRadius, t), borderSide: BordersDefaultClass.BorderSide.Lerp(BorderSide, outline.BorderSide, t), gapPadding: outline.GapPadding);
            }

            return base.LerpTo(b, t);
        }




        public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return new Path();
            new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect).Deflate(BorderSide.Width));
        }




        public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
        {
            return new Path();
            new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect));
        }




        private Path _GapBorderPath(Canvas canvas, FlutterBinding.UI.RRect center, double start, double extent)
        {
            RRect scaledRRect = center.ScaleRadii();
            Rect tlCorner = Rect.FromLTWH(scaledRRect.Left, scaledRRect.Top, scaledRRect.TlRadiusX * 2.0, scaledRRect.TlRadiusY * 2.0);
            Rect trCorner = Rect.FromLTWH(scaledRRect.Right - scaledRRect.TrRadiusX * 2.0, scaledRRect.Top, scaledRRect.TrRadiusX * 2.0, scaledRRect.TrRadiusY * 2.0);
            Rect brCorner = Rect.FromLTWH(scaledRRect.Right - scaledRRect.BrRadiusX * 2.0, scaledRRect.Bottom - scaledRRect.BrRadiusY * 2.0, scaledRRect.BrRadiusX * 2.0, scaledRRect.BrRadiusY * 2.0);
            Rect blCorner = Rect.FromLTWH(scaledRRect.Left, scaledRRect.Bottom - scaledRRect.BlRadiusY * 2.0, scaledRRect.BlRadiusX * 2.0, scaledRRect.BlRadiusX * 2.0);
            double cornerArcSweep = Math.Dart.MathDefaultClass.Pi / 2.0;
            double tlCornerArcSweep = start < scaledRRect.TlRadiusX ? Dart.Math.MathDefaultClass.Asin((start / scaledRRect.TlRadiusX).Clamp(-1.0, 1.0)) : Math.Dart.MathDefaultClass.Pi / 2.0;
            Path path = new Path();
            new Path().AddArc(tlCorner, Math.Dart.MathDefaultClass.Pi, tlCornerArcSweep);
            new Path().MoveTo(scaledRRect.Left + scaledRRect.TlRadiusX, scaledRRect.Top);
            if (start > scaledRRect.TlRadiusX) path.LineTo(scaledRRect.Left + start, scaledRRect.Top);
            double trCornerArcStart = (3 * Math.Dart.MathDefaultClass.Pi) / 2.0;
            double trCornerArcSweep = cornerArcSweep;
            if (start + extent < scaledRRect.Width - scaledRRect.TrRadiusX)
            {
                ;
                path.RelativeMoveTo(extent, 0.0);
                path.LineTo(scaledRRect.Right - scaledRRect.TrRadiusX, scaledRRect.Top);
                path.AddArc(trCorner, trCornerArcStart, trCornerArcSweep);
            }
            else if (start + extent < scaledRRect.Width)
            {
                double dx = scaledRRect.Width - (start + extent);
                double sweep = Dart.Math.MathDefaultClass.Acos(dx / scaledRRect.TrRadiusX);
                path.AddArc(trCorner, trCornerArcStart + sweep, trCornerArcSweep - sweep);
            }

            return;
            path.MoveTo(scaledRRect.Right, scaledRRect.Top + scaledRRect.TrRadiusY);
            path.LineTo(scaledRRect.Right, scaledRRect.Bottom - scaledRRect.BrRadiusY);
            path.AddArc(brCorner, 0.0, cornerArcSweep);
            path.LineTo(scaledRRect.Left + scaledRRect.BlRadiusX, scaledRRect.Bottom);
            path.AddArc(blCorner, Math.Dart.MathDefaultClass.Pi / 2.0, cornerArcSweep);
            path.LineTo(scaledRRect.Left, scaledRRect.Top + scaledRRect.TlRadiusY);
        }




        /// <Summary>
        /// Draw a rounded rectangle around [rect] using [borderRadius].
        ///
        /// The [borderSide] defines the line's color and weight.
        ///
        /// The top side of the rounded rectangle may be interrupted by a single gap
        /// if [gapExtent] is non-null. In that case the gap begins at
        /// `gapStart - gapPadding` (assuming that the [textDirection] is [TextDirection.ltr]).
        /// The gap's width is `(gapPadding + gapExtent + gapPadding) * gapPercentage`.
        /// </Summary>
        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
        {



            Paint paint = BorderSide.ToPaint();
            RRect outer = BorderRadius.ToRRect(rect);
            RRect center = outer.Deflate(BorderSide.Width / 2.0);
            if (gapStart == null || gapExtent <= 0.0 || gapPercentage == 0.0)
            {
                canvas.DrawRRect(center, paint);
            }
            else
            {
                double extent = Dart.UI.UiDefaultClass.LerpDouble(0.0, gapExtent + GapPadding * 2.0, gapPercentage);
                switch (textDirection) { case TextDirection.Rtl: Path path = _GapBorderPath(canvas, center, Dart.Math.MathDefaultClass.Max(0.0, gapStart + GapPadding - extent), extent); canvas.DrawPath(path, paint); break; case TextDirection.Ltr: Path path = _GapBorderPath(canvas, center, Dart.Math.MathDefaultClass.Max(0.0, gapStart - GapPadding), extent); canvas.DrawPath(path, paint); break; }
            }

        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is OutlineInputBorder && other.BorderSide == BorderSide && other.BorderRadius == BorderRadius && other.GapPadding == GapPadding;
        }



    }

}
