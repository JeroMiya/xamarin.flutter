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
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
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
namespace FlutterSDK.Material.Selectabletext
{
    internal static class SelectabletextDefaultClass
    {
        public static int IOSHorizontalOffset = default(int);
    }

    public class _TextSpanEditingController : FlutterSDK.Widgets.Editabletext.TextEditingController
    {
        public _TextSpanEditingController(FlutterSDK.Painting.Textspan.TextSpan textSpan = default(FlutterSDK.Painting.Textspan.TextSpan))
        : base(text: textSpan.ToPlainText())
        {

        }
        internal virtual FlutterSDK.Painting.Textspan.TextSpan _TextSpan { get; set; }
        public virtual string Text { set { throw new NotImplementedException(); } }

        public new FlutterSDK.Painting.Textspan.TextSpan BuildTextSpan(FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), bool withComposing = default(bool))
        {
            return new TextSpan(style: style, children: new List<TextSpan>() { _TextSpan });
        }



    }


    public class _SelectableTextSelectionGestureDetectorBuilder : FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilder
    {
        public _SelectableTextSelectionGestureDetectorBuilder(FlutterSDK.Material.Selectabletext._SelectableTextState state = default(FlutterSDK.Material.Selectabletext._SelectableTextState))
        : base(@delegate: state)
        {

        }
        internal virtual FlutterSDK.Material.Selectabletext._SelectableTextState _State { get; set; }

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
    /// A run of selectable text with a single style.
    ///
    /// The [SelectableText] widget displays a string of text with a single style.
    /// The string might break across multiple lines or might all be displayed on
    /// the same line depending on the layout constraints.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=ZSU3ZXOs6hc}
    ///
    /// The [style] argument is optional. When omitted, the text will use the style
    /// from the closest enclosing [DefaultTextStyle]. If the given style's
    /// [TextStyle.inherit] property is true (the default), the given style will
    /// be merged with the closest enclosing [DefaultTextStyle]. This merging
    /// behavior is useful, for example, to make the text bold while using the
    /// default font family and size.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// SelectableText(
    ///   'Hello! How are you?',
    ///   textAlign: TextAlign.center,
    ///   style: TextStyle(fontWeight: FontWeight.bold),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// Using the [SelectableText.rich] constructor, the [SelectableText] widget can
    /// display a paragraph with differently styled [TextSpan]s. The sample
    /// that follows displays "Hello beautiful world" with different styles
    /// for each word.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// const SelectableText.rich(
    ///   TextSpan(
    ///     text: 'Hello', // default text style
    ///     children: <TextSpan>[
    ///       TextSpan(text: ' beautiful ', style: TextStyle(fontStyle: FontStyle.italic)),
    ///       TextSpan(text: 'world', style: TextStyle(fontWeight: FontWeight.bold)),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Interactivity
    ///
    /// To make [SelectableText] react to touch events, use callback [onTap] to achieve
    /// the desired behavior.
    ///
    /// See also:
    ///
    ///  * [Text], which is the non selectable version of this widget.
    ///  * [TextField], which is the editable version of this widget.
    /// </Summary>
    public class SelectableText : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a selectable text widget.
        ///
        /// If the [style] argument is null, the text will use the style from the
        /// closest enclosing [DefaultTextStyle].
        ///
        /// The [showCursor], [autofocus], [dragStartBehavior], and [data] parameters
        /// must not be null. If specified, the [maxLines] argument must be greater
        /// than zero.
        /// </Summary>
        public SelectableText(string data, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), double textScaleFactor = default(double), bool showCursor = false, bool autofocus = false, FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions), int minLines = default(int), int maxLines = default(int), double cursorWidth = 2.0, Radius cursorRadius = default(Radius), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis))
        : base(key: key)
        {
            this.Data = data;
            this.FocusNode = focusNode;
            this.Style = style;
            this.StrutStyle = strutStyle;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.TextScaleFactor = textScaleFactor;
            this.ShowCursor = showCursor;
            this.Autofocus = autofocus;
            this.MinLines = minLines;
            this.MaxLines = maxLines;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorColor = cursorColor;
            this.DragStartBehavior = dragStartBehavior;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.OnTap = onTap;
            this.ScrollPhysics = scrollPhysics;
            this.TextWidthBasis = textWidthBasis;
        }
        /// <Summary>
        /// Creates a selectable text widget with a [TextSpan].
        ///
        /// The [textSpan] parameter must not be null and only contain [TextSpan] in
        /// [textSpan.children]. Other type of [InlineSpan] is not allowed.
        ///
        /// The [autofocus] and [dragStartBehavior] arguments must not be null.
        /// </Summary>
        public static SelectableText Rich(FlutterSDK.Painting.Textspan.TextSpan textSpan, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), double textScaleFactor = default(double), bool showCursor = false, bool autofocus = false, FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions), int minLines = default(int), int maxLines = default(int), double cursorWidth = 2.0, Radius cursorRadius = default(Radius), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis))
        {
            var instance = new SelectableText(key: key); instance.TextSpan = textSpan;
            instance.FocusNode = focusNode;
            instance.Style = style;
            instance.StrutStyle = strutStyle;
            instance.TextAlign = textAlign;
            instance.TextDirection = textDirection;
            instance.TextScaleFactor = textScaleFactor;
            instance.ShowCursor = showCursor;
            instance.Autofocus = autofocus;
            instance.MinLines = minLines;
            instance.MaxLines = maxLines;
            instance.CursorWidth = cursorWidth;
            instance.CursorRadius = cursorRadius;
            instance.CursorColor = cursorColor;
            instance.DragStartBehavior = dragStartBehavior;
            instance.EnableInteractiveSelection = enableInteractiveSelection;
            instance.OnTap = onTap;
            instance.ScrollPhysics = scrollPhysics;
            instance.TextWidthBasis = textWidthBasis;
        }
        /// <Summary>
        /// The text to display.
        ///
        /// This will be null if a [textSpan] is provided instead.
        /// </Summary>
        public virtual string Data { get; set; }
        /// <Summary>
        /// The text to display as a [TextSpan].
        ///
        /// This will be null if [data] is provided instead.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textspan.TextSpan TextSpan { get; set; }
        /// <Summary>
        /// Defines the focus for this widget.
        ///
        /// Text is only selectable when widget is focused.
        ///
        /// The [focusNode] is a long-lived object that's typically managed by a
        /// [StatefulWidget] parent. See [FocusNode] for more information.
        ///
        /// To give the focus to this widget, provide a [focusNode] and then
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
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// The style to use for the text.
        ///
        /// If null, defaults [DefaultTextStyle] of context.
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
        /// {@macro flutter.widgets.editableText.textDirection}
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.textScaleFactor}
        /// </Summary>
        public virtual double TextScaleFactor { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.minLines}
        /// </Summary>
        public virtual int MinLines { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.maxLines}
        /// </Summary>
        public virtual int MaxLines { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.showCursor}
        /// </Summary>
        public virtual bool ShowCursor { get; set; }
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
        /// Defaults to the theme's `cursorColor` when null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.enableInteractiveSelection}
        /// </Summary>
        public virtual bool EnableInteractiveSelection { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        /// <Summary>
        /// Configuration of toolbar options.
        ///
        /// Paste and cut will be disabled regardless.
        ///
        /// If not set, select all and copy will be enabled by default.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Editabletext.ToolbarOptions ToolbarOptions { get; set; }
        /// <Summary>
        /// Called when the user taps on this selectable text.
        ///
        /// The selectable text builds a [GestureDetector] to handle input events like tap,
        /// to trigger focus requests, to move the caret, adjust the selection, etc.
        /// Handling some of those events by wrapping the selectable text with a competing
        /// GestureDetector is problematic.
        ///
        /// To unconditionally handle taps, without interfering with the selectable text's
        /// internal gesture detector, provide this callback.
        ///
        /// To be notified when the text field gains or loses the focus, provide a
        /// [focusNode] and add a listener to that.
        ///
        /// To listen to arbitrary pointer events without competing with the
        /// selectable text's internal gesture detector, use a [Listener].
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.scrollPhysics}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ScrollPhysics { get; set; }
        /// <Summary>
        /// {@macro flutter.painting.textPainter.textWidthBasis}
        /// </Summary>
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Selectabletext._SelectableTextState CreateState() => new _SelectableTextState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<string>("data", Data, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode, defaultValue: null));
            properties.Add(new DiagnosticsProperty<TextStyle>("style", Style, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("autofocus", Autofocus, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("showCursor", ShowCursor, defaultValue: false));
            properties.Add(new IntProperty("minLines", MinLines, defaultValue: null));
            properties.Add(new IntProperty("maxLines", MaxLines, defaultValue: null));
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: null));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            properties.Add(new DoubleProperty("textScaleFactor", TextScaleFactor, defaultValue: null));
            properties.Add(new DoubleProperty("cursorWidth", CursorWidth, defaultValue: 2.0));
            properties.Add(new DiagnosticsProperty<Radius>("cursorRadius", CursorRadius, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Color>("cursorColor", CursorColor, defaultValue: null));
            properties.Add(new FlagProperty("selectionEnabled", value: SelectionEnabled, defaultValue: true, ifFalse: "selection disabled"));
            properties.Add(new DiagnosticsProperty<ScrollPhysics>("scrollPhysics", ScrollPhysics, defaultValue: null));
        }



    }


    public class _SelectableTextState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Selectabletext.SelectableText>, ITextSelectionGestureDetectorBuilderDelegate, IAutomaticKeepAliveClientMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _SelectableTextState()
        { }
        internal virtual FlutterSDK.Material.Selectabletext._TextSpanEditingController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual bool _ShowSelectionHandles { get; set; }
        internal virtual FlutterSDK.Material.Selectabletext._SelectableTextSelectionGestureDetectorBuilder _SelectionGestureDetectorBuilder { get; set; }
        public new bool ForcePressEnabled { get; set; }
        public new FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Editabletext.EditableTextState> EditableTextKey { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext.EditableTextState _EditableText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _EffectiveFocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _SelectionGestureDetectorBuilder = new _SelectableTextSelectionGestureDetectorBuilder(state: this);
            _Controller = new _TextSpanEditingController(textSpan: Widget.TextSpan ?? new TextSpan(text: Widget.Data));
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Selectabletext.SelectableText oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Data != oldWidget.Data || Widget.TextSpan != oldWidget.TextSpan)
            {
                _Controller = new _TextSpanEditingController(textSpan: Widget.TextSpan ?? new TextSpan(text: Widget.Data));
            }

            if (_EffectiveFocusNode.HasFocus && _Controller.Selection.IsCollapsed)
            {
                _ShowSelectionHandles = false;
            }

        }




        public new void Dispose()
        {
            _FocusNode?.Dispose();
            base.Dispose();
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
            if (_Controller.Selection.IsCollapsed)
            {
                _EditableText.ToggleToolbar();
            }

        }




        private bool _ShouldShowSelectionHandles(FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
        {
            if (!_SelectionGestureDetectorBuilder.ShouldShowSelectionToolbar) return false;
            if (_Controller.Selection.IsCollapsed) return false;
            if (cause == SelectionChangedCause.Keyboard) return false;
            if (cause == SelectionChangedCause.LongPress) return true;
            if (_Controller.Text.IsNotEmpty) return true;
            return false;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            base.Build(context);




            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            FocusNode focusNode = _EffectiveFocusNode;
            TextSelectionControls textSelectionControls = default(TextSelectionControls);
            bool paintCursorAboveText = default(bool);
            bool cursorOpacityAnimates = default(bool);
            Offset cursorOffset = default(Offset);
            Color cursorColor = Widget.CursorColor;
            Radius cursorRadius = Widget.CursorRadius;
            switch (themeData.Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: ForcePressEnabled = true; textSelectionControls = TextselectionDefaultClass.CupertinoTextSelectionControls; paintCursorAboveText = true; cursorOpacityAnimates = true; cursorColor = (cursorColor == null ? ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor : cursorColor); cursorRadius = (cursorRadius == null ? Radius.Circular(2.0) : cursorRadius); cursorOffset = new Offset(SelectabletextDefaultClass.IOSHorizontalOffset / MediaqueryDefaultClass.MediaQuery.Of(context).DevicePixelRatio, 0); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: ForcePressEnabled = false; textSelectionControls = TextselectionDefaultClass.MaterialTextSelectionControls; paintCursorAboveText = false; cursorOpacityAnimates = false; cursorColor = (cursorColor == null ? themeData.CursorColor : cursorColor); break; }
            DefaultTextStyle defaultTextStyle = TextDefaultClass.DefaultTextStyle.Of(context);
            TextStyle effectiveTextStyle = Widget.Style;
            if (Widget.Style == null || Widget.Style.Inherit) effectiveTextStyle = defaultTextStyle.Style.Merge(Widget.Style);
            if (MediaqueryDefaultClass.MediaQuery.BoldTextOverride(context)) effectiveTextStyle = effectiveTextStyle.Merge(new TextStyle(fontWeight: Dart.UI.UiDefaultClass.FontWeight.Bold));
            Widget child = new RepaintBoundary(child: new EditableText(key: EditableTextKey, style: effectiveTextStyle, readOnly: true, textWidthBasis: Widget.TextWidthBasis ?? defaultTextStyle.TextWidthBasis, showSelectionHandles: _ShowSelectionHandles, showCursor: Widget.ShowCursor, controller: _Controller, focusNode: focusNode, strutStyle: Widget.StrutStyle ?? new StrutStyle(), textAlign: Widget.TextAlign ?? defaultTextStyle.TextAlign ?? TextAlign.Start, textDirection: Widget.TextDirection, textScaleFactor: Widget.TextScaleFactor, autofocus: Widget.Autofocus, forceLine: false, toolbarOptions: Widget.ToolbarOptions, minLines: Widget.MinLines, maxLines: Widget.MaxLines ?? defaultTextStyle.MaxLines, selectionColor: themeData.TextSelectionColor, selectionControls: Widget.SelectionEnabled ? textSelectionControls : null, onSelectionChanged: _HandleSelectionChanged, onSelectionHandleTapped: _HandleSelectionHandleTapped, rendererIgnoresPointer: true, cursorWidth: Widget.CursorWidth, cursorRadius: cursorRadius, cursorColor: cursorColor, cursorOpacityAnimates: cursorOpacityAnimates, cursorOffset: cursorOffset, paintCursorAboveText: paintCursorAboveText, backgroundCursorColor: ColorsDefaultClass.CupertinoColors.InactiveGray, enableInteractiveSelection: Widget.EnableInteractiveSelection, dragStartBehavior: Widget.DragStartBehavior, scrollPhysics: Widget.ScrollPhysics));
            return new Semantics(onTap: () =>
            {
                if (!_Controller.Selection.IsValid) _Controller.Selection = TextSelection.Collapsed(offset: _Controller.Text.Length);
                _EffectiveFocusNode.RequestFocus();
            }
            , onLongPress: () =>
            {
                _EffectiveFocusNode.RequestFocus();
            }
            , child: _SelectionGestureDetectorBuilder.BuildGestureDetector(behavior: HitTestBehavior.Translucent, child: child));
        }



    }

}
