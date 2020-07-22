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

            RenderBox renderBoxContainer = globalKey.CurrentContext.FindRenderObject() as RenderBox;
            Offset containerOffset = renderBoxContainer.LocalToGlobal(renderBoxContainer.PaintBounds.TopLeft);
            return containerOffset & renderBoxContainer.PaintBounds.Size;
        }



    }

    /// <Summary>
    /// A full-screen modal route that opens when the [child] is long-pressed.
    ///
    /// When open, the [CupertinoContextMenu] shows the child, or the widget returned
    /// by [previewBuilder] if given, in a large full-screen [Overlay] with a list
    /// of buttons specified by [actions]. The child/preview is placed in an
    /// [Expanded] widget so that it will grow to fill the Overlay if its size is
    /// unconstrained.
    ///
    /// When closed, the CupertinoContextMenu simply displays the child as if the
    /// CupertinoContextMenu were not there. Sizing and positioning is unaffected.
    /// The menu can be closed like other [PopupRoute]s, such as by tapping the
    /// background or by calling `Navigator.pop(context)`. Unlike PopupRoute, it can
    /// also be closed by swiping downwards.
    ///
    /// The [previewBuilder] parameter is most commonly used to display a slight
    /// variation of [child]. See [previewBuilder] for an example of rounding the
    /// child's corners and allowing its aspect ratio to expand, similar to the
    /// Photos app on iOS.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    ///
    /// This sample shows a very simple CupertinoContextMenu for an empty red
    /// 100x100 Container. Simply long press on it to open.
    ///
    /// ```dart imports
    /// import 'package:flutter/cupertino.dart';
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Center(
    ///       child: Container(
    ///         width: 100,
    ///         height: 100,
    ///         child: CupertinoContextMenu(
    ///           child: Container(
    ///             color: Colors.red,
    ///           ),
    ///           actions: <Widget>[
    ///             CupertinoContextMenuAction(
    ///               child: const Text('Action one'),
    ///               onPressed: () {
    ///                 Navigator.pop(context);
    ///               },
    ///             ),
    ///             CupertinoContextMenuAction(
    ///               child: const Text('Action two'),
    ///               onPressed: () {
    ///                 Navigator.pop(context);
    ///               },
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Apple's HIG for Context Menus](https://developer.apple.com/design/human-interface-guidelines/ios/controls/context-menus/)
    /// </Summary>
    public class CupertinoContextMenu : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public CupertinoContextMenu(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Cupertino.Contextmenu.ContextMenuPreviewBuilder previewBuilder = default(FlutterSDK.Cupertino.Contextmenu.ContextMenuPreviewBuilder))
        : base(key: key)
        {
            this.Actions = actions;
            this.Child = child;
            this.PreviewBuilder = previewBuilder;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Cupertino.Contextmenu.ContextMenuPreviewBuilder PreviewBuilder { get; set; }

        public new FlutterSDK.Cupertino.Contextmenu._CupertinoContextMenuState CreateState() => new _CupertinoContextMenuState();


    }


    public class _CupertinoContextMenuState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Contextmenu.CupertinoContextMenu>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _CupertinoContextMenuState()
        { }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ChildGlobalKey { get; set; }
        internal virtual bool _ChildHidden { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _OpenController { get; set; }
        internal virtual FlutterBinding.UI.Rect _DecoyChildEndRect { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _LastOverlayEntry { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuRoute<object> _Route { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation _ContextMenuLocation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _OpenController = new AnimationController(duration: ConstantsDefaultClass.KLongPressTimeout, vsync: this);
            _OpenController.AddStatusListener(_OnDecoyAnimationStatusChange);
        }




        private void _OpenContextMenu()
        {
            SetState(() =>
            {
                _ChildHidden = true;
            }
            );
            _Route = new _ContextMenuRoute<void>(actions: Widget.Actions, barrierLabel: "Dismiss", filter: Ui.Dart:uiDefaultClass.ImageFilter.Blur(sigmaX: 5.0, sigmaY: 5.0), contextMenuLocation: _ContextMenuLocation, previousChildRect: _DecoyChildEndRect, builder: (BuildContext context, Animation<double> animation) =>
            {
                if (Widget.PreviewBuilder == null)
                {
                    return Widget.Child;
                }

                return Widget.PreviewBuilder(context, animation, Widget.Child);
            }
            );
            NavigatorDefaultClass.Navigator.Of(Context, rootNavigator: true).Push(_Route);
            _Route.Animation.AddStatusListener(_RouteAnimationStatusListener);
        }




        private void _OnDecoyAnimationStatusChange(FlutterSDK.Animation.Animation.AnimationStatus animationStatus)
        {
            switch (animationStatus)
            {
                case AnimationStatus.Dismissed:
                    if (_Route == null)
                    {
                        SetState(() =>
                        {
                            _ChildHidden = false;
                        }
                        );
                    }
                    _LastOverlayEntry?.Remove(); _LastOverlayEntry = null; break;
                case AnimationStatus.Completed:
                    SetState(() =>
                    {
                        _ChildHidden = true;
                    }
); _OpenContextMenu(); BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan _) =>
{
_LastOverlayEntry?.Remove();
_LastOverlayEntry = null;
_OpenController.Reset();
}
); break;
                default: return;
            }
        }




        private void _RouteAnimationStatusListener(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status != AnimationStatus.Dismissed)
            {
                return;
            }

            SetState(() =>
            {
                _ChildHidden = false;
            }
            );
            _Route.Animation.RemoveStatusListener(_RouteAnimationStatusListener);
            _Route = null;
        }




        private void _OnTap()
        {
            if (_OpenController.IsAnimating && _OpenController.Value < 0.5)
            {
                _OpenController.Reverse();
            }

        }




        private void _OnTapCancel()
        {
            if (_OpenController.IsAnimating && _OpenController.Value < 0.5)
            {
                _OpenController.Reverse();
            }

        }




        private void _OnTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            if (_OpenController.IsAnimating && _OpenController.Value < 0.5)
            {
                _OpenController.Reverse();
            }

        }




        private void _OnTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
        {
            SetState(() =>
            {
                _ChildHidden = true;
            }
            );
            Rect childRect = ContextmenuDefaultClass._GetRect(_ChildGlobalKey);
            _DecoyChildEndRect = Rect.FromCenter(center: childRect.Center, width: childRect.Width * ContextmenuDefaultClass._KOpenScale, height: childRect.Height * ContextmenuDefaultClass._KOpenScale);
            _LastOverlayEntry = new OverlayEntry(opaque: false, builder: (BuildContext context) =>
            {
                return new _DecoyChild(beginRect: childRect, child: Widget.Child, controller: _OpenController, endRect: _DecoyChildEndRect);
            }
            );
            OverlayDefaultClass.Overlay.Of(Context).Insert(_LastOverlayEntry);
            _OpenController.Forward();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new GestureDetector(onTapCancel: _OnTapCancel, onTapDown: _OnTapDown, onTapUp: _OnTapUp, onTap: _OnTap, child: new TickerMode(enabled: !_ChildHidden, child: new Opacity(key: _ChildGlobalKey, opacity: _ChildHidden ? 0.0 : 1.0, child: Widget.Child)));
        }




        public new void Dispose()
        {
            _OpenController.Dispose();
            base.Dispose();
        }



    }


    public class _DecoyChild : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _DecoyChild(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Rect beginRect = default(FlutterBinding.UI.Rect), FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterBinding.UI.Rect endRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.BeginRect = beginRect;
            this.Controller = controller;
            this.EndRect = endRect;
            this.Child = child;
        }
        public virtual FlutterBinding.UI.Rect BeginRect { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterBinding.UI.Rect EndRect { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Cupertino.Contextmenu._DecoyChildState CreateState() => new _DecoyChildState();


    }


    public class _DecoyChildState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Contextmenu._DecoyChild>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _DecoyChildState()
        { }
        internal virtual FlutterBinding.UI.Color _LightModeMaskColor { get; set; }
        internal virtual FlutterBinding.UI.Color _MasklessColor { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ChildGlobalKey { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Color> _Mask { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Rect> _Rect { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Mask = new _OnOffAnimation<Color>(controller: Widget.Controller, onValue: _LightModeMaskColor, offValue: _MasklessColor, intervalOn: 0.0, intervalOff: 0.5);
            Rect midRect = Widget.BeginRect.Deflate(Widget.BeginRect.Width * (ContextmenuDefaultClass._KOpenScale - 1.0) / 2);
            _Rect = new TweenSequence<Rect>(new List<TweenSequenceItem<Rect>>() { new TweenSequenceItem<Rect>(tween: new RectTween(begin: Widget.BeginRect, end: midRect).Chain(new CurveTween(curve: CurvesDefaultClass.Curves.EaseInOutCubic)), weight: 1.0), new TweenSequenceItem<Rect>(tween: new RectTween(begin: midRect, end: Widget.EndRect).Chain(new CurveTween(curve: CurvesDefaultClass.Curves.EaseOutCubic)), weight: 1.0) }).Animate(Widget.Controller);
            _Rect.AddListener(_RectListener);
        }




        private void _RectListener()
        {
            if (Widget.Controller.Value < 0.5)
            {
                return;
            }

            HapticfeedbackDefaultClass.HapticFeedback.SelectionClick();
            _Rect.RemoveListener(_RectListener);
        }




        public new void Dispose()
        {
            _Rect.RemoveListener(_RectListener);
            base.Dispose();
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            Color color = Widget.Controller.Status == AnimationStatus.Reverse ? _MasklessColor : _Mask.Value;
            return Positioned.FromRect(rect: _Rect.Value, child: ConstantsDefaultClass.KIsWeb ? new Container(key: _ChildGlobalKey, child: Widget.Child) : new ShaderMask(key: _ChildGlobalKey, shaderCallback: (Rect bounds) =>
            {
                return new LinearGradient(begin: AlignmentDefaultClass.Alignment.TopLeft, end: AlignmentDefaultClass.Alignment.BottomRight, colors: new List<Color>() { color, color }).CreateShader(bounds);
            }
            , child: Widget.Child));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Stack(children: new List<Widget>() { new AnimatedBuilder(builder: _BuildAnimation, animation: Widget.Controller) });
        }



    }


    public class _ContextMenuRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
    {
        public _ContextMenuRoute(List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation), string barrierLabel = default(string), FlutterSDK.Cupertino.Contextmenu._ContextMenuPreviewBuilderChildless builder = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuPreviewBuilderChildless), ImageFilter filter = default(ImageFilter), FlutterBinding.UI.Rect previousChildRect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        : base(filter: filter, settings: settings)
        {
            this.BarrierLabel = barrierLabel;
        }
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

        private Rect _GetScaledRect(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> globalKey, double scale)
        {
            Rect childRect = ContextmenuDefaultClass._GetRect(globalKey);
            Size sizeScaled = childRect.Size * scale;
            Offset offsetScaled = new Offset(childRect.Left + (childRect.Size.Width - sizeScaled.Width) / 2, childRect.Top + (childRect.Size.Height - sizeScaled.Height) / 2);
            return offsetScaled & sizeScaled;
        }




        public virtual FlutterSDK.Painting.Alignment.AlignmentDirectional GetSheetAlignment(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation)
        {
            switch (contextMenuLocation) { case _ContextMenuLocation.Center: return AlignmentDefaultClass.AlignmentDirectional.TopCenter; case _ContextMenuLocation.Right: return AlignmentDefaultClass.AlignmentDirectional.TopEnd; default: return AlignmentDefaultClass.AlignmentDirectional.TopStart; }
        }




        private Rect _GetSheetRectBegin(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation, FlutterBinding.UI.Rect childRect, FlutterBinding.UI.Rect sheetRect)
        {
            switch (contextMenuLocation) { case _ContextMenuLocation.Center: Offset target = orientation == Orientation.Portrait ? childRect.BottomCenter : childRect.TopCenter; Offset centered = target - new Offset(sheetRect.Width / 2, 0.0); return centered & sheetRect.Size; case _ContextMenuLocation.Right: Offset target = orientation == Orientation.Portrait ? childRect.BottomRight : childRect.TopRight; return (target - new Offset(sheetRect.Width, 0.0)) & sheetRect.Size; default: Offset target = orientation == Orientation.Portrait ? childRect.BottomLeft : childRect.TopLeft; return target & sheetRect.Size; }
        }




        private void _OnDismiss(FlutterSDK.Widgets.Framework.BuildContext context, double scale, double opacity)
        {
            _Scale = scale;
            _OpacityTween.End = opacity;
            _SheetOpacity = _OpacityTween.Animate(new CurvedAnimation(parent: Animation, curve: new Interval(0.9, 1.0)));
            NavigatorDefaultClass.Navigator.Of(context).Pop();
        }




        private void _UpdateTweenRects()
        {
            Rect childRect = _Scale == null ? ContextmenuDefaultClass._GetRect(_ChildGlobalKey) : _GetScaledRect(_ChildGlobalKey, _Scale);
            _RectTween.Begin = _PreviousChildRect;
            _RectTween.End = childRect;
            Rect childRectOriginal = Rect.FromCenter(center: _PreviousChildRect.Center, width: _PreviousChildRect.Width / ContextmenuDefaultClass._KOpenScale, height: _PreviousChildRect.Height / ContextmenuDefaultClass._KOpenScale);
            Rect sheetRect = ContextmenuDefaultClass._GetRect(_SheetGlobalKey);
            Rect sheetRectBegin = _GetSheetRectBegin(_LastOrientation, _ContextMenuLocation, childRectOriginal, sheetRect);
            _SheetRectTween.Begin = sheetRectBegin;
            _SheetRectTween.End = sheetRect;
            _SheetScaleTween.Begin = 0.0;
            _SheetScaleTween.End = _Scale;
            _RectTweenReverse.Begin = childRectOriginal;
            _RectTweenReverse.End = childRect;
        }




        private void _SetOffstageInternally()
        {
            base.Offstage = _ExternalOffstage || _InternalOffstage;
            ChangedInternalState();
        }




        public new bool DidPop(T result)
        {
            _UpdateTweenRects();
            return base.DidPop(result);
        }




        public new FlutterSDK.Scheduler.Ticker.TickerFuture DidPush()
        {
            _InternalOffstage = true;
            _SetOffstageInternally();
            BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan _) =>
            {
                _UpdateTweenRects();
                _InternalOffstage = false;
                _SetOffstageInternally();
            }
            );
            return base.DidPush();
        }




        public new FlutterSDK.Animation.Animation.Animation<double> CreateAnimation()
        {
            Animation<double> animation = base.CreateAnimation();
            _SheetOpacity = _OpacityTween.Animate(new CurvedAnimation(parent: animation, curve: CurvesDefaultClass.Curves.Linear));
            return animation;
        }




        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation)
        {
            return null;
        }




        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new OrientationBuilder(builder: (BuildContext context, Orientation orientation) =>
            {
                _LastOrientation = orientation;
                if (!animation.IsCompleted)
                {
                    bool reverse = animation.Status == AnimationStatus.Reverse;
                    Rect rect = reverse ? _RectAnimatableReverse.Evaluate(animation) : _RectAnimatable.Evaluate(animation);
                    Rect sheetRect = reverse ? _SheetRectAnimatableReverse.Evaluate(animation) : _SheetRectAnimatable.Evaluate(animation);
                    double sheetScale = reverse ? _SheetScaleAnimatableReverse.Evaluate(animation) : _SheetScaleAnimatable.Evaluate(animation);
                    return new Stack(children: new List<Widget>() { Positioned.FromRect(rect: sheetRect, child: new Opacity(opacity: _SheetOpacity.Value, child: Transform.Scale(alignment: GetSheetAlignment(_ContextMenuLocation), scale: sheetScale, child: new _ContextMenuSheet(key: _SheetGlobalKey, actions: _Actions, contextMenuLocation: _ContextMenuLocation, orientation: orientation)))), Positioned.FromRect(key: _ChildGlobalKey, rect: rect, child: _Builder(context, animation)) });
                }

                return new _ContextMenuRouteStatic(actions: _Actions, child: _Builder(context, animation), childGlobalKey: _ChildGlobalKey, contextMenuLocation: _ContextMenuLocation, onDismiss: _OnDismiss, orientation: orientation, sheetGlobalKey: _SheetGlobalKey);
            }
            );
        }



    }


    public class _ContextMenuRouteStatic : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _ContextMenuRouteStatic(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> childGlobalKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation), FlutterSDK.Cupertino.Contextmenu._DismissCallback onDismiss = default(FlutterSDK.Cupertino.Contextmenu._DismissCallback), FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> sheetGlobalKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>))
        : base(key: key)
        {
            this.Actions = actions;
            this.Child = child;
            this.ChildGlobalKey = childGlobalKey;
            this.ContextMenuLocation = contextMenuLocation;
            this.OnDismiss = onDismiss;
            this.Orientation = orientation;
            this.SheetGlobalKey = sheetGlobalKey;
        }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> ChildGlobalKey { get; set; }
        public virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation ContextMenuLocation { get; set; }
        public virtual FlutterSDK.Cupertino.Contextmenu._DismissCallback OnDismiss { get; set; }
        public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> SheetGlobalKey { get; set; }

        public new FlutterSDK.Cupertino.Contextmenu._ContextMenuRouteStaticState CreateState() => new _ContextMenuRouteStaticState();


    }


    public class _ContextMenuRouteStaticState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Contextmenu._ContextMenuRouteStatic>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _ContextMenuRouteStaticState()
        { }
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

        private double _GetScale(FlutterSDK.Widgets.Mediaquery.Orientation orientation, double maxDragDistance, double dy)
        {
            double dyDirectional = dy <= 0.0 ? dy : -dy;
            return Math.Dart:mathDefaultClass.Max(_KMinScale, (maxDragDistance + dyDirectional) / maxDragDistance);
        }




        private void _OnPanStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {
            _MoveController.Value = 1.0;
            _SetDragOffset(Dart: uiDefaultClass.Offset.Zero);
        }




        private void _OnPanUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            _SetDragOffset(_DragOffset + details.Delta);
        }




        private void _OnPanEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            if (details.Velocity.PixelsPerSecond.Dy.Abs() >= ConstantsDefaultClass.KMinFlingVelocity)
            {
                bool flingIsAway = details.Velocity.PixelsPerSecond.Dy > 0;
                double finalPosition = flingIsAway ? _MoveAnimation.Value.Dy + 100.0 : 0.0;
                if (flingIsAway && _SheetController.Status != AnimationStatus.Forward)
                {
                    _SheetController.Forward();
                }
                else if (!flingIsAway && _SheetController.Status != AnimationStatus.Reverse)
                {
                    _SheetController.Reverse();
                }

                _MoveAnimation = new Tween<Offset>(begin: new Offset(0.0, _MoveAnimation.Value.Dy), end: new Offset(0.0, finalPosition)).Animate(_MoveController);
                _MoveController.Reset();
                _MoveController.Duration = new TimeSpan(milliseconds: 64);
                _MoveController.Forward();
                _MoveController.AddStatusListener(_FlingStatusListener);
                return;
            }

            if (_LastScale == _KMinScale)
            {
                Widget.OnDismiss(Context, _LastScale, _SheetOpacityAnimation.Value);
                return;
            }

            _MoveController.AddListener(_MoveListener);
            _MoveController.Reverse();
        }




        private void _MoveListener()
        {
            if (_LastScale > _KSheetScaleThreshold)
            {
                _MoveController.RemoveListener(_MoveListener);
                if (_SheetController.Status != AnimationStatus.Dismissed)
                {
                    _SheetController.Reverse();
                }

            }

        }




        private void _FlingStatusListener(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status != AnimationStatus.Completed)
            {
                return;
            }

            _MoveController.Duration = _KMoveControllerDuration;
            _MoveController.RemoveStatusListener(_FlingStatusListener);
            if (_MoveAnimation.Value.Dy == 0.0)
            {
                return;
            }

            Widget.OnDismiss(Context, _LastScale, _SheetOpacityAnimation.Value);
        }




        private FlutterSDK.Painting.Alignment.Alignment _GetChildAlignment(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation)
        {
            switch (contextMenuLocation) { case _ContextMenuLocation.Center: return orientation == Orientation.Portrait ? AlignmentDefaultClass.Alignment.BottomCenter : AlignmentDefaultClass.Alignment.TopRight; case _ContextMenuLocation.Right: return orientation == Orientation.Portrait ? AlignmentDefaultClass.Alignment.BottomCenter : AlignmentDefaultClass.Alignment.TopLeft; default: return orientation == Orientation.Portrait ? AlignmentDefaultClass.Alignment.BottomCenter : AlignmentDefaultClass.Alignment.TopRight; }
        }




        private void _SetDragOffset(FlutterBinding.UI.Offset dragOffset)
        {
            double endX = _KPadding * dragOffset.Dx / _KDamping;
            double endY = dragOffset.Dy >= 0.0 ? dragOffset.Dy : _KPadding * dragOffset.Dy / _KDamping;
            SetState(() =>
            {
                _DragOffset = dragOffset;
                _MoveAnimation = new Tween<Offset>(begin: Dart:uiDefaultClass.Offset.Zero, end: new Offset(endX.Clamp(-_KPadding, _KPadding) as double, endY)).Animate(new CurvedAnimation(parent: _MoveController, curve: CurvesDefaultClass.Curves.ElasticIn));
                if (_LastScale <= _KSheetScaleThreshold && _SheetController.Status != AnimationStatus.Forward && _SheetScaleAnimation.Value != 0.0)
                {
                    _SheetController.Forward();
                }
                else if (_LastScale > _KSheetScaleThreshold && _SheetController.Status != AnimationStatus.Reverse && _SheetScaleAnimation.Value != 1.0)
                {
                    _SheetController.Reverse();
                }

            }
            );
        }




        private List<FlutterSDK.Widgets.Framework.Widget> _GetChildren(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation)
        {
            Expanded child = new Expanded(child: new Align(alignment: _GetChildAlignment(Widget.Orientation, Widget.ContextMenuLocation), child: new AnimatedBuilder(animation: _MoveController, builder: _BuildChildAnimation, child: Widget.Child)));
            Container spacer = new Container(width: _KPadding, height: _KPadding);
            Expanded sheet = new Expanded(child: new AnimatedBuilder(animation: _SheetController, builder: _BuildSheetAnimation, child: new _ContextMenuSheet(key: Widget.SheetGlobalKey, actions: Widget.Actions, contextMenuLocation: Widget.ContextMenuLocation, orientation: Widget.Orientation)));
            switch (contextMenuLocation) { case _ContextMenuLocation.Center: return new List<Widget>() { child, spacer, sheet }; case _ContextMenuLocation.Right: return orientation == Orientation.Portrait ? new List<Widget>() { child, spacer, sheet } : new List<Widget>() { sheet, spacer, child }; default: return new List<Widget>() { child, spacer, sheet }; }
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildSheetAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            return Transform.Scale(alignment: ContextmenuDefaultClass._ContextMenuRoute.GetSheetAlignment(Widget.ContextMenuLocation), scale: _SheetScaleAnimation.Value, child: new Opacity(opacity: _SheetOpacityAnimation.Value, child: child));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildChildAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            _LastScale = _GetScale(Widget.Orientation, MediaqueryDefaultClass.MediaQuery.Of(context).Size.Height, _MoveAnimation.Value.Dy);
            return Transform.Scale(key: Widget.ChildGlobalKey, scale: _LastScale, child: child);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildAnimation(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            return Transform.Translate(offset: _MoveAnimation.Value, child: child);
        }




        public new void InitState()
        {
            base.InitState();
            _MoveController = new AnimationController(duration: _KMoveControllerDuration, value: 1.0, vsync: this);
            _SheetController = new AnimationController(duration: new TimeSpan(milliseconds: 100), reverseDuration: new TimeSpan(milliseconds: 300), vsync: this);
            _SheetScaleAnimation = new Tween<double>(begin: 1.0, end: 0.0).Animate(new CurvedAnimation(parent: _SheetController, curve: CurvesDefaultClass.Curves.Linear, reverseCurve: CurvesDefaultClass.Curves.EaseInBack));
            _SheetOpacityAnimation = new Tween<double>(begin: 1.0, end: 0.0).Animate(_SheetController);
            _SetDragOffset(Dart: uiDefaultClass.Offset.Zero);
        }




        public new void Dispose()
        {
            _MoveController.Dispose();
            _SheetController.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> children = _GetChildren(Widget.Orientation, Widget.ContextMenuLocation);
            return new SafeArea(child: new Padding(padding: EdgeInsets.All(_KPadding), child: new Align(alignment: AlignmentDefaultClass.Alignment.TopLeft, child: new GestureDetector(onPanEnd: _OnPanEnd, onPanStart: _OnPanStart, onPanUpdate: _OnPanUpdate, child: new AnimatedBuilder(animation: _MoveController, builder: _BuildAnimation, child: Widget.Orientation == Orientation.Portrait ? new Column(crossAxisAlignment: CrossAxisAlignment.Start, children: children) : new Row(crossAxisAlignment: CrossAxisAlignment.Start, children: children))))));
        }



    }


    public class _ContextMenuSheet : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _ContextMenuSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation contextMenuLocation = default(FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation), FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation))
        : base(key: key)
        {
            this.Actions = actions;
        }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        internal virtual FlutterSDK.Cupertino.Contextmenu._ContextMenuLocation _ContextMenuLocation { get; set; }
        internal virtual FlutterSDK.Widgets.Mediaquery.Orientation _Orientation { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Row(crossAxisAlignment: CrossAxisAlignment.Start, children: Children);
        }



    }


    public class _OnOffAnimation<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
    {
        public _OnOffAnimation(FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), T onValue = default(T), T offValue = default(T), double intervalOn = default(double), double intervalOff = default(double))
        : base(first: new Tween<T>(begin: offValue, end: onValue).Animate(new CurvedAnimation(parent: controller, curve: new Interval(intervalOn, intervalOn))), next: new Tween<T>(begin: onValue, end: offValue).Animate(new CurvedAnimation(parent: controller, curve: new Interval(intervalOff, intervalOff))))
        {

        }
        internal virtual T _OffValue { get; set; }
        public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    public enum _ContextMenuLocation
    {

        Center,
        Left,
        Right,
    }

}
