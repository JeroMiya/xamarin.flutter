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
namespace FlutterSDK.Gestures.Dragdetails
{
    /// <Summary>
    /// Signature for when a pointer has contacted the screen and might begin to
    /// move.
    ///
    /// The `details` object provides the position of the touch.
    ///
    /// See [DragGestureRecognizer.onDown].
    /// </Summary>
    public delegate void GestureDragDownCallback(FlutterSDK.Gestures.Dragdetails.DragDownDetails details);
    /// <Summary>
    /// Signature for when a pointer has contacted the screen and has begun to move.
    ///
    /// The `details` object provides the position of the touch when it first
    /// touched the surface.
    ///
    /// See [DragGestureRecognizer.onStart].
    /// </Summary>
    public delegate void GestureDragStartCallback(FlutterSDK.Gestures.Dragdetails.DragStartDetails details);
    /// <Summary>
    /// Signature for when a pointer that is in contact with the screen and moving
    /// has moved again.
    ///
    /// The `details` object provides the position of the touch and the distance it
    /// has traveled since the last update.
    ///
    /// See [DragGestureRecognizer.onUpdate].
    /// </Summary>
    public delegate void GestureDragUpdateCallback(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details);
    internal static class DragdetailsDefaultClass
    {
    }

    /// <Summary>
    /// Details object for callbacks that use [GestureDragDownCallback].
    ///
    /// See also:
    ///
    ///  * [DragGestureRecognizer.onDown], which uses [GestureDragDownCallback].
    ///  * [DragStartDetails], the details for [GestureDragStartCallback].
    ///  * [DragUpdateDetails], the details for [GestureDragUpdateCallback].
    ///  * [DragEndDetails], the details for [GestureDragEndCallback].
    /// </Summary>
    public class DragDownDetails
    {
        /// <Summary>
        /// Creates details for a [GestureDragDownCallback].
        ///
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public DragDownDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.GlobalPosition = globalPosition;
        }
        /// <Summary>
        /// The global position at which the pointer contacted the screen.
        ///
        /// Defaults to the origin if not specified in the constructor.
        ///
        /// See also:
        ///
        ///  * [localPosition], which is the [globalPosition] transformed to the
        ///    coordinate space of the event receiver.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position in the coordinate system of the event receiver at
        /// which the pointer contacted the screen.
        ///
        /// Defaults to [globalPosition] if not specified in the constructor.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }

    }


    /// <Summary>
    /// Details object for callbacks that use [GestureDragStartCallback].
    ///
    /// See also:
    ///
    ///  * [DragGestureRecognizer.onStart], which uses [GestureDragStartCallback].
    ///  * [DragDownDetails], the details for [GestureDragDownCallback].
    ///  * [DragUpdateDetails], the details for [GestureDragUpdateCallback].
    ///  * [DragEndDetails], the details for [GestureDragEndCallback].
    /// </Summary>
    public class DragStartDetails
    {
        /// <Summary>
        /// Creates details for a [GestureDragStartCallback].
        ///
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public DragStartDetails(TimeSpan sourceTimeStamp = default(TimeSpan), FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.SourceTimeStamp = sourceTimeStamp;
            this.GlobalPosition = globalPosition;
        }
        /// <Summary>
        /// Recorded timestamp of the source pointer event that triggered the drag
        /// event.
        ///
        /// Could be null if triggered from proxied events such as accessibility.
        /// </Summary>
        public virtual TimeSpan SourceTimeStamp { get; set; }
        /// <Summary>
        /// The global position at which the pointer contacted the screen.
        ///
        /// Defaults to the origin if not specified in the constructor.
        ///
        /// See also:
        ///
        ///  * [localPosition], which is the [globalPosition] transformed to the
        ///    coordinate space of the event receiver.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position in the coordinate system of the event receiver at
        /// which the pointer contacted the screen.
        ///
        /// Defaults to [globalPosition] if not specified in the constructor.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }

    }


    /// <Summary>
    /// Details object for callbacks that use [GestureDragUpdateCallback].
    ///
    /// See also:
    ///
    ///  * [DragGestureRecognizer.onUpdate], which uses [GestureDragUpdateCallback].
    ///  * [DragDownDetails], the details for [GestureDragDownCallback].
    ///  * [DragStartDetails], the details for [GestureDragStartCallback].
    ///  * [DragEndDetails], the details for [GestureDragEndCallback].
    /// </Summary>
    public class DragUpdateDetails
    {
        /// <Summary>
        /// Creates details for a [DragUpdateDetails].
        ///
        /// The [delta] argument must not be null.
        ///
        /// If [primaryDelta] is non-null, then its value must match one of the
        /// coordinates of [delta] and the other coordinate must be zero.
        ///
        /// The [globalPosition] argument must be provided and must not be null.
        /// </Summary>
        public DragUpdateDetails(TimeSpan sourceTimeStamp = default(TimeSpan), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), double primaryDelta = default(double), FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.SourceTimeStamp = sourceTimeStamp;
            this.Delta = delta;
            this.PrimaryDelta = primaryDelta;
            this.GlobalPosition = globalPosition;
        }
        /// <Summary>
        /// Recorded timestamp of the source pointer event that triggered the drag
        /// event.
        ///
        /// Could be null if triggered from proxied events such as accessibility.
        /// </Summary>
        public virtual TimeSpan SourceTimeStamp { get; set; }
        /// <Summary>
        /// The amount the pointer has moved in the coordinate space of the event
        /// receiver since the previous update.
        ///
        /// If the [GestureDragUpdateCallback] is for a one-dimensional drag (e.g.,
        /// a horizontal or vertical drag), then this offset contains only the delta
        /// in that direction (i.e., the coordinate in the other direction is zero).
        ///
        /// Defaults to zero if not specified in the constructor.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Delta { get; set; }
        /// <Summary>
        /// The amount the pointer has moved along the primary axis in the coordinate
        /// space of the event receiver since the previous
        /// update.
        ///
        /// If the [GestureDragUpdateCallback] is for a one-dimensional drag (e.g.,
        /// a horizontal or vertical drag), then this value contains the component of
        /// [delta] along the primary axis (e.g., horizontal or vertical,
        /// respectively). Otherwise, if the [GestureDragUpdateCallback] is for a
        /// two-dimensional drag (e.g., a pan), then this value is null.
        ///
        /// Defaults to null if not specified in the constructor.
        /// </Summary>
        public virtual double PrimaryDelta { get; set; }
        /// <Summary>
        /// The pointer's global position when it triggered this update.
        ///
        /// See also:
        ///
        ///  * [localPosition], which is the [globalPosition] transformed to the
        ///    coordinate space of the event receiver.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position in the coordinate system of the event receiver at
        /// which the pointer contacted the screen.
        ///
        /// Defaults to [globalPosition] if not specified in the constructor.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }

    }


    /// <Summary>
    /// Details object for callbacks that use [GestureDragEndCallback].
    ///
    /// See also:
    ///
    ///  * [DragGestureRecognizer.onEnd], which uses [GestureDragEndCallback].
    ///  * [DragDownDetails], the details for [GestureDragDownCallback].
    ///  * [DragStartDetails], the details for [GestureDragStartCallback].
    ///  * [DragUpdateDetails], the details for [GestureDragUpdateCallback].
    /// </Summary>
    public class DragEndDetails
    {
        /// <Summary>
        /// Creates details for a [GestureDragEndCallback].
        ///
        /// The [velocity] argument must not be null.
        /// </Summary>
        public DragEndDetails(FlutterSDK.Gestures.Velocitytracker.Velocity velocity = default(FlutterSDK.Gestures.Velocitytracker.Velocity), double primaryVelocity = default(double))
        : base()
        {
            this.Velocity = velocity;
            this.PrimaryVelocity = primaryVelocity;
        }
        /// <Summary>
        /// The velocity the pointer was moving when it stopped contacting the screen.
        ///
        /// Defaults to zero if not specified in the constructor.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Velocity { get; set; }
        /// <Summary>
        /// The velocity the pointer was moving along the primary axis when it stopped
        /// contacting the screen, in logical pixels per second.
        ///
        /// If the [GestureDragEndCallback] is for a one-dimensional drag (e.g., a
        /// horizontal or vertical drag), then this value contains the component of
        /// [velocity] along the primary axis (e.g., horizontal or vertical,
        /// respectively). Otherwise, if the [GestureDragEndCallback] is for a
        /// two-dimensional drag (e.g., a pan), then this value is null.
        ///
        /// Defaults to null if not specified in the constructor.
        /// </Summary>
        public virtual double PrimaryVelocity { get; set; }

    }

}
