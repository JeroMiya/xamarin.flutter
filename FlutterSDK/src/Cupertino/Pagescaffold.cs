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
namespace FlutterSDK.Cupertino.Pagescaffold
{
    internal static class PagescaffoldDefaultClass
    {
    }

    public interface IObstructingPreferredSizeWidget { }

    public class ObstructingPreferredSizeWidget : IPreferredSizeWidget
    {

        /// <Summary>
        /// If true, this widget fully obstructs widgets behind it by the specified
        /// size.
        ///
        /// If false, this widget partially obstructs.
        /// </Summary>
        public virtual bool ShouldFullyObstruct(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(bool);
        }

        public virtual Size PreferredSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class ObstructingPreferredSizeWidgetMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IObstructingPreferredSizeWidget, ObstructingPreferredSizeWidget> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IObstructingPreferredSizeWidget, ObstructingPreferredSizeWidget>();
        static ObstructingPreferredSizeWidget GetOrCreate(IObstructingPreferredSizeWidget instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ObstructingPreferredSizeWidget();
                _table.Add(instance, value);
            }
            return (ObstructingPreferredSizeWidget)value;
        }
        public static bool ShouldFullyObstruct(this IObstructingPreferredSizeWidget instance, FlutterSDK.Widgets.Framework.BuildContext context) => GetOrCreate(instance).ShouldFullyObstruct(context);
    }


    /// <Summary>
    /// Implements a single iOS application page's layout.
    ///
    /// The scaffold lays out the navigation bar on top and the content between or
    /// behind the navigation bar.
    ///
    /// See also:
    ///
    ///  * [CupertinoTabScaffold], a similar widget for tabbed applications.
    ///  * [CupertinoPageRoute], a modal page route that typically hosts a
    ///    [CupertinoPageScaffold] with support for iOS-style page transitions.
    /// </Summary>
    public class CupertinoPageScaffold : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a layout for pages with a navigation bar at the top.
        /// </Summary>
        public CupertinoPageScaffold(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Pagescaffold.ObstructingPreferredSizeWidget navigationBar = default(FlutterSDK.Cupertino.Pagescaffold.ObstructingPreferredSizeWidget), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), bool resizeToAvoidBottomInset = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.NavigationBar = navigationBar;
            this.BackgroundColor = backgroundColor;
            this.ResizeToAvoidBottomInset = resizeToAvoidBottomInset;
            this.Child = child;
        }
        /// <Summary>
        /// The [navigationBar], typically a [CupertinoNavigationBar], is drawn at the
        /// top of the screen.
        ///
        /// If translucent, the main content may slide behind it.
        /// Otherwise, the main content's top margin will be offset by its height.
        ///
        /// The scaffold assumes the navigation bar will account for the [MediaQuery]
        /// top padding, also consume it if the navigation bar is opaque.
        ///
        /// By default `navigationBar` has its text scale factor set to 1.0 and does
        /// not respond to text scale factor changes from the operating system, to match
        /// the native iOS behavior. To override such behavior, wrap each of the `navigationBar`'s
        /// components inside a [MediaQuery] with the desired [MediaQueryData.textScaleFactor]
        /// value. The text scale factor value from the operating system can be retrieved
        /// in many ways, such as querying [MediaQuery.textScaleFactorOf] against
        /// [CupertinoApp]'s [BuildContext].
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Pagescaffold.ObstructingPreferredSizeWidget NavigationBar { get; set; }
        /// <Summary>
        /// Widget to show in the main content area.
        ///
        /// Content can slide under the [navigationBar] when they're translucent.
        /// In that case, the child's [BuildContext]'s [MediaQuery] will have a
        /// top padding indicating the area of obstructing overlap from the
        /// [navigationBar].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The color of the widget that underlies the entire scaffold.
        ///
        /// By default uses [CupertinoTheme]'s `scaffoldBackgroundColor` when null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// Whether the [child] should size itself to avoid the window's bottom inset.
        ///
        /// For example, if there is an onscreen keyboard displayed above the
        /// scaffold, the body can be resized to avoid overlapping the keyboard, which
        /// prevents widgets inside the body from being obscured by the keyboard.
        ///
        /// Defaults to true and cannot be null.
        /// </Summary>
        public virtual bool ResizeToAvoidBottomInset { get; set; }

        public new FlutterSDK.Cupertino.Pagescaffold._CupertinoPageScaffoldState CreateState() => new _CupertinoPageScaffoldState();


    }


    public class _CupertinoPageScaffoldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Pagescaffold.CupertinoPageScaffold>
    {
        public _CupertinoPageScaffoldState()
        { }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _PrimaryScrollController { get; set; }

        private void _HandleStatusBarTap()
        {
            if (_PrimaryScrollController.HasClients)
            {
                _PrimaryScrollController.AnimateTo(0.0, duration: new TimeSpan(milliseconds: 500), curve: CurvesDefaultClass.Curves.LinearToEaseOut);
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget paddedContent = Widget.Child;
            MediaQueryData existingMediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context);
            if (Widget.NavigationBar != null)
            {
                double topPadding = Widget.NavigationBar.PreferredSize.Height + existingMediaQuery.Padding.Top;
                double bottomPadding = Widget.ResizeToAvoidBottomInset ? existingMediaQuery.ViewInsets.Bottom : 0.0;
                EdgeInsets newViewInsets = Widget.ResizeToAvoidBottomInset ? existingMediaQuery.ViewInsets.CopyWith(bottom: 0.0) : existingMediaQuery.ViewInsets;
                bool fullObstruction = Widget.NavigationBar.ShouldFullyObstruct(context);
                if (fullObstruction)
                {
                    paddedContent = new MediaQuery(data: existingMediaQuery.RemovePadding(removeTop: true).CopyWith(viewInsets: newViewInsets), child: new Padding(padding: EdgeInsets.Only(top: topPadding, bottom: bottomPadding), child: paddedContent));
                }
                else
                {
                    paddedContent = new MediaQuery(data: existingMediaQuery.CopyWith(padding: existingMediaQuery.Padding.CopyWith(top: topPadding), viewInsets: newViewInsets), child: new Padding(padding: EdgeInsets.Only(bottom: bottomPadding), child: paddedContent));
                }

            }
            else
            {
                double bottomPadding = Widget.ResizeToAvoidBottomInset ? existingMediaQuery.ViewInsets.Bottom : 0.0;
                paddedContent = new Padding(padding: EdgeInsets.Only(bottom: bottomPadding), child: paddedContent);
            }

            return new DecoratedBox(decoration: new BoxDecoration(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).ScaffoldBackgroundColor), child: new Stack(children: new List<Widget>() { new PrimaryScrollController(controller: _PrimaryScrollController, child: paddedContent) }));
        }



    }

}
