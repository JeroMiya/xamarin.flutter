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
namespace FlutterSDK.Services.Messagecodecs
{
    internal static class MessagecodecsDefaultClass
    {
    }

    /// <Summary>
    /// [MessageCodec] with unencoded binary messages represented using [ByteData].
    ///
    /// On Android, messages will be represented using `java.nio.ByteBuffer`.
    /// On iOS, messages will be represented using `NSData`.
    ///
    /// When sending outgoing messages from Android, be sure to use direct `ByteBuffer`
    /// as opposed to indirect. The `wrap()` API provides indirect buffers by default
    /// and you will get empty `ByteData` objects in Dart.
    /// </Summary>
    public class BinaryCodec : IMessageCodec<ByteData>
    {
        #region constructors
        public BinaryCodec()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new ByteData DecodeMessage(ByteData message) { throw new NotImplementedException(); }


        public new ByteData EncodeMessage(ByteData message) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// [MessageCodec] with UTF-8 encoded String messages.
    ///
    /// On Android, messages will be represented using `java.util.String`.
    /// On iOS, messages will be represented using `NSString`.
    /// </Summary>
    public class StringCodec : IMessageCodec<string>
    {
        #region constructors
        public StringCodec()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new string DecodeMessage(ByteData message) { throw new NotImplementedException(); }


        public new ByteData EncodeMessage(string message) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// [MessageCodec] with UTF-8 encoded JSON messages.
    ///
    /// Supported messages are acyclic values of these forms:
    ///
    ///  * null
    ///  * [bool]s
    ///  * [num]s
    ///  * [String]s
    ///  * [List]s of supported values
    ///  * [Map]s from strings to supported values
    ///
    /// On Android, messages are decoded using the `org.json` library.
    /// On iOS, messages are decoded using the `NSJSONSerialization` library.
    /// In both cases, the use of top-level simple messages (null, [bool], [num],
    /// and [String]) is supported (by the Flutter SDK). The decoded value will be
    /// null/nil for null, and identical to what would result from decoding a
    /// singleton JSON array with a Boolean, number, or string value, and then
    /// extracting its single element.
    /// </Summary>
    public class JSONMessageCodec : IMessageCodec<object>
    {
        #region constructors
        public JSONMessageCodec()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new ByteData EncodeMessage(object message) { throw new NotImplementedException(); }


        public new object DecodeMessage(ByteData message) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// [MethodCodec] with UTF-8 encoded JSON method calls and result envelopes.
    ///
    /// Values supported as method arguments and result payloads are those supported
    /// by [JSONMessageCodec].
    /// </Summary>
    public class JSONMethodCodec : IMethodCodec
    {
        #region constructors
        public JSONMethodCodec()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new ByteData EncodeMethodCall(FlutterSDK.Services.Messagecodec.MethodCall call) { throw new NotImplementedException(); }


        public new FlutterSDK.Services.Messagecodec.MethodCall DecodeMethodCall(ByteData methodCall) { throw new NotImplementedException(); }


        public new object DecodeEnvelope(ByteData envelope) { throw new NotImplementedException(); }


        public new ByteData EncodeSuccessEnvelope(object result) { throw new NotImplementedException(); }


        public new ByteData EncodeErrorEnvelope(string code = default(string), string message = default(string), object details = default(object)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// [MessageCodec] using the Flutter standard binary encoding.
    ///
    /// Supported messages are acyclic values of these forms:
    ///
    ///  * null
    ///  * [bool]s
    ///  * [num]s
    ///  * [String]s
    ///  * [Uint8List]s, [Int32List]s, [Int64List]s, [Float64List]s
    ///  * [List]s of supported values
    ///  * [Map]s from supported values to supported values
    ///
    /// Decoded values will use `List<dynamic>` and `Map<dynamic, dynamic>`
    /// irrespective of content.
    ///
    /// On Android, messages are represented as follows:
    ///
    ///  * null: null
    ///  * [bool]\: `java.lang.Boolean`
    ///  * [int]\: `java.lang.Integer` for values that are representable using 32-bit
    ///    two's complement; `java.lang.Long` otherwise
    ///  * [double]\: `java.lang.Double`
    ///  * [String]\: `java.lang.String`
    ///  * [Uint8List]\: `byte[]`
    ///  * [Int32List]\: `int[]`
    ///  * [Int64List]\: `long[]`
    ///  * [Float64List]\: `double[]`
    ///  * [List]\: `java.util.ArrayList`
    ///  * [Map]\: `java.util.HashMap`
    ///
    /// On iOS, messages are represented as follows:
    ///
    ///  * null: nil
    ///  * [bool]\: `NSNumber numberWithBool:`
    ///  * [int]\: `NSNumber numberWithInt:` for values that are representable using
    ///    32-bit two's complement; `NSNumber numberWithLong:` otherwise
    ///  * [double]\: `NSNumber numberWithDouble:`
    ///  * [String]\: `NSString`
    ///  * [Uint8List], [Int32List], [Int64List], [Float64List]\:
    ///    `FlutterStandardTypedData`
    ///  * [List]\: `NSArray`
    ///  * [Map]\: `NSDictionary`
    ///
    /// When sending a `java.math.BigInteger` from Java, it is converted into a
    /// [String] with the hexadecimal representation of the integer. (The value is
    /// tagged as being a big integer; subclasses of this class could be made to
    /// support it natively; see the discussion at [writeValue].) This codec does
    /// not support sending big integers from Dart.
    ///
    /// The codec is extensible by subclasses overriding [writeValue] and
    /// [readValueOfType].
    /// </Summary>
    public class StandardMessageCodec : IMessageCodec<object>
    {
        #region constructors
        public StandardMessageCodec()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual int _ValueNull { get; set; }
        internal virtual int _ValueTrue { get; set; }
        internal virtual int _ValueFalse { get; set; }
        internal virtual int _ValueInt32 { get; set; }
        internal virtual int _ValueInt64 { get; set; }
        internal virtual int _ValueLargeInt { get; set; }
        internal virtual int _ValueFloat64 { get; set; }
        internal virtual int _ValueString { get; set; }
        internal virtual int _ValueUint8List { get; set; }
        internal virtual int _ValueInt32List { get; set; }
        internal virtual int _ValueInt64List { get; set; }
        internal virtual int _ValueFloat64List { get; set; }
        internal virtual int _ValueList { get; set; }
        internal virtual int _ValueMap { get; set; }
        #endregion

        #region methods

        public new ByteData EncodeMessage(object message) { throw new NotImplementedException(); }


        public new object DecodeMessage(ByteData message) { throw new NotImplementedException(); }


        /// <Summary>
        /// Writes [value] to [buffer] by first writing a type discriminator
        /// byte, then the value itself.
        ///
        /// This method may be called recursively to serialize container values.
        ///
        /// Type discriminators 0 through 127 inclusive are reserved for use by the
        /// base class, as follows:
        ///
        ///  * null = 0
        ///  * true = 1
        ///  * false = 2
        ///  * 32 bit integer = 3
        ///  * 64 bit integer = 4
        ///  * larger integers = 5 (see below)
        ///  * 64 bit floating-point number = 6
        ///  * String = 7
        ///  * Uint8List = 8
        ///  * Int32List = 9
        ///  * Int64List = 10
        ///  * Float64List = 11
        ///  * List = 12
        ///  * Map = 13
        ///  * Reserved for future expansion: 14..127
        ///
        /// The codec can be extended by overriding this method, calling super
        /// for values that the extension does not handle. Type discriminators
        /// used by extensions must be greater than or equal to 128 in order to avoid
        /// clashes with any later extensions to the base class.
        ///
        /// The "larger integers" type, 5, is never used by [writeValue]. A subclass
        /// could represent big integers from another package using that type. The
        /// format is first the type byte (0x05), then the actual number as an ASCII
        /// string giving the hexadecimal representation of the integer, with the
        /// string's length as encoded by [writeSize] followed by the string bytes. On
        /// Android, that would get converted to a `java.math.BigInteger` object. On
        /// iOS, the string representation is returned.
        /// </Summary>
        public virtual void WriteValue(FlutterSDK.Foundation.Serialization.WriteBuffer buffer, object value) { throw new NotImplementedException(); }


        /// <Summary>
        /// Reads a value from [buffer] as written by [writeValue].
        ///
        /// This method is intended for use by subclasses overriding
        /// [readValueOfType].
        /// </Summary>
        public virtual object ReadValue(FlutterSDK.Foundation.Serialization.ReadBuffer buffer) { throw new NotImplementedException(); }


        /// <Summary>
        /// Reads a value of the indicated [type] from [buffer].
        ///
        /// The codec can be extended by overriding this method, calling super for
        /// types that the extension does not handle. See the discussion at
        /// [writeValue].
        /// </Summary>
        public virtual object ReadValueOfType(int type, FlutterSDK.Foundation.Serialization.ReadBuffer buffer) { throw new NotImplementedException(); }


        /// <Summary>
        /// Writes a non-negative 32-bit integer [value] to [buffer]
        /// using an expanding 1-5 byte encoding that optimizes for small values.
        ///
        /// This method is intended for use by subclasses overriding
        /// [writeValue].
        /// </Summary>
        public virtual void WriteSize(FlutterSDK.Foundation.Serialization.WriteBuffer buffer, int value) { throw new NotImplementedException(); }


        /// <Summary>
        /// Reads a non-negative int from [buffer] as written by [writeSize].
        ///
        /// This method is intended for use by subclasses overriding
        /// [readValueOfType].
        /// </Summary>
        public virtual int ReadSize(FlutterSDK.Foundation.Serialization.ReadBuffer buffer) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// [MethodCodec] using the Flutter standard binary encoding.
    ///
    /// The standard codec is guaranteed to be compatible with the corresponding
    /// standard codec for FlutterMethodChannels on the host platform. These parts
    /// of the Flutter SDK are evolved synchronously.
    ///
    /// Values supported as method arguments and result payloads are those supported
    /// by [StandardMessageCodec].
    /// </Summary>
    public class StandardMethodCodec : IMethodCodec
    {
        #region constructors
        public StandardMethodCodec(FlutterSDK.Services.Messagecodecs.StandardMessageCodec messageCodec = default(FlutterSDK.Services.Messagecodecs.StandardMessageCodec))
        {
            this.MessageCodec = messageCodec; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Messagecodecs.StandardMessageCodec MessageCodec { get; set; }
        #endregion

        #region methods

        public new ByteData EncodeMethodCall(FlutterSDK.Services.Messagecodec.MethodCall call) { throw new NotImplementedException(); }


        public new FlutterSDK.Services.Messagecodec.MethodCall DecodeMethodCall(ByteData methodCall) { throw new NotImplementedException(); }


        public new ByteData EncodeSuccessEnvelope(object result) { throw new NotImplementedException(); }


        public new ByteData EncodeErrorEnvelope(string code = default(string), string message = default(string), object details = default(object)) { throw new NotImplementedException(); }


        public new object DecodeEnvelope(ByteData envelope) { throw new NotImplementedException(); }

        #endregion
    }

}
