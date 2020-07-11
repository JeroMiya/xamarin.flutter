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
namespace FlutterSDK.Painting.Edgeinsets
{
    internal static class EdgeinsetsDefaultClass
    {
    }

    public interface IEdgeInsetsGeometry
    {
        double Along(FlutterSDK.Painting.Basictypes.Axis axis);
        Size InflateSize(Size size);
        Size DeflateSize(Size size);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Clamp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry min, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry max);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Unary();
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry MultiplyOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideIntegerResultOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ModuloOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry a, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry b, double t);
        FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction);
        string ToString();
        bool Equals(@Object other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Infinity { get; }
        bool IsNonNegative { get; }
        double Horizontal { get; }
        double Vertical { get; }
        Size CollapsedSize { get; }
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Flipped { get; }
        int HashCode { get; }
    }


    public class EdgeInsetsGeometry
    {
        #region constructors
        public EdgeInsetsGeometry()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Infinity { get; set; }
        internal virtual double _Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _End { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNonNegative { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Horizontal { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Vertical { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size CollapsedSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual double Along(FlutterSDK.Painting.Basictypes.Axis axis) { throw new NotImplementedException(); }


        public virtual Size InflateSize(Size size) { throw new NotImplementedException(); }


        public virtual Size DeflateSize(Size size) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Clamp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry min, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry max) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Unary() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry MultiplyOperator(double other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideOperator(double other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideIntegerResultOperator(double other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ModuloOperator(double other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry a, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry b, double t) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction) { throw new NotImplementedException(); }



        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class EdgeInsets : FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry
    {
        #region constructors
        public static EdgeInsets FromLTRB(double left, double top, double right, double bottom)
        {
            var instance = new EdgeInsets(); instance.Left = left;
            instance.Top = top;
            instance.Right = right;
            instance.Bottom = bottom; throw new NotImplementedException();
        }
        public static EdgeInsets All(double value)
        {
            var instance = new EdgeInsets(); throw new NotImplementedException();
        }
        public static EdgeInsets Only(double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0)
        {
            var instance = new EdgeInsets(); instance.Left = left;
            instance.Top = top;
            instance.Right = right;
            instance.Bottom = bottom; throw new NotImplementedException();
        }
        public static EdgeInsets Symmetric(double vertical = 0.0, double horizontal = 0.0)
        {
            var instance = new EdgeInsets(); throw new NotImplementedException();
        }
        public static EdgeInsets FromWindowPadding(WindowPadding padding, double devicePixelRatio)
        {
            var instance = new EdgeInsets(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Zero { get; set; }
        public virtual double Left { get; set; }
        public virtual double Top { get; set; }
        public virtual double Right { get; set; }
        public virtual double Bottom { get; set; }
        internal virtual double _Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _End { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset TopLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset TopRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset BottomLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset BottomRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual Rect InflateRect(FlutterBinding.UI.Rect rect) { throw new NotImplementedException(); }


        public virtual Rect DeflateRect(FlutterBinding.UI.Rect rect) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Clamp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry min, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry max) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Unary(FlutterSDK.Painting.Edgeinsets.EdgeInsets other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets AddOperator(FlutterSDK.Painting.Edgeinsets.EdgeInsets other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Unary() { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets MultiplyOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets DivideOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets DivideIntegerResultOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets ModuloOperator(double other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsets a, FlutterSDK.Painting.Edgeinsets.EdgeInsets b, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets CopyWith(double left = default(double), double top = default(double), double right = default(double), double bottom = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class EdgeInsetsDirectional : FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry
    {
        #region constructors
        public static EdgeInsetsDirectional FromSTEB(double start, double top, double end, double bottom)
        {
            var instance = new EdgeInsetsDirectional(); instance.Start = start;
            instance.Top = top;
            instance.End = end;
            instance.Bottom = bottom; throw new NotImplementedException();
        }
        public static EdgeInsetsDirectional Only(double start = 0.0, double top = 0.0, double end = 0.0, double bottom = 0.0)
        {
            var instance = new EdgeInsetsDirectional(); instance.Start = start;
            instance.Top = top;
            instance.End = end;
            instance.Bottom = bottom; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Zero { get; set; }
        public virtual double Start { get; set; }
        public virtual double Top { get; set; }
        public virtual double End { get; set; }
        public virtual double Bottom { get; set; }
        internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _End { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNonNegative { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Unary(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional AddOperator(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Unary() { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional MultiplyOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional DivideOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional DivideIntegerResultOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional ModuloOperator(double other) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional a, FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional b, double t) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction) { throw new NotImplementedException(); }

        #endregion
    }


    public class _MixedEdgeInsets : FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry
    {
        #region constructors
        public static _MixedEdgeInsets FromLRSETB(double _left, double _right, double _start, double _end, double _top, double _bottom)
        {
            var instance = new _MixedEdgeInsets(); instance._Left = _left;
            instance._Right = _right;
            instance._Start = _start;
            instance._End = _end;
            instance._Top = _top;
            instance._Bottom = _bottom; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal new double _Left { get; set; }
        internal new double _Right { get; set; }
        internal new double _Start { get; set; }
        internal new double _End { get; set; }
        internal new double _Top { get; set; }
        internal new double _Bottom { get; set; }
        public virtual bool IsNonNegative { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets Unary() { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets MultiplyOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets DivideOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets DivideIntegerResultOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets ModuloOperator(double other) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction) { throw new NotImplementedException(); }

        #endregion
    }

}
