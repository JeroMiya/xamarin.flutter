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
namespace FlutterSDK.Gestures.Events
{
    internal static class EventsDefaultClass
    {
        public static int KPrimaryButton = default(int);
        public static int KSecondaryButton = default(int);
        public static int KPrimaryMouseButton = default(int);
        public static int KSecondaryMouseButton = default(int);
        public static int KStylusContact = default(int);
        public static int KPrimaryStylusButton = default(int);
        public static int KMiddleMouseButton = default(int);
        public static int KSecondaryStylusButton = default(int);
        public static int KBackMouseButton = default(int);
        public static int KForwardMouseButton = default(int);
        public static int KTouchContact = default(int);
        /// <Summary>
        /// The bit of [PointerEvent.buttons] that corresponds to the nth mouse button.
        ///
        /// The `number` argument can be at most 62 in Flutter for mobile and desktop,
        /// and at most 32 on Flutter for web.
        ///
        /// See [kPrimaryMouseButton], [kSecondaryMouseButton], [kMiddleMouseButton],
        /// [kBackMouseButton], and [kForwardMouseButton] for semantic names for some
        /// mouse buttons.
        /// </Summary>
        internal static int NthMouseButton(int number) => (EventsDefaultClass.KPrimaryMouseButton << (number - 1)) & BitfieldDefaultClass.KMaxUnsignedSMI;


        /// <Summary>
        /// The bit of [PointerEvent.buttons] that corresponds to the nth stylus button.
        ///
        /// The `number` argument can be at most 62 in Flutter for mobile and desktop,
        /// and at most 32 on Flutter for web.
        ///
        /// See [kPrimaryStylusButton] and [kSecondaryStylusButton] for semantic names
        /// for some stylus buttons.
        /// </Summary>
        internal static int NthStylusButton(int number) => (EventsDefaultClass.KPrimaryStylusButton << (number - 1)) & BitfieldDefaultClass.KMaxUnsignedSMI;


        /// <Summary>
        /// Returns the button of `buttons` with the smallest integer.
        ///
        /// The `buttons` parameter is a bit field where each set bit represents a button.
        /// This function returns the set bit closest to the least significant bit.
        ///
        /// It returns zero when `buttons` is zero.
        ///
        /// Example:
        ///
        /// ```dart
        ///   assert(rightmostButton(0x1) == 0x1);
        ///   assert(rightmostButton(0x11) == 0x1);
        ///   assert(rightmostButton(0) == 0);
        /// ```
        ///
        /// See also:
        ///
        ///  * [isSingleButton], which checks if a `buttons` contains exactly one button.
        /// </Summary>
        internal static int SmallestButton(int buttons) => buttons & (-buttons);


        /// <Summary>
        /// Returns whether `buttons` contains one and only one button.
        ///
        /// The `buttons` parameter is a bit field where each set bit represents a button.
        /// This function returns whether there is only one set bit in the given integer.
        ///
        /// It returns false when `buttons` is zero.
        ///
        /// Example:
        ///
        /// ```dart
        ///   assert(isSingleButton(0x1) == true);
        ///   assert(isSingleButton(0x11) == false);
        ///   assert(isSingleButton(0) == false);
        /// ```
        ///
        /// See also:
        ///
        ///  * [smallestButton], which returns the button in a `buttons` bit field with
        ///    the smallest integer button.
        /// </Summary>
        internal static bool IsSingleButton(int buttons) => buttons != 0 && (EventsDefaultClass.SmallestButton(buttons) == buttons);


    }

    /// <Summary>
    /// Base class for touch, stylus, or mouse events.
    ///
    /// Pointer events operate in the coordinate space of the screen, scaled to
    /// logical pixels. Logical pixels approximate a grid with about 38 pixels per
    /// centimeter, or 96 pixels per inch.
    ///
    /// This allows gestures to be recognized independent of the precise hardware
    /// characteristics of the device. In particular, features such as touch slop
    /// (see [kTouchSlop]) can be defined in terms of roughly physical lengths so
    /// that the user can shift their finger by the same distance on a high-density
    /// display as on a low-resolution device.
    ///
    /// For similar reasons, pointer events are not affected by any transforms in
    /// the rendering layer. This means that deltas may need to be scaled before
    /// being applied to movement within the rendering. For example, if a scrolling
    /// list is shown scaled by 2x, the pointer deltas will have to be scaled by the
    /// inverse amount if the list is to appear to scroll with the user's finger.
    ///
    /// See also:
    ///
    ///  * [Window.devicePixelRatio], which defines the device's current resolution.
    /// </Summary>
    public interface IPointerEvent
    {
        FlutterSDK.Gestures.Events.PointerEvent Transformed(Matrix4 transform);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        string ToStringFull();
        Offset TransformPosition(Matrix4 transform, FlutterBinding.UI.Offset position);
        Offset TransformDeltaViaPositions(FlutterBinding.UI.Offset untransformedEndPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset transformedEndPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset untransformedDelta = default(FlutterBinding.UI.Offset), Matrix4 transform = default(Matrix4));
        Matrix4 RemovePerspectiveTransform(Matrix4 transform);
        TimeSpan TimeStamp { get; }
        int Pointer { get; }
        PointerDeviceKind Kind { get; }
        int Device { get; }
        FlutterBinding.UI.Offset Position { get; }
        FlutterBinding.UI.Offset LocalPosition { get; }
        FlutterBinding.UI.Offset Delta { get; }
        FlutterBinding.UI.Offset LocalDelta { get; }
        int Buttons { get; }
        bool Down { get; }
        bool Obscured { get; }
        double Pressure { get; }
        double PressureMin { get; }
        double PressureMax { get; }
        double Distance { get; }
        double DistanceMax { get; }
        double Size { get; }
        double RadiusMajor { get; }
        double RadiusMinor { get; }
        double RadiusMin { get; }
        double RadiusMax { get; }
        double Orientation { get; }
        double Tilt { get; }
        int PlatformData { get; }
        bool Synthesized { get; }
        Matrix4 Transform { get; }
        FlutterSDK.Gestures.Events.PointerEvent Original { get; }
        double DistanceMin { get; }
    }


    /// <Summary>
    /// An event that corresponds to a discrete pointer signal.
    ///
    /// Pointer signals are events that originate from the pointer but don't change
    /// the state of the pointer itself, and are discrete rather than needing to be
    /// interpreted in the context of a series of events.
    /// </Summary>
    public interface IPointerSignalEvent
    {
    }


    /// <Summary>
    /// Base class for touch, stylus, or mouse events.
    ///
    /// Pointer events operate in the coordinate space of the screen, scaled to
    /// logical pixels. Logical pixels approximate a grid with about 38 pixels per
    /// centimeter, or 96 pixels per inch.
    ///
    /// This allows gestures to be recognized independent of the precise hardware
    /// characteristics of the device. In particular, features such as touch slop
    /// (see [kTouchSlop]) can be defined in terms of roughly physical lengths so
    /// that the user can shift their finger by the same distance on a high-density
    /// display as on a low-resolution device.
    ///
    /// For similar reasons, pointer events are not affected by any transforms in
    /// the rendering layer. This means that deltas may need to be scaled before
    /// being applied to movement within the rendering. For example, if a scrolling
    /// list is shown scaled by 2x, the pointer deltas will have to be scaled by the
    /// inverse amount if the list is to appear to scroll with the user's finger.
    ///
    /// See also:
    ///
    ///  * [Window.devicePixelRatio], which defines the device's current resolution.
    /// </Summary>
    public class PointerEvent : IDiagnosticable
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public PointerEvent(TimeSpan timeStamp = default(TimeSpan), int pointer = 0, PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset), int buttons = 0, bool down = false, bool obscured = false, double pressure = 1.0, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, int platformData = 0, bool synthesized = false, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerEvent original = default(FlutterSDK.Gestures.Events.PointerEvent))
        : base()
        {
            this.TimeStamp = timeStamp;
            this.Pointer = pointer;
            this.Kind = kind;
            this.Device = device;
            this.Position = position;
            this.Delta = delta;
            this.Buttons = buttons;
            this.Down = down;
            this.Obscured = obscured;
            this.Pressure = pressure;
            this.PressureMin = pressureMin;
            this.PressureMax = pressureMax;
            this.Distance = distance;
            this.DistanceMax = distanceMax;
            this.Size = size;
            this.RadiusMajor = radiusMajor;
            this.RadiusMinor = radiusMinor;
            this.RadiusMin = radiusMin;
            this.RadiusMax = radiusMax;
            this.Orientation = orientation;
            this.Tilt = tilt;
            this.PlatformData = platformData;
            this.Synthesized = synthesized;
            this.Transform = transform;
            this.Original = original;
        }
        /// <Summary>
        /// Time of event dispatch, relative to an arbitrary timeline.
        /// </Summary>
        public virtual TimeSpan TimeStamp { get; set; }
        /// <Summary>
        /// Unique identifier for the pointer, not reused. Changes for each new
        /// pointer down event.
        /// </Summary>
        public virtual int Pointer { get; set; }
        /// <Summary>
        /// The kind of input device for which the event was generated.
        /// </Summary>
        public virtual PointerDeviceKind Kind { get; set; }
        /// <Summary>
        /// Unique identifier for the pointing device, reused across interactions.
        /// </Summary>
        public virtual int Device { get; set; }
        /// <Summary>
        /// Coordinate of the position of the pointer, in logical pixels in the global
        /// coordinate space.
        ///
        /// See also:
        ///
        ///  * [localPosition], which is the [position] transformed into the local
        ///    coordinate system of the event receiver.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Position { get; set; }
        /// <Summary>
        /// The [position] transformed into the event receiver's local coordinate
        /// system according to [transform].
        ///
        /// If this event has not been transformed, [position] is returned as-is.
        /// See also:
        ///
        ///  * [position], which is the position in the global coordinate system of
        ///    the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
        /// <Summary>
        /// Distance in logical pixels that the pointer moved since the last
        /// [PointerMoveEvent] or [PointerHoverEvent].
        ///
        /// This value is always 0.0 for down, up, and cancel events.
        ///
        /// See also:
        ///
        ///  * [localDelta], which is the [delta] transformed into the local
        ///    coordinate space of the event receiver.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Delta { get; set; }
        /// <Summary>
        /// The [delta] transformed into the event receiver's local coordinate
        /// system according to [transform].
        ///
        /// If this event has not been transformed, [delta] is returned as-is.
        ///
        /// See also:
        ///
        ///  * [delta], which is the distance the pointer moved in the global
        ///    coordinate system of the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalDelta { get; set; }
        /// <Summary>
        /// Bit field using the *Button constants such as [kPrimaryMouseButton],
        /// [kSecondaryStylusButton], etc.
        ///
        /// For example, if this has the value 6 and the
        /// [kind] is [PointerDeviceKind.invertedStylus], then this indicates an
        /// upside-down stylus with both its primary and secondary buttons pressed.
        /// </Summary>
        public virtual int Buttons { get; set; }
        /// <Summary>
        /// Set if the pointer is currently down.
        ///
        /// For touch and stylus pointers, this means the object (finger, pen) is in
        /// contact with the input surface. For mice, it means a button is pressed.
        /// </Summary>
        public virtual bool Down { get; set; }
        /// <Summary>
        /// Set if an application from a different security domain is in any way
        /// obscuring this application's window.
        ///
        /// This is not currently implemented.
        /// </Summary>
        public virtual bool Obscured { get; set; }
        /// <Summary>
        /// The pressure of the touch.
        ///
        /// This value is a number ranging from 0.0, indicating a touch with no
        /// discernible pressure, to 1.0, indicating a touch with "normal" pressure,
        /// and possibly beyond, indicating a stronger touch. For devices that do not
        /// detect pressure (e.g. mice), returns 1.0.
        /// </Summary>
        public virtual double Pressure { get; set; }
        /// <Summary>
        /// The minimum value that [pressure] can return for this pointer.
        ///
        /// For devices that do not detect pressure (e.g. mice), returns 1.0.
        /// This will always be a number less than or equal to 1.0.
        /// </Summary>
        public virtual double PressureMin { get; set; }
        /// <Summary>
        /// The maximum value that [pressure] can return for this pointer.
        ///
        /// For devices that do not detect pressure (e.g. mice), returns 1.0.
        /// This will always be a greater than or equal to 1.0.
        /// </Summary>
        public virtual double PressureMax { get; set; }
        /// <Summary>
        /// The distance of the detected object from the input surface.
        ///
        /// For instance, this value could be the distance of a stylus or finger
        /// from a touch screen, in arbitrary units on an arbitrary (not necessarily
        /// linear) scale. If the pointer is down, this is 0.0 by definition.
        /// </Summary>
        public virtual double Distance { get; set; }
        /// <Summary>
        /// The maximum value that [distance] can return for this pointer.
        ///
        /// If this input device cannot detect "hover touch" input events,
        /// then this will be 0.0.
        /// </Summary>
        public virtual double DistanceMax { get; set; }
        /// <Summary>
        /// The area of the screen being pressed.
        ///
        /// This value is scaled to a range between 0 and 1. It can be used to
        /// determine fat touch events. This value is only set on Android and is
        /// a device specific approximation within the range of detectable values.
        /// So, for example, the value of 0.1 could mean a touch with the tip of
        /// the finger, 0.2 a touch with full finger, and 0.3 the full palm.
        ///
        /// Because this value uses device-specific range and is uncalibrated,
        /// it is of limited use and is primarily retained in order to be able
        /// to reconstruct original pointer events for [AndroidView].
        /// </Summary>
        public virtual double Size { get; set; }
        /// <Summary>
        /// The radius of the contact ellipse along the major axis, in logical pixels.
        /// </Summary>
        public virtual double RadiusMajor { get; set; }
        /// <Summary>
        /// The radius of the contact ellipse along the minor axis, in logical pixels.
        /// </Summary>
        public virtual double RadiusMinor { get; set; }
        /// <Summary>
        /// The minimum value that could be reported for [radiusMajor] and [radiusMinor]
        /// for this pointer, in logical pixels.
        /// </Summary>
        public virtual double RadiusMin { get; set; }
        /// <Summary>
        /// The maximum value that could be reported for [radiusMajor] and [radiusMinor]
        /// for this pointer, in logical pixels.
        /// </Summary>
        public virtual double RadiusMax { get; set; }
        /// <Summary>
        /// The orientation angle of the detected object, in radians.
        ///
        /// For [PointerDeviceKind.touch] events:
        ///
        /// The angle of the contact ellipse, in radians in the range:
        ///
        ///    -pi/2 < orientation <= pi/2
        ///
        /// ...giving the angle of the major axis of the ellipse with the y-axis
        /// (negative angles indicating an orientation along the top-left /
        /// bottom-right diagonal, positive angles indicating an orientation along the
        /// top-right / bottom-left diagonal, and zero indicating an orientation
        /// parallel with the y-axis).
        ///
        /// For [PointerDeviceKind.stylus] and [PointerDeviceKind.invertedStylus] events:
        ///
        /// The angle of the stylus, in radians in the range:
        ///
        ///    -pi < orientation <= pi
        ///
        /// ...giving the angle of the axis of the stylus projected onto the input
        /// surface, relative to the positive y-axis of that surface (thus 0.0
        /// indicates the stylus, if projected onto that surface, would go from the
        /// contact point vertically up in the positive y-axis direction, pi would
        /// indicate that the stylus would go down in the negative y-axis direction;
        /// pi/4 would indicate that the stylus goes up and to the right, -pi/2 would
        /// indicate that the stylus goes to the left, etc).
        /// </Summary>
        public virtual double Orientation { get; set; }
        /// <Summary>
        /// The tilt angle of the detected object, in radians.
        ///
        /// For [PointerDeviceKind.stylus] and [PointerDeviceKind.invertedStylus] events:
        ///
        /// The angle of the stylus, in radians in the range:
        ///
        ///    0 <= tilt <= pi/2
        ///
        /// ...giving the angle of the axis of the stylus, relative to the axis
        /// perpendicular to the input surface (thus 0.0 indicates the stylus is
        /// orthogonal to the plane of the input surface, while pi/2 indicates that
        /// the stylus is flat on that surface).
        /// </Summary>
        public virtual double Tilt { get; set; }
        /// <Summary>
        /// Opaque platform-specific data associated with the event.
        /// </Summary>
        public virtual int PlatformData { get; set; }
        /// <Summary>
        /// Set if the event was synthesized by Flutter.
        ///
        /// We occasionally synthesize PointerEvents that aren't exact translations
        /// of [PointerData] from the engine to cover small cross-OS discrepancies
        /// in pointer behaviors.
        ///
        /// For instance, on end events, Android always drops any location changes
        /// that happened between its reporting intervals when emitting the end events.
        ///
        /// On iOS, minor incorrect location changes from the previous move events
        /// can be reported on end events. We synthesize a [PointerEvent] to cover
        /// the difference between the 2 events in that case.
        /// </Summary>
        public virtual bool Synthesized { get; set; }
        /// <Summary>
        /// The transformation used to transform this event from the global coordinate
        /// space into the coordinate space of the event receiver.
        ///
        /// This value affects what is returned by [localPosition] and [localDelta].
        /// If this value is null, it is treated as the identity transformation.
        ///
        /// Unlike a paint transform, this transform usually does not contain any
        /// "perspective" components, meaning that the third row and the third column
        /// of the matrix should be equal to "0, 0, 1, 0". This ensures that
        /// [localPosition] describes the point in the local coordinate system of the
        /// event receiver at which the user is actually touching the screen.
        ///
        /// See also:
        ///
        ///  * [transformed], which transforms this event into a different coordinate
        ///    space.
        /// </Summary>
        public virtual Matrix4 Transform { get; set; }
        /// <Summary>
        /// The original un-transformed [PointerEvent] before any [transform]s were
        /// applied.
        ///
        /// If [transform] is null or the identity transformation this may be null.
        ///
        /// When multiple event receivers in different coordinate spaces receive an
        /// event, they all receive the event transformed to their local coordinate
        /// space. The [original] property can be used to determine if all those
        /// transformed events actually originated from the same pointer interaction.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Events.PointerEvent Original { get; set; }
        public virtual double DistanceMin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Transforms the event from the global coordinate space into the coordinate
        /// space of an event receiver.
        ///
        /// The coordinate space of the event receiver is described by `transform`. A
        /// null value for `transform` is treated as the identity transformation.
        ///
        /// The method may return the same object instance if for example the
        /// transformation has no effect on the event.
        ///
        /// Transforms are not commutative. If this method is called on a
        /// [PointerEvent] that has a non-null [transform] value, that value will be
        /// overridden by the provided `transform`.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Events.PointerEvent Transformed(Matrix4 transform)
        {
            return default(PointerEvent);
        }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Offset>("position", Position));
            properties.Add(new DiagnosticsProperty<Offset>("localPosition", LocalPosition, defaultValue: Position, level: DiagnosticLevel.Debug));
            properties.Add(new DiagnosticsProperty<Offset>("delta", Delta, defaultValue: Dart.UI.UiDefaultClass.Offset.Zero, level: DiagnosticLevel.Debug));
            properties.Add(new DiagnosticsProperty<Offset>("localDelta", LocalDelta, defaultValue: Delta, level: DiagnosticLevel.Debug));
            properties.Add(new DiagnosticsProperty<TimeSpan>("timeStamp", TimeStamp, defaultValue: Dart.CoreDefaultClass.Duration.Zero, level: DiagnosticLevel.Debug));
            properties.Add(new IntProperty("pointer", Pointer, level: DiagnosticLevel.Debug));
            properties.Add(new EnumProperty<PointerDeviceKind>("kind", Kind, level: DiagnosticLevel.Debug));
            properties.Add(new IntProperty("device", Device, defaultValue: 0, level: DiagnosticLevel.Debug));
            properties.Add(new IntProperty("buttons", Buttons, defaultValue: 0, level: DiagnosticLevel.Debug));
            properties.Add(new DiagnosticsProperty<bool>("down", Down, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("pressure", Pressure, defaultValue: 1.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("pressureMin", PressureMin, defaultValue: 1.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("pressureMax", PressureMax, defaultValue: 1.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("distance", Distance, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("distanceMin", DistanceMin, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("distanceMax", DistanceMax, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("size", Size, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("radiusMajor", RadiusMajor, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("radiusMinor", RadiusMinor, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("radiusMin", RadiusMin, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("radiusMax", RadiusMax, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("orientation", Orientation, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new DoubleProperty("tilt", Tilt, defaultValue: 0.0, level: DiagnosticLevel.Debug));
            properties.Add(new IntProperty("platformData", PlatformData, defaultValue: 0, level: DiagnosticLevel.Debug));
            properties.Add(new FlagProperty("obscured", value: Obscured, ifTrue: "obscured", level: DiagnosticLevel.Debug));
            properties.Add(new FlagProperty("synthesized", value: Synthesized, ifTrue: "synthesized", level: DiagnosticLevel.Debug));
        }




        /// <Summary>
        /// Returns a complete textual description of this event.
        /// </Summary>
        public virtual string ToStringFull()
        {
            return ToString(minLevel: DiagnosticLevel.Fine);
        }




        /// <Summary>
        /// Returns the transformation of `position` into the coordinate system
        /// described by `transform`.
        ///
        /// The z-value of `position` is assumed to be 0.0. If `transform` is null,
        /// `position` is returned as-is.
        /// </Summary>
        public virtual Offset TransformPosition(Matrix4 transform, FlutterBinding.UI.Offset position)
        {
            if (transform == null)
            {
                return position;
            }

            Vector3 position3 = Vector3(position.Dx, position.Dy, 0.0);
            Vector3 transformed3 = transform.PerspectiveTransform(position3);
            return new Offset(transformed3.x, transformed3.y);
        }




        /// <Summary>
        /// Transforms `untransformedDelta` into the coordinate system described by
        /// `transform`.
        ///
        /// It uses the provided `untransformedEndPosition` and
        /// `transformedEndPosition` of the provided delta to increase accuracy.
        ///
        /// If `transform` is null, `untransformedDelta` is returned.
        /// </Summary>
        public virtual Offset TransformDeltaViaPositions(FlutterBinding.UI.Offset untransformedEndPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset transformedEndPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset untransformedDelta = default(FlutterBinding.UI.Offset), Matrix4 transform = default(Matrix4))
        {
            if (transform == null)
            {
                return untransformedDelta;
            }

            transformedEndPosition = (transformedEndPosition == null ? TransformPosition(transform, untransformedEndPosition) : transformedEndPosition);
            Offset transformedStartPosition = TransformPosition(transform, untransformedEndPosition - untransformedDelta);
            return transformedEndPosition - transformedStartPosition;
        }




        /// <Summary>
        /// Removes the "perspective" component from `transform`.
        ///
        /// When applying the resulting transform matrix to a point with a
        /// z-coordinate of zero (which is generally assumed for all points
        /// represented by an [Offset]), the other coordinates will get transformed as
        /// before, but the new z-coordinate is going to be zero again. This is
        /// achieved by setting the third column and third row of the matrix to
        /// "0, 0, 1, 0".
        /// </Summary>
        public virtual Matrix4 RemovePerspectiveTransform(Matrix4 transform)
        {
            Vector4 vector = Vector4(0, 0, 1, 0);
            return transform.Clone();
            transform.Clone().SetColumn(2, vector);
            transform.Clone().SetRow(2, vector);
        }



    }


    /// <Summary>
    /// The device has started tracking the pointer.
    ///
    /// For example, the pointer might be hovering above the device, having not yet
    /// made contact with the surface of the device.
    /// </Summary>
    public class PointerAddedEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer added event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerAddedEvent(TimeSpan timeStamp = default(TimeSpan), PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), bool obscured = false, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerAddedEvent original = default(FlutterSDK.Gestures.Events.PointerAddedEvent))
        : base(timeStamp: timeStamp, kind: kind, device: device, position: position, localPosition: localPosition, obscured: obscured, pressure: 0.0, pressureMin: pressureMin, pressureMax: pressureMax, distance: distance, distanceMax: distanceMax, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerAddedEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            return new PointerAddedEvent(timeStamp: TimeStamp, kind: Kind, device: Device, position: Position, localPosition: EventsDefaultClass.PointerEvent.TransformPosition(transform, Position), obscured: Obscured, pressureMin: PressureMin, pressureMax: PressureMax, distance: Distance, distanceMax: DistanceMax, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, transform: transform, original: Original as PointerAddedEvent ?? this);
        }



    }


    /// <Summary>
    /// The device is no longer tracking the pointer.
    ///
    /// For example, the pointer might have drifted out of the device's hover
    /// detection range or might have been disconnected from the system entirely.
    /// </Summary>
    public class PointerRemovedEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer removed event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerRemovedEvent(TimeSpan timeStamp = default(TimeSpan), PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), bool obscured = false, double pressureMin = 1.0, double pressureMax = 1.0, double distanceMax = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerRemovedEvent original = default(FlutterSDK.Gestures.Events.PointerRemovedEvent))
        : base(timeStamp: timeStamp, kind: kind, device: device, position: position, localPosition: localPosition, obscured: obscured, pressure: 0.0, pressureMin: pressureMin, pressureMax: pressureMax, distanceMax: distanceMax, radiusMin: radiusMin, radiusMax: radiusMax, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerRemovedEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            return new PointerRemovedEvent(timeStamp: TimeStamp, kind: Kind, device: Device, position: Position, localPosition: EventsDefaultClass.PointerEvent.TransformPosition(transform, Position), obscured: Obscured, pressureMin: PressureMin, pressureMax: PressureMax, distanceMax: DistanceMax, radiusMin: RadiusMin, radiusMax: RadiusMax, transform: transform, original: Original as PointerRemovedEvent ?? this);
        }



    }


    /// <Summary>
    /// The pointer has moved with respect to the device while the pointer is not
    /// in contact with the device.
    ///
    /// See also:
    ///
    ///  * [PointerEnterEvent], which reports when the pointer has entered an
    ///    object.
    ///  * [PointerExitEvent], which reports when the pointer has left an object.
    ///  * [PointerMoveEvent], which reports movement while the pointer is in
    ///    contact with the device.
    /// </Summary>
    public class PointerHoverEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer hover event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerHoverEvent(TimeSpan timeStamp = default(TimeSpan), PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset), int buttons = 0, bool obscured = false, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, bool synthesized = false, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerHoverEvent original = default(FlutterSDK.Gestures.Events.PointerHoverEvent))
        : base(timeStamp: timeStamp, kind: kind, device: device, position: position, localPosition: localPosition, delta: delta, localDelta: localDelta, buttons: buttons, down: false, obscured: obscured, pressure: 0.0, pressureMin: pressureMin, pressureMax: pressureMax, distance: distance, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, synthesized: synthesized, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerHoverEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            Offset transformedPosition = EventsDefaultClass.PointerEvent.TransformPosition(transform, Position);
            return new PointerHoverEvent(timeStamp: TimeStamp, kind: Kind, device: Device, position: Position, localPosition: transformedPosition, delta: Delta, localDelta: EventsDefaultClass.PointerEvent.TransformDeltaViaPositions(transform: transform, untransformedDelta: Delta, untransformedEndPosition: Position, transformedEndPosition: transformedPosition), buttons: Buttons, obscured: Obscured, pressureMin: PressureMin, pressureMax: PressureMax, distance: Distance, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, synthesized: Synthesized, transform: transform, original: Original as PointerHoverEvent ?? this);
        }



    }


    /// <Summary>
    /// The pointer has moved with respect to the device while the pointer is or is
    /// not in contact with the device, and it has entered a target object.
    ///
    /// See also:
    ///
    ///  * [PointerHoverEvent], which reports when the pointer has moved while
    ///    within an object.
    ///  * [PointerExitEvent], which reports when the pointer has left an object.
    ///  * [PointerMoveEvent], which reports movement while the pointer is in
    ///    contact with the device.
    /// </Summary>
    public class PointerEnterEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer enter event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerEnterEvent(TimeSpan timeStamp = default(TimeSpan), PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset), int buttons = 0, bool obscured = false, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, bool down = false, bool synthesized = false, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerEnterEvent original = default(FlutterSDK.Gestures.Events.PointerEnterEvent))
        : base(timeStamp: timeStamp, kind: kind, device: device, position: position, localPosition: localPosition, delta: delta, localDelta: localDelta, buttons: buttons, down: down, obscured: obscured, pressure: 0.0, pressureMin: pressureMin, pressureMax: pressureMax, distance: distance, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, synthesized: synthesized, transform: transform, original: original)
        {

        }
        /// <Summary>
        /// Creates an enter event from a [PointerHoverEvent].
        ///
        /// Deprecated. Please use [PointerEnterEvent.fromMouseEvent] instead.
        /// </Summary>
        public static PointerEnterEvent FromHoverEvent(FlutterSDK.Gestures.Events.PointerHoverEvent @event)
        {
            var instance = new PointerEnterEvent();
        }
        /// <Summary>
        /// Creates an enter event from a [PointerEvent].
        ///
        /// This is used by the [MouseTracker] to synthesize enter events.
        /// </Summary>
        public static PointerEnterEvent FromMouseEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            var instance = new PointerEnterEvent();
        }

        public new FlutterSDK.Gestures.Events.PointerEnterEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            Offset transformedPosition = EventsDefaultClass.PointerEvent.TransformPosition(transform, Position);
            return new PointerEnterEvent(timeStamp: TimeStamp, kind: Kind, device: Device, position: Position, localPosition: transformedPosition, delta: Delta, localDelta: EventsDefaultClass.PointerEvent.TransformDeltaViaPositions(transform: transform, untransformedDelta: Delta, untransformedEndPosition: Position, transformedEndPosition: transformedPosition), buttons: Buttons, obscured: Obscured, pressureMin: PressureMin, pressureMax: PressureMax, distance: Distance, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, down: Down, synthesized: Synthesized, transform: transform, original: Original as PointerEnterEvent ?? this);
        }



    }


    /// <Summary>
    /// The pointer has moved with respect to the device while the pointer is or is
    /// not in contact with the device, and entered a target object.
    ///
    /// See also:
    ///
    ///  * [PointerHoverEvent], which reports when the pointer has moved while
    ///    within an object.
    ///  * [PointerEnterEvent], which reports when the pointer has entered an object.
    ///  * [PointerMoveEvent], which reports movement while the pointer is in
    ///    contact with the device.
    /// </Summary>
    public class PointerExitEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer exit event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerExitEvent(TimeSpan timeStamp = default(TimeSpan), PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset), int buttons = 0, bool obscured = false, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, bool down = false, bool synthesized = false, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerExitEvent original = default(FlutterSDK.Gestures.Events.PointerExitEvent))
        : base(timeStamp: timeStamp, kind: kind, device: device, position: position, localPosition: localPosition, delta: delta, localDelta: localDelta, buttons: buttons, down: down, obscured: obscured, pressure: 0.0, pressureMin: pressureMin, pressureMax: pressureMax, distance: distance, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, synthesized: synthesized, transform: transform, original: original)
        {

        }
        /// <Summary>
        /// Creates an exit event from a [PointerHoverEvent].
        ///
        /// Deprecated. Please use [PointerExitEvent.fromMouseEvent] instead.
        /// </Summary>
        public static PointerExitEvent FromHoverEvent(FlutterSDK.Gestures.Events.PointerHoverEvent @event)
        {
            var instance = new PointerExitEvent();
        }
        /// <Summary>
        /// Creates an exit event from a [PointerEvent].
        ///
        /// This is used by the [MouseTracker] to synthesize exit events.
        /// </Summary>
        public static PointerExitEvent FromMouseEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            var instance = new PointerExitEvent();
        }

        public new FlutterSDK.Gestures.Events.PointerExitEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            Offset transformedPosition = EventsDefaultClass.PointerEvent.TransformPosition(transform, Position);
            return new PointerExitEvent(timeStamp: TimeStamp, kind: Kind, device: Device, position: Position, localPosition: transformedPosition, delta: Delta, localDelta: EventsDefaultClass.PointerEvent.TransformDeltaViaPositions(transform: transform, untransformedDelta: Delta, untransformedEndPosition: Position, transformedEndPosition: transformedPosition), buttons: Buttons, obscured: Obscured, pressureMin: PressureMin, pressureMax: PressureMax, distance: Distance, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, down: Down, synthesized: Synthesized, transform: transform, original: Original as PointerExitEvent ?? this);
        }



    }


    /// <Summary>
    /// The pointer has made contact with the device.
    /// </Summary>
    public class PointerDownEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer down event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerDownEvent(TimeSpan timeStamp = default(TimeSpan), int pointer = 0, PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), int buttons = default(int), bool obscured = false, double pressure = 1.0, double pressureMin = 1.0, double pressureMax = 1.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerDownEvent original = default(FlutterSDK.Gestures.Events.PointerDownEvent))
        : base(timeStamp: timeStamp, pointer: pointer, kind: kind, device: device, position: position, localPosition: localPosition, buttons: buttons, down: true, obscured: obscured, pressure: pressure, pressureMin: pressureMin, pressureMax: pressureMax, distance: 0.0, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerDownEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            return new PointerDownEvent(timeStamp: TimeStamp, pointer: Pointer, kind: Kind, device: Device, position: Position, localPosition: EventsDefaultClass.PointerEvent.TransformPosition(transform, Position), buttons: Buttons, obscured: Obscured, pressure: Pressure, pressureMin: PressureMin, pressureMax: PressureMax, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, transform: transform, original: Original as PointerDownEvent ?? this);
        }



    }


    /// <Summary>
    /// The pointer has moved with respect to the device while the pointer is in
    /// contact with the device.
    ///
    /// See also:
    ///
    ///  * [PointerHoverEvent], which reports movement while the pointer is not in
    ///    contact with the device.
    /// </Summary>
    public class PointerMoveEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer move event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerMoveEvent(TimeSpan timeStamp = default(TimeSpan), int pointer = 0, PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset), int buttons = default(int), bool obscured = false, double pressure = 1.0, double pressureMin = 1.0, double pressureMax = 1.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, int platformData = 0, bool synthesized = false, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerMoveEvent original = default(FlutterSDK.Gestures.Events.PointerMoveEvent))
        : base(timeStamp: timeStamp, pointer: pointer, kind: kind, device: device, position: position, localPosition: localPosition, delta: delta, localDelta: localDelta, buttons: buttons, down: true, obscured: obscured, pressure: pressure, pressureMin: pressureMin, pressureMax: pressureMax, distance: 0.0, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, platformData: platformData, synthesized: synthesized, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerMoveEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            Offset transformedPosition = EventsDefaultClass.PointerEvent.TransformPosition(transform, Position);
            return new PointerMoveEvent(timeStamp: TimeStamp, pointer: Pointer, kind: Kind, device: Device, position: Position, localPosition: transformedPosition, delta: Delta, localDelta: EventsDefaultClass.PointerEvent.TransformDeltaViaPositions(transform: transform, untransformedDelta: Delta, untransformedEndPosition: Position, transformedEndPosition: transformedPosition), buttons: Buttons, obscured: Obscured, pressure: Pressure, pressureMin: PressureMin, pressureMax: PressureMax, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, platformData: PlatformData, synthesized: Synthesized, transform: transform, original: Original as PointerMoveEvent ?? this);
        }



    }


    /// <Summary>
    /// The pointer has stopped making contact with the device.
    /// </Summary>
    public class PointerUpEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer up event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerUpEvent(TimeSpan timeStamp = default(TimeSpan), int pointer = 0, PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), int buttons = 0, bool obscured = false, double pressure = 0.0, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerUpEvent original = default(FlutterSDK.Gestures.Events.PointerUpEvent))
        : base(timeStamp: timeStamp, pointer: pointer, kind: kind, device: device, position: position, localPosition: localPosition, buttons: buttons, down: false, obscured: obscured, pressure: pressure, pressureMin: pressureMin, pressureMax: pressureMax, distance: distance, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerUpEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            return new PointerUpEvent(timeStamp: TimeStamp, pointer: Pointer, kind: Kind, device: Device, position: Position, localPosition: EventsDefaultClass.PointerEvent.TransformPosition(transform, Position), buttons: Buttons, obscured: Obscured, pressure: Pressure, pressureMin: PressureMin, pressureMax: PressureMax, distance: Distance, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, transform: transform, original: Original as PointerUpEvent ?? this);
        }



    }


    /// <Summary>
    /// An event that corresponds to a discrete pointer signal.
    ///
    /// Pointer signals are events that originate from the pointer but don't change
    /// the state of the pointer itself, and are discrete rather than needing to be
    /// interpreted in the context of a series of events.
    /// </Summary>
    public class PointerSignalEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public PointerSignalEvent(TimeSpan timeStamp = default(TimeSpan), int pointer = 0, PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerSignalEvent original = default(FlutterSDK.Gestures.Events.PointerSignalEvent))
        : base(timeStamp: timeStamp, pointer: pointer, kind: kind, device: device, position: position, localPosition: localPosition, transform: transform, original: original)
        {

        }
    }


    /// <Summary>
    /// The pointer issued a scroll event.
    ///
    /// Scrolling the scroll wheel on a mouse is an example of an event that
    /// would create a [PointerScrollEvent].
    /// </Summary>
    public class PointerScrollEvent : FlutterSDK.Gestures.Events.PointerSignalEvent
    {
        /// <Summary>
        /// Creates a pointer scroll event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerScrollEvent(TimeSpan timeStamp = default(TimeSpan), PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset scrollDelta = default(FlutterBinding.UI.Offset), Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerScrollEvent original = default(FlutterSDK.Gestures.Events.PointerScrollEvent))
        : base(timeStamp: timeStamp, kind: kind, device: device, position: position, localPosition: localPosition, transform: transform, original: original)
        {
            this.ScrollDelta = scrollDelta;
        }
        /// <Summary>
        /// The amount to scroll, in logical pixels.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset ScrollDelta { get; set; }

        public new FlutterSDK.Gestures.Events.PointerScrollEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            return new PointerScrollEvent(timeStamp: TimeStamp, kind: Kind, device: Device, position: Position, localPosition: EventsDefaultClass.PointerEvent.TransformPosition(transform, Position), scrollDelta: ScrollDelta, transform: transform, original: Original as PointerScrollEvent ?? this);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Offset>("scrollDelta", ScrollDelta));
        }



    }


    /// <Summary>
    /// The input from the pointer is no longer directed towards this receiver.
    /// </Summary>
    public class PointerCancelEvent : FlutterSDK.Gestures.Events.PointerEvent
    {
        /// <Summary>
        /// Creates a pointer cancel event.
        ///
        /// All of the arguments must be non-null.
        /// </Summary>
        public PointerCancelEvent(TimeSpan timeStamp = default(TimeSpan), int pointer = 0, PointerDeviceKind kind = default(PointerDeviceKind), int device = 0, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), int buttons = 0, bool obscured = false, double pressureMin = 1.0, double pressureMax = 1.0, double distance = 0.0, double distanceMax = 0.0, double size = 0.0, double radiusMajor = 0.0, double radiusMinor = 0.0, double radiusMin = 0.0, double radiusMax = 0.0, double orientation = 0.0, double tilt = 0.0, Matrix4 transform = default(Matrix4), FlutterSDK.Gestures.Events.PointerCancelEvent original = default(FlutterSDK.Gestures.Events.PointerCancelEvent))
        : base(timeStamp: timeStamp, pointer: pointer, kind: kind, device: device, position: position, localPosition: localPosition, buttons: buttons, down: false, obscured: obscured, pressure: 0.0, pressureMin: pressureMin, pressureMax: pressureMax, distance: distance, distanceMax: distanceMax, size: size, radiusMajor: radiusMajor, radiusMinor: radiusMinor, radiusMin: radiusMin, radiusMax: radiusMax, orientation: orientation, tilt: tilt, transform: transform, original: original)
        {

        }

        public new FlutterSDK.Gestures.Events.PointerCancelEvent Transformed(Matrix4 transform)
        {
            if (transform == null || transform == this.Transform)
            {
                return this;
            }

            return new PointerCancelEvent(timeStamp: TimeStamp, pointer: Pointer, kind: Kind, device: Device, position: Position, localPosition: EventsDefaultClass.PointerEvent.TransformPosition(transform, Position), buttons: Buttons, obscured: Obscured, pressureMin: PressureMin, pressureMax: PressureMax, distance: Distance, distanceMax: DistanceMax, size: Size, radiusMajor: RadiusMajor, radiusMinor: RadiusMinor, radiusMin: RadiusMin, radiusMax: RadiusMax, orientation: Orientation, tilt: Tilt, transform: transform, original: Original as PointerCancelEvent ?? this);
        }



    }

}
