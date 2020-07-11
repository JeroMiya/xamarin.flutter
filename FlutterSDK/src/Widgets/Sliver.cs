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
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Sliver
{
    public delegate int SemanticIndexCallback(FlutterSDK.Widgets.Framework.Widget widget, int localIndex);
    public delegate int ChildIndexGetter(FlutterSDK.Foundation.Key.Key key);
    internal static class SliverDefaultClass
    {
        internal static int _KDefaultSemanticIndexCallback(FlutterSDK.Widgets.Framework.Widget _, int localIndex)
        {
            throw new NotImplementedException();
        }

        internal static FlutterSDK.Widgets.Framework.Widget _CreateErrorWidget(object exception, StackTrace stackTrace)
        {
            throw new NotImplementedException();
        }

    }

    public interface ISliverChildDelegate
    {
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index);
        double EstimateMaxScrollOffset(int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset);
        void DidFinishLayout(int firstIndex, int lastIndex);
        bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate);
        int FindIndexByKey(FlutterSDK.Foundation.Key.Key key);
        string ToString();
        void DebugFillDescription(List<string> description);
        int EstimatedChildCount { get; }
    }


    public interface ISliverWithKeepAliveWidget
    {
        FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverWithKeepAliveMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
    }


    public interface ISliverMultiBoxAdaptorWidget
    {
        FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorElement CreateElement();
        FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
        double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate { get; }
    }


    public class SliverChildDelegate
    {
        #region constructors
        public SliverChildDelegate()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index) { throw new NotImplementedException(); }


        public virtual double EstimateMaxScrollOffset(int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset) { throw new NotImplementedException(); }


        public virtual void DidFinishLayout(int firstIndex, int lastIndex) { throw new NotImplementedException(); }


        public virtual bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate) { throw new NotImplementedException(); }


        public virtual int FindIndexByKey(FlutterSDK.Foundation.Key.Key key) { throw new NotImplementedException(); }



        public virtual void DebugFillDescription(List<string> description) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SaltedValueKey : FlutterSDK.Foundation.Key.ValueKey<FlutterSDK.Foundation.Key.Key>
    {
        #region constructors
        public _SaltedValueKey(FlutterSDK.Foundation.Key.Key key)
        : base(key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class SliverChildBuilderDelegate : FlutterSDK.Widgets.Sliver.SliverChildDelegate
    {
        #region constructors
        public SliverChildBuilderDelegate(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder builder, FlutterSDK.Widgets.Sliver.ChildIndexGetter findChildIndexCallback = default(FlutterSDK.Widgets.Sliver.ChildIndexGetter), int childCount = default(int), bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, FlutterSDK.Widgets.Sliver.SemanticIndexCallback semanticIndexCallback = default(FlutterSDK.Widgets.Sliver.SemanticIndexCallback), int semanticIndexOffset = 0)
        : base()
        {
            this.Builder = builder;
            this.FindChildIndexCallback = findChildIndexCallback;
            this.ChildCount = childCount;
            this.AddAutomaticKeepAlives = addAutomaticKeepAlives;
            this.AddRepaintBoundaries = addRepaintBoundaries;
            this.AddSemanticIndexes = addSemanticIndexes;
            this.SemanticIndexCallback = semanticIndexCallback;
            this.SemanticIndexOffset = semanticIndexOffset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder Builder { get; set; }
        public virtual int ChildCount { get; set; }
        public virtual bool AddAutomaticKeepAlives { get; set; }
        public virtual bool AddRepaintBoundaries { get; set; }
        public virtual bool AddSemanticIndexes { get; set; }
        public virtual int SemanticIndexOffset { get; set; }
        public virtual FlutterSDK.Widgets.Sliver.SemanticIndexCallback SemanticIndexCallback { get; set; }
        public virtual FlutterSDK.Widgets.Sliver.ChildIndexGetter FindChildIndexCallback { get; set; }
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new int FindIndexByKey(FlutterSDK.Foundation.Key.Key key) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index) { throw new NotImplementedException(); }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildBuilderDelegate oldDelegate) { throw new NotImplementedException(); }
        public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverChildListDelegate : FlutterSDK.Widgets.Sliver.SliverChildDelegate
    {
        #region constructors
        public SliverChildListDelegate(List<FlutterSDK.Widgets.Framework.Widget> children, bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, FlutterSDK.Widgets.Sliver.SemanticIndexCallback semanticIndexCallback = default(FlutterSDK.Widgets.Sliver.SemanticIndexCallback), int semanticIndexOffset = 0)
        : base()
        {
            this.Children = children;
            this.AddAutomaticKeepAlives = addAutomaticKeepAlives;
            this.AddRepaintBoundaries = addRepaintBoundaries;
            this.AddSemanticIndexes = addSemanticIndexes;
            this.SemanticIndexCallback = semanticIndexCallback;
            this.SemanticIndexOffset = semanticIndexOffset; throw new NotImplementedException();
        }
        public static SliverChildListDelegate Fixed(List<FlutterSDK.Widgets.Framework.Widget> children, bool addAutomaticKeepAlives = true, bool addRepaintBoundaries = true, bool addSemanticIndexes = true, FlutterSDK.Widgets.Sliver.SemanticIndexCallback semanticIndexCallback = default(FlutterSDK.Widgets.Sliver.SemanticIndexCallback), int semanticIndexOffset = 0)
        {
            var instance = new SliverChildListDelegate(); instance.Children = children;
            instance.AddAutomaticKeepAlives = addAutomaticKeepAlives;
            instance.AddRepaintBoundaries = addRepaintBoundaries;
            instance.AddSemanticIndexes = addSemanticIndexes;
            instance.SemanticIndexCallback = semanticIndexCallback;
            instance.SemanticIndexOffset = semanticIndexOffset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool AddAutomaticKeepAlives { get; set; }
        public virtual bool AddRepaintBoundaries { get; set; }
        public virtual bool AddSemanticIndexes { get; set; }
        public virtual int SemanticIndexOffset { get; set; }
        public virtual FlutterSDK.Widgets.Sliver.SemanticIndexCallback SemanticIndexCallback { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        internal virtual Dictionary<FlutterSDK.Foundation.Key.Key, int> _KeyToIndex { get; set; }
        internal virtual bool _IsConstantInstance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private int _FindChildIndex(FlutterSDK.Foundation.Key.Key key) { throw new NotImplementedException(); }


        public new int FindIndexByKey(FlutterSDK.Foundation.Key.Key key) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index) { throw new NotImplementedException(); }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildListDelegate oldDelegate) { throw new NotImplementedException(); }
        public new bool ShouldRebuild(FlutterSDK.Widgets.Sliver.SliverChildDelegate oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverWithKeepAliveWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public SliverWithKeepAliveWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverWithKeepAliveMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverMultiBoxAdaptorWidget : FlutterSDK.Widgets.Sliver.SliverWithKeepAliveWidget
    {
        #region constructors
        public SliverMultiBoxAdaptorWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate))
        : base(key: key)
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorElement CreateElement() { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public virtual double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverList : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
    {
        #region constructors
        public SliverList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate))
        : base(key: key, @delegate: @delegate)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Sliverlist.RenderSliverList CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverFixedExtentList : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
    {
        #region constructors
        public SliverFixedExtentList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), double itemExtent = default(double))
        : base(key: key, @delegate: @delegate)
        {
            this.ItemExtent = itemExtent; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double ItemExtent { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Sliverfixedextentlist.RenderSliverFixedExtentList CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Sliverfixedextentlist.RenderSliverFixedExtentList renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverGrid : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
    {
        #region constructors
        public SliverGrid(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate))
        : base(key: key, @delegate: @delegate)
        {
            this.GridDelegate = gridDelegate; throw new NotImplementedException();
        }
        public static SliverGrid Count(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int crossAxisCount = default(int), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        {
            var instance = new SliverGrid(key: key, @delegate: new SliverChildListDelegate(children)); throw new NotImplementedException();
        }
        public static SliverGrid Extent(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double maxCrossAxisExtent = default(double), double mainAxisSpacing = 0.0, double crossAxisSpacing = 0.0, double childAspectRatio = 1.0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        {
            var instance = new SliverGrid(key: key, @delegate: new SliverChildListDelegate(children)); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Slivergrid.SliverGridDelegate GridDelegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Slivergrid.RenderSliverGrid CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Slivergrid.RenderSliverGrid renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverMultiBoxAdaptorElement : FlutterSDK.Widgets.Framework.RenderObjectElement, IRenderSliverBoxChildManager
    {
        #region constructors
        public SliverMultiBoxAdaptorElement(FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Dictionary<int, FlutterSDK.Widgets.Framework.Widget> _ChildWidgets { get; set; }
        internal virtual SplayTreeMap<int, FlutterSDK.Widgets.Framework.Element> _ChildElements { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _CurrentBeforeChild { get; set; }
        internal virtual int _CurrentlyUpdatingChildIndex { get; set; }
        internal virtual bool _DidUnderflow { get; set; }
        public virtual FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Slivermultiboxadaptor.RenderSliverMultiBoxAdaptor RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Update(FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        public new void PerformRebuild() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _Build(int index) { throw new NotImplementedException(); }


        public new void CreateChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        public new void RemoveChild(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        private double _ExtrapolateMaxScrollOffset(int firstIndex, int lastIndex, double leadingScrollOffset, double trailingScrollOffset, int childCount) { throw new NotImplementedException(); }


        public new double EstimateMaxScrollOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints, int firstIndex = default(int), int lastIndex = default(int), double leadingScrollOffset = default(double), double trailingScrollOffset = default(double)) { throw new NotImplementedException(); }


        public new void DidStartLayout() { throw new NotImplementedException(); }


        public new void DidFinishLayout() { throw new NotImplementedException(); }


        public new bool DebugAssertChildListLocked() { throw new NotImplementedException(); }


        public new void DidAdoptChild(FlutterSDK.Rendering.Box.RenderBox child) { throw new NotImplementedException(); }


        public new void SetDidUnderflow(bool value) { throw new NotImplementedException(); }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, int slot) { throw new NotImplementedException(); }
        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, int slot) { throw new NotImplementedException(); }
        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverOpacity : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverOpacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double opacity = default(double), bool alwaysIncludeSemantics = false, FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: sliver)
        {
            this.Opacity = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Opacity { get; set; }
        public virtual bool AlwaysIncludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxysliver.RenderSliverOpacity CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverOpacity renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverIgnorePointer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverIgnorePointer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool ignoring = true, bool ignoringSemantics = default(bool), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: sliver)
        {
            this.Ignoring = ignoring;
            this.IgnoringSemantics = ignoringSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Ignoring { get; set; }
        public virtual bool IgnoringSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxysliver.RenderSliverIgnorePointer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverIgnorePointer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverOffstage : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverOffstage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool offstage = true, FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: sliver)
        {
            this.Offstage = offstage; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Offstage { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxysliver.RenderSliverOffstage CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxysliver.RenderSliverOffstage renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Sliver._SliverOffstageElement CreateElement() { throw new NotImplementedException(); }

        #endregion
    }


    public class _SliverOffstageElement : FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement
    {
        #region constructors
        public _SliverOffstageElement(FlutterSDK.Widgets.Sliver.SliverOffstage widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Sliver.SliverOffstage Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }

        #endregion
    }


    public class KeepAlive : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Slivermultiboxadaptor.KeepAliveParentDataMixin>
    {
        #region constructors
        public KeepAlive(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool keepAlive = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.KeepAliveValue = keepAlive; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool KeepAliveValue { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new bool DebugCanApplyOutOfTurn() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }

}
