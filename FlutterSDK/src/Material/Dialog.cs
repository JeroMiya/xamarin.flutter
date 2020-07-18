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
namespace FlutterSDK.Material.Dialog
{
    internal static class DialogDefaultClass
    {
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _DefaultInsetPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        internal static FlutterSDK.Widgets.Framework.Widget _BuildMaterialDialogTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            throw new NotImplementedException();
        }

        internal static Future<T> ShowDialog<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), bool barrierDismissible = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A material design dialog.
    ///
    /// This dialog widget does not have any opinion about the contents of the
    /// dialog. Rather than using this widget directly, consider using [AlertDialog]
    /// or [SimpleDialog], which implement specific kinds of material design
    /// dialogs.
    ///
    /// See also:
    ///
    ///  * [AlertDialog], for dialogs that have a message and some buttons.
    ///  * [SimpleDialog], for dialogs that offer a variety of options.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * <https://material.io/design/components/dialogs.html>
    /// </Summary>
    public class Dialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public Dialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), TimeSpan insetAnimationDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve insetAnimationCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Painting.Edgeinsets.EdgeInsets insetPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.InsetAnimationDuration = insetAnimationDuration;
            this.InsetAnimationCurve = insetAnimationCurve;
            this.InsetPadding = insetPadding;
            this.ClipBehavior = clipBehavior;
            this.Shape = shape;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual double Elevation { get; set; }
        public virtual TimeSpan InsetAnimationDuration { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve InsetAnimationCurve { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets InsetPadding { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        internal virtual FlutterSDK.Painting.Roundedrectangleborder.RoundedRectangleBorder _DefaultDialogShape { get; set; }
        internal virtual double _DefaultElevation { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            DialogTheme dialogTheme = DialogthemeDefaultClass.DialogTheme.Of(context);
            EdgeInsets effectivePadding = MediaqueryDefaultClass.MediaQuery.Of(context).ViewInsets + (InsetPadding ?? EdgeInsets.All(0.0));
            return new AnimatedPadding(padding: effectivePadding, duration: InsetAnimationDuration, curve: InsetAnimationCurve, child: MediaQuery.RemoveViewInsets(removeLeft: true, removeTop: true, removeRight: true, removeBottom: true, context: context, child: new Center(child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: 280.0), child: new Material(color: BackgroundColor ?? dialogTheme.BackgroundColor ?? ThemeDefaultClass.Theme.Of(context).DialogBackgroundColor, elevation: elevation == default(double) ? dialogTheme.elevation : elevation ?? _DefaultElevation, shape: Shape ?? dialogTheme.Shape ?? _DefaultDialogShape, type: MaterialType.Card, clipBehavior: ClipBehavior, child: Child)))));
        }



        #endregion
    }


    /// <Summary>
    /// A material design alert dialog.
    ///
    /// An alert dialog informs the user about situations that require
    /// acknowledgement. An alert dialog has an optional title and an optional list
    /// of actions. The title is displayed above the content and the actions are
    /// displayed below the content.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=75CsnyRXf5I}
    ///
    /// If the content is too large to fit on the screen vertically, the dialog will
    /// display the title and the actions and let the content overflow, which is
    /// rarely desired. Consider using a scrolling widget for [content], such as
    /// [SingleChildScrollView], to avoid overflow. (However, be aware that since
    /// [AlertDialog] tries to size itself using the intrinsic dimensions of its
    /// children, widgets such as [ListView], [GridView], and [CustomScrollView],
    /// which use lazy viewports, will not work. If this is a problem, consider
    /// using [Dialog] directly.)
    ///
    /// For dialogs that offer the user a choice between several options, consider
    /// using a [SimpleDialog].
    ///
    /// Typically passed as the child widget to [showDialog], which displays the
    /// dialog.
    ///
    /// {@animation 350 622 https://flutter.github.io/assets-for-api-docs/assets/material/alert_dialog.mp4}
    ///
    /// {@tool snippet}
    ///
    /// This snippet shows a method in a [State] which, when called, displays a dialog box
    /// and returns a [Future] that completes when the dialog is dismissed.
    ///
    /// ```dart
    /// Future<void> _showMyDialog() async {
    ///   return showDialog<void>(
    ///     context: context,
    ///     barrierDismissible: false, // user must tap button!
    ///     builder: (BuildContext context) {
    ///       return AlertDialog(
    ///         title: Text('AlertDialog Title'),
    ///         content: SingleChildScrollView(
    ///           child: ListBody(
    ///             children: <Widget>[
    ///               Text('This is a demo alert dialog.'),
    ///               Text('Would you like to approve of this message?'),
    ///             ],
    ///           ),
    ///         ),
    ///         actions: <Widget>[
    ///           FlatButton(
    ///             child: Text('Approve'),
    ///             onPressed: () {
    ///               Navigator.of(context).pop();
    ///             },
    ///           ),
    ///         ],
    ///       );
    ///     },
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SimpleDialog], which handles the scrolling of the contents but has no [actions].
    ///  * [Dialog], on which [AlertDialog] and [SimpleDialog] are based.
    ///  * [CupertinoAlertDialog], an iOS-styled alert dialog.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * <https://material.io/design/components/dialogs.html#alert-dialog>
    /// </Summary>
    public class AlertDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public AlertDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry titlePadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Textstyle.TextStyle titleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Textstyle.TextStyle contentTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry actionsPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Basictypes.VerticalDirection actionsOverflowDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), double actionsOverflowButtonSpacing = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry buttonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), string semanticLabel = default(string), FlutterSDK.Painting.Edgeinsets.EdgeInsets insetPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool scrollable = false)
        : base(key: key)
        {
            this.Title = title;
            this.TitlePadding = titlePadding;
            this.TitleTextStyle = titleTextStyle;
            this.Content = content;
            this.ContentPadding = contentPadding;
            this.ContentTextStyle = contentTextStyle;
            this.Actions = actions;
            this.ActionsPadding = actionsPadding;
            this.ActionsOverflowDirection = actionsOverflowDirection;
            this.ActionsOverflowButtonSpacing = actionsOverflowButtonSpacing;
            this.ButtonPadding = buttonPadding;
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.SemanticLabel = semanticLabel;
            this.InsetPadding = insetPadding;
            this.ClipBehavior = clipBehavior;
            this.Shape = shape;
            this.Scrollable = scrollable;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry TitlePadding { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TitleTextStyle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ContentTextStyle { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ActionsPadding { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection ActionsOverflowDirection { get; set; }
        public virtual double ActionsOverflowButtonSpacing { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ButtonPadding { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual double Elevation { get; set; }
        public virtual string SemanticLabel { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets InsetPadding { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual bool Scrollable { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            DialogTheme dialogTheme = DialogthemeDefaultClass.DialogTheme.Of(context);
            string label = SemanticLabel;
            if (Title == null)
            {
                switch (theme.Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: label = SemanticLabel; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: label = SemanticLabel ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.AlertDialogLabel; }
            }

            Widget titleWidget = default(Widget);
            Widget contentWidget = default(Widget);
            Widget actionsWidget = default(Widget);
            if (Title != null) titleWidget = new Padding(padding: TitlePadding ?? EdgeInsets.FromLTRB(24.0, 24.0, 24.0, Content == null ? 20.0 : 0.0), child: new DefaultTextStyle(style: TitleTextStyle ?? dialogTheme.TitleTextStyle ?? theme.TextTheme.Headline6, child: new Semantics(child: Title, namesRoute: true, container: true)));
            if (Content != null) contentWidget = new Padding(padding: ContentPadding, child: new DefaultTextStyle(style: ContentTextStyle ?? dialogTheme.ContentTextStyle ?? theme.TextTheme.Subtitle1, child: Content));
            if (Actions != null) actionsWidget = new Padding(padding: ActionsPadding, child: new ButtonBar(buttonPadding: ButtonPadding, overflowDirection: ActionsOverflowDirection, overflowButtonSpacing: ActionsOverflowButtonSpacing, children: Actions));
            List<Widget> columnChildren = default(List<Widget>);
            if (Scrollable)
            {
                columnChildren = new List<Widget>() { };
            }
            else
            {
                columnChildren = new List<Widget>() { };
            }

            Widget dialogChild = new IntrinsicWidth(child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: columnChildren));
            if (label != null) dialogChild = new Semantics(namesRoute: true, label: label, child: dialogChild);
            return new Dialog(backgroundColor: BackgroundColor, elevation: Elevation, insetPadding: InsetPadding, clipBehavior: ClipBehavior, shape: Shape, child: dialogChild);
        }



        #endregion
    }


    /// <Summary>
    /// An option used in a [SimpleDialog].
    ///
    /// A simple dialog offers the user a choice between several options. This
    /// widget is commonly used to represent each of the options. If the user
    /// selects this option, the widget will call the [onPressed] callback, which
    /// typically uses [Navigator.pop] to close the dialog.
    ///
    /// The padding on a [SimpleDialogOption] is configured to combine with the
    /// default [SimpleDialog.contentPadding] so that each option ends up 8 pixels
    /// from the other vertically, with 20 pixels of spacing between the dialog's
    /// title and the first option, and 24 pixels of spacing between the last option
    /// and the bottom of the dialog.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// SimpleDialogOption(
    ///   onPressed: () { Navigator.pop(context, Department.treasury); },
    ///   child: const Text('Treasury department'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SimpleDialog], for a dialog in which to use this widget.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * [FlatButton], which are commonly used as actions in other kinds of
    ///    dialogs, such as [AlertDialog]s.
    ///  * <https://material.io/design/components/dialogs.html#simple-dialog>
    /// </Summary>
    public class SimpleDialogOption : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public SimpleDialogOption(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPressed = onPressed;
            this.Padding = padding;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual VoidCallback OnPressed { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new InkWell(onTap: OnPressed, child: new Padding(padding: Padding ?? EdgeInsets.Symmetric(vertical: 8.0, horizontal: 24.0), child: Child));
        }



        #endregion
    }


    /// <Summary>
    /// A simple material design dialog.
    ///
    /// A simple dialog offers the user a choice between several options. A simple
    /// dialog has an optional title that is displayed above the choices.
    ///
    /// Choices are normally represented using [SimpleDialogOption] widgets. If
    /// other widgets are used, see [contentPadding] for notes regarding the
    /// conventions for obtaining the spacing expected by Material Design.
    ///
    /// For dialogs that inform the user about a situation, consider using an
    /// [AlertDialog].
    ///
    /// Typically passed as the child widget to [showDialog], which displays the
    /// dialog.
    ///
    /// {@animation 350 622 https://flutter.github.io/assets-for-api-docs/assets/material/simple_dialog.mp4}
    ///
    /// {@tool snippet}
    ///
    /// In this example, the user is asked to select between two options. These
    /// options are represented as an enum. The [showDialog] method here returns
    /// a [Future] that completes to a value of that enum. If the user cancels
    /// the dialog (e.g. by hitting the back button on Android, or tapping on the
    /// mask behind the dialog) then the future completes with the null value.
    ///
    /// The return value in this example is used as the index for a switch statement.
    /// One advantage of using an enum as the return value and then using that to
    /// drive a switch statement is that the analyzer will flag any switch statement
    /// that doesn't mention every value in the enum.
    ///
    /// ```dart
    /// Future<void> _askedToLead() async {
    ///   switch (await showDialog<Department>(
    ///     context: context,
    ///     builder: (BuildContext context) {
    ///       return SimpleDialog(
    ///         title: const Text('Select assignment'),
    ///         children: <Widget>[
    ///           SimpleDialogOption(
    ///             onPressed: () { Navigator.pop(context, Department.treasury); },
    ///             child: const Text('Treasury department'),
    ///           ),
    ///           SimpleDialogOption(
    ///             onPressed: () { Navigator.pop(context, Department.state); },
    ///             child: const Text('State department'),
    ///           ),
    ///         ],
    ///       );
    ///     }
    ///   )) {
    ///     case Department.treasury:
    ///       // Let's go.
    ///       // ...
    ///     break;
    ///     case Department.state:
    ///       // ...
    ///     break;
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SimpleDialogOption], which are options used in this type of dialog.
    ///  * [AlertDialog], for dialogs that have a row of buttons below the body.
    ///  * [Dialog], on which [SimpleDialog] and [AlertDialog] are based.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * <https://material.io/design/components/dialogs.html#simple-dialog>
    /// </Summary>
    public class SimpleDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public SimpleDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry titlePadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), string semanticLabel = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Title = title;
            this.TitlePadding = titlePadding;
            this.Children = children;
            this.ContentPadding = contentPadding;
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.SemanticLabel = semanticLabel;
            this.Shape = shape;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry TitlePadding { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual double Elevation { get; set; }
        public virtual string SemanticLabel { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            string label = SemanticLabel;
            if (Title == null)
            {
                switch (theme.Platform) { case TargetPlatform.MacOS: case TargetPlatform.IOS: label = SemanticLabel; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: label = SemanticLabel ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.DialogLabel; }
            }

            Widget dialogChild = new IntrinsicWidth(stepWidth: 56.0, child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: 280.0), child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { })));
            if (label != null) dialogChild = new Semantics(namesRoute: true, label: label, child: dialogChild);
            return new Dialog(backgroundColor: BackgroundColor, elevation: Elevation, shape: Shape, child: dialogChild);
        }



        #endregion
    }

}
