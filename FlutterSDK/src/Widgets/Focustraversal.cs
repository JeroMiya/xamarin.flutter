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
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Focustraversal
{
    internal static class FocustraversalDefaultClass
    {
        internal static FlutterSDK.Widgets.Framework.BuildContext _GetAncestor(FlutterSDK.Widgets.Framework.BuildContext context, int count = 1)
        {
            BuildContext target = default(BuildContext);
            context.VisitAncestorElements((Element ancestor) =>
            {
                count--;
                if (count == 0)
                {
                    target = ancestor;
                    return false;
                }

                return true;
            }
            );
            return target;
        }



        internal static void _FocusAndEnsureVisible(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy alignmentPolicy = default(FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy))
        {
            node.RequestFocus();
            ScrollableDefaultClass.Scrollable.EnsureVisible(node.Context, alignment: 1.0, alignmentPolicy: alignmentPolicy);
        }



    }

    /// <Summary>
    /// An object used to specify a focus traversal policy used for configuring a
    /// [FocusTraversalGroup] widget.
    ///
    /// The focus traversal policy is what determines which widget is "next",
    /// "previous", or in a direction from the currently focused [FocusNode].
    ///
    /// One of the pre-defined subclasses may be used, or define a custom policy to
    /// create a unique focus order.
    ///
    /// When defining your own, your subclass should implement [sortDescendants] to
    /// provide the order in which you would like the descendants to be traversed.
    ///
    /// See also:
    ///
    ///  * [FocusNode], for a description of the focus system.
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [FocusNode], which is affected by the traversal policy.
    ///  * [WidgetOrderTraversalPolicy], a policy that relies on the widget
    ///    creation order to describe the order of traversal.
    ///  * [ReadingOrderTraversalPolicy], a policy that describes the order as the
    ///    natural "reading order" for the current [Directionality].
    ///  * [OrderedTraversalPolicy], a policy that describes the order
    ///    explicitly using [FocusTraversalOrder] widgets.
    ///  * [DirectionalFocusTraversalPolicyMixin] a mixin class that implements
    ///    focus traversal in a direction.
    /// </Summary>
    public interface IFocusTraversalPolicy
    {
        FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocus(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode);
        FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction);
        void InvalidateScopeData(FlutterSDK.Widgets.Focusmanager.FocusScopeNode node);
        void ChangedScope(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode));
        bool Next(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode);
        bool Previous(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode);
        bool InDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction);
        Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants);
    }


    /// <Summary>
    /// Base class for all sort orders for [OrderedTraversalPolicy] traversal.
    ///
    /// {@template flutter.widgets.focusorder.comparable}
    /// Only orders of the same type are comparable. If a set of widgets in the same
    /// [FocusTraversalGroup] contains orders that are not comparable with each other, it
    /// will assert, since the ordering between such keys is undefined. To avoid
    /// collisions, use a [FocusTraversalGroup] to group similarly ordered widgets
    /// together.
    ///
    /// When overriding, [doCompare] must be overridden instead of [compareTo],
    /// which calls [doCompare] to do the actual comparison.
    /// {@endtemplate}
    ///
    /// See also:
    ///
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [FocusTraversalOrder], a widget that assigns an order to a widget subtree
    ///    for the [OrderedFocusTraversalPolicy] to use.
    ///  * [NumericFocusOrder], for a focus order that describes its order with a
    ///    `double`.
    ///  * [LexicalFocusOrder], a focus order that assigns a string-based lexical
    ///    traversal order to a [FocusTraversalOrder] widget.
    /// </Summary>
    public interface IFocusOrder
    {
        int CompareTo(FlutterSDK.Widgets.Focustraversal.FocusOrder other);
        int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other);
    }


    public interface IDirectionalFocusTraversalPolicyMixin { }

    public class DirectionalFocusTraversalPolicyMixin
    {
        internal virtual Dictionary<FlutterSDK.Widgets.Focusmanager.FocusScopeNode, FlutterSDK.Widgets.Focustraversal._DirectionalPolicyData> _PolicyData { get; set; }

        public new void InvalidateScopeData(FlutterSDK.Widgets.Focusmanager.FocusScopeNode node)
        {
            base.InvalidateScopeData(node);
            _PolicyData.Remove(node);
        }




        public new void ChangedScope(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode))
        {
            base.ChangedScope(node: node, oldScope: oldScope);
            if (oldScope != null)
            {
                _PolicyData[oldScope]?.History?.RemoveWhere((_DirectionalPolicyDataEntry entry) =>
                {
                    return entry.Node == node;
                }
                );
            }

        }




        public new FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction)
        {


            switch (direction) { case TraversalDirection.Up: return _SortAndFindInitial(currentNode, vertical: true, first: false); case TraversalDirection.Down: return _SortAndFindInitial(currentNode, vertical: true, first: true); case TraversalDirection.Left: return _SortAndFindInitial(currentNode, vertical: false, first: false); case TraversalDirection.Right: return _SortAndFindInitial(currentNode, vertical: false, first: true); }
            return null;
        }




        private FlutterSDK.Widgets.Focusmanager.FocusNode _SortAndFindInitial(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, bool vertical = default(bool), bool first = default(bool))
        {
            Iterable<FocusNode> nodes = currentNode.NearestScope.TraversalDescendants;
            List<FocusNode> sorted = nodes.ToList();
            MergeSort(sorted, Compare: (FocusNode a, FocusNode b) =>
            {
                if (vertical)
                {
                    if (first)
                    {
                        return a.Rect.Top.CompareTo(b.Rect.Top);
                    }
                    else
                    {
                        return b.Rect.Bottom.CompareTo(a.Rect.Bottom);
                    }

                }
                else
                {
                    if (first)
                    {
                        return a.Rect.Left.CompareTo(b.Rect.Left);
                    }
                    else
                    {
                        return b.Rect.Right.CompareTo(a.Rect.Right);
                    }

                }

            }
            );
            if (sorted.IsNotEmpty)
            {
                return sorted.First;
            }

            return null;
        }




        private Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> _SortAndFilterHorizontally(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction, FlutterBinding.UI.Rect target, FlutterSDK.Widgets.Focusmanager.FocusNode nearestScope)
        {

            Iterable<FocusNode> nodes = nearestScope.TraversalDescendants;

            List<FocusNode> sorted = nodes.ToList();
            MergeSort(sorted, Compare: (FocusNode a, FocusNode b) => =>a.Rect.Center.Dx.CompareTo(b.Rect.Center.Dx));
            Iterable<FocusNode> result = default(Iterable<FocusNode>);
            switch (direction) { case TraversalDirection.Left: result = sorted.Where((FocusNode node) => =>node.Rect != target && node.Rect.Center.Dx <= target.Left); break; case TraversalDirection.Right: result = sorted.Where((FocusNode node) => =>node.Rect != target && node.Rect.Center.Dx >= target.Right); break; case TraversalDirection.Up: case TraversalDirection.Down: break; }
            return result;
        }




        private Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> _SortAndFilterVertically(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction, FlutterBinding.UI.Rect target, Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> nodes)
        {
            List<FocusNode> sorted = nodes.ToList();
            MergeSort(sorted, Compare: (FocusNode a, FocusNode b) => =>a.Rect.Center.Dy.CompareTo(b.Rect.Center.Dy));
            switch (direction) { case TraversalDirection.Up: return sorted.Where((FocusNode node) => =>node.Rect != target && node.Rect.Center.Dy <= target.Top); case TraversalDirection.Down: return sorted.Where((FocusNode node) => =>node.Rect != target && node.Rect.Center.Dy >= target.Bottom); case TraversalDirection.Left: case TraversalDirection.Right: break; }

            return null;
        }




        private bool _PopPolicyDataIfNeeded(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction, FlutterSDK.Widgets.Focusmanager.FocusScopeNode nearestScope, FlutterSDK.Widgets.Focusmanager.FocusNode focusedChild)
        {
            _DirectionalPolicyData policyData = _PolicyData[nearestScope];
            if (policyData != null && policyData.History.IsNotEmpty && policyData.History.First.Direction != direction)
            {
                if (policyData.History.Last().Node.Parent == null)
                {
                    InvalidateScopeData(nearestScope);
                    return false;
                }

                bool PopOrInvalidate(TraversalDirection direction)
                {
                    FocusNode lastNode = policyData.History.RemoveLast().Node;
                    if (ScrollableDefaultClass.Scrollable.Of(lastNode.Context) != ScrollableDefaultClass.Scrollable.Of(FocusmanagerDefaultClass.PrimaryFocus.Context))
                    {
                        InvalidateScopeData(nearestScope);
                        return false;
                    }

                    ScrollPositionAlignmentPolicy alignmentPolicy = default(ScrollPositionAlignmentPolicy);
                    switch (direction) { case TraversalDirection.Up: case TraversalDirection.Left: alignmentPolicy = ScrollPositionAlignmentPolicy.KeepVisibleAtStart; break; case TraversalDirection.Right: case TraversalDirection.Down: alignmentPolicy = ScrollPositionAlignmentPolicy.KeepVisibleAtEnd; break; }
                    FocustraversalDefaultClass._FocusAndEnsureVisible(lastNode, alignmentPolicy: alignmentPolicy);
                    return true;
                }

                switch (direction)
                {
                    case TraversalDirection.Down:
                    case TraversalDirection.Up:
                        switch (policyData.History.First.Direction)
                        {
                            case TraversalDirection.Left: case TraversalDirection.Right: InvalidateScopeData(nearestScope); break;
                            case TraversalDirection.Up:
                            case TraversalDirection.Down:
                                if (PopOrInvalidate(direction))
                                {
                                    return true;
                                }
                                break;
                        }
                        break;
                    case TraversalDirection.Left:
                    case TraversalDirection.Right:
                        switch (policyData.History.First.Direction)
                        {
                            case TraversalDirection.Left:
                            case TraversalDirection.Right:
                                if (PopOrInvalidate(direction))
                                {
                                    return true;
                                }
                                break;
                            case TraversalDirection.Up: case TraversalDirection.Down: InvalidateScopeData(nearestScope); break;
                        }
                }
            }

            if (policyData != null && policyData.History.IsEmpty())
            {
                InvalidateScopeData(nearestScope);
            }

            return false;
        }




        private void _PushPolicyData(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction, FlutterSDK.Widgets.Focusmanager.FocusScopeNode nearestScope, FlutterSDK.Widgets.Focusmanager.FocusNode focusedChild)
        {
            _DirectionalPolicyData policyData = _PolicyData[nearestScope];
            if (policyData != null && !(policyData is _DirectionalPolicyData))
            {
                return;
            }

            _DirectionalPolicyDataEntry newEntry = new _DirectionalPolicyDataEntry(node: focusedChild, direction: direction);
            if (policyData != null)
            {
                policyData.History.Add(newEntry);
            }
            else
            {
                _PolicyData[nearestScope] = new _DirectionalPolicyData(history: new List<_DirectionalPolicyDataEntry>() { newEntry });
            }

        }




        /// <Summary>
        /// Focuses the next widget in the given [direction] in the [FocusScope] that
        /// contains the [currentNode].
        ///
        /// This determines what the next node to receive focus in the given
        /// [direction] will be by inspecting the node tree, and then calling
        /// [FocusNode.requestFocus] on it.
        ///
        /// Returns true if it successfully found a node and requested focus.
        ///
        /// Maintains a stack of previous locations that have been visited on the
        /// [policyData] for the affected [FocusScopeNode]. If the previous direction
        /// was the opposite of the current direction, then the this policy will
        /// request focus on the previously focused node. Change to another direction
        /// other than the current one or its opposite will clear the stack.
        ///
        /// If this function returns true when called by a subclass, then the subclass
        /// should return true and not request focus from any node.
        /// </Summary>
        public new bool InDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction)
        {
            FocusScopeNode nearestScope = currentNode.NearestScope;
            FocusNode focusedChild = nearestScope.FocusedChild;
            if (focusedChild == null)
            {
                FocusNode firstFocus = FindFirstFocusInDirection(currentNode, direction) ?? currentNode;
                switch (direction) { case TraversalDirection.Up: case TraversalDirection.Left: FocustraversalDefaultClass._FocusAndEnsureVisible(firstFocus, alignmentPolicy: ScrollPositionAlignmentPolicy.KeepVisibleAtStart); break; case TraversalDirection.Right: case TraversalDirection.Down: FocustraversalDefaultClass._FocusAndEnsureVisible(firstFocus, alignmentPolicy: ScrollPositionAlignmentPolicy.KeepVisibleAtEnd); break; }
                return true;
            }

            if (_PopPolicyDataIfNeeded(direction, nearestScope, focusedChild))
            {
                return true;
            }

            FocusNode found = default(FocusNode);
            ScrollableState focusedScrollable = ScrollableDefaultClass.Scrollable.Of(focusedChild.Context);
            switch (direction)
            {
                case TraversalDirection.Down:
                case TraversalDirection.Up:
                    Iterable<FocusNode> eligibleNodes = _SortAndFilterVertically(direction, focusedChild.Rect, nearestScope.TraversalDescendants); if (focusedScrollable != null && !focusedScrollable.Position.AtEdge)
                    {
                        Iterable<FocusNode> filteredEligibleNodes = eligibleNodes.Where((FocusNode node) => =>ScrollableDefaultClass.Scrollable.Of(node.Context) == focusedScrollable);
                        if (filteredEligibleNodes.IsNotEmpty)
                        {
                            eligibleNodes = filteredEligibleNodes;
                        }

                    }
                    if (eligibleNodes.IsEmpty())
                    {
                        break;
                    }
                    List<FocusNode> sorted = eligibleNodes.ToList(); if (direction == TraversalDirection.Up)
                    {
                        sorted = sorted.Reversed.ToList();
                    }
                    Rect band = Rect.FromLTRB(focusedChild.Rect.Left, -Dart.CoreDefaultClass.Double.Infinity, focusedChild.Rect.Right, Dart.CoreDefaultClass.Double.Infinity); Iterable<FocusNode> inBand = sorted.Where((FocusNode node) => =>!node.Rect.Intersect(band).IsEmpty()); if (inBand.IsNotEmpty)
                    {
                        found = inBand.First;
                        break;
                    }
                    MergeSort(sorted, Compare: (FocusNode a, FocusNode b) =>
                    {
                        return (a.Rect.Center.Dx - focusedChild.Rect.Center.Dx).Abs().CompareTo((b.Rect.Center.Dx - focusedChild.Rect.Center.Dx).Abs());
                    }
                    ); found = sorted.First; break;
                case TraversalDirection.Right:
                case TraversalDirection.Left:
                    Iterable<FocusNode> eligibleNodes = _SortAndFilterHorizontally(direction, focusedChild.Rect, nearestScope); if (focusedScrollable != null && !focusedScrollable.Position.AtEdge)
                    {
                        Iterable<FocusNode> filteredEligibleNodes = eligibleNodes.Where((FocusNode node) => =>ScrollableDefaultClass.Scrollable.Of(node.Context) == focusedScrollable);
                        if (filteredEligibleNodes.IsNotEmpty)
                        {
                            eligibleNodes = filteredEligibleNodes;
                        }

                    }
                    if (eligibleNodes.IsEmpty())
                    {
                        break;
                    }
                    List<FocusNode> sorted = eligibleNodes.ToList(); if (direction == TraversalDirection.Left)
                    {
                        sorted = sorted.Reversed.ToList();
                    }
                    Rect band = Rect.FromLTRB(-Dart.CoreDefaultClass.Double.Infinity, focusedChild.Rect.Top, Dart.CoreDefaultClass.Double.Infinity, focusedChild.Rect.Bottom); Iterable<FocusNode> inBand = sorted.Where((FocusNode node) => =>!node.Rect.Intersect(band).IsEmpty()); if (inBand.IsNotEmpty)
                    {
                        found = inBand.First;
                        break;
                    }
                    MergeSort(sorted, Compare: (FocusNode a, FocusNode b) =>
                    {
                        return (a.Rect.Center.Dy - focusedChild.Rect.Center.Dy).Abs().CompareTo((b.Rect.Center.Dy - focusedChild.Rect.Center.Dy).Abs());
                    }
                    ); found = sorted.First; break;
            }
            if (found != null)
            {
                _PushPolicyData(direction, nearestScope, focusedChild);
                switch (direction) { case TraversalDirection.Up: case TraversalDirection.Left: FocustraversalDefaultClass._FocusAndEnsureVisible(found, alignmentPolicy: ScrollPositionAlignmentPolicy.KeepVisibleAtStart); break; case TraversalDirection.Down: case TraversalDirection.Right: FocustraversalDefaultClass._FocusAndEnsureVisible(found, alignmentPolicy: ScrollPositionAlignmentPolicy.KeepVisibleAtEnd); break; }
                return true;
            }

            return false;
        }



    }
    public static class DirectionalFocusTraversalPolicyMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IDirectionalFocusTraversalPolicyMixin, DirectionalFocusTraversalPolicyMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDirectionalFocusTraversalPolicyMixin, DirectionalFocusTraversalPolicyMixin>();
        static DirectionalFocusTraversalPolicyMixin GetOrCreate(IDirectionalFocusTraversalPolicyMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new DirectionalFocusTraversalPolicyMixin();
                _table.Add(instance, value);
            }
            return (DirectionalFocusTraversalPolicyMixin)value;
        }
        public static void InvalidateScopeData(this IDirectionalFocusTraversalPolicyMixin instance, FlutterSDK.Widgets.Focusmanager.FocusScopeNode node) => GetOrCreate(instance).InvalidateScopeData(node);
        public static void ChangedScope(this IDirectionalFocusTraversalPolicyMixin instance, FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode)) => GetOrCreate(instance).ChangedScope(node, oldScope);
        public static FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(this IDirectionalFocusTraversalPolicyMixin instance, FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction) => GetOrCreate(instance).FindFirstFocusInDirection(currentNode, direction);
        public static bool InDirection(this IDirectionalFocusTraversalPolicyMixin instance, FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction) => GetOrCreate(instance).InDirection(currentNode, direction);
    }


    public class _FocusTraversalGroupInfo
    {
        public _FocusTraversalGroupInfo(FlutterSDK.Widgets.Focustraversal._FocusTraversalGroupMarker marker, FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy defaultPolicy = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy), List<FlutterSDK.Widgets.Focusmanager.FocusNode> members = default(List<FlutterSDK.Widgets.Focusmanager.FocusNode>))
        : base()
        {

        }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode GroupNode { get; set; }
        public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Policy { get; set; }
        public virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> Members { get; set; }
    }


    /// <Summary>
    /// An object used to specify a focus traversal policy used for configuring a
    /// [FocusTraversalGroup] widget.
    ///
    /// The focus traversal policy is what determines which widget is "next",
    /// "previous", or in a direction from the currently focused [FocusNode].
    ///
    /// One of the pre-defined subclasses may be used, or define a custom policy to
    /// create a unique focus order.
    ///
    /// When defining your own, your subclass should implement [sortDescendants] to
    /// provide the order in which you would like the descendants to be traversed.
    ///
    /// See also:
    ///
    ///  * [FocusNode], for a description of the focus system.
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [FocusNode], which is affected by the traversal policy.
    ///  * [WidgetOrderTraversalPolicy], a policy that relies on the widget
    ///    creation order to describe the order of traversal.
    ///  * [ReadingOrderTraversalPolicy], a policy that describes the order as the
    ///    natural "reading order" for the current [Directionality].
    ///  * [OrderedTraversalPolicy], a policy that describes the order
    ///    explicitly using [FocusTraversalOrder] widgets.
    ///  * [DirectionalFocusTraversalPolicyMixin] a mixin class that implements
    ///    focus traversal in a direction.
    /// </Summary>
    public class FocusTraversalPolicy : IDiagnosticable
    {
        /// <Summary>
        /// A const constructor so subclasses can be const.
        /// </Summary>
        public FocusTraversalPolicy()
        {

        }

        /// <Summary>
        /// Returns the node that should receive focus if there is no current focus
        /// in the nearest [FocusScopeNode] that `currentNode` belongs to.
        ///
        /// This is used by [next]/[previous]/[inDirection] to determine which node to
        /// focus if they are called when no node is currently focused.
        ///
        /// The `currentNode` argument must not be null.
        ///
        /// The default implementation returns the [FocusScopeNode.focusedChild], if
        /// set, on the nearest scope of the `currentNode`, otherwise, returns the
        /// first node from [sortDescendants], or the given `currentNode` if there are
        /// no descendants.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocus(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode)
        {

            FocusScopeNode scope = currentNode.NearestScope;
            FocusNode candidate = scope.FocusedChild;
            if (candidate == null && scope.Descendants.IsNotEmpty)
            {
                Iterable<FocusNode> sorted = _SortAllDescendants(scope);
                candidate = sorted.IsNotEmpty ? sorted.First : null;
            }

            candidate = (candidate == null ? currentNode : candidate);
            return candidate;
        }




        /// <Summary>
        /// Returns the first node in the given `direction` that should receive focus
        /// if there is no current focus in the scope to which the `currentNode`
        /// belongs.
        ///
        /// This is typically used by [inDirection] to determine which node to focus
        /// if it is called when no node is currently focused.
        ///
        /// All arguments must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction)
        {
            return default(FocusNode);
        }


        /// <Summary>
        /// Clears the data associated with the given [FocusScopeNode] for this object.
        ///
        /// This is used to indicate that the focus policy has changed its mode, and
        /// so any cached policy data should be invalidated. For example, changing the
        /// direction in which focus is moving, or changing from directional to
        /// next/previous navigation modes.
        ///
        /// The default implementation does nothing.
        /// </Summary>
        public virtual void InvalidateScopeData(FlutterSDK.Widgets.Focusmanager.FocusScopeNode node)
        {
        }




        /// <Summary>
        /// This is called whenever the given [node] is re-parented into a new scope,
        /// so that the policy has a chance to update or invalidate any cached data
        /// that it maintains per scope about the node.
        ///
        /// The [oldScope] is the previous scope that this node belonged to, if any.
        ///
        /// The default implementation does nothing.
        /// </Summary>
        public virtual void ChangedScope(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode))
        {
        }




        /// <Summary>
        /// Focuses the next widget in the focus scope that contains the given
        /// [currentNode].
        ///
        /// This should determine what the next node to receive focus should be by
        /// inspecting the node tree, and then calling [FocusNode.requestFocus] on
        /// the node that has been selected.
        ///
        /// Returns true if it successfully found a node and requested focus.
        ///
        /// The [currentNode] argument must not be null.
        /// </Summary>
        public virtual bool Next(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode) => _MoveFocus(currentNode, forward: true);



        /// <Summary>
        /// Focuses the previous widget in the focus scope that contains the given
        /// [currentNode].
        ///
        /// This should determine what the previous node to receive focus should be by
        /// inspecting the node tree, and then calling [FocusNode.requestFocus] on
        /// the node that has been selected.
        ///
        /// Returns true if it successfully found a node and requested focus.
        ///
        /// The [currentNode] argument must not be null.
        /// </Summary>
        public virtual bool Previous(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode) => _MoveFocus(currentNode, forward: false);



        /// <Summary>
        /// Focuses the next widget in the given [direction] in the focus scope that
        /// contains the given [currentNode].
        ///
        /// This should determine what the next node to receive focus in the given
        /// [direction] should be by inspecting the node tree, and then calling
        /// [FocusNode.requestFocus] on the node that has been selected.
        ///
        /// Returns true if it successfully found a node and requested focus.
        ///
        /// All arguments must not be null.
        /// </Summary>
        public virtual bool InDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, FlutterSDK.Widgets.Focustraversal.TraversalDirection direction)
        {
            return default(bool);
        }


        /// <Summary>
        /// Sorts the given `descendants` into focus order.
        ///
        /// Subclasses should override this to implement a different sort for [next]
        /// and [previous] to use in their ordering. If the returned iterable omits a
        /// node that is a descendant of the given scope, then the user will be unable
        /// to use next/previous keyboard traversal to reach that node, and if that
        /// node is used as the originator of a call to next/previous (i.e. supplied
        /// as the argument to [next] or [previous]), then the next or previous node
        /// will not be able to be determined and the focus will not change.
        ///
        /// This is not used for directional focus ([inDirection]), only for
        /// determining the focus order for [next] and [previous].
        ///
        /// When implementing an override for this function, be sure to use
        /// [mergeSort] instead of Dart's default list sorting algorithm when sorting
        /// items, since the default algorithm is not stable (items deemed to be equal
        /// can appear in arbitrary order, and change positions between sorts), whereas
        /// [mergeSort] is stable.
        /// </Summary>
        public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants)
        {
            return default(Iterable<FocusNode>);
        }


        private FlutterSDK.Widgets.Focustraversal._FocusTraversalGroupMarker _GetMarker(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return context?.GetElementForInheritedWidgetOfExactType()?.Widget as _FocusTraversalGroupMarker;
        }




        private List<FlutterSDK.Widgets.Focusmanager.FocusNode> _SortAllDescendants(FlutterSDK.Widgets.Focusmanager.FocusScopeNode scope)
        {

            _FocusTraversalGroupMarker scopeGroupMarker = _GetMarker(scope.Context);
            FocusTraversalPolicy defaultPolicy = scopeGroupMarker?.Policy ?? new ReadingOrderTraversalPolicy();
            Dictionary<FocusNode, _FocusTraversalGroupInfo> groups = new Dictionary<FocusNode, _FocusTraversalGroupInfo> { };
            foreach (FocusNode node in scope.Descendants)
            {
                _FocusTraversalGroupMarker groupMarker = _GetMarker(node.Context);
                FocusNode groupNode = groupMarker?.FocusNode;
                if (node == groupNode)
                {
                    BuildContext parentContext = FocustraversalDefaultClass._GetAncestor(groupNode.Context, count: 2);
                    _FocusTraversalGroupMarker parentMarker = _GetMarker(parentContext);
                    FocusNode parentNode = parentMarker?.FocusNode;
                    groups[parentNode] = (groups[parentNode] == null ? new _FocusTraversalGroupInfo(parentMarker, members: new List<FocusNode>() { }, defaultPolicy: defaultPolicy) : groups[parentNode]);

                    groups[parentNode].Members.Add(groupNode);
                    continue;
                }

                if (node.CanRequestFocus && !node.SkipTraversal)
                {
                    groups[groupNode] = (groups[groupNode] == null ? new _FocusTraversalGroupInfo(groupMarker, members: new List<FocusNode>() { }, defaultPolicy: defaultPolicy) : groups[groupNode]);

                    groups[groupNode].Members.Add(node);
                }

            }

            HashSet<FocusNode> groupKeys = groups.Keys.ToSet();
            foreach (FocusNode key in groups.Keys)
            {
                List<FocusNode> sortedMembers = groups[key].Policy.SortDescendants(groups[key].Members).ToList();
                groups[key].Members.Clear();
                groups[key].Members.AddAll(sortedMembers);
            }

            List<FocusNode> sortedDescendants = new List<FocusNode>() { };
            void VisitGroups(_FocusTraversalGroupInfo info)
            {
                foreach (FocusNode node in info.Members)
                {
                    if (groupKeys.Contains(node))
                    {
                        VisitGroups(groups[node]);
                    }
                    else
                    {
                        sortedDescendants.Add(node);
                    }

                }

            }

            VisitGroups(groups[scopeGroupMarker?.FocusNode]);


            return sortedDescendants;
        }




        private bool _MoveFocus(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode, bool forward = default(bool))
        {

            if (currentNode == null)
            {
                return false;
            }

            FocusScopeNode nearestScope = currentNode.NearestScope;
            InvalidateScopeData(nearestScope);
            FocusNode focusedChild = nearestScope.FocusedChild;
            if (focusedChild == null)
            {
                FocusNode firstFocus = FindFirstFocus(currentNode);
                if (firstFocus != null)
                {
                    FocustraversalDefaultClass._FocusAndEnsureVisible(firstFocus, alignmentPolicy: forward ? ScrollPositionAlignmentPolicy.KeepVisibleAtEnd : ScrollPositionAlignmentPolicy.KeepVisibleAtStart);
                    return true;
                }

            }

            List<FocusNode> sortedNodes = _SortAllDescendants(nearestScope);
            if (forward && focusedChild == sortedNodes.Last())
            {
                FocustraversalDefaultClass._FocusAndEnsureVisible(sortedNodes.First, alignmentPolicy: ScrollPositionAlignmentPolicy.KeepVisibleAtEnd);
                return true;
            }

            if (!forward && focusedChild == sortedNodes.First)
            {
                FocustraversalDefaultClass._FocusAndEnsureVisible(sortedNodes.Last(), alignmentPolicy: ScrollPositionAlignmentPolicy.KeepVisibleAtStart);
                return true;
            }

            Iterable<FocusNode> maybeFlipped = forward ? sortedNodes : sortedNodes.Reversed;
            FocusNode previousNode = default(FocusNode);
            foreach (FocusNode node in maybeFlipped)
            {
                if (previousNode == focusedChild)
                {
                    FocustraversalDefaultClass._FocusAndEnsureVisible(node, alignmentPolicy: forward ? ScrollPositionAlignmentPolicy.KeepVisibleAtEnd : ScrollPositionAlignmentPolicy.KeepVisibleAtStart);
                    return true;
                }

                previousNode = node;
            }

            return false;
        }



    }


    public class _DirectionalPolicyDataEntry
    {
        public _DirectionalPolicyDataEntry(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction = default(FlutterSDK.Widgets.Focustraversal.TraversalDirection), FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode))
        : base()
        {
            this.Direction = direction;
            this.Node = node;
        }
        public virtual FlutterSDK.Widgets.Focustraversal.TraversalDirection Direction { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Node { get; set; }
    }


    public class _DirectionalPolicyData
    {
        public _DirectionalPolicyData(List<FlutterSDK.Widgets.Focustraversal._DirectionalPolicyDataEntry> history = default(List<FlutterSDK.Widgets.Focustraversal._DirectionalPolicyDataEntry>))
        : base()
        {
            this.History = history;
        }
        /// <Summary>
        /// A queue of entries that describe the path taken to the current node.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Focustraversal._DirectionalPolicyDataEntry> History { get; set; }
    }


    /// <Summary>
    /// A [FocusTraversalPolicy] that traverses the focus order in widget hierarchy
    /// order.
    ///
    /// This policy is used when the order desired is the order in which widgets are
    /// created in the widget hierarchy.
    ///
    /// See also:
    ///
    ///  * [FocusNode], for a description of the focus system.
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [ReadingOrderTraversalPolicy], a policy that describes the order as the
    ///    natural "reading order" for the current [Directionality].
    ///  * [DirectionalFocusTraversalPolicyMixin] a mixin class that implements
    ///    focus traversal in a direction.
    ///  * [OrderedTraversalPolicy], a policy that describes the order
    ///    explicitly using [FocusTraversalOrder] widgets.
    /// </Summary>
    public class WidgetOrderTraversalPolicy : FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy, IDirectionalFocusTraversalPolicyMixin
    {
        public WidgetOrderTraversalPolicy()
        { }

        public new Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants) => descendants;


    }


    public class _ReadingOrderSortData : IDiagnosticable
    {
        public _ReadingOrderSortData(FlutterSDK.Widgets.Focusmanager.FocusNode node)
        : base()
        {
            this.Node = node;
        }
        public virtual TextDirection Directionality { get; set; }
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Node { get; set; }
        internal virtual List<FlutterSDK.Widgets.Basic.Directionality> _DirectionalAncestors { get; set; }
        public virtual Iterable<FlutterSDK.Widgets.Basic.Directionality> DirectionalAncestors { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private TextDirection _FindDirectionality(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return (context.GetElementForInheritedWidgetOfExactType()?.Widget as Directionality)?.TextDirection;
        }




        /// <Summary>
        /// Finds the common Directional ancestor of an entire list of groups.
        /// </Summary>
        public virtual TextDirection CommonDirectionalityOf(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> list)
        {
            Iterable<HashSet<Directionality>> allAncestors = list.Map((_ReadingOrderSortData member) => =>member.DirectionalAncestors.ToSet());
            HashSet<Directionality> common = default(HashSet<Directionality>);
            foreach (HashSet<Directionality> ancestorSet in allAncestors)
            {
                common = (common == null ? ancestorSet : common);
                common = common.Intersection(ancestorSet);
            }

            if (common.IsEmpty())
            {
                return list.First.Directionality;
            }

            return list.First.DirectionalAncestors.FirstWhere(common.Contains).TextDirection;
        }




        public virtual void SortWithDirectionality(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> list, TextDirection directionality)
        {
            MergeSort(list, Compare: (_ReadingOrderSortData a, _ReadingOrderSortData b) =>
            {
                switch (directionality) { case TextDirection.Ltr: return a.Rect.Left.CompareTo(b.Rect.Left); case TextDirection.Rtl: return b.Rect.Right.CompareTo(a.Rect.Right); }

                return 0;
            }
            );
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<TextDirection>("directionality", Directionality));
            properties.Add(new StringProperty("name", Node.DebugLabel, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Rect>("rect", Rect));
        }



    }


    public class _ReadingOrderDirectionalGroupData : IDiagnosticable
    {
        public _ReadingOrderDirectionalGroupData(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> members)
        {
            this.Members = members;
        }
        public virtual List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> Members { get; set; }
        internal virtual FlutterBinding.UI.Rect _Rect { get; set; }
        internal virtual List<FlutterSDK.Widgets.Basic.Directionality> _MemberAncestors { get; set; }
        public virtual TextDirection Directionality { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<FlutterSDK.Widgets.Basic.Directionality> MemberAncestors { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual void SortWithDirectionality(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderDirectionalGroupData> list, TextDirection directionality)
        {
            MergeSort(list, Compare: (_ReadingOrderDirectionalGroupData a, _ReadingOrderDirectionalGroupData b) =>
            {
                switch (directionality) { case TextDirection.Ltr: return a.Rect.Left.CompareTo(b.Rect.Left); case TextDirection.Rtl: return b.Rect.Right.CompareTo(a.Rect.Right); }

                return 0;
            }
            );
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<TextDirection>("directionality", Directionality));
            properties.Add(new DiagnosticsProperty<Rect>("rect", Rect));
            properties.Add(new IterableProperty<string>("members", Members.Map((_ReadingOrderSortData member) =>
            {
                return $"'"{ member.Node.DebugLabel}
                "({member.Rect})'";
            }
            )));
        }



    }


    /// <Summary>
    /// Traverses the focus order in "reading order".
    ///
    /// By default, reading order traversal goes in the reading direction, and then
    /// down, using this algorithm:
    ///
    /// 1. Find the node rectangle that has the highest `top` on the screen.
    /// 2. Find any other nodes that intersect the infinite horizontal band defined
    ///    by the highest rectangle's top and bottom edges.
    /// 3. Pick the closest to the beginning of the reading order from among the
    ///    nodes discovered above.
    ///
    /// It uses the ambient [Directionality] in the context for the enclosing
    /// [FocusTraversalGroup] to determine which direction is "reading order".
    ///
    /// See also:
    ///
    ///  * [FocusNode], for a description of the focus system.
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [WidgetOrderTraversalPolicy], a policy that relies on the widget
    ///    creation order to describe the order of traversal.
    ///  * [DirectionalFocusTraversalPolicyMixin] a mixin class that implements
    ///    focus traversal in a direction.
    ///  * [OrderedTraversalPolicy], a policy that describes the order
    ///    explicitly using [FocusTraversalOrder] widgets.
    /// </Summary>
    public class ReadingOrderTraversalPolicy : FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy, IDirectionalFocusTraversalPolicyMixin
    {
        public ReadingOrderTraversalPolicy()
        { }

        private List<FlutterSDK.Widgets.Focustraversal._ReadingOrderDirectionalGroupData> _CollectDirectionalityGroups(Iterable<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> candidates)
        {
            TextDirection currentDirection = candidates.First.Directionality;
            List<_ReadingOrderSortData> currentGroup = new List<_ReadingOrderSortData>() { };
            List<_ReadingOrderDirectionalGroupData> result = new List<_ReadingOrderDirectionalGroupData>() { };
            foreach (_ReadingOrderSortData candidate in candidates)
            {
                if (candidate.Directionality == currentDirection)
                {
                    currentGroup.Add(candidate);
                    continue;
                }

                currentDirection = candidate.Directionality;
                result.Add(new _ReadingOrderDirectionalGroupData(currentGroup));
                currentGroup = new List<_ReadingOrderSortData>() { candidate };
            }

            if (currentGroup.IsNotEmpty)
            {
                result.Add(new _ReadingOrderDirectionalGroupData(currentGroup));
            }

            foreach (_ReadingOrderDirectionalGroupData bandGroup in result)
            {
                if (bandGroup.Members.Count == 1)
                {
                    continue;
                }

                FocustraversalDefaultClass._ReadingOrderSortData.SortWithDirectionality(bandGroup.Members, bandGroup.Directionality);
            }

            return result;
        }




        private FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData _PickNext(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> candidates)
        {
            MergeSort(candidates, Compare: (_ReadingOrderSortData a, _ReadingOrderSortData b) => =>a.Rect.Top.CompareTo(b.Rect.Top));
            _ReadingOrderSortData topmost = candidates.First;
            List<_ReadingOrderSortData> InBand(_ReadingOrderSortData current, Iterable<_ReadingOrderSortData> candidates)
            {
                Rect band = Rect.FromLTRB(Dart.CoreDefaultClass.Double.NegativeInfinity, current.Rect.Top, Dart.CoreDefaultClass.Double.Infinity, current.Rect.Bottom);
                return candidates.Where((_ReadingOrderSortData item) =>
                {
                    return !item.Rect.Intersect(band).IsEmpty();
                }
                ).ToList();
            }

            List<_ReadingOrderSortData> inBandOfTop = InBand(topmost, candidates);

            if (inBandOfTop.Count <= 1)
            {
                return topmost;
            }

            TextDirection nearestCommonDirectionality = FocustraversalDefaultClass._ReadingOrderSortData.CommonDirectionalityOf(inBandOfTop);
            FocustraversalDefaultClass._ReadingOrderSortData.SortWithDirectionality(inBandOfTop, nearestCommonDirectionality);
            List<_ReadingOrderDirectionalGroupData> bandGroups = _CollectDirectionalityGroups(inBandOfTop);
            if (bandGroups.Count == 1)
            {
                return bandGroups.First.Members.First;
            }

            FocustraversalDefaultClass._ReadingOrderDirectionalGroupData.SortWithDirectionality(bandGroups, nearestCommonDirectionality);
            return bandGroups.First.Members.First;
        }




        public new Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants)
        {

            if (descendants.Length <= 1)
            {
                return descendants;
            }

            List<_ReadingOrderSortData> data = new List<_ReadingOrderSortData>() { };
            List<FocusNode> sortedList = new List<FocusNode>() { };
            List<_ReadingOrderSortData> unplaced = data;
            _ReadingOrderSortData current = _PickNext(unplaced);
            sortedList.Add(current.Node);
            unplaced.Remove(current);
            while (unplaced.IsNotEmpty)
            {
                _ReadingOrderSortData next = _PickNext(unplaced);
                current = next;
                sortedList.Add(current.Node);
                unplaced.Remove(current);
            }

            return sortedList;
        }



    }


    /// <Summary>
    /// Base class for all sort orders for [OrderedTraversalPolicy] traversal.
    ///
    /// {@template flutter.widgets.focusorder.comparable}
    /// Only orders of the same type are comparable. If a set of widgets in the same
    /// [FocusTraversalGroup] contains orders that are not comparable with each other, it
    /// will assert, since the ordering between such keys is undefined. To avoid
    /// collisions, use a [FocusTraversalGroup] to group similarly ordered widgets
    /// together.
    ///
    /// When overriding, [doCompare] must be overridden instead of [compareTo],
    /// which calls [doCompare] to do the actual comparison.
    /// {@endtemplate}
    ///
    /// See also:
    ///
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [FocusTraversalOrder], a widget that assigns an order to a widget subtree
    ///    for the [OrderedFocusTraversalPolicy] to use.
    ///  * [NumericFocusOrder], for a focus order that describes its order with a
    ///    `double`.
    ///  * [LexicalFocusOrder], a focus order that assigns a string-based lexical
    ///    traversal order to a [FocusTraversalOrder] widget.
    /// </Summary>
    public class FocusOrder : IComparable<FlutterSDK.Widgets.Focustraversal.FocusOrder>, IDiagnosticable
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public FocusOrder()
        {

        }

        /// <Summary>
        /// Compares this object to another [Comparable].
        ///
        /// When overriding [FocusOrder], implement [doCompare] instead of this
        /// function to do the actual comparison.
        ///
        /// Returns a value like a [Comparator] when comparing `this` to [other].
        /// That is, it returns a negative integer if `this` is ordered before [other],
        /// a positive integer if `this` is ordered after [other],
        /// and zero if `this` and [other] are ordered together.
        ///
        /// The [other] argument must be a value that is comparable to this object.
        /// </Summary>
        public new int CompareTo(FlutterSDK.Widgets.Focustraversal.FocusOrder other)
        {

            return DoCompare(other);
        }




        /// <Summary>
        /// The subclass implementation called by [compareTo] to compare orders.
        ///
        /// The argument is guaranteed to be of the same [runtimeType] as this object.
        ///
        /// The method should return a negative number if this object comes earlier in
        /// the sort order than the `other` argument; and a positive number if it
        /// comes later in the sort order than `other`. Returning zero causes the
        /// system to fall back to the secondary sort order defined by
        /// [OrderedTraversalPolicy.secondary]
        /// </Summary>
        public virtual int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other)
        {
            return default(int);
        }

    }


    /// <Summary>
    /// Can be given to a [FocusTraversalOrder] widget to assign a numerical order
    /// to a widget subtree that is using a [OrderedTraversalPolicy] to define the
    /// order in which widgets should be traversed with the keyboard.
    ///
    /// {@macro flutter.widgets.focusorder.comparable}
    ///
    /// See also:
    ///
    ///  * [FocusTraversalOrder], a widget that assigns an order to a widget subtree
    ///    for the [OrderedFocusTraversalPolicy] to use.
    /// </Summary>
    public class NumericFocusOrder : FlutterSDK.Widgets.Focustraversal.FocusOrder
    {
        /// <Summary>
        /// Const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public NumericFocusOrder(double order)
        : base()
        {
            this.Order = order;
        }
        /// <Summary>
        /// The numerical order to assign to the widget subtree using
        /// [FocusTraversalOrder].
        ///
        /// Determines the placement of this widget in a sequence of widgets that defines
        /// the order in which this node is traversed by the focus policy.
        ///
        /// Lower values will be traversed first.
        /// </Summary>
        public virtual double Order { get; set; }

        public new int DoCompare(FlutterSDK.Widgets.Focustraversal.NumericFocusOrder other) => Order.CompareTo(other.Order);

        public new int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other) => Order.CompareTo(other.Order);



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DoubleProperty("order", Order));
        }



    }


    /// <Summary>
    /// Can be given to a [FocusTraversalOrder] widget to use a String to assign a
    /// lexical order to a widget subtree that is using a
    /// [OrderedTraversalPolicy] to define the order in which widgets should be
    /// traversed with the keyboard.
    ///
    /// This sorts strings using Dart's default string comparison, which is not
    /// locale specific.
    ///
    /// {@macro flutter.widgets.focusorder.comparable}
    ///
    /// See also:
    ///
    ///  * [FocusTraversalOrder], a widget that assigns an order to a widget subtree
    ///    for the [OrderedFocusTraversalPolicy] to use.
    /// </Summary>
    public class LexicalFocusOrder : FlutterSDK.Widgets.Focustraversal.FocusOrder
    {
        /// <Summary>
        /// Const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public LexicalFocusOrder(string order)
        : base()
        {
            this.Order = order;
        }
        /// <Summary>
        /// The String that defines the lexical order to assign to the widget subtree
        /// using [FocusTraversalOrder].
        ///
        /// Determines the placement of this widget in a sequence of widgets that defines
        /// the order in which this node is traversed by the focus policy.
        ///
        /// Lower lexical values will be traversed first (e.g. 'a' comes before 'z').
        /// </Summary>
        public virtual string Order { get; set; }

        public new int DoCompare(FlutterSDK.Widgets.Focustraversal.LexicalFocusOrder other) => Order.CompareTo(other.Order);

        public new int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other) => Order.CompareTo(other.Order);



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("order", Order));
        }



    }


    public class _OrderedFocusInfo
    {
        public _OrderedFocusInfo(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Focustraversal.FocusOrder order = default(FlutterSDK.Widgets.Focustraversal.FocusOrder))
        : base()
        {
            this.Node = node;
            this.Order = order;
        }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Node { get; set; }
        public virtual FlutterSDK.Widgets.Focustraversal.FocusOrder Order { get; set; }
    }


    /// <Summary>
    /// A [FocusTraversalPolicy] that orders nodes by an explicit order that resides
    /// in the nearest [FocusTraversalOrder] widget ancestor.
    ///
    /// {@macro flutter.widgets.focusorder.comparable}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold_center}
    /// This sample shows how to assign a traversal order to a widget. In the
    /// example, the focus order goes from bottom right (the "One" button) to top
    /// left (the "Six" button).
    ///
    /// ```dart preamble
    /// class DemoButton extends StatelessWidget {
    ///   const DemoButton({this.name, this.autofocus = false, this.order});
    ///
    ///   final String name;
    ///   final bool autofocus;
    ///   final double order;
    ///
    ///   void _handleOnPressed() {
    ///     print('Button $name pressed.');
    ///     debugDumpFocusTree();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return FocusTraversalOrder(
    ///       order: NumericFocusOrder(order),
    ///       child: FlatButton(
    ///         autofocus: autofocus,
    ///         focusColor: Colors.red,
    ///         onPressed: () => _handleOnPressed(),
    ///         child: Text(name),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return FocusTraversalGroup(
    ///     policy: OrderedTraversalPolicy(),
    ///     child: Column(
    ///       mainAxisAlignment: MainAxisAlignment.center,
    ///       children: <Widget>[
    ///         Row(
    ///           mainAxisAlignment: MainAxisAlignment.center,
    ///           children: const <Widget>[
    ///             DemoButton(name: 'Six', order: 6),
    ///           ],
    ///         ),
    ///         Row(
    ///           mainAxisAlignment: MainAxisAlignment.center,
    ///           children: const <Widget>[
    ///             DemoButton(name: 'Five', order: 5),
    ///             DemoButton(name: 'Four', order: 4),
    ///           ],
    ///         ),
    ///         Row(
    ///           mainAxisAlignment: MainAxisAlignment.center,
    ///           children: const <Widget>[
    ///             DemoButton(name: 'Three', order: 3),
    ///             DemoButton(name: 'Two', order: 2),
    ///             DemoButton(name: 'One', order: 1, autofocus: true),
    ///           ],
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
    ///  * [FocusTraversalGroup], a widget that groups together and imposes a
    ///    traversal policy on the [Focus] nodes below it in the widget hierarchy.
    ///  * [WidgetOrderTraversalPolicy], a policy that relies on the widget
    ///    creation order to describe the order of traversal.
    ///  * [ReadingOrderTraversalPolicy], a policy that describes the order as the
    ///    natural "reading order" for the current [Directionality].
    ///  * [NumericFocusOrder], a focus order that assigns a numeric traversal order
    ///    to a [FocusTraversalOrder] widget.
    ///  * [LexicalFocusOrder], a focus order that assigns a string-based lexical
    ///    traversal order to a [FocusTraversalOrder] widget.
    ///  * [FocusOrder], an abstract base class for all types of focus traversal
    ///    orderings.
    /// </Summary>
    public class OrderedTraversalPolicy : FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy, IDirectionalFocusTraversalPolicyMixin
    {
        /// <Summary>
        /// Constructs a traversal policy that orders widgets for keyboard traversal
        /// based on an explicit order.
        ///
        /// If [secondary] is null, it will default to [ReadingOrderTraversalPolicy].
        /// </Summary>
        public OrderedTraversalPolicy(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy secondary = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy))
        {
            this.Secondary = secondary;
        }
        /// <Summary>
        /// This is the policy that is used when a node doesn't have an order
        /// assigned, or when multiple nodes have orders which are identical.
        ///
        /// If not set, this defaults to [ReadingOrderTraversalPolicy].
        ///
        /// This policy determines the secondary sorting order of nodes which evaluate
        /// as having an identical order (including those with no order specified).
        ///
        /// Nodes with no order specified will be sorted after nodes with an explicit
        /// order.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Secondary { get; set; }

        public new Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants)
        {
            FocusTraversalPolicy secondaryPolicy = Secondary ?? new ReadingOrderTraversalPolicy();
            Iterable<FocusNode> sortedDescendants = secondaryPolicy.SortDescendants(descendants);
            List<FocusNode> unordered = new List<FocusNode>() { };
            List<_OrderedFocusInfo> ordered = new List<_OrderedFocusInfo>() { };
            foreach (FocusNode node in sortedDescendants)
            {
                FocusOrder order = FocustraversalDefaultClass.FocusTraversalOrder.Of(node.Context, nullOk: true);
                if (order != null)
                {
                    ordered.Add(new _OrderedFocusInfo(node: node, order: order));
                }
                else
                {
                    unordered.Add(node);
                }

            }

            MergeSort(ordered, Compare: (_OrderedFocusInfo a, _OrderedFocusInfo b) =>
            {

                return a.Order.CompareTo(b.Order);
            }
            );
            return ordered.Map((_OrderedFocusInfo info) => =>info.Node).FollowedBy(unordered);
        }



    }


    /// <Summary>
    /// An inherited widget that describes the order in which its child subtree
    /// should be traversed.
    ///
    /// {@macro flutter.widgets.focusorder.comparable}
    ///
    /// The order for a widget is determined by the [FocusOrder] returned by
    /// [FocusTraversalOrder.of] for a particular context.
    /// </Summary>
    public class FocusTraversalOrder : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        /// <Summary>
        /// A const constructor so that subclasses can be const.
        /// </Summary>
        public FocusTraversalOrder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Focustraversal.FocusOrder order = default(FlutterSDK.Widgets.Focustraversal.FocusOrder), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Order = order;
        }
        /// <Summary>
        /// The order for the widget descendants of this [FocusTraversalOrder].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focustraversal.FocusOrder Order { get; set; }

        /// <Summary>
        /// Finds the [FocusOrder] in the nearest ancestor [FocusTraversalOrder] widget.
        ///
        /// It does not create a rebuild dependency because changing the traversal
        /// order doesn't change the widget tree, so nothing needs to be rebuilt as a
        /// result of an order change.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focustraversal.FocusOrder Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {


            FocusTraversalOrder marker = context.GetElementForInheritedWidgetOfExactType()?.Widget as FocusTraversalOrder;
            FocusOrder order = marker?.Order;
            if (order == null && !nullOk)
            {
                throw new FlutterError("FocusTraversalOrder.of() was called with a context that " + "does not contain a TraversalOrder widget. No TraversalOrder widget " + "ancestor could be found starting from the context that was passed to " + "FocusTraversalOrder.of().\n" + "The context used was:\n" + $"'  {context}'");
            }

            return order;
        }




        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => false;



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<FocusOrder>("order", Order));
        }



    }


    /// <Summary>
    /// A widget that describes the inherited focus policy for focus traversal for
    /// its descendants, grouping them into a separate traversal group.
    ///
    /// A traversal group is treated as one entity when sorted by the traversal
    /// algorithm, so it can be used to segregate different parts of the widget tree
    /// that need to be sorted using different algorithms and/or sort orders when
    /// using an [OrderedTraversalPolicy].
    ///
    /// Within the group, it will use the given [policy] to order the elements. The
    /// group itself will be ordered using the parent group's policy.
    ///
    /// By default, traverses in reading order using [ReadingOrderTraversalPolicy].
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This sample shows three rows of buttons, each grouped by a
    /// [FocusTraversalGroup], each with different traversal order policies. Use tab
    /// traversal to see the order they are traversed in.  The first row follows a
    /// numerical order, the second follows a lexical order (ordered to traverse
    /// right to left), and the third ignores the numerical order assigned to it and
    /// traverses in widget order.
    ///
    /// ```dart preamble
    /// /// A button wrapper that adds either a numerical or lexical order, depending on
    /// /// the type of T.
    /// class OrderedButton<T> extends StatefulWidget {
    ///   const OrderedButton({
    ///     this.name,
    ///     this.canRequestFocus = true,
    ///     this.autofocus = false,
    ///     this.order,
    ///   });
    ///
    ///   final String name;
    ///   final bool canRequestFocus;
    ///   final bool autofocus;
    ///   final T order;
    ///
    ///   @override
    ///   _OrderedButtonState createState() => _OrderedButtonState();
    /// }
    ///
    /// class _OrderedButtonState<T> extends State<OrderedButton<T>> {
    ///   FocusNode focusNode;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     focusNode = FocusNode(
    ///       debugLabel: widget.name,
    ///       canRequestFocus: widget.canRequestFocus,
    ///     );
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     focusNode?.dispose();
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   void didUpdateWidget(OrderedButton oldWidget) {
    ///     super.didUpdateWidget(oldWidget);
    ///     focusNode.canRequestFocus = widget.canRequestFocus;
    ///   }
    ///
    ///   void _handleOnPressed() {
    ///     focusNode.requestFocus();
    ///     print('Button ${widget.name} pressed.');
    ///     debugDumpFocusTree();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     FocusOrder order;
    ///     if (widget.order is num) {
    ///       order = NumericFocusOrder((widget.order as num).toDouble());
    ///     } else {
    ///       order = LexicalFocusOrder(widget.order.toString());
    ///     }
    ///
    ///     return FocusTraversalOrder(
    ///       order: order,
    ///       child: Padding(
    ///         padding: const EdgeInsets.all(8.0),
    ///         child: OutlineButton(
    ///           focusNode: focusNode,
    ///           autofocus: widget.autofocus,
    ///           focusColor: Colors.red,
    ///           hoverColor: Colors.blue,
    ///           onPressed: () => _handleOnPressed(),
    ///           child: Text(widget.name),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Container(
    ///     color: Colors.white,
    ///     child: FocusTraversalGroup(
    ///       policy: OrderedTraversalPolicy(),
    ///       child: Column(
    ///         mainAxisAlignment: MainAxisAlignment.center,
    ///         children: <Widget>[
    ///           // A group that is ordered with a numerical order, from left to right.
    ///           FocusTraversalGroup(
    ///             policy: OrderedTraversalPolicy(),
    ///             child: Row(
    ///               mainAxisAlignment: MainAxisAlignment.center,
    ///               children: List<Widget>.generate(3, (int index) {
    ///                 return OrderedButton<num>(
    ///                   name: 'num: $index',
    ///                   // TRY THIS: change this to "3 - index" and see how the order changes.
    ///                   order: index,
    ///                 );
    ///               }),
    ///             ),
    ///           ),
    ///           // A group that is ordered with a lexical order, from right to left.
    ///           FocusTraversalGroup(
    ///             policy: OrderedTraversalPolicy(),
    ///             child: Row(
    ///               mainAxisAlignment: MainAxisAlignment.center,
    ///               children: List<Widget>.generate(3, (int index) {
    ///                 // Order as "C" "B", "A".
    ///                 String order =
    ///                     String.fromCharCode('A'.codeUnitAt(0) + (2 - index));
    ///                 return OrderedButton<String>(
    ///                   name: 'String: $order',
    ///                   order: order,
    ///                 );
    ///               }),
    ///             ),
    ///           ),
    ///           // A group that orders in widget order, regardless of what the order is set to.
    ///           FocusTraversalGroup(
    ///             // Note that because this is NOT an OrderedTraversalPolicy, the
    ///             // assigned order of these OrderedButtons is ignored, and they
    ///             // are traversed in widget order. TRY THIS: change this to
    ///             // "OrderedTraversalPolicy()" and see that it now follows the
    ///             // numeric order set on them instead of the widget order.
    ///             policy: WidgetOrderTraversalPolicy(),
    ///             child: Row(
    ///               mainAxisAlignment: MainAxisAlignment.center,
    ///               children: List<Widget>.generate(3, (int index) {
    ///                 return OrderedButton<num>(
    ///                   name: 'ignored num: ${3 - index}',
    ///                   order: 3 - index,
    ///                 );
    ///               }),
    ///             ),
    ///           ),
    ///         ],
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [FocusNode], for a description of the focus system.
    ///  * [WidgetOrderTraversalPolicy], a policy that relies on the widget
    ///    creation order to describe the order of traversal.
    ///  * [ReadingOrderTraversalPolicy], a policy that describes the order as the
    ///    natural "reading order" for the current [Directionality].
    ///  * [DirectionalFocusTraversalPolicyMixin] a mixin class that implements
    ///    focus traversal in a direction.
    /// </Summary>
    public class FocusTraversalGroup : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a [FocusTraversalGroup] object.
        ///
        /// The [child] argument must not be null.
        /// </Summary>
        public FocusTraversalGroup(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy policy = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        /// <Summary>
        /// The child widget of this [FocusTraversalGroup].
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The policy used to move the focus from one focus node to another when
        /// traversing them using a keyboard.
        ///
        /// If not specified, traverses in reading order using
        /// [ReadingOrderTraversalPolicy].
        ///
        /// See also:
        ///
        ///  * [FocusTraversalPolicy] for the API used to impose traversal order
        ///    policy.
        ///  * [WidgetOrderTraversalPolicy] for a traversal policy that traverses
        ///    nodes in the order they are added to the widget tree.
        ///  * [ReadingOrderTraversalPolicy] for a traversal policy that traverses
        ///    nodes in the reading order defined in the widget tree, and then top to
        ///    bottom.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Policy { get; set; }

        /// <Summary>
        /// Returns the focus policy set by the [FocusTraversalGroup] that most
        /// tightly encloses the given [BuildContext].
        ///
        /// It does not create a rebuild dependency because changing the traversal
        /// order doesn't change the widget tree, so nothing needs to be rebuilt as a
        /// result of an order change.
        ///
        /// Will assert if no [FocusTraversalGroup] ancestor is found, and `nullOk` is false.
        ///
        /// If `nullOk` is true, then it will return null if it doesn't find a
        /// [FocusTraversalGroup] ancestor.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {

            _FocusTraversalGroupMarker inherited = context?.DependOnInheritedWidgetOfExactType();

            return inherited?.Policy;
        }




        public new FlutterSDK.Widgets.Focustraversal._FocusTraversalGroupState CreateState() => new _FocusTraversalGroupState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<FocusTraversalPolicy>("policy", Policy));
        }



    }


    public class _FocusTraversalGroupState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Focustraversal.FocusTraversalGroup>
    {
        public _FocusTraversalGroupState()
        { }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }

        public new void InitState()
        {
            base.InitState();
            FocusNode = new FocusNode(canRequestFocus: false, skipTraversal: true, debugLabel: "FocusTraversalGroup");
        }




        public new void Dispose()
        {
            FocusNode?.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _FocusTraversalGroupMarker(policy: Widget.Policy, focusNode: FocusNode, child: new Focus(focusNode: FocusNode, canRequestFocus: false, skipTraversal: true, includeSemantics: false, child: Widget.Child));
        }



    }


    public class _FocusTraversalGroupMarker : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        public _FocusTraversalGroupMarker(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy policy = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(child: child)
        {
            this.Policy = policy;
            this.FocusNode = focusNode;
        }
        public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Policy { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => false;


    }


    public class _RequestFocusActionBase : FlutterSDK.Widgets.Actions.Action
    {
        public _RequestFocusActionBase(FlutterSDK.Foundation.Key.LocalKey name)
        : base(name)
        {

        }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _PreviousFocus { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
            _PreviousFocus = FocusmanagerDefaultClass.PrimaryFocus;
            node.RequestFocus();
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<FocusNode>("previous", _PreviousFocus));
        }



    }


    /// <Summary>
    /// An [Action] that requests the focus on the node it is invoked on.
    ///
    /// This action can be used to request focus for a particular node, by calling
    /// [Action.invoke] like so:
    ///
    /// ```dart
    /// Actions.invoke(context, const Intent(RequestFocusAction.key), focusNode: _focusNode);
    /// ```
    ///
    /// Where the `_focusNode` is the node for which the focus will be requested.
    ///
    /// The difference between requesting focus in this way versus calling
    /// [_focusNode.requestFocus] directly is that it will use the [Action]
    /// registered in the nearest [Actions] widget associated with [key] to make the
    /// request, rather than just requesting focus directly. This allows the action
    /// to have additional side effects, like logging, or undo and redo
    /// functionality.
    ///
    /// However, this [RequestFocusAction] is the default action associated with the
    /// [key] in the [WidgetsApp], and it simply requests focus and has no side
    /// effects.
    /// </Summary>
    public class RequestFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
    {
        /// <Summary>
        /// Creates a [RequestFocusAction] with a fixed [key].
        /// </Summary>
        public RequestFocusAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely identifies this action to an [Intent].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent) => FocustraversalDefaultClass._FocusAndEnsureVisible(node);


    }


    /// <Summary>
    /// An [Action] that moves the focus to the next focusable node in the focus
    /// order.
    ///
    /// This action is the default action registered for the [key], and by default
    /// is bound to the [LogicalKeyboardKey.tab] key in the [WidgetsApp].
    /// </Summary>
    public class NextFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
    {
        /// <Summary>
        /// Creates a [NextFocusAction] with a fixed [key];
        /// </Summary>
        public NextFocusAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely identifies this action to an [Intent].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent) => node.NextFocus();


    }


    /// <Summary>
    /// An [Action] that moves the focus to the previous focusable node in the focus
    /// order.
    ///
    /// This action is the default action registered for the [key], and by default
    /// is bound to a combination of the [LogicalKeyboardKey.tab] key and the
    /// [LogicalKeyboardKey.shift] key in the [WidgetsApp].
    /// </Summary>
    public class PreviousFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
    {
        /// <Summary>
        /// Creates a [PreviousFocusAction] with a fixed [key];
        /// </Summary>
        public PreviousFocusAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely identifies this action to an [Intent].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent) => node.PreviousFocus();


    }


    /// <Summary>
    /// An [Intent] that represents moving to the next focusable node in the given
    /// [direction].
    ///
    /// This is the [Intent] bound by default to the [LogicalKeyboardKey.arrowUp],
    /// [LogicalKeyboardKey.arrowDown], [LogicalKeyboardKey.arrowLeft], and
    /// [LogicalKeyboardKey.arrowRight] keys in the [WidgetsApp], with the
    /// appropriate associated directions.
    /// </Summary>
    public class DirectionalFocusIntent : FlutterSDK.Widgets.Actions.Intent
    {
        /// <Summary>
        /// Creates a [DirectionalFocusIntent] with a fixed [key], and the given
        /// [direction].
        /// </Summary>
        public DirectionalFocusIntent(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction, bool ignoreTextFields = true)
        : base(FocustraversalDefaultClass.DirectionalFocusAction.Key)
        {
            this.Direction = direction;
            this.IgnoreTextFields = ignoreTextFields;
        }
        /// <Summary>
        /// The direction in which to look for the next focusable node when the
        /// associated [DirectionalFocusAction] is invoked.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focustraversal.TraversalDirection Direction { get; set; }
        /// <Summary>
        /// If true, then directional focus actions that occur within a text field
        /// will not happen when the focus node which received the key is a text
        /// field.
        ///
        /// Defaults to true.
        /// </Summary>
        public virtual bool IgnoreTextFields { get; set; }
    }


    /// <Summary>
    /// An [Action] that moves the focus to the focusable node in the direction
    /// configured by the associated [DirectionalFocusIntent.direction].
    ///
    /// This is the [Action] associated with the [key] and bound by default to the
    /// [LogicalKeyboardKey.arrowUp], [LogicalKeyboardKey.arrowDown],
    /// [LogicalKeyboardKey.arrowLeft], and [LogicalKeyboardKey.arrowRight] keys in
    /// the [WidgetsApp], with the appropriate associated directions.
    /// </Summary>
    public class DirectionalFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
    {
        /// <Summary>
        /// Creates a [DirectionalFocusAction] with a fixed [key];
        /// </Summary>
        public DirectionalFocusAction()
        : base(Key)
        {

        }
        /// <Summary>
        /// The [LocalKey] that uniquely identifies this action to [DirectionalFocusIntent].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }

        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Focustraversal.DirectionalFocusIntent intent)
        {
            if (!intent.IgnoreTextFields || !(node.Context.Widget is EditableText))
            {
                node.FocusInDirection(intent.Direction);
            }

        }


        public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
            if (!intent.IgnoreTextFields || !(node.Context.Widget is EditableText))
            {
                node.FocusInDirection(intent.Direction);
            }

        }



    }


    /// <Summary>
    /// A direction along either the horizontal or vertical axes.
    ///
    /// This is used by the [DirectionalFocusTraversalPolicyMixin], and
    /// [Focus.focusInDirection] to indicate which direction to look in for the next
    /// focus.
    /// </Summary>
    public enum TraversalDirection
    {

        /// <Summary>
        /// Indicates a direction above the currently focused widget.
        /// </Summary>
        Up,
        /// <Summary>
        /// Indicates a direction to the right of the currently focused widget.
        ///
        /// This direction is unaffected by the [Directionality] of the current
        /// context.
        /// </Summary>
        Right,
        /// <Summary>
        /// Indicates a direction below the currently focused widget.
        /// </Summary>
        Down,
        /// <Summary>
        /// Indicates a direction to the left of the currently focused widget.
        ///
        /// This direction is unaffected by the [Directionality] of the current
        /// context.
        /// </Summary>
        Left,
    }

}
