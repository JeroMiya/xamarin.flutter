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
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Framework
{
    public delegate void StateSetter(VoidCallback fn);
    public delegate void ElementVisitor(FlutterSDK.Widgets.Framework.Element element);
    public delegate FlutterSDK.Widgets.Framework.Widget ErrorWidgetBuilder(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details);
    public delegate FlutterSDK.Widgets.Framework.Widget WidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context);
    public delegate FlutterSDK.Widgets.Framework.Widget IndexedWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, int index);
    public delegate FlutterSDK.Widgets.Framework.Widget TransitionBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child);
    public delegate FlutterSDK.Widgets.Framework.Widget ControlsWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, VoidCallback onStepContinue = default(VoidCallback), VoidCallback onStepCancel = default(VoidCallback));
    internal static class FrameworkDefaultClass
    {
        internal static FlutterSDK.Foundation.Assertions.FlutterErrorDetails _DebugReportException(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context, object exception, StackTrace stack, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
        {
            throw new NotImplementedException();
        }

    }

    public interface IGlobalKey<T>
    {
        FlutterSDK.Widgets.Framework.BuildContext CurrentContext { get; }
        FlutterSDK.Widgets.Framework.Widget CurrentWidget { get; }
        T CurrentState { get; }
    }


    public interface IWidget
    {
        FlutterSDK.Widgets.Framework.Element CreateElement();
        string ToStringShort();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        bool Equals(@Object other);
        bool CanUpdate(FlutterSDK.Widgets.Framework.Widget oldWidget, FlutterSDK.Widgets.Framework.Widget newWidget);
        FlutterSDK.Foundation.Key.Key Key { get; }
        int HashCode { get; }
    }


    public interface IStatelessWidget
    {
        FlutterSDK.Widgets.Framework.StatelessElement CreateElement();
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
    }


    public interface IStatefulWidget
    {
        FlutterSDK.Widgets.Framework.StatefulElement CreateElement();
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState();
    }


    public interface IState<T>
    {
        void InitState();
        void DidUpdateWidget(T oldWidget);
        void Reassemble();
        void SetState(VoidCallback fn);
        void Deactivate();
        void Dispose();
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
        void DidChangeDependencies();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        T Widget { get; }
        FlutterSDK.Widgets.Framework.BuildContext Context { get; }
        bool Mounted { get; }
    }


    public interface IProxyWidget
    {
        FlutterSDK.Widgets.Framework.Widget Child { get; }
    }


    public interface IParentDataWidget<T>
    {
        ParentDataElement<T> CreateElement();
        bool DebugIsValidRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject);
        void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject);
        bool DebugCanApplyOutOfTurn();
        Type DebugTypicalAncestorWidgetClass { get; }
    }


    public interface IInheritedWidget
    {
        FlutterSDK.Widgets.Framework.InheritedElement CreateElement();
        bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget);
    }


    public interface IRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement();
        FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
        void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject);
        void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject);
    }


    public interface ILeafRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.LeafRenderObjectElement CreateElement();
    }


    public interface ISingleChildRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement CreateElement();
        FlutterSDK.Widgets.Framework.Widget Child { get; }
    }


    public interface IMultiChildRenderObjectWidget
    {
        FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement CreateElement();
        List<FlutterSDK.Widgets.Framework.Widget> Children { get; }
    }


    public interface IElement
    {
        bool Equals(@Object other);
        void Reassemble();
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(Type expectedAncestorType = default(Type));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElements(string name, Iterable<FlutterSDK.Widgets.Framework.Element> elements);
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(string name);
        void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        void VisitChildElements(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot);
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
        void Update(FlutterSDK.Widgets.Framework.Widget newWidget);
        void UpdateSlotForChild(FlutterSDK.Widgets.Framework.Element child, object newSlot);
        void DetachRenderObject();
        void AttachRenderObject(object newSlot);
        FlutterSDK.Widgets.Framework.Element InflateWidget(FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot);
        void DeactivateChild(FlutterSDK.Widgets.Framework.Element child);
        void ForgetChild(FlutterSDK.Widgets.Framework.Element child);
        void Activate();
        void Deactivate();
        void DebugDeactivated();
        void Unmount();
        FlutterSDK.Rendering.@object.RenderObject FindRenderObject();
        FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object));
        FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object));
        FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(Type targetType, @Object aspect = default(@Object));
        T DependOnInheritedWidgetOfExactType<T>(@Object aspect = default(@Object));
        FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(Type targetType);
        FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>();
        FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(Type targetType);
        T FindAncestorWidgetOfExactType<T>();
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher);
        T FindAncestorStateOfType<T>();
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher);
        T FindRootAncestorStateOfType<T>();
        FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher);
        T FindAncestorRenderObjectOfType<T>();
        void VisitAncestorElements(Func<bool, Element> visitor);
        void DidChangeDependencies();
        string DebugGetCreatorChain(int limit);
        List<FlutterSDK.Widgets.Framework.Element> DebugGetDiagnosticChain();
        string ToStringShort();
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
        void MarkNeedsBuild();
        void Rebuild();
        void PerformRebuild();
        int HashCode { get; }
        object Slot { get; }
        int Depth { get; }
        FlutterSDK.Widgets.Framework.Widget Widget { get; }
        FlutterSDK.Widgets.Framework.BuildOwner Owner { get; }
        FlutterSDK.Rendering.@object.RenderObject RenderObject { get; }
        Size Size { get; }
        bool Dirty { get; }
    }


    public interface IComponentElement
    {
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
        void PerformRebuild();
        FlutterSDK.Widgets.Framework.Widget Build();
        void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor);
        void ForgetChild(FlutterSDK.Widgets.Framework.Element child);
        bool DebugDoingBuild { get; }
    }


    public interface IProxyElement
    {
        FlutterSDK.Widgets.Framework.Widget Build();
        void Update(FlutterSDK.Widgets.Framework.ProxyWidget newWidget);
        void Updated(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget);
        void NotifyClients(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget);
        FlutterSDK.Widgets.Framework.ProxyWidget Widget { get; }
    }


    public interface IRenderObjectElement
    {
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
        void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget);
        void PerformRebuild();
        List<FlutterSDK.Widgets.Framework.Element> UpdateChildren(List<FlutterSDK.Widgets.Framework.Element> oldChildren, List<FlutterSDK.Widgets.Framework.Widget> newWidgets, HashSet<FlutterSDK.Widgets.Framework.Element> forgottenChildren = default(HashSet<FlutterSDK.Widgets.Framework.Element>));
        void Deactivate();
        void Unmount();
        void AttachRenderObject(object newSlot);
        void DetachRenderObject();
        void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot);
        void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot);
        void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Widgets.Framework.RenderObjectWidget Widget { get; }
        FlutterSDK.Rendering.@object.RenderObject RenderObject { get; }
        bool DebugDoingBuild { get; }
    }


    public interface IRootRenderObjectElement
    {
        void AssignOwner(FlutterSDK.Widgets.Framework.BuildOwner owner);
        void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot);
    }


    public interface I_InactiveElements { }

    public class _InactiveElements
    {
        internal virtual bool _Locked { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _Elements { get; set; }

        private void _Unmount(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        private void _UnmountAll() { throw new NotImplementedException(); }


        private void _DeactivateRecursively(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        public virtual void Add(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        public virtual void Remove(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        public virtual bool DebugContains(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }

    }
    public static class _InactiveElementsMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<I_InactiveElements, _InactiveElements> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_InactiveElements, _InactiveElements>();
        static _InactiveElements GetOrCreate(I_InactiveElements instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new _InactiveElements();
                _table.Add(instance, value);
            }
            return (_InactiveElements)value;
        }
        public static void Add(this I_InactiveElements instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).Add(element);
        public static void Remove(this I_InactiveElements instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).Remove(element);
        public static bool DebugContains(this I_InactiveElements instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).DebugContains(element);
    }


    public interface IBuildContext { }

    public class BuildContext
    {
        public virtual FlutterSDK.Widgets.Framework.Widget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingBuild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual FlutterSDK.Rendering.@object.RenderObject FindRenderObject() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(Type targetType, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public virtual T DependOnInheritedWidgetOfExactType<T>(@Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(Type targetType) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(Type targetType) { throw new NotImplementedException(); }


        public virtual T FindAncestorWidgetOfExactType<T>() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) { throw new NotImplementedException(); }


        public virtual T FindAncestorStateOfType<T>() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) { throw new NotImplementedException(); }


        public virtual T FindRootAncestorStateOfType<T>() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) { throw new NotImplementedException(); }


        public virtual T FindAncestorRenderObjectOfType<T>() { throw new NotImplementedException(); }


        public virtual void VisitAncestorElements(Func<bool, Element> visitor) { throw new NotImplementedException(); }


        public virtual void VisitChildElements(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(Type expectedAncestorType = default(Type)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(string name) { throw new NotImplementedException(); }

    }
    public static class BuildContextMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IBuildContext, BuildContext> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IBuildContext, BuildContext>();
        static BuildContext GetOrCreate(IBuildContext instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new BuildContext();
                _table.Add(instance, value);
            }
            return (BuildContext)value;
        }
        public static FlutterSDK.Widgets.Framework.Widget WidgetProperty(this IBuildContext instance) => GetOrCreate(instance).Widget;
        public static FlutterSDK.Widgets.Framework.BuildOwner OwnerProperty(this IBuildContext instance) => GetOrCreate(instance).Owner;
        public static bool DebugDoingBuildProperty(this IBuildContext instance) => GetOrCreate(instance).DebugDoingBuild;
        public static Size SizeProperty(this IBuildContext instance) => GetOrCreate(instance).Size;
        public static FlutterSDK.Rendering.@object.RenderObject FindRenderObject(this IBuildContext instance) => GetOrCreate(instance).FindRenderObject();
        public static FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(this IBuildContext instance, FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) => GetOrCreate(instance).InheritFromElement(ancestor, aspect);
        public static FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(this IBuildContext instance, FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) => GetOrCreate(instance).DependOnInheritedElement(ancestor, aspect);
        public static FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(this IBuildContext instance, Type targetType, @Object aspect = default(@Object)) => GetOrCreate(instance).InheritFromWidgetOfExactType(targetType, aspect);
        public static T DependOnInheritedWidgetOfExactType<T>(this IBuildContext instance, @Object aspect = default(@Object)) => GetOrCreate(instance).DependOnInheritedWidgetOfExactType<T>(aspect);
        public static FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(this IBuildContext instance, Type targetType) => GetOrCreate(instance).AncestorInheritedElementForWidgetOfExactType(targetType);
        public static FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>(this IBuildContext instance) => GetOrCreate(instance).GetElementForInheritedWidgetOfExactType<T>();
        public static FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(this IBuildContext instance, Type targetType) => GetOrCreate(instance).AncestorWidgetOfExactType(targetType);
        public static T FindAncestorWidgetOfExactType<T>(this IBuildContext instance) => GetOrCreate(instance).FindAncestorWidgetOfExactType<T>();
        public static FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(this IBuildContext instance, FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) => GetOrCreate(instance).AncestorStateOfType(matcher);
        public static T FindAncestorStateOfType<T>(this IBuildContext instance) => GetOrCreate(instance).FindAncestorStateOfType<T>();
        public static FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(this IBuildContext instance, FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) => GetOrCreate(instance).RootAncestorStateOfType(matcher);
        public static T FindRootAncestorStateOfType<T>(this IBuildContext instance) => GetOrCreate(instance).FindRootAncestorStateOfType<T>();
        public static FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(this IBuildContext instance, FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) => GetOrCreate(instance).AncestorRenderObjectOfType(matcher);
        public static T FindAncestorRenderObjectOfType<T>(this IBuildContext instance) => GetOrCreate(instance).FindAncestorRenderObjectOfType<T>();
        public static void VisitAncestorElements(this IBuildContext instance, Func<bool, Element> visitor) => GetOrCreate(instance).VisitAncestorElements(visitor);
        public static void VisitChildElements(this IBuildContext instance, FlutterSDK.Widgets.Framework.ElementVisitor visitor) => GetOrCreate(instance).VisitChildElements(visitor);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(this IBuildContext instance, string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).DescribeElement(name, style);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(this IBuildContext instance, string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).DescribeWidget(name, style);
        public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(this IBuildContext instance, Type expectedAncestorType = default(Type)) => GetOrCreate(instance).DescribeMissingAncestor(expectedAncestorType);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(this IBuildContext instance, string name) => GetOrCreate(instance).DescribeOwnershipChain(name);
    }


    public class UniqueKey : FlutterSDK.Foundation.Key.LocalKey
    {
        #region constructors
        public UniqueKey()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        #endregion
    }


    public class ObjectKey : FlutterSDK.Foundation.Key.LocalKey
    {
        #region constructors
        public ObjectKey(@Object value)
        {
            this.Value = value; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual @Object Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class GlobalKey<T> : FlutterSDK.Foundation.Key.Key
    {
        #region constructors
        public GlobalKey(string debugLabel = default(string))
        {
            throw new NotImplementedException();
        }
        public static GlobalKey<T> Constructor()
        {
            var instance = new GlobalKey<T>(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>, FlutterSDK.Widgets.Framework.Element> _Registry { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _DebugIllFatedElements { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.Element, Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>>> _DebugReservations { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _CurrentElement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext CurrentContext { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget CurrentWidget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual T CurrentState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _DebugRemoveReservationFor(FlutterSDK.Widgets.Framework.Element parent, FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        private void _Register(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        private void _Unregister(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        private void _DebugReserveFor(FlutterSDK.Widgets.Framework.Element parent, FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        private void _DebugVerifyGlobalKeyReservation() { throw new NotImplementedException(); }


        private void _DebugVerifyIllFatedPopulation() { throw new NotImplementedException(); }

        #endregion
    }


    public class LabeledGlobalKey<T> : FlutterSDK.Widgets.Framework.GlobalKey<T>
    {
        #region constructors
        public LabeledGlobalKey(string _debugLabel)
        : base()
        {
            this._DebugLabel = _debugLabel; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual string _DebugLabel { get; set; }
        #endregion

        #region methods

        #endregion
    }


    public class GlobalObjectKey<T> : FlutterSDK.Widgets.Framework.GlobalKey<T>
    {
        #region constructors
        public GlobalObjectKey(@Object value)
        : base()
        {
            this.Value = value; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual @Object Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class TypeMatcher<T>
    {
        #region constructors
        public TypeMatcher()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual bool Check(object @object) { throw new NotImplementedException(); }

        #endregion
    }


    public class Widget : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
    {
        #region constructors
        public Widget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        {
            this.Key = key; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Key.Key Key { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual FlutterSDK.Widgets.Framework.Element CreateElement() { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public virtual bool CanUpdate(FlutterSDK.Widgets.Framework.Widget oldWidget, FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        private int _DebugConcreteSubtype(FlutterSDK.Widgets.Framework.Widget widget) { throw new NotImplementedException(); }

        #endregion
    }


    public class StatelessWidget : FlutterSDK.Widgets.Framework.Widget
    {
        #region constructors
        public StatelessWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.StatelessElement CreateElement() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class StatefulWidget : FlutterSDK.Widgets.Framework.Widget
    {
        #region constructors
        public StatefulWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.StatefulElement CreateElement() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class State<T> : IDiagnosticable
    {
        #region constructors
        public State()
        { }
        #endregion

        #region fields
        internal virtual T _Widget { get; set; }
        internal virtual FlutterSDK.Widgets.Framework._StateLifecycle _DebugLifecycleState { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.StatefulElement _Element { get; set; }
        public virtual T Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Mounted { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private bool _DebugTypesAreRight(FlutterSDK.Widgets.Framework.Widget widget) { throw new NotImplementedException(); }


        public virtual void InitState() { throw new NotImplementedException(); }


        public virtual void DidUpdateWidget(T oldWidget) { throw new NotImplementedException(); }


        public virtual void Reassemble() { throw new NotImplementedException(); }


        public virtual void SetState(VoidCallback fn) { throw new NotImplementedException(); }


        public virtual void Deactivate() { throw new NotImplementedException(); }


        public virtual void Dispose() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public virtual void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ProxyWidget : FlutterSDK.Widgets.Framework.Widget
    {
        #region constructors
        public ProxyWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class ParentDataWidget<T> : FlutterSDK.Widgets.Framework.ProxyWidget
    {
        #region constructors
        public ParentDataWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new ParentDataElement<T> CreateElement() { throw new NotImplementedException(); }


        public virtual bool DebugIsValidRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        private Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _DebugDescribeIncorrectParentDataType(FlutterSDK.Rendering.@object.ParentData parentData = default(FlutterSDK.Rendering.@object.ParentData), FlutterSDK.Widgets.Framework.RenderObjectWidget parentDataCreator = default(FlutterSDK.Widgets.Framework.RenderObjectWidget), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ownershipChain = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode)) { throw new NotImplementedException(); }


        public virtual void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public virtual bool DebugCanApplyOutOfTurn() { throw new NotImplementedException(); }

        #endregion
    }


    public class InheritedWidget : FlutterSDK.Widgets.Framework.ProxyWidget
    {
        #region constructors
        public InheritedWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.InheritedElement CreateElement() { throw new NotImplementedException(); }


        public virtual bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class RenderObjectWidget : FlutterSDK.Widgets.Framework.Widget
    {
        #region constructors
        public RenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public virtual void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public virtual void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class LeafRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public LeafRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.LeafRenderObjectElement CreateElement() { throw new NotImplementedException(); }

        #endregion
    }


    public class SingleChildRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public SingleChildRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement CreateElement() { throw new NotImplementedException(); }

        #endregion
    }


    public class MultiChildRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public MultiChildRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key)
        {
            this.Children = children; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement CreateElement() { throw new NotImplementedException(); }

        #endregion
    }


    public class BuildOwner
    {
        #region constructors
        public BuildOwner(VoidCallback onBuildScheduled = default(VoidCallback))
        {
            this.OnBuildScheduled = onBuildScheduled; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual VoidCallback OnBuildScheduled { get; set; }
        internal virtual FlutterSDK.Widgets.Framework._InactiveElements _InactiveElements { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Element> _DirtyElements { get; set; }
        internal virtual bool _ScheduledFlushDirtyElements { get; set; }
        internal virtual bool _DirtyElementsNeedsResorting { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusManager FocusManager { get; set; }
        internal virtual int _DebugStateLockLevel { get; set; }
        internal virtual bool _DebugBuilding { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _DebugCurrentBuildTarget { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.Element, HashSet<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>>> _DebugElementsThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans { get; set; }
        internal virtual bool _DebugIsInBuildScope { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DebugStateLocked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugBuilding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void ScheduleBuildFor(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        public virtual void LockState(Action callback) { throw new NotImplementedException(); }


        public virtual void BuildScope(FlutterSDK.Widgets.Framework.Element context, VoidCallback callback = default(VoidCallback)) { throw new NotImplementedException(); }


        private void _DebugTrackElementThatWillNeedToBeRebuiltDueToGlobalKeyShenanigans(FlutterSDK.Widgets.Framework.Element node, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key) { throw new NotImplementedException(); }


        private void _DebugElementWasRebuilt(FlutterSDK.Widgets.Framework.Element node) { throw new NotImplementedException(); }


        public virtual void FinalizeTree() { throw new NotImplementedException(); }


        public virtual void Reassemble(FlutterSDK.Widgets.Framework.Element root) { throw new NotImplementedException(); }

        #endregion
    }


    public class Element : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree, IBuildContext
    {
        #region constructors
        public Element(FlutterSDK.Widgets.Framework.Widget widget)
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Element _Parent { get; set; }
        internal virtual int _CachedHash { get; set; }
        internal virtual int _NextHashCode { get; set; }
        internal virtual object _Slot { get; set; }
        internal virtual int _Depth { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Widget { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.BuildOwner _Owner { get; set; }
        internal virtual bool _Active { get; set; }
        internal virtual FlutterSDK.Widgets.Framework._ElementLifecycle _DebugLifecycleState { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _DebugForgottenChildrenWithGlobalKey { get; set; }
        internal virtual Dictionary<Type, FlutterSDK.Widgets.Framework.InheritedElement> _InheritedWidgets { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.InheritedElement> _Dependencies { get; set; }
        internal virtual bool _HadUnsatisfiedDependencies { get; set; }
        internal virtual bool _Dirty { get; set; }
        internal virtual bool _InDirtyList { get; set; }
        internal virtual bool _DebugBuiltOnce { get; set; }
        internal virtual bool _DebugAllowIgnoredCallsToMarkNeedsBuild { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual object Slot { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int Depth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildOwner Owner { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Dirty { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        private int _Sort(FlutterSDK.Widgets.Framework.Element a, FlutterSDK.Widgets.Framework.Element b) { throw new NotImplementedException(); }


        private int _DebugConcreteSubtype(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        public virtual void Reassemble() { throw new NotImplementedException(); }


        private bool _DebugIsInScope(FlutterSDK.Widgets.Framework.Element target) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DescribeMissingAncestor(Type expectedAncestorType = default(Type)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElements(string name, Iterable<FlutterSDK.Widgets.Framework.Element> elements) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeElement(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeWidget(string name, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode DescribeOwnershipChain(string name) { throw new NotImplementedException(); }


        public virtual void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public virtual void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void VisitChildElements(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot) { throw new NotImplementedException(); }


        public virtual void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        private void _DebugRemoveGlobalKeyReservation(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public virtual void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        public virtual void UpdateSlotForChild(FlutterSDK.Widgets.Framework.Element child, object newSlot) { throw new NotImplementedException(); }


        private void _UpdateSlot(object newSlot) { throw new NotImplementedException(); }


        private void _UpdateDepth(int parentDepth) { throw new NotImplementedException(); }


        public virtual void DetachRenderObject() { throw new NotImplementedException(); }


        public virtual void AttachRenderObject(object newSlot) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Element _RetakeInactiveElement(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key, FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Element InflateWidget(FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot) { throw new NotImplementedException(); }


        private void _DebugCheckForCycles(FlutterSDK.Widgets.Framework.Element newChild) { throw new NotImplementedException(); }


        public virtual void DeactivateChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public virtual void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        private void _ActivateWithParent(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        private void _ActivateRecursively(FlutterSDK.Widgets.Framework.Element element) { throw new NotImplementedException(); }


        public virtual void Activate() { throw new NotImplementedException(); }


        public virtual void Deactivate() { throw new NotImplementedException(); }


        public virtual void DebugDeactivated() { throw new NotImplementedException(); }


        public virtual void Unmount() { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.@object.RenderObject FindRenderObject() { throw new NotImplementedException(); }


        private bool _DebugCheckStateIsActiveForAncestorLookup() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.InheritedElement ancestor, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedWidget InheritFromWidgetOfExactType(Type targetType, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public new T DependOnInheritedWidgetOfExactType<T>(@Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedElement AncestorInheritedElementForWidgetOfExactType(Type targetType) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedElement GetElementForInheritedWidgetOfExactType<T>() { throw new NotImplementedException(); }


        private void _UpdateInheritance() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget AncestorWidgetOfExactType(Type targetType) { throw new NotImplementedException(); }


        public new T FindAncestorWidgetOfExactType<T>() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> AncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) { throw new NotImplementedException(); }


        public new T FindAncestorStateOfType<T>() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> RootAncestorStateOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) { throw new NotImplementedException(); }


        public new T FindRootAncestorStateOfType<T>() { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.@object.RenderObject AncestorRenderObjectOfType(FlutterSDK.Widgets.Framework.TypeMatcher<object> matcher) { throw new NotImplementedException(); }


        public new T FindAncestorRenderObjectOfType<T>() { throw new NotImplementedException(); }


        public new void VisitAncestorElements(Func<bool, Element> visitor) { throw new NotImplementedException(); }


        public virtual void DidChangeDependencies() { throw new NotImplementedException(); }


        private bool _DebugCheckOwnerBuildTargetExists(string methodName) { throw new NotImplementedException(); }


        public virtual string DebugGetCreatorChain(int limit) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Widgets.Framework.Element> DebugGetDiagnosticChain() { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }


        private bool _DebugSetAllowIgnoredCallsToMarkNeedsBuild(bool value) { throw new NotImplementedException(); }


        public virtual void MarkNeedsBuild() { throw new NotImplementedException(); }


        public virtual void Rebuild() { throw new NotImplementedException(); }


        public virtual void PerformRebuild() { throw new NotImplementedException(); }

        #endregion
    }


    public class _ElementDiagnosticableTreeNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableTreeNode
    {
        #region constructors
        public _ElementDiagnosticableTreeNode(string name = default(string), FlutterSDK.Widgets.Framework.Element value = default(FlutterSDK.Widgets.Framework.Element), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool stateful = false)
        : base(name: name, value: value, style: style)
        {
            this.Stateful = stateful; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Stateful { get; set; }
        #endregion

        #region methods

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class ErrorWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public ErrorWidget(@Object exception)
        : base(key: new UniqueKey())
        {
            throw new NotImplementedException();
        }
        public static ErrorWidget WithDetails(string message = default(string), FlutterSDK.Foundation.Assertions.FlutterError error = default(FlutterSDK.Foundation.Assertions.FlutterError))
        {
            var instance = new ErrorWidget(key: new UniqueKey()); instance.Message = message; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.ErrorWidgetBuilder Builder { get; set; }
        public virtual string Message { get; set; }
        internal virtual FlutterSDK.Foundation.Assertions.FlutterError _FlutterError { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Framework.Widget _DefaultErrorWidgetBuilder(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details) { throw new NotImplementedException(); }


        private string _Stringify(@Object exception) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Box.RenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ComponentElement : FlutterSDK.Widgets.Framework.Element
    {
        #region constructors
        public ComponentElement(FlutterSDK.Widgets.Framework.Widget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Element _Child { get; set; }
        internal virtual bool _DebugDoingBuild { get; set; }
        public virtual bool DebugDoingBuild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        private void _FirstBuild() { throw new NotImplementedException(); }


        public new void PerformRebuild() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget Build() { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }

        #endregion
    }


    public class StatelessElement : FlutterSDK.Widgets.Framework.ComponentElement
    {
        #region constructors
        public StatelessElement(FlutterSDK.Widgets.Framework.StatelessWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.StatelessWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build() { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Framework.StatelessWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class StatefulElement : FlutterSDK.Widgets.Framework.ComponentElement
    {
        #region constructors
        public StatefulElement(FlutterSDK.Widgets.Framework.StatefulWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> _State { get; set; }
        internal virtual bool _DidChangeDependencies { get; set; }
        public virtual FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> State { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build() { throw new NotImplementedException(); }


        public new void Reassemble() { throw new NotImplementedException(); }


        protected new void _FirstBuild() { throw new NotImplementedException(); }


        public new void PerformRebuild() { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Framework.StatefulWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        public new void Activate() { throw new NotImplementedException(); }


        public new void Deactivate() { throw new NotImplementedException(); }


        public new void Unmount() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedWidget InheritFromElement(FlutterSDK.Widgets.Framework.Element ancestor, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.InheritedWidget DependOnInheritedElement(FlutterSDK.Widgets.Framework.Element ancestor, @Object aspect = default(@Object)) { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ProxyElement : FlutterSDK.Widgets.Framework.ComponentElement
    {
        #region constructors
        public ProxyElement(FlutterSDK.Widgets.Framework.ProxyWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.ProxyWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build() { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Framework.ProxyWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        public virtual void Updated(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget) { throw new NotImplementedException(); }


        public virtual void NotifyClients(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class ParentDataElement<T> : FlutterSDK.Widgets.Framework.ProxyElement
    {
        #region constructors
        public ParentDataElement(FlutterSDK.Widgets.Framework.ParentDataWidget<T> widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.ParentDataWidget<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _ApplyParentData(FlutterSDK.Widgets.Framework.ParentDataWidget<T> widget) { throw new NotImplementedException(); }


        public virtual void ApplyWidgetOutOfTurn(FlutterSDK.Widgets.Framework.ParentDataWidget<T> newWidget) { throw new NotImplementedException(); }


        public new void NotifyClients(FlutterSDK.Widgets.Framework.ParentDataWidget<T> oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class InheritedElement : FlutterSDK.Widgets.Framework.ProxyElement
    {
        #region constructors
        public InheritedElement(FlutterSDK.Widgets.Framework.InheritedWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Dictionary<FlutterSDK.Widgets.Framework.Element, @Object> _Dependents { get; set; }
        public virtual FlutterSDK.Widgets.Framework.InheritedWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        protected new void _UpdateInheritance() { throw new NotImplementedException(); }


        public new void DebugDeactivated() { throw new NotImplementedException(); }


        public virtual @Object GetDependencies(FlutterSDK.Widgets.Framework.Element dependent) { throw new NotImplementedException(); }


        public virtual void SetDependencies(FlutterSDK.Widgets.Framework.Element dependent, @Object value) { throw new NotImplementedException(); }


        public virtual void UpdateDependencies(FlutterSDK.Widgets.Framework.Element dependent, @Object aspect) { throw new NotImplementedException(); }


        public virtual void NotifyDependent(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget, FlutterSDK.Widgets.Framework.Element dependent) { throw new NotImplementedException(); }


        public new void Updated(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }
        public new void Updated(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget) { throw new NotImplementedException(); }


        public new void NotifyClients(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }
        public new void NotifyClients(FlutterSDK.Widgets.Framework.ProxyWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class RenderObjectElement : FlutterSDK.Widgets.Framework.Element
    {
        #region constructors
        public RenderObjectElement(FlutterSDK.Widgets.Framework.RenderObjectWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.@object.RenderObject _RenderObject { get; set; }
        internal virtual bool _DebugDoingBuild { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.RenderObjectElement _AncestorRenderObjectElement { get; set; }
        public virtual FlutterSDK.Widgets.Framework.RenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.@object.RenderObject RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugDoingBuild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Framework.RenderObjectElement _FindAncestorRenderObjectElement() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.ParentDataElement<FlutterSDK.Rendering.@object.ParentData> _FindAncestorParentDataElement() { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        private void _DebugUpdateRenderObjectOwner() { throw new NotImplementedException(); }


        public new void PerformRebuild() { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Widgets.Framework.Element> UpdateChildren(List<FlutterSDK.Widgets.Framework.Element> oldChildren, List<FlutterSDK.Widgets.Framework.Widget> newWidgets, HashSet<FlutterSDK.Widgets.Framework.Element> forgottenChildren = default(HashSet<FlutterSDK.Widgets.Framework.Element>)) { throw new NotImplementedException(); }


        public new void Deactivate() { throw new NotImplementedException(); }


        public new void Unmount() { throw new NotImplementedException(); }


        private void _UpdateParentData(FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.@object.ParentData> parentDataWidget) { throw new NotImplementedException(); }


        protected new void _UpdateSlot(object newSlot) { throw new NotImplementedException(); }


        public new void AttachRenderObject(object newSlot) { throw new NotImplementedException(); }


        public new void DetachRenderObject() { throw new NotImplementedException(); }


        public virtual void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public virtual void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public virtual void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class RootRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public RootRenderObjectElement(FlutterSDK.Widgets.Framework.RenderObjectWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual void AssignOwner(FlutterSDK.Widgets.Framework.BuildOwner owner) { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }

        #endregion
    }


    public class LeafRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public LeafRenderObjectElement(FlutterSDK.Widgets.Framework.LeafRenderObjectWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }

        #endregion
    }


    public class SingleChildRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public SingleChildRenderObjectElement(FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Element _Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }

        #endregion
    }


    public class MultiChildRenderObjectElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public MultiChildRenderObjectElement(FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<FlutterSDK.Widgets.Framework.Element> _Children { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _ForgottenChildren { get; set; }
        public virtual FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Framework.Element> Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Widgets.Framework.IndexedSlot<FlutterSDK.Widgets.Framework.Element> slot) { throw new NotImplementedException(); }
        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Widgets.Framework.IndexedSlot<FlutterSDK.Widgets.Framework.Element> slot) { throw new NotImplementedException(); }
        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class DebugCreator
    {
        #region constructors
        public DebugCreator(FlutterSDK.Widgets.Framework.Element element)
        {
            this.Element = element; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Element Element { get; set; }
        #endregion

        #region methods

        #endregion
    }


    public class IndexedSlot<T>
    {
        #region constructors
        public IndexedSlot(int index, T value)
        {
            this.Index = index;
            this.Value = value; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual T Value { get; set; }
        public virtual int Index { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public enum _StateLifecycle
    {

        Created,
        Initialized,
        Ready,
        Defunct,
    }


    public enum _ElementLifecycle
    {

        Initial,
        Active,
        Inactive,
        Defunct,
    }

}
