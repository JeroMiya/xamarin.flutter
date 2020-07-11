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
namespace FlutterSDK.Widgets.Gesturedetector
{
    public delegate T GestureRecognizerFactoryConstructor<T>();
    public delegate void GestureRecognizerFactoryInitializer<T>(T instance);
    public delegate void _AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler p1);
    internal static class GesturedetectorDefaultClass
    {
    }

    public interface IGestureRecognizerFactory<T>
    {
        T Constructor();
        void Initializer(T instance);
    }


    public interface ISemanticsGestureDelegate
    {
        void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject);
        string ToString();
    }


    public class GestureRecognizerFactory<T>
    {
        #region constructors
        public GestureRecognizerFactory()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual T Constructor() { throw new NotImplementedException(); }


        public virtual void Initializer(T instance) { throw new NotImplementedException(); }


        private bool _DebugAssertTypeMatches(Type type) { throw new NotImplementedException(); }

        #endregion
    }


    public class GestureRecognizerFactoryWithHandlers<T> : FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<T>
    {
        #region constructors
        public GestureRecognizerFactoryWithHandlers(FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryConstructor<T> _constructor, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryInitializer<T> _initializer)
        : base()
        {
            this._Constructor = _constructor;
            this._Initializer = _initializer; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryConstructor<T> _Constructor { get; set; }
        internal virtual FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryInitializer<T> _Initializer { get; set; }
        #endregion

        #region methods

        public new T Constructor() { throw new NotImplementedException(); }


        public new void Initializer(T instance) { throw new NotImplementedException(); }

        #endregion
    }


    public class GestureDetector : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public GestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Tap.GestureTapUpCallback onTapUp = default(FlutterSDK.Gestures.Tap.GestureTapUpCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapCancelCallback onTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback), FlutterSDK.Gestures.Tap.GestureTapDownCallback onSecondaryTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Tap.GestureTapUpCallback onSecondaryTapUp = default(FlutterSDK.Gestures.Tap.GestureTapUpCallback), FlutterSDK.Gestures.Tap.GestureTapCancelCallback onSecondaryTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback onLongPressStart = default(FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback), FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback onLongPressMoveUpdate = default(FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback), FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback onLongPressUp = default(FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback), FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback onLongPressEnd = default(FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback), FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback onVerticalDragDown = default(FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onVerticalDragStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onVerticalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onVerticalDragEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback onVerticalDragCancel = default(FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback), FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback onHorizontalDragDown = default(FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onHorizontalDragStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onHorizontalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onHorizontalDragEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback onHorizontalDragCancel = default(FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback onForcePressStart = default(FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback onForcePressPeak = default(FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback onForcePressUpdate = default(FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback onForcePressEnd = default(FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback), FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback onPanDown = default(FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onPanStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onPanUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onPanEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback onPanCancel = default(FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback), FlutterSDK.Gestures.Scale.GestureScaleStartCallback onScaleStart = default(FlutterSDK.Gestures.Scale.GestureScaleStartCallback), FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback onScaleUpdate = default(FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback), FlutterSDK.Gestures.Scale.GestureScaleEndCallback onScaleEnd = default(FlutterSDK.Gestures.Scale.GestureScaleEndCallback), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), bool excludeFromSemantics = false, FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Child = child;
            this.OnTapDown = onTapDown;
            this.OnTapUp = onTapUp;
            this.OnTap = onTap;
            this.OnTapCancel = onTapCancel;
            this.OnSecondaryTapDown = onSecondaryTapDown;
            this.OnSecondaryTapUp = onSecondaryTapUp;
            this.OnSecondaryTapCancel = onSecondaryTapCancel;
            this.OnDoubleTap = onDoubleTap;
            this.OnLongPress = onLongPress;
            this.OnLongPressStart = onLongPressStart;
            this.OnLongPressMoveUpdate = onLongPressMoveUpdate;
            this.OnLongPressUp = onLongPressUp;
            this.OnLongPressEnd = onLongPressEnd;
            this.OnVerticalDragDown = onVerticalDragDown;
            this.OnVerticalDragStart = onVerticalDragStart;
            this.OnVerticalDragUpdate = onVerticalDragUpdate;
            this.OnVerticalDragEnd = onVerticalDragEnd;
            this.OnVerticalDragCancel = onVerticalDragCancel;
            this.OnHorizontalDragDown = onHorizontalDragDown;
            this.OnHorizontalDragStart = onHorizontalDragStart;
            this.OnHorizontalDragUpdate = onHorizontalDragUpdate;
            this.OnHorizontalDragEnd = onHorizontalDragEnd;
            this.OnHorizontalDragCancel = onHorizontalDragCancel;
            this.OnForcePressStart = onForcePressStart;
            this.OnForcePressPeak = onForcePressPeak;
            this.OnForcePressUpdate = onForcePressUpdate;
            this.OnForcePressEnd = onForcePressEnd;
            this.OnPanDown = onPanDown;
            this.OnPanStart = onPanStart;
            this.OnPanUpdate = onPanUpdate;
            this.OnPanEnd = onPanEnd;
            this.OnPanCancel = onPanCancel;
            this.OnScaleStart = onScaleStart;
            this.OnScaleUpdate = onScaleUpdate;
            this.OnScaleEnd = onScaleEnd;
            this.Behavior = behavior;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.DragStartBehavior = dragStartBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnTapDown { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnTapUp { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnTapCancel { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnSecondaryTapDown { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnSecondaryTapUp { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnSecondaryTapCancel { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnDoubleTap { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback OnLongPressStart { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback OnLongPressMoveUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback OnLongPressUp { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback OnLongPressEnd { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnVerticalDragDown { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnVerticalDragStart { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnVerticalDragUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnVerticalDragEnd { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnVerticalDragCancel { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnHorizontalDragDown { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnHorizontalDragStart { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnHorizontalDragUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnHorizontalDragEnd { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnHorizontalDragCancel { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnPanDown { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnPanStart { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnPanUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnPanEnd { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnPanCancel { get; set; }
        public virtual FlutterSDK.Gestures.Scale.GestureScaleStartCallback OnScaleStart { get; set; }
        public virtual FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback OnScaleUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Scale.GestureScaleEndCallback OnScaleEnd { get; set; }
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback OnForcePressStart { get; set; }
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback OnForcePressPeak { get; set; }
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback OnForcePressUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback OnForcePressEnd { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        public virtual bool ExcludeFromSemantics { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class RawGestureDetector : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public RawGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> gestures = default(Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>>), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), bool excludeFromSemantics = false, FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate semantics = default(FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate))
        : base(key: key)
        {
            this.Child = child;
            this.Gestures = gestures;
            this.Behavior = behavior;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.Semantics = semantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> Gestures { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        public virtual bool ExcludeFromSemantics { get; set; }
        public virtual FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate Semantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class RawGestureDetectorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Gesturedetector.RawGestureDetector>
    {
        #region constructors
        public RawGestureDetectorState()
        { }
        #endregion

        #region fields
        internal virtual Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> _Recognizers { get; set; }
        internal virtual FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate _Semantics { get; set; }
        internal virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior _DefaultBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Gesturedetector.RawGestureDetector oldWidget) { throw new NotImplementedException(); }


        public virtual void ReplaceGestureRecognizers(Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> gestures) { throw new NotImplementedException(); }


        public virtual void ReplaceSemanticsActions(HashSet<SemanticsAction> actions) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _SyncAll(Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> gestures) { throw new NotImplementedException(); }


        private void _HandlePointerDown(FlutterSDK.Gestures.Events.PointerDownEvent @event) { throw new NotImplementedException(); }


        private void _UpdateSemanticsForRenderObject(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _GestureSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _GestureSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Gesturedetector._AssignSemantics assignSemantics = default(FlutterSDK.Widgets.Gesturedetector._AssignSemantics))
        : base(key: key, child: child)
        {
            this.AssignSemantics = assignSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Gesturedetector._AssignSemantics AssignSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class SemanticsGestureDelegate
    {
        #region constructors
        public SemanticsGestureDelegate()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject) { throw new NotImplementedException(); }


        #endregion
    }


    public class _DefaultSemanticsGestureDelegate : FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate
    {
        #region constructors
        public _DefaultSemanticsGestureDelegate(FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState detectorState)
        {
            this.DetectorState = detectorState; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState DetectorState { get; set; }
        #endregion

        #region methods

        public new void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject) { throw new NotImplementedException(); }


        private FlutterSDK.Gestures.Tap.GestureTapCallback _GetTapHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers) { throw new NotImplementedException(); }


        private FlutterSDK.Gestures.Longpress.GestureLongPressCallback _GetLongPressHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers) { throw new NotImplementedException(); }


        private FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _GetHorizontalDragUpdateHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers) { throw new NotImplementedException(); }


        private FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _GetVerticalDragUpdateHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers) { throw new NotImplementedException(); }

        #endregion
    }

}
