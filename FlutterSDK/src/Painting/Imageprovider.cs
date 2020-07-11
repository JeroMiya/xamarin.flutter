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
namespace FlutterSDK.Painting.Imageprovider
{
    public delegate void _KeyAndErrorHandlerCallback<T>(T key, FlutterSDK.Painting.Imagestream.ImageErrorListener handleError);
    public delegate Future<object> _AsyncKeyErrorHandler<T>(T key, object exception, StackTrace stack);
    public delegate Future<SKCodec> DecoderCallback(Uint8List bytes, int cacheWidth = default(int), int cacheHeight = default(int));
    internal static class ImageproviderDefaultClass
    {
    }

    public interface IImageProvider<T>
    {
        FlutterSDK.Painting.Imagestream.ImageStream Resolve(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration);
        FlutterSDK.Painting.Imagestream.ImageStream CreateStream(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration);
        Future<FlutterSDK.Painting.Imagecache.ImageCacheStatus> ObtainCacheStatus(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Painting.Imagestream.ImageErrorListener handleError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener));
        void ResolveStreamForKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration, FlutterSDK.Painting.Imagestream.ImageStream stream, T key, FlutterSDK.Painting.Imagestream.ImageErrorListener handleError);
        Future<bool> Evict(FlutterSDK.Painting.Imagecache.ImageCache cache = default(FlutterSDK.Painting.Imagecache.ImageCache), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration));
        Future<T> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration);
        FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(T key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode);
        string ToString();
    }


    public interface IAssetBundleImageProvider
    {
        FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.AssetBundleImageKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode);
    }


    public interface INetworkImage
    {
        FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.NetworkImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode);
        string Url { get; }
        double Scale { get; }
        Dictionary<string, string> Headers { get; }
    }


    public class ImageConfiguration
    {
        #region constructors
        public ImageConfiguration(FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), double devicePixelRatio = default(double), Locale locale = default(Locale), TextDirection textDirection = default(TextDirection), Size size = default(Size), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform))
        {
            this.Bundle = bundle;
            this.DevicePixelRatio = devicePixelRatio;
            this.Locale = locale;
            this.TextDirection = textDirection;
            this.Size = size;
            this.Platform = platform; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
        public virtual double DevicePixelRatio { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual Size Size { get; set; }
        public virtual FlutterSDK.Foundation.Platform.TargetPlatform Platform { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Empty { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration CopyWith(FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), double devicePixelRatio = default(double), Locale locale = default(Locale), TextDirection textDirection = default(TextDirection), Size size = default(Size), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform)) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class ImageProvider<T>
    {
        #region constructors
        public ImageProvider()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual FlutterSDK.Painting.Imagestream.ImageStream Resolve(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Imagestream.ImageStream CreateStream(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public virtual Future<FlutterSDK.Painting.Imagecache.ImageCacheStatus> ObtainCacheStatus(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Painting.Imagestream.ImageErrorListener handleError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener)) { throw new NotImplementedException(); }


        private void _CreateErrorHandlerAndKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration, FlutterSDK.Painting.Imageprovider._KeyAndErrorHandlerCallback<T> successCallback, FlutterSDK.Painting.Imageprovider._AsyncKeyErrorHandler<T> errorCallback) { throw new NotImplementedException(); }


        public virtual void ResolveStreamForKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration, FlutterSDK.Painting.Imagestream.ImageStream stream, T key, FlutterSDK.Painting.Imagestream.ImageErrorListener handleError) { throw new NotImplementedException(); }


        public virtual Future<bool> Evict(FlutterSDK.Painting.Imagecache.ImageCache cache = default(FlutterSDK.Painting.Imagecache.ImageCache), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration)) { throw new NotImplementedException(); }


        public virtual Future<T> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(T key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        #endregion
    }


    public class AssetBundleImageKey
    {
        #region constructors
        public AssetBundleImageKey(FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), string name = default(string), double scale = default(double))
        : base()
        {
            this.Bundle = bundle;
            this.Name = name;
            this.Scale = scale; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
        public virtual string Name { get; set; }
        public virtual double Scale { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class AssetBundleImageProvider : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.AssetBundleImageKey>
    {
        #region constructors
        public AssetBundleImageProvider()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.AssetBundleImageKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        private Future<SKCodec> _LoadAsync(FlutterSDK.Painting.Imageprovider.AssetBundleImageKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SizeAwareCacheKey
    {
        #region constructors
        public _SizeAwareCacheKey(@Object providerCacheKey, int width, int height)
        {
            this.ProviderCacheKey = providerCacheKey;
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual @Object ProviderCacheKey { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class ResizeImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider._SizeAwareCacheKey>
    {
        #region constructors
        public ResizeImage(FlutterSDK.Painting.Imageprovider.ImageProvider<object> imageProvider, int width = default(int), int height = default(int))
        : base()
        {
            this.ImageProvider = imageProvider;
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ImageProvider { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ResizeIfNeeded(int cacheWidth, int cacheHeight, FlutterSDK.Painting.Imageprovider.ImageProvider<object> provider) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider._SizeAwareCacheKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        public new Future<FlutterSDK.Painting.Imageprovider._SizeAwareCacheKey> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }

        #endregion
    }


    public class NetworkImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.NetworkImage>
    {
        #region constructors
        public NetworkImage(string url, double scale = default(double), Dictionary<string, string> headers = default(Dictionary<string, string>))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string Url { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Scale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Dictionary<string, string> Headers { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.NetworkImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }

        #endregion
    }


    public class FileImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.FileImage>
    {
        #region constructors
        public FileImage(File file, double scale = 1.0)
        : base()
        {
            this.File = file;
            this.Scale = scale; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual File File { get; set; }
        public virtual double Scale { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Future<FlutterSDK.Painting.Imageprovider.FileImage> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.FileImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        private Future<SKCodec> _LoadAsync(FlutterSDK.Painting.Imageprovider.FileImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class MemoryImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.MemoryImage>
    {
        #region constructors
        public MemoryImage(Uint8List bytes, double scale = 1.0)
        : base()
        {
            this.Bytes = bytes;
            this.Scale = scale; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Uint8List Bytes { get; set; }
        public virtual double Scale { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Future<FlutterSDK.Painting.Imageprovider.MemoryImage> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.MemoryImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        private Future<SKCodec> _LoadAsync(FlutterSDK.Painting.Imageprovider.MemoryImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class ExactAssetImage : FlutterSDK.Painting.Imageprovider.AssetBundleImageProvider
    {
        #region constructors
        public ExactAssetImage(string assetName, double scale = 1.0, FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), string package = default(string))
        : base()
        {
            this.AssetName = assetName;
            this.Scale = scale;
            this.Bundle = bundle;
            this.Package = package; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string AssetName { get; set; }
        public virtual double Scale { get; set; }
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
        public virtual string Package { get; set; }
        public virtual string KeyName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Future<FlutterSDK.Painting.Imageprovider.AssetBundleImageKey> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    public class _ErrorImageCompleter : FlutterSDK.Painting.Imagestream.ImageStreamCompleter
    {
        #region constructors
        public _ErrorImageCompleter()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual void SetError(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), object exception = default(object), StackTrace stack = default(StackTrace), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false) { throw new NotImplementedException(); }

        #endregion
    }


    public class NetworkImageLoadException : IException
    {
        #region constructors
        public NetworkImageLoadException(int statusCode = default(int), Uri uri = default(Uri))
        : base()
        {
            this.StatusCode = statusCode;
            this.Uri = uri; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int StatusCode { get; set; }
        internal virtual string _Message { get; set; }
        public virtual Uri Uri { get; set; }
        #endregion

        #region methods

        #endregion
    }

}
