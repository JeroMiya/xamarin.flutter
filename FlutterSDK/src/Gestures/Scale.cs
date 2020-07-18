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
namespace FlutterSDK.Gestures.Scale
{
    public delegate void GestureScaleStartCallback(FlutterSDK.Gestures.Scale.ScaleStartDetails details);
    public delegate void GestureScaleUpdateCallback(FlutterSDK.Gestures.Scale.ScaleUpdateDetails details);
    public delegate void GestureScaleEndCallback(FlutterSDK.Gestures.Scale.ScaleEndDetails details);
    internal static class ScaleDefaultClass
    {
        internal static bool _IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.Velocity velocity)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Details for [GestureScaleStartCallback].
    /// </Summary>
    public class ScaleStartDetails
    {
        #region constructors
        public ScaleStartDetails(FlutterBinding.UI.Offset focalPoint = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localFocalPoint = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.FocalPoint = focalPoint;
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Offset FocalPoint { get; set; }
        public virtual FlutterBinding.UI.Offset LocalFocalPoint { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Details for [GestureScaleUpdateCallback].
    /// </Summary>
    public class ScaleUpdateDetails
    {
        #region constructors
        public ScaleUpdateDetails(FlutterBinding.UI.Offset focalPoint = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localFocalPoint = default(FlutterBinding.UI.Offset), double scale = 1.0, double horizontalScale = 1.0, double verticalScale = 1.0, double rotation = 0.0)
        : base()
        {
            this.FocalPoint = focalPoint;
            this.Scale = scale;
            this.HorizontalScale = horizontalScale;
            this.VerticalScale = verticalScale;
            this.Rotation = rotation;
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Offset FocalPoint { get; set; }
        public virtual FlutterBinding.UI.Offset LocalFocalPoint { get; set; }
        public virtual double Scale { get; set; }
        public virtual double HorizontalScale { get; set; }
        public virtual double VerticalScale { get; set; }
        public virtual double Rotation { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Details for [GestureScaleEndCallback].
    /// </Summary>
    public class ScaleEndDetails
    {
        #region constructors
        public ScaleEndDetails(FlutterSDK.Gestures.Velocitytracker.Velocity velocity = default(FlutterSDK.Gestures.Velocitytracker.Velocity))
        : base()
        {
            this.Velocity = velocity;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Velocity { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Defines a line between two pointers on screen.
    ///
    /// [_LineBetweenPointers] is an abstraction of a line between two pointers in
    /// contact with the screen. Used to track the rotation of a scale gesture.
    /// </Summary>
    public class _LineBetweenPointers
    {
        #region constructors
        public _LineBetweenPointers(FlutterBinding.UI.Offset pointerStartLocation = default(FlutterBinding.UI.Offset), int pointerStartId = 0, FlutterBinding.UI.Offset pointerEndLocation = default(FlutterBinding.UI.Offset), int pointerEndId = 1)
        : base()
        {
            this.PointerStartLocation = pointerStartLocation;
            this.PointerStartId = pointerStartId;
            this.PointerEndLocation = pointerEndLocation;
            this.PointerEndId = pointerEndId;
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Offset PointerStartLocation { get; set; }
        public virtual int PointerStartId { get; set; }
        public virtual FlutterBinding.UI.Offset PointerEndLocation { get; set; }
        public virtual int PointerEndId { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// Recognizes a scale gesture.
    ///
    /// [ScaleGestureRecognizer] tracks the pointers in contact with the screen and
    /// calculates their focal point, indicated scale, and rotation. When a focal
    /// pointer is established, the recognizer calls [onStart]. As the focal point,
    /// scale, rotation change, the recognizer calls [onUpdate]. When the pointers
    /// are no longer in contact with the screen, the recognizer calls [onEnd].
    /// </Summary>
    public class ScaleGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
    {
        #region constructors
        public ScaleGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Scale.GestureScaleStartCallback OnStart { get; set; }
        public virtual FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback OnUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Scale.GestureScaleEndCallback OnEnd { get; set; }
        internal virtual FlutterSDK.Gestures.Scale._ScaleState _State { get; set; }
        internal virtual Matrix4 _LastTransform { get; set; }
        internal virtual FlutterBinding.UI.Offset _InitialFocalPoint { get; set; }
        internal virtual FlutterBinding.UI.Offset _CurrentFocalPoint { get; set; }
        internal virtual double _InitialSpan { get; set; }
        internal virtual double _CurrentSpan { get; set; }
        internal virtual double _InitialHorizontalSpan { get; set; }
        internal virtual double _CurrentHorizontalSpan { get; set; }
        internal virtual double _InitialVerticalSpan { get; set; }
        internal virtual double _CurrentVerticalSpan { get; set; }
        internal virtual FlutterSDK.Gestures.Scale._LineBetweenPointers _InitialLine { get; set; }
        internal virtual FlutterSDK.Gestures.Scale._LineBetweenPointers _CurrentLine { get; set; }
        internal virtual Dictionary<int, Offset> _PointerLocations { get; set; }
        internal virtual List<int> _PointerQueue { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Velocitytracker.VelocityTracker> _VelocityTrackers { get; set; }
        internal virtual double _ScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _HorizontalScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _VerticalScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private double _ComputeRotationFactor()
        {
            if (_InitialLine == null || _CurrentLine == null)
            {
                return 0.0;
            }

            double fx = _InitialLine.PointerStartLocation.Dx;
            double fy = _InitialLine.PointerStartLocation.Dy;
            double sx = _InitialLine.PointerEndLocation.Dx;
            double sy = _InitialLine.PointerEndLocation.Dy;
            double nfx = _CurrentLine.PointerStartLocation.Dx;
            double nfy = _CurrentLine.PointerStartLocation.Dy;
            double nsx = _CurrentLine.PointerEndLocation.Dx;
            double nsy = _CurrentLine.PointerEndLocation.Dy;
            double angle1 = Math.Dart:mathDefaultClass.Atan2(fy - sy, fx - sx);
            double angle2 = Math.Dart:mathDefaultClass.Atan2(nfy - nsy, nfx - nsx);
            return angle2 - angle1;
        }




        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            StartTrackingPointer(@event.Pointer, @event.Transform);
            _VelocityTrackers[@event.Pointer] = new VelocityTracker();
            if (_State == _ScaleState.Ready)
            {
                _State = _ScaleState.Possible;
                _InitialSpan = 0.0;
                _CurrentSpan = 0.0;
                _InitialHorizontalSpan = 0.0;
                _CurrentHorizontalSpan = 0.0;
                _InitialVerticalSpan = 0.0;
                _CurrentVerticalSpan = 0.0;
                _PointerLocations = new Dictionary<int, Offset> { };
                _PointerQueue = new List<int>() { };
            }

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            bool didChangeConfiguration = false;
            bool shouldStartIfAccepted = false;
            if (@event is PointerMoveEvent)
            {
                VelocityTracker tracker = _VelocityTrackers[((PointerMoveEvent)@event).Pointer];

                if (!((PointerMoveEvent)@event).Synthesized) tracker.AddPosition(((PointerMoveEvent)@event).TimeStamp, ((PointerMoveEvent)@event).Position);
                _PointerLocations[((PointerMoveEvent)@event).Pointer] = ((PointerMoveEvent)@event).Position;
                shouldStartIfAccepted = true;
                _LastTransform = ((PointerMoveEvent)@event).Transform;
            }
            else if (@event is PointerDownEvent)
            {
                _PointerLocations[((PointerDownEvent)@event).Pointer] = ((PointerDownEvent)@event).Position;
                _PointerQueue.Add(((PointerDownEvent)@event).Pointer);
                didChangeConfiguration = true;
                shouldStartIfAccepted = true;
                _LastTransform = ((PointerDownEvent)@event).Transform;
            }
            else if (@event is PointerUpEvent || @event is PointerCancelEvent)
            {
                _PointerLocations.Remove(((PointerUpEvent)@event).Pointer);
                _PointerQueue.Remove(((PointerUpEvent)@event).Pointer);
                didChangeConfiguration = true;
                _LastTransform = ((PointerUpEvent)@event).Transform;
            }

            _UpdateLines();
            _Update();
            if (!didChangeConfiguration || _Reconfigure(@event.Pointer)) _AdvanceStateMachine(shouldStartIfAccepted);
            StopTrackingIfPointerNoLongerDown(@event);
        }




        private void _Update()
        {
            int count = _PointerLocations.Keys.Length;
            Offset focalPoint = Dart:uiDefaultClass.Offset.Zero;
            foreach (int pointer in _PointerLocations.Keys) focalPoint += _PointerLocations[pointer];
            _CurrentFocalPoint = count > 0 ? focalPoint / count.ToDouble() : Dart:uiDefaultClass.Offset.Zero;
            double totalDeviation = 0.0;
            double totalHorizontalDeviation = 0.0;
            double totalVerticalDeviation = 0.0;
            foreach (int pointer in _PointerLocations.Keys)
            {
                totalDeviation += (_CurrentFocalPoint - _PointerLocations[pointer]).Distance;
                totalHorizontalDeviation += (_CurrentFocalPoint.Dx - _PointerLocations[pointer].Dx).Abs();
                totalVerticalDeviation += (_CurrentFocalPoint.Dy - _PointerLocations[pointer].Dy).Abs();
            }

            _CurrentSpan = count > 0 ? totalDeviation / count : 0.0;
            _CurrentHorizontalSpan = count > 0 ? totalHorizontalDeviation / count : 0.0;
            _CurrentVerticalSpan = count > 0 ? totalVerticalDeviation / count : 0.0;
        }




        /// <Summary>
        /// Updates [_initialLine] and [_currentLine] accordingly to the situation of
        /// the registered pointers
        /// </Summary>
        private void _UpdateLines()
        {
            int count = _PointerLocations.Keys.Length;

            if (count < 2)
            {
                _InitialLine = _CurrentLine;
            }
            else if (_InitialLine != null && _InitialLine.PointerStartId == _PointerQueue[0] && _InitialLine.PointerEndId == _PointerQueue[1])
            {
                _CurrentLine = new _LineBetweenPointers(pointerStartId: _PointerQueue[0], pointerStartLocation: _PointerLocations[_PointerQueue[0]], pointerEndId: _PointerQueue[1], pointerEndLocation: _PointerLocations[_PointerQueue[1]]);
            }
            else
            {
                _InitialLine = new _LineBetweenPointers(pointerStartId: _PointerQueue[0], pointerStartLocation: _PointerLocations[_PointerQueue[0]], pointerEndId: _PointerQueue[1], pointerEndLocation: _PointerLocations[_PointerQueue[1]]);
                _CurrentLine = null;
            }

        }




        private bool _Reconfigure(int pointer)
        {
            _InitialFocalPoint = _CurrentFocalPoint;
            _InitialSpan = _CurrentSpan;
            _InitialLine = _CurrentLine;
            _InitialHorizontalSpan = _CurrentHorizontalSpan;
            _InitialVerticalSpan = _CurrentVerticalSpan;
            if (_State == _ScaleState.Started)
            {
                if (OnEnd != null)
                {
                    VelocityTracker tracker = _VelocityTrackers[pointer];

                    Velocity velocity = tracker.GetVelocity();
                    if (ScaleDefaultClass._IsFlingGesture(velocity))
                    {
                        Offset pixelsPerSecond = velocity.PixelsPerSecond;
                        if (pixelsPerSecond.DistanceSquared > ConstantsDefaultClass.KMaxFlingVelocity * ConstantsDefaultClass.KMaxFlingVelocity) velocity = new Velocity(pixelsPerSecond: (pixelsPerSecond / pixelsPerSecond.Distance) * ConstantsDefaultClass.KMaxFlingVelocity);
                        InvokeCallback("onEnd", () => =>OnEnd(new ScaleEndDetails(velocity: velocity)));
                    }
                    else
                    {
                        InvokeCallback("onEnd", () => =>OnEnd(new ScaleEndDetails(velocity: VelocitytrackerDefaultClass.Velocity.Zero)));
                    }

                }

                _State = _ScaleState.Accepted;
                return false;
            }

            return true;
        }




        private void _AdvanceStateMachine(bool shouldStartIfAccepted)
        {
            if (_State == _ScaleState.Ready) _State = _ScaleState.Possible;
            if (_State == _ScaleState.Possible)
            {
                double spanDelta = (_CurrentSpan - _InitialSpan).Abs();
                double focalPointDelta = (_CurrentFocalPoint - _InitialFocalPoint).Distance;
                if (spanDelta > ConstantsDefaultClass.KScaleSlop || focalPointDelta > ConstantsDefaultClass.KPanSlop) Resolve(GestureDisposition.Accepted);
            }
            else if (_State.Index >= _ScaleState.Accepted.Index)
            {
                Resolve(GestureDisposition.Accepted);
            }

            if (_State == _ScaleState.Accepted && shouldStartIfAccepted)
            {
                _State = _ScaleState.Started;
                _DispatchOnStartCallbackIfNeeded();
            }

            if (_State == _ScaleState.Started && OnUpdate != null) InvokeCallback("onUpdate", () =>
            {
                OnUpdate(new ScaleUpdateDetails(scale: _ScaleFactor, horizontalScale: _HorizontalScaleFactor, verticalScale: _VerticalScaleFactor, focalPoint: _CurrentFocalPoint, localFocalPoint: EventsDefaultClass.PointerEvent.TransformPosition(_LastTransform, _CurrentFocalPoint), rotation: _ComputeRotationFactor()));
            }
                  );
        }




        private void _DispatchOnStartCallbackIfNeeded()
        {

            if (OnStart != null) InvokeCallback("onStart", () =>
            {
                OnStart(new ScaleStartDetails(focalPoint: _CurrentFocalPoint, localFocalPoint: EventsDefaultClass.PointerEvent.TransformPosition(_LastTransform, _CurrentFocalPoint)));
            }
              );
        }




        public new void AcceptGesture(int pointer)
        {
            if (_State == _ScaleState.Possible)
            {
                _State = _ScaleState.Started;
                _DispatchOnStartCallbackIfNeeded();
            }

        }




        public new void RejectGesture(int pointer)
        {
            StopTrackingPointer(pointer);
        }




        public new void DidStopTrackingLastPointer(int pointer)
        {
            switch (_State) { case _ScaleState.Possible: Resolve(GestureDisposition.Rejected); break; case _ScaleState.Ready: break; case _ScaleState.Accepted: break; case _ScaleState.Started: break; }
            _State = _ScaleState.Ready;
        }




        public new void Dispose()
        {
            _VelocityTrackers.Clear();
            base.Dispose();
        }



        #endregion
    }


    /// <Summary>
    /// The possible states of a [ScaleGestureRecognizer].
    /// </Summary>
    public enum _ScaleState
    {

        /// <Summary>
        /// The recognizer is ready to start recognizing a gesture.
        /// </Summary>
        Ready,
        /// <Summary>
        /// The sequence of pointer events seen thus far is consistent with a scale
        /// gesture but the gesture has not been accepted definitively.
        /// </Summary>
        Possible,
        /// <Summary>
        /// The sequence of pointer events seen thus far has been accepted
        /// definitively as a scale gesture.
        /// </Summary>
        Accepted,
        /// <Summary>
        /// The sequence of pointer events seen thus far has been accepted
        /// definitively as a scale gesture and the pointers established a focal point
        /// and initial scale.
        /// </Summary>
        Started,
    }

}
