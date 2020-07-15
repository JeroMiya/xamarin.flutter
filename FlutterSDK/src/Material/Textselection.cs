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
namespace FlutterSDK.Material.Textselection
{
    internal static class TextselectionDefaultClass
    {
        public static double _KHandleSize = default(double);
        public static double _KToolbarScreenPadding = default(double);
        public static double _KToolbarHeight = default(double);
        public static double _KToolbarContentDistanceBelow = default(double);
        public static double _KToolbarContentDistance = default(double);
        public static FlutterSDK.Widgets.Textselection.TextSelectionControls MaterialTextSelectionControls = default(FlutterSDK.Widgets.Textselection.TextSelectionControls);
    }

    /// <Summary>
    /// Manages a copy/paste text selection toolbar.
    /// </Summary>
    public class _TextSelectionToolbar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _TextSelectionToolbar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback handleCut = default(VoidCallback), VoidCallback handleCopy = default(VoidCallback), VoidCallback handlePaste = default(VoidCallback), VoidCallback handleSelectAll = default(VoidCallback), bool isAbove = default(bool))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual VoidCallback HandleCut { get; set; }
    public virtual VoidCallback HandleCopy { get; set; }
    public virtual VoidCallback HandlePaste { get; set; }
    public virtual VoidCallback HandleSelectAll { get; set; }
    public virtual bool IsAbove { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Material.Textselection._TextSelectionToolbarState CreateState() => new _TextSelectionToolbarState();


    #endregion
}


public class _TextSelectionToolbarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Textselection._TextSelectionToolbar>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _TextSelectionToolbarState()
    { }
    #endregion

    #region fields
    internal virtual bool _OverflowOpen { get; set; }
    internal virtual FlutterSDK.Widgets.Framework.UniqueKey _ContainerKey { get; set; }
    #endregion

    #region methods

    private FlutterSDK.Material.Flatbutton.FlatButton _GetItem(VoidCallback onPressed, string label)
    {

        return new FlatButton(child: new Text(label), onPressed: onPressed);
    }




    public new void DidUpdateWidget(FlutterSDK.Material.Textselection._TextSelectionToolbar oldWidget)
    {
        if (((Widget.HandleCut == null) != (oldWidget.HandleCut == null)) || ((Widget.HandleCopy == null) != (oldWidget.HandleCopy == null)) || ((Widget.HandlePaste == null) != (oldWidget.HandlePaste == null)) || ((Widget.HandleSelectAll == null) != (oldWidget.HandleSelectAll == null)))
        {
            _ContainerKey = new UniqueKey();
            _OverflowOpen = false;
        }

        base.DidUpdateWidget(oldWidget);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
        List<Widget> items = new List<Widget>() { };
        if (items.IsEmpty())
        {
            return new Container(width: 0.0, height: 0.0);
        }

        return new _TextSelectionToolbarContainer(key: _ContainerKey, overflowOpen: _OverflowOpen, child: new AnimatedSize(vsync: this, duration: new TimeSpan(milliseconds: 140), child: new Material(elevation: 1.0, child: new _TextSelectionToolbarItems(isAbove: Widget.IsAbove, overflowOpen: _OverflowOpen, children: new List<Widget>(){new Material(child:new IconButton(icon:new Icon(_OverflowOpen?IconsDefaultClass.Icons.Arrow_back:IconsDefaultClass.Icons.More_vert), onPressed:() => {
SetState(() => {
_OverflowOpen=!_OverflowOpen;
}
);
}
, tooltip:_OverflowOpen?localizations.BackButtonTooltip:localizations.MoreButtonTooltip)), , items}))));
    }



    #endregion
}


public class _TextSelectionToolbarContainer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public _TextSelectionToolbarContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool overflowOpen = default(bool))
    : base(key: key, child: child)

}
#endregion

#region fields
public virtual bool OverflowOpen { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Textselection._TextSelectionToolbarContainerRenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _TextSelectionToolbarContainerRenderBox(overflowOpen: OverflowOpen);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Textselection._TextSelectionToolbarContainerRenderBox renderObject)
{
    renderObject.OverflowOpen = OverflowOpen;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.OverflowOpen = OverflowOpen;
}



#endregion
}


public class _TextSelectionToolbarContainerRenderBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
    #region constructors
    public _TextSelectionToolbarContainerRenderBox(bool overflowOpen = default(bool))
    : base()

}
#endregion

#region fields
internal virtual double _ClosedWidth { get; set; }
internal virtual bool _OverflowOpen { get; set; }
public virtual bool OverflowOpen { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void PerformLayout()
{
    Child.Layout(Constraints.Loosen(), parentUsesSize: true);
    if (!OverflowOpen && _ClosedWidth == null)
    {
        _ClosedWidth = Child.Size.Width;
    }

    Size = Constraints.Constrain(new Size(_ClosedWidth == null || Child.Size.Width > _ClosedWidth ? Child.Size.Width : _ClosedWidth, Child.Size.Height));
    _ToolbarParentData childParentData = Child.ParentData as _ToolbarParentData;
    childParentData.Offset = new Offset(Size.Width - Child.Size.Width, 0.0);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    _ToolbarParentData childParentData = Child.ParentData as _ToolbarParentData;
    context.PaintChild(Child, childParentData.Offset + offset);
}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    _ToolbarParentData childParentData = Child.ParentData as _ToolbarParentData;
    return result.AddWithPaintOffset(offset: childParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
    {

        return Child.HitTest(result, position: transformed);
    }
    );
}




public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
{
    if (!(child.ParentData is _ToolbarParentData))
    {
        ((_ToolbarParentData)child.ParentData) = new _ToolbarParentData();
    }

}


public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
{
    if (!(child.ParentData is _ToolbarParentData))
    {
        ((_ToolbarParentData)child.ParentData) = new _ToolbarParentData();
    }

}




public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
{
    _ToolbarParentData childParentData = child.ParentData as _ToolbarParentData;
    transform.Translate(childParentData.Offset.Dx, childParentData.Offset.Dy);
    base.ApplyPaintTransform(child, transform);
}



#endregion
}


public class _TextSelectionToolbarItems : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
{
    #region constructors
    public _TextSelectionToolbarItems(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool isAbove = default(bool), bool overflowOpen = default(bool), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
    : base(key: key, children: children)

}
#endregion

#region fields
public virtual bool IsAbove { get; set; }
public virtual bool OverflowOpen { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Textselection._TextSelectionToolbarItemsRenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _TextSelectionToolbarItemsRenderBox(isAbove: IsAbove, overflowOpen: OverflowOpen);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Textselection._TextSelectionToolbarItemsRenderBox renderObject)
{
    ..IsAbove = IsAbove..OverflowOpen = OverflowOpen;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    ..IsAbove = IsAbove..OverflowOpen = OverflowOpen;
}




public new FlutterSDK.Material.Textselection._TextSelectionToolbarItemsElement CreateElement() => new _TextSelectionToolbarItemsElement(this);


#endregion
}


public class _ToolbarParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
{
    #region constructors
    public _ToolbarParentData()
    { }
    #endregion

    #region fields
    public virtual bool ShouldPaint { get; set; }
    #endregion

    #region methods

    #endregion
}


public class _TextSelectionToolbarItemsElement : FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement
{
    #region constructors
    public _TextSelectionToolbarItemsElement(FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget widget)
    : base(widget)

}
#endregion

#region fields
#endregion

#region methods

private bool _ShouldPaint(FlutterSDK.Widgets.Framework.Element child)
{
    return (child.RenderObject.ParentData as _ToolbarParentData).ShouldPaint;
}




public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
{
    Children.Where(_ShouldPaint).ForEach(visitor);
}



#endregion
}


public class _TextSelectionToolbarItemsRenderBox : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Material.Textselection._ToolbarParentData>
{
    #region constructors
    public _TextSelectionToolbarItemsRenderBox(bool isAbove = default(bool), bool overflowOpen = default(bool))
    : base()

}
#endregion

#region fields
internal virtual int _LastIndexThatFits { get; set; }
internal virtual bool _IsAbove { get; set; }
internal virtual bool _OverflowOpen { get; set; }
public virtual bool IsAbove { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool OverflowOpen { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _LayoutChildren()
{
    BoxConstraints sizedConstraints = _OverflowOpen ? Constraints : BoxConstraints.Loose(new Size(Constraints.MaxWidth, TextselectionDefaultClass._KToolbarHeight));
    int i = -1;
    double width = 0.0;
    VisitChildren((RenderObject renderObjectChild) =>
    {
        i++;
        if (_LastIndexThatFits != -1 && !OverflowOpen)
        {
            return;
        }

        RenderBox child = renderObjectChild as RenderBox;
        child.Layout(sizedConstraints.Loosen(), parentUsesSize: true);
        width += child.Size.Width;
        if (width > sizedConstraints.MaxWidth && _LastIndexThatFits == -1)
        {
            _LastIndexThatFits = i - 1;
        }

    }
    );
    RenderBox navButton = FirstChild;
    if (_LastIndexThatFits != -1 && _LastIndexThatFits == ChildCount - 2 && width - navButton.Size.Width <= sizedConstraints.MaxWidth)
    {
        _LastIndexThatFits = -1;
    }

}




private bool _ShouldPaintChild(FlutterSDK.Rendering.@object.RenderObject renderObjectChild, int index)
{
    if (renderObjectChild == FirstChild)
    {
        return _LastIndexThatFits != -1;
    }

    if (_LastIndexThatFits == -1)
    {
        return true;
    }

    return (index > _LastIndexThatFits) == OverflowOpen;
}




private void _PlaceChildren()
{
    int i = -1;
    Size nextSize = new Size(0.0, 0.0);
    double fitWidth = 0.0;
    RenderBox navButton = FirstChild;
    double overflowHeight = OverflowOpen && !IsAbove ? navButton.Size.Height : 0.0;
    VisitChildren((RenderObject renderObjectChild) =>
    {
    i++;
    RenderBox child = renderObjectChild as RenderBox;
    _ToolbarParentData childParentData = child.ParentData as _ToolbarParentData;
    if (renderObjectChild == navButton)
    {
        return;
    }

    if (!_ShouldPaintChild(renderObjectChild, i))
    {
        childParentData.ShouldPaint = false;
        return;
    }

    childParentData.ShouldPaint = true;
    if (!OverflowOpen)
    {
        childParentData.Offset = new Offset(fitWidth, 0.0);
        fitWidth += child.Size.Width;
        nextSize = new Size(fitWidth, Math.Dart:mathDefaultClass.Max(child.Size.Height, nextSize.Height));
}
else
{
    childParentData.Offset = new Offset(0.0, overflowHeight);
    overflowHeight += child.Size.Height;
    nextSize = new Size(Math.Dart:mathDefaultClass.Max(child.Size.Width, nextSize.Width), overflowHeight);
}

}
);
_ToolbarParentData navButtonParentData = navButton.ParentData as _ToolbarParentData;
if (_ShouldPaintChild(FirstChild, 0))
{
    navButtonParentData.ShouldPaint = true;
    if (OverflowOpen)
    {
        navButtonParentData.Offset = IsAbove ? new Offset(0.0, overflowHeight) : Dart:uiDefaultClass.Offset.Zero;
        nextSize = new Size(nextSize.Width, IsAbove ? nextSize.Height + navButton.Size.Height : nextSize.Height);
    }
    else
    {
        navButtonParentData.Offset = new Offset(fitWidth, 0.0);
        nextSize = new Size(nextSize.Width + navButton.Size.Width, nextSize.Height);
    }

}
else
{
    navButtonParentData.ShouldPaint = false;
}

Size = nextSize;
}




public new void PerformLayout()
{
    _LastIndexThatFits = -1;
    if (FirstChild == null)
    {
        PerformResize();
        return;
    }

    _LayoutChildren();
    _PlaceChildren();
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    VisitChildren((RenderObject renderObjectChild) =>
    {
        RenderBox child = renderObjectChild as RenderBox;
        _ToolbarParentData childParentData = child.ParentData as _ToolbarParentData;
        if (!childParentData.ShouldPaint)
        {
            return;
        }

        context.PaintChild(child, childParentData.Offset + offset);
    }
    );
}




public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
{
    if (!(child.ParentData is _ToolbarParentData))
    {
        ((_ToolbarParentData)child.ParentData) = new _ToolbarParentData();
    }

}


public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
{
    if (!(child.ParentData is _ToolbarParentData))
    {
        ((_ToolbarParentData)child.ParentData) = new _ToolbarParentData();
    }

}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    RenderBox child = LastChild;
    while (child != null)
    {
        _ToolbarParentData childParentData = child.ParentData as _ToolbarParentData;
        if (!childParentData.ShouldPaint)
        {
            child = childParentData.PreviousSibling;
            continue;
        }

        bool isHit = result.AddWithPaintOffset(offset: childParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
        {

            return child.HitTest(result, position: transformed);
        }
        );
        if (isHit) return true;
        child = childParentData.PreviousSibling;
    }

    return false;
}



#endregion
}


/// <Summary>
/// Centers the toolbar around the given anchor, ensuring that it remains on
/// screen.
/// </Summary>
public class _TextSelectionToolbarLayout : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
{
    #region constructors
    public _TextSelectionToolbarLayout(FlutterBinding.UI.Offset anchor, double upperBounds, bool fitsAbove)

}
#endregion

#region fields
public virtual FlutterBinding.UI.Offset Anchor { get; set; }
public virtual double UpperBounds { get; set; }
public virtual bool FitsAbove { get; set; }
#endregion

#region methods

private double _CenterOn(double position, double width, double min, double max)
{
    if (position - width / 2.0 < min)
    {
        return min;
    }

    if (position + width / 2.0 > max)
    {
        return max - width;
    }

    return position - width / 2.0;
}




public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints)
{
    return constraints.Loosen();
}




public new Offset GetPositionForChild(Size size, Size childSize)
{
    return new Offset(_CenterOn(Anchor.Dx, childSize.Width, TextselectionDefaultClass._KToolbarScreenPadding, size.Width - TextselectionDefaultClass._KToolbarScreenPadding), FitsAbove ? Math.Dart : mathDefaultClass.Max(UpperBounds, Anchor.Dy - childSize.Height):Anchor.Dy);
}




public new bool ShouldRelayout(FlutterSDK.Material.Textselection._TextSelectionToolbarLayout oldDelegate)
{
    return Anchor != oldDelegate.Anchor;
}


public new bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate)
{
    return Anchor != oldDelegate.Anchor;
}



#endregion
}


/// <Summary>
/// Draws a single text selection handle which points up and to the left.
/// </Summary>
public class _TextSelectionHandlePainter : FlutterSDK.Rendering.Custompaint.CustomPainter
{
    #region constructors
    public _TextSelectionHandlePainter(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))

}
#endregion

#region fields
public virtual FlutterBinding.UI.Color Color { get; set; }
#endregion

#region methods

public new void Paint(Canvas canvas, Size size)
{
    Paint paint = new Paint()..Color = Color;
    double radius = size.Width / 2.0;
    Rect circle = Rect.FromCircle(center: new Offset(radius, radius), radius: radius);
    Rect point = Rect.FromLTWH(0.0, 0.0, radius, radius);
    Path path = new Path();
    new Path().AddOval(circle);
    new Path().AddRect(point);
    canvas.DrawPath(path, paint);
}




public new bool ShouldRepaint(FlutterSDK.Material.Textselection._TextSelectionHandlePainter oldPainter)
{
    return Color != oldPainter.Color;
}


public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
{
    return Color != oldPainter.Color;
}



#endregion
}


public class _MaterialTextSelectionControls : FlutterSDK.Widgets.Textselection.TextSelectionControls
{
    #region constructors
    public _MaterialTextSelectionControls()
    { }
    #endregion

    #region fields
    #endregion

    #region methods

    /// <Summary>
    /// Returns the size of the Material handle.
    /// </Summary>
    public new Size GetHandleSize(double textLineHeight) => new Size(TextselectionDefaultClass._KHandleSize, TextselectionDefaultClass._KHandleSize);



    /// <Summary>
    /// Builder for material-style copy/paste text selection toolbar.
    /// </Summary>
    public new FlutterSDK.Widgets.Framework.Widget BuildToolbar(FlutterSDK.Widgets.Framework.BuildContext context, FlutterBinding.UI.Rect globalEditableRegion, double textLineHeight, FlutterBinding.UI.Offset selectionMidpoint, List<FlutterSDK.Rendering.Editable.TextSelectionPoint> endpoints, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
    {


        TextSelectionPoint startTextSelectionPoint = endpoints[0];
        TextSelectionPoint endTextSelectionPoint = endpoints.Count > 1 ? endpoints[1] : endpoints[0];
        double closedToolbarHeightNeeded = TextselectionDefaultClass._KToolbarScreenPadding + TextselectionDefaultClass._KToolbarHeight + TextselectionDefaultClass._KToolbarContentDistance;
        double paddingTop = MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Top;
        double availableHeight = globalEditableRegion.Top + startTextSelectionPoint.Point.Dy - textLineHeight - paddingTop;
        bool fitsAbove = closedToolbarHeightNeeded <= availableHeight;
        Offset anchor = new Offset(globalEditableRegion.Left + selectionMidpoint.Dx, fitsAbove ? globalEditableRegion.Top + startTextSelectionPoint.Point.Dy - textLineHeight - TextselectionDefaultClass._KToolbarContentDistance : globalEditableRegion.Top + endTextSelectionPoint.Point.Dy + TextselectionDefaultClass._KToolbarContentDistanceBelow);
        return new Stack(children: new List<Widget>() { new CustomSingleChildLayout(@delegate: new _TextSelectionToolbarLayout(anchor, TextselectionDefaultClass._KToolbarScreenPadding + paddingTop, fitsAbove), child: new _TextSelectionToolbar(handleCut: CanCut(delegate) ? () => =>HandleCut(delegate):null, handleCopy: CanCopy(delegate) ? () => =>HandleCopy(delegate):null, handlePaste: CanPaste(delegate) ? () => =>HandlePaste(delegate):null, handleSelectAll: CanSelectAll(delegate) ? () => =>HandleSelectAll(delegate):null, isAbove: fitsAbove)) });
    }




    /// <Summary>
    /// Builder for material-style text selection handles.
    /// </Summary>
    public new FlutterSDK.Widgets.Framework.Widget BuildHandle(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textHeight)
    {
        Widget handle = new SizedBox(width: TextselectionDefaultClass._KHandleSize, height: TextselectionDefaultClass._KHandleSize, child: new CustomPaint(painter: new _TextSelectionHandlePainter(color: ThemeDefaultClass.Theme.Of(context).TextSelectionHandleColor)));
        switch (type) { case TextSelectionHandleType.Left: return Transform.Rotate(angle: Math.Dart:mathDefaultClass.Pi / 2.0, child: handle); case TextSelectionHandleType.Right: return handle; case TextSelectionHandleType.Collapsed: return Transform.Rotate(angle: Math.Dart:mathDefaultClass.Pi / 4.0, child: handle); }

        return null;
    }




    /// <Summary>
    /// Gets anchor for material-style text selection handles.
    ///
    /// See [TextSelectionControls.getHandleAnchor].
    /// </Summary>
    public new Offset GetHandleAnchor(FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight)
    {
        switch (type) { case TextSelectionHandleType.Left: return new Offset(TextselectionDefaultClass._KHandleSize, 0); case TextSelectionHandleType.Right: return Dart:uiDefaultClass.Offset.Zero; default: return new Offset(TextselectionDefaultClass._KHandleSize / 2, -4); }
    }




    public new bool CanSelectAll(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
    {
        TextEditingValue value = delegate.TextEditingValue;
        return delegate.SelectAllEnabled && value.Text.IsNotEmpty && !(value.Selection.Start == 0 && value.Selection.End == value.Text.Length);
    }



    #endregion
}

}
