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
namespace FlutterSDK.Rendering.Viewport
{
    internal static class ViewportDefaultClass
    {
    }

    public interface IRenderAbstractViewport
    {
        FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object);
        FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect));
        double DefaultCacheExtent { get; }
    }


    public interface IRenderViewportBase<ParentDataClass>
    {
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void Detach();
        bool DebugThrowIfNotCheckingIntrinsics();
        double ComputeMinIntrinsicWidth(double height);
        double ComputeMaxIntrinsicWidth(double height);
        double ComputeMinIntrinsicHeight(double width);
        double ComputeMaxIntrinsicHeight(double width);
        double LayoutChildSequence(FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver), double scrollOffset = default(double), double overlap = default(double), double layoutOffset = default(double), double remainingPaintExtent = default(double), double mainAxisExtent = default(double), double crossAxisExtent = default(double), FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection), Func<RenderSliver, RenderSliver> advance = default(Func<RenderSliver, RenderSliver>), double remainingCacheExtent = default(double), double cacheOrigin = default(double));
        Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.Sliver.RenderSliver child);
        Rect DescribeSemanticsClip(FlutterSDK.Rendering.Sliver.RenderSliver child);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
        FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect));
        Offset ComputeAbsolutePaintOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry);
        void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection);
        Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child);
        double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild);
        double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child);
        double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition);
        string LabelForChild(int index);
        void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        Rect ShowInViewport(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Rendering.Viewport.RenderAbstractViewport viewport = default(FlutterSDK.Rendering.Viewport.RenderAbstractViewport), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get; set; }
        FlutterSDK.Painting.Basictypes.Axis Axis { get; }
        FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }
        double CacheExtent { get; set; }
        FlutterSDK.Rendering.Viewport.CacheExtentStyle CacheExtentStyle { get; set; }
        bool IsRepaintBoundary { get; }
        bool HasVisualOverflow { get; }
        int IndexOfFirstChild { get; }
        Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get; }
        Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get; }
    }


    public class RenderAbstractViewport : FlutterSDK.Rendering.@object.RenderObject
    {
        #region constructors
        internal RenderAbstractViewport()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double DefaultCacheExtent { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect)) { throw new NotImplementedException(); }

        #endregion
    }


    public class RevealedOffset
    {
        #region constructors
        public RevealedOffset(double offset = default(double), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect))
        : base()
        {
            this.Offset = offset;
            this.Rect = rect; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Offset { get; set; }
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        #endregion

        #region methods

        #endregion
    }


    public class RenderViewportBase<ParentDataClass> : FlutterSDK.Rendering.Box.RenderBox, IRenderAbstractViewport, IContainerRenderObjectMixin<FlutterSDK.Rendering.Sliver.RenderSliver, ParentDataClass>
    {
        #region constructors
        public RenderViewportBase(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double cacheExtent = default(double), FlutterSDK.Rendering.Viewport.CacheExtentStyle cacheExtentStyle = default(FlutterSDK.Rendering.Viewport.CacheExtentStyle))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Basictypes.AxisDirection _AxisDirection { get; set; }
        internal virtual FlutterSDK.Painting.Basictypes.AxisDirection _CrossAxisDirection { get; set; }
        internal virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset _Offset { get; set; }
        internal virtual double _CacheExtent { get; set; }
        internal virtual double _CalculatedCacheExtent { get; set; }
        internal virtual FlutterSDK.Rendering.Viewport.CacheExtentStyle _CacheExtentStyle { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double CacheExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewport.CacheExtentStyle CacheExtentStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexOfFirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }


        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public virtual bool DebugThrowIfNotCheckingIntrinsics() { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public virtual double LayoutChildSequence(FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver), double scrollOffset = default(double), double overlap = default(double), double layoutOffset = default(double), double remainingPaintExtent = default(double), double mainAxisExtent = default(double), double crossAxisExtent = default(double), FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection), Func<RenderSliver, RenderSliver> advance = default(Func<RenderSliver, RenderSliver>), double remainingCacheExtent = default(double), double cacheOrigin = default(double)) { throw new NotImplementedException(); }


        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }
        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new Rect DescribeSemanticsClip(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }
        public new Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _PaintContents(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect)) { throw new NotImplementedException(); }


        public virtual Offset ComputeAbsolutePaintOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }


        public virtual void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry) { throw new NotImplementedException(); }


        public virtual void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection) { throw new NotImplementedException(); }


        public virtual Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }


        public virtual double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild) { throw new NotImplementedException(); }


        public virtual double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }


        public virtual double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition) { throw new NotImplementedException(); }


        public virtual string LabelForChild(int index) { throw new NotImplementedException(); }


        public new void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        public virtual Rect ShowInViewport(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Rendering.Viewport.RenderAbstractViewport viewport = default(FlutterSDK.Rendering.Viewport.RenderAbstractViewport), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }

        #endregion
        RenderAbstractViewport _RenderAbstractViewportInstance = new RenderAbstractViewport();
        public FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object) => _RenderAbstractViewportInstance.Of(@object);
        public double DefaultCacheExtent => _RenderAbstractViewportInstance.DefaultCacheExtent;
    }


    public class RenderViewport : FlutterSDK.Rendering.Viewport.RenderViewportBase<FlutterSDK.Rendering.Sliver.SliverPhysicalContainerParentData>
    {
        #region constructors
        public RenderViewport(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double anchor = 0.0, List<FlutterSDK.Rendering.Sliver.RenderSliver> children = default(List<FlutterSDK.Rendering.Sliver.RenderSliver>), FlutterSDK.Rendering.Sliver.RenderSliver center = default(FlutterSDK.Rendering.Sliver.RenderSliver), double cacheExtent = default(double), FlutterSDK.Rendering.Viewport.CacheExtentStyle cacheExtentStyle = default(FlutterSDK.Rendering.Viewport.CacheExtentStyle))
        : base(axisDirection: axisDirection, crossAxisDirection: crossAxisDirection, offset: offset, cacheExtent: cacheExtent, cacheExtentStyle: cacheExtentStyle)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Semantics.Semantics.SemanticsTag UseTwoPaneSemantics { get; set; }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsTag ExcludeFromScrolling { get; set; }
        internal virtual double _Anchor { get; set; }
        internal virtual FlutterSDK.Rendering.Sliver.RenderSliver _Center { get; set; }
        internal virtual int _MaxLayoutCycles { get; set; }
        internal virtual double _MinScrollExtent { get; set; }
        internal virtual double _MaxScrollExtent { get; set; }
        internal virtual bool _HasVisualOverflow { get; set; }
        public virtual double Anchor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliver.RenderSliver Center { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexOfFirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void PerformResize() { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        private double _AttemptLayout(double mainAxisExtent, double crossAxisExtent, double correctedOffset) { throw new NotImplementedException(); }


        public new void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry) { throw new NotImplementedException(); }


        public new void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection) { throw new NotImplementedException(); }


        public new Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }


        public new double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild) { throw new NotImplementedException(); }


        public new double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }


        public new double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition) { throw new NotImplementedException(); }


        public new string LabelForChild(int index) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class RenderShrinkWrappingViewport : FlutterSDK.Rendering.Viewport.RenderViewportBase<FlutterSDK.Rendering.Sliver.SliverLogicalContainerParentData>
    {
        #region constructors
        public RenderShrinkWrappingViewport(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), List<FlutterSDK.Rendering.Sliver.RenderSliver> children = default(List<FlutterSDK.Rendering.Sliver.RenderSliver>))
        : base(axisDirection: axisDirection, crossAxisDirection: crossAxisDirection, offset: offset)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _MaxScrollExtent { get; set; }
        internal virtual double _ShrinkWrapExtent { get; set; }
        internal virtual bool _HasVisualOverflow { get; set; }
        public virtual bool HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int IndexOfFirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInPaintOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.Sliver.RenderSliver> ChildrenInHitTestOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new bool DebugThrowIfNotCheckingIntrinsics() { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        private double _AttemptLayout(double mainAxisExtent, double crossAxisExtent, double correctedOffset) { throw new NotImplementedException(); }


        public new void UpdateOutOfBandData(FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection, FlutterSDK.Rendering.Sliver.SliverGeometry childLayoutGeometry) { throw new NotImplementedException(); }


        public new void UpdateChildLayoutOffset(FlutterSDK.Rendering.Sliver.RenderSliver child, double layoutOffset, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection) { throw new NotImplementedException(); }


        public new Offset PaintOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }


        public new double ScrollOffsetOf(FlutterSDK.Rendering.Sliver.RenderSliver child, double scrollOffsetWithinChild) { throw new NotImplementedException(); }


        public new double MaxScrollObstructionExtentBefore(FlutterSDK.Rendering.Sliver.RenderSliver child) { throw new NotImplementedException(); }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }


        public new double ComputeChildMainAxisPosition(FlutterSDK.Rendering.Sliver.RenderSliver child, double parentMainAxisPosition) { throw new NotImplementedException(); }


        public new string LabelForChild(int index) { throw new NotImplementedException(); }

        #endregion
    }


    public enum CacheExtentStyle
    {

        Pixel,
        Viewport,
    }

}
