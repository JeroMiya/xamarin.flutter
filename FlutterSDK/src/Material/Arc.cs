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
namespace FlutterSDK.Material.Arc
{
    public delegate double _KeyFunc<T>(T input);
    internal static class ArcDefaultClass
    {
        public static double _KOnAxisDelta = default(double);
        public static List<FlutterSDK.Material.Arc._Diagonal> _AllDiagonals = default(List<FlutterSDK.Material.Arc._Diagonal>);
        internal static T _MaxBy<T>(Iterable<T> input, FlutterSDK.Material.Arc._KeyFunc<T> keyFunc)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A [Tween] that interpolates an [Offset] along a circular arc.
    ///
    /// This class specializes the interpolation of [Tween<Offset>] so that instead
    /// of a straight line, the intermediate points follow the arc of a circle in a
    /// manner consistent with material design principles.
    ///
    /// The arc's radius is related to the bounding box that contains the [begin]
    /// and [end] points. If the bounding box is taller than it is wide, then the
    /// center of the circle will be horizontally aligned with the end point.
    /// Otherwise the center of the circle will be aligned with the begin point.
    /// The arc's sweep is always less than or equal to 90 degrees.
    ///
    /// See also:
    ///
    ///  * [Tween], for a discussion on how to use interpolation objects.
    ///  * [MaterialRectArcTween], which extends this concept to interpolating [Rect]s.
    /// </Summary>
    public class MaterialPointArcTween : FlutterSDK.Animation.Tween.Tween<Offset>
    {
        #region constructors
        public MaterialPointArcTween(FlutterBinding.UI.Offset begin = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset end = default(FlutterBinding.UI.Offset))
        : base(begin: begin, end: end)
        {

        }
        #endregion

        #region fields
        internal virtual bool _Dirty { get; set; }
        internal virtual FlutterBinding.UI.Offset _Center { get; set; }
        internal virtual double _Radius { get; set; }
        internal virtual double _BeginAngle { get; set; }
        internal virtual double _EndAngle { get; set; }
        public virtual FlutterBinding.UI.Offset Center { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Radius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double BeginAngle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double EndAngle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset Begin { set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset End { set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _Initialize()
        {


            Offset delta = End - Begin;
            double deltaX = delta.Dx.Abs();
            double deltaY = delta.Dy.Abs();
            double distanceFromAtoB = delta.Distance;
            Offset c = new Offset(End.Dx, Begin.Dy);
            double SweepAngle() => 2.0 * Math.Dart:mathDefaultClass.Asin(distanceFromAtoB / (2.0 * _Radius));
            if (deltaX > ArcDefaultClass._KOnAxisDelta && deltaY > ArcDefaultClass._KOnAxisDelta)
            {
                if (deltaX < deltaY)
                {
                    _Radius = distanceFromAtoB * distanceFromAtoB / (c - Begin).Distance / 2.0;
                    _Center = new Offset(End.Dx + _Radius * (Begin.Dx - End.Dx).Sign, End.Dy);
                    if (Begin.Dx < End.Dx)
                    {
                        _BeginAngle = SweepAngle() * (Begin.Dy - End.Dy).Sign;
                        _EndAngle = 0.0;
                    }
                    else
                    {
                        _BeginAngle = Math.Dart:mathDefaultClass.Pi + SweepAngle() * (End.Dy - Begin.Dy).Sign;
                        _EndAngle = Math.Dart:mathDefaultClass.Pi;
                    }

                }
                else
                {
                    _Radius = distanceFromAtoB * distanceFromAtoB / (c - End).Distance / 2.0;
                    _Center = new Offset(Begin.Dx, Begin.Dy + (End.Dy - Begin.Dy).Sign * _Radius);
                    if (Begin.Dy < End.Dy)
                    {
                        _BeginAngle = -Math.Dart:mathDefaultClass.Pi / 2.0;
                        _EndAngle = _BeginAngle + SweepAngle() * (End.Dx - Begin.Dx).Sign;
                    }
                    else
                    {
                        _BeginAngle = Math.Dart:mathDefaultClass.Pi / 2.0;
                        _EndAngle = _BeginAngle + SweepAngle() * (Begin.Dx - End.Dx).Sign;
                    }

                }



            }
            else
            {
                _BeginAngle = null;
                _EndAngle = null;
            }

            _Dirty = false;
        }




        public new Offset Lerp(double t)
        {
            if (_Dirty) _Initialize();
            if (t == 0.0) return Begin;
            if (t == 1.0) return End;
            if (_BeginAngle == null || _EndAngle == null) return Dart:uiDefaultClass.Offset.Lerp(Begin, End, t);
            double angle = Dart:uiDefaultClass.LerpDouble(_BeginAngle, _EndAngle, t);
            double x = Math.Dart:mathDefaultClass.Cos(angle) * _Radius;
            double y = Math.Dart:mathDefaultClass.Sin(angle) * _Radius;
            return _Center + new Offset(x, y);
        }




        #endregion
    }


    public class _Diagonal
    {
        #region constructors
        public _Diagonal(FlutterSDK.Material.Arc._CornerId beginId, FlutterSDK.Material.Arc._CornerId endId)
        {
            this.BeginId = beginId;
            this.EndId = endId;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Arc._CornerId BeginId { get; set; }
        public virtual FlutterSDK.Material.Arc._CornerId EndId { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A [Tween] that interpolates a [Rect] by having its opposite corners follow
    /// circular arcs.
    ///
    /// This class specializes the interpolation of [Tween<Rect>] so that instead of
    /// growing or shrinking linearly, opposite corners of the rectangle follow arcs
    /// in a manner consistent with material design principles.
    ///
    /// Specifically, the rectangle corners whose diagonals are closest to the overall
    /// direction of the animation follow arcs defined with [MaterialPointArcTween].
    ///
    /// See also:
    ///
    ///  * [MaterialRectCenterArcTween], which interpolates a rect along a circular
    ///    arc between the begin and end [Rect]'s centers.
    ///  * [Tween], for a discussion on how to use interpolation objects.
    ///  * [MaterialPointArcTween], the analog for [Offset] interpolation.
    ///  * [RectTween], which does a linear rectangle interpolation.
    ///  * [Hero.createRectTween], which can be used to specify the tween that defines
    ///    a hero's path.
    /// </Summary>
    public class MaterialRectArcTween : FlutterSDK.Animation.Tween.RectTween
    {
        #region constructors
        public MaterialRectArcTween(FlutterBinding.UI.Rect begin = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect end = default(FlutterBinding.UI.Rect))
        : base(begin: begin, end: end)
        {

        }
        #endregion

        #region fields
        internal virtual bool _Dirty { get; set; }
        internal virtual FlutterSDK.Material.Arc.MaterialPointArcTween _BeginArc { get; set; }
        internal virtual FlutterSDK.Material.Arc.MaterialPointArcTween _EndArc { get; set; }
        public virtual FlutterSDK.Material.Arc.MaterialPointArcTween BeginArc { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Arc.MaterialPointArcTween EndArc { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect Begin { set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect End { set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _Initialize()
        {


            Offset centersVector = End.Center - Begin.Center;
            _Diagonal diagonal = ArcDefaultClass._MaxBy(ArcDefaultClass._AllDiagonals, (_Diagonal d) => =>_DiagonalSupport(centersVector, d));
            _BeginArc = new MaterialPointArcTween(begin: _CornerFor(Begin, diagonal.BeginId), end: _CornerFor(End, diagonal.BeginId));
            _EndArc = new MaterialPointArcTween(begin: _CornerFor(Begin, diagonal.EndId), end: _CornerFor(End, diagonal.EndId));
            _Dirty = false;
        }




        private double _DiagonalSupport(FlutterBinding.UI.Offset centersVector, FlutterSDK.Material.Arc._Diagonal diagonal)
        {
            Offset delta = _CornerFor(Begin, diagonal.EndId) - _CornerFor(Begin, diagonal.BeginId);
            double length = delta.Distance;
            return centersVector.Dx * delta.Dx / length + centersVector.Dy * delta.Dy / length;
        }




        private Offset _CornerFor(FlutterBinding.UI.Rect rect, FlutterSDK.Material.Arc._CornerId id)
        {
            switch (id) { case _CornerId.TopLeft: return rect.TopLeft; case _CornerId.TopRight: return rect.TopRight; case _CornerId.BottomLeft: return rect.BottomLeft; case _CornerId.BottomRight: return rect.BottomRight; }
            return Dart:uiDefaultClass.Offset.Zero;
        }




        public new Rect Lerp(double t)
        {
            if (_Dirty) _Initialize();
            if (t == 0.0) return Begin;
            if (t == 1.0) return End;
            return Rect.FromPoints(_BeginArc.Lerp(t), _EndArc.Lerp(t));
        }




        #endregion
    }


    /// <Summary>
    /// A [Tween] that interpolates a [Rect] by moving it along a circular arc from
    /// [begin]'s [Rect.center] to [end]'s [Rect.center] while interpolating the
    /// rectangle's width and height.
    ///
    /// The arc that defines that center of the interpolated rectangle as it morphs
    /// from [begin] to [end] is a [MaterialPointArcTween].
    ///
    /// See also:
    ///
    ///  * [MaterialRectArcTween], A [Tween] that interpolates a [Rect] by having
    ///    its opposite corners follow circular arcs.
    ///  * [Tween], for a discussion on how to use interpolation objects.
    ///  * [MaterialPointArcTween], the analog for [Offset] interpolation.
    ///  * [RectTween], which does a linear rectangle interpolation.
    ///  * [Hero.createRectTween], which can be used to specify the tween that defines
    ///    a hero's path.
    /// </Summary>
    public class MaterialRectCenterArcTween : FlutterSDK.Animation.Tween.RectTween
    {
        #region constructors
        public MaterialRectCenterArcTween(FlutterBinding.UI.Rect begin = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect end = default(FlutterBinding.UI.Rect))
        : base(begin: begin, end: end)
        {

        }
        #endregion

        #region fields
        internal virtual bool _Dirty { get; set; }
        internal virtual FlutterSDK.Material.Arc.MaterialPointArcTween _CenterArc { get; set; }
        public virtual FlutterSDK.Material.Arc.MaterialPointArcTween CenterArc { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect Begin { set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect End { set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _Initialize()
        {


            _CenterArc = new MaterialPointArcTween(begin: Begin.Center, end: End.Center);
            _Dirty = false;
        }




        public new Rect Lerp(double t)
        {
            if (_Dirty) _Initialize();
            if (t == 0.0) return Begin;
            if (t == 1.0) return End;
            Offset center = _CenterArc.Lerp(t);
            double width = Dart:uiDefaultClass.LerpDouble(Begin.Width, End.Width, t);
            double height = Dart:uiDefaultClass.LerpDouble(Begin.Height, End.Height, t);
            return Rect.FromLTWH(center.Dx - width / 2.0, center.Dy - height / 2.0, width, height);
        }




        #endregion
    }


    public enum _CornerId
    {

        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
    }

}
