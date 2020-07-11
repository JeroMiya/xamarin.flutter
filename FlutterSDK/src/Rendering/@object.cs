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
namespace FlutterSDK.Rendering.@object
{
    public delegate void PaintingContextCallback(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
    public delegate void RenderObjectVisitor(FlutterSDK.Rendering.@object.RenderObject child);
    public delegate void LayoutCallback<T>(T constraints);
    internal static class ObjectDefaultClass
    {
    }

    public interface IConstraints
    {
        bool DebugAssertIsValid(bool isAppliedConstraint = false, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector));
        bool IsTight { get; }
        bool IsNormalized { get; }
    }


    public interface IRenderObject
    {
        void Reassemble();
        void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
        void AdoptChild(FlutterSDK.Rendering.@object.RenderObject child);
        void DropChild(FlutterSDK.Rendering.@object.RenderObject child);
        void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
        void DebugAssertDoesMeetConstraints();
        void MarkNeedsLayout();
        void MarkParentNeedsLayout();
        void MarkNeedsLayoutForSizedByParentChange();
        void ScheduleInitialLayout();
        void Layout(FlutterSDK.Rendering.@object.Constraints constraints, bool parentUsesSize = false);
        void DebugResetSize();
        void PerformResize();
        void PerformLayout();
        void InvokeLayoutCallback<T>(FlutterSDK.Rendering.@object.LayoutCallback<T> callback);
        void Rotate(int oldAngle = default(int), int newAngle = default(int), TimeSpan time = default(TimeSpan));
        void DebugRegisterRepaintBoundaryPaint(bool includedParent = true, bool includedChild = false);
        void MarkNeedsCompositingBitsUpdate();
        void MarkNeedsPaint();
        void ScheduleInitialPaint(FlutterSDK.Rendering.Layer.ContainerLayer rootLayer);
        void ReplaceRootLayer(FlutterSDK.Rendering.Layer.OffsetLayer rootLayer);
        void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset);
        void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform);
        Matrix4 GetTransformTo(FlutterSDK.Rendering.@object.RenderObject ancestor);
        Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child);
        Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child);
        void ScheduleInitialSemantics();
        void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
        void SendSemanticsEvent(FlutterSDK.Semantics.Semanticsevent.SemanticsEvent semanticsEvent);
        void ClearSemantics();
        void MarkNeedsSemanticsUpdate();
        void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor);
        void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry);
        string ToStringShort();
        string ToString(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeForError(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        FlutterSDK.Rendering.@object.ParentData ParentData { get; set; }
        object DebugCreator { get; set; }
        bool DebugCheckingIntrinsics { get; set; }
        bool DebugDoingThisResize { get; }
        bool DebugDoingThisLayout { get; }
        FlutterSDK.Rendering.@object.RenderObject DebugActiveLayout { get; }
        bool DebugCanParentUseSize { get; }
        FlutterSDK.Rendering.@object.PipelineOwner Owner { get; }
        bool DebugNeedsLayout { get; }
        FlutterSDK.Rendering.@object.Constraints Constraints { get; }
        bool SizedByParent { get; }
        bool DebugDoingThisPaint { get; }
        FlutterSDK.Rendering.@object.RenderObject DebugActivePaint { get; }
        bool IsRepaintBoundary { get; }
        bool AlwaysNeedsCompositing { get; }
        FlutterSDK.Rendering.Layer.ContainerLayer Layer { get; set; }
        FlutterSDK.Rendering.Layer.ContainerLayer DebugLayer { get; }
        bool NeedsCompositing { get; }
        bool DebugNeedsPaint { get; }
        FlutterBinding.UI.Rect PaintBounds { get; }
        FlutterBinding.UI.Rect SemanticBounds { get; }
        FlutterSDK.Semantics.Semantics.SemanticsNode DebugSemantics { get; }
    }


    internal interface I_SemanticsFragment
    {
        void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments);
        bool DropsSemanticsOfPreviousSiblings { get; }
        Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get; }
        bool AbortsWalk { get; }
    }


    internal interface I_InterestingSemanticsFragment
    {
        Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double));
        void MarkAsExplicit();
        void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments);
        void AddTags(Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> tags);
        void AddAncestor(FlutterSDK.Rendering.@object.RenderObject ancestor);
        FlutterSDK.Rendering.@object.RenderObject Owner { get; }
        FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get; }
        bool HasConfigForParent { get; }
        Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get; }
    }


    public interface IRenderObjectWithChildMixin<ChildType> { }

    public class RenderObjectWithChildMixin<ChildType>
    {
        internal virtual ChildType _Child { get; set; }
        public virtual ChildType Child { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual bool DebugValidateChild(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void RedepthChildren() { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }

    }
    public static class RenderObjectWithChildMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static RenderObjectWithChildMixin<ChildType> GetOrCreate<ChildType>(IRenderObjectWithChildMixin<ChildType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RenderObjectWithChildMixin<ChildType>();
                _table.Add(instance, value);
            }
            return (RenderObjectWithChildMixin<ChildType>)value;
        }
        public static ChildType ChildProperty<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).Child;
        public static bool DebugValidateChild<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance, FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).DebugValidateChild(child);
        public static void Attach<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).Detach();
        public static void RedepthChildren<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).RedepthChildren();
        public static void VisitChildren<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance, FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) => GetOrCreate(instance).VisitChildren(visitor);
        public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren<ChildType>(this IRenderObjectWithChildMixin<ChildType> instance) => GetOrCreate(instance).DebugDescribeChildren();
    }


    public interface IContainerParentDataMixin<ChildType> { }

    public class ContainerParentDataMixin<ChildType>
    {
        public virtual ChildType PreviousSibling { get; set; }
        public virtual ChildType NextSibling { get; set; }

        public new void Detach() { throw new NotImplementedException(); }

    }
    public static class ContainerParentDataMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static ContainerParentDataMixin<ChildType> GetOrCreate<ChildType>(IContainerParentDataMixin<ChildType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ContainerParentDataMixin<ChildType>();
                _table.Add(instance, value);
            }
            return (ContainerParentDataMixin<ChildType>)value;
        }
        public static ChildType PreviousSiblingProperty<ChildType>(this IContainerParentDataMixin<ChildType> instance) => GetOrCreate(instance).PreviousSibling;
        public static ChildType NextSiblingProperty<ChildType>(this IContainerParentDataMixin<ChildType> instance) => GetOrCreate(instance).NextSibling;
        public static void Detach<ChildType>(this IContainerParentDataMixin<ChildType> instance) => GetOrCreate(instance).Detach();
    }


    public interface IContainerRenderObjectMixin<ChildType, ParentDataType> { }

    public class ContainerRenderObjectMixin<ChildType, ParentDataType>
    {
        internal virtual int _ChildCount { get; set; }
        internal virtual ChildType _FirstChild { get; set; }
        internal virtual ChildType _LastChild { get; set; }
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual ChildType FirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual ChildType LastChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private bool _DebugUltimatePreviousSiblingOf(ChildType child, ChildType equals = default(ChildType)) { throw new NotImplementedException(); }


        private bool _DebugUltimateNextSiblingOf(ChildType child, ChildType equals = default(ChildType)) { throw new NotImplementedException(); }


        public virtual bool DebugValidateChild(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        private void _InsertIntoChildList(ChildType child, ChildType after = default(ChildType)) { throw new NotImplementedException(); }


        public virtual void Insert(ChildType child, ChildType after = default(ChildType)) { throw new NotImplementedException(); }


        public virtual void Add(ChildType child) { throw new NotImplementedException(); }


        public virtual void AddAll(List<ChildType> children) { throw new NotImplementedException(); }


        private void _RemoveFromChildList(ChildType child) { throw new NotImplementedException(); }


        public virtual void Remove(ChildType child) { throw new NotImplementedException(); }


        public virtual void RemoveAll() { throw new NotImplementedException(); }


        public virtual void Move(ChildType child, ChildType after = default(ChildType)) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void RedepthChildren() { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public virtual ChildType ChildBefore(ChildType child) { throw new NotImplementedException(); }


        public virtual ChildType ChildAfter(ChildType child) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }

    }
    public static class ContainerRenderObjectMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static ContainerRenderObjectMixin<ChildType, ParentDataType> GetOrCreate<ChildType, ParentDataType>(IContainerRenderObjectMixin<ChildType, ParentDataType> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ContainerRenderObjectMixin<ChildType, ParentDataType>();
                _table.Add(instance, value);
            }
            return (ContainerRenderObjectMixin<ChildType, ParentDataType>)value;
        }
        public static int ChildCountProperty<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).ChildCount;
        public static ChildType FirstChildProperty<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).FirstChild;
        public static ChildType LastChildProperty<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).LastChild;
        public static bool DebugValidateChild<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).DebugValidateChild(child);
        public static void Insert<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child, ChildType after = default(ChildType)) => GetOrCreate(instance).Insert(child, after);
        public static void Add<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).Add(child);
        public static void AddAll<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, List<ChildType> children) => GetOrCreate(instance).AddAll(children);
        public static void Remove<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).Remove(child);
        public static void RemoveAll<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).RemoveAll();
        public static void Move<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child, ChildType after = default(ChildType)) => GetOrCreate(instance).Move(child, after);
        public static void Attach<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).Detach();
        public static void RedepthChildren<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).RedepthChildren();
        public static void VisitChildren<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) => GetOrCreate(instance).VisitChildren(visitor);
        public static ChildType ChildBefore<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).ChildBefore(child);
        public static ChildType ChildAfter<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance, ChildType child) => GetOrCreate(instance).ChildAfter(child);
        public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren<ChildType, ParentDataType>(this IContainerRenderObjectMixin<ChildType, ParentDataType> instance) => GetOrCreate(instance).DebugDescribeChildren();
    }


    public interface IRelayoutWhenSystemFontsChangeMixin { }

    public class RelayoutWhenSystemFontsChangeMixin
    {

        public virtual void SystemFontsDidChange() { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }

    }
    public static class RelayoutWhenSystemFontsChangeMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IRelayoutWhenSystemFontsChangeMixin, RelayoutWhenSystemFontsChangeMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRelayoutWhenSystemFontsChangeMixin, RelayoutWhenSystemFontsChangeMixin>();
        static RelayoutWhenSystemFontsChangeMixin GetOrCreate(IRelayoutWhenSystemFontsChangeMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new RelayoutWhenSystemFontsChangeMixin();
                _table.Add(instance, value);
            }
            return (RelayoutWhenSystemFontsChangeMixin)value;
        }
        public static void SystemFontsDidChange(this IRelayoutWhenSystemFontsChangeMixin instance) => GetOrCreate(instance).SystemFontsDidChange();
        public static void Attach(this IRelayoutWhenSystemFontsChangeMixin instance, FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
        public static void Detach(this IRelayoutWhenSystemFontsChangeMixin instance) => GetOrCreate(instance).Detach();
    }


    public interface IParentData { }

    public class ParentData
    {

        public virtual void Detach() { throw new NotImplementedException(); }


    }
    public static class ParentDataMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IParentData, ParentData> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IParentData, ParentData>();
        static ParentData GetOrCreate(IParentData instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ParentData();
                _table.Add(instance, value);
            }
            return (ParentData)value;
        }
        public static void Detach(this IParentData instance) => GetOrCreate(instance).Detach();
        public static string ToString(this IParentData instance) => GetOrCreate(instance).ToString();
    }


    public class PaintingContext : FlutterSDK.Painting.Clip.ClipContext
    {
        #region constructors
        public PaintingContext(FlutterSDK.Rendering.Layer.ContainerLayer _containerLayer, FlutterBinding.UI.Rect estimatedBounds)
        : base()
        {
            this._ContainerLayer = _containerLayer;
            this.EstimatedBounds = estimatedBounds; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Layer.ContainerLayer _ContainerLayer { get; set; }
        public virtual FlutterBinding.UI.Rect EstimatedBounds { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.PictureLayer _CurrentLayer { get; set; }
        internal virtual PictureRecorder _Recorder { get; set; }
        internal virtual Canvas _Canvas { get; set; }
        internal virtual bool _IsRecording { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Canvas Canvas { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void RepaintCompositedChild(FlutterSDK.Rendering.@object.RenderObject child, bool debugAlsoPaintedParent = false) { throw new NotImplementedException(); }


        private void _RepaintCompositedChild(FlutterSDK.Rendering.@object.RenderObject child, bool debugAlsoPaintedParent = false, FlutterSDK.Rendering.@object.PaintingContext childContext = default(FlutterSDK.Rendering.@object.PaintingContext)) { throw new NotImplementedException(); }


        public virtual void DebugInstrumentRepaintCompositedChild(FlutterSDK.Rendering.@object.RenderObject child, bool debugAlsoPaintedParent = false, FlutterSDK.Rendering.@object.PaintingContext customContext = default(FlutterSDK.Rendering.@object.PaintingContext)) { throw new NotImplementedException(); }


        public virtual void PaintChild(FlutterSDK.Rendering.@object.RenderObject child, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _CompositeChild(FlutterSDK.Rendering.@object.RenderObject child, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public virtual void AppendLayer(FlutterSDK.Rendering.Layer.Layer layer) { throw new NotImplementedException(); }


        private void _StartRecording() { throw new NotImplementedException(); }


        public virtual void StopRecordingIfNeeded() { throw new NotImplementedException(); }


        public virtual void SetIsComplexHint() { throw new NotImplementedException(); }


        public virtual void SetWillChangeHint() { throw new NotImplementedException(); }


        public virtual void AddLayer(FlutterSDK.Rendering.Layer.Layer layer) { throw new NotImplementedException(); }


        public virtual void PushLayer(FlutterSDK.Rendering.Layer.ContainerLayer childLayer, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect childPaintBounds = default(FlutterBinding.UI.Rect)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.@object.PaintingContext CreateChildContext(FlutterSDK.Rendering.Layer.ContainerLayer childLayer, FlutterBinding.UI.Rect bounds) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Layer.ClipRectLayer PushClipRect(bool needsCompositing, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect clipRect, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Layer.ClipRectLayer oldLayer = default(FlutterSDK.Rendering.Layer.ClipRectLayer)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Layer.ClipRRectLayer PushClipRRect(bool needsCompositing, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect bounds, FlutterBinding.UI.RRect clipRRect, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Layer.ClipRRectLayer oldLayer = default(FlutterSDK.Rendering.Layer.ClipRRectLayer)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Layer.ClipPathLayer PushClipPath(bool needsCompositing, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect bounds, Path clipPath, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Rendering.Layer.ClipPathLayer oldLayer = default(FlutterSDK.Rendering.Layer.ClipPathLayer)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Layer.ColorFilterLayer PushColorFilter(FlutterBinding.UI.Offset offset, ColorFilter colorFilter, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterSDK.Rendering.Layer.ColorFilterLayer oldLayer = default(FlutterSDK.Rendering.Layer.ColorFilterLayer)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Layer.TransformLayer PushTransform(bool needsCompositing, FlutterBinding.UI.Offset offset, Matrix4 transform, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterSDK.Rendering.Layer.TransformLayer oldLayer = default(FlutterSDK.Rendering.Layer.TransformLayer)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Layer.OpacityLayer PushOpacity(FlutterBinding.UI.Offset offset, int alpha, FlutterSDK.Rendering.@object.PaintingContextCallback painter, FlutterSDK.Rendering.Layer.OpacityLayer oldLayer = default(FlutterSDK.Rendering.Layer.OpacityLayer)) { throw new NotImplementedException(); }


        #endregion
    }


    public class Constraints
    {
        #region constructors
        public Constraints()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool IsTight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNormalized { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual bool DebugAssertIsValid(bool isAppliedConstraint = false, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector)) { throw new NotImplementedException(); }

        #endregion
    }


    public class SemanticsHandle
    {
        #region constructors
        internal SemanticsHandle(FlutterSDK.Rendering.@object.PipelineOwner _owner, VoidCallback listener)
        : base()
        {
            this._Owner = _owner;
            this.Listener = listener; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.@object.PipelineOwner _Owner { get; set; }
        public virtual VoidCallback Listener { get; set; }
        #endregion

        #region methods

        public virtual void Dispose() { throw new NotImplementedException(); }

        #endregion
    }


    public class PipelineOwner
    {
        #region constructors
        public PipelineOwner(VoidCallback onNeedVisualUpdate = default(VoidCallback), VoidCallback onSemanticsOwnerCreated = default(VoidCallback), VoidCallback onSemanticsOwnerDisposed = default(VoidCallback))
        {
            this.OnNeedVisualUpdate = onNeedVisualUpdate;
            this.OnSemanticsOwnerCreated = onSemanticsOwnerCreated;
            this.OnSemanticsOwnerDisposed = onSemanticsOwnerDisposed; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual VoidCallback OnNeedVisualUpdate { get; set; }
        public virtual VoidCallback OnSemanticsOwnerCreated { get; set; }
        public virtual VoidCallback OnSemanticsOwnerDisposed { get; set; }
        internal virtual FlutterSDK.Foundation.Node.AbstractNode _RootNode { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingLayout { get; set; }
        internal virtual bool _DebugDoingLayout { get; set; }
        internal virtual bool _DebugAllowMutationsToDirtySubtrees { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingCompositingBitsUpdate { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingPaint { get; set; }
        internal virtual bool _DebugDoingPaint { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsOwner _SemanticsOwner { get; set; }
        internal virtual int _OutstandingSemanticsHandles { get; set; }
        internal virtual bool _DebugDoingSemantics { get; set; }
        internal virtual HashSet<FlutterSDK.Rendering.@object.RenderObject> _NodesNeedingSemantics { get; set; }
        public virtual FlutterSDK.Foundation.Node.AbstractNode RootNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingPaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsOwner SemanticsOwner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int DebugOutstandingSemanticsHandles { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void RequestVisualUpdate() { throw new NotImplementedException(); }


        public virtual void FlushLayout() { throw new NotImplementedException(); }


        private void _EnableMutationsToDirtySubtrees(VoidCallback callback) { throw new NotImplementedException(); }


        public virtual void FlushCompositingBits() { throw new NotImplementedException(); }


        public virtual void FlushPaint() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.@object.SemanticsHandle EnsureSemantics(VoidCallback listener = default(VoidCallback)) { throw new NotImplementedException(); }


        private void _DidDisposeSemanticsHandle() { throw new NotImplementedException(); }


        public virtual void FlushSemantics() { throw new NotImplementedException(); }

        #endregion
    }


    public class RenderObject : FlutterSDK.Foundation.Node.AbstractNode, IHitTestTarget, IDiagnosticableTreeMixin
    {
        #region constructors
        public RenderObject()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.@object.ParentData ParentData { get; set; }
        public virtual object DebugCreator { get; set; }
        internal virtual bool _DebugDoingThisResize { get; set; }
        internal virtual bool _DebugDoingThisLayout { get; set; }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _DebugActiveLayout { get; set; }
        internal virtual bool _DebugCanParentUseSize { get; set; }
        internal virtual bool _DebugMutationsLocked { get; set; }
        internal virtual bool _NeedsLayout { get; set; }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _RelayoutBoundary { get; set; }
        internal virtual bool _DoingThisLayoutWithCallback { get; set; }
        internal virtual FlutterSDK.Rendering.@object.Constraints _Constraints { get; set; }
        public virtual bool DebugCheckingIntrinsics { get; set; }
        internal virtual bool _DebugDoingThisPaint { get; set; }
        internal virtual FlutterSDK.Rendering.@object.RenderObject _DebugActivePaint { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.ContainerLayer _Layer { get; set; }
        internal virtual bool _NeedsCompositingBitsUpdate { get; set; }
        internal virtual bool _NeedsCompositing { get; set; }
        internal virtual bool _NeedsPaint { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _CachedSemanticsConfiguration { get; set; }
        internal virtual bool _NeedsSemanticsUpdate { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsNode _Semantics { get; set; }
        public virtual bool DebugDoingThisResize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingThisLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject DebugActiveLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugCanParentUseSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DebugCanPerformMutations { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.PipelineOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugNeedsLayout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.Constraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingThisPaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject DebugActivePaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.ContainerLayer Layer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.ContainerLayer DebugLayer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool NeedsCompositing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugNeedsPaint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect PaintBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _SemanticsConfiguration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect SemanticBounds { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsNode DebugSemantics { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void Reassemble() { throw new NotImplementedException(); }


        public virtual void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void AdoptChild(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }
        public new void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child) { throw new NotImplementedException(); }


        public new void DropChild(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }
        public new void DropChild(FlutterSDK.Foundation.Node.AbstractNode child) { throw new NotImplementedException(); }


        public virtual void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        private void _DebugReportException(string method, object exception, StackTrace stack) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public virtual void DebugAssertDoesMeetConstraints() { throw new NotImplementedException(); }


        private bool _DebugSubtreeRelayoutRootAlreadyMarkedNeedsLayout() { throw new NotImplementedException(); }


        public virtual void MarkNeedsLayout() { throw new NotImplementedException(); }


        public virtual void MarkParentNeedsLayout() { throw new NotImplementedException(); }


        public virtual void MarkNeedsLayoutForSizedByParentChange() { throw new NotImplementedException(); }


        private void _CleanRelayoutBoundary() { throw new NotImplementedException(); }


        private void _CleanChildRelayoutBoundary(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public virtual void ScheduleInitialLayout() { throw new NotImplementedException(); }


        private void _LayoutWithoutResize() { throw new NotImplementedException(); }


        public virtual void Layout(FlutterSDK.Rendering.@object.Constraints constraints, bool parentUsesSize = false) { throw new NotImplementedException(); }


        public virtual void DebugResetSize() { throw new NotImplementedException(); }


        public virtual void PerformResize() { throw new NotImplementedException(); }


        public virtual void PerformLayout() { throw new NotImplementedException(); }


        public virtual void InvokeLayoutCallback<T>(FlutterSDK.Rendering.@object.LayoutCallback<T> callback) { throw new NotImplementedException(); }


        public virtual void Rotate(int oldAngle = default(int), int newAngle = default(int), TimeSpan time = default(TimeSpan)) { throw new NotImplementedException(); }


        public virtual void DebugRegisterRepaintBoundaryPaint(bool includedParent = true, bool includedChild = false) { throw new NotImplementedException(); }


        public virtual void MarkNeedsCompositingBitsUpdate() { throw new NotImplementedException(); }


        private void _UpdateCompositingBits() { throw new NotImplementedException(); }


        public virtual void MarkNeedsPaint() { throw new NotImplementedException(); }


        private void _SkippedPaintingOnLayer() { throw new NotImplementedException(); }


        public virtual void ScheduleInitialPaint(FlutterSDK.Rendering.Layer.ContainerLayer rootLayer) { throw new NotImplementedException(); }


        public virtual void ReplaceRootLayer(FlutterSDK.Rendering.Layer.OffsetLayer rootLayer) { throw new NotImplementedException(); }


        private void _PaintWithContext(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public virtual void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public virtual void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public virtual void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }


        public virtual Matrix4 GetTransformTo(FlutterSDK.Rendering.@object.RenderObject ancestor) { throw new NotImplementedException(); }


        public virtual Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public virtual Rect DescribeSemanticsClip(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public virtual void ScheduleInitialSemantics() { throw new NotImplementedException(); }


        public virtual void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }


        public virtual void SendSemanticsEvent(FlutterSDK.Semantics.Semanticsevent.SemanticsEvent semanticsEvent) { throw new NotImplementedException(); }


        public virtual void ClearSemantics() { throw new NotImplementedException(); }


        public virtual void MarkNeedsSemanticsUpdate() { throw new NotImplementedException(); }


        private void _UpdateSemantics() { throw new NotImplementedException(); }


        private FlutterSDK.Rendering.@object._SemanticsFragment _GetSemanticsForParent(bool mergeIntoParent = default(bool)) { throw new NotImplementedException(); }


        public virtual void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public virtual void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }



        public new string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }


        public new string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }


        public virtual void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeForError(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }

        #endregion
    }


    public class FlutterErrorDetailsForRendering : FlutterSDK.Foundation.Assertions.FlutterErrorDetails
    {
        #region constructors
        public FlutterErrorDetailsForRendering(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Rendering.@object.RenderObject renderObject = default(FlutterSDK.Rendering.@object.RenderObject), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
        : base(exception: exception, stack: stack, library: library, context: context, informationCollector: informationCollector, silent: silent)
        {
            this.RenderObject = renderObject; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.@object.RenderObject RenderObject { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _SemanticsFragment
    {
        #region constructors
        public _SemanticsFragment(bool dropsSemanticsOfPreviousSiblings = default(bool))
        : base()
        {
            this.DropsSemanticsOfPreviousSiblings = dropsSemanticsOfPreviousSiblings; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool DropsSemanticsOfPreviousSiblings { get; set; }
        public virtual Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AbortsWalk { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ContainerSemanticsFragment : FlutterSDK.Rendering.@object._SemanticsFragment
    {
        #region constructors
        public _ContainerSemanticsFragment(bool dropsSemanticsOfPreviousSiblings = default(bool))
        : base(dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new List<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get; set; }
        #endregion

        #region methods

        public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments) { throw new NotImplementedException(); }

        #endregion
    }


    public class _InterestingSemanticsFragment : FlutterSDK.Rendering.@object._SemanticsFragment
    {
        #region constructors
        public _InterestingSemanticsFragment(FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject), bool dropsSemanticsOfPreviousSiblings = default(bool))
        : base(dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<FlutterSDK.Rendering.@object.RenderObject> _AncestorChain { get; set; }
        internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> _TagsForChildren { get; set; }
        public virtual FlutterSDK.Rendering.@object.RenderObject Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasConfigForParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> InterestingFragments { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double)) { throw new NotImplementedException(); }


        public virtual void MarkAsExplicit() { throw new NotImplementedException(); }


        public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments) { throw new NotImplementedException(); }


        public virtual void AddTags(Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> tags) { throw new NotImplementedException(); }


        public virtual void AddAncestor(FlutterSDK.Rendering.@object.RenderObject ancestor) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RootSemanticsFragment : FlutterSDK.Rendering.@object._InterestingSemanticsFragment
    {
        #region constructors
        public _RootSemanticsFragment(FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject), bool dropsSemanticsOfPreviousSiblings = default(bool))
        : base(owner: owner, dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> _Children { get; set; }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double)) { throw new NotImplementedException(); }


        public new void MarkAsExplicit() { throw new NotImplementedException(); }


        public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SwitchableSemanticsFragment : FlutterSDK.Rendering.@object._InterestingSemanticsFragment
    {
        #region constructors
        public _SwitchableSemanticsFragment(bool mergeIntoParent = default(bool), FlutterSDK.Semantics.Semantics.SemanticsConfiguration config = default(FlutterSDK.Semantics.Semantics.SemanticsConfiguration), FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject), bool dropsSemanticsOfPreviousSiblings = default(bool))
        : base(owner: owner, dropsSemanticsOfPreviousSiblings: dropsSemanticsOfPreviousSiblings)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual bool _MergeIntoParent { get; set; }
        internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _Config { get; set; }
        internal virtual bool _IsConfigWritable { get; set; }
        internal virtual List<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> _Children { get; set; }
        internal virtual bool _IsExplicit { get; set; }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _NeedsGeometryUpdate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double)) { throw new NotImplementedException(); }


        public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments) { throw new NotImplementedException(); }


        private void _EnsureConfigIsWritable() { throw new NotImplementedException(); }


        public new void MarkAsExplicit() { throw new NotImplementedException(); }

        #endregion
    }


    public class _AbortingSemanticsFragment : FlutterSDK.Rendering.@object._InterestingSemanticsFragment
    {
        #region constructors
        public _AbortingSemanticsFragment(FlutterSDK.Rendering.@object.RenderObject owner = default(FlutterSDK.Rendering.@object.RenderObject))
        : base(owner: owner, dropsSemanticsOfPreviousSiblings: false)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool AbortsWalk { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Config { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddAll(Iterable<FlutterSDK.Rendering.@object._InterestingSemanticsFragment> fragments) { throw new NotImplementedException(); }


        public new Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> CompileChildren(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), double elevationAdjustment = default(double)) { throw new NotImplementedException(); }


        public new void MarkAsExplicit() { throw new NotImplementedException(); }

        #endregion
    }


    public class _SemanticsGeometry
    {
        #region constructors
        public _SemanticsGeometry(FlutterBinding.UI.Rect parentSemanticsClipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect parentPaintClipRect = default(FlutterBinding.UI.Rect), List<FlutterSDK.Rendering.@object.RenderObject> ancestors = default(List<FlutterSDK.Rendering.@object.RenderObject>))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Rect _PaintClipRect { get; set; }
        internal virtual FlutterBinding.UI.Rect _SemanticsClipRect { get; set; }
        internal virtual Matrix4 _Transform { get; set; }
        internal virtual FlutterBinding.UI.Rect _Rect { get; set; }
        internal virtual Matrix4 _TemporaryTransformHolder { get; set; }
        internal virtual bool _MarkAsHidden { get; set; }
        public virtual object Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect SemanticsClipRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect PaintClipRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DropFromTree { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool MarkAsHidden { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _ComputeValues(FlutterBinding.UI.Rect parentSemanticsClipRect, FlutterBinding.UI.Rect parentPaintClipRect, List<FlutterSDK.Rendering.@object.RenderObject> ancestors) { throw new NotImplementedException(); }


        private Rect _TransformRect(FlutterBinding.UI.Rect rect, Matrix4 transform) { throw new NotImplementedException(); }


        private void _ApplyIntermediatePaintTransforms(FlutterSDK.Rendering.@object.RenderObject ancestor, FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform, Matrix4 clipRectTransform) { throw new NotImplementedException(); }


        private Rect _IntersectRects(FlutterBinding.UI.Rect a, FlutterBinding.UI.Rect b) { throw new NotImplementedException(); }

        #endregion
    }


    public class DiagnosticsDebugCreator : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<@Object>
    {
        #region constructors
        public DiagnosticsDebugCreator(@Object value)
        : base("debugCreator", value, level: DiagnosticLevel.Hidden)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }

}
