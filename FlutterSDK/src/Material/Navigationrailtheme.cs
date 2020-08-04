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
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
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
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
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
namespace FlutterSDK.Material.Navigationrailtheme
{
    internal static class NavigationrailthemeDefaultClass
    {
    }

    /// <Summary>
    /// Defines default property values for descendant [NavigationRail]
    /// widgets.
    ///
    /// Descendant widgets obtain the current [NavigationRailThemeData] object
    /// using `NavigationRailTheme.of(context)`. Instances of
    /// [NavigationRailThemeData] can be customized with
    /// [NavigationRailThemeData.copyWith].
    ///
    /// Typically a [NavigationRailThemeData] is specified as part of the
    /// overall [Theme] with [ThemeData.navigationRailTheme].
    ///
    /// All [NavigationRailThemeData] properties are `null` by default.
    /// When null, the [NavigationRail] will use the values from [ThemeData]
    /// if they exist, otherwise it will provide its own defaults based on the
    /// overall [Theme]'s textTheme and colorScheme. See the individual
    /// [NavigationRail] properties for details.
    ///
    /// See also:
    ///
    ///  * [ThemeData], which describes the overall theme information for the
    ///    application.
    /// </Summary>
    public class NavigationRailThemeData : IDiagnosticable
    {
        /// <Summary>
        /// Creates a theme that can be used for [ThemeData.navigationRailTheme].
        /// </Summary>
        public NavigationRailThemeData(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle selectedLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Iconthemedata.IconThemeData unselectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData selectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), double groupAlignment = default(double), FlutterSDK.Material.Navigationrail.NavigationRailLabelType labelType = default(FlutterSDK.Material.Navigationrail.NavigationRailLabelType))
        {
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.UnselectedLabelTextStyle = unselectedLabelTextStyle;
            this.SelectedLabelTextStyle = selectedLabelTextStyle;
            this.UnselectedIconTheme = unselectedIconTheme;
            this.SelectedIconTheme = selectedIconTheme;
            this.GroupAlignment = groupAlignment;
            this.LabelType = labelType;
        }
        /// <Summary>
        /// Color to be used for the [NavigationRail]'s background.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The z-coordinate to be used for the [NavigationRail]'s elevation.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The style to merge with the default text style for
        /// [NavigationRailDestination] labels, when the destination is not selected.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelTextStyle { get; set; }
        /// <Summary>
        /// The style to merge with the default text style for
        /// [NavigationRailDestination] labels, when the destination is selected.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SelectedLabelTextStyle { get; set; }
        /// <Summary>
        /// The theme to merge with the default icon theme for
        /// [NavigationRailDestination] icons, when the destination is not selected.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData UnselectedIconTheme { get; set; }
        /// <Summary>
        /// The theme to merge with the default icon theme for
        /// [NavigationRailDestination] icons, when the destination is selected.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData SelectedIconTheme { get; set; }
        /// <Summary>
        /// The alignment for the [NavigationRailDestination]s as they are positioned
        /// within the [NavigationRail].
        /// </Summary>
        public virtual double GroupAlignment { get; set; }
        /// <Summary>
        /// The type that defines the layout and behavior of the labels in the
        /// [NavigationRail].
        /// </Summary>
        public virtual FlutterSDK.Material.Navigationrail.NavigationRailLabelType LabelType { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this object with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData CopyWith(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle selectedLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Iconthemedata.IconThemeData unselectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData selectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), double groupAlignment = default(double), FlutterSDK.Material.Navigationrail.NavigationRailLabelType labelType = default(FlutterSDK.Material.Navigationrail.NavigationRailLabelType))
        {
            return new NavigationRailThemeData(backgroundColor: backgroundColor ?? this.BackgroundColor, elevation: elevation == default(double) ? this.elevation : elevation, unselectedLabelTextStyle: unselectedLabelTextStyle ?? this.UnselectedLabelTextStyle, selectedLabelTextStyle: selectedLabelTextStyle ?? this.SelectedLabelTextStyle, unselectedIconTheme: unselectedIconTheme ?? this.UnselectedIconTheme, selectedIconTheme: selectedIconTheme ?? this.SelectedIconTheme, groupAlignment: groupAlignment == default(double) ? this.groupAlignment : groupAlignment, labelType: labelType ?? this.LabelType);
        }




        /// <Summary>
        /// Linearly interpolate between two navigation rail themes.
        ///
        /// If both arguments are null then null is returned.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData Lerp(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData a, FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData b, double t)
        {

            if (a == null && b == null) return null;
            return new NavigationRailThemeData(backgroundColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.BackgroundColor, b?.BackgroundColor, t), elevation: Dart.UI.UiDefaultClass.LerpDouble(a?.Elevation, b?.Elevation, t), unselectedLabelTextStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.UnselectedLabelTextStyle, b?.UnselectedLabelTextStyle, t), selectedLabelTextStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.SelectedLabelTextStyle, b?.SelectedLabelTextStyle, t), unselectedIconTheme: IconthemedataDefaultClass.IconThemeData.Lerp(a?.UnselectedIconTheme, b?.UnselectedIconTheme, t), selectedIconTheme: IconthemedataDefaultClass.IconThemeData.Lerp(a?.SelectedIconTheme, b?.SelectedIconTheme, t), groupAlignment: Dart.UI.UiDefaultClass.LerpDouble(a?.GroupAlignment, b?.GroupAlignment, t), labelType: t < 0.5 ? a?.LabelType : b?.LabelType);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is NavigationRailThemeData && other.BackgroundColor == BackgroundColor && other.Elevation == Elevation && other.UnselectedLabelTextStyle == UnselectedLabelTextStyle && other.SelectedLabelTextStyle == SelectedLabelTextStyle && other.UnselectedIconTheme == UnselectedIconTheme && other.SelectedIconTheme == SelectedIconTheme && other.GroupAlignment == GroupAlignment && other.LabelType == LabelType;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            NavigationRailThemeData defaultData = new NavigationRailThemeData();
            properties.Add(new ColorProperty("backgroundColor", BackgroundColor, defaultValue: defaultData.BackgroundColor));
            properties.Add(new DoubleProperty("elevation", Elevation, defaultValue: defaultData.Elevation));
            properties.Add(new DiagnosticsProperty<TextStyle>("unselectedLabelTextStyle", UnselectedLabelTextStyle, defaultValue: defaultData.UnselectedLabelTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("selectedLabelTextStyle", SelectedLabelTextStyle, defaultValue: defaultData.SelectedLabelTextStyle));
            properties.Add(new DiagnosticsProperty<IconThemeData>("unselectedIconTheme", UnselectedIconTheme, defaultValue: defaultData.UnselectedIconTheme));
            properties.Add(new DiagnosticsProperty<IconThemeData>("selectedIconTheme", SelectedIconTheme, defaultValue: defaultData.SelectedIconTheme));
            properties.Add(new DoubleProperty("groupAlignment", GroupAlignment, defaultValue: defaultData.GroupAlignment));
            properties.Add(new DiagnosticsProperty<NavigationRailLabelType>("labelType", LabelType, defaultValue: defaultData.LabelType));
        }



    }


    /// <Summary>
    /// An inherited widget that defines visual properties for [NavigationRail]s and
    /// [NavigationRailDestination]s in this widget's subtree.
    ///
    /// Values specified here are used for [NavigationRail] properties that are not
    /// given an explicit non-null value.
    /// </Summary>
    public class NavigationRailTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        /// <Summary>
        /// Creates a navigation rail theme that controls the
        /// [NavigationRailThemeData] properties for a [NavigationRail].
        ///
        /// The data argument must not be null.
        /// </Summary>
        public NavigationRailTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData data = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data;
        }
        /// <Summary>
        /// Specifies the background color, elevation, label text style, icon theme,
        /// group alignment, and label type and border values for descendant
        /// [NavigationRail] widgets.
        /// </Summary>
        public virtual FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData Data { get; set; }

        /// <Summary>
        /// The closest instance of this class that encloses the given context.
        ///
        /// If there is no enclosing [NavigationRailTheme] widget, then
        /// [ThemeData.navigationRailTheme] is used.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// NavigationRailTheme theme = NavigationRailTheme.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            NavigationRailTheme navigationRailTheme = context.DependOnInheritedWidgetOfExactType();
            return navigationRailTheme?.Data ?? ThemeDefaultClass.Theme.Of(context).NavigationRailTheme;
        }




        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            NavigationRailTheme ancestorTheme = context.FindAncestorWidgetOfExactType();
            return Dart.CoreDefaultClass.Identical(this, ancestorTheme) ? child : new NavigationRailTheme(data: Data, child: child);
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Navigationrailtheme.NavigationRailTheme oldWidget) => Data != oldWidget.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


    }

}
