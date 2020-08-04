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
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Typography;
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
namespace FlutterSDK.Material.Textfield
{
    /// <Summary>
    /// Signature for the [TextField.buildCounter] callback.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget InputCounterWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, int currentLength = default(int), int maxLength = default(int), bool isFocused = default(bool));
    internal static class TextfieldDefaultClass
    {
    }

    public class _TextFieldSelectionGestureDetectorBuilder : FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilder
    {
        public _TextFieldSelectionGestureDetectorBuilder(FlutterSDK.Material.Textfield._TextFieldState state = default(FlutterSDK.Material.Textfield._TextFieldState))
        : base(@delegate: state)
        {

        }
        internal virtual FlutterSDK.Material.Textfield._TextFieldState _State { get; set; }

        public new void OnForcePressStart(FlutterSDK.Gestures.Forcepress.ForcePressDetails details)
        {
            base.OnForcePressStart(details);
            if (Delegate.SelectionEnabled && ShouldShowSelectionToolbar)
            {
                EditableText.ShowToolbar();
            }

        }




        public new void OnForcePressEnd(FlutterSDK.Gestures.Forcepress.ForcePressDetails details)
        {
        }




        public new void OnSingleLongTapMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details)
        {
            if (Delegate.SelectionEnabled)
            {
                switch (ThemeDefaultClass.Theme.Of(_State.Context).Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: RenderEditable.SelectPositionAt(from: details.GlobalPosition, cause: SelectionChangedCause.LongPress); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: RenderEditable.SelectWordsInRange(from: details.GlobalPosition - details.OffsetFromOrigin, to: details.GlobalPosition, cause: SelectionChangedCause.LongPress); break; }
            }

        }




        public new void OnSingleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            EditableText.HideToolbar();
            if (Delegate.SelectionEnabled)
            {
                switch (ThemeDefaultClass.Theme.Of(_State.Context).Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: RenderEditable.SelectWordEdge(cause: SelectionChangedCause.Tap); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: RenderEditable.SelectPosition(cause: SelectionChangedCause.Tap); break; }
            }

            _State._RequestKeyboard();
            if (_State.Widget.OnTap != null) _State.Widget.OnTap();
        }




        public new void OnSingleLongTapStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details)
        {
            if (Delegate.SelectionEnabled)
            {
                switch (ThemeDefaultClass.Theme.Of(_State.Context).Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: RenderEditable.SelectPositionAt(from: details.GlobalPosition, cause: SelectionChangedCause.LongPress); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: RenderEditable.SelectWord(cause: SelectionChangedCause.LongPress); FeedbackDefaultClass.Feedback.ForLongPress(_State.Context); break; }
            }

        }



    }


    /// <Summary>
    /// A material design text field.
    ///
    /// A text field lets the user enter text, either with hardware keyboard or with
    /// an onscreen keyboard.
    ///
    /// The text field calls the [onChanged] callback whenever the user changes the
    /// text in the field. If the user indicates that they are done typing in the
    /// field (e.g., by pressing a button on the soft keyboard), the text field
    /// calls the [onSubmitted] callback.
    ///
    /// To control the text that is displayed in the text field, use the
    /// [controller]. For example, to set the initial value of the text field, use
    /// a [controller] that already contains some text. The [controller] can also
    /// control the selection and composing region (and to observe changes to the
    /// text, selection, and composing region).
    ///
    /// By default, a text field has a [decoration] that draws a divider below the
    /// text field. You can use the [decoration] property to control the decoration,
    /// for example by adding a label or an icon. If you set the [decoration]
    /// property to null, the decoration will be removed entirely, including the
    /// extra padding introduced by the decoration to save space for the labels.
    ///
    /// If [decoration] is non-null (which is the default), the text field requires
    /// one of its ancestors to be a [Material] widget.
    ///
    /// To integrate the [TextField] into a [Form] with other [FormField] widgets,
    /// consider using [TextFormField].
    ///
    /// Remember to [dispose] of the [TextEditingController] when it is no longer needed.
    /// This will ensure we discard any resources used by the object.
    ///
    /// {@tool snippet}
    /// This example shows how to create a [TextField] that will obscure input. The
    /// [InputDecoration] surrounds the field in a border using [OutlineInputBorder]
    /// and adds a label.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/text_field.png)
    ///
    /// ```dart
    /// TextField(
    ///   obscureText: true,
    ///   decoration: InputDecoration(
    ///     border: OutlineInputBorder(),
    ///     labelText: 'Password',
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Reading values
    ///
    /// A common way to read a value from a TextField is to use the [onSubmitted]
    /// callback. This callback is applied to the text field's current value when
    /// the user finishes editing.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    ///
    /// This sample shows how to get a value from a TextField via the [onSubmitted]
    /// callback.
    ///
    /// ```dart
    /// TextEditingController _controller;
    ///
    /// void initState() {
    ///   super.initState();
    ///   _controller = TextEditingController();
    /// }
    ///
    /// void dispose() {
    ///   _controller.dispose();
    ///   super.dispose();
    /// }
    ///
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     body: Center(
    ///       child: TextField(
    ///         controller: _controller,
    ///         onSubmitted: (String value) async {
    ///           await showDialog<void>(
    ///             context: context,
    ///             builder: (BuildContext context) {
    ///               return AlertDialog(
    ///                 title: const Text('Thanks!'),
    ///                 content: Text ('You typed "$value".'),
    ///                 actions: <Widget>[
    ///                   FlatButton(
    ///                     onPressed: () { Navigator.pop(context); },
    ///                     child: const Text('OK'),
    ///                   ),
    ///                 ],
    ///               );
    ///             },
    ///           );
    ///         },
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// For most applications the [onSubmitted] callback will be sufficient for
    /// reacting to user input.
    ///
    /// The [onEditingComplete] callback also runs when the user finishes editing.
    /// It's different from [onSubmitted] because it has a default value which
    /// updates the text controller and yields the keyboard focus. Applications that
    /// require different behavior can override the default [onEditingComplete]
    /// callback.
    ///
    /// Keep in mind you can also always read the current string from a TextField's
    /// [TextEditingController] using [TextEditingController.text].
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/components/text-fields.html>
    ///  * [TextFormField], which integrates with the [Form] widget.
    ///  * [InputDecorator], which shows the labels and other visual elements that
    ///    surround the actual text editing widget.
    ///  * [EditableText], which is the raw text editing control at the heart of a
    ///    [TextField]. The [EditableText] widget is rarely used directly unless
    ///    you are implementing an entirely different design language, such as
    ///    Cupertino.
    ///  * Learn how to use a [TextEditingController] in one of our
    ///    [cookbook recipe](https://flutter.dev/docs/cookbook/forms/text-field-changes#2-use-a-texteditingcontroller)s.
    /// </Summary>
    public class TextField : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a Material Design text field.
        ///
        /// If [decoration] is non-null (which is the default), the text field requires
        /// one of its ancestors to be a [Material] widget.
        ///
        /// To remove the decoration entirely (including the extra padding introduced
        /// by the decoration to save space for the labels), set the [decoration] to
        /// null.
        ///
        /// The [maxLines] property can be set to null to remove the restriction on
        /// the number of lines. By default, it is one, meaning this is a single-line
        /// text field. [maxLines] must not be zero.
        ///
        /// The [maxLength] property is set to null by default, which means the
        /// number of characters allowed in the text field is not restricted. If
        /// [maxLength] is set a character counter will be displayed below the
        /// field showing how many characters have been entered. If the value is
        /// set to a positive integer it will also display the maximum allowed
        /// number of characters to be entered.  If the value is set to
        /// [TextField.noMaxLength] then only the current length is displayed.
        ///
        /// After [maxLength] characters have been input, additional input
        /// is ignored, unless [maxLengthEnforced] is set to false. The text field
        /// enforces the length with a [LengthLimitingTextInputFormatter], which is
        /// evaluated after the supplied [inputFormatters], if any. The [maxLength]
        /// value must be either null or greater than zero.
        ///
        /// If [maxLengthEnforced] is set to false, then more than [maxLength]
        /// characters may be entered, and the error counter and divider will
        /// switch to the [decoration.errorStyle] when the limit is exceeded.
        ///
        /// The text cursor is not shown if [showCursor] is false or if [showCursor]
        /// is null (the default) and [readOnly] is true.
        ///
        /// The [selectionHeightStyle] and [selectionWidthStyle] properties allow
        /// changing the shape of the selection highlighting. These properties default
        /// to [ui.BoxHeightStyle.tight] and [ui.BoxWidthStyle.tight] respectively and
        /// must not be null.
        ///
        /// The [textAlign], [autofocus], [obscureText], [readOnly], [autocorrect],
        /// [maxLengthEnforced], [scrollPadding], [maxLines], [maxLength],
        /// [selectionHeightStyle], [selectionWidthStyle], and [enableSuggestions]
        /// arguments must not be null.
        ///
        /// See also:
        ///
        ///  * [maxLength], which discusses the precise meaning of "number of
        ///    characters" and how it may differ from the intuitive meaning.
        /// </Summary>
        public TextField(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Editabletext.TextEditingController controller = default(FlutterSDK.Widgets.Editabletext.TextEditingController), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Material.Inputdecorator.InputDecoration decoration = default(FlutterSDK.Material.Inputdecorator.InputDecoration), FlutterSDK.Services.Textinput.TextInputType keyboardType = default(FlutterSDK.Services.Textinput.TextInputType), FlutterSDK.Services.Textinput.TextInputAction textInputAction = default(FlutterSDK.Services.Textinput.TextInputAction), FlutterSDK.Services.Textinput.TextCapitalization textCapitalization = default(FlutterSDK.Services.Textinput.TextCapitalization), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), TextDirection textDirection = default(TextDirection), bool readOnly = false, FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions), bool showCursor = default(bool), bool autofocus = false, bool obscureText = false, bool autocorrect = true, FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = true, int maxLines = 1, int minLines = default(int), bool expands = false, int maxLength = default(int), bool maxLengthEnforced = true, FlutterSDK.Foundation.Basictypes.ValueChanged<string> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), VoidCallback onEditingComplete = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onSubmitted = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), List<FlutterSDK.Services.Textformatter.TextInputFormatter> inputFormatters = default(List<FlutterSDK.Services.Textformatter.TextInputFormatter>), bool enabled = default(bool), double cursorWidth = 2.0, Radius cursorRadius = default(Radius), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), Brightness keyboardAppearance = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets scrollPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Material.Textfield.InputCounterWidgetBuilder buildCounter = default(FlutterSDK.Material.Textfield.InputCounterWidgetBuilder), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
        : base(key: key)
        {
            this.Controller = controller;
            this.FocusNode = focusNode;
            this.Decoration = decoration;
            this.TextInputAction = textInputAction;
            this.TextCapitalization = textCapitalization;
            this.Style = style;
            this.StrutStyle = strutStyle;
            this.TextAlign = textAlign;
            this.TextAlignVertical = textAlignVertical;
            this.TextDirection = textDirection;
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
            this.BuildCounter = buildCounter;
            this.ScrollController = scrollController;
            this.ScrollPhysics = scrollPhysics;
        }
        /// <Summary>
        /// Controls the text being edited.
        ///
        /// If null, this widget will create its own [TextEditingController].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Editabletext.TextEditingController Controller { get; set; }
        /// <Summary>
        /// Defines the keyboard focus for this widget.
        ///
        /// The [focusNode] is a long-lived object that's typically managed by a
        /// [StatefulWidget] parent. See [FocusNode] for more information.
        ///
        /// To give the keyboard focus to this widget, provide a [focusNode] and then
        /// use the current [FocusScope] to request the focus:
        ///
        /// ```dart
        /// FocusScope.of(context).requestFocus(myFocusNode);
        /// ```
        ///
        /// This happens automatically when the widget is tapped.
        ///
        /// To be notified when the widget gains or loses the focus, add a listener
        /// to the [focusNode]:
        ///
        /// ```dart
        /// focusNode.addListener(() { print(myFocusNode.hasFocus); });
        /// ```
        ///
        /// If null, this widget will create its own [FocusNode].
        ///
        /// ## Keyboard
        ///
        /// Requesting the focus will typically cause the keyboard to be shown
        /// if it's not showing already.
        ///
        /// On Android, the user can hide the keyboard - without changing the focus -
        /// with the system back button. They can restore the keyboard's visibility
        /// by tapping on a text field.  The user might hide the keyboard and
        /// switch to a physical keyboard, or they might just need to get it
        /// out of the way for a moment, to expose something it's
        /// obscuring. In this case requesting the focus again will not
        /// cause the focus to change, and will not make the keyboard visible.
        ///
        /// This widget builds an [EditableText] and will ensure that the keyboard is
        /// showing when it is tapped by calling [EditableTextState.requestKeyboard()].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// The decoration to show around the text field.
        ///
        /// By default, draws a horizontal line under the text field but can be
        /// configured to show an icon, label, hint text, and error text.
        ///
        /// Specify null to remove the decoration entirely (including the
        /// extra padding introduced by the decoration to save space for the labels).
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.keyboardType}
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; set; }
        /// <Summary>
        /// The type of action button to use for the keyboard.
        ///
        /// Defaults to [TextInputAction.newline] if [keyboardType] is
        /// [TextInputType.multiline] and [TextInputAction.done] otherwise.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.textCapitalization}
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextCapitalization TextCapitalization { get; set; }
        /// <Summary>
        /// The style to use for the text being edited.
        ///
        /// This text style is also used as the base style for the [decoration].
        ///
        /// If null, defaults to the `subtitle1` text style from the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.strutStyle}
        /// </Summary>
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.textAlign}
        /// </Summary>
        public virtual TextAlign TextAlign { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.inputDecorator.textAlignVertical}
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.textDirection}
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.obscureText}
        /// </Summary>
        public virtual bool ObscureText { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.autocorrect}
        /// </Summary>
        public virtual bool Autocorrect { get; set; }
        /// <Summary>
        /// {@macro flutter.services.textInput.smartDashesType}
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        /// <Summary>
        /// {@macro flutter.services.textInput.smartQuotesType}
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        /// <Summary>
        /// {@macro flutter.services.textInput.enableSuggestions}
        /// </Summary>
        public virtual bool EnableSuggestions { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.maxLines}
        /// </Summary>
        public virtual int MaxLines { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.minLines}
        /// </Summary>
        public virtual int MinLines { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.expands}
        /// </Summary>
        public virtual bool Expands { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.readOnly}
        /// </Summary>
        public virtual bool ReadOnly { get; set; }
        /// <Summary>
        /// Configuration of toolbar options.
        ///
        /// If not set, select all and paste will default to be enabled. Copy and cut
        /// will be disabled if [obscureText] is true. If [readOnly] is true,
        /// paste and cut will be disabled regardless.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Editabletext.ToolbarOptions ToolbarOptions { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.showCursor}
        /// </Summary>
        public virtual bool ShowCursor { get; set; }
        /// <Summary>
        /// If [maxLength] is set to this value, only the "current input length"
        /// part of the character counter is shown.
        /// </Summary>
        public virtual int NoMaxLength { get; set; }
        /// <Summary>
        /// The maximum number of characters (Unicode scalar values) to allow in the
        /// text field.
        ///
        /// If set, a character counter will be displayed below the
        /// field showing how many characters have been entered. If set to a number
        /// greater than 0, it will also display the maximum number allowed. If set
        /// to [TextField.noMaxLength] then only the current character count is displayed.
        ///
        /// After [maxLength] characters have been input, additional input
        /// is ignored, unless [maxLengthEnforced] is set to false. The text field
        /// enforces the length with a [LengthLimitingTextInputFormatter], which is
        /// evaluated after the supplied [inputFormatters], if any.
        ///
        /// This value must be either null, [TextField.noMaxLength], or greater than 0.
        /// If null (the default) then there is no limit to the number of characters
        /// that can be entered. If set to [TextField.noMaxLength], then no limit will
        /// be enforced, but the number of characters entered will still be displayed.
        ///
        /// Whitespace characters (e.g. newline, space, tab) are included in the
        /// character count.
        ///
        /// If [maxLengthEnforced] is set to false, then more than [maxLength]
        /// characters may be entered, but the error counter and divider will
        /// switch to the [decoration.errorStyle] when the limit is exceeded.
        ///
        /// ## Limitations
        ///
        /// The text field does not currently count Unicode grapheme clusters (i.e.
        /// characters visible to the user), it counts Unicode scalar values, which
        /// leaves out a number of useful possible characters (like many emoji and
        /// composed characters), so this will be inaccurate in the presence of those
        /// characters. If you expect to encounter these kinds of characters, be
        /// generous in the maxLength used.
        ///
        /// For instance, the character "ö" can be represented as '\u{006F}\u{0308}',
        /// which is the letter "o" followed by a composed diaeresis "¨", or it can
        /// be represented as '\u{00F6}', which is the Unicode scalar value "LATIN
        /// SMALL LETTER O WITH DIAERESIS". In the first case, the text field will
        /// count two characters, and the second case will be counted as one
        /// character, even though the user can see no difference in the input.
        ///
        /// Similarly, some emoji are represented by multiple scalar values. The
        /// Unicode "THUMBS UP SIGN + MEDIUM SKIN TONE MODIFIER", "👍🏽", should be
        /// counted as a single character, but because it is a combination of two
        /// Unicode scalar values, '\u{1F44D}\u{1F3FD}', it is counted as two
        /// characters.
        ///
        /// See also:
        ///
        ///  * [LengthLimitingTextInputFormatter] for more information on how it
        ///    counts characters, and how it may differ from the intuitive meaning.
        /// </Summary>
        public virtual int MaxLength { get; set; }
        /// <Summary>
        /// If true, prevents the field from allowing more than [maxLength]
        /// characters.
        ///
        /// If [maxLength] is set, [maxLengthEnforced] indicates whether or not to
        /// enforce the limit, or merely provide a character counter and warning when
        /// [maxLength] is exceeded.
        /// </Summary>
        public virtual bool MaxLengthEnforced { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.onChanged}
        ///
        /// See also:
        ///
        ///  * [inputFormatters], which are called before [onChanged]
        ///    runs and can validate and change ("format") the input value.
        ///  * [onEditingComplete], [onSubmitted], [onSelectionChanged]:
        ///    which are more specialized input change notifications.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnChanged { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.onEditingComplete}
        /// </Summary>
        public virtual VoidCallback OnEditingComplete { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.onSubmitted}
        ///
        /// See also:
        ///
        ///  * [EditableText.onSubmitted] for an example of how to handle moving to
        ///    the next/previous field when using [TextInputAction.next] and
        ///    [TextInputAction.previous] for [textInputAction].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnSubmitted { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.inputFormatters}
        /// </Summary>
        public virtual List<FlutterSDK.Services.Textformatter.TextInputFormatter> InputFormatters { get; set; }
        /// <Summary>
        /// If false the text field is "disabled": it ignores taps and its
        /// [decoration] is rendered in grey.
        ///
        /// If non-null this property overrides the [decoration]'s
        /// [Decoration.enabled] property.
        /// </Summary>
        public virtual bool Enabled { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.cursorWidth}
        /// </Summary>
        public virtual double CursorWidth { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.cursorRadius}
        /// </Summary>
        public virtual Radius CursorRadius { get; set; }
        /// <Summary>
        /// The color to use when painting the cursor.
        ///
        /// Defaults to [ThemeData.cursorColor] or [CupertinoTheme.primaryColor]
        /// depending on [ThemeData.platform].
        /// </Summary>
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        /// <Summary>
        /// Controls how tall the selection highlight boxes are computed to be.
        ///
        /// See [ui.BoxHeightStyle] for details on available styles.
        /// </Summary>
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        /// <Summary>
        /// Controls how wide the selection highlight boxes are computed to be.
        ///
        /// See [ui.BoxWidthStyle] for details on available styles.
        /// </Summary>
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        /// <Summary>
        /// The appearance of the keyboard.
        ///
        /// This setting is only honored on iOS devices.
        ///
        /// If unset, defaults to the brightness of [ThemeData.primaryColorBrightness].
        /// </Summary>
        public virtual Brightness KeyboardAppearance { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.scrollPadding}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ScrollPadding { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.enableInteractiveSelection}
        /// </Summary>
        public virtual bool EnableInteractiveSelection { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        /// <Summary>
        /// {@template flutter.material.textfield.onTap}
        /// Called for each distinct tap except for every second tap of a double tap.
        ///
        /// The text field builds a [GestureDetector] to handle input events like tap,
        /// to trigger focus requests, to move the caret, adjust the selection, etc.
        /// Handling some of those events by wrapping the text field with a competing
        /// GestureDetector is problematic.
        ///
        /// To unconditionally handle taps, without interfering with the text field's
        /// internal gesture detector, provide this callback.
        ///
        /// If the text field is created with [enabled] false, taps will not be
        /// recognized.
        ///
        /// To be notified when the text field gains or loses the focus, provide a
        /// [focusNode] and add a listener to that.
        ///
        /// To listen to arbitrary pointer events without competing with the
        /// text field's internal gesture detector, use a [Listener].
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        /// <Summary>
        /// Callback that generates a custom [InputDecorator.counter] widget.
        ///
        /// See [InputCounterWidgetBuilder] for an explanation of the passed in
        /// arguments.  The returned widget will be placed below the line in place of
        /// the default widget built when [counterText] is specified.
        ///
        /// The returned widget will be wrapped in a [Semantics] widget for
        /// accessibility, but it also needs to be accessible itself.  For example,
        /// if returning a Text widget, set the [semanticsLabel] property.
        ///
        /// {@tool snippet}
        /// ```dart
        /// Widget counter(
        ///   BuildContext context,
        ///   {
        ///     int currentLength,
        ///     int maxLength,
        ///     bool isFocused,
        ///   }
        /// ) {
        ///   return Text(
        ///     '$currentLength of $maxLength characters',
        ///     semanticsLabel: 'character count',
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// If buildCounter returns null, then no counter and no Semantics widget will
        /// be created at all.
        /// </Summary>
        public virtual FlutterSDK.Material.Textfield.InputCounterWidgetBuilder BuildCounter { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.scrollPhysics}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ScrollPhysics { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.scrollController}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Textfield._TextFieldState CreateState() => new _TextFieldState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<TextEditingController>("controller", Controller, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("enabled", Enabled, defaultValue: null));
            properties.Add(new DiagnosticsProperty<InputDecoration>("decoration", Decoration, defaultValue: new InputDecoration()));
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
            properties.Add(new FlagProperty("maxLengthEnforced", value: MaxLengthEnforced, defaultValue: true, ifFalse: "maxLength not enforced"));
            properties.Add(new EnumProperty<TextInputAction>("textInputAction", TextInputAction, defaultValue: null));
            properties.Add(new EnumProperty<TextCapitalization>("textCapitalization", TextCapitalization, defaultValue: TextCapitalization.None));
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: TextAlign.Start));
            properties.Add(new DiagnosticsProperty<TextAlignVertical>("textAlignVertical", TextAlignVertical, defaultValue: null));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            properties.Add(new DoubleProperty("cursorWidth", CursorWidth, defaultValue: 2.0));
            properties.Add(new DiagnosticsProperty<Radius>("cursorRadius", CursorRadius, defaultValue: null));
            properties.Add(new ColorProperty("cursorColor", CursorColor, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Brightness>("keyboardAppearance", KeyboardAppearance, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("scrollPadding", ScrollPadding, defaultValue: EdgeInsets.All(20.0)));
            properties.Add(new FlagProperty("selectionEnabled", value: SelectionEnabled, defaultValue: true, ifFalse: "selection disabled"));
            properties.Add(new DiagnosticsProperty<ScrollController>("scrollController", ScrollController, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ScrollPhysics>("scrollPhysics", ScrollPhysics, defaultValue: null));
        }



    }


    public class _TextFieldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Textfield.TextField>, ITextSelectionGestureDetectorBuilderDelegate
    {
        public _TextFieldState()
        { }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual bool _IsHovering { get; set; }
        internal virtual bool _ShowSelectionHandles { get; set; }
        internal virtual FlutterSDK.Material.Textfield._TextFieldSelectionGestureDetectorBuilder _SelectionGestureDetectorBuilder { get; set; }
        public new bool ForcePressEnabled { get; set; }
        public new FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Editabletext.EditableTextState> EditableTextKey { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _EffectiveController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _EffectiveFocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool NeedsCounter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual int _CurrentLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Editabletext.EditableTextState _EditableText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private FlutterSDK.Material.Inputdecorator.InputDecoration _GetEffectiveDecoration()
        {
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
            ThemeData themeData = ThemeDefaultClass.Theme.Of(Context);
            InputDecoration effectiveDecoration = (Widget.Decoration ?? new InputDecoration()).ApplyDefaults(themeData.InputDecorationTheme).CopyWith(enabled: Widget.Enabled, hintMaxLines: Widget.Decoration?.HintMaxLines ?? Widget.MaxLines);
            if (effectiveDecoration.Counter != null || effectiveDecoration.CounterText != null) return effectiveDecoration;
            Widget counter = default(Widget);
            int currentLength = _CurrentLength;
            if (effectiveDecoration.Counter == null && effectiveDecoration.CounterText == null && Widget.BuildCounter != null)
            {
                bool isFocused = _EffectiveFocusNode.HasFocus;
                Widget builtCounter = Widget.BuildCounter(Context, currentLength: currentLength, maxLength: Widget.MaxLength, isFocused: isFocused);
                if (builtCounter != null)
                {
                    counter = new Semantics(container: true, liveRegion: isFocused, child: builtCounter);
                }

                return effectiveDecoration.CopyWith(counter: counter);
            }

            if (Widget.MaxLength == null) return effectiveDecoration;
            string counterText = $"'{currentLength}'";
            string semanticCounterText = "";
            if (Widget.MaxLength > 0)
            {
                counterText += $"'/{Widget.MaxLength}'";
                int remaining = (Widget.MaxLength - currentLength).Clamp(0, Widget.MaxLength) as int;
                semanticCounterText = localizations.RemainingTextFieldCharacterCount(remaining);
                if (_EffectiveController.Value.Text.Runes.Length > Widget.MaxLength)
                {
                    return effectiveDecoration.CopyWith(errorText: effectiveDecoration.ErrorText ?? "", counterStyle: effectiveDecoration.ErrorStyle ?? themeData.TextTheme.Caption.CopyWith(color: themeData.ErrorColor), counterText: counterText, semanticCounterText: semanticCounterText);
                }

            }

            return effectiveDecoration.CopyWith(counterText: counterText, semanticCounterText: semanticCounterText);
        }




        public new void InitState()
        {
            base.InitState();
            _SelectionGestureDetectorBuilder = new _TextFieldSelectionGestureDetectorBuilder(state: this);
            if (Widget.Controller == null)
            {
                _Controller = new TextEditingController();
            }

            _EffectiveFocusNode.CanRequestFocus = _IsEnabled;
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Textfield.TextField oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller == null && oldWidget.Controller != null) _Controller = TextEditingController.FromValue(oldWidget.Controller.Value); else if (Widget.Controller != null && oldWidget.Controller == null) _Controller = null;
            _EffectiveFocusNode.CanRequestFocus = _IsEnabled;
            if (_EffectiveFocusNode.HasFocus && Widget.ReadOnly != oldWidget.ReadOnly)
            {
                if (_EffectiveController.Selection.IsCollapsed)
                {
                    _ShowSelectionHandles = !Widget.ReadOnly;
                }

            }

        }




        public new void Dispose()
        {
            _FocusNode?.Dispose();
            base.Dispose();
        }




        private void _RequestKeyboard()
        {
            _EditableText?.RequestKeyboard();
        }




        private bool _ShouldShowSelectionHandles(FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
        {
            if (!_SelectionGestureDetectorBuilder.ShouldShowSelectionToolbar) return false;
            if (cause == SelectionChangedCause.Keyboard) return false;
            if (Widget.ReadOnly && _EffectiveController.Selection.IsCollapsed) return false;
            if (cause == SelectionChangedCause.LongPress) return true;
            if (_EffectiveController.Text.IsNotEmpty) return true;
            return false;
        }




        private void _HandleSelectionChanged(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
        {
            bool willShowSelectionHandles = _ShouldShowSelectionHandles(cause);
            if (willShowSelectionHandles != _ShowSelectionHandles)
            {
                SetState(() =>
                {
                    _ShowSelectionHandles = willShowSelectionHandles;
                }
                );
            }

            switch (ThemeDefaultClass.Theme.Of(Context).Platform)
            {
                case TargetPlatform.IOS:
                case TargetPlatform.MacOS:
                    if (cause == SelectionChangedCause.LongPress)
                    {
                        _EditableText?.BringIntoView(selection.Base);
                    }
                    return;
                case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows:
            }
        }




        /// <Summary>
        /// Toggle the toolbar when a selection handle is tapped.
        /// </Summary>
        private void _HandleSelectionHandleTapped()
        {
            if (_EffectiveController.Selection.IsCollapsed)
            {
                _EditableText.ToggleToolbar();
            }

        }




        private void _HandleHover(bool hovering)
        {
            if (hovering != _IsHovering)
            {
                SetState(() =>
                {
                    _IsHovering = hovering;
                }
                );
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {



            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            TextStyle style = themeData.TextTheme.Subtitle1.Merge(Widget.Style);
            Brightness keyboardAppearance = Widget.KeyboardAppearance ?? themeData.PrimaryColorBrightness;
            TextEditingController controller = _EffectiveController;
            FocusNode focusNode = _EffectiveFocusNode;
            List<TextInputFormatter> formatters = Widget.InputFormatters ?? new List<TextInputFormatter>() { };
            if (Widget.MaxLength != null && Widget.MaxLengthEnforced) formatters.Add(new LengthLimitingTextInputFormatter(Widget.MaxLength));
            TextSelectionControls textSelectionControls = default(TextSelectionControls);
            bool paintCursorAboveText = default(bool);
            bool cursorOpacityAnimates = default(bool);
            Offset cursorOffset = default(Offset);
            Color cursorColor = Widget.CursorColor;
            Radius cursorRadius = Widget.CursorRadius;
            switch (themeData.Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: ForcePressEnabled = true; textSelectionControls = TextselectionDefaultClass.CupertinoTextSelectionControls; paintCursorAboveText = true; cursorOpacityAnimates = true; cursorColor = (cursorColor == null ? ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor : cursorColor); cursorRadius = (cursorRadius == null ? Radius.Circular(2.0) : cursorRadius); cursorOffset = new Offset(SelectabletextDefaultClass.IOSHorizontalOffset / MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio, 0); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: ForcePressEnabled = false; textSelectionControls = TextselectionDefaultClass.MaterialTextSelectionControls; paintCursorAboveText = false; cursorOpacityAnimates = false; cursorColor = (cursorColor == null ? themeData.CursorColor : cursorColor); break; }
            Widget child = new RepaintBoundary(child: new EditableText(key: EditableTextKey, readOnly: Widget.ReadOnly, toolbarOptions: Widget.ToolbarOptions, showCursor: Widget.ShowCursor, showSelectionHandles: _ShowSelectionHandles, controller: controller, focusNode: focusNode, keyboardType: Widget.KeyboardType, textInputAction: Widget.TextInputAction, textCapitalization: Widget.TextCapitalization, style: style, strutStyle: Widget.StrutStyle, textAlign: Widget.TextAlign, textDirection: Widget.TextDirection, autofocus: Widget.Autofocus, obscureText: Widget.ObscureText, autocorrect: Widget.Autocorrect, smartDashesType: Widget.SmartDashesType, smartQuotesType: Widget.SmartQuotesType, enableSuggestions: Widget.EnableSuggestions, maxLines: Widget.MaxLines, minLines: Widget.MinLines, expands: Widget.Expands, selectionColor: themeData.TextSelectionColor, selectionControls: Widget.SelectionEnabled ? textSelectionControls : null, onChanged: Widget.OnChanged, onSelectionChanged: _HandleSelectionChanged, onEditingComplete: Widget.OnEditingComplete, onSubmitted: Widget.OnSubmitted, onSelectionHandleTapped: _HandleSelectionHandleTapped, inputFormatters: formatters, rendererIgnoresPointer: true, cursorWidth: Widget.CursorWidth, cursorRadius: cursorRadius, cursorColor: cursorColor, selectionHeightStyle: Widget.SelectionHeightStyle, selectionWidthStyle: Widget.SelectionWidthStyle, cursorOpacityAnimates: cursorOpacityAnimates, cursorOffset: cursorOffset, paintCursorAboveText: paintCursorAboveText, backgroundCursorColor: ColorsDefaultClass.CupertinoColors.InactiveGray, scrollPadding: Widget.ScrollPadding, keyboardAppearance: keyboardAppearance, enableInteractiveSelection: Widget.EnableInteractiveSelection, dragStartBehavior: Widget.DragStartBehavior, scrollController: Widget.ScrollController, scrollPhysics: Widget.ScrollPhysics));
            if (Widget.Decoration != null)
            {
                child = new AnimatedBuilder(animation: Listenable.Merge(new List<Listenable>() { focusNode, controller }), builder: (BuildContext context, Widget child) =>
                {
                    return new InputDecorator(decoration: _GetEffectiveDecoration(), baseStyle: Widget.Style, textAlign: Widget.TextAlign, textAlignVertical: Widget.TextAlignVertical, isHovering: _IsHovering, isFocused: focusNode.HasFocus, isEmpty: controller.Value.Text.IsEmpty(), expands: Widget.Expands, child: child);
                }
                , child: child);
            }

            return new IgnorePointer(ignoring: !_IsEnabled, child: new MouseRegion(onEnter: (PointerEnterEvent @event) => =>_HandleHover(true), onExit: (PointerExitEvent @event) => =>_HandleHover(false), child: new AnimatedBuilder(animation: controller, builder: (BuildContext context, Widget child) =>
            {
                return new Semantics(maxValueLength: Widget.MaxLengthEnforced && Widget.MaxLength != null && Widget.MaxLength > 0 ? Widget.MaxLength : null, currentValueLength: _CurrentLength, onTap: () =>
                {
                    if (!_EffectiveController.Selection.IsValid) _EffectiveController.Selection = TextSelection.Collapsed(offset: _EffectiveController.Text.Length);
                    _RequestKeyboard();
                }
                , child: child);
            }
            , child: _SelectionGestureDetectorBuilder.BuildGestureDetector(behavior: HitTestBehavior.Translucent, child: child))));
        }



    }

}
