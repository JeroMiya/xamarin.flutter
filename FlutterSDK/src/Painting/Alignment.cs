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
namespace FlutterSDK.Painting.Alignment
{
    internal static class AlignmentDefaultClass
    {
    }

    /// <Summary>
    /// Base class for [Alignment] that allows for text-direction aware
    /// resolution.
    ///
    /// A property or argument of this type accepts classes created either with [new
    /// Alignment] and its variants, or [new AlignmentDirectional].
    ///
    /// To convert an [AlignmentGeometry] object of indeterminate type into an
    /// [Alignment] object, call the [resolve] method.
    /// </Summary>
    public interface IAlignmentGeometry
    {
        FlutterSDK.Painting.Alignment.AlignmentGeometry Add(FlutterSDK.Painting.Alignment.AlignmentGeometry other);
        FlutterSDK.Painting.Alignment.AlignmentGeometry Unary();
        FlutterSDK.Painting.Alignment.AlignmentGeometry MultiplyOperator(double other);
        FlutterSDK.Painting.Alignment.AlignmentGeometry DivideOperator(double other);
        FlutterSDK.Painting.Alignment.AlignmentGeometry DivideIntegerResultOperator(double other);
        FlutterSDK.Painting.Alignment.AlignmentGeometry ModuloOperator(double other);
        FlutterSDK.Painting.Alignment.AlignmentGeometry Lerp(FlutterSDK.Painting.Alignment.AlignmentGeometry a, FlutterSDK.Painting.Alignment.AlignmentGeometry b, double t);
        FlutterSDK.Painting.Alignment.Alignment Resolve(TextDirection direction);
        string ToString();
        bool Equals(@Object other);
        int HashCode { get; }
    }


    /// <Summary>
    /// Base class for [Alignment] that allows for text-direction aware
    /// resolution.
    ///
    /// A property or argument of this type accepts classes created either with [new
    /// Alignment] and its variants, or [new AlignmentDirectional].
    ///
    /// To convert an [AlignmentGeometry] object of indeterminate type into an
    /// [Alignment] object, call the [resolve] method.
    /// </Summary>
    public class AlignmentGeometry
    {
        #region constructors
        public AlignmentGeometry()
    
}
    #endregion

    #region fields
    internal virtual double _X { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _Y { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Returns the sum of two [AlignmentGeometry] objects.
    ///
    /// If you know you are adding two [Alignment] or two [AlignmentDirectional]
    /// objects, consider using the `+` operator instead, which always returns an
    /// object of the same type as the operands, and is typed accordingly.
    ///
    /// If [add] is applied to two objects of the same type ([Alignment] or
    /// [AlignmentDirectional]), an object of that type will be returned (though
    /// this is not reflected in the type system). Otherwise, an object
    /// representing a combination of both is returned. That object can be turned
    /// into a concrete [Alignment] using [resolve].
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Add(FlutterSDK.Painting.Alignment.AlignmentGeometry other)
    {
        return new _MixedAlignment(_X + other._X, _Start + other._Start, _Y + other._Y);
    }




    /// <Summary>
    /// Returns the negation of the given [AlignmentGeometry] object.
    ///
    /// This is the same as multiplying the object by -1.0.
    ///
    /// This operator returns an object of the same type as the operand.
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Unary()
    {
        return default(AlignmentGeometry);
    }


    /// <Summary>
    /// Scales the [AlignmentGeometry] object in each dimension by the given factor.
    ///
    /// This operator returns an object of the same type as the operand.
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry MultiplyOperator(double other)
    {
        return default(AlignmentGeometry);
    }


    /// <Summary>
    /// Divides the [AlignmentGeometry] object in each dimension by the given factor.
    ///
    /// This operator returns an object of the same type as the operand.
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry DivideOperator(double other)
    {
        return default(AlignmentGeometry);
    }


    /// <Summary>
    /// Integer divides the [AlignmentGeometry] object in each dimension by the given factor.
    ///
    /// This operator returns an object of the same type as the operand.
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry DivideIntegerResultOperator(double other)
    {
        return default(AlignmentGeometry);
    }


    /// <Summary>
    /// Computes the remainder in each dimension by the given factor.
    ///
    /// This operator returns an object of the same type as the operand.
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry ModuloOperator(double other)
    {
        return default(AlignmentGeometry);
    }


    /// <Summary>
    /// Linearly interpolate between two [AlignmentGeometry] objects.
    ///
    /// If either is null, this function interpolates from [Alignment.center], and
    /// the result is an object of the same type as the non-null argument.
    ///
    /// If [lerp] is applied to two objects of the same type ([Alignment] or
    /// [AlignmentDirectional]), an object of that type will be returned (though
    /// this is not reflected in the type system). Otherwise, an object
    /// representing a combination of both is returned. That object can be turned
    /// into a concrete [Alignment] using [resolve].
    ///
    /// {@macro dart.ui.shadow.lerp}
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Lerp(FlutterSDK.Painting.Alignment.AlignmentGeometry a, FlutterSDK.Painting.Alignment.AlignmentGeometry b, double t)
    {

        if (a == null && b == null) return null;
        if (a == null) return b * t;
        if (b == null) return a * (1.0 - t);
        if (a is Alignment && b is Alignment) return AlignmentDefaultClass.Alignment.Lerp(a, b, t);
        if (a is AlignmentDirectional && b is AlignmentDirectional) return AlignmentDefaultClass.AlignmentDirectional.Lerp(a, b, t);
        return new _MixedAlignment(Ui.Dart:uiDefaultClass.LerpDouble(a._X, b._X, t), Ui.Dart:uiDefaultClass.LerpDouble(a._Start, b._Start, t), Ui.Dart:uiDefaultClass.LerpDouble(a._Y, b._Y, t));
    }




    /// <Summary>
    /// Convert this instance into an [Alignment], which uses literal
    /// coordinates (the `x` coordinate being explicitly a distance from the
    /// left).
    ///
    /// See also:
    ///
    ///  * [Alignment], for which this is a no-op (returns itself).
    ///  * [AlignmentDirectional], which flips the horizontal direction
    ///    based on the `direction` argument.
    /// </Summary>
    public virtual FlutterSDK.Painting.Alignment.Alignment Resolve(TextDirection direction)
    {
        return default(Alignment);
    }



    public new bool Equals(@Object other)
    {
        return other is AlignmentGeometry && other._X == _X && other._Start == _Start && other._Y == _Y;
    }



    #endregion
}


/// <Summary>
/// A point within a rectangle.
///
/// `Alignment(0.0, 0.0)` represents the center of the rectangle. The distance
/// from -1.0 to +1.0 is the distance from one side of the rectangle to the
/// other side of the rectangle. Therefore, 2.0 units horizontally (or
/// vertically) is equivalent to the width (or height) of the rectangle.
///
/// `Alignment(-1.0, -1.0)` represents the top left of the rectangle.
///
/// `Alignment(1.0, 1.0)` represents the bottom right of the rectangle.
///
/// `Alignment(0.0, 3.0)` represents a point that is horizontally centered with
/// respect to the rectangle and vertically below the bottom of the rectangle by
/// the height of the rectangle.
///
/// `Alignment(0.0, -0.5)` represents a point that is horizontally centered with
/// respect to the rectangle and vertically half way between the top edge and
/// the center.
///
/// `Alignment(x, y)` in a rectangle with height h and width w describes
/// the point (x * w/2 + w/2, y * h/2 + h/2) in the coordinate system of the
/// rectangle.
///
/// [Alignment] uses visual coordinates, which means increasing [x] moves the
/// point from left to right. To support layouts with a right-to-left
/// [TextDirection], consider using [AlignmentDirectional], in which the
/// direction the point moves when increasing the horizontal value depends on
/// the [TextDirection].
///
/// A variety of widgets use [Alignment] in their configuration, most
/// notably:
///
///  * [Align] positions a child according to an [Alignment].
///
/// See also:
///
///  * [AlignmentDirectional], which has a horizontal coordinate orientation
///    that depends on the [TextDirection].
///  * [AlignmentGeometry], which is an abstract type that is agnostic as to
///    whether the horizontal direction depends on the [TextDirection].
/// </Summary>
public class Alignment : FlutterSDK.Painting.Alignment.AlignmentGeometry
{
    #region constructors
    public Alignment(double x, double y)
    : base()

}
#endregion

#region fields
public virtual double x { get; set; }
public virtual double y { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment TopLeft { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment TopCenter { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment TopRight { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment CenterLeft { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment Center { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment CenterRight { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment BottomLeft { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment BottomCenter { get; set; }
public virtual FlutterSDK.Painting.Alignment.Alignment BottomRight { get; set; }
internal virtual double _X { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _Y { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Painting.Alignment.AlignmentGeometry Add(FlutterSDK.Painting.Alignment.AlignmentGeometry other)
{
    if (other is Alignment) return this + other;
    return base.Add(other);
}




/// <Summary>
/// Returns the difference between two [Alignment]s.
/// </Summary>
public virtual FlutterSDK.Painting.Alignment.Alignment Unary(FlutterSDK.Painting.Alignment.Alignment other)
{
    return new Alignment(x - other.x, y - other.y);
}




/// <Summary>
/// Returns the sum of two [Alignment]s.
/// </Summary>
public virtual FlutterSDK.Painting.Alignment.Alignment AddOperator(FlutterSDK.Painting.Alignment.Alignment other)
{
    return new Alignment(x + other.x, y + other.y);
}




/// <Summary>
/// Returns the negation of the given [Alignment].
/// </Summary>
public new FlutterSDK.Painting.Alignment.Alignment Unary()
{
    return new Alignment(-x, -y);
}




/// <Summary>
/// Scales the [Alignment] in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.Alignment MultiplyOperator(double other)
{
    return new Alignment(x * other, y * other);
}




/// <Summary>
/// Divides the [Alignment] in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.Alignment DivideOperator(double other)
{
    return new Alignment(x / other, y / other);
}




/// <Summary>
/// Integer divides the [Alignment] in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.Alignment DivideIntegerResultOperator(double other)
{
    return new Alignment((x~/ other).ToDouble(), (y~/ other).ToDouble());
}




/// <Summary>
/// Computes the remainder in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.Alignment ModuloOperator(double other)
{
    return new Alignment(x % other, y % other);
}




/// <Summary>
/// Returns the offset that is this fraction in the direction of the given offset.
/// </Summary>
public virtual Offset AlongOffset(FlutterBinding.UI.Offset other)
{
    double centerX = other.Dx / 2.0;
    double centerY = other.Dy / 2.0;
    return new Offset(centerX + x * centerX, centerY + y * centerY);
}




/// <Summary>
/// Returns the offset that is this fraction within the given size.
/// </Summary>
public virtual Offset AlongSize(Size other)
{
    double centerX = other.Width / 2.0;
    double centerY = other.Height / 2.0;
    return new Offset(centerX + x * centerX, centerY + y * centerY);
}




/// <Summary>
/// Returns the point that is this fraction within the given rect.
/// </Summary>
public virtual Offset WithinRect(FlutterBinding.UI.Rect rect)
{
    double halfWidth = rect.Width / 2.0;
    double halfHeight = rect.Height / 2.0;
    return new Offset(rect.Left + halfWidth + x * halfWidth, rect.Top + halfHeight + y * halfHeight);
}




/// <Summary>
/// Returns a rect of the given size, aligned within given rect as specified
/// by this alignment.
///
/// For example, a 100×100 size inscribed on a 200×200 rect using
/// [Alignment.topLeft] would be the 100×100 rect at the top left of
/// the 200×200 rect.
/// </Summary>
public virtual Rect Inscribe(Size size, FlutterBinding.UI.Rect rect)
{
    double halfWidthDelta = (rect.Width - size.Width) / 2.0;
    double halfHeightDelta = (rect.Height - size.Height) / 2.0;
    return Rect.FromLTWH(rect.Left + halfWidthDelta + x * halfWidthDelta, rect.Top + halfHeightDelta + y * halfHeightDelta, size.Width, size.Height);
}




/// <Summary>
/// Linearly interpolate between two [Alignment]s.
///
/// If either is null, this function interpolates from [Alignment.center].
///
/// {@macro dart.ui.shadow.lerp}
/// </Summary>
public virtual FlutterSDK.Painting.Alignment.Alignment Lerp(FlutterSDK.Painting.Alignment.Alignment a, FlutterSDK.Painting.Alignment.Alignment b, double t)
{

    if (a == null && b == null) return null;
    if (a == null) return new Alignment(Ui.Dart:uiDefaultClass.LerpDouble(0.0, b.x, t), Ui.Dart:uiDefaultClass.LerpDouble(0.0, b.y, t));
    if (b == null) return new Alignment(Ui.Dart:uiDefaultClass.LerpDouble(a.x, 0.0, t), Ui.Dart:uiDefaultClass.LerpDouble(a.y, 0.0, t));
    return new Alignment(Ui.Dart:uiDefaultClass.LerpDouble(a.x, b.x, t), Ui.Dart:uiDefaultClass.LerpDouble(a.y, b.y, t));
}




public new FlutterSDK.Painting.Alignment.Alignment Resolve(TextDirection direction) => this;



private string _Stringify(double x, double y)
{
    if (x == -1.0 && y == -1.0) return "topLeft";
    if (x == 0.0 && y == -1.0) return "topCenter";
    if (x == 1.0 && y == -1.0) return "topRight";
    if (x == -1.0 && y == 0.0) return "centerLeft";
    if (x == 0.0 && y == 0.0) return "center";
    if (x == 1.0 && y == 0.0) return "centerRight";
    if (x == -1.0 && y == 1.0) return "bottomLeft";
    if (x == 0.0 && y == 1.0) return "bottomCenter";
    if (x == 1.0 && y == 1.0) return "bottomRight";
    return $"'Alignment({x.ToStringAsFixed(1)}, '" + $"'{y.ToStringAsFixed(1)})'";
}




#endregion
}


/// <Summary>
/// An offset that's expressed as a fraction of a [Size], but whose horizontal
/// component is dependent on the writing direction.
///
/// This can be used to indicate an offset from the left in [TextDirection.ltr]
/// text and an offset from the right in [TextDirection.rtl] text without having
/// to be aware of the current text direction.
///
/// See also:
///
///  * [Alignment], a variant that is defined in physical terms (i.e.
///    whose horizontal component does not depend on the text direction).
/// </Summary>
public class AlignmentDirectional : FlutterSDK.Painting.Alignment.AlignmentGeometry
{
    #region constructors
    public AlignmentDirectional(double start, double y)
    : base()

}
#endregion

#region fields
public virtual double Start { get; set; }
public virtual double y { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional TopStart { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional TopCenter { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional TopEnd { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional CenterStart { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional Center { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional CenterEnd { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional BottomStart { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional BottomCenter { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional BottomEnd { get; set; }
internal virtual double _X { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _Y { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Painting.Alignment.AlignmentGeometry Add(FlutterSDK.Painting.Alignment.AlignmentGeometry other)
{
    if (other is AlignmentDirectional) return this + other;
    return base.Add(other);
}




/// <Summary>
/// Returns the difference between two [AlignmentDirectional]s.
/// </Summary>
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional Unary(FlutterSDK.Painting.Alignment.AlignmentDirectional other)
{
    return new AlignmentDirectional(Start - other.Start, y - other.y);
}




/// <Summary>
/// Returns the sum of two [AlignmentDirectional]s.
/// </Summary>
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional AddOperator(FlutterSDK.Painting.Alignment.AlignmentDirectional other)
{
    return new AlignmentDirectional(Start + other.Start, y + other.y);
}




/// <Summary>
/// Returns the negation of the given [AlignmentDirectional].
/// </Summary>
public new FlutterSDK.Painting.Alignment.AlignmentDirectional Unary()
{
    return new AlignmentDirectional(-Start, -y);
}




/// <Summary>
/// Scales the [AlignmentDirectional] in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.AlignmentDirectional MultiplyOperator(double other)
{
    return new AlignmentDirectional(Start * other, y * other);
}




/// <Summary>
/// Divides the [AlignmentDirectional] in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.AlignmentDirectional DivideOperator(double other)
{
    return new AlignmentDirectional(Start / other, y / other);
}




/// <Summary>
/// Integer divides the [AlignmentDirectional] in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.AlignmentDirectional DivideIntegerResultOperator(double other)
{
    return new AlignmentDirectional((Start~/ other).ToDouble(), (y~/ other).ToDouble());
}




/// <Summary>
/// Computes the remainder in each dimension by the given factor.
/// </Summary>
public new FlutterSDK.Painting.Alignment.AlignmentDirectional ModuloOperator(double other)
{
    return new AlignmentDirectional(Start % other, y % other);
}




/// <Summary>
/// Linearly interpolate between two [AlignmentDirectional]s.
///
/// If either is null, this function interpolates from [AlignmentDirectional.center].
///
/// {@macro dart.ui.shadow.lerp}
/// </Summary>
public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional Lerp(FlutterSDK.Painting.Alignment.AlignmentDirectional a, FlutterSDK.Painting.Alignment.AlignmentDirectional b, double t)
{

    if (a == null && b == null) return null;
    if (a == null) return new AlignmentDirectional(Ui.Dart:uiDefaultClass.LerpDouble(0.0, b.Start, t), Ui.Dart:uiDefaultClass.LerpDouble(0.0, b.y, t));
    if (b == null) return new AlignmentDirectional(Ui.Dart:uiDefaultClass.LerpDouble(a.Start, 0.0, t), Ui.Dart:uiDefaultClass.LerpDouble(a.y, 0.0, t));
    return new AlignmentDirectional(Ui.Dart:uiDefaultClass.LerpDouble(a.Start, b.Start, t), Ui.Dart:uiDefaultClass.LerpDouble(a.y, b.y, t));
}




public new FlutterSDK.Painting.Alignment.Alignment Resolve(TextDirection direction)
{

    switch (direction) { case TextDirection.Rtl: return new Alignment(-Start, y); case TextDirection.Ltr: return new Alignment(Start, y); }
    return null;
}




private string _Stringify(double start, double y)
{
    if (start == -1.0 && y == -1.0) return "AlignmentDirectional.topStart";
    if (start == 0.0 && y == -1.0) return "AlignmentDirectional.topCenter";
    if (start == 1.0 && y == -1.0) return "AlignmentDirectional.topEnd";
    if (start == -1.0 && y == 0.0) return "AlignmentDirectional.centerStart";
    if (start == 0.0 && y == 0.0) return "AlignmentDirectional.center";
    if (start == 1.0 && y == 0.0) return "AlignmentDirectional.centerEnd";
    if (start == -1.0 && y == 1.0) return "AlignmentDirectional.bottomStart";
    if (start == 0.0 && y == 1.0) return "AlignmentDirectional.bottomCenter";
    if (start == 1.0 && y == 1.0) return "AlignmentDirectional.bottomEnd";
    return $"'AlignmentDirectional({start.ToStringAsFixed(1)}, '" + $"'{y.ToStringAsFixed(1)})'";
}




#endregion
}


public class _MixedAlignment : FlutterSDK.Painting.Alignment.AlignmentGeometry
{
    #region constructors
    public _MixedAlignment(double _x, double _start, double _y)

}
#endregion

#region fields
internal new double _X { get; set; }
internal new double _Start { get; set; }
internal new double _Y { get; set; }
#endregion

#region methods

public new FlutterSDK.Painting.Alignment._MixedAlignment Unary()
{
    return new _MixedAlignment(-_X, -_Start, -_Y);
}




public new FlutterSDK.Painting.Alignment._MixedAlignment MultiplyOperator(double other)
{
    return new _MixedAlignment(_X * other, _Start * other, _Y * other);
}




public new FlutterSDK.Painting.Alignment._MixedAlignment DivideOperator(double other)
{
    return new _MixedAlignment(_X / other, _Start / other, _Y / other);
}




public new FlutterSDK.Painting.Alignment._MixedAlignment DivideIntegerResultOperator(double other)
{
    return new _MixedAlignment((_X~/ other).ToDouble(), (_Start~/ other).ToDouble(), (_Y~/ other).ToDouble());
}




public new FlutterSDK.Painting.Alignment._MixedAlignment ModuloOperator(double other)
{
    return new _MixedAlignment(_X % other, _Start % other, _Y % other);
}




public new FlutterSDK.Painting.Alignment.Alignment Resolve(TextDirection direction)
{

    switch (direction) { case TextDirection.Rtl: return new Alignment(_X - _Start, _Y); case TextDirection.Ltr: return new Alignment(_X + _Start, _Y); }
    return null;
}



#endregion
}


/// <Summary>
/// The vertical alignment of text within an input box.
///
/// A single [y] value that can range from -1.0 to 1.0. -1.0 aligns to the top
/// of an input box so that the top of the first line of text fits within the
/// box and its padding. 0.0 aligns to the center of the box. 1.0 aligns so that
/// the bottom of the last line of text aligns with the bottom interior edge of
/// the input box.
///
/// See also:
///
///  * [TextField.textAlignVertical], which is passed on to the [InputDecorator].
///  * [CupertinoTextField.textAlignVertical], which behaves in the same way as
///    the parameter in TextField.
///  * [InputDecorator.textAlignVertical], which defines the alignment of
///    prefix, input, and suffix within an [InputDecorator].
/// </Summary>
public class TextAlignVertical
{
    #region constructors
    public TextAlignVertical(double y = default(double))
    : base()

}
#endregion

#region fields
public virtual double y { get; set; }
public virtual FlutterSDK.Painting.Alignment.TextAlignVertical Top { get; set; }
public virtual FlutterSDK.Painting.Alignment.TextAlignVertical Center { get; set; }
public virtual FlutterSDK.Painting.Alignment.TextAlignVertical Bottom { get; set; }
#endregion

#region methods

#endregion
}

}
