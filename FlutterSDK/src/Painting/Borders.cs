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
namespace FlutterSDK.Painting.Borders
{
    internal static class BordersDefaultClass
    {
        internal static void PaintBorder(Canvas canvas, FlutterBinding.UI.Rect rect, FlutterSDK.Painting.Borders.BorderSide top = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide right = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide bottom = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide left = default(FlutterSDK.Painting.Borders.BorderSide))
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Base class for shape outlines.
    ///
    /// This class handles how to add multiple borders together. Subclasses define
    /// various shapes, like circles ([CircleBorder]), rounded rectangles
    /// ([RoundedRectangleBorder]), continuous rectangles
    /// ([ContinuousRectangleBorder]), or beveled rectangles
    /// ([BeveledRectangleBorder]).
    ///
    /// See also:
    ///
    ///  * [ShapeDecoration], which can be used with [DecoratedBox] to show a shape.
    ///  * [Material] (and many other widgets in the Material library), which takes
    ///    a [ShapeBorder] to define its shape.
    ///  * [NotchedShape], which describes a shape with a hole in it.
    /// </Summary>
    public interface IShapeBorder
    {
        FlutterSDK.Painting.Borders.ShapeBorder Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false);
        FlutterSDK.Painting.Borders.ShapeBorder AddOperator(FlutterSDK.Painting.Borders.ShapeBorder other);
        FlutterSDK.Painting.Borders.ShapeBorder Scale(double t);
        FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t);
        FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t);
        FlutterSDK.Painting.Borders.ShapeBorder Lerp(FlutterSDK.Painting.Borders.ShapeBorder a, FlutterSDK.Painting.Borders.ShapeBorder b, double t);
        Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection));
        Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection));
        void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection));
        string ToString();
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get; }
    }


    /// <Summary>
    /// A side of a border of a box.
    ///
    /// A [Border] consists of four [BorderSide] objects: [Border.top],
    /// [Border.left], [Border.right], and [Border.bottom].
    ///
    /// Note that setting [BorderSide.width] to 0.0 will result in hairline
    /// rendering. A more involved explanation is present in [BorderSide.width].
    ///
    /// {@tool snippet}
    ///
    /// This sample shows how [BorderSide] objects can be used in a [Container], via
    /// a [BoxDecoration] and a [Border], to decorate some [Text]. In this example,
    /// the text has a thick bar above it that is light blue, and a thick bar below
    /// it that is a darker shade of blue.
    ///
    /// ```dart
    /// Container(
    ///   padding: EdgeInsets.all(8.0),
    ///   decoration: BoxDecoration(
    ///     border: Border(
    ///       top: BorderSide(width: 16.0, color: Colors.lightBlue.shade50),
    ///       bottom: BorderSide(width: 16.0, color: Colors.lightBlue.shade900),
    ///     ),
    ///   ),
    ///   child: Text('Flutter in the sky', textAlign: TextAlign.center),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Border], which uses [BorderSide] objects to represent its sides.
    ///  * [BoxDecoration], which optionally takes a [Border] object.
    ///  * [TableBorder], which is similar to [Border] but has two more sides
    ///    ([TableBorder.horizontalInside] and [TableBorder.verticalInside]), both
    ///    of which are also [BorderSide] objects.
    /// </Summary>
    public class BorderSide
    {
        #region constructors
        public BorderSide(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), double width = 1.0, FlutterSDK.Painting.Borders.BorderStyle style = default(FlutterSDK.Painting.Borders.BorderStyle))
        : base()
        {
            this.Color = color;
            this.Width = width;
            this.Style = style; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual double Width { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderStyle Style { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide None { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a [BorderSide] that represents the addition of the two given
        /// [BorderSide]s.
        ///
        /// It is only valid to call this if [canMerge] returns true for the two
        /// sides.
        ///
        /// If one of the sides is zero-width with [BorderStyle.none], then the other
        /// side is return as-is. If both of the sides are zero-width with
        /// [BorderStyle.none], then [BorderSide.zero] is returned.
        ///
        /// The arguments must not be null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide Merge(FlutterSDK.Painting.Borders.BorderSide a, FlutterSDK.Painting.Borders.BorderSide b) { throw new NotImplementedException(); }


        /// <Summary>
        /// Creates a copy of this border but with the given fields replaced with the new values.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide CopyWith(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), double width = default(double), FlutterSDK.Painting.Borders.BorderStyle style = default(FlutterSDK.Painting.Borders.BorderStyle)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Creates a copy of this border side description but with the width scaled
        /// by the factor `t`.
        ///
        /// The `t` argument represents the multiplicand, or the position on the
        /// timeline for an interpolation from nothing to `this`, with 0.0 meaning
        /// that the object returned should be the nil variant of this object, 1.0
        /// meaning that no change should be applied, returning `this` (or something
        /// equivalent to `this`), and other values meaning that the object should be
        /// multiplied by `t`. Negative values are treated like zero.
        ///
        /// Since a zero width is normally painted as a hairline width rather than no
        /// border at all, the zero factor is special-cased to instead change the
        /// style to [BorderStyle.none].
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide Scale(double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Create a [Paint] object that, if used to stroke a line, will draw the line
        /// in this border's style.
        ///
        /// Not all borders use this method to paint their border sides. For example,
        /// non-uniform rectangular [Border]s have beveled edges and so paint their
        /// border sides as filled shapes rather than using a stroke.
        /// </Summary>
        public virtual Paint ToPaint() { throw new NotImplementedException(); }


        /// <Summary>
        /// Whether the two given [BorderSide]s can be merged using [new
        /// BorderSide.merge].
        ///
        /// Two sides can be merged if one or both are zero-width with
        /// [BorderStyle.none], or if they both have the same color and style.
        ///
        /// The arguments must not be null.
        /// </Summary>
        public virtual bool CanMerge(FlutterSDK.Painting.Borders.BorderSide a, FlutterSDK.Painting.Borders.BorderSide b) { throw new NotImplementedException(); }


        /// <Summary>
        /// Linearly interpolate between two border sides.
        ///
        /// The arguments must not be null.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide Lerp(FlutterSDK.Painting.Borders.BorderSide a, FlutterSDK.Painting.Borders.BorderSide b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// Base class for shape outlines.
    ///
    /// This class handles how to add multiple borders together. Subclasses define
    /// various shapes, like circles ([CircleBorder]), rounded rectangles
    /// ([RoundedRectangleBorder]), continuous rectangles
    /// ([ContinuousRectangleBorder]), or beveled rectangles
    /// ([BeveledRectangleBorder]).
    ///
    /// See also:
    ///
    ///  * [ShapeDecoration], which can be used with [DecoratedBox] to show a shape.
    ///  * [Material] (and many other widgets in the Material library), which takes
    ///    a [ShapeBorder] to define its shape.
    ///  * [NotchedShape], which describes a shape with a hole in it.
    /// </Summary>
    public class ShapeBorder
    {
        #region constructors
        public ShapeBorder()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Attempts to create a new object that represents the amalgamation of `this`
        /// border and the `other` border.
        ///
        /// If the type of the other border isn't known, or the given instance cannot
        /// be reasonably added to this instance, then this should return null.
        ///
        /// This method is used by the [operator +] implementation.
        ///
        /// The `reversed` argument is true if this object was the right operand of
        /// the `+` operator, and false if it was the left operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false) { throw new NotImplementedException(); }


        /// <Summary>
        /// Creates a new border consisting of the two borders on either side of the
        /// operator.
        ///
        /// If the borders belong to classes that know how to add themselves, then
        /// this results in a new border that represents the intelligent addition of
        /// those two borders (see [add]). Otherwise, an object is returned that
        /// merely paints the two borders sequentially, with the left hand operand on
        /// the inside and the right hand operand on the outside.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder AddOperator(FlutterSDK.Painting.Borders.ShapeBorder other) { throw new NotImplementedException(); }


        /// <Summary>
        /// Creates a copy of this border, scaled by the factor `t`.
        ///
        /// Typically this means scaling the width of the border's side, but it can
        /// also include scaling other artifacts of the border, e.g. the border radius
        /// of a [RoundedRectangleBorder].
        ///
        /// The `t` argument represents the multiplicand, or the position on the
        /// timeline for an interpolation from nothing to `this`, with 0.0 meaning
        /// that the object returned should be the nil variant of this object, 1.0
        /// meaning that no change should be applied, returning `this` (or something
        /// equivalent to `this`), and other values meaning that the object should be
        /// multiplied by `t`. Negative values are allowed but may be meaningless
        /// (they correspond to extrapolating the interpolation from this object to
        /// nothing, and going beyond nothing)
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        ///
        /// See also:
        ///
        ///  * [BorderSide.scale], which most [ShapeBorder] subclasses defer to for
        ///    the actual computation.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Scale(double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Linearly interpolates from another [ShapeBorder] (possibly of another
        /// class) to `this`.
        ///
        /// When implementing this method in subclasses, return null if this class
        /// cannot interpolate from `a`. In that case, [lerp] will try `a`'s [lerpTo]
        /// method instead. If `a` is null, this must not return null.
        ///
        /// The base class implementation handles the case of `a` being null by
        /// deferring to [scale].
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
        /// Instead of calling this directly, use [ShapeBorder.lerp].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Linearly interpolates from `this` to another [ShapeBorder] (possibly of
        /// another class).
        ///
        /// This is called if `b`'s [lerpTo] did not know how to handle this class.
        ///
        /// When implementing this method in subclasses, return null if this class
        /// cannot interpolate from `b`. In that case, [lerp] will apply a default
        /// behavior instead. If `b` is null, this must not return null.
        ///
        /// The base class implementation handles the case of `b` being null by
        /// deferring to [scale].
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
        /// Instead of calling this directly, use [ShapeBorder.lerp].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Linearly interpolates between two [ShapeBorder]s.
        ///
        /// This defers to `b`'s [lerpTo] function if `b` is not null. If `b` is
        /// null or if its [lerpTo] returns null, it uses `a`'s [lerpFrom]
        /// function instead. If both return null, it returns `a` before `t=0.5`
        /// and `b` after `t=0.5`.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Lerp(FlutterSDK.Painting.Borders.ShapeBorder a, FlutterSDK.Painting.Borders.ShapeBorder b, double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Create a [Path] that describes the outer edge of the border.
        ///
        /// This path must not cross the path given by [getInnerPath] for the same
        /// [Rect].
        ///
        /// To obtain a [Path] that describes the area of the border itself, set the
        /// [Path.fillType] of the returned object to [PathFillType.evenOdd], and add
        /// to this object the path returned from [getInnerPath] (using
        /// [Path.addPath]).
        ///
        /// The `textDirection` argument must be provided non-null if the border
        /// has a text direction dependency (for example if it is expressed in terms
        /// of "start" and "end" instead of "left" and "right"). It may be null if
        /// the border will not need the text direction to paint itself.
        ///
        /// See also:
        ///
        ///  * [getInnerPath], which creates the path for the inner edge.
        ///  * [Path.contains], which can tell if an [Offset] is within a [Path].
        /// </Summary>
        public virtual Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Create a [Path] that describes the inner edge of the border.
        ///
        /// This path must not cross the path given by [getOuterPath] for the same
        /// [Rect].
        ///
        /// To obtain a [Path] that describes the area of the border itself, set the
        /// [Path.fillType] of the returned object to [PathFillType.evenOdd], and add
        /// to this object the path returned from [getOuterPath] (using
        /// [Path.addPath]).
        ///
        /// The `textDirection` argument must be provided and non-null if the border
        /// has a text direction dependency (for example if it is expressed in terms
        /// of "start" and "end" instead of "left" and "right"). It may be null if
        /// the border will not need the text direction to paint itself.
        ///
        /// See also:
        ///
        ///  * [getOuterPath], which creates the path for the outer edge.
        ///  * [Path.contains], which can tell if an [Offset] is within a [Path].
        /// </Summary>
        public virtual Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Paints the border within the given [Rect] on the given [Canvas].
        ///
        /// The `textDirection` argument must be provided and non-null if the border
        /// has a text direction dependency (for example if it is expressed in terms
        /// of "start" and "end" instead of "left" and "right"). It may be null if
        /// the border will not need the text direction to paint itself.
        /// </Summary>
        public virtual void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// Represents the addition of two otherwise-incompatible borders.
    ///
    /// The borders are listed from the outside to the inside.
    /// </Summary>
    public class _CompoundBorder : FlutterSDK.Painting.Borders.ShapeBorder
    {
        #region constructors
        public _CompoundBorder(List<FlutterSDK.Painting.Borders.ShapeBorder> borders)
        : base()
        {
            this.Borders = borders; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Painting.Borders.ShapeBorder> Borders { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Painting.Borders.ShapeBorder Add(FlutterSDK.Painting.Borders.ShapeBorder other, bool reversed = false) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Borders.ShapeBorder Scale(double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Borders._CompoundBorder Lerp(FlutterSDK.Painting.Borders.ShapeBorder a, FlutterSDK.Painting.Borders.ShapeBorder b, double t) { throw new NotImplementedException(); }


        public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection)) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// The style of line to draw for a [BorderSide] in a [Border].
    /// </Summary>
    public enum BorderStyle
    {

        /// <Summary>
        /// Skip the border.
        /// </Summary>
        None,
        /// <Summary>
        /// Draw the border as a solid line.
        /// </Summary>
        Solid,
    }

}
