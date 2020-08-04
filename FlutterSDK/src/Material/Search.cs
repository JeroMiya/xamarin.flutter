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
namespace FlutterSDK.Material.Search
{
    internal static class SearchDefaultClass
    {
        /// <Summary>
        /// Shows a full screen search page and returns the search result selected by
        /// the user when the page is closed.
        ///
        /// The search page consists of an app bar with a search field and a body which
        /// can either show suggested search queries or the search results.
        ///
        /// The appearance of the search page is determined by the provided
        /// `delegate`. The initial query string is given by `query`, which defaults
        /// to the empty string. When `query` is set to null, `delegate.query` will
        /// be used as the initial query.
        ///
        /// This method returns the selected search result, which can be set in the
        /// [SearchDelegate.close] call. If the search page is closed with the system
        /// back button, it returns null.
        ///
        /// A given [SearchDelegate] can only be associated with one active [showSearch]
        /// call. Call [SearchDelegate.close] before re-using the same delegate instance
        /// for another [showSearch] call.
        ///
        /// The transition to the search page triggered by this method looks best if the
        /// screen triggering the transition contains an [AppBar] at the top and the
        /// transition is called from an [IconButton] that's part of [AppBar.actions].
        /// The animation provided by [SearchDelegate.transitionAnimation] can be used
        /// to trigger additional animations in the underlying page while the search
        /// page fades in or out. This is commonly used to animate an [AnimatedIcon] in
        /// the [AppBar.leading] position e.g. from the hamburger menu to the back arrow
        /// used to exit the search page.
        ///
        /// See also:
        ///
        ///  * [SearchDelegate] to define the content of the search page.
        /// </Summary>
        internal static Future<T> ShowSearch<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Material.Search.SearchDelegate<T> @delegate = default(FlutterSDK.Material.Search.SearchDelegate<T>), string query = default(string))
        {


            delegate.Query = query ?? delegate.Query;
            delegate._CurrentBody = _SearchBody.Suggestions;
            return NavigatorDefaultClass.Navigator.Of(context).Push(new _SearchPageRoute<T>(@delegate: @delegate));
        }



    }

    /// <Summary>
    /// Delegate for [showSearch] to define the content of the search page.
    ///
    /// The search page always shows an [AppBar] at the top where users can
    /// enter their search queries. The buttons shown before and after the search
    /// query text field can be customized via [SearchDelegate.leading] and
    /// [SearchDelegate.actions].
    ///
    /// The body below the [AppBar] can either show suggested queries (returned by
    /// [SearchDelegate.buildSuggestions]) or - once the user submits a search  - the
    /// results of the search as returned by [SearchDelegate.buildResults].
    ///
    /// [SearchDelegate.query] always contains the current query entered by the user
    /// and should be used to build the suggestions and results.
    ///
    /// The results can be brought on screen by calling [SearchDelegate.showResults]
    /// and you can go back to showing the suggestions by calling
    /// [SearchDelegate.showSuggestions].
    ///
    /// Once the user has selected a search result, [SearchDelegate.close] should be
    /// called to remove the search page from the top of the navigation stack and
    /// to notify the caller of [showSearch] about the selected search result.
    ///
    /// A given [SearchDelegate] can only be associated with one active [showSearch]
    /// call. Call [SearchDelegate.close] before re-using the same delegate instance
    /// for another [showSearch] call.
    /// </Summary>
    public interface ISearchDelegate<T>
    {
        FlutterSDK.Widgets.Framework.Widget BuildSuggestions(FlutterSDK.Widgets.Framework.BuildContext context);
        FlutterSDK.Widgets.Framework.Widget BuildResults(FlutterSDK.Widgets.Framework.BuildContext context);
        FlutterSDK.Widgets.Framework.Widget BuildLeading(FlutterSDK.Widgets.Framework.BuildContext context);
        List<FlutterSDK.Widgets.Framework.Widget> BuildActions(FlutterSDK.Widgets.Framework.BuildContext context);
        FlutterSDK.Material.Themedata.ThemeData AppBarTheme(FlutterSDK.Widgets.Framework.BuildContext context);
        void ShowResults(FlutterSDK.Widgets.Framework.BuildContext context);
        void ShowSuggestions(FlutterSDK.Widgets.Framework.BuildContext context);
        void Close(FlutterSDK.Widgets.Framework.BuildContext context, T result);
        string SearchFieldLabel { get; }
        FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; }
        FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; }
        string Query { get; set; }
        FlutterSDK.Animation.Animation.Animation<double> TransitionAnimation { get; }
    }


    /// <Summary>
    /// Delegate for [showSearch] to define the content of the search page.
    ///
    /// The search page always shows an [AppBar] at the top where users can
    /// enter their search queries. The buttons shown before and after the search
    /// query text field can be customized via [SearchDelegate.leading] and
    /// [SearchDelegate.actions].
    ///
    /// The body below the [AppBar] can either show suggested queries (returned by
    /// [SearchDelegate.buildSuggestions]) or - once the user submits a search  - the
    /// results of the search as returned by [SearchDelegate.buildResults].
    ///
    /// [SearchDelegate.query] always contains the current query entered by the user
    /// and should be used to build the suggestions and results.
    ///
    /// The results can be brought on screen by calling [SearchDelegate.showResults]
    /// and you can go back to showing the suggestions by calling
    /// [SearchDelegate.showSuggestions].
    ///
    /// Once the user has selected a search result, [SearchDelegate.close] should be
    /// called to remove the search page from the top of the navigation stack and
    /// to notify the caller of [showSearch] about the selected search result.
    ///
    /// A given [SearchDelegate] can only be associated with one active [showSearch]
    /// call. Call [SearchDelegate.close] before re-using the same delegate instance
    /// for another [showSearch] call.
    /// </Summary>
    public class SearchDelegate<T>
    {
        /// <Summary>
        /// Constructor to be called by subclasses which may specify [searchFieldLabel], [keyboardType] and/or
        /// [textInputAction].
        ///
        /// {@tool snippet}
        /// ```dart
        /// class CustomSearchHintDelegate extends SearchDelegate {
        ///   CustomSearchHintDelegate({
        ///     String hintText,
        ///   }) : super(
        ///     searchFieldLabel: hintText,
        ///     keyboardType: TextInputType.text,
        ///     textInputAction: TextInputAction.search,
        ///   );
        ///
        ///   @override
        ///   Widget buildLeading(BuildContext context) => Text("leading");
        ///
        ///   @override
        ///   Widget buildSuggestions(BuildContext context) => Text("suggestions");
        ///
        ///   @override
        ///   Widget buildResults(BuildContext context) => Text('results');
        ///
        ///   @override
        ///   List<Widget> buildActions(BuildContext context) => [];
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public SearchDelegate(string searchFieldLabel = default(string), FlutterSDK.Services.Textinput.TextInputType keyboardType = default(FlutterSDK.Services.Textinput.TextInputType), FlutterSDK.Services.Textinput.TextInputAction textInputAction = default(FlutterSDK.Services.Textinput.TextInputAction))
        {
            this.SearchFieldLabel = searchFieldLabel;
            this.KeyboardType = keyboardType;
            this.TextInputAction = textInputAction;
        }
        /// <Summary>
        /// The hint text that is shown in the search field when it is empty.
        ///
        /// If this value is set to null, the value of MaterialLocalizations.of(context).searchFieldLabel will be used instead.
        /// </Summary>
        public virtual string SearchFieldLabel { get; set; }
        /// <Summary>
        /// The type of action button to use for the keyboard.
        ///
        /// Defaults to the default value specified in [TextField].
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; set; }
        /// <Summary>
        /// The text input action configuring the soft keyboard to a particular action
        /// button.
        ///
        /// Defaults to [TextInputAction.search].
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _QueryTextController { get; set; }
        internal virtual FlutterSDK.Animation.Animations.ProxyAnimation _ProxyAnimation { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<FlutterSDK.Material.Search._SearchBody> _CurrentBodyNotifier { get; set; }
        internal virtual FlutterSDK.Material.Search._SearchPageRoute<T> _Route { get; set; }
        public virtual string Query { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.Animation<double> TransitionAnimation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Material.Search._SearchBody _CurrentBody { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Suggestions shown in the body of the search page while the user types a
        /// query into the search field.
        ///
        /// The delegate method is called whenever the content of [query] changes.
        /// The suggestions should be based on the current [query] string. If the query
        /// string is empty, it is good practice to show suggested queries based on
        /// past queries or the current context.
        ///
        /// Usually, this method will return a [ListView] with one [ListTile] per
        /// suggestion. When [ListTile.onTap] is called, [query] should be updated
        /// with the corresponding suggestion and the results page should be shown
        /// by calling [showResults].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildSuggestions(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Widget);
        }


        /// <Summary>
        /// The results shown after the user submits a search from the search page.
        ///
        /// The current value of [query] can be used to determine what the user
        /// searched for.
        ///
        /// This method might be applied more than once to the same query.
        /// If your [buildResults] method is computationally expensive, you may want
        /// to cache the search results for one or more queries.
        ///
        /// Typically, this method returns a [ListView] with the search results.
        /// When the user taps on a particular search result, [close] should be called
        /// with the selected result as argument. This will close the search page and
        /// communicate the result back to the initial caller of [showSearch].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildResults(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Widget);
        }


        /// <Summary>
        /// A widget to display before the current query in the [AppBar].
        ///
        /// Typically an [IconButton] configured with a [BackButtonIcon] that exits
        /// the search with [close]. One can also use an [AnimatedIcon] driven by
        /// [transitionAnimation], which animates from e.g. a hamburger menu to the
        /// back button as the search overlay fades in.
        ///
        /// Returns null if no widget should be shown.
        ///
        /// See also:
        ///
        ///  * [AppBar.leading], the intended use for the return value of this method.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildLeading(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Widgets to display after the search query in the [AppBar].
        ///
        /// If the [query] is not empty, this should typically contain a button to
        /// clear the query and show the suggestions again (via [showSuggestions]) if
        /// the results are currently shown.
        ///
        /// Returns null if no widget should be shown
        ///
        /// See also:
        ///
        ///  * [AppBar.actions], the intended use for the return value of this method.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> BuildActions(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(List<Widget>);
        }


        /// <Summary>
        /// The theme used to style the [AppBar].
        ///
        /// By default, a white theme is used.
        ///
        /// See also:
        ///
        ///  * [AppBar.backgroundColor], which is set to [ThemeData.primaryColor].
        ///  * [AppBar.iconTheme], which is set to [ThemeData.primaryIconTheme].
        ///  * [AppBar.textTheme], which is set to [ThemeData.primaryTextTheme].
        ///  * [AppBar.brightness], which is set to [ThemeData.primaryColorBrightness].
        /// </Summary>
        public virtual FlutterSDK.Material.Themedata.ThemeData AppBarTheme(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);

            return theme.CopyWith(primaryColor: ColorsDefaultClass.Colors.White, primaryIconTheme: theme.PrimaryIconTheme.CopyWith(color: ColorsDefaultClass.Colors.Grey), primaryColorBrightness: Brightness.Light, primaryTextTheme: theme.TextTheme);
        }




        /// <Summary>
        /// Transition from the suggestions returned by [buildSuggestions] to the
        /// [query] results returned by [buildResults].
        ///
        /// If the user taps on a suggestion provided by [buildSuggestions] the
        /// screen should typically transition to the page showing the search
        /// results for the suggested query. This transition can be triggered
        /// by calling this method.
        ///
        /// See also:
        ///
        ///  * [showSuggestions] to show the search suggestions again.
        /// </Summary>
        public virtual void ShowResults(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _FocusNode?.Unfocus();
            _CurrentBody = _SearchBody.Results;
        }




        /// <Summary>
        /// Transition from showing the results returned by [buildResults] to showing
        /// the suggestions returned by [buildSuggestions].
        ///
        /// Calling this method will also put the input focus back into the search
        /// field of the [AppBar].
        ///
        /// If the results are currently shown this method can be used to go back
        /// to showing the search suggestions.
        ///
        /// See also:
        ///
        ///  * [showResults] to show the search results.
        /// </Summary>
        public virtual void ShowSuggestions(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            _FocusNode.RequestFocus();
            _CurrentBody = _SearchBody.Suggestions;
        }




        /// <Summary>
        /// Closes the search page and returns to the underlying route.
        ///
        /// The value provided for `result` is used as the return value of the call
        /// to [showSearch] that launched the search initially.
        /// </Summary>
        public virtual void Close(FlutterSDK.Widgets.Framework.BuildContext context, T result)
        {
            _CurrentBody = null;
            _FocusNode?.Unfocus();
            NavigatorDefaultClass.Navigator.Of(context);
            NavigatorDefaultClass.Navigator.Of(context).PopUntil((Route<object> route) => =>route == _Route);
            NavigatorDefaultClass.Navigator.Of(context).Pop(result);
        }



    }


    public class _SearchPageRoute<T> : FlutterSDK.Widgets.Pages.PageRoute<T>
    {
        public _SearchPageRoute(FlutterSDK.Material.Search.SearchDelegate<T> @delegate = default(FlutterSDK.Material.Search.SearchDelegate<T>))
        : base()
        {
            this.@delegate = @delegate;

            Delegate._Route = this;
        }


        public virtual FlutterSDK.Material.Search.SearchDelegate<T> @delegate { get; set; }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string BarrierLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool MaintainState { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new FadeTransition(opacity: animation, child: child);
        }




        public new FlutterSDK.Animation.Animation.Animation<double> CreateAnimation()
        {
            Animation<double> animation = base.CreateAnimation();
            Delegate._ProxyAnimation.Parent = animation;
            return animation;
        }




        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation)
        {
            return new _SearchPage<T>(@delegate: @Delegate, animation: animation);
        }




        public new void DidComplete(T result)
        {
            base.DidComplete(result);

            Delegate._Route = null;
            Delegate._CurrentBody = null;
        }



    }


    public class _SearchPage<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _SearchPage(FlutterSDK.Material.Search.SearchDelegate<T> @delegate = default(FlutterSDK.Material.Search.SearchDelegate<T>), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>))
        {
            this.@delegate = @delegate;
            this.Animation = animation;
        }
        public virtual FlutterSDK.Material.Search.SearchDelegate<T> @delegate { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _SearchPageState<T>();


    }


    public class _SearchPageState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Search._SearchPage<T>>
    {
        public _SearchPageState()
        { }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }

        public new void InitState()
        {
            base.InitState();
            Widget.Delegate._QueryTextController.AddListener(_OnQueryChanged);
            Widget.Animation.AddStatusListener(_OnAnimationStatusChanged);
            Widget.Delegate._CurrentBodyNotifier.AddListener(_OnSearchBodyChanged);
            FocusNode.AddListener(_OnFocusChanged);
            Widget.Delegate._FocusNode = FocusNode;
        }




        public new void Dispose()
        {
            base.Dispose();
            Widget.Delegate._QueryTextController.RemoveListener(_OnQueryChanged);
            Widget.Animation.RemoveStatusListener(_OnAnimationStatusChanged);
            Widget.Delegate._CurrentBodyNotifier.RemoveListener(_OnSearchBodyChanged);
            Widget.Delegate._FocusNode = null;
            FocusNode.Dispose();
        }




        private void _OnAnimationStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status != AnimationStatus.Completed)
            {
                return;
            }

            Widget.Animation.RemoveStatusListener(_OnAnimationStatusChanged);
            if (Widget.Delegate._CurrentBody == _SearchBody.Suggestions)
            {
                FocusNode.RequestFocus();
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Material.Search._SearchPage<T> oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Delegate != oldWidget.Delegate)
            {
                oldWidget.Delegate._QueryTextController.RemoveListener(_OnQueryChanged);
                Widget.Delegate._QueryTextController.AddListener(_OnQueryChanged);
                oldWidget.Delegate._CurrentBodyNotifier.RemoveListener(_OnSearchBodyChanged);
                Widget.Delegate._CurrentBodyNotifier.AddListener(_OnSearchBodyChanged);
                oldWidget.Delegate._FocusNode = null;
                Widget.Delegate._FocusNode = FocusNode;
            }

        }




        private void _OnFocusChanged()
        {
            if (FocusNode.HasFocus && Widget.Delegate._CurrentBody != _SearchBody.Suggestions)
            {
                Widget.Delegate.ShowSuggestions(Context);
            }

        }




        private void _OnQueryChanged()
        {
            SetState(() =>
            {
            }
            );
        }




        private void _OnSearchBodyChanged()
        {
            SetState(() =>
            {
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = Widget.Delegate.AppBarTheme(context);
            string searchFieldLabel = Widget.Delegate.SearchFieldLabel ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).SearchFieldLabel;
            Widget body = default(Widget);
            switch (Widget.Delegate._CurrentBody) { case _SearchBody.Suggestions: body = new KeyedSubtree(key: new ValueKey<_SearchBody>(_SearchBody.Suggestions), child: Widget.Delegate.BuildSuggestions(context)); break; case _SearchBody.Results: body = new KeyedSubtree(key: new ValueKey<_SearchBody>(_SearchBody.Results), child: Widget.Delegate.BuildResults(context)); break; }
            string routeName = default(string);
            switch (theme.Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: routeName = ""; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: routeName = searchFieldLabel; }
            return new Semantics(explicitChildNodes: true, scopesRoute: true, namesRoute: true, label: routeName, child: new Scaffold(appBar: new AppBar(backgroundColor: theme.PrimaryColor, iconTheme: theme.PrimaryIconTheme, textTheme: theme.PrimaryTextTheme, brightness: theme.PrimaryColorBrightness, leading: Widget.Delegate.BuildLeading(context), title: new TextField(controller: Widget.Delegate._QueryTextController, focusNode: FocusNode, style: theme.TextTheme.Headline6, textInputAction: Widget.Delegate.TextInputAction, keyboardType: Widget.Delegate.KeyboardType, onSubmitted: (string _) =>
            {
                Widget.Delegate.ShowResults(context);
            }
            , decoration: new InputDecoration(border: InputborderDefaultClass.InputBorder.None, hintText: searchFieldLabel, hintStyle: theme.InputDecorationTheme.HintStyle)), actions: Widget.Delegate.BuildActions(context)), body: new AnimatedSwitcher(duration: new TimeSpan(milliseconds: 300), child: body)));
        }



    }


    /// <Summary>
    /// Describes the body that is currently shown under the [AppBar] in the
    /// search page.
    /// </Summary>
    public enum _SearchBody
    {

        /// <Summary>
        /// Suggested queries are shown in the body.
        ///
        /// The suggested queries are generated by [SearchDelegate.buildSuggestions].
        /// </Summary>
        Suggestions,
        /// <Summary>
        /// Search results are currently shown in the body.
        ///
        /// The search results are generated by [SearchDelegate.buildResults].
        /// </Summary>
        Results,
    }

}
