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
namespace FlutterSDK.Widgets.Async
{
    public delegate FlutterSDK.Widgets.Framework.Widget AsyncWidgetBuilder<T>(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Async.AsyncSnapshot<T> snapshot);
    internal static class AsyncDefaultClass
    {
    }

    /// <Summary>
    /// Base class for widgets that build themselves based on interaction with
    /// a specified [Stream].
    ///
    /// A [StreamBuilderBase] is stateful and maintains a summary of the interaction
    /// so far. The type of the summary and how it is updated with each interaction
    /// is defined by sub-classes.
    ///
    /// Examples of summaries include:
    ///
    /// * the running average of a stream of integers;
    /// * the current direction and speed based on a stream of geolocation data;
    /// * a graph displaying data points from a stream.
    ///
    /// In general, the summary is the result of a fold computation over the data
    /// items and errors received from the stream along with pseudo-events
    /// representing termination or change of stream. The initial summary is
    /// specified by sub-classes by overriding [initial]. The summary updates on
    /// receipt of stream data and errors are specified by overriding [afterData] and
    /// [afterError], respectively. If needed, the summary may be updated on stream
    /// termination by overriding [afterDone]. Finally, the summary may be updated
    /// on change of stream by overriding [afterDisconnected] and [afterConnected].
    ///
    /// `T` is the type of stream events.
    ///
    /// `S` is the type of interaction summary.
    ///
    /// See also:
    ///
    ///  * [StreamBuilder], which is specialized for the case where only the most
    ///    recent interaction is needed for widget building.
    /// </Summary>
    public interface IStreamBuilderBase<T, S>
    {
        S Initial();
        S AfterConnected(S current);
        S AfterData(S current, T data);
        S AfterError(S current, @Object error);
        S AfterDone(S current);
        S AfterDisconnected(S current);
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, S currentSummary);
        FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Async.StreamBuilderBase<T, S>> CreateState();
        Stream<T> Stream { get; }
    }


    /// <Summary>
    /// Base class for widgets that build themselves based on interaction with
    /// a specified [Stream].
    ///
    /// A [StreamBuilderBase] is stateful and maintains a summary of the interaction
    /// so far. The type of the summary and how it is updated with each interaction
    /// is defined by sub-classes.
    ///
    /// Examples of summaries include:
    ///
    /// * the running average of a stream of integers;
    /// * the current direction and speed based on a stream of geolocation data;
    /// * a graph displaying data points from a stream.
    ///
    /// In general, the summary is the result of a fold computation over the data
    /// items and errors received from the stream along with pseudo-events
    /// representing termination or change of stream. The initial summary is
    /// specified by sub-classes by overriding [initial]. The summary updates on
    /// receipt of stream data and errors are specified by overriding [afterData] and
    /// [afterError], respectively. If needed, the summary may be updated on stream
    /// termination by overriding [afterDone]. Finally, the summary may be updated
    /// on change of stream by overriding [afterDisconnected] and [afterConnected].
    ///
    /// `T` is the type of stream events.
    ///
    /// `S` is the type of interaction summary.
    ///
    /// See also:
    ///
    ///  * [StreamBuilder], which is specialized for the case where only the most
    ///    recent interaction is needed for widget building.
    /// </Summary>
    public class StreamBuilderBase<T, S> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public StreamBuilderBase(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Stream<T> stream = default(Stream<T>))
        : base(key: key)
        {
            this.Stream = stream;
        }
        public virtual Stream<T> Stream { get; set; }

        /// <Summary>
        /// Returns the initial summary of stream interaction, typically representing
        /// the fact that no interaction has happened at all.
        ///
        /// Sub-classes must override this method to provide the initial value for
        /// the fold computation.
        /// </Summary>
        public virtual S Initial()
        {
            return default(S);
        }


        /// <Summary>
        /// Returns an updated version of the [current] summary reflecting that we
        /// are now connected to a stream.
        ///
        /// The default implementation returns [current] as is.
        /// </Summary>
        public virtual S AfterConnected(S current) => current;



        /// <Summary>
        /// Returns an updated version of the [current] summary following a data event.
        ///
        /// Sub-classes must override this method to specify how the current summary
        /// is combined with the new data item in the fold computation.
        /// </Summary>
        public virtual S AfterData(S current, T data)
        {
            return default(S);
        }


        /// <Summary>
        /// Returns an updated version of the [current] summary following an error.
        ///
        /// The default implementation returns [current] as is.
        /// </Summary>
        public virtual S AfterError(S current, @Object error) => current;



        /// <Summary>
        /// Returns an updated version of the [current] summary following stream
        /// termination.
        ///
        /// The default implementation returns [current] as is.
        /// </Summary>
        public virtual S AfterDone(S current) => current;



        /// <Summary>
        /// Returns an updated version of the [current] summary reflecting that we
        /// are no longer connected to a stream.
        ///
        /// The default implementation returns [current] as is.
        /// </Summary>
        public virtual S AfterDisconnected(S current) => current;



        /// <Summary>
        /// Returns a Widget based on the [currentSummary].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, S currentSummary)
        {
            return default(Widget);
        }


        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Async.StreamBuilderBase<T, S>> CreateState() => new _StreamBuilderBaseState<T, S>();


    }


    /// <Summary>
    /// State for [StreamBuilderBase].
    /// </Summary>
    public class _StreamBuilderBaseState<T, S> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Async.StreamBuilderBase<T, S>>
    {
        public _StreamBuilderBaseState()
        { }
        internal virtual StreamSubscription<T> _Subscription { get; set; }
        internal virtual S _Summary { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Summary = Widget.Initial();
            _Subscribe();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Async.StreamBuilderBase<T, S> oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Stream != Widget.Stream)
            {
                if (_Subscription != null)
                {
                    _Unsubscribe();
                    _Summary = Widget.AfterDisconnected(_Summary);
                }

                _Subscribe();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) => Widget.Build(context, _Summary);



        public new void Dispose()
        {
            _Unsubscribe();
            base.Dispose();
        }




        private void _Subscribe()
        {
            if (Widget.Stream != null)
            {
                _Subscription = Widget.Stream.Listen((T data) =>
                {
                    SetState(() =>
                    {
                        _Summary = Widget.AfterData(_Summary, data);
                    }
                    );
                }
                , onError: (object error) =>
                {
                    SetState(() =>
                    {
                        _Summary = Widget.AfterError(_Summary, error);
                    }
    );
                }
                , onDone: () =>
                {
                    SetState(() =>
                    {
                        _Summary = Widget.AfterDone(_Summary);
                    }
    );
                }
                );
                _Summary = Widget.AfterConnected(_Summary);
            }

        }




        private void _Unsubscribe()
        {
            if (_Subscription != null)
            {
                _Subscription.Cancel();
                _Subscription = null;
            }

        }



    }


    /// <Summary>
    /// Immutable representation of the most recent interaction with an asynchronous
    /// computation.
    ///
    /// See also:
    ///
    ///  * [StreamBuilder], which builds itself based on a snapshot from interacting
    ///    with a [Stream].
    ///  * [FutureBuilder], which builds itself based on a snapshot from interacting
    ///    with a [Future].
    /// </Summary>
    public class AsyncSnapshot<T>
    {
        internal AsyncSnapshot(FlutterSDK.Widgets.Async.ConnectionState connectionState, T data, @Object error)
        : base()
        {
            this.ConnectionState = connectionState;
            this.Data = data;
            this.Error = error;
        }
        public static AsyncSnapshot<T> Nothing()
        {
            var instance = new AsyncSnapshot<T>();
        }
        public static AsyncSnapshot<T> WithData(FlutterSDK.Widgets.Async.ConnectionState state, T data)
        {
            var instance = new AsyncSnapshot<T>();
        }
        public static AsyncSnapshot<T> WithError(FlutterSDK.Widgets.Async.ConnectionState state, @Object error)
        {
            var instance = new AsyncSnapshot<T>();
        }
        public virtual FlutterSDK.Widgets.Async.ConnectionState ConnectionState { get; set; }
        public virtual T Data { get; set; }
        public virtual @Object Error { get; set; }
        public virtual T RequireData { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasData { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasError { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a snapshot like this one, but in the specified [state].
        ///
        /// The [data] and [error] fields persist unmodified, even if the new state is
        /// [ConnectionState.none].
        /// </Summary>
        public virtual AsyncSnapshot<T> InState(FlutterSDK.Widgets.Async.ConnectionState state) => AsyncSnapshot<T>._(state, Data, Error);




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            return other is AsyncSnapshot<T> && other.ConnectionState == ConnectionState && other.Data == Data && other.Error == Error;
        }



    }


    /// <Summary>
    /// Widget that builds itself based on the latest snapshot of interaction with
    /// a [Stream].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=MkKEWHfy99Y}
    ///
    /// Widget rebuilding is scheduled by each interaction, using [State.setState],
    /// but is otherwise decoupled from the timing of the stream. The [builder]
    /// is called at the discretion of the Flutter pipeline, and will thus receive a
    /// timing-dependent sub-sequence of the snapshots that represent the
    /// interaction with the stream.
    ///
    /// As an example, when interacting with a stream producing the integers
    /// 0 through 9, the [builder] may be called with any ordered sub-sequence
    /// of the following snapshots that includes the last one (the one with
    /// ConnectionState.done):
    ///
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.waiting, null)`
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.active, 0)`
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.active, 1)`
    /// * ...
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.active, 9)`
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.done, 9)`
    ///
    /// The actual sequence of invocations of the [builder] depends on the relative
    /// timing of events produced by the stream and the build rate of the Flutter
    /// pipeline.
    ///
    /// Changing the [StreamBuilder] configuration to another stream during event
    /// generation introduces snapshot pairs of the form:
    ///
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.none, 5)`
    /// * `new AsyncSnapshot<int>.withData(ConnectionState.waiting, 5)`
    ///
    /// The latter will be produced only when the new stream is non-null, and the
    /// former only when the old stream is non-null.
    ///
    /// The stream may produce errors, resulting in snapshots of the form:
    ///
    /// * `new AsyncSnapshot<int>.withError(ConnectionState.active, 'some error')`
    ///
    /// The data and error fields of snapshots produced are only changed when the
    /// state is `ConnectionState.active`.
    ///
    /// The initial snapshot data can be controlled by specifying [initialData].
    /// This should be used to ensure that the first frame has the expected value,
    /// as the builder will always be called before the stream listener has a chance
    /// to be processed.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    ///
    /// This sample shows a [StreamBuilder] that listens to a Stream that emits bids
    /// for an auction. Every time the StreamBuilder receives a bid from the Stream,
    /// it will display the price of the bid below an icon. If the Stream emits an
    /// error, the error is displayed below an error icon. When the Stream finishes
    /// emitting bids, the final price is displayed.
    ///
    /// ```dart
    /// Stream<int> _bids = (() async* {
    ///   await Future<void>.delayed(Duration(seconds: 1));
    ///   yield 1;
    ///   await Future<void>.delayed(Duration(seconds: 1));
    /// })();
    ///
    /// Widget build(BuildContext context) {
    ///   return DefaultTextStyle(
    ///     style: Theme.of(context).textTheme.headline2,
    ///     textAlign: TextAlign.center,
    ///     child: Container(
    ///       alignment: FractionalOffset.center,
    ///       color: Colors.white,
    ///       child: StreamBuilder<int>(
    ///         stream: _bids,
    ///         builder: (BuildContext context, AsyncSnapshot<int> snapshot) {
    ///           List<Widget> children;
    ///           if (snapshot.hasError) {
    ///             children = <Widget>[
    ///               Icon(
    ///                 Icons.error_outline,
    ///                 color: Colors.red,
    ///                 size: 60,
    ///               ),
    ///               Padding(
    ///                 padding: const EdgeInsets.only(top: 16),
    ///                 child: Text('Error: ${snapshot.error}'),
    ///               )
    ///             ];
    ///           } else {
    ///             switch (snapshot.connectionState) {
    ///               case ConnectionState.none:
    ///                 children = <Widget>[
    ///                   Icon(
    ///                     Icons.info,
    ///                     color: Colors.blue,
    ///                     size: 60,
    ///                   ),
    ///                   const Padding(
    ///                     padding: EdgeInsets.only(top: 16),
    ///                     child: Text('Select a lot'),
    ///                   )
    ///                 ];
    ///                 break;
    ///               case ConnectionState.waiting:
    ///                 children = <Widget>[
    ///                   SizedBox(
    ///                     child: const CircularProgressIndicator(),
    ///                     width: 60,
    ///                     height: 60,
    ///                   ),
    ///                   const Padding(
    ///                     padding: EdgeInsets.only(top: 16),
    ///                     child: Text('Awaiting bids...'),
    ///                   )
    ///                 ];
    ///                 break;
    ///               case ConnectionState.active:
    ///                 children = <Widget>[
    ///                   Icon(
    ///                     Icons.check_circle_outline,
    ///                     color: Colors.green,
    ///                     size: 60,
    ///                   ),
    ///                   Padding(
    ///                     padding: const EdgeInsets.only(top: 16),
    ///                     child: Text('\$${snapshot.data}'),
    ///                   )
    ///                 ];
    ///                 break;
    ///               case ConnectionState.done:
    ///                 children = <Widget>[
    ///                   Icon(
    ///                     Icons.info,
    ///                     color: Colors.blue,
    ///                     size: 60,
    ///                   ),
    ///                   Padding(
    ///                     padding: const EdgeInsets.only(top: 16),
    ///                     child: Text('\$${snapshot.data} (closed)'),
    ///                   )
    ///                 ];
    ///                 break;
    ///             }
    ///           }
    ///
    ///           return Column(
    ///             mainAxisAlignment: MainAxisAlignment.center,
    ///             crossAxisAlignment: CrossAxisAlignment.center,
    ///             children: children,
    ///           );
    ///         },
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ValueListenableBuilder], which wraps a [ValueListenable] instead of a
    ///    [Stream].
    ///  * [StreamBuilderBase], which supports widget building based on a computation
    ///    that spans all interactions made with the stream.
    /// </Summary>
    public class StreamBuilder<T> : FlutterSDK.Widgets.Async.StreamBuilderBase<T, FlutterSDK.Widgets.Async.AsyncSnapshot<T>>
    {
        public StreamBuilder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T initialData = default(T), Stream<T> stream = default(Stream<T>), FlutterSDK.Widgets.Async.AsyncWidgetBuilder<T> builder = default(FlutterSDK.Widgets.Async.AsyncWidgetBuilder<T>))
        : base(key: key, stream: stream)
        {
            this.InitialData = initialData;
            this.Builder = builder;
        }
        public virtual FlutterSDK.Widgets.Async.AsyncWidgetBuilder<T> Builder { get; set; }
        public virtual T InitialData { get; set; }

        public new AsyncSnapshot<T> Initial() => AsyncSnapshot<T>.WithData(ConnectionState.None, InitialData);



        public new AsyncSnapshot<T> AfterConnected(FlutterSDK.Widgets.Async.AsyncSnapshot<T> current) => current.InState(ConnectionState.Waiting);



        public new AsyncSnapshot<T> AfterData(FlutterSDK.Widgets.Async.AsyncSnapshot<T> current, T data)
        {
            return AsyncSnapshot<T>.WithData(ConnectionState.Active, data);
        }




        public new AsyncSnapshot<T> AfterError(FlutterSDK.Widgets.Async.AsyncSnapshot<T> current, @Object error)
        {
            return AsyncSnapshot<T>.WithError(ConnectionState.Active, error);
        }




        public new AsyncSnapshot<T> AfterDone(FlutterSDK.Widgets.Async.AsyncSnapshot<T> current) => current.InState(ConnectionState.Done);



        public new AsyncSnapshot<T> AfterDisconnected(FlutterSDK.Widgets.Async.AsyncSnapshot<T> current) => current.InState(ConnectionState.None);



        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Async.AsyncSnapshot<T> currentSummary) => Builder(context, currentSummary);


    }


    /// <Summary>
    /// Widget that builds itself based on the latest snapshot of interaction with
    /// a [Future].
    ///
    /// The [future] must have been obtained earlier, e.g. during [State.initState],
    /// [State.didUpdateConfig], or [State.didChangeDependencies]. It must not be
    /// created during the [State.build] or [StatelessWidget.build] method call when
    /// constructing the [FutureBuilder]. If the [future] is created at the same
    /// time as the [FutureBuilder], then every time the [FutureBuilder]'s parent is
    /// rebuilt, the asynchronous task will be restarted.
    ///
    /// A general guideline is to assume that every `build` method could get called
    /// every frame, and to treat omitted calls as an optimization.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=ek8ZPdWj4Qo}
    ///
    /// ## Timing
    ///
    /// Widget rebuilding is scheduled by the completion of the future, using
    /// [State.setState], but is otherwise decoupled from the timing of the future.
    /// The [builder] callback is called at the discretion of the Flutter pipeline, and
    /// will thus receive a timing-dependent sub-sequence of the snapshots that
    /// represent the interaction with the future.
    ///
    /// A side-effect of this is that providing a new but already-completed future
    /// to a [FutureBuilder] will result in a single frame in the
    /// [ConnectionState.waiting] state. This is because there is no way to
    /// synchronously determine that a [Future] has already completed.
    ///
    /// ## Builder contract
    ///
    /// For a future that completes successfully with data, assuming [initialData]
    /// is null, the [builder] will be called with either both or only the latter of
    /// the following snapshots:
    ///
    /// * `new AsyncSnapshot<String>.withData(ConnectionState.waiting, null)`
    /// * `new AsyncSnapshot<String>.withData(ConnectionState.done, 'some data')`
    ///
    /// If that same future instead completed with an error, the [builder] would be
    /// called with either both or only the latter of:
    ///
    /// * `new AsyncSnapshot<String>.withData(ConnectionState.waiting, null)`
    /// * `new AsyncSnapshot<String>.withError(ConnectionState.done, 'some error')`
    ///
    /// The initial snapshot data can be controlled by specifying [initialData]. You
    /// would use this facility to ensure that if the [builder] is invoked before
    /// the future completes, the snapshot carries data of your choice rather than
    /// the default null value.
    ///
    /// The data and error fields of the snapshot change only as the connection
    /// state field transitions from `waiting` to `done`, and they will be retained
    /// when changing the [FutureBuilder] configuration to another future. If the
    /// old future has already completed successfully with data as above, changing
    /// configuration to a new future results in snapshot pairs of the form:
    ///
    /// * `new AsyncSnapshot<String>.withData(ConnectionState.none, 'data of first future')`
    /// * `new AsyncSnapshot<String>.withData(ConnectionState.waiting, 'data of second future')`
    ///
    /// In general, the latter will be produced only when the new future is
    /// non-null, and the former only when the old future is non-null.
    ///
    /// A [FutureBuilder] behaves identically to a [StreamBuilder] configured with
    /// `future?.asStream()`, except that snapshots with `ConnectionState.active`
    /// may appear for the latter, depending on how the stream is implemented.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    ///
    /// This sample shows a [FutureBuilder] that displays a loading spinner while it
    /// loads data. It displays a success icon and text if the [Future] completes
    /// with a result, or an error icon and text if the [Future] completes with an
    /// error. Assume the `_calculation` field is set by pressing a button elsewhere
    /// in the UI.
    ///
    /// ```dart
    /// Future<String> _calculation = Future<String>.delayed(
    ///   Duration(seconds: 2),
    ///   () => 'Data Loaded',
    /// );
    ///
    /// Widget build(BuildContext context) {
    ///   return DefaultTextStyle(
    ///     style: Theme.of(context).textTheme.headline2,
    ///     textAlign: TextAlign.center,
    ///     child: FutureBuilder<String>(
    ///       future: _calculation, // a previously-obtained Future<String> or null
    ///       builder: (BuildContext context, AsyncSnapshot<String> snapshot) {
    ///         List<Widget> children;
    ///         if (snapshot.hasData) {
    ///           children = <Widget>[
    ///             Icon(
    ///               Icons.check_circle_outline,
    ///               color: Colors.green,
    ///               size: 60,
    ///             ),
    ///             Padding(
    ///               padding: const EdgeInsets.only(top: 16),
    ///               child: Text('Result: ${snapshot.data}'),
    ///             )
    ///           ];
    ///         } else if (snapshot.hasError) {
    ///           children = <Widget>[
    ///             Icon(
    ///               Icons.error_outline,
    ///               color: Colors.red,
    ///               size: 60,
    ///             ),
    ///             Padding(
    ///               padding: const EdgeInsets.only(top: 16),
    ///               child: Text('Error: ${snapshot.error}'),
    ///             )
    ///           ];
    ///         } else {
    ///           children = <Widget>[
    ///             SizedBox(
    ///               child: CircularProgressIndicator(),
    ///               width: 60,
    ///               height: 60,
    ///             ),
    ///             const Padding(
    ///               padding: EdgeInsets.only(top: 16),
    ///               child: Text('Awaiting result...'),
    ///             )
    ///           ];
    ///         }
    ///         return Center(
    ///           child: Column(
    ///             mainAxisAlignment: MainAxisAlignment.center,
    ///             crossAxisAlignment: CrossAxisAlignment.center,
    ///             children: children,
    ///           ),
    ///         );
    ///       },
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class FutureBuilder<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public FutureBuilder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Future<T> future = default(Future<T>), T initialData = default(T), FlutterSDK.Widgets.Async.AsyncWidgetBuilder<T> builder = default(FlutterSDK.Widgets.Async.AsyncWidgetBuilder<T>))
        : base(key: key)
        {
            this.Future = future;
            this.InitialData = initialData;
            this.Builder = builder;
        }
        public virtual Future<T> Future { get; set; }
        public virtual FlutterSDK.Widgets.Async.AsyncWidgetBuilder<T> Builder { get; set; }
        public virtual T InitialData { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Async.FutureBuilder<T>> CreateState() => new _FutureBuilderState<T>();


    }


    /// <Summary>
    /// State for [FutureBuilder].
    /// </Summary>
    public class _FutureBuilderState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Async.FutureBuilder<T>>
    {
        public _FutureBuilderState()
        { }
        internal virtual @Object _ActiveCallbackIdentity { get; set; }
        internal virtual FlutterSDK.Widgets.Async.AsyncSnapshot<T> _Snapshot { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Snapshot = AsyncSnapshot<T>.WithData(ConnectionState.None, Widget.InitialData);
            _Subscribe();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Async.FutureBuilder<T> oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Future != Widget.Future)
            {
                if (_ActiveCallbackIdentity != null)
                {
                    _Unsubscribe();
                    _Snapshot = _Snapshot.InState(ConnectionState.None);
                }

                _Subscribe();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) => Widget.Builder(context, _Snapshot);



        public new void Dispose()
        {
            _Unsubscribe();
            base.Dispose();
        }




        private void _Subscribe()
        {
            if (Widget.Future != null)
            {
                object callbackIdentity = new object();
                _ActiveCallbackIdentity = callbackIdentity;
                Widget.Future.Then((T data) =>
                {
                    if (_ActiveCallbackIdentity == callbackIdentity)
                    {
                        SetState(() =>
                        {
                            _Snapshot = AsyncSnapshot<T>.WithData(ConnectionState.Done, data);
                        }
                        );
                    }

                }
                , onError: (object error) =>
                {
                    if (_ActiveCallbackIdentity == callbackIdentity)
                    {
                        SetState(() =>
                        {
                            _Snapshot = AsyncSnapshot<T>.WithError(ConnectionState.Done, error);
                        }
        );
                    }

                }
                );
                _Snapshot = _Snapshot.InState(ConnectionState.Waiting);
            }

        }




        private void _Unsubscribe()
        {
            _ActiveCallbackIdentity = null;
        }



    }


    /// <Summary>
    /// The state of connection to an asynchronous computation.
    ///
    /// See also:
    ///
    ///  * [AsyncSnapshot], which augments a connection state with information
    ///    received from the asynchronous computation.
    /// </Summary>
    public enum ConnectionState
    {

        /// <Summary>
        /// Not currently connected to any asynchronous computation.
        ///
        /// For example, a [FutureBuilder] whose [FutureBuilder.future] is null.
        /// </Summary>
        None,
        /// <Summary>
        /// Connected to an asynchronous computation and awaiting interaction.
        /// </Summary>
        Waiting,
        /// <Summary>
        /// Connected to an active asynchronous computation.
        ///
        /// For example, a [Stream] that has returned at least one value, but is not
        /// yet done.
        /// </Summary>
        Active,
        /// <Summary>
        /// Connected to a terminated asynchronous computation.
        /// </Summary>
        Done,
    }

}
