using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Rendering.Debugoverflowindicator
{
    internal static class DebugoverflowindicatorDefaultClass
    {
    }

    public interface IDebugOverflowIndicatorMixin { }

    public class DebugOverflowIndicatorMixin
    {
        internal virtual FlutterBinding.UI.Color _Black { get; set; }
        internal virtual FlutterBinding.UI.Color _Yellow { get; set; }
        internal virtual double _IndicatorFraction { get; set; }
        internal virtual double _IndicatorFontSizePixels { get; set; }
        internal virtual double _IndicatorLabelPaddingPixels { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _IndicatorTextStyle { get; set; }
        internal virtual SKPaint _IndicatorPaint { get; set; }
        internal virtual SKPaint _LabelBackgroundPaint { get; set; }
        internal virtual List<FlutterSDK.Painting.Textpainter.TextPainter> _IndicatorLabel { get; set; }
        internal virtual bool _OverflowReportNeeded { get; set; }

        private string _FormatPixels(double value)
        {

            string pixels = default(string);
            if (value > 10.0)
            {
                pixels = value.ToStringAsFixed(0);
            }
            else if (value > 1.0)
            {
                pixels = value.ToStringAsFixed(1);
            }
            else
            {
                pixels = value.ToStringAsPrecision(3);
            }

            return pixels;
        }




        private List<FlutterSDK.Rendering.Debugoverflowindicator._OverflowRegionData> _CalculateOverflowRegions(FlutterSDK.Rendering.Stack.RelativeRect overflow, FlutterBinding.UI.Rect containerRect)
        {
            List<_OverflowRegionData> regions = new List<_OverflowRegionData>() { };
            if (overflow.Left > 0.0)
            {
                Rect markerRect = Rect.FromLTWH(0.0, 0.0, containerRect.Width * _IndicatorFraction, containerRect.Height);
                regions.Add(new _OverflowRegionData(rect: markerRect, label: $"'LEFT OVERFLOWED BY {_FormatPixels(overflow.Left)} PIXELS'", labelOffset: markerRect.CenterLeft + new Offset(_IndicatorFontSizePixels + _IndicatorLabelPaddingPixels, 0.0), rotation: Dart.Math.MathDefaultClass.Pi / 2.0, side: _OverflowSide.Left));
            }

            if (overflow.Right > 0.0)
            {
                Rect markerRect = Rect.FromLTWH(containerRect.Width * (1.0 - _IndicatorFraction), 0.0, containerRect.Width * _IndicatorFraction, containerRect.Height);
                regions.Add(new _OverflowRegionData(rect: markerRect, label: $"'RIGHT OVERFLOWED BY {_FormatPixels(overflow.Right)} PIXELS'", labelOffset: markerRect.CenterRight - new Offset(_IndicatorFontSizePixels + _IndicatorLabelPaddingPixels, 0.0), rotation: -Dart.Math.MathDefaultClass.Pi / 2.0, side: _OverflowSide.Right));
            }

            if (overflow.Top > 0.0)
            {
                Rect markerRect = Rect.FromLTWH(0.0, 0.0, containerRect.Width, containerRect.Height * _IndicatorFraction);
                regions.Add(new _OverflowRegionData(rect: markerRect, label: $"'TOP OVERFLOWED BY {_FormatPixels(overflow.Top)} PIXELS'", labelOffset: markerRect.TopCenter + new Offset(0.0, _IndicatorLabelPaddingPixels), rotation: 0.0, side: _OverflowSide.Top));
            }

            if (overflow.Bottom > 0.0)
            {
                Rect markerRect = Rect.FromLTWH(0.0, containerRect.Height * (1.0 - _IndicatorFraction), containerRect.Width, containerRect.Height * _IndicatorFraction);
                regions.Add(new _OverflowRegionData(rect: markerRect, label: $"'BOTTOM OVERFLOWED BY {_FormatPixels(overflow.Bottom)} PIXELS'", labelOffset: markerRect.BottomCenter - new Offset(0.0, _IndicatorFontSizePixels + _IndicatorLabelPaddingPixels), rotation: 0.0, side: _OverflowSide.Bottom));
            }

            return regions;
        }




        private void _ReportOverflow(FlutterSDK.Rendering.Stack.RelativeRect overflow, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> overflowHints)
        {
            overflowHints = (overflowHints == null ? new List<DiagnosticsNode>() { } : overflowHints);
            if (overflowHints.IsEmpty())
            {
                overflowHints.Add(new ErrorDescription($"'The edge of the {GetType()} that is '" + "overflowing has been marked in the rendering with a yellow and black " + "striped pattern. This is usually caused by the contents being too big " + $"'for the {GetType()}.'"));
                overflowHints.Add(new ErrorHint("This is considered an error condition because it indicates that there " + "is content that cannot be seen. If the content is legitimately bigger " + "than the available space, consider clipping it with a ClipRect widget " + $"'before putting it in the {GetType()}, or using a scrollable '" + "container, like a ListView."));
            }

            List<string> overflows = new List<string>() { };
            string overflowText = "";

            switch (overflows.Count) { case 1: overflowText = overflows.First; break; case 2: overflowText = $"'{overflows.First} and {overflows.Last()}'"; break; default: overflows[overflows.Count - 1] = $"'and {overflows[overflows.Count - 1]}'"; overflowText = overflows.Join(", "); }
            AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForRendering(exception: new FlutterError($"'A {GetType()} overflowed by {overflowText}.'"), library: "rendering library", context: new ErrorDescription("during layout"), renderObject: this, informationCollector: () =>
            {
            if (DebugCreator != null) yield return new DiagnosticsDebugCreator(DebugCreator);
            foreach (var enumItem in (overflowHints)) { yield return enumItem; }
            yield return DescribeForError($"'The specific {GetType()} in question is'");
            yield return DiagnosticsNode.Message("◢◤" * (AssertionsDefaultClass.FlutterError.WrapWidth~/ 2), allowWrap: false );
        }
));
}




    /// <Summary>
    /// To be called when the overflow indicators should be painted.
    ///
    /// Typically only called if there is an overflow, and only from within a
    /// debug build.
    ///
    /// See example code in [DebugOverflowIndicatorMixin] documentation.
    /// </Summary>
    public virtual void PaintOverflowIndicator(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect containerRect, FlutterBinding.UI.Rect childRect, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> overflowHints = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>))
    {
        RelativeRect overflow = RelativeRect.FromRect(containerRect, childRect);
        if (overflow.Left <= 0.0 && overflow.Right <= 0.0 && overflow.Top <= 0.0 && overflow.Bottom <= 0.0)
        {
            return;
        }

        List<_OverflowRegionData> overflowRegions = _CalculateOverflowRegions(overflow, containerRect);
        foreach (_OverflowRegionData region in overflowRegions)
        {
            context.Canvas.DrawRect(region.Rect.Shift(offset), _IndicatorPaint);
            TextSpan textSpan = _IndicatorLabel[region.Side.Index].Text as TextSpan;
            if (textSpan?.Text != region.Label)
            {
                _IndicatorLabel[region.Side.Index].Text = new TextSpan(text: region.Label, style: _IndicatorTextStyle);
                _IndicatorLabel[region.Side.Index].Layout();
            }

            Offset labelOffset = region.LabelOffset + offset;
            Offset centerOffset = new Offset(-_IndicatorLabel[region.Side.Index].Width / 2.0, 0.0);
            Rect textBackgroundRect = centerOffset & _IndicatorLabel[region.Side.Index].Size;
            context.Canvas.Save();
            context.Canvas.Translate(labelOffset.Dx, labelOffset.Dy);
            context.Canvas.Rotate(region.Rotation);
            context.Canvas.DrawRect(textBackgroundRect, _LabelBackgroundPaint);
            _IndicatorLabel[region.Side.Index].Paint(context.Canvas, centerOffset);
            context.Canvas.Restore();
        }

        if (_OverflowReportNeeded)
        {
            _OverflowReportNeeded = false;
            _ReportOverflow(overflow, overflowHints);
        }

    }




    public new void Reassemble()
    {
        base.Reassemble();

    }



}
public static class DebugOverflowIndicatorMixinMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<IDebugOverflowIndicatorMixin, DebugOverflowIndicatorMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDebugOverflowIndicatorMixin, DebugOverflowIndicatorMixin>();
    static DebugOverflowIndicatorMixin GetOrCreate(IDebugOverflowIndicatorMixin instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new DebugOverflowIndicatorMixin();
            _table.Add(instance, value);
        }
        return (DebugOverflowIndicatorMixin)value;
    }
    public static void PaintOverflowIndicator(this IDebugOverflowIndicatorMixin instance, FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Rect containerRect, FlutterBinding.UI.Rect childRect, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> overflowHints = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>)) => GetOrCreate(instance).PaintOverflowIndicator(context, offset, containerRect, childRect, overflowHints);
    public static void Reassemble(this IDebugOverflowIndicatorMixin instance) => GetOrCreate(instance).Reassemble();
}


public class _OverflowRegionData
{
    public _OverflowRegionData(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), string label = default(string), FlutterBinding.UI.Offset labelOffset = default(FlutterBinding.UI.Offset), double rotation = 0.0, FlutterSDK.Rendering.Debugoverflowindicator._OverflowSide side = default(FlutterSDK.Rendering.Debugoverflowindicator._OverflowSide))
    {
        this.Rect = rect;
        this.Label = label;
        this.LabelOffset = labelOffset;
        this.Rotation = rotation;
        this.Side = side;
    }
    public virtual FlutterBinding.UI.Rect Rect { get; set; }
    public virtual string Label { get; set; }
    public virtual FlutterBinding.UI.Offset LabelOffset { get; set; }
    public virtual double Rotation { get; set; }
    public virtual FlutterSDK.Rendering.Debugoverflowindicator._OverflowSide Side { get; set; }
}


public enum _OverflowSide
{

    Left,
    Top,
    Bottom,
    Right,
}

}
