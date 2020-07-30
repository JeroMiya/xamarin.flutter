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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Material.Progressindicator
{
    internal static class ProgressindicatorDefaultClass
    {
        public static double _KLinearProgressIndicatorHeight = default(double);
        public static double _KMinCircularProgressIndicatorSize = default(double);
        public static int _KIndeterminateLinearDuration = default(int);
        public static FlutterSDK.Animation.Tween.Animatable<double> _KStrokeHeadTween = default(FlutterSDK.Animation.Tween.Animatable<double>);
        public static FlutterSDK.Animation.Tween.Animatable<double> _KStrokeTailTween = default(FlutterSDK.Animation.Tween.Animatable<double>);
        public static FlutterSDK.Animation.Tween.Animatable<int> _KStepTween = default(FlutterSDK.Animation.Tween.Animatable<int>);
        public static FlutterSDK.Animation.Tween.Animatable<double> _KRotationTween = default(FlutterSDK.Animation.Tween.Animatable<double>);
    }

    /// <Summary>
    /// A base class for material design progress indicators.
    ///
    /// This widget cannot be instantiated directly. For a linear progress
    /// indicator, see [LinearProgressIndicator]. For a circular progress indicator,
    /// see [CircularProgressIndicator].
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/components/progress-indicators.html>
    /// </Summary>
    public interface IProgressIndicator
    {
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        double Value { get; }
        FlutterBinding.UI.Color BackgroundColor { get; }
        FlutterSDK.Animation.Animation.Animation<Color> ValueColor { get; }
        string SemanticsLabel { get; }
        string SemanticsValue { get; }
    }


    /// <Summary>
    /// A base class for material design progress indicators.
    ///
    /// This widget cannot be instantiated directly. For a linear progress
    /// indicator, see [LinearProgressIndicator]. For a circular progress indicator,
    /// see [CircularProgressIndicator].
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/components/progress-indicators.html>
    /// </Summary>
    public class ProgressIndicator : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public ProgressIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Animation.Animation<Color> valueColor = default(FlutterSDK.Animation.Animation.Animation<Color>), string semanticsLabel = default(string), string semanticsValue = default(string))
        : base(key: key)
        {
            this.Value = value;
            this.BackgroundColor = backgroundColor;
            this.ValueColor = valueColor;
            this.SemanticsLabel = semanticsLabel;
            this.SemanticsValue = semanticsValue;
        }
        public virtual double Value { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<Color> ValueColor { get; set; }
        public virtual string SemanticsLabel { get; set; }
        public virtual string SemanticsValue { get; set; }

        private Color _GetBackgroundColor(FlutterSDK.Widgets.Framework.BuildContext context) => BackgroundColor ?? ThemeDefaultClass.Theme.Of(context).BackgroundColor;



        private Color _GetValueColor(FlutterSDK.Widgets.Framework.BuildContext context) => ValueColor?.Value ?? ThemeDefaultClass.Theme.Of(context).AccentColor;



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new PercentProperty("value", Value, showName: false, ifNull: "<indeterminate>"));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildSemanticsWrapper(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            string expandedSemanticsValue = SemanticsValue;
            if (Value != null)
            {
                expandedSemanticsValue = (expandedSemanticsValue == null ? $"'{(Value * 100).Round()}%'" : expandedSemanticsValue);
            }

            return new Semantics(label: SemanticsLabel, value: expandedSemanticsValue, child: child);
        }



    }


    public class _LinearProgressIndicatorPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _LinearProgressIndicatorPainter(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color valueColor = default(FlutterBinding.UI.Color), double value = default(double), double animationValue = default(double), TextDirection textDirection = default(TextDirection))
        : base()
        {
            this.BackgroundColor = backgroundColor;
            this.ValueColor = valueColor;
            this.Value = value;
            this.AnimationValue = animationValue;
            this.TextDirection = textDirection;
        }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color ValueColor { get; set; }
        public virtual double Value { get; set; }
        public virtual double AnimationValue { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Line1Head { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Line1Tail { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Line2Head { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Line2Tail { get; set; }

        public new void Paint(Canvas canvas, Size size)
        {
            Paint paint = new Paint()..Color = BackgroundColor..Style = PaintingStyle.Fill;
            canvas.DrawRect(Dart.UI.UiDefaultClass.Offset.Zero & size, paint);
            paint.Color = ValueColor;
            void DrawBar(double x, double width)
            {
                if (width <= 0.0) return;
                double left = default(double);
                switch (TextDirection) { case TextDirection.Rtl: left = size.Width - width - x; break; case TextDirection.Ltr: left = x; break; }
                canvas.DrawRect(new Offset(left, 0.0) & new Size(width, size.Height), paint);
            }

            if (Value != null)
            {
                DrawBar(0.0, Value.Clamp(0.0, 1.0) * size.Width as double);
            }
            else
            {
                double x1 = size.Width * Line1Tail.Transform(AnimationValue);
                double width1 = size.Width * Line1Head.Transform(AnimationValue) - x1;
                double x2 = size.Width * Line2Tail.Transform(AnimationValue);
                double width2 = size.Width * Line2Head.Transform(AnimationValue) - x2;
                DrawBar(x1, width1);
                DrawBar(x2, width2);
            }

        }




        public new bool ShouldRepaint(FlutterSDK.Material.Progressindicator._LinearProgressIndicatorPainter oldPainter)
        {
            return oldPainter.BackgroundColor != BackgroundColor || oldPainter.ValueColor != ValueColor || oldPainter.Value != Value || oldPainter.AnimationValue != AnimationValue || oldPainter.TextDirection != TextDirection;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return oldPainter.BackgroundColor != BackgroundColor || oldPainter.ValueColor != ValueColor || oldPainter.Value != Value || oldPainter.AnimationValue != AnimationValue || oldPainter.TextDirection != TextDirection;
        }



    }


    /// <Summary>
    /// A material design linear progress indicator, also known as a progress bar.
    ///
    /// A widget that shows progress along a line. There are two kinds of linear
    /// progress indicators:
    ///
    ///  * _Determinate_. Determinate progress indicators have a specific value at
    ///    each point in time, and the value should increase monotonically from 0.0
    ///    to 1.0, at which time the indicator is complete. To create a determinate
    ///    progress indicator, use a non-null [value] between 0.0 and 1.0.
    ///  * _Indeterminate_. Indeterminate progress indicators do not have a specific
    ///    value at each point in time and instead indicate that progress is being
    ///    made without indicating how much progress remains. To create an
    ///    indeterminate progress indicator, use a null [value].
    ///
    /// The indicator line is displayed with [valueColor], an animated value. To
    /// specify a constant color value use: `AlwaysStoppedAnimation<Color>(color)`.
    ///
    /// See also:
    ///
    ///  * [CircularProgressIndicator], which shows progress along a circular arc.
    ///  * [RefreshIndicator], which automatically displays a [CircularProgressIndicator]
    ///    when the underlying vertical scrollable is overscrolled.
    ///  * <https://material.io/design/components/progress-indicators.html#linear-progress-indicators>
    /// </Summary>
    public class LinearProgressIndicator : FlutterSDK.Material.Progressindicator.ProgressIndicator
    {
        public LinearProgressIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Animation.Animation<Color> valueColor = default(FlutterSDK.Animation.Animation.Animation<Color>), string semanticsLabel = default(string), string semanticsValue = default(string))
        : base(key: key, value: value, backgroundColor: backgroundColor, valueColor: valueColor, semanticsLabel: semanticsLabel, semanticsValue: semanticsValue)
        {

        }

        public new FlutterSDK.Material.Progressindicator._LinearProgressIndicatorState CreateState() => new _LinearProgressIndicatorState();


    }


    public class _LinearProgressIndicatorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Progressindicator.LinearProgressIndicator>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _LinearProgressIndicatorState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(duration: new TimeSpan(milliseconds: ProgressindicatorDefaultClass._KIndeterminateLinearDuration), vsync: this);
            if (Widget.Value == null) _Controller.Repeat();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Progressindicator.LinearProgressIndicator oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Value == null && !_Controller.IsAnimating) _Controller.Repeat(); else if (Widget.Value != null && _Controller.IsAnimating) _Controller.Stop();
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildIndicator(FlutterSDK.Widgets.Framework.BuildContext context, double animationValue, TextDirection textDirection)
        {
            return Widget._BuildSemanticsWrapper(context: context, child: new Container(constraints: new BoxConstraints(minWidth: Dart.CoreDefaultClass.Double.Infinity, minHeight: ProgressindicatorDefaultClass._KLinearProgressIndicatorHeight), child: new CustomPaint(painter: new _LinearProgressIndicatorPainter(backgroundColor: Widget._GetBackgroundColor(context), valueColor: Widget._GetValueColor(context), value: Widget.Value, animationValue: animationValue, textDirection: textDirection))));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            if (Widget.Value != null) return _BuildIndicator(context, _Controller.Value, textDirection);
            return new AnimatedBuilder(animation: _Controller.View, builder: (BuildContext context, Widget child) =>
            {
                return _BuildIndicator(context, _Controller.Value, textDirection);
            }
            );
        }



    }


    public class _CircularProgressIndicatorPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _CircularProgressIndicatorPainter(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color valueColor = default(FlutterBinding.UI.Color), double value = default(double), double headValue = default(double), double tailValue = default(double), int stepValue = default(int), double rotationValue = default(double), double strokeWidth = default(double))
        : base()
        {
            this.BackgroundColor = backgroundColor;
            this.ValueColor = valueColor;
            this.Value = value;
            this.HeadValue = headValue;
            this.TailValue = tailValue;
            this.StepValue = stepValue;
            this.RotationValue = rotationValue;
            this.StrokeWidth = strokeWidth;
        }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color ValueColor { get; set; }
        public virtual double Value { get; set; }
        public virtual double HeadValue { get; set; }
        public virtual double TailValue { get; set; }
        public virtual int StepValue { get; set; }
        public virtual double RotationValue { get; set; }
        public virtual double StrokeWidth { get; set; }
        public virtual double ArcStart { get; set; }
        public virtual double ArcSweep { get; set; }
        internal virtual double _TwoPi { get; set; }
        internal virtual double _Epsilon { get; set; }
        internal virtual double _Sweep { get; set; }
        internal virtual double _StartAngle { get; set; }

        public new void Paint(Canvas canvas, Size size)
        {
            Paint paint = new Paint()..Color = ValueColor..StrokeWidth = StrokeWidth..Style = PaintingStyle.Stroke;
            if (BackgroundColor != null)
            {
                Paint backgroundPaint = new Paint()..Color = BackgroundColor..StrokeWidth = StrokeWidth..Style = PaintingStyle.Stroke;
                canvas.DrawArc(Dart.UI.UiDefaultClass.Offset.Zero & size, 0, _Sweep, false, backgroundPaint);
            }

            if (Value == null) paint.StrokeCap = StrokeCap.Square;
            canvas.DrawArc(Dart.UI.UiDefaultClass.Offset.Zero & size, ArcStart, ArcSweep, false, paint);
        }




        public new bool ShouldRepaint(FlutterSDK.Material.Progressindicator._CircularProgressIndicatorPainter oldPainter)
        {
            return oldPainter.BackgroundColor != BackgroundColor || oldPainter.ValueColor != ValueColor || oldPainter.Value != Value || oldPainter.HeadValue != HeadValue || oldPainter.TailValue != TailValue || oldPainter.StepValue != StepValue || oldPainter.RotationValue != RotationValue || oldPainter.StrokeWidth != StrokeWidth;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return oldPainter.BackgroundColor != BackgroundColor || oldPainter.ValueColor != ValueColor || oldPainter.Value != Value || oldPainter.HeadValue != HeadValue || oldPainter.TailValue != TailValue || oldPainter.StepValue != StepValue || oldPainter.RotationValue != RotationValue || oldPainter.StrokeWidth != StrokeWidth;
        }



    }


    /// <Summary>
    /// A material design circular progress indicator, which spins to indicate that
    /// the application is busy.
    ///
    /// A widget that shows progress along a circle. There are two kinds of circular
    /// progress indicators:
    ///
    ///  * _Determinate_. Determinate progress indicators have a specific value at
    ///    each point in time, and the value should increase monotonically from 0.0
    ///    to 1.0, at which time the indicator is complete. To create a determinate
    ///    progress indicator, use a non-null [value] between 0.0 and 1.0.
    ///  * _Indeterminate_. Indeterminate progress indicators do not have a specific
    ///    value at each point in time and instead indicate that progress is being
    ///    made without indicating how much progress remains. To create an
    ///    indeterminate progress indicator, use a null [value].
    ///
    /// The indicator arc is displayed with [valueColor], an animated value. To
    /// specify a constant color use: `AlwaysStoppedAnimation<Color>(color)`.
    ///
    /// See also:
    ///
    ///  * [LinearProgressIndicator], which displays progress along a line.
    ///  * [RefreshIndicator], which automatically displays a [CircularProgressIndicator]
    ///    when the underlying vertical scrollable is overscrolled.
    ///  * <https://material.io/design/components/progress-indicators.html#circular-progress-indicators>
    /// </Summary>
    public class CircularProgressIndicator : FlutterSDK.Material.Progressindicator.ProgressIndicator
    {
        public CircularProgressIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Animation.Animation<Color> valueColor = default(FlutterSDK.Animation.Animation.Animation<Color>), double strokeWidth = 4.0, string semanticsLabel = default(string), string semanticsValue = default(string))
        : base(key: key, value: value, backgroundColor: backgroundColor, valueColor: valueColor, semanticsLabel: semanticsLabel, semanticsValue: semanticsValue)
        {
            this.StrokeWidth = strokeWidth;
        }
        public virtual double StrokeWidth { get; set; }

        public new FlutterSDK.Material.Progressindicator._CircularProgressIndicatorState CreateState() => new _CircularProgressIndicatorState();


    }


    public class _CircularProgressIndicatorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Progressindicator.CircularProgressIndicator>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _CircularProgressIndicatorState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(duration: new TimeSpan(seconds: 5), vsync: this);
            if (Widget.Value == null) _Controller.Repeat();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Progressindicator.CircularProgressIndicator oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Value == null && !_Controller.IsAnimating) _Controller.Repeat(); else if (Widget.Value != null && _Controller.IsAnimating) _Controller.Stop();
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildIndicator(FlutterSDK.Widgets.Framework.BuildContext context, double headValue, double tailValue, int stepValue, double rotationValue)
        {
            return Widget._BuildSemanticsWrapper(context: context, child: new Container(constraints: new BoxConstraints(minWidth: ProgressindicatorDefaultClass._KMinCircularProgressIndicatorSize, minHeight: ProgressindicatorDefaultClass._KMinCircularProgressIndicatorSize), child: new CustomPaint(painter: new _CircularProgressIndicatorPainter(backgroundColor: Widget.BackgroundColor, valueColor: Widget._GetValueColor(context), value: Widget.Value, headValue: headValue, tailValue: tailValue, stepValue: stepValue, rotationValue: rotationValue, strokeWidth: Widget.StrokeWidth))));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildAnimation()
        {
            return new AnimatedBuilder(animation: _Controller, builder: (BuildContext context, Widget child) =>
            {
                return _BuildIndicator(context, ProgressindicatorDefaultClass._KStrokeHeadTween.Evaluate(_Controller), ProgressindicatorDefaultClass._KStrokeTailTween.Evaluate(_Controller), ProgressindicatorDefaultClass._KStepTween.Evaluate(_Controller), ProgressindicatorDefaultClass._KRotationTween.Evaluate(_Controller));
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (Widget.Value != null) return _BuildIndicator(context, 0.0, 0.0, 0, 0.0);
            return _BuildAnimation();
        }



    }


    public class _RefreshProgressIndicatorPainter : FlutterSDK.Material.Progressindicator._CircularProgressIndicatorPainter
    {
        public _RefreshProgressIndicatorPainter(FlutterBinding.UI.Color valueColor = default(FlutterBinding.UI.Color), double value = default(double), double headValue = default(double), double tailValue = default(double), int stepValue = default(int), double rotationValue = default(double), double strokeWidth = default(double), double arrowheadScale = default(double))
        : base(valueColor: valueColor, value: value, headValue: headValue, tailValue: tailValue, stepValue: stepValue, rotationValue: rotationValue, strokeWidth: strokeWidth)
        {
            this.ArrowheadScale = arrowheadScale;
        }
        public virtual double ArrowheadScale { get; set; }

        public virtual void PaintArrowhead(Canvas canvas, Size size)
        {
            double arcEnd = ArcStart + ArcSweep;
            double ux = Dart.Math.MathDefaultClass.Cos(arcEnd);
            double uy = Dart.Math.MathDefaultClass.Sin(arcEnd);

            double radius = size.Width / 2.0;
            double arrowheadPointX = radius + ux * radius + -uy * StrokeWidth * 2.0 * ArrowheadScale;
            double arrowheadPointY = radius + uy * radius + ux * StrokeWidth * 2.0 * ArrowheadScale;
            double arrowheadRadius = StrokeWidth * 1.5 * ArrowheadScale;
            double innerRadius = radius - arrowheadRadius;
            double outerRadius = radius + arrowheadRadius;
            Path path = new Path();
            new Path().MoveTo(radius + ux * innerRadius, radius + uy * innerRadius);
            new Path().LineTo(radius + ux * outerRadius, radius + uy * outerRadius);
            new Path().LineTo(arrowheadPointX, arrowheadPointY);
            new Path().Close();
            Paint paint = new Paint()..Color = ValueColor..StrokeWidth = StrokeWidth..Style = PaintingStyle.Fill;
            canvas.DrawPath(path, paint);
        }




        public new void Paint(Canvas canvas, Size size)
        {
            base.Paint(canvas, size);
            if (ArrowheadScale > 0.0) PaintArrowhead(canvas, size);
        }



    }


    /// <Summary>
    /// An indicator for the progress of refreshing the contents of a widget.
    ///
    /// Typically used for swipe-to-refresh interactions. See [RefreshIndicator] for
    /// a complete implementation of swipe-to-refresh driven by a [Scrollable]
    /// widget.
    ///
    /// The indicator arc is displayed with [valueColor], an animated value. To
    /// specify a constant color use: `AlwaysStoppedAnimation<Color>(color)`.
    ///
    /// See also:
    ///
    ///  * [RefreshIndicator], which automatically displays a [CircularProgressIndicator]
    ///    when the underlying vertical scrollable is overscrolled.
    /// </Summary>
    public class RefreshProgressIndicator : FlutterSDK.Material.Progressindicator.CircularProgressIndicator
    {
        public RefreshProgressIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double value = default(double), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Animation.Animation<Color> valueColor = default(FlutterSDK.Animation.Animation.Animation<Color>), double strokeWidth = 2.0, string semanticsLabel = default(string), string semanticsValue = default(string))
        : base(key: key, value: value, backgroundColor: backgroundColor, valueColor: valueColor, strokeWidth: strokeWidth, semanticsLabel: semanticsLabel, semanticsValue: semanticsValue)
        {

        }

        public new FlutterSDK.Material.Progressindicator._RefreshProgressIndicatorState CreateState() => new _RefreshProgressIndicatorState();


    }


    public class _RefreshProgressIndicatorState : FlutterSDK.Material.Progressindicator._CircularProgressIndicatorState
    {
        public _RefreshProgressIndicatorState()
        { }
        internal virtual double _IndicatorSize { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (Widget.Value != null) _Controller.Value = Widget.Value / 10.0; else if (!_Controller.IsAnimating) _Controller.Repeat();
            return _BuildAnimation();
        }




        protected new FlutterSDK.Widgets.Framework.Widget _BuildIndicator(FlutterSDK.Widgets.Framework.BuildContext context, double headValue, double tailValue, int stepValue, double rotationValue)
        {
            double arrowheadScale = Widget.Value == null ? 0.0 : ((Widget.Value * 2.0).Clamp(0.0, 1.0) as double);
            return Widget._BuildSemanticsWrapper(context: context, child: new Container(width: _IndicatorSize, height: _IndicatorSize, margin: EdgeInsets.All(4.0), child: new Material(type: MaterialType.Circle, color: Widget.BackgroundColor ?? ThemeDefaultClass.Theme.Of(context).CanvasColor, elevation: 2.0, child: new Padding(padding: EdgeInsets.All(12.0), child: new CustomPaint(painter: new _RefreshProgressIndicatorPainter(valueColor: Widget._GetValueColor(context), value: null, headValue: headValue, tailValue: tailValue, stepValue: stepValue, rotationValue: rotationValue, strokeWidth: Widget.StrokeWidth, arrowheadScale: arrowheadScale))))));
        }



    }

}
