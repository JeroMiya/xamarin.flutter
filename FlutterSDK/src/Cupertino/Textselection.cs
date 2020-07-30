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
namespace FlutterSDK.Cupertino.Textselection
{
    internal static class TextselectionDefaultClass
    {
        public static double _KSelectionHandleOverlap = default(double);
        public static double _KSelectionHandleRadius = default(double);
        public static double _KToolbarScreenPadding = default(double);
        public static double _KArrowScreenPadding = default(double);
        public static double _KToolbarContentDistance = default(double);
        public static double _KToolbarHeight = default(double);
        public static Size _KToolbarArrowSize = default(Size);
        public static Radius _KToolbarBorderRadius = default(Radius);
        public static Color _KToolbarBackgroundColor = default(Color);
        public static Color _KToolbarDividerColor = default(Color);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KToolbarButtonFontStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KToolbarButtonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static FlutterSDK.Widgets.Textselection.TextSelectionControls CupertinoTextSelectionControls = default(FlutterSDK.Widgets.Textselection.TextSelectionControls);
    }

    /// <Summary>
    /// An iOS-style toolbar that appears in response to text selection.
    ///
    /// Typically displays buttons for text manipulation, e.g. copying and pasting text.
    ///
    /// See also:
    ///
    ///  * [TextSelectionControls.buildToolbar], where [CupertinoTextSelectionToolbar]
    ///    will be used to build an iOS-style toolbar.
    /// </Summary>
    public class CupertinoTextSelectionToolbar : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        internal CupertinoTextSelectionToolbar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double barTopY = default(double), double arrowTipX = default(double), bool isArrowPointingDown = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }
        internal virtual double _BarTopY { get; set; }
        internal virtual double _ArrowTipX { get; set; }
        internal virtual bool _IsArrowPointingDown { get; set; }

        public new FlutterSDK.Cupertino.Textselection._ToolbarRenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new _ToolbarRenderBox(_BarTopY, _ArrowTipX, _IsArrowPointingDown, null);



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Textselection._ToolbarRenderBox renderObject)
        {
            ..BarTopY = _BarTopY..ArrowTipX = _ArrowTipX..IsArrowPointingDown = _IsArrowPointingDown;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..BarTopY = _BarTopY..ArrowTipX = _ArrowTipX..IsArrowPointingDown = _IsArrowPointingDown;
        }



    }


    public class _ToolbarParentData : FlutterSDK.Rendering.Box.BoxParentData
    {
        public _ToolbarParentData()
        { }
        public virtual double ArrowXOffsetFromCenter { get; set; }

    }


    public class _ToolbarRenderBox : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        public _ToolbarRenderBox(double _barTopY, double _arrowTipX, bool _isArrowPointingDown, FlutterSDK.Rendering.Box.RenderBox child)
        : base(child)
        {
            this._BarTopY = _barTopY;
            this._ArrowTipX = _arrowTipX;
            this._IsArrowPointingDown = _isArrowPointingDown;
        }
        internal virtual double _BarTopY { get; set; }
        internal virtual double _ArrowTipX { get; set; }
        internal virtual bool _IsArrowPointingDown { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints HeightConstraint { get; set; }
        internal virtual SKPaint _DebugPaint { get; set; }
        public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double BarTopY { set { throw new NotImplementedException(); } }
        public virtual double ArrowTipX { set { throw new NotImplementedException(); } }
        public virtual bool IsArrowPointingDown { set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is _ToolbarParentData))
            {
                ((_ToolbarParentData)child.ParentData) = new _ToolbarParentData();
            }

        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            Size = constraints.Biggest;
            if (Child == null)
            {
                return;
            }

            BoxConstraints enforcedConstraint = constraints.Deflate(EdgeInsets.Symmetric(horizontal: TextselectionDefaultClass._KToolbarScreenPadding)).Loosen();
            Child.Layout(HeightConstraint.Enforce(enforcedConstraint), parentUsesSize: true);
            _ToolbarParentData childParentData = Child.ParentData as _ToolbarParentData;
            double lowerBound = Child.Size.Width / 2 + TextselectionDefaultClass._KToolbarScreenPadding;
            double upperBound = Size.Width - Child.Size.Width / 2 - TextselectionDefaultClass._KToolbarScreenPadding;
            double adjustedCenterX = _ArrowTipX.Clamp(lowerBound, upperBound) as double;
            childParentData.Offset = new Offset(adjustedCenterX - Child.Size.Width / 2, _BarTopY);
            childParentData.ArrowXOffsetFromCenter = _ArrowTipX - adjustedCenterX;
        }




        private Path _ClipPath()
        {
            _ToolbarParentData childParentData = Child.ParentData as _ToolbarParentData;
            Path rrect = new Path();
            new Path().AddRRect(RRect.FromRectAndRadius(new Offset(0, _IsArrowPointingDown ? 0 : TextselectionDefaultClass._KToolbarArrowSize.Height) & new Size(Child.Size.Width, Child.Size.Height - TextselectionDefaultClass._KToolbarArrowSize.Height), TextselectionDefaultClass._KToolbarBorderRadius));
            double arrowTipX = Child.Size.Width / 2 + childParentData.ArrowXOffsetFromCenter;
            double arrowBottomY = _IsArrowPointingDown ? Child.Size.Height - TextselectionDefaultClass._KToolbarArrowSize.Height : TextselectionDefaultClass._KToolbarArrowSize.Height;
            double arrowTipY = _IsArrowPointingDown ? Child.Size.Height : 0;
            Path arrow = new Path();
            new Path().MoveTo(arrowTipX, arrowTipY);
            new Path().LineTo(arrowTipX - TextselectionDefaultClass._KToolbarArrowSize.Width / 2, arrowBottomY);
            new Path().LineTo(arrowTipX + TextselectionDefaultClass._KToolbarArrowSize.Width / 2, arrowBottomY);
            new Path().Close();
            return Dart.UI.UiDefaultClass.Path.Combine(PathOperation.Union, rrect, arrow);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (Child == null)
            {
                return;
            }

            _ToolbarParentData childParentData = Child.ParentData as _ToolbarParentData;
            context.PushClipPath(NeedsCompositing, offset + childParentData.Offset, Dart.UI.UiDefaultClass.Offset.Zero & Child.Size, _ClipPath(), (PaintingContext innerContext, Offset innerOffset) => =>innerContext.PaintChild(Child, innerOffset));
        }




        public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {

        }



    }


    /// <Summary>
    /// Draws a single text selection handle with a bar and a ball.
    /// </Summary>
    public class _TextSelectionHandlePainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _TextSelectionHandlePainter(FlutterBinding.UI.Color color)
        {
            this.Color = color;
        }
        public virtual FlutterBinding.UI.Color Color { get; set; }

        public new void Paint(Canvas canvas, Size size)
        {
            double halfStrokeWidth = 1.0;
            Paint paint = new Paint()..Color = Color;
            Rect circle = Rect.FromCircle(center: new Offset(TextselectionDefaultClass._KSelectionHandleRadius, TextselectionDefaultClass._KSelectionHandleRadius), radius: TextselectionDefaultClass._KSelectionHandleRadius);
            Rect line = Rect.FromPoints(new Offset(TextselectionDefaultClass._KSelectionHandleRadius - halfStrokeWidth, 2 * TextselectionDefaultClass._KSelectionHandleRadius - TextselectionDefaultClass._KSelectionHandleOverlap), new Offset(TextselectionDefaultClass._KSelectionHandleRadius + halfStrokeWidth, size.Height));
            Path path = new Path();
            new Path().AddOval(circle);
            new Path().AddRect(line);
            canvas.DrawPath(path, paint);
        }




        public new bool ShouldRepaint(FlutterSDK.Cupertino.Textselection._TextSelectionHandlePainter oldPainter) => Color != oldPainter.Color;

        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate) => Color != oldPainter.Color;


    }


    public class _CupertinoTextSelectionControls : FlutterSDK.Widgets.Textselection.TextSelectionControls
    {
        public _CupertinoTextSelectionControls()
        { }

        /// <Summary>
        /// Returns the size of the Cupertino handle.
        /// </Summary>
        public new Size GetHandleSize(double textLineHeight)
        {
            return new Size(TextselectionDefaultClass._KSelectionHandleRadius * 2, textLineHeight + TextselectionDefaultClass._KSelectionHandleRadius * 2 - TextselectionDefaultClass._KSelectionHandleOverlap);
        }




        /// <Summary>
        /// Builder for iOS-style copy/paste text selection toolbar.
        /// </Summary>
        public new FlutterSDK.Widgets.Framework.Widget BuildToolbar(FlutterSDK.Widgets.Framework.BuildContext context, FlutterBinding.UI.Rect globalEditableRegion, double textLineHeight, FlutterBinding.UI.Offset position, List<FlutterSDK.Rendering.Editable.TextSelectionPoint> endpoints, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {

            MediaQueryData mediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context);
            double toolbarHeightNeeded = mediaQuery.Padding.Top + TextselectionDefaultClass._KToolbarScreenPadding + TextselectionDefaultClass._KToolbarHeight + TextselectionDefaultClass._KToolbarContentDistance;
            double availableHeight = globalEditableRegion.Top + endpoints.First.Point.Dy - textLineHeight;
            bool isArrowPointingDown = toolbarHeightNeeded <= availableHeight;
            double arrowTipX = (position.Dx + globalEditableRegion.Left).Clamp(TextselectionDefaultClass._KArrowScreenPadding + mediaQuery.Padding.Left, mediaQuery.Size.Width - mediaQuery.Padding.Right - TextselectionDefaultClass._KArrowScreenPadding) as double;
            double localBarTopY = isArrowPointingDown ? endpoints.First.Point.Dy - textLineHeight - TextselectionDefaultClass._KToolbarContentDistance - TextselectionDefaultClass._KToolbarHeight : endpoints.Last().Point.Dy + TextselectionDefaultClass._KToolbarContentDistance;
            List<Widget> items = new List<Widget>() { };
            Widget onePhysicalPixelVerticalDivider = new SizedBox(width: 1.0 / MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio);
            CupertinoLocalizations localizations = LocalizationsDefaultClass.CupertinoLocalizations.Of(context);
            EdgeInsets arrowPadding = isArrowPointingDown ? EdgeInsets.Only(bottom: TextselectionDefaultClass._KToolbarArrowSize.Height) : EdgeInsets.Only(top: TextselectionDefaultClass._KToolbarArrowSize.Height);
            void AddToolbarButtonIfNeeded(string text, Func<TextSelectionDelegate, bool> predicate, Action<TextSelectionDelegate> onPressed)
            {
                if (!predicate(delegate))
                {
                    return;
                }

                if (items.IsNotEmpty)
                {
                    items.Add(onePhysicalPixelVerticalDivider);
                }

                items.Add(new CupertinoButton(child: new Text(text, style: TextselectionDefaultClass._KToolbarButtonFontStyle), color: TextselectionDefaultClass._KToolbarBackgroundColor, minSize: TextselectionDefaultClass._KToolbarHeight, padding: TextselectionDefaultClass._KToolbarButtonPadding.Add(arrowPadding), borderRadius: null, pressedOpacity: 0.7, onPressed: () => =>onPressed(delegate)));
            }

            AddToolbarButtonIfNeeded(localizations.CutButtonLabel, CanCut, HandleCut);
            AddToolbarButtonIfNeeded(localizations.CopyButtonLabel, CanCopy, HandleCopy);
            AddToolbarButtonIfNeeded(localizations.PasteButtonLabel, CanPaste, HandlePaste);
            AddToolbarButtonIfNeeded(localizations.SelectAllButtonLabel, CanSelectAll, HandleSelectAll);
            return CupertinoTextSelectionToolbar._(barTopY: localBarTopY + globalEditableRegion.Top, arrowTipX: arrowTipX, isArrowPointingDown: isArrowPointingDown, child: items.IsEmpty() ? null : new DecoratedBox(decoration: new BoxDecoration(color: TextselectionDefaultClass._KToolbarDividerColor), child: new Row(mainAxisSize: MainAxisSize.Min, children: items)));
        }




        /// <Summary>
        /// Builder for iOS text selection edges.
        /// </Summary>
        public new FlutterSDK.Widgets.Framework.Widget BuildHandle(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight)
        {
            Size desiredSize = GetHandleSize(textLineHeight);
            Widget handle = SizedBox.FromSize(size: desiredSize, child: new CustomPaint(painter: new _TextSelectionHandlePainter(ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor)));
            switch (type)
            {
                case TextSelectionHandleType.Left: return handle;
                case TextSelectionHandleType.Right:
                    return new Transform(transform: Matrix4.Identity();
                    Matrix4.Identity().Translate(desiredSize.Width / 2, desiredSize.Height / 2);
                    Matrix4.Identity().RotateZ(Math.Dart.MathDefaultClass.Pi);
                    Matrix4.Identity().Translate(-desiredSize.Width / 2, -desiredSize.Height / 2), child: handle);
                case TextSelectionHandleType.Collapsed: return new SizedBox();
            }

            return null;
        }




        /// <Summary>
        /// Gets anchor for cupertino-style text selection handles.
        ///
        /// See [TextSelectionControls.getHandleAnchor].
        /// </Summary>
        public new Offset GetHandleAnchor(FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight)
        {
            Size handleSize = GetHandleSize(textLineHeight);
            switch (type) { case TextSelectionHandleType.Left: return new Offset(handleSize.Width / 2, handleSize.Height); case TextSelectionHandleType.Right: return new Offset(handleSize.Width / 2, handleSize.Height - 2 * TextselectionDefaultClass._KSelectionHandleRadius + TextselectionDefaultClass._KSelectionHandleOverlap); default: return new Offset(handleSize.Width / 2, textLineHeight + (handleSize.Height - textLineHeight) / 2); }
        }



    }

}
