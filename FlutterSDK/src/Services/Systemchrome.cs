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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Services.Systemchrome
{
    internal static class SystemchromeDefaultClass
    {
        internal static List<string> _Stringify(List<object> list)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Specifies a description of the application that is pertinent to the
    /// embedder's application switcher (also known as "recent tasks") user
    /// interface.
    ///
    /// Used by [SystemChrome.setApplicationSwitcherDescription].
    /// </Summary>
    public class ApplicationSwitcherDescription
    {
        #region constructors
        public ApplicationSwitcherDescription(string label = default(string), int primaryColor = default(int))
    
}
    #endregion

    #region fields
    public virtual string Label { get; set; }
    public virtual int PrimaryColor { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Specifies a preference for the style of the system overlays.
///
/// Used by [SystemChrome.setSystemUIOverlayStyle].
/// </Summary>
public class SystemUiOverlayStyle
{
    #region constructors
    public SystemUiOverlayStyle(FlutterBinding.UI.Color systemNavigationBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color systemNavigationBarDividerColor = default(FlutterBinding.UI.Color), Brightness systemNavigationBarIconBrightness = default(Brightness), FlutterBinding.UI.Color statusBarColor = default(FlutterBinding.UI.Color), Brightness statusBarBrightness = default(Brightness), Brightness statusBarIconBrightness = default(Brightness))

}
#endregion

#region fields
public virtual FlutterBinding.UI.Color SystemNavigationBarColor { get; set; }
public virtual FlutterBinding.UI.Color SystemNavigationBarDividerColor { get; set; }
public virtual Brightness SystemNavigationBarIconBrightness { get; set; }
public virtual FlutterBinding.UI.Color StatusBarColor { get; set; }
public virtual Brightness StatusBarBrightness { get; set; }
public virtual Brightness StatusBarIconBrightness { get; set; }
public virtual FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle Light { get; set; }
public virtual FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle Dark { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Convert this event to a map for serialization.
/// </Summary>
private Dictionary<string, object> _ToMap()
{
    return new Dictionary<string, object> { { "systemNavigationBarColor", SystemNavigationBarColor?.Value }{ "systemNavigationBarDividerColor", SystemNavigationBarDividerColor?.Value }{ "statusBarColor", StatusBarColor?.Value }{ "statusBarBrightness", StatusBarBrightness?.ToString() }{ "statusBarIconBrightness", StatusBarIconBrightness?.ToString() }{ "systemNavigationBarIconBrightness", SystemNavigationBarIconBrightness?.ToString() } };
}





/// <Summary>
/// Creates a copy of this theme with the given fields replaced with new values.
/// </Summary>
public virtual FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle CopyWith(FlutterBinding.UI.Color systemNavigationBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color systemNavigationBarDividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color statusBarColor = default(FlutterBinding.UI.Color), Brightness statusBarBrightness = default(Brightness), Brightness statusBarIconBrightness = default(Brightness), Brightness systemNavigationBarIconBrightness = default(Brightness))
{
    return new SystemUiOverlayStyle(systemNavigationBarColor: systemNavigationBarColor ?? this.SystemNavigationBarColor, systemNavigationBarDividerColor: systemNavigationBarDividerColor ?? this.SystemNavigationBarDividerColor, statusBarColor: statusBarColor ?? this.StatusBarColor, statusBarIconBrightness: statusBarIconBrightness ?? this.StatusBarIconBrightness, statusBarBrightness: statusBarBrightness ?? this.StatusBarBrightness, systemNavigationBarIconBrightness: systemNavigationBarIconBrightness ?? this.SystemNavigationBarIconBrightness);
}




public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is SystemUiOverlayStyle && other.SystemNavigationBarColor == SystemNavigationBarColor && other.SystemNavigationBarDividerColor == SystemNavigationBarDividerColor && other.StatusBarColor == StatusBarColor && other.StatusBarIconBrightness == StatusBarIconBrightness && other.StatusBarBrightness == StatusBarBrightness && other.SystemNavigationBarIconBrightness == SystemNavigationBarIconBrightness;
}



#endregion
}


/// <Summary>
/// Controls specific aspects of the operating system's graphical interface and
/// how it interacts with the application.
/// </Summary>
public class SystemChrome
{
    #region constructors
    internal SystemChrome()

}
#endregion

#region fields
internal virtual FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle _PendingStyle { get; set; }
internal virtual FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle _LatestStyle { get; set; }
public virtual FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle LatestStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Specifies the set of orientations the application interface can
/// be displayed in.
///
/// The `orientation` argument is a list of [DeviceOrientation] enum values.
/// The empty list causes the application to defer to the operating system
/// default.
///
/// ## Limitations
///
/// This setting will only be respected on iPad if multitasking is disabled.
///
/// You can decide to opt out of multitasking on iPad, then
/// setPreferredOrientations will work but your app will not
/// support Slide Over and Split View multitasking anymore.
///
/// Should you decide to opt out of multitasking you can do this by
/// setting "Requires full screen" to true in the Xcode Deployment Info.
/// </Summary>
public virtual Future<object> SetPreferredOrientations(List<FlutterSDK.Services.Systemchrome.DeviceOrientation> orientations)
async
{
    await SystemchannelsDefaultClass.SystemChannels.Platform.InvokeMethod("SystemChrome.setPreferredOrientations", SystemchromeDefaultClass._Stringify(orientations));
}




/// <Summary>
/// Specifies the description of the current state of the application as it
/// pertains to the application switcher (also known as "recent tasks").
///
/// Any part of the description that is unsupported on the current platform
/// will be ignored.
/// </Summary>
public virtual Future<object> SetApplicationSwitcherDescription(FlutterSDK.Services.Systemchrome.ApplicationSwitcherDescription description)
async
{
    await SystemchannelsDefaultClass.SystemChannels.Platform.InvokeMethod("SystemChrome.setApplicationSwitcherDescription", new Dictionary<string, object> { { "label", description.Label }{ "primaryColor", description.PrimaryColor } });
}




/// <Summary>
/// Specifies the set of system overlays to have visible when the application
/// is running.
///
/// The `overlays` argument is a list of [SystemUiOverlay] enum values
/// denoting the overlays to show.
///
/// If a particular overlay is unsupported on the platform, enabling or
/// disabling that overlay will be ignored.
///
/// The settings here can be overridden by the platform when System UI becomes
/// necessary for functionality.
///
/// For example, on Android, when the keyboard becomes visible, it will enable the
/// navigation bar and status bar system UI overlays. When the keyboard is closed,
/// Android will not restore the previous UI visibility settings, and the UI
/// visibility cannot be changed until 1 second after the keyboard is closed to
/// prevent malware locking users from navigation buttons.
///
/// To regain "fullscreen" after text entry, the UI overlays should be set again
/// after a delay of 1 second. This can be achieved through [restoreSystemUIOverlays]
/// or calling this again. Otherwise, the original UI overlay settings will be
/// automatically restored only when the application loses and regains focus.
/// </Summary>
public virtual Future<object> SetEnabledSystemUIOverlays(List<FlutterSDK.Services.Systemchrome.SystemUiOverlay> overlays)
async
{
    await SystemchannelsDefaultClass.SystemChannels.Platform.InvokeMethod("SystemChrome.setEnabledSystemUIOverlays", SystemchromeDefaultClass._Stringify(overlays));
}




/// <Summary>
/// Restores the system overlays to the last settings provided via
/// [setEnabledSystemUIOverlays]. May be used when the platform force enables/disables
/// UI elements.
///
/// For example, when the Android keyboard disables hidden status and navigation bars,
/// this can be called to re-disable the bars when the keyboard is closed.
///
/// On Android, the system UI cannot be changed until 1 second after the previous
/// change. This is to prevent malware from permanently hiding navigation buttons.
/// </Summary>
public virtual Future<object> RestoreSystemUIOverlays()
async
{
    await SystemchannelsDefaultClass.SystemChannels.Platform.InvokeMethod("SystemChrome.restoreSystemUIOverlays", null);
}




/// <Summary>
/// Specifies the style to use for the system overlays that are visible (if
/// any).
///
/// This method will schedule the embedder update to be run in a microtask.
/// Any subsequent calls to this method during the current event loop will
/// overwrite the pending value, such that only the last specified value takes
/// effect.
///
/// Call this API in code whose lifecycle matches that of the desired
/// system UI styles. For instance, to change the system UI style on a new
/// page, consider calling when pushing/popping a new [PageRoute].
///
/// However, the [AppBar] widget automatically sets the system overlay style
/// based on its [AppBar.brightness], so configure that instead of calling
/// this method directly. Likewise, do the same for [CupertinoNavigationBar]
/// via [CupertinoNavigationBar.backgroundColor].
///
/// If a particular style is not supported on the platform, selecting it will
/// have no effect.
///
/// {@tool snippet}
/// ```dart
/// @override
/// Widget build(BuildContext context) {
///   SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle.dark);
///   return Placeholder();
/// }
/// ```
/// {@end-tool}
///
/// For more complex control of the system overlay styles, consider using
/// an [AnnotatedRegion] widget instead of calling [setSystemUiOverlayStyle]
/// directly. This widget places a value directly into the layer tree where
/// it can be hit-tested by the framework. On every frame, the framework will
/// hit-test and select the annotated region it finds under the status and
/// navigation bar and synthesize them into a single style. This can be used
/// to configure the system styles when an app bar is not used.
///
/// {@tool sample --template=stateful_widget_material}
/// The following example creates a widget that changes the status bar color
/// to a random value on Android.
///
/// ```dart imports
/// import 'package:flutter/services.dart';
/// import 'dart:math' as math;
/// ```
///
/// ```dart
/// final _random = math.Random();
/// SystemUiOverlayStyle _currentStyle = SystemUiOverlayStyle.light;
///
/// void _changeColor() {
///   final color = Color.fromRGBO(
///     _random.nextInt(255),
///     _random.nextInt(255),
///     _random.nextInt(255),
///     1.0,
///   );
///   setState(() {
///     _currentStyle = SystemUiOverlayStyle.dark.copyWith(
///       statusBarColor: color,
///     );
///   });
/// }
///
/// @override
/// Widget build(BuildContext context) {
///   return AnnotatedRegion(
///     value: _currentStyle,
///     child: Center(
///       child: RaisedButton(
///         child: const Text('Change Color'),
///         onPressed: _changeColor,
///        ),
///      ),
///    );
///  }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [AnnotatedRegion], the widget used to place data into the layer tree.
/// </Summary>
public virtual void SetSystemUIOverlayStyle(FlutterSDK.Services.Systemchrome.SystemUiOverlayStyle style)
{

    if (_PendingStyle != null)
    {
        _PendingStyle = style;
        return;
    }

    if (style == _LatestStyle)
    {
        return;
    }

    _PendingStyle = style;
Dart: asyncDefaultClass.ScheduleMicrotask(() =>
{

    if (_PendingStyle != _LatestStyle)
    {
        SystemchannelsDefaultClass.SystemChannels.Platform.InvokeMethod("SystemChrome.setSystemUIOverlayStyle", _PendingStyle._ToMap());
        _LatestStyle = _PendingStyle;
    }

    _PendingStyle = null;
}
 );
}



#endregion
}


/// <Summary>
/// Specifies a particular device orientation.
///
/// To determine which values correspond to which orientations, first position
/// the device in its default orientation (this is the orientation that the
/// system first uses for its boot logo, or the orientation in which the
/// hardware logos or markings are upright, or the orientation in which the
/// cameras are at the top). If this is a portrait orientation, then this is
/// [portraitUp]. Otherwise, it's [landscapeLeft]. As you rotate the device by
/// 90 degrees in a counter-clockwise direction around the axis that pierces the
/// screen, you step through each value in this enum in the order given.
///
/// For a device with a landscape default orientation, the orientation obtained
/// by rotating the device 90 degrees clockwise from its default orientation is
/// [portraitUp].
///
/// Used by [SystemChrome.setPreferredOrientations].
/// </Summary>
public enum DeviceOrientation
{

    /// <Summary>
    /// If the device shows its boot logo in portrait, then the boot logo is shown
    /// in [portraitUp]. Otherwise, the device shows its boot logo in landscape
    /// and this orientation is obtained by rotating the device 90 degrees
    /// clockwise from its boot orientation.
    /// </Summary>
    PortraitUp,
    /// <Summary>
    /// The orientation that is 90 degrees clockwise from [portraitUp].
    ///
    /// If the device shows its boot logo in landscape, then the boot logo is
    /// shown in [landscapeLeft].
    /// </Summary>
    LandscapeLeft,
    /// <Summary>
    /// The orientation that is 180 degrees from [portraitUp].
    /// </Summary>
    PortraitDown,
    /// <Summary>
    /// The orientation that is 90 degrees counterclockwise from [portraitUp].
    /// </Summary>
    LandscapeRight,
}


/// <Summary>
/// Specifies a system overlay at a particular location.
///
/// Used by [SystemChrome.setEnabledSystemUIOverlays].
/// </Summary>
public enum SystemUiOverlay
{

    /// <Summary>
    /// The status bar provided by the embedder on the top of the application
    /// surface, if any.
    /// </Summary>
    Top,
    /// <Summary>
    /// The status bar provided by the embedder on the bottom of the application
    /// surface, if any.
    /// </Summary>
    Bottom,
}

}
