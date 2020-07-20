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
using FlutterSDK.Foundation;
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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Painting.Imagecache
{
    internal static class ImagecacheDefaultClass
    {
        public static int _KDefaultSize = default(int);
        public static int _KDefaultSizeBytes = default(int);
    }

    public interface IImageCache { }

    public class ImageCache
    {
        internal virtual Dictionary<@Object, FlutterSDK.Painting.Imagecache._PendingImage> _PendingImages { get; set; }
        internal virtual Dictionary<@Object, FlutterSDK.Painting.Imagecache._CachedImage> _Cache { get; set; }
        internal virtual Dictionary<@Object, FlutterSDK.Painting.Imagecache._LiveImage> _LiveImages { get; set; }
        internal virtual int _MaximumSize { get; set; }
        internal virtual int _MaximumSizeBytes { get; set; }
        internal virtual int _CurrentSizeBytes { get; set; }
        public virtual int MaximumSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int CurrentSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaximumSizeBytes { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int CurrentSizeBytes { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int LiveImageCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int PendingImageCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Evicts all pending and keepAlive entries from the cache.
        ///
        /// This is useful if, for instance, the root asset bundle has been updated
        /// and therefore new images must be obtained.
        ///
        /// Images which have not finished loading yet will not be removed from the
        /// cache, and when they complete they will be inserted as normal.
        ///
        /// This method does not clear live references to images, since clearing those
        /// would not reduce memory pressure. Such images still have listeners in the
        /// application code, and will still remain resident in memory.
        ///
        /// To clear live references, use [clearLiveImages].
        /// </Summary>
        public virtual void Clear()
        {
            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.InstantSync("ImageCache.clear", arguments: new Dictionary<string, object> { { "pendingImages", _PendingImages.Length }{ "keepAliveImages", _Cache.Length }{ "liveImages", _LiveImages.Length }{ "currentSizeInBytes", _CurrentSizeBytes } });
            }

            _Cache.Clear();
            _PendingImages.Clear();
            _CurrentSizeBytes = 0;
        }




        /// <Summary>
        /// Evicts a single entry from the cache, returning true if successful.
        ///
        /// Pending images waiting for completion are removed as well, returning true
        /// if successful. When a pending image is removed the listener on it is
        /// removed as well to prevent it from adding itself to the cache if it
        /// eventually completes.
        ///
        /// If this method removes a pending image, it will also remove
        /// the corresponding live tracking of the image, since it is no longer clear
        /// if the image will ever complete or have any listeners, and failing to
        /// remove the live reference could leave the cache in a state where all
        /// subsequent calls to [putIfAbsent] will return an [ImageStreamCompleter]
        /// that will never complete.
        ///
        /// If this method removes a completed image, it will _not_ remove the live
        /// reference to the image, which will only be cleared when the listener
        /// count on the completer drops to zero. To clear live image references,
        /// whether completed or not, use [clearLiveImages].
        ///
        /// The `key` must be equal to an object used to cache an image in
        /// [ImageCache.putIfAbsent].
        ///
        /// If the key is not immediately available, as is common, consider using
        /// [ImageProvider.evict] to call this method indirectly instead.
        ///
        /// The `includeLive` argument determines whether images that still have
        /// listeners in the tree should be evicted as well. This parameter should be
        /// set to true in cases where the image may be corrupted and needs to be
        /// completely discarded by the cache. It should be set to false when calls
        /// to evict are trying to relieve memory pressure, since an image with a
        /// listener will not actually be evicted from memory, and subsequent attempts
        /// to load it will end up allocating more memory for the image again. The
        /// argument must not be null.
        ///
        /// See also:
        ///
        ///  * [ImageProvider], for providing images to the [Image] widget.
        /// </Summary>
        public virtual bool Evict(@Object key, bool includeLive = true)
        {

            if (includeLive)
            {
                _LiveImage image = _LiveImages.Remove(key);
                image?.RemoveListener();
            }

            _PendingImage pendingImage = _PendingImages.Remove(key);
            if (pendingImage != null)
            {
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                Dart: developerDefaultClass.Timeline.InstantSync("ImageCache.evict", arguments: new Dictionary<string, object> { { "type", "pending" } });
                }

                pendingImage.RemoveListener();
                return true;
            }

            _CachedImage image = _Cache.Remove(key);
            if (image != null)
            {
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                Dart: developerDefaultClass.Timeline.InstantSync("ImageCache.evict", arguments: new Dictionary<string, object> { { "type", "keepAlive" }{ "sizeiInBytes", image.SizeBytes } });
                }

                _CurrentSizeBytes -= image.SizeBytes;
                return true;
            }

            if (!ConstantsDefaultClass.KReleaseMode)
            {
            Dart: developerDefaultClass.Timeline.InstantSync("ImageCache.evict", arguments: new Dictionary<string, object> { { "type", "miss" } });
            }

            return false;
        }




        /// <Summary>
        /// Updates the least recently used image cache with this image, if it is
        /// less than the [maximumSizeBytes] of this cache.
        ///
        /// Resizes the cache as appropriate to maintain the constraints of
        /// [maximumSize] and [maximumSizeBytes].
        /// </Summary>
        private void _Touch(@Object key, FlutterSDK.Painting.Imagecache._CachedImage image, TimelineTask timelineTask)
        {

            if (image.SizeBytes != null && image.SizeBytes <= MaximumSizeBytes)
            {
                _CurrentSizeBytes += image.SizeBytes;
                _Cache[key] = image;
                _CheckCacheSize(timelineTask);
            }

        }




        private void _TrackLiveImage(@Object key, FlutterSDK.Painting.Imagecache._LiveImage image, bool debugPutOk = true)
        {
            _LiveImages.PutIfAbsent(key, () =>
            {

                image.Completer.AddOnLastListenerRemovedCallback(image.HandleRemove);
                return image;
            }
            ).SizeBytes = (_LiveImages.PutIfAbsent(key, () =>
            {

                image.Completer.AddOnLastListenerRemovedCallback(image.HandleRemove);
                return image;
            }
            ).SizeBytes == null ? image.SizeBytes : _LiveImages.PutIfAbsent(key, () =>
            {

                image.Completer.AddOnLastListenerRemovedCallback(image.HandleRemove);
                return image;
            }
            ).SizeBytes);
        }




        /// <Summary>
        /// Returns the previously cached [ImageStream] for the given key, if available;
        /// if not, calls the given callback to obtain it first. In either case, the
        /// key is moved to the "most recently used" position.
        ///
        /// The arguments must not be null. The `loader` cannot return null.
        ///
        /// In the event that the loader throws an exception, it will be caught only if
        /// `onError` is also provided. When an exception is caught resolving an image,
        /// no completers are cached and `null` is returned instead of a new
        /// completer.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter PutIfAbsent(@Object key, Func<ImageStreamCompleter> loader, FlutterSDK.Painting.Imagestream.ImageErrorListener onError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener))
        {


            TimelineTask timelineTask = default(TimelineTask);
            TimelineTask listenerTask = default(TimelineTask);
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                timelineTask = new TimelineTask();
                new TimelineTask().Start("ImageCache.putIfAbsent", arguments: new Dictionary<string, object> { { "key", key.ToString() } });
            }

            ImageStreamCompleter result = _PendingImages[key]?.Completer;
            if (result != null)
            {
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                    timelineTask.Finish(arguments: new Dictionary<string, object> { { "result", "pending" } });
                }

                return result;
            }

            _CachedImage image = _Cache.Remove(key);
            if (image != null)
            {
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                    timelineTask.Finish(arguments: new Dictionary<string, object> { { "result", "keepAlive" } });
                }

                _TrackLiveImage(key, new _LiveImage(image.Completer, image.SizeBytes, () => =>_LiveImages.Remove(key)));
                _Cache[key] = image;
                return image.Completer;
            }

            _CachedImage liveImage = _LiveImages[key];
            if (liveImage != null)
            {
                _Touch(key, liveImage, timelineTask);
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                    timelineTask.Finish(arguments: new Dictionary<string, object> { { "result", "keepAlive" } });
                }

                return liveImage.Completer;
            }

            try
            {
                result = loader();
                _TrackLiveImage(key, new _LiveImage(result, null, () => =>_LiveImages.Remove(key)));
            }
            catch (error,stackTrace){
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                    timelineTask.Finish(arguments: new Dictionary<string, object> { { "result", "error" }{ "error", error.ToString() }{ "stackTrace", stackTrace.ToString() } });
                }

                if (onError != null)
                {
                    onError(error, stackTrace);
                    return null;
                }
                else
                {
                    throw;
                }

            }

            if (!ConstantsDefaultClass.KReleaseMode)
            {
                listenerTask = new TimelineTask(parent: timelineTask);
                new TimelineTask(parent: timelineTask).Start("listener");
            }

            bool listenedOnce = false;
            _PendingImage untrackedPendingImage = default(_PendingImage);
            void Listener(ImageInfo info, bool syncCall)
            {
                int imageSize = info?.Image == null ? 0 : info.Image.Height * info.Image.Width * 4;
                _CachedImage image = new _CachedImage(result, imageSize);
                _TrackLiveImage(key, new _LiveImage(result, imageSize, () => =>_LiveImages.Remove(key)), debugPutOk: syncCall);
                _PendingImage pendingImage = untrackedPendingImage ?? _PendingImages.Remove(key);
                if (pendingImage != null)
                {
                    pendingImage.RemoveListener();
                }

                if (untrackedPendingImage == null)
                {
                    _Touch(key, image, listenerTask);
                }

                if (!ConstantsDefaultClass.KReleaseMode && !listenedOnce)
                {
                    listenerTask.Finish(arguments: new Dictionary<string, object> { { "syncCall", syncCall }{ "sizeInBytes", imageSize } });
                    timelineTask.Finish(arguments: new Dictionary<string, object> { { "currentSizeBytes", CurrentSizeBytes }{ "currentSize", CurrentSize } });
                }

                listenedOnce = true;
            }

            ImageStreamListener streamListener = new ImageStreamListener(Listener);
            if (MaximumSize > 0 && MaximumSizeBytes > 0)
            {
                _PendingImages[key] = new _PendingImage(result, streamListener);
            }
            else
            {
                untrackedPendingImage = new _PendingImage(result, streamListener);
            }

            result.AddListener(streamListener);
            return result;
            }




/// <Summary>
/// The [ImageCacheStatus] information for the given `key`.
/// </Summary>
        public virtual FlutterSDK.Painting.Imagecache.ImageCacheStatus StatusForKey(@Object key)
        {
            return ImageCacheStatus._(pending: _PendingImages.ContainsKey(key), keepAlive: _Cache.ContainsKey(key), live: _LiveImages.ContainsKey(key));
        }




        /// <Summary>
        /// Returns whether this `key` has been previously added by [putIfAbsent].
        /// </Summary>
        public virtual bool ContainsKey(@Object key)
        {
            return _PendingImages[key] != null || _Cache[key] != null;
        }




        /// <Summary>
        /// Clears any live references to images in this cache.
        ///
        /// An image is considered live if its [ImageStreamCompleter] has never hit
        /// zero listeners after adding at least one listener. The
        /// [ImageStreamCompleter.addOnLastListenerRemovedCallback] is used to
        /// determine when this has happened.
        ///
        /// This is called after a hot reload to evict any stale references to image
        /// data for assets that have changed. Calling this method does not relieve
        /// memory pressure, since the live image caching only tracks image instances
        /// that are also being held by at least one other object.
        /// </Summary>
        public virtual void ClearLiveImages()
        {
            foreach (_LiveImage image in _LiveImages.Values)
            {
                image.RemoveListener();
            }

            _LiveImages.Clear();
        }




        private void _CheckCacheSize(TimelineTask timelineTask)
        {
            Dictionary<string, object> finishArgs = new Dictionary<string, object> { };
            TimelineTask checkCacheTask = default(TimelineTask);
            if (!ConstantsDefaultClass.KReleaseMode)
            {
                checkCacheTask = new TimelineTask(parent: timelineTask);
                new TimelineTask(parent: timelineTask).Start("checkCacheSize");
                finishArgs["evictedKeys"] = new List<string>() { };
                finishArgs["currentSize"] = CurrentSize;
                finishArgs["currentSizeBytes"] = CurrentSizeBytes;
            }

            while (_CurrentSizeBytes > _MaximumSizeBytes || _Cache.Length > _MaximumSize)
            {
                object key = _Cache.Keys.First;
                _CachedImage image = _Cache[key];
                _CurrentSizeBytes -= image.SizeBytes;
                _Cache.Remove(key);
                if (!ConstantsDefaultClass.KReleaseMode)
                {
                    finishArgs["evictedKeys"].Add(key.ToString());
                }

            }

            if (!ConstantsDefaultClass.KReleaseMode)
            {
                finishArgs["endSize"] = CurrentSize;
                finishArgs["endSizeBytes"] = CurrentSizeBytes;
                checkCacheTask.Finish(arguments: finishArgs);
            }




        }



    }
    public static class ImageCacheMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IImageCache, ImageCache> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IImageCache, ImageCache>();
        static ImageCache GetOrCreate(IImageCache instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ImageCache();
                _table.Add(instance, value);
            }
            return (ImageCache)value;
        }
        public static int MaximumSizeProperty(this IImageCache instance) => GetOrCreate(instance).MaximumSize;
        public static int CurrentSizeProperty(this IImageCache instance) => GetOrCreate(instance).CurrentSize;
        public static int MaximumSizeBytesProperty(this IImageCache instance) => GetOrCreate(instance).MaximumSizeBytes;
        public static int CurrentSizeBytesProperty(this IImageCache instance) => GetOrCreate(instance).CurrentSizeBytes;
        public static int LiveImageCountProperty(this IImageCache instance) => GetOrCreate(instance).LiveImageCount;
        public static int PendingImageCountProperty(this IImageCache instance) => GetOrCreate(instance).PendingImageCount;
        public static void Clear(this IImageCache instance) => GetOrCreate(instance).Clear();
        public static bool Evict(this IImageCache instance, @Object key, bool includeLive = true) => GetOrCreate(instance).Evict(key, includeLive);
        public static FlutterSDK.Painting.Imagestream.ImageStreamCompleter PutIfAbsent(this IImageCache instance, @Object key, Func<ImageStreamCompleter> loader, FlutterSDK.Painting.Imagestream.ImageErrorListener onError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener)) => GetOrCreate(instance).PutIfAbsent(key, loader, onError);
        public static FlutterSDK.Painting.Imagecache.ImageCacheStatus StatusForKey(this IImageCache instance, @Object key) => GetOrCreate(instance).StatusForKey(key);
        public static bool ContainsKey(this IImageCache instance, @Object key) => GetOrCreate(instance).ContainsKey(key);
        public static void ClearLiveImages(this IImageCache instance) => GetOrCreate(instance).ClearLiveImages();
    }


    /// <Summary>
    /// Information about how the [ImageCache] is tracking an image.
    ///
    /// A [pending] image is one that has not completed yet. It may also be tracked
    /// as [live] because something is listening to it.
    ///
    /// A [keepAlive] image is being held in the cache, which uses Least Recently
    /// Used semantics to determine when to evict an image. These images are subject
    /// to eviction based on [ImageCache.maximumSizeBytes] and
    /// [ImageCache.maximumSize]. It may be [live], but not [pending].
    ///
    /// A [live] image is being held until its [ImageStreamCompleter] has no more
    /// listeners. It may also be [pending] or [keepAlive].
    ///
    /// An [untracked] image is not being cached.
    ///
    /// To obtain an [ImageCacheStatus], use [ImageCache.statusForKey] or
    /// [ImageProvider.obtainCacheStatus].
    /// </Summary>
    public class ImageCacheStatus
    {
        #region constructors
        internal ImageCacheStatus(bool pending = false, bool keepAlive = false, bool live = false)
        : base()
        {
            this.Pending = pending;
            this.KeepAlive = keepAlive;
            this.Live = live;
        }
        #endregion

        #region fields
        public virtual bool Pending { get; set; }
        public virtual bool KeepAlive { get; set; }
        public virtual bool Live { get; set; }
        public virtual bool Tracked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Untracked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is ImageCacheStatus && other.Pending == Pending && other.KeepAlive == KeepAlive && other.Live == Live;
        }




        #endregion
    }


    public class _CachedImage
    {
        #region constructors
        public _CachedImage(FlutterSDK.Painting.Imagestream.ImageStreamCompleter completer, int sizeBytes)
        {
            this.Completer = completer;
            this.SizeBytes = sizeBytes;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter Completer { get; set; }
        public virtual int SizeBytes { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _LiveImage : FlutterSDK.Painting.Imagecache._CachedImage
    {
        #region constructors
        public _LiveImage(FlutterSDK.Painting.Imagestream.ImageStreamCompleter completer, int sizeBytes, VoidCallback handleRemove)
        : base(completer, sizeBytes)
        {
            this.HandleRemove = handleRemove;
        }
        #endregion

        #region fields
        public virtual VoidCallback HandleRemove { get; set; }
        #endregion

        #region methods

        public virtual void RemoveListener()
        {
            Completer.RemoveOnLastListenerRemovedCallback(HandleRemove);
        }



        #endregion
    }


    public class _PendingImage
    {
        #region constructors
        public _PendingImage(FlutterSDK.Painting.Imagestream.ImageStreamCompleter completer, FlutterSDK.Painting.Imagestream.ImageStreamListener listener)
        {
            this.Completer = completer;
            this.Listener = listener;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter Completer { get; set; }
        public virtual FlutterSDK.Painting.Imagestream.ImageStreamListener Listener { get; set; }
        #endregion

        #region methods

        public virtual void RemoveListener()
        {
            Completer.RemoveListener(Listener);
        }



        #endregion
    }

}
