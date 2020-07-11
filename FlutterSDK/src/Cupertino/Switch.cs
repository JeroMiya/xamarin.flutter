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
namespace FlutterSDK.Cupertino.Switch
{
    internal static class SwitchDefaultClass
    {
        public static double _KTrackWidth = default(double);
        public static double _KTrackHeight = default(double);
        public static double _KTrackRadius = default(double);
        public static double _KTrackInnerStart = default(double);
        public static double _KTrackInnerEnd = default(double);
        public static double _KTrackInnerLength = default(double);
        public static double _KSwitchWidth = default(double);
        public static double _KSwitchHeight = default(double);
        public static double _KCupertinoSwitchDisabledOpacity = default(double);
        public static TimeSpan _KReactionDuration = default(TimeSpan);
        public static TimeSpan _KToggleDuration = default(TimeSpan);
    }

    /// <Summary>
    /// An iOS-style switch.
    ///
    /// Used to toggle the on/off state of a single setting.
    ///
    /// The switch itself does not maintain any state. Instead, when the state of
    /// the switch changes, the widget calls the [onChanged] callback. Most widgets
    /// that use a switch will listen for the [onChanged] callback and rebuild the
    /// switch with a new [value] to update the visual appearance of the switch.
    ///
    /// {@tool snippet}
    ///
    /// This sample shows how to use a [CupertinoSwitch] in a [ListTile]. The
    /// [MergeSemantics] is used to turn the entire [ListTile] into a single item
    /// for accessibility tools.
    ///
    /// ```dart
    /// MergeSemantics(
    ///   child: ListTile(
    ///     title: Text('Lights'),
    ///     trailing: CupertinoSwitch(
    ///       value: _lights,
    ///       onChanged: (bool value) { setState(() { _lights = value; }); },
    ///     ),
    ///     onTap: () { setState(() { _lights = !_lights; }); },
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Switch], the material design equivalent.
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/controls/switches/>
    /// </Summary>
    public class CupertinoSwitch : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoSwitch(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color trackColor = default(FlutterBinding.UI.Color), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Value = value;
            this.OnChanged = onChanged;
            this.ActiveColor = activeColor;
            this.TrackColor = trackColor;
            this.DragStartBehavior = dragStartBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Value { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color TrackColor { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Switch._CupertinoSwitchState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoSwitchState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Switch.CupertinoSwitch>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _CupertinoSwitchState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer _Tap { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _PositionController { get; set; }
        public virtual FlutterSDK.Animation.Animations.CurvedAnimation Position { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ReactionController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Reaction { get; set; }
        public virtual bool NeedsPositionAnimation { get; set; }
        public virtual bool IsInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Cupertino.Switch.CupertinoSwitch oldWidget) { throw new NotImplementedException(); }


        private void _ResumePositionAnimation(bool isLinear = true) { throw new NotImplementedException(); }


        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) { throw new NotImplementedException(); }


        private void _HandleTap() { throw new NotImplementedException(); }


        private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) { throw new NotImplementedException(); }


        private void _HandleTapCancel() { throw new NotImplementedException(); }


        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        private void _EmitVibration() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoSwitchRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _CupertinoSwitchRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color trackColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), TextDirection textDirection = default(TextDirection), FlutterSDK.Cupertino.Switch._CupertinoSwitchState state = default(FlutterSDK.Cupertino.Switch._CupertinoSwitchState))
        : base(key: key)
        {
            this.Value = value;
            this.ActiveColor = activeColor;
            this.TrackColor = trackColor;
            this.OnChanged = onChanged;
            this.TextDirection = textDirection;
            this.State = state; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Value { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color TrackColor { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterSDK.Cupertino.Switch._CupertinoSwitchState State { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Switch._RenderCupertinoSwitch CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Switch._RenderCupertinoSwitch renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderCupertinoSwitch : FlutterSDK.Rendering.Proxybox.RenderConstrainedBox
    {
        #region constructors
        public _RenderCupertinoSwitch(bool value = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color trackColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), TextDirection textDirection = default(TextDirection), FlutterSDK.Cupertino.Switch._CupertinoSwitchState state = default(FlutterSDK.Cupertino.Switch._CupertinoSwitchState))
        : base(additionalConstraints: BoxConstraints.TightFor(width: SwitchDefaultClass._KSwitchWidth, height: SwitchDefaultClass._KSwitchHeight))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Cupertino.Switch._CupertinoSwitchState _State { get; set; }
        internal virtual bool _Value { get; set; }
        internal virtual FlutterBinding.UI.Color _ActiveColor { get; set; }
        internal virtual FlutterBinding.UI.Color _TrackColor { get; set; }
        internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> _OnChanged { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual bool Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ActiveColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color TrackColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool HitTestSelf(FlutterBinding.UI.Offset position) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry) { throw new NotImplementedException(); }


        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }

}
