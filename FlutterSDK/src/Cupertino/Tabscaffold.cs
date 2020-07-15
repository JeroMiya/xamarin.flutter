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
namespace FlutterSDK.Cupertino.Tabscaffold
{
    internal static class TabscaffoldDefaultClass
    {
    }

    /// <Summary>
    /// Coordinates tab selection between a [CupertinoTabBar] and a [CupertinoTabScaffold].
    ///
    /// The [index] property is the index of the selected tab. Changing its value
    /// updates the actively displayed tab of the [CupertinoTabScaffold] the
    /// [CupertinoTabController] controls, as well as the currently selected tab item of
    /// its [CupertinoTabBar].
    ///
    /// {@tool snippet}
    ///
    /// [CupertinoTabController] can be used to switch tabs:
    ///
    /// ```dart
    /// class MyCupertinoTabScaffoldPage extends StatefulWidget {
    ///   @override
    ///   _CupertinoTabScaffoldPageState createState() => _CupertinoTabScaffoldPageState();
    /// }
    ///
    /// class _CupertinoTabScaffoldPageState extends State<MyCupertinoTabScaffoldPage> {
    ///   final CupertinoTabController _controller = CupertinoTabController();
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return CupertinoTabScaffold(
    ///       tabBar: CupertinoTabBar(
    ///         items: <BottomNavigationBarItem> [
    ///           // ...
    ///         ],
    ///       ),
    ///       controller: _controller,
    ///       tabBuilder: (BuildContext context, int index) {
    ///         return Center(
    ///           child: CupertinoButton(
    ///             child: const Text('Go to first tab'),
    ///             onPressed: () => _controller.index = 0,
    ///           )
    ///         );
    ///       }
    ///     );
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _controller.dispose();
    ///     super.dispose();
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [CupertinoTabScaffold], a tabbed application root layout that can be
    ///    controlled by a [CupertinoTabController].
    /// </Summary>
    public class CupertinoTabController : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        #region constructors
        public CupertinoTabController(int initialIndex = 0)
        : base()
    
}
    #endregion

    #region fields
    internal virtual bool _IsDisposed { get; set; }
    internal virtual int _Index { get; set; }
    public virtual int Index { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void Dispose()
    {
        base.Dispose();
        _IsDisposed = true;
    }



    #endregion
}


/// <Summary>
/// Implements a tabbed iOS application's root layout and behavior structure.
///
/// The scaffold lays out the tab bar at the bottom and the content between or
/// behind the tab bar.
///
/// A [tabBar] and a [tabBuilder] are required. The [CupertinoTabScaffold]
/// will automatically listen to the provided [CupertinoTabBar]'s tap callbacks
/// to change the active tab.
///
/// A [controller] can be used to provide an initially selected tab index and manage
/// subsequent tab changes. If a controller is not specified, the scaffold will
/// create its own [CupertinoTabController] and manage it internally. Otherwise
/// it's up to the owner of [controller] to call `dispose` on it after finish
/// using it.
///
/// Tabs' contents are built with the provided [tabBuilder] at the active
/// tab index. The [tabBuilder] must be able to build the same number of
/// pages as there are [tabBar] items. Inactive tabs will be moved [Offstage]
/// and their animations disabled.
///
/// Adding/removing tabs, or changing the order of tabs is supported but not
/// recommended. Doing so is against the iOS human interface guidelines, and
/// [CupertinoTabScaffold] may lose some tabs' state in the process.
///
/// Use [CupertinoTabView] as the root widget of each tab to support tabs with
/// parallel navigation state and history. Since each [CupertinoTabView] contains
/// a [Navigator], rebuilding the [CupertinoTabView] with a different
/// [WidgetBuilder] instance in [CupertinoTabView.builder] will not recreate
/// the [CupertinoTabView]'s navigation stack or update its UI. To update the
/// contents of the [CupertinoTabView] after it's built, trigger a rebuild
/// (via [State.setState], for instance) from its descendant rather than from
/// its ancestor.
///
/// {@tool snippet}
///
/// A sample code implementing a typical iOS information architecture with tabs.
///
/// ```dart
/// CupertinoTabScaffold(
///   tabBar: CupertinoTabBar(
///     items: <BottomNavigationBarItem> [
///       // ...
///     ],
///   ),
///   tabBuilder: (BuildContext context, int index) {
///     return CupertinoTabView(
///       builder: (BuildContext context) {
///         return CupertinoPageScaffold(
///           navigationBar: CupertinoNavigationBar(
///             middle: Text('Page 1 of tab $index'),
///           ),
///           child: Center(
///             child: CupertinoButton(
///               child: const Text('Next page'),
///               onPressed: () {
///                 Navigator.of(context).push(
///                   CupertinoPageRoute<void>(
///                     builder: (BuildContext context) {
///                       return CupertinoPageScaffold(
///                         navigationBar: CupertinoNavigationBar(
///                           middle: Text('Page 2 of tab $index'),
///                         ),
///                         child: Center(
///                           child: CupertinoButton(
///                             child: const Text('Back'),
///                             onPressed: () { Navigator.of(context).pop(); },
///                           ),
///                         ),
///                       );
///                     },
///                   ),
///                 );
///               },
///             ),
///           ),
///         );
///       },
///     );
///   },
/// )
/// ```
/// {@end-tool}
///
/// To push a route above all tabs instead of inside the currently selected one
/// (such as when showing a dialog on top of this scaffold), use
/// `Navigator.of(rootNavigator: true)` from inside the [BuildContext] of a
/// [CupertinoTabView].
///
/// See also:
///
///  * [CupertinoTabBar], the bottom tab bar inserted in the scaffold.
///  * [CupertinoTabController], the selection state of this widget
///  * [CupertinoTabView], the typical root content of each tab that holds its own
///    [Navigator] stack.
///  * [CupertinoPageRoute], a route hosting modal pages with iOS style transitions.
///  * [CupertinoPageScaffold], typical contents of an iOS modal page implementing
///    layout with a navigation bar on top.
///  * [iOS human interface guidelines](https://developer.apple.com/design/human-interface-guidelines/ios/bars/tab-bars/).
/// </Summary>
public class CupertinoTabScaffold : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public CupertinoTabScaffold(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar tabBar = default(FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder tabBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController controller = default(FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), bool resizeToAvoidBottomInset = true)
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar TabBar { get; set; }
public virtual FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController Controller { get; set; }
public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder TabBuilder { get; set; }
public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
public virtual bool ResizeToAvoidBottomInset { get; set; }
#endregion

#region methods

public new FlutterSDK.Cupertino.Tabscaffold._CupertinoTabScaffoldState CreateState() => new _CupertinoTabScaffoldState();


#endregion
}


public class _CupertinoTabScaffoldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Tabscaffold.CupertinoTabScaffold>
{
    #region constructors
    public _CupertinoTabScaffoldState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController _Controller { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _UpdateTabController();
    }




    private void _UpdateTabController(bool shouldDisposeOldController = false)
    {
        CupertinoTabController newController = Widget.Controller ?? new CupertinoTabController(initialIndex: Widget.TabBar.CurrentIndex);
        if (newController == _Controller)
        {
            return;
        }

        if (shouldDisposeOldController)
        {
            _Controller?.Dispose();
        }
        else if (_Controller?._IsDisposed == false)
        {
            _Controller.RemoveListener(_OnCurrentIndexChange);
        }

        newController.AddListener(_OnCurrentIndexChange);
        _Controller = newController;
    }




    private void _OnCurrentIndexChange()
    {

        SetState(() =>
        {
        }
        );
    }




    public new void DidUpdateWidget(FlutterSDK.Cupertino.Tabscaffold.CupertinoTabScaffold oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        if (Widget.Controller != oldWidget.Controller)
        {
            _UpdateTabController(shouldDisposeOldController: oldWidget.Controller == null);
        }
        else if (_Controller.Index >= Widget.TabBar.Items.Count)
        {
            _Controller.Index = Widget.TabBar.Items.Count - 1;
        }

    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        MediaQueryData existingMediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context);
        MediaQueryData newMediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context);
        Widget content = new _TabSwitchingView(currentTabIndex: _Controller.Index, tabCount: Widget.TabBar.Items.Count, tabBuilder: Widget.TabBuilder);
        EdgeInsets contentPadding = EdgeinsetsDefaultClass.EdgeInsets.Zero;
        if (Widget.ResizeToAvoidBottomInset)
        {
            newMediaQuery = newMediaQuery.RemoveViewInsets(removeBottom: true);
            contentPadding = EdgeInsets.Only(bottom: existingMediaQuery.ViewInsets.Bottom);
        }

        if (Widget.TabBar != null && (!Widget.ResizeToAvoidBottomInset || Widget.TabBar.PreferredSize.Height > existingMediaQuery.ViewInsets.Bottom))
        {
            double bottomPadding = Widget.TabBar.PreferredSize.Height + existingMediaQuery.Padding.Bottom;
            if (Widget.TabBar.Opaque(context))
            {
                contentPadding = EdgeInsets.Only(bottom: bottomPadding);
                newMediaQuery = newMediaQuery.RemovePadding(removeBottom: true);
            }
            else
            {
                newMediaQuery = newMediaQuery.CopyWith(padding: newMediaQuery.Padding.CopyWith(bottom: bottomPadding));
            }

        }

        content = new MediaQuery(data: newMediaQuery, child: new Padding(padding: contentPadding, child: content));
        return new DecoratedBox(decoration: new BoxDecoration(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).ScaffoldBackgroundColor), child: new Stack(children: new List<Widget>(){content, new MediaQuery(data:existingMediaQuery.CopyWith(textScaleFactor:1), child:new Align(alignment:AlignmentDefaultClass.Alignment.BottomCenter, child:Widget.TabBar.CopyWith(currentIndex:_Controller.Index, onTap:(int newIndex) => {
_Controller.Index=newIndex;
if (Widget.TabBar.OnTap!=null )Widget.TabBar.OnTap(newIndex);
}
)))}));
    }




    public new void Dispose()
    {
        if (Widget.Controller == null)
        {
            _Controller?.Dispose();
        }
        else if (_Controller?._IsDisposed == false)
        {
            _Controller.RemoveListener(_OnCurrentIndexChange);
        }

        base.Dispose();
    }



    #endregion
}


/// <Summary>
/// A widget laying out multiple tabs with only one active tab being built
/// at a time and on stage. Off stage tabs' animations are stopped.
/// </Summary>
public class _TabSwitchingView : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public _TabSwitchingView(int currentTabIndex = default(int), int tabCount = default(int), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder tabBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder))
    : base()

}
#endregion

#region fields
public virtual int CurrentTabIndex { get; set; }
public virtual int TabCount { get; set; }
public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder TabBuilder { get; set; }
#endregion

#region methods

public new FlutterSDK.Cupertino.Tabscaffold._TabSwitchingViewState CreateState() => new _TabSwitchingViewState();


#endregion
}


public class _TabSwitchingViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Tabscaffold._TabSwitchingView>
{
    #region constructors
    public _TabSwitchingViewState()
    { }
    #endregion

    #region fields
    public virtual List<bool> ShouldBuildTab { get; set; }
    public virtual List<FlutterSDK.Widgets.Focusmanager.FocusScopeNode> TabFocusNodes { get; set; }
    public virtual List<FlutterSDK.Widgets.Focusmanager.FocusScopeNode> DiscardedNodes { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        ShouldBuildTab.AddAll(List<bool>.Filled(Widget.TabCount, false));
    }




    public new void DidChangeDependencies()
    {
        base.DidChangeDependencies();
        _FocusActiveTab();
    }




    public new void DidUpdateWidget(FlutterSDK.Cupertino.Tabscaffold._TabSwitchingView oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        int lengthDiff = Widget.TabCount - ShouldBuildTab.Count;
        if (lengthDiff > 0)
        {
            ShouldBuildTab.AddAll(List<bool>.Filled(lengthDiff, false));
        }
        else if (lengthDiff < 0)
        {
            ShouldBuildTab.RemoveRange(Widget.TabCount, ShouldBuildTab.Count);
        }

        _FocusActiveTab();
    }




    private void _FocusActiveTab()
    {
        if (TabFocusNodes.Count != Widget.TabCount)
        {
            if (TabFocusNodes.Count > Widget.TabCount)
            {
                DiscardedNodes.AddAll(TabFocusNodes.Sublist(Widget.TabCount));
                TabFocusNodes.RemoveRange(Widget.TabCount, TabFocusNodes.Count);
            }
            else
            {
                TabFocusNodes.AddAll(List<FocusScopeNode>.Generate(Widget.TabCount - TabFocusNodes.Count, (int index) => =>new FocusScopeNode(debugLabel: $"'{TabscaffoldDefaultClass.CupertinoTabScaffold} Tab {index + TabFocusNodes.Count}'")));
            }

        }

        FocusscopeDefaultClass.FocusScope.Of(Context).SetFirstFocus(TabFocusNodes[Widget.CurrentTabIndex]);
    }




    public new void Dispose()
    {
        foreach (FocusScopeNode focusScopeNode in TabFocusNodes)
        {
            focusScopeNode.Dispose();
        }

        foreach (FocusScopeNode focusScopeNode in DiscardedNodes)
        {
            focusScopeNode.Dispose();
        }

        base.Dispose();
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new Stack(fit: StackFit.Expand, children: List<Widget>.Generate(Widget.TabCount, (int index) =>
        {
            bool active = index == Widget.CurrentTabIndex;
            ShouldBuildTab[index] = active || ShouldBuildTab[index];
            return new Offstage(offstage: !active, child: new TickerMode(enabled: active, child: new FocusScope(node: TabFocusNodes[index], child: new Builder(builder: (BuildContext context) =>
            {
                return ShouldBuildTab[index] ? Widget.TabBuilder(context, index) : new Container();
            }
            ))));
        }
        ));
    }



    #endregion
}

}
