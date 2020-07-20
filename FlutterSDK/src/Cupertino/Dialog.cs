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
namespace FlutterSDK.Cupertino.Dialog
{
    internal static class DialogDefaultClass
    {
        public static FlutterSDK.Painting.Textstyle.TextStyle _KCupertinoDialogTitleStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KCupertinoDialogContentStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KCupertinoDialogActionStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static double _KCupertinoDialogWidth = default(double);
        public static double _KAccessibilityCupertinoDialogWidth = default(double);
        public static double _KBlurAmount = default(double);
        public static double _KEdgePadding = default(double);
        public static double _KMinButtonHeight = default(double);
        public static double _KMinButtonFontSize = default(double);
        public static double _KDialogCornerRadius = default(double);
        public static double _KDividerThickness = default(double);
        public static Color _KDialogColor = default(Color);
        public static Color _KDialogPressedColor = default(Color);
        public static double _KMaxRegularTextScaleFactor = default(double);
        internal static bool _IsInAccessibilityMode(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            MediaQueryData data = MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true);
            return data != null && data.TextScaleFactor > DialogDefaultClass._KMaxRegularTextScaleFactor;
        }



    }

    /// <Summary>
    /// An iOS-style alert dialog.
    ///
    /// An alert dialog informs the user about situations that require
    /// acknowledgement. An alert dialog has an optional title, optional content,
    /// and an optional list of actions. The title is displayed above the content
    /// and the actions are displayed below the content.
    ///
    /// This dialog styles its title and content (typically a message) to match the
    /// standard iOS title and message dialog text style. These default styles can
    /// be overridden by explicitly defining [TextStyle]s for [Text] widgets that
    /// are part of the title or content.
    ///
    /// To display action buttons that look like standard iOS dialog buttons,
    /// provide [CupertinoDialogAction]s for the [actions] given to this dialog.
    ///
    /// Typically passed as the child widget to [showDialog], which displays the
    /// dialog.
    ///
    /// See also:
    ///
    ///  * [CupertinoPopupSurface], which is a generic iOS-style popup surface that
    ///    holds arbitrary content to create custom popups.
    ///  * [CupertinoDialogAction], which is an iOS-style dialog button.
    ///  * [AlertDialog], a Material Design alert dialog.
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/views/alerts/>
    /// </Summary>
    public class CupertinoAlertDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoAlertDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollcontroller.ScrollController actionScrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), TimeSpan insetAnimationDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve insetAnimationCurve = default(FlutterSDK.Animation.Curves.Curve))
        : base(key: key)
        {
            this.Title = title;
            this.Content = content;
            this.Actions = actions;
            this.ScrollController = scrollController;
            this.ActionScrollController = actionScrollController;
            this.InsetAnimationDuration = insetAnimationDuration;
            this.InsetAnimationCurve = insetAnimationCurve;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ActionScrollController { get; set; }
        public virtual TimeSpan InsetAnimationDuration { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve InsetAnimationCurve { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Framework.Widget _BuildContent(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> children = new List<Widget>() { };
            return new Container(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogColor, context), child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: children));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildActions()
        {
            Widget actionSection = new Container(height: 0.0);
            if (Actions.IsNotEmpty)
            {
                actionSection = new _CupertinoAlertActionSection(children: Actions, scrollController: ActionScrollController);
            }

            return actionSection;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            CupertinoLocalizations localizations = LocalizationsDefaultClass.CupertinoLocalizations.Of(context);
            bool isInAccessibilityMode = DialogDefaultClass._IsInAccessibilityMode(context);
            double textScaleFactor = MediaqueryDefaultClass.MediaQuery.Of(context).TextScaleFactor;
            return new CupertinoUserInterfaceLevel(data: CupertinoUserInterfaceLevelData.Elevated, child: new MediaQuery(data: MediaqueryDefaultClass.MediaQuery.Of(context).CopyWith(textScaleFactor: Math.Dart:mathDefaultClass.Max(textScaleFactor, 1.0)), child: new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
            {
                return new AnimatedPadding(padding: MediaqueryDefaultClass.MediaQuery.Of(context).ViewInsets + EdgeInsets.Symmetric(horizontal: 40.0, vertical: 24.0), duration: InsetAnimationDuration, curve: InsetAnimationCurve, child: MediaQuery.RemoveViewInsets(removeLeft: true, removeTop: true, removeRight: true, removeBottom: true, context: context, child: new Center(child: new Container(margin: EdgeInsets.Symmetric(vertical: DialogDefaultClass._KEdgePadding), width: isInAccessibilityMode ? DialogDefaultClass._KAccessibilityCupertinoDialogWidth : DialogDefaultClass._KCupertinoDialogWidth, child: new CupertinoPopupSurface(isSurfacePainted: false, child: new Semantics(namesRoute: true, scopesRoute: true, explicitChildNodes: true, label: localizations.AlertDialogLabel, child: new _CupertinoDialogRenderWidget(contentSection: _BuildContent(context), actionsSection: _BuildActions())))))));
            }
            )));
        }



        #endregion
    }


    /// <Summary>
    /// An iOS-style dialog.
    ///
    /// This dialog widget does not have any opinion about the contents of the
    /// dialog. Rather than using this widget directly, consider using
    /// [CupertinoAlertDialog], which implement a specific kind of dialog.
    ///
    /// Push with `Navigator.of(..., rootNavigator: true)` when using with
    /// [CupertinoTabScaffold] to ensure that the dialog appears above the tabs.
    ///
    /// See also:
    ///
    ///  * [CupertinoAlertDialog], which is a dialog with title, contents, and
    ///    actions.
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/views/alerts/>
    /// </Summary>
    public class CupertinoDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Center(child: new SizedBox(width: DialogDefaultClass._KCupertinoDialogWidth, child: new CupertinoPopupSurface(child: Child)));
        }



        #endregion
    }


    /// <Summary>
    /// Rounded rectangle surface that looks like an iOS popup surface, e.g., alert dialog
    /// and action sheet.
    ///
    /// A [CupertinoPopupSurface] can be configured to paint or not paint a white
    /// color on top of its blurred area. Typical usage should paint white on top
    /// of the blur. However, the white paint can be disabled for the purpose of
    /// rendering divider gaps for a more complicated layout, e.g., [CupertinoAlertDialog].
    /// Additionally, the white paint can be disabled to render a blurred rounded
    /// rectangle without any color (similar to iOS's volume control popup).
    ///
    /// See also:
    ///
    ///  * [CupertinoAlertDialog], which is a dialog with a title, content, and
    ///    actions.
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/views/alerts/>
    /// </Summary>
    public class CupertinoPopupSurface : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoPopupSurface(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool isSurfacePainted = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.IsSurfacePainted = isSurfacePainted;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual bool IsSurfacePainted { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new ClipRRect(borderRadius: BorderRadius.Circular(DialogDefaultClass._KDialogCornerRadius), child: new BackdropFilter(filter: ImageFilter.Blur(sigmaX: DialogDefaultClass._KBlurAmount, sigmaY: DialogDefaultClass._KBlurAmount), child: new Container(color: IsSurfacePainted ? ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogColor, context) : null, child: Child)));
        }



        #endregion
    }


    public class _CupertinoDialogRenderWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public _CupertinoDialogRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget contentSection = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget actionsSection = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.ContentSection = contentSection;
            this.ActionsSection = actionsSection;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget ContentSection { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget ActionsSection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderCupertinoDialog(dividerThickness: DialogDefaultClass._KDividerThickness / MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio, isInAccessibilityMode: DialogDefaultClass._IsInAccessibilityMode(context), dividerColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.Separator, context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Dialog._RenderCupertinoDialog renderObject)
        {
            ..IsInAccessibilityMode = DialogDefaultClass._IsInAccessibilityMode(context)..DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.Separator, context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..IsInAccessibilityMode = DialogDefaultClass._IsInAccessibilityMode(context)..DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.Separator, context);
        }




        public new FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement()
        {
            return new _CupertinoDialogRenderElement(this);
        }



        #endregion
    }


    public class _CupertinoDialogRenderElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public _CupertinoDialogRenderElement(FlutterSDK.Cupertino.Dialog._CupertinoDialogRenderWidget widget)
        : base(widget)
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Element _ContentElement { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _ActionsElement { get; set; }
        public virtual FlutterSDK.Cupertino.Dialog._CupertinoDialogRenderWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Cupertino.Dialog._RenderCupertinoDialog RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            if (_ContentElement != null)
            {
                visitor(_ContentElement);
            }

            if (_ActionsElement != null)
            {
                visitor(_ActionsElement);
            }

        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _ContentElement = UpdateChild(_ContentElement, Widget.ContentSection, _AlertDialogSections.ContentSection);
            _ActionsElement = UpdateChild(_ActionsElement, Widget.ActionsSection, _AlertDialogSections.ActionsSection);
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Cupertino.Dialog._AlertDialogSections slot)
        {

            switch (slot) { case _AlertDialogSections.ContentSection: RenderObject.ContentSection = child as RenderBox; break; case _AlertDialogSections.ActionsSection: RenderObject.ActionsSection = child as RenderBox; break; }
        }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

            switch (slot) { case _AlertDialogSections.ContentSection: RenderObject.ContentSection = child as RenderBox; break; case _AlertDialogSections.ActionsSection: RenderObject.ActionsSection = child as RenderBox; break; }
        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Cupertino.Dialog._AlertDialogSections slot)
        {

        }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

        }




        public new void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget)
        {
            base.Update(newWidget);
            _ContentElement = UpdateChild(_ContentElement, Widget.ContentSection, _AlertDialogSections.ContentSection);
            _ActionsElement = UpdateChild(_ActionsElement, Widget.ActionsSection, _AlertDialogSections.ActionsSection);
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);
            _ContentElement = UpdateChild(_ContentElement, Widget.ContentSection, _AlertDialogSections.ContentSection);
            _ActionsElement = UpdateChild(_ActionsElement, Widget.ActionsSection, _AlertDialogSections.ActionsSection);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            if (_ContentElement == child)
            {
                _ContentElement = null;
            }
            else
            {

                _ActionsElement = null;
            }

            base.ForgetChild(child);
        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {

            if (RenderObject.ContentSection == child)
            {
                RenderObject.ContentSection = null;
            }
            else
            {

                RenderObject.ActionsSection = null;
            }

        }



        #endregion
    }


    public class _RenderCupertinoDialog : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public _RenderCupertinoDialog(FlutterSDK.Rendering.Box.RenderBox contentSection = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Box.RenderBox actionsSection = default(FlutterSDK.Rendering.Box.RenderBox), double dividerThickness = 0.0, bool isInAccessibilityMode = false, FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color))
        : base()
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Box.RenderBox _ContentSection { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _ActionsSection { get; set; }
        internal virtual bool _IsInAccessibilityMode { get; set; }
        internal virtual double _DividerThickness { get; set; }
        internal virtual SKPaint _DividerPaint { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox ContentSection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox ActionsSection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsInAccessibilityMode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _DialogWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DividerColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            if (null != ContentSection)
            {
                ContentSection.Attach(owner);
            }

            if (null != ActionsSection)
            {
                ActionsSection.Attach(owner);
            }

        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            if (null != ContentSection)
            {
                ContentSection.Attach(owner);
            }

            if (null != ActionsSection)
            {
                ActionsSection.Attach(owner);
            }

        }




        public new void Detach()
        {
            base.Detach();
            if (null != ContentSection)
            {
                ContentSection.Detach();
            }

            if (null != ActionsSection)
            {
                ActionsSection.Detach();
            }

        }




        public new void RedepthChildren()
        {
            if (null != ContentSection)
            {
                RedepthChild(ContentSection);
            }

            if (null != ActionsSection)
            {
                RedepthChild(ActionsSection);
            }

        }




        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is BoxParentData))
            {
                ((BoxParentData)child.ParentData) = new BoxParentData();
            }

        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is BoxParentData))
            {
                ((BoxParentData)child.ParentData) = new BoxParentData();
            }

        }




        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            if (ContentSection != null)
            {
                visitor(ContentSection);
            }

            if (ActionsSection != null)
            {
                visitor(ActionsSection);
            }

        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() => new List<DiagnosticsNode>() { };



        public new double ComputeMinIntrinsicWidth(double height)
        {
            return _DialogWidth;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return _DialogWidth;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double contentHeight = ContentSection.GetMinIntrinsicHeight(width);
            double actionsHeight = ActionsSection.GetMinIntrinsicHeight(width);
            bool hasDivider = contentHeight > 0.0 && actionsHeight > 0.0;
            double height = contentHeight + (hasDivider ? _DividerThickness : 0.0) + actionsHeight;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            double contentHeight = ContentSection.GetMaxIntrinsicHeight(width);
            double actionsHeight = ActionsSection.GetMaxIntrinsicHeight(width);
            bool hasDivider = contentHeight > 0.0 && actionsHeight > 0.0;
            double height = contentHeight + (hasDivider ? _DividerThickness : 0.0) + actionsHeight;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new void PerformLayout()
        {
            if (IsInAccessibilityMode)
            {
                PerformAccessibilityLayout();
            }
            else
            {
                PerformRegularLayout();
            }

        }




        public virtual void PerformRegularLayout()
        {
            bool hasDivider = ContentSection.GetMaxIntrinsicHeight(_DialogWidth) > 0.0 && ActionsSection.GetMaxIntrinsicHeight(_DialogWidth) > 0.0;
            double dividerThickness = hasDivider ? _DividerThickness : 0.0;
            double minActionsHeight = ActionsSection.GetMinIntrinsicHeight(_DialogWidth);
            ContentSection.Layout(Constraints.Deflate(EdgeInsets.Only(bottom: minActionsHeight + dividerThickness)), parentUsesSize: true);
            Size contentSize = ContentSection.Size;
            ActionsSection.Layout(Constraints.Deflate(EdgeInsets.Only(top: contentSize.Height + dividerThickness)), parentUsesSize: true);
            Size actionsSize = ActionsSection.Size;
            double dialogHeight = contentSize.Height + dividerThickness + actionsSize.Height;
            Size = Constraints.Constrain(new Size(_DialogWidth, dialogHeight));

            BoxParentData actionParentData = ActionsSection.ParentData as BoxParentData;
            actionParentData.Offset = new Offset(0.0, contentSize.Height + dividerThickness);
        }




        public virtual void PerformAccessibilityLayout()
        {
            bool hasDivider = ContentSection.GetMaxIntrinsicHeight(_DialogWidth) > 0.0 && ActionsSection.GetMaxIntrinsicHeight(_DialogWidth) > 0.0;
            double dividerThickness = hasDivider ? _DividerThickness : 0.0;
            double maxContentHeight = ContentSection.GetMaxIntrinsicHeight(_DialogWidth);
            double maxActionsHeight = ActionsSection.GetMaxIntrinsicHeight(_DialogWidth);
            Size contentSize = default(Size);
            Size actionsSize = default(Size);
            if (maxContentHeight + dividerThickness + maxActionsHeight > Constraints.MaxHeight)
            {
                ActionsSection.Layout(Constraints.Deflate(EdgeInsets.Only(top: Constraints.MaxHeight / 2.0)), parentUsesSize: true);
                actionsSize = ActionsSection.Size;
                ContentSection.Layout(Constraints.Deflate(EdgeInsets.Only(bottom: actionsSize.Height + dividerThickness)), parentUsesSize: true);
                contentSize = ContentSection.Size;
            }
            else
            {
                ContentSection.Layout(Constraints, parentUsesSize: true);
                contentSize = ContentSection.Size;
                ActionsSection.Layout(Constraints.Deflate(EdgeInsets.Only(top: contentSize.Height)), parentUsesSize: true);
                actionsSize = ActionsSection.Size;
            }

            double dialogHeight = contentSize.Height + dividerThickness + actionsSize.Height;
            Size = Constraints.Constrain(new Size(_DialogWidth, dialogHeight));

            BoxParentData actionParentData = ActionsSection.ParentData as BoxParentData;
            actionParentData.Offset = new Offset(0.0, contentSize.Height + dividerThickness);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            BoxParentData contentParentData = ContentSection.ParentData as BoxParentData;
            ContentSection.Paint(context, offset + contentParentData.Offset);
            bool hasDivider = ContentSection.Size.Height > 0.0 && ActionsSection.Size.Height > 0.0;
            if (hasDivider)
            {
                _PaintDividerBetweenContentAndActions(context.Canvas, offset);
            }

            BoxParentData actionsParentData = ActionsSection.ParentData as BoxParentData;
            ActionsSection.Paint(context, offset + actionsParentData.Offset);
        }




        private void _PaintDividerBetweenContentAndActions(Canvas canvas, FlutterBinding.UI.Offset offset)
        {
            canvas.DrawRect(Rect.FromLTWH(offset.Dx, offset.Dy + ContentSection.Size.Height, Size.Width, _DividerThickness), _DividerPaint);
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            BoxParentData contentSectionParentData = ContentSection.ParentData as BoxParentData;
            BoxParentData actionsSectionParentData = ActionsSection.ParentData as BoxParentData;
            return result.AddWithPaintOffset(offset: contentSectionParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
            {

                return ContentSection.HitTest(result, position: transformed);
            }
            ) || result.AddWithPaintOffset(offset: actionsSectionParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
            {

                return ActionsSection.HitTest(result, position: transformed);
            }
            );
        }



        #endregion
    }


    public class _CupertinoAlertContentSection : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _CupertinoAlertContentSection(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController))
        : base(key: key)
        {
            this.Title = title;
            this.Content = content;
            this.ScrollController = scrollController;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (Title == null && Content == null)
            {
                return new SingleChildScrollView(controller: ScrollController, child: new Container(width: 0.0, height: 0.0));
            }

            double textScaleFactor = MediaqueryDefaultClass.MediaQuery.Of(context).TextScaleFactor;
            List<Widget> titleContentGroup = new List<Widget>() { };
            return new CupertinoScrollbar(child: new SingleChildScrollView(controller: ScrollController, child: new Column(mainAxisSize: MainAxisSize.Max, crossAxisAlignment: CrossAxisAlignment.Stretch, children: titleContentGroup)));
        }



        #endregion
    }


    public class _CupertinoAlertActionSection : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _CupertinoAlertActionSection(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController))
        : base(key: key)
        {
            this.Children = children;
            this.ScrollController = scrollController;
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Dialog._CupertinoAlertActionSectionState CreateState() => new _CupertinoAlertActionSectionState();


        #endregion
    }


    public class _CupertinoAlertActionSectionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Dialog._CupertinoAlertActionSection>
    {
        #region constructors
        public _CupertinoAlertActionSectionState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            double devicePixelRatio = MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio;
            List<Widget> interactiveButtons = new List<Widget>() { };
            for (int i = 0; i < Widget.Children.Count; i += 1)
            {
                interactiveButtons.Add(new _PressableActionButton(child: Widget.Children[i]));
            }

            return new CupertinoScrollbar(child: new SingleChildScrollView(controller: Widget.ScrollController, child: new _CupertinoDialogActionsRenderWidget(actionButtons: interactiveButtons, dividerThickness: DialogDefaultClass._KDividerThickness / devicePixelRatio)));
        }



        #endregion
    }


    public class _PressableActionButton : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _PressableActionButton(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Dialog._PressableActionButtonState CreateState() => new _PressableActionButtonState();


        #endregion
    }


    public class _PressableActionButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Dialog._PressableActionButton>
    {
        #region constructors
        public _PressableActionButtonState()
        { }
        #endregion

        #region fields
        internal virtual bool _IsPressed { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _ActionButtonParentDataWidget(isPressed: _IsPressed, child: new MergeSemantics(child: new GestureDetector(excludeFromSemantics: true, behavior: HitTestBehavior.Opaque, onTapDown: (TapDownDetails details) => =>SetState(() =>
            {
                _IsPressed = true;
            }
            ), onTapUp: (TapUpDetails details) => =>SetState(() =>
            {
                _IsPressed = false;
            }
            ), onTapCancel: () => =>SetState(() => =>_IsPressed = false), child: Widget.Child)));
        }



        #endregion
    }


    public class _ActionButtonParentDataWidget : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Cupertino.Dialog._ActionButtonParentData>
    {
        #region constructors
        public _ActionButtonParentDataWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool isPressed = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.IsPressed = isPressed;
        }
        #endregion

        #region fields
        public virtual bool IsPressed { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject)
        {

            _ActionButtonParentData parentData = renderObject.ParentData as _ActionButtonParentData;
            if (parentData.IsPressed != IsPressed)
            {
                parentData.IsPressed = IsPressed;
                AbstractNode targetParent = renderObject.Parent;
                if (((RenderObject)targetParent) is RenderObject) ((RenderObject)targetParent).MarkNeedsPaint();
            }

        }



        #endregion
    }


    public class _ActionButtonParentData : FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData
    {
        #region constructors
        public _ActionButtonParentData(bool isPressed = false)
        {
            this.IsPressed = isPressed;
        }
        #endregion

        #region fields
        public virtual bool IsPressed { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A button typically used in a [CupertinoAlertDialog].
    ///
    /// See also:
    ///
    ///  * [CupertinoAlertDialog], a dialog that informs the user about situations
    ///    that require acknowledgement.
    /// </Summary>
    public class CupertinoDialogAction : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoDialogAction(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), bool isDefaultAction = false, bool isDestructiveAction = false, FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPressed = onPressed;
            this.IsDefaultAction = isDefaultAction;
            this.IsDestructiveAction = isDestructiveAction;
            this.TextStyle = textStyle;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual VoidCallback OnPressed { get; set; }
        public virtual bool IsDefaultAction { get; set; }
        public virtual bool IsDestructiveAction { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private double _CalculatePadding(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return 8.0 * MediaqueryDefaultClass.MediaQuery.TextScaleFactorOf(context);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildContentWithRegularSizingPolicy(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget))
        {
            bool isInAccessibilityMode = DialogDefaultClass._IsInAccessibilityMode(context);
            double dialogWidth = isInAccessibilityMode ? DialogDefaultClass._KAccessibilityCupertinoDialogWidth : DialogDefaultClass._KCupertinoDialogWidth;
            double textScaleFactor = MediaqueryDefaultClass.MediaQuery.TextScaleFactorOf(context);
            double fontSizeRatio = (textScaleFactor * textStyle.FontSize) / DialogDefaultClass._KMinButtonFontSize;
            double padding = _CalculatePadding(context);
            return new IntrinsicHeight(child: new SizedBox(width: Dart:coreDefaultClass.Double.Infinity, child: new FittedBox(fit: BoxFit.ScaleDown, child: new ConstrainedBox(constraints: new BoxConstraints(maxWidth: fontSizeRatio * (dialogWidth - (2 * padding))), child: new Semantics(button: true, onTap: OnPressed, child: new DefaultTextStyle(style: textStyle, textAlign: TextAlign.Center, overflow: TextOverflow.Ellipsis, maxLines: 1, child: content))))));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildContentWithAccessibilitySizingPolicy(FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget))
        {
            return new DefaultTextStyle(style: textStyle, textAlign: TextAlign.Center, child: content);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            TextStyle style = DialogDefaultClass._KCupertinoDialogActionStyle.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(IsDestructiveAction ? ColorsDefaultClass.CupertinoColors.SystemRed : ColorsDefaultClass.CupertinoColors.SystemBlue, context));
            style = style.Merge(TextStyle);
            if (IsDefaultAction)
            {
                style = style.CopyWith(fontWeight: Dart:uiDefaultClass.FontWeight.W600);
            }

            if (!Enabled)
            {
                style = style.CopyWith(color: style.Color.WithOpacity(0.5));
            }

            Widget sizedContent = DialogDefaultClass._IsInAccessibilityMode(context) ? _BuildContentWithAccessibilitySizingPolicy(textStyle: style, content: Child) : _BuildContentWithRegularSizingPolicy(context: context, textStyle: style, content: Child);
            return new GestureDetector(excludeFromSemantics: true, onTap: OnPressed, behavior: HitTestBehavior.Opaque, child: new ConstrainedBox(constraints: new BoxConstraints(minHeight: DialogDefaultClass._KMinButtonHeight), child: new Container(alignment: AlignmentDefaultClass.Alignment.Center, padding: EdgeInsets.All(_CalculatePadding(context)), child: sizedContent)));
        }



        #endregion
    }


    public class _CupertinoDialogActionsRenderWidget : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public _CupertinoDialogActionsRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actionButtons = default(List<FlutterSDK.Widgets.Framework.Widget>), double dividerThickness = 0.0)
        : base(key: key, children: actionButtons)
        {

        }
        #endregion

        #region fields
        internal virtual double _DividerThickness { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderCupertinoDialogActions(dialogWidth: DialogDefaultClass._IsInAccessibilityMode(context) ? DialogDefaultClass._KAccessibilityCupertinoDialogWidth : DialogDefaultClass._KCupertinoDialogWidth, dividerThickness: _DividerThickness, dialogColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogColor, context), dialogPressedColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogPressedColor, context), dividerColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.Separator, context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Dialog._RenderCupertinoDialogActions renderObject)
        {
            ..DialogWidth = DialogDefaultClass._IsInAccessibilityMode(context) ? DialogDefaultClass._KAccessibilityCupertinoDialogWidth : DialogDefaultClass._KCupertinoDialogWidth..DividerThickness = _DividerThickness..DialogColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogColor, context)..DialogPressedColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogPressedColor, context)..DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.Separator, context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..DialogWidth = DialogDefaultClass._IsInAccessibilityMode(context) ? DialogDefaultClass._KAccessibilityCupertinoDialogWidth : DialogDefaultClass._KCupertinoDialogWidth..DividerThickness = _DividerThickness..DialogColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogColor, context)..DialogPressedColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(DialogDefaultClass._KDialogPressedColor, context)..DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.Separator, context);
        }



        #endregion
    }


    public class _RenderCupertinoDialogActions : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>
    {
        #region constructors
        public _RenderCupertinoDialogActions(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), double dialogWidth = default(double), double dividerThickness = 0.0, FlutterBinding.UI.Color dialogColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogPressedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color))
        : base()
        {

            AddAll(children);
        }


        #endregion

        #region fields
        internal virtual double _DialogWidth { get; set; }
        internal virtual double _DividerThickness { get; set; }
        internal virtual SKPaint _ButtonBackgroundPaint { get; set; }
        internal virtual SKPaint _PressedButtonBackgroundPaint { get; set; }
        internal virtual SKPaint _DividerPaint { get; set; }
        public virtual double DialogWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double DividerThickness { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DialogColor { set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DialogPressedColor { set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DividerColor { set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> _PressedButtons { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsButtonPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is _ActionButtonParentData)) child.ParentData = new _ActionButtonParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is _ActionButtonParentData)) child.ParentData = new _ActionButtonParentData();
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return DialogWidth;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return DialogWidth;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double minHeight = default(double);
            if (ChildCount == 0)
            {
                minHeight = 0.0;
            }
            else if (ChildCount == 1)
            {
                minHeight = _ComputeMinIntrinsicHeightSideBySide(width);
            }
            else
            {
                if (ChildCount == 2 && _IsSingleButtonRow(width))
                {
                    minHeight = _ComputeMinIntrinsicHeightSideBySide(width);
                }
                else
                {
                    minHeight = _ComputeMinIntrinsicHeightStacked(width);
                }

            }

            return minHeight;
        }




        private double _ComputeMinIntrinsicHeightSideBySide(double width)
        {

            double minHeight = default(double);
            if (ChildCount == 1)
            {
                minHeight = FirstChild.GetMinIntrinsicHeight(width);
            }
            else
            {
                double perButtonWidth = (width - DividerThickness) / 2.0;
                minHeight = Math.Dart:mathDefaultClass.Max(FirstChild.GetMinIntrinsicHeight(perButtonWidth), LastChild.GetMinIntrinsicHeight(perButtonWidth));
            }

            return minHeight;
        }




        private double _ComputeMinIntrinsicHeightStacked(double width)
        {

            return FirstChild.GetMinIntrinsicHeight(width) + DividerThickness + (0.5 * ChildAfter(FirstChild).GetMinIntrinsicHeight(width));
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            double maxHeight = default(double);
            if (ChildCount == 0)
            {
                maxHeight = 0.0;
            }
            else if (ChildCount == 1)
            {
                maxHeight = FirstChild.GetMaxIntrinsicHeight(width);
            }
            else if (ChildCount == 2)
            {
                if (_IsSingleButtonRow(width))
                {
                    double perButtonWidth = (width - DividerThickness) / 2.0;
                    maxHeight = Math.Dart:mathDefaultClass.Max(FirstChild.GetMaxIntrinsicHeight(perButtonWidth), LastChild.GetMaxIntrinsicHeight(perButtonWidth));
                }
                else
                {
                    maxHeight = _ComputeMaxIntrinsicHeightStacked(width);
                }

            }
            else
            {
                maxHeight = _ComputeMaxIntrinsicHeightStacked(width);
            }

            return maxHeight;
        }




        private double _ComputeMaxIntrinsicHeightStacked(double width)
        {

            double allDividersHeight = (ChildCount - 1) * DividerThickness;
            double heightAccumulation = allDividersHeight;
            RenderBox button = FirstChild;
            while (button != null)
            {
                heightAccumulation += button.GetMaxIntrinsicHeight(width);
                button = ChildAfter(button);
            }

            return heightAccumulation;
        }




        private bool _IsSingleButtonRow(double width)
        {
            bool isSingleButtonRow = default(bool);
            if (ChildCount == 1)
            {
                isSingleButtonRow = true;
            }
            else if (ChildCount == 2)
            {
                double sideBySideWidth = FirstChild.GetMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity) + DividerThickness + LastChild.GetMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity);
                isSingleButtonRow = sideBySideWidth <= width;
            }
            else
            {
                isSingleButtonRow = false;
            }

            return isSingleButtonRow;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            if (_IsSingleButtonRow(DialogWidth))
            {
                if (ChildCount == 1)
                {
                    FirstChild.Layout(constraints, parentUsesSize: true);
                    Size = constraints.Constrain(new Size(DialogWidth, FirstChild.Size.Height));
                }
                else
                {
                    BoxConstraints perButtonConstraints = new BoxConstraints(minWidth: (constraints.MinWidth - DividerThickness) / 2.0, maxWidth: (constraints.MaxWidth - DividerThickness) / 2.0, minHeight: 0.0, maxHeight: Dart:coreDefaultClass.Double.Infinity);
                    FirstChild.Layout(perButtonConstraints, parentUsesSize: true);
                    LastChild.Layout(perButtonConstraints, parentUsesSize: true);

                    MultiChildLayoutParentData secondButtonParentData = LastChild.ParentData as MultiChildLayoutParentData;
                    secondButtonParentData.Offset = new Offset(FirstChild.Size.Width + DividerThickness, 0.0);
                    Size = constraints.Constrain(new Size(DialogWidth, Math.Dart:mathDefaultClass.Max(FirstChild.Size.Height, LastChild.Size.Height)));
                }

            }
            else
            {
                BoxConstraints perButtonConstraints = constraints.CopyWith(minHeight: 0.0, maxHeight: Dart:coreDefaultClass.Double.Infinity);
                RenderBox child = FirstChild;
                int index = 0;
                double verticalOffset = 0.0;
                while (child != null)
                {
                    child.Layout(perButtonConstraints, parentUsesSize: true);

                    MultiChildLayoutParentData parentData = child.ParentData as MultiChildLayoutParentData;
                    parentData.Offset = new Offset(0.0, verticalOffset);
                    verticalOffset += child.Size.Height;
                    if (index < ChildCount - 1)
                    {
                        verticalOffset += DividerThickness;
                    }

                    index += 1;
                    child = ChildAfter(child);
                }

                Size = constraints.Constrain(new Size(DialogWidth, verticalOffset));
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            Canvas canvas = context.Canvas;
            if (_IsSingleButtonRow(Size.Width))
            {
                _DrawButtonBackgroundsAndDividersSingleRow(canvas, offset);
            }
            else
            {
                _DrawButtonBackgroundsAndDividersStacked(canvas, offset);
            }

            _DrawButtons(context, offset);
        }




        private void _DrawButtonBackgroundsAndDividersSingleRow(Canvas canvas, FlutterBinding.UI.Offset offset)
        {
            Rect verticalDivider = ChildCount == 2 && !_IsButtonPressed ? Rect.FromLTWH(offset.Dx + FirstChild.Size.Width, offset.Dy, DividerThickness, Math.Dart: mathDefaultClass.Max(FirstChild.Size.Height, LastChild.Size.Height)):Dart: uiDefaultClass.Rect.Zero;
            List<Rect> pressedButtonRects = _PressedButtons.Map((RenderBox pressedButton) =>
            {
                MultiChildLayoutParentData buttonParentData = pressedButton.ParentData as MultiChildLayoutParentData;
                return Rect.FromLTWH(offset.Dx + buttonParentData.Offset.Dx, offset.Dy + buttonParentData.Offset.Dy, pressedButton.Size.Width, pressedButton.Size.Height);
            }
            ).ToList();
            Path backgroundFillPath = new Path()..FillType = PathFillType.EvenOdd;
            new Path().AddRect(Rect.FromLTWH(0.0, 0.0, Size.Width, Size.Height));
            new Path().AddRect(verticalDivider);
            for (int i = 0; i < pressedButtonRects.Count; i += 1)
            {
                backgroundFillPath.AddRect(pressedButtonRects[i]);
            }

            canvas.DrawPath(backgroundFillPath, _ButtonBackgroundPaint);
            Path pressedBackgroundFillPath = new Path();
            for (int i = 0; i < pressedButtonRects.Count; i += 1)
            {
                pressedBackgroundFillPath.AddRect(pressedButtonRects[i]);
            }

            canvas.DrawPath(pressedBackgroundFillPath, _PressedButtonBackgroundPaint);
            Path dividersPath = new Path();
            new Path().AddRect(verticalDivider);
            canvas.DrawPath(dividersPath, _DividerPaint);
        }




        private void _DrawButtonBackgroundsAndDividersStacked(Canvas canvas, FlutterBinding.UI.Offset offset)
        {
            Offset dividerOffset = new Offset(0.0, DividerThickness);
            Path backgroundFillPath = new Path()..FillType = PathFillType.EvenOdd;
            new Path().AddRect(Rect.FromLTWH(0.0, 0.0, Size.Width, Size.Height));
            Path pressedBackgroundFillPath = new Path();
            Path dividersPath = new Path();
            Offset accumulatingOffset = offset;
            RenderBox child = FirstChild;
            RenderBox prevChild = default(RenderBox);
            while (child != null)
            {

                _ActionButtonParentData currentButtonParentData = child.ParentData as _ActionButtonParentData;
                bool isButtonPressed = currentButtonParentData.IsPressed;
                bool isPrevButtonPressed = false;
                if (prevChild != null)
                {

                    _ActionButtonParentData previousButtonParentData = prevChild.ParentData as _ActionButtonParentData;
                    isPrevButtonPressed = previousButtonParentData.IsPressed;
                }

                bool isDividerPresent = child != FirstChild;
                bool isDividerPainted = isDividerPresent && !(isButtonPressed || isPrevButtonPressed);
                Rect dividerRect = Rect.FromLTWH(accumulatingOffset.Dx, accumulatingOffset.Dy, Size.Width, DividerThickness);
                Rect buttonBackgroundRect = Rect.FromLTWH(accumulatingOffset.Dx, accumulatingOffset.Dy + (isDividerPresent ? DividerThickness : 0.0), Size.Width, child.Size.Height);
                if (isButtonPressed)
                {
                    backgroundFillPath.AddRect(buttonBackgroundRect);
                    pressedBackgroundFillPath.AddRect(buttonBackgroundRect);
                }

                if (isDividerPainted)
                {
                    backgroundFillPath.AddRect(dividerRect);
                    dividersPath.AddRect(dividerRect);
                }

                accumulatingOffset += (isDividerPresent ? dividerOffset : Dart:uiDefaultClass.Offset.Zero)+new Offset(0.0, child.Size.Height);
                prevChild = child;
                child = ChildAfter(child);
            }

            canvas.DrawPath(backgroundFillPath, _ButtonBackgroundPaint);
            canvas.DrawPath(pressedBackgroundFillPath, _PressedButtonBackgroundPaint);
            canvas.DrawPath(dividersPath, _DividerPaint);
        }




        private void _DrawButtons(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            RenderBox child = FirstChild;
            while (child != null)
            {
                MultiChildLayoutParentData childParentData = child.ParentData as MultiChildLayoutParentData;
                context.PaintChild(child, childParentData.Offset + offset);
                child = ChildAfter(child);
            }

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            return DefaultHitTestChildren(result, position: position);
        }



        #endregion
    }


    public enum _AlertDialogSections
    {

        ContentSection,
        ActionsSection,
    }

}
