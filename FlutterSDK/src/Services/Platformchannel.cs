using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Services.Platformchannel
{
    internal static class PlatformchannelDefaultClass
    {
    }

    /// <Summary>
    /// A named channel for communicating with platform plugins using asynchronous
    /// message passing.
    ///
    /// Messages are encoded into binary before being sent, and binary messages
    /// received are decoded into Dart values. The [MessageCodec] used must be
    /// compatible with the one used by the platform plugin. This can be achieved
    /// by creating a basic message channel counterpart of this channel on the
    /// platform side. The Dart type of messages sent and received is [T],
    /// but only the values supported by the specified [MessageCodec] can be used.
    /// The use of unsupported values should be considered programming errors, and
    /// will result in exceptions being thrown. The null message is supported
    /// for all codecs.
    ///
    /// The logical identity of the channel is given by its name. Identically named
    /// channels will interfere with each other's communication.
    ///
    /// See: <https://flutter.dev/platform-channels/>
    /// </Summary>
    public class BasicMessageChannel<T>
    {
        /// <Summary>
        /// Creates a [BasicMessageChannel] with the specified [name], [codec] and [binaryMessenger].
        ///
        /// The [name] and [codec] arguments cannot be null. The default [ServicesBinding.defaultBinaryMessenger]
        /// instance is used if [binaryMessenger] is null.
        /// </Summary>
        public BasicMessageChannel(string name, FlutterSDK.Services.Messagecodec.MessageCodec<T> codec, FlutterSDK.Services.Binarymessenger.BinaryMessenger binaryMessenger = default(FlutterSDK.Services.Binarymessenger.BinaryMessenger))
        : base()
        {
            this.Name = name;
            this.Codec = codec;
        }
        /// <Summary>
        /// The logical channel on which communication happens, not null.
        /// </Summary>
        public virtual string Name { get; set; }
        /// <Summary>
        /// The message codec used by this channel, not null.
        /// </Summary>
        public virtual FlutterSDK.Services.Messagecodec.MessageCodec<T> Codec { get; set; }
        internal virtual FlutterSDK.Services.Binarymessenger.BinaryMessenger _BinaryMessenger { get; set; }
        public virtual FlutterSDK.Services.Binarymessenger.BinaryMessenger BinaryMessenger { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Sends the specified [message] to the platform plugins on this channel.
        ///
        /// Returns a [Future] which completes to the received response, which may
        /// be null.
        /// </Summary>
        public virtual async Future<T> Send(T message)
        {
            return Codec.DecodeMessage(await BinaryMessenger.Send(Name, Codec.EncodeMessage(message)));
        }




        /// <Summary>
        /// Sets a callback for receiving messages from the platform plugins on this
        /// channel. Messages may be null.
        ///
        /// The given callback will replace the currently registered callback for this
        /// channel, if any. To remove the handler, pass null as the `handler`
        /// argument.
        ///
        /// The handler's return value is sent back to the platform plugins as a
        /// message reply. It may be null.
        /// </Summary>
        public virtual void SetMessageHandler(Func<Future<T>, T> handler)
        {
            if (handler == null)
            {
                BinaryMessenger.SetMessageHandler(Name, null);
            }
            else
            {
                BinaryMessenger.SetMessageHandler(Name, async (ByteData message) =>
                {
                    return Codec.EncodeMessage(await handler(Codec.DecodeMessage(message)));
                }
                );
            }

        }




        /// <Summary>
        /// Sets a mock callback for intercepting messages sent on this channel.
        /// Messages may be null.
        ///
        /// The given callback will replace the currently registered mock callback for
        /// this channel, if any. To remove the mock handler, pass null as the
        /// `handler` argument.
        ///
        /// The handler's return value is used as a message reply. It may be null.
        ///
        /// This is intended for testing. Messages intercepted in this manner are not
        /// sent to platform plugins.
        /// </Summary>
        public virtual void SetMockMessageHandler(Func<Future<T>, T> handler)
        {
            if (handler == null)
            {
                BinaryMessenger.SetMockMessageHandler(Name, null);
            }
            else
            {
                BinaryMessenger.SetMockMessageHandler(Name, async (ByteData message) =>
                {
                    return Codec.EncodeMessage(await handler(Codec.DecodeMessage(message)));
                }
                );
            }

        }



    }


    /// <Summary>
    /// A named channel for communicating with platform plugins using asynchronous
    /// method calls.
    ///
    /// Method calls are encoded into binary before being sent, and binary results
    /// received are decoded into Dart values. The [MethodCodec] used must be
    /// compatible with the one used by the platform plugin. This can be achieved
    /// by creating a method channel counterpart of this channel on the
    /// platform side. The Dart type of arguments and results is `dynamic`,
    /// but only values supported by the specified [MethodCodec] can be used.
    /// The use of unsupported values should be considered programming errors, and
    /// will result in exceptions being thrown. The null value is supported
    /// for all codecs.
    ///
    /// The logical identity of the channel is given by its name. Identically named
    /// channels will interfere with each other's communication.
    ///
    /// See: <https://flutter.dev/platform-channels/>
    /// </Summary>
    public class MethodChannel
    {
        /// <Summary>
        /// Creates a [MethodChannel] with the specified [name].
        ///
        /// The [codec] used will be [StandardMethodCodec], unless otherwise
        /// specified.
        ///
        /// The [name] and [codec] arguments cannot be null. The default [ServicesBinding.defaultBinaryMessenger]
        /// instance is used if [binaryMessenger] is null.
        /// </Summary>
        public MethodChannel(string name, FlutterSDK.Services.Messagecodec.MethodCodec codec = default(FlutterSDK.Services.Messagecodec.MethodCodec), FlutterSDK.Services.Binarymessenger.BinaryMessenger binaryMessenger = default(FlutterSDK.Services.Binarymessenger.BinaryMessenger))
        : base()
        {
            this.Name = name;
            this.Codec = codec;
        }
        /// <Summary>
        /// The logical channel on which communication happens, not null.
        /// </Summary>
        public virtual string Name { get; set; }
        /// <Summary>
        /// The message codec used by this channel, not null.
        /// </Summary>
        public virtual FlutterSDK.Services.Messagecodec.MethodCodec Codec { get; set; }
        internal virtual FlutterSDK.Services.Binarymessenger.BinaryMessenger _BinaryMessenger { get; set; }
        public virtual FlutterSDK.Services.Binarymessenger.BinaryMessenger BinaryMessenger { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private async Future<T> _InvokeMethod<T>(string method, bool missingOk = default(bool), object arguments = default(object))
        {

            ByteData result = await BinaryMessenger.Send(Name, Codec.EncodeMethodCall(new MethodCall(method, arguments)));
            if (result == null)
            {
                if (missingOk)
                {
                    return null;
                }

                throw new MissingPluginException($"'No implementation found for method {method} on channel {Name}'");
            }

            return Codec.DecodeEnvelope(result) as T;
        }




        /// <Summary>
        /// Invokes a [method] on this channel with the specified [arguments].
        ///
        /// The static type of [arguments] is `dynamic`, but only values supported by
        /// the [codec] of this channel can be used. The same applies to the returned
        /// result. The values supported by the default codec and their platform-specific
        /// counterparts are documented with [StandardMessageCodec].
        ///
        /// The generic argument `T` of the method can be inferred by the surrounding
        /// context, or provided explicitly. If it does not match the returned type of
        /// the channel, a [TypeError] will be thrown at runtime. `T` cannot be a class
        /// with generics other than `dynamic`. For example, `Map<String, String>`
        /// is not supported but `Map<dynamic, dynamic>` or `Map` is.
        ///
        /// Returns a [Future] which completes to one of the following:
        ///
        /// * a result (possibly null), on successful invocation;
        /// * a [PlatformException], if the invocation failed in the platform plugin;
        /// * a [MissingPluginException], if the method has not been implemented by a
        ///   platform plugin.
        ///
        /// The following code snippets demonstrate how to invoke platform methods
        /// in Dart using a MethodChannel and how to implement those methods in Java
        /// (for Android) and Objective-C (for iOS).
        ///
        /// {@tool snippet}
        ///
        /// The code might be packaged up as a musical plugin, see
        /// <https://flutter.dev/developing-packages/>:
        ///
        /// ```dart
        /// class Music {
        ///   static const MethodChannel _channel = MethodChannel('music');
        ///
        ///   static Future<bool> isLicensed() async {
        ///     // invokeMethod returns a Future<T> which can be inferred as bool
        ///     // in this context.
        ///     return _channel.invokeMethod('isLicensed');
        ///   }
        ///
        ///   static Future<List<Song>> songs() async {
        ///     // invokeMethod here returns a Future<dynamic> that completes to a
        ///     // List<dynamic> with Map<dynamic, dynamic> entries. Post-processing
        ///     // code thus cannot assume e.g. List<Map<String, String>> even though
        ///     // the actual values involved would support such a typed container.
        ///     // The correct type cannot be inferred with any value of `T`.
        ///     final List<dynamic> songs = await _channel.invokeMethod('getSongs');
        ///     return songs.map(Song.fromJson).toList();
        ///   }
        ///
        ///   static Future<void> play(Song song, double volume) async {
        ///     // Errors occurring on the platform side cause invokeMethod to throw
        ///     // PlatformExceptions.
        ///     try {
        ///       return _channel.invokeMethod('play', <String, dynamic>{
        ///         'song': song.id,
        ///         'volume': volume,
        ///       });
        ///     } on PlatformException catch (e) {
        ///       throw 'Unable to play ${song.title}: ${e.message}';
        ///     }
        ///   }
        /// }
        ///
        /// class Song {
        ///   Song(this.id, this.title, this.artist);
        ///
        ///   final String id;
        ///   final String title;
        ///   final String artist;
        ///
        ///   static Song fromJson(dynamic json) {
        ///     return Song(json['id'], json['title'], json['artist']);
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        ///
        /// Java (for Android):
        ///
        /// ```java
        /// // Assumes existence of an Android MusicApi.
        /// public class MusicPlugin implements MethodCallHandler {
        ///   @Override
        ///   public void onMethodCall(MethodCall call, Result result) {
        ///     switch (call.method) {
        ///       case "isLicensed":
        ///         result.success(MusicApi.checkLicense());
        ///         break;
        ///       case "getSongs":
        ///         final List<MusicApi.Track> tracks = MusicApi.getTracks();
        ///         final List<Object> json = ArrayList<>(tracks.size());
        ///         for (MusicApi.Track track : tracks) {
        ///           json.add(track.toJson()); // Map<String, Object> entries
        ///         }
        ///         result.success(json);
        ///         break;
        ///       case "play":
        ///         final String song = call.argument("song");
        ///         final double volume = call.argument("volume");
        ///         try {
        ///           MusicApi.playSongAtVolume(song, volume);
        ///           result.success(null);
        ///         } catch (MusicalException e) {
        ///           result.error("playError", e.getMessage(), null);
        ///         }
        ///         break;
        ///       default:
        ///         result.notImplemented();
        ///     }
        ///   }
        ///   // Other methods elided.
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        ///
        /// Objective-C (for iOS):
        ///
        /// ```objectivec
        /// @interface MusicPlugin : NSObject<FlutterPlugin>
        /// @end
        ///
        /// // Assumes existence of an iOS Broadway Play Api.
        /// @implementation MusicPlugin
        /// - (void)handleMethodCall:(FlutterMethodCall*)call result:(FlutterResult)result {
        ///   if ([@"isLicensed" isEqualToString:call.method]) {
        ///     result([NSNumber numberWithBool:[BWPlayApi isLicensed]]);
        ///   } else if ([@"getSongs" isEqualToString:call.method]) {
        ///     NSArray* items = [BWPlayApi items];
        ///     NSMutableArray* json = [NSMutableArray arrayWithCapacity:items.count];
        ///     for (final BWPlayItem* item in items) {
        ///       [json addObject:@{@"id":item.itemId, @"title":item.name, @"artist":item.artist}];
        ///     }
        ///     result(json);
        ///   } else if ([@"play" isEqualToString:call.method]) {
        ///     NSString* itemId = call.arguments[@"song"];
        ///     NSNumber* volume = call.arguments[@"volume"];
        ///     NSError* error = nil;
        ///     BOOL success = [BWPlayApi playItem:itemId volume:volume.doubleValue error:&error];
        ///     if (success) {
        ///       result(nil);
        ///     } else {
        ///       result([FlutterError errorWithCode:[NSString stringWithFormat:@"Error %ld", error.code]
        ///                                  message:error.domain
        ///                                  details:error.localizedDescription]);
        ///     }
        ///   } else {
        ///     result(FlutterMethodNotImplemented);
        ///   }
        /// }
        /// // Other methods elided.
        /// @end
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [invokeListMethod], for automatically returning typed lists.
        ///  * [invokeMapMethod], for automatically returning typed maps.
        ///  * [StandardMessageCodec] which defines the payload values supported by
        ///    [StandardMethodCodec].
        ///  * [JSONMessageCodec] which defines the payload values supported by
        ///    [JSONMethodCodec].
        ///  * <https://api.flutter.dev/javadoc/io/flutter/plugin/common/MethodCall.html>
        ///    for how to access method call arguments on Android.
        /// </Summary>
        public virtual Future<T> InvokeMethod<T>(string method, object arguments = default(object))
        {
            return _InvokeMethod(method, missingOk: false, arguments: arguments);
        }




        /// <Summary>
        /// An implementation of [invokeMethod] that can return typed lists.
        ///
        /// Dart generics are reified, meaning that an untyped List<dynamic>
        /// cannot masquerade as a List<T>. Since invokeMethod can only return
        /// dynamic maps, we instead create a new typed list using [List.cast].
        ///
        /// See also:
        ///
        ///  * [invokeMethod], which this call delegates to.
        /// </Summary>
        public virtual async Future<List<T>> InvokeListMethod<T>(string method, object arguments = default(object))
        {
            List<object> result = await InvokeMethod(method, arguments);
            return result?.Cast();
        }




        /// <Summary>
        /// An implementation of [invokeMethod] that can return typed maps.
        ///
        /// Dart generics are reified, meaning that an untyped Map<dynamic, dynamic>
        /// cannot masquerade as a Map<K, V>. Since invokeMethod can only return
        /// dynamic maps, we instead create a new typed map using [Map.cast].
        ///
        /// See also:
        ///
        ///  * [invokeMethod], which this call delegates to.
        /// </Summary>
        public virtual async Future<Dictionary<K, V>> InvokeMapMethod<K, V>(string method, object arguments = default(object))
        {
            Dictionary<object, object> result = await InvokeMethod(method, arguments);
            return result?.Cast();
        }




        /// <Summary>
        /// Sets a callback for receiving method calls on this channel.
        ///
        /// The given callback will replace the currently registered callback for this
        /// channel, if any. To remove the handler, pass null as the
        /// `handler` argument.
        ///
        /// If the future returned by the handler completes with a result, that value
        /// is sent back to the platform plugin caller wrapped in a success envelope
        /// as defined by the [codec] of this channel. If the future completes with
        /// a [PlatformException], the fields of that exception will be used to
        /// populate an error envelope which is sent back instead. If the future
        /// completes with a [MissingPluginException], an empty reply is sent
        /// similarly to what happens if no method call handler has been set.
        /// Any other exception results in an error envelope being sent.
        /// </Summary>
        public virtual void SetMethodCallHandler(Func<Future<object>, MethodCall> handler)
        {
            BinaryMessenger.SetMessageHandler(Name, handler == null ? null : (ByteData message) => =>_HandleAsMethodCall(message, handler));
        }




        /// <Summary>
        /// Sets a mock callback for intercepting method invocations on this channel.
        ///
        /// The given callback will replace the currently registered mock callback for
        /// this channel, if any. To remove the mock handler, pass null as the
        /// `handler` argument.
        ///
        /// Later calls to [invokeMethod] will result in a successful result,
        /// a [PlatformException] or a [MissingPluginException], determined by how
        /// the future returned by the mock callback completes. The [codec] of this
        /// channel is used to encode and decode values and errors.
        ///
        /// This is intended for testing. Method calls intercepted in this manner are
        /// not sent to platform plugins.
        ///
        /// The provided `handler` must return a `Future` that completes with the
        /// return value of the call. The value will be encoded using
        /// [MethodCodec.encodeSuccessEnvelope], to act as if platform plugin had
        /// returned that value.
        /// </Summary>
        public virtual void SetMockMethodCallHandler(Func<Future<object>, MethodCall> handler)
        {
            BinaryMessenger.SetMockMessageHandler(Name, handler == null ? null : (ByteData message) => =>_HandleAsMethodCall(message, handler));
        }




        private async Future<ByteData> _HandleAsMethodCall(ByteData message, Func<Future<object>, MethodCall> handler)
        {
            MethodCall call = Codec.DecodeMethodCall(message);
            try
            {
                return Codec.EncodeSuccessEnvelope(await handler(call));
            }
on PlatformExceptioncatch(e)
            {
                return Codec.EncodeErrorEnvelope(code: e.Code, message: e.Message, details: e.Details);
            }
            on MissingPluginException{
                return null;
            }
catch (e)
            {
                return Codec.EncodeErrorEnvelope(code: "error", message: e.ToString(), details: null);
            }

        }



    }


    /// <Summary>
    /// A [MethodChannel] that ignores missing platform plugins.
    ///
    /// When [invokeMethod] fails to find the platform plugin, it returns null
    /// instead of throwing an exception.
    /// </Summary>
    public class OptionalMethodChannel : FlutterSDK.Services.Platformchannel.MethodChannel
    {
        /// <Summary>
        /// Creates a [MethodChannel] that ignores missing platform plugins.
        /// </Summary>
        public OptionalMethodChannel(string name, FlutterSDK.Services.Messagecodec.MethodCodec codec = default(FlutterSDK.Services.Messagecodec.MethodCodec))
        : base(name, codec)
        {

        }

        public new async Future<T> InvokeMethod<T>(string method, object arguments = default(object))
        {
            return base._InvokeMethod(method, missingOk: true, arguments: arguments);
        }




        public new async Future<List<T>> InvokeListMethod<T>(string method, object arguments = default(object))
        {
            List<object> result = await InvokeMethod(method, arguments);
            return result.Cast();
        }




        public new async Future<Dictionary<K, V>> InvokeMapMethod<K, V>(string method, object arguments = default(object))
        {
            Dictionary<object, object> result = await InvokeMethod(method, arguments);
            return result.Cast();
        }



    }


    /// <Summary>
    /// A named channel for communicating with platform plugins using event streams.
    ///
    /// Stream setup requests are encoded into binary before being sent,
    /// and binary events and errors received are decoded into Dart values.
    /// The [MethodCodec] used must be compatible with the one used by the platform
    /// plugin. This can be achieved by creating an `EventChannel` counterpart of
    /// this channel on the platform side. The Dart type of events sent and received
    /// is `dynamic`, but only values supported by the specified [MethodCodec] can
    /// be used.
    ///
    /// The logical identity of the channel is given by its name. Identically named
    /// channels will interfere with each other's communication.
    ///
    /// See: <https://flutter.dev/platform-channels/>
    /// </Summary>
    public class EventChannel
    {
        /// <Summary>
        /// Creates an [EventChannel] with the specified [name].
        ///
        /// The [codec] used will be [StandardMethodCodec], unless otherwise
        /// specified.
        ///
        /// Neither [name] nor [codec] may be null. The default [ServicesBinding.defaultBinaryMessenger]
        /// instance is used if [binaryMessenger] is null.
        /// </Summary>
        public EventChannel(string name, FlutterSDK.Services.Messagecodec.MethodCodec codec = default(FlutterSDK.Services.Messagecodec.MethodCodec), FlutterSDK.Services.Binarymessenger.BinaryMessenger binaryMessenger = default(FlutterSDK.Services.Binarymessenger.BinaryMessenger))
        : base()
        {
            this.Name = name;
            this.Codec = codec;
        }
        /// <Summary>
        /// The logical channel on which communication happens, not null.
        /// </Summary>
        public virtual string Name { get; set; }
        /// <Summary>
        /// The message codec used by this channel, not null.
        /// </Summary>
        public virtual FlutterSDK.Services.Messagecodec.MethodCodec Codec { get; set; }
        internal virtual FlutterSDK.Services.Binarymessenger.BinaryMessenger _BinaryMessenger { get; set; }
        public virtual FlutterSDK.Services.Binarymessenger.BinaryMessenger BinaryMessenger { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Sets up a broadcast stream for receiving events on this channel.
        ///
        /// Returns a broadcast [Stream] which emits events to listeners as follows:
        ///
        /// * a decoded data event (possibly null) for each successful event
        ///   received from the platform plugin;
        /// * an error event containing a [PlatformException] for each error event
        ///   received from the platform plugin.
        ///
        /// Errors occurring during stream activation or deactivation are reported
        /// through the [FlutterError] facility. Stream activation happens only when
        /// stream listener count changes from 0 to 1. Stream deactivation happens
        /// only when stream listener count changes from 1 to 0.
        /// </Summary>
        public virtual Stream<object> ReceiveBroadcastStream(object arguments = default(object))
        {
            MethodChannel methodChannel = new MethodChannel(Name, Codec);
            StreamController<object> controller = default(StreamController<object>);
            controller = StreamController<object>.Broadcast(onListen: async () =>
            {
                BinaryMessenger.SetMessageHandler(Name, async (ByteData reply) =>
                {
                    if (reply == null)
                    {
                        controller.Close();
                    }
                    else
                    {
                        try
                        {
                            controller.Add(Codec.DecodeEnvelope(reply));
                        }
on PlatformExceptioncatch(e)
                        {
                            controller.AddError(e);
                        }

                    }

                    return null;
                }
                );
                try
                {
                    await methodChannel.InvokeMethod("listen", arguments);
                }
                catch (exception,stack){
                AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, library: "services library", context: new ErrorDescription($"'while activating platform stream on channel {Name}'")));
            }

        }
, onCancel:async() => {
BinaryMessenger.SetMessageHandler(Name, null );
try {
await methodChannel.InvokeMethod("cancel", arguments);
    }
catch (exception, stack){
AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception:exception, stack:stack, library:"services library", context:new ErrorDescription($"'while de-activating platform stream on channel {Name}'")));
}

}
);
return controller.Stream;
}



}

}
