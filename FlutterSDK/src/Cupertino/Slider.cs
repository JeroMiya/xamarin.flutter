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
namespace FlutterSDK.Cupertino.Slider
{
    internal static class SliderDefaultClass
    {
        public static double _KPadding = default(double);
        public static double _KSliderHeight = default(double);
        public static double _KSliderWidth = default(double);
        public static TimeSpan _KDiscreteTransitionDuration = default(TimeSpan);
        public static double _KAdjustmentUnit = default(double);
    }

    /// <Summary>
    /// An iOS-style slider.
    ///
    /// Used to select from a range of values.
    ///
    /// A slider can be used to select from either a continuous or a discrete set of
    /// values. The default is use a continuous range of values from [min] to [max].
    /// To use discrete values, use a non-null value for [divisions], which
    /// indicates the number of discrete intervals. For example, if [min] is 0.0 and
    /// [max] is 50.0 and [divisions] is 5, then the slider can take on the values
    /// discrete values 0.0, 10.0, 20.0, 30.0, 40.0, and 50.0.
    ///
    /// The slider itself does not maintain any state. Instead, when the state of
    /// the slider changes, the widget calls the [onChanged] callback. Most widgets
    /// that use a slider will listen for the [onChanged] callback and rebuild the
    /// slider with a new [value] to update the visual appearance of the slider.
    ///
    /// See also:
    ///
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/controls/sliders/>
    /// </Summary>
    public class CupertinoSlider : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoSlider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), double min = 0.0, double max = 1.0, int divisions = default(int), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual double Value { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
    public virtual double Min { get; set; }
    public virtual double Max { get; set; }
    public virtual int Divisions { get; set; }
    public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
    public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Cupertino.Slider._CupertinoSliderState CreateState() => new _CupertinoSliderState();



    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DoubleProperty("value", Value));
        properties.Add(new DoubleProperty("min", Min));
        properties.Add(new DoubleProperty("max", Max));
    }



    #endregion
}


public class _CupertinoSliderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Slider.CupertinoSlider>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _CupertinoSliderState()
    { }
    #endregion

    #region fields
    #endregion

    #region methods

    private void _HandleChanged(double value)
    {

        double lerpValue = Dart:uiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value);
        if (lerpValue != Widget.Value)
        {
            Widget.OnChanged(lerpValue);
        }

    }




    private void _HandleDragStart(double value)
    {

        Widget.OnChangeStart(Dart: uiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value));
    }




    private void _HandleDragEnd(double value)
    {

        Widget.OnChangeEnd(Dart: uiDefaultClass.LerpDouble(Widget.Min, Widget.Max, value));
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new _CupertinoSliderRenderObjectWidget(value: (Widget.Value - Widget.Min) / (Widget.Max - Widget.Min), divisions: Widget.Divisions, activeColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.ActiveColor ?? ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor, context), thumbColor: Widget.ThumbColor, onChanged: Widget.OnChanged != null ? _HandleChanged : null, onChangeStart: Widget.OnChangeStart != null ? _HandleDragStart : null, onChangeEnd: Widget.OnChangeEnd != null ? _HandleDragEnd : null, vsync: this);
    }



    #endregion
}


public class _CupertinoSliderRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
{
    #region constructors
    public _CupertinoSliderRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), int divisions = default(int), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
    : base(key: key)

}
#endregion

#region fields
public virtual double Value { get; set; }
public virtual int Divisions { get; set; }
public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
public virtual FlutterBinding.UI.Color ThumbColor { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
#endregion

#region methods

public new FlutterSDK.Cupertino.Slider._RenderCupertinoSlider CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderCupertinoSlider(value: Value, divisions: Divisions, activeColor: ActiveColor, thumbColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context), trackColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemFill, context), onChanged: OnChanged, onChangeStart: OnChangeStart, onChangeEnd: OnChangeEnd, vsync: Vsync, textDirection: BasicDefaultClass.Directionality.Of(context));
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Slider._RenderCupertinoSlider renderObject)
{
    ..Value = Value..Divisions = Divisions..ActiveColor = ActiveColor..ThumbColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context)..TrackColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemFill, context)..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context);
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    ..Value = Value..Divisions = Divisions..ActiveColor = ActiveColor..ThumbColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ThumbColor, context)..TrackColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemFill, context)..OnChanged = OnChanged..OnChangeStart = OnChangeStart..OnChangeEnd = OnChangeEnd..TextDirection = BasicDefaultClass.Directionality.Of(context);
}



#endregion
}


public class _RenderCupertinoSlider : FlutterSDK.Rendering.Proxybox.RenderConstrainedBox
{
    #region constructors
    public _RenderCupertinoSlider(double value = default(double), int divisions = default(int), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color thumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color trackColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Foundation.Basictypes.ValueChanged<double> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<double>), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), TextDirection textDirection = default(TextDirection))
    : base(additionalConstraints: BoxConstraints.TightFor(width: SliderDefaultClass._KSliderWidth, height: SliderDefaultClass._KSliderHeight))

_Drag=new HorizontalDragGestureRecognizer()..OnStart=_HandleDragStart..OnUpdate=_HandleDragUpdate..OnEnd=_HandleDragEnd;
_Position=new AnimationController(value:value, duration:SliderDefaultClass._KDiscreteTransitionDuration, vsync:vsync);
    new AnimationController(value:value, duration:SliderDefaultClass._KDiscreteTransitionDuration, vsync:vsync).AddListener(MarkNeedsPaint);
}


#endregion

#region fields
internal virtual double _Value { get; set; }
internal virtual int _Divisions { get; set; }
internal virtual FlutterBinding.UI.Color _ActiveColor { get; set; }
internal virtual FlutterBinding.UI.Color _ThumbColor { get; set; }
internal virtual FlutterBinding.UI.Color _TrackColor { get; set; }
internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> _OnChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeStart { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChangeEnd { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Position { get; set; }
internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag { get; set; }
internal virtual double _CurrentDragValue { get; set; }
public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int Divisions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color ActiveColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color ThumbColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color TrackColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<double> OnChanged { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _DiscretizedCurrentDragValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _TrackLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _TrackRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _ThumbCenter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IsInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _SemanticActionUnit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) => _StartInteraction(details.GlobalPosition);



private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
{
    if (IsInteractive)
    {
        double extent = Math.Dart:mathDefaultClass.Max(SliderDefaultClass._KPadding, Size.Width - 2.0 * (SliderDefaultClass._KPadding + ThumbpainterDefaultClass.CupertinoThumbPainter.Radius));
double valueDelta = details.PrimaryDelta / extent;
switch (TextDirection) { case TextDirection.Rtl: _CurrentDragValue -= valueDelta; break; case TextDirection.Ltr: _CurrentDragValue += valueDelta; break; }
OnChanged(_DiscretizedCurrentDragValue);
}

}




private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) => _EndInteraction();



private void _StartInteraction(FlutterBinding.UI.Offset globalPosition)
{
    if (IsInteractive)
    {
        if (OnChangeStart != null)
        {
            OnChangeStart(_DiscretizedCurrentDragValue);
        }

        _CurrentDragValue = _Value;
        OnChanged(_DiscretizedCurrentDragValue);
    }

}




private void _EndInteraction()
{
    if (OnChangeEnd != null)
    {
        OnChangeEnd(_DiscretizedCurrentDragValue);
    }

    _CurrentDragValue = 0.0;
}




public new bool HitTestSelf(FlutterBinding.UI.Offset position)
{
    return (position.Dx - _ThumbCenter).Abs() < ThumbpainterDefaultClass.CupertinoThumbPainter.Radius + SliderDefaultClass._KPadding;
}




public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
{

    if (@event is PointerDownEvent && IsInteractive) _Drag.AddPointer(@event);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    double visualPosition = default(double);
    Color leftColor = default(Color);
    Color rightColor = default(Color);
    switch (TextDirection) { case TextDirection.Rtl: visualPosition = 1.0 - _Position.Value; leftColor = _ActiveColor; rightColor = TrackColor; break; case TextDirection.Ltr: visualPosition = _Position.Value; leftColor = TrackColor; rightColor = _ActiveColor; break; }
    double trackCenter = offset.Dy + Size.Height / 2.0;
    double trackLeft = offset.Dx + _TrackLeft;
    double trackTop = trackCenter - 1.0;
    double trackBottom = trackCenter + 1.0;
    double trackRight = offset.Dx + _TrackRight;
    double trackActive = offset.Dx + _ThumbCenter;
    Canvas canvas = context.Canvas;
    if (visualPosition > 0.0)
    {
        Paint paint = new Paint()..Color = rightColor;
        canvas.DrawRRect(RRect.FromLTRBXY(trackLeft, trackTop, trackActive, trackBottom, 1.0, 1.0), paint);
    }

    if (visualPosition < 1.0)
    {
        Paint paint = new Paint()..Color = leftColor;
        canvas.DrawRRect(RRect.FromLTRBXY(trackActive, trackTop, trackRight, trackBottom, 1.0, 1.0), paint);
    }

    Offset thumbCenter = new Offset(trackActive, trackCenter);
    new CupertinoThumbPainter(color: ThumbColor).Paint(canvas, Rect.FromCircle(center: thumbCenter, radius: ThumbpainterDefaultClass.CupertinoThumbPainter.Radius));
}




public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    config.IsSemanticBoundary = IsInteractive;
    if (IsInteractive)
    {
        config.TextDirection = TextDirection;
        config.OnIncrease = _IncreaseAction;
        config.OnDecrease = _DecreaseAction;
        config.Value = $"'{(Value * 100).Round()}%'";
        config.IncreasedValue = $"'{((Value + _SemanticActionUnit).Clamp(0.0, 1.0) * 100).Round()}%'";
        config.DecreasedValue = $"'{((Value - _SemanticActionUnit).Clamp(0.0, 1.0) * 100).Round()}%'";
    }

}




private void _IncreaseAction()
{
    if (IsInteractive) OnChanged((Value + _SemanticActionUnit).Clamp(0.0, 1.0) as double);
}




private void _DecreaseAction()
{
    if (IsInteractive) OnChanged((Value - _SemanticActionUnit).Clamp(0.0, 1.0) as double);
}



#endregion
}

}
