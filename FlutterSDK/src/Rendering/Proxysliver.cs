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
using FlutterSDK.Painting._Networkimageio;
namespace FlutterSDK.Rendering.Proxysliver
{
    internal static class ProxysliverDefaultClass
    {
    }

    /// <Summary>
    /// A base class for sliver render objects that resemble their children.
    ///
    /// A proxy sliver has a single child and simply mimics all the properties of
    /// that child by calling through to the child for each function in the render
    /// sliver protocol. For example, a proxy sliver determines its geometry by
    /// asking its sliver child to layout with the same constraints and then
    /// matching the geometry.
    ///
    /// A proxy sliver isn't useful on its own because you might as well just
    /// replace the proxy sliver with its child. However, RenderProxySliver is a
    /// useful base class for render objects that wish to mimic most, but not all,
    /// of the properties of their sliver child.
    ///
    /// See also:
    ///
    ///  * [RenderProxyBox], a base class for render boxes that resemble their
    ///    children.
    /// </Summary>
    public interface IRenderProxySliver
    {
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        void PerformLayout();
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double));
        double ChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
    }


    /// <Summary>
    /// A base class for sliver render objects that resemble their children.
    ///
    /// A proxy sliver has a single child and simply mimics all the properties of
    /// that child by calling through to the child for each function in the render
    /// sliver protocol. For example, a proxy sliver determines its geometry by
    /// asking its sliver child to layout with the same constraints and then
    /// matching the geometry.
    ///
    /// A proxy sliver isn't useful on its own because you might as well just
    /// replace the proxy sliver with its child. However, RenderProxySliver is a
    /// useful base class for render objects that wish to mimic most, but not all,
    /// of the properties of their sliver child.
    ///
    /// See also:
    ///
    ///  * [RenderProxyBox], a base class for render boxes that resemble their
    ///    children.
    /// </Summary>
    public class RenderProxySliver : FlutterSDK.Rendering.Sliver.RenderSliver, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
    {
        #region constructors
        public RenderProxySliver(FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver))
    
this .Child=child;
}


    #endregion

    #region fields
    #endregion

    #region methods

    public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
    {
        if (!(child.ParentData is SliverPhysicalParentData)) child.ParentData = new SliverPhysicalParentData();
    }




    public new void PerformLayout()
    {

        Child.Layout(Constraints, parentUsesSize: true);
        Geometry = Child.Geometry;
    }




    public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {
        if (Child != null) context.PaintChild(Child, offset);
    }




    public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
    {
        return Child != null && Child.Geometry.HitTestExtent > 0 && Child.HitTest(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
    }




    public new double ChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child)
    {


        return 0.0;
    }


    public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child)
    {


        return 0.0;
    }




    public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
    {

        SliverPhysicalParentData childParentData = child.ParentData as SliverPhysicalParentData;
        childParentData.ApplyPaintTransform(transform);
    }



    #endregion
}


/// <Summary>
/// Makes its sliver child partially transparent.
///
/// This class paints its sliver child into an intermediate buffer and then
/// blends the sliver child back into the scene, partially transparent.
///
/// For values of opacity other than 0.0 and 1.0, this class is relatively
/// expensive, because it requires painting the sliver child into an intermediate
/// buffer. For the value 0.0, the sliver child is simply not painted at all.
/// For the value 1.0, the sliver child is painted immediately without an
/// intermediate buffer.
/// </Summary>
public class RenderSliverOpacity : FlutterSDK.Rendering.Proxysliver.RenderProxySliver
{
    #region constructors
    public RenderSliverOpacity(double opacity = 1.0, bool alwaysIncludeSemantics = false, FlutterSDK.Rendering.Sliver.RenderSliver sliver = default(FlutterSDK.Rendering.Sliver.RenderSliver))
    : base()

Child=sliver;
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
    if (Child != null && Child.Geometry.Visible)
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
/// A render object that is invisible during hit testing.
///
/// When [ignoring] is true, this render object (and its subtree) is invisible
/// to hit testing. It still consumes space during layout and paints its sliver
/// child as usual. It just cannot be the target of located events, because its
/// render object returns false from [hitTest].
///
/// When [ignoringSemantics] is true, the subtree will be invisible to the
/// semantics layer (and thus e.g. accessibility tools). If [ignoringSemantics]
/// is null, it uses the value of [ignoring].
/// </Summary>
public class RenderSliverIgnorePointer : FlutterSDK.Rendering.Proxysliver.RenderProxySliver
{
    #region constructors
    public RenderSliverIgnorePointer(FlutterSDK.Rendering.Sliver.RenderSliver sliver = default(FlutterSDK.Rendering.Sliver.RenderSliver), bool ignoring = true, bool ignoringSemantics = default(bool))
    : base()

Child=sliver;
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

public new bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
{
    return !Ignoring && base.HitTest(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
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
/// Lays the sliver child out as if it was in the tree, but without painting
/// anything, without making the sliver child available for hit testing, and
/// without taking any room in the parent.
/// </Summary>
public class RenderSliverOffstage : FlutterSDK.Rendering.Proxysliver.RenderProxySliver
{
    #region constructors
    public RenderSliverOffstage(bool offstage = true, FlutterSDK.Rendering.Sliver.RenderSliver sliver = default(FlutterSDK.Rendering.Sliver.RenderSliver))
    : base()

Child=sliver;
}


#endregion

#region fields
internal virtual bool _Offstage { get; set; }
public virtual bool Offstage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void PerformLayout()
{

    Child.Layout(Constraints, parentUsesSize: true);
    if (!Offstage) Geometry = Child.Geometry; else Geometry = new SliverGeometry(scrollExtent: 0.0, visible: false, maxPaintExtent: 0.0);
}




public new bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
{
    return !Offstage && base.HitTest(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
}




public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
{
    return !Offstage && Child != null && Child.Geometry.HitTestExtent > 0 && Child.HitTest(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (Offstage) return;
    context.PaintChild(Child, offset);
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
/// Makes its sliver child partially transparent, driven from an [Animation].
///
/// This is a variant of [RenderSliverOpacity] that uses an [Animation<double>]
/// rather than a [double] to control the opacity.
/// </Summary>
public class RenderSliverAnimatedOpacity : FlutterSDK.Rendering.Proxysliver.RenderProxySliver, IRenderAnimatedOpacityMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
{
    #region constructors
    public RenderSliverAnimatedOpacity(FlutterSDK.Animation.Animation.Animation<double> opacity = default(FlutterSDK.Animation.Animation.Animation<double>), bool alwaysIncludeSemantics = false, FlutterSDK.Rendering.Sliver.RenderSliver sliver = default(FlutterSDK.Rendering.Sliver.RenderSliver))
    : base()

this .Opacity=opacity;
this .AlwaysIncludeSemantics=alwaysIncludeSemantics;
Child=sliver;
}


#endregion

#region fields
#endregion

#region methods
#endregion
}

}
