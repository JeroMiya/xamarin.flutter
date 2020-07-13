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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Form
{
    public delegate string FormFieldValidator<T>(T value);
    public delegate void FormFieldSetter<T>(T newValue);
    public delegate FlutterSDK.Widgets.Framework.Widget FormFieldBuilder<T>(FlutterSDK.Widgets.Form.FormFieldState<T> field);
    internal static class FormDefaultClass
    {
    }

    /// <Summary>
    /// An optional container for grouping together multiple form field widgets
    /// (e.g. [TextField] widgets).
    ///
    /// Each individual form field should be wrapped in a [FormField] widget, with
    /// the [Form] widget as a common ancestor of all of those. Call methods on
    /// [FormState] to save, reset, or validate each [FormField] that is a
    /// descendant of this [Form]. To obtain the [FormState], you may use [Form.of]
    /// with a context whose ancestor is the [Form], or pass a [GlobalKey] to the
    /// [Form] constructor and call [GlobalKey.currentState].
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold}
    /// This example shows a [Form] with one [TextFormField] to enter an email
    /// address and a [RaisedButton] to submit the form. A [GlobalKey] is used here
    /// to identify the [Form] and validate input.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/form.png)
    ///
    /// ```dart
    /// final _formKey = GlobalKey<FormState>();
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Form(
    ///     key: _formKey,
    ///     child: Column(
    ///       crossAxisAlignment: CrossAxisAlignment.start,
    ///       children: <Widget>[
    ///         TextFormField(
    ///           decoration: const InputDecoration(
    ///             hintText: 'Enter your email',
    ///           ),
    ///           validator: (value) {
    ///             if (value.isEmpty) {
    ///               return 'Please enter some text';
    ///             }
    ///             return null;
    ///           },
    ///         ),
    ///         Padding(
    ///           padding: const EdgeInsets.symmetric(vertical: 16.0),
    ///           child: RaisedButton(
    ///             onPressed: () {
    ///               // Validate will return true if the form is valid, or false if
    ///               // the form is invalid.
    ///               if (_formKey.currentState.validate()) {
    ///                 // Process data.
    ///               }
    ///             },
    ///             child: Text('Submit'),
    ///           ),
    ///         ),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [GlobalKey], a key that is unique across the entire app.
    ///  * [FormField], a single form field widget that maintains the current state.
    ///  * [TextFormField], a convenience widget that wraps a [TextField] widget in a [FormField].
    /// </Summary>
    public class Form : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Form(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool autovalidate = false, FlutterSDK.Widgets.Navigator.WillPopCallback onWillPop = default(FlutterSDK.Widgets.Navigator.WillPopCallback), VoidCallback onChanged = default(VoidCallback))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
    public virtual bool Autovalidate { get; set; }
    public virtual FlutterSDK.Widgets.Navigator.WillPopCallback OnWillPop { get; set; }
    public virtual VoidCallback OnChanged { get; set; }
    #endregion

    #region methods

    /// <Summary>
    /// Returns the closest [FormState] which encloses the given context.
    ///
    /// Typical usage is as follows:
    ///
    /// ```dart
    /// FormState form = Form.of(context);
    /// form.save();
    /// ```
    /// </Summary>
    public virtual FlutterSDK.Widgets.Form.FormState Of(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        _FormScope scope = context.DependOnInheritedWidgetOfExactType();
        return scope?._FormState;
    }




    public new FlutterSDK.Widgets.Form.FormState CreateState() => new FormState();


    #endregion
}


/// <Summary>
/// State associated with a [Form] widget.
///
/// A [FormState] object can be used to [save], [reset], and [validate] every
/// [FormField] that is a descendant of the associated [Form].
///
/// Typically obtained via [Form.of].
/// </Summary>
public class FormState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Form.Form>
{
    #region constructors
    public FormState()
    { }
    #endregion

    #region fields
    internal virtual int _Generation { get; set; }
    internal virtual HashSet<FlutterSDK.Widgets.Form.FormFieldState<object>> _Fields { get; set; }
    #endregion

    #region methods

    private void _FieldDidChange()
    {
        if (Widget.OnChanged != null) Widget.OnChanged();
        _ForceRebuild();
    }




    private void _ForceRebuild()
    {
        SetState(() =>
        {
            ++_Generation;
        }
        );
    }




    private void _Register(FlutterSDK.Widgets.Form.FormFieldState<object> field)
    {
        _Fields.Add(field);
    }




    private void _Unregister(FlutterSDK.Widgets.Form.FormFieldState<object> field)
    {
        _Fields.Remove(field);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        if (Widget.Autovalidate) _Validate();
        return new WillPopScope(onWillPop: Widget.OnWillPop, child: new _FormScope(formState: this, generation: _Generation, child: Widget.Child));
    }




    /// <Summary>
    /// Saves every [FormField] that is a descendant of this [Form].
    /// </Summary>
    public virtual void Save()
    {
        foreach (FormFieldState<object> field in _Fields) field.Save();
    }




    /// <Summary>
    /// Resets every [FormField] that is a descendant of this [Form] back to its
    /// [FormField.initialValue].
    ///
    /// The [Form.onChanged] callback will be called.
    ///
    /// If the form's [Form.autovalidate] property is true, the fields will all be
    /// revalidated after being reset.
    /// </Summary>
    public virtual void Reset()
    {
        foreach (FormFieldState<object> field in _Fields) field.Reset();
        _FieldDidChange();
    }




    /// <Summary>
    /// Validates every [FormField] that is a descendant of this [Form], and
    /// returns true if there are no errors.
    ///
    /// The form will rebuild to report the results.
    /// </Summary>
    public virtual bool Validate()
    {
        _ForceRebuild();
        return _Validate();
    }




    private bool _Validate()
    {
        bool hasError = false;
        foreach (FormFieldState<object> field in _Fields) hasError = !field.Validate() || hasError;
        return !hasError;
    }



    #endregion
}


public class _FormScope : FlutterSDK.Widgets.Framework.InheritedWidget
{
    #region constructors
    public _FormScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Form.FormState formState = default(FlutterSDK.Widgets.Form.FormState), int generation = default(int))
    : base(key: key, child: child)

}
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Form.FormState _FormState { get; set; }
internal virtual int _Generation { get; set; }
public virtual FlutterSDK.Widgets.Form.Form Form { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool UpdateShouldNotify(FlutterSDK.Widgets.Form._FormScope old) => _Generation != old._Generation;

public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => _Generation != old._Generation;


#endregion
}


/// <Summary>
/// A single form field.
///
/// This widget maintains the current state of the form field, so that updates
/// and validation errors are visually reflected in the UI.
///
/// When used inside a [Form], you can use methods on [FormState] to query or
/// manipulate the form data as a whole. For example, calling [FormState.save]
/// will invoke each [FormField]'s [onSaved] callback in turn.
///
/// Use a [GlobalKey] with [FormField] if you want to retrieve its current
/// state, for example if you want one form field to depend on another.
///
/// A [Form] ancestor is not required. The [Form] simply makes it easier to
/// save, reset, or validate multiple fields at once. To use without a [Form],
/// pass a [GlobalKey] to the constructor and use [GlobalKey.currentState] to
/// save or reset the form field.
///
/// See also:
///
///  * [Form], which is the widget that aggregates the form fields.
///  * [TextField], which is a commonly used form field for entering text.
/// </Summary>
public class FormField<T> : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public FormField(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Form.FormFieldBuilder<T> builder = default(FlutterSDK.Widgets.Form.FormFieldBuilder<T>), FlutterSDK.Widgets.Form.FormFieldSetter<T> onSaved = default(FlutterSDK.Widgets.Form.FormFieldSetter<T>), FlutterSDK.Widgets.Form.FormFieldValidator<T> validator = default(FlutterSDK.Widgets.Form.FormFieldValidator<T>), T initialValue = default(T), bool autovalidate = false, bool enabled = true)
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Form.FormFieldSetter<T> OnSaved { get; set; }
public virtual FlutterSDK.Widgets.Form.FormFieldValidator<T> Validator { get; set; }
public virtual FlutterSDK.Widgets.Form.FormFieldBuilder<T> Builder { get; set; }
public virtual T InitialValue { get; set; }
public virtual bool Autovalidate { get; set; }
public virtual bool Enabled { get; set; }
#endregion

#region methods

public new FormFieldState<T> CreateState() => new FormFieldState<T>();


#endregion
}


/// <Summary>
/// The current state of a [FormField]. Passed to the [FormFieldBuilder] method
/// for use in constructing the form field's widget.
/// </Summary>
public class FormFieldState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Form.FormField<T>>
{
    #region constructors
    public FormFieldState()
    { }
    #endregion

    #region fields
    internal virtual T _Value { get; set; }
    internal virtual string _ErrorText { get; set; }
    public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual string ErrorText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool HasError { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool IsValid { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Calls the [FormField]'s onSaved method with the current value.
    /// </Summary>
    public virtual void Save()
    {
        if (Widget.OnSaved != null) Widget.OnSaved(Value);
    }




    /// <Summary>
    /// Resets the field to its initial value.
    /// </Summary>
    public virtual void Reset()
    {
        SetState(() =>
        {
            _Value = Widget.InitialValue;
            _ErrorText = null;
        }
        );
    }




    /// <Summary>
    /// Calls [FormField.validator] to set the [errorText]. Returns true if there
    /// were no errors.
    ///
    /// See also:
    ///
    ///  * [isValid], which passively gets the validity without setting
    ///    [errorText] or [hasError].
    /// </Summary>
    public virtual bool Validate()
    {
        SetState(() =>
        {
            _Validate();
        }
        );
        return !HasError;
    }




    private void _Validate()
    {
        if (Widget.Validator != null) _ErrorText = Widget.Validator(_Value);
    }




    /// <Summary>
    /// Updates this field's state to the new value. Useful for responding to
    /// child widget changes, e.g. [Slider]'s [Slider.onChanged] argument.
    ///
    /// Triggers the [Form.onChanged] callback and, if the [Form.autovalidate]
    /// field is set, revalidates all the fields of the form.
    /// </Summary>
    public virtual void DidChange(T value)
    {
        SetState(() =>
        {
            _Value = value;
        }
        );
        FormDefaultClass.Form.Of(Context)?._FieldDidChange();
    }




    /// <Summary>
    /// Sets the value associated with this form field.
    ///
    /// This method should be only be called by subclasses that need to update
    /// the form field value due to state changes identified during the widget
    /// build phase, when calling `setState` is prohibited. In all other cases,
    /// the value should be set by a call to [didChange], which ensures that
    /// `setState` is called.
    /// </Summary>
    public virtual void SetValue(T value)
    {
        _Value = value;
    }




    public new void InitState()
    {
        base.InitState();
        _Value = Widget.InitialValue;
    }




    public new void Deactivate()
    {
        FormDefaultClass.Form.Of(Context)?._Unregister(this);
        base.Deactivate();
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        if (Widget.Autovalidate && Widget.Enabled) _Validate();
        FormDefaultClass.Form.Of(context)?._Register(this);
        return Widget.Builder(this);
    }



    #endregion
}

}
