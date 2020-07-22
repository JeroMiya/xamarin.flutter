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
namespace FlutterSDK.Painting.Shapedecoration
{
    internal static class ShapedecorationDefaultClass
    {
    }

    /// <Summary>
    /// An immutable description of how to paint an arbitrary shape.
    ///
    /// The [ShapeDecoration] class provides a way to draw a [ShapeBorder],
    /// optionally filling it with a color or a gradient, optionally painting an
    /// image into it, and optionally casting a shadow.
    ///
    /// {@tool snippet}
    ///
    /// The following example uses the [Container] widget from the widgets layer to
    /// draw a white rectangle with a 24-pixel multicolor outline, with the text
    /// "RGB" inside it:
    ///
    /// ```dart
    /// Container(
    ///   decoration: ShapeDecoration(
    ///     color: Colors.white,
    ///     shape: Border.all(
    ///       color: Colors.red,
    ///       width: 8.0,
    ///     ) + Border.all(
    ///       color: Colors.green,
    ///       width: 8.0,
    ///     ) + Border.all(
    ///       color: Colors.blue,
    ///       width: 8.0,
    ///     ),
    ///   ),
    ///   child: const Text('RGB', textAlign: TextAlign.center),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [DecoratedBox] and [Container], widgets that can be configured with
    ///    [ShapeDecoration] objects.
    ///  * [BoxDecoration], a similar [Decoration] that is optimized for rectangles
    ///    specifically.
    ///  * [ShapeBorder], the base class for the objects that are used in the
    ///    [shape] property.
    /// </Summary>
    public class ShapeDecoration : FlutterSDK.Painting.Decoration.Decoration
    {
        public ShapeDecoration(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Decorationimage.DecorationImage image = default(FlutterSDK.Painting.Decorationimage.DecorationImage), FlutterSDK.Painting.Gradient.Gradient gradient = default(FlutterSDK.Painting.Gradient.Gradient), List<FlutterSDK.Painting.Boxshadow.BoxShadow> shadows = default(List<FlutterSDK.Painting.Boxshadow.BoxShadow>), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base()
        {
            this.Color = color;
            this.Image = image;
            this.Gradient = gradient;
            this.Shadows = shadows;
            this.Shape = shape;
        }
        public static ShapeDecoration FromBoxDecoration(FlutterSDK.Painting.Boxdecoration.BoxDecoration source)
        {
            var instance = new ShapeDecoration();
            ShapeBorder shape = default(ShapeBorder);

            switch (source.Shape)
            {
                case BoxShape.Circle:
                    if (source.Border != null)
                    {

                        shape = new CircleBorder(side: source.Border.Top);
                    }
                    else
                    {
                        shape = new CircleBorder();
                    }
                    break;
                case BoxShape.Rectangle:
                    if (source.BorderRadius != null)
                    {

                        shape = new RoundedRectangleBorder(side: source.Border?.Top ?? BordersDefaultClass.BorderSide.None, borderRadius: source.BorderRadius);
                    }
                    else
                    {
                        shape = source.Border ?? new Border();
                    }
                    break;
            }
            return new ShapeDecoration(color: source.Color, image: source.Image, gradient: source.Gradient, shadows: source.BoxShadow, shape: shape);
        }


        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterSDK.Painting.Gradient.Gradient Gradient { get; set; }
        public virtual FlutterSDK.Painting.Decorationimage.DecorationImage Image { get; set; }
        public virtual List<FlutterSDK.Painting.Boxshadow.BoxShadow> Shadows { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsComplex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new Path GetClipPath(FlutterBinding.UI.Rect rect, TextDirection textDirection)
        {
            return Shape.GetOuterPath(rect, textDirection: textDirection);
        }




        public new FlutterSDK.Painting.Shapedecoration.ShapeDecoration LerpFrom(FlutterSDK.Painting.Decoration.Decoration a, double t)
        {
            if (a is BoxDecoration)
            {
                return ShapedecorationDefaultClass.ShapeDecoration.Lerp(ShapeDecoration.FromBoxDecoration(((BoxDecoration)a)), this, t);
            }
            else if (a == null || a is ShapeDecoration)
            {
                return ShapedecorationDefaultClass.ShapeDecoration.Lerp(((ShapeDecoration)a) as ShapeDecoration, this, t);
            }

            return base.LerpFrom(a, t) as ShapeDecoration;
        }




        public new FlutterSDK.Painting.Shapedecoration.ShapeDecoration LerpTo(FlutterSDK.Painting.Decoration.Decoration b, double t)
        {
            if (b is BoxDecoration)
            {
                return ShapedecorationDefaultClass.ShapeDecoration.Lerp(this, ShapeDecoration.FromBoxDecoration(((BoxDecoration)b)), t);
            }
            else if (b == null || b is ShapeDecoration)
            {
                return ShapedecorationDefaultClass.ShapeDecoration.Lerp(this, ((ShapeDecoration)b) as ShapeDecoration, t);
            }

            return base.LerpTo(b, t) as ShapeDecoration;
        }




        /// <Summary>
        /// Linearly interpolate between two shapes.
        ///
        /// Interpolates each parameter of the decoration separately.
        ///
        /// If both values are null, this returns null. Otherwise, it returns a
        /// non-null value, with null arguments treated like a [ShapeDecoration] whose
        /// fields are all null (including the [shape], which cannot normally be
        /// null).
        ///
        /// {@macro dart.ui.shadow.lerp}
        ///
        /// See also:
        ///
        ///  * [Decoration.lerp], which can interpolate between any two types of
        ///    [Decoration]s, not just [ShapeDecoration]s.
        ///  * [lerpFrom] and [lerpTo], which are used to implement [Decoration.lerp]
        ///    and which use [ShapeDecoration.lerp] when interpolating two
        ///    [ShapeDecoration]s or a [ShapeDecoration] to or from null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Shapedecoration.ShapeDecoration Lerp(FlutterSDK.Painting.Shapedecoration.ShapeDecoration a, FlutterSDK.Painting.Shapedecoration.ShapeDecoration b, double t)
        {

            if (a == null && b == null) return null;
            if (a != null && b != null)
            {
                if (t == 0.0) return a;
                if (t == 1.0) return b;
            }

            return new ShapeDecoration(color: Dart:uiDefaultClass.Color.Lerp(a?.Color, b?.Color, t), gradient: GradientDefaultClass.Gradient.Lerp(a?.Gradient, b?.Gradient, t), image: t < 0.5 ? a.Image : b.Image, shadows: BoxshadowDefaultClass.BoxShadow.LerpList(a?.Shadows, b?.Shadows, t), shape: BordersDefaultClass.ShapeBorder.Lerp(a?.Shape, b?.Shape, t));
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            return other is ShapeDecoration && other.Color == Color && other.Gradient == Gradient && other.Image == Image && other.Shadows == Shadows && other.Shape == Shape;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.DefaultDiagnosticsTreeStyle = DiagnosticsTreeStyle.Whitespace;
            properties.Add(new ColorProperty("color", Color, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Gradient>("gradient", Gradient, defaultValue: null));
            properties.Add(new DiagnosticsProperty<DecorationImage>("image", Image, defaultValue: null));
            properties.Add(new IterableProperty<BoxShadow>("shadows", Shadows, defaultValue: null, style: DiagnosticsTreeStyle.Whitespace));
            properties.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape));
        }




        public new bool HitTest(Size size, FlutterBinding.UI.Offset position, TextDirection textDirection = default(TextDirection))
        {
            return Shape.GetOuterPath(Dart: uiDefaultClass.Offset.Zero & size, textDirection: textDirection).Contains(position);
        }




        public new FlutterSDK.Painting.Shapedecoration._ShapeDecorationPainter CreateBoxPainter(VoidCallback onChanged = default(VoidCallback))
        {

            return new _ShapeDecorationPainter(this, onChanged);
        }



    }


    /// <Summary>
    /// An object that paints a [ShapeDecoration] into a canvas.
    /// </Summary>
    public class _ShapeDecorationPainter : FlutterSDK.Painting.Decoration.BoxPainter
    {
        public _ShapeDecorationPainter(FlutterSDK.Painting.Shapedecoration.ShapeDecoration _decoration, VoidCallback onChanged)
        : base(onChanged)
        {
            this._Decoration = _decoration;
        }
        internal virtual FlutterSDK.Painting.Shapedecoration.ShapeDecoration _Decoration { get; set; }
        internal virtual FlutterBinding.UI.Rect _LastRect { get; set; }
        internal virtual TextDirection _LastTextDirection { get; set; }
        internal virtual Path _OuterPath { get; set; }
        internal virtual Path _InnerPath { get; set; }
        internal virtual SKPaint _InteriorPaint { get; set; }
        internal virtual int _ShadowCount { get; set; }
        internal virtual List<Path> _ShadowPaths { get; set; }
        internal virtual List<Paint> _ShadowPaints { get; set; }
        internal virtual FlutterSDK.Painting.Decorationimage.DecorationImagePainter _ImagePainter { get; set; }

        private void _Precache(FlutterBinding.UI.Rect rect, TextDirection textDirection)
        {

            if (rect == _LastRect && textDirection == _LastTextDirection) return;
            if (_InteriorPaint == null && (_Decoration.Color != null || _Decoration.Gradient != null))
            {
                _InteriorPaint = new Paint();
                if (_Decoration.Color != null) _InteriorPaint.Color = _Decoration.Color;
            }

            if (_Decoration.Gradient != null) _InteriorPaint.Shader = _Decoration.Gradient.CreateShader(rect);
            if (_Decoration.Shadows != null)
            {
                if (_ShadowCount == null)
                {
                    _ShadowCount = _Decoration.Shadows.Count;
                    _ShadowPaths = new List<Path>(_ShadowCount);
                    _ShadowPaints = new List<Paint>(_ShadowCount);
                    for (int index = 0; index < _ShadowCount; index += 1) _ShadowPaints[index] = _Decoration.Shadows[index].ToPaint();
                }

                for (int index = 0; index < _ShadowCount; index += 1)
                {
                    BoxShadow shadow = _Decoration.Shadows[index];
                    _ShadowPaths[index] = _Decoration.Shape.GetOuterPath(rect.Shift(shadow.Offset).Inflate(shadow.SpreadRadius), textDirection: textDirection);
                }

            }

            if (_InteriorPaint != null || _ShadowCount != null) _OuterPath = _Decoration.Shape.GetOuterPath(rect, textDirection: textDirection);
            if (_Decoration.Image != null) _InnerPath = _Decoration.Shape.GetInnerPath(rect, textDirection: textDirection);
            _LastRect = rect;
            _LastTextDirection = textDirection;
        }




        private void _PaintShadows(Canvas canvas)
        {
            if (_ShadowCount != null)
            {
                for (int index = 0; index < _ShadowCount; index += 1) canvas.DrawPath(_ShadowPaths[index], _ShadowPaints[index]);
            }

        }




        private void _PaintInterior(Canvas canvas)
        {
            if (_InteriorPaint != null) canvas.DrawPath(_OuterPath, _InteriorPaint);
        }




        private void _PaintImage(Canvas canvas, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {
            if (_Decoration.Image == null) return;
            _ImagePainter = (_ImagePainter == null ? _Decoration.Image.CreatePainter(OnChanged) : _ImagePainter);
            _ImagePainter.Paint(canvas, _LastRect, _InnerPath, configuration);
        }




        public new void Dispose()
        {
            _ImagePainter?.Dispose();
            base.Dispose();
        }




        public new void Paint(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {


            Rect rect = offset & configuration.Size;
            TextDirection textDirection = configuration.TextDirection;
            _Precache(rect, textDirection);
            _PaintShadows(canvas);
            _PaintInterior(canvas);
            _PaintImage(canvas, configuration);
            _Decoration.Shape.Paint(canvas, rect, textDirection: textDirection);
        }



    }

}
