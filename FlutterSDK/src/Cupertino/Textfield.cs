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
namespace FlutterSDK.Cupertino.Textfield
{
    internal static class TextfieldDefaultClass
    {
        public static FlutterSDK.Painting.Borders.BorderSide _KDefaultRoundedBorderSide = default(FlutterSDK.Painting.Borders.BorderSide);
        public static FlutterSDK.Painting.Boxborder.Border _KDefaultRoundedBorder = default(FlutterSDK.Painting.Boxborder.Border);
        public static FlutterSDK.Painting.Boxdecoration.BoxDecoration _KDefaultRoundedBorderDecoration = default(FlutterSDK.Painting.Boxdecoration.BoxDecoration);
        public static Color _KDisabledBackground = default(Color);
        public static FlutterSDK.Cupertino.Colors.CupertinoDynamicColor _KClearButtonColor = default(FlutterSDK.Cupertino.Colors.CupertinoDynamicColor);
        public static int _IOSHorizontalCursorOffsetPixels = default(int);
    }

    public class _CupertinoTextFieldSelectionGestureDetectorBuilder : FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilder
    {
        #region constructors
        public _CupertinoTextFieldSelectionGestureDetectorBuilder(FlutterSDK.Cupertino.Textfield._CupertinoTextFieldState state = default(FlutterSDK.Cupertino.Textfield._CupertinoTextFieldState))
        : base(@delegate: state)
        {

        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Cupertino.Textfield._CupertinoTextFieldState _State { get; set; }
        #endregion

        #region methods

        public new void OnSingleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            if (_State._ClearGlobalKey.CurrentContext != null)
            {
                RenderBox renderBox = _State._ClearGlobalKey.CurrentContext.FindRenderObject() as RenderBox;
                Offset localOffset = renderBox.GlobalToLocal(details.GlobalPosition);
                if (renderBox.HitTest(new BoxHitTestResult(), position: localOffset))
                {
                    return;
                }

            }

            base.OnSingleTapUp(details);
            _State._RequestKeyboard();
            if (_State.Widget.OnTap != null) _State.Widget.OnTap();
        }




        public new void OnDragSelectionEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            _State._RequestKeyboard();
        }



        #endregion
    }


    /// <Summary>
    /// An iOS-style text field.
    ///
    /// A text field lets the user enter text, either with a hardware keyboard or with
    /// an onscreen keyboard.
    ///
    /// This widget corresponds to both a `UITextField` and an editable `UITextView`
    /// on iOS.
    ///
    /// The text field calls the [onChanged] callback whenever the user changes the
    /// text in the field. If the user indicates that they are done typing in the
    /// field (e.g., by pressing a button on the soft keyboard), the text field
    /// calls the [onSubmitted] callback.
    ///
    /// To control the text that is displayed in the text field, use the
    /// [controller]. For example, to set the initial value of the text field, use
    /// a [controller] that already contains some text such as:
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// class MyPrefilledText extends StatefulWidget {
    ///   @override
    ///   _MyPrefilledTextState createState() => _MyPrefilledTextState();
    /// }
    ///
    /// class _MyPrefilledTextState extends State<MyPrefilledText> {
    ///   TextEditingController _textController;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _textController = TextEditingController(text: 'initial text');
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return CupertinoTextField(controller: _textController);
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// The [controller] can also control the selection and composing region (and to
    /// observe changes to the text, selection, and composing region).
    ///
    /// The text field has an overridable [decoration] that, by default, draws a
    /// rounded rectangle border around the text field. If you set the [decoration]
    /// property to null, the decoration will be removed entirely.
    ///
    /// Remember to call [TextEditingController.dispose] when it is no longer
    /// needed. This will ensure we discard any resources used by the object.
    ///
    /// See also:
    ///
    ///  * <https://developer.apple.com/documentation/uikit/uitextfield>
    ///  * [TextField], an alternative text field widget that follows the Material
    ///    Design UI conventions.
    ///  * [EditableText], which is the raw text editing control at the heart of a
    ///    [TextField].
    ///  * Learn how to use a [TextEditingController] in one of our [cookbook recipes](https://flutter.dev/docs/cookbook/forms/text-field-changes#2-use-a-texteditingcontroller).
    /// </Summary>
    public class CupertinoTextField : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoTextField(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Editabletext.TextEditingController controller = default(FlutterSDK.Widgets.Editabletext.TextEditingController), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Painting.Boxdecoration.BoxDecoration decoration = default(FlutterSDK.Painting.Boxdecoration.BoxDecoration), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), string placeholder = default(string), FlutterSDK.Painting.Textstyle.TextStyle placeholderStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode prefixMode = default(FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode suffixMode = default(FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode), FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode clearButtonMode = default(FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode), FlutterSDK.Services.Textinput.TextInputType keyboardType = default(FlutterSDK.Services.Textinput.TextInputType), FlutterSDK.Services.Textinput.TextInputAction textInputAction = default(FlutterSDK.Services.Textinput.TextInputAction), FlutterSDK.Services.Textinput.TextCapitalization textCapitalization = default(FlutterSDK.Services.Textinput.TextCapitalization), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), bool readOnly = false, FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions), bool showCursor = default(bool), bool autofocus = false, bool obscureText = false, bool autocorrect = true, FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = true, int maxLines = 1, int minLines = default(int), bool expands = false, int maxLength = default(int), bool maxLengthEnforced = true, FlutterSDK.Foundation.Basictypes.ValueChanged<string> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), VoidCallback onEditingComplete = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onSubmitted = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), List<FlutterSDK.Services.Textformatter.TextInputFormatter> inputFormatters = default(List<FlutterSDK.Services.Textformatter.TextInputFormatter>), bool enabled = default(bool), double cursorWidth = 2.0, Radius cursorRadius = default(Radius), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), Brightness keyboardAppearance = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets scrollPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
        : base(key: key)
        {
            this.Controller = controller;
            this.FocusNode = focusNode;
            this.Decoration = decoration;
            this.Padding = padding;
            this.Placeholder = placeholder;
            this.PlaceholderStyle = placeholderStyle;
            this.Prefix = prefix;
            this.PrefixMode = prefixMode;
            this.Suffix = suffix;
            this.SuffixMode = suffixMode;
            this.ClearButtonMode = clearButtonMode;
            this.TextInputAction = textInputAction;
            this.TextCapitalization = textCapitalization;
            this.Style = style;
            this.StrutStyle = strutStyle;
            this.TextAlign = textAlign;
            this.TextAlignVertical = textAlignVertical;
            this.ReadOnly = readOnly;
            this.ShowCursor = showCursor;
            this.Autofocus = autofocus;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.EnableSuggestions = enableSuggestions;
            this.MaxLines = maxLines;
            this.MinLines = minLines;
            this.Expands = expands;
            this.MaxLength = maxLength;
            this.MaxLengthEnforced = maxLengthEnforced;
            this.OnChanged = onChanged;
            this.OnEditingComplete = onEditingComplete;
            this.OnSubmitted = onSubmitted;
            this.InputFormatters = inputFormatters;
            this.Enabled = enabled;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorColor = cursorColor;
            this.SelectionHeightStyle = selectionHeightStyle;
            this.SelectionWidthStyle = selectionWidthStyle;
            this.KeyboardAppearance = keyboardAppearance;
            this.ScrollPadding = scrollPadding;
            this.DragStartBehavior = dragStartBehavior;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.OnTap = onTap;
            this.ScrollController = scrollController;
            this.ScrollPhysics = scrollPhysics;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Editabletext.TextEditingController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual FlutterSDK.Painting.Boxdecoration.BoxDecoration Decoration { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual string Placeholder { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PlaceholderStyle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Prefix { get; set; }
        public virtual FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode PrefixMode { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Suffix { get; set; }
        public virtual FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode SuffixMode { get; set; }
        public virtual FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode ClearButtonMode { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextCapitalization TextCapitalization { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual FlutterSDK.Widgets.Editabletext.ToolbarOptions ToolbarOptions { get; set; }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        public virtual bool ReadOnly { get; set; }
        public virtual bool ShowCursor { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual bool ObscureText { get; set; }
        public virtual bool Autocorrect { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        public virtual bool EnableSuggestions { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual int MinLines { get; set; }
        public virtual bool Expands { get; set; }
        public virtual int MaxLength { get; set; }
        public virtual bool MaxLengthEnforced { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnChanged { get; set; }
        public virtual VoidCallback OnEditingComplete { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnSubmitted { get; set; }
        public virtual List<FlutterSDK.Services.Textformatter.TextInputFormatter> InputFormatters { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual double CursorWidth { get; set; }
        public virtual Radius CursorRadius { get; set; }
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        public virtual Brightness KeyboardAppearance { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ScrollPadding { get; set; }
        public virtual bool EnableInteractiveSelection { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ScrollPhysics { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.Textfield._CupertinoTextFieldState CreateState() => new _CupertinoTextFieldState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<TextEditingController>("controller", Controller, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode, defaultValue: null));
            properties.Add(new DiagnosticsProperty<BoxDecoration>("decoration", Decoration));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding));
            properties.Add(new StringProperty("placeholder", Placeholder));
            properties.Add(new DiagnosticsProperty<TextStyle>("placeholderStyle", PlaceholderStyle));
            properties.Add(new DiagnosticsProperty<OverlayVisibilityMode>("prefix", Prefix == null ? null : PrefixMode));
            properties.Add(new DiagnosticsProperty<OverlayVisibilityMode>("suffix", Suffix == null ? null : SuffixMode));
            properties.Add(new DiagnosticsProperty<OverlayVisibilityMode>("clearButtonMode", ClearButtonMode));
            properties.Add(new DiagnosticsProperty<TextInputType>("keyboardType", KeyboardType, defaultValue: TextinputDefaultClass.TextInputType.Text));
            properties.Add(new DiagnosticsProperty<TextStyle>("style", Style, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("autofocus", Autofocus, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("obscureText", ObscureText, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("autocorrect", Autocorrect, defaultValue: true));
            properties.Add(new EnumProperty<SmartDashesType>("smartDashesType", SmartDashesType, defaultValue: ObscureText ? SmartDashesType.Disabled : SmartDashesType.Enabled));
            properties.Add(new EnumProperty<SmartQuotesType>("smartQuotesType", SmartQuotesType, defaultValue: ObscureText ? SmartQuotesType.Disabled : SmartQuotesType.Enabled));
            properties.Add(new DiagnosticsProperty<bool>("enableSuggestions", EnableSuggestions, defaultValue: true));
            properties.Add(new IntProperty("maxLines", MaxLines, defaultValue: 1));
            properties.Add(new IntProperty("minLines", MinLines, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("expands", Expands, defaultValue: false));
            properties.Add(new IntProperty("maxLength", MaxLength, defaultValue: null));
            properties.Add(new FlagProperty("maxLengthEnforced", value: MaxLengthEnforced, ifTrue: "max length enforced"));
            properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("cursorColor", CursorColor, defaultValue: null));
            properties.Add(new FlagProperty("selectionEnabled", value: SelectionEnabled, defaultValue: true, ifFalse: "selection disabled"));
            properties.Add(new DiagnosticsProperty<ScrollController>("scrollController", ScrollController, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ScrollPhysics>("scrollPhysics", ScrollPhysics, defaultValue: null));
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: TextAlign.Start));
            properties.Add(new DiagnosticsProperty<TextAlignVertical>("textAlignVertical", TextAlignVertical, defaultValue: null));
        }



        #endregion
    }


    public class _CupertinoTextFieldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Textfield.CupertinoTextField>, ITextSelectionGestureDetectorBuilderDelegate, IAutomaticKeepAliveClientMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _CupertinoTextFieldState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ClearGlobalKey { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual bool _ShowSelectionHandles { get; set; }
        internal virtual FlutterSDK.Cupertino.Textfield._CupertinoTextFieldSelectionGestureDetectorBuilder _SelectionGestureDetectorBuilder { get; set; }
        public new FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Editabletext.EditableTextState> EditableTextKey { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _EffectiveController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _EffectiveFocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ForcePressEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Editabletext.EditableTextState _EditableText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasDecoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Painting.Alignment.TextAlignVertical _TextAlignVertical { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            _SelectionGestureDetectorBuilder = new _CupertinoTextFieldSelectionGestureDetectorBuilder(state: this);
            if (Widget.Controller == null)
            {
                _Controller = new TextEditingController();
                _Controller.AddListener(UpdateKeepAlive);
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Textfield.CupertinoTextField oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller == null && oldWidget.Controller != null)
            {
                _Controller = TextEditingController.FromValue(oldWidget.Controller.Value);
                _Controller.AddListener(UpdateKeepAlive);
            }
            else if (Widget.Controller != null && oldWidget.Controller == null)
            {
                _Controller = null;
            }

            bool isEnabled = Widget.Enabled ?? true;
            bool wasEnabled = oldWidget.Enabled ?? true;
            if (wasEnabled && !isEnabled)
            {
                _EffectiveFocusNode.Unfocus();
            }

        }




        public new void Dispose()
        {
            _FocusNode?.Dispose();
            _Controller?.RemoveListener(UpdateKeepAlive);
            base.Dispose();
        }




        private void _RequestKeyboard()
        {
            _EditableText?.RequestKeyboard();
        }




        private bool _ShouldShowSelectionHandles(FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
        {
            if (!_SelectionGestureDetectorBuilder.ShouldShowSelectionToolbar) return false;
            if (_EffectiveController.Selection.IsCollapsed) return false;
            if (cause == SelectionChangedCause.Keyboard) return false;
            if (_EffectiveController.Text.IsNotEmpty) return true;
            return false;
        }




        private void _HandleSelectionChanged(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
        {
            if (cause == SelectionChangedCause.LongPress)
            {
                _EditableText?.BringIntoView(selection.Base);
            }

            bool willShowSelectionHandles = _ShouldShowSelectionHandles(cause);
            if (willShowSelectionHandles != _ShowSelectionHandles)
            {
                SetState(() =>
                {
                    _ShowSelectionHandles = willShowSelectionHandles;
                }
                );
            }

        }




        private bool _ShouldShowAttachment(FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode attachment = default(FlutterSDK.Cupertino.Textfield.OverlayVisibilityMode), bool hasText = default(bool))
        {
            switch (attachment) { case OverlayVisibilityMode.Never: return false; case OverlayVisibilityMode.Always: return true; case OverlayVisibilityMode.Editing: return hasText; case OverlayVisibilityMode.NotEditing: return !hasText; }

            return null;
        }




        private bool _ShowPrefixWidget(FlutterSDK.Services.Textinput.TextEditingValue text)
        {
            return Widget.Prefix != null && _ShouldShowAttachment(attachment: Widget.PrefixMode, hasText: text.Text.IsNotEmpty);
        }




        private bool _ShowSuffixWidget(FlutterSDK.Services.Textinput.TextEditingValue text)
        {
            return Widget.Suffix != null && _ShouldShowAttachment(attachment: Widget.SuffixMode, hasText: text.Text.IsNotEmpty);
        }




        private bool _ShowClearButton(FlutterSDK.Services.Textinput.TextEditingValue text)
        {
            return _ShouldShowAttachment(attachment: Widget.ClearButtonMode, hasText: text.Text.IsNotEmpty);
        }




        private FlutterSDK.Widgets.Framework.Widget _AddTextDependentAttachments(FlutterSDK.Widgets.Framework.Widget editableText, FlutterSDK.Painting.Textstyle.TextStyle textStyle, FlutterSDK.Painting.Textstyle.TextStyle placeholderStyle)
        {



            if (!_HasDecoration)
            {
                return editableText;
            }

            return new ValueListenableBuilder<TextEditingValue>(valueListenable: _EffectiveController, child: editableText, builder: (BuildContext context, TextEditingValue text, Widget child) =>
            {
                return new Row(children: new List<Widget>() { });
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            base.Build(context);

            TextEditingController controller = _EffectiveController;
            List<TextInputFormatter> formatters = Widget.InputFormatters ?? new List<TextInputFormatter>() { };
            bool enabled = Widget.Enabled ?? true;
            Offset cursorOffset = new Offset(TextfieldDefaultClass._IOSHorizontalCursorOffsetPixels / MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio, 0);
            if (Widget.MaxLength != null && Widget.MaxLengthEnforced)
            {
                formatters.Add(new LengthLimitingTextInputFormatter(Widget.MaxLength));
            }

            CupertinoThemeData themeData = ThemeDefaultClass.CupertinoTheme.Of(context);
            TextStyle resolvedStyle = Widget.Style?.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.Style?.Color, context), backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.Style?.BackgroundColor, context));
            TextStyle textStyle = themeData.TextTheme.TextStyle.Merge(resolvedStyle);
            TextStyle resolvedPlaceholderStyle = Widget.PlaceholderStyle?.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.PlaceholderStyle?.Color, context), backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.PlaceholderStyle?.BackgroundColor, context));
            TextStyle placeholderStyle = textStyle.Merge(resolvedPlaceholderStyle);
            Brightness keyboardAppearance = Widget.KeyboardAppearance ?? ThemeDefaultClass.CupertinoTheme.BrightnessOf(context);
            Color cursorColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.CursorColor, context) ?? themeData.PrimaryColor;
            Color disabledColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(TextfieldDefaultClass._KDisabledBackground, context);
            Color decorationColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.Decoration?.Color, context);
            BoxBorder border = Widget.Decoration?.Border;
            Border resolvedBorder = border as Border;
            if (border is Border)
            {
                BorderSide ResolveBorderSide(BorderSide side) => {
                    return side == BordersDefaultClass.BorderSide.None ? side : side.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(side.Color, context));
                }

                resolvedBorder = ((Border)border) == null || ((Border)border).GetType() != BoxborderDefaultClass.Border ? ((Border)border) : new Border(top: ResolveBorderSide(((Border)border).Top), left: ResolveBorderSide(((Border)border).Left), bottom: ResolveBorderSide(((Border)border).Bottom), right: ResolveBorderSide(((Border)border).Right));
            }

            BoxDecoration effectiveDecoration = Widget.Decoration?.CopyWith(border: resolvedBorder, color: enabled ? decorationColor : (decorationColor ?? disabledColor));
            Widget paddedEditable = new Padding(padding: Widget.Padding, child: new RepaintBoundary(child: new EditableText(key: EditableTextKey, controller: controller, readOnly: Widget.ReadOnly, toolbarOptions: Widget.ToolbarOptions, showCursor: Widget.ShowCursor, showSelectionHandles: _ShowSelectionHandles, focusNode: _EffectiveFocusNode, keyboardType: Widget.KeyboardType, textInputAction: Widget.TextInputAction, textCapitalization: Widget.TextCapitalization, style: textStyle, strutStyle: Widget.StrutStyle, textAlign: Widget.TextAlign, autofocus: Widget.Autofocus, obscureText: Widget.ObscureText, autocorrect: Widget.Autocorrect, smartDashesType: Widget.SmartDashesType, smartQuotesType: Widget.SmartQuotesType, enableSuggestions: Widget.EnableSuggestions, maxLines: Widget.MaxLines, minLines: Widget.MinLines, expands: Widget.Expands, selectionColor: ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor.WithOpacity(0.2), selectionControls: Widget.SelectionEnabled ? TextselectionDefaultClass.CupertinoTextSelectionControls : null, onChanged: Widget.OnChanged, onSelectionChanged: _HandleSelectionChanged, onEditingComplete: Widget.OnEditingComplete, onSubmitted: Widget.OnSubmitted, inputFormatters: formatters, rendererIgnoresPointer: true, cursorWidth: Widget.CursorWidth, cursorRadius: Widget.CursorRadius, cursorColor: cursorColor, cursorOpacityAnimates: true, cursorOffset: cursorOffset, paintCursorAboveText: true, backgroundCursorColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.InactiveGray, context), selectionHeightStyle: Widget.SelectionHeightStyle, selectionWidthStyle: Widget.SelectionWidthStyle, scrollPadding: Widget.ScrollPadding, keyboardAppearance: keyboardAppearance, dragStartBehavior: Widget.DragStartBehavior, scrollController: Widget.ScrollController, scrollPhysics: Widget.ScrollPhysics, enableInteractiveSelection: Widget.EnableInteractiveSelection)));
            return new Semantics(enabled: enabled, onTap: !enabled ? null : () =>
            {
                if (!controller.Selection.IsValid)
                {
                    controller.Selection = TextSelection.Collapsed(offset: controller.Text.Length);
                }

                _RequestKeyboard();
            }
            , child: new IgnorePointer(ignoring: !enabled, child: new Container(decoration: effectiveDecoration, child: _SelectionGestureDetectorBuilder.BuildGestureDetector(behavior: HitTestBehavior.Translucent, child: new Align(alignment: new Alignment(-1.0, _TextAlignVertical.y), widthFactor: 1.0, heightFactor: 1.0, child: _AddTextDependentAttachments(paddedEditable, textStyle, placeholderStyle))))));
        }



        #endregion
    }


    /// <Summary>
    /// Visibility of text field overlays based on the state of the current text entry.
    ///
    /// Used to toggle the visibility behavior of the optional decorating widgets
    /// surrounding the [EditableText] such as the clear text button.
    /// </Summary>
    public enum OverlayVisibilityMode
    {

        /// <Summary>
        /// Overlay will never appear regardless of the text entry state.
        /// </Summary>
        Never,
        /// <Summary>
        /// Overlay will only appear when the current text entry is not empty.
        ///
        /// This includes prefilled text that the user did not type in manually. But
        /// does not include text in placeholders.
        /// </Summary>
        Editing,
        /// <Summary>
        /// Overlay will only appear when the current text entry is empty.
        ///
        /// This also includes not having prefilled text that the user did not type
        /// in manually. Texts in placeholders are ignored.
        /// </Summary>
        NotEditing,
        /// <Summary>
        /// Always show the overlay regardless of the text entry state.
        /// </Summary>
        Always,
    }

}
