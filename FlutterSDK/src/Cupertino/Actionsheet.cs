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
namespace FlutterSDK.Cupertino.Actionsheet
{
    internal static class ActionsheetDefaultClass
    {
        public static FlutterSDK.Painting.Textstyle.TextStyle _KActionSheetActionStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KActionSheetContentStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static Color _KBackgroundColor = default(Color);
        public static Color _KPressedColor = default(Color);
        public static Color _KCancelPressedColor = default(Color);
        public static Color _KContentTextColor = default(Color);
        public static Color _KButtonDividerColor = default(Color);
        public static double _KBlurAmount = default(double);
        public static double _KEdgeHorizontalPadding = default(double);
        public static double _KCancelButtonPadding = default(double);
        public static double _KEdgeVerticalPadding = default(double);
        public static double _KContentHorizontalPadding = default(double);
        public static double _KContentVerticalPadding = default(double);
        public static double _KButtonHeight = default(double);
        public static double _KCornerRadius = default(double);
        public static double _KDividerThickness = default(double);
    }

    /// <Summary>
    /// An iOS-style action sheet.
    ///
    /// An action sheet is a specific style of alert that presents the user
    /// with a set of two or more choices related to the current context.
    /// An action sheet can have a title, an additional message, and a list
    /// of actions. The title is displayed above the message and the actions
    /// are displayed below this content.
    ///
    /// This action sheet styles its title and message to match standard iOS action
    /// sheet title and message text style.
    ///
    /// To display action buttons that look like standard iOS action sheet buttons,
    /// provide [CupertinoActionSheetAction]s for the [actions] given to this action
    /// sheet.
    ///
    /// To include a iOS-style cancel button separate from the other buttons,
    /// provide an [CupertinoActionSheetAction] for the [cancelButton] given to this
    /// action sheet.
    ///
    /// An action sheet is typically passed as the child widget to
    /// [showCupertinoModalPopup], which displays the action sheet by sliding it up
    /// from the bottom of the screen.
    ///
    /// See also:
    ///
    ///  * [CupertinoActionSheetAction], which is an iOS-style action sheet button.
    ///  * <https://developer.apple.com/design/human-interface-guidelines/ios/views/action-sheets/>
    /// </Summary>
    public class CupertinoActionSheet : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoActionSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget message = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Scrollcontroller.ScrollController messageScrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollcontroller.ScrollController actionScrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Framework.Widget cancelButton = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Title = title;
            this.Message = message;
            this.Actions = actions;
            this.MessageScrollController = messageScrollController;
            this.ActionScrollController = actionScrollController;
            this.CancelButton = cancelButton;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Message { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController MessageScrollController { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ActionScrollController { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget CancelButton { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Framework.Widget _BuildContent(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> content = new List<Widget>() { };
            if (Title != null || Message != null)
            {
                Widget titleSection = new _CupertinoAlertContentSection(title: Title, message: Message, scrollController: MessageScrollController);
                content.Add(new Flexible(child: titleSection));
            }

            return new Container(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KBackgroundColor, context), child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: content));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildActions()
        {
            if (Actions == null || Actions.IsEmpty())
            {
                return new Container(height: 0.0);
            }

            return new Container(child: new _CupertinoAlertActionSection(children: Actions, scrollController: ActionScrollController, hasCancelButton: CancelButton != null));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildCancelButton()
        {
            double cancelPadding = (Actions != null || Message != null || Title != null) ? ActionsheetDefaultClass._KCancelButtonPadding : 0.0;
            return new Padding(padding: EdgeInsets.Only(top: cancelPadding), child: new _CupertinoActionSheetCancelButton(child: CancelButton));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> children = new List<Widget>() { new Flexible(child: new ClipRRect(borderRadius: BorderRadius.Circular(12.0), child: new BackdropFilter(filter: ImageFilter.Blur(sigmaX: ActionsheetDefaultClass._KBlurAmount, sigmaY: ActionsheetDefaultClass._KBlurAmount), child: new _CupertinoAlertRenderWidget(contentSection: new Builder(builder: _BuildContent), actionsSection: _BuildActions())))), };
            Orientation orientation = MediaqueryDefaultClass.MediaQuery.Of(context).Orientation;
            double actionSheetWidth = default(double);
            if (orientation == Orientation.Portrait)
            {
                actionSheetWidth = MediaqueryDefaultClass.MediaQuery.Of(context).Size.Width - (ActionsheetDefaultClass._KEdgeHorizontalPadding * 2);
            }
            else
            {
                actionSheetWidth = MediaqueryDefaultClass.MediaQuery.Of(context).Size.Height - (ActionsheetDefaultClass._KEdgeHorizontalPadding * 2);
            }

            return new SafeArea(child: new Semantics(namesRoute: true, scopesRoute: true, explicitChildNodes: true, label: "Alert", child: new CupertinoUserInterfaceLevel(data: CupertinoUserInterfaceLevelData.Elevated, child: new Container(width: actionSheetWidth, margin: EdgeInsets.Symmetric(horizontal: ActionsheetDefaultClass._KEdgeHorizontalPadding, vertical: ActionsheetDefaultClass._KEdgeVerticalPadding), child: new Column(children: children, mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch)))));
        }



        #endregion
    }


    /// <Summary>
    /// A button typically used in a [CupertinoActionSheet].
    ///
    /// See also:
    ///
    ///  * [CupertinoActionSheet], an alert that presents the user with a set of two or
    ///    more choices related to the current context.
    /// </Summary>
    public class CupertinoActionSheetAction : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public CupertinoActionSheetAction(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), bool isDefaultAction = false, bool isDestructiveAction = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPressed = onPressed;
            this.IsDefaultAction = isDefaultAction;
            this.IsDestructiveAction = isDestructiveAction;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual VoidCallback OnPressed { get; set; }
        public virtual bool IsDefaultAction { get; set; }
        public virtual bool IsDestructiveAction { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            TextStyle style = ActionsheetDefaultClass._KActionSheetActionStyle.CopyWith(color: IsDestructiveAction ? ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.SystemRed, context) : ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor);
            if (IsDefaultAction)
            {
                style = style.CopyWith(fontWeight: Dart:uiDefaultClass.FontWeight.W600);
            }

            return new GestureDetector(onTap: OnPressed, behavior: HitTestBehavior.Opaque, child: new ConstrainedBox(constraints: new BoxConstraints(minHeight: ActionsheetDefaultClass._KButtonHeight), child: new Semantics(button: true, child: new Container(alignment: AlignmentDefaultClass.Alignment.Center, padding: EdgeInsets.Symmetric(vertical: 16.0, horizontal: 10.0), child: new DefaultTextStyle(style: style, child: Child, textAlign: TextAlign.Center)))));
        }



        #endregion
    }


    public class _CupertinoActionSheetCancelButton : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _CupertinoActionSheetCancelButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Actionsheet._CupertinoActionSheetCancelButtonState CreateState() => new _CupertinoActionSheetCancelButtonState();


        #endregion
    }


    public class _CupertinoActionSheetCancelButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Actionsheet._CupertinoActionSheetCancelButton>
    {
        #region constructors
        public _CupertinoActionSheetCancelButtonState()
        { }
        #endregion

        #region fields
        public virtual bool IsBeingPressed { get; set; }
        #endregion

        #region methods

        private void _OnTapDown(FlutterSDK.Gestures.Tap.TapDownDetails @event)
        {
            SetState(() =>
            {
                IsBeingPressed = true;
            }
            );
        }




        private void _OnTapUp(FlutterSDK.Gestures.Tap.TapUpDetails @event)
        {
            SetState(() =>
            {
                IsBeingPressed = false;
            }
            );
        }




        private void _OnTapCancel()
        {
            SetState(() =>
            {
                IsBeingPressed = false;
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color backgroundColor = IsBeingPressed ? ActionsheetDefaultClass._KCancelPressedColor : ColorsDefaultClass.CupertinoColors.SecondarySystemGroupedBackground;
            return new GestureDetector(excludeFromSemantics: true, onTapDown: _OnTapDown, onTapUp: _OnTapUp, onTapCancel: _OnTapCancel, child: new Container(decoration: new BoxDecoration(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(backgroundColor, context), borderRadius: BorderRadius.Circular(ActionsheetDefaultClass._KCornerRadius)), child: Widget.Child));
        }



        #endregion
    }


    public class _CupertinoAlertRenderWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public _CupertinoAlertRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget contentSection = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget actionsSection = default(FlutterSDK.Widgets.Framework.Widget))
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
            return new _RenderCupertinoAlert(dividerThickness: ActionsheetDefaultClass._KDividerThickness / MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio, dividerColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KButtonDividerColor, context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Actionsheet._RenderCupertinoAlert renderObject)
        {
            base.UpdateRenderObject(context, renderObject);
            renderObject.DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KButtonDividerColor, context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            base.UpdateRenderObject(context, renderObject);
            renderObject.DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KButtonDividerColor, context);
        }




        public new FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement()
        {
            return new _CupertinoAlertRenderElement(this);
        }



        #endregion
    }


    public class _CupertinoAlertRenderElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public _CupertinoAlertRenderElement(FlutterSDK.Cupertino.Actionsheet._CupertinoAlertRenderWidget widget)
        : base(widget)
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.Element _ContentElement { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _ActionsElement { get; set; }
        public virtual FlutterSDK.Cupertino.Actionsheet._CupertinoAlertRenderWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Cupertino.Actionsheet._RenderCupertinoAlert RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
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
            _ContentElement = UpdateChild(_ContentElement, Widget.ContentSection, _AlertSections.ContentSection);
            _ActionsElement = UpdateChild(_ActionsElement, Widget.ActionsSection, _AlertSections.ActionsSection);
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Cupertino.Actionsheet._AlertSections slot)
        {
            _PlaceChildInSlot(child, slot);
        }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            _PlaceChildInSlot(child, slot);
        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Cupertino.Actionsheet._AlertSections slot)
        {
            _PlaceChildInSlot(child, slot);
        }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            _PlaceChildInSlot(child, slot);
        }




        public new void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget)
        {
            base.Update(newWidget);
            _ContentElement = UpdateChild(_ContentElement, Widget.ContentSection, _AlertSections.ContentSection);
            _ActionsElement = UpdateChild(_ActionsElement, Widget.ActionsSection, _AlertSections.ActionsSection);
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);
            _ContentElement = UpdateChild(_ContentElement, Widget.ContentSection, _AlertSections.ContentSection);
            _ActionsElement = UpdateChild(_ActionsElement, Widget.ActionsSection, _AlertSections.ActionsSection);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            if (_ContentElement == child)
            {
                _ContentElement = null;
            }
            else if (_ActionsElement == child)
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
            else if (RenderObject.ActionsSection == child)
            {
                RenderObject.ActionsSection = null;
            }

        }




        private void _PlaceChildInSlot(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Cupertino.Actionsheet._AlertSections slot)
        {

            switch (slot) { case _AlertSections.ContentSection: RenderObject.ContentSection = child as RenderBox; break; case _AlertSections.ActionsSection: RenderObject.ActionsSection = child as RenderBox; break; }
        }



        #endregion
    }


    public class _RenderCupertinoAlert : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public _RenderCupertinoAlert(FlutterSDK.Rendering.Box.RenderBox contentSection = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Box.RenderBox actionsSection = default(FlutterSDK.Rendering.Box.RenderBox), double dividerThickness = 0.0, FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color))
        : base()
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Box.RenderBox _ContentSection { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _ActionsSection { get; set; }
        internal virtual double _DividerThickness { get; set; }
        internal virtual SKPaint _DividerPaint { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox ContentSection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox ActionsSection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
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
            if (!(child.ParentData is MultiChildLayoutParentData))
            {
                ((MultiChildLayoutParentData)child.ParentData) = new MultiChildLayoutParentData();
            }

        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is MultiChildLayoutParentData))
            {
                ((MultiChildLayoutParentData)child.ParentData) = new MultiChildLayoutParentData();
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




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> value = new List<DiagnosticsNode>() { };
            if (ContentSection != null)
            {
                value.Add(ContentSection.ToDiagnosticsNode(name: "content"));
            }

            if (ActionsSection != null)
            {
                value.Add(ActionsSection.ToDiagnosticsNode(name: "actions"));
            }

            return value;
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return Constraints.MinWidth;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return Constraints.MaxWidth;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double contentHeight = ContentSection.GetMinIntrinsicHeight(width);
            double actionsHeight = ActionsSection.GetMinIntrinsicHeight(width);
            bool hasDivider = contentHeight > 0.0 && actionsHeight > 0.0;
            double height = contentHeight + (hasDivider ? _DividerThickness : 0.0) + actionsHeight;
            if (actionsHeight > 0 || contentHeight > 0) height -= 2 * ActionsheetDefaultClass._KEdgeVerticalPadding;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            double contentHeight = ContentSection.GetMaxIntrinsicHeight(width);
            double actionsHeight = ActionsSection.GetMaxIntrinsicHeight(width);
            bool hasDivider = contentHeight > 0.0 && actionsHeight > 0.0;
            double height = contentHeight + (hasDivider ? _DividerThickness : 0.0) + actionsHeight;
            if (actionsHeight > 0 || contentHeight > 0) height -= 2 * ActionsheetDefaultClass._KEdgeVerticalPadding;
            if (height.IsFinite()) return height;
            return 0.0;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            bool hasDivider = ContentSection.GetMaxIntrinsicHeight(constraints.MaxWidth) > 0.0 && ActionsSection.GetMaxIntrinsicHeight(constraints.MaxWidth) > 0.0;
            double dividerThickness = hasDivider ? _DividerThickness : 0.0;
            double minActionsHeight = ActionsSection.GetMinIntrinsicHeight(constraints.MaxWidth);
            ContentSection.Layout(constraints.Deflate(EdgeInsets.Only(bottom: minActionsHeight + dividerThickness)), parentUsesSize: true);
            Size contentSize = ContentSection.Size;
            ActionsSection.Layout(constraints.Deflate(EdgeInsets.Only(top: contentSize.Height + dividerThickness)), parentUsesSize: true);
            Size actionsSize = ActionsSection.Size;
            double actionSheetHeight = contentSize.Height + dividerThickness + actionsSize.Height;
            Size = new Size(constraints.MaxWidth, actionSheetHeight);

            MultiChildLayoutParentData actionParentData = ActionsSection.ParentData as MultiChildLayoutParentData;
            actionParentData.Offset = new Offset(0.0, contentSize.Height + dividerThickness);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            MultiChildLayoutParentData contentParentData = ContentSection.ParentData as MultiChildLayoutParentData;
            ContentSection.Paint(context, offset + contentParentData.Offset);
            bool hasDivider = ContentSection.Size.Height > 0.0 && ActionsSection.Size.Height > 0.0;
            if (hasDivider)
            {
                _PaintDividerBetweenContentAndActions(context.Canvas, offset);
            }

            MultiChildLayoutParentData actionsParentData = ActionsSection.ParentData as MultiChildLayoutParentData;
            ActionsSection.Paint(context, offset + actionsParentData.Offset);
        }




        private void _PaintDividerBetweenContentAndActions(Canvas canvas, FlutterBinding.UI.Offset offset)
        {
            canvas.DrawRect(Rect.FromLTWH(offset.Dx, offset.Dy + ContentSection.Size.Height, Size.Width, _DividerThickness), _DividerPaint);
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            MultiChildLayoutParentData contentSectionParentData = ContentSection.ParentData as MultiChildLayoutParentData;
            MultiChildLayoutParentData actionsSectionParentData = ActionsSection.ParentData as MultiChildLayoutParentData;
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
        public _CupertinoAlertContentSection(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget message = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController))
        : base(key: key)
        {
            this.Title = title;
            this.Message = message;
            this.ScrollController = scrollController;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Message { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> titleContentGroup = new List<Widget>() { };
            if (Title != null)
            {
                titleContentGroup.Add(new Padding(padding: EdgeInsets.Only(left: ActionsheetDefaultClass._KContentHorizontalPadding, right: ActionsheetDefaultClass._KContentHorizontalPadding, bottom: ActionsheetDefaultClass._KContentVerticalPadding, top: ActionsheetDefaultClass._KContentVerticalPadding), child: new DefaultTextStyle(style: Message == null ? ActionsheetDefaultClass._KActionSheetContentStyle : ActionsheetDefaultClass._KActionSheetContentStyle.CopyWith(fontWeight: Dart:uiDefaultClass.FontWeight.W600), textAlign: TextAlign.Center, child: Title)));
            }

            if (Message != null)
            {
                titleContentGroup.Add(new Padding(padding: EdgeInsets.Only(left: ActionsheetDefaultClass._KContentHorizontalPadding, right: ActionsheetDefaultClass._KContentHorizontalPadding, bottom: Title == null ? ActionsheetDefaultClass._KContentVerticalPadding : 22.0, top: Title == null ? ActionsheetDefaultClass._KContentVerticalPadding : 0.0), child: new DefaultTextStyle(style: Title == null ? ActionsheetDefaultClass._KActionSheetContentStyle.CopyWith(fontWeight: Dart:uiDefaultClass.FontWeight.W600) : ActionsheetDefaultClass._KActionSheetContentStyle, textAlign: TextAlign.Center, child: Message)));
            }

            if (titleContentGroup.IsEmpty())
            {
                return new SingleChildScrollView(controller: ScrollController, child: new Container(width: 0.0, height: 0.0));
            }

            if (titleContentGroup.Count > 1)
            {
                titleContentGroup.Insert(1, new Padding(padding: EdgeInsets.Only(top: 8.0)));
            }

            return new CupertinoScrollbar(child: new SingleChildScrollView(controller: ScrollController, child: new Column(mainAxisSize: MainAxisSize.Max, crossAxisAlignment: CrossAxisAlignment.Stretch, children: titleContentGroup)));
        }



        #endregion
    }


    public class _CupertinoAlertActionSection : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _CupertinoAlertActionSection(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool hasCancelButton = default(bool))
        : base(key: key)
        {
            this.Children = children;
            this.ScrollController = scrollController;
            this.HasCancelButton = hasCancelButton;
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual bool HasCancelButton { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Actionsheet._CupertinoAlertActionSectionState CreateState() => new _CupertinoAlertActionSectionState();


        #endregion
    }


    public class _CupertinoAlertActionSectionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Actionsheet._CupertinoAlertActionSection>
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

            return new CupertinoScrollbar(child: new SingleChildScrollView(controller: Widget.ScrollController, child: new _CupertinoAlertActionsRenderWidget(actionButtons: interactiveButtons, dividerThickness: ActionsheetDefaultClass._KDividerThickness / devicePixelRatio, hasCancelButton: Widget.HasCancelButton)));
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

        public new FlutterSDK.Cupertino.Actionsheet._PressableActionButtonState CreateState() => new _PressableActionButtonState();


        #endregion
    }


    public class _PressableActionButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Actionsheet._PressableActionButton>
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
            return new _ActionButtonParentDataWidget(isPressed: _IsPressed, child: new GestureDetector(excludeFromSemantics: true, behavior: HitTestBehavior.Opaque, onTapDown: (TapDownDetails details) => =>SetState(() => =>_IsPressed = true), onTapUp: (TapUpDetails details) => =>SetState(() => =>_IsPressed = false), onTapCancel: () => =>SetState(() => =>_IsPressed = false), child: Widget.Child));
        }



        #endregion
    }


    public class _ActionButtonParentDataWidget : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Cupertino.Actionsheet._ActionButtonParentData>
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


    public class _CupertinoAlertActionsRenderWidget : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public _CupertinoAlertActionsRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> actionButtons = default(List<FlutterSDK.Widgets.Framework.Widget>), double dividerThickness = 0.0, bool hasCancelButton = false)
        : base(key: key, children: actionButtons)
        {

        }
        #endregion

        #region fields
        internal virtual double _DividerThickness { get; set; }
        internal virtual bool _HasCancelButton { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderCupertinoAlertActions(dividerThickness: _DividerThickness, dividerColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KButtonDividerColor, context), hasCancelButton: _HasCancelButton, backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KBackgroundColor, context), pressedColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KPressedColor, context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Actionsheet._RenderCupertinoAlertActions renderObject)
        {
            ..DividerThickness = _DividerThickness..DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KButtonDividerColor, context)..HasCancelButton = _HasCancelButton..BackgroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KBackgroundColor, context)..PressedColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KPressedColor, context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..DividerThickness = _DividerThickness..DividerColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KButtonDividerColor, context)..HasCancelButton = _HasCancelButton..BackgroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KBackgroundColor, context)..PressedColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(ActionsheetDefaultClass._KPressedColor, context);
        }



        #endregion
    }


    public class _RenderCupertinoAlertActions : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>
    {
        #region constructors
        public _RenderCupertinoAlertActions(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), double dividerThickness = 0.0, FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), bool hasCancelButton = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color pressedColor = default(FlutterBinding.UI.Color))
        : base()
        {

            AddAll(children);
        }


        #endregion

        #region fields
        internal virtual double _DividerThickness { get; set; }
        internal virtual bool _HasCancelButton { get; set; }
        internal virtual SKPaint _ButtonBackgroundPaint { get; set; }
        internal virtual SKPaint _PressedButtonBackgroundPaint { get; set; }
        internal virtual SKPaint _DividerPaint { get; set; }
        public virtual double DividerThickness { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BackgroundColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color PressedColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DividerColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasCancelButton { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
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
            return Constraints.MinWidth;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return Constraints.MaxWidth;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            if (ChildCount == 0) return 0.0;
            if (ChildCount == 1) return FirstChild.ComputeMaxIntrinsicHeight(width) + DividerThickness;
            if (HasCancelButton && ChildCount < 4) return _ComputeMinIntrinsicHeightWithCancel(width);
            return _ComputeMinIntrinsicHeightWithoutCancel(width);
        }




        private double _ComputeMinIntrinsicHeightWithCancel(double width)
        {

            if (ChildCount == 2)
            {
                return FirstChild.GetMinIntrinsicHeight(width) + ChildAfter(FirstChild).GetMinIntrinsicHeight(width) + DividerThickness;
            }

            return FirstChild.GetMinIntrinsicHeight(width) + ChildAfter(FirstChild).GetMinIntrinsicHeight(width) + ChildAfter(ChildAfter(FirstChild)).GetMinIntrinsicHeight(width) + (DividerThickness * 2);
        }




        private double _ComputeMinIntrinsicHeightWithoutCancel(double width)
        {

            return FirstChild.GetMinIntrinsicHeight(width) + DividerThickness + (0.5 * ChildAfter(FirstChild).GetMinIntrinsicHeight(width));
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            if (ChildCount == 0) return 0.0;
            if (ChildCount == 1) return FirstChild.ComputeMaxIntrinsicHeight(width) + DividerThickness;
            return _ComputeMaxIntrinsicHeightStacked(width);
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




        public new void PerformLayout()
        {
            BoxConstraints perButtonConstraints = Constraints.CopyWith(minHeight: 0.0, maxHeight: Dart:coreDefaultClass.Double.Infinity);
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

            Size = Constraints.Constrain(new Size(Constraints.MaxWidth, verticalOffset));
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            Canvas canvas = context.Canvas;
            _DrawButtonBackgroundsAndDividersStacked(canvas, offset);
            _DrawButtons(context, offset);
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
                Rect dividerRect = Rect.FromLTWH(accumulatingOffset.Dx, accumulatingOffset.Dy, Size.Width, _DividerThickness);
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


    public enum _AlertSections
    {

        ContentSection,
        ActionsSection,
    }

}
