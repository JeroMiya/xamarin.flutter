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
namespace FlutterSDK.Cupertino.Contextmenu
{
    public delegate void _DismissCallback(FlutterSDK.Widgets.Framework.BuildContext context, double scale, double opacity);
    public delegate FlutterSDK.Widgets.Framework.Widget ContextMenuPreviewBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Widgets.Framework.Widget child);
    public delegate FlutterSDK.Widgets.Framework.Widget _ContextMenuPreviewBuilderChildless(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation);
    internal static class ContextmenuDefaultClass
    {
        public static double _KOpenScale = default(double);
        internal static Rect _GetRect(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> globalKey)
        {
            throw new NotImplementedException();
        }

    }

    public class CupertinoContextMenu : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoContextMenu(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Cupertino.Contextmenu.ContextMenuPreviewBuilder previewBuilder = default(FlutterSDK.Cupertino.Contextmenu.ContextMenuPreviewBuilder))
        : base(key: key)
        {
            this.Actions = actions;
            this.Child = child;
            this.PreviewBuilder = previewBuilder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Cupertino.Contextmenu.ContextMenuPreviewBuilder PreviewBuilder { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Contextmenu._CupertinoContextMenuState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoContextMenuState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Contextmenu.CupertinoContextMenu>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _CupertinoContextMenuState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ChildGlobalKey { get; set; }
        internal virtual bool _ChildHidden { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _OpenController { get; set; }
        internal virtual FlutterBinding.UI.Rect _DecoyChildEndRect { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _LastOverlayEntry { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuRoute<object> _Route { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation _ContextMenuLocation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _OpenContextMenu() { throw new NotImplementedException(); }


        private void _OnDecoyAnimationStatusChange(FlutterSDK.Animation.Animation.AnimationStatus animationStatus) { throw new NotImplementedException(); }


        private void _RouteAnimationStatusListener(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        private void _OnTap() { throw new NotImplementedException(); }


        private void _OnTapCancel() { throw new NotImplementedException(); }


        private void _OnTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) { throw new NotImplementedException(); }


        private void _OnTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DecoyChild : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _DecoyChild(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Rect beginRect = default(FlutterBinding.UI.Rect), FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterBinding.UI.Rect endRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.BeginRect = beginRect;
            this.Controller = controller;
            this.EndRect = endRect;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect BeginRect { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterBinding.UI.Rect EndRect { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Contextmenu._DecoyChildState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DecoyChildState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Contextmenu._DecoyChild>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _DecoyChildState()
        { }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Color _LightModeMaskColor { get; set; }
        internal virtual FlutterBinding.UI.Color _MasklessColor { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ChildGlobalKey { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Color> _Mask { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Rect> _Rect { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _RectListener() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ContextMenuRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
    {
        #region constructors
        public _ContextMenuRoute(List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation), string barrierLabel = default(string), FlutterSDK.Cupertino.Contextmenu._ContextMenuPreviewBuilderChildless builder = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuPreviewBuilderChildless), ImageFilter filter = default(ImageFilter), FlutterBinding.UI.Rect previousChildRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(filter: filter, settings: settings)
        {
            this.BarrierLabel = barrierLabel; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Color _KModalBarrierColor { get; set; }
        internal virtual TimeSpan _KModalPopupTransitionDuration { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _Actions { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuPreviewBuilderChildless _Builder { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ChildGlobalKey { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation _ContextMenuLocation { get; set; }
        internal virtual bool _ExternalOffstage { get; set; }
        internal virtual bool _InternalOffstage { get; set; }
        internal virtual FlutterSDK.Widgets.Mediaquery.Orientation _LastOrientation { get; set; }
        internal virtual FlutterBinding.UI.Rect _PreviousChildRect { get; set; }
        internal virtual double _Scale { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _SheetGlobalKey { get; set; }
        internal virtual FlutterSDK.Animation.Tween.CurveTween _Curve { get; set; }
        internal virtual FlutterSDK.Animation.Tween.CurveTween _CurveReverse { get; set; }
        internal virtual FlutterSDK.Animation.Tween.RectTween _RectTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<Rect> _RectAnimatable { get; set; }
        internal virtual FlutterSDK.Animation.Tween.RectTween _RectTweenReverse { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<Rect> _RectAnimatableReverse { get; set; }
        internal virtual FlutterSDK.Animation.Tween.RectTween _SheetRectTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<Rect> _SheetRectAnimatable { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<Rect> _SheetRectAnimatableReverse { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _SheetScaleTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _SheetScaleAnimatable { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _SheetScaleAnimatableReverse { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _OpacityTween { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _SheetOpacity { get; set; }
        public new string BarrierLabel { get; set; }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SemanticsDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Offstage { set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private Rect _GetScaledRect(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> globalKey, double scale) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional GetSheetAlignment(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation) { throw new NotImplementedException(); }


        private Rect _GetSheetRectBegin(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation, FlutterBinding.UI.Rect childRect, FlutterBinding.UI.Rect sheetRect) { throw new NotImplementedException(); }


        private void _OnDismiss(FlutterSDK.Widgets.Framework.BuildContext context, double scale, double opacity) { throw new NotImplementedException(); }


        private void _UpdateTweenRects() { throw new NotImplementedException(); }


        private void _SetOffstageInternally() { throw new NotImplementedException(); }


        public new bool DidPop(T result) { throw new NotImplementedException(); }


        public new FlutterSDK.Scheduler.Ticker.TickerFuture DidPush() { throw new NotImplementedException(); }


        public new FlutterSDK.Animation.Animation.Animation<double> CreateAnimation() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ContextMenuRouteStatic : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _ContextMenuRouteStatic(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> childGlobalKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation), FlutterSDK.Cupertino.Contextmenu._DismissCallback onDismiss = default(FlutterSDK.Cupertino.Contextmenu._DismissCallback), FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> sheetGlobalKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>))
        : base(key: key)
        {
            this.Actions = actions;
            this.Child = child;
            this.ChildGlobalKey = childGlobalKey;
            this.ContextMenuLocation = contextMenuLocation;
            this.OnDismiss = onDismiss;
            this.Orientation = orientation;
            this.SheetGlobalKey = sheetGlobalKey; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> ChildGlobalKey { get; set; }
        public virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation ContextMenuLocation { get; set; }
        public virtual FlutterSDK.Cupertino.Contextmenu._DismissCallback OnDismiss { get; set; }
        public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> SheetGlobalKey { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Contextmenu._ContextMenuRouteStaticState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _ContextMenuRouteStaticState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Contextmenu._ContextMenuRouteStatic>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _ContextMenuRouteStaticState()
        { }
        #endregion

        #region fields
        internal virtual double _KMinScale { get; set; }
        internal virtual double _KSheetScaleThreshold { get; set; }
        internal virtual double _KPadding { get; set; }
        internal virtual double _KDamping { get; set; }
        internal virtual TimeSpan _KMoveControllerDuration { get; set; }
        internal virtual FlutterBinding.UI.Offset _DragOffset { get; set; }
        internal virtual double _LastScale { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _MoveController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _SheetController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _MoveAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _SheetScaleAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _SheetOpacityAnimation { get; set; }
        #endregion

        #region methods

        private double _GetScale(FlutterSDK.Widgets.Mediaquery.Orientation orientation, double maxDragDistance, double dy) { throw new NotImplementedException(); }


        private void _OnPanStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _OnPanUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _OnPanEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        private void _MoveListener() { throw new NotImplementedException(); }


        private void _FlingStatusListener(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Alignment.Alignment _GetChildAlignment(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation) { throw new NotImplementedException(); }


        private void _SetDragOffset(FlutterBinding.UI.Offset dragOffset) { throw new NotImplementedException(); }


        private List<FlutterSDK.Widgets.Framework.Widget> _GetChildren(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildSheetAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildChildAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ContextMenuSheet : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _ContextMenuSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation), FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation))
        : base(key: key)
        {
            this.Actions = actions; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation _ContextMenuLocation { get; set; }
        internal virtual FlutterSDK.Widgets.Mediaquery.Orientation _Orientation { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _OnOffAnimation<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
    {
        #region constructors
        public _OnOffAnimation(FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), T onValue = default(T), T offValue = default(T), double intervalOn = default(double), double intervalOff = default(double))
        : base(first: new Tween<T>(begin: offValue, end: onValue).Animate(new CurvedAnimation(parent: controller, curve: new Interval(intervalOn, intervalOn))), next: new Tween<T>(begin: onValue, end: offValue).Animate(new CurvedAnimation(parent: controller, curve: new Interval(intervalOff, intervalOff))))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual T _OffValue { get; set; }
        public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }


    public enum _ContextMenuLocation
    {

        Center,
        Left,
        Right,
    }

}
