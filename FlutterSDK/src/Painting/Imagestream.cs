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
namespace FlutterSDK.Painting.Imagestream
{
    public delegate void ImageListener(FlutterSDK.Painting.Imagestream.ImageInfo image, bool synchronousCall);
    public delegate void ImageChunkListener(FlutterSDK.Painting.Imagestream.ImageChunkEvent @event);
    public delegate void ImageErrorListener(object exception, StackTrace stackTrace);
    internal static class ImagestreamDefaultClass
    {
    }

    /// <Summary>
    /// Base class for those that manage the loading of [dart:ui.Image] objects for
    /// [ImageStream]s.
    ///
    /// [ImageStreamListener] objects are rarely constructed directly. Generally, an
    /// [ImageProvider] subclass will return an [ImageStream] and automatically
    /// configure it with the right [ImageStreamCompleter] when possible.
    /// </Summary>
    public interface IImageStreamCompleter
    {
        void AddListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener);
        void RemoveListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener);
        void AddOnLastListenerRemovedCallback(VoidCallback callback);
        void RemoveOnLastListenerRemovedCallback(VoidCallback callback);
        void SetImage(FlutterSDK.Painting.Imagestream.ImageInfo image);
        void ReportError(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), object exception = default(object), StackTrace stack = default(StackTrace), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description);
        bool HasListeners { get; }
    }


    /// <Summary>
    /// A [dart:ui.Image] object with its corresponding scale.
    ///
    /// ImageInfo objects are used by [ImageStream] objects to represent the
    /// actual data of the image once it has been obtained.
    /// </Summary>
    public class ImageInfo
    {
        #region constructors
        public ImageInfo(SKImage image = default(SKImage), double scale = 1.0)
        : base()
    
}
    #endregion

    #region fields
    public virtual SKImage Image { get; set; }
    public virtual double Scale { get; set; }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods


    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is ImageInfo && other.Image == Image && other.Scale == Scale;
    }



    #endregion
}


/// <Summary>
/// Interface for receiving notifications about the loading of an image.
///
/// This class overrides [operator ==] and [hashCode] to compare the individual
/// callbacks in the listener, meaning that if you add an instance of this class
/// as a listener (e.g. via [ImageStream.addListener]), you can instantiate a
/// _different_ instance of this class when you remove the listener, and the
/// listener will be properly removed as long as all associated callbacks are
/// equal.
///
/// Used by [ImageStream] and [ImageStreamCompleter].
/// </Summary>
public class ImageStreamListener
{
    #region constructors
    public ImageStreamListener(FlutterSDK.Painting.Imagestream.ImageListener onImage, FlutterSDK.Painting.Imagestream.ImageChunkListener onChunk = default(FlutterSDK.Painting.Imagestream.ImageChunkListener), FlutterSDK.Painting.Imagestream.ImageErrorListener onError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Imagestream.ImageListener OnImage { get; set; }
public virtual FlutterSDK.Painting.Imagestream.ImageChunkListener OnChunk { get; set; }
public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnError { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is ImageStreamListener && other.OnImage == OnImage && other.OnChunk == OnChunk && other.OnError == OnError;
}



#endregion
}


/// <Summary>
/// An immutable notification of image bytes that have been incrementally loaded.
///
/// Chunk events represent progress notifications while an image is being
/// loaded (e.g. from disk or over the network).
///
/// See also:
///
///  * [ImageChunkListener], the means by which callers get notified of
///    these events.
/// </Summary>
public class ImageChunkEvent : IDiagnosticable
{
    #region constructors
    public ImageChunkEvent(int cumulativeBytesLoaded = default(int), int expectedTotalBytes = default(int))
    : base()

}
#endregion

#region fields
public virtual int CumulativeBytesLoaded { get; set; }
public virtual int ExpectedTotalBytes { get; set; }
#endregion

#region methods

public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new IntProperty("cumulativeBytesLoaded", CumulativeBytesLoaded));
    properties.Add(new IntProperty("expectedTotalBytes", ExpectedTotalBytes));
}



#endregion
}


/// <Summary>
/// A handle to an image resource.
///
/// ImageStream represents a handle to a [dart:ui.Image] object and its scale
/// (together represented by an [ImageInfo] object). The underlying image object
/// might change over time, either because the image is animating or because the
/// underlying image resource was mutated.
///
/// ImageStream objects can also represent an image that hasn't finished
/// loading.
///
/// ImageStream objects are backed by [ImageStreamCompleter] objects.
///
/// The [ImageCache] will consider an image to be live until the listener count
/// drops to zero after adding at least one listener. The
/// [addOnLastListenerRemovedCallback] method is used for tracking this
/// information.
///
/// See also:
///
///  * [ImageProvider], which has an example that includes the use of an
///    [ImageStream] in a [Widget].
/// </Summary>
public class ImageStream : IDiagnosticable
{
    #region constructors
    public ImageStream()

}
#endregion

#region fields
internal virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter _Completer { get; set; }
internal virtual List<FlutterSDK.Painting.Imagestream.ImageStreamListener> _Listeners { get; set; }
public virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter Completer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual @Object Key { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Assigns a particular [ImageStreamCompleter] to this [ImageStream].
///
/// This is usually done automatically by the [ImageProvider] that created the
/// [ImageStream].
///
/// This method can only be called once per stream. To have an [ImageStream]
/// represent multiple images over time, assign it a completer that
/// completes several images in succession.
/// </Summary>
public virtual void SetCompleter(FlutterSDK.Painting.Imagestream.ImageStreamCompleter value)
{

    _Completer = value;
    if (_Listeners != null)
    {
        List<ImageStreamListener> initialListeners = _Listeners;
        _Listeners = null;
        initialListeners.ForEach(_Completer.AddListener);
    }

}




/// <Summary>
/// Adds a listener callback that is called whenever a new concrete [ImageInfo]
/// object is available. If a concrete image is already available, this object
/// will call the listener synchronously.
///
/// If the assigned [completer] completes multiple images over its lifetime,
/// this listener will fire multiple times.
///
/// {@template flutter.painting.imageStream.addListener}
/// The listener will be passed a flag indicating whether a synchronous call
/// occurred. If the listener is added within a render object paint function,
/// then use this flag to avoid calling [RenderObject.markNeedsPaint] during
/// a paint.
///
/// If a duplicate `listener` is registered N times, then it will be called N
/// times when the image stream completes (whether because a new image is
/// available or because an error occurs). Likewise, to remove all instances
/// of the listener, [removeListener] would need to called N times as well.
/// {@endtemplate}
/// </Summary>
public virtual void AddListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
{
    if (_Completer != null) return _Completer.AddListener(listener);
    _Listeners = (_Listeners == null ? new List<ImageStreamListener>() { } : _Listeners);
    _Listeners.Add(listener);
}




/// <Summary>
/// Stops listening for events from this stream's [ImageStreamCompleter].
///
/// If [listener] has been added multiple times, this removes the _first_
/// instance of the listener.
/// </Summary>
public virtual void RemoveListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
{
    if (_Completer != null) return _Completer.RemoveListener(listener);

    for (int i = 0; i < _Listeners.Count; i += 1)
    {
        if (_Listeners[i] == listener)
        {
            _Listeners.RemoveAt(i);
            break;
        }

    }

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new ObjectFlagProperty<ImageStreamCompleter>("completer", _Completer, ifPresent: _Completer?.ToStringShort(), ifNull: "unresolved"));
    properties.Add(new ObjectFlagProperty<List<ImageStreamListener>>("listeners", _Listeners, ifPresent: $"'{_Listeners?.Count} listener{_Listeners?.Count == 1 ? "":'s'}'", ifNull: "no listeners", level: _Completer != null ? DiagnosticLevel.Hidden : DiagnosticLevel.Info));
    _Completer?.DebugFillProperties(properties);
}



#endregion
}


/// <Summary>
/// Base class for those that manage the loading of [dart:ui.Image] objects for
/// [ImageStream]s.
///
/// [ImageStreamListener] objects are rarely constructed directly. Generally, an
/// [ImageProvider] subclass will return an [ImageStream] and automatically
/// configure it with the right [ImageStreamCompleter] when possible.
/// </Summary>
public class ImageStreamCompleter : IDiagnosticable
{
    #region constructors
    public ImageStreamCompleter()
    { }
    #endregion

    #region fields
    internal virtual List<FlutterSDK.Painting.Imagestream.ImageStreamListener> _Listeners { get; set; }
    internal virtual FlutterSDK.Painting.Imagestream.ImageInfo _CurrentImage { get; set; }
    internal virtual FlutterSDK.Foundation.Assertions.FlutterErrorDetails _CurrentError { get; set; }
    internal virtual List<object> _OnLastListenerRemovedCallbacks { get; set; }
    public virtual bool HasListeners { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Adds a listener callback that is called whenever a new concrete [ImageInfo]
    /// object is available or an error is reported. If a concrete image is
    /// already available, or if an error has been already reported, this object
    /// will notify the listener synchronously.
    ///
    /// If the [ImageStreamCompleter] completes multiple images over its lifetime,
    /// this listener's [ImageStreamListener.onImage] will fire multiple times.
    ///
    /// {@macro flutter.painting.imageStream.addListener}
    /// </Summary>
    public virtual void AddListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
    {
        _Listeners.Add(listener);
        if (_CurrentImage != null)
        {
            try
            {
                listener.OnImage(_CurrentImage, true);
            }
            catch (exception,stack){
                ReportError(context: new ErrorDescription("by a synchronously-called image listener"), exception: exception, stack: stack);
            }

            }

            if (_CurrentError != null && listener.OnError != null)
            {
                try
                {
                    listener.OnError(_CurrentError.Exception, _CurrentError.Stack);
                }
                catch (exception,stack){
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, library: "image resource service", context: new ErrorDescription("by a synchronously-called image error listener"), stack: stack));
                }

                }

            }




/// <Summary>
/// Stops the specified [listener] from receiving image stream events.
///
/// If [listener] has been added multiple times, this removes the _first_
/// instance of the listener.
/// </Summary>
    public virtual void RemoveListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
    {
        for (int i = 0; i < _Listeners.Count; i += 1)
        {
            if (_Listeners[i] == listener)
            {
                _Listeners.RemoveAt(i);
                break;
            }

        }

        if (_Listeners.IsEmpty())
        {
            foreach (VoidCallback callback in _OnLastListenerRemovedCallbacks)
            {
                callback();
            }

            _OnLastListenerRemovedCallbacks.Clear();
        }

    }




    /// <Summary>
    /// Adds a callback to call when [removeListener] results in an empty
    /// list of listeners.
    ///
    /// This callback will never fire if [removeListener] is never called.
    /// </Summary>
    public virtual void AddOnLastListenerRemovedCallback(VoidCallback callback)
    {

        _OnLastListenerRemovedCallbacks.Add(callback);
    }




    /// <Summary>
    /// Removes a callback previously suppplied to
    /// [addOnLastListenerRemovedCallback].
    /// </Summary>
    public virtual void RemoveOnLastListenerRemovedCallback(VoidCallback callback)
    {

        _OnLastListenerRemovedCallbacks.Remove(callback);
    }




    /// <Summary>
    /// Calls all the registered listeners to notify them of a new image.
    /// </Summary>
    public virtual void SetImage(FlutterSDK.Painting.Imagestream.ImageInfo image)
    {
        _CurrentImage = image;
        if (_Listeners.IsEmpty()) return;
        List<ImageStreamListener> localListeners = List<ImageStreamListener>.From(_Listeners);
        foreach (ImageStreamListener listener in localListeners)
        {
            try
            {
                listener.OnImage(image, false);
            }
            catch (exception,stack){
                ReportError(context: new ErrorDescription("by an image listener"), exception: exception, stack: stack);
            }

            }

        }




/// <Summary>
/// Calls all the registered error listeners to notify them of an error that
/// occurred while resolving the image.
///
/// If no error listeners (listeners with an [ImageStreamListener.onError]
/// specified) are attached, a [FlutterError] will be reported instead.
///
/// The `context` should be a string describing where the error was caught, in
/// a form that will make sense in English when following the word "thrown",
/// as in "thrown while obtaining the image from the network" (for the context
/// "while obtaining the image from the network").
///
/// The `exception` is the error being reported; the `stack` is the
/// [StackTrace] associated with the exception.
///
/// The `informationCollector` is a callback (of type [InformationCollector])
/// that is called when the exception is used by [FlutterError.reportError].
/// It is used to obtain further details to include in the logs, which may be
/// expensive to collect, and thus should only be collected if the error is to
/// be logged in the first place.
///
/// The `silent` argument causes the exception to not be reported to the logs
/// in release builds, if passed to [FlutterError.reportError]. (It is still
/// sent to error handlers.) It should be set to true if the error is one that
/// is expected to be encountered in release builds, for example network
/// errors. That way, logs on end-user devices will not have spurious
/// messages, but errors during development will still be reported.
///
/// See [FlutterErrorDetails] for further details on these values.
/// </Summary>
    public virtual void ReportError(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), object exception = default(object), StackTrace stack = default(StackTrace), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
    {
        _CurrentError = new FlutterErrorDetails(exception: exception, stack: stack, library: "image resource service", context: context, informationCollector: informationCollector, silent: silent);
        List<ImageErrorListener> localErrorListeners = _Listeners.Map((ImageStreamListener listener) => =>listener.OnError).Where((ImageErrorListener errorListener) => =>errorListener != null).ToList();
        if (localErrorListeners.IsEmpty())
        {
            AssertionsDefaultClass.FlutterError.ReportError(_CurrentError);
        }
        else
        {
            foreach (ImageErrorListener errorListener in localErrorListeners)
            {
                try
                {
                    errorListener(exception, stack);
                }
                catch (exception,stack){
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(context: new ErrorDescription("when reporting an error to an image listener"), library: "image resource service", exception: exception, stack: stack));
                }

                }

            }

        }




/// <Summary>
/// Accumulates a list of strings describing the object's state. Subclasses
/// should override this to have their information included in [toString].
/// </Summary>
    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
    {
        base.DebugFillProperties(description);
        description.Add(new DiagnosticsProperty<ImageInfo>("current", _CurrentImage, ifNull: "unresolved", showName: false));
        description.Add(new ObjectFlagProperty<List<ImageStreamListener>>("listeners", _Listeners, ifPresent: $"'{_Listeners?.Count} listener{_Listeners?.Count == 1 ? "":'s'}'"));
    }



    #endregion
}


/// <Summary>
/// Manages the loading of [dart:ui.Image] objects for static [ImageStream]s (those
/// with only one frame).
/// </Summary>
public class OneFrameImageStreamCompleter : FlutterSDK.Painting.Imagestream.ImageStreamCompleter
{
    #region constructors
    public OneFrameImageStreamCompleter(Future<FlutterSDK.Painting.Imagestream.ImageInfo> image, FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
    : base()

image.Then(SetImage, onError:(object error, StackTrace stack) => {
ReportError(context:new ErrorDescription("resolving a single-frame image stream"), exception:error, stack:stack, informationCollector:informationCollector, silent:true );
}
);
}


#endregion

#region fields
#endregion

#region methods
#endregion
}


/// <Summary>
/// Manages the decoding and scheduling of image frames.
///
/// New frames will only be emitted while there are registered listeners to the
/// stream (registered with [addListener]).
///
/// This class deals with 2 types of frames:
///
///  * image frames - image frames of an animated image.
///  * app frames - frames that the flutter engine is drawing to the screen to
///    show the app GUI.
///
/// For single frame images the stream will only complete once.
///
/// For animated images, this class eagerly decodes the next image frame,
/// and notifies the listeners that a new frame is ready on the first app frame
/// that is scheduled after the image frame duration has passed.
///
/// Scheduling new timers only from scheduled app frames, makes sure we pause
/// the animation when the app is not visible (as new app frames will not be
/// scheduled).
///
/// See the following timeline example:
///
///     | Time | Event                                      | Comment                   |
///     |------|--------------------------------------------|---------------------------|
///     | t1   | App frame scheduled (image frame A posted) |                           |
///     | t2   | App frame scheduled                        |                           |
///     | t3   | App frame scheduled                        |                           |
///     | t4   | Image frame B decoded                      |                           |
///     | t5   | App frame scheduled                        | t5 - t1 < frameB_duration |
///     | t6   | App frame scheduled (image frame B posted) | t6 - t1 > frameB_duration |
///
/// </Summary>
public class MultiFrameImageStreamCompleter : FlutterSDK.Painting.Imagestream.ImageStreamCompleter
{
    #region constructors
    public MultiFrameImageStreamCompleter(Future<SKCodec> codec = default(Future<SKCodec>), double scale = default(double), Stream<FlutterSDK.Painting.Imagestream.ImageChunkEvent> chunkEvents = default(Stream<FlutterSDK.Painting.Imagestream.ImageChunkEvent>), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector))
    : base()

codec.Then(_HandleCodecReady, onError:(object error, StackTrace stack) => {
ReportError(context:new ErrorDescription("resolving an image codec"), exception:error, stack:stack, informationCollector:informationCollector, silent:true );
}
);
if (chunkEvents != null)
{
    chunkEvents.Listen((ImageChunkEvent @event) =>
    {
        if (HasListeners)
        {
            List<ImageChunkListener> localListeners = _Listeners.Map((ImageStreamListener listener) => =>listener.OnChunk).Where((ImageChunkListener chunkListener) => =>chunkListener != null).ToList();
            foreach (ImageChunkListener listener in localListeners)
            {
                listener(@event);
            }

        }

    }
    , onError: (object error, StackTrace stack) =>
    {
        ReportError(context: new ErrorDescription("loading an image"), exception: error, stack: stack, informationCollector: informationCollector, silent: true);
    }
    );
}

}


#endregion

#region fields
internal virtual SKCodec _Codec { get; set; }
internal virtual double _Scale { get; set; }
internal virtual FlutterSDK.Foundation.Assertions.InformationCollector _InformationCollector { get; set; }
internal virtual SKCodecFrameInfo _NextFrame { get; set; }
internal virtual TimeSpan _ShownTimestamp { get; set; }
internal virtual TimeSpan _FrameDuration { get; set; }
internal virtual int _FramesEmitted { get; set; }
internal virtual Timer _Timer { get; set; }
internal virtual bool _FrameCallbackScheduled { get; set; }
#endregion

#region methods

private void _HandleCodecReady(SKCodec codec)
{
    _Codec = codec;

    if (HasListeners)
    {
        _DecodeNextFrameAndSchedule();
    }

}




private void _HandleAppFrame(TimeSpan timestamp)
{
    _FrameCallbackScheduled = false;
    if (!HasListeners) return;
    if (_IsFirstFrame() || _HasFrameDurationPassed(timestamp))
    {
        _EmitFrame(new ImageInfo(image: _NextFrame.Image, scale: _Scale));
        _ShownTimestamp = timestamp;
        _FrameDuration = _NextFrame.Duration;
        _NextFrame = null;
        int completedCycles = _FramesEmitted~/ _Codec.FrameCount;
        if (_Codec.RepetitionCount == -1 || completedCycles <= _Codec.RepetitionCount)
        {
            _DecodeNextFrameAndSchedule();
        }

        return;
    }

    TimeSpan delay = _FrameDuration - (timestamp - _ShownTimestamp);
    _Timer = new Timer(delay * BindingDefaultClass.TimeDilation, () =>
    {
        _ScheduleAppFrame();
    }
    );
}




private bool _IsFirstFrame()
{
    return _FrameDuration == null;
}




private bool _HasFrameDurationPassed(TimeSpan timestamp)
{

    return timestamp - _ShownTimestamp >= _FrameDuration;
}




private Future<object> _DecodeNextFrameAndSchedule()
async
{
    try
    {
        _NextFrame = await _Codec.GetNextFrame();
    }
    catch (exception,stack){
        ReportError(context: new ErrorDescription("resolving an image frame"), exception: exception, stack: stack, informationCollector: _InformationCollector, silent: true);
        return;
    }

    if (_Codec.FrameCount == 1)
    {
        _EmitFrame(new ImageInfo(image: _NextFrame.Image, scale: _Scale));
        return;
    }

    _ScheduleAppFrame();
    }




    private void _ScheduleAppFrame()
    {
        if (_FrameCallbackScheduled)
        {
            return;
        }

        _FrameCallbackScheduled = true;
        BindingDefaultClass.SchedulerBinding.Instance.ScheduleFrameCallback(_HandleAppFrame);
    }




    private void _EmitFrame(FlutterSDK.Painting.Imagestream.ImageInfo imageInfo)
    {
        SetImage(imageInfo);
        _FramesEmitted += 1;
    }




public new void AddListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
{
    if (!HasListeners && _Codec != null) _DecodeNextFrameAndSchedule();
    base.AddListener(listener);
}




public new void RemoveListener(FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
{
    base.RemoveListener(listener);
    if (!HasListeners)
    {
        _Timer?.Cancel();
        _Timer = null;
    }

}



#endregion
}

}
