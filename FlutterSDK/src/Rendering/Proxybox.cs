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
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Rendering.Proxybox
{
    public delegate SKShader ShaderCallback(FlutterBinding.UI.Rect bounds);
    public delegate void PointerDownEventListener(FlutterSDK.Gestures.Events.PointerDownEvent @event);
    public delegate void PointerMoveEventListener(FlutterSDK.Gestures.Events.PointerMoveEvent @event);
    public delegate void PointerUpEventListener(FlutterSDK.Gestures.Events.PointerUpEvent @event);
    public delegate void PointerCancelEventListener(FlutterSDK.Gestures.Events.PointerCancelEvent @event);
    public delegate void PointerSignalEventListener(FlutterSDK.Gestures.Events.PointerSignalEvent @event);
    internal static class ProxyboxDefaultClass
    {
    }

    /// <Summary>
    /// A RenderProxyBox subclass that allows you to customize the
    /// hit-testing behavior.
    /// </Summary>
    public interface IRenderProxyBoxWithHitTestBehavior
    {
        bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
        bool HitTestSelf(FlutterBinding.UI.Offset position);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
    }


    /// <Summary>
    /// An interface for providing custom clips.
    ///
    /// This class is used by a number of clip widgets (e.g., [ClipRect] and
    /// [ClipPath]).
    ///
    /// The [getClip] method is called whenever the custom clip needs to be updated.
    ///
    /// The [shouldReclip] method is called when a new instance of the class
    /// is provided, to check if the new instance actually represents different
    /// information.
    ///
    /// The most efficient way to update the clip provided by this class is to
    /// supply a `reclip` argument to the constructor of the [CustomClipper]. The
    /// custom object will listen to this animation and update the clip whenever the
    /// animation ticks, avoiding both the build and layout phases of the pipeline.
    ///
    /// See also:
    ///
    ///  * [ClipRect], which can be customized with a [CustomClipper<Rect>].
    ///  * [ClipRRect], which can be customized with a [CustomClipper<RRect>].
    ///  * [ClipOval], which can be customized with a [CustomClipper<Rect>].
    ///  * [ClipPath], which can be customized with a [CustomClipper<Path>].
    ///  * [ShapeBorderClipper], for specifying a clip path using a [ShapeBorder].
    /// </Summary>
    public interface ICustomClipper<T>
    {
        T GetClip(Size size);
        Rect GetApproximateClipRect(Size size);
        bool ShouldReclip(FlutterSDK.Rendering.Proxybox.CustomClipper<T> oldClipper);
        string ToString();
    }


    internal interface I_RenderCustomClip<T>
    {
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void Detach();
        void PerformLayout();
        Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child);
        void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        FlutterSDK.Rendering.Proxybox.CustomClipper<T> Clipper { get; set; }
        FlutterBinding.UI.Clip ClipBehavior { get; set; }
    }


    /// <Summary>
    /// A physical model layer casts a shadow based on its [elevation].
    ///
    /// The concrete implementations [RenderPhysicalModel] and [RenderPhysicalShape]
    /// determine the actual shape of the physical model.
    /// </Summary>
    internal interface I_RenderPhysicalModelBase<T>
    {
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description);
        double Elevation { get; set; }
        FlutterBinding.UI.Color ShadowColor { get; set; }
        FlutterBinding.UI.Color Color { get; set; }
        bool AlwaysNeedsCompositing { get; }
    }


    public interface IRenderProxyBoxMixin<T> { }

    public class RenderProxyBoxMixin<T>
    {

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is ParentData)) child.ParentData = new ParentData();
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            if (Child != null) return Child.GetMinIntrinsicWidth(height);
            return 0.0;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            if (Child != null) return Child.GetMaxIntrinsicWidth(height);
            return 0.0;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            if (Child != null) return Child.GetMinIntrinsicHeight(width);
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            if (Child != null) return Child.GetMaxIntrinsicHeight(width);
            return 0.0;
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {
            if (Child != null) return Child.GetDistanceToActualBaseline(baseline);
            return base.ComputeDistanceToActualBaseline(baseline);
        }




        public new void PerformLayout()
        {
            if (Child != null)
            {
                Child.Layout(Constraints, parentUsesSize: true);
                Size = Child.Size;
            }
            else
            {
                PerformResize();
            }

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            return Child?.HitTest(result, position: position) ?? false;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child != null) context.PaintChild(Child, offset);
        }



    }
    public static class RenderProxyBoxMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static RenderProxyBoxMixin<T> GetOrCreate<T>(IRenderProxyBoxMixin<T> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderProxyBoxMixin<T>();
                _table.Add(instance, value);
            }
            return (RenderProxyBoxMixin<T>)value;
        }
        public static void SetupParentData<T>(this IRenderProxyBoxMixin<T> instance, FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).SetupParentData(child);
        public static double ComputeMinIntrinsicWidth<T>(this IRenderProxyBoxMixin<T> instance, double height) => GetOrCreate(instance).ComputeMinIntrinsicWidth(height);
        public static double ComputeMaxIntrinsicWidth<T>(this IRenderProxyBoxMixin<T> instance, double height) => GetOrCreate(instance).ComputeMaxIntrinsicWidth(height);
        public static double ComputeMinIntrinsicHeight<T>(this IRenderProxyBoxMixin<T> instance, double width) => GetOrCreate(instance).ComputeMinIntrinsicHeight(width);
        public static double ComputeMaxIntrinsicHeight<T>(this IRenderProxyBoxMixin<T> instance, double width) => GetOrCreate(instance).ComputeMaxIntrinsicHeight(width);
        public static double ComputeDistanceToActualBaseline<T>(this IRenderProxyBoxMixin<T> instance, TextBaseline baseline) => GetOrCreate(instance).ComputeDistanceToActualBaseline(baseline);
        public static void PerformLayout<T>(this IRenderProxyBoxMixin<T> instance) => GetOrCreate(instance).PerformLayout();
        public static bool HitTestChildren<T>(this IRenderProxyBoxMixin<T> instance, FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => GetOrCreate(instance).HitTestChildren(result, position);
        public static void ApplyPaintTransform<T>(this IRenderProxyBoxMixin<T> instance, FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) => GetOrCreate(instance).ApplyPaintTransform(child, transform);
        public static void Paint<T>(this IRenderProxyBoxMixin<T> instance, FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) => GetOrCreate(instance).Paint(context, offset);
    }


    public interface IRenderAnimatedOpacityMixin<T> { }

    public class RenderAnimatedOpacityMixin<T>
    {
        internal virtual int _Alpha { get; set; }
        internal virtual bool _CurrentlyNeedsCompositing { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Opacity { get; set; }
        internal virtual bool _AlwaysIncludeSemantics { get; set; }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Opacity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysIncludeSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            _Opacity.AddListener(_UpdateOpacity);
            _UpdateOpacity();
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            _Opacity.AddListener(_UpdateOpacity);
            _UpdateOpacity();
        }




        public new void Detach()
        {
            _Opacity.RemoveListener(_UpdateOpacity);
            base.Detach();
        }




        private void _UpdateOpacity()
        {
            int oldAlpha = _Alpha;
            _Alpha = Ui.Dart:uiDefaultClass.Color.GetAlphaFromOpacity(_Opacity.Value);
            if (oldAlpha != _Alpha)
            {
                bool didNeedCompositing = _CurrentlyNeedsCompositing;
                _CurrentlyNeedsCompositing = _Alpha > 0 && _Alpha < 255;
                if (Child != null && didNeedCompositing != _CurrentlyNeedsCompositing) MarkNeedsCompositingBitsUpdate();
                MarkNeedsPaint();
                if (oldAlpha == 0 || _Alpha == 0) MarkNeedsSemanticsUpdate();
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child != null)
            {
                if (_Alpha == 0)
                {
                    Layer = null;
                    return;
                }

                if (_Alpha == 255)
                {
                    Layer = null;
                    context.PaintChild(Child, offset);
                    return;
                }


                Layer = context.PushOpacity(offset, _Alpha, base.Paint, oldLayer: Layer as OpacityLayer);
            }

        }




        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            if (Child != null && (_Alpha != 0 || AlwaysIncludeSemantics)) visitor(Child);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Animation<double>>("opacity", Opacity));
            properties.Add(new FlagProperty("alwaysIncludeSemantics", value: AlwaysIncludeSemantics, ifTrue: "alwaysIncludeSemantics"));
        }



    }
    public static class RenderAnimatedOpacityMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static RenderAnimatedOpacityMixin<T> GetOrCreate<T>(IRenderAnimatedOpacityMixin<T> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderAnimatedOpacityMixin<T>();
                _table.Add(instance, value);
            }
            return (RenderAnimatedOpacityMixin<T>)value;
        }
        public static bool AlwaysNeedsCompositingProperty<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).AlwaysNeedsCompositing;
        public static FlutterSDK.Animation.Animation.Animation<double> OpacityProperty<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).Opacity;
        public static bool AlwaysIncludeSemanticsProperty<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).AlwaysIncludeSemantics;
        public static void Attach<T>(this IRenderAnimatedOpacityMixin<T> instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).Detach();
        public static void Paint<T>(this IRenderAnimatedOpacityMixin<T> instance, FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) => GetOrCreate(instance).Paint(context, offset);
        public static void VisitChildrenForSemantics<T>(this IRenderAnimatedOpacityMixin<T> instance, FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) => GetOrCreate(instance).VisitChildrenForSemantics(visitor);
        public static void DebugFillProperties<T>(this IRenderAnimatedOpacityMixin<T> instance, FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) => GetOrCreate(instance).DebugFillProperties(properties);
    }


    /// <Summary>
    /// A base class for render boxes that resemble their children.
    ///
    /// A proxy box has a single child and simply mimics all the properties of that
    /// child by calling through to the child for each function in the render box
    /// protocol. For example, a proxy box determines its size by asking its child
    /// to layout with the same constraints and then matching the size.
    ///
    /// A proxy box isn't useful on its own because you might as well just replace
    /// the proxy box with its child. However, RenderProxyBox is a useful base class
    /// for render objects that wish to mimic most, but not all, of the properties
    /// of their child.
    ///
    /// See also:
    ///
    ///  * [RenderProxySliver], a base class for render slivers that resemble their
    ///    children.
    /// </Summary>
    public class RenderProxyBox : FlutterSDK.Rendering.Box.RenderBox, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>, IRenderProxyBoxMixin<FlutterSDK.Rendering.Box.RenderBox>
    {
        #region constructors
        public RenderProxyBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    
this .Child=child;
}


    #endregion

    #region fields
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// A RenderProxyBox subclass that allows you to customize the
/// hit-testing behavior.
/// </Summary>
public class RenderProxyBoxWithHitTestBehavior : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderProxyBoxWithHitTestBehavior(FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    bool hitTarget = false;
    if (Size.Contains(position))
    {
        hitTarget = HitTestChildren(result, position: position) || HitTestSelf(position);
        if (hitTarget || Behavior == HitTestBehavior.Translucent) result.Add(new BoxHitTestEntry(this, position));
    }

    return hitTarget;
}




public new bool HitTestSelf(FlutterBinding.UI.Offset position) => Behavior == HitTestBehavior.Opaque;



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new EnumProperty<HitTestBehavior>("behavior", Behavior, defaultValue: null));
}



#endregion
}


/// <Summary>
/// Imposes additional constraints on its child.
///
/// A render constrained box proxies most functions in the render box protocol
/// to its child, except that when laying out its child, it tightens the
/// constraints provided by its parent by enforcing the [additionalConstraints]
/// as well.
///
/// For example, if you wanted [child] to have a minimum height of 50.0 logical
/// pixels, you could use `const BoxConstraints(minHeight: 50.0)` as the
/// [additionalConstraints].
/// </Summary>
public class RenderConstrainedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderConstrainedBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints))
    : base(child)

}
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Box.BoxConstraints _AdditionalConstraints { get; set; }
public virtual FlutterSDK.Rendering.Box.BoxConstraints AdditionalConstraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height)
{
    if (_AdditionalConstraints.HasBoundedWidth && _AdditionalConstraints.HasTightWidth) return _AdditionalConstraints.MinWidth;
    double width = base.ComputeMinIntrinsicWidth(height);

    if (!_AdditionalConstraints.HasInfiniteWidth) return _AdditionalConstraints.ConstrainWidth(width);
    return width;
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    if (_AdditionalConstraints.HasBoundedWidth && _AdditionalConstraints.HasTightWidth) return _AdditionalConstraints.MinWidth;
    double width = base.ComputeMaxIntrinsicWidth(height);

    if (!_AdditionalConstraints.HasInfiniteWidth) return _AdditionalConstraints.ConstrainWidth(width);
    return width;
}




public new double ComputeMinIntrinsicHeight(double width)
{
    if (_AdditionalConstraints.HasBoundedHeight && _AdditionalConstraints.HasTightHeight) return _AdditionalConstraints.MinHeight;
    double height = base.ComputeMinIntrinsicHeight(width);

    if (!_AdditionalConstraints.HasInfiniteHeight) return _AdditionalConstraints.ConstrainHeight(height);
    return height;
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    if (_AdditionalConstraints.HasBoundedHeight && _AdditionalConstraints.HasTightHeight) return _AdditionalConstraints.MinHeight;
    double height = base.ComputeMaxIntrinsicHeight(width);

    if (!_AdditionalConstraints.HasInfiniteHeight) return _AdditionalConstraints.ConstrainHeight(height);
    return height;
}




public new void PerformLayout()
{
    BoxConstraints constraints = this.Constraints;
    if (Child != null)
    {
        Child.Layout(_AdditionalConstraints.Enforce(constraints), parentUsesSize: true);
        Size = Child.Size;
    }
    else
    {
        Size = _AdditionalConstraints.Enforce(constraints).Constrain(Dart: uiDefaultClass.Size.Zero);
    }

}




public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    base.DebugPaintSize(context, offset);

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<BoxConstraints>("additionalConstraints", AdditionalConstraints));
}



#endregion
}


/// <Summary>
/// Constrains the child's [BoxConstraints.maxWidth] and
/// [BoxConstraints.maxHeight] if they're otherwise unconstrained.
///
/// This has the effect of giving the child a natural dimension in unbounded
/// environments. For example, by providing a [maxHeight] to a widget that
/// normally tries to be as big as possible, the widget will normally size
/// itself to fit its parent, but when placed in a vertical list, it will take
/// on the given height.
///
/// This is useful when composing widgets that normally try to match their
/// parents' size, so that they behave reasonably in lists (which are
/// unbounded).
/// </Summary>
public class RenderLimitedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderLimitedBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double maxWidth = default(double), double maxHeight = default(double))
    : base(child)

}
#endregion

#region fields
internal virtual double _MaxWidth { get; set; }
internal virtual double _MaxHeight { get; set; }
public virtual double MaxWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double MaxHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private FlutterSDK.Rendering.Box.BoxConstraints _LimitConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints)
{
    return new BoxConstraints(minWidth: constraints.MinWidth, maxWidth: constraints.HasBoundedWidth ? constraints.MaxWidth : constraints.ConstrainWidth(MaxWidth), minHeight: constraints.MinHeight, maxHeight: constraints.HasBoundedHeight ? constraints.MaxHeight : constraints.ConstrainHeight(MaxHeight));
}




public new void PerformLayout()
{
    if (Child != null)
    {
        BoxConstraints constraints = this.Constraints;
        Child.Layout(_LimitConstraints(constraints), parentUsesSize: true);
        Size = constraints.Constrain(Child.Size);
    }
    else
    {
        Size = _LimitConstraints(Constraints).Constrain(Dart: uiDefaultClass.Size.Zero);
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("maxWidth", MaxWidth, defaultValue: Dart:coreDefaultClass.Double.Infinity));
    properties.Add(new DoubleProperty("maxHeight", MaxHeight, defaultValue: Dart:coreDefaultClass.Double.Infinity));
}



#endregion
}


/// <Summary>
/// Attempts to size the child to a specific aspect ratio.
///
/// The render object first tries the largest width permitted by the layout
/// constraints. The height of the render object is determined by applying the
/// given aspect ratio to the width, expressed as a ratio of width to height.
///
/// For example, a 16:9 width:height aspect ratio would have a value of
/// 16.0/9.0. If the maximum width is infinite, the initial width is determined
/// by applying the aspect ratio to the maximum height.
///
/// Now consider a second example, this time with an aspect ratio of 2.0 and
/// layout constraints that require the width to be between 0.0 and 100.0 and
/// the height to be between 0.0 and 100.0. We'll select a width of 100.0 (the
/// biggest allowed) and a height of 50.0 (to match the aspect ratio).
///
/// In that same situation, if the aspect ratio is 0.5, we'll also select a
/// width of 100.0 (still the biggest allowed) and we'll attempt to use a height
/// of 200.0. Unfortunately, that violates the constraints because the child can
/// be at most 100.0 pixels tall. The render object will then take that value
/// and apply the aspect ratio again to obtain a width of 50.0. That width is
/// permitted by the constraints and the child receives a width of 50.0 and a
/// height of 100.0. If the width were not permitted, the render object would
/// continue iterating through the constraints. If the render object does not
/// find a feasible size after consulting each constraint, the render object
/// will eventually select a size for the child that meets the layout
/// constraints but fails to meet the aspect ratio constraints.
/// </Summary>
public class RenderAspectRatio : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderAspectRatio(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double aspectRatio = default(double))
    : base(child)

}
#endregion

#region fields
internal virtual double _AspectRatio { get; set; }
public virtual double AspectRatio { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height)
{
    if (height.IsFinite()) return height * _AspectRatio;
    if (Child != null) return Child.GetMinIntrinsicWidth(height);
    return 0.0;
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    if (height.IsFinite()) return height * _AspectRatio;
    if (Child != null) return Child.GetMaxIntrinsicWidth(height);
    return 0.0;
}




public new double ComputeMinIntrinsicHeight(double width)
{
    if (width.IsFinite()) return width / _AspectRatio;
    if (Child != null) return Child.GetMinIntrinsicHeight(width);
    return 0.0;
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    if (width.IsFinite()) return width / _AspectRatio;
    if (Child != null) return Child.GetMaxIntrinsicHeight(width);
    return 0.0;
}




private Size _ApplyAspectRatio(FlutterSDK.Rendering.Box.BoxConstraints constraints)
{


    if (constraints.IsTight) return constraints.Smallest;
    double width = constraints.MaxWidth;
    double height = default(double);
    if (width.IsFinite())
    {
        height = width / _AspectRatio;
    }
    else
    {
        height = constraints.MaxHeight;
        width = height * _AspectRatio;
    }

    if (width > constraints.MaxWidth)
    {
        width = constraints.MaxWidth;
        height = width / _AspectRatio;
    }

    if (height > constraints.MaxHeight)
    {
        height = constraints.MaxHeight;
        width = height * _AspectRatio;
    }

    if (width < constraints.MinWidth)
    {
        width = constraints.MinWidth;
        height = width / _AspectRatio;
    }

    if (height < constraints.MinHeight)
    {
        height = constraints.MinHeight;
        width = height * _AspectRatio;
    }

    return constraints.Constrain(new Size(width, height));
}




public new void PerformLayout()
{
    Size = _ApplyAspectRatio(Constraints);
    if (Child != null) Child.Layout(BoxConstraints.Tight(Size));
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("aspectRatio", AspectRatio));
}



#endregion
}


/// <Summary>
/// Sizes its child to the child's intrinsic width.
///
/// Sizes its child's width to the child's maximum intrinsic width. If
/// [stepWidth] is non-null, the child's width will be snapped to a multiple of
/// the [stepWidth]. Similarly, if [stepHeight] is non-null, the child's height
/// will be snapped to a multiple of the [stepHeight].
///
/// This class is useful, for example, when unlimited width is available and
/// you would like a child that would otherwise attempt to expand infinitely to
/// instead size itself to a more reasonable width.
///
/// This class is relatively expensive, because it adds a speculative layout
/// pass before the final layout phase. Avoid using it where possible. In the
/// worst case, this render object can result in a layout that is O(N²) in the
/// depth of the tree.
/// </Summary>
public class RenderIntrinsicWidth : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderIntrinsicWidth(double stepWidth = default(double), double stepHeight = default(double), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual double _StepWidth { get; set; }
internal virtual double _StepHeight { get; set; }
public virtual double StepWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double StepHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private double _ApplyStep(double input, double step)
{

    if (step == null) return input;
    return (input / step).Ceil() * step;
}




public new double ComputeMinIntrinsicWidth(double height)
{
    return ComputeMaxIntrinsicWidth(height);
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    if (Child == null) return 0.0;
    double width = Child.GetMaxIntrinsicWidth(height);
    return _ApplyStep(width, _StepWidth);
}




public new double ComputeMinIntrinsicHeight(double width)
{
    if (Child == null) return 0.0;
    if (!width.IsFinite()) width = ComputeMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity);

    double height = Child.GetMinIntrinsicHeight(width);
    return _ApplyStep(height, _StepHeight);
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    if (Child == null) return 0.0;
    if (!width.IsFinite()) width = ComputeMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity);

    double height = Child.GetMaxIntrinsicHeight(width);
    return _ApplyStep(height, _StepHeight);
}




public new void PerformLayout()
{
    if (Child != null)
    {
        BoxConstraints childConstraints = Constraints;
        if (!childConstraints.HasTightWidth)
        {
            double width = Child.GetMaxIntrinsicWidth(childConstraints.MaxHeight);

            childConstraints = childConstraints.Tighten(width: _ApplyStep(width, _StepWidth));
        }

        if (_StepHeight != null)
        {
            double height = Child.GetMaxIntrinsicHeight(childConstraints.MaxWidth);

            childConstraints = childConstraints.Tighten(height: _ApplyStep(height, _StepHeight));
        }

        Child.Layout(childConstraints, parentUsesSize: true);
        Size = Child.Size;
    }
    else
    {
        PerformResize();
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("stepWidth", StepWidth));
    properties.Add(new DoubleProperty("stepHeight", StepHeight));
}



#endregion
}


/// <Summary>
/// Sizes its child to the child's intrinsic height.
///
/// This class is useful, for example, when unlimited height is available and
/// you would like a child that would otherwise attempt to expand infinitely to
/// instead size itself to a more reasonable height.
///
/// This class is relatively expensive, because it adds a speculative layout
/// pass before the final layout phase. Avoid using it where possible. In the
/// worst case, this render object can result in a layout that is O(N²) in the
/// depth of the tree.
/// </Summary>
public class RenderIntrinsicHeight : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderIntrinsicHeight(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height)
{
    if (Child == null) return 0.0;
    if (!height.IsFinite()) height = Child.GetMaxIntrinsicHeight(Dart: coreDefaultClass.Double.Infinity);

    return Child.GetMinIntrinsicWidth(height);
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    if (Child == null) return 0.0;
    if (!height.IsFinite()) height = Child.GetMaxIntrinsicHeight(Dart: coreDefaultClass.Double.Infinity);

    return Child.GetMaxIntrinsicWidth(height);
}




public new double ComputeMinIntrinsicHeight(double width)
{
    return ComputeMaxIntrinsicHeight(width);
}




public new void PerformLayout()
{
    if (Child != null)
    {
        BoxConstraints childConstraints = Constraints;
        if (!childConstraints.HasTightHeight)
        {
            double height = Child.GetMaxIntrinsicHeight(childConstraints.MaxWidth);

            childConstraints = childConstraints.Tighten(height: height);
        }

        Child.Layout(childConstraints, parentUsesSize: true);
        Size = Child.Size;
    }
    else
    {
        PerformResize();
    }

}



#endregion
}


/// <Summary>
/// Makes its child partially transparent.
///
/// This class paints its child into an intermediate buffer and then blends the
/// child back into the scene partially transparent.
///
/// For values of opacity other than 0.0 and 1.0, this class is relatively
/// expensive because it requires painting the child into an intermediate
/// buffer. For the value 0.0, the child is simply not painted at all. For the
/// value 1.0, the child is painted immediately without an intermediate buffer.
/// </Summary>
public class RenderOpacity : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderOpacity(double opacity = 1.0, bool alwaysIncludeSemantics = false, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual int _Alpha { get; set; }
internal virtual double _Opacity { get; set; }
internal virtual bool _AlwaysIncludeSemantics { get; set; }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double Opacity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysIncludeSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        if (_Alpha == 0)
        {
            Layer = null;
            return;
        }

        if (_Alpha == 255)
        {
            Layer = null;
            context.PaintChild(Child, offset);
            return;
        }


        Layer = context.PushOpacity(offset, _Alpha, base.Paint, oldLayer: Layer as OpacityLayer);
    }

}




public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    if (Child != null && (_Alpha != 0 || AlwaysIncludeSemantics)) visitor(Child);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("opacity", Opacity));
    properties.Add(new FlagProperty("alwaysIncludeSemantics", value: AlwaysIncludeSemantics, ifTrue: "alwaysIncludeSemantics"));
}



#endregion
}


/// <Summary>
/// Makes its child partially transparent, driven from an [Animation].
///
/// This is a variant of [RenderOpacity] that uses an [Animation<double>] rather
/// than a [double] to control the opacity.
/// </Summary>
public class RenderAnimatedOpacity : FlutterSDK.Rendering.Proxybox.RenderProxyBox, IRenderProxyBoxMixin<FlutterSDK.Rendering.Box.RenderBox>, IRenderAnimatedOpacityMixin<FlutterSDK.Rendering.Box.RenderBox>
{
    #region constructors
    public RenderAnimatedOpacity(FlutterSDK.Animation.Animation.Animation<double> opacity = default(FlutterSDK.Animation.Animation.Animation<double>), bool alwaysIncludeSemantics = false, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

this .Opacity=opacity;
this .AlwaysIncludeSemantics=alwaysIncludeSemantics;
}


#endregion

#region fields
#endregion

#region methods
#endregion
}


/// <Summary>
/// Applies a mask generated by a [Shader] to its child.
///
/// For example, [RenderShaderMask] can be used to gradually fade out the edge
/// of a child by using a [new ui.Gradient.linear] mask.
/// </Summary>
public class RenderShaderMask : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderShaderMask(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Proxybox.ShaderCallback shaderCallback = default(FlutterSDK.Rendering.Proxybox.ShaderCallback), FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode))
    : base(child)

}
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Proxybox.ShaderCallback _ShaderCallback { get; set; }
internal virtual FlutterBinding.UI.BlendMode _BlendMode { get; set; }
public virtual FlutterSDK.Rendering.Layer.ShaderMaskLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Proxybox.ShaderCallback ShaderCallback { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.BlendMode BlendMode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {

        Layer = (Layer == null ? new ShaderMaskLayer() : Layer);
        ..Shader = _ShaderCallback(Dart: uiDefaultClass.Offset.Zero & Size)..MaskRect = offset & Size..BlendMode = _BlendMode;
        context.PushLayer(Layer, base.Paint, offset);
    }
    else
    {
        Layer = null;
    }

}



#endregion
}


/// <Summary>
/// Applies a filter to the existing painted content and then paints [child].
///
/// This effect is relatively expensive, especially if the filter is non-local,
/// such as a blur.
/// </Summary>
public class RenderBackdropFilter : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderBackdropFilter(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), ImageFilter filter = default(ImageFilter))
    : base(child)

}
#endregion

#region fields
internal virtual ImageFilter _Filter { get; set; }
public virtual FlutterSDK.Rendering.Layer.BackdropFilterLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual ImageFilter Filter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {

        Layer = (Layer == null ? new BackdropFilterLayer() : Layer);
        Layer.Filter = _Filter;
        context.PushLayer(Layer, base.Paint, offset);
    }
    else
    {
        Layer = null;
    }

}



#endregion
}


/// <Summary>
/// An interface for providing custom clips.
///
/// This class is used by a number of clip widgets (e.g., [ClipRect] and
/// [ClipPath]).
///
/// The [getClip] method is called whenever the custom clip needs to be updated.
///
/// The [shouldReclip] method is called when a new instance of the class
/// is provided, to check if the new instance actually represents different
/// information.
///
/// The most efficient way to update the clip provided by this class is to
/// supply a `reclip` argument to the constructor of the [CustomClipper]. The
/// custom object will listen to this animation and update the clip whenever the
/// animation ticks, avoiding both the build and layout phases of the pipeline.
///
/// See also:
///
///  * [ClipRect], which can be customized with a [CustomClipper<Rect>].
///  * [ClipRRect], which can be customized with a [CustomClipper<RRect>].
///  * [ClipOval], which can be customized with a [CustomClipper<Rect>].
///  * [ClipPath], which can be customized with a [CustomClipper<Path>].
///  * [ShapeBorderClipper], for specifying a clip path using a [ShapeBorder].
/// </Summary>
public class CustomClipper<T>
{
    #region constructors
    public CustomClipper(FlutterSDK.Foundation.Changenotifier.Listenable reclip = default(FlutterSDK.Foundation.Changenotifier.Listenable))
    : base()

}
#endregion

#region fields
internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Reclip { get; set; }
#endregion

#region methods

/// <Summary>
/// Returns a description of the clip given that the render object being
/// clipped is of the given size.
/// </Summary>
public virtual T GetClip(Size size)
{
    return default(T);
}


/// <Summary>
/// Returns an approximation of the clip returned by [getClip], as
/// an axis-aligned Rect. This is used by the semantics layer to
/// determine whether widgets should be excluded.
///
/// By default, this returns a rectangle that is the same size as
/// the RenderObject. If getClip returns a shape that is roughly the
/// same size as the RenderObject (e.g. it's a rounded rectangle
/// with very small arcs in the corners), then this may be adequate.
/// </Summary>
public virtual Rect GetApproximateClipRect(Size size) => Dart:uiDefaultClass.Offset.Zero & size;



/// <Summary>
/// Called whenever a new instance of the custom clipper delegate class is
/// provided to the clip object, or any time that a new clip object is created
/// with a new instance of the custom painter delegate class (which amounts to
/// the same thing, because the latter is implemented in terms of the former).
///
/// If the new instance represents different information than the old
/// instance, then the method should return true, otherwise it should return
/// false.
///
/// If the method returns false, then the [getClip] call might be optimized
/// away.
///
/// It's possible that the [getClip] method will get called even if
/// [shouldReclip] returns false or if the [shouldReclip] method is never
/// called at all (e.g. if the box changes size).
/// </Summary>
public virtual bool ShouldReclip(FlutterSDK.Rendering.Proxybox.CustomClipper<T> oldClipper)
{
    return default(bool);
}


#endregion
}


/// <Summary>
/// A [CustomClipper] that clips to the outer path of a [ShapeBorder].
/// </Summary>
public class ShapeBorderClipper : FlutterSDK.Rendering.Proxybox.CustomClipper<Path>
{
    #region constructors
    public ShapeBorderClipper(FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), TextDirection textDirection = default(TextDirection))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual TextDirection TextDirection { get; set; }
#endregion

#region methods

/// <Summary>
/// Returns the outer path of [shape] as the clip.
/// </Summary>
public new Path GetClip(Size size)
{
    return Shape.GetOuterPath(Dart: uiDefaultClass.Offset.Zero & size, textDirection: TextDirection);
}




public new bool ShouldReclip(FlutterSDK.Rendering.Proxybox.CustomClipper<Path> oldClipper)
{
    if (oldClipper.GetType() != ProxyboxDefaultClass.ShapeBorderClipper) return true;
    ShapeBorderClipper typedOldClipper = oldClipper as ShapeBorderClipper;
    return typedOldClipper.Shape != Shape || typedOldClipper.TextDirection != TextDirection;
}



#endregion
}


public class _RenderCustomClip<T> : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public _RenderCustomClip(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Proxybox.CustomClipper<T> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<T>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base(child)

}
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Proxybox.CustomClipper<T> _Clipper { get; set; }
internal virtual T _Clip { get; set; }
internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
internal virtual SKPaint _DebugPaint { get; set; }
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _DebugText { get; set; }
public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<T> Clipper { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual T _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    _Clipper?._Reclip?.AddListener(_MarkNeedsClip);
}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    _Clipper?._Reclip?.AddListener(_MarkNeedsClip);
}




public new void Detach()
{
    _Clipper?._Reclip?.RemoveListener(_MarkNeedsClip);
    base.Detach();
}




private void _MarkNeedsClip()
{
    _Clip = null;
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




public new void PerformLayout()
{
    Size oldSize = HasSize ? Size : null;
    base.PerformLayout();
    if (oldSize != Size) _Clip = null;
}




private void _UpdateClip()
{
    _Clip = (_Clip == null ? _Clipper?.GetClip(Size) ?? _DefaultClip : _Clip);
}




public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child)
{
    return _Clipper?.GetApproximateClipRect(Size) ?? Dart:uiDefaultClass.Offset.Zero & Size;
}




public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

}



#endregion
}


/// <Summary>
/// Clips its child using a rectangle.
///
/// By default, [RenderClipRect] prevents its child from painting outside its
/// bounds, but the size and location of the clip rect can be customized using a
/// custom [clipper].
/// </Summary>
public class RenderClipRect : FlutterSDK.Rendering.Proxybox._RenderCustomClip<Rect>
{
    #region constructors
    public RenderClipRect(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base(child: child, clipper: clipper, clipBehavior: clipBehavior)

}
#endregion

#region fields
internal virtual FlutterBinding.UI.Rect _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (_Clipper != null)
    {
        _UpdateClip();

        if (!_Clip.Contains(position)) return false;
    }

    return base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        _UpdateClip();
        Layer = context.PushClipRect(NeedsCompositing, offset, _Clip, base.Paint, clipBehavior: ClipBehavior, oldLayer: Layer as ClipRectLayer);
    }
    else
    {
        Layer = null;
    }

}




public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

}



#endregion
}


/// <Summary>
/// Clips its child using a rounded rectangle.
///
/// By default, [RenderClipRRect] uses its own bounds as the base rectangle for
/// the clip, but the size and location of the clip can be customized using a
/// custom [clipper].
/// </Summary>
public class RenderClipRRect : FlutterSDK.Rendering.Proxybox._RenderCustomClip<RRect>
{
    #region constructors
    public RenderClipRRect(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Rendering.Proxybox.CustomClipper<RRect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<RRect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base(child: child, clipper: clipper, clipBehavior: clipBehavior)


}


#endregion

#region fields
internal virtual FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius { get; set; }
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual FlutterBinding.UI.RRect _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (_Clipper != null)
    {
        _UpdateClip();

        if (!_Clip.Contains(position)) return false;
    }

    return base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        _UpdateClip();
        Layer = context.PushClipRRect(NeedsCompositing, offset, _Clip.OuterRect, _Clip, base.Paint, clipBehavior: ClipBehavior, oldLayer: Layer as ClipRRectLayer);
    }
    else
    {
        Layer = null;
    }

}




public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

}



#endregion
}


/// <Summary>
/// Clips its child using an oval.
///
/// By default, inscribes an axis-aligned oval into its layout dimensions and
/// prevents its child from painting outside that oval, but the size and
/// location of the clip oval can be customized using a custom [clipper].
/// </Summary>
public class RenderClipOval : FlutterSDK.Rendering.Proxybox._RenderCustomClip<Rect>
{
    #region constructors
    public RenderClipOval(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base(child: child, clipper: clipper, clipBehavior: clipBehavior)

}
#endregion

#region fields
internal virtual FlutterBinding.UI.Rect _CachedRect { get; set; }
internal virtual Path _CachedPath { get; set; }
internal virtual FlutterBinding.UI.Rect _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private Path _GetClipPath(FlutterBinding.UI.Rect rect)
{
    if (rect != _CachedRect)
    {
        _CachedRect = rect;
        _CachedPath = new Path();
        new Path().AddOval(_CachedRect);
    }

    return _CachedPath;
}




public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    _UpdateClip();

    Offset center = _Clip.Center;
    Offset offset = new Offset((position.Dx - center.Dx) / _Clip.Width, (position.Dy - center.Dy) / _Clip.Height);
    if (offset.DistanceSquared > 0.25) return false;
    return base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        _UpdateClip();
        Layer = context.PushClipPath(NeedsCompositing, offset, _Clip, _GetClipPath(_Clip), base.Paint, clipBehavior: ClipBehavior, oldLayer: Layer as ClipPathLayer);
    }
    else
    {
        Layer = null;
    }

}




public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

}



#endregion
}


/// <Summary>
/// Clips its child using a path.
///
/// Takes a delegate whose primary method returns a path that should
/// be used to prevent the child from painting outside the path.
///
/// Clipping to a path is expensive. Certain shapes have more
/// optimized render objects:
///
///  * To clip to a rectangle, consider [RenderClipRect].
///  * To clip to an oval or circle, consider [RenderClipOval].
///  * To clip to a rounded rectangle, consider [RenderClipRRect].
/// </Summary>
public class RenderClipPath : FlutterSDK.Rendering.Proxybox._RenderCustomClip<Path>
{
    #region constructors
    public RenderClipPath(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base(child: child, clipper: clipper, clipBehavior: clipBehavior)

}
#endregion

#region fields
internal virtual Path _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (_Clipper != null)
    {
        _UpdateClip();

        if (!_Clip.Contains(position)) return false;
    }

    return base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        _UpdateClip();
        Layer = context.PushClipPath(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, _Clip, base.Paint, clipBehavior: ClipBehavior, oldLayer: Layer as ClipPathLayer);
    }
    else
    {
        Layer = null;
    }

}




public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

}



#endregion
}


/// <Summary>
/// A physical model layer casts a shadow based on its [elevation].
///
/// The concrete implementations [RenderPhysicalModel] and [RenderPhysicalShape]
/// determine the actual shape of the physical model.
/// </Summary>
public class _RenderPhysicalModelBase<T> : FlutterSDK.Rendering.Proxybox._RenderCustomClip<T>
{
    #region constructors
    public _RenderPhysicalModelBase(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), double elevation = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Proxybox.CustomClipper<T> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<T>))
    : base(child: child, clipBehavior: clipBehavior, clipper: clipper)

}
#endregion

#region fields
internal virtual double _Elevation { get; set; }
internal virtual FlutterBinding.UI.Color _ShadowColor { get; set; }
internal virtual FlutterBinding.UI.Color _Color { get; set; }
public virtual double Elevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color ShadowColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    config.Elevation = Elevation;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
{
    base.DebugFillProperties(description);
    description.Add(new DoubleProperty("elevation", Elevation));
    description.Add(new ColorProperty("color", Color));
    description.Add(new ColorProperty("shadowColor", Color));
}



#endregion
}


/// <Summary>
/// Creates a physical model layer that clips its child to a rounded
/// rectangle.
///
/// A physical model layer casts a shadow based on its [elevation].
/// </Summary>
public class RenderPhysicalModel : FlutterSDK.Rendering.Proxybox._RenderPhysicalModelBase<RRect>
{
    #region constructors
    public RenderPhysicalModel(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
    : base(clipBehavior: clipBehavior, child: child, elevation: elevation, color: color, shadowColor: shadowColor)

}
#endregion

#region fields
internal virtual FlutterSDK.Painting.Boxborder.BoxShape _Shape { get; set; }
internal virtual FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius { get; set; }
public virtual FlutterSDK.Rendering.Layer.PhysicalModelLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual FlutterBinding.UI.RRect _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (_Clipper != null)
    {
        _UpdateClip();

        if (!_Clip.Contains(position)) return false;
    }

    return base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        _UpdateClip();
        RRect offsetRRect = _Clip.Shift(offset);
        Rect offsetBounds = offsetRRect.OuterRect;
        Path offsetRRectAsPath = new Path();
        new Path().AddRRect(offsetRRect);
        bool paintShadows = true;

        Layer = (Layer == null ? new PhysicalModelLayer() : Layer);
        ..ClipPath = offsetRRectAsPath..ClipBehavior = ClipBehavior..Elevation = paintShadows ? Elevation : 0.0..Color = Color..ShadowColor = ShadowColor;
        context.PushLayer(Layer, base.Paint, offset, childPaintBounds: offsetBounds);

    }
    else
    {
        Layer = null;
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
{
    base.DebugFillProperties(description);
    description.Add(new DiagnosticsProperty<BoxShape>("shape", Shape));
    description.Add(new DiagnosticsProperty<BorderRadius>("borderRadius", BorderRadius));
}



#endregion
}


/// <Summary>
/// Creates a physical shape layer that clips its child to a [Path].
///
/// A physical shape layer casts a shadow based on its [elevation].
///
/// See also:
///
///  * [RenderPhysicalModel], which is optimized for rounded rectangles and
///    circles.
/// </Summary>
public class RenderPhysicalShape : FlutterSDK.Rendering.Proxybox._RenderPhysicalModelBase<Path>
{
    #region constructors
    public RenderPhysicalShape(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
    : base(child: child, elevation: elevation, color: color, shadowColor: shadowColor, clipper: clipper, clipBehavior: clipBehavior)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Layer.PhysicalModelLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual Path _DefaultClip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (_Clipper != null)
    {
        _UpdateClip();

        if (!_Clip.Contains(position)) return false;
    }

    return base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        _UpdateClip();
        Rect offsetBounds = offset & Size;
        Path offsetPath = _Clip.Shift(offset);
        bool paintShadows = true;

        Layer = (Layer == null ? new PhysicalModelLayer() : Layer);
        ..ClipPath = offsetPath..ClipBehavior = ClipBehavior..Elevation = paintShadows ? Elevation : 0.0..Color = Color..ShadowColor = ShadowColor;
        context.PushLayer(Layer, base.Paint, offset, childPaintBounds: offsetBounds);

    }
    else
    {
        Layer = null;
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
{
    base.DebugFillProperties(description);
    description.Add(new DiagnosticsProperty<CustomClipper<Path>>("clipper", Clipper));
}



#endregion
}


/// <Summary>
/// Paints a [Decoration] either before or after its child paints.
/// </Summary>
public class RenderDecoratedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderDecoratedBox(FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Rendering.Proxybox.DecorationPosition position = default(FlutterSDK.Rendering.Proxybox.DecorationPosition), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual FlutterSDK.Painting.Decoration.BoxPainter _Painter { get; set; }
internal virtual FlutterSDK.Painting.Decoration.Decoration _Decoration { get; set; }
internal virtual FlutterSDK.Rendering.Proxybox.DecorationPosition _Position { get; set; }
internal virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration _Configuration { get; set; }
public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Proxybox.DecorationPosition Position { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Configuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Detach()
{
    _Painter?.Dispose();
    _Painter = null;
    base.Detach();
    MarkNeedsPaint();
}




public new bool HitTestSelf(FlutterBinding.UI.Offset position)
{
    return _Decoration.HitTest(Size, position, textDirection: Configuration.TextDirection);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{


    _Painter = (_Painter == null ? _Decoration.CreateBoxPainter(MarkNeedsPaint) : _Painter);
    ImageConfiguration filledConfiguration = Configuration.CopyWith(size: Size);
    if (Position == DecorationPosition.Background)
    {
        int debugSaveCount = default(int);

        _Painter.Paint(context.Canvas, offset, filledConfiguration);

        if (Decoration.IsComplex) context.SetIsComplexHint();
    }

    base.Paint(context, offset);
    if (Position == DecorationPosition.Foreground)
    {
        _Painter.Paint(context.Canvas, offset, filledConfiguration);
        if (Decoration.IsComplex) context.SetIsComplexHint();
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(_Decoration.ToDiagnosticsNode(name: "decoration"));
    properties.Add(new DiagnosticsProperty<ImageConfiguration>("configuration", Configuration));
}



#endregion
}


/// <Summary>
/// Applies a transformation before painting its child.
/// </Summary>
public class RenderTransform : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderTransform(Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), bool transformHitTests = true, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

this .Transform=transform;
this .Alignment=alignment;
this .TextDirection=textDirection;
this .Origin=origin;
}


#endregion

#region fields
internal virtual FlutterBinding.UI.Offset _Origin { get; set; }
internal virtual FlutterSDK.Painting.Alignment.AlignmentGeometry _Alignment { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
public virtual bool TransformHitTests { get; set; }
internal virtual Matrix4 _Transform { get; set; }
public virtual FlutterBinding.UI.Offset Origin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual object Transform { set { throw new NotImplementedException(); } }
internal virtual object _EffectiveTransform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Sets the transform to the identity matrix.
/// </Summary>
public virtual void SetIdentity()
{
    _Transform.SetIdentity();
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




/// <Summary>
/// Concatenates a rotation about the x axis into the transform.
/// </Summary>
public virtual void RotateX(double radians)
{
    _Transform.RotateX(radians);
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




/// <Summary>
/// Concatenates a rotation about the y axis into the transform.
/// </Summary>
public virtual void RotateY(double radians)
{
    _Transform.RotateY(radians);
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




/// <Summary>
/// Concatenates a rotation about the z axis into the transform.
/// </Summary>
public virtual void RotateZ(double radians)
{
    _Transform.RotateZ(radians);
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




/// <Summary>
/// Concatenates a translation by (x, y, z) into the transform.
/// </Summary>
public virtual void Translate(double x, double y = 0.0, double z = 0.0)
{
    _Transform.Translate(x, y, z);
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




/// <Summary>
/// Concatenates a scale into the transform.
/// </Summary>
public virtual void Scale(double x, double y = default(double), double z = default(double))
{
    _Transform.Scale(x, y, z);
    MarkNeedsPaint();
    MarkNeedsSemanticsUpdate();
}




public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return HitTestChildren(result, position: position);
}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{

    return result.AddWithPaintTransform(transform: TransformHitTests ? _EffectiveTransform : null, position: position, hitTest: (BoxHitTestResult result, Offset position) =>
    {
        return base.HitTestChildren(result, position: position);
    }
    );
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Child != null)
    {
        Matrix4 transform = _EffectiveTransform;
        Offset childOffset = MatrixutilsDefaultClass.MatrixUtils.GetAsTranslation(transform);
        if (childOffset == null)
        {
            Layer = context.PushTransform(NeedsCompositing, offset, transform, base.Paint, oldLayer: Layer as TransformLayer);
        }
        else
        {
            base.Paint(context, offset + childOffset);
            Layer = null;
        }

    }

}




public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
{
    transform.Multiply(_EffectiveTransform);
}


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
{
    transform.Multiply(_EffectiveTransform);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new TransformProperty("transform matrix", _Transform));
    properties.Add(new DiagnosticsProperty<Offset>("origin", Origin));
    properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment));
    properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
    properties.Add(new DiagnosticsProperty<bool>("transformHitTests", TransformHitTests));
}



#endregion
}


/// <Summary>
/// Scales and positions its child within itself according to [fit].
/// </Summary>
public class RenderFittedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderFittedBox(FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual FlutterSDK.Painting.Alignment.Alignment _ResolvedAlignment { get; set; }
internal virtual FlutterSDK.Painting.Boxfit.BoxFit _Fit { get; set; }
internal virtual FlutterSDK.Painting.Alignment.AlignmentGeometry _Alignment { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
internal virtual bool _HasVisualOverflow { get; set; }
internal virtual Matrix4 _Transform { get; set; }
public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _Resolve()
{
    if (_ResolvedAlignment != null) return;
    _ResolvedAlignment = Alignment.Resolve(TextDirection);
}




private void _MarkNeedResolution()
{
    _ResolvedAlignment = null;
    MarkNeedsPaint();
}




public new void PerformLayout()
{
    if (Child != null)
    {
        Child.Layout(new BoxConstraints(), parentUsesSize: true);
        Size = Constraints.ConstrainSizeAndAttemptToPreserveAspectRatio(Child.Size);
        _ClearPaintData();
    }
    else
    {
        Size = Constraints.Smallest;
    }

}




private void _ClearPaintData()
{
    _HasVisualOverflow = null;
    _Transform = null;
}




private void _UpdatePaintData()
{
    if (_Transform != null) return;
    if (Child == null)
    {
        _HasVisualOverflow = false;
        _Transform = Matrix4.Identity();
    }
    else
    {
        _Resolve();
        Size childSize = Child.Size;
        FittedSizes sizes = BoxfitDefaultClass.ApplyBoxFit(_Fit, childSize, Size);
        double scaleX = sizes.Destination.Width / sizes.Source.Width;
        double scaleY = sizes.Destination.Height / sizes.Source.Height;
        Rect sourceRect = _ResolvedAlignment.Inscribe(sizes.Source, Dart: uiDefaultClass.Offset.Zero & childSize);
        Rect destinationRect = _ResolvedAlignment.Inscribe(sizes.Destination, Dart: uiDefaultClass.Offset.Zero & Size);
        _HasVisualOverflow = sourceRect.Width < childSize.Width || sourceRect.Height < childSize.Height;

        _Transform = Matrix4.TranslationValues(destinationRect.Left, destinationRect.Top, 0.0);
        Matrix4.TranslationValues(destinationRect.Left, destinationRect.Top, 0.0).Scale(scaleX, scaleY, 1.0);
        Matrix4.TranslationValues(destinationRect.Left, destinationRect.Top, 0.0).Translate(-sourceRect.Left, -sourceRect.Top);

    }

}




private FlutterSDK.Rendering.Layer.TransformLayer _PaintChildWithTransform(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    Offset childOffset = MatrixutilsDefaultClass.MatrixUtils.GetAsTranslation(_Transform);
    if (childOffset == null) return context.PushTransform(NeedsCompositing, offset, _Transform, base.Paint, oldLayer: Layer is TransformLayer ? Layer as TransformLayer : null); else base.Paint(context, offset + childOffset);
    return null;
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Size.IsEmpty() || Child.Size.IsEmpty()) return;
    _UpdatePaintData();
    if (Child != null)
    {
        if (_HasVisualOverflow) ((TransformLayer)Layer) = context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, _PaintChildWithTransform, oldLayer: ((TransformLayer)Layer) is ClipRectLayer ? ((TransformLayer)Layer) as ClipRectLayer : null); else ((TransformLayer)Layer) = _PaintChildWithTransform(context, offset);
    }

}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (Size.IsEmpty() || Child?.Size?.IsEmpty() == true) return false;
    _UpdatePaintData();
    return result.AddWithPaintTransform(transform: _Transform, position: position, hitTest: (BoxHitTestResult result, Offset position) =>
    {
        return base.HitTestChildren(result, position: position);
    }
    );
}




public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
{
    if (Size.IsEmpty() || child.Size.IsEmpty())
    {
        transform.SetZero();
    }
    else
    {
        _UpdatePaintData();
        transform.Multiply(_Transform);
    }

}


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
{
    if (Size.IsEmpty() || child.Size.IsEmpty())
    {
        transform.SetZero();
    }
    else
    {
        _UpdatePaintData();
        transform.Multiply(_Transform);
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new EnumProperty<BoxFit>("fit", Fit));
    properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment));
    properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
}



#endregion
}


/// <Summary>
/// Applies a translation transformation before painting its child.
///
/// The translation is expressed as an [Offset] scaled to the child's size. For
/// example, an [Offset] with a `dx` of 0.25 will result in a horizontal
/// translation of one quarter the width of the child.
///
/// Hit tests will only be detected inside the bounds of the
/// [RenderFractionalTranslation], even if the contents are offset such that
/// they overflow.
/// </Summary>
public class RenderFractionalTranslation : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderFractionalTranslation(FlutterBinding.UI.Offset translation = default(FlutterBinding.UI.Offset), bool transformHitTests = true, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual FlutterBinding.UI.Offset _Translation { get; set; }
public virtual bool TransformHitTests { get; set; }
public virtual FlutterBinding.UI.Offset Translation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return HitTestChildren(result, position: position);
}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{

    return result.AddWithPaintOffset(offset: TransformHitTests ? new Offset(Translation.Dx * Size.Width, Translation.Dy * Size.Height) : null, position: position, hitTest: (BoxHitTestResult result, Offset position) =>
    {
        return base.HitTestChildren(result, position: position);
    }
    );
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

    if (Child != null)
    {
        base.Paint(context, new Offset(offset.Dx + Translation.Dx * Size.Width, offset.Dy + Translation.Dy * Size.Height));
    }

}




public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
{
    transform.Translate(Translation.Dx * Size.Width, Translation.Dy * Size.Height);
}


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
{
    transform.Translate(Translation.Dx * Size.Width, Translation.Dy * Size.Height);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<Offset>("translation", Translation));
    properties.Add(new DiagnosticsProperty<bool>("transformHitTests", TransformHitTests));
}



#endregion
}


/// <Summary>
/// Calls callbacks in response to common pointer events.
///
/// It responds to events that can construct gestures, such as when the
/// pointer is pressed, moved, then released or canceled.
///
/// It does not respond to events that are exclusive to mouse, such as when the
/// mouse enters, exits or hovers a region without pressing any buttons. For
/// these events, use [RenderMouseRegion].
///
/// If it has a child, defers to the child for sizing behavior.
///
/// If it does not have a child, grows to fit the parent-provided constraints.
/// </Summary>
public class RenderPointerListener : FlutterSDK.Rendering.Proxybox.RenderProxyBoxWithHitTestBehavior
{
    #region constructors
    public RenderPointerListener(FlutterSDK.Rendering.Proxybox.PointerDownEventListener onPointerDown = default(FlutterSDK.Rendering.Proxybox.PointerDownEventListener), FlutterSDK.Rendering.Proxybox.PointerMoveEventListener onPointerMove = default(FlutterSDK.Rendering.Proxybox.PointerMoveEventListener), FlutterSDK.Rendering.Proxybox.PointerUpEventListener onPointerUp = default(FlutterSDK.Rendering.Proxybox.PointerUpEventListener), FlutterSDK.Rendering.Proxybox.PointerCancelEventListener onPointerCancel = default(FlutterSDK.Rendering.Proxybox.PointerCancelEventListener), FlutterSDK.Rendering.Proxybox.PointerSignalEventListener onPointerSignal = default(FlutterSDK.Rendering.Proxybox.PointerSignalEventListener), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(behavior: behavior, child: child)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Proxybox.PointerDownEventListener OnPointerDown { get; set; }
public virtual FlutterSDK.Rendering.Proxybox.PointerMoveEventListener OnPointerMove { get; set; }
public virtual FlutterSDK.Rendering.Proxybox.PointerUpEventListener OnPointerUp { get; set; }
public virtual FlutterSDK.Rendering.Proxybox.PointerCancelEventListener OnPointerCancel { get; set; }
public virtual FlutterSDK.Rendering.Proxybox.PointerSignalEventListener OnPointerSignal { get; set; }
#endregion

#region methods

public new void PerformResize()
{
    Size = Constraints.Biggest;
}




public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry)
{

    if (OnPointerDown != null && @event is PointerDownEvent) return OnPointerDown(@event);
    if (OnPointerMove != null && @event is PointerMoveEvent) return OnPointerMove(@event);
    if (OnPointerUp != null && @event is PointerUpEvent) return OnPointerUp(@event);
    if (OnPointerCancel != null && @event is PointerCancelEvent) return OnPointerCancel(@event);
    if (OnPointerSignal != null && @event is PointerSignalEvent) return OnPointerSignal(@event);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new FlagsSummary<Function>("listeners", new Dictionary<string, Function> { { "down", OnPointerDown }{ "move", OnPointerMove }{ "up", OnPointerUp }{ "cancel", OnPointerCancel }{ "signal", OnPointerSignal } }, ifEmpty: "<none>"));
}



#endregion
}


/// <Summary>
/// Calls callbacks in response to pointer events that are exclusive to mice.
///
/// It responds to events that are related to hovering, i.e. when the mouse
/// enters, exits (with or without pressing buttons), or moves over a region
/// without pressing buttons.
///
/// It does not respond to common events that construct gestures, such as when
/// the pointer is pressed, moved, then released or canceled. For these events,
/// use [RenderPointerListener].
///
/// If it has a child, it defers to the child for sizing behavior.
///
/// If it does not have a child, it grows to fit the parent-provided constraints.
///
/// See also:
///
///  * [MouseRegion], a widget that listens to hover events using
///    [RenderMouseRegion].
/// </Summary>
public class RenderMouseRegion : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderMouseRegion(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener), FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener), FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener), bool opaque = true, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

_HoverAnnotation=new MouseTrackerAnnotation(onEnter:_HandleEnter, onHover:_HandleHover, onExit:_HandleExit);
}


#endregion

#region fields
internal virtual bool _Opaque { get; set; }
internal virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener _OnEnter { get; set; }
internal virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener _OnHover { get; set; }
internal virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener _OnExit { get; set; }
internal virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation _HoverAnnotation { get; set; }
internal virtual bool _AnnotationIsActive { get; set; }
public virtual bool Opaque { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnEnter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnHover { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnExit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation HoverAnnotation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool NeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _HandleEnter(FlutterSDK.Gestures.Events.PointerEnterEvent @event)
{
    if (_OnEnter != null) _OnEnter(@event);
}




private void _HandleHover(FlutterSDK.Gestures.Events.PointerHoverEvent @event)
{
    if (_OnHover != null) _OnHover(@event);
}




private void _HandleExit(FlutterSDK.Gestures.Events.PointerExitEvent @event)
{
    if (_OnExit != null) _OnExit(@event);
}




private void _MarkPropertyUpdated(bool mustRepaint = default(bool))
{

    bool newAnnotationIsActive = (_OnEnter != null || _OnHover != null || _OnExit != null || Opaque) && BindingDefaultClass.RendererBinding.Instance.MouseTracker.MouseIsConnected;
    _SetAnnotationIsActive(newAnnotationIsActive);
    if (mustRepaint) MarkNeedsPaint();
}




private void _SetAnnotationIsActive(bool value)
{
    bool annotationWasActive = _AnnotationIsActive;
    _AnnotationIsActive = value;
    if (annotationWasActive != value)
    {
        MarkNeedsPaint();
        MarkNeedsCompositingBitsUpdate();
    }

}




private void _HandleUpdatedMouseIsConnected()
{
    _MarkPropertyUpdated(mustRepaint: false);
}




public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    BindingDefaultClass.RendererBinding.Instance.MouseTracker.AddListener(_HandleUpdatedMouseIsConnected);
    _MarkPropertyUpdated(mustRepaint: false);
}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    BindingDefaultClass.RendererBinding.Instance.MouseTracker.AddListener(_HandleUpdatedMouseIsConnected);
    _MarkPropertyUpdated(mustRepaint: false);
}




public new void Detach()
{
    BindingDefaultClass.RendererBinding.Instance.MouseTracker.RemoveListener(_HandleUpdatedMouseIsConnected);
    base.Detach();
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (_AnnotationIsActive)
    {
        AnnotatedRegionLayer<MouseTrackerAnnotation> layer = new AnnotatedRegionLayer<MouseTrackerAnnotation>(_HoverAnnotation, size: Size, offset: offset, opaque: Opaque);
        context.PushLayer(layer, base.Paint, offset);
    }
    else
    {
        base.Paint(context, offset);
    }

}




public new void PerformResize()
{
    Size = Constraints.Biggest;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new FlagsSummary<Function>("listeners", new Dictionary<string, Function> { { "enter", OnEnter }{ "hover", OnHover }{ "exit", OnExit } }, ifEmpty: "<none>"));
    properties.Add(new DiagnosticsProperty<bool>("opaque", Opaque, defaultValue: true));
}



#endregion
}


/// <Summary>
/// Creates a separate display list for its child.
///
/// This render object creates a separate display list for its child, which
/// can improve performance if the subtree repaints at different times than
/// the surrounding parts of the tree. Specifically, when the child does not
/// repaint but its parent does, we can re-use the display list we recorded
/// previously. Similarly, when the child repaints but the surround tree does
/// not, we can re-record its display list without re-recording the display list
/// for the surround tree.
///
/// In some cases, it is necessary to place _two_ (or more) repaint boundaries
/// to get a useful effect. Consider, for example, an e-mail application that
/// shows an unread count and a list of e-mails. Whenever a new e-mail comes in,
/// the list would update, but so would the unread count. If only one of these
/// two parts of the application was behind a repaint boundary, the entire
/// application would repaint each time. On the other hand, if both were behind
/// a repaint boundary, a new e-mail would only change those two parts of the
/// application and the rest of the application would not repaint.
///
/// To tell if a particular RenderRepaintBoundary is useful, run your
/// application in checked mode, interacting with it in typical ways, and then
/// call [debugDumpRenderTree]. Each RenderRepaintBoundary will include the
/// ratio of cases where the repaint boundary was useful vs the cases where it
/// was not. These counts can also be inspected programmatically using
/// [debugAsymmetricPaintCount] and [debugSymmetricPaintCount] respectively.
/// </Summary>
public class RenderRepaintBoundary : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderRepaintBoundary(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual int _DebugSymmetricPaintCount { get; set; }
internal virtual int _DebugAsymmetricPaintCount { get; set; }
public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int DebugSymmetricPaintCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int DebugAsymmetricPaintCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Capture an image of the current state of this render object and its
/// children.
///
/// The returned [ui.Image] has uncompressed raw RGBA bytes in the dimensions
/// of the render object, multiplied by the [pixelRatio].
///
/// To use [toImage], the render object must have gone through the paint phase
/// (i.e. [debugNeedsPaint] must be false).
///
/// The [pixelRatio] describes the scale between the logical pixels and the
/// size of the output image. It is independent of the
/// [window.devicePixelRatio] for the device, so specifying 1.0 (the default)
/// will give you a 1:1 mapping between logical pixels and the output pixels
/// in the image.
///
/// {@tool snippet}
///
/// The following is an example of how to go from a `GlobalKey` on a
/// `RepaintBoundary` to a PNG:
///
/// ```dart
/// class PngHome extends StatefulWidget {
///   PngHome({Key key}) : super(key: key);
///
///   @override
///   _PngHomeState createState() => _PngHomeState();
/// }
///
/// class _PngHomeState extends State<PngHome> {
///   GlobalKey globalKey = GlobalKey();
///
///   Future<void> _capturePng() async {
///     RenderRepaintBoundary boundary = globalKey.currentContext.findRenderObject();
///     ui.Image image = await boundary.toImage();
///     ByteData byteData = await image.toByteData(format: ui.ImageByteFormat.png);
///     Uint8List pngBytes = byteData.buffer.asUint8List();
///     print(pngBytes);
///   }
///
///   @override
///   Widget build(BuildContext context) {
///     return RepaintBoundary(
///       key: globalKey,
///       child: Center(
///         child: FlatButton(
///           child: Text('Hello World', textDirection: TextDirection.ltr),
///           onPressed: _capturePng,
///         ),
///       ),
///     );
///   }
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [OffsetLayer.toImage] for a similar API at the layer level.
///  * [dart:ui.Scene.toImage] for more information about the image returned.
/// </Summary>
public virtual Future<SKImage> ToImage(double pixelRatio = 1.0)
{

    OffsetLayer offsetLayer = Layer as OffsetLayer;
    return offsetLayer.ToImage(Dart: uiDefaultClass.Offset.Zero & Size, pixelRatio: pixelRatio);
}




/// <Summary>
/// Resets the [debugSymmetricPaintCount] and [debugAsymmetricPaintCount]
/// counts to zero.
///
/// Only valid when asserts are enabled. Does nothing in release builds.
/// </Summary>
public virtual void DebugResetMetrics()
{

}




public new void DebugRegisterRepaintBoundaryPaint(bool includedParent = true, bool includedChild = false)
{

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    bool inReleaseMode = true;

    if (inReleaseMode) properties.Add(DiagnosticsNode.Message("(run in checked mode to collect repaint boundary statistics)"));
}



#endregion
}


/// <Summary>
/// A render object that is invisible during hit testing.
///
/// When [ignoring] is true, this render object (and its subtree) is invisible
/// to hit testing. It still consumes space during layout and paints its child
/// as usual. It just cannot be the target of located events, because its render
/// object returns false from [hitTest].
///
/// When [ignoringSemantics] is true, the subtree will be invisible to
/// the semantics layer (and thus e.g. accessibility tools). If
/// [ignoringSemantics] is null, it uses the value of [ignoring].
///
/// See also:
///
///  * [RenderAbsorbPointer], which takes the pointer events but prevents any
///    nodes in the subtree from seeing them.
/// </Summary>
public class RenderIgnorePointer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderIgnorePointer(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), bool ignoring = true, bool ignoringSemantics = default(bool))
    : base(child)


}


#endregion

#region fields
internal virtual bool _Ignoring { get; set; }
internal virtual bool _IgnoringSemantics { get; set; }
public virtual bool Ignoring { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IgnoringSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual bool _EffectiveIgnoringSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return !Ignoring && base.HitTest(result, position: position);
}




public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    if (Child != null && !_EffectiveIgnoringSemantics) visitor(Child);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("ignoring", Ignoring));
    properties.Add(new DiagnosticsProperty<bool>("ignoringSemantics", _EffectiveIgnoringSemantics, description: IgnoringSemantics == null ? $"'implicitly {_EffectiveIgnoringSemantics}'" : null));
}



#endregion
}


/// <Summary>
/// Lays the child out as if it was in the tree, but without painting anything,
/// without making the child available for hit testing, and without taking any
/// room in the parent.
/// </Summary>
public class RenderOffstage : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderOffstage(bool offstage = true, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual bool _Offstage { get; set; }
public virtual bool Offstage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height)
{
    if (Offstage) return 0.0;
    return base.ComputeMinIntrinsicWidth(height);
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    if (Offstage) return 0.0;
    return base.ComputeMaxIntrinsicWidth(height);
}




public new double ComputeMinIntrinsicHeight(double width)
{
    if (Offstage) return 0.0;
    return base.ComputeMinIntrinsicHeight(width);
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    if (Offstage) return 0.0;
    return base.ComputeMaxIntrinsicHeight(width);
}




public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
{
    if (Offstage) return null;
    return base.ComputeDistanceToActualBaseline(baseline);
}




public new void PerformResize()
{

    Size = Constraints.Smallest;
}




public new void PerformLayout()
{
    if (Offstage)
    {
        Child?.Layout(Constraints);
    }
    else
    {
        base.PerformLayout();
    }

}




public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return !Offstage && base.HitTest(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Offstage) return;
    base.Paint(context, offset);
}




public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    if (Offstage) return;
    base.VisitChildrenForSemantics(visitor);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("offstage", Offstage));
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
{
    if (Child == null) return new List<DiagnosticsNode>() { };
    return new List<DiagnosticsNode>() { Child.ToDiagnosticsNode(name: "child", style: Offstage ? DiagnosticsTreeStyle.Offstage : DiagnosticsTreeStyle.Sparse) };
}



#endregion
}


/// <Summary>
/// A render object that absorbs pointers during hit testing.
///
/// When [absorbing] is true, this render object prevents its subtree from
/// receiving pointer events by terminating hit testing at itself. It still
/// consumes space during layout and paints its child as usual. It just prevents
/// its children from being the target of located events, because its render
/// object returns true from [hitTest].
///
/// See also:
///
///  * [RenderIgnorePointer], which has the opposite effect: removing the
///    subtree from considering entirely for the purposes of hit testing.
/// </Summary>
public class RenderAbsorbPointer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderAbsorbPointer(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), bool absorbing = true, bool ignoringSemantics = default(bool))
    : base(child)

}
#endregion

#region fields
internal virtual bool _Absorbing { get; set; }
internal virtual bool _IgnoringSemantics { get; set; }
public virtual bool Absorbing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IgnoringSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual bool _EffectiveIgnoringSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return Absorbing ? Size.Contains(position) : base.HitTest(result, position: position);
}




public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    if (Child != null && !_EffectiveIgnoringSemantics) visitor(Child);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("absorbing", Absorbing));
    properties.Add(new DiagnosticsProperty<bool>("ignoringSemantics", _EffectiveIgnoringSemantics, description: IgnoringSemantics == null ? $"'implicitly {_EffectiveIgnoringSemantics}'" : null));
}



#endregion
}


/// <Summary>
/// Holds opaque meta data in the render tree.
///
/// Useful for decorating the render tree with information that will be consumed
/// later. For example, you could store information in the render tree that will
/// be used when the user interacts with the render tree but has no visual
/// impact prior to the interaction.
/// </Summary>
public class RenderMetaData : FlutterSDK.Rendering.Proxybox.RenderProxyBoxWithHitTestBehavior
{
    #region constructors
    public RenderMetaData(object metaData = default(object), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(behavior: behavior, child: child)

}
#endregion

#region fields
public virtual object MetaData { get; set; }
#endregion

#region methods

public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<object>("metaData", MetaData));
}



#endregion
}


/// <Summary>
/// Listens for the specified gestures from the semantics server (e.g.
/// an accessibility tool).
/// </Summary>
public class RenderSemanticsGestureHandler : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderSemanticsGestureHandler(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onHorizontalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onVerticalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), double scrollFactor = 0.8)
    : base(child)

}
#endregion

#region fields
internal virtual HashSet<SemanticsAction> _ValidActions { get; set; }
internal virtual FlutterSDK.Gestures.Tap.GestureTapCallback _OnTap { get; set; }
internal virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback _OnLongPress { get; set; }
internal virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _OnHorizontalDragUpdate { get; set; }
internal virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _OnVerticalDragUpdate { get; set; }
public virtual double ScrollFactor { get; set; }
public virtual HashSet<SemanticsAction> ValidActions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnHorizontalDragUpdate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnVerticalDragUpdate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    if (OnTap != null && _IsValidAction(Dart: uiDefaultClass.SemanticsAction.Tap)) config.OnTap = OnTap;
    if (OnLongPress != null && _IsValidAction(Dart: uiDefaultClass.SemanticsAction.LongPress)) config.OnLongPress = OnLongPress;
    if (OnHorizontalDragUpdate != null)
    {
        if (_IsValidAction(Dart: uiDefaultClass.SemanticsAction.ScrollRight)) config.OnScrollRight = _PerformSemanticScrollRight;
        if (_IsValidAction(Dart: uiDefaultClass.SemanticsAction.ScrollLeft)) config.OnScrollLeft = _PerformSemanticScrollLeft;
    }

    if (OnVerticalDragUpdate != null)
    {
        if (_IsValidAction(Dart: uiDefaultClass.SemanticsAction.ScrollUp)) config.OnScrollUp = _PerformSemanticScrollUp;
        if (_IsValidAction(Dart: uiDefaultClass.SemanticsAction.ScrollDown)) config.OnScrollDown = _PerformSemanticScrollDown;
    }

}




private bool _IsValidAction(SemanticsAction action)
{
    return ValidActions == null || ValidActions.Contains(action);
}




private void _PerformSemanticScrollLeft()
{
    if (OnHorizontalDragUpdate != null)
    {
        double primaryDelta = Size.Width * -ScrollFactor;
        OnHorizontalDragUpdate(new DragUpdateDetails(delta: new Offset(primaryDelta, 0.0), primaryDelta: primaryDelta, globalPosition: LocalToGlobal(Size.Center(Dart: uiDefaultClass.Offset.Zero))));
    }

}




private void _PerformSemanticScrollRight()
{
    if (OnHorizontalDragUpdate != null)
    {
        double primaryDelta = Size.Width * ScrollFactor;
        OnHorizontalDragUpdate(new DragUpdateDetails(delta: new Offset(primaryDelta, 0.0), primaryDelta: primaryDelta, globalPosition: LocalToGlobal(Size.Center(Dart: uiDefaultClass.Offset.Zero))));
    }

}




private void _PerformSemanticScrollUp()
{
    if (OnVerticalDragUpdate != null)
    {
        double primaryDelta = Size.Height * -ScrollFactor;
        OnVerticalDragUpdate(new DragUpdateDetails(delta: new Offset(0.0, primaryDelta), primaryDelta: primaryDelta, globalPosition: LocalToGlobal(Size.Center(Dart: uiDefaultClass.Offset.Zero))));
    }

}




private void _PerformSemanticScrollDown()
{
    if (OnVerticalDragUpdate != null)
    {
        double primaryDelta = Size.Height * ScrollFactor;
        OnVerticalDragUpdate(new DragUpdateDetails(delta: new Offset(0.0, primaryDelta), primaryDelta: primaryDelta, globalPosition: LocalToGlobal(Size.Center(Dart: uiDefaultClass.Offset.Zero))));
    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    List<string> gestures = new List<string>() { };
    if (gestures.IsEmpty()) gestures.Add("<none>");
    properties.Add(new IterableProperty<string>("gestures", gestures));
}



#endregion
}


/// <Summary>
/// Add annotations to the [SemanticsNode] for this subtree.
/// </Summary>
public class RenderSemanticsAnnotations : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderSemanticsAnnotations(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), bool container = false, bool explicitChildNodes = default(bool), bool excludeSemantics = false, bool enabled = default(bool), bool @checked = default(bool), bool toggled = default(bool), bool selected = default(bool), bool button = default(bool), bool link = default(bool), bool header = default(bool), bool textField = default(bool), bool readOnly = default(bool), bool focusable = default(bool), bool focused = default(bool), bool inMutuallyExclusiveGroup = default(bool), bool obscured = default(bool), bool multiline = default(bool), bool scopesRoute = default(bool), bool namesRoute = default(bool), bool hidden = default(bool), bool image = default(bool), bool liveRegion = default(bool), int maxValueLength = default(int), int currentValueLength = default(int), string label = default(string), string value = default(string), string increasedValue = default(string), string decreasedValue = default(string), string hint = default(string), FlutterSDK.Semantics.Semantics.SemanticsHintOverrides hintOverrides = default(FlutterSDK.Semantics.Semantics.SemanticsHintOverrides), TextDirection textDirection = default(TextDirection), FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey), VoidCallback onTap = default(VoidCallback), VoidCallback onDismiss = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), VoidCallback onScrollLeft = default(VoidCallback), VoidCallback onScrollRight = default(VoidCallback), VoidCallback onScrollUp = default(VoidCallback), VoidCallback onScrollDown = default(VoidCallback), VoidCallback onIncrease = default(VoidCallback), VoidCallback onDecrease = default(VoidCallback), VoidCallback onCopy = default(VoidCallback), VoidCallback onCut = default(VoidCallback), VoidCallback onPaste = default(VoidCallback), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.SetSelectionHandler onSetSelection = default(FlutterSDK.Semantics.Semantics.SetSelectionHandler), VoidCallback onDidGainAccessibilityFocus = default(VoidCallback), VoidCallback onDidLoseAccessibilityFocus = default(VoidCallback), Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> customSemanticsActions = default(Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object>))
    : base(child)

}
#endregion

#region fields
internal virtual bool _Container { get; set; }
internal virtual bool _ExplicitChildNodes { get; set; }
internal virtual bool _ExcludeSemantics { get; set; }
internal virtual bool _Checked { get; set; }
internal virtual bool _Enabled { get; set; }
internal virtual bool _Selected { get; set; }
internal virtual bool _Button { get; set; }
internal virtual bool _Link { get; set; }
internal virtual bool _Header { get; set; }
internal virtual bool _TextField { get; set; }
internal virtual bool _ReadOnly { get; set; }
internal virtual bool _Focusable { get; set; }
internal virtual bool _Focused { get; set; }
internal virtual bool _InMutuallyExclusiveGroup { get; set; }
internal virtual bool _Obscured { get; set; }
internal virtual bool _Multiline { get; set; }
internal virtual bool _ScopesRoute { get; set; }
internal virtual bool _NamesRoute { get; set; }
internal virtual bool _Hidden { get; set; }
internal virtual bool _Image { get; set; }
internal virtual bool _LiveRegion { get; set; }
internal virtual int _MaxValueLength { get; set; }
internal virtual int _CurrentValueLength { get; set; }
internal virtual bool _Toggled { get; set; }
internal virtual string _Label { get; set; }
internal virtual string _Value { get; set; }
internal virtual string _IncreasedValue { get; set; }
internal virtual string _DecreasedValue { get; set; }
internal virtual string _Hint { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides _HintOverrides { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey _SortKey { get; set; }
internal virtual VoidCallback _OnTap { get; set; }
internal virtual VoidCallback _OnDismiss { get; set; }
internal virtual VoidCallback _OnLongPress { get; set; }
internal virtual VoidCallback _OnScrollLeft { get; set; }
internal virtual VoidCallback _OnScrollRight { get; set; }
internal virtual VoidCallback _OnScrollUp { get; set; }
internal virtual VoidCallback _OnScrollDown { get; set; }
internal virtual VoidCallback _OnIncrease { get; set; }
internal virtual VoidCallback _OnDecrease { get; set; }
internal virtual VoidCallback _OnCopy { get; set; }
internal virtual VoidCallback _OnCut { get; set; }
internal virtual VoidCallback _OnPaste { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByCharacter { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByCharacter { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByWord { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByWord { get; set; }
internal virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler _OnSetSelection { get; set; }
internal virtual VoidCallback _OnDidGainAccessibilityFocus { get; set; }
internal virtual VoidCallback _OnDidLoseAccessibilityFocus { get; set; }
internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> _CustomSemanticsActions { get; set; }
public virtual bool Container { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ExplicitChildNodes { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ExcludeSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool @checked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Selected { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Button { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Link { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Header { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool TextField { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ReadOnly { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Focusable { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Focused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool InMutuallyExclusiveGroup { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Obscured { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Multiline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ScopesRoute { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool NamesRoute { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Hidden { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Image { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool LiveRegion { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int MaxValueLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int CurrentValueLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Toggled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string IncreasedValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string DecreasedValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string Hint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnTap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnDismiss { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnLongPress { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnScrollLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnScrollRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnScrollUp { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnScrollDown { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnIncrease { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnDecrease { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnCopy { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnCut { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnPaste { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWord { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWord { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnDidGainAccessibilityFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual VoidCallback OnDidLoseAccessibilityFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> CustomSemanticsActions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    if (ExcludeSemantics) return;
    base.VisitChildrenForSemantics(visitor);
}




public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    config.IsSemanticBoundary = Container;
    config.ExplicitChildNodes = ExplicitChildNodes;


    if (Enabled != null) config.IsEnabled = Enabled;
    if (Checked != null) config.IsChecked = Checked;
    if (Toggled != null) config.IsToggled = Toggled;
    if (Selected != null) config.IsSelected = Selected;
    if (Button != null) config.IsButton = Button;
    if (Link != null) config.IsLink = Link;
    if (Header != null) config.IsHeader = Header;
    if (TextField != null) config.IsTextField = TextField;
    if (ReadOnly != null) config.IsReadOnly = ReadOnly;
    if (Focusable != null) config.IsFocusable = Focusable;
    if (Focused != null) config.IsFocused = Focused;
    if (InMutuallyExclusiveGroup != null) config.IsInMutuallyExclusiveGroup = InMutuallyExclusiveGroup;
    if (Obscured != null) config.IsObscured = Obscured;
    if (Multiline != null) config.IsMultiline = Multiline;
    if (Hidden != null) config.IsHidden = Hidden;
    if (Image != null) config.IsImage = Image;
    if (Label != null) config.Label = Label;
    if (Value != null) config.Value = Value;
    if (IncreasedValue != null) config.IncreasedValue = IncreasedValue;
    if (DecreasedValue != null) config.DecreasedValue = DecreasedValue;
    if (Hint != null) config.Hint = Hint;
    if (HintOverrides != null && HintOverrides.IsNotEmpty) config.HintOverrides = HintOverrides;
    if (ScopesRoute != null) config.ScopesRoute = ScopesRoute;
    if (NamesRoute != null) config.NamesRoute = NamesRoute;
    if (LiveRegion != null) config.LiveRegion = LiveRegion;
    if (MaxValueLength != null)
    {
        config.MaxValueLength = MaxValueLength;
    }

    if (CurrentValueLength != null)
    {
        config.CurrentValueLength = CurrentValueLength;
    }

    if (TextDirection != null) config.TextDirection = TextDirection;
    if (SortKey != null) config.SortKey = SortKey;
    if (OnTap != null) config.OnTap = _PerformTap;
    if (OnLongPress != null) config.OnLongPress = _PerformLongPress;
    if (OnDismiss != null) config.OnDismiss = _PerformDismiss;
    if (OnScrollLeft != null) config.OnScrollLeft = _PerformScrollLeft;
    if (OnScrollRight != null) config.OnScrollRight = _PerformScrollRight;
    if (OnScrollUp != null) config.OnScrollUp = _PerformScrollUp;
    if (OnScrollDown != null) config.OnScrollDown = _PerformScrollDown;
    if (OnIncrease != null) config.OnIncrease = _PerformIncrease;
    if (OnDecrease != null) config.OnDecrease = _PerformDecrease;
    if (OnCopy != null) config.OnCopy = _PerformCopy;
    if (OnCut != null) config.OnCut = _PerformCut;
    if (OnPaste != null) config.OnPaste = _PerformPaste;
    if (OnMoveCursorForwardByCharacter != null) config.OnMoveCursorForwardByCharacter = _PerformMoveCursorForwardByCharacter;
    if (OnMoveCursorBackwardByCharacter != null) config.OnMoveCursorBackwardByCharacter = _PerformMoveCursorBackwardByCharacter;
    if (OnMoveCursorForwardByWord != null) config.OnMoveCursorForwardByWord = _PerformMoveCursorForwardByWord;
    if (OnMoveCursorBackwardByWord != null) config.OnMoveCursorBackwardByWord = _PerformMoveCursorBackwardByWord;
    if (OnSetSelection != null) config.OnSetSelection = _PerformSetSelection;
    if (OnDidGainAccessibilityFocus != null) config.OnDidGainAccessibilityFocus = _PerformDidGainAccessibilityFocus;
    if (OnDidLoseAccessibilityFocus != null) config.OnDidLoseAccessibilityFocus = _PerformDidLoseAccessibilityFocus;
    if (CustomSemanticsActions != null) config.CustomSemanticsActions = _CustomSemanticsActions;
}




private void _PerformTap()
{
    if (OnTap != null) OnTap();
}




private void _PerformLongPress()
{
    if (OnLongPress != null) OnLongPress();
}




private void _PerformDismiss()
{
    if (OnDismiss != null) OnDismiss();
}




private void _PerformScrollLeft()
{
    if (OnScrollLeft != null) OnScrollLeft();
}




private void _PerformScrollRight()
{
    if (OnScrollRight != null) OnScrollRight();
}




private void _PerformScrollUp()
{
    if (OnScrollUp != null) OnScrollUp();
}




private void _PerformScrollDown()
{
    if (OnScrollDown != null) OnScrollDown();
}




private void _PerformIncrease()
{
    if (OnIncrease != null) OnIncrease();
}




private void _PerformDecrease()
{
    if (OnDecrease != null) OnDecrease();
}




private void _PerformCopy()
{
    if (OnCopy != null) OnCopy();
}




private void _PerformCut()
{
    if (OnCut != null) OnCut();
}




private void _PerformPaste()
{
    if (OnPaste != null) OnPaste();
}




private void _PerformMoveCursorForwardByCharacter(bool extendSelection)
{
    if (OnMoveCursorForwardByCharacter != null) OnMoveCursorForwardByCharacter(extendSelection);
}




private void _PerformMoveCursorBackwardByCharacter(bool extendSelection)
{
    if (OnMoveCursorBackwardByCharacter != null) OnMoveCursorBackwardByCharacter(extendSelection);
}




private void _PerformMoveCursorForwardByWord(bool extendSelection)
{
    if (OnMoveCursorForwardByWord != null) OnMoveCursorForwardByWord(extendSelection);
}




private void _PerformMoveCursorBackwardByWord(bool extendSelection)
{
    if (OnMoveCursorBackwardByWord != null) OnMoveCursorBackwardByWord(extendSelection);
}




private void _PerformSetSelection(FlutterSDK.Services.Textediting.TextSelection selection)
{
    if (OnSetSelection != null) OnSetSelection(selection);
}




private void _PerformDidGainAccessibilityFocus()
{
    if (OnDidGainAccessibilityFocus != null) OnDidGainAccessibilityFocus();
}




private void _PerformDidLoseAccessibilityFocus()
{
    if (OnDidLoseAccessibilityFocus != null) OnDidLoseAccessibilityFocus();
}



#endregion
}


/// <Summary>
/// Causes the semantics of all earlier render objects below the same semantic
/// boundary to be dropped.
///
/// This is useful in a stack where an opaque mask should prevent interactions
/// with the render objects painted below the mask.
/// </Summary>
public class RenderBlockSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderBlockSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), bool blocking = true)
    : base(child)

}
#endregion

#region fields
internal virtual bool _Blocking { get; set; }
public virtual bool Blocking { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    config.IsBlockingSemanticsOfPreviouslyPaintedNodes = Blocking;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("blocking", Blocking));
}



#endregion
}


/// <Summary>
/// Causes the semantics of all descendants to be merged into this
/// node such that the entire subtree becomes a single leaf in the
/// semantics tree.
///
/// Useful for combining the semantics of multiple render objects that
/// form part of a single conceptual widget, e.g. a checkbox, a label,
/// and the gesture detector that goes with them.
/// </Summary>
public class RenderMergeSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderMergeSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    ..IsSemanticBoundary = true..IsMergingSemanticsOfDescendants = true;
}



#endregion
}


/// <Summary>
/// Excludes this subtree from the semantic tree.
///
/// When [excluding] is true, this render object (and its subtree) is excluded
/// from the semantic tree.
///
/// Useful e.g. for hiding text that is redundant with other text next
/// to it (e.g. text included only for the visual effect).
/// </Summary>
public class RenderExcludeSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderExcludeSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), bool excluding = true)
    : base(child)


}


#endregion

#region fields
internal virtual bool _Excluding { get; set; }
public virtual bool Excluding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    if (Excluding) return;
    base.VisitChildrenForSemantics(visitor);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<bool>("excluding", Excluding));
}



#endregion
}


/// <Summary>
/// A render objects that annotates semantics with an index.
///
/// Certain widgets will automatically provide a child index for building
/// semantics. For example, the [ScrollView] uses the index of the first
/// visible child semantics node to determine the
/// [SemanticsConfiguration.scrollIndex].
///
/// See also:
///
///  * [CustomScrollView], for an explanation of scroll semantics.
/// </Summary>
public class RenderIndexedSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderIndexedSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), int index = default(int))
    : base(child)

}
#endregion

#region fields
internal virtual int _Index { get; set; }
public virtual int Index { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    config.IsSemanticBoundary = true;
    config.IndexInParent = Index;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<int>("index", Index));
}



#endregion
}


/// <Summary>
/// Provides an anchor for a [RenderFollowerLayer].
///
/// See also:
///
///  * [CompositedTransformTarget], the corresponding widget.
///  * [LeaderLayer], the layer that this render object creates.
/// </Summary>
public class RenderLeaderLayer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderLeaderLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

this .Link=link;
}


#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link { get; set; }
public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Layer == null)
    {
        Layer = new LeaderLayer(link: Link, offset: offset);
    }
    else
    {
        LeaderLayer leaderLayer = Layer as LeaderLayer;
        ..Link = Link..Offset = offset;
    }

    context.PushLayer(Layer, base.Paint, Dart: uiDefaultClass.Offset.Zero);

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<LayerLink>("link", Link));
}



#endregion
}


/// <Summary>
/// Transform the child so that its origin is [offset] from the origin of the
/// [RenderLeaderLayer] with the same [LayerLink].
///
/// The [RenderLeaderLayer] in question must be earlier in the paint order.
///
/// Hit testing on descendants of this render object will only work if the
/// target position is within the box that this render object's parent considers
/// to be hittable.
///
/// See also:
///
///  * [CompositedTransformFollower], the corresponding widget.
///  * [FollowerLayer], the layer that this render object creates.
/// </Summary>
public class RenderFollowerLayer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderFollowerLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), bool showWhenUnlinked = true, FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

this .Link=link;
this .ShowWhenUnlinked=showWhenUnlinked;
this .Offset=offset;
}


#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link { get; set; }
internal virtual bool _ShowWhenUnlinked { get; set; }
internal virtual FlutterBinding.UI.Offset _Offset { get; set; }
public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ShowWhenUnlinked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Offset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Layer.FollowerLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Detach()
{
    Layer = null;
    base.Detach();
}




/// <Summary>
/// Return the transform that was used in the last composition phase, if any.
///
/// If the [FollowerLayer] has not yet been created, was never composited, or
/// was unable to determine the transform (see
/// [FollowerLayer.getLastTransform]), this returns the identity matrix (see
/// [new Matrix4.identity].
/// </Summary>
public virtual Matrix4 GetCurrentTransform()
{
    return Layer?.GetLastTransform() ?? Matrix4.Identity();
}




public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return HitTestChildren(result, position: position);
}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return result.AddWithPaintTransform(transform: GetCurrentTransform(), position: position, hitTest: (BoxHitTestResult result, Offset position) =>
    {
        return base.HitTestChildren(result, position: position);
    }
    );
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

    if (Layer == null)
    {
        Layer = new FollowerLayer(link: Link, showWhenUnlinked: ShowWhenUnlinked, linkedOffset: this.Offset, unlinkedOffset: offset);
    }
    else
    {
        ..Link = Link..ShowWhenUnlinked = ShowWhenUnlinked..LinkedOffset = this.Offset..UnlinkedOffset = offset;
    }

    context.PushLayer(Layer, base.Paint, Dart: uiDefaultClass.Offset.Zero, childPaintBounds: Rect.FromLTRB(Dart: coreDefaultClass.Double.NegativeInfinity, Dart: coreDefaultClass.Double.NegativeInfinity, Dart: coreDefaultClass.Double.Infinity, Dart: coreDefaultClass.Double.Infinity));
}




public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
{
    transform.Multiply(GetCurrentTransform());
}


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
{
    transform.Multiply(GetCurrentTransform());
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<LayerLink>("link", Link));
    properties.Add(new DiagnosticsProperty<bool>("showWhenUnlinked", ShowWhenUnlinked));
    properties.Add(new DiagnosticsProperty<Offset>("offset", Offset));
    properties.Add(new TransformProperty("current transform matrix", GetCurrentTransform()));
}



#endregion
}


/// <Summary>
/// Render object which inserts an [AnnotatedRegionLayer] into the layer tree.
///
/// See also:
///
///  * [Layer.find], for an example of how this value is retrieved.
///  * [AnnotatedRegionLayer], the layer this render object creates.
/// </Summary>
public class RenderAnnotatedRegion<T> : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public RenderAnnotatedRegion(T value = default(T), bool sized = default(bool), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
    : base(child)

}
#endregion

#region fields
internal virtual T _Value { get; set; }
internal virtual bool _Sized { get; set; }
public new bool AlwaysNeedsCompositing { get; set; }
public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Sized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    AnnotatedRegionLayer<T> layer = new AnnotatedRegionLayer<T>(Value, size: Sized ? Size : null, offset: Sized ? offset : null);
    context.PushLayer(layer, base.Paint, offset);
}



#endregion
}


/// <Summary>
/// How to behave during hit tests.
/// </Summary>
public enum HitTestBehavior
{

    /// <Summary>
    /// Targets that defer to their children receive events within their bounds
    /// only if one of their children is hit by the hit test.
    /// </Summary>
    DeferToChild,
    /// <Summary>
    /// Opaque targets can be hit by hit tests, causing them to both receive
    /// events within their bounds and prevent targets visually behind them from
    /// also receiving events.
    /// </Summary>
    Opaque,
    /// <Summary>
    /// Translucent targets both receive events within their bounds and permit
    /// targets visually behind them to also receive events.
    /// </Summary>
    Translucent,
}


/// <Summary>
/// Where to paint a box decoration.
/// </Summary>
public enum DecorationPosition
{

    /// <Summary>
    /// Paint the box decoration behind the children.
    /// </Summary>
    Background,
    /// <Summary>
    /// Paint the box decoration in front of the children.
    /// </Summary>
    Foreground,
}

}
