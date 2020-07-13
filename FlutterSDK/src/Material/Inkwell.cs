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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
namespace FlutterSDK.Material.Inkwell
{
    internal static class InkwellDefaultClass
    {
    }

    /// <Summary>
    /// An ink feature that displays a [color] "splash" in response to a user
    /// gesture that can be confirmed or canceled.
    ///
    /// Subclasses call [confirm] when an input gesture is recognized. For
    /// example a press event might trigger an ink feature that's confirmed
    /// when the corresponding up event is seen.
    ///
    /// Subclasses call [cancel] when an input gesture is aborted before it
    /// is recognized. For example a press event might trigger an ink feature
    /// that's canceled when the pointer is dragged out of the reference
    /// box.
    ///
    /// The [InkWell] and [InkResponse] widgets generate instances of this
    /// class.
    /// </Summary>
    public interface IInteractiveInkFeature
    {
        void Confirm();
        void Cancel();
        void PaintInkCircle(Canvas canvas = default(Canvas), Matrix4 transform = default(Matrix4), SKPaint paint = default(SKPaint), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), double radius = default(double), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Material.Material.RectCallback clipCallback = default(FlutterSDK.Material.Material.RectCallback));
        FlutterBinding.UI.Color Color { get; set; }
    }


    /// <Summary>
    /// An encapsulation of an [InteractiveInkFeature] constructor used by
    /// [InkWell], [InkResponse], and [ThemeData].
    ///
    /// Interactive ink feature implementations should provide a static const
    /// `splashFactory` value that's an instance of this class. The `splashFactory`
    /// can be used to configure an [InkWell], [InkResponse] or [ThemeData].
    ///
    /// See also:
    ///
    ///  * [InkSplash.splashFactory]
    ///  * [InkRipple.splashFactory]
    /// </Summary>
    public interface IInteractiveInkFeatureFactory
    {
        FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), bool containedInkWell = false, FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), double radius = default(double), VoidCallback onRemoved = default(VoidCallback));
    }


    /// <Summary>
    /// An ink feature that displays a [color] "splash" in response to a user
    /// gesture that can be confirmed or canceled.
    ///
    /// Subclasses call [confirm] when an input gesture is recognized. For
    /// example a press event might trigger an ink feature that's confirmed
    /// when the corresponding up event is seen.
    ///
    /// Subclasses call [cancel] when an input gesture is aborted before it
    /// is recognized. For example a press event might trigger an ink feature
    /// that's canceled when the pointer is dragged out of the reference
    /// box.
    ///
    /// The [InkWell] and [InkResponse] widgets generate instances of this
    /// class.
    /// </Summary>
    public class InteractiveInkFeature : FlutterSDK.Material.Material.InkFeature
    {
        #region constructors
        public InteractiveInkFeature(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), VoidCallback onRemoved = default(VoidCallback))
        : base(controller: controller, referenceBox: referenceBox, onRemoved: onRemoved)
    
}
    #endregion

    #region fields
    internal virtual FlutterBinding.UI.Color _Color { get; set; }
    public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Called when the user input that triggered this feature's appearance was confirmed.
    ///
    /// Typically causes the ink to propagate faster across the material. By default this
    /// method does nothing.
    /// </Summary>
    public virtual void Confirm()
    {
    }




    /// <Summary>
    /// Called when the user input that triggered this feature's appearance was canceled.
    ///
    /// Typically causes the ink to gradually disappear. By default this method does
    /// nothing.
    /// </Summary>
    public virtual void Cancel()
    {
    }




    /// <Summary>
    /// Draws an ink splash or ink ripple on the passed in [Canvas].
    ///
    /// The [transform] argument is the [Matrix4] transform that typically
    /// shifts the coordinate space of the canvas to the space in which
    /// the ink circle is to be painted.
    ///
    /// [center] is the [Offset] from origin of the canvas where the center
    /// of the circle is drawn.
    ///
    /// [paint] takes a [Paint] object that describes the styles used to draw the ink circle.
    /// For example, [paint] can specify properties like color, strokewidth, colorFilter.
    ///
    /// [radius] is the radius of ink circle to be drawn on canvas.
    ///
    /// [clipCallback] is the callback used to obtain the [Rect] used for clipping the ink effect.
    /// If [clipCallback] is null, no clipping is performed on the ink circle.
    ///
    /// Clipping can happen in 3 different ways -
    ///  1. If [customBorder] is provided, it is used to determine the path
    ///     for clipping.
    ///  2. If [customBorder] is null, and [borderRadius] is provided, the canvas
    ///     is clipped by an [RRect] created from [clipCallback] and [borderRadius].
    ///  3. If [borderRadius] is the default [BorderRadius.zero], then the [Rect] provided
    ///      by [clipCallback] is used for clipping.
    ///
    /// [textDirection] is used by [customBorder] if it is non-null. This allows the [customBorder]'s path
    /// to be properly defined if it was the path was expressed in terms of "start" and "end" instead of
    /// "left" and "right".
    ///
    /// For examples on how the function is used, see [InkSplash] and [InkRipple].
    /// </Summary>
    public virtual void PaintInkCircle(Canvas canvas = default(Canvas), Matrix4 transform = default(Matrix4), SKPaint paint = default(SKPaint), FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset), double radius = default(double), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Material.Material.RectCallback clipCallback = default(FlutterSDK.Material.Material.RectCallback))
    {






        Offset originOffset = MatrixutilsDefaultClass.MatrixUtils.GetAsTranslation(transform);
        canvas.Save();
        if (originOffset == null)
        {
            canvas.Transform(transform.Storage);
        }
        else
        {
            canvas.Translate(originOffset.Dx, originOffset.Dy);
        }

        if (clipCallback != null)
        {
            Rect rect = clipCallback();
            if (customBorder != null)
            {
                canvas.ClipPath(customBorder.GetOuterPath(rect, textDirection: textDirection));
            }
            else if (borderRadius != BorderradiusDefaultClass.BorderRadius.Zero)
            {
                canvas.ClipRRect(RRect.FromRectAndCorners(rect, topLeft: borderRadius.TopLeft, topRight: borderRadius.TopRight, bottomLeft: borderRadius.BottomLeft, bottomRight: borderRadius.BottomRight));
            }
            else
            {
                canvas.ClipRect(rect);
            }

        }

        canvas.DrawCircle(center, radius, paint);
        canvas.Restore();
    }



    #endregion
}


/// <Summary>
/// An encapsulation of an [InteractiveInkFeature] constructor used by
/// [InkWell], [InkResponse], and [ThemeData].
///
/// Interactive ink feature implementations should provide a static const
/// `splashFactory` value that's an instance of this class. The `splashFactory`
/// can be used to configure an [InkWell], [InkResponse] or [ThemeData].
///
/// See also:
///
///  * [InkSplash.splashFactory]
///  * [InkRipple.splashFactory]
/// </Summary>
public class InteractiveInkFeatureFactory
{
    #region constructors
    public InteractiveInkFeatureFactory()

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// The factory method.
///
/// Subclasses should override this method to return a new instance of an
/// [InteractiveInkFeature].
/// </Summary>
public virtual FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), bool containedInkWell = false, FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), double radius = default(double), VoidCallback onRemoved = default(VoidCallback))
{
    return default(InteractiveInkFeature);
}

#endregion
}


/// <Summary>
/// An area of a [Material] that responds to touch. Has a configurable shape and
/// can be configured to clip splashes that extend outside its bounds or not.
///
/// For a variant of this widget that is specialized for rectangular areas that
/// always clip splashes, see [InkWell].
///
/// An [InkResponse] widget does two things when responding to a tap:
///
///  * It starts to animate a _highlight_. The shape of the highlight is
///    determined by [highlightShape]. If it is a [BoxShape.circle], the
///    default, then the highlight is a circle of fixed size centered in the
///    [InkResponse]. If it is [BoxShape.rectangle], then the highlight is a box
///    the size of the [InkResponse] itself, unless [getRectCallback] is
///    provided, in which case that callback defines the rectangle. The color of
///    the highlight is set by [highlightColor].
///
///  * Simultaneously, it starts to animate a _splash_. This is a growing circle
///    initially centered on the tap location. If this is a [containedInkWell],
///    the splash grows to the [radius] while remaining centered at the tap
///    location. Otherwise, the splash migrates to the center of the box as it
///    grows.
///
/// The following two diagrams show how [InkResponse] looks when tapped if the
/// [highlightShape] is [BoxShape.circle] (the default) and [containedInkWell]
/// is false (also the default).
///
/// The first diagram shows how it looks if the [InkResponse] is relatively
/// large:
///
/// ![The highlight is a disc centered in the box, smaller than the child widget.](https://flutter.github.io/assets-for-api-docs/assets/material/ink_response_large.png)
///
/// The second diagram shows how it looks if the [InkResponse] is small:
///
/// ![The highlight is a disc overflowing the box, centered on the child.](https://flutter.github.io/assets-for-api-docs/assets/material/ink_response_small.png)
///
/// The main thing to notice from these diagrams is that the splashes happily
/// exceed the bounds of the widget (because [containedInkWell] is false).
///
/// The following diagram shows the effect when the [InkResponse] has a
/// [highlightShape] of [BoxShape.rectangle] with [containedInkWell] set to
/// true. These are the values used by [InkWell].
///
/// ![The highlight is a rectangle the size of the box.](https://flutter.github.io/assets-for-api-docs/assets/material/ink_well.png)
///
/// The [InkResponse] widget must have a [Material] widget as an ancestor. The
/// [Material] widget is where the ink reactions are actually painted. This
/// matches the material design premise wherein the [Material] is what is
/// actually reacting to touches by spreading ink.
///
/// If a Widget uses this class directly, it should include the following line
/// at the top of its build function to call [debugCheckHasMaterial]:
///
/// ```dart
/// assert(debugCheckHasMaterial(context));
/// ```
///
/// ## Troubleshooting
///
/// ### The ink splashes aren't visible!
///
/// If there is an opaque graphic, e.g. painted using a [Container], [Image], or
/// [DecoratedBox], between the [Material] widget and the [InkResponse] widget,
/// then the splash won't be visible because it will be under the opaque graphic.
/// This is because ink splashes draw on the underlying [Material] itself, as
/// if the ink was spreading inside the material.
///
/// The [Ink] widget can be used as a replacement for [Image], [Container], or
/// [DecoratedBox] to ensure that the image or decoration also paints in the
/// [Material] itself, below the ink.
///
/// If this is not possible for some reason, e.g. because you are using an
/// opaque [CustomPaint] widget, alternatively consider using a second
/// [Material] above the opaque widget but below the [InkResponse] (as an
/// ancestor to the ink response). The [MaterialType.transparency] material
/// kind can be used for this purpose.
///
/// See also:
///
///  * [GestureDetector], for listening for gestures without ink splashes.
///  * [RaisedButton] and [FlatButton], two kinds of buttons in material design.
///  * [IconButton], which combines [InkResponse] with an [Icon].
/// </Summary>
public class InkResponse : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public InkResponse(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHover = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), bool containedInkWell = false, FlutterSDK.Painting.Boxborder.BoxShape highlightShape = default(FlutterSDK.Painting.Boxborder.BoxShape), double radius = default(double), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), bool enableFeedback = true, bool excludeFromSemantics = false, FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool canRequestFocus = true, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), bool autofocus = false)
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnTapDown { get; set; }
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTapCancel { get; set; }
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnDoubleTap { get; set; }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnHighlightChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnHover { get; set; }
public virtual bool ContainedInkWell { get; set; }
public virtual FlutterSDK.Painting.Boxborder.BoxShape HighlightShape { get; set; }
public virtual double Radius { get; set; }
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder CustomBorder { get; set; }
public virtual FlutterBinding.UI.Color FocusColor { get; set; }
public virtual FlutterBinding.UI.Color HoverColor { get; set; }
public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
public virtual FlutterBinding.UI.Color SplashColor { get; set; }
public virtual FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory SplashFactory { get; set; }
public virtual bool EnableFeedback { get; set; }
public virtual bool ExcludeFromSemantics { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnFocusChange { get; set; }
public virtual bool Autofocus { get; set; }
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
public virtual bool CanRequestFocus { get; set; }
#endregion

#region methods

/// <Summary>
/// The rectangle to use for the highlight effect and for clipping
/// the splash effects if [containedInkWell] is true.
///
/// This method is intended to be overridden by descendants that
/// specialize [InkResponse] for unusual cases. For example,
/// [TableRowInkWell] implements this method to return the rectangle
/// corresponding to the row that the widget is in.
///
/// The default behavior returns null, which is equivalent to
/// returning the referenceBox argument's bounding box (though
/// slightly more efficient).
/// </Summary>
public virtual FlutterSDK.Material.Material.RectCallback GetRectCallback(FlutterSDK.Rendering.Box.RenderBox referenceBox) => null;



/// <Summary>
/// Asserts that the given context satisfies the prerequisites for
/// this class.
///
/// This method is intended to be overridden by descendants that
/// specialize [InkResponse] for unusual cases. For example,
/// [TableRowInkWell] implements this method to verify that the widget is
/// in a table.
/// </Summary>
public virtual bool DebugCheckContext(FlutterSDK.Widgets.Framework.BuildContext context)
{


    return true;
}




public new FlutterSDK.Material.Inkwell._InkResponseState<FlutterSDK.Material.Inkwell.InkResponse> CreateState() => new _InkResponseState<InkResponse>();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    List<string> gestures = new List<string>() { };
    properties.Add(new IterableProperty<string>("gestures", gestures, ifEmpty: "<none>"));
    properties.Add(new DiagnosticsProperty<bool>("containedInkWell", ContainedInkWell, level: DiagnosticLevel.Fine));
    properties.Add(new DiagnosticsProperty<BoxShape>("highlightShape", HighlightShape, description: $"'{ContainedInkWell ? "clipped to ":""}{HighlightShape}'", showName: false));
}



#endregion
}


public class _InkResponseState<T> : FlutterSDK.Widgets.Framework.State<T>, IAutomaticKeepAliveClientMixin<T>
{
    #region constructors
    public _InkResponseState()
    { }
    #endregion

    #region fields
    internal virtual HashSet<FlutterSDK.Material.Inkwell.InteractiveInkFeature> _Splashes { get; set; }
    internal virtual FlutterSDK.Material.Inkwell.InteractiveInkFeature _CurrentSplash { get; set; }
    internal virtual bool _Hovering { get; set; }
    internal virtual Dictionary<FlutterSDK.Material.Inkwell._HighlightType, FlutterSDK.Material.Inkhighlight.InkHighlight> _Highlights { get; set; }
    internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> _ActionMap { get; set; }
    internal virtual bool _HasFocus { get; set; }
    public virtual bool HighlightsExist { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    private void _HandleAction(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
    {
        _StartSplash(context: node.Context);
        _HandleTap(node.Context);
    }




    private FlutterSDK.Widgets.Actions.Action _CreateAction()
    {
        return new CallbackAction(ActionsDefaultClass.ActivateAction.Key, onInvoke: _HandleAction);
    }




    public new void InitState()
    {
        base.InitState();
        _ActionMap = new Dictionary<LocalKey, ActionFactory> { { ActionsDefaultClass.ActivateAction.Key, _CreateAction } };
        FocusmanagerDefaultClass.FocusManager.Instance.AddHighlightModeListener(_HandleFocusHighlightModeChange);
    }




    public new void DidUpdateWidget(T oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        if (_IsWidgetEnabled(Widget) != _IsWidgetEnabled(oldWidget))
        {
            _HandleHoverChange(_Hovering);
            _UpdateFocusHighlights();
        }

    }




    public new void Dispose()
    {
        FocusmanagerDefaultClass.FocusManager.Instance.RemoveHighlightModeListener(_HandleFocusHighlightModeChange);
        base.Dispose();
    }




    public virtual Color GetHighlightColorForType(FlutterSDK.Material.Inkwell._HighlightType type)
    {
        switch (type) { case _HighlightType.Pressed: return Widget.HighlightColor ?? ThemeDefaultClass.Theme.Of(Context).HighlightColor; case _HighlightType.Focus: return Widget.FocusColor ?? ThemeDefaultClass.Theme.Of(Context).FocusColor; case _HighlightType.Hover: return Widget.HoverColor ?? ThemeDefaultClass.Theme.Of(Context).HoverColor; }

        return null;
    }




    public virtual TimeSpan GetFadeDurationForType(FlutterSDK.Material.Inkwell._HighlightType type)
    {
        switch (type) { case _HighlightType.Pressed: return new TimeSpan(milliseconds: 200); case _HighlightType.Hover: case _HighlightType.Focus: return new TimeSpan(milliseconds: 50); }

        return null;
    }




    public virtual void UpdateHighlight(FlutterSDK.Material.Inkwell._HighlightType type, bool value = default(bool))
    {
        InkHighlight highlight = _Highlights[type];
        void HandleInkRemoval() => {

            _Highlights[type] = null;
            UpdateKeepAlive();
        }

        if (value == (highlight != null && highlight.Active)) return;
        if (value)
        {
            if (highlight == null)
            {
                RenderBox referenceBox = Context.FindRenderObject() as RenderBox;
                _Highlights[type] = new InkHighlight(controller: MaterialDefaultClass.Material.Of(Context), referenceBox: referenceBox, color: GetHighlightColorForType(type), shape: Widget.HighlightShape, borderRadius: Widget.BorderRadius, customBorder: Widget.CustomBorder, rectCallback: Widget.GetRectCallback(referenceBox), onRemoved: HandleInkRemoval, textDirection: BasicDefaultClass.Directionality.Of(Context), fadeDuration: GetFadeDurationForType(type));
                UpdateKeepAlive();
            }
            else
            {
                highlight.Activate();
            }

        }
        else
        {
            highlight.Deactivate();
        }


        switch (type) { case _HighlightType.Pressed: if (Widget.OnHighlightChanged != null) Widget.OnHighlightChanged(value); break; case _HighlightType.Hover: if (Widget.OnHover != null) Widget.OnHover(value); break; case _HighlightType.Focus: break; }
    }




    private FlutterSDK.Material.Inkwell.InteractiveInkFeature _CreateInkFeature(FlutterBinding.UI.Offset globalPosition)
    {
        MaterialInkController inkController = MaterialDefaultClass.Material.Of(Context);
        RenderBox referenceBox = Context.FindRenderObject() as RenderBox;
        Offset position = referenceBox.GlobalToLocal(globalPosition);
        Color color = Widget.SplashColor ?? ThemeDefaultClass.Theme.Of(Context).SplashColor;
        RectCallback rectCallback = Widget.ContainedInkWell ? Widget.GetRectCallback(referenceBox) : null;
        BorderRadius borderRadius = Widget.BorderRadius;
        ShapeBorder customBorder = Widget.CustomBorder;
        InteractiveInkFeature splash = default(InteractiveInkFeature);
        void OnRemoved() => {
            if (_Splashes != null)
            {

                _Splashes.Remove(splash);
                if (_CurrentSplash == splash) _CurrentSplash = null;
                UpdateKeepAlive();
            }

        }

        splash = (Widget.SplashFactory ?? ThemeDefaultClass.Theme.Of(Context).SplashFactory).Create(controller: inkController, referenceBox: referenceBox, position: position, color: color, containedInkWell: Widget.ContainedInkWell, rectCallback: rectCallback, radius: Widget.Radius, borderRadius: borderRadius, customBorder: customBorder, onRemoved: OnRemoved, textDirection: BasicDefaultClass.Directionality.Of(Context));
        return splash;
    }




    private void _HandleFocusHighlightModeChange(FlutterSDK.Widgets.Focusmanager.FocusHighlightMode mode)
    {
        if (!Mounted)
        {
            return;
        }

        SetState(() =>
        {
            _UpdateFocusHighlights();
        }
        );
    }




    private void _UpdateFocusHighlights()
    {
        bool showFocus = default(bool);
        switch (FocusmanagerDefaultClass.FocusManager.Instance.HighlightMode) { case FocusHighlightMode.Touch: showFocus = false; break; case FocusHighlightMode.Traditional: showFocus = Enabled && _HasFocus; break; }
        UpdateHighlight(_HighlightType.Focus, value: showFocus);
    }




    private void _HandleFocusUpdate(bool hasFocus)
    {
        _HasFocus = hasFocus;
        _UpdateFocusHighlights();
        if (Widget.OnFocusChange != null)
        {
            Widget.OnFocusChange(hasFocus);
        }

    }




    private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
    {
        _StartSplash(details: details);
        if (Widget.OnTapDown != null)
        {
            Widget.OnTapDown(details);
        }

    }




    private void _StartSplash(FlutterSDK.Gestures.Tap.TapDownDetails details = default(FlutterSDK.Gestures.Tap.TapDownDetails), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext))
    {

        Offset globalPosition = default(Offset);
        if (context != null)
        {
            RenderBox referenceBox = context.FindRenderObject() as RenderBox;

            globalPosition = referenceBox.LocalToGlobal(referenceBox.PaintBounds.Center);
        }
        else
        {
            globalPosition = details.GlobalPosition;
        }

        InteractiveInkFeature splash = _CreateInkFeature(globalPosition);
        _Splashes = (_Splashes == null ? new HashSet<InteractiveInkFeature>() : _Splashes);
        _Splashes.Add(splash);
        _CurrentSplash = splash;
        UpdateKeepAlive();
        UpdateHighlight(_HighlightType.Pressed, value: true);
    }




    private void _HandleTap(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        _CurrentSplash?.Confirm();
        _CurrentSplash = null;
        UpdateHighlight(_HighlightType.Pressed, value: false);
        if (Widget.OnTap != null)
        {
            if (Widget.EnableFeedback) FeedbackDefaultClass.Feedback.ForTap(context);
            Widget.OnTap();
        }

    }




    private void _HandleTapCancel()
    {
        _CurrentSplash?.Cancel();
        _CurrentSplash = null;
        if (Widget.OnTapCancel != null)
        {
            Widget.OnTapCancel();
        }

        UpdateHighlight(_HighlightType.Pressed, value: false);
    }




    private void _HandleDoubleTap()
    {
        _CurrentSplash?.Confirm();
        _CurrentSplash = null;
        if (Widget.OnDoubleTap != null) Widget.OnDoubleTap();
    }




    private void _HandleLongPress(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        _CurrentSplash?.Confirm();
        _CurrentSplash = null;
        if (Widget.OnLongPress != null)
        {
            if (Widget.EnableFeedback) FeedbackDefaultClass.Feedback.ForLongPress(context);
            Widget.OnLongPress();
        }

    }




    public new void Deactivate()
    {
        if (_Splashes != null)
        {
            HashSet<InteractiveInkFeature> splashes = _Splashes;
            _Splashes = null;
            foreach (InteractiveInkFeature splash in splashes) splash.Dispose();
            _CurrentSplash = null;
        }


        foreach (_HighlightType highlight in _Highlights.Keys)
        {
            _Highlights[highlight]?.Dispose();
            _Highlights[highlight] = null;
        }

        base.Deactivate();
    }




    private bool _IsWidgetEnabled(FlutterSDK.Material.Inkwell.InkResponse widget)
    {
        return widget.OnTap != null || widget.OnDoubleTap != null || widget.OnLongPress != null;
    }




    private void _HandleMouseEnter(FlutterSDK.Gestures.Events.PointerEnterEvent @event) => _HandleHoverChange(true);



    private void _HandleMouseExit(FlutterSDK.Gestures.Events.PointerExitEvent @event) => _HandleHoverChange(false);



    private void _HandleHoverChange(bool hovering)
    {
        if (_Hovering != hovering)
        {
            _Hovering = hovering;
            UpdateHighlight(_HighlightType.Hover, value: Enabled && _Hovering);
        }

    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {

        base.Build(context);
        foreach (_HighlightType type in _Highlights.Keys)
        {
            _Highlights[type]?.Color = GetHighlightColorForType(type);
        }

        _CurrentSplash?.Color = Widget.SplashColor ?? ThemeDefaultClass.Theme.Of(context).SplashColor;
        bool canRequestFocus = Enabled && Widget.CanRequestFocus;
        return new Actions(actions: _ActionMap, child: new Focus(focusNode: Widget.FocusNode, canRequestFocus: canRequestFocus, onFocusChange: _HandleFocusUpdate, autofocus: Widget.Autofocus, child: new MouseRegion(onEnter: Enabled ? _HandleMouseEnter : null, onExit: Enabled ? _HandleMouseExit : null, child: new GestureDetector(onTapDown: Enabled ? _HandleTapDown : null, onTap: Enabled ? () => =>_HandleTap(context):null, onTapCancel: Enabled ? _HandleTapCancel : null, onDoubleTap: Widget.OnDoubleTap != null ? _HandleDoubleTap : null, onLongPress: Widget.OnLongPress != null ? () => =>_HandleLongPress(context):null, behavior: HitTestBehavior.Opaque, excludeFromSemantics: Widget.ExcludeFromSemantics, child: Widget.Child))));
    }



    #endregion
}


/// <Summary>
/// A rectangular area of a [Material] that responds to touch.
///
/// For a variant of this widget that does not clip splashes, see [InkResponse].
///
/// The following diagram shows how an [InkWell] looks when tapped, when using
/// default values.
///
/// ![The highlight is a rectangle the size of the box.](https://flutter.github.io/assets-for-api-docs/assets/material/ink_well.png)
///
/// The [InkWell] widget must have a [Material] widget as an ancestor. The
/// [Material] widget is where the ink reactions are actually painted. This
/// matches the material design premise wherein the [Material] is what is
/// actually reacting to touches by spreading ink.
///
/// If a Widget uses this class directly, it should include the following line
/// at the top of its build function to call [debugCheckHasMaterial]:
///
/// ```dart
/// assert(debugCheckHasMaterial(context));
/// ```
///
/// ## Troubleshooting
///
/// ### The ink splashes aren't visible!
///
/// If there is an opaque graphic, e.g. painted using a [Container], [Image], or
/// [DecoratedBox], between the [Material] widget and the [InkWell] widget, then
/// the splash won't be visible because it will be under the opaque graphic.
/// This is because ink splashes draw on the underlying [Material] itself, as
/// if the ink was spreading inside the material.
///
/// The [Ink] widget can be used as a replacement for [Image], [Container], or
/// [DecoratedBox] to ensure that the image or decoration also paints in the
/// [Material] itself, below the ink.
///
/// If this is not possible for some reason, e.g. because you are using an
/// opaque [CustomPaint] widget, alternatively consider using a second
/// [Material] above the opaque widget but below the [InkWell] (as an
/// ancestor to the ink well). The [MaterialType.transparency] material
/// kind can be used for this purpose.
///
/// ### The ink splashes don't track the size of an animated container
/// If the size of an InkWell's [Material] ancestor changes while the InkWell's
/// splashes are expanding, you may notice that the splashes aren't clipped
/// correctly. This can't be avoided.
///
/// An example of this situation is as follows:
///
/// {@tool dartpad --template=stateful_widget_scaffold_center}
///
/// Tap the container to cause it to grow. Then, tap it again and hold before
/// the widget reaches its maximum size to observe the clipped ink splash.
///
/// ```dart
/// double sideLength = 50;
///
/// Widget build(BuildContext context) {
///   return AnimatedContainer(
///     height: sideLength,
///     width: sideLength,
///     duration: Duration(seconds: 2),
///     curve: Curves.easeIn,
///     child: Material(
///       color: Colors.yellow,
///       child: InkWell(
///         onTap: () {
///           setState(() {
///             sideLength == 50 ? sideLength = 100 : sideLength = 50;
///           });
///         },
///       ),
///     ),
///   );
/// }
/// ```
/// {@end-tool}
///
/// An InkWell's splashes will not properly update to conform to changes if the
/// size of its underlying [Material], where the splashes are rendered, changes
/// during animation. You should avoid using InkWells within [Material] widgets
/// that are changing size.
///
/// See also:
///
///  * [GestureDetector], for listening for gestures without ink splashes.
///  * [RaisedButton] and [FlatButton], two kinds of buttons in material design.
///  * [InkResponse], a variant of [InkWell] that doesn't force a rectangular
///    shape on the ink reaction.
/// </Summary>
public class InkWell : FlutterSDK.Material.Inkwell.InkResponse
{
    #region constructors
    public InkWell(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Tap.GestureTapCancelCallback onTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHover = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), double radius = default(double), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), bool enableFeedback = true, bool excludeFromSemantics = false, FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool canRequestFocus = true, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), bool autofocus = false)
    : base(key: key, child: child, onTap: onTap, onDoubleTap: onDoubleTap, onLongPress: onLongPress, onTapDown: onTapDown, onTapCancel: onTapCancel, onHighlightChanged: onHighlightChanged, onHover: onHover, containedInkWell: true, highlightShape: BoxShape.Rectangle, focusColor: focusColor, hoverColor: hoverColor, highlightColor: highlightColor, splashColor: splashColor, splashFactory: splashFactory, radius: radius, borderRadius: borderRadius, customBorder: customBorder, enableFeedback: enableFeedback ?? true, excludeFromSemantics: excludeFromSemantics ?? false, focusNode: focusNode, canRequestFocus: canRequestFocus ?? true, onFocusChange: onFocusChange, autofocus: autofocus ?? false)

}
#endregion

#region fields
#endregion

#region methods
#endregion
}


/// <Summary>
/// Used to index the allocated highlights for the different types of highlights
/// in [_InkResponseState].
/// </Summary>
public enum _HighlightType
{

    Pressed,
    Hover,
    Focus,
}

}
