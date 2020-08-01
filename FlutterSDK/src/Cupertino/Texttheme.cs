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
namespace FlutterSDK.Cupertino.Texttheme
{
    internal static class TextthemeDefaultClass
    {
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultActionTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultTabLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultMiddleTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultLargeTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultPickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultDateTimePickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        internal static FlutterSDK.Painting.Textstyle.TextStyle _ResolveTextStyle(FlutterSDK.Painting.Textstyle.TextStyle style, FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk)
        {
            return style?.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(style?.Color, context, nullOk: nullOk), backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(style?.BackgroundColor, context, nullOk: nullOk), decorationColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(style?.DecorationColor, context, nullOk: nullOk));
        }



    }

    /// <Summary>
    /// Cupertino typography theme in a [CupertinoThemeData].
    /// </Summary>
    public class CupertinoTextThemeData : IDiagnosticable
    {
        /// <Summary>
        /// Create a [CupertinoTextThemeData].
        ///
        /// The [primaryColor] is used to derive TextStyle defaults of other attributes
        /// such as [navActionTextStyle] and [actionTextStyle], it must not be null when
        /// either [navActionTextStyle] or [actionTextStyle] is null. Defaults to
        /// [CupertinoColors.systemBlue].
        ///
        /// Other [TextStyle] parameters default to default iOS text styles when
        /// unspecified.
        /// </Summary>
        public CupertinoTextThemeData(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle actionTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle tabLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle navTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle navLargeTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle navActionTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle pickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle dateTimePickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle))
        : base()
        {

        }
        internal static CupertinoTextThemeData _Raw(FlutterSDK.Cupertino.Texttheme._TextThemeDefaultsBuilder _defaults, FlutterBinding.UI.Color _primaryColor, FlutterSDK.Painting.Textstyle.TextStyle _textStyle, FlutterSDK.Painting.Textstyle.TextStyle _actionTextStyle, FlutterSDK.Painting.Textstyle.TextStyle _tabLabelTextStyle, FlutterSDK.Painting.Textstyle.TextStyle _navTitleTextStyle, FlutterSDK.Painting.Textstyle.TextStyle _navLargeTitleTextStyle, FlutterSDK.Painting.Textstyle.TextStyle _navActionTextStyle, FlutterSDK.Painting.Textstyle.TextStyle _pickerTextStyle, FlutterSDK.Painting.Textstyle.TextStyle _dateTimePickerTextStyle)
        {
            var instance = new CupertinoTextThemeData(); instance._Defaults = _defaults;
            instance._PrimaryColor = _primaryColor;
            instance._TextStyle = _textStyle;
            instance._ActionTextStyle = _actionTextStyle;
            instance._TabLabelTextStyle = _tabLabelTextStyle;
            instance._NavTitleTextStyle = _navTitleTextStyle;
            instance._NavLargeTitleTextStyle = _navLargeTitleTextStyle;
            instance._NavActionTextStyle = _navActionTextStyle;
            instance._PickerTextStyle = _pickerTextStyle;
            instance._DateTimePickerTextStyle = _dateTimePickerTextStyle;
        }
        internal virtual FlutterSDK.Cupertino.Texttheme._TextThemeDefaultsBuilder _Defaults { get; set; }
        internal virtual FlutterBinding.UI.Color _PrimaryColor { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _TextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _ActionTextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _TabLabelTextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _NavTitleTextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _NavLargeTitleTextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _NavActionTextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _PickerTextStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _DateTimePickerTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ActionTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TabLabelTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavTitleTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavLargeTitleTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavActionTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PickerTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle DateTimePickerTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a copy of the current [CupertinoTextThemeData] with all the colors
        /// resolved against the given [BuildContext].
        ///
        /// Throws an exception if any of the [InheritedWidget]s required to resolve
        /// this [CupertinoTextThemeData] is not found in [context], unless [nullOk] is
        /// set to true, in which case [CupertinoDynamicColor]s that fail to resolve will
        /// be used as-is.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {
            return CupertinoTextThemeData._Raw(_Defaults?.ResolveFrom(context, nullOk), ColorsDefaultClass.CupertinoDynamicColor.Resolve(_PrimaryColor, context, nullOk: nullOk), TextthemeDefaultClass._ResolveTextStyle(_TextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_ActionTextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_TabLabelTextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_NavTitleTextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_NavLargeTitleTextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_NavActionTextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_PickerTextStyle, context, nullOk), TextthemeDefaultClass._ResolveTextStyle(_DateTimePickerTextStyle, context, nullOk));
        }




        /// <Summary>
        /// Returns a copy of the current [CupertinoTextThemeData] instance with
        /// specified overrides.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData CopyWith(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle actionTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle tabLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle navTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle navLargeTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle navActionTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle pickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle dateTimePickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle))
        {
            return CupertinoTextThemeData._Raw(_Defaults, primaryColor ?? _PrimaryColor, textStyle ?? _TextStyle, actionTextStyle ?? _ActionTextStyle, tabLabelTextStyle ?? _TabLabelTextStyle, navTitleTextStyle ?? _NavTitleTextStyle, navLargeTitleTextStyle ?? _NavLargeTitleTextStyle, navActionTextStyle ?? _NavActionTextStyle, pickerTextStyle ?? _PickerTextStyle, dateTimePickerTextStyle ?? _DateTimePickerTextStyle);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            CupertinoTextThemeData defaultData = new CupertinoTextThemeData();
            properties.Add(new DiagnosticsProperty<TextStyle>("textStyle", TextStyle, defaultValue: defaultData.TextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("actionTextStyle", ActionTextStyle, defaultValue: defaultData.ActionTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("tabLabelTextStyle", TabLabelTextStyle, defaultValue: defaultData.TabLabelTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("navTitleTextStyle", NavTitleTextStyle, defaultValue: defaultData.NavTitleTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("navLargeTitleTextStyle", NavLargeTitleTextStyle, defaultValue: defaultData.NavLargeTitleTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("navActionTextStyle", NavActionTextStyle, defaultValue: defaultData.NavActionTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("pickerTextStyle", PickerTextStyle, defaultValue: defaultData.PickerTextStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("dateTimePickerTextStyle", DateTimePickerTextStyle, defaultValue: defaultData.DateTimePickerTextStyle));
        }



    }


    public class _TextThemeDefaultsBuilder
    {
        public _TextThemeDefaultsBuilder(FlutterBinding.UI.Color labelColor, FlutterBinding.UI.Color inactiveGrayColor)
        : base()
        {
            this.LabelColor = labelColor;
            this.InactiveGrayColor = inactiveGrayColor;
        }
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveGrayColor { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TabLabelTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavTitleTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavLargeTitleTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PickerTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle DateTimePickerTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private FlutterSDK.Painting.Textstyle.TextStyle _ApplyLabelColor(FlutterSDK.Painting.Textstyle.TextStyle original, FlutterBinding.UI.Color color)
        {
            return original?.Color == color ? original : original?.CopyWith(color: color);
        }




        public virtual FlutterSDK.Painting.Textstyle.TextStyle ActionTextStyle(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color)) => TextthemeDefaultClass._KDefaultActionTextStyle.CopyWith(color: primaryColor);



        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavActionTextStyle(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color)) => ActionTextStyle(primaryColor: primaryColor);



        public virtual FlutterSDK.Cupertino.Texttheme._TextThemeDefaultsBuilder ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk)
        {
            Color resolvedLabelColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(LabelColor, context, nullOk: nullOk);
            Color resolvedInactiveGray = ColorsDefaultClass.CupertinoDynamicColor.Resolve(InactiveGrayColor, context, nullOk: nullOk);
            return resolvedLabelColor == LabelColor && resolvedInactiveGray == ColorsDefaultClass.CupertinoColors.InactiveGray ? this : new _TextThemeDefaultsBuilder(resolvedLabelColor, resolvedInactiveGray);
        }



    }

}
