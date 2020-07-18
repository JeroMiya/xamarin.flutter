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
namespace FlutterSDK.Cupertino.Bottomtabbar
{
    internal static class BottomtabbarDefaultClass
    {
        public static double _KTabBarHeight = default(double);
        public static Color _KDefaultTabBarBorderColor = default(Color);
        public static Color _KDefaultTabBarInactiveColor = default(Color);
    }

    /// <Summary>
    /// An iOS-styled bottom navigation tab bar.
    ///
    /// Displays multiple tabs using [BottomNavigationBarItem] with one tab being
    /// active, the first tab by default.
    ///
    /// This [StatelessWidget] doesn't store the active tab itself. You must
    /// listen to the [onTap] callbacks and call `setState` with a new [currentIndex]
    /// for the new selection to reflect. This can also be done automatically
    /// by wrapping this with a [CupertinoTabScaffold].
    ///
    /// Tab changes typically trigger a switch between [Navigator]s, each with its
    /// own navigation stack, per standard iOS design. This can be done by using
    /// [CupertinoTabView]s inside each tab builder in [CupertinoTabScaffold].
    ///
    /// If the given [backgroundColor]'s opacity is not 1.0 (which is the case by
    /// default), it will produce a blurring effect to the content behind it.
    ///
    /// When used as [CupertinoTabScaffold.tabBar], by default `CupertinoTabBar` has
    /// its text scale factor set to 1.0 and does not respond to text scale factor
    /// changes from the operating system, to match the native iOS behavior. To override
    /// this behavior, wrap each of the `navigationBar`'s components inside a [MediaQuery]
    /// with the desired [MediaQueryData.textScaleFactor] value. The text scale factor
    /// value from the operating system can be retrieved in many ways, such as querying
    /// [MediaQuery.textScaleFactorOf] against [CupertinoApp]'s [BuildContext].
    ///
    /// See also:
    ///
    ///  * [CupertinoTabScaffold], which hosts the [CupertinoTabBar] at the bottom.
    ///  * [BottomNavigationBarItem], an item in a [CupertinoTabBar].
    /// </Summary>
    public class CupertinoTabBar : FlutterSDK.Widgets.Framework.StatelessWidget, IPreferredSizeWidget
    {
        #region constructors
        public CupertinoTabBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem> items = default(List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem>), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onTap = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), int currentIndex = 0, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), double iconSize = 30.0, FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border))
        : base(key: key)
        {
            this.Items = items;
            this.OnTap = onTap;
            this.CurrentIndex = currentIndex;
            this.BackgroundColor = backgroundColor;
            this.ActiveColor = activeColor;
            this.InactiveColor = inactiveColor;
            this.IconSize = iconSize;
            this.Border = border;
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem> Items { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnTap { get; set; }
        public virtual int CurrentIndex { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
        public virtual double IconSize { get; set; }
        public virtual FlutterSDK.Painting.Boxborder.Border Border { get; set; }
        public virtual Size PreferredSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Indicates whether the tab bar is fully opaque or can have contents behind
        /// it show through it.
        /// </Summary>
        public virtual bool Opaque(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color backgroundColor = this.BackgroundColor ?? ThemeDefaultClass.CupertinoTheme.Of(context).BarBackgroundColor;
            return ColorsDefaultClass.CupertinoDynamicColor.Resolve(backgroundColor, context).Alpha == 0xFF;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            double bottomPadding = MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Bottom;
            Color backgroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(this.BackgroundColor ?? ThemeDefaultClass.CupertinoTheme.Of(context).BarBackgroundColor, context);
            BorderSide ResolveBorderSide(BorderSide side) => {
                return side == BordersDefaultClass.BorderSide.None ? side : side.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(side.Color, context));
            }

            Border resolvedBorder = Border == null || Border.GetType() != BoxborderDefaultClass.Border ? Border : new Border(top: ResolveBorderSide(Border.Top), left: ResolveBorderSide(Border.Left), bottom: ResolveBorderSide(Border.Bottom), right: ResolveBorderSide(Border.Right));
            Color inactive = ColorsDefaultClass.CupertinoDynamicColor.Resolve(InactiveColor, context);
            Widget result = new DecoratedBox(decoration: new BoxDecoration(border: resolvedBorder, color: backgroundColor), child: new SizedBox(height: BottomtabbarDefaultClass._KTabBarHeight + bottomPadding, child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: inactive, size: IconSize), child: new DefaultTextStyle(style: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.TabLabelTextStyle.CopyWith(color: inactive), child: new Padding(padding: EdgeInsets.Only(bottom: bottomPadding), child: new Row(crossAxisAlignment: CrossAxisAlignment.End, children: _BuildTabItems(context)))))));
            if (!Opaque(context))
            {
                result = new ClipRect(child: new BackdropFilter(filter: ImageFilter.Blur(sigmaX: 10.0, sigmaY: 10.0), child: result));
            }

            return result;
        }




        private List<FlutterSDK.Widgets.Framework.Widget> _BuildTabItems(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            List<Widget> result = new List<Widget>() { };
            for (int index = 0; index < Items.Count; index += 1)
            {
                bool active = index == CurrentIndex;
                result.Add(_WrapActiveItem(context, new Expanded(child: new Semantics(selected: active, hint: $"'tab, {index + 1} of {Items.Count}'", child: new GestureDetector(behavior: HitTestBehavior.Opaque, onTap: OnTap == null ? null : () =>
                {
                    OnTap(index);
                }
                , child: new Padding(padding: EdgeInsets.Only(bottom: 4.0), child: new Column(mainAxisAlignment: MainAxisAlignment.End, children: _BuildSingleTabItem(Items[index], active)))))), active: active));
            }

            return result;
        }




        private List<FlutterSDK.Widgets.Framework.Widget> _BuildSingleTabItem(FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem item, bool active)
        {
            return new List<Widget>() { new Expanded(child: new Center(child: active ? item.ActiveIcon : item.Icon)), };
        }




        /// <Summary>
        /// Change the active tab item's icon and title colors to active.
        /// </Summary>
        private FlutterSDK.Widgets.Framework.Widget _WrapActiveItem(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget item, bool active = default(bool))
        {
            if (!active) return item;
            Color activeColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(this.ActiveColor ?? ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor, context);
            return IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: activeColor), child: TextDefaultClass.DefaultTextStyle.Merge(style: new TextStyle(color: activeColor), child: item));
        }




        /// <Summary>
        /// Create a clone of the current [CupertinoTabBar] but with provided
        /// parameters overridden.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar CopyWith(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem> items = default(List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem>), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), double iconSize = default(double), FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border), int currentIndex = default(int), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onTap = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>))
        {
            return new CupertinoTabBar(key: key ?? this.Key, items: items ?? this.Items, backgroundColor: backgroundColor ?? this.BackgroundColor, activeColor: activeColor ?? this.ActiveColor, inactiveColor: inactiveColor ?? this.InactiveColor, iconSize: iconSize == default(double) ? this.iconSize : iconSize, border: border ?? this.Border, currentIndex: currentIndex ?? this.CurrentIndex, onTap: onTap ?? this.OnTap);
        }



        #endregion
    }

}
