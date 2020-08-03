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
namespace FlutterSDK.Cupertino.Picker
{
    internal static class PickerDefaultClass
    {
        public static Color _KHighlighterBorder = default(Color);
        public static double _KDefaultDiameterRatio = default(double);
        public static double _KDefaultPerspective = default(double);
        public static double _KSqueeze = default(double);
        public static double _KOverAndUnderCenterOpacity = default(double);
    }

    /// <Summary>
    /// An iOS-styled picker.
    ///
    /// Displays its children widgets on a wheel for selection and
    /// calls back when the currently selected item changes.
    ///
    /// By default, the first child in `children` will be the initially selected child.
    /// The index of a different child can be specified in [scrollController], to make
    /// that child the initially selected child.
    ///
    /// Can be used with [showCupertinoModalPopup] to display the picker modally at the
    /// bottom of the screen. When calling [showCupertinoModalPopup], be sure to set
    /// `semanticsDismissible` to true to enable dismissing the modal via semantics.
    ///
    /// Sizes itself to its parent. All children are sized to the same size based
    /// on [itemExtent].
    ///
    /// By default, descendent texts are shown with [CupertinoTextThemeData.pickerTextStyle].
    ///
    /// See also:
    ///
    ///  * [ListWheelScrollView], the generic widget backing this picker without
    ///    the iOS design specific chrome.
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/controls/pickers/>
    /// </Summary>
    public class CupertinoPicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a picker from a concrete list of children.
        ///
        /// The [diameterRatio] and [itemExtent] arguments must not be null. The
        /// [itemExtent] must be greater than zero.
        ///
        /// The [backgroundColor] defaults to null, which disables background painting entirely.
        /// (i.e. the picker is going to have a completely transparent background), to match
        /// the native UIPicker and UIDatePicker. Also, if it has transparency, no gradient
        /// effect will be rendered.
        ///
        /// The [scrollController] argument can be used to specify a custom
        /// [FixedExtentScrollController] for programmatically reading or changing
        /// the current picker index or for selecting an initial index value.
        ///
        /// The [looping] argument decides whether the child list loops and can be
        /// scrolled infinitely.  If set to true, scrolling past the end of the list
        /// will loop the list back to the beginning.  If set to false, the list will
        /// stop scrolling when you reach the end or the beginning.
        /// </Summary>
        public CupertinoPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double diameterRatio = default(double), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double offAxisFraction = 0.0, bool useMagnifier = false, double magnification = 1.0, FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController scrollController = default(FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController), double squeeze = default(double), double itemExtent = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onSelectedItemChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), bool looping = false)
        : base(key: key)
        {
            this.DiameterRatio = diameterRatio;
            this.BackgroundColor = backgroundColor;
            this.OffAxisFraction = offAxisFraction;
            this.UseMagnifier = useMagnifier;
            this.Magnification = magnification;
            this.ScrollController = scrollController;
            this.Squeeze = squeeze;
            this.ItemExtent = itemExtent;
            this.OnSelectedItemChanged = onSelectedItemChanged;
        }
        /// <Summary>
        /// Creates a picker from an [IndexedWidgetBuilder] callback where the builder
        /// is dynamically invoked during layout.
        ///
        /// A child is lazily created when it starts becoming visible in the viewport.
        /// All of the children provided by the builder are cached and reused, so
        /// normally the builder is only called once for each index (except when
        /// rebuilding - the cache is cleared).
        ///
        /// The [itemBuilder] argument must not be null. The [childCount] argument
        /// reflects the number of children that will be provided by the [itemBuilder].
        /// {@macro flutter.widgets.wheelList.childCount}
        ///
        /// The [itemExtent] argument must be non-null and positive.
        ///
        /// The [backgroundColor] defaults to null, which disables background painting entirely.
        /// (i.e. the picker is going to have a completely transparent background), to match
        /// the native UIPicker and UIDatePicker.
        /// </Summary>
        public static CupertinoPicker Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double diameterRatio = default(double), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double offAxisFraction = 0.0, bool useMagnifier = false, double magnification = 1.0, FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController scrollController = default(FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController), double squeeze = default(double), double itemExtent = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onSelectedItemChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), int childCount = default(int))
        {
            var instance = new CupertinoPicker(key: key); instance.DiameterRatio = diameterRatio;
            instance.BackgroundColor = backgroundColor;
            instance.OffAxisFraction = offAxisFraction;
            instance.UseMagnifier = useMagnifier;
            instance.Magnification = magnification;
            instance.ScrollController = scrollController;
            instance.Squeeze = squeeze;
            instance.ItemExtent = itemExtent;
            instance.OnSelectedItemChanged = onSelectedItemChanged;
        }
        /// <Summary>
        /// Relative ratio between this picker's height and the simulated cylinder's diameter.
        ///
        /// Smaller values creates more pronounced curvatures in the scrollable wheel.
        ///
        /// For more details, see [ListWheelScrollView.diameterRatio].
        ///
        /// Must not be null and defaults to `1.1` to visually mimic iOS.
        /// </Summary>
        public virtual double DiameterRatio { get; set; }
        /// <Summary>
        /// Background color behind the children.
        ///
        /// Defaults to null, which disables background painting entirely.
        /// (i.e. the picker is going to have a completely transparent background), to match
        /// the native UIPicker and UIDatePicker.
        ///
        /// Any alpha value less 255 (fully opaque) will cause the removal of the
        /// wheel list edge fade gradient from rendering of the widget.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.offAxisFraction}
        /// </Summary>
        public virtual double OffAxisFraction { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.useMagnifier}
        /// </Summary>
        public virtual bool UseMagnifier { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.magnification}
        /// </Summary>
        public virtual double Magnification { get; set; }
        /// <Summary>
        /// A [FixedExtentScrollController] to read and control the current item, and
        /// to set the initial item.
        ///
        /// If null, an implicit one will be created internally.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController ScrollController { get; set; }
        /// <Summary>
        /// The uniform height of all children.
        ///
        /// All children will be given the [BoxConstraints] to match this exact
        /// height. Must not be null and must be positive.
        /// </Summary>
        public virtual double ItemExtent { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.squeeze}
        ///
        /// Defaults to `1.45` to visually mimic iOS.
        /// </Summary>
        public virtual double Squeeze { get; set; }
        /// <Summary>
        /// An option callback when the currently centered item changes.
        ///
        /// Value changes when the item closest to the center changes.
        ///
        /// This can be called during scrolls and during ballistic flings. To get the
        /// value only when the scrolling settles, use a [NotificationListener],
        /// listen for [ScrollEndNotification] and read its [FixedExtentMetrics].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnSelectedItemChanged { get; set; }
        /// <Summary>
        /// A delegate that lazily instantiates children.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate ChildDelegate { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _CupertinoPickerState();


    }


    public class _CupertinoPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Picker.CupertinoPicker>
    {
        public _CupertinoPickerState()
        { }
        internal virtual int _LastHapticIndex { get; set; }
        internal virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController _Controller { get; set; }

        public new void InitState()
        {
            base.InitState();
            if (Widget.ScrollController == null)
            {
                _Controller = new FixedExtentScrollController();
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Picker.CupertinoPicker oldWidget)
        {
            if (Widget.ScrollController != null && oldWidget.ScrollController == null)
            {
                _Controller = null;
            }
            else if (Widget.ScrollController == null && oldWidget.ScrollController != null)
            {

                _Controller = new FixedExtentScrollController();
            }

            base.DidUpdateWidget(oldWidget);
        }




        public new void Dispose()
        {
            _Controller?.Dispose();
            base.Dispose();
        }




        private void _HandleSelectedItemChanged(int index)
        {
            bool hasSuitableHapticHardware = default(bool);
            switch (PlatformDefaultClass.DefaultTargetPlatform) { case TargetPlatform.IOS: hasSuitableHapticHardware = true; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.MacOS: case TargetPlatform.Windows: hasSuitableHapticHardware = false; break; }

            if (hasSuitableHapticHardware && index != _LastHapticIndex)
            {
                _LastHapticIndex = index;
                HapticfeedbackDefaultClass.HapticFeedback.SelectionClick();
            }

            if (Widget.OnSelectedItemChanged != null)
            {
                Widget.OnSelectedItemChanged(index);
            }

        }




        /// <Summary>
        /// Draws the magnifier borders.
        /// </Summary>
        private FlutterSDK.Widgets.Framework.Widget _BuildMagnifierScreen()
        {
            Color resolvedBorderColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(PickerDefaultClass._KHighlighterBorder, Context);
            return new IgnorePointer(child: new Center(child: new Container(decoration: new BoxDecoration(border: new Border(top: new BorderSide(width: 0.0, color: resolvedBorderColor), bottom: new BorderSide(width: 0.0, color: resolvedBorderColor))), constraints: BoxConstraints.Expand(height: Widget.ItemExtent * Widget.Magnification))));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color resolvedBackgroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context);
            Widget result = new DefaultTextStyle(style: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.PickerTextStyle, child: new Stack(children: new List<Widget>() { Positioned.Fill(child: new _CupertinoPickerSemantics(scrollController: Widget.ScrollController ?? _Controller, child: ListWheelScrollView.UseDelegate(controller: Widget.ScrollController ?? _Controller, physics: new FixedExtentScrollPhysics(), diameterRatio: Widget.DiameterRatio, perspective: PickerDefaultClass._KDefaultPerspective, offAxisFraction: Widget.OffAxisFraction, useMagnifier: Widget.UseMagnifier, magnification: Widget.Magnification, overAndUnderCenterOpacity: PickerDefaultClass._KOverAndUnderCenterOpacity, itemExtent: Widget.ItemExtent, squeeze: Widget.Squeeze, onSelectedItemChanged: _HandleSelectedItemChanged, childDelegate: Widget.ChildDelegate))), _BuildMagnifierScreen() }));
            return new DecoratedBox(decoration: new BoxDecoration(color: resolvedBackgroundColor), child: result);
        }



    }


    public class _CupertinoPickerSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _CupertinoPickerSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController scrollController = default(FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController))
        : base(key: key, child: child)
        {
            this.ScrollController = scrollController;
        }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController ScrollController { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new _RenderCupertinoPickerSemantics(ScrollController, BasicDefaultClass.Directionality.Of(context));



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Picker._RenderCupertinoPickerSemantics renderObject)
        {
            ..TextDirection = BasicDefaultClass.Directionality.Of(context)..Controller = ScrollController;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..TextDirection = BasicDefaultClass.Directionality.Of(context)..Controller = ScrollController;
        }



    }


    public class _RenderCupertinoPickerSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
    {
        public _RenderCupertinoPickerSemantics(FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController controller, TextDirection _textDirection)
        {
            this._TextDirection = _textDirection;
            this.Controller = controller;
        }


        internal virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController _Controller { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual int _CurrentIndex { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController Controller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _HandleIncrease()
        {
            Controller.JumpToItem(_CurrentIndex + 1);
        }




        private void _HandleDecrease()
        {
            if (_CurrentIndex == 0) return;
            Controller.JumpToItem(_CurrentIndex - 1);
        }




        private void _HandleScrollUpdate()
        {
            if (Controller.SelectedItem == _CurrentIndex) return;
            _CurrentIndex = Controller.SelectedItem;
            MarkNeedsSemanticsUpdate();
        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.IsSemanticBoundary = true;
            config.TextDirection = TextDirection;
        }




        public new void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children)
        {
            if (children.IsEmpty()) return base.AssembleSemanticsNode(node, config, children);
            SemanticsNode scrollable = children.First;
            Dictionary<int, SemanticsNode> indexedChildren = new Dictionary<int, SemanticsNode> { };
            scrollable.VisitChildren((SemanticsNode child) =>
            {

                indexedChildren[child.IndexInParent] = child;
                return true;
            }
            );
            if (indexedChildren[_CurrentIndex] == null)
            {
                return node.UpdateWith(config: config);
            }

            config.Value = indexedChildren[_CurrentIndex].Label;
            SemanticsNode previousChild = indexedChildren[_CurrentIndex - 1];
            SemanticsNode nextChild = indexedChildren[_CurrentIndex + 1];
            if (nextChild != null)
            {
                config.IncreasedValue = nextChild.Label;
                config.OnIncrease = _HandleIncrease;
            }

            if (previousChild != null)
            {
                config.DecreasedValue = previousChild.Label;
                config.OnDecrease = _HandleDecrease;
            }

            node.UpdateWith(config: config);
        }



    }

}
